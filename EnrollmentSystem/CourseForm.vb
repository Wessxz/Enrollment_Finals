Imports MySql.Data.MySqlClient

Public Class CourseForm

    Private selectedCourseId As Integer = 0

    Private Sub CourseForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadCourses()
    End Sub

    Private Sub LoadCourses()
        Try
            openCon()
            Using cmd As New MySqlCommand(
                "SELECT course_id, course_code, course_name, department
                 FROM courses ORDER BY course_code", conn)
                Dim dt As New DataTable
                Dim da As New MySqlDataAdapter(cmd)
                da.Fill(dt)
                dgvCourses.DataSource = dt
                If dgvCourses.Columns.Contains("course_id") Then
                    dgvCourses.Columns("course_id").Visible = False
                End If
            End Using
        Catch ex As Exception
            MsgBox("Error loading courses: " & ex.Message)
        Finally
            closeCon()
        End Try
    End Sub

    Private Sub dgvCourses_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvCourses.CellClick
        If e.RowIndex < 0 Then Return
        Dim row As DataGridViewRow = dgvCourses.Rows(e.RowIndex)
        selectedCourseId = Convert.ToInt32(row.Cells("course_id").Value)
        txtCourseCode.Text = row.Cells("course_code").Value.ToString()
        txtCourseName.Text = row.Cells("course_name").Value.ToString()
        txtDepartment.Text = If(IsDBNull(row.Cells("department").Value), "", row.Cells("department").Value.ToString())
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        If String.IsNullOrWhiteSpace(txtCourseCode.Text) OrElse String.IsNullOrWhiteSpace(txtCourseName.Text) Then
            MsgBox("Course code and name are required.", MsgBoxStyle.Exclamation)
            Return
        End If
        Try
            openCon()
            Using cmd As New MySqlCommand(
                "INSERT INTO courses (course_code, course_name, department)
                 VALUES (@code, @name, @dept)", conn)
                cmd.Parameters.AddWithValue("@code", txtCourseCode.Text.Trim().ToUpper())
                cmd.Parameters.AddWithValue("@name", txtCourseName.Text.Trim())
                cmd.Parameters.AddWithValue("@dept", txtDepartment.Text.Trim())
                cmd.ExecuteNonQuery()
            End Using
            MsgBox("Course added!", MsgBoxStyle.Information)
            LoadCourses()
            ClearFields()
        Catch ex As Exception
            MsgBox("Error: " & ex.Message)
        Finally
            closeCon()
        End Try
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        If selectedCourseId = 0 Then
            MsgBox("Select a course first.", MsgBoxStyle.Exclamation)
            Return
        End If
        Try
            openCon()
            Using cmd As New MySqlCommand(
                "UPDATE courses SET course_code=@code, course_name=@name, department=@dept
                 WHERE course_id=@id", conn)
                cmd.Parameters.AddWithValue("@code", txtCourseCode.Text.Trim().ToUpper())
                cmd.Parameters.AddWithValue("@name", txtCourseName.Text.Trim())
                cmd.Parameters.AddWithValue("@dept", txtDepartment.Text.Trim())
                cmd.Parameters.AddWithValue("@id", selectedCourseId)
                cmd.ExecuteNonQuery()
            End Using
            MsgBox("Course updated!", MsgBoxStyle.Information)
            LoadCourses()
            ClearFields()
        Catch ex As Exception
            MsgBox("Error: " & ex.Message)
        Finally
            closeCon()
        End Try
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If selectedCourseId = 0 Then
            MsgBox("Select a course first.", MsgBoxStyle.Exclamation)
            Return
        End If
        If MsgBox("Delete this course?", MsgBoxStyle.YesNo) = MsgBoxResult.No Then Return
        Try
            openCon()
            Using cmd As New MySqlCommand(
                "DELETE FROM courses WHERE course_id = @id", conn)
                cmd.Parameters.AddWithValue("@id", selectedCourseId)
                cmd.ExecuteNonQuery()
            End Using
            MsgBox("Course deleted!", MsgBoxStyle.Information)
            LoadCourses()
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
        selectedCourseId = 0
        txtCourseCode.Clear()
        txtCourseName.Clear()
        txtDepartment.Clear()
        dgvCourses.ClearSelection()
    End Sub

End Class
