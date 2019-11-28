<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LO_MA_ALMACEN
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
        Dim UltraGridColumn1 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("AL_ID")
        Dim UltraGridColumn2 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("AL_DESCRIPCION")
        Dim UltraGridColumn3 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("AL_DIR")
        Dim UltraGridColumn4 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("AL_PAIS")
        Dim UltraGridColumn5 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("AL_UBIGEO")
        Dim UltraGridColumn6 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("AL_TELFE")
        Dim UltraGridColumn7 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("AL_ESTADO")
        Dim UltraGridColumn8 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("AL_DEFECTO")
        Dim EditorButton1 As Infragistics.Win.UltraWinEditors.EditorButton = New Infragistics.Win.UltraWinEditors.EditorButton("btn_ubigeo")
        Dim Appearance10 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim ValueListItem1 As Infragistics.Win.ValueListItem = New Infragistics.Win.ValueListItem()
        Dim ValueListItem2 As Infragistics.Win.ValueListItem = New Infragistics.Win.ValueListItem()
        Dim Appearance8 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance26 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance2 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance3 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance4 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance1 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraTab1 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraTab2 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraDataColumn1 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("AL_ID")
        Dim UltraDataColumn2 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("AL_DESCRIPCION")
        Dim UltraDataColumn3 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("AL_DIR")
        Dim UltraDataColumn4 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("AL_PAIS")
        Dim UltraDataColumn5 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("AL_UBIGEO")
        Dim UltraDataColumn6 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("AL_TELFE")
        Dim UltraDataColumn7 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("AL_ESTADO")
        Dim UltraDataColumn8 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("AL_DEFECTO")
        Me.UltraTabPageControl1 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.ug_ar = New Infragistics.Win.UltraWinGrid.UltraGrid()
        Me.uc_pais = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.txt_des_ubigeo = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.txt_ubigeo = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.ucheck_defecto = New Infragistics.Win.UltraWinEditors.UltraCheckEditor()
        Me.ugb_estado = New Infragistics.Win.Misc.UltraGroupBox()
        Me.urb_Estado = New Infragistics.Win.UltraWinEditors.UltraOptionSet()
        Me.uce_pais = New Infragistics.Win.UltraWinEditors.UltraComboEditor()
        Me.txt_tele = New System.Windows.Forms.TextBox()
        Me.UltraLabel6 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraLabel5 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraLabel4 = New Infragistics.Win.Misc.UltraLabel()
        Me.txt_direc = New System.Windows.Forms.TextBox()
        Me.UltraLabel3 = New Infragistics.Win.Misc.UltraLabel()
        Me.txt_des = New System.Windows.Forms.TextBox()
        Me.txt_cod = New System.Windows.Forms.TextBox()
        Me.UltraLabel2 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraLabel1 = New Infragistics.Win.Misc.UltraLabel()
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
        Me.utb_datos = New Infragistics.Win.UltraWinTabControl.UltraTabControl()
        Me.UltraTabSharedControlsPage2 = New Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage()
        Me.uds_almacen = New Infragistics.Win.UltraWinDataSource.UltraDataSource(Me.components)
        Me.UltraTabPageControl1.SuspendLayout()
        CType(Me.ug_ar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.uc_pais.SuspendLayout()
        CType(Me.txt_des_ubigeo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_ubigeo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ugb_estado, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ugb_estado.SuspendLayout()
        CType(Me.urb_Estado, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.uce_pais, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolS_Mantenimiento.SuspendLayout()
        CType(Me.utb_datos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.utb_datos.SuspendLayout()
        CType(Me.uds_almacen, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'UltraTabPageControl1
        '
        Me.UltraTabPageControl1.Controls.Add(Me.ug_ar)
        Me.UltraTabPageControl1.Location = New System.Drawing.Point(1, 23)
        Me.UltraTabPageControl1.Name = "UltraTabPageControl1"
        Me.UltraTabPageControl1.Size = New System.Drawing.Size(668, 237)
        '
        'ug_ar
        '
        Me.ug_ar.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ug_ar.DataSource = Me.uds_almacen
        Me.ug_ar.DisplayLayout.AutoFitStyle = Infragistics.Win.UltraWinGrid.AutoFitStyle.ExtendLastColumn
        UltraGridColumn1.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn1.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn1.Header.Caption = "CODIGO"
        UltraGridColumn1.Header.VisiblePosition = 0
        UltraGridColumn1.Width = 49
        UltraGridColumn2.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn2.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn2.Header.Caption = "DESCRIPCION"
        UltraGridColumn2.Header.VisiblePosition = 1
        UltraGridColumn2.Width = 252
        UltraGridColumn3.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn3.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn3.Header.VisiblePosition = 2
        UltraGridColumn3.Hidden = True
        UltraGridColumn4.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn4.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn4.Header.VisiblePosition = 3
        UltraGridColumn4.Hidden = True
        UltraGridColumn5.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn5.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn5.Header.VisiblePosition = 4
        UltraGridColumn5.Hidden = True
        UltraGridColumn6.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn6.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn6.Header.Caption = "TELFE"
        UltraGridColumn6.Header.VisiblePosition = 5
        UltraGridColumn7.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn7.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn7.Header.VisiblePosition = 6
        UltraGridColumn7.Hidden = True
        UltraGridColumn8.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn8.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn8.Header.VisiblePosition = 7
        UltraGridColumn8.Hidden = True
        UltraGridBand1.Columns.AddRange(New Object() {UltraGridColumn1, UltraGridColumn2, UltraGridColumn3, UltraGridColumn4, UltraGridColumn5, UltraGridColumn6, UltraGridColumn7, UltraGridColumn8})
        Me.ug_ar.DisplayLayout.BandsSerializer.Add(UltraGridBand1)
        Me.ug_ar.DisplayLayout.GroupByBox.Hidden = True
        Me.ug_ar.DisplayLayout.MaxColScrollRegions = 1
        Me.ug_ar.DisplayLayout.MaxRowScrollRegions = 1
        Me.ug_ar.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        Me.ug_ar.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Me.ug_ar.DisplayLayout.Override.SelectTypeRow = Infragistics.Win.UltraWinGrid.SelectType.[Single]
        Me.ug_ar.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.ug_ar.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.ug_ar.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy
        Me.ug_ar.Location = New System.Drawing.Point(0, 0)
        Me.ug_ar.Name = "ug_ar"
        Me.ug_ar.Size = New System.Drawing.Size(665, 237)
        Me.ug_ar.TabIndex = 0
        '
        'uc_pais
        '
        Me.uc_pais.Controls.Add(Me.txt_des_ubigeo)
        Me.uc_pais.Controls.Add(Me.txt_ubigeo)
        Me.uc_pais.Controls.Add(Me.ucheck_defecto)
        Me.uc_pais.Controls.Add(Me.ugb_estado)
        Me.uc_pais.Controls.Add(Me.uce_pais)
        Me.uc_pais.Controls.Add(Me.txt_tele)
        Me.uc_pais.Controls.Add(Me.UltraLabel6)
        Me.uc_pais.Controls.Add(Me.UltraLabel5)
        Me.uc_pais.Controls.Add(Me.UltraLabel4)
        Me.uc_pais.Controls.Add(Me.txt_direc)
        Me.uc_pais.Controls.Add(Me.UltraLabel3)
        Me.uc_pais.Controls.Add(Me.txt_des)
        Me.uc_pais.Controls.Add(Me.txt_cod)
        Me.uc_pais.Controls.Add(Me.UltraLabel2)
        Me.uc_pais.Controls.Add(Me.UltraLabel1)
        Me.uc_pais.Location = New System.Drawing.Point(-10000, -10000)
        Me.uc_pais.Name = "uc_pais"
        Me.uc_pais.Size = New System.Drawing.Size(668, 237)
        '
        'txt_des_ubigeo
        '
        Me.txt_des_ubigeo.Location = New System.Drawing.Point(162, 168)
        Me.txt_des_ubigeo.MaxLength = 11
        Me.txt_des_ubigeo.Name = "txt_des_ubigeo"
        Me.txt_des_ubigeo.Size = New System.Drawing.Size(203, 21)
        Me.txt_des_ubigeo.TabIndex = 23
        '
        'txt_ubigeo
        '
        EditorButton1.Key = "btn_ubigeo"
        Me.txt_ubigeo.ButtonsRight.Add(EditorButton1)
        Me.txt_ubigeo.Location = New System.Drawing.Point(82, 168)
        Me.txt_ubigeo.MaxLength = 11
        Me.txt_ubigeo.Name = "txt_ubigeo"
        Me.txt_ubigeo.Size = New System.Drawing.Size(78, 21)
        Me.txt_ubigeo.TabIndex = 5
        '
        'ucheck_defecto
        '
        Appearance10.FontData.SizeInPoints = 9.0!
        Appearance10.ForeColor = System.Drawing.Color.Navy
        Me.ucheck_defecto.Appearance = Appearance10
        Me.ucheck_defecto.BackColor = System.Drawing.Color.Transparent
        Me.ucheck_defecto.BackColorInternal = System.Drawing.Color.Transparent
        Me.ucheck_defecto.Location = New System.Drawing.Point(447, 96)
        Me.ucheck_defecto.Name = "ucheck_defecto"
        Me.ucheck_defecto.Size = New System.Drawing.Size(120, 20)
        Me.ucheck_defecto.TabIndex = 7
        Me.ucheck_defecto.Text = "Por Defecto"
        '
        'ugb_estado
        '
        Me.ugb_estado.Controls.Add(Me.urb_Estado)
        Me.ugb_estado.Location = New System.Drawing.Point(447, 138)
        Me.ugb_estado.Name = "ugb_estado"
        Me.ugb_estado.Size = New System.Drawing.Size(171, 51)
        Me.ugb_estado.TabIndex = 6
        Me.ugb_estado.Text = "Estado"
        '
        'urb_Estado
        '
        Me.urb_Estado.BackColor = System.Drawing.Color.Transparent
        Me.urb_Estado.BackColorInternal = System.Drawing.Color.Transparent
        Me.urb_Estado.BorderStyle = Infragistics.Win.UIElementBorderStyle.None
        Me.urb_Estado.CheckedIndex = 0
        ValueListItem1.DataValue = 1
        ValueListItem1.DisplayText = "Activo"
        ValueListItem2.DataValue = 0
        ValueListItem2.DisplayText = "Inactivo"
        Me.urb_Estado.Items.AddRange(New Infragistics.Win.ValueListItem() {ValueListItem1, ValueListItem2})
        Me.urb_Estado.Location = New System.Drawing.Point(20, 22)
        Me.urb_Estado.Name = "urb_Estado"
        Me.urb_Estado.Size = New System.Drawing.Size(138, 22)
        Me.urb_Estado.TabIndex = 28
        Me.urb_Estado.Text = "Activo"
        '
        'uce_pais
        '
        Me.uce_pais.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.uce_pais.Location = New System.Drawing.Point(82, 134)
        Me.uce_pais.Name = "uce_pais"
        Me.uce_pais.Size = New System.Drawing.Size(198, 21)
        Me.uce_pais.TabIndex = 4
        '
        'txt_tele
        '
        Me.txt_tele.Location = New System.Drawing.Point(517, 60)
        Me.txt_tele.Name = "txt_tele"
        Me.txt_tele.Size = New System.Drawing.Size(88, 20)
        Me.txt_tele.TabIndex = 3
        '
        'UltraLabel6
        '
        Appearance8.BackColor = System.Drawing.Color.Transparent
        Appearance8.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel6.Appearance = Appearance8
        Me.UltraLabel6.Location = New System.Drawing.Point(447, 63)
        Me.UltraLabel6.Name = "UltraLabel6"
        Me.UltraLabel6.Size = New System.Drawing.Size(64, 17)
        Me.UltraLabel6.TabIndex = 15
        Me.UltraLabel6.Text = "Telefono"
        '
        'UltraLabel5
        '
        Appearance26.BackColor = System.Drawing.Color.Transparent
        Appearance26.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel5.Appearance = Appearance26
        Me.UltraLabel5.Location = New System.Drawing.Point(12, 172)
        Me.UltraLabel5.Name = "UltraLabel5"
        Me.UltraLabel5.Size = New System.Drawing.Size(64, 17)
        Me.UltraLabel5.TabIndex = 13
        Me.UltraLabel5.Text = "Ubigeo"
        '
        'UltraLabel4
        '
        Appearance2.BackColor = System.Drawing.Color.Transparent
        Appearance2.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel4.Appearance = Appearance2
        Me.UltraLabel4.Location = New System.Drawing.Point(12, 138)
        Me.UltraLabel4.Name = "UltraLabel4"
        Me.UltraLabel4.Size = New System.Drawing.Size(64, 17)
        Me.UltraLabel4.TabIndex = 11
        Me.UltraLabel4.Text = "Pais"
        '
        'txt_direc
        '
        Me.txt_direc.Location = New System.Drawing.Point(82, 97)
        Me.txt_direc.Name = "txt_direc"
        Me.txt_direc.Size = New System.Drawing.Size(295, 20)
        Me.txt_direc.TabIndex = 2
        '
        'UltraLabel3
        '
        Appearance3.BackColor = System.Drawing.Color.Transparent
        Appearance3.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel3.Appearance = Appearance3
        Me.UltraLabel3.Location = New System.Drawing.Point(12, 100)
        Me.UltraLabel3.Name = "UltraLabel3"
        Me.UltraLabel3.Size = New System.Drawing.Size(64, 17)
        Me.UltraLabel3.TabIndex = 9
        Me.UltraLabel3.Text = "Direccion"
        '
        'txt_des
        '
        Me.txt_des.Location = New System.Drawing.Point(82, 60)
        Me.txt_des.Name = "txt_des"
        Me.txt_des.Size = New System.Drawing.Size(295, 20)
        Me.txt_des.TabIndex = 1
        '
        'txt_cod
        '
        Me.txt_cod.Location = New System.Drawing.Point(82, 16)
        Me.txt_cod.Name = "txt_cod"
        Me.txt_cod.Size = New System.Drawing.Size(78, 20)
        Me.txt_cod.TabIndex = 0
        '
        'UltraLabel2
        '
        Appearance4.BackColor = System.Drawing.Color.Transparent
        Appearance4.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel2.Appearance = Appearance4
        Me.UltraLabel2.Location = New System.Drawing.Point(12, 63)
        Me.UltraLabel2.Name = "UltraLabel2"
        Me.UltraLabel2.Size = New System.Drawing.Size(64, 17)
        Me.UltraLabel2.TabIndex = 5
        Me.UltraLabel2.Text = "Descripcion"
        '
        'UltraLabel1
        '
        Appearance1.BackColor = System.Drawing.Color.Transparent
        Appearance1.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel1.Appearance = Appearance1
        Me.UltraLabel1.Location = New System.Drawing.Point(12, 19)
        Me.UltraLabel1.Name = "UltraLabel1"
        Me.UltraLabel1.Size = New System.Drawing.Size(41, 16)
        Me.UltraLabel1.TabIndex = 6
        Me.UltraLabel1.Text = "Codigo"
        '
        'ToolS_Mantenimiento
        '
        Me.ToolS_Mantenimiento.BackColor = System.Drawing.Color.White
        Me.ToolS_Mantenimiento.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Tool_Nuevo, Me.ToolStripSeparator1, Me.Tool_Grabar, Me.ToolStripSeparator3, Me.Tool_Editar, Me.ToolStripSeparator4, Me.Tool_Cancelar, Me.ToolStripSeparator2, Me.Tool_Eliminar, Me.ToolStripSeparator5, Me.Tool_Salir})
        Me.ToolS_Mantenimiento.Location = New System.Drawing.Point(0, 0)
        Me.ToolS_Mantenimiento.Name = "ToolS_Mantenimiento"
        Me.ToolS_Mantenimiento.Size = New System.Drawing.Size(690, 25)
        Me.ToolS_Mantenimiento.TabIndex = 11
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
        'utb_datos
        '
        Me.utb_datos.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.utb_datos.Controls.Add(Me.UltraTabSharedControlsPage2)
        Me.utb_datos.Controls.Add(Me.UltraTabPageControl1)
        Me.utb_datos.Controls.Add(Me.uc_pais)
        Me.utb_datos.Location = New System.Drawing.Point(12, 28)
        Me.utb_datos.Name = "utb_datos"
        Me.utb_datos.SharedControlsPage = Me.UltraTabSharedControlsPage2
        Me.utb_datos.Size = New System.Drawing.Size(672, 263)
        Me.utb_datos.TabIndex = 13
        UltraTab1.TabPage = Me.UltraTabPageControl1
        UltraTab1.Text = "Listado"
        UltraTab2.TabPage = Me.uc_pais
        UltraTab2.Text = "Ingreso  / Edicion de datos"
        Me.utb_datos.Tabs.AddRange(New Infragistics.Win.UltraWinTabControl.UltraTab() {UltraTab1, UltraTab2})
        '
        'UltraTabSharedControlsPage2
        '
        Me.UltraTabSharedControlsPage2.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabSharedControlsPage2.Name = "UltraTabSharedControlsPage2"
        Me.UltraTabSharedControlsPage2.Size = New System.Drawing.Size(668, 237)
        '
        'uds_almacen
        '
        Me.uds_almacen.AllowAdd = False
        Me.uds_almacen.AllowDelete = False
        Me.uds_almacen.Band.Columns.AddRange(New Object() {UltraDataColumn1, UltraDataColumn2, UltraDataColumn3, UltraDataColumn4, UltraDataColumn5, UltraDataColumn6, UltraDataColumn7, UltraDataColumn8})
        '
        'LO_MA_ALMACEN
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(690, 293)
        Me.Controls.Add(Me.utb_datos)
        Me.Controls.Add(Me.ToolS_Mantenimiento)
        Me.Name = "LO_MA_ALMACEN"
        Me.Text = "Mantenimiento de Almacen"
        Me.UltraTabPageControl1.ResumeLayout(False)
        CType(Me.ug_ar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.uc_pais.ResumeLayout(False)
        Me.uc_pais.PerformLayout()
        CType(Me.txt_des_ubigeo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_ubigeo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ugb_estado, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ugb_estado.ResumeLayout(False)
        CType(Me.urb_Estado, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.uce_pais, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolS_Mantenimiento.ResumeLayout(False)
        Me.ToolS_Mantenimiento.PerformLayout()
        CType(Me.utb_datos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.utb_datos.ResumeLayout(False)
        CType(Me.uds_almacen, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents utb_datos As Infragistics.Win.UltraWinTabControl.UltraTabControl
    Friend WithEvents UltraTabSharedControlsPage2 As Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage
    Friend WithEvents UltraTabPageControl1 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents ug_ar As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents uc_pais As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents txt_tele As System.Windows.Forms.TextBox
    Friend WithEvents UltraLabel6 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel5 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel4 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents txt_direc As System.Windows.Forms.TextBox
    Friend WithEvents UltraLabel3 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents txt_des As System.Windows.Forms.TextBox
    Friend WithEvents txt_cod As System.Windows.Forms.TextBox
    Friend WithEvents UltraLabel2 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel1 As Infragistics.Win.Misc.UltraLabel
    Public WithEvents uce_pais As Infragistics.Win.UltraWinEditors.UltraComboEditor
    Friend WithEvents ugb_estado As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents urb_Estado As Infragistics.Win.UltraWinEditors.UltraOptionSet
    Friend WithEvents ucheck_defecto As Infragistics.Win.UltraWinEditors.UltraCheckEditor
    Friend WithEvents txt_ubigeo As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents txt_des_ubigeo As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents uds_almacen As Infragistics.Win.UltraWinDataSource.UltraDataSource
End Class
