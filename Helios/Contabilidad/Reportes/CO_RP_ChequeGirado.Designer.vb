<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CO_RP_ChequeGirado
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
        Dim Appearance21 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance2 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance20 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraDataColumn1 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("NUM_CHEQUE")
        Dim UltraDataColumn2 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("GIRADO_A")
        Dim UltraDataColumn3 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("CONCEPTO")
        Dim UltraDataColumn4 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("FEC_EMISION")
        Dim UltraDataColumn5 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("MONTO")
        Dim UltraDataColumn6 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("NUM_VOUCHER")
        Dim UltraGridBand1 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1)
        Dim UltraGridColumn1 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NUM_CHEQUE")
        Dim UltraGridColumn2 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("GIRADO_A")
        Dim UltraGridColumn3 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CONCEPTO")
        Dim UltraGridColumn4 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FEC_EMISION")
        Dim Appearance8 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn5 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("MONTO")
        Dim Appearance9 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn6 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NUM_VOUCHER")
        Dim SummarySettings1 As Infragistics.Win.UltraWinGrid.SummarySettings = New Infragistics.Win.UltraWinGrid.SummarySettings("", Infragistics.Win.UltraWinGrid.SummaryType.Sum, Nothing, "MONTO", 4, True, "Band 0", 0, Infragistics.Win.UltraWinGrid.SummaryPosition.UseSummaryPositionColumn, "MONTO", 4, True)
        Dim Appearance10 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance11 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance3 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.Tool_consultar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.Tool_exportar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.Tool_salir = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.UltraLabel4 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraLabel3 = New Infragistics.Win.Misc.UltraLabel()
        Me.udte_f2 = New Infragistics.Win.UltraWinEditors.UltraDateTimeEditor()
        Me.udte_f1 = New Infragistics.Win.UltraWinEditors.UltraDateTimeEditor()
        Me.uce_banco = New Infragistics.Win.UltraWinEditors.UltraComboEditor()
        Me.uce_ctacte = New Infragistics.Win.UltraWinEditors.UltraComboEditor()
        Me.UltraLabel1 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraLabel2 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraGroupBox1 = New Infragistics.Win.Misc.UltraGroupBox()
        Me.uds_cheques = New Infragistics.Win.UltraWinDataSource.UltraDataSource(Me.components)
        Me.ug_cheques = New Infragistics.Win.UltraWinGrid.UltraGrid()
        Me.UltraGridExcelExporter1 = New Infragistics.Win.UltraWinGrid.ExcelExport.UltraGridExcelExporter(Me.components)
        Me.ToolStrip1.SuspendLayout()
        CType(Me.udte_f2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.udte_f1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.uce_banco, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.uce_ctacte, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UltraGroupBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraGroupBox1.SuspendLayout()
        CType(Me.uds_cheques, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ug_cheques, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ToolStrip1
        '
        Me.ToolStrip1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Tool_consultar, Me.ToolStripSeparator2, Me.Tool_exportar, Me.ToolStripSeparator1, Me.Tool_salir, Me.ToolStripSeparator3})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(762, 25)
        Me.ToolStrip1.TabIndex = 203
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'Tool_consultar
        '
        Me.Tool_consultar.Image = Global.Contabilidad.My.Resources.Resources._16__Build_
        Me.Tool_consultar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Tool_consultar.Name = "Tool_consultar"
        Me.Tool_consultar.Size = New System.Drawing.Size(78, 22)
        Me.Tool_consultar.Text = "Consultar"
        Me.Tool_consultar.ToolTipText = "Imprimir"
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
        Me.Tool_exportar.Size = New System.Drawing.Size(108, 22)
        Me.Tool_exportar.Text = "Exportar a Excel"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'Tool_salir
        '
        Me.Tool_salir.Image = Global.Contabilidad.My.Resources.Resources._28
        Me.Tool_salir.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Tool_salir.Name = "Tool_salir"
        Me.Tool_salir.Size = New System.Drawing.Size(49, 22)
        Me.Tool_salir.Text = "Salir"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 25)
        '
        'UltraLabel4
        '
        Appearance1.BackColor = System.Drawing.Color.Transparent
        Appearance1.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel4.Appearance = Appearance1
        Me.UltraLabel4.AutoSize = True
        Me.UltraLabel4.Location = New System.Drawing.Point(344, 13)
        Me.UltraLabel4.Name = "UltraLabel4"
        Me.UltraLabel4.Size = New System.Drawing.Size(51, 14)
        Me.UltraLabel4.TabIndex = 206
        Me.UltraLabel4.Text = "Fecha Ini"
        '
        'UltraLabel3
        '
        Appearance21.BackColor = System.Drawing.Color.Transparent
        Appearance21.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel3.Appearance = Appearance21
        Me.UltraLabel3.AutoSize = True
        Me.UltraLabel3.Location = New System.Drawing.Point(341, 36)
        Me.UltraLabel3.Name = "UltraLabel3"
        Me.UltraLabel3.Size = New System.Drawing.Size(54, 14)
        Me.UltraLabel3.TabIndex = 207
        Me.UltraLabel3.Text = "Fecha Fin"
        '
        'udte_f2
        '
        Me.udte_f2.Location = New System.Drawing.Point(401, 32)
        Me.udte_f2.Name = "udte_f2"
        Me.udte_f2.Size = New System.Drawing.Size(99, 21)
        Me.udte_f2.TabIndex = 205
        '
        'udte_f1
        '
        Me.udte_f1.Location = New System.Drawing.Point(401, 9)
        Me.udte_f1.Name = "udte_f1"
        Me.udte_f1.Size = New System.Drawing.Size(99, 21)
        Me.udte_f1.TabIndex = 204
        '
        'uce_banco
        '
        Me.uce_banco.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.uce_banco.Location = New System.Drawing.Point(92, 9)
        Me.uce_banco.Name = "uce_banco"
        Me.uce_banco.Size = New System.Drawing.Size(214, 21)
        Me.uce_banco.TabIndex = 208
        '
        'uce_ctacte
        '
        Me.uce_ctacte.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.uce_ctacte.Location = New System.Drawing.Point(92, 32)
        Me.uce_ctacte.Name = "uce_ctacte"
        Me.uce_ctacte.Size = New System.Drawing.Size(214, 21)
        Me.uce_ctacte.TabIndex = 208
        '
        'UltraLabel1
        '
        Appearance2.BackColor = System.Drawing.Color.Transparent
        Appearance2.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel1.Appearance = Appearance2
        Me.UltraLabel1.AutoSize = True
        Me.UltraLabel1.Location = New System.Drawing.Point(15, 13)
        Me.UltraLabel1.Name = "UltraLabel1"
        Me.UltraLabel1.Size = New System.Drawing.Size(36, 14)
        Me.UltraLabel1.TabIndex = 206
        Me.UltraLabel1.Text = "Banco"
        '
        'UltraLabel2
        '
        Appearance20.BackColor = System.Drawing.Color.Transparent
        Appearance20.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel2.Appearance = Appearance20
        Me.UltraLabel2.AutoSize = True
        Me.UltraLabel2.Location = New System.Drawing.Point(15, 36)
        Me.UltraLabel2.Name = "UltraLabel2"
        Me.UltraLabel2.Size = New System.Drawing.Size(64, 14)
        Me.UltraLabel2.TabIndex = 206
        Me.UltraLabel2.Text = "Cuenta Cte."
        '
        'UltraGroupBox1
        '
        Me.UltraGroupBox1.Controls.Add(Me.uce_ctacte)
        Me.UltraGroupBox1.Controls.Add(Me.uce_banco)
        Me.UltraGroupBox1.Controls.Add(Me.UltraLabel2)
        Me.UltraGroupBox1.Controls.Add(Me.UltraLabel1)
        Me.UltraGroupBox1.Controls.Add(Me.UltraLabel4)
        Me.UltraGroupBox1.Controls.Add(Me.UltraLabel3)
        Me.UltraGroupBox1.Controls.Add(Me.udte_f2)
        Me.UltraGroupBox1.Controls.Add(Me.udte_f1)
        Me.UltraGroupBox1.Location = New System.Drawing.Point(5, 31)
        Me.UltraGroupBox1.Name = "UltraGroupBox1"
        Me.UltraGroupBox1.Size = New System.Drawing.Size(745, 60)
        Me.UltraGroupBox1.TabIndex = 209
        '
        'uds_cheques
        '
        Me.uds_cheques.AllowAdd = False
        Me.uds_cheques.AllowDelete = False
        UltraDataColumn4.DataType = GetType(Date)
        UltraDataColumn5.DataType = GetType(Double)
        Me.uds_cheques.Band.Columns.AddRange(New Object() {UltraDataColumn1, UltraDataColumn2, UltraDataColumn3, UltraDataColumn4, UltraDataColumn5, UltraDataColumn6})
        '
        'ug_cheques
        '
        Me.ug_cheques.DataSource = Me.uds_cheques
        Me.ug_cheques.DisplayLayout.AutoFitStyle = Infragistics.Win.UltraWinGrid.AutoFitStyle.ExtendLastColumn
        UltraGridColumn1.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn1.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn1.Header.VisiblePosition = 0
        UltraGridColumn1.Width = 83
        UltraGridColumn2.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn2.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn2.Header.Caption = "GIRADO A"
        UltraGridColumn2.Header.VisiblePosition = 1
        UltraGridColumn2.Width = 191
        UltraGridColumn3.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn3.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn3.Header.VisiblePosition = 2
        UltraGridColumn3.Width = 169
        UltraGridColumn4.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn4.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        Appearance8.TextHAlignAsString = "Center"
        UltraGridColumn4.CellAppearance = Appearance8
        UltraGridColumn4.Header.Caption = "F. EMISION"
        UltraGridColumn4.Header.VisiblePosition = 3
        UltraGridColumn4.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Date]
        UltraGridColumn4.Width = 83
        UltraGridColumn5.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn5.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        Appearance9.TextHAlignAsString = "Right"
        UltraGridColumn5.CellAppearance = Appearance9
        UltraGridColumn5.Header.VisiblePosition = 4
        UltraGridColumn5.MaskDisplayMode = Infragistics.Win.UltraWinMaskedEdit.MaskMode.IncludeLiterals
        UltraGridColumn5.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Double]
        UltraGridColumn5.Width = 80
        UltraGridColumn6.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn6.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn6.Header.VisiblePosition = 5
        UltraGridColumn6.Width = 61
        UltraGridBand1.Columns.AddRange(New Object() {UltraGridColumn1, UltraGridColumn2, UltraGridColumn3, UltraGridColumn4, UltraGridColumn5, UltraGridColumn6})
        Appearance10.BackColor = System.Drawing.Color.White
        Appearance10.BackColor2 = System.Drawing.Color.White
        Appearance10.ForeColor = System.Drawing.Color.Navy
        Appearance10.TextHAlignAsString = "Right"
        SummarySettings1.Appearance = Appearance10
        SummarySettings1.DisplayFormat = "{0}"
        SummarySettings1.GroupBySummaryValueAppearance = Appearance11
        UltraGridBand1.Summaries.AddRange(New Infragistics.Win.UltraWinGrid.SummarySettings() {SummarySettings1})
        Me.ug_cheques.DisplayLayout.BandsSerializer.Add(UltraGridBand1)
        Me.ug_cheques.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.[False]
        Me.ug_cheques.DisplayLayout.MaxColScrollRegions = 1
        Me.ug_cheques.DisplayLayout.MaxRowScrollRegions = 1
        Appearance3.BackColor = System.Drawing.Color.WhiteSmoke
        Appearance3.BackColor2 = System.Drawing.Color.Gray
        Me.ug_cheques.DisplayLayout.Override.RowAlternateAppearance = Appearance3
        Me.ug_cheques.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.ug_cheques.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.ug_cheques.Location = New System.Drawing.Point(5, 97)
        Me.ug_cheques.Name = "ug_cheques"
        Me.ug_cheques.Size = New System.Drawing.Size(745, 250)
        Me.ug_cheques.TabIndex = 210
        Me.ug_cheques.Text = "UltraGrid1"
        '
        'CO_RP_ChequeGirado
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(762, 356)
        Me.Controls.Add(Me.ug_cheques)
        Me.Controls.Add(Me.UltraGroupBox1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "CO_RP_ChequeGirado"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cheques Girados"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        CType(Me.udte_f2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.udte_f1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.uce_banco, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.uce_ctacte, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UltraGroupBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraGroupBox1.ResumeLayout(False)
        Me.UltraGroupBox1.PerformLayout()
        CType(Me.uds_cheques, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ug_cheques, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents Tool_consultar As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents Tool_salir As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents UltraLabel4 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel3 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents udte_f2 As Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
    Friend WithEvents udte_f1 As Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
    Friend WithEvents uce_banco As Infragistics.Win.UltraWinEditors.UltraComboEditor
    Friend WithEvents uce_ctacte As Infragistics.Win.UltraWinEditors.UltraComboEditor
    Friend WithEvents UltraLabel1 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel2 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraGroupBox1 As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents uds_cheques As Infragistics.Win.UltraWinDataSource.UltraDataSource
    Friend WithEvents ug_cheques As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents Tool_exportar As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents UltraGridExcelExporter1 As Infragistics.Win.UltraWinGrid.ExcelExport.UltraGridExcelExporter
End Class
