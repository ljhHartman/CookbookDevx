
Public Class ucManual

    ' TableLayout : tlContiner
    ' NavBarControl : nbcList
    ' RichTextBox : rtbView

    Public Sub New()
        InitializeComponent()

        ' RichTextBox Config
        rtbView.ReadOnly = True
        rtbView.Multiline = True
        rtbView.Font = New Font("Georgia", 10)

        ' Handlers
        AddHandler Me.alpha.LinkClicked, AddressOf Alpha_Click
    End Sub

#Region "Buttons"

    Private Sub Alpha_Click(sender As Object, e As EventArgs)
        LoadText("Alpah", "Hello World")
    End Sub

#End Region


#Region "Methods"

    Private Sub LoadText(title As String, text As String)
        rtbView.Clear()
        rtbView.Focus()
        rtbView.Text = title + Environment.NewLine + Environment.NewLine + text
    End Sub

#End Region

End Class
