Imports MySql.Data.MySqlClient

Public Class SubjectForm

    Private selectedSubjectId As Integer = 0

    Private Sub SubjectForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadCourseDropdown()
        LoadSubjects()
    End Sub

    Private Sub LoadCourseDropdown()
        Try
            openCon()
            Using cmd As New MySqlCommand(
                "SELECT course_code, course_name FROM courses ORDER BY course_name", conn)
                Dim dt As New DataTable
                Dim da As New MySqlDataAdapter(cmd)
                da.Fill(dt)
                cmbCourse.DataSource = dt
                cmbCourse.DisplayMember = "course_name"
                cmbCourse.ValueMember = "course_code"
                cmbCourse.SelectedIndex = -1
            End Using
        Catch ex As Exception
            MsgBox("Error loading courses: " & ex.Message)
        Finally
            closeCon()
        End Try
    End Sub

    Private Sub LoadSubjects()
        Try
            openCon()
            Using cmd As New MySqlCommand(
                "SELECT subject_id, course, subject_code, subject_name, units
                 FROM subjects ORDER BY course, subject_code", conn)
                Dim dt As New DataTable
                Dim da As New MySqlDataAdapter(cmd)
                da.Fill(dt)
                dgvSubjects.DataSource = dt
                If dgvSubjects.Columns.Contains("subject_id") Then
                    dgvSubjects.Columns("subject_id").Visible = False
                End If
            End Using
        Catch ex As Exception
            MsgBox("Error: " & ex.Message)
        Finally
            closeCon()
        End Try
    End Sub

    Private Sub dgvSubjects_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvSubjects.CellClick
        If e.RowIndex < 0 Then Return
        Dim row As DataGridViewRow = dgvSubjects.Rows(e.RowIndex)
        selectedSubjectId = Convert.ToInt32(row.Cells("subject_id").Value)
        cmbCourse.SelectedValue = row.Cells("course").Value.ToString()
        txtSubjectCode.Text = row.Cells("subject_code").Value.ToString()
        txtSubjectName.Text = row.Cells("subject_name").Value.ToString()
        txtUnits.Text = row.Cells("units").Value.ToString()
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        If cmbCourse.SelectedValue Is Nothing Then
            MsgBox("Please select a course.", MsgBoxStyle.Exclamation)
            Return
        End If
        If String.IsNullOrWhiteSpace(txtSubjectCode.Text) OrElse String.IsNullOrWhiteSpace(txtSubjectName.Text) Then
            MsgBox("Subject code and name are required.", MsgBoxStyle.Exclamation)
            Return
        End If
        Try
            openCon()
            Using cmd As New MySqlCommand(
                "INSERT INTO subjects (course, subject_code, subject_name, units)
                 VALUES (@course, @code, @name, @units)", conn)
                cmd.Parameters.AddWithValue("@course", cmbCourse.SelectedValue.ToString())
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

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        If selectedSubjectId = 0 Then
            MsgBox("Select a subject first.", MsgBoxStyle.Exclamation)
            Return
        End If
        Try
            openCon()
            Using cmd As New MySqlCommand(
                "UPDATE subjects SET course=@course, subject_code=@code, subject_name=@name, units=@units
                 WHERE subject_id=@id", conn)
                cmd.Parameters.AddWithValue("@course", cmbCourse.SelectedValue.ToString())
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

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If selectedSubjectId = 0 Then
            MsgBox("Select a subject first.", MsgBoxStyle.Exclamation)
            Return
        End If
        If MsgBox("Delete this subject?", MsgBoxStyle.YesNo) = MsgBoxResult.No Then Return
        Try
            openCon()
            Using cmd As New MySqlCommand(
                "DELETE FROM subjects WHERE subject_id = @id", conn)
                cmd.Parameters.AddWithValue("@id", selectedSubjectId)
                cmd.ExecuteNonQuery()
            End Using
            MsgBox("Subject deleted!", MsgBoxStyle.Information)
            LoadSubjects()
            ClearFields()
        Catch ex As Exception
            MsgBox("Error: " & ex.Message)
        Finally
            closeCon()
        End Try
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        ClearFields()
    End Sub

    Private Sub ClearFields()
        selectedSubjectId = 0
        cmbCourse.SelectedIndex = -1
        txtSubjectCode.Clear()
        txtSubjectName.Clear()
        txtUnits.Clear()
        dgvSubjects.ClearSelection()
    End Sub

End Class
