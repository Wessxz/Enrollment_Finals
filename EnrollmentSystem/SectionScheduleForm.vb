Imports MySql.Data.MySqlClient

Public Class SectionScheduleForm

    Private currentSectionId As Integer = 0

    Private Sub SectionScheduleForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadSectionCombo()
    End Sub

    ' ================================================================
    ' LOAD SECTIONS INTO COMBO
    ' ================================================================
    Private Sub LoadSectionCombo()
        Try
            openCon()
            Using cmd As New MySqlCommand(
                "SELECT section_id,
                        CONCAT(section_name, ' — ', course, ' ', year_level, ' (', semester, ' ', academic_year, ')') AS display_name
                 FROM sections ORDER BY academic_year DESC, section_name", conn)
                Dim dt As New DataTable
                Dim da As New MySqlDataAdapter(cmd)
                da.Fill(dt)
                cmbSection.DataSource    = dt
                cmbSection.ValueMember   = "section_id"
                cmbSection.DisplayMember = "display_name"
                cmbSection.SelectedIndex = -1
            End Using
        Catch ex As Exception
            MsgBox("Error loading sections: " & ex.Message)
        Finally
            closeCon()
        End Try
    End Sub

    ' ================================================================
    ' LOAD BUTTON — show available and assigned schedules
    ' ================================================================
    Private Sub btnLoadSection_Click(sender As Object, e As EventArgs) Handles btnLoadSection.Click
        If cmbSection.SelectedValue Is Nothing Then
            MsgBox("Please select a section.", MsgBoxStyle.Exclamation) : Return
        End If

        currentSectionId = Convert.ToInt32(cmbSection.SelectedValue)
        LoadAvailableSchedules()
        LoadAssignedSchedules()
    End Sub

    ' ================================================================
    ' AVAILABLE SCHEDULES (not yet assigned to this section)
    ' ================================================================
    Private Sub LoadAvailableSchedules()
        Try
            openCon()
            Dim query As String =
                "SELECT sc.schedule_id,
                        sub.subject_code,
                        sub.subject_name,
                        u.username AS instructor,
                        sc.day_of_week,
                        TIME_FORMAT(sc.start_time, '%h:%i %p') AS start_time,
                        TIME_FORMAT(sc.end_time,   '%h:%i %p') AS end_time,
                        sc.room,
                        sc.semester,
                        sc.academic_year
                 FROM schedules sc
                 INNER JOIN subjects sub ON sc.subject_id = sub.subject_id
                 LEFT  JOIN users u ON sc.faculty_id = u.id
                 WHERE sc.schedule_id NOT IN (
                     SELECT schedule_id FROM section_schedules WHERE section_id = @sid
                 )
                 ORDER BY sc.day_of_week, sc.start_time"

            Using cmd As New MySqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@sid", currentSectionId)
                Dim dt As New DataTable
                Dim da As New MySqlDataAdapter(cmd)
                da.Fill(dt)
                dgvAvailable.DataSource = dt
                If dgvAvailable.Columns.Contains("schedule_id") Then
                    dgvAvailable.Columns("schedule_id").Visible = False
                End If
                lblAvailable.Text = "Available Schedules (" & dt.Rows.Count & ")"
            End Using
        Catch ex As Exception
            MsgBox("Error loading available schedules: " & ex.Message)
        Finally
            closeCon()
        End Try
    End Sub

    ' ================================================================
    ' ASSIGNED SCHEDULES (already in this section)
    ' ================================================================
    Private Sub LoadAssignedSchedules()
        Try
            openCon()
            Dim query As String =
                "SELECT sc.schedule_id,
                        sub.subject_code,
                        sub.subject_name,
                        u.username AS instructor,
                        sc.day_of_week,
                        TIME_FORMAT(sc.start_time, '%h:%i %p') AS start_time,
                        TIME_FORMAT(sc.end_time,   '%h:%i %p') AS end_time,
                        sc.room
                 FROM section_schedules ss
                 INNER JOIN schedules sc ON ss.schedule_id = sc.schedule_id
                 INNER JOIN subjects sub ON sc.subject_id = sub.subject_id
                 LEFT  JOIN users u ON sc.faculty_id = u.id
                 WHERE ss.section_id = @sid
                 ORDER BY sc.day_of_week, sc.start_time"

            Using cmd As New MySqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@sid", currentSectionId)
                Dim dt As New DataTable
                Dim da As New MySqlDataAdapter(cmd)
                da.Fill(dt)
                dgvAssigned.DataSource = dt
                If dgvAssigned.Columns.Contains("schedule_id") Then
                    dgvAssigned.Columns("schedule_id").Visible = False
                End If
                lblAssigned.Text = "Schedules Assigned to Section (" & dt.Rows.Count & ")"
            End Using
        Catch ex As Exception
            MsgBox("Error loading assigned schedules: " & ex.Message)
        Finally
            closeCon()
        End Try
    End Sub

    ' ================================================================
    ' ASSIGN — move selected from Available → Assigned
    ' ================================================================
    Private Sub btnAssign_Click(sender As Object, e As EventArgs) Handles btnAssign.Click
        If currentSectionId = 0 Then
            MsgBox("Please load a section first.", MsgBoxStyle.Exclamation) : Return
        End If
        If dgvAvailable.CurrentRow Is Nothing Then
            MsgBox("Please select a schedule to assign.", MsgBoxStyle.Exclamation) : Return
        End If

        Dim scheduleId As Integer = Convert.ToInt32(dgvAvailable.CurrentRow.Cells("schedule_id").Value)

        Try
            openCon()
            Using cmd As New MySqlCommand(
                "INSERT IGNORE INTO section_schedules (section_id, schedule_id)
                 VALUES (@sid, @schid)", conn)
                cmd.Parameters.AddWithValue("@sid",   currentSectionId)
                cmd.Parameters.AddWithValue("@schid", scheduleId)
                cmd.ExecuteNonQuery()
            End Using
            LoadAvailableSchedules()
            LoadAssignedSchedules()
        Catch ex As Exception
            MsgBox("Error assigning schedule: " & ex.Message)
        Finally
            closeCon()
        End Try
    End Sub

    ' ================================================================
    ' REMOVE — move selected from Assigned → Available
    ' ================================================================
    Private Sub btnRemove_Click(sender As Object, e As EventArgs) Handles btnRemove.Click
        If currentSectionId = 0 Then
            MsgBox("Please load a section first.", MsgBoxStyle.Exclamation) : Return
        End If
        If dgvAssigned.CurrentRow Is Nothing Then
            MsgBox("Please select a schedule to remove.", MsgBoxStyle.Exclamation) : Return
        End If

        Dim scheduleId As Integer = Convert.ToInt32(dgvAssigned.CurrentRow.Cells("schedule_id").Value)

        If MsgBox("Remove this schedule from the section?", MsgBoxStyle.YesNo) = MsgBoxResult.No Then Return

        Try
            openCon()
            Using cmd As New MySqlCommand(
                "DELETE FROM section_schedules WHERE section_id=@sid AND schedule_id=@schid", conn)
                cmd.Parameters.AddWithValue("@sid",   currentSectionId)
                cmd.Parameters.AddWithValue("@schid", scheduleId)
                cmd.ExecuteNonQuery()
            End Using
            LoadAvailableSchedules()
            LoadAssignedSchedules()
        Catch ex As Exception
            MsgBox("Error removing schedule: " & ex.Message)
        Finally
            closeCon()
        End Try
    End Sub

    Private Sub pnlTop2_Paint(sender As Object, e As PaintEventArgs) Handles pnlTop2.Paint

    End Sub
End Class
