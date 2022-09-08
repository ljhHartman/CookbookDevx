Public Class InputBoxAutocomplete

    Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        AddHandler Me.btnXtraDialog.Click, AddressOf btnXtraDialog_Click

    End Sub




    Private Sub btnXtraDialog_Click(sender As Object, e As EventArgs)

        Dim uc As New ucSelectDepotCode("My_Relation_Code", "Depot")
        DevExpress.XtraEditors.XtraDialog.Show(uc, "Add Depot", MessageBoxButtons.OKCancel)



    End Sub
End Class