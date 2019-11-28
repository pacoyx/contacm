<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PL_PR_CuentaCorriente
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
        Dim UltraGridColumn1 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CC_ID")
        Dim UltraGridColumn2 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CC_NUMERO")
        Dim UltraGridColumn3 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CC_FECHA_REGISTRO")
        Dim UltraGridColumn4 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CC_ID_PERSONAL")
        Dim UltraGridColumn5 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NOMBRES")
        Dim UltraGridColumn6 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CC_ID_MOTIVO")
        Dim UltraGridColumn7 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CC_ID_MONEDA")
        Dim UltraGridColumn8 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("MO_SIMBOLO")
        Dim UltraGridColumn9 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CC_IMPORTE")
        Dim Appearance17 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn10 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CC_MONTO_TOTAL")
        Dim Appearance18 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn11 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CC_NUM_CUOTAS")
        Dim UltraGridColumn12 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CC_ESTADO")
        Dim UltraGridColumn13 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CC_SALDO")
        Dim Appearance20 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraDataColumn1 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("CC_ID")
        Dim UltraDataColumn2 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("CC_NUMERO")
        Dim UltraDataColumn3 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("CC_FECHA_REGISTRO")
        Dim UltraDataColumn4 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("CC_ID_PERSONAL")
        Dim UltraDataColumn5 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("NOMBRES")
        Dim UltraDataColumn6 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("CC_ID_MOTIVO")
        Dim UltraDataColumn7 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("CC_ID_MONEDA")
        Dim UltraDataColumn8 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("MO_SIMBOLO")
        Dim UltraDataColumn9 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("CC_IMPORTE")
        Dim UltraDataColumn10 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("CC_MONTO_TOTAL")
        Dim UltraDataColumn11 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("CC_NUM_CUOTAS")
        Dim UltraDataColumn12 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("CC_ESTADO")
        Dim UltraDataColumn13 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("CC_SALDO")
        Dim Appearance45 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance1 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance49 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance50 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance13 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance16 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance7 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance15 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance3 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim EditorButton1 As Infragistics.Win.UltraWinEditors.EditorButton = New Infragistics.Win.UltraWinEditors.EditorButton()
        Dim EditorButton2 As Infragistics.Win.UltraWinEditors.EditorButton = New Infragistics.Win.UltraWinEditors.EditorButton()
        Dim Appearance10 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance8 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance29 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance11 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance12 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance22 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance43 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance28 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance41 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance44 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance42 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance26 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance39 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance37 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance19 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance40 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance38 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance27 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance4 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance2 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance32 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance5 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance31 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance30 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance34 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance9 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance14 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance6 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance21 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridBand2 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1)
        Dim UltraGridColumn14 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CR_ID_CTACTE")
        Dim UltraGridColumn15 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CR_NUM_CUOTA")
        Dim Appearance66 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn16 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CR_FECHA_PAGO")
        Dim Appearance67 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn17 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CR_IMPORTE")
        Dim Appearance68 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn18 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CR_ESTADO")
        Dim UltraGridColumn19 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CR_NO_CONSIDERAR")
        Dim UltraGridColumn20 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CR_CAPITAL")
        Dim Appearance69 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn21 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CR_CUOTA")
        Dim Appearance70 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn22 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CR_INTERES")
        Dim Appearance71 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim SummarySettings1 As Infragistics.Win.UltraWinGrid.SummarySettings = New Infragistics.Win.UltraWinGrid.SummarySettings("", Infragistics.Win.UltraWinGrid.SummaryType.Sum, Nothing, "CR_CUOTA", 7, True, "Band 0", 0, Infragistics.Win.UltraWinGrid.SummaryPosition.UseSummaryPositionColumn, "CR_CUOTA", 7, True)
        Dim Appearance72 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance73 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim SummarySettings2 As Infragistics.Win.UltraWinGrid.SummarySettings = New Infragistics.Win.UltraWinGrid.SummarySettings("", Infragistics.Win.UltraWinGrid.SummaryType.Sum, Nothing, "CR_INTERES", 8, True, "Band 0", 0, Infragistics.Win.UltraWinGrid.SummaryPosition.UseSummaryPositionColumn, "CR_INTERES", 8, True)
        Dim Appearance74 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance75 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim SummarySettings3 As Infragistics.Win.UltraWinGrid.SummarySettings = New Infragistics.Win.UltraWinGrid.SummarySettings("", Infragistics.Win.UltraWinGrid.SummaryType.Sum, Nothing, "CR_IMPORTE", 3, True, "Band 0", 0, Infragistics.Win.UltraWinGrid.SummaryPosition.UseSummaryPositionColumn, "CR_IMPORTE", 3, True)
        Dim Appearance76 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance77 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraDataColumn14 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("CR_ID_CTACTE")
        Dim UltraDataColumn15 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("CR_NUM_CUOTA")
        Dim UltraDataColumn16 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("CR_FECHA_PAGO")
        Dim UltraDataColumn17 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("CR_IMPORTE")
        Dim UltraDataColumn18 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("CR_ESTADO")
        Dim UltraDataColumn19 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("CR_NO_CONSIDERAR")
        Dim UltraDataColumn20 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("CR_CAPITAL")
        Dim UltraDataColumn21 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("CR_CUOTA")
        Dim UltraDataColumn22 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("CR_INTERES")
        Dim UltraTab1 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraTab2 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraTab3 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Me.UltraTabPageControl1 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.ubtn_Anular = New Infragistics.Win.Misc.UltraButton()
        Me.uos_estado = New Infragistics.Win.UltraWinEditors.UltraOptionSet()
        Me.ubtn_Cronograma = New Infragistics.Win.Misc.UltraButton()
        Me.ug_listado_cta_cte = New Infragistics.Win.UltraWinGrid.UltraGrid()
        Me.uds_Listado_CtaCte = New Infragistics.Win.UltraWinDataSource.UltraDataSource(Me.components)
        Me.UltraTabPageControl2 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.ugb_datos = New Infragistics.Win.Misc.UltraGroupBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.une_num_recibo = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.UltraLabel24 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraLabel23 = New Infragistics.Win.Misc.UltraLabel()
        Me.txt_ser_doc = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.txt_des_doc = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.txt_tip_doc = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.UltraLabel10 = New Infragistics.Win.Misc.UltraLabel()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.ume_tipoCambio = New Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit()
        Me.uchk_Afecta = New Infragistics.Win.UltraWinEditors.UltraCheckEditor()
        Me.UltraLabel6 = New Infragistics.Win.Misc.UltraLabel()
        Me.txt_id_registro = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.UltraLabel4 = New Infragistics.Win.Misc.UltraLabel()
        Me.txt_id_personal = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.UltraLabel3 = New Infragistics.Win.Misc.UltraLabel()
        Me.uce_Moneda = New Infragistics.Win.UltraWinEditors.UltraComboEditor()
        Me.uce_Motivo = New Infragistics.Win.UltraWinEditors.UltraComboEditor()
        Me.txt_nombres = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.txt_cod_personal = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.UltraLabel2 = New Infragistics.Win.Misc.UltraLabel()
        Me.udte_fecha_Reg = New Infragistics.Win.UltraWinEditors.UltraDateTimeEditor()
        Me.UltraLabel1 = New Infragistics.Win.Misc.UltraLabel()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.UltraLabel9 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraLabel5 = New Infragistics.Win.Misc.UltraLabel()
        Me.uce_estado = New Infragistics.Win.UltraWinEditors.UltraComboEditor()
        Me.txt_obs = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.ume_total_interes = New Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit()
        Me.ubtn_formula = New Infragistics.Win.Misc.UltraButton()
        Me.ume_cuota_mensual = New Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit()
        Me.UltraLabel21 = New Infragistics.Win.Misc.UltraLabel()
        Me.ume_saldo = New Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit()
        Me.UltraLabel20 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraLabel11 = New Infragistics.Win.Misc.UltraLabel()
        Me.ume_monto_total = New Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit()
        Me.ume_tasaInteres = New Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit()
        Me.une_num_cuota = New Infragistics.Win.UltraWinEditors.UltraNumericEditor()
        Me.ume_Importe = New Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit()
        Me.UltraLabel19 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraLabel18 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraLabel7 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraLabel12 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraTabPageControl3 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.ubtn_Cancelar = New Infragistics.Win.Misc.UltraButton()
        Me.ubtn_Mod_Cronograma = New Infragistics.Win.Misc.UltraButton()
        Me.ubtn_Regresar = New Infragistics.Win.Misc.UltraButton()
        Me.ugb_Informacion = New Infragistics.Win.Misc.UltraGroupBox()
        Me.ume_cro_fecha_prestamo = New Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit()
        Me.UltraLabel17 = New Infragistics.Win.Misc.UltraLabel()
        Me.ume_imp_total = New Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit()
        Me.ume_cro_saldo = New Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit()
        Me.UltraLabel16 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraLabel22 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraLabel15 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraLabel14 = New Infragistics.Win.Misc.UltraLabel()
        Me.une_cuotas_pen = New Infragistics.Win.UltraWinEditors.UltraNumericEditor()
        Me.une_cro_cuotas_can = New Infragistics.Win.UltraWinEditors.UltraNumericEditor()
        Me.une_cro_num_cuotas = New Infragistics.Win.UltraWinEditors.UltraNumericEditor()
        Me.UltraLabel13 = New Infragistics.Win.Misc.UltraLabel()
        Me.ume_cro_importe = New Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit()
        Me.UltraLabel8 = New Infragistics.Win.Misc.UltraLabel()
        Me.lbl_personal = New Infragistics.Win.Misc.UltraLabel()
        Me.ug_cronograma = New Infragistics.Win.UltraWinGrid.UltraGrid()
        Me.uds_Cronograma = New Infragistics.Win.UltraWinDataSource.UltraDataSource(Me.components)
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
        Me.utc_Cta_Cte = New Infragistics.Win.UltraWinTabControl.UltraTabControl()
        Me.UltraTabSharedControlsPage1 = New Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage()
        Me.ubtn_exportar = New Infragistics.Win.Misc.UltraButton()
        Me.uge_ctacor = New Infragistics.Win.UltraWinGrid.ExcelExport.UltraGridExcelExporter(Me.components)
        Me.UltraTabPageControl1.SuspendLayout()
        CType(Me.uos_estado, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ug_listado_cta_cte, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.uds_Listado_CtaCte, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabPageControl2.SuspendLayout()
        CType(Me.ugb_datos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ugb_datos.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        CType(Me.une_num_recibo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_ser_doc, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_des_doc, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_tip_doc, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        CType(Me.txt_id_registro, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_id_personal, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.uce_Moneda, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.uce_Motivo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_nombres, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_cod_personal, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.udte_fecha_Reg, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.uce_estado, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_obs, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.une_num_cuota, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabPageControl3.SuspendLayout()
        CType(Me.ugb_Informacion, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ugb_Informacion.SuspendLayout()
        CType(Me.une_cuotas_pen, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.une_cro_cuotas_can, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.une_cro_num_cuotas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ug_cronograma, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.uds_Cronograma, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolS_Mantenimiento.SuspendLayout()
        CType(Me.utc_Cta_Cte, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.utc_Cta_Cte.SuspendLayout()
        Me.SuspendLayout()
        '
        'UltraTabPageControl1
        '
        Me.UltraTabPageControl1.Controls.Add(Me.ubtn_Anular)
        Me.UltraTabPageControl1.Controls.Add(Me.uos_estado)
        Me.UltraTabPageControl1.Controls.Add(Me.ubtn_Cronograma)
        Me.UltraTabPageControl1.Controls.Add(Me.ug_listado_cta_cte)
        Me.UltraTabPageControl1.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl1.Name = "UltraTabPageControl1"
        Me.UltraTabPageControl1.Size = New System.Drawing.Size(776, 369)
        '
        'ubtn_Anular
        '
        Me.ubtn_Anular.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ubtn_Anular.Location = New System.Drawing.Point(519, 9)
        Me.ubtn_Anular.Name = "ubtn_Anular"
        Me.ubtn_Anular.Size = New System.Drawing.Size(75, 28)
        Me.ubtn_Anular.TabIndex = 3
        Me.ubtn_Anular.Text = "&Anular"
        '
        'uos_estado
        '
        Me.uos_estado.BorderStyle = Infragistics.Win.UIElementBorderStyle.None
        Me.uos_estado.Location = New System.Drawing.Point(12, 14)
        Me.uos_estado.Name = "uos_estado"
        Me.uos_estado.Size = New System.Drawing.Size(385, 22)
        Me.uos_estado.TabIndex = 2
        '
        'ubtn_Cronograma
        '
        Me.ubtn_Cronograma.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ubtn_Cronograma.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ubtn_Cronograma.Location = New System.Drawing.Point(600, 9)
        Me.ubtn_Cronograma.Name = "ubtn_Cronograma"
        Me.ubtn_Cronograma.Size = New System.Drawing.Size(162, 29)
        Me.ubtn_Cronograma.TabIndex = 1
        Me.ubtn_Cronograma.Text = "Cronograma de Pagos"
        '
        'ug_listado_cta_cte
        '
        Me.ug_listado_cta_cte.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ug_listado_cta_cte.DataSource = Me.uds_Listado_CtaCte
        Me.ug_listado_cta_cte.DisplayLayout.AutoFitStyle = Infragistics.Win.UltraWinGrid.AutoFitStyle.ExtendLastColumn
        UltraGridColumn1.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn1.Header.VisiblePosition = 0
        UltraGridColumn1.Hidden = True
        UltraGridColumn2.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn2.Header.Caption = "Nº Recibo"
        UltraGridColumn2.Header.VisiblePosition = 1
        UltraGridColumn2.Width = 45
        UltraGridColumn3.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn3.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn3.Header.Caption = "Fecha"
        UltraGridColumn3.Header.VisiblePosition = 2
        UltraGridColumn3.Width = 70
        UltraGridColumn4.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn4.Header.VisiblePosition = 3
        UltraGridColumn4.Hidden = True
        UltraGridColumn5.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn5.Header.Caption = "Personal"
        UltraGridColumn5.Header.VisiblePosition = 4
        UltraGridColumn5.Width = 170
        UltraGridColumn6.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn6.Header.VisiblePosition = 5
        UltraGridColumn6.Hidden = True
        UltraGridColumn7.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn7.Header.VisiblePosition = 6
        UltraGridColumn7.Hidden = True
        UltraGridColumn8.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn8.Header.Caption = "Mon"
        UltraGridColumn8.Header.VisiblePosition = 7
        UltraGridColumn8.Width = 29
        UltraGridColumn9.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        Appearance17.TextHAlignAsString = "Right"
        UltraGridColumn9.CellAppearance = Appearance17
        UltraGridColumn9.Header.Caption = "Importe"
        UltraGridColumn9.Header.VisiblePosition = 8
        UltraGridColumn10.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        Appearance18.TextHAlignAsString = "Right"
        UltraGridColumn10.CellAppearance = Appearance18
        UltraGridColumn10.Header.Caption = "Monto Total"
        UltraGridColumn10.Header.VisiblePosition = 9
        UltraGridColumn11.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn11.Header.Caption = "Cuotas"
        UltraGridColumn11.Header.VisiblePosition = 10
        UltraGridColumn11.Width = 39
        UltraGridColumn12.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn12.Header.Caption = "Estado"
        UltraGridColumn12.Header.VisiblePosition = 11
        UltraGridColumn13.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        Appearance20.TextHAlignAsString = "Right"
        UltraGridColumn13.CellAppearance = Appearance20
        UltraGridColumn13.Header.Caption = "Saldo"
        UltraGridColumn13.Header.VisiblePosition = 12
        UltraGridBand1.Columns.AddRange(New Object() {UltraGridColumn1, UltraGridColumn2, UltraGridColumn3, UltraGridColumn4, UltraGridColumn5, UltraGridColumn6, UltraGridColumn7, UltraGridColumn8, UltraGridColumn9, UltraGridColumn10, UltraGridColumn11, UltraGridColumn12, UltraGridColumn13})
        Me.ug_listado_cta_cte.DisplayLayout.BandsSerializer.Add(UltraGridBand1)
        Me.ug_listado_cta_cte.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.[False]
        Me.ug_listado_cta_cte.DisplayLayout.Override.FilterUIType = Infragistics.Win.UltraWinGrid.FilterUIType.FilterRow
        Me.ug_listado_cta_cte.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Me.ug_listado_cta_cte.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ug_listado_cta_cte.Location = New System.Drawing.Point(12, 44)
        Me.ug_listado_cta_cte.Name = "ug_listado_cta_cte"
        Me.ug_listado_cta_cte.Size = New System.Drawing.Size(750, 313)
        Me.ug_listado_cta_cte.TabIndex = 0
        Me.ug_listado_cta_cte.Text = "UltraGrid1"
        '
        'uds_Listado_CtaCte
        '
        Me.uds_Listado_CtaCte.AllowDelete = False
        UltraDataColumn1.DataType = GetType(Integer)
        UltraDataColumn3.DataType = GetType(Date)
        UltraDataColumn4.DataType = GetType(Integer)
        UltraDataColumn6.DataType = GetType(Short)
        UltraDataColumn7.DataType = GetType(Short)
        UltraDataColumn9.DataType = GetType(Double)
        UltraDataColumn10.DataType = GetType(Double)
        UltraDataColumn11.DataType = GetType(Short)
        UltraDataColumn13.DataType = GetType(Double)
        Me.uds_Listado_CtaCte.Band.Columns.AddRange(New Object() {UltraDataColumn1, UltraDataColumn2, UltraDataColumn3, UltraDataColumn4, UltraDataColumn5, UltraDataColumn6, UltraDataColumn7, UltraDataColumn8, UltraDataColumn9, UltraDataColumn10, UltraDataColumn11, UltraDataColumn12, UltraDataColumn13})
        '
        'UltraTabPageControl2
        '
        Me.UltraTabPageControl2.Controls.Add(Me.ugb_datos)
        Me.UltraTabPageControl2.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl2.Name = "UltraTabPageControl2"
        Me.UltraTabPageControl2.Size = New System.Drawing.Size(776, 369)
        '
        'ugb_datos
        '
        Appearance45.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ugb_datos.Appearance = Appearance45
        Me.ugb_datos.Controls.Add(Me.GroupBox4)
        Me.ugb_datos.Controls.Add(Me.GroupBox3)
        Me.ugb_datos.Controls.Add(Me.GroupBox2)
        Me.ugb_datos.Controls.Add(Me.GroupBox1)
        Me.ugb_datos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ugb_datos.Location = New System.Drawing.Point(0, 0)
        Me.ugb_datos.Name = "ugb_datos"
        Me.ugb_datos.Size = New System.Drawing.Size(776, 369)
        Me.ugb_datos.TabIndex = 0
        '
        'GroupBox4
        '
        Me.GroupBox4.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox4.Controls.Add(Me.une_num_recibo)
        Me.GroupBox4.Controls.Add(Me.UltraLabel24)
        Me.GroupBox4.Controls.Add(Me.UltraLabel23)
        Me.GroupBox4.Controls.Add(Me.txt_ser_doc)
        Me.GroupBox4.Controls.Add(Me.txt_des_doc)
        Me.GroupBox4.Controls.Add(Me.txt_tip_doc)
        Me.GroupBox4.Controls.Add(Me.UltraLabel10)
        Me.GroupBox4.Location = New System.Drawing.Point(14, 5)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(742, 42)
        Me.GroupBox4.TabIndex = 24
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Recibo de Prestamo"
        '
        'une_num_recibo
        '
        Me.une_num_recibo.Location = New System.Drawing.Point(450, 15)
        Me.une_num_recibo.Name = "une_num_recibo"
        Me.une_num_recibo.ReadOnly = True
        Me.une_num_recibo.Size = New System.Drawing.Size(55, 21)
        Me.une_num_recibo.TabIndex = 13
        '
        'UltraLabel24
        '
        Appearance1.BackColor = System.Drawing.Color.Transparent
        Appearance1.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel24.Appearance = Appearance1
        Me.UltraLabel24.AutoSize = True
        Me.UltraLabel24.Location = New System.Drawing.Point(400, 19)
        Me.UltraLabel24.Name = "UltraLabel24"
        Me.UltraLabel24.Size = New System.Drawing.Size(44, 14)
        Me.UltraLabel24.TabIndex = 12
        Me.UltraLabel24.Text = "Numero"
        '
        'UltraLabel23
        '
        Appearance49.BackColor = System.Drawing.Color.Transparent
        Appearance49.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel23.Appearance = Appearance49
        Me.UltraLabel23.AutoSize = True
        Me.UltraLabel23.Location = New System.Drawing.Point(297, 19)
        Me.UltraLabel23.Name = "UltraLabel23"
        Me.UltraLabel23.Size = New System.Drawing.Size(31, 14)
        Me.UltraLabel23.TabIndex = 11
        Me.UltraLabel23.Text = "Serie"
        '
        'txt_ser_doc
        '
        Me.txt_ser_doc.Location = New System.Drawing.Point(334, 15)
        Me.txt_ser_doc.Name = "txt_ser_doc"
        Me.txt_ser_doc.ReadOnly = True
        Me.txt_ser_doc.Size = New System.Drawing.Size(55, 21)
        Me.txt_ser_doc.TabIndex = 10
        '
        'txt_des_doc
        '
        Me.txt_des_doc.Location = New System.Drawing.Point(136, 15)
        Me.txt_des_doc.Name = "txt_des_doc"
        Me.txt_des_doc.ReadOnly = True
        Me.txt_des_doc.Size = New System.Drawing.Size(148, 21)
        Me.txt_des_doc.TabIndex = 10
        '
        'txt_tip_doc
        '
        Me.txt_tip_doc.Location = New System.Drawing.Point(107, 15)
        Me.txt_tip_doc.Name = "txt_tip_doc"
        Me.txt_tip_doc.ReadOnly = True
        Me.txt_tip_doc.Size = New System.Drawing.Size(29, 21)
        Me.txt_tip_doc.TabIndex = 10
        '
        'UltraLabel10
        '
        Appearance50.BackColor = System.Drawing.Color.Transparent
        Appearance50.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel10.Appearance = Appearance50
        Me.UltraLabel10.AutoSize = True
        Me.UltraLabel10.Location = New System.Drawing.Point(29, 19)
        Me.UltraLabel10.Name = "UltraLabel10"
        Me.UltraLabel10.Size = New System.Drawing.Size(55, 14)
        Me.UltraLabel10.TabIndex = 9
        Me.UltraLabel10.Text = "Nº Recibo"
        '
        'GroupBox3
        '
        Me.GroupBox3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox3.Controls.Add(Me.ume_tipoCambio)
        Me.GroupBox3.Controls.Add(Me.uchk_Afecta)
        Me.GroupBox3.Controls.Add(Me.UltraLabel6)
        Me.GroupBox3.Controls.Add(Me.txt_id_registro)
        Me.GroupBox3.Controls.Add(Me.UltraLabel4)
        Me.GroupBox3.Controls.Add(Me.txt_id_personal)
        Me.GroupBox3.Controls.Add(Me.UltraLabel3)
        Me.GroupBox3.Controls.Add(Me.uce_Moneda)
        Me.GroupBox3.Controls.Add(Me.uce_Motivo)
        Me.GroupBox3.Controls.Add(Me.txt_nombres)
        Me.GroupBox3.Controls.Add(Me.txt_cod_personal)
        Me.GroupBox3.Controls.Add(Me.UltraLabel2)
        Me.GroupBox3.Controls.Add(Me.udte_fecha_Reg)
        Me.GroupBox3.Controls.Add(Me.UltraLabel1)
        Me.GroupBox3.Location = New System.Drawing.Point(14, 53)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(742, 102)
        Me.GroupBox3.TabIndex = 23
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Datos de Registro"
        '
        'ume_tipoCambio
        '
        Appearance13.TextHAlignAsString = "Right"
        Me.ume_tipoCambio.Appearance = Appearance13
        Me.ume_tipoCambio.EditAs = Infragistics.Win.UltraWinMaskedEdit.EditAsType.UseSpecifiedMask
        Me.ume_tipoCambio.InputMask = "{double:3.3}"
        Me.ume_tipoCambio.Location = New System.Drawing.Point(364, 70)
        Me.ume_tipoCambio.Name = "ume_tipoCambio"
        Me.ume_tipoCambio.Size = New System.Drawing.Size(69, 20)
        Me.ume_tipoCambio.TabIndex = 19
        Me.ume_tipoCambio.Text = "UltraMaskedEdit1"
        '
        'uchk_Afecta
        '
        Appearance16.ForeColor = System.Drawing.Color.Navy
        Me.uchk_Afecta.Appearance = Appearance16
        Me.uchk_Afecta.BackColor = System.Drawing.Color.Transparent
        Me.uchk_Afecta.BackColorInternal = System.Drawing.Color.Transparent
        Me.uchk_Afecta.Checked = True
        Me.uchk_Afecta.CheckState = System.Windows.Forms.CheckState.Checked
        Me.uchk_Afecta.Location = New System.Drawing.Point(446, 73)
        Me.uchk_Afecta.Name = "uchk_Afecta"
        Me.uchk_Afecta.Size = New System.Drawing.Size(120, 20)
        Me.uchk_Afecta.TabIndex = 7
        Me.uchk_Afecta.Text = "Afecta a la Planilla"
        '
        'UltraLabel6
        '
        Appearance7.BackColor = System.Drawing.Color.Transparent
        Appearance7.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel6.Appearance = Appearance7
        Me.UltraLabel6.AutoSize = True
        Me.UltraLabel6.Location = New System.Drawing.Point(290, 73)
        Me.UltraLabel6.Name = "UltraLabel6"
        Me.UltraLabel6.Size = New System.Drawing.Size(68, 14)
        Me.UltraLabel6.TabIndex = 16
        Me.UltraLabel6.Text = "Tipo Cambio"
        '
        'txt_id_registro
        '
        Me.txt_id_registro.Location = New System.Drawing.Point(650, 19)
        Me.txt_id_registro.Name = "txt_id_registro"
        Me.txt_id_registro.Size = New System.Drawing.Size(41, 21)
        Me.txt_id_registro.TabIndex = 11
        Me.txt_id_registro.Visible = False
        '
        'UltraLabel4
        '
        Appearance15.BackColor = System.Drawing.Color.Transparent
        Appearance15.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel4.Appearance = Appearance15
        Me.UltraLabel4.AutoSize = True
        Me.UltraLabel4.Location = New System.Drawing.Point(20, 73)
        Me.UltraLabel4.Name = "UltraLabel4"
        Me.UltraLabel4.Size = New System.Drawing.Size(45, 14)
        Me.UltraLabel4.TabIndex = 16
        Me.UltraLabel4.Text = "Moneda"
        '
        'txt_id_personal
        '
        Me.txt_id_personal.Location = New System.Drawing.Point(697, 19)
        Me.txt_id_personal.Name = "txt_id_personal"
        Me.txt_id_personal.Size = New System.Drawing.Size(32, 21)
        Me.txt_id_personal.TabIndex = 11
        Me.txt_id_personal.Visible = False
        '
        'UltraLabel3
        '
        Appearance3.BackColor = System.Drawing.Color.Transparent
        Appearance3.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel3.Appearance = Appearance3
        Me.UltraLabel3.AutoSize = True
        Me.UltraLabel3.Location = New System.Drawing.Point(290, 45)
        Me.UltraLabel3.Name = "UltraLabel3"
        Me.UltraLabel3.Size = New System.Drawing.Size(38, 14)
        Me.UltraLabel3.TabIndex = 16
        Me.UltraLabel3.Text = "Motivo"
        '
        'uce_Moneda
        '
        Me.uce_Moneda.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.uce_Moneda.Location = New System.Drawing.Point(107, 69)
        Me.uce_Moneda.Name = "uce_Moneda"
        Me.uce_Moneda.Size = New System.Drawing.Size(144, 21)
        Me.uce_Moneda.TabIndex = 4
        '
        'uce_Motivo
        '
        Me.uce_Motivo.ButtonsRight.Add(EditorButton1)
        Me.uce_Motivo.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.uce_Motivo.Location = New System.Drawing.Point(364, 41)
        Me.uce_Motivo.Name = "uce_Motivo"
        Me.uce_Motivo.Size = New System.Drawing.Size(202, 21)
        Me.uce_Motivo.TabIndex = 3
        '
        'txt_nombres
        '
        Me.txt_nombres.Location = New System.Drawing.Point(227, 15)
        Me.txt_nombres.Name = "txt_nombres"
        Me.txt_nombres.Size = New System.Drawing.Size(339, 21)
        Me.txt_nombres.TabIndex = 14
        '
        'txt_cod_personal
        '
        Appearance10.ImageHAlign = Infragistics.Win.HAlign.Center
        Appearance10.ImageVAlign = Infragistics.Win.VAlign.Middle
        EditorButton2.Appearance = Appearance10
        Me.txt_cod_personal.ButtonsRight.Add(EditorButton2)
        Me.txt_cod_personal.Location = New System.Drawing.Point(107, 15)
        Me.txt_cod_personal.Name = "txt_cod_personal"
        Me.txt_cod_personal.Size = New System.Drawing.Size(120, 21)
        Me.txt_cod_personal.TabIndex = 1
        '
        'UltraLabel2
        '
        Appearance8.BackColor = System.Drawing.Color.Transparent
        Appearance8.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel2.Appearance = Appearance8
        Me.UltraLabel2.AutoSize = True
        Me.UltraLabel2.Location = New System.Drawing.Point(20, 19)
        Me.UltraLabel2.Name = "UltraLabel2"
        Me.UltraLabel2.Size = New System.Drawing.Size(49, 14)
        Me.UltraLabel2.TabIndex = 12
        Me.UltraLabel2.Text = "Personal"
        '
        'udte_fecha_Reg
        '
        Me.udte_fecha_Reg.Location = New System.Drawing.Point(107, 42)
        Me.udte_fecha_Reg.Name = "udte_fecha_Reg"
        Me.udte_fecha_Reg.Size = New System.Drawing.Size(144, 21)
        Me.udte_fecha_Reg.TabIndex = 2
        '
        'UltraLabel1
        '
        Appearance29.BackColor = System.Drawing.Color.Transparent
        Appearance29.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel1.Appearance = Appearance29
        Me.UltraLabel1.AutoSize = True
        Me.UltraLabel1.Location = New System.Drawing.Point(20, 46)
        Me.UltraLabel1.Name = "UltraLabel1"
        Me.UltraLabel1.Size = New System.Drawing.Size(81, 14)
        Me.UltraLabel1.TabIndex = 9
        Me.UltraLabel1.Text = "Fecha Registro"
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox2.Controls.Add(Me.UltraLabel9)
        Me.GroupBox2.Controls.Add(Me.UltraLabel5)
        Me.GroupBox2.Controls.Add(Me.uce_estado)
        Me.GroupBox2.Controls.Add(Me.txt_obs)
        Me.GroupBox2.Location = New System.Drawing.Point(14, 250)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(742, 109)
        Me.GroupBox2.TabIndex = 22
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Observaciones"
        '
        'UltraLabel9
        '
        Appearance11.BackColor = System.Drawing.Color.Transparent
        Appearance11.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel9.Appearance = Appearance11
        Me.UltraLabel9.AutoSize = True
        Me.UltraLabel9.Location = New System.Drawing.Point(20, 24)
        Me.UltraLabel9.Name = "UltraLabel9"
        Me.UltraLabel9.Size = New System.Drawing.Size(39, 14)
        Me.UltraLabel9.TabIndex = 16
        Me.UltraLabel9.Text = "Estado"
        '
        'UltraLabel5
        '
        Appearance12.BackColor = System.Drawing.Color.Transparent
        Appearance12.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel5.Appearance = Appearance12
        Me.UltraLabel5.AutoSize = True
        Me.UltraLabel5.Location = New System.Drawing.Point(20, 50)
        Me.UltraLabel5.Name = "UltraLabel5"
        Me.UltraLabel5.Size = New System.Drawing.Size(80, 14)
        Me.UltraLabel5.TabIndex = 16
        Me.UltraLabel5.Text = "Observaciones"
        '
        'uce_estado
        '
        Me.uce_estado.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.uce_estado.Location = New System.Drawing.Point(107, 20)
        Me.uce_estado.Name = "uce_estado"
        Me.uce_estado.Size = New System.Drawing.Size(171, 21)
        Me.uce_estado.TabIndex = 8
        '
        'txt_obs
        '
        Me.txt_obs.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_obs.Location = New System.Drawing.Point(107, 50)
        Me.txt_obs.Multiline = True
        Me.txt_obs.Name = "txt_obs"
        Me.txt_obs.Size = New System.Drawing.Size(624, 53)
        Me.txt_obs.TabIndex = 9
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.ume_total_interes)
        Me.GroupBox1.Controls.Add(Me.ubtn_formula)
        Me.GroupBox1.Controls.Add(Me.ume_cuota_mensual)
        Me.GroupBox1.Controls.Add(Me.UltraLabel21)
        Me.GroupBox1.Controls.Add(Me.ume_saldo)
        Me.GroupBox1.Controls.Add(Me.UltraLabel20)
        Me.GroupBox1.Controls.Add(Me.UltraLabel11)
        Me.GroupBox1.Controls.Add(Me.ume_monto_total)
        Me.GroupBox1.Controls.Add(Me.ume_tasaInteres)
        Me.GroupBox1.Controls.Add(Me.une_num_cuota)
        Me.GroupBox1.Controls.Add(Me.ume_Importe)
        Me.GroupBox1.Controls.Add(Me.UltraLabel19)
        Me.GroupBox1.Controls.Add(Me.UltraLabel18)
        Me.GroupBox1.Controls.Add(Me.UltraLabel7)
        Me.GroupBox1.Controls.Add(Me.UltraLabel12)
        Me.GroupBox1.Location = New System.Drawing.Point(14, 161)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(743, 83)
        Me.GroupBox1.TabIndex = 21
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Datos de Calculo"
        '
        'ume_total_interes
        '
        Appearance22.TextHAlignAsString = "Right"
        Me.ume_total_interes.Appearance = Appearance22
        Me.ume_total_interes.EditAs = Infragistics.Win.UltraWinMaskedEdit.EditAsType.UseSpecifiedMask
        Me.ume_total_interes.InputMask = "{double:9.2}"
        Me.ume_total_interes.Location = New System.Drawing.Point(489, 48)
        Me.ume_total_interes.Name = "ume_total_interes"
        Me.ume_total_interes.Size = New System.Drawing.Size(92, 20)
        Me.ume_total_interes.TabIndex = 5
        Me.ume_total_interes.Text = "UltraMaskedEdit1"
        '
        'ubtn_formula
        '
        Me.ubtn_formula.Location = New System.Drawing.Point(638, 48)
        Me.ubtn_formula.Name = "ubtn_formula"
        Me.ubtn_formula.Size = New System.Drawing.Size(91, 23)
        Me.ubtn_formula.TabIndex = 7
        Me.ubtn_formula.Text = "Cronograma"
        '
        'ume_cuota_mensual
        '
        Appearance43.TextHAlignAsString = "Right"
        Me.ume_cuota_mensual.Appearance = Appearance43
        Me.ume_cuota_mensual.EditAs = Infragistics.Win.UltraWinMaskedEdit.EditAsType.UseSpecifiedMask
        Me.ume_cuota_mensual.InputMask = "{double:9.2}"
        Me.ume_cuota_mensual.Location = New System.Drawing.Point(489, 21)
        Me.ume_cuota_mensual.Name = "ume_cuota_mensual"
        Me.ume_cuota_mensual.Size = New System.Drawing.Size(92, 20)
        Me.ume_cuota_mensual.TabIndex = 4
        Me.ume_cuota_mensual.Text = "UltraMaskedEdit1"
        '
        'UltraLabel21
        '
        Appearance28.BackColor = System.Drawing.Color.Transparent
        Appearance28.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel21.Appearance = Appearance28
        Me.UltraLabel21.AutoSize = True
        Me.UltraLabel21.Location = New System.Drawing.Point(394, 51)
        Me.UltraLabel21.Name = "UltraLabel21"
        Me.UltraLabel21.Size = New System.Drawing.Size(67, 14)
        Me.UltraLabel21.TabIndex = 16
        Me.UltraLabel21.Text = "Interes Total"
        '
        'ume_saldo
        '
        Appearance41.TextHAlignAsString = "Right"
        Me.ume_saldo.Appearance = Appearance41
        Me.ume_saldo.EditAs = Infragistics.Win.UltraWinMaskedEdit.EditAsType.UseSpecifiedMask
        Me.ume_saldo.InputMask = "{double:9.2}"
        Me.ume_saldo.Location = New System.Drawing.Point(638, 22)
        Me.ume_saldo.Name = "ume_saldo"
        Me.ume_saldo.Size = New System.Drawing.Size(92, 20)
        Me.ume_saldo.TabIndex = 6
        Me.ume_saldo.Text = "UltraMaskedEdit1"
        '
        'UltraLabel20
        '
        Appearance44.BackColor = System.Drawing.Color.Transparent
        Appearance44.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel20.Appearance = Appearance44
        Me.UltraLabel20.AutoSize = True
        Me.UltraLabel20.Location = New System.Drawing.Point(393, 25)
        Me.UltraLabel20.Name = "UltraLabel20"
        Me.UltraLabel20.Size = New System.Drawing.Size(90, 14)
        Me.UltraLabel20.TabIndex = 16
        Me.UltraLabel20.Text = "Cuota Mensual 1"
        '
        'UltraLabel11
        '
        Appearance42.BackColor = System.Drawing.Color.Transparent
        Appearance42.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel11.Appearance = Appearance42
        Me.UltraLabel11.AutoSize = True
        Me.UltraLabel11.Location = New System.Drawing.Point(599, 24)
        Me.UltraLabel11.Name = "UltraLabel11"
        Me.UltraLabel11.Size = New System.Drawing.Size(33, 14)
        Me.UltraLabel11.TabIndex = 16
        Me.UltraLabel11.Text = "Saldo"
        '
        'ume_monto_total
        '
        Appearance26.TextHAlignAsString = "Right"
        Me.ume_monto_total.Appearance = Appearance26
        Me.ume_monto_total.EditAs = Infragistics.Win.UltraWinMaskedEdit.EditAsType.UseSpecifiedMask
        Me.ume_monto_total.InputMask = "{double:9.2}"
        Me.ume_monto_total.Location = New System.Drawing.Point(290, 48)
        Me.ume_monto_total.Name = "ume_monto_total"
        Me.ume_monto_total.Size = New System.Drawing.Size(92, 20)
        Me.ume_monto_total.TabIndex = 3
        Me.ume_monto_total.Text = "UltraMaskedEdit1"
        '
        'ume_tasaInteres
        '
        Appearance39.TextHAlignAsString = "Right"
        Me.ume_tasaInteres.Appearance = Appearance39
        Me.ume_tasaInteres.EditAs = Infragistics.Win.UltraWinMaskedEdit.EditAsType.UseSpecifiedMask
        Me.ume_tasaInteres.InputMask = "{double:4.3}"
        Me.ume_tasaInteres.Location = New System.Drawing.Point(290, 21)
        Me.ume_tasaInteres.Name = "ume_tasaInteres"
        Me.ume_tasaInteres.Size = New System.Drawing.Size(92, 20)
        Me.ume_tasaInteres.TabIndex = 2
        Me.ume_tasaInteres.Text = "UltraMaskedEdit1"
        '
        'une_num_cuota
        '
        Me.une_num_cuota.Location = New System.Drawing.Point(147, 47)
        Me.une_num_cuota.MaskInput = "nn"
        Me.une_num_cuota.Name = "une_num_cuota"
        Me.une_num_cuota.Size = New System.Drawing.Size(41, 21)
        Me.une_num_cuota.TabIndex = 1
        '
        'ume_Importe
        '
        Appearance37.TextHAlignAsString = "Right"
        Me.ume_Importe.Appearance = Appearance37
        Me.ume_Importe.EditAs = Infragistics.Win.UltraWinMaskedEdit.EditAsType.UseSpecifiedMask
        Me.ume_Importe.InputMask = "{double:9.2}"
        Me.ume_Importe.Location = New System.Drawing.Point(107, 20)
        Me.ume_Importe.Name = "ume_Importe"
        Me.ume_Importe.Size = New System.Drawing.Size(81, 20)
        Me.ume_Importe.TabIndex = 0
        Me.ume_Importe.Text = "UltraMaskedEdit1"
        '
        'UltraLabel19
        '
        Appearance19.BackColor = System.Drawing.Color.Transparent
        Appearance19.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel19.Appearance = Appearance19
        Me.UltraLabel19.AutoSize = True
        Me.UltraLabel19.Location = New System.Drawing.Point(203, 50)
        Me.UltraLabel19.Name = "UltraLabel19"
        Me.UltraLabel19.Size = New System.Drawing.Size(64, 14)
        Me.UltraLabel19.TabIndex = 16
        Me.UltraLabel19.Text = "Monto Total"
        '
        'UltraLabel18
        '
        Appearance40.BackColor = System.Drawing.Color.Transparent
        Appearance40.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel18.Appearance = Appearance40
        Me.UltraLabel18.AutoSize = True
        Me.UltraLabel18.Location = New System.Drawing.Point(203, 23)
        Me.UltraLabel18.Name = "UltraLabel18"
        Me.UltraLabel18.Size = New System.Drawing.Size(83, 14)
        Me.UltraLabel18.TabIndex = 16
        Me.UltraLabel18.Text = "Tasa de Interes"
        '
        'UltraLabel7
        '
        Appearance38.BackColor = System.Drawing.Color.Transparent
        Appearance38.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel7.Appearance = Appearance38
        Me.UltraLabel7.AutoSize = True
        Me.UltraLabel7.Location = New System.Drawing.Point(22, 50)
        Me.UltraLabel7.Name = "UltraLabel7"
        Me.UltraLabel7.Size = New System.Drawing.Size(71, 14)
        Me.UltraLabel7.TabIndex = 16
        Me.UltraLabel7.Text = "N° de Cuotas"
        '
        'UltraLabel12
        '
        Appearance27.BackColor = System.Drawing.Color.Transparent
        Appearance27.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel12.Appearance = Appearance27
        Me.UltraLabel12.AutoSize = True
        Me.UltraLabel12.Location = New System.Drawing.Point(22, 23)
        Me.UltraLabel12.Name = "UltraLabel12"
        Me.UltraLabel12.Size = New System.Drawing.Size(40, 14)
        Me.UltraLabel12.TabIndex = 16
        Me.UltraLabel12.Text = "Capital"
        '
        'UltraTabPageControl3
        '
        Me.UltraTabPageControl3.Controls.Add(Me.ubtn_exportar)
        Me.UltraTabPageControl3.Controls.Add(Me.ubtn_Cancelar)
        Me.UltraTabPageControl3.Controls.Add(Me.ubtn_Mod_Cronograma)
        Me.UltraTabPageControl3.Controls.Add(Me.ubtn_Regresar)
        Me.UltraTabPageControl3.Controls.Add(Me.ugb_Informacion)
        Me.UltraTabPageControl3.Controls.Add(Me.lbl_personal)
        Me.UltraTabPageControl3.Controls.Add(Me.ug_cronograma)
        Me.UltraTabPageControl3.Location = New System.Drawing.Point(1, 23)
        Me.UltraTabPageControl3.Name = "UltraTabPageControl3"
        Me.UltraTabPageControl3.Size = New System.Drawing.Size(776, 369)
        '
        'ubtn_Cancelar
        '
        Me.ubtn_Cancelar.Location = New System.Drawing.Point(280, 16)
        Me.ubtn_Cancelar.Name = "ubtn_Cancelar"
        Me.ubtn_Cancelar.Size = New System.Drawing.Size(90, 29)
        Me.ubtn_Cancelar.TabIndex = 28
        Me.ubtn_Cancelar.Text = "Cancelar"
        Me.ubtn_Cancelar.Visible = False
        '
        'ubtn_Mod_Cronograma
        '
        Me.ubtn_Mod_Cronograma.Location = New System.Drawing.Point(376, 16)
        Me.ubtn_Mod_Cronograma.Name = "ubtn_Mod_Cronograma"
        Me.ubtn_Mod_Cronograma.Size = New System.Drawing.Size(152, 29)
        Me.ubtn_Mod_Cronograma.TabIndex = 27
        Me.ubtn_Mod_Cronograma.Text = "Modificar Cronograma"
        '
        'ubtn_Regresar
        '
        Me.ubtn_Regresar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ubtn_Regresar.Location = New System.Drawing.Point(15, 16)
        Me.ubtn_Regresar.Name = "ubtn_Regresar"
        Me.ubtn_Regresar.Size = New System.Drawing.Size(102, 29)
        Me.ubtn_Regresar.TabIndex = 26
        Me.ubtn_Regresar.Text = "Regresar"
        '
        'ugb_Informacion
        '
        Me.ugb_Informacion.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ugb_Informacion.Controls.Add(Me.ume_cro_fecha_prestamo)
        Me.ugb_Informacion.Controls.Add(Me.UltraLabel17)
        Me.ugb_Informacion.Controls.Add(Me.ume_imp_total)
        Me.ugb_Informacion.Controls.Add(Me.ume_cro_saldo)
        Me.ugb_Informacion.Controls.Add(Me.UltraLabel16)
        Me.ugb_Informacion.Controls.Add(Me.UltraLabel22)
        Me.ugb_Informacion.Controls.Add(Me.UltraLabel15)
        Me.ugb_Informacion.Controls.Add(Me.UltraLabel14)
        Me.ugb_Informacion.Controls.Add(Me.une_cuotas_pen)
        Me.ugb_Informacion.Controls.Add(Me.une_cro_cuotas_can)
        Me.ugb_Informacion.Controls.Add(Me.une_cro_num_cuotas)
        Me.ugb_Informacion.Controls.Add(Me.UltraLabel13)
        Me.ugb_Informacion.Controls.Add(Me.ume_cro_importe)
        Me.ugb_Informacion.Controls.Add(Me.UltraLabel8)
        Me.ugb_Informacion.Location = New System.Drawing.Point(543, 51)
        Me.ugb_Informacion.Name = "ugb_Informacion"
        Me.ugb_Informacion.Size = New System.Drawing.Size(221, 306)
        Me.ugb_Informacion.TabIndex = 25
        Me.ugb_Informacion.Text = "Informacion del Prestamo"
        '
        'ume_cro_fecha_prestamo
        '
        Me.ume_cro_fecha_prestamo.EditAs = Infragistics.Win.UltraWinMaskedEdit.EditAsType.UseSpecifiedMask
        Me.ume_cro_fecha_prestamo.InputMask = "{LOC}dd/mm/yyyy"
        Me.ume_cro_fecha_prestamo.Location = New System.Drawing.Point(112, 31)
        Me.ume_cro_fecha_prestamo.Name = "ume_cro_fecha_prestamo"
        Me.ume_cro_fecha_prestamo.ReadOnly = True
        Me.ume_cro_fecha_prestamo.Size = New System.Drawing.Size(100, 20)
        Me.ume_cro_fecha_prestamo.TabIndex = 24
        Me.ume_cro_fecha_prestamo.Text = "UltraMaskedEdit3"
        '
        'UltraLabel17
        '
        Appearance4.BackColor = System.Drawing.Color.Transparent
        Appearance4.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel17.Appearance = Appearance4
        Me.UltraLabel17.AutoSize = True
        Me.UltraLabel17.Location = New System.Drawing.Point(7, 34)
        Me.UltraLabel17.Name = "UltraLabel17"
        Me.UltraLabel17.Size = New System.Drawing.Size(87, 14)
        Me.UltraLabel17.TabIndex = 23
        Me.UltraLabel17.Text = "Fecha Prestamo"
        '
        'ume_imp_total
        '
        Appearance2.TextHAlignAsString = "Right"
        Me.ume_imp_total.Appearance = Appearance2
        Me.ume_imp_total.EditAs = Infragistics.Win.UltraWinMaskedEdit.EditAsType.UseSpecifiedMask
        Me.ume_imp_total.InputMask = "{double:9.2}"
        Me.ume_imp_total.Location = New System.Drawing.Point(125, 124)
        Me.ume_imp_total.Name = "ume_imp_total"
        Me.ume_imp_total.ReadOnly = True
        Me.ume_imp_total.Size = New System.Drawing.Size(87, 20)
        Me.ume_imp_total.TabIndex = 21
        Me.ume_imp_total.Text = "UltraMaskedEdit1"
        '
        'ume_cro_saldo
        '
        Appearance32.TextHAlignAsString = "Right"
        Me.ume_cro_saldo.Appearance = Appearance32
        Me.ume_cro_saldo.EditAs = Infragistics.Win.UltraWinMaskedEdit.EditAsType.UseSpecifiedMask
        Me.ume_cro_saldo.InputMask = "{double:9.2}"
        Me.ume_cro_saldo.Location = New System.Drawing.Point(125, 150)
        Me.ume_cro_saldo.Name = "ume_cro_saldo"
        Me.ume_cro_saldo.ReadOnly = True
        Me.ume_cro_saldo.Size = New System.Drawing.Size(87, 20)
        Me.ume_cro_saldo.TabIndex = 21
        Me.ume_cro_saldo.Text = "UltraMaskedEdit1"
        '
        'UltraLabel16
        '
        Appearance5.BackColor = System.Drawing.Color.Transparent
        Appearance5.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel16.Appearance = Appearance5
        Me.UltraLabel16.AutoSize = True
        Me.UltraLabel16.Location = New System.Drawing.Point(7, 230)
        Me.UltraLabel16.Name = "UltraLabel16"
        Me.UltraLabel16.Size = New System.Drawing.Size(131, 14)
        Me.UltraLabel16.TabIndex = 22
        Me.UltraLabel16.Text = "Nº de Cuotas Pendientes"
        '
        'UltraLabel22
        '
        Appearance31.BackColor = System.Drawing.Color.Transparent
        Appearance31.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel22.Appearance = Appearance31
        Me.UltraLabel22.AutoSize = True
        Me.UltraLabel22.Location = New System.Drawing.Point(7, 127)
        Me.UltraLabel22.Name = "UltraLabel22"
        Me.UltraLabel22.Size = New System.Drawing.Size(71, 14)
        Me.UltraLabel22.TabIndex = 22
        Me.UltraLabel22.Text = "Importe Total"
        '
        'UltraLabel15
        '
        Appearance30.BackColor = System.Drawing.Color.Transparent
        Appearance30.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel15.Appearance = Appearance30
        Me.UltraLabel15.AutoSize = True
        Me.UltraLabel15.Location = New System.Drawing.Point(7, 203)
        Me.UltraLabel15.Name = "UltraLabel15"
        Me.UltraLabel15.Size = New System.Drawing.Size(118, 14)
        Me.UltraLabel15.TabIndex = 22
        Me.UltraLabel15.Text = "Nº Cuotas Canceladas"
        '
        'UltraLabel14
        '
        Appearance34.BackColor = System.Drawing.Color.Transparent
        Appearance34.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel14.Appearance = Appearance34
        Me.UltraLabel14.AutoSize = True
        Me.UltraLabel14.Location = New System.Drawing.Point(7, 153)
        Me.UltraLabel14.Name = "UltraLabel14"
        Me.UltraLabel14.Size = New System.Drawing.Size(103, 14)
        Me.UltraLabel14.TabIndex = 22
        Me.UltraLabel14.Text = "Saldo del Prestamo"
        '
        'une_cuotas_pen
        '
        Me.une_cuotas_pen.Location = New System.Drawing.Point(171, 226)
        Me.une_cuotas_pen.MaskInput = "nn"
        Me.une_cuotas_pen.Name = "une_cuotas_pen"
        Me.une_cuotas_pen.ReadOnly = True
        Me.une_cuotas_pen.Size = New System.Drawing.Size(41, 21)
        Me.une_cuotas_pen.TabIndex = 19
        '
        'une_cro_cuotas_can
        '
        Me.une_cro_cuotas_can.Location = New System.Drawing.Point(171, 199)
        Me.une_cro_cuotas_can.MaskInput = "nn"
        Me.une_cro_cuotas_can.Name = "une_cro_cuotas_can"
        Me.une_cro_cuotas_can.ReadOnly = True
        Me.une_cro_cuotas_can.Size = New System.Drawing.Size(41, 21)
        Me.une_cro_cuotas_can.TabIndex = 19
        '
        'une_cro_num_cuotas
        '
        Me.une_cro_num_cuotas.Location = New System.Drawing.Point(171, 87)
        Me.une_cro_num_cuotas.MaskInput = "nn"
        Me.une_cro_num_cuotas.Name = "une_cro_num_cuotas"
        Me.une_cro_num_cuotas.ReadOnly = True
        Me.une_cro_num_cuotas.Size = New System.Drawing.Size(41, 21)
        Me.une_cro_num_cuotas.TabIndex = 19
        '
        'UltraLabel13
        '
        Appearance9.BackColor = System.Drawing.Color.Transparent
        Appearance9.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel13.Appearance = Appearance9
        Me.UltraLabel13.AutoSize = True
        Me.UltraLabel13.Location = New System.Drawing.Point(7, 91)
        Me.UltraLabel13.Name = "UltraLabel13"
        Me.UltraLabel13.Size = New System.Drawing.Size(99, 14)
        Me.UltraLabel13.TabIndex = 20
        Me.UltraLabel13.Text = "Numero de Cuotas"
        '
        'ume_cro_importe
        '
        Appearance14.TextHAlignAsString = "Right"
        Me.ume_cro_importe.Appearance = Appearance14
        Me.ume_cro_importe.EditAs = Infragistics.Win.UltraWinMaskedEdit.EditAsType.UseSpecifiedMask
        Me.ume_cro_importe.InputMask = "{double:9.2}"
        Me.ume_cro_importe.Location = New System.Drawing.Point(125, 61)
        Me.ume_cro_importe.Name = "ume_cro_importe"
        Me.ume_cro_importe.ReadOnly = True
        Me.ume_cro_importe.Size = New System.Drawing.Size(87, 20)
        Me.ume_cro_importe.TabIndex = 17
        Me.ume_cro_importe.Text = "UltraMaskedEdit1"
        '
        'UltraLabel8
        '
        Appearance6.BackColor = System.Drawing.Color.Transparent
        Appearance6.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel8.Appearance = Appearance6
        Me.UltraLabel8.AutoSize = True
        Me.UltraLabel8.Location = New System.Drawing.Point(7, 64)
        Me.UltraLabel8.Name = "UltraLabel8"
        Me.UltraLabel8.Size = New System.Drawing.Size(110, 14)
        Me.UltraLabel8.TabIndex = 18
        Me.UltraLabel8.Text = "Importe de Prestamo"
        '
        'lbl_personal
        '
        Me.lbl_personal.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Appearance21.BackColor = System.Drawing.Color.White
        Me.lbl_personal.Appearance = Appearance21
        Me.lbl_personal.BorderStyleInner = Infragistics.Win.UIElementBorderStyle.Solid
        Me.lbl_personal.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_personal.Location = New System.Drawing.Point(15, 51)
        Me.lbl_personal.Name = "lbl_personal"
        Me.lbl_personal.Size = New System.Drawing.Size(520, 23)
        Me.lbl_personal.TabIndex = 1
        '
        'ug_cronograma
        '
        Me.ug_cronograma.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ug_cronograma.DataSource = Me.uds_Cronograma
        Me.ug_cronograma.DisplayLayout.AutoFitStyle = Infragistics.Win.UltraWinGrid.AutoFitStyle.ExtendLastColumn
        UltraGridColumn14.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn14.Header.VisiblePosition = 0
        UltraGridColumn14.Hidden = True
        UltraGridColumn15.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn15.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        Appearance66.TextHAlignAsString = "Center"
        UltraGridColumn15.CellAppearance = Appearance66
        UltraGridColumn15.Header.Caption = "Numero de Cuota"
        UltraGridColumn15.Header.VisiblePosition = 1
        UltraGridColumn15.Width = 38
        UltraGridColumn16.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn16.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        Appearance67.TextHAlignAsString = "Center"
        UltraGridColumn16.CellAppearance = Appearance67
        UltraGridColumn16.Header.Caption = "Fecha de Pago"
        UltraGridColumn16.Header.VisiblePosition = 2
        UltraGridColumn16.Width = 79
        UltraGridColumn17.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn17.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        Appearance68.TextHAlignAsString = "Right"
        UltraGridColumn17.CellAppearance = Appearance68
        UltraGridColumn17.Header.Caption = "Importe a Pagar"
        UltraGridColumn17.Header.VisiblePosition = 6
        UltraGridColumn17.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Double]
        UltraGridColumn17.Width = 72
        UltraGridColumn18.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn18.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn18.Header.Caption = "Cancelado"
        UltraGridColumn18.Header.VisiblePosition = 7
        UltraGridColumn18.Width = 65
        UltraGridColumn19.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn19.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn19.Header.Caption = "No Considerar"
        UltraGridColumn19.Header.VisiblePosition = 8
        UltraGridColumn19.Width = 64
        UltraGridColumn20.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn20.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        Appearance69.TextHAlignAsString = "Right"
        UltraGridColumn20.CellAppearance = Appearance69
        UltraGridColumn20.Header.Caption = "Capital"
        UltraGridColumn20.Header.VisiblePosition = 3
        UltraGridColumn20.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Double]
        UltraGridColumn20.Width = 59
        UltraGridColumn21.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn21.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        Appearance70.TextHAlignAsString = "Right"
        UltraGridColumn21.CellAppearance = Appearance70
        UltraGridColumn21.Header.Caption = "Cuota"
        UltraGridColumn21.Header.VisiblePosition = 4
        UltraGridColumn21.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Double]
        UltraGridColumn21.Width = 64
        UltraGridColumn22.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn22.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        Appearance71.TextHAlignAsString = "Right"
        UltraGridColumn22.CellAppearance = Appearance71
        UltraGridColumn22.Header.Caption = "Interes"
        UltraGridColumn22.Header.VisiblePosition = 5
        UltraGridColumn22.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Double]
        UltraGridColumn22.Width = 58
        UltraGridBand2.Columns.AddRange(New Object() {UltraGridColumn14, UltraGridColumn15, UltraGridColumn16, UltraGridColumn17, UltraGridColumn18, UltraGridColumn19, UltraGridColumn20, UltraGridColumn21, UltraGridColumn22})
        Appearance72.BackColor = System.Drawing.Color.White
        Appearance72.FontData.BoldAsString = "True"
        Appearance72.FontData.SizeInPoints = 10.0!
        Appearance72.ForeColor = System.Drawing.Color.Navy
        Appearance72.TextHAlignAsString = "Right"
        SummarySettings1.Appearance = Appearance72
        SummarySettings1.DisplayFormat = "{0:##,##0.00#}"
        SummarySettings1.GroupBySummaryValueAppearance = Appearance73
        SummarySettings1.SummaryDisplayArea = Infragistics.Win.UltraWinGrid.SummaryDisplayAreas.BottomFixed
        Appearance74.BackColor = System.Drawing.Color.White
        Appearance74.FontData.BoldAsString = "True"
        Appearance74.FontData.SizeInPoints = 10.0!
        Appearance74.ForeColor = System.Drawing.Color.Navy
        Appearance74.TextHAlignAsString = "Right"
        SummarySettings2.Appearance = Appearance74
        SummarySettings2.DisplayFormat = "{0:##,##0.00#}"
        SummarySettings2.GroupBySummaryValueAppearance = Appearance75
        SummarySettings2.SummaryDisplayArea = Infragistics.Win.UltraWinGrid.SummaryDisplayAreas.BottomFixed
        Appearance76.BackColor = System.Drawing.Color.White
        Appearance76.FontData.BoldAsString = "True"
        Appearance76.FontData.SizeInPoints = 10.0!
        Appearance76.ForeColor = System.Drawing.Color.Navy
        Appearance76.TextHAlignAsString = "Right"
        SummarySettings3.Appearance = Appearance76
        SummarySettings3.DisplayFormat = "{0:##,##0.00#}"
        SummarySettings3.GroupBySummaryValueAppearance = Appearance77
        SummarySettings3.SummaryDisplayArea = Infragistics.Win.UltraWinGrid.SummaryDisplayAreas.BottomFixed
        UltraGridBand2.Summaries.AddRange(New Infragistics.Win.UltraWinGrid.SummarySettings() {SummarySettings1, SummarySettings2, SummarySettings3})
        UltraGridBand2.SummaryFooterCaption = "Totales"
        Me.ug_cronograma.DisplayLayout.BandsSerializer.Add(UltraGridBand2)
        Me.ug_cronograma.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.[False]
        Me.ug_cronograma.DisplayLayout.MaxColScrollRegions = 1
        Me.ug_cronograma.DisplayLayout.MaxRowScrollRegions = 1
        Me.ug_cronograma.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.ug_cronograma.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ug_cronograma.Location = New System.Drawing.Point(15, 80)
        Me.ug_cronograma.Name = "ug_cronograma"
        Me.ug_cronograma.Size = New System.Drawing.Size(520, 277)
        Me.ug_cronograma.TabIndex = 0
        Me.ug_cronograma.Text = "UltraGrid1"
        '
        'uds_Cronograma
        '
        UltraDataColumn14.DataType = GetType(Integer)
        UltraDataColumn15.DataType = GetType(Short)
        UltraDataColumn16.DataType = GetType(Date)
        UltraDataColumn17.DataType = GetType(Double)
        UltraDataColumn18.DataType = GetType(Boolean)
        UltraDataColumn19.DataType = GetType(Boolean)
        UltraDataColumn20.DataType = GetType(Double)
        UltraDataColumn21.DataType = GetType(Double)
        UltraDataColumn22.DataType = GetType(Double)
        Me.uds_Cronograma.Band.Columns.AddRange(New Object() {UltraDataColumn14, UltraDataColumn15, UltraDataColumn16, UltraDataColumn17, UltraDataColumn18, UltraDataColumn19, UltraDataColumn20, UltraDataColumn21, UltraDataColumn22})
        '
        'ToolS_Mantenimiento
        '
        Me.ToolS_Mantenimiento.BackColor = System.Drawing.Color.White
        Me.ToolS_Mantenimiento.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Tool_Nuevo, Me.ToolStripSeparator1, Me.Tool_Grabar, Me.ToolStripSeparator3, Me.Tool_Editar, Me.ToolStripSeparator4, Me.Tool_Cancelar, Me.ToolStripSeparator2, Me.Tool_Eliminar, Me.ToolStripSeparator5, Me.Tool_Salir})
        Me.ToolS_Mantenimiento.Location = New System.Drawing.Point(0, 0)
        Me.ToolS_Mantenimiento.Name = "ToolS_Mantenimiento"
        Me.ToolS_Mantenimiento.Size = New System.Drawing.Size(804, 25)
        Me.ToolS_Mantenimiento.TabIndex = 9
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
        Me.Tool_Grabar.ToolTipText = "Grabar (F4)"
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
        'utc_Cta_Cte
        '
        Me.utc_Cta_Cte.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.utc_Cta_Cte.Controls.Add(Me.UltraTabSharedControlsPage1)
        Me.utc_Cta_Cte.Controls.Add(Me.UltraTabPageControl1)
        Me.utc_Cta_Cte.Controls.Add(Me.UltraTabPageControl2)
        Me.utc_Cta_Cte.Controls.Add(Me.UltraTabPageControl3)
        Me.utc_Cta_Cte.Location = New System.Drawing.Point(12, 38)
        Me.utc_Cta_Cte.Name = "utc_Cta_Cte"
        Me.utc_Cta_Cte.SharedControlsPage = Me.UltraTabSharedControlsPage1
        Me.utc_Cta_Cte.Size = New System.Drawing.Size(780, 395)
        Me.utc_Cta_Cte.TabIndex = 10
        UltraTab1.TabPage = Me.UltraTabPageControl1
        UltraTab1.Text = "Listado de Cta Ctes"
        UltraTab2.TabPage = Me.UltraTabPageControl2
        UltraTab2.Text = "Ingreso / Edicion de Datos"
        UltraTab3.TabPage = Me.UltraTabPageControl3
        UltraTab3.Text = "Cronograma"
        Me.utc_Cta_Cte.Tabs.AddRange(New Infragistics.Win.UltraWinTabControl.UltraTab() {UltraTab1, UltraTab2, UltraTab3})
        '
        'UltraTabSharedControlsPage1
        '
        Me.UltraTabSharedControlsPage1.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabSharedControlsPage1.Name = "UltraTabSharedControlsPage1"
        Me.UltraTabSharedControlsPage1.Size = New System.Drawing.Size(776, 369)
        '
        'ubtn_exportar
        '
        Me.ubtn_exportar.Location = New System.Drawing.Point(199, 16)
        Me.ubtn_exportar.Name = "ubtn_exportar"
        Me.ubtn_exportar.Size = New System.Drawing.Size(75, 29)
        Me.ubtn_exportar.TabIndex = 29
        Me.ubtn_exportar.Text = "Exportar "
        '
        'PL_PR_CuentaCorriente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(804, 440)
        Me.Controls.Add(Me.utc_Cta_Cte)
        Me.Controls.Add(Me.ToolS_Mantenimiento)
        Me.Name = "PL_PR_CuentaCorriente"
        Me.Text = "Prestamos al Personal"
        Me.UltraTabPageControl1.ResumeLayout(False)
        CType(Me.uos_estado, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ug_listado_cta_cte, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.uds_Listado_CtaCte, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabPageControl2.ResumeLayout(False)
        CType(Me.ugb_datos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ugb_datos.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        CType(Me.une_num_recibo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_ser_doc, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_des_doc, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_tip_doc, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.txt_id_registro, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_id_personal, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.uce_Moneda, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.uce_Motivo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_nombres, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_cod_personal, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.udte_fecha_Reg, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.uce_estado, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_obs, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.une_num_cuota, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabPageControl3.ResumeLayout(False)
        CType(Me.ugb_Informacion, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ugb_Informacion.ResumeLayout(False)
        Me.ugb_Informacion.PerformLayout()
        CType(Me.une_cuotas_pen, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.une_cro_cuotas_can, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.une_cro_num_cuotas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ug_cronograma, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.uds_Cronograma, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolS_Mantenimiento.ResumeLayout(False)
        Me.ToolS_Mantenimiento.PerformLayout()
        CType(Me.utc_Cta_Cte, System.ComponentModel.ISupportInitialize).EndInit()
        Me.utc_Cta_Cte.ResumeLayout(False)
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
    Friend WithEvents utc_Cta_Cte As Infragistics.Win.UltraWinTabControl.UltraTabControl
    Friend WithEvents UltraTabSharedControlsPage1 As Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage
    Friend WithEvents UltraTabPageControl1 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents UltraTabPageControl2 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents ug_listado_cta_cte As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents uds_Listado_CtaCte As Infragistics.Win.UltraWinDataSource.UltraDataSource
    Friend WithEvents ugb_datos As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents UltraLabel10 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel1 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents udte_fecha_Reg As Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
    Friend WithEvents txt_nombres As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents txt_id_personal As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents txt_cod_personal As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents UltraLabel2 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel3 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents uce_Motivo As Infragistics.Win.UltraWinEditors.UltraComboEditor
    Friend WithEvents uchk_Afecta As Infragistics.Win.UltraWinEditors.UltraCheckEditor
    Friend WithEvents UltraLabel4 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents uce_Moneda As Infragistics.Win.UltraWinEditors.UltraComboEditor
    Friend WithEvents ume_tipoCambio As Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit
    Friend WithEvents ume_Importe As Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit
    Friend WithEvents UltraLabel6 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel5 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents une_num_cuota As Infragistics.Win.UltraWinEditors.UltraNumericEditor
    Friend WithEvents UltraLabel7 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel11 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel9 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents ume_saldo As Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit
    Friend WithEvents uce_estado As Infragistics.Win.UltraWinEditors.UltraComboEditor
    Friend WithEvents txt_obs As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents UltraLabel12 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents txt_id_registro As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents UltraTabPageControl3 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents uds_Cronograma As Infragistics.Win.UltraWinDataSource.UltraDataSource
    Friend WithEvents lbl_personal As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents ug_cronograma As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents ume_cro_importe As Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit
    Friend WithEvents UltraLabel8 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents une_cro_num_cuotas As Infragistics.Win.UltraWinEditors.UltraNumericEditor
    Friend WithEvents UltraLabel13 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents ume_cro_saldo As Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit
    Friend WithEvents UltraLabel14 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents ume_cro_fecha_prestamo As Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit
    Friend WithEvents UltraLabel17 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel16 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel15 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents une_cuotas_pen As Infragistics.Win.UltraWinEditors.UltraNumericEditor
    Friend WithEvents une_cro_cuotas_can As Infragistics.Win.UltraWinEditors.UltraNumericEditor
    Friend WithEvents ubtn_Cronograma As Infragistics.Win.Misc.UltraButton
    Friend WithEvents ugb_Informacion As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents ubtn_Regresar As Infragistics.Win.Misc.UltraButton
    Friend WithEvents ubtn_Mod_Cronograma As Infragistics.Win.Misc.UltraButton
    Friend WithEvents ubtn_Cancelar As Infragistics.Win.Misc.UltraButton
    Friend WithEvents ume_tasaInteres As Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit
    Friend WithEvents UltraLabel18 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents ume_monto_total As Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit
    Friend WithEvents UltraLabel19 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents txt_ser_doc As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents txt_des_doc As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents txt_tip_doc As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents ubtn_formula As Infragistics.Win.Misc.UltraButton
    Friend WithEvents ume_cuota_mensual As Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit
    Friend WithEvents UltraLabel20 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents ume_total_interes As Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit
    Friend WithEvents UltraLabel21 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents ume_imp_total As Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit
    Friend WithEvents UltraLabel22 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents uos_estado As Infragistics.Win.UltraWinEditors.UltraOptionSet
    Friend WithEvents ubtn_Anular As Infragistics.Win.Misc.UltraButton
    Friend WithEvents une_num_recibo As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents UltraLabel24 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel23 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents ubtn_exportar As Infragistics.Win.Misc.UltraButton
    Friend WithEvents uge_ctacor As Infragistics.Win.UltraWinGrid.ExcelExport.UltraGridExcelExporter
End Class
