<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MessageBoxError
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
        Me.components = New System.ComponentModel.Container()
        Me.btnRelactionCode = New System.Windows.Forms.Button()
        Me.DxErrorProvider1 = New DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider(Me.components)
        Me.teRelationCode = New DevExpress.XtraEditors.TextEdit()
        Me.lblRelationCode = New System.Windows.Forms.Label()
        Me.BehaviorManager1 = New DevExpress.Utils.Behaviors.BehaviorManager(Me.components)
        Me.btnSave = New System.Windows.Forms.Button()
        CType(Me.DxErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.teRelationCode.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BehaviorManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnRelactionCode
        '
        Me.btnRelactionCode.Location = New System.Drawing.Point(341, 12)
        Me.btnRelactionCode.Name = "btnRelactionCode"
        Me.btnRelactionCode.Size = New System.Drawing.Size(112, 23)
        Me.btnRelactionCode.TabIndex = 0
        Me.btnRelactionCode.Text = "New Relation Code"
        Me.btnRelactionCode.UseVisualStyleBackColor = True
        '
        'DxErrorProvider1
        '
        Me.DxErrorProvider1.ContainerControl = Me
        '
        'teRelationCode
        '
        Me.teRelationCode.Location = New System.Drawing.Point(341, 158)
        Me.teRelationCode.Name = "teRelationCode"
        Me.teRelationCode.Size = New System.Drawing.Size(112, 20)
        Me.teRelationCode.TabIndex = 1
        '
        'lblRelationCode
        '
        Me.lblRelationCode.AutoSize = True
        Me.lblRelationCode.Location = New System.Drawing.Point(254, 161)
        Me.lblRelationCode.Name = "lblRelationCode"
        Me.lblRelationCode.Size = New System.Drawing.Size(70, 13)
        Me.lblRelationCode.TabIndex = 2
        Me.lblRelationCode.Text = "Relationcode"
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(667, 399)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(75, 23)
        Me.btnSave.TabIndex = 3
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'MessageBoxError
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.lblRelationCode)
        Me.Controls.Add(Me.teRelationCode)
        Me.Controls.Add(Me.btnRelactionCode)
        Me.Name = "MessageBoxError"
        Me.Text = "MessageBoxError"
        CType(Me.DxErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.teRelationCode.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BehaviorManager1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnRelactionCode As Button
    Private WithEvents DxErrorProvider1 As DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider
    Friend WithEvents lblRelationCode As Label
    Friend WithEvents teRelationCode As DevExpress.XtraEditors.TextEdit
    Friend WithEvents BehaviorManager1 As DevExpress.Utils.Behaviors.BehaviorManager
    Friend WithEvents btnSave As Button
End Class
