Imports System.Timers
Imports DevExpress.XtraGrid.Views.Grid

Public Class SelectRowsByCheckbox

    Dim Rows As New ArrayList()
    Dim val As String

    Private Sub GridConrolForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ' Get SQLTable from DataBase
        Me.StockTableAdapter.Fill(Me.SSLTESTDataSet.Stock)

        ' Show Horizontal ScrollBar
        GridView1.OptionsView.ColumnAutoWidth = False
        GridView1.HorzScrollVisibility = True

        ' Multi Select
        ' Source: https://docs.devexpress.com/WindowsForms/DevExpress.XtraGrid.Views.Grid.GridOptionsSelection.MultiSelectMode
        GridView1.OptionsSelection.MultiSelect = True
        GridView1.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect


        'AddHandler GridView1.CustomDrawFooter, AddressOf GridView1_CustomDrawFooter

        ' Create timer
        'Dim timer As Timer = New Timer()
        'timer.Interval = 100
        'AddHandler timer.Elapsed, AddressOf TimerEvent
        'timer.AutoReset = True
        'timer.Enabled = True

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

                'AddHandler GridView1.CustomDrawFooter, AddressOf GridView1_CustomDrawFooter
            End If
        Next

        MsgBox(Rows.Count & " Rows are obtained")

    End Sub



    'Private Sub GridView1_CustomDrawFooter(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.RowObjectCustomDrawEventArgs)
    '    Dim stringFormat As StringFormat = New StringFormat()
    '    stringFormat.Alignment = StringAlignment.Near
    '    stringFormat.LineAlignment = StringAlignment.Center
    '    Dim rect = e.Bounds
    '    rect.X += 10
    '    e.DefaultDraw()
    '    e.Cache.DrawString($"Total: {val}", e.Appearance.GetFont(), e.Appearance.GetForeBrush(e.Cache), rect, stringFormat)
    '    e.Handled = True
    'End Sub



    'Private Sub TimerEvent(ByVal source As Object, ByVal e As ElapsedEventArgs)
    '    'Console.WriteLine("Event Raised at {0:HH:mm:ss.fff}", e.SignalTime)
    '    Console.WriteLine("Count Miliseconds {0:fff}", e.SignalTime) ' count milisecond
    '    'Console.WriteLine("Count Seconds {0:ss}", e.SignalTime) ' count milisecond
    'End Sub

    'Dim SUMSelection As Double
    'Private Sub GridView1_SelectionChanged(sender As Object, e As DevExpress.Data.SelectionChangedEventArgs) Handles GridView1.SelectionChanged
    '    Try
    '        SUMSelection = GetSelectedRows(GridControl1.FocusedView)
    '        MsgBox(Rows.Count)
    '    Catch ex As Exception

    '    End Try

    'End Sub


    Private Function GetSelectedRows(view As GridView)
        Dim sum As Double = 0D
        If view.OptionsSelection.MultiSelectMode = GridMultiSelectMode.CellSelect Then
            For Each cell In view.GetSelectedCells
                sum += view.GetRowCellValue(cell.RowHandle, cell.Column)
            Next
        End If
        Return sum

    End Function

End Class