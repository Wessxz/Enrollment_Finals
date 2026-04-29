Imports MySql.Data.MySqlClient

Public Class CashierForm
    ' Global configuration
    Private requiredDownpayment As Decimal = 3000.0

    Private Sub CashierForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            ' Initial UI State
            txtBalance.Text = "Balance: ₱0.00"
            txtPaid.Text = "0.00"
            txtCashier.Text = UserSession.CurrentUsername
            txtTransactionDate.Text = DateTime.Now.ToString("yyyy-MM-dd")

            LoadStudentIDs()
            LoadPayments()
        Catch ex As Exception
            MsgBox("Startup Error: " & ex.Message)
        End Try
    End Sub

    ' ================= 1. AUTOMATED FIELDS =================
    Private Sub GenerateAutoPaymentDetails()
        Try
            openCon()
            ' Prevents "Duplicate Entry" by finding the true maximum OR number
            Dim query As String = "SELECT MAX(CAST(or_number AS UNSIGNED)) FROM payments"
            Using cmd As New MySqlCommand(query, conn)
                Dim result = cmd.ExecuteScalar()
                Dim nextNumber As Integer = 1

                If result IsNot DBNull.Value AndAlso result IsNot Nothing Then
                    nextNumber = Convert.ToInt32(result) + 1
                End If

                txtOR.Text = nextNumber.ToString("D6")
            End Using
        Catch ex As Exception
            txtOR.Text = "000001"
        Finally
            closeCon()
        End Try
    End Sub

    ' ================= 2. DATA LOADING =================
    Private Sub LoadStudentIDs()
        Try
            openCon()
            Dim query As String = "SELECT DISTINCT student_id FROM billing WHERE status <> 'PAID'"
            Dim da As New MySqlDataAdapter(query, conn)
            Dim dt As New DataTable
            da.Fill(dt)

            cmbStudentID.DataSource = dt
            cmbStudentID.DisplayMember = "student_id"
            cmbStudentID.ValueMember = "student_id"
            cmbStudentID.SelectedIndex = -1
            ClearFields()
        Finally
            closeCon()
        End Try
    End Sub

    ' ================= 3. AUTO-FILL AND GATEKEEPER LOGIC =================
    Private Sub cmbStudentID_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbStudentID.SelectedIndexChanged
        If cmbStudentID.SelectedIndex = -1 OrElse cmbStudentID.SelectedValue Is Nothing Then
            ClearFields()
            Return
        End If

        Try
            openCon()
            ' Includes payment_mode to handle auto-fill requirements
            Dim query As String = "SELECT s.first_name, s.last_name, s.course, b.balance, b.status, b.billing_id, b.total_amount, b.payment_mode " &
                                 "FROM billing b INNER JOIN students s ON b.student_id = s.student_id " &
                                 "WHERE b.student_id = @sid LIMIT 1"

            Using cmd As New MySqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@sid", cmbStudentID.Text)
                Using dr As MySqlDataReader = cmd.ExecuteReader()
                    If dr.Read() Then
                        txtStudentName.Text = dr("first_name").ToString() & " " & dr("last_name").ToString()
                        txtCourse.Text = dr("course").ToString()

                        Dim totalAmt As Decimal = Convert.ToDecimal(dr("total_amount"))
                        Dim currentBal As Decimal = Convert.ToDecimal(dr("balance"))
                        Dim billingStatus As String = dr("status").ToString()
                        Dim payMode As String = dr("payment_mode").ToString().ToUpper()

                        txtTotal.Text = totalAmt.ToString("N2")
                        txtBalance.Text = "Balance: ₱" & currentBal.ToString("N2")
                        lblHiddenBillingID.Text = dr("billing_id").ToString()

                        ' Full Payment Mode: Auto-fills amount and locks sections
                        If payMode = "FULL PAYMENT" Then
                            txtStatus.Text = "MODE: FULL PAYMENT"
                            txtStatus.ForeColor = Color.Blue
                            txtAmount.Text = currentBal.ToString("F2")
                            txtAmount.ReadOnly = True
                            pnlTuitionSection.Enabled = True
                            grpDownPayment.Enabled = False

                            ' Installment Mode: Initial state
                        ElseIf billingStatus = "UNPAID" Then
                            txtStatus.Text = "AWAITING DOWNPAYMENT"
                            txtStatus.ForeColor = Color.Red
                            txtAmount.ReadOnly = False
                            pnlTuitionSection.Enabled = False
                            grpDownPayment.Enabled = True
                            txtDownpayment.Text = "3000.00"
                        Else
                            ' Installment Mode: After downpayment
                            txtStatus.Text = "ENROLLED / TUITION"
                            txtStatus.ForeColor = Color.Green
                            txtAmount.ReadOnly = False
                            pnlTuitionSection.Enabled = True
                            grpDownPayment.Enabled = False
                        End If
                    End If
                End Using
            End Using

            ' Refresh Total Paid display
            Dim sumQuery As String = "SELECT SUM(amount_paid) FROM payments WHERE billing_id = @bid"
            Using cmdSum As New MySqlCommand(sumQuery, conn)
                cmdSum.Parameters.AddWithValue("@bid", lblHiddenBillingID.Text)
                Dim res = cmdSum.ExecuteScalar()
                txtPaid.Text = If(res Is DBNull.Value, "0.00", Convert.ToDecimal(res).ToString("N2"))
            End Using

            GenerateAutoPaymentDetails()
        Finally
            closeCon()
        End Try
    End Sub

    ' ================= 4. ENROLLMENT HELPER =================
    Private Sub RegisterEnrollment(studentID As String)
        ' Officially registers the student in the enrollment table
        Dim checkQuery As String = "SELECT COUNT(*) FROM enrollments WHERE student_id = @sid"
        Using cmdCheck As New MySqlCommand(checkQuery, conn)
            cmdCheck.Parameters.AddWithValue("@sid", studentID)
            If Convert.ToInt32(cmdCheck.ExecuteScalar()) > 0 Then Return
        End Using

        Dim enrollQuery As String = "INSERT INTO enrollments (student_id, course_id, semester, academic_year, status, date_enrolled) " &
                                   "VALUES (@sid, @cid, '1st Semester', '2025-2026', 'ENROLLED', NOW())"
        Using cmdEnroll As New MySqlCommand(enrollQuery, conn)
            cmdEnroll.Parameters.AddWithValue("@sid", studentID)
            cmdEnroll.Parameters.AddWithValue("@cid", txtCourse.Text)
            cmdEnroll.ExecuteNonQuery()
        End Using
    End Sub

    ' ================= 5. PAYMENT ACTIONS =================
    Private Sub btnDownPayment_Click(sender As Object, e As EventArgs) Handles btnDownPayment.Click
        If String.IsNullOrEmpty(txtDownpayment.Text) OrElse String.IsNullOrEmpty(txtOR.Text) Then Return

        Try
            openCon()
            Dim amount As Decimal = Convert.ToDecimal(txtDownpayment.Text)
            Dim bID As Integer = Convert.ToInt32(lblHiddenBillingID.Text)
            Dim sID As String = cmbStudentID.Text

            ' 1. Insert Payment
            Dim iQuery = "INSERT INTO payments (billing_id, or_number, amount_paid, payment_date, cashier_id) VALUES (@bid, @or, @amt, NOW(), @cid)"
            Using cmdPay As New MySqlCommand(iQuery, conn)
                cmdPay.Parameters.AddWithValue("@bid", bID)
                cmdPay.Parameters.AddWithValue("@or", txtOR.Text)
                cmdPay.Parameters.AddWithValue("@amt", amount)
                cmdPay.Parameters.AddWithValue("@cid", UserSession.CurrentCashierID)
                cmdPay.ExecuteNonQuery()
            End Using

            ' 2. Update Billing
            Dim uQuery = "UPDATE billing SET balance = GREATEST(balance - @amt, 0), status = CASE WHEN (balance - @amt) <= 0 THEN 'PAID' ELSE 'PARTIAL' END WHERE billing_id = @bid"
            Using cmdUpdate As New MySqlCommand(uQuery, conn)
                cmdUpdate.Parameters.AddWithValue("@amt", amount)
                cmdUpdate.Parameters.AddWithValue("@bid", bID)
                cmdUpdate.ExecuteNonQuery()
            End Using

            ' 3. Sync Web Status
            Dim statusQuery = "UPDATE students SET status = 'PENDING' WHERE student_id = @sid"
            Using cmdStatus As New MySqlCommand(statusQuery, conn)
                cmdStatus.Parameters.AddWithValue("@sid", sID)
                cmdStatus.ExecuteNonQuery()
            End Using

            ' 4. Register official enrollment
            RegisterEnrollment(sID)

            MsgBox("Downpayment Processed and Enrolled!", MsgBoxStyle.Information)
            LoadPayments()
            cmbStudentID_SelectedIndexChanged(Nothing, Nothing)
        Catch ex As Exception
            MsgBox("Error: " & ex.Message)
        Finally
            closeCon()
        End Try
    End Sub

    Private Sub btnPay_Click(sender As Object, e As EventArgs) Handles btnPay.Click
        If cmbStudentID.SelectedIndex = -1 Then Return

        Dim amountToPay As Decimal
        If Not Decimal.TryParse(txtAmount.Text, amountToPay) OrElse amountToPay <= 0 Then Return

        Try
            openCon()
            Dim bID As Integer = Convert.ToInt32(lblHiddenBillingID.Text)
            Dim sID As String = cmbStudentID.Text

            ' Insert Payment Record
            Dim iQuery = "INSERT INTO payments (billing_id, or_number, amount_paid, payment_date, cashier_id) VALUES (@bid, @or, @amt, NOW(), @cid)"
            Using cmdPay As New MySqlCommand(iQuery, conn)
                cmdPay.Parameters.AddWithValue("@bid", bID)
                cmdPay.Parameters.AddWithValue("@or", txtOR.Text)
                cmdPay.Parameters.AddWithValue("@amt", amountToPay)
                cmdPay.Parameters.AddWithValue("@cid", UserSession.CurrentCashierID)
                cmdPay.ExecuteNonQuery()
            End Using

            ' Update Balance and Billing Status
            Dim uQuery = "UPDATE billing SET balance = GREATEST(balance - @amt, 0), status = CASE WHEN (balance - @amt) <= 0 THEN 'PAID' ELSE 'PARTIAL' END WHERE billing_id = @bid"
            Using cmdUpdate As New MySqlCommand(uQuery, conn)
                cmdUpdate.Parameters.AddWithValue("@amt", amountToPay)
                cmdUpdate.Parameters.AddWithValue("@bid", bID)
                cmdUpdate.ExecuteNonQuery()
            End Using

            ' Ensure Enrollment Table is updated
            RegisterEnrollment(sID)

            MsgBox("Payment Successful!")
            GenerateAutoPaymentDetails()
            LoadPayments()
            cmbStudentID_SelectedIndexChanged(Nothing, Nothing)
            txtAmount.Clear()
        Catch ex As Exception
            MsgBox("Error: " & ex.Message)
        Finally
            closeCon()
        End Try
    End Sub

    Private Sub ClearFields()
        txtStudentName.Clear()
        txtCourse.Clear()
        txtTotal.Clear()
        txtPaid.Text = "0.00"
        txtBalance.Text = "Balance: ₱0.00"
        lblHiddenBillingID.Text = ""
        txtStatus.Text = "IDLE"
        txtAmount.Clear()
        txtAmount.ReadOnly = False
        pnlTuitionSection.Enabled = False
        grpDownPayment.Enabled = False
    End Sub

    Private Sub LoadPayments()
        Try
            openCon()
            Dim query As String = "SELECT p.or_number, s.student_id, p.amount_paid FROM payments p " &
                                "INNER JOIN billing b ON p.billing_id = b.billing_id " &
                                "INNER JOIN students s ON b.student_id = s.student_id " &
                                "ORDER BY p.payment_date DESC"
            Dim da As New MySqlDataAdapter(query, conn)
            Dim dt As New DataTable
            da.Fill(dt)
            dgvHistory.DataSource = dt
        Finally
            closeCon()
        End Try
    End Sub
End Class