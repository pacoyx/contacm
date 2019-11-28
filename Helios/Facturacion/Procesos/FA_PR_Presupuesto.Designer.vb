<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FA_PR_Presupuesto
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
        Dim UltraGridColumn1 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("PR_ID")
        Dim UltraGridColumn2 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("PR_IDSEGURO")
        Dim UltraGridColumn3 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("PR_IDNUMHIST")
        Dim UltraGridColumn4 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("PR_IDCLIENTE")
        Dim UltraGridColumn5 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CL_NDOC")
        Dim UltraGridColumn6 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CL_NOMBRE")
        Dim UltraGridColumn7 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("SEGURO")
        Dim UltraGridColumn8 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("PR_IDMEDICO")
        Dim UltraGridColumn9 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("PR_IDPAQUETE")
        Dim UltraGridColumn10 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("PR_COPG_FIJO")
        Dim UltraGridColumn11 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("PR_COPG_VARI")
        Dim UltraGridColumn12 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("PR_ESTADO_PRE")
        Dim UltraGridColumn13 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("PR_FECHA")
        Dim Appearance9 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraDataColumn1 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("PR_ID")
        Dim UltraDataColumn2 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("PR_IDSEGURO")
        Dim UltraDataColumn3 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("PR_IDNUMHIST")
        Dim UltraDataColumn4 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("PR_IDCLIENTE")
        Dim UltraDataColumn5 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("CL_NDOC")
        Dim UltraDataColumn6 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("CL_NOMBRE")
        Dim UltraDataColumn7 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("SEGURO")
        Dim UltraDataColumn8 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("PR_IDMEDICO")
        Dim UltraDataColumn9 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("PR_IDPAQUETE")
        Dim UltraDataColumn10 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("PR_COPG_FIJO")
        Dim UltraDataColumn11 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("PR_COPG_VARI")
        Dim UltraDataColumn12 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("PR_ESTADO_PRE")
        Dim UltraDataColumn13 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("PR_FECHA")
        Dim Appearance24 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance45 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance28 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim ValueListItem5 As Infragistics.Win.ValueListItem = New Infragistics.Win.ValueListItem()
        Dim ValueListItem6 As Infragistics.Win.ValueListItem = New Infragistics.Win.ValueListItem()
        Dim EditorButton1 As Infragistics.Win.UltraWinEditors.EditorButton = New Infragistics.Win.UltraWinEditors.EditorButton("ayuda")
        Dim Appearance2 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance40 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance12 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim EditorButton2 As Infragistics.Win.UltraWinEditors.EditorButton = New Infragistics.Win.UltraWinEditors.EditorButton("ayuda")
        Dim Appearance10 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance21 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim EditorButton3 As Infragistics.Win.UltraWinEditors.EditorButton = New Infragistics.Win.UltraWinEditors.EditorButton("ayuda")
        Dim Appearance30 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridBand2 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1)
        Dim UltraGridColumn14 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Cant")
        Dim Appearance5 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance6 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn15 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id_Articulo")
        Dim UltraGridColumn16 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Codigo")
        Dim UltraGridColumn17 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Descripcion")
        Dim UltraGridColumn18 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Costo")
        Dim Appearance7 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn19 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CD_SEG_CUBRE")
        Dim UltraGridColumn20 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CD_DEDUCIBLE")
        Dim Appearance8 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn21 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Descuento")
        Dim Appearance11 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn22 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CD_DSCTO_OTRO")
        Dim Appearance13 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn23 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("SubTotal")
        Dim Appearance14 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn24 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IGV")
        Dim Appearance19 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn25 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Total")
        Dim Appearance20 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn26 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("idConsulta")
        Dim UltraGridColumn27 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CD_IDCOMPROBANTE")
        Dim UltraGridColumn28 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CD_ITEM")
        Dim UltraGridColumn29 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CD_SINPAGO")
        Dim UltraGridColumn30 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CD_DSCTO_PORC")
        Dim UltraDataColumn14 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Cant")
        Dim UltraDataColumn15 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Id_Articulo")
        Dim UltraDataColumn16 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Codigo")
        Dim UltraDataColumn17 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Descripcion")
        Dim UltraDataColumn18 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Costo")
        Dim UltraDataColumn19 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("CD_SEG_CUBRE")
        Dim UltraDataColumn20 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("CD_DEDUCIBLE")
        Dim UltraDataColumn21 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Descuento")
        Dim UltraDataColumn22 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("CD_DSCTO_OTRO")
        Dim UltraDataColumn23 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("SubTotal")
        Dim UltraDataColumn24 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IGV")
        Dim UltraDataColumn25 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Total")
        Dim UltraDataColumn26 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("idConsulta")
        Dim UltraDataColumn27 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("CD_IDCOMPROBANTE")
        Dim UltraDataColumn28 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("CD_ITEM")
        Dim UltraDataColumn29 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("CD_SINPAGO")
        Dim UltraDataColumn30 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("CD_DSCTO_PORC")
        Dim Appearance18 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance27 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance23 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance32 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance41 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance4 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance17 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance16 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance15 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance72 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance3 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance1 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraTab1 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraTab2 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Me.UltraTabPageControl1 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.ug_Lista = New Infragistics.Win.UltraWinGrid.UltraGrid()
        Me.uds_Lista = New Infragistics.Win.UltraWinDataSource.UltraDataSource(Me.components)
        Me.UltraTabPageControl2 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.ugb_Datos = New Infragistics.Win.Misc.UltraGroupBox()
        Me.UltraLabel8 = New Infragistics.Win.Misc.UltraLabel()
        Me.txt_idTratamiento = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.UltraLabel3 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraLabel7 = New Infragistics.Win.Misc.UltraLabel()
        Me.ucbo_Estado = New Infragistics.Win.UltraWinEditors.UltraComboEditor()
        Me.txt_Des_ClienteC = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.uce_tip_doc = New Infragistics.Win.UltraWinEditors.UltraComboEditor()
        Me.txt_Des_Cliente = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.txt_ruc_cliente = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.UltraLabel20 = New Infragistics.Win.Misc.UltraLabel()
        Me.txt_IdCliente = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.UltraLabel4 = New Infragistics.Win.Misc.UltraLabel()
        Me.txt_idHistoria = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.txt_idClienteC = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.txt_Ruc_ClientesC = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.UltraLabel5 = New Infragistics.Win.Misc.UltraLabel()
        Me.txt_Tratamiento = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.uce_Medico = New Infragistics.Win.UltraWinEditors.UltraComboEditor()
        Me.ug_detalle = New Infragistics.Win.UltraWinGrid.UltraGrid()
        Me.uds_detalle = New Infragistics.Win.UltraWinDataSource.UltraDataSource(Me.components)
        Me.ubt_Quitar = New Infragistics.Win.Misc.UltraButton()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.UltraLabel2 = New Infragistics.Win.Misc.UltraLabel()
        Me.udte_fecha = New Infragistics.Win.UltraWinEditors.UltraDateTimeEditor()
        Me.ugb_Cuenta = New Infragistics.Win.Misc.UltraGroupBox()
        Me.UltraLabel9 = New Infragistics.Win.Misc.UltraLabel()
        Me.txt_PagoFijo = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.txt_PagoVariable = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.UltraLabel10 = New Infragistics.Win.Misc.UltraLabel()
        Me.ubt_Agregar = New Infragistics.Win.Misc.UltraButton()
        Me.ucm_SeguroEps = New Infragistics.Win.UltraWinEditors.UltraComboEditor()
        Me.uchk_SeguroEps = New Infragistics.Win.UltraWinEditors.UltraCheckEditor()
        Me.UltraLabel6 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraLabel1 = New Infragistics.Win.Misc.UltraLabel()
        Me.txt_idPresupuesto = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.txt_Total = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.txt_IGV = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.txt_SubTotal = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.UltraLabel24 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraLabel32 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraLabel25 = New Infragistics.Win.Misc.UltraLabel()
        Me.ToolS_Mantenimiento = New System.Windows.Forms.ToolStrip()
        Me.Tool_Nuevo = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.Tool_Grabar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.Tool_Editar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.Tool_Cancelar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.Tool_Eliminar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator()
        Me.Tool_Salir = New System.Windows.Forms.ToolStripButton()
        Me.utc_Datos = New Infragistics.Win.UltraWinTabControl.UltraTabControl()
        Me.UltraTabSharedControlsPage1 = New Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage()
        Me.UltraTabPageControl1.SuspendLayout()
        CType(Me.ug_Lista, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.uds_Lista, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabPageControl2.SuspendLayout()
        CType(Me.ugb_Datos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ugb_Datos.SuspendLayout()
        CType(Me.txt_idTratamiento, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ucbo_Estado, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_Des_ClienteC, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.uce_tip_doc, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_Des_Cliente, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_ruc_cliente, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_IdCliente, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_idHistoria, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_idClienteC, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_Ruc_ClientesC, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_Tratamiento, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.uce_Medico, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ug_detalle, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.uds_detalle, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.udte_fecha, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ugb_Cuenta, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ugb_Cuenta.SuspendLayout()
        CType(Me.txt_PagoFijo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_PagoVariable, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ucm_SeguroEps, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_idPresupuesto, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_Total, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_IGV, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_SubTotal, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolS_Mantenimiento.SuspendLayout()
        CType(Me.utc_Datos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.utc_Datos.SuspendLayout()
        Me.SuspendLayout()
        '
        'UltraTabPageControl1
        '
        Me.UltraTabPageControl1.Controls.Add(Me.ug_Lista)
        Me.UltraTabPageControl1.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl1.Name = "UltraTabPageControl1"
        Me.UltraTabPageControl1.Size = New System.Drawing.Size(881, 554)
        '
        'ug_Lista
        '
        Me.ug_Lista.DataSource = Me.uds_Lista
        Me.ug_Lista.DisplayLayout.AutoFitStyle = Infragistics.Win.UltraWinGrid.AutoFitStyle.ExtendLastColumn
        UltraGridColumn1.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn1.Header.Caption = "CÓDIGO"
        UltraGridColumn1.Header.VisiblePosition = 0
        UltraGridColumn1.Width = 65
        UltraGridColumn2.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn2.Header.VisiblePosition = 1
        UltraGridColumn2.Hidden = True
        UltraGridColumn3.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn3.Header.VisiblePosition = 2
        UltraGridColumn3.Hidden = True
        UltraGridColumn4.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn4.Header.VisiblePosition = 3
        UltraGridColumn4.Hidden = True
        UltraGridColumn5.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn5.Header.Caption = "N° DOC"
        UltraGridColumn5.Header.VisiblePosition = 4
        UltraGridColumn6.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn6.Header.Caption = "PACIENTE"
        UltraGridColumn6.Header.VisiblePosition = 5
        UltraGridColumn6.Width = 320
        UltraGridColumn7.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn7.Header.VisiblePosition = 6
        UltraGridColumn7.Width = 200
        UltraGridColumn8.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn8.Header.VisiblePosition = 7
        UltraGridColumn8.Hidden = True
        UltraGridColumn9.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn9.Header.VisiblePosition = 8
        UltraGridColumn9.Hidden = True
        UltraGridColumn10.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn10.Header.VisiblePosition = 9
        UltraGridColumn10.Hidden = True
        UltraGridColumn11.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn11.Header.VisiblePosition = 10
        UltraGridColumn11.Hidden = True
        UltraGridColumn12.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn12.Header.Caption = "ESTADO"
        UltraGridColumn12.Header.VisiblePosition = 11
        UltraGridColumn12.Width = 100
        UltraGridColumn13.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn13.Header.Caption = "FECHA"
        UltraGridColumn13.Header.VisiblePosition = 12
        UltraGridColumn13.Width = 90
        UltraGridBand1.Columns.AddRange(New Object() {UltraGridColumn1, UltraGridColumn2, UltraGridColumn3, UltraGridColumn4, UltraGridColumn5, UltraGridColumn6, UltraGridColumn7, UltraGridColumn8, UltraGridColumn9, UltraGridColumn10, UltraGridColumn11, UltraGridColumn12, UltraGridColumn13})
        Me.ug_Lista.DisplayLayout.BandsSerializer.Add(UltraGridBand1)
        Me.ug_Lista.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.[False]
        Me.ug_Lista.DisplayLayout.MaxColScrollRegions = 1
        Me.ug_Lista.DisplayLayout.MaxRowScrollRegions = 1
        Appearance9.BackColor = System.Drawing.Color.WhiteSmoke
        Appearance9.BackColor2 = System.Drawing.Color.WhiteSmoke
        Me.ug_Lista.DisplayLayout.Override.RowAlternateAppearance = Appearance9
        Me.ug_Lista.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.ug_Lista.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.ug_Lista.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ug_Lista.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ug_Lista.Location = New System.Drawing.Point(0, 0)
        Me.ug_Lista.Name = "ug_Lista"
        Me.ug_Lista.Size = New System.Drawing.Size(881, 554)
        Me.ug_Lista.TabIndex = 0
        Me.ug_Lista.Text = "UltraGrid1"
        '
        'uds_Lista
        '
        Me.uds_Lista.AllowDelete = False
        UltraDataColumn1.DataType = GetType(Long)
        UltraDataColumn2.DataType = GetType(Integer)
        UltraDataColumn3.DataType = GetType(Integer)
        UltraDataColumn4.DataType = GetType(Integer)
        UltraDataColumn9.DataType = GetType(Integer)
        UltraDataColumn10.DataType = GetType(Decimal)
        UltraDataColumn11.DataType = GetType(Decimal)
        Me.uds_Lista.Band.Columns.AddRange(New Object() {UltraDataColumn1, UltraDataColumn2, UltraDataColumn3, UltraDataColumn4, UltraDataColumn5, UltraDataColumn6, UltraDataColumn7, UltraDataColumn8, UltraDataColumn9, UltraDataColumn10, UltraDataColumn11, UltraDataColumn12, UltraDataColumn13})
        '
        'UltraTabPageControl2
        '
        Me.UltraTabPageControl2.Controls.Add(Me.ugb_Datos)
        Me.UltraTabPageControl2.Controls.Add(Me.txt_Total)
        Me.UltraTabPageControl2.Controls.Add(Me.txt_IGV)
        Me.UltraTabPageControl2.Controls.Add(Me.txt_SubTotal)
        Me.UltraTabPageControl2.Controls.Add(Me.UltraLabel24)
        Me.UltraTabPageControl2.Controls.Add(Me.UltraLabel32)
        Me.UltraTabPageControl2.Controls.Add(Me.UltraLabel25)
        Me.UltraTabPageControl2.Location = New System.Drawing.Point(1, 23)
        Me.UltraTabPageControl2.Name = "UltraTabPageControl2"
        Me.UltraTabPageControl2.Size = New System.Drawing.Size(881, 554)
        '
        'ugb_Datos
        '
        Me.ugb_Datos.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ugb_Datos.Controls.Add(Me.UltraLabel8)
        Me.ugb_Datos.Controls.Add(Me.txt_idTratamiento)
        Me.ugb_Datos.Controls.Add(Me.UltraLabel3)
        Me.ugb_Datos.Controls.Add(Me.UltraLabel7)
        Me.ugb_Datos.Controls.Add(Me.ucbo_Estado)
        Me.ugb_Datos.Controls.Add(Me.txt_Des_ClienteC)
        Me.ugb_Datos.Controls.Add(Me.uce_tip_doc)
        Me.ugb_Datos.Controls.Add(Me.txt_Des_Cliente)
        Me.ugb_Datos.Controls.Add(Me.txt_ruc_cliente)
        Me.ugb_Datos.Controls.Add(Me.UltraLabel20)
        Me.ugb_Datos.Controls.Add(Me.txt_IdCliente)
        Me.ugb_Datos.Controls.Add(Me.UltraLabel4)
        Me.ugb_Datos.Controls.Add(Me.txt_idHistoria)
        Me.ugb_Datos.Controls.Add(Me.txt_idClienteC)
        Me.ugb_Datos.Controls.Add(Me.txt_Ruc_ClientesC)
        Me.ugb_Datos.Controls.Add(Me.UltraLabel5)
        Me.ugb_Datos.Controls.Add(Me.txt_Tratamiento)
        Me.ugb_Datos.Controls.Add(Me.uce_Medico)
        Me.ugb_Datos.Controls.Add(Me.ug_detalle)
        Me.ugb_Datos.Controls.Add(Me.ubt_Quitar)
        Me.ugb_Datos.Controls.Add(Me.Panel2)
        Me.ugb_Datos.Controls.Add(Me.UltraLabel2)
        Me.ugb_Datos.Controls.Add(Me.udte_fecha)
        Me.ugb_Datos.Controls.Add(Me.ugb_Cuenta)
        Me.ugb_Datos.Controls.Add(Me.ubt_Agregar)
        Me.ugb_Datos.Controls.Add(Me.ucm_SeguroEps)
        Me.ugb_Datos.Controls.Add(Me.uchk_SeguroEps)
        Me.ugb_Datos.Controls.Add(Me.UltraLabel6)
        Me.ugb_Datos.Controls.Add(Me.UltraLabel1)
        Me.ugb_Datos.Controls.Add(Me.txt_idPresupuesto)
        Me.ugb_Datos.Location = New System.Drawing.Point(-1, 1)
        Me.ugb_Datos.Name = "ugb_Datos"
        Me.ugb_Datos.Size = New System.Drawing.Size(879, 519)
        Me.ugb_Datos.TabIndex = 33
        '
        'UltraLabel8
        '
        Appearance24.BackColor = System.Drawing.Color.Transparent
        Appearance24.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel8.Appearance = Appearance24
        Me.UltraLabel8.AutoSize = True
        Me.UltraLabel8.Location = New System.Drawing.Point(440, 173)
        Me.UltraLabel8.Name = "UltraLabel8"
        Me.UltraLabel8.Size = New System.Drawing.Size(65, 14)
        Me.UltraLabel8.TabIndex = 183
        Me.UltraLabel8.Text = "Tratamiento"
        '
        'txt_idTratamiento
        '
        Me.txt_idTratamiento.Location = New System.Drawing.Point(768, 143)
        Me.txt_idTratamiento.Name = "txt_idTratamiento"
        Me.txt_idTratamiento.Size = New System.Drawing.Size(22, 21)
        Me.txt_idTratamiento.TabIndex = 182
        Me.txt_idTratamiento.Visible = False
        '
        'UltraLabel3
        '
        Appearance45.BackColor = System.Drawing.Color.Transparent
        Appearance45.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel3.Appearance = Appearance45
        Me.UltraLabel3.AutoSize = True
        Me.UltraLabel3.Location = New System.Drawing.Point(30, 44)
        Me.UltraLabel3.Name = "UltraLabel3"
        Me.UltraLabel3.Size = New System.Drawing.Size(107, 14)
        Me.UltraLabel3.TabIndex = 181
        Me.UltraLabel3.Text = "Código Presupuesto"
        '
        'UltraLabel7
        '
        Appearance28.BackColor = System.Drawing.Color.Transparent
        Appearance28.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel7.Appearance = Appearance28
        Me.UltraLabel7.AutoSize = True
        Me.UltraLabel7.Location = New System.Drawing.Point(239, 119)
        Me.UltraLabel7.Name = "UltraLabel7"
        Me.UltraLabel7.Size = New System.Drawing.Size(39, 14)
        Me.UltraLabel7.TabIndex = 180
        Me.UltraLabel7.Text = "Estado"
        '
        'ucbo_Estado
        '
        Me.ucbo_Estado.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        ValueListItem5.DataValue = "1"
        ValueListItem5.DisplayText = "Pendiente"
        ValueListItem6.DataValue = "2"
        ValueListItem6.DisplayText = "Facturado"
        Me.ucbo_Estado.Items.AddRange(New Infragistics.Win.ValueListItem() {ValueListItem5, ValueListItem6})
        Me.ucbo_Estado.Location = New System.Drawing.Point(286, 115)
        Me.ucbo_Estado.Name = "ucbo_Estado"
        Me.ucbo_Estado.ReadOnly = True
        Me.ucbo_Estado.Size = New System.Drawing.Size(124, 21)
        Me.ucbo_Estado.TabIndex = 6
        '
        'txt_Des_ClienteC
        '
        Me.txt_Des_ClienteC.Location = New System.Drawing.Point(382, 65)
        Me.txt_Des_ClienteC.Name = "txt_Des_ClienteC"
        Me.txt_Des_ClienteC.ReadOnly = True
        Me.txt_Des_ClienteC.Size = New System.Drawing.Size(484, 21)
        Me.txt_Des_ClienteC.TabIndex = 169
        '
        'uce_tip_doc
        '
        Me.uce_tip_doc.DropDownListWidth = 300
        Me.uce_tip_doc.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.uce_tip_doc.Location = New System.Drawing.Point(216, 40)
        Me.uce_tip_doc.Name = "uce_tip_doc"
        Me.uce_tip_doc.Size = New System.Drawing.Size(63, 21)
        Me.uce_tip_doc.TabIndex = 1
        '
        'txt_Des_Cliente
        '
        Me.txt_Des_Cliente.Location = New System.Drawing.Point(382, 40)
        Me.txt_Des_Cliente.Name = "txt_Des_Cliente"
        Me.txt_Des_Cliente.ReadOnly = True
        Me.txt_Des_Cliente.Size = New System.Drawing.Size(335, 21)
        Me.txt_Des_Cliente.TabIndex = 176
        '
        'txt_ruc_cliente
        '
        Appearance2.ImageHAlign = Infragistics.Win.HAlign.Center
        Appearance2.ImageVAlign = Infragistics.Win.VAlign.Middle
        EditorButton1.Appearance = Appearance2
        EditorButton1.Key = "ayuda"
        Me.txt_ruc_cliente.ButtonsRight.Add(EditorButton1)
        Me.txt_ruc_cliente.Location = New System.Drawing.Point(279, 40)
        Me.txt_ruc_cliente.MaxLength = 11
        Me.txt_ruc_cliente.Name = "txt_ruc_cliente"
        Me.txt_ruc_cliente.Size = New System.Drawing.Size(102, 21)
        Me.txt_ruc_cliente.TabIndex = 2
        '
        'UltraLabel20
        '
        Appearance40.BackColor = System.Drawing.Color.Transparent
        Appearance40.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel20.Appearance = Appearance40
        Me.UltraLabel20.AutoSize = True
        Me.UltraLabel20.Location = New System.Drawing.Point(166, 44)
        Me.UltraLabel20.Name = "UltraLabel20"
        Me.UltraLabel20.Size = New System.Drawing.Size(48, 14)
        Me.UltraLabel20.TabIndex = 177
        Me.UltraLabel20.Text = "Paciente"
        '
        'txt_IdCliente
        '
        Me.txt_IdCliente.Location = New System.Drawing.Point(261, 33)
        Me.txt_IdCliente.Name = "txt_IdCliente"
        Me.txt_IdCliente.Size = New System.Drawing.Size(37, 21)
        Me.txt_IdCliente.TabIndex = 175
        Me.txt_IdCliente.Visible = False
        '
        'UltraLabel4
        '
        Appearance12.BackColor = System.Drawing.Color.Transparent
        Appearance12.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel4.Appearance = Appearance12
        Me.UltraLabel4.AutoSize = True
        Me.UltraLabel4.Location = New System.Drawing.Point(723, 44)
        Me.UltraLabel4.Name = "UltraLabel4"
        Me.UltraLabel4.Size = New System.Drawing.Size(27, 14)
        Me.UltraLabel4.TabIndex = 172
        Me.UltraLabel4.Text = "H.C."
        '
        'txt_idHistoria
        '
        Me.txt_idHistoria.Location = New System.Drawing.Point(755, 40)
        Me.txt_idHistoria.Name = "txt_idHistoria"
        Me.txt_idHistoria.ReadOnly = True
        Me.txt_idHistoria.Size = New System.Drawing.Size(111, 21)
        Me.txt_idHistoria.TabIndex = 171
        '
        'txt_idClienteC
        '
        Me.txt_idClienteC.Location = New System.Drawing.Point(342, 65)
        Me.txt_idClienteC.Name = "txt_idClienteC"
        Me.txt_idClienteC.Size = New System.Drawing.Size(39, 21)
        Me.txt_idClienteC.TabIndex = 4
        '
        'txt_Ruc_ClientesC
        '
        Appearance10.ImageHAlign = Infragistics.Win.HAlign.Center
        Appearance10.ImageVAlign = Infragistics.Win.VAlign.Middle
        EditorButton2.Appearance = Appearance10
        EditorButton2.Key = "ayuda"
        Me.txt_Ruc_ClientesC.ButtonsRight.Add(EditorButton2)
        Me.txt_Ruc_ClientesC.Location = New System.Drawing.Point(216, 65)
        Me.txt_Ruc_ClientesC.MaxLength = 11
        Me.txt_Ruc_ClientesC.Name = "txt_Ruc_ClientesC"
        Me.txt_Ruc_ClientesC.Size = New System.Drawing.Size(126, 21)
        Me.txt_Ruc_ClientesC.TabIndex = 3
        '
        'UltraLabel5
        '
        Appearance21.BackColor = System.Drawing.Color.Transparent
        Appearance21.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel5.Appearance = Appearance21
        Me.UltraLabel5.AutoSize = True
        Me.UltraLabel5.Location = New System.Drawing.Point(166, 69)
        Me.UltraLabel5.Name = "UltraLabel5"
        Me.UltraLabel5.Size = New System.Drawing.Size(40, 14)
        Me.UltraLabel5.TabIndex = 170
        Me.UltraLabel5.Text = "Cliente"
        '
        'txt_Tratamiento
        '
        Appearance30.ImageHAlign = Infragistics.Win.HAlign.Center
        Appearance30.ImageVAlign = Infragistics.Win.VAlign.Middle
        EditorButton3.Appearance = Appearance30
        EditorButton3.Key = "ayuda"
        Me.txt_Tratamiento.ButtonsRight.Add(EditorButton3)
        Me.txt_Tratamiento.Location = New System.Drawing.Point(506, 169)
        Me.txt_Tratamiento.MaxLength = 11
        Me.txt_Tratamiento.Name = "txt_Tratamiento"
        Me.txt_Tratamiento.ReadOnly = True
        Me.txt_Tratamiento.Size = New System.Drawing.Size(284, 21)
        Me.txt_Tratamiento.TabIndex = 12
        '
        'uce_Medico
        '
        Me.uce_Medico.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.uce_Medico.Location = New System.Drawing.Point(85, 169)
        Me.uce_Medico.Name = "uce_Medico"
        Me.uce_Medico.Size = New System.Drawing.Size(325, 21)
        Me.uce_Medico.TabIndex = 9
        '
        'ug_detalle
        '
        Me.ug_detalle.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ug_detalle.DataSource = Me.uds_detalle
        Me.ug_detalle.DisplayLayout.AutoFitStyle = Infragistics.Win.UltraWinGrid.AutoFitStyle.ExtendLastColumn
        UltraGridColumn14.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        Appearance5.TextHAlignAsString = "Center"
        UltraGridColumn14.CellAppearance = Appearance5
        Appearance6.TextHAlignAsString = "Right"
        UltraGridColumn14.Header.Appearance = Appearance6
        UltraGridColumn14.Header.VisiblePosition = 1
        UltraGridColumn14.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Integer]
        UltraGridColumn14.Width = 30
        UltraGridColumn15.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn15.Header.VisiblePosition = 0
        UltraGridColumn15.Hidden = True
        UltraGridColumn16.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn16.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn16.Header.VisiblePosition = 2
        UltraGridColumn16.Width = 50
        UltraGridColumn17.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn17.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn17.Header.VisiblePosition = 3
        UltraGridColumn17.Width = 274
        UltraGridColumn18.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        Appearance7.TextHAlignAsString = "Right"
        UltraGridColumn18.CellAppearance = Appearance7
        UltraGridColumn18.Header.VisiblePosition = 4
        UltraGridColumn18.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Double]
        UltraGridColumn18.Width = 65
        UltraGridColumn19.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn19.Header.Caption = "Cubre"
        UltraGridColumn19.Header.VisiblePosition = 5
        UltraGridColumn20.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        Appearance8.TextHAlignAsString = "Right"
        UltraGridColumn20.CellAppearance = Appearance8
        UltraGridColumn20.Header.Caption = "Deducible"
        UltraGridColumn20.Header.VisiblePosition = 6
        UltraGridColumn20.Width = 60
        UltraGridColumn21.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn21.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        Appearance11.TextHAlignAsString = "Right"
        UltraGridColumn21.CellAppearance = Appearance11
        UltraGridColumn21.Header.Caption = "Dscto Seg."
        UltraGridColumn21.Header.VisiblePosition = 7
        UltraGridColumn21.MaskDisplayMode = Infragistics.Win.UltraWinMaskedEdit.MaskMode.IncludeLiterals
        UltraGridColumn21.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Double]
        UltraGridColumn21.Width = 65
        UltraGridColumn22.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        Appearance13.TextHAlignAsString = "Right"
        UltraGridColumn22.CellAppearance = Appearance13
        UltraGridColumn22.Header.Caption = "Dscto Otro"
        UltraGridColumn22.Header.VisiblePosition = 8
        UltraGridColumn22.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Double]
        UltraGridColumn22.Width = 65
        UltraGridColumn23.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn23.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        Appearance14.TextHAlignAsString = "Right"
        UltraGridColumn23.CellAppearance = Appearance14
        UltraGridColumn23.Header.VisiblePosition = 9
        UltraGridColumn23.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Double]
        UltraGridColumn23.Width = 60
        UltraGridColumn24.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn24.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        Appearance19.TextHAlignAsString = "Right"
        UltraGridColumn24.CellAppearance = Appearance19
        UltraGridColumn24.Header.VisiblePosition = 10
        UltraGridColumn24.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Double]
        UltraGridColumn24.Width = 55
        UltraGridColumn25.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn25.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        Appearance20.TextHAlignAsString = "Right"
        UltraGridColumn25.CellAppearance = Appearance20
        UltraGridColumn25.Header.VisiblePosition = 11
        UltraGridColumn25.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Double]
        UltraGridColumn25.Width = 65
        UltraGridColumn26.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn26.Header.VisiblePosition = 12
        UltraGridColumn26.Hidden = True
        UltraGridColumn27.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn27.Header.VisiblePosition = 13
        UltraGridColumn27.Hidden = True
        UltraGridColumn28.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn28.Header.VisiblePosition = 14
        UltraGridColumn28.Hidden = True
        UltraGridColumn29.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn29.Header.VisiblePosition = 15
        UltraGridColumn29.Hidden = True
        UltraGridColumn30.Header.VisiblePosition = 16
        UltraGridColumn30.Hidden = True
        UltraGridBand2.Columns.AddRange(New Object() {UltraGridColumn14, UltraGridColumn15, UltraGridColumn16, UltraGridColumn17, UltraGridColumn18, UltraGridColumn19, UltraGridColumn20, UltraGridColumn21, UltraGridColumn22, UltraGridColumn23, UltraGridColumn24, UltraGridColumn25, UltraGridColumn26, UltraGridColumn27, UltraGridColumn28, UltraGridColumn29, UltraGridColumn30})
        UltraGridBand2.SummaryFooterCaption = "Totales"
        Me.ug_detalle.DisplayLayout.BandsSerializer.Add(UltraGridBand2)
        Me.ug_detalle.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.[False]
        Me.ug_detalle.DisplayLayout.MaxColScrollRegions = 1
        Me.ug_detalle.DisplayLayout.MaxRowScrollRegions = 1
        Me.ug_detalle.DisplayLayout.Override.AllowDelete = Infragistics.Win.DefaultableBoolean.[True]
        Me.ug_detalle.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.ug_detalle.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.ug_detalle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ug_detalle.Location = New System.Drawing.Point(5, 196)
        Me.ug_detalle.Name = "ug_detalle"
        Me.ug_detalle.Size = New System.Drawing.Size(868, 317)
        Me.ug_detalle.TabIndex = 14
        Me.ug_detalle.Text = "UltraGrid1"
        '
        'uds_detalle
        '
        Me.uds_detalle.Band.AllowAdd = Infragistics.Win.DefaultableBoolean.[True]
        Me.uds_detalle.Band.AllowDelete = Infragistics.Win.DefaultableBoolean.[True]
        UltraDataColumn14.DataType = GetType(Integer)
        UltraDataColumn15.DataType = GetType(Integer)
        UltraDataColumn18.DataType = GetType(Double)
        UltraDataColumn19.DataType = GetType(Boolean)
        UltraDataColumn20.DataType = GetType(Boolean)
        UltraDataColumn21.DataType = GetType(Double)
        UltraDataColumn22.DataType = GetType(Double)
        UltraDataColumn23.DataType = GetType(Double)
        UltraDataColumn24.DataType = GetType(Double)
        UltraDataColumn25.DataType = GetType(Double)
        UltraDataColumn26.DataType = GetType(Integer)
        UltraDataColumn27.DataType = GetType(Integer)
        UltraDataColumn28.DataType = GetType(Integer)
        UltraDataColumn29.DataType = GetType(Integer)
        UltraDataColumn30.DataType = GetType(Integer)
        Me.uds_detalle.Band.Columns.AddRange(New Object() {UltraDataColumn14, UltraDataColumn15, UltraDataColumn16, UltraDataColumn17, UltraDataColumn18, UltraDataColumn19, UltraDataColumn20, UltraDataColumn21, UltraDataColumn22, UltraDataColumn23, UltraDataColumn24, UltraDataColumn25, UltraDataColumn26, UltraDataColumn27, UltraDataColumn28, UltraDataColumn29, UltraDataColumn30})
        '
        'ubt_Quitar
        '
        Me.ubt_Quitar.Location = New System.Drawing.Point(841, 167)
        Me.ubt_Quitar.Name = "ubt_Quitar"
        Me.ubt_Quitar.Size = New System.Drawing.Size(29, 24)
        Me.ubt_Quitar.TabIndex = 15
        Me.ubt_Quitar.Text = "-"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.Panel2.Location = New System.Drawing.Point(14, 97)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(860, 2)
        Me.Panel2.TabIndex = 154
        '
        'UltraLabel2
        '
        Appearance18.BackColor = System.Drawing.Color.DeepSkyBlue
        Appearance18.ForeColor = System.Drawing.Color.White
        Appearance18.TextHAlignAsString = "Center"
        Me.UltraLabel2.Appearance = Appearance18
        Me.UltraLabel2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel2.Location = New System.Drawing.Point(2, 2)
        Me.UltraLabel2.Name = "UltraLabel2"
        Me.UltraLabel2.Size = New System.Drawing.Size(885, 28)
        Me.UltraLabel2.TabIndex = 27
        Me.UltraLabel2.Text = "Presupuesto"
        '
        'udte_fecha
        '
        Me.udte_fecha.DateTime = New Date(2014, 1, 28, 0, 0, 0, 0)
        Me.udte_fecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.udte_fecha.Location = New System.Drawing.Point(85, 112)
        Me.udte_fecha.Name = "udte_fecha"
        Me.udte_fecha.ReadOnly = True
        Me.udte_fecha.Size = New System.Drawing.Size(138, 24)
        Me.udte_fecha.TabIndex = 5
        Me.udte_fecha.Value = New Date(2014, 1, 28, 0, 0, 0, 0)
        '
        'ugb_Cuenta
        '
        Me.ugb_Cuenta.Controls.Add(Me.UltraLabel9)
        Me.ugb_Cuenta.Controls.Add(Me.txt_PagoFijo)
        Me.ugb_Cuenta.Controls.Add(Me.txt_PagoVariable)
        Me.ugb_Cuenta.Controls.Add(Me.UltraLabel10)
        Me.ugb_Cuenta.Location = New System.Drawing.Point(422, 112)
        Me.ugb_Cuenta.Name = "ugb_Cuenta"
        Me.ugb_Cuenta.Size = New System.Drawing.Size(313, 50)
        Me.ugb_Cuenta.TabIndex = 141
        Me.ugb_Cuenta.Text = "Informacion Asegurado"
        '
        'UltraLabel9
        '
        Appearance27.BackColor = System.Drawing.Color.Transparent
        Appearance27.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel9.Appearance = Appearance27
        Me.UltraLabel9.AutoSize = True
        Me.UltraLabel9.Location = New System.Drawing.Point(162, 26)
        Me.UltraLabel9.Name = "UltraLabel9"
        Me.UltraLabel9.Size = New System.Drawing.Size(57, 14)
        Me.UltraLabel9.TabIndex = 27
        Me.UltraLabel9.Text = "Copago %"
        '
        'txt_PagoFijo
        '
        Me.txt_PagoFijo.Location = New System.Drawing.Point(84, 21)
        Me.txt_PagoFijo.Name = "txt_PagoFijo"
        Me.txt_PagoFijo.Size = New System.Drawing.Size(59, 21)
        Me.txt_PagoFijo.TabIndex = 10
        '
        'txt_PagoVariable
        '
        Me.txt_PagoVariable.Location = New System.Drawing.Point(225, 21)
        Me.txt_PagoVariable.Name = "txt_PagoVariable"
        Me.txt_PagoVariable.Size = New System.Drawing.Size(59, 21)
        Me.txt_PagoVariable.TabIndex = 11
        '
        'UltraLabel10
        '
        Appearance23.BackColor = System.Drawing.Color.Transparent
        Appearance23.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel10.Appearance = Appearance23
        Me.UltraLabel10.AutoSize = True
        Me.UltraLabel10.Location = New System.Drawing.Point(19, 25)
        Me.UltraLabel10.Name = "UltraLabel10"
        Me.UltraLabel10.Size = New System.Drawing.Size(55, 14)
        Me.UltraLabel10.TabIndex = 27
        Me.UltraLabel10.Text = "Deducible"
        '
        'ubt_Agregar
        '
        Me.ubt_Agregar.Location = New System.Drawing.Point(807, 167)
        Me.ubt_Agregar.Name = "ubt_Agregar"
        Me.ubt_Agregar.Size = New System.Drawing.Size(29, 24)
        Me.ubt_Agregar.TabIndex = 13
        Me.ubt_Agregar.Text = "+"
        '
        'ucm_SeguroEps
        '
        Me.ucm_SeguroEps.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.ucm_SeguroEps.Location = New System.Drawing.Point(85, 142)
        Me.ucm_SeguroEps.Name = "ucm_SeguroEps"
        Me.ucm_SeguroEps.Size = New System.Drawing.Size(325, 21)
        Me.ucm_SeguroEps.TabIndex = 8
        '
        'uchk_SeguroEps
        '
        Appearance32.ForeColor = System.Drawing.Color.Navy
        Me.uchk_SeguroEps.Appearance = Appearance32
        Me.uchk_SeguroEps.BackColor = System.Drawing.Color.Transparent
        Me.uchk_SeguroEps.BackColorInternal = System.Drawing.Color.Transparent
        Me.uchk_SeguroEps.Location = New System.Drawing.Point(14, 142)
        Me.uchk_SeguroEps.Name = "uchk_SeguroEps"
        Me.uchk_SeguroEps.Size = New System.Drawing.Size(68, 22)
        Me.uchk_SeguroEps.TabIndex = 7
        Me.uchk_SeguroEps.Text = "Seguro"
        '
        'UltraLabel6
        '
        Appearance41.BackColor = System.Drawing.Color.Transparent
        Appearance41.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel6.Appearance = Appearance41
        Me.UltraLabel6.AutoSize = True
        Me.UltraLabel6.Location = New System.Drawing.Point(30, 173)
        Me.UltraLabel6.Name = "UltraLabel6"
        Me.UltraLabel6.Size = New System.Drawing.Size(41, 14)
        Me.UltraLabel6.TabIndex = 36
        Me.UltraLabel6.Text = "Médico"
        '
        'UltraLabel1
        '
        Appearance4.BackColor = System.Drawing.Color.Transparent
        Appearance4.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel1.Appearance = Appearance4
        Me.UltraLabel1.AutoSize = True
        Me.UltraLabel1.Location = New System.Drawing.Point(14, 119)
        Me.UltraLabel1.Name = "UltraLabel1"
        Me.UltraLabel1.Size = New System.Drawing.Size(63, 14)
        Me.UltraLabel1.TabIndex = 29
        Me.UltraLabel1.Text = "Fecha Reg."
        '
        'txt_idPresupuesto
        '
        Me.txt_idPresupuesto.Location = New System.Drawing.Point(30, 62)
        Me.txt_idPresupuesto.Name = "txt_idPresupuesto"
        Me.txt_idPresupuesto.ReadOnly = True
        Me.txt_idPresupuesto.Size = New System.Drawing.Size(107, 21)
        Me.txt_idPresupuesto.TabIndex = 0
        '
        'txt_Total
        '
        Appearance17.TextHAlignAsString = "Right"
        Me.txt_Total.Appearance = Appearance17
        Me.txt_Total.Location = New System.Drawing.Point(768, 528)
        Me.txt_Total.Name = "txt_Total"
        Me.txt_Total.ReadOnly = True
        Me.txt_Total.Size = New System.Drawing.Size(116, 21)
        Me.txt_Total.TabIndex = 137
        '
        'txt_IGV
        '
        Appearance16.TextHAlignAsString = "Right"
        Me.txt_IGV.Appearance = Appearance16
        Me.txt_IGV.Location = New System.Drawing.Point(596, 528)
        Me.txt_IGV.Name = "txt_IGV"
        Me.txt_IGV.ReadOnly = True
        Me.txt_IGV.Size = New System.Drawing.Size(116, 21)
        Me.txt_IGV.TabIndex = 136
        '
        'txt_SubTotal
        '
        Appearance15.TextHAlignAsString = "Right"
        Me.txt_SubTotal.Appearance = Appearance15
        Me.txt_SubTotal.Location = New System.Drawing.Point(417, 528)
        Me.txt_SubTotal.Name = "txt_SubTotal"
        Me.txt_SubTotal.ReadOnly = True
        Me.txt_SubTotal.Size = New System.Drawing.Size(116, 21)
        Me.txt_SubTotal.TabIndex = 34
        '
        'UltraLabel24
        '
        Me.UltraLabel24.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Appearance72.BackColor = System.Drawing.Color.Transparent
        Appearance72.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel24.Appearance = Appearance72
        Me.UltraLabel24.AutoSize = True
        Me.UltraLabel24.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel24.Location = New System.Drawing.Point(350, 530)
        Me.UltraLabel24.Name = "UltraLabel24"
        Me.UltraLabel24.Size = New System.Drawing.Size(54, 16)
        Me.UltraLabel24.TabIndex = 135
        Me.UltraLabel24.Text = "SubTotal"
        '
        'UltraLabel32
        '
        Me.UltraLabel32.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Appearance3.BackColor = System.Drawing.Color.Transparent
        Appearance3.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel32.Appearance = Appearance3
        Me.UltraLabel32.AutoSize = True
        Me.UltraLabel32.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel32.Location = New System.Drawing.Point(719, 530)
        Me.UltraLabel32.Name = "UltraLabel32"
        Me.UltraLabel32.Size = New System.Drawing.Size(33, 16)
        Me.UltraLabel32.TabIndex = 133
        Me.UltraLabel32.Text = "Total"
        '
        'UltraLabel25
        '
        Me.UltraLabel25.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Appearance1.BackColor = System.Drawing.Color.Transparent
        Appearance1.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel25.Appearance = Appearance1
        Me.UltraLabel25.AutoSize = True
        Me.UltraLabel25.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel25.Location = New System.Drawing.Point(547, 530)
        Me.UltraLabel25.Name = "UltraLabel25"
        Me.UltraLabel25.Size = New System.Drawing.Size(36, 16)
        Me.UltraLabel25.TabIndex = 134
        Me.UltraLabel25.Text = "I.G.V."
        '
        'ToolS_Mantenimiento
        '
        Me.ToolS_Mantenimiento.BackColor = System.Drawing.Color.White
        Me.ToolS_Mantenimiento.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Tool_Nuevo, Me.ToolStripSeparator1, Me.Tool_Grabar, Me.ToolStripSeparator4, Me.Tool_Editar, Me.ToolStripSeparator3, Me.Tool_Cancelar, Me.ToolStripSeparator2, Me.Tool_Eliminar, Me.ToolStripSeparator5, Me.Tool_Salir})
        Me.ToolS_Mantenimiento.Location = New System.Drawing.Point(0, 0)
        Me.ToolS_Mantenimiento.Name = "ToolS_Mantenimiento"
        Me.ToolS_Mantenimiento.Size = New System.Drawing.Size(887, 25)
        Me.ToolS_Mantenimiento.TabIndex = 32
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
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(6, 25)
        '
        'Tool_Editar
        '
        Me.Tool_Editar.Image = Global.Contabilidad.My.Resources.Resources._16__Card_edit_
        Me.Tool_Editar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Tool_Editar.Name = "Tool_Editar"
        Me.Tool_Editar.Size = New System.Drawing.Size(57, 22)
        Me.Tool_Editar.Text = "Editar"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 25)
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
        Me.Tool_Eliminar.Image = Global.Contabilidad.My.Resources.Resources._132
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
        'utc_Datos
        '
        Me.utc_Datos.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.utc_Datos.Controls.Add(Me.UltraTabSharedControlsPage1)
        Me.utc_Datos.Controls.Add(Me.UltraTabPageControl1)
        Me.utc_Datos.Controls.Add(Me.UltraTabPageControl2)
        Me.utc_Datos.Location = New System.Drawing.Point(2, 26)
        Me.utc_Datos.Name = "utc_Datos"
        Me.utc_Datos.SharedControlsPage = Me.UltraTabSharedControlsPage1
        Me.utc_Datos.Size = New System.Drawing.Size(885, 580)
        Me.utc_Datos.TabIndex = 184
        UltraTab1.TabPage = Me.UltraTabPageControl1
        UltraTab1.Text = "Lista de Presupuesto"
        UltraTab2.TabPage = Me.UltraTabPageControl2
        UltraTab2.Text = "Ingreso / Edicion de Datos"
        Me.utc_Datos.Tabs.AddRange(New Infragistics.Win.UltraWinTabControl.UltraTab() {UltraTab1, UltraTab2})
        '
        'UltraTabSharedControlsPage1
        '
        Me.UltraTabSharedControlsPage1.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabSharedControlsPage1.Name = "UltraTabSharedControlsPage1"
        Me.UltraTabSharedControlsPage1.Size = New System.Drawing.Size(881, 554)
        '
        'FA_PR_Presupuesto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(887, 606)
        Me.Controls.Add(Me.utc_Datos)
        Me.Controls.Add(Me.ToolS_Mantenimiento)
        Me.Name = "FA_PR_Presupuesto"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Presupuesto"
        Me.UltraTabPageControl1.ResumeLayout(False)
        CType(Me.ug_Lista, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.uds_Lista, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabPageControl2.ResumeLayout(False)
        Me.UltraTabPageControl2.PerformLayout()
        CType(Me.ugb_Datos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ugb_Datos.ResumeLayout(False)
        Me.ugb_Datos.PerformLayout()
        CType(Me.txt_idTratamiento, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ucbo_Estado, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_Des_ClienteC, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.uce_tip_doc, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_Des_Cliente, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_ruc_cliente, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_IdCliente, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_idHistoria, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_idClienteC, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_Ruc_ClientesC, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_Tratamiento, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.uce_Medico, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ug_detalle, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.uds_detalle, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.udte_fecha, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ugb_Cuenta, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ugb_Cuenta.ResumeLayout(False)
        Me.ugb_Cuenta.PerformLayout()
        CType(Me.txt_PagoFijo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_PagoVariable, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ucm_SeguroEps, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_idPresupuesto, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_Total, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_IGV, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_SubTotal, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolS_Mantenimiento.ResumeLayout(False)
        Me.ToolS_Mantenimiento.PerformLayout()
        CType(Me.utc_Datos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.utc_Datos.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolS_Mantenimiento As System.Windows.Forms.ToolStrip
    Friend WithEvents Tool_Grabar As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents Tool_Salir As System.Windows.Forms.ToolStripButton
    Friend WithEvents ugb_Datos As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents UltraLabel6 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel1 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel2 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel9 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel10 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents txt_PagoVariable As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents txt_PagoFijo As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents ubt_Agregar As Infragistics.Win.Misc.UltraButton
    Friend WithEvents ucm_SeguroEps As Infragistics.Win.UltraWinEditors.UltraComboEditor
    Friend WithEvents uchk_SeguroEps As Infragistics.Win.UltraWinEditors.UltraCheckEditor
    Friend WithEvents udte_fecha As Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents txt_SubTotal As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents UltraLabel24 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel25 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel32 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents txt_IGV As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents txt_Total As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents ubt_Quitar As Infragistics.Win.Misc.UltraButton
    Friend WithEvents uds_detalle As Infragistics.Win.UltraWinDataSource.UltraDataSource
    Public WithEvents ug_detalle As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Public WithEvents uce_Medico As Infragistics.Win.UltraWinEditors.UltraComboEditor
    Friend WithEvents txt_Tratamiento As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents txt_Des_ClienteC As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents uce_tip_doc As Infragistics.Win.UltraWinEditors.UltraComboEditor
    Friend WithEvents txt_Des_Cliente As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents txt_ruc_cliente As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents UltraLabel20 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents txt_IdCliente As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents UltraLabel4 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents txt_idHistoria As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents txt_idClienteC As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents txt_Ruc_ClientesC As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents UltraLabel5 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents txt_idPresupuesto As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents UltraLabel7 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents ucbo_Estado As Infragistics.Win.UltraWinEditors.UltraComboEditor
    Friend WithEvents Tool_Nuevo As System.Windows.Forms.ToolStripButton
    Friend WithEvents Tool_Cancelar As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ugb_Cuenta As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents UltraLabel3 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents txt_idTratamiento As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents UltraLabel8 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents Tool_Editar As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents utc_Datos As Infragistics.Win.UltraWinTabControl.UltraTabControl
    Friend WithEvents UltraTabSharedControlsPage1 As Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage
    Friend WithEvents UltraTabPageControl1 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents ug_Lista As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents UltraTabPageControl2 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents uds_Lista As Infragistics.Win.UltraWinDataSource.UltraDataSource
    Friend WithEvents Tool_Eliminar As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator5 As System.Windows.Forms.ToolStripSeparator
End Class
