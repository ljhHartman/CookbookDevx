Public Class Main

    Sub New()
        InitializeComponent()

        ' Open form inside the Main form
        Me.IsMdiContainer = True

        'Build top Menubar
        Me.Menu = New MainMenu()

        ' Menu Item : Base From
        Dim item = New MenuItem("Form")
        Me.Menu.MenuItems.Add(item)
        item.MenuItems.Add("Base Form", New EventHandler(AddressOf BaseForm_Click))
        item.MenuItems.Add("Inherit Base Form", New EventHandler(AddressOf InheritBaseForm_Click))
        item.MenuItems.Add("Setup Detail Form", New EventHandler(AddressOf SetupDetailForm_Click))
        item.MenuItems.Add("Simple Form Layout", New EventHandler(AddressOf SimpleFormLayout_Click))
        item.MenuItems.Add("Timer Tick", New EventHandler(AddressOf TimerTick_Click))
        item.MenuItems.Add("Inherit GridControl", New EventHandler(AddressOf InheritGridControl_Click))

        ' Menu Item : Grid Control
        item = New MenuItem("GridControl")
        Me.Menu.MenuItems.Add(item)
        item.MenuItems.Add("Files Viewer", New EventHandler(AddressOf FilesViewer_Click))
        item.MenuItems.Add("Select Rows By Checkbox", New EventHandler(AddressOf SelectRowsByCheckbox_Click))
        item.MenuItems.Add("GridControl Footer Sum", New EventHandler(AddressOf GridControlFooterSum_Click))
        item.MenuItems.Add("Grid 2 Grid", New EventHandler(AddressOf Grid2Grid_Click))
        item.MenuItems.Add("Double Click Row", New EventHandler(AddressOf ClickRow_Click))
        item.MenuItems.Add("Add Row", New EventHandler(AddressOf AddRow_Click))
        item.MenuItems.Add("Cost & Revenue View", New EventHandler(AddressOf CostRevenueView_Click))
        item.MenuItems.Add("Show icon infromt on row", New EventHandler(AddressOf RowIcon_Click))

        ' Menu Item : Tabs
        item = New MenuItem("Tabs")
        Me.Menu.MenuItems.Add(item)
        item.MenuItems.Add("Move data Tab 2 Tab", New EventHandler(AddressOf CloseTabs_Click))
        item.MenuItems.Add("Close Tabs", New EventHandler(AddressOf DataTab2Tab_Click))

        ' Menu Item : Components
        item = New MenuItem("Components")
        Me.Menu.MenuItems.Add(item)
        item.MenuItems.Add("Chartview", New EventHandler(AddressOf Chartview_Click))
        item.MenuItems.Add("ComboBox", New EventHandler(AddressOf ComboBox_Click))
        item.MenuItems.Add("FlyoutPanel", New EventHandler(AddressOf FlyoutPanel_Click))
        item.MenuItems.Add("RibbonForm", New EventHandler(AddressOf RibbonForm_Click))
        item.MenuItems.Add("Erroricon TextBox", New EventHandler(AddressOf ErrorIconTextBox_Click))
        item.MenuItems.Add("Upload Image", New EventHandler(AddressOf UploadImage_Click))
        item.MenuItems.Add("Manualview", New EventHandler(AddressOf Manualview_Click))
        item.MenuItems.Add("Autocomplete", New EventHandler(AddressOf Autocomplete_Click))

        ' Menu Item : MessageBox
        item = New MenuItem("MessageBox")
        Me.Menu.MenuItems.Add(item)
        item.MenuItems.Add("Input Box", New EventHandler(AddressOf InputBox_Click))
        item.MenuItems.Add("Table Box", New EventHandler(AddressOf TableMessageBox_Click))

        ' Menu Item : Remainder
        item = New MenuItem("Remainder")
        Me.Menu.MenuItems.Add(item)
        item.MenuItems.Add("Blank", New EventHandler(AddressOf Blank_Click))

        ' Menu Item : MSSMS
        item = New MenuItem("MSSMS")
        Me.Menu.MenuItems.Add(item)
        item.MenuItems.Add("Sql Command", New EventHandler(AddressOf SqlCommand_Click))
        item.MenuItems.Add("Sql Stored Procedure", New EventHandler(AddressOf SqlStoredProcedure_Click))
        item.MenuItems.Add("Sql Stored View", New EventHandler(AddressOf SqlView_Click))

    End Sub



#Region "mssms"

    Private Sub SqlView_Click(sender As Object, e As EventArgs)
        ' Set Form Constructor
        Dim childForm As New SqlView With {
            .MdiParent = Me,
            .WindowState = FormWindowState.Maximized
        }
        childForm.Show()
    End Sub



    Private Sub SqlStoredProcedure_Click(sender As Object, e As EventArgs)
        ' Set Form Constructor
        Dim childForm As New SqlStoredProcedure With {
            .MdiParent = Me,
            .WindowState = FormWindowState.Maximized
        }
        childForm.Show()
    End Sub



    Private Sub SqlCommand_Click(sender As Object, e As EventArgs)
        ' Set Form Constructor
        Dim childForm As New SqlCommand With {
            .MdiParent = Me,
            .WindowState = FormWindowState.Maximized
        }
        childForm.Show()
    End Sub

#End Region



#Region "Remainder"

    Private Sub Blank_Click(sender As Object, e As EventArgs)
        ' Set Form Constructor
        Dim childForm As New Autocomplete With {
            .MdiParent = Me,
            .WindowState = FormWindowState.Maximized
        }
        childForm.Show()
    End Sub



#End Region



#Region " MessageBox"

    Private Sub InputBox_Click(sender As Object, e As EventArgs)
        ' Set Form Constructor
        Dim childForm As New InputBox With {
            .MdiParent = Me,
            .WindowState = FormWindowState.Maximized
        }
        childForm.Show()
    End Sub

    Private Sub TableMessageBox_Click(sender As Object, e As EventArgs)
        ' Set Form Constructor
        Dim childForm As New TableMessageBox With {
            .MdiParent = Me,
            .WindowState = FormWindowState.Maximized
        }
        childForm.Show()
    End Sub

#End Region



#Region "Components"

    Private Sub Chartview_Click(sender As Object, e As EventArgs)
        ' Set Form Constructor
        Dim childForm As New Chartview With {
            .MdiParent = Me,
            .WindowState = FormWindowState.Maximized
        }
        childForm.Show()
    End Sub

    Private Sub ComboBox_Click(sender As Object, e As EventArgs)
        ' Set Form Constructor
        Dim childForm As New ComboBox With {
            .MdiParent = Me,
            .WindowState = FormWindowState.Maximized
        }
        childForm.Show()
    End Sub

    Private Sub FlyoutPanel_Click(sender As Object, e As EventArgs)
        ' Set Form Constructor
        Dim childForm As New FlyoutPanel With {
            .MdiParent = Me,
            .WindowState = FormWindowState.Maximized
        }
        childForm.Show()
    End Sub

    Private Sub RibbonForm_Click(sender As Object, e As EventArgs)
        ' Set Form Constructor
        Dim childForm As New RibbonControl With {
            .MdiParent = Me,
            .WindowState = FormWindowState.Maximized
        }
        childForm.Show()
    End Sub

    Private Sub ErrorIconTextBox_Click(sender As Object, e As EventArgs)
        ' Set Form Constructor
        Dim childForm As New ErrorIconTextBox With {
            .MdiParent = Me,
            .WindowState = FormWindowState.Maximized
        }
        childForm.Show()
    End Sub

    Private Sub UploadImage_Click(sender As Object, e As EventArgs)
        ' Set Form Constructor
        Dim childForm As New UploadImage With {
            .MdiParent = Me,
            .WindowState = FormWindowState.Maximized
        }
        childForm.Show()
    End Sub

    Private Sub Manualview_Click(sender As Object, e As EventArgs)
        ' Set Form Constructor
        Dim childForm As New Manualview With {
            .MdiParent = Me,
            .WindowState = FormWindowState.Maximized
        }
        childForm.Show()
    End Sub

    Private Sub Autocomplete_Click(sender As Object, e As EventArgs)
        ' Set Form Constructor
        Dim childForm As New Autocomplete With {
            .MdiParent = Me,
            .WindowState = FormWindowState.Maximized
        }
        childForm.Show()
    End Sub


#End Region



#Region "Tabs"

    Private Sub DataTab2Tab_Click(sender As Object, e As EventArgs)
        ' Set Form Constructor
        Dim childForm As New DataTab2Tab With {
            .MdiParent = Me,
            .WindowState = FormWindowState.Maximized
        }
        childForm.Show()
    End Sub

    Private Sub CloseTabs_Click(sender As Object, e As EventArgs)
        ' Set Form Constructor
        Dim childForm As New CloseTabs With {
            .MdiParent = Me,
            .WindowState = FormWindowState.Maximized
        }
        childForm.Show()
    End Sub

#End Region



#Region "Grid Control"

    Private Sub SelectRowsByCheckbox_Click(sender As Object, e As EventArgs)
        ' Set Form Constructor
        Dim childForm As New SelectRowsByCheckbox With {
            .MdiParent = Me,
            .WindowState = FormWindowState.Maximized
        }
        childForm.Show()
    End Sub

    Private Sub GridControlFooterSum_Click(sender As Object, e As EventArgs)
        ' Set Form Constructor
        Dim childForm As New GridControlFooterSum With {
            .MdiParent = Me,
            .WindowState = FormWindowState.Maximized
        }
        childForm.Show()
    End Sub

    Private Sub Grid2Grid_Click(sender As Object, e As EventArgs)
        ' Set Form Constructor
        Dim childForm As New Grid2Grid With {
            .MdiParent = Me,
            .WindowState = FormWindowState.Maximized
        }
        childForm.Show()
    End Sub

    Private Sub FilesViewer_Click(sender As Object, e As EventArgs)
        ' Set Form Constructor
        Dim childForm As New FilesViewer With {
            .MdiParent = Me,
            .WindowState = FormWindowState.Maximized
        }
        childForm.Show()
    End Sub

    Private Sub ClickRow_Click(sender As Object, e As EventArgs)
        ' Set Form Constructor
        Dim childForm As New ClickRow With {
            .MdiParent = Me,
            .WindowState = FormWindowState.Maximized
        }
        childForm.Show()
    End Sub

    Private Sub AddRow_Click(sender As Object, e As EventArgs)
        ' Set Form Constructor
        Dim childForm As New AddRowDataGrid With {
            .MdiParent = Me,
            .WindowState = FormWindowState.Maximized
        }
        childForm.Show()
    End Sub

    Private Sub CostRevenueView_Click(sender As Object, e As EventArgs)
        ' Set Form Constructor
        Dim childForm As New CostRevenueView With {
            .MdiParent = Me,
            .WindowState = FormWindowState.Maximized
        }
        childForm.Show()
    End Sub

    '
    Private Sub RowIcon_Click(sender As Object, e As EventArgs)
        ' Set Form Constructor
        Dim childForm As New RowIcon With {
            .MdiParent = Me,
            .WindowState = FormWindowState.Maximized
        }
        childForm.Show()
    End Sub

#End Region



#Region "Form"

    Private Sub BaseForm_Click(sender As Object, e As EventArgs)
        ' Set Form Constructor
        Dim childForm As New BaseForm With {
            .MdiParent = Me,
            .WindowState = FormWindowState.Maximized
        }
        childForm.Show()
    End Sub

    Private Sub InheritBaseForm_Click(sender As Object, e As EventArgs)
        ' Set Form Constructor
        Dim childForm As New InheritBaseForm With {
            .MdiParent = Me,
            .WindowState = FormWindowState.Maximized
        }
        childForm.Show()
    End Sub

    Private Sub SetupDetailForm_Click(sender As Object, e As EventArgs)
        ' Set Form Constructor
        Dim childForm As New FormDetails With {
            .MdiParent = Me,
            .WindowState = FormWindowState.Maximized
        }
        childForm.Show()
    End Sub

    Private Sub SimpleFormLayout_Click(sender As Object, e As EventArgs)
        ' Set Form Constructor
        Dim childForm As New SimpleFormLayout With {
            .MdiParent = Me,
            .WindowState = FormWindowState.Maximized
        }
        childForm.Show()
    End Sub

    Private Sub TimerTick_Click(sender As Object, e As EventArgs)
        ' Set Form Constructor
        Dim childForm As New TimerTick With {
            .MdiParent = Me,
            .WindowState = FormWindowState.Maximized
        }
        childForm.Show()
    End Sub

    Private Sub InheritGridControl_Click(sender As Object, e As EventArgs)
        ' Set Form Constructor
        Dim childForm As New InheritGridControl With {
            .MdiParent = Me,
            .WindowState = FormWindowState.Maximized
        }
        childForm.Show()
    End Sub



#End Region


End Class
