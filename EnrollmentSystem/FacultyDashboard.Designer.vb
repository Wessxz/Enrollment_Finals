<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FacultyDashboard
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
        Me.pnlSidebar = New System.Windows.Forms.Panel()
        Me.lblSidebarBrand = New System.Windows.Forms.Label()
        Me.pnlNavDivider = New System.Windows.Forms.Panel()
        Me.btnDashboard = New System.Windows.Forms.Button()
        Me.btnGradeMaster = New System.Windows.Forms.Button()
        Me.btnEncodeGrades = New System.Windows.Forms.Button()
        Me.btnAnnouncements = New System.Windows.Forms.Button()
        Me.btnLogout = New System.Windows.Forms.Button()
        Me.pnlTopBar = New System.Windows.Forms.Panel()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.pnlMain = New System.Windows.Forms.Panel()
        Me.pnlScheduleSection = New System.Windows.Forms.Panel()
        Me.dgvSchedules = New System.Windows.Forms.DataGridView()
        Me.cmbSemesterFilter = New System.Windows.Forms.ComboBox()
        Me.lblScheduleTitle = New System.Windows.Forms.Label()
        Me.pnlOverview = New System.Windows.Forms.Panel()
        Me.lblOverviewTitle = New System.Windows.Forms.Label()
        Me.cardTotalClasses = New System.Windows.Forms.Panel()
        Me.lblTotalClassesValue = New System.Windows.Forms.Label()
        Me.lblTotalClassesLabel = New System.Windows.Forms.Label()
        Me.cardTotalStudents = New System.Windows.Forms.Panel()
        Me.lblTotalStudentsValue = New System.Windows.Forms.Label()
        Me.lblTotalStudentsLabel = New System.Windows.Forms.Label()
        Me.cardPendingGrades = New System.Windows.Forms.Panel()
        Me.lblPendingGradesValue = New System.Windows.Forms.Label()
        Me.lblPendingGradesLabel = New System.Windows.Forms.Label()
        Me.pnlSidebar.SuspendLayout()
        Me.pnlTopBar.SuspendLayout()
        Me.pnlMain.SuspendLayout()
        Me.pnlScheduleSection.SuspendLayout()
        CType(Me.dgvSchedules, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlOverview.SuspendLayout()
        Me.cardTotalClasses.SuspendLayout()
        Me.cardTotalStudents.SuspendLayout()
        Me.cardPendingGrades.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlSidebar
        '
        Me.pnlSidebar.BackColor = System.Drawing.Color.FromArgb(CType(CType(49, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(129, Byte), Integer))
        Me.pnlSidebar.Controls.Add(Me.lblSidebarBrand)
        Me.pnlSidebar.Controls.Add(Me.pnlNavDivider)
        Me.pnlSidebar.Controls.Add(Me.btnDashboard)
        Me.pnlSidebar.Controls.Add(Me.btnGradeMaster)
        Me.pnlSidebar.Controls.Add(Me.btnEncodeGrades)
        Me.pnlSidebar.Controls.Add(Me.btnAnnouncements)
        Me.pnlSidebar.Controls.Add(Me.btnLogout)
        Me.pnlSidebar.Dock = System.Windows.Forms.DockStyle.Left
        Me.pnlSidebar.Location = New System.Drawing.Point(0, 0)
        Me.pnlSidebar.Name = "pnlSidebar"
        Me.pnlSidebar.Size = New System.Drawing.Size(240, 700)
        Me.pnlSidebar.TabIndex = 0
        '
        'lblSidebarBrand
        '
        Me.lblSidebarBrand.AutoSize = True
        Me.lblSidebarBrand.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Bold)
        Me.lblSidebarBrand.ForeColor = System.Drawing.Color.White
        Me.lblSidebarBrand.Location = New System.Drawing.Point(20, 20)
        Me.lblSidebarBrand.Name = "lblSidebarBrand"
        Me.lblSidebarBrand.Size = New System.Drawing.Size(210, 32)
        Me.lblSidebarBrand.TabIndex = 0
        Me.lblSidebarBrand.Text = "FACULTY PORTAL"
        '
        'pnlNavDivider
        '
        Me.pnlNavDivider.BackColor = System.Drawing.Color.FromArgb(CType(CType(99, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.pnlNavDivider.Location = New System.Drawing.Point(15, 60)
        Me.pnlNavDivider.Name = "pnlNavDivider"
        Me.pnlNavDivider.Size = New System.Drawing.Size(210, 2)
        Me.pnlNavDivider.TabIndex = 1
        '
        'btnDashboard
        '
        Me.btnDashboard.BackColor = System.Drawing.Color.FromArgb(CType(CType(67, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(202, Byte), Integer))
        Me.btnDashboard.FlatAppearance.BorderSize = 0
        Me.btnDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDashboard.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.btnDashboard.ForeColor = System.Drawing.Color.White
        Me.btnDashboard.Location = New System.Drawing.Point(12, 80)
        Me.btnDashboard.Name = "btnDashboard"
        Me.btnDashboard.Size = New System.Drawing.Size(216, 45)
        Me.btnDashboard.TabIndex = 2
        Me.btnDashboard.Text = "Dashboard"
        Me.btnDashboard.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnDashboard.UseVisualStyleBackColor = False
        '
        'btnGradeMaster
        '
        Me.btnGradeMaster.FlatAppearance.BorderSize = 0
        Me.btnGradeMaster.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGradeMaster.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.btnGradeMaster.ForeColor = System.Drawing.Color.White
        Me.btnGradeMaster.Location = New System.Drawing.Point(12, 135)
        Me.btnGradeMaster.Name = "btnGradeMaster"
        Me.btnGradeMaster.Size = New System.Drawing.Size(216, 45)
        Me.btnGradeMaster.TabIndex = 3
        Me.btnGradeMaster.Text = "Student Masterlist"
        Me.btnGradeMaster.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnGradeMaster.UseVisualStyleBackColor = True
        '
        'btnEncodeGrades
        '
        Me.btnEncodeGrades.FlatAppearance.BorderSize = 0
        Me.btnEncodeGrades.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEncodeGrades.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.btnEncodeGrades.ForeColor = System.Drawing.Color.White
        Me.btnEncodeGrades.Location = New System.Drawing.Point(12, 190)
        Me.btnEncodeGrades.Name = "btnEncodeGrades"
        Me.btnEncodeGrades.Size = New System.Drawing.Size(216, 45)
        Me.btnEncodeGrades.TabIndex = 4
        Me.btnEncodeGrades.Text = "Encode Grades"
        Me.btnEncodeGrades.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnEncodeGrades.UseVisualStyleBackColor = True
        '
        'btnAnnouncements
        '
        Me.btnAnnouncements.FlatAppearance.BorderSize = 0
        Me.btnAnnouncements.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAnnouncements.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.btnAnnouncements.ForeColor = System.Drawing.Color.White
        Me.btnAnnouncements.Location = New System.Drawing.Point(12, 245)
        Me.btnAnnouncements.Name = "btnAnnouncements"
        Me.btnAnnouncements.Size = New System.Drawing.Size(216, 45)
        Me.btnAnnouncements.TabIndex = 5
        Me.btnAnnouncements.Text = "Announcements"
        Me.btnAnnouncements.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAnnouncements.UseVisualStyleBackColor = True
        '
        'btnLogout
        '
        Me.btnLogout.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(43, Byte), Integer))
        Me.btnLogout.FlatAppearance.BorderSize = 0
        Me.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLogout.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.btnLogout.ForeColor = System.Drawing.Color.White
        Me.btnLogout.Location = New System.Drawing.Point(12, 630)
        Me.btnLogout.Name = "btnLogout"
        Me.btnLogout.Size = New System.Drawing.Size(216, 45)
        Me.btnLogout.TabIndex = 6
        Me.btnLogout.Text = "Logout"
        Me.btnLogout.UseVisualStyleBackColor = False
        '
        'pnlTopBar
        '
        Me.pnlTopBar.BackColor = System.Drawing.Color.FromArgb(CType(CType(67, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(202, Byte), Integer))
        Me.pnlTopBar.Controls.Add(Me.lblTitle)
        Me.pnlTopBar.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlTopBar.Location = New System.Drawing.Point(240, 0)
        Me.pnlTopBar.Name = "pnlTopBar"
        Me.pnlTopBar.Size = New System.Drawing.Size(1060, 60)
        Me.pnlTopBar.TabIndex = 1
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Segoe UI", 16.0!, System.Drawing.FontStyle.Bold)
        Me.lblTitle.ForeColor = System.Drawing.Color.White
        Me.lblTitle.Location = New System.Drawing.Point(20, 15)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(453, 37)
        Me.lblTitle.TabIndex = 0
        Me.lblTitle.Text = "FACULTY DASHBOARD OVERVIEW"
        '
        'pnlMain
        '
        Me.pnlMain.BackColor = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(233, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.pnlMain.Controls.Add(Me.pnlScheduleSection)
        Me.pnlMain.Controls.Add(Me.pnlOverview)
        Me.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlMain.Location = New System.Drawing.Point(240, 60)
        Me.pnlMain.Name = "pnlMain"
        Me.pnlMain.Padding = New System.Windows.Forms.Padding(20)
        Me.pnlMain.Size = New System.Drawing.Size(1060, 640)
        Me.pnlMain.TabIndex = 2
        '
        'pnlScheduleSection
        '
        Me.pnlScheduleSection.BackColor = System.Drawing.Color.White
        Me.pnlScheduleSection.Controls.Add(Me.dgvSchedules)
        Me.pnlScheduleSection.Controls.Add(Me.cmbSemesterFilter)
        Me.pnlScheduleSection.Controls.Add(Me.lblScheduleTitle)
        Me.pnlScheduleSection.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlScheduleSection.Location = New System.Drawing.Point(20, 160)
        Me.pnlScheduleSection.Name = "pnlScheduleSection"
        Me.pnlScheduleSection.Padding = New System.Windows.Forms.Padding(15)
        Me.pnlScheduleSection.Size = New System.Drawing.Size(1020, 460)
        Me.pnlScheduleSection.TabIndex = 1
        '
        'dgvSchedules
        '
        Me.dgvSchedules.AllowUserToAddRows = False
        Me.dgvSchedules.AllowUserToDeleteRows = False
        Me.dgvSchedules.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvSchedules.BackgroundColor = System.Drawing.Color.White
        Me.dgvSchedules.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvSchedules.ColumnHeadersHeight = 35
        Me.dgvSchedules.Location = New System.Drawing.Point(20, 55)
        Me.dgvSchedules.Name = "dgvSchedules"
        Me.dgvSchedules.ReadOnly = True
        Me.dgvSchedules.RowHeadersVisible = False
        Me.dgvSchedules.RowHeadersWidth = 51
        Me.dgvSchedules.RowTemplate.Height = 30
        Me.dgvSchedules.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvSchedules.Size = New System.Drawing.Size(980, 385)
        Me.dgvSchedules.TabIndex = 2
        '
        'cmbSemesterFilter
        '
        Me.cmbSemesterFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbSemesterFilter.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.cmbSemesterFilter.Items.AddRange(New Object() {"1st Semester", "2nd Semester", "Summer"})
        Me.cmbSemesterFilter.Location = New System.Drawing.Point(850, 15)
        Me.cmbSemesterFilter.Name = "cmbSemesterFilter"
        Me.cmbSemesterFilter.Size = New System.Drawing.Size(150, 28)
        Me.cmbSemesterFilter.TabIndex = 1
        '
        'lblScheduleTitle
        '
        Me.lblScheduleTitle.AutoSize = True
        Me.lblScheduleTitle.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Bold)
        Me.lblScheduleTitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(67, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(202, Byte), Integer))
        Me.lblScheduleTitle.Location = New System.Drawing.Point(15, 15)
        Me.lblScheduleTitle.Name = "lblScheduleTitle"
        Me.lblScheduleTitle.Size = New System.Drawing.Size(345, 25)
        Me.lblScheduleTitle.TabIndex = 3
        Me.lblScheduleTitle.Text = "Your Current Teaching Load Schedule"
        '
        'pnlOverview
        '
        Me.pnlOverview.Controls.Add(Me.lblOverviewTitle)
        Me.pnlOverview.Controls.Add(Me.cardTotalClasses)
        Me.pnlOverview.Controls.Add(Me.cardTotalStudents)
        Me.pnlOverview.Controls.Add(Me.cardPendingGrades)
        Me.pnlOverview.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlOverview.Location = New System.Drawing.Point(20, 20)
        Me.pnlOverview.Name = "pnlOverview"
        Me.pnlOverview.Size = New System.Drawing.Size(1020, 140)
        Me.pnlOverview.TabIndex = 0
        '
        'lblOverviewTitle
        '
        Me.lblOverviewTitle.AutoSize = True
        Me.lblOverviewTitle.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.lblOverviewTitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(67, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(202, Byte), Integer))
        Me.lblOverviewTitle.Location = New System.Drawing.Point(5, 5)
        Me.lblOverviewTitle.Name = "lblOverviewTitle"
        Me.lblOverviewTitle.Size = New System.Drawing.Size(86, 23)
        Me.lblOverviewTitle.TabIndex = 0
        Me.lblOverviewTitle.Text = "Overview"
        '
        'cardTotalClasses
        '
        Me.cardTotalClasses.BackColor = System.Drawing.Color.White
        Me.cardTotalClasses.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.cardTotalClasses.Controls.Add(Me.lblTotalClassesValue)
        Me.cardTotalClasses.Controls.Add(Me.lblTotalClassesLabel)
        Me.cardTotalClasses.Location = New System.Drawing.Point(10, 35)
        Me.cardTotalClasses.Name = "cardTotalClasses"
        Me.cardTotalClasses.Size = New System.Drawing.Size(250, 90)
        Me.cardTotalClasses.TabIndex = 0
        '
        'lblTotalClassesValue
        '
        Me.lblTotalClassesValue.AutoSize = True
        Me.lblTotalClassesValue.Font = New System.Drawing.Font("Segoe UI", 24.0!, System.Drawing.FontStyle.Bold)
        Me.lblTotalClassesValue.ForeColor = System.Drawing.Color.FromArgb(CType(CType(67, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(202, Byte), Integer))
        Me.lblTotalClassesValue.Location = New System.Drawing.Point(15, 30)
        Me.lblTotalClassesValue.Name = "lblTotalClassesValue"
        Me.lblTotalClassesValue.Size = New System.Drawing.Size(46, 54)
        Me.lblTotalClassesValue.TabIndex = 0
        Me.lblTotalClassesValue.Text = "0"
        '
        'lblTotalClassesLabel
        '
        Me.lblTotalClassesLabel.AutoSize = True
        Me.lblTotalClassesLabel.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblTotalClassesLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(127, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.lblTotalClassesLabel.Location = New System.Drawing.Point(15, 10)
        Me.lblTotalClassesLabel.Name = "lblTotalClassesLabel"
        Me.lblTotalClassesLabel.Size = New System.Drawing.Size(174, 20)
        Me.lblTotalClassesLabel.TabIndex = 1
        Me.lblTotalClassesLabel.Text = "ACTIVE CLASS SECTIONS"
        '
        'cardTotalStudents
        '
        Me.cardTotalStudents.BackColor = System.Drawing.Color.White
        Me.cardTotalStudents.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.cardTotalStudents.Controls.Add(Me.lblTotalStudentsValue)
        Me.cardTotalStudents.Controls.Add(Me.lblTotalStudentsLabel)
        Me.cardTotalStudents.Location = New System.Drawing.Point(280, 35)
        Me.cardTotalStudents.Name = "cardTotalStudents"
        Me.cardTotalStudents.Size = New System.Drawing.Size(250, 90)
        Me.cardTotalStudents.TabIndex = 1
        '
        'lblTotalStudentsValue
        '
        Me.lblTotalStudentsValue.AutoSize = True
        Me.lblTotalStudentsValue.Font = New System.Drawing.Font("Segoe UI", 24.0!, System.Drawing.FontStyle.Bold)
        Me.lblTotalStudentsValue.ForeColor = System.Drawing.Color.FromArgb(CType(CType(99, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.lblTotalStudentsValue.Location = New System.Drawing.Point(15, 30)
        Me.lblTotalStudentsValue.Name = "lblTotalStudentsValue"
        Me.lblTotalStudentsValue.Size = New System.Drawing.Size(46, 54)
        Me.lblTotalStudentsValue.TabIndex = 0
        Me.lblTotalStudentsValue.Text = "0"
        '
        'lblTotalStudentsLabel
        '
        Me.lblTotalStudentsLabel.AutoSize = True
        Me.lblTotalStudentsLabel.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblTotalStudentsLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(127, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.lblTotalStudentsLabel.Location = New System.Drawing.Point(15, 10)
        Me.lblTotalStudentsLabel.Name = "lblTotalStudentsLabel"
        Me.lblTotalStudentsLabel.Size = New System.Drawing.Size(199, 20)
        Me.lblTotalStudentsLabel.TabIndex = 1
        Me.lblTotalStudentsLabel.Text = "TOTAL HANDLED STUDENTS"
        '
        'cardPendingGrades
        '
        Me.cardPendingGrades.BackColor = System.Drawing.Color.White
        Me.cardPendingGrades.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.cardPendingGrades.Controls.Add(Me.lblPendingGradesValue)
        Me.cardPendingGrades.Controls.Add(Me.lblPendingGradesLabel)
        Me.cardPendingGrades.Location = New System.Drawing.Point(550, 35)
        Me.cardPendingGrades.Name = "cardPendingGrades"
        Me.cardPendingGrades.Size = New System.Drawing.Size(250, 90)
        Me.cardPendingGrades.TabIndex = 2
        '
        'lblPendingGradesValue
        '
        Me.lblPendingGradesValue.AutoSize = True
        Me.lblPendingGradesValue.Font = New System.Drawing.Font("Segoe UI", 24.0!, System.Drawing.FontStyle.Bold)
        Me.lblPendingGradesValue.ForeColor = System.Drawing.Color.FromArgb(CType(CType(124, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(237, Byte), Integer))
        Me.lblPendingGradesValue.Location = New System.Drawing.Point(15, 30)
        Me.lblPendingGradesValue.Name = "lblPendingGradesValue"
        Me.lblPendingGradesValue.Size = New System.Drawing.Size(46, 54)
        Me.lblPendingGradesValue.TabIndex = 0
        Me.lblPendingGradesValue.Text = "0"
        '
        'lblPendingGradesLabel
        '
        Me.lblPendingGradesLabel.AutoSize = True
        Me.lblPendingGradesLabel.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblPendingGradesLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(127, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.lblPendingGradesLabel.Location = New System.Drawing.Point(15, 10)
        Me.lblPendingGradesLabel.Name = "lblPendingGradesLabel"
        Me.lblPendingGradesLabel.Size = New System.Drawing.Size(211, 20)
        Me.lblPendingGradesLabel.TabIndex = 1
        Me.lblPendingGradesLabel.Text = "STUDENTS WITHOUT GRADES"
        '
        'FacultyDashboard
        '
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(233, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1300, 700)
        Me.Controls.Add(Me.pnlMain)
        Me.Controls.Add(Me.pnlTopBar)
        Me.Controls.Add(Me.pnlSidebar)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Name = "FacultyDashboard"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Faculty Dashboard"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.pnlSidebar.ResumeLayout(False)
        Me.pnlSidebar.PerformLayout()
        Me.pnlTopBar.ResumeLayout(False)
        Me.pnlTopBar.PerformLayout()
        Me.pnlMain.ResumeLayout(False)
        Me.pnlScheduleSection.ResumeLayout(False)
        Me.pnlScheduleSection.PerformLayout()
        CType(Me.dgvSchedules, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlOverview.ResumeLayout(False)
        Me.pnlOverview.PerformLayout()
        Me.cardTotalClasses.ResumeLayout(False)
        Me.cardTotalClasses.PerformLayout()
        Me.cardTotalStudents.ResumeLayout(False)
        Me.cardTotalStudents.PerformLayout()
        Me.cardPendingGrades.ResumeLayout(False)
        Me.cardPendingGrades.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnlSidebar As System.Windows.Forms.Panel
    Friend WithEvents lblSidebarBrand As System.Windows.Forms.Label
    Friend WithEvents pnlNavDivider As System.Windows.Forms.Panel
    Friend WithEvents btnDashboard As System.Windows.Forms.Button
    Friend WithEvents btnGradeMaster As System.Windows.Forms.Button
    Friend WithEvents btnEncodeGrades As System.Windows.Forms.Button
    Friend WithEvents btnAnnouncements As System.Windows.Forms.Button
    Friend WithEvents btnLogout As System.Windows.Forms.Button
    Friend WithEvents pnlTopBar As System.Windows.Forms.Panel
    Friend WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents pnlMain As System.Windows.Forms.Panel
    Friend WithEvents pnlOverview As System.Windows.Forms.Panel
    Friend WithEvents lblOverviewTitle As System.Windows.Forms.Label
    Friend WithEvents cardTotalClasses As System.Windows.Forms.Panel
    Friend WithEvents lblTotalClassesValue As System.Windows.Forms.Label
    Friend WithEvents lblTotalClassesLabel As System.Windows.Forms.Label
    Friend WithEvents cardTotalStudents As System.Windows.Forms.Panel
    Friend WithEvents lblTotalStudentsValue As System.Windows.Forms.Label
    Friend WithEvents lblTotalStudentsLabel As System.Windows.Forms.Label
    Friend WithEvents cardPendingGrades As System.Windows.Forms.Panel
    Friend WithEvents lblPendingGradesValue As System.Windows.Forms.Label
    Friend WithEvents lblPendingGradesLabel As System.Windows.Forms.Label
    Friend WithEvents pnlScheduleSection As System.Windows.Forms.Panel
    Friend WithEvents lblScheduleTitle As System.Windows.Forms.Label
    Friend WithEvents cmbSemesterFilter As System.Windows.Forms.ComboBox
    Friend WithEvents dgvSchedules As System.Windows.Forms.DataGridView

End Class
