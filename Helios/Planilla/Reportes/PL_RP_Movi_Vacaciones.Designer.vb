<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PL_RP_Movi_Vacaciones
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
        Dim EditorButton1 As Infragistics.Win.UltraWinEditors.EditorButton = New Infragistics.Win.UltraWinEditors.EditorButton()
        Dim Appearance6 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance2 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraDataColumn1 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("TV_CODIGO")
        Dim UltraDataColumn2 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("TV_NOMBRES")
        Dim UltraDataColumn3 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("TV_FEC_ING")
        Dim UltraDataColumn4 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("TV_PERIODO")
        Dim UltraDataColumn5 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("TV_DIAS_V")
        Dim UltraDataColumn6 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("TV_DIAS_T")
        Dim UltraDataColumn7 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("TV_DIAS_S")
        Dim UltraDataColumn8 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("TV_FEC_INI")
        Dim UltraDataColumn9 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("TV_FEC_FIN")
        Dim UltraDataColumn10 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("E")
        Dim UltraDataColumn11 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("TV_OBS")
        Dim UltraGridBand1 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1)
        Dim UltraGridColumn1 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TV_CODIGO")
        Dim Appearance1 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn2 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TV_NOMBRES")
        Dim Appearance3 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn3 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TV_FEC_ING")
        Dim Appearance4 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn4 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TV_PERIODO", -1, Nothing, 1, Infragistics.Win.UltraWinGrid.SortIndicator.Ascending, True)
        Dim Appearance5 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn5 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TV_DIAS_V")
        Dim Appearance7 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn6 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TV_DIAS_T")
        Dim Appearance8 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn7 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TV_DIAS_S")
        Dim Appearance10 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn8 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TV_FEC_INI")
        Dim Appearance11 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn9 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TV_FEC_FIN")
        Dim Appearance12 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn10 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("E", -1, Nothing, 0, Infragistics.Win.UltraWinGrid.SortIndicator.Ascending, True)
        Dim UltraGridColumn11 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TV_OBS")
        Dim SummarySettings1 As Infragistics.Win.UltraWinGrid.SummarySettings = New Infragistics.Win.UltraWinGrid.SummarySettings("", Infragistics.Win.UltraWinGrid.SummaryType.Sum, Nothing, "TV_DIAS_V", 4, True, "Band 0", 0, Infragistics.Win.UltraWinGrid.SummaryPosition.UseSummaryPositionColumn, "TV_DIAS_V", 4, True)
        Dim Appearance13 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance14 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance37 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance38 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance39 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance9 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraTab1 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraTab2 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim ValueListItem1 As Infragistics.Win.ValueListItem = New Infragistics.Win.ValueListItem()
        Dim ValueListItem2 As Infragistics.Win.ValueListItem = New Infragistics.Win.ValueListItem()
        Dim ValueListItem3 As Infragistics.Win.ValueListItem = New Infragistics.Win.ValueListItem()
        Me.UltraTabPageControl1 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.txt_nombres = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.txt_idpersonal = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.txt_codper = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.UltraLabel2 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraTabPageControl2 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.uce_CARGO = New Infragistics.Win.UltraWinEditors.UltraComboEditor()
        Me.UltraLabel3 = New Infragistics.Win.Misc.UltraLabel()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.Tool_Consultar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.Tool_imprimir = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.Tool_Enviar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator()
        Me.Tool_Salir = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.uds_vaca = New Infragistics.Win.UltraWinDataSource.UltraDataSource(Me.components)
        Me.ug_vaca = New Infragistics.Win.UltraWinGrid.UltraGrid()
        Me.udte_fec_corte = New Infragistics.Win.UltraWinEditors.UltraDateTimeEditor()
        Me.UltraLabel1 = New Infragistics.Win.Misc.UltraLabel()
        Me.uchk_inicio = New Infragistics.Win.UltraWinEditors.UltraCheckEditor()
        Me.UltraGroupBox1 = New Infragistics.Win.Misc.UltraGroupBox()
        Me.utc_1 = New Infragistics.Win.UltraWinTabControl.UltraTabControl()
        Me.UltraTabSharedControlsPage1 = New Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage()
        Me.uos_filtros = New Infragistics.Win.UltraWinEditors.UltraOptionSet()
        Me.UltraGroupBox2 = New Infragistics.Win.Misc.UltraGroupBox()
        Me.UltraTabPageControl1.SuspendLayout()
        CType(Me.txt_nombres, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_idpersonal, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_codper, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabPageControl2.SuspendLayout()
        CType(Me.uce_CARGO, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip1.SuspendLayout()
        CType(Me.uds_vaca, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ug_vaca, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.udte_fec_corte, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UltraGroupBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraGroupBox1.SuspendLayout()
        CType(Me.utc_1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.utc_1.SuspendLayout()
        CType(Me.uos_filtros, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UltraGroupBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraGroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'UltraTabPageControl1
        '
        Me.UltraTabPageControl1.Controls.Add(Me.txt_nombres)
        Me.UltraTabPageControl1.Controls.Add(Me.txt_idpersonal)
        Me.UltraTabPageControl1.Controls.Add(Me.txt_codper)
        Me.UltraTabPageControl1.Controls.Add(Me.UltraLabel2)
        Me.UltraTabPageControl1.Location = New System.Drawing.Point(1, 23)
        Me.UltraTabPageControl1.Name = "UltraTabPageControl1"
        Me.UltraTabPageControl1.Size = New System.Drawing.Size(583, 45)
        '
        'txt_nombres
        '
        Me.txt_nombres.Location = New System.Drawing.Point(181, 13)
        Me.txt_nombres.Name = "txt_nombres"
        Me.txt_nombres.ReadOnly = True
        Me.txt_nombres.Size = New System.Drawing.Size(333, 21)
        Me.txt_nombres.TabIndex = 32
        '
        'txt_idpersonal
        '
        Me.txt_idpersonal.Location = New System.Drawing.Point(145, 13)
        Me.txt_idpersonal.Name = "txt_idpersonal"
        Me.txt_idpersonal.Size = New System.Drawing.Size(36, 21)
        Me.txt_idpersonal.TabIndex = 33
        '
        'txt_codper
        '
        Appearance6.ImageHAlign = Infragistics.Win.HAlign.Center
        EditorButton1.Appearance = Appearance6
        Me.txt_codper.ButtonsRight.Add(EditorButton1)
        Me.txt_codper.Location = New System.Drawing.Point(79, 13)
        Me.txt_codper.Name = "txt_codper"
        Me.txt_codper.Size = New System.Drawing.Size(66, 21)
        Me.txt_codper.TabIndex = 33
        '
        'UltraLabel2
        '
        Appearance2.BackColor = System.Drawing.Color.Transparent
        Appearance2.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel2.Appearance = Appearance2
        Me.UltraLabel2.AutoSize = True
        Me.UltraLabel2.Location = New System.Drawing.Point(14, 17)
        Me.UltraLabel2.Name = "UltraLabel2"
        Me.UltraLabel2.Size = New System.Drawing.Size(59, 14)
        Me.UltraLabel2.TabIndex = 34
        Me.UltraLabel2.Text = "Trabajador"
        '
        'UltraTabPageControl2
        '
        Me.UltraTabPageControl2.Controls.Add(Me.uce_CARGO)
        Me.UltraTabPageControl2.Controls.Add(Me.UltraLabel3)
        Me.UltraTabPageControl2.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl2.Name = "UltraTabPageControl2"
        Me.UltraTabPageControl2.Size = New System.Drawing.Size(583, 45)
        '
        'uce_CARGO
        '
        Me.uce_CARGO.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend
        Me.uce_CARGO.DropDownListWidth = 300
        Me.uce_CARGO.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.uce_CARGO.Location = New System.Drawing.Point(52, 9)
        Me.uce_CARGO.Name = "uce_CARGO"
        Me.uce_CARGO.Size = New System.Drawing.Size(219, 21)
        Me.uce_CARGO.TabIndex = 36
        '
        'UltraLabel3
        '
        Me.UltraLabel3.AutoSize = True
        Me.UltraLabel3.Location = New System.Drawing.Point(11, 13)
        Me.UltraLabel3.Name = "UltraLabel3"
        Me.UltraLabel3.Size = New System.Drawing.Size(35, 14)
        Me.UltraLabel3.TabIndex = 35
        Me.UltraLabel3.Text = "Cargo"
        '
        'ToolStrip1
        '
        Me.ToolStrip1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripSeparator4, Me.Tool_Consultar, Me.ToolStripSeparator3, Me.Tool_imprimir, Me.ToolStripSeparator2, Me.Tool_Enviar, Me.ToolStripSeparator5, Me.Tool_Salir, Me.ToolStripSeparator1})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(610, 25)
        Me.ToolStrip1.TabIndex = 29
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(6, 25)
        '
        'Tool_Consultar
        '
        Me.Tool_Consultar.Image = Global.Contabilidad.My.Resources.Resources._16__Search_
        Me.Tool_Consultar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Tool_Consultar.Name = "Tool_Consultar"
        Me.Tool_Consultar.Size = New System.Drawing.Size(73, 22)
        Me.Tool_Consultar.Text = "Consultar"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 25)
        '
        'Tool_imprimir
        '
        Me.Tool_imprimir.Image = Global.Contabilidad.My.Resources.Resources._004
        Me.Tool_imprimir.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Tool_imprimir.Name = "Tool_imprimir"
        Me.Tool_imprimir.Size = New System.Drawing.Size(65, 22)
        Me.Tool_imprimir.Text = "Imprimir"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'Tool_Enviar
        '
        Me.Tool_Enviar.Image = Global.Contabilidad.My.Resources.Resources._16__Mail_
        Me.Tool_Enviar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Tool_Enviar.Name = "Tool_Enviar"
        Me.Tool_Enviar.Size = New System.Drawing.Size(107, 22)
        Me.Tool_Enviar.Text = "Enviar por E-Mail"
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
        Me.Tool_Salir.Size = New System.Drawing.Size(47, 22)
        Me.Tool_Salir.Text = "Salir"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'uds_vaca
        '
        Me.uds_vaca.AllowDelete = False
        UltraDataColumn3.DataType = GetType(Date)
        UltraDataColumn5.DataType = GetType(Short)
        UltraDataColumn6.DataType = GetType(Short)
        UltraDataColumn7.DataType = GetType(Short)
        UltraDataColumn8.DataType = GetType(Date)
        UltraDataColumn9.DataType = GetType(Date)
        Me.uds_vaca.Band.Columns.AddRange(New Object() {UltraDataColumn1, UltraDataColumn2, UltraDataColumn3, UltraDataColumn4, UltraDataColumn5, UltraDataColumn6, UltraDataColumn7, UltraDataColumn8, UltraDataColumn9, UltraDataColumn10, UltraDataColumn11})
        '
        'ug_vaca
        '
        Me.ug_vaca.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ug_vaca.DataSource = Me.uds_vaca
        Me.ug_vaca.DisplayLayout.AutoFitStyle = Infragistics.Win.UltraWinGrid.AutoFitStyle.ExtendLastColumn
        UltraGridColumn1.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        Appearance1.ImageHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn1.CellAppearance = Appearance1
        UltraGridColumn1.Header.Caption = "CodPer"
        UltraGridColumn1.Header.VisiblePosition = 0
        UltraGridColumn1.Hidden = True
        UltraGridColumn1.Width = 43
        UltraGridColumn2.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        Appearance3.ImageHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn2.CellAppearance = Appearance3
        UltraGridColumn2.Header.Caption = "Empleado"
        UltraGridColumn2.Header.VisiblePosition = 4
        UltraGridColumn2.Hidden = True
        UltraGridColumn3.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        Appearance4.ImageHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn3.CellAppearance = Appearance4
        UltraGridColumn3.Header.Caption = "Fec Ing."
        UltraGridColumn3.Header.VisiblePosition = 1
        UltraGridColumn3.Hidden = True
        UltraGridColumn3.Width = 79
        UltraGridColumn4.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        Appearance5.ImageHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn4.CellAppearance = Appearance5
        UltraGridColumn4.Header.Caption = "Periodo"
        UltraGridColumn4.Header.VisiblePosition = 2
        UltraGridColumn4.Width = 69
        UltraGridColumn5.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        Appearance7.ImageHAlign = Infragistics.Win.HAlign.Center
        Appearance7.TextHAlignAsString = "Center"
        UltraGridColumn5.CellAppearance = Appearance7
        UltraGridColumn5.Header.Caption = "Gozadas"
        UltraGridColumn5.Header.VisiblePosition = 3
        UltraGridColumn5.Width = 116
        UltraGridColumn6.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        Appearance8.ImageHAlign = Infragistics.Win.HAlign.Center
        Appearance8.TextHAlignAsString = "Center"
        UltraGridColumn6.CellAppearance = Appearance8
        UltraGridColumn6.Header.Caption = "Dias T."
        UltraGridColumn6.Header.VisiblePosition = 5
        UltraGridColumn6.Hidden = True
        UltraGridColumn6.Width = 60
        UltraGridColumn7.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        Appearance10.ImageHAlign = Infragistics.Win.HAlign.Center
        Appearance10.TextHAlignAsString = "Center"
        UltraGridColumn7.CellAppearance = Appearance10
        UltraGridColumn7.Header.Caption = "Saldo Dias"
        UltraGridColumn7.Header.VisiblePosition = 6
        UltraGridColumn7.Width = 77
        UltraGridColumn8.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn8.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        Appearance11.ImageHAlign = Infragistics.Win.HAlign.Center
        Appearance11.TextHAlignAsString = "Center"
        UltraGridColumn8.CellAppearance = Appearance11
        UltraGridColumn8.Header.Caption = "Fec.Ini"
        UltraGridColumn8.Header.VisiblePosition = 7
        UltraGridColumn8.Width = 70
        UltraGridColumn9.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn9.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        Appearance12.ImageHAlign = Infragistics.Win.HAlign.Center
        Appearance12.TextHAlignAsString = "Center"
        UltraGridColumn9.CellAppearance = Appearance12
        UltraGridColumn9.Header.Caption = "Fec.Fin"
        UltraGridColumn9.Header.VisiblePosition = 8
        UltraGridColumn9.Width = 66
        UltraGridColumn10.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn10.Header.VisiblePosition = 9
        UltraGridColumn11.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn11.Header.Caption = "Observ."
        UltraGridColumn11.Header.VisiblePosition = 10
        UltraGridBand1.Columns.AddRange(New Object() {UltraGridColumn1, UltraGridColumn2, UltraGridColumn3, UltraGridColumn4, UltraGridColumn5, UltraGridColumn6, UltraGridColumn7, UltraGridColumn8, UltraGridColumn9, UltraGridColumn10, UltraGridColumn11})
        Appearance13.BackColor = System.Drawing.Color.Beige
        Appearance13.FontData.BoldAsString = "True"
        Appearance13.FontData.SizeInPoints = 10.0!
        Appearance13.ForeColor = System.Drawing.Color.Navy
        Appearance13.TextHAlignAsString = "Right"
        SummarySettings1.Appearance = Appearance13
        SummarySettings1.DisplayFormat = "Dias  : {0}"
        SummarySettings1.GroupBySummaryValueAppearance = Appearance14
        SummarySettings1.Lines = 2
        SummarySettings1.SummaryDisplayArea = Infragistics.Win.UltraWinGrid.SummaryDisplayAreas.BottomFixed
        UltraGridBand1.Summaries.AddRange(New Infragistics.Win.UltraWinGrid.SummarySettings() {SummarySettings1})
        UltraGridBand1.SummaryFooterCaption = ""
        Me.ug_vaca.DisplayLayout.BandsSerializer.Add(UltraGridBand1)
        Me.ug_vaca.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.[False]
        Appearance37.BackColor = System.Drawing.Color.White
        Me.ug_vaca.DisplayLayout.GroupByBox.Appearance = Appearance37
        Me.ug_vaca.DisplayLayout.GroupByBox.Prompt = "Jale una columna aqui"
        Me.ug_vaca.DisplayLayout.GroupByBox.Style = Infragistics.Win.UltraWinGrid.GroupByBoxStyle.Compact
        Me.ug_vaca.DisplayLayout.MaxColScrollRegions = 1
        Me.ug_vaca.DisplayLayout.MaxRowScrollRegions = 1
        Appearance38.BackColor = System.Drawing.Color.White
        Appearance38.FontData.BoldAsString = "True"
        Appearance38.FontData.SizeInPoints = 9.0!
        Appearance38.ForeColor = System.Drawing.Color.Navy
        Me.ug_vaca.DisplayLayout.Override.GroupByRowAppearance = Appearance38
        Me.ug_vaca.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Appearance39.BackColor = System.Drawing.Color.WhiteSmoke
        Appearance39.BackColor2 = System.Drawing.Color.WhiteSmoke
        Me.ug_vaca.DisplayLayout.Override.RowAlternateAppearance = Appearance39
        Me.ug_vaca.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.[False]
        Me.ug_vaca.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.ug_vaca.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy
        Me.ug_vaca.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ug_vaca.Location = New System.Drawing.Point(12, 149)
        Me.ug_vaca.Name = "ug_vaca"
        Me.ug_vaca.Size = New System.Drawing.Size(586, 359)
        Me.ug_vaca.TabIndex = 32
        Me.ug_vaca.Text = "UltraGrid1"
        '
        'udte_fec_corte
        '
        Me.udte_fec_corte.Location = New System.Drawing.Point(44, 7)
        Me.udte_fec_corte.Name = "udte_fec_corte"
        Me.udte_fec_corte.Size = New System.Drawing.Size(93, 21)
        Me.udte_fec_corte.TabIndex = 30
        '
        'UltraLabel1
        '
        Appearance9.BackColor = System.Drawing.Color.Transparent
        Appearance9.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel1.Appearance = Appearance9
        Me.UltraLabel1.AutoSize = True
        Me.UltraLabel1.Location = New System.Drawing.Point(6, 11)
        Me.UltraLabel1.Name = "UltraLabel1"
        Me.UltraLabel1.Size = New System.Drawing.Size(32, 14)
        Me.UltraLabel1.TabIndex = 31
        Me.UltraLabel1.Text = "Corte"
        '
        'uchk_inicio
        '
        Me.uchk_inicio.BackColor = System.Drawing.Color.Transparent
        Me.uchk_inicio.BackColorInternal = System.Drawing.Color.Transparent
        Me.uchk_inicio.Checked = True
        Me.uchk_inicio.CheckState = System.Windows.Forms.CheckState.Checked
        Me.uchk_inicio.Location = New System.Drawing.Point(143, 8)
        Me.uchk_inicio.Name = "uchk_inicio"
        Me.uchk_inicio.Size = New System.Drawing.Size(150, 20)
        Me.uchk_inicio.TabIndex = 35
        Me.uchk_inicio.Text = "Desde Inicio de Sistema"
        '
        'UltraGroupBox1
        '
        Me.UltraGroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.UltraGroupBox1.Controls.Add(Me.uchk_inicio)
        Me.UltraGroupBox1.Controls.Add(Me.UltraLabel1)
        Me.UltraGroupBox1.Controls.Add(Me.udte_fec_corte)
        Me.UltraGroupBox1.Location = New System.Drawing.Point(282, 31)
        Me.UltraGroupBox1.Name = "UltraGroupBox1"
        Me.UltraGroupBox1.Size = New System.Drawing.Size(316, 35)
        Me.UltraGroupBox1.TabIndex = 31
        '
        'utc_1
        '
        Me.utc_1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.utc_1.Controls.Add(Me.UltraTabSharedControlsPage1)
        Me.utc_1.Controls.Add(Me.UltraTabPageControl1)
        Me.utc_1.Controls.Add(Me.UltraTabPageControl2)
        Me.utc_1.Location = New System.Drawing.Point(12, 72)
        Me.utc_1.Name = "utc_1"
        Me.utc_1.SharedControlsPage = Me.UltraTabSharedControlsPage1
        Me.utc_1.Size = New System.Drawing.Size(587, 71)
        Me.utc_1.TabIndex = 33
        UltraTab1.TabPage = Me.UltraTabPageControl1
        UltraTab1.Text = "Por Trabajador"
        UltraTab2.TabPage = Me.UltraTabPageControl2
        UltraTab2.Text = "Por Cargo"
        Me.utc_1.Tabs.AddRange(New Infragistics.Win.UltraWinTabControl.UltraTab() {UltraTab1, UltraTab2})
        '
        'UltraTabSharedControlsPage1
        '
        Me.UltraTabSharedControlsPage1.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabSharedControlsPage1.Name = "UltraTabSharedControlsPage1"
        Me.UltraTabSharedControlsPage1.Size = New System.Drawing.Size(583, 45)
        '
        'uos_filtros
        '
        Me.uos_filtros.BackColor = System.Drawing.Color.Transparent
        Me.uos_filtros.BackColorInternal = System.Drawing.Color.Transparent
        Me.uos_filtros.BorderStyle = Infragistics.Win.UIElementBorderStyle.None
        ValueListItem1.DataValue = "0"
        ValueListItem1.DisplayText = "Todos"
        ValueListItem2.DataValue = "1"
        ValueListItem2.DisplayText = "Por Trabajador"
        ValueListItem3.DataValue = "2"
        ValueListItem3.DisplayText = "Por Cargos"
        Me.uos_filtros.Items.AddRange(New Infragistics.Win.ValueListItem() {ValueListItem1, ValueListItem2, ValueListItem3})
        Me.uos_filtros.Location = New System.Drawing.Point(12, 11)
        Me.uos_filtros.Name = "uos_filtros"
        Me.uos_filtros.Size = New System.Drawing.Size(243, 18)
        Me.uos_filtros.TabIndex = 34
        '
        'UltraGroupBox2
        '
        Me.UltraGroupBox2.Controls.Add(Me.uos_filtros)
        Me.UltraGroupBox2.Location = New System.Drawing.Point(12, 31)
        Me.UltraGroupBox2.Name = "UltraGroupBox2"
        Me.UltraGroupBox2.Size = New System.Drawing.Size(264, 35)
        Me.UltraGroupBox2.TabIndex = 35
        '
        'PL_RP_Movi_Vacaciones
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(610, 520)
        Me.Controls.Add(Me.UltraGroupBox2)
        Me.Controls.Add(Me.utc_1)
        Me.Controls.Add(Me.ug_vaca)
        Me.Controls.Add(Me.UltraGroupBox1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Name = "PL_RP_Movi_Vacaciones"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Movimiento de Vacaciones"
        Me.UltraTabPageControl1.ResumeLayout(False)
        Me.UltraTabPageControl1.PerformLayout()
        CType(Me.txt_nombres, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_idpersonal, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_codper, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabPageControl2.ResumeLayout(False)
        Me.UltraTabPageControl2.PerformLayout()
        CType(Me.uce_CARGO, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        CType(Me.uds_vaca, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ug_vaca, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.udte_fec_corte, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UltraGroupBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraGroupBox1.ResumeLayout(False)
        Me.UltraGroupBox1.PerformLayout()
        CType(Me.utc_1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.utc_1.ResumeLayout(False)
        CType(Me.uos_filtros, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UltraGroupBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraGroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents Tool_imprimir As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents Tool_Salir As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents uds_vaca As Infragistics.Win.UltraWinDataSource.UltraDataSource
    Friend WithEvents ug_vaca As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents Tool_Consultar As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents udte_fec_corte As Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
    Friend WithEvents UltraLabel1 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents txt_nombres As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents txt_codper As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents UltraLabel2 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents txt_idpersonal As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents uchk_inicio As Infragistics.Win.UltraWinEditors.UltraCheckEditor
    Friend WithEvents UltraGroupBox1 As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents Tool_Enviar As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator5 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents utc_1 As Infragistics.Win.UltraWinTabControl.UltraTabControl
    Friend WithEvents UltraTabSharedControlsPage1 As Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage
    Friend WithEvents UltraTabPageControl1 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents UltraTabPageControl2 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents uos_filtros As Infragistics.Win.UltraWinEditors.UltraOptionSet
    Friend WithEvents UltraLabel3 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents uce_CARGO As Infragistics.Win.UltraWinEditors.UltraComboEditor
    Friend WithEvents UltraGroupBox2 As Infragistics.Win.Misc.UltraGroupBox
End Class
