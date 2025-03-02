Public Class DELETEACCOUNT

    Private Sub Display(ByVal Text As String)
        MessageBox.Show(Text)

    End Sub

    Private Sub cmdDeactivate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtAccountNumber.TextChanged

    End Sub

    Private Sub TextBox4_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtPassword.TextChanged

    End Sub

    Private Sub cmdSubmit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSUBMIT.Click
        If String.IsNullOrWhiteSpace(txtAccountNumber.Text) Then
            MsgBox("Please fill in your Account Number!")
            txtAccountNumber.Focus()
            Exit Sub
        End If
        If String.IsNullOrWhiteSpace(txtName.Text) Then
            MsgBox("Please fill in your Name!")
            txtName.Focus()
            Exit Sub
        End If
        If txtMobileNumber.Text = "" Or txtMobileNumber.Text = "" Then
            MessageBox.Show("Please fill Mobile Number", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        'Ensure both fields are filled
        If txtPassword.Text = "" Or txtConfirmPassword.Text = "" Then
            MessageBox.Show("Password fields cannot be empty!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        ' Ensure passwords match
        If txtPassword.Text <> txtConfirmPassword.Text Then
            MessageBox.Show("Passwords do not match!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If


        HOME_PAGE.Show()
        Me.Hide()

    End Sub

    Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = True Then
            txtPassword.UseSystemPasswordChar = False
        Else
            txtPassword.UseSystemPasswordChar = True
        End If
    End Sub

    Private Sub txtConfirmPassword_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtConfirmPassword.TextChanged

    End Sub

    Private Sub CheckBox2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox2.CheckedChanged
        If CheckBox2.Checked = True Then
            txtConfirmPassword.UseSystemPasswordChar = False
        Else
            txtConfirmPassword.UseSystemPasswordChar = True
        End If
    End Sub

    Private Sub CheckBox4_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox4.CheckedChanged
        If CheckBox4.Checked Then
            Display("Account will be temporarily deactivated for 3 months")
        End If
    End Sub

    Private Sub CheckBox3_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox3.CheckedChanged

        If CheckBox3.Checked Then
            Display("Account will be deleted Permanently")

        End If
    End Sub

    Private Sub lbldeactivate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lbldeactivate.Click

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdPREVIOUS.Click
        BANKMENU.Show()
        Me.Hide()
    End Sub
End Class