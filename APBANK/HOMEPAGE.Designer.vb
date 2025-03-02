<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class HOME_PAGE
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(HOME_PAGE))
        Me.lblAPBANK = New System.Windows.Forms.Label()
        Me.lbWELCOME = New System.Windows.Forms.Label()
        Me.cmdSIGNUP = New System.Windows.Forms.Button()
        Me.cmdLOGIN = New System.Windows.Forms.Button()
        Me.cmdEXIT = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.lblDonthaveanaccount = New System.Windows.Forms.Label()
        Me.lblHaveanaccount = New System.Windows.Forms.Label()
        Me.cmdABOUTUS = New System.Windows.Forms.Button()
        Me.cmdCONTACTUS = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblAPBANK
        '
        Me.lblAPBANK.AutoSize = True
        Me.lblAPBANK.Font = New System.Drawing.Font("Copperplate Gothic Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAPBANK.ForeColor = System.Drawing.SystemColors.Window
        Me.lblAPBANK.Location = New System.Drawing.Point(349, 20)
        Me.lblAPBANK.Name = "lblAPBANK"
        Me.lblAPBANK.Size = New System.Drawing.Size(111, 23)
        Me.lblAPBANK.TabIndex = 0
        Me.lblAPBANK.Text = "AP BANK"
        '
        'lbWELCOME
        '
        Me.lbWELCOME.AutoSize = True
        Me.lbWELCOME.Font = New System.Drawing.Font("Microsoft YaHei UI", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbWELCOME.ForeColor = System.Drawing.SystemColors.Info
        Me.lbWELCOME.Location = New System.Drawing.Point(327, 200)
        Me.lbWELCOME.Name = "lbWELCOME"
        Me.lbWELCOME.Size = New System.Drawing.Size(142, 31)
        Me.lbWELCOME.TabIndex = 1
        Me.lbWELCOME.Text = "WELCOME"
        '
        'cmdSIGNUP
        '
        Me.cmdSIGNUP.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.cmdSIGNUP.ForeColor = System.Drawing.SystemColors.Info
        Me.cmdSIGNUP.Location = New System.Drawing.Point(361, 272)
        Me.cmdSIGNUP.Name = "cmdSIGNUP"
        Me.cmdSIGNUP.Size = New System.Drawing.Size(75, 23)
        Me.cmdSIGNUP.TabIndex = 2
        Me.cmdSIGNUP.Text = "SIGN UP"
        Me.cmdSIGNUP.UseVisualStyleBackColor = False
        '
        'cmdLOGIN
        '
        Me.cmdLOGIN.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.cmdLOGIN.ForeColor = System.Drawing.Color.Teal
        Me.cmdLOGIN.Location = New System.Drawing.Point(361, 355)
        Me.cmdLOGIN.Name = "cmdLOGIN"
        Me.cmdLOGIN.Size = New System.Drawing.Size(75, 23)
        Me.cmdLOGIN.TabIndex = 3
        Me.cmdLOGIN.Text = "LOG IN"
        Me.cmdLOGIN.UseVisualStyleBackColor = False
        '
        'cmdEXIT
        '
        Me.cmdEXIT.Location = New System.Drawing.Point(607, 428)
        Me.cmdEXIT.Name = "cmdEXIT"
        Me.cmdEXIT.Size = New System.Drawing.Size(75, 23)
        Me.cmdEXIT.TabIndex = 4
        Me.cmdEXIT.Text = "EXIT"
        Me.cmdEXIT.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(41, 46)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(725, 135)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 5
        Me.PictureBox1.TabStop = False
        '
        'lblDonthaveanaccount
        '
        Me.lblDonthaveanaccount.AutoSize = True
        Me.lblDonthaveanaccount.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDonthaveanaccount.ForeColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.lblDonthaveanaccount.Location = New System.Drawing.Point(319, 252)
        Me.lblDonthaveanaccount.Name = "lblDonthaveanaccount"
        Me.lblDonthaveanaccount.Size = New System.Drawing.Size(158, 17)
        Me.lblDonthaveanaccount.TabIndex = 6
        Me.lblDonthaveanaccount.Text = "Don't have an account?"
        '
        'lblHaveanaccount
        '
        Me.lblHaveanaccount.AutoSize = True
        Me.lblHaveanaccount.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHaveanaccount.ForeColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.lblHaveanaccount.Location = New System.Drawing.Point(337, 335)
        Me.lblHaveanaccount.Name = "lblHaveanaccount"
        Me.lblHaveanaccount.Size = New System.Drawing.Size(123, 17)
        Me.lblHaveanaccount.TabIndex = 7
        Me.lblHaveanaccount.Text = "Have an account?"
        '
        'cmdABOUTUS
        '
        Me.cmdABOUTUS.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.cmdABOUTUS.Location = New System.Drawing.Point(122, 428)
        Me.cmdABOUTUS.Name = "cmdABOUTUS"
        Me.cmdABOUTUS.Size = New System.Drawing.Size(89, 23)
        Me.cmdABOUTUS.TabIndex = 8
        Me.cmdABOUTUS.Text = "ABOUT US"
        Me.cmdABOUTUS.UseVisualStyleBackColor = False
        '
        'cmdCONTACTUS
        '
        Me.cmdCONTACTUS.BackColor = System.Drawing.Color.LavenderBlush
        Me.cmdCONTACTUS.Location = New System.Drawing.Point(340, 428)
        Me.cmdCONTACTUS.Name = "cmdCONTACTUS"
        Me.cmdCONTACTUS.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.cmdCONTACTUS.Size = New System.Drawing.Size(120, 23)
        Me.cmdCONTACTUS.TabIndex = 9
        Me.cmdCONTACTUS.Text = "CONTACT US"
        Me.cmdCONTACTUS.UseVisualStyleBackColor = False
        '
        'HOME_PAGE
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkSlateGray
        Me.ClientSize = New System.Drawing.Size(806, 494)
        Me.Controls.Add(Me.cmdCONTACTUS)
        Me.Controls.Add(Me.cmdABOUTUS)
        Me.Controls.Add(Me.lblHaveanaccount)
        Me.Controls.Add(Me.lblDonthaveanaccount)
        Me.Controls.Add(Me.cmdEXIT)
        Me.Controls.Add(Me.cmdLOGIN)
        Me.Controls.Add(Me.cmdSIGNUP)
        Me.Controls.Add(Me.lbWELCOME)
        Me.Controls.Add(Me.lblAPBANK)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "HOME_PAGE"
        Me.Text = "HOME_PAGE"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblAPBANK As System.Windows.Forms.Label
    Friend WithEvents lbWELCOME As System.Windows.Forms.Label
    Friend WithEvents cmdSIGNUP As System.Windows.Forms.Button
    Friend WithEvents cmdLOGIN As System.Windows.Forms.Button
    Friend WithEvents cmdEXIT As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents lblDonthaveanaccount As System.Windows.Forms.Label
    Friend WithEvents lblHaveanaccount As System.Windows.Forms.Label
    Friend WithEvents cmdABOUTUS As System.Windows.Forms.Button
    Friend WithEvents cmdCONTACTUS As System.Windows.Forms.Button
End Class
