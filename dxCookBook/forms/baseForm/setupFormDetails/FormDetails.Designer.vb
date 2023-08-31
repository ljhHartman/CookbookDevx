<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormDetails
    Inherits BaseForm

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
        Me.lblPersonID = New System.Windows.Forms.Label()
        Me.lblLastName = New System.Windows.Forms.Label()
        Me.lblFirstName = New System.Windows.Forms.Label()
        Me.lblCity = New System.Windows.Forms.Label()
        Me.tePersonID = New DevExpress.XtraEditors.TextEdit()
        Me.teLastName = New DevExpress.XtraEditors.TextEdit()
        Me.teFirstName = New DevExpress.XtraEditors.TextEdit()
        Me.teCity = New DevExpress.XtraEditors.TextEdit()
        Me.btnAddRow = New System.Windows.Forms.Button()
        Me.btnClearView = New System.Windows.Forms.Button()
        Me.btnInitializeView = New System.Windows.Forms.Button()
        Me.SslDataGrid1 = New sslDataGrid.sslDataGrid()
        Me.SslGridView1 = New sslDataGrid.sslGridView()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.SslDataGrid2 = New sslDataGrid.sslDataGrid()
        Me.SslGridView2 = New sslDataGrid.sslGridView()
        CType(Me.aTimer, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tePersonID.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.teLastName.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.teFirstName.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.teCity.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SslDataGrid1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SslGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SslDataGrid2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SslGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'aTimer
        '
        Me.aTimer.Enabled = False
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
        'lblFirstName
        '
        Me.lblFirstName.AutoSize = True
        Me.lblFirstName.Location = New System.Drawing.Point(48, 119)
        Me.lblFirstName.Name = "lblFirstName"
        Me.lblFirstName.Size = New System.Drawing.Size(54, 13)
        Me.lblFirstName.TabIndex = 5
        Me.lblFirstName.Text = "FirstName"
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
        'tePersonID
        '
        Me.tePersonID.Location = New System.Drawing.Point(132, 45)
        Me.tePersonID.Name = "tePersonID"
        Me.tePersonID.Size = New System.Drawing.Size(100, 20)
        Me.tePersonID.TabIndex = 9
        '
        'teLastName
        '
        Me.teLastName.Location = New System.Drawing.Point(132, 80)
        Me.teLastName.Name = "teLastName"
        Me.teLastName.Size = New System.Drawing.Size(100, 20)
        Me.teLastName.TabIndex = 10
        '
        'teFirstName
        '
        Me.teFirstName.Location = New System.Drawing.Point(132, 116)
        Me.teFirstName.Name = "teFirstName"
        Me.teFirstName.Size = New System.Drawing.Size(100, 20)
        Me.teFirstName.TabIndex = 11
        '
        'teCity
        '
        Me.teCity.Location = New System.Drawing.Point(132, 154)
        Me.teCity.Name = "teCity"
        Me.teCity.Size = New System.Drawing.Size(100, 20)
        Me.teCity.TabIndex = 12
        '
        'btnAddRow
        '
        Me.btnAddRow.Location = New System.Drawing.Point(132, 194)
        Me.btnAddRow.Name = "btnAddRow"
        Me.btnAddRow.Size = New System.Drawing.Size(100, 23)
        Me.btnAddRow.TabIndex = 13
        Me.btnAddRow.Text = "Add Row"
        Me.btnAddRow.UseVisualStyleBackColor = True
        '
        'btnClearView
        '
        Me.btnClearView.Location = New System.Drawing.Point(132, 236)
        Me.btnClearView.Name = "btnClearView"
        Me.btnClearView.Size = New System.Drawing.Size(100, 23)
        Me.btnClearView.TabIndex = 14
        Me.btnClearView.Text = "Clear View"
        Me.btnClearView.UseVisualStyleBackColor = True
        '
        'btnInitializeView
        '
        Me.btnInitializeView.Location = New System.Drawing.Point(132, 281)
        Me.btnInitializeView.Name = "btnInitializeView"
        Me.btnInitializeView.Size = New System.Drawing.Size(100, 23)
        Me.btnInitializeView.TabIndex = 15
        Me.btnInitializeView.Text = "Initialize View"
        Me.btnInitializeView.UseVisualStyleBackColor = True
        '
        'SslDataGrid1
        '
        Me.SslDataGrid1.Location = New System.Drawing.Point(331, 17)
        Me.SslDataGrid1.MainView = Me.SslGridView1
        Me.SslDataGrid1.Name = "SslDataGrid1"
        Me.SslDataGrid1.Size = New System.Drawing.Size(400, 200)
        Me.SslDataGrid1.TabIndex = 16
        Me.SslDataGrid1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.SslGridView1})
        '
        'SslGridView1
        '
        Me.SslGridView1.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.[Default]
        Me.SslGridView1.GridControl = Me.SslDataGrid1
        Me.SslGridView1.Name = "SslGridView1"
        Me.SslGridView1.SimpleSearch = False
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(132, 322)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(100, 23)
        Me.btnSave.TabIndex = 19
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'SslDataGrid2
        '
        Me.SslDataGrid2.Location = New System.Drawing.Point(331, 236)
        Me.SslDataGrid2.MainView = Me.SslGridView2
        Me.SslDataGrid2.Name = "SslDataGrid2"
        Me.SslDataGrid2.Size = New System.Drawing.Size(400, 364)
        Me.SslDataGrid2.TabIndex = 20
        Me.SslDataGrid2.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.SslGridView2})
        '
        'SslGridView2
        '
        Me.SslGridView2.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.[Default]
        Me.SslGridView2.GridControl = Me.SslDataGrid2
        Me.SslGridView2.Name = "SslGridView2"
        Me.SslGridView2.SimpleSearch = False
        '
        'FormDetails
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 641)
        Me.Controls.Add(Me.SslDataGrid2)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.SslDataGrid1)
        Me.Controls.Add(Me.btnInitializeView)
        Me.Controls.Add(Me.btnClearView)
        Me.Controls.Add(Me.btnAddRow)
        Me.Controls.Add(Me.teCity)
        Me.Controls.Add(Me.teFirstName)
        Me.Controls.Add(Me.teLastName)
        Me.Controls.Add(Me.tePersonID)
        Me.Controls.Add(Me.lblCity)
        Me.Controls.Add(Me.lblFirstName)
        Me.Controls.Add(Me.lblLastName)
        Me.Controls.Add(Me.lblPersonID)
        Me.Name = "FormDetails"
        Me.Text = "BeindingList"
        CType(Me.aTimer, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tePersonID.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.teLastName.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.teFirstName.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.teCity.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SslDataGrid1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SslGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SslDataGrid2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SslGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblPersonID As Label
    Friend WithEvents lblLastName As Label
    Friend WithEvents lblFirstName As Label
    Friend WithEvents lblCity As Label
    Friend WithEvents tePersonID As DevExpress.XtraEditors.TextEdit
    Friend WithEvents teLastName As DevExpress.XtraEditors.TextEdit
    Friend WithEvents teFirstName As DevExpress.XtraEditors.TextEdit
    Friend WithEvents teCity As DevExpress.XtraEditors.TextEdit
    Friend WithEvents btnAddRow As Button
    Friend WithEvents btnClearView As Button
    Friend WithEvents btnInitializeView As Button
    Friend WithEvents SslDataGrid1 As sslDataGrid.sslDataGrid
    Friend WithEvents SslGridView1 As sslDataGrid.sslGridView
    Friend WithEvents btnSave As Button
    Friend WithEvents SslDataGrid2 As sslDataGrid.sslDataGrid
    Friend WithEvents SslGridView2 As sslDataGrid.sslGridView
End Class
