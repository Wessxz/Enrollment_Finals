Public Class FacultyDashboard

    Private Sub btnGrades_Click(sender As Object, e As EventArgs) Handles btnGrades.Click
        Dim f As New GradesForm()
        f.Show()
    End Sub

    Private Sub btnAnnouncements_Click(sender As Object, e As EventArgs) Handles btnAnnouncements.Click
        Dim f As New AnnouncementForm()
        f.Show()
    End Sub

    Private Sub btnClassList_Click(sender As Object, e As EventArgs) Handles btnClassList.Click
        Dim f As New ClassListForm()
        f.Show()
    End Sub

    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        Me.Hide()
        Login.Show()
    End Sub

    Private Sub FacultyDashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class