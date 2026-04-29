Imports MySql.Data.MySqlClient

Public Class StudentMasterlistForm

    Private facultyId As Integer = 0

    Private Sub StudentMasterlistForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        facultyId = Login.LoggedInUserId
        LoadSubjectFilter()
        LoadGradesMasterlist()
    End Sub

    ' =========================================================
    ' LOAD SUBJECT FILTER
    ' =========================================================
    Private Sub LoadSubjectFilter()
        Try
            openCon()

            Dim query As String =
                "SELECT DISTINCT sc.schedule_id, 
                        CONCAT(sub.subject_code, ' - ', sub.subject_name) AS subject_display
                 FROM schedules sc
                 INNER JOIN subjects sub ON sc.subject_id = sub.subject_id
                 WHERE sc.faculty_id = @fid
                 ORDER BY sub.subject_code"

            Using cmd As New MySqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@fid", facultyId)

                cmbSubjectFilter.Items.Clear()
                cmbSubjectFilter.Items.Add("All Subjects")

                Dim reader As MySqlDataReader = cmd.ExecuteReader()
                While reader.Read()
                    cmbSubjectFilter.Items.Add(New With {
                        .Value = reader("schedule_id"),
                        .Display = reader("subject_display").ToString()
                    })
                End While
                reader.Close()

                cmbSubjectFilter.DisplayMember = "Display"
                cmbSubjectFilter.ValueMember = "Value"
                cmbSubjectFilter.SelectedIndex = 0

            End Using

        Catch ex As Exception
            MsgBox("Error loading subjects: " & ex.Message)
        Finally
            closeCon()
        End Try
    End Sub

    ' =========================================================
    ' LOAD GRADES MASTERLIST
    ' =========================================================
    Private Sub LoadGradesMasterlist(Optional searchText As String = "", Optional scheduleId As Integer = 0)
        Try
            openCon()

            Dim query As String =
                "SELECT s.student_id AS 'Student ID',
                        CONCAT(s.first_name, ' ', s.last_name) AS 'Student Name',
                        s.course AS 'Course',
                        s.year_level AS 'Year',
                        sub.subject_code AS 'Subject Code',
                        sub.subject_name AS 'Subject Name',
                        IFNULL(g.prelim_grade, '-') AS 'Prelim',
                        IFNULL(g.midterm_grade, '-') AS 'Midterm',
                        IFNULL(g.final_grade, '-') AS 'Final',
                        CASE 
                            WHEN g.final_grade IS NULL THEN 'No Grade'
                            WHEN g.final_grade >= 75 THEN 'PASSED'
                            ELSE 'FAILED'
                        END AS 'Status',
                        sc.semester AS 'Semester',
                        sc.academic_year AS 'Academic Year'
                 FROM enrollment_details ed
                 INNER JOIN enrollments e ON ed.enrollment_id = e.enrollment_id
                 INNER JOIN students s ON e.student_id = s.student_id
                 INNER JOIN schedules sc ON ed.schedule_id = sc.schedule_id
                 INNER JOIN subjects sub ON sc.subject_id = sub.subject_id
                 LEFT JOIN grades g ON ed.detail_id = g.enrollment_detail_id
                 WHERE sc.faculty_id = @fid"

            If scheduleId > 0 Then
                query &= " AND sc.schedule_id = @scheduleId"
            End If

            If Not String.IsNullOrWhiteSpace(searchText) Then
                query &= " AND (s.student_id LIKE @search 
                           OR s.first_name LIKE @search 
                           OR s.last_name LIKE @search 
                           OR sub.subject_code LIKE @search)"
            End If

            query &= " ORDER BY sub.subject_code, s.last_name, s.first_name"

            Using cmd As New MySqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@fid", facultyId)
                
                If scheduleId > 0 Then
                    cmd.Parameters.AddWithValue("@scheduleId", scheduleId)
                End If

                If Not String.IsNullOrWhiteSpace(searchText) Then
                    cmd.Parameters.AddWithValue("@search", "%" & searchText & "%")
                End If

                Dim dt As New DataTable
                Dim da As New MySqlDataAdapter(cmd)
                da.Fill(dt)

                dgvGrades.DataSource = dt
                lblTotalRecords.Text = "Total Records: " & dt.Rows.Count

                ' Count students without grades
                Dim noGradeCount As Integer = 0
                For Each row As DataRow In dt.Rows
                    If row("Status").ToString() = "No Grade" Then
                        noGradeCount += 1
                    End If
                Next
                lblPendingGrades.Text = "Pending Grades: " & noGradeCount

            End Using

        Catch ex As Exception
            MsgBox("Error loading grades masterlist: " & ex.Message)
        Finally
            closeCon()
        End Try
    End Sub

    ' =========================================================
    ' SEARCH
    ' =========================================================
    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        Dim scheduleId As Integer = 0
        If cmbSubjectFilter.SelectedIndex > 0 Then
            scheduleId = CType(cmbSubjectFilter.SelectedItem, Object).Value
        End If
        LoadGradesMasterlist(txtSearch.Text, scheduleId)
    End Sub

    ' =========================================================
    ' SUBJECT FILTER
    ' =========================================================
    Private Sub cmbSubjectFilter_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbSubjectFilter.SelectedIndexChanged
        Dim scheduleId As Integer = 0
        If cmbSubjectFilter.SelectedIndex > 0 Then
            scheduleId = CType(cmbSubjectFilter.SelectedItem, Object).Value
        End If
        LoadGradesMasterlist(txtSearch.Text, scheduleId)
    End Sub

    ' =========================================================
    ' EXPORT TO CSV (Optional feature)
    ' =========================================================
    Private Sub btnExport_Click(sender As Object, e As EventArgs) Handles btnExport.Click
        If dgvGrades.Rows.Count = 0 Then
            MsgBox("No data to export.", MsgBoxStyle.Exclamation)
            Return
        End If

        Try
            Dim saveDialog As New SaveFileDialog()
            saveDialog.Filter = "CSV Files (*.csv)|*.csv"
            saveDialog.FileName = "GradesMasterlist_" & DateTime.Now.ToString("yyyyMMdd_HHmmss") & ".csv"

            If saveDialog.ShowDialog() = DialogResult.OK Then
                Dim csv As New System.Text.StringBuilder()

                ' Headers
                Dim headers As New List(Of String)
                For Each column As DataGridViewColumn In dgvGrades.Columns
                    headers.Add(column.HeaderText)
                Next
                csv.AppendLine(String.Join(",", headers))

                ' Rows
                For Each row As DataGridViewRow In dgvGrades.Rows
                    Dim cells As New List(Of String)
                    For Each cell As DataGridViewCell In row.Cells
                        cells.Add("""" & cell.Value.ToString().Replace("""", """""") & """")
                    Next
                    csv.AppendLine(String.Join(",", cells))
                Next

                System.IO.File.WriteAllText(saveDialog.FileName, csv.ToString())
                MsgBox("Grades masterlist exported successfully!", MsgBoxStyle.Information)
            End If

        Catch ex As Exception
            MsgBox("Error exporting data: " & ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    ' =========================================================
    ' CLOSE
    ' =========================================================
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

End Class
