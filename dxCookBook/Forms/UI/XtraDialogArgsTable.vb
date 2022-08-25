Imports DevExpress.XtraEditors

Public Class XtraDialogArgsTable

    ' On button Click open dialog
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'Open Dialog
        Dim number = XtraInputBox.Show("Enter a number:", Application.CompanyName, "")

        ' Init User Control & Send Number
        Dim ucControl As ucTableReturn = New ucTableReturn(number)

        ' Return Number from User Control
        If DevExpress.XtraEditors.XtraDialog.Show(ucControl, "Title", MessageBoxButtons.OKCancel) = DialogResult.OK Then
            Dim result As DataTable = ucControl.result
            DataGridView1.DataSource = result
        End If
    End Sub


End Class