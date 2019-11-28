<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PL_PR_Provisiones
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
        Dim UltraGridBand1 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1)
        Dim UltraGridColumn1 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Item")
        Dim UltraGridColumn2 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CC")
        Dim UltraGridColumn3 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Cuenta")
        Dim UltraGridColumn4 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Descripcion")
        Dim UltraGridColumn5 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Debe")
        Dim Appearance2 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn6 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Haber")
        Dim Appearance3 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn7 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("EsDestino")
        Dim SummarySettings1 As Infragistics.Win.UltraWinGrid.SummarySettings = New Infragistics.Win.UltraWinGrid.SummarySettings("", Infragistics.Win.UltraWinGrid.SummaryType.Sum, Nothing, "Debe", 4, True, "Band 0", 0, Infragistics.Win.UltraWinGrid.SummaryPosition.UseSummaryPositionColumn, "Debe", 4, True)
        Dim Appearance5 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance6 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim SummarySettings2 As Infragistics.Win.UltraWinGrid.SummarySettings = New Infragistics.Win.UltraWinGrid.SummarySettings("", Infragistics.Win.UltraWinGrid.SummaryType.Sum, Nothing, "Haber", 5, True, "Band 0", 0, Infragistics.Win.UltraWinGrid.SummaryPosition.UseSummaryPositionColumn, "Haber", 5, True)
        Dim Appearance7 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance8 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraDataColumn1 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Item")
        Dim UltraDataColumn2 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("CC")
        Dim UltraDataColumn3 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Cuenta")
        Dim UltraDataColumn4 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Descripcion")
        Dim UltraDataColumn5 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Debe")
        Dim UltraDataColumn6 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Haber")
        Dim UltraDataColumn7 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("EsDestino")
        Dim ValueListItem2 As Infragistics.Win.ValueListItem = New Infragistics.Win.ValueListItem()
        Dim ValueListItem3 As Infragistics.Win.ValueListItem = New Infragistics.Win.ValueListItem()
        Dim Appearance1 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance4 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance12 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance9 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance10 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Me.ug_Asiento = New Infragistics.Win.UltraWinGrid.UltraGrid()
        Me.uds_Asiento = New Infragistics.Win.UltraWinDataSource.UltraDataSource(Me.components)
        Me.ugb_Parametros = New Infragistics.Win.Misc.UltraGroupBox()
        Me.uos_tipo = New Infragistics.Win.UltraWinEditors.UltraOptionSet()
        Me.une_Ayo = New Infragistics.Win.UltraWinEditors.UltraNumericEditor()
        Me.UltraLabel7 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraLabel8 = New Infragistics.Win.Misc.UltraLabel()
        Me.uce_Mes = New Infragistics.Win.UltraWinEditors.UltraComboEditor()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.Tool_Procesar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.Tool_Generar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.Tool_Salir = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator()
        Me.UltraGroupBox3 = New Infragistics.Win.Misc.UltraGroupBox()
        Me.uce_SubDiario = New Infragistics.Win.UltraWinEditors.UltraComboEditor()
        Me.udte_fec_Vou = New Infragistics.Win.UltraWinEditors.UltraDateTimeEditor()
        Me.UltraLabel3 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraLabel6 = New Infragistics.Win.Misc.UltraLabel()
        CType(Me.ug_Asiento, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.uds_Asiento, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ugb_Parametros, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ugb_Parametros.SuspendLayout()
        CType(Me.uos_tipo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.une_Ayo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.uce_Mes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip1.SuspendLayout()
        CType(Me.UltraGroupBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraGroupBox3.SuspendLayout()
        CType(Me.uce_SubDiario, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.udte_fec_Vou, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ug_Asiento
        '
        Me.ug_Asiento.DataSource = Me.uds_Asiento
        Me.ug_Asiento.DisplayLayout.AutoFitStyle = Infragistics.Win.UltraWinGrid.AutoFitStyle.ExtendLastColumn
        UltraGridColumn1.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn1.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn1.Header.VisiblePosition = 0
        UltraGridColumn1.Width = 31
        UltraGridColumn2.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn2.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn2.Header.VisiblePosition = 1
        UltraGridColumn2.Width = 30
        UltraGridColumn3.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn3.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn3.Header.VisiblePosition = 2
        UltraGridColumn3.Width = 58
        UltraGridColumn4.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn4.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn4.Header.VisiblePosition = 3
        UltraGridColumn4.Width = 272
        UltraGridColumn5.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn5.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        Appearance2.TextHAlignAsString = "Right"
        UltraGridColumn5.CellAppearance = Appearance2
        UltraGridColumn5.Header.VisiblePosition = 4
        UltraGridColumn5.MaskDisplayMode = Infragistics.Win.UltraWinMaskedEdit.MaskMode.IncludeLiterals
        UltraGridColumn5.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Double]
        UltraGridColumn5.Width = 108
        UltraGridColumn6.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn6.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        Appearance3.TextHAlignAsString = "Right"
        UltraGridColumn6.CellAppearance = Appearance3
        UltraGridColumn6.Header.VisiblePosition = 5
        UltraGridColumn6.MaskDisplayMode = Infragistics.Win.UltraWinMaskedEdit.MaskMode.IncludeLiterals
        UltraGridColumn6.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Double]
        UltraGridColumn7.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn7.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn7.Header.VisiblePosition = 6
        UltraGridColumn7.Hidden = True
        UltraGridColumn7.Width = 38
        UltraGridBand1.Columns.AddRange(New Object() {UltraGridColumn1, UltraGridColumn2, UltraGridColumn3, UltraGridColumn4, UltraGridColumn5, UltraGridColumn6, UltraGridColumn7})
        Appearance5.BackColor = System.Drawing.Color.White
        Appearance5.FontData.SizeInPoints = 10.0!
        Appearance5.ForeColor = System.Drawing.Color.Navy
        Appearance5.TextHAlignAsString = "Right"
        SummarySettings1.Appearance = Appearance5
        SummarySettings1.DisplayFormat = "{0:##,##0.00#}"
        SummarySettings1.GroupBySummaryValueAppearance = Appearance6
        SummarySettings1.SummaryDisplayArea = Infragistics.Win.UltraWinGrid.SummaryDisplayAreas.BottomFixed
        Appearance7.BackColor = System.Drawing.Color.White
        Appearance7.FontData.SizeInPoints = 10.0!
        Appearance7.ForeColor = System.Drawing.Color.Navy
        Appearance7.TextHAlignAsString = "Right"
        SummarySettings2.Appearance = Appearance7
        SummarySettings2.DisplayFormat = "{0:##,##0.00#}"
        SummarySettings2.GroupBySummaryValueAppearance = Appearance8
        SummarySettings2.SummaryDisplayArea = Infragistics.Win.UltraWinGrid.SummaryDisplayAreas.BottomFixed
        UltraGridBand1.Summaries.AddRange(New Infragistics.Win.UltraWinGrid.SummarySettings() {SummarySettings1, SummarySettings2})
        UltraGridBand1.SummaryFooterCaption = "Totales"
        Me.ug_Asiento.DisplayLayout.BandsSerializer.Add(UltraGridBand1)
        Me.ug_Asiento.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.[False]
        Me.ug_Asiento.DisplayLayout.MaxColScrollRegions = 1
        Me.ug_Asiento.DisplayLayout.MaxRowScrollRegions = 1
        Me.ug_Asiento.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.ug_Asiento.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.ug_Asiento.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ug_Asiento.Location = New System.Drawing.Point(12, 126)
        Me.ug_Asiento.Name = "ug_Asiento"
        Me.ug_Asiento.Size = New System.Drawing.Size(634, 308)
        Me.ug_Asiento.TabIndex = 1
        Me.ug_Asiento.Text = "UltraGrid1"
        '
        'uds_Asiento
        '
        Me.uds_Asiento.AllowDelete = False
        UltraDataColumn1.DataType = GetType(Short)
        UltraDataColumn5.DataType = GetType(Double)
        UltraDataColumn6.DataType = GetType(Double)
        Me.uds_Asiento.Band.Columns.AddRange(New Object() {UltraDataColumn1, UltraDataColumn2, UltraDataColumn3, UltraDataColumn4, UltraDataColumn5, UltraDataColumn6, UltraDataColumn7})
        '
        'ugb_Parametros
        '
        Me.ugb_Parametros.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ugb_Parametros.Controls.Add(Me.uos_tipo)
        Me.ugb_Parametros.Controls.Add(Me.une_Ayo)
        Me.ugb_Parametros.Controls.Add(Me.UltraLabel7)
        Me.ugb_Parametros.Controls.Add(Me.UltraLabel8)
        Me.ugb_Parametros.Controls.Add(Me.uce_Mes)
        Me.ugb_Parametros.Location = New System.Drawing.Point(12, 32)
        Me.ugb_Parametros.Name = "ugb_Parametros"
        Me.ugb_Parametros.Size = New System.Drawing.Size(634, 36)
        Me.ugb_Parametros.TabIndex = 15
        Me.ugb_Parametros.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.XP
        '
        'uos_tipo
        '
        Me.uos_tipo.BackColor = System.Drawing.Color.Transparent
        Me.uos_tipo.BackColorInternal = System.Drawing.Color.Transparent
        Me.uos_tipo.BorderStyle = Infragistics.Win.UIElementBorderStyle.None
        Me.uos_tipo.CheckedIndex = 0
        ValueListItem2.DataValue = CType(1, Short)
        ValueListItem2.DisplayText = "CTS"
        ValueListItem3.DataValue = CType(2, Short)
        ValueListItem3.DisplayText = "Vacaciones"
        Me.uos_tipo.Items.AddRange(New Infragistics.Win.ValueListItem() {ValueListItem2, ValueListItem3})
        Me.uos_tipo.ItemSpacingHorizontal = 10
        Me.uos_tipo.Location = New System.Drawing.Point(441, 10)
        Me.uos_tipo.Name = "uos_tipo"
        Me.uos_tipo.Size = New System.Drawing.Size(174, 18)
        Me.uos_tipo.TabIndex = 14
        Me.uos_tipo.Text = "CTS"
        '
        'une_Ayo
        '
        Appearance1.TextHAlignAsString = "Center"
        Me.une_Ayo.Appearance = Appearance1
        Me.une_Ayo.Location = New System.Drawing.Point(48, 7)
        Me.une_Ayo.MaskInput = "nnnn"
        Me.une_Ayo.Name = "une_Ayo"
        Me.une_Ayo.ReadOnly = True
        Me.une_Ayo.Size = New System.Drawing.Size(36, 21)
        Me.une_Ayo.TabIndex = 13
        '
        'UltraLabel7
        '
        Appearance4.BackColor = System.Drawing.Color.Transparent
        Appearance4.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel7.Appearance = Appearance4
        Me.UltraLabel7.AutoSize = True
        Me.UltraLabel7.Location = New System.Drawing.Point(18, 11)
        Me.UltraLabel7.Name = "UltraLabel7"
        Me.UltraLabel7.Size = New System.Drawing.Size(27, 14)
        Me.UltraLabel7.TabIndex = 12
        Me.UltraLabel7.Text = "Año:"
        '
        'UltraLabel8
        '
        Appearance12.BackColor = System.Drawing.Color.Transparent
        Appearance12.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel8.Appearance = Appearance12
        Me.UltraLabel8.AutoSize = True
        Me.UltraLabel8.Location = New System.Drawing.Point(96, 12)
        Me.UltraLabel8.Name = "UltraLabel8"
        Me.UltraLabel8.Size = New System.Drawing.Size(32, 14)
        Me.UltraLabel8.TabIndex = 12
        Me.UltraLabel8.Text = "Mes :"
        '
        'uce_Mes
        '
        Me.uce_Mes.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.uce_Mes.Location = New System.Drawing.Point(131, 8)
        Me.uce_Mes.Name = "uce_Mes"
        Me.uce_Mes.Size = New System.Drawing.Size(109, 21)
        Me.uce_Mes.TabIndex = 0
        '
        'ToolStrip1
        '
        Me.ToolStrip1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripSeparator3, Me.Tool_Procesar, Me.ToolStripSeparator2, Me.Tool_Generar, Me.ToolStripSeparator1, Me.Tool_Salir, Me.ToolStripSeparator5})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(658, 25)
        Me.ToolStrip1.TabIndex = 16
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 25)
        '
        'Tool_Procesar
        '
        Me.Tool_Procesar.Image = Global.Contabilidad.My.Resources.Resources._16__Configure_
        Me.Tool_Procesar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Tool_Procesar.Name = "Tool_Procesar"
        Me.Tool_Procesar.Size = New System.Drawing.Size(69, 22)
        Me.Tool_Procesar.Text = "Procesar"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'Tool_Generar
        '
        Me.Tool_Generar.Image = Global.Contabilidad.My.Resources.Resources._16__Build_
        Me.Tool_Generar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Tool_Generar.Name = "Tool_Generar"
        Me.Tool_Generar.Size = New System.Drawing.Size(105, 22)
        Me.Tool_Generar.Text = "Generar Asiento"
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
        Me.Tool_Salir.Size = New System.Drawing.Size(47, 22)
        Me.Tool_Salir.Text = "Salir"
        '
        'ToolStripSeparator5
        '
        Me.ToolStripSeparator5.Name = "ToolStripSeparator5"
        Me.ToolStripSeparator5.Size = New System.Drawing.Size(6, 25)
        '
        'UltraGroupBox3
        '
        Me.UltraGroupBox3.Controls.Add(Me.uce_SubDiario)
        Me.UltraGroupBox3.Controls.Add(Me.udte_fec_Vou)
        Me.UltraGroupBox3.Controls.Add(Me.UltraLabel3)
        Me.UltraGroupBox3.Controls.Add(Me.UltraLabel6)
        Me.UltraGroupBox3.Location = New System.Drawing.Point(12, 73)
        Me.UltraGroupBox3.Name = "UltraGroupBox3"
        Me.UltraGroupBox3.Size = New System.Drawing.Size(634, 47)
        Me.UltraGroupBox3.TabIndex = 24
        Me.UltraGroupBox3.Text = "Informacion"
        '
        'uce_SubDiario
        '
        Me.uce_SubDiario.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.uce_SubDiario.Location = New System.Drawing.Point(286, 19)
        Me.uce_SubDiario.Name = "uce_SubDiario"
        Me.uce_SubDiario.Size = New System.Drawing.Size(212, 21)
        Me.uce_SubDiario.TabIndex = 5
        '
        'udte_fec_Vou
        '
        Me.udte_fec_Vou.Location = New System.Drawing.Point(101, 19)
        Me.udte_fec_Vou.MaskInput = "{date}"
        Me.udte_fec_Vou.Name = "udte_fec_Vou"
        Me.udte_fec_Vou.Size = New System.Drawing.Size(96, 21)
        Me.udte_fec_Vou.TabIndex = 3
        '
        'UltraLabel3
        '
        Appearance9.BackColor = System.Drawing.Color.Transparent
        Appearance9.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel3.Appearance = Appearance9
        Me.UltraLabel3.AutoSize = True
        Me.UltraLabel3.Location = New System.Drawing.Point(224, 23)
        Me.UltraLabel3.Name = "UltraLabel3"
        Me.UltraLabel3.Size = New System.Drawing.Size(58, 14)
        Me.UltraLabel3.TabIndex = 4
        Me.UltraLabel3.Text = "Subdiario :"
        '
        'UltraLabel6
        '
        Appearance10.BackColor = System.Drawing.Color.Transparent
        Appearance10.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel6.Appearance = Appearance10
        Me.UltraLabel6.AutoSize = True
        Me.UltraLabel6.Location = New System.Drawing.Point(14, 23)
        Me.UltraLabel6.Name = "UltraLabel6"
        Me.UltraLabel6.Size = New System.Drawing.Size(81, 14)
        Me.UltraLabel6.TabIndex = 4
        Me.UltraLabel6.Text = "Fecha Voucher"
        '
        'PL_PR_Provisiones
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(658, 443)
        Me.Controls.Add(Me.UltraGroupBox3)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.ugb_Parametros)
        Me.Controls.Add(Me.ug_Asiento)
        Me.Name = "PL_PR_Provisiones"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Provisiones de CTS y Vacaciones"
        CType(Me.ug_Asiento, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.uds_Asiento, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ugb_Parametros, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ugb_Parametros.ResumeLayout(False)
        Me.ugb_Parametros.PerformLayout()
        CType(Me.uos_tipo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.une_Ayo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.uce_Mes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        CType(Me.UltraGroupBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraGroupBox3.ResumeLayout(False)
        Me.UltraGroupBox3.PerformLayout()
        CType(Me.uce_SubDiario, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.udte_fec_Vou, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ug_Asiento As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents ugb_Parametros As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents une_Ayo As Infragistics.Win.UltraWinEditors.UltraNumericEditor
    Friend WithEvents UltraLabel7 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel8 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents uce_Mes As Infragistics.Win.UltraWinEditors.UltraComboEditor
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents Tool_Procesar As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents Tool_Salir As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator5 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents Tool_Generar As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents UltraGroupBox3 As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents udte_fec_Vou As Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
    Friend WithEvents UltraLabel3 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel6 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents uce_SubDiario As Infragistics.Win.UltraWinEditors.UltraComboEditor
    Friend WithEvents uds_Asiento As Infragistics.Win.UltraWinDataSource.UltraDataSource
    Friend WithEvents uos_tipo As Infragistics.Win.UltraWinEditors.UltraOptionSet
End Class
