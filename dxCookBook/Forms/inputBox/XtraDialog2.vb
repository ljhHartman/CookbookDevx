Public Class XtraDialog2

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim myControl As New ucExample()
        If DevExpress.XtraEditors.XtraDialog.Show(myControl, "Title", MessageBoxButtons.OKCancel) = DialogResult.OK Then
            Dim result As String = myControl.result
            MsgBox(result)
        End If

    End Sub

End Class