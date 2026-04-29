Imports MySql.Data.MySqlClient

Public Class StudentMasterlistForm

    Private facultyId As Integer = 0

    Private Sub StudentMasterlistForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        facultyId = UserSession.CurrentCashierID
        LoadSubjectFilter()
        LoadGradesMasterlist()
    End Sub

    ' =========================================================
    ' LOAD SUBJECT FILTER DROPDOWN
    ' =========================================================
    Private Sub LoadSubjectFilter()
        Try
            openCon()

            Dim query As String =
                "SELECT DISTINCT sub.subject_id,
                        CONCAT(sub.subject_code, ' - ', sub.subject_name) AS subject_display
                 FROM schedules sc
                 INNER JOIN subjects sub ON sc.subject_id = sub.subject_id
                 WHERE sc.faculty_id = @fid
                 ORDER BY sub.subject_code"

            Using cmd As New MySqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@fid", facultyId)

                cmbSubjectFilter.Items.Clear()
                cmbSubjectFilter.Items.Add("--- ALL SUBJECTS ---")

                Using reader As MySqlDataReader = cmd.ExecuteReader()
                    While reader.Read()
                        cmbSubjectFilter.Items.Add(New With {
                            .Value = reader("subject_id"),
                            .Display = reader("subject_display").ToString()
                        })
                    End While
                End Using

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
    Private Sub LoadGradesMasterlist(Optional subjectId As Integer = 0)
        Try
            openCon()

            ' Query matches screenshot: Student ID, Full Name, Code, Subject, Grade, Remarks
            ' Shows one row per grade entry (per term)
            Dim query As String =
                "SELECT
                    s.student_id        AS 'Student ID',
                    CONCAT(s.last_name, ', ', s.first_name) AS 'Full Name',
                    sub.subject_code    AS 'Code',
                    sub.subject_name    AS 'Subject',
                    g.term              AS 'Term',
                    g.grade_value       AS 'Grade',
                    g.remarks           AS 'Remarks'
                 FROM schedules sc
                 INNER JOIN subjects sub ON sc.subject_id = sub.subject_id
                 INNER JOIN enrollment_details ed ON ed.schedule_id = sc.schedule_id
                 INNER JOIN enrollments e ON ed.enrollment_id = e.enrollment_id
                 INNER JOIN students s ON e.student_id = s.student_id
                 LEFT JOIN grades g ON g.enrollment_id = e.enrollment_id
                     AND g.subject_id = sub.subject_id
                 WHERE sc.faculty_id = @fid"

            If subjectId > 0 Then
                query &= " AND sub.subject_id = @subjectId"
            End If

            query &= " ORDER BY sub.subject_code, s.last_name, s.first_name, g.term"

            Using cmd As New MySqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@fid", facultyId)
                If subjectId > 0 Then
                    cmd.Parameters.AddWithValue("@subjectId", subjectId)
                End If

                Dim dt As New DataTable
                Dim da As New MySqlDataAdapter(cmd)
                da.Fill(dt)

                dgvGrades.DataSource = dt

                ' Style the grid
                StyleGrid()

                ' Update stats
                lblTotalRecords.Text = "Total Records: " & dt.Rows.Count

                Dim pendingCount As Integer = 0
                For Each row As DataRow In dt.Rows
                    If IsDBNull(row("Grade")) OrElse row("Grade").ToString() = "" Then
                        pendingCount += 1
                    End If
                Next
                lblPendingGrades.Text = "Pending Grades: " & pendingCount

            End Using

        Catch ex As Exception
            MsgBox("Error loading masterlist: " & ex.Message)
        Finally
            closeCon()
        End Try
    End Sub

    ' =========================================================
    ' STYLE GRID - Color rows based on remarks
    ' =========================================================
    Private Sub StyleGrid()
        dgvGrades.DefaultCellStyle.BackColor = System.Drawing.Color.White
        dgvGrades.DefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(50, 50, 50)
        dgvGrades.AlternatingRowsDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(250, 250, 250)

        ' Color selected row like screenshot (blue)
        dgvGrades.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(52, 152, 219)
        dgvGrades.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White
    End Sub

    ' =========================================================
    ' COLOR ROWS AFTER DATA LOADS
    ' =========================================================
    Private Sub dgvGrades_DataBindingComplete(sender As Object, e As DataGridViewBindingCompleteEventArgs) Handles dgvGrades.DataBindingComplete
        For Each row As DataGridViewRow In dgvGrades.Rows
            If row.Cells("Remarks").Value IsNot Nothing Then
                Select Case row.Cells("Remarks").Value.ToString().ToUpper()
                    Case "FAILED"
                        row.DefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(192, 57, 43)
                    Case "PASSED"
                        row.DefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(39, 174, 96)
                    Case "INC", "INCOMPLETE"
                        row.DefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(211, 84, 0)
                    Case "DRP", "DROPPED"
                        row.DefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(127, 140, 141)
                End Select
            End If
        Next
    End Sub

    ' =========================================================
    ' SUBJECT FILTER CHANGED
    ' =========================================================
    Private Sub cmbSubjectFilter_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbSubjectFilter.SelectedIndexChanged
        Dim subjectId As Integer = 0
        If cmbSubjectFilter.SelectedIndex > 0 Then
            subjectId = CType(cmbSubjectFilter.SelectedItem, Object).Value
        End If
        LoadGradesMasterlist(subjectId)
    End Sub

    ' =========================================================
    ' REFRESH BUTTON
    ' =========================================================
    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        LoadSubjectFilter()
        Dim subjectId As Integer = 0
        If cmbSubjectFilter.SelectedIndex > 0 Then
            subjectId = CType(cmbSubjectFilter.SelectedItem, Object).Value
        End If
        LoadGradesMasterlist(subjectId)
    End Sub

    ' =========================================================
    ' EXPORT TO CSV
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
                For Each col As DataGridViewColumn In dgvGrades.Columns
                    headers.Add(col.HeaderText)
                Next
                csv.AppendLine(String.Join(",", headers))

                ' Rows
                For Each row As DataGridViewRow In dgvGrades.Rows
                    Dim cells As New List(Of String)
                    For Each cell As DataGridViewCell In row.Cells
                        Dim val As String = If(cell.Value IsNot Nothing, cell.Value.ToString(), "")
                        cells.Add("""" & val.Replace("""", """""") & """")
                    Next
                    csv.AppendLine(String.Join(",", cells))
                Next

                System.IO.File.WriteAllText(saveDialog.FileName, csv.ToString())
                MsgBox("Exported successfully!", MsgBoxStyle.Information)
            End If

        Catch ex As Exception
            MsgBox("Export error: " & ex.Message)
        End Try
    End Sub

    ' =========================================================
    ' CLOSE
    ' =========================================================
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

End Class
