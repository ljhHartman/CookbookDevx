Imports System.Data.SqlClient

Public Class SqlDatasetProcedure
    Inherits BaseForm



    Sub New()
        InitializeComponent()

        AddHandler Me.btnReadStatement.Click, AddressOf ReadDataset_Click
        AddHandler Me.btnInsertStatement.Click, AddressOf InstertDataset_Click
        AddHandler Me.btnUpdateStatement.Click, AddressOf UpdateDataset_Click
        AddHandler Me.btnDeleteStatement.Click, AddressOf DeleteDataset_Click
    End Sub



    Private Sub DeleteDataset_Click(sender As Object, e As EventArgs)
        Print("Delete data with an Existing Stored Procedure, through the Dataset")

        ' define adapter
        Dim ds As New dsPersons.vwPersonsDataTable
        Dim tba As New dsPersonsTableAdapters.vwPersonsTableAdapter

        Try
            ' execute query
            tba.spDeleteQuery(13)
        Catch ex As SqlException
            Print($"SqlException: {ex}")
        Catch ex As Exception
            Print($"Exception: {ex}")
        End Try
    End Sub



    Private Sub UpdateDataset_Click(sender As Object, e As EventArgs)
        Print("Update data with an Existing Stored Procedure, through the Dataset")

        ' define adapter
        Dim ds As New dsPersons.vwPersonsDataTable
        Dim tba As New dsPersonsTableAdapters.vwPersonsTableAdapter

        Try
            ' execute query
            tba.spUpdateQuery(13, "Sonny", "Boy")
        Catch ex As SqlException
            Print($"SqlException: {ex}")
        Catch ex As Exception
            Print($"Exception: {ex}")
        End Try
    End Sub



    Private Sub InstertDataset_Click(sender As Object, e As EventArgs)
        Print("Insert data with an Existing Stored Procedure, through the Dataset")

        ' define adapter
        Dim ds As New dsPersons.vwPersonsDataTable
        Dim tba As New dsPersonsTableAdapters.vwPersonsTableAdapter

        Try
            ' execute query
            tba.spInsertQuery(13, "Jim", "Button")
        Catch ex As SqlException
            Print($"SqlException: {ex}")
        Catch ex As Exception
            Print($"Exception: {ex}")
        End Try
    End Sub



    Private Sub ReadDataset_Click(sender As Object, e As EventArgs)
        Print("Read data with a Existing Stored Procedure, through the Dataset")

        ' define adapter
        Dim ds As New dsPersons.vwPersonsDataTable
        Dim tba As New dsPersonsTableAdapters.vwPersonsTableAdapter

        Try
            ' fill dataset
            tba.spFillBy(ds, 1)

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