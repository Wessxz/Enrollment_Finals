<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class CashierReportsForm
    Inherits System.Windows.Forms.Form

    Private components As System.ComponentModel.IContainer

    Private Sub InitializeComponent()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.pnlFilter = New System.Windows.Forms.Panel()
        Me.lblFrom = New System.Windows.Forms.Label()
        Me.dtpFrom = New System.Windows.Forms.DateTimePicker()
        Me.lblTo = New System.Windows.Forms.Label()
        Me.dtpTo = New System.Windows.Forms.DateTimePicker()
        Me.lblType = New System.Windows.Forms.Label()
        Me.cmbType = New System.Windows.Forms.ComboBox()
        Me.btnGenerate = New System.Windows.Forms.Button()
        Me.btnPrint = New System.Windows.Forms.Button()
        Me.btnExport = New System.Windows.Forms.Button()
        Me.lblTotalCollection = New System.Windows.Forms.Label()
        Me.txtTotalCollection = New System.Windows.Forms.TextBox()
        Me.lblTotalStudents = New System.Windows.Forms.Label()
        Me.txtTotalStudents = New System.Windows.Forms.TextBox()
        Me.lblReportList = New System.Windows.Forms.Label()
        Me.dgvReports = New System.Windows.Forms.DataGridView()
        Me.pnlFilter.SuspendLayout()
        CType(Me.dgvReports, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold)
        Me.lblTitle.Location = New System.Drawing.Point(350, 20)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(317, 41)
        Me.lblTitle.TabIndex = 0
        Me.lblTitle.Text = "FINANCIAL REPORTS"
        '
        'pnlFilter
        '
        Me.pnlFilter.BackColor = System.Drawing.Color.WhiteSmoke
        Me.pnlFilter.Controls.Add(Me.lblFrom)
        Me.pnlFilter.Controls.Add(Me.dtpFrom)
        Me.pnlFilter.Controls.Add(Me.lblTo)
        Me.pnlFilter.Controls.Add(Me.dtpTo)
        Me.pnlFilter.Controls.Add(Me.lblType)
        Me.pnlFilter.Controls.Add(Me.cmbType)
        Me.pnlFilter.Controls.Add(Me.btnGenerate)
        Me.pnlFilter.Controls.Add(Me.btnPrint)
        Me.pnlFilter.Controls.Add(Me.btnExport)
        Me.pnlFilter.Location = New System.Drawing.Point(20, 80)
        Me.pnlFilter.Name = "pnlFilter"
        Me.pnlFilter.Size = New System.Drawing.Size(1050, 100)
        Me.pnlFilter.TabIndex = 1
        '
        'lblFrom
        '
        Me.lblFrom.Location = New System.Drawing.Point(20, 20)
        Me.lblFrom.Name = "lblFrom"
        Me.lblFrom.Size = New System.Drawing.Size(100, 23)
        Me.lblFrom.TabIndex = 0
        Me.lblFrom.Text = "From"
        '
        'dtpFrom
        '
        Me.dtpFrom.Location = New System.Drawing.Point(20, 50)
        Me.dtpFrom.Name = "dtpFrom"
        Me.dtpFrom.Size = New System.Drawing.Size(200, 22)
        Me.dtpFrom.TabIndex = 1
        '
        'lblTo
        '
        Me.lblTo.Location = New System.Drawing.Point(250, 20)
        Me.lblTo.Name = "lblTo"
        Me.lblTo.Size = New System.Drawing.Size(100, 23)
        Me.lblTo.TabIndex = 2
        Me.lblTo.Text = "To"
        '
        'dtpTo
        '
        Me.dtpTo.Location = New System.Drawing.Point(250, 50)
        Me.dtpTo.Name = "dtpTo"
        Me.dtpTo.Size = New System.Drawing.Size(200, 22)
        Me.dtpTo.TabIndex = 3
        '
        'lblType
        '
        Me.lblType.Location = New System.Drawing.Point(480, 20)
        Me.lblType.Name = "lblType"
        Me.lblType.Size = New System.Drawing.Size(100, 23)
        Me.lblType.TabIndex = 4
        Me.lblType.Text = "Report Type"
        '
        'cmbType
        '
        Me.cmbType.Items.AddRange(New Object() {"All Payments", "Fully Paid", "Partial Payments"})
        Me.cmbType.Location = New System.Drawing.Point(480, 50)
        Me.cmbType.Name = "cmbType"
        Me.cmbType.Size = New System.Drawing.Size(180, 24)
        Me.cmbType.TabIndex = 5
        '
        'btnGenerate
        '
        Me.btnGenerate.BackColor = System.Drawing.Color.Green
        Me.btnGenerate.ForeColor = System.Drawing.Color.White
        Me.btnGenerate.Location = New System.Drawing.Point(700, 50)
        Me.btnGenerate.Name = "btnGenerate"
        Me.btnGenerate.Size = New System.Drawing.Size(75, 23)
        Me.btnGenerate.TabIndex = 6
        Me.btnGenerate.Text = "Generate"
        Me.btnGenerate.UseVisualStyleBackColor = False
        '
        'btnPrint
        '
        Me.btnPrint.Location = New System.Drawing.Point(800, 50)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(75, 23)
        Me.btnPrint.TabIndex = 7
        Me.btnPrint.Text = "Print"
        '
        'btnExport
        '
        Me.btnExport.Location = New System.Drawing.Point(880, 50)
        Me.btnExport.Name = "btnExport"
        Me.btnExport.Size = New System.Drawing.Size(75, 23)
        Me.btnExport.TabIndex = 8
        Me.btnExport.Text = "Export"
        '
        'lblTotalCollection
        '
        Me.lblTotalCollection.Location = New System.Drawing.Point(20, 200)
        Me.lblTotalCollection.Name = "lblTotalCollection"
        Me.lblTotalCollection.Size = New System.Drawing.Size(100, 23)
        Me.lblTotalCollection.TabIndex = 2
        Me.lblTotalCollection.Text = "Total Collection"
        '
        'txtTotalCollection
        '
        Me.txtTotalCollection.Location = New System.Drawing.Point(20, 230)
        Me.txtTotalCollection.Name = "txtTotalCollection"
        Me.txtTotalCollection.ReadOnly = True
        Me.txtTotalCollection.Size = New System.Drawing.Size(200, 22)
        Me.txtTotalCollection.TabIndex = 3
        '
        'lblTotalStudents
        '
        Me.lblTotalStudents.Location = New System.Drawing.Point(250, 200)
        Me.lblTotalStudents.Name = "lblTotalStudents"
        Me.lblTotalStudents.Size = New System.Drawing.Size(100, 23)
        Me.lblTotalStudents.TabIndex = 4
        Me.lblTotalStudents.Text = "Total Students Paid"
        '
        'txtTotalStudents
        '
        Me.txtTotalStudents.Location = New System.Drawing.Point(250, 230)
        Me.txtTotalStudents.Name = "txtTotalStudents"
        Me.txtTotalStudents.ReadOnly = True
        Me.txtTotalStudents.Size = New System.Drawing.Size(200, 22)
        Me.txtTotalStudents.TabIndex = 5
        '
        'lblReportList
        '
        Me.lblReportList.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.lblReportList.Location = New System.Drawing.Point(20, 270)
        Me.lblReportList.Name = "lblReportList"
        Me.lblReportList.Size = New System.Drawing.Size(100, 23)
        Me.lblReportList.TabIndex = 6
        Me.lblReportList.Text = "Report Details"
        '
        'dgvReports
        '
        Me.dgvReports.ColumnHeadersHeight = 29
        Me.dgvReports.Location = New System.Drawing.Point(20, 300)
        Me.dgvReports.Name = "dgvReports"
        Me.dgvReports.RowHeadersWidth = 51
        Me.dgvReports.Size = New System.Drawing.Size(1050, 300)
        Me.dgvReports.TabIndex = 7
        '
        'CashierReportsForm
        '
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1100, 650)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.pnlFilter)
        Me.Controls.Add(Me.lblTotalCollection)
        Me.Controls.Add(Me.txtTotalCollection)
        Me.Controls.Add(Me.lblTotalStudents)
        Me.Controls.Add(Me.txtTotalStudents)
        Me.Controls.Add(Me.lblReportList)
        Me.Controls.Add(Me.dgvReports)
        Me.Name = "CashierReportsForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Financial Reports"
        Me.pnlFilter.ResumeLayout(False)
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