Imports MySql.Data.MySqlClient

Public Class RegistrarDashboard

    Private Sub RegistrarDashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ShowDashboard()
        LoadDashboardStats()
    End Sub


    Private Sub LoadFormIntoPanel(frm As Form)
        pnlMain.Controls.Clear()
        frm.TopLevel = False
        frm.FormBorderStyle = FormBorderStyle.None
        frm.Dock = DockStyle.Fill
        pnlMain.Controls.Add(frm)
        frm.Show()
    End Sub


    Private Sub ShowDashboard()
        pnlMain.Controls.Clear()
        ' Ibinabalik ang mga original cards sa pnlMain
        pnlMain.Controls.Add(cardStudents)
        pnlMain.Controls.Add(cardEnrolled)
        pnlMain.Controls.Add(cardCourses)
        pnlMain.Controls.Add(cardSubjects)
    End Sub

    ' ================= NAVIGATION BUTTONS =================

    Private Sub btnDashboard_Click(sender As Object, e As EventArgs) Handles btnDashboard.Click
        ShowDashboard()
        LoadDashboardStats()
    End Sub

    Private Sub btnStudents_Click(sender As Object, e As EventArgs) Handles btnStudents.Click
        LoadFormIntoPanel(New StudentForm())
    End Sub

    Private Sub btnCourses_Click(sender As Object, e As EventArgs) Handles btnCourses.Click
        LoadFormIntoPanel(New CourseForm())
    End Sub

    Private Sub btnSubjects_Click(sender As Object, e As EventArgs) Handles btnSubjects.Click
        LoadFormIntoPanel(New SubjectForm())
    End Sub

    Private Sub btnSchedule_Click(sender As Object, e As EventArgs) Handles btnSchedule.Click
        LoadFormIntoPanel(New ScheduleForm())
    End Sub

    Private Sub btnSections_Click(sender As Object, e As EventArgs) Handles btnSections.Click
        LoadFormIntoPanel(New SectionForm())
    End Sub

    Private Sub btnSectionSchedule_Click(sender As Object, e As EventArgs) Handles btnSectionSchedule.Click
        LoadFormIntoPanel(New SectionScheduleForm())
    End Sub

    Private Sub btnIrregularEnrollment_Click(sender As Object, e As EventArgs) Handles btnIrregularEnrollment.Click
        LoadFormIntoPanel(New IrregularEnrollmentForm())
    End Sub



    ' ================= STATS LOGIC =================
    Private Sub LoadDashboardStats()
        Try
            closeCon()
            openCon()

            ' 1. Total Students
            Using cmd1 As New MySqlCommand("SELECT COUNT(*) FROM students", conn)
                lblStudents.Text = "Students: " & cmd1.ExecuteScalar().ToString()
            End Using

            ' 2. Total Enrolled
            Using cmd2 As New MySqlCommand("SELECT COUNT(*) FROM enrollments", conn)
                lblEnrolled.Text = "Enrolled: " & cmd2.ExecuteScalar().ToString()
            End Using

            ' 3. Total Courses
            Using cmd3 As New MySqlCommand("SELECT COUNT(*) FROM courses", conn)
                lblCourses.Text = "Courses: " & cmd3.ExecuteScalar().ToString()
            End Using

            ' 4. Total Subjects
            Using cmd4 As New MySqlCommand("SELECT COUNT(*) FROM subjects", conn)
                lblSubjects.Text = "Subjects: " & cmd4.ExecuteScalar().ToString()
            End Using

        Catch ex As Exception
            ' Tahimik na error handling para hindi makaabala sa UI
            Console.WriteLine("Stats Error: " & ex.Message)
        Finally
            closeCon()
        End Try
    End Sub

    ' ================= LOGOUT =================
    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        Me.Hide()
        Login.Show()
    End Sub

    Private Sub pnlMain_Paint(sender As Object, e As PaintEventArgs) Handles pnlMain.Paint

    End Sub

    Private Sub btnAssignschedule_Click(sender As Object, e As EventArgs) Handles btnAssignschedule.Click
        LoadFormIntoPanel(New SectionScheduleForm())
    End Sub

    Private Sub pnlSidebar_Paint(sender As Object, e As PaintEventArgs) Handles pnlSidebar.Paint

    End Sub
End Class