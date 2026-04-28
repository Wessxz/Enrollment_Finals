Imports MySql.Data.MySqlClient

Public Class ReportsForm

    Private Sub ReportsForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadPaymentReport()
    End Sub

    ' ================= PAYMENT / FINANCE REPORT =================
    Private Sub LoadPaymentReport()
        Try
            openCon()

            Dim query As String =
                "SELECT p.payment_id,
                        CONCAT(s.student_id, ' - ', s.first_name, ' ', s.last_name) AS student_name,
                        p.or_number,
                        p.amount_paid,
                        b.total_amount,
                        b.balance,
                        b.status,
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
                dgvReports.DataSource = dt
            End Using

        Catch ex As Exception
            MsgBox("Error loading report: " & ex.Message)
        Finally
            closeCon()
        End Try
    End Sub

End Class
