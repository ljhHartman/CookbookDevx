Public Class FilesViewer
    Inherits BaseForm
    Private GileManagerView1 As FileManagerView
    Private GReadOnly As Boolean = False
    Private ID As Integer = 123456

    Sub New()
        InitializeComponent()

        GileManagerView1 = New FileManagerView(Me.SslDataGrid1, GReadOnly, ID)
    End Sub

    Private Sub FilesViewer_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class