Public Class Chartview

    ' ------------------------------
    '           Build Chart
    ' ------------------------------
    ' 1. CREATE:            Toolbox > ChartContro
    ' 2. SELECT DATA:       Task > Choose Data Source > Add > Table > SELECT 2 or more Columns
    ' 3. CHART TYPE:        Task > Run Wizard  > Series > Add > Select Chart
    ' 4. INPUT HOR. DATA:    Task > Series > Properties > > Data > ArgumentDataMember > Select Horizontal Values
    ' 5. INPUT VER. DATA:    Task > Series > Properties >> Data > ValueDataMember > Select Vertical Values


    Private Sub ChartForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'SSLTESTDataSet1.InkomendeFacturen' table. You can move, or remove it, as needed.
        Me.InkomendeFacturenTableAdapter.Fill(Me.SSLTESTDataSet1.InkomendeFacturen)

    End Sub
End Class