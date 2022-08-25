Imports DevExpress.XtraTab
Imports DevExpress.XtraTab.ViewInfo


'-------------------------------------------
' Set close button on all Tabs
'-------------------------------------------
' XtraTabControl Properties > ClosePageButtonShowMode: InAllTabPageHeders

Public Class CloseTabControleAction

    Private Sub btnNewTab_Click(sender As Object, e As EventArgs) Handles btnNewTab.Click
        ' Create a new tab, showing a form, if the from does not already exist
        Dim frmLoad As Form = New SampleForm()
        Dim strName As String = "Sample Form"

        'Check if tabpage is already open, if open select tabpage and return
        For Each tp As XtraTabPage In tcForms.TabPages
            If tp.Text = strName Then
                tcForms.SelectedTabPage = tp
                MsgBox("Tab already exist")
                Exit Sub
            End If
        Next

        ' Create New Tab
        Dim tpTmp As XtraTabPage = New XtraTabPage()
        Dim frmToLoad As Form = New Form()
        'Set form to load
        frmToLoad = frmLoad
        frmToLoad.TopLevel = False
        frmToLoad.Height = 300
        frmToLoad.Width = 400

        'Set tabpage and add form
        tpTmp.Text = strName
        tpTmp.Controls.Add(frmToLoad)
        frmToLoad.FormBorderStyle = FormBorderStyle.None
        frmToLoad.Show()
        tpTmp.Tag = tcForms.SelectedTabPageIndex
        'Add tabpage to tabcontrol and set selected page to the new tabcontrol
        tcForms.TabPages.Add(tpTmp)
        tcForms.SelectedTabPage = tpTmp

    End Sub

    Private Sub XtraTabControl1_CloseButtonClick(ByVal sender As System.Object,
        ByVal e As System.EventArgs) Handles tcForms.CloseButtonClick
        ' When Click Close Button on a Tab.
        ' This action finds which tab to close
        ' But first deletes the From inside the selected TabPage
        ' And lasty delete the selected TabPage
        Dim arg As ClosePageButtonEventArgs = TryCast(e, ClosePageButtonEventArgs)

        ' Look for Form in TabPage and Delete From
        Dim tpTmp As XtraTabPage = CType(arg.Page, XtraTabPage)
        Dim frmToClose As Form = New Form()
        If tpTmp.Controls.Count > 0 Then
            frmToClose = CType(tpTmp.Controls(0), Form)
            'MsgBox($"Delete From {frmToClose.Text}")
            frmToClose.Close()
        End If

        ' Delete Tab
        tcForms.TabPages.Remove(CType(arg.Page, XtraTabPage))

        ' Message
        MsgBox($"Close Tab: {arg.Page.Text.ToString}")
    End Sub

End Class