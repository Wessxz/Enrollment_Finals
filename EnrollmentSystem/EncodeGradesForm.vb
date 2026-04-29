Imports MySql.Data.MySqlClient

Public Class EncodeGradesForm

    Private facultyId As Integer = 0
    Private currentEnrollmentId As Integer = 0
    Private currentSubjectId As Integer = 0

    Private Sub EncodeGradesForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        facultyId = UserSession.CurrentCashierID
        InitializeTermComboBox()
        LoadFacultySubjects()
    End Sub

    ' =========================================================
    ' INITIALIZE TERM COMBOBOX
    ' =========================================================
    Private Sub InitializeTermComboBox()
        cmbterm.Items.Clear()
        cmbterm.Items.Add("Prelim")
        cmbterm.Items.Add("Midterm")
        cmbterm.Items.Add("Pre-Final")
        cmbterm.Items.Add("Final")
        cmbterm.SelectedIndex = 0
    End Sub

    ' =========================================================
    ' LOAD FACULTY SUBJECTS INTO COMBOBOX
    ' =========================================================
    Private Sub LoadFacultySubjects()
        Try
            openCon()

            Dim query As String =
                "SELECT DISTINCT sc.schedule_id, sc.subject_id,
                        CONCAT(sub.subject_code, ' - ', sub.subject_name, ' (', sc.semester, ')') AS subject_display
                 FROM schedules sc
                 INNER JOIN subjects sub ON sc.subject_id = sub.subject_id
                 WHERE sc.faculty_id = @fid
                 ORDER BY sub.subject_code"

            Using cmd As New MySqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@fid", facultyId)

                cmbSubject.Items.Clear()
                cmbSubject.Items.Add("-- Select Subject --")

                Using reader As MySqlDataReader = cmd.ExecuteReader()
                    While reader.Read()
                        cmbSubject.Items.Add(New With {
                            .ScheduleId = reader("schedule_id"),
                            .SubjectId = reader("subject_id"),
                            .Display = reader("subject_display").ToString()
                        })
                    End While
                End Using

                cmbSubject.DisplayMember = "Display"
                cmbSubject.SelectedIndex = 0
            End Using

        Catch ex As Exception
            MsgBox("Error loading subjects: " & ex.Message)
        Finally
            closeCon()
        End Try
    End Sub

    ' =========================================================
    ' SUBJECT CHANGED - LOAD GRADES FOR SELECTED SUBJECT
    ' =========================================================
    Private Sub cmbSubject_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbSubject.SelectedIndexChanged
        If cmbSubject.SelectedIndex > 0 Then
            Dim selected = CType(cmbSubject.SelectedItem, Object)
            currentSubjectId = selected.SubjectId
            LoadStudentGrades()
            ClearForm()
        End If
    End Sub

    ' =========================================================
    ' TERM CHANGED - RELOAD GRADE IF STUDENT ALREADY SEARCHED
    ' =========================================================
    Private Sub cmbterm_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbterm.SelectedIndexChanged
        If currentEnrollmentId > 0 AndAlso Not String.IsNullOrWhiteSpace(txtStudentID.Text) Then
            LoadExistingGradeForStudent()
        End If
    End Sub

    ' =========================================================
    ' SEARCH STUDENT
    ' =========================================================
    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        If String.IsNullOrWhiteSpace(txtStudentID.Text) Then
            MsgBox("Please enter a Student ID.", MsgBoxStyle.Exclamation)
            Return
        End If

        If cmbSubject.SelectedIndex <= 0 Then
            MsgBox("Please select a subject first.", MsgBoxStyle.Exclamation)
            Return
        End If

        Try
            openCon()

            Dim selected = CType(cmbSubject.SelectedItem, Object)
            Dim scheduleId As Integer = selected.ScheduleId
            currentSubjectId = selected.SubjectId

            ' Find student and their enrollment_id for this schedule
            Dim query As String =
                "SELECT s.student_id,
                        CONCAT(s.first_name, ' ', s.last_name) AS student_name,
                        s.course,
                        e.enrollment_id
                 FROM students s
                 INNER JOIN enrollments e ON s.student_id = e.student_id
                 INNER JOIN enrollment_details ed ON e.enrollment_id = ed.enrollment_id
                 WHERE s.student_id = @sid
                 AND ed.schedule_id = @scheduleId
                 LIMIT 1"

            Using cmd As New MySqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@sid", txtStudentID.Text.Trim())
                cmd.Parameters.AddWithValue("@scheduleId", scheduleId)

                Using reader As MySqlDataReader = cmd.ExecuteReader()
                    If reader.Read() Then
                        txtStudentName.Text = reader("student_name").ToString()
                        txtCourse.Text = reader("course").ToString()
                        currentEnrollmentId = Convert.ToInt32(reader("enrollment_id"))
                    Else
                        MsgBox("Student not found in this subject.", MsgBoxStyle.Exclamation)
                        ClearForm()
                        Return
                    End If
                End Using
            End Using

            ' Load existing grade for selected term
            LoadExistingGradeForStudent()

        Catch ex As Exception
            MsgBox("Error searching student: " & ex.Message)
        Finally
            closeCon()
        End Try
    End Sub

    ' =========================================================
    ' LOAD EXISTING GRADE FOR CURRENT STUDENT + TERM
    ' =========================================================
    Private Sub LoadExistingGradeForStudent()
        If currentEnrollmentId = 0 OrElse currentSubjectId = 0 Then Return

        Try
            openCon()

            Using cmd As New MySqlCommand(
                "SELECT grade_value FROM grades
                 WHERE enrollment_id = @eid
                 AND subject_id = @sid
                 AND term = @term
                 LIMIT 1", conn)
                cmd.Parameters.AddWithValue("@eid", currentEnrollmentId)
                cmd.Parameters.AddWithValue("@sid", currentSubjectId)
                cmd.Parameters.AddWithValue("@term", cmbterm.Text)

                Dim result = cmd.ExecuteScalar()
                txtGrade.Text = If(result IsNot Nothing AndAlso Not IsDBNull(result),
                                   result.ToString(), "")
            End Using

        Catch ex As Exception
            MsgBox("Error loading grade: " & ex.Message)
        Finally
            closeCon()
        End Try
    End Sub

    ' =========================================================
    ' SAVE GRADE
    ' =========================================================
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If currentEnrollmentId = 0 Then
            MsgBox("Please search for a student first.", MsgBoxStyle.Exclamation)
            Return
        End If

        If String.IsNullOrWhiteSpace(txtGrade.Text) Then
            MsgBox("Please enter a grade.", MsgBoxStyle.Exclamation)
            Return
        End If

        ' Validate grade
        Dim grade As String = txtGrade.Text.Trim().ToUpper()
        If grade <> "INC" AndAlso grade <> "DRP" Then
            Dim numGrade As Decimal
            If Not Decimal.TryParse(grade, numGrade) OrElse numGrade < 1.0 OrElse numGrade > 5.0 Then
                MsgBox("Grade must be 1.00-5.00, INC, or DRP.", MsgBoxStyle.Exclamation)
                Return
            End If
        End If

        ' Determine remarks
        Dim remarks As String = ""
        If grade = "INC" Then
            remarks = "INCOMPLETE"
        ElseIf grade = "DRP" Then
            remarks = "DROPPED"
        Else
            Dim numGrade As Decimal = Decimal.Parse(grade)
            remarks = If(numGrade <= 3.0, "PASSED", "FAILED")
        End If

        Try
            openCon()

            ' Check if grade already exists for this enrollment + subject + term
            Dim gradeExists As Boolean = False
            Using cmd As New MySqlCommand(
                "SELECT COUNT(*) FROM grades
                 WHERE enrollment_id = @eid AND subject_id = @sid AND term = @term", conn)
                cmd.Parameters.AddWithValue("@eid", currentEnrollmentId)
                cmd.Parameters.AddWithValue("@sid", currentSubjectId)
                cmd.Parameters.AddWithValue("@term", cmbterm.Text)
                gradeExists = Convert.ToInt32(cmd.ExecuteScalar()) > 0
            End Using

            If gradeExists Then
                ' Update existing
                Using cmd As New MySqlCommand(
                    "UPDATE grades SET grade_value = @grade, remarks = @remarks,
                     encoded_by = @encodedBy, date_encoded = NOW()
                     WHERE enrollment_id = @eid AND subject_id = @sid AND term = @term", conn)
                    cmd.Parameters.AddWithValue("@grade", grade)
                    cmd.Parameters.AddWithValue("@remarks", remarks)
                    cmd.Parameters.AddWithValue("@encodedBy", facultyId)
                    cmd.Parameters.AddWithValue("@eid", currentEnrollmentId)
                    cmd.Parameters.AddWithValue("@sid", currentSubjectId)
                    cmd.Parameters.AddWithValue("@term", cmbterm.Text)
                    cmd.ExecuteNonQuery()
                End Using
            Else
                ' Insert new
                Using cmd As New MySqlCommand(
                    "INSERT INTO grades (enrollment_id, subject_id, term, grade_value, remarks, encoded_by, date_encoded)
                     VALUES (@eid, @sid, @term, @grade, @remarks, @encodedBy, NOW())", conn)
                    cmd.Parameters.AddWithValue("@eid", currentEnrollmentId)
                    cmd.Parameters.AddWithValue("@sid", currentSubjectId)
                    cmd.Parameters.AddWithValue("@term", cmbterm.Text)
                    cmd.Parameters.AddWithValue("@grade", grade)
                    cmd.Parameters.AddWithValue("@remarks", remarks)
                    cmd.Parameters.AddWithValue("@encodedBy", facultyId)
                    cmd.ExecuteNonQuery()
                End Using
            End If

            MsgBox($"{cmbterm.Text} grade saved successfully!", MsgBoxStyle.Information)
            LoadStudentGrades()
            ClearForm()

        Catch ex As Exception
            MsgBox("Error saving grade: " & ex.Message)
        Finally
            closeCon()
        End Try
    End Sub

    ' =========================================================
    ' LOAD ALL STUDENT GRADES FOR SELECTED SUBJECT (ALL TERMS)
    ' =========================================================
    Private Sub LoadStudentGrades()
        If cmbSubject.SelectedIndex <= 0 Then Return

        Try
            openCon()

            Dim selected = CType(cmbSubject.SelectedItem, Object)
            Dim scheduleId As Integer = selected.ScheduleId
            Dim subjectId As Integer = selected.SubjectId

            Dim query As String =
                "SELECT s.student_id AS 'Student ID',
                        CONCAT(s.first_name, ' ', s.last_name) AS 'Student Name',
                        IFNULL(MAX(CASE WHEN g.term = 'Prelim'    THEN g.grade_value END), '-') AS 'Prelim',
                        IFNULL(MAX(CASE WHEN g.term = 'Midterm'   THEN g.grade_value END), '-') AS 'Midterm',
                        IFNULL(MAX(CASE WHEN g.term = 'Pre-Final' THEN g.grade_value END), '-') AS 'Pre-Final',
                        IFNULL(MAX(CASE WHEN g.term = 'Final'     THEN g.grade_value END), '-') AS 'Final',
                        CASE
                            WHEN MAX(CASE WHEN g.term = 'Prelim'    THEN g.grade_value END) IS NULL
                              OR MAX(CASE WHEN g.term = 'Midterm'   THEN g.grade_value END) IS NULL
                              OR MAX(CASE WHEN g.term = 'Pre-Final' THEN g.grade_value END) IS NULL
                              OR MAX(CASE WHEN g.term = 'Final'     THEN g.grade_value END) IS NULL
                            THEN 'Incomplete'
                            WHEN MAX(CASE WHEN g.term = 'Prelim'    THEN g.grade_value END) IN ('INC','DRP')
                              OR MAX(CASE WHEN g.term = 'Midterm'   THEN g.grade_value END) IN ('INC','DRP')
                              OR MAX(CASE WHEN g.term = 'Pre-Final' THEN g.grade_value END) IN ('INC','DRP')
                              OR MAX(CASE WHEN g.term = 'Final'     THEN g.grade_value END) IN ('INC','DRP')
                            THEN IFNULL(MAX(CASE WHEN g.term = 'Final' THEN g.grade_value END), 'INC')
                            ELSE
                                CASE
                                    WHEN (
                                        CAST(MAX(CASE WHEN g.term = 'Prelim'    THEN g.grade_value END) AS DECIMAL(4,2)) * 0.25 +
                                        CAST(MAX(CASE WHEN g.term = 'Midterm'   THEN g.grade_value END) AS DECIMAL(4,2)) * 0.25 +
                                        CAST(MAX(CASE WHEN g.term = 'Pre-Final' THEN g.grade_value END) AS DECIMAL(4,2)) * 0.25 +
                                        CAST(MAX(CASE WHEN g.term = 'Final'     THEN g.grade_value END) AS DECIMAL(4,2)) * 0.25
                                    ) <= 3.0 THEN 'PASSED'
                                    ELSE 'FAILED'
                                END
                        END AS 'Status',
                        CASE
                            WHEN MAX(CASE WHEN g.term = 'Prelim'    THEN g.grade_value END) IS NULL
                              OR MAX(CASE WHEN g.term = 'Midterm'   THEN g.grade_value END) IS NULL
                              OR MAX(CASE WHEN g.term = 'Pre-Final' THEN g.grade_value END) IS NULL
                              OR MAX(CASE WHEN g.term = 'Final'     THEN g.grade_value END) IS NULL
                            THEN '-'
                            WHEN MAX(CASE WHEN g.term = 'Prelim'    THEN g.grade_value END) IN ('INC','DRP')
                              OR MAX(CASE WHEN g.term = 'Midterm'   THEN g.grade_value END) IN ('INC','DRP')
                              OR MAX(CASE WHEN g.term = 'Pre-Final' THEN g.grade_value END) IN ('INC','DRP')
                              OR MAX(CASE WHEN g.term = 'Final'     THEN g.grade_value END) IN ('INC','DRP')
                            THEN '-'
                            ELSE CAST(ROUND(
                                CAST(MAX(CASE WHEN g.term = 'Prelim'    THEN g.grade_value END) AS DECIMAL(4,2)) * 0.25 +
                                CAST(MAX(CASE WHEN g.term = 'Midterm'   THEN g.grade_value END) AS DECIMAL(4,2)) * 0.25 +
                                CAST(MAX(CASE WHEN g.term = 'Pre-Final' THEN g.grade_value END) AS DECIMAL(4,2)) * 0.25 +
                                CAST(MAX(CASE WHEN g.term = 'Final'     THEN g.grade_value END) AS DECIMAL(4,2)) * 0.25
                            , 2) AS CHAR)
                        END AS 'GWA'
                 FROM enrollment_details ed
                 INNER JOIN enrollments e ON ed.enrollment_id = e.enrollment_id
                 INNER JOIN students s ON e.student_id = s.student_id
                 LEFT JOIN grades g ON e.enrollment_id = g.enrollment_id
                     AND g.subject_id = @subjectId
                 WHERE ed.schedule_id = @scheduleId
                 GROUP BY s.student_id, s.first_name, s.last_name
                 ORDER BY s.last_name, s.first_name"

            Using cmd As New MySqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@scheduleId", scheduleId)
                cmd.Parameters.AddWithValue("@subjectId", subjectId)
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

    ' =========================================================
    ' CLEAR FORM
    ' =========================================================
    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        ClearForm()
    End Sub

    Private Sub ClearForm()
        txtStudentID.Clear()
        txtStudentName.Clear()
        txtCourse.Clear()
        txtGrade.Clear()
        currentEnrollmentId = 0
    End Sub

End Class
