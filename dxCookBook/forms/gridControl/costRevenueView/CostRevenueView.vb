Imports System.Data.SqlClient
Imports System.Reflection
Imports DevExpress.XtraEditors
Imports DevExpress.XtraGrid.Views.Grid



Public Class CostRevenueView
    Inherits BaseForm
    Private ReadOnly Gc As CostRevenueView1

    Sub New()
        InitializeComponent()
        Gc = New CostRevenueView1(Me.SslDataGrid1)
    End Sub



#Region "Classes"

    Public Class CostRevenueView1
        Private bReadOnly As Boolean = False
        Private WithEvents Gc As sslDataGrid.sslDataGrid
        Private ReadOnly Dt As DataTable
        Private WithEvents Gv As GridView
        Private ReadOnly Ds As Object
        Private ReadOnly Tba As Object
        Private ReadOnly Cms As New ContextMenuStrip()
        Private WithEvents CmsItemOpen As New ToolStripMenuItem()
        Private WithEvents CmsItemNew As New ToolStripMenuItem()
        Private WithEvents CmsItemSort As New ToolStripMenuItem()
        Private WithEvents CmsItemDelete As New ToolStripMenuItem()



        Public Sub New(ByRef gridcontrol As sslDataGrid.sslDataGrid)
            Gc = gridcontrol
            Gv = Gc.MainView
            Ds = New dsCostRevenue.spCostRevenueDataTable ' Sql Table: KostenOpbrengsten
            Tba = New dsCostRevenueTableAdapters.spCostRevenueTableAdapter
            Dt = New DataTable

            ' Fill table details
            Tba.Fill(Ds, 1950) ' a.k.a Konummer
            Dt = Ds
            Gc.DataSource = Dt

            ' Gridview settings
            Gv.OptionsView.ColumnAutoWidth = False
            Gv.HorzScrollVisibility = True
            Gv.OptionsBehavior.Editable = False
            Gv.OptionsView.ShowGroupPanel = False
            Gv.OptionsFind.AllowFindPanel = True
            Gv.OptionsFind.AlwaysVisible = True
            Gv.OptionsView.ShowFooter = True

            ' ContextMenuStrip Settings
            CmsItemOpen.Name = "Open"
            CmsItemOpen.Text = "Open"
            CmsItemNew.Name = "New"
            CmsItemNew.Text = "New"
            CmsItemDelete.Name = "Delete"
            CmsItemDelete.Text = "Delete"
            Cms.Items.Add(CmsItemOpen)
            Cms.Items.Add(CmsItemNew)
            Cms.Items.Add(CmsItemDelete)

            ' Handlers
            AddHandler Gc.DoubleClick, AddressOf CmsItemOpen_Click
            AddHandler Gv.Click, AddressOf ShowContextMenuStrip_RightClick
            AddHandler CmsItemOpen.Click, AddressOf CmsItemOpen_Click
            AddHandler CmsItemNew.Click, AddressOf CmsItemNew_Click
            AddHandler CmsItemDelete.Click, AddressOf CmsItemDelete_Click
        End Sub



#Region "Handlers"

        Private Sub ShowContextMenuStrip_RightClick(sender As Object, e As DevExpress.Utils.DXMouseEventArgs)
            Print("Right mouse click handler, show popup-menu")
            Dim dataRow As DataRow = Gv.GetFocusedDataRow()
            Try
                If e.Button = MouseButtons.Right And dataRow("konummer") > 0 Then Cms.Show(MousePosition)
            Catch ex As NullReferenceException
                Print($"No row was selected: {ex.Message}")
            End Try
        End Sub

        Private Sub CmsItemOpen_Click(ByVal sender As Object, ByVal e As EventArgs)
            Dim dataRow As DataRow = Gv.GetFocusedDataRow()
            MsgBox($"Selected row id: {dataRow("Konummer")}")
            ' GridView3_DoubleClick
        End Sub

        Private Sub CmsItemNew_Click(ByVal sender As Object, ByVal e As EventArgs)
            Dim dataRow As DataRow = Gv.GetFocusedDataRow()
            MsgBox($"New Row")
            ' BtnNewCostRevenue_Click
        End Sub

        Private Sub CmsItemSort_Click(ByVal sender As Object, ByVal e As EventArgs)
            Dim dataRow As DataRow = Gv.GetFocusedDataRow()
            MsgBox($"Sort")
        End Sub

        Private Sub CmsItemDelete_Click(sender As Object, e As EventArgs)
            If Not bReadOnly Then
                ' Get Selected Row
                Dim dataRow As DataRow = Gv.GetFocusedDataRow()

                ' Exectue StoredProcedure
                'Dim con As New SqlConnection(My.Settings.conSsl)
                'Dim cmd As New SqlCommand("spDeleteCostRevenue", con) With {
                '    .CommandType = CommandType.StoredProcedure
                '}
                'cmd.Parameters.AddWithValue("@CRCODE", dataRow("Konummer"))
                'con.Open()
                'cmd.ExecuteNonQuery()

                '' Check if Execute Query was successful
                'If cmd.ExecuteNonQuery() > 0 Then
                '    dataRow.Delete()
                'Else
                '    XtraMessageBox.Show("Delete row was not successful", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                'End If
                'con.Close()
            End If
        End Sub

#End Region ' Handlers



#Region "Methods"

        Private Sub Print(ByVal description As String)
            ' Get parent method
            Dim sf As New StackFrame(1, True)
            Dim parentMethod As MethodBase = sf.GetMethod()
            Dim dots As String = New String(".", 50 - parentMethod.Name.Count())
            ' Print
            Debug.WriteLine($"[INFO]...{parentMethod.Name}:{dots}{description}")
        End Sub

#End Region ' Methods


#Region "Notes"

        ' -----------------------------------------------------
        ' Stored Procedure Name
        ' -----------------------------------------------------
        ' SSLTEST > Programmability >
        ' dbo.spCostRevenue 
        ' spDeleteCostRevenue

        ' -----------------------------------------------------
        ' SQL talbe Queries:
        ' -----------------------------------------------------
        ' Select * from KostenOpbrengsten where KONUMMER = 1950

#End Region ' Notes

    End Class

    Private Sub CostRevenueView_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub


#End Region ' Classes

End Class 'CostRevenueView