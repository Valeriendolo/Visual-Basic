<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmCONVERTER
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
        LblCONVERTER = New Label()
        BtnCONVERT = New Button()
        SuspendLayout()
        ' 
        ' LblCONVERTER
        ' 
        LblCONVERTER.AutoSize = True
        LblCONVERTER.Font = New Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        LblCONVERTER.Location = New Point(256, 56)
        LblCONVERTER.Name = "LblCONVERTER"
        LblCONVERTER.RightToLeft = RightToLeft.Yes
        LblCONVERTER.Size = New Size(402, 46)
        LblCONVERTER.TabIndex = 0
        LblCONVERTER.Text = "CURRENCY CONVERTER"
        ' 
        ' BtnCONVERT
        ' 
        BtnCONVERT.Font = New Font("Segoe UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        BtnCONVERT.Location = New Point(373, 242)
        BtnCONVERT.Name = "BtnCONVERT"
        BtnCONVERT.Size = New Size(169, 60)
        BtnCONVERT.TabIndex = 1
        BtnCONVERT.Text = "CONVERT"
        BtnCONVERT.UseVisualStyleBackColor = True
        ' 
        ' FrmCONVERTER
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(914, 547)
        Controls.Add(BtnCONVERT)
        Controls.Add(LblCONVERTER)
        Name = "FrmCONVERTER"
        Text = "CONVERTER"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents LblCONVERTER As Label
    Friend WithEvents BtnCONVERT As Button
End Class
