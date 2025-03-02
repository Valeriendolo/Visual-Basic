Public Class FrmSTUDENTGRADES
    Private Sub BtnPROCESS_Click(sender As Object, e As EventArgs) Handles btnPROCESS.Click
        Dim score As Integer
        score = txtTest.Text

        Select Case score

            Case 0 To 49
                lblResult.Text = "Fail"
            Case 50 To 64
                lblResult.Text = "Pass"
            Case 65 To 74
                lblResult.Text = "Credit"
            Case 75 To 100
                lblResult.Text = "Distinction"
            Case Else
                lblResult.Text = "Invalid"

        End Select
    End Sub
End Class
