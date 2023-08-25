Imports System.ComponentModel
Imports DevExpress.Data
Imports DevExpress.XtraGrid.Columns
Imports DevExpress.XtraGrid.Views.Grid

' Steps: Creating Sum Total Selected
' 1. Create BindList with Items
' 2 Bind BindList to GridControl
' 3. Enable GridControl MultiSelect - CheckBoxRowSelect
' 4. Enable GridControl ShowFooter
' 5. Get "Cost"total sum of selected rows
' 6. Update TotalValue in the footer, with the SUMSelection


Public Class GridControlFooterSum
    Dim SUMSelection As Double
    Dim SelectedRows As Integer


    Public Sub New()
        InitializeComponent()

        'BindList to GridControl
        Dim bl As BindingList(Of Dos) = New BindingList(Of Dos)
        bl.Add(New Dos With {
               .Name = "Alpha",
               .Cost = 111.11})
        bl.Add(New Dos With {
           .Name = "Beta",
           .Cost = 222.22})
        bl.Add(New Dos With {
           .Name = "Gamma",
           .Cost = 333.33})
        GridControl1.DataSource = bl

        ' Enable Footer
        GridView1.OptionsView.ShowFooter = True
        Dim column As GridColumn = GridView1.Columns("Cost")
        column.SummaryItem.SummaryType = SummaryItemType.Custom

        'Events
        AddHandler GridView1.SelectionChanged, AddressOf GridView1_SelectionChanged
        AddHandler GridView1.CustomSummaryCalculate, AddressOf GridView1_CustomSummaryCalculate

    End Sub



    Private Sub GridView1_SelectionChanged(sender As Object, e As DevExpress.Data.SelectionChangedEventArgs)
        'This Event, adds up all the selected cost value and execute the grievew UpdateSUmmary
        Dim view As GridView = TryCast(sender, GridView)

        Dim sum As Double = 0D
        Dim tot As Integer = 0
        For Each row In view.GetSelectedRows ' iterate each selected row
            sum += view.GetRowCellValue(row, view.Columns("Cost")) 'add up all selected cost values
        Next

        SelectedRows = GridView1.SelectedRowsCount
        SUMSelection = sum
        GridView1.UpdateSummary()
    End Sub


    Private Sub GridView1_CustomSummaryCalculate(sender As Object, e As DevExpress.Data.CustomSummaryEventArgs)
        'This Event, select the condition of the CustomSummaryProcess and update the TotalValue
        Select Case e.SummaryProcess
            Case DevExpress.Data.CustomSummaryProcess.Start
                e.TotalValue = 0
            Case DevExpress.Data.CustomSummaryProcess.Calculate
                e.TotalValue = $"{SelectedRows} Selected, Total Cost: {SUMSelection}"
            Case DevExpress.Data.CustomSummaryProcess.Finalize
                e.TotalValueReady = True
        End Select
    End Sub

End Class




Friend Class Dos
    Property Name As String
    Property Cost As Double
End Class
