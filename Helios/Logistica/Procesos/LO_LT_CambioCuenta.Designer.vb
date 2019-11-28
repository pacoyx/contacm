<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LO_LT_CambioCuenta
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
        Dim EditorButton1 As Infragistics.Win.UltraWinEditors.EditorButton = New Infragistics.Win.UltraWinEditors.EditorButton("ayuda")
        Dim Appearance9 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance3 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance8 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridBand1 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1)
        Dim UltraGridColumn1 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("AL_DESCRIPCION")
        Dim UltraGridColumn2 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("1")
        Dim UltraGridColumn3 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("2")
        Dim UltraGridColumn4 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("UM_DESCRIPCION")
        Dim UltraGridColumn5 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("D1")
        Dim UltraGridColumn6 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("D2")
        Dim UltraGridColumn7 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("D3")
        Dim UltraGridColumn8 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Fecha")
        Dim UltraGridColumn9 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CM_TDOC")
        Dim UltraGridColumn10 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NDOC")
        Dim UltraGridColumn11 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("DC_SEG_CUBRE")
        Dim UltraGridColumn12 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CM_ID")
        Dim Appearance1 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraDataColumn1 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("AL_DESCRIPCION")
        Dim UltraDataColumn2 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("1")
        Dim UltraDataColumn3 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("2")
        Dim UltraDataColumn4 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("UM_DESCRIPCION")
        Dim UltraDataColumn5 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("D1")
        Dim UltraDataColumn6 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("D2")
        Dim UltraDataColumn7 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("D3")
        Dim UltraDataColumn8 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Fecha")
        Dim UltraDataColumn9 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("CM_TDOC")
        Dim UltraDataColumn10 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("NDOC")
        Dim UltraDataColumn11 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("DC_SEG_CUBRE")
        Dim UltraDataColumn12 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("CM_ID")
        Dim Appearance2 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance10 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim EditorButton2 As Infragistics.Win.UltraWinEditors.EditorButton = New Infragistics.Win.UltraWinEditors.EditorButton("ayuda")
        Dim Appearance25 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance5 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance19 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Me.txt_IdCuenta = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.uce_tip_doc = New Infragistics.Win.UltraWinEditors.UltraComboEditor()
        Me.txt_Des_Cliente = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.txt_ruc_cliente = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.UltraLabel20 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraLabel4 = New Infragistics.Win.Misc.UltraLabel()
        Me.txt_idHistoria = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.ug_data = New Infragistics.Win.UltraWinGrid.UltraGrid()
        Me.uds_Lista = New Infragistics.Win.UltraWinDataSource.UltraDataSource(Me.components)
        Me.lbl_estado = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraLabel3 = New Infragistics.Win.Misc.UltraLabel()
        Me.txt_idCuentaNueva = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.UltraLabel1 = New Infragistics.Win.Misc.UltraLabel()
        Me.lbl_estadoNuevo = New Infragistics.Win.Misc.UltraLabel()
        Me.ToolS_Mantenimiento = New System.Windows.Forms.ToolStrip()
        Me.Tool_Cambiar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.Tool_Cancelar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.Tool_Salir = New System.Windows.Forms.ToolStripButton()
        CType(Me.txt_IdCuenta, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.uce_tip_doc, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_Des_Cliente, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_ruc_cliente, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_idHistoria, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ug_data, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.uds_Lista, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_idCuentaNueva, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolS_Mantenimiento.SuspendLayout()
        Me.SuspendLayout()
        '
        'txt_IdCuenta
        '
        Appearance9.ImageHAlign = Infragistics.Win.HAlign.Center
        Appearance9.ImageVAlign = Infragistics.Win.VAlign.Middle
        EditorButton1.Appearance = Appearance9
        EditorButton1.Key = "ayuda"
        Me.txt_IdCuenta.ButtonsRight.Add(EditorButton1)
        Me.txt_IdCuenta.Location = New System.Drawing.Point(58, 37)
        Me.txt_IdCuenta.MaxLength = 11
        Me.txt_IdCuenta.Name = "txt_IdCuenta"
        Me.txt_IdCuenta.Size = New System.Drawing.Size(165, 21)
        Me.txt_IdCuenta.TabIndex = 0
        '
        'uce_tip_doc
        '
        Me.uce_tip_doc.DropDownListWidth = 300
        Me.uce_tip_doc.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.uce_tip_doc.Location = New System.Drawing.Point(58, 61)
        Me.uce_tip_doc.Name = "uce_tip_doc"
        Me.uce_tip_doc.ReadOnly = True
        Me.uce_tip_doc.Size = New System.Drawing.Size(63, 21)
        Me.uce_tip_doc.TabIndex = 216
        '
        'txt_Des_Cliente
        '
        Me.txt_Des_Cliente.Location = New System.Drawing.Point(223, 61)
        Me.txt_Des_Cliente.Name = "txt_Des_Cliente"
        Me.txt_Des_Cliente.ReadOnly = True
        Me.txt_Des_Cliente.Size = New System.Drawing.Size(528, 21)
        Me.txt_Des_Cliente.TabIndex = 218
        '
        'txt_ruc_cliente
        '
        Me.txt_ruc_cliente.Location = New System.Drawing.Point(121, 61)
        Me.txt_ruc_cliente.MaxLength = 11
        Me.txt_ruc_cliente.Name = "txt_ruc_cliente"
        Me.txt_ruc_cliente.ReadOnly = True
        Me.txt_ruc_cliente.Size = New System.Drawing.Size(102, 21)
        Me.txt_ruc_cliente.TabIndex = 217
        '
        'UltraLabel20
        '
        Appearance3.BackColor = System.Drawing.Color.Transparent
        Appearance3.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel20.Appearance = Appearance3
        Me.UltraLabel20.AutoSize = True
        Me.UltraLabel20.Location = New System.Drawing.Point(8, 65)
        Me.UltraLabel20.Name = "UltraLabel20"
        Me.UltraLabel20.Size = New System.Drawing.Size(48, 14)
        Me.UltraLabel20.TabIndex = 222
        Me.UltraLabel20.Text = "Paciente"
        '
        'UltraLabel4
        '
        Appearance8.BackColor = System.Drawing.Color.Transparent
        Appearance8.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel4.Appearance = Appearance8
        Me.UltraLabel4.AutoSize = True
        Me.UltraLabel4.Location = New System.Drawing.Point(768, 65)
        Me.UltraLabel4.Name = "UltraLabel4"
        Me.UltraLabel4.Size = New System.Drawing.Size(27, 14)
        Me.UltraLabel4.TabIndex = 221
        Me.UltraLabel4.Text = "H.C."
        '
        'txt_idHistoria
        '
        Me.txt_idHistoria.Location = New System.Drawing.Point(799, 61)
        Me.txt_idHistoria.Name = "txt_idHistoria"
        Me.txt_idHistoria.ReadOnly = True
        Me.txt_idHistoria.Size = New System.Drawing.Size(125, 21)
        Me.txt_idHistoria.TabIndex = 220
        '
        'ug_data
        '
        Me.ug_data.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ug_data.DataSource = Me.uds_Lista
        Me.ug_data.DisplayLayout.AutoFitStyle = Infragistics.Win.UltraWinGrid.AutoFitStyle.ExtendLastColumn
        UltraGridColumn1.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn1.Header.Caption = "Área"
        UltraGridColumn1.Header.VisiblePosition = 0
        UltraGridColumn1.Width = 93
        UltraGridColumn2.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn2.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn2.Header.Caption = "Código"
        UltraGridColumn2.Header.VisiblePosition = 1
        UltraGridColumn2.Width = 70
        UltraGridColumn3.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn3.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn3.Header.Caption = "Descripción"
        UltraGridColumn3.Header.VisiblePosition = 2
        UltraGridColumn3.Width = 269
        UltraGridColumn4.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn4.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn4.Header.Caption = "U. Medida"
        UltraGridColumn4.Header.VisiblePosition = 3
        UltraGridColumn4.Width = 93
        UltraGridColumn5.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn5.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn5.Header.Caption = "Precio"
        UltraGridColumn5.Header.VisiblePosition = 4
        UltraGridColumn5.Width = 74
        UltraGridColumn6.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn6.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn6.Header.Caption = "Cant"
        UltraGridColumn6.Header.VisiblePosition = 5
        UltraGridColumn6.Width = 56
        UltraGridColumn7.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn7.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn7.Header.Caption = "Sub Total"
        UltraGridColumn7.Header.VisiblePosition = 6
        UltraGridColumn7.Width = 78
        UltraGridColumn8.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn8.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn8.Header.VisiblePosition = 7
        UltraGridColumn8.Width = 77
        UltraGridColumn9.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn9.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn9.Header.Caption = "T. Doc."
        UltraGridColumn9.Header.VisiblePosition = 8
        UltraGridColumn9.Width = 45
        UltraGridColumn10.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn10.Header.Caption = "Nº Doc."
        UltraGridColumn10.Header.VisiblePosition = 9
        UltraGridColumn11.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn11.Header.VisiblePosition = 10
        UltraGridColumn11.Hidden = True
        UltraGridColumn12.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn12.Header.VisiblePosition = 11
        UltraGridColumn12.Hidden = True
        UltraGridBand1.Columns.AddRange(New Object() {UltraGridColumn1, UltraGridColumn2, UltraGridColumn3, UltraGridColumn4, UltraGridColumn5, UltraGridColumn6, UltraGridColumn7, UltraGridColumn8, UltraGridColumn9, UltraGridColumn10, UltraGridColumn11, UltraGridColumn12})
        Me.ug_data.DisplayLayout.BandsSerializer.Add(UltraGridBand1)
        Me.ug_data.DisplayLayout.MaxColScrollRegions = 1
        Me.ug_data.DisplayLayout.MaxRowScrollRegions = 1
        Me.ug_data.DisplayLayout.Override.AllowAddNew = Infragistics.Win.UltraWinGrid.AllowAddNew.No
        Me.ug_data.DisplayLayout.Override.AllowDelete = Infragistics.Win.DefaultableBoolean.[False]
        Me.ug_data.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.[False]
        Me.ug_data.DisplayLayout.Override.FilterUIType = Infragistics.Win.UltraWinGrid.FilterUIType.FilterRow
        Me.ug_data.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Appearance1.BackColor = System.Drawing.Color.WhiteSmoke
        Appearance1.BackColor2 = System.Drawing.Color.WhiteSmoke
        Me.ug_data.DisplayLayout.Override.RowAlternateAppearance = Appearance1
        Me.ug_data.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.ug_data.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.ug_data.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ug_data.Location = New System.Drawing.Point(4, 86)
        Me.ug_data.Name = "ug_data"
        Me.ug_data.Size = New System.Drawing.Size(980, 427)
        Me.ug_data.TabIndex = 3
        '
        'uds_Lista
        '
        Me.uds_Lista.AllowDelete = False
        UltraDataColumn5.DataType = GetType(Double)
        UltraDataColumn6.DataType = GetType(Double)
        UltraDataColumn7.DataType = GetType(Double)
        UltraDataColumn11.DataType = GetType(Integer)
        UltraDataColumn12.DataType = GetType(Integer)
        Me.uds_Lista.Band.Columns.AddRange(New Object() {UltraDataColumn1, UltraDataColumn2, UltraDataColumn3, UltraDataColumn4, UltraDataColumn5, UltraDataColumn6, UltraDataColumn7, UltraDataColumn8, UltraDataColumn9, UltraDataColumn10, UltraDataColumn11, UltraDataColumn12})
        '
        'lbl_estado
        '
        Appearance2.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Appearance2.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Appearance2.FontData.BoldAsString = "True"
        Appearance2.FontData.SizeInPoints = 12.0!
        Appearance2.ForeColor = System.Drawing.Color.White
        Appearance2.TextHAlignAsString = "Center"
        Me.lbl_estado.Appearance = Appearance2
        Me.lbl_estado.BorderStyleInner = Infragistics.Win.UIElementBorderStyle.Solid
        Me.lbl_estado.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_estado.Location = New System.Drawing.Point(228, 36)
        Me.lbl_estado.Name = "lbl_estado"
        Me.lbl_estado.Size = New System.Drawing.Size(123, 23)
        Me.lbl_estado.TabIndex = 227
        Me.lbl_estado.Text = "Estado"
        '
        'UltraLabel3
        '
        Appearance10.BackColor = System.Drawing.Color.Transparent
        Appearance10.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel3.Appearance = Appearance10
        Me.UltraLabel3.AutoSize = True
        Me.UltraLabel3.Location = New System.Drawing.Point(8, 41)
        Me.UltraLabel3.Name = "UltraLabel3"
        Me.UltraLabel3.Size = New System.Drawing.Size(41, 14)
        Me.UltraLabel3.TabIndex = 223
        Me.UltraLabel3.Text = "Cuenta"
        '
        'txt_idCuentaNueva
        '
        Appearance25.ImageHAlign = Infragistics.Win.HAlign.Center
        Appearance25.ImageVAlign = Infragistics.Win.VAlign.Middle
        EditorButton2.Appearance = Appearance25
        EditorButton2.Key = "ayuda"
        Me.txt_idCuentaNueva.ButtonsRight.Add(EditorButton2)
        Me.txt_idCuentaNueva.Location = New System.Drawing.Point(459, 37)
        Me.txt_idCuentaNueva.MaxLength = 11
        Me.txt_idCuentaNueva.Name = "txt_idCuentaNueva"
        Me.txt_idCuentaNueva.Size = New System.Drawing.Size(165, 21)
        Me.txt_idCuentaNueva.TabIndex = 1
        '
        'UltraLabel1
        '
        Appearance5.BackColor = System.Drawing.Color.Transparent
        Appearance5.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel1.Appearance = Appearance5
        Me.UltraLabel1.AutoSize = True
        Me.UltraLabel1.Location = New System.Drawing.Point(381, 41)
        Me.UltraLabel1.Name = "UltraLabel1"
        Me.UltraLabel1.Size = New System.Drawing.Size(76, 14)
        Me.UltraLabel1.TabIndex = 229
        Me.UltraLabel1.Text = "Nueva Cuenta"
        '
        'lbl_estadoNuevo
        '
        Appearance19.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Appearance19.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Appearance19.FontData.BoldAsString = "True"
        Appearance19.FontData.SizeInPoints = 12.0!
        Appearance19.ForeColor = System.Drawing.Color.White
        Appearance19.TextHAlignAsString = "Center"
        Me.lbl_estadoNuevo.Appearance = Appearance19
        Me.lbl_estadoNuevo.BorderStyleInner = Infragistics.Win.UIElementBorderStyle.Solid
        Me.lbl_estadoNuevo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_estadoNuevo.Location = New System.Drawing.Point(628, 36)
        Me.lbl_estadoNuevo.Name = "lbl_estadoNuevo"
        Me.lbl_estadoNuevo.Size = New System.Drawing.Size(123, 23)
        Me.lbl_estadoNuevo.TabIndex = 231
        Me.lbl_estadoNuevo.Text = "Estado"
        '
        'ToolS_Mantenimiento
        '
        Me.ToolS_Mantenimiento.BackColor = System.Drawing.Color.White
        Me.ToolS_Mantenimiento.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Tool_Cambiar, Me.ToolStripSeparator4, Me.Tool_Cancelar, Me.ToolStripSeparator1, Me.Tool_Salir})
        Me.ToolS_Mantenimiento.Location = New System.Drawing.Point(0, 0)
        Me.ToolS_Mantenimiento.Name = "ToolS_Mantenimiento"
        Me.ToolS_Mantenimiento.Size = New System.Drawing.Size(989, 25)
        Me.ToolS_Mantenimiento.TabIndex = 232
        Me.ToolS_Mantenimiento.Text = "ToolStrip1"
        '
        'Tool_Cambiar
        '
        Me.Tool_Cambiar.Image = Global.Contabilidad.My.Resources.Resources.action_refresh_blue
        Me.Tool_Cambiar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Tool_Cambiar.Name = "Tool_Cambiar"
        Me.Tool_Cambiar.Size = New System.Drawing.Size(113, 22)
        Me.Tool_Cambiar.Text = "Cambiar Cuenta"
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
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'Tool_Salir
        '
        Me.Tool_Salir.Image = Global.Contabilidad.My.Resources.Resources._28
        Me.Tool_Salir.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Tool_Salir.Name = "Tool_Salir"
        Me.Tool_Salir.Size = New System.Drawing.Size(49, 22)
        Me.Tool_Salir.Text = "Salir"
        '
        'LO_LT_CambioCuenta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(989, 516)
        Me.Controls.Add(Me.ToolS_Mantenimiento)
        Me.Controls.Add(Me.lbl_estadoNuevo)
        Me.Controls.Add(Me.txt_idCuentaNueva)
        Me.Controls.Add(Me.UltraLabel1)
        Me.Controls.Add(Me.txt_IdCuenta)
        Me.Controls.Add(Me.uce_tip_doc)
        Me.Controls.Add(Me.txt_Des_Cliente)
        Me.Controls.Add(Me.txt_ruc_cliente)
        Me.Controls.Add(Me.UltraLabel20)
        Me.Controls.Add(Me.UltraLabel4)
        Me.Controls.Add(Me.txt_idHistoria)
        Me.Controls.Add(Me.ug_data)
        Me.Controls.Add(Me.lbl_estado)
        Me.Controls.Add(Me.UltraLabel3)
        Me.Name = "LO_LT_CambioCuenta"
        Me.Text = "Cambio de Cuenta"
        CType(Me.txt_IdCuenta, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.uce_tip_doc, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_Des_Cliente, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_ruc_cliente, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_idHistoria, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ug_data, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.uds_Lista, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_idCuentaNueva, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolS_Mantenimiento.ResumeLayout(False)
        Me.ToolS_Mantenimiento.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txt_IdCuenta As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents uce_tip_doc As Infragistics.Win.UltraWinEditors.UltraComboEditor
    Friend WithEvents txt_Des_Cliente As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents txt_ruc_cliente As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents UltraLabel20 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel4 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents txt_idHistoria As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents ug_data As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents uds_Lista As Infragistics.Win.UltraWinDataSource.UltraDataSource
    Friend WithEvents lbl_estado As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel3 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents txt_idCuentaNueva As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents UltraLabel1 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents lbl_estadoNuevo As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents ToolS_Mantenimiento As System.Windows.Forms.ToolStrip
    Friend WithEvents Tool_Cambiar As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents Tool_Cancelar As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents Tool_Salir As System.Windows.Forms.ToolStripButton
End Class
