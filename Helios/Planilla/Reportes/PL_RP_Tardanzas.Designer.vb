<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PL_RP_Tardanzas
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
        Dim Appearance3 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance2 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance14 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance5 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance15 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridBand1 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1)
        Dim UltraGridColumn1 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CODPER", -1, Nothing, 14541290, 3, 0)
        Dim UltraGridColumn2 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NOMBRES", -1, Nothing, 14541290, 1, 0)
        Dim UltraGridColumn3 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("APELLIDOS", -1, Nothing, 14541290, 2, 0)
        Dim UltraGridColumn4 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TOTAL_HRAS_TARDANZA", -1, Nothing, 14541291, 0, 0, 0, Infragistics.Win.UltraWinGrid.SortIndicator.Descending, False)
        Dim Appearance13 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn5 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("HORAS_TARDE", -1, Nothing, 14541291, 1, 0)
        Dim Appearance18 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn6 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("MINUTOS_TARDE", -1, Nothing, 14541291, 2, 0)
        Dim Appearance19 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn7 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TOTAL_MENOS45_MIN", -1, Nothing, 14541292, 0, 0)
        Dim Appearance20 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn8 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("HORAS", -1, Nothing, 14541292, 1, 0)
        Dim Appearance21 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn9 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("MINUTOS", -1, Nothing, 14541292, 2, 0)
        Dim Appearance22 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn10 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("DNI")
        Dim UltraGridColumn11 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ES_FT")
        Dim UltraGridColumn12 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("HORA_L", -1, Nothing, 14541292, 3, 0)
        Dim Appearance24 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn13 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("col_btn_detalle", 0, Nothing, 14541290, 0, 0)
        Dim UltraGridGroup1 As Infragistics.Win.UltraWinGrid.UltraGridGroup = New Infragistics.Win.UltraWinGrid.UltraGridGroup("PERSONAL", 14541290)
        Dim UltraGridGroup2 As Infragistics.Win.UltraWinGrid.UltraGridGroup = New Infragistics.Win.UltraWinGrid.UltraGridGroup("TARDANZA", 14541291)
        Dim UltraGridGroup3 As Infragistics.Win.UltraWinGrid.UltraGridGroup = New Infragistics.Win.UltraWinGrid.UltraGridGroup("CON TOLERANCIA DE 45 MIN", 14541292)
        Dim Appearance23 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraDataColumn1 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("CODPER")
        Dim UltraDataColumn2 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("NOMBRES")
        Dim UltraDataColumn3 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("APELLIDOS")
        Dim UltraDataColumn4 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("TOTAL_HRAS_TARDANZA")
        Dim UltraDataColumn5 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("HORAS_TARDE")
        Dim UltraDataColumn6 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("MINUTOS_TARDE")
        Dim UltraDataColumn7 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("TOTAL_MENOS45_MIN")
        Dim UltraDataColumn8 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("HORAS")
        Dim UltraDataColumn9 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("MINUTOS")
        Dim UltraDataColumn10 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("DNI")
        Dim UltraDataColumn11 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("ES_FT")
        Dim UltraDataColumn12 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("HORA_L")
        Dim Appearance4 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance17 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance8 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance16 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.Tool_Procesar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.Tool_imprimir = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.Tool_Salir = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ugb_Parametros = New Infragistics.Win.Misc.UltraGroupBox()
        Me.uchk_modificar = New Infragistics.Win.UltraWinEditors.UltraCheckEditor()
        Me.uce_TipoPersonal = New Infragistics.Win.UltraWinEditors.UltraComboEditor()
        Me.udte_fec_fin = New Infragistics.Win.UltraWinEditors.UltraDateTimeEditor()
        Me.UltraLabel2 = New Infragistics.Win.Misc.UltraLabel()
        Me.udte_fec_ini = New Infragistics.Win.UltraWinEditors.UltraDateTimeEditor()
        Me.une_Ayo = New Infragistics.Win.UltraWinEditors.UltraNumericEditor()
        Me.UltraLabel6 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraLabel5 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraLabel1 = New Infragistics.Win.Misc.UltraLabel()
        Me.uce_Mes = New Infragistics.Win.UltraWinEditors.UltraComboEditor()
        Me.upb_estado = New Infragistics.Win.UltraWinProgressBar.UltraProgressBar()
        Me.ug_exporta = New Infragistics.Win.UltraWinGrid.UltraGrid()
        Me.uds_exportar = New Infragistics.Win.UltraWinDataSource.UltraDataSource(Me.components)
        Me.UltraLabel4 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraLabel7 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraLabel9 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraLabel8 = New Infragistics.Win.Misc.UltraLabel()
        Me.ToolStrip1.SuspendLayout()
        CType(Me.ugb_Parametros, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ugb_Parametros.SuspendLayout()
        CType(Me.uce_TipoPersonal, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.udte_fec_fin, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.udte_fec_ini, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.une_Ayo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.uce_Mes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ug_exporta, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.uds_exportar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ToolStrip1
        '
        Me.ToolStrip1.BackColor = System.Drawing.Color.Gainsboro
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Tool_Procesar, Me.ToolStripSeparator4, Me.Tool_imprimir, Me.ToolStripSeparator2, Me.Tool_Salir, Me.ToolStripSeparator1})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(800, 25)
        Me.ToolStrip1.TabIndex = 7
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'Tool_Procesar
        '
        Me.Tool_Procesar.Image = Global.Contabilidad.My.Resources.Resources._16__Configure_
        Me.Tool_Procesar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Tool_Procesar.Name = "Tool_Procesar"
        Me.Tool_Procesar.Size = New System.Drawing.Size(72, 22)
        Me.Tool_Procesar.Text = "Procesar"
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
        'ugb_Parametros
        '
        Me.ugb_Parametros.Controls.Add(Me.uchk_modificar)
        Me.ugb_Parametros.Controls.Add(Me.uce_TipoPersonal)
        Me.ugb_Parametros.Controls.Add(Me.udte_fec_fin)
        Me.ugb_Parametros.Controls.Add(Me.UltraLabel2)
        Me.ugb_Parametros.Controls.Add(Me.udte_fec_ini)
        Me.ugb_Parametros.Controls.Add(Me.une_Ayo)
        Me.ugb_Parametros.Controls.Add(Me.UltraLabel6)
        Me.ugb_Parametros.Controls.Add(Me.UltraLabel5)
        Me.ugb_Parametros.Controls.Add(Me.UltraLabel1)
        Me.ugb_Parametros.Controls.Add(Me.uce_Mes)
        Me.ugb_Parametros.Location = New System.Drawing.Point(12, 33)
        Me.ugb_Parametros.Name = "ugb_Parametros"
        Me.ugb_Parametros.Size = New System.Drawing.Size(776, 45)
        Me.ugb_Parametros.TabIndex = 12
        '
        'uchk_modificar
        '
        Me.uchk_modificar.BackColor = System.Drawing.Color.Transparent
        Me.uchk_modificar.BackColorInternal = System.Drawing.Color.Transparent
        Me.uchk_modificar.Location = New System.Drawing.Point(691, 16)
        Me.uchk_modificar.Name = "uchk_modificar"
        Me.uchk_modificar.Size = New System.Drawing.Size(73, 20)
        Me.uchk_modificar.TabIndex = 15
        Me.uchk_modificar.Text = "Modificar"
        '
        'uce_TipoPersonal
        '
        Me.uce_TipoPersonal.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.uce_TipoPersonal.Location = New System.Drawing.Point(513, 13)
        Me.uce_TipoPersonal.Name = "uce_TipoPersonal"
        Me.uce_TipoPersonal.Size = New System.Drawing.Size(116, 21)
        Me.uce_TipoPersonal.TabIndex = 6
        '
        'udte_fec_fin
        '
        Me.udte_fec_fin.Location = New System.Drawing.Point(360, 13)
        Me.udte_fec_fin.Name = "udte_fec_fin"
        Me.udte_fec_fin.Size = New System.Drawing.Size(88, 21)
        Me.udte_fec_fin.TabIndex = 14
        '
        'UltraLabel2
        '
        Appearance3.BackColor = System.Drawing.Color.Transparent
        Appearance3.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel2.Appearance = Appearance3
        Me.UltraLabel2.AutoSize = True
        Me.UltraLabel2.Location = New System.Drawing.Point(460, 17)
        Me.UltraLabel2.Name = "UltraLabel2"
        Me.UltraLabel2.Size = New System.Drawing.Size(47, 14)
        Me.UltraLabel2.TabIndex = 5
        Me.UltraLabel2.Text = "Tipo Per"
        '
        'udte_fec_ini
        '
        Me.udte_fec_ini.Location = New System.Drawing.Point(239, 12)
        Me.udte_fec_ini.Name = "udte_fec_ini"
        Me.udte_fec_ini.Size = New System.Drawing.Size(92, 21)
        Me.udte_fec_ini.TabIndex = 14
        '
        'une_Ayo
        '
        Appearance2.TextHAlignAsString = "Center"
        Me.une_Ayo.Appearance = Appearance2
        Me.une_Ayo.Location = New System.Drawing.Point(52, 13)
        Me.une_Ayo.MaskInput = "nnnn"
        Me.une_Ayo.Name = "une_Ayo"
        Me.une_Ayo.ReadOnly = True
        Me.une_Ayo.Size = New System.Drawing.Size(46, 21)
        Me.une_Ayo.TabIndex = 13
        '
        'UltraLabel6
        '
        Appearance14.BackColor = System.Drawing.Color.Transparent
        Appearance14.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel6.Appearance = Appearance14
        Me.UltraLabel6.AutoSize = True
        Me.UltraLabel6.Location = New System.Drawing.Point(337, 16)
        Me.UltraLabel6.Name = "UltraLabel6"
        Me.UltraLabel6.Size = New System.Drawing.Size(18, 14)
        Me.UltraLabel6.TabIndex = 12
        Me.UltraLabel6.Text = "A :"
        '
        'UltraLabel5
        '
        Appearance5.BackColor = System.Drawing.Color.Transparent
        Appearance5.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel5.Appearance = Appearance5
        Me.UltraLabel5.AutoSize = True
        Me.UltraLabel5.Location = New System.Drawing.Point(210, 16)
        Me.UltraLabel5.Name = "UltraLabel5"
        Me.UltraLabel5.Size = New System.Drawing.Size(25, 14)
        Me.UltraLabel5.TabIndex = 12
        Me.UltraLabel5.Text = "De :"
        '
        'UltraLabel1
        '
        Appearance15.BackColor = System.Drawing.Color.Transparent
        Appearance15.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel1.Appearance = Appearance15
        Me.UltraLabel1.AutoSize = True
        Me.UltraLabel1.Location = New System.Drawing.Point(8, 17)
        Me.UltraLabel1.Name = "UltraLabel1"
        Me.UltraLabel1.Size = New System.Drawing.Size(43, 14)
        Me.UltraLabel1.TabIndex = 12
        Me.UltraLabel1.Text = "Periodo"
        '
        'uce_Mes
        '
        Me.uce_Mes.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.uce_Mes.Location = New System.Drawing.Point(99, 13)
        Me.uce_Mes.Name = "uce_Mes"
        Me.uce_Mes.Size = New System.Drawing.Size(100, 21)
        Me.uce_Mes.TabIndex = 0
        '
        'upb_estado
        '
        Me.upb_estado.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.upb_estado.Location = New System.Drawing.Point(428, 475)
        Me.upb_estado.Name = "upb_estado"
        Me.upb_estado.Size = New System.Drawing.Size(360, 17)
        Me.upb_estado.TabIndex = 14
        Me.upb_estado.Text = "[Formatted]"
        Me.upb_estado.Visible = False
        '
        'ug_exporta
        '
        Me.ug_exporta.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ug_exporta.DataSource = Me.uds_exportar
        Me.ug_exporta.DisplayLayout.AutoFitStyle = Infragistics.Win.UltraWinGrid.AutoFitStyle.ExtendLastColumn
        UltraGridColumn1.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn1.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn1.Header.Caption = "CODIGO"
        UltraGridColumn1.Width = 53
        UltraGridColumn2.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn2.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn2.Width = 133
        UltraGridColumn3.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn3.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn3.Width = 138
        UltraGridColumn4.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn4.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        Appearance13.BackColor = System.Drawing.Color.LightGoldenrodYellow
        Appearance13.TextHAlignAsString = "Center"
        UltraGridColumn4.CellAppearance = Appearance13
        UltraGridColumn4.Header.Caption = "TARDANZA"
        UltraGridColumn4.MaskInput = "hh:mm:ss"
        UltraGridColumn4.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.Time
        UltraGridColumn4.Width = 72
        UltraGridColumn5.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn5.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        Appearance18.BackColor = System.Drawing.Color.LightGoldenrodYellow
        Appearance18.TextHAlignAsString = "Center"
        UltraGridColumn5.CellAppearance = Appearance18
        UltraGridColumn5.Header.Caption = "H. T."
        UltraGridColumn5.Width = 32
        UltraGridColumn6.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn6.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        Appearance19.BackColor = System.Drawing.Color.LightGoldenrodYellow
        Appearance19.TextHAlignAsString = "Center"
        UltraGridColumn6.CellAppearance = Appearance19
        UltraGridColumn6.Header.Caption = "M. T."
        UltraGridColumn6.Width = 39
        UltraGridColumn7.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn7.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        Appearance20.BackColor = System.Drawing.Color.Bisque
        Appearance20.TextHAlignAsString = "Center"
        UltraGridColumn7.CellAppearance = Appearance20
        UltraGridColumn7.Header.Caption = "MENOS 45"
        UltraGridColumn7.MaskInput = "hh:mm:ss"
        UltraGridColumn7.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.Time
        UltraGridColumn7.Width = 63
        UltraGridColumn8.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn8.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        Appearance21.BackColor = System.Drawing.Color.Bisque
        Appearance21.TextHAlignAsString = "Center"
        UltraGridColumn8.CellAppearance = Appearance21
        UltraGridColumn8.Header.Caption = "H. T. C."
        UltraGridColumn8.Width = 50
        UltraGridColumn9.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn9.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        Appearance22.BackColor = System.Drawing.Color.Bisque
        Appearance22.TextHAlignAsString = "Center"
        UltraGridColumn9.CellAppearance = Appearance22
        UltraGridColumn9.Header.Caption = "M. T. C."
        UltraGridColumn9.Width = 8
        UltraGridColumn10.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn10.Header.VisiblePosition = 11
        UltraGridColumn10.Hidden = True
        UltraGridColumn11.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn11.Header.VisiblePosition = 12
        UltraGridColumn11.Hidden = True
        UltraGridColumn12.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        Appearance24.TextHAlignAsString = "Center"
        UltraGridColumn12.CellAppearance = Appearance24
        UltraGridColumn12.Hidden = True
        UltraGridColumn12.MaskInput = "hh:mm"
        UltraGridColumn12.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.Time
        UltraGridColumn13.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn13.ButtonDisplayStyle = Infragistics.Win.UltraWinGrid.ButtonDisplayStyle.Always
        UltraGridColumn13.Header.Caption = "Detalle"
        UltraGridColumn13.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.Button
        UltraGridColumn13.Width = 39
        UltraGridBand1.Columns.AddRange(New Object() {UltraGridColumn1, UltraGridColumn2, UltraGridColumn3, UltraGridColumn4, UltraGridColumn5, UltraGridColumn6, UltraGridColumn7, UltraGridColumn8, UltraGridColumn9, UltraGridColumn10, UltraGridColumn11, UltraGridColumn12, UltraGridColumn13})
        UltraGridGroup1.Key = "PERSONAL"
        UltraGridGroup2.Key = "TARDANZA"
        UltraGridGroup3.Key = "CON TOLERANCIA DE 45 MIN"
        UltraGridBand1.Groups.AddRange(New Infragistics.Win.UltraWinGrid.UltraGridGroup() {UltraGridGroup1, UltraGridGroup2, UltraGridGroup3})
        Me.ug_exporta.DisplayLayout.BandsSerializer.Add(UltraGridBand1)
        Me.ug_exporta.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.[False]
        Me.ug_exporta.DisplayLayout.MaxColScrollRegions = 1
        Me.ug_exporta.DisplayLayout.MaxRowScrollRegions = 1
        Me.ug_exporta.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Appearance23.BackColor = System.Drawing.Color.WhiteSmoke
        Appearance23.BackColor2 = System.Drawing.Color.WhiteSmoke
        Me.ug_exporta.DisplayLayout.Override.RowAlternateAppearance = Appearance23
        Me.ug_exporta.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.ug_exporta.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.ug_exporta.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ug_exporta.Location = New System.Drawing.Point(13, 84)
        Me.ug_exporta.Name = "ug_exporta"
        Me.ug_exporta.Size = New System.Drawing.Size(775, 385)
        Me.ug_exporta.TabIndex = 15
        Me.ug_exporta.Text = "UltraGrid1"
        '
        'uds_exportar
        '
        Me.uds_exportar.AllowDelete = False
        UltraDataColumn4.DataType = GetType(Date)
        UltraDataColumn5.DataType = GetType(Double)
        UltraDataColumn6.DataType = GetType(Double)
        UltraDataColumn7.DataType = GetType(Date)
        UltraDataColumn8.DataType = GetType(Double)
        UltraDataColumn9.DataType = GetType(Double)
        UltraDataColumn11.DataType = GetType(Short)
        UltraDataColumn12.DataType = GetType(Date)
        Me.uds_exportar.Band.Columns.AddRange(New Object() {UltraDataColumn1, UltraDataColumn2, UltraDataColumn3, UltraDataColumn4, UltraDataColumn5, UltraDataColumn6, UltraDataColumn7, UltraDataColumn8, UltraDataColumn9, UltraDataColumn10, UltraDataColumn11, UltraDataColumn12})
        '
        'UltraLabel4
        '
        Me.UltraLabel4.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Appearance4.BackColor = System.Drawing.Color.LightGoldenrodYellow
        Appearance4.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel4.Appearance = Appearance4
        Me.UltraLabel4.BorderStyleInner = Infragistics.Win.UIElementBorderStyle.Solid
        Me.UltraLabel4.Location = New System.Drawing.Point(13, 477)
        Me.UltraLabel4.Name = "UltraLabel4"
        Me.UltraLabel4.Size = New System.Drawing.Size(43, 14)
        Me.UltraLabel4.TabIndex = 17
        '
        'UltraLabel7
        '
        Me.UltraLabel7.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Appearance17.BackColor = System.Drawing.Color.Transparent
        Appearance17.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel7.Appearance = Appearance17
        Me.UltraLabel7.AutoSize = True
        Me.UltraLabel7.Location = New System.Drawing.Point(59, 477)
        Me.UltraLabel7.Name = "UltraLabel7"
        Me.UltraLabel7.Size = New System.Drawing.Size(52, 14)
        Me.UltraLabel7.TabIndex = 17
        Me.UltraLabel7.Text = "Tardanza"
        '
        'UltraLabel9
        '
        Me.UltraLabel9.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Appearance8.BackColor = System.Drawing.Color.Transparent
        Appearance8.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel9.Appearance = Appearance8
        Me.UltraLabel9.AutoSize = True
        Me.UltraLabel9.Location = New System.Drawing.Point(189, 477)
        Me.UltraLabel9.Name = "UltraLabel9"
        Me.UltraLabel9.Size = New System.Drawing.Size(169, 14)
        Me.UltraLabel9.TabIndex = 17
        Me.UltraLabel9.Text = "Con Tolerancia  ( menos 45Min.)"
        '
        'UltraLabel8
        '
        Me.UltraLabel8.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Appearance16.BackColor = System.Drawing.Color.Bisque
        Appearance16.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel8.Appearance = Appearance16
        Me.UltraLabel8.BorderStyleInner = Infragistics.Win.UIElementBorderStyle.Solid
        Me.UltraLabel8.Location = New System.Drawing.Point(142, 477)
        Me.UltraLabel8.Name = "UltraLabel8"
        Me.UltraLabel8.Size = New System.Drawing.Size(43, 14)
        Me.UltraLabel8.TabIndex = 18
        '
        'PL_RP_Tardanzas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(800, 500)
        Me.Controls.Add(Me.UltraLabel8)
        Me.Controls.Add(Me.UltraLabel9)
        Me.Controls.Add(Me.UltraLabel7)
        Me.Controls.Add(Me.UltraLabel4)
        Me.Controls.Add(Me.ug_exporta)
        Me.Controls.Add(Me.upb_estado)
        Me.Controls.Add(Me.ugb_Parametros)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Name = "PL_RP_Tardanzas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Tardanzas"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        CType(Me.ugb_Parametros, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ugb_Parametros.ResumeLayout(False)
        Me.ugb_Parametros.PerformLayout()
        CType(Me.uce_TipoPersonal, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.udte_fec_fin, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.udte_fec_ini, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.une_Ayo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.uce_Mes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ug_exporta, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.uds_exportar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents Tool_imprimir As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents Tool_Salir As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ugb_Parametros As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents une_Ayo As Infragistics.Win.UltraWinEditors.UltraNumericEditor
    Friend WithEvents UltraLabel1 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents uce_Mes As Infragistics.Win.UltraWinEditors.UltraComboEditor
    Friend WithEvents uce_TipoPersonal As Infragistics.Win.UltraWinEditors.UltraComboEditor
    Friend WithEvents UltraLabel2 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents upb_estado As Infragistics.Win.UltraWinProgressBar.UltraProgressBar
    Friend WithEvents ug_exporta As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents uds_exportar As Infragistics.Win.UltraWinDataSource.UltraDataSource
    Friend WithEvents udte_fec_fin As Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
    Friend WithEvents udte_fec_ini As Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
    Friend WithEvents UltraLabel6 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel5 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents Tool_Procesar As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents UltraLabel4 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel7 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel9 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel8 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents uchk_modificar As Infragistics.Win.UltraWinEditors.UltraCheckEditor
End Class
