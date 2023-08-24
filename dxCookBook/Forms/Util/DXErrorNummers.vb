Imports DevExpress.XtraEditors.DXErrorProvider

Public Class DXErrorNummers
    Dim icon1 As Image = Image.FromFile("\\burandoholding.int\shares\UserData\lucas.hartman\My Documents\My Pictures\vomiting.png")



    Private Sub DXErrorNummers_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AddHandler DXErrorProvider.GetErrorIcon, AddressOf DXErrorProvider_GetErrorIcon
    End Sub



    ' Provide an error icon for the User1 error type.
    Private Sub DXErrorProvider_GetErrorIcon(ByVal e As GetErrorIconEventArgs)
        If e.ErrorType = ErrorType.User1 Then e.ErrorIcon = icon1
    End Sub



    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim intVar As Integer
        If Integer.TryParse(TextEdit1.Text, intVar) Then 'Try to parse user inpt to Integer variable 
            If intVar < 0 Or intVar > 100 Then
                ' Show Custom Icon
                DxErrorProvider1.SetError(TextEdit1, $"{Label1.Text} must be between 0 and 100", ErrorType.User1)
            Else
                ' Don't show Icon
                DxErrorProvider1.SetError(TextEdit1, Nothing, Nothing)
            End If
        Else
            ' Show Warning Icon
            DxErrorProvider1.SetError(TextEdit1, $"{Label1.Text} field is empty", ErrorType.Warning)
        End If


    End Sub
End Class
