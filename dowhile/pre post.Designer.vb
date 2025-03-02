<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Lstbox = New ListBox()
        BtnLoop = New Button()
        Btnpost = New Button()
        SuspendLayout()
        ' 
        ' Lstbox
        ' 
        Lstbox.FormattingEnabled = True
        Lstbox.Location = New Point(67, 32)
        Lstbox.Name = "Lstbox"
        Lstbox.Size = New Size(655, 244)
        Lstbox.TabIndex = 0
        ' 
        ' BtnLoop
        ' 
        BtnLoop.Location = New Point(172, 334)
        BtnLoop.Name = "BtnLoop"
        BtnLoop.Size = New Size(107, 29)
        BtnLoop.TabIndex = 1
        BtnLoop.Text = "Loop"
        BtnLoop.UseVisualStyleBackColor = True
        ' 
        ' Btnpost
        ' 
        Btnpost.Location = New Point(535, 334)
        Btnpost.Name = "Btnpost"
        Btnpost.Size = New Size(102, 29)
        Btnpost.TabIndex = 2
        Btnpost.Text = "post"
        Btnpost.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(830, 450)
        Controls.Add(Btnpost)
        Controls.Add(BtnLoop)
        Controls.Add(Lstbox)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
    End Sub

    Friend WithEvents Lstbox As ListBox
    Friend WithEvents BtnLoop As Button
    Friend WithEvents Btnpost As Button

End Class
