Imports MySql.Data.MySqlClient

Public Class AnnouncementForm

    Private Sub AnnouncementForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadAnnouncements()
    End Sub

    ' ================= LOAD ANNOUNCEMENTS =================
    Private Sub LoadAnnouncements()
        Try
            openCon()
            Dim query As String =
                "SELECT a.announcement_id, a.title, a.content,
                        u.username AS posted_by, a.date_posted
                 FROM announcements a
                 LEFT JOIN users u ON a.posted_by = u.id
                 ORDER BY a.date_posted DESC"

            Using cmd As New MySqlCommand(query, conn)
                Dim dt As New DataTable
                Dim da As New MySqlDataAdapter(cmd)
                da.Fill(dt)
                dgvAnnouncements.DataSource = dt
            End Using
        Catch ex As Exception
            MsgBox("Error loading announcements: " & ex.Message)
        Finally
            closeCon()
        End Try
    End Sub

    ' ================= POST ANNOUNCEMENT =================
    ' Designer controls: txtSubject, txtMessage, btnPost, btnClear
    Private Sub btnPost_Click(sender As Object, e As EventArgs) Handles btnPost.Click
        If String.IsNullOrWhiteSpace(txtSubject.Text) OrElse String.IsNullOrWhiteSpace(txtMessage.Text) Then
            MsgBox("Subject and message are required.", MsgBoxStyle.Exclamation)
            Return
        End If

        Try
            openCon()
            Using cmd As New MySqlCommand(
                "INSERT INTO announcements (title, content) VALUES (@title, @content)", conn)
                cmd.Parameters.AddWithValue("@title", txtSubject.Text.Trim())
                cmd.Parameters.AddWithValue("@content", txtMessage.Text.Trim())
                cmd.ExecuteNonQuery()
            End Using
            MsgBox("Announcement posted!", MsgBoxStyle.Information)
            LoadAnnouncements()
            ClearFields()
        Catch ex As Exception
            MsgBox("Error: " & ex.Message)
        Finally
            closeCon()
        End Try
    End Sub

    Private Sub ClearFields()
        txtSubject.Clear()
        txtMessage.Clear()
        cmbAudience.SelectedIndex = -1
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        ClearFields()
    End Sub

End Class
