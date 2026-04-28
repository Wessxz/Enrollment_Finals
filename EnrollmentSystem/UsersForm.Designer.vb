<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class UsersForm
    Inherits System.Windows.Forms.Form

    Private components As System.ComponentModel.IContainer

    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.dgvUsers = New System.Windows.Forms.DataGridView()
        Me.btnLoad = New System.Windows.Forms.Button()
        Me.btnVerify = New System.Windows.Forms.Button()
        Me.btnReject = New System.Windows.Forms.Button()
        Me.lblTitle = New System.Windows.Forms.Label()
        CType(Me.dgvUsers, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()

        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Segoe UI", 16.0!, System.Drawing.FontStyle.Bold)
        Me.lblTitle.Location = New System.Drawing.Point(300, 20)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(230, 30)
        Me.lblTitle.TabIndex = 0
        Me.lblTitle.Text = "USER VERIFICATION"

        '
        'dgvUsers
        '
        Me.dgvUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvUsers.Location = New System.Drawing.Point(50, 70)
        Me.dgvUsers.Name = "dgvUsers"
        Me.dgvUsers.Size = New System.Drawing.Size(700, 250)
        Me.dgvUsers.TabIndex = 1

        '
        'btnLoad
        '
        Me.btnLoad.Location = New System.Drawing.Point(180, 340)
        Me.btnLoad.Name = "btnLoad"
        Me.btnLoad.Size = New System.Drawing.Size(120, 40)
        Me.btnLoad.TabIndex = 2
        Me.btnLoad.Text = "Load Users"
        Me.btnLoad.UseVisualStyleBackColor = True

        '
        'btnVerify
        '
        Me.btnVerify.Location = New System.Drawing.Point(340, 340)
        Me.btnVerify.Name = "btnVerify"
        Me.btnVerify.Size = New System.Drawing.Size(120, 40)
        Me.btnVerify.TabIndex = 3
        Me.btnVerify.Text = "Verify"
        Me.btnVerify.UseVisualStyleBackColor = True

        '
        'btnReject
        '
        Me.btnReject.Location = New System.Drawing.Point(500, 340)
        Me.btnReject.Name = "btnReject"
        Me.btnReject.Size = New System.Drawing.Size(120, 40)
        Me.btnReject.TabIndex = 4
        Me.btnReject.Text = "Reject"
        Me.btnReject.UseVisualStyleBackColor = True

        '
        'UsersForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)

        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.btnReject)
        Me.Controls.Add(Me.btnVerify)
        Me.Controls.Add(Me.btnLoad)
        Me.Controls.Add(Me.dgvUsers)

        Me.Name = "UsersForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "User Verification"

        CType(Me.dgvUsers, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgvUsers As DataGridView
    Friend WithEvents btnLoad As Button
    Friend WithEvents btnVerify As Button
    Friend WithEvents btnReject As Button
    Friend WithEvents lblTitle As Label

End Class