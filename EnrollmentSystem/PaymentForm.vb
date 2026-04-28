Imports MySql.Data.MySqlClient

Public Class PaymentForm

    Private Sub PaymentForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadBillingCombo()
        LoadPayments()
    End Sub

    ' ================= LOAD BILLING INTO COMBOBOX =================
    ' Fixed: billing has no student_id — must JOIN through enrollments
    ' Fixed: column is "balance" not "total_balance"
    Private Sub LoadBillingCombo()
        Try
            openCon()

            Dim query As String =
                "SELECT b.billing_id,
                        CONCAT(s.student_id, ' - ', s.first_name, ' ', s.last_name) AS display_name,
                        b.balance
                 FROM billing b
                 INNER JOIN enrollments e ON b.enrollment_id = e.enrollment_id
                 INNER JOIN students s ON e.student_id = s.student_id
                 WHERE b.status <> 'PAID'"

            Using cmd As New MySqlCommand(query, conn)
                Dim dt As New DataTable
                Dim da As New MySqlDataAdapter(cmd)
                da.Fill(dt)

                cmbBilling.DataSource = dt
                cmbBilling.DisplayMember = "display_name"
                cmbBilling.ValueMember = "billing_id"
                cmbBilling.SelectedIndex = -1
            End Using

        Catch ex As Exception
            MsgBox("Error loading billing: " & ex.Message)
        Finally
            closeCon()
        End Try
    End Sub

    ' ================= SHOW BALANCE ON SELECTION =================
    ' Fixed: column is "balance" not "total_balance"
    Private Sub cmbBilling_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbBilling.SelectedIndexChanged
        If cmbBilling.SelectedValue Is Nothing Then Return

        Try
            openCon()

            Using cmd As New MySqlCommand("SELECT balance FROM billing WHERE billing_id = @id", conn)
                cmd.Parameters.AddWithValue("@id", cmbBilling.SelectedValue)
                Dim result = cmd.ExecuteScalar()
                If result IsNot Nothing Then
                    lblBalance.Text = "Balance: ₱" & Convert.ToDecimal(result).ToString("N2")
                End If
            End Using

        Catch ex As Exception
            ' silently ignore during combo population
        Finally
            closeCon()
        End Try
    End Sub

    ' ================= GENERATE OR NUMBER =================
    Private Function GenerateOR() As String
        Return "OR-" & DateTime.Now.ToString("yyyyMMddHHmmss")
    End Function

    ' ================= PAY =================
    ' Fixed: column is "or_number" not "receipt_no"
    ' Fixed: balance update uses correct column name
    ' Fixed: status logic uses CASE instead of IF (MariaDB compatible)
    Private Sub btnPay_Click(sender As Object, e As EventArgs) Handles btnPay.Click
        If cmbBilling.SelectedValue Is Nothing Then
            MsgBox("Please select a billing record.", MsgBoxStyle.Exclamation)
            Return
        End If

        Dim amount As Decimal = Val(txtAmount.Text)
        If amount <= 0 Then
            MsgBox("Please enter a valid payment amount.", MsgBoxStyle.Exclamation)
            Return
        End If

        Try
            openCon()

            Dim orNumber As String = GenerateOR()
            Dim billingId As Integer = Convert.ToInt32(cmbBilling.SelectedValue)

            ' Insert payment record
            Dim insertQuery As String =
                "INSERT INTO payments (billing_id, or_number, amount_paid, payment_date)
                 VALUES (@bid, @or, @amt, NOW())"

            Using cmd As New MySqlCommand(insertQuery, conn)
                cmd.Parameters.AddWithValue("@bid", billingId)
                cmd.Parameters.AddWithValue("@or", orNumber)
                cmd.Parameters.AddWithValue("@amt", amount)
                cmd.ExecuteNonQuery()
            End Using

            ' Update balance and status
            Dim updateQuery As String =
                "UPDATE billing
                 SET balance = GREATEST(balance - @amt, 0),
                     status  = CASE WHEN balance - @amt <= 0 THEN 'PAID'
                                    WHEN balance - @amt < total_amount THEN 'PARTIAL'
                                    ELSE 'UNPAID' END
                 WHERE billing_id = @bid"

            Using cmd As New MySqlCommand(updateQuery, conn)
                cmd.Parameters.AddWithValue("@amt", amount)
                cmd.Parameters.AddWithValue("@bid", billingId)
                cmd.ExecuteNonQuery()
            End Using

            MsgBox("Payment Successful! OR#: " & orNumber, MsgBoxStyle.Information)
            LoadBillingCombo()
            LoadPayments()
            txtAmount.Clear()
            lblBalance.Text = "Balance: ₱0.00"

        Catch ex As Exception
            MsgBox("Error: " & ex.Message)
        Finally
            closeCon()
        End Try
    End Sub

    ' ================= LOAD PAYMENTS =================
    ' Fixed: JOIN through enrollments, correct column names
    Private Sub LoadPayments()
        Try
            openCon()

            Dim query As String =
                "SELECT p.payment_id,
                        CONCAT(s.student_id, ' - ', s.first_name, ' ', s.last_name) AS student_name,
                        p.or_number,
                        p.amount_paid,
                        p.payment_date
                 FROM payments p
                 INNER JOIN billing b ON p.billing_id = b.billing_id
                 INNER JOIN enrollments e ON b.enrollment_id = e.enrollment_id
                 INNER JOIN students s ON e.student_id = s.student_id
                 ORDER BY p.payment_date DESC"

            Using cmd As New MySqlCommand(query, conn)
                Dim dt As New DataTable
                Dim da As New MySqlDataAdapter(cmd)
                da.Fill(dt)
                dgvPayments.DataSource = dt
            End Using

        Catch ex As Exception
            MsgBox("Error loading payments: " & ex.Message)
        Finally
            closeCon()
        End Try
    End Sub

End Class
