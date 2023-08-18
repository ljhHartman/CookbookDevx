Imports System.ComponentModel
Imports DevExpress.XtraGrid.Views.Grid



Public Class FormDetails
    Dim bindingList As BindingList(Of Record)
    Dim formID As Integer = Globals.ID
    Dim formUser As String = Globals.formUser
    Dim formReadOnly As Boolean = Globals.formReadOnly
    Dim formLanguage As String = Globals.formLanguage
    Dim gridcontrol1 As GridController1


    Sub New()
        InitializeComponent()
        InitializeFormDetails()
        InitializeAutocomplete()
        InitializeReadOnly()
        ItitializeViews()



    End Sub



#Region "Methods"

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
        tbPersonID.DataBindings.Add("EditValue", bindingList, "PersonID")
        tbLastName.DataBindings.Add("EditValue", bindingList, "LastName")
        tbFirstName.DataBindings.Add("EditValue", bindingList, "FirstName")
        tbCity.DataBindings.Add("EditValue", bindingList, "City")
    End Sub

    Private Sub InitializeAutocomplete()
        Dim dsAlphaTable As New dsAlphaTable
        Dim tbaAlphaTable As New dsAlphaTableTableAdapters.AlphaTableTableAdapter
        Dim acAlphaTable As New AutoCompleteStringCollection
        tbaAlphaTable.Fill(dsAlphaTable.AlphaTable)
        dsAlphaTable.AlphaTable.Rows.Cast(Of DataRow).ToList.ForEach(Function(dr) acAlphaTable.Add(dr("LastName") & "    |    " & dr("PersonID")))
        tbLastName.MaskBox.AutoCompleteCustomSource = acAlphaTable

        ' Add more Autocomplete
    End Sub

    Private Sub InitializeReadOnly()
        If formReadOnly Then Console.WriteLine($"Run ReadOnlyAppUI(Me) method from BaseFrom")
    End Sub

    Private Sub ItitializeViews()
        gridcontrol1 = New GridController1(Me.SslDataGrid1, formID)
    End Sub

#End Region


#Region "Classes"

    Private Class Record
        Public Sub New()
        End Sub

        Public Property PersonID As Integer
        Public Property LastName As String
        Public Property FirstName As String
        Public Property City As String
    End Class



    Private Class GridController1
        Public Sub New(ByRef gridcontrol As sslDataGrid.sslDataGrid, id As Integer)
            Dim ds As Object = New dsAlphaTable.AlphaTableDataTable()
            Dim tba As Object = New dsAlphaTableTableAdapters.AlphaTableTableAdapter()
            Dim dt As DataTable = New DataTable
            Dim gv As GridView = gridcontrol.MainView

            ' Set datasource
            tba.Fill(ds)
            dt = ds
            gridcontrol.DataSource = dt

            ' Settings
            gv.OptionsView.ColumnAutoWidth = False
            gv.HorzScrollVisibility = True
            gv.OptionsBehavior.Editable = False
            gv.OptionsView.ShowGroupPanel = False
            gv.OptionsFind.AllowFindPanel = True
            gv.OptionsFind.AlwaysVisible = True
            gv.OptionsView.ShowFooter = True
        End Sub

    End Class

#End Region

End Class
