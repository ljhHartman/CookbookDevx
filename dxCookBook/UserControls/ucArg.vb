Public Class ucArg
    Public Sub New(arg As String)
        InitializeComponent()
        MsgBox("Get Nummber " & arg)
    End Sub

    Public ReadOnly Property result As String
        Get
            Return TextEdit1.Text
        End Get
    End Property

End Class
