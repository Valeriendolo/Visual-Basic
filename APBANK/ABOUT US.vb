Public Class ABOUT_US

    Private Sub WebBrowser1_DocumentCompleted(ByVal sender As System.Object, ByVal e As System.Windows.Forms.WebBrowserDocumentCompletedEventArgs)

    End Sub

    Private Sub cmdEXIT_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdEXIT.Click
        Close()

    End Sub

    Private Sub ABOUT_US_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub lblCompanyinfo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblCompanyinfo.Click

    End Sub

    Private Sub cmdCONTACTUS_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCONTACTUS.Click
        CONTACTS.Show()
        Me.Hide()

    End Sub

    Private Sub cmdPrevious_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdPrevious.Click
        HOME_PAGE.Show()
        Me.Hide()


    End Sub
End Class