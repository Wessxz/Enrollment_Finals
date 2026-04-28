Imports MySql.Data.MySqlClient

Public Class ClassListForm

    Private Sub ClassListForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Designer controls: txtSearch, dgvClasses, dgvStudents,
        '                    lblSubject, lblCourse, lblSchedule, lblRoom
        LoadClasses()
    End Sub

    ' ================= LOAD ALL SCHEDULES INTO LEFT GRID =================
    Private Sub LoadClasses(Optional filter As String = "")
        Try
            openCon()
            Dim query As String =
                "SELECT sc.schedule_id,
                        sub.subject_code,
                        sub.subject_name,
                        u.username AS instructor,
                        sc.day_of_week,
                        sc.start_time,
                        sc.end_time,
                        sc.room
                 FROM schedules sc
                 INNER JOIN subjects sub ON sc.subject_id = sub.subject_id
                 LEFT JOIN users u ON sc.faculty_id = u.id"

            If Not String.IsNullOrWhiteSpace(filter) Then
                query &= " WHERE sub.subject_code LIKE @f OR sub.subject_name LIKE @f"
            End If

            query &= " ORDER BY sub.subject_code"

            Using cmd As New MySqlCommand(query, conn)
                If Not String.IsNullOrWhiteSpace(filter) Then
                    cmd.Parameters.AddWithValue("@f", "%" & filter & "%")
                End If
                Dim dt As New DataTable
                Dim da As New MySqlDataAdapter(cmd)
                da.Fill(dt)
                dgvClasses.DataSource = dt
            End Using
        Catch ex As Exception
            MsgBox("Error loading classes: " & ex.Message)
        Finally
            closeCon()
        End Try
    End Sub

    ' ================= CLICK CLASS ROW → LOAD STUDENTS =================
    Private Sub dgvClasses_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvClasses.CellClick
        If e.RowIndex < 0 Then Return

        Dim row As DataGridViewRow = dgvClasses.Rows(e.RowIndex)
        Dim scheduleId As Integer = Convert.ToInt32(row.Cells("schedule_id").Value)

        ' Update info labels
        lblSubject.Text = "Subject: " & row.Cells("subject_code").Value.ToString() & " - " & row.Cells("subject_name").Value.ToString()
        lblCourse.Text = "Instructor: " & row.Cells("instructor").Value.ToString()
        lblSchedule.Text = "Schedule: " & row.Cells("day_of_week").Value.ToString() & " " &
                           row.Cells("start_time").Value.ToString() & " - " & row.Cells("end_time").Value.ToString()
        lblRoom.Text = "Room: " & row.Cells("room").Value.ToString()

        LoadStudentsForSchedule(scheduleId)
    End Sub

    ' ================= LOAD STUDENTS FOR SELECTED SCHEDULE =================
    Private Sub LoadStudentsForSchedule(scheduleId As Integer)
        Try
            openCon()
            Dim query As String =
                "SELECT s.student_id,
                        CONCAT(s.first_name, ' ', s.last_name) AS student_name,
                        s.course,
                        s.year_level
                 FROM enrollment_details ed
                 INNER JOIN enrollments e ON ed.enrollment_id = e.enrollment_id
                 INNER JOIN students s ON e.student_id = s.student_id
                 WHERE ed.schedule_id = @sid
                 ORDER BY s.last_name"

            Using cmd As New MySqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@sid", scheduleId)
                Dim dt As New DataTable
                Dim da As New MySqlDataAdapter(cmd)
                da.Fill(dt)
                dgvStudents.DataSource = dt
            End Using
        Catch ex As Exception
            MsgBox("Error loading students: " & ex.Message)
        Finally
            closeCon()
        End Try
    End Sub

    ' ================= SEARCH =================
    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        LoadClasses(txtSearch.Text)
    End Sub

End Class
