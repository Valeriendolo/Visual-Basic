Public Class LOGIN

    Private Sub Label2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub TextBox2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox2.TextChanged

    End Sub

    Private Sub cmdNext_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdEXIT.Click
        Close()


    End Sub

    Private Sub cmdPrevious_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdPrevious.Click
        HOME_PAGE.Show()
        Me.Hide()

    End Sub

    Private Sub cmdEnter_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdEnter.Click
        If String.IsNullOrWhiteSpace(TextBox1.Text) Then
            MsgBox("Please fill in your username!")
            TextBox1.Focus()
            Exit Sub
        End If

        If String.IsNullOrWhiteSpace(TextBox2.Text) Then
            MsgBox("Please fill in your password!")
            TextBox2.Focus()
            Exit Sub
        End If

        BANKMENU.Show()
        Me.Hide()
    End Sub


    Private passwordVisible As Boolean = False
    Private Sub cmdShow_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdShow.Click
        If passwordVisible Then
            TextBox2.PasswordChar = "*"
            cmdShow.Text = "Show Password"
        Else

            TextBox2.PasswordChar = ControlChars.NullChar
            cmdHide.Text = "Hide Password"
        End If
        passwordVisible = Not passwordVisible

    End Sub

    Private Sub cmdHide_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdHide.Click


    End Sub

    Private Sub LOGIN_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class