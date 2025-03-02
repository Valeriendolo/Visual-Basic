Public Class HOME_PAGE

    Private Sub Label2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lbWELCOME.Click

    End Sub

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblDonthaveanaccount.Click

    End Sub

    Private Sub HOME_PAGE_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub cmdSIGNUP_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSIGNUP.Click
        REGISTRATION.Show()
        Me.Hide()

    End Sub

    Private Sub cmdLOGIN_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdLOGIN.Click
        LOGIN.Show()
        Me.Hide()
    End Sub

    Private Sub cmdEXIT_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdEXIT.Click
        Close()

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdABOUTUS.Click
        ABOUT_US.Show()
        Me.Hide()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCONTACTUS.Click
        CONTACTS.Show()
        Me.Hide()
    End Sub
End Class