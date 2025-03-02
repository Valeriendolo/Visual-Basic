Public Class Form1
    Private Sub Lstbox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Lstbox.SelectedIndexChanged

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles BtnLoop.Click
        Dim x As Integer
        x = 6
        Do While x <= 20
            Lstbox.Items.Add(x)
            Dim v As Integer = x + 2
            x = v
        Loop

    End Sub

    Private Sub Btnpost_Click(sender As Object, e As EventArgs) Handles Btnpost.Click
        Dim x As Integer
        x = 6
        Do
            Lstbox.Items.Add(x)
            Dim v As Integer = x + 2
            x = v
        Loop While x <= 20

    End Sub
End Class
