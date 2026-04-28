Imports MySql.Data.MySqlClient

Public Class BillingForm
    ' This runs when the form opens
    Private Sub BillingForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadValidatedStudents()
        LoadBillingData()
    End Sub

    ' 1. Load students into the ComboBox
    Private Sub LoadValidatedStudents()
        Try
            openCon()
            Dim query As String = "SELECT student_id, CONCAT(first_name, ' ', last_name) AS full_name FROM students"
            Dim da As New MySqlDataAdapter(query, conn)
            Dim dt As New DataTable
            da.Fill(dt)

            If dt.Rows.Count > 0 Then
                cmbStudentID.DataSource = dt
                cmbStudentID.DisplayMember = "student_id"
                cmbStudentID.ValueMember = "full_name"
                cmbStudentID.SelectedIndex = -1
            Else
                MsgBox("No students found in the database!")
            End If
        Catch ex As Exception
            MsgBox("Database Error: " & ex.Message)
        Finally
            closeCon()
        End Try
    End Sub

    ' 2. Handle selection changes to auto-fill name and calculate base tuition
    Private Sub cmbStudentID_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbStudentID.SelectedIndexChanged
        If cmbStudentID.SelectedIndex = -1 OrElse cmbStudentID.SelectedValue Is Nothing Then Return

        Try
            openCon()
            ' Fill name from the ComboBox ValueMember
            txtStudentName.Text = cmbStudentID.SelectedValue.ToString()

            ' Count subjects based on the student's section_id
            Dim sql As String = "SELECT COUNT(*) FROM section_schedules ss " &
                               "INNER JOIN students s ON ss.section_id = s.section_id " &
                               "WHERE s.student_id = @sid"

            Using cmd As New MySqlCommand(sql, conn)
                cmd.Parameters.AddWithValue("@sid", cmbStudentID.Text)
                Dim subjectCount As Integer = Convert.ToInt32(cmd.ExecuteScalar())

                ' Calculate: ₱1,800 per subject
                Dim calculatedTuition As Decimal = subjectCount * 1800
                txtTuition.Text = calculatedTuition.ToString("N2")

                UpdateFinancialBreakdown()
            End Using
        Catch ex As Exception
            MsgBox("Tuition Calculation Error: " & ex.Message)
        Finally
            closeCon()
        End Try
    End Sub

    ' 3. The Math Helper: Strips commas and calculates totals for display
    Private Sub UpdateFinancialBreakdown()
        ' Use a helper function to safely parse text with commas
        Dim tuition As Decimal = ParseDecimal(txtTuition.Text)
        Dim misc As Decimal = ParseDecimal(txtMisc.Text)
        Dim lab As Decimal = ParseDecimal(txtLab.Text)
        Dim other As Decimal = ParseDecimal(txtOther.Text)

        Dim total As Decimal = tuition + misc + lab + other
        txtTotal.Text = total.ToString("N2")

        If cmbPaymentType.Text = "Full Payment" Then
            lblBreakdown.Text = "Mode: Full Payment" & vbCrLf & "Total Due: ₱" & total.ToString("N2")
        ElseIf cmbPaymentType.Text = "Partial Payment" Then
            Dim downpayment As Decimal = 2500
            Dim remaining As Decimal = total - downpayment

            If remaining > 0 Then
                Dim perTerm As Decimal = remaining / 4
                lblBreakdown.Text = String.Format("Mode: Partial Payment" & vbCrLf &
                                             "Downpayment: ₱{0:N2}" & vbCrLf &
                                             "Installments (4x): ₱{1:N2} each",
                                             downpayment, perTerm)
            Else
                lblBreakdown.Text = "Total covered by downpayment."
            End If
        Else
            lblBreakdown.Text = "Please select a Payment Type."
        End If
    End Sub

    ' Helper to handle the "Replace Comma" logic centrally
    Private Function ParseDecimal(text As String) As Decimal
        If String.IsNullOrWhiteSpace(text) Then Return 0
        Dim cleanText As String = text.Replace(",", "").Trim()
        Dim result As Decimal
        Decimal.TryParse(cleanText, result)
        Return result
    End Function

    ' 4. Save Button: Cleans data and inserts into DB
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If cmbStudentID.SelectedIndex = -1 Or cmbPaymentType.SelectedIndex = -1 Then
            MsgBox("Please select a Student and Payment Mode first.", MsgBoxStyle.Exclamation)
            Return
        End If

        Try
            openCon()
            ' SQL targeting your billing table columns
            Dim sql As String = "INSERT INTO billing (student_id, tuition_fee, misc_fee, total_amount, balance, payment_mode, status) " &
                                 "VALUES (@sid, @tuition, @misc, @total, @bal, @mode, @status)"

            Using cmd As New MySqlCommand(sql, conn)
                ' Get cleaned numeric values
                Dim tuitionVal As Decimal = ParseDecimal(txtTuition.Text)
                ' Sum extra fees for the misc_fee column
                Dim miscTotalVal As Decimal = ParseDecimal(txtMisc.Text) + ParseDecimal(txtLab.Text) + ParseDecimal(txtOther.Text)
                Dim totalVal As Decimal = ParseDecimal(txtTotal.Text)

                ' Map parameters (Each added ONLY ONCE to avoid crashes)
                cmd.Parameters.AddWithValue("@sid", cmbStudentID.Text) ' e.g. 2205
                cmd.Parameters.AddWithValue("@tuition", tuitionVal)
                cmd.Parameters.AddWithValue("@misc", miscTotalVal)
                cmd.Parameters.AddWithValue("@total", totalVal)
                cmd.Parameters.AddWithValue("@bal", totalVal) ' Initially, balance equals total
                cmd.Parameters.AddWithValue("@mode", cmbPaymentType.Text)
                cmd.Parameters.AddWithValue("@status", "UNPAID")

                cmd.ExecuteNonQuery()
                MsgBox("Billing saved successfully for Student " & cmbStudentID.Text, MsgBoxStyle.Information)
                LoadBillingData()
            End Using
        Catch ex As Exception
            MsgBox("Save Error: " & ex.Message)
        Finally
            closeCon()
        End Try
    End Sub

    Private Sub btnCompute_Click(sender As Object, e As EventArgs) Handles btnCompute.Click
        UpdateFinancialBreakdown()
    End Sub

    Private Sub cmbPaymentType_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbPaymentType.SelectedIndexChanged
        UpdateFinancialBreakdown()
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtStudentName.Clear()
        txtTuition.Text = "0.00"
        txtMisc.Clear()
        txtLab.Clear()
        txtOther.Clear()
        txtTotal.Text = "0.00"
        cmbStudentID.SelectedIndex = -1
        cmbPaymentType.SelectedIndex = -1
        lblBreakdown.Text = "Breakdown reset."
    End Sub

    Private Sub LoadBillingData()
        Try
            openCon()
            Dim sql As String = "SELECT * FROM billing ORDER BY billing_id DESC"
            Dim da As New MySqlDataAdapter(sql, conn)
            Dim dt As New DataTable()
            da.Fill(dt)
            dgvBilling.DataSource = dt

            ' Format DataGridView for currency
            If dgvBilling.Columns.Contains("total_amount") Then
                dgvBilling.Columns("total_amount").DefaultCellStyle.Format = "N2"
            End If
        Catch ex As Exception
            MsgBox("Error loading billing data: " & ex.Message)
        Finally
            closeCon()
        End Try
    End Sub
End Class