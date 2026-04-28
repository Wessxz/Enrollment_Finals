Imports MySql.Data.MySqlClient

Public Class StudentForm

    Private selectedID As Integer = 0

    ' =========================================================
    ' FORM LOAD
    ' =========================================================
    Private Sub StudentForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadSectionCombo()
        LoadStudents()
    End Sub

    ' =========================================================
    ' LOAD STUDENTS (FIXED QUERY)
    ' =========================================================
    Private Sub LoadStudents()
        Try
            openCon()

            Dim query As String =
                "SELECT s.id,
                        s.student_id,
                        s.first_name,
                        s.last_name,
                        s.course,
                        s.year_level,
                        s.student_type,
                        s.section_id,
                        IFNULL(sec.section_name, 'Not Assigned') AS section_name,
                        s.status
                 FROM students s
                 LEFT JOIN sections sec ON s.section_id = sec.section_id
                 ORDER BY s.last_name"

            Using cmd As New MySqlCommand(query, conn)
                Dim dt As New DataTable
                Dim da As New MySqlDataAdapter(cmd)
                da.Fill(dt)

                dgvStudents.DataSource = dt
                dgvStudents.AutoGenerateColumns = True

                If dgvStudents.Columns.Contains("id") Then
                    dgvStudents.Columns("id").Visible = False
                End If

                If dgvStudents.Columns.Contains("section_id") Then
                    dgvStudents.Columns("section_id").Visible = False
                End If

            End Using

        Catch ex As Exception
            MessageBox.Show("Error loading students: " & ex.Message)
        Finally
            closeCon()
        End Try
    End Sub

    ' =========================================================
    ' CLEAR FIELDS
    ' =========================================================
    Private Sub ClearFields()
        selectedID = 0

        txtStudentID.Clear()
        txtFirstName.Clear()
        txtLastName.Clear()
        txtCourse.Clear()

        cmbYearLevel.SelectedIndex = -1
        cmbStudentStatus.SelectedIndex = -1
        cmbSection.SelectedIndex = -1

        dgvStudents.ClearSelection()
    End Sub

    ' =========================================================
    ' LOAD SECTION COMBO
    ' =========================================================
    Private Sub LoadSectionCombo()
        Try
            openCon()

            Using cmd As New MySqlCommand(
                "SELECT section_id,
                        CONCAT(section_name,' (',semester,' ',academic_year,')') AS display_name
                 FROM sections", conn)

                Dim dt As New DataTable
                Dim da As New MySqlDataAdapter(cmd)
                da.Fill(dt)

                cmbSection.DataSource = dt
                cmbSection.ValueMember = "section_id"
                cmbSection.DisplayMember = "display_name"
                cmbSection.SelectedIndex = -1

            End Using

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            closeCon()
        End Try
    End Sub

    ' =========================================================
    ' SECTION FULL CHECK
    ' =========================================================
    Private Function IsSectionFull(sectionId As Integer) As Boolean

        Dim count As Integer = 0
        Dim max As Integer = 40

        Try
            openCon()

            Using cmd As New MySqlCommand(
                "SELECT COUNT(*) FROM students WHERE section_id=@id", conn)
                cmd.Parameters.AddWithValue("@id", sectionId)
                count = Convert.ToInt32(cmd.ExecuteScalar())
            End Using

            Using cmd As New MySqlCommand(
                "SELECT max_slots FROM sections WHERE section_id=@id", conn)
                cmd.Parameters.AddWithValue("@id", sectionId)
                Dim result = cmd.ExecuteScalar()

                If result IsNot Nothing AndAlso Not IsDBNull(result) Then
                    max = Convert.ToInt32(result)
                End If
            End Using

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            closeCon()
        End Try

        Return count >= max
    End Function

    ' =========================================================
    ' AUTO FILL (FIXED)
    ' =========================================================
    Private Sub dgvStudents_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvStudents.CellClick

        If e.RowIndex < 0 Then Return

        Dim row As DataGridViewRow = dgvStudents.Rows(e.RowIndex)

        selectedID = Convert.ToInt32(row.Cells("id").Value)

        txtStudentID.Text = row.Cells("student_id").Value.ToString()
        txtFirstName.Text = row.Cells("first_name").Value.ToString()
        txtLastName.Text = row.Cells("last_name").Value.ToString()
        txtCourse.Text = row.Cells("course").Value.ToString()
        cmbYearLevel.Text = row.Cells("year_level").Value.ToString()
        cmbStudentStatus.Text = row.Cells("student_type").Value.ToString()

        ' FIX SECTION SELECT
        If Not IsDBNull(row.Cells("section_id").Value) Then
            cmbSection.SelectedValue = row.Cells("section_id").Value
        Else
            cmbSection.SelectedIndex = -1
        End If

    End Sub

    ' =========================================================
    ' UPDATE STUDENT
    ' =========================================================
    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click

        If selectedID = 0 Then
            MessageBox.Show("Select student first")
            Return
        End If

        Dim sectionId As Object = DBNull.Value

        If cmbSection.SelectedIndex <> -1 Then
            sectionId = Convert.ToInt32(cmbSection.SelectedValue)

            If IsSectionFull(sectionId) Then
                MessageBox.Show("Section is FULL!", "Limit",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If
        End If

        Try
            openCon()

            Using cmd As New MySqlCommand(
                "UPDATE students 
                 SET student_id=@sid,
                     first_name=@fn,
                     last_name=@ln,
                     course=@course,
                     year_level=@yr,
                     student_type=@type,
                     section_id=@section
                 WHERE id=@id", conn)

                cmd.Parameters.AddWithValue("@sid", txtStudentID.Text)
                cmd.Parameters.AddWithValue("@fn", txtFirstName.Text)
                cmd.Parameters.AddWithValue("@ln", txtLastName.Text)
                cmd.Parameters.AddWithValue("@course", txtCourse.Text)
                cmd.Parameters.AddWithValue("@yr", cmbYearLevel.Text)
                cmd.Parameters.AddWithValue("@type", cmbStudentStatus.Text)
                cmd.Parameters.AddWithValue("@section", sectionId)
                cmd.Parameters.AddWithValue("@id", selectedID)

                cmd.ExecuteNonQuery()
            End Using

            MessageBox.Show("Updated Successfully!")

            LoadStudents()
            ClearFields()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            closeCon()
        End Try

    End Sub

End Class