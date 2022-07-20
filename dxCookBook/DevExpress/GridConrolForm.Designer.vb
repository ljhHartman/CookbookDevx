<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GridConrolForm
    Inherits DevExpress.XtraEditors.XtraForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl()
        Me.StockBindingSource = New System.Windows.Forms.BindingSource()
        Me.SSLTESTDataSet = New dxCookBook.SSLTESTDataSet()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colSTOCKID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPACKAGEID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colFILENUMBER = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colINWARDNUMBER = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCUSTOMER = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDEPOT = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colLOCATION = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colINSTOCK = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSTOCKOUT = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPRODUCTID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPRODUCTGROUP = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTOTALPACKAGES = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCONFIRMEDTOTAL = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colREMAININGPACKAGES = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colORDERNUMBERS = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colVESSEL = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colGROSSWEIGHT = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colNETTWEIGHT = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colLENGTH = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colHEIGHT = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colWIDTH = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colM3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colVALUE = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCURRENCY = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colLOCALVALUE = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCUSTOMSTYPE = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCUSTOMSSTATUS = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCUSTOMSNUMBER = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.StockTableAdapter = New dxCookBook.SSLTESTDataSetTableAdapters.StockTableAdapter()
        Me.btnObtain = New System.Windows.Forms.Button()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StockBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SSLTESTDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GridControl1
        '
        Me.GridControl1.DataSource = Me.StockBindingSource
        Me.GridControl1.Dock = System.Windows.Forms.DockStyle.Top
        Me.GridControl1.Location = New System.Drawing.Point(0, 0)
        Me.GridControl1.MainView = Me.GridView1
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.Size = New System.Drawing.Size(1662, 220)
        Me.GridControl1.TabIndex = 0
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'StockBindingSource
        '
        Me.StockBindingSource.DataMember = "Stock"
        Me.StockBindingSource.DataSource = Me.SSLTESTDataSet
        '
        'SSLTESTDataSet
        '
        Me.SSLTESTDataSet.DataSetName = "SSLTESTDataSet"
        Me.SSLTESTDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colSTOCKID, Me.colPACKAGEID, Me.colFILENUMBER, Me.colINWARDNUMBER, Me.colCUSTOMER, Me.colDEPOT, Me.colLOCATION, Me.colINSTOCK, Me.colSTOCKOUT, Me.colPRODUCTID, Me.colPRODUCTGROUP, Me.colTOTALPACKAGES, Me.colCONFIRMEDTOTAL, Me.colREMAININGPACKAGES, Me.colORDERNUMBERS, Me.colVESSEL, Me.colGROSSWEIGHT, Me.colNETTWEIGHT, Me.colLENGTH, Me.colHEIGHT, Me.colWIDTH, Me.colM3, Me.colVALUE, Me.colCURRENCY, Me.colLOCALVALUE, Me.colCUSTOMSTYPE, Me.colCUSTOMSSTATUS, Me.colCUSTOMSNUMBER})
        Me.GridView1.GridControl = Me.GridControl1
        Me.GridView1.HorzScrollStep = 1
        Me.GridView1.HorzScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Always
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsBehavior.AllowPixelScrolling = DevExpress.Utils.DefaultBoolean.[True]
        Me.GridView1.OptionsPrint.AutoWidth = False
        Me.GridView1.OptionsSelection.MultiSelect = True
        Me.GridView1.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect
        Me.GridView1.OptionsView.ColumnAutoWidth = False
        Me.GridView1.OptionsView.ShowFooter = True
        Me.GridView1.OptionsView.ShowGroupPanel = False
        Me.GridView1.OptionsView.ShowHorizontalLines = DevExpress.Utils.DefaultBoolean.[True]
        Me.GridView1.VertScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Always
        '
        'colSTOCKID
        '
        Me.colSTOCKID.FieldName = "STOCKID"
        Me.colSTOCKID.Name = "colSTOCKID"
        Me.colSTOCKID.Visible = True
        Me.colSTOCKID.VisibleIndex = 1
        '
        'colPACKAGEID
        '
        Me.colPACKAGEID.FieldName = "PACKAGEID"
        Me.colPACKAGEID.Name = "colPACKAGEID"
        Me.colPACKAGEID.Visible = True
        Me.colPACKAGEID.VisibleIndex = 2
        '
        'colFILENUMBER
        '
        Me.colFILENUMBER.FieldName = "FILENUMBER"
        Me.colFILENUMBER.Name = "colFILENUMBER"
        Me.colFILENUMBER.Visible = True
        Me.colFILENUMBER.VisibleIndex = 3
        '
        'colINWARDNUMBER
        '
        Me.colINWARDNUMBER.FieldName = "INWARDNUMBER"
        Me.colINWARDNUMBER.Name = "colINWARDNUMBER"
        Me.colINWARDNUMBER.Visible = True
        Me.colINWARDNUMBER.VisibleIndex = 4
        '
        'colCUSTOMER
        '
        Me.colCUSTOMER.FieldName = "CUSTOMER"
        Me.colCUSTOMER.Name = "colCUSTOMER"
        Me.colCUSTOMER.Visible = True
        Me.colCUSTOMER.VisibleIndex = 5
        '
        'colDEPOT
        '
        Me.colDEPOT.FieldName = "DEPOT"
        Me.colDEPOT.Name = "colDEPOT"
        Me.colDEPOT.Visible = True
        Me.colDEPOT.VisibleIndex = 6
        '
        'colLOCATION
        '
        Me.colLOCATION.FieldName = "LOCATION"
        Me.colLOCATION.Name = "colLOCATION"
        Me.colLOCATION.Visible = True
        Me.colLOCATION.VisibleIndex = 7
        '
        'colINSTOCK
        '
        Me.colINSTOCK.FieldName = "INSTOCK"
        Me.colINSTOCK.Name = "colINSTOCK"
        Me.colINSTOCK.Visible = True
        Me.colINSTOCK.VisibleIndex = 8
        '
        'colSTOCKOUT
        '
        Me.colSTOCKOUT.FieldName = "STOCKOUT"
        Me.colSTOCKOUT.Name = "colSTOCKOUT"
        Me.colSTOCKOUT.Visible = True
        Me.colSTOCKOUT.VisibleIndex = 9
        '
        'colPRODUCTID
        '
        Me.colPRODUCTID.FieldName = "PRODUCTID"
        Me.colPRODUCTID.Name = "colPRODUCTID"
        Me.colPRODUCTID.Visible = True
        Me.colPRODUCTID.VisibleIndex = 10
        '
        'colPRODUCTGROUP
        '
        Me.colPRODUCTGROUP.FieldName = "PRODUCTGROUP"
        Me.colPRODUCTGROUP.Name = "colPRODUCTGROUP"
        Me.colPRODUCTGROUP.Visible = True
        Me.colPRODUCTGROUP.VisibleIndex = 11
        '
        'colTOTALPACKAGES
        '
        Me.colTOTALPACKAGES.FieldName = "TOTALPACKAGES"
        Me.colTOTALPACKAGES.Name = "colTOTALPACKAGES"
        Me.colTOTALPACKAGES.Visible = True
        Me.colTOTALPACKAGES.VisibleIndex = 12
        '
        'colCONFIRMEDTOTAL
        '
        Me.colCONFIRMEDTOTAL.FieldName = "CONFIRMEDTOTAL"
        Me.colCONFIRMEDTOTAL.Name = "colCONFIRMEDTOTAL"
        Me.colCONFIRMEDTOTAL.Visible = True
        Me.colCONFIRMEDTOTAL.VisibleIndex = 13
        '
        'colREMAININGPACKAGES
        '
        Me.colREMAININGPACKAGES.FieldName = "REMAININGPACKAGES"
        Me.colREMAININGPACKAGES.Name = "colREMAININGPACKAGES"
        Me.colREMAININGPACKAGES.Visible = True
        Me.colREMAININGPACKAGES.VisibleIndex = 14
        '
        'colORDERNUMBERS
        '
        Me.colORDERNUMBERS.FieldName = "ORDERNUMBERS"
        Me.colORDERNUMBERS.Name = "colORDERNUMBERS"
        Me.colORDERNUMBERS.Visible = True
        Me.colORDERNUMBERS.VisibleIndex = 15
        '
        'colVESSEL
        '
        Me.colVESSEL.FieldName = "VESSEL"
        Me.colVESSEL.Name = "colVESSEL"
        Me.colVESSEL.Visible = True
        Me.colVESSEL.VisibleIndex = 16
        '
        'colGROSSWEIGHT
        '
        Me.colGROSSWEIGHT.FieldName = "GROSSWEIGHT"
        Me.colGROSSWEIGHT.Name = "colGROSSWEIGHT"
        Me.colGROSSWEIGHT.Visible = True
        Me.colGROSSWEIGHT.VisibleIndex = 17
        '
        'colNETTWEIGHT
        '
        Me.colNETTWEIGHT.FieldName = "NETTWEIGHT"
        Me.colNETTWEIGHT.Name = "colNETTWEIGHT"
        Me.colNETTWEIGHT.Visible = True
        Me.colNETTWEIGHT.VisibleIndex = 18
        '
        'colLENGTH
        '
        Me.colLENGTH.FieldName = "LENGTH"
        Me.colLENGTH.Name = "colLENGTH"
        Me.colLENGTH.Visible = True
        Me.colLENGTH.VisibleIndex = 19
        '
        'colHEIGHT
        '
        Me.colHEIGHT.FieldName = "HEIGHT"
        Me.colHEIGHT.Name = "colHEIGHT"
        Me.colHEIGHT.Visible = True
        Me.colHEIGHT.VisibleIndex = 20
        '
        'colWIDTH
        '
        Me.colWIDTH.FieldName = "WIDTH"
        Me.colWIDTH.Name = "colWIDTH"
        Me.colWIDTH.Visible = True
        Me.colWIDTH.VisibleIndex = 21
        '
        'colM3
        '
        Me.colM3.FieldName = "M3"
        Me.colM3.Name = "colM3"
        Me.colM3.Visible = True
        Me.colM3.VisibleIndex = 22
        '
        'colVALUE
        '
        Me.colVALUE.FieldName = "VALUE"
        Me.colVALUE.Name = "colVALUE"
        Me.colVALUE.Visible = True
        Me.colVALUE.VisibleIndex = 23
        '
        'colCURRENCY
        '
        Me.colCURRENCY.FieldName = "CURRENCY"
        Me.colCURRENCY.Name = "colCURRENCY"
        Me.colCURRENCY.Visible = True
        Me.colCURRENCY.VisibleIndex = 24
        '
        'colLOCALVALUE
        '
        Me.colLOCALVALUE.FieldName = "LOCALVALUE"
        Me.colLOCALVALUE.Name = "colLOCALVALUE"
        Me.colLOCALVALUE.Visible = True
        Me.colLOCALVALUE.VisibleIndex = 25
        '
        'colCUSTOMSTYPE
        '
        Me.colCUSTOMSTYPE.FieldName = "CUSTOMSTYPE"
        Me.colCUSTOMSTYPE.Name = "colCUSTOMSTYPE"
        Me.colCUSTOMSTYPE.Visible = True
        Me.colCUSTOMSTYPE.VisibleIndex = 26
        '
        'colCUSTOMSSTATUS
        '
        Me.colCUSTOMSSTATUS.FieldName = "CUSTOMSSTATUS"
        Me.colCUSTOMSSTATUS.Name = "colCUSTOMSSTATUS"
        Me.colCUSTOMSSTATUS.Visible = True
        Me.colCUSTOMSSTATUS.VisibleIndex = 27
        '
        'colCUSTOMSNUMBER
        '
        Me.colCUSTOMSNUMBER.FieldName = "CUSTOMSNUMBER"
        Me.colCUSTOMSNUMBER.Name = "colCUSTOMSNUMBER"
        Me.colCUSTOMSNUMBER.Visible = True
        Me.colCUSTOMSNUMBER.VisibleIndex = 28
        '
        'StockTableAdapter
        '
        Me.StockTableAdapter.ClearBeforeFill = True
        '
        'btnObtain
        '
        Me.btnObtain.Location = New System.Drawing.Point(12, 226)
        Me.btnObtain.Name = "btnObtain"
        Me.btnObtain.Size = New System.Drawing.Size(242, 39)
        Me.btnObtain.TabIndex = 1
        Me.btnObtain.Text = "Obtain the Selected Rows"
        Me.btnObtain.UseVisualStyleBackColor = True
        '
        'GridConrolForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1662, 460)
        Me.Controls.Add(Me.btnObtain)
        Me.Controls.Add(Me.GridControl1)
        Me.Name = "GridConrolForm"
        Me.Text = "GridConrolForm"
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StockBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SSLTESTDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents SSLTESTDataSet As SSLTESTDataSet
    Friend WithEvents StockBindingSource As BindingSource
    Friend WithEvents StockTableAdapter As SSLTESTDataSetTableAdapters.StockTableAdapter
    Friend WithEvents colSTOCKID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPACKAGEID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFILENUMBER As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colINWARDNUMBER As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCUSTOMER As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDEPOT As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colLOCATION As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colINSTOCK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSTOCKOUT As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPRODUCTID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPRODUCTGROUP As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTOTALPACKAGES As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCONFIRMEDTOTAL As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colREMAININGPACKAGES As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colORDERNUMBERS As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colVESSEL As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colGROSSWEIGHT As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNETTWEIGHT As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colLENGTH As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colHEIGHT As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colWIDTH As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colM3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colVALUE As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCURRENCY As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colLOCALVALUE As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCUSTOMSTYPE As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCUSTOMSSTATUS As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCUSTOMSNUMBER As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents btnObtain As Button
End Class
