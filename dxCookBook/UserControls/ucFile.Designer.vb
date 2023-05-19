<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucFile
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ucFile))
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.tlpIcons = New System.Windows.Forms.TableLayoutPanel()
        Me.tbSmall = New DevExpress.XtraBars.Navigation.TileBar()
        Me.tbMedium = New DevExpress.XtraBars.Navigation.TileBar()
        Me.tbLarge = New DevExpress.XtraBars.Navigation.TileBar()
        Me.tbExtraLarge = New DevExpress.XtraBars.Navigation.TileBar()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.gcAttachments = New DevExpress.XtraGrid.GridControl()
        Me.WinExplorerView1 = New DevExpress.XtraGrid.Views.WinExplorer.WinExplorerView()
        Me.columnName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.columnPath = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.columnCheck = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.columnGroup = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.columnImage = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.tlpIcons.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        CType(Me.gcAttachments, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.WinExplorerView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.tlpIcons, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanel2, 0, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(786, 438)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'tlpIcons
        '
        Me.tlpIcons.ColumnCount = 1
        Me.tlpIcons.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpIcons.Controls.Add(Me.tbSmall, 0, 3)
        Me.tlpIcons.Controls.Add(Me.tbMedium, 0, 2)
        Me.tlpIcons.Controls.Add(Me.tbLarge, 0, 1)
        Me.tlpIcons.Controls.Add(Me.tbExtraLarge, 0, 0)
        Me.tlpIcons.Dock = System.Windows.Forms.DockStyle.Top
        Me.tlpIcons.Location = New System.Drawing.Point(739, 3)
        Me.tlpIcons.Name = "tlpIcons"
        Me.tlpIcons.RowCount = 7
        Me.tlpIcons.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.tlpIcons.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.tlpIcons.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.tlpIcons.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.tlpIcons.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.tlpIcons.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.tlpIcons.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpIcons.Size = New System.Drawing.Size(44, 251)
        Me.tlpIcons.TabIndex = 24
        '
        'tbSmall
        '
        Me.tbSmall.AllowDrag = False
        Me.tbSmall.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.tbSmall.BackgroundImage = CType(resources.GetObject("tbSmall.BackgroundImage"), System.Drawing.Image)
        Me.tbSmall.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.tbSmall.Cursor = System.Windows.Forms.Cursors.Default
        Me.tbSmall.DropDownOptions.BeakColor = System.Drawing.Color.Empty
        Me.tbSmall.Location = New System.Drawing.Point(0, 90)
        Me.tbSmall.Margin = New System.Windows.Forms.Padding(0)
        Me.tbSmall.MaxId = 1
        Me.tbSmall.Name = "tbSmall"
        Me.tbSmall.ScrollMode = DevExpress.XtraEditors.TileControlScrollMode.ScrollButtons
        Me.tbSmall.Size = New System.Drawing.Size(44, 30)
        Me.tbSmall.TabIndex = 9
        Me.tbSmall.Text = "TileBar6"
        '
        'tbMedium
        '
        Me.tbMedium.AllowDrag = False
        Me.tbMedium.BackgroundImage = CType(resources.GetObject("tbMedium.BackgroundImage"), System.Drawing.Image)
        Me.tbMedium.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.tbMedium.Cursor = System.Windows.Forms.Cursors.Default
        Me.tbMedium.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tbMedium.DropDownOptions.BeakColor = System.Drawing.Color.Empty
        Me.tbMedium.Location = New System.Drawing.Point(0, 60)
        Me.tbMedium.Margin = New System.Windows.Forms.Padding(0)
        Me.tbMedium.MaxId = 1
        Me.tbMedium.Name = "tbMedium"
        Me.tbMedium.ScrollMode = DevExpress.XtraEditors.TileControlScrollMode.ScrollButtons
        Me.tbMedium.Size = New System.Drawing.Size(44, 30)
        Me.tbMedium.TabIndex = 8
        Me.tbMedium.Text = "TileBar5"
        '
        'tbLarge
        '
        Me.tbLarge.AllowDrag = False
        Me.tbLarge.BackgroundImage = CType(resources.GetObject("tbLarge.BackgroundImage"), System.Drawing.Image)
        Me.tbLarge.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.tbLarge.Cursor = System.Windows.Forms.Cursors.Default
        Me.tbLarge.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tbLarge.DropDownOptions.BeakColor = System.Drawing.Color.Empty
        Me.tbLarge.Location = New System.Drawing.Point(0, 30)
        Me.tbLarge.Margin = New System.Windows.Forms.Padding(0)
        Me.tbLarge.MaxId = 1
        Me.tbLarge.Name = "tbLarge"
        Me.tbLarge.ScrollMode = DevExpress.XtraEditors.TileControlScrollMode.ScrollButtons
        Me.tbLarge.Size = New System.Drawing.Size(44, 30)
        Me.tbLarge.TabIndex = 7
        Me.tbLarge.Text = "TileBar4"
        '
        'tbExtraLarge
        '
        Me.tbExtraLarge.AllowDrag = False
        Me.tbExtraLarge.BackgroundImage = CType(resources.GetObject("tbExtraLarge.BackgroundImage"), System.Drawing.Image)
        Me.tbExtraLarge.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.tbExtraLarge.Cursor = System.Windows.Forms.Cursors.Default
        Me.tbExtraLarge.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tbExtraLarge.DropDownOptions.BeakColor = System.Drawing.Color.Empty
        Me.tbExtraLarge.Location = New System.Drawing.Point(0, 0)
        Me.tbExtraLarge.Margin = New System.Windows.Forms.Padding(0)
        Me.tbExtraLarge.MaxId = 1
        Me.tbExtraLarge.Name = "tbExtraLarge"
        Me.tbExtraLarge.ScrollMode = DevExpress.XtraEditors.TileControlScrollMode.ScrollButtons
        Me.tbExtraLarge.Size = New System.Drawing.Size(44, 30)
        Me.tbExtraLarge.TabIndex = 5
        Me.tbExtraLarge.Text = "TileBar1"
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 1
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.gcAttachments, 0, 0)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(3, 3)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 1
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(730, 432)
        Me.TableLayoutPanel2.TabIndex = 25
        '
        'gcAttachments
        '
        Me.gcAttachments.Cursor = System.Windows.Forms.Cursors.Default
        Me.gcAttachments.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gcAttachments.Location = New System.Drawing.Point(3, 3)
        Me.gcAttachments.MainView = Me.WinExplorerView1
        Me.gcAttachments.Name = "gcAttachments"
        Me.gcAttachments.Size = New System.Drawing.Size(724, 426)
        Me.gcAttachments.TabIndex = 24
        Me.gcAttachments.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.WinExplorerView1})
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
        Me.WinExplorerView1.GridControl = Me.gcAttachments
        Me.WinExplorerView1.GroupCount = 1
        Me.WinExplorerView1.Name = "WinExplorerView1"
        Me.WinExplorerView1.OptionsFind.AlwaysVisible = True
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
        'ucFile
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Name = "ucFile"
        Me.Size = New System.Drawing.Size(786, 438)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.tlpIcons.ResumeLayout(False)
        Me.TableLayoutPanel2.ResumeLayout(False)
        CType(Me.gcAttachments, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.WinExplorerView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents tlpIcons As TableLayoutPanel
    Friend WithEvents tbSmall As DevExpress.XtraBars.Navigation.TileBar
    Friend WithEvents tbMedium As DevExpress.XtraBars.Navigation.TileBar
    Friend WithEvents tbLarge As DevExpress.XtraBars.Navigation.TileBar
    Friend WithEvents tbExtraLarge As DevExpress.XtraBars.Navigation.TileBar
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents gcAttachments As DevExpress.XtraGrid.GridControl
    Friend WithEvents WinExplorerView1 As DevExpress.XtraGrid.Views.WinExplorer.WinExplorerView
    Friend WithEvents columnName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents columnPath As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents columnCheck As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents columnGroup As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents columnImage As DevExpress.XtraGrid.Columns.GridColumn
End Class
