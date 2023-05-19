Imports System.IO
Imports System.Reflection
Imports DevExpress.Utils.Helpers
Imports DevExpress.XtraGrid.Views.WinExplorer

Public Class ucFile
    Dim PrimaryCode As Integer
    Dim MainDirectory As String
    Dim SubDirectory As String
    Dim ViewStyle As WinExplorerViewStyle

    Sub New(iPrimaryCode As Integer, strParameterName As String)
        ' Initialize Design
        InitializeComponent()

        ' Initialize Pictogram Style
        ViewStyle = WinExplorerViewStyle.ExtraLarge
        Me.WinExplorerView1.OptionsView.Style = ViewStyle

        ' Initiliaze Class Variables
        PrimaryCode = iPrimaryCode
        MainDirectory = GetParameter(strParameterName) ' "INWARDFILES"
        SubDirectory = $"{MainDirectory}{PrimaryCode}\"

        ' View Files
        UpdateView()

        Me.gcAttachments.AllowDrop = True

        AddHandler gcAttachments.DragEnter, AddressOf GridControl_DragEnter
        AddHandler gcAttachments.DragDrop, AddressOf GridControl_DragDrop

        AddHandler Me.tbExtraLarge.Click, AddressOf tbExtraLarge_Click
        AddHandler Me.tbLarge.Click, AddressOf tbLarge_Click
        AddHandler Me.tbMedium.Click, AddressOf tbMedium_Click
        AddHandler Me.tbSmall.Click, AddressOf tbSmall_Click

    End Sub



#Region "Buttons"

    Private Sub tbExtraLarge_Click(sender As Object, e As EventArgs)
        Me.WinExplorerView1.OptionsView.Style = WinExplorerViewStyle.ExtraLarge
    End Sub

    Private Sub tbLarge_Click(sender As Object, e As EventArgs)
        Me.WinExplorerView1.OptionsView.Style = WinExplorerViewStyle.Large
    End Sub

    Private Sub tbMedium_Click(sender As Object, e As EventArgs)
        Me.WinExplorerView1.OptionsView.Style = WinExplorerViewStyle.Medium
    End Sub

    Private Sub tbSmall_Click(sender As Object, e As EventArgs)
        Me.WinExplorerView1.OptionsView.Style = WinExplorerViewStyle.Small
    End Sub

#End Region


#Region "Methods"

    Public Function GetParameter(ByVal strParameterName As String) As String
        ' Get main path from the database
        Debug.WriteLine(vbCrLf & $"[METHOD] - {MethodBase.GetCurrentMethod().Name}")

        Dim tba As vwParametersTableAdapters.vwParameterTableAdapter = New vwParametersTableAdapters.vwParameterTableAdapter()
        Return tba.sQryGetParameter(strParameterName)
    End Function



    Private Sub GridControl_DragEnter(sender As Object, e As DragEventArgs)
        ' Select Multiple files for the explorer and drag them to the GridControl
        Debug.WriteLine($"[METHOD] - {MethodBase.GetCurrentMethod().Name}")

        ' Drag multiple files
        e.Effect = DragDropEffects.All
    End Sub



    Private Sub GridControl_DragDrop(sender As Object, e As DragEventArgs)
        ' Drop files into the GrindControl
        Debug.WriteLine($"[METHOD] - {MethodBase.GetCurrentMethod().Name}")

        ' List of Dragged Files
        Dim files As String() = CType(e.Data.GetData(DataFormats.FileDrop), String())

        ' Create sub directory
        CreateSubDirecoty()
        Debug.WriteLine($"[INFO] - Sub Directory Path: {SubDirectory}")

        ' Iterate Dragged Files
        For Each i As String In files
            Debug.WriteLine($"[INFO] - Drop File : {i}")

            Try
                ' Copy Files To sub directory
                File.Copy(i, $"{SubDirectory}{Path.GetFileName(i)}", True)
            Catch ex As DirectoryNotFoundException
                Console.WriteLine("¯\_(^,^)_/¯ : Can't find Directory" & vbCrLf & ex.Message)
            Catch ex As Exception
                Console.WriteLine("¯\_(-.-)_/¯ : I don't even know what this is" & vbCrLf & ex.Message)
            End Try
        Next

        ' Update View
        UpdateView()
    End Sub


    Private Sub UpdateView()
        ' Update View with the current files in the sub directory
        Debug.WriteLine($"[METHOD] - {MethodBase.GetCurrentMethod().Name}")

        Dim ViewStyle As WinExplorerViewStyle = Me.WinExplorerView1.OptionsView.Style

        If Directory.Exists(SubDirectory) Then
            gcAttachments.DataSource = FileSystemHelper.GetFileSystemEntries(SubDirectory, GetItemSizeType(ViewStyle), GetItemSize(ViewStyle))

        End If



    End Sub



    Private Sub CreateSubDirecoty()
        ' Create sub directory is it not alrady exist
        Debug.WriteLine($"[METHOD] - {MethodBase.GetCurrentMethod().Name}")

        If Not Directory.Exists(SubDirectory) Then
            Dim dirInfo As DirectoryInfo = New DirectoryInfo(MainDirectory)
            dirInfo.CreateSubdirectory(PrimaryCode)
        End If
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


#End Region
End Class
