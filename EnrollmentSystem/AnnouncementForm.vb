Imports MySql.Data.MySqlClient

Public Class AnnouncementForm

    Private Sub AnnouncementForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadAnnouncements()
    End Sub

    ' =========================================================
    ' LOAD ANNOUNCEMENTS (filtered by audience if selected)
    ' =========================================================
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

                ' Hide ID column
                If dgvAnnouncements.Columns.Contains("announcement_id") Then
                    dgvAnnouncements.Columns("announcement_id").Visible = False
                End If
            End Using
        Catch ex As Exception
            MsgBox("Error loading announcements: " & ex.Message)
        Finally
            closeCon()
        End Try
    End Sub

    ' =========================================================
    ' POST ANNOUNCEMENT
    ' =========================================================
    Private Sub btnPost_Click(sender As Object, e As EventArgs) Handles btnPost.Click
        If String.IsNullOrWhiteSpace(txtSubject.Text) OrElse String.IsNullOrWhiteSpace(txtMessage.Text) Then
            MsgBox("Subject and message are required.", MsgBoxStyle.Exclamation)
            Return
        End If

        Try
            openCon()

            Using cmd As New MySqlCommand(
                "INSERT INTO announcements (title, content, posted_by, date_posted)
                 VALUES (@title, @content, @postedBy, NOW())", conn)
                cmd.Parameters.AddWithValue("@title", txtSubject.Text.Trim())
                cmd.Parameters.AddWithValue("@content", txtMessage.Text.Trim())
                cmd.Parameters.AddWithValue("@postedBy", UserSession.CurrentCashierID)
                cmd.ExecuteNonQuery()
            End Using

            MsgBox("Announcement posted successfully!", MsgBoxStyle.Information)
            LoadAnnouncements()
            ClearFields()

        Catch ex As Exception
            MsgBox("Error posting announcement: " & ex.Message)
        Finally
            closeCon()
        End Try
    End Sub

    ' =========================================================
    ' DELETE ANNOUNCEMENT
    ' =========================================================
    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If dgvAnnouncements.CurrentRow Is Nothing Then
            MsgBox("Select an announcement to delete.", MsgBoxStyle.Exclamation)
            Return
        End If

        If MsgBox("Delete this announcement?", MsgBoxStyle.YesNo) = MsgBoxResult.No Then Return

        Try
            openCon()
            Dim announcementId As Integer = Convert.ToInt32(dgvAnnouncements.CurrentRow.Cells("announcement_id").Value)

            Using cmd As New MySqlCommand(
                "DELETE FROM announcements WHERE announcement_id = @id", conn)
                cmd.Parameters.AddWithValue("@id", announcementId)
                cmd.ExecuteNonQuery()
            End Using

            MsgBox("Announcement deleted.", MsgBoxStyle.Information)
            LoadAnnouncements()

        Catch ex As Exception
            MsgBox("Error deleting announcement: " & ex.Message)
        Finally
            closeCon()
        End Try
    End Sub

    ' =========================================================
    ' ROW CLICK - LOAD ANNOUNCEMENT INTO FORM FOR EDITING
    ' =========================================================
    Private Sub dgvAnnouncements_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvAnnouncements.CellClick
        If e.RowIndex < 0 Then Return
        Dim row As DataGridViewRow = dgvAnnouncements.Rows(e.RowIndex)
        txtSubject.Text = row.Cells("title").Value.ToString()
        txtMessage.Text = row.Cells("content").Value.ToString()
    End Sub

    ' =========================================================
    ' CLEAR FIELDS
    ' =========================================================
    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        ClearFields()
    End Sub

    Private Sub ClearFields()
        txtSubject.Clear()
        txtMessage.Clear()
        If cmbAudience IsNot Nothing Then cmbAudience.SelectedIndex = -1
        dgvAnnouncements.ClearSelection()
    End Sub

End Class
