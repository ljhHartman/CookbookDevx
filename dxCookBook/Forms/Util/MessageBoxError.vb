Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.DXErrorProvider

Public Class MessageBoxError

    Sub New()
        InitializeComponent()
        AddHandler btnSave.Click, AddressOf btnSave_Click
        AddHandler btnRelactionCode.Click, AddressOf btnRelactionCode_Click
    End Sub


#Region "Button"

    Private Sub btnSave_Click(sender As Object, e As EventArgs)
        ValidateEditBox()
    End Sub

    Private Sub btnRelactionCode_Click(sender As Object, e As EventArgs)
        ValidateInputBoxArgs()
    End Sub

#End Region


#Region "Method"

    Private Sub ValidateEditBox()
        ' This Method checks the input from a user in the EditBox
        ' If the user input is greater than 8, an error is provided
        ' If the user input is empty, an error is provided
        ' If the user input is correct, an error would be provided
        Dim rc As String = teRelationCode.Text
        If rc = Nothing Then
            DxErrorProvider1.SetError(teRelationCode, $"Relation Code field is empty", ErrorType.Warning)
        ElseIf rc.Count > 8 Then
            DxErrorProvider1.SetError(teRelationCode, $"Relation Code should have Max 8 character", ErrorType.Warning)
        Else
            DxErrorProvider1.SetError(teRelationCode, Nothing, ErrorType.None)
        End If
    End Sub

    Private Sub ValidateInputBoxArgs()
        ' This Method creates an InputBox, which the user can put in a new Relocation code
        ' If the user input is greater than 8, an error is provided
        ' If the user input is empty, the TextEdit won't be updated
        ' If the user input is correct the TextEdit will inherit the user input

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
                teRelationCode.Text = result
                Exit Sub
            End If
        End While
    End Sub

#End Region

End Class