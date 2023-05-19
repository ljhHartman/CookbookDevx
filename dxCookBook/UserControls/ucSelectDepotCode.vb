Imports System.ComponentModel
Imports System.Data.SqlClient
Imports System.Reflection
Imports DevExpress.XtraEditors.DXErrorProvider

Public Class ucSelectDepotCode
    Dim blDepots As BindingList(Of SelectDepots) = New BindingList(Of SelectDepots)()
    Dim relationCode As String
    Dim relationType As String



    Sub New(iRelationCode As String)
        InitializeComponent()
        relationCode = iRelationCode

        AddHandler btnAdd.Click, AddressOf btnAdd_Click
        Autocomplete()
    End Sub



#Region "Buttons"

    Private Sub btnAdd_Click(sender As Object, e As EventArgs)
        InsertRelationType(relationType)
    End Sub

#End Region



#Region "Method"
    Private Sub Autocomplete()
        Console.WriteLine(vbCrLf & $"--- {MethodBase.GetCurrentMethod().Name} ---")

        ' This Method Autocomplates the text in the Depot, Agent, Location Textbox
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
                Me.dtbValue.MaskBox.AutoCompleteCustomSource = ascDepots

    End Sub



    Private Sub InsertRelationType(ByVal relationType As String)
        Console.WriteLine(vbCrLf & $"--- {MethodBase.GetCurrentMethod().Name} ---")
        Dim code As String = dtbValue.Text

        If code.Count < 1 Then
            ' Show Custom Warning Icon
            DxErrorProvider1.SetError(dtbValue, $"{dtbValue.Text} Select {relationType}", ErrorType.Warning)
        Else
            ' Don't show Warning Icon
            DxErrorProvider1.SetError(dtbValue, Nothing, Nothing)

            Console.WriteLine($"Relationcode: {relationCode} | {relationType}: {code}")

            ' Save RelationCode and Code into Relatie... Table
            Dim con As SqlConnection = New SqlConnection(My.Settings.conSsl)
            con.Open()
            Dim cmd As SqlCommand = New SqlCommand("spRelationDepot", con)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.Add(New SqlParameter("@SELECT", SqlDbType.NVarChar))
            cmd.Parameters.Add(New SqlParameter("@RELATIECODE", SqlDbType.NVarChar))
            cmd.Parameters.Add(New SqlParameter("@CODE", SqlDbType.NVarChar))
            cmd.Parameters(0).Value = "Depot" 'Depot, Agent, Location
            cmd.Parameters(1).Value = relationCode.ToString
            cmd.Parameters(2).Value = code.ToString 'DataTextBox selection

            cmd.ExecuteNonQuery()

            dtbValue.Text = Nothing
        End If
    End Sub


    Public Function fnDbNull(ByVal value As Object)
        ' This Method, deals with DbNull values and set them to "" string
        If IsDBNull(value) Then
            value = ""
        End If
        Return value
    End Function

#End Region



#Region "Classes"

    Class SelectDepots
        Property DEPOTCODE As String
        Property NAAM As String
    End Class


#End Region

End Class