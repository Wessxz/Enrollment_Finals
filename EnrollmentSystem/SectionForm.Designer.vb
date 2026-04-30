<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class SectionForm
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
        Me.lblCount = New System.Windows.Forms.Label()
        Me.pnlLeft = New System.Windows.Forms.Panel()
        Me.lblSectionName = New System.Windows.Forms.Label()
        Me.txtSectionName = New System.Windows.Forms.TextBox()
        Me.lblCourse = New System.Windows.Forms.Label()
        Me.cmbCourse = New System.Windows.Forms.ComboBox()
        Me.lblYearLevel = New System.Windows.Forms.Label()
        Me.cmbYearLevel = New System.Windows.Forms.ComboBox()
        Me.lblSemester = New System.Windows.Forms.Label()
        Me.cmbSemester = New System.Windows.Forms.ComboBox()
        Me.lblAcadYear = New System.Windows.Forms.Label()
        Me.txtAcadYear = New System.Windows.Forms.TextBox()
        Me.lblMaxSlots = New System.Windows.Forms.Label()
        Me.txtMaxSlots = New System.Windows.Forms.TextBox()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.dgvSections = New System.Windows.Forms.DataGridView()
        Me.pnlTop.SuspendLayout()
        Me.pnlLeft.SuspendLayout()
        CType(Me.dgvSections, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnlTop
        '
        Me.pnlTop.BackColor = System.Drawing.Color.FromArgb(CType(CType(67, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(202, Byte), Integer))
        Me.pnlTop.Controls.Add(Me.lblTitle)
        Me.pnlTop.Controls.Add(Me.lblCount)
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
        Me.lblTitle.Size = New System.Drawing.Size(331, 37)
        Me.lblTitle.TabIndex = 0
        Me.lblTitle.Text = "SECTION MANAGEMENT"
        '
        'lblCount
        '
        Me.lblCount.AutoSize = True
        Me.lblCount.ForeColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lblCount.Location = New System.Drawing.Point(22, 40)
        Me.lblCount.Name = "lblCount"
        Me.lblCount.Size = New System.Drawing.Size(116, 20)
        Me.lblCount.TabIndex = 1
        Me.lblCount.Text = "Total Sections: 0"
        '
        'pnlLeft
        '
        Me.pnlLeft.BackColor = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(233, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.pnlLeft.Controls.Add(Me.lblSectionName)
        Me.pnlLeft.Controls.Add(Me.txtSectionName)
        Me.pnlLeft.Controls.Add(Me.lblCourse)
        Me.pnlLeft.Controls.Add(Me.cmbCourse)
        Me.pnlLeft.Controls.Add(Me.lblYearLevel)
        Me.pnlLeft.Controls.Add(Me.cmbYearLevel)
        Me.pnlLeft.Controls.Add(Me.lblSemester)
        Me.pnlLeft.Controls.Add(Me.cmbSemester)
        Me.pnlLeft.Controls.Add(Me.lblAcadYear)
        Me.pnlLeft.Controls.Add(Me.txtAcadYear)
        Me.pnlLeft.Controls.Add(Me.lblMaxSlots)
        Me.pnlLeft.Controls.Add(Me.txtMaxSlots)
        Me.pnlLeft.Controls.Add(Me.btnAdd)
        Me.pnlLeft.Controls.Add(Me.btnUpdate)
        Me.pnlLeft.Controls.Add(Me.btnDelete)
        Me.pnlLeft.Controls.Add(Me.btnClear)
        Me.pnlLeft.Location = New System.Drawing.Point(10, 70)
        Me.pnlLeft.Name = "pnlLeft"
        Me.pnlLeft.Size = New System.Drawing.Size(300, 590)
        Me.pnlLeft.TabIndex = 1
        '
        'lblSectionName
        '
        Me.lblSectionName.AutoSize = True
        Me.lblSectionName.Location = New System.Drawing.Point(15, 15)
        Me.lblSectionName.Name = "lblSectionName"
        Me.lblSectionName.Size = New System.Drawing.Size(112, 20)
        Me.lblSectionName.TabIndex = 0
        Me.lblSectionName.Text = "Section Name *"
        '
        'txtSectionName
        '
        Me.txtSectionName.Location = New System.Drawing.Point(15, 35)
        Me.txtSectionName.Name = "txtSectionName"
        Me.txtSectionName.Size = New System.Drawing.Size(260, 27)
        Me.txtSectionName.TabIndex = 1
        '
        'lblCourse
        '
        Me.lblCourse.Location = New System.Drawing.Point(15, 69)
        Me.lblCourse.Name = "lblCourse"
        Me.lblCourse.Size = New System.Drawing.Size(100, 23)
        Me.lblCourse.TabIndex = 2
        Me.lblCourse.Text = "Course *"
        '
        'cmbCourse
        '
        Me.cmbCourse.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbCourse.Location = New System.Drawing.Point(15, 95)
        Me.cmbCourse.Name = "cmbCourse"
        Me.cmbCourse.Size = New System.Drawing.Size(260, 28)
        Me.cmbCourse.TabIndex = 3
        '
        'lblYearLevel
        '
        Me.lblYearLevel.AutoSize = True
        Me.lblYearLevel.Location = New System.Drawing.Point(15, 135)
        Me.lblYearLevel.Name = "lblYearLevel"
        Me.lblYearLevel.Size = New System.Drawing.Size(85, 20)
        Me.lblYearLevel.TabIndex = 4
        Me.lblYearLevel.Text = "Year Level *"
        '
        'cmbYearLevel
        '
        Me.cmbYearLevel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbYearLevel.Items.AddRange(New Object() {"1ST YEAR", "2ND YEAR", "3RD YEAR", "4TH YEAR"})
        Me.cmbYearLevel.Location = New System.Drawing.Point(15, 155)
        Me.cmbYearLevel.Name = "cmbYearLevel"
        Me.cmbYearLevel.Size = New System.Drawing.Size(260, 28)
        Me.cmbYearLevel.TabIndex = 5
        '
        'lblSemester
        '
        Me.lblSemester.AutoSize = True
        Me.lblSemester.Location = New System.Drawing.Point(15, 195)
        Me.lblSemester.Name = "lblSemester"
        Me.lblSemester.Size = New System.Drawing.Size(80, 20)
        Me.lblSemester.TabIndex = 6
        Me.lblSemester.Text = "Semester *"
        '
        'cmbSemester
        '
        Me.cmbSemester.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbSemester.Items.AddRange(New Object() {"1st Sem", "2nd Sem", "Summer"})
        Me.cmbSemester.Location = New System.Drawing.Point(15, 215)
        Me.cmbSemester.Name = "cmbSemester"
        Me.cmbSemester.Size = New System.Drawing.Size(260, 28)
        Me.cmbSemester.TabIndex = 7
        '
        'lblAcadYear
        '
        Me.lblAcadYear.AutoSize = True
        Me.lblAcadYear.Location = New System.Drawing.Point(15, 255)
        Me.lblAcadYear.Name = "lblAcadYear"
        Me.lblAcadYear.Size = New System.Drawing.Size(96, 20)
        Me.lblAcadYear.TabIndex = 8
        Me.lblAcadYear.Text = "School Year *"
        '
        'txtAcadYear
        '
        Me.txtAcadYear.Location = New System.Drawing.Point(15, 275)
        Me.txtAcadYear.Name = "txtAcadYear"
        Me.txtAcadYear.Size = New System.Drawing.Size(260, 27)
        Me.txtAcadYear.TabIndex = 9
        Me.txtAcadYear.Text = "2024-2025"
        '
        'lblMaxSlots
        '
        Me.lblMaxSlots.AutoSize = True
        Me.lblMaxSlots.Location = New System.Drawing.Point(15, 315)
        Me.lblMaxSlots.Name = "lblMaxSlots"
        Me.lblMaxSlots.Size = New System.Drawing.Size(108, 20)
        Me.lblMaxSlots.TabIndex = 14
        Me.lblMaxSlots.Text = "Max Students *"
        '
        'txtMaxSlots
        '
        Me.txtMaxSlots.Location = New System.Drawing.Point(15, 335)
        Me.txtMaxSlots.Name = "txtMaxSlots"
        Me.txtMaxSlots.Size = New System.Drawing.Size(100, 27)
        Me.txtMaxSlots.TabIndex = 15
        Me.txtMaxSlots.Text = "40"
        '
        'btnAdd
        '
        Me.btnAdd.BackColor = System.Drawing.Color.FromArgb(CType(CType(67, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(202, Byte), Integer))
        Me.btnAdd.FlatAppearance.BorderSize = 0
        Me.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAdd.ForeColor = System.Drawing.Color.White
        Me.btnAdd.Location = New System.Drawing.Point(15, 380)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(120, 32)
        Me.btnAdd.TabIndex = 10
        Me.btnAdd.Text = "Add Section"
        Me.btnAdd.UseVisualStyleBackColor = False
        '
        'btnUpdate
        '
        Me.btnUpdate.BackColor = System.Drawing.Color.FromArgb(CType(CType(99, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.btnUpdate.FlatAppearance.BorderSize = 0
        Me.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUpdate.ForeColor = System.Drawing.Color.White
        Me.btnUpdate.Location = New System.Drawing.Point(145, 380)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(80, 32)
        Me.btnUpdate.TabIndex = 11
        Me.btnUpdate.Text = "Update"
        Me.btnUpdate.UseVisualStyleBackColor = False
        '
        'btnDelete
        '
        Me.btnDelete.BackColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.btnDelete.FlatAppearance.BorderSize = 0
        Me.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDelete.ForeColor = System.Drawing.Color.White
        Me.btnDelete.Location = New System.Drawing.Point(15, 422)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(80, 32)
        Me.btnDelete.TabIndex = 12
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = False
        '
        'btnClear
        '
        Me.btnClear.BackColor = System.Drawing.Color.FromArgb(CType(CType(139, Byte), Integer), CType(CType(92, Byte), Integer), CType(CType(246, Byte), Integer))
        Me.btnClear.FlatAppearance.BorderSize = 0
        Me.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClear.ForeColor = System.Drawing.Color.White
        Me.btnClear.Location = New System.Drawing.Point(105, 422)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(80, 32)
        Me.btnClear.TabIndex = 13
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = False
        '
        'dgvSections
        '
        Me.dgvSections.AllowUserToAddRows = False
        Me.dgvSections.AllowUserToDeleteRows = False
        Me.dgvSections.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvSections.BackgroundColor = System.Drawing.Color.White
        Me.dgvSections.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvSections.ColumnHeadersHeight = 35
        Me.dgvSections.Location = New System.Drawing.Point(320, 70)
        Me.dgvSections.Name = "dgvSections"
        Me.dgvSections.ReadOnly = True
        Me.dgvSections.RowHeadersVisible = False
        Me.dgvSections.RowHeadersWidth = 51
        Me.dgvSections.RowTemplate.Height = 30
        Me.dgvSections.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvSections.Size = New System.Drawing.Size(765, 590)
        Me.dgvSections.TabIndex = 2
        '
        'SectionForm
        '
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(233, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1100, 680)
        Me.Controls.Add(Me.pnlTop)
        Me.Controls.Add(Me.pnlLeft)
        Me.Controls.Add(Me.dgvSections)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Name = "SectionForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Section Management"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.pnlTop.ResumeLayout(False)
        Me.pnlTop.PerformLayout()
        Me.pnlLeft.ResumeLayout(False)
        Me.pnlLeft.PerformLayout()
        CType(Me.dgvSections, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnlTop       As System.Windows.Forms.Panel
    Friend WithEvents lblTitle     As System.Windows.Forms.Label
    Friend WithEvents lblCount     As System.Windows.Forms.Label
    Friend WithEvents pnlLeft      As System.Windows.Forms.Panel
    Friend WithEvents lblSectionName As System.Windows.Forms.Label
    Friend WithEvents txtSectionName As System.Windows.Forms.TextBox
    Friend WithEvents lblCourse    As System.Windows.Forms.Label
    Friend WithEvents cmbCourse    As System.Windows.Forms.ComboBox
    Friend WithEvents lblYearLevel As System.Windows.Forms.Label
    Friend WithEvents cmbYearLevel As System.Windows.Forms.ComboBox
    Friend WithEvents lblSemester  As System.Windows.Forms.Label
    Friend WithEvents cmbSemester  As System.Windows.Forms.ComboBox
    Friend WithEvents lblAcadYear  As System.Windows.Forms.Label
    Friend WithEvents txtAcadYear  As System.Windows.Forms.TextBox
    Friend WithEvents lblMaxSlots  As System.Windows.Forms.Label
    Friend WithEvents txtMaxSlots  As System.Windows.Forms.TextBox
    Friend WithEvents btnAdd       As System.Windows.Forms.Button
    Friend WithEvents btnUpdate    As System.Windows.Forms.Button
    Friend WithEvents btnDelete    As System.Windows.Forms.Button
    Friend WithEvents btnClear     As System.Windows.Forms.Button
    Friend WithEvents dgvSections  As System.Windows.Forms.DataGridView
End Class
