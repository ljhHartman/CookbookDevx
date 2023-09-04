Imports DevExpress.XtraGrid
Imports DevExpress.XtraGrid.Views.Grid



Public Class RowIcon
    Private GridControlExample As GridController1


    Sub New()
        InitializeComponent()
        GridControlExample = New GridController1(Me.gcInward)

    End Sub

#Region "Classes"

    Private Class Record
        Public Property PersonID As Integer
        Public Property LastName As String
        Public Property FirstName As String
        Public Property City As String
    End Class



    Class GridController1
        Private ReadOnly gc As sslDataGrid.sslDataGrid
        Private ReadOnly ds As Object
        Private ReadOnly tba As Object
        Private dt As DataTable
        Private ReadOnly gv As GridView



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
            AddHandler gc.DoubleClick, AddressOf Gridcontrol_Click
            AddHandler gv.RowStyle, AddressOf CellIcon_RowStyle

            ' Footer
            gv.Columns("PersonID").Summary.Add(New GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "PersonID", "Sum={0}"))
        End Sub



        Private Sub CellIcon_RowStyle(sender As Object, e As RowStyleEventArgs)
            Dim view As GridView = TryCast(sender, GridView)
            Dim imagePath As String = "C:\Users\lucas.hartman\source\repos\ljhHartman\Cookbook_Devx\src\f.png"
            Dim image As Image = Image.FromFile(imagePath)
            Dim icon As New Bitmap(image, New Size(50, 50))

            If e.RowHandle >= 0 Then
                Dim value As String = view.GetRowCellDisplayText(e.RowHandle, view.Columns("PersonID"))
                If value = 1 Then e.Appearance.Image = icon
            End If
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




#Region "Notes"
    'select INSLAGNUMMER, ADR from Inslag
#End Region




End Class