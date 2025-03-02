<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmSTUDENTGRADES
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        LblSTUDENTGRADES = New Label()
        txtTest = New TextBox()
        lblGRADE = New Label()
        btnPROCESS = New Button()
        lblResult = New Label()
        SuspendLayout()
        ' 
        ' LblSTUDENTGRADES
        ' 
        LblSTUDENTGRADES.AutoSize = True
        LblSTUDENTGRADES.Font = New Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        LblSTUDENTGRADES.Location = New Point(233, 28)
        LblSTUDENTGRADES.Name = "LblSTUDENTGRADES"
        LblSTUDENTGRADES.Size = New Size(315, 46)
        LblSTUDENTGRADES.TabIndex = 0
        LblSTUDENTGRADES.Text = "STUDENT GRADES"
        ' 
        ' txtTest
        ' 
        txtTest.Location = New Point(423, 96)
        txtTest.Name = "txtTest"
        txtTest.Size = New Size(125, 27)
        txtTest.TabIndex = 1
        ' 
        ' lblGRADE
        ' 
        lblGRADE.AutoSize = True
        lblGRADE.Location = New Point(248, 100)
        lblGRADE.Name = "lblGRADE"
        lblGRADE.Size = New Size(150, 20)
        lblGRADE.TabIndex = 2
        lblGRADE.Text = "Your Overall Grade Is:"
        ' 
        ' btnPROCESS
        ' 
        btnPROCESS.Location = New Point(304, 234)
        btnPROCESS.Name = "btnPROCESS"
        btnPROCESS.Size = New Size(94, 29)
        btnPROCESS.TabIndex = 3
        btnPROCESS.Text = "PROCESS"
        btnPROCESS.UseVisualStyleBackColor = True
        ' 
        ' lblResult
        ' 
        lblResult.AutoSize = True
        lblResult.Location = New Point(423, 243)
        lblResult.Name = "lblResult"
        lblResult.Size = New Size(0, 20)
        lblResult.TabIndex = 4
        ' 
        ' FrmSTUDENTGRADES
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(lblResult)
        Controls.Add(btnPROCESS)
        Controls.Add(lblGRADE)
        Controls.Add(txtTest)
        Controls.Add(LblSTUDENTGRADES)
        Name = "FrmSTUDENTGRADES"
        Text = "Student Grades"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents LblSTUDENTGRADES As Label
    Friend WithEvents txtTest As TextBox
    Friend WithEvents lblGRADE As Label
    Friend WithEvents btnPROCESS As Button
    Friend WithEvents lblResult As Label

End Class
