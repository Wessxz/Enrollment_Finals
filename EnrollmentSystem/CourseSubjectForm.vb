Imports MySql.Data.MySqlClient

Public Class CourseSubjectForm

    Dim selectedSubjectId As Integer

    Private Sub CourseSubjectForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadSubjects()
    End Sub

    ' ================= LOAD SUBJECTS =================
    Private Sub LoadSubjects()
        Try
            openCon()
            Using cmd As New MySqlCommand("SELECT * FROM subjects ORDER BY subject_code", conn)
                Dim dt As New DataTable
                Dim da As New MySqlDataAdapter(cmd)
                da.Fill(dt)
                dgvSubjects.DataSource = dt
            End Using
        Catch ex As Exception
            MsgBox("Error: " & ex.Message)
        Finally
            closeCon()
        End Try
    End Sub

    ' ================= ROW CLICK → AUTO FILL =================
    Private Sub dgvSubjects_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvSubjects.CellClick
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow = dgvSubjects.Rows(e.RowIndex)
            selectedSubjectId = Convert.ToInt32(row.Cells("subject_id").Value)
            txtCourse.Text = row.Cells("course").Value.ToString()
            txtSubjectCode.Text = row.Cells("subject_code").Value.ToString()
            txtSubjectName.Text = row.Cells("subject_name").Value.ToString()
            txtUnits.Text = row.Cells("units").Value.ToString()
        End If
    End Sub

    ' ================= ADD =================
    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        If String.IsNullOrWhiteSpace(txtSubjectCode.Text) OrElse String.IsNullOrWhiteSpace(txtSubjectName.Text) Then
            MsgBox("Subject code and name are required.", MsgBoxStyle.Exclamation)
            Return
        End If

        Try
            openCon()
            Using cmd As New MySqlCommand(
                "INSERT INTO subjects (course, subject_code, subject_name, units) VALUES (@course, @code, @name, @units)", conn)
                cmd.Parameters.AddWithValue("@course", txtCourse.Text.Trim())
                cmd.Parameters.AddWithValue("@code", txtSubjectCode.Text.Trim())
                cmd.Parameters.AddWithValue("@name", txtSubjectName.Text.Trim())
                cmd.Parameters.AddWithValue("@units", Val(txtUnits.Text))
                cmd.ExecuteNonQuery()
            End Using
            MsgBox("Subject added!", MsgBoxStyle.Information)
            LoadSubjects()
            ClearFields()
        Catch ex As Exception
            MsgBox("Error: " & ex.Message)
        Finally
            closeCon()
        End Try
    End Sub

    ' ================= UPDATE =================
    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        If selectedSubjectId = 0 Then
            MsgBox("Please select a subject to update.", MsgBoxStyle.Exclamation)
            Return
        End If

        Try
            openCon()
            Using cmd As New MySqlCommand(
                "UPDATE subjects SET course=@course, subject_code=@code, subject_name=@name, units=@units WHERE subject_id=@id", conn)
                cmd.Parameters.AddWithValue("@course", txtCourse.Text.Trim())
                cmd.Parameters.AddWithValue("@code", txtSubjectCode.Text.Trim())
                cmd.Parameters.AddWithValue("@name", txtSubjectName.Text.Trim())
                cmd.Parameters.AddWithValue("@units", Val(txtUnits.Text))
                cmd.Parameters.AddWithValue("@id", selectedSubjectId)
                cmd.ExecuteNonQuery()
            End Using
            MsgBox("Subject updated!", MsgBoxStyle.Information)
            LoadSubjects()
            ClearFields()
        Catch ex As Exception
            MsgBox("Error: " & ex.Message)
        Finally
            closeCon()
        End Try
    End Sub

    ' ================= DELETE =================
    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If selectedSubjectId = 0 Then
            MsgBox("Please select a subject to delete.", MsgBoxStyle.Exclamation)
            Return
        End If

        If MsgBox("Delete this subject?", MsgBoxStyle.YesNo) = MsgBoxResult.No Then Return

        Try
            openCon()
            Using cmd As New MySqlCommand("DELETE FROM subjects WHERE subject_id = @id", conn)
                cmd.Parameters.AddWithValue("@id", selectedSubjectId)
                cmd.ExecuteNonQuery()
            End Using
            MsgBox("Deleted!", MsgBoxStyle.Information)
            LoadSubjects()
            ClearFields()
        Catch ex As Exception
            MsgBox("Error: " & ex.Message)
        Finally
            closeCon()
        End Try
    End Sub

    ' ================= CLEAR =================
    Private Sub ClearFields()
        selectedSubjectId = 0
        txtCourse.Clear()
        txtSubjectCode.Clear()
        txtSubjectName.Clear()
        txtUnits.Clear()
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        ClearFields()
    End Sub

End Class
