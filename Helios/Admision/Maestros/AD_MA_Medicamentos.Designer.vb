<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AD_MA_Medicamentos
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
        Dim UltraGridColumn1 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ME_ID")
        Dim UltraGridColumn2 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ME_DESCRIPCION")
        Dim UltraGridColumn3 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ME_IDCAT")
        Dim UltraGridColumn4 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CM_DESCRIPCION")
        Dim UltraGridColumn5 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ME_COMPO_GENE")
        Dim UltraGridColumn6 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ME_PRESENTACION")
        Dim UltraGridColumn7 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ME_IDARTICULO")
        Dim UltraDataColumn1 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("ME_ID")
        Dim UltraDataColumn2 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("ME_DESCRIPCION")
        Dim UltraDataColumn3 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("ME_IDCAT")
        Dim UltraDataColumn4 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("CM_DESCRIPCION")
        Dim UltraDataColumn5 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("ME_COMPO_GENE")
        Dim UltraDataColumn6 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("ME_PRESENTACION")
        Dim UltraDataColumn7 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("ME_IDARTICULO")
        Dim Appearance2 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance5 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance6 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance1 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance16 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraTab1 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraTab2 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Me.UltraTabPageControl1 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.ug_medicamentos = New Infragistics.Win.UltraWinGrid.UltraGrid()
        Me.uds_listaMedica = New Infragistics.Win.UltraWinDataSource.UltraDataSource(Me.components)
        Me.UltraTabPageControl2 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.ugb_datos = New Infragistics.Win.Misc.UltraGroupBox()
        Me.cb_presentacion = New System.Windows.Forms.ComboBox()
        Me.cb_categoria = New System.Windows.Forms.ComboBox()
        Me.UltraLabel3 = New Infragistics.Win.Misc.UltraLabel()
        Me.txt_Descripcion = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.txt_compo_gene = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.UltraLabel2 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraLabel5 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraLabel1 = New Infragistics.Win.Misc.UltraLabel()
        Me.txt_id = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.UltraLabel4 = New Infragistics.Win.Misc.UltraLabel()
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
        Me.utc_medicamentos = New Infragistics.Win.UltraWinTabControl.UltraTabControl()
        Me.UltraTabSharedControlsPage1 = New Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage()
        Me.UltraTabPageControl1.SuspendLayout()
        CType(Me.ug_medicamentos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.uds_listaMedica, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabPageControl2.SuspendLayout()
        CType(Me.ugb_datos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ugb_datos.SuspendLayout()
        CType(Me.txt_Descripcion, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_compo_gene, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_id, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolS_Mantenimiento.SuspendLayout()
        CType(Me.utc_medicamentos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.utc_medicamentos.SuspendLayout()
        Me.SuspendLayout()
        '
        'UltraTabPageControl1
        '
        Me.UltraTabPageControl1.Controls.Add(Me.ug_medicamentos)
        Me.UltraTabPageControl1.Location = New System.Drawing.Point(1, 23)
        Me.UltraTabPageControl1.Name = "UltraTabPageControl1"
        Me.UltraTabPageControl1.Size = New System.Drawing.Size(711, 370)
        '
        'ug_medicamentos
        '
        Me.ug_medicamentos.DataSource = Me.uds_listaMedica
        Me.ug_medicamentos.DisplayLayout.AutoFitStyle = Infragistics.Win.UltraWinGrid.AutoFitStyle.ExtendLastColumn
        UltraGridColumn1.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn1.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn1.Header.Caption = "Codigo"
        UltraGridColumn1.Header.VisiblePosition = 0
        UltraGridColumn2.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn2.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn2.Header.Caption = "Descripcion"
        UltraGridColumn2.Header.VisiblePosition = 1
        UltraGridColumn2.Width = 239
        UltraGridColumn3.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn3.Header.VisiblePosition = 2
        UltraGridColumn3.Hidden = True
        UltraGridColumn4.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn4.Header.Caption = "DESCRIPCIÓN"
        UltraGridColumn4.Header.VisiblePosition = 3
        UltraGridColumn4.Hidden = True
        UltraGridColumn4.Width = 95
        UltraGridColumn5.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn5.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn5.Header.Caption = "Composicion Generica"
        UltraGridColumn5.Header.VisiblePosition = 5
        UltraGridColumn5.Width = 194
        UltraGridColumn6.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn6.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn6.Header.Caption = "Presentacion"
        UltraGridColumn6.Header.VisiblePosition = 4
        UltraGridColumn6.Width = 123
        UltraGridColumn7.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn7.Header.VisiblePosition = 6
        UltraGridColumn7.Hidden = True
        UltraGridBand1.Columns.AddRange(New Object() {UltraGridColumn1, UltraGridColumn2, UltraGridColumn3, UltraGridColumn4, UltraGridColumn5, UltraGridColumn6, UltraGridColumn7})
        Me.ug_medicamentos.DisplayLayout.BandsSerializer.Add(UltraGridBand1)
        Me.ug_medicamentos.DisplayLayout.MaxColScrollRegions = 1
        Me.ug_medicamentos.DisplayLayout.MaxRowScrollRegions = 1
        Me.ug_medicamentos.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.ug_medicamentos.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.ug_medicamentos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ug_medicamentos.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ug_medicamentos.Location = New System.Drawing.Point(0, 0)
        Me.ug_medicamentos.Name = "ug_medicamentos"
        Me.ug_medicamentos.Size = New System.Drawing.Size(711, 370)
        Me.ug_medicamentos.TabIndex = 0
        '
        'uds_listaMedica
        '
        Me.uds_listaMedica.AllowDelete = False
        UltraDataColumn1.DataType = GetType(Integer)
        UltraDataColumn3.DataType = GetType(Integer)
        UltraDataColumn7.DataType = GetType(Integer)
        Me.uds_listaMedica.Band.Columns.AddRange(New Object() {UltraDataColumn1, UltraDataColumn2, UltraDataColumn3, UltraDataColumn4, UltraDataColumn5, UltraDataColumn6, UltraDataColumn7})
        '
        'UltraTabPageControl2
        '
        Me.UltraTabPageControl2.Controls.Add(Me.ugb_datos)
        Me.UltraTabPageControl2.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl2.Name = "UltraTabPageControl2"
        Me.UltraTabPageControl2.Size = New System.Drawing.Size(711, 370)
        '
        'ugb_datos
        '
        Me.ugb_datos.Controls.Add(Me.cb_presentacion)
        Me.ugb_datos.Controls.Add(Me.cb_categoria)
        Me.ugb_datos.Controls.Add(Me.UltraLabel3)
        Me.ugb_datos.Controls.Add(Me.txt_Descripcion)
        Me.ugb_datos.Controls.Add(Me.txt_compo_gene)
        Me.ugb_datos.Controls.Add(Me.UltraLabel2)
        Me.ugb_datos.Controls.Add(Me.UltraLabel5)
        Me.ugb_datos.Controls.Add(Me.UltraLabel1)
        Me.ugb_datos.Controls.Add(Me.txt_id)
        Me.ugb_datos.Controls.Add(Me.UltraLabel4)
        Me.ugb_datos.Location = New System.Drawing.Point(11, 10)
        Me.ugb_datos.Name = "ugb_datos"
        Me.ugb_datos.Size = New System.Drawing.Size(691, 351)
        Me.ugb_datos.TabIndex = 0
        '
        'cb_presentacion
        '
        Me.cb_presentacion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cb_presentacion.FormattingEnabled = True
        Me.cb_presentacion.Location = New System.Drawing.Point(108, 187)
        Me.cb_presentacion.Name = "cb_presentacion"
        Me.cb_presentacion.Size = New System.Drawing.Size(188, 21)
        Me.cb_presentacion.TabIndex = 26
        '
        'cb_categoria
        '
        Me.cb_categoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cb_categoria.FormattingEnabled = True
        Me.cb_categoria.Location = New System.Drawing.Point(108, 154)
        Me.cb_categoria.Name = "cb_categoria"
        Me.cb_categoria.Size = New System.Drawing.Size(188, 21)
        Me.cb_categoria.TabIndex = 26
        '
        'UltraLabel3
        '
        Appearance2.BackColor = System.Drawing.Color.Transparent
        Appearance2.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel3.Appearance = Appearance2
        Me.UltraLabel3.AutoSize = True
        Me.UltraLabel3.Location = New System.Drawing.Point(25, 190)
        Me.UltraLabel3.Name = "UltraLabel3"
        Me.UltraLabel3.Size = New System.Drawing.Size(70, 14)
        Me.UltraLabel3.TabIndex = 25
        Me.UltraLabel3.Text = "Presentación"
        '
        'txt_Descripcion
        '
        Me.txt_Descripcion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_Descripcion.Location = New System.Drawing.Point(108, 51)
        Me.txt_Descripcion.MaxLength = 200
        Me.txt_Descripcion.Name = "txt_Descripcion"
        Me.txt_Descripcion.Size = New System.Drawing.Size(400, 21)
        Me.txt_Descripcion.TabIndex = 2
        '
        'txt_compo_gene
        '
        Me.txt_compo_gene.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_compo_gene.Location = New System.Drawing.Point(108, 91)
        Me.txt_compo_gene.MaxLength = 200
        Me.txt_compo_gene.Name = "txt_compo_gene"
        Me.txt_compo_gene.Size = New System.Drawing.Size(266, 21)
        Me.txt_compo_gene.TabIndex = 1
        '
        'UltraLabel2
        '
        Appearance5.BackColor = System.Drawing.Color.Transparent
        Appearance5.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel2.Appearance = Appearance5
        Me.UltraLabel2.AutoSize = True
        Me.UltraLabel2.Location = New System.Drawing.Point(25, 58)
        Me.UltraLabel2.Name = "UltraLabel2"
        Me.UltraLabel2.Size = New System.Drawing.Size(63, 14)
        Me.UltraLabel2.TabIndex = 23
        Me.UltraLabel2.Text = "Descripción"
        '
        'UltraLabel5
        '
        Appearance6.BackColor = System.Drawing.Color.Transparent
        Appearance6.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel5.Appearance = Appearance6
        Me.UltraLabel5.AutoSize = True
        Me.UltraLabel5.Location = New System.Drawing.Point(27, 157)
        Me.UltraLabel5.Name = "UltraLabel5"
        Me.UltraLabel5.Size = New System.Drawing.Size(53, 14)
        Me.UltraLabel5.TabIndex = 23
        Me.UltraLabel5.Text = "Categoria"
        '
        'UltraLabel1
        '
        Appearance1.BackColor = System.Drawing.Color.Transparent
        Appearance1.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel1.Appearance = Appearance1
        Me.UltraLabel1.Location = New System.Drawing.Point(25, 91)
        Me.UltraLabel1.Name = "UltraLabel1"
        Me.UltraLabel1.Size = New System.Drawing.Size(72, 37)
        Me.UltraLabel1.TabIndex = 23
        Me.UltraLabel1.Text = "Composicion Genérica"
        '
        'txt_id
        '
        Me.txt_id.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_id.Enabled = False
        Me.txt_id.ImageTransparentColor = System.Drawing.Color.WhiteSmoke
        Me.txt_id.Location = New System.Drawing.Point(108, 24)
        Me.txt_id.MaxLength = 50
        Me.txt_id.Name = "txt_id"
        Me.txt_id.Size = New System.Drawing.Size(88, 21)
        Me.txt_id.TabIndex = 0
        '
        'UltraLabel4
        '
        Appearance16.BackColor = System.Drawing.Color.Transparent
        Appearance16.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel4.Appearance = Appearance16
        Me.UltraLabel4.AutoSize = True
        Me.UltraLabel4.Location = New System.Drawing.Point(30, 31)
        Me.UltraLabel4.Name = "UltraLabel4"
        Me.UltraLabel4.Size = New System.Drawing.Size(40, 14)
        Me.UltraLabel4.TabIndex = 23
        Me.UltraLabel4.Text = "Codigo"
        '
        'ToolS_Mantenimiento
        '
        Me.ToolS_Mantenimiento.BackColor = System.Drawing.Color.White
        Me.ToolS_Mantenimiento.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Tool_Nuevo, Me.ToolStripSeparator1, Me.Tool_Grabar, Me.ToolStripSeparator3, Me.Tool_Editar, Me.ToolStripSeparator4, Me.Tool_Cancelar, Me.ToolStripSeparator2, Me.Tool_Eliminar, Me.ToolStripSeparator5, Me.Tool_Salir})
        Me.ToolS_Mantenimiento.Location = New System.Drawing.Point(0, 0)
        Me.ToolS_Mantenimiento.Name = "ToolS_Mantenimiento"
        Me.ToolS_Mantenimiento.Size = New System.Drawing.Size(715, 25)
        Me.ToolS_Mantenimiento.TabIndex = 12
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
        'utc_medicamentos
        '
        Me.utc_medicamentos.Controls.Add(Me.UltraTabSharedControlsPage1)
        Me.utc_medicamentos.Controls.Add(Me.UltraTabPageControl1)
        Me.utc_medicamentos.Controls.Add(Me.UltraTabPageControl2)
        Me.utc_medicamentos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.utc_medicamentos.Location = New System.Drawing.Point(0, 25)
        Me.utc_medicamentos.Name = "utc_medicamentos"
        Me.utc_medicamentos.SharedControlsPage = Me.UltraTabSharedControlsPage1
        Me.utc_medicamentos.Size = New System.Drawing.Size(715, 396)
        Me.utc_medicamentos.TabIndex = 13
        UltraTab1.TabPage = Me.UltraTabPageControl1
        UltraTab1.Text = "Lista de Medicamentos"
        UltraTab2.TabPage = Me.UltraTabPageControl2
        UltraTab2.Text = "Ingreso / Edicion de Datos"
        Me.utc_medicamentos.Tabs.AddRange(New Infragistics.Win.UltraWinTabControl.UltraTab() {UltraTab1, UltraTab2})
        '
        'UltraTabSharedControlsPage1
        '
        Me.UltraTabSharedControlsPage1.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabSharedControlsPage1.Name = "UltraTabSharedControlsPage1"
        Me.UltraTabSharedControlsPage1.Size = New System.Drawing.Size(711, 370)
        '
        'AD_MA_Medicamentos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(715, 421)
        Me.Controls.Add(Me.utc_medicamentos)
        Me.Controls.Add(Me.ToolS_Mantenimiento)
        Me.Name = "AD_MA_Medicamentos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Medicamentos para Recetas"
        Me.UltraTabPageControl1.ResumeLayout(False)
        CType(Me.ug_medicamentos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.uds_listaMedica, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabPageControl2.ResumeLayout(False)
        CType(Me.ugb_datos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ugb_datos.ResumeLayout(False)
        Me.ugb_datos.PerformLayout()
        CType(Me.txt_Descripcion, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_compo_gene, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_id, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolS_Mantenimiento.ResumeLayout(False)
        Me.ToolS_Mantenimiento.PerformLayout()
        CType(Me.utc_medicamentos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.utc_medicamentos.ResumeLayout(False)
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
    Friend WithEvents utc_medicamentos As Infragistics.Win.UltraWinTabControl.UltraTabControl
    Friend WithEvents UltraTabSharedControlsPage1 As Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage
    Friend WithEvents UltraTabPageControl1 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents ug_medicamentos As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents UltraTabPageControl2 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents ugb_datos As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents UltraLabel3 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents txt_Descripcion As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents txt_compo_gene As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents UltraLabel2 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel1 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents txt_id As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents UltraLabel4 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents cb_categoria As System.Windows.Forms.ComboBox
    Friend WithEvents UltraLabel5 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents cb_presentacion As System.Windows.Forms.ComboBox
    Friend WithEvents uds_listaMedica As Infragistics.Win.UltraWinDataSource.UltraDataSource
End Class
