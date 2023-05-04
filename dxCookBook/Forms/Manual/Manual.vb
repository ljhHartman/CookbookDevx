Public Class Manual
    Private Sub Manual_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim myControl As New ucManual()
        DevExpress.XtraEditors.XtraDialog.Show(myControl, "Manual", MessageBoxButtons.OK)
        'If DevExpress.XtraEditors.XtraDialog.Show(myControl, "Manual", MessageBoxButtons.OK) = DialogResult.OK Then

        'End If
    End Sub
End Class