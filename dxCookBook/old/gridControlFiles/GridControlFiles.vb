Imports System.IO
Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.Controls
Imports DevExpress.XtraEditors.Repository

Public Class GridControlFiles
    Private directory As DirectoryInfo = New DirectoryInfo("C:\Users\lucas.hartman\Downloads")
    Private selectedRowIndex As Integer
    Private selectedFilename As String


    Sub New()
        InitializeComponent()

        AddHandler Me.gcAttachments.Load, AddressOf SslDataGrid1_Load
        AddHandler Me.winExplorerView.PopupMenuShowing, AddressOf SslGridView1_PopupMenuShowing

    End Sub



#Region "UI"

    Private Sub SslDataGrid1_Load(sender As Object, e As EventArgs) Handles gcAttachments.Load
        My.Application.Log.WriteEntry($"GridControl - loads directory: {directory.ToString}")

        Dim files() As FileInfo = directory.GetFiles()
        gcAttachments.DataSource = files
    End Sub

    Private Sub SslGridView1_PopupMenuShowing(sender As Object, e As DevExpress.XtraGrid.Views.Grid.PopupMenuShowingEventArgs)
        My.Application.Log.WriteEntry("GridControl - right mouse click handler")

        ' Show pop-up menu if a row is selected
        If e.MenuType = DevExpress.XtraGrid.Views.Grid.GridMenuType.Row Then
            selectedRowIndex = winExplorerView.GetSelectedRows(0)
            selectedFilename = winExplorerView.GetRowCellValue(selectedRowIndex, "Name").ToString

            My.Application.Log.WriteEntry($"Right mouse click - Show pop-up menu on the selected filename: {selectedFilename}")

            ' Pop-up Menu item handler
            Dim rename As New DevExpress.Utils.Menu.DXMenuItem("Rename", AddressOf Rename_Click)
            e.Menu.Items.Add(rename)
        End If
    End Sub

    Private Sub Rename_Click(sender As Object, e As EventArgs)
        My.Application.Log.WriteEntry($"Pop-up Menu, Item Handler - Open MessageBox for renaming the selected file")

        'Open Dialog & return user input
        Dim newFilename = XtraInputBox.Show("Rename file:", Application.CompanyName, "")


        ' Rename file on disk
        Try
            Dim filetype = Path.GetExtension($"{directory}\{selectedFilename}")
            My.Application.Log.WriteEntry($"FileSystem - get filetype: {filetype}")

            If (newFilename IsNot "") Then
                My.Computer.FileSystem.RenameFile($"{directory}\{selectedFilename}", $"{newFilename}{filetype}")
                My.Application.Log.WriteEntry($"FileSystem - renamed file {selectedFilename} to {newFilename}{filetype}")

                ' Refresh Gridview
                'SslGridView1.RefreshRow(selectedRowIndex)
                'SslGridView1.RefreshData()
                'SslGridView1.RefreshRow(SslGridView1.FocusedRowHandle)

                'SslGridView1.OptionsBehavior.Editable = True
                'SslGridView1.SetRowCellValue(selectedRowIndex, "Name", $"{newFilename}{filetype}")
                'SslGridView1.OptionsBehavior.Editable = False


            End If
        Catch ex As ArgumentNullException
            My.Application.Log.WriteEntry($"ArgumentNullException: No new filename was given")

        End Try
    End Sub

#End Region

End Class