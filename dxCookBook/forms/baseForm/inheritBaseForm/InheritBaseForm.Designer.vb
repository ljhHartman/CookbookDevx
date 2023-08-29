<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class InheritBaseForm
    Inherits BaseForm

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
        Me.btnWarningMessageBox = New System.Windows.Forms.Button()
        Me.btnPrint = New System.Windows.Forms.Button()
        CType(Me.aTimer, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnWarningMessageBox
        '
        Me.btnWarningMessageBox.Location = New System.Drawing.Point(12, 12)
        Me.btnWarningMessageBox.Name = "btnWarningMessageBox"
        Me.btnWarningMessageBox.Size = New System.Drawing.Size(129, 23)
        Me.btnWarningMessageBox.TabIndex = 0
        Me.btnWarningMessageBox.Text = "Warning MessageBox"
        Me.btnWarningMessageBox.UseVisualStyleBackColor = True
        '
        'btnPrint
        '
        Me.btnPrint.Location = New System.Drawing.Point(12, 41)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(129, 23)
        Me.btnPrint.TabIndex = 1
        Me.btnPrint.Text = "Print to Output"
        Me.btnPrint.UseVisualStyleBackColor = True
        '
        'InheritBaseForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnPrint)
        Me.Controls.Add(Me.btnWarningMessageBox)
        Me.Name = "InheritBaseForm"
        Me.Text = "InheritBaseForm"
        CType(Me.aTimer, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnWarningMessageBox As Button
    Friend WithEvents btnPrint As Button
End Class
