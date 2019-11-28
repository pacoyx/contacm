<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AD_PR_PreFacturacion
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
        Dim Appearance11 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance13 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance14 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance19 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance20 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance37 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance6 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance39 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance42 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance38 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance5 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance43 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim ValueListItem1 As Infragistics.Win.ValueListItem = New Infragistics.Win.ValueListItem()
        Dim ValueListItem2 As Infragistics.Win.ValueListItem = New Infragistics.Win.ValueListItem()
        Dim Appearance44 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim EditorButton1 As Infragistics.Win.UltraWinEditors.EditorButton = New Infragistics.Win.UltraWinEditors.EditorButton("ayuda")
        Dim Appearance46 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance47 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance48 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim EditorButton2 As Infragistics.Win.UltraWinEditors.EditorButton = New Infragistics.Win.UltraWinEditors.EditorButton("ayuda")
        Dim Appearance8 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance7 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance49 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance50 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraTab1 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraTab2 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
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
        Me.ugb_Datos = New Infragistics.Win.Misc.UltraGroupBox()
        Me.ugb_Cuenta = New Infragistics.Win.Misc.UltraGroupBox()
        Me.UltraLabel2 = New Infragistics.Win.Misc.UltraLabel()
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
        Me.ucm_SeguroEps = New Infragistics.Win.UltraWinEditors.UltraComboEditor()
        Me.uchk_SeguroEps = New Infragistics.Win.UltraWinEditors.UltraCheckEditor()
        Me.UltraLabel7 = New Infragistics.Win.Misc.UltraLabel()
        Me.ucbo_Estado = New Infragistics.Win.UltraWinEditors.UltraComboEditor()
        Me.UltraLabel21 = New Infragistics.Win.Misc.UltraLabel()
        Me.ucm_Tipo = New Infragistics.Win.UltraWinEditors.UltraComboEditor()
        Me.uce_tip_doc = New Infragistics.Win.UltraWinEditors.UltraComboEditor()
        Me.txt_Des_Cliente = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.txt_ruc_cliente = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.UltraLabel20 = New Infragistics.Win.Misc.UltraLabel()
        Me.txt_IdCliente = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.UltraLabel4 = New Infragistics.Win.Misc.UltraLabel()
        Me.txt_idHistoria = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.txt_IdCuenta = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.uce_Medico = New Infragistics.Win.UltraWinEditors.UltraComboEditor()
        Me.udte_fecha = New Infragistics.Win.UltraWinEditors.UltraDateTimeEditor()
        Me.uchk_GenerarCta = New Infragistics.Win.UltraWinEditors.UltraCheckEditor()
        Me.UltraLabel6 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraLabel1 = New Infragistics.Win.Misc.UltraLabel()
        Me.txt_idPreFactura = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.utc_Datos = New Infragistics.Win.UltraWinTabControl.UltraTabControl()
        Me.UltraTabSharedControlsPage1 = New Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage()
        Me.UltraTabPageControl1 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.ug_Lista = New Infragistics.Win.UltraWinGrid.UltraGrid()
        Me.UltraTabPageControl2 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.ToolS_Mantenimiento.SuspendLayout()
        CType(Me.ugb_Datos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ugb_Datos.SuspendLayout()
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
        CType(Me.ucbo_Estado, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ucm_Tipo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.uce_tip_doc, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_Des_Cliente, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_ruc_cliente, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_IdCliente, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_idHistoria, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_IdCuenta, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.uce_Medico, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.udte_fecha, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_idPreFactura, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.utc_Datos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.utc_Datos.SuspendLayout()
        Me.UltraTabPageControl1.SuspendLayout()
        CType(Me.ug_Lista, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabPageControl2.SuspendLayout()
        Me.SuspendLayout()
        '
        'ToolS_Mantenimiento
        '
        Me.ToolS_Mantenimiento.BackColor = System.Drawing.Color.White
        Me.ToolS_Mantenimiento.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Tool_Nuevo, Me.ToolStripSeparator1, Me.Tool_Grabar, Me.ToolStripSeparator4, Me.Tool_Editar, Me.ToolStripSeparator3, Me.Tool_Cancelar, Me.ToolStripSeparator2, Me.Tool_Eliminar, Me.ToolStripSeparator5, Me.Tool_Salir})
        Me.ToolS_Mantenimiento.Location = New System.Drawing.Point(0, 0)
        Me.ToolS_Mantenimiento.Name = "ToolS_Mantenimiento"
        Me.ToolS_Mantenimiento.Size = New System.Drawing.Size(872, 25)
        Me.ToolS_Mantenimiento.TabIndex = 140
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
        'ugb_Datos
        '
        Me.ugb_Datos.Controls.Add(Me.ugb_Cuenta)
        Me.ugb_Datos.Controls.Add(Me.ucm_SeguroEps)
        Me.ugb_Datos.Controls.Add(Me.uchk_SeguroEps)
        Me.ugb_Datos.Controls.Add(Me.UltraLabel7)
        Me.ugb_Datos.Controls.Add(Me.ucbo_Estado)
        Me.ugb_Datos.Controls.Add(Me.UltraLabel21)
        Me.ugb_Datos.Controls.Add(Me.ucm_Tipo)
        Me.ugb_Datos.Controls.Add(Me.uce_tip_doc)
        Me.ugb_Datos.Controls.Add(Me.txt_Des_Cliente)
        Me.ugb_Datos.Controls.Add(Me.txt_ruc_cliente)
        Me.ugb_Datos.Controls.Add(Me.UltraLabel20)
        Me.ugb_Datos.Controls.Add(Me.txt_IdCliente)
        Me.ugb_Datos.Controls.Add(Me.UltraLabel4)
        Me.ugb_Datos.Controls.Add(Me.txt_idHistoria)
        Me.ugb_Datos.Controls.Add(Me.txt_IdCuenta)
        Me.ugb_Datos.Controls.Add(Me.uce_Medico)
        Me.ugb_Datos.Controls.Add(Me.udte_fecha)
        Me.ugb_Datos.Controls.Add(Me.uchk_GenerarCta)
        Me.ugb_Datos.Controls.Add(Me.UltraLabel6)
        Me.ugb_Datos.Controls.Add(Me.UltraLabel1)
        Me.ugb_Datos.Controls.Add(Me.txt_idPreFactura)
        Me.ugb_Datos.Location = New System.Drawing.Point(3, 9)
        Me.ugb_Datos.Name = "ugb_Datos"
        Me.ugb_Datos.Size = New System.Drawing.Size(862, 250)
        Me.ugb_Datos.TabIndex = 139
        '
        'ugb_Cuenta
        '
        Me.ugb_Cuenta.Controls.Add(Me.UltraLabel2)
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
        Me.ugb_Cuenta.Location = New System.Drawing.Point(14, 108)
        Me.ugb_Cuenta.Name = "ugb_Cuenta"
        Me.ugb_Cuenta.Size = New System.Drawing.Size(833, 117)
        Me.ugb_Cuenta.TabIndex = 192
        Me.ugb_Cuenta.Text = "Informacion Asegurado"
        '
        'UltraLabel2
        '
        Appearance11.BackColor = System.Drawing.Color.Transparent
        Appearance11.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel2.Appearance = Appearance11
        Me.UltraLabel2.AutoSize = True
        Me.UltraLabel2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel2.Location = New System.Drawing.Point(307, 58)
        Me.UltraLabel2.Name = "UltraLabel2"
        Me.UltraLabel2.Size = New System.Drawing.Size(14, 14)
        Me.UltraLabel2.TabIndex = 159
        Me.UltraLabel2.Text = "%"
        '
        'UltraLabel17
        '
        Appearance13.BackColor = System.Drawing.Color.Transparent
        Appearance13.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel17.Appearance = Appearance13
        Me.UltraLabel17.AutoSize = True
        Me.UltraLabel17.Location = New System.Drawing.Point(8, 58)
        Me.UltraLabel17.Name = "UltraLabel17"
        Me.UltraLabel17.Size = New System.Drawing.Size(65, 14)
        Me.UltraLabel17.TabIndex = 158
        Me.UltraLabel17.Text = "Copago Fijo"
        '
        'txt_FijoC
        '
        Me.txt_FijoC.Location = New System.Drawing.Point(113, 80)
        Me.txt_FijoC.Name = "txt_FijoC"
        Me.txt_FijoC.ReadOnly = True
        Me.txt_FijoC.Size = New System.Drawing.Size(50, 21)
        Me.txt_FijoC.TabIndex = 157
        '
        'txt_DesCobertura
        '
        Me.txt_DesCobertura.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.txt_DesCobertura.Location = New System.Drawing.Point(397, 54)
        Me.txt_DesCobertura.Name = "txt_DesCobertura"
        Me.txt_DesCobertura.Size = New System.Drawing.Size(426, 21)
        Me.txt_DesCobertura.TabIndex = 12
        '
        'TXT_TIPOAFILIACION
        '
        Me.TXT_TIPOAFILIACION.Location = New System.Drawing.Point(815, 9)
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
        Me.txt_FechaAutoriza.Location = New System.Drawing.Point(719, 78)
        Me.txt_FechaAutoriza.Name = "txt_FechaAutoriza"
        Me.txt_FechaAutoriza.ReadOnly = True
        Me.txt_FechaAutoriza.Size = New System.Drawing.Size(104, 24)
        Me.txt_FechaAutoriza.TabIndex = 155
        Me.txt_FechaAutoriza.Value = New Date(2014, 1, 28, 0, 0, 0, 0)
        '
        'uckIngresoManual
        '
        Appearance14.ForeColor = System.Drawing.Color.Navy
        Me.uckIngresoManual.Appearance = Appearance14
        Me.uckIngresoManual.BackColor = System.Drawing.Color.Transparent
        Me.uckIngresoManual.BackColorInternal = System.Drawing.Color.Transparent
        Me.uckIngresoManual.Location = New System.Drawing.Point(11, 27)
        Me.uckIngresoManual.Name = "uckIngresoManual"
        Me.uckIngresoManual.Size = New System.Drawing.Size(196, 17)
        Me.uckIngresoManual.TabIndex = 9
        Me.uckIngresoManual.Text = "Ingresar Cobertura Manualmente"
        '
        'UltraLabel22
        '
        Appearance19.BackColor = System.Drawing.Color.Transparent
        Appearance19.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel22.Appearance = Appearance19
        Me.UltraLabel22.AutoSize = True
        Me.UltraLabel22.Location = New System.Drawing.Point(637, 84)
        Me.UltraLabel22.Name = "UltraLabel22"
        Me.UltraLabel22.Size = New System.Drawing.Size(80, 14)
        Me.UltraLabel22.TabIndex = 35
        Me.UltraLabel22.Text = "Fecha Autoriza"
        '
        'UltraLabel18
        '
        Appearance20.BackColor = System.Drawing.Color.Transparent
        Appearance20.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel18.Appearance = Appearance20
        Me.UltraLabel18.AutoSize = True
        Me.UltraLabel18.Location = New System.Drawing.Point(434, 84)
        Me.UltraLabel18.Name = "UltraLabel18"
        Me.UltraLabel18.Size = New System.Drawing.Size(54, 14)
        Me.UltraLabel18.TabIndex = 33
        Me.UltraLabel18.Text = "Cód. EPS"
        '
        'txt_EPS
        '
        Me.txt_EPS.Location = New System.Drawing.Point(492, 80)
        Me.txt_EPS.Name = "txt_EPS"
        Me.txt_EPS.ReadOnly = True
        Me.txt_EPS.Size = New System.Drawing.Size(139, 21)
        Me.txt_EPS.TabIndex = 32
        '
        'UltraLabel19
        '
        Appearance37.BackColor = System.Drawing.Color.Transparent
        Appearance37.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel19.Appearance = Appearance37
        Me.UltraLabel19.AutoSize = True
        Me.UltraLabel19.Location = New System.Drawing.Point(213, 30)
        Me.UltraLabel19.Name = "UltraLabel19"
        Me.UltraLabel19.Size = New System.Drawing.Size(94, 14)
        Me.UltraLabel19.TabIndex = 31
        Me.UltraLabel19.Text = "Cód. Autorización"
        '
        'txt_CodAutoriza
        '
        Me.txt_CodAutoriza.Location = New System.Drawing.Point(313, 26)
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
        Me.UltraLabel9.Location = New System.Drawing.Point(175, 58)
        Me.UltraLabel9.Name = "UltraLabel9"
        Me.UltraLabel9.Size = New System.Drawing.Size(67, 14)
        Me.UltraLabel9.TabIndex = 27
        Me.UltraLabel9.Text = "Copago Vari"
        '
        'UltraLabel10
        '
        Appearance39.BackColor = System.Drawing.Color.Transparent
        Appearance39.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel10.Appearance = Appearance39
        Me.UltraLabel10.AutoSize = True
        Me.UltraLabel10.Location = New System.Drawing.Point(8, 84)
        Me.UltraLabel10.Name = "UltraLabel10"
        Me.UltraLabel10.Size = New System.Drawing.Size(105, 14)
        Me.UltraLabel10.TabIndex = 27
        Me.UltraLabel10.Text = "Copago Fijo sin IGV"
        '
        'UltraLabel11
        '
        Appearance42.BackColor = System.Drawing.Color.Transparent
        Appearance42.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel11.Appearance = Appearance42
        Me.UltraLabel11.AutoSize = True
        Me.UltraLabel11.Location = New System.Drawing.Point(175, 84)
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
        Me.UltraLabel12.Location = New System.Drawing.Point(340, 58)
        Me.UltraLabel12.Name = "UltraLabel12"
        Me.UltraLabel12.Size = New System.Drawing.Size(55, 14)
        Me.UltraLabel12.TabIndex = 27
        Me.UltraLabel12.Text = "Cobertura"
        '
        'txt_PagoVariable
        '
        Me.txt_PagoVariable.Location = New System.Drawing.Point(261, 54)
        Me.txt_PagoVariable.Name = "txt_PagoVariable"
        Me.txt_PagoVariable.ReadOnly = True
        Me.txt_PagoVariable.Size = New System.Drawing.Size(43, 21)
        Me.txt_PagoVariable.TabIndex = 13
        '
        'txt_PagoFijo
        '
        Me.txt_PagoFijo.Location = New System.Drawing.Point(89, 54)
        Me.txt_PagoFijo.Name = "txt_PagoFijo"
        Me.txt_PagoFijo.ReadOnly = True
        Me.txt_PagoFijo.Size = New System.Drawing.Size(74, 21)
        Me.txt_PagoFijo.TabIndex = 12
        '
        'txt_CodAsegurado
        '
        Me.txt_CodAsegurado.Location = New System.Drawing.Point(261, 80)
        Me.txt_CodAsegurado.Name = "txt_CodAsegurado"
        Me.txt_CodAsegurado.Size = New System.Drawing.Size(167, 21)
        Me.txt_CodAsegurado.TabIndex = 1
        '
        'ucm_SeguroEps
        '
        Me.ucm_SeguroEps.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.ucm_SeguroEps.Location = New System.Drawing.Point(89, 75)
        Me.ucm_SeguroEps.Name = "ucm_SeguroEps"
        Me.ucm_SeguroEps.Size = New System.Drawing.Size(388, 21)
        Me.ucm_SeguroEps.TabIndex = 191
        '
        'uchk_SeguroEps
        '
        Appearance5.ForeColor = System.Drawing.Color.Navy
        Me.uchk_SeguroEps.Appearance = Appearance5
        Me.uchk_SeguroEps.BackColor = System.Drawing.Color.Transparent
        Me.uchk_SeguroEps.BackColorInternal = System.Drawing.Color.Transparent
        Me.uchk_SeguroEps.Location = New System.Drawing.Point(24, 75)
        Me.uchk_SeguroEps.Name = "uchk_SeguroEps"
        Me.uchk_SeguroEps.Size = New System.Drawing.Size(63, 22)
        Me.uchk_SeguroEps.TabIndex = 190
        Me.uchk_SeguroEps.Text = "Seguro"
        '
        'UltraLabel7
        '
        Appearance43.BackColor = System.Drawing.Color.Transparent
        Appearance43.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel7.Appearance = Appearance43
        Me.UltraLabel7.AutoSize = True
        Me.UltraLabel7.Location = New System.Drawing.Point(685, 26)
        Me.UltraLabel7.Name = "UltraLabel7"
        Me.UltraLabel7.Size = New System.Drawing.Size(39, 14)
        Me.UltraLabel7.TabIndex = 180
        Me.UltraLabel7.Text = "Estado"
        '
        'ucbo_Estado
        '
        Me.ucbo_Estado.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        ValueListItem1.DataValue = "1"
        ValueListItem1.DisplayText = "Pendiente"
        ValueListItem2.DataValue = "2"
        ValueListItem2.DisplayText = "Facturado"
        Me.ucbo_Estado.Items.AddRange(New Infragistics.Win.ValueListItem() {ValueListItem1, ValueListItem2})
        Me.ucbo_Estado.Location = New System.Drawing.Point(730, 22)
        Me.ucbo_Estado.Name = "ucbo_Estado"
        Me.ucbo_Estado.ReadOnly = True
        Me.ucbo_Estado.Size = New System.Drawing.Size(117, 21)
        Me.ucbo_Estado.TabIndex = 7
        '
        'UltraLabel21
        '
        Appearance44.BackColor = System.Drawing.Color.Transparent
        Appearance44.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel21.Appearance = Appearance44
        Me.UltraLabel21.AutoSize = True
        Me.UltraLabel21.Location = New System.Drawing.Point(251, 25)
        Me.UltraLabel21.Name = "UltraLabel21"
        Me.UltraLabel21.Size = New System.Drawing.Size(73, 14)
        Me.UltraLabel21.TabIndex = 154
        Me.UltraLabel21.Text = "Tipo Atención"
        '
        'ucm_Tipo
        '
        Me.ucm_Tipo.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.ucm_Tipo.Location = New System.Drawing.Point(327, 21)
        Me.ucm_Tipo.Name = "ucm_Tipo"
        Me.ucm_Tipo.Size = New System.Drawing.Size(150, 21)
        Me.ucm_Tipo.TabIndex = 6
        '
        'uce_tip_doc
        '
        Me.uce_tip_doc.DropDownListWidth = 300
        Me.uce_tip_doc.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.uce_tip_doc.Location = New System.Drawing.Point(89, 48)
        Me.uce_tip_doc.Name = "uce_tip_doc"
        Me.uce_tip_doc.Size = New System.Drawing.Size(63, 21)
        Me.uce_tip_doc.TabIndex = 173
        '
        'txt_Des_Cliente
        '
        Me.txt_Des_Cliente.Location = New System.Drawing.Point(474, 48)
        Me.txt_Des_Cliente.Name = "txt_Des_Cliente"
        Me.txt_Des_Cliente.ReadOnly = True
        Me.txt_Des_Cliente.Size = New System.Drawing.Size(373, 21)
        Me.txt_Des_Cliente.TabIndex = 176
        '
        'txt_ruc_cliente
        '
        Appearance46.ImageHAlign = Infragistics.Win.HAlign.Center
        Appearance46.ImageVAlign = Infragistics.Win.VAlign.Middle
        EditorButton1.Appearance = Appearance46
        EditorButton1.Key = "ayuda"
        Me.txt_ruc_cliente.ButtonsRight.Add(EditorButton1)
        Me.txt_ruc_cliente.Location = New System.Drawing.Point(152, 48)
        Me.txt_ruc_cliente.MaxLength = 11
        Me.txt_ruc_cliente.Name = "txt_ruc_cliente"
        Me.txt_ruc_cliente.Size = New System.Drawing.Size(155, 21)
        Me.txt_ruc_cliente.TabIndex = 174
        '
        'UltraLabel20
        '
        Appearance47.BackColor = System.Drawing.Color.Transparent
        Appearance47.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel20.Appearance = Appearance47
        Me.UltraLabel20.AutoSize = True
        Me.UltraLabel20.Location = New System.Drawing.Point(21, 52)
        Me.UltraLabel20.Name = "UltraLabel20"
        Me.UltraLabel20.Size = New System.Drawing.Size(48, 14)
        Me.UltraLabel20.TabIndex = 177
        Me.UltraLabel20.Text = "Paciente"
        '
        'txt_IdCliente
        '
        Me.txt_IdCliente.Location = New System.Drawing.Point(134, 41)
        Me.txt_IdCliente.Name = "txt_IdCliente"
        Me.txt_IdCliente.Size = New System.Drawing.Size(37, 21)
        Me.txt_IdCliente.TabIndex = 175
        Me.txt_IdCliente.Visible = False
        '
        'UltraLabel4
        '
        Appearance48.BackColor = System.Drawing.Color.Transparent
        Appearance48.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel4.Appearance = Appearance48
        Me.UltraLabel4.AutoSize = True
        Me.UltraLabel4.Location = New System.Drawing.Point(312, 52)
        Me.UltraLabel4.Name = "UltraLabel4"
        Me.UltraLabel4.Size = New System.Drawing.Size(27, 14)
        Me.UltraLabel4.TabIndex = 172
        Me.UltraLabel4.Text = "H.C."
        '
        'txt_idHistoria
        '
        Me.txt_idHistoria.Location = New System.Drawing.Point(342, 48)
        Me.txt_idHistoria.Name = "txt_idHistoria"
        Me.txt_idHistoria.ReadOnly = True
        Me.txt_idHistoria.Size = New System.Drawing.Size(129, 21)
        Me.txt_idHistoria.TabIndex = 171
        '
        'txt_IdCuenta
        '
        Appearance8.ImageHAlign = Infragistics.Win.HAlign.Center
        Appearance8.ImageVAlign = Infragistics.Win.VAlign.Middle
        EditorButton2.Appearance = Appearance8
        EditorButton2.Key = "ayuda"
        Me.txt_IdCuenta.ButtonsRight.Add(EditorButton2)
        Me.txt_IdCuenta.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_IdCuenta.Location = New System.Drawing.Point(89, 20)
        Me.txt_IdCuenta.MaxLength = 11
        Me.txt_IdCuenta.Name = "txt_IdCuenta"
        Me.txt_IdCuenta.Size = New System.Drawing.Size(150, 23)
        Me.txt_IdCuenta.TabIndex = 1
        '
        'uce_Medico
        '
        Me.uce_Medico.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend
        Me.uce_Medico.Location = New System.Drawing.Point(544, 75)
        Me.uce_Medico.Name = "uce_Medico"
        Me.uce_Medico.Size = New System.Drawing.Size(303, 21)
        Me.uce_Medico.TabIndex = 13
        '
        'udte_fecha
        '
        Me.udte_fecha.DateTime = New Date(2014, 1, 28, 0, 0, 0, 0)
        Me.udte_fecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.udte_fecha.Location = New System.Drawing.Point(560, 20)
        Me.udte_fecha.Name = "udte_fecha"
        Me.udte_fecha.ReadOnly = True
        Me.udte_fecha.Size = New System.Drawing.Size(114, 24)
        Me.udte_fecha.TabIndex = 5
        Me.udte_fecha.Value = New Date(2014, 1, 28, 0, 0, 0, 0)
        '
        'uchk_GenerarCta
        '
        Appearance7.ForeColor = System.Drawing.Color.Navy
        Me.uchk_GenerarCta.Appearance = Appearance7
        Me.uchk_GenerarCta.BackColor = System.Drawing.Color.Transparent
        Me.uchk_GenerarCta.BackColorInternal = System.Drawing.Color.Transparent
        Me.uchk_GenerarCta.Location = New System.Drawing.Point(21, 22)
        Me.uchk_GenerarCta.Name = "uchk_GenerarCta"
        Me.uchk_GenerarCta.Size = New System.Drawing.Size(75, 17)
        Me.uchk_GenerarCta.TabIndex = 0
        Me.uchk_GenerarCta.Text = "Cuenta"
        '
        'UltraLabel6
        '
        Appearance49.BackColor = System.Drawing.Color.Transparent
        Appearance49.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel6.Appearance = Appearance49
        Me.UltraLabel6.AutoSize = True
        Me.UltraLabel6.Location = New System.Drawing.Point(497, 79)
        Me.UltraLabel6.Name = "UltraLabel6"
        Me.UltraLabel6.Size = New System.Drawing.Size(41, 14)
        Me.UltraLabel6.TabIndex = 36
        Me.UltraLabel6.Text = "Médico"
        '
        'UltraLabel1
        '
        Appearance50.BackColor = System.Drawing.Color.Transparent
        Appearance50.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel1.Appearance = Appearance50
        Me.UltraLabel1.AutoSize = True
        Me.UltraLabel1.Location = New System.Drawing.Point(495, 26)
        Me.UltraLabel1.Name = "UltraLabel1"
        Me.UltraLabel1.Size = New System.Drawing.Size(63, 14)
        Me.UltraLabel1.TabIndex = 29
        Me.UltraLabel1.Text = "Fecha Reg."
        '
        'txt_idPreFactura
        '
        Me.txt_idPreFactura.Location = New System.Drawing.Point(14, 10)
        Me.txt_idPreFactura.Name = "txt_idPreFactura"
        Me.txt_idPreFactura.ReadOnly = True
        Me.txt_idPreFactura.Size = New System.Drawing.Size(47, 21)
        Me.txt_idPreFactura.TabIndex = 178
        Me.txt_idPreFactura.Visible = False
        '
        'utc_Datos
        '
        Me.utc_Datos.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.utc_Datos.Controls.Add(Me.UltraTabSharedControlsPage1)
        Me.utc_Datos.Controls.Add(Me.UltraTabPageControl1)
        Me.utc_Datos.Controls.Add(Me.UltraTabPageControl2)
        Me.utc_Datos.Location = New System.Drawing.Point(0, 28)
        Me.utc_Datos.Name = "utc_Datos"
        Me.utc_Datos.SharedControlsPage = Me.UltraTabSharedControlsPage1
        Me.utc_Datos.Size = New System.Drawing.Size(871, 290)
        Me.utc_Datos.TabIndex = 185
        UltraTab1.TabPage = Me.UltraTabPageControl1
        UltraTab1.Text = "Lista de Datos"
        UltraTab2.TabPage = Me.UltraTabPageControl2
        UltraTab2.Text = "Ingreso / Edicion de Datos"
        Me.utc_Datos.Tabs.AddRange(New Infragistics.Win.UltraWinTabControl.UltraTab() {UltraTab1, UltraTab2})
        '
        'UltraTabSharedControlsPage1
        '
        Me.UltraTabSharedControlsPage1.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabSharedControlsPage1.Name = "UltraTabSharedControlsPage1"
        Me.UltraTabSharedControlsPage1.Size = New System.Drawing.Size(867, 264)
        '
        'UltraTabPageControl1
        '
        Me.UltraTabPageControl1.Controls.Add(Me.ug_Lista)
        Me.UltraTabPageControl1.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl1.Name = "UltraTabPageControl1"
        Me.UltraTabPageControl1.Size = New System.Drawing.Size(867, 264)
        '
        'ug_Lista
        '
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
        Me.ug_Lista.Size = New System.Drawing.Size(867, 264)
        Me.ug_Lista.TabIndex = 0
        Me.ug_Lista.Text = "UltraGrid1"
        '
        'UltraTabPageControl2
        '
        Me.UltraTabPageControl2.Controls.Add(Me.ugb_Datos)
        Me.UltraTabPageControl2.Location = New System.Drawing.Point(1, 23)
        Me.UltraTabPageControl2.Name = "UltraTabPageControl2"
        Me.UltraTabPageControl2.Size = New System.Drawing.Size(867, 264)
        '
        'AD_PR_PreFacturacion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(872, 320)
        Me.Controls.Add(Me.utc_Datos)
        Me.Controls.Add(Me.ToolS_Mantenimiento)
        Me.Name = "AD_PR_PreFacturacion"
        Me.Text = "Crear Cuenta"
        Me.ToolS_Mantenimiento.ResumeLayout(False)
        Me.ToolS_Mantenimiento.PerformLayout()
        CType(Me.ugb_Datos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ugb_Datos.ResumeLayout(False)
        Me.ugb_Datos.PerformLayout()
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
        CType(Me.ucbo_Estado, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ucm_Tipo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.uce_tip_doc, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_Des_Cliente, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_ruc_cliente, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_IdCliente, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_idHistoria, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_IdCuenta, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.uce_Medico, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.udte_fecha, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_idPreFactura, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.utc_Datos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.utc_Datos.ResumeLayout(False)
        Me.UltraTabPageControl1.ResumeLayout(False)
        CType(Me.ug_Lista, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabPageControl2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolS_Mantenimiento As System.Windows.Forms.ToolStrip
    Friend WithEvents Tool_Nuevo As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents Tool_Grabar As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents Tool_Editar As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents Tool_Cancelar As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents Tool_Eliminar As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator5 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents Tool_Salir As System.Windows.Forms.ToolStripButton
    Friend WithEvents ugb_Datos As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents UltraLabel7 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents ucbo_Estado As Infragistics.Win.UltraWinEditors.UltraComboEditor
    Friend WithEvents UltraLabel21 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents ucm_Tipo As Infragistics.Win.UltraWinEditors.UltraComboEditor
    Friend WithEvents uce_tip_doc As Infragistics.Win.UltraWinEditors.UltraComboEditor
    Friend WithEvents txt_Des_Cliente As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents txt_ruc_cliente As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents UltraLabel20 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents txt_IdCliente As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents UltraLabel4 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents txt_idHistoria As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents txt_IdCuenta As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Public WithEvents uce_Medico As Infragistics.Win.UltraWinEditors.UltraComboEditor
    Friend WithEvents udte_fecha As Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
    Friend WithEvents uchk_GenerarCta As Infragistics.Win.UltraWinEditors.UltraCheckEditor
    Friend WithEvents UltraLabel6 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel1 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents txt_idPreFactura As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents ucm_SeguroEps As Infragistics.Win.UltraWinEditors.UltraComboEditor
    Friend WithEvents uchk_SeguroEps As Infragistics.Win.UltraWinEditors.UltraCheckEditor
    Friend WithEvents ugb_Cuenta As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents UltraLabel2 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel17 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents txt_FijoC As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents txt_DesCobertura As Infragistics.Win.UltraWinEditors.UltraComboEditor
    Friend WithEvents TXT_TIPOAFILIACION As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents txt_FechaAutoriza As Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
    Friend WithEvents uckIngresoManual As Infragistics.Win.UltraWinEditors.UltraCheckEditor
    Friend WithEvents UltraLabel22 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel18 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents txt_EPS As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents UltraLabel19 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents txt_CodAutoriza As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents UltraLabel9 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel10 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel11 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel12 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents txt_PagoVariable As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents txt_PagoFijo As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents txt_CodAsegurado As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents utc_Datos As Infragistics.Win.UltraWinTabControl.UltraTabControl
    Friend WithEvents UltraTabSharedControlsPage1 As Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage
    Friend WithEvents UltraTabPageControl1 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents ug_Lista As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents UltraTabPageControl2 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
End Class
