<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CONTACTS
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
        Me.cmdSUBMIT = New System.Windows.Forms.Button()
        Me.lblNAME = New System.Windows.Forms.Label()
        Me.lblEMAIL = New System.Windows.Forms.Label()
        Me.lblMESSAGE = New System.Windows.Forms.Label()
        Me.TextBoxname = New System.Windows.Forms.TextBox()
        Me.TextBoxemail = New System.Windows.Forms.TextBox()
        Me.TextBoxmessage = New System.Windows.Forms.TextBox()
        Me.lblCONTACTUS = New System.Windows.Forms.Label()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'cmdSUBMIT
        '
        Me.cmdSUBMIT.BackColor = System.Drawing.Color.Red
        Me.cmdSUBMIT.Location = New System.Drawing.Point(324, 384)
        Me.cmdSUBMIT.Name = "cmdSUBMIT"
        Me.cmdSUBMIT.Size = New System.Drawing.Size(176, 43)
        Me.cmdSUBMIT.TabIndex = 0
        Me.cmdSUBMIT.Text = "SUBMIT"
        Me.cmdSUBMIT.UseVisualStyleBackColor = False
        '
        'lblNAME
        '
        Me.lblNAME.AutoSize = True
        Me.lblNAME.Location = New System.Drawing.Point(12, 74)
        Me.lblNAME.Name = "lblNAME"
        Me.lblNAME.Size = New System.Drawing.Size(55, 20)
        Me.lblNAME.TabIndex = 1
        Me.lblNAME.Text = "NAME"
        '
        'lblEMAIL
        '
        Me.lblEMAIL.AutoSize = True
        Me.lblEMAIL.Location = New System.Drawing.Point(12, 179)
        Me.lblEMAIL.Name = "lblEMAIL"
        Me.lblEMAIL.Size = New System.Drawing.Size(58, 20)
        Me.lblEMAIL.TabIndex = 2
        Me.lblEMAIL.Text = "EMAIL"
        '
        'lblMESSAGE
        '
        Me.lblMESSAGE.AutoSize = True
        Me.lblMESSAGE.Location = New System.Drawing.Point(12, 284)
        Me.lblMESSAGE.Name = "lblMESSAGE"
        Me.lblMESSAGE.Size = New System.Drawing.Size(90, 20)
        Me.lblMESSAGE.TabIndex = 3
        Me.lblMESSAGE.Text = "MESSAGE"
        '
        'TextBoxname
        '
        Me.TextBoxname.Location = New System.Drawing.Point(110, 68)
        Me.TextBoxname.Name = "TextBoxname"
        Me.TextBoxname.Size = New System.Drawing.Size(139, 26)
        Me.TextBoxname.TabIndex = 4
        '
        'TextBoxemail
        '
        Me.TextBoxemail.Location = New System.Drawing.Point(142, 176)
        Me.TextBoxemail.Name = "TextBoxemail"
        Me.TextBoxemail.Size = New System.Drawing.Size(286, 26)
        Me.TextBoxemail.TabIndex = 5
        '
        'TextBoxmessage
        '
        Me.TextBoxmessage.Location = New System.Drawing.Point(12, 307)
        Me.TextBoxmessage.Multiline = True
        Me.TextBoxmessage.Name = "TextBoxmessage"
        Me.TextBoxmessage.Size = New System.Drawing.Size(658, 26)
        Me.TextBoxmessage.TabIndex = 6
        '
        'lblCONTACTUS
        '
        Me.lblCONTACTUS.AutoSize = True
        Me.lblCONTACTUS.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCONTACTUS.Location = New System.Drawing.Point(264, 0)
        Me.lblCONTACTUS.Name = "lblCONTACTUS"
        Me.lblCONTACTUS.Size = New System.Drawing.Size(206, 32)
        Me.lblCONTACTUS.TabIndex = 7
        Me.lblCONTACTUS.Text = "CONTACT US"
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(314, 68)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(156, 26)
        Me.TextBox4.TabIndex = 8
        '
        'CONTACTS
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(862, 464)
        Me.ControlBox = False
        Me.Controls.Add(Me.TextBox4)
        Me.Controls.Add(Me.lblCONTACTUS)
        Me.Controls.Add(Me.TextBoxmessage)
        Me.Controls.Add(Me.TextBoxemail)
        Me.Controls.Add(Me.TextBoxname)
        Me.Controls.Add(Me.lblMESSAGE)
        Me.Controls.Add(Me.lblEMAIL)
        Me.Controls.Add(Me.lblNAME)
        Me.Controls.Add(Me.cmdSUBMIT)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "CONTACTS"
        Me.Text = "CONTACTS"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cmdSUBMIT As System.Windows.Forms.Button
    Friend WithEvents lblNAME As System.Windows.Forms.Label
    Friend WithEvents lblEMAIL As System.Windows.Forms.Label
    Friend WithEvents lblMESSAGE As System.Windows.Forms.Label
    Friend WithEvents TextBoxname As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxemail As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxmessage As System.Windows.Forms.TextBox
    Friend WithEvents lblCONTACTUS As System.Windows.Forms.Label
    Friend WithEvents TextBox4 As System.Windows.Forms.TextBox
End Class
