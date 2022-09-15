<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ChartForm
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
        Dim XyDiagram1 As DevExpress.XtraCharts.XYDiagram = New DevExpress.XtraCharts.XYDiagram()
        Dim Series1 As DevExpress.XtraCharts.Series = New DevExpress.XtraCharts.Series()
        Dim LineSeriesView1 As DevExpress.XtraCharts.LineSeriesView = New DevExpress.XtraCharts.LineSeriesView()
        Me.ChartControl1 = New DevExpress.XtraCharts.ChartControl()
        Me.InkomendeFacturenTableAdapter = New dxCookBook.SSLTESTDataSet1TableAdapters.InkomendeFacturenTableAdapter()
        Me.InkomendeFacturenBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SSLTESTDataSet1 = New dxCookBook.SSLTESTDataSet1()
        CType(Me.ChartControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(XyDiagram1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Series1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(LineSeriesView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.InkomendeFacturenBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SSLTESTDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ChartControl1
        '
        Me.ChartControl1.DataAdapter = Me.InkomendeFacturenTableAdapter
        Me.ChartControl1.DataBindings = Nothing
        Me.ChartControl1.DataSource = Me.InkomendeFacturenBindingSource
        XyDiagram1.AxisX.VisibleInPanesSerializable = "-1"
        XyDiagram1.AxisY.VisibleInPanesSerializable = "-1"
        Me.ChartControl1.Diagram = XyDiagram1
        Me.ChartControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ChartControl1.Legend.Name = "Default Legend"
        Me.ChartControl1.Location = New System.Drawing.Point(0, 0)
        Me.ChartControl1.Name = "ChartControl1"
        Series1.ArgumentDataMember = "FACTUURDATUM"
        Series1.Name = "Series 1"
        Series1.ValueDataMembersSerializable = "BEDRAG"
        Series1.View = LineSeriesView1
        Me.ChartControl1.SeriesSerializable = New DevExpress.XtraCharts.Series() {Series1}
        Me.ChartControl1.Size = New System.Drawing.Size(483, 450)
        Me.ChartControl1.TabIndex = 0
        '
        'InkomendeFacturenTableAdapter
        '
        Me.InkomendeFacturenTableAdapter.ClearBeforeFill = True
        '
        'InkomendeFacturenBindingSource
        '
        Me.InkomendeFacturenBindingSource.DataMember = "InkomendeFacturen"
        Me.InkomendeFacturenBindingSource.DataSource = Me.SSLTESTDataSet1
        '
        'SSLTESTDataSet1
        '
        Me.SSLTESTDataSet1.DataSetName = "SSLTESTDataSet1"
        Me.SSLTESTDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ChartForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(483, 450)
        Me.Controls.Add(Me.ChartControl1)
        Me.Name = "ChartForm"
        Me.Text = "ChartForm"
        CType(XyDiagram1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(LineSeriesView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Series1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ChartControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.InkomendeFacturenBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SSLTESTDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ChartControl1 As DevExpress.XtraCharts.ChartControl
    Friend WithEvents InkomendeFacturenTableAdapter As SSLTESTDataSet1TableAdapters.InkomendeFacturenTableAdapter
    Friend WithEvents SSLTESTDataSet1 As SSLTESTDataSet1
    Friend WithEvents InkomendeFacturenBindingSource As BindingSource
End Class
