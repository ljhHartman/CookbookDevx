Public Class ClickRow

    ' Delcare Class Varialbes
    Private androidUserId As Long
    Private tableAdapter As SSLTESTDataSet3TableAdapters.android_usersTableAdapter
    Private dataTable As SSLTESTDataSet3.android_usersDataTable
    Private dataRow As DataRow


    Sub New()
        ' Init From Design
        InitializeComponent()

        ' Init Class Variables
        androidUserId = 0
        tableAdapter = Me.Android_usersTableAdapter1
        dataTable = Me.SSLTESTDataSet31.android_users

        ' Init Activities
        AddHandler Me.Load, AddressOf ClickRow_Load
        AddHandler SslDataGrid1.DoubleClick, AddressOf SslDataGrid1_Click

    End Sub



#Region "Buttons"

    Private Sub ClickRow_Load(sender As Object, e As EventArgs)
        'At Load Time, fill Datagrid with the selected Table
        tableAdapter.Fill(dataTable)
    End Sub




    Private Sub SslDataGrid1_Click(ByVal sender As Object, ByVal e As EventArgs)
        ' Double Click Row Action

        ' Create DataRow
        dataRow = SslGridView1.GetFocusedDataRow()

        ' Return Value from DataRow
        androidUserId = dataRow("id")
        MsgBox("id: " & androidUserId)
    End Sub

#End Region

End Class