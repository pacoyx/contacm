<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FA_RE_Articulo
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim UltraGridBand1 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1)
        Dim UltraGridColumn1 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("AR_ID")
        Dim UltraGridColumn2 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("AR_CODIGO")
        Dim UltraGridColumn3 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("AR_CODIGO_ALT")
        Dim UltraGridColumn4 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("AR_DESCRIPCION", -1, Nothing, 0, Infragistics.Win.UltraWinGrid.SortIndicator.Ascending, False)
        Dim UltraGridColumn5 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("AR_PRECIO_VENTA")
        Dim Appearance1 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn6 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("AR_IDFAMILIA")
        Dim UltraGridColumn7 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FA_DESCRIPCION")
        Dim UltraGridColumn8 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("AR_IDCATEGORIA")
        Dim UltraGridColumn9 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CA_DESCRIPCION")
        Dim UltraGridColumn10 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("AR_NUM_CTA_CONTA")
        Dim Appearance2 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn11 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("AR_ESTADO")
        Dim UltraGridColumn12 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("AR_TIPO_ARTI")
        Dim UltraGridColumn13 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("AR_INCLUYE_IGV")
        Dim UltraGridColumn14 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("AR_ING_RAP")
        Dim UltraGridColumn15 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("AR_MON_VTA")
        Dim UltraGridColumn16 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("AR_CTRL_STOCK")
        Dim UltraGridColumn17 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("AR_FACTOR")
        Dim UltraGridColumn18 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("AR_UNIDAD")
        Dim Appearance35 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraDataColumn1 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("AR_ID")
        Dim UltraDataColumn2 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("AR_CODIGO")
        Dim UltraDataColumn3 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("AR_CODIGO_ALT")
        Dim UltraDataColumn4 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("AR_DESCRIPCION")
        Dim UltraDataColumn5 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("AR_PRECIO_VENTA")
        Dim UltraDataColumn6 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("AR_IDFAMILIA")
        Dim UltraDataColumn7 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("FA_DESCRIPCION")
        Dim UltraDataColumn8 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("AR_IDCATEGORIA")
        Dim UltraDataColumn9 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("CA_DESCRIPCION")
        Dim UltraDataColumn10 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("AR_NUM_CTA_CONTA")
        Dim UltraDataColumn11 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("AR_ESTADO")
        Dim UltraDataColumn12 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("AR_TIPO_ARTI")
        Dim UltraDataColumn13 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("AR_INCLUYE_IGV")
        Dim UltraDataColumn14 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("AR_ING_RAP")
        Dim UltraDataColumn15 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("AR_MON_VTA")
        Dim UltraDataColumn16 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("AR_CTRL_STOCK")
        Dim UltraDataColumn17 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("AR_FACTOR")
        Dim UltraDataColumn18 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("AR_UNIDAD")
        Dim UltraDataColumn19 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Sel")
        Dim UltraDataColumn20 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("ME_CODIGO")
        Dim UltraDataColumn21 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("ME_NOMBRES")
        Dim UltraDataColumn22 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("ME_IDEMPRESA")
        Dim UltraDataColumn23 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Precio")
        Dim Appearance28 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance29 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance4 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance30 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance24 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance26 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance27 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance31 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance25 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance18 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance19 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance20 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance21 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraTab1 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Me.UltraTabPageControl1 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.ug_Lista = New Infragistics.Win.UltraWinGrid.UltraGrid()
        Me.uds_Lista_Arti = New Infragistics.Win.UltraWinDataSource.UltraDataSource(Me.components)
        Me.uds_ListaME = New Infragistics.Win.UltraWinDataSource.UltraDataSource(Me.components)
        Me.UltraTabPageControl3 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.UltraGroupBox1 = New Infragistics.Win.Misc.UltraGroupBox()
        Me.ume_cant_um_compra = New Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit()
        Me.UltraMaskedEdit1 = New Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit()
        Me.UltraColorPicker1 = New Infragistics.Win.UltraWinEditors.UltraColorPicker()
        Me.une_stock_min = New Infragistics.Win.UltraWinEditors.UltraNumericEditor()
        Me.txt_des_prove = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.txt_idprove = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.UltraTextEditor2 = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.uce_um_distri = New Infragistics.Win.UltraWinEditors.UltraComboEditor()
        Me.uce_um_venta = New Infragistics.Win.UltraWinEditors.UltraComboEditor()
        Me.uce_fabricante = New Infragistics.Win.UltraWinEditors.UltraComboEditor()
        Me.uce_marca = New Infragistics.Win.UltraWinEditors.UltraComboEditor()
        Me.uce_pais = New Infragistics.Win.UltraWinEditors.UltraComboEditor()
        Me.uce_um_peso = New Infragistics.Win.UltraWinEditors.UltraComboEditor()
        Me.uce_um_compra = New Infragistics.Win.UltraWinEditors.UltraComboEditor()
        Me.uce_Ubicaciones = New Infragistics.Win.UltraWinEditors.UltraComboEditor()
        Me.uce_GrupoArt = New Infragistics.Win.UltraWinEditors.UltraComboEditor()
        Me.UltraLabel24 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraLabel26 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraLabel23 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraLabel18 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraLabel21 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraLabel20 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraLabel17 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraLabel25 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraLabel16 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraLabel15 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraLabel14 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraLabel13 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraLabel12 = New Infragistics.Win.Misc.UltraLabel()
        Me.utc_TipoAne = New Infragistics.Win.UltraWinTabControl.UltraTabControl()
        Me.UltraTabSharedControlsPage1 = New Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage()
        Me.UltraTabPageControl1.SuspendLayout()
        CType(Me.ug_Lista, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.uds_Lista_Arti, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.uds_ListaME, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabPageControl3.SuspendLayout()
        CType(Me.UltraGroupBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraGroupBox1.SuspendLayout()
        CType(Me.UltraColorPicker1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.une_stock_min, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_des_prove, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_idprove, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UltraTextEditor2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.uce_um_distri, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.uce_um_venta, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.uce_fabricante, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.uce_marca, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.uce_pais, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.uce_um_peso, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.uce_um_compra, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.uce_Ubicaciones, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.uce_GrupoArt, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.utc_TipoAne, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.utc_TipoAne.SuspendLayout()
        Me.SuspendLayout()
        '
        'UltraTabPageControl1
        '
        Me.UltraTabPageControl1.Controls.Add(Me.ug_Lista)
        Me.UltraTabPageControl1.Location = New System.Drawing.Point(1, 23)
        Me.UltraTabPageControl1.Name = "UltraTabPageControl1"
        Me.UltraTabPageControl1.Size = New System.Drawing.Size(712, 416)
        '
        'ug_Lista
        '
        Me.ug_Lista.DataSource = Me.uds_Lista_Arti
        Me.ug_Lista.DisplayLayout.AutoFitStyle = Infragistics.Win.UltraWinGrid.AutoFitStyle.ExtendLastColumn
        UltraGridColumn1.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn1.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn1.Header.Caption = "ID"
        UltraGridColumn1.Header.VisiblePosition = 0
        UltraGridColumn1.Hidden = True
        UltraGridColumn2.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn2.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn2.Header.Caption = "CODIGO"
        UltraGridColumn2.Header.VisiblePosition = 1
        UltraGridColumn2.Width = 71
        UltraGridColumn3.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn3.Header.VisiblePosition = 2
        UltraGridColumn3.Hidden = True
        UltraGridColumn3.Width = 58
        UltraGridColumn4.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn4.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn4.Header.Caption = "DESCRIPCION"
        UltraGridColumn4.Header.VisiblePosition = 3
        UltraGridColumn4.Width = 380
        UltraGridColumn5.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn5.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        Appearance1.TextHAlignAsString = "Right"
        UltraGridColumn5.CellAppearance = Appearance1
        UltraGridColumn5.Header.Caption = "PRECIO"
        UltraGridColumn5.Header.VisiblePosition = 8
        UltraGridColumn5.MaskDisplayMode = Infragistics.Win.UltraWinMaskedEdit.MaskMode.IncludeLiterals
        UltraGridColumn5.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Double]
        UltraGridColumn5.Width = 80
        UltraGridColumn6.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn6.Header.VisiblePosition = 5
        UltraGridColumn6.Hidden = True
        UltraGridColumn7.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn7.Header.Caption = "FAMILIA"
        UltraGridColumn7.Header.VisiblePosition = 4
        UltraGridColumn7.Hidden = True
        UltraGridColumn7.Width = 148
        UltraGridColumn8.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn8.Header.VisiblePosition = 6
        UltraGridColumn8.Hidden = True
        UltraGridColumn9.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn9.Header.Caption = "CATEGORIA"
        UltraGridColumn9.Header.VisiblePosition = 7
        UltraGridColumn9.Hidden = True
        UltraGridColumn9.Width = 132
        UltraGridColumn10.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn10.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        Appearance2.TextHAlignAsString = "Center"
        UltraGridColumn10.CellAppearance = Appearance2
        UltraGridColumn10.Header.Caption = "CTA CONTA"
        UltraGridColumn10.Header.VisiblePosition = 10
        UltraGridColumn10.Width = 73
        UltraGridColumn11.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn11.Header.VisiblePosition = 11
        UltraGridColumn11.Hidden = True
        UltraGridColumn11.Width = 42
        UltraGridColumn12.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn12.Header.VisiblePosition = 12
        UltraGridColumn12.Hidden = True
        UltraGridColumn12.Width = 28
        UltraGridColumn13.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn13.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn13.Header.Caption = "INC. IGV"
        UltraGridColumn13.Header.VisiblePosition = 9
        UltraGridColumn13.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.CheckBox
        UltraGridColumn13.Width = 55
        UltraGridColumn14.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn14.Header.VisiblePosition = 13
        UltraGridColumn14.Hidden = True
        UltraGridColumn15.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn15.Header.VisiblePosition = 14
        UltraGridColumn15.Hidden = True
        UltraGridColumn16.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn16.Header.VisiblePosition = 15
        UltraGridColumn16.Hidden = True
        UltraGridColumn17.Header.VisiblePosition = 16
        UltraGridColumn17.Hidden = True
        UltraGridColumn18.Header.VisiblePosition = 17
        UltraGridColumn18.Hidden = True
        UltraGridBand1.Columns.AddRange(New Object() {UltraGridColumn1, UltraGridColumn2, UltraGridColumn3, UltraGridColumn4, UltraGridColumn5, UltraGridColumn6, UltraGridColumn7, UltraGridColumn8, UltraGridColumn9, UltraGridColumn10, UltraGridColumn11, UltraGridColumn12, UltraGridColumn13, UltraGridColumn14, UltraGridColumn15, UltraGridColumn16, UltraGridColumn17, UltraGridColumn18})
        Me.ug_Lista.DisplayLayout.BandsSerializer.Add(UltraGridBand1)
        Me.ug_Lista.DisplayLayout.MaxColScrollRegions = 1
        Me.ug_Lista.DisplayLayout.MaxRowScrollRegions = 1
        Me.ug_Lista.DisplayLayout.Override.AllowDelete = Infragistics.Win.DefaultableBoolean.[False]
        Me.ug_Lista.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.[False]
        Me.ug_Lista.DisplayLayout.Override.FilterUIType = Infragistics.Win.UltraWinGrid.FilterUIType.FilterRow
        Me.ug_Lista.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Appearance35.BackColor = System.Drawing.Color.WhiteSmoke
        Appearance35.BackColor2 = System.Drawing.Color.WhiteSmoke
        Me.ug_Lista.DisplayLayout.Override.RowAlternateAppearance = Appearance35
        Me.ug_Lista.DisplayLayout.Override.SelectTypeRow = Infragistics.Win.UltraWinGrid.SelectType.[Single]
        Me.ug_Lista.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.ug_Lista.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.ug_Lista.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ug_Lista.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ug_Lista.Location = New System.Drawing.Point(0, 0)
        Me.ug_Lista.Name = "ug_Lista"
        Me.ug_Lista.Size = New System.Drawing.Size(712, 416)
        Me.ug_Lista.TabIndex = 0
        '
        'uds_Lista_Arti
        '
        Me.uds_Lista_Arti.AllowDelete = False
        UltraDataColumn1.DataType = GetType(Integer)
        UltraDataColumn5.DataType = GetType(Double)
        UltraDataColumn11.DataType = GetType(Boolean)
        UltraDataColumn13.DataType = GetType(Short)
        UltraDataColumn14.DataType = GetType(Short)
        UltraDataColumn16.DataType = GetType(Short)
        UltraDataColumn17.DataType = GetType(Integer)
        UltraDataColumn18.DataType = GetType(Double)
        Me.uds_Lista_Arti.Band.Columns.AddRange(New Object() {UltraDataColumn1, UltraDataColumn2, UltraDataColumn3, UltraDataColumn4, UltraDataColumn5, UltraDataColumn6, UltraDataColumn7, UltraDataColumn8, UltraDataColumn9, UltraDataColumn10, UltraDataColumn11, UltraDataColumn12, UltraDataColumn13, UltraDataColumn14, UltraDataColumn15, UltraDataColumn16, UltraDataColumn17, UltraDataColumn18})
        '
        'uds_ListaME
        '
        Me.uds_ListaME.AllowDelete = False
        UltraDataColumn19.DataType = GetType(Boolean)
        UltraDataColumn22.DataType = GetType(Integer)
        UltraDataColumn23.DataType = GetType(Decimal)
        Me.uds_ListaME.Band.Columns.AddRange(New Object() {UltraDataColumn19, UltraDataColumn20, UltraDataColumn21, UltraDataColumn22, UltraDataColumn23})
        '
        'UltraTabPageControl3
        '
        Me.UltraTabPageControl3.Controls.Add(Me.UltraGroupBox1)
        Me.UltraTabPageControl3.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl3.Name = "UltraTabPageControl3"
        Me.UltraTabPageControl3.Size = New System.Drawing.Size(649, 287)
        '
        'UltraGroupBox1
        '
        Me.UltraGroupBox1.Controls.Add(Me.ume_cant_um_compra)
        Me.UltraGroupBox1.Controls.Add(Me.UltraMaskedEdit1)
        Me.UltraGroupBox1.Controls.Add(Me.UltraColorPicker1)
        Me.UltraGroupBox1.Controls.Add(Me.une_stock_min)
        Me.UltraGroupBox1.Controls.Add(Me.txt_des_prove)
        Me.UltraGroupBox1.Controls.Add(Me.txt_idprove)
        Me.UltraGroupBox1.Controls.Add(Me.UltraTextEditor2)
        Me.UltraGroupBox1.Controls.Add(Me.uce_um_distri)
        Me.UltraGroupBox1.Controls.Add(Me.uce_um_venta)
        Me.UltraGroupBox1.Controls.Add(Me.uce_fabricante)
        Me.UltraGroupBox1.Controls.Add(Me.uce_marca)
        Me.UltraGroupBox1.Controls.Add(Me.uce_pais)
        Me.UltraGroupBox1.Controls.Add(Me.uce_um_peso)
        Me.UltraGroupBox1.Controls.Add(Me.uce_um_compra)
        Me.UltraGroupBox1.Controls.Add(Me.uce_Ubicaciones)
        Me.UltraGroupBox1.Controls.Add(Me.uce_GrupoArt)
        Me.UltraGroupBox1.Controls.Add(Me.UltraLabel24)
        Me.UltraGroupBox1.Controls.Add(Me.UltraLabel26)
        Me.UltraGroupBox1.Controls.Add(Me.UltraLabel23)
        Me.UltraGroupBox1.Controls.Add(Me.UltraLabel18)
        Me.UltraGroupBox1.Controls.Add(Me.UltraLabel21)
        Me.UltraGroupBox1.Controls.Add(Me.UltraLabel20)
        Me.UltraGroupBox1.Controls.Add(Me.UltraLabel17)
        Me.UltraGroupBox1.Controls.Add(Me.UltraLabel25)
        Me.UltraGroupBox1.Controls.Add(Me.UltraLabel16)
        Me.UltraGroupBox1.Controls.Add(Me.UltraLabel15)
        Me.UltraGroupBox1.Controls.Add(Me.UltraLabel14)
        Me.UltraGroupBox1.Controls.Add(Me.UltraLabel13)
        Me.UltraGroupBox1.Controls.Add(Me.UltraLabel12)
        Me.UltraGroupBox1.Location = New System.Drawing.Point(7, 7)
        Me.UltraGroupBox1.Name = "UltraGroupBox1"
        Me.UltraGroupBox1.Size = New System.Drawing.Size(633, 274)
        Me.UltraGroupBox1.TabIndex = 0
        '
        'ume_cant_um_compra
        '
        Me.ume_cant_um_compra.EditAs = Infragistics.Win.UltraWinMaskedEdit.EditAsType.UseSpecifiedMask
        Me.ume_cant_um_compra.InputMask = "{double:3.2}"
        Me.ume_cant_um_compra.Location = New System.Drawing.Point(227, 122)
        Me.ume_cant_um_compra.Name = "ume_cant_um_compra"
        Me.ume_cant_um_compra.Size = New System.Drawing.Size(50, 20)
        Me.ume_cant_um_compra.TabIndex = 12
        Me.ume_cant_um_compra.Text = "UltraMaskedEdit1"
        '
        'UltraMaskedEdit1
        '
        Me.UltraMaskedEdit1.EditAs = Infragistics.Win.UltraWinMaskedEdit.EditAsType.UseSpecifiedMask
        Me.UltraMaskedEdit1.InputMask = "{double:3.2}"
        Me.UltraMaskedEdit1.Location = New System.Drawing.Point(428, 149)
        Me.UltraMaskedEdit1.Name = "UltraMaskedEdit1"
        Me.UltraMaskedEdit1.Size = New System.Drawing.Size(74, 20)
        Me.UltraMaskedEdit1.TabIndex = 12
        Me.UltraMaskedEdit1.Text = "UltraMaskedEdit1"
        '
        'UltraColorPicker1
        '
        Me.UltraColorPicker1.Location = New System.Drawing.Point(428, 122)
        Me.UltraColorPicker1.Name = "UltraColorPicker1"
        Me.UltraColorPicker1.Size = New System.Drawing.Size(190, 21)
        Me.UltraColorPicker1.TabIndex = 11
        Me.UltraColorPicker1.Text = "Control"
        '
        'une_stock_min
        '
        Me.une_stock_min.Location = New System.Drawing.Point(428, 177)
        Me.une_stock_min.MaskInput = "nnnn"
        Me.une_stock_min.Name = "une_stock_min"
        Me.une_stock_min.Size = New System.Drawing.Size(74, 21)
        Me.une_stock_min.TabIndex = 10
        '
        'txt_des_prove
        '
        Me.txt_des_prove.Location = New System.Drawing.Point(170, 10)
        Me.txt_des_prove.MaxLength = 10
        Me.txt_des_prove.Name = "txt_des_prove"
        Me.txt_des_prove.ReadOnly = True
        Me.txt_des_prove.Size = New System.Drawing.Size(446, 21)
        Me.txt_des_prove.TabIndex = 9
        '
        'txt_idprove
        '
        Me.txt_idprove.Location = New System.Drawing.Point(91, 10)
        Me.txt_idprove.MaxLength = 10
        Me.txt_idprove.Name = "txt_idprove"
        Me.txt_idprove.Size = New System.Drawing.Size(79, 21)
        Me.txt_idprove.TabIndex = 9
        '
        'UltraTextEditor2
        '
        Me.UltraTextEditor2.Location = New System.Drawing.Point(428, 65)
        Me.UltraTextEditor2.MaxLength = 10
        Me.UltraTextEditor2.Name = "UltraTextEditor2"
        Me.UltraTextEditor2.Size = New System.Drawing.Size(190, 21)
        Me.UltraTextEditor2.TabIndex = 9
        '
        'uce_um_distri
        '
        Me.uce_um_distri.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.uce_um_distri.Location = New System.Drawing.Point(107, 177)
        Me.uce_um_distri.Name = "uce_um_distri"
        Me.uce_um_distri.Size = New System.Drawing.Size(170, 21)
        Me.uce_um_distri.TabIndex = 6
        '
        'uce_um_venta
        '
        Me.uce_um_venta.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.uce_um_venta.Location = New System.Drawing.Point(107, 149)
        Me.uce_um_venta.Name = "uce_um_venta"
        Me.uce_um_venta.Size = New System.Drawing.Size(170, 21)
        Me.uce_um_venta.TabIndex = 6
        '
        'uce_fabricante
        '
        Me.uce_fabricante.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.uce_fabricante.Location = New System.Drawing.Point(428, 38)
        Me.uce_fabricante.Name = "uce_fabricante"
        Me.uce_fabricante.Size = New System.Drawing.Size(190, 21)
        Me.uce_fabricante.TabIndex = 6
        '
        'uce_marca
        '
        Me.uce_marca.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.uce_marca.Location = New System.Drawing.Point(428, 92)
        Me.uce_marca.Name = "uce_marca"
        Me.uce_marca.Size = New System.Drawing.Size(190, 21)
        Me.uce_marca.TabIndex = 6
        '
        'uce_pais
        '
        Me.uce_pais.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.uce_pais.Location = New System.Drawing.Point(93, 92)
        Me.uce_pais.Name = "uce_pais"
        Me.uce_pais.Size = New System.Drawing.Size(184, 21)
        Me.uce_pais.TabIndex = 6
        '
        'uce_um_peso
        '
        Me.uce_um_peso.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.uce_um_peso.Location = New System.Drawing.Point(502, 149)
        Me.uce_um_peso.Name = "uce_um_peso"
        Me.uce_um_peso.Size = New System.Drawing.Size(116, 21)
        Me.uce_um_peso.TabIndex = 6
        '
        'uce_um_compra
        '
        Me.uce_um_compra.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.uce_um_compra.Location = New System.Drawing.Point(107, 122)
        Me.uce_um_compra.Name = "uce_um_compra"
        Me.uce_um_compra.Size = New System.Drawing.Size(119, 21)
        Me.uce_um_compra.TabIndex = 6
        '
        'uce_Ubicaciones
        '
        Me.uce_Ubicaciones.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.uce_Ubicaciones.Location = New System.Drawing.Point(93, 65)
        Me.uce_Ubicaciones.Name = "uce_Ubicaciones"
        Me.uce_Ubicaciones.Size = New System.Drawing.Size(184, 21)
        Me.uce_Ubicaciones.TabIndex = 6
        '
        'uce_GrupoArt
        '
        Me.uce_GrupoArt.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.uce_GrupoArt.Location = New System.Drawing.Point(93, 38)
        Me.uce_GrupoArt.Name = "uce_GrupoArt"
        Me.uce_GrupoArt.Size = New System.Drawing.Size(184, 21)
        Me.uce_GrupoArt.TabIndex = 6
        '
        'UltraLabel24
        '
        Appearance28.BackColor = System.Drawing.Color.Transparent
        Appearance28.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel24.Appearance = Appearance28
        Me.UltraLabel24.AutoSize = True
        Me.UltraLabel24.Location = New System.Drawing.Point(26, 96)
        Me.UltraLabel24.Name = "UltraLabel24"
        Me.UltraLabel24.Size = New System.Drawing.Size(26, 14)
        Me.UltraLabel24.TabIndex = 4
        Me.UltraLabel24.Text = "Pais"
        '
        'UltraLabel26
        '
        Appearance29.BackColor = System.Drawing.Color.Transparent
        Appearance29.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel26.Appearance = Appearance29
        Me.UltraLabel26.AutoSize = True
        Me.UltraLabel26.Location = New System.Drawing.Point(323, 184)
        Me.UltraLabel26.Name = "UltraLabel26"
        Me.UltraLabel26.Size = New System.Drawing.Size(72, 14)
        Me.UltraLabel26.TabIndex = 4
        Me.UltraLabel26.Text = "Stock Minimo"
        '
        'UltraLabel23
        '
        Appearance4.BackColor = System.Drawing.Color.Transparent
        Appearance4.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel23.Appearance = Appearance4
        Me.UltraLabel23.AutoSize = True
        Me.UltraLabel23.Location = New System.Drawing.Point(323, 126)
        Me.UltraLabel23.Name = "UltraLabel23"
        Me.UltraLabel23.Size = New System.Drawing.Size(31, 14)
        Me.UltraLabel23.TabIndex = 4
        Me.UltraLabel23.Text = "Color"
        '
        'UltraLabel18
        '
        Appearance30.BackColor = System.Drawing.Color.Transparent
        Appearance30.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel18.Appearance = Appearance30
        Me.UltraLabel18.AutoSize = True
        Me.UltraLabel18.Location = New System.Drawing.Point(323, 152)
        Me.UltraLabel18.Name = "UltraLabel18"
        Me.UltraLabel18.Size = New System.Drawing.Size(30, 14)
        Me.UltraLabel18.TabIndex = 4
        Me.UltraLabel18.Text = "Peso"
        '
        'UltraLabel21
        '
        Appearance24.BackColor = System.Drawing.Color.Transparent
        Appearance24.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel21.Appearance = Appearance24
        Me.UltraLabel21.AutoSize = True
        Me.UltraLabel21.Location = New System.Drawing.Point(27, 180)
        Me.UltraLabel21.Name = "UltraLabel21"
        Me.UltraLabel21.Size = New System.Drawing.Size(66, 14)
        Me.UltraLabel21.TabIndex = 4
        Me.UltraLabel21.Text = "U.M. Distrib."
        '
        'UltraLabel20
        '
        Appearance26.BackColor = System.Drawing.Color.Transparent
        Appearance26.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel20.Appearance = Appearance26
        Me.UltraLabel20.AutoSize = True
        Me.UltraLabel20.Location = New System.Drawing.Point(27, 152)
        Me.UltraLabel20.Name = "UltraLabel20"
        Me.UltraLabel20.Size = New System.Drawing.Size(61, 14)
        Me.UltraLabel20.TabIndex = 4
        Me.UltraLabel20.Text = "U.M. Venta"
        '
        'UltraLabel17
        '
        Appearance27.BackColor = System.Drawing.Color.Transparent
        Appearance27.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel17.Appearance = Appearance27
        Me.UltraLabel17.AutoSize = True
        Me.UltraLabel17.Location = New System.Drawing.Point(27, 126)
        Me.UltraLabel17.Name = "UltraLabel17"
        Me.UltraLabel17.Size = New System.Drawing.Size(71, 14)
        Me.UltraLabel17.TabIndex = 4
        Me.UltraLabel17.Text = "U.M. Compra"
        '
        'UltraLabel25
        '
        Appearance31.BackColor = System.Drawing.Color.Transparent
        Appearance31.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel25.Appearance = Appearance31
        Me.UltraLabel25.AutoSize = True
        Me.UltraLabel25.Location = New System.Drawing.Point(26, 69)
        Me.UltraLabel25.Name = "UltraLabel25"
        Me.UltraLabel25.Size = New System.Drawing.Size(54, 14)
        Me.UltraLabel25.TabIndex = 4
        Me.UltraLabel25.Text = "Ubicacion"
        '
        'UltraLabel16
        '
        Appearance25.BackColor = System.Drawing.Color.Transparent
        Appearance25.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel16.Appearance = Appearance25
        Me.UltraLabel16.AutoSize = True
        Me.UltraLabel16.Location = New System.Drawing.Point(26, 42)
        Me.UltraLabel16.Name = "UltraLabel16"
        Me.UltraLabel16.Size = New System.Drawing.Size(36, 14)
        Me.UltraLabel16.TabIndex = 4
        Me.UltraLabel16.Text = "Grupo"
        '
        'UltraLabel15
        '
        Appearance18.BackColor = System.Drawing.Color.Transparent
        Appearance18.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel15.Appearance = Appearance18
        Me.UltraLabel15.AutoSize = True
        Me.UltraLabel15.Location = New System.Drawing.Point(24, 14)
        Me.UltraLabel15.Name = "UltraLabel15"
        Me.UltraLabel15.Size = New System.Drawing.Size(56, 14)
        Me.UltraLabel15.TabIndex = 4
        Me.UltraLabel15.Text = "Proveedor"
        '
        'UltraLabel14
        '
        Appearance19.BackColor = System.Drawing.Color.Transparent
        Appearance19.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel14.Appearance = Appearance19
        Me.UltraLabel14.AutoSize = True
        Me.UltraLabel14.Location = New System.Drawing.Point(323, 94)
        Me.UltraLabel14.Name = "UltraLabel14"
        Me.UltraLabel14.Size = New System.Drawing.Size(36, 14)
        Me.UltraLabel14.TabIndex = 4
        Me.UltraLabel14.Text = "Marca"
        '
        'UltraLabel13
        '
        Appearance20.BackColor = System.Drawing.Color.Transparent
        Appearance20.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel13.Appearance = Appearance20
        Me.UltraLabel13.AutoSize = True
        Me.UltraLabel13.Location = New System.Drawing.Point(323, 69)
        Me.UltraLabel13.Name = "UltraLabel13"
        Me.UltraLabel13.Size = New System.Drawing.Size(41, 14)
        Me.UltraLabel13.TabIndex = 4
        Me.UltraLabel13.Text = "Modelo"
        '
        'UltraLabel12
        '
        Appearance21.BackColor = System.Drawing.Color.Transparent
        Appearance21.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel12.Appearance = Appearance21
        Me.UltraLabel12.AutoSize = True
        Me.UltraLabel12.Location = New System.Drawing.Point(323, 42)
        Me.UltraLabel12.Name = "UltraLabel12"
        Me.UltraLabel12.Size = New System.Drawing.Size(58, 14)
        Me.UltraLabel12.TabIndex = 4
        Me.UltraLabel12.Text = "Fabricante"
        '
        'utc_TipoAne
        '
        Me.utc_TipoAne.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.utc_TipoAne.Controls.Add(Me.UltraTabSharedControlsPage1)
        Me.utc_TipoAne.Controls.Add(Me.UltraTabPageControl1)
        Me.utc_TipoAne.Location = New System.Drawing.Point(2, 2)
        Me.utc_TipoAne.Name = "utc_TipoAne"
        Me.utc_TipoAne.SharedControlsPage = Me.UltraTabSharedControlsPage1
        Me.utc_TipoAne.Size = New System.Drawing.Size(716, 442)
        Me.utc_TipoAne.TabIndex = 8
        UltraTab1.TabPage = Me.UltraTabPageControl1
        UltraTab1.Text = "Lista de Articulos"
        Me.utc_TipoAne.Tabs.AddRange(New Infragistics.Win.UltraWinTabControl.UltraTab() {UltraTab1})
        '
        'UltraTabSharedControlsPage1
        '
        Me.UltraTabSharedControlsPage1.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabSharedControlsPage1.Name = "UltraTabSharedControlsPage1"
        Me.UltraTabSharedControlsPage1.Size = New System.Drawing.Size(712, 416)
        '
        'FA_RE_Articulo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(719, 445)
        Me.Controls.Add(Me.utc_TipoAne)
        Me.Name = "FA_RE_Articulo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Articulos / Servicios"
        Me.UltraTabPageControl1.ResumeLayout(False)
        CType(Me.ug_Lista, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.uds_Lista_Arti, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.uds_ListaME, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabPageControl3.ResumeLayout(False)
        CType(Me.UltraGroupBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraGroupBox1.ResumeLayout(False)
        Me.UltraGroupBox1.PerformLayout()
        CType(Me.UltraColorPicker1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.une_stock_min, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_des_prove, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_idprove, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UltraTextEditor2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.uce_um_distri, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.uce_um_venta, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.uce_fabricante, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.uce_marca, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.uce_pais, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.uce_um_peso, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.uce_um_compra, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.uce_Ubicaciones, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.uce_GrupoArt, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.utc_TipoAne, System.ComponentModel.ISupportInitialize).EndInit()
        Me.utc_TipoAne.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents utc_TipoAne As Infragistics.Win.UltraWinTabControl.UltraTabControl
    Friend WithEvents UltraTabSharedControlsPage1 As Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage
    Friend WithEvents UltraTabPageControl1 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents ug_Lista As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents uds_Lista_Arti As Infragistics.Win.UltraWinDataSource.UltraDataSource
    Friend WithEvents UltraTabPageControl3 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents UltraGroupBox1 As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents txt_des_prove As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents txt_idprove As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents UltraTextEditor2 As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents uce_GrupoArt As Infragistics.Win.UltraWinEditors.UltraComboEditor
    Friend WithEvents UltraLabel16 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel15 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel14 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel13 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel12 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents uce_um_compra As Infragistics.Win.UltraWinEditors.UltraComboEditor
    Friend WithEvents UltraLabel18 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel17 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents une_stock_min As Infragistics.Win.UltraWinEditors.UltraNumericEditor
    Friend WithEvents uce_um_distri As Infragistics.Win.UltraWinEditors.UltraComboEditor
    Friend WithEvents uce_um_venta As Infragistics.Win.UltraWinEditors.UltraComboEditor
    Friend WithEvents UltraLabel21 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel20 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel24 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel23 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraMaskedEdit1 As Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit
    Friend WithEvents UltraColorPicker1 As Infragistics.Win.UltraWinEditors.UltraColorPicker
    Friend WithEvents uce_pais As Infragistics.Win.UltraWinEditors.UltraComboEditor
    Friend WithEvents uce_um_peso As Infragistics.Win.UltraWinEditors.UltraComboEditor
    Friend WithEvents uce_Ubicaciones As Infragistics.Win.UltraWinEditors.UltraComboEditor
    Friend WithEvents UltraLabel25 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents uce_fabricante As Infragistics.Win.UltraWinEditors.UltraComboEditor
    Friend WithEvents uce_marca As Infragistics.Win.UltraWinEditors.UltraComboEditor
    Friend WithEvents UltraLabel26 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents ume_cant_um_compra As Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit
    Friend WithEvents uds_ListaME As Infragistics.Win.UltraWinDataSource.UltraDataSource
End Class
