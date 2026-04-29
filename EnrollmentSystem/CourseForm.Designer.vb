<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class CourseForm
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
        Me.lblCourseCode = New System.Windows.Forms.Label()
        Me.txtCourseCode = New System.Windows.Forms.TextBox()
        Me.lblCourseName = New System.Windows.Forms.Label()
        Me.txtCourseName = New System.Windows.Forms.TextBox()
        Me.lblDepartment = New System.Windows.Forms.Label()
        Me.txtDepartment = New System.Windows.Forms.TextBox()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.dgvCourses = New System.Windows.Forms.DataGridView()
        Me.pnlForm.SuspendLayout()
        CType(Me.dgvCourses, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()

        ' lblTitle
        Me.lblTitle.Text = "COURSE MANAGEMENT"
        Me.lblTitle.Font = New System.Drawing.Font("Segoe UI", 16, System.Drawing.FontStyle.Bold)
        Me.lblTitle.ForeColor = System.Drawing.Color.FromArgb(30, 30, 60)
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Location = New System.Drawing.Point(20, 18)

        ' pnlForm
        Me.pnlForm.Location = New System.Drawing.Point(20, 65)
        Me.pnlForm.Size = New System.Drawing.Size(960, 75)
        Me.pnlForm.BackColor = System.Drawing.Color.WhiteSmoke

        ' lblCourseCode
        Me.lblCourseCode.Text = "Course Code"
        Me.lblCourseCode.Location = New System.Drawing.Point(15, 8)
        Me.lblCourseCode.Size = New System.Drawing.Size(100, 20)
        Me.lblCourseCode.Font = New System.Drawing.Font("Segoe UI", 9)
        Me.pnlForm.Controls.Add(Me.lblCourseCode)

        ' txtCourseCode
        Me.txtCourseCode.Location = New System.Drawing.Point(15, 30)
        Me.txtCourseCode.Size = New System.Drawing.Size(150, 24)
        Me.pnlForm.Controls.Add(Me.txtCourseCode)

        ' lblCourseName
        Me.lblCourseName.Text = "Course Name"
        Me.lblCourseName.Location = New System.Drawing.Point(185, 8)
        Me.lblCourseName.Size = New System.Drawing.Size(100, 20)
        Me.lblCourseName.Font = New System.Drawing.Font("Segoe UI", 9)
        Me.pnlForm.Controls.Add(Me.lblCourseName)

        ' txtCourseName
        Me.txtCourseName.Location = New System.Drawing.Point(185, 30)
        Me.txtCourseName.Size = New System.Drawing.Size(280, 24)
        Me.pnlForm.Controls.Add(Me.txtCourseName)

        ' lblDepartment
        Me.lblDepartment.Text = "Department"
        Me.lblDepartment.Location = New System.Drawing.Point(485, 8)
        Me.lblDepartment.Size = New System.Drawing.Size(100, 20)
        Me.lblDepartment.Font = New System.Drawing.Font("Segoe UI", 9)
        Me.pnlForm.Controls.Add(Me.lblDepartment)

        ' txtDepartment
        Me.txtDepartment.Location = New System.Drawing.Point(485, 30)
        Me.txtDepartment.Size = New System.Drawing.Size(200, 24)
        Me.pnlForm.Controls.Add(Me.txtDepartment)

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

        ' dgvCourses
        Me.dgvCourses.Location = New System.Drawing.Point(20, 160)
        Me.dgvCourses.Size = New System.Drawing.Size(960, 390)
        Me.dgvCourses.BackgroundColor = System.Drawing.Color.White
        Me.dgvCourses.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvCourses.AllowUserToAddRows = False
        Me.dgvCourses.AllowUserToDeleteRows = False
        Me.dgvCourses.ReadOnly = True
        Me.dgvCourses.RowHeadersVisible = False
        Me.dgvCourses.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvCourses.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvCourses.ColumnHeadersHeight = 35
        Me.dgvCourses.RowTemplate.Height = 30
        Me.dgvCourses.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(30, 30, 60)
        Me.dgvCourses.ColumnHeadersDefaultCellStyle.ForeColor = System.Drawing.Color.White
        Me.dgvCourses.ColumnHeadersDefaultCellStyle.Font = New System.Drawing.Font("Segoe UI", 9, System.Drawing.FontStyle.Bold)
        Me.dgvCourses.EnableHeadersVisualStyles = False

        ' Form
        Me.BackColor = System.Drawing.Color.FromArgb(245, 247, 250)
        Me.ClientSize = New System.Drawing.Size(1000, 580)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.pnlForm)
        Me.Controls.Add(Me.dgvCourses)
        Me.Name = "CourseForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Course Management"

        Me.pnlForm.ResumeLayout(False)
        Me.pnlForm.PerformLayout()
        CType(Me.dgvCourses, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()
    End Sub

    Friend WithEvents lblTitle As Label
    Friend WithEvents pnlForm As Panel
    Friend WithEvents lblCourseCode As Label
    Friend WithEvents txtCourseCode As TextBox
    Friend WithEvents lblCourseName As Label
    Friend WithEvents txtCourseName As TextBox
    Friend WithEvents lblDepartment As Label
    Friend WithEvents txtDepartment As TextBox
    Friend WithEvents btnAdd As Button
    Friend WithEvents btnUpdate As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents dgvCourses As DataGridView

End Class
