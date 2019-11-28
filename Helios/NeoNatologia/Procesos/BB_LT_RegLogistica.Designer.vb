<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BB_LT_RegLogistica
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
        Dim UltraGridColumn1 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("RC_ID")
        Dim UltraGridColumn2 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("RC_IDTIPO")
        Dim UltraGridColumn3 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TR_DESCRIPCION")
        Dim UltraGridColumn4 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("RC_FECHA_REQ")
        Dim UltraGridColumn5 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("RC_NOTA")
        Dim UltraGridColumn6 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("RC_ESTADO")
        Dim Appearance9 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraDataColumn1 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("RC_ID")
        Dim UltraDataColumn2 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("RC_IDTIPO")
        Dim UltraDataColumn3 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("TR_DESCRIPCION")
        Dim UltraDataColumn4 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("RC_FECHA_REQ")
        Dim UltraDataColumn5 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("RC_NOTA")
        Dim UltraDataColumn6 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("RC_ESTADO")
        Dim Appearance7 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance3 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance37 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance12 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridBand2 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1)
        Dim UltraGridColumn7 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("RD_ITEM")
        Dim Appearance1 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn8 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("RD_IDARTICULO")
        Dim Appearance2 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn9 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("AR_DESCRIPCION")
        Dim UltraGridColumn10 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("UM_DESCRIPCION")
        Dim Appearance5 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn11 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("RD_CANT")
        Dim UltraGridColumn12 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("RD_NOTA")
        Dim UltraDataColumn7 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("RD_ITEM")
        Dim UltraDataColumn8 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("RD_IDARTICULO")
        Dim UltraDataColumn9 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("AR_DESCRIPCION")
        Dim UltraDataColumn10 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("UM_DESCRIPCION")
        Dim UltraDataColumn11 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("RD_CANT")
        Dim UltraDataColumn12 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("RD_NOTA")
        Dim Appearance20 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraTab1 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraTab2 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Me.UltraTabPageControl1 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.uce_Area = New Infragistics.Win.UltraWinEditors.UltraComboEditor()
        Me.UltraLabel10 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraLabel3 = New Infragistics.Win.Misc.UltraLabel()
        Me.txt_IDCUENTA = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.txt_bebe = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.UltraLabel5 = New Infragistics.Win.Misc.UltraLabel()
        Me.ug_Lista = New Infragistics.Win.UltraWinGrid.UltraGrid()
        Me.uds_Lista = New Infragistics.Win.UltraWinDataSource.UltraDataSource(Me.components)
        Me.UltraTabPageControl2 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.ugb_Datos = New Infragistics.Win.Misc.UltraGroupBox()
        Me.txt_Nota = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.UltraLabel13 = New Infragistics.Win.Misc.UltraLabel()
        Me.txt_IdRequerimiento = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.UltraLabel9 = New Infragistics.Win.Misc.UltraLabel()
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
        Me.Tool_Imprimir = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator6 = New System.Windows.Forms.ToolStripSeparator()
        Me.Tool_Eliminar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator()
        Me.Tool_Salir = New System.Windows.Forms.ToolStripButton()
        Me.txt_idRegistro = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.UltraTabPageControl1.SuspendLayout()
        CType(Me.uce_Area, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_IDCUENTA, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_bebe, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ug_Lista, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.uds_Lista, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabPageControl2.SuspendLayout()
        CType(Me.ugb_Datos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ugb_Datos.SuspendLayout()
        CType(Me.txt_Nota, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_IdRequerimiento, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.UltraTabPageControl1.Controls.Add(Me.uce_Area)
        Me.UltraTabPageControl1.Controls.Add(Me.UltraLabel10)
        Me.UltraTabPageControl1.Controls.Add(Me.UltraLabel3)
        Me.UltraTabPageControl1.Controls.Add(Me.txt_IDCUENTA)
        Me.UltraTabPageControl1.Controls.Add(Me.txt_bebe)
        Me.UltraTabPageControl1.Controls.Add(Me.UltraLabel5)
        Me.UltraTabPageControl1.Controls.Add(Me.ug_Lista)
        Me.UltraTabPageControl1.Location = New System.Drawing.Point(1, 23)
        Me.UltraTabPageControl1.Name = "UltraTabPageControl1"
        Me.UltraTabPageControl1.Size = New System.Drawing.Size(830, 428)
        '
        'uce_Area
        '
        Me.uce_Area.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.uce_Area.Location = New System.Drawing.Point(681, 4)
        Me.uce_Area.Name = "uce_Area"
        Me.uce_Area.ReadOnly = True
        Me.uce_Area.Size = New System.Drawing.Size(137, 21)
        Me.uce_Area.TabIndex = 192
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
        UltraGridColumn1.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn1.Header.Caption = "Código"
        UltraGridColumn1.Header.VisiblePosition = 0
        UltraGridColumn1.Width = 78
        UltraGridColumn2.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn2.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn2.Header.VisiblePosition = 1
        UltraGridColumn2.Hidden = True
        UltraGridColumn2.Width = 120
        UltraGridColumn3.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn3.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn3.Header.Caption = "Tipo"
        UltraGridColumn3.Header.VisiblePosition = 2
        UltraGridColumn3.Width = 104
        UltraGridColumn4.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn4.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn4.Header.Caption = "Fecha"
        UltraGridColumn4.Header.VisiblePosition = 3
        UltraGridColumn4.Width = 127
        UltraGridColumn5.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn5.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn5.Header.Caption = "Nota"
        UltraGridColumn5.Header.VisiblePosition = 4
        UltraGridColumn5.Width = 84
        UltraGridColumn6.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn6.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn6.Header.VisiblePosition = 5
        UltraGridColumn6.Hidden = True
        UltraGridBand1.Columns.AddRange(New Object() {UltraGridColumn1, UltraGridColumn2, UltraGridColumn3, UltraGridColumn4, UltraGridColumn5, UltraGridColumn6})
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
        Me.ug_Lista.Location = New System.Drawing.Point(2, 31)
        Me.ug_Lista.Name = "ug_Lista"
        Me.ug_Lista.Size = New System.Drawing.Size(825, 397)
        Me.ug_Lista.TabIndex = 0
        Me.ug_Lista.Text = "UltraGrid1"
        '
        'uds_Lista
        '
        Me.uds_Lista.AllowDelete = False
        UltraDataColumn1.DataType = GetType(Long)
        UltraDataColumn2.DataType = GetType(Integer)
        UltraDataColumn6.DataType = GetType(Integer)
        Me.uds_Lista.Band.Columns.AddRange(New Object() {UltraDataColumn1, UltraDataColumn2, UltraDataColumn3, UltraDataColumn4, UltraDataColumn5, UltraDataColumn6})
        '
        'UltraTabPageControl2
        '
        Me.UltraTabPageControl2.Controls.Add(Me.ugb_Datos)
        Me.UltraTabPageControl2.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl2.Name = "UltraTabPageControl2"
        Me.UltraTabPageControl2.Size = New System.Drawing.Size(830, 428)
        '
        'ugb_Datos
        '
        Me.ugb_Datos.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ugb_Datos.Controls.Add(Me.txt_Nota)
        Me.ugb_Datos.Controls.Add(Me.UltraLabel13)
        Me.ugb_Datos.Controls.Add(Me.txt_IdRequerimiento)
        Me.ugb_Datos.Controls.Add(Me.UltraLabel9)
        Me.ugb_Datos.Controls.Add(Me.uce_tip_doc)
        Me.ugb_Datos.Controls.Add(Me.txt_Des_Cliente)
        Me.ugb_Datos.Controls.Add(Me.txt_ruc_cliente)
        Me.ugb_Datos.Controls.Add(Me.UltraLabel20)
        Me.ugb_Datos.Controls.Add(Me.UltraLabel4)
        Me.ugb_Datos.Controls.Add(Me.txt_idHistoria)
        Me.ugb_Datos.Controls.Add(Me.ug_detalle)
        Me.ugb_Datos.Controls.Add(Me.ubt_Quitar)
        Me.ugb_Datos.Controls.Add(Me.Panel2)
        Me.ugb_Datos.Controls.Add(Me.udte_fecha)
        Me.ugb_Datos.Controls.Add(Me.ubt_Agregar)
        Me.ugb_Datos.Controls.Add(Me.UltraLabel1)
        Me.ugb_Datos.Location = New System.Drawing.Point(1, 1)
        Me.ugb_Datos.Name = "ugb_Datos"
        Me.ugb_Datos.Size = New System.Drawing.Size(827, 426)
        Me.ugb_Datos.TabIndex = 33
        '
        'txt_Nota
        '
        Me.txt_Nota.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_Nota.Location = New System.Drawing.Point(64, 84)
        Me.txt_Nota.MaxLength = 100
        Me.txt_Nota.Name = "txt_Nota"
        Me.txt_Nota.Size = New System.Drawing.Size(635, 21)
        Me.txt_Nota.TabIndex = 231
        '
        'UltraLabel13
        '
        Appearance7.BackColor = System.Drawing.Color.Transparent
        Appearance7.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel13.Appearance = Appearance7
        Me.UltraLabel13.AutoSize = True
        Me.UltraLabel13.Location = New System.Drawing.Point(15, 88)
        Me.UltraLabel13.Name = "UltraLabel13"
        Me.UltraLabel13.Size = New System.Drawing.Size(31, 14)
        Me.UltraLabel13.TabIndex = 232
        Me.UltraLabel13.Text = "Nota:"
        '
        'txt_IdRequerimiento
        '
        Me.txt_IdRequerimiento.Location = New System.Drawing.Point(114, 13)
        Me.txt_IdRequerimiento.Name = "txt_IdRequerimiento"
        Me.txt_IdRequerimiento.ReadOnly = True
        Me.txt_IdRequerimiento.Size = New System.Drawing.Size(179, 21)
        Me.txt_IdRequerimiento.TabIndex = 3
        '
        'UltraLabel9
        '
        Appearance3.BackColor = System.Drawing.Color.Transparent
        Appearance3.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel9.Appearance = Appearance3
        Me.UltraLabel9.AutoSize = True
        Me.UltraLabel9.Location = New System.Drawing.Point(15, 17)
        Me.UltraLabel9.Name = "UltraLabel9"
        Me.UltraLabel9.Size = New System.Drawing.Size(94, 14)
        Me.UltraLabel9.TabIndex = 190
        Me.UltraLabel9.Text = "N° Requerimiento"
        '
        'uce_tip_doc
        '
        Me.uce_tip_doc.DropDownListWidth = 300
        Me.uce_tip_doc.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.uce_tip_doc.Location = New System.Drawing.Point(64, 58)
        Me.uce_tip_doc.Name = "uce_tip_doc"
        Me.uce_tip_doc.ReadOnly = True
        Me.uce_tip_doc.Size = New System.Drawing.Size(63, 21)
        Me.uce_tip_doc.TabIndex = 7
        '
        'txt_Des_Cliente
        '
        Me.txt_Des_Cliente.Location = New System.Drawing.Point(230, 58)
        Me.txt_Des_Cliente.Name = "txt_Des_Cliente"
        Me.txt_Des_Cliente.ReadOnly = True
        Me.txt_Des_Cliente.Size = New System.Drawing.Size(345, 21)
        Me.txt_Des_Cliente.TabIndex = 176
        '
        'txt_ruc_cliente
        '
        Me.txt_ruc_cliente.Location = New System.Drawing.Point(127, 58)
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
        Me.UltraLabel20.Location = New System.Drawing.Point(14, 62)
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
        Me.UltraLabel4.Location = New System.Drawing.Point(578, 62)
        Me.UltraLabel4.Name = "UltraLabel4"
        Me.UltraLabel4.Size = New System.Drawing.Size(27, 14)
        Me.UltraLabel4.TabIndex = 172
        Me.UltraLabel4.Text = "H.C."
        '
        'txt_idHistoria
        '
        Me.txt_idHistoria.Location = New System.Drawing.Point(608, 58)
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
        UltraGridColumn7.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn7.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        Appearance1.TextHAlignAsString = "Center"
        UltraGridColumn7.CellAppearance = Appearance1
        UltraGridColumn7.Header.Caption = "Item"
        UltraGridColumn7.Header.VisiblePosition = 0
        UltraGridColumn7.Width = 36
        UltraGridColumn8.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn8.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        Appearance2.TextHAlignAsString = "Center"
        UltraGridColumn8.CellAppearance = Appearance2
        UltraGridColumn8.Header.Caption = "Código"
        UltraGridColumn8.Header.VisiblePosition = 1
        UltraGridColumn8.Width = 66
        UltraGridColumn9.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn9.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn9.Header.Caption = "Dscripcion"
        UltraGridColumn9.Header.VisiblePosition = 2
        UltraGridColumn9.Width = 330
        UltraGridColumn10.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn10.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        Appearance5.TextHAlignAsString = "Left"
        UltraGridColumn10.CellAppearance = Appearance5
        UltraGridColumn10.Header.Caption = "U. Medida"
        UltraGridColumn10.Header.VisiblePosition = 3
        UltraGridColumn10.MaskDisplayMode = Infragistics.Win.UltraWinMaskedEdit.MaskMode.IncludeLiterals
        UltraGridColumn10.Width = 91
        UltraGridColumn11.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn11.Header.Caption = "Cantidad"
        UltraGridColumn11.Header.VisiblePosition = 4
        UltraGridColumn11.Width = 57
        UltraGridColumn12.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn12.Header.Caption = "Nota"
        UltraGridColumn12.Header.VisiblePosition = 5
        UltraGridBand2.Columns.AddRange(New Object() {UltraGridColumn7, UltraGridColumn8, UltraGridColumn9, UltraGridColumn10, UltraGridColumn11, UltraGridColumn12})
        UltraGridBand2.SummaryFooterCaption = "Totales"
        Me.ug_detalle.DisplayLayout.BandsSerializer.Add(UltraGridBand2)
        Me.ug_detalle.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.[False]
        Me.ug_detalle.DisplayLayout.MaxColScrollRegions = 1
        Me.ug_detalle.DisplayLayout.MaxRowScrollRegions = 1
        Me.ug_detalle.DisplayLayout.Override.AllowDelete = Infragistics.Win.DefaultableBoolean.[True]
        Me.ug_detalle.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.ug_detalle.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.ug_detalle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ug_detalle.Location = New System.Drawing.Point(8, 115)
        Me.ug_detalle.Name = "ug_detalle"
        Me.ug_detalle.Size = New System.Drawing.Size(812, 304)
        Me.ug_detalle.TabIndex = 11
        Me.ug_detalle.Text = "UltraGrid1"
        '
        'uds_detalle
        '
        Me.uds_detalle.Band.AllowAdd = Infragistics.Win.DefaultableBoolean.[True]
        Me.uds_detalle.Band.AllowDelete = Infragistics.Win.DefaultableBoolean.[True]
        UltraDataColumn7.DataType = GetType(Integer)
        UltraDataColumn8.DataType = GetType(Integer)
        UltraDataColumn11.DataType = GetType(Integer)
        Me.uds_detalle.Band.Columns.AddRange(New Object() {UltraDataColumn7, UltraDataColumn8, UltraDataColumn9, UltraDataColumn10, UltraDataColumn11, UltraDataColumn12})
        '
        'ubt_Quitar
        '
        Me.ubt_Quitar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ubt_Quitar.Location = New System.Drawing.Point(762, 70)
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
        Me.Panel2.Location = New System.Drawing.Point(14, 45)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(797, 2)
        Me.Panel2.TabIndex = 154
        '
        'udte_fecha
        '
        Me.udte_fecha.DateTime = New Date(2014, 1, 28, 0, 0, 0, 0)
        Me.udte_fecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.udte_fecha.Location = New System.Drawing.Point(406, 11)
        Me.udte_fecha.Name = "udte_fecha"
        Me.udte_fecha.ReadOnly = True
        Me.udte_fecha.Size = New System.Drawing.Size(131, 24)
        Me.udte_fecha.TabIndex = 5
        Me.udte_fecha.Value = New Date(2014, 1, 28, 0, 0, 0, 0)
        '
        'ubt_Agregar
        '
        Me.ubt_Agregar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ubt_Agregar.Location = New System.Drawing.Point(728, 70)
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
        Me.UltraLabel1.Location = New System.Drawing.Point(339, 17)
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
        Me.utc_Datos.Location = New System.Drawing.Point(1, 28)
        Me.utc_Datos.Name = "utc_Datos"
        Me.utc_Datos.SharedControlsPage = Me.UltraTabSharedControlsPage1
        Me.utc_Datos.Size = New System.Drawing.Size(834, 454)
        Me.utc_Datos.TabIndex = 190
        UltraTab1.TabPage = Me.UltraTabPageControl1
        UltraTab1.Text = "Lista de Requerimientos"
        UltraTab2.TabPage = Me.UltraTabPageControl2
        UltraTab2.Text = "Ingreso / Edicion de Datos"
        Me.utc_Datos.Tabs.AddRange(New Infragistics.Win.UltraWinTabControl.UltraTab() {UltraTab1, UltraTab2})
        '
        'UltraTabSharedControlsPage1
        '
        Me.UltraTabSharedControlsPage1.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabSharedControlsPage1.Name = "UltraTabSharedControlsPage1"
        Me.UltraTabSharedControlsPage1.Size = New System.Drawing.Size(830, 428)
        '
        'ToolS_Mantenimiento
        '
        Me.ToolS_Mantenimiento.BackColor = System.Drawing.Color.White
        Me.ToolS_Mantenimiento.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Tool_Nuevo, Me.ToolStripSeparator1, Me.Tool_Grabar, Me.ToolStripSeparator4, Me.Tool_Editar, Me.ToolStripSeparator3, Me.Tool_Cancelar, Me.ToolStripSeparator2, Me.Tool_Imprimir, Me.ToolStripSeparator6, Me.Tool_Eliminar, Me.ToolStripSeparator5, Me.Tool_Salir})
        Me.ToolS_Mantenimiento.Location = New System.Drawing.Point(0, 0)
        Me.ToolS_Mantenimiento.Name = "ToolS_Mantenimiento"
        Me.ToolS_Mantenimiento.Size = New System.Drawing.Size(835, 25)
        Me.ToolS_Mantenimiento.TabIndex = 189
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
        'Tool_Imprimir
        '
        Me.Tool_Imprimir.Image = Global.Contabilidad.My.Resources.Resources._004
        Me.Tool_Imprimir.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Tool_Imprimir.Name = "Tool_Imprimir"
        Me.Tool_Imprimir.Size = New System.Drawing.Size(73, 22)
        Me.Tool_Imprimir.Text = "Imprimir"
        '
        'ToolStripSeparator6
        '
        Me.ToolStripSeparator6.Name = "ToolStripSeparator6"
        Me.ToolStripSeparator6.Size = New System.Drawing.Size(6, 25)
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
        Me.txt_idRegistro.Location = New System.Drawing.Point(609, 3)
        Me.txt_idRegistro.MaxLength = 100
        Me.txt_idRegistro.Name = "txt_idRegistro"
        Me.txt_idRegistro.ReadOnly = True
        Me.txt_idRegistro.Size = New System.Drawing.Size(32, 21)
        Me.txt_idRegistro.TabIndex = 194
        Me.txt_idRegistro.Visible = False
        '
        'BB_LT_RegLogistica
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(835, 484)
        Me.Controls.Add(Me.utc_Datos)
        Me.Controls.Add(Me.ToolS_Mantenimiento)
        Me.Name = "BB_LT_RegLogistica"
        Me.Text = "Consumo por Logistica"
        Me.UltraTabPageControl1.ResumeLayout(False)
        Me.UltraTabPageControl1.PerformLayout()
        CType(Me.uce_Area, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_IDCUENTA, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_bebe, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ug_Lista, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.uds_Lista, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabPageControl2.ResumeLayout(False)
        CType(Me.ugb_Datos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ugb_Datos.ResumeLayout(False)
        Me.ugb_Datos.PerformLayout()
        CType(Me.txt_Nota, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_IdRequerimiento, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents uce_Area As Infragistics.Win.UltraWinEditors.UltraComboEditor
    Friend WithEvents UltraLabel10 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel3 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents txt_IDCUENTA As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents txt_bebe As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents UltraLabel5 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents ug_Lista As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents uds_Lista As Infragistics.Win.UltraWinDataSource.UltraDataSource
    Friend WithEvents UltraTabPageControl2 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents ugb_Datos As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents txt_IdRequerimiento As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents UltraLabel9 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents uce_tip_doc As Infragistics.Win.UltraWinEditors.UltraComboEditor
    Friend WithEvents txt_Des_Cliente As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents txt_ruc_cliente As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents UltraLabel20 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel4 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents txt_idHistoria As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Public WithEvents ug_detalle As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents ubt_Quitar As Infragistics.Win.Misc.UltraButton
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
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
    Friend WithEvents txt_Nota As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents UltraLabel13 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents Tool_Imprimir As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator6 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents txt_idRegistro As Infragistics.Win.UltraWinEditors.UltraTextEditor
End Class
