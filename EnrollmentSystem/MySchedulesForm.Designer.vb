<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MySchedulesForm
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
        Me.lblTotalSchedules = New System.Windows.Forms.Label()
        Me.dgvSchedules = New System.Windows.Forms.DataGridView()
        Me.pnlBottom = New System.Windows.Forms.Panel()
        Me.btnViewClassList = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.pnlTop.SuspendLayout()
        CType(Me.dgvSchedules, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlBottom.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlTop
        '
        Me.pnlTop.BackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.pnlTop.Controls.Add(Me.lblTitle)
        Me.pnlTop.Controls.Add(Me.lblTotalSchedules)
        Me.pnlTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlTop.Location = New System.Drawing.Point(0, 0)
        Me.pnlTop.Name = "pnlTop"
        Me.pnlTop.Size = New System.Drawing.Size(1200, 70)
        Me.pnlTop.TabIndex = 0
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Segoe UI", 16.0!, System.Drawing.FontStyle.Bold)
        Me.lblTitle.ForeColor = System.Drawing.Color.White
        Me.lblTitle.Location = New System.Drawing.Point(20, 15)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Text = "MY TEACHING SCHEDULES"
        '
        'lblTotalSchedules
        '
        Me.lblTotalSchedules.AutoSize = True
        Me.lblTotalSchedules.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblTotalSchedules.ForeColor = System.Drawing.Color.FromArgb(CType(CType(189, Byte), Integer), CType(CType(195, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.lblTotalSchedules.Location = New System.Drawing.Point(22, 45)
        Me.lblTotalSchedules.Name = "lblTotalSchedules"
        Me.lblTotalSchedules.Text = "Total Schedules: 0"
        '
        'dgvSchedules
        '
        Me.dgvSchedules.AllowUserToAddRows = False
        Me.dgvSchedules.AllowUserToDeleteRows = False
        Me.dgvSchedules.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvSchedules.BackgroundColor = System.Drawing.Color.White
        Me.dgvSchedules.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvSchedules.ColumnHeadersHeight = 35
        Me.dgvSchedules.Location = New System.Drawing.Point(20, 90)
        Me.dgvSchedules.Name = "dgvSchedules"
        Me.dgvSchedules.ReadOnly = True
        Me.dgvSchedules.RowHeadersVisible = False
        Me.dgvSchedules.RowTemplate.Height = 30
        Me.dgvSchedules.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvSchedules.Size = New System.Drawing.Size(1160, 490)
        Me.dgvSchedules.TabIndex = 1
        '
        'pnlBottom
        '
        Me.pnlBottom.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.pnlBottom.Controls.Add(Me.btnViewClassList)
        Me.pnlBottom.Controls.Add(Me.btnClose)
        Me.pnlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pnlBottom.Location = New System.Drawing.Point(0, 600)
        Me.pnlBottom.Name = "pnlBottom"
        Me.pnlBottom.Size = New System.Drawing.Size(1200, 60)
        Me.pnlBottom.TabIndex = 2
        '
        'btnViewClassList
        '
        Me.btnViewClassList.BackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(185, Byte), Integer))
        Me.btnViewClassList.FlatAppearance.BorderSize = 0
        Me.btnViewClassList.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnViewClassList.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.btnViewClassList.ForeColor = System.Drawing.Color.White
        Me.btnViewClassList.Location = New System.Drawing.Point(20, 12)
        Me.btnViewClassList.Name = "btnViewClassList"
        Me.btnViewClassList.Size = New System.Drawing.Size(150, 35)
        Me.btnViewClassList.TabIndex = 0
        Me.btnViewClassList.Text = "View Class List"
        Me.btnViewClassList.UseVisualStyleBackColor = False
        '
        'btnClose
        '
        Me.btnClose.BackColor = System.Drawing.Color.FromArgb(CType(CType(149, Byte), Integer), CType(CType(165, Byte), Integer), CType(CType(166, Byte), Integer))
        Me.btnClose.FlatAppearance.BorderSize = 0
        Me.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClose.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.btnClose.ForeColor = System.Drawing.Color.White
        Me.btnClose.Location = New System.Drawing.Point(1030, 12)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(150, 35)
        Me.btnClose.TabIndex = 1
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = False
        '
        'MySchedulesForm
        '
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1200, 660)
        Me.Controls.Add(Me.pnlBottom)
        Me.Controls.Add(Me.dgvSchedules)
        Me.Controls.Add(Me.pnlTop)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Name = "MySchedulesForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "My Schedules"
        Me.pnlTop.ResumeLayout(False)
        Me.pnlTop.PerformLayout()
        CType(Me.dgvSchedules, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlBottom.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnlTop As System.Windows.Forms.Panel
    Friend WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents lblTotalSchedules As System.Windows.Forms.Label
    Friend WithEvents dgvSchedules As System.Windows.Forms.DataGridView
    Friend WithEvents pnlBottom As System.Windows.Forms.Panel
    Friend WithEvents btnViewClassList As System.Windows.Forms.Button
    Friend WithEvents btnClose As System.Windows.Forms.Button

End Class
