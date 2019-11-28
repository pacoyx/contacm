<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PL_PR_Calculo_5ta
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
        Dim EditorButton1 As Infragistics.Win.UltraWinEditors.EditorButton = New Infragistics.Win.UltraWinEditors.EditorButton()
        Dim Appearance6 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance4 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance23 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance12 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraDataColumn1 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("CODIGO")
        Dim UltraDataColumn2 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("NOMBRES")
        Dim UltraDataColumn3 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("VALOR")
        Dim UltraGridBand1 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1)
        Dim UltraGridColumn1 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CODIGO")
        Dim UltraGridColumn2 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NOMBRES")
        Dim UltraGridColumn3 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("VALOR")
        Dim Appearance2 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.Tool_Procesar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.Tool_Exportar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.Tool_Imprimir = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator6 = New System.Windows.Forms.ToolStripSeparator()
        Me.Tool_Salir = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator()
        Me.ugb_Parametros = New Infragistics.Win.Misc.UltraGroupBox()
        Me.txt_idpersonal = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.une_Ayo = New Infragistics.Win.UltraWinEditors.UltraNumericEditor()
        Me.txt_nombres = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.uchk_Todos = New Infragistics.Win.UltraWinEditors.UltraCheckEditor()
        Me.txt_codper = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.UltraLabel7 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraLabel1 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraLabel8 = New Infragistics.Win.Misc.UltraLabel()
        Me.uce_TipoPersonal = New Infragistics.Win.UltraWinEditors.UltraComboEditor()
        Me.uce_Mes = New Infragistics.Win.UltraWinEditors.UltraComboEditor()
        Me.uds_Lista = New Infragistics.Win.UltraWinDataSource.UltraDataSource(Me.components)
        Me.ug_5ta = New Infragistics.Win.UltraWinGrid.UltraGrid()
        Me.upb_1 = New Infragistics.Win.UltraWinProgressBar.UltraProgressBar()
        Me.uge_5ta = New Infragistics.Win.UltraWinGrid.ExcelExport.UltraGridExcelExporter(Me.components)
        Me.ToolStrip1.SuspendLayout()
        CType(Me.ugb_Parametros, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ugb_Parametros.SuspendLayout()
        CType(Me.txt_idpersonal, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.une_Ayo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_nombres, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_codper, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.uce_TipoPersonal, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.uce_Mes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.uds_Lista, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ug_5ta, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ToolStrip1
        '
        Me.ToolStrip1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripSeparator3, Me.Tool_Procesar, Me.ToolStripSeparator2, Me.Tool_Exportar, Me.ToolStripSeparator1, Me.Tool_Imprimir, Me.ToolStripSeparator6, Me.Tool_Salir, Me.ToolStripSeparator5})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(796, 25)
        Me.ToolStrip1.TabIndex = 13
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
        'Tool_Exportar
        '
        Me.Tool_Exportar.Image = Global.Contabilidad.My.Resources.Resources._16__Doc_excel_
        Me.Tool_Exportar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Tool_Exportar.Name = "Tool_Exportar"
        Me.Tool_Exportar.Size = New System.Drawing.Size(69, 22)
        Me.Tool_Exportar.Text = "Exportar"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'Tool_Imprimir
        '
        Me.Tool_Imprimir.Image = Global.Contabilidad.My.Resources.Resources._004
        Me.Tool_Imprimir.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Tool_Imprimir.Name = "Tool_Imprimir"
        Me.Tool_Imprimir.Size = New System.Drawing.Size(65, 22)
        Me.Tool_Imprimir.Text = "Imprimir"
        '
        'ToolStripSeparator6
        '
        Me.ToolStripSeparator6.Name = "ToolStripSeparator6"
        Me.ToolStripSeparator6.Size = New System.Drawing.Size(6, 25)
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
        'ugb_Parametros
        '
        Me.ugb_Parametros.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ugb_Parametros.Controls.Add(Me.txt_idpersonal)
        Me.ugb_Parametros.Controls.Add(Me.une_Ayo)
        Me.ugb_Parametros.Controls.Add(Me.txt_nombres)
        Me.ugb_Parametros.Controls.Add(Me.uchk_Todos)
        Me.ugb_Parametros.Controls.Add(Me.txt_codper)
        Me.ugb_Parametros.Controls.Add(Me.UltraLabel7)
        Me.ugb_Parametros.Controls.Add(Me.UltraLabel1)
        Me.ugb_Parametros.Controls.Add(Me.UltraLabel8)
        Me.ugb_Parametros.Controls.Add(Me.uce_TipoPersonal)
        Me.ugb_Parametros.Controls.Add(Me.uce_Mes)
        Me.ugb_Parametros.Location = New System.Drawing.Point(12, 28)
        Me.ugb_Parametros.Name = "ugb_Parametros"
        Me.ugb_Parametros.Size = New System.Drawing.Size(774, 36)
        Me.ugb_Parametros.TabIndex = 14
        Me.ugb_Parametros.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.XP
        '
        'txt_idpersonal
        '
        Me.txt_idpersonal.Location = New System.Drawing.Point(272, 7)
        Me.txt_idpersonal.Name = "txt_idpersonal"
        Me.txt_idpersonal.Size = New System.Drawing.Size(15, 21)
        Me.txt_idpersonal.TabIndex = 15
        Me.txt_idpersonal.Visible = False
        '
        'une_Ayo
        '
        Appearance1.TextHAlignAsString = "Center"
        Me.une_Ayo.Appearance = Appearance1
        Me.une_Ayo.Location = New System.Drawing.Point(41, 6)
        Me.une_Ayo.MaskInput = "nnnn"
        Me.une_Ayo.Name = "une_Ayo"
        Me.une_Ayo.ReadOnly = True
        Me.une_Ayo.Size = New System.Drawing.Size(36, 21)
        Me.une_Ayo.TabIndex = 13
        '
        'txt_nombres
        '
        Me.txt_nombres.Location = New System.Drawing.Point(504, 6)
        Me.txt_nombres.Name = "txt_nombres"
        Me.txt_nombres.ReadOnly = True
        Me.txt_nombres.Size = New System.Drawing.Size(187, 21)
        Me.txt_nombres.TabIndex = 1
        '
        'uchk_Todos
        '
        Me.uchk_Todos.BackColor = System.Drawing.Color.Transparent
        Me.uchk_Todos.BackColorInternal = System.Drawing.Color.Transparent
        Me.uchk_Todos.Checked = True
        Me.uchk_Todos.CheckState = System.Windows.Forms.CheckState.Checked
        Me.uchk_Todos.Location = New System.Drawing.Point(697, 9)
        Me.uchk_Todos.Name = "uchk_Todos"
        Me.uchk_Todos.Size = New System.Drawing.Size(59, 17)
        Me.uchk_Todos.TabIndex = 15
        Me.uchk_Todos.Text = "Todos"
        '
        'txt_codper
        '
        Appearance6.ImageHAlign = Infragistics.Win.HAlign.Center
        EditorButton1.Appearance = Appearance6
        Me.txt_codper.ButtonsRight.Add(EditorButton1)
        Me.txt_codper.Location = New System.Drawing.Point(426, 6)
        Me.txt_codper.Name = "txt_codper"
        Me.txt_codper.Size = New System.Drawing.Size(78, 21)
        Me.txt_codper.TabIndex = 1
        '
        'UltraLabel7
        '
        Appearance4.BackColor = System.Drawing.Color.Transparent
        Appearance4.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel7.Appearance = Appearance4
        Me.UltraLabel7.AutoSize = True
        Me.UltraLabel7.Location = New System.Drawing.Point(11, 10)
        Me.UltraLabel7.Name = "UltraLabel7"
        Me.UltraLabel7.Size = New System.Drawing.Size(27, 14)
        Me.UltraLabel7.TabIndex = 12
        Me.UltraLabel7.Text = "Año:"
        '
        'UltraLabel1
        '
        Appearance23.BackColor = System.Drawing.Color.Transparent
        Appearance23.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel1.Appearance = Appearance23
        Me.UltraLabel1.AutoSize = True
        Me.UltraLabel1.Location = New System.Drawing.Point(293, 10)
        Me.UltraLabel1.Name = "UltraLabel1"
        Me.UltraLabel1.Size = New System.Drawing.Size(31, 14)
        Me.UltraLabel1.TabIndex = 12
        Me.UltraLabel1.Text = "Trab:"
        '
        'UltraLabel8
        '
        Appearance12.BackColor = System.Drawing.Color.Transparent
        Appearance12.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel8.Appearance = Appearance12
        Me.UltraLabel8.AutoSize = True
        Me.UltraLabel8.Location = New System.Drawing.Point(89, 11)
        Me.UltraLabel8.Name = "UltraLabel8"
        Me.UltraLabel8.Size = New System.Drawing.Size(32, 14)
        Me.UltraLabel8.TabIndex = 12
        Me.UltraLabel8.Text = "Mes :"
        '
        'uce_TipoPersonal
        '
        Me.uce_TipoPersonal.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.uce_TipoPersonal.Location = New System.Drawing.Point(327, 6)
        Me.uce_TipoPersonal.Name = "uce_TipoPersonal"
        Me.uce_TipoPersonal.Size = New System.Drawing.Size(99, 21)
        Me.uce_TipoPersonal.TabIndex = 14
        '
        'uce_Mes
        '
        Me.uce_Mes.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.uce_Mes.Location = New System.Drawing.Point(124, 7)
        Me.uce_Mes.Name = "uce_Mes"
        Me.uce_Mes.Size = New System.Drawing.Size(139, 21)
        Me.uce_Mes.TabIndex = 0
        '
        'uds_Lista
        '
        Me.uds_Lista.AllowDelete = False
        UltraDataColumn3.DataType = GetType(Double)
        Me.uds_Lista.Band.Columns.AddRange(New Object() {UltraDataColumn1, UltraDataColumn2, UltraDataColumn3})
        '
        'ug_5ta
        '
        Me.ug_5ta.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ug_5ta.DataSource = Me.uds_Lista
        Me.ug_5ta.DisplayLayout.AutoFitStyle = Infragistics.Win.UltraWinGrid.AutoFitStyle.ExtendLastColumn
        UltraGridColumn1.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn1.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn1.Header.VisiblePosition = 0
        UltraGridColumn1.Width = 93
        UltraGridColumn2.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn2.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn2.Header.VisiblePosition = 1
        UltraGridColumn2.Width = 371
        UltraGridColumn3.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn3.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        Appearance2.TextHAlignAsString = "Right"
        UltraGridColumn3.CellAppearance = Appearance2
        UltraGridColumn3.Header.VisiblePosition = 2
        UltraGridBand1.Columns.AddRange(New Object() {UltraGridColumn1, UltraGridColumn2, UltraGridColumn3})
        Me.ug_5ta.DisplayLayout.BandsSerializer.Add(UltraGridBand1)
        Me.ug_5ta.DisplayLayout.MaxColScrollRegions = 1
        Me.ug_5ta.DisplayLayout.MaxRowScrollRegions = 1
        Me.ug_5ta.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.ug_5ta.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.ug_5ta.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ug_5ta.Location = New System.Drawing.Point(12, 95)
        Me.ug_5ta.Name = "ug_5ta"
        Me.ug_5ta.Size = New System.Drawing.Size(774, 296)
        Me.ug_5ta.TabIndex = 15
        Me.ug_5ta.Text = "Lista de Personal"
        '
        'upb_1
        '
        Me.upb_1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.upb_1.Location = New System.Drawing.Point(12, 66)
        Me.upb_1.Name = "upb_1"
        Me.upb_1.Size = New System.Drawing.Size(774, 23)
        Me.upb_1.TabIndex = 18
        Me.upb_1.Text = "[Formatted]"
        '
        'PL_PR_Calculo_5ta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(796, 398)
        Me.Controls.Add(Me.upb_1)
        Me.Controls.Add(Me.ug_5ta)
        Me.Controls.Add(Me.ugb_Parametros)
        Me.Controls.Add(Me.ToolStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "PL_PR_Calculo_5ta"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Calculo 5ta Categoria"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        CType(Me.ugb_Parametros, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ugb_Parametros.ResumeLayout(False)
        Me.ugb_Parametros.PerformLayout()
        CType(Me.txt_idpersonal, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.une_Ayo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_nombres, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_codper, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.uce_TipoPersonal, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.uce_Mes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.uds_Lista, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ug_5ta, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents Tool_Procesar As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents Tool_Exportar As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents Tool_Imprimir As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator6 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents Tool_Salir As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator5 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ugb_Parametros As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents txt_idpersonal As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents une_Ayo As Infragistics.Win.UltraWinEditors.UltraNumericEditor
    Friend WithEvents txt_nombres As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents uchk_Todos As Infragistics.Win.UltraWinEditors.UltraCheckEditor
    Friend WithEvents txt_codper As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents UltraLabel7 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel1 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel8 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents uce_TipoPersonal As Infragistics.Win.UltraWinEditors.UltraComboEditor
    Friend WithEvents uce_Mes As Infragistics.Win.UltraWinEditors.UltraComboEditor
    Friend WithEvents uds_Lista As Infragistics.Win.UltraWinDataSource.UltraDataSource
    Friend WithEvents ug_5ta As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents upb_1 As Infragistics.Win.UltraWinProgressBar.UltraProgressBar
    Friend WithEvents uge_5ta As Infragistics.Win.UltraWinGrid.ExcelExport.UltraGridExcelExporter
End Class
