<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LO_LT_Mante_ComproB
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
        Dim Appearance19 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance1 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance5 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim ValueListItem1 As Infragistics.Win.ValueListItem = New Infragistics.Win.ValueListItem()
        Dim ValueListItem2 As Infragistics.Win.ValueListItem = New Infragistics.Win.ValueListItem()
        Dim ValueListItem3 As Infragistics.Win.ValueListItem = New Infragistics.Win.ValueListItem()
        Dim Appearance6 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance11 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraDataColumn1 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("CO_ID")
        Dim UltraDataColumn2 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("CO_TDOC")
        Dim UltraDataColumn3 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("CO_SDOC")
        Dim UltraDataColumn4 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("CO_NDOC")
        Dim UltraDataColumn5 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("CO_FDOC")
        Dim UltraDataColumn6 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("CO_IDPROVE")
        Dim UltraDataColumn7 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("PR_DESCRIPCION")
        Dim UltraDataColumn8 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("CO_TOTAL")
        Dim UltraDataColumn9 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("CO_ESTADO")
        Dim UltraDataColumn10 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("CO_IDVOUCHER")
        Dim UltraDataColumn11 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("CO_IDMONEDA")
        Dim UltraDataColumn12 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("FP_DESCRIPCION")
        Dim UltraDataColumn13 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("ESTADO")
        Dim Appearance2 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridBand1 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1)
        Dim UltraGridColumn1 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CO_ID")
        Dim UltraGridColumn2 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CO_TDOC")
        Dim UltraGridColumn3 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CO_SDOC")
        Dim UltraGridColumn4 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CO_NDOC")
        Dim UltraGridColumn5 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CO_FDOC")
        Dim Appearance3 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn6 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CO_IDPROVE")
        Dim UltraGridColumn7 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("PR_DESCRIPCION")
        Dim UltraGridColumn8 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CO_TOTAL")
        Dim Appearance4 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn9 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CO_ESTADO")
        Dim UltraGridColumn10 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CO_IDVOUCHER")
        Dim UltraGridColumn11 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CO_IDMONEDA")
        Dim UltraGridColumn12 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ESTADO")
        Dim UltraGridColumn13 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FP_DESCRIPCION")
        Dim SummarySettings1 As Infragistics.Win.UltraWinGrid.SummarySettings = New Infragistics.Win.UltraWinGrid.SummarySettings("", Infragistics.Win.UltraWinGrid.SummaryType.Count, Nothing, "CO_TDOC", 1, True, "Band 0", 0, Infragistics.Win.UltraWinGrid.SummaryPosition.Left, Nothing, -1, False)
        Dim Appearance7 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance8 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance9 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance10 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Me.ToolS_Mantenimiento = New System.Windows.Forms.ToolStrip()
        Me.Tool_Nuevo = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator8 = New System.Windows.Forms.ToolStripSeparator()
        Me.Tool_Consultar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.Tool_Anular = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator()
        Me.Tool_Actualizar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.Tool_NotaCredito = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.Tool_Salir = New System.Windows.Forms.ToolStripButton()
        Me.UltraGroupBox1 = New Infragistics.Win.Misc.UltraGroupBox()
        Me.txt_año = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.ulbA = New Infragistics.Win.Misc.UltraLabel()
        Me.uce_Mes = New Infragistics.Win.UltraWinEditors.UltraComboEditor()
        Me.UltraLabel10 = New Infragistics.Win.Misc.UltraLabel()
        Me.uce_tipo = New Infragistics.Win.UltraWinEditors.UltraComboEditor()
        Me.udte_hasta = New Infragistics.Win.UltraWinEditors.UltraDateTimeEditor()
        Me.udte_desde = New Infragistics.Win.UltraWinEditors.UltraDateTimeEditor()
        Me.lbl_hasta = New Infragistics.Win.Misc.UltraLabel()
        Me.lbl_desde = New Infragistics.Win.Misc.UltraLabel()
        Me.uds_Listado = New Infragistics.Win.UltraWinDataSource.UltraDataSource(Me.components)
        Me.ug_Listado = New Infragistics.Win.UltraWinGrid.UltraGrid()
        Me.ToolS_Mantenimiento.SuspendLayout()
        CType(Me.UltraGroupBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraGroupBox1.SuspendLayout()
        CType(Me.txt_año, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.uce_Mes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.uce_tipo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.udte_hasta, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.udte_desde, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.uds_Listado, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ug_Listado, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ToolS_Mantenimiento
        '
        Me.ToolS_Mantenimiento.BackColor = System.Drawing.Color.White
        Me.ToolS_Mantenimiento.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Tool_Nuevo, Me.ToolStripSeparator8, Me.Tool_Consultar, Me.ToolStripSeparator4, Me.Tool_Anular, Me.ToolStripSeparator5, Me.Tool_Actualizar, Me.ToolStripSeparator1, Me.Tool_NotaCredito, Me.ToolStripSeparator3, Me.Tool_Salir})
        Me.ToolS_Mantenimiento.Location = New System.Drawing.Point(0, 0)
        Me.ToolS_Mantenimiento.Name = "ToolS_Mantenimiento"
        Me.ToolS_Mantenimiento.Size = New System.Drawing.Size(958, 25)
        Me.ToolS_Mantenimiento.TabIndex = 6
        Me.ToolS_Mantenimiento.Text = "ToolStrip1"
        '
        'Tool_Nuevo
        '
        Me.Tool_Nuevo.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Tool_Nuevo.Image = Global.Contabilidad.My.Resources.Resources._16__File_new_2_
        Me.Tool_Nuevo.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Tool_Nuevo.Name = "Tool_Nuevo"
        Me.Tool_Nuevo.Size = New System.Drawing.Size(62, 22)
        Me.Tool_Nuevo.Text = "Nuevo"
        '
        'ToolStripSeparator8
        '
        Me.ToolStripSeparator8.Name = "ToolStripSeparator8"
        Me.ToolStripSeparator8.Size = New System.Drawing.Size(6, 25)
        '
        'Tool_Consultar
        '
        Me.Tool_Consultar.Image = Global.Contabilidad.My.Resources.Resources._16__Settings_
        Me.Tool_Consultar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Tool_Consultar.Name = "Tool_Consultar"
        Me.Tool_Consultar.Size = New System.Drawing.Size(78, 22)
        Me.Tool_Consultar.Text = "Modificar"
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(6, 25)
        '
        'Tool_Anular
        '
        Me.Tool_Anular.Image = Global.Contabilidad.My.Resources.Resources._16__Delete_
        Me.Tool_Anular.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Tool_Anular.Name = "Tool_Anular"
        Me.Tool_Anular.Size = New System.Drawing.Size(62, 22)
        Me.Tool_Anular.Text = "Anular"
        '
        'ToolStripSeparator5
        '
        Me.ToolStripSeparator5.Name = "ToolStripSeparator5"
        Me.ToolStripSeparator5.Size = New System.Drawing.Size(6, 25)
        '
        'Tool_Actualizar
        '
        Me.Tool_Actualizar.Image = Global.Contabilidad.My.Resources.Resources._726
        Me.Tool_Actualizar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Tool_Actualizar.Name = "Tool_Actualizar"
        Me.Tool_Actualizar.Size = New System.Drawing.Size(79, 22)
        Me.Tool_Actualizar.Text = "Actualizar"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'Tool_NotaCredito
        '
        Me.Tool_NotaCredito.Image = Global.Contabilidad.My.Resources.Resources._16__Copy_plus_
        Me.Tool_NotaCredito.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Tool_NotaCredito.Name = "Tool_NotaCredito"
        Me.Tool_NotaCredito.Size = New System.Drawing.Size(111, 22)
        Me.Tool_NotaCredito.Text = "Nota de Crédito"
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
        'UltraGroupBox1
        '
        Me.UltraGroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.UltraGroupBox1.Controls.Add(Me.txt_año)
        Me.UltraGroupBox1.Controls.Add(Me.ulbA)
        Me.UltraGroupBox1.Controls.Add(Me.uce_Mes)
        Me.UltraGroupBox1.Controls.Add(Me.UltraLabel10)
        Me.UltraGroupBox1.Controls.Add(Me.uce_tipo)
        Me.UltraGroupBox1.Controls.Add(Me.udte_hasta)
        Me.UltraGroupBox1.Controls.Add(Me.udte_desde)
        Me.UltraGroupBox1.Controls.Add(Me.lbl_hasta)
        Me.UltraGroupBox1.Controls.Add(Me.lbl_desde)
        Me.UltraGroupBox1.Location = New System.Drawing.Point(12, 32)
        Me.UltraGroupBox1.Name = "UltraGroupBox1"
        Me.UltraGroupBox1.Size = New System.Drawing.Size(934, 37)
        Me.UltraGroupBox1.TabIndex = 7
        '
        'txt_año
        '
        Appearance19.TextHAlignAsString = "Left"
        Me.txt_año.Appearance = Appearance19
        Me.txt_año.Location = New System.Drawing.Point(472, 10)
        Me.txt_año.Name = "txt_año"
        Me.txt_año.Size = New System.Drawing.Size(52, 21)
        Me.txt_año.TabIndex = 195
        '
        'ulbA
        '
        Appearance1.BackColor = System.Drawing.Color.Transparent
        Appearance1.ForeColor = System.Drawing.Color.Navy
        Me.ulbA.Appearance = Appearance1
        Me.ulbA.AutoSize = True
        Me.ulbA.Location = New System.Drawing.Point(438, 14)
        Me.ulbA.Name = "ulbA"
        Me.ulbA.Size = New System.Drawing.Size(24, 14)
        Me.ulbA.TabIndex = 194
        Me.ulbA.Text = "Año"
        '
        'uce_Mes
        '
        Me.uce_Mes.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.uce_Mes.Location = New System.Drawing.Point(273, 10)
        Me.uce_Mes.Name = "uce_Mes"
        Me.uce_Mes.Size = New System.Drawing.Size(153, 21)
        Me.uce_Mes.TabIndex = 193
        '
        'UltraLabel10
        '
        Appearance5.BackColor = System.Drawing.Color.Transparent
        Appearance5.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel10.Appearance = Appearance5
        Me.UltraLabel10.AutoSize = True
        Me.UltraLabel10.Location = New System.Drawing.Point(22, 14)
        Me.UltraLabel10.Name = "UltraLabel10"
        Me.UltraLabel10.Size = New System.Drawing.Size(26, 14)
        Me.UltraLabel10.TabIndex = 192
        Me.UltraLabel10.Text = "Tipo"
        '
        'uce_tipo
        '
        Me.uce_tipo.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        ValueListItem1.DataValue = "1"
        ValueListItem1.DisplayText = "Diario"
        ValueListItem2.DataValue = "2"
        ValueListItem2.DisplayText = "Semanal"
        ValueListItem3.DataValue = "3"
        ValueListItem3.DisplayText = "Mensual"
        Me.uce_tipo.Items.AddRange(New Infragistics.Win.ValueListItem() {ValueListItem1, ValueListItem2, ValueListItem3})
        Me.uce_tipo.Location = New System.Drawing.Point(54, 10)
        Me.uce_tipo.Name = "uce_tipo"
        Me.uce_tipo.Size = New System.Drawing.Size(144, 21)
        Me.uce_tipo.TabIndex = 191
        '
        'udte_hasta
        '
        Me.udte_hasta.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.udte_hasta.Location = New System.Drawing.Point(472, 10)
        Me.udte_hasta.MaskInput = "{date}"
        Me.udte_hasta.Name = "udte_hasta"
        Me.udte_hasta.Size = New System.Drawing.Size(86, 21)
        Me.udte_hasta.TabIndex = 190
        '
        'udte_desde
        '
        Me.udte_desde.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.udte_desde.Location = New System.Drawing.Point(340, 10)
        Me.udte_desde.MaskInput = "{date}"
        Me.udte_desde.Name = "udte_desde"
        Me.udte_desde.Size = New System.Drawing.Size(86, 21)
        Me.udte_desde.TabIndex = 190
        '
        'lbl_hasta
        '
        Appearance6.BackColor = System.Drawing.Color.Transparent
        Appearance6.ForeColor = System.Drawing.Color.Navy
        Me.lbl_hasta.Appearance = Appearance6
        Me.lbl_hasta.AutoSize = True
        Me.lbl_hasta.Location = New System.Drawing.Point(365, 14)
        Me.lbl_hasta.Name = "lbl_hasta"
        Me.lbl_hasta.Size = New System.Drawing.Size(40, 14)
        Me.lbl_hasta.TabIndex = 189
        Me.lbl_hasta.Text = "Hasta :"
        '
        'lbl_desde
        '
        Appearance11.BackColor = System.Drawing.Color.Transparent
        Appearance11.ForeColor = System.Drawing.Color.Navy
        Me.lbl_desde.Appearance = Appearance11
        Me.lbl_desde.AutoSize = True
        Me.lbl_desde.Location = New System.Drawing.Point(230, 14)
        Me.lbl_desde.Name = "lbl_desde"
        Me.lbl_desde.Size = New System.Drawing.Size(37, 14)
        Me.lbl_desde.TabIndex = 189
        Me.lbl_desde.Text = "Desde"
        '
        'uds_Listado
        '
        Me.uds_Listado.AllowDelete = False
        UltraDataColumn5.DataType = GetType(Date)
        UltraDataColumn6.DataType = GetType(Integer)
        UltraDataColumn8.DataType = GetType(Double)
        UltraDataColumn9.DataType = GetType(Short)
        UltraDataColumn10.DataType = GetType(Long)
        Me.uds_Listado.Band.Columns.AddRange(New Object() {UltraDataColumn1, UltraDataColumn2, UltraDataColumn3, UltraDataColumn4, UltraDataColumn5, UltraDataColumn6, UltraDataColumn7, UltraDataColumn8, UltraDataColumn9, UltraDataColumn10, UltraDataColumn11, UltraDataColumn12, UltraDataColumn13})
        '
        'ug_Listado
        '
        Me.ug_Listado.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ug_Listado.DataSource = Me.uds_Listado
        Appearance2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ug_Listado.DisplayLayout.Appearance = Appearance2
        Me.ug_Listado.DisplayLayout.AutoFitStyle = Infragistics.Win.UltraWinGrid.AutoFitStyle.ExtendLastColumn
        UltraGridColumn1.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn1.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn1.Header.VisiblePosition = 0
        UltraGridColumn1.Hidden = True
        UltraGridColumn1.Width = 58
        UltraGridColumn2.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn2.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn2.Header.Caption = "Tip Doc"
        UltraGridColumn2.Header.VisiblePosition = 1
        UltraGridColumn2.Width = 70
        UltraGridColumn3.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn3.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn3.Header.Caption = "Serie"
        UltraGridColumn3.Header.VisiblePosition = 2
        UltraGridColumn3.Width = 70
        UltraGridColumn4.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn4.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn4.Header.Caption = "Numero"
        UltraGridColumn4.Header.VisiblePosition = 3
        UltraGridColumn4.Width = 100
        UltraGridColumn5.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn5.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        Appearance3.TextHAlignAsString = "Center"
        UltraGridColumn5.CellAppearance = Appearance3
        UltraGridColumn5.Header.Caption = "Fecha"
        UltraGridColumn5.Header.VisiblePosition = 4
        UltraGridColumn5.Width = 100
        UltraGridColumn6.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn6.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn6.Header.VisiblePosition = 5
        UltraGridColumn6.Hidden = True
        UltraGridColumn6.Width = 61
        UltraGridColumn7.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn7.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn7.Header.Caption = "Proveedor"
        UltraGridColumn7.Header.VisiblePosition = 6
        UltraGridColumn7.Width = 342
        UltraGridColumn8.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn8.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        Appearance4.TextHAlignAsString = "Right"
        UltraGridColumn8.CellAppearance = Appearance4
        UltraGridColumn8.Header.Caption = "Importe"
        UltraGridColumn8.Header.VisiblePosition = 7
        UltraGridColumn8.MaskDisplayMode = Infragistics.Win.UltraWinMaskedEdit.MaskMode.IncludeLiterals
        UltraGridColumn8.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Double]
        UltraGridColumn8.Width = 81
        UltraGridColumn9.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn9.Header.VisiblePosition = 8
        UltraGridColumn9.Hidden = True
        UltraGridColumn10.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn10.Header.VisiblePosition = 9
        UltraGridColumn10.Hidden = True
        UltraGridColumn11.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn11.Header.VisiblePosition = 10
        UltraGridColumn11.Hidden = True
        UltraGridColumn12.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn12.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn12.Header.Caption = "Estado"
        UltraGridColumn12.Header.VisiblePosition = 12
        UltraGridColumn12.Width = 70
        UltraGridColumn13.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn13.Header.Caption = "TIPO PAGO"
        UltraGridColumn13.Header.VisiblePosition = 11
        UltraGridColumn13.Width = 77
        UltraGridBand1.Columns.AddRange(New Object() {UltraGridColumn1, UltraGridColumn2, UltraGridColumn3, UltraGridColumn4, UltraGridColumn5, UltraGridColumn6, UltraGridColumn7, UltraGridColumn8, UltraGridColumn9, UltraGridColumn10, UltraGridColumn11, UltraGridColumn12, UltraGridColumn13})
        Appearance7.BackColor = System.Drawing.Color.White
        Appearance7.FontData.SizeInPoints = 10.0!
        Appearance7.ForeColor = System.Drawing.Color.Navy
        SummarySettings1.Appearance = Appearance7
        SummarySettings1.DisplayFormat = "N° de Comprobantes  = {0}"
        SummarySettings1.GroupBySummaryValueAppearance = Appearance8
        SummarySettings1.SummaryDisplayArea = Infragistics.Win.UltraWinGrid.SummaryDisplayAreas.BottomFixed
        UltraGridBand1.Summaries.AddRange(New Infragistics.Win.UltraWinGrid.SummarySettings() {SummarySettings1})
        UltraGridBand1.SummaryFooterCaption = ""
        Me.ug_Listado.DisplayLayout.BandsSerializer.Add(UltraGridBand1)
        Me.ug_Listado.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.[False]
        Me.ug_Listado.DisplayLayout.MaxColScrollRegions = 1
        Me.ug_Listado.DisplayLayout.MaxRowScrollRegions = 1
        Appearance9.BackColor = System.Drawing.Color.LightGoldenrodYellow
        Me.ug_Listado.DisplayLayout.Override.FilterRowAppearance = Appearance9
        Me.ug_Listado.DisplayLayout.Override.FilterUIType = Infragistics.Win.UltraWinGrid.FilterUIType.FilterRow
        Appearance10.BackColor = System.Drawing.Color.WhiteSmoke
        Appearance10.BackColor2 = System.Drawing.Color.WhiteSmoke
        Me.ug_Listado.DisplayLayout.Override.RowAlternateAppearance = Appearance10
        Me.ug_Listado.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.ug_Listado.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.ug_Listado.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ug_Listado.Location = New System.Drawing.Point(5, 74)
        Me.ug_Listado.Name = "ug_Listado"
        Me.ug_Listado.Size = New System.Drawing.Size(946, 381)
        Me.ug_Listado.TabIndex = 8
        Me.ug_Listado.Text = "UltraGrid1"
        '
        'LO_LT_Mante_ComproB
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(958, 462)
        Me.Controls.Add(Me.ug_Listado)
        Me.Controls.Add(Me.UltraGroupBox1)
        Me.Controls.Add(Me.ToolS_Mantenimiento)
        Me.Name = "LO_LT_Mante_ComproB"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Consulta de Compras / Nota de Crédito / Anulacion"
        Me.ToolS_Mantenimiento.ResumeLayout(False)
        Me.ToolS_Mantenimiento.PerformLayout()
        CType(Me.UltraGroupBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraGroupBox1.ResumeLayout(False)
        Me.UltraGroupBox1.PerformLayout()
        CType(Me.txt_año, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.uce_Mes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.uce_tipo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.udte_hasta, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.udte_desde, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.uds_Listado, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ug_Listado, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolS_Mantenimiento As System.Windows.Forms.ToolStrip
    Friend WithEvents Tool_Nuevo As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator8 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents Tool_Consultar As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents Tool_Anular As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator5 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents Tool_Actualizar As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents Tool_Salir As System.Windows.Forms.ToolStripButton
    Friend WithEvents UltraGroupBox1 As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents lbl_hasta As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents lbl_desde As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents udte_hasta As Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
    Friend WithEvents udte_desde As Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
    Friend WithEvents uds_Listado As Infragistics.Win.UltraWinDataSource.UltraDataSource
    Friend WithEvents UltraLabel10 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents uce_tipo As Infragistics.Win.UltraWinEditors.UltraComboEditor
    Friend WithEvents ug_Listado As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents uce_Mes As Infragistics.Win.UltraWinEditors.UltraComboEditor
    Friend WithEvents Tool_NotaCredito As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ulbA As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents txt_año As Infragistics.Win.UltraWinEditors.UltraTextEditor
End Class
