<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class SubjectForm
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
        Me.pnlForm = New System.Windows.Forms.Panel()
        Me.lblCourse = New System.Windows.Forms.Label()
        Me.cmbCourse = New System.Windows.Forms.ComboBox()
        Me.lblSubjectCode = New System.Windows.Forms.Label()
        Me.txtSubjectCode = New System.Windows.Forms.TextBox()
        Me.lblSubjectName = New System.Windows.Forms.Label()
        Me.txtSubjectName = New System.Windows.Forms.TextBox()
        Me.lblUnits = New System.Windows.Forms.Label()
        Me.txtUnits = New System.Windows.Forms.TextBox()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.dgvSubjects = New System.Windows.Forms.DataGridView()
        Me.pnlForm.SuspendLayout()
        CType(Me.dgvSubjects, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()

        ' lblTitle
        Me.lblTitle.Text = "SUBJECT MANAGEMENT"
        Me.lblTitle.Font = New System.Drawing.Font("Segoe UI", 16, System.Drawing.FontStyle.Bold)
        Me.lblTitle.ForeColor = System.Drawing.Color.FromArgb(30, 30, 60)
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Location = New System.Drawing.Point(20, 18)

        ' pnlForm
        Me.pnlForm.Location = New System.Drawing.Point(20, 65)
        Me.pnlForm.Size = New System.Drawing.Size(960, 75)
        Me.pnlForm.BackColor = System.Drawing.Color.WhiteSmoke

        ' lblCourse
        Me.lblCourse.Text = "Course"
        Me.lblCourse.Location = New System.Drawing.Point(15, 8)
        Me.lblCourse.Size = New System.Drawing.Size(80, 20)
        Me.lblCourse.Font = New System.Drawing.Font("Segoe UI", 9)
        Me.pnlForm.Controls.Add(Me.lblCourse)

        ' cmbCourse
        Me.cmbCourse.Location = New System.Drawing.Point(15, 30)
        Me.cmbCourse.Size = New System.Drawing.Size(150, 24)
        Me.cmbCourse.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.pnlForm.Controls.Add(Me.cmbCourse)

        ' lblSubjectCode
        Me.lblSubjectCode.Text = "Subject Code"
        Me.lblSubjectCode.Location = New System.Drawing.Point(185, 8)
        Me.lblSubjectCode.Size = New System.Drawing.Size(100, 20)
        Me.lblSubjectCode.Font = New System.Drawing.Font("Segoe UI", 9)
        Me.pnlForm.Controls.Add(Me.lblSubjectCode)

        ' txtSubjectCode
        Me.txtSubjectCode.Location = New System.Drawing.Point(185, 30)
        Me.txtSubjectCode.Size = New System.Drawing.Size(150, 24)
        Me.pnlForm.Controls.Add(Me.txtSubjectCode)

        ' lblSubjectName
        Me.lblSubjectName.Text = "Subject Name"
        Me.lblSubjectName.Location = New System.Drawing.Point(355, 8)
        Me.lblSubjectName.Size = New System.Drawing.Size(100, 20)
        Me.lblSubjectName.Font = New System.Drawing.Font("Segoe UI", 9)
        Me.pnlForm.Controls.Add(Me.lblSubjectName)

        ' txtSubjectName
        Me.txtSubjectName.Location = New System.Drawing.Point(355, 30)
        Me.txtSubjectName.Size = New System.Drawing.Size(260, 24)
        Me.pnlForm.Controls.Add(Me.txtSubjectName)

        ' lblUnits
        Me.lblUnits.Text = "Units"
        Me.lblUnits.Location = New System.Drawing.Point(635, 8)
        Me.lblUnits.Size = New System.Drawing.Size(50, 20)
        Me.lblUnits.Font = New System.Drawing.Font("Segoe UI", 9)
        Me.pnlForm.Controls.Add(Me.lblUnits)

        ' txtUnits
        Me.txtUnits.Location = New System.Drawing.Point(635, 30)
        Me.txtUnits.Size = New System.Drawing.Size(55, 24)
        Me.pnlForm.Controls.Add(Me.txtUnits)

        ' btnAdd
        Me.btnAdd.Text = "Add"
        Me.btnAdd.Location = New System.Drawing.Point(705, 15)
        Me.btnAdd.Size = New System.Drawing.Size(60, 28)
        Me.btnAdd.BackColor = System.Drawing.Color.FromArgb(30, 30, 60)
        Me.btnAdd.ForeColor = System.Drawing.Color.White
        Me.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAdd.FlatAppearance.BorderSize = 0
        Me.pnlForm.Controls.Add(Me.btnAdd)

        ' btnUpdate
        Me.btnUpdate.Text = "Update"
        Me.btnUpdate.Location = New System.Drawing.Point(775, 15)
        Me.btnUpdate.Size = New System.Drawing.Size(75, 28)
        Me.btnUpdate.BackColor = System.Drawing.Color.FromArgb(39, 174, 96)
        Me.btnUpdate.ForeColor = System.Drawing.Color.White
        Me.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUpdate.FlatAppearance.BorderSize = 0
        Me.pnlForm.Controls.Add(Me.btnUpdate)

        ' btnDelete
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.Location = New System.Drawing.Point(860, 15)
        Me.btnDelete.Size = New System.Drawing.Size(75, 28)
        Me.btnDelete.BackColor = System.Drawing.Color.FromArgb(192, 57, 43)
        Me.btnDelete.ForeColor = System.Drawing.Color.White
        Me.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDelete.FlatAppearance.BorderSize = 0
        Me.pnlForm.Controls.Add(Me.btnDelete)

        ' btnClear
        Me.btnClear.Text = "Clear"
        Me.btnClear.Location = New System.Drawing.Point(705, 48)
        Me.btnClear.Size = New System.Drawing.Size(60, 22)
        Me.btnClear.BackColor = System.Drawing.Color.FromArgb(149, 165, 166)
        Me.btnClear.ForeColor = System.Drawing.Color.White
        Me.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClear.FlatAppearance.BorderSize = 0
        Me.pnlForm.Controls.Add(Me.btnClear)

        ' dgvSubjects
        Me.dgvSubjects.Location = New System.Drawing.Point(20, 160)
        Me.dgvSubjects.Size = New System.Drawing.Size(960, 390)
        Me.dgvSubjects.BackgroundColor = System.Drawing.Color.White
        Me.dgvSubjects.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvSubjects.AllowUserToAddRows = False
        Me.dgvSubjects.AllowUserToDeleteRows = False
        Me.dgvSubjects.ReadOnly = True
        Me.dgvSubjects.RowHeadersVisible = False
        Me.dgvSubjects.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvSubjects.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvSubjects.ColumnHeadersHeight = 35
        Me.dgvSubjects.RowTemplate.Height = 30
        Me.dgvSubjects.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(30, 30, 60)
        Me.dgvSubjects.ColumnHeadersDefaultCellStyle.ForeColor = System.Drawing.Color.White
        Me.dgvSubjects.ColumnHeadersDefaultCellStyle.Font = New System.Drawing.Font("Segoe UI", 9, System.Drawing.FontStyle.Bold)
        Me.dgvSubjects.EnableHeadersVisualStyles = False

        ' Form
        Me.BackColor = System.Drawing.Color.FromArgb(245, 247, 250)
        Me.ClientSize = New System.Drawing.Size(1000, 580)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.pnlForm)
        Me.Controls.Add(Me.dgvSubjects)
        Me.Name = "SubjectForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Subject Management"

        Me.pnlForm.ResumeLayout(False)
        Me.pnlForm.PerformLayout()
        CType(Me.dgvSubjects, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()
    End Sub

    Friend WithEvents lblTitle As Label
    Friend WithEvents pnlForm As Panel
    Friend WithEvents lblCourse As Label
    Friend WithEvents cmbCourse As ComboBox
    Friend WithEvents lblSubjectCode As Label
    Friend WithEvents txtSubjectCode As TextBox
    Friend WithEvents lblSubjectName As Label
    Friend WithEvents txtSubjectName As TextBox
    Friend WithEvents lblUnits As Label
    Friend WithEvents txtUnits As TextBox
    Friend WithEvents btnAdd As Button
    Friend WithEvents btnUpdate As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents dgvSubjects As DataGridView

End Class
