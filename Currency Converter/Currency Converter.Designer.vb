<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmCURRENCYCONVERTER
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
        LblHeader = New Label()
        txtUSD = New TextBox()
        lblUSD = New Label()
        LblKsh = New Label()
        txtKshs = New TextBox()
        BtnCONVERT = New Button()
        SuspendLayout()
        ' 
        ' LblHeader
        ' 
        LblHeader.AutoSize = True
        LblHeader.Font = New Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        LblHeader.Location = New Point(163, 42)
        LblHeader.Name = "LblHeader"
        LblHeader.Size = New Size(402, 46)
        LblHeader.TabIndex = 0
        LblHeader.Text = "CURRENCY CONVERTER"
        ' 
        ' txtUSD
        ' 
        txtUSD.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtUSD.Location = New Point(302, 141)
        txtUSD.Name = "txtUSD"
        txtUSD.Size = New Size(125, 34)
        txtUSD.TabIndex = 1
        ' 
        ' lblUSD
        ' 
        lblUSD.AutoSize = True
        lblUSD.BackColor = SystemColors.Control
        lblUSD.Location = New Point(317, 118)
        lblUSD.Name = "lblUSD"
        lblUSD.Size = New Size(94, 20)
        lblUSD.TabIndex = 2
        lblUSD.Text = "US Dollar ($)"
        ' 
        ' LblKsh
        ' 
        LblKsh.AutoSize = True
        LblKsh.Location = New Point(291, 337)
        LblKsh.Name = "LblKsh"
        LblKsh.Size = New Size(147, 20)
        LblKsh.TabIndex = 3
        LblKsh.Text = "Kenyan Shilling (Ksh)"
        ' 
        ' txtKshs
        ' 
        txtKshs.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtKshs.Location = New Point(302, 360)
        txtKshs.Name = "txtKshs"
        txtKshs.Size = New Size(125, 34)
        txtKshs.TabIndex = 4
        ' 
        ' BtnCONVERT
        ' 
        BtnCONVERT.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        BtnCONVERT.Location = New Point(267, 226)
        BtnCONVERT.Name = "BtnCONVERT"
        BtnCONVERT.Size = New Size(195, 52)
        BtnCONVERT.TabIndex = 5
        BtnCONVERT.Text = "CONVERT"
        BtnCONVERT.UseVisualStyleBackColor = True
        ' 
        ' FrmCURRENCYCONVERTER
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(BtnCONVERT)
        Controls.Add(txtKshs)
        Controls.Add(LblKsh)
        Controls.Add(lblUSD)
        Controls.Add(txtUSD)
        Controls.Add(LblHeader)
        Name = "FrmCURRENCYCONVERTER"
        Text = "CURRENCY CONVERTER"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents LblHeader As Label
    Friend WithEvents txtUSD As TextBox
    Friend WithEvents lblUSD As Label
    Friend WithEvents LblKsh As Label
    Friend WithEvents txtKshs As TextBox
    Friend WithEvents BtnCONVERT As Button
End Class
