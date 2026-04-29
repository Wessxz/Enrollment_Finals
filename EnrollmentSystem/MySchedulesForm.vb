Imports MySql.Data.MySqlClient

Public Class MySchedulesForm

    Private Sub MySchedulesForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadSchedules()
    End Sub

    ' =========================================================
    ' LOAD SCHEDULES
    ' =========================================================
    Private Sub LoadSchedules()
        Try
            openCon()

            Dim query As String =
                "SELECT sc.schedule_id,
                        sub.subject_code AS 'Subject Code',
                        sub.subject_name AS 'Subject Name',
                        sub.units AS 'Units',
                        IFNULL(sec.section_name, 'N/A') AS 'Section',
                        sc.day_of_week AS 'Day',
                        TIME_FORMAT(sc.start_time, '%h:%i %p') AS 'Start Time',
                        TIME_FORMAT(sc.end_time, '%h:%i %p') AS 'End Time',
                        sc.room AS 'Room',
                        sc.semester AS 'Semester',
                        sc.academic_year AS 'Academic Year',
                        sc.max_slots AS 'Max Slots',
                        COUNT(ed.detail_id) AS 'Enrolled'
                 FROM schedules sc
                 INNER JOIN subjects sub ON sc.subject_id = sub.subject_id
                 LEFT JOIN section_schedules ss ON sc.schedule_id = ss.schedule_id
                 LEFT JOIN sections sec ON ss.section_id = sec.section_id
                 LEFT JOIN enrollment_details ed ON sc.schedule_id = ed.schedule_id
                 WHERE sc.faculty_id = @fid
                 GROUP BY sc.schedule_id, sub.subject_code, sub.subject_name, sub.units,
                          sec.section_name, sc.day_of_week, sc.start_time, sc.end_time,
                          sc.room, sc.semester, sc.academic_year, sc.max_slots
                 ORDER BY sc.day_of_week, sc.start_time"

            Using cmd As New MySqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@fid", UserSession.CurrentCashierID)

                Dim dt As New DataTable
                Dim da As New MySqlDataAdapter(cmd)
                da.Fill(dt)

                dgvSchedules.DataSource = dt

                If dgvSchedules.Columns.Contains("schedule_id") Then
                    dgvSchedules.Columns("schedule_id").Visible = False
                End If

                lblTotalSchedules.Text = "Total Schedules: " & dt.Rows.Count

            End Using

        Catch ex As Exception
            MsgBox("Error loading schedules: " & ex.Message)
        Finally
            closeCon()
        End Try
    End Sub

    ' =========================================================
    ' VIEW CLASS LIST
    ' =========================================================
    Private Sub btnViewClassList_Click(sender As Object, e As EventArgs) Handles btnViewClassList.Click
        ViewSelectedClassList()
    End Sub

    ' =========================================================
    ' DOUBLE CLICK ROW TO VIEW CLASS LIST
    ' =========================================================
    Private Sub dgvSchedules_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvSchedules.CellDoubleClick
        If e.RowIndex >= 0 Then
            ViewSelectedClassList()
        End If
    End Sub

    ' =========================================================
    ' HELPER: VIEW CLASS LIST FOR SELECTED SCHEDULE
    ' =========================================================
    Private Sub ViewSelectedClassList()
        ' Check if there are any schedules
        If dgvSchedules.Rows.Count = 0 Then
            MsgBox("No schedules available.", MsgBoxStyle.Exclamation)
            Return
        End If

        ' Check if a row is selected
        If dgvSchedules.SelectedRows.Count = 0 Then
            MsgBox("Please click on a schedule row first to select it.", MsgBoxStyle.Exclamation)
            Return
        End If

        Try
            Dim scheduleId As Integer = Convert.ToInt32(dgvSchedules.SelectedRows(0).Cells("schedule_id").Value)
            
            ' Open ClassListForm with selected schedule_id
            Dim f As New ClassListForm()
            f.ScheduleId = scheduleId
            f.Show()
        Catch ex As Exception
            MsgBox("Error opening class list: " & ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    ' =========================================================
    ' CLOSE
    ' =========================================================
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

End Class
