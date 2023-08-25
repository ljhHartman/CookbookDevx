Imports DevExpress.XtraTab
Imports dxCookBook

Public Class dataTab2Tab
    Private Sub GetFromTab_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Create tab with form content
        LoadForm(New frmCharlie(), "page_charie")
        LoadForm(New frmDelta(), "page_delta")
    End Sub


    Public Sub LoadForm(ByVal targetForm As Form, ByVal tabTitle As String)
        ' Create tabpage
        Dim tabPage As XtraTabPage = New XtraTabPage()

        ' Create form
        Dim form As Form = New Form()
        form = targetForm
        form.TopLevel = False
        form.Width = 600
        form.Height = 300
        form.FormBorderStyle = FormBorderStyle.None

        ' Add from to tabpage
        tabPage.Controls.Add(form)
        tabPage.Text = tabTitle
        form.Show()

        ' Add tabpage to tabControl
        tabControl.TabPages.Add(tabPage)
    End Sub

End Class