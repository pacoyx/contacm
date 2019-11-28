<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PL_PR_Folios
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
        Dim UltraDataColumn1 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("FO_ID_PERSONA")
        Dim UltraDataColumn2 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("PE_CODIGO")
        Dim UltraDataColumn3 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("NOMBRES")
        Dim UltraDataColumn4 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("FO_VALOR")
        Dim UltraGridBand1 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1)
        Dim UltraGridColumn1 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FO_ID_PERSONA")
        Dim UltraGridColumn2 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("PE_CODIGO")
        Dim UltraGridColumn3 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NOMBRES", -1, Nothing, 0, Infragistics.Win.UltraWinGrid.SortIndicator.Ascending, False)
        Dim UltraGridColumn4 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FO_VALOR")
        Dim Appearance2 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn5 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("col_btn_Doc", 0)
        Dim SummarySettings1 As Infragistics.Win.UltraWinGrid.SummarySettings = New Infragistics.Win.UltraWinGrid.SummarySettings("", Infragistics.Win.UltraWinGrid.SummaryType.Sum, Nothing, "FO_VALOR", 3, True, "Band 0", 0, Infragistics.Win.UltraWinGrid.SummaryPosition.UseSummaryPositionColumn, "FO_VALOR", 3, True)
        Dim Appearance3 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance4 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridBand2 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1)
        Dim UltraGridColumn6 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CO_ID")
        Dim UltraGridColumn7 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CO_DESCRIPCION")
        Dim Appearance1 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraDataColumn5 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("CO_ID")
        Dim UltraDataColumn6 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("CO_DESCRIPCION")
        Dim Appearance28 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance8 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance22 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Me.uds_detalle = New Infragistics.Win.UltraWinDataSource.UltraDataSource(Me.components)
        Me.ug_Detalle = New Infragistics.Win.UltraWinGrid.UltraGrid()
        Me.ug_Folios = New Infragistics.Win.UltraWinGrid.UltraGrid()
        Me.uds_Folios = New Infragistics.Win.UltraWinDataSource.UltraDataSource(Me.components)
        Me.udte_fecha = New Infragistics.Win.UltraWinEditors.UltraDateTimeEditor()
        Me.ubtn_previo = New Infragistics.Win.Misc.UltraButton()
        Me.ubtn_siguiente = New Infragistics.Win.Misc.UltraButton()
        Me.lbl_titulo = New Infragistics.Win.Misc.UltraLabel()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.tool_agregar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.Tool_agregar_ConValor = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.Tool_CargarFolio = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.Tool_Eliminar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.Tool_eliminar_todos = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator()
        Me.Tool_Salir = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator6 = New System.Windows.Forms.ToolStripSeparator()
        CType(Me.uds_detalle, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ug_Detalle, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ug_Folios, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.uds_Folios, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.udte_fecha, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'uds_detalle
        '
        UltraDataColumn1.DataType = GetType(Integer)
        UltraDataColumn4.DataType = GetType(Double)
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
        UltraGridColumn1.Header.VisiblePosition = 0
        UltraGridColumn1.Hidden = True
        UltraGridColumn2.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn2.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn2.Header.Caption = "Codigo"
        UltraGridColumn2.Header.VisiblePosition = 2
        UltraGridColumn2.Width = 65
        UltraGridColumn3.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn3.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn3.Header.Caption = "Personal"
        UltraGridColumn3.Header.VisiblePosition = 3
        UltraGridColumn3.Width = 264
        UltraGridColumn4.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        Appearance2.TextHAlignAsString = "Right"
        UltraGridColumn4.CellAppearance = Appearance2
        UltraGridColumn4.Header.Caption = "Valor"
        UltraGridColumn4.Header.VisiblePosition = 4
        UltraGridColumn4.MaskDisplayMode = Infragistics.Win.UltraWinMaskedEdit.MaskMode.IncludeLiterals
        UltraGridColumn4.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Double]
        UltraGridColumn5.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn5.ButtonDisplayStyle = Infragistics.Win.UltraWinGrid.ButtonDisplayStyle.Always
        UltraGridColumn5.Header.Caption = "Docum."
        UltraGridColumn5.Header.VisiblePosition = 1
        UltraGridColumn5.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.Button
        UltraGridColumn5.Width = 42
        UltraGridBand1.Columns.AddRange(New Object() {UltraGridColumn1, UltraGridColumn2, UltraGridColumn3, UltraGridColumn4, UltraGridColumn5})
        Appearance3.BackColor = System.Drawing.Color.White
        Appearance3.ForeColor = System.Drawing.Color.Navy
        Appearance3.TextHAlignAsString = "Right"
        SummarySettings1.Appearance = Appearance3
        SummarySettings1.DisplayFormat = "Sum= {0:##,##0.00#}"
        SummarySettings1.GroupBySummaryValueAppearance = Appearance4
        SummarySettings1.SummaryDisplayArea = Infragistics.Win.UltraWinGrid.SummaryDisplayAreas.BottomFixed
        UltraGridBand1.Summaries.AddRange(New Infragistics.Win.UltraWinGrid.SummarySettings() {SummarySettings1})
        UltraGridBand1.SummaryFooterCaption = ""
        Me.ug_Detalle.DisplayLayout.BandsSerializer.Add(UltraGridBand1)
        Me.ug_Detalle.DisplayLayout.MaxColScrollRegions = 1
        Me.ug_Detalle.DisplayLayout.MaxRowScrollRegions = 1
        Me.ug_Detalle.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Me.ug_Detalle.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.ug_Detalle.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.ug_Detalle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ug_Detalle.Location = New System.Drawing.Point(272, 71)
        Me.ug_Detalle.Name = "ug_Detalle"
        Me.ug_Detalle.Size = New System.Drawing.Size(512, 370)
        Me.ug_Detalle.TabIndex = 3
        '
        'ug_Folios
        '
        Me.ug_Folios.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.ug_Folios.DataSource = Me.uds_Folios
        Me.ug_Folios.DisplayLayout.AutoFitStyle = Infragistics.Win.UltraWinGrid.AutoFitStyle.ExtendLastColumn
        UltraGridColumn6.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn6.Header.VisiblePosition = 0
        UltraGridColumn6.Hidden = True
        UltraGridColumn7.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn7.Header.Caption = "Folio"
        UltraGridColumn7.Header.VisiblePosition = 1
        UltraGridBand2.Columns.AddRange(New Object() {UltraGridColumn6, UltraGridColumn7})
        Me.ug_Folios.DisplayLayout.BandsSerializer.Add(UltraGridBand2)
        Me.ug_Folios.DisplayLayout.MaxColScrollRegions = 1
        Me.ug_Folios.DisplayLayout.MaxRowScrollRegions = 1
        Appearance1.FontData.BoldAsString = "True"
        Appearance1.FontData.SizeInPoints = 10.0!
        Me.ug_Folios.DisplayLayout.Override.RowSelectorAppearance = Appearance1
        Me.ug_Folios.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.ug_Folios.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ug_Folios.Location = New System.Drawing.Point(13, 71)
        Me.ug_Folios.Name = "ug_Folios"
        Me.ug_Folios.Size = New System.Drawing.Size(252, 370)
        Me.ug_Folios.TabIndex = 13
        '
        'uds_Folios
        '
        Me.uds_Folios.AllowDelete = False
        Me.uds_Folios.Band.Columns.AddRange(New Object() {UltraDataColumn5, UltraDataColumn6})
        '
        'udte_fecha
        '
        Me.udte_fecha.FormatString = "MMMM  /  yyyy"
        Me.udte_fecha.Location = New System.Drawing.Point(39, 44)
        Me.udte_fecha.Name = "udte_fecha"
        Me.udte_fecha.Size = New System.Drawing.Size(130, 21)
        Me.udte_fecha.TabIndex = 16
        '
        'ubtn_previo
        '
        Appearance28.ImageHAlign = Infragistics.Win.HAlign.Center
        Appearance28.ImageVAlign = Infragistics.Win.VAlign.Middle
        Me.ubtn_previo.Appearance = Appearance28
        Me.ubtn_previo.Location = New System.Drawing.Point(13, 43)
        Me.ubtn_previo.Name = "ubtn_previo"
        Me.ubtn_previo.Size = New System.Drawing.Size(25, 22)
        Me.ubtn_previo.TabIndex = 17
        '
        'ubtn_siguiente
        '
        Appearance8.ImageHAlign = Infragistics.Win.HAlign.Center
        Appearance8.ImageVAlign = Infragistics.Win.VAlign.Middle
        Me.ubtn_siguiente.Appearance = Appearance8
        Me.ubtn_siguiente.Location = New System.Drawing.Point(170, 43)
        Me.ubtn_siguiente.Name = "ubtn_siguiente"
        Me.ubtn_siguiente.Size = New System.Drawing.Size(25, 22)
        Me.ubtn_siguiente.TabIndex = 17
        '
        'lbl_titulo
        '
        Me.lbl_titulo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Appearance22.BackColor = System.Drawing.Color.White
        Appearance22.ForeColor = System.Drawing.Color.Navy
        Me.lbl_titulo.Appearance = Appearance22
        Me.lbl_titulo.BorderStyleInner = Infragistics.Win.UIElementBorderStyle.Solid
        Me.lbl_titulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_titulo.Location = New System.Drawing.Point(272, 44)
        Me.lbl_titulo.Name = "lbl_titulo"
        Me.lbl_titulo.Size = New System.Drawing.Size(510, 23)
        Me.lbl_titulo.TabIndex = 22
        '
        'ToolStrip1
        '
        Me.ToolStrip1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tool_agregar, Me.ToolStripSeparator1, Me.Tool_agregar_ConValor, Me.ToolStripSeparator2, Me.Tool_CargarFolio, Me.ToolStripSeparator3, Me.Tool_Eliminar, Me.ToolStripSeparator4, Me.Tool_eliminar_todos, Me.ToolStripSeparator5, Me.Tool_Salir, Me.ToolStripSeparator6})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(794, 25)
        Me.ToolStrip1.TabIndex = 27
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'tool_agregar
        '
        Me.tool_agregar.Image = Global.Contabilidad.My.Resources.Resources.Bebox__person_
        Me.tool_agregar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tool_agregar.Name = "tool_agregar"
        Me.tool_agregar.Size = New System.Drawing.Size(99, 22)
        Me.tool_agregar.Text = "Agregar Trab."
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'Tool_agregar_ConValor
        '
        Me.Tool_agregar_ConValor.Image = Global.Contabilidad.My.Resources.Resources._16__Settings_
        Me.Tool_agregar_ConValor.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Tool_agregar_ConValor.Name = "Tool_agregar_ConValor"
        Me.Tool_agregar_ConValor.Size = New System.Drawing.Size(124, 22)
        Me.Tool_agregar_ConValor.Text = "Agregar Con Valor"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'Tool_CargarFolio
        '
        Me.Tool_CargarFolio.Image = Global.Contabilidad.My.Resources.Resources.Bebox__ansi_server_
        Me.Tool_CargarFolio.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Tool_CargarFolio.Name = "Tool_CargarFolio"
        Me.Tool_CargarFolio.Size = New System.Drawing.Size(91, 22)
        Me.Tool_CargarFolio.Text = "Copiar Folio"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 25)
        '
        'Tool_Eliminar
        '
        Me.Tool_Eliminar.Image = Global.Contabilidad.My.Resources.Resources._16__Delete_over_
        Me.Tool_Eliminar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Tool_Eliminar.Name = "Tool_Eliminar"
        Me.Tool_Eliminar.Size = New System.Drawing.Size(70, 22)
        Me.Tool_Eliminar.Text = "Eliminar"
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(6, 25)
        '
        'Tool_eliminar_todos
        '
        Me.Tool_eliminar_todos.Image = Global.Contabilidad.My.Resources.Resources._16__Delete_
        Me.Tool_eliminar_todos.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Tool_eliminar_todos.Name = "Tool_eliminar_todos"
        Me.Tool_eliminar_todos.Size = New System.Drawing.Size(106, 22)
        Me.Tool_eliminar_todos.Text = "Eliminar Todos"
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
        Me.Tool_Salir.Size = New System.Drawing.Size(49, 22)
        Me.Tool_Salir.Text = "Salir"
        '
        'ToolStripSeparator6
        '
        Me.ToolStripSeparator6.Name = "ToolStripSeparator6"
        Me.ToolStripSeparator6.Size = New System.Drawing.Size(6, 25)
        '
        'PL_PR_Folios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(794, 448)
        Me.Controls.Add(Me.lbl_titulo)
        Me.Controls.Add(Me.ubtn_siguiente)
        Me.Controls.Add(Me.ubtn_previo)
        Me.Controls.Add(Me.udte_fecha)
        Me.Controls.Add(Me.ug_Folios)
        Me.Controls.Add(Me.ug_Detalle)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Name = "PL_PR_Folios"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Registro de Folios"
        CType(Me.uds_detalle, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ug_Detalle, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ug_Folios, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.uds_Folios, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.udte_fecha, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents uds_detalle As Infragistics.Win.UltraWinDataSource.UltraDataSource
    Friend WithEvents ug_Detalle As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents ug_Folios As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents uds_Folios As Infragistics.Win.UltraWinDataSource.UltraDataSource
    Friend WithEvents udte_fecha As Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
    Friend WithEvents ubtn_siguiente As Infragistics.Win.Misc.UltraButton
    Friend WithEvents ubtn_previo As Infragistics.Win.Misc.UltraButton
    Friend WithEvents lbl_titulo As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents tool_agregar As System.Windows.Forms.ToolStripButton
    Friend WithEvents Tool_agregar_ConValor As System.Windows.Forms.ToolStripButton
    Friend WithEvents Tool_CargarFolio As System.Windows.Forms.ToolStripButton
    Friend WithEvents Tool_Eliminar As System.Windows.Forms.ToolStripButton
    Friend WithEvents Tool_eliminar_todos As System.Windows.Forms.ToolStripButton
    Friend WithEvents Tool_Salir As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator5 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator6 As System.Windows.Forms.ToolStripSeparator
End Class
