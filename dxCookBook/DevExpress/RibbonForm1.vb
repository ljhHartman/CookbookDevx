Imports DevExpress.Skins
Imports DevExpress.XtraBars
Imports DevExpress.XtraBars.Ribbon



Public Class RibbonForm1


    Dim statusBarSwitch As Boolean = False



    Private Sub RibbonForm1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

#Region "Init Settings"

        Me.Text = "Window Title"

        ' Int Style Template
        RibbonControl.RibbonStyle = RibbonControlStyle.Office2013
        ' Set top Bar to Minimized
        RibbonControl.Minimized = True



        ' Hide Quick Access Toolbar
        RibbonControl.ToolbarLocation = RibbonQuickAccessToolbarLocation.Hidden



        ' Hide StatusBar.ShowSizeGrip
        RibbonStatusBar.ShowSizeGrip = False
        ' Hide StatusBar
        RibbonStatusBar.Visible = False
        'Status Bar Color
        Dim element As SkinElement = SkinManager.GetSkinElement(SkinProductId.Ribbon, DevExpress.LookAndFeel.UserLookAndFeel.Default, "StatusBarFormBackground")
        element.Color.SolidImageCenterColor = Color.Green

#End Region


#Region "Events"

        ' RibbonStyle Events
        AddHandler btnOffice2007.ItemClick, AddressOf StyleOffice2007
        AddHandler btnOffice2010.ItemClick, AddressOf StyleOffice2010
        AddHandler btnOffice2013.ItemClick, AddressOf StyleOffice2013
        AddHandler btnMacOffice.ItemClick, AddressOf StyleMacOffice
        AddHandler btnTabletOffice.ItemClick, AddressOf StyleTabletOffice
        AddHandler btnOfficeUniversal.ItemClick, AddressOf StyleOfficeUniversal

        AddHandler btnShowStatusBar.ItemClick, AddressOf ShowStatusBar

#End Region


    End Sub

    Private Sub ShowStatusBar()
        If statusBarSwitch = False Then
            statusBarSwitch = True
        Else
            statusBarSwitch = False
        End If

        ' Hide StatusBar.ShowSizeGrip
        RibbonStatusBar.ShowSizeGrip = statusBarSwitch
        ' Hide StatusBar
        RibbonStatusBar.Visible = statusBarSwitch
    End Sub


#Region "RibbonStyle"

    Private Sub StyleDefault()
        RibbonControl.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.Default
    End Sub

    Private Sub StyleOffice2007()
        RibbonControl.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.Office2007
    End Sub

    Private Sub StyleOffice2010()
        RibbonControl.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.Office2010
    End Sub

    Private Sub StyleOffice2013()
        RibbonControl.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.Office2013
    End Sub

    Private Sub StyleMacOffice()
        RibbonControl.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.MacOffice
    End Sub

    Private Sub StyleTabletOffice()
        RibbonControl.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.TabletOffice
    End Sub

    Private Sub StyleOfficeUniversal()
        RibbonControl.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.OfficeUniversal
    End Sub

#End Region




End Class