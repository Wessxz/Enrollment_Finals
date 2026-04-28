Imports MySql.Data.MySqlClient

Public Class GradesForm

    ' Designer controls: cmbStudent, cmbSubject, txtGrade, txtRemarks, btnSave, dgvGrades

    Private Sub GradesForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadStudentCombo()
        LoadSubjectCombo()
        LoadGrades()
    End Sub

    ' ================= LOAD STUDENTS COMBO =================
    Private Sub LoadStudentCombo()
        Try
            openCon()
            Using cmd As New MySqlCommand(
                "SELECT student_id, CONCAT(student_id, ' - ', first_name, ' ', last_name) AS display_name
                 FROM students WHERE status = 'VERIFIED' ORDER BY last_name", conn)
                Dim dt As New DataTable
                Dim da As New MySqlDataAdapter(cmd)
                da.Fill(dt)
                cmbStudent.DataSource = dt
                cmbStudent.ValueMember = "student_id"
                cmbStudent.DisplayMember = "display_name"
                cmbStudent.SelectedIndex = -1
            End Using
        Catch ex As Exception
            MsgBox("Error loading students: " & ex.Message)
        Finally
            closeCon()
        End Try
    End Sub

    ' ================= LOAD SUBJECTS COMBO =================
    Private Sub LoadSubjectCombo()
        Try
            openCon()
            Using cmd As New MySqlCommand(
                "SELECT subject_id, CONCAT(subject_code, ' - ', subject_name) AS display_name FROM subjects", conn)
                Dim dt As New DataTable
                Dim da As New MySqlDataAdapter(cmd)
                da.Fill(dt)
                cmbSubject.DataSource = dt
                cmbSubject.ValueMember = "subject_id"
                cmbSubject.DisplayMember = "display_name"
                cmbSubject.SelectedIndex = -1
            End Using
        Catch ex As Exception
            MsgBox("Error loading subjects: " & ex.Message)
        Finally
            closeCon()
        End Try
    End Sub

    ' ================= LOAD GRADES GRID =================
    Private Sub LoadGrades()
        Try
            openCon()
            Dim query As String =
                "SELECT g.grade_id,
                        CONCAT(s.student_id, ' - ', s.first_name, ' ', s.last_name) AS student_name,
                        CONCAT(sub.subject_code, ' - ', sub.subject_name) AS subject,
                        g.grade_value,
                        g.remarks
                 FROM grades g
                 INNER JOIN enrollment_details ed ON g.enrollment_detail_id = ed.detail_id
                 INNER JOIN schedules sc ON ed.schedule_id = sc.schedule_id
                 INNER JOIN subjects sub ON sc.subject_id = sub.subject_id
                 INNER JOIN enrollments e ON ed.enrollment_id = e.enrollment_id
                 INNER JOIN students s ON e.student_id = s.student_id
                 ORDER BY s.last_name"

            Using cmd As New MySqlCommand(query, conn)
                Dim dt As New DataTable
                Dim da As New MySqlDataAdapter(cmd)
                da.Fill(dt)
                dgvGrades.DataSource = dt
            End Using
        Catch ex As Exception
            MsgBox("Error loading grades: " & ex.Message)
        Finally
            closeCon()
        End Try
    End Sub

    ' ================= SAVE GRADE =================
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If cmbStudent.SelectedValue Is Nothing OrElse cmbSubject.SelectedValue Is Nothing Then
            MsgBox("Please select a student and subject.", MsgBoxStyle.Exclamation)
            Return
        End If

        If String.IsNullOrWhiteSpace(txtGrade.Text) OrElse txtGrade.Text = "Grade" Then
            MsgBox("Please enter a grade.", MsgBoxStyle.Exclamation)
            Return
        End If

        Try
            openCon()

            ' Find enrollment_detail_id for this student + subject
            Dim detailId As Integer = 0
            Using cmd As New MySqlCommand(
                "SELECT ed.detail_id
                 FROM enrollment_details ed
                 INNER JOIN enrollments e ON ed.enrollment_id = e.enrollment_id
                 INNER JOIN schedules sc ON ed.schedule_id = sc.schedule_id
                 WHERE e.student_id = @sid AND sc.subject_id = @subid
                 LIMIT 1", conn)
                cmd.Parameters.AddWithValue("@sid", cmbStudent.SelectedValue)
                cmd.Parameters.AddWithValue("@subid", cmbSubject.SelectedValue)
                Dim result = cmd.ExecuteScalar()
                If result Is Nothing OrElse IsDBNull(result) Then
                    MsgBox("No enrollment record found for this student and subject.", MsgBoxStyle.Exclamation)
                    Return
                End If
                detailId = Convert.ToInt32(result)
            End Using

            ' Check if grade already exists
            Dim existingId As Integer = 0
            Using cmd As New MySqlCommand(
                "SELECT grade_id FROM grades WHERE enrollment_detail_id = @did", conn)
                cmd.Parameters.AddWithValue("@did", detailId)
                Dim result = cmd.ExecuteScalar()
                If result IsNot Nothing AndAlso Not IsDBNull(result) Then
                    existingId = Convert.ToInt32(result)
                End If
            End Using

            If existingId > 0 Then
                Using cmd As New MySqlCommand(
                    "UPDATE grades SET grade_value=@g, remarks=@r WHERE grade_id=@id", conn)
                    cmd.Parameters.AddWithValue("@g", txtGrade.Text.Trim())
                    cmd.Parameters.AddWithValue("@r", txtRemarks.Text.Trim())
                    cmd.Parameters.AddWithValue("@id", existingId)
                    cmd.ExecuteNonQuery()
                End Using
                MsgBox("Grade updated!", MsgBoxStyle.Information)
            Else
                Using cmd As New MySqlCommand(
                    "INSERT INTO grades (enrollment_detail_id, grade_value, remarks) VALUES (@did, @g, @r)", conn)
                    cmd.Parameters.AddWithValue("@did", detailId)
                    cmd.Parameters.AddWithValue("@g", txtGrade.Text.Trim())
                    cmd.Parameters.AddWithValue("@r", txtRemarks.Text.Trim())
                    cmd.ExecuteNonQuery()
                End Using
                MsgBox("Grade saved!", MsgBoxStyle.Information)
            End If

            LoadGrades()
            cmbStudent.SelectedIndex = -1
            cmbSubject.SelectedIndex = -1
            txtGrade.Clear()
            txtRemarks.Clear()

        Catch ex As Exception
            MsgBox("Error: " & ex.Message)
        Finally
            closeCon()
        End Try
    End Sub

End Class
