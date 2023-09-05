Imports System.Data.SqlClient

Public Class SqlCommand
    Inherits BaseForm

    Sub New()
        InitializeComponent()

        AddHandler Me.btnReadStatement.Click, AddressOf ReadStatement_Click
        AddHandler Me.btnInsertStatement.Click, AddressOf InstertStatement_Click
        AddHandler Me.btnUpdateStatement.Click, AddressOf UpdateStatment_Click
        AddHandler Me.btnDeleteStatement.Click, AddressOf DeleteStatment_Click
    End Sub



    Private Sub DeleteStatment_Click(sender As Object, e As EventArgs)
        Print("Delete data with a Transact-SQLstatement")

        ' connect to database
        Dim con As New SqlConnection(My.Settings.conSsl)

        ' set query
        Dim cmd = con.CreateCommand
        cmd.CommandText = "Delete FROM persons WHERE id=@value1"
        cmd.Parameters.AddWithValue("@value1", 5)

        ' open connection
        con.Open()

        Try
            ' execute query
            Dim exe As Integer = cmd.ExecuteNonQuery()
            Print(If(exe = 1, "Success", "Failed"))
        Catch ex As SqlException
            Print($"SqlException: {ex}")
        Catch ex As Exception
            Print($"Exception: {ex}")
        End Try

        ' close connection
        con.Close()
    End Sub



    Private Sub UpdateStatment_Click(sender As Object, e As EventArgs)
        Print("Update data with a Transact-SQLstatement")

        ' connect to database
        Dim con As New SqlConnection(My.Settings.conSsl)

        ' set query
        Dim cmd = con.CreateCommand
        cmd.CommandText = "Update persons Set id=@value1, first_name =@value2, last_name=@value3 WHERE id=@value1"
        cmd.Parameters.AddWithValue("@value1", 73)
        cmd.Parameters.AddWithValue("@value2", "Pierce")
        cmd.Parameters.AddWithValue("@value3", "Hawthome")

        ' open connection
        con.Open()

        Try
            ' execute query
            Dim exe As Integer = cmd.ExecuteNonQuery()
            Print(If(exe = 1, "Success", "Failed"))
        Catch ex As SqlException
            Print($"SqlException: {ex}")
        Catch ex As Exception
            Print($"Exception: {ex}")
        End Try

        ' close connection
        con.Close()
    End Sub



    Private Sub InstertStatement_Click(sender As Object, e As EventArgs)
        Print("Insert data with a Transact-SQLstatement")

        ' connect to database
        Dim con As New SqlConnection(My.Settings.conSsl)

        ' set query
        Dim cmd = con.CreateCommand
        cmd.CommandText = "INSERT INTO persons(id, first_name, last_name) VALUES (@value1, @value2, @value3)"
        cmd.Parameters.AddWithValue("@value1", 11)
        cmd.Parameters.AddWithValue("@value2", "Pierce")
        cmd.Parameters.AddWithValue("@value3", "Hawthome")

        ' open connection
        con.Open()

        Try
            ' execute query
            Dim exe As Integer = cmd.ExecuteNonQuery()
            Print(If(exe = 1, "Success", "Failed"))
        Catch ex As SqlException
            Print($"SqlException: {ex}")
        Catch ex As Exception
            Print($"Exception: {ex}")
        End Try

        ' close connection
        con.Close()
    End Sub



    Private Sub ReadStatement_Click(sender As Object, e As EventArgs)
        Print("Read data with a Transact-SQLstatement")

        ' connect to database
        Dim con As New SqlConnection(My.Settings.conSsl)

        ' set query
        Dim cmd = con.CreateCommand
        cmd.CommandText = "SELECT * FROM persons"

        ' open connection
        con.Open()

        ' OPTIONS 1 ########################################

        '' execute queary
        'Dim reader As SqlDataReader = cmd.ExecuteReader()
        'While reader.Read()
        '    Dim column1 As Integer = reader.GetInt64(0)
        '    Dim column2 As String = reader.GetString(1)
        '    Dim column3 As String = reader.GetString(2)

        '    Console.WriteLine($"{column1}, {column2}, {column3}")
        'End While

        ' OPTIONS 2 ########################################

        Try
            ' store reqeust data
            Dim adapter As New SqlDataAdapter With {
            .SelectCommand = cmd
            }

            ' create dataset
            Dim ds As New DataSet

            ' fill dataset
            adapter.Fill(ds)

            ' print dataset
            For Each row As DataRow In ds.Tables(0).Rows
                Print($"{row(0)}, {row(1)}, {row(2)}")
            Next
        Catch ex As SqlException
            Print($"SqlException: {ex}")
        Catch ex As Exception
            Print($"Exception: {ex}")
        End Try

        ' close connection
        con.Close()
    End Sub



End Class