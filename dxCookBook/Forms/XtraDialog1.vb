Imports DevExpress.XtraEditors
Imports DevExpress.XtraLayout
Imports System
Imports System.Windows.Forms


' SOURCE: https://docs.devexpress.com/WindowsForms/114567/controls-and-libraries/messages-notifications-and-dialogs/xtradialog
' display a control (for example, a UserControl) and a button set in its client area.
' supports DevExpress skins to provide a consistent appearance.

Public Class XtraDialog1
    Inherits Form

    Public Sub New()
        InitializeComponent()
        AddHandler Me.SimpleButton1.Click, AddressOf simpleButton1_Click
    End Sub

    ' Button Action
    Private Sub simpleButton1_Click(ByVal sender As Object, ByVal e As EventArgs)

        ' Declare User Control
        Dim myControl As New ucExample()

        ' Show Popup
        Dim dlg As XtraDialog
        Dim args As XtraDialogArgs = New XtraDialogArgs(caption:=Application.CompanyName, content:=myControl, buttons:=New DialogResult() {DialogResult.OK, DialogResult.Cancel})
        If XtraDialog.Show(args) = DialogResult.OK Then
            MsgBox(myControl.result)
        End If
        'Dim dlg As DevExpress.XtraEditors.XtraDialog(myControl, "Title", MessageBoxButtons.OKCancel)
        ''dlg = New XtraDialog(myControl, "", MessageBoxButtons.OKCancel)
        ''dlg.
        'If dlg.Show(myControl, "Title", MessageBoxButtons.OKCancel) = DialogResult.OK Then
        '    MsgBox(dlg.result)
        'End If

    End Sub


End Class