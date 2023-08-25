Public Class InheritBaseForm
    Inherits BaseForm

    Sub New()
        InitializeComponent()
    End Sub

    Private Sub BtnWarningMessageBox_Click(sender As Object, e As EventArgs) Handles btnWarningMessageBox.Click
        WarningMessageBox("ENGLISH", "save")
    End Sub

    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        Print("This is an exmaple of print to output")
    End Sub
End Class