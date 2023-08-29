
Public Class InheritBaseForm
    Inherits BaseForm


    Sub New()
        InitializeComponent()

        '  Initialize time thicker from the BaseForm
        AddHandler aTimer.Elapsed, AddressOf OnTimedEvent
    End Sub

    Private Sub BtnWarningMessageBox_Click(sender As Object, e As EventArgs) Handles btnWarningMessageBox.Click
        WarningMessageBox("ENGLISH", "save")
    End Sub

    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        Print("This is an exmaple of print to output")
    End Sub

    Private Sub InheritBaseForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class