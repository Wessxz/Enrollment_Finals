<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class GradesForm
    Inherits Form

    Private Sub InitializeComponent()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.cmbStudent = New System.Windows.Forms.ComboBox()
        Me.cmbSubject = New System.Windows.Forms.ComboBox()
        Me.txtGrade = New System.Windows.Forms.TextBox()
        Me.txtRemarks = New System.Windows.Forms.TextBox()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.dgvGrades = New System.Windows.Forms.DataGridView()
        CType(Me.dgvGrades, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Segoe UI", 16.0!, System.Drawing.FontStyle.Bold)
        Me.lblTitle.Location = New System.Drawing.Point(350, 20)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(235, 37)
        Me.lblTitle.TabIndex = 0
        Me.lblTitle.Text = "ENCODE GRADES"
        '
        'cmbStudent
        '
        Me.cmbStudent.Location = New System.Drawing.Point(50, 80)
        Me.cmbStudent.Name = "cmbStudent"
        Me.cmbStudent.Size = New System.Drawing.Size(200, 24)
        Me.cmbStudent.TabIndex = 1
        '
        'cmbSubject
        '
        Me.cmbSubject.Location = New System.Drawing.Point(270, 80)
        Me.cmbSubject.Name = "cmbSubject"
        Me.cmbSubject.Size = New System.Drawing.Size(200, 24)
        Me.cmbSubject.TabIndex = 2
        '
        'txtGrade
        '
        Me.txtGrade.Location = New System.Drawing.Point(490, 80)
        Me.txtGrade.Name = "txtGrade"
        Me.txtGrade.Size = New System.Drawing.Size(100, 22)
        Me.txtGrade.TabIndex = 3
        Me.txtGrade.Text = "Grade"
        '
        'txtRemarks
        '
        Me.txtRemarks.Location = New System.Drawing.Point(610, 80)
        Me.txtRemarks.Name = "txtRemarks"
        Me.txtRemarks.Size = New System.Drawing.Size(150, 22)
        Me.txtRemarks.TabIndex = 4
        Me.txtRemarks.Text = "Remarks"
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(50, 120)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(75, 23)
        Me.btnSave.TabIndex = 5
        Me.btnSave.Text = "SAVE"
        '
        'dgvGrades
        '
        Me.dgvGrades.ColumnHeadersHeight = 29
        Me.dgvGrades.Location = New System.Drawing.Point(50, 170)
        Me.dgvGrades.Name = "dgvGrades"
        Me.dgvGrades.RowHeadersWidth = 51
        Me.dgvGrades.Size = New System.Drawing.Size(800, 280)
        Me.dgvGrades.TabIndex = 6
        '
        'GradesForm
        '
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(900, 500)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.cmbStudent)
        Me.Controls.Add(Me.cmbSubject)
        Me.Controls.Add(Me.txtGrade)
        Me.Controls.Add(Me.txtRemarks)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.dgvGrades)
        Me.Name = "GradesForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.dgvGrades, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblTitle As Label
    Friend WithEvents cmbStudent As ComboBox
    Friend WithEvents cmbSubject As ComboBox
    Friend WithEvents txtGrade As TextBox
    Friend WithEvents txtRemarks As TextBox
    Friend WithEvents btnSave As Button
    Friend WithEvents dgvGrades As DataGridView

End Class