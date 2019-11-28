<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LO_RE_ComprasXVencer
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
        Dim Appearance5 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance7 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance10 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridBand1 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1)
        Dim UltraGridColumn1 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("1")
        Dim UltraGridColumn2 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("2")
        Dim UltraGridColumn3 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("3")
        Dim UltraGridColumn4 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("4")
        Dim UltraGridColumn5 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("5")
        Dim UltraGridColumn6 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("D1")
        Dim SummarySettings1 As Infragistics.Win.UltraWinGrid.SummarySettings = New Infragistics.Win.UltraWinGrid.SummarySettings("", Infragistics.Win.UltraWinGrid.SummaryType.Sum, Nothing, "D1", 5, True, "Band 0", 0, Infragistics.Win.UltraWinGrid.SummaryPosition.UseSummaryPositionColumn, "D1", 5, True)
        Dim Appearance1 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance3 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraDataColumn1 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("1")
        Dim UltraDataColumn2 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("2")
        Dim UltraDataColumn3 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("3")
        Dim UltraDataColumn4 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("4")
        Dim UltraDataColumn5 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("5")
        Dim UltraDataColumn6 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("D1")
        Me.uck_Totalizar = New Infragistics.Win.UltraWinEditors.UltraCheckEditor()
        Me.UltraLabel1 = New Infragistics.Win.Misc.UltraLabel()
        Me.udtp_FechaFin = New Infragistics.Win.UltraWinEditors.UltraDateTimeEditor()
        Me.UltraLabel2 = New Infragistics.Win.Misc.UltraLabel()
        Me.udtp_fechaInicio = New Infragistics.Win.UltraWinEditors.UltraDateTimeEditor()
        Me.ug_data = New Infragistics.Win.UltraWinGrid.UltraGrid()
        Me.uds_Lista = New Infragistics.Win.UltraWinDataSource.UltraDataSource(Me.components)
        Me.ToolS_Mantenimiento = New System.Windows.Forms.ToolStrip()
        Me.Tool_Consultar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.Tool_Imprimir = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.Tool_Salir = New System.Windows.Forms.ToolStripButton()
        CType(Me.udtp_FechaFin, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.udtp_fechaInicio, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ug_data, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.uds_Lista, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolS_Mantenimiento.SuspendLayout()
        Me.SuspendLayout()
        '
        'uck_Totalizar
        '
        Me.uck_Totalizar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Appearance5.ForeColor = System.Drawing.Color.Navy
        Me.uck_Totalizar.Appearance = Appearance5
        Me.uck_Totalizar.BackColor = System.Drawing.Color.Transparent
        Me.uck_Totalizar.BackColorInternal = System.Drawing.Color.Transparent
        Me.uck_Totalizar.Location = New System.Drawing.Point(432, 34)
        Me.uck_Totalizar.Name = "uck_Totalizar"
        Me.uck_Totalizar.Size = New System.Drawing.Size(239, 22)
        Me.uck_Totalizar.TabIndex = 213
        Me.uck_Totalizar.Text = "Totalizar Por Proveedor"
        '
        'UltraLabel1
        '
        Appearance7.BackColor = System.Drawing.Color.Transparent
        Appearance7.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel1.Appearance = Appearance7
        Me.UltraLabel1.AutoSize = True
        Me.UltraLabel1.Location = New System.Drawing.Point(12, 38)
        Me.UltraLabel1.Name = "UltraLabel1"
        Me.UltraLabel1.Size = New System.Drawing.Size(68, 14)
        Me.UltraLabel1.TabIndex = 217
        Me.UltraLabel1.Text = "Fecha Inicio:"
        '
        'udtp_FechaFin
        '
        Me.udtp_FechaFin.DateTime = New Date(2014, 1, 28, 0, 0, 0, 0)
        Me.udtp_FechaFin.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.udtp_FechaFin.Location = New System.Drawing.Point(291, 32)
        Me.udtp_FechaFin.Name = "udtp_FechaFin"
        Me.udtp_FechaFin.Size = New System.Drawing.Size(112, 24)
        Me.udtp_FechaFin.TabIndex = 212
        Me.udtp_FechaFin.Value = New Date(2014, 1, 28, 0, 0, 0, 0)
        '
        'UltraLabel2
        '
        Appearance10.BackColor = System.Drawing.Color.Transparent
        Appearance10.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel2.Appearance = Appearance10
        Me.UltraLabel2.AutoSize = True
        Me.UltraLabel2.Location = New System.Drawing.Point(214, 38)
        Me.UltraLabel2.Name = "UltraLabel2"
        Me.UltraLabel2.Size = New System.Drawing.Size(71, 14)
        Me.UltraLabel2.TabIndex = 216
        Me.UltraLabel2.Text = "Fecha Hasta:"
        '
        'udtp_fechaInicio
        '
        Me.udtp_fechaInicio.DateTime = New Date(2014, 1, 28, 0, 0, 0, 0)
        Me.udtp_fechaInicio.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.udtp_fechaInicio.Location = New System.Drawing.Point(84, 32)
        Me.udtp_fechaInicio.Name = "udtp_fechaInicio"
        Me.udtp_fechaInicio.Size = New System.Drawing.Size(112, 24)
        Me.udtp_fechaInicio.TabIndex = 211
        Me.udtp_fechaInicio.Value = New Date(2014, 1, 28, 0, 0, 0, 0)
        '
        'ug_data
        '
        Me.ug_data.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ug_data.DataSource = Me.uds_Lista
        Me.ug_data.DisplayLayout.AutoFitStyle = Infragistics.Win.UltraWinGrid.AutoFitStyle.ExtendLastColumn
        UltraGridColumn1.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn1.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn1.Header.Caption = "Proveedor"
        UltraGridColumn1.Header.VisiblePosition = 0
        UltraGridColumn1.Width = 252
        UltraGridColumn2.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn2.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn2.Header.Caption = "R.U.C."
        UltraGridColumn2.Header.VisiblePosition = 1
        UltraGridColumn2.Width = 114
        UltraGridColumn3.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn3.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn3.Header.Caption = "Tipo Doc."
        UltraGridColumn3.Header.VisiblePosition = 2
        UltraGridColumn4.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn4.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn4.Header.Caption = "Serie"
        UltraGridColumn4.Header.VisiblePosition = 3
        UltraGridColumn4.Width = 95
        UltraGridColumn5.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn5.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn5.Header.Caption = "Numero"
        UltraGridColumn5.Header.VisiblePosition = 4
        UltraGridColumn5.Width = 121
        UltraGridColumn6.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn6.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn6.Header.Caption = "Importe"
        UltraGridColumn6.Header.VisiblePosition = 5
        UltraGridColumn6.Width = 70
        UltraGridBand1.Columns.AddRange(New Object() {UltraGridColumn1, UltraGridColumn2, UltraGridColumn3, UltraGridColumn4, UltraGridColumn5, UltraGridColumn6})
        SummarySettings1.DisplayFormat = "{0}"
        SummarySettings1.GroupBySummaryValueAppearance = Appearance1
        SummarySettings1.SummaryDisplayArea = Infragistics.Win.UltraWinGrid.SummaryDisplayAreas.BottomFixed
        UltraGridBand1.Summaries.AddRange(New Infragistics.Win.UltraWinGrid.SummarySettings() {SummarySettings1})
        UltraGridBand1.SummaryFooterCaption = "Total"
        Me.ug_data.DisplayLayout.BandsSerializer.Add(UltraGridBand1)
        Me.ug_data.DisplayLayout.MaxColScrollRegions = 1
        Me.ug_data.DisplayLayout.MaxRowScrollRegions = 1
        Me.ug_data.DisplayLayout.Override.AllowAddNew = Infragistics.Win.UltraWinGrid.AllowAddNew.No
        Me.ug_data.DisplayLayout.Override.AllowDelete = Infragistics.Win.DefaultableBoolean.[False]
        Me.ug_data.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.[False]
        Me.ug_data.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Appearance3.BackColor = System.Drawing.Color.WhiteSmoke
        Appearance3.BackColor2 = System.Drawing.Color.WhiteSmoke
        Me.ug_data.DisplayLayout.Override.RowAlternateAppearance = Appearance3
        Me.ug_data.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.ug_data.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.ug_data.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ug_data.Location = New System.Drawing.Point(12, 62)
        Me.ug_data.Name = "ug_data"
        Me.ug_data.Size = New System.Drawing.Size(831, 457)
        Me.ug_data.TabIndex = 215
        '
        'uds_Lista
        '
        Me.uds_Lista.AllowDelete = False
        UltraDataColumn6.DataType = GetType(Double)
        Me.uds_Lista.Band.Columns.AddRange(New Object() {UltraDataColumn1, UltraDataColumn2, UltraDataColumn3, UltraDataColumn4, UltraDataColumn5, UltraDataColumn6})
        '
        'ToolS_Mantenimiento
        '
        Me.ToolS_Mantenimiento.BackColor = System.Drawing.Color.White
        Me.ToolS_Mantenimiento.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Tool_Consultar, Me.ToolStripSeparator4, Me.Tool_Imprimir, Me.ToolStripSeparator1, Me.Tool_Salir})
        Me.ToolS_Mantenimiento.Location = New System.Drawing.Point(0, 0)
        Me.ToolS_Mantenimiento.Name = "ToolS_Mantenimiento"
        Me.ToolS_Mantenimiento.Size = New System.Drawing.Size(855, 25)
        Me.ToolS_Mantenimiento.TabIndex = 214
        Me.ToolS_Mantenimiento.Text = "ToolStrip1"
        '
        'Tool_Consultar
        '
        Me.Tool_Consultar.Image = Global.Contabilidad.My.Resources.Resources._16__Search_
        Me.Tool_Consultar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Tool_Consultar.Name = "Tool_Consultar"
        Me.Tool_Consultar.Size = New System.Drawing.Size(78, 22)
        Me.Tool_Consultar.Text = "Consultar"
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(6, 25)
        '
        'Tool_Imprimir
        '
        Me.Tool_Imprimir.Image = Global.Contabilidad.My.Resources.Resources.klpq_24x24_32
        Me.Tool_Imprimir.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Tool_Imprimir.Name = "Tool_Imprimir"
        Me.Tool_Imprimir.Size = New System.Drawing.Size(73, 22)
        Me.Tool_Imprimir.Text = "Imprimir"
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
        'LO_RE_ComprasXVencer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(855, 516)
        Me.Controls.Add(Me.uck_Totalizar)
        Me.Controls.Add(Me.UltraLabel1)
        Me.Controls.Add(Me.udtp_FechaFin)
        Me.Controls.Add(Me.UltraLabel2)
        Me.Controls.Add(Me.udtp_fechaInicio)
        Me.Controls.Add(Me.ug_data)
        Me.Controls.Add(Me.ToolS_Mantenimiento)
        Me.Name = "LO_RE_ComprasXVencer"
        Me.Text = "Comprobantes Pendientes Por Vencer"
        CType(Me.udtp_FechaFin, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.udtp_fechaInicio, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ug_data, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.uds_Lista, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolS_Mantenimiento.ResumeLayout(False)
        Me.ToolS_Mantenimiento.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents uck_Totalizar As Infragistics.Win.UltraWinEditors.UltraCheckEditor
    Friend WithEvents UltraLabel1 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents udtp_FechaFin As Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
    Friend WithEvents UltraLabel2 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents udtp_fechaInicio As Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
    Friend WithEvents ug_data As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents ToolS_Mantenimiento As System.Windows.Forms.ToolStrip
    Friend WithEvents Tool_Consultar As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents Tool_Imprimir As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents Tool_Salir As System.Windows.Forms.ToolStripButton
    Friend WithEvents uds_Lista As Infragistics.Win.UltraWinDataSource.UltraDataSource
End Class
