<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDelta
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.SslDataGrid1 = New sslDataGrid.sslDataGrid()
        Me.SslGridView1 = New sslDataGrid.sslGridView()
        CType(Me.SslDataGrid1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SslGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SslDataGrid1
        '
        Me.SslDataGrid1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SslDataGrid1.Location = New System.Drawing.Point(0, 0)
        Me.SslDataGrid1.MainView = Me.SslGridView1
        Me.SslDataGrid1.Name = "SslDataGrid1"
        Me.SslDataGrid1.Size = New System.Drawing.Size(800, 450)
        Me.SslDataGrid1.TabIndex = 2
        Me.SslDataGrid1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.SslGridView1})
        '
        'SslGridView1
        '
        Me.SslGridView1.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.[Default]
        Me.SslGridView1.GridControl = Me.SslDataGrid1
        Me.SslGridView1.Name = "SslGridView1"
        Me.SslGridView1.SimpleSearch = False
        '
        'frmDelta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.SslDataGrid1)
        Me.Name = "frmDelta"
        Me.Text = "frmDelta"
        CType(Me.SslDataGrid1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SslGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents SslDataGrid1 As sslDataGrid.sslDataGrid
    Friend WithEvents SslGridView1 As sslDataGrid.sslGridView
End Class
