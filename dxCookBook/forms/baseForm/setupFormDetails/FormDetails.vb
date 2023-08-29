Imports System.ComponentModel
Imports DevExpress.XtraGrid
Imports DevExpress.XtraGrid.Views.Grid

Public Class FormDetails
    Inherits BaseForm
    Private bindingList As BindingList(Of Record)
    Private formID As Integer = Globals.ID
    Private gUser As String = Globals.gUser
    Private gReadOnly As Boolean = Globals.gReadOnly
    Private gLanguage As String = Globals.gLanguage
    Private gridControlExample As GridController1
    Private fileManagerView1 As FileManagerView

    Sub New()
        InitializeComponent()
        InitializeFormDetails()
        InitializeAutocomplete()
        InitializeReadOnly()
        InitializeInfo()

        gridControlExample = New GridController1(Me.SslDataGrid1)
        fileManagerView1 = New FileManagerView(Me.SslDataGrid2, gReadOnly, Globals.ID)



        AddHandler Me.btnAddRow.Click, AddressOf BtnAddRow_Click
        AddHandler Me.btnClearView.Click, AddressOf BtnClearView_Click
        AddHandler Me.btnInitializeView.Click, AddressOf BtnInitializeView_Click
        AddHandler Me.btnSave.Click, AddressOf BtnSave_Click
    End Sub


#Region "Initializers"

    Private Sub InitializeFormDetails()
        Try
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
        Catch ex As Exception

        End Try
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
        If gReadOnly Then Console.WriteLine($"This form is set to Read only")
    End Sub

    Private Sub InitializeInfo()
        My.Application.Log.WriteEntry($" [TEST] Form ID:................{formID}")
        My.Application.Log.WriteEntry($" [TEST] Form Language:..........{gLanguage}")
        My.Application.Log.WriteEntry($" [TEST] Form Read Only:.........{gReadOnly}")
        My.Application.Log.WriteEntry($" [TEST] Form User:..............{gUser}")
    End Sub

#End Region



#Region "Handlers"

    Private Sub BtnSave_Click(sender As Object, e As EventArgs)
        ' Generated Filenumber
        Globals.ID = 123456

        ' Set Filenumber in view
        fileManagerView1.Id = Globals.ID
    End Sub

    Private Sub BtnAddRow_Click(sender As Object, e As EventArgs)
        gridControlExample.NewRow()
    End Sub

    Private Sub BtnClearView_Click(sender As Object, e As EventArgs)
        gridControlExample.ClearView()
    End Sub

    Private Sub BtnInitializeView_Click(sender As Object, e As EventArgs)
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
        Private ReadOnly gc As sslDataGrid.SslDataGrid
        Private ReadOnly ds As Object
        Private ReadOnly tba As Object
        Private dt As DataTable
        Private ReadOnly gv As GridView



        Public Sub New(ByRef gridcontrol As sslDataGrid.SslDataGrid)
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
            AddHandler gc.DoubleClick, AddressOf Gridcontrol_Click

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

        Private Sub Gridcontrol_Click(ByVal sender As Object, ByVal e As EventArgs)
            Dim dataRow As DataRow = gv.GetFocusedDataRow()
            MsgBox($"Selected row id: {dataRow("PersonID")}")
        End Sub

    End Class

#End Region

End Class
