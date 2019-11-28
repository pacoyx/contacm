<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PL_RP_Tardanza_Detalle
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
        Dim UltraDataColumn1 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("FECHA")
        Dim UltraDataColumn2 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("HORA")
        Dim UltraDataColumn3 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("ESTADO")
        Dim UltraDataColumn4 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("TARDANZA")
        Dim UltraGridBand1 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1)
        Dim UltraGridColumn1 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FECHA")
        Dim Appearance13 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn2 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("HORA")
        Dim Appearance14 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn3 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ESTADO")
        Dim Appearance16 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn4 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TARDANZA")
        Dim Appearance17 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance18 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance20 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance4 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance2 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance15 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance12 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance3 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Me.uds_detalle = New Infragistics.Win.UltraWinDataSource.UltraDataSource(Me.components)
        Me.ug_Detalle = New Infragistics.Win.UltraWinGrid.UltraGrid()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.Tool_imprimir = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.Tool_exportar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.Tool_Salir = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.UltraLabel1 = New Infragistics.Win.Misc.UltraLabel()
        Me.txt_trabajador = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.UltraLabel2 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraLabel3 = New Infragistics.Win.Misc.UltraLabel()
        Me.lbl_ft = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraGridExcelExporter1 = New Infragistics.Win.UltraWinGrid.ExcelExport.UltraGridExcelExporter(Me.components)
        Me.UltraPrintPreviewDialog1 = New Infragistics.Win.Printing.UltraPrintPreviewDialog(Me.components)
        Me.ugpd_Planilla = New Infragistics.Win.UltraWinGrid.UltraGridPrintDocument(Me.components)
        Me.txt_total = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.UltraLabel4 = New Infragistics.Win.Misc.UltraLabel()
        CType(Me.uds_detalle, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ug_Detalle, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip1.SuspendLayout()
        CType(Me.txt_trabajador, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_total, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'uds_detalle
        '
        Me.uds_detalle.AllowDelete = False
        UltraDataColumn1.DataType = GetType(Date)
        Me.uds_detalle.Band.Columns.AddRange(New Object() {UltraDataColumn1, UltraDataColumn2, UltraDataColumn3, UltraDataColumn4})
        '
        'ug_Detalle
        '
        Me.ug_Detalle.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ug_Detalle.DataSource = Me.uds_detalle
        Me.ug_Detalle.DisplayLayout.AutoFitStyle = Infragistics.Win.UltraWinGrid.AutoFitStyle.ExtendLastColumn
        UltraGridColumn1.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn1.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        Appearance13.TextHAlignAsString = "Center"
        UltraGridColumn1.CellAppearance = Appearance13
        UltraGridColumn1.Header.Caption = "Fecha"
        UltraGridColumn1.Header.VisiblePosition = 0
        UltraGridColumn1.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Date]
        UltraGridColumn1.Width = 83
        UltraGridColumn2.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn2.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        Appearance14.TextHAlignAsString = "Center"
        UltraGridColumn2.CellAppearance = Appearance14
        UltraGridColumn2.Header.Caption = "Hora Marcada"
        UltraGridColumn2.Header.VisiblePosition = 1
        UltraGridColumn2.MaskInput = ""
        UltraGridColumn2.Width = 82
        UltraGridColumn3.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn3.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        Appearance16.TextHAlignAsString = "Center"
        UltraGridColumn3.CellAppearance = Appearance16
        UltraGridColumn3.Header.Caption = "Estado"
        UltraGridColumn3.Header.VisiblePosition = 2
        UltraGridColumn3.Width = 52
        UltraGridColumn4.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        Appearance17.TextHAlignAsString = "Center"
        UltraGridColumn4.CellAppearance = Appearance17
        UltraGridColumn4.Header.Caption = "Tardanza"
        UltraGridColumn4.Header.VisiblePosition = 3
        UltraGridColumn4.MaskInput = ""
        UltraGridColumn4.Width = 8
        UltraGridBand1.Columns.AddRange(New Object() {UltraGridColumn1, UltraGridColumn2, UltraGridColumn3, UltraGridColumn4})
        UltraGridBand1.SummaryFooterCaption = ""
        Me.ug_Detalle.DisplayLayout.BandsSerializer.Add(UltraGridBand1)
        Me.ug_Detalle.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.[False]
        Me.ug_Detalle.DisplayLayout.MaxColScrollRegions = 1
        Me.ug_Detalle.DisplayLayout.MaxRowScrollRegions = 1
        Appearance18.BackColor = System.Drawing.Color.WhiteSmoke
        Appearance18.BackColor2 = System.Drawing.Color.WhiteSmoke
        Me.ug_Detalle.DisplayLayout.Override.RowAlternateAppearance = Appearance18
        Me.ug_Detalle.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.ug_Detalle.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.ug_Detalle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ug_Detalle.Location = New System.Drawing.Point(12, 76)
        Me.ug_Detalle.Name = "ug_Detalle"
        Me.ug_Detalle.Size = New System.Drawing.Size(311, 359)
        Me.ug_Detalle.TabIndex = 0
        Me.ug_Detalle.Text = "UltraGrid1"
        '
        'ToolStrip1
        '
        Me.ToolStrip1.BackColor = System.Drawing.Color.Gainsboro
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripSeparator4, Me.Tool_imprimir, Me.ToolStripSeparator2, Me.Tool_exportar, Me.ToolStripSeparator3, Me.Tool_Salir, Me.ToolStripSeparator1})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(499, 25)
        Me.ToolStrip1.TabIndex = 8
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
        'Tool_exportar
        '
        Me.Tool_exportar.Image = Global.Contabilidad.My.Resources.Resources._16__Doc_excel_
        Me.Tool_exportar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Tool_exportar.Name = "Tool_exportar"
        Me.Tool_exportar.Size = New System.Drawing.Size(70, 22)
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
        Me.Tool_Salir.Size = New System.Drawing.Size(49, 22)
        Me.Tool_Salir.Text = "Salir"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'UltraLabel1
        '
        Appearance20.BackColor = System.Drawing.Color.Transparent
        Appearance20.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel1.Appearance = Appearance20
        Me.UltraLabel1.AutoSize = True
        Me.UltraLabel1.Location = New System.Drawing.Point(12, 44)
        Me.UltraLabel1.Name = "UltraLabel1"
        Me.UltraLabel1.Size = New System.Drawing.Size(65, 14)
        Me.UltraLabel1.TabIndex = 13
        Me.UltraLabel1.Text = "Trabajador : "
        '
        'txt_trabajador
        '
        Me.txt_trabajador.Location = New System.Drawing.Point(83, 40)
        Me.txt_trabajador.Name = "txt_trabajador"
        Me.txt_trabajador.ReadOnly = True
        Me.txt_trabajador.Size = New System.Drawing.Size(404, 21)
        Me.txt_trabajador.TabIndex = 14
        '
        'UltraLabel2
        '
        Me.UltraLabel2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Appearance4.BackColor = System.Drawing.Color.White
        Appearance4.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel2.Appearance = Appearance4
        Me.UltraLabel2.BorderStyleOuter = Infragistics.Win.UIElementBorderStyle.Solid
        Me.UltraLabel2.Location = New System.Drawing.Point(329, 105)
        Me.UltraLabel2.Name = "UltraLabel2"
        Me.UltraLabel2.Size = New System.Drawing.Size(158, 79)
        Me.UltraLabel2.TabIndex = 15
        Me.UltraLabel2.Text = "E = Entrada" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "S = Salida" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "T = Tardanza" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "FT = Falta Tardanza > 30 Min." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "TR = Tardan" & _
    "za Refrigerio"
        '
        'UltraLabel3
        '
        Me.UltraLabel3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Appearance2.BackColor = System.Drawing.Color.Transparent
        Appearance2.FontData.BoldAsString = "True"
        Appearance2.FontData.SizeInPoints = 10.0!
        Appearance2.ForeColor = System.Drawing.Color.Navy
        Appearance2.TextHAlignAsString = "Center"
        Appearance2.TextVAlignAsString = "Middle"
        Me.UltraLabel3.Appearance = Appearance2
        Me.UltraLabel3.BorderStyleOuter = Infragistics.Win.UIElementBorderStyle.Rounded1
        Me.UltraLabel3.Location = New System.Drawing.Point(329, 76)
        Me.UltraLabel3.Name = "UltraLabel3"
        Me.UltraLabel3.Size = New System.Drawing.Size(158, 26)
        Me.UltraLabel3.TabIndex = 16
        Me.UltraLabel3.Text = "Leyenda "
        '
        'lbl_ft
        '
        Me.lbl_ft.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Appearance15.BackColor = System.Drawing.Color.White
        Appearance15.ForeColor = System.Drawing.Color.Maroon
        Me.lbl_ft.Appearance = Appearance15
        Me.lbl_ft.BorderStyleOuter = Infragistics.Win.UIElementBorderStyle.Solid
        Me.lbl_ft.Location = New System.Drawing.Point(329, 190)
        Me.lbl_ft.Name = "lbl_ft"
        Me.lbl_ft.Size = New System.Drawing.Size(158, 79)
        Me.lbl_ft.TabIndex = 17
        Me.lbl_ft.Text = "No se esta considerando las faltas tipo FT por la configuracion que tiene en el m" & _
    "aestro de Personal."
        '
        'UltraPrintPreviewDialog1
        '
        Me.UltraPrintPreviewDialog1.Name = "UltraPrintPreviewDialog1"
        '
        'ugpd_Planilla
        '
        Me.ugpd_Planilla.Grid = Me.ug_Detalle
        '
        'txt_total
        '
        Me.txt_total.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Appearance12.TextHAlignAsString = "Right"
        Me.txt_total.Appearance = Appearance12
        Me.txt_total.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_total.Location = New System.Drawing.Point(224, 443)
        Me.txt_total.Name = "txt_total"
        Me.txt_total.ReadOnly = True
        Me.txt_total.Size = New System.Drawing.Size(99, 21)
        Me.txt_total.TabIndex = 18
        '
        'UltraLabel4
        '
        Me.UltraLabel4.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Appearance3.BackColor = System.Drawing.Color.Transparent
        Appearance3.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel4.Appearance = Appearance3
        Me.UltraLabel4.AutoSize = True
        Me.UltraLabel4.Location = New System.Drawing.Point(182, 447)
        Me.UltraLabel4.Name = "UltraLabel4"
        Me.UltraLabel4.Size = New System.Drawing.Size(36, 14)
        Me.UltraLabel4.TabIndex = 19
        Me.UltraLabel4.Text = "Total : "
        '
        'PL_RP_Tardanza_Detalle
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(499, 476)
        Me.Controls.Add(Me.UltraLabel4)
        Me.Controls.Add(Me.txt_total)
        Me.Controls.Add(Me.lbl_ft)
        Me.Controls.Add(Me.UltraLabel3)
        Me.Controls.Add(Me.UltraLabel2)
        Me.Controls.Add(Me.txt_trabajador)
        Me.Controls.Add(Me.UltraLabel1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.ug_Detalle)
        Me.Name = "PL_RP_Tardanza_Detalle"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Detalle de Tardanzas"
        CType(Me.uds_detalle, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ug_Detalle, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        CType(Me.txt_trabajador, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_total, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents uds_detalle As Infragistics.Win.UltraWinDataSource.UltraDataSource
    Friend WithEvents ug_Detalle As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents Tool_imprimir As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents Tool_exportar As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents Tool_Salir As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents UltraLabel1 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents txt_trabajador As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents UltraLabel2 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel3 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents lbl_ft As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraGridExcelExporter1 As Infragistics.Win.UltraWinGrid.ExcelExport.UltraGridExcelExporter
    Friend WithEvents UltraPrintPreviewDialog1 As Infragistics.Win.Printing.UltraPrintPreviewDialog
    Friend WithEvents ugpd_Planilla As Infragistics.Win.UltraWinGrid.UltraGridPrintDocument
    Friend WithEvents txt_total As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents UltraLabel4 As Infragistics.Win.Misc.UltraLabel
End Class
