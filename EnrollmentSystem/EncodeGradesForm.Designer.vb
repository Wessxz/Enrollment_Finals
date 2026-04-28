<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class EncodeGradesForm
    Inherits System.Windows.Forms.Form

    Private components As System.ComponentModel.IContainer

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
        Me.lblSubject = New System.Windows.Forms.Label()
        Me.cmbSubject = New System.Windows.Forms.ComboBox()
        Me.lblPrelim = New System.Windows.Forms.Label()
        Me.txtPrelim = New System.Windows.Forms.TextBox()
        Me.lblMidterm = New System.Windows.Forms.Label()
        Me.txtMidterm = New System.Windows.Forms.TextBox()
        Me.lblFinal = New System.Windows.Forms.Label()
        Me.txtFinal = New System.Windows.Forms.TextBox()
        Me.lblFinalGrade = New System.Windows.Forms.Label()
        Me.txtFinalGrade = New System.Windows.Forms.TextBox()
        Me.btnCompute = New System.Windows.Forms.Button()
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
        Me.txtCourse.Size = New System.Drawing.Size(150, 22)
        Me.txtCourse.TabIndex = 6
        '
        'pnlGrades
        '
        Me.pnlGrades.BackColor = System.Drawing.Color.White
        Me.pnlGrades.Controls.Add(Me.lblSubject)
        Me.pnlGrades.Controls.Add(Me.cmbSubject)
        Me.pnlGrades.Controls.Add(Me.lblPrelim)
        Me.pnlGrades.Controls.Add(Me.txtPrelim)
        Me.pnlGrades.Controls.Add(Me.lblMidterm)
        Me.pnlGrades.Controls.Add(Me.txtMidterm)
        Me.pnlGrades.Controls.Add(Me.lblFinal)
        Me.pnlGrades.Controls.Add(Me.txtFinal)
        Me.pnlGrades.Controls.Add(Me.lblFinalGrade)
        Me.pnlGrades.Controls.Add(Me.txtFinalGrade)
        Me.pnlGrades.Controls.Add(Me.btnCompute)
        Me.pnlGrades.Controls.Add(Me.btnSave)
        Me.pnlGrades.Controls.Add(Me.btnClear)
        Me.pnlGrades.Location = New System.Drawing.Point(20, 210)
        Me.pnlGrades.Name = "pnlGrades"
        Me.pnlGrades.Size = New System.Drawing.Size(1040, 160)
        Me.pnlGrades.TabIndex = 2
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
        Me.cmbSubject.Location = New System.Drawing.Point(20, 40)
        Me.cmbSubject.Name = "cmbSubject"
        Me.cmbSubject.Size = New System.Drawing.Size(200, 24)
        Me.cmbSubject.TabIndex = 1
        '
        'lblPrelim
        '
        Me.lblPrelim.Location = New System.Drawing.Point(250, 15)
        Me.lblPrelim.Name = "lblPrelim"
        Me.lblPrelim.Size = New System.Drawing.Size(100, 23)
        Me.lblPrelim.TabIndex = 2
        Me.lblPrelim.Text = "Prelim"
        '
        'txtPrelim
        '
        Me.txtPrelim.Location = New System.Drawing.Point(250, 40)
        Me.txtPrelim.Name = "txtPrelim"
        Me.txtPrelim.Size = New System.Drawing.Size(100, 22)
        Me.txtPrelim.TabIndex = 3
        '
        'lblMidterm
        '
        Me.lblMidterm.Location = New System.Drawing.Point(380, 15)
        Me.lblMidterm.Name = "lblMidterm"
        Me.lblMidterm.Size = New System.Drawing.Size(100, 23)
        Me.lblMidterm.TabIndex = 4
        Me.lblMidterm.Text = "Midterm"
        '
        'txtMidterm
        '
        Me.txtMidterm.Location = New System.Drawing.Point(380, 40)
        Me.txtMidterm.Name = "txtMidterm"
        Me.txtMidterm.Size = New System.Drawing.Size(100, 22)
        Me.txtMidterm.TabIndex = 5
        '
        'lblFinal
        '
        Me.lblFinal.Location = New System.Drawing.Point(510, 15)
        Me.lblFinal.Name = "lblFinal"
        Me.lblFinal.Size = New System.Drawing.Size(100, 23)
        Me.lblFinal.TabIndex = 6
        Me.lblFinal.Text = "Final"
        '
        'txtFinal
        '
        Me.txtFinal.Location = New System.Drawing.Point(510, 40)
        Me.txtFinal.Name = "txtFinal"
        Me.txtFinal.Size = New System.Drawing.Size(100, 22)
        Me.txtFinal.TabIndex = 7
        '
        'lblFinalGrade
        '
        Me.lblFinalGrade.Location = New System.Drawing.Point(640, 15)
        Me.lblFinalGrade.Name = "lblFinalGrade"
        Me.lblFinalGrade.Size = New System.Drawing.Size(100, 23)
        Me.lblFinalGrade.TabIndex = 8
        Me.lblFinalGrade.Text = "Final Grade"
        '
        'txtFinalGrade
        '
        Me.txtFinalGrade.Location = New System.Drawing.Point(640, 40)
        Me.txtFinalGrade.Name = "txtFinalGrade"
        Me.txtFinalGrade.ReadOnly = True
        Me.txtFinalGrade.Size = New System.Drawing.Size(120, 22)
        Me.txtFinalGrade.TabIndex = 9
        '
        'btnCompute
        '
        Me.btnCompute.Location = New System.Drawing.Point(20, 90)
        Me.btnCompute.Name = "btnCompute"
        Me.btnCompute.Size = New System.Drawing.Size(75, 23)
        Me.btnCompute.TabIndex = 10
        Me.btnCompute.Text = "Compute"
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(120, 90)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(75, 23)
        Me.btnSave.TabIndex = 11
        Me.btnSave.Text = "Save"
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(200, 90)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(75, 23)
        Me.btnClear.TabIndex = 12
        Me.btnClear.Text = "Clear"
        '
        'dgvGrades
        '
        Me.dgvGrades.ColumnHeadersHeight = 29
        Me.dgvGrades.Location = New System.Drawing.Point(20, 390)
        Me.dgvGrades.Name = "dgvGrades"
        Me.dgvGrades.RowHeadersWidth = 51
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

    Friend WithEvents lblPrelim As Label
    Friend WithEvents txtPrelim As TextBox

    Friend WithEvents lblMidterm As Label
    Friend WithEvents txtMidterm As TextBox

    Friend WithEvents lblFinal As Label
    Friend WithEvents txtFinal As TextBox

    Friend WithEvents lblFinalGrade As Label
    Friend WithEvents txtFinalGrade As TextBox

    Friend WithEvents btnCompute As Button
    Friend WithEvents btnSave As Button
    Friend WithEvents btnClear As Button

    Friend WithEvents dgvGrades As DataGridView

End Class