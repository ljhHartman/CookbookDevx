<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class DropFiles
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
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl()
        Me.WinExplorerView1 = New DevExpress.XtraGrid.Views.WinExplorer.WinExplorerView()
        Me.columnName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.columnPath = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.columnCheck = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.columnGroup = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.columnImage = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.WinExplorerView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.GridControl1, 0, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(800, 450)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'GridControl1
        '
        Me.GridControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridControl1.Location = New System.Drawing.Point(3, 3)
        Me.GridControl1.MainView = Me.WinExplorerView1
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.Size = New System.Drawing.Size(394, 444)
        Me.GridControl1.TabIndex = 0
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.WinExplorerView1})
        '
        'WinExplorerView1
        '
        Me.WinExplorerView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.columnName, Me.columnPath, Me.columnCheck, Me.columnGroup, Me.columnImage})
        Me.WinExplorerView1.ColumnSet.CheckBoxColumn = Me.columnCheck
        Me.WinExplorerView1.ColumnSet.DescriptionColumn = Me.columnPath
        Me.WinExplorerView1.ColumnSet.ExtraLargeImageColumn = Me.columnImage
        Me.WinExplorerView1.ColumnSet.GroupColumn = Me.columnGroup
        Me.WinExplorerView1.ColumnSet.LargeImageColumn = Me.columnImage
        Me.WinExplorerView1.ColumnSet.MediumImageColumn = Me.columnImage
        Me.WinExplorerView1.ColumnSet.TextColumn = Me.columnName
        Me.WinExplorerView1.GridControl = Me.GridControl1
        Me.WinExplorerView1.GroupCount = 1
        Me.WinExplorerView1.Name = "WinExplorerView1"
        Me.WinExplorerView1.SortInfo.AddRange(New DevExpress.XtraGrid.Columns.GridColumnSortInfo() {New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.columnGroup, DevExpress.Data.ColumnSortOrder.Ascending)})
        '
        'columnName
        '
        Me.columnName.Caption = "columnName"
        Me.columnName.FieldName = "Name"
        Me.columnName.Name = "columnName"
        Me.columnName.Visible = True
        Me.columnName.VisibleIndex = 0
        '
        'columnPath
        '
        Me.columnPath.Caption = "columnPath"
        Me.columnPath.FieldName = "Path"
        Me.columnPath.Name = "columnPath"
        Me.columnPath.Visible = True
        Me.columnPath.VisibleIndex = 0
        '
        'columnCheck
        '
        Me.columnCheck.Caption = "columnCheck"
        Me.columnCheck.FieldName = "Check"
        Me.columnCheck.Name = "columnCheck"
        Me.columnCheck.Visible = True
        Me.columnCheck.VisibleIndex = 0
        '
        'columnGroup
        '
        Me.columnGroup.Caption = "columnGroup"
        Me.columnGroup.FieldName = "Group"
        Me.columnGroup.Name = "columnGroup"
        Me.columnGroup.Visible = True
        Me.columnGroup.VisibleIndex = 0
        '
        'columnImage
        '
        Me.columnImage.Caption = "columnImage"
        Me.columnImage.FieldName = "Image"
        Me.columnImage.Name = "columnImage"
        Me.columnImage.Visible = True
        Me.columnImage.VisibleIndex = 0
        '
        'DropFiles
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Name = "DropFiles"
        Me.Text = "DropFiles"
        Me.TableLayoutPanel1.ResumeLayout(False)
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.WinExplorerView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents WinExplorerView1 As DevExpress.XtraGrid.Views.WinExplorer.WinExplorerView
    Friend WithEvents columnName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents columnPath As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents columnCheck As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents columnGroup As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents columnImage As DevExpress.XtraGrid.Columns.GridColumn
End Class
