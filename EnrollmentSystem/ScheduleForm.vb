Imports MySql.Data.MySqlClient

Public Class ScheduleForm

    Private selectedScheduleId As Integer = 0

    ' ================================================================
    ' FORM LOAD
    ' ================================================================
    Private Sub ScheduleForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadSubjectCombo()
        LoadInstructorCombo()
        LoadAcadYearCombo()
        LoadSchedules()
    End Sub

    ' ================================================================
    ' LOAD COMBOS FROM DATABASE
    ' ================================================================
    Private Sub LoadSubjectCombo()
        Try
            openCon()
            Using cmd As New MySqlCommand(
                "SELECT subject_id, CONCAT(subject_code, ' - ', subject_name) AS display_name
                 FROM subjects ORDER BY subject_code", conn)
                Dim dt As New DataTable
                Dim da As New MySqlDataAdapter(cmd)
                da.Fill(dt)
                cmbSubject.DataSource    = dt
                cmbSubject.ValueMember   = "subject_id"
                cmbSubject.DisplayMember = "display_name"
                cmbSubject.SelectedIndex = -1
            End Using
        Catch ex As Exception
            MsgBox("Error loading subjects: " & ex.Message)
        Finally
            closeCon()
        End Try
    End Sub

    Private Sub LoadInstructorCombo()
        Try
            openCon()
            Using cmd As New MySqlCommand(
                "SELECT id, username AS full_name FROM users
                 WHERE role = 'Faculty' AND status = 'VERIFIED'
                 ORDER BY username", conn)
                Dim dt As New DataTable
                Dim da As New MySqlDataAdapter(cmd)
                da.Fill(dt)
                cmbInstructor.DataSource    = dt
                cmbInstructor.ValueMember   = "id"
                cmbInstructor.DisplayMember = "full_name"
                cmbInstructor.SelectedIndex = -1
            End Using
        Catch ex As Exception
            MsgBox("Error loading instructors: " & ex.Message)
        Finally
            closeCon()
        End Try
    End Sub

    Private Sub LoadAcadYearCombo()
        ' Populate academic year filter from existing data + current year
        Dim currentYear As Integer = DateTime.Now.Year
        Dim years As New List(Of String)
        For i As Integer = -1 To 2
            years.Add((currentYear + i) & "-" & (currentYear + i + 1))
        Next
        cmbAYFilter.Items.Clear()
        cmbAYFilter.Items.Add("All")
        For Each y As String In years
            cmbAYFilter.Items.Add(y)
        Next
        cmbAYFilter.SelectedIndex = 0
        ' Default academic year in form
        txtAcadYear.Text = currentYear & "-" & (currentYear + 1)
    End Sub

    ' ================================================================
    ' LOAD SCHEDULES INTO GRID (with optional semester/year filter)
    ' ================================================================
    Private Sub LoadSchedules()
        Try
            openCon()

            Dim semFilter As String = cmbSemFilter.Text
            Dim ayFilter  As String = cmbAYFilter.Text

            Dim query As String =
                "SELECT sc.schedule_id,
                        sub.subject_code,
                        sub.subject_name,
                        sub.units,
                        u.username        AS instructor,
                        sc.day_of_week,
                        TIME_FORMAT(sc.start_time, '%h:%i %p') AS start_time,
                        TIME_FORMAT(sc.end_time,   '%h:%i %p') AS end_time,
                        sc.room,
                        sc.semester,
                        sc.academic_year,
                        sc.max_slots,
                        COUNT(ed.detail_id) AS enrolled
                 FROM schedules sc
                 INNER JOIN subjects sub ON sc.subject_id  = sub.subject_id
                 LEFT  JOIN users    u   ON sc.faculty_id  = u.id
                 LEFT  JOIN enrollment_details ed ON ed.schedule_id = sc.schedule_id"

            Dim conditions As New List(Of String)
            If semFilter <> "All" AndAlso semFilter <> "" Then
                conditions.Add("sc.semester = @sem")
            End If
            If ayFilter <> "All" AndAlso ayFilter <> "" Then
                conditions.Add("sc.academic_year = @ay")
            End If
            If conditions.Count > 0 Then
                query &= " WHERE " & String.Join(" AND ", conditions)
            End If

            query &= " GROUP BY sc.schedule_id ORDER BY sc.day_of_week, sc.start_time"

            Using cmd As New MySqlCommand(query, conn)
                If semFilter <> "All" AndAlso semFilter <> "" Then
                    cmd.Parameters.AddWithValue("@sem", semFilter)
                End If
                If ayFilter <> "All" AndAlso ayFilter <> "" Then
                    cmd.Parameters.AddWithValue("@ay", ayFilter)
                End If

                Dim dt As New DataTable
                Dim da As New MySqlDataAdapter(cmd)
                da.Fill(dt)

                ' Add a Slots column showing "enrolled / max"
                dt.Columns.Add("slots_display", GetType(String))
                For Each row As DataRow In dt.Rows
                    row("slots_display") = row("enrolled").ToString() & " / " & row("max_slots").ToString()
                Next

                ' Hide raw columns, show friendly ones
                dgvSchedule.DataSource = dt
                HideGridColumns()

                lblSection.Text = "Total Schedules: " & dt.Rows.Count.ToString()
            End Using

        Catch ex As Exception
            MsgBox("Error loading schedules: " & ex.Message)
        Finally
            closeCon()
        End Try
    End Sub

    Private Sub HideGridColumns()
        Dim hideCols As String() = {"schedule_id", "max_slots", "enrolled"}
        For Each col As String In hideCols
            If dgvSchedule.Columns.Contains(col) Then
                dgvSchedule.Columns(col).Visible = False
            End If
        Next

        ' Rename headers for readability
        Dim headers As New Dictionary(Of String, String) From {
            {"subject_code",  "Code"},
            {"subject_name",  "Subject"},
            {"units",         "Units"},
            {"instructor",    "Instructor"},
            {"day_of_week",   "Day"},
            {"start_time",    "Start"},
            {"end_time",      "End"},
            {"room",          "Room"},
            {"semester",      "Semester"},
            {"academic_year", "School Year"},
            {"slots_display", "Slots (Enrolled/Max)"}
        }
        For Each kv In headers
            If dgvSchedule.Columns.Contains(kv.Key) Then
                dgvSchedule.Columns(kv.Key).HeaderText = kv.Value
            End If
        Next
    End Sub

    ' ================================================================
    ' FILTER BUTTON
    ' ================================================================
    Private Sub btnFilter_Click(sender As Object, e As EventArgs) Handles btnFilter.Click
        LoadSchedules()
    End Sub

    ' ================================================================
    ' ROW CLICK → AUTO FILL CONTROLS
    ' ================================================================
    Private Sub dgvSchedule_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvSchedule.CellClick
        If e.RowIndex < 0 Then Return

        Try
            Dim row As DataGridViewRow = dgvSchedule.Rows(e.RowIndex)
            selectedScheduleId = Convert.ToInt32(row.Cells("schedule_id").Value)

            ' Re-query raw IDs so ComboBoxes set correctly
            openCon()
            Using cmd As New MySqlCommand(
                "SELECT subject_id, faculty_id, day_of_week, start_time, end_time,
                        room, semester, academic_year, max_slots
                 FROM schedules WHERE schedule_id = @id", conn)
                cmd.Parameters.AddWithValue("@id", selectedScheduleId)
                Using dr As MySqlDataReader = cmd.ExecuteReader()
                    If dr.Read() Then
                        cmbSubject.SelectedValue   = dr("subject_id")
                        cmbInstructor.SelectedValue = If(IsDBNull(dr("faculty_id")), Nothing, dr("faculty_id"))
                        cmbDay.Text                = dr("day_of_week").ToString()
                        dtpStart.Value             = DateTime.Parse(dr("start_time").ToString())
                        dtpEnd.Value               = DateTime.Parse(dr("end_time").ToString())
                        txtRoom.Text               = dr("room").ToString()
                        cmbSemester.Text           = dr("semester").ToString()
                        txtAcadYear.Text           = dr("academic_year").ToString()
                        txtMaxSlots.Text           = dr("max_slots").ToString()
                    End If
                End Using
            End Using

        Catch ex As Exception
            MsgBox("Error selecting row: " & ex.Message)
        Finally
            closeCon()
        End Try
    End Sub

    ' ================================================================
    ' VALIDATION
    ' ================================================================
    Private Function ValidateInputs() As Boolean
        If cmbSubject.SelectedValue Is Nothing Then
            MsgBox("Please select a subject.", MsgBoxStyle.Exclamation) : Return False
        End If
        If cmbInstructor.SelectedValue Is Nothing Then
            MsgBox("Please select an instructor.", MsgBoxStyle.Exclamation) : Return False
        End If
        If cmbDay.SelectedIndex < 0 Then
            MsgBox("Please select a day.", MsgBoxStyle.Exclamation) : Return False
        End If
        If dtpEnd.Value <= dtpStart.Value Then
            MsgBox("End time must be after start time.", MsgBoxStyle.Exclamation) : Return False
        End If
        If String.IsNullOrWhiteSpace(txtRoom.Text) Then
            MsgBox("Please enter a room.", MsgBoxStyle.Exclamation) : Return False
        End If
        If cmbSemester.SelectedIndex < 0 Then
            MsgBox("Please select a semester.", MsgBoxStyle.Exclamation) : Return False
        End If
        If String.IsNullOrWhiteSpace(txtAcadYear.Text) Then
            MsgBox("Please enter the school year (e.g. 2024-2025).", MsgBoxStyle.Exclamation) : Return False
        End If
        If Val(txtMaxSlots.Text) <= 0 Then
            MsgBox("Max slots must be greater than 0.", MsgBoxStyle.Exclamation) : Return False
        End If
        Return True
    End Function

    ' ================================================================
    ' CONFLICT CHECKS
    ' ================================================================
    ' Returns True if a conflict exists (blocks save)
    Private Function HasInstructorConflict(excludeId As Integer) As Boolean
        Try
            openCon()
            Dim query As String =
                "SELECT COUNT(*) FROM schedules
                 WHERE faculty_id   = @fid
                 AND   day_of_week  = @day
                 AND   semester     = @sem
                 AND   academic_year = @ay
                 AND   schedule_id  <> @excl
                 AND   (
                     (@start < end_time AND @end > start_time)
                 )"
            Using cmd As New MySqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@fid",   cmbInstructor.SelectedValue)
                cmd.Parameters.AddWithValue("@day",   cmbDay.Text)
                cmd.Parameters.AddWithValue("@sem",   cmbSemester.Text)
                cmd.Parameters.AddWithValue("@ay",    txtAcadYear.Text)
                cmd.Parameters.AddWithValue("@start", dtpStart.Value.ToString("HH:mm:ss"))
                cmd.Parameters.AddWithValue("@end",   dtpEnd.Value.ToString("HH:mm:ss"))
                cmd.Parameters.AddWithValue("@excl",  excludeId)
                Return Convert.ToInt32(cmd.ExecuteScalar()) > 0
            End Using
        Finally
            closeCon()
        End Try
    End Function

    Private Function HasRoomConflict(excludeId As Integer) As Boolean
        Try
            openCon()
            Dim query As String =
                "SELECT COUNT(*) FROM schedules
                 WHERE room         = @room
                 AND   day_of_week  = @day
                 AND   semester     = @sem
                 AND   academic_year = @ay
                 AND   schedule_id  <> @excl
                 AND   (
                     (@start < end_time AND @end > start_time)
                 )"
            Using cmd As New MySqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@room",  txtRoom.Text.Trim())
                cmd.Parameters.AddWithValue("@day",   cmbDay.Text)
                cmd.Parameters.AddWithValue("@sem",   cmbSemester.Text)
                cmd.Parameters.AddWithValue("@ay",    txtAcadYear.Text)
                cmd.Parameters.AddWithValue("@start", dtpStart.Value.ToString("HH:mm:ss"))
                cmd.Parameters.AddWithValue("@end",   dtpEnd.Value.ToString("HH:mm:ss"))
                cmd.Parameters.AddWithValue("@excl",  excludeId)
                Return Convert.ToInt32(cmd.ExecuteScalar()) > 0
            End Using
        Finally
            closeCon()
        End Try
    End Function

    ' ================================================================
    ' ADD
    ' ================================================================
    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        If Not ValidateInputs() Then Return

        If HasInstructorConflict(0) Then
            MsgBox("⚠ Conflict: This instructor already has a class on " &
                   cmbDay.Text & " at that time slot.", MsgBoxStyle.Exclamation)
            Return
        End If

        If HasRoomConflict(0) Then
            MsgBox("⚠ Conflict: Room " & txtRoom.Text &
                   " is already occupied on " & cmbDay.Text & " at that time slot.", MsgBoxStyle.Exclamation)
            Return
        End If

        Try
            openCon()
            Using cmd As New MySqlCommand(
                "INSERT INTO schedules
                    (subject_id, faculty_id, day_of_week, start_time, end_time,
                     room, semester, academic_year, max_slots)
                 VALUES
                    (@sub, @fac, @day, @start, @end,
                     @room, @sem, @ay, @slots)", conn)
                cmd.Parameters.AddWithValue("@sub",   cmbSubject.SelectedValue)
                cmd.Parameters.AddWithValue("@fac",   cmbInstructor.SelectedValue)
                cmd.Parameters.AddWithValue("@day",   cmbDay.Text)
                cmd.Parameters.AddWithValue("@start", dtpStart.Value.ToString("HH:mm:ss"))
                cmd.Parameters.AddWithValue("@end",   dtpEnd.Value.ToString("HH:mm:ss"))
                cmd.Parameters.AddWithValue("@room",  txtRoom.Text.Trim())
                cmd.Parameters.AddWithValue("@sem",   cmbSemester.Text)
                cmd.Parameters.AddWithValue("@ay",    txtAcadYear.Text.Trim())
                cmd.Parameters.AddWithValue("@slots", Val(txtMaxSlots.Text))
                cmd.ExecuteNonQuery()
            End Using
            MsgBox("Schedule added successfully!", MsgBoxStyle.Information)
            LoadSchedules()
            ClearFields()
        Catch ex As Exception
            MsgBox("Error adding schedule: " & ex.Message)
        Finally
            closeCon()
        End Try
    End Sub

    ' ================================================================
    ' UPDATE
    ' ================================================================
    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        If selectedScheduleId = 0 Then
            MsgBox("Please select a schedule to update.", MsgBoxStyle.Exclamation) : Return
        End If
        If Not ValidateInputs() Then Return

        If HasInstructorConflict(selectedScheduleId) Then
            MsgBox("⚠ Conflict: This instructor already has a class on " &
                   cmbDay.Text & " at that time slot.", MsgBoxStyle.Exclamation)
            Return
        End If

        If HasRoomConflict(selectedScheduleId) Then
            MsgBox("⚠ Conflict: Room " & txtRoom.Text &
                   " is already occupied on " & cmbDay.Text & " at that time slot.", MsgBoxStyle.Exclamation)
            Return
        End If

        Try
            openCon()
            Using cmd As New MySqlCommand(
                "UPDATE schedules SET
                    subject_id   = @sub,
                    faculty_id   = @fac,
                    day_of_week  = @day,
                    start_time   = @start,
                    end_time     = @end,
                    room         = @room,
                    semester     = @sem,
                    academic_year = @ay,
                    max_slots    = @slots
                 WHERE schedule_id = @id", conn)
                cmd.Parameters.AddWithValue("@sub",   cmbSubject.SelectedValue)
                cmd.Parameters.AddWithValue("@fac",   cmbInstructor.SelectedValue)
                cmd.Parameters.AddWithValue("@day",   cmbDay.Text)
                cmd.Parameters.AddWithValue("@start", dtpStart.Value.ToString("HH:mm:ss"))
                cmd.Parameters.AddWithValue("@end",   dtpEnd.Value.ToString("HH:mm:ss"))
                cmd.Parameters.AddWithValue("@room",  txtRoom.Text.Trim())
                cmd.Parameters.AddWithValue("@sem",   cmbSemester.Text)
                cmd.Parameters.AddWithValue("@ay",    txtAcadYear.Text.Trim())
                cmd.Parameters.AddWithValue("@slots", Val(txtMaxSlots.Text))
                cmd.Parameters.AddWithValue("@id",    selectedScheduleId)
                cmd.ExecuteNonQuery()
            End Using
            MsgBox("Schedule updated successfully!", MsgBoxStyle.Information)
            LoadSchedules()
            ClearFields()
        Catch ex As Exception
            MsgBox("Error updating schedule: " & ex.Message)
        Finally
            closeCon()
        End Try
    End Sub

    ' ================================================================
    ' DELETE
    ' ================================================================
    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If selectedScheduleId = 0 Then
            MsgBox("Please select a schedule to delete.", MsgBoxStyle.Exclamation) : Return
        End If

        ' Check if students are already enrolled in this schedule
        Try
            openCon()
            Dim enrolledCount As Integer = 0
            Using cmd As New MySqlCommand(
                "SELECT COUNT(*) FROM enrollment_details WHERE schedule_id = @id", conn)
                cmd.Parameters.AddWithValue("@id", selectedScheduleId)
                enrolledCount = Convert.ToInt32(cmd.ExecuteScalar())
            End Using

            If enrolledCount > 0 Then
                Dim confirm As MsgBoxResult = MsgBox(
                    "⚠ Warning: " & enrolledCount & " student(s) are enrolled in this schedule." &
                    vbNewLine & "Deleting it will also remove their enrollment details." &
                    vbNewLine & vbNewLine & "Are you sure you want to continue?",
                    MsgBoxStyle.YesNo Or MsgBoxStyle.Critical, "Confirm Delete")
                If confirm = MsgBoxResult.No Then Return
            Else
                If MsgBox("Delete this schedule?", MsgBoxStyle.YesNo Or MsgBoxStyle.Question) = MsgBoxResult.No Then Return
            End If

            Using cmd As New MySqlCommand(
                "DELETE FROM schedules WHERE schedule_id = @id", conn)
                cmd.Parameters.AddWithValue("@id", selectedScheduleId)
                cmd.ExecuteNonQuery()
            End Using

            MsgBox("Schedule deleted.", MsgBoxStyle.Information)
            LoadSchedules()
            ClearFields()

        Catch ex As Exception
            MsgBox("Error deleting schedule: " & ex.Message)
        Finally
            closeCon()
        End Try
    End Sub

    ' ================================================================
    ' CLEAR
    ' ================================================================
    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        ClearFields()
    End Sub

    Private Sub ClearFields()
        selectedScheduleId       = 0
        cmbSubject.SelectedIndex  = -1
        cmbInstructor.SelectedIndex = -1
        cmbDay.SelectedIndex      = -1
        dtpStart.Value            = DateTime.Today.AddHours(7)
        dtpEnd.Value              = DateTime.Today.AddHours(8)
        txtRoom.Clear()
        cmbSemester.SelectedIndex = 0
        txtAcadYear.Text          = DateTime.Now.Year & "-" & (DateTime.Now.Year + 1)
        txtMaxSlots.Text          = "40"
        dgvSchedule.ClearSelection()
    End Sub

End Class
