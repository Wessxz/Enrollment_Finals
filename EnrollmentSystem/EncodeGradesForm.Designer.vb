<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class EncodeGradesForm
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

    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.pnlTop = New System.Windows.Forms.Panel()
        Me.lblStudentID = New System.Windows.Forms.Label()
        Me.txtStudentID = New System.Windows.Forms.TextBox()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.lblStudentName = New System.Windows.Forms.Label()
        Me.txtStudentName = New System.Windows.Forms.TextBox()
        Me.lblCourse = New System.Windows.Forms.Label()
        Me.txtCourse = New System.Windows.Forms.TextBox()
        Me.pnlGrades = New System.Windows.Forms.Panel()
        Me.lblGrade = New System.Windows.Forms.Label()
        Me.txtGrade = New System.Windows.Forms.TextBox()
        Me.cmbterm = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblSubject = New System.Windows.Forms.Label()
        Me.cmbSubject = New System.Windows.Forms.ComboBox()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.dgvGrades = New System.Windows.Forms.DataGridView()
        Me.pnlTop.SuspendLayout()
        Me.pnlGrades.SuspendLayout()
        CType(Me.dgvGrades, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold)
        Me.lblTitle.Location = New System.Drawing.Point(420, 20)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(398, 41)
        Me.lblTitle.TabIndex = 0
        Me.lblTitle.Text = "ENCODE GRADES MODULE"
        '
        'pnlTop
        '
        Me.pnlTop.BackColor = System.Drawing.Color.WhiteSmoke
        Me.pnlTop.Controls.Add(Me.lblStudentID)
        Me.pnlTop.Controls.Add(Me.txtStudentID)
        Me.pnlTop.Controls.Add(Me.btnSearch)
        Me.pnlTop.Controls.Add(Me.lblStudentName)
        Me.pnlTop.Controls.Add(Me.txtStudentName)
        Me.pnlTop.Controls.Add(Me.lblCourse)
        Me.pnlTop.Controls.Add(Me.txtCourse)
        Me.pnlTop.Location = New System.Drawing.Point(20, 70)
        Me.pnlTop.Name = "pnlTop"
        Me.pnlTop.Size = New System.Drawing.Size(1040, 120)
        Me.pnlTop.TabIndex = 1
        '
        'lblStudentID
        '
        Me.lblStudentID.Location = New System.Drawing.Point(20, 15)
        Me.lblStudentID.Name = "lblStudentID"
        Me.lblStudentID.Size = New System.Drawing.Size(100, 23)
        Me.lblStudentID.TabIndex = 0
        Me.lblStudentID.Text = "Student ID"
        '
        'txtStudentID
        '
        Me.txtStudentID.Location = New System.Drawing.Point(20, 40)
        Me.txtStudentID.Name = "txtStudentID"
        Me.txtStudentID.Size = New System.Drawing.Size(150, 22)
        Me.txtStudentID.TabIndex = 1
        '
        'btnSearch
        '
        Me.btnSearch.Location = New System.Drawing.Point(180, 38)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(75, 23)
        Me.btnSearch.TabIndex = 2
        Me.btnSearch.Text = "Search"
        '
        'lblStudentName
        '
        Me.lblStudentName.Location = New System.Drawing.Point(300, 15)
        Me.lblStudentName.Name = "lblStudentName"
        Me.lblStudentName.Size = New System.Drawing.Size(100, 23)
        Me.lblStudentName.TabIndex = 3
        Me.lblStudentName.Text = "Student Name"
        '
        'txtStudentName
        '
        Me.txtStudentName.Location = New System.Drawing.Point(300, 40)
        Me.txtStudentName.Name = "txtStudentName"
        Me.txtStudentName.ReadOnly = True
        Me.txtStudentName.Size = New System.Drawing.Size(250, 22)
        Me.txtStudentName.TabIndex = 4
        '
        'lblCourse
        '
        Me.lblCourse.Location = New System.Drawing.Point(600, 15)
        Me.lblCourse.Name = "lblCourse"
        Me.lblCourse.Size = New System.Drawing.Size(100, 23)
        Me.lblCourse.TabIndex = 5
        Me.lblCourse.Text = "Course"
        '
        'txtCourse
        '
        Me.txtCourse.Location = New System.Drawing.Point(600, 40)
        Me.txtCourse.Name = "txtCourse"
        Me.txtCourse.ReadOnly = True
        Me.txtCourse.Size = New System.Drawing.Size(150, 22)
        Me.txtCourse.TabIndex = 6
        '
        'pnlGrades
        '
        Me.pnlGrades.BackColor = System.Drawing.Color.White
        Me.pnlGrades.Controls.Add(Me.lblGrade)
        Me.pnlGrades.Controls.Add(Me.txtGrade)
        Me.pnlGrades.Controls.Add(Me.cmbterm)
        Me.pnlGrades.Controls.Add(Me.Label1)
        Me.pnlGrades.Controls.Add(Me.lblSubject)
        Me.pnlGrades.Controls.Add(Me.cmbSubject)
        Me.pnlGrades.Controls.Add(Me.btnSave)
        Me.pnlGrades.Controls.Add(Me.btnClear)
        Me.pnlGrades.Location = New System.Drawing.Point(20, 210)
        Me.pnlGrades.Name = "pnlGrades"
        Me.pnlGrades.Size = New System.Drawing.Size(1040, 160)
        Me.pnlGrades.TabIndex = 2
        '
        'lblGrade
        '
        Me.lblGrade.Location = New System.Drawing.Point(540, 15)
        Me.lblGrade.Name = "lblGrade"
        Me.lblGrade.Size = New System.Drawing.Size(100, 23)
        Me.lblGrade.TabIndex = 15
        Me.lblGrade.Text = "Grade"
        '
        'txtGrade
        '
        Me.txtGrade.Location = New System.Drawing.Point(540, 41)
        Me.txtGrade.Name = "txtGrade"
        Me.txtGrade.Size = New System.Drawing.Size(120, 22)
        Me.txtGrade.TabIndex = 16
        '
        'cmbterm
        '
        Me.cmbterm.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbterm.Location = New System.Drawing.Point(303, 41)
        Me.cmbterm.Name = "cmbterm"
        Me.cmbterm.Size = New System.Drawing.Size(200, 24)
        Me.cmbterm.TabIndex = 14
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(297, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(100, 23)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "Term"
        '
        'lblSubject
        '
        Me.lblSubject.Location = New System.Drawing.Point(20, 15)
        Me.lblSubject.Name = "lblSubject"
        Me.lblSubject.Size = New System.Drawing.Size(100, 23)
        Me.lblSubject.TabIndex = 0
        Me.lblSubject.Text = "Subject"
        '
        'cmbSubject
        '
        Me.cmbSubject.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbSubject.Location = New System.Drawing.Point(20, 40)
        Me.cmbSubject.Name = "cmbSubject"
        Me.cmbSubject.Size = New System.Drawing.Size(250, 24)
        Me.cmbSubject.TabIndex = 1
        '
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.btnSave.FlatAppearance.BorderSize = 0
        Me.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSave.ForeColor = System.Drawing.Color.White
        Me.btnSave.Location = New System.Drawing.Point(20, 90)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(100, 35)
        Me.btnSave.TabIndex = 11
        Me.btnSave.Text = "Save Grade"
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'btnClear
        '
        Me.btnClear.BackColor = System.Drawing.Color.FromArgb(CType(CType(149, Byte), Integer), CType(CType(165, Byte), Integer), CType(CType(166, Byte), Integer))
        Me.btnClear.FlatAppearance.BorderSize = 0
        Me.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClear.ForeColor = System.Drawing.Color.White
        Me.btnClear.Location = New System.Drawing.Point(140, 90)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(100, 35)
        Me.btnClear.TabIndex = 12
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = False
        '
        'dgvGrades
        '
        Me.dgvGrades.AllowUserToAddRows = False
        Me.dgvGrades.AllowUserToDeleteRows = False
        Me.dgvGrades.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvGrades.BackgroundColor = System.Drawing.Color.White
        Me.dgvGrades.ColumnHeadersHeight = 35
        Me.dgvGrades.Location = New System.Drawing.Point(20, 390)
        Me.dgvGrades.Name = "dgvGrades"
        Me.dgvGrades.ReadOnly = True
        Me.dgvGrades.RowHeadersVisible = False
        Me.dgvGrades.RowHeadersWidth = 51
        Me.dgvGrades.RowTemplate.Height = 30
        Me.dgvGrades.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvGrades.Size = New System.Drawing.Size(1040, 230)
        Me.dgvGrades.TabIndex = 3
        '
        'EncodeGradesForm
        '
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1100, 650)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.pnlTop)
        Me.Controls.Add(Me.pnlGrades)
        Me.Controls.Add(Me.dgvGrades)
        Me.Name = "EncodeGradesForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Encode Grades"
        Me.pnlTop.ResumeLayout(False)
        Me.pnlTop.PerformLayout()
        Me.pnlGrades.ResumeLayout(False)
        Me.pnlGrades.PerformLayout()
        CType(Me.dgvGrades, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblTitle As Label
    Friend WithEvents pnlTop As Panel
    Friend WithEvents pnlGrades As Panel
    Friend WithEvents lblStudentID As Label
    Friend WithEvents txtStudentID As TextBox
    Friend WithEvents btnSearch As Button
    Friend WithEvents lblStudentName As Label
    Friend WithEvents txtStudentName As TextBox
    Friend WithEvents lblCourse As Label
    Friend WithEvents txtCourse As TextBox
    Friend WithEvents lblSubject As Label
    Friend WithEvents cmbSubject As ComboBox
    Friend WithEvents btnSave As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents dgvGrades As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents cmbterm As ComboBox
    Friend WithEvents lblGrade As Label
    Friend WithEvents txtGrade As TextBox

End Class
