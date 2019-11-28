<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PL_PR_RegHoras_PerAsistencial
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
        Dim ValueListItem2 As Infragistics.Win.ValueListItem = New Infragistics.Win.ValueListItem()
        Dim ValueListItem3 As Infragistics.Win.ValueListItem = New Infragistics.Win.ValueListItem()
        Dim Appearance44 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance4 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance3 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance9 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance12 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
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
        Dim UltraDataColumn11 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("EXTRAS_DOBLES")
        Dim UltraDataColumn12 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("REFRI")
        Dim UltraGridBand1 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1)
        Dim UltraGridColumn1 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("PE_ID", -1, Nothing, 31755204, 2, 0)
        Dim UltraGridColumn2 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("PE_CODIGO", -1, Nothing, 31755204, 0, 0)
        Dim UltraGridColumn3 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("EMPLEADO", -1, Nothing, 31755204, 1, 0)
        Dim UltraGridColumn4 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CUNA_NORMAL", -1, Nothing, 31755205, 0, 0)
        Dim Appearance25 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn5 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("INTER", -1, Nothing, 31755205, 1, 0)
        Dim Appearance26 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn6 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("UCI", -1, Nothing, 31755205, 2, 0)
        Dim Appearance27 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn7 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TOTAL", -1, Nothing, 31755205, 3, 0)
        Dim Appearance28 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn8 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FIJAS", -1, Nothing, 31755206, 0, 0)
        Dim Appearance29 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn9 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("EXTRAS", -1, Nothing, 31755206, 1, 0)
        Dim Appearance30 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn10 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("OK", -1, Nothing, 31755206, 4, 0)
        Dim UltraGridColumn11 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("EXTRAS_DOBLES", -1, Nothing, 31755206, 2, 0)
        Dim Appearance31 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn12 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("REFRI", -1, Nothing, 31755206, 3, 0)
        Dim Appearance32 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridGroup1 As Infragistics.Win.UltraWinGrid.UltraGridGroup = New Infragistics.Win.UltraWinGrid.UltraGridGroup("PERSONAL", 31755204)
        Dim Appearance33 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridGroup2 As Infragistics.Win.UltraWinGrid.UltraGridGroup = New Infragistics.Win.UltraWinGrid.UltraGridGroup("SALA DE BEBES", 31755205)
        Dim Appearance34 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridGroup3 As Infragistics.Win.UltraWinGrid.UltraGridGroup = New Infragistics.Win.UltraWinGrid.UltraGridGroup("HOSPITALIZACION", 31755206)
        Dim Appearance35 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim SummarySettings1 As Infragistics.Win.UltraWinGrid.SummarySettings = New Infragistics.Win.UltraWinGrid.SummarySettings("", Infragistics.Win.UltraWinGrid.SummaryType.Sum, Nothing, "TOTAL", 6, True, "Band 0", 0, Infragistics.Win.UltraWinGrid.SummaryPosition.UseSummaryPositionColumn, "TOTAL", 6, True)
        Dim Appearance36 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance37 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim SummarySettings2 As Infragistics.Win.UltraWinGrid.SummarySettings = New Infragistics.Win.UltraWinGrid.SummarySettings("", Infragistics.Win.UltraWinGrid.SummaryType.Sum, Nothing, "UCI", 5, True, "Band 0", 0, Infragistics.Win.UltraWinGrid.SummaryPosition.UseSummaryPositionColumn, "UCI", 5, True)
        Dim Appearance38 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance39 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim SummarySettings3 As Infragistics.Win.UltraWinGrid.SummarySettings = New Infragistics.Win.UltraWinGrid.SummarySettings("", Infragistics.Win.UltraWinGrid.SummaryType.Sum, Nothing, "INTER", 4, True, "Band 0", 0, Infragistics.Win.UltraWinGrid.SummaryPosition.UseSummaryPositionColumn, "INTER", 4, True)
        Dim Appearance40 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance41 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim SummarySettings4 As Infragistics.Win.UltraWinGrid.SummarySettings = New Infragistics.Win.UltraWinGrid.SummarySettings("", Infragistics.Win.UltraWinGrid.SummaryType.Sum, Nothing, "CUNA_NORMAL", 3, True, "Band 0", 0, Infragistics.Win.UltraWinGrid.SummaryPosition.UseSummaryPositionColumn, "CUNA_NORMAL", 3, True)
        Dim Appearance42 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance43 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance16 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Me.Tools_Mante = New System.Windows.Forms.ToolStrip()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.Tool_Reporte = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.Tool_salir = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ugb_act_estado = New Infragistics.Win.Misc.UltraGroupBox()
        Me.ubtn_actualizar = New Infragistics.Win.Misc.UltraButton()
        Me.uos_visto = New Infragistics.Win.UltraWinEditors.UltraOptionSet()
        Me.UltraGroupBox1 = New Infragistics.Win.Misc.UltraGroupBox()
        Me.uce_mes = New Infragistics.Win.UltraWinEditors.UltraComboEditor()
        Me.une_ayo = New Infragistics.Win.UltraWinEditors.UltraNumericEditor()
        Me.UltraLabel2 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraLabel1 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraGroupBox2 = New Infragistics.Win.Misc.UltraGroupBox()
        Me.utxt_estado2 = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.txt_estado = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.uds_detalle = New Infragistics.Win.UltraWinDataSource.UltraDataSource(Me.components)
        Me.ug_detalle = New Infragistics.Win.UltraWinGrid.UltraGrid()
        Me.Tools_Mante.SuspendLayout()
        CType(Me.ugb_act_estado, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ugb_act_estado.SuspendLayout()
        CType(Me.uos_visto, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UltraGroupBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraGroupBox1.SuspendLayout()
        CType(Me.uce_mes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.une_ayo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UltraGroupBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraGroupBox2.SuspendLayout()
        CType(Me.utxt_estado2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_estado, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.uds_detalle, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ug_detalle, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Tools_Mante
        '
        Me.Tools_Mante.BackColor = System.Drawing.Color.White
        Me.Tools_Mante.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripSeparator1, Me.Tool_Reporte, Me.ToolStripSeparator3, Me.Tool_salir, Me.ToolStripSeparator2})
        Me.Tools_Mante.Location = New System.Drawing.Point(0, 0)
        Me.Tools_Mante.Name = "Tools_Mante"
        Me.Tools_Mante.Size = New System.Drawing.Size(891, 25)
        Me.Tools_Mante.TabIndex = 12
        Me.Tools_Mante.Text = "ToolStrip1"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'Tool_Reporte
        '
        Me.Tool_Reporte.Image = Global.Contabilidad.My.Resources.Resources._004
        Me.Tool_Reporte.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Tool_Reporte.Name = "Tool_Reporte"
        Me.Tool_Reporte.Size = New System.Drawing.Size(65, 22)
        Me.Tool_Reporte.Text = "Imprimir"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 25)
        '
        'Tool_salir
        '
        Me.Tool_salir.Image = Global.Contabilidad.My.Resources.Resources._28
        Me.Tool_salir.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Tool_salir.Name = "Tool_salir"
        Me.Tool_salir.Size = New System.Drawing.Size(47, 22)
        Me.Tool_salir.Text = "Salir"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'ugb_act_estado
        '
        Me.ugb_act_estado.Controls.Add(Me.ubtn_actualizar)
        Me.ugb_act_estado.Controls.Add(Me.uos_visto)
        Me.ugb_act_estado.Location = New System.Drawing.Point(186, 28)
        Me.ugb_act_estado.Name = "ugb_act_estado"
        Me.ugb_act_estado.Size = New System.Drawing.Size(217, 75)
        Me.ugb_act_estado.TabIndex = 17
        Me.ugb_act_estado.Text = "Opciones"
        '
        'ubtn_actualizar
        '
        Me.ubtn_actualizar.Location = New System.Drawing.Point(119, 29)
        Me.ubtn_actualizar.Name = "ubtn_actualizar"
        Me.ubtn_actualizar.Size = New System.Drawing.Size(84, 32)
        Me.ubtn_actualizar.TabIndex = 9
        Me.ubtn_actualizar.Text = "&Actualizar"
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
        Me.uos_visto.ItemSpacingVertical = 3
        Me.uos_visto.Location = New System.Drawing.Point(18, 29)
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
        Me.UltraGroupBox1.Size = New System.Drawing.Size(168, 75)
        Me.UltraGroupBox1.TabIndex = 18
        Me.UltraGroupBox1.Text = "Periodo"
        '
        'uce_mes
        '
        Me.uce_mes.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.uce_mes.Location = New System.Drawing.Point(45, 44)
        Me.uce_mes.Name = "uce_mes"
        Me.uce_mes.Size = New System.Drawing.Size(113, 21)
        Me.uce_mes.TabIndex = 4
        '
        'une_ayo
        '
        Appearance44.TextHAlignAsString = "Center"
        Me.une_ayo.Appearance = Appearance44
        Me.une_ayo.Location = New System.Drawing.Point(45, 21)
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
        Me.UltraLabel2.Location = New System.Drawing.Point(7, 48)
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
        Me.UltraLabel1.Location = New System.Drawing.Point(9, 28)
        Me.UltraLabel1.Name = "UltraLabel1"
        Me.UltraLabel1.Size = New System.Drawing.Size(30, 14)
        Me.UltraLabel1.TabIndex = 1
        Me.UltraLabel1.Text = "Año :"
        '
        'UltraGroupBox2
        '
        Me.UltraGroupBox2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.UltraGroupBox2.Controls.Add(Me.utxt_estado2)
        Me.UltraGroupBox2.Controls.Add(Me.txt_estado)
        Me.UltraGroupBox2.Location = New System.Drawing.Point(409, 28)
        Me.UltraGroupBox2.Name = "UltraGroupBox2"
        Me.UltraGroupBox2.Size = New System.Drawing.Size(473, 75)
        Me.UltraGroupBox2.TabIndex = 19
        Me.UltraGroupBox2.Text = "Estado"
        '
        'utxt_estado2
        '
        Me.utxt_estado2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Appearance9.FontData.BoldAsString = "True"
        Appearance9.ForeColor = System.Drawing.Color.Navy
        Appearance9.TextHAlignAsString = "Center"
        Me.utxt_estado2.Appearance = Appearance9
        Me.utxt_estado2.Location = New System.Drawing.Point(14, 43)
        Me.utxt_estado2.Name = "utxt_estado2"
        Me.utxt_estado2.ReadOnly = True
        Me.utxt_estado2.Size = New System.Drawing.Size(446, 21)
        Me.utxt_estado2.TabIndex = 13
        '
        'txt_estado
        '
        Me.txt_estado.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Appearance12.FontData.BoldAsString = "True"
        Appearance12.ForeColor = System.Drawing.Color.Navy
        Appearance12.TextHAlignAsString = "Center"
        Me.txt_estado.Appearance = Appearance12
        Me.txt_estado.Location = New System.Drawing.Point(14, 18)
        Me.txt_estado.Name = "txt_estado"
        Me.txt_estado.ReadOnly = True
        Me.txt_estado.Size = New System.Drawing.Size(446, 21)
        Me.txt_estado.TabIndex = 7
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
        UltraDataColumn11.DataType = GetType(Double)
        UltraDataColumn12.DataType = GetType(Double)
        Me.uds_detalle.Band.Columns.AddRange(New Object() {UltraDataColumn1, UltraDataColumn2, UltraDataColumn3, UltraDataColumn4, UltraDataColumn5, UltraDataColumn6, UltraDataColumn7, UltraDataColumn8, UltraDataColumn9, UltraDataColumn10, UltraDataColumn11, UltraDataColumn12})
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
        UltraGridColumn3.Width = 195
        UltraGridColumn4.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn4.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        Appearance25.ForeColor = System.Drawing.Color.Navy
        Appearance25.TextHAlignAsString = "Center"
        UltraGridColumn4.CellAppearance = Appearance25
        UltraGridColumn4.Header.Caption = "CUNA/NORMAL"
        UltraGridColumn4.Width = 79
        UltraGridColumn5.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn5.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        Appearance26.ForeColor = System.Drawing.Color.Navy
        Appearance26.TextHAlignAsString = "Center"
        UltraGridColumn5.CellAppearance = Appearance26
        UltraGridColumn5.Width = 64
        UltraGridColumn6.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn6.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        Appearance27.ForeColor = System.Drawing.Color.Navy
        Appearance27.TextHAlignAsString = "Center"
        UltraGridColumn6.CellAppearance = Appearance27
        UltraGridColumn6.Width = 60
        UltraGridColumn7.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn7.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        Appearance28.ForeColor = System.Drawing.Color.Navy
        Appearance28.TextHAlignAsString = "Center"
        UltraGridColumn7.CellAppearance = Appearance28
        UltraGridColumn7.Header.Caption = "TOTAL "
        UltraGridColumn7.Width = 60
        UltraGridColumn8.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn8.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        Appearance29.ForeColor = System.Drawing.Color.Navy
        Appearance29.TextHAlignAsString = "Center"
        UltraGridColumn8.CellAppearance = Appearance29
        UltraGridColumn8.Width = 50
        UltraGridColumn9.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn9.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        Appearance30.ForeColor = System.Drawing.Color.Navy
        Appearance30.TextHAlignAsString = "Center"
        UltraGridColumn9.CellAppearance = Appearance30
        UltraGridColumn9.Width = 61
        UltraGridColumn10.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn10.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.CheckBox
        UltraGridColumn11.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn11.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        Appearance31.ForeColor = System.Drawing.Color.Navy
        Appearance31.TextHAlignAsString = "Center"
        UltraGridColumn11.CellAppearance = Appearance31
        UltraGridColumn11.Header.Caption = "FERIADOS"
        UltraGridColumn11.Width = 69
        UltraGridColumn12.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn12.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        Appearance32.ForeColor = System.Drawing.Color.Navy
        Appearance32.TextHAlignAsString = "Center"
        UltraGridColumn12.CellAppearance = Appearance32
        UltraGridColumn12.Width = 48
        UltraGridBand1.Columns.AddRange(New Object() {UltraGridColumn1, UltraGridColumn2, UltraGridColumn3, UltraGridColumn4, UltraGridColumn5, UltraGridColumn6, UltraGridColumn7, UltraGridColumn8, UltraGridColumn9, UltraGridColumn10, UltraGridColumn11, UltraGridColumn12})
        Appearance33.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Appearance33.FontData.SizeInPoints = 9.0!
        Appearance33.ForeColor = System.Drawing.Color.Red
        UltraGridGroup1.Header.Appearance = Appearance33
        UltraGridGroup1.Key = "PERSONAL"
        Appearance34.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Appearance34.FontData.SizeInPoints = 9.0!
        Appearance34.ForeColor = System.Drawing.Color.Red
        UltraGridGroup2.Header.Appearance = Appearance34
        UltraGridGroup2.Key = "SALA DE BEBES"
        Appearance35.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Appearance35.FontData.SizeInPoints = 9.0!
        Appearance35.ForeColor = System.Drawing.Color.Red
        UltraGridGroup3.Header.Appearance = Appearance35
        UltraGridGroup3.Key = "HOSPITALIZACION"
        UltraGridBand1.Groups.AddRange(New Infragistics.Win.UltraWinGrid.UltraGridGroup() {UltraGridGroup1, UltraGridGroup2, UltraGridGroup3})
        Appearance36.BackColor = System.Drawing.Color.White
        Appearance36.FontData.BoldAsString = "True"
        Appearance36.FontData.SizeInPoints = 10.0!
        Appearance36.ForeColor = System.Drawing.Color.Navy
        Appearance36.TextHAlignAsString = "Center"
        SummarySettings1.Appearance = Appearance36
        SummarySettings1.DisplayFormat = "{0}"
        SummarySettings1.GroupBySummaryValueAppearance = Appearance37
        SummarySettings1.SummaryDisplayArea = Infragistics.Win.UltraWinGrid.SummaryDisplayAreas.BottomFixed
        Appearance38.BackColor = System.Drawing.Color.White
        Appearance38.FontData.BoldAsString = "True"
        Appearance38.FontData.SizeInPoints = 10.0!
        Appearance38.ForeColor = System.Drawing.Color.Navy
        Appearance38.TextHAlignAsString = "Center"
        SummarySettings2.Appearance = Appearance38
        SummarySettings2.DisplayFormat = "{0}"
        SummarySettings2.GroupBySummaryValueAppearance = Appearance39
        SummarySettings2.SummaryDisplayArea = Infragistics.Win.UltraWinGrid.SummaryDisplayAreas.BottomFixed
        Appearance40.BackColor = System.Drawing.Color.White
        Appearance40.FontData.BoldAsString = "True"
        Appearance40.FontData.SizeInPoints = 10.0!
        Appearance40.ForeColor = System.Drawing.Color.Navy
        Appearance40.TextHAlignAsString = "Center"
        SummarySettings3.Appearance = Appearance40
        SummarySettings3.DisplayFormat = "{0}"
        SummarySettings3.GroupBySummaryValueAppearance = Appearance41
        SummarySettings3.SummaryDisplayArea = Infragistics.Win.UltraWinGrid.SummaryDisplayAreas.BottomFixed
        Appearance42.BackColor = System.Drawing.Color.White
        Appearance42.FontData.BoldAsString = "True"
        Appearance42.FontData.SizeInPoints = 10.0!
        Appearance42.ForeColor = System.Drawing.Color.Navy
        Appearance42.TextHAlignAsString = "Center"
        SummarySettings4.Appearance = Appearance42
        SummarySettings4.DisplayFormat = "{0}"
        SummarySettings4.GroupBySummaryValueAppearance = Appearance43
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
        Me.ug_detalle.Location = New System.Drawing.Point(12, 109)
        Me.ug_detalle.Name = "ug_detalle"
        Me.ug_detalle.Size = New System.Drawing.Size(870, 405)
        Me.ug_detalle.TabIndex = 23
        Me.ug_detalle.Text = "UltraGrid1"
        '
        'PL_PR_RegHoras_PerAsistencial
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(891, 526)
        Me.Controls.Add(Me.ug_detalle)
        Me.Controls.Add(Me.ugb_act_estado)
        Me.Controls.Add(Me.UltraGroupBox1)
        Me.Controls.Add(Me.UltraGroupBox2)
        Me.Controls.Add(Me.Tools_Mante)
        Me.Name = "PL_PR_RegHoras_PerAsistencial"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Reg. de Horas Personal Asistencial "
        Me.Tools_Mante.ResumeLayout(False)
        Me.Tools_Mante.PerformLayout()
        CType(Me.ugb_act_estado, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ugb_act_estado.ResumeLayout(False)
        CType(Me.uos_visto, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UltraGroupBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraGroupBox1.ResumeLayout(False)
        Me.UltraGroupBox1.PerformLayout()
        CType(Me.uce_mes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.une_ayo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UltraGroupBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraGroupBox2.ResumeLayout(False)
        Me.UltraGroupBox2.PerformLayout()
        CType(Me.utxt_estado2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_estado, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.uds_detalle, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ug_detalle, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Tools_Mante As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents Tool_salir As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ugb_act_estado As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents ubtn_actualizar As Infragistics.Win.Misc.UltraButton
    Friend WithEvents uos_visto As Infragistics.Win.UltraWinEditors.UltraOptionSet
    Friend WithEvents UltraGroupBox1 As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents uce_mes As Infragistics.Win.UltraWinEditors.UltraComboEditor
    Friend WithEvents une_ayo As Infragistics.Win.UltraWinEditors.UltraNumericEditor
    Friend WithEvents UltraLabel2 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel1 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraGroupBox2 As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents utxt_estado2 As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents txt_estado As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents uds_detalle As Infragistics.Win.UltraWinDataSource.UltraDataSource
    Friend WithEvents ug_detalle As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents Tool_Reporte As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
End Class
