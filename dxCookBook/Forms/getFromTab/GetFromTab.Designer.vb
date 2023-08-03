<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class GetFromTab
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl()
        Me.tabControl = New DevExpress.XtraTab.XtraTabControl()
        Me.pageBeta = New DevExpress.XtraTab.XtraTabPage()
        Me.pageAlpha = New DevExpress.XtraTab.XtraTabPage()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.tabControl, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabControl.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupControl1
        '
        Me.GroupControl1.Controls.Add(Me.tabControl)
        Me.GroupControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupControl1.Location = New System.Drawing.Point(0, 0)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(800, 450)
        Me.GroupControl1.TabIndex = 0
        Me.GroupControl1.Text = "GroupControl1"
        '
        'tabControl
        '
        Me.tabControl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tabControl.Location = New System.Drawing.Point(2, 20)
        Me.tabControl.MultiLine = DevExpress.Utils.DefaultBoolean.[True]
        Me.tabControl.Name = "tabControl"
        Me.tabControl.SelectedTabPage = Me.pageAlpha
        Me.tabControl.Size = New System.Drawing.Size(796, 428)
        Me.tabControl.TabIndex = 0
        Me.tabControl.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.pageAlpha, Me.pageBeta})
        '
        'pageBeta
        '
        Me.pageBeta.Name = "pageBeta"
        Me.pageBeta.Size = New System.Drawing.Size(790, 400)
        Me.pageBeta.Text = "page_beta"
        '
        'pageAlpha
        '
        Me.pageAlpha.Name = "pageAlpha"
        Me.pageAlpha.Size = New System.Drawing.Size(790, 400)
        Me.pageAlpha.Text = "page_alpha"
        '
        'GetFromTab
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.GroupControl1)
        Me.Name = "GetFromTab"
        Me.Text = "GetFromTab"
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        CType(Me.tabControl, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabControl.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents tabControl As DevExpress.XtraTab.XtraTabControl
    Friend WithEvents pageBeta As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents pageAlpha As DevExpress.XtraTab.XtraTabPage
End Class
