<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PL_RP_Planilla_Mes
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
        Dim Appearance1 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance23 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance12 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance3 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance2 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance5 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance4 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.Tool_Imprimir_Chico = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator()
        Me.Tool_exportar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.Tool_Salir = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ugb_Parametros = New Infragistics.Win.Misc.UltraGroupBox()
        Me.uce_TipoPersonal = New Infragistics.Win.UltraWinEditors.UltraComboEditor()
        Me.UltraLabel2 = New Infragistics.Win.Misc.UltraLabel()
        Me.une_Ayo = New Infragistics.Win.UltraWinEditors.UltraNumericEditor()
        Me.UltraLabel7 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraLabel8 = New Infragistics.Win.Misc.UltraLabel()
        Me.uce_Mes = New Infragistics.Win.UltraWinEditors.UltraComboEditor()
        Me.ug_planilla = New Infragistics.Win.UltraWinGrid.UltraGrid()
        Me.UltraGridColumnChooser1 = New Infragistics.Win.UltraWinGrid.UltraGridColumnChooser()
        Me.uge_planilla = New Infragistics.Win.UltraWinGrid.ExcelExport.UltraGridExcelExporter(Me.components)
        Me.CachedSG_SI_01_21 = New LR.CachedSG_SI_01_2()
        Me.ToolStrip1.SuspendLayout()
        CType(Me.ugb_Parametros, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ugb_Parametros.SuspendLayout()
        CType(Me.uce_TipoPersonal, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.une_Ayo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.uce_Mes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ug_planilla, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UltraGridColumnChooser1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ToolStrip1
        '
        Me.ToolStrip1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Tool_Imprimir_Chico, Me.ToolStripSeparator5, Me.Tool_exportar, Me.ToolStripSeparator3, Me.Tool_Salir, Me.ToolStripSeparator1})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(573, 25)
        Me.ToolStrip1.TabIndex = 7
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'Tool_Imprimir_Chico
        '
        Me.Tool_Imprimir_Chico.Image = Global.Contabilidad.My.Resources.Resources._004
        Me.Tool_Imprimir_Chico.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Tool_Imprimir_Chico.Name = "Tool_Imprimir_Chico"
        Me.Tool_Imprimir_Chico.Size = New System.Drawing.Size(65, 22)
        Me.Tool_Imprimir_Chico.Text = "Imprimir"
        '
        'ToolStripSeparator5
        '
        Me.ToolStripSeparator5.Name = "ToolStripSeparator5"
        Me.ToolStripSeparator5.Size = New System.Drawing.Size(6, 25)
        '
        'Tool_exportar
        '
        Me.Tool_exportar.Image = Global.Contabilidad.My.Resources.Resources._16__Doc_excel_
        Me.Tool_exportar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Tool_exportar.Name = "Tool_exportar"
        Me.Tool_exportar.Size = New System.Drawing.Size(69, 22)
        Me.Tool_exportar.Text = "Exportar"
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
        Me.Tool_Salir.Size = New System.Drawing.Size(47, 22)
        Me.Tool_Salir.Text = "Salir"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'ugb_Parametros
        '
        Me.ugb_Parametros.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ugb_Parametros.Controls.Add(Me.uce_TipoPersonal)
        Me.ugb_Parametros.Controls.Add(Me.UltraLabel2)
        Me.ugb_Parametros.Controls.Add(Me.une_Ayo)
        Me.ugb_Parametros.Controls.Add(Me.UltraLabel7)
        Me.ugb_Parametros.Controls.Add(Me.UltraLabel8)
        Me.ugb_Parametros.Controls.Add(Me.uce_Mes)
        Me.ugb_Parametros.Location = New System.Drawing.Point(12, 38)
        Me.ugb_Parametros.Name = "ugb_Parametros"
        Me.ugb_Parametros.Size = New System.Drawing.Size(551, 41)
        Me.ugb_Parametros.TabIndex = 8
        '
        'uce_TipoPersonal
        '
        Me.uce_TipoPersonal.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.uce_TipoPersonal.Location = New System.Drawing.Point(359, 11)
        Me.uce_TipoPersonal.Name = "uce_TipoPersonal"
        Me.uce_TipoPersonal.Size = New System.Drawing.Size(158, 21)
        Me.uce_TipoPersonal.TabIndex = 14
        '
        'UltraLabel2
        '
        Appearance13.BackColor = System.Drawing.Color.Transparent
        Appearance13.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel2.Appearance = Appearance13
        Me.UltraLabel2.AutoSize = True
        Me.UltraLabel2.Location = New System.Drawing.Point(282, 15)
        Me.UltraLabel2.Name = "UltraLabel2"
        Me.UltraLabel2.Size = New System.Drawing.Size(74, 14)
        Me.UltraLabel2.TabIndex = 3
        Me.UltraLabel2.Text = "Tipo Personal"
        '
        'une_Ayo
        '
        Appearance1.TextHAlignAsString = "Center"
        Me.une_Ayo.Appearance = Appearance1
        Me.une_Ayo.Location = New System.Drawing.Point(54, 11)
        Me.une_Ayo.MaskInput = "nnnn"
        Me.une_Ayo.Name = "une_Ayo"
        Me.une_Ayo.ReadOnly = True
        Me.une_Ayo.Size = New System.Drawing.Size(36, 21)
        Me.une_Ayo.TabIndex = 13
        '
        'UltraLabel7
        '
        Appearance23.BackColor = System.Drawing.Color.Transparent
        Appearance23.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel7.Appearance = Appearance23
        Me.UltraLabel7.AutoSize = True
        Me.UltraLabel7.Location = New System.Drawing.Point(21, 15)
        Me.UltraLabel7.Name = "UltraLabel7"
        Me.UltraLabel7.Size = New System.Drawing.Size(30, 14)
        Me.UltraLabel7.TabIndex = 12
        Me.UltraLabel7.Text = "Año :"
        '
        'UltraLabel8
        '
        Appearance12.BackColor = System.Drawing.Color.Transparent
        Appearance12.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel8.Appearance = Appearance12
        Me.UltraLabel8.AutoSize = True
        Me.UltraLabel8.Location = New System.Drawing.Point(102, 15)
        Me.UltraLabel8.Name = "UltraLabel8"
        Me.UltraLabel8.Size = New System.Drawing.Size(32, 14)
        Me.UltraLabel8.TabIndex = 12
        Me.UltraLabel8.Text = "Mes :"
        '
        'uce_Mes
        '
        Me.uce_Mes.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.uce_Mes.Location = New System.Drawing.Point(137, 11)
        Me.uce_Mes.Name = "uce_Mes"
        Me.uce_Mes.Size = New System.Drawing.Size(120, 21)
        Me.uce_Mes.TabIndex = 0
        '
        'ug_planilla
        '
        Me.ug_planilla.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.[False]
        Me.ug_planilla.DisplayLayout.MaxColScrollRegions = 1
        Me.ug_planilla.DisplayLayout.MaxRowScrollRegions = 1
        Me.ug_planilla.DisplayLayout.Override.ColumnSizingArea = Infragistics.Win.UltraWinGrid.ColumnSizingArea.HeadersOnly
        Appearance3.FontData.SizeInPoints = 10.0!
        Me.ug_planilla.DisplayLayout.Override.HeaderAppearance = Appearance3
        Me.ug_planilla.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Appearance2.BackColor = System.Drawing.Color.WhiteSmoke
        Appearance2.BackColor2 = System.Drawing.Color.WhiteSmoke
        Me.ug_planilla.DisplayLayout.Override.RowAlternateAppearance = Appearance2
        Me.ug_planilla.DisplayLayout.Override.RowSizing = Infragistics.Win.UltraWinGrid.RowSizing.AutoFree
        Me.ug_planilla.DisplayLayout.Override.SummaryDisplayArea = Infragistics.Win.UltraWinGrid.SummaryDisplayAreas.BottomFixed
        Appearance5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ug_planilla.DisplayLayout.Override.SummaryFooterCaptionAppearance = Appearance5
        Appearance4.BackColor = System.Drawing.Color.WhiteSmoke
        Appearance4.BackColor2 = System.Drawing.Color.WhiteSmoke
        Appearance4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ug_planilla.DisplayLayout.Override.SummaryValueAppearance = Appearance4
        Me.ug_planilla.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.ug_planilla.Location = New System.Drawing.Point(199, 129)
        Me.ug_planilla.Name = "ug_planilla"
        Me.ug_planilla.Size = New System.Drawing.Size(362, 81)
        Me.ug_planilla.TabIndex = 9
        Me.ug_planilla.Text = "UltraGrid1"
        '
        'UltraGridColumnChooser1
        '
        Me.UltraGridColumnChooser1.DisplayLayout.AutoFitStyle = Infragistics.Win.UltraWinGrid.AutoFitStyle.ResizeAllColumns
        Me.UltraGridColumnChooser1.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.[False]
        Me.UltraGridColumnChooser1.DisplayLayout.MaxColScrollRegions = 1
        Me.UltraGridColumnChooser1.DisplayLayout.MaxRowScrollRegions = 1
        Me.UltraGridColumnChooser1.DisplayLayout.Override.AllowColMoving = Infragistics.Win.UltraWinGrid.AllowColMoving.NotAllowed
        Me.UltraGridColumnChooser1.DisplayLayout.Override.AllowColSizing = Infragistics.Win.UltraWinGrid.AllowColSizing.None
        Me.UltraGridColumnChooser1.DisplayLayout.Override.AllowRowLayoutCellSizing = Infragistics.Win.UltraWinGrid.RowLayoutSizing.None
        Me.UltraGridColumnChooser1.DisplayLayout.Override.AllowRowLayoutLabelSizing = Infragistics.Win.UltraWinGrid.RowLayoutSizing.None
        Me.UltraGridColumnChooser1.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        Me.UltraGridColumnChooser1.DisplayLayout.Override.CellPadding = 2
        Me.UltraGridColumnChooser1.DisplayLayout.Override.ExpansionIndicator = Infragistics.Win.UltraWinGrid.ShowExpansionIndicator.Never
        Me.UltraGridColumnChooser1.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.[Select]
        Me.UltraGridColumnChooser1.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.[False]
        Me.UltraGridColumnChooser1.DisplayLayout.Override.RowSizing = Infragistics.Win.UltraWinGrid.RowSizing.AutoFixed
        Me.UltraGridColumnChooser1.DisplayLayout.Override.SelectTypeCell = Infragistics.Win.UltraWinGrid.SelectType.None
        Me.UltraGridColumnChooser1.DisplayLayout.Override.SelectTypeCol = Infragistics.Win.UltraWinGrid.SelectType.None
        Me.UltraGridColumnChooser1.DisplayLayout.Override.SelectTypeRow = Infragistics.Win.UltraWinGrid.SelectType.None
        Me.UltraGridColumnChooser1.DisplayLayout.RowConnectorStyle = Infragistics.Win.UltraWinGrid.RowConnectorStyle.None
        Me.UltraGridColumnChooser1.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.UltraGridColumnChooser1.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.UltraGridColumnChooser1.Location = New System.Drawing.Point(12, 129)
        Me.UltraGridColumnChooser1.Name = "UltraGridColumnChooser1"
        Me.UltraGridColumnChooser1.Size = New System.Drawing.Size(181, 81)
        Me.UltraGridColumnChooser1.StyleLibraryName = ""
        Me.UltraGridColumnChooser1.StyleSetName = ""
        Me.UltraGridColumnChooser1.TabIndex = 10
        Me.UltraGridColumnChooser1.Text = "UltraGridColumnChooser1"
        '
        'PL_RP_Planilla_Mes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(573, 91)
        Me.Controls.Add(Me.UltraGridColumnChooser1)
        Me.Controls.Add(Me.ug_planilla)
        Me.Controls.Add(Me.ugb_Parametros)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Name = "PL_RP_Planilla_Mes"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Planilla Mensual"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        CType(Me.ugb_Parametros, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ugb_Parametros.ResumeLayout(False)
        Me.ugb_Parametros.PerformLayout()
        CType(Me.uce_TipoPersonal, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.une_Ayo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.uce_Mes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ug_planilla, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UltraGridColumnChooser1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents Tool_exportar As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents Tool_Salir As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ugb_Parametros As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents uce_TipoPersonal As Infragistics.Win.UltraWinEditors.UltraComboEditor
    Friend WithEvents UltraLabel2 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents une_Ayo As Infragistics.Win.UltraWinEditors.UltraNumericEditor
    Friend WithEvents UltraLabel7 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel8 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents uce_Mes As Infragistics.Win.UltraWinEditors.UltraComboEditor
    Friend WithEvents ug_planilla As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents UltraGridColumnChooser1 As Infragistics.Win.UltraWinGrid.UltraGridColumnChooser
    Friend WithEvents uge_planilla As Infragistics.Win.UltraWinGrid.ExcelExport.UltraGridExcelExporter
    Friend WithEvents Tool_Imprimir_Chico As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator5 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents CachedSG_SI_01_21 As LR.CachedSG_SI_01_2
End Class
