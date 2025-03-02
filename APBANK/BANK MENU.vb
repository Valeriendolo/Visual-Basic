Public Class BANKMENU

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdTRANSFERFUNDS.Click

        FUNDSTRANSFER.Show()
        Me.Hide()

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdLOANAPPLICATION.Click
        Dim loanapplication As New FUNDSTRANSFER

        Loan_Application.ShowDialog()
        Me.Hide()

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub cmdEXIT_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdEXIT.Click
        Close()
    End Sub

    Private Sub LBLMENU_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LBLMENU.Click

    End Sub

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub cmdMONEYMARKETFUND_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdMONEYMARKETFUND.Click

    End Sub

    Private Sub Button2_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdDELETEACCOUNT.Click
        DELETEACCOUNT.Show()
        Me.Hide()
    End Sub

    Private Sub cmdCONTACTUS_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        CONTACTS.Show()
        Me.Hide()
    End Sub

    Private Sub Button3_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
End Class