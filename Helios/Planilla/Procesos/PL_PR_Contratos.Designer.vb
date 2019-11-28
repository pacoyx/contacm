<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PL_PR_Contratos
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
        Dim Appearance3 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridBand1 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1)
        Dim UltraGridColumn1 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ITEM")
        Dim UltraGridColumn2 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CO_ID")
        Dim UltraGridColumn3 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CO_ID_TIPO_CONTRATO")
        Dim UltraGridColumn4 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CO_FECHA_INI")
        Dim UltraGridColumn5 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CO_FECHA_FIN")
        Dim UltraGridColumn6 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CO_COMENTARIO")
        Dim UltraDataColumn1 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("ITEM")
        Dim UltraDataColumn2 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("CO_ID")
        Dim UltraDataColumn3 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("CO_ID_TIPO_CONTRATO")
        Dim UltraDataColumn4 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("CO_FECHA_INI")
        Dim UltraDataColumn5 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("CO_FECHA_FIN")
        Dim UltraDataColumn6 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("CO_COMENTARIO")
        Dim UltraGridBand2 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1)
        Dim UltraGridColumn7 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("PE_ID")
        Dim UltraGridColumn8 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("PE_CODIGO")
        Dim UltraGridColumn9 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("APELLIDOS_NOMBRES")
        Dim Appearance4 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraDataColumn7 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("PE_ID")
        Dim UltraDataColumn8 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("PE_CODIGO")
        Dim UltraDataColumn9 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("APELLIDOS_NOMBRES")
        Dim EditorButton1 As Infragistics.Win.UltraWinEditors.EditorButton = New Infragistics.Win.UltraWinEditors.EditorButton()
        Dim Appearance14 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance8 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance5 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance1 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance2 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance6 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraTab1 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraTab2 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Me.UltraTabPageControl1 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.ubtn_atraz = New Infragistics.Win.Misc.UltraButton()
        Me.lbl_titulo = New Infragistics.Win.Misc.UltraLabel()
        Me.ug_Detalle = New Infragistics.Win.UltraWinGrid.UltraGrid()
        Me.uds_Detalle = New Infragistics.Win.UltraWinDataSource.UltraDataSource(Me.components)
        Me.ubtn_Generar_Contrato = New Infragistics.Win.Misc.UltraButton()
        Me.ug_Lista = New Infragistics.Win.UltraWinGrid.UltraGrid()
        Me.uds_Lista = New Infragistics.Win.UltraWinDataSource.UltraDataSource(Me.components)
        Me.UltraTabPageControl2 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.gb1 = New System.Windows.Forms.GroupBox()
        Me.txt_nombres = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.txt_id_personal = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.txt_cod_personal = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.UltraLabel10 = New Infragistics.Win.Misc.UltraLabel()
        Me.ugb_detalle = New Infragistics.Win.Misc.UltraGroupBox()
        Me.une_id = New Infragistics.Win.UltraWinEditors.UltraNumericEditor()
        Me.txt_comentario = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.udte_fec_ter = New Infragistics.Win.UltraWinEditors.UltraDateTimeEditor()
        Me.udte_fec_ini = New Infragistics.Win.UltraWinEditors.UltraDateTimeEditor()
        Me.uce_tipoContrato = New Infragistics.Win.UltraWinEditors.UltraComboEditor()
        Me.UltraLabel3 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraLabel2 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraLabel1 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraLabel63 = New Infragistics.Win.Misc.UltraLabel()
        Me.utc_contrato = New Infragistics.Win.UltraWinTabControl.UltraTabControl()
        Me.UltraTabSharedControlsPage1 = New Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage()
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
        Me.Tool_Reporte = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator6 = New System.Windows.Forms.ToolStripSeparator()
        Me.Tool_Salir = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator7 = New System.Windows.Forms.ToolStripSeparator()
        Me.UltraTabPageControl1.SuspendLayout()
        CType(Me.ug_Detalle, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.uds_Detalle, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ug_Lista, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.uds_Lista, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabPageControl2.SuspendLayout()
        Me.gb1.SuspendLayout()
        CType(Me.txt_nombres, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_id_personal, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_cod_personal, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ugb_detalle, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ugb_detalle.SuspendLayout()
        CType(Me.une_id, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_comentario, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.udte_fec_ter, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.udte_fec_ini, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.uce_tipoContrato, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.utc_contrato, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.utc_contrato.SuspendLayout()
        Me.ToolS_Mantenimiento.SuspendLayout()
        Me.SuspendLayout()
        '
        'UltraTabPageControl1
        '
        Me.UltraTabPageControl1.Controls.Add(Me.ubtn_atraz)
        Me.UltraTabPageControl1.Controls.Add(Me.lbl_titulo)
        Me.UltraTabPageControl1.Controls.Add(Me.ug_Detalle)
        Me.UltraTabPageControl1.Controls.Add(Me.ubtn_Generar_Contrato)
        Me.UltraTabPageControl1.Controls.Add(Me.ug_Lista)
        Me.UltraTabPageControl1.Location = New System.Drawing.Point(1, 23)
        Me.UltraTabPageControl1.Name = "UltraTabPageControl1"
        Me.UltraTabPageControl1.Size = New System.Drawing.Size(710, 431)
        '
        'ubtn_atraz
        '
        Me.ubtn_atraz.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ubtn_atraz.Location = New System.Drawing.Point(477, 13)
        Me.ubtn_atraz.Name = "ubtn_atraz"
        Me.ubtn_atraz.Size = New System.Drawing.Size(78, 27)
        Me.ubtn_atraz.TabIndex = 12
        Me.ubtn_atraz.Text = "Atraz"
        '
        'lbl_titulo
        '
        Appearance3.BackColor = System.Drawing.Color.Transparent
        Appearance3.ForeColor = System.Drawing.Color.Navy
        Me.lbl_titulo.Appearance = Appearance3
        Me.lbl_titulo.AutoSize = True
        Me.lbl_titulo.Location = New System.Drawing.Point(15, 26)
        Me.lbl_titulo.Name = "lbl_titulo"
        Me.lbl_titulo.Size = New System.Drawing.Size(14, 14)
        Me.lbl_titulo.TabIndex = 11
        Me.lbl_titulo.Text = "..."
        '
        'ug_Detalle
        '
        Me.ug_Detalle.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ug_Detalle.DataSource = Me.uds_Detalle
        Me.ug_Detalle.DisplayLayout.AutoFitStyle = Infragistics.Win.UltraWinGrid.AutoFitStyle.ExtendLastColumn
        UltraGridColumn1.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn1.Header.VisiblePosition = 1
        UltraGridColumn2.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn2.Header.VisiblePosition = 0
        UltraGridColumn2.Hidden = True
        UltraGridColumn3.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn3.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn3.Header.Caption = "TIPO CONTRATO"
        UltraGridColumn3.Header.VisiblePosition = 2
        UltraGridColumn4.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn4.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn4.Header.Caption = "FECHA INICIO"
        UltraGridColumn4.Header.VisiblePosition = 3
        UltraGridColumn5.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn5.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn5.Header.Caption = "FECHA TERMINO"
        UltraGridColumn5.Header.VisiblePosition = 4
        UltraGridColumn6.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn6.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn6.Header.Caption = "COMENTARIO"
        UltraGridColumn6.Header.VisiblePosition = 5
        UltraGridBand1.Columns.AddRange(New Object() {UltraGridColumn1, UltraGridColumn2, UltraGridColumn3, UltraGridColumn4, UltraGridColumn5, UltraGridColumn6})
        Me.ug_Detalle.DisplayLayout.BandsSerializer.Add(UltraGridBand1)
        Me.ug_Detalle.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.[False]
        Me.ug_Detalle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ug_Detalle.Location = New System.Drawing.Point(15, 46)
        Me.ug_Detalle.Name = "ug_Detalle"
        Me.ug_Detalle.Size = New System.Drawing.Size(681, 382)
        Me.ug_Detalle.TabIndex = 10
        Me.ug_Detalle.Text = "UltraGrid2"
        '
        'uds_Detalle
        '
        Me.uds_Detalle.AllowDelete = False
        UltraDataColumn1.DataType = GetType(Short)
        UltraDataColumn2.DataType = GetType(Long)
        UltraDataColumn4.DataType = GetType(Date)
        UltraDataColumn5.DataType = GetType(Date)
        Me.uds_Detalle.Band.Columns.AddRange(New Object() {UltraDataColumn1, UltraDataColumn2, UltraDataColumn3, UltraDataColumn4, UltraDataColumn5, UltraDataColumn6})
        '
        'ubtn_Generar_Contrato
        '
        Me.ubtn_Generar_Contrato.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ubtn_Generar_Contrato.Location = New System.Drawing.Point(562, 12)
        Me.ubtn_Generar_Contrato.Name = "ubtn_Generar_Contrato"
        Me.ubtn_Generar_Contrato.Size = New System.Drawing.Size(134, 28)
        Me.ubtn_Generar_Contrato.TabIndex = 9
        Me.ubtn_Generar_Contrato.Text = "&Generar Contrato"
        '
        'ug_Lista
        '
        Me.ug_Lista.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ug_Lista.DataSource = Me.uds_Lista
        Me.ug_Lista.DisplayLayout.AutoFitStyle = Infragistics.Win.UltraWinGrid.AutoFitStyle.ExtendLastColumn
        UltraGridColumn7.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn7.Header.VisiblePosition = 0
        UltraGridColumn7.Hidden = True
        UltraGridColumn8.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn8.Header.Caption = "CODIGO"
        UltraGridColumn8.Header.VisiblePosition = 1
        UltraGridColumn9.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn9.Header.Caption = "APELLIDOS y NOMBRES"
        UltraGridColumn9.Header.VisiblePosition = 2
        UltraGridBand2.Columns.AddRange(New Object() {UltraGridColumn7, UltraGridColumn8, UltraGridColumn9})
        Me.ug_Lista.DisplayLayout.BandsSerializer.Add(UltraGridBand2)
        Me.ug_Lista.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.[False]
        Me.ug_Lista.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Appearance4.BackColor = System.Drawing.Color.WhiteSmoke
        Appearance4.BackColor2 = System.Drawing.Color.WhiteSmoke
        Me.ug_Lista.DisplayLayout.Override.RowAlternateAppearance = Appearance4
        Me.ug_Lista.Location = New System.Drawing.Point(15, 46)
        Me.ug_Lista.Name = "ug_Lista"
        Me.ug_Lista.Size = New System.Drawing.Size(681, 382)
        Me.ug_Lista.TabIndex = 0
        Me.ug_Lista.Text = "UltraGrid1"
        '
        'uds_Lista
        '
        Me.uds_Lista.AllowDelete = False
        UltraDataColumn7.DataType = GetType(Long)
        Me.uds_Lista.Band.Columns.AddRange(New Object() {UltraDataColumn7, UltraDataColumn8, UltraDataColumn9})
        '
        'UltraTabPageControl2
        '
        Me.UltraTabPageControl2.Controls.Add(Me.gb1)
        Me.UltraTabPageControl2.Controls.Add(Me.ugb_detalle)
        Me.UltraTabPageControl2.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl2.Name = "UltraTabPageControl2"
        Me.UltraTabPageControl2.Size = New System.Drawing.Size(710, 431)
        '
        'gb1
        '
        Me.gb1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gb1.Controls.Add(Me.txt_nombres)
        Me.gb1.Controls.Add(Me.txt_id_personal)
        Me.gb1.Controls.Add(Me.txt_cod_personal)
        Me.gb1.Controls.Add(Me.UltraLabel10)
        Me.gb1.Location = New System.Drawing.Point(20, 7)
        Me.gb1.Name = "gb1"
        Me.gb1.Size = New System.Drawing.Size(676, 48)
        Me.gb1.TabIndex = 14
        Me.gb1.TabStop = False
        Me.gb1.Text = "Identificacion"
        '
        'txt_nombres
        '
        Me.txt_nombres.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_nombres.Location = New System.Drawing.Point(242, 18)
        Me.txt_nombres.Name = "txt_nombres"
        Me.txt_nombres.ReadOnly = True
        Me.txt_nombres.Size = New System.Drawing.Size(417, 21)
        Me.txt_nombres.TabIndex = 9
        '
        'txt_id_personal
        '
        Me.txt_id_personal.Location = New System.Drawing.Point(173, 18)
        Me.txt_id_personal.Name = "txt_id_personal"
        Me.txt_id_personal.ReadOnly = True
        Me.txt_id_personal.Size = New System.Drawing.Size(69, 21)
        Me.txt_id_personal.TabIndex = 8
        '
        'txt_cod_personal
        '
        Appearance14.ImageHAlign = Infragistics.Win.HAlign.Center
        EditorButton1.Appearance = Appearance14
        Me.txt_cod_personal.ButtonsRight.Add(EditorButton1)
        Me.txt_cod_personal.Location = New System.Drawing.Point(72, 18)
        Me.txt_cod_personal.Name = "txt_cod_personal"
        Me.txt_cod_personal.Size = New System.Drawing.Size(101, 21)
        Me.txt_cod_personal.TabIndex = 0
        '
        'UltraLabel10
        '
        Appearance8.BackColor = System.Drawing.Color.Transparent
        Appearance8.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel10.Appearance = Appearance8
        Me.UltraLabel10.AutoSize = True
        Me.UltraLabel10.Location = New System.Drawing.Point(17, 21)
        Me.UltraLabel10.Name = "UltraLabel10"
        Me.UltraLabel10.Size = New System.Drawing.Size(49, 14)
        Me.UltraLabel10.TabIndex = 8
        Me.UltraLabel10.Text = "Personal"
        '
        'ugb_detalle
        '
        Me.ugb_detalle.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ugb_detalle.Controls.Add(Me.une_id)
        Me.ugb_detalle.Controls.Add(Me.txt_comentario)
        Me.ugb_detalle.Controls.Add(Me.udte_fec_ter)
        Me.ugb_detalle.Controls.Add(Me.udte_fec_ini)
        Me.ugb_detalle.Controls.Add(Me.uce_tipoContrato)
        Me.ugb_detalle.Controls.Add(Me.UltraLabel3)
        Me.ugb_detalle.Controls.Add(Me.UltraLabel2)
        Me.ugb_detalle.Controls.Add(Me.UltraLabel1)
        Me.ugb_detalle.Controls.Add(Me.UltraLabel63)
        Me.ugb_detalle.Location = New System.Drawing.Point(20, 61)
        Me.ugb_detalle.Name = "ugb_detalle"
        Me.ugb_detalle.Size = New System.Drawing.Size(676, 356)
        Me.ugb_detalle.TabIndex = 0
        '
        'une_id
        '
        Me.une_id.Location = New System.Drawing.Point(408, 21)
        Me.une_id.Name = "une_id"
        Me.une_id.Size = New System.Drawing.Size(89, 21)
        Me.une_id.TabIndex = 13
        Me.une_id.Visible = False
        '
        'txt_comentario
        '
        Me.txt_comentario.Location = New System.Drawing.Point(128, 125)
        Me.txt_comentario.Name = "txt_comentario"
        Me.txt_comentario.Size = New System.Drawing.Size(430, 21)
        Me.txt_comentario.TabIndex = 12
        '
        'udte_fec_ter
        '
        Me.udte_fec_ter.Location = New System.Drawing.Point(128, 91)
        Me.udte_fec_ter.Name = "udte_fec_ter"
        Me.udte_fec_ter.Size = New System.Drawing.Size(144, 21)
        Me.udte_fec_ter.TabIndex = 11
        '
        'udte_fec_ini
        '
        Me.udte_fec_ini.Location = New System.Drawing.Point(128, 59)
        Me.udte_fec_ini.Name = "udte_fec_ini"
        Me.udte_fec_ini.Size = New System.Drawing.Size(144, 21)
        Me.udte_fec_ini.TabIndex = 11
        '
        'uce_tipoContrato
        '
        Me.uce_tipoContrato.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.uce_tipoContrato.Location = New System.Drawing.Point(128, 21)
        Me.uce_tipoContrato.Name = "uce_tipoContrato"
        Me.uce_tipoContrato.Size = New System.Drawing.Size(274, 21)
        Me.uce_tipoContrato.TabIndex = 10
        '
        'UltraLabel3
        '
        Appearance5.BackColor = System.Drawing.Color.Transparent
        Appearance5.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel3.Appearance = Appearance5
        Me.UltraLabel3.AutoSize = True
        Me.UltraLabel3.Location = New System.Drawing.Point(19, 129)
        Me.UltraLabel3.Name = "UltraLabel3"
        Me.UltraLabel3.Size = New System.Drawing.Size(68, 14)
        Me.UltraLabel3.TabIndex = 9
        Me.UltraLabel3.Text = "Comentarios "
        '
        'UltraLabel2
        '
        Appearance1.BackColor = System.Drawing.Color.Transparent
        Appearance1.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel2.Appearance = Appearance1
        Me.UltraLabel2.AutoSize = True
        Me.UltraLabel2.Location = New System.Drawing.Point(19, 95)
        Me.UltraLabel2.Name = "UltraLabel2"
        Me.UltraLabel2.Size = New System.Drawing.Size(80, 14)
        Me.UltraLabel2.TabIndex = 9
        Me.UltraLabel2.Text = "Fecha Termino "
        '
        'UltraLabel1
        '
        Appearance2.BackColor = System.Drawing.Color.Transparent
        Appearance2.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel1.Appearance = Appearance2
        Me.UltraLabel1.AutoSize = True
        Me.UltraLabel1.Location = New System.Drawing.Point(19, 59)
        Me.UltraLabel1.Name = "UltraLabel1"
        Me.UltraLabel1.Size = New System.Drawing.Size(65, 14)
        Me.UltraLabel1.TabIndex = 9
        Me.UltraLabel1.Text = "Fecha Inicio "
        '
        'UltraLabel63
        '
        Appearance6.BackColor = System.Drawing.Color.Transparent
        Appearance6.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel63.Appearance = Appearance6
        Me.UltraLabel63.AutoSize = True
        Me.UltraLabel63.Location = New System.Drawing.Point(19, 25)
        Me.UltraLabel63.Name = "UltraLabel63"
        Me.UltraLabel63.Size = New System.Drawing.Size(88, 14)
        Me.UltraLabel63.TabIndex = 8
        Me.UltraLabel63.Text = "Tipo de Contrato "
        '
        'utc_contrato
        '
        Me.utc_contrato.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.utc_contrato.Controls.Add(Me.UltraTabSharedControlsPage1)
        Me.utc_contrato.Controls.Add(Me.UltraTabPageControl1)
        Me.utc_contrato.Controls.Add(Me.UltraTabPageControl2)
        Me.utc_contrato.Location = New System.Drawing.Point(12, 41)
        Me.utc_contrato.Name = "utc_contrato"
        Me.utc_contrato.SharedControlsPage = Me.UltraTabSharedControlsPage1
        Me.utc_contrato.Size = New System.Drawing.Size(714, 457)
        Me.utc_contrato.TabIndex = 0
        UltraTab1.TabPage = Me.UltraTabPageControl1
        UltraTab1.Text = "Listado de Contratos por Personal"
        UltraTab2.TabPage = Me.UltraTabPageControl2
        UltraTab2.Text = "Detalle de Contrato"
        Me.utc_contrato.Tabs.AddRange(New Infragistics.Win.UltraWinTabControl.UltraTab() {UltraTab1, UltraTab2})
        '
        'UltraTabSharedControlsPage1
        '
        Me.UltraTabSharedControlsPage1.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabSharedControlsPage1.Name = "UltraTabSharedControlsPage1"
        Me.UltraTabSharedControlsPage1.Size = New System.Drawing.Size(710, 431)
        '
        'ToolS_Mantenimiento
        '
        Me.ToolS_Mantenimiento.BackColor = System.Drawing.Color.White
        Me.ToolS_Mantenimiento.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Tool_Nuevo, Me.ToolStripSeparator1, Me.Tool_Grabar, Me.ToolStripSeparator3, Me.Tool_Editar, Me.ToolStripSeparator4, Me.Tool_Cancelar, Me.ToolStripSeparator2, Me.Tool_Eliminar, Me.ToolStripSeparator5, Me.Tool_Reporte, Me.ToolStripSeparator6, Me.Tool_Salir, Me.ToolStripSeparator7})
        Me.ToolS_Mantenimiento.Location = New System.Drawing.Point(0, 0)
        Me.ToolS_Mantenimiento.Name = "ToolS_Mantenimiento"
        Me.ToolS_Mantenimiento.Size = New System.Drawing.Size(738, 25)
        Me.ToolS_Mantenimiento.TabIndex = 6
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
        Me.Tool_Grabar.ToolTipText = "Grabar (F4)"
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
        'Tool_Reporte
        '
        Me.Tool_Reporte.Image = Global.Contabilidad.My.Resources.Resources._004
        Me.Tool_Reporte.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Tool_Reporte.Name = "Tool_Reporte"
        Me.Tool_Reporte.Size = New System.Drawing.Size(68, 22)
        Me.Tool_Reporte.Text = "Reporte"
        '
        'ToolStripSeparator6
        '
        Me.ToolStripSeparator6.Name = "ToolStripSeparator6"
        Me.ToolStripSeparator6.Size = New System.Drawing.Size(6, 25)
        '
        'Tool_Salir
        '
        Me.Tool_Salir.Image = Global.Contabilidad.My.Resources.Resources._28
        Me.Tool_Salir.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Tool_Salir.Name = "Tool_Salir"
        Me.Tool_Salir.Size = New System.Drawing.Size(49, 22)
        Me.Tool_Salir.Text = "Salir"
        '
        'ToolStripSeparator7
        '
        Me.ToolStripSeparator7.Name = "ToolStripSeparator7"
        Me.ToolStripSeparator7.Size = New System.Drawing.Size(6, 25)
        '
        'PL_PR_Contratos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(738, 510)
        Me.Controls.Add(Me.ToolS_Mantenimiento)
        Me.Controls.Add(Me.utc_contrato)
        Me.Name = "PL_PR_Contratos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Contratos de Personal"
        Me.UltraTabPageControl1.ResumeLayout(False)
        Me.UltraTabPageControl1.PerformLayout()
        CType(Me.ug_Detalle, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.uds_Detalle, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ug_Lista, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.uds_Lista, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabPageControl2.ResumeLayout(False)
        Me.gb1.ResumeLayout(False)
        Me.gb1.PerformLayout()
        CType(Me.txt_nombres, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_id_personal, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_cod_personal, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ugb_detalle, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ugb_detalle.ResumeLayout(False)
        Me.ugb_detalle.PerformLayout()
        CType(Me.une_id, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_comentario, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.udte_fec_ter, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.udte_fec_ini, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.uce_tipoContrato, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.utc_contrato, System.ComponentModel.ISupportInitialize).EndInit()
        Me.utc_contrato.ResumeLayout(False)
        Me.ToolS_Mantenimiento.ResumeLayout(False)
        Me.ToolS_Mantenimiento.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents utc_contrato As Infragistics.Win.UltraWinTabControl.UltraTabControl
    Friend WithEvents UltraTabSharedControlsPage1 As Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage
    Friend WithEvents UltraTabPageControl1 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents UltraTabPageControl2 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents ugb_detalle As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents UltraLabel63 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel3 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel2 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel1 As Infragistics.Win.Misc.UltraLabel
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
    Friend WithEvents Tool_Reporte As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator6 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents Tool_Salir As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator7 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents txt_comentario As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents udte_fec_ter As Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
    Friend WithEvents udte_fec_ini As Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
    Friend WithEvents uce_tipoContrato As Infragistics.Win.UltraWinEditors.UltraComboEditor
    Friend WithEvents ug_Lista As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents uds_Lista As Infragistics.Win.UltraWinDataSource.UltraDataSource
    Friend WithEvents uds_Detalle As Infragistics.Win.UltraWinDataSource.UltraDataSource
    Friend WithEvents ubtn_Generar_Contrato As Infragistics.Win.Misc.UltraButton
    Friend WithEvents ug_Detalle As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents une_id As Infragistics.Win.UltraWinEditors.UltraNumericEditor
    Friend WithEvents gb1 As System.Windows.Forms.GroupBox
    Friend WithEvents txt_nombres As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents txt_id_personal As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents txt_cod_personal As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents UltraLabel10 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents lbl_titulo As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents ubtn_atraz As Infragistics.Win.Misc.UltraButton
End Class
