Imports System.IO
Imports System.Drawing
Imports DevExpress.XtraEditors

Public Class RenameFiles
    Dim path As String = "C:\Users\lucas.hartman\Downloads"
    Dim listViewItem As ListViewItem
    Dim fileName As String


    Private Sub RenameFiles_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Load all Folder
        For Each i In My.Computer.FileSystem.GetDirectories(path)
            ListView1.Items.Add(i.Substring(i.LastIndexOf("\") + 1), ImageList1.Images.Count() - 2)
        Next

        ' Load all Files
        For Each i In My.Computer.FileSystem.GetFiles(path)
            ListView1.Items.Add(i.Substring(i.LastIndexOf("\") + 1), ImageList1.Images.Count() - 1)
        Next
    End Sub



    Private Sub ListView1_MouseDown(sender As Object, e As MouseEventArgs) Handles ListView1.MouseDown
        ' Right click handler
        If e.Button = MouseButtons.Right Then
            listViewItem = ListView1.GetItemAt(e.X, e.Y)

            ' If an item in the ListView was selected, show Pop-up menu
            If listViewItem IsNot Nothing Then

                ' Set instance variable
                fileName = listViewItem.Text

                Console.WriteLine($"[INFO] - Right Mouse Activty: {e.X},{e.Y}, {fileName}")
                ContextMenuStrip1.Show(ListView1, e.Location)
            End If
        End If
    End Sub



    Private Sub Rename_Click(sender As Object, e As EventArgs) Handles Rename.Click
        'Open Dialog & return user input
        listViewItem.Text = XtraInputBox.Show("Rename file:", Application.CompanyName, "")

        ' Rename file on disk
        My.Computer.FileSystem.RenameFile($"{path}\{fileName}", listViewItem.Text)
        Console.WriteLine($"[INFO] - Rename: {path}\{fileName} to {listViewItem.Text}")
    End Sub
End Class