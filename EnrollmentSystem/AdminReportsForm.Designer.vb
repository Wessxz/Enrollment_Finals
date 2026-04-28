Partial Class AdminReportsForm
    Inherits Form

    Private Sub InitializeComponent()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.dgvReports = New System.Windows.Forms.DataGridView()
        Me.btnLoadEnrollment = New System.Windows.Forms.Button()
        Me.btnLoadFinance = New System.Windows.Forms.Button()
        CType(Me.dgvReports, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblTitle
        '
        Me.lblTitle.Font = New System.Drawing.Font("Segoe UI", 16.0!, System.Drawing.FontStyle.Bold)
        Me.lblTitle.Location = New System.Drawing.Point(350, 20)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(360, 50)
        Me.lblTitle.TabIndex = 0
        Me.lblTitle.Text = "ADMIN REPORTS"
        '
        'dgvReports
        '
        Me.dgvReports.ColumnHeadersHeight = 29
        Me.dgvReports.Location = New System.Drawing.Point(50, 100)
        Me.dgvReports.Name = "dgvReports"
        Me.dgvReports.RowHeadersWidth = 51
        Me.dgvReports.Size = New System.Drawing.Size(800, 350)
        Me.dgvReports.TabIndex = 1
        '
        'btnLoadEnrollment
        '
        Me.btnLoadEnrollment.Location = New System.Drawing.Point(50, 60)
        Me.btnLoadEnrollment.Name = "btnLoadEnrollment"
        Me.btnLoadEnrollment.Size = New System.Drawing.Size(75, 23)
        Me.btnLoadEnrollment.TabIndex = 2
        Me.btnLoadEnrollment.Text = "Enrollment Report"
        '
        'btnLoadFinance
        '
        Me.btnLoadFinance.Location = New System.Drawing.Point(200, 60)
        Me.btnLoadFinance.Name = "btnLoadFinance"
        Me.btnLoadFinance.Size = New System.Drawing.Size(75, 23)
        Me.btnLoadFinance.TabIndex = 3
        Me.btnLoadFinance.Text = "Financial Report"
        '
        'AdminReportsForm
        '
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(900, 500)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.dgvReports)
        Me.Controls.Add(Me.btnLoadEnrollment)
        Me.Controls.Add(Me.btnLoadFinance)
        Me.Name = "AdminReportsForm"
        CType(Me.dgvReports, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lblTitle As Label
    Friend WithEvents dgvReports As DataGridView
    Friend WithEvents btnLoadEnrollment As Button
    Friend WithEvents btnLoadFinance As Button

End Class