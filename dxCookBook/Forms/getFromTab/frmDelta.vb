Imports System.ComponentModel

Public Class frmDelta
    Private bindingList As BindingList(Of Model)



    Private Sub frmDelta_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        bindingList = New BindingList(Of Model)

        ' Build BindingList
        bindingList.Add(New Model With {
                        .id = 0,
                        .x = 111,
                        .y = 222,
                        .z = 333})

        ' Fill DataGrid
        SslDataGrid1.DataSource = bindingList

        ' Test Method Local
        'setBindingListItem(0, 123, 456, 678)
    End Sub



    Public Sub setBindingListItem(ByVal id As Integer, ByVal x As Integer, ByVal y As Integer, ByVal z As Integer)
        ' This method, set the item in a bindinglist by id

        ' Set item details
        Dim item As Model = bindingList.SingleOrDefault(Function(i) i.id = id)
        item.x = x
        item.y = y
        item.z = z

        ' Print item details
        Debug.WriteLine(vbCrLf & $"[INFO] - Set BindindList item id: {item.id}, x={item.x}, y={item.y}, z={item.z},")

        ' Refresh DataGrid
        SslGridView1.RefreshData()
    End Sub



    Private Class Model
        Property id As Integer
        Property x As Integer
        Property y As Integer
        Property z As Integer

    End Class
End Class