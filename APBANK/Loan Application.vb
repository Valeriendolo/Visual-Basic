Public Class Loan_Application

    Private Sub lblName_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblName.Click

    End Sub

    Private Sub lblTelNo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblTelNo.Click

    End Sub

    Private Sub lblIDNo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblIDNo.Click

    End Sub

    Private Sub Loan_Application_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub lblOccupation_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblOccupation.Click

    End Sub

    Private Sub lblAmount_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblAmount.Click

    End Sub

    Private Sub lblLoanTerm_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblLoanTerm.Click

    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub TextBox2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox2.TextChanged

    End Sub

    Private Sub TextBox3_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox3.TextChanged

    End Sub

    Private Sub TextBox5_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox5.TextChanged

    End Sub

    Private Sub Range_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Range.SelectedIndexChanged

    End Sub

    Private Sub TextBox4_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox4.TextChanged

    End Sub

    Private Sub cmdSubmit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSubmit.Click
        If String.IsNullOrWhiteSpace(TextBox1.Text) Then
            MsgBox("Please fill in your Name!")
            TextBox1.Focus()
            Exit Sub
        End If

        If String.IsNullOrWhiteSpace(TextBox2.Text) Then
            MessageBox.Show("Please fill in your Telephone number!")
            TextBox2.Focus()
            Exit Sub
        End If

        If String.IsNullOrWhiteSpace(TextBox3.Text) Then
            MessageBox.Show("Please fill in your ID No.!")
            TextBox3.Focus()
            Exit Sub


        End If
        If String.IsNullOrWhiteSpace(TextBox4.Text) Then
            MessageBox.Show("Please fill in your Occupation!")
            TextBox4.Focus()
            Exit Sub


        End If

        If String.IsNullOrWhiteSpace(TextBox5.Text) Then
            MessageBox.Show("Please input your desired loan term!")
            TextBox5.Focus()
            Exit Sub


        End If

        MsgBox("Loan Application successful!")
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdEXIT.Click
        Close()
    End Sub
End Class