<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TE_RE_Facturas_por_fecha
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
        Dim Appearance2 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim ValueListItem1 As Infragistics.Win.ValueListItem = New Infragistics.Win.ValueListItem()
        Dim ValueListItem2 As Infragistics.Win.ValueListItem = New Infragistics.Win.ValueListItem()
        Dim Appearance94 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance3 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance1 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraDataColumn1 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("FECHA")
        Dim UltraDataColumn2 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("FACTURA")
        Dim UltraDataColumn3 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("RUC")
        Dim UltraDataColumn4 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("MONEDA")
        Dim UltraDataColumn5 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("TIPCAM")
        Dim UltraDataColumn6 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("SUBTOTAL")
        Dim UltraDataColumn7 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IGV")
        Dim UltraDataColumn8 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("TOTAL")
        Dim UltraDataColumn9 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("PACIENTE")
        Dim UltraDataColumn10 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("USUARIO")
        Dim UltraDataColumn11 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("OBSERVACIONES")
        Dim UltraDataColumn12 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("FORMA_PAGO")
        Dim UltraDataColumn13 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("ESTADO")
        Dim UltraGridBand1 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1)
        Dim UltraGridColumn1 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FECHA")
        Dim UltraGridColumn2 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FACTURA")
        Dim UltraGridColumn3 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("RUC")
        Dim UltraGridColumn4 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("MONEDA")
        Dim UltraGridColumn5 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TIPCAM")
        Dim Appearance5 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn6 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("SUBTOTAL")
        Dim Appearance6 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn7 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IGV")
        Dim Appearance7 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn8 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TOTAL")
        Dim Appearance8 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn9 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("PACIENTE")
        Dim UltraGridColumn10 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("USUARIO")
        Dim UltraGridColumn11 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("OBSERVACIONES")
        Dim UltraGridColumn12 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FORMA_PAGO")
        Dim UltraGridColumn13 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ESTADO")
        Dim Appearance16 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Me.UltraLabel1 = New Infragistics.Win.Misc.UltraLabel()
        Me.ugb_datos = New Infragistics.Win.Misc.UltraGroupBox()
        Me.upb_fts = New Infragistics.Win.UltraWinProgressBar.UltraProgressBar()
        Me.UltraLabel3 = New Infragistics.Win.Misc.UltraLabel()
        Me.uce_tipCom = New Infragistics.Win.UltraWinEditors.UltraComboEditor()
        Me.btn_Consultar = New Infragistics.Win.Misc.UltraButton()
        Me.udte_fecha2 = New Infragistics.Win.UltraWinEditors.UltraDateTimeEditor()
        Me.UltraLabel2 = New Infragistics.Win.Misc.UltraLabel()
        Me.udte_fecha1 = New Infragistics.Win.UltraWinEditors.UltraDateTimeEditor()
        Me.UltraLabel5 = New Infragistics.Win.Misc.UltraLabel()
        Me.ToolS_Mantenimiento = New System.Windows.Forms.ToolStrip()
        Me.Tool_Exportar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.Tool_Salir = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.uds_fts = New Infragistics.Win.UltraWinDataSource.UltraDataSource(Me.components)
        Me.ug_fts = New Infragistics.Win.UltraWinGrid.UltraGrid()
        CType(Me.ugb_datos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ugb_datos.SuspendLayout()
        CType(Me.uce_tipCom, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.udte_fecha2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.udte_fecha1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolS_Mantenimiento.SuspendLayout()
        CType(Me.uds_fts, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ug_fts, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'UltraLabel1
        '
        Appearance4.BackColor = System.Drawing.Color.Transparent
        Appearance4.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel1.Appearance = Appearance4
        Me.UltraLabel1.AutoSize = True
        Me.UltraLabel1.Location = New System.Drawing.Point(190, 23)
        Me.UltraLabel1.Name = "UltraLabel1"
        Me.UltraLabel1.Size = New System.Drawing.Size(71, 14)
        Me.UltraLabel1.TabIndex = 7
        Me.UltraLabel1.Text = "Fecha Desde"
        '
        'ugb_datos
        '
        Me.ugb_datos.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ugb_datos.Controls.Add(Me.upb_fts)
        Me.ugb_datos.Controls.Add(Me.UltraLabel3)
        Me.ugb_datos.Controls.Add(Me.uce_tipCom)
        Me.ugb_datos.Controls.Add(Me.btn_Consultar)
        Me.ugb_datos.Controls.Add(Me.udte_fecha2)
        Me.ugb_datos.Controls.Add(Me.UltraLabel2)
        Me.ugb_datos.Controls.Add(Me.udte_fecha1)
        Me.ugb_datos.Controls.Add(Me.UltraLabel5)
        Me.ugb_datos.Controls.Add(Me.UltraLabel1)
        Me.ugb_datos.Location = New System.Drawing.Point(12, 31)
        Me.ugb_datos.Name = "ugb_datos"
        Me.ugb_datos.Size = New System.Drawing.Size(1021, 57)
        Me.ugb_datos.TabIndex = 12
        '
        'upb_fts
        '
        Me.upb_fts.Location = New System.Drawing.Point(751, 18)
        Me.upb_fts.Name = "upb_fts"
        Me.upb_fts.Size = New System.Drawing.Size(249, 23)
        Me.upb_fts.TabIndex = 30
        Me.upb_fts.Text = "[Formatted]"
        '
        'UltraLabel3
        '
        Appearance2.BackColor = System.Drawing.Color.Transparent
        Appearance2.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel3.Appearance = Appearance2
        Me.UltraLabel3.AutoSize = True
        Me.UltraLabel3.Location = New System.Drawing.Point(16, 23)
        Me.UltraLabel3.Name = "UltraLabel3"
        Me.UltraLabel3.Size = New System.Drawing.Size(26, 14)
        Me.UltraLabel3.TabIndex = 29
        Me.UltraLabel3.Text = "Tipo"
        '
        'uce_tipCom
        '
        Me.uce_tipCom.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        ValueListItem1.DataValue = "01"
        ValueListItem1.DisplayText = "Facturas"
        ValueListItem2.DataValue = "03"
        ValueListItem2.DisplayText = "Boletas"
        Me.uce_tipCom.Items.AddRange(New Infragistics.Win.ValueListItem() {ValueListItem1, ValueListItem2})
        Me.uce_tipCom.Location = New System.Drawing.Point(48, 20)
        Me.uce_tipCom.Name = "uce_tipCom"
        Me.uce_tipCom.Size = New System.Drawing.Size(119, 21)
        Me.uce_tipCom.TabIndex = 28
        '
        'btn_Consultar
        '
        Appearance94.ImageHAlign = Infragistics.Win.HAlign.Left
        Appearance94.ImageVAlign = Infragistics.Win.VAlign.Middle
        Appearance94.TextHAlignAsString = "Center"
        Me.btn_Consultar.Appearance = Appearance94
        Me.btn_Consultar.ButtonStyle = Infragistics.Win.UIElementButtonStyle.Office2007RibbonButton
        Me.btn_Consultar.Location = New System.Drawing.Point(630, 14)
        Me.btn_Consultar.Name = "btn_Consultar"
        Me.btn_Consultar.Size = New System.Drawing.Size(103, 34)
        Me.btn_Consultar.TabIndex = 27
        Me.btn_Consultar.Text = "&Consultar"
        '
        'udte_fecha2
        '
        Me.udte_fecha2.DateTime = New Date(2014, 1, 28, 0, 0, 0, 0)
        Me.udte_fecha2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.udte_fecha2.Location = New System.Drawing.Point(475, 17)
        Me.udte_fecha2.Name = "udte_fecha2"
        Me.udte_fecha2.Size = New System.Drawing.Size(111, 24)
        Me.udte_fecha2.TabIndex = 26
        Me.udte_fecha2.Value = New Date(2014, 1, 28, 0, 0, 0, 0)
        '
        'UltraLabel2
        '
        Appearance3.BackColor = System.Drawing.Color.Transparent
        Appearance3.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel2.Appearance = Appearance3
        Me.UltraLabel2.AutoSize = True
        Me.UltraLabel2.Location = New System.Drawing.Point(401, 23)
        Me.UltraLabel2.Name = "UltraLabel2"
        Me.UltraLabel2.Size = New System.Drawing.Size(68, 14)
        Me.UltraLabel2.TabIndex = 25
        Me.UltraLabel2.Text = "Fecha Hasta"
        '
        'udte_fecha1
        '
        Me.udte_fecha1.DateTime = New Date(2014, 1, 28, 0, 0, 0, 0)
        Me.udte_fecha1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.udte_fecha1.Location = New System.Drawing.Point(267, 17)
        Me.udte_fecha1.Name = "udte_fecha1"
        Me.udte_fecha1.Size = New System.Drawing.Size(111, 24)
        Me.udte_fecha1.TabIndex = 24
        Me.udte_fecha1.Value = New Date(2014, 1, 28, 0, 0, 0, 0)
        '
        'UltraLabel5
        '
        Appearance1.BackColor = System.Drawing.Color.Transparent
        Appearance1.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel5.Appearance = Appearance1
        Me.UltraLabel5.AutoSize = True
        Me.UltraLabel5.Location = New System.Drawing.Point(36, 45)
        Me.UltraLabel5.Name = "UltraLabel5"
        Me.UltraLabel5.Size = New System.Drawing.Size(0, 0)
        Me.UltraLabel5.TabIndex = 23
        '
        'ToolS_Mantenimiento
        '
        Me.ToolS_Mantenimiento.BackColor = System.Drawing.Color.White
        Me.ToolS_Mantenimiento.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Tool_Exportar, Me.ToolStripSeparator3, Me.Tool_Salir, Me.ToolStripSeparator2})
        Me.ToolS_Mantenimiento.Location = New System.Drawing.Point(0, 0)
        Me.ToolS_Mantenimiento.Name = "ToolS_Mantenimiento"
        Me.ToolS_Mantenimiento.Size = New System.Drawing.Size(1043, 25)
        Me.ToolS_Mantenimiento.TabIndex = 154
        Me.ToolS_Mantenimiento.Text = "ToolStrip1"
        '
        'Tool_Exportar
        '
        Me.Tool_Exportar.Image = Global.Contabilidad.My.Resources.Resources._16__Doc_excel_
        Me.Tool_Exportar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Tool_Exportar.Name = "Tool_Exportar"
        Me.Tool_Exportar.Size = New System.Drawing.Size(70, 22)
        Me.Tool_Exportar.Text = "Exportar"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 25)
        '
        'Tool_Salir
        '
        Me.Tool_Salir.Image = Global.Contabilidad.My.Resources.Resources._28
        Me.Tool_Salir.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Tool_Salir.Name = "Tool_Salir"
        Me.Tool_Salir.Size = New System.Drawing.Size(49, 22)
        Me.Tool_Salir.Text = "Salir"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'uds_fts
        '
        Me.uds_fts.AllowAdd = False
        Me.uds_fts.AllowDelete = False
        UltraDataColumn1.DataType = GetType(Date)
        UltraDataColumn5.DataType = GetType(Double)
        UltraDataColumn6.DataType = GetType(Double)
        UltraDataColumn7.DataType = GetType(Double)
        UltraDataColumn8.DataType = GetType(Double)
        Me.uds_fts.Band.Columns.AddRange(New Object() {UltraDataColumn1, UltraDataColumn2, UltraDataColumn3, UltraDataColumn4, UltraDataColumn5, UltraDataColumn6, UltraDataColumn7, UltraDataColumn8, UltraDataColumn9, UltraDataColumn10, UltraDataColumn11, UltraDataColumn12, UltraDataColumn13})
        '
        'ug_fts
        '
        Me.ug_fts.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ug_fts.DataSource = Me.uds_fts
        Me.ug_fts.DisplayLayout.AutoFitStyle = Infragistics.Win.UltraWinGrid.AutoFitStyle.ExtendLastColumn
        UltraGridColumn1.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn1.Header.VisiblePosition = 0
        UltraGridColumn2.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn2.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn2.Header.VisiblePosition = 1
        UltraGridColumn3.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn3.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn3.Header.VisiblePosition = 2
        UltraGridColumn3.Width = 93
        UltraGridColumn4.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn4.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn4.Header.VisiblePosition = 3
        UltraGridColumn4.Width = 39
        UltraGridColumn5.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn5.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        Appearance5.TextHAlignAsString = "Right"
        UltraGridColumn5.CellAppearance = Appearance5
        UltraGridColumn5.Header.VisiblePosition = 4
        UltraGridColumn5.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Double]
        UltraGridColumn5.Width = 56
        UltraGridColumn6.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn6.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        Appearance6.TextHAlignAsString = "Right"
        UltraGridColumn6.CellAppearance = Appearance6
        UltraGridColumn6.Header.VisiblePosition = 5
        UltraGridColumn6.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Double]
        UltraGridColumn7.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn7.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        Appearance7.TextHAlignAsString = "Right"
        UltraGridColumn7.CellAppearance = Appearance7
        UltraGridColumn7.Header.VisiblePosition = 6
        UltraGridColumn7.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Double]
        UltraGridColumn8.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn8.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        Appearance8.TextHAlignAsString = "Right"
        UltraGridColumn8.CellAppearance = Appearance8
        UltraGridColumn8.Header.VisiblePosition = 7
        UltraGridColumn8.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Double]
        UltraGridColumn9.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn9.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn9.Header.VisiblePosition = 8
        UltraGridColumn9.Width = 258
        UltraGridColumn10.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn10.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn10.Header.VisiblePosition = 9
        UltraGridColumn11.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn11.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn11.Header.VisiblePosition = 10
        UltraGridColumn11.Width = 197
        UltraGridColumn12.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn12.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn12.Header.VisiblePosition = 11
        UltraGridColumn13.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn13.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn13.Header.VisiblePosition = 12
        UltraGridBand1.Columns.AddRange(New Object() {UltraGridColumn1, UltraGridColumn2, UltraGridColumn3, UltraGridColumn4, UltraGridColumn5, UltraGridColumn6, UltraGridColumn7, UltraGridColumn8, UltraGridColumn9, UltraGridColumn10, UltraGridColumn11, UltraGridColumn12, UltraGridColumn13})
        Me.ug_fts.DisplayLayout.BandsSerializer.Add(UltraGridBand1)
        Me.ug_fts.DisplayLayout.GroupByBox.Hidden = True
        Me.ug_fts.DisplayLayout.MaxColScrollRegions = 1
        Me.ug_fts.DisplayLayout.MaxRowScrollRegions = 1
        Me.ug_fts.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        Me.ug_fts.DisplayLayout.Override.FilterOperatorDefaultValue = Infragistics.Win.UltraWinGrid.FilterOperatorDefaultValue.Contains
        Me.ug_fts.DisplayLayout.Override.FilterUIType = Infragistics.Win.UltraWinGrid.FilterUIType.FilterRow
        Me.ug_fts.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Appearance16.BackColor = System.Drawing.Color.WhiteSmoke
        Appearance16.BackColor2 = System.Drawing.Color.WhiteSmoke
        Me.ug_fts.DisplayLayout.Override.RowAlternateAppearance = Appearance16
        Me.ug_fts.DisplayLayout.Override.WrapHeaderText = Infragistics.Win.DefaultableBoolean.[True]
        Me.ug_fts.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.ug_fts.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.ug_fts.DisplayLayout.ViewStyle = Infragistics.Win.UltraWinGrid.ViewStyle.SingleBand
        Me.ug_fts.Location = New System.Drawing.Point(12, 94)
        Me.ug_fts.Name = "ug_fts"
        Me.ug_fts.Size = New System.Drawing.Size(1021, 419)
        Me.ug_fts.TabIndex = 155
        '
        'TE_RE_Facturas_por_fecha
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(1043, 525)
        Me.Controls.Add(Me.ug_fts)
        Me.Controls.Add(Me.ToolS_Mantenimiento)
        Me.Controls.Add(Me.ugb_datos)
        Me.Name = "TE_RE_Facturas_por_fecha"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Reporte de facturas"
        CType(Me.ugb_datos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ugb_datos.ResumeLayout(False)
        Me.ugb_datos.PerformLayout()
        CType(Me.uce_tipCom, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.udte_fecha2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.udte_fecha1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolS_Mantenimiento.ResumeLayout(False)
        Me.ToolS_Mantenimiento.PerformLayout()
        CType(Me.uds_fts, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ug_fts, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents UltraLabel1 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents ugb_datos As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents UltraLabel5 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents udte_fecha1 As Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
    Friend WithEvents ToolS_Mantenimiento As System.Windows.Forms.ToolStrip
    Friend WithEvents Tool_Salir As System.Windows.Forms.ToolStripButton
    Friend WithEvents udte_fecha2 As Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
    Friend WithEvents UltraLabel2 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents btn_Consultar As Infragistics.Win.Misc.UltraButton
    Friend WithEvents Tool_Exportar As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents uds_fts As Infragistics.Win.UltraWinDataSource.UltraDataSource
    Friend WithEvents ug_fts As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents UltraLabel3 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents uce_tipCom As Infragistics.Win.UltraWinEditors.UltraComboEditor
    Friend WithEvents upb_fts As Infragistics.Win.UltraWinProgressBar.UltraProgressBar
End Class
