Imports MySql.Data.MySqlClient

Public Class SectionForm

    Private selectedSectionId As Integer = 0

    Private Sub SectionForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadSections()
    End Sub

    ' =========================================================
    ' DATA ERROR HANDLER (PREVENT GRID CRASH)
    ' =========================================================
    Private Sub dgvSections_DataError(sender As Object, e As DataGridViewDataErrorEventArgs) Handles dgvSections.DataError
        e.ThrowException = False
        e.Cancel = True
    End Sub

    ' =========================================================
    ' LOAD SECTIONS (WITH ENROLLED COUNT ONLY)
    ' =========================================================
    Private Sub LoadSections()
        Try
            openCon()

            Dim query As String =
                "SELECT 
                    s.section_id,
                    s.section_name,
                    s.course,
                    s.year_level,
                    s.semester,
                    s.academic_year,
                    COUNT(st.id) AS enrolled
                 FROM sections s
                 LEFT JOIN students st ON st.section_id = s.section_id
                 GROUP BY 
                    s.section_id,
                    s.section_name,
                    s.course,
                    s.year_level,
                    s.semester,
                    s.academic_year
                 ORDER BY s.section_name"

            Using cmd As New MySqlCommand(query, conn)
                Dim dt As New DataTable
                Dim da As New MySqlDataAdapter(cmd)
                da.Fill(dt)

                dgvSections.DataSource = dt
                dgvSections.AutoGenerateColumns = True

                ' Hide ID
                If dgvSections.Columns.Contains("section_id") Then
                    dgvSections.Columns("section_id").Visible = False
                End If

                ' Header rename
                If dgvSections.Columns.Contains("enrolled") Then
                    dgvSections.Columns("enrolled").HeaderText = "Enrolled Students"
                End If

                lblCount.Text = "Total Sections: " & dt.Rows.Count

            End Using

        Catch ex As Exception
            MsgBox("Error loading sections: " & ex.Message)
        Finally
            closeCon()
        End Try
    End Sub

    ' =========================================================
    ' CELL CLICK
    ' =========================================================
    Private Sub dgvSections_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvSections.CellClick
        If e.RowIndex < 0 Then Return

        Dim row = dgvSections.Rows(e.RowIndex)

        selectedSectionId = Convert.ToInt32(row.Cells("section_id").Value)

        txtSectionName.Text = row.Cells("section_name").Value.ToString()
        txtCourse.Text = row.Cells("course").Value.ToString()
        cmbYearLevel.Text = row.Cells("year_level").Value.ToString()
        cmbSemester.Text = row.Cells("semester").Value.ToString()
        txtAcadYear.Text = row.Cells("academic_year").Value.ToString()
    End Sub

    ' =========================================================
    ' VALIDATION
    ' =========================================================
    Private Function ValidateInputs() As Boolean
        If txtSectionName.Text = "" Then Return False
        If txtCourse.Text = "" Then Return False
        If cmbYearLevel.Text = "" Then Return False
        If cmbSemester.Text = "" Then Return False
        If txtAcadYear.Text = "" Then Return False
        Return True
    End Function

    ' =========================================================
    ' ADD
    ' =========================================================
    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        If Not ValidateInputs() Then
            MsgBox("Fill all fields") : Return
        End If

        Try
            openCon()

            Using cmd As New MySqlCommand(
                "INSERT INTO sections 
                (section_name, course, year_level, semester, academic_year)
                VALUES (@name,@course,@yr,@sem,@ay)", conn)

                cmd.Parameters.AddWithValue("@name", txtSectionName.Text.Trim())
                cmd.Parameters.AddWithValue("@course", txtCourse.Text.Trim())
                cmd.Parameters.AddWithValue("@yr", cmbYearLevel.Text)
                cmd.Parameters.AddWithValue("@sem", cmbSemester.Text)
                cmd.Parameters.AddWithValue("@ay", txtAcadYear.Text)

                cmd.ExecuteNonQuery()
            End Using

            LoadSections()
            ClearFields()

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            closeCon()
        End Try
    End Sub

    ' =========================================================
    ' UPDATE
    ' =========================================================
    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click

        If selectedSectionId = 0 Then Return

        Try
            openCon()

            Using cmd As New MySqlCommand(
                "UPDATE sections SET 
                    section_name=@name,
                    course=@course,
                    year_level=@yr,
                    semester=@sem,
                    academic_year=@ay
                 WHERE section_id=@id", conn)

                cmd.Parameters.AddWithValue("@name", txtSectionName.Text)
                cmd.Parameters.AddWithValue("@course", txtCourse.Text)
                cmd.Parameters.AddWithValue("@yr", cmbYearLevel.Text)
                cmd.Parameters.AddWithValue("@sem", cmbSemester.Text)
                cmd.Parameters.AddWithValue("@ay", txtAcadYear.Text)
                cmd.Parameters.AddWithValue("@id", selectedSectionId)

                cmd.ExecuteNonQuery()
            End Using

            LoadSections()
            ClearFields()

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            closeCon()
        End Try
    End Sub

    ' =========================================================
    ' DELETE
    ' =========================================================
    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click

        If selectedSectionId = 0 Then Return

        Try
            openCon()

            Using cmd As New MySqlCommand(
                "DELETE FROM sections WHERE section_id=@id", conn)

                cmd.Parameters.AddWithValue("@id", selectedSectionId)
                cmd.ExecuteNonQuery()
            End Using

            LoadSections()
            ClearFields()

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            closeCon()
        End Try
    End Sub

    ' =========================================================
    ' CLEAR
    ' =========================================================
    Private Sub ClearFields()
        selectedSectionId = 0
        txtSectionName.Clear()
        txtCourse.Clear()
        cmbYearLevel.SelectedIndex = -1
        cmbSemester.SelectedIndex = -1
        txtAcadYear.Text = ""
        dgvSections.ClearSelection()
    End Sub

End Class