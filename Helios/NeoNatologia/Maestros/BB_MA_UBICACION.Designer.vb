<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BB_MA_UBICACION
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
        Dim UltraGridColumn1 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("UB_ID")
        Dim UltraGridColumn2 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("UB_NOMBRE")
        Dim UltraGridColumn3 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("UB_IDTIPO")
        Dim UltraGridColumn4 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TI_DESCRIPCION")
        Dim UltraGridColumn5 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("UB_IDARTICULO")
        Dim UltraGridColumn6 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("UB_ESTADO")
        Dim UltraDataColumn1 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("UB_ID")
        Dim UltraDataColumn2 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("UB_NOMBRE")
        Dim UltraDataColumn3 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("UB_IDTIPO")
        Dim UltraDataColumn4 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("TI_DESCRIPCION")
        Dim UltraDataColumn5 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("UB_IDARTICULO")
        Dim UltraDataColumn6 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("UB_ESTADO")
        Dim ValueListItem2 As Infragistics.Win.ValueListItem = New Infragistics.Win.ValueListItem()
        Dim ValueListItem3 As Infragistics.Win.ValueListItem = New Infragistics.Win.ValueListItem()
        Dim Appearance11 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance6 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim EditorButton1 As Infragistics.Win.UltraWinEditors.EditorButton = New Infragistics.Win.UltraWinEditors.EditorButton("ayuda")
        Dim Appearance4 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance1 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance3 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance26 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraTab1 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraTab2 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Me.UltraTabPageControl1 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.ug_incuba = New Infragistics.Win.UltraWinGrid.UltraGrid()
        Me.uds_Lista = New Infragistics.Win.UltraWinDataSource.UltraDataSource(Me.components)
        Me.utp_in = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.ugb_datos = New Infragistics.Win.Misc.UltraGroupBox()
        Me.uos_Estado = New Infragistics.Win.UltraWinEditors.UltraOptionSet()
        Me.UltraLabel8 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraLabel5 = New Infragistics.Win.Misc.UltraLabel()
        Me.txt_Des_Articulo = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.txt_IDArticulo = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.txt_cod = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.UltraLabel1 = New Infragistics.Win.Misc.UltraLabel()
        Me.ucb_tip = New Infragistics.Win.UltraWinEditors.UltraComboEditor()
        Me.UltraLabel3 = New Infragistics.Win.Misc.UltraLabel()
        Me.txt_des = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.UltraLabel2 = New Infragistics.Win.Misc.UltraLabel()
        Me.txt_IDArt = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
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
        Me.utc_incuba = New Infragistics.Win.UltraWinTabControl.UltraTabControl()
        Me.UltraTabSharedControlsPage2 = New Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage()
        Me.UltraTabPageControl1.SuspendLayout()
        CType(Me.ug_incuba, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.uds_Lista, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.utp_in.SuspendLayout()
        CType(Me.ugb_datos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ugb_datos.SuspendLayout()
        CType(Me.uos_Estado, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_Des_Articulo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_IDArticulo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_cod, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ucb_tip, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_des, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_IDArt, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolS_Mantenimiento.SuspendLayout()
        CType(Me.utc_incuba, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.utc_incuba.SuspendLayout()
        Me.SuspendLayout()
        '
        'UltraTabPageControl1
        '
        Me.UltraTabPageControl1.Controls.Add(Me.ug_incuba)
        Me.UltraTabPageControl1.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl1.Name = "UltraTabPageControl1"
        Me.UltraTabPageControl1.Size = New System.Drawing.Size(624, 275)
        '
        'ug_incuba
        '
        Me.ug_incuba.DataSource = Me.uds_Lista
        Me.ug_incuba.DisplayLayout.AutoFitStyle = Infragistics.Win.UltraWinGrid.AutoFitStyle.ExtendLastColumn
        UltraGridColumn1.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn1.Header.Caption = "CODIGO"
        UltraGridColumn1.Header.VisiblePosition = 0
        UltraGridColumn2.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn2.Header.Caption = "NOMBRE"
        UltraGridColumn2.Header.VisiblePosition = 1
        UltraGridColumn2.Width = 378
        UltraGridColumn3.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn3.Header.VisiblePosition = 2
        UltraGridColumn3.Hidden = True
        UltraGridColumn4.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn4.Header.Caption = "TIPO"
        UltraGridColumn4.Header.VisiblePosition = 3
        UltraGridColumn5.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn5.Header.VisiblePosition = 4
        UltraGridColumn5.Hidden = True
        UltraGridColumn6.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn6.Header.VisiblePosition = 5
        UltraGridColumn6.Hidden = True
        UltraGridBand1.Columns.AddRange(New Object() {UltraGridColumn1, UltraGridColumn2, UltraGridColumn3, UltraGridColumn4, UltraGridColumn5, UltraGridColumn6})
        Me.ug_incuba.DisplayLayout.BandsSerializer.Add(UltraGridBand1)
        Me.ug_incuba.DisplayLayout.GroupByBox.Hidden = True
        Me.ug_incuba.DisplayLayout.MaxColScrollRegions = 1
        Me.ug_incuba.DisplayLayout.MaxRowScrollRegions = 1
        Me.ug_incuba.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        Me.ug_incuba.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Me.ug_incuba.DisplayLayout.Override.SelectTypeRow = Infragistics.Win.UltraWinGrid.SelectType.[Single]
        Me.ug_incuba.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.ug_incuba.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.ug_incuba.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy
        Me.ug_incuba.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ug_incuba.Location = New System.Drawing.Point(0, 0)
        Me.ug_incuba.Name = "ug_incuba"
        Me.ug_incuba.Size = New System.Drawing.Size(624, 275)
        Me.ug_incuba.TabIndex = 0
        '
        'uds_Lista
        '
        Me.uds_Lista.AllowDelete = False
        UltraDataColumn1.DataType = GetType(Long)
        UltraDataColumn3.DataType = GetType(Integer)
        UltraDataColumn5.DataType = GetType(Integer)
        UltraDataColumn6.DataType = GetType(Integer)
        Me.uds_Lista.Band.Columns.AddRange(New Object() {UltraDataColumn1, UltraDataColumn2, UltraDataColumn3, UltraDataColumn4, UltraDataColumn5, UltraDataColumn6})
        '
        'utp_in
        '
        Me.utp_in.Controls.Add(Me.ugb_datos)
        Me.utp_in.Location = New System.Drawing.Point(1, 23)
        Me.utp_in.Name = "utp_in"
        Me.utp_in.Size = New System.Drawing.Size(624, 275)
        '
        'ugb_datos
        '
        Me.ugb_datos.Controls.Add(Me.uos_Estado)
        Me.ugb_datos.Controls.Add(Me.UltraLabel8)
        Me.ugb_datos.Controls.Add(Me.UltraLabel5)
        Me.ugb_datos.Controls.Add(Me.txt_Des_Articulo)
        Me.ugb_datos.Controls.Add(Me.txt_IDArticulo)
        Me.ugb_datos.Controls.Add(Me.txt_cod)
        Me.ugb_datos.Controls.Add(Me.UltraLabel1)
        Me.ugb_datos.Controls.Add(Me.ucb_tip)
        Me.ugb_datos.Controls.Add(Me.UltraLabel3)
        Me.ugb_datos.Controls.Add(Me.txt_des)
        Me.ugb_datos.Controls.Add(Me.UltraLabel2)
        Me.ugb_datos.Controls.Add(Me.txt_IDArt)
        Me.ugb_datos.Location = New System.Drawing.Point(21, 15)
        Me.ugb_datos.Name = "ugb_datos"
        Me.ugb_datos.Size = New System.Drawing.Size(586, 243)
        Me.ugb_datos.TabIndex = 24
        '
        'uos_Estado
        '
        Me.uos_Estado.BackColor = System.Drawing.Color.Transparent
        Me.uos_Estado.BackColorInternal = System.Drawing.Color.Transparent
        Me.uos_Estado.BorderStyle = Infragistics.Win.UIElementBorderStyle.None
        Me.uos_Estado.CheckedIndex = 0
        ValueListItem2.DataValue = CType(1, Short)
        ValueListItem2.DisplayText = "Activo"
        ValueListItem3.DataValue = CType(0, Short)
        ValueListItem3.DisplayText = "Inactivo"
        Me.uos_Estado.Items.AddRange(New Infragistics.Win.ValueListItem() {ValueListItem2, ValueListItem3})
        Me.uos_Estado.Location = New System.Drawing.Point(91, 184)
        Me.uos_Estado.Name = "uos_Estado"
        Me.uos_Estado.Size = New System.Drawing.Size(139, 21)
        Me.uos_Estado.TabIndex = 5
        Me.uos_Estado.Text = "Activo"
        '
        'UltraLabel8
        '
        Appearance11.BackColor = System.Drawing.Color.Transparent
        Appearance11.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel8.Appearance = Appearance11
        Me.UltraLabel8.AutoSize = True
        Me.UltraLabel8.Location = New System.Drawing.Point(32, 184)
        Me.UltraLabel8.Name = "UltraLabel8"
        Me.UltraLabel8.Size = New System.Drawing.Size(39, 14)
        Me.UltraLabel8.TabIndex = 222
        Me.UltraLabel8.Text = "Estado"
        '
        'UltraLabel5
        '
        Appearance6.BackColor = System.Drawing.Color.Transparent
        Appearance6.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel5.Appearance = Appearance6
        Me.UltraLabel5.AutoSize = True
        Me.UltraLabel5.Location = New System.Drawing.Point(32, 140)
        Me.UltraLabel5.Name = "UltraLabel5"
        Me.UltraLabel5.Size = New System.Drawing.Size(42, 14)
        Me.UltraLabel5.TabIndex = 220
        Me.UltraLabel5.Text = "Articulo"
        '
        'txt_Des_Articulo
        '
        Me.txt_Des_Articulo.Location = New System.Drawing.Point(168, 137)
        Me.txt_Des_Articulo.Name = "txt_Des_Articulo"
        Me.txt_Des_Articulo.ReadOnly = True
        Me.txt_Des_Articulo.Size = New System.Drawing.Size(369, 21)
        Me.txt_Des_Articulo.TabIndex = 4
        '
        'txt_IDArticulo
        '
        Appearance4.ImageHAlign = Infragistics.Win.HAlign.Center
        Appearance4.ImageVAlign = Infragistics.Win.VAlign.Middle
        EditorButton1.Appearance = Appearance4
        EditorButton1.Key = "ayuda"
        Me.txt_IDArticulo.ButtonsRight.Add(EditorButton1)
        Me.txt_IDArticulo.Location = New System.Drawing.Point(82, 137)
        Me.txt_IDArticulo.MaxLength = 11
        Me.txt_IDArticulo.Name = "txt_IDArticulo"
        Me.txt_IDArticulo.Size = New System.Drawing.Size(81, 21)
        Me.txt_IDArticulo.TabIndex = 3
        '
        'txt_cod
        '
        Me.txt_cod.Location = New System.Drawing.Point(82, 26)
        Me.txt_cod.MaxLength = 10
        Me.txt_cod.Name = "txt_cod"
        Me.txt_cod.ReadOnly = True
        Me.txt_cod.Size = New System.Drawing.Size(81, 21)
        Me.txt_cod.TabIndex = 0
        '
        'UltraLabel1
        '
        Appearance1.BackColor = System.Drawing.Color.Transparent
        Appearance1.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel1.Appearance = Appearance1
        Me.UltraLabel1.AutoSize = True
        Me.UltraLabel1.Location = New System.Drawing.Point(33, 31)
        Me.UltraLabel1.Name = "UltraLabel1"
        Me.UltraLabel1.Size = New System.Drawing.Size(40, 14)
        Me.UltraLabel1.TabIndex = 6
        Me.UltraLabel1.Text = "Codigo"
        '
        'ucb_tip
        '
        Me.ucb_tip.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.ucb_tip.Location = New System.Drawing.Point(82, 99)
        Me.ucb_tip.Name = "ucb_tip"
        Me.ucb_tip.Size = New System.Drawing.Size(169, 21)
        Me.ucb_tip.TabIndex = 2
        '
        'UltraLabel3
        '
        Appearance3.BackColor = System.Drawing.Color.Transparent
        Appearance3.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel3.Appearance = Appearance3
        Me.UltraLabel3.AutoSize = True
        Me.UltraLabel3.Location = New System.Drawing.Point(33, 66)
        Me.UltraLabel3.Name = "UltraLabel3"
        Me.UltraLabel3.Size = New System.Drawing.Size(44, 14)
        Me.UltraLabel3.TabIndex = 6
        Me.UltraLabel3.Text = "Nombre"
        '
        'txt_des
        '
        Me.txt_des.Location = New System.Drawing.Point(82, 62)
        Me.txt_des.MaxLength = 50
        Me.txt_des.Name = "txt_des"
        Me.txt_des.Size = New System.Drawing.Size(455, 21)
        Me.txt_des.TabIndex = 1
        '
        'UltraLabel2
        '
        Appearance26.BackColor = System.Drawing.Color.Transparent
        Appearance26.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel2.Appearance = Appearance26
        Me.UltraLabel2.AutoSize = True
        Me.UltraLabel2.Location = New System.Drawing.Point(33, 103)
        Me.UltraLabel2.Name = "UltraLabel2"
        Me.UltraLabel2.Size = New System.Drawing.Size(26, 14)
        Me.UltraLabel2.TabIndex = 5
        Me.UltraLabel2.Text = "Tipo"
        '
        'txt_IDArt
        '
        Me.txt_IDArt.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_IDArt.Location = New System.Drawing.Point(153, 133)
        Me.txt_IDArt.MaxLength = 50
        Me.txt_IDArt.Name = "txt_IDArt"
        Me.txt_IDArt.ReadOnly = True
        Me.txt_IDArt.Size = New System.Drawing.Size(28, 21)
        Me.txt_IDArt.TabIndex = 221
        Me.txt_IDArt.Visible = False
        '
        'ToolS_Mantenimiento
        '
        Me.ToolS_Mantenimiento.BackColor = System.Drawing.Color.White
        Me.ToolS_Mantenimiento.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Tool_Nuevo, Me.ToolStripSeparator1, Me.Tool_Grabar, Me.ToolStripSeparator3, Me.Tool_Editar, Me.ToolStripSeparator4, Me.Tool_Cancelar, Me.ToolStripSeparator2, Me.Tool_Eliminar, Me.ToolStripSeparator5, Me.Tool_Salir})
        Me.ToolS_Mantenimiento.Location = New System.Drawing.Point(0, 0)
        Me.ToolS_Mantenimiento.Name = "ToolS_Mantenimiento"
        Me.ToolS_Mantenimiento.Size = New System.Drawing.Size(628, 25)
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
        'utc_incuba
        '
        Me.utc_incuba.Controls.Add(Me.UltraTabSharedControlsPage2)
        Me.utc_incuba.Controls.Add(Me.UltraTabPageControl1)
        Me.utc_incuba.Controls.Add(Me.utp_in)
        Me.utc_incuba.Dock = System.Windows.Forms.DockStyle.Fill
        Me.utc_incuba.Location = New System.Drawing.Point(0, 25)
        Me.utc_incuba.Name = "utc_incuba"
        Me.utc_incuba.SharedControlsPage = Me.UltraTabSharedControlsPage2
        Me.utc_incuba.Size = New System.Drawing.Size(628, 301)
        Me.utc_incuba.TabIndex = 14
        UltraTab1.TabPage = Me.UltraTabPageControl1
        UltraTab1.Text = "Listado"
        UltraTab2.TabPage = Me.utp_in
        UltraTab2.Text = "Ingreso  / Edicion de datos"
        Me.utc_incuba.Tabs.AddRange(New Infragistics.Win.UltraWinTabControl.UltraTab() {UltraTab1, UltraTab2})
        '
        'UltraTabSharedControlsPage2
        '
        Me.UltraTabSharedControlsPage2.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabSharedControlsPage2.Name = "UltraTabSharedControlsPage2"
        Me.UltraTabSharedControlsPage2.Size = New System.Drawing.Size(624, 275)
        '
        'BB_MA_UBICACION
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(628, 326)
        Me.Controls.Add(Me.utc_incuba)
        Me.Controls.Add(Me.ToolS_Mantenimiento)
        Me.Name = "BB_MA_UBICACION"
        Me.Text = "UBICACION DEL BEBE"
        Me.UltraTabPageControl1.ResumeLayout(False)
        CType(Me.ug_incuba, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.uds_Lista, System.ComponentModel.ISupportInitialize).EndInit()
        Me.utp_in.ResumeLayout(False)
        CType(Me.ugb_datos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ugb_datos.ResumeLayout(False)
        Me.ugb_datos.PerformLayout()
        CType(Me.uos_Estado, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_Des_Articulo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_IDArticulo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_cod, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ucb_tip, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_des, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_IDArt, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolS_Mantenimiento.ResumeLayout(False)
        Me.ToolS_Mantenimiento.PerformLayout()
        CType(Me.utc_incuba, System.ComponentModel.ISupportInitialize).EndInit()
        Me.utc_incuba.ResumeLayout(False)
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
    Friend WithEvents utc_incuba As Infragistics.Win.UltraWinTabControl.UltraTabControl
    Friend WithEvents UltraTabSharedControlsPage2 As Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage
    Friend WithEvents UltraTabPageControl1 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents ug_incuba As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents utp_in As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents UltraLabel2 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel1 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel3 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents txt_des As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents txt_cod As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents ucb_tip As Infragistics.Win.UltraWinEditors.UltraComboEditor
    Friend WithEvents uds_Lista As Infragistics.Win.UltraWinDataSource.UltraDataSource
    Friend WithEvents ugb_datos As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents UltraLabel5 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents txt_Des_Articulo As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents txt_IDArticulo As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents txt_IDArt As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents uos_Estado As Infragistics.Win.UltraWinEditors.UltraOptionSet
    Friend WithEvents UltraLabel8 As Infragistics.Win.Misc.UltraLabel
End Class
