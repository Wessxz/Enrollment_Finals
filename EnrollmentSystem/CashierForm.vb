Imports MySql.Data.MySqlClient

Public Class CashierForm

    Private Sub CashierForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadBillingCombo()
        LoadPayments()
    End Sub

    ' ================= LOAD BILLING INTO COMBOBOX =================
    ' Only shows students who still have an outstanding balance
    Private Sub LoadBillingCombo()
        Try
            openCon()
            Dim query As String =
                "SELECT b.billing_id, " &
                "CONCAT(s.first_name, ' ', s.last_name) AS display_name, " &
                "b.balance " &
                "FROM billing b " &
                "INNER JOIN enrollments e ON b.enrollment_id = e.enrollment_id " &
                "INNER JOIN students s ON e.student_id = s.student_id " &
                "WHERE b.status <> 'PAID' AND b.balance > 0"

            Using cmd As New MySqlCommand(query, conn)
                Dim dt As New DataTable
                Dim da As New MySqlDataAdapter(cmd)
                da.Fill(dt)

                cmbType.DataSource = dt
                cmbType.DisplayMember = "display_name"
                cmbType.ValueMember = "billing_id"
                cmbType.SelectedIndex = -1
            End Using
        Catch ex As Exception
            MsgBox("Error loading billing: " & ex.Message)
        Finally
            closeCon()
        End Try
    End Sub

    ' ================= SHOW BALANCE ON SELECTION =================
    Private Sub cmbType_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbType.SelectedIndexChanged
        ' Reset balance label if nothing is selected
        If cmbType.SelectedIndex = -1 OrElse Not TypeOf cmbType.SelectedValue Is Integer Then
            lblBalance.Text = "Balance: ₱0.00"
            Return
        End If

        Try
            openCon()
            Using cmd As New MySqlCommand("SELECT balance FROM billing WHERE billing_id = @id", conn)
                cmd.Parameters.AddWithValue("@id", cmbType.SelectedValue)
                Dim result = cmd.ExecuteScalar()
                If result IsNot Nothing Then
                    lblBalance.Text = "Balance: ₱" & Convert.ToDecimal(result).ToString("N2")
                End If
            End Using
        Catch ex As Exception
            ' Silent catch for initialization events
        Finally
            closeCon()
        End Try
    End Sub

    ' ================= PAY BUTTON CLICK =================
    Private Sub btnPay_Click(sender As Object, e As EventArgs) Handles btnPay.Click
        ' 1. Validations
        If cmbType.SelectedIndex = -1 Then
            MsgBox("Please select a student record.", MsgBoxStyle.Exclamation)
            Return
        End If

        Dim amountToPay As Decimal = Val(txtAmount.Text)
        If amountToPay <= 0 Then
            MsgBox("Please enter a valid payment amount.", MsgBoxStyle.Exclamation)
            Return
        End If

        Try
            openCon()
            Dim orNumber As String = "OR-" & DateTime.Now.ToString("yyyyMMddHHmmss")
            Dim billingId As Integer = Convert.ToInt32(cmbType.SelectedValue)

            ' 2. Insert into payments table
            ' We include cashier_id (defaulted to 1, change to your login variable if available)

            Dim insertQuery As String = "INSERT INTO payments (billing_id, or_number, amount_paid, payment_date, cashier_id) " &
                          "VALUES (@bid, @or, @amt, NOW(), @cid)"
            ' ...
            cmd.Parameters.AddWithValue("@cid", 1) ' Replace '1' with your actual logged-in user's ID

            Using cmdPay As New MySqlCommand(insertQuery, conn)
                cmdPay.Parameters.AddWithValue("@bid", billingId)
                cmdPay.Parameters.AddWithValue("@or", orNumber)
                cmdPay.Parameters.AddWithValue("@amt", amountToPay)
                cmdPay.Parameters.AddWithValue("@cid", 1)
                cmdPay.ExecuteNonQuery()
            End Using

            ' 3. Update billing table (Balance and Status)
            ' Using CASE to automatically mark as PAID if balance hits zero
            Dim updateQuery As String = "UPDATE billing SET " &
                                      "balance = GREATEST(balance - @amt, 0), " &
                                      "status = CASE WHEN (balance - @amt) <= 0 THEN 'PAID' ELSE 'PARTIAL' END " &
                                      "WHERE billing_id = @bid"

            Using cmdUpdate As New MySqlCommand(updateQuery, conn)
                cmdUpdate.Parameters.AddWithValue("@amt", amountToPay)
                cmdUpdate.Parameters.AddWithValue("@bid", billingId)
                cmdUpdate.ExecuteNonQuery()
            End Using

            MsgBox("Payment Successful!" & vbCrLf & "OR Number: " & orNumber, MsgBoxStyle.Information)

            ' 4. Refresh UI
            txtAmount.Clear()
            LoadBillingCombo()
            LoadPayments()

        Catch ex As Exception
            MsgBox("Error processing payment: " & ex.Message)
        Finally
            closeCon()
        End Try
    End Sub

    ' ================= LOAD PAYMENTS HISTORY =================
    Private Sub LoadPayments()
        Try
            openCon()
            ' Standard query to show payment logs in the DataGridView
            Dim query As String = "SELECT p.payment_id AS 'ID', " &
                                "CONCAT(s.first_name, ' ', s.last_name) AS 'Student', " &
                                "p.or_number AS 'OR Number', " &
                                "p.amount_paid AS 'Amount Paid', " &
                                "p.payment_date AS 'Date' " &
                                "FROM payments p " &
                                "INNER JOIN billing b ON p.billing_id = b.billing_id " &
                                "INNER JOIN enrollments e ON b.enrollment_id = e.enrollment_id " &
                                "INNER JOIN students s ON e.student_id = s.student_id " &
                                "ORDER BY p.payment_date DESC"

            Using cmd As New MySqlCommand(query, conn)
                Dim dt As New DataTable
                Dim da As New MySqlDataAdapter(cmd)
                da.Fill(dt)
                dgvHistory.DataSource = dt
            End Using
        Catch ex As Exception
            MsgBox("Error loading payment history: " & ex.Message)
        Finally
            closeCon()
        End Try
    End Sub

End Class