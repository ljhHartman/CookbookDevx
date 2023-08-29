<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ClickRow
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
        Me.AndroidusersBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        'Me.SSLTESTDataSet2 = New dxCookBook.SSLTESTDataSet2()
        'Me.Android_usersTableAdapter = New dxCookBook.SSLTESTDataSet2TableAdapters.android_usersTableAdapter()
        'Me.SsltestDataSet1 = New dxCookBook.SSLTESTDataSet()
        ' Me.SsltestDataSet3 = New dxCookBook.SSLTESTDataSet()
        Me.SslDataGrid1 = New sslDataGrid.sslDataGrid()
        Me.AndroidusersBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        'Me.SSLTESTDataSet31 = New dxCookBook.SSLTESTDataSet3()
        Me.SslGridView1 = New sslDataGrid.sslGridView()
        Me.colid = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colauthority = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colemail = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colenabled = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colimage = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colpassword = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colusername = New DevExpress.XtraGrid.Columns.GridColumn()
        ' Me.Android_usersTableAdapter1 = New dxCookBook.SSLTESTDataSet3TableAdapters.android_usersTableAdapter()
        CType(Me.AndroidusersBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SSLTESTDataSet2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SsltestDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SsltestDataSet3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SslDataGrid1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AndroidusersBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SSLTESTDataSet31, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SslGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'AndroidusersBindingSource
        '
        Me.AndroidusersBindingSource.DataMember = "android_users"
        Me.AndroidusersBindingSource.DataSource = Me.SSLTESTDataSet2
        '
        'SSLTESTDataSet2
        '
        Me.SSLTESTDataSet2.DataSetName = "SSLTESTDataSet2"
        Me.SSLTESTDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Android_usersTableAdapter
        '
        Me.Android_usersTableAdapter.ClearBeforeFill = True
        '
        'SsltestDataSet1
        '
        Me.SsltestDataSet1.DataSetName = "SSLTESTDataSet"
        Me.SsltestDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'SsltestDataSet3
        '
        Me.SsltestDataSet3.DataSetName = "SSLTESTDataSet"
        Me.SsltestDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'SslDataGrid1
        '
        Me.SslDataGrid1.DataSource = Me.AndroidusersBindingSource1
        Me.SslDataGrid1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SslDataGrid1.Location = New System.Drawing.Point(0, 0)
        Me.SslDataGrid1.MainView = Me.SslGridView1
        Me.SslDataGrid1.Name = "SslDataGrid1"
        Me.SslDataGrid1.Size = New System.Drawing.Size(800, 450)
        Me.SslDataGrid1.TabIndex = 0
        Me.SslDataGrid1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.SslGridView1})
        '
        'AndroidusersBindingSource1
        '
        Me.AndroidusersBindingSource1.DataMember = "android_users"
        Me.AndroidusersBindingSource1.DataSource = Me.SSLTESTDataSet31
        '
        'SSLTESTDataSet31
        '
        Me.SSLTESTDataSet31.DataSetName = "SSLTESTDataSet3"
        Me.SSLTESTDataSet31.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'SslGridView1
        '
        Me.SslGridView1.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.[Default]
        Me.SslGridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colid, Me.colauthority, Me.colemail, Me.colenabled, Me.colimage, Me.colpassword, Me.colusername})
        Me.SslGridView1.GridControl = Me.SslDataGrid1
        Me.SslGridView1.Name = "SslGridView1"
        Me.SslGridView1.OptionsBehavior.Editable = False
        Me.SslGridView1.SimpleSearch = False
        '
        'colid
        '
        Me.colid.FieldName = "id"
        Me.colid.Name = "colid"
        Me.colid.Visible = True
        Me.colid.VisibleIndex = 0
        '
        'colauthority
        '
        Me.colauthority.FieldName = "authority"
        Me.colauthority.Name = "colauthority"
        Me.colauthority.Visible = True
        Me.colauthority.VisibleIndex = 1
        '
        'colemail
        '
        Me.colemail.FieldName = "email"
        Me.colemail.Name = "colemail"
        Me.colemail.Visible = True
        Me.colemail.VisibleIndex = 2
        '
        'colenabled
        '
        Me.colenabled.FieldName = "enabled"
        Me.colenabled.Name = "colenabled"
        Me.colenabled.Visible = True
        Me.colenabled.VisibleIndex = 3
        '
        'colimage
        '
        Me.colimage.FieldName = "image"
        Me.colimage.Name = "colimage"
        Me.colimage.Visible = True
        Me.colimage.VisibleIndex = 4
        '
        'colpassword
        '
        Me.colpassword.FieldName = "password"
        Me.colpassword.Name = "colpassword"
        Me.colpassword.Visible = True
        Me.colpassword.VisibleIndex = 5
        '
        'colusername
        '
        Me.colusername.FieldName = "username"
        Me.colusername.Name = "colusername"
        Me.colusername.Visible = True
        Me.colusername.VisibleIndex = 6
        '
        'Android_usersTableAdapter1
        '
        Me.Android_usersTableAdapter1.ClearBeforeFill = True
        '
        'ClickRow
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.SslDataGrid1)
        Me.Name = "ClickRow"
        Me.Text = "ClickRow"
        CType(Me.AndroidusersBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SSLTESTDataSet2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SsltestDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SsltestDataSet3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SslDataGrid1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AndroidusersBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SSLTESTDataSet31, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SslGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SSLTESTDataSet2 As SSLTESTDataSet2
    Friend WithEvents AndroidusersBindingSource As BindingSource
    Friend WithEvents Android_usersTableAdapter As SSLTESTDataSet2TableAdapters.android_usersTableAdapter
    Friend WithEvents SsltestDataSet1 As SSLTESTDataSet
    Friend WithEvents SsltestDataSet3 As SSLTESTDataSet
    Friend WithEvents SslDataGrid1 As sslDataGrid.sslDataGrid
    Friend WithEvents SslGridView1 As sslDataGrid.sslGridView
    Friend WithEvents SSLTESTDataSet31 As SSLTESTDataSet3
    Friend WithEvents AndroidusersBindingSource1 As BindingSource
    Friend WithEvents Android_usersTableAdapter1 As SSLTESTDataSet3TableAdapters.android_usersTableAdapter
    Friend WithEvents colid As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colauthority As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colemail As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colenabled As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colimage As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colpassword As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colusername As DevExpress.XtraGrid.Columns.GridColumn
End Class
