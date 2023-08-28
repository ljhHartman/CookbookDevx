Imports System.ComponentModel

Public Class AddRowDataGrid

    Private Sub AddRowDataGrid_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Load Data
        SslDataGrid1.DataSource = SampleData()

        AddHandler bbAddRow.Click, AddressOf bbAddRow_Click
    End Sub


    Private Sub bbAddRow_Click(sender As Object, e As EventArgs)

        ' Check for Duplictes
        If checkDuplicates("Please enter new value") Then

            'Add Row
            With SslGridView1
                .AddNewRow()
                .SetRowCellValue(SslDataGrid1.NewItemRowHandle, SslGridView1.Columns("Name"), "Please enter new value")
                .SetRowCellValue(SslDataGrid1.NewItemRowHandle, SslGridView1.Columns("ID"), 69)
            End With

            ' Refresh underlying data source 
            SslGridView1.RefreshData()
        End If
    End Sub

    Private Function checkDuplicates(value As String) As Boolean
        Dim checker As Boolean = True
        For i As Integer = 0 To SslGridView1.RowCount - 1
            Debug.WriteLine(i & " - " & SslGridView1.GetRowCellValue(i, "Name"))
            If SslGridView1.GetRowCellValue(i, "Name") = value Then
                checker = False
            End If
        Next
        Return checker
    End Function


    'Sample Data
    Public Function SampleData() As BindingList(Of Entry)
        Dim ds As New BindingList(Of Entry)()
        With ds
            .Add(New Entry("One", 1))
            .Add(New Entry("Two", 2))
            .Add(New Entry("Three", 3))
            .AllowNew = True
        End With
        Return ds
    End Function


    Public Class Entry
        Public Sub New()
        End Sub

        Public Sub New(ByVal name As String, ByVal id As Int32)
            Me.Name = name
            Me.ID = id
        End Sub
        Public Property Name() As String
        Public Property ID() As Int32
    End Class

End Class