<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSimpleLayout
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSimpleLayout))
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.rbcOptions = New DevExpress.XtraBars.Ribbon.RibbonControl()
        Me.bbSave = New DevExpress.XtraBars.BarButtonItem()
        Me.rbFile = New DevExpress.XtraBars.Ribbon.RibbonPage()
        Me.rpgSave = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.bbSaveNew = New DevExpress.XtraBars.BarButtonItem()
        Me.bbSaveClose = New DevExpress.XtraBars.BarButtonItem()
        Me.rpgManual = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.bbManual = New DevExpress.XtraBars.BarButtonItem()
        Me.rpgChangeCode = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.bbChangeRelation = New DevExpress.XtraBars.BarButtonItem()
        Me.rpgEnabled = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.tsEnabled = New DevExpress.XtraBars.BarToggleSwitchItem()
        Me.bbOpen = New DevExpress.XtraBars.BarButtonItem()
        Me.bbCopy = New DevExpress.XtraBars.BarButtonItem()
        Me.bbPaste = New DevExpress.XtraBars.BarButtonItem()
        Me.bbDelete = New DevExpress.XtraBars.BarButtonItem()
        Me.bbEmailAttachment = New DevExpress.XtraBars.BarButtonItem()
        Me.bbProperties = New DevExpress.XtraBars.BarButtonItem()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.rbcOptions, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.AutoScroll = True
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.rbcOptions, 0, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 2
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 23.52941!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 76.47059!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(1140, 510)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'rbcOptions
        '
        Me.rbcOptions.ExpandCollapseItem.Id = 0
        Me.rbcOptions.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.rbcOptions.ExpandCollapseItem, Me.bbSave, Me.bbSaveClose, Me.bbSaveNew, Me.bbManual, Me.tsEnabled, Me.bbChangeRelation, Me.bbOpen, Me.bbCopy, Me.bbPaste, Me.bbDelete, Me.bbEmailAttachment, Me.bbProperties})
        Me.rbcOptions.Location = New System.Drawing.Point(3, 3)
        Me.rbcOptions.MaxItemId = 10
        Me.rbcOptions.Name = "rbcOptions"
        Me.rbcOptions.Pages.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPage() {Me.rbFile})
        Me.rbcOptions.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.Office2007
        Me.rbcOptions.Size = New System.Drawing.Size(1134, 113)
        Me.rbcOptions.ToolbarLocation = DevExpress.XtraBars.Ribbon.RibbonQuickAccessToolbarLocation.Hidden
        '
        'bbSave
        '
        Me.bbSave.Caption = "Save"
        Me.bbSave.Id = 1
        Me.bbSave.ImageOptions.Image = CType(resources.GetObject("bbSave.ImageOptions.Image"), System.Drawing.Image)
        Me.bbSave.ImageOptions.LargeImage = CType(resources.GetObject("bbSave.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.bbSave.Name = "bbSave"
        '
        'rbFile
        '
        Me.rbFile.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.rpgSave, Me.rpgManual, Me.rpgChangeCode, Me.rpgEnabled})
        Me.rbFile.Name = "rbFile"
        Me.rbFile.Text = "File"
        '
        'rpgSave
        '
        Me.rpgSave.ItemLinks.Add(Me.bbSave)
        Me.rpgSave.ItemLinks.Add(Me.bbSaveNew)
        Me.rpgSave.ItemLinks.Add(Me.bbSaveClose)
        Me.rpgSave.Name = "rpgSave"
        Me.rpgSave.Text = "Save"
        '
        'bbSaveNew
        '
        Me.bbSaveNew.Caption = "Save and New"
        Me.bbSaveNew.Id = 3
        Me.bbSaveNew.ImageOptions.Image = CType(resources.GetObject("bbSaveNew.ImageOptions.Image"), System.Drawing.Image)
        Me.bbSaveNew.ImageOptions.LargeImage = CType(resources.GetObject("bbSaveNew.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.bbSaveNew.Name = "bbSaveNew"
        '
        'bbSaveClose
        '
        Me.bbSaveClose.Caption = "Save and Close"
        Me.bbSaveClose.Id = 2
        Me.bbSaveClose.ImageOptions.Image = CType(resources.GetObject("bbSaveClose.ImageOptions.Image"), System.Drawing.Image)
        Me.bbSaveClose.ImageOptions.LargeImage = CType(resources.GetObject("bbSaveClose.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.bbSaveClose.Name = "bbSaveClose"
        '
        'rpgManual
        '
        Me.rpgManual.AllowTextClipping = False
        Me.rpgManual.ItemLinks.Add(Me.bbManual)
        Me.rpgManual.Name = "rpgManual"
        Me.rpgManual.Text = "Manual"
        '
        'bbManual
        '
        Me.bbManual.Caption = "Manual"
        Me.bbManual.Id = 4
        Me.bbManual.ImageOptions.Image = CType(resources.GetObject("bbManual.ImageOptions.Image"), System.Drawing.Image)
        Me.bbManual.ImageOptions.LargeImage = CType(resources.GetObject("bbManual.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.bbManual.Name = "bbManual"
        '
        'rpgChangeCode
        '
        Me.rpgChangeCode.AllowTextClipping = False
        Me.rpgChangeCode.ItemLinks.Add(Me.bbChangeRelation)
        Me.rpgChangeCode.Name = "rpgChangeCode"
        Me.rpgChangeCode.Text = "Relation code"
        '
        'bbChangeRelation
        '
        Me.bbChangeRelation.Caption = "Change relationcode"
        Me.bbChangeRelation.Id = 3
        Me.bbChangeRelation.ImageOptions.Image = CType(resources.GetObject("bbChangeRelation.ImageOptions.Image"), System.Drawing.Image)
        Me.bbChangeRelation.ImageOptions.LargeImage = CType(resources.GetObject("bbChangeRelation.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.bbChangeRelation.Name = "bbChangeRelation"
        '
        'rpgEnabled
        '
        Me.rpgEnabled.AllowTextClipping = False
        Me.rpgEnabled.ItemLinks.Add(Me.tsEnabled)
        Me.rpgEnabled.Name = "rpgEnabled"
        Me.rpgEnabled.Text = "Enabled"
        '
        'tsEnabled
        '
        Me.tsEnabled.Caption = "Enabled"
        Me.tsEnabled.Id = 2
        Me.tsEnabled.Name = "tsEnabled"
        '
        'bbOpen
        '
        Me.bbOpen.Caption = "Open"
        Me.bbOpen.Id = 4
        Me.bbOpen.ItemAppearance.Normal.FontStyleDelta = System.Drawing.FontStyle.Bold
        Me.bbOpen.ItemAppearance.Normal.Options.UseFont = True
        Me.bbOpen.Name = "bbOpen"
        '
        'bbCopy
        '
        Me.bbCopy.Caption = "Copy"
        Me.bbCopy.Id = 5
        Me.bbCopy.Name = "bbCopy"
        '
        'bbPaste
        '
        Me.bbPaste.Caption = "Paste"
        Me.bbPaste.Id = 6
        Me.bbPaste.Name = "bbPaste"
        '
        'bbDelete
        '
        Me.bbDelete.Caption = "Delete"
        Me.bbDelete.Id = 7
        Me.bbDelete.Name = "bbDelete"
        '
        'bbEmailAttachment
        '
        Me.bbEmailAttachment.Caption = "E-mail"
        Me.bbEmailAttachment.Id = 8
        Me.bbEmailAttachment.Name = "bbEmailAttachment"
        '
        'bbProperties
        '
        Me.bbProperties.Caption = "Properties"
        Me.bbProperties.Id = 9
        Me.bbProperties.Name = "bbProperties"
        '
        'frmSimpleLayout
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1140, 510)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Name = "frmSimpleLayout"
        Me.Text = "frmSimpleLayout"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        CType(Me.rbcOptions, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Private WithEvents rbcOptions As DevExpress.XtraBars.Ribbon.RibbonControl
    Private WithEvents bbSave As DevExpress.XtraBars.BarButtonItem
    Private WithEvents bbSaveClose As DevExpress.XtraBars.BarButtonItem
    Private WithEvents bbSaveNew As DevExpress.XtraBars.BarButtonItem
    Private WithEvents bbManual As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents tsEnabled As DevExpress.XtraBars.BarToggleSwitchItem
    Friend WithEvents bbChangeRelation As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents bbOpen As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents bbCopy As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents bbPaste As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents bbDelete As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents bbEmailAttachment As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents bbProperties As DevExpress.XtraBars.BarButtonItem
    Private WithEvents rbFile As DevExpress.XtraBars.Ribbon.RibbonPage
    Private WithEvents rpgSave As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Private WithEvents rpgManual As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents rpgChangeCode As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents rpgEnabled As DevExpress.XtraBars.Ribbon.RibbonPageGroup
End Class
