<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PL_RP_RepPagos
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
        Dim Appearance13 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance15 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance2 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraDataColumn1 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("PE_CODIGO")
        Dim UltraDataColumn2 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("NOMBRES")
        Dim UltraDataColumn3 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("REMU")
        Dim UltraDataColumn4 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("DSCTO")
        Dim UltraDataColumn5 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("APORTE")
        Dim UltraDataColumn6 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("TOTAL")
        Dim UltraGridBand1 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1)
        Dim UltraGridColumn1 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("PE_CODIGO")
        Dim UltraGridColumn2 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NOMBRES")
        Dim UltraGridColumn3 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("REMU")
        Dim Appearance3 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn4 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("DSCTO")
        Dim Appearance4 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn5 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("APORTE")
        Dim Appearance5 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn6 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TOTAL")
        Dim Appearance6 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim SummarySettings1 As Infragistics.Win.UltraWinGrid.SummarySettings = New Infragistics.Win.UltraWinGrid.SummarySettings("", Infragistics.Win.UltraWinGrid.SummaryType.Sum, Nothing, "REMU", 2, True, "Band 0", 0, Infragistics.Win.UltraWinGrid.SummaryPosition.UseSummaryPositionColumn, "REMU", 2, True)
        Dim Appearance7 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance8 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim SummarySettings2 As Infragistics.Win.UltraWinGrid.SummarySettings = New Infragistics.Win.UltraWinGrid.SummarySettings("", Infragistics.Win.UltraWinGrid.SummaryType.Sum, Nothing, "DSCTO", 3, True, "Band 0", 0, Infragistics.Win.UltraWinGrid.SummaryPosition.UseSummaryPositionColumn, "DSCTO", 3, True)
        Dim Appearance9 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance10 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim SummarySettings3 As Infragistics.Win.UltraWinGrid.SummarySettings = New Infragistics.Win.UltraWinGrid.SummarySettings("", Infragistics.Win.UltraWinGrid.SummaryType.Sum, Nothing, "APORTE", 4, True, "Band 0", 0, Infragistics.Win.UltraWinGrid.SummaryPosition.UseSummaryPositionColumn, "APORTE", 4, True)
        Dim Appearance11 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance12 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim SummarySettings4 As Infragistics.Win.UltraWinGrid.SummarySettings = New Infragistics.Win.UltraWinGrid.SummarySettings("", Infragistics.Win.UltraWinGrid.SummaryType.Sum, Nothing, "TOTAL", 5, True, "Band 0", 0, Infragistics.Win.UltraWinGrid.SummaryPosition.UseSummaryPositionColumn, "TOTAL", 5, True)
        Dim Appearance14 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance16 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim SummarySettings5 As Infragistics.Win.UltraWinGrid.SummarySettings = New Infragistics.Win.UltraWinGrid.SummarySettings("", Infragistics.Win.UltraWinGrid.SummaryType.Count, Nothing, "PE_CODIGO", 0, True, "Band 0", 0, Infragistics.Win.UltraWinGrid.SummaryPosition.Left, "PE_CODIGO", 0, True)
        Dim Appearance17 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance18 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance1 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Me.UltraGroupBox1 = New Infragistics.Win.Misc.UltraGroupBox()
        Me.uce_TipoPersonal = New Infragistics.Win.UltraWinEditors.UltraComboEditor()
        Me.UltraLabel2 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraLabel3 = New Infragistics.Win.Misc.UltraLabel()
        Me.uce_Mes = New Infragistics.Win.UltraWinEditors.UltraComboEditor()
        Me.une_ayo = New Infragistics.Win.UltraWinEditors.UltraNumericEditor()
        Me.UltraLabel1 = New Infragistics.Win.Misc.UltraLabel()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.Tool_imprimir = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.Tool_Salir = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.uds_Pagos = New Infragistics.Win.UltraWinDataSource.UltraDataSource(Me.components)
        Me.ug_reporte = New Infragistics.Win.UltraWinGrid.UltraGrid()
        CType(Me.UltraGroupBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraGroupBox1.SuspendLayout()
        CType(Me.uce_TipoPersonal, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.uce_Mes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.une_ayo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip1.SuspendLayout()
        CType(Me.uds_Pagos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ug_reporte, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        Me.UltraGroupBox1.Size = New System.Drawing.Size(613, 46)
        Me.UltraGroupBox1.TabIndex = 19
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
        Appearance13.BackColor = System.Drawing.Color.Transparent
        Appearance13.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel2.Appearance = Appearance13
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
        'ToolStrip1
        '
        Me.ToolStrip1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripSeparator4, Me.Tool_imprimir, Me.ToolStripSeparator2, Me.Tool_Salir, Me.ToolStripSeparator1})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(637, 25)
        Me.ToolStrip1.TabIndex = 20
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
        Me.Tool_imprimir.Size = New System.Drawing.Size(65, 22)
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
        Me.Tool_Salir.Size = New System.Drawing.Size(47, 22)
        Me.Tool_Salir.Text = "Salir"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'uds_Pagos
        '
        Me.uds_Pagos.AllowDelete = False
        UltraDataColumn3.DataType = GetType(Double)
        UltraDataColumn4.DataType = GetType(Double)
        UltraDataColumn5.DataType = GetType(Double)
        UltraDataColumn6.DataType = GetType(Double)
        Me.uds_Pagos.Band.Columns.AddRange(New Object() {UltraDataColumn1, UltraDataColumn2, UltraDataColumn3, UltraDataColumn4, UltraDataColumn5, UltraDataColumn6})
        '
        'ug_reporte
        '
        Me.ug_reporte.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ug_reporte.DataSource = Me.uds_Pagos
        Me.ug_reporte.DisplayLayout.AutoFitStyle = Infragistics.Win.UltraWinGrid.AutoFitStyle.ExtendLastColumn
        UltraGridColumn1.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn1.Header.Caption = "Codigo"
        UltraGridColumn1.Header.VisiblePosition = 0
        UltraGridColumn1.Width = 57
        UltraGridColumn2.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn2.Header.Caption = "Nombres"
        UltraGridColumn2.Header.VisiblePosition = 1
        UltraGridColumn2.Width = 196
        UltraGridColumn3.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        Appearance3.TextHAlignAsString = "Right"
        UltraGridColumn3.CellAppearance = Appearance3
        UltraGridColumn3.Header.Caption = "T. Remun."
        UltraGridColumn3.Header.VisiblePosition = 2
        UltraGridColumn3.MaskDisplayMode = Infragistics.Win.UltraWinMaskedEdit.MaskMode.IncludeLiterals
        UltraGridColumn3.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Double]
        UltraGridColumn3.Width = 101
        UltraGridColumn4.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        Appearance4.TextHAlignAsString = "Right"
        UltraGridColumn4.CellAppearance = Appearance4
        UltraGridColumn4.Header.Caption = "T. Dsctos"
        UltraGridColumn4.Header.VisiblePosition = 3
        UltraGridColumn4.MaskDisplayMode = Infragistics.Win.UltraWinMaskedEdit.MaskMode.IncludeLiterals
        UltraGridColumn4.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Double]
        UltraGridColumn4.Width = 84
        UltraGridColumn5.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        Appearance5.TextHAlignAsString = "Right"
        UltraGridColumn5.CellAppearance = Appearance5
        UltraGridColumn5.Header.Caption = "T. Aporte"
        UltraGridColumn5.Header.VisiblePosition = 4
        UltraGridColumn5.MaskDisplayMode = Infragistics.Win.UltraWinMaskedEdit.MaskMode.IncludeLiterals
        UltraGridColumn5.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Double]
        UltraGridColumn5.Width = 73
        UltraGridColumn6.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        Appearance6.TextHAlignAsString = "Right"
        UltraGridColumn6.CellAppearance = Appearance6
        UltraGridColumn6.Header.Caption = "Total"
        UltraGridColumn6.Header.VisiblePosition = 5
        UltraGridColumn6.MaskDisplayMode = Infragistics.Win.UltraWinMaskedEdit.MaskMode.IncludeLiterals
        UltraGridColumn6.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Double]
        UltraGridColumn6.Width = 61
        UltraGridBand1.Columns.AddRange(New Object() {UltraGridColumn1, UltraGridColumn2, UltraGridColumn3, UltraGridColumn4, UltraGridColumn5, UltraGridColumn6})
        Appearance7.BackColor = System.Drawing.Color.White
        Appearance7.FontData.BoldAsString = "True"
        Appearance7.FontData.SizeInPoints = 9.0!
        Appearance7.ForeColor = System.Drawing.Color.Navy
        Appearance7.TextHAlignAsString = "Right"
        SummarySettings1.Appearance = Appearance7
        SummarySettings1.DisplayFormat = "{0:##,##0.00#}"
        SummarySettings1.GroupBySummaryValueAppearance = Appearance8
        SummarySettings1.SummaryDisplayArea = Infragistics.Win.UltraWinGrid.SummaryDisplayAreas.BottomFixed
        Appearance9.BackColor = System.Drawing.Color.White
        Appearance9.FontData.BoldAsString = "True"
        Appearance9.FontData.SizeInPoints = 9.0!
        Appearance9.ForeColor = System.Drawing.Color.Navy
        Appearance9.TextHAlignAsString = "Right"
        SummarySettings2.Appearance = Appearance9
        SummarySettings2.DisplayFormat = "{0:##,##0.00#}"
        SummarySettings2.GroupBySummaryValueAppearance = Appearance10
        SummarySettings2.SummaryDisplayArea = Infragistics.Win.UltraWinGrid.SummaryDisplayAreas.BottomFixed
        Appearance11.BackColor = System.Drawing.Color.White
        Appearance11.FontData.BoldAsString = "True"
        Appearance11.FontData.SizeInPoints = 9.0!
        Appearance11.ForeColor = System.Drawing.Color.Navy
        Appearance11.TextHAlignAsString = "Right"
        SummarySettings3.Appearance = Appearance11
        SummarySettings3.DisplayFormat = "{0:##,##0.00#}"
        SummarySettings3.GroupBySummaryValueAppearance = Appearance12
        SummarySettings3.SummaryDisplayArea = Infragistics.Win.UltraWinGrid.SummaryDisplayAreas.BottomFixed
        Appearance14.BackColor = System.Drawing.Color.White
        Appearance14.FontData.BoldAsString = "True"
        Appearance14.FontData.SizeInPoints = 9.0!
        Appearance14.ForeColor = System.Drawing.Color.Navy
        Appearance14.TextHAlignAsString = "Right"
        SummarySettings4.Appearance = Appearance14
        SummarySettings4.DisplayFormat = "{0:##,##0.00#}"
        SummarySettings4.GroupBySummaryValueAppearance = Appearance16
        SummarySettings4.SummaryDisplayArea = Infragistics.Win.UltraWinGrid.SummaryDisplayAreas.BottomFixed
        Appearance17.BackColor = System.Drawing.Color.Yellow
        Appearance17.FontData.BoldAsString = "True"
        Appearance17.FontData.SizeInPoints = 9.0!
        Appearance17.ForeColor = System.Drawing.Color.Navy
        SummarySettings5.Appearance = Appearance17
        SummarySettings5.DisplayFormat = "Num. Filas : {0}"
        SummarySettings5.GroupBySummaryValueAppearance = Appearance18
        SummarySettings5.SummaryDisplayArea = Infragistics.Win.UltraWinGrid.SummaryDisplayAreas.BottomFixed
        UltraGridBand1.Summaries.AddRange(New Infragistics.Win.UltraWinGrid.SummarySettings() {SummarySettings1, SummarySettings2, SummarySettings3, SummarySettings4, SummarySettings5})
        UltraGridBand1.SummaryFooterCaption = ""
        Me.ug_reporte.DisplayLayout.BandsSerializer.Add(UltraGridBand1)
        Me.ug_reporte.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.[False]
        Me.ug_reporte.DisplayLayout.MaxRowScrollRegions = 1
        Appearance1.BackColor = System.Drawing.Color.WhiteSmoke
        Appearance1.BackColor2 = System.Drawing.Color.WhiteSmoke
        Me.ug_reporte.DisplayLayout.Override.RowAlternateAppearance = Appearance1
        Me.ug_reporte.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.ug_reporte.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ug_reporte.Location = New System.Drawing.Point(12, 80)
        Me.ug_reporte.Name = "ug_reporte"
        Me.ug_reporte.Size = New System.Drawing.Size(613, 391)
        Me.ug_reporte.TabIndex = 21
        Me.ug_reporte.Text = "UltraGrid1"
        '
        'PL_RP_RepPagos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(637, 483)
        Me.Controls.Add(Me.ug_reporte)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.UltraGroupBox1)
        Me.Name = "PL_RP_RepPagos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Reporte de Pagos"
        CType(Me.UltraGroupBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraGroupBox1.ResumeLayout(False)
        Me.UltraGroupBox1.PerformLayout()
        CType(Me.uce_TipoPersonal, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.uce_Mes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.une_ayo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        CType(Me.uds_Pagos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ug_reporte, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents UltraGroupBox1 As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents uce_TipoPersonal As Infragistics.Win.UltraWinEditors.UltraComboEditor
    Friend WithEvents UltraLabel2 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel3 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents uce_Mes As Infragistics.Win.UltraWinEditors.UltraComboEditor
    Friend WithEvents une_ayo As Infragistics.Win.UltraWinEditors.UltraNumericEditor
    Friend WithEvents UltraLabel1 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents Tool_imprimir As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents Tool_Salir As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents uds_Pagos As Infragistics.Win.UltraWinDataSource.UltraDataSource
    Friend WithEvents ug_reporte As Infragistics.Win.UltraWinGrid.UltraGrid
End Class
