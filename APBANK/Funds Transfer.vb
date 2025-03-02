Public Class FUNDSTRANSFER
    Dim currentbalance As Integer = CInt(currentbalance)
    Dim Amount As Integer
    Dim NewBalance As Integer
    Private Sub Funds_Transfer_Load(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblNewBalance.Click

    End Sub

    Private Sub HScrollBar1_Scroll(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ScrollEventArgs)

    End Sub

    Private Sub TextBox3_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox3.TextChanged

    End Sub

    Private Sub TextBox4_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox4.TextChanged

    End Sub

    Private Sub rdoDeposit_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdoDeposit.CheckedChanged
        Dim currentbalance As Integer = CInt(currentbalance)
        Dim amount As Integer
        Dim newbalance As Integer

        currentbalance = TextBox3.Text
        amount = TextBox2.Text
        newbalance = currentbalance + amount


        MessageBox.Show("Your New balance Is")
        MessageBox.Show(newbalance)
    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub cmdPREVIOUS_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdPREVIOUS.Click
        BANKMENU.Show()
        Me.Hide()

    End Sub

    Private Sub cmdEXIT_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdEXIT.Click
        Close()
    End Sub

    Private Sub rdoWithdraw_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdoWithdraw.CheckedChanged
        Dim currentbalance As Integer = CInt(currentbalance)
        Dim amount As Integer
        Dim newbalance As Integer

        currentbalance = TextBox3.Text
        amount = TextBox2.Text
        newbalance = currentbalance - amount


        MessageBox.Show("Your New balance Is")
        MessageBox.Show(newbalance)
    End Sub

    Private Sub cmdNEXT_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCLEAR.Click
        TextBox1.Clear()
        TextBox2.Clear()
        TextBox3.Clear()
    End Sub
End Class