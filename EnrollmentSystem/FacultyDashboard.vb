Imports MySql.Data.MySqlClient

Public Class FacultyDashboard

    Private currentFacultyId As Integer = 0

    ' =========================================================
    ' FORM LOAD
    ' =========================================================
    Private Sub FacultyDashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Get faculty_id from login session
        currentFacultyId = UserSession.CurrentCashierID

        cmbSemesterFilter.SelectedIndex = 0
        LoadDashboardStats()
        LoadSchedules()
    End Sub

    ' =========================================================
    ' LOAD DASHBOARD STATS
    ' =========================================================
    Private Sub LoadDashboardStats()
        Try
            openCon()

            ' Total active class sections
            Using cmd As New MySqlCommand(
                "SELECT COUNT(*) FROM schedules WHERE faculty_id = @fid", conn)
                cmd.Parameters.AddWithValue("@fid", currentFacultyId)
                lblTotalClassesValue.Text = cmd.ExecuteScalar().ToString()
            End Using

            ' Total handled students (APPROVED only)
            Using cmd As New MySqlCommand(
                "SELECT COUNT(DISTINCT e.student_id)
                 FROM enrollment_details ed
                 INNER JOIN enrollments e ON ed.enrollment_id = e.enrollment_id
                 INNER JOIN schedules sc ON ed.schedule_id = sc.schedule_id
                 WHERE sc.faculty_id = @fid
                 AND e.status = 'APPROVED'", conn)
                cmd.Parameters.AddWithValue("@fid", currentFacultyId)
                lblTotalStudentsValue.Text = cmd.ExecuteScalar().ToString()
            End Using

            ' Students without grades
            Using cmd As New MySqlCommand(
                "SELECT COUNT(*)
                 FROM enrollment_details ed
                 INNER JOIN schedules sc ON ed.schedule_id = sc.schedule_id
                 LEFT JOIN grades g ON ed.detail_id = g.enrollment_detail_id
                 WHERE sc.faculty_id = @fid AND g.grade_id IS NULL", conn)
                cmd.Parameters.AddWithValue("@fid", currentFacultyId)
                lblPendingGradesValue.Text = cmd.ExecuteScalar().ToString()
            End Using

        Catch ex As Exception
            MsgBox("Error loading stats: " & ex.Message)
        Finally
            closeCon()
        End Try
    End Sub

    ' =========================================================
    ' LOAD SCHEDULES
    ' =========================================================
    Private Sub LoadSchedules()
        Try
            openCon()

            Dim semFilter As String = cmbSemesterFilter.Text

            Dim query As String =
                "SELECT sc.schedule_id AS 'Code',
                        sub.subject_name AS 'Subject Name',
                        IFNULL(sec.section_name, 'N/A') AS 'Section',
                        sc.day_of_week AS 'Days',
                        TIME_FORMAT(sc.start_time, '%h:%i %p') AS 'Start',
                        TIME_FORMAT(sc.end_time, '%h:%i %p') AS 'End',
                        sc.room AS 'Room',
                        sc.semester,
                        sc.academic_year
                 FROM schedules sc
                 INNER JOIN subjects sub ON sc.subject_id = sub.subject_id
                 LEFT JOIN section_schedules ss ON sc.schedule_id = ss.schedule_id
                 LEFT JOIN sections sec ON ss.section_id = sec.section_id
                 WHERE sc.faculty_id = @fid"

            ' Apply semester filter if not "All"
            If semFilter <> "All" AndAlso semFilter <> "" Then
                query &= " AND sc.semester = @sem"
            End If

            query &= " ORDER BY sc.day_of_week, sc.start_time"

            Using cmd As New MySqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@fid", currentFacultyId)
                If semFilter <> "All" AndAlso semFilter <> "" Then
                    cmd.Parameters.AddWithValue("@sem", semFilter)
                End If

                Dim dt As New DataTable
                Dim da As New MySqlDataAdapter(cmd)
                da.Fill(dt)

                dgvSchedules.DataSource = dt

                If dgvSchedules.Columns.Contains("semester") Then
                    dgvSchedules.Columns("semester").Visible = False
                End If
                If dgvSchedules.Columns.Contains("academic_year") Then
                    dgvSchedules.Columns("academic_year").Visible = False
                End If
            End Using

        Catch ex As Exception
            MsgBox("Error loading schedules: " & ex.Message)
        Finally
            closeCon()
        End Try
    End Sub

    ' =========================================================
    ' NAVIGATION BUTTONS
    ' =========================================================
    Private Sub btnDashboard_Click(sender As Object, e As EventArgs) Handles btnDashboard.Click
        LoadDashboardStats()
        LoadSchedules()
    End Sub


    Private Sub btnEncodeGrades_Click(sender As Object, e As EventArgs) Handles btnEncodeGrades.Click
        Dim f As New EncodeGradesForm()
        f.Show()
    End Sub

    Private Sub btnAnnouncements_Click(sender As Object, e As EventArgs) Handles btnAnnouncements.Click
        Dim f As New AnnouncementForm()
        f.Show()
    End Sub



    ' =========================================================
    ' SEMESTER FILTER
    ' =========================================================
    Private Sub cmbSemesterFilter_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbSemesterFilter.SelectedIndexChanged
        LoadSchedules()
    End Sub

    ' =========================================================
    ' DOUBLE CLICK SCHEDULE ROW - OPEN CLASS LIST
    ' =========================================================
    Private Sub dgvSchedules_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvSchedules.CellContentClick
        If e.RowIndex < 0 Then Return
        Dim f As New ClassListForm()
        f.Show()
    End Sub

    Private Sub btnGradeMaster_Click(sender As Object, e As EventArgs) Handles btnGradeMaster.Click
        Dim f As New StudentMasterlistForm()
        f.Show()
    End Sub
End Class
