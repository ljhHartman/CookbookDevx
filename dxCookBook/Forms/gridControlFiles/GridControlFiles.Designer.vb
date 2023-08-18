<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class GridControlFiles
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
        Me.gcAttachments = New sslDataGrid.sslDataGrid()
        Me.winExplorerView = New sslDataGrid.sslGridView()
        CType(Me.gcAttachments, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.winExplorerView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gcAttachments
        '
        Me.gcAttachments.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gcAttachments.Location = New System.Drawing.Point(0, 0)
        Me.gcAttachments.MainView = Me.winExplorerView
        Me.gcAttachments.Name = "gcAttachments"
        Me.gcAttachments.Size = New System.Drawing.Size(800, 450)
        Me.gcAttachments.TabIndex = 0
        Me.gcAttachments.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.winExplorerView})
        '
        'winExplorerView
        '
        Me.winExplorerView.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.[Default]
        Me.winExplorerView.GridControl = Me.gcAttachments
        Me.winExplorerView.Name = "winExplorerView"
        Me.winExplorerView.OptionsBehavior.Editable = False
        Me.winExplorerView.SimpleSearch = False
        '
        'GridControlFiles
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.gcAttachments)
        Me.Name = "GridControlFiles"
        Me.Text = "GridControlFiles"
        CType(Me.gcAttachments, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.winExplorerView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents gcAttachments As sslDataGrid.sslDataGrid
    Friend WithEvents winExplorerView As sslDataGrid.sslGridView
End Class
