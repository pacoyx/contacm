<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FA_PR_Mante_Congela_sc
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
        Dim UltraGridColumn1 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ITEM")
        Dim UltraGridColumn2 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("PD_IDCAB")
        Dim UltraGridColumn3 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("PD_ANHO")
        Dim UltraGridColumn4 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("PD_MES")
        Dim UltraGridColumn5 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("PD_FECPAGO")
        Dim UltraGridColumn6 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("PD_IMPORTE")
        Dim UltraGridColumn7 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("PD_IDCOMPROBANTE")
        Dim UltraGridColumn8 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("PD_EST_CUOTA")
        Dim UltraGridColumn9 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("PD_COMENTARIOS")
        Dim UltraGridColumn10 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("PD_IDMONEDA")
        Dim UltraGridColumn11 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("PD_TIPCAM")
        Dim UltraGridColumn12 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("PD_REF")
        Dim UltraGridColumn13 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("PD_MES_DES")
        Dim UltraGridColumn14 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("PD_IDMONEDA_DES")
        Dim UltraDataColumn1 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("ITEM")
        Dim UltraDataColumn2 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("PD_IDCAB")
        Dim UltraDataColumn3 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("PD_ANHO")
        Dim UltraDataColumn4 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("PD_MES")
        Dim UltraDataColumn5 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("PD_FECPAGO")
        Dim UltraDataColumn6 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("PD_IMPORTE")
        Dim UltraDataColumn7 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("PD_IDCOMPROBANTE")
        Dim UltraDataColumn8 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("PD_EST_CUOTA")
        Dim UltraDataColumn9 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("PD_COMENTARIOS")
        Dim UltraDataColumn10 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("PD_IDMONEDA")
        Dim UltraDataColumn11 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("PD_TIPCAM")
        Dim UltraDataColumn12 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("PD_REF")
        Dim UltraDataColumn13 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("PD_MES_DES")
        Dim UltraDataColumn14 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("PD_IDMONEDA_DES")
        Dim Appearance20 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance21 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance6 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance4 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim ValueListItem1 As Infragistics.Win.ValueListItem = New Infragistics.Win.ValueListItem()
        Dim ValueListItem4 As Infragistics.Win.ValueListItem = New Infragistics.Win.ValueListItem()
        Dim Appearance9 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance11 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance44 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance5 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance38 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance7 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance33 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance16 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance10 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridBand2 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1)
        Dim UltraGridColumn15 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("PG_ID")
        Dim UltraGridColumn16 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("PG_FEC_CONGE")
        Dim UltraGridColumn17 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("PG_IDCOMPROBANTE", -1, Nothing, 0, Infragistics.Win.UltraWinGrid.SortIndicator.Ascending, False)
        Dim UltraGridColumn18 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("COMPROBANTE")
        Dim UltraGridColumn19 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("PG_IDCLIENTE")
        Dim UltraGridColumn20 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CL_NOMBRE")
        Dim UltraGridColumn21 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("PG_IDCONGELACION")
        Dim UltraGridColumn22 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TC_DESCRIPCION")
        Dim UltraGridColumn23 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("PG_IDMEDICO")
        Dim UltraGridColumn24 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("MEDICO")
        Dim UltraGridColumn25 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("PG_COMENTARIOS")
        Dim UltraGridColumn26 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("PG_IMPORTE")
        Dim UltraGridColumn27 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("PG_ESTADO")
        Dim UltraGridColumn28 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("PG_REF")
        Dim UltraGridColumn29 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("PG_IDMONEDA")
        Dim UltraGridColumn30 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("PG_TIPCAM")
        Dim Appearance1 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraDataColumn15 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("PG_ID")
        Dim UltraDataColumn16 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("PG_FEC_CONGE")
        Dim UltraDataColumn17 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("PG_IDCOMPROBANTE")
        Dim UltraDataColumn18 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("COMPROBANTE")
        Dim UltraDataColumn19 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("PG_IDCLIENTE")
        Dim UltraDataColumn20 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("CL_NOMBRE")
        Dim UltraDataColumn21 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("PG_IDCONGELACION")
        Dim UltraDataColumn22 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("TC_DESCRIPCION")
        Dim UltraDataColumn23 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("PG_IDMEDICO")
        Dim UltraDataColumn24 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("MEDICO")
        Dim UltraDataColumn25 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("PG_COMENTARIOS")
        Dim UltraDataColumn26 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("PG_IMPORTE")
        Dim UltraDataColumn27 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("PG_ESTADO")
        Dim UltraDataColumn28 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("PG_REF")
        Dim UltraDataColumn29 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("PG_IDMONEDA")
        Dim UltraDataColumn30 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("PG_TIPCAM")
        Dim Appearance22 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance41 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance12 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance13 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance14 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim ValueListItem2 As Infragistics.Win.ValueListItem = New Infragistics.Win.ValueListItem()
        Dim ValueListItem3 As Infragistics.Win.ValueListItem = New Infragistics.Win.ValueListItem()
        Dim Appearance15 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance3 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance34 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance17 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance19 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance18 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim EditorButton1 As Infragistics.Win.UltraWinEditors.EditorButton = New Infragistics.Win.UltraWinEditors.EditorButton("ayuda")
        Dim Appearance111 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance8 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance28 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance2 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraTab3 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraTab4 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim Appearance23 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraTab1 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraTab2 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Me.UltraTabPageControl3 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.ug_detalle = New Infragistics.Win.UltraWinGrid.UltraGrid()
        Me.uds_Detalle = New Infragistics.Win.UltraWinDataSource.UltraDataSource(Me.components)
        Me.UltraTabPageControl4 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.ugb_detalle = New Infragistics.Win.Misc.UltraGroupBox()
        Me.txt_idcompro_det = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.btn_cancelar = New Infragistics.Win.Misc.UltraButton()
        Me.btn_Aceptar = New Infragistics.Win.Misc.UltraButton()
        Me.txt_ref_det = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.UltraLabel18 = New Infragistics.Win.Misc.UltraLabel()
        Me.txt_comen_det = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.UltraLabel17 = New Infragistics.Win.Misc.UltraLabel()
        Me.uce_estado_det = New Infragistics.Win.UltraWinEditors.UltraComboEditor()
        Me.UltraLabel16 = New Infragistics.Win.Misc.UltraLabel()
        Me.ume_importe_det = New Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit()
        Me.uce_ayo = New Infragistics.Win.UltraWinEditors.UltraComboEditor()
        Me.udte_fec_pago = New Infragistics.Win.UltraWinEditors.UltraDateTimeEditor()
        Me.ume_tc_det = New Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit()
        Me.UltraLabel14 = New Infragistics.Win.Misc.UltraLabel()
        Me.uce_moneda_det = New Infragistics.Win.UltraWinEditors.UltraComboEditor()
        Me.UltraLabel15 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraLabel13 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraLabel12 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraLabel11 = New Infragistics.Win.Misc.UltraLabel()
        Me.uce_mes = New Infragistics.Win.UltraWinEditors.UltraComboEditor()
        Me.UltraLabel10 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraTabPageControl1 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.ug_Lista = New Infragistics.Win.UltraWinGrid.UltraGrid()
        Me.uds_congelaciones = New Infragistics.Win.UltraWinDataSource.UltraDataSource(Me.components)
        Me.UltraTabPageControl2 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.ugb_datos = New Infragistics.Win.Misc.UltraGroupBox()
        Me.btn_quitar = New Infragistics.Win.Misc.UltraButton()
        Me.UltraGroupBox1 = New Infragistics.Win.Misc.UltraGroupBox()
        Me.uce_tipoconge = New Infragistics.Win.UltraWinEditors.UltraComboEditor()
        Me.UltraLabel19 = New Infragistics.Win.Misc.UltraLabel()
        Me.ume_ValorTipoCambio = New Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit()
        Me.UltraLabel4 = New Infragistics.Win.Misc.UltraLabel()
        Me.uce_Moneda = New Infragistics.Win.UltraWinEditors.UltraComboEditor()
        Me.UltraLabel8 = New Infragistics.Win.Misc.UltraLabel()
        Me.txt_idcompro = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.txt_ref = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.uos_estado = New Infragistics.Win.UltraWinEditors.UltraOptionSet()
        Me.ume_total = New Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit()
        Me.UltraLabel32 = New Infragistics.Win.Misc.UltraLabel()
        Me.txt_notas = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.UltraLabel3 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraLabel7 = New Infragistics.Win.Misc.UltraLabel()
        Me.uce_Medico = New Infragistics.Win.UltraWinEditors.UltraComboEditor()
        Me.UltraLabel2 = New Infragistics.Win.Misc.UltraLabel()
        Me.txt_idconge = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.UltraLabel9 = New Infragistics.Win.Misc.UltraLabel()
        Me.txt_IdCliente = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.txt_Des_Cliente = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.txt_ruc_cliente = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.UltraLabel5 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraLabel1 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraLabel6 = New Infragistics.Win.Misc.UltraLabel()
        Me.udte_fec_conge = New Infragistics.Win.UltraWinEditors.UltraDateTimeEditor()
        Me.utc_Detalle = New Infragistics.Win.UltraWinTabControl.UltraTabControl()
        Me.UltraTabSharedControlsPage2 = New Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage()
        Me.btn_nuevo_det = New Infragistics.Win.Misc.UltraButton()
        Me.ToolS_Mantenimiento = New System.Windows.Forms.ToolStrip()
        Me.Tool_Nuevo = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.Tool_Grabar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.Tool_Editar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.Tool_Cancelar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.Tool_Eliminar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator()
        Me.Tool_Salir = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator6 = New System.Windows.Forms.ToolStripSeparator()
        Me.utc_congela = New Infragistics.Win.UltraWinTabControl.UltraTabControl()
        Me.UltraTabSharedControlsPage1 = New Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage()
        Me.UltraTabPageControl3.SuspendLayout()
        CType(Me.ug_detalle, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.uds_Detalle, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabPageControl4.SuspendLayout()
        CType(Me.ugb_detalle, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ugb_detalle.SuspendLayout()
        CType(Me.txt_idcompro_det, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_ref_det, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_comen_det, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.uce_estado_det, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.uce_ayo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.udte_fec_pago, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.uce_moneda_det, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.uce_mes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabPageControl1.SuspendLayout()
        CType(Me.ug_Lista, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.uds_congelaciones, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabPageControl2.SuspendLayout()
        CType(Me.ugb_datos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ugb_datos.SuspendLayout()
        CType(Me.UltraGroupBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraGroupBox1.SuspendLayout()
        CType(Me.uce_tipoconge, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.uce_Moneda, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_idcompro, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_ref, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.uos_estado, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_notas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.uce_Medico, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_idconge, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_IdCliente, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_Des_Cliente, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_ruc_cliente, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.udte_fec_conge, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.utc_Detalle, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.utc_Detalle.SuspendLayout()
        Me.ToolS_Mantenimiento.SuspendLayout()
        CType(Me.utc_congela, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.utc_congela.SuspendLayout()
        Me.SuspendLayout()
        '
        'UltraTabPageControl3
        '
        Me.UltraTabPageControl3.Controls.Add(Me.ug_detalle)
        Me.UltraTabPageControl3.Location = New System.Drawing.Point(1, 23)
        Me.UltraTabPageControl3.Name = "UltraTabPageControl3"
        Me.UltraTabPageControl3.Size = New System.Drawing.Size(978, 231)
        '
        'ug_detalle
        '
        Me.ug_detalle.DataSource = Me.uds_Detalle
        Me.ug_detalle.DisplayLayout.AutoFitStyle = Infragistics.Win.UltraWinGrid.AutoFitStyle.ExtendLastColumn
        UltraGridColumn1.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn1.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn1.Header.Caption = "Item"
        UltraGridColumn1.Header.VisiblePosition = 1
        UltraGridColumn1.Width = 37
        UltraGridColumn2.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn2.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn2.Header.VisiblePosition = 0
        UltraGridColumn2.Hidden = True
        UltraGridColumn2.Width = 32
        UltraGridColumn3.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn3.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn3.Header.Caption = "Año"
        UltraGridColumn3.Header.VisiblePosition = 2
        UltraGridColumn3.Width = 45
        UltraGridColumn4.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn4.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn4.Header.VisiblePosition = 3
        UltraGridColumn4.Hidden = True
        UltraGridColumn5.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn5.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn5.Header.Caption = "Fec. Pago"
        UltraGridColumn5.Header.VisiblePosition = 5
        UltraGridColumn5.Width = 70
        UltraGridColumn6.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn6.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn6.Header.Caption = "Importe"
        UltraGridColumn6.Header.VisiblePosition = 6
        UltraGridColumn6.MaskDisplayMode = Infragistics.Win.UltraWinMaskedEdit.MaskMode.IncludeLiterals
        UltraGridColumn6.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Double]
        UltraGridColumn7.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn7.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn7.Header.VisiblePosition = 7
        UltraGridColumn7.Hidden = True
        UltraGridColumn8.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn8.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn8.Header.Caption = "Estado"
        UltraGridColumn8.Header.VisiblePosition = 10
        UltraGridColumn9.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn9.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn9.Header.Caption = "Comentarios"
        UltraGridColumn9.Header.VisiblePosition = 12
        UltraGridColumn10.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn10.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn10.Header.VisiblePosition = 13
        UltraGridColumn10.Hidden = True
        UltraGridColumn11.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn11.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn11.Header.Caption = "T.C."
        UltraGridColumn11.Header.VisiblePosition = 9
        UltraGridColumn11.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Double]
        UltraGridColumn11.Width = 50
        UltraGridColumn12.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn12.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn12.Header.Caption = "Referencia"
        UltraGridColumn12.Header.VisiblePosition = 11
        UltraGridColumn12.Width = 122
        UltraGridColumn13.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn13.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn13.Header.Caption = "Mes"
        UltraGridColumn13.Header.VisiblePosition = 4
        UltraGridColumn14.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn14.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn14.Header.Caption = "Mon."
        UltraGridColumn14.Header.VisiblePosition = 8
        UltraGridColumn14.Width = 37
        UltraGridBand1.Columns.AddRange(New Object() {UltraGridColumn1, UltraGridColumn2, UltraGridColumn3, UltraGridColumn4, UltraGridColumn5, UltraGridColumn6, UltraGridColumn7, UltraGridColumn8, UltraGridColumn9, UltraGridColumn10, UltraGridColumn11, UltraGridColumn12, UltraGridColumn13, UltraGridColumn14})
        Me.ug_detalle.DisplayLayout.BandsSerializer.Add(UltraGridBand1)
        Me.ug_detalle.DisplayLayout.GroupByBox.Hidden = True
        Me.ug_detalle.DisplayLayout.MaxColScrollRegions = 1
        Me.ug_detalle.DisplayLayout.MaxRowScrollRegions = 1
        Me.ug_detalle.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        Me.ug_detalle.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Me.ug_detalle.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.ug_detalle.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.ug_detalle.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ug_detalle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ug_detalle.Location = New System.Drawing.Point(0, 0)
        Me.ug_detalle.Name = "ug_detalle"
        Me.ug_detalle.Size = New System.Drawing.Size(978, 231)
        Me.ug_detalle.TabIndex = 0
        '
        'uds_Detalle
        '
        UltraDataColumn1.DataType = GetType(Short)
        UltraDataColumn2.DataType = GetType(Long)
        UltraDataColumn3.DataType = GetType(Integer)
        UltraDataColumn4.DataType = GetType(Short)
        UltraDataColumn5.DataType = GetType(Date)
        UltraDataColumn6.DataType = GetType(Double)
        UltraDataColumn11.DataType = GetType(Double)
        Me.uds_Detalle.Band.Columns.AddRange(New Object() {UltraDataColumn1, UltraDataColumn2, UltraDataColumn3, UltraDataColumn4, UltraDataColumn5, UltraDataColumn6, UltraDataColumn7, UltraDataColumn8, UltraDataColumn9, UltraDataColumn10, UltraDataColumn11, UltraDataColumn12, UltraDataColumn13, UltraDataColumn14})
        '
        'UltraTabPageControl4
        '
        Me.UltraTabPageControl4.Controls.Add(Me.ugb_detalle)
        Me.UltraTabPageControl4.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl4.Name = "UltraTabPageControl4"
        Me.UltraTabPageControl4.Size = New System.Drawing.Size(978, 231)
        '
        'ugb_detalle
        '
        Me.ugb_detalle.Controls.Add(Me.txt_idcompro_det)
        Me.ugb_detalle.Controls.Add(Me.btn_cancelar)
        Me.ugb_detalle.Controls.Add(Me.btn_Aceptar)
        Me.ugb_detalle.Controls.Add(Me.txt_ref_det)
        Me.ugb_detalle.Controls.Add(Me.UltraLabel18)
        Me.ugb_detalle.Controls.Add(Me.txt_comen_det)
        Me.ugb_detalle.Controls.Add(Me.UltraLabel17)
        Me.ugb_detalle.Controls.Add(Me.uce_estado_det)
        Me.ugb_detalle.Controls.Add(Me.UltraLabel16)
        Me.ugb_detalle.Controls.Add(Me.ume_importe_det)
        Me.ugb_detalle.Controls.Add(Me.uce_ayo)
        Me.ugb_detalle.Controls.Add(Me.udte_fec_pago)
        Me.ugb_detalle.Controls.Add(Me.ume_tc_det)
        Me.ugb_detalle.Controls.Add(Me.UltraLabel14)
        Me.ugb_detalle.Controls.Add(Me.uce_moneda_det)
        Me.ugb_detalle.Controls.Add(Me.UltraLabel15)
        Me.ugb_detalle.Controls.Add(Me.UltraLabel13)
        Me.ugb_detalle.Controls.Add(Me.UltraLabel12)
        Me.ugb_detalle.Controls.Add(Me.UltraLabel11)
        Me.ugb_detalle.Controls.Add(Me.uce_mes)
        Me.ugb_detalle.Controls.Add(Me.UltraLabel10)
        Me.ugb_detalle.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ugb_detalle.Location = New System.Drawing.Point(0, 0)
        Me.ugb_detalle.Name = "ugb_detalle"
        Me.ugb_detalle.Size = New System.Drawing.Size(978, 231)
        Me.ugb_detalle.TabIndex = 149
        '
        'txt_idcompro_det
        '
        Me.txt_idcompro_det.Location = New System.Drawing.Point(522, 15)
        Me.txt_idcompro_det.Name = "txt_idcompro_det"
        Me.txt_idcompro_det.ReadOnly = True
        Me.txt_idcompro_det.Size = New System.Drawing.Size(62, 21)
        Me.txt_idcompro_det.TabIndex = 191
        '
        'btn_cancelar
        '
        Appearance20.ImageHAlign = Infragistics.Win.HAlign.Left
        Me.btn_cancelar.Appearance = Appearance20
        Me.btn_cancelar.Location = New System.Drawing.Point(644, 176)
        Me.btn_cancelar.Name = "btn_cancelar"
        Me.btn_cancelar.Size = New System.Drawing.Size(105, 33)
        Me.btn_cancelar.TabIndex = 10
        Me.btn_cancelar.Text = "Cancelar"
        '
        'btn_Aceptar
        '
        Appearance21.ImageHAlign = Infragistics.Win.HAlign.Left
        Me.btn_Aceptar.Appearance = Appearance21
        Me.btn_Aceptar.Location = New System.Drawing.Point(533, 176)
        Me.btn_Aceptar.Name = "btn_Aceptar"
        Me.btn_Aceptar.Size = New System.Drawing.Size(105, 33)
        Me.btn_Aceptar.TabIndex = 9
        Me.btn_Aceptar.Text = "Aceptar"
        '
        'txt_ref_det
        '
        Me.txt_ref_det.Location = New System.Drawing.Point(83, 152)
        Me.txt_ref_det.Name = "txt_ref_det"
        Me.txt_ref_det.Size = New System.Drawing.Size(433, 21)
        Me.txt_ref_det.TabIndex = 5
        '
        'UltraLabel18
        '
        Appearance6.BackColor = System.Drawing.Color.Transparent
        Appearance6.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel18.Appearance = Appearance6
        Me.UltraLabel18.AutoSize = True
        Me.UltraLabel18.Location = New System.Drawing.Point(19, 156)
        Me.UltraLabel18.Name = "UltraLabel18"
        Me.UltraLabel18.Size = New System.Drawing.Size(59, 14)
        Me.UltraLabel18.TabIndex = 187
        Me.UltraLabel18.Text = "Referencia"
        '
        'txt_comen_det
        '
        Me.txt_comen_det.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_comen_det.Location = New System.Drawing.Point(83, 186)
        Me.txt_comen_det.MaxLength = 250
        Me.txt_comen_det.Name = "txt_comen_det"
        Me.txt_comen_det.Size = New System.Drawing.Size(433, 21)
        Me.txt_comen_det.TabIndex = 6
        '
        'UltraLabel17
        '
        Appearance4.BackColor = System.Drawing.Color.Transparent
        Appearance4.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel17.Appearance = Appearance4
        Me.UltraLabel17.AutoSize = True
        Me.UltraLabel17.Location = New System.Drawing.Point(10, 190)
        Me.UltraLabel17.Name = "UltraLabel17"
        Me.UltraLabel17.Size = New System.Drawing.Size(68, 14)
        Me.UltraLabel17.TabIndex = 186
        Me.UltraLabel17.Text = "Comentarios"
        '
        'uce_estado_det
        '
        Me.uce_estado_det.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        ValueListItem1.DataValue = CType(1, Short)
        ValueListItem1.DisplayText = "CANCELADO"
        ValueListItem4.DataValue = CType(2, Short)
        ValueListItem4.DisplayText = "PENDIENTE"
        Me.uce_estado_det.Items.AddRange(New Infragistics.Win.ValueListItem() {ValueListItem1, ValueListItem4})
        Me.uce_estado_det.Location = New System.Drawing.Point(360, 15)
        Me.uce_estado_det.Name = "uce_estado_det"
        Me.uce_estado_det.Size = New System.Drawing.Size(156, 21)
        Me.uce_estado_det.TabIndex = 7
        '
        'UltraLabel16
        '
        Appearance9.BackColor = System.Drawing.Color.Transparent
        Appearance9.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel16.Appearance = Appearance9
        Me.UltraLabel16.AutoSize = True
        Me.UltraLabel16.Location = New System.Drawing.Point(266, 19)
        Me.UltraLabel16.Name = "UltraLabel16"
        Me.UltraLabel16.Size = New System.Drawing.Size(88, 14)
        Me.UltraLabel16.TabIndex = 183
        Me.UltraLabel16.Text = "Estado de Cuota"
        '
        'ume_importe_det
        '
        Appearance11.TextHAlignAsString = "Right"
        Me.ume_importe_det.Appearance = Appearance11
        Me.ume_importe_det.EditAs = Infragistics.Win.UltraWinMaskedEdit.EditAsType.UseSpecifiedMask
        Me.ume_importe_det.InputMask = "{double:-9.2}"
        Me.ume_importe_det.Location = New System.Drawing.Point(83, 73)
        Me.ume_importe_det.Name = "ume_importe_det"
        Me.ume_importe_det.Size = New System.Drawing.Size(117, 20)
        Me.ume_importe_det.TabIndex = 2
        '
        'uce_ayo
        '
        Me.uce_ayo.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.uce_ayo.Location = New System.Drawing.Point(83, 15)
        Me.uce_ayo.Name = "uce_ayo"
        Me.uce_ayo.Size = New System.Drawing.Size(117, 21)
        Me.uce_ayo.TabIndex = 0
        '
        'udte_fec_pago
        '
        Me.udte_fec_pago.Location = New System.Drawing.Point(360, 46)
        Me.udte_fec_pago.MaskInput = "{date}"
        Me.udte_fec_pago.Name = "udte_fec_pago"
        Me.udte_fec_pago.Size = New System.Drawing.Size(156, 21)
        Me.udte_fec_pago.TabIndex = 8
        '
        'ume_tc_det
        '
        Appearance44.TextHAlignAsString = "Right"
        Me.ume_tc_det.Appearance = Appearance44
        Me.ume_tc_det.EditAs = Infragistics.Win.UltraWinMaskedEdit.EditAsType.UseSpecifiedMask
        Me.ume_tc_det.InputMask = "{double:1.3}"
        Me.ume_tc_det.Location = New System.Drawing.Point(202, 102)
        Me.ume_tc_det.Name = "ume_tc_det"
        Me.ume_tc_det.Size = New System.Drawing.Size(38, 20)
        Me.ume_tc_det.TabIndex = 4
        '
        'UltraLabel14
        '
        Appearance5.BackColor = System.Drawing.Color.Transparent
        Appearance5.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel14.Appearance = Appearance5
        Me.UltraLabel14.AutoSize = True
        Me.UltraLabel14.Location = New System.Drawing.Point(171, 105)
        Me.UltraLabel14.Name = "UltraLabel14"
        Me.UltraLabel14.Size = New System.Drawing.Size(26, 14)
        Me.UltraLabel14.TabIndex = 177
        Me.UltraLabel14.Text = "T.C."
        '
        'uce_moneda_det
        '
        Me.uce_moneda_det.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Suggest
        Me.uce_moneda_det.DropDownListWidth = 100
        Me.uce_moneda_det.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.uce_moneda_det.Location = New System.Drawing.Point(83, 101)
        Me.uce_moneda_det.Name = "uce_moneda_det"
        Me.uce_moneda_det.Size = New System.Drawing.Size(75, 21)
        Me.uce_moneda_det.TabIndex = 3
        '
        'UltraLabel15
        '
        Appearance38.BackColor = System.Drawing.Color.Transparent
        Appearance38.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel15.Appearance = Appearance38
        Me.UltraLabel15.AutoSize = True
        Me.UltraLabel15.Location = New System.Drawing.Point(33, 105)
        Me.UltraLabel15.Name = "UltraLabel15"
        Me.UltraLabel15.Size = New System.Drawing.Size(45, 14)
        Me.UltraLabel15.TabIndex = 175
        Me.UltraLabel15.Text = "Moneda"
        '
        'UltraLabel13
        '
        Appearance7.BackColor = System.Drawing.Color.Transparent
        Appearance7.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel13.Appearance = Appearance7
        Me.UltraLabel13.AutoSize = True
        Me.UltraLabel13.Location = New System.Drawing.Point(35, 76)
        Me.UltraLabel13.Name = "UltraLabel13"
        Me.UltraLabel13.Size = New System.Drawing.Size(43, 14)
        Me.UltraLabel13.TabIndex = 151
        Me.UltraLabel13.Text = "Importe"
        '
        'UltraLabel12
        '
        Appearance33.BackColor = System.Drawing.Color.Transparent
        Appearance33.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel12.Appearance = Appearance33
        Me.UltraLabel12.AutoSize = True
        Me.UltraLabel12.Location = New System.Drawing.Point(52, 50)
        Me.UltraLabel12.Name = "UltraLabel12"
        Me.UltraLabel12.Size = New System.Drawing.Size(26, 14)
        Me.UltraLabel12.TabIndex = 150
        Me.UltraLabel12.Text = "Mes"
        '
        'UltraLabel11
        '
        Appearance16.BackColor = System.Drawing.Color.Transparent
        Appearance16.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel11.Appearance = Appearance16
        Me.UltraLabel11.AutoSize = True
        Me.UltraLabel11.Location = New System.Drawing.Point(54, 19)
        Me.UltraLabel11.Name = "UltraLabel11"
        Me.UltraLabel11.Size = New System.Drawing.Size(24, 14)
        Me.UltraLabel11.TabIndex = 149
        Me.UltraLabel11.Text = "Año"
        '
        'uce_mes
        '
        Me.uce_mes.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.uce_mes.Location = New System.Drawing.Point(83, 46)
        Me.uce_mes.Name = "uce_mes"
        Me.uce_mes.Size = New System.Drawing.Size(117, 21)
        Me.uce_mes.TabIndex = 1
        '
        'UltraLabel10
        '
        Appearance10.BackColor = System.Drawing.Color.Transparent
        Appearance10.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel10.Appearance = Appearance10
        Me.UltraLabel10.AutoSize = True
        Me.UltraLabel10.Location = New System.Drawing.Point(287, 50)
        Me.UltraLabel10.Name = "UltraLabel10"
        Me.UltraLabel10.Size = New System.Drawing.Size(65, 14)
        Me.UltraLabel10.TabIndex = 147
        Me.UltraLabel10.Text = "Fecha Pago"
        '
        'UltraTabPageControl1
        '
        Me.UltraTabPageControl1.Controls.Add(Me.ug_Lista)
        Me.UltraTabPageControl1.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl1.Name = "UltraTabPageControl1"
        Me.UltraTabPageControl1.Size = New System.Drawing.Size(1010, 471)
        '
        'ug_Lista
        '
        Me.ug_Lista.DataSource = Me.uds_congelaciones
        Me.ug_Lista.DisplayLayout.AutoFitStyle = Infragistics.Win.UltraWinGrid.AutoFitStyle.ExtendLastColumn
        UltraGridColumn15.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn15.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn15.Header.Caption = "Num."
        UltraGridColumn15.Header.VisiblePosition = 0
        UltraGridColumn15.Width = 31
        UltraGridColumn16.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn16.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn16.Header.Caption = "Fec. Congel"
        UltraGridColumn16.Header.VisiblePosition = 1
        UltraGridColumn16.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Date]
        UltraGridColumn16.Width = 77
        UltraGridColumn17.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn17.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn17.Header.VisiblePosition = 2
        UltraGridColumn17.Hidden = True
        UltraGridColumn17.Width = 43
        UltraGridColumn18.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn18.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn18.Header.Caption = "Comprobante"
        UltraGridColumn18.Header.VisiblePosition = 3
        UltraGridColumn18.Width = 113
        UltraGridColumn19.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn19.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn19.Header.VisiblePosition = 4
        UltraGridColumn19.Hidden = True
        UltraGridColumn19.Width = 45
        UltraGridColumn20.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn20.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn20.Header.Caption = "Cliente"
        UltraGridColumn20.Header.VisiblePosition = 5
        UltraGridColumn20.Width = 292
        UltraGridColumn21.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn21.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn21.Header.VisiblePosition = 6
        UltraGridColumn21.Hidden = True
        UltraGridColumn21.Width = 33
        UltraGridColumn22.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn22.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn22.Header.Caption = "Congelacion"
        UltraGridColumn22.Header.VisiblePosition = 8
        UltraGridColumn22.Width = 250
        UltraGridColumn23.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn23.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn23.Header.VisiblePosition = 9
        UltraGridColumn23.Hidden = True
        UltraGridColumn23.Width = 28
        UltraGridColumn24.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn24.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn24.Header.Caption = "Medico"
        UltraGridColumn24.Header.VisiblePosition = 10
        UltraGridColumn24.Width = 134
        UltraGridColumn25.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn25.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn25.Header.Caption = "Comentarios"
        UltraGridColumn25.Header.VisiblePosition = 7
        UltraGridColumn25.Width = 336
        UltraGridColumn26.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn26.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn26.Header.Caption = "Importe"
        UltraGridColumn26.Header.VisiblePosition = 11
        UltraGridColumn26.MaskDisplayMode = Infragistics.Win.UltraWinMaskedEdit.MaskMode.IncludeLiterals
        UltraGridColumn26.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Double]
        UltraGridColumn26.Width = 93
        UltraGridColumn27.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn27.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn27.Header.Caption = "Estado"
        UltraGridColumn27.Header.VisiblePosition = 12
        UltraGridColumn27.Width = 51
        UltraGridColumn28.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn28.Header.VisiblePosition = 13
        UltraGridColumn29.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn29.Header.VisiblePosition = 14
        UltraGridColumn30.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn30.Header.VisiblePosition = 15
        UltraGridBand2.Columns.AddRange(New Object() {UltraGridColumn15, UltraGridColumn16, UltraGridColumn17, UltraGridColumn18, UltraGridColumn19, UltraGridColumn20, UltraGridColumn21, UltraGridColumn22, UltraGridColumn23, UltraGridColumn24, UltraGridColumn25, UltraGridColumn26, UltraGridColumn27, UltraGridColumn28, UltraGridColumn29, UltraGridColumn30})
        Me.ug_Lista.DisplayLayout.BandsSerializer.Add(UltraGridBand2)
        Me.ug_Lista.DisplayLayout.GroupByBox.Hidden = True
        Me.ug_Lista.DisplayLayout.MaxColScrollRegions = 1
        Me.ug_Lista.DisplayLayout.MaxRowScrollRegions = 1
        Me.ug_Lista.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        Me.ug_Lista.DisplayLayout.Override.FilterOperatorDefaultValue = Infragistics.Win.UltraWinGrid.FilterOperatorDefaultValue.Contains
        Me.ug_Lista.DisplayLayout.Override.FilterUIType = Infragistics.Win.UltraWinGrid.FilterUIType.FilterRow
        Me.ug_Lista.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Appearance1.BackColor = System.Drawing.Color.WhiteSmoke
        Appearance1.BackColor2 = System.Drawing.Color.WhiteSmoke
        Me.ug_Lista.DisplayLayout.Override.RowAlternateAppearance = Appearance1
        Me.ug_Lista.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.ug_Lista.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.ug_Lista.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ug_Lista.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ug_Lista.Location = New System.Drawing.Point(0, 0)
        Me.ug_Lista.Name = "ug_Lista"
        Me.ug_Lista.Size = New System.Drawing.Size(1010, 471)
        Me.ug_Lista.TabIndex = 0
        '
        'uds_congelaciones
        '
        Me.uds_congelaciones.AllowAdd = False
        Me.uds_congelaciones.AllowDelete = False
        UltraDataColumn15.DataType = GetType(Long)
        UltraDataColumn16.DataType = GetType(Date)
        UltraDataColumn26.DataType = GetType(Double)
        UltraDataColumn27.DataType = GetType(Short)
        UltraDataColumn30.DataType = GetType(Double)
        Me.uds_congelaciones.Band.Columns.AddRange(New Object() {UltraDataColumn15, UltraDataColumn16, UltraDataColumn17, UltraDataColumn18, UltraDataColumn19, UltraDataColumn20, UltraDataColumn21, UltraDataColumn22, UltraDataColumn23, UltraDataColumn24, UltraDataColumn25, UltraDataColumn26, UltraDataColumn27, UltraDataColumn28, UltraDataColumn29, UltraDataColumn30})
        '
        'UltraTabPageControl2
        '
        Me.UltraTabPageControl2.Controls.Add(Me.ugb_datos)
        Me.UltraTabPageControl2.Location = New System.Drawing.Point(1, 23)
        Me.UltraTabPageControl2.Name = "UltraTabPageControl2"
        Me.UltraTabPageControl2.Size = New System.Drawing.Size(1010, 471)
        '
        'ugb_datos
        '
        Me.ugb_datos.Controls.Add(Me.btn_quitar)
        Me.ugb_datos.Controls.Add(Me.UltraGroupBox1)
        Me.ugb_datos.Controls.Add(Me.utc_Detalle)
        Me.ugb_datos.Controls.Add(Me.btn_nuevo_det)
        Me.ugb_datos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ugb_datos.Location = New System.Drawing.Point(0, 0)
        Me.ugb_datos.Name = "ugb_datos"
        Me.ugb_datos.Size = New System.Drawing.Size(1010, 471)
        Me.ugb_datos.TabIndex = 0
        '
        'btn_quitar
        '
        Appearance22.ImageHAlign = Infragistics.Win.HAlign.Left
        Me.btn_quitar.Appearance = Appearance22
        Me.btn_quitar.Location = New System.Drawing.Point(114, 169)
        Me.btn_quitar.Name = "btn_quitar"
        Me.btn_quitar.Size = New System.Drawing.Size(92, 28)
        Me.btn_quitar.TabIndex = 191
        Me.btn_quitar.Text = "Quitar"
        '
        'UltraGroupBox1
        '
        Me.UltraGroupBox1.Controls.Add(Me.uce_tipoconge)
        Me.UltraGroupBox1.Controls.Add(Me.UltraLabel19)
        Me.UltraGroupBox1.Controls.Add(Me.ume_ValorTipoCambio)
        Me.UltraGroupBox1.Controls.Add(Me.UltraLabel4)
        Me.UltraGroupBox1.Controls.Add(Me.uce_Moneda)
        Me.UltraGroupBox1.Controls.Add(Me.UltraLabel8)
        Me.UltraGroupBox1.Controls.Add(Me.txt_idcompro)
        Me.UltraGroupBox1.Controls.Add(Me.txt_ref)
        Me.UltraGroupBox1.Controls.Add(Me.uos_estado)
        Me.UltraGroupBox1.Controls.Add(Me.ume_total)
        Me.UltraGroupBox1.Controls.Add(Me.UltraLabel32)
        Me.UltraGroupBox1.Controls.Add(Me.txt_notas)
        Me.UltraGroupBox1.Controls.Add(Me.UltraLabel3)
        Me.UltraGroupBox1.Controls.Add(Me.UltraLabel7)
        Me.UltraGroupBox1.Controls.Add(Me.uce_Medico)
        Me.UltraGroupBox1.Controls.Add(Me.UltraLabel2)
        Me.UltraGroupBox1.Controls.Add(Me.txt_idconge)
        Me.UltraGroupBox1.Controls.Add(Me.UltraLabel9)
        Me.UltraGroupBox1.Controls.Add(Me.txt_IdCliente)
        Me.UltraGroupBox1.Controls.Add(Me.txt_Des_Cliente)
        Me.UltraGroupBox1.Controls.Add(Me.txt_ruc_cliente)
        Me.UltraGroupBox1.Controls.Add(Me.UltraLabel5)
        Me.UltraGroupBox1.Controls.Add(Me.UltraLabel1)
        Me.UltraGroupBox1.Controls.Add(Me.UltraLabel6)
        Me.UltraGroupBox1.Controls.Add(Me.udte_fec_conge)
        Me.UltraGroupBox1.Location = New System.Drawing.Point(15, 12)
        Me.UltraGroupBox1.Name = "UltraGroupBox1"
        Me.UltraGroupBox1.Size = New System.Drawing.Size(982, 149)
        Me.UltraGroupBox1.TabIndex = 169
        '
        'uce_tipoconge
        '
        Me.uce_tipoconge.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Suggest
        Me.uce_tipoconge.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.uce_tipoconge.Location = New System.Drawing.Point(87, 66)
        Me.uce_tipoconge.Name = "uce_tipoconge"
        Me.uce_tipoconge.Size = New System.Drawing.Size(534, 21)
        Me.uce_tipoconge.TabIndex = 3
        '
        'UltraLabel19
        '
        Appearance41.BackColor = System.Drawing.Color.Transparent
        Appearance41.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel19.Appearance = Appearance41
        Me.UltraLabel19.AutoSize = True
        Me.UltraLabel19.Location = New System.Drawing.Point(14, 70)
        Me.UltraLabel19.Name = "UltraLabel19"
        Me.UltraLabel19.Size = New System.Drawing.Size(67, 14)
        Me.UltraLabel19.TabIndex = 192
        Me.UltraLabel19.Text = "Congelacion"
        '
        'ume_ValorTipoCambio
        '
        Appearance12.TextHAlignAsString = "Right"
        Me.ume_ValorTipoCambio.Appearance = Appearance12
        Me.ume_ValorTipoCambio.EditAs = Infragistics.Win.UltraWinMaskedEdit.EditAsType.UseSpecifiedMask
        Me.ume_ValorTipoCambio.InputMask = "{double:1.3}"
        Me.ume_ValorTipoCambio.Location = New System.Drawing.Point(928, 90)
        Me.ume_ValorTipoCambio.Name = "ume_ValorTipoCambio"
        Me.ume_ValorTipoCambio.Size = New System.Drawing.Size(38, 20)
        Me.ume_ValorTipoCambio.TabIndex = 7
        '
        'UltraLabel4
        '
        Appearance13.BackColor = System.Drawing.Color.Transparent
        Appearance13.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel4.Appearance = Appearance13
        Me.UltraLabel4.AutoSize = True
        Me.UltraLabel4.Location = New System.Drawing.Point(896, 93)
        Me.UltraLabel4.Name = "UltraLabel4"
        Me.UltraLabel4.Size = New System.Drawing.Size(26, 14)
        Me.UltraLabel4.TabIndex = 173
        Me.UltraLabel4.Text = "T.C."
        '
        'uce_Moneda
        '
        Me.uce_Moneda.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Suggest
        Me.uce_Moneda.DropDownListWidth = 100
        Me.uce_Moneda.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.uce_Moneda.Location = New System.Drawing.Point(850, 63)
        Me.uce_Moneda.Name = "uce_Moneda"
        Me.uce_Moneda.Size = New System.Drawing.Size(116, 21)
        Me.uce_Moneda.TabIndex = 6
        '
        'UltraLabel8
        '
        Appearance14.BackColor = System.Drawing.Color.Transparent
        Appearance14.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel8.Appearance = Appearance14
        Me.UltraLabel8.AutoSize = True
        Me.UltraLabel8.Location = New System.Drawing.Point(799, 67)
        Me.UltraLabel8.Name = "UltraLabel8"
        Me.UltraLabel8.Size = New System.Drawing.Size(45, 14)
        Me.UltraLabel8.TabIndex = 171
        Me.UltraLabel8.Text = "Moneda"
        '
        'txt_idcompro
        '
        Me.txt_idcompro.Location = New System.Drawing.Point(453, 11)
        Me.txt_idcompro.Name = "txt_idcompro"
        Me.txt_idcompro.ReadOnly = True
        Me.txt_idcompro.Size = New System.Drawing.Size(62, 21)
        Me.txt_idcompro.TabIndex = 170
        '
        'txt_ref
        '
        Me.txt_ref.Location = New System.Drawing.Point(403, 120)
        Me.txt_ref.Name = "txt_ref"
        Me.txt_ref.Size = New System.Drawing.Size(218, 21)
        Me.txt_ref.TabIndex = 9
        '
        'uos_estado
        '
        Me.uos_estado.BackColor = System.Drawing.Color.Transparent
        Me.uos_estado.BackColorInternal = System.Drawing.Color.Transparent
        Me.uos_estado.BorderStyle = Infragistics.Win.UIElementBorderStyle.None
        Me.uos_estado.CheckedIndex = 0
        ValueListItem2.DataValue = CType(1, Short)
        ValueListItem2.DisplayText = "Activo"
        ValueListItem3.DataValue = CType(0, Short)
        ValueListItem3.DisplayText = "Anulado"
        Me.uos_estado.Items.AddRange(New Infragistics.Win.ValueListItem() {ValueListItem2, ValueListItem3})
        Me.uos_estado.ItemSpacingHorizontal = 5
        Me.uos_estado.ItemSpacingVertical = 5
        Me.uos_estado.Location = New System.Drawing.Point(101, 120)
        Me.uos_estado.Name = "uos_estado"
        Me.uos_estado.Size = New System.Drawing.Size(126, 22)
        Me.uos_estado.TabIndex = 168
        Me.uos_estado.Text = "Activo"
        '
        'ume_total
        '
        Appearance15.TextHAlignAsString = "Right"
        Me.ume_total.Appearance = Appearance15
        Me.ume_total.EditAs = Infragistics.Win.UltraWinMaskedEdit.EditAsType.UseSpecifiedMask
        Me.ume_total.InputMask = "{double:-9.2}"
        Me.ume_total.Location = New System.Drawing.Point(873, 116)
        Me.ume_total.Name = "ume_total"
        Me.ume_total.Size = New System.Drawing.Size(93, 20)
        Me.ume_total.TabIndex = 8
        '
        'UltraLabel32
        '
        Appearance3.BackColor = System.Drawing.Color.Transparent
        Appearance3.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel32.Appearance = Appearance3
        Me.UltraLabel32.AutoSize = True
        Me.UltraLabel32.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel32.Location = New System.Drawing.Point(739, 118)
        Me.UltraLabel32.Name = "UltraLabel32"
        Me.UltraLabel32.Size = New System.Drawing.Size(123, 16)
        Me.UltraLabel32.TabIndex = 167
        Me.UltraLabel32.Text = "Importe Congelacion"
        '
        'txt_notas
        '
        Me.txt_notas.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txt_notas.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_notas.Location = New System.Drawing.Point(87, 93)
        Me.txt_notas.MaxLength = 250
        Me.txt_notas.Name = "txt_notas"
        Me.txt_notas.Size = New System.Drawing.Size(534, 21)
        Me.txt_notas.TabIndex = 4
        '
        'UltraLabel3
        '
        Me.UltraLabel3.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Appearance34.BackColor = System.Drawing.Color.Transparent
        Appearance34.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel3.Appearance = Appearance34
        Me.UltraLabel3.AutoSize = True
        Me.UltraLabel3.Location = New System.Drawing.Point(42, 122)
        Me.UltraLabel3.Name = "UltraLabel3"
        Me.UltraLabel3.Size = New System.Drawing.Size(39, 14)
        Me.UltraLabel3.TabIndex = 165
        Me.UltraLabel3.Text = "Estado"
        '
        'UltraLabel7
        '
        Me.UltraLabel7.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Appearance17.BackColor = System.Drawing.Color.Transparent
        Appearance17.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel7.Appearance = Appearance17
        Me.UltraLabel7.AutoSize = True
        Me.UltraLabel7.Location = New System.Drawing.Point(13, 97)
        Me.UltraLabel7.Name = "UltraLabel7"
        Me.UltraLabel7.Size = New System.Drawing.Size(68, 14)
        Me.UltraLabel7.TabIndex = 165
        Me.UltraLabel7.Text = "Comentarios"
        '
        'uce_Medico
        '
        Me.uce_Medico.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Suggest
        Me.uce_Medico.Location = New System.Drawing.Point(678, 39)
        Me.uce_Medico.Name = "uce_Medico"
        Me.uce_Medico.Size = New System.Drawing.Size(288, 21)
        Me.uce_Medico.TabIndex = 5
        '
        'UltraLabel2
        '
        Appearance19.BackColor = System.Drawing.Color.Transparent
        Appearance19.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel2.Appearance = Appearance19
        Me.UltraLabel2.AutoSize = True
        Me.UltraLabel2.Location = New System.Drawing.Point(633, 43)
        Me.UltraLabel2.Name = "UltraLabel2"
        Me.UltraLabel2.Size = New System.Drawing.Size(41, 14)
        Me.UltraLabel2.TabIndex = 163
        Me.UltraLabel2.Text = "Médico"
        '
        'txt_idconge
        '
        Me.txt_idconge.Location = New System.Drawing.Point(87, 14)
        Me.txt_idconge.Name = "txt_idconge"
        Me.txt_idconge.ReadOnly = True
        Me.txt_idconge.Size = New System.Drawing.Size(37, 21)
        Me.txt_idconge.TabIndex = 0
        '
        'UltraLabel9
        '
        Appearance18.BackColor = System.Drawing.Color.Transparent
        Appearance18.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel9.Appearance = Appearance18
        Me.UltraLabel9.AutoSize = True
        Me.UltraLabel9.Location = New System.Drawing.Point(338, 124)
        Me.UltraLabel9.Name = "UltraLabel9"
        Me.UltraLabel9.Size = New System.Drawing.Size(59, 14)
        Me.UltraLabel9.TabIndex = 151
        Me.UltraLabel9.Text = "Referencia"
        '
        'txt_IdCliente
        '
        Me.txt_IdCliente.Location = New System.Drawing.Point(213, 39)
        Me.txt_IdCliente.Name = "txt_IdCliente"
        Me.txt_IdCliente.Size = New System.Drawing.Size(46, 21)
        Me.txt_IdCliente.TabIndex = 144
        '
        'txt_Des_Cliente
        '
        Me.txt_Des_Cliente.Location = New System.Drawing.Point(259, 39)
        Me.txt_Des_Cliente.Name = "txt_Des_Cliente"
        Me.txt_Des_Cliente.ReadOnly = True
        Me.txt_Des_Cliente.Size = New System.Drawing.Size(362, 21)
        Me.txt_Des_Cliente.TabIndex = 145
        '
        'txt_ruc_cliente
        '
        Appearance111.ImageHAlign = Infragistics.Win.HAlign.Center
        Appearance111.ImageVAlign = Infragistics.Win.VAlign.Middle
        EditorButton1.Appearance = Appearance111
        EditorButton1.Key = "ayuda"
        Me.txt_ruc_cliente.ButtonsRight.Add(EditorButton1)
        Me.txt_ruc_cliente.Location = New System.Drawing.Point(87, 39)
        Me.txt_ruc_cliente.MaxLength = 11
        Me.txt_ruc_cliente.Name = "txt_ruc_cliente"
        Me.txt_ruc_cliente.Size = New System.Drawing.Size(126, 21)
        Me.txt_ruc_cliente.TabIndex = 2
        '
        'UltraLabel5
        '
        Appearance8.BackColor = System.Drawing.Color.Transparent
        Appearance8.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel5.Appearance = Appearance8
        Me.UltraLabel5.AutoSize = True
        Me.UltraLabel5.Location = New System.Drawing.Point(41, 43)
        Me.UltraLabel5.Name = "UltraLabel5"
        Me.UltraLabel5.Size = New System.Drawing.Size(40, 14)
        Me.UltraLabel5.TabIndex = 146
        Me.UltraLabel5.Text = "Cliente"
        '
        'UltraLabel1
        '
        Appearance28.BackColor = System.Drawing.Color.Transparent
        Appearance28.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel1.Appearance = Appearance28
        Me.UltraLabel1.AutoSize = True
        Me.UltraLabel1.Location = New System.Drawing.Point(15, 18)
        Me.UltraLabel1.Name = "UltraLabel1"
        Me.UltraLabel1.Size = New System.Drawing.Size(66, 14)
        Me.UltraLabel1.TabIndex = 119
        Me.UltraLabel1.Text = "Identificador"
        '
        'UltraLabel6
        '
        Appearance2.BackColor = System.Drawing.Color.Transparent
        Appearance2.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel6.Appearance = Appearance2
        Me.UltraLabel6.AutoSize = True
        Me.UltraLabel6.Location = New System.Drawing.Point(135, 18)
        Me.UltraLabel6.Name = "UltraLabel6"
        Me.UltraLabel6.Size = New System.Drawing.Size(92, 14)
        Me.UltraLabel6.TabIndex = 119
        Me.UltraLabel6.Text = "Fec. Congelacion"
        '
        'udte_fec_conge
        '
        Me.udte_fec_conge.Location = New System.Drawing.Point(233, 14)
        Me.udte_fec_conge.MaskInput = "{date}"
        Me.udte_fec_conge.Name = "udte_fec_conge"
        Me.udte_fec_conge.Size = New System.Drawing.Size(106, 21)
        Me.udte_fec_conge.TabIndex = 1
        '
        'utc_Detalle
        '
        Me.utc_Detalle.Controls.Add(Me.UltraTabSharedControlsPage2)
        Me.utc_Detalle.Controls.Add(Me.UltraTabPageControl3)
        Me.utc_Detalle.Controls.Add(Me.UltraTabPageControl4)
        Me.utc_Detalle.Location = New System.Drawing.Point(15, 205)
        Me.utc_Detalle.Name = "utc_Detalle"
        Me.utc_Detalle.SharedControlsPage = Me.UltraTabSharedControlsPage2
        Me.utc_Detalle.Size = New System.Drawing.Size(982, 257)
        Me.utc_Detalle.TabIndex = 1
        UltraTab3.TabPage = Me.UltraTabPageControl3
        UltraTab3.Text = "Lista de Pagos"
        UltraTab4.TabPage = Me.UltraTabPageControl4
        UltraTab4.Text = "Ingreso / Edicion de Datos"
        Me.utc_Detalle.Tabs.AddRange(New Infragistics.Win.UltraWinTabControl.UltraTab() {UltraTab3, UltraTab4})
        '
        'UltraTabSharedControlsPage2
        '
        Me.UltraTabSharedControlsPage2.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabSharedControlsPage2.Name = "UltraTabSharedControlsPage2"
        Me.UltraTabSharedControlsPage2.Size = New System.Drawing.Size(978, 231)
        '
        'btn_nuevo_det
        '
        Appearance23.ImageHAlign = Infragistics.Win.HAlign.Left
        Me.btn_nuevo_det.Appearance = Appearance23
        Me.btn_nuevo_det.Location = New System.Drawing.Point(16, 169)
        Me.btn_nuevo_det.Name = "btn_nuevo_det"
        Me.btn_nuevo_det.Size = New System.Drawing.Size(92, 28)
        Me.btn_nuevo_det.TabIndex = 190
        Me.btn_nuevo_det.Text = "Agregar"
        '
        'ToolS_Mantenimiento
        '
        Me.ToolS_Mantenimiento.BackColor = System.Drawing.Color.White
        Me.ToolS_Mantenimiento.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Tool_Nuevo, Me.ToolStripSeparator1, Me.Tool_Grabar, Me.ToolStripSeparator3, Me.Tool_Editar, Me.ToolStripSeparator4, Me.Tool_Cancelar, Me.ToolStripSeparator2, Me.Tool_Eliminar, Me.ToolStripSeparator5, Me.Tool_Salir, Me.ToolStripSeparator6})
        Me.ToolS_Mantenimiento.Location = New System.Drawing.Point(0, 0)
        Me.ToolS_Mantenimiento.Name = "ToolS_Mantenimiento"
        Me.ToolS_Mantenimiento.Size = New System.Drawing.Size(1027, 25)
        Me.ToolS_Mantenimiento.TabIndex = 8
        Me.ToolS_Mantenimiento.Text = "ToolStrip1"
        '
        'Tool_Nuevo
        '
        Me.Tool_Nuevo.Image = Global.Contabilidad.My.Resources.Resources._16__File_new_2_
        Me.Tool_Nuevo.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Tool_Nuevo.Name = "Tool_Nuevo"
        Me.Tool_Nuevo.Size = New System.Drawing.Size(62, 22)
        Me.Tool_Nuevo.Text = "Nuevo"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'Tool_Grabar
        '
        Me.Tool_Grabar.Image = Global.Contabilidad.My.Resources.Resources._003
        Me.Tool_Grabar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Tool_Grabar.Name = "Tool_Grabar"
        Me.Tool_Grabar.Size = New System.Drawing.Size(62, 22)
        Me.Tool_Grabar.Text = "Grabar"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 25)
        '
        'Tool_Editar
        '
        Me.Tool_Editar.Image = Global.Contabilidad.My.Resources.Resources._16__Card_edit_
        Me.Tool_Editar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Tool_Editar.Name = "Tool_Editar"
        Me.Tool_Editar.Size = New System.Drawing.Size(57, 22)
        Me.Tool_Editar.Text = "Editar"
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(6, 25)
        '
        'Tool_Cancelar
        '
        Me.Tool_Cancelar.Image = Global.Contabilidad.My.Resources.Resources._16__Cancel_
        Me.Tool_Cancelar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Tool_Cancelar.Name = "Tool_Cancelar"
        Me.Tool_Cancelar.Size = New System.Drawing.Size(73, 22)
        Me.Tool_Cancelar.Text = "Cancelar"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'Tool_Eliminar
        '
        Me.Tool_Eliminar.Image = Global.Contabilidad.My.Resources.Resources._16__Delete_
        Me.Tool_Eliminar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Tool_Eliminar.Name = "Tool_Eliminar"
        Me.Tool_Eliminar.Size = New System.Drawing.Size(70, 22)
        Me.Tool_Eliminar.Text = "Eliminar"
        '
        'ToolStripSeparator5
        '
        Me.ToolStripSeparator5.Name = "ToolStripSeparator5"
        Me.ToolStripSeparator5.Size = New System.Drawing.Size(6, 25)
        '
        'Tool_Salir
        '
        Me.Tool_Salir.Image = Global.Contabilidad.My.Resources.Resources._28
        Me.Tool_Salir.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Tool_Salir.Name = "Tool_Salir"
        Me.Tool_Salir.Size = New System.Drawing.Size(49, 22)
        Me.Tool_Salir.Text = "Salir"
        '
        'ToolStripSeparator6
        '
        Me.ToolStripSeparator6.Name = "ToolStripSeparator6"
        Me.ToolStripSeparator6.Size = New System.Drawing.Size(6, 25)
        '
        'utc_congela
        '
        Me.utc_congela.Controls.Add(Me.UltraTabSharedControlsPage1)
        Me.utc_congela.Controls.Add(Me.UltraTabPageControl1)
        Me.utc_congela.Controls.Add(Me.UltraTabPageControl2)
        Me.utc_congela.Location = New System.Drawing.Point(7, 30)
        Me.utc_congela.Name = "utc_congela"
        Me.utc_congela.SharedControlsPage = Me.UltraTabSharedControlsPage1
        Me.utc_congela.Size = New System.Drawing.Size(1014, 497)
        Me.utc_congela.TabIndex = 9
        UltraTab1.TabPage = Me.UltraTabPageControl1
        UltraTab1.Text = "Lista de Congelaciones"
        UltraTab2.TabPage = Me.UltraTabPageControl2
        UltraTab2.Text = "Ingreso / Edicion de Datos"
        Me.utc_congela.Tabs.AddRange(New Infragistics.Win.UltraWinTabControl.UltraTab() {UltraTab1, UltraTab2})
        '
        'UltraTabSharedControlsPage1
        '
        Me.UltraTabSharedControlsPage1.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabSharedControlsPage1.Name = "UltraTabSharedControlsPage1"
        Me.UltraTabSharedControlsPage1.Size = New System.Drawing.Size(1010, 471)
        '
        'FA_PR_Mante_Congela_sc
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(1027, 531)
        Me.Controls.Add(Me.utc_congela)
        Me.Controls.Add(Me.ToolS_Mantenimiento)
        Me.MaximizeBox = False
        Me.Name = "FA_PR_Mante_Congela_sc"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Mantenimiento de Congelaciones"
        Me.UltraTabPageControl3.ResumeLayout(False)
        CType(Me.ug_detalle, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.uds_Detalle, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabPageControl4.ResumeLayout(False)
        CType(Me.ugb_detalle, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ugb_detalle.ResumeLayout(False)
        Me.ugb_detalle.PerformLayout()
        CType(Me.txt_idcompro_det, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_ref_det, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_comen_det, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.uce_estado_det, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.uce_ayo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.udte_fec_pago, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.uce_moneda_det, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.uce_mes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabPageControl1.ResumeLayout(False)
        CType(Me.ug_Lista, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.uds_congelaciones, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabPageControl2.ResumeLayout(False)
        CType(Me.ugb_datos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ugb_datos.ResumeLayout(False)
        CType(Me.UltraGroupBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraGroupBox1.ResumeLayout(False)
        Me.UltraGroupBox1.PerformLayout()
        CType(Me.uce_tipoconge, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.uce_Moneda, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_idcompro, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_ref, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.uos_estado, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_notas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.uce_Medico, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_idconge, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_IdCliente, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_Des_Cliente, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_ruc_cliente, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.udte_fec_conge, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.utc_Detalle, System.ComponentModel.ISupportInitialize).EndInit()
        Me.utc_Detalle.ResumeLayout(False)
        Me.ToolS_Mantenimiento.ResumeLayout(False)
        Me.ToolS_Mantenimiento.PerformLayout()
        CType(Me.utc_congela, System.ComponentModel.ISupportInitialize).EndInit()
        Me.utc_congela.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolS_Mantenimiento As System.Windows.Forms.ToolStrip
    Friend WithEvents Tool_Nuevo As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents Tool_Grabar As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents Tool_Editar As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents Tool_Cancelar As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents Tool_Eliminar As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator5 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents Tool_Salir As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator6 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents utc_congela As Infragistics.Win.UltraWinTabControl.UltraTabControl
    Friend WithEvents UltraTabSharedControlsPage1 As Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage
    Friend WithEvents UltraTabPageControl1 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents UltraTabPageControl2 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents uds_congelaciones As Infragistics.Win.UltraWinDataSource.UltraDataSource
    Friend WithEvents ug_Lista As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents ugb_datos As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents ug_detalle As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents uds_Detalle As Infragistics.Win.UltraWinDataSource.UltraDataSource
    Friend WithEvents utc_Detalle As Infragistics.Win.UltraWinTabControl.UltraTabControl
    Friend WithEvents UltraTabSharedControlsPage2 As Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage
    Friend WithEvents UltraTabPageControl3 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents UltraTabPageControl4 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents UltraLabel6 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents udte_fec_conge As Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
    Friend WithEvents uce_mes As Infragistics.Win.UltraWinEditors.UltraComboEditor
    Friend WithEvents UltraLabel10 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents txt_IdCliente As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents txt_Des_Cliente As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents txt_ruc_cliente As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents UltraLabel5 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents txt_idconge As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents UltraLabel9 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel1 As Infragistics.Win.Misc.UltraLabel
    Public WithEvents uce_Medico As Infragistics.Win.UltraWinEditors.UltraComboEditor
    Friend WithEvents UltraLabel2 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents txt_notas As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents UltraLabel7 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents ume_total As Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit
    Friend WithEvents UltraLabel32 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents uos_estado As Infragistics.Win.UltraWinEditors.UltraOptionSet
    Friend WithEvents UltraLabel3 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraGroupBox1 As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents txt_ref As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents txt_idcompro As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents ume_ValorTipoCambio As Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit
    Friend WithEvents UltraLabel4 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents uce_Moneda As Infragistics.Win.UltraWinEditors.UltraComboEditor
    Friend WithEvents UltraLabel8 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents ugb_detalle As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents ume_tc_det As Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit
    Friend WithEvents UltraLabel14 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents uce_moneda_det As Infragistics.Win.UltraWinEditors.UltraComboEditor
    Friend WithEvents UltraLabel15 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel13 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel12 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel11 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents uce_estado_det As Infragistics.Win.UltraWinEditors.UltraComboEditor
    Friend WithEvents UltraLabel16 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents ume_importe_det As Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit
    Friend WithEvents uce_ayo As Infragistics.Win.UltraWinEditors.UltraComboEditor
    Friend WithEvents udte_fec_pago As Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
    Friend WithEvents txt_comen_det As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents UltraLabel17 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents txt_ref_det As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents UltraLabel18 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents btn_cancelar As Infragistics.Win.Misc.UltraButton
    Friend WithEvents btn_Aceptar As Infragistics.Win.Misc.UltraButton
    Friend WithEvents btn_nuevo_det As Infragistics.Win.Misc.UltraButton
    Public WithEvents uce_tipoconge As Infragistics.Win.UltraWinEditors.UltraComboEditor
    Friend WithEvents UltraLabel19 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents btn_quitar As Infragistics.Win.Misc.UltraButton
    Friend WithEvents txt_idcompro_det As Infragistics.Win.UltraWinEditors.UltraTextEditor
End Class
