<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PL_RP_Aportaciones_AFP
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
        Dim Appearance1 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance15 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance2 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraDataColumn1 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("PE_ID_AFP")
        Dim UltraDataColumn2 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("AF_NOMBRE")
        Dim UltraDataColumn3 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("PE_NUM_AFP")
        Dim UltraDataColumn4 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("PE_APE_PAT")
        Dim UltraDataColumn5 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("PE_APE_MAT")
        Dim UltraDataColumn6 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("PE_NOM_PRI")
        Dim UltraDataColumn7 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("PE_NOM_SEG")
        Dim UltraDataColumn8 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("NOMBRES")
        Dim UltraDataColumn9 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("BASICO")
        Dim UltraDataColumn10 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("APORTE_OBLI")
        Dim UltraDataColumn11 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("PRIMA_SEGU")
        Dim UltraDataColumn12 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("COMI_VAR")
        Dim UltraDataColumn13 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("SUB_TOTAL")
        Dim UltraDataColumn14 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("TOTAL")
        Dim UltraGridBand1 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1)
        Dim UltraGridColumn1 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("PE_ID_AFP")
        Dim UltraGridColumn2 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("AF_NOMBRE", -1, Nothing, 0, Infragistics.Win.UltraWinGrid.SortIndicator.Ascending, True)
        Dim UltraGridColumn3 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("PE_NUM_AFP")
        Dim UltraGridColumn4 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("PE_APE_PAT")
        Dim UltraGridColumn5 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("PE_APE_MAT")
        Dim UltraGridColumn6 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("PE_NOM_PRI")
        Dim UltraGridColumn7 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("PE_NOM_SEG")
        Dim UltraGridColumn8 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NOMBRES")
        Dim UltraGridColumn9 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("BASICO")
        Dim Appearance3 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn10 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("APORTE_OBLI")
        Dim Appearance4 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn11 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("PRIMA_SEGU")
        Dim Appearance5 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn12 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("COMI_VAR")
        Dim Appearance6 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn13 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("SUB_TOTAL")
        Dim Appearance7 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn14 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TOTAL")
        Dim Appearance8 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim SummarySettings1 As Infragistics.Win.UltraWinGrid.SummarySettings = New Infragistics.Win.UltraWinGrid.SummarySettings("", Infragistics.Win.UltraWinGrid.SummaryType.Sum, Nothing, "BASICO", 8, True, "Band 0", 0, Infragistics.Win.UltraWinGrid.SummaryPosition.UseSummaryPositionColumn, "BASICO", 8, True)
        Dim Appearance9 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance10 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim SummarySettings2 As Infragistics.Win.UltraWinGrid.SummarySettings = New Infragistics.Win.UltraWinGrid.SummarySettings("", Infragistics.Win.UltraWinGrid.SummaryType.Sum, Nothing, "APORTE_OBLI", 9, True, "Band 0", 0, Infragistics.Win.UltraWinGrid.SummaryPosition.UseSummaryPositionColumn, "APORTE_OBLI", 9, True)
        Dim Appearance11 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance12 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim SummarySettings3 As Infragistics.Win.UltraWinGrid.SummarySettings = New Infragistics.Win.UltraWinGrid.SummarySettings("", Infragistics.Win.UltraWinGrid.SummaryType.Sum, Nothing, "PRIMA_SEGU", 10, True, "Band 0", 0, Infragistics.Win.UltraWinGrid.SummaryPosition.UseSummaryPositionColumn, "PRIMA_SEGU", 10, True)
        Dim Appearance13 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance14 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim SummarySettings4 As Infragistics.Win.UltraWinGrid.SummarySettings = New Infragistics.Win.UltraWinGrid.SummarySettings("", Infragistics.Win.UltraWinGrid.SummaryType.Sum, Nothing, "COMI_VAR", 11, True, "Band 0", 0, Infragistics.Win.UltraWinGrid.SummaryPosition.UseSummaryPositionColumn, "COMI_VAR", 11, True)
        Dim Appearance16 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance17 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim SummarySettings5 As Infragistics.Win.UltraWinGrid.SummarySettings = New Infragistics.Win.UltraWinGrid.SummarySettings("", Infragistics.Win.UltraWinGrid.SummaryType.Sum, Nothing, "SUB_TOTAL", 12, True, "Band 0", 0, Infragistics.Win.UltraWinGrid.SummaryPosition.UseSummaryPositionColumn, "SUB_TOTAL", 12, True)
        Dim Appearance18 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance19 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim SummarySettings6 As Infragistics.Win.UltraWinGrid.SummarySettings = New Infragistics.Win.UltraWinGrid.SummarySettings("", Infragistics.Win.UltraWinGrid.SummaryType.Sum, Nothing, "TOTAL", 13, True, "Band 0", 0, Infragistics.Win.UltraWinGrid.SummaryPosition.UseSummaryPositionColumn, "TOTAL", 13, True)
        Dim Appearance20 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance21 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance66 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance67 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.Tool_imprimir = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.Tool_Salir = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.UltraGroupBox1 = New Infragistics.Win.Misc.UltraGroupBox()
        Me.uce_TipoPersonal = New Infragistics.Win.UltraWinEditors.UltraComboEditor()
        Me.UltraLabel2 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraLabel3 = New Infragistics.Win.Misc.UltraLabel()
        Me.uce_Mes = New Infragistics.Win.UltraWinEditors.UltraComboEditor()
        Me.une_ayo = New Infragistics.Win.UltraWinEditors.UltraNumericEditor()
        Me.UltraLabel1 = New Infragistics.Win.Misc.UltraLabel()
        Me.uds_aportaciones = New Infragistics.Win.UltraWinDataSource.UltraDataSource(Me.components)
        Me.ug_aportaciones = New Infragistics.Win.UltraWinGrid.UltraGrid()
        Me.ToolStrip1.SuspendLayout()
        CType(Me.UltraGroupBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraGroupBox1.SuspendLayout()
        CType(Me.uce_TipoPersonal, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.uce_Mes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.une_ayo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.uds_aportaciones, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ug_aportaciones, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ToolStrip1
        '
        Me.ToolStrip1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripSeparator4, Me.Tool_imprimir, Me.ToolStripSeparator2, Me.Tool_Salir, Me.ToolStripSeparator1})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(800, 25)
        Me.ToolStrip1.TabIndex = 25
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(6, 25)
        '
        'Tool_imprimir
        '
        Me.Tool_imprimir.Image = Global.Contabilidad.My.Resources.Resources._004
        Me.Tool_imprimir.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Tool_imprimir.Name = "Tool_imprimir"
        Me.Tool_imprimir.Size = New System.Drawing.Size(73, 22)
        Me.Tool_imprimir.Text = "Imprimir"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'Tool_Salir
        '
        Me.Tool_Salir.Image = Global.Contabilidad.My.Resources.Resources._28
        Me.Tool_Salir.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Tool_Salir.Name = "Tool_Salir"
        Me.Tool_Salir.Size = New System.Drawing.Size(49, 22)
        Me.Tool_Salir.Text = "Salir"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'UltraGroupBox1
        '
        Me.UltraGroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.UltraGroupBox1.Controls.Add(Me.uce_TipoPersonal)
        Me.UltraGroupBox1.Controls.Add(Me.UltraLabel2)
        Me.UltraGroupBox1.Controls.Add(Me.UltraLabel3)
        Me.UltraGroupBox1.Controls.Add(Me.uce_Mes)
        Me.UltraGroupBox1.Controls.Add(Me.une_ayo)
        Me.UltraGroupBox1.Controls.Add(Me.UltraLabel1)
        Me.UltraGroupBox1.Location = New System.Drawing.Point(12, 28)
        Me.UltraGroupBox1.Name = "UltraGroupBox1"
        Me.UltraGroupBox1.Size = New System.Drawing.Size(776, 46)
        Me.UltraGroupBox1.TabIndex = 26
        '
        'uce_TipoPersonal
        '
        Me.uce_TipoPersonal.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.uce_TipoPersonal.Location = New System.Drawing.Point(335, 12)
        Me.uce_TipoPersonal.Name = "uce_TipoPersonal"
        Me.uce_TipoPersonal.Size = New System.Drawing.Size(116, 21)
        Me.uce_TipoPersonal.TabIndex = 16
        '
        'UltraLabel2
        '
        Appearance1.BackColor = System.Drawing.Color.Transparent
        Appearance1.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel2.Appearance = Appearance1
        Me.UltraLabel2.AutoSize = True
        Me.UltraLabel2.Location = New System.Drawing.Point(255, 16)
        Me.UltraLabel2.Name = "UltraLabel2"
        Me.UltraLabel2.Size = New System.Drawing.Size(74, 14)
        Me.UltraLabel2.TabIndex = 15
        Me.UltraLabel2.Text = "Tipo Personal"
        '
        'UltraLabel3
        '
        Appearance15.BackColor = System.Drawing.Color.Transparent
        Appearance15.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel3.Appearance = Appearance15
        Me.UltraLabel3.AutoSize = True
        Me.UltraLabel3.Location = New System.Drawing.Point(113, 14)
        Me.UltraLabel3.Name = "UltraLabel3"
        Me.UltraLabel3.Size = New System.Drawing.Size(26, 14)
        Me.UltraLabel3.TabIndex = 21
        Me.UltraLabel3.Text = "Mes "
        '
        'uce_Mes
        '
        Me.uce_Mes.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.uce_Mes.Location = New System.Drawing.Point(145, 12)
        Me.uce_Mes.Name = "uce_Mes"
        Me.uce_Mes.Size = New System.Drawing.Size(91, 21)
        Me.uce_Mes.TabIndex = 20
        '
        'une_ayo
        '
        Me.une_ayo.Location = New System.Drawing.Point(43, 12)
        Me.une_ayo.MaskInput = "nnnn"
        Me.une_ayo.Name = "une_ayo"
        Me.une_ayo.Size = New System.Drawing.Size(59, 21)
        Me.une_ayo.SpinButtonDisplayStyle = Infragistics.Win.ButtonDisplayStyle.Always
        Me.une_ayo.TabIndex = 19
        '
        'UltraLabel1
        '
        Appearance2.BackColor = System.Drawing.Color.Transparent
        Appearance2.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel1.Appearance = Appearance2
        Me.UltraLabel1.AutoSize = True
        Me.UltraLabel1.Location = New System.Drawing.Point(13, 16)
        Me.UltraLabel1.Name = "UltraLabel1"
        Me.UltraLabel1.Size = New System.Drawing.Size(24, 14)
        Me.UltraLabel1.TabIndex = 18
        Me.UltraLabel1.Text = "Año"
        '
        'uds_aportaciones
        '
        Me.uds_aportaciones.AllowDelete = False
        UltraDataColumn9.DataType = GetType(Double)
        UltraDataColumn10.DataType = GetType(Double)
        UltraDataColumn11.DataType = GetType(Double)
        UltraDataColumn12.DataType = GetType(Double)
        UltraDataColumn13.DataType = GetType(Double)
        UltraDataColumn14.DataType = GetType(Double)
        Me.uds_aportaciones.Band.Columns.AddRange(New Object() {UltraDataColumn1, UltraDataColumn2, UltraDataColumn3, UltraDataColumn4, UltraDataColumn5, UltraDataColumn6, UltraDataColumn7, UltraDataColumn8, UltraDataColumn9, UltraDataColumn10, UltraDataColumn11, UltraDataColumn12, UltraDataColumn13, UltraDataColumn14})
        '
        'ug_aportaciones
        '
        Me.ug_aportaciones.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ug_aportaciones.DataSource = Me.uds_aportaciones
        Me.ug_aportaciones.DisplayLayout.AutoFitStyle = Infragistics.Win.UltraWinGrid.AutoFitStyle.ExtendLastColumn
        UltraGridBand1.ColHeaderLines = 2
        UltraGridColumn1.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn1.Header.VisiblePosition = 0
        UltraGridColumn1.Hidden = True
        UltraGridColumn2.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn2.Header.Caption = "AFP"
        UltraGridColumn2.Header.VisiblePosition = 1
        UltraGridColumn3.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn3.Header.Caption = "NUMERO"
        UltraGridColumn3.Header.VisiblePosition = 2
        UltraGridColumn3.Width = 89
        UltraGridColumn4.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn4.Header.VisiblePosition = 3
        UltraGridColumn4.Hidden = True
        UltraGridColumn5.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn5.Header.VisiblePosition = 4
        UltraGridColumn5.Hidden = True
        UltraGridColumn6.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn6.Header.VisiblePosition = 5
        UltraGridColumn6.Hidden = True
        UltraGridColumn7.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn7.Header.VisiblePosition = 6
        UltraGridColumn7.Hidden = True
        UltraGridColumn8.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn8.Header.VisiblePosition = 7
        UltraGridColumn8.Width = 190
        UltraGridColumn9.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        Appearance3.TextHAlignAsString = "Right"
        UltraGridColumn9.CellAppearance = Appearance3
        UltraGridColumn9.Header.VisiblePosition = 8
        UltraGridColumn9.MaskDisplayMode = Infragistics.Win.UltraWinMaskedEdit.MaskMode.IncludeLiterals
        UltraGridColumn9.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Double]
        UltraGridColumn9.Width = 88
        UltraGridColumn10.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        Appearance4.TextHAlignAsString = "Right"
        UltraGridColumn10.CellAppearance = Appearance4
        UltraGridColumn10.Header.Caption = "APORTE OBLIGATORIO"
        UltraGridColumn10.Header.TextOrientation = New Infragistics.Win.TextOrientationInfo(0, Infragistics.Win.TextFlowDirection.Horizontal)
        UltraGridColumn10.Header.VisiblePosition = 9
        UltraGridColumn10.MaskDisplayMode = Infragistics.Win.UltraWinMaskedEdit.MaskMode.IncludeLiterals
        UltraGridColumn10.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Double]
        UltraGridColumn10.Width = 74
        UltraGridColumn11.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        Appearance5.TextHAlignAsString = "Right"
        UltraGridColumn11.CellAppearance = Appearance5
        UltraGridColumn11.Header.Caption = "PRIMA SEGURO"
        UltraGridColumn11.Header.VisiblePosition = 10
        UltraGridColumn11.MaskDisplayMode = Infragistics.Win.UltraWinMaskedEdit.MaskMode.IncludeLiterals
        UltraGridColumn11.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Double]
        UltraGridColumn11.Width = 74
        UltraGridColumn12.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        Appearance6.TextHAlignAsString = "Right"
        UltraGridColumn12.CellAppearance = Appearance6
        UltraGridColumn12.Header.Caption = "COMISION VARIABLE"
        UltraGridColumn12.Header.VisiblePosition = 11
        UltraGridColumn12.MaskDisplayMode = Infragistics.Win.UltraWinMaskedEdit.MaskMode.IncludeLiterals
        UltraGridColumn12.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Double]
        UltraGridColumn12.Width = 69
        UltraGridColumn13.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        Appearance7.TextHAlignAsString = "Right"
        UltraGridColumn13.CellAppearance = Appearance7
        UltraGridColumn13.Header.Caption = "SUB TOTAL"
        UltraGridColumn13.Header.VisiblePosition = 12
        UltraGridColumn13.MaskDisplayMode = Infragistics.Win.UltraWinMaskedEdit.MaskMode.IncludeLiterals
        UltraGridColumn13.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Double]
        UltraGridColumn13.Width = 69
        UltraGridColumn14.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        Appearance8.TextHAlignAsString = "Right"
        UltraGridColumn14.CellAppearance = Appearance8
        UltraGridColumn14.Header.VisiblePosition = 13
        UltraGridColumn14.MaskDisplayMode = Infragistics.Win.UltraWinMaskedEdit.MaskMode.IncludeLiterals
        UltraGridColumn14.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Double]
        UltraGridColumn14.Width = 69
        UltraGridBand1.Columns.AddRange(New Object() {UltraGridColumn1, UltraGridColumn2, UltraGridColumn3, UltraGridColumn4, UltraGridColumn5, UltraGridColumn6, UltraGridColumn7, UltraGridColumn8, UltraGridColumn9, UltraGridColumn10, UltraGridColumn11, UltraGridColumn12, UltraGridColumn13, UltraGridColumn14})
        UltraGridBand1.GroupHeaderLines = 2
        Appearance9.BackColor = System.Drawing.Color.White
        Appearance9.FontData.BoldAsString = "True"
        Appearance9.FontData.SizeInPoints = 9.0!
        Appearance9.ForeColor = System.Drawing.Color.Navy
        Appearance9.TextHAlignAsString = "Right"
        SummarySettings1.Appearance = Appearance9
        SummarySettings1.DisplayFormat = "{0:##,##0.00#}"
        SummarySettings1.GroupBySummaryValueAppearance = Appearance10
        SummarySettings1.SummaryDisplayArea = CType((Infragistics.Win.UltraWinGrid.SummaryDisplayAreas.Bottom Or Infragistics.Win.UltraWinGrid.SummaryDisplayAreas.GroupByRowsFooter), Infragistics.Win.UltraWinGrid.SummaryDisplayAreas)
        Appearance11.BackColor = System.Drawing.Color.White
        Appearance11.FontData.BoldAsString = "True"
        Appearance11.FontData.SizeInPoints = 9.0!
        Appearance11.ForeColor = System.Drawing.Color.Navy
        Appearance11.TextHAlignAsString = "Right"
        SummarySettings2.Appearance = Appearance11
        SummarySettings2.DisplayFormat = "{0:##,##0.00#}"
        SummarySettings2.GroupBySummaryValueAppearance = Appearance12
        SummarySettings2.SummaryDisplayArea = CType((Infragistics.Win.UltraWinGrid.SummaryDisplayAreas.Bottom Or Infragistics.Win.UltraWinGrid.SummaryDisplayAreas.GroupByRowsFooter), Infragistics.Win.UltraWinGrid.SummaryDisplayAreas)
        Appearance13.BackColor = System.Drawing.Color.White
        Appearance13.FontData.BoldAsString = "True"
        Appearance13.FontData.SizeInPoints = 9.0!
        Appearance13.ForeColor = System.Drawing.Color.Navy
        Appearance13.TextHAlignAsString = "Right"
        SummarySettings3.Appearance = Appearance13
        SummarySettings3.DisplayFormat = "{0:##,##0.00#}"
        SummarySettings3.GroupBySummaryValueAppearance = Appearance14
        SummarySettings3.SummaryDisplayArea = CType((Infragistics.Win.UltraWinGrid.SummaryDisplayAreas.Bottom Or Infragistics.Win.UltraWinGrid.SummaryDisplayAreas.GroupByRowsFooter), Infragistics.Win.UltraWinGrid.SummaryDisplayAreas)
        Appearance16.BackColor = System.Drawing.Color.White
        Appearance16.FontData.BoldAsString = "True"
        Appearance16.FontData.SizeInPoints = 9.0!
        Appearance16.ForeColor = System.Drawing.Color.Navy
        Appearance16.TextHAlignAsString = "Right"
        SummarySettings4.Appearance = Appearance16
        SummarySettings4.DisplayFormat = "{0:##,##0.00#}"
        SummarySettings4.GroupBySummaryValueAppearance = Appearance17
        SummarySettings4.SummaryDisplayArea = CType((Infragistics.Win.UltraWinGrid.SummaryDisplayAreas.Bottom Or Infragistics.Win.UltraWinGrid.SummaryDisplayAreas.GroupByRowsFooter), Infragistics.Win.UltraWinGrid.SummaryDisplayAreas)
        Appearance18.BackColor = System.Drawing.Color.White
        Appearance18.FontData.BoldAsString = "True"
        Appearance18.FontData.SizeInPoints = 9.0!
        Appearance18.ForeColor = System.Drawing.Color.Navy
        Appearance18.TextHAlignAsString = "Right"
        SummarySettings5.Appearance = Appearance18
        SummarySettings5.DisplayFormat = "{0:##,##0.00#}"
        SummarySettings5.GroupBySummaryValueAppearance = Appearance19
        SummarySettings5.SummaryDisplayArea = CType((Infragistics.Win.UltraWinGrid.SummaryDisplayAreas.Bottom Or Infragistics.Win.UltraWinGrid.SummaryDisplayAreas.GroupByRowsFooter), Infragistics.Win.UltraWinGrid.SummaryDisplayAreas)
        Appearance20.BackColor = System.Drawing.Color.White
        Appearance20.FontData.BoldAsString = "True"
        Appearance20.FontData.SizeInPoints = 9.0!
        Appearance20.ForeColor = System.Drawing.Color.Navy
        Appearance20.TextHAlignAsString = "Right"
        SummarySettings6.Appearance = Appearance20
        SummarySettings6.DisplayFormat = "{0:##,##0.00#}"
        SummarySettings6.GroupBySummaryValueAppearance = Appearance21
        SummarySettings6.SummaryDisplayArea = CType((Infragistics.Win.UltraWinGrid.SummaryDisplayAreas.Bottom Or Infragistics.Win.UltraWinGrid.SummaryDisplayAreas.GroupByRowsFooter), Infragistics.Win.UltraWinGrid.SummaryDisplayAreas)
        UltraGridBand1.Summaries.AddRange(New Infragistics.Win.UltraWinGrid.SummarySettings() {SummarySettings1, SummarySettings2, SummarySettings3, SummarySettings4, SummarySettings5, SummarySettings6})
        UltraGridBand1.SummaryFooterCaption = ""
        Me.ug_aportaciones.DisplayLayout.BandsSerializer.Add(UltraGridBand1)
        Me.ug_aportaciones.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.[False]
        Appearance66.BackColor = System.Drawing.Color.White
        Appearance66.ForeColor = System.Drawing.Color.Navy
        Me.ug_aportaciones.DisplayLayout.GroupByBox.Appearance = Appearance66
        Me.ug_aportaciones.DisplayLayout.MaxRowScrollRegions = 1
        Appearance67.BackColor = System.Drawing.Color.WhiteSmoke
        Appearance67.BackColor2 = System.Drawing.Color.WhiteSmoke
        Me.ug_aportaciones.DisplayLayout.Override.RowAlternateAppearance = Appearance67
        Me.ug_aportaciones.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.ug_aportaciones.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy
        Me.ug_aportaciones.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ug_aportaciones.Location = New System.Drawing.Point(12, 80)
        Me.ug_aportaciones.Name = "ug_aportaciones"
        Me.ug_aportaciones.Size = New System.Drawing.Size(776, 344)
        Me.ug_aportaciones.TabIndex = 27
        Me.ug_aportaciones.Text = "UltraGrid1"
        '
        'PL_RP_Aportaciones_AFP
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(800, 436)
        Me.Controls.Add(Me.ug_aportaciones)
        Me.Controls.Add(Me.UltraGroupBox1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Name = "PL_RP_Aportaciones_AFP"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Aportaciones AFP"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        CType(Me.UltraGroupBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraGroupBox1.ResumeLayout(False)
        Me.UltraGroupBox1.PerformLayout()
        CType(Me.uce_TipoPersonal, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.uce_Mes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.une_ayo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.uds_aportaciones, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ug_aportaciones, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents Tool_imprimir As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents Tool_Salir As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents UltraGroupBox1 As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents uce_TipoPersonal As Infragistics.Win.UltraWinEditors.UltraComboEditor
    Friend WithEvents UltraLabel2 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel3 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents uce_Mes As Infragistics.Win.UltraWinEditors.UltraComboEditor
    Friend WithEvents une_ayo As Infragistics.Win.UltraWinEditors.UltraNumericEditor
    Friend WithEvents UltraLabel1 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents uds_aportaciones As Infragistics.Win.UltraWinDataSource.UltraDataSource
    Friend WithEvents ug_aportaciones As Infragistics.Win.UltraWinGrid.UltraGrid
End Class
