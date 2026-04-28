<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class IrregularEnrollmentForm
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
        Me.lblSubtitle = New System.Windows.Forms.Label()
        Me.pnlLeft = New System.Windows.Forms.Panel()
        Me.lblStudentID = New System.Windows.Forms.Label()
        Me.txtStudentID = New System.Windows.Forms.TextBox()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.lblName = New System.Windows.Forms.Label()
        Me.txtStudentName = New System.Windows.Forms.TextBox()
        Me.lblCourse = New System.Windows.Forms.Label()
        Me.txtCourse = New System.Windows.Forms.TextBox()
        Me.lblYearLevel = New System.Windows.Forms.Label()
        Me.txtYearLevel = New System.Windows.Forms.TextBox()
        Me.lblSemester = New System.Windows.Forms.Label()
        Me.cmbSemester = New System.Windows.Forms.ComboBox()
        Me.lblAcadYear = New System.Windows.Forms.Label()
        Me.txtAcadYear = New System.Windows.Forms.TextBox()
        Me.lblTotalUnits = New System.Windows.Forms.Label()
        Me.btnEnroll = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.lblAvailable = New System.Windows.Forms.Label()
        Me.dgvAvailable = New System.Windows.Forms.DataGridView()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnRemove = New System.Windows.Forms.Button()
        Me.lblSelected = New System.Windows.Forms.Label()
        Me.dgvSelected = New System.Windows.Forms.DataGridView()
        Me.sel_schedule_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.sel_subject_code = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.sel_subject_name = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.sel_units = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.sel_instructor = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.sel_day = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.sel_start = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.sel_end = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.sel_room = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.pnlTop.SuspendLayout()
        Me.pnlLeft.SuspendLayout()
        CType(Me.dgvAvailable, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvSelected, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnlTop
        '
        Me.pnlTop.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.pnlTop.Controls.Add(Me.lblTitle)
        Me.pnlTop.Controls.Add(Me.lblSubtitle)
        Me.pnlTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlTop.Location = New System.Drawing.Point(0, 0)
        Me.pnlTop.Name = "pnlTop"
        Me.pnlTop.Size = New System.Drawing.Size(1100, 60)
        Me.pnlTop.TabIndex = 0
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Segoe UI", 16.0!, System.Drawing.FontStyle.Bold)
        Me.lblTitle.ForeColor = System.Drawing.Color.White
        Me.lblTitle.Location = New System.Drawing.Point(20, 10)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(352, 37)
        Me.lblTitle.TabIndex = 0
        Me.lblTitle.Text = "IRREGULAR ENROLLMENT"
        '
        'lblSubtitle
        '
        Me.lblSubtitle.AutoSize = True
        Me.lblSubtitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lblSubtitle.Location = New System.Drawing.Point(22, 40)
        Me.lblSubtitle.Name = "lblSubtitle"
        Me.lblSubtitle.Size = New System.Drawing.Size(314, 20)
        Me.lblSubtitle.TabIndex = 1
        Me.lblSubtitle.Text = "Manual subject selection for irregular students"
        '
        'pnlLeft
        '
        Me.pnlLeft.BackColor = System.Drawing.Color.White
        Me.pnlLeft.Controls.Add(Me.lblStudentID)
        Me.pnlLeft.Controls.Add(Me.txtStudentID)
        Me.pnlLeft.Controls.Add(Me.btnSearch)
        Me.pnlLeft.Controls.Add(Me.lblName)
        Me.pnlLeft.Controls.Add(Me.txtStudentName)
        Me.pnlLeft.Controls.Add(Me.lblCourse)
        Me.pnlLeft.Controls.Add(Me.txtCourse)
        Me.pnlLeft.Controls.Add(Me.lblYearLevel)
        Me.pnlLeft.Controls.Add(Me.txtYearLevel)
        Me.pnlLeft.Controls.Add(Me.lblSemester)
        Me.pnlLeft.Controls.Add(Me.cmbSemester)
        Me.pnlLeft.Controls.Add(Me.lblAcadYear)
        Me.pnlLeft.Controls.Add(Me.txtAcadYear)
        Me.pnlLeft.Controls.Add(Me.lblTotalUnits)
        Me.pnlLeft.Controls.Add(Me.btnEnroll)
        Me.pnlLeft.Controls.Add(Me.btnClear)
        Me.pnlLeft.Location = New System.Drawing.Point(10, 70)
        Me.pnlLeft.Name = "pnlLeft"
        Me.pnlLeft.Size = New System.Drawing.Size(280, 590)
        Me.pnlLeft.TabIndex = 1
        '
        'lblStudentID
        '
        Me.lblStudentID.AutoSize = True
        Me.lblStudentID.Location = New System.Drawing.Point(15, 15)
        Me.lblStudentID.Name = "lblStudentID"
        Me.lblStudentID.Size = New System.Drawing.Size(89, 20)
        Me.lblStudentID.TabIndex = 0
        Me.lblStudentID.Text = "Student ID *"
        '
        'txtStudentID
        '
        Me.txtStudentID.Location = New System.Drawing.Point(15, 35)
        Me.txtStudentID.Name = "txtStudentID"
        Me.txtStudentID.Size = New System.Drawing.Size(245, 27)
        Me.txtStudentID.TabIndex = 1
        '
        'btnSearch
        '
        Me.btnSearch.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.btnSearch.FlatAppearance.BorderSize = 0
        Me.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSearch.ForeColor = System.Drawing.Color.White
        Me.btnSearch.Location = New System.Drawing.Point(15, 68)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(245, 32)
        Me.btnSearch.TabIndex = 2
        Me.btnSearch.Text = "Search Student"
        Me.btnSearch.UseVisualStyleBackColor = False
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Location = New System.Drawing.Point(15, 115)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(76, 20)
        Me.lblName.TabIndex = 3
        Me.lblName.Text = "Full Name"
        '
        'txtStudentName
        '
        Me.txtStudentName.BackColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.txtStudentName.Location = New System.Drawing.Point(15, 135)
        Me.txtStudentName.Name = "txtStudentName"
        Me.txtStudentName.ReadOnly = True
        Me.txtStudentName.Size = New System.Drawing.Size(245, 27)
        Me.txtStudentName.TabIndex = 4
        '
        'lblCourse
        '
        Me.lblCourse.AutoSize = True
        Me.lblCourse.Location = New System.Drawing.Point(15, 175)
        Me.lblCourse.Name = "lblCourse"
        Me.lblCourse.Size = New System.Drawing.Size(54, 20)
        Me.lblCourse.TabIndex = 5
        Me.lblCourse.Text = "Course"
        '
        'txtCourse
        '
        Me.txtCourse.BackColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.txtCourse.Location = New System.Drawing.Point(15, 195)
        Me.txtCourse.Name = "txtCourse"
        Me.txtCourse.ReadOnly = True
        Me.txtCourse.Size = New System.Drawing.Size(245, 27)
        Me.txtCourse.TabIndex = 6
        '
        'lblYearLevel
        '
        Me.lblYearLevel.AutoSize = True
        Me.lblYearLevel.Location = New System.Drawing.Point(15, 235)
        Me.lblYearLevel.Name = "lblYearLevel"
        Me.lblYearLevel.Size = New System.Drawing.Size(75, 20)
        Me.lblYearLevel.TabIndex = 7
        Me.lblYearLevel.Text = "Year Level"
        '
        'txtYearLevel
        '
        Me.txtYearLevel.BackColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.txtYearLevel.Location = New System.Drawing.Point(15, 255)
        Me.txtYearLevel.Name = "txtYearLevel"
        Me.txtYearLevel.ReadOnly = True
        Me.txtYearLevel.Size = New System.Drawing.Size(245, 27)
        Me.txtYearLevel.TabIndex = 8
        '
        'lblSemester
        '
        Me.lblSemester.AutoSize = True
        Me.lblSemester.Location = New System.Drawing.Point(15, 295)
        Me.lblSemester.Name = "lblSemester"
        Me.lblSemester.Size = New System.Drawing.Size(80, 20)
        Me.lblSemester.TabIndex = 9
        Me.lblSemester.Text = "Semester *"
        '
        'cmbSemester
        '
        Me.cmbSemester.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbSemester.Items.AddRange(New Object() {"1st Sem", "2nd Sem", "Summer"})
        Me.cmbSemester.Location = New System.Drawing.Point(15, 315)
        Me.cmbSemester.Name = "cmbSemester"
        Me.cmbSemester.Size = New System.Drawing.Size(245, 28)
        Me.cmbSemester.TabIndex = 10
        '
        'lblAcadYear
        '
        Me.lblAcadYear.AutoSize = True
        Me.lblAcadYear.Location = New System.Drawing.Point(15, 355)
        Me.lblAcadYear.Name = "lblAcadYear"
        Me.lblAcadYear.Size = New System.Drawing.Size(96, 20)
        Me.lblAcadYear.TabIndex = 11
        Me.lblAcadYear.Text = "School Year *"
        '
        'txtAcadYear
        '
        Me.txtAcadYear.Location = New System.Drawing.Point(15, 375)
        Me.txtAcadYear.Name = "txtAcadYear"
        Me.txtAcadYear.Size = New System.Drawing.Size(245, 27)
        Me.txtAcadYear.TabIndex = 12
        Me.txtAcadYear.Text = "2024-2025"
        '
        'lblTotalUnits
        '
        Me.lblTotalUnits.AutoSize = True
        Me.lblTotalUnits.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.lblTotalUnits.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.lblTotalUnits.Location = New System.Drawing.Point(15, 420)
        Me.lblTotalUnits.Name = "lblTotalUnits"
        Me.lblTotalUnits.Size = New System.Drawing.Size(115, 23)
        Me.lblTotalUnits.TabIndex = 13
        Me.lblTotalUnits.Text = "Total Units: 0"
        '
        'btnEnroll
        '
        Me.btnEnroll.BackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(163, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.btnEnroll.FlatAppearance.BorderSize = 0
        Me.btnEnroll.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEnroll.ForeColor = System.Drawing.Color.White
        Me.btnEnroll.Location = New System.Drawing.Point(15, 450)
        Me.btnEnroll.Name = "btnEnroll"
        Me.btnEnroll.Size = New System.Drawing.Size(245, 32)
        Me.btnEnroll.TabIndex = 14
        Me.btnEnroll.Text = "Enroll Student"
        Me.btnEnroll.UseVisualStyleBackColor = False
        '
        'btnClear
        '
        Me.btnClear.BackColor = System.Drawing.Color.FromArgb(CType(CType(107, Byte), Integer), CType(CType(114, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnClear.FlatAppearance.BorderSize = 0
        Me.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClear.ForeColor = System.Drawing.Color.White
        Me.btnClear.Location = New System.Drawing.Point(15, 492)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(245, 32)
        Me.btnClear.TabIndex = 15
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = False
        '
        'lblAvailable
        '
        Me.lblAvailable.AutoSize = True
        Me.lblAvailable.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblAvailable.Location = New System.Drawing.Point(300, 72)
        Me.lblAvailable.Name = "lblAvailable"
        Me.lblAvailable.Size = New System.Drawing.Size(146, 20)
        Me.lblAvailable.TabIndex = 2
        Me.lblAvailable.Text = "Available Schedules"
        '
        'dgvAvailable
        '
        Me.dgvAvailable.AllowUserToAddRows = False
        Me.dgvAvailable.AllowUserToDeleteRows = False
        Me.dgvAvailable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvAvailable.BackgroundColor = System.Drawing.Color.White
        Me.dgvAvailable.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvAvailable.ColumnHeadersHeight = 35
        Me.dgvAvailable.Location = New System.Drawing.Point(300, 92)
        Me.dgvAvailable.Name = "dgvAvailable"
        Me.dgvAvailable.ReadOnly = True
        Me.dgvAvailable.RowHeadersVisible = False
        Me.dgvAvailable.RowHeadersWidth = 51
        Me.dgvAvailable.RowTemplate.Height = 30
        Me.dgvAvailable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvAvailable.Size = New System.Drawing.Size(780, 265)
        Me.dgvAvailable.TabIndex = 3
        '
        'btnAdd
        '
        Me.btnAdd.BackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(163, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.btnAdd.FlatAppearance.BorderSize = 0
        Me.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAdd.ForeColor = System.Drawing.Color.White
        Me.btnAdd.Location = New System.Drawing.Point(300, 365)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(120, 32)
        Me.btnAdd.TabIndex = 4
        Me.btnAdd.Text = "Add to List"
        Me.btnAdd.UseVisualStyleBackColor = False
        '
        'btnRemove
        '
        Me.btnRemove.BackColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.btnRemove.FlatAppearance.BorderSize = 0
        Me.btnRemove.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRemove.ForeColor = System.Drawing.Color.White
        Me.btnRemove.Location = New System.Drawing.Point(430, 365)
        Me.btnRemove.Name = "btnRemove"
        Me.btnRemove.Size = New System.Drawing.Size(120, 32)
        Me.btnRemove.TabIndex = 5
        Me.btnRemove.Text = "Remove"
        Me.btnRemove.UseVisualStyleBackColor = False
        '
        'lblSelected
        '
        Me.lblSelected.AutoSize = True
        Me.lblSelected.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblSelected.Location = New System.Drawing.Point(300, 410)
        Me.lblSelected.Name = "lblSelected"
        Me.lblSelected.Size = New System.Drawing.Size(129, 20)
        Me.lblSelected.TabIndex = 6
        Me.lblSelected.Text = "Selected Subjects"
        '
        'dgvSelected
        '
        Me.dgvSelected.AllowUserToAddRows = False
        Me.dgvSelected.AllowUserToDeleteRows = False
        Me.dgvSelected.BackgroundColor = System.Drawing.Color.White
        Me.dgvSelected.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvSelected.ColumnHeadersHeight = 35
        Me.dgvSelected.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.sel_schedule_id, Me.sel_subject_code, Me.sel_subject_name, Me.sel_units, Me.sel_instructor, Me.sel_day, Me.sel_start, Me.sel_end, Me.sel_room})
        Me.dgvSelected.Location = New System.Drawing.Point(300, 430)
        Me.dgvSelected.Name = "dgvSelected"
        Me.dgvSelected.ReadOnly = True
        Me.dgvSelected.RowHeadersVisible = False
        Me.dgvSelected.RowHeadersWidth = 51
        Me.dgvSelected.RowTemplate.Height = 30
        Me.dgvSelected.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvSelected.Size = New System.Drawing.Size(780, 225)
        Me.dgvSelected.TabIndex = 7
        '
        'sel_schedule_id
        '
        Me.sel_schedule_id.HeaderText = "ID"
        Me.sel_schedule_id.MinimumWidth = 6
        Me.sel_schedule_id.Name = "sel_schedule_id"
        Me.sel_schedule_id.ReadOnly = True
        Me.sel_schedule_id.Visible = False
        Me.sel_schedule_id.Width = 125
        '
        'sel_subject_code
        '
        Me.sel_subject_code.HeaderText = "Code"
        Me.sel_subject_code.MinimumWidth = 6
        Me.sel_subject_code.Name = "sel_subject_code"
        Me.sel_subject_code.ReadOnly = True
        Me.sel_subject_code.Width = 80
        '
        'sel_subject_name
        '
        Me.sel_subject_name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.sel_subject_name.HeaderText = "Subject"
        Me.sel_subject_name.MinimumWidth = 6
        Me.sel_subject_name.Name = "sel_subject_name"
        Me.sel_subject_name.ReadOnly = True
        '
        'sel_units
        '
        Me.sel_units.HeaderText = "Units"
        Me.sel_units.MinimumWidth = 6
        Me.sel_units.Name = "sel_units"
        Me.sel_units.ReadOnly = True
        Me.sel_units.Width = 50
        '
        'sel_instructor
        '
        Me.sel_instructor.HeaderText = "Instructor"
        Me.sel_instructor.MinimumWidth = 6
        Me.sel_instructor.Name = "sel_instructor"
        Me.sel_instructor.ReadOnly = True
        Me.sel_instructor.Width = 110
        '
        'sel_day
        '
        Me.sel_day.HeaderText = "Day"
        Me.sel_day.MinimumWidth = 6
        Me.sel_day.Name = "sel_day"
        Me.sel_day.ReadOnly = True
        Me.sel_day.Width = 80
        '
        'sel_start
        '
        Me.sel_start.HeaderText = "Start"
        Me.sel_start.MinimumWidth = 6
        Me.sel_start.Name = "sel_start"
        Me.sel_start.ReadOnly = True
        Me.sel_start.Width = 80
        '
        'sel_end
        '
        Me.sel_end.HeaderText = "End"
        Me.sel_end.MinimumWidth = 6
        Me.sel_end.Name = "sel_end"
        Me.sel_end.ReadOnly = True
        Me.sel_end.Width = 80
        '
        'sel_room
        '
        Me.sel_room.HeaderText = "Room"
        Me.sel_room.MinimumWidth = 6
        Me.sel_room.Name = "sel_room"
        Me.sel_room.ReadOnly = True
        Me.sel_room.Width = 70
        '
        'IrregularEnrollmentForm
        '
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1100, 680)
        Me.Controls.Add(Me.pnlTop)
        Me.Controls.Add(Me.pnlLeft)
        Me.Controls.Add(Me.lblAvailable)
        Me.Controls.Add(Me.dgvAvailable)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.btnRemove)
        Me.Controls.Add(Me.lblSelected)
        Me.Controls.Add(Me.dgvSelected)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Name = "IrregularEnrollmentForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Irregular Enrollment"
        Me.pnlTop.ResumeLayout(False)
        Me.pnlTop.PerformLayout()
        Me.pnlLeft.ResumeLayout(False)
        Me.pnlLeft.PerformLayout()
        CType(Me.dgvAvailable, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvSelected, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents pnlTop          As System.Windows.Forms.Panel
    Friend WithEvents lblTitle         As System.Windows.Forms.Label
    Friend WithEvents lblSubtitle      As System.Windows.Forms.Label
    Friend WithEvents pnlLeft          As System.Windows.Forms.Panel
    Friend WithEvents lblStudentID     As System.Windows.Forms.Label
    Friend WithEvents txtStudentID     As System.Windows.Forms.TextBox
    Friend WithEvents btnSearch        As System.Windows.Forms.Button
    Friend WithEvents lblName          As System.Windows.Forms.Label
    Friend WithEvents txtStudentName   As System.Windows.Forms.TextBox
    Friend WithEvents lblCourse        As System.Windows.Forms.Label
    Friend WithEvents txtCourse        As System.Windows.Forms.TextBox
    Friend WithEvents lblYearLevel     As System.Windows.Forms.Label
    Friend WithEvents txtYearLevel     As System.Windows.Forms.TextBox
    Friend WithEvents lblSemester      As System.Windows.Forms.Label
    Friend WithEvents cmbSemester      As System.Windows.Forms.ComboBox
    Friend WithEvents lblAcadYear      As System.Windows.Forms.Label
    Friend WithEvents txtAcadYear      As System.Windows.Forms.TextBox
    Friend WithEvents lblTotalUnits    As System.Windows.Forms.Label
    Friend WithEvents btnEnroll        As System.Windows.Forms.Button
    Friend WithEvents btnClear         As System.Windows.Forms.Button
    Friend WithEvents lblAvailable     As System.Windows.Forms.Label
    Friend WithEvents dgvAvailable     As System.Windows.Forms.DataGridView
    Friend WithEvents btnAdd           As System.Windows.Forms.Button
    Friend WithEvents btnRemove        As System.Windows.Forms.Button
    Friend WithEvents lblSelected      As System.Windows.Forms.Label
    Friend WithEvents dgvSelected      As System.Windows.Forms.DataGridView
    Friend WithEvents sel_schedule_id  As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents sel_subject_code As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents sel_subject_name As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents sel_units        As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents sel_instructor   As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents sel_day          As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents sel_start        As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents sel_end          As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents sel_room         As System.Windows.Forms.DataGridViewTextBoxColumn

End Class
