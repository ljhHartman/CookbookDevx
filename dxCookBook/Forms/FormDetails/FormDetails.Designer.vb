<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormDetails
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
        Me.tbPersonID = New sslDataTextBox.txtDataTextBox()
        Me.lblPersonID = New System.Windows.Forms.Label()
        Me.lblLastName = New System.Windows.Forms.Label()
        Me.tbLastName = New sslDataTextBox.txtDataTextBox()
        Me.lblFirstName = New System.Windows.Forms.Label()
        Me.tbFirstName = New sslDataTextBox.txtDataTextBox()
        Me.lblCity = New System.Windows.Forms.Label()
        Me.tbCity = New sslDataTextBox.txtDataTextBox()
        Me.SslDataGrid1 = New sslDataGrid.sslDataGrid()
        Me.SslGridView1 = New sslDataGrid.sslGridView()
        CType(Me.tbPersonID.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tbLastName.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tbFirstName.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tbCity.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SslDataGrid1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SslGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tbPersonID
        '
        Me.tbPersonID.Location = New System.Drawing.Point(125, 41)
        Me.tbPersonID.Name = "tbPersonID"
        Me.tbPersonID.Properties.Appearance.BackColor = System.Drawing.Color.LightSteelBlue
        Me.tbPersonID.Properties.Appearance.ForeColor = System.Drawing.Color.Black
        Me.tbPersonID.Properties.Appearance.Options.UseBackColor = True
        Me.tbPersonID.Properties.Appearance.Options.UseForeColor = True
        Me.tbPersonID.ShowToolTips = False
        Me.tbPersonID.Size = New System.Drawing.Size(100, 20)
        Me.tbPersonID.TabIndex = 0
        '
        'lblPersonID
        '
        Me.lblPersonID.AutoSize = True
        Me.lblPersonID.Location = New System.Drawing.Point(48, 48)
        Me.lblPersonID.Name = "lblPersonID"
        Me.lblPersonID.Size = New System.Drawing.Size(51, 13)
        Me.lblPersonID.TabIndex = 1
        Me.lblPersonID.Text = "PersonID"
        '
        'lblLastName
        '
        Me.lblLastName.AutoSize = True
        Me.lblLastName.Location = New System.Drawing.Point(48, 83)
        Me.lblLastName.Name = "lblLastName"
        Me.lblLastName.Size = New System.Drawing.Size(55, 13)
        Me.lblLastName.TabIndex = 3
        Me.lblLastName.Text = "LastName"
        '
        'tbLastName
        '
        Me.tbLastName.Location = New System.Drawing.Point(125, 76)
        Me.tbLastName.Name = "tbLastName"
        Me.tbLastName.Properties.Appearance.BackColor = System.Drawing.Color.LightSteelBlue
        Me.tbLastName.Properties.Appearance.ForeColor = System.Drawing.Color.Black
        Me.tbLastName.Properties.Appearance.Options.UseBackColor = True
        Me.tbLastName.Properties.Appearance.Options.UseForeColor = True
        Me.tbLastName.ShowToolTips = False
        Me.tbLastName.Size = New System.Drawing.Size(100, 20)
        Me.tbLastName.TabIndex = 2
        '
        'lblFirstName
        '
        Me.lblFirstName.AutoSize = True
        Me.lblFirstName.Location = New System.Drawing.Point(48, 119)
        Me.lblFirstName.Name = "lblFirstName"
        Me.lblFirstName.Size = New System.Drawing.Size(54, 13)
        Me.lblFirstName.TabIndex = 5
        Me.lblFirstName.Text = "FirstName"
        '
        'tbFirstName
        '
        Me.tbFirstName.Location = New System.Drawing.Point(125, 112)
        Me.tbFirstName.Name = "tbFirstName"
        Me.tbFirstName.Properties.Appearance.BackColor = System.Drawing.Color.LightSteelBlue
        Me.tbFirstName.Properties.Appearance.ForeColor = System.Drawing.Color.Black
        Me.tbFirstName.Properties.Appearance.Options.UseBackColor = True
        Me.tbFirstName.Properties.Appearance.Options.UseForeColor = True
        Me.tbFirstName.ShowToolTips = False
        Me.tbFirstName.Size = New System.Drawing.Size(100, 20)
        Me.tbFirstName.TabIndex = 4
        '
        'lblCity
        '
        Me.lblCity.AutoSize = True
        Me.lblCity.Location = New System.Drawing.Point(48, 157)
        Me.lblCity.Name = "lblCity"
        Me.lblCity.Size = New System.Drawing.Size(24, 13)
        Me.lblCity.TabIndex = 7
        Me.lblCity.Text = "City"
        '
        'tbCity
        '
        Me.tbCity.Location = New System.Drawing.Point(125, 150)
        Me.tbCity.Name = "tbCity"
        Me.tbCity.Properties.Appearance.BackColor = System.Drawing.Color.LightSteelBlue
        Me.tbCity.Properties.Appearance.ForeColor = System.Drawing.Color.Black
        Me.tbCity.Properties.Appearance.Options.UseBackColor = True
        Me.tbCity.Properties.Appearance.Options.UseForeColor = True
        Me.tbCity.ShowToolTips = False
        Me.tbCity.Size = New System.Drawing.Size(100, 20)
        Me.tbCity.TabIndex = 6
        '
        'SslDataGrid1
        '
        Me.SslDataGrid1.Location = New System.Drawing.Point(255, 44)
        Me.SslDataGrid1.MainView = Me.SslGridView1
        Me.SslDataGrid1.Name = "SslDataGrid1"
        Me.SslDataGrid1.Size = New System.Drawing.Size(533, 394)
        Me.SslDataGrid1.TabIndex = 8
        Me.SslDataGrid1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.SslGridView1})
        '
        'SslGridView1
        '
        Me.SslGridView1.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.[Default]
        Me.SslGridView1.GridControl = Me.SslDataGrid1
        Me.SslGridView1.Name = "SslGridView1"
        Me.SslGridView1.SimpleSearch = False
        '
        'FormDetails
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.SslDataGrid1)
        Me.Controls.Add(Me.lblCity)
        Me.Controls.Add(Me.tbCity)
        Me.Controls.Add(Me.lblFirstName)
        Me.Controls.Add(Me.tbFirstName)
        Me.Controls.Add(Me.lblLastName)
        Me.Controls.Add(Me.tbLastName)
        Me.Controls.Add(Me.lblPersonID)
        Me.Controls.Add(Me.tbPersonID)
        Me.Name = "FormDetails"
        Me.Text = "BeindingList"
        CType(Me.tbPersonID.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tbLastName.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tbFirstName.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tbCity.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SslDataGrid1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SslGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents tbPersonID As sslDataTextBox.txtDataTextBox
    Friend WithEvents lblPersonID As Label
    Friend WithEvents lblLastName As Label
    Friend WithEvents tbLastName As sslDataTextBox.txtDataTextBox
    Friend WithEvents lblFirstName As Label
    Friend WithEvents tbFirstName As sslDataTextBox.txtDataTextBox
    Friend WithEvents lblCity As Label
    Friend WithEvents tbCity As sslDataTextBox.txtDataTextBox
    Friend WithEvents SslDataGrid1 As sslDataGrid.sslDataGrid
    Friend WithEvents SslGridView1 As sslDataGrid.sslGridView
End Class
