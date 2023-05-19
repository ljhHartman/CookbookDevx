Imports System.Reflection
Imports DevExpress.Utils.Helpers
Imports DevExpress.XtraGrid.Views.WinExplorer

Public Class FormDragDrop2

    ' 0. Create GridControl
    ' 1. Allow Drop in GridControl
    ' 1. Change View in GridControl to WinExploressView 
    ' 2. Define DragEnter Handler, for dragging files into the app
    ' 3. Define DragDrop Handler, for dropping the dragged file into the GridControl


    Sub New()
        InitializeComponent()

        Me.GridControlAttachment.AllowDrop = True
        AddHandler GridControlAttachment.DragEnter, AddressOf GridControl_DragEnter
        AddHandler GridControlAttachment.DragDrop, AddressOf GridControl_DragDrop


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

        ' Print Dropped Files
        For Each file As String In files
            Debug.WriteLine($"[INFO] - Drop File : {file}")
        Next

    End Sub














    Private Sub UpdateView()

        GridControlAttachment.DataSource = FileSystemHelper.GetFileSystemEntries("C:\Development\Ship_Handling_System_SSLv5\SSL\Resources\", GetItemSizeType(ViewStyle), GetItemSize(ViewStyle))

        WinExplorerView1.RefreshData()
        'EnsureSearchEdit()
        BeginInvoke(New MethodInvoker(AddressOf WinExplorerView1.ClearSelection))
    End Sub

    Private Function GetItemSize(ByVal viewStyle As WinExplorerViewStyle) As Size
        Select Case viewStyle
            Case WinExplorerViewStyle.ExtraLarge
                Return New Size(256, 256)
            Case WinExplorerViewStyle.Large
                Return New Size(96, 96)
            Case WinExplorerViewStyle.Content
                Return New Size(32, 32)
            Case WinExplorerViewStyle.Small
                Return New Size(16, 16)
            Case Else
                Return New Size(96, 96)
        End Select
    End Function

    Private Function GetItemSizeType(ByVal viewStyle As WinExplorerViewStyle) As IconSizeType
        Select Case viewStyle
            Case WinExplorerViewStyle.Large, WinExplorerViewStyle.ExtraLarge
                Return IconSizeType.ExtraLarge
            Case WinExplorerViewStyle.List, WinExplorerViewStyle.Small
                Return IconSizeType.Small
            Case WinExplorerViewStyle.Tiles, WinExplorerViewStyle.Medium, WinExplorerViewStyle.Content
                Return IconSizeType.Large
            Case Else
                Return IconSizeType.ExtraLarge
        End Select
    End Function

    Private Function GetSelectedEntries() As List(Of FileSystemEntry)
        Return GetSelectedEntries(False)
    End Function

    Private Function GetSelectedEntries(ByVal sort As Boolean) As List(Of FileSystemEntry)
        Dim list As New List(Of FileSystemEntry)()
        Dim rows() As Integer = WinExplorerView1.GetSelectedRows()
        For i As Integer = 0 To rows.Length - 1
            list.Add(CType(WinExplorerView1.GetRow(rows(i)), FileSystemEntry))
        Next i
        If sort Then
            list.Sort(New FileSytemEntryComparer())
        End If
        Return list
    End Function

    Public ReadOnly Property ViewStyle As WinExplorerViewStyle
        Get
            Return Me.WinExplorerView1.OptionsView.Style
        End Get
    End Property

    Private Sub UpdatePath(ByVal path As String)
    End Sub

    Private Sub FormDragDrop_Load(sender As Object, e As EventArgs) Handles Me.Load
        UpdateView()
    End Sub
End Class