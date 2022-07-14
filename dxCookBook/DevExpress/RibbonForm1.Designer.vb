<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RibbonForm1
    Inherits DevExpress.XtraBars.Ribbon.RibbonForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(RibbonForm1))
        Me.RibbonControl = New DevExpress.XtraBars.Ribbon.RibbonControl()
        Me.BarButtonItem1 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem2 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarCheckItem1 = New DevExpress.XtraBars.BarCheckItem()
        Me.BarSubItem1 = New DevExpress.XtraBars.BarSubItem()
        Me.BarHeaderItem1 = New DevExpress.XtraBars.BarHeaderItem()
        Me.BarEditItem1 = New DevExpress.XtraBars.BarEditItem()
        Me.RepositoryItemImageEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemImageEdit()
        Me.BarButtonItem3 = New DevExpress.XtraBars.BarButtonItem()
        Me.btnDefault = New DevExpress.XtraBars.BarButtonItem()
        Me.btnOffice2007 = New DevExpress.XtraBars.BarButtonItem()
        Me.btnOffice2010 = New DevExpress.XtraBars.BarButtonItem()
        Me.btnOffice2013 = New DevExpress.XtraBars.BarButtonItem()
        Me.btnMacOffice = New DevExpress.XtraBars.BarButtonItem()
        Me.btnTabletOffice = New DevExpress.XtraBars.BarButtonItem()
        Me.btnOfficeUniversal = New DevExpress.XtraBars.BarButtonItem()
        Me.RibbonPage1 = New DevExpress.XtraBars.Ribbon.RibbonPage()
        Me.RibbonPage2 = New DevExpress.XtraBars.Ribbon.RibbonPage()
        Me.RibbonPageGroup6 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonStatusBar = New DevExpress.XtraBars.Ribbon.RibbonStatusBar()
        Me.UcExample1 = New dxCookBook.ucExample()
        Me.RibbonPageGroup1 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.btnShowStatusBar = New DevExpress.XtraBars.BarButtonItem()
        CType(Me.RibbonControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemImageEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RibbonControl
        '
        Me.RibbonControl.ExpandCollapseItem.Id = 0
        Me.RibbonControl.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.RibbonControl.ExpandCollapseItem, Me.BarButtonItem1, Me.BarButtonItem2, Me.BarCheckItem1, Me.BarSubItem1, Me.BarHeaderItem1, Me.BarEditItem1, Me.BarButtonItem3, Me.btnDefault, Me.btnOffice2007, Me.btnOffice2010, Me.btnOffice2013, Me.btnMacOffice, Me.btnTabletOffice, Me.btnOfficeUniversal, Me.btnShowStatusBar})
        Me.RibbonControl.Location = New System.Drawing.Point(0, 0)
        Me.RibbonControl.MaxItemId = 16
        Me.RibbonControl.Name = "RibbonControl"
        Me.RibbonControl.Pages.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPage() {Me.RibbonPage1, Me.RibbonPage2})
        Me.RibbonControl.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemImageEdit1})
        Me.RibbonControl.Size = New System.Drawing.Size(1014, 143)
        Me.RibbonControl.StatusBar = Me.RibbonStatusBar
        '
        'BarButtonItem1
        '
        Me.BarButtonItem1.Caption = "BarButtonItem1"
        Me.BarButtonItem1.Id = 1
        Me.BarButtonItem1.Name = "BarButtonItem1"
        '
        'BarButtonItem2
        '
        Me.BarButtonItem2.Caption = "BarButtonItem2"
        Me.BarButtonItem2.Id = 2
        Me.BarButtonItem2.Name = "BarButtonItem2"
        '
        'BarCheckItem1
        '
        Me.BarCheckItem1.Caption = "BarCheckItem1"
        Me.BarCheckItem1.Id = 3
        Me.BarCheckItem1.Name = "BarCheckItem1"
        '
        'BarSubItem1
        '
        Me.BarSubItem1.Caption = "BarSubItem1"
        Me.BarSubItem1.Id = 4
        Me.BarSubItem1.Name = "BarSubItem1"
        '
        'BarHeaderItem1
        '
        Me.BarHeaderItem1.Caption = "BarHeaderItem1"
        Me.BarHeaderItem1.Id = 5
        Me.BarHeaderItem1.Name = "BarHeaderItem1"
        '
        'BarEditItem1
        '
        Me.BarEditItem1.Caption = "BarEditItem1"
        Me.BarEditItem1.Edit = Me.RepositoryItemImageEdit1
        Me.BarEditItem1.Id = 6
        Me.BarEditItem1.Name = "BarEditItem1"
        '
        'RepositoryItemImageEdit1
        '
        Me.RepositoryItemImageEdit1.AutoHeight = False
        Me.RepositoryItemImageEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemImageEdit1.Name = "RepositoryItemImageEdit1"
        '
        'BarButtonItem3
        '
        Me.BarButtonItem3.Caption = "BarButtonItem3"
        Me.BarButtonItem3.Id = 7
        Me.BarButtonItem3.ImageOptions.SvgImage = CType(resources.GetObject("BarButtonItem3.ImageOptions.SvgImage"), DevExpress.Utils.Svg.SvgImage)
        Me.BarButtonItem3.Name = "BarButtonItem3"
        '
        'btnDefault
        '
        Me.btnDefault.Caption = "Default"
        Me.btnDefault.Id = 8
        Me.btnDefault.ImageOptions.SvgImage = CType(resources.GetObject("btnDefault.ImageOptions.SvgImage"), DevExpress.Utils.Svg.SvgImage)
        Me.btnDefault.Name = "btnDefault"
        '
        'btnOffice2007
        '
        Me.btnOffice2007.Caption = "Office2007"
        Me.btnOffice2007.Id = 9
        Me.btnOffice2007.ImageOptions.SvgImage = CType(resources.GetObject("btnOffice2007.ImageOptions.SvgImage"), DevExpress.Utils.Svg.SvgImage)
        Me.btnOffice2007.Name = "btnOffice2007"
        '
        'btnOffice2010
        '
        Me.btnOffice2010.Caption = "Office2010"
        Me.btnOffice2010.Id = 10
        Me.btnOffice2010.ImageOptions.SvgImage = CType(resources.GetObject("btnOffice2010.ImageOptions.SvgImage"), DevExpress.Utils.Svg.SvgImage)
        Me.btnOffice2010.Name = "btnOffice2010"
        '
        'btnOffice2013
        '
        Me.btnOffice2013.Caption = "Office2013"
        Me.btnOffice2013.Id = 11
        Me.btnOffice2013.ImageOptions.SvgImage = CType(resources.GetObject("btnOffice2013.ImageOptions.SvgImage"), DevExpress.Utils.Svg.SvgImage)
        Me.btnOffice2013.Name = "btnOffice2013"
        '
        'btnMacOffice
        '
        Me.btnMacOffice.Caption = "MacOffice"
        Me.btnMacOffice.Id = 12
        Me.btnMacOffice.ImageOptions.SvgImage = CType(resources.GetObject("btnMacOffice.ImageOptions.SvgImage"), DevExpress.Utils.Svg.SvgImage)
        Me.btnMacOffice.Name = "btnMacOffice"
        '
        'btnTabletOffice
        '
        Me.btnTabletOffice.Caption = "TabletOffice"
        Me.btnTabletOffice.Id = 13
        Me.btnTabletOffice.ImageOptions.SvgImage = CType(resources.GetObject("btnTabletOffice.ImageOptions.SvgImage"), DevExpress.Utils.Svg.SvgImage)
        Me.btnTabletOffice.Name = "btnTabletOffice"
        '
        'btnOfficeUniversal
        '
        Me.btnOfficeUniversal.Caption = "OfficeUniversal"
        Me.btnOfficeUniversal.Id = 14
        Me.btnOfficeUniversal.ImageOptions.SvgImage = CType(resources.GetObject("btnOfficeUniversal.ImageOptions.SvgImage"), DevExpress.Utils.Svg.SvgImage)
        Me.btnOfficeUniversal.Name = "btnOfficeUniversal"
        '
        'RibbonPage1
        '
        Me.RibbonPage1.Name = "RibbonPage1"
        Me.RibbonPage1.Text = "RibbonPage1"
        '
        'RibbonPage2
        '
        Me.RibbonPage2.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.RibbonPageGroup6, Me.RibbonPageGroup1})
        Me.RibbonPage2.Name = "RibbonPage2"
        Me.RibbonPage2.Text = "Windows Styles"
        '
        'RibbonPageGroup6
        '
        Me.RibbonPageGroup6.ItemLinks.Add(Me.btnOffice2007)
        Me.RibbonPageGroup6.ItemLinks.Add(Me.btnOffice2010)
        Me.RibbonPageGroup6.ItemLinks.Add(Me.btnOffice2013)
        Me.RibbonPageGroup6.ItemLinks.Add(Me.btnMacOffice)
        Me.RibbonPageGroup6.ItemLinks.Add(Me.btnTabletOffice)
        Me.RibbonPageGroup6.ItemLinks.Add(Me.btnOfficeUniversal)
        Me.RibbonPageGroup6.Name = "RibbonPageGroup6"
        Me.RibbonPageGroup6.ShowCaptionButton = False
        Me.RibbonPageGroup6.Text = "Thema's"
        '
        'RibbonStatusBar
        '
        Me.RibbonStatusBar.Location = New System.Drawing.Point(0, 608)
        Me.RibbonStatusBar.Name = "RibbonStatusBar"
        Me.RibbonStatusBar.Ribbon = Me.RibbonControl
        Me.RibbonStatusBar.Size = New System.Drawing.Size(1014, 31)
        '
        'UcExample1
        '
        Me.UcExample1.BackColor = System.Drawing.SystemColors.Desktop
        Me.UcExample1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UcExample1.Location = New System.Drawing.Point(0, 143)
        Me.UcExample1.Name = "UcExample1"
        Me.UcExample1.Size = New System.Drawing.Size(1014, 465)
        Me.UcExample1.TabIndex = 2
        '
        'RibbonPageGroup1
        '
        Me.RibbonPageGroup1.ItemLinks.Add(Me.btnShowStatusBar)
        Me.RibbonPageGroup1.Name = "RibbonPageGroup1"
        Me.RibbonPageGroup1.Text = "StatusBar"
        '
        'btnShowStatusBar
        '
        Me.btnShowStatusBar.Caption = "Show"
        Me.btnShowStatusBar.Id = 15
        Me.btnShowStatusBar.ImageOptions.SvgImage = CType(resources.GetObject("BarButtonItem4.ImageOptions.SvgImage"), DevExpress.Utils.Svg.SvgImage)
        Me.btnShowStatusBar.Name = "btnShowStatusBar"
        '
        'RibbonForm1
        '
        Me.Appearance.BackColor = System.Drawing.Color.LightSalmon
        Me.Appearance.Options.UseBackColor = True
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1014, 639)
        Me.Controls.Add(Me.UcExample1)
        Me.Controls.Add(Me.RibbonStatusBar)
        Me.Controls.Add(Me.RibbonControl)
        Me.Name = "RibbonForm1"
        Me.Ribbon = Me.RibbonControl
        Me.StatusBar = Me.RibbonStatusBar
        Me.Text = "Ribbon CookBook"
        CType(Me.RibbonControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemImageEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents RibbonControl As DevExpress.XtraBars.Ribbon.RibbonControl
    Friend WithEvents RibbonPage1 As DevExpress.XtraBars.Ribbon.RibbonPage
    Friend WithEvents RibbonStatusBar As DevExpress.XtraBars.Ribbon.RibbonStatusBar
    Friend WithEvents UcExample1 As ucExample
    Friend WithEvents BarButtonItem1 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem2 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarCheckItem1 As DevExpress.XtraBars.BarCheckItem
    Friend WithEvents BarSubItem1 As DevExpress.XtraBars.BarSubItem
    Friend WithEvents BarHeaderItem1 As DevExpress.XtraBars.BarHeaderItem
    Friend WithEvents BarEditItem1 As DevExpress.XtraBars.BarEditItem
    Friend WithEvents RepositoryItemImageEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemImageEdit
    Friend WithEvents RibbonPage2 As DevExpress.XtraBars.Ribbon.RibbonPage
    Friend WithEvents RibbonPageGroup6 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents BarButtonItem3 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnDefault As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnOffice2007 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnOffice2010 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnOffice2013 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnMacOffice As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnTabletOffice As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnOfficeUniversal As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnShowStatusBar As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents RibbonPageGroup1 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
End Class
