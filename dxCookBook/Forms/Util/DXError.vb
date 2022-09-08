Imports DevExpress.XtraEditors.DXErrorProvider
'-----------------------------------------------
'                   SOURCE
'-----------------------------------------------
' https://docs.devexpress.com/WindowsForms/DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider

'-----------------------------------------------
'                   STEPS
'-----------------------------------------------
' 1. Insert Toolbox > BindingSource1
' 2. Inser Toolbox > DxErrorProvider1
' 3. Create BindSource
' 4. Create Entiy (MyRecord)
' 5. Add Enity to BindingSource
' 6. Bind TextDitors to Entity Properties
' 7. Bind DXErrorProvider to DataSource
' 8. Specify the container of controls to DxErrorProvider
' 9. Create GetPropertyError method
' 10. ?

Public Class DXError

    Sub New()
        InitializeComponent()

        '3. Set BindingSource Type
        BindingSource1.DataSource = GetType(MyRecord)

        ' 4. Create an empty MyRecord
        Dim rec As MyRecord = New MyRecord
        rec.FirstName = ""
        rec.LastName = ""

        ' 5. Add Record to BindingSource
        BindingSource1.Add(rec)

        ' 6. Bind TextEditors to MyRecord.FirstName and MyRecord.LastName properties.
        TextEdit1.DataBindings.Add(New Binding("EditValue", Me.BindingSource1, "FirstName", True))
        TextEdit2.DataBindings.Add(New Binding("EditValue", Me.BindingSource1, "LastName", True))

    End Sub

    Class MyRecord
        Implements IDXDataErrorInfo

        Property FirstName As String
        Property LastName As String

        '9.  Implements the IDXDataErrorInfo.GetPropertyError method.
        Public Sub GetPropertyError(ByVal propertyName As String, ByVal info As ErrorInfo) _
          Implements IDXDataErrorInfo.GetPropertyError
            If ((propertyName = "FirstName" AndAlso FirstName = "") _
            OrElse (propertyName = "LastName" AndAlso LastName = "")) Then
                info.ErrorText = String.Format("The '{0}' field cannot be empty", propertyName)
            End If
        End Sub

        ' 10. Implements the IDXDataErrorInfo.GetPropertyError method.
        Public Sub GetError(ByVal info As ErrorInfo) Implements IDXDataErrorInfo.GetError
        End Sub

    End Class

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        '7. Bind DXErrorProvider to DataSource
        DxErrorProvider1.DataSource = BindingSource1

        ' Specify the container of controls (textEdit1 and textEdit2) 
        ' which are monitored for errors.
        DxErrorProvider1.ContainerControl = Me

    End Sub

    Private Sub DXError_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class

