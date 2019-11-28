<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class HO_PR_VistoSistemas
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
        Dim UltraDataColumn1 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("PE_ID")
        Dim UltraDataColumn2 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("PE_CODIGO")
        Dim UltraDataColumn3 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("EMPLEADO")
        Dim UltraDataColumn4 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("CUNA_NORMAL")
        Dim UltraDataColumn5 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("INTER")
        Dim UltraDataColumn6 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("UCI")
        Dim UltraDataColumn7 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("TOTAL")
        Dim UltraDataColumn8 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("FIJAS")
        Dim UltraDataColumn9 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("EXTRAS")
        Dim UltraDataColumn10 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("OK")
        Dim UltraDataColumn11 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("OBS")
        Dim UltraDataColumn12 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("EXTRAS_DOBLES")
        Dim Appearance9 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance12 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim ValueListItem2 As Infragistics.Win.ValueListItem = New Infragistics.Win.ValueListItem()
        Dim ValueListItem3 As Infragistics.Win.ValueListItem = New Infragistics.Win.ValueListItem()
        Dim Appearance17 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance4 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance3 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridBand1 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1)
        Dim UltraGridColumn1 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("PE_ID", -1, Nothing, 25079002, 2, 0)
        Dim UltraGridColumn2 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("PE_CODIGO", -1, Nothing, 25079002, 0, 0)
        Dim UltraGridColumn3 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("EMPLEADO", -1, Nothing, 25079002, 1, 0)
        Dim UltraGridColumn4 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CUNA_NORMAL", -1, Nothing, 25079003, 0, 0)
        Dim Appearance1 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn5 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("INTER", -1, Nothing, 25079003, 1, 0)
        Dim Appearance2 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn6 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("UCI", -1, Nothing, 25079003, 2, 0)
        Dim Appearance5 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn7 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TOTAL", -1, Nothing, 25079003, 3, 0)
        Dim Appearance6 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn8 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FIJAS", -1, Nothing, 25079004, 0, 0)
        Dim Appearance7 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn9 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("EXTRAS", -1, Nothing, 25079004, 1, 0)
        Dim Appearance8 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn10 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("OK", -1, Nothing, 25079004, 3, 0)
        Dim UltraGridColumn11 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("OBS")
        Dim UltraGridColumn12 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("EXTRAS_DOBLES", -1, Nothing, 25079004, 2, 0)
        Dim Appearance10 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn13 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("col_btn_obs", 0, Nothing, 25079004, 4, 0)
        Dim UltraGridGroup1 As Infragistics.Win.UltraWinGrid.UltraGridGroup = New Infragistics.Win.UltraWinGrid.UltraGridGroup("PERSONAL", 25079002)
        Dim Appearance11 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridGroup2 As Infragistics.Win.UltraWinGrid.UltraGridGroup = New Infragistics.Win.UltraWinGrid.UltraGridGroup("SALA DE BEBES", 25079003)
        Dim Appearance13 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridGroup3 As Infragistics.Win.UltraWinGrid.UltraGridGroup = New Infragistics.Win.UltraWinGrid.UltraGridGroup("HOSPITALIZACION", 25079004)
        Dim Appearance14 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim SummarySettings1 As Infragistics.Win.UltraWinGrid.SummarySettings = New Infragistics.Win.UltraWinGrid.SummarySettings("", Infragistics.Win.UltraWinGrid.SummaryType.Sum, Nothing, "TOTAL", 6, True, "Band 0", 0, Infragistics.Win.UltraWinGrid.SummaryPosition.UseSummaryPositionColumn, "TOTAL", 6, True)
        Dim Appearance15 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance18 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim SummarySettings2 As Infragistics.Win.UltraWinGrid.SummarySettings = New Infragistics.Win.UltraWinGrid.SummarySettings("", Infragistics.Win.UltraWinGrid.SummaryType.Sum, Nothing, "UCI", 5, True, "Band 0", 0, Infragistics.Win.UltraWinGrid.SummaryPosition.UseSummaryPositionColumn, "UCI", 5, True)
        Dim Appearance19 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance20 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim SummarySettings3 As Infragistics.Win.UltraWinGrid.SummarySettings = New Infragistics.Win.UltraWinGrid.SummarySettings("", Infragistics.Win.UltraWinGrid.SummaryType.Sum, Nothing, "INTER", 4, True, "Band 0", 0, Infragistics.Win.UltraWinGrid.SummaryPosition.UseSummaryPositionColumn, "INTER", 4, True)
        Dim Appearance21 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance22 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim SummarySettings4 As Infragistics.Win.UltraWinGrid.SummarySettings = New Infragistics.Win.UltraWinGrid.SummarySettings("", Infragistics.Win.UltraWinGrid.SummaryType.Sum, Nothing, "CUNA_NORMAL", 3, True, "Band 0", 0, Infragistics.Win.UltraWinGrid.SummaryPosition.UseSummaryPositionColumn, "CUNA_NORMAL", 3, True)
        Dim Appearance23 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance24 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance16 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Me.uds_detalle = New Infragistics.Win.UltraWinDataSource.UltraDataSource(Me.components)
        Me.Tools_Mante = New System.Windows.Forms.ToolStrip()
        Me.Tool_exportar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.Tool_Actualizar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.Tool_salir = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.export1 = New Infragistics.Win.UltraWinGrid.ExcelExport.UltraGridExcelExporter(Me.components)
        Me.UltraGroupBox2 = New Infragistics.Win.Misc.UltraGroupBox()
        Me.utxt_estado2 = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.txt_estado = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.ugb_act_estado = New Infragistics.Win.Misc.UltraGroupBox()
        Me.ubtn_actualizar = New Infragistics.Win.Misc.UltraButton()
        Me.uos_visto = New Infragistics.Win.UltraWinEditors.UltraOptionSet()
        Me.UltraGroupBox1 = New Infragistics.Win.Misc.UltraGroupBox()
        Me.uce_mes = New Infragistics.Win.UltraWinEditors.UltraComboEditor()
        Me.une_ayo = New Infragistics.Win.UltraWinEditors.UltraNumericEditor()
        Me.UltraLabel2 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraLabel1 = New Infragistics.Win.Misc.UltraLabel()
        Me.ug_detalle = New Infragistics.Win.UltraWinGrid.UltraGrid()
        CType(Me.uds_detalle, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Tools_Mante.SuspendLayout()
        CType(Me.UltraGroupBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraGroupBox2.SuspendLayout()
        CType(Me.utxt_estado2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_estado, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ugb_act_estado, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ugb_act_estado.SuspendLayout()
        CType(Me.uos_visto, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UltraGroupBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraGroupBox1.SuspendLayout()
        CType(Me.uce_mes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.une_ayo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ug_detalle, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'uds_detalle
        '
        Me.uds_detalle.AllowDelete = False
        UltraDataColumn1.DataType = GetType(Integer)
        UltraDataColumn4.DataType = GetType(Double)
        UltraDataColumn5.DataType = GetType(Double)
        UltraDataColumn6.DataType = GetType(Double)
        UltraDataColumn7.DataType = GetType(Double)
        UltraDataColumn8.DataType = GetType(Double)
        UltraDataColumn9.DataType = GetType(Double)
        UltraDataColumn10.DataType = GetType(Boolean)
        UltraDataColumn12.DataType = GetType(Double)
        Me.uds_detalle.Band.Columns.AddRange(New Object() {UltraDataColumn1, UltraDataColumn2, UltraDataColumn3, UltraDataColumn4, UltraDataColumn5, UltraDataColumn6, UltraDataColumn7, UltraDataColumn8, UltraDataColumn9, UltraDataColumn10, UltraDataColumn11, UltraDataColumn12})
        '
        'Tools_Mante
        '
        Me.Tools_Mante.BackColor = System.Drawing.Color.White
        Me.Tools_Mante.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Tool_exportar, Me.ToolStripSeparator2, Me.Tool_Actualizar, Me.ToolStripSeparator1, Me.Tool_salir, Me.ToolStripSeparator3})
        Me.Tools_Mante.Location = New System.Drawing.Point(0, 0)
        Me.Tools_Mante.Name = "Tools_Mante"
        Me.Tools_Mante.Size = New System.Drawing.Size(798, 25)
        Me.Tools_Mante.TabIndex = 11
        Me.Tools_Mante.Text = "ToolStrip1"
        '
        'Tool_exportar
        '
        Me.Tool_exportar.Image = Global.Contabilidad.My.Resources.Resources._16__Doc_excel_
        Me.Tool_exportar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Tool_exportar.Name = "Tool_exportar"
        Me.Tool_exportar.Size = New System.Drawing.Size(70, 22)
        Me.Tool_exportar.Text = "Exportar"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'Tool_Actualizar
        '
        Me.Tool_Actualizar.Image = Global.Contabilidad.My.Resources.Resources._726
        Me.Tool_Actualizar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Tool_Actualizar.Name = "Tool_Actualizar"
        Me.Tool_Actualizar.Size = New System.Drawing.Size(102, 22)
        Me.Tool_Actualizar.Text = "Refrescar Lista"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'Tool_salir
        '
        Me.Tool_salir.Image = Global.Contabilidad.My.Resources.Resources._28
        Me.Tool_salir.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Tool_salir.Name = "Tool_salir"
        Me.Tool_salir.Size = New System.Drawing.Size(49, 22)
        Me.Tool_salir.Text = "Salir"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 25)
        '
        'UltraGroupBox2
        '
        Me.UltraGroupBox2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.UltraGroupBox2.Controls.Add(Me.utxt_estado2)
        Me.UltraGroupBox2.Controls.Add(Me.txt_estado)
        Me.UltraGroupBox2.Location = New System.Drawing.Point(444, 28)
        Me.UltraGroupBox2.Name = "UltraGroupBox2"
        Me.UltraGroupBox2.Size = New System.Drawing.Size(342, 69)
        Me.UltraGroupBox2.TabIndex = 16
        Me.UltraGroupBox2.Text = "Estado"
        '
        'utxt_estado2
        '
        Appearance9.FontData.BoldAsString = "True"
        Appearance9.ForeColor = System.Drawing.Color.Navy
        Appearance9.TextHAlignAsString = "Center"
        Me.utxt_estado2.Appearance = Appearance9
        Me.utxt_estado2.Location = New System.Drawing.Point(10, 42)
        Me.utxt_estado2.Name = "utxt_estado2"
        Me.utxt_estado2.ReadOnly = True
        Me.utxt_estado2.Size = New System.Drawing.Size(233, 21)
        Me.utxt_estado2.TabIndex = 12
        '
        'txt_estado
        '
        Appearance12.FontData.BoldAsString = "True"
        Appearance12.ForeColor = System.Drawing.Color.Navy
        Appearance12.TextHAlignAsString = "Center"
        Me.txt_estado.Appearance = Appearance12
        Me.txt_estado.Location = New System.Drawing.Point(10, 17)
        Me.txt_estado.Name = "txt_estado"
        Me.txt_estado.ReadOnly = True
        Me.txt_estado.Size = New System.Drawing.Size(233, 21)
        Me.txt_estado.TabIndex = 7
        '
        'ugb_act_estado
        '
        Me.ugb_act_estado.Controls.Add(Me.ubtn_actualizar)
        Me.ugb_act_estado.Controls.Add(Me.uos_visto)
        Me.ugb_act_estado.Location = New System.Drawing.Point(210, 28)
        Me.ugb_act_estado.Name = "ugb_act_estado"
        Me.ugb_act_estado.Size = New System.Drawing.Size(228, 69)
        Me.ugb_act_estado.TabIndex = 15
        Me.ugb_act_estado.Text = "Opcion"
        '
        'ubtn_actualizar
        '
        Me.ubtn_actualizar.Location = New System.Drawing.Point(123, 22)
        Me.ubtn_actualizar.Name = "ubtn_actualizar"
        Me.ubtn_actualizar.Size = New System.Drawing.Size(92, 32)
        Me.ubtn_actualizar.TabIndex = 9
        Me.ubtn_actualizar.Text = "&Guardar"
        '
        'uos_visto
        '
        Me.uos_visto.BackColor = System.Drawing.Color.Transparent
        Me.uos_visto.BackColorInternal = System.Drawing.Color.Transparent
        Me.uos_visto.BorderStyle = Infragistics.Win.UIElementBorderStyle.None
        Me.uos_visto.CheckedIndex = 0
        ValueListItem2.DataValue = "1"
        ValueListItem2.DisplayText = "Conforme"
        ValueListItem3.DataValue = "0"
        ValueListItem3.DisplayText = "Inconforme"
        Me.uos_visto.Items.AddRange(New Infragistics.Win.ValueListItem() {ValueListItem2, ValueListItem3})
        Me.uos_visto.ItemSpacingVertical = 4
        Me.uos_visto.Location = New System.Drawing.Point(10, 23)
        Me.uos_visto.Name = "uos_visto"
        Me.uos_visto.Size = New System.Drawing.Size(95, 38)
        Me.uos_visto.TabIndex = 8
        Me.uos_visto.Text = "Conforme"
        '
        'UltraGroupBox1
        '
        Me.UltraGroupBox1.Controls.Add(Me.uce_mes)
        Me.UltraGroupBox1.Controls.Add(Me.une_ayo)
        Me.UltraGroupBox1.Controls.Add(Me.UltraLabel2)
        Me.UltraGroupBox1.Controls.Add(Me.UltraLabel1)
        Me.UltraGroupBox1.Location = New System.Drawing.Point(12, 28)
        Me.UltraGroupBox1.Name = "UltraGroupBox1"
        Me.UltraGroupBox1.Size = New System.Drawing.Size(192, 69)
        Me.UltraGroupBox1.TabIndex = 14
        Me.UltraGroupBox1.Text = "Periodo"
        '
        'uce_mes
        '
        Me.uce_mes.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.uce_mes.Location = New System.Drawing.Point(52, 40)
        Me.uce_mes.Name = "uce_mes"
        Me.uce_mes.Size = New System.Drawing.Size(123, 21)
        Me.uce_mes.TabIndex = 4
        '
        'une_ayo
        '
        Appearance17.TextHAlignAsString = "Center"
        Me.une_ayo.Appearance = Appearance17
        Me.une_ayo.Location = New System.Drawing.Point(52, 17)
        Me.une_ayo.MaskInput = "nnnn"
        Me.une_ayo.Name = "une_ayo"
        Me.une_ayo.ReadOnly = True
        Me.une_ayo.Size = New System.Drawing.Size(48, 21)
        Me.une_ayo.TabIndex = 3
        '
        'UltraLabel2
        '
        Appearance4.BackColor = System.Drawing.Color.Transparent
        Appearance4.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel2.Appearance = Appearance4
        Me.UltraLabel2.AutoSize = True
        Me.UltraLabel2.Location = New System.Drawing.Point(14, 44)
        Me.UltraLabel2.Name = "UltraLabel2"
        Me.UltraLabel2.Size = New System.Drawing.Size(32, 14)
        Me.UltraLabel2.TabIndex = 2
        Me.UltraLabel2.Text = "Mes :"
        '
        'UltraLabel1
        '
        Appearance3.BackColor = System.Drawing.Color.Transparent
        Appearance3.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel1.Appearance = Appearance3
        Me.UltraLabel1.AutoSize = True
        Me.UltraLabel1.Location = New System.Drawing.Point(16, 21)
        Me.UltraLabel1.Name = "UltraLabel1"
        Me.UltraLabel1.Size = New System.Drawing.Size(30, 14)
        Me.UltraLabel1.TabIndex = 1
        Me.UltraLabel1.Text = "Año :"
        '
        'ug_detalle
        '
        Me.ug_detalle.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ug_detalle.DataSource = Me.uds_detalle
        Me.ug_detalle.DisplayLayout.AutoFitStyle = Infragistics.Win.UltraWinGrid.AutoFitStyle.ExtendLastColumn
        UltraGridColumn1.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn1.Hidden = True
        UltraGridColumn2.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn2.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn2.Header.Caption = "CODIGO"
        UltraGridColumn2.Width = 52
        UltraGridColumn3.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn3.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn3.Width = 175
        UltraGridColumn4.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn4.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        Appearance1.ForeColor = System.Drawing.Color.Navy
        Appearance1.TextHAlignAsString = "Center"
        UltraGridColumn4.CellAppearance = Appearance1
        UltraGridColumn4.Header.Caption = "CUNA/NORMAL"
        UltraGridColumn4.Width = 72
        UltraGridColumn5.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn5.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        Appearance2.ForeColor = System.Drawing.Color.Navy
        Appearance2.TextHAlignAsString = "Center"
        UltraGridColumn5.CellAppearance = Appearance2
        UltraGridColumn5.Width = 64
        UltraGridColumn6.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn6.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        Appearance5.ForeColor = System.Drawing.Color.Navy
        Appearance5.TextHAlignAsString = "Center"
        UltraGridColumn6.CellAppearance = Appearance5
        UltraGridColumn6.Width = 60
        UltraGridColumn7.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn7.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        Appearance6.ForeColor = System.Drawing.Color.Navy
        Appearance6.TextHAlignAsString = "Center"
        UltraGridColumn7.CellAppearance = Appearance6
        UltraGridColumn7.Header.Caption = "TOTAL "
        UltraGridColumn7.Width = 60
        UltraGridColumn8.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn8.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        Appearance7.ForeColor = System.Drawing.Color.Navy
        Appearance7.TextHAlignAsString = "Center"
        UltraGridColumn8.CellAppearance = Appearance7
        UltraGridColumn8.Width = 50
        UltraGridColumn9.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn9.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        Appearance8.ForeColor = System.Drawing.Color.Navy
        Appearance8.TextHAlignAsString = "Center"
        UltraGridColumn9.CellAppearance = Appearance8
        UltraGridColumn9.Width = 53
        UltraGridColumn10.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn10.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.CheckBox
        UltraGridColumn11.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn11.Header.VisiblePosition = 12
        UltraGridColumn11.Hidden = True
        UltraGridColumn12.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn12.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        Appearance10.ForeColor = System.Drawing.Color.Navy
        Appearance10.TextHAlignAsString = "Center"
        UltraGridColumn12.CellAppearance = Appearance10
        UltraGridColumn12.Header.Caption = "FERIADO"
        UltraGridColumn12.Width = 66
        UltraGridColumn13.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn13.ButtonDisplayStyle = Infragistics.Win.UltraWinGrid.ButtonDisplayStyle.Always
        UltraGridColumn13.Header.Caption = "OBS"
        UltraGridColumn13.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.Button
        UltraGridColumn13.Width = 39
        UltraGridBand1.Columns.AddRange(New Object() {UltraGridColumn1, UltraGridColumn2, UltraGridColumn3, UltraGridColumn4, UltraGridColumn5, UltraGridColumn6, UltraGridColumn7, UltraGridColumn8, UltraGridColumn9, UltraGridColumn10, UltraGridColumn11, UltraGridColumn12, UltraGridColumn13})
        Appearance11.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Appearance11.FontData.SizeInPoints = 9.0!
        Appearance11.ForeColor = System.Drawing.Color.Red
        UltraGridGroup1.Header.Appearance = Appearance11
        UltraGridGroup1.Key = "PERSONAL"
        Appearance13.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Appearance13.FontData.SizeInPoints = 9.0!
        Appearance13.ForeColor = System.Drawing.Color.Red
        UltraGridGroup2.Header.Appearance = Appearance13
        UltraGridGroup2.Key = "SALA DE BEBES"
        Appearance14.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Appearance14.FontData.SizeInPoints = 9.0!
        Appearance14.ForeColor = System.Drawing.Color.Red
        UltraGridGroup3.Header.Appearance = Appearance14
        UltraGridGroup3.Key = "HOSPITALIZACION"
        UltraGridBand1.Groups.AddRange(New Infragistics.Win.UltraWinGrid.UltraGridGroup() {UltraGridGroup1, UltraGridGroup2, UltraGridGroup3})
        Appearance15.BackColor = System.Drawing.Color.White
        Appearance15.FontData.BoldAsString = "True"
        Appearance15.FontData.SizeInPoints = 10.0!
        Appearance15.ForeColor = System.Drawing.Color.Navy
        Appearance15.TextHAlignAsString = "Center"
        SummarySettings1.Appearance = Appearance15
        SummarySettings1.DisplayFormat = "{0}"
        SummarySettings1.GroupBySummaryValueAppearance = Appearance18
        SummarySettings1.SummaryDisplayArea = Infragistics.Win.UltraWinGrid.SummaryDisplayAreas.BottomFixed
        Appearance19.BackColor = System.Drawing.Color.White
        Appearance19.FontData.BoldAsString = "True"
        Appearance19.FontData.SizeInPoints = 10.0!
        Appearance19.ForeColor = System.Drawing.Color.Navy
        Appearance19.TextHAlignAsString = "Center"
        SummarySettings2.Appearance = Appearance19
        SummarySettings2.DisplayFormat = "{0}"
        SummarySettings2.GroupBySummaryValueAppearance = Appearance20
        SummarySettings2.SummaryDisplayArea = Infragistics.Win.UltraWinGrid.SummaryDisplayAreas.BottomFixed
        Appearance21.BackColor = System.Drawing.Color.White
        Appearance21.FontData.BoldAsString = "True"
        Appearance21.FontData.SizeInPoints = 10.0!
        Appearance21.ForeColor = System.Drawing.Color.Navy
        Appearance21.TextHAlignAsString = "Center"
        SummarySettings3.Appearance = Appearance21
        SummarySettings3.DisplayFormat = "{0}"
        SummarySettings3.GroupBySummaryValueAppearance = Appearance22
        SummarySettings3.SummaryDisplayArea = Infragistics.Win.UltraWinGrid.SummaryDisplayAreas.BottomFixed
        Appearance23.BackColor = System.Drawing.Color.White
        Appearance23.FontData.BoldAsString = "True"
        Appearance23.FontData.SizeInPoints = 10.0!
        Appearance23.ForeColor = System.Drawing.Color.Navy
        Appearance23.TextHAlignAsString = "Center"
        SummarySettings4.Appearance = Appearance23
        SummarySettings4.DisplayFormat = "{0}"
        SummarySettings4.GroupBySummaryValueAppearance = Appearance24
        SummarySettings4.SummaryDisplayArea = Infragistics.Win.UltraWinGrid.SummaryDisplayAreas.BottomFixed
        UltraGridBand1.Summaries.AddRange(New Infragistics.Win.UltraWinGrid.SummarySettings() {SummarySettings1, SummarySettings2, SummarySettings3, SummarySettings4})
        UltraGridBand1.SummaryFooterCaption = "Totales"
        Me.ug_detalle.DisplayLayout.BandsSerializer.Add(UltraGridBand1)
        Me.ug_detalle.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.[False]
        Me.ug_detalle.DisplayLayout.MaxColScrollRegions = 1
        Me.ug_detalle.DisplayLayout.MaxRowScrollRegions = 1
        Appearance16.BackColor = System.Drawing.Color.WhiteSmoke
        Appearance16.BackColor2 = System.Drawing.Color.WhiteSmoke
        Me.ug_detalle.DisplayLayout.Override.RowAlternateAppearance = Appearance16
        Me.ug_detalle.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.ug_detalle.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.ug_detalle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ug_detalle.Location = New System.Drawing.Point(12, 103)
        Me.ug_detalle.Name = "ug_detalle"
        Me.ug_detalle.Size = New System.Drawing.Size(774, 287)
        Me.ug_detalle.TabIndex = 17
        Me.ug_detalle.Text = "UltraGrid1"
        '
        'HO_PR_VistoSistemas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(798, 402)
        Me.Controls.Add(Me.ug_detalle)
        Me.Controls.Add(Me.UltraGroupBox2)
        Me.Controls.Add(Me.ugb_act_estado)
        Me.Controls.Add(Me.UltraGroupBox1)
        Me.Controls.Add(Me.Tools_Mante)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "HO_PR_VistoSistemas"
        Me.Text = "Visto Sistemas"
        CType(Me.uds_detalle, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Tools_Mante.ResumeLayout(False)
        Me.Tools_Mante.PerformLayout()
        CType(Me.UltraGroupBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraGroupBox2.ResumeLayout(False)
        Me.UltraGroupBox2.PerformLayout()
        CType(Me.utxt_estado2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_estado, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ugb_act_estado, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ugb_act_estado.ResumeLayout(False)
        CType(Me.uos_visto, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UltraGroupBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraGroupBox1.ResumeLayout(False)
        Me.UltraGroupBox1.PerformLayout()
        CType(Me.uce_mes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.une_ayo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ug_detalle, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents uds_detalle As Infragistics.Win.UltraWinDataSource.UltraDataSource
    Friend WithEvents Tools_Mante As System.Windows.Forms.ToolStrip
    Friend WithEvents Tool_exportar As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents Tool_Actualizar As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents Tool_salir As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents export1 As Infragistics.Win.UltraWinGrid.ExcelExport.UltraGridExcelExporter
    Friend WithEvents UltraGroupBox2 As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents utxt_estado2 As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents txt_estado As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents ugb_act_estado As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents ubtn_actualizar As Infragistics.Win.Misc.UltraButton
    Friend WithEvents uos_visto As Infragistics.Win.UltraWinEditors.UltraOptionSet
    Friend WithEvents UltraGroupBox1 As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents uce_mes As Infragistics.Win.UltraWinEditors.UltraComboEditor
    Friend WithEvents une_ayo As Infragistics.Win.UltraWinEditors.UltraNumericEditor
    Friend WithEvents UltraLabel2 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel1 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents ug_detalle As Infragistics.Win.UltraWinGrid.UltraGrid
End Class
