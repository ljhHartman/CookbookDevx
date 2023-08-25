<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class uploadImage
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
        Me.tlpPicture = New System.Windows.Forms.TableLayoutPanel()
        Me.lbPicture = New System.Windows.Forms.LinkLabel()
        Me.pbPicture = New System.Windows.Forms.PictureBox()
        Me.tlpPicture.SuspendLayout()
        CType(Me.pbPicture, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tlpPicture
        '
        Me.tlpPicture.BackColor = System.Drawing.Color.Transparent
        Me.tlpPicture.ColumnCount = 2
        Me.tlpPicture.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 300.0!))
        Me.tlpPicture.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpPicture.Controls.Add(Me.lbPicture, 0, 1)
        Me.tlpPicture.Controls.Add(Me.pbPicture, 0, 0)
        Me.tlpPicture.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlpPicture.Location = New System.Drawing.Point(0, 0)
        Me.tlpPicture.Margin = New System.Windows.Forms.Padding(9)
        Me.tlpPicture.Name = "tlpPicture"
        Me.tlpPicture.RowCount = 3
        Me.tlpPicture.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 200.0!))
        Me.tlpPicture.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 15.0!))
        Me.tlpPicture.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpPicture.Size = New System.Drawing.Size(800, 450)
        Me.tlpPicture.TabIndex = 1
        '
        'lbPicture
        '
        Me.lbPicture.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.lbPicture.AutoSize = True
        Me.lbPicture.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lbPicture.Location = New System.Drawing.Point(3, 201)
        Me.lbPicture.Name = "lbPicture"
        Me.lbPicture.Size = New System.Drawing.Size(105, 13)
        Me.lbPicture.TabIndex = 0
        Me.lbPicture.TabStop = True
        Me.lbPicture.Text = "Select Profile Picture"
        '
        'pbPicture
        '
        Me.pbPicture.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.pbPicture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.pbPicture.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pbPicture.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.pbPicture.Location = New System.Drawing.Point(0, 0)
        Me.pbPicture.Margin = New System.Windows.Forms.Padding(0)
        Me.pbPicture.Name = "pbPicture"
        Me.pbPicture.Size = New System.Drawing.Size(300, 200)
        Me.pbPicture.TabIndex = 3
        Me.pbPicture.TabStop = False
        '
        'uploadImage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.tlpPicture)
        Me.Name = "uploadImage"
        Me.Text = "uploadImage"
        Me.tlpPicture.ResumeLayout(False)
        Me.tlpPicture.PerformLayout()
        CType(Me.pbPicture, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents tlpPicture As TableLayoutPanel
    Friend WithEvents lbPicture As LinkLabel
    Friend WithEvents pbPicture As PictureBox
End Class
