<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddRowDataGrid
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
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.SslDataGrid1 = New sslDataGrid.sslDataGrid()
        Me.SslGridView1 = New sslDataGrid.sslGridView()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.bbAddRow = New System.Windows.Forms.Button()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.SslDataGrid1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SslGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.SslDataGrid1, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanel2, 1, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(800, 450)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'SslDataGrid1
        '
        Me.SslDataGrid1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SslDataGrid1.Location = New System.Drawing.Point(3, 3)
        Me.SslDataGrid1.MainView = Me.SslGridView1
        Me.SslDataGrid1.Name = "SslDataGrid1"
        Me.SslDataGrid1.Size = New System.Drawing.Size(394, 444)
        Me.SslDataGrid1.TabIndex = 0
        Me.SslDataGrid1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.SslGridView1})
        '
        'SslGridView1
        '
        Me.SslGridView1.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.[Default]
        Me.SslGridView1.GridControl = Me.SslDataGrid1
        Me.SslGridView1.Name = "SslGridView1"
        Me.SslGridView1.SimpleSearch = False
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 1
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.bbAddRow, 0, 3)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(403, 3)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 4
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(394, 444)
        Me.TableLayoutPanel2.TabIndex = 1
        '
        'bbAddRow
        '
        Me.bbAddRow.Dock = System.Windows.Forms.DockStyle.Fill
        Me.bbAddRow.Location = New System.Drawing.Point(3, 336)
        Me.bbAddRow.Name = "bbAddRow"
        Me.bbAddRow.Size = New System.Drawing.Size(388, 105)
        Me.bbAddRow.TabIndex = 0
        Me.bbAddRow.Text = "Add Row"
        Me.bbAddRow.UseVisualStyleBackColor = True
        '
        'AddRowDataGrid
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Name = "AddRowDataGrid"
        Me.Text = "AddRowDataGrid"
        Me.TableLayoutPanel1.ResumeLayout(False)
        CType(Me.SslDataGrid1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SslGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents SslDataGrid1 As sslDataGrid.sslDataGrid
    Friend WithEvents SslGridView1 As sslDataGrid.sslGridView
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents bbAddRow As Button
End Class
