Imports System.ComponentModel
Imports System.Data.SqlClient


Public Class Grid2Grid

    'Tutorial
    ' 1. Build View
    '   - SSMS > Object Explorer > Views > New View
    '   - Add Table(s)
    '   - Select Properties

    ' 2. Build DataSet with Query+Parameter 
    '   - MVS > Solution Explorer > [Data]: RMB > Add > New Item > DataSet
    '   - Drag Item from Server Explores

    ' 3. GridControl
    '   - Create GridControl
    '   - Add Table:                GridControl.TopLeftIcon > Choose DataSources > ds[NAME] > vw[Name]
    '   - Keep Column Names Only:   GridControl.tOPlEFTiCON > Choose DataSource > None
    '   - Remove all Icons below Design (this will create an error)
    '   - Remove line from Design:          
    '                                       TODO: This line of code loads data into the 'DsIncomingInvoiceLines.vwIncomingInvoiceLines' table. You can move, or remove it, as needed.
    '                                       Me.VwIncomingInvoiceLinesTableAdapter.Fill(Me.DsIncomingInvoiceLines.vwIncomingInvoiceLines)
    ' Show Horizontal Scroll:
    '                                       GridView1.OptionsView.ColumnAutoWidth = False
    '                                       GridView1.HorzScrollVisibility = True



    Public Sub New()
        InitializeComponent()
        'Me.CostRevenueTableAdapter.Fill(Me.DsCostRevenue.vwCostRevenue) 'Fill GridView - CostRevenue 
        Dim table1 As DataTable = GetCostRevenueTable() ' Fill Table1
        Dim bl As BindingList(Of NewIncomingInvoiceLine) = Table2Bindlist(table1) ' Fill BindingList 
        GridControl1.DataSource = bl ' Fill GriedView
    End Sub



    Private Function GetCostRevenueTable() As DataTable
        ' This Method, gets Database.Table: KostenOpbrengsten and fill into a table 
        Dim unused As New SqlDataAdapter
        Dim tb As New DataTable()
        Dim con As New SqlConnection("Server=SQLCluster01\Burando; Database=SSLTEST; Trusted_Connection=True")
        Dim strSql = "Select * from vwCostRevenue WHERE DOSSIERNUMMER = 81732"
        con.Open()
        Dim sda As New SqlDataAdapter(strSql, con)
        sda.Fill(tb)
        Return tb
    End Function



    Private Function Table2Bindlist(tb As DataTable) As Object
        ' Fill GridView(New Incoming Invoice)  with the data from CostRevenue 
        Dim bl As New BindingList(Of NewIncomingInvoiceLine)
        For i As Integer = 1 To tb.Rows.Count - 1
            bl.Add(New NewIncomingInvoiceLine With {
            .IFACTUURREGELNUMMER = tb.Rows(0)("IFACTUURREGELNUMMER"),
            .BTWBEDRAG = Nothing,
            .FACTUURNUMMER = Nothing,
            .REGELNUMMER = Nothing,
            .KOSTCODE = tb.Rows(0)("KOSTCODE").ToString(),
            .DOSSIERNUMMER = tb.Rows(0)("DOSSIERNUMMER").ToString(),
            .OMSCHRIJVING = tb.Rows(0)("OMSCHRIJVING").ToString(),
            .RELATIE = Nothing,
            .PRIJS = Nothing,
            .AANTAL = Nothing,
            .BEDRAG = Nothing,
            .VALUTA = Nothing,
            .BTWCODE = Nothing,
            .WISSELKOERS = Nothing,
            .BEDRAGEURO = Nothing,
            .PERIODE = Nothing,
            .GROOTBOEKNUMMER = Nothing})
        Next
        Return bl
    End Function



    Private Class NewIncomingInvoiceLine
        Property IFACTUURREGELNUMMER As String
        Property BTWBEDRAG As String
        Property FACTUURNUMMER As String
        Property REGELNUMMER As String
        Property KOSTCODE As String
        Property DOSSIERNUMMER As String
        Property OMSCHRIJVING As String
        Property RELATIE As String
        Property PRIJS As String
        Property AANTAL As String
        Property BEDRAG As String
        Property VALUTA As String
        Property BTWCODE As String
        Property WISSELKOERS As String
        Property BEDRAGEURO As String
        Property PERIODE As String
        Property GROOTBOEKNUMMER As String
    End Class

    Private Sub Grid2Grid_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class