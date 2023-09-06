<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SqlStoredProcedure
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
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.btnDeleteStatement = New System.Windows.Forms.Button()
        Me.btnUpdateStatement = New System.Windows.Forms.Button()
        Me.btnInsertStatement = New System.Windows.Forms.Button()
        Me.btnReadStatement = New System.Windows.Forms.Button()
        CType(Me.aTimer, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.btnDeleteStatement, 0, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.btnUpdateStatement, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.btnInsertStatement, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.btnReadStatement, 0, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 10
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(800, 450)
        Me.TableLayoutPanel1.TabIndex = 1
        '
        'btnDeleteStatement
        '
        Me.btnDeleteStatement.Location = New System.Drawing.Point(3, 138)
        Me.btnDeleteStatement.Name = "btnDeleteStatement"
        Me.btnDeleteStatement.Size = New System.Drawing.Size(75, 23)
        Me.btnDeleteStatement.TabIndex = 6
        Me.btnDeleteStatement.Text = "Delete Statment"
        Me.btnDeleteStatement.UseVisualStyleBackColor = True
        '
        'btnUpdateStatement
        '
        Me.btnUpdateStatement.Location = New System.Drawing.Point(3, 93)
        Me.btnUpdateStatement.Name = "btnUpdateStatement"
        Me.btnUpdateStatement.Size = New System.Drawing.Size(75, 23)
        Me.btnUpdateStatement.TabIndex = 4
        Me.btnUpdateStatement.Text = "Update Stetement"
        Me.btnUpdateStatement.UseVisualStyleBackColor = True
        '
        'btnInsertStatement
        '
        Me.btnInsertStatement.Location = New System.Drawing.Point(3, 48)
        Me.btnInsertStatement.Name = "btnInsertStatement"
        Me.btnInsertStatement.Size = New System.Drawing.Size(75, 23)
        Me.btnInsertStatement.TabIndex = 2
        Me.btnInsertStatement.Text = "Insert Statement"
        Me.btnInsertStatement.UseVisualStyleBackColor = True
        '
        'btnReadStatement
        '
        Me.btnReadStatement.Location = New System.Drawing.Point(3, 3)
        Me.btnReadStatement.Name = "btnReadStatement"
        Me.btnReadStatement.Size = New System.Drawing.Size(75, 23)
        Me.btnReadStatement.TabIndex = 0
        Me.btnReadStatement.Text = "Read Statement"
        Me.btnReadStatement.UseVisualStyleBackColor = True
        '
        'SqlStoredProcedure
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Name = "SqlStoredProcedure"
        Me.Text = "SqlStoredProcedure"
        CType(Me.aTimer, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents btnDeleteStatement As Button
    Friend WithEvents btnUpdateStatement As Button
    Friend WithEvents btnInsertStatement As Button
    Friend WithEvents btnReadStatement As Button
End Class
