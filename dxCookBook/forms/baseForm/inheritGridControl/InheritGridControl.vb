
Imports DevExpress.XtraEditors.TextEditController.Win32

Public Class InheritGridControl
    Inherits BaseForm
    Private BaseGridControlExmaple As BaseGridControl

    Sub New()
        InitializeComponent()
        BaseGridControlExmaple = New BaseGridControl(
            SslDataGrid1,
            New dsAlphaTable.AlphaTableDataTable(),
            New dsAlphaTableTableAdapters.AlphaTableTableAdapter()
            )
    End Sub


End Class