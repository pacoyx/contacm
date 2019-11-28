<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FA_PR_Emi_ComproFacturacion
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
        Dim Appearance7 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance21 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim EditorButton1 As Infragistics.Win.UltraWinEditors.EditorButton = New Infragistics.Win.UltraWinEditors.EditorButton("btn_ref")
        Dim Appearance6 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance38 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance11 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance3 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance1 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance4 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance72 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance93 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance28 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance23 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance26 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance29 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance41 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim EditorButton2 As Infragistics.Win.UltraWinEditors.EditorButton = New Infragistics.Win.UltraWinEditors.EditorButton("ayuda")
        Dim Appearance2 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance13 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance12 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim EditorButton3 As Infragistics.Win.UltraWinEditors.EditorButton = New Infragistics.Win.UltraWinEditors.EditorButton("ayuda")
        Dim Appearance111 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance8 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance9 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance33 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance58 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance66 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance10 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance44 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance5 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance37 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraDataColumn1 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Item")
        Dim UltraDataColumn2 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Cant")
        Dim UltraDataColumn3 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdArticulo")
        Dim UltraDataColumn4 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("DesArticulo")
        Dim UltraDataColumn5 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Precio")
        Dim UltraDataColumn6 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("DSCTO")
        Dim UltraDataColumn7 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("DSCTO_OTRO")
        Dim UltraDataColumn8 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("SubTotal")
        Dim UltraDataColumn9 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Impuesto")
        Dim UltraDataColumn10 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Total")
        Dim UltraDataColumn11 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("InIGV")
        Dim UltraDataColumn12 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IDCUENTA")
        Dim UltraDataColumn13 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("CuentaItems")
        Dim UltraGridBand1 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1)
        Dim UltraGridColumn1 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Item")
        Dim UltraGridColumn2 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Cant")
        Dim Appearance25 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn3 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdArticulo")
        Dim UltraGridColumn4 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("DesArticulo")
        Dim UltraGridColumn5 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Precio")
        Dim Appearance32 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn6 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("DSCTO")
        Dim Appearance35 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn7 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("DSCTO_OTRO")
        Dim Appearance36 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn8 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("SubTotal")
        Dim Appearance39 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn9 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Impuesto")
        Dim Appearance40 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn10 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Total")
        Dim Appearance45 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn11 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("InIGV")
        Dim UltraGridColumn12 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IDCUENTA")
        Dim UltraGridColumn13 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CuentaItems")
        Dim Appearance34 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim EditorButton4 As Infragistics.Win.UltraWinEditors.EditorButton = New Infragistics.Win.UltraWinEditors.EditorButton("btn_des_cli")
        Dim UltraStatusPanel1 As Infragistics.Win.UltraWinStatusBar.UltraStatusPanel = New Infragistics.Win.UltraWinStatusBar.UltraStatusPanel()
        Dim Appearance22 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance43 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance24 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance42 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance31 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance27 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance30 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FA_PR_Emi_ComproFacturacion))
        Me.lbludte_Fec_Ven = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraLabel6 = New Infragistics.Win.Misc.UltraLabel()
        Me.udte_fec_Ven = New Infragistics.Win.UltraWinEditors.UltraDateTimeEditor()
        Me.udte_fec_emi = New Infragistics.Win.UltraWinEditors.UltraDateTimeEditor()
        Me.uce_TipoDoc = New Infragistics.Win.UltraWinEditors.UltraComboEditor()
        Me.txt_NumDoc = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.UltraLabel9 = New Infragistics.Win.Misc.UltraLabel()
        Me.uce_Moneda = New Infragistics.Win.UltraWinEditors.UltraComboEditor()
        Me.UltraLabel3 = New Infragistics.Win.Misc.UltraLabel()
        Me.ume_total = New Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit()
        Me.UltraLabel32 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraLabel1 = New Infragistics.Win.Misc.UltraLabel()
        Me.ume_igv = New Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit()
        Me.UltraLabel2 = New Infragistics.Win.Misc.UltraLabel()
        Me.ume_subtotal = New Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit()
        Me.ugb_cabecera = New Infragistics.Win.Misc.UltraGroupBox()
        Me.UltraLabel25 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraLabel24 = New Infragistics.Win.Misc.UltraLabel()
        Me.uck_Redondear = New Infragistics.Win.UltraWinEditors.UltraCheckEditor()
        Me.udtpFechaAlta = New Infragistics.Win.UltraWinEditors.UltraDateTimeEditor()
        Me.udtpFecha_Ingreso = New Infragistics.Win.UltraWinEditors.UltraDateTimeEditor()
        Me.UltraLabel23 = New Infragistics.Win.Misc.UltraLabel()
        Me.ucm_Tipo = New Infragistics.Win.UltraWinEditors.UltraComboEditor()
        Me.uce_Medico = New Infragistics.Win.UltraWinEditors.UltraComboEditor()
        Me.UltraLabel5 = New Infragistics.Win.Misc.UltraLabel()
        Me.txt_Des_ClienteC = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.uce_tip_doc = New Infragistics.Win.UltraWinEditors.UltraComboEditor()
        Me.txt_Des_Cliente = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.txt_ruc_cliente = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.UltraLabel20 = New Infragistics.Win.Misc.UltraLabel()
        Me.txt_IdCliente = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.UltraLabel22 = New Infragistics.Win.Misc.UltraLabel()
        Me.txt_idHistoria = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.txt_idClienteC = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.txt_Ruc_ClientesC = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.UltraLabel21 = New Infragistics.Win.Misc.UltraLabel()
        Me.txt_doc_pago = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.txt_ref_pago = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.uce_docu_pago = New Infragistics.Win.UltraWinEditors.UltraComboEditor()
        Me.uce_FormaPago = New Infragistics.Win.UltraWinEditors.UltraComboEditor()
        Me.UltraLabel11 = New Infragistics.Win.Misc.UltraLabel()
        Me.uce_PuntoVenta = New Infragistics.Win.UltraWinEditors.UltraComboEditor()
        Me.UltraLabel10 = New Infragistics.Win.Misc.UltraLabel()
        Me.uce_Serie = New Infragistics.Win.UltraWinEditors.UltraComboEditor()
        Me.UltraLabel8 = New Infragistics.Win.Misc.UltraLabel()
        Me.ume_Tasa_Igv = New Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit()
        Me.UltraLabel14 = New Infragistics.Win.Misc.UltraLabel()
        Me.ume_ValorTipoCambio = New Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit()
        Me.UltraLabel4 = New Infragistics.Win.Misc.UltraLabel()
        Me.txt_num_voucher_conta = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.UltraLabel12 = New Infragistics.Win.Misc.UltraLabel()
        Me.txt_IdComprobante = New System.Windows.Forms.TextBox()
        Me.uds_detalle = New Infragistics.Win.UltraWinDataSource.UltraDataSource(Me.components)
        Me.ug_Detalle = New Infragistics.Win.UltraWinGrid.UltraGrid()
        Me.ubtn_agregar = New Infragistics.Win.Misc.UltraButton()
        Me.ubtn_quitar = New Infragistics.Win.Misc.UltraButton()
        Me.UltraLabel7 = New Infragistics.Win.Misc.UltraLabel()
        Me.txt_notas = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.usb_compro = New Infragistics.Win.UltraWinStatusBar.UltraStatusBar()
        Me.ToolS_Mantenimiento = New System.Windows.Forms.ToolStrip()
        Me.Tool_Nuevo = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.Tool_Grabar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator()
        Me.Tool_Cancelar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.Tool_Imprimir = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator7 = New System.Windows.Forms.ToolStripSeparator()
        Me.Tool_Salir = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator6 = New System.Windows.Forms.ToolStripSeparator()
        Me.ugb_docref = New Infragistics.Win.Misc.UltraGroupBox()
        Me.UltraLabel19 = New Infragistics.Win.Misc.UltraLabel()
        Me.ubtn_aceptar = New Infragistics.Win.Misc.UltraButton()
        Me.ume_fec_ven_ref = New Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit()
        Me.ume_fec_emi_ref = New Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit()
        Me.txt_numero_ref = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.txt_serie_ref = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.uce_TipDocRef = New Infragistics.Win.UltraWinEditors.UltraComboEditor()
        Me.UltraLabel18 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraLabel17 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraLabel16 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraLabel15 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraLabel13 = New Infragistics.Win.Misc.UltraLabel()
        CType(Me.udte_fec_Ven, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.udte_fec_emi, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.uce_TipoDoc, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_NumDoc, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.uce_Moneda, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ugb_cabecera, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ugb_cabecera.SuspendLayout()
        CType(Me.udtpFechaAlta, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.udtpFecha_Ingreso, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ucm_Tipo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.uce_Medico, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_Des_ClienteC, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.uce_tip_doc, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_Des_Cliente, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_ruc_cliente, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_IdCliente, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_idHistoria, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_idClienteC, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_Ruc_ClientesC, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_doc_pago, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_ref_pago, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.uce_docu_pago, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.uce_FormaPago, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.uce_PuntoVenta, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.uce_Serie, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_num_voucher_conta, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.uds_detalle, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ug_Detalle, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_notas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolS_Mantenimiento.SuspendLayout()
        CType(Me.ugb_docref, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ugb_docref.SuspendLayout()
        CType(Me.txt_numero_ref, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_serie_ref, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.uce_TipDocRef, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbludte_Fec_Ven
        '
        Me.lbludte_Fec_Ven.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Appearance7.BackColor = System.Drawing.Color.Transparent
        Appearance7.ForeColor = System.Drawing.Color.Navy
        Me.lbludte_Fec_Ven.Appearance = Appearance7
        Me.lbludte_Fec_Ven.AutoSize = True
        Me.lbludte_Fec_Ven.Location = New System.Drawing.Point(688, 39)
        Me.lbludte_Fec_Ven.Name = "lbludte_Fec_Ven"
        Me.lbludte_Fec_Ven.Size = New System.Drawing.Size(70, 14)
        Me.lbludte_Fec_Ven.TabIndex = 118
        Me.lbludte_Fec_Ven.Text = "Fec. Vencim."
        '
        'UltraLabel6
        '
        Me.UltraLabel6.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Appearance21.BackColor = System.Drawing.Color.Transparent
        Appearance21.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel6.Appearance = Appearance21
        Me.UltraLabel6.AutoSize = True
        Me.UltraLabel6.Location = New System.Drawing.Point(688, 15)
        Me.UltraLabel6.Name = "UltraLabel6"
        Me.UltraLabel6.Size = New System.Drawing.Size(70, 14)
        Me.UltraLabel6.TabIndex = 117
        Me.UltraLabel6.Text = "Fec. Emision"
        '
        'udte_fec_Ven
        '
        Me.udte_fec_Ven.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.udte_fec_Ven.Location = New System.Drawing.Point(764, 35)
        Me.udte_fec_Ven.MaskInput = "{date}"
        Me.udte_fec_Ven.Name = "udte_fec_Ven"
        Me.udte_fec_Ven.Size = New System.Drawing.Size(105, 21)
        Me.udte_fec_Ven.TabIndex = 116
        '
        'udte_fec_emi
        '
        Me.udte_fec_emi.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.udte_fec_emi.Location = New System.Drawing.Point(764, 11)
        Me.udte_fec_emi.MaskInput = "{date}"
        Me.udte_fec_emi.Name = "udte_fec_emi"
        Me.udte_fec_emi.ReadOnly = True
        Me.udte_fec_emi.Size = New System.Drawing.Size(105, 21)
        Me.udte_fec_emi.TabIndex = 115
        '
        'uce_TipoDoc
        '
        Me.uce_TipoDoc.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Suggest
        Me.uce_TipoDoc.DropDownListWidth = 50
        Me.uce_TipoDoc.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.uce_TipoDoc.Location = New System.Drawing.Point(280, 11)
        Me.uce_TipoDoc.Name = "uce_TipoDoc"
        Me.uce_TipoDoc.Size = New System.Drawing.Size(91, 21)
        Me.uce_TipoDoc.TabIndex = 120
        '
        'txt_NumDoc
        '
        EditorButton1.Key = "btn_ref"
        Me.txt_NumDoc.ButtonsRight.Add(EditorButton1)
        Me.txt_NumDoc.Location = New System.Drawing.Point(471, 11)
        Me.txt_NumDoc.Name = "txt_NumDoc"
        Me.txt_NumDoc.ReadOnly = True
        Me.txt_NumDoc.Size = New System.Drawing.Size(197, 21)
        Me.txt_NumDoc.TabIndex = 122
        '
        'UltraLabel9
        '
        Appearance6.BackColor = System.Drawing.Color.Transparent
        Appearance6.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel9.Appearance = Appearance6
        Me.UltraLabel9.AutoSize = True
        Me.UltraLabel9.Location = New System.Drawing.Point(205, 14)
        Me.UltraLabel9.Name = "UltraLabel9"
        Me.UltraLabel9.Size = New System.Drawing.Size(73, 14)
        Me.UltraLabel9.TabIndex = 123
        Me.UltraLabel9.Text = "Comprobante"
        '
        'uce_Moneda
        '
        Me.uce_Moneda.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Suggest
        Me.uce_Moneda.DropDownListWidth = 100
        Me.uce_Moneda.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.uce_Moneda.Location = New System.Drawing.Point(61, 107)
        Me.uce_Moneda.Name = "uce_Moneda"
        Me.uce_Moneda.Size = New System.Drawing.Size(56, 21)
        Me.uce_Moneda.TabIndex = 129
        '
        'UltraLabel3
        '
        Appearance38.BackColor = System.Drawing.Color.Transparent
        Appearance38.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel3.Appearance = Appearance38
        Me.UltraLabel3.AutoSize = True
        Me.UltraLabel3.Location = New System.Drawing.Point(11, 110)
        Me.UltraLabel3.Name = "UltraLabel3"
        Me.UltraLabel3.Size = New System.Drawing.Size(45, 14)
        Me.UltraLabel3.TabIndex = 128
        Me.UltraLabel3.Text = "Moneda"
        '
        'ume_total
        '
        Me.ume_total.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Appearance11.TextHAlignAsString = "Right"
        Me.ume_total.Appearance = Appearance11
        Me.ume_total.EditAs = Infragistics.Win.UltraWinMaskedEdit.EditAsType.UseSpecifiedMask
        Me.ume_total.InputMask = "{double:-9.3}"
        Me.ume_total.Location = New System.Drawing.Point(778, 546)
        Me.ume_total.Name = "ume_total"
        Me.ume_total.ReadOnly = True
        Me.ume_total.Size = New System.Drawing.Size(109, 20)
        Me.ume_total.TabIndex = 131
        '
        'UltraLabel32
        '
        Me.UltraLabel32.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Appearance3.BackColor = System.Drawing.Color.Transparent
        Appearance3.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel32.Appearance = Appearance3
        Me.UltraLabel32.AutoSize = True
        Me.UltraLabel32.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel32.Location = New System.Drawing.Point(736, 547)
        Me.UltraLabel32.Name = "UltraLabel32"
        Me.UltraLabel32.Size = New System.Drawing.Size(33, 16)
        Me.UltraLabel32.TabIndex = 132
        Me.UltraLabel32.Text = "Total"
        '
        'UltraLabel1
        '
        Me.UltraLabel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Appearance1.BackColor = System.Drawing.Color.Transparent
        Appearance1.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel1.Appearance = Appearance1
        Me.UltraLabel1.AutoSize = True
        Me.UltraLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel1.Location = New System.Drawing.Point(738, 528)
        Me.UltraLabel1.Name = "UltraLabel1"
        Me.UltraLabel1.Size = New System.Drawing.Size(36, 16)
        Me.UltraLabel1.TabIndex = 132
        Me.UltraLabel1.Text = "I.G.V."
        '
        'ume_igv
        '
        Me.ume_igv.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Appearance4.TextHAlignAsString = "Right"
        Me.ume_igv.Appearance = Appearance4
        Me.ume_igv.EditAs = Infragistics.Win.UltraWinMaskedEdit.EditAsType.UseSpecifiedMask
        Me.ume_igv.InputMask = "{double:-9.3}"
        Me.ume_igv.Location = New System.Drawing.Point(778, 525)
        Me.ume_igv.Name = "ume_igv"
        Me.ume_igv.ReadOnly = True
        Me.ume_igv.Size = New System.Drawing.Size(109, 20)
        Me.ume_igv.TabIndex = 131
        '
        'UltraLabel2
        '
        Me.UltraLabel2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Appearance72.BackColor = System.Drawing.Color.Transparent
        Appearance72.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel2.Appearance = Appearance72
        Me.UltraLabel2.AutoSize = True
        Me.UltraLabel2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel2.Location = New System.Drawing.Point(720, 507)
        Me.UltraLabel2.Name = "UltraLabel2"
        Me.UltraLabel2.Size = New System.Drawing.Size(54, 16)
        Me.UltraLabel2.TabIndex = 132
        Me.UltraLabel2.Text = "SubTotal"
        '
        'ume_subtotal
        '
        Me.ume_subtotal.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Appearance93.TextHAlignAsString = "Right"
        Me.ume_subtotal.Appearance = Appearance93
        Me.ume_subtotal.EditAs = Infragistics.Win.UltraWinMaskedEdit.EditAsType.Currency
        Me.ume_subtotal.InputMask = "{double:-9.3}"
        Me.ume_subtotal.Location = New System.Drawing.Point(778, 504)
        Me.ume_subtotal.Name = "ume_subtotal"
        Me.ume_subtotal.ReadOnly = True
        Me.ume_subtotal.Size = New System.Drawing.Size(109, 20)
        Me.ume_subtotal.TabIndex = 131
        '
        'ugb_cabecera
        '
        Me.ugb_cabecera.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ugb_cabecera.Controls.Add(Me.UltraLabel25)
        Me.ugb_cabecera.Controls.Add(Me.UltraLabel24)
        Me.ugb_cabecera.Controls.Add(Me.uck_Redondear)
        Me.ugb_cabecera.Controls.Add(Me.udtpFechaAlta)
        Me.ugb_cabecera.Controls.Add(Me.udtpFecha_Ingreso)
        Me.ugb_cabecera.Controls.Add(Me.UltraLabel23)
        Me.ugb_cabecera.Controls.Add(Me.ucm_Tipo)
        Me.ugb_cabecera.Controls.Add(Me.uce_Medico)
        Me.ugb_cabecera.Controls.Add(Me.UltraLabel5)
        Me.ugb_cabecera.Controls.Add(Me.txt_Des_ClienteC)
        Me.ugb_cabecera.Controls.Add(Me.uce_tip_doc)
        Me.ugb_cabecera.Controls.Add(Me.txt_Des_Cliente)
        Me.ugb_cabecera.Controls.Add(Me.txt_ruc_cliente)
        Me.ugb_cabecera.Controls.Add(Me.UltraLabel20)
        Me.ugb_cabecera.Controls.Add(Me.txt_IdCliente)
        Me.ugb_cabecera.Controls.Add(Me.UltraLabel22)
        Me.ugb_cabecera.Controls.Add(Me.txt_idHistoria)
        Me.ugb_cabecera.Controls.Add(Me.txt_idClienteC)
        Me.ugb_cabecera.Controls.Add(Me.txt_Ruc_ClientesC)
        Me.ugb_cabecera.Controls.Add(Me.UltraLabel21)
        Me.ugb_cabecera.Controls.Add(Me.txt_doc_pago)
        Me.ugb_cabecera.Controls.Add(Me.txt_ref_pago)
        Me.ugb_cabecera.Controls.Add(Me.uce_docu_pago)
        Me.ugb_cabecera.Controls.Add(Me.uce_FormaPago)
        Me.ugb_cabecera.Controls.Add(Me.UltraLabel11)
        Me.ugb_cabecera.Controls.Add(Me.uce_PuntoVenta)
        Me.ugb_cabecera.Controls.Add(Me.UltraLabel10)
        Me.ugb_cabecera.Controls.Add(Me.uce_Serie)
        Me.ugb_cabecera.Controls.Add(Me.UltraLabel8)
        Me.ugb_cabecera.Controls.Add(Me.ume_Tasa_Igv)
        Me.ugb_cabecera.Controls.Add(Me.UltraLabel14)
        Me.ugb_cabecera.Controls.Add(Me.ume_ValorTipoCambio)
        Me.ugb_cabecera.Controls.Add(Me.UltraLabel4)
        Me.ugb_cabecera.Controls.Add(Me.uce_Moneda)
        Me.ugb_cabecera.Controls.Add(Me.UltraLabel3)
        Me.ugb_cabecera.Controls.Add(Me.uce_TipoDoc)
        Me.ugb_cabecera.Controls.Add(Me.txt_NumDoc)
        Me.ugb_cabecera.Controls.Add(Me.UltraLabel9)
        Me.ugb_cabecera.Controls.Add(Me.lbludte_Fec_Ven)
        Me.ugb_cabecera.Controls.Add(Me.UltraLabel6)
        Me.ugb_cabecera.Controls.Add(Me.udte_fec_Ven)
        Me.ugb_cabecera.Controls.Add(Me.udte_fec_emi)
        Me.ugb_cabecera.Location = New System.Drawing.Point(9, 51)
        Me.ugb_cabecera.Name = "ugb_cabecera"
        Me.ugb_cabecera.Size = New System.Drawing.Size(878, 133)
        Me.ugb_cabecera.TabIndex = 0
        '
        'UltraLabel25
        '
        Me.UltraLabel25.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Appearance28.BackColor = System.Drawing.Color.Transparent
        Appearance28.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel25.Appearance = Appearance28
        Me.UltraLabel25.AutoSize = True
        Me.UltraLabel25.Location = New System.Drawing.Point(688, 87)
        Me.UltraLabel25.Name = "UltraLabel25"
        Me.UltraLabel25.Size = New System.Drawing.Size(49, 14)
        Me.UltraLabel25.TabIndex = 178
        Me.UltraLabel25.Text = "Fec. Alta"
        '
        'UltraLabel24
        '
        Me.UltraLabel24.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Appearance23.BackColor = System.Drawing.Color.Transparent
        Appearance23.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel24.Appearance = Appearance23
        Me.UltraLabel24.AutoSize = True
        Me.UltraLabel24.Location = New System.Drawing.Point(688, 63)
        Me.UltraLabel24.Name = "UltraLabel24"
        Me.UltraLabel24.Size = New System.Drawing.Size(67, 14)
        Me.UltraLabel24.TabIndex = 177
        Me.UltraLabel24.Text = "Fec. Ingreso"
        '
        'uck_Redondear
        '
        Appearance26.ForeColor = System.Drawing.Color.Navy
        Me.uck_Redondear.Appearance = Appearance26
        Me.uck_Redondear.BackColor = System.Drawing.Color.Transparent
        Me.uck_Redondear.BackColorInternal = System.Drawing.Color.Transparent
        Me.uck_Redondear.Location = New System.Drawing.Point(691, 108)
        Me.uck_Redondear.Name = "uck_Redondear"
        Me.uck_Redondear.Size = New System.Drawing.Size(85, 17)
        Me.uck_Redondear.TabIndex = 171
        Me.uck_Redondear.Text = "Redondeo"
        '
        'udtpFechaAlta
        '
        Me.udtpFechaAlta.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.udtpFechaAlta.Location = New System.Drawing.Point(764, 83)
        Me.udtpFechaAlta.MaskInput = "{date}"
        Me.udtpFechaAlta.Name = "udtpFechaAlta"
        Me.udtpFechaAlta.Size = New System.Drawing.Size(105, 21)
        Me.udtpFechaAlta.TabIndex = 176
        '
        'udtpFecha_Ingreso
        '
        Me.udtpFecha_Ingreso.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.udtpFecha_Ingreso.Location = New System.Drawing.Point(764, 59)
        Me.udtpFecha_Ingreso.MaskInput = "{date}"
        Me.udtpFecha_Ingreso.Name = "udtpFecha_Ingreso"
        Me.udtpFecha_Ingreso.Size = New System.Drawing.Size(105, 21)
        Me.udtpFecha_Ingreso.TabIndex = 175
        '
        'UltraLabel23
        '
        Appearance29.BackColor = System.Drawing.Color.Transparent
        Appearance29.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel23.Appearance = Appearance29
        Me.UltraLabel23.AutoSize = True
        Me.UltraLabel23.Location = New System.Drawing.Point(460, 87)
        Me.UltraLabel23.Name = "UltraLabel23"
        Me.UltraLabel23.Size = New System.Drawing.Size(73, 14)
        Me.UltraLabel23.TabIndex = 164
        Me.UltraLabel23.Text = "Tipo Atención"
        '
        'ucm_Tipo
        '
        Me.ucm_Tipo.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.ucm_Tipo.Location = New System.Drawing.Point(538, 83)
        Me.ucm_Tipo.Name = "ucm_Tipo"
        Me.ucm_Tipo.ReadOnly = True
        Me.ucm_Tipo.Size = New System.Drawing.Size(130, 21)
        Me.ucm_Tipo.TabIndex = 163
        '
        'uce_Medico
        '
        Me.uce_Medico.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Suggest
        Me.uce_Medico.Location = New System.Drawing.Point(61, 83)
        Me.uce_Medico.Name = "uce_Medico"
        Me.uce_Medico.Size = New System.Drawing.Size(388, 21)
        Me.uce_Medico.TabIndex = 162
        '
        'UltraLabel5
        '
        Appearance41.BackColor = System.Drawing.Color.Transparent
        Appearance41.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel5.Appearance = Appearance41
        Me.UltraLabel5.AutoSize = True
        Me.UltraLabel5.Location = New System.Drawing.Point(11, 87)
        Me.UltraLabel5.Name = "UltraLabel5"
        Me.UltraLabel5.Size = New System.Drawing.Size(41, 14)
        Me.UltraLabel5.TabIndex = 161
        Me.UltraLabel5.Text = "Médico"
        '
        'txt_Des_ClienteC
        '
        Me.txt_Des_ClienteC.Location = New System.Drawing.Point(227, 59)
        Me.txt_Des_ClienteC.Name = "txt_Des_ClienteC"
        Me.txt_Des_ClienteC.ReadOnly = True
        Me.txt_Des_ClienteC.Size = New System.Drawing.Size(292, 21)
        Me.txt_Des_ClienteC.TabIndex = 152
        '
        'uce_tip_doc
        '
        Me.uce_tip_doc.DropDownListWidth = 300
        Me.uce_tip_doc.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.uce_tip_doc.Location = New System.Drawing.Point(61, 35)
        Me.uce_tip_doc.Name = "uce_tip_doc"
        Me.uce_tip_doc.Size = New System.Drawing.Size(63, 21)
        Me.uce_tip_doc.TabIndex = 156
        '
        'txt_Des_Cliente
        '
        Me.txt_Des_Cliente.Location = New System.Drawing.Point(227, 35)
        Me.txt_Des_Cliente.Name = "txt_Des_Cliente"
        Me.txt_Des_Cliente.ReadOnly = True
        Me.txt_Des_Cliente.Size = New System.Drawing.Size(292, 21)
        Me.txt_Des_Cliente.TabIndex = 159
        '
        'txt_ruc_cliente
        '
        Appearance2.ImageHAlign = Infragistics.Win.HAlign.Center
        Appearance2.ImageVAlign = Infragistics.Win.VAlign.Middle
        EditorButton2.Appearance = Appearance2
        EditorButton2.Key = "ayuda"
        Me.txt_ruc_cliente.ButtonsRight.Add(EditorButton2)
        Me.txt_ruc_cliente.Location = New System.Drawing.Point(124, 35)
        Me.txt_ruc_cliente.MaxLength = 11
        Me.txt_ruc_cliente.Name = "txt_ruc_cliente"
        Me.txt_ruc_cliente.Size = New System.Drawing.Size(102, 21)
        Me.txt_ruc_cliente.TabIndex = 157
        '
        'UltraLabel20
        '
        Appearance13.BackColor = System.Drawing.Color.Transparent
        Appearance13.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel20.Appearance = Appearance13
        Me.UltraLabel20.AutoSize = True
        Me.UltraLabel20.Location = New System.Drawing.Point(11, 39)
        Me.UltraLabel20.Name = "UltraLabel20"
        Me.UltraLabel20.Size = New System.Drawing.Size(48, 14)
        Me.UltraLabel20.TabIndex = 160
        Me.UltraLabel20.Text = "Paciente"
        '
        'txt_IdCliente
        '
        Me.txt_IdCliente.Location = New System.Drawing.Point(106, 29)
        Me.txt_IdCliente.Name = "txt_IdCliente"
        Me.txt_IdCliente.Size = New System.Drawing.Size(37, 21)
        Me.txt_IdCliente.TabIndex = 158
        Me.txt_IdCliente.Visible = False
        '
        'UltraLabel22
        '
        Appearance12.BackColor = System.Drawing.Color.Transparent
        Appearance12.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel22.Appearance = Appearance12
        Me.UltraLabel22.AutoSize = True
        Me.UltraLabel22.Location = New System.Drawing.Point(524, 39)
        Me.UltraLabel22.Name = "UltraLabel22"
        Me.UltraLabel22.Size = New System.Drawing.Size(27, 14)
        Me.UltraLabel22.TabIndex = 155
        Me.UltraLabel22.Text = "H.C."
        '
        'txt_idHistoria
        '
        Me.txt_idHistoria.Location = New System.Drawing.Point(564, 35)
        Me.txt_idHistoria.Name = "txt_idHistoria"
        Me.txt_idHistoria.ReadOnly = True
        Me.txt_idHistoria.Size = New System.Drawing.Size(104, 21)
        Me.txt_idHistoria.TabIndex = 154
        '
        'txt_idClienteC
        '
        Me.txt_idClienteC.Location = New System.Drawing.Point(187, 59)
        Me.txt_idClienteC.Name = "txt_idClienteC"
        Me.txt_idClienteC.Size = New System.Drawing.Size(39, 21)
        Me.txt_idClienteC.TabIndex = 151
        '
        'txt_Ruc_ClientesC
        '
        Appearance111.ImageHAlign = Infragistics.Win.HAlign.Center
        Appearance111.ImageVAlign = Infragistics.Win.VAlign.Middle
        EditorButton3.Appearance = Appearance111
        EditorButton3.Key = "ayuda"
        Me.txt_Ruc_ClientesC.ButtonsRight.Add(EditorButton3)
        Me.txt_Ruc_ClientesC.Location = New System.Drawing.Point(61, 59)
        Me.txt_Ruc_ClientesC.MaxLength = 11
        Me.txt_Ruc_ClientesC.Name = "txt_Ruc_ClientesC"
        Me.txt_Ruc_ClientesC.Size = New System.Drawing.Size(126, 21)
        Me.txt_Ruc_ClientesC.TabIndex = 150
        '
        'UltraLabel21
        '
        Appearance8.BackColor = System.Drawing.Color.Transparent
        Appearance8.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel21.Appearance = Appearance8
        Me.UltraLabel21.AutoSize = True
        Me.UltraLabel21.Location = New System.Drawing.Point(11, 63)
        Me.UltraLabel21.Name = "UltraLabel21"
        Me.UltraLabel21.Size = New System.Drawing.Size(40, 14)
        Me.UltraLabel21.TabIndex = 153
        Me.UltraLabel21.Text = "Cliente"
        '
        'txt_doc_pago
        '
        Me.txt_doc_pago.Location = New System.Drawing.Point(448, 107)
        Me.txt_doc_pago.Name = "txt_doc_pago"
        Me.txt_doc_pago.ReadOnly = True
        Me.txt_doc_pago.Size = New System.Drawing.Size(83, 21)
        Me.txt_doc_pago.TabIndex = 149
        '
        'txt_ref_pago
        '
        Me.txt_ref_pago.Location = New System.Drawing.Point(531, 107)
        Me.txt_ref_pago.Name = "txt_ref_pago"
        Me.txt_ref_pago.Size = New System.Drawing.Size(137, 21)
        Me.txt_ref_pago.TabIndex = 147
        '
        'uce_docu_pago
        '
        Me.uce_docu_pago.DropDownListWidth = 100
        Me.uce_docu_pago.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.uce_docu_pago.Location = New System.Drawing.Point(447, 107)
        Me.uce_docu_pago.Name = "uce_docu_pago"
        Me.uce_docu_pago.Size = New System.Drawing.Size(75, 21)
        Me.uce_docu_pago.TabIndex = 146
        '
        'uce_FormaPago
        '
        Me.uce_FormaPago.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.uce_FormaPago.Location = New System.Drawing.Point(340, 107)
        Me.uce_FormaPago.Name = "uce_FormaPago"
        Me.uce_FormaPago.Size = New System.Drawing.Size(107, 21)
        Me.uce_FormaPago.TabIndex = 144
        '
        'UltraLabel11
        '
        Appearance9.BackColor = System.Drawing.Color.Transparent
        Appearance9.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel11.Appearance = Appearance9
        Me.UltraLabel11.AutoSize = True
        Me.UltraLabel11.Location = New System.Drawing.Point(273, 110)
        Me.UltraLabel11.Name = "UltraLabel11"
        Me.UltraLabel11.Size = New System.Drawing.Size(66, 14)
        Me.UltraLabel11.TabIndex = 143
        Me.UltraLabel11.Text = "Forma Pago"
        '
        'uce_PuntoVenta
        '
        Me.uce_PuntoVenta.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.uce_PuntoVenta.Location = New System.Drawing.Point(61, 11)
        Me.uce_PuntoVenta.Name = "uce_PuntoVenta"
        Me.uce_PuntoVenta.Size = New System.Drawing.Size(132, 21)
        Me.uce_PuntoVenta.TabIndex = 142
        '
        'UltraLabel10
        '
        Appearance33.BackColor = System.Drawing.Color.Transparent
        Appearance33.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel10.Appearance = Appearance33
        Me.UltraLabel10.AutoSize = True
        Me.UltraLabel10.Location = New System.Drawing.Point(11, 15)
        Me.UltraLabel10.Name = "UltraLabel10"
        Me.UltraLabel10.Size = New System.Drawing.Size(41, 14)
        Me.UltraLabel10.TabIndex = 141
        Me.UltraLabel10.Text = "Pto Vta"
        '
        'uce_Serie
        '
        Me.uce_Serie.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.uce_Serie.Location = New System.Drawing.Point(374, 11)
        Me.uce_Serie.Name = "uce_Serie"
        Me.uce_Serie.Size = New System.Drawing.Size(94, 21)
        Me.uce_Serie.TabIndex = 140
        '
        'UltraLabel8
        '
        Appearance58.BackColor = System.Drawing.Color.Transparent
        Appearance58.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel8.Appearance = Appearance58
        Me.UltraLabel8.AutoSize = True
        Me.UltraLabel8.Location = New System.Drawing.Point(253, 110)
        Me.UltraLabel8.Name = "UltraLabel8"
        Me.UltraLabel8.Size = New System.Drawing.Size(14, 14)
        Me.UltraLabel8.TabIndex = 139
        Me.UltraLabel8.Text = "%"
        '
        'ume_Tasa_Igv
        '
        Appearance66.TextHAlignAsString = "Right"
        Me.ume_Tasa_Igv.Appearance = Appearance66
        Me.ume_Tasa_Igv.EditAs = Infragistics.Win.UltraWinMaskedEdit.EditAsType.UseSpecifiedMask
        Me.ume_Tasa_Igv.InputMask = "nn"
        Me.ume_Tasa_Igv.Location = New System.Drawing.Point(224, 107)
        Me.ume_Tasa_Igv.Name = "ume_Tasa_Igv"
        Me.ume_Tasa_Igv.ReadOnly = True
        Me.ume_Tasa_Igv.Size = New System.Drawing.Size(29, 20)
        Me.ume_Tasa_Igv.TabIndex = 136
        '
        'UltraLabel14
        '
        Appearance10.BackColor = System.Drawing.Color.Transparent
        Appearance10.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel14.Appearance = Appearance10
        Me.UltraLabel14.AutoSize = True
        Me.UltraLabel14.Location = New System.Drawing.Point(198, 110)
        Me.UltraLabel14.Name = "UltraLabel14"
        Me.UltraLabel14.Size = New System.Drawing.Size(24, 14)
        Me.UltraLabel14.TabIndex = 138
        Me.UltraLabel14.Text = "IGV "
        '
        'ume_ValorTipoCambio
        '
        Appearance44.TextHAlignAsString = "Right"
        Me.ume_ValorTipoCambio.Appearance = Appearance44
        Me.ume_ValorTipoCambio.EditAs = Infragistics.Win.UltraWinMaskedEdit.EditAsType.UseSpecifiedMask
        Me.ume_ValorTipoCambio.InputMask = "{double:1.3}"
        Me.ume_ValorTipoCambio.Location = New System.Drawing.Point(153, 107)
        Me.ume_ValorTipoCambio.Name = "ume_ValorTipoCambio"
        Me.ume_ValorTipoCambio.ReadOnly = True
        Me.ume_ValorTipoCambio.Size = New System.Drawing.Size(38, 20)
        Me.ume_ValorTipoCambio.TabIndex = 132
        '
        'UltraLabel4
        '
        Appearance5.BackColor = System.Drawing.Color.Transparent
        Appearance5.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel4.Appearance = Appearance5
        Me.UltraLabel4.AutoSize = True
        Me.UltraLabel4.Location = New System.Drawing.Point(125, 110)
        Me.UltraLabel4.Name = "UltraLabel4"
        Me.UltraLabel4.Size = New System.Drawing.Size(26, 14)
        Me.UltraLabel4.TabIndex = 130
        Me.UltraLabel4.Text = "T.C."
        '
        'txt_num_voucher_conta
        '
        Me.txt_num_voucher_conta.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_num_voucher_conta.Location = New System.Drawing.Point(172, 29)
        Me.txt_num_voucher_conta.Name = "txt_num_voucher_conta"
        Me.txt_num_voucher_conta.ReadOnly = True
        Me.txt_num_voucher_conta.Size = New System.Drawing.Size(88, 21)
        Me.txt_num_voucher_conta.TabIndex = 148
        '
        'UltraLabel12
        '
        Me.UltraLabel12.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Appearance37.BackColor = System.Drawing.Color.Transparent
        Appearance37.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel12.Appearance = Appearance37
        Me.UltraLabel12.AutoSize = True
        Me.UltraLabel12.Location = New System.Drawing.Point(104, 33)
        Me.UltraLabel12.Name = "UltraLabel12"
        Me.UltraLabel12.Size = New System.Drawing.Size(62, 14)
        Me.UltraLabel12.TabIndex = 147
        Me.UltraLabel12.Text = "Nº Voucher"
        '
        'txt_IdComprobante
        '
        Me.txt_IdComprobante.Location = New System.Drawing.Point(172, 30)
        Me.txt_IdComprobante.Name = "txt_IdComprobante"
        Me.txt_IdComprobante.ReadOnly = True
        Me.txt_IdComprobante.Size = New System.Drawing.Size(33, 20)
        Me.txt_IdComprobante.TabIndex = 145
        Me.txt_IdComprobante.Visible = False
        '
        'uds_detalle
        '
        Me.uds_detalle.Band.AllowAdd = Infragistics.Win.DefaultableBoolean.[True]
        Me.uds_detalle.Band.AllowDelete = Infragistics.Win.DefaultableBoolean.[True]
        UltraDataColumn1.DataType = GetType(Short)
        UltraDataColumn2.DataType = GetType(Short)
        UltraDataColumn3.DataType = GetType(Integer)
        UltraDataColumn5.DataType = GetType(Double)
        UltraDataColumn6.DataType = GetType(Double)
        UltraDataColumn7.DataType = GetType(Double)
        UltraDataColumn8.DataType = GetType(Double)
        UltraDataColumn9.DataType = GetType(Double)
        UltraDataColumn10.DataType = GetType(Double)
        UltraDataColumn11.DataType = GetType(Short)
        UltraDataColumn12.DataType = GetType(Integer)
        UltraDataColumn13.DataType = GetType(Integer)
        Me.uds_detalle.Band.Columns.AddRange(New Object() {UltraDataColumn1, UltraDataColumn2, UltraDataColumn3, UltraDataColumn4, UltraDataColumn5, UltraDataColumn6, UltraDataColumn7, UltraDataColumn8, UltraDataColumn9, UltraDataColumn10, UltraDataColumn11, UltraDataColumn12, UltraDataColumn13})
        '
        'ug_Detalle
        '
        Me.ug_Detalle.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ug_Detalle.DataSource = Me.uds_detalle
        Me.ug_Detalle.DisplayLayout.AutoFitStyle = Infragistics.Win.UltraWinGrid.AutoFitStyle.ExtendLastColumn
        UltraGridColumn1.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn1.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn1.Header.VisiblePosition = 0
        UltraGridColumn1.Hidden = True
        UltraGridColumn1.Width = 34
        UltraGridColumn2.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        Appearance25.TextHAlignAsString = "Center"
        UltraGridColumn2.CellAppearance = Appearance25
        UltraGridColumn2.Header.VisiblePosition = 1
        UltraGridColumn2.Width = 42
        UltraGridColumn3.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn3.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn3.Header.Caption = "Cod. Art."
        UltraGridColumn3.Header.VisiblePosition = 2
        UltraGridColumn3.Width = 55
        UltraGridColumn4.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn4.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn4.Header.Caption = "Descripcion"
        UltraGridColumn4.Header.VisiblePosition = 3
        UltraGridColumn4.Width = 248
        UltraGridColumn5.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        Appearance32.TextHAlignAsString = "Right"
        UltraGridColumn5.CellAppearance = Appearance32
        UltraGridColumn5.Header.Caption = "Precio Unit. S/."
        UltraGridColumn5.Header.VisiblePosition = 4
        UltraGridColumn5.MaskDisplayMode = Infragistics.Win.UltraWinMaskedEdit.MaskMode.IncludeLiterals
        UltraGridColumn5.MinWidth = 8
        UltraGridColumn5.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Double]
        UltraGridColumn5.Width = 85
        UltraGridColumn6.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn6.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        Appearance35.TextHAlignAsString = "Right"
        UltraGridColumn6.CellAppearance = Appearance35
        UltraGridColumn6.Header.Caption = "DSCTO SEG."
        UltraGridColumn6.Header.VisiblePosition = 5
        UltraGridColumn6.MinWidth = 8
        UltraGridColumn6.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Double]
        UltraGridColumn6.Width = 85
        UltraGridColumn7.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        Appearance36.TextHAlignAsString = "Right"
        UltraGridColumn7.CellAppearance = Appearance36
        UltraGridColumn7.Header.Caption = "DSCTO OTRO"
        UltraGridColumn7.Header.VisiblePosition = 6
        UltraGridColumn7.MinWidth = 8
        UltraGridColumn7.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Double]
        UltraGridColumn7.Width = 85
        UltraGridColumn8.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn8.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        Appearance39.TextHAlignAsString = "Right"
        UltraGridColumn8.CellAppearance = Appearance39
        UltraGridColumn8.Header.VisiblePosition = 7
        UltraGridColumn8.MaskDisplayMode = Infragistics.Win.UltraWinMaskedEdit.MaskMode.IncludeLiterals
        UltraGridColumn8.MinWidth = 8
        UltraGridColumn8.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Double]
        UltraGridColumn8.Width = 85
        UltraGridColumn9.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn9.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        Appearance40.TextHAlignAsString = "Right"
        UltraGridColumn9.CellAppearance = Appearance40
        UltraGridColumn9.Header.VisiblePosition = 8
        UltraGridColumn9.MaskDisplayMode = Infragistics.Win.UltraWinMaskedEdit.MaskMode.IncludeLiterals
        UltraGridColumn9.MinWidth = 8
        UltraGridColumn9.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Double]
        UltraGridColumn9.Width = 87
        UltraGridColumn10.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn10.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        Appearance45.TextHAlignAsString = "Right"
        UltraGridColumn10.CellAppearance = Appearance45
        UltraGridColumn10.Header.VisiblePosition = 9
        UltraGridColumn10.MaskDisplayMode = Infragistics.Win.UltraWinMaskedEdit.MaskMode.IncludeLiterals
        UltraGridColumn10.MinWidth = 8
        UltraGridColumn10.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Double]
        UltraGridColumn10.Width = 85
        UltraGridColumn11.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn11.Header.VisiblePosition = 10
        UltraGridColumn11.Hidden = True
        UltraGridColumn11.Width = 20
        UltraGridColumn12.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn12.Header.VisiblePosition = 11
        UltraGridColumn12.Hidden = True
        UltraGridColumn13.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn13.Header.VisiblePosition = 12
        UltraGridColumn13.Hidden = True
        UltraGridBand1.Columns.AddRange(New Object() {UltraGridColumn1, UltraGridColumn2, UltraGridColumn3, UltraGridColumn4, UltraGridColumn5, UltraGridColumn6, UltraGridColumn7, UltraGridColumn8, UltraGridColumn9, UltraGridColumn10, UltraGridColumn11, UltraGridColumn12, UltraGridColumn13})
        UltraGridBand1.SummaryFooterCaption = "Totales"
        Me.ug_Detalle.DisplayLayout.BandsSerializer.Add(UltraGridBand1)
        Me.ug_Detalle.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.[False]
        Me.ug_Detalle.DisplayLayout.MaxColScrollRegions = 1
        Me.ug_Detalle.DisplayLayout.MaxRowScrollRegions = 1
        Me.ug_Detalle.DisplayLayout.Override.AllowDelete = Infragistics.Win.DefaultableBoolean.[True]
        Me.ug_Detalle.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.ug_Detalle.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.ug_Detalle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ug_Detalle.Location = New System.Drawing.Point(9, 190)
        Me.ug_Detalle.Name = "ug_Detalle"
        Me.ug_Detalle.Size = New System.Drawing.Size(878, 312)
        Me.ug_Detalle.TabIndex = 1
        Me.ug_Detalle.Text = "UltraGrid1"
        '
        'ubtn_agregar
        '
        Me.ubtn_agregar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.ubtn_agregar.Location = New System.Drawing.Point(8, 502)
        Me.ubtn_agregar.Name = "ubtn_agregar"
        Me.ubtn_agregar.Size = New System.Drawing.Size(108, 26)
        Me.ubtn_agregar.TabIndex = 135
        Me.ubtn_agregar.Text = "Añadir Articulo"
        '
        'ubtn_quitar
        '
        Me.ubtn_quitar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.ubtn_quitar.Location = New System.Drawing.Point(117, 502)
        Me.ubtn_quitar.Name = "ubtn_quitar"
        Me.ubtn_quitar.Size = New System.Drawing.Size(113, 26)
        Me.ubtn_quitar.TabIndex = 135
        Me.ubtn_quitar.Text = "Quitar Articulo"
        '
        'UltraLabel7
        '
        Me.UltraLabel7.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Appearance34.BackColor = System.Drawing.Color.Transparent
        Appearance34.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel7.Appearance = Appearance34
        Me.UltraLabel7.AutoSize = True
        Me.UltraLabel7.Location = New System.Drawing.Point(13, 543)
        Me.UltraLabel7.Name = "UltraLabel7"
        Me.UltraLabel7.Size = New System.Drawing.Size(40, 14)
        Me.UltraLabel7.TabIndex = 136
        Me.UltraLabel7.Text = "Notas :"
        '
        'txt_notas
        '
        Me.txt_notas.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        EditorButton4.Key = "btn_des_cli"
        Me.txt_notas.ButtonsRight.Add(EditorButton4)
        Me.txt_notas.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_notas.Location = New System.Drawing.Point(59, 539)
        Me.txt_notas.MaxLength = 250
        Me.txt_notas.Name = "txt_notas"
        Me.txt_notas.Size = New System.Drawing.Size(553, 21)
        Me.txt_notas.TabIndex = 137
        '
        'usb_compro
        '
        Me.usb_compro.Location = New System.Drawing.Point(0, 566)
        Me.usb_compro.Name = "usb_compro"
        Appearance22.ForeColor = System.Drawing.Color.Navy
        UltraStatusPanel1.Appearance = Appearance22
        UltraStatusPanel1.Key = "usp_usuario"
        UltraStatusPanel1.Width = 200
        Me.usb_compro.Panels.AddRange(New Infragistics.Win.UltraWinStatusBar.UltraStatusPanel() {UltraStatusPanel1})
        Me.usb_compro.Size = New System.Drawing.Size(899, 20)
        Me.usb_compro.TabIndex = 140
        Me.usb_compro.Text = "UltraStatusBar1"
        '
        'ToolS_Mantenimiento
        '
        Me.ToolS_Mantenimiento.BackColor = System.Drawing.Color.White
        Me.ToolS_Mantenimiento.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Tool_Nuevo, Me.ToolStripSeparator1, Me.ToolStripSeparator4, Me.Tool_Grabar, Me.ToolStripSeparator3, Me.ToolStripSeparator5, Me.Tool_Cancelar, Me.ToolStripSeparator2, Me.Tool_Imprimir, Me.ToolStripSeparator7, Me.Tool_Salir, Me.ToolStripSeparator6})
        Me.ToolS_Mantenimiento.Location = New System.Drawing.Point(0, 0)
        Me.ToolS_Mantenimiento.Name = "ToolS_Mantenimiento"
        Me.ToolS_Mantenimiento.Size = New System.Drawing.Size(899, 25)
        Me.ToolS_Mantenimiento.TabIndex = 141
        Me.ToolS_Mantenimiento.Text = "ToolStrip1"
        '
        'Tool_Nuevo
        '
        Me.Tool_Nuevo.Image = Global.Contabilidad.My.Resources.Resources._16__File_new_2_
        Me.Tool_Nuevo.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Tool_Nuevo.Name = "Tool_Nuevo"
        Me.Tool_Nuevo.Size = New System.Drawing.Size(83, 22)
        Me.Tool_Nuevo.Text = "Nuevo       "
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(6, 25)
        '
        'Tool_Grabar
        '
        Me.Tool_Grabar.Image = Global.Contabilidad.My.Resources.Resources._003
        Me.Tool_Grabar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Tool_Grabar.Name = "Tool_Grabar"
        Me.Tool_Grabar.Size = New System.Drawing.Size(74, 22)
        Me.Tool_Grabar.Text = "Grabar    "
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripSeparator5
        '
        Me.ToolStripSeparator5.Name = "ToolStripSeparator5"
        Me.ToolStripSeparator5.Size = New System.Drawing.Size(6, 25)
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
        'Tool_Imprimir
        '
        Me.Tool_Imprimir.Image = Global.Contabilidad.My.Resources.Resources._004
        Me.Tool_Imprimir.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Tool_Imprimir.Name = "Tool_Imprimir"
        Me.Tool_Imprimir.Size = New System.Drawing.Size(73, 22)
        Me.Tool_Imprimir.Text = "Imprimir"
        '
        'ToolStripSeparator7
        '
        Me.ToolStripSeparator7.Name = "ToolStripSeparator7"
        Me.ToolStripSeparator7.Size = New System.Drawing.Size(6, 25)
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
        'ugb_docref
        '
        Me.ugb_docref.Controls.Add(Me.UltraLabel19)
        Me.ugb_docref.Controls.Add(Me.ubtn_aceptar)
        Me.ugb_docref.Controls.Add(Me.ume_fec_ven_ref)
        Me.ugb_docref.Controls.Add(Me.ume_fec_emi_ref)
        Me.ugb_docref.Controls.Add(Me.txt_numero_ref)
        Me.ugb_docref.Controls.Add(Me.txt_serie_ref)
        Me.ugb_docref.Controls.Add(Me.uce_TipDocRef)
        Me.ugb_docref.Controls.Add(Me.UltraLabel18)
        Me.ugb_docref.Controls.Add(Me.UltraLabel17)
        Me.ugb_docref.Controls.Add(Me.UltraLabel16)
        Me.ugb_docref.Controls.Add(Me.UltraLabel15)
        Me.ugb_docref.Controls.Add(Me.UltraLabel13)
        Me.ugb_docref.Location = New System.Drawing.Point(286, 221)
        Me.ugb_docref.Name = "ugb_docref"
        Me.ugb_docref.Size = New System.Drawing.Size(326, 140)
        Me.ugb_docref.TabIndex = 142
        Me.ugb_docref.Text = "Documento de Referencia"
        Me.ugb_docref.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2003
        Me.ugb_docref.Visible = False
        '
        'UltraLabel19
        '
        Appearance43.BackColor = System.Drawing.Color.Transparent
        Appearance43.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel19.Appearance = Appearance43
        Me.UltraLabel19.AutoSize = True
        Me.UltraLabel19.Location = New System.Drawing.Point(14, 109)
        Me.UltraLabel19.Name = "UltraLabel19"
        Me.UltraLabel19.Size = New System.Drawing.Size(210, 14)
        Me.UltraLabel19.TabIndex = 125
        Me.UltraLabel19.Text = "_________________________________"
        '
        'ubtn_aceptar
        '
        Me.ubtn_aceptar.Location = New System.Drawing.Point(238, 109)
        Me.ubtn_aceptar.Name = "ubtn_aceptar"
        Me.ubtn_aceptar.Size = New System.Drawing.Size(75, 23)
        Me.ubtn_aceptar.TabIndex = 5
        Me.ubtn_aceptar.Text = "Aceptar"
        '
        'ume_fec_ven_ref
        '
        Me.ume_fec_ven_ref.EditAs = Infragistics.Win.UltraWinMaskedEdit.EditAsType.UseSpecifiedMask
        Me.ume_fec_ven_ref.InputMask = "{LOC}dd/mm/yyyy"
        Me.ume_fec_ven_ref.Location = New System.Drawing.Point(239, 77)
        Me.ume_fec_ven_ref.Name = "ume_fec_ven_ref"
        Me.ume_fec_ven_ref.ReadOnly = True
        Me.ume_fec_ven_ref.Size = New System.Drawing.Size(74, 20)
        Me.ume_fec_ven_ref.TabIndex = 4
        Me.ume_fec_ven_ref.Text = "UltraMaskedEdit1"
        '
        'ume_fec_emi_ref
        '
        Me.ume_fec_emi_ref.EditAs = Infragistics.Win.UltraWinMaskedEdit.EditAsType.UseSpecifiedMask
        Me.ume_fec_emi_ref.InputMask = "{LOC}dd/mm/yyyy"
        Me.ume_fec_emi_ref.Location = New System.Drawing.Point(239, 54)
        Me.ume_fec_emi_ref.Name = "ume_fec_emi_ref"
        Me.ume_fec_emi_ref.ReadOnly = True
        Me.ume_fec_emi_ref.Size = New System.Drawing.Size(74, 20)
        Me.ume_fec_emi_ref.TabIndex = 3
        Me.ume_fec_emi_ref.Text = "UltraMaskedEdit1"
        '
        'txt_numero_ref
        '
        Me.txt_numero_ref.Location = New System.Drawing.Point(68, 76)
        Me.txt_numero_ref.Name = "txt_numero_ref"
        Me.txt_numero_ref.ReadOnly = True
        Me.txt_numero_ref.Size = New System.Drawing.Size(104, 21)
        Me.txt_numero_ref.TabIndex = 2
        '
        'txt_serie_ref
        '
        Me.txt_serie_ref.Location = New System.Drawing.Point(88, 53)
        Me.txt_serie_ref.Name = "txt_serie_ref"
        Me.txt_serie_ref.ReadOnly = True
        Me.txt_serie_ref.Size = New System.Drawing.Size(84, 21)
        Me.txt_serie_ref.TabIndex = 1
        '
        'uce_TipDocRef
        '
        Me.uce_TipDocRef.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.uce_TipDocRef.Location = New System.Drawing.Point(88, 29)
        Me.uce_TipDocRef.Name = "uce_TipDocRef"
        Me.uce_TipDocRef.ReadOnly = True
        Me.uce_TipDocRef.Size = New System.Drawing.Size(84, 21)
        Me.uce_TipDocRef.TabIndex = 0
        '
        'UltraLabel18
        '
        Appearance24.BackColor = System.Drawing.Color.Transparent
        Appearance24.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel18.Appearance = Appearance24
        Me.UltraLabel18.AutoSize = True
        Me.UltraLabel18.Location = New System.Drawing.Point(178, 80)
        Me.UltraLabel18.Name = "UltraLabel18"
        Me.UltraLabel18.Size = New System.Drawing.Size(53, 14)
        Me.UltraLabel18.TabIndex = 124
        Me.UltraLabel18.Text = "Fec. Ven."
        '
        'UltraLabel17
        '
        Appearance42.BackColor = System.Drawing.Color.Transparent
        Appearance42.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel17.Appearance = Appearance42
        Me.UltraLabel17.AutoSize = True
        Me.UltraLabel17.Location = New System.Drawing.Point(179, 57)
        Me.UltraLabel17.Name = "UltraLabel17"
        Me.UltraLabel17.Size = New System.Drawing.Size(52, 14)
        Me.UltraLabel17.TabIndex = 124
        Me.UltraLabel17.Text = "Fec. Emi."
        '
        'UltraLabel16
        '
        Appearance31.BackColor = System.Drawing.Color.Transparent
        Appearance31.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel16.Appearance = Appearance31
        Me.UltraLabel16.AutoSize = True
        Me.UltraLabel16.Location = New System.Drawing.Point(10, 80)
        Me.UltraLabel16.Name = "UltraLabel16"
        Me.UltraLabel16.Size = New System.Drawing.Size(44, 14)
        Me.UltraLabel16.TabIndex = 124
        Me.UltraLabel16.Text = "Numero"
        '
        'UltraLabel15
        '
        Appearance27.BackColor = System.Drawing.Color.Transparent
        Appearance27.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel15.Appearance = Appearance27
        Me.UltraLabel15.AutoSize = True
        Me.UltraLabel15.Location = New System.Drawing.Point(10, 57)
        Me.UltraLabel15.Name = "UltraLabel15"
        Me.UltraLabel15.Size = New System.Drawing.Size(31, 14)
        Me.UltraLabel15.TabIndex = 124
        Me.UltraLabel15.Text = "Serie"
        '
        'UltraLabel13
        '
        Appearance30.BackColor = System.Drawing.Color.Transparent
        Appearance30.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel13.Appearance = Appearance30
        Me.UltraLabel13.AutoSize = True
        Me.UltraLabel13.Location = New System.Drawing.Point(9, 33)
        Me.UltraLabel13.Name = "UltraLabel13"
        Me.UltraLabel13.Size = New System.Drawing.Size(73, 14)
        Me.UltraLabel13.TabIndex = 124
        Me.UltraLabel13.Text = "Comprobante"
        '
        'FA_PR_Emi_ComproFacturacion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(899, 586)
        Me.Controls.Add(Me.txt_IdComprobante)
        Me.Controls.Add(Me.txt_num_voucher_conta)
        Me.Controls.Add(Me.UltraLabel12)
        Me.Controls.Add(Me.ugb_docref)
        Me.Controls.Add(Me.ToolS_Mantenimiento)
        Me.Controls.Add(Me.usb_compro)
        Me.Controls.Add(Me.txt_notas)
        Me.Controls.Add(Me.UltraLabel7)
        Me.Controls.Add(Me.ubtn_quitar)
        Me.Controls.Add(Me.ubtn_agregar)
        Me.Controls.Add(Me.ug_Detalle)
        Me.Controls.Add(Me.ugb_cabecera)
        Me.Controls.Add(Me.ume_subtotal)
        Me.Controls.Add(Me.UltraLabel2)
        Me.Controls.Add(Me.ume_igv)
        Me.Controls.Add(Me.UltraLabel1)
        Me.Controls.Add(Me.ume_total)
        Me.Controls.Add(Me.UltraLabel32)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FA_PR_Emi_ComproFacturacion"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Emision de Comprobantes (prestaciones)"
        CType(Me.udte_fec_Ven, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.udte_fec_emi, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.uce_TipoDoc, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_NumDoc, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.uce_Moneda, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ugb_cabecera, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ugb_cabecera.ResumeLayout(False)
        Me.ugb_cabecera.PerformLayout()
        CType(Me.udtpFechaAlta, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.udtpFecha_Ingreso, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ucm_Tipo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.uce_Medico, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_Des_ClienteC, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.uce_tip_doc, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_Des_Cliente, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_ruc_cliente, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_IdCliente, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_idHistoria, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_idClienteC, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_Ruc_ClientesC, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_doc_pago, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_ref_pago, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.uce_docu_pago, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.uce_FormaPago, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.uce_PuntoVenta, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.uce_Serie, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_num_voucher_conta, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.uds_detalle, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ug_Detalle, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_notas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolS_Mantenimiento.ResumeLayout(False)
        Me.ToolS_Mantenimiento.PerformLayout()
        CType(Me.ugb_docref, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ugb_docref.ResumeLayout(False)
        Me.ugb_docref.PerformLayout()
        CType(Me.txt_numero_ref, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_serie_ref, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.uce_TipDocRef, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lbludte_Fec_Ven As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel6 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents udte_fec_Ven As Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
    Friend WithEvents udte_fec_emi As Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
    Friend WithEvents uce_TipoDoc As Infragistics.Win.UltraWinEditors.UltraComboEditor
    Friend WithEvents txt_NumDoc As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents UltraLabel9 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents uce_Moneda As Infragistics.Win.UltraWinEditors.UltraComboEditor
    Friend WithEvents UltraLabel3 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents ume_total As Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit
    Friend WithEvents UltraLabel32 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel1 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents ume_igv As Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit
    Friend WithEvents UltraLabel2 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents ume_subtotal As Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit
    Friend WithEvents ugb_cabecera As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents uds_detalle As Infragistics.Win.UltraWinDataSource.UltraDataSource
    Friend WithEvents ume_ValorTipoCambio As Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit
    Friend WithEvents UltraLabel4 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents ubtn_agregar As Infragistics.Win.Misc.UltraButton
    Friend WithEvents ubtn_quitar As Infragistics.Win.Misc.UltraButton
    Friend WithEvents UltraLabel7 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents txt_notas As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents usb_compro As Infragistics.Win.UltraWinStatusBar.UltraStatusBar
    Friend WithEvents ume_Tasa_Igv As Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit
    Friend WithEvents UltraLabel14 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel8 As Infragistics.Win.Misc.UltraLabel
    Public WithEvents ug_Detalle As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents uce_Serie As Infragistics.Win.UltraWinEditors.UltraComboEditor
    Friend WithEvents UltraLabel10 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents uce_PuntoVenta As Infragistics.Win.UltraWinEditors.UltraComboEditor
    Friend WithEvents uce_FormaPago As Infragistics.Win.UltraWinEditors.UltraComboEditor
    Friend WithEvents UltraLabel11 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents ToolS_Mantenimiento As System.Windows.Forms.ToolStrip
    Friend WithEvents Tool_Nuevo As System.Windows.Forms.ToolStripButton
    Friend WithEvents Tool_Grabar As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents Tool_Cancelar As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents Tool_Salir As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator7 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents Tool_Imprimir As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator6 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator5 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents txt_IdComprobante As System.Windows.Forms.TextBox
    Friend WithEvents UltraLabel12 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents ugb_docref As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents ume_fec_ven_ref As Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit
    Friend WithEvents ume_fec_emi_ref As Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit
    Friend WithEvents txt_numero_ref As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents txt_serie_ref As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents uce_TipDocRef As Infragistics.Win.UltraWinEditors.UltraComboEditor
    Friend WithEvents UltraLabel18 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel17 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel16 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel15 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel13 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents ubtn_aceptar As Infragistics.Win.Misc.UltraButton
    Friend WithEvents txt_num_voucher_conta As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents UltraLabel19 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents uce_docu_pago As Infragistics.Win.UltraWinEditors.UltraComboEditor
    Friend WithEvents txt_ref_pago As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents txt_doc_pago As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents txt_idClienteC As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents txt_Des_ClienteC As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents txt_Ruc_ClientesC As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents UltraLabel21 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel22 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents txt_idHistoria As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents uce_tip_doc As Infragistics.Win.UltraWinEditors.UltraComboEditor
    Friend WithEvents txt_Des_Cliente As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents txt_ruc_cliente As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents UltraLabel20 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents txt_IdCliente As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents UltraLabel5 As Infragistics.Win.Misc.UltraLabel
    Public WithEvents uce_Medico As Infragistics.Win.UltraWinEditors.UltraComboEditor
    Friend WithEvents UltraLabel23 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents ucm_Tipo As Infragistics.Win.UltraWinEditors.UltraComboEditor
    Friend WithEvents uck_Redondear As Infragistics.Win.UltraWinEditors.UltraCheckEditor
    Friend WithEvents udtpFechaAlta As Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
    Friend WithEvents udtpFecha_Ingreso As Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
    Friend WithEvents UltraLabel25 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel24 As Infragistics.Win.Misc.UltraLabel
End Class
