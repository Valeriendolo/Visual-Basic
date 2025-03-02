<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ABOUT_US
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ABOUT_US))
        Me.cmdEXIT = New System.Windows.Forms.Button()
        Me.lblCompanyinfo = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.cmdCONTACTUS = New System.Windows.Forms.Button()
        Me.cmdPrevious = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmdEXIT
        '
        Me.cmdEXIT.BackColor = System.Drawing.Color.Red
        Me.cmdEXIT.Location = New System.Drawing.Point(972, 457)
        Me.cmdEXIT.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cmdEXIT.Name = "cmdEXIT"
        Me.cmdEXIT.Size = New System.Drawing.Size(99, 38)
        Me.cmdEXIT.TabIndex = 0
        Me.cmdEXIT.Text = "EXIT"
        Me.cmdEXIT.UseVisualStyleBackColor = False
        '
        'lblCompanyinfo
        '
        Me.lblCompanyinfo.AutoSize = True
        Me.lblCompanyinfo.Font = New System.Drawing.Font("Microsoft YaHei UI", 16.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCompanyinfo.ForeColor = System.Drawing.Color.Firebrick
        Me.lblCompanyinfo.Location = New System.Drawing.Point(467, 9)
        Me.lblCompanyinfo.Name = "lblCompanyinfo"
        Me.lblCompanyinfo.Size = New System.Drawing.Size(338, 36)
        Me.lblCompanyinfo.TabIndex = 1
        Me.lblCompanyinfo.Text = "WELCOME TO AP BANK"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(50, 326)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(519, 51)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = resources.GetString("Label1.Text")
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(37, 62)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(1184, 255)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = resources.GetString("Label2.Text")
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(602, 184)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(152, 133)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 4
        Me.PictureBox1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(948, 184)
        Me.PictureBox2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(152, 133)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 5
        Me.PictureBox2.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(777, 184)
        Me.PictureBox3.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(148, 133)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 6
        Me.PictureBox3.TabStop = False
        '
        'cmdCONTACTUS
        '
        Me.cmdCONTACTUS.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.cmdCONTACTUS.Location = New System.Drawing.Point(741, 457)
        Me.cmdCONTACTUS.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cmdCONTACTUS.Name = "cmdCONTACTUS"
        Me.cmdCONTACTUS.Size = New System.Drawing.Size(118, 37)
        Me.cmdCONTACTUS.TabIndex = 7
        Me.cmdCONTACTUS.Text = "CONTACT US"
        Me.cmdCONTACTUS.UseVisualStyleBackColor = False
        '
        'cmdPrevious
        '
        Me.cmdPrevious.Location = New System.Drawing.Point(40, 458)
        Me.cmdPrevious.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cmdPrevious.Name = "cmdPrevious"
        Me.cmdPrevious.Size = New System.Drawing.Size(129, 36)
        Me.cmdPrevious.TabIndex = 8
        Me.cmdPrevious.Text = "Previous"
        Me.cmdPrevious.UseVisualStyleBackColor = True
        '
        'ABOUT_US
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1258, 540)
        Me.ControlBox = False
        Me.Controls.Add(Me.cmdPrevious)
        Me.Controls.Add(Me.cmdCONTACTUS)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblCompanyinfo)
        Me.Controls.Add(Me.cmdEXIT)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "ABOUT_US"
        Me.Text = "ABOUT_US"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cmdEXIT As System.Windows.Forms.Button
    Friend WithEvents lblCompanyinfo As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents cmdCONTACTUS As System.Windows.Forms.Button
    Friend WithEvents cmdPrevious As System.Windows.Forms.Button
End Class
