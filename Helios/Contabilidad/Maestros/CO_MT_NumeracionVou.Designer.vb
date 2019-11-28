<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CO_MT_NumeracionVou
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
        Dim UltraGridColumn1 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NV_IDSUBDIARIO")
        Dim UltraGridColumn2 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("SUBDIARIO")
        Dim UltraGridColumn3 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NV_ULTIMO_NUMERO")
        Dim Appearance5 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance2 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraDataColumn1 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("NV_IDSUBDIARIO")
        Dim UltraDataColumn2 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("SUBDIARIO")
        Dim UltraDataColumn3 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("NV_ULTIMO_NUMERO")
        Dim Appearance3 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance4 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance1 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance23 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance7 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraTab1 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraTab2 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Me.UltraTabPageControl1 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.ug_Numeracion = New Infragistics.Win.UltraWinGrid.UltraGrid()
        Me.uds_Numeracion = New Infragistics.Win.UltraWinDataSource.UltraDataSource(Me.components)
        Me.UltraTabPageControl2 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.UltraGroupBox1 = New Infragistics.Win.Misc.UltraGroupBox()
        Me.txt_subdiario = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.UltraLabel3 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraLabel2 = New Infragistics.Win.Misc.UltraLabel()
        Me.ugb_Parametros = New Infragistics.Win.Misc.UltraGroupBox()
        Me.une_Ayo = New Infragistics.Win.UltraWinEditors.UltraNumericEditor()
        Me.UltraLabel1 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraLabel4 = New Infragistics.Win.Misc.UltraLabel()
        Me.uce_Mes = New Infragistics.Win.UltraWinEditors.UltraComboEditor()
        Me.ToolS_Bancos = New System.Windows.Forms.ToolStrip()
        Me.Tool_Grabar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.Tool_Editar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.Tool_Cancelar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.Tool_Salir = New System.Windows.Forms.ToolStripButton()
        Me.utc_numeracion = New Infragistics.Win.UltraWinTabControl.UltraTabControl()
        Me.UltraTabSharedControlsPage1 = New Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage()
        Me.txt_ultimo_num = New Infragistics.Win.UltraWinEditors.UltraNumericEditor()
        Me.UltraTabPageControl1.SuspendLayout()
        CType(Me.ug_Numeracion, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.uds_Numeracion, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabPageControl2.SuspendLayout()
        CType(Me.UltraGroupBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraGroupBox1.SuspendLayout()
        CType(Me.txt_subdiario, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ugb_Parametros, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ugb_Parametros.SuspendLayout()
        CType(Me.une_Ayo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.uce_Mes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolS_Bancos.SuspendLayout()
        CType(Me.utc_numeracion, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.utc_numeracion.SuspendLayout()
        CType(Me.txt_ultimo_num, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'UltraTabPageControl1
        '
        Me.UltraTabPageControl1.Controls.Add(Me.ug_Numeracion)
        Me.UltraTabPageControl1.Location = New System.Drawing.Point(1, 23)
        Me.UltraTabPageControl1.Name = "UltraTabPageControl1"
        Me.UltraTabPageControl1.Size = New System.Drawing.Size(607, 262)
        '
        'ug_Numeracion
        '
        Me.ug_Numeracion.DataSource = Me.uds_Numeracion
        Me.ug_Numeracion.DisplayLayout.AutoFitStyle = Infragistics.Win.UltraWinGrid.AutoFitStyle.ExtendLastColumn
        UltraGridColumn1.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn1.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn1.Header.Caption = "Cod. Subdiario"
        UltraGridColumn1.Header.VisiblePosition = 0
        UltraGridColumn1.Width = 63
        UltraGridColumn2.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn2.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn2.Header.Caption = "Subdiario"
        UltraGridColumn2.Header.VisiblePosition = 1
        UltraGridColumn2.Width = 321
        UltraGridColumn3.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn3.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        Appearance5.TextHAlignAsString = "Right"
        UltraGridColumn3.CellAppearance = Appearance5
        UltraGridColumn3.Header.Caption = "Ultimo Numero"
        UltraGridColumn3.Header.VisiblePosition = 2
        UltraGridBand1.Columns.AddRange(New Object() {UltraGridColumn1, UltraGridColumn2, UltraGridColumn3})
        Me.ug_Numeracion.DisplayLayout.BandsSerializer.Add(UltraGridBand1)
        Me.ug_Numeracion.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.[False]
        Me.ug_Numeracion.DisplayLayout.MaxColScrollRegions = 1
        Me.ug_Numeracion.DisplayLayout.MaxRowScrollRegions = 1
        Appearance2.BackColor = System.Drawing.Color.WhiteSmoke
        Appearance2.BackColor2 = System.Drawing.Color.WhiteSmoke
        Me.ug_Numeracion.DisplayLayout.Override.RowAlternateAppearance = Appearance2
        Me.ug_Numeracion.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.ug_Numeracion.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.ug_Numeracion.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ug_Numeracion.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ug_Numeracion.Location = New System.Drawing.Point(0, 0)
        Me.ug_Numeracion.Name = "ug_Numeracion"
        Me.ug_Numeracion.Size = New System.Drawing.Size(607, 262)
        Me.ug_Numeracion.TabIndex = 9
        Me.ug_Numeracion.Text = "UltraGrid1"
        '
        'uds_Numeracion
        '
        Me.uds_Numeracion.AllowDelete = False
        UltraDataColumn3.DataType = GetType(Double)
        Me.uds_Numeracion.Band.Columns.AddRange(New Object() {UltraDataColumn1, UltraDataColumn2, UltraDataColumn3})
        '
        'UltraTabPageControl2
        '
        Me.UltraTabPageControl2.Controls.Add(Me.UltraGroupBox1)
        Me.UltraTabPageControl2.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl2.Name = "UltraTabPageControl2"
        Me.UltraTabPageControl2.Size = New System.Drawing.Size(607, 262)
        '
        'UltraGroupBox1
        '
        Me.UltraGroupBox1.Controls.Add(Me.txt_ultimo_num)
        Me.UltraGroupBox1.Controls.Add(Me.txt_subdiario)
        Me.UltraGroupBox1.Controls.Add(Me.UltraLabel3)
        Me.UltraGroupBox1.Controls.Add(Me.UltraLabel2)
        Me.UltraGroupBox1.Location = New System.Drawing.Point(14, 21)
        Me.UltraGroupBox1.Name = "UltraGroupBox1"
        Me.UltraGroupBox1.Size = New System.Drawing.Size(580, 101)
        Me.UltraGroupBox1.TabIndex = 0
        '
        'txt_subdiario
        '
        Me.txt_subdiario.Location = New System.Drawing.Point(153, 25)
        Me.txt_subdiario.Name = "txt_subdiario"
        Me.txt_subdiario.ReadOnly = True
        Me.txt_subdiario.Size = New System.Drawing.Size(334, 21)
        Me.txt_subdiario.TabIndex = 1
        '
        'UltraLabel3
        '
        Appearance3.BackColor = System.Drawing.Color.Transparent
        Me.UltraLabel3.Appearance = Appearance3
        Me.UltraLabel3.AutoSize = True
        Me.UltraLabel3.Location = New System.Drawing.Point(47, 56)
        Me.UltraLabel3.Name = "UltraLabel3"
        Me.UltraLabel3.Size = New System.Drawing.Size(80, 14)
        Me.UltraLabel3.TabIndex = 0
        Me.UltraLabel3.Text = "Ultimo Numero"
        '
        'UltraLabel2
        '
        Appearance4.BackColor = System.Drawing.Color.Transparent
        Me.UltraLabel2.Appearance = Appearance4
        Me.UltraLabel2.AutoSize = True
        Me.UltraLabel2.Location = New System.Drawing.Point(47, 29)
        Me.UltraLabel2.Name = "UltraLabel2"
        Me.UltraLabel2.Size = New System.Drawing.Size(52, 14)
        Me.UltraLabel2.TabIndex = 0
        Me.UltraLabel2.Text = "Subdiario"
        '
        'ugb_Parametros
        '
        Me.ugb_Parametros.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ugb_Parametros.Controls.Add(Me.une_Ayo)
        Me.ugb_Parametros.Controls.Add(Me.UltraLabel1)
        Me.ugb_Parametros.Controls.Add(Me.UltraLabel4)
        Me.ugb_Parametros.Controls.Add(Me.uce_Mes)
        Me.ugb_Parametros.Location = New System.Drawing.Point(12, 37)
        Me.ugb_Parametros.Name = "ugb_Parametros"
        Me.ugb_Parametros.Size = New System.Drawing.Size(611, 44)
        Me.ugb_Parametros.TabIndex = 7
        '
        'une_Ayo
        '
        Appearance1.TextHAlignAsString = "Center"
        Me.une_Ayo.Appearance = Appearance1
        Me.une_Ayo.Location = New System.Drawing.Point(48, 13)
        Me.une_Ayo.MaskInput = "nnnn"
        Me.une_Ayo.Name = "une_Ayo"
        Me.une_Ayo.ReadOnly = True
        Me.une_Ayo.Size = New System.Drawing.Size(46, 21)
        Me.une_Ayo.TabIndex = 13
        '
        'UltraLabel1
        '
        Appearance23.BackColor = System.Drawing.Color.Transparent
        Appearance23.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel1.Appearance = Appearance23
        Me.UltraLabel1.AutoSize = True
        Me.UltraLabel1.Location = New System.Drawing.Point(15, 17)
        Me.UltraLabel1.Name = "UltraLabel1"
        Me.UltraLabel1.Size = New System.Drawing.Size(30, 14)
        Me.UltraLabel1.TabIndex = 12
        Me.UltraLabel1.Text = "Año :"
        '
        'UltraLabel4
        '
        Appearance7.BackColor = System.Drawing.Color.Transparent
        Appearance7.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel4.Appearance = Appearance7
        Me.UltraLabel4.AutoSize = True
        Me.UltraLabel4.Location = New System.Drawing.Point(129, 17)
        Me.UltraLabel4.Name = "UltraLabel4"
        Me.UltraLabel4.Size = New System.Drawing.Size(32, 14)
        Me.UltraLabel4.TabIndex = 12
        Me.UltraLabel4.Text = "Mes :"
        '
        'uce_Mes
        '
        Me.uce_Mes.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.uce_Mes.Location = New System.Drawing.Point(167, 13)
        Me.uce_Mes.Name = "uce_Mes"
        Me.uce_Mes.Size = New System.Drawing.Size(161, 21)
        Me.uce_Mes.TabIndex = 0
        '
        'ToolS_Bancos
        '
        Me.ToolS_Bancos.BackColor = System.Drawing.Color.White
        Me.ToolS_Bancos.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Tool_Grabar, Me.ToolStripSeparator3, Me.Tool_Editar, Me.ToolStripSeparator4, Me.Tool_Cancelar, Me.ToolStripSeparator2, Me.Tool_Salir})
        Me.ToolS_Bancos.Location = New System.Drawing.Point(0, 0)
        Me.ToolS_Bancos.Name = "ToolS_Bancos"
        Me.ToolS_Bancos.Size = New System.Drawing.Size(635, 25)
        Me.ToolS_Bancos.TabIndex = 8
        Me.ToolS_Bancos.Text = "ToolStrip1"
        '
        'Tool_Grabar
        '
        Me.Tool_Grabar.Image = Global.Contabilidad.My.Resources.Resources._003
        Me.Tool_Grabar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Tool_Grabar.Name = "Tool_Grabar"
        Me.Tool_Grabar.Size = New System.Drawing.Size(60, 22)
        Me.Tool_Grabar.Text = "Grabar"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 25)
        '
        'Tool_Editar
        '
        Me.Tool_Editar.Image = Global.Contabilidad.My.Resources.Resources._16__Card_edit_
        Me.Tool_Editar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Tool_Editar.Name = "Tool_Editar"
        Me.Tool_Editar.Size = New System.Drawing.Size(55, 22)
        Me.Tool_Editar.Text = "Editar"
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(6, 25)
        '
        'Tool_Cancelar
        '
        Me.Tool_Cancelar.Image = Global.Contabilidad.My.Resources.Resources._16__Cancel_
        Me.Tool_Cancelar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Tool_Cancelar.Name = "Tool_Cancelar"
        Me.Tool_Cancelar.Size = New System.Drawing.Size(69, 22)
        Me.Tool_Cancelar.Text = "Cancelar"
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
        'utc_numeracion
        '
        Me.utc_numeracion.Controls.Add(Me.UltraTabSharedControlsPage1)
        Me.utc_numeracion.Controls.Add(Me.UltraTabPageControl1)
        Me.utc_numeracion.Controls.Add(Me.UltraTabPageControl2)
        Me.utc_numeracion.Location = New System.Drawing.Point(12, 87)
        Me.utc_numeracion.Name = "utc_numeracion"
        Me.utc_numeracion.SharedControlsPage = Me.UltraTabSharedControlsPage1
        Me.utc_numeracion.Size = New System.Drawing.Size(611, 288)
        Me.utc_numeracion.TabIndex = 10
        UltraTab1.TabPage = Me.UltraTabPageControl1
        UltraTab1.Text = "Lista de Numeracion por Subdiarios"
        UltraTab2.TabPage = Me.UltraTabPageControl2
        UltraTab2.Text = "Edicion de Datos"
        Me.utc_numeracion.Tabs.AddRange(New Infragistics.Win.UltraWinTabControl.UltraTab() {UltraTab1, UltraTab2})
        '
        'UltraTabSharedControlsPage1
        '
        Me.UltraTabSharedControlsPage1.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabSharedControlsPage1.Name = "UltraTabSharedControlsPage1"
        Me.UltraTabSharedControlsPage1.Size = New System.Drawing.Size(607, 262)
        '
        'txt_ultimo_num
        '
        Me.txt_ultimo_num.Location = New System.Drawing.Point(152, 52)
        Me.txt_ultimo_num.Name = "txt_ultimo_num"
        Me.txt_ultimo_num.Size = New System.Drawing.Size(100, 21)
        Me.txt_ultimo_num.TabIndex = 2
        '
        'CO_MT_NumeracionVou
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(635, 377)
        Me.Controls.Add(Me.utc_numeracion)
        Me.Controls.Add(Me.ToolS_Bancos)
        Me.Controls.Add(Me.ugb_Parametros)
        Me.Name = "CO_MT_NumeracionVou"
        Me.Text = "Numeracion de Voucher"
        Me.UltraTabPageControl1.ResumeLayout(False)
        CType(Me.ug_Numeracion, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.uds_Numeracion, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabPageControl2.ResumeLayout(False)
        CType(Me.UltraGroupBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraGroupBox1.ResumeLayout(False)
        Me.UltraGroupBox1.PerformLayout()
        CType(Me.txt_subdiario, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ugb_Parametros, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ugb_Parametros.ResumeLayout(False)
        Me.ugb_Parametros.PerformLayout()
        CType(Me.une_Ayo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.uce_Mes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolS_Bancos.ResumeLayout(False)
        Me.ToolS_Bancos.PerformLayout()
        CType(Me.utc_numeracion, System.ComponentModel.ISupportInitialize).EndInit()
        Me.utc_numeracion.ResumeLayout(False)
        CType(Me.txt_ultimo_num, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ugb_Parametros As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents une_Ayo As Infragistics.Win.UltraWinEditors.UltraNumericEditor
    Friend WithEvents UltraLabel1 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel4 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents uce_Mes As Infragistics.Win.UltraWinEditors.UltraComboEditor
    Friend WithEvents ToolS_Bancos As System.Windows.Forms.ToolStrip
    Friend WithEvents Tool_Grabar As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents Tool_Editar As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents Tool_Cancelar As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents Tool_Salir As System.Windows.Forms.ToolStripButton
    Friend WithEvents uds_Numeracion As Infragistics.Win.UltraWinDataSource.UltraDataSource
    Friend WithEvents ug_Numeracion As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents utc_numeracion As Infragistics.Win.UltraWinTabControl.UltraTabControl
    Friend WithEvents UltraTabSharedControlsPage1 As Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage
    Friend WithEvents UltraTabPageControl1 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents UltraTabPageControl2 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents UltraGroupBox1 As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents txt_subdiario As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents UltraLabel3 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel2 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents txt_ultimo_num As Infragistics.Win.UltraWinEditors.UltraNumericEditor
End Class
