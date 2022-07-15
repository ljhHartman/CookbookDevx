Public Class Main



    Private Sub GridControlToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GridControlToolStripMenuItem.Click
        GridConrolForm.Show()
    End Sub

    Private Sub RibbonFromToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RibbonFromToolStripMenuItem.Click
        RibbonForm2.Show()
    End Sub

    Private Sub Main_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub XtraDialogArgsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles XtraDialogArgsToolStripMenuItem.Click
        XtraDialogArgs1.Show()
    End Sub
End Class
