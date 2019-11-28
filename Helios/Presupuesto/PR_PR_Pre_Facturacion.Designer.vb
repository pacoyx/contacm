<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PR_PR_Pre_Facturacion
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
        Dim Appearance35 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance28 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim ValueListItem5 As Infragistics.Win.ValueListItem = New Infragistics.Win.ValueListItem()
        Dim ValueListItem6 As Infragistics.Win.ValueListItem = New Infragistics.Win.ValueListItem()
        Dim Appearance4 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim EditorButton1 As Infragistics.Win.UltraWinEditors.EditorButton = New Infragistics.Win.UltraWinEditors.EditorButton("ayuda")
        Dim Appearance2 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance40 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance12 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim EditorButton2 As Infragistics.Win.UltraWinEditors.EditorButton = New Infragistics.Win.UltraWinEditors.EditorButton("ayuda")
        Dim Appearance25 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance18 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance27 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance41 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance45 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Me.ugb_Datos = New Infragistics.Win.Misc.UltraGroupBox()
        Me.uce_Tratamiento = New Infragistics.Win.UltraWinEditors.UltraComboEditor()
        Me.UltraLabel15 = New Infragistics.Win.Misc.UltraLabel()
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
        Me.UltraLabel2 = New Infragistics.Win.Misc.UltraLabel()
        Me.udte_fecha = New Infragistics.Win.UltraWinEditors.UltraDateTimeEditor()
        Me.uchk_GenerarCta = New Infragistics.Win.UltraWinEditors.UltraCheckEditor()
        Me.UltraLabel6 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraLabel1 = New Infragistics.Win.Misc.UltraLabel()
        Me.txt_idPreFactura = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.utc_Datos = New Infragistics.Win.UltraWinTabControl.UltraTabControl()
        Me.UltraTabSharedControlsPage1 = New Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage()
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
        CType(Me.ugb_Datos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ugb_Datos.SuspendLayout()
        CType(Me.uce_Tratamiento, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.ToolS_Mantenimiento.SuspendLayout()
        Me.SuspendLayout()
        '
        'ugb_Datos
        '
        Me.ugb_Datos.Controls.Add(Me.uce_Tratamiento)
        Me.ugb_Datos.Controls.Add(Me.UltraLabel15)
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
        Me.ugb_Datos.Controls.Add(Me.UltraLabel2)
        Me.ugb_Datos.Controls.Add(Me.udte_fecha)
        Me.ugb_Datos.Controls.Add(Me.uchk_GenerarCta)
        Me.ugb_Datos.Controls.Add(Me.UltraLabel6)
        Me.ugb_Datos.Controls.Add(Me.UltraLabel1)
        Me.ugb_Datos.Controls.Add(Me.txt_idPreFactura)
        Me.ugb_Datos.Location = New System.Drawing.Point(3, 27)
        Me.ugb_Datos.Name = "ugb_Datos"
        Me.ugb_Datos.Size = New System.Drawing.Size(527, 244)
        Me.ugb_Datos.TabIndex = 33
        '
        'uce_Tratamiento
        '
        Me.uce_Tratamiento.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Suggest
        Me.uce_Tratamiento.Location = New System.Drawing.Point(96, 169)
        Me.uce_Tratamiento.Name = "uce_Tratamiento"
        Me.uce_Tratamiento.Size = New System.Drawing.Size(395, 21)
        Me.uce_Tratamiento.TabIndex = 189
        '
        'UltraLabel15
        '
        Appearance35.BackColor = System.Drawing.Color.Transparent
        Appearance35.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel15.Appearance = Appearance35
        Me.UltraLabel15.AutoSize = True
        Me.UltraLabel15.Location = New System.Drawing.Point(20, 174)
        Me.UltraLabel15.Name = "UltraLabel15"
        Me.UltraLabel15.Size = New System.Drawing.Size(65, 14)
        Me.UltraLabel15.TabIndex = 187
        Me.UltraLabel15.Text = "Tratamiento"
        '
        'UltraLabel7
        '
        Appearance28.BackColor = System.Drawing.Color.Transparent
        Appearance28.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel7.Appearance = Appearance28
        Me.UltraLabel7.AutoSize = True
        Me.UltraLabel7.Location = New System.Drawing.Point(275, 81)
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
        Me.ucbo_Estado.Location = New System.Drawing.Point(320, 77)
        Me.ucbo_Estado.Name = "ucbo_Estado"
        Me.ucbo_Estado.ReadOnly = True
        Me.ucbo_Estado.Size = New System.Drawing.Size(171, 21)
        Me.ucbo_Estado.TabIndex = 7
        '
        'UltraLabel21
        '
        Appearance4.BackColor = System.Drawing.Color.Transparent
        Appearance4.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel21.Appearance = Appearance4
        Me.UltraLabel21.AutoSize = True
        Me.UltraLabel21.Location = New System.Drawing.Point(20, 81)
        Me.UltraLabel21.Name = "UltraLabel21"
        Me.UltraLabel21.Size = New System.Drawing.Size(73, 14)
        Me.UltraLabel21.TabIndex = 154
        Me.UltraLabel21.Text = "Tipo Atención"
        '
        'ucm_Tipo
        '
        Me.ucm_Tipo.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.ucm_Tipo.Location = New System.Drawing.Point(96, 77)
        Me.ucm_Tipo.Name = "ucm_Tipo"
        Me.ucm_Tipo.ReadOnly = True
        Me.ucm_Tipo.Size = New System.Drawing.Size(150, 21)
        Me.ucm_Tipo.TabIndex = 6
        '
        'uce_tip_doc
        '
        Me.uce_tip_doc.DropDownListWidth = 300
        Me.uce_tip_doc.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.uce_tip_doc.Location = New System.Drawing.Point(96, 112)
        Me.uce_tip_doc.Name = "uce_tip_doc"
        Me.uce_tip_doc.Size = New System.Drawing.Size(63, 21)
        Me.uce_tip_doc.TabIndex = 173
        '
        'txt_Des_Cliente
        '
        Me.txt_Des_Cliente.Location = New System.Drawing.Point(96, 136)
        Me.txt_Des_Cliente.Name = "txt_Des_Cliente"
        Me.txt_Des_Cliente.ReadOnly = True
        Me.txt_Des_Cliente.Size = New System.Drawing.Size(395, 21)
        Me.txt_Des_Cliente.TabIndex = 176
        '
        'txt_ruc_cliente
        '
        Appearance2.ImageHAlign = Infragistics.Win.HAlign.Center
        Appearance2.ImageVAlign = Infragistics.Win.VAlign.Middle
        EditorButton1.Appearance = Appearance2
        EditorButton1.Key = "ayuda"
        Me.txt_ruc_cliente.ButtonsRight.Add(EditorButton1)
        Me.txt_ruc_cliente.Location = New System.Drawing.Point(159, 112)
        Me.txt_ruc_cliente.MaxLength = 11
        Me.txt_ruc_cliente.Name = "txt_ruc_cliente"
        Me.txt_ruc_cliente.Size = New System.Drawing.Size(155, 21)
        Me.txt_ruc_cliente.TabIndex = 174
        '
        'UltraLabel20
        '
        Appearance40.BackColor = System.Drawing.Color.Transparent
        Appearance40.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel20.Appearance = Appearance40
        Me.UltraLabel20.AutoSize = True
        Me.UltraLabel20.Location = New System.Drawing.Point(20, 116)
        Me.UltraLabel20.Name = "UltraLabel20"
        Me.UltraLabel20.Size = New System.Drawing.Size(48, 14)
        Me.UltraLabel20.TabIndex = 177
        Me.UltraLabel20.Text = "Paciente"
        '
        'txt_IdCliente
        '
        Me.txt_IdCliente.Location = New System.Drawing.Point(141, 105)
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
        Me.UltraLabel4.Location = New System.Drawing.Point(329, 114)
        Me.UltraLabel4.Name = "UltraLabel4"
        Me.UltraLabel4.Size = New System.Drawing.Size(27, 14)
        Me.UltraLabel4.TabIndex = 172
        Me.UltraLabel4.Text = "H.C."
        '
        'txt_idHistoria
        '
        Me.txt_idHistoria.Location = New System.Drawing.Point(362, 112)
        Me.txt_idHistoria.Name = "txt_idHistoria"
        Me.txt_idHistoria.ReadOnly = True
        Me.txt_idHistoria.Size = New System.Drawing.Size(129, 21)
        Me.txt_idHistoria.TabIndex = 171
        '
        'txt_IdCuenta
        '
        Appearance25.ImageHAlign = Infragistics.Win.HAlign.Center
        Appearance25.ImageVAlign = Infragistics.Win.VAlign.Middle
        EditorButton2.Appearance = Appearance25
        EditorButton2.Key = "ayuda"
        Me.txt_IdCuenta.ButtonsRight.Add(EditorButton2)
        Me.txt_IdCuenta.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_IdCuenta.Location = New System.Drawing.Point(96, 46)
        Me.txt_IdCuenta.MaxLength = 11
        Me.txt_IdCuenta.Name = "txt_IdCuenta"
        Me.txt_IdCuenta.Size = New System.Drawing.Size(150, 23)
        Me.txt_IdCuenta.TabIndex = 1
        '
        'uce_Medico
        '
        Me.uce_Medico.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend
        Me.uce_Medico.Location = New System.Drawing.Point(96, 201)
        Me.uce_Medico.Name = "uce_Medico"
        Me.uce_Medico.Size = New System.Drawing.Size(395, 21)
        Me.uce_Medico.TabIndex = 13
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
        Me.UltraLabel2.Size = New System.Drawing.Size(523, 28)
        Me.UltraLabel2.TabIndex = 27
        Me.UltraLabel2.Text = "Pre-Facturación"
        '
        'udte_fecha
        '
        Me.udte_fecha.DateTime = New Date(2014, 1, 28, 0, 0, 0, 0)
        Me.udte_fecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.udte_fecha.Location = New System.Drawing.Point(362, 44)
        Me.udte_fecha.Name = "udte_fecha"
        Me.udte_fecha.ReadOnly = True
        Me.udte_fecha.Size = New System.Drawing.Size(129, 24)
        Me.udte_fecha.TabIndex = 5
        Me.udte_fecha.Value = New Date(2014, 1, 28, 0, 0, 0, 0)
        '
        'uchk_GenerarCta
        '
        Appearance27.ForeColor = System.Drawing.Color.Navy
        Me.uchk_GenerarCta.Appearance = Appearance27
        Me.uchk_GenerarCta.BackColor = System.Drawing.Color.Transparent
        Me.uchk_GenerarCta.BackColorInternal = System.Drawing.Color.Transparent
        Me.uchk_GenerarCta.Location = New System.Drawing.Point(20, 48)
        Me.uchk_GenerarCta.Name = "uchk_GenerarCta"
        Me.uchk_GenerarCta.Size = New System.Drawing.Size(75, 17)
        Me.uchk_GenerarCta.TabIndex = 0
        Me.uchk_GenerarCta.Text = "Cuenta"
        '
        'UltraLabel6
        '
        Appearance41.BackColor = System.Drawing.Color.Transparent
        Appearance41.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel6.Appearance = Appearance41
        Me.UltraLabel6.AutoSize = True
        Me.UltraLabel6.Location = New System.Drawing.Point(20, 205)
        Me.UltraLabel6.Name = "UltraLabel6"
        Me.UltraLabel6.Size = New System.Drawing.Size(41, 14)
        Me.UltraLabel6.TabIndex = 36
        Me.UltraLabel6.Text = "Médico"
        '
        'UltraLabel1
        '
        Appearance45.BackColor = System.Drawing.Color.Transparent
        Appearance45.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel1.Appearance = Appearance45
        Me.UltraLabel1.AutoSize = True
        Me.UltraLabel1.Location = New System.Drawing.Point(275, 50)
        Me.UltraLabel1.Name = "UltraLabel1"
        Me.UltraLabel1.Size = New System.Drawing.Size(63, 14)
        Me.UltraLabel1.TabIndex = 29
        Me.UltraLabel1.Text = "Fecha Reg."
        '
        'txt_idPreFactura
        '
        Me.txt_idPreFactura.Location = New System.Drawing.Point(13, 36)
        Me.txt_idPreFactura.Name = "txt_idPreFactura"
        Me.txt_idPreFactura.ReadOnly = True
        Me.txt_idPreFactura.Size = New System.Drawing.Size(47, 21)
        Me.txt_idPreFactura.TabIndex = 178
        Me.txt_idPreFactura.Visible = False
        '
        'utc_Datos
        '
        Me.utc_Datos.Location = New System.Drawing.Point(0, 0)
        Me.utc_Datos.Name = "utc_Datos"
        Me.utc_Datos.SharedControlsPage = Me.UltraTabSharedControlsPage1
        Me.utc_Datos.Size = New System.Drawing.Size(200, 100)
        Me.utc_Datos.TabIndex = 0
        '
        'UltraTabSharedControlsPage1
        '
        Me.UltraTabSharedControlsPage1.Location = New System.Drawing.Point(1, 20)
        Me.UltraTabSharedControlsPage1.Name = "UltraTabSharedControlsPage1"
        Me.UltraTabSharedControlsPage1.Size = New System.Drawing.Size(196, 77)
        '
        'ToolS_Mantenimiento
        '
        Me.ToolS_Mantenimiento.BackColor = System.Drawing.Color.White
        Me.ToolS_Mantenimiento.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Tool_Nuevo, Me.ToolStripSeparator1, Me.Tool_Grabar, Me.ToolStripSeparator4, Me.Tool_Editar, Me.ToolStripSeparator3, Me.Tool_Cancelar, Me.ToolStripSeparator2, Me.Tool_Eliminar, Me.ToolStripSeparator5, Me.Tool_Salir})
        Me.ToolS_Mantenimiento.Location = New System.Drawing.Point(0, 0)
        Me.ToolS_Mantenimiento.Name = "ToolS_Mantenimiento"
        Me.ToolS_Mantenimiento.Size = New System.Drawing.Size(535, 25)
        Me.ToolS_Mantenimiento.TabIndex = 138
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
        'PR_PR_Pre_Facturacion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(535, 274)
        Me.Controls.Add(Me.ToolS_Mantenimiento)
        Me.Controls.Add(Me.ugb_Datos)
        Me.Name = "PR_PR_Pre_Facturacion"
        Me.Text = "Pre-Facturación"
        CType(Me.ugb_Datos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ugb_Datos.ResumeLayout(False)
        Me.ugb_Datos.PerformLayout()
        CType(Me.uce_Tratamiento, System.ComponentModel.ISupportInitialize).EndInit()
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
        Me.ToolS_Mantenimiento.ResumeLayout(False)
        Me.ToolS_Mantenimiento.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ugb_Datos As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents UltraLabel6 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel1 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel2 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents uchk_GenerarCta As Infragistics.Win.UltraWinEditors.UltraCheckEditor
    Friend WithEvents udte_fecha As Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
    Friend WithEvents ucm_Tipo As Infragistics.Win.UltraWinEditors.UltraComboEditor
    Friend WithEvents UltraLabel21 As Infragistics.Win.Misc.UltraLabel
    Public WithEvents uce_Medico As Infragistics.Win.UltraWinEditors.UltraComboEditor
    Friend WithEvents txt_IdCuenta As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents uce_tip_doc As Infragistics.Win.UltraWinEditors.UltraComboEditor
    Friend WithEvents txt_Des_Cliente As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents txt_ruc_cliente As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents UltraLabel20 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents txt_IdCliente As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents UltraLabel4 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents txt_idHistoria As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents txt_idPreFactura As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents UltraLabel7 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents ucbo_Estado As Infragistics.Win.UltraWinEditors.UltraComboEditor
    Friend WithEvents utc_Datos As Infragistics.Win.UltraWinTabControl.UltraTabControl
    Friend WithEvents UltraTabSharedControlsPage1 As Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage
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
    Friend WithEvents UltraLabel15 As Infragistics.Win.Misc.UltraLabel
    Public WithEvents uce_Tratamiento As Infragistics.Win.UltraWinEditors.UltraComboEditor
End Class
