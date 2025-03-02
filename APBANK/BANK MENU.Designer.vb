<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BANKMENU
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(BANKMENU))
        Me.LBLAPBANK = New System.Windows.Forms.Label()
        Me.LBLMENU = New System.Windows.Forms.Label()
        Me.cmdTRANSFERFUNDS = New System.Windows.Forms.Button()
        Me.cmdLOANAPPLICATION = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.cmdEXIT = New System.Windows.Forms.Button()
        Me.cmdMONEYMARKETFUND = New System.Windows.Forms.Button()
        Me.cmdDELETEACCOUNT = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LBLAPBANK
        '
        Me.LBLAPBANK.AutoSize = True
        Me.LBLAPBANK.Font = New System.Drawing.Font("Segoe Script", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLAPBANK.Location = New System.Drawing.Point(313, 26)
        Me.LBLAPBANK.Name = "LBLAPBANK"
        Me.LBLAPBANK.Size = New System.Drawing.Size(121, 33)
        Me.LBLAPBANK.TabIndex = 0
        Me.LBLAPBANK.Text = "AP BANK"
        '
        'LBLMENU
        '
        Me.LBLMENU.AutoSize = True
        Me.LBLMENU.BackColor = System.Drawing.Color.Indigo
        Me.LBLMENU.Font = New System.Drawing.Font("Courier New", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLMENU.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.LBLMENU.Location = New System.Drawing.Point(807, 127)
        Me.LBLMENU.Name = "LBLMENU"
        Me.LBLMENU.Size = New System.Drawing.Size(40, 16)
        Me.LBLMENU.TabIndex = 1
        Me.LBLMENU.Text = "MENU"
        '
        'cmdTRANSFERFUNDS
        '
        Me.cmdTRANSFERFUNDS.BackColor = System.Drawing.Color.Goldenrod
        Me.cmdTRANSFERFUNDS.Location = New System.Drawing.Point(751, 182)
        Me.cmdTRANSFERFUNDS.Name = "cmdTRANSFERFUNDS"
        Me.cmdTRANSFERFUNDS.Size = New System.Drawing.Size(154, 42)
        Me.cmdTRANSFERFUNDS.TabIndex = 2
        Me.cmdTRANSFERFUNDS.Text = "TRANSFER FUNDS"
        Me.cmdTRANSFERFUNDS.UseVisualStyleBackColor = False
        '
        'cmdLOANAPPLICATION
        '
        Me.cmdLOANAPPLICATION.BackColor = System.Drawing.Color.Beige
        Me.cmdLOANAPPLICATION.Location = New System.Drawing.Point(751, 253)
        Me.cmdLOANAPPLICATION.Name = "cmdLOANAPPLICATION"
        Me.cmdLOANAPPLICATION.Size = New System.Drawing.Size(154, 42)
        Me.cmdLOANAPPLICATION.TabIndex = 3
        Me.cmdLOANAPPLICATION.Text = "LOAN APPLICATION"
        Me.cmdLOANAPPLICATION.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(74, 92)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(578, 332)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 6
        Me.PictureBox1.TabStop = False
        '
        'cmdEXIT
        '
        Me.cmdEXIT.Location = New System.Drawing.Point(787, 456)
        Me.cmdEXIT.Name = "cmdEXIT"
        Me.cmdEXIT.Size = New System.Drawing.Size(75, 23)
        Me.cmdEXIT.TabIndex = 8
        Me.cmdEXIT.Text = "EXIT"
        Me.cmdEXIT.UseVisualStyleBackColor = True
        '
        'cmdMONEYMARKETFUND
        '
        Me.cmdMONEYMARKETFUND.BackColor = System.Drawing.Color.OliveDrab
        Me.cmdMONEYMARKETFUND.Location = New System.Drawing.Point(751, 317)
        Me.cmdMONEYMARKETFUND.Name = "cmdMONEYMARKETFUND"
        Me.cmdMONEYMARKETFUND.Size = New System.Drawing.Size(154, 49)
        Me.cmdMONEYMARKETFUND.TabIndex = 11
        Me.cmdMONEYMARKETFUND.Text = "MONEY MARKET FUND"
        Me.cmdMONEYMARKETFUND.UseVisualStyleBackColor = False
        '
        'cmdDELETEACCOUNT
        '
        Me.cmdDELETEACCOUNT.BackColor = System.Drawing.Color.Sienna
        Me.cmdDELETEACCOUNT.Location = New System.Drawing.Point(295, 456)
        Me.cmdDELETEACCOUNT.Name = "cmdDELETEACCOUNT"
        Me.cmdDELETEACCOUNT.Size = New System.Drawing.Size(155, 36)
        Me.cmdDELETEACCOUNT.TabIndex = 13
        Me.cmdDELETEACCOUNT.Text = "DELETE ACCOUNT"
        Me.cmdDELETEACCOUNT.UseVisualStyleBackColor = False
        '
        'BANKMENU
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.WindowFrame
        Me.ClientSize = New System.Drawing.Size(959, 531)
        Me.Controls.Add(Me.cmdDELETEACCOUNT)
        Me.Controls.Add(Me.cmdMONEYMARKETFUND)
        Me.Controls.Add(Me.cmdEXIT)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.cmdLOANAPPLICATION)
        Me.Controls.Add(Me.cmdTRANSFERFUNDS)
        Me.Controls.Add(Me.LBLMENU)
        Me.Controls.Add(Me.LBLAPBANK)
        Me.Name = "BANKMENU"
        Me.Text = "BANK MENU"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LBLAPBANK As System.Windows.Forms.Label
    Friend WithEvents LBLMENU As System.Windows.Forms.Label
    Friend WithEvents cmdTRANSFERFUNDS As System.Windows.Forms.Button
    Friend WithEvents cmdLOANAPPLICATION As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents cmdEXIT As System.Windows.Forms.Button
    Friend WithEvents cmdMONEYMARKETFUND As System.Windows.Forms.Button
    Friend WithEvents cmdDELETEACCOUNT As System.Windows.Forms.Button

End Class
