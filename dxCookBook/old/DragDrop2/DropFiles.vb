Imports System.IO
Imports System.Reflection
Imports DevExpress.Utils.Helpers

Public Class DropFiles
    Dim directory As String = "C:\Users\lucas.hartman\Local\Unsplash\Test\"

    ' 0. Create GridControl
    ' 1. Allow Drop in GridControl
    ' 1. Change View in GridControl to WinExploressView 
    ' 2. Define DragEnter Handler, for dragging files into the app
    ' 3. Define DragDrop Handler, for dropping the dragged file into the GridControl
    ' 4. View file in WinExploresView: See "Run Desinger" Columns & View 
    ' 5. Create a file copy to desination directory

    Sub New()
        InitializeComponent()

        Me.GridControl1.AllowDrop = True
        AddHandler GridControl1.DragEnter, AddressOf GridControl_DragEnter
        AddHandler GridControl1.DragDrop, AddressOf GridControl_DragDrop

        ' View directory files in GridControl
        ViewFiles()
    End Sub



    Private Sub GridControl_DragEnter(sender As Object, e As DragEventArgs)

        ' Select Multiple files for the explorer and drag them to the GridControl
        Debug.WriteLine(vbCrLf & $"[METHOD] - {MethodBase.GetCurrentMethod().Name}")

        ' Drag multiple files
        e.Effect = DragDropEffects.All
    End Sub



    Private Sub GridControl_DragDrop(sender As Object, e As DragEventArgs)

        ' Drop the Dragged files into the GrindControl
        Debug.WriteLine(vbCrLf & $"[METHOD] - {MethodBase.GetCurrentMethod().Name}")

        ' Drop Files
        Dim files As String() = CType(e.Data.GetData(DataFormats.FileDrop), String())

        ' Copy file to destination directory
        For Each f As String In files
            Debug.WriteLine($"[INFO] - Drop File : {f}")

            ' Copy Files
            Try
                File.Copy(f, directory + Path.GetFileName(f), True)
            Catch ex As DirectoryNotFoundException
                Console.WriteLine("¯\_(^,^)_/¯ : Can't find Directory" & vbCrLf & ex.Message)
            Catch ex As Exception
                Console.WriteLine("¯\_(-.-)_/¯ : I don't even know what this is" & vbCrLf & ex.Message)
            End Try
        Next

        ' Update View
        ViewFiles()
    End Sub


    Private Sub ViewFiles()
        ' Show directory files in the WinExplorerView
        Debug.WriteLine(vbCrLf & $"[METHOD] - {MethodBase.GetCurrentMethod().Name}")

        ' View directory files
        Dim iconType As IconSizeType = IconSizeType.ExtraLarge
        Dim iconSize As Size = New Size(256, 256)
        GridControl1.DataSource = FileSystemHelper.GetFileSystemEntries(directory, iconType, iconSize)

        ' Refresh view
        WinExplorerView1.RefreshData()
    End Sub

    Private Sub DropFiles_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class