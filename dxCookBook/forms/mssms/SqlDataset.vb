Imports System.Data.SqlClient

Public Class SqlDataset
    Inherits BaseForm



    Sub New()
        InitializeComponent()

        AddHandler Me.btnReadStatement.Click, AddressOf ReadDataset_Click
        AddHandler Me.btnInsertStatement.Click, AddressOf InstertDataset_Click
        AddHandler Me.btnUpdateStatement.Click, AddressOf UpdateDataset_Click
        AddHandler Me.btnDeleteStatement.Click, AddressOf DeleteDataset_Click
    End Sub



    Private Sub DeleteDataset_Click(sender As Object, e As EventArgs)
        Print("Delete data with a Dataset")

        ' define adapter
        Dim ds As New dsPersons.vwPersonsDataTable
        Dim tba As New dsPersonsTableAdapters.vwPersonsTableAdapter

        Try
            ' execute query
            tba.DeleteQuery(12)
        Catch ex As SqlException
            Print($"SqlException: {ex}")
        Catch ex As Exception
            Print($"Exception: {ex}")
        End Try

    End Sub



    Private Sub UpdateDataset_Click(sender As Object, e As EventArgs)
        Print("Update data with a Dataset")

        ' define adapter
        Dim ds As New dsPersons.vwPersonsDataTable
        Dim tba As New dsPersonsTableAdapters.vwPersonsTableAdapter

        Try
            ' execute query
            tba.UpdateQuery(12, "Sonny", "Boy", 12)
        Catch ex As SqlException
            Print($"SqlException: {ex}")
        Catch ex As Exception
            Print($"Exception: {ex}")
        End Try
    End Sub



    Private Sub InstertDataset_Click(sender As Object, e As EventArgs)
        Print("Insert data with a Dataset")

        ' define adapter
        Dim ds As New dsPersons.vwPersonsDataTable
        Dim tba As New dsPersonsTableAdapters.vwPersonsTableAdapter

        Try
            ' execute query
            tba.InsertQuery(12, "Jim", "Button")
        Catch ex As SqlException
            Print($"SqlException: {ex}")
        Catch ex As Exception
            Print($"Exception: {ex}")
        End Try
    End Sub



    Private Sub ReadDataset_Click(sender As Object, e As EventArgs)
        Print("Read data with a Dataset")

        ' define adapter
        Dim ds As New dsPersons.vwPersonsDataTable
        Dim tba As New dsPersonsTableAdapters.vwPersonsTableAdapter

        Try
            ' fill dataset
            tba.Fill(ds)
            tba.FillBy(ds, 1)

            ' print dataset
            For Each row As DataRow In ds.Rows
                Print($"{row(0)}, {row(1)}, {row(2)}")
            Next
        Catch ex As SqlException
            Print($"SqlException: {ex}")
        Catch ex As Exception
            Print($"Exception: {ex}")
        End Try
    End Sub



End Class

' ----------------------------------------
'           Create Dataset
' ----------------------------------------
'Dasteset.xsd > TableAdapter > Rigth Click > Add > New

'    Use SQL statement > [query type]

'    Modify query

'Select Case id, first_name, last_name, name, radius FROM dbo.vwPersons WHERE id=@id

'    Test query: Query Builder > Execute Query

'    Next > Next > Finish



' ----------------------------------------
'           Create Query
' ----------------------------------------
'1. Dasteset.xsd > TableAdapter > Rigth Click > Add > New
'2. Use SQL statement > [query type]
'3. Modify query 

'    Select Case id, first_name, last_name, name, radius FROM dbo.vwPersons WHERE id=@id

'4. Test query: Query Builder > Execute Query
'5. Next > Next > Finish