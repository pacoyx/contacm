<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BB_LT_RegConsumoFar
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
        Dim Appearance33 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance4 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance21 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridBand1 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1)
        Dim UltraGridColumn1 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CM_ID")
        Dim UltraGridColumn2 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("AL_DESCRIPCION")
        Dim UltraGridColumn3 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CM_TDOC")
        Dim UltraGridColumn4 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CM_SDOC")
        Dim UltraGridColumn5 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CM_NDOC")
        Dim UltraGridColumn6 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CM_IDALMACEN")
        Dim UltraGridColumn7 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CM_IDCUENTA")
        Dim UltraGridColumn8 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CM_IDNUM_HIST")
        Dim UltraGridColumn9 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("PACIENTE")
        Dim UltraGridColumn10 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CM_TOTAL")
        Dim UltraGridColumn11 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CM_FECHA")
        Dim UltraGridColumn12 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CM_ESTADO")
        Dim UltraGridColumn13 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ESTADO")
        Dim UltraGridColumn14 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CM_ESTADO_DOC")
        Dim Appearance9 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraDataColumn1 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("CM_ID")
        Dim UltraDataColumn2 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("AL_DESCRIPCION")
        Dim UltraDataColumn3 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("CM_TDOC")
        Dim UltraDataColumn4 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("CM_SDOC")
        Dim UltraDataColumn5 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("CM_NDOC")
        Dim UltraDataColumn6 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("CM_IDALMACEN")
        Dim UltraDataColumn7 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("CM_IDCUENTA")
        Dim UltraDataColumn8 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("CM_IDNUM_HIST")
        Dim UltraDataColumn9 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("PACIENTE")
        Dim UltraDataColumn10 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("CM_TOTAL")
        Dim UltraDataColumn11 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("CM_FECHA")
        Dim UltraDataColumn12 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("CM_ESTADO")
        Dim UltraDataColumn13 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("ESTADO")
        Dim UltraDataColumn14 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("CM_ESTADO_DOC")
        Dim ValueListItem2 As Infragistics.Win.ValueListItem = New Infragistics.Win.ValueListItem()
        Dim ValueListItem3 As Infragistics.Win.ValueListItem = New Infragistics.Win.ValueListItem()
        Dim ValueListItem1 As Infragistics.Win.ValueListItem = New Infragistics.Win.ValueListItem()
        Dim Appearance3 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance11 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance37 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance12 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridBand2 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1)
        Dim UltraGridColumn15 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("DC_ITEM")
        Dim Appearance1 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn16 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("DC_IDARTICULO")
        Dim Appearance2 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn17 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("AR_DESCRIPCION")
        Dim UltraGridColumn18 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("UM_DESCRIPCION")
        Dim Appearance5 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn19 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("DC_IDLOTE")
        Dim UltraGridColumn20 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("DC_PRECIO")
        Dim UltraGridColumn21 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("DC_CANT")
        Dim Appearance6 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance7 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn22 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("DC_TOTAL")
        Dim UltraGridColumn23 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("DC_SEG_CUBRE")
        Dim UltraGridColumn24 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("DC_Trans")
        Dim UltraGridColumn25 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("DS_SALDO")
        Dim UltraDataColumn15 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("DC_ITEM")
        Dim UltraDataColumn16 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("DC_IDARTICULO")
        Dim UltraDataColumn17 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("AR_DESCRIPCION")
        Dim UltraDataColumn18 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("UM_DESCRIPCION")
        Dim UltraDataColumn19 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("DC_IDLOTE")
        Dim UltraDataColumn20 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("DC_PRECIO")
        Dim UltraDataColumn21 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("DC_CANT")
        Dim UltraDataColumn22 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("DC_TOTAL")
        Dim UltraDataColumn23 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("DC_SEG_CUBRE")
        Dim UltraDataColumn24 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("DC_Trans")
        Dim UltraDataColumn25 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("DS_SALDO")
        Dim Appearance18 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance20 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraTab1 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraTab2 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Me.UltraTabPageControl1 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.uce_Almacen = New Infragistics.Win.UltraWinEditors.UltraComboEditor()
        Me.UltraLabel10 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraLabel3 = New Infragistics.Win.Misc.UltraLabel()
        Me.txt_IDCUENTA = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.txt_bebe = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.UltraLabel5 = New Infragistics.Win.Misc.UltraLabel()
        Me.ug_Lista = New Infragistics.Win.UltraWinGrid.UltraGrid()
        Me.uds_Lista = New Infragistics.Win.UltraWinDataSource.UltraDataSource(Me.components)
        Me.UltraTabPageControl2 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.ugb_Datos = New Infragistics.Win.Misc.UltraGroupBox()
        Me.ucbo_Estado = New Infragistics.Win.UltraWinEditors.UltraComboEditor()
        Me.txtIDSeguro = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.txt_idConsumo = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.uce_Serie = New Infragistics.Win.UltraWinEditors.UltraComboEditor()
        Me.uce_TipoDoc = New Infragistics.Win.UltraWinEditors.UltraComboEditor()
        Me.txt_NumDoc = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.UltraLabel9 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraLabel7 = New Infragistics.Win.Misc.UltraLabel()
        Me.uce_tip_doc = New Infragistics.Win.UltraWinEditors.UltraComboEditor()
        Me.txt_Des_Cliente = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.txt_ruc_cliente = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.UltraLabel20 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraLabel4 = New Infragistics.Win.Misc.UltraLabel()
        Me.txt_idHistoria = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.ug_detalle = New Infragistics.Win.UltraWinGrid.UltraGrid()
        Me.uds_detalle = New Infragistics.Win.UltraWinDataSource.UltraDataSource(Me.components)
        Me.ubt_Quitar = New Infragistics.Win.Misc.UltraButton()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.UltraLabel2 = New Infragistics.Win.Misc.UltraLabel()
        Me.udte_fecha = New Infragistics.Win.UltraWinEditors.UltraDateTimeEditor()
        Me.ubt_Agregar = New Infragistics.Win.Misc.UltraButton()
        Me.UltraLabel1 = New Infragistics.Win.Misc.UltraLabel()
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
        Me.txt_idRegistro = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.UltraTabPageControl1.SuspendLayout()
        CType(Me.uce_Almacen, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_IDCUENTA, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_bebe, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ug_Lista, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.uds_Lista, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabPageControl2.SuspendLayout()
        CType(Me.ugb_Datos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ugb_Datos.SuspendLayout()
        CType(Me.ucbo_Estado, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtIDSeguro, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_idConsumo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.uce_Serie, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.uce_TipoDoc, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_NumDoc, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.uce_tip_doc, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_Des_Cliente, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_ruc_cliente, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_idHistoria, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ug_detalle, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.uds_detalle, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.udte_fecha, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.utc_Datos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.utc_Datos.SuspendLayout()
        Me.ToolS_Mantenimiento.SuspendLayout()
        CType(Me.txt_idRegistro, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'UltraTabPageControl1
        '
        Me.UltraTabPageControl1.Controls.Add(Me.txt_idRegistro)
        Me.UltraTabPageControl1.Controls.Add(Me.uce_Almacen)
        Me.UltraTabPageControl1.Controls.Add(Me.UltraLabel10)
        Me.UltraTabPageControl1.Controls.Add(Me.UltraLabel3)
        Me.UltraTabPageControl1.Controls.Add(Me.txt_IDCUENTA)
        Me.UltraTabPageControl1.Controls.Add(Me.txt_bebe)
        Me.UltraTabPageControl1.Controls.Add(Me.UltraLabel5)
        Me.UltraTabPageControl1.Controls.Add(Me.ug_Lista)
        Me.UltraTabPageControl1.Location = New System.Drawing.Point(1, 23)
        Me.UltraTabPageControl1.Name = "UltraTabPageControl1"
        Me.UltraTabPageControl1.Size = New System.Drawing.Size(821, 489)
        '
        'uce_Almacen
        '
        Me.uce_Almacen.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.uce_Almacen.Location = New System.Drawing.Point(681, 4)
        Me.uce_Almacen.Name = "uce_Almacen"
        Me.uce_Almacen.ReadOnly = True
        Me.uce_Almacen.Size = New System.Drawing.Size(137, 21)
        Me.uce_Almacen.TabIndex = 192
        '
        'UltraLabel10
        '
        Appearance33.BackColor = System.Drawing.Color.Transparent
        Appearance33.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel10.Appearance = Appearance33
        Me.UltraLabel10.AutoSize = True
        Me.UltraLabel10.Location = New System.Drawing.Point(647, 8)
        Me.UltraLabel10.Name = "UltraLabel10"
        Me.UltraLabel10.Size = New System.Drawing.Size(28, 14)
        Me.UltraLabel10.TabIndex = 193
        Me.UltraLabel10.Text = "Area"
        '
        'UltraLabel3
        '
        Appearance4.BackColor = System.Drawing.Color.Transparent
        Appearance4.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel3.Appearance = Appearance4
        Me.UltraLabel3.AutoSize = True
        Me.UltraLabel3.Location = New System.Drawing.Point(489, 7)
        Me.UltraLabel3.Name = "UltraLabel3"
        Me.UltraLabel3.Size = New System.Drawing.Size(56, 14)
        Me.UltraLabel3.TabIndex = 60
        Me.UltraLabel3.Text = "Nº Cuenta"
        '
        'txt_IDCUENTA
        '
        Me.txt_IDCUENTA.Location = New System.Drawing.Point(548, 4)
        Me.txt_IDCUENTA.MaxLength = 100
        Me.txt_IDCUENTA.Name = "txt_IDCUENTA"
        Me.txt_IDCUENTA.ReadOnly = True
        Me.txt_IDCUENTA.Size = New System.Drawing.Size(78, 21)
        Me.txt_IDCUENTA.TabIndex = 59
        '
        'txt_bebe
        '
        Me.txt_bebe.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_bebe.Location = New System.Drawing.Point(114, 4)
        Me.txt_bebe.MaxLength = 100
        Me.txt_bebe.Name = "txt_bebe"
        Me.txt_bebe.ReadOnly = True
        Me.txt_bebe.Size = New System.Drawing.Size(360, 21)
        Me.txt_bebe.TabIndex = 57
        '
        'UltraLabel5
        '
        Appearance21.BackColor = System.Drawing.Color.Transparent
        Appearance21.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel5.Appearance = Appearance21
        Me.UltraLabel5.AutoSize = True
        Me.UltraLabel5.Location = New System.Drawing.Point(3, 8)
        Me.UltraLabel5.Name = "UltraLabel5"
        Me.UltraLabel5.Size = New System.Drawing.Size(110, 14)
        Me.UltraLabel5.TabIndex = 58
        Me.UltraLabel5.Text = "Nombre del Paciente"
        '
        'ug_Lista
        '
        Me.ug_Lista.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ug_Lista.DataSource = Me.uds_Lista
        Me.ug_Lista.DisplayLayout.AutoFitStyle = Infragistics.Win.UltraWinGrid.AutoFitStyle.ExtendLastColumn
        UltraGridColumn1.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn1.Header.Caption = "CÓDIGO"
        UltraGridColumn1.Header.VisiblePosition = 0
        UltraGridColumn1.Hidden = True
        UltraGridColumn1.Width = 65
        UltraGridColumn2.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn2.Header.Caption = "ALMACEN"
        UltraGridColumn2.Header.VisiblePosition = 1
        UltraGridColumn2.Width = 120
        UltraGridColumn3.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn3.Header.Caption = "T. DOC."
        UltraGridColumn3.Header.VisiblePosition = 2
        UltraGridColumn3.Width = 54
        UltraGridColumn4.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn4.Header.Caption = "SERIE"
        UltraGridColumn4.Header.VisiblePosition = 3
        UltraGridColumn4.Width = 62
        UltraGridColumn5.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn5.Header.Caption = "NUMERO"
        UltraGridColumn5.Header.VisiblePosition = 4
        UltraGridColumn5.Width = 84
        UltraGridColumn6.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn6.Header.VisiblePosition = 5
        UltraGridColumn6.Hidden = True
        UltraGridColumn7.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn7.Header.Caption = "N° CUENTA"
        UltraGridColumn7.Header.VisiblePosition = 6
        UltraGridColumn7.Hidden = True
        UltraGridColumn7.Width = 81
        UltraGridColumn8.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn8.Header.Caption = "N° HISTORIA"
        UltraGridColumn8.Header.VisiblePosition = 7
        UltraGridColumn8.Width = 83
        UltraGridColumn9.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn9.Header.VisiblePosition = 8
        UltraGridColumn9.Width = 199
        UltraGridColumn10.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn10.Header.VisiblePosition = 9
        UltraGridColumn10.Hidden = True
        UltraGridColumn11.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn11.Header.Caption = "FECHA"
        UltraGridColumn11.Header.VisiblePosition = 10
        UltraGridColumn11.Width = 82
        UltraGridColumn12.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn12.Header.VisiblePosition = 11
        UltraGridColumn12.Hidden = True
        UltraGridColumn13.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn13.Header.VisiblePosition = 12
        UltraGridColumn13.Width = 89
        UltraGridColumn14.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn14.Header.VisiblePosition = 13
        UltraGridColumn14.Hidden = True
        UltraGridBand1.Columns.AddRange(New Object() {UltraGridColumn1, UltraGridColumn2, UltraGridColumn3, UltraGridColumn4, UltraGridColumn5, UltraGridColumn6, UltraGridColumn7, UltraGridColumn8, UltraGridColumn9, UltraGridColumn10, UltraGridColumn11, UltraGridColumn12, UltraGridColumn13, UltraGridColumn14})
        Me.ug_Lista.DisplayLayout.BandsSerializer.Add(UltraGridBand1)
        Me.ug_Lista.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.[False]
        Me.ug_Lista.DisplayLayout.MaxColScrollRegions = 1
        Me.ug_Lista.DisplayLayout.MaxRowScrollRegions = 1
        Me.ug_Lista.DisplayLayout.Override.FilterUIType = Infragistics.Win.UltraWinGrid.FilterUIType.FilterRow
        Appearance9.BackColor = System.Drawing.Color.WhiteSmoke
        Appearance9.BackColor2 = System.Drawing.Color.WhiteSmoke
        Me.ug_Lista.DisplayLayout.Override.RowAlternateAppearance = Appearance9
        Me.ug_Lista.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.ug_Lista.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.ug_Lista.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ug_Lista.Location = New System.Drawing.Point(2, 30)
        Me.ug_Lista.Name = "ug_Lista"
        Me.ug_Lista.Size = New System.Drawing.Size(816, 459)
        Me.ug_Lista.TabIndex = 0
        Me.ug_Lista.Text = "UltraGrid1"
        '
        'uds_Lista
        '
        Me.uds_Lista.AllowDelete = False
        UltraDataColumn1.DataType = GetType(Long)
        UltraDataColumn5.DataType = GetType(Integer)
        UltraDataColumn7.DataType = GetType(Integer)
        UltraDataColumn10.DataType = GetType(Decimal)
        UltraDataColumn12.DataType = GetType(Integer)
        UltraDataColumn14.DataType = GetType(Integer)
        Me.uds_Lista.Band.Columns.AddRange(New Object() {UltraDataColumn1, UltraDataColumn2, UltraDataColumn3, UltraDataColumn4, UltraDataColumn5, UltraDataColumn6, UltraDataColumn7, UltraDataColumn8, UltraDataColumn9, UltraDataColumn10, UltraDataColumn11, UltraDataColumn12, UltraDataColumn13, UltraDataColumn14})
        '
        'UltraTabPageControl2
        '
        Me.UltraTabPageControl2.Controls.Add(Me.ugb_Datos)
        Me.UltraTabPageControl2.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl2.Name = "UltraTabPageControl2"
        Me.UltraTabPageControl2.Size = New System.Drawing.Size(821, 489)
        '
        'ugb_Datos
        '
        Me.ugb_Datos.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ugb_Datos.Controls.Add(Me.ucbo_Estado)
        Me.ugb_Datos.Controls.Add(Me.txtIDSeguro)
        Me.ugb_Datos.Controls.Add(Me.txt_idConsumo)
        Me.ugb_Datos.Controls.Add(Me.uce_Serie)
        Me.ugb_Datos.Controls.Add(Me.uce_TipoDoc)
        Me.ugb_Datos.Controls.Add(Me.txt_NumDoc)
        Me.ugb_Datos.Controls.Add(Me.UltraLabel9)
        Me.ugb_Datos.Controls.Add(Me.UltraLabel7)
        Me.ugb_Datos.Controls.Add(Me.uce_tip_doc)
        Me.ugb_Datos.Controls.Add(Me.txt_Des_Cliente)
        Me.ugb_Datos.Controls.Add(Me.txt_ruc_cliente)
        Me.ugb_Datos.Controls.Add(Me.UltraLabel20)
        Me.ugb_Datos.Controls.Add(Me.UltraLabel4)
        Me.ugb_Datos.Controls.Add(Me.txt_idHistoria)
        Me.ugb_Datos.Controls.Add(Me.ug_detalle)
        Me.ugb_Datos.Controls.Add(Me.ubt_Quitar)
        Me.ugb_Datos.Controls.Add(Me.Panel2)
        Me.ugb_Datos.Controls.Add(Me.UltraLabel2)
        Me.ugb_Datos.Controls.Add(Me.udte_fecha)
        Me.ugb_Datos.Controls.Add(Me.ubt_Agregar)
        Me.ugb_Datos.Controls.Add(Me.UltraLabel1)
        Me.ugb_Datos.Location = New System.Drawing.Point(-1, 1)
        Me.ugb_Datos.Name = "ugb_Datos"
        Me.ugb_Datos.Size = New System.Drawing.Size(826, 493)
        Me.ugb_Datos.TabIndex = 33
        '
        'ucbo_Estado
        '
        Me.ucbo_Estado.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        ValueListItem2.DataValue = "1"
        ValueListItem2.DisplayText = "PENDIENTE"
        ValueListItem3.DataValue = "2"
        ValueListItem3.DisplayText = "TRANSFERIDO"
        ValueListItem1.DataValue = "3"
        ValueListItem1.DisplayText = "FACTURADO"
        Me.ucbo_Estado.Items.AddRange(New Infragistics.Win.ValueListItem() {ValueListItem2, ValueListItem3, ValueListItem1})
        Me.ucbo_Estado.Location = New System.Drawing.Point(701, 42)
        Me.ucbo_Estado.Name = "ucbo_Estado"
        Me.ucbo_Estado.ReadOnly = True
        Me.ucbo_Estado.Size = New System.Drawing.Size(110, 21)
        Me.ucbo_Estado.TabIndex = 6
        '
        'txtIDSeguro
        '
        Me.txtIDSeguro.Location = New System.Drawing.Point(705, 86)
        Me.txtIDSeguro.Name = "txtIDSeguro"
        Me.txtIDSeguro.Size = New System.Drawing.Size(15, 21)
        Me.txtIDSeguro.TabIndex = 194
        Me.txtIDSeguro.Visible = False
        '
        'txt_idConsumo
        '
        Me.txt_idConsumo.Location = New System.Drawing.Point(806, 27)
        Me.txt_idConsumo.Name = "txt_idConsumo"
        Me.txt_idConsumo.Size = New System.Drawing.Size(15, 21)
        Me.txt_idConsumo.TabIndex = 193
        Me.txt_idConsumo.Visible = False
        '
        'uce_Serie
        '
        Me.uce_Serie.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.uce_Serie.Location = New System.Drawing.Point(212, 41)
        Me.uce_Serie.Name = "uce_Serie"
        Me.uce_Serie.Size = New System.Drawing.Size(83, 21)
        Me.uce_Serie.TabIndex = 2
        '
        'uce_TipoDoc
        '
        Me.uce_TipoDoc.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Suggest
        Me.uce_TipoDoc.DropDownListWidth = 50
        Me.uce_TipoDoc.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.uce_TipoDoc.Location = New System.Drawing.Point(90, 41)
        Me.uce_TipoDoc.Name = "uce_TipoDoc"
        Me.uce_TipoDoc.Size = New System.Drawing.Size(122, 21)
        Me.uce_TipoDoc.TabIndex = 1
        '
        'txt_NumDoc
        '
        Me.txt_NumDoc.Location = New System.Drawing.Point(295, 41)
        Me.txt_NumDoc.Name = "txt_NumDoc"
        Me.txt_NumDoc.ReadOnly = True
        Me.txt_NumDoc.Size = New System.Drawing.Size(123, 21)
        Me.txt_NumDoc.TabIndex = 3
        '
        'UltraLabel9
        '
        Appearance3.BackColor = System.Drawing.Color.Transparent
        Appearance3.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel9.Appearance = Appearance3
        Me.UltraLabel9.AutoSize = True
        Me.UltraLabel9.Location = New System.Drawing.Point(15, 44)
        Me.UltraLabel9.Name = "UltraLabel9"
        Me.UltraLabel9.Size = New System.Drawing.Size(73, 14)
        Me.UltraLabel9.TabIndex = 190
        Me.UltraLabel9.Text = "Comprobante"
        '
        'UltraLabel7
        '
        Appearance11.BackColor = System.Drawing.Color.Transparent
        Appearance11.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel7.Appearance = Appearance11
        Me.UltraLabel7.AutoSize = True
        Me.UltraLabel7.Location = New System.Drawing.Point(616, 46)
        Me.UltraLabel7.Name = "UltraLabel7"
        Me.UltraLabel7.Size = New System.Drawing.Size(84, 14)
        Me.UltraLabel7.TabIndex = 180
        Me.UltraLabel7.Text = "Estado del Doc."
        '
        'uce_tip_doc
        '
        Me.uce_tip_doc.DropDownListWidth = 300
        Me.uce_tip_doc.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.uce_tip_doc.Location = New System.Drawing.Point(64, 85)
        Me.uce_tip_doc.Name = "uce_tip_doc"
        Me.uce_tip_doc.ReadOnly = True
        Me.uce_tip_doc.Size = New System.Drawing.Size(63, 21)
        Me.uce_tip_doc.TabIndex = 7
        '
        'txt_Des_Cliente
        '
        Me.txt_Des_Cliente.Location = New System.Drawing.Point(230, 85)
        Me.txt_Des_Cliente.Name = "txt_Des_Cliente"
        Me.txt_Des_Cliente.ReadOnly = True
        Me.txt_Des_Cliente.Size = New System.Drawing.Size(345, 21)
        Me.txt_Des_Cliente.TabIndex = 176
        '
        'txt_ruc_cliente
        '
        Me.txt_ruc_cliente.Location = New System.Drawing.Point(127, 85)
        Me.txt_ruc_cliente.MaxLength = 11
        Me.txt_ruc_cliente.Name = "txt_ruc_cliente"
        Me.txt_ruc_cliente.ReadOnly = True
        Me.txt_ruc_cliente.Size = New System.Drawing.Size(102, 21)
        Me.txt_ruc_cliente.TabIndex = 8
        '
        'UltraLabel20
        '
        Appearance37.BackColor = System.Drawing.Color.Transparent
        Appearance37.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel20.Appearance = Appearance37
        Me.UltraLabel20.AutoSize = True
        Me.UltraLabel20.Location = New System.Drawing.Point(14, 89)
        Me.UltraLabel20.Name = "UltraLabel20"
        Me.UltraLabel20.Size = New System.Drawing.Size(48, 14)
        Me.UltraLabel20.TabIndex = 177
        Me.UltraLabel20.Text = "Paciente"
        '
        'UltraLabel4
        '
        Appearance12.BackColor = System.Drawing.Color.Transparent
        Appearance12.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel4.Appearance = Appearance12
        Me.UltraLabel4.AutoSize = True
        Me.UltraLabel4.Location = New System.Drawing.Point(578, 89)
        Me.UltraLabel4.Name = "UltraLabel4"
        Me.UltraLabel4.Size = New System.Drawing.Size(27, 14)
        Me.UltraLabel4.TabIndex = 172
        Me.UltraLabel4.Text = "H.C."
        '
        'txt_idHistoria
        '
        Me.txt_idHistoria.Location = New System.Drawing.Point(608, 85)
        Me.txt_idHistoria.Name = "txt_idHistoria"
        Me.txt_idHistoria.ReadOnly = True
        Me.txt_idHistoria.Size = New System.Drawing.Size(91, 21)
        Me.txt_idHistoria.TabIndex = 171
        '
        'ug_detalle
        '
        Me.ug_detalle.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ug_detalle.DataSource = Me.uds_detalle
        Me.ug_detalle.DisplayLayout.AutoFitStyle = Infragistics.Win.UltraWinGrid.AutoFitStyle.ExtendLastColumn
        UltraGridColumn15.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn15.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        Appearance1.TextHAlignAsString = "Center"
        UltraGridColumn15.CellAppearance = Appearance1
        UltraGridColumn15.Header.Caption = "Item"
        UltraGridColumn15.Header.VisiblePosition = 0
        UltraGridColumn15.Width = 36
        UltraGridColumn16.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn16.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        Appearance2.TextHAlignAsString = "Center"
        UltraGridColumn16.CellAppearance = Appearance2
        UltraGridColumn16.Header.Caption = "Código"
        UltraGridColumn16.Header.VisiblePosition = 1
        UltraGridColumn16.Width = 80
        UltraGridColumn17.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn17.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn17.Header.Caption = "DESCRIPCION"
        UltraGridColumn17.Header.VisiblePosition = 2
        UltraGridColumn17.Width = 415
        UltraGridColumn18.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn18.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        Appearance5.TextHAlignAsString = "Left"
        UltraGridColumn18.CellAppearance = Appearance5
        UltraGridColumn18.Header.Caption = "U. Medida"
        UltraGridColumn18.Header.VisiblePosition = 3
        UltraGridColumn18.MaskDisplayMode = Infragistics.Win.UltraWinMaskedEdit.MaskMode.IncludeLiterals
        UltraGridColumn18.Width = 91
        UltraGridColumn19.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn19.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn19.Header.Caption = "LOTE"
        UltraGridColumn19.Header.VisiblePosition = 4
        UltraGridColumn19.Width = 73
        UltraGridColumn20.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn20.Header.VisiblePosition = 5
        UltraGridColumn20.Hidden = True
        UltraGridColumn21.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        Appearance6.TextHAlignAsString = "Center"
        UltraGridColumn21.CellAppearance = Appearance6
        Appearance7.TextHAlignAsString = "Center"
        UltraGridColumn21.Header.Appearance = Appearance7
        UltraGridColumn21.Header.Caption = "CANTIDAD"
        UltraGridColumn21.Header.VisiblePosition = 6
        UltraGridColumn21.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Integer]
        UltraGridColumn21.Width = 60
        UltraGridColumn22.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn22.Header.VisiblePosition = 7
        UltraGridColumn22.Hidden = True
        UltraGridColumn23.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn23.Header.VisiblePosition = 8
        UltraGridColumn23.Hidden = True
        UltraGridColumn24.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn24.Header.VisiblePosition = 9
        UltraGridColumn24.Hidden = True
        UltraGridColumn25.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn25.Header.VisiblePosition = 10
        UltraGridColumn25.Hidden = True
        UltraGridBand2.Columns.AddRange(New Object() {UltraGridColumn15, UltraGridColumn16, UltraGridColumn17, UltraGridColumn18, UltraGridColumn19, UltraGridColumn20, UltraGridColumn21, UltraGridColumn22, UltraGridColumn23, UltraGridColumn24, UltraGridColumn25})
        UltraGridBand2.SummaryFooterCaption = "Totales"
        Me.ug_detalle.DisplayLayout.BandsSerializer.Add(UltraGridBand2)
        Me.ug_detalle.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.[False]
        Me.ug_detalle.DisplayLayout.MaxColScrollRegions = 1
        Me.ug_detalle.DisplayLayout.MaxRowScrollRegions = 1
        Me.ug_detalle.DisplayLayout.Override.AllowDelete = Infragistics.Win.DefaultableBoolean.[True]
        Me.ug_detalle.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.ug_detalle.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.ug_detalle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ug_detalle.Location = New System.Drawing.Point(15, 114)
        Me.ug_detalle.Name = "ug_detalle"
        Me.ug_detalle.Size = New System.Drawing.Size(796, 373)
        Me.ug_detalle.TabIndex = 11
        Me.ug_detalle.Text = "UltraGrid1"
        '
        'uds_detalle
        '
        Me.uds_detalle.Band.AllowAdd = Infragistics.Win.DefaultableBoolean.[True]
        Me.uds_detalle.Band.AllowDelete = Infragistics.Win.DefaultableBoolean.[True]
        UltraDataColumn15.DataType = GetType(Integer)
        UltraDataColumn16.DataType = GetType(Integer)
        UltraDataColumn20.DataType = GetType(Double)
        UltraDataColumn21.DataType = GetType(Integer)
        UltraDataColumn22.DataType = GetType(Double)
        UltraDataColumn23.DataType = GetType(Integer)
        UltraDataColumn24.DataType = GetType(Boolean)
        UltraDataColumn25.DataType = GetType(Double)
        Me.uds_detalle.Band.Columns.AddRange(New Object() {UltraDataColumn15, UltraDataColumn16, UltraDataColumn17, UltraDataColumn18, UltraDataColumn19, UltraDataColumn20, UltraDataColumn21, UltraDataColumn22, UltraDataColumn23, UltraDataColumn24, UltraDataColumn25})
        '
        'ubt_Quitar
        '
        Me.ubt_Quitar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ubt_Quitar.Location = New System.Drawing.Point(772, 84)
        Me.ubt_Quitar.Name = "ubt_Quitar"
        Me.ubt_Quitar.Size = New System.Drawing.Size(29, 24)
        Me.ubt_Quitar.TabIndex = 10
        Me.ubt_Quitar.Text = "-"
        '
        'Panel2
        '
        Me.Panel2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel2.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.Panel2.Location = New System.Drawing.Point(14, 73)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(796, 2)
        Me.Panel2.TabIndex = 154
        '
        'UltraLabel2
        '
        Me.UltraLabel2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Appearance18.BackColor = System.Drawing.Color.DeepSkyBlue
        Appearance18.ForeColor = System.Drawing.Color.White
        Appearance18.TextHAlignAsString = "Center"
        Me.UltraLabel2.Appearance = Appearance18
        Me.UltraLabel2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel2.Location = New System.Drawing.Point(2, 2)
        Me.UltraLabel2.Name = "UltraLabel2"
        Me.UltraLabel2.Size = New System.Drawing.Size(821, 28)
        Me.UltraLabel2.TabIndex = 27
        Me.UltraLabel2.Text = "Consumo por Paciente"
        '
        'udte_fecha
        '
        Me.udte_fecha.DateTime = New Date(2014, 1, 28, 0, 0, 0, 0)
        Me.udte_fecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.udte_fecha.Location = New System.Drawing.Point(492, 39)
        Me.udte_fecha.Name = "udte_fecha"
        Me.udte_fecha.ReadOnly = True
        Me.udte_fecha.Size = New System.Drawing.Size(109, 24)
        Me.udte_fecha.TabIndex = 5
        Me.udte_fecha.Value = New Date(2014, 1, 28, 0, 0, 0, 0)
        '
        'ubt_Agregar
        '
        Me.ubt_Agregar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ubt_Agregar.Location = New System.Drawing.Point(738, 84)
        Me.ubt_Agregar.Name = "ubt_Agregar"
        Me.ubt_Agregar.Size = New System.Drawing.Size(29, 24)
        Me.ubt_Agregar.TabIndex = 9
        Me.ubt_Agregar.Text = "+"
        '
        'UltraLabel1
        '
        Appearance20.BackColor = System.Drawing.Color.Transparent
        Appearance20.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel1.Appearance = Appearance20
        Me.UltraLabel1.AutoSize = True
        Me.UltraLabel1.Location = New System.Drawing.Point(428, 45)
        Me.UltraLabel1.Name = "UltraLabel1"
        Me.UltraLabel1.Size = New System.Drawing.Size(63, 14)
        Me.UltraLabel1.TabIndex = 29
        Me.UltraLabel1.Text = "Fecha Reg."
        '
        'utc_Datos
        '
        Me.utc_Datos.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.utc_Datos.Controls.Add(Me.UltraTabSharedControlsPage1)
        Me.utc_Datos.Controls.Add(Me.UltraTabPageControl1)
        Me.utc_Datos.Controls.Add(Me.UltraTabPageControl2)
        Me.utc_Datos.Location = New System.Drawing.Point(2, 27)
        Me.utc_Datos.Name = "utc_Datos"
        Me.utc_Datos.SharedControlsPage = Me.UltraTabSharedControlsPage1
        Me.utc_Datos.Size = New System.Drawing.Size(825, 515)
        Me.utc_Datos.TabIndex = 188
        UltraTab1.TabPage = Me.UltraTabPageControl1
        UltraTab1.Text = "Lista de Consumo"
        UltraTab2.TabPage = Me.UltraTabPageControl2
        UltraTab2.Text = "Ingreso / Edicion de Datos"
        Me.utc_Datos.Tabs.AddRange(New Infragistics.Win.UltraWinTabControl.UltraTab() {UltraTab1, UltraTab2})
        '
        'UltraTabSharedControlsPage1
        '
        Me.UltraTabSharedControlsPage1.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabSharedControlsPage1.Name = "UltraTabSharedControlsPage1"
        Me.UltraTabSharedControlsPage1.Size = New System.Drawing.Size(821, 489)
        '
        'ToolS_Mantenimiento
        '
        Me.ToolS_Mantenimiento.BackColor = System.Drawing.Color.White
        Me.ToolS_Mantenimiento.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Tool_Nuevo, Me.ToolStripSeparator1, Me.Tool_Grabar, Me.ToolStripSeparator4, Me.Tool_Editar, Me.ToolStripSeparator3, Me.Tool_Cancelar, Me.ToolStripSeparator2, Me.Tool_Eliminar, Me.ToolStripSeparator5, Me.Tool_Salir})
        Me.ToolS_Mantenimiento.Location = New System.Drawing.Point(0, 0)
        Me.ToolS_Mantenimiento.Name = "ToolS_Mantenimiento"
        Me.ToolS_Mantenimiento.Size = New System.Drawing.Size(827, 25)
        Me.ToolS_Mantenimiento.TabIndex = 187
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
        Me.Tool_Eliminar.Size = New System.Drawing.Size(62, 22)
        Me.Tool_Eliminar.Text = "Anular"
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
        'txt_idRegistro
        '
        Me.txt_idRegistro.Location = New System.Drawing.Point(609, 4)
        Me.txt_idRegistro.MaxLength = 100
        Me.txt_idRegistro.Name = "txt_idRegistro"
        Me.txt_idRegistro.ReadOnly = True
        Me.txt_idRegistro.Size = New System.Drawing.Size(32, 21)
        Me.txt_idRegistro.TabIndex = 194
        Me.txt_idRegistro.Visible = False
        '
        'BB_LT_RegConsumoFar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(827, 543)
        Me.Controls.Add(Me.utc_Datos)
        Me.Controls.Add(Me.ToolS_Mantenimiento)
        Me.Name = "BB_LT_RegConsumoFar"
        Me.Text = "Consumo de Farmacia"
        Me.UltraTabPageControl1.ResumeLayout(False)
        Me.UltraTabPageControl1.PerformLayout()
        CType(Me.uce_Almacen, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_IDCUENTA, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_bebe, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ug_Lista, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.uds_Lista, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabPageControl2.ResumeLayout(False)
        CType(Me.ugb_Datos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ugb_Datos.ResumeLayout(False)
        Me.ugb_Datos.PerformLayout()
        CType(Me.ucbo_Estado, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtIDSeguro, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_idConsumo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.uce_Serie, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.uce_TipoDoc, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_NumDoc, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.uce_tip_doc, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_Des_Cliente, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_ruc_cliente, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_idHistoria, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ug_detalle, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.uds_detalle, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.udte_fecha, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.utc_Datos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.utc_Datos.ResumeLayout(False)
        Me.ToolS_Mantenimiento.ResumeLayout(False)
        Me.ToolS_Mantenimiento.PerformLayout()
        CType(Me.txt_idRegistro, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents uds_detalle As Infragistics.Win.UltraWinDataSource.UltraDataSource
    Friend WithEvents utc_Datos As Infragistics.Win.UltraWinTabControl.UltraTabControl
    Friend WithEvents UltraTabSharedControlsPage1 As Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage
    Friend WithEvents UltraTabPageControl1 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents ug_Lista As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents uds_Lista As Infragistics.Win.UltraWinDataSource.UltraDataSource
    Friend WithEvents UltraTabPageControl2 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents ugb_Datos As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents txtIDSeguro As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents txt_idConsumo As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents uce_Serie As Infragistics.Win.UltraWinEditors.UltraComboEditor
    Friend WithEvents uce_TipoDoc As Infragistics.Win.UltraWinEditors.UltraComboEditor
    Friend WithEvents txt_NumDoc As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents UltraLabel9 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel7 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents ucbo_Estado As Infragistics.Win.UltraWinEditors.UltraComboEditor
    Friend WithEvents uce_tip_doc As Infragistics.Win.UltraWinEditors.UltraComboEditor
    Friend WithEvents txt_Des_Cliente As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents txt_ruc_cliente As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents UltraLabel20 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel4 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents txt_idHistoria As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Public WithEvents ug_detalle As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents ubt_Quitar As Infragistics.Win.Misc.UltraButton
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents UltraLabel2 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents udte_fecha As Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
    Friend WithEvents ubt_Agregar As Infragistics.Win.Misc.UltraButton
    Friend WithEvents UltraLabel1 As Infragistics.Win.Misc.UltraLabel
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
    Friend WithEvents txt_bebe As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents UltraLabel5 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel3 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents txt_IDCUENTA As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents uce_Almacen As Infragistics.Win.UltraWinEditors.UltraComboEditor
    Friend WithEvents UltraLabel10 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents txt_idRegistro As Infragistics.Win.UltraWinEditors.UltraTextEditor
End Class
