Imports System.Text
Imports Microsoft.VisualStudio.TestTools.UnitTesting
Imports System.IO
Imports System.Net
Imports System.Data.SqlClient

'------------------------------------------------------------
'                      Tutorial
'------------------------------------------------------------
' Add Dependencies:         Solution Explorer > References > Add References: Microsoft.VisualStudio.QualityTools.UnitTestFramework & Microsoft.VisualStudio.TestTools.UITest.Extension
' Creaete Folder:           Unit-Testing
' Create Class:             Tests.vb
' Create Test Methods
' Run Test:                 Test > All Tests (Ctrl+A,R)
' Check Result              Test Explorer Panel

<TestClass()> Public Class Tests


    <TestMethod()> Public Sub GetSQLColumnNames()
        Dim table1 As DataTable = New DataTable()

        Dim strSql As String
        Dim sda As New SqlDataAdapter

        ' Connect to Database
        Dim con As New SqlConnection("Server=SQLCluster01\Burando; Database=SSLTEST;  Trusted_Connection=True")
        con.Open()

        'Sql Expresion
        'SqlDataAdapter to Table 1
        'strSql = "Select * from vwCostRevenue" ' vwCostRevenue
        strSql = "Select * from VwIncomingInvoiceLines" ' VwIncomingInvoiceLines
        sda = New SqlDataAdapter(strSql, con)
        sda.Fill(table1)

        ' Get Column Names
        For i As Integer = 0 To table1.Columns.Count - 1

            Dim columnName As String = table1.Columns(i).ColumnName
            Console.WriteLine($"Column {i} : {columnName}")
        Next
        con.Close()
    End Sub




End Class
