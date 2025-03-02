Public Class REGISTRATION

    Private Sub Label3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblPhoneNumber.Click

    End Sub

    Private Sub RadioButton2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdoMale.CheckedChanged

    End Sub

    Private Sub lblName_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblFullName.Click

    End Sub

    Private Sub RadioButton3_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdoPreferNotToSay.CheckedChanged

    End Sub

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblDOB.Click

    End Sub

    Private Sub Form2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        Close()
    End Sub

    Private Sub Label2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblPassword.Click

    End Sub














    Private Sub txtConfirmPassword_MaskInputRejected(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MaskInputRejectedEventArgs) Handles mtxtConfirmPassword.MaskInputRejected
        
    End Sub

    Private Sub txtFullName_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtFullName.TextChanged

    End Sub

    Private Sub rdoFemale_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdoFemale.CheckedChanged

    End Sub

    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdClear.Click
        txtFullName.Clear()
        txtEmail.Clear()
        mtxtPhoneNumber.Clear()
        mtxtPassword.Clear()
        mtxtConfirmPassword.Clear()
    End Sub

    Private Sub mtxtPassword_MaskInputRejected(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MaskInputRejectedEventArgs) Handles mtxtPassword.MaskInputRejected
        Dim mtxtPassword As New MaskedTextBox

        ' Set MaskedTextBox properties
        With mtxtPassword
            .Name = "mtxtPassword"
            .Mask = "00000000"  ' Only allows 8 digits
            .Size = New Size(150, 25)
            .PromptChar = "_" ' Underscore as placeholder
        End With

        ' Add control to the form
        Me.Controls.Add(mtxtPassword)
    End Sub


    Private Sub mtxtPhoneNumber_MaskInputRejected(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MaskInputRejectedEventArgs) Handles mtxtPhoneNumber.MaskInputRejected

        Dim mtxtPhoneNumber As New MaskedTextBox

        ' Set MaskedTextBox properties
        With mtxtPhoneNumber
            .Name = "mtxtPhoneNumber"
            .Mask = "(999) 000-000"  ' Phone Number Format
            .Size = New Size(150, 25)
        End With

        ' Add control to the form
        Me.Controls.Add(mtxtPhoneNumber)

    End Sub

    Private Sub Label2_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LblFillAllTheRequiredFields.Click

    End Sub








    Private Sub btnSubmit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSubmit.Click

        If String.IsNullOrWhiteSpace(txtFullName.Text) Then
            MsgBox("Please fill in your Full name!")
            txtFullName.Focus()
            Exit Sub
        End If

        If String.IsNullOrWhiteSpace(txtEmail.Text) Then
            MessageBox.Show("Please fill in your Email!")
            txtEmail.Focus()
            Exit Sub
        End If


        If mtxtPhoneNumber.Text = "" Or mtxtPhoneNumber.Text = "" Then
            MessageBox.Show("Please fill phone number", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        ' Ensure both fields are filled
        If mtxtPassword.Text = "" Or mtxtConfirmPassword.Text = "" Then
            MessageBox.Show("Password fields cannot be empty!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        ' Ensure passwords match
        If mtxtPassword.Text <> mtxtConfirmPassword.Text Then
            MessageBox.Show("Passwords do not match!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        MessageBox.Show("Registration Successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

        LOGIN.Show()
        Me.Hide()
    End Sub

    Private Sub CheckBox2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox2.CheckedChanged
        If CheckBox1.Checked = True Then
            mtxtConfirmPassword.UseSystemPasswordChar = False
        Else
            mtxtConfirmPassword.UseSystemPasswordChar = True
        End If
    End Sub

    Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = True Then
            mtxtPassword.UseSystemPasswordChar = False
        Else
            mtxtPassword.UseSystemPasswordChar = True
        End If
    End Sub

    Private Sub txtEmail_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtEmail.TextChanged

    End Sub
End Class