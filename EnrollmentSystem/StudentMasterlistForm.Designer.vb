<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class StudentMasterlistForm
    Inherits System.Windows.Forms.Form

    Private components As System.ComponentModel.IContainer

    Protected Overrides Sub Dispose(disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    Private Sub InitializeComponent()
        Me.pnlTop = New System.Windows.Forms.Panel()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.lblTotalRecords = New System.Windows.Forms.Label()
        Me.lblPendingGrades = New System.Windows.Forms.Label()
        Me.pnlFilters = New System.Windows.Forms.Panel()
        Me.lblSearch = New System.Windows.Forms.Label()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.lblSubjectFilter = New System.Windows.Forms.Label()
        Me.cmbSubjectFilter = New System.Windows.Forms.ComboBox()
        Me.dgvGrades = New System.Windows.Forms.DataGridView()
        Me.pnlBottom = New System.Windows.Forms.Panel()
        Me.btnExport = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.pnlTop.SuspendLayout()
        Me.pnlFilters.SuspendLayout()
        CType(Me.dgvGrades, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlBottom.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlTop
        '
        Me.pnlTop.BackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.pnlTop.Controls.Add(Me.lblTitle)
        Me.pnlTop.Controls.Add(Me.lblTotalRecords)
        Me.pnlTop.Controls.Add(Me.lblPendingGrades)
        Me.pnlTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlTop.Location = New System.Drawing.Point(0, 0)
        Me.pnlTop.Name = "pnlTop"
        Me.pnlTop.Size = New System.Drawing.Size(1300, 70)
        Me.pnlTop.TabIndex = 0
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Segoe UI", 16.0!, System.Drawing.FontStyle.Bold)
        Me.lblTitle.ForeColor = System.Drawing.Color.White
        Me.lblTitle.Location = New System.Drawing.Point(20, 15)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Text = "GRADES MASTERLIST"
        '
        'lblTotalRecords
        '
        Me.lblTotalRecords.AutoSize = True
        Me.lblTotalRecords.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblTotalRecords.ForeColor = System.Drawing.Color.FromArgb(CType(CType(189, Byte), Integer), CType(CType(195, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.lblTotalRecords.Location = New System.Drawing.Point(22, 45)
        Me.lblTotalRecords.Name = "lblTotalRecords"
        Me.lblTotalRecords.Text = "Total Records: 0"
        '
        'lblPendingGrades
        '
        Me.lblPendingGrades.AutoSize = True
        Me.lblPendingGrades.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblPendingGrades.ForeColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(76, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.lblPendingGrades.Location = New System.Drawing.Point(180, 45)
        Me.lblPendingGrades.Name = "lblPendingGrades"
        Me.lblPendingGrades.Text = "Pending Grades: 0"
        '
        'pnlFilters
        '
        Me.pnlFilters.BackColor = System.Drawing.Color.White
        Me.pnlFilters.Controls.Add(Me.lblSearch)
        Me.pnlFilters.Controls.Add(Me.txtSearch)
        Me.pnlFilters.Controls.Add(Me.lblSubjectFilter)
        Me.pnlFilters.Controls.Add(Me.cmbSubjectFilter)
        Me.pnlFilters.Location = New System.Drawing.Point(20, 90)
        Me.pnlFilters.Name = "pnlFilters"
        Me.pnlFilters.Size = New System.Drawing.Size(1260, 50)
        Me.pnlFilters.TabIndex = 1
        '
        'lblSearch
        '
        Me.lblSearch.AutoSize = True
        Me.lblSearch.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblSearch.ForeColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.lblSearch.Location = New System.Drawing.Point(15, 15)
        Me.lblSearch.Name = "lblSearch"
        Me.lblSearch.Text = "Search:"
        '
        'txtSearch
        '
        Me.txtSearch.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.txtSearch.Location = New System.Drawing.Point(80, 12)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(350, 25)
        Me.txtSearch.TabIndex = 0
        '
        'lblSubjectFilter
        '
        Me.lblSubjectFilter.AutoSize = True
        Me.lblSubjectFilter.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblSubjectFilter.ForeColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.lblSubjectFilter.Location = New System.Drawing.Point(460, 15)
        Me.lblSubjectFilter.Name = "lblSubjectFilter"
        Me.lblSubjectFilter.Text = "Filter by Subject:"
        '
        'cmbSubjectFilter
        '
        Me.cmbSubjectFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbSubjectFilter.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.cmbSubjectFilter.FormattingEnabled = True
        Me.cmbSubjectFilter.Location = New System.Drawing.Point(580, 12)
        Me.cmbSubjectFilter.Name = "cmbSubjectFilter"
        Me.cmbSubjectFilter.Size = New System.Drawing.Size(400, 25)
        Me.cmbSubjectFilter.TabIndex = 1
        '
        'dgvGrades
        '
        Me.dgvGrades.AllowUserToAddRows = False
        Me.dgvGrades.AllowUserToDeleteRows = False
        Me.dgvGrades.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvGrades.BackgroundColor = System.Drawing.Color.White
        Me.dgvGrades.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvGrades.ColumnHeadersHeight = 35
        Me.dgvGrades.Location = New System.Drawing.Point(20, 160)
        Me.dgvGrades.Name = "dgvGrades"
        Me.dgvGrades.ReadOnly = True
        Me.dgvGrades.RowHeadersVisible = False
        Me.dgvGrades.RowTemplate.Height = 30
        Me.dgvGrades.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvGrades.Size = New System.Drawing.Size(1260, 470)
        Me.dgvGrades.TabIndex = 2
        '
        'pnlBottom
        '
        Me.pnlBottom.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.pnlBottom.Controls.Add(Me.btnExport)
        Me.pnlBottom.Controls.Add(Me.btnClose)
        Me.pnlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pnlBottom.Location = New System.Drawing.Point(0, 650)
        Me.pnlBottom.Name = "pnlBottom"
        Me.pnlBottom.Size = New System.Drawing.Size(1300, 60)
        Me.pnlBottom.TabIndex = 3
        '
        'btnExport
        '
        Me.btnExport.BackColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.btnExport.FlatAppearance.BorderSize = 0
        Me.btnExport.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExport.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.btnExport.ForeColor = System.Drawing.Color.White
        Me.btnExport.Location = New System.Drawing.Point(20, 12)
        Me.btnExport.Name = "btnExport"
        Me.btnExport.Size = New System.Drawing.Size(150, 35)
        Me.btnExport.TabIndex = 0
        Me.btnExport.Text = "Export to CSV"
        Me.btnExport.UseVisualStyleBackColor = False
        '
        'btnClose
        '
        Me.btnClose.BackColor = System.Drawing.Color.FromArgb(CType(CType(149, Byte), Integer), CType(CType(165, Byte), Integer), CType(CType(166, Byte), Integer))
        Me.btnClose.FlatAppearance.BorderSize = 0
        Me.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClose.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.btnClose.ForeColor = System.Drawing.Color.White
        Me.btnClose.Location = New System.Drawing.Point(1130, 12)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(150, 35)
        Me.btnClose.TabIndex = 1
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = False
        '
        'StudentMasterlistForm
        '
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1300, 710)
        Me.Controls.Add(Me.pnlBottom)
        Me.Controls.Add(Me.dgvGrades)
        Me.Controls.Add(Me.pnlFilters)
        Me.Controls.Add(Me.pnlTop)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Name = "StudentMasterlistForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Grades Masterlist"
        Me.pnlTop.ResumeLayout(False)
        Me.pnlTop.PerformLayout()
        Me.pnlFilters.ResumeLayout(False)
        Me.pnlFilters.PerformLayout()
        CType(Me.dgvGrades, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlBottom.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnlTop As System.Windows.Forms.Panel
    Friend WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents lblTotalRecords As System.Windows.Forms.Label
    Friend WithEvents lblPendingGrades As System.Windows.Forms.Label
    Friend WithEvents pnlFilters As System.Windows.Forms.Panel
    Friend WithEvents lblSearch As System.Windows.Forms.Label
    Friend WithEvents txtSearch As System.Windows.Forms.TextBox
    Friend WithEvents lblSubjectFilter As System.Windows.Forms.Label
    Friend WithEvents cmbSubjectFilter As System.Windows.Forms.ComboBox
    Friend WithEvents dgvGrades As System.Windows.Forms.DataGridView
    Friend WithEvents pnlBottom As System.Windows.Forms.Panel
    Friend WithEvents btnExport As System.Windows.Forms.Button
    Friend WithEvents btnClose As System.Windows.Forms.Button

End Class
