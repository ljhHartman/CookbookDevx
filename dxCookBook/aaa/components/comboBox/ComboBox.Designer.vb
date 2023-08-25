<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ComboBox
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.lueDocumentType = New DevExpress.XtraEditors.LookUpEdit()
        CType(Me.lueDocumentType.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lueDocumentType
        '
        Me.lueDocumentType.Location = New System.Drawing.Point(68, 69)
        Me.lueDocumentType.Name = "lueDocumentType"
        Me.lueDocumentType.Properties.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.lueDocumentType.Properties.Appearance.Options.UseBackColor = True
        Me.lueDocumentType.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lueDocumentType.Size = New System.Drawing.Size(261, 20)
        Me.lueDocumentType.TabIndex = 0
        '
        'ComboBox
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.lueDocumentType)
        Me.Name = "ComboBox"
        Me.Text = "ComboBox"
        CType(Me.lueDocumentType.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lueDocumentType As DevExpress.XtraEditors.LookUpEdit
End Class
