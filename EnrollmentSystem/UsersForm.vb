Imports MySql.Data.MySqlClient

Public Class UsersForm

    Private Sub UsersForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadStudents()
    End Sub

    ' =========================
    ' LOAD STUDENTS (PENDING ONLY)
    ' =========================
    Private Sub LoadStudents()

        Try
            openCon()

            Dim query As String =
"SELECT id, student_id, first_name, last_name, username, status
 FROM students
 ORDER BY status ASC, last_name ASC"

            Using cmd As New MySqlCommand(query, conn)

                Dim dt As New DataTable
                Dim da As New MySqlDataAdapter(cmd)

                da.Fill(dt)
                dgvUsers.DataSource = dt

            End Using

        Catch ex As Exception
            MsgBox("Error loading students: " & ex.Message, MsgBoxStyle.Critical)
        Finally
            closeCon()
        End Try

    End Sub

    ' =========================
    ' REFRESH BUTTON
    ' =========================
    Private Sub btnLoad_Click(sender As Object, e As EventArgs) Handles btnLoad.Click
        LoadStudents()
    End Sub

    ' =========================
    ' VERIFY STUDENT
    ' =========================
    Private Sub btnVerify_Click(sender As Object, e As EventArgs) Handles btnVerify.Click

        If dgvUsers.CurrentRow Is Nothing Then
            MsgBox("Select a student first.")
            Exit Sub
        End If

        Try
            openCon()

            Dim studentID As Integer = Convert.ToInt32(dgvUsers.CurrentRow.Cells("id").Value)

            Dim query As String =
                "UPDATE students SET status='VERIFIED' WHERE id=@id"

            Using cmd As New MySqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@id", studentID)
                cmd.ExecuteNonQuery()
            End Using

            MsgBox("Student Verified!", MsgBoxStyle.Information)

            LoadStudents()

        Catch ex As Exception
            MsgBox("Verification Error: " & ex.Message, MsgBoxStyle.Critical)
        Finally
            closeCon()
        End Try

    End Sub

    ' =========================
    ' REJECT STUDENT (DELETE)
    ' =========================
    Private Sub btnReject_Click(sender As Object, e As EventArgs) Handles btnReject.Click

        If dgvUsers.CurrentRow Is Nothing Then
            MsgBox("Select a student first.")
            Exit Sub
        End If

        If MsgBox("Reject and delete this student?", MsgBoxStyle.YesNo + MsgBoxStyle.Question) = MsgBoxResult.No Then
            Exit Sub
        End If

        Try
            openCon()

            Dim studentID As Integer = Convert.ToInt32(dgvUsers.CurrentRow.Cells("id").Value)

            Dim query As String = "DELETE FROM students WHERE id=@id"

            Using cmd As New MySqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@id", studentID)
                cmd.ExecuteNonQuery()
            End Using

            MsgBox("Student Rejected & Deleted.", MsgBoxStyle.Information)

            LoadStudents()

        Catch ex As Exception
            MsgBox("Rejection Error: " & ex.Message, MsgBoxStyle.Critical)
        Finally
            closeCon()
        End Try

    End Sub

End Class