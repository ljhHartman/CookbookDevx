Public Class FlyoutPanel

    Sub New()
        ' This call is required by the designer.
        InitializeComponent()
    End Sub



    Private Sub Button1_Click(sender As Object, e As EventArgs)

        ' Set Panel Location (below button)
        FlyoutPanel1.Options.AnchorType = DevExpress.Utils.Win.PopupToolWindowAnchor.Manual
        FlyoutPanel1.Options.Location = New Point(0, Button1.Size.Height)

        ' Show Panel
        FlyoutPanel1.ShowPopup()
    End Sub



    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        ' Set Panel Location (below button)
        FlyoutPanel2.Options.AnchorType = DevExpress.Utils.Win.PopupToolWindowAnchor.Manual
        FlyoutPanel2.Options.Location = New Point(0, Button1.Size.Height)

        ' Set Size
        FlyoutPanel2.Width = 500
        FlyoutPanel2.Height = 200

        ' Add User Control
        FlyoutPanel2.Controls.Add(New ucExample)

        ' Show Panel
        FlyoutPanel2.ShowPopup()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs)
        ' Set Panel Location (below button)
        FlyoutPanel3.Options.AnchorType = DevExpress.Utils.Win.PopupToolWindowAnchor.Manual
        FlyoutPanel3.Options.Location = New Point(0, Button1.Size.Height)

        ' Set Size
        FlyoutPanel3.Width = 500
        FlyoutPanel3.Height = 200

        ' Add User Control
        FlyoutPanel3.Controls.Add(New ucExample)

        ' Show Panel
        FlyoutPanel3.ShowPopup()
    End Sub
End Class