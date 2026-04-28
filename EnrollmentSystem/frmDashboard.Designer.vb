<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmDashboard
    Inherits System.Windows.Forms.Form

    Private components As System.ComponentModel.IContainer

    <System.Diagnostics.DebuggerNonUserCode()>
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
        Me.pnlSidebar = New System.Windows.Forms.Panel()
        Me.btnSchedule = New System.Windows.Forms.Button()
        Me.btnFaculty = New System.Windows.Forms.Button()
        Me.btnSubjects = New System.Windows.Forms.Button()
        Me.btnSections = New System.Windows.Forms.Button()
        Me.btnStudents = New System.Windows.Forms.Button()
        Me.btnDashboard = New System.Windows.Forms.Button()
        Me.btnLogout = New System.Windows.Forms.Button()
        Me.pnlTop = New System.Windows.Forms.Panel()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.pnlMain = New System.Windows.Forms.Panel()
        Me.pnlSidebar.SuspendLayout()
        Me.pnlTop.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlSidebar
        '
        Me.pnlSidebar.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.pnlSidebar.Controls.Add(Me.btnSchedule)
        Me.pnlSidebar.Controls.Add(Me.btnFaculty)
        Me.pnlSidebar.Controls.Add(Me.btnSubjects)
        Me.pnlSidebar.Controls.Add(Me.btnSections)
        Me.pnlSidebar.Controls.Add(Me.btnStudents)
        Me.pnlSidebar.Controls.Add(Me.btnDashboard)
        Me.pnlSidebar.Controls.Add(Me.btnLogout)
        Me.pnlSidebar.Dock = System.Windows.Forms.DockStyle.Left
        Me.pnlSidebar.Location = New System.Drawing.Point(0, 0)
        Me.pnlSidebar.Name = "pnlSidebar"
        Me.pnlSidebar.Size = New System.Drawing.Size(220, 700)
        Me.pnlSidebar.TabIndex = 2
        '
        'btnSchedule
        '
        Me.btnSchedule.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnSchedule.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSchedule.ForeColor = System.Drawing.Color.White
        Me.btnSchedule.Location = New System.Drawing.Point(0, 250)
        Me.btnSchedule.Name = "btnSchedule"
        Me.btnSchedule.Size = New System.Drawing.Size(220, 50)
        Me.btnSchedule.TabIndex = 0
        Me.btnSchedule.Text = "Schedule"
        '
        'btnFaculty
        '
        Me.btnFaculty.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnFaculty.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnFaculty.ForeColor = System.Drawing.Color.White
        Me.btnFaculty.Location = New System.Drawing.Point(0, 200)
        Me.btnFaculty.Name = "btnFaculty"
        Me.btnFaculty.Size = New System.Drawing.Size(220, 50)
        Me.btnFaculty.TabIndex = 1
        Me.btnFaculty.Text = "Faculty"
        '
        'btnSubjects
        '
        Me.btnSubjects.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnSubjects.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSubjects.ForeColor = System.Drawing.Color.White
        Me.btnSubjects.Location = New System.Drawing.Point(0, 150)
        Me.btnSubjects.Name = "btnSubjects"
        Me.btnSubjects.Size = New System.Drawing.Size(220, 50)
        Me.btnSubjects.TabIndex = 2
        Me.btnSubjects.Text = "Subjects"
        '
        'btnSections
        '
        Me.btnSections.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnSections.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSections.ForeColor = System.Drawing.Color.White
        Me.btnSections.Location = New System.Drawing.Point(0, 100)
        Me.btnSections.Name = "btnSections"
        Me.btnSections.Size = New System.Drawing.Size(220, 50)
        Me.btnSections.TabIndex = 3
        Me.btnSections.Text = "Sections"
        '
        'btnStudents
        '
        Me.btnStudents.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnStudents.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnStudents.ForeColor = System.Drawing.Color.White
        Me.btnStudents.Location = New System.Drawing.Point(0, 50)
        Me.btnStudents.Name = "btnStudents"
        Me.btnStudents.Size = New System.Drawing.Size(220, 50)
        Me.btnStudents.TabIndex = 4
        Me.btnStudents.Text = "Students"
        '
        'btnDashboard
        '
        Me.btnDashboard.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDashboard.ForeColor = System.Drawing.Color.White
        Me.btnDashboard.Location = New System.Drawing.Point(0, 0)
        Me.btnDashboard.Name = "btnDashboard"
        Me.btnDashboard.Size = New System.Drawing.Size(220, 50)
        Me.btnDashboard.TabIndex = 5
        Me.btnDashboard.Text = "Dashboard"
        '
        'btnLogout
        '
        Me.btnLogout.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLogout.ForeColor = System.Drawing.Color.White
        Me.btnLogout.Location = New System.Drawing.Point(0, 650)
        Me.btnLogout.Name = "btnLogout"
        Me.btnLogout.Size = New System.Drawing.Size(220, 50)
        Me.btnLogout.TabIndex = 6
        Me.btnLogout.Text = "Logout"
        '
        'pnlTop
        '
        Me.pnlTop.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(113, Byte), Integer))
        Me.pnlTop.Controls.Add(Me.lblTitle)
        Me.pnlTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlTop.Location = New System.Drawing.Point(220, 0)
        Me.pnlTop.Name = "pnlTop"
        Me.pnlTop.Size = New System.Drawing.Size(980, 60)
        Me.pnlTop.TabIndex = 1
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Bold)
        Me.lblTitle.ForeColor = System.Drawing.Color.White
        Me.lblTitle.Location = New System.Drawing.Point(240, 15)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(399, 32)
        Me.lblTitle.TabIndex = 0
        Me.lblTitle.Text = "REGISTRAR SYSTEM DASHBOARD"
        '
        'pnlMain
        '
        Me.pnlMain.BackColor = System.Drawing.Color.White
        Me.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlMain.Location = New System.Drawing.Point(220, 60)
        Me.pnlMain.Name = "pnlMain"
        Me.pnlMain.Size = New System.Drawing.Size(980, 640)
        Me.pnlMain.TabIndex = 0
        '
        'frmDashboard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1200, 700)
        Me.Controls.Add(Me.pnlMain)
        Me.Controls.Add(Me.pnlTop)
        Me.Controls.Add(Me.pnlSidebar)
        Me.Name = "frmDashboard"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Registrar Dashboard"
        Me.pnlSidebar.ResumeLayout(False)
        Me.pnlTop.ResumeLayout(False)
        Me.pnlTop.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    ' ================= CONTROLS =================
    Friend WithEvents pnlSidebar As Panel
    Friend WithEvents pnlTop As Panel
    Friend WithEvents pnlMain As Panel

    Friend WithEvents btnDashboard As Button
    Friend WithEvents btnStudents As Button
    Friend WithEvents btnSections As Button
    Friend WithEvents btnSubjects As Button
    Friend WithEvents btnFaculty As Button
    Friend WithEvents btnSchedule As Button
    Friend WithEvents btnLogout As Button

    Friend WithEvents lblTitle As Label

End Class