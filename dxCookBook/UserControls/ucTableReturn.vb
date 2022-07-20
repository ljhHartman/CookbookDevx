Public Class ucTableReturn

    ' Class Vars
    Dim Rows As New ArrayList()
    Dim table1 As DataTable = New DataTable()
    Dim table2 As DataTable = New DataTable()

    ' Constructor
    Public Sub New(arg As String)
        InitializeComponent()

        ' Setup Tables
        table1.Columns.Add("ID")
        table1.Columns.Add("Value")
        table1.Columns.Add("Valuta")
        table1.Columns.Add("Zeres")
        table1.Columns.Add("Cost")
        table1.Rows.Add(1, 1111, "Euro", 0, 11.1)
        table1.Rows.Add(2, 2222, "Euro", 0, 22.2)
        table1.Rows.Add(3, 3333, "Euro", 0, 33.3)
        table2.Columns.Add("ID")
        table2.Columns.Add("Value")
        table2.Columns.Add("Valuta")
        table2.Columns.Add("Zeres")
        table2.Columns.Add("Cost")

        ' View Table in Top GridControl
        GridControl1.DataSource = table1
    End Sub


    Public ReadOnly Property result As DataTable
        Get
            ' Add the selected rows to the Table.
            Dim selectedRowHandles As Int32() = GridView1.GetSelectedRows()
            Dim I As Integer
            For I = 0 To selectedRowHandles.Length - 1
                Dim selectedRowHandle As Int32 = selectedRowHandles(I)
                If (selectedRowHandle >= 0) Then
                    table2.ImportRow(GridView1.GetDataRow(selectedRowHandle))
                End If
            Next

            ' Info Dialog
            Dim numRowsSelected As Integer = table2.Rows.Count
            Dim currencyType As String = table2.Rows(0)("Valuta").ToString()
            ' Sum of Total Cost Selected
            Dim totalCostSelected As Double = 0
            For x As Integer = 0 To table2.Rows.Count - 1
                totalCostSelected = totalCostSelected + table2.Rows(x)("Cost")
            Next
            MsgBox(numRowsSelected & " items are selected with a total cost of " & totalCostSelected & " " & currencyType, Nothing, "Selected")

            Return table2
        End Get
    End Property

    Private Sub GridControl1_Click(sender As Object, e As EventArgs) Handles GridControl1.Click

    End Sub
End Class
