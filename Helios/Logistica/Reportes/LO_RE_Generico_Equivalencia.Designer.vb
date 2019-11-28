<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LO_RE_Generico_Equivalencia
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
        Dim UltraDataColumn1 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("1")
        Dim UltraDataColumn2 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("2")
        Dim UltraDataColumn3 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("3")
        Dim UltraDataColumn4 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("4")
        Dim UltraDataColumn5 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("5")
        Dim UltraGridBand1 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1)
        Dim UltraGridColumn1 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("1")
        Dim Appearance1 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn2 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("2")
        Dim UltraGridColumn3 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("3")
        Dim UltraGridColumn4 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("4")
        Dim UltraGridColumn5 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("5")
        Dim Appearance18 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance54 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance49 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance3 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridBand2 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1)
        Dim UltraGridColumn6 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("GE_ID")
        Dim UltraGridColumn7 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("GE_DESCRIPCION")
        Dim Appearance6 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraDataColumn6 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("GE_ID")
        Dim UltraDataColumn7 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("GE_DESCRIPCION")
        Me.ToolS_Mantenimiento = New System.Windows.Forms.ToolStrip()
        Me.Tool_Imprimir = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.Tool_Cancelar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.Tool_Salir = New System.Windows.Forms.ToolStripButton()
        Me.uds_ListaDet = New Infragistics.Win.UltraWinDataSource.UltraDataSource(Me.components)
        Me.ug_ListaDet = New Infragistics.Win.UltraWinGrid.UltraGrid()
        Me.UltraGroupBox1 = New Infragistics.Win.Misc.UltraGroupBox()
        Me.ubtn_Quitar = New Infragistics.Win.Misc.UltraButton()
        Me.uce_Generico = New Infragistics.Win.UltraWinEditors.UltraComboEditor()
        Me.UltraLabel38 = New Infragistics.Win.Misc.UltraLabel()
        Me.ubtn_Consultar = New Infragistics.Win.Misc.UltraButton()
        Me.ug_Lista = New Infragistics.Win.UltraWinGrid.UltraGrid()
        Me.uds_Lista = New Infragistics.Win.UltraWinDataSource.UltraDataSource(Me.components)
        Me.ToolS_Mantenimiento.SuspendLayout()
        CType(Me.uds_ListaDet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ug_ListaDet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UltraGroupBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraGroupBox1.SuspendLayout()
        CType(Me.uce_Generico, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ug_Lista, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.uds_Lista, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ToolS_Mantenimiento
        '
        Me.ToolS_Mantenimiento.BackColor = System.Drawing.Color.White
        Me.ToolS_Mantenimiento.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Tool_Imprimir, Me.ToolStripSeparator2, Me.Tool_Cancelar, Me.ToolStripSeparator1, Me.Tool_Salir})
        Me.ToolS_Mantenimiento.Location = New System.Drawing.Point(0, 0)
        Me.ToolS_Mantenimiento.Name = "ToolS_Mantenimiento"
        Me.ToolS_Mantenimiento.Size = New System.Drawing.Size(779, 25)
        Me.ToolS_Mantenimiento.TabIndex = 168
        Me.ToolS_Mantenimiento.Text = "ToolStrip1"
        '
        'Tool_Imprimir
        '
        Me.Tool_Imprimir.Image = Global.Contabilidad.My.Resources.Resources._004
        Me.Tool_Imprimir.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Tool_Imprimir.Name = "Tool_Imprimir"
        Me.Tool_Imprimir.Size = New System.Drawing.Size(73, 22)
        Me.Tool_Imprimir.Text = "Imprimir"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'Tool_Cancelar
        '
        Me.Tool_Cancelar.Image = Global.Contabilidad.My.Resources.Resources._16__Cancel_
        Me.Tool_Cancelar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Tool_Cancelar.Name = "Tool_Cancelar"
        Me.Tool_Cancelar.Size = New System.Drawing.Size(73, 22)
        Me.Tool_Cancelar.Text = "Cancelar"
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
        Me.Tool_Salir.Size = New System.Drawing.Size(49, 22)
        Me.Tool_Salir.Text = "Salir"
        '
        'uds_ListaDet
        '
        Me.uds_ListaDet.AllowDelete = False
        UltraDataColumn1.DataType = GetType(Integer)
        Me.uds_ListaDet.Band.Columns.AddRange(New Object() {UltraDataColumn1, UltraDataColumn2, UltraDataColumn3, UltraDataColumn4, UltraDataColumn5})
        '
        'ug_ListaDet
        '
        Me.ug_ListaDet.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ug_ListaDet.DataSource = Me.uds_ListaDet
        Me.ug_ListaDet.DisplayLayout.AutoFitStyle = Infragistics.Win.UltraWinGrid.AutoFitStyle.ExtendLastColumn
        UltraGridColumn1.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn1.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        Appearance1.TextHAlignAsString = "Center"
        UltraGridColumn1.CellAppearance = Appearance1
        UltraGridColumn1.Header.Caption = "Código"
        UltraGridColumn1.Header.VisiblePosition = 0
        UltraGridColumn1.Width = 78
        UltraGridColumn2.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn2.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn2.Header.Caption = "Descripcion"
        UltraGridColumn2.Header.VisiblePosition = 1
        UltraGridColumn2.Width = 400
        UltraGridColumn3.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn3.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn3.Header.Caption = "CUM"
        UltraGridColumn3.Header.VisiblePosition = 2
        UltraGridColumn3.MaskInput = ""
        UltraGridColumn4.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn4.Header.Caption = "U.M.  Compra"
        UltraGridColumn4.Header.VisiblePosition = 3
        UltraGridColumn4.Width = 76
        UltraGridColumn5.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn5.Header.Caption = "U.M. Venta"
        UltraGridColumn5.Header.VisiblePosition = 4
        UltraGridColumn5.Width = 71
        UltraGridBand1.Columns.AddRange(New Object() {UltraGridColumn1, UltraGridColumn2, UltraGridColumn3, UltraGridColumn4, UltraGridColumn5})
        Me.ug_ListaDet.DisplayLayout.BandsSerializer.Add(UltraGridBand1)
        Me.ug_ListaDet.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.[True]
        Me.ug_ListaDet.DisplayLayout.MaxColScrollRegions = 1
        Me.ug_ListaDet.DisplayLayout.MaxRowScrollRegions = 1
        Appearance18.BackColor = System.Drawing.Color.WhiteSmoke
        Appearance18.BackColor2 = System.Drawing.Color.WhiteSmoke
        Me.ug_ListaDet.DisplayLayout.Override.RowAlternateAppearance = Appearance18
        Me.ug_ListaDet.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.ug_ListaDet.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.ug_ListaDet.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ug_ListaDet.Location = New System.Drawing.Point(11, 269)
        Me.ug_ListaDet.Name = "ug_ListaDet"
        Me.ug_ListaDet.Size = New System.Drawing.Size(756, 157)
        Me.ug_ListaDet.TabIndex = 169
        Me.ug_ListaDet.Text = "Detalle de Medicamentos"
        '
        'UltraGroupBox1
        '
        Me.UltraGroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.UltraGroupBox1.Controls.Add(Me.ubtn_Quitar)
        Me.UltraGroupBox1.Controls.Add(Me.uce_Generico)
        Me.UltraGroupBox1.Controls.Add(Me.UltraLabel38)
        Me.UltraGroupBox1.Controls.Add(Me.ubtn_Consultar)
        Me.UltraGroupBox1.Location = New System.Drawing.Point(11, 30)
        Me.UltraGroupBox1.Name = "UltraGroupBox1"
        Me.UltraGroupBox1.Size = New System.Drawing.Size(756, 39)
        Me.UltraGroupBox1.TabIndex = 170
        '
        'ubtn_Quitar
        '
        Me.ubtn_Quitar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Appearance54.FontData.SizeInPoints = 8.0!
        Appearance54.ImageHAlign = Infragistics.Win.HAlign.Left
        Me.ubtn_Quitar.Appearance = Appearance54
        Me.ubtn_Quitar.Location = New System.Drawing.Point(679, 9)
        Me.ubtn_Quitar.Name = "ubtn_Quitar"
        Me.ubtn_Quitar.Size = New System.Drawing.Size(71, 24)
        Me.ubtn_Quitar.TabIndex = 28
        Me.ubtn_Quitar.Text = "Quitar"
        '
        'uce_Generico
        '
        Me.uce_Generico.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.uce_Generico.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.uce_Generico.Location = New System.Drawing.Point(68, 10)
        Me.uce_Generico.Name = "uce_Generico"
        Me.uce_Generico.Size = New System.Drawing.Size(494, 21)
        Me.uce_Generico.TabIndex = 27
        '
        'UltraLabel38
        '
        Appearance49.BackColor = System.Drawing.Color.Transparent
        Appearance49.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel38.Appearance = Appearance49
        Me.UltraLabel38.AutoSize = True
        Me.UltraLabel38.Location = New System.Drawing.Point(6, 14)
        Me.UltraLabel38.Name = "UltraLabel38"
        Me.UltraLabel38.Size = New System.Drawing.Size(50, 14)
        Me.UltraLabel38.TabIndex = 26
        Me.UltraLabel38.Text = "Genérico"
        '
        'ubtn_Consultar
        '
        Me.ubtn_Consultar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Appearance3.FontData.SizeInPoints = 8.0!
        Appearance3.ImageHAlign = Infragistics.Win.HAlign.Left
        Me.ubtn_Consultar.Appearance = Appearance3
        Me.ubtn_Consultar.Location = New System.Drawing.Point(603, 9)
        Me.ubtn_Consultar.Name = "ubtn_Consultar"
        Me.ubtn_Consultar.Size = New System.Drawing.Size(71, 24)
        Me.ubtn_Consultar.TabIndex = 9
        Me.ubtn_Consultar.Text = "Agregar"
        '
        'ug_Lista
        '
        Me.ug_Lista.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ug_Lista.DataSource = Me.uds_Lista
        Me.ug_Lista.DisplayLayout.AutoFitStyle = Infragistics.Win.UltraWinGrid.AutoFitStyle.ExtendLastColumn
        UltraGridColumn6.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn6.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn6.Header.Caption = "Código"
        UltraGridColumn6.Header.VisiblePosition = 0
        UltraGridColumn6.Width = 85
        UltraGridColumn7.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn7.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn7.Header.Caption = "Descripcion"
        UltraGridColumn7.Header.VisiblePosition = 1
        UltraGridColumn7.Width = 60
        UltraGridBand2.Columns.AddRange(New Object() {UltraGridColumn6, UltraGridColumn7})
        Me.ug_Lista.DisplayLayout.BandsSerializer.Add(UltraGridBand2)
        Me.ug_Lista.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.[False]
        Me.ug_Lista.DisplayLayout.MaxColScrollRegions = 1
        Me.ug_Lista.DisplayLayout.MaxRowScrollRegions = 1
        Me.ug_Lista.DisplayLayout.Override.FilterUIType = Infragistics.Win.UltraWinGrid.FilterUIType.FilterRow
        Appearance6.BackColor = System.Drawing.Color.WhiteSmoke
        Appearance6.BackColor2 = System.Drawing.Color.WhiteSmoke
        Me.ug_Lista.DisplayLayout.Override.RowAlternateAppearance = Appearance6
        Me.ug_Lista.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.ug_Lista.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.ug_Lista.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ug_Lista.Location = New System.Drawing.Point(12, 74)
        Me.ug_Lista.Name = "ug_Lista"
        Me.ug_Lista.Size = New System.Drawing.Size(755, 190)
        Me.ug_Lista.TabIndex = 167
        Me.ug_Lista.Text = "UltraGrid1"
        '
        'uds_Lista
        '
        UltraDataColumn6.DataType = GetType(Integer)
        Me.uds_Lista.Band.Columns.AddRange(New Object() {UltraDataColumn6, UltraDataColumn7})
        '
        'LO_RE_Generico_Equivalencia
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(779, 431)
        Me.Controls.Add(Me.ToolS_Mantenimiento)
        Me.Controls.Add(Me.ug_ListaDet)
        Me.Controls.Add(Me.UltraGroupBox1)
        Me.Controls.Add(Me.ug_Lista)
        Me.Name = "LO_RE_Generico_Equivalencia"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Medicamentos por Genéricos"
        Me.ToolS_Mantenimiento.ResumeLayout(False)
        Me.ToolS_Mantenimiento.PerformLayout()
        CType(Me.uds_ListaDet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ug_ListaDet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UltraGroupBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraGroupBox1.ResumeLayout(False)
        Me.UltraGroupBox1.PerformLayout()
        CType(Me.uce_Generico, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ug_Lista, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.uds_Lista, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolS_Mantenimiento As System.Windows.Forms.ToolStrip
    Friend WithEvents Tool_Cancelar As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents Tool_Salir As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents uds_ListaDet As Infragistics.Win.UltraWinDataSource.UltraDataSource
    Friend WithEvents ug_ListaDet As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents UltraGroupBox1 As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents ubtn_Consultar As Infragistics.Win.Misc.UltraButton
    Friend WithEvents ug_Lista As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents uds_Lista As Infragistics.Win.UltraWinDataSource.UltraDataSource
    Friend WithEvents Tool_Imprimir As System.Windows.Forms.ToolStripButton
    Friend WithEvents ubtn_Quitar As Infragistics.Win.Misc.UltraButton
    Public WithEvents uce_Generico As Infragistics.Win.UltraWinEditors.UltraComboEditor
    Friend WithEvents UltraLabel38 As Infragistics.Win.Misc.UltraLabel
End Class
