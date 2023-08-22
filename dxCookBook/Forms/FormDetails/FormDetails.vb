Imports System.ComponentModel
Imports System.IO
Imports DevExpress.Utils.Drawing
Imports DevExpress.Utils.Helpers
Imports DevExpress.XtraGrid
Imports DevExpress.XtraGrid.Columns
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraGrid.Views.WinExplorer

Public Class FormDetails
    Private bindingList As BindingList(Of Record)
    Private formID As Integer = Globals.ID
    Private formUser As String = Globals.formUser
    Private formReadOnly As Boolean = Globals.formReadOnly
    Private formLanguage As String = Globals.formLanguage
    Private gridControlExample As GridController1
    Private fileManagerExample As FileManagerExample1




#Region "Initializers"

    Sub New()
        InitializeComponent()
        InitializeFormDetails()
        InitializeAutocomplete()
        InitializeReadOnly()
        ItitializeViews()
        InitializeTests()

        AddHandler Me.btnAddRow.Click, AddressOf btnAddRow_Click
        AddHandler Me.btnClearView.Click, AddressOf btnClearView_Click
        AddHandler Me.btnInitializeView.Click, AddressOf btnInitializeView_Click
    End Sub

    Private Sub InitializeFormDetails()
        ' Define BindingList
        bindingList = New BindingList(Of Record)

        ' Build Dataset
        Dim ds As Object = New dsAlphaTable.AlphaTableDataTable()
        Dim tba As Object = New dsAlphaTableTableAdapters.AlphaTableTableAdapter()
        tba.FillBy(ds, formID)

        ' Print Dataset
        For Each row As Object In ds.Rows
            Console.WriteLine($"[INFO] - {Reflection.MethodBase.GetCurrentMethod().Name} - Dataset Row Id: {row("PersonID")}")
        Next

        ' Dataset to BindingList
        bindingList.Add(New Record() With {
            .PersonID = If(IsDBNull(ds.Rows(0)("PersonID")), "", ds.Rows(0)("PersonID")),
            .FirstName = If(IsDBNull(ds.Rows(0)("FirstName")), "", ds.Rows(0)("FirstName")),
            .LastName = If(IsDBNull(ds.Rows(0)("LastName")), "", ds.Rows(0)("LastName")),
            .City = If(IsDBNull(ds.Rows(0)("City")), "", ds.Rows(0)("City"))
        })

        ' BindingList to Textboxes
        tePersonID.DataBindings.Add("EditValue", bindingList, "PersonID")
        teLastName.DataBindings.Add("EditValue", bindingList, "LastName")
        teFirstName.DataBindings.Add("EditValue", bindingList, "FirstName")
        teCity.DataBindings.Add("EditValue", bindingList, "City")
    End Sub

    Private Sub InitializeAutocomplete()
        Dim dsAlphaTable As New dsAlphaTable
        Dim tbaAlphaTable As New dsAlphaTableTableAdapters.AlphaTableTableAdapter
        Dim acAlphaTable As New AutoCompleteStringCollection
        tbaAlphaTable.Fill(dsAlphaTable.AlphaTable)
        dsAlphaTable.AlphaTable.Rows.Cast(Of DataRow).ToList.ForEach(Function(dr) acAlphaTable.Add(dr("LastName") & "    |    " & dr("PersonID")))
        teLastName.MaskBox.AutoCompleteCustomSource = acAlphaTable

        ' Add more Autocomplete
    End Sub

    Private Sub InitializeReadOnly()
        If formReadOnly Then Console.WriteLine($"Run ReadOnlyAppUI(Me) method from BaseFrom")
    End Sub

    Private Sub InitializeTests()
        My.Application.Log.WriteEntry($" [TEST] Form ID:................{formID}")
        My.Application.Log.WriteEntry($" [TEST] Form Language:..........{formLanguage}")
        My.Application.Log.WriteEntry($" [TEST] Form Read Only:.........{formReadOnly}")
        My.Application.Log.WriteEntry($" [TEST] Form User:..............{formUser}")
        My.Application.Log.WriteEntry($" [TEST] GridControl1 RowCount:..{gridControlExample.RowCount()}")

    End Sub

    Private Sub ItitializeViews()
        gridControlExample = New GridController1(Me.SslDataGrid1)
        fileManagerExample = New FileManagerExample1(Me.SslDataGrid3)
    End Sub

#End Region



#Region "Controls"

    Private Sub btnAddRow_Click(sender As Object, e As EventArgs)
        gridControlExample.NewRow()
    End Sub

    Private Sub btnClearView_Click(sender As Object, e As EventArgs)
        gridControlExample.ClearView()
    End Sub

    Private Sub btnInitializeView_Click(sender As Object, e As EventArgs)
        gridControlExample.InitializeView()
    End Sub
#End Region



#Region "Methods"



#End Region



#Region "Classes"

    Private Class Record
        Public Property PersonID As Integer
        Public Property LastName As String
        Public Property FirstName As String
        Public Property City As String
    End Class



    Class GridController1
        Private gc As sslDataGrid.sslDataGrid
        Private ds As Object
        Private tba As Object
        Private dt As DataTable
        Private gv As GridView



        Public Sub New(ByRef gridcontrol As sslDataGrid.sslDataGrid)
            gc = gridcontrol
            ds = New dsAlphaTable.AlphaTableDataTable()
            tba = New dsAlphaTableTableAdapters.AlphaTableTableAdapter()
            dt = New DataTable
            gv = gridcontrol.MainView

            ' Datasource
            InitializeView()

            ' Settings
            gv.OptionsView.ColumnAutoWidth = False
            gv.HorzScrollVisibility = True
            gv.OptionsBehavior.Editable = False
            gv.OptionsView.ShowGroupPanel = False
            gv.OptionsFind.AllowFindPanel = True
            gv.OptionsFind.AlwaysVisible = True
            gv.OptionsView.ShowFooter = True

            ' Handlers
            AddHandler gc.DoubleClick, AddressOf gridcontrol_Click

            ' Footer
            gv.Columns("PersonID").Summary.Add(New GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "PersonID", "Sum={0}"))

        End Sub

        Function RowCount()
            Return gv.RowCount()
        End Function

        Sub InitializeView()
            tba.Fill(ds)
            dt = ds
            gc.DataSource = dt
        End Sub

        Sub ClearView()
            gc.BeginUpdate()
            Try
                gv.Columns.Clear()
                gc.DataSource = Nothing
            Finally
                gc.EndUpdate()
            End Try
        End Sub

        Sub NewRow()
            With gv
                .AddNewRow()
                .SetRowCellValue(gc.NewItemRowHandle, gv.Columns("PersonID"), 4)
                .SetRowCellValue(gc.NewItemRowHandle, gv.Columns("FirstName"), "Fry")
                .SetRowCellValue(gc.NewItemRowHandle, gv.Columns("LastName"), "X")
                .SetRowCellValue(gc.NewItemRowHandle, gv.Columns("City"), "New New York City")
            End With
        End Sub

        Private Sub gridcontrol_Click(ByVal sender As Object, ByVal e As EventArgs)
            Dim dataRow As DataRow = gv.GetFocusedDataRow()
            MsgBox($"Selected row id: {dataRow("PersonID")}")
        End Sub

    End Class


    Private Class FileManagerExample1
        Implements IFileSystemNavigationSupports
        Private gc As sslDataGrid.sslDataGrid
        Private wv As WinExplorerView = New WinExplorerView()
        Private root As String = "C:\Users\lucas.hartman\Downloads"

        Sub New(ByRef fileSystem As sslDataGrid.sslDataGrid)
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
            wv.OptionsView.Style = WinExplorerViewStyle.Medium
            wv.OptionsView.ShowViewCaption = True

            gc = fileSystem
            gc.MainView = wv

            ' Settings
            gc.AllowDrop = True

            ' Show Files
            Dim iconSizeType As WinExplorerViewStyle = wv.OptionsView.Style
            Dim iconSize As New Size(96, 96)
            gc.DataSource = FileSystemHelper.GetFileSystemEntries(root, GetItemSizeType(iconSizeType), GetItemSize(iconSizeType))

        End Sub



#Region "Methods"
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

#End Region



#Region "Implements"
        Public ReadOnly Property CurrentPath As String Implements IFileSystemNavigationSupports.CurrentPath
            Get
                Throw New NotImplementedException()
            End Get
        End Property

        Public Sub UpdatePath(path As String) Implements IFileSystemNavigationSupports.UpdatePath
            Throw New NotImplementedException()
        End Sub
#End Region

    End Class

#End Region

End Class
