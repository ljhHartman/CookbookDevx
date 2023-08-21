Imports System.ComponentModel
Imports DevExpress.XtraGrid
Imports DevExpress.XtraGrid.Views.Grid



Public Class FormDetails
    Dim bindingList As BindingList(Of Record)
    Dim formID As Integer = Globals.ID
    Dim formUser As String = Globals.formUser
    Dim formReadOnly As Boolean = Globals.formReadOnly
    Dim formLanguage As String = Globals.formLanguage
    Dim gridControlExample As GridController1
    Dim fileSystemExample As FileSystem1



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
        fileSystemExample = New FileSystem1(Me.SslDataGrid2)
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


    Private Class FileSystem1
        Sub New(ByRef fileSystem As sslDataGrid.sslDataGrid)
        End Sub

    End Class


#End Region

End Class
