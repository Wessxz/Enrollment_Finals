Imports MySql.Data.MySqlClient

Public Class IrregularEnrollmentForm

    Private currentStudentId As String = ""
    Private currentEnrollmentId As Integer = 0

    ' =========================================================
    ' FORM LOAD
    ' =========================================================
    Private Sub IrregularEnrollmentForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cmbSemester.Items.AddRange({"1st Sem", "2nd Sem", "Summer"})
        cmbSemester.SelectedIndex = 0
        txtAcadYear.Text = "2024-2025"
    End Sub

    ' =========================================================
    ' SEARCH STUDENT
    ' =========================================================
    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        If String.IsNullOrWhiteSpace(txtStudentID.Text) Then
            MsgBox("Enter a Student ID.", MsgBoxStyle.Exclamation) : Return
        End If

        Try
            openCon()
            Using cmd As New MySqlCommand(
                "SELECT student_id, first_name, last_name, course, year_level, student_type
                 FROM students
                 WHERE student_id = @sid", conn)

                cmd.Parameters.AddWithValue("@sid", txtStudentID.Text.Trim())

                Using dr As MySqlDataReader = cmd.ExecuteReader()
                    If dr.Read() Then
                        If dr("student_type").ToString().ToUpper() <> "IRREGULAR" Then
                            MsgBox("This student is REGULAR. Use block sectioning instead.",
                                   MsgBoxStyle.Exclamation)
                            ClearAll()
                            Return
                        End If
                        currentStudentId = dr("student_id").ToString()
                        txtStudentName.Text = dr("first_name").ToString() & " " & dr("last_name").ToString()
                        txtCourse.Text = dr("course").ToString()
                        txtYearLevel.Text = dr("year_level").ToString()
                    Else
                        MsgBox("Student ID not found.", MsgBoxStyle.Exclamation)
                        ClearAll()
                        Return
                    End If
                End Using
            End Using

            LoadAvailableSchedules()

        Catch ex As Exception
            MsgBox("Search error: " & ex.Message)
        Finally
            closeCon()
        End Try
    End Sub

    ' =========================================================
    ' LOAD AVAILABLE SCHEDULES
    ' =========================================================
    Private Sub LoadAvailableSchedules()
        If String.IsNullOrEmpty(currentStudentId) Then Return

        Try
            openCon()

            Dim query As String =
                "SELECT sc.schedule_id,
                        sub.subject_code,
                        sub.subject_name,
                        sub.units,
                        IFNULL(u.username, 'TBA') AS instructor,
                        sc.day_of_week,
                        TIME_FORMAT(sc.start_time, '%h:%i %p') AS start_time,
                        TIME_FORMAT(sc.end_time,   '%h:%i %p') AS end_time,
                        sc.room,
                        sc.semester,
                        sc.academic_year
                 FROM schedules sc
                 INNER JOIN subjects sub ON sc.subject_id = sub.subject_id
                 LEFT  JOIN users u ON sc.faculty_id = u.id
                 WHERE sc.semester = @sem
                   AND sc.academic_year = @ay
                   AND sc.schedule_id NOT IN (
                       SELECT ed.schedule_id
                       FROM enrollment_details ed
                       INNER JOIN enrollments e ON ed.enrollment_id = e.enrollment_id
                       WHERE e.student_id = @sid
                         AND e.semester = @sem
                         AND e.academic_year = @ay
                   )
                 ORDER BY sc.day_of_week, sc.start_time"

            Using cmd As New MySqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@sem", cmbSemester.Text)
                cmd.Parameters.AddWithValue("@ay", txtAcadYear.Text.Trim())
                cmd.Parameters.AddWithValue("@sid", currentStudentId)

                Dim dt As New DataTable
                Dim da As New MySqlDataAdapter(cmd)
                da.Fill(dt)

                dgvAvailable.DataSource = dt
                dgvAvailable.AutoGenerateColumns = True

                If dgvAvailable.Columns.Contains("schedule_id") Then
                    dgvAvailable.Columns("schedule_id").Visible = False
                End If

                lblAvailable.Text = "Available Schedules (" & dt.Rows.Count & ")"
            End Using

        Catch ex As Exception
            MsgBox("Error loading schedules: " & ex.Message)
        Finally
            closeCon()
        End Try
    End Sub

    ' =========================================================
    ' ADD TO SELECTED LIST
    ' =========================================================
    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        If dgvAvailable.CurrentRow Is Nothing Then
            MsgBox("Select a schedule first.", MsgBoxStyle.Exclamation) : Return
        End If

        Dim row As DataGridViewRow = dgvAvailable.CurrentRow
        Dim newSchedId As Integer = Convert.ToInt32(row.Cells("schedule_id").Value)
        Dim newDay As String = row.Cells("day_of_week").Value.ToString()
        Dim newStart As String = row.Cells("start_time").Value.ToString()
        Dim newEnd As String = row.Cells("end_time").Value.ToString()

        ' Check duplicate
        For Each selRow As DataGridViewRow In dgvSelected.Rows
            If selRow.Cells("sel_schedule_id").Value IsNot Nothing Then
                If Convert.ToInt32(selRow.Cells("sel_schedule_id").Value) = newSchedId Then
                    MsgBox("Already added.", MsgBoxStyle.Exclamation) : Return
                End If
            End If
        Next

        ' Check time conflict
        For Each selRow As DataGridViewRow In dgvSelected.Rows
            If selRow.Cells("sel_schedule_id").Value IsNot Nothing Then
                If selRow.Cells("sel_day").Value.ToString() = newDay Then
                    If TimesOverlap(newStart, newEnd,
                                    selRow.Cells("sel_start").Value.ToString(),
                                    selRow.Cells("sel_end").Value.ToString()) Then
                        MsgBox("Schedule conflict with: " &
                               selRow.Cells("sel_subject_name").Value.ToString() &
                               " on " & newDay, MsgBoxStyle.Exclamation)
                        Return
                    End If
                End If
            End If
        Next

        dgvSelected.Rows.Add(
            newSchedId,
            row.Cells("subject_code").Value.ToString(),
            row.Cells("subject_name").Value.ToString(),
            row.Cells("units").Value.ToString(),
            row.Cells("instructor").Value.ToString(),
            newDay,
            newStart,
            newEnd,
            row.Cells("room").Value.ToString()
        )

        UpdateTotalUnits()
    End Sub

    ' =========================================================
    ' REMOVE FROM SELECTED LIST
    ' =========================================================
    Private Sub btnRemove_Click(sender As Object, e As EventArgs) Handles btnRemove.Click
        If dgvSelected.CurrentRow Is Nothing Then Return
        dgvSelected.Rows.Remove(dgvSelected.CurrentRow)
        UpdateTotalUnits()
    End Sub

    ' =========================================================
    ' TOTAL UNITS
    ' =========================================================
    Private Sub UpdateTotalUnits()
        Dim total As Integer = 0
        For Each row As DataGridViewRow In dgvSelected.Rows
            If row.Cells("sel_units").Value IsNot Nothing Then
                total += Convert.ToInt32(row.Cells("sel_units").Value)
            End If
        Next
        lblTotalUnits.Text = "Total Units: " & total
    End Sub

    ' =========================================================
    ' TIME OVERLAP CHECK
    ' =========================================================
    Private Function TimesOverlap(s1 As String, e1 As String,
                                   s2 As String, e2 As String) As Boolean
        Try
            Dim ts1 As DateTime = DateTime.Parse(s1)
            Dim te1 As DateTime = DateTime.Parse(e1)
            Dim ts2 As DateTime = DateTime.Parse(s2)
            Dim te2 As DateTime = DateTime.Parse(e2)
            Return ts1 < te2 AndAlso ts2 < te1
        Catch
            Return False
        End Try
    End Function

    ' =========================================================
    ' ENROLL BUTTON
    ' =========================================================
    Private Sub btnEnroll_Click(sender As Object, e As EventArgs) Handles btnEnroll.Click
        If String.IsNullOrEmpty(currentStudentId) Then
            MsgBox("Search a student first.", MsgBoxStyle.Exclamation) : Return
        End If
        If dgvSelected.Rows.Count = 0 Then
            MsgBox("No subjects selected.", MsgBoxStyle.Exclamation) : Return
        End If
        If String.IsNullOrWhiteSpace(txtAcadYear.Text) OrElse cmbSemester.SelectedIndex = -1 Then
            MsgBox("Set semester and school year.", MsgBoxStyle.Exclamation) : Return
        End If

        If MsgBox("Enroll " & txtStudentName.Text & " in " & dgvSelected.Rows.Count & " subject(s)?",
                  MsgBoxStyle.YesNo Or MsgBoxStyle.Question) = MsgBoxResult.No Then Return

        Try
            openCon()

            Dim existingId As Object
            Using cmd As New MySqlCommand(
                "SELECT enrollment_id FROM enrollments
                 WHERE student_id = @sid AND semester = @sem AND academic_year = @ay
                 LIMIT 1", conn)
                cmd.Parameters.AddWithValue("@sid", currentStudentId)
                cmd.Parameters.AddWithValue("@sem", cmbSemester.Text)
                cmd.Parameters.AddWithValue("@ay", txtAcadYear.Text.Trim())
                existingId = cmd.ExecuteScalar()
            End Using

            If existingId IsNot Nothing AndAlso Not IsDBNull(existingId) Then
                currentEnrollmentId = Convert.ToInt32(existingId)
            Else
                Dim courseId As Integer = 0
                Using cmd As New MySqlCommand(
                    "SELECT course_id FROM courses WHERE course_code = @code LIMIT 1", conn)
                    cmd.Parameters.AddWithValue("@code", txtCourse.Text.Trim())
                    Dim result = cmd.ExecuteScalar()
                    If result IsNot Nothing AndAlso Not IsDBNull(result) Then
                        courseId = Convert.ToInt32(result)
                    End If
                End Using

                If courseId = 0 Then
                    MsgBox("Course '" & txtCourse.Text & "' not found in courses table.",
                           MsgBoxStyle.Exclamation)
                    Return
                End If

                Using cmd As New MySqlCommand(
                    "INSERT INTO enrollments (student_id, course_id, semester, academic_year, status)
                     VALUES (@sid, @cid, @sem, @ay, 'APPROVED');
                     SELECT LAST_INSERT_ID();", conn)
                    cmd.Parameters.AddWithValue("@sid", currentStudentId)
                    cmd.Parameters.AddWithValue("@cid", courseId)
                    cmd.Parameters.AddWithValue("@sem", cmbSemester.Text)
                    cmd.Parameters.AddWithValue("@ay", txtAcadYear.Text.Trim())
                    currentEnrollmentId = Convert.ToInt32(cmd.ExecuteScalar())
                End Using
            End If

            Dim added As Integer = 0
            For Each row As DataGridViewRow In dgvSelected.Rows
                If row.Cells("sel_schedule_id").Value Is Nothing Then Continue For

                Dim schedId As Integer = Convert.ToInt32(row.Cells("sel_schedule_id").Value)

                Dim alreadyExists As Object
                Using chk As New MySqlCommand(
                    "SELECT detail_id FROM enrollment_details
                     WHERE enrollment_id = @eid AND schedule_id = @schid LIMIT 1", conn)
                    chk.Parameters.AddWithValue("@eid", currentEnrollmentId)
                    chk.Parameters.AddWithValue("@schid", schedId)
                    alreadyExists = chk.ExecuteScalar()
                End Using

                If alreadyExists IsNot Nothing AndAlso Not IsDBNull(alreadyExists) Then Continue For

                Using ins As New MySqlCommand(
                    "INSERT INTO enrollment_details (enrollment_id, schedule_id)
                     VALUES (@eid, @schid)", conn)
                    ins.Parameters.AddWithValue("@eid", currentEnrollmentId)
                    ins.Parameters.AddWithValue("@schid", schedId)
                    ins.ExecuteNonQuery()
                    added += 1
                End Using
            Next

            MsgBox(added & " subject(s) enrolled successfully!" & vbNewLine &
                   "Enrollment ID: " & currentEnrollmentId, MsgBoxStyle.Information)

            LoadAvailableSchedules()
            dgvSelected.Rows.Clear()
            UpdateTotalUnits()

        Catch ex As Exception
            MsgBox("Enrollment error: " & ex.Message)
        Finally
            closeCon()
        End Try
    End Sub

    ' =========================================================
    ' RELOAD ON SEM / SCHOOL YEAR CHANGE
    ' =========================================================
    Private Sub cmbSemester_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbSemester.SelectedIndexChanged
        If Not String.IsNullOrEmpty(currentStudentId) Then
            LoadAvailableSchedules()
            dgvSelected.Rows.Clear()
            UpdateTotalUnits()
        End If
    End Sub

    Private Sub txtAcadYear_Leave(sender As Object, e As EventArgs) Handles txtAcadYear.Leave
        If Not String.IsNullOrEmpty(currentStudentId) Then
            LoadAvailableSchedules()
            dgvSelected.Rows.Clear()
            UpdateTotalUnits()
        End If
    End Sub


    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        ClearAll()
    End Sub

    Private Sub ClearAll()
        currentStudentId = ""
        currentEnrollmentId = 0
        txtStudentID.Clear()
        txtStudentName.Clear()
        txtCourse.Clear()
        txtYearLevel.Clear()
        dgvAvailable.DataSource = Nothing
        dgvSelected.Rows.Clear()
        lblAvailable.Text = "Available Schedules"
        lblTotalUnits.Text = "Total Units: 0"
    End Sub

    Private Sub dgvAvailable_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvAvailable.CellContentClick

    End Sub
End Class
