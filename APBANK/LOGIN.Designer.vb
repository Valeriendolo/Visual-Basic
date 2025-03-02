<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LOGIN
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.lblUsername = New System.Windows.Forms.Label()
        Me.cmdEnter = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.lblPassword = New System.Windows.Forms.Label()
        Me.cmdEXIT = New System.Windows.Forms.Button()
        Me.cmdPrevious = New System.Windows.Forms.Button()
        Me.cmdShow = New System.Windows.Forms.Button()
        Me.cmdHide = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblUsername
        '
        Me.lblUsername.AutoSize = True
        Me.lblUsername.Location = New System.Drawing.Point(13, 43)
        Me.lblUsername.Name = "lblUsername"
        Me.lblUsername.Size = New System.Drawing.Size(73, 17)
        Me.lblUsername.TabIndex = 0
        Me.lblUsername.Text = "Username"
        '
        'cmdEnter
        '
        Me.cmdEnter.ForeColor = System.Drawing.Color.Blue
        Me.cmdEnter.Location = New System.Drawing.Point(100, 285)
        Me.cmdEnter.Name = "cmdEnter"
        Me.cmdEnter.Size = New System.Drawing.Size(75, 23)
        Me.cmdEnter.TabIndex = 1
        Me.cmdEnter.Text = "Enter"
        Me.cmdEnter.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(145, 43)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 22)
        Me.TextBox1.TabIndex = 2
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(145, 137)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(100, 22)
        Me.TextBox2.TabIndex = 3
        '
        'lblPassword
        '
        Me.lblPassword.AutoSize = True
        Me.lblPassword.Location = New System.Drawing.Point(13, 142)
        Me.lblPassword.Name = "lblPassword"
        Me.lblPassword.Size = New System.Drawing.Size(69, 17)
        Me.lblPassword.TabIndex = 4
        Me.lblPassword.Text = "Password"
        '
        'cmdEXIT
        '
        Me.cmdEXIT.ForeColor = System.Drawing.Color.Crimson
        Me.cmdEXIT.Location = New System.Drawing.Point(529, 331)
        Me.cmdEXIT.Name = "cmdEXIT"
        Me.cmdEXIT.Size = New System.Drawing.Size(75, 23)
        Me.cmdEXIT.TabIndex = 5
        Me.cmdEXIT.Text = "EXIT"
        Me.cmdEXIT.UseVisualStyleBackColor = True
        '
        'cmdPrevious
        '
        Me.cmdPrevious.ForeColor = System.Drawing.Color.DarkCyan
        Me.cmdPrevious.Location = New System.Drawing.Point(212, 285)
        Me.cmdPrevious.Name = "cmdPrevious"
        Me.cmdPrevious.Size = New System.Drawing.Size(75, 23)
        Me.cmdPrevious.TabIndex = 7
        Me.cmdPrevious.Text = "Previous"
        Me.cmdPrevious.UseVisualStyleBackColor = True
        '
        'cmdShow
        '
        Me.cmdShow.Location = New System.Drawing.Point(100, 331)
        Me.cmdShow.Name = "cmdShow"
        Me.cmdShow.Size = New System.Drawing.Size(75, 23)
        Me.cmdShow.TabIndex = 8
        Me.cmdShow.Text = "Show"
        Me.cmdShow.UseVisualStyleBackColor = True
        '
        'cmdHide
        '
        Me.cmdHide.Location = New System.Drawing.Point(212, 331)
        Me.cmdHide.Name = "cmdHide"
        Me.cmdHide.Size = New System.Drawing.Size(75, 23)
        Me.cmdHide.TabIndex = 6
        Me.cmdHide.Text = "Hide"
        Me.cmdHide.UseVisualStyleBackColor = True
        '
        'LOGIN
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(661, 395)
        Me.Controls.Add(Me.cmdShow)
        Me.Controls.Add(Me.cmdPrevious)
        Me.Controls.Add(Me.cmdHide)
        Me.Controls.Add(Me.cmdEXIT)
        Me.Controls.Add(Me.lblPassword)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.cmdEnter)
        Me.Controls.Add(Me.lblUsername)
        Me.Name = "LOGIN"
        Me.Text = "LOGIN"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblUsername As System.Windows.Forms.Label
    Friend WithEvents cmdEnter As System.Windows.Forms.Button
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents lblPassword As System.Windows.Forms.Label
    Friend WithEvents cmdEXIT As System.Windows.Forms.Button
    Friend WithEvents cmdPrevious As System.Windows.Forms.Button
    Friend WithEvents cmdShow As System.Windows.Forms.Button
    Friend WithEvents cmdHide As System.Windows.Forms.Button
End Class
