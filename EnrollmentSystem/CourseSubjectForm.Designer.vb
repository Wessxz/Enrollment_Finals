<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class CourseSubjectForm
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
        Me.tabControl = New System.Windows.Forms.TabControl()

        ' ── COURSE TAB ──
        Me.tabCourses = New System.Windows.Forms.TabPage()
        Me.pnlCourseForm = New System.Windows.Forms.Panel()
        Me.lblCourseCode = New System.Windows.Forms.Label()
        Me.txtCourseCode = New System.Windows.Forms.TextBox()
        Me.lblCourseName = New System.Windows.Forms.Label()
        Me.txtCourseName = New System.Windows.Forms.TextBox()
        Me.lblDepartment = New System.Windows.Forms.Label()
        Me.txtDepartment = New System.Windows.Forms.TextBox()
        Me.btnAddCourse = New System.Windows.Forms.Button()
        Me.btnUpdateCourse = New System.Windows.Forms.Button()
        Me.btnDeleteCourse = New System.Windows.Forms.Button()
        Me.btnClearCourse = New System.Windows.Forms.Button()
        Me.dgvCourses = New System.Windows.Forms.DataGridView()

        ' ── SUBJECT TAB ──
        Me.tabSubjects = New System.Windows.Forms.TabPage()
        Me.pnlSubjectForm = New System.Windows.Forms.Panel()
        Me.lblCourse = New System.Windows.Forms.Label()
        Me.cmbCourse = New System.Windows.Forms.ComboBox()
        Me.lblSubjectCode = New System.Windows.Forms.Label()
        Me.txtSubjectCode = New System.Windows.Forms.TextBox()
        Me.lblSubjectName = New System.Windows.Forms.Label()
        Me.txtSubjectName = New System.Windows.Forms.TextBox()
        Me.lblUnits = New System.Windows.Forms.Label()
        Me.txtUnits = New System.Windows.Forms.TextBox()
        Me.btnAddSubject = New System.Windows.Forms.Button()
        Me.btnUpdateSubject = New System.Windows.Forms.Button()
        Me.btnDeleteSubject = New System.Windows.Forms.Button()
        Me.btnClearSubject = New System.Windows.Forms.Button()
        Me.dgvSubjects = New System.Windows.Forms.DataGridView()

        Me.tabControl.SuspendLayout()
        Me.tabCourses.SuspendLayout()
        Me.tabSubjects.SuspendLayout()
        Me.pnlCourseForm.SuspendLayout()
        Me.pnlSubjectForm.SuspendLayout()
        CType(Me.dgvCourses, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvSubjects, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()

        ' ══════════════════════════════════════════════════════
        ' TITLE
        ' ══════════════════════════════════════════════════════
        Me.lblTitle.Text = "COURSE & SUBJECT MANAGEMENT"
        Me.lblTitle.Font = New System.Drawing.Font("Segoe UI", 16, System.Drawing.FontStyle.Bold)
        Me.lblTitle.ForeColor = System.Drawing.Color.FromArgb(30, 30, 60)
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Location = New System.Drawing.Point(20, 18)

        ' ══════════════════════════════════════════════════════
        ' TAB CONTROL
        ' ══════════════════════════════════════════════════════
        Me.tabControl.Location = New System.Drawing.Point(20, 65)
        Me.tabControl.Size = New System.Drawing.Size(960, 510)
        Me.tabControl.Font = New System.Drawing.Font("Segoe UI", 10)
        Me.tabControl.TabPages.Add(Me.tabCourses)
        Me.tabControl.TabPages.Add(Me.tabSubjects)

        ' ══════════════════════════════════════════════════════
        ' TAB 1: COURSES
        ' ══════════════════════════════════════════════════════
        Me.tabCourses.Text = "  Courses  "
        Me.tabCourses.BackColor = System.Drawing.Color.FromArgb(245, 247, 250)
        Me.tabCourses.Controls.Add(Me.pnlCourseForm)
        Me.tabCourses.Controls.Add(Me.dgvCourses)

        ' Course input panel
        Me.pnlCourseForm.Location = New System.Drawing.Point(10, 10)
        Me.pnlCourseForm.Size = New System.Drawing.Size(930, 70)
        Me.pnlCourseForm.BackColor = System.Drawing.Color.WhiteSmoke

        Me.lblCourseCode.Text = "Course Code"
        Me.lblCourseCode.Location = New System.Drawing.Point(15, 8)
        Me.lblCourseCode.Size = New System.Drawing.Size(100, 20)
        Me.lblCourseCode.Font = New System.Drawing.Font("Segoe UI", 9)
        Me.pnlCourseForm.Controls.Add(Me.lblCourseCode)

        Me.txtCourseCode.Location = New System.Drawing.Point(15, 30)
        Me.txtCourseCode.Size = New System.Drawing.Size(140, 24)
        Me.pnlCourseForm.Controls.Add(Me.txtCourseCode)

        Me.lblCourseName.Text = "Course Name"
        Me.lblCourseName.Location = New System.Drawing.Point(175, 8)
        Me.lblCourseName.Size = New System.Drawing.Size(100, 20)
        Me.lblCourseName.Font = New System.Drawing.Font("Segoe UI", 9)
        Me.pnlCourseForm.Controls.Add(Me.lblCourseName)

        Me.txtCourseName.Location = New System.Drawing.Point(175, 30)
        Me.txtCourseName.Size = New System.Drawing.Size(280, 24)
        Me.pnlCourseForm.Controls.Add(Me.txtCourseName)

        Me.lblDepartment.Text = "Department"
        Me.lblDepartment.Location = New System.Drawing.Point(475, 8)
        Me.lblDepartment.Size = New System.Drawing.Size(100, 20)
        Me.lblDepartment.Font = New System.Drawing.Font("Segoe UI", 9)
        Me.pnlCourseForm.Controls.Add(Me.lblDepartment)

        Me.txtDepartment.Location = New System.Drawing.Point(475, 30)
        Me.txtDepartment.Size = New System.Drawing.Size(200, 24)
        Me.pnlCourseForm.Controls.Add(Me.txtDepartment)

        ' Course buttons
        Me.btnAddCourse.Text = "Add"
        Me.btnAddCourse.Location = New System.Drawing.Point(695, 10)
        Me.btnAddCourse.Size = New System.Drawing.Size(55, 24)
        Me.btnAddCourse.BackColor = System.Drawing.Color.FromArgb(30, 30, 60)
        Me.btnAddCourse.ForeColor = System.Drawing.Color.White
        Me.btnAddCourse.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAddCourse.FlatAppearance.BorderSize = 0
        Me.pnlCourseForm.Controls.Add(Me.btnAddCourse)

        Me.btnUpdateCourse.Text = "Update"
        Me.btnUpdateCourse.Location = New System.Drawing.Point(760, 10)
        Me.btnUpdateCourse.Size = New System.Drawing.Size(70, 24)
        Me.btnUpdateCourse.BackColor = System.Drawing.Color.FromArgb(39, 174, 96)
        Me.btnUpdateCourse.ForeColor = System.Drawing.Color.White
        Me.btnUpdateCourse.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUpdateCourse.FlatAppearance.BorderSize = 0
        Me.pnlCourseForm.Controls.Add(Me.btnUpdateCourse)

        Me.btnDeleteCourse.Text = "Delete"
        Me.btnDeleteCourse.Location = New System.Drawing.Point(695, 40)
        Me.btnDeleteCourse.Size = New System.Drawing.Size(55, 24)
        Me.btnDeleteCourse.BackColor = System.Drawing.Color.FromArgb(192, 57, 43)
        Me.btnDeleteCourse.ForeColor = System.Drawing.Color.White
        Me.btnDeleteCourse.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDeleteCourse.FlatAppearance.BorderSize = 0
        Me.pnlCourseForm.Controls.Add(Me.btnDeleteCourse)

        Me.btnClearCourse.Text = "Clear"
        Me.btnClearCourse.Location = New System.Drawing.Point(760, 40)
        Me.btnClearCourse.Size = New System.Drawing.Size(70, 24)
        Me.btnClearCourse.BackColor = System.Drawing.Color.FromArgb(149, 165, 166)
        Me.btnClearCourse.ForeColor = System.Drawing.Color.White
        Me.btnClearCourse.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClearCourse.FlatAppearance.BorderSize = 0
        Me.pnlCourseForm.Controls.Add(Me.btnClearCourse)

        ' Course DataGridView
        Me.dgvCourses.Location = New System.Drawing.Point(10, 95)
        Me.dgvCourses.Size = New System.Drawing.Size(930, 380)
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
        Me.tabCourses.Controls.Add(Me.dgvCourses)

        ' ══════════════════════════════════════════════════════
        ' TAB 2: SUBJECTS
        ' ══════════════════════════════════════════════════════
        Me.tabSubjects.Text = "  Subjects  "
        Me.tabSubjects.BackColor = System.Drawing.Color.FromArgb(245, 247, 250)
        Me.tabSubjects.Controls.Add(Me.pnlSubjectForm)
        Me.tabSubjects.Controls.Add(Me.dgvSubjects)

        ' Subject input panel
        Me.pnlSubjectForm.Location = New System.Drawing.Point(10, 10)
        Me.pnlSubjectForm.Size = New System.Drawing.Size(930, 70)
        Me.pnlSubjectForm.BackColor = System.Drawing.Color.WhiteSmoke

        Me.lblCourse.Text = "Course"
        Me.lblCourse.Location = New System.Drawing.Point(15, 8)
        Me.lblCourse.Size = New System.Drawing.Size(80, 20)
        Me.lblCourse.Font = New System.Drawing.Font("Segoe UI", 9)
        Me.pnlSubjectForm.Controls.Add(Me.lblCourse)

        Me.cmbCourse.Location = New System.Drawing.Point(15, 30)
        Me.cmbCourse.Size = New System.Drawing.Size(140, 24)
        Me.cmbCourse.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.pnlSubjectForm.Controls.Add(Me.cmbCourse)

        Me.lblSubjectCode.Text = "Subject Code"
        Me.lblSubjectCode.Location = New System.Drawing.Point(175, 8)
        Me.lblSubjectCode.Size = New System.Drawing.Size(100, 20)
        Me.lblSubjectCode.Font = New System.Drawing.Font("Segoe UI", 9)
        Me.pnlSubjectForm.Controls.Add(Me.lblSubjectCode)

        Me.txtSubjectCode.Location = New System.Drawing.Point(175, 30)
        Me.txtSubjectCode.Size = New System.Drawing.Size(140, 24)
        Me.pnlSubjectForm.Controls.Add(Me.txtSubjectCode)

        Me.lblSubjectName.Text = "Subject Name"
        Me.lblSubjectName.Location = New System.Drawing.Point(335, 8)
        Me.lblSubjectName.Size = New System.Drawing.Size(100, 20)
        Me.lblSubjectName.Font = New System.Drawing.Font("Segoe UI", 9)
        Me.pnlSubjectForm.Controls.Add(Me.lblSubjectName)

        Me.txtSubjectName.Location = New System.Drawing.Point(335, 30)
        Me.txtSubjectName.Size = New System.Drawing.Size(260, 24)
        Me.pnlSubjectForm.Controls.Add(Me.txtSubjectName)

        Me.lblUnits.Text = "Units"
        Me.lblUnits.Location = New System.Drawing.Point(615, 8)
        Me.lblUnits.Size = New System.Drawing.Size(50, 20)
        Me.lblUnits.Font = New System.Drawing.Font("Segoe UI", 9)
        Me.pnlSubjectForm.Controls.Add(Me.lblUnits)

        Me.txtUnits.Location = New System.Drawing.Point(615, 30)
        Me.txtUnits.Size = New System.Drawing.Size(60, 24)
        Me.pnlSubjectForm.Controls.Add(Me.txtUnits)

        ' Subject buttons
        Me.btnAddSubject.Text = "Add"
        Me.btnAddSubject.Location = New System.Drawing.Point(695, 10)
        Me.btnAddSubject.Size = New System.Drawing.Size(55, 24)
        Me.btnAddSubject.BackColor = System.Drawing.Color.FromArgb(30, 30, 60)
        Me.btnAddSubject.ForeColor = System.Drawing.Color.White
        Me.btnAddSubject.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAddSubject.FlatAppearance.BorderSize = 0
        Me.pnlSubjectForm.Controls.Add(Me.btnAddSubject)

        Me.btnUpdateSubject.Text = "Update"
        Me.btnUpdateSubject.Location = New System.Drawing.Point(760, 10)
        Me.btnUpdateSubject.Size = New System.Drawing.Size(70, 24)
        Me.btnUpdateSubject.BackColor = System.Drawing.Color.FromArgb(39, 174, 96)
        Me.btnUpdateSubject.ForeColor = System.Drawing.Color.White
        Me.btnUpdateSubject.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUpdateSubject.FlatAppearance.BorderSize = 0
        Me.pnlSubjectForm.Controls.Add(Me.btnUpdateSubject)

        Me.btnDeleteSubject.Text = "Delete"
        Me.btnDeleteSubject.Location = New System.Drawing.Point(695, 40)
        Me.btnDeleteSubject.Size = New System.Drawing.Size(55, 24)
        Me.btnDeleteSubject.BackColor = System.Drawing.Color.FromArgb(192, 57, 43)
        Me.btnDeleteSubject.ForeColor = System.Drawing.Color.White
        Me.btnDeleteSubject.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDeleteSubject.FlatAppearance.BorderSize = 0
        Me.pnlSubjectForm.Controls.Add(Me.btnDeleteSubject)

        Me.btnClearSubject.Text = "Clear"
        Me.btnClearSubject.Location = New System.Drawing.Point(760, 40)
        Me.btnClearSubject.Size = New System.Drawing.Size(70, 24)
        Me.btnClearSubject.BackColor = System.Drawing.Color.FromArgb(149, 165, 166)
        Me.btnClearSubject.ForeColor = System.Drawing.Color.White
        Me.btnClearSubject.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClearSubject.FlatAppearance.BorderSize = 0
        Me.pnlSubjectForm.Controls.Add(Me.btnClearSubject)

        ' Subject DataGridView
        Me.dgvSubjects.Location = New System.Drawing.Point(10, 95)
        Me.dgvSubjects.Size = New System.Drawing.Size(930, 380)
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
        Me.tabSubjects.Controls.Add(Me.dgvSubjects)

        ' ══════════════════════════════════════════════════════
        ' FORM
        ' ══════════════════════════════════════════════════════
        Me.BackColor = System.Drawing.Color.FromArgb(245, 247, 250)
        Me.ClientSize = New System.Drawing.Size(1000, 600)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.tabControl)
        Me.Name = "CourseSubjectForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Course & Subject Management"

        Me.tabControl.ResumeLayout(False)
        Me.tabCourses.ResumeLayout(False)
        Me.tabSubjects.ResumeLayout(False)
        Me.pnlCourseForm.ResumeLayout(False)
        Me.pnlCourseForm.PerformLayout()
        Me.pnlSubjectForm.ResumeLayout(False)
        Me.pnlSubjectForm.PerformLayout()
        CType(Me.dgvCourses, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvSubjects, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()
    End Sub

    Friend WithEvents lblTitle As Label
    Friend WithEvents tabControl As System.Windows.Forms.TabControl
    Friend WithEvents tabCourses As System.Windows.Forms.TabPage
    Friend WithEvents tabSubjects As System.Windows.Forms.TabPage

    Friend WithEvents pnlCourseForm As Panel
    Friend WithEvents lblCourseCode As Label
    Friend WithEvents txtCourseCode As TextBox
    Friend WithEvents lblCourseName As Label
    Friend WithEvents txtCourseName As TextBox
    Friend WithEvents lblDepartment As Label
    Friend WithEvents txtDepartment As TextBox
    Friend WithEvents btnAddCourse As Button
    Friend WithEvents btnUpdateCourse As Button
    Friend WithEvents btnDeleteCourse As Button
    Friend WithEvents btnClearCourse As Button
    Friend WithEvents dgvCourses As DataGridView

    Friend WithEvents pnlSubjectForm As Panel
    Friend WithEvents lblCourse As Label
    Friend WithEvents cmbCourse As ComboBox
    Friend WithEvents lblSubjectCode As Label
    Friend WithEvents txtSubjectCode As TextBox
    Friend WithEvents lblSubjectName As Label
    Friend WithEvents txtSubjectName As TextBox
    Friend WithEvents lblUnits As Label
    Friend WithEvents txtUnits As TextBox
    Friend WithEvents btnAddSubject As Button
    Friend WithEvents btnUpdateSubject As Button
    Friend WithEvents btnDeleteSubject As Button
    Friend WithEvents btnClearSubject As Button
    Friend WithEvents dgvSubjects As DataGridView

End Class
