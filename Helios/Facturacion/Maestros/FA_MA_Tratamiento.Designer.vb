<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FA_MA_Tratamiento
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
        Dim UltraGridColumn1 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("PC_ID")
        Dim UltraGridColumn2 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("PC_DESCRIPCION")
        Dim UltraGridColumn3 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("PC_CuentaCont")
        Dim UltraGridColumn4 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("PC_IDArticulo")
        Dim UltraGridColumn5 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("PC_ESTADO")
        Dim Appearance7 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraDataColumn1 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("PC_ID")
        Dim UltraDataColumn2 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("PC_DESCRIPCION")
        Dim UltraDataColumn3 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("PC_CuentaCont")
        Dim UltraDataColumn4 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("PC_IDArticulo")
        Dim UltraDataColumn5 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("PC_ESTADO")
        Dim ValueListItem2 As Infragistics.Win.ValueListItem = New Infragistics.Win.ValueListItem()
        Dim ValueListItem3 As Infragistics.Win.ValueListItem = New Infragistics.Win.ValueListItem()
        Dim Appearance11 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance6 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim EditorButton1 As Infragistics.Win.UltraWinEditors.EditorButton = New Infragistics.Win.UltraWinEditors.EditorButton("ayuda")
        Dim Appearance4 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance1 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance8 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridBand2 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1)
        Dim UltraGridColumn6 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("SEL")
        Dim UltraGridColumn7 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("AR_ID")
        Dim UltraGridColumn8 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FA_DESCRIPCION")
        Dim UltraGridColumn9 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CA_DESCRIPCION")
        Dim UltraGridColumn10 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("AR_DESCRIPCION")
        Dim UltraGridColumn11 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("PD_CANTIDAD")
        Dim Appearance3 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraDataColumn6 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("SEL")
        Dim UltraDataColumn7 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("AR_ID")
        Dim UltraDataColumn8 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("FA_DESCRIPCION")
        Dim UltraDataColumn9 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("CA_DESCRIPCION")
        Dim UltraDataColumn10 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("AR_DESCRIPCION")
        Dim UltraDataColumn11 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("PD_CANTIDAD")
        Dim Appearance2 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridBand3 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1)
        Dim UltraGridColumn12 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Sel")
        Dim UltraGridColumn13 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("AR_ID")
        Dim UltraGridColumn14 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FA_DESCRIPCION")
        Dim UltraGridColumn15 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CA_DESCRIPCION")
        Dim UltraGridColumn16 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("AR_DESCRIPCION")
        Dim Appearance5 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraDataColumn12 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Sel")
        Dim UltraDataColumn13 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("AR_ID")
        Dim UltraDataColumn14 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("FA_DESCRIPCION")
        Dim UltraDataColumn15 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("CA_DESCRIPCION")
        Dim UltraDataColumn16 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("AR_DESCRIPCION")
        Dim Appearance9 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraTab1 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraTab2 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Me.UltraTabPageControl1 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.ug_Lista = New Infragistics.Win.UltraWinGrid.UltraGrid()
        Me.uds_Lista = New Infragistics.Win.UltraWinDataSource.UltraDataSource(Me.components)
        Me.UltraTabPageControl2 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.ugb_datos = New Infragistics.Win.Misc.UltraGroupBox()
        Me.uos_Estado = New Infragistics.Win.UltraWinEditors.UltraOptionSet()
        Me.UltraLabel8 = New Infragistics.Win.Misc.UltraLabel()
        Me.txt_IDArt = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.UltraLabel5 = New Infragistics.Win.Misc.UltraLabel()
        Me.txt_Des_Articulo = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.txt_IDArticulo = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.ubt_Quitar = New Infragistics.Win.Misc.UltraButton()
        Me.ubt_Agregar = New Infragistics.Win.Misc.UltraButton()
        Me.UltraLabel4 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraLabel3 = New Infragistics.Win.Misc.UltraLabel()
        Me.ug_ArticulosTra = New Infragistics.Win.UltraWinGrid.UltraGrid()
        Me.uds_ListaArticuloT = New Infragistics.Win.UltraWinDataSource.UltraDataSource(Me.components)
        Me.txt_CuentaCon = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.UltraLabel1 = New Infragistics.Win.Misc.UltraLabel()
        Me.ug_intervalos = New Infragistics.Win.UltraWinGrid.UltraGrid()
        Me.uds_ListaME = New Infragistics.Win.UltraWinDataSource.UltraDataSource(Me.components)
        Me.txt_Nombre = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.UltraLabel2 = New Infragistics.Win.Misc.UltraLabel()
        Me.txt_idTratamiento = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.utc_Datos = New Infragistics.Win.UltraWinTabControl.UltraTabControl()
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
        Me.Tool_Salir = New System.Windows.Forms.ToolStripButton()
        Me.UltraTabPageControl1.SuspendLayout()
        CType(Me.ug_Lista, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.uds_Lista, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabPageControl2.SuspendLayout()
        CType(Me.ugb_datos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ugb_datos.SuspendLayout()
        CType(Me.uos_Estado, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_IDArt, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_Des_Articulo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_IDArticulo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ug_ArticulosTra, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.uds_ListaArticuloT, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_CuentaCon, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ug_intervalos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.uds_ListaME, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_Nombre, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_idTratamiento, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.utc_Datos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.utc_Datos.SuspendLayout()
        Me.ToolS_Mantenimiento.SuspendLayout()
        Me.SuspendLayout()
        '
        'UltraTabPageControl1
        '
        Me.UltraTabPageControl1.Controls.Add(Me.ug_Lista)
        Me.UltraTabPageControl1.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl1.Name = "UltraTabPageControl1"
        Me.UltraTabPageControl1.Size = New System.Drawing.Size(1061, 473)
        '
        'ug_Lista
        '
        Me.ug_Lista.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ug_Lista.DataSource = Me.uds_Lista
        Me.ug_Lista.DisplayLayout.AutoFitStyle = Infragistics.Win.UltraWinGrid.AutoFitStyle.ExtendLastColumn
        UltraGridColumn1.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn1.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn1.Header.Caption = "CODIGO"
        UltraGridColumn1.Header.VisiblePosition = 0
        UltraGridColumn1.Width = 137
        UltraGridColumn2.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn2.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn2.Header.Caption = "Tratamiento"
        UltraGridColumn2.Header.VisiblePosition = 1
        UltraGridColumn2.Width = 681
        UltraGridColumn3.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn3.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn3.Header.Caption = "Cuenta Cont."
        UltraGridColumn3.Header.VisiblePosition = 2
        UltraGridColumn3.Width = 100
        UltraGridColumn4.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn4.Header.VisiblePosition = 3
        UltraGridColumn4.Hidden = True
        UltraGridColumn5.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn5.Header.VisiblePosition = 4
        UltraGridColumn5.Hidden = True
        UltraGridBand1.Columns.AddRange(New Object() {UltraGridColumn1, UltraGridColumn2, UltraGridColumn3, UltraGridColumn4, UltraGridColumn5})
        Me.ug_Lista.DisplayLayout.BandsSerializer.Add(UltraGridBand1)
        Me.ug_Lista.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.[False]
        Me.ug_Lista.DisplayLayout.MaxColScrollRegions = 1
        Me.ug_Lista.DisplayLayout.MaxRowScrollRegions = 1
        Me.ug_Lista.DisplayLayout.Override.FilterUIType = Infragistics.Win.UltraWinGrid.FilterUIType.FilterRow
        Appearance7.BackColor = System.Drawing.Color.WhiteSmoke
        Appearance7.BackColor2 = System.Drawing.Color.WhiteSmoke
        Me.ug_Lista.DisplayLayout.Override.RowAlternateAppearance = Appearance7
        Me.ug_Lista.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.ug_Lista.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.ug_Lista.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ug_Lista.Location = New System.Drawing.Point(0, 0)
        Me.ug_Lista.Name = "ug_Lista"
        Me.ug_Lista.Size = New System.Drawing.Size(1035, 473)
        Me.ug_Lista.TabIndex = 0
        Me.ug_Lista.Text = "UltraGrid1"
        '
        'uds_Lista
        '
        Me.uds_Lista.AllowDelete = False
        UltraDataColumn1.DataType = GetType(Long)
        UltraDataColumn4.DataType = GetType(Integer)
        UltraDataColumn5.DataType = GetType(Integer)
        Me.uds_Lista.Band.Columns.AddRange(New Object() {UltraDataColumn1, UltraDataColumn2, UltraDataColumn3, UltraDataColumn4, UltraDataColumn5})
        '
        'UltraTabPageControl2
        '
        Me.UltraTabPageControl2.Controls.Add(Me.ugb_datos)
        Me.UltraTabPageControl2.Location = New System.Drawing.Point(1, 23)
        Me.UltraTabPageControl2.Name = "UltraTabPageControl2"
        Me.UltraTabPageControl2.Size = New System.Drawing.Size(1061, 473)
        '
        'ugb_datos
        '
        Me.ugb_datos.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ugb_datos.Controls.Add(Me.uos_Estado)
        Me.ugb_datos.Controls.Add(Me.UltraLabel8)
        Me.ugb_datos.Controls.Add(Me.txt_IDArt)
        Me.ugb_datos.Controls.Add(Me.UltraLabel5)
        Me.ugb_datos.Controls.Add(Me.txt_Des_Articulo)
        Me.ugb_datos.Controls.Add(Me.txt_IDArticulo)
        Me.ugb_datos.Controls.Add(Me.ubt_Quitar)
        Me.ugb_datos.Controls.Add(Me.ubt_Agregar)
        Me.ugb_datos.Controls.Add(Me.UltraLabel4)
        Me.ugb_datos.Controls.Add(Me.UltraLabel3)
        Me.ugb_datos.Controls.Add(Me.ug_ArticulosTra)
        Me.ugb_datos.Controls.Add(Me.txt_CuentaCon)
        Me.ugb_datos.Controls.Add(Me.UltraLabel1)
        Me.ugb_datos.Controls.Add(Me.ug_intervalos)
        Me.ugb_datos.Controls.Add(Me.txt_Nombre)
        Me.ugb_datos.Controls.Add(Me.UltraLabel2)
        Me.ugb_datos.Controls.Add(Me.txt_idTratamiento)
        Me.ugb_datos.Location = New System.Drawing.Point(1, 3)
        Me.ugb_datos.Name = "ugb_datos"
        Me.ugb_datos.Size = New System.Drawing.Size(1057, 467)
        Me.ugb_datos.TabIndex = 0
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
        Me.uos_Estado.Location = New System.Drawing.Point(899, 17)
        Me.uos_Estado.Name = "uos_Estado"
        Me.uos_Estado.Size = New System.Drawing.Size(111, 21)
        Me.uos_Estado.TabIndex = 219
        Me.uos_Estado.Text = "Activo"
        '
        'UltraLabel8
        '
        Appearance11.BackColor = System.Drawing.Color.Transparent
        Appearance11.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel8.Appearance = Appearance11
        Me.UltraLabel8.AutoSize = True
        Me.UltraLabel8.Location = New System.Drawing.Point(853, 17)
        Me.UltraLabel8.Name = "UltraLabel8"
        Me.UltraLabel8.Size = New System.Drawing.Size(39, 14)
        Me.UltraLabel8.TabIndex = 218
        Me.UltraLabel8.Text = "Estado"
        '
        'txt_IDArt
        '
        Me.txt_IDArt.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_IDArt.Location = New System.Drawing.Point(813, 14)
        Me.txt_IDArt.MaxLength = 50
        Me.txt_IDArt.Name = "txt_IDArt"
        Me.txt_IDArt.ReadOnly = True
        Me.txt_IDArt.Size = New System.Drawing.Size(28, 21)
        Me.txt_IDArt.TabIndex = 217
        Me.txt_IDArt.Visible = False
        '
        'UltraLabel5
        '
        Appearance6.BackColor = System.Drawing.Color.Transparent
        Appearance6.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel5.Appearance = Appearance6
        Me.UltraLabel5.AutoSize = True
        Me.UltraLabel5.Location = New System.Drawing.Point(17, 17)
        Me.UltraLabel5.Name = "UltraLabel5"
        Me.UltraLabel5.Size = New System.Drawing.Size(42, 14)
        Me.UltraLabel5.TabIndex = 216
        Me.UltraLabel5.Text = "Articulo"
        '
        'txt_Des_Articulo
        '
        Me.txt_Des_Articulo.Location = New System.Drawing.Point(195, 14)
        Me.txt_Des_Articulo.Name = "txt_Des_Articulo"
        Me.txt_Des_Articulo.ReadOnly = True
        Me.txt_Des_Articulo.Size = New System.Drawing.Size(612, 21)
        Me.txt_Des_Articulo.TabIndex = 215
        '
        'txt_IDArticulo
        '
        Appearance4.ImageHAlign = Infragistics.Win.HAlign.Center
        Appearance4.ImageVAlign = Infragistics.Win.VAlign.Middle
        EditorButton1.Appearance = Appearance4
        EditorButton1.Key = "ayuda"
        Me.txt_IDArticulo.ButtonsRight.Add(EditorButton1)
        Me.txt_IDArticulo.Location = New System.Drawing.Point(85, 14)
        Me.txt_IDArticulo.MaxLength = 11
        Me.txt_IDArticulo.Name = "txt_IDArticulo"
        Me.txt_IDArticulo.Size = New System.Drawing.Size(104, 21)
        Me.txt_IDArticulo.TabIndex = 1
        '
        'ubt_Quitar
        '
        Me.ubt_Quitar.Location = New System.Drawing.Point(539, 246)
        Me.ubt_Quitar.Name = "ubt_Quitar"
        Me.ubt_Quitar.Size = New System.Drawing.Size(29, 24)
        Me.ubt_Quitar.TabIndex = 6
        Me.ubt_Quitar.Text = "<<"
        '
        'ubt_Agregar
        '
        Me.ubt_Agregar.Location = New System.Drawing.Point(539, 216)
        Me.ubt_Agregar.Name = "ubt_Agregar"
        Me.ubt_Agregar.Size = New System.Drawing.Size(29, 24)
        Me.ubt_Agregar.TabIndex = 5
        Me.ubt_Agregar.Text = ">>"
        '
        'UltraLabel4
        '
        Me.UltraLabel4.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Appearance1.BackColor = System.Drawing.Color.FromArgb(CType(CType(189, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(236, Byte), Integer))
        Appearance1.ForeColor = System.Drawing.Color.Navy
        Appearance1.TextHAlignAsString = "Center"
        Appearance1.TextVAlignAsString = "Middle"
        Me.UltraLabel4.Appearance = Appearance1
        Me.UltraLabel4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel4.Location = New System.Drawing.Point(571, 68)
        Me.UltraLabel4.Name = "UltraLabel4"
        Me.UltraLabel4.Size = New System.Drawing.Size(478, 23)
        Me.UltraLabel4.TabIndex = 43
        Me.UltraLabel4.Text = "Lista de Articulos del Tratamiento"
        '
        'UltraLabel3
        '
        Appearance8.BackColor = System.Drawing.Color.FromArgb(CType(CType(189, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(236, Byte), Integer))
        Appearance8.ForeColor = System.Drawing.Color.Navy
        Appearance8.TextHAlignAsString = "Center"
        Appearance8.TextVAlignAsString = "Middle"
        Me.UltraLabel3.Appearance = Appearance8
        Me.UltraLabel3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel3.Location = New System.Drawing.Point(3, 69)
        Me.UltraLabel3.Name = "UltraLabel3"
        Me.UltraLabel3.Size = New System.Drawing.Size(531, 23)
        Me.UltraLabel3.TabIndex = 42
        Me.UltraLabel3.Text = "Lista de Todos Los Articulos"
        '
        'ug_ArticulosTra
        '
        Me.ug_ArticulosTra.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ug_ArticulosTra.DataSource = Me.uds_ListaArticuloT
        Me.ug_ArticulosTra.DisplayLayout.AutoFitStyle = Infragistics.Win.UltraWinGrid.AutoFitStyle.ExtendLastColumn
        UltraGridColumn6.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn6.Header.VisiblePosition = 0
        UltraGridColumn6.Hidden = True
        UltraGridColumn6.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.CheckBox
        UltraGridColumn7.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn7.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn7.Header.Caption = "CODIGO"
        UltraGridColumn7.Header.VisiblePosition = 1
        UltraGridColumn7.Hidden = True
        UltraGridColumn7.Width = 60
        UltraGridColumn8.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn8.Header.Caption = "FAMILIA"
        UltraGridColumn8.Header.VisiblePosition = 2
        UltraGridColumn8.Width = 92
        UltraGridColumn9.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn9.Header.Caption = "CATEGORIA"
        UltraGridColumn9.Header.VisiblePosition = 3
        UltraGridColumn9.Width = 94
        UltraGridColumn10.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn10.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn10.Header.Caption = "DESCRIPCION"
        UltraGridColumn10.Header.VisiblePosition = 4
        UltraGridColumn10.Width = 230
        UltraGridColumn11.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn11.Header.Caption = "CANT."
        UltraGridColumn11.Header.VisiblePosition = 5
        UltraGridColumn11.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Integer]
        UltraGridColumn11.Width = 30
        UltraGridBand2.Columns.AddRange(New Object() {UltraGridColumn6, UltraGridColumn7, UltraGridColumn8, UltraGridColumn9, UltraGridColumn10, UltraGridColumn11})
        Me.ug_ArticulosTra.DisplayLayout.BandsSerializer.Add(UltraGridBand2)
        Me.ug_ArticulosTra.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.[False]
        Me.ug_ArticulosTra.DisplayLayout.MaxColScrollRegions = 1
        Me.ug_ArticulosTra.DisplayLayout.MaxRowScrollRegions = 1
        Appearance3.BackColor = System.Drawing.Color.WhiteSmoke
        Appearance3.BackColor2 = System.Drawing.Color.WhiteSmoke
        Me.ug_ArticulosTra.DisplayLayout.Override.RowAlternateAppearance = Appearance3
        Me.ug_ArticulosTra.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.ug_ArticulosTra.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.ug_ArticulosTra.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ug_ArticulosTra.Location = New System.Drawing.Point(571, 91)
        Me.ug_ArticulosTra.Name = "ug_ArticulosTra"
        Me.ug_ArticulosTra.Size = New System.Drawing.Size(478, 370)
        Me.ug_ArticulosTra.TabIndex = 7
        Me.ug_ArticulosTra.Text = "UltraGrid1"
        '
        'uds_ListaArticuloT
        '
        Me.uds_ListaArticuloT.AllowDelete = False
        UltraDataColumn6.DataType = GetType(Integer)
        UltraDataColumn7.DataType = GetType(Integer)
        UltraDataColumn11.DataType = GetType(Integer)
        Me.uds_ListaArticuloT.Band.Columns.AddRange(New Object() {UltraDataColumn6, UltraDataColumn7, UltraDataColumn8, UltraDataColumn9, UltraDataColumn10, UltraDataColumn11})
        '
        'txt_CuentaCon
        '
        Me.txt_CuentaCon.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_CuentaCon.Location = New System.Drawing.Point(904, 41)
        Me.txt_CuentaCon.MaxLength = 100
        Me.txt_CuentaCon.Name = "txt_CuentaCon"
        Me.txt_CuentaCon.Size = New System.Drawing.Size(106, 21)
        Me.txt_CuentaCon.TabIndex = 3
        '
        'UltraLabel1
        '
        Appearance2.BackColor = System.Drawing.Color.Transparent
        Appearance2.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel1.Appearance = Appearance2
        Me.UltraLabel1.AutoSize = True
        Me.UltraLabel1.Location = New System.Drawing.Point(824, 44)
        Me.UltraLabel1.Name = "UltraLabel1"
        Me.UltraLabel1.Size = New System.Drawing.Size(77, 14)
        Me.UltraLabel1.TabIndex = 40
        Me.UltraLabel1.Text = "Cuenta Conta:"
        '
        'ug_intervalos
        '
        Me.ug_intervalos.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.ug_intervalos.DataSource = Me.uds_ListaME
        Me.ug_intervalos.DisplayLayout.AutoFitStyle = Infragistics.Win.UltraWinGrid.AutoFitStyle.ExtendLastColumn
        UltraGridColumn12.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn12.Header.VisiblePosition = 0
        UltraGridColumn12.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.CheckBox
        UltraGridColumn13.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn13.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn13.Header.Caption = "CODIGO"
        UltraGridColumn13.Header.VisiblePosition = 1
        UltraGridColumn13.Hidden = True
        UltraGridColumn13.Width = 60
        UltraGridColumn14.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn14.Header.Caption = "FAMILIA"
        UltraGridColumn14.Header.VisiblePosition = 2
        UltraGridColumn15.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn15.Header.Caption = "CATEGORIA"
        UltraGridColumn15.Header.VisiblePosition = 3
        UltraGridColumn16.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn16.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn16.Header.Caption = "DESCRIPCION"
        UltraGridColumn16.Header.VisiblePosition = 4
        UltraGridColumn16.Width = 200
        UltraGridBand3.Columns.AddRange(New Object() {UltraGridColumn12, UltraGridColumn13, UltraGridColumn14, UltraGridColumn15, UltraGridColumn16})
        Me.ug_intervalos.DisplayLayout.BandsSerializer.Add(UltraGridBand3)
        Me.ug_intervalos.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.[False]
        Me.ug_intervalos.DisplayLayout.MaxColScrollRegions = 1
        Me.ug_intervalos.DisplayLayout.MaxRowScrollRegions = 1
        Me.ug_intervalos.DisplayLayout.Override.FilterOperatorDefaultValue = Infragistics.Win.UltraWinGrid.FilterOperatorDefaultValue.Contains
        Me.ug_intervalos.DisplayLayout.Override.FilterUIType = Infragistics.Win.UltraWinGrid.FilterUIType.FilterRow
        Appearance5.BackColor = System.Drawing.Color.WhiteSmoke
        Appearance5.BackColor2 = System.Drawing.Color.WhiteSmoke
        Me.ug_intervalos.DisplayLayout.Override.RowAlternateAppearance = Appearance5
        Me.ug_intervalos.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.ug_intervalos.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.ug_intervalos.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ug_intervalos.Location = New System.Drawing.Point(3, 92)
        Me.ug_intervalos.Name = "ug_intervalos"
        Me.ug_intervalos.Size = New System.Drawing.Size(532, 370)
        Me.ug_intervalos.TabIndex = 4
        Me.ug_intervalos.Text = "UltraGrid1"
        '
        'uds_ListaME
        '
        Me.uds_ListaME.AllowDelete = False
        UltraDataColumn12.DataType = GetType(Boolean)
        UltraDataColumn13.DataType = GetType(Integer)
        Me.uds_ListaME.Band.Columns.AddRange(New Object() {UltraDataColumn12, UltraDataColumn13, UltraDataColumn14, UltraDataColumn15, UltraDataColumn16})
        '
        'txt_Nombre
        '
        Me.txt_Nombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_Nombre.Location = New System.Drawing.Point(85, 41)
        Me.txt_Nombre.MaxLength = 100
        Me.txt_Nombre.Name = "txt_Nombre"
        Me.txt_Nombre.Size = New System.Drawing.Size(722, 21)
        Me.txt_Nombre.TabIndex = 2
        '
        'UltraLabel2
        '
        Appearance9.BackColor = System.Drawing.Color.Transparent
        Appearance9.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel2.Appearance = Appearance9
        Me.UltraLabel2.AutoSize = True
        Me.UltraLabel2.Location = New System.Drawing.Point(15, 44)
        Me.UltraLabel2.Name = "UltraLabel2"
        Me.UltraLabel2.Size = New System.Drawing.Size(65, 14)
        Me.UltraLabel2.TabIndex = 23
        Me.UltraLabel2.Text = "Tratamiento"
        '
        'txt_idTratamiento
        '
        Me.txt_idTratamiento.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_idTratamiento.Location = New System.Drawing.Point(969, 42)
        Me.txt_idTratamiento.MaxLength = 50
        Me.txt_idTratamiento.Name = "txt_idTratamiento"
        Me.txt_idTratamiento.ReadOnly = True
        Me.txt_idTratamiento.Size = New System.Drawing.Size(28, 21)
        Me.txt_idTratamiento.TabIndex = 0
        Me.txt_idTratamiento.Visible = False
        '
        'utc_Datos
        '
        Me.utc_Datos.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.utc_Datos.Controls.Add(Me.UltraTabSharedControlsPage1)
        Me.utc_Datos.Controls.Add(Me.UltraTabPageControl1)
        Me.utc_Datos.Controls.Add(Me.UltraTabPageControl2)
        Me.utc_Datos.Location = New System.Drawing.Point(4, 30)
        Me.utc_Datos.Name = "utc_Datos"
        Me.utc_Datos.SharedControlsPage = Me.UltraTabSharedControlsPage1
        Me.utc_Datos.Size = New System.Drawing.Size(1065, 499)
        Me.utc_Datos.TabIndex = 17
        UltraTab1.TabPage = Me.UltraTabPageControl1
        UltraTab1.Text = "Lista"
        UltraTab2.TabPage = Me.UltraTabPageControl2
        UltraTab2.Text = "Ingreso / Edicion de Datos"
        Me.utc_Datos.Tabs.AddRange(New Infragistics.Win.UltraWinTabControl.UltraTab() {UltraTab1, UltraTab2})
        '
        'UltraTabSharedControlsPage1
        '
        Me.UltraTabSharedControlsPage1.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabSharedControlsPage1.Name = "UltraTabSharedControlsPage1"
        Me.UltraTabSharedControlsPage1.Size = New System.Drawing.Size(1061, 473)
        '
        'ToolS_Mantenimiento
        '
        Me.ToolS_Mantenimiento.BackColor = System.Drawing.Color.White
        Me.ToolS_Mantenimiento.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Tool_Nuevo, Me.ToolStripSeparator1, Me.Tool_Grabar, Me.ToolStripSeparator3, Me.Tool_Editar, Me.ToolStripSeparator4, Me.Tool_Cancelar, Me.ToolStripSeparator2, Me.Tool_Eliminar, Me.ToolStripSeparator5, Me.Tool_Salir})
        Me.ToolS_Mantenimiento.Location = New System.Drawing.Point(0, 0)
        Me.ToolS_Mantenimiento.Name = "ToolS_Mantenimiento"
        Me.ToolS_Mantenimiento.Size = New System.Drawing.Size(1071, 25)
        Me.ToolS_Mantenimiento.TabIndex = 16
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
        'FA_MA_Tratamiento
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1071, 530)
        Me.Controls.Add(Me.utc_Datos)
        Me.Controls.Add(Me.ToolS_Mantenimiento)
        Me.Name = "FA_MA_Tratamiento"
        Me.Text = "TRATAMIENTOS"
        Me.UltraTabPageControl1.ResumeLayout(False)
        CType(Me.ug_Lista, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.uds_Lista, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabPageControl2.ResumeLayout(False)
        CType(Me.ugb_datos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ugb_datos.ResumeLayout(False)
        Me.ugb_datos.PerformLayout()
        CType(Me.uos_Estado, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_IDArt, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_Des_Articulo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_IDArticulo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ug_ArticulosTra, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.uds_ListaArticuloT, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_CuentaCon, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ug_intervalos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.uds_ListaME, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_Nombre, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_idTratamiento, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.utc_Datos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.utc_Datos.ResumeLayout(False)
        Me.ToolS_Mantenimiento.ResumeLayout(False)
        Me.ToolS_Mantenimiento.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents utc_Datos As Infragistics.Win.UltraWinTabControl.UltraTabControl
    Friend WithEvents UltraTabSharedControlsPage1 As Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage
    Friend WithEvents UltraTabPageControl1 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents ug_Lista As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents uds_Lista As Infragistics.Win.UltraWinDataSource.UltraDataSource
    Friend WithEvents UltraTabPageControl2 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents ugb_datos As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents txt_Nombre As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents UltraLabel2 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents txt_idTratamiento As Infragistics.Win.UltraWinEditors.UltraTextEditor
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
    Public WithEvents ug_intervalos As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents uds_ListaME As Infragistics.Win.UltraWinDataSource.UltraDataSource
    Friend WithEvents txt_CuentaCon As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents UltraLabel1 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel4 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel3 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents ubt_Quitar As Infragistics.Win.Misc.UltraButton
    Friend WithEvents ubt_Agregar As Infragistics.Win.Misc.UltraButton
    Friend WithEvents uds_ListaArticuloT As Infragistics.Win.UltraWinDataSource.UltraDataSource
    Public WithEvents ug_ArticulosTra As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents UltraLabel5 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents txt_Des_Articulo As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents txt_IDArticulo As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents txt_IDArt As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents uos_Estado As Infragistics.Win.UltraWinEditors.UltraOptionSet
    Friend WithEvents UltraLabel8 As Infragistics.Win.Misc.UltraLabel
End Class
