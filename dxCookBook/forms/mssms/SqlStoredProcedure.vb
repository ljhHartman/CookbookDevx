Imports System.Data.SqlClient

Public Class SqlStoredProcedure
    Inherits BaseForm

    Sub New()
        InitializeComponent()

        AddHandler Me.btnReadStatement.Click, AddressOf ReadProcedure_Click
        AddHandler Me.btnInsertStatement.Click, AddressOf InsertProcedure_Click
        AddHandler Me.btnUpdateStatement.Click, AddressOf UpdateProcedure_Click
        AddHandler Me.btnDeleteStatement.Click, AddressOf DeleteProcedure_Click
    End Sub



    Private Sub DeleteProcedure_Click()
        Print("Delete data with a Stored Procedure")

        ' connect to database
        Dim con As New SqlConnection(My.Settings.conSsl)

        ' set command
        Dim cmd = con.CreateCommand
        cmd.CommandType = CommandType.StoredProcedure
        cmd.CommandText = "spPersonsDelete"
        cmd.Parameters.AddWithValue("@ID", 5)

        ' open connections
        con.Open()

        Try
            ' execute procedure
            cmd.ExecuteNonQuery()
        Catch ex As SqlException
            Print($"SqlException: {ex}")
        Catch ex As Exception
            Print($"Exception: {ex}")
        End Try

        ' close connection
        con.Close()
    End Sub



    Private Sub UpdateProcedure_Click()
        Print("Update data with a Stored Procedure")

        ' connect to database
        Dim con As New SqlConnection(My.Settings.conSsl)

        ' set command
        Dim cmd = con.CreateCommand
        cmd.CommandType = CommandType.StoredProcedure
        cmd.CommandText = "spPersonsUpdate"
        cmd.Parameters.AddWithValue("@ID", 5)
        cmd.Parameters.AddWithValue("@First_Name", "Pierce")
        cmd.Parameters.AddWithValue("@Last_Name", "Hawthome")

        ' open connections
        con.Open()

        Try
            ' execute procedure
            cmd.ExecuteNonQuery()
        Catch ex As SqlException
            Print($"SqlException: {ex}")
        Catch ex As Exception
            Print($"Exception: {ex}")
        End Try

        ' close connection
        con.Close()
    End Sub



    Private Sub InsertProcedure_Click()
        Print("Insert data with a Stored Procedure")

        ' connect to database
        Dim con As New SqlConnection(My.Settings.conSsl)

        ' set command
        Dim cmd = con.CreateCommand
        cmd.CommandType = CommandType.StoredProcedure
        cmd.CommandText = "spPersonsInsert"
        cmd.Parameters.AddWithValue("@ID", 6)
        cmd.Parameters.AddWithValue("@First_Name", "Pierce")
        cmd.Parameters.AddWithValue("@Last_Name", "Hawthome")

        ' open connections
        con.Open()

        Try
            ' execute procedure
            cmd.ExecuteNonQuery()
        Catch ex As SqlException
            Print($"SqlException: {ex}")
        Catch ex As Exception
            Print($"Exception: {ex}")
        End Try

        ' close connection
        con.Close()
    End Sub



    Private Sub ReadProcedure_Click(sender As Object, e As EventArgs)
        Print("Read data with a Stored Procedure")

        ' connect to database
        Dim con As New SqlConnection(My.Settings.conSsl)

        ' set command
        Dim cmd = con.CreateCommand
        cmd.CommandType = CommandType.StoredProcedure
        cmd.CommandText = "spPersonsSelect"
        cmd.Parameters.AddWithValue("@ID", 1)

        ' OPTIONS 1 ########################################

        ' open connection
        con.Open()

        Try
            ' execute queary
            Dim reader As SqlDataReader = cmd.ExecuteReader()
            While reader.Read()
                Dim column1 As Integer = reader.GetInt64(0)
                Dim column2 As String = reader.GetString(1)
                Dim column3 As String = reader.GetString(2)

                Print($"{column1}, {column2}, {column3}")
            End While
        Catch ex As SqlException
            Print($"SqlException: {ex}")
        Catch ex As Exception
            Print($"Exception: {ex}")
        End Try

        ' close connection
        con.Close()

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
    End Sub



End Class



' ----------------------------------------
'       Create Stored Procedure
' ----------------------------------------
' 1. MSSMS > Database > SSLTEST > Programmability > Stored Procedures > Right Click > New > stored procedure

' 2. Set author, create date & description
'   --=============================================
'   -- Author:		    Lucas Hartman
'   -- Create date:    04/09/2023
'   -- Description:    Insert person to Persons
'   --=============================================

'3. Set stored procedure name
'   CREATE PROCEDURE spPersons_Select

'4. Set Parameters
'   	@ID int,
'       @First_Name VARCHAR(33),
'       @Last_Name VARCHAR(33)

' Set Query
'   SELECT id,first_name,last_name FROM persons WHERE id=@ID;
'   INSERT INTO persons(id, first_name, last_name) VALUES (@ID, @First_Name, @Last_Name)
'   UPDATE persons Set id=@ID, first_name = @First_Name, last_name=@Last_Name WHERE id=@ID
'   Delete FROM persons WHERE id=@ID



' ----------------------------------------
'       Test Stored Procedure in MSSMS
' ----------------------------------------
'1. Select stored procedure > Right click > Execute Stored Procedure
'2. Input Value
