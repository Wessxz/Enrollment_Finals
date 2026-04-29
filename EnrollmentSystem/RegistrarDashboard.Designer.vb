<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class RegistrarDashboard
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.pnlSidebar = New System.Windows.Forms.Panel()
        Me.btnIrregularEnrollment = New System.Windows.Forms.Button()
        Me.btnDashboard = New System.Windows.Forms.Button()
        Me.btnStudents = New System.Windows.Forms.Button()
        Me.btnCourses = New System.Windows.Forms.Button()
        Me.btnSubjects = New System.Windows.Forms.Button()
        Me.btnSchedule = New System.Windows.Forms.Button()
        Me.btnSections = New System.Windows.Forms.Button()
        Me.btnSectionSchedule = New System.Windows.Forms.Button()
        Me.btnLogout = New System.Windows.Forms.Button()
        Me.pnlTop = New System.Windows.Forms.Panel()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.pnlMain = New System.Windows.Forms.Panel()
        Me.cardStudents = New System.Windows.Forms.Panel()
        Me.lblStudents = New System.Windows.Forms.Label()
        Me.cardEnrolled = New System.Windows.Forms.Panel()
        Me.lblEnrolled = New System.Windows.Forms.Label()
        Me.cardCourses = New System.Windows.Forms.Panel()
        Me.lblCourses = New System.Windows.Forms.Label()
        Me.cardSubjects = New System.Windows.Forms.Panel()
        Me.lblSubjects = New System.Windows.Forms.Label()
        Me.btnAssignschedule = New System.Windows.Forms.Button()
        Me.pnlSidebar.SuspendLayout()
        Me.pnlTop.SuspendLayout()
        Me.pnlMain.SuspendLayout()
        Me.cardStudents.SuspendLayout()
        Me.cardEnrolled.SuspendLayout()
        Me.cardCourses.SuspendLayout()
        Me.cardSubjects.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlSidebar
        '
        Me.pnlSidebar.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.pnlSidebar.Controls.Add(Me.btnAssignschedule)
        Me.pnlSidebar.Controls.Add(Me.btnIrregularEnrollment)
        Me.pnlSidebar.Controls.Add(Me.btnDashboard)
        Me.pnlSidebar.Controls.Add(Me.btnStudents)
        Me.pnlSidebar.Controls.Add(Me.btnCourses)
        Me.pnlSidebar.Controls.Add(Me.btnSubjects)
        Me.pnlSidebar.Controls.Add(Me.btnSchedule)
        Me.pnlSidebar.Controls.Add(Me.btnSections)
        Me.pnlSidebar.Controls.Add(Me.btnSectionSchedule)
        Me.pnlSidebar.Controls.Add(Me.btnLogout)
        Me.pnlSidebar.Dock = System.Windows.Forms.DockStyle.Left
        Me.pnlSidebar.Location = New System.Drawing.Point(0, 0)
        Me.pnlSidebar.Name = "pnlSidebar"
        Me.pnlSidebar.Size = New System.Drawing.Size(220, 700)
        Me.pnlSidebar.TabIndex = 2
        '
        'btnIrregularEnrollment
        '
        Me.btnIrregularEnrollment.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnIrregularEnrollment.Location = New System.Drawing.Point(12, 381)
        Me.btnIrregularEnrollment.Name = "btnIrregularEnrollment"
        Me.btnIrregularEnrollment.Size = New System.Drawing.Size(200, 45)
        Me.btnIrregularEnrollment.TabIndex = 6
        Me.btnIrregularEnrollment.Text = "Irregular Enrollment"
        '
        'btnDashboard
        '
        Me.btnDashboard.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnDashboard.Location = New System.Drawing.Point(10, 40)
        Me.btnDashboard.Name = "btnDashboard"
        Me.btnDashboard.Size = New System.Drawing.Size(200, 45)
        Me.btnDashboard.TabIndex = 0
        Me.btnDashboard.Text = "Dashboard"
        '
        'btnStudents
        '
        Me.btnStudents.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnStudents.Location = New System.Drawing.Point(10, 100)
        Me.btnStudents.Name = "btnStudents"
        Me.btnStudents.Size = New System.Drawing.Size(200, 45)
        Me.btnStudents.TabIndex = 1
        Me.btnStudents.Text = "Students"
        '
        'btnCourses
        '
        Me.btnCourses.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnCourses.Location = New System.Drawing.Point(10, 160)
        Me.btnCourses.Name = "btnCourses"
        Me.btnCourses.Size = New System.Drawing.Size(200, 45)
        Me.btnCourses.TabIndex = 2
        Me.btnCourses.Text = "Courses"
        '
        'btnSubjects
        '
        Me.btnSubjects.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnSubjects.Location = New System.Drawing.Point(10, 215)
        Me.btnSubjects.Name = "btnSubjects"
        Me.btnSubjects.Size = New System.Drawing.Size(200, 45)
        Me.btnSubjects.TabIndex = 9
        Me.btnSubjects.Text = "Subjects"
        '
        'btnSchedule
        '
        Me.btnSchedule.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnSchedule.Location = New System.Drawing.Point(10, 270)
        Me.btnSchedule.Name = "btnSchedule"
        Me.btnSchedule.Size = New System.Drawing.Size(200, 45)
        Me.btnSchedule.TabIndex = 3
        Me.btnSchedule.Text = "Schedule"
        '
        'btnSections
        '
        Me.btnSections.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnSections.Location = New System.Drawing.Point(10, 325)
        Me.btnSections.Name = "btnSections"
        Me.btnSections.Size = New System.Drawing.Size(200, 45)
        Me.btnSections.TabIndex = 4
        Me.btnSections.Text = "Sections"
        '
        'btnSectionSchedule
        '
        Me.btnSectionSchedule.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnSectionSchedule.Location = New System.Drawing.Point(10, 380)
        Me.btnSectionSchedule.Name = "btnSectionSchedule"
        Me.btnSectionSchedule.Size = New System.Drawing.Size(200, 45)
        Me.btnSectionSchedule.TabIndex = 5
        Me.btnSectionSchedule.Text = "Assign Schedules"
        '
        'btnLogout
        '
        Me.btnLogout.BackColor = System.Drawing.Color.Red
        Me.btnLogout.ForeColor = System.Drawing.Color.White
        Me.btnLogout.Location = New System.Drawing.Point(10, 600)
        Me.btnLogout.Name = "btnLogout"
        Me.btnLogout.Size = New System.Drawing.Size(200, 45)
        Me.btnLogout.TabIndex = 5
        Me.btnLogout.Text = "Logout"
        Me.btnLogout.UseVisualStyleBackColor = False
        '
        'pnlTop
        '
        Me.pnlTop.BackColor = System.Drawing.Color.White
        Me.pnlTop.Controls.Add(Me.lblTitle)
        Me.pnlTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlTop.Location = New System.Drawing.Point(220, 0)
        Me.pnlTop.Name = "pnlTop"
        Me.pnlTop.Size = New System.Drawing.Size(1322, 70)
        Me.pnlTop.TabIndex = 1
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold)
        Me.lblTitle.Location = New System.Drawing.Point(368, 29)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(377, 41)
        Me.lblTitle.TabIndex = 0
        Me.lblTitle.Text = "REGISTRAR DASHBOARD"
        '
        'pnlMain
        '
        Me.pnlMain.BackColor = System.Drawing.Color.White
        Me.pnlMain.Controls.Add(Me.cardStudents)
        Me.pnlMain.Controls.Add(Me.cardEnrolled)
        Me.pnlMain.Controls.Add(Me.cardCourses)
        Me.pnlMain.Controls.Add(Me.cardSubjects)
        Me.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlMain.Location = New System.Drawing.Point(220, 70)
        Me.pnlMain.Name = "pnlMain"
        Me.pnlMain.Size = New System.Drawing.Size(1322, 630)
        Me.pnlMain.TabIndex = 0
        '
        'cardStudents
        '
        Me.cardStudents.BackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.cardStudents.Controls.Add(Me.lblStudents)
        Me.cardStudents.Location = New System.Drawing.Point(260, 100)
        Me.cardStudents.Name = "cardStudents"
        Me.cardStudents.Size = New System.Drawing.Size(200, 120)
        Me.cardStudents.TabIndex = 0
        '
        'lblStudents
        '
        Me.lblStudents.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.lblStudents.ForeColor = System.Drawing.Color.White
        Me.lblStudents.Location = New System.Drawing.Point(20, 45)
        Me.lblStudents.Name = "lblStudents"
        Me.lblStudents.Size = New System.Drawing.Size(100, 23)
        Me.lblStudents.TabIndex = 0
        Me.lblStudents.Text = "Students: 0"
        '
        'cardEnrolled
        '
        Me.cardEnrolled.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(113, Byte), Integer))
        Me.cardEnrolled.Controls.Add(Me.lblEnrolled)
        Me.cardEnrolled.Location = New System.Drawing.Point(480, 100)
        Me.cardEnrolled.Name = "cardEnrolled"
        Me.cardEnrolled.Size = New System.Drawing.Size(200, 120)
        Me.cardEnrolled.TabIndex = 1
        '
        'lblEnrolled
        '
        Me.lblEnrolled.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.lblEnrolled.ForeColor = System.Drawing.Color.White
        Me.lblEnrolled.Location = New System.Drawing.Point(20, 45)
        Me.lblEnrolled.Name = "lblEnrolled"
        Me.lblEnrolled.Size = New System.Drawing.Size(100, 23)
        Me.lblEnrolled.TabIndex = 0
        Me.lblEnrolled.Text = "Enrolled: 0"
        '
        'cardCourses
        '
        Me.cardCourses.BackColor = System.Drawing.Color.FromArgb(CType(CType(155, Byte), Integer), CType(CType(89, Byte), Integer), CType(CType(182, Byte), Integer))
        Me.cardCourses.Controls.Add(Me.lblCourses)
        Me.cardCourses.Location = New System.Drawing.Point(700, 100)
        Me.cardCourses.Name = "cardCourses"
        Me.cardCourses.Size = New System.Drawing.Size(200, 120)
        Me.cardCourses.TabIndex = 2
        '
        'lblCourses
        '
        Me.lblCourses.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.lblCourses.ForeColor = System.Drawing.Color.White
        Me.lblCourses.Location = New System.Drawing.Point(20, 45)
        Me.lblCourses.Name = "lblCourses"
        Me.lblCourses.Size = New System.Drawing.Size(100, 23)
        Me.lblCourses.TabIndex = 0
        Me.lblCourses.Text = "Courses: 0"
        '
        'cardSubjects
        '
        Me.cardSubjects.BackColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.cardSubjects.Controls.Add(Me.lblSubjects)
        Me.cardSubjects.Location = New System.Drawing.Point(920, 100)
        Me.cardSubjects.Name = "cardSubjects"
        Me.cardSubjects.Size = New System.Drawing.Size(200, 120)
        Me.cardSubjects.TabIndex = 3
        '
        'lblSubjects
        '
        Me.lblSubjects.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.lblSubjects.ForeColor = System.Drawing.Color.White
        Me.lblSubjects.Location = New System.Drawing.Point(20, 45)
        Me.lblSubjects.Name = "lblSubjects"
        Me.lblSubjects.Size = New System.Drawing.Size(100, 23)
        Me.lblSubjects.TabIndex = 0
        Me.lblSubjects.Text = "Subjects: 0"
        '
        'btnAssignschedule
        '
        Me.btnAssignschedule.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnAssignschedule.Location = New System.Drawing.Point(10, 432)
        Me.btnAssignschedule.Name = "btnAssignschedule"
        Me.btnAssignschedule.Size = New System.Drawing.Size(200, 45)
        Me.btnAssignschedule.TabIndex = 10
        Me.btnAssignschedule.Text = "Assign Schedule"
        '
        'RegistrarDashboard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1542, 700)
        Me.Controls.Add(Me.pnlMain)
        Me.Controls.Add(Me.pnlTop)
        Me.Controls.Add(Me.pnlSidebar)
        Me.Name = "RegistrarDashboard"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Registrar Dashboard"
        Me.pnlSidebar.ResumeLayout(False)
        Me.pnlTop.ResumeLayout(False)
        Me.pnlTop.PerformLayout()
        Me.pnlMain.ResumeLayout(False)
        Me.cardStudents.ResumeLayout(False)
        Me.cardEnrolled.ResumeLayout(False)
        Me.cardCourses.ResumeLayout(False)
        Me.cardSubjects.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnlSidebar As System.Windows.Forms.Panel
    Friend WithEvents pnlTop As System.Windows.Forms.Panel
    Friend WithEvents pnlMain As System.Windows.Forms.Panel

    Friend WithEvents btnDashboard As System.Windows.Forms.Button
    Friend WithEvents btnStudents As System.Windows.Forms.Button
    Friend WithEvents btnCourses As System.Windows.Forms.Button
    Friend WithEvents btnSubjects As System.Windows.Forms.Button
    Friend WithEvents btnSchedule As System.Windows.Forms.Button
    Friend WithEvents btnSections As System.Windows.Forms.Button
    Friend WithEvents btnSectionSchedule As System.Windows.Forms.Button
    Friend WithEvents btnLogout As System.Windows.Forms.Button

    Friend WithEvents lblTitle As System.Windows.Forms.Label

    Friend WithEvents cardStudents As System.Windows.Forms.Panel
    Friend WithEvents cardEnrolled As System.Windows.Forms.Panel
    Friend WithEvents cardCourses As System.Windows.Forms.Panel
    Friend WithEvents cardSubjects As System.Windows.Forms.Panel

    Friend WithEvents lblStudents As System.Windows.Forms.Label
    Friend WithEvents lblEnrolled As System.Windows.Forms.Label
    Friend WithEvents lblCourses As System.Windows.Forms.Label
    Friend WithEvents lblSubjects As System.Windows.Forms.Label
    Friend WithEvents btnIrregularEnrollment As Button
    Friend WithEvents btnAssignschedule As Button
End Class