<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AD_PR_Atencion
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
        Dim Appearance26 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance41 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance10 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance29 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance19 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridBand1 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1)
        Dim UltraGridColumn1 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Cant")
        Dim UltraGridColumn2 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id_Articulo")
        Dim UltraGridColumn3 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Codigo")
        Dim UltraGridColumn4 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Descripcion")
        Dim UltraGridColumn5 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Costo")
        Dim Appearance11 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn6 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CD_SEG_CUBRE")
        Dim UltraGridColumn7 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CD_DEDUCIBLE")
        Dim Appearance12 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn8 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Descuento")
        Dim Appearance13 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn9 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CD_DSCTO_OTRO")
        Dim Appearance14 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn10 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("SubTotal")
        Dim Appearance21 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn11 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IGV")
        Dim Appearance23 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn12 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Total")
        Dim Appearance33 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn13 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("idConsulta")
        Dim UltraGridColumn14 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CD_IDCOMPROBANTE")
        Dim UltraGridColumn15 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CD_ITEM")
        Dim UltraGridColumn16 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CD_SINPAGO")
        Dim UltraDataColumn1 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Cant")
        Dim UltraDataColumn2 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Id_Articulo")
        Dim UltraDataColumn3 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Codigo")
        Dim UltraDataColumn4 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Descripcion")
        Dim UltraDataColumn5 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Costo")
        Dim UltraDataColumn6 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("CD_SEG_CUBRE")
        Dim UltraDataColumn7 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("CD_DEDUCIBLE")
        Dim UltraDataColumn8 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Descuento")
        Dim UltraDataColumn9 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("CD_DSCTO_OTRO")
        Dim UltraDataColumn10 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("SubTotal")
        Dim UltraDataColumn11 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IGV")
        Dim UltraDataColumn12 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Total")
        Dim UltraDataColumn13 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("idConsulta")
        Dim UltraDataColumn14 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("CD_IDCOMPROBANTE")
        Dim UltraDataColumn15 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("CD_ITEM")
        Dim UltraDataColumn16 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("CD_SINPAGO")
        Dim Appearance30 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance5 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance4 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance35 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance18 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance7 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance24 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance32 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance36 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance9 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance25 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance37 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance6 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance27 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance22 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance38 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance31 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance8 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance20 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim EditorButton1 As Infragistics.Win.UltraWinEditors.EditorButton = New Infragistics.Win.UltraWinEditors.EditorButton("ayuda")
        Dim Appearance2 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance40 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance28 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance42 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance43 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance44 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance45 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance15 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance72 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance1 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance3 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance16 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance17 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Me.ToolS_Mantenimiento = New System.Windows.Forms.ToolStrip()
        Me.Tool_Grabar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.Tool_Salir = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.Tool_ImprimirF = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.Tool_ImprimirA = New System.Windows.Forms.ToolStripButton()
        Me.ugb_Datos = New Infragistics.Win.Misc.UltraGroupBox()
        Me.uck_Anamnesis = New Infragistics.Win.UltraWinEditors.UltraCheckEditor()
        Me.uce_Medico = New Infragistics.Win.UltraWinEditors.UltraComboEditor()
        Me.UltraLabel8 = New Infragistics.Win.Misc.UltraLabel()
        Me.ume_horaIngreso = New Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit()
        Me.ume_HoraLLegada = New Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit()
        Me.uck_HoraLlegada = New Infragistics.Win.UltraWinEditors.UltraCheckEditor()
        Me.UltraLabel21 = New Infragistics.Win.Misc.UltraLabel()
        Me.uck_HoraIngreso = New Infragistics.Win.UltraWinEditors.UltraCheckEditor()
        Me.ug_detalle = New Infragistics.Win.UltraWinGrid.UltraGrid()
        Me.uds_detalle = New Infragistics.Win.UltraWinDataSource.UltraDataSource(Me.components)
        Me.ubt_Quitar = New Infragistics.Win.Misc.UltraButton()
        Me.ucm_Tipo = New Infragistics.Win.UltraWinEditors.UltraComboEditor()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.UltraLabel2 = New Infragistics.Win.Misc.UltraLabel()
        Me.udte_fecha = New Infragistics.Win.UltraWinEditors.UltraDateTimeEditor()
        Me.udte_fechaNac = New Infragistics.Win.UltraWinEditors.UltraDateTimeEditor()
        Me.UltraLabel16 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraLabel15 = New Infragistics.Win.Misc.UltraLabel()
        Me.txt_Edad = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.UltraLabel14 = New Infragistics.Win.Misc.UltraLabel()
        Me.txt_Observacion = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.UltraLabel13 = New Infragistics.Win.Misc.UltraLabel()
        Me.txt_idCita = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.ugb_Cuenta = New Infragistics.Win.Misc.UltraGroupBox()
        Me.UltraLabel20 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraLabel17 = New Infragistics.Win.Misc.UltraLabel()
        Me.txt_FijoC = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.txt_DesCobertura = New Infragistics.Win.UltraWinEditors.UltraComboEditor()
        Me.TXT_TIPOAFILIACION = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.txt_FechaAutoriza = New Infragistics.Win.UltraWinEditors.UltraDateTimeEditor()
        Me.uckIngresoManual = New Infragistics.Win.UltraWinEditors.UltraCheckEditor()
        Me.UltraLabel22 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraLabel18 = New Infragistics.Win.Misc.UltraLabel()
        Me.txt_EPS = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.UltraLabel19 = New Infragistics.Win.Misc.UltraLabel()
        Me.txt_CodAutoriza = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.UltraLabel9 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraLabel10 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraLabel11 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraLabel12 = New Infragistics.Win.Misc.UltraLabel()
        Me.txt_PagoVariable = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.txt_PagoFijo = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.txt_CodAsegurado = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.ubt_Agregar = New Infragistics.Win.Misc.UltraButton()
        Me.ucm_SeguroEps = New Infragistics.Win.UltraWinEditors.UltraComboEditor()
        Me.txt_IdCuenta = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.uchk_SeguroEps = New Infragistics.Win.UltraWinEditors.UltraCheckEditor()
        Me.uchk_GenerarCta = New Infragistics.Win.UltraWinEditors.UltraCheckEditor()
        Me.uce_tip_doc = New Infragistics.Win.UltraWinEditors.UltraComboEditor()
        Me.txt_idprogramacion = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.txt_Des_Cliente = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.txt_ruc_cliente = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.UltraLabel7 = New Infragistics.Win.Misc.UltraLabel()
        Me.txt_Medico = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.UltraLabel6 = New Infragistics.Win.Misc.UltraLabel()
        Me.txt_Servicio = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.UltraLabel5 = New Infragistics.Win.Misc.UltraLabel()
        Me.txt_Orden = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.UltraLabel4 = New Infragistics.Win.Misc.UltraLabel()
        Me.txt_Hora = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.UltraLabel3 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraLabel1 = New Infragistics.Win.Misc.UltraLabel()
        Me.txt_IdCliente = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.txt_idHistoria = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.txt_SubTotal = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.UltraLabel24 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraLabel25 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraLabel32 = New Infragistics.Win.Misc.UltraLabel()
        Me.txt_IGV = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.txt_Total = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.ToolS_Mantenimiento.SuspendLayout()
        CType(Me.ugb_Datos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ugb_Datos.SuspendLayout()
        CType(Me.uce_Medico, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ug_detalle, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.uds_detalle, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ucm_Tipo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.udte_fecha, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.udte_fechaNac, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_Edad, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_Observacion, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_idCita, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ugb_Cuenta, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ugb_Cuenta.SuspendLayout()
        CType(Me.txt_FijoC, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_DesCobertura, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TXT_TIPOAFILIACION, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_FechaAutoriza, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_EPS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_CodAutoriza, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_PagoVariable, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_PagoFijo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_CodAsegurado, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ucm_SeguroEps, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_IdCuenta, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.uce_tip_doc, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_idprogramacion, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_Des_Cliente, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_ruc_cliente, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_Medico, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_Servicio, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_Orden, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_Hora, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_IdCliente, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_idHistoria, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_SubTotal, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_IGV, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_Total, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ToolS_Mantenimiento
        '
        Me.ToolS_Mantenimiento.BackColor = System.Drawing.Color.White
        Me.ToolS_Mantenimiento.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Tool_Grabar, Me.ToolStripSeparator3, Me.Tool_Salir, Me.ToolStripSeparator1, Me.Tool_ImprimirF, Me.ToolStripSeparator2, Me.Tool_ImprimirA})
        Me.ToolS_Mantenimiento.Location = New System.Drawing.Point(0, 0)
        Me.ToolS_Mantenimiento.Name = "ToolS_Mantenimiento"
        Me.ToolS_Mantenimiento.Size = New System.Drawing.Size(792, 25)
        Me.ToolS_Mantenimiento.TabIndex = 32
        Me.ToolS_Mantenimiento.Text = "ToolStrip1"
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
        'Tool_Salir
        '
        Me.Tool_Salir.Image = Global.Contabilidad.My.Resources.Resources._28
        Me.Tool_Salir.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Tool_Salir.Name = "Tool_Salir"
        Me.Tool_Salir.Size = New System.Drawing.Size(49, 22)
        Me.Tool_Salir.Text = "Salir"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'Tool_ImprimirF
        '
        Me.Tool_ImprimirF.Image = Global.Contabilidad.My.Resources.Resources._004
        Me.Tool_ImprimirF.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Tool_ImprimirF.Name = "Tool_ImprimirF"
        Me.Tool_ImprimirF.Size = New System.Drawing.Size(135, 22)
        Me.Tool_ImprimirF.Text = "Imprimir H. Filiacion"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'Tool_ImprimirA
        '
        Me.Tool_ImprimirA.Image = Global.Contabilidad.My.Resources.Resources._004
        Me.Tool_ImprimirA.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Tool_ImprimirA.Name = "Tool_ImprimirA"
        Me.Tool_ImprimirA.Size = New System.Drawing.Size(139, 22)
        Me.Tool_ImprimirA.Text = "Imprimir O. Atención"
        '
        'ugb_Datos
        '
        Me.ugb_Datos.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ugb_Datos.Controls.Add(Me.uck_Anamnesis)
        Me.ugb_Datos.Controls.Add(Me.uce_Medico)
        Me.ugb_Datos.Controls.Add(Me.UltraLabel8)
        Me.ugb_Datos.Controls.Add(Me.ume_horaIngreso)
        Me.ugb_Datos.Controls.Add(Me.ume_HoraLLegada)
        Me.ugb_Datos.Controls.Add(Me.uck_HoraLlegada)
        Me.ugb_Datos.Controls.Add(Me.UltraLabel21)
        Me.ugb_Datos.Controls.Add(Me.uck_HoraIngreso)
        Me.ugb_Datos.Controls.Add(Me.ug_detalle)
        Me.ugb_Datos.Controls.Add(Me.ubt_Quitar)
        Me.ugb_Datos.Controls.Add(Me.ucm_Tipo)
        Me.ugb_Datos.Controls.Add(Me.Panel2)
        Me.ugb_Datos.Controls.Add(Me.Panel1)
        Me.ugb_Datos.Controls.Add(Me.UltraLabel2)
        Me.ugb_Datos.Controls.Add(Me.udte_fecha)
        Me.ugb_Datos.Controls.Add(Me.udte_fechaNac)
        Me.ugb_Datos.Controls.Add(Me.UltraLabel16)
        Me.ugb_Datos.Controls.Add(Me.UltraLabel15)
        Me.ugb_Datos.Controls.Add(Me.txt_Edad)
        Me.ugb_Datos.Controls.Add(Me.UltraLabel14)
        Me.ugb_Datos.Controls.Add(Me.txt_Observacion)
        Me.ugb_Datos.Controls.Add(Me.UltraLabel13)
        Me.ugb_Datos.Controls.Add(Me.txt_idCita)
        Me.ugb_Datos.Controls.Add(Me.ugb_Cuenta)
        Me.ugb_Datos.Controls.Add(Me.ubt_Agregar)
        Me.ugb_Datos.Controls.Add(Me.ucm_SeguroEps)
        Me.ugb_Datos.Controls.Add(Me.txt_IdCuenta)
        Me.ugb_Datos.Controls.Add(Me.uchk_SeguroEps)
        Me.ugb_Datos.Controls.Add(Me.uchk_GenerarCta)
        Me.ugb_Datos.Controls.Add(Me.uce_tip_doc)
        Me.ugb_Datos.Controls.Add(Me.txt_idprogramacion)
        Me.ugb_Datos.Controls.Add(Me.txt_Des_Cliente)
        Me.ugb_Datos.Controls.Add(Me.txt_ruc_cliente)
        Me.ugb_Datos.Controls.Add(Me.UltraLabel7)
        Me.ugb_Datos.Controls.Add(Me.txt_Medico)
        Me.ugb_Datos.Controls.Add(Me.UltraLabel6)
        Me.ugb_Datos.Controls.Add(Me.txt_Servicio)
        Me.ugb_Datos.Controls.Add(Me.UltraLabel5)
        Me.ugb_Datos.Controls.Add(Me.txt_Orden)
        Me.ugb_Datos.Controls.Add(Me.UltraLabel4)
        Me.ugb_Datos.Controls.Add(Me.txt_Hora)
        Me.ugb_Datos.Controls.Add(Me.UltraLabel3)
        Me.ugb_Datos.Controls.Add(Me.UltraLabel1)
        Me.ugb_Datos.Controls.Add(Me.txt_IdCliente)
        Me.ugb_Datos.Controls.Add(Me.txt_idHistoria)
        Me.ugb_Datos.Location = New System.Drawing.Point(2, 27)
        Me.ugb_Datos.Name = "ugb_Datos"
        Me.ugb_Datos.Size = New System.Drawing.Size(789, 490)
        Me.ugb_Datos.TabIndex = 33
        '
        'uck_Anamnesis
        '
        Appearance26.ForeColor = System.Drawing.Color.Navy
        Me.uck_Anamnesis.Appearance = Appearance26
        Me.uck_Anamnesis.BackColor = System.Drawing.Color.Transparent
        Me.uck_Anamnesis.BackColorInternal = System.Drawing.Color.Transparent
        Me.uck_Anamnesis.Location = New System.Drawing.Point(274, 67)
        Me.uck_Anamnesis.Name = "uck_Anamnesis"
        Me.uck_Anamnesis.Size = New System.Drawing.Size(85, 17)
        Me.uck_Anamnesis.TabIndex = 165
        Me.uck_Anamnesis.Text = "Anamnesis"
        '
        'uce_Medico
        '
        Me.uce_Medico.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.uce_Medico.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.uce_Medico.Location = New System.Drawing.Point(435, 126)
        Me.uce_Medico.Name = "uce_Medico"
        Me.uce_Medico.Size = New System.Drawing.Size(318, 21)
        Me.uce_Medico.TabIndex = 4
        '
        'UltraLabel8
        '
        Appearance41.BackColor = System.Drawing.Color.Transparent
        Appearance41.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel8.Appearance = Appearance41
        Me.UltraLabel8.AutoSize = True
        Me.UltraLabel8.Location = New System.Drawing.Point(341, 130)
        Me.UltraLabel8.Name = "UltraLabel8"
        Me.UltraLabel8.Size = New System.Drawing.Size(92, 14)
        Me.UltraLabel8.TabIndex = 164
        Me.UltraLabel8.Text = "Médico Derivante"
        '
        'ume_horaIngreso
        '
        Me.ume_horaIngreso.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ume_horaIngreso.EditAs = Infragistics.Win.UltraWinMaskedEdit.EditAsType.UseSpecifiedMask
        Me.ume_horaIngreso.InputMask = "{LOC}hh:mm"
        Me.ume_horaIngreso.Location = New System.Drawing.Point(708, 41)
        Me.ume_horaIngreso.Name = "ume_horaIngreso"
        Me.ume_horaIngreso.Size = New System.Drawing.Size(45, 20)
        Me.ume_horaIngreso.TabIndex = 2
        Me.ume_horaIngreso.Text = "UltraMaskedEdit1"
        '
        'ume_HoraLLegada
        '
        Me.ume_HoraLLegada.EditAs = Infragistics.Win.UltraWinMaskedEdit.EditAsType.UseSpecifiedMask
        Me.ume_HoraLLegada.InputMask = "{LOC}hh:mm"
        Me.ume_HoraLLegada.Location = New System.Drawing.Point(572, 41)
        Me.ume_HoraLLegada.Name = "ume_HoraLLegada"
        Me.ume_HoraLLegada.Size = New System.Drawing.Size(45, 20)
        Me.ume_HoraLLegada.TabIndex = 1
        Me.ume_HoraLLegada.Text = "UltraMaskedEdit1"
        '
        'uck_HoraLlegada
        '
        Appearance10.ForeColor = System.Drawing.Color.Navy
        Me.uck_HoraLlegada.Appearance = Appearance10
        Me.uck_HoraLlegada.BackColor = System.Drawing.Color.Transparent
        Me.uck_HoraLlegada.BackColorInternal = System.Drawing.Color.Transparent
        Me.uck_HoraLlegada.Location = New System.Drawing.Point(495, 42)
        Me.uck_HoraLlegada.Name = "uck_HoraLlegada"
        Me.uck_HoraLlegada.Size = New System.Drawing.Size(85, 17)
        Me.uck_HoraLlegada.TabIndex = 0
        Me.uck_HoraLlegada.Text = "H. Llegada"
        '
        'UltraLabel21
        '
        Appearance29.BackColor = System.Drawing.Color.Transparent
        Appearance29.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel21.Appearance = Appearance29
        Me.UltraLabel21.AutoSize = True
        Me.UltraLabel21.Location = New System.Drawing.Point(600, 194)
        Me.UltraLabel21.Name = "UltraLabel21"
        Me.UltraLabel21.Size = New System.Drawing.Size(26, 14)
        Me.UltraLabel21.TabIndex = 154
        Me.UltraLabel21.Text = "Tipo"
        '
        'uck_HoraIngreso
        '
        Appearance19.ForeColor = System.Drawing.Color.Navy
        Me.uck_HoraIngreso.Appearance = Appearance19
        Me.uck_HoraIngreso.BackColor = System.Drawing.Color.Transparent
        Me.uck_HoraIngreso.BackColorInternal = System.Drawing.Color.Transparent
        Me.uck_HoraIngreso.Location = New System.Drawing.Point(634, 42)
        Me.uck_HoraIngreso.Name = "uck_HoraIngreso"
        Me.uck_HoraIngreso.Size = New System.Drawing.Size(75, 17)
        Me.uck_HoraIngreso.TabIndex = 1
        Me.uck_HoraIngreso.Text = "H. Ingreso"
        '
        'ug_detalle
        '
        Me.ug_detalle.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ug_detalle.DataSource = Me.uds_detalle
        Me.ug_detalle.DisplayLayout.AutoFitStyle = Infragistics.Win.UltraWinGrid.AutoFitStyle.ExtendLastColumn
        UltraGridColumn1.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn1.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn1.Header.VisiblePosition = 1
        UltraGridColumn1.Width = 40
        UltraGridColumn2.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn2.Header.VisiblePosition = 0
        UltraGridColumn2.Hidden = True
        UltraGridColumn3.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn3.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn3.Header.VisiblePosition = 2
        UltraGridColumn3.Width = 50
        UltraGridColumn4.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn4.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn4.Header.VisiblePosition = 3
        UltraGridColumn4.Width = 280
        UltraGridColumn5.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        Appearance11.TextHAlignAsString = "Right"
        UltraGridColumn5.CellAppearance = Appearance11
        UltraGridColumn5.Header.VisiblePosition = 4
        UltraGridColumn5.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Double]
        UltraGridColumn5.Width = 60
        UltraGridColumn6.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn6.Header.Caption = "Cubre"
        UltraGridColumn6.Header.VisiblePosition = 5
        UltraGridColumn6.Hidden = True
        UltraGridColumn7.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        Appearance12.TextHAlignAsString = "Right"
        UltraGridColumn7.CellAppearance = Appearance12
        UltraGridColumn7.Header.Caption = "Deducible"
        UltraGridColumn7.Header.VisiblePosition = 6
        UltraGridColumn7.Hidden = True
        UltraGridColumn7.Width = 60
        UltraGridColumn8.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn8.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        Appearance13.TextHAlignAsString = "Right"
        UltraGridColumn8.CellAppearance = Appearance13
        UltraGridColumn8.Header.Caption = "Dscto Seg."
        UltraGridColumn8.Header.VisiblePosition = 7
        UltraGridColumn8.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Double]
        UltraGridColumn8.Width = 65
        UltraGridColumn9.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn9.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        Appearance14.TextHAlignAsString = "Right"
        UltraGridColumn9.CellAppearance = Appearance14
        UltraGridColumn9.Header.Caption = "Dscto Otro"
        UltraGridColumn9.Header.VisiblePosition = 8
        UltraGridColumn9.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Double]
        UltraGridColumn9.Width = 65
        UltraGridColumn10.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn10.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        Appearance21.TextHAlignAsString = "Right"
        UltraGridColumn10.CellAppearance = Appearance21
        UltraGridColumn10.Header.VisiblePosition = 9
        UltraGridColumn10.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Double]
        UltraGridColumn10.Width = 70
        UltraGridColumn11.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn11.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        Appearance23.TextHAlignAsString = "Right"
        UltraGridColumn11.CellAppearance = Appearance23
        UltraGridColumn11.Header.VisiblePosition = 10
        UltraGridColumn11.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Double]
        UltraGridColumn11.Width = 55
        UltraGridColumn12.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn12.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        Appearance33.TextHAlignAsString = "Right"
        UltraGridColumn12.CellAppearance = Appearance33
        UltraGridColumn12.Header.VisiblePosition = 11
        UltraGridColumn12.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Double]
        UltraGridColumn12.Width = 65
        UltraGridColumn13.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn13.Header.VisiblePosition = 12
        UltraGridColumn13.Hidden = True
        UltraGridColumn14.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn14.Header.VisiblePosition = 13
        UltraGridColumn14.Hidden = True
        UltraGridColumn15.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn15.Header.VisiblePosition = 14
        UltraGridColumn15.Hidden = True
        UltraGridColumn16.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn16.Header.VisiblePosition = 15
        UltraGridColumn16.Hidden = True
        UltraGridBand1.Columns.AddRange(New Object() {UltraGridColumn1, UltraGridColumn2, UltraGridColumn3, UltraGridColumn4, UltraGridColumn5, UltraGridColumn6, UltraGridColumn7, UltraGridColumn8, UltraGridColumn9, UltraGridColumn10, UltraGridColumn11, UltraGridColumn12, UltraGridColumn13, UltraGridColumn14, UltraGridColumn15, UltraGridColumn16})
        UltraGridBand1.SummaryFooterCaption = "Totales"
        Me.ug_detalle.DisplayLayout.BandsSerializer.Add(UltraGridBand1)
        Me.ug_detalle.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.[False]
        Me.ug_detalle.DisplayLayout.MaxColScrollRegions = 1
        Me.ug_detalle.DisplayLayout.MaxRowScrollRegions = 1
        Me.ug_detalle.DisplayLayout.Override.AllowDelete = Infragistics.Win.DefaultableBoolean.[True]
        Me.ug_detalle.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.ug_detalle.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.ug_detalle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ug_detalle.Location = New System.Drawing.Point(5, 353)
        Me.ug_detalle.Name = "ug_detalle"
        Me.ug_detalle.Size = New System.Drawing.Size(776, 131)
        Me.ug_detalle.TabIndex = 156
        Me.ug_detalle.Text = "UltraGrid1"
        '
        'uds_detalle
        '
        Me.uds_detalle.Band.AllowAdd = Infragistics.Win.DefaultableBoolean.[True]
        Me.uds_detalle.Band.AllowDelete = Infragistics.Win.DefaultableBoolean.[True]
        UltraDataColumn1.DataType = GetType(Integer)
        UltraDataColumn2.DataType = GetType(Integer)
        UltraDataColumn5.DataType = GetType(Double)
        UltraDataColumn6.DataType = GetType(Boolean)
        UltraDataColumn7.DataType = GetType(Boolean)
        UltraDataColumn8.DataType = GetType(Double)
        UltraDataColumn9.DataType = GetType(Double)
        UltraDataColumn10.DataType = GetType(Double)
        UltraDataColumn11.DataType = GetType(Double)
        UltraDataColumn12.DataType = GetType(Double)
        UltraDataColumn13.DataType = GetType(Integer)
        UltraDataColumn14.DataType = GetType(Integer)
        UltraDataColumn15.DataType = GetType(Integer)
        UltraDataColumn16.DataType = GetType(Integer)
        Me.uds_detalle.Band.Columns.AddRange(New Object() {UltraDataColumn1, UltraDataColumn2, UltraDataColumn3, UltraDataColumn4, UltraDataColumn5, UltraDataColumn6, UltraDataColumn7, UltraDataColumn8, UltraDataColumn9, UltraDataColumn10, UltraDataColumn11, UltraDataColumn12, UltraDataColumn13, UltraDataColumn14, UltraDataColumn15, UltraDataColumn16})
        '
        'ubt_Quitar
        '
        Me.ubt_Quitar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Appearance30.ImageHAlign = Infragistics.Win.HAlign.Center
        Appearance30.ImageVAlign = Infragistics.Win.VAlign.Middle
        Me.ubt_Quitar.Appearance = Appearance30
        Me.ubt_Quitar.Location = New System.Drawing.Point(737, 324)
        Me.ubt_Quitar.Name = "ubt_Quitar"
        Me.ubt_Quitar.Size = New System.Drawing.Size(29, 24)
        Me.ubt_Quitar.TabIndex = 14
        '
        'ucm_Tipo
        '
        Me.ucm_Tipo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ucm_Tipo.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.ucm_Tipo.Location = New System.Drawing.Point(629, 190)
        Me.ucm_Tipo.Name = "ucm_Tipo"
        Me.ucm_Tipo.Size = New System.Drawing.Size(124, 21)
        Me.ucm_Tipo.TabIndex = 11
        '
        'Panel2
        '
        Me.Panel2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel2.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.Panel2.Location = New System.Drawing.Point(14, 181)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(750, 2)
        Me.Panel2.TabIndex = 154
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.Panel1.Location = New System.Drawing.Point(13, 94)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(750, 2)
        Me.Panel1.TabIndex = 153
        '
        'UltraLabel2
        '
        Me.UltraLabel2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Appearance5.BackColor = System.Drawing.Color.DeepSkyBlue
        Appearance5.ForeColor = System.Drawing.Color.White
        Appearance5.TextHAlignAsString = "Center"
        Me.UltraLabel2.Appearance = Appearance5
        Me.UltraLabel2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel2.Location = New System.Drawing.Point(2, 2)
        Me.UltraLabel2.Name = "UltraLabel2"
        Me.UltraLabel2.Size = New System.Drawing.Size(786, 28)
        Me.UltraLabel2.TabIndex = 27
        Me.UltraLabel2.Text = "Registrar Atención"
        '
        'udte_fecha
        '
        Me.udte_fecha.DateTime = New Date(2014, 1, 28, 0, 0, 0, 0)
        Me.udte_fecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.udte_fecha.Location = New System.Drawing.Point(63, 37)
        Me.udte_fecha.Name = "udte_fecha"
        Me.udte_fecha.ReadOnly = True
        Me.udte_fecha.Size = New System.Drawing.Size(113, 24)
        Me.udte_fecha.TabIndex = 150
        Me.udte_fecha.Value = New Date(2014, 1, 28, 0, 0, 0, 0)
        '
        'udte_fechaNac
        '
        Me.udte_fechaNac.DateTime = New Date(2014, 1, 28, 0, 0, 0, 0)
        Me.udte_fechaNac.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.udte_fechaNac.Location = New System.Drawing.Point(99, 149)
        Me.udte_fechaNac.Name = "udte_fechaNac"
        Me.udte_fechaNac.ReadOnly = True
        Me.udte_fechaNac.Size = New System.Drawing.Size(96, 24)
        Me.udte_fechaNac.TabIndex = 149
        Me.udte_fechaNac.Value = New Date(2014, 1, 28, 0, 0, 0, 0)
        '
        'UltraLabel16
        '
        Appearance4.BackColor = System.Drawing.Color.Transparent
        Appearance4.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel16.Appearance = Appearance4
        Me.UltraLabel16.AutoSize = True
        Me.UltraLabel16.Location = New System.Drawing.Point(13, 155)
        Me.UltraLabel16.Name = "UltraLabel16"
        Me.UltraLabel16.Size = New System.Drawing.Size(62, 14)
        Me.UltraLabel16.TabIndex = 148
        Me.UltraLabel16.Text = "Fecha Nac."
        '
        'UltraLabel15
        '
        Appearance35.BackColor = System.Drawing.Color.Transparent
        Appearance35.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel15.Appearance = Appearance35
        Me.UltraLabel15.AutoSize = True
        Me.UltraLabel15.Location = New System.Drawing.Point(243, 130)
        Me.UltraLabel15.Name = "UltraLabel15"
        Me.UltraLabel15.Size = New System.Drawing.Size(31, 14)
        Me.UltraLabel15.TabIndex = 147
        Me.UltraLabel15.Text = "Edad"
        '
        'txt_Edad
        '
        Me.txt_Edad.Location = New System.Drawing.Point(277, 126)
        Me.txt_Edad.Name = "txt_Edad"
        Me.txt_Edad.ReadOnly = True
        Me.txt_Edad.Size = New System.Drawing.Size(50, 21)
        Me.txt_Edad.TabIndex = 146
        '
        'UltraLabel14
        '
        Appearance18.BackColor = System.Drawing.Color.Transparent
        Appearance18.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel14.Appearance = Appearance18
        Me.UltraLabel14.AutoSize = True
        Me.UltraLabel14.Location = New System.Drawing.Point(13, 130)
        Me.UltraLabel14.Name = "UltraLabel14"
        Me.UltraLabel14.Size = New System.Drawing.Size(80, 14)
        Me.UltraLabel14.TabIndex = 145
        Me.UltraLabel14.Text = "Historia Clínica"
        '
        'txt_Observacion
        '
        Me.txt_Observacion.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_Observacion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_Observacion.Location = New System.Drawing.Point(277, 152)
        Me.txt_Observacion.MaxLength = 100
        Me.txt_Observacion.Name = "txt_Observacion"
        Me.txt_Observacion.Size = New System.Drawing.Size(476, 21)
        Me.txt_Observacion.TabIndex = 5
        '
        'UltraLabel13
        '
        Appearance7.BackColor = System.Drawing.Color.Transparent
        Appearance7.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel13.Appearance = Appearance7
        Me.UltraLabel13.AutoSize = True
        Me.UltraLabel13.Location = New System.Drawing.Point(205, 156)
        Me.UltraLabel13.Name = "UltraLabel13"
        Me.UltraLabel13.Size = New System.Drawing.Size(68, 14)
        Me.UltraLabel13.TabIndex = 144
        Me.UltraLabel13.Text = "Observacion"
        '
        'txt_idCita
        '
        Me.txt_idCita.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_idCita.Location = New System.Drawing.Point(13, 19)
        Me.txt_idCita.MaxLength = 50
        Me.txt_idCita.Name = "txt_idCita"
        Me.txt_idCita.ReadOnly = True
        Me.txt_idCita.Size = New System.Drawing.Size(10, 21)
        Me.txt_idCita.TabIndex = 142
        Me.txt_idCita.Visible = False
        '
        'ugb_Cuenta
        '
        Me.ugb_Cuenta.Controls.Add(Me.UltraLabel20)
        Me.ugb_Cuenta.Controls.Add(Me.UltraLabel17)
        Me.ugb_Cuenta.Controls.Add(Me.txt_FijoC)
        Me.ugb_Cuenta.Controls.Add(Me.txt_DesCobertura)
        Me.ugb_Cuenta.Controls.Add(Me.TXT_TIPOAFILIACION)
        Me.ugb_Cuenta.Controls.Add(Me.txt_FechaAutoriza)
        Me.ugb_Cuenta.Controls.Add(Me.uckIngresoManual)
        Me.ugb_Cuenta.Controls.Add(Me.UltraLabel22)
        Me.ugb_Cuenta.Controls.Add(Me.UltraLabel18)
        Me.ugb_Cuenta.Controls.Add(Me.txt_EPS)
        Me.ugb_Cuenta.Controls.Add(Me.UltraLabel19)
        Me.ugb_Cuenta.Controls.Add(Me.txt_CodAutoriza)
        Me.ugb_Cuenta.Controls.Add(Me.UltraLabel9)
        Me.ugb_Cuenta.Controls.Add(Me.UltraLabel10)
        Me.ugb_Cuenta.Controls.Add(Me.UltraLabel11)
        Me.ugb_Cuenta.Controls.Add(Me.UltraLabel12)
        Me.ugb_Cuenta.Controls.Add(Me.txt_PagoVariable)
        Me.ugb_Cuenta.Controls.Add(Me.txt_PagoFijo)
        Me.ugb_Cuenta.Controls.Add(Me.txt_CodAsegurado)
        Me.ugb_Cuenta.Location = New System.Drawing.Point(13, 218)
        Me.ugb_Cuenta.Name = "ugb_Cuenta"
        Me.ugb_Cuenta.Size = New System.Drawing.Size(684, 130)
        Me.ugb_Cuenta.TabIndex = 141
        Me.ugb_Cuenta.Text = "Informacion Asegurado"
        '
        'UltraLabel20
        '
        Appearance24.BackColor = System.Drawing.Color.Transparent
        Appearance24.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel20.Appearance = Appearance24
        Me.UltraLabel20.AutoSize = True
        Me.UltraLabel20.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel20.Location = New System.Drawing.Point(136, 75)
        Me.UltraLabel20.Name = "UltraLabel20"
        Me.UltraLabel20.Size = New System.Drawing.Size(14, 14)
        Me.UltraLabel20.TabIndex = 159
        Me.UltraLabel20.Text = "%"
        '
        'UltraLabel17
        '
        Appearance32.BackColor = System.Drawing.Color.Transparent
        Appearance32.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel17.Appearance = Appearance32
        Me.UltraLabel17.AutoSize = True
        Me.UltraLabel17.Location = New System.Drawing.Point(8, 47)
        Me.UltraLabel17.Name = "UltraLabel17"
        Me.UltraLabel17.Size = New System.Drawing.Size(65, 14)
        Me.UltraLabel17.TabIndex = 158
        Me.UltraLabel17.Text = "Copago Fijo"
        '
        'txt_FijoC
        '
        Me.txt_FijoC.Location = New System.Drawing.Point(113, 97)
        Me.txt_FijoC.Name = "txt_FijoC"
        Me.txt_FijoC.ReadOnly = True
        Me.txt_FijoC.Size = New System.Drawing.Size(50, 21)
        Me.txt_FijoC.TabIndex = 157
        '
        'txt_DesCobertura
        '
        Me.txt_DesCobertura.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.txt_DesCobertura.Location = New System.Drawing.Point(242, 97)
        Me.txt_DesCobertura.Name = "txt_DesCobertura"
        Me.txt_DesCobertura.Size = New System.Drawing.Size(426, 21)
        Me.txt_DesCobertura.TabIndex = 12
        '
        'TXT_TIPOAFILIACION
        '
        Me.TXT_TIPOAFILIACION.Location = New System.Drawing.Point(469, 12)
        Me.TXT_TIPOAFILIACION.Name = "TXT_TIPOAFILIACION"
        Me.TXT_TIPOAFILIACION.ReadOnly = True
        Me.TXT_TIPOAFILIACION.Size = New System.Drawing.Size(12, 21)
        Me.TXT_TIPOAFILIACION.TabIndex = 156
        Me.TXT_TIPOAFILIACION.Visible = False
        '
        'txt_FechaAutoriza
        '
        Me.txt_FechaAutoriza.DateTime = New Date(2014, 1, 28, 0, 0, 0, 0)
        Me.txt_FechaAutoriza.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_FechaAutoriza.Location = New System.Drawing.Point(543, 68)
        Me.txt_FechaAutoriza.Name = "txt_FechaAutoriza"
        Me.txt_FechaAutoriza.ReadOnly = True
        Me.txt_FechaAutoriza.Size = New System.Drawing.Size(125, 24)
        Me.txt_FechaAutoriza.TabIndex = 155
        Me.txt_FechaAutoriza.Value = New Date(2014, 1, 28, 0, 0, 0, 0)
        '
        'uckIngresoManual
        '
        Appearance36.ForeColor = System.Drawing.Color.Navy
        Me.uckIngresoManual.Appearance = Appearance36
        Me.uckIngresoManual.BackColor = System.Drawing.Color.Transparent
        Me.uckIngresoManual.BackColorInternal = System.Drawing.Color.Transparent
        Me.uckIngresoManual.Location = New System.Drawing.Point(11, 20)
        Me.uckIngresoManual.Name = "uckIngresoManual"
        Me.uckIngresoManual.Size = New System.Drawing.Size(196, 17)
        Me.uckIngresoManual.TabIndex = 9
        Me.uckIngresoManual.Text = "Ingresar Cobertura Manualmente"
        '
        'UltraLabel22
        '
        Appearance9.BackColor = System.Drawing.Color.Transparent
        Appearance9.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel22.Appearance = Appearance9
        Me.UltraLabel22.AutoSize = True
        Me.UltraLabel22.Location = New System.Drawing.Point(456, 74)
        Me.UltraLabel22.Name = "UltraLabel22"
        Me.UltraLabel22.Size = New System.Drawing.Size(80, 14)
        Me.UltraLabel22.TabIndex = 35
        Me.UltraLabel22.Text = "Fecha Autoriza"
        '
        'UltraLabel18
        '
        Appearance25.BackColor = System.Drawing.Color.Transparent
        Appearance25.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel18.Appearance = Appearance25
        Me.UltraLabel18.AutoSize = True
        Me.UltraLabel18.Location = New System.Drawing.Point(452, 47)
        Me.UltraLabel18.Name = "UltraLabel18"
        Me.UltraLabel18.Size = New System.Drawing.Size(54, 14)
        Me.UltraLabel18.TabIndex = 33
        Me.UltraLabel18.Text = "Cód. EPS"
        '
        'txt_EPS
        '
        Me.txt_EPS.Location = New System.Drawing.Point(516, 43)
        Me.txt_EPS.Name = "txt_EPS"
        Me.txt_EPS.ReadOnly = True
        Me.txt_EPS.Size = New System.Drawing.Size(152, 21)
        Me.txt_EPS.TabIndex = 32
        '
        'UltraLabel19
        '
        Appearance37.BackColor = System.Drawing.Color.Transparent
        Appearance37.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel19.Appearance = Appearance37
        Me.UltraLabel19.AutoSize = True
        Me.UltraLabel19.Location = New System.Drawing.Point(213, 47)
        Me.UltraLabel19.Name = "UltraLabel19"
        Me.UltraLabel19.Size = New System.Drawing.Size(94, 14)
        Me.UltraLabel19.TabIndex = 31
        Me.UltraLabel19.Text = "Cód. Autorización"
        '
        'txt_CodAutoriza
        '
        Me.txt_CodAutoriza.Location = New System.Drawing.Point(313, 43)
        Me.txt_CodAutoriza.Name = "txt_CodAutoriza"
        Me.txt_CodAutoriza.Size = New System.Drawing.Size(117, 21)
        Me.txt_CodAutoriza.TabIndex = 10
        '
        'UltraLabel9
        '
        Appearance6.BackColor = System.Drawing.Color.Transparent
        Appearance6.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel9.Appearance = Appearance6
        Me.UltraLabel9.AutoSize = True
        Me.UltraLabel9.Location = New System.Drawing.Point(8, 75)
        Me.UltraLabel9.Name = "UltraLabel9"
        Me.UltraLabel9.Size = New System.Drawing.Size(67, 14)
        Me.UltraLabel9.TabIndex = 27
        Me.UltraLabel9.Text = "Copago Vari"
        '
        'UltraLabel10
        '
        Appearance27.BackColor = System.Drawing.Color.Transparent
        Appearance27.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel10.Appearance = Appearance27
        Me.UltraLabel10.AutoSize = True
        Me.UltraLabel10.Location = New System.Drawing.Point(8, 101)
        Me.UltraLabel10.Name = "UltraLabel10"
        Me.UltraLabel10.Size = New System.Drawing.Size(105, 14)
        Me.UltraLabel10.TabIndex = 27
        Me.UltraLabel10.Text = "Copago Fijo sin IGV"
        '
        'UltraLabel11
        '
        Appearance22.BackColor = System.Drawing.Color.Transparent
        Appearance22.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel11.Appearance = Appearance22
        Me.UltraLabel11.AutoSize = True
        Me.UltraLabel11.Location = New System.Drawing.Point(182, 74)
        Me.UltraLabel11.Name = "UltraLabel11"
        Me.UltraLabel11.Size = New System.Drawing.Size(86, 14)
        Me.UltraLabel11.TabIndex = 27
        Me.UltraLabel11.Text = "Cód. Asegurado"
        '
        'UltraLabel12
        '
        Appearance38.BackColor = System.Drawing.Color.Transparent
        Appearance38.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel12.Appearance = Appearance38
        Me.UltraLabel12.AutoSize = True
        Me.UltraLabel12.Location = New System.Drawing.Point(181, 101)
        Me.UltraLabel12.Name = "UltraLabel12"
        Me.UltraLabel12.Size = New System.Drawing.Size(55, 14)
        Me.UltraLabel12.TabIndex = 27
        Me.UltraLabel12.Text = "Cobertura"
        '
        'txt_PagoVariable
        '
        Me.txt_PagoVariable.Location = New System.Drawing.Point(89, 71)
        Me.txt_PagoVariable.Name = "txt_PagoVariable"
        Me.txt_PagoVariable.ReadOnly = True
        Me.txt_PagoVariable.Size = New System.Drawing.Size(43, 21)
        Me.txt_PagoVariable.TabIndex = 13
        '
        'txt_PagoFijo
        '
        Me.txt_PagoFijo.Location = New System.Drawing.Point(89, 43)
        Me.txt_PagoFijo.Name = "txt_PagoFijo"
        Me.txt_PagoFijo.ReadOnly = True
        Me.txt_PagoFijo.Size = New System.Drawing.Size(74, 21)
        Me.txt_PagoFijo.TabIndex = 12
        '
        'txt_CodAsegurado
        '
        Me.txt_CodAsegurado.Location = New System.Drawing.Point(277, 70)
        Me.txt_CodAsegurado.Name = "txt_CodAsegurado"
        Me.txt_CodAsegurado.Size = New System.Drawing.Size(153, 21)
        Me.txt_CodAsegurado.TabIndex = 1
        '
        'ubt_Agregar
        '
        Me.ubt_Agregar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Appearance31.ImageHAlign = Infragistics.Win.HAlign.Center
        Appearance31.ImageVAlign = Infragistics.Win.VAlign.Middle
        Me.ubt_Agregar.Appearance = Appearance31
        Me.ubt_Agregar.Location = New System.Drawing.Point(703, 324)
        Me.ubt_Agregar.Name = "ubt_Agregar"
        Me.ubt_Agregar.Size = New System.Drawing.Size(29, 24)
        Me.ubt_Agregar.TabIndex = 13
        '
        'ucm_SeguroEps
        '
        Me.ucm_SeguroEps.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.ucm_SeguroEps.Location = New System.Drawing.Point(74, 190)
        Me.ucm_SeguroEps.Name = "ucm_SeguroEps"
        Me.ucm_SeguroEps.Size = New System.Drawing.Size(295, 21)
        Me.ucm_SeguroEps.TabIndex = 7
        '
        'txt_IdCuenta
        '
        Me.txt_IdCuenta.Location = New System.Drawing.Point(483, 191)
        Me.txt_IdCuenta.Name = "txt_IdCuenta"
        Me.txt_IdCuenta.ReadOnly = True
        Me.txt_IdCuenta.Size = New System.Drawing.Size(112, 21)
        Me.txt_IdCuenta.TabIndex = 137
        '
        'uchk_SeguroEps
        '
        Appearance8.ForeColor = System.Drawing.Color.Navy
        Me.uchk_SeguroEps.Appearance = Appearance8
        Me.uchk_SeguroEps.BackColor = System.Drawing.Color.Transparent
        Me.uchk_SeguroEps.BackColorInternal = System.Drawing.Color.Transparent
        Me.uchk_SeguroEps.Location = New System.Drawing.Point(13, 190)
        Me.uchk_SeguroEps.Name = "uchk_SeguroEps"
        Me.uchk_SeguroEps.Size = New System.Drawing.Size(68, 22)
        Me.uchk_SeguroEps.TabIndex = 6
        Me.uchk_SeguroEps.Text = "Seguro"
        '
        'uchk_GenerarCta
        '
        Appearance20.ForeColor = System.Drawing.Color.Navy
        Me.uchk_GenerarCta.Appearance = Appearance20
        Me.uchk_GenerarCta.BackColor = System.Drawing.Color.Transparent
        Me.uchk_GenerarCta.BackColorInternal = System.Drawing.Color.Transparent
        Me.uchk_GenerarCta.Location = New System.Drawing.Point(380, 194)
        Me.uchk_GenerarCta.Name = "uchk_GenerarCta"
        Me.uchk_GenerarCta.Size = New System.Drawing.Size(105, 17)
        Me.uchk_GenerarCta.TabIndex = 8
        Me.uchk_GenerarCta.Text = "Generar Cuenta"
        '
        'uce_tip_doc
        '
        Me.uce_tip_doc.DropDownListWidth = 300
        Me.uce_tip_doc.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.uce_tip_doc.Location = New System.Drawing.Point(63, 102)
        Me.uce_tip_doc.Name = "uce_tip_doc"
        Me.uce_tip_doc.Size = New System.Drawing.Size(63, 21)
        Me.uce_tip_doc.TabIndex = 2
        '
        'txt_idprogramacion
        '
        Me.txt_idprogramacion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_idprogramacion.Location = New System.Drawing.Point(27, 19)
        Me.txt_idprogramacion.MaxLength = 50
        Me.txt_idprogramacion.Name = "txt_idprogramacion"
        Me.txt_idprogramacion.ReadOnly = True
        Me.txt_idprogramacion.Size = New System.Drawing.Size(10, 21)
        Me.txt_idprogramacion.TabIndex = 130
        Me.txt_idprogramacion.Visible = False
        '
        'txt_Des_Cliente
        '
        Me.txt_Des_Cliente.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_Des_Cliente.Location = New System.Drawing.Point(229, 102)
        Me.txt_Des_Cliente.Name = "txt_Des_Cliente"
        Me.txt_Des_Cliente.ReadOnly = True
        Me.txt_Des_Cliente.Size = New System.Drawing.Size(524, 21)
        Me.txt_Des_Cliente.TabIndex = 128
        '
        'txt_ruc_cliente
        '
        Appearance2.ImageHAlign = Infragistics.Win.HAlign.Center
        Appearance2.ImageVAlign = Infragistics.Win.VAlign.Middle
        EditorButton1.Appearance = Appearance2
        EditorButton1.Key = "ayuda"
        Me.txt_ruc_cliente.ButtonsRight.Add(EditorButton1)
        Me.txt_ruc_cliente.Location = New System.Drawing.Point(126, 102)
        Me.txt_ruc_cliente.MaxLength = 11
        Me.txt_ruc_cliente.Name = "txt_ruc_cliente"
        Me.txt_ruc_cliente.Size = New System.Drawing.Size(102, 21)
        Me.txt_ruc_cliente.TabIndex = 3
        '
        'UltraLabel7
        '
        Appearance40.BackColor = System.Drawing.Color.Transparent
        Appearance40.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel7.Appearance = Appearance40
        Me.UltraLabel7.AutoSize = True
        Me.UltraLabel7.Location = New System.Drawing.Point(13, 106)
        Me.UltraLabel7.Name = "UltraLabel7"
        Me.UltraLabel7.Size = New System.Drawing.Size(48, 14)
        Me.UltraLabel7.TabIndex = 129
        Me.UltraLabel7.Text = "Paciente"
        '
        'txt_Medico
        '
        Me.txt_Medico.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_Medico.Location = New System.Drawing.Point(435, 66)
        Me.txt_Medico.MaxLength = 5
        Me.txt_Medico.Name = "txt_Medico"
        Me.txt_Medico.ReadOnly = True
        Me.txt_Medico.Size = New System.Drawing.Size(318, 21)
        Me.txt_Medico.TabIndex = 37
        '
        'UltraLabel6
        '
        Appearance28.BackColor = System.Drawing.Color.Transparent
        Appearance28.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel6.Appearance = Appearance28
        Me.UltraLabel6.AutoSize = True
        Me.UltraLabel6.Location = New System.Drawing.Point(381, 70)
        Me.UltraLabel6.Name = "UltraLabel6"
        Me.UltraLabel6.Size = New System.Drawing.Size(41, 14)
        Me.UltraLabel6.TabIndex = 36
        Me.UltraLabel6.Text = "Médico"
        '
        'txt_Servicio
        '
        Me.txt_Servicio.Location = New System.Drawing.Point(63, 66)
        Me.txt_Servicio.MaxLength = 5
        Me.txt_Servicio.Name = "txt_Servicio"
        Me.txt_Servicio.ReadOnly = True
        Me.txt_Servicio.Size = New System.Drawing.Size(192, 21)
        Me.txt_Servicio.TabIndex = 35
        '
        'UltraLabel5
        '
        Appearance42.BackColor = System.Drawing.Color.Transparent
        Appearance42.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel5.Appearance = Appearance42
        Me.UltraLabel5.AutoSize = True
        Me.UltraLabel5.Location = New System.Drawing.Point(13, 70)
        Me.UltraLabel5.Name = "UltraLabel5"
        Me.UltraLabel5.Size = New System.Drawing.Size(45, 14)
        Me.UltraLabel5.TabIndex = 34
        Me.UltraLabel5.Text = "Servicio"
        '
        'txt_Orden
        '
        Me.txt_Orden.Location = New System.Drawing.Point(435, 40)
        Me.txt_Orden.MaxLength = 5
        Me.txt_Orden.Name = "txt_Orden"
        Me.txt_Orden.ReadOnly = True
        Me.txt_Orden.Size = New System.Drawing.Size(50, 21)
        Me.txt_Orden.TabIndex = 33
        '
        'UltraLabel4
        '
        Appearance43.BackColor = System.Drawing.Color.Transparent
        Appearance43.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel4.Appearance = Appearance43
        Me.UltraLabel4.AutoSize = True
        Me.UltraLabel4.Location = New System.Drawing.Point(381, 44)
        Me.UltraLabel4.Name = "UltraLabel4"
        Me.UltraLabel4.Size = New System.Drawing.Size(51, 14)
        Me.UltraLabel4.TabIndex = 32
        Me.UltraLabel4.Text = "Nº Orden"
        '
        'txt_Hora
        '
        Me.txt_Hora.Location = New System.Drawing.Point(259, 40)
        Me.txt_Hora.MaxLength = 5
        Me.txt_Hora.Name = "txt_Hora"
        Me.txt_Hora.ReadOnly = True
        Me.txt_Hora.Size = New System.Drawing.Size(100, 21)
        Me.txt_Hora.TabIndex = 30
        '
        'UltraLabel3
        '
        Appearance44.BackColor = System.Drawing.Color.Transparent
        Appearance44.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel3.Appearance = Appearance44
        Me.UltraLabel3.AutoSize = True
        Me.UltraLabel3.Location = New System.Drawing.Point(196, 44)
        Me.UltraLabel3.Name = "UltraLabel3"
        Me.UltraLabel3.Size = New System.Drawing.Size(59, 14)
        Me.UltraLabel3.TabIndex = 28
        Me.UltraLabel3.Text = "Hora Prog."
        '
        'UltraLabel1
        '
        Appearance45.BackColor = System.Drawing.Color.Transparent
        Appearance45.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel1.Appearance = Appearance45
        Me.UltraLabel1.AutoSize = True
        Me.UltraLabel1.Location = New System.Drawing.Point(13, 44)
        Me.UltraLabel1.Name = "UltraLabel1"
        Me.UltraLabel1.Size = New System.Drawing.Size(36, 14)
        Me.UltraLabel1.TabIndex = 29
        Me.UltraLabel1.Text = "Fecha"
        '
        'txt_IdCliente
        '
        Me.txt_IdCliente.Location = New System.Drawing.Point(108, 95)
        Me.txt_IdCliente.Name = "txt_IdCliente"
        Me.txt_IdCliente.Size = New System.Drawing.Size(37, 21)
        Me.txt_IdCliente.TabIndex = 127
        Me.txt_IdCliente.Visible = False
        '
        'txt_idHistoria
        '
        Me.txt_idHistoria.Location = New System.Drawing.Point(99, 126)
        Me.txt_idHistoria.Name = "txt_idHistoria"
        Me.txt_idHistoria.ReadOnly = True
        Me.txt_idHistoria.Size = New System.Drawing.Size(129, 21)
        Me.txt_idHistoria.TabIndex = 132
        '
        'txt_SubTotal
        '
        Me.txt_SubTotal.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Appearance15.TextHAlignAsString = "Right"
        Me.txt_SubTotal.Appearance = Appearance15
        Me.txt_SubTotal.Location = New System.Drawing.Point(306, 522)
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
        Me.UltraLabel24.Location = New System.Drawing.Point(250, 524)
        Me.UltraLabel24.Name = "UltraLabel24"
        Me.UltraLabel24.Size = New System.Drawing.Size(54, 16)
        Me.UltraLabel24.TabIndex = 135
        Me.UltraLabel24.Text = "SubTotal"
        '
        'UltraLabel25
        '
        Me.UltraLabel25.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Appearance1.BackColor = System.Drawing.Color.Transparent
        Appearance1.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel25.Appearance = Appearance1
        Me.UltraLabel25.AutoSize = True
        Me.UltraLabel25.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel25.Location = New System.Drawing.Point(449, 524)
        Me.UltraLabel25.Name = "UltraLabel25"
        Me.UltraLabel25.Size = New System.Drawing.Size(36, 16)
        Me.UltraLabel25.TabIndex = 134
        Me.UltraLabel25.Text = "I.G.V."
        '
        'UltraLabel32
        '
        Me.UltraLabel32.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Appearance3.BackColor = System.Drawing.Color.Transparent
        Appearance3.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel32.Appearance = Appearance3
        Me.UltraLabel32.AutoSize = True
        Me.UltraLabel32.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel32.Location = New System.Drawing.Point(619, 524)
        Me.UltraLabel32.Name = "UltraLabel32"
        Me.UltraLabel32.Size = New System.Drawing.Size(33, 16)
        Me.UltraLabel32.TabIndex = 133
        Me.UltraLabel32.Text = "Total"
        '
        'txt_IGV
        '
        Me.txt_IGV.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Appearance16.TextHAlignAsString = "Right"
        Me.txt_IGV.Appearance = Appearance16
        Me.txt_IGV.Location = New System.Drawing.Point(485, 522)
        Me.txt_IGV.Name = "txt_IGV"
        Me.txt_IGV.ReadOnly = True
        Me.txt_IGV.Size = New System.Drawing.Size(116, 21)
        Me.txt_IGV.TabIndex = 136
        '
        'txt_Total
        '
        Me.txt_Total.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Appearance17.TextHAlignAsString = "Right"
        Me.txt_Total.Appearance = Appearance17
        Me.txt_Total.Location = New System.Drawing.Point(658, 522)
        Me.txt_Total.Name = "txt_Total"
        Me.txt_Total.ReadOnly = True
        Me.txt_Total.Size = New System.Drawing.Size(116, 21)
        Me.txt_Total.TabIndex = 137
        '
        'AD_PR_Atencion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(792, 550)
        Me.Controls.Add(Me.txt_Total)
        Me.Controls.Add(Me.txt_IGV)
        Me.Controls.Add(Me.UltraLabel24)
        Me.Controls.Add(Me.UltraLabel25)
        Me.Controls.Add(Me.UltraLabel32)
        Me.Controls.Add(Me.txt_SubTotal)
        Me.Controls.Add(Me.ugb_Datos)
        Me.Controls.Add(Me.ToolS_Mantenimiento)
        Me.Name = "AD_PR_Atencion"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Registro de Atención"
        Me.ToolS_Mantenimiento.ResumeLayout(False)
        Me.ToolS_Mantenimiento.PerformLayout()
        CType(Me.ugb_Datos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ugb_Datos.ResumeLayout(False)
        Me.ugb_Datos.PerformLayout()
        CType(Me.uce_Medico, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ug_detalle, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.uds_detalle, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ucm_Tipo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.udte_fecha, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.udte_fechaNac, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_Edad, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_Observacion, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_idCita, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ugb_Cuenta, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ugb_Cuenta.ResumeLayout(False)
        Me.ugb_Cuenta.PerformLayout()
        CType(Me.txt_FijoC, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_DesCobertura, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TXT_TIPOAFILIACION, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_FechaAutoriza, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_EPS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_CodAutoriza, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_PagoVariable, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_PagoFijo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_CodAsegurado, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ucm_SeguroEps, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_IdCuenta, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.uce_tip_doc, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_idprogramacion, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_Des_Cliente, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_ruc_cliente, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_Medico, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_Servicio, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_Orden, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_Hora, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_IdCliente, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_idHistoria, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_SubTotal, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_IGV, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_Total, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolS_Mantenimiento As System.Windows.Forms.ToolStrip
    Friend WithEvents Tool_Grabar As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents Tool_Salir As System.Windows.Forms.ToolStripButton
    Friend WithEvents ugb_Datos As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents uce_tip_doc As Infragistics.Win.UltraWinEditors.UltraComboEditor
    Friend WithEvents txt_idprogramacion As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents txt_Des_Cliente As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents txt_ruc_cliente As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents UltraLabel7 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents txt_Medico As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents UltraLabel6 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents txt_Servicio As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents UltraLabel5 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents txt_Orden As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents UltraLabel4 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents txt_Hora As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents UltraLabel3 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel1 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel2 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents txt_IdCliente As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents txt_idHistoria As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents ume_HoraLLegada As Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit
    Friend WithEvents ugb_Cuenta As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents UltraLabel9 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel10 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel11 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel12 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents txt_PagoVariable As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents txt_PagoFijo As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents txt_CodAsegurado As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents ubt_Agregar As Infragistics.Win.Misc.UltraButton
    Friend WithEvents ucm_SeguroEps As Infragistics.Win.UltraWinEditors.UltraComboEditor
    Friend WithEvents txt_IdCuenta As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents uchk_SeguroEps As Infragistics.Win.UltraWinEditors.UltraCheckEditor
    Friend WithEvents uchk_GenerarCta As Infragistics.Win.UltraWinEditors.UltraCheckEditor
    Friend WithEvents txt_idCita As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents txt_Observacion As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents UltraLabel13 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel14 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel15 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents txt_Edad As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents udte_fechaNac As Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
    Friend WithEvents UltraLabel16 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel18 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents txt_EPS As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents UltraLabel19 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents txt_CodAutoriza As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents udte_fecha As Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
    Friend WithEvents ume_horaIngreso As Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit
    Friend WithEvents ucm_Tipo As Infragistics.Win.UltraWinEditors.UltraComboEditor
    Friend WithEvents UltraLabel21 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents UltraLabel22 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents uckIngresoManual As Infragistics.Win.UltraWinEditors.UltraCheckEditor
    Friend WithEvents txt_FechaAutoriza As Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
    Friend WithEvents txt_SubTotal As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents UltraLabel24 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel25 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel32 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents txt_IGV As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents txt_Total As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents ubt_Quitar As Infragistics.Win.Misc.UltraButton
    Friend WithEvents uds_detalle As Infragistics.Win.UltraWinDataSource.UltraDataSource
    Public WithEvents ug_detalle As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents uck_HoraLlegada As Infragistics.Win.UltraWinEditors.UltraCheckEditor
    Friend WithEvents uck_HoraIngreso As Infragistics.Win.UltraWinEditors.UltraCheckEditor
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents Tool_ImprimirF As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents Tool_ImprimirA As System.Windows.Forms.ToolStripButton
    Friend WithEvents TXT_TIPOAFILIACION As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Public WithEvents uce_Medico As Infragistics.Win.UltraWinEditors.UltraComboEditor
    Friend WithEvents UltraLabel8 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents txt_DesCobertura As Infragistics.Win.UltraWinEditors.UltraComboEditor
    Friend WithEvents UltraLabel17 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents txt_FijoC As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents UltraLabel20 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents uck_Anamnesis As Infragistics.Win.UltraWinEditors.UltraCheckEditor
End Class
