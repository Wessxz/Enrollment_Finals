Imports MySql.Data.MySqlClient

Public Class UsersForm
    Private Sub UsersForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadPendingStudents()
    End Sub

    ' ================= 1. DATA LOADING (FIXED QUERY) =================
    Private Sub LoadPendingStudents()
        Try
            openCon()
            ' FIXED: Removed 'first_name', 'last_name', and 'student_id' 
            ' These caused the "Unknown Column" errors in your screenshots.
            Dim query = "SELECT id, username, status FROM users WHERE status = 'PENDING' AND role = 'student'"

            Dim da As New MySqlDataAdapter(query, conn)
            Dim dt As New DataTable
            da.Fill(dt)
            dgvUsers.DataSource = dt
        Catch ex As Exception
            MsgBox("Database Error: " & ex.Message)
        Finally
            closeCon()
        End Try
    End Sub

    ' ================= 2. VERIFICATION ACTION =================
    Private Sub btnVerify_Click(sender As Object, e As EventArgs) Handles btnVerify.Click
        If dgvUsers.CurrentRow Is Nothing Then Return

        Dim uID As Integer = Convert.ToInt32(dgvUsers.CurrentRow.Cells("id").Value)

        Try
            openCon()
            Dim query = "UPDATE users SET status = 'VERIFIED' WHERE id = @id"
            Using cmd As New MySqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@id", uID)
                cmd.ExecuteNonQuery()
            End Using
            MsgBox("Student Verified! Portal access granted.", MsgBoxStyle.Information)
            LoadPendingStudents()
        Catch ex As Exception
            MsgBox("Error: " & ex.Message)
        Finally
            closeCon()
        End Try
    End Sub

    ' ================= 3. REJECTION ACTION =================
    Private Sub btnReject_Click(sender As Object, e As EventArgs) Handles btnReject.Click
        If dgvUsers.CurrentRow Is Nothing Then Return
        Dim uID As Integer = Convert.ToInt32(dgvUsers.CurrentRow.Cells("id").Value)

        If MsgBox("Reject student?", MsgBoxStyle.YesNo + MsgBoxStyle.Question) = MsgBoxResult.Yes Then
            Try
                openCon()
                Using cmd As New MySqlCommand("DELETE FROM users WHERE id = @id", conn)
                    cmd.Parameters.AddWithValue("@id", uID)
                    cmd.ExecuteNonQuery()
                End Using
                LoadPendingStudents()
            Catch ex As Exception
                MsgBox("Error: " & ex.Message)
            Finally
                closeCon()
            End Try
        End If
    End Sub
End Class