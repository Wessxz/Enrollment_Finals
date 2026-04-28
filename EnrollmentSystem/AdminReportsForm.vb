Imports MySql.Data.MySqlClient

Public Class AdminReportsForm

    Private Sub AdminReportsForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadEnrollmentReport()
    End Sub

    ' ================= ENROLLMENT REPORT =================
    Private Sub btnLoadEnrollment_Click(sender As Object, e As EventArgs) Handles btnLoadEnrollment.Click
        LoadEnrollmentReport()
    End Sub

    Private Sub LoadEnrollmentReport()
        Try
            openCon()

            Dim query As String =
                "SELECT e.enrollment_id,
                        s.student_id,
                        CONCAT(s.first_name, ' ', s.last_name) AS student_name,
                        c.course_code,
                        e.semester,
                        e.academic_year,
                        e.status,
                        e.date_enrolled
                 FROM enrollments e
                 INNER JOIN students s ON e.student_id = s.student_id
                 INNER JOIN courses c ON e.course_id = c.course_id
                 ORDER BY e.date_enrolled DESC"

            Using cmd As New MySqlCommand(query, conn)
                Dim dt As New DataTable
                Dim da As New MySqlDataAdapter(cmd)
                da.Fill(dt)
                dgvReports.DataSource = dt
            End Using

        Catch ex As Exception
            MsgBox("Error: " & ex.Message)
        Finally
            closeCon()
        End Try
    End Sub

    ' ================= FINANCE REPORT =================
    Private Sub btnLoadFinance_Click(sender As Object, e As EventArgs) Handles btnLoadFinance.Click
        Try
            openCon()

            Dim query As String =
                "SELECT p.payment_id,
                        s.student_id,
                        CONCAT(s.first_name, ' ', s.last_name) AS student_name,
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
                dgvReports.DataSource = dt
            End Using

        Catch ex As Exception
            MsgBox("Error: " & ex.Message)
        Finally
            closeCon()
        End Try
    End Sub

End Class
