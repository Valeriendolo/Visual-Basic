Public Class FrmCONVERTER
    ' Conversion Factor
    Dim factor As Double = 90.0

    Private Sub BtnCONVERT_Click(sender As Object, e As EventArgs) Handles BtnCONVERT.Click
        Dim USD As Double
        Dim Kshs As Double


        USD = InputBox("Enter Amount In USD", "USD Converter",)

        Kshs = USD * factor

        MessageBox.Show("The equivalent amount in Kenya Shillings is: Kshs " & Kshs.ToString("N2"), "Conversion Result")
    End Sub

End Class