<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Loan_Application
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
        Me.lblName = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.lblTelNo = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.lblIDNo = New System.Windows.Forms.Label()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.lblAmount = New System.Windows.Forms.Label()
        Me.lblLoanTerm = New System.Windows.Forms.Label()
        Me.cmdSubmit = New System.Windows.Forms.Button()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.Range = New System.Windows.Forms.ListBox()
        Me.lblOccupation = New System.Windows.Forms.Label()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.cmdEXIT = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Location = New System.Drawing.Point(65, 56)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(45, 17)
        Me.lblName.TabIndex = 0
        Me.lblName.Text = "Name"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(299, 56)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(177, 22)
        Me.TextBox1.TabIndex = 1
        '
        'lblTelNo
        '
        Me.lblTelNo.AutoSize = True
        Me.lblTelNo.Location = New System.Drawing.Point(65, 106)
        Me.lblTelNo.Name = "lblTelNo"
        Me.lblTelNo.Size = New System.Drawing.Size(50, 17)
        Me.lblTelNo.TabIndex = 2
        Me.lblTelNo.Text = "Tel No"
        Me.lblTelNo.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(299, 106)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(177, 22)
        Me.TextBox2.TabIndex = 3
        '
        'lblIDNo
        '
        Me.lblIDNo.AutoSize = True
        Me.lblIDNo.Location = New System.Drawing.Point(65, 166)
        Me.lblIDNo.Name = "lblIDNo"
        Me.lblIDNo.Size = New System.Drawing.Size(43, 17)
        Me.lblIDNo.TabIndex = 4
        Me.lblIDNo.Text = "ID No"
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(299, 161)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(177, 22)
        Me.TextBox3.TabIndex = 5
        '
        'lblAmount
        '
        Me.lblAmount.AutoSize = True
        Me.lblAmount.Location = New System.Drawing.Point(65, 317)
        Me.lblAmount.Name = "lblAmount"
        Me.lblAmount.Size = New System.Drawing.Size(56, 17)
        Me.lblAmount.TabIndex = 6
        Me.lblAmount.Text = "Amount"
        '
        'lblLoanTerm
        '
        Me.lblLoanTerm.AutoSize = True
        Me.lblLoanTerm.Location = New System.Drawing.Point(56, 447)
        Me.lblLoanTerm.Name = "lblLoanTerm"
        Me.lblLoanTerm.Size = New System.Drawing.Size(139, 17)
        Me.lblLoanTerm.TabIndex = 7
        Me.lblLoanTerm.Text = "Loan Term(In Years)"
        Me.lblLoanTerm.UseWaitCursor = True
        '
        'cmdSubmit
        '
        Me.cmdSubmit.Location = New System.Drawing.Point(732, 300)
        Me.cmdSubmit.Name = "cmdSubmit"
        Me.cmdSubmit.Size = New System.Drawing.Size(103, 34)
        Me.cmdSubmit.TabIndex = 8
        Me.cmdSubmit.Text = "Submit"
        Me.cmdSubmit.UseVisualStyleBackColor = True
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(299, 444)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(177, 22)
        Me.TextBox4.TabIndex = 9
        '
        'Range
        '
        Me.Range.FormattingEnabled = True
        Me.Range.ItemHeight = 16
        Me.Range.Items.AddRange(New Object() {"100000 - 300000", "300001 - 600000", "600001 - 900000", "900001 - 1200000", "1200001 - 1500000", "1500001 - 1800000", "1800001 - 2000000"})
        Me.Range.Location = New System.Drawing.Point(299, 294)
        Me.Range.Name = "Range"
        Me.Range.Size = New System.Drawing.Size(232, 84)
        Me.Range.TabIndex = 10
        '
        'lblOccupation
        '
        Me.lblOccupation.AutoSize = True
        Me.lblOccupation.Location = New System.Drawing.Point(65, 224)
        Me.lblOccupation.Name = "lblOccupation"
        Me.lblOccupation.Size = New System.Drawing.Size(80, 17)
        Me.lblOccupation.TabIndex = 11
        Me.lblOccupation.Text = "Occupation"
        '
        'TextBox5
        '
        Me.TextBox5.Location = New System.Drawing.Point(299, 224)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(177, 22)
        Me.TextBox5.TabIndex = 12
        '
        'cmdEXIT
        '
        Me.cmdEXIT.Location = New System.Drawing.Point(732, 376)
        Me.cmdEXIT.Name = "cmdEXIT"
        Me.cmdEXIT.Size = New System.Drawing.Size(103, 34)
        Me.cmdEXIT.TabIndex = 13
        Me.cmdEXIT.Text = "EXIT"
        Me.cmdEXIT.UseVisualStyleBackColor = True
        '
        'Loan_Application
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(873, 597)
        Me.Controls.Add(Me.cmdEXIT)
        Me.Controls.Add(Me.TextBox5)
        Me.Controls.Add(Me.lblOccupation)
        Me.Controls.Add(Me.Range)
        Me.Controls.Add(Me.TextBox4)
        Me.Controls.Add(Me.cmdSubmit)
        Me.Controls.Add(Me.lblLoanTerm)
        Me.Controls.Add(Me.lblAmount)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.lblIDNo)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.lblTelNo)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.lblName)
        Me.Name = "Loan_Application"
        Me.Text = "Loan_Application"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblName As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents lblTelNo As System.Windows.Forms.Label
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents lblIDNo As System.Windows.Forms.Label
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents lblAmount As System.Windows.Forms.Label
    Friend WithEvents lblLoanTerm As System.Windows.Forms.Label
    Friend WithEvents cmdSubmit As System.Windows.Forms.Button
    Friend WithEvents TextBox4 As System.Windows.Forms.TextBox
    Friend WithEvents Range As System.Windows.Forms.ListBox
    Friend WithEvents lblOccupation As System.Windows.Forms.Label
    Friend WithEvents TextBox5 As System.Windows.Forms.TextBox
    Friend WithEvents cmdEXIT As System.Windows.Forms.Button
End Class
