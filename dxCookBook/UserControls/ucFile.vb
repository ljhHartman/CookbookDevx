Imports System.IO
Imports System.Reflection
Imports System.Text.RegularExpressions
Imports DevExpress.Utils.Helpers
Imports DevExpress.XtraBars
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
        ViewStyle = WinExplorerViewStyle.Large
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
        AddHandler Me.WinExplorerView1.DoubleClick, AddressOf WinExplorerView_OpenFile
    End Sub



#Region "Buttons"

    Private Sub WinExplorerView_OpenFile(ByVal sender As Object, ByVal e As Object)
        Debug.WriteLine(vbCrLf & $"--- Method : {MethodBase.GetCurrentMethod().Name} ---")
        For Each path As String In Directory.GetFiles(SubDirectory)
            Dim GetFileNameWithoutExtension = IO.Path.GetFileNameWithoutExtension(path)
            If GetFileNameWithoutExtension = WinExplorerView1.GetFocusedValue Then Process.Start(path)
        Next
    End Sub

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

    Private Sub GridControl_DragEnter(sender As Object, e As DragEventArgs)
        ' Select Multiple files for the explorer and drag them to the GridControl
        Debug.WriteLine($"[METHOD] - {MethodBase.GetCurrentMethod().Name}")

        ' Drag multiple files
        e.Effect = DragDropEffects.All
    End Sub

    Private Sub GridControl_DragDrop(sender As Object, e As DragEventArgs)
        ' Drop files into the GrindControl
        Debug.WriteLine($"[METHOD] - {MethodBase.GetCurrentMethod().Name}")

        Try
            If e.Data.GetDataPresent(DataFormats.FileDrop) Then
                ' List of Dragged Files
                Dim draggedFiles As String() = CType(e.Data.GetData(DataFormats.FileDrop), String())

                ' Create sub directory
                CreateSubDirecoty()
                Debug.WriteLine($"[INFO] - Sub Directory Path: {SubDirectory}")

                ' Iterate Dragged Files
                For Each i As String In draggedFiles
                    Debug.WriteLine($"[INFO] - Drop File : {i}")

                    ' Copy Files To sub directory
                    File.Copy(i, $"{SubDirectory}{Path.GetFileName(i)}", True)
                Next
            ElseIf e.Data.GetDataPresent("FileGroupDescriptor") Then
                DropEmail(sender, e)
            End If

        Catch ex As DirectoryNotFoundException
            Console.WriteLine("¯\_(^,^)_/¯ : Can't find Directory" & vbCrLf & ex.Message)
        Catch ex As NullReferenceException
            Console.WriteLine("¯\_('v')_/¯ : I don't get this filetype" & vbCrLf & ex.Message)
        Catch ex As Exception
            Console.WriteLine("¯\_(-.-)_/¯ : I don't even know what this is" & vbCrLf & ex.Message)
        End Try

        ' Update View
        UpdateView()
    End Sub

    Public Function GetParameter(ByVal strParameterName As String) As String
        ' Get main path from the database
        Debug.WriteLine(vbCrLf & $"[METHOD] - {MethodBase.GetCurrentMethod().Name}")

        Dim tba As vwParametersTableAdapters.vwParameterTableAdapter = New vwParametersTableAdapters.vwParameterTableAdapter()
        Return tba.sQryGetParameter(strParameterName)
    End Function

    Private Sub UpdateView()
        ' Update View with the current files in the sub directory
        Debug.WriteLine($"[METHOD] - {MethodBase.GetCurrentMethod().Name}")

        ' Get current style
        ViewStyle = Me.WinExplorerView1.OptionsView.Style

        ' Refresh View
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

    Private Sub DropEmail(sender As Object, e As DragEventArgs)
        ' Make if posible to drop Email files into the view
        Debug.WriteLine($"[METHOD] - {MethodBase.GetCurrentMethod().Name}")

        Dim mem_stream As MemoryStream = e.Data.GetData("FileGroupDescriptor")
        Dim bytes(mem_stream.Length - 1) As Byte

        mem_stream.Read(bytes, 0, mem_stream.Length)
        mem_stream.Close()
        Dim fnames$() = Nothing, sw As Boolean = False
        For f1 As Integer = 76 To (bytes.Length - 1)
            If bytes(f1) = 0 Then
                sw = False
            Else
                If Not sw Then
                    sw = True
                    If IsNothing(fnames) Then ReDim fnames(0) Else ReDim Preserve fnames(fnames.Length)
                    fnames(fnames.Length - 1) = ""
                End If
                fnames(fnames.Length - 1) &= Chr(bytes(f1))
            End If
        Next f1

        Dim sType As String = fnames(0).ToString()

        If Microsoft.VisualBasic.Strings.Right(sType, 4).ToUpper() = ".MSG" Then
            'supports a drop of a Outlook message

            ' Int Outlook Application
            Dim objOL As New Microsoft.Office.Interop.Outlook.Application

            'Dim objMI As Object - if you want to do late-binding
            Dim objMI As Microsoft.Office.Interop.Outlook.MailItem

            For Each objMI In objOL.ActiveExplorer.Selection()
                'hardcode a destination path for testing
                Dim dt As String = objMI.ReceivedTime.Year & "-" & objMI.ReceivedTime.Month & "-" & objMI.ReceivedTime.Day & "-" & objMI.ReceivedTime.Hour & "-" _
                    & objMI.ReceivedTime.Minute & "-" & objMI.ReceivedTime.Second

                Dim strFile As String =
                            IO.Path.Combine(SubDirectory, (fnEmailSubject(objMI.Subject) + "_" + dt + ".msg").Replace(":", ""))
                objMI.SaveAs(strFile)
            Next
        Else
            Dim theFile As String = SubDirectory & DateTime.Now.ToString("yyyyMMdd_HHmmss") & "_" & fnames(0).ToString()

            ' get the actual raw file into memory
            Dim ms As MemoryStream = CType(e.Data.GetData("FileContents"), MemoryStream)

            ' allocate enough bytes to hold the raw data
            Dim fileBytes(ms.Length) As Byte

            ' set starting position at first byte And read in the raw data
            ms.Position = 0
            ms.Read(fileBytes, 0, ms.Length)

            ' create a file And save the raw zip file to it
            Dim fs As FileStream = New FileStream(theFile, FileMode.Create)
            fs.Write(fileBytes, 0, fileBytes.Length)

            ' close the file
            fs.Close()
        End If
    End Sub

    Public Function fnEmailSubject(ByVal subject As String) As String
        If subject = Nothing Then
            subject = "EMPTY SUBJECT"
        Else
            subject = subject.Trim
            If subject <> "" Then
                subject = Regex.Replace(subject, ",|\.|\\|\/|\[|\]|\'|\%|\:|\;|\t|\#|\*|\<|\>|\" & Chr(34) & "|\" & Chr(47), "_")
                subject = subject.Replace("|", "_")
            End If
        End If
        Return subject
    End Function

#End Region

End Class
