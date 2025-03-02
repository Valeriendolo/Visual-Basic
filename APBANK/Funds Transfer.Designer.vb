<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FUNDSTRANSFER
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
        Me.cmdCLEAR = New System.Windows.Forms.Button()
        Me.cmdPREVIOUS = New System.Windows.Forms.Button()
        Me.cmdEXIT = New System.Windows.Forms.Button()
        Me.lblAccNo = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.lblAmount = New System.Windows.Forms.Label()
        Me.lblCurrentBalance = New System.Windows.Forms.Label()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.rdoDeposit = New System.Windows.Forms.RadioButton()
        Me.rdoWithdraw = New System.Windows.Forms.RadioButton()
        Me.lblNewBalance = New System.Windows.Forms.Label()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'cmdCLEAR
        '
        Me.cmdCLEAR.Location = New System.Drawing.Point(650, 533)
        Me.cmdCLEAR.Name = "cmdCLEAR"
        Me.cmdCLEAR.Size = New System.Drawing.Size(104, 23)
        Me.cmdCLEAR.TabIndex = 0
        Me.cmdCLEAR.Text = "CLEAR"
        Me.cmdCLEAR.UseVisualStyleBackColor = True
        '
        'cmdPREVIOUS
        '
        Me.cmdPREVIOUS.Location = New System.Drawing.Point(214, 533)
        Me.cmdPREVIOUS.Name = "cmdPREVIOUS"
        Me.cmdPREVIOUS.Size = New System.Drawing.Size(104, 23)
        Me.cmdPREVIOUS.TabIndex = 1
        Me.cmdPREVIOUS.Text = "PREVIOUS"
        Me.cmdPREVIOUS.UseVisualStyleBackColor = True
        '
        'cmdEXIT
        '
        Me.cmdEXIT.Location = New System.Drawing.Point(432, 533)
        Me.cmdEXIT.Name = "cmdEXIT"
        Me.cmdEXIT.Size = New System.Drawing.Size(104, 23)
        Me.cmdEXIT.TabIndex = 2
        Me.cmdEXIT.Text = "EXIT"
        Me.cmdEXIT.UseVisualStyleBackColor = True
        '
        'lblAccNo
        '
        Me.lblAccNo.AutoSize = True
        Me.lblAccNo.Location = New System.Drawing.Point(62, 58)
        Me.lblAccNo.Name = "lblAccNo"
        Me.lblAccNo.Size = New System.Drawing.Size(53, 17)
        Me.lblAccNo.TabIndex = 3
        Me.lblAccNo.Text = "Acc No"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(369, 278)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(230, 17)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "What action would you like to take?"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(228, 66)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(197, 22)
        Me.TextBox1.TabIndex = 5
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(228, 204)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(197, 22)
        Me.TextBox2.TabIndex = 6
        '
        'lblAmount
        '
        Me.lblAmount.AutoSize = True
        Me.lblAmount.Location = New System.Drawing.Point(59, 196)
        Me.lblAmount.Name = "lblAmount"
        Me.lblAmount.Size = New System.Drawing.Size(56, 17)
        Me.lblAmount.TabIndex = 7
        Me.lblAmount.Text = "Amount"
        '
        'lblCurrentBalance
        '
        Me.lblCurrentBalance.AutoSize = True
        Me.lblCurrentBalance.Location = New System.Drawing.Point(53, 127)
        Me.lblCurrentBalance.Name = "lblCurrentBalance"
        Me.lblCurrentBalance.Size = New System.Drawing.Size(110, 17)
        Me.lblCurrentBalance.TabIndex = 10
        Me.lblCurrentBalance.Text = "Current Balance"
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(228, 135)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(197, 22)
        Me.TextBox3.TabIndex = 11
        '
        'rdoDeposit
        '
        Me.rdoDeposit.AutoSize = True
        Me.rdoDeposit.Location = New System.Drawing.Point(372, 353)
        Me.rdoDeposit.Name = "rdoDeposit"
        Me.rdoDeposit.Size = New System.Drawing.Size(77, 21)
        Me.rdoDeposit.TabIndex = 12
        Me.rdoDeposit.TabStop = True
        Me.rdoDeposit.Text = "Deposit"
        Me.rdoDeposit.UseVisualStyleBackColor = True
        '
        'rdoWithdraw
        '
        Me.rdoWithdraw.AutoSize = True
        Me.rdoWithdraw.Location = New System.Drawing.Point(512, 353)
        Me.rdoWithdraw.Name = "rdoWithdraw"
        Me.rdoWithdraw.Size = New System.Drawing.Size(87, 21)
        Me.rdoWithdraw.TabIndex = 13
        Me.rdoWithdraw.TabStop = True
        Me.rdoWithdraw.Text = "Withdraw"
        Me.rdoWithdraw.UseVisualStyleBackColor = True
        '
        'lblNewBalance
        '
        Me.lblNewBalance.AutoSize = True
        Me.lblNewBalance.Location = New System.Drawing.Point(320, 444)
        Me.lblNewBalance.Name = "lblNewBalance"
        Me.lblNewBalance.Size = New System.Drawing.Size(90, 17)
        Me.lblNewBalance.TabIndex = 14
        Me.lblNewBalance.Text = "New Balance"
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(471, 439)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(178, 22)
        Me.TextBox4.TabIndex = 15
        '
        'FUNDSTRANSFER
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(968, 610)
        Me.Controls.Add(Me.TextBox4)
        Me.Controls.Add(Me.lblNewBalance)
        Me.Controls.Add(Me.rdoWithdraw)
        Me.Controls.Add(Me.rdoDeposit)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.lblCurrentBalance)
        Me.Controls.Add(Me.lblAmount)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lblAccNo)
        Me.Controls.Add(Me.cmdEXIT)
        Me.Controls.Add(Me.cmdPREVIOUS)
        Me.Controls.Add(Me.cmdCLEAR)
        Me.Name = "FUNDSTRANSFER"
        Me.Text = "FUNDS TRANSFER"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cmdCLEAR As System.Windows.Forms.Button
    Friend WithEvents cmdPREVIOUS As System.Windows.Forms.Button
    Friend WithEvents cmdEXIT As System.Windows.Forms.Button
    Friend WithEvents lblAccNo As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents lblAmount As System.Windows.Forms.Label
    Friend WithEvents lblCurrentBalance As System.Windows.Forms.Label
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents rdoDeposit As System.Windows.Forms.RadioButton
    Friend WithEvents rdoWithdraw As System.Windows.Forms.RadioButton
    Friend WithEvents lblNewBalance As System.Windows.Forms.Label
    Friend WithEvents TextBox4 As System.Windows.Forms.TextBox
End Class
