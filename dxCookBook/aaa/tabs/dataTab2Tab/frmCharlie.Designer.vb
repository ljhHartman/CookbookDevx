<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCharlie
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
        Me.tlpAlpha = New System.Windows.Forms.TableLayoutPanel()
        Me.teX = New DevExpress.XtraEditors.TextEdit()
        Me.teY = New DevExpress.XtraEditors.TextEdit()
        Me.teZ = New DevExpress.XtraEditors.TextEdit()
        Me.lblX = New System.Windows.Forms.Label()
        Me.lblY = New System.Windows.Forms.Label()
        Me.lblZ = New System.Windows.Forms.Label()
        Me.btnSend = New System.Windows.Forms.Button()
        Me.tlpAlpha.SuspendLayout()
        CType(Me.teX.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.teY.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.teZ.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tlpAlpha
        '
        Me.tlpAlpha.ColumnCount = 2
        Me.tlpAlpha.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tlpAlpha.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tlpAlpha.Controls.Add(Me.teX, 1, 0)
        Me.tlpAlpha.Controls.Add(Me.teY, 1, 1)
        Me.tlpAlpha.Controls.Add(Me.teZ, 1, 2)
        Me.tlpAlpha.Controls.Add(Me.lblX, 0, 0)
        Me.tlpAlpha.Controls.Add(Me.lblY, 0, 1)
        Me.tlpAlpha.Controls.Add(Me.lblZ, 0, 2)
        Me.tlpAlpha.Controls.Add(Me.btnSend, 1, 3)
        Me.tlpAlpha.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlpAlpha.Location = New System.Drawing.Point(0, 0)
        Me.tlpAlpha.Name = "tlpAlpha"
        Me.tlpAlpha.RowCount = 4
        Me.tlpAlpha.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.tlpAlpha.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33334!))
        Me.tlpAlpha.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33334!))
        Me.tlpAlpha.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50.0!))
        Me.tlpAlpha.Size = New System.Drawing.Size(800, 450)
        Me.tlpAlpha.TabIndex = 2
        '
        'teX
        '
        Me.teX.Dock = System.Windows.Forms.DockStyle.Top
        Me.teX.Location = New System.Drawing.Point(403, 3)
        Me.teX.Name = "teX"
        Me.teX.Size = New System.Drawing.Size(394, 20)
        Me.teX.TabIndex = 0
        '
        'teY
        '
        Me.teY.Dock = System.Windows.Forms.DockStyle.Top
        Me.teY.Location = New System.Drawing.Point(403, 136)
        Me.teY.Name = "teY"
        Me.teY.Size = New System.Drawing.Size(394, 20)
        Me.teY.TabIndex = 1
        '
        'teZ
        '
        Me.teZ.Dock = System.Windows.Forms.DockStyle.Top
        Me.teZ.Location = New System.Drawing.Point(403, 269)
        Me.teZ.Name = "teZ"
        Me.teZ.Size = New System.Drawing.Size(394, 20)
        Me.teZ.TabIndex = 2
        '
        'lblX
        '
        Me.lblX.AutoSize = True
        Me.lblX.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblX.Location = New System.Drawing.Point(3, 0)
        Me.lblX.Name = "lblX"
        Me.lblX.Size = New System.Drawing.Size(394, 13)
        Me.lblX.TabIndex = 3
        Me.lblX.Text = "X"
        '
        'lblY
        '
        Me.lblY.AutoSize = True
        Me.lblY.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblY.Location = New System.Drawing.Point(3, 133)
        Me.lblY.Name = "lblY"
        Me.lblY.Size = New System.Drawing.Size(394, 13)
        Me.lblY.TabIndex = 4
        Me.lblY.Text = "Y"
        '
        'lblZ
        '
        Me.lblZ.AutoSize = True
        Me.lblZ.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblZ.Location = New System.Drawing.Point(3, 266)
        Me.lblZ.Name = "lblZ"
        Me.lblZ.Size = New System.Drawing.Size(394, 13)
        Me.lblZ.TabIndex = 5
        Me.lblZ.Text = "Z"
        '
        'btnSend
        '
        Me.btnSend.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnSend.Location = New System.Drawing.Point(403, 402)
        Me.btnSend.Name = "btnSend"
        Me.btnSend.Size = New System.Drawing.Size(394, 45)
        Me.btnSend.TabIndex = 6
        Me.btnSend.Text = "Send to Beta Tab"
        Me.btnSend.UseVisualStyleBackColor = True
        '
        'frmCharlie
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.tlpAlpha)
        Me.Name = "frmCharlie"
        Me.Text = "frmCharlie"
        Me.tlpAlpha.ResumeLayout(False)
        Me.tlpAlpha.PerformLayout()
        CType(Me.teX.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.teY.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.teZ.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents tlpAlpha As TableLayoutPanel
    Friend WithEvents teX As DevExpress.XtraEditors.TextEdit
    Friend WithEvents teY As DevExpress.XtraEditors.TextEdit
    Friend WithEvents teZ As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lblX As Label
    Friend WithEvents lblY As Label
    Friend WithEvents lblZ As Label
    Friend WithEvents btnSend As Button
End Class
