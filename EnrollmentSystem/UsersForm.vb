Imports MySql.Data.MySqlClient

Public Class UsersForm
    Private Sub UsersForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadPendingStudents()
    End Sub

    ' ================= 1. DATA LOADING =================
    Private Sub LoadPendingStudents()
        Try
            openCon()
            ' FIXED: Table name is 'students' (plural). 
            ' Removed non-existent columns like student_id, first_name, last_name.
            Dim query = "SELECT id, username, status FROM students WHERE status = 'PENDING'"

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
            ' FIXED: Changed table name from 'student' to 'students'
            Dim query = "UPDATE students SET status = 'VERIFIED' WHERE id = @id"
            Using cmd As New MySqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@id", uID)
                cmd.ExecuteNonQuery()
            End Using

            MsgBox("Student Verified! Portal access granted.", MsgBoxStyle.Information)
            LoadPendingStudents()
        Catch ex As Exception
            MsgBox("Verification Error: " & ex.Message)
        Finally
            closeCon()
        End Try
    End Sub

    ' ================= 3. REJECTION ACTION =================
    Private Sub btnReject_Click(sender As Object, e As EventArgs) Handles btnReject.Click
        If dgvUsers.CurrentRow Is Nothing Then Return
        Dim uID As Integer = Convert.ToInt32(dgvUsers.CurrentRow.Cells("id").Value)

        If MsgBox("Reject student account?", MsgBoxStyle.YesNo + MsgBoxStyle.Question) = MsgBoxResult.Yes Then
            Try
                openCon()
                ' FIXED: Changed table name from 'student' to 'students'
                Using cmd As New MySqlCommand("DELETE FROM students WHERE id = @id", conn)
                    cmd.Parameters.AddWithValue("@id", uID)
                    cmd.ExecuteNonQuery()
                End Using
                LoadPendingStudents()
            Catch ex As Exception
                MsgBox("Deletion Error: " & ex.Message)
            Finally
                closeCon()
            End Try
        End If
    End Sub
End Class