Public Class FrmCURRENCYCONVERTER
    ' Conversion Factor
    Dim factor As Double = 90.0
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub LblHeader_Click(sender As Object, e As EventArgs) Handles LblHeader.Click

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles lblUSD.Click

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles LblKsh.Click

    End Sub

    Private Sub BtnCONVERT_Click(sender As Object, e As EventArgs) Handles BtnCONVERT.Click

        If IsNumeric(txtUSD.Text) Then
            ' Convert the value and store it in a variable
            Dim USD As Double = CDbl(txtUSD.Text)
            Dim Kshs As Double = Convert(USD, 2)

            ' Display the converted value
            txtKshs.Text = Kshs.ToString("N2")
            MessageBox.Show("The equivalent amount in Kenya Shillings is: " & Kshs.ToString("N2") & " Kshs", "Conversion Result")
        Else
            ' Show error message if input is not a valid number
            MessageBox.Show("Please enter a valid numerical amount.", "Invalid Input")
        End If
    End Sub
    Function Convert(amt As Double)
        Return Math.Round(amt * factor, 2)
    End Function

    Function Convert(amt As Double, places As Integer) As Double
        Return Math.Round(amt * factor, places)
    End Function


    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles txtKshs.TextChanged

    End Sub
End Class