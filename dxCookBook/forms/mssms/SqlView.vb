Imports System.Data.SqlClient

Public Class SqlView
    Inherits BaseForm



    Sub New()
        InitializeComponent()

        AddHandler Me.btnReadStatement.Click, AddressOf ReadView_Click
        AddHandler Me.btnInsertStatement.Click, AddressOf InsertView_Click
    End Sub



    Private Sub InsertView_Click()
        Print("Insert data into View")

        ' connect to database
        Dim con As New SqlConnection(My.Settings.conSsl)

        ' set command
        Dim cmd = con.CreateCommand
        cmd.CommandText = "INSERT INTO vwPersons(id,first_name,last_name,name,radius) VALUES(@value1, @value2, @value3, @value4, @value5)"
        cmd.Parameters.AddWithValue("@value1", 69)
        cmd.Parameters.AddWithValue("@value2", "Pierce")
        cmd.Parameters.AddWithValue("@value3", "Hawthome")
        cmd.Parameters.AddWithValue("@value4", "Venus")
        cmd.Parameters.AddWithValue("@value5", 60268)

        ' open connection
        con.Open()

        Try
            ' Exectue query
            cmd.ExecuteNonQuery()
        Catch ex As SqlException
            Print($"SqlException: ITS NOT POSSIBLE TO UPDATE A VIEW, ITS READ ONLY!!!")
        Catch ex As Exception
            Print($"Exception: {ex}")
        End Try

        'close connection
        con.Close()
    End Sub



    Private Sub ReadView_Click(sender As Object, e As EventArgs)
        Print("Read data from View")

        ' connect to database
        Dim con As New SqlConnection(My.Settings.conSsl)

        ' set query
        Dim cmd = con.CreateCommand
        cmd.CommandText = "SELECT * FROM vwPersons"

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
                Print($"{row(0)}, {row(1)}, {row(2)}, {row(3)}, {row(4)}")
            Next
        Catch ex As SqlException
            Print($"SqlException: {ex}")
        Catch ex As Exception
            Print($"Exception: {ex}")
        End Try
    End Sub



End Class

' ----------------------------------------
'               Create View
' ----------------------------------------
'1. MSSMS > Database > SSLTEST > Views > Right Click > New View
'2. Select tables
'3. Select which columns you want to select, for this view
'4. Save View