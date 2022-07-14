Public Class ucExample
    Public ReadOnly Property result As String
        Get
            Return TextEdit1.Text
        End Get
    End Property
    Public Sub New()
        'result = TextEdit1.Text
    End Sub
End Class
