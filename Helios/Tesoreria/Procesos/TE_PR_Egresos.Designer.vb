<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TE_PR_Egresos
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
        Dim Appearance15 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance44 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance26 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance2 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance94 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance98 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance13 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance1 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance21 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance11 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance5 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance56 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance18 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance24 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim EditorButton1 As Infragistics.Win.UltraWinEditors.EditorButton = New Infragistics.Win.UltraWinEditors.EditorButton("Ayuda")
        Dim Appearance111 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance90 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraDataColumn1 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Tipo")
        Dim UltraDataColumn2 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Serie")
        Dim UltraDataColumn3 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("documento")
        Dim UltraDataColumn4 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("importe")
        Dim UltraDataColumn5 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("importe_ori")
        Dim UltraDataColumn6 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("comentario")
        Dim UltraDataColumn7 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("tc")
        Dim UltraDataColumn8 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("cuenta")
        Dim UltraDataColumn9 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("cod_TD")
        Dim UltraDataColumn10 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("fecha_TD")
        Dim Appearance4 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridBand1 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1)
        Dim UltraGridColumn1 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Tipo")
        Dim UltraGridColumn2 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Serie")
        Dim UltraGridColumn3 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("documento")
        Dim UltraGridColumn4 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("importe")
        Dim Appearance19 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn5 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("importe_ori")
        Dim UltraGridColumn6 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("comentario")
        Dim UltraGridColumn7 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("tc")
        Dim UltraGridColumn8 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("cuenta")
        Dim UltraGridColumn9 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("cod_TD")
        Dim UltraGridColumn10 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("fecha_TD")
        Dim Appearance6 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance7 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance8 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance9 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance10 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance16 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance17 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance14 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance20 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance25 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance3 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance81 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance23 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance22 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance12 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance77 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Me.UltraLabel1 = New Infragistics.Win.Misc.UltraLabel()
        Me.uce_TipoAnexo = New Infragistics.Win.UltraWinEditors.UltraComboEditor()
        Me.ume_Importe_Mov = New Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit()
        Me.uchk_deducir = New Infragistics.Win.UltraWinEditors.UltraCheckEditor()
        Me.UltraLabel12 = New Infragistics.Win.Misc.UltraLabel()
        Me.uce_MedioPago = New Infragistics.Win.UltraWinEditors.UltraComboEditor()
        Me.UltraLabel11 = New Infragistics.Win.Misc.UltraLabel()
        Me.btn_ListoCab = New Infragistics.Win.Misc.UltraButton()
        Me.uce_centrocosto = New Infragistics.Win.UltraWinEditors.UltraComboEditor()
        Me.UltraLabel3 = New Infragistics.Win.Misc.UltraLabel()
        Me.uce_Moneda = New Infragistics.Win.UltraWinEditors.UltraComboEditor()
        Me.UltraLabel5 = New Infragistics.Win.Misc.UltraLabel()
        Me.txt_Glosa = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.UltraLabel4 = New Infragistics.Win.Misc.UltraLabel()
        Me.ume_importe_Ori = New Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit()
        Me.ume_ValorTipoCambio = New Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit()
        Me.UltraLabel8 = New Infragistics.Win.Misc.UltraLabel()
        Me.udte_Voucher = New Infragistics.Win.UltraWinEditors.UltraDateTimeEditor()
        Me.UltraLabel2 = New Infragistics.Win.Misc.UltraLabel()
        Me.uce_Comprobante = New Infragistics.Win.UltraWinEditors.UltraComboEditor()
        Me.txt_NumDoc = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.txt_SerieDoc = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.UltraLabel9 = New Infragistics.Win.Misc.UltraLabel()
        Me.txt_IdAnexo = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.txt_Des_Prove = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.txt_ruc_anexo = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.uce_CuentaBancaria = New Infragistics.Win.UltraWinEditors.UltraComboEditor()
        Me.uce_Banco = New Infragistics.Win.UltraWinEditors.UltraComboEditor()
        Me.uce_Concepto = New Infragistics.Win.UltraWinEditors.UltraComboEditor()
        Me.UltraLabel7 = New Infragistics.Win.Misc.UltraLabel()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.Tool_Grabar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButton2 = New System.Windows.Forms.ToolStripButton()
        Me.uds_Detalle = New Infragistics.Win.UltraWinDataSource.UltraDataSource(Me.components)
        Me.ug_detalle = New Infragistics.Win.UltraWinGrid.UltraGrid()
        Me.txt_total_soles = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.txt_total_dolares = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.UltraLabel6 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraLabel10 = New Infragistics.Win.Misc.UltraLabel()
        Me.ugb_detalle = New Infragistics.Win.Misc.UltraGroupBox()
        Me.ubtn_add_auxi = New Infragistics.Win.Misc.UltraButton()
        Me.txt_correlativo = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.UltraLabel13 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraLabel14 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraGroupBox1 = New Infragistics.Win.Misc.UltraGroupBox()
        Me.UltraLabel15 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraLabel16 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraGroupBox2 = New Infragistics.Win.Misc.UltraGroupBox()
        Me.UltraLabel17 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraTextEditor1 = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        CType(Me.uce_TipoAnexo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.uce_MedioPago, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.uce_centrocosto, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.uce_Moneda, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_Glosa, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.udte_Voucher, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.uce_Comprobante, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_NumDoc, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_SerieDoc, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_IdAnexo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_Des_Prove, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_ruc_anexo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.uce_CuentaBancaria, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.uce_Banco, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.uce_Concepto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip1.SuspendLayout()
        CType(Me.uds_Detalle, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ug_detalle, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_total_soles, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_total_dolares, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ugb_detalle, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ugb_detalle.SuspendLayout()
        CType(Me.txt_correlativo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UltraGroupBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraGroupBox1.SuspendLayout()
        CType(Me.UltraGroupBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraGroupBox2.SuspendLayout()
        CType(Me.UltraTextEditor1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'UltraLabel1
        '
        Appearance15.BackColor = System.Drawing.Color.Transparent
        Appearance15.ForeColor = System.Drawing.Color.Navy
        Appearance15.TextHAlignAsString = "Center"
        Me.UltraLabel1.Appearance = Appearance15
        Me.UltraLabel1.Location = New System.Drawing.Point(105, 44)
        Me.UltraLabel1.Name = "UltraLabel1"
        Me.UltraLabel1.Size = New System.Drawing.Size(278, 17)
        Me.UltraLabel1.TabIndex = 3
        Me.UltraLabel1.Text = "Concepto"
        '
        'uce_TipoAnexo
        '
        Me.uce_TipoAnexo.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.uce_TipoAnexo.Location = New System.Drawing.Point(17, 49)
        Me.uce_TipoAnexo.Name = "uce_TipoAnexo"
        Me.uce_TipoAnexo.Size = New System.Drawing.Size(132, 21)
        Me.uce_TipoAnexo.TabIndex = 0
        '
        'ume_Importe_Mov
        '
        Appearance44.TextHAlignAsString = "Right"
        Me.ume_Importe_Mov.Appearance = Appearance44
        Me.ume_Importe_Mov.EditAs = Infragistics.Win.UltraWinMaskedEdit.EditAsType.UseSpecifiedMask
        Me.ume_Importe_Mov.InputMask = "{double:9.2}"
        Me.ume_Importe_Mov.Location = New System.Drawing.Point(474, 266)
        Me.ume_Importe_Mov.Name = "ume_Importe_Mov"
        Me.ume_Importe_Mov.Size = New System.Drawing.Size(89, 20)
        Me.ume_Importe_Mov.TabIndex = 140
        '
        'uchk_deducir
        '
        Me.uchk_deducir.BackColor = System.Drawing.Color.Transparent
        Me.uchk_deducir.BackColorInternal = System.Drawing.Color.Transparent
        Me.uchk_deducir.Location = New System.Drawing.Point(184, 326)
        Me.uchk_deducir.Name = "uchk_deducir"
        Me.uchk_deducir.Size = New System.Drawing.Size(68, 20)
        Me.uchk_deducir.TabIndex = 139
        Me.uchk_deducir.Text = "Deducir"
        '
        'UltraLabel12
        '
        Appearance26.BackColor = System.Drawing.Color.Transparent
        Appearance26.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel12.Appearance = Appearance26
        Me.UltraLabel12.AutoSize = True
        Me.UltraLabel12.Location = New System.Drawing.Point(59, 41)
        Me.UltraLabel12.Name = "UltraLabel12"
        Me.UltraLabel12.Size = New System.Drawing.Size(79, 14)
        Me.UltraLabel12.TabIndex = 138
        Me.UltraLabel12.Text = "Medio de pago"
        '
        'uce_MedioPago
        '
        Me.uce_MedioPago.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Suggest
        Me.uce_MedioPago.DropDownListWidth = 400
        Me.uce_MedioPago.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.uce_MedioPago.Location = New System.Drawing.Point(17, 61)
        Me.uce_MedioPago.Name = "uce_MedioPago"
        Me.uce_MedioPago.Size = New System.Drawing.Size(182, 21)
        Me.uce_MedioPago.TabIndex = 13
        '
        'UltraLabel11
        '
        Appearance2.BackColor = System.Drawing.Color.Transparent
        Appearance2.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel11.Appearance = Appearance2
        Me.UltraLabel11.AutoSize = True
        Me.UltraLabel11.Location = New System.Drawing.Point(425, 247)
        Me.UltraLabel11.Name = "UltraLabel11"
        Me.UltraLabel11.Size = New System.Drawing.Size(68, 14)
        Me.UltraLabel11.TabIndex = 135
        Me.UltraLabel11.Text = "Total Egreso"
        '
        'btn_ListoCab
        '
        Appearance94.ImageHAlign = Infragistics.Win.HAlign.Center
        Appearance94.ImageVAlign = Infragistics.Win.VAlign.Middle
        Me.btn_ListoCab.Appearance = Appearance94
        Me.btn_ListoCab.ButtonStyle = Infragistics.Win.UIElementButtonStyle.Office2007RibbonButton
        Me.btn_ListoCab.Location = New System.Drawing.Point(265, 313)
        Me.btn_ListoCab.Name = "btn_ListoCab"
        Me.btn_ListoCab.Size = New System.Drawing.Size(52, 34)
        Me.btn_ListoCab.TabIndex = 15
        '
        'uce_centrocosto
        '
        Me.uce_centrocosto.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Suggest
        Me.uce_centrocosto.DropDownListWidth = 200
        Me.uce_centrocosto.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.uce_centrocosto.Location = New System.Drawing.Point(24, 326)
        Me.uce_centrocosto.Name = "uce_centrocosto"
        Me.uce_centrocosto.Size = New System.Drawing.Size(154, 21)
        Me.uce_centrocosto.TabIndex = 9
        '
        'UltraLabel3
        '
        Appearance98.BackColor = System.Drawing.Color.Transparent
        Appearance98.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel3.Appearance = Appearance98
        Me.UltraLabel3.AutoSize = True
        Me.UltraLabel3.Location = New System.Drawing.Point(77, 306)
        Me.UltraLabel3.Name = "UltraLabel3"
        Me.UltraLabel3.Size = New System.Drawing.Size(45, 14)
        Me.UltraLabel3.TabIndex = 135
        Me.UltraLabel3.Text = "C/Costo"
        '
        'uce_Moneda
        '
        Me.uce_Moneda.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Suggest
        Me.uce_Moneda.DropDownListWidth = 200
        Me.uce_Moneda.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.uce_Moneda.Location = New System.Drawing.Point(242, 267)
        Me.uce_Moneda.Name = "uce_Moneda"
        Me.uce_Moneda.Size = New System.Drawing.Size(96, 21)
        Me.uce_Moneda.TabIndex = 8
        '
        'UltraLabel5
        '
        Appearance13.BackColor = System.Drawing.Color.Transparent
        Appearance13.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel5.Appearance = Appearance13
        Me.UltraLabel5.AutoSize = True
        Me.UltraLabel5.Location = New System.Drawing.Point(261, 247)
        Me.UltraLabel5.Name = "UltraLabel5"
        Me.UltraLabel5.Size = New System.Drawing.Size(45, 14)
        Me.UltraLabel5.TabIndex = 135
        Me.UltraLabel5.Text = "Moneda"
        '
        'txt_Glosa
        '
        Me.txt_Glosa.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_Glosa.Location = New System.Drawing.Point(574, 266)
        Me.txt_Glosa.Name = "txt_Glosa"
        Me.txt_Glosa.Size = New System.Drawing.Size(428, 21)
        Me.txt_Glosa.TabIndex = 14
        '
        'UltraLabel4
        '
        Appearance1.BackColor = System.Drawing.Color.Transparent
        Appearance1.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel4.Appearance = Appearance1
        Me.UltraLabel4.AutoSize = True
        Me.UltraLabel4.Location = New System.Drawing.Point(706, 247)
        Me.UltraLabel4.Name = "UltraLabel4"
        Me.UltraLabel4.Size = New System.Drawing.Size(96, 14)
        Me.UltraLabel4.TabIndex = 132
        Me.UltraLabel4.Text = "Breve Descripcion"
        '
        'ume_importe_Ori
        '
        Appearance21.TextHAlignAsString = "Right"
        Me.ume_importe_Ori.Appearance = Appearance21
        Me.ume_importe_Ori.EditAs = Infragistics.Win.UltraWinMaskedEdit.EditAsType.UseSpecifiedMask
        Me.ume_importe_Ori.InputMask = "{double:9.2}"
        Me.ume_importe_Ori.Location = New System.Drawing.Point(379, 266)
        Me.ume_importe_Ori.Name = "ume_importe_Ori"
        Me.ume_importe_Ori.Size = New System.Drawing.Size(89, 20)
        Me.ume_importe_Ori.TabIndex = 11
        '
        'ume_ValorTipoCambio
        '
        Appearance11.TextHAlignAsString = "Right"
        Me.ume_ValorTipoCambio.Appearance = Appearance11
        Me.ume_ValorTipoCambio.EditAs = Infragistics.Win.UltraWinMaskedEdit.EditAsType.UseSpecifiedMask
        Me.ume_ValorTipoCambio.InputMask = "{double:1.3}"
        Me.ume_ValorTipoCambio.Location = New System.Drawing.Point(132, 267)
        Me.ume_ValorTipoCambio.Name = "ume_ValorTipoCambio"
        Me.ume_ValorTipoCambio.Size = New System.Drawing.Size(89, 20)
        Me.ume_ValorTipoCambio.TabIndex = 11
        '
        'UltraLabel8
        '
        Appearance5.BackColor = System.Drawing.Color.Transparent
        Appearance5.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel8.Appearance = Appearance5
        Me.UltraLabel8.AutoSize = True
        Me.UltraLabel8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.UltraLabel8.Location = New System.Drawing.Point(142, 247)
        Me.UltraLabel8.Name = "UltraLabel8"
        Me.UltraLabel8.Size = New System.Drawing.Size(68, 14)
        Me.UltraLabel8.TabIndex = 130
        Me.UltraLabel8.Text = "Tipo Cambio"
        '
        'udte_Voucher
        '
        Me.udte_Voucher.Location = New System.Drawing.Point(23, 267)
        Me.udte_Voucher.Name = "udte_Voucher"
        Me.udte_Voucher.Size = New System.Drawing.Size(89, 21)
        Me.udte_Voucher.TabIndex = 10
        '
        'UltraLabel2
        '
        Appearance56.BackColor = System.Drawing.Color.Transparent
        Appearance56.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel2.Appearance = Appearance56
        Me.UltraLabel2.AutoSize = True
        Me.UltraLabel2.Location = New System.Drawing.Point(32, 247)
        Me.UltraLabel2.Name = "UltraLabel2"
        Me.UltraLabel2.Size = New System.Drawing.Size(71, 14)
        Me.UltraLabel2.TabIndex = 127
        Me.UltraLabel2.Text = "Fec. Voucher"
        '
        'uce_Comprobante
        '
        Me.uce_Comprobante.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Suggest
        Me.uce_Comprobante.DropDownListWidth = 200
        Me.uce_Comprobante.Location = New System.Drawing.Point(17, 100)
        Me.uce_Comprobante.Name = "uce_Comprobante"
        Me.uce_Comprobante.Size = New System.Drawing.Size(156, 21)
        Me.uce_Comprobante.TabIndex = 5
        '
        'txt_NumDoc
        '
        Me.txt_NumDoc.Location = New System.Drawing.Point(237, 100)
        Me.txt_NumDoc.Name = "txt_NumDoc"
        Me.txt_NumDoc.Size = New System.Drawing.Size(102, 21)
        Me.txt_NumDoc.TabIndex = 7
        '
        'txt_SerieDoc
        '
        Appearance18.TextHAlignAsString = "Left"
        Me.txt_SerieDoc.Appearance = Appearance18
        Me.txt_SerieDoc.Location = New System.Drawing.Point(179, 100)
        Me.txt_SerieDoc.Name = "txt_SerieDoc"
        Me.txt_SerieDoc.Size = New System.Drawing.Size(53, 21)
        Me.txt_SerieDoc.TabIndex = 6
        '
        'UltraLabel9
        '
        Appearance24.BackColor = System.Drawing.Color.Transparent
        Appearance24.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel9.Appearance = Appearance24
        Me.UltraLabel9.AutoSize = True
        Me.UltraLabel9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.UltraLabel9.Location = New System.Drawing.Point(45, 80)
        Me.UltraLabel9.Name = "UltraLabel9"
        Me.UltraLabel9.Size = New System.Drawing.Size(98, 14)
        Me.UltraLabel9.TabIndex = 126
        Me.UltraLabel9.Text = "Tipo Comprobante"
        '
        'txt_IdAnexo
        '
        Me.txt_IdAnexo.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txt_IdAnexo.Location = New System.Drawing.Point(345, 100)
        Me.txt_IdAnexo.Name = "txt_IdAnexo"
        Me.txt_IdAnexo.ReadOnly = True
        Me.txt_IdAnexo.Size = New System.Drawing.Size(57, 21)
        Me.txt_IdAnexo.TabIndex = 17
        '
        'txt_Des_Prove
        '
        Me.txt_Des_Prove.Location = New System.Drawing.Point(251, 49)
        Me.txt_Des_Prove.Name = "txt_Des_Prove"
        Me.txt_Des_Prove.ReadOnly = True
        Me.txt_Des_Prove.Size = New System.Drawing.Size(330, 21)
        Me.txt_Des_Prove.TabIndex = 16
        '
        'txt_ruc_anexo
        '
        Appearance111.ImageHAlign = Infragistics.Win.HAlign.Center
        Appearance111.ImageVAlign = Infragistics.Win.VAlign.Middle
        EditorButton1.Appearance = Appearance111
        EditorButton1.Key = "Ayuda"
        Me.txt_ruc_anexo.ButtonsRight.Add(EditorButton1)
        Me.txt_ruc_anexo.Location = New System.Drawing.Point(151, 49)
        Me.txt_ruc_anexo.Name = "txt_ruc_anexo"
        Me.txt_ruc_anexo.Size = New System.Drawing.Size(100, 21)
        Me.txt_ruc_anexo.TabIndex = 1
        Me.txt_ruc_anexo.Text = "10436190455"
        '
        'uce_CuentaBancaria
        '
        Me.uce_CuentaBancaria.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.uce_CuentaBancaria.Location = New System.Drawing.Point(579, 64)
        Me.uce_CuentaBancaria.Name = "uce_CuentaBancaria"
        Me.uce_CuentaBancaria.Size = New System.Drawing.Size(423, 21)
        Me.uce_CuentaBancaria.TabIndex = 3
        '
        'uce_Banco
        '
        Me.uce_Banco.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.uce_Banco.Location = New System.Drawing.Point(400, 64)
        Me.uce_Banco.Name = "uce_Banco"
        Me.uce_Banco.Size = New System.Drawing.Size(173, 21)
        Me.uce_Banco.TabIndex = 2
        '
        'uce_Concepto
        '
        Me.uce_Concepto.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.uce_Concepto.Location = New System.Drawing.Point(105, 66)
        Me.uce_Concepto.Name = "uce_Concepto"
        Me.uce_Concepto.Size = New System.Drawing.Size(278, 21)
        Me.uce_Concepto.TabIndex = 4
        '
        'UltraLabel7
        '
        Appearance90.BackColor = System.Drawing.Color.Transparent
        Appearance90.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel7.Appearance = Appearance90
        Me.UltraLabel7.AutoSize = True
        Me.UltraLabel7.Location = New System.Drawing.Point(445, 44)
        Me.UltraLabel7.Name = "UltraLabel7"
        Me.UltraLabel7.Size = New System.Drawing.Size(36, 14)
        Me.UltraLabel7.TabIndex = 3
        Me.UltraLabel7.Text = "Banco"
        '
        'ToolStrip1
        '
        Me.ToolStrip1.BackColor = System.Drawing.Color.Gainsboro
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton1, Me.ToolStripSeparator2, Me.Tool_Grabar, Me.ToolStripSeparator1, Me.ToolStripButton2})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(1019, 25)
        Me.ToolStrip1.TabIndex = 5
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.Image = Global.Contabilidad.My.Resources.Resources._16__File_new_2_
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(62, 22)
        Me.ToolStripButton1.Text = "Nuevo"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'Tool_Grabar
        '
        Me.Tool_Grabar.Image = Global.Contabilidad.My.Resources.Resources._003
        Me.Tool_Grabar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Tool_Grabar.Name = "Tool_Grabar"
        Me.Tool_Grabar.Size = New System.Drawing.Size(62, 22)
        Me.Tool_Grabar.Text = "Grabar"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripButton2
        '
        Me.ToolStripButton2.Image = Global.Contabilidad.My.Resources.Resources._28
        Me.ToolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton2.Name = "ToolStripButton2"
        Me.ToolStripButton2.Size = New System.Drawing.Size(49, 22)
        Me.ToolStripButton2.Text = "Salir"
        '
        'uds_Detalle
        '
        UltraDataColumn7.DataType = GetType(Double)
        UltraDataColumn10.DataType = GetType(Date)
        Me.uds_Detalle.Band.Columns.AddRange(New Object() {UltraDataColumn1, UltraDataColumn2, UltraDataColumn3, UltraDataColumn4, UltraDataColumn5, UltraDataColumn6, UltraDataColumn7, UltraDataColumn8, UltraDataColumn9, UltraDataColumn10})
        '
        'ug_detalle
        '
        Me.ug_detalle.DataSource = Me.uds_Detalle
        Appearance4.BackColor = System.Drawing.Color.White
        Me.ug_detalle.DisplayLayout.Appearance = Appearance4
        Me.ug_detalle.DisplayLayout.AutoFitStyle = Infragistics.Win.UltraWinGrid.AutoFitStyle.ExtendLastColumn
        UltraGridColumn1.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn1.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn1.Header.VisiblePosition = 0
        UltraGridColumn2.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn2.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn2.Header.VisiblePosition = 1
        UltraGridColumn2.Width = 61
        UltraGridColumn3.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn3.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn3.Header.VisiblePosition = 2
        UltraGridColumn4.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn4.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        Appearance19.TextHAlignAsString = "Right"
        UltraGridColumn4.CellAppearance = Appearance19
        UltraGridColumn4.Header.VisiblePosition = 3
        UltraGridColumn4.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Double]
        UltraGridColumn5.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn5.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn5.Header.VisiblePosition = 4
        UltraGridColumn5.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Double]
        UltraGridColumn6.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn6.Header.VisiblePosition = 6
        UltraGridColumn6.Width = 125
        UltraGridColumn7.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn7.Header.VisiblePosition = 5
        UltraGridColumn7.Width = 45
        UltraGridColumn8.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn8.Header.VisiblePosition = 7
        UltraGridColumn8.Width = 76
        UltraGridColumn9.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn9.Header.VisiblePosition = 8
        UltraGridColumn10.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn10.Header.VisiblePosition = 9
        UltraGridBand1.Columns.AddRange(New Object() {UltraGridColumn1, UltraGridColumn2, UltraGridColumn3, UltraGridColumn4, UltraGridColumn5, UltraGridColumn6, UltraGridColumn7, UltraGridColumn8, UltraGridColumn9, UltraGridColumn10})
        Me.ug_detalle.DisplayLayout.BandsSerializer.Add(UltraGridBand1)
        Appearance6.BackColor = System.Drawing.Color.Transparent
        Me.ug_detalle.DisplayLayout.Override.CardAreaAppearance = Appearance6
        Appearance7.BackColor = System.Drawing.Color.FromArgb(CType(CType(168, Byte), Integer), CType(CType(167, Byte), Integer), CType(CType(191, Byte), Integer))
        Appearance7.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(112, Byte), Integer), CType(CType(111, Byte), Integer), CType(CType(145, Byte), Integer))
        Appearance7.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance7.FontData.BoldAsString = "True"
        Appearance7.FontData.Name = "Arial"
        Appearance7.FontData.SizeInPoints = 10.0!
        Appearance7.ForeColor = System.Drawing.Color.White
        Appearance7.ThemedElementAlpha = Infragistics.Win.Alpha.Transparent
        Me.ug_detalle.DisplayLayout.Override.HeaderAppearance = Appearance7
        Appearance8.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ug_detalle.DisplayLayout.Override.RowAlternateAppearance = Appearance8
        Appearance9.BackColor = System.Drawing.Color.FromArgb(CType(CType(168, Byte), Integer), CType(CType(167, Byte), Integer), CType(CType(191, Byte), Integer))
        Appearance9.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(112, Byte), Integer), CType(CType(111, Byte), Integer), CType(CType(145, Byte), Integer))
        Appearance9.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Me.ug_detalle.DisplayLayout.Override.RowSelectorAppearance = Appearance9
        Appearance10.BackColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(148, Byte), Integer))
        Appearance10.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(149, Byte), Integer), CType(CType(21, Byte), Integer))
        Appearance10.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Me.ug_detalle.DisplayLayout.Override.SelectedRowAppearance = Appearance10
        Me.ug_detalle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ug_detalle.Location = New System.Drawing.Point(16, 46)
        Me.ug_detalle.Name = "ug_detalle"
        Me.ug_detalle.Size = New System.Drawing.Size(734, 133)
        Me.ug_detalle.TabIndex = 6
        '
        'txt_total_soles
        '
        Appearance16.TextHAlignAsString = "Right"
        Me.txt_total_soles.Appearance = Appearance16
        Me.txt_total_soles.Location = New System.Drawing.Point(73, 15)
        Me.txt_total_soles.Name = "txt_total_soles"
        Me.txt_total_soles.ReadOnly = True
        Me.txt_total_soles.Size = New System.Drawing.Size(104, 21)
        Me.txt_total_soles.TabIndex = 8
        '
        'txt_total_dolares
        '
        Appearance17.TextHAlignAsString = "Right"
        Me.txt_total_dolares.Appearance = Appearance17
        Me.txt_total_dolares.Location = New System.Drawing.Point(258, 15)
        Me.txt_total_dolares.Name = "txt_total_dolares"
        Me.txt_total_dolares.ReadOnly = True
        Me.txt_total_dolares.Size = New System.Drawing.Size(106, 21)
        Me.txt_total_dolares.TabIndex = 8
        '
        'UltraLabel6
        '
        Appearance14.BackColor = System.Drawing.Color.Transparent
        Appearance14.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel6.Appearance = Appearance14
        Me.UltraLabel6.AutoSize = True
        Me.UltraLabel6.Location = New System.Drawing.Point(18, 19)
        Me.UltraLabel6.Name = "UltraLabel6"
        Me.UltraLabel6.Size = New System.Drawing.Size(49, 14)
        Me.UltraLabel6.TabIndex = 135
        Me.UltraLabel6.Text = "Total Sol"
        '
        'UltraLabel10
        '
        Appearance20.BackColor = System.Drawing.Color.Transparent
        Appearance20.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel10.Appearance = Appearance20
        Me.UltraLabel10.AutoSize = True
        Me.UltraLabel10.Location = New System.Drawing.Point(203, 19)
        Me.UltraLabel10.Name = "UltraLabel10"
        Me.UltraLabel10.Size = New System.Drawing.Size(49, 14)
        Me.UltraLabel10.TabIndex = 135
        Me.UltraLabel10.Text = "Total Dol"
        '
        'ugb_detalle
        '
        Me.ugb_detalle.Controls.Add(Me.ubtn_add_auxi)
        Me.ugb_detalle.Controls.Add(Me.txt_total_dolares)
        Me.ugb_detalle.Controls.Add(Me.ug_detalle)
        Me.ugb_detalle.Controls.Add(Me.txt_total_soles)
        Me.ugb_detalle.Controls.Add(Me.UltraLabel10)
        Me.ugb_detalle.Controls.Add(Me.UltraLabel6)
        Me.ugb_detalle.Location = New System.Drawing.Point(24, 365)
        Me.ugb_detalle.Name = "ugb_detalle"
        Me.ugb_detalle.Size = New System.Drawing.Size(776, 189)
        Me.ugb_detalle.TabIndex = 136
        '
        'ubtn_add_auxi
        '
        Me.ubtn_add_auxi.Location = New System.Drawing.Point(619, 14)
        Me.ubtn_add_auxi.Name = "ubtn_add_auxi"
        Me.ubtn_add_auxi.Size = New System.Drawing.Size(129, 25)
        Me.ubtn_add_auxi.TabIndex = 7
        Me.ubtn_add_auxi.Text = "Docs."
        '
        'txt_correlativo
        '
        Appearance25.TextHAlignAsString = "Left"
        Me.txt_correlativo.Appearance = Appearance25
        Me.txt_correlativo.Location = New System.Drawing.Point(24, 66)
        Me.txt_correlativo.Name = "txt_correlativo"
        Me.txt_correlativo.Size = New System.Drawing.Size(75, 21)
        Me.txt_correlativo.TabIndex = 137
        '
        'UltraLabel13
        '
        Appearance3.BackColor = System.Drawing.Color.Transparent
        Appearance3.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel13.Appearance = Appearance3
        Me.UltraLabel13.AutoSize = True
        Me.UltraLabel13.Location = New System.Drawing.Point(32, 46)
        Me.UltraLabel13.Name = "UltraLabel13"
        Me.UltraLabel13.Size = New System.Drawing.Size(59, 14)
        Me.UltraLabel13.TabIndex = 138
        Me.UltraLabel13.Text = "Correlativo"
        '
        'UltraLabel14
        '
        Appearance81.BackColor = System.Drawing.Color.Transparent
        Appearance81.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel14.Appearance = Appearance81
        Me.UltraLabel14.AutoSize = True
        Me.UltraLabel14.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.UltraLabel14.Location = New System.Drawing.Point(135, 25)
        Me.UltraLabel14.Name = "UltraLabel14"
        Me.UltraLabel14.Size = New System.Drawing.Size(311, 14)
        Me.UltraLabel14.TabIndex = 139
        Me.UltraLabel14.Text = "______________________Entidad_____________________"
        '
        'UltraGroupBox1
        '
        Me.UltraGroupBox1.Controls.Add(Me.UltraLabel16)
        Me.UltraGroupBox1.Controls.Add(Me.UltraLabel15)
        Me.UltraGroupBox1.Controls.Add(Me.UltraLabel14)
        Me.UltraGroupBox1.Controls.Add(Me.txt_SerieDoc)
        Me.UltraGroupBox1.Controls.Add(Me.UltraLabel9)
        Me.UltraGroupBox1.Controls.Add(Me.uce_Comprobante)
        Me.UltraGroupBox1.Controls.Add(Me.txt_NumDoc)
        Me.UltraGroupBox1.Controls.Add(Me.txt_ruc_anexo)
        Me.UltraGroupBox1.Controls.Add(Me.uce_TipoAnexo)
        Me.UltraGroupBox1.Controls.Add(Me.txt_Des_Prove)
        Me.UltraGroupBox1.Controls.Add(Me.txt_IdAnexo)
        Me.UltraGroupBox1.Location = New System.Drawing.Point(400, 98)
        Me.UltraGroupBox1.Name = "UltraGroupBox1"
        Me.UltraGroupBox1.Size = New System.Drawing.Size(602, 132)
        Me.UltraGroupBox1.TabIndex = 140
        Me.UltraGroupBox1.Text = "Documento de Sustento"
        '
        'UltraLabel15
        '
        Appearance23.BackColor = System.Drawing.Color.Transparent
        Appearance23.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel15.Appearance = Appearance23
        Me.UltraLabel15.AutoSize = True
        Me.UltraLabel15.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.UltraLabel15.Location = New System.Drawing.Point(190, 80)
        Me.UltraLabel15.Name = "UltraLabel15"
        Me.UltraLabel15.Size = New System.Drawing.Size(31, 14)
        Me.UltraLabel15.TabIndex = 140
        Me.UltraLabel15.Text = "Serie"
        '
        'UltraLabel16
        '
        Appearance22.BackColor = System.Drawing.Color.Transparent
        Appearance22.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel16.Appearance = Appearance22
        Me.UltraLabel16.AutoSize = True
        Me.UltraLabel16.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.UltraLabel16.Location = New System.Drawing.Point(263, 80)
        Me.UltraLabel16.Name = "UltraLabel16"
        Me.UltraLabel16.Size = New System.Drawing.Size(44, 14)
        Me.UltraLabel16.TabIndex = 141
        Me.UltraLabel16.Text = "Numero"
        '
        'UltraGroupBox2
        '
        Me.UltraGroupBox2.Controls.Add(Me.UltraTextEditor1)
        Me.UltraGroupBox2.Controls.Add(Me.UltraLabel17)
        Me.UltraGroupBox2.Controls.Add(Me.UltraLabel12)
        Me.UltraGroupBox2.Controls.Add(Me.uce_MedioPago)
        Me.UltraGroupBox2.Location = New System.Drawing.Point(19, 97)
        Me.UltraGroupBox2.Name = "UltraGroupBox2"
        Me.UltraGroupBox2.Size = New System.Drawing.Size(364, 133)
        Me.UltraGroupBox2.TabIndex = 141
        Me.UltraGroupBox2.Text = "Documento de Medio de Pago"
        '
        'UltraLabel17
        '
        Appearance12.BackColor = System.Drawing.Color.Transparent
        Appearance12.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel17.Appearance = Appearance12
        Me.UltraLabel17.AutoSize = True
        Me.UltraLabel17.Location = New System.Drawing.Point(246, 41)
        Me.UltraLabel17.Name = "UltraLabel17"
        Me.UltraLabel17.Size = New System.Drawing.Size(44, 14)
        Me.UltraLabel17.TabIndex = 139
        Me.UltraLabel17.Text = "Numero"
        '
        'UltraTextEditor1
        '
        Appearance77.TextHAlignAsString = "Left"
        Me.UltraTextEditor1.Appearance = Appearance77
        Me.UltraTextEditor1.Location = New System.Drawing.Point(205, 61)
        Me.UltraTextEditor1.Name = "UltraTextEditor1"
        Me.UltraTextEditor1.Size = New System.Drawing.Size(131, 21)
        Me.UltraTextEditor1.TabIndex = 140
        '
        'TE_PR_Egresos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(1019, 582)
        Me.Controls.Add(Me.uce_CuentaBancaria)
        Me.Controls.Add(Me.uchk_deducir)
        Me.Controls.Add(Me.uce_Banco)
        Me.Controls.Add(Me.UltraLabel7)
        Me.Controls.Add(Me.ume_Importe_Mov)
        Me.Controls.Add(Me.btn_ListoCab)
        Me.Controls.Add(Me.UltraGroupBox2)
        Me.Controls.Add(Me.uce_centrocosto)
        Me.Controls.Add(Me.UltraLabel3)
        Me.Controls.Add(Me.UltraLabel11)
        Me.Controls.Add(Me.UltraGroupBox1)
        Me.Controls.Add(Me.txt_Glosa)
        Me.Controls.Add(Me.UltraLabel4)
        Me.Controls.Add(Me.uce_Moneda)
        Me.Controls.Add(Me.UltraLabel5)
        Me.Controls.Add(Me.UltraLabel13)
        Me.Controls.Add(Me.txt_correlativo)
        Me.Controls.Add(Me.ugb_detalle)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.uce_Concepto)
        Me.Controls.Add(Me.UltraLabel1)
        Me.Controls.Add(Me.ume_importe_Ori)
        Me.Controls.Add(Me.ume_ValorTipoCambio)
        Me.Controls.Add(Me.UltraLabel2)
        Me.Controls.Add(Me.udte_Voucher)
        Me.Controls.Add(Me.UltraLabel8)
        Me.Name = "TE_PR_Egresos"
        Me.Text = "Egresos"
        CType(Me.uce_TipoAnexo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.uce_MedioPago, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.uce_centrocosto, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.uce_Moneda, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_Glosa, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.udte_Voucher, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.uce_Comprobante, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_NumDoc, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_SerieDoc, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_IdAnexo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_Des_Prove, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_ruc_anexo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.uce_CuentaBancaria, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.uce_Banco, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.uce_Concepto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        CType(Me.uds_Detalle, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ug_detalle, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_total_soles, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_total_dolares, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ugb_detalle, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ugb_detalle.ResumeLayout(False)
        Me.ugb_detalle.PerformLayout()
        CType(Me.txt_correlativo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UltraGroupBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraGroupBox1.ResumeLayout(False)
        Me.UltraGroupBox1.PerformLayout()
        CType(Me.UltraGroupBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraGroupBox2.ResumeLayout(False)
        Me.UltraGroupBox2.PerformLayout()
        CType(Me.UltraTextEditor1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents UltraLabel1 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents uce_TipoAnexo As Infragistics.Win.UltraWinEditors.UltraComboEditor
    Friend WithEvents txt_IdAnexo As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents txt_Des_Prove As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents txt_ruc_anexo As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents uce_Concepto As Infragistics.Win.UltraWinEditors.UltraComboEditor
    Friend WithEvents uce_Comprobante As Infragistics.Win.UltraWinEditors.UltraComboEditor
    Friend WithEvents txt_NumDoc As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents txt_SerieDoc As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents UltraLabel9 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents udte_Voucher As Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
    Friend WithEvents UltraLabel2 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents ume_ValorTipoCambio As Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit
    Friend WithEvents txt_Glosa As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents UltraLabel4 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents uce_centrocosto As Infragistics.Win.UltraWinEditors.UltraComboEditor
    Friend WithEvents UltraLabel3 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents uce_Moneda As Infragistics.Win.UltraWinEditors.UltraComboEditor
    Friend WithEvents UltraLabel5 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents btn_ListoCab As Infragistics.Win.Misc.UltraButton
    Friend WithEvents UltraLabel12 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents uce_MedioPago As Infragistics.Win.UltraWinEditors.UltraComboEditor
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripButton1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents Tool_Grabar As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripButton2 As System.Windows.Forms.ToolStripButton
    Friend WithEvents uce_CuentaBancaria As Infragistics.Win.UltraWinEditors.UltraComboEditor
    Friend WithEvents uce_Banco As Infragistics.Win.UltraWinEditors.UltraComboEditor
    Friend WithEvents UltraLabel7 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel8 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents uds_Detalle As Infragistics.Win.UltraWinDataSource.UltraDataSource
    Friend WithEvents ug_detalle As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents txt_total_soles As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents txt_total_dolares As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents UltraLabel6 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel10 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents ugb_detalle As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents UltraLabel11 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents uchk_deducir As Infragistics.Win.UltraWinEditors.UltraCheckEditor
    Friend WithEvents ume_importe_Ori As Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit
    Friend WithEvents ume_Importe_Mov As Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit
    Friend WithEvents ubtn_add_auxi As Infragistics.Win.Misc.UltraButton
    Friend WithEvents txt_correlativo As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents UltraLabel13 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel14 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraGroupBox1 As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents UltraLabel16 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel15 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraGroupBox2 As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents UltraTextEditor1 As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents UltraLabel17 As Infragistics.Win.Misc.UltraLabel
End Class
