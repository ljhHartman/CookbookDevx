<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Main
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Main))
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripDropDownButton1 = New System.Windows.Forms.ToolStripDropDownButton()
        Me.XtraDialogToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GridControlToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RibbonFromToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.XtraDialogArgsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.XtraDialogReturnTableToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GridControlFooterToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewDataSetGridToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStrip2 = New System.Windows.Forms.ToolStrip()
        Me.CloseTabControleActionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripDropDownButton1})
        resources.ApplyResources(Me.ToolStrip1, "ToolStrip1")
        Me.ToolStrip1.Name = "ToolStrip1"
        '
        'ToolStripDropDownButton1
        '
        Me.ToolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripDropDownButton1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.XtraDialogToolStripMenuItem, Me.GridControlToolStripMenuItem, Me.RibbonFromToolStripMenuItem, Me.XtraDialogArgsToolStripMenuItem, Me.XtraDialogReturnTableToolStripMenuItem, Me.GridControlFooterToolStripMenuItem, Me.ViewDataSetGridToolStripMenuItem, Me.CloseTabControleActionToolStripMenuItem})
        resources.ApplyResources(Me.ToolStripDropDownButton1, "ToolStripDropDownButton1")
        Me.ToolStripDropDownButton1.Name = "ToolStripDropDownButton1"
        '
        'XtraDialogToolStripMenuItem
        '
        Me.XtraDialogToolStripMenuItem.Name = "XtraDialogToolStripMenuItem"
        resources.ApplyResources(Me.XtraDialogToolStripMenuItem, "XtraDialogToolStripMenuItem")
        '
        'GridControlToolStripMenuItem
        '
        Me.GridControlToolStripMenuItem.Name = "GridControlToolStripMenuItem"
        resources.ApplyResources(Me.GridControlToolStripMenuItem, "GridControlToolStripMenuItem")
        '
        'RibbonFromToolStripMenuItem
        '
        Me.RibbonFromToolStripMenuItem.Name = "RibbonFromToolStripMenuItem"
        resources.ApplyResources(Me.RibbonFromToolStripMenuItem, "RibbonFromToolStripMenuItem")
        '
        'XtraDialogArgsToolStripMenuItem
        '
        Me.XtraDialogArgsToolStripMenuItem.Name = "XtraDialogArgsToolStripMenuItem"
        resources.ApplyResources(Me.XtraDialogArgsToolStripMenuItem, "XtraDialogArgsToolStripMenuItem")
        '
        'XtraDialogReturnTableToolStripMenuItem
        '
        Me.XtraDialogReturnTableToolStripMenuItem.Name = "XtraDialogReturnTableToolStripMenuItem"
        resources.ApplyResources(Me.XtraDialogReturnTableToolStripMenuItem, "XtraDialogReturnTableToolStripMenuItem")
        '
        'GridControlFooterToolStripMenuItem
        '
        Me.GridControlFooterToolStripMenuItem.Name = "GridControlFooterToolStripMenuItem"
        resources.ApplyResources(Me.GridControlFooterToolStripMenuItem, "GridControlFooterToolStripMenuItem")
        '
        'ViewDataSetGridToolStripMenuItem
        '
        Me.ViewDataSetGridToolStripMenuItem.Name = "ViewDataSetGridToolStripMenuItem"
        resources.ApplyResources(Me.ViewDataSetGridToolStripMenuItem, "ViewDataSetGridToolStripMenuItem")
        '
        'ToolStrip2
        '
        resources.ApplyResources(Me.ToolStrip2, "ToolStrip2")
        Me.ToolStrip2.Name = "ToolStrip2"
        '
        'CloseTabControleActionToolStripMenuItem
        '
        Me.CloseTabControleActionToolStripMenuItem.Name = "CloseTabControleActionToolStripMenuItem"
        resources.ApplyResources(Me.CloseTabControleActionToolStripMenuItem, "CloseTabControleActionToolStripMenuItem")
        '
        'Main
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.ToolStrip2)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Name = "Main"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents ToolStripDropDownButton1 As ToolStripDropDownButton
    Friend WithEvents XtraDialogToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStrip2 As ToolStrip
    Friend WithEvents GridControlToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RibbonFromToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents XtraDialogArgsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents XtraDialogReturnTableToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GridControlFooterToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ViewDataSetGridToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CloseTabControleActionToolStripMenuItem As ToolStripMenuItem
End Class
