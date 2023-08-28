Imports DevExpress.XtraTab

Public Class frmCharlie

    Private Sub btnSend_Click(sender As Object, e As EventArgs) Handles btnSend.Click
        ' Search Open tabs
        searchTabs()

    End Sub

    Private Sub searchTabs()
        Dim count = 0

        For Each form As Form In Application.OpenForms
            ' Search form by name
            If form.Name = "frmDelta" Then
                Debug.WriteLine(vbCrLf & $"[INFO] - Found active tab: frmDelta")

                ' Get form
                Dim targetForm As frmDelta
                targetForm = form

                ' Init form method
                targetForm.setBindingListItem(0, 100, 200, 300)

                ' Break ForeEach
                Exit For
            End If

            ' Count number of loop
            count = count + 1
            Debug.WriteLine(vbCrLf & $"[INFO] - Search tab loop: {count}")

        Next
    End Sub

End Class