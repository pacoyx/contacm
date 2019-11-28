<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CO_RP_LibCajaBancos
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
        Dim Appearance4 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance5 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance6 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance9 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance1 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance7 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraDataColumn1 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Sel")
        Dim UltraDataColumn2 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Cuenta")
        Dim UltraDataColumn3 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Descripcion")
        Dim UltraDataColumn4 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdCuenta")
        Dim Appearance8 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim ValueListItem1 As Infragistics.Win.ValueListItem = New Infragistics.Win.ValueListItem()
        Dim ValueListItem2 As Infragistics.Win.ValueListItem = New Infragistics.Win.ValueListItem()
        Dim UltraGridBand1 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1)
        Dim UltraGridColumn1 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Sel")
        Dim UltraGridColumn2 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Cuenta")
        Dim UltraGridColumn3 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Descripcion")
        Dim UltraGridColumn4 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdCuenta")
        Dim Appearance2 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Me.ugb_Opciones = New Infragistics.Win.Misc.UltraGroupBox()
        Me.uchk_SinFecha = New Infragistics.Win.UltraWinEditors.UltraCheckEditor()
        Me.uchk_Resumen = New Infragistics.Win.UltraWinEditors.UltraCheckEditor()
        Me.ugb_Datos = New Infragistics.Win.Misc.UltraGroupBox()
        Me.uce_Moneda = New Infragistics.Win.UltraWinEditors.UltraComboEditor()
        Me.UltraLabel2 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraLabel4 = New Infragistics.Win.Misc.UltraLabel()
        Me.uce_Mes = New Infragistics.Win.UltraWinEditors.UltraComboEditor()
        Me.UltraLabel1 = New Infragistics.Win.Misc.UltraLabel()
        Me.txt_Ayo = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.uchk_todos = New Infragistics.Win.UltraWinEditors.UltraCheckEditor()
        Me.lbl_mensaje = New Infragistics.Win.Misc.UltraLabel()
        Me.upb_Mayor = New Infragistics.Win.UltraWinProgressBar.UltraProgressBar()
        Me.uds_Cuentas = New Infragistics.Win.UltraWinDataSource.UltraDataSource(Me.components)
        Me.UltraGroupBox1 = New Infragistics.Win.Misc.UltraGroupBox()
        Me.uos_Formato = New Infragistics.Win.UltraWinEditors.UltraOptionSet()
        Me.ug_Cuentas = New Infragistics.Win.UltraWinGrid.UltraGrid()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.Tool_imprimir = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.Tool_salir = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        CType(Me.ugb_Opciones, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ugb_Opciones.SuspendLayout()
        CType(Me.ugb_Datos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ugb_Datos.SuspendLayout()
        CType(Me.uce_Moneda, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.uce_Mes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_Ayo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.uds_Cuentas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UltraGroupBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraGroupBox1.SuspendLayout()
        CType(Me.uos_Formato, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ug_Cuentas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ugb_Opciones
        '
        Me.ugb_Opciones.CaptionAlignment = Infragistics.Win.Misc.GroupBoxCaptionAlignment.Center
        Me.ugb_Opciones.Controls.Add(Me.uchk_SinFecha)
        Me.ugb_Opciones.Controls.Add(Me.uchk_Resumen)
        Me.ugb_Opciones.HeaderPosition = Infragistics.Win.Misc.GroupBoxHeaderPosition.TopOutsideBorder
        Me.ugb_Opciones.Location = New System.Drawing.Point(350, 36)
        Me.ugb_Opciones.Name = "ugb_Opciones"
        Me.ugb_Opciones.Size = New System.Drawing.Size(161, 110)
        Me.ugb_Opciones.TabIndex = 15
        Me.ugb_Opciones.Text = "Opciones"
        '
        'uchk_SinFecha
        '
        Appearance4.ForeColor = System.Drawing.Color.Navy
        Me.uchk_SinFecha.Appearance = Appearance4
        Me.uchk_SinFecha.BackColor = System.Drawing.Color.Transparent
        Me.uchk_SinFecha.BackColorInternal = System.Drawing.Color.Transparent
        Me.uchk_SinFecha.Location = New System.Drawing.Point(13, 61)
        Me.uchk_SinFecha.Name = "uchk_SinFecha"
        Me.uchk_SinFecha.Size = New System.Drawing.Size(148, 20)
        Me.uchk_SinFecha.TabIndex = 0
        Me.uchk_SinFecha.Text = "Sin Fecha de Impresion"
        '
        'uchk_Resumen
        '
        Appearance5.ForeColor = System.Drawing.Color.Navy
        Me.uchk_Resumen.Appearance = Appearance5
        Me.uchk_Resumen.BackColor = System.Drawing.Color.Transparent
        Me.uchk_Resumen.BackColorInternal = System.Drawing.Color.Transparent
        Me.uchk_Resumen.Location = New System.Drawing.Point(13, 40)
        Me.uchk_Resumen.Name = "uchk_Resumen"
        Me.uchk_Resumen.Size = New System.Drawing.Size(148, 20)
        Me.uchk_Resumen.TabIndex = 0
        Me.uchk_Resumen.Text = "Resumen"
        '
        'ugb_Datos
        '
        Me.ugb_Datos.CaptionAlignment = Infragistics.Win.Misc.GroupBoxCaptionAlignment.Center
        Me.ugb_Datos.Controls.Add(Me.uce_Moneda)
        Me.ugb_Datos.Controls.Add(Me.UltraLabel2)
        Me.ugb_Datos.Controls.Add(Me.UltraLabel4)
        Me.ugb_Datos.Controls.Add(Me.uce_Mes)
        Me.ugb_Datos.Controls.Add(Me.UltraLabel1)
        Me.ugb_Datos.Controls.Add(Me.txt_Ayo)
        Me.ugb_Datos.HeaderPosition = Infragistics.Win.Misc.GroupBoxHeaderPosition.TopOutsideBorder
        Me.ugb_Datos.Location = New System.Drawing.Point(12, 36)
        Me.ugb_Datos.Name = "ugb_Datos"
        Me.ugb_Datos.Size = New System.Drawing.Size(193, 110)
        Me.ugb_Datos.TabIndex = 14
        Me.ugb_Datos.Text = "Periodo"
        '
        'uce_Moneda
        '
        Me.uce_Moneda.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Suggest
        Me.uce_Moneda.DropDownListWidth = 200
        Me.uce_Moneda.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.uce_Moneda.Location = New System.Drawing.Point(63, 79)
        Me.uce_Moneda.Name = "uce_Moneda"
        Me.uce_Moneda.Size = New System.Drawing.Size(116, 21)
        Me.uce_Moneda.TabIndex = 196
        '
        'UltraLabel2
        '
        Appearance6.BackColor = System.Drawing.Color.Transparent
        Appearance6.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel2.Appearance = Appearance6
        Me.UltraLabel2.AutoSize = True
        Me.UltraLabel2.Location = New System.Drawing.Point(6, 83)
        Me.UltraLabel2.Name = "UltraLabel2"
        Me.UltraLabel2.Size = New System.Drawing.Size(51, 14)
        Me.UltraLabel2.TabIndex = 195
        Me.UltraLabel2.Text = "Moneda :"
        '
        'UltraLabel4
        '
        Appearance9.BackColor = System.Drawing.Color.Transparent
        Appearance9.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel4.Appearance = Appearance9
        Me.UltraLabel4.AutoSize = True
        Me.UltraLabel4.Location = New System.Drawing.Point(25, 56)
        Me.UltraLabel4.Name = "UltraLabel4"
        Me.UltraLabel4.Size = New System.Drawing.Size(32, 14)
        Me.UltraLabel4.TabIndex = 195
        Me.UltraLabel4.Text = "Mes :"
        '
        'uce_Mes
        '
        Me.uce_Mes.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.uce_Mes.Location = New System.Drawing.Point(63, 52)
        Me.uce_Mes.Name = "uce_Mes"
        Me.uce_Mes.Size = New System.Drawing.Size(116, 21)
        Me.uce_Mes.TabIndex = 1
        '
        'UltraLabel1
        '
        Appearance1.BackColor = System.Drawing.Color.Transparent
        Appearance1.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel1.Appearance = Appearance1
        Me.UltraLabel1.AutoSize = True
        Me.UltraLabel1.Location = New System.Drawing.Point(27, 29)
        Me.UltraLabel1.Name = "UltraLabel1"
        Me.UltraLabel1.Size = New System.Drawing.Size(30, 14)
        Me.UltraLabel1.TabIndex = 1
        Me.UltraLabel1.Text = "Año :"
        '
        'txt_Ayo
        '
        Me.txt_Ayo.Location = New System.Drawing.Point(63, 25)
        Me.txt_Ayo.Name = "txt_Ayo"
        Me.txt_Ayo.Size = New System.Drawing.Size(53, 21)
        Me.txt_Ayo.TabIndex = 0
        '
        'uchk_todos
        '
        Me.uchk_todos.Location = New System.Drawing.Point(12, 149)
        Me.uchk_todos.Name = "uchk_todos"
        Me.uchk_todos.Size = New System.Drawing.Size(120, 20)
        Me.uchk_todos.TabIndex = 17
        Me.uchk_todos.Text = "Todos"
        '
        'lbl_mensaje
        '
        Me.lbl_mensaje.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Appearance7.BackColor = System.Drawing.Color.Transparent
        Appearance7.ForeColor = System.Drawing.Color.Navy
        Me.lbl_mensaje.Appearance = Appearance7
        Me.lbl_mensaje.AutoSize = True
        Me.lbl_mensaje.Location = New System.Drawing.Point(12, 392)
        Me.lbl_mensaje.Name = "lbl_mensaje"
        Me.lbl_mensaje.Size = New System.Drawing.Size(39, 14)
        Me.lbl_mensaje.TabIndex = 200
        Me.lbl_mensaje.Text = "Cargar"
        '
        'upb_Mayor
        '
        Me.upb_Mayor.Location = New System.Drawing.Point(68, 392)
        Me.upb_Mayor.Name = "upb_Mayor"
        Me.upb_Mayor.Size = New System.Drawing.Size(443, 19)
        Me.upb_Mayor.TabIndex = 199
        Me.upb_Mayor.Text = "[Formatted]"
        Me.upb_Mayor.Visible = False
        '
        'uds_Cuentas
        '
        Me.uds_Cuentas.AllowDelete = False
        UltraDataColumn1.DataType = GetType(Boolean)
        UltraDataColumn1.DefaultValue = False
        UltraDataColumn3.ReadOnly = Infragistics.Win.DefaultableBoolean.[False]
        UltraDataColumn4.DataType = GetType(Integer)
        UltraDataColumn4.ReadOnly = Infragistics.Win.DefaultableBoolean.[False]
        Me.uds_Cuentas.Band.Columns.AddRange(New Object() {UltraDataColumn1, UltraDataColumn2, UltraDataColumn3, UltraDataColumn4})
        '
        'UltraGroupBox1
        '
        Me.UltraGroupBox1.CaptionAlignment = Infragistics.Win.Misc.GroupBoxCaptionAlignment.Center
        Me.UltraGroupBox1.Controls.Add(Me.uos_Formato)
        Me.UltraGroupBox1.HeaderPosition = Infragistics.Win.Misc.GroupBoxHeaderPosition.TopOutsideBorder
        Me.UltraGroupBox1.Location = New System.Drawing.Point(211, 36)
        Me.UltraGroupBox1.Name = "UltraGroupBox1"
        Me.UltraGroupBox1.Size = New System.Drawing.Size(133, 110)
        Me.UltraGroupBox1.TabIndex = 201
        Me.UltraGroupBox1.Text = "Formato"
        '
        'uos_Formato
        '
        Appearance8.ForeColor = System.Drawing.Color.Navy
        Me.uos_Formato.Appearance = Appearance8
        Me.uos_Formato.BackColor = System.Drawing.Color.Transparent
        Me.uos_Formato.BackColorInternal = System.Drawing.Color.Transparent
        Me.uos_Formato.BorderStyle = Infragistics.Win.UIElementBorderStyle.None
        Me.uos_Formato.CheckedIndex = 0
        ValueListItem1.DataValue = CType(2, Short)
        ValueListItem1.DisplayText = "Efectivo"
        ValueListItem2.DataValue = CType(3, Short)
        ValueListItem2.DisplayText = "Cuenta Corriente"
        Me.uos_Formato.Items.AddRange(New Infragistics.Win.ValueListItem() {ValueListItem1, ValueListItem2})
        Me.uos_Formato.ItemSpacingHorizontal = 10
        Me.uos_Formato.ItemSpacingVertical = 5
        Me.uos_Formato.Location = New System.Drawing.Point(15, 41)
        Me.uos_Formato.Name = "uos_Formato"
        Me.uos_Formato.Size = New System.Drawing.Size(112, 46)
        Me.uos_Formato.TabIndex = 0
        Me.uos_Formato.Text = "Efectivo"
        '
        'ug_Cuentas
        '
        Me.ug_Cuentas.DataSource = Me.uds_Cuentas
        Me.ug_Cuentas.DisplayLayout.AutoFitStyle = Infragistics.Win.UltraWinGrid.AutoFitStyle.ExtendLastColumn
        UltraGridColumn1.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn1.Header.VisiblePosition = 0
        UltraGridColumn1.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.CheckBox
        UltraGridColumn2.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn2.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn2.Header.VisiblePosition = 1
        UltraGridColumn3.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn3.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn3.Header.VisiblePosition = 2
        UltraGridColumn4.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn4.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn4.Header.VisiblePosition = 3
        UltraGridColumn4.Hidden = True
        UltraGridBand1.Columns.AddRange(New Object() {UltraGridColumn1, UltraGridColumn2, UltraGridColumn3, UltraGridColumn4})
        Me.ug_Cuentas.DisplayLayout.BandsSerializer.Add(UltraGridBand1)
        Me.ug_Cuentas.DisplayLayout.MaxColScrollRegions = 1
        Me.ug_Cuentas.DisplayLayout.MaxRowScrollRegions = 1
        Appearance2.BackColor = System.Drawing.Color.WhiteSmoke
        Appearance2.BackColor2 = System.Drawing.Color.WhiteSmoke
        Me.ug_Cuentas.DisplayLayout.Override.RowAlternateAppearance = Appearance2
        Me.ug_Cuentas.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.ug_Cuentas.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.ug_Cuentas.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ug_Cuentas.Location = New System.Drawing.Point(12, 174)
        Me.ug_Cuentas.Name = "ug_Cuentas"
        Me.ug_Cuentas.Size = New System.Drawing.Size(499, 212)
        Me.ug_Cuentas.TabIndex = 202
        '
        'ToolStrip1
        '
        Me.ToolStrip1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Tool_imprimir, Me.ToolStripSeparator2, Me.Tool_salir, Me.ToolStripSeparator1})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(520, 25)
        Me.ToolStrip1.TabIndex = 203
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'Tool_imprimir
        '
        Me.Tool_imprimir.Image = Global.Contabilidad.My.Resources.Resources._004
        Me.Tool_imprimir.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Tool_imprimir.Name = "Tool_imprimir"
        Me.Tool_imprimir.Size = New System.Drawing.Size(73, 22)
        Me.Tool_imprimir.Text = "Imprimir"
        Me.Tool_imprimir.ToolTipText = "Imprimir"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'Tool_salir
        '
        Me.Tool_salir.Image = Global.Contabilidad.My.Resources.Resources._28
        Me.Tool_salir.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Tool_salir.Name = "Tool_salir"
        Me.Tool_salir.Size = New System.Drawing.Size(49, 22)
        Me.Tool_salir.Text = "Salir"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'CO_RP_LibCajaBancos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(520, 419)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.ug_Cuentas)
        Me.Controls.Add(Me.UltraGroupBox1)
        Me.Controls.Add(Me.lbl_mensaje)
        Me.Controls.Add(Me.upb_Mayor)
        Me.Controls.Add(Me.uchk_todos)
        Me.Controls.Add(Me.ugb_Opciones)
        Me.Controls.Add(Me.ugb_Datos)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "CO_RP_LibCajaBancos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Libro Caja y Bancos"
        CType(Me.ugb_Opciones, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ugb_Opciones.ResumeLayout(False)
        CType(Me.ugb_Datos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ugb_Datos.ResumeLayout(False)
        Me.ugb_Datos.PerformLayout()
        CType(Me.uce_Moneda, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.uce_Mes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_Ayo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.uds_Cuentas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UltraGroupBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraGroupBox1.ResumeLayout(False)
        CType(Me.uos_Formato, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ug_Cuentas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ugb_Opciones As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents uchk_SinFecha As Infragistics.Win.UltraWinEditors.UltraCheckEditor
    Friend WithEvents uchk_Resumen As Infragistics.Win.UltraWinEditors.UltraCheckEditor
    Friend WithEvents ugb_Datos As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents UltraLabel4 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents uce_Mes As Infragistics.Win.UltraWinEditors.UltraComboEditor
    Friend WithEvents UltraLabel1 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents txt_Ayo As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents uchk_todos As Infragistics.Win.UltraWinEditors.UltraCheckEditor
    Friend WithEvents lbl_mensaje As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents upb_Mayor As Infragistics.Win.UltraWinProgressBar.UltraProgressBar
    Friend WithEvents uds_Cuentas As Infragistics.Win.UltraWinDataSource.UltraDataSource
    Friend WithEvents UltraGroupBox1 As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents uos_Formato As Infragistics.Win.UltraWinEditors.UltraOptionSet
    Friend WithEvents ug_Cuentas As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents UltraLabel2 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents uce_Moneda As Infragistics.Win.UltraWinEditors.UltraComboEditor
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents Tool_imprimir As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents Tool_salir As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
End Class
