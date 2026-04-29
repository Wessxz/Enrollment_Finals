Imports MySql.Data.MySqlClient

Public Class CourseSubjectForm

    Private selectedCourseId As Integer = 0
    Private selectedSubjectId As Integer = 0

    Private Sub CourseSubjectForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadCourses()
        LoadCourseDropdown()
        LoadSubjects()
    End Sub

    ' =========================================================
    ' TAB CHANGED - Refresh dropdown when switching to Subjects
    ' =========================================================
    Private Sub tabControl_SelectedIndexChanged(sender As Object, e As EventArgs) Handles tabControl.SelectedIndexChanged
        If tabControl.SelectedTab Is tabSubjects Then
            LoadCourseDropdown()
            LoadSubjects()
        End If
    End Sub

    ' =========================================================
    ' COURSES TAB
    ' =========================================================
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

    Private Sub btnAddCourse_Click(sender As Object, e As EventArgs) Handles btnAddCourse.Click
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
            MsgBox("Course added successfully!", MsgBoxStyle.Information)
            LoadCourses()
            ClearCourseFields()
        Catch ex As Exception
            MsgBox("Error: " & ex.Message)
        Finally
            closeCon()
        End Try
    End Sub

    Private Sub btnUpdateCourse_Click(sender As Object, e As EventArgs) Handles btnUpdateCourse.Click
        If selectedCourseId = 0 Then
            MsgBox("Please select a course to update.", MsgBoxStyle.Exclamation)
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
            MsgBox("Course updated successfully!", MsgBoxStyle.Information)
            LoadCourses()
            ClearCourseFields()
        Catch ex As Exception
            MsgBox("Error: " & ex.Message)
        Finally
            closeCon()
        End Try
    End Sub

    Private Sub btnDeleteCourse_Click(sender As Object, e As EventArgs) Handles btnDeleteCourse.Click
        If selectedCourseId = 0 Then
            MsgBox("Please select a course to delete.", MsgBoxStyle.Exclamation)
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
            ClearCourseFields()
        Catch ex As Exception
            MsgBox("Error: " & ex.Message)
        Finally
            closeCon()
        End Try
    End Sub

    Private Sub btnClearCourse_Click(sender As Object, e As EventArgs) Handles btnClearCourse.Click
        ClearCourseFields()
    End Sub

    Private Sub ClearCourseFields()
        selectedCourseId = 0
        txtCourseCode.Clear()
        txtCourseName.Clear()
        txtDepartment.Clear()
        dgvCourses.ClearSelection()
    End Sub

    ' =========================================================
    ' SUBJECTS TAB
    ' =========================================================
    Private Sub LoadCourseDropdown()
        Try
            openCon()
            Using cmd As New MySqlCommand(
                "SELECT course_code FROM courses ORDER BY course_code", conn)
                Dim dt As New DataTable
                Dim da As New MySqlDataAdapter(cmd)
                da.Fill(dt)

                cmbCourse.Items.Clear()
                For Each row As DataRow In dt.Rows
                    cmbCourse.Items.Add(row("course_code").ToString())
                Next
            End Using
        Catch ex As Exception
            MsgBox("Error loading course dropdown: " & ex.Message)
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
            MsgBox("Error loading subjects: " & ex.Message)
        Finally
            closeCon()
        End Try
    End Sub

    Private Sub dgvSubjects_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvSubjects.CellClick
        If e.RowIndex < 0 Then Return
        Dim row As DataGridViewRow = dgvSubjects.Rows(e.RowIndex)
        selectedSubjectId = Convert.ToInt32(row.Cells("subject_id").Value)
        cmbCourse.Text = row.Cells("course").Value.ToString()
        txtSubjectCode.Text = row.Cells("subject_code").Value.ToString()
        txtSubjectName.Text = row.Cells("subject_name").Value.ToString()
        txtUnits.Text = row.Cells("units").Value.ToString()
    End Sub

    Private Sub btnAddSubject_Click(sender As Object, e As EventArgs) Handles btnAddSubject.Click
        If cmbCourse.SelectedIndex = -1 Then
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
                cmd.Parameters.AddWithValue("@course", cmbCourse.Text.Trim())
                cmd.Parameters.AddWithValue("@code", txtSubjectCode.Text.Trim())
                cmd.Parameters.AddWithValue("@name", txtSubjectName.Text.Trim())
                cmd.Parameters.AddWithValue("@units", Val(txtUnits.Text))
                cmd.ExecuteNonQuery()
            End Using
            MsgBox("Subject added successfully!", MsgBoxStyle.Information)
            LoadSubjects()
            ClearSubjectFields()
        Catch ex As Exception
            MsgBox("Error: " & ex.Message)
        Finally
            closeCon()
        End Try
    End Sub

    Private Sub btnUpdateSubject_Click(sender As Object, e As EventArgs) Handles btnUpdateSubject.Click
        If selectedSubjectId = 0 Then
            MsgBox("Please select a subject to update.", MsgBoxStyle.Exclamation)
            Return
        End If

        Try
            openCon()
            Using cmd As New MySqlCommand(
                "UPDATE subjects SET course=@course, subject_code=@code, subject_name=@name, units=@units
                 WHERE subject_id=@id", conn)
                cmd.Parameters.AddWithValue("@course", cmbCourse.Text.Trim())
                cmd.Parameters.AddWithValue("@code", txtSubjectCode.Text.Trim())
                cmd.Parameters.AddWithValue("@name", txtSubjectName.Text.Trim())
                cmd.Parameters.AddWithValue("@units", Val(txtUnits.Text))
                cmd.Parameters.AddWithValue("@id", selectedSubjectId)
                cmd.ExecuteNonQuery()
            End Using
            MsgBox("Subject updated successfully!", MsgBoxStyle.Information)
            LoadSubjects()
            ClearSubjectFields()
        Catch ex As Exception
            MsgBox("Error: " & ex.Message)
        Finally
            closeCon()
        End Try
    End Sub

    Private Sub btnDeleteSubject_Click(sender As Object, e As EventArgs) Handles btnDeleteSubject.Click
        If selectedSubjectId = 0 Then
            MsgBox("Please select a subject to delete.", MsgBoxStyle.Exclamation)
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
            ClearSubjectFields()
        Catch ex As Exception
            MsgBox("Error: " & ex.Message)
        Finally
            closeCon()
        End Try
    End Sub

    Private Sub btnClearSubject_Click(sender As Object, e As EventArgs) Handles btnClearSubject.Click
        ClearSubjectFields()
    End Sub

    Private Sub ClearSubjectFields()
        selectedSubjectId = 0
        cmbCourse.SelectedIndex = -1
        txtSubjectCode.Clear()
        txtSubjectName.Clear()
        txtUnits.Clear()
        dgvSubjects.ClearSelection()
    End Sub

End Class
