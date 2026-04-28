<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class StudentForm
    Inherits System.Windows.Forms.Form

    Private components As System.ComponentModel.IContainer

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

    Private Sub InitializeComponent()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.lblStudentID = New System.Windows.Forms.Label()
        Me.lblFirstName = New System.Windows.Forms.Label()
        Me.lblLastName = New System.Windows.Forms.Label()
        Me.lblCourse = New System.Windows.Forms.Label()
        Me.lblYearLevel = New System.Windows.Forms.Label()
        Me.txtStudentID = New System.Windows.Forms.TextBox()
        Me.txtFirstName = New System.Windows.Forms.TextBox()
        Me.txtLastName = New System.Windows.Forms.TextBox()
        Me.txtCourse = New System.Windows.Forms.TextBox()
        Me.dgvStudents = New System.Windows.Forms.DataGridView()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmbStudentStatus = New System.Windows.Forms.ComboBox()
        Me.cmbYearLevel = New System.Windows.Forms.ComboBox()
        Me.lblSection = New System.Windows.Forms.Label()
        Me.cmbSection = New System.Windows.Forms.ComboBox()
        CType(Me.dgvStudents, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold)
        Me.lblTitle.Location = New System.Drawing.Point(380, 20)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(300, 41)
        Me.lblTitle.TabIndex = 0
        Me.lblTitle.Text = "STUDENT RECORDS"
        '
        'lblStudentID
        '
        Me.lblStudentID.Location = New System.Drawing.Point(30, 80)
        Me.lblStudentID.Name = "lblStudentID"
        Me.lblStudentID.Size = New System.Drawing.Size(100, 23)
        Me.lblStudentID.TabIndex = 1
        Me.lblStudentID.Text = "Student ID"
        '
        'lblFirstName
        '
        Me.lblFirstName.Location = New System.Drawing.Point(220, 80)
        Me.lblFirstName.Name = "lblFirstName"
        Me.lblFirstName.Size = New System.Drawing.Size(100, 23)
        Me.lblFirstName.TabIndex = 2
        Me.lblFirstName.Text = "First Name"
        '
        'lblLastName
        '
        Me.lblLastName.Location = New System.Drawing.Point(410, 80)
        Me.lblLastName.Name = "lblLastName"
        Me.lblLastName.Size = New System.Drawing.Size(100, 23)
        Me.lblLastName.TabIndex = 3
        Me.lblLastName.Text = "Last Name"
        '
        'lblCourse
        '
        Me.lblCourse.Location = New System.Drawing.Point(600, 80)
        Me.lblCourse.Name = "lblCourse"
        Me.lblCourse.Size = New System.Drawing.Size(100, 23)
        Me.lblCourse.TabIndex = 4
        Me.lblCourse.Text = "Course"
        '
        'lblYearLevel
        '
        Me.lblYearLevel.Location = New System.Drawing.Point(1040, 80)
        Me.lblYearLevel.Name = "lblYearLevel"
        Me.lblYearLevel.Size = New System.Drawing.Size(100, 23)
        Me.lblYearLevel.TabIndex = 5
        Me.lblYearLevel.Text = "Year Level"
        '
        'txtStudentID
        '
        Me.txtStudentID.Location = New System.Drawing.Point(30, 110)
        Me.txtStudentID.Name = "txtStudentID"
        Me.txtStudentID.Size = New System.Drawing.Size(150, 22)
        Me.txtStudentID.TabIndex = 7
        '
        'txtFirstName
        '
        Me.txtFirstName.Location = New System.Drawing.Point(220, 110)
        Me.txtFirstName.Name = "txtFirstName"
        Me.txtFirstName.Size = New System.Drawing.Size(150, 22)
        Me.txtFirstName.TabIndex = 8
        '
        'txtLastName
        '
        Me.txtLastName.Location = New System.Drawing.Point(410, 110)
        Me.txtLastName.Name = "txtLastName"
        Me.txtLastName.Size = New System.Drawing.Size(150, 22)
        Me.txtLastName.TabIndex = 9
        '
        'txtCourse
        '
        Me.txtCourse.Location = New System.Drawing.Point(600, 110)
        Me.txtCourse.Name = "txtCourse"
        Me.txtCourse.Size = New System.Drawing.Size(150, 22)
        Me.txtCourse.TabIndex = 10
        '
        'dgvStudents
        '
        Me.dgvStudents.ColumnHeadersHeight = 29
        Me.dgvStudents.Location = New System.Drawing.Point(30, 200)
        Me.dgvStudents.Name = "dgvStudents"
        Me.dgvStudents.RowHeadersWidth = 51
        Me.dgvStudents.Size = New System.Drawing.Size(1433, 463)
        Me.dgvStudents.TabIndex = 17
        '
        'btnUpdate
        '
        Me.btnUpdate.Location = New System.Drawing.Point(36, 149)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(75, 23)
        Me.btnUpdate.TabIndex = 13
        Me.btnUpdate.Text = "Update"
        '
        'btnDelete
        '
        Me.btnDelete.Location = New System.Drawing.Point(126, 149)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(75, 23)
        Me.btnDelete.TabIndex = 14
        Me.btnDelete.Text = "Delete"
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(216, 149)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(75, 23)
        Me.btnClear.TabIndex = 15
        Me.btnClear.Text = "Clear"
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(809, 80)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(100, 23)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Student Status"
        '
        'cmbStudentStatus
        '
        Me.cmbStudentStatus.Items.AddRange(New Object() {"IRREGULAR", "REGULAR"})
        Me.cmbStudentStatus.Location = New System.Drawing.Point(812, 110)
        Me.cmbStudentStatus.Name = "cmbStudentStatus"
        Me.cmbStudentStatus.Size = New System.Drawing.Size(159, 24)
        Me.cmbStudentStatus.TabIndex = 11
        '
        'cmbYearLevel
        '
        Me.cmbYearLevel.Items.AddRange(New Object() {"1ST YEAR", "2ND YEAR", "3RD YEAR", "4TH YEAR"})
        Me.cmbYearLevel.Location = New System.Drawing.Point(1043, 110)
        Me.cmbYearLevel.Name = "cmbYearLevel"
        Me.cmbYearLevel.Size = New System.Drawing.Size(159, 24)
        Me.cmbYearLevel.TabIndex = 12
        '
        'StudentForm
        '
        Me.ClientSize = New System.Drawing.Size(1475, 697)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.lblStudentID)
        Me.Controls.Add(Me.lblFirstName)
        Me.Controls.Add(Me.lblLastName)
        Me.Controls.Add(Me.lblCourse)
        Me.Controls.Add(Me.lblYearLevel)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtStudentID)
        Me.Controls.Add(Me.txtFirstName)
        Me.Controls.Add(Me.txtLastName)
        Me.Controls.Add(Me.txtCourse)
        '
        'lblSection
        '
        Me.lblSection.Location = New System.Drawing.Point(1220, 80)
        Me.lblSection.Name = "lblSection"
        Me.lblSection.Size = New System.Drawing.Size(100, 23)
        Me.lblSection.TabIndex = 18
        Me.lblSection.Text = "Section"
        '
        'cmbSection
        '
        Me.cmbSection.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbSection.Location = New System.Drawing.Point(1220, 110)
        Me.cmbSection.Name = "cmbSection"
        Me.cmbSection.Size = New System.Drawing.Size(200, 24)
        Me.cmbSection.TabIndex = 16

        Me.Controls.Add(Me.cmbStudentStatus)
        Me.Controls.Add(Me.cmbYearLevel)
        Me.Controls.Add(Me.lblSection)
        Me.Controls.Add(Me.cmbSection)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.dgvStudents)
        Me.Name = "StudentForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Student Records"
        CType(Me.dgvStudents, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblTitle As Label
    Friend WithEvents lblStudentID As Label
    Friend WithEvents lblFirstName As Label
    Friend WithEvents lblLastName As Label
    Friend WithEvents lblCourse As Label
    Friend WithEvents lblYearLevel As Label

    Friend WithEvents txtStudentID As TextBox
    Friend WithEvents txtFirstName As TextBox
    Friend WithEvents txtLastName As TextBox
    Friend WithEvents txtCourse As TextBox

    Friend WithEvents dgvStudents As DataGridView
    Friend WithEvents btnUpdate As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnClear As Button

    Friend WithEvents Label1 As Label
    Friend WithEvents cmbStudentStatus As ComboBox
    Friend WithEvents cmbYearLevel As ComboBox
    Friend WithEvents lblSection As Label
    Friend WithEvents cmbSection As ComboBox
End Class