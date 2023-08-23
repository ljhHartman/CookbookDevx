Imports System.ComponentModel
Imports System.IO
Imports System.Reflection
Imports System.Text.RegularExpressions
Imports DevExpress.Utils.Drawing
Imports DevExpress.Utils.Helpers
Imports DevExpress.XtraEditors
Imports DevExpress.XtraGrid
Imports DevExpress.XtraGrid.Columns
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraGrid.Views.WinExplorer


Public Class BaseForm
    Private Sub BaseForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

#Region " Classes"


    Class FileManagerView
        Implements IFileSystemNavigationSupports
        Property formID As Integer
        Property formReadOnly As Boolean = True
        Private root As String = "C:\Users\lucas.hartman\Downloads"
        Private formDirectory
        Private gc As sslDataGrid.sslDataGrid
        Private WithEvents wv As WinExplorerView = New WinExplorerView()
        Private cms As ContextMenuStrip = New ContextMenuStrip()
        Private WithEvents cmsItemRename As New ToolStripMenuItem()
        Private WithEvents cmsItemSmall As New ToolStripMenuItem()
        Private WithEvents cmsItemMedium As New ToolStripMenuItem()
        Private WithEvents cmsItemLarge As New ToolStripMenuItem()
        Private WithEvents cmsItemXL As New ToolStripMenuItem()
        Private WithEvents cmsItemCopyTo As New ToolStripMenuItem()
        Private WithEvents cmsItemOpen As New ToolStripMenuItem()

        Sub New(ByRef pFileSystem As sslDataGrid.sslDataGrid, ByRef pReadOnly As Boolean, Optional ByVal pID As Integer = Nothing)
            gc = pFileSystem
            formID = pID
            formReadOnly = pReadOnly
            formDirectory = $"{root}\{formID}"

            InitializeWinExplorerView()
            InitializeContextMenuStrip()

            AddHandler Me.wv.Click, AddressOf WinExplorerView_RightClick
            AddHandler Me.cmsItemRename.Click, AddressOf cmsItemRename_Click
            AddHandler Me.cmsItemSmall.Click, AddressOf cmsItemSmall_Click
            AddHandler Me.cmsItemMedium.Click, AddressOf cmsItemMedium_Click
            AddHandler Me.cmsItemLarge.Click, AddressOf cmsItemLarge_Click
            AddHandler Me.cmsItemXL.Click, AddressOf cmsItemXL_Click
            AddHandler Me.cmsItemCopyTo.Click, AddressOf cmsItemCopyTo_Click
            AddHandler Me.cmsItemOpen.Click, AddressOf cmsItemOpen_Click
            AddHandler Me.wv.DoubleClick, AddressOf cmsItemOpen_Click
            AddHandler Me.gc.DragEnter, AddressOf GridControl_DragEnter
            AddHandler Me.gc.DragDrop, AddressOf GridControl_DragDrop
        End Sub



#Region "Initializers"

        Private Sub InitializeWinExplorerView()
            Print($"Declare Columns and Setting,")

            ' Declare Columns
            Dim colName As New GridColumn() With {
                .Caption = "columnName",
                .Visible = True,
                .VisibleIndex = 0,
                .FieldName = "Name",
                .Name = "columnName"
            }
            Dim colPath As New GridColumn() With {
                .Caption = "columnPath",
                .Visible = True,
                .VisibleIndex = 0,
                .FieldName = "Path",
                .Name = "columnPath"
            }
            Dim colCheck As New GridColumn() With {
                .Caption = "columnCheck",
                .Visible = True,
                .VisibleIndex = 0,
                .FieldName = "IsCheck",
                .Name = "columnCheck"
            }
            Dim colGroup As New GridColumn() With {
                .Caption = "columnGroup",
                .Visible = True,
                .VisibleIndex = 0,
                .FieldName = "Group",
                .Name = "columnGroup"
            }
            Dim colImage As New GridColumn() With {
                .Caption = "columnImage",
                .Visible = True,
                .VisibleIndex = 0,
                .FieldName = "Image",
                .Name = "columnImage"
            }

            ' WinExplorerView settings
            wv.Columns.Add(colName)
            wv.Columns.Add(colPath)
            wv.Columns.Add(colCheck)
            wv.Columns.Add(colGroup)
            wv.Columns.Add(colImage)

            wv.ColumnSet.CheckBoxColumn = colCheck
            wv.ColumnSet.DescriptionColumn = colPath
            wv.ColumnSet.ExtraLargeImageColumn = colImage
            wv.ColumnSet.LargeImageColumn = colImage
            wv.ColumnSet.MediumImageColumn = colImage
            wv.ColumnSet.SmallImageColumn = colImage
            wv.ColumnSet.TextColumn = colName

            wv.OptionsSelection.AllowMarqueeSelection = True
            wv.OptionsSelection.ItemSelectionMode = IconItemSelectionMode.Click
            wv.OptionsSelection.MultiSelect = True

            wv.OptionsView.ImageLayoutMode = ImageLayoutMode.Stretch
            wv.OptionsView.Style = WinExplorerViewStyle.Small
            wv.OptionsView.ShowViewCaption = True

            ' GridControl settings
            gc.MainView = wv
            gc.AllowDrop = formReadOnly

            If Not IsNothing(formID) And Directory.Exists(formDirectory) Then
                Print($"Get Files from Directory")
                gc.DataSource = FileSystemHelper.GetFileSystemEntries(formDirectory, GetItemSizeType(wv.OptionsView.Style), GetItemSize(wv.OptionsView.Style))
            End If
        End Sub

        Private Sub InitializeContextMenuStrip()
            Print($"Build & add menu items")

            ' Menu Items Settings
            cmsItemRename.Name = "Rename"
            cmsItemRename.Text = "Rename"

            cmsItemSmall.Name = "Small"
            cmsItemSmall.Text = "Small"

            cmsItemMedium.Name = "Medium"
            cmsItemMedium.Text = "Medium"

            cmsItemLarge.Name = "Large"
            cmsItemLarge.Text = "Large"

            cmsItemXL.Name = "ExtraLarge"
            cmsItemXL.Text = "Extra Large"

            cmsItemCopyTo.Name = "CopyTo"
            cmsItemCopyTo.Text = "Copy to"

            cmsItemOpen.Name = "Open"
            cmsItemOpen.Text = "Open"

            ' Add Menu items to ContextMenuStrip
            cms.Items.Add(cmsItemOpen)
            cms.Items.Add(cmsItemSmall)
            cms.Items.Add(cmsItemMedium)
            cms.Items.Add(cmsItemLarge)
            cms.Items.Add(cmsItemXL)
            cms.Items.Add(cmsItemCopyTo)
            cms.Items.Add(cmsItemRename)
        End Sub

#End Region



#Region "Handlers"

        Private Sub GridControl_DragDrop(sender As Object, e As DragEventArgs)
            Print($"Drag and drop handler")

            If IsNothing(formID) Or formID <> 0 Then

                ' Set for Directory
                formDirectory = $"{root}\{formID}"

                ' Create directory
                If Not Directory.Exists(formDirectory) Then Directory.CreateDirectory(formDirectory)

                ' Drop File into WinExplorerView
                Try
                    If e.Data.GetDataPresent(DataFormats.FileDrop) Then
                        ' List of Dragged Files
                        Dim draggedFiles As String() = CType(e.Data.GetData(DataFormats.FileDrop), String())

                        ' Copy file to form directory
                        For Each i As String In draggedFiles

                            File.Copy(i, $"{formDirectory}\{Path.GetFileName(i)}", True)
                        Next

                    ElseIf e.Data.GetDataPresent("FileGroupDescriptor") Then
                        DropEmail(sender, e)
                    End If

                Catch ex As DirectoryNotFoundException
                    Print($"¯\_(^,^)_/¯ : Can't find Directory" & vbCrLf & ex.Message)
                Catch ex As NullReferenceException
                    Print($"¯\_('v')_/¯ : I don't get this filetype" & vbCrLf & ex.Message)
                Catch ex As Exception
                    Print($"¯\_(-.-)_/¯ : I don't even know what this is" & vbCrLf & ex.Message)
                End Try

                ' Update View
                ClearView()
                InitializeWinExplorerView()
            Else
                MsgBox($"Form must be saved, before you can drop any files.")
            End If
        End Sub

        Private Sub DropEmail(sender As Object, e As DragEventArgs)
            Print($"Enable Email Drag & Drop")

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
                            IO.Path.Combine(formDirectory, (fnEmailSubject(objMI.Subject) + "_" + dt + ".msg").Replace(":", ""))
                    objMI.SaveAs(strFile)
                Next
            Else
                Dim theFile As String = formDirectory & DateTime.Now.ToString("yyyyMMdd_HHmmss") & "_" & fnames(0).ToString()

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

        Private Sub GridControl_DragEnter(sender As Object, e As DragEventArgs)
            If formReadOnly Then
                Print($"Drag Enter handler")
                e.Effect = DragDropEffects.All
            Else
                MsgBox("WARNING: can't drag files when in read only mode")
            End If
        End Sub

        Private Sub cmsItemOpen_Click(sender As Object, e As EventArgs)
            Print($"Open file handler")
            ' Get selected files from WinExplorerView
            Dim selectedRows() As Integer = wv.GetSelectedRows()

            ' Iterate selected files
            For Each i As Integer In selectedRows
                Dim fileEntry As FileSystemEntry = CType(wv.GetRow(i), FileSystemEntry)
                Try
                    ' Open File
                    fileEntry.DoAction(Me)
                Catch ex As ArgumentNullException
                    Console.WriteLine("User can't access folder")
                End Try
            Next
        End Sub

        Private Sub cmsItemCopyTo_Click(sender As Object, e As EventArgs)
            If formReadOnly Then
                Print($"Copy file to a different directory")
                Try
                    ' User Inputs target directory to move files to
                    Dim targetFolder As Integer = XtraInputBox.Show($"Copy files to", Application.CompanyName, "")
                    If Directory.Exists($"{root}\{targetFolder}") Then
                        ' Copy Files
                        CopySelectedFiles(targetFolder)
                    Else
                        ' Create Directory & Copy Files
                        Directory.CreateDirectory($"{root}\{targetFolder}")
                        CopySelectedFiles(targetFolder)
                    End If
                Catch ex As InvalidCastException
                    ' User has not input any value, or did not input an Integer
                    Console.WriteLine(ex)
                End Try
            Else
                MsgBox("WARNING: can't copy files when in read only mode")
            End If
        End Sub

        Private Sub cmsItemXL_Click(sender As Object, e As EventArgs)
            Print($"Set Icon XL size handler")
            wv.OptionsView.Style = WinExplorerViewStyle.ExtraLarge
            wv.OptionsViewStyles.ExtraLarge.ImageSize = New Size(256, 256)
        End Sub

        Private Sub cmsItemLarge_Click(sender As Object, e As EventArgs)
            Print($"Set Icon Large size handler")
            wv.OptionsView.Style = WinExplorerViewStyle.Large
            wv.OptionsViewStyles.ExtraLarge.ImageSize = New Size(96, 96)
        End Sub

        Private Sub cmsItemMedium_Click(sender As Object, e As EventArgs)
            Print($"Set Icon Medium size handler")
            wv.OptionsView.Style = WinExplorerViewStyle.Medium
            wv.OptionsViewStyles.ExtraLarge.ImageSize = New Size(32, 32)
        End Sub

        Private Sub cmsItemSmall_Click(sender As Object, e As EventArgs)
            Print($"Set Icon Small size handler")
            wv.OptionsView.Style = WinExplorerViewStyle.Small
            wv.OptionsViewStyles.ExtraLarge.ImageSize = New Size(16, 16)
        End Sub

        Private Sub cmsItemRename_Click(sender As Object, e As EventArgs)
            If formReadOnly Then
                Print("Rename file handler")
                Dim fileIndex As Integer = wv.FocusedRowHandle
                Dim fileEntry As FileSystemEntry = CType(wv.GetRow(fileIndex), FileSystemEntry)
                Dim filePath As String = fileEntry.Path
                Dim fileName As String = fileEntry.Name
                Dim fileExtension As String = Path.GetExtension(filePath)

                Print($"filePath: {filePath}")
                Print($"fileName: {fileName}")
                Print($"fileExtension: {fileExtension}")

                If File.Exists(filePath) Then
                    Try
                        Dim newName As String = XtraInputBox.Show($"Rename {fileName}", Application.CompanyName, "")
                        My.Computer.FileSystem.RenameFile(filePath, $"{newName}{fileExtension}")
                    Catch ex As IOException
                        MsgBox("Filename Already exists")
                    Finally
                        ClearView()
                        InitializeWinExplorerView()
                    End Try
                Else
                    MsgBox($"File '{filePath}' does not exists :(")
                End If
            Else
                MsgBox("WARNING: can't rename file when in read only mode")
            End If
        End Sub

        Private Sub WinExplorerView_RightClick(sender As Object, e As DevExpress.Utils.DXMouseEventArgs)
            Print("Right mouse click handler, show popup-menu ")
            If e.Button = MouseButtons.Right Then cms.Show(MousePosition)
        End Sub

#End Region



#Region "Methods"

        Public Function fnEmailSubject(ByVal subject As String) As String
            Print("")
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

        Sub CopySelectedFiles(ByVal targetFolder As String)
            Print("Copy files to {targetFolder} directory")

            ' Get selected files from WinExplorerView
            Dim selectedRows() As Integer = wv.GetSelectedRows()

            ' Iterate selected files
            For Each i As Integer In selectedRows
                Dim fileEntry As FileSystemEntry = CType(wv.GetRow(i), FileSystemEntry)
                Dim filePath As String = fileEntry.Path
                Dim fileName As String = fileEntry.Name
                Dim fileExtension As String = Path.GetExtension(filePath)

                ' Copy non-folder file to target folder
                If Not wv.IsGroupRow(i) Then
                    Try
                        File.Copy(filePath, $"{root}\{targetFolder}\{fileName}{fileExtension}", True)
                    Catch ex As IOException
                        ' current file is a folder
                        Console.WriteLine(ex)
                    End Try
                End If
            Next i
        End Sub

        Sub ClearView()
            Print("Clear WinExplorerView MainView")
            gc.BeginUpdate()
            Try
                wv.Columns.Clear()
                gc.DataSource = Nothing
            Finally
                gc.EndUpdate()
            End Try
        End Sub

        Private Function GetItemSizeType(ByVal viewStyle As WinExplorerViewStyle) As IconSizeType
            Print("Set Icon Size Type")
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

        Private Function GetItemSize(ByVal viewStyle As WinExplorerViewStyle) As Size
            Print("Set icon item size")
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

        Private Sub Print(ByVal description As String)
            ' Get Parent Method
            Dim sf As New StackFrame(1, True)
            Dim parentMethod As MethodBase = sf.GetMethod()

            ' Print name of the parent method and description
            Debug.WriteLine($"[INFO] : {parentMethod.Name} - {description}")
        End Sub

#End Region



#Region "Implements"
        Public ReadOnly Property CurrentPath As String Implements IFileSystemNavigationSupports.CurrentPath
            Get
                Try
                    Throw New NotImplementedException()
                Catch ex As NotImplementedException
                    Console.WriteLine("User can't access folder")
                End Try

            End Get
        End Property

        Public Sub UpdatePath(path As String) Implements IFileSystemNavigationSupports.UpdatePath
            Throw New NotImplementedException()
        End Sub
#End Region

    End Class

#End Region

End Class