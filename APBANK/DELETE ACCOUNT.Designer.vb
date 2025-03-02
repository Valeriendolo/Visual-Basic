<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DELETEACCOUNT
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
        Me.lblAccountNumber = New System.Windows.Forms.Label()
        Me.lblName = New System.Windows.Forms.Label()
        Me.lblMobileNumber = New System.Windows.Forms.Label()
        Me.lblPassword = New System.Windows.Forms.Label()
        Me.txtAccountNumber = New System.Windows.Forms.TextBox()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.txtMobileNumber = New System.Windows.Forms.TextBox()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.lblConfirmPassword = New System.Windows.Forms.Label()
        Me.txtConfirmPassword = New System.Windows.Forms.TextBox()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.CheckBox2 = New System.Windows.Forms.CheckBox()
        Me.cmdSUBMIT = New System.Windows.Forms.Button()
        Me.lbldeactivate = New System.Windows.Forms.Label()
        Me.CheckBox3 = New System.Windows.Forms.CheckBox()
        Me.CheckBox4 = New System.Windows.Forms.CheckBox()
        Me.lbldelete = New System.Windows.Forms.Label()
        Me.cmdPREVIOUS = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblAccountNumber
        '
        Me.lblAccountNumber.AutoSize = True
        Me.lblAccountNumber.Location = New System.Drawing.Point(40, 53)
        Me.lblAccountNumber.Name = "lblAccountNumber"
        Me.lblAccountNumber.Size = New System.Drawing.Size(113, 17)
        Me.lblAccountNumber.TabIndex = 0
        Me.lblAccountNumber.Text = "Account Number"
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Location = New System.Drawing.Point(40, 101)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(45, 17)
        Me.lblName.TabIndex = 1
        Me.lblName.Text = "Name"
        '
        'lblMobileNumber
        '
        Me.lblMobileNumber.AutoSize = True
        Me.lblMobileNumber.Location = New System.Drawing.Point(40, 152)
        Me.lblMobileNumber.Name = "lblMobileNumber"
        Me.lblMobileNumber.Size = New System.Drawing.Size(103, 17)
        Me.lblMobileNumber.TabIndex = 2
        Me.lblMobileNumber.Text = "Mobile Number"
        '
        'lblPassword
        '
        Me.lblPassword.AutoSize = True
        Me.lblPassword.Location = New System.Drawing.Point(40, 202)
        Me.lblPassword.Name = "lblPassword"
        Me.lblPassword.Size = New System.Drawing.Size(69, 17)
        Me.lblPassword.TabIndex = 3
        Me.lblPassword.Text = "Password"
        '
        'txtAccountNumber
        '
        Me.txtAccountNumber.Location = New System.Drawing.Point(178, 50)
        Me.txtAccountNumber.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtAccountNumber.Name = "txtAccountNumber"
        Me.txtAccountNumber.Size = New System.Drawing.Size(89, 22)
        Me.txtAccountNumber.TabIndex = 4
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(178, 96)
        Me.txtName.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(89, 22)
        Me.txtName.TabIndex = 5
        '
        'txtMobileNumber
        '
        Me.txtMobileNumber.Location = New System.Drawing.Point(178, 147)
        Me.txtMobileNumber.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtMobileNumber.Name = "txtMobileNumber"
        Me.txtMobileNumber.Size = New System.Drawing.Size(89, 22)
        Me.txtMobileNumber.TabIndex = 6
        '
        'txtPassword
        '
        Me.txtPassword.Location = New System.Drawing.Point(178, 197)
        Me.txtPassword.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.Size = New System.Drawing.Size(89, 22)
        Me.txtPassword.TabIndex = 7
        Me.txtPassword.UseSystemPasswordChar = True
        '
        'lblConfirmPassword
        '
        Me.lblConfirmPassword.AutoSize = True
        Me.lblConfirmPassword.Location = New System.Drawing.Point(40, 254)
        Me.lblConfirmPassword.Name = "lblConfirmPassword"
        Me.lblConfirmPassword.Size = New System.Drawing.Size(121, 17)
        Me.lblConfirmPassword.TabIndex = 10
        Me.lblConfirmPassword.Text = "Confirm Password"
        '
        'txtConfirmPassword
        '
        Me.txtConfirmPassword.Location = New System.Drawing.Point(178, 249)
        Me.txtConfirmPassword.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtConfirmPassword.Name = "txtConfirmPassword"
        Me.txtConfirmPassword.Size = New System.Drawing.Size(89, 22)
        Me.txtConfirmPassword.TabIndex = 11
        Me.txtConfirmPassword.UseSystemPasswordChar = True
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(342, 198)
        Me.CheckBox1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(64, 21)
        Me.CheckBox1.TabIndex = 12
        Me.CheckBox1.Text = "Show"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'CheckBox2
        '
        Me.CheckBox2.AutoSize = True
        Me.CheckBox2.Location = New System.Drawing.Point(342, 250)
        Me.CheckBox2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.CheckBox2.Name = "CheckBox2"
        Me.CheckBox2.Size = New System.Drawing.Size(64, 21)
        Me.CheckBox2.TabIndex = 13
        Me.CheckBox2.Text = "Show"
        Me.CheckBox2.UseVisualStyleBackColor = True
        '
        'cmdSUBMIT
        '
        Me.cmdSUBMIT.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.cmdSUBMIT.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.cmdSUBMIT.Location = New System.Drawing.Point(770, 426)
        Me.cmdSUBMIT.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cmdSUBMIT.Name = "cmdSUBMIT"
        Me.cmdSUBMIT.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.cmdSUBMIT.Size = New System.Drawing.Size(94, 30)
        Me.cmdSUBMIT.TabIndex = 14
        Me.cmdSUBMIT.Text = "SUBMIT"
        Me.cmdSUBMIT.UseVisualStyleBackColor = False
        '
        'lbldeactivate
        '
        Me.lbldeactivate.AutoSize = True
        Me.lbldeactivate.Location = New System.Drawing.Point(40, 359)
        Me.lbldeactivate.Name = "lbldeactivate"
        Me.lbldeactivate.Size = New System.Drawing.Size(264, 17)
        Me.lbldeactivate.TabIndex = 15
        Me.lbldeactivate.Text = "If unsure, temporarily deactivate account"
        '
        'CheckBox3
        '
        Me.CheckBox3.AutoSize = True
        Me.CheckBox3.Location = New System.Drawing.Point(342, 305)
        Me.CheckBox3.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.CheckBox3.Name = "CheckBox3"
        Me.CheckBox3.Size = New System.Drawing.Size(71, 21)
        Me.CheckBox3.TabIndex = 16
        Me.CheckBox3.Text = "Delete"
        Me.CheckBox3.UseVisualStyleBackColor = True
        '
        'CheckBox4
        '
        Me.CheckBox4.AutoSize = True
        Me.CheckBox4.Location = New System.Drawing.Point(342, 356)
        Me.CheckBox4.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.CheckBox4.Name = "CheckBox4"
        Me.CheckBox4.Size = New System.Drawing.Size(97, 21)
        Me.CheckBox4.TabIndex = 17
        Me.CheckBox4.Text = "Deactivate"
        Me.CheckBox4.UseVisualStyleBackColor = True
        '
        'lbldelete
        '
        Me.lbldelete.AutoSize = True
        Me.lbldelete.Location = New System.Drawing.Point(40, 308)
        Me.lbldelete.Name = "lbldelete"
        Me.lbldelete.Size = New System.Drawing.Size(220, 17)
        Me.lbldelete.TabIndex = 18
        Me.lbldelete.Text = "If sure, proceed to delete account"
        '
        'cmdPREVIOUS
        '
        Me.cmdPREVIOUS.Location = New System.Drawing.Point(770, 381)
        Me.cmdPREVIOUS.Name = "cmdPREVIOUS"
        Me.cmdPREVIOUS.Size = New System.Drawing.Size(93, 23)
        Me.cmdPREVIOUS.TabIndex = 19
        Me.cmdPREVIOUS.Text = "PREVIOUS"
        Me.cmdPREVIOUS.UseVisualStyleBackColor = True
        '
        'DELETEACCOUNT
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(931, 505)
        Me.Controls.Add(Me.cmdPREVIOUS)
        Me.Controls.Add(Me.lbldelete)
        Me.Controls.Add(Me.CheckBox4)
        Me.Controls.Add(Me.CheckBox3)
        Me.Controls.Add(Me.lbldeactivate)
        Me.Controls.Add(Me.cmdSUBMIT)
        Me.Controls.Add(Me.CheckBox2)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.txtConfirmPassword)
        Me.Controls.Add(Me.lblConfirmPassword)
        Me.Controls.Add(Me.txtPassword)
        Me.Controls.Add(Me.txtMobileNumber)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.txtAccountNumber)
        Me.Controls.Add(Me.lblPassword)
        Me.Controls.Add(Me.lblMobileNumber)
        Me.Controls.Add(Me.lblName)
        Me.Controls.Add(Me.lblAccountNumber)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "DELETEACCOUNT"
        Me.Text = "DELETE ACCOUNT"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblAccountNumber As System.Windows.Forms.Label
    Friend WithEvents lblName As System.Windows.Forms.Label
    Friend WithEvents lblMobileNumber As System.Windows.Forms.Label
    Friend WithEvents lblPassword As System.Windows.Forms.Label
    Friend WithEvents txtAccountNumber As System.Windows.Forms.TextBox
    Friend WithEvents txtName As System.Windows.Forms.TextBox
    Friend WithEvents txtMobileNumber As System.Windows.Forms.TextBox
    Friend WithEvents txtPassword As System.Windows.Forms.TextBox
    Friend WithEvents lblConfirmPassword As System.Windows.Forms.Label
    Friend WithEvents txtConfirmPassword As System.Windows.Forms.TextBox
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox2 As System.Windows.Forms.CheckBox
    Friend WithEvents cmdSUBMIT As System.Windows.Forms.Button
    Friend WithEvents lbldeactivate As System.Windows.Forms.Label
    Friend WithEvents CheckBox3 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox4 As System.Windows.Forms.CheckBox
    Friend WithEvents lbldelete As System.Windows.Forms.Label
    Friend WithEvents cmdPREVIOUS As System.Windows.Forms.Button
End Class
