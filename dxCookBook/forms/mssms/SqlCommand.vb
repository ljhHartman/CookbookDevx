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
        cmd.CommandText = "Delete FROM persons WHERE id=5"

        ' open connection
        con.Open()

        ' execute query
        Dim exe As Integer = cmd.ExecuteNonQuery()
        Print(If(exe = 1, "Success", "Failed"))

        ' close connection
        con.Close()
    End Sub



    Private Sub UpdateStatment_Click(sender As Object, e As EventArgs)
        Print("Update data with a Transact-SQLstatement")

        ' connect to database
        Dim con As New SqlConnection(My.Settings.conSsl)

        ' set query
        Dim cmd = con.CreateCommand
        cmd.CommandText = "Update persons Set id=5, first_name ='Annie', last_name='Edison' WHERE id=5"

        ' open connection
        con.Open()

        ' execute query
        Dim exe As Integer = cmd.ExecuteNonQuery()
        Print(If(exe = 1, "Success", "Failed"))

        ' close connection
        con.Close()
    End Sub



    Private Sub InstertStatement_Click(sender As Object, e As EventArgs)
        Print("Insert data with a Transact-SQLstatement")

        ' connect to database
        Dim con As New SqlConnection(My.Settings.conSsl)

        ' set query
        Dim cmd = con.CreateCommand
        cmd.CommandText = "INSERT INTO persons(id, first_name, last_name) VALUES (5, 'Jeff', 'Winter')"

        ' open connection
        con.Open()

        ' execute query
        Try
            Dim exe As Integer = cmd.ExecuteNonQuery()
            Print(If(exe = 1, "Success", "Failed"))
        Catch ex As SqlException
            Print("Cannot insert duplicate key")
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

        ' execute queary
        Dim reader As SqlDataReader = cmd.ExecuteReader()
        While reader.Read()
            Dim column1 As Integer = reader.GetInt64(0)
            Dim column2 As String = reader.GetString(1)
            Dim column3 As String = reader.GetString(2)

            Console.WriteLine($"{column1}, {column2}, {column3}")
        End While

        ' close connection
        con.Close()
    End Sub

End Class