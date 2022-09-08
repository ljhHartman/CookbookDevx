<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucSelectDepotCode
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
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.lblDepots = New System.Windows.Forms.Label()
        Me.dtbDepots = New sslDataTextBox.txtDataTextBox()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.dtbDepots.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.BackColor = System.Drawing.Color.Transparent
        Me.TableLayoutPanel1.ColumnCount = 5
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.btnAdd, 3, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.lblDepots, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.dtbDepots, 2, 1)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 3
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 66.66666!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(521, 67)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'btnAdd
        '
        Me.btnAdd.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAdd.Location = New System.Drawing.Point(364, 16)
        Me.btnAdd.Margin = New System.Windows.Forms.Padding(0)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(130, 28)
        Me.btnAdd.TabIndex = 2
        Me.btnAdd.Text = "Add"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'lblDepots
        '
        Me.lblDepots.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.lblDepots.AutoSize = True
        Me.lblDepots.Location = New System.Drawing.Point(29, 21)
        Me.lblDepots.Name = "lblDepots"
        Me.lblDepots.Size = New System.Drawing.Size(57, 17)
        Me.lblDepots.TabIndex = 0
        Me.lblDepots.Text = "Depots:"
        '
        'dtbDepots
        '
        Me.dtbDepots.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dtbDepots.Location = New System.Drawing.Point(107, 19)
        Me.dtbDepots.Name = "dtbDepots"
        Me.dtbDepots.Properties.Appearance.BackColor = System.Drawing.Color.LightSteelBlue
        Me.dtbDepots.Properties.Appearance.ForeColor = System.Drawing.Color.Black
        Me.dtbDepots.Properties.Appearance.Options.UseBackColor = True
        Me.dtbDepots.Properties.Appearance.Options.UseForeColor = True
        Me.dtbDepots.ShowToolTips = False
        Me.dtbDepots.Size = New System.Drawing.Size(254, 22)
        Me.dtbDepots.TabIndex = 3
        '
        'ucSelectDepotCode
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Name = "ucSelectDepotCode"
        Me.Size = New System.Drawing.Size(521, 69)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        CType(Me.dtbDepots.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents btnAdd As Button
    Friend WithEvents lblDepots As Label
    Friend WithEvents dtbDepots As sslDataTextBox.txtDataTextBox
End Class
