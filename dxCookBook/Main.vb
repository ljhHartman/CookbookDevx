Public Class Main



    Private Sub GridControlToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GridControlToolStripMenuItem.Click
        GridConrolForm.Show()
    End Sub

    Private Sub RibbonFromToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RibbonFromToolStripMenuItem.Click
        RibbonForm2.Show()
    End Sub


    Private Sub XtraDialogArgsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles XtraDialogArgsToolStripMenuItem.Click
        XtraDialogArgs1.Show()
    End Sub

    Private Sub XtraDialogToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles XtraDialogToolStripMenuItem.Click
        XtraDialog2.Show()
    End Sub

    Private Sub XtraDialogReturnTableToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles XtraDialogReturnTableToolStripMenuItem.Click
        XtraDialogArgsTable.Show()
    End Sub

    Private Sub GridControlFooterToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GridControlFooterToolStripMenuItem.Click
        GridControlFooter.Show()
    End Sub

    Private Sub Main_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub ViewDataSetGridToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ViewDataSetGridToolStripMenuItem.Click
        Grid2Grid.Show()
    End Sub

    Private Sub CloseTabControleActionToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CloseTabControleActionToolStripMenuItem.Click
        CloseTabControleAction.Show()
    End Sub

    Private Sub DXErrorToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DXErrorToolStripMenuItem.Click
        DXError.Show()
    End Sub

    Private Sub DXErrorNumberToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DXErrorNumberToolStripMenuItem.Click
        DXErrorNummers.Show()
    End Sub

    Private Sub MessageBoxErrorToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MessageBoxErrorToolStripMenuItem.Click
        MessageBoxError.Show()
    End Sub
End Class
