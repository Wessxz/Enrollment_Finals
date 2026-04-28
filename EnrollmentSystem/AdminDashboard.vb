Imports MySql.Data.MySqlClient

Public Class AdminDashboard

    Private Sub AdminDashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ShowDashboard()
        LoadDashboardStats()
    End Sub

    ' ================= PANEL LOADER =================
    Private Sub LoadFormIntoPanel(frm As Form)
        pnlContent.Controls.Clear()
        frm.TopLevel = False
        frm.FormBorderStyle = FormBorderStyle.None
        frm.Dock = DockStyle.Fill
        pnlContent.Controls.Add(frm)
        frm.Show()
    End Sub

    ' ================= DASHBOARD =================
    Private Sub ShowDashboard()
        pnlContent.Controls.Clear()
        pnlContent.Controls.Add(pnlDashboard)
    End Sub

    Private Sub btnDashboard_Click(sender As Object, e As EventArgs) Handles btnDashboard.Click
        ShowDashboard()
        LoadDashboardStats()
    End Sub
    Private Sub btnUsers_Click(sender As Object, e As EventArgs) Handles btnUsers.Click
        LoadFormIntoPanel(New UsersForm())
    End Sub

    Private Sub btnCourses_Click(sender As Object, e As EventArgs) Handles btnManageAccount.Click
        LoadFormIntoPanel(New UserCreationForm())
    End Sub

    Private Sub LoadDashboardStats()
        Try
            closeCon()
            openCon()

            ' 1. Students Count
            Using cmd1 As New MySqlCommand("SELECT COUNT(*) FROM students", conn)
                lblStudents.Text = "Students: " & cmd1.ExecuteScalar().ToString()
            End Using

            ' 2. Users Count
            Using cmd2 As New MySqlCommand("SELECT COUNT(*) FROM users", conn)
                lblUsers.Text = "Users: " & cmd2.ExecuteScalar().ToString()
            End Using

            ' 3. Enrolled Count
            Using cmd3 As New MySqlCommand("SELECT COUNT(*) FROM enrollments", conn)
                lblEnrolled.Text = "Enrolled: " & cmd3.ExecuteScalar().ToString()
            End Using

            ' 4. Revenue (amount_paid ang column sa payments table mo)
            Using cmd4 As New MySqlCommand("SELECT IFNULL(SUM(amount_paid), 0) FROM payments", conn)
                Dim totalRevenue As Decimal = Convert.ToDecimal(cmd4.ExecuteScalar())
                lblRevenue.Text = "Revenue: ₱" & totalRevenue.ToString("N2")
            End Using

        Catch ex As Exception
            MsgBox("Error loading stats: " & ex.Message, MsgBoxStyle.Critical)
        Finally
            ' Siguradong magsasara ang connection para sa susunod na gamit
            closeCon()
        End Try
    End Sub

    ' ================= LOGOUT =================
    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        Me.Hide()
        Login.Show()
    End Sub

    Private Sub pnlDashboard_Paint(sender As Object, e As PaintEventArgs) Handles pnlDashboard.Paint

    End Sub

    Private Sub pnlSidebar_Paint(sender As Object, e As PaintEventArgs) Handles pnlSidebar.Paint

    End Sub
End Class