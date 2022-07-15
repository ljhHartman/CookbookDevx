Imports DevExpress.XtraEditors

Public Class XtraDialogArgs1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'Open Dialog
        Dim number = XtraInputBox.Show("Enter a number:", Application.CompanyName, "")

        ' Init User Control & Send Number
        Dim ucControl As ucArg = New ucArg(number)

        ' Return Number from User Control
        If DevExpress.XtraEditors.XtraDialog.Show(ucControl, "Title", MessageBoxButtons.OKCancel) = DialogResult.OK Then
            Dim result As String = ucControl.result
            MsgBox("receive " & result)
        End If

    End Sub
End Class