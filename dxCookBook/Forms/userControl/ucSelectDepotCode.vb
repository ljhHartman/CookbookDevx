Imports System.ComponentModel
Imports System.Reflection

Public Class ucSelectDepotCode
    Dim blDepots As BindingList(Of SelectDepots) = New BindingList(Of SelectDepots)()



    Private Sub ucSelectDepotCode_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ' SELECT DEPOTCODE, NAAM FROM Depit
        ' ADD to Autocomplate
        ' SET Autocomplate to TextEdit
        AutocompleteDepot()

        ' SELECT DEPOTCODE FROM TextEdit
        ' SELECT RELATIECODE FROM Module.RelatieCode
        ' INSERT RELATIECODE, DEPOTCODE to RelatieDepot

    End Sub



    Private Sub AutocompleteDepot()
        Console.WriteLine(vbCrLf & $"--- {MethodBase.GetCurrentMethod().Name} ---")
        ' This Method Autocomplates the text in the Depot Textbox
        blDepots = New BindingList(Of SelectDepots)()

        ' Get DepotDataTable
        Dim dsDepots As New dsDepots.spDepotDataTable
        Dim tbaDepot As New dsDepotsTableAdapters.spDepotTableAdapter
        tbaDepot.FillSelect(dsDepots)

        ' Get Rows from DataSet
        For Each dr As DataRow In dsDepots.Rows
            blDepots.Add(New SelectDepots With {.DEPOTCODE = dr("DEPOTCODE"), .NAAM = fnDbNull(dr("NAAM"))})
        Next

        ' Create autocomplte string collection in textbox
        Dim ascDepots As AutoCompleteStringCollection = New AutoCompleteStringCollection()
        Dim strDepots() As String = blDepots.[Select](Function(s) s.DEPOTCODE & " | " & s.NAAM & " | Tag: " & s.DEPOTCODE).ToArray()
        ascDepots.AddRange(strDepots)
        Me.dtbDepots.MaskBox.AutoCompleteCustomSource = ascDepots
    End Sub



    Public Function fnDbNull(ByVal value As Object)
        ' This Method, deals with DbNull values and set them to "" string
        If IsDBNull(value) Then
            value = ""
        End If
        Return value
    End Function


    Class SelectDepots
        Property DEPOTCODE As String
        Property NAAM As String
    End Class


End Class
