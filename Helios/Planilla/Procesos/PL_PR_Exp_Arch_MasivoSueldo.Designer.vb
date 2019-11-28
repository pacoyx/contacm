<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PL_PR_Exp_Arch_MasivoSueldo
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
        Dim ValueListItem5 As Infragistics.Win.ValueListItem = New Infragistics.Win.ValueListItem()
        Dim ValueListItem1 As Infragistics.Win.ValueListItem = New Infragistics.Win.ValueListItem()
        Dim Appearance1 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance3 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraDataColumn1 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("PE_CODIGO")
        Dim UltraDataColumn2 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("PE_APE_PAT")
        Dim UltraDataColumn3 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("PE_APE_MAT")
        Dim UltraDataColumn4 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("NOM_PER")
        Dim UltraDataColumn5 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IMPORTE")
        Dim UltraDataColumn6 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("CTA_CTE")
        Dim UltraDataColumn7 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("DOC_PER")
        Dim UltraDataColumn8 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("PE_COD_INTERBANCA")
        Dim UltraGridBand1 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1)
        Dim UltraGridColumn1 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("PE_CODIGO")
        Dim UltraGridColumn2 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("PE_APE_PAT", -1, Nothing, 0, Infragistics.Win.UltraWinGrid.SortIndicator.Ascending, False)
        Dim UltraGridColumn3 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("PE_APE_MAT")
        Dim UltraGridColumn4 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NOM_PER")
        Dim UltraGridColumn5 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IMPORTE")
        Dim Appearance2 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn6 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CTA_CTE")
        Dim Appearance4 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn7 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("DOC_PER")
        Dim UltraGridColumn8 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("PE_COD_INTERBANCA")
        Dim SummarySettings1 As Infragistics.Win.UltraWinGrid.SummarySettings = New Infragistics.Win.UltraWinGrid.SummarySettings("", Infragistics.Win.UltraWinGrid.SummaryType.Sum, Nothing, "IMPORTE", 4, True, "Band 0", 0, Infragistics.Win.UltraWinGrid.SummaryPosition.UseSummaryPositionColumn, "IMPORTE", 4, True)
        Dim Appearance5 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance6 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim SummarySettings2 As Infragistics.Win.UltraWinGrid.SummarySettings = New Infragistics.Win.UltraWinGrid.SummarySettings("", Infragistics.Win.UltraWinGrid.SummaryType.Count, Nothing, "PE_CODIGO", 0, True, "Band 0", 0, Infragistics.Win.UltraWinGrid.SummaryPosition.UseSummaryPositionColumn, "PE_CODIGO", 0, True)
        Dim Appearance7 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance13 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Me.ugb_Parametros = New Infragistics.Win.Misc.UltraGroupBox()
        Me.uos_periodo = New Infragistics.Win.UltraWinEditors.UltraOptionSet()
        Me.une_Ayo = New Infragistics.Win.UltraWinEditors.UltraNumericEditor()
        Me.UltraLabel1 = New Infragistics.Win.Misc.UltraLabel()
        Me.uce_Mes = New Infragistics.Win.UltraWinEditors.UltraComboEditor()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.Tool_Procesar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.Tool_Generar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator()
        Me.Tool_GenerarConExcel = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator6 = New System.Windows.Forms.ToolStripSeparator()
        Me.Tool_Abrir = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator7 = New System.Windows.Forms.ToolStripSeparator()
        Me.Tool_Salir = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.uds_datos = New Infragistics.Win.UltraWinDataSource.UltraDataSource(Me.components)
        Me.ug_datos = New Infragistics.Win.UltraWinGrid.UltraGrid()
        Me.txt_cod_folio = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        CType(Me.ugb_Parametros, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ugb_Parametros.SuspendLayout()
        CType(Me.uos_periodo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.une_Ayo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.uce_Mes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip1.SuspendLayout()
        CType(Me.uds_datos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ug_datos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_cod_folio, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ugb_Parametros
        '
        Me.ugb_Parametros.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ugb_Parametros.Controls.Add(Me.txt_cod_folio)
        Me.ugb_Parametros.Controls.Add(Me.uos_periodo)
        Me.ugb_Parametros.Controls.Add(Me.une_Ayo)
        Me.ugb_Parametros.Controls.Add(Me.UltraLabel1)
        Me.ugb_Parametros.Controls.Add(Me.uce_Mes)
        Me.ugb_Parametros.Location = New System.Drawing.Point(12, 34)
        Me.ugb_Parametros.Name = "ugb_Parametros"
        Me.ugb_Parametros.Size = New System.Drawing.Size(677, 36)
        Me.ugb_Parametros.TabIndex = 12
        '
        'uos_periodo
        '
        Me.uos_periodo.BackColor = System.Drawing.Color.Transparent
        Me.uos_periodo.BackColorInternal = System.Drawing.Color.Transparent
        Me.uos_periodo.BorderStyle = Infragistics.Win.UIElementBorderStyle.None
        Me.uos_periodo.CheckedIndex = 0
        ValueListItem2.DataValue = CType(1, Short)
        ValueListItem2.DisplayText = "Quincena"
        ValueListItem3.DataValue = CType(2, Short)
        ValueListItem3.DisplayText = "Fin de Mes"
        ValueListItem5.DataValue = CType(3, Short)
        ValueListItem5.DisplayText = "Gratificacion"
        ValueListItem1.DataValue = CType(4, Short)
        ValueListItem1.DisplayText = "Otros"
        Me.uos_periodo.Items.AddRange(New Infragistics.Win.ValueListItem() {ValueListItem2, ValueListItem3, ValueListItem5, ValueListItem1})
        Me.uos_periodo.ItemSpacingHorizontal = 2
        Me.uos_periodo.Location = New System.Drawing.Point(324, 11)
        Me.uos_periodo.Name = "uos_periodo"
        Me.uos_periodo.Size = New System.Drawing.Size(291, 19)
        Me.uos_periodo.TabIndex = 14
        Me.uos_periodo.Text = "Quincena"
        '
        'une_Ayo
        '
        Appearance1.TextHAlignAsString = "Center"
        Me.une_Ayo.Appearance = Appearance1
        Me.une_Ayo.Location = New System.Drawing.Point(59, 9)
        Me.une_Ayo.MaskInput = "nnnn"
        Me.une_Ayo.Name = "une_Ayo"
        Me.une_Ayo.ReadOnly = True
        Me.une_Ayo.Size = New System.Drawing.Size(35, 21)
        Me.une_Ayo.TabIndex = 13
        '
        'UltraLabel1
        '
        Appearance3.BackColor = System.Drawing.Color.Transparent
        Appearance3.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel1.Appearance = Appearance3
        Me.UltraLabel1.AutoSize = True
        Me.UltraLabel1.Location = New System.Drawing.Point(15, 13)
        Me.UltraLabel1.Name = "UltraLabel1"
        Me.UltraLabel1.Size = New System.Drawing.Size(43, 14)
        Me.UltraLabel1.TabIndex = 12
        Me.UltraLabel1.Text = "Periodo"
        '
        'uce_Mes
        '
        Me.uce_Mes.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.uce_Mes.Location = New System.Drawing.Point(95, 9)
        Me.uce_Mes.Name = "uce_Mes"
        Me.uce_Mes.Size = New System.Drawing.Size(110, 21)
        Me.uce_Mes.TabIndex = 0
        '
        'ToolStrip1
        '
        Me.ToolStrip1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Tool_Procesar, Me.ToolStripSeparator1, Me.Tool_Generar, Me.ToolStripSeparator5, Me.Tool_GenerarConExcel, Me.ToolStripSeparator6, Me.Tool_Abrir, Me.ToolStripSeparator7, Me.Tool_Salir, Me.ToolStripSeparator4})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(701, 25)
        Me.ToolStrip1.TabIndex = 18
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'Tool_Procesar
        '
        Me.Tool_Procesar.Image = Global.Contabilidad.My.Resources.Resources._16__Configure_
        Me.Tool_Procesar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Tool_Procesar.Name = "Tool_Procesar"
        Me.Tool_Procesar.Size = New System.Drawing.Size(78, 22)
        Me.Tool_Procesar.Text = "Consultar"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'Tool_Generar
        '
        Me.Tool_Generar.Image = Global.Contabilidad.My.Resources.Resources._16__Build_
        Me.Tool_Generar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Tool_Generar.Name = "Tool_Generar"
        Me.Tool_Generar.Size = New System.Drawing.Size(92, 22)
        Me.Tool_Generar.Text = "Generar TXT"
        '
        'ToolStripSeparator5
        '
        Me.ToolStripSeparator5.Name = "ToolStripSeparator5"
        Me.ToolStripSeparator5.Size = New System.Drawing.Size(6, 25)
        '
        'Tool_GenerarConExcel
        '
        Me.Tool_GenerarConExcel.Image = Global.Contabilidad.My.Resources.Resources.Access_039
        Me.Tool_GenerarConExcel.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Tool_GenerarConExcel.Name = "Tool_GenerarConExcel"
        Me.Tool_GenerarConExcel.Size = New System.Drawing.Size(120, 22)
        Me.Tool_GenerarConExcel.Text = "Generar con Excel"
        '
        'ToolStripSeparator6
        '
        Me.ToolStripSeparator6.Name = "ToolStripSeparator6"
        Me.ToolStripSeparator6.Size = New System.Drawing.Size(6, 25)
        '
        'Tool_Abrir
        '
        Me.Tool_Abrir.Image = Global.Contabilidad.My.Resources.Resources._16__Open_
        Me.Tool_Abrir.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Tool_Abrir.Name = "Tool_Abrir"
        Me.Tool_Abrir.Size = New System.Drawing.Size(53, 22)
        Me.Tool_Abrir.Text = "Abrir"
        '
        'ToolStripSeparator7
        '
        Me.ToolStripSeparator7.Name = "ToolStripSeparator7"
        Me.ToolStripSeparator7.Size = New System.Drawing.Size(6, 25)
        '
        'Tool_Salir
        '
        Me.Tool_Salir.Image = Global.Contabilidad.My.Resources.Resources._28
        Me.Tool_Salir.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Tool_Salir.Name = "Tool_Salir"
        Me.Tool_Salir.Size = New System.Drawing.Size(49, 22)
        Me.Tool_Salir.Text = "Salir"
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(6, 25)
        '
        'uds_datos
        '
        Me.uds_datos.AllowDelete = False
        UltraDataColumn4.ReadOnly = Infragistics.Win.DefaultableBoolean.[False]
        UltraDataColumn5.DataType = GetType(Double)
        Me.uds_datos.Band.Columns.AddRange(New Object() {UltraDataColumn1, UltraDataColumn2, UltraDataColumn3, UltraDataColumn4, UltraDataColumn5, UltraDataColumn6, UltraDataColumn7, UltraDataColumn8})
        '
        'ug_datos
        '
        Me.ug_datos.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ug_datos.DataSource = Me.uds_datos
        Me.ug_datos.DisplayLayout.AutoFitStyle = Infragistics.Win.UltraWinGrid.AutoFitStyle.ExtendLastColumn
        UltraGridColumn1.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn1.Header.Caption = "Codigo"
        UltraGridColumn1.Header.VisiblePosition = 0
        UltraGridColumn1.Width = 50
        UltraGridColumn2.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn2.Header.Caption = "Paterno"
        UltraGridColumn2.Header.VisiblePosition = 2
        UltraGridColumn2.Width = 87
        UltraGridColumn3.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn3.Header.Caption = "Materno"
        UltraGridColumn3.Header.VisiblePosition = 3
        UltraGridColumn3.Width = 93
        UltraGridColumn4.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn4.Header.Caption = "Nombres"
        UltraGridColumn4.Header.VisiblePosition = 4
        UltraGridColumn4.Width = 120
        UltraGridColumn5.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        Appearance2.TextHAlignAsString = "Right"
        UltraGridColumn5.CellAppearance = Appearance2
        UltraGridColumn5.Header.Caption = "Importe"
        UltraGridColumn5.Header.VisiblePosition = 5
        UltraGridColumn5.MaskDisplayMode = Infragistics.Win.UltraWinMaskedEdit.MaskMode.IncludeLiterals
        UltraGridColumn5.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Double]
        UltraGridColumn5.Width = 100
        UltraGridColumn6.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        Appearance4.TextHAlignAsString = "Center"
        UltraGridColumn6.CellAppearance = Appearance4
        UltraGridColumn6.Header.Caption = "N. Cuenta Banco"
        UltraGridColumn6.Header.VisiblePosition = 6
        UltraGridColumn7.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn7.Header.Caption = "DNI"
        UltraGridColumn7.Header.VisiblePosition = 1
        UltraGridColumn7.Width = 83
        UltraGridColumn8.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn8.Header.VisiblePosition = 7
        UltraGridColumn8.Hidden = True
        UltraGridBand1.Columns.AddRange(New Object() {UltraGridColumn1, UltraGridColumn2, UltraGridColumn3, UltraGridColumn4, UltraGridColumn5, UltraGridColumn6, UltraGridColumn7, UltraGridColumn8})
        Appearance5.BackColor = System.Drawing.Color.White
        Appearance5.FontData.BoldAsString = "True"
        Appearance5.FontData.SizeInPoints = 10.0!
        Appearance5.ForeColor = System.Drawing.Color.Navy
        Appearance5.TextHAlignAsString = "Right"
        SummarySettings1.Appearance = Appearance5
        SummarySettings1.DisplayFormat = "{0:##,##0.00#}"
        SummarySettings1.GroupBySummaryValueAppearance = Appearance6
        SummarySettings1.SummaryDisplayArea = Infragistics.Win.UltraWinGrid.SummaryDisplayAreas.BottomFixed
        SummarySettings2.DisplayFormat = "Filas : {0} "
        SummarySettings2.GroupBySummaryValueAppearance = Appearance7
        SummarySettings2.SummaryDisplayArea = Infragistics.Win.UltraWinGrid.SummaryDisplayAreas.BottomFixed
        UltraGridBand1.Summaries.AddRange(New Infragistics.Win.UltraWinGrid.SummarySettings() {SummarySettings1, SummarySettings2})
        UltraGridBand1.SummaryFooterCaption = ""
        Me.ug_datos.DisplayLayout.BandsSerializer.Add(UltraGridBand1)
        Me.ug_datos.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.[False]
        Me.ug_datos.DisplayLayout.MaxColScrollRegions = 1
        Me.ug_datos.DisplayLayout.MaxRowScrollRegions = 1
        Me.ug_datos.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Appearance13.BackColor = System.Drawing.Color.WhiteSmoke
        Appearance13.BackColor2 = System.Drawing.Color.WhiteSmoke
        Me.ug_datos.DisplayLayout.Override.RowAlternateAppearance = Appearance13
        Me.ug_datos.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.ug_datos.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ug_datos.Location = New System.Drawing.Point(12, 76)
        Me.ug_datos.Name = "ug_datos"
        Me.ug_datos.Size = New System.Drawing.Size(677, 331)
        Me.ug_datos.TabIndex = 19
        Me.ug_datos.Text = "UltraGrid1"
        '
        'txt_cod_folio
        '
        Me.txt_cod_folio.Location = New System.Drawing.Point(621, 9)
        Me.txt_cod_folio.Name = "txt_cod_folio"
        Me.txt_cod_folio.Size = New System.Drawing.Size(48, 21)
        Me.txt_cod_folio.TabIndex = 15
        '
        'PL_PR_Exp_Arch_MasivoSueldo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(701, 419)
        Me.Controls.Add(Me.ug_datos)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.ugb_Parametros)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "PL_PR_Exp_Arch_MasivoSueldo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Generar Archivo  Planilla de Sueldo - Scotiabank"
        CType(Me.ugb_Parametros, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ugb_Parametros.ResumeLayout(False)
        Me.ugb_Parametros.PerformLayout()
        CType(Me.uos_periodo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.une_Ayo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.uce_Mes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        CType(Me.uds_datos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ug_datos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_cod_folio, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ugb_Parametros As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents une_Ayo As Infragistics.Win.UltraWinEditors.UltraNumericEditor
    Friend WithEvents UltraLabel1 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents uce_Mes As Infragistics.Win.UltraWinEditors.UltraComboEditor
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents Tool_Procesar As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents Tool_Abrir As System.Windows.Forms.ToolStripButton
    Friend WithEvents Tool_Salir As System.Windows.Forms.ToolStripButton
    Friend WithEvents uds_datos As Infragistics.Win.UltraWinDataSource.UltraDataSource
    Friend WithEvents ug_datos As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents uos_periodo As Infragistics.Win.UltraWinEditors.UltraOptionSet
    Friend WithEvents Tool_Generar As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator5 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents Tool_GenerarConExcel As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator6 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator7 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents txt_cod_folio As Infragistics.Win.UltraWinEditors.UltraTextEditor
End Class
