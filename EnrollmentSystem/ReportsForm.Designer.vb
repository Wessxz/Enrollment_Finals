<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ReportsForm
    Inherits System.Windows.Forms.Form

    Private components As System.ComponentModel.IContainer

    Private Sub InitializeComponent()

        Me.lblTitle = New Label()

        ' ================= FILTER PANEL =================
        Me.pnlFilter = New Panel()

        Me.lblFrom = New Label()
        Me.dtpFrom = New DateTimePicker()

        Me.lblTo = New Label()
        Me.dtpTo = New DateTimePicker()

        Me.lblType = New Label()
        Me.cmbType = New ComboBox()

        Me.btnGenerate = New Button()
        Me.btnPrint = New Button()
        Me.btnExport = New Button()

        ' ================= SUMMARY =================
        Me.lblTotalCollection = New Label()
        Me.txtTotalCollection = New TextBox()

        Me.lblTotalStudents = New Label()
        Me.txtTotalStudents = New TextBox()

        ' ================= TABLE =================
        Me.lblReportList = New Label()
        Me.dgvReports = New DataGridView()

        CType(Me.dgvReports, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()

        ' ================= FORM =================
        Me.ClientSize = New Size(1100, 650)
        Me.Text = "Financial Reports"
        Me.StartPosition = FormStartPosition.CenterScreen
        Me.BackColor = Color.White

        ' ================= TITLE =================
        Me.lblTitle.Text = "FINANCIAL REPORTS"
        Me.lblTitle.Font = New Font("Segoe UI", 18, FontStyle.Bold)
        Me.lblTitle.Location = New Point(350, 20)
        Me.lblTitle.AutoSize = True

        ' ================= FILTER PANEL =================
        Me.pnlFilter.Location = New Point(20, 80)
        Me.pnlFilter.Size = New Size(1050, 100)
        Me.pnlFilter.BackColor = Color.WhiteSmoke

        Me.lblFrom.Text = "From"
        Me.lblFrom.Location = New Point(20, 20)

        Me.dtpFrom.Location = New Point(20, 50)

        Me.lblTo.Text = "To"
        Me.lblTo.Location = New Point(250, 20)

        Me.dtpTo.Location = New Point(250, 50)

        Me.lblType.Text = "Report Type"
        Me.lblType.Location = New Point(480, 20)

        Me.cmbType.Location = New Point(480, 50)
        Me.cmbType.Size = New Size(180, 25)
        Me.cmbType.Items.AddRange(New Object() {
            "All Payments",
            "Fully Paid",
            "Partial Payments"
        })

        Me.btnGenerate.Text = "Generate"
        Me.btnGenerate.Location = New Point(700, 50)
        Me.btnGenerate.BackColor = Color.Green
        Me.btnGenerate.ForeColor = Color.White

        Me.btnPrint.Text = "Print"
        Me.btnPrint.Location = New Point(800, 50)

        Me.btnExport.Text = "Export"
        Me.btnExport.Location = New Point(880, 50)

        ' ================= SUMMARY =================
        Me.lblTotalCollection.Text = "Total Collection"
        Me.lblTotalCollection.Location = New Point(20, 200)

        Me.txtTotalCollection.Location = New Point(20, 230)
        Me.txtTotalCollection.Size = New Size(200, 25)
        Me.txtTotalCollection.ReadOnly = True

        Me.lblTotalStudents.Text = "Total Students Paid"
        Me.lblTotalStudents.Location = New Point(250, 200)

        Me.txtTotalStudents.Location = New Point(250, 230)
        Me.txtTotalStudents.Size = New Size(200, 25)
        Me.txtTotalStudents.ReadOnly = True

        ' ================= TABLE =================
        Me.lblReportList.Text = "Report Details"
        Me.lblReportList.Location = New Point(20, 270)
        Me.lblReportList.Font = New Font("Segoe UI", 10, FontStyle.Bold)

        Me.dgvReports.Location = New Point(20, 300)
        Me.dgvReports.Size = New Size(1050, 300)

        ' ================= ADD CONTROLS =================
        Me.pnlFilter.Controls.Add(Me.lblFrom)
        Me.pnlFilter.Controls.Add(Me.dtpFrom)
        Me.pnlFilter.Controls.Add(Me.lblTo)
        Me.pnlFilter.Controls.Add(Me.dtpTo)
        Me.pnlFilter.Controls.Add(Me.lblType)
        Me.pnlFilter.Controls.Add(Me.cmbType)
        Me.pnlFilter.Controls.Add(Me.btnGenerate)
        Me.pnlFilter.Controls.Add(Me.btnPrint)
        Me.pnlFilter.Controls.Add(Me.btnExport)

        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.pnlFilter)
        Me.Controls.Add(Me.lblTotalCollection)
        Me.Controls.Add(Me.txtTotalCollection)
        Me.Controls.Add(Me.lblTotalStudents)
        Me.Controls.Add(Me.txtTotalStudents)
        Me.Controls.Add(Me.lblReportList)
        Me.Controls.Add(Me.dgvReports)

        CType(Me.dgvReports, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    ' ================= DECLARATIONS =================
    Friend WithEvents lblTitle As Label

    Friend WithEvents pnlFilter As Panel
    Friend WithEvents lblFrom As Label
    Friend WithEvents dtpFrom As DateTimePicker
    Friend WithEvents lblTo As Label
    Friend WithEvents dtpTo As DateTimePicker
    Friend WithEvents lblType As Label
    Friend WithEvents cmbType As ComboBox

    Friend WithEvents btnGenerate As Button
    Friend WithEvents btnPrint As Button
    Friend WithEvents btnExport As Button

    Friend WithEvents lblTotalCollection As Label
    Friend WithEvents txtTotalCollection As TextBox

    Friend WithEvents lblTotalStudents As Label
    Friend WithEvents txtTotalStudents As TextBox

    Friend WithEvents lblReportList As Label
    Friend WithEvents dgvReports As DataGridView

End Class