Public Class GridConrolForm

    Dim Rows As New ArrayList()

    Private Sub GridConrolForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ' Get Table from DataBase
        Me.StockTableAdapter.Fill(Me.SSLTESTDataSet.Stock)

        ' Show Horizontal ScrollBar
        GridView1.OptionsView.ColumnAutoWidth = False
        GridView1.HorzScrollVisibility = True

        ' Multi Select
        ' Source: https://docs.devexpress.com/WindowsForms/DevExpress.XtraGrid.Views.Grid.GridOptionsSelection.MultiSelectMode
        GridView1.OptionsSelection.MultiSelect = True
        GridView1.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnObtain.Click
        ' Source: https://docs.devexpress.com/WindowsForms/711/controls-and-libraries/data-grid/focus-and-selection-handling/multiple-row-and-cell-selection
        ' Story selected rows to an array

        ' Add the selected rows to the list.
        Dim selectedRowHandles As Int32() = GridView1.GetSelectedRows()
        Dim I As Integer
        For I = 0 To selectedRowHandles.Length - 1
            Dim selectedRowHandle As Int32 = selectedRowHandles(I)
            If (selectedRowHandle >= 0) Then
                Rows.Add(GridView1.GetDataRow(selectedRowHandle))
            End If
        Next

        MsgBox(Rows.Count & " Rows are obtained")

    End Sub
End Class