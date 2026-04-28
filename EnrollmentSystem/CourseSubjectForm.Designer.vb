<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class CourseSubjectForm
    Inherits System.Windows.Forms.Form

    Private components As System.ComponentModel.IContainer

    Private Sub InitializeComponent()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.lblCourse = New System.Windows.Forms.Label()
        Me.lblSubjectCode = New System.Windows.Forms.Label()
        Me.lblSubjectName = New System.Windows.Forms.Label()
        Me.lblUnits = New System.Windows.Forms.Label()
        Me.txtCourse = New System.Windows.Forms.TextBox()
        Me.txtSubjectCode = New System.Windows.Forms.TextBox()
        Me.txtSubjectName = New System.Windows.Forms.TextBox()
        Me.txtUnits = New System.Windows.Forms.TextBox()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.dgvSubjects = New System.Windows.Forms.DataGridView()
        CType(Me.dgvSubjects, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold)
        Me.lblTitle.Location = New System.Drawing.Point(320, 20)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(502, 41)
        Me.lblTitle.TabIndex = 0
        Me.lblTitle.Text = "COURSE & SUBJECT MANAGEMENT"
        '
        'lblCourse
        '
        Me.lblCourse.Location = New System.Drawing.Point(30, 80)
        Me.lblCourse.Name = "lblCourse"
        Me.lblCourse.Size = New System.Drawing.Size(100, 23)
        Me.lblCourse.TabIndex = 1
        Me.lblCourse.Text = "Course"
        '
        'lblSubjectCode
        '
        Me.lblSubjectCode.Location = New System.Drawing.Point(250, 80)
        Me.lblSubjectCode.Name = "lblSubjectCode"
        Me.lblSubjectCode.Size = New System.Drawing.Size(100, 23)
        Me.lblSubjectCode.TabIndex = 2
        Me.lblSubjectCode.Text = "Subject Code"
        '
        'lblSubjectName
        '
        Me.lblSubjectName.Location = New System.Drawing.Point(450, 80)
        Me.lblSubjectName.Name = "lblSubjectName"
        Me.lblSubjectName.Size = New System.Drawing.Size(100, 23)
        Me.lblSubjectName.TabIndex = 3
        Me.lblSubjectName.Text = "Subject Name"
        '
        'lblUnits
        '
        Me.lblUnits.Location = New System.Drawing.Point(700, 80)
        Me.lblUnits.Name = "lblUnits"
        Me.lblUnits.Size = New System.Drawing.Size(100, 23)
        Me.lblUnits.TabIndex = 4
        Me.lblUnits.Text = "Units"
        '
        'txtCourse
        '
        Me.txtCourse.Location = New System.Drawing.Point(30, 110)
        Me.txtCourse.Name = "txtCourse"
        Me.txtCourse.Size = New System.Drawing.Size(200, 22)
        Me.txtCourse.TabIndex = 5
        '
        'txtSubjectCode
        '
        Me.txtSubjectCode.Location = New System.Drawing.Point(250, 110)
        Me.txtSubjectCode.Name = "txtSubjectCode"
        Me.txtSubjectCode.Size = New System.Drawing.Size(180, 22)
        Me.txtSubjectCode.TabIndex = 6
        '
        'txtSubjectName
        '
        Me.txtSubjectName.Location = New System.Drawing.Point(450, 110)
        Me.txtSubjectName.Name = "txtSubjectName"
        Me.txtSubjectName.Size = New System.Drawing.Size(220, 22)
        Me.txtSubjectName.TabIndex = 7
        '
        'txtUnits
        '
        Me.txtUnits.Location = New System.Drawing.Point(700, 110)
        Me.txtUnits.Name = "txtUnits"
        Me.txtUnits.Size = New System.Drawing.Size(100, 22)
        Me.txtUnits.TabIndex = 8
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(820, 110)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(75, 23)
        Me.btnAdd.TabIndex = 9
        Me.btnAdd.Text = "Add"
        '
        'btnUpdate
        '
        Me.btnUpdate.Location = New System.Drawing.Point(900, 110)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(75, 23)
        Me.btnUpdate.TabIndex = 10
        Me.btnUpdate.Text = "Update"
        '
        'btnDelete
        '
        Me.btnDelete.Location = New System.Drawing.Point(820, 150)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(75, 23)
        Me.btnDelete.TabIndex = 11
        Me.btnDelete.Text = "Delete"
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(900, 150)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(75, 23)
        Me.btnClear.TabIndex = 12
        Me.btnClear.Text = "Clear"
        '
        'dgvSubjects
        '
        Me.dgvSubjects.ColumnHeadersHeight = 29
        Me.dgvSubjects.Location = New System.Drawing.Point(30, 200)
        Me.dgvSubjects.Name = "dgvSubjects"
        Me.dgvSubjects.RowHeadersWidth = 51
        Me.dgvSubjects.Size = New System.Drawing.Size(940, 350)
        Me.dgvSubjects.TabIndex = 13
        '
        'CourseSubjectForm
        '
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1000, 600)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.lblCourse)
        Me.Controls.Add(Me.lblSubjectCode)
        Me.Controls.Add(Me.lblSubjectName)
        Me.Controls.Add(Me.lblUnits)
        Me.Controls.Add(Me.txtCourse)
        Me.Controls.Add(Me.txtSubjectCode)
        Me.Controls.Add(Me.txtSubjectName)
        Me.Controls.Add(Me.txtUnits)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.dgvSubjects)
        Me.Name = "CourseSubjectForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Course & Subject Management"
        CType(Me.dgvSubjects, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblTitle As Label
    Friend WithEvents lblCourse As Label
    Friend WithEvents lblSubjectCode As Label
    Friend WithEvents lblSubjectName As Label
    Friend WithEvents lblUnits As Label

    Friend WithEvents txtCourse As TextBox
    Friend WithEvents txtSubjectCode As TextBox
    Friend WithEvents txtSubjectName As TextBox
    Friend WithEvents txtUnits As TextBox

    Friend WithEvents btnAdd As Button
    Friend WithEvents btnUpdate As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnClear As Button

    Friend WithEvents dgvSubjects As DataGridView

End Class