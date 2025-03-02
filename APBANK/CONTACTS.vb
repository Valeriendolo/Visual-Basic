Public Class CONTACTS

    Private Sub cmdSUBMIT_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSUBMIT.Click


        Dim name As String = TextBoxname.Text
        Dim email As String = TextBoxemail.Text()
        Dim message As String = TextBoxmessage.Text

        If String.IsNullOrEmpty(name) OrElse String.IsNullOrEmpty(email) OrElse String.IsNullOrEmpty(message) Then
            MessageBox.Show("Please fill out all fields.")
            Return
        End If

        MessageBox.Show("Form submitted successfully." & vbCrLf & "Name: {name}" & vbCrLf & "Email: {email}" & vbCrLf & "Message: {message}")

        TextBoxname.Clear()
        TextBoxemail.Clear()
        TextBoxmessage.Clear()

        HOME_PAGE.Show()
        Me.Hide()

    End Sub

    Private Sub cmdSUBMIT_Click(ByVal sender As Object, Optional ByVal p2 As Object = Nothing, Optional ByVal e As EventArgs = Nothing)
        Throw New NotImplementedException

    End Sub

    Private Sub CONTACTS_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class