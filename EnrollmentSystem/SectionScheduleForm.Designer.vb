<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class SectionScheduleForm
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
        Me.lblInfo = New System.Windows.Forms.Label()
        Me.pnlTop2 = New System.Windows.Forms.Panel()
        Me.lblSelectSection = New System.Windows.Forms.Label()
        Me.cmbSection = New System.Windows.Forms.ComboBox()
        Me.btnLoadSection = New System.Windows.Forms.Button()
        Me.pnlLeft = New System.Windows.Forms.Panel()
        Me.lblAvailable = New System.Windows.Forms.Label()
        Me.dgvAvailable = New System.Windows.Forms.DataGridView()
        Me.pnlMiddle = New System.Windows.Forms.Panel()
        Me.btnAssign = New System.Windows.Forms.Button()
        Me.btnRemove = New System.Windows.Forms.Button()
        Me.pnlRight = New System.Windows.Forms.Panel()
        Me.lblAssigned = New System.Windows.Forms.Label()
        Me.dgvAssigned = New System.Windows.Forms.DataGridView()
        Me.pnlTop.SuspendLayout()
        Me.pnlTop2.SuspendLayout()
        Me.pnlLeft.SuspendLayout()
        CType(Me.dgvAvailable, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlMiddle.SuspendLayout()
        Me.pnlRight.SuspendLayout()
        CType(Me.dgvAssigned, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnlTop
        '
        Me.pnlTop.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.pnlTop.Controls.Add(Me.lblTitle)
        Me.pnlTop.Controls.Add(Me.lblInfo)
        Me.pnlTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlTop.Location = New System.Drawing.Point(0, 0)
        Me.pnlTop.Name = "pnlTop"
        Me.pnlTop.Size = New System.Drawing.Size(1200, 60)
        Me.pnlTop.TabIndex = 0
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Segoe UI", 16.0!, System.Drawing.FontStyle.Bold)
        Me.lblTitle.ForeColor = System.Drawing.Color.White
        Me.lblTitle.Location = New System.Drawing.Point(20, 10)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(433, 37)
        Me.lblTitle.TabIndex = 0
        Me.lblTitle.Text = "ASSIGN SCHEDULES TO SECTION"
        '
        'lblInfo
        '
        Me.lblInfo.AutoSize = True
        Me.lblInfo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lblInfo.Location = New System.Drawing.Point(22, 40)
        Me.lblInfo.Name = "lblInfo"
        Me.lblInfo.Size = New System.Drawing.Size(292, 20)
        Me.lblInfo.TabIndex = 1
        Me.lblInfo.Text = "Select a section, then assign schedules to it"
        '
        'pnlTop2
        '
        Me.pnlTop2.BackColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.pnlTop2.Controls.Add(Me.lblSelectSection)
        Me.pnlTop2.Controls.Add(Me.cmbSection)
        Me.pnlTop2.Controls.Add(Me.btnLoadSection)
        Me.pnlTop2.Location = New System.Drawing.Point(0, 60)
        Me.pnlTop2.Name = "pnlTop2"
        Me.pnlTop2.Size = New System.Drawing.Size(1200, 50)
        Me.pnlTop2.TabIndex = 1
        '
        'lblSelectSection
        '
        Me.lblSelectSection.AutoSize = True
        Me.lblSelectSection.Location = New System.Drawing.Point(15, 15)
        Me.lblSelectSection.Name = "lblSelectSection"
        Me.lblSelectSection.Size = New System.Drawing.Size(61, 20)
        Me.lblSelectSection.TabIndex = 0
        Me.lblSelectSection.Text = "Section:"
        '
        'cmbSection
        '
        Me.cmbSection.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbSection.Location = New System.Drawing.Point(70, 12)
        Me.cmbSection.Name = "cmbSection"
        Me.cmbSection.Size = New System.Drawing.Size(300, 28)
        Me.cmbSection.TabIndex = 1
        '
        'btnLoadSection
        '
        Me.btnLoadSection.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.btnLoadSection.FlatAppearance.BorderSize = 0
        Me.btnLoadSection.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLoadSection.ForeColor = System.Drawing.Color.White
        Me.btnLoadSection.Location = New System.Drawing.Point(380, 11)
        Me.btnLoadSection.Name = "btnLoadSection"
        Me.btnLoadSection.Size = New System.Drawing.Size(80, 27)
        Me.btnLoadSection.TabIndex = 2
        Me.btnLoadSection.Text = "Load"
        Me.btnLoadSection.UseVisualStyleBackColor = False
        '
        'pnlLeft
        '
        Me.pnlLeft.BackColor = System.Drawing.Color.White
        Me.pnlLeft.Controls.Add(Me.lblAvailable)
        Me.pnlLeft.Controls.Add(Me.dgvAvailable)
        Me.pnlLeft.Location = New System.Drawing.Point(10, 120)
        Me.pnlLeft.Name = "pnlLeft"
        Me.pnlLeft.Size = New System.Drawing.Size(530, 560)
        Me.pnlLeft.TabIndex = 2
        '
        'lblAvailable
        '
        Me.lblAvailable.AutoSize = True
        Me.lblAvailable.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblAvailable.Location = New System.Drawing.Point(10, 10)
        Me.lblAvailable.Name = "lblAvailable"
        Me.lblAvailable.Size = New System.Drawing.Size(283, 20)
        Me.lblAvailable.TabIndex = 0
        Me.lblAvailable.Text = "Available Schedules (not yet in section)"
        '
        'dgvAvailable
        '
        Me.dgvAvailable.AllowUserToAddRows = False
        Me.dgvAvailable.AllowUserToDeleteRows = False
        Me.dgvAvailable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvAvailable.BackgroundColor = System.Drawing.Color.White
        Me.dgvAvailable.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvAvailable.ColumnHeadersHeight = 32
        Me.dgvAvailable.Location = New System.Drawing.Point(10, 35)
        Me.dgvAvailable.Name = "dgvAvailable"
        Me.dgvAvailable.ReadOnly = True
        Me.dgvAvailable.RowHeadersVisible = False
        Me.dgvAvailable.RowHeadersWidth = 51
        Me.dgvAvailable.RowTemplate.Height = 28
        Me.dgvAvailable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvAvailable.Size = New System.Drawing.Size(510, 510)
        Me.dgvAvailable.TabIndex = 1
        '
        'pnlMiddle
        '
        Me.pnlMiddle.BackColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.pnlMiddle.Controls.Add(Me.btnAssign)
        Me.pnlMiddle.Controls.Add(Me.btnRemove)
        Me.pnlMiddle.Location = New System.Drawing.Point(550, 120)
        Me.pnlMiddle.Name = "pnlMiddle"
        Me.pnlMiddle.Size = New System.Drawing.Size(90, 560)
        Me.pnlMiddle.TabIndex = 3
        '
        'btnAssign
        '
        Me.btnAssign.BackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(163, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.btnAssign.FlatAppearance.BorderSize = 0
        Me.btnAssign.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAssign.ForeColor = System.Drawing.Color.White
        Me.btnAssign.Location = New System.Drawing.Point(5, 230)
        Me.btnAssign.Name = "btnAssign"
        Me.btnAssign.Size = New System.Drawing.Size(80, 35)
        Me.btnAssign.TabIndex = 0
        Me.btnAssign.Text = "Add →"
        Me.btnAssign.UseVisualStyleBackColor = False
        '
        'btnRemove
        '
        Me.btnRemove.BackColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.btnRemove.FlatAppearance.BorderSize = 0
        Me.btnRemove.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRemove.ForeColor = System.Drawing.Color.White
        Me.btnRemove.Location = New System.Drawing.Point(5, 275)
        Me.btnRemove.Name = "btnRemove"
        Me.btnRemove.Size = New System.Drawing.Size(80, 35)
        Me.btnRemove.TabIndex = 1
        Me.btnRemove.Text = "← Remove"
        Me.btnRemove.UseVisualStyleBackColor = False
        '
        'pnlRight
        '
        Me.pnlRight.BackColor = System.Drawing.Color.White
        Me.pnlRight.Controls.Add(Me.lblAssigned)
        Me.pnlRight.Controls.Add(Me.dgvAssigned)
        Me.pnlRight.Location = New System.Drawing.Point(650, 120)
        Me.pnlRight.Name = "pnlRight"
        Me.pnlRight.Size = New System.Drawing.Size(535, 560)
        Me.pnlRight.TabIndex = 4
        '
        'lblAssigned
        '
        Me.lblAssigned.AutoSize = True
        Me.lblAssigned.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblAssigned.Location = New System.Drawing.Point(10, 10)
        Me.lblAssigned.Name = "lblAssigned"
        Me.lblAssigned.Size = New System.Drawing.Size(220, 20)
        Me.lblAssigned.TabIndex = 0
        Me.lblAssigned.Text = "Schedules Assigned to Section"
        '
        'dgvAssigned
        '
        Me.dgvAssigned.AllowUserToAddRows = False
        Me.dgvAssigned.AllowUserToDeleteRows = False
        Me.dgvAssigned.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvAssigned.BackgroundColor = System.Drawing.Color.White
        Me.dgvAssigned.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvAssigned.ColumnHeadersHeight = 32
        Me.dgvAssigned.Location = New System.Drawing.Point(10, 35)
        Me.dgvAssigned.Name = "dgvAssigned"
        Me.dgvAssigned.ReadOnly = True
        Me.dgvAssigned.RowHeadersVisible = False
        Me.dgvAssigned.RowHeadersWidth = 51
        Me.dgvAssigned.RowTemplate.Height = 28
        Me.dgvAssigned.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvAssigned.Size = New System.Drawing.Size(515, 510)
        Me.dgvAssigned.TabIndex = 1
        '
        'SectionScheduleForm
        '
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1200, 700)
        Me.Controls.Add(Me.pnlTop)
        Me.Controls.Add(Me.pnlTop2)
        Me.Controls.Add(Me.pnlLeft)
        Me.Controls.Add(Me.pnlMiddle)
        Me.Controls.Add(Me.pnlRight)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Name = "SectionScheduleForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Assign Schedules to Section"
        Me.pnlTop.ResumeLayout(False)
        Me.pnlTop.PerformLayout()
        Me.pnlTop2.ResumeLayout(False)
        Me.pnlTop2.PerformLayout()
        Me.pnlLeft.ResumeLayout(False)
        Me.pnlLeft.PerformLayout()
        CType(Me.dgvAvailable, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlMiddle.ResumeLayout(False)
        Me.pnlRight.ResumeLayout(False)
        Me.pnlRight.PerformLayout()
        CType(Me.dgvAssigned, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnlTop          As System.Windows.Forms.Panel
    Friend WithEvents lblTitle        As System.Windows.Forms.Label
    Friend WithEvents lblInfo         As System.Windows.Forms.Label
    Friend WithEvents pnlTop2         As System.Windows.Forms.Panel
    Friend WithEvents lblSelectSection As System.Windows.Forms.Label
    Friend WithEvents cmbSection      As System.Windows.Forms.ComboBox
    Friend WithEvents btnLoadSection  As System.Windows.Forms.Button
    Friend WithEvents pnlLeft         As System.Windows.Forms.Panel
    Friend WithEvents lblAvailable    As System.Windows.Forms.Label
    Friend WithEvents dgvAvailable    As System.Windows.Forms.DataGridView
    Friend WithEvents pnlMiddle       As System.Windows.Forms.Panel
    Friend WithEvents btnAssign       As System.Windows.Forms.Button
    Friend WithEvents btnRemove       As System.Windows.Forms.Button
    Friend WithEvents pnlRight        As System.Windows.Forms.Panel
    Friend WithEvents lblAssigned     As System.Windows.Forms.Label
    Friend WithEvents dgvAssigned     As System.Windows.Forms.DataGridView
End Class
