Public Class ComboBox

    Private Sub ComboBox_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        acDocumentType()
    End Sub

    Private Sub acDocumentType()
        Dim dataSource As List(Of String) = New List(Of String)
        Dim ds As dsDocumentType.DocumentSoortenDataTable
        Dim tba As dsDocumentTypeTableAdapters.DocumentSoortenTableAdapter

        ' Load Dataset
        ds = New dsDocumentType.DocumentSoortenDataTable()
        tba = New dsDocumentTypeTableAdapters.DocumentSoortenTableAdapter()
        tba.Fill(ds)

        ' Dataset to List
        For Each row As DataRow In ds.Rows
            If row("SOORT") = "IN" Then dataSource.Add(row("CODE"))
        Next

        ' Bind List to LookUpEdit
        lueDocumentType.Properties.DataSource = dataSource
    End Sub
End Class