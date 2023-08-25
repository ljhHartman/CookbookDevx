<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucMoveToFolder
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
        Me.tlpContainer = New System.Windows.Forms.TableLayoutPanel()
        Me.lblCurrent = New System.Windows.Forms.Label()
        Me.tlpHeaderRight = New System.Windows.Forms.TableLayoutPanel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextEdit1 = New DevExpress.XtraEditors.TextEdit()
        Me.tlpContainer.SuspendLayout()
        Me.tlpHeaderRight.SuspendLayout()
        CType(Me.TextEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tlpContainer
        '
        Me.tlpContainer.ColumnCount = 4
        Me.tlpContainer.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.tlpContainer.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tlpContainer.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tlpContainer.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.tlpContainer.Controls.Add(Me.lblCurrent, 1, 2)
        Me.tlpContainer.Controls.Add(Me.tlpHeaderRight, 2, 2)
        Me.tlpContainer.Dock = System.Windows.Forms.DockStyle.Top
        Me.tlpContainer.Location = New System.Drawing.Point(0, 0)
        Me.tlpContainer.Name = "tlpContainer"
        Me.tlpContainer.RowCount = 5
        Me.tlpContainer.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.tlpContainer.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60.0!))
        Me.tlpContainer.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.tlpContainer.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpContainer.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.tlpContainer.Size = New System.Drawing.Size(522, 591)
        Me.tlpContainer.TabIndex = 0
        '
        'lblCurrent
        '
        Me.lblCurrent.AutoSize = True
        Me.lblCurrent.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblCurrent.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCurrent.Location = New System.Drawing.Point(23, 80)
        Me.lblCurrent.Name = "lblCurrent"
        Me.lblCurrent.Size = New System.Drawing.Size(235, 30)
        Me.lblCurrent.TabIndex = 0
        Me.lblCurrent.Text = "Dossier: 1234567"
        '
        'tlpHeaderRight
        '
        Me.tlpHeaderRight.ColumnCount = 2
        Me.tlpHeaderRight.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 29.78723!))
        Me.tlpHeaderRight.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70.21277!))
        Me.tlpHeaderRight.Controls.Add(Me.Label1, 0, 0)
        Me.tlpHeaderRight.Controls.Add(Me.TextEdit1, 1, 0)
        Me.tlpHeaderRight.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlpHeaderRight.Location = New System.Drawing.Point(264, 83)
        Me.tlpHeaderRight.Name = "tlpHeaderRight"
        Me.tlpHeaderRight.RowCount = 1
        Me.tlpHeaderRight.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tlpHeaderRight.Size = New System.Drawing.Size(235, 24)
        Me.tlpHeaderRight.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(3, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(60, 24)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Dossier:"
        '
        'TextEdit1
        '
        Me.TextEdit1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TextEdit1.Location = New System.Drawing.Point(72, 3)
        Me.TextEdit1.Name = "TextEdit1"
        Me.TextEdit1.Size = New System.Drawing.Size(160, 20)
        Me.TextEdit1.TabIndex = 2
        '
        'ucMoveToFolder
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.tlpContainer)
        Me.Name = "ucMoveToFolder"
        Me.Size = New System.Drawing.Size(522, 607)
        Me.tlpContainer.ResumeLayout(False)
        Me.tlpContainer.PerformLayout()
        Me.tlpHeaderRight.ResumeLayout(False)
        Me.tlpHeaderRight.PerformLayout()
        CType(Me.TextEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents tlpContainer As TableLayoutPanel
    Friend WithEvents lblCurrent As Label
    Friend WithEvents tlpHeaderRight As TableLayoutPanel
    Friend WithEvents Label1 As Label
    Friend WithEvents TextEdit1 As DevExpress.XtraEditors.TextEdit
End Class
