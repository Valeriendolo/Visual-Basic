<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class REGISTRATION
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
        Me.lblFullName = New System.Windows.Forms.Label()
        Me.lblEmail = New System.Windows.Forms.Label()
        Me.lblPhoneNumber = New System.Windows.Forms.Label()
        Me.txtFullName = New System.Windows.Forms.TextBox()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.lblGender = New System.Windows.Forms.Label()
        Me.rdoFemale = New System.Windows.Forms.RadioButton()
        Me.rdoMale = New System.Windows.Forms.RadioButton()
        Me.cmdClear = New System.Windows.Forms.Button()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.rdoPreferNotToSay = New System.Windows.Forms.RadioButton()
        Me.lblDOB = New System.Windows.Forms.Label()
        Me.cmdSubmit = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.cboAccountType = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblPassword = New System.Windows.Forms.Label()
        Me.mtxtPassword = New System.Windows.Forms.MaskedTextBox()
        Me.mtxtConfirmPassword = New System.Windows.Forms.MaskedTextBox()
        Me.lblConfirmPassword = New System.Windows.Forms.Label()
        Me.mtxtPhoneNumber = New System.Windows.Forms.MaskedTextBox()
        Me.LblFillAllTheRequiredFields = New System.Windows.Forms.Label()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.CheckBox2 = New System.Windows.Forms.CheckBox()
        Me.SuspendLayout()
        '
        'lblFullName
        '
        Me.lblFullName.AutoSize = True
        Me.lblFullName.Location = New System.Drawing.Point(31, 60)
        Me.lblFullName.Name = "lblFullName"
        Me.lblFullName.Size = New System.Drawing.Size(71, 17)
        Me.lblFullName.TabIndex = 0
        Me.lblFullName.Text = "Full Name"
        '
        'lblEmail
        '
        Me.lblEmail.AutoSize = True
        Me.lblEmail.Location = New System.Drawing.Point(31, 123)
        Me.lblEmail.Name = "lblEmail"
        Me.lblEmail.Size = New System.Drawing.Size(42, 17)
        Me.lblEmail.TabIndex = 1
        Me.lblEmail.Text = "Email"
        '
        'lblPhoneNumber
        '
        Me.lblPhoneNumber.AutoSize = True
        Me.lblPhoneNumber.Location = New System.Drawing.Point(31, 184)
        Me.lblPhoneNumber.Name = "lblPhoneNumber"
        Me.lblPhoneNumber.Size = New System.Drawing.Size(103, 17)
        Me.lblPhoneNumber.TabIndex = 2
        Me.lblPhoneNumber.Text = "Phone Number"
        '
        'txtFullName
        '
        Me.txtFullName.Location = New System.Drawing.Point(329, 60)
        Me.txtFullName.Name = "txtFullName"
        Me.txtFullName.Size = New System.Drawing.Size(248, 22)
        Me.txtFullName.TabIndex = 3
        '
        'txtEmail
        '
        Me.txtEmail.Location = New System.Drawing.Point(329, 123)
        Me.txtEmail.Multiline = True
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(248, 22)
        Me.txtEmail.TabIndex = 4
        '
        'lblGender
        '
        Me.lblGender.AutoSize = True
        Me.lblGender.Location = New System.Drawing.Point(31, 307)
        Me.lblGender.Name = "lblGender"
        Me.lblGender.Size = New System.Drawing.Size(56, 17)
        Me.lblGender.TabIndex = 6
        Me.lblGender.Text = "Gender"
        '
        'rdoFemale
        '
        Me.rdoFemale.AutoSize = True
        Me.rdoFemale.Location = New System.Drawing.Point(329, 303)
        Me.rdoFemale.Name = "rdoFemale"
        Me.rdoFemale.Size = New System.Drawing.Size(75, 21)
        Me.rdoFemale.TabIndex = 7
        Me.rdoFemale.TabStop = True
        Me.rdoFemale.Text = "Female"
        Me.rdoFemale.UseVisualStyleBackColor = True
        '
        'rdoMale
        '
        Me.rdoMale.AutoSize = True
        Me.rdoMale.Location = New System.Drawing.Point(461, 303)
        Me.rdoMale.Name = "rdoMale"
        Me.rdoMale.Size = New System.Drawing.Size(59, 21)
        Me.rdoMale.TabIndex = 8
        Me.rdoMale.TabStop = True
        Me.rdoMale.Text = "Male"
        Me.rdoMale.UseVisualStyleBackColor = True
        '
        'cmdClear
        '
        Me.cmdClear.BackColor = System.Drawing.Color.Ivory
        Me.cmdClear.ForeColor = System.Drawing.Color.BlueViolet
        Me.cmdClear.Location = New System.Drawing.Point(166, 611)
        Me.cmdClear.Name = "cmdClear"
        Me.cmdClear.Size = New System.Drawing.Size(109, 31)
        Me.cmdClear.TabIndex = 9
        Me.cmdClear.Text = "Clear"
        Me.cmdClear.UseVisualStyleBackColor = False
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(329, 246)
        Me.DateTimePicker1.MinDate = New Date(1900, 1, 1, 0, 0, 0, 0)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(248, 22)
        Me.DateTimePicker1.TabIndex = 10
        '
        'rdoPreferNotToSay
        '
        Me.rdoPreferNotToSay.AutoSize = True
        Me.rdoPreferNotToSay.Location = New System.Drawing.Point(345, 342)
        Me.rdoPreferNotToSay.Name = "rdoPreferNotToSay"
        Me.rdoPreferNotToSay.Size = New System.Drawing.Size(143, 21)
        Me.rdoPreferNotToSay.TabIndex = 11
        Me.rdoPreferNotToSay.TabStop = True
        Me.rdoPreferNotToSay.Text = "Prefer Not To Say"
        Me.rdoPreferNotToSay.UseVisualStyleBackColor = True
        '
        'lblDOB
        '
        Me.lblDOB.AutoSize = True
        Me.lblDOB.Location = New System.Drawing.Point(31, 246)
        Me.lblDOB.Name = "lblDOB"
        Me.lblDOB.Size = New System.Drawing.Size(38, 17)
        Me.lblDOB.TabIndex = 12
        Me.lblDOB.Text = "DOB"
        '
        'cmdSubmit
        '
        Me.cmdSubmit.BackColor = System.Drawing.Color.Beige
        Me.cmdSubmit.Location = New System.Drawing.Point(576, 611)
        Me.cmdSubmit.Name = "cmdSubmit"
        Me.cmdSubmit.Size = New System.Drawing.Size(109, 31)
        Me.cmdSubmit.TabIndex = 13
        Me.cmdSubmit.Text = "Submit"
        Me.cmdSubmit.UseVisualStyleBackColor = False
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.btnExit.Location = New System.Drawing.Point(371, 611)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(109, 31)
        Me.btnExit.TabIndex = 14
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'cboAccountType
        '
        Me.cboAccountType.FormattingEnabled = True
        Me.cboAccountType.Items.AddRange(New Object() {"Savings Account", "Current Account", "Salary Account", "Checking Account"})
        Me.cboAccountType.Location = New System.Drawing.Point(329, 387)
        Me.cboAccountType.Name = "cboAccountType"
        Me.cboAccountType.Size = New System.Drawing.Size(248, 24)
        Me.cboAccountType.TabIndex = 15
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(31, 394)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(95, 17)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "Account Type"
        '
        'lblPassword
        '
        Me.lblPassword.AutoSize = True
        Me.lblPassword.Location = New System.Drawing.Point(33, 458)
        Me.lblPassword.Name = "lblPassword"
        Me.lblPassword.Size = New System.Drawing.Size(69, 17)
        Me.lblPassword.TabIndex = 17
        Me.lblPassword.Text = "Password"
        '
        'mtxtPassword
        '
        Me.mtxtPassword.Location = New System.Drawing.Point(329, 458)
        Me.mtxtPassword.Name = "mtxtPassword"
        Me.mtxtPassword.Size = New System.Drawing.Size(248, 22)
        Me.mtxtPassword.TabIndex = 18
        Me.mtxtPassword.UseSystemPasswordChar = True
        '
        'mtxtConfirmPassword
        '
        Me.mtxtConfirmPassword.Location = New System.Drawing.Point(329, 534)
        Me.mtxtConfirmPassword.Name = "mtxtConfirmPassword"
        Me.mtxtConfirmPassword.Size = New System.Drawing.Size(248, 22)
        Me.mtxtConfirmPassword.TabIndex = 19
        Me.mtxtConfirmPassword.UseSystemPasswordChar = True
        '
        'lblConfirmPassword
        '
        Me.lblConfirmPassword.AutoSize = True
        Me.lblConfirmPassword.Location = New System.Drawing.Point(31, 534)
        Me.lblConfirmPassword.Name = "lblConfirmPassword"
        Me.lblConfirmPassword.Size = New System.Drawing.Size(121, 17)
        Me.lblConfirmPassword.TabIndex = 20
        Me.lblConfirmPassword.Text = "Confirm Password"
        '
        'mtxtPhoneNumber
        '
        Me.mtxtPhoneNumber.BeepOnError = True
        Me.mtxtPhoneNumber.Location = New System.Drawing.Point(329, 184)
        Me.mtxtPhoneNumber.Name = "mtxtPhoneNumber"
        Me.mtxtPhoneNumber.Size = New System.Drawing.Size(248, 22)
        Me.mtxtPhoneNumber.TabIndex = 21
        '
        'LblFillAllTheRequiredFields
        '
        Me.LblFillAllTheRequiredFields.AutoSize = True
        Me.LblFillAllTheRequiredFields.Font = New System.Drawing.Font("Cascadia Mono", 7.8!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblFillAllTheRequiredFields.ForeColor = System.Drawing.Color.Crimson
        Me.LblFillAllTheRequiredFields.Location = New System.Drawing.Point(242, 22)
        Me.LblFillAllTheRequiredFields.Name = "LblFillAllTheRequiredFields"
        Me.LblFillAllTheRequiredFields.Size = New System.Drawing.Size(232, 18)
        Me.LblFillAllTheRequiredFields.TabIndex = 22
        Me.LblFillAllTheRequiredFields.Text = "Fill All The Required Fields"
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(603, 460)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(62, 21)
        Me.CheckBox1.TabIndex = 23
        Me.CheckBox1.Text = "show"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'CheckBox2
        '
        Me.CheckBox2.AutoSize = True
        Me.CheckBox2.Location = New System.Drawing.Point(603, 534)
        Me.CheckBox2.Name = "CheckBox2"
        Me.CheckBox2.Size = New System.Drawing.Size(62, 21)
        Me.CheckBox2.TabIndex = 24
        Me.CheckBox2.Text = "show"
        Me.CheckBox2.UseVisualStyleBackColor = True
        '
        'REGISTRATION
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.ClientSize = New System.Drawing.Size(906, 681)
        Me.Controls.Add(Me.CheckBox2)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.LblFillAllTheRequiredFields)
        Me.Controls.Add(Me.mtxtPhoneNumber)
        Me.Controls.Add(Me.lblConfirmPassword)
        Me.Controls.Add(Me.mtxtConfirmPassword)
        Me.Controls.Add(Me.mtxtPassword)
        Me.Controls.Add(Me.lblPassword)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cboAccountType)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.cmdSubmit)
        Me.Controls.Add(Me.lblDOB)
        Me.Controls.Add(Me.rdoPreferNotToSay)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.cmdClear)
        Me.Controls.Add(Me.rdoMale)
        Me.Controls.Add(Me.rdoFemale)
        Me.Controls.Add(Me.lblGender)
        Me.Controls.Add(Me.txtEmail)
        Me.Controls.Add(Me.txtFullName)
        Me.Controls.Add(Me.lblPhoneNumber)
        Me.Controls.Add(Me.lblEmail)
        Me.Controls.Add(Me.lblFullName)
        Me.ForeColor = System.Drawing.Color.DarkMagenta
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "REGISTRATION"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblFullName As System.Windows.Forms.Label
    Friend WithEvents lblEmail As System.Windows.Forms.Label
    Friend WithEvents lblPhoneNumber As System.Windows.Forms.Label
    Friend WithEvents txtFullName As System.Windows.Forms.TextBox
    Friend WithEvents txtEmail As System.Windows.Forms.TextBox
    Friend WithEvents lblGender As System.Windows.Forms.Label
    Friend WithEvents rdoFemale As System.Windows.Forms.RadioButton
    Friend WithEvents rdoMale As System.Windows.Forms.RadioButton
    Friend WithEvents cmdClear As System.Windows.Forms.Button
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents rdoPreferNotToSay As System.Windows.Forms.RadioButton
    Friend WithEvents lblDOB As System.Windows.Forms.Label
    Friend WithEvents cmdSubmit As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents cboAccountType As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblPassword As System.Windows.Forms.Label
    Friend WithEvents mtxtPassword As System.Windows.Forms.MaskedTextBox
    Friend WithEvents mtxtConfirmPassword As System.Windows.Forms.MaskedTextBox
    Friend WithEvents lblConfirmPassword As System.Windows.Forms.Label
    Friend WithEvents mtxtPhoneNumber As System.Windows.Forms.MaskedTextBox
    Friend WithEvents LblFillAllTheRequiredFields As System.Windows.Forms.Label
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox2 As System.Windows.Forms.CheckBox
End Class
