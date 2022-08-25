Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.DXErrorProvider

Public Class MessageBoxError

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        ' Create Custom TextBox
        Dim editor As New TextEdit()

        ' Create XtraInputBoxArgs
        Dim args As New XtraInputBoxArgs()
        args.Caption = "Title"
        args.Prompt = "Feed me text"
        args.Editor = editor

        ' Check user input
        While True
            Dim result = XtraInputBox.Show(args)
            If result = Nothing Then ' If empyt or Cancel button
                Exit Sub
            ElseIf result.ToString.Count > 8 Then ' Show ErrorProveder
                DxErrorProvider1.SetError(editor, $"Max 8 characters", ErrorType.Warning)
            ElseIf result.ToString.Count <= 8 Then ' Continue
                Exit Sub
            End If
        End While
    End Sub

End Class