<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Dean
    Inherits System.Windows.Forms.Form

    Private components As System.ComponentModel.IContainer

    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.pnlSidebar = New System.Windows.Forms.Panel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btnGrades = New System.Windows.Forms.Button()
        Me.btnAnnouncements = New System.Windows.Forms.Button()
        Me.btnClassList = New System.Windows.Forms.Button()
        Me.btnLogout = New System.Windows.Forms.Button()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.pnlSidebar.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlSidebar
        '
        Me.pnlSidebar.BackColor = System.Drawing.Color.FromArgb(CType(CType(49, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(129, Byte), Integer))
        Me.pnlSidebar.Controls.Add(Me.Button1)
        Me.pnlSidebar.Controls.Add(Me.btnGrades)
        Me.pnlSidebar.Controls.Add(Me.btnAnnouncements)
        Me.pnlSidebar.Controls.Add(Me.btnClassList)
        Me.pnlSidebar.Controls.Add(Me.btnLogout)
        Me.pnlSidebar.Dock = System.Windows.Forms.DockStyle.Left
        Me.pnlSidebar.Location = New System.Drawing.Point(0, 0)
        Me.pnlSidebar.Name = "pnlSidebar"
        Me.pnlSidebar.Size = New System.Drawing.Size(220, 600)
        Me.pnlSidebar.TabIndex = 0
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(67, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(202, Byte), Integer))
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(10, 278)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(200, 45)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "Assign Subject"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'btnGrades
        '
        Me.btnGrades.BackColor = System.Drawing.Color.FromArgb(CType(CType(99, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.btnGrades.FlatAppearance.BorderSize = 0
        Me.btnGrades.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGrades.ForeColor = System.Drawing.Color.White
        Me.btnGrades.Location = New System.Drawing.Point(10, 100)
        Me.btnGrades.Name = "btnGrades"
        Me.btnGrades.Size = New System.Drawing.Size(200, 45)
        Me.btnGrades.TabIndex = 0
        Me.btnGrades.Text = "Encode Grades"
        Me.btnGrades.UseVisualStyleBackColor = False
        '
        'btnAnnouncements
        '
        Me.btnAnnouncements.BackColor = System.Drawing.Color.FromArgb(CType(CType(99, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.btnAnnouncements.FlatAppearance.BorderSize = 0
        Me.btnAnnouncements.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAnnouncements.ForeColor = System.Drawing.Color.White
        Me.btnAnnouncements.Location = New System.Drawing.Point(10, 160)
        Me.btnAnnouncements.Name = "btnAnnouncements"
        Me.btnAnnouncements.Size = New System.Drawing.Size(200, 45)
        Me.btnAnnouncements.TabIndex = 1
        Me.btnAnnouncements.Text = "Post Announcements"
        Me.btnAnnouncements.UseVisualStyleBackColor = False
        '
        'btnClassList
        '
        Me.btnClassList.BackColor = System.Drawing.Color.FromArgb(CType(CType(99, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.btnClassList.FlatAppearance.BorderSize = 0
        Me.btnClassList.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClassList.ForeColor = System.Drawing.Color.White
        Me.btnClassList.Location = New System.Drawing.Point(10, 220)
        Me.btnClassList.Name = "btnClassList"
        Me.btnClassList.Size = New System.Drawing.Size(200, 45)
        Me.btnClassList.TabIndex = 2
        Me.btnClassList.Text = "Class List"
        Me.btnClassList.UseVisualStyleBackColor = False
        '
        'btnLogout
        '
        Me.btnLogout.BackColor = System.Drawing.Color.FromArgb(CType(CType(127, Byte), Integer), CType(CType(29, Byte), Integer), CType(CType(29, Byte), Integer))
        Me.btnLogout.FlatAppearance.BorderSize = 0
        Me.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLogout.ForeColor = System.Drawing.Color.White
        Me.btnLogout.Location = New System.Drawing.Point(10, 500)
        Me.btnLogout.Name = "btnLogout"
        Me.btnLogout.Size = New System.Drawing.Size(200, 45)
        Me.btnLogout.TabIndex = 3
        Me.btnLogout.Text = "Logout"
        Me.btnLogout.UseVisualStyleBackColor = False
        '
        'lblTitle
        '
        Me.lblTitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(49, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(129, Byte), Integer))
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Segoe UI", 20.0!, System.Drawing.FontStyle.Bold)
        Me.lblTitle.Location = New System.Drawing.Point(260, 40)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(334, 46)
        Me.lblTitle.TabIndex = 1
        Me.lblTitle.Text = "DEAN DASHBOARD"
        '
        'Dean
        '
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(233, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1000, 600)
        Me.Controls.Add(Me.pnlSidebar)
        Me.Controls.Add(Me.lblTitle)
        Me.Name = "Dean"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Faculty Dashboard"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.pnlSidebar.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents pnlSidebar As Panel
    Friend WithEvents btnGrades As Button
    Friend WithEvents btnAnnouncements As Button
    Friend WithEvents btnClassList As Button
    Friend WithEvents btnLogout As Button
    Friend WithEvents lblTitle As Label
    Friend WithEvents Button1 As Button
End Class