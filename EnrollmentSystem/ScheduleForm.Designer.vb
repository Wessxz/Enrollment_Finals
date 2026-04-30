<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ScheduleForm
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
        Me.pnlTop = New System.Windows.Forms.Panel()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.lblSection = New System.Windows.Forms.Label()
        Me.pnlFilter = New System.Windows.Forms.Panel()
        Me.lblSemFilter = New System.Windows.Forms.Label()
        Me.cmbSemFilter = New System.Windows.Forms.ComboBox()
        Me.lblAYFilter = New System.Windows.Forms.Label()
        Me.cmbAYFilter = New System.Windows.Forms.ComboBox()
        Me.btnFilter = New System.Windows.Forms.Button()
        Me.pnlForm = New System.Windows.Forms.Panel()
        Me.lblSubject = New System.Windows.Forms.Label()
        Me.cmbSubject = New System.Windows.Forms.ComboBox()
        Me.lblInstructor = New System.Windows.Forms.Label()
        Me.cmbInstructor = New System.Windows.Forms.ComboBox()
        Me.lblDay = New System.Windows.Forms.Label()
        Me.cmbDay = New System.Windows.Forms.ComboBox()
        Me.lblStart = New System.Windows.Forms.Label()
        Me.dtpStart = New System.Windows.Forms.DateTimePicker()
        Me.lblEnd = New System.Windows.Forms.Label()
        Me.dtpEnd = New System.Windows.Forms.DateTimePicker()
        Me.lblRoom = New System.Windows.Forms.Label()
        Me.txtRoom = New System.Windows.Forms.TextBox()
        Me.lblSemester = New System.Windows.Forms.Label()
        Me.cmbSemester = New System.Windows.Forms.ComboBox()
        Me.lblAcadYear = New System.Windows.Forms.Label()
        Me.txtAcadYear = New System.Windows.Forms.TextBox()
        Me.lblMaxSlots = New System.Windows.Forms.Label()
        Me.txtMaxSlots = New System.Windows.Forms.TextBox()
        Me.pnlButtons = New System.Windows.Forms.Panel()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.dgvSchedule = New System.Windows.Forms.DataGridView()
        Me.pnlTop.SuspendLayout()
        Me.pnlFilter.SuspendLayout()
        Me.pnlForm.SuspendLayout()
        Me.pnlButtons.SuspendLayout()
        CType(Me.dgvSchedule, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnlTop
        '
        Me.pnlTop.BackColor = System.Drawing.Color.FromArgb(CType(CType(67, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(202, Byte), Integer))
        Me.pnlTop.Controls.Add(Me.lblTitle)
        Me.pnlTop.Controls.Add(Me.lblSection)
        Me.pnlTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlTop.Location = New System.Drawing.Point(0, 0)
        Me.pnlTop.Name = "pnlTop"
        Me.pnlTop.Padding = New System.Windows.Forms.Padding(20, 0, 0, 0)
        Me.pnlTop.Size = New System.Drawing.Size(1430, 65)
        Me.pnlTop.TabIndex = 0
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold)
        Me.lblTitle.ForeColor = System.Drawing.Color.White
        Me.lblTitle.Location = New System.Drawing.Point(20, 12)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(395, 41)
        Me.lblTitle.TabIndex = 0
        Me.lblTitle.Text = "SCHEDULE MANAGEMENT"
        '
        'lblSection
        '
        Me.lblSection.AutoSize = True
        Me.lblSection.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblSection.ForeColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lblSection.Location = New System.Drawing.Point(22, 44)
        Me.lblSection.Name = "lblSection"
        Me.lblSection.Size = New System.Drawing.Size(127, 20)
        Me.lblSection.TabIndex = 1
        Me.lblSection.Text = "Total Schedules: 0"
        '
        'pnlFilter
        '
        Me.pnlFilter.BackColor = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(233, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.pnlFilter.Controls.Add(Me.lblSemFilter)
        Me.pnlFilter.Controls.Add(Me.cmbSemFilter)
        Me.pnlFilter.Controls.Add(Me.lblAYFilter)
        Me.pnlFilter.Controls.Add(Me.cmbAYFilter)
        Me.pnlFilter.Controls.Add(Me.btnFilter)
        Me.pnlFilter.Location = New System.Drawing.Point(10, 75)
        Me.pnlFilter.Name = "pnlFilter"
        Me.pnlFilter.Size = New System.Drawing.Size(1331, 50)
        Me.pnlFilter.TabIndex = 1
        '
        'lblSemFilter
        '
        Me.lblSemFilter.AutoSize = True
        Me.lblSemFilter.Location = New System.Drawing.Point(10, 15)
        Me.lblSemFilter.Name = "lblSemFilter"
        Me.lblSemFilter.Size = New System.Drawing.Size(73, 20)
        Me.lblSemFilter.TabIndex = 0
        Me.lblSemFilter.Text = "Semester:"
        '
        'cmbSemFilter
        '
        Me.cmbSemFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbSemFilter.Items.AddRange(New Object() {"All", "1st Sem", "2nd Sem", "Summer"})
        Me.cmbSemFilter.Location = New System.Drawing.Point(75, 12)
        Me.cmbSemFilter.Name = "cmbSemFilter"
        Me.cmbSemFilter.Size = New System.Drawing.Size(130, 28)
        Me.cmbSemFilter.TabIndex = 1
        '
        'lblAYFilter
        '
        Me.lblAYFilter.AutoSize = True
        Me.lblAYFilter.Location = New System.Drawing.Point(220, 15)
        Me.lblAYFilter.Name = "lblAYFilter"
        Me.lblAYFilter.Size = New System.Drawing.Size(89, 20)
        Me.lblAYFilter.TabIndex = 2
        Me.lblAYFilter.Text = "School Year:"
        '
        'cmbAYFilter
        '
        Me.cmbAYFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbAYFilter.Location = New System.Drawing.Point(305, 12)
        Me.cmbAYFilter.Name = "cmbAYFilter"
        Me.cmbAYFilter.Size = New System.Drawing.Size(130, 28)
        Me.cmbAYFilter.TabIndex = 3
        '
        'btnFilter
        '
        Me.btnFilter.BackColor = System.Drawing.Color.FromArgb(CType(CType(67, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(202, Byte), Integer))
        Me.btnFilter.FlatAppearance.BorderSize = 0
        Me.btnFilter.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnFilter.ForeColor = System.Drawing.Color.White
        Me.btnFilter.Location = New System.Drawing.Point(450, 11)
        Me.btnFilter.Name = "btnFilter"
        Me.btnFilter.Size = New System.Drawing.Size(80, 26)
        Me.btnFilter.TabIndex = 4
        Me.btnFilter.Text = "Filter"
        Me.btnFilter.UseVisualStyleBackColor = False
        '
        'pnlForm
        '
        Me.pnlForm.BackColor = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(233, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.pnlForm.Controls.Add(Me.lblSubject)
        Me.pnlForm.Controls.Add(Me.cmbSubject)
        Me.pnlForm.Controls.Add(Me.lblInstructor)
        Me.pnlForm.Controls.Add(Me.cmbInstructor)
        Me.pnlForm.Controls.Add(Me.lblDay)
        Me.pnlForm.Controls.Add(Me.cmbDay)
        Me.pnlForm.Controls.Add(Me.lblStart)
        Me.pnlForm.Controls.Add(Me.dtpStart)
        Me.pnlForm.Controls.Add(Me.lblEnd)
        Me.pnlForm.Controls.Add(Me.dtpEnd)
        Me.pnlForm.Controls.Add(Me.lblRoom)
        Me.pnlForm.Controls.Add(Me.txtRoom)
        Me.pnlForm.Controls.Add(Me.lblSemester)
        Me.pnlForm.Controls.Add(Me.cmbSemester)
        Me.pnlForm.Controls.Add(Me.lblAcadYear)
        Me.pnlForm.Controls.Add(Me.txtAcadYear)
        Me.pnlForm.Controls.Add(Me.lblMaxSlots)
        Me.pnlForm.Controls.Add(Me.txtMaxSlots)
        Me.pnlForm.Location = New System.Drawing.Point(10, 135)
        Me.pnlForm.Name = "pnlForm"
        Me.pnlForm.Size = New System.Drawing.Size(1331, 120)
        Me.pnlForm.TabIndex = 2
        '
        'lblSubject
        '
        Me.lblSubject.AutoSize = True
        Me.lblSubject.Location = New System.Drawing.Point(10, 10)
        Me.lblSubject.Name = "lblSubject"
        Me.lblSubject.Size = New System.Drawing.Size(68, 20)
        Me.lblSubject.TabIndex = 0
        Me.lblSubject.Text = "Subject *"
        '
        'cmbSubject
        '
        Me.cmbSubject.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbSubject.Location = New System.Drawing.Point(10, 30)
        Me.cmbSubject.Name = "cmbSubject"
        Me.cmbSubject.Size = New System.Drawing.Size(210, 28)
        Me.cmbSubject.TabIndex = 1
        '
        'lblInstructor
        '
        Me.lblInstructor.AutoSize = True
        Me.lblInstructor.Location = New System.Drawing.Point(235, 10)
        Me.lblInstructor.Name = "lblInstructor"
        Me.lblInstructor.Size = New System.Drawing.Size(81, 20)
        Me.lblInstructor.TabIndex = 2
        Me.lblInstructor.Text = "Instructor *"
        '
        'cmbInstructor
        '
        Me.cmbInstructor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbInstructor.Location = New System.Drawing.Point(235, 30)
        Me.cmbInstructor.Name = "cmbInstructor"
        Me.cmbInstructor.Size = New System.Drawing.Size(180, 28)
        Me.cmbInstructor.TabIndex = 3
        '
        'lblDay
        '
        Me.lblDay.AutoSize = True
        Me.lblDay.Location = New System.Drawing.Point(430, 10)
        Me.lblDay.Name = "lblDay"
        Me.lblDay.Size = New System.Drawing.Size(45, 20)
        Me.lblDay.TabIndex = 4
        Me.lblDay.Text = "Day *"
        '
        'cmbDay
        '
        Me.cmbDay.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbDay.Items.AddRange(New Object() {"Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday"})
        Me.cmbDay.Location = New System.Drawing.Point(430, 30)
        Me.cmbDay.Name = "cmbDay"
        Me.cmbDay.Size = New System.Drawing.Size(120, 28)
        Me.cmbDay.TabIndex = 5
        '
        'lblStart
        '
        Me.lblStart.AutoSize = True
        Me.lblStart.Location = New System.Drawing.Point(565, 10)
        Me.lblStart.Name = "lblStart"
        Me.lblStart.Size = New System.Drawing.Size(87, 20)
        Me.lblStart.TabIndex = 6
        Me.lblStart.Text = "Start Time *"
        '
        'dtpStart
        '
        Me.dtpStart.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.dtpStart.Location = New System.Drawing.Point(565, 30)
        Me.dtpStart.Name = "dtpStart"
        Me.dtpStart.ShowUpDown = True
        Me.dtpStart.Size = New System.Drawing.Size(120, 27)
        Me.dtpStart.TabIndex = 7
        '
        'lblEnd
        '
        Me.lblEnd.AutoSize = True
        Me.lblEnd.Location = New System.Drawing.Point(700, 10)
        Me.lblEnd.Name = "lblEnd"
        Me.lblEnd.Size = New System.Drawing.Size(81, 20)
        Me.lblEnd.TabIndex = 8
        Me.lblEnd.Text = "End Time *"
        '
        'dtpEnd
        '
        Me.dtpEnd.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.dtpEnd.Location = New System.Drawing.Point(700, 30)
        Me.dtpEnd.Name = "dtpEnd"
        Me.dtpEnd.ShowUpDown = True
        Me.dtpEnd.Size = New System.Drawing.Size(120, 27)
        Me.dtpEnd.TabIndex = 9
        '
        'lblRoom
        '
        Me.lblRoom.AutoSize = True
        Me.lblRoom.Location = New System.Drawing.Point(835, 10)
        Me.lblRoom.Name = "lblRoom"
        Me.lblRoom.Size = New System.Drawing.Size(59, 20)
        Me.lblRoom.TabIndex = 10
        Me.lblRoom.Text = "Room *"
        '
        'txtRoom
        '
        Me.txtRoom.Location = New System.Drawing.Point(835, 30)
        Me.txtRoom.Name = "txtRoom"
        Me.txtRoom.Size = New System.Drawing.Size(100, 27)
        Me.txtRoom.TabIndex = 11
        '
        'lblSemester
        '
        Me.lblSemester.AutoSize = True
        Me.lblSemester.Location = New System.Drawing.Point(950, 10)
        Me.lblSemester.Name = "lblSemester"
        Me.lblSemester.Size = New System.Drawing.Size(80, 20)
        Me.lblSemester.TabIndex = 12
        Me.lblSemester.Text = "Semester *"
        '
        'cmbSemester
        '
        Me.cmbSemester.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbSemester.Items.AddRange(New Object() {"1st Sem", "2nd Sem", "Summer"})
        Me.cmbSemester.Location = New System.Drawing.Point(950, 30)
        Me.cmbSemester.Name = "cmbSemester"
        Me.cmbSemester.Size = New System.Drawing.Size(110, 28)
        Me.cmbSemester.TabIndex = 13
        '
        'lblAcadYear
        '
        Me.lblAcadYear.AutoSize = True
        Me.lblAcadYear.Location = New System.Drawing.Point(1075, 10)
        Me.lblAcadYear.Name = "lblAcadYear"
        Me.lblAcadYear.Size = New System.Drawing.Size(96, 20)
        Me.lblAcadYear.TabIndex = 14
        Me.lblAcadYear.Text = "School Year *"
        '
        'txtAcadYear
        '
        Me.txtAcadYear.Location = New System.Drawing.Point(1075, 30)
        Me.txtAcadYear.Name = "txtAcadYear"
        Me.txtAcadYear.Size = New System.Drawing.Size(100, 27)
        Me.txtAcadYear.TabIndex = 15
        Me.txtAcadYear.Text = "2024-2025"
        '
        'lblMaxSlots
        '
        Me.lblMaxSlots.AutoSize = True
        Me.lblMaxSlots.Location = New System.Drawing.Point(1190, 10)
        Me.lblMaxSlots.Name = "lblMaxSlots"
        Me.lblMaxSlots.Size = New System.Drawing.Size(73, 20)
        Me.lblMaxSlots.TabIndex = 16
        Me.lblMaxSlots.Text = "Max Slots"
        '
        'txtMaxSlots
        '
        Me.txtMaxSlots.Location = New System.Drawing.Point(1190, 30)
        Me.txtMaxSlots.Name = "txtMaxSlots"
        Me.txtMaxSlots.Size = New System.Drawing.Size(55, 27)
        Me.txtMaxSlots.TabIndex = 17
        Me.txtMaxSlots.Text = "40"
        '
        'pnlButtons
        '
        Me.pnlButtons.BackColor = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(233, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.pnlButtons.Controls.Add(Me.btnAdd)
        Me.pnlButtons.Controls.Add(Me.btnUpdate)
        Me.pnlButtons.Controls.Add(Me.btnDelete)
        Me.pnlButtons.Controls.Add(Me.btnClear)
        Me.pnlButtons.Location = New System.Drawing.Point(10, 263)
        Me.pnlButtons.Name = "pnlButtons"
        Me.pnlButtons.Size = New System.Drawing.Size(1331, 45)
        Me.pnlButtons.TabIndex = 3
        '
        'btnAdd
        '
        Me.btnAdd.BackColor = System.Drawing.Color.FromArgb(CType(CType(67, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(202, Byte), Integer))
        Me.btnAdd.FlatAppearance.BorderSize = 0
        Me.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAdd.ForeColor = System.Drawing.Color.White
        Me.btnAdd.Location = New System.Drawing.Point(0, 6)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(100, 32)
        Me.btnAdd.TabIndex = 0
        Me.btnAdd.Text = "➕  Add"
        Me.btnAdd.UseVisualStyleBackColor = False
        '
        'btnUpdate
        '
        Me.btnUpdate.BackColor = System.Drawing.Color.FromArgb(CType(CType(99, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.btnUpdate.FlatAppearance.BorderSize = 0
        Me.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUpdate.ForeColor = System.Drawing.Color.White
        Me.btnUpdate.Location = New System.Drawing.Point(110, 6)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(100, 32)
        Me.btnUpdate.TabIndex = 1
        Me.btnUpdate.Text = "✏  Update"
        Me.btnUpdate.UseVisualStyleBackColor = False
        '
        'btnDelete
        '
        Me.btnDelete.BackColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.btnDelete.FlatAppearance.BorderSize = 0
        Me.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDelete.ForeColor = System.Drawing.Color.White
        Me.btnDelete.Location = New System.Drawing.Point(220, 6)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(100, 32)
        Me.btnDelete.TabIndex = 2
        Me.btnDelete.Text = "🗑  Delete"
        Me.btnDelete.UseVisualStyleBackColor = False
        '
        'btnClear
        '
        Me.btnClear.BackColor = System.Drawing.Color.FromArgb(CType(CType(139, Byte), Integer), CType(CType(92, Byte), Integer), CType(CType(246, Byte), Integer))
        Me.btnClear.FlatAppearance.BorderSize = 0
        Me.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClear.ForeColor = System.Drawing.Color.White
        Me.btnClear.Location = New System.Drawing.Point(330, 6)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(100, 32)
        Me.btnClear.TabIndex = 3
        Me.btnClear.Text = "🔄  Clear"
        Me.btnClear.UseVisualStyleBackColor = False
        '
        'dgvSchedule
        '
        Me.dgvSchedule.AllowUserToAddRows = False
        Me.dgvSchedule.AllowUserToDeleteRows = False
        Me.dgvSchedule.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvSchedule.BackgroundColor = System.Drawing.Color.White
        Me.dgvSchedule.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvSchedule.ColumnHeadersHeight = 35
        Me.dgvSchedule.Location = New System.Drawing.Point(10, 315)
        Me.dgvSchedule.Name = "dgvSchedule"
        Me.dgvSchedule.ReadOnly = True
        Me.dgvSchedule.RowHeadersVisible = False
        Me.dgvSchedule.RowHeadersWidth = 51
        Me.dgvSchedule.RowTemplate.Height = 30
        Me.dgvSchedule.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvSchedule.Size = New System.Drawing.Size(1331, 390)
        Me.dgvSchedule.TabIndex = 4
        '
        'ScheduleForm
        '
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(233, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1430, 720)
        Me.Controls.Add(Me.pnlTop)
        Me.Controls.Add(Me.pnlFilter)
        Me.Controls.Add(Me.pnlForm)
        Me.Controls.Add(Me.pnlButtons)
        Me.Controls.Add(Me.dgvSchedule)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Name = "ScheduleForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Schedule Management"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.pnlTop.ResumeLayout(False)
        Me.pnlTop.PerformLayout()
        Me.pnlFilter.ResumeLayout(False)
        Me.pnlFilter.PerformLayout()
        Me.pnlForm.ResumeLayout(False)
        Me.pnlForm.PerformLayout()
        Me.pnlButtons.ResumeLayout(False)
        CType(Me.dgvSchedule, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    ' ── DECLARATIONS ──────────────────────────────────────────
    Friend WithEvents pnlTop      As System.Windows.Forms.Panel
    Friend WithEvents lblTitle    As System.Windows.Forms.Label
    Friend WithEvents lblSection  As System.Windows.Forms.Label

    Friend WithEvents pnlFilter   As System.Windows.Forms.Panel
    Friend WithEvents lblSemFilter As System.Windows.Forms.Label
    Friend WithEvents cmbSemFilter As System.Windows.Forms.ComboBox
    Friend WithEvents lblAYFilter  As System.Windows.Forms.Label
    Friend WithEvents cmbAYFilter  As System.Windows.Forms.ComboBox
    Friend WithEvents btnFilter    As System.Windows.Forms.Button

    Friend WithEvents pnlForm      As System.Windows.Forms.Panel
    Friend WithEvents lblSubject   As System.Windows.Forms.Label
    Friend WithEvents cmbSubject   As System.Windows.Forms.ComboBox
    Friend WithEvents lblInstructor As System.Windows.Forms.Label
    Friend WithEvents cmbInstructor As System.Windows.Forms.ComboBox
    Friend WithEvents lblDay       As System.Windows.Forms.Label
    Friend WithEvents cmbDay       As System.Windows.Forms.ComboBox
    Friend WithEvents lblStart     As System.Windows.Forms.Label
    Friend WithEvents dtpStart     As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblEnd       As System.Windows.Forms.Label
    Friend WithEvents dtpEnd       As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblRoom      As System.Windows.Forms.Label
    Friend WithEvents txtRoom      As System.Windows.Forms.TextBox
    Friend WithEvents lblSemester  As System.Windows.Forms.Label
    Friend WithEvents cmbSemester  As System.Windows.Forms.ComboBox
    Friend WithEvents lblAcadYear  As System.Windows.Forms.Label
    Friend WithEvents txtAcadYear  As System.Windows.Forms.TextBox
    Friend WithEvents lblMaxSlots  As System.Windows.Forms.Label
    Friend WithEvents txtMaxSlots  As System.Windows.Forms.TextBox

    Friend WithEvents pnlButtons  As System.Windows.Forms.Panel
    Friend WithEvents btnAdd      As System.Windows.Forms.Button
    Friend WithEvents btnUpdate   As System.Windows.Forms.Button
    Friend WithEvents btnDelete   As System.Windows.Forms.Button
    Friend WithEvents btnClear    As System.Windows.Forms.Button

    Friend WithEvents dgvSchedule As System.Windows.Forms.DataGridView

End Class
