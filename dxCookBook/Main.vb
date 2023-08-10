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

    Private Sub InputBoxAutocompleteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InputBoxAutocompleteToolStripMenuItem.Click
        InputBoxAutocomplete.Show()
    End Sub

    Private Sub ChartControlToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ChartControlToolStripMenuItem.Click
        ChartForm.Show()
    End Sub

    Private Sub RowClickToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RowClickToolStripMenuItem.Click
        ClickRow.Show()
    End Sub

    Private Sub UploadImageToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UploadImageToolStripMenuItem.Click
        uploadImage.Show()
    End Sub

    Private Sub ToolStripDropDownButton1_Click(sender As Object, e As EventArgs) Handles ToolStripDropDownButton1.Click

    End Sub

    Private Sub ToolStripButton2_Click(sender As Object, e As EventArgs) Handles ToolStripButton2.Click
        AddRowDataGrid.Show()
    End Sub

    Private Sub ManualUIToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ManualUIToolStripMenuItem.Click
        Dim myControl As New ucManual()
        DevExpress.XtraEditors.XtraDialog.Show(myControl, "Manual", MessageBoxButtons.OK)
    End Sub

    Private Sub FlyoutPanelToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FlyoutPanelToolStripMenuItem.Click
        FlyoutPanel.Show()
    End Sub

    Private Sub DragDropToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DragDropToolStripMenuItem.Click
        FormDragDrop2.Show()
    End Sub


    Private Sub UcDragDropToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UcDragDropToolStripMenuItem.Click
        Dim uc As New ucFileManager(0, "INWARDFILES")
        DevExpress.XtraEditors.XtraDialog.Show(uc, "Manual", MessageBoxButtons.OK)
    End Sub

    Private Sub ComboBoxToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ComboBoxToolStripMenuItem.Click
        ComboBox.Show()
    End Sub

    Private Sub GetFromTabToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GetFromTabToolStripMenuItem.Click
        GetFromTab.Show()
    End Sub

    Private Sub MoveFilesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MoveFilesToolStripMenuItem.Click
        MoveFiles.Show()
    End Sub

    Private Sub RenameFileToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RenameFileToolStripMenuItem.Click
        RenameFiles.Show()
    End Sub
End Class
