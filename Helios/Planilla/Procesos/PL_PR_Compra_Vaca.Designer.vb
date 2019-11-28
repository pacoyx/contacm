<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PL_PR_Compra_Vaca
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
        Dim UltraGridColumn1 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CV_ID_PERSONAL")
        Dim UltraGridColumn2 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("PE_CODIGO", -1, Nothing, 0, Infragistics.Win.UltraWinGrid.SortIndicator.Ascending, False)
        Dim UltraGridColumn3 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("PE_APE_PAT")
        Dim UltraGridColumn4 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("PE_APE_MAT")
        Dim UltraGridColumn5 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("PE_NOM_PRI")
        Dim UltraGridColumn6 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("PE_NOM_SEG")
        Dim UltraGridColumn7 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Band 1")
        Dim UltraGridBand2 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 1", 0)
        Dim UltraGridColumn8 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CV_ID_PERSONAL")
        Dim UltraGridColumn9 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CV_ID")
        Dim UltraGridColumn10 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CV_DIAS")
        Dim UltraGridColumn11 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CV_IMPORTE")
        Dim Appearance1 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn12 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CV_PERIODO")
        Dim UltraGridColumn13 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CV_FECHA_LIQUI", -1, Nothing, 0, Infragistics.Win.UltraWinGrid.SortIndicator.Ascending, False)
        Dim UltraGridColumn14 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CV_OBS")
        Dim UltraGridColumn15 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CV_PROCESAR")
        Dim Appearance11 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance12 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraDataBand1 As Infragistics.Win.UltraWinDataSource.UltraDataBand = New Infragistics.Win.UltraWinDataSource.UltraDataBand("Band 1")
        Dim UltraDataColumn1 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("CV_ID_PERSONAL")
        Dim UltraDataColumn2 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("CV_ID")
        Dim UltraDataColumn3 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("CV_DIAS")
        Dim UltraDataColumn4 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("CV_IMPORTE")
        Dim UltraDataColumn5 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("CV_PERIODO")
        Dim UltraDataColumn6 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("CV_FECHA_LIQUI")
        Dim UltraDataColumn7 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("CV_OBS")
        Dim UltraDataColumn8 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("CV_PROCESAR")
        Dim UltraDataColumn9 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("CV_ID_PERSONAL")
        Dim UltraDataColumn10 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("PE_CODIGO")
        Dim UltraDataColumn11 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("PE_APE_PAT")
        Dim UltraDataColumn12 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("PE_APE_MAT")
        Dim UltraDataColumn13 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("PE_NOM_PRI")
        Dim UltraDataColumn14 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("PE_NOM_SEG")
        Dim Appearance10 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance4 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance22 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance8 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance39 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance40 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim EditorButton1 As Infragistics.Win.UltraWinEditors.EditorButton = New Infragistics.Win.UltraWinEditors.EditorButton()
        Dim Appearance14 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance41 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraTab1 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraTab2 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Me.UltraTabPageControl1 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.ug_lista_emp_compra = New Infragistics.Win.UltraWinGrid.UltraGrid()
        Me.uds_Lista_Emp_Compras = New Infragistics.Win.UltraWinDataSource.UltraDataSource(Me.components)
        Me.UltraTabPageControl2 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.ugb_datos = New Infragistics.Win.Misc.UltraGroupBox()
        Me.txt_idRegistro = New Infragistics.Win.UltraWinEditors.UltraNumericEditor()
        Me.uchk_consi_liqui = New Infragistics.Win.UltraWinEditors.UltraCheckEditor()
        Me.UltraLabel21 = New Infragistics.Win.Misc.UltraLabel()
        Me.uce_periodo_compra = New Infragistics.Win.UltraWinEditors.UltraComboEditor()
        Me.UltraLabel20 = New Infragistics.Win.Misc.UltraLabel()
        Me.udte_fec_liqui = New Infragistics.Win.UltraWinEditors.UltraDateTimeEditor()
        Me.ume_importe_compra = New Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit()
        Me.txt_obs_compra = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.une_dias_compra = New Infragistics.Win.UltraWinEditors.UltraNumericEditor()
        Me.UltraLabel19 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraLabel18 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraLabel17 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraLabel16 = New Infragistics.Win.Misc.UltraLabel()
        Me.ugb_trabajador = New Infragistics.Win.Misc.UltraGroupBox()
        Me.txt_nom_per = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.txt_cod_per = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.txt_id_per = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.UltraLabel15 = New Infragistics.Win.Misc.UltraLabel()
        Me.ToolS_Mantenimiento = New System.Windows.Forms.ToolStrip()
        Me.Tool_Nuevo = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.Tool_Grabar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.Tool_Editar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.Tool_Cancelar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.Tool_Eliminar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator()
        Me.Tool_Salir = New System.Windows.Forms.ToolStripButton()
        Me.utc_compras = New Infragistics.Win.UltraWinTabControl.UltraTabControl()
        Me.UltraTabSharedControlsPage1 = New Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage()
        Me.UltraTabPageControl1.SuspendLayout()
        CType(Me.ug_lista_emp_compra, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.uds_Lista_Emp_Compras, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabPageControl2.SuspendLayout()
        CType(Me.ugb_datos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ugb_datos.SuspendLayout()
        CType(Me.txt_idRegistro, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.uce_periodo_compra, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.udte_fec_liqui, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_obs_compra, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.une_dias_compra, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ugb_trabajador, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ugb_trabajador.SuspendLayout()
        CType(Me.txt_nom_per, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_cod_per, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_id_per, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolS_Mantenimiento.SuspendLayout()
        CType(Me.utc_compras, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.utc_compras.SuspendLayout()
        Me.SuspendLayout()
        '
        'UltraTabPageControl1
        '
        Me.UltraTabPageControl1.Controls.Add(Me.ug_lista_emp_compra)
        Me.UltraTabPageControl1.Location = New System.Drawing.Point(1, 23)
        Me.UltraTabPageControl1.Name = "UltraTabPageControl1"
        Me.UltraTabPageControl1.Size = New System.Drawing.Size(658, 360)
        '
        'ug_lista_emp_compra
        '
        Me.ug_lista_emp_compra.DataSource = Me.uds_Lista_Emp_Compras
        Me.ug_lista_emp_compra.DisplayLayout.AutoFitStyle = Infragistics.Win.UltraWinGrid.AutoFitStyle.ExtendLastColumn
        UltraGridColumn1.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn1.Header.VisiblePosition = 0
        UltraGridColumn1.Hidden = True
        UltraGridColumn1.Width = 57
        UltraGridColumn2.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn2.Header.Caption = "CodPer"
        UltraGridColumn2.Header.VisiblePosition = 1
        UltraGridColumn2.Width = 92
        UltraGridColumn3.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn3.Header.Caption = "Paterno"
        UltraGridColumn3.Header.VisiblePosition = 2
        UltraGridColumn4.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn4.Header.Caption = "Materno"
        UltraGridColumn4.Header.VisiblePosition = 3
        UltraGridColumn4.Width = 88
        UltraGridColumn5.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn5.Header.Caption = "Nombre"
        UltraGridColumn5.Header.VisiblePosition = 4
        UltraGridColumn5.Width = 90
        UltraGridColumn6.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn6.Header.Caption = "Nombre2"
        UltraGridColumn6.Header.VisiblePosition = 5
        UltraGridColumn6.Width = 179
        UltraGridColumn7.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn7.Header.VisiblePosition = 6
        UltraGridBand1.Columns.AddRange(New Object() {UltraGridColumn1, UltraGridColumn2, UltraGridColumn3, UltraGridColumn4, UltraGridColumn5, UltraGridColumn6, UltraGridColumn7})
        UltraGridColumn8.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn8.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn8.Header.VisiblePosition = 0
        UltraGridColumn8.Hidden = True
        UltraGridColumn8.Width = 73
        UltraGridColumn9.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn9.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn9.Header.VisiblePosition = 1
        UltraGridColumn9.Hidden = True
        UltraGridColumn10.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn10.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn10.Header.Caption = "Dias"
        UltraGridColumn10.Header.VisiblePosition = 2
        UltraGridColumn11.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn11.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        Appearance1.TextHAlignAsString = "Right"
        UltraGridColumn11.CellAppearance = Appearance1
        UltraGridColumn11.Header.Caption = "Importe"
        UltraGridColumn11.Header.VisiblePosition = 3
        UltraGridColumn11.MaskDisplayMode = Infragistics.Win.UltraWinMaskedEdit.MaskMode.IncludeLiterals
        UltraGridColumn11.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Double]
        UltraGridColumn12.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn12.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn12.Header.Caption = "Periodo"
        UltraGridColumn12.Header.VisiblePosition = 4
        UltraGridColumn12.Width = 88
        UltraGridColumn13.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn13.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn13.Header.Caption = "Fecha"
        UltraGridColumn13.Header.VisiblePosition = 5
        UltraGridColumn13.Width = 90
        UltraGridColumn14.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn14.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn14.Header.Caption = "Obs."
        UltraGridColumn14.Header.VisiblePosition = 6
        UltraGridColumn14.Width = 179
        UltraGridColumn15.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn15.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn15.Header.Caption = "Procesa"
        UltraGridColumn15.Header.VisiblePosition = 7
        UltraGridBand2.Columns.AddRange(New Object() {UltraGridColumn8, UltraGridColumn9, UltraGridColumn10, UltraGridColumn11, UltraGridColumn12, UltraGridColumn13, UltraGridColumn14, UltraGridColumn15})
        Me.ug_lista_emp_compra.DisplayLayout.BandsSerializer.Add(UltraGridBand1)
        Me.ug_lista_emp_compra.DisplayLayout.BandsSerializer.Add(UltraGridBand2)
        Me.ug_lista_emp_compra.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.[False]
        Me.ug_lista_emp_compra.DisplayLayout.MaxColScrollRegions = 1
        Me.ug_lista_emp_compra.DisplayLayout.MaxRowScrollRegions = 1
        Appearance11.BackColor = System.Drawing.Color.Beige
        Me.ug_lista_emp_compra.DisplayLayout.Override.FilterRowAppearance = Appearance11
        Me.ug_lista_emp_compra.DisplayLayout.Override.FilterUIType = Infragistics.Win.UltraWinGrid.FilterUIType.FilterRow
        Me.ug_lista_emp_compra.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Appearance12.BackColor = System.Drawing.Color.WhiteSmoke
        Appearance12.BackColor2 = System.Drawing.Color.WhiteSmoke
        Me.ug_lista_emp_compra.DisplayLayout.Override.RowAlternateAppearance = Appearance12
        Me.ug_lista_emp_compra.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.ug_lista_emp_compra.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ug_lista_emp_compra.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ug_lista_emp_compra.Location = New System.Drawing.Point(0, 0)
        Me.ug_lista_emp_compra.Name = "ug_lista_emp_compra"
        Me.ug_lista_emp_compra.Size = New System.Drawing.Size(658, 360)
        Me.ug_lista_emp_compra.TabIndex = 0
        Me.ug_lista_emp_compra.Text = "UltraGrid1"
        '
        'uds_Lista_Emp_Compras
        '
        Me.uds_Lista_Emp_Compras.AllowDelete = False
        UltraDataColumn1.DataType = GetType(Integer)
        UltraDataColumn2.DataType = GetType(Integer)
        UltraDataColumn3.DataType = GetType(Short)
        UltraDataColumn4.DataType = GetType(Double)
        UltraDataColumn6.DataType = GetType(Date)
        UltraDataColumn8.DataType = GetType(Boolean)
        UltraDataBand1.Columns.AddRange(New Object() {UltraDataColumn1, UltraDataColumn2, UltraDataColumn3, UltraDataColumn4, UltraDataColumn5, UltraDataColumn6, UltraDataColumn7, UltraDataColumn8})
        Me.uds_Lista_Emp_Compras.Band.ChildBands.AddRange(New Object() {UltraDataBand1})
        UltraDataColumn9.DataType = GetType(Integer)
        Me.uds_Lista_Emp_Compras.Band.Columns.AddRange(New Object() {UltraDataColumn9, UltraDataColumn10, UltraDataColumn11, UltraDataColumn12, UltraDataColumn13, UltraDataColumn14})
        '
        'UltraTabPageControl2
        '
        Me.UltraTabPageControl2.Controls.Add(Me.ugb_datos)
        Me.UltraTabPageControl2.Controls.Add(Me.ugb_trabajador)
        Me.UltraTabPageControl2.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl2.Name = "UltraTabPageControl2"
        Me.UltraTabPageControl2.Size = New System.Drawing.Size(658, 360)
        '
        'ugb_datos
        '
        Me.ugb_datos.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ugb_datos.Controls.Add(Me.txt_idRegistro)
        Me.ugb_datos.Controls.Add(Me.uchk_consi_liqui)
        Me.ugb_datos.Controls.Add(Me.UltraLabel21)
        Me.ugb_datos.Controls.Add(Me.uce_periodo_compra)
        Me.ugb_datos.Controls.Add(Me.UltraLabel20)
        Me.ugb_datos.Controls.Add(Me.udte_fec_liqui)
        Me.ugb_datos.Controls.Add(Me.ume_importe_compra)
        Me.ugb_datos.Controls.Add(Me.txt_obs_compra)
        Me.ugb_datos.Controls.Add(Me.une_dias_compra)
        Me.ugb_datos.Controls.Add(Me.UltraLabel19)
        Me.ugb_datos.Controls.Add(Me.UltraLabel18)
        Me.ugb_datos.Controls.Add(Me.UltraLabel17)
        Me.ugb_datos.Controls.Add(Me.UltraLabel16)
        Me.ugb_datos.Location = New System.Drawing.Point(16, 76)
        Me.ugb_datos.Name = "ugb_datos"
        Me.ugb_datos.Size = New System.Drawing.Size(626, 262)
        Me.ugb_datos.TabIndex = 15
        Me.ugb_datos.Text = "Detalle de Compra"
        '
        'txt_idRegistro
        '
        Me.txt_idRegistro.Location = New System.Drawing.Point(174, 31)
        Me.txt_idRegistro.MaskInput = "nn"
        Me.txt_idRegistro.Name = "txt_idRegistro"
        Me.txt_idRegistro.Size = New System.Drawing.Size(41, 21)
        Me.txt_idRegistro.TabIndex = 19
        '
        'uchk_consi_liqui
        '
        Me.uchk_consi_liqui.BackColor = System.Drawing.Color.Transparent
        Me.uchk_consi_liqui.BackColorInternal = System.Drawing.Color.Transparent
        Me.uchk_consi_liqui.Checked = True
        Me.uchk_consi_liqui.CheckState = System.Windows.Forms.CheckState.Checked
        Me.uchk_consi_liqui.Location = New System.Drawing.Point(126, 188)
        Me.uchk_consi_liqui.Name = "uchk_consi_liqui"
        Me.uchk_consi_liqui.Size = New System.Drawing.Size(177, 20)
        Me.uchk_consi_liqui.TabIndex = 5
        Me.uchk_consi_liqui.Text = "Considerar en Liquidacion"
        '
        'UltraLabel21
        '
        Appearance10.BackColor = System.Drawing.Color.Transparent
        Appearance10.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel21.Appearance = Appearance10
        Me.UltraLabel21.AutoSize = True
        Me.UltraLabel21.Location = New System.Drawing.Point(32, 191)
        Me.UltraLabel21.Name = "UltraLabel21"
        Me.UltraLabel21.Size = New System.Drawing.Size(49, 14)
        Me.UltraLabel21.TabIndex = 18
        Me.UltraLabel21.Text = "Procesar"
        '
        'uce_periodo_compra
        '
        Me.uce_periodo_compra.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.uce_periodo_compra.Location = New System.Drawing.Point(127, 89)
        Me.uce_periodo_compra.Name = "uce_periodo_compra"
        Me.uce_periodo_compra.Size = New System.Drawing.Size(158, 21)
        Me.uce_periodo_compra.TabIndex = 2
        '
        'UltraLabel20
        '
        Appearance4.BackColor = System.Drawing.Color.Transparent
        Appearance4.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel20.Appearance = Appearance4
        Me.UltraLabel20.AutoSize = True
        Me.UltraLabel20.Location = New System.Drawing.Point(32, 93)
        Me.UltraLabel20.Name = "UltraLabel20"
        Me.UltraLabel20.Size = New System.Drawing.Size(43, 14)
        Me.UltraLabel20.TabIndex = 15
        Me.UltraLabel20.Text = "Periodo"
        '
        'udte_fec_liqui
        '
        Me.udte_fec_liqui.Location = New System.Drawing.Point(127, 120)
        Me.udte_fec_liqui.Name = "udte_fec_liqui"
        Me.udte_fec_liqui.Size = New System.Drawing.Size(121, 21)
        Me.udte_fec_liqui.TabIndex = 3
        '
        'ume_importe_compra
        '
        Me.ume_importe_compra.EditAs = Infragistics.Win.UltraWinMaskedEdit.EditAsType.UseSpecifiedMask
        Me.ume_importe_compra.InputMask = "{double:9.2}"
        Me.ume_importe_compra.Location = New System.Drawing.Point(127, 60)
        Me.ume_importe_compra.Name = "ume_importe_compra"
        Me.ume_importe_compra.Size = New System.Drawing.Size(79, 20)
        Me.ume_importe_compra.TabIndex = 1
        Me.ume_importe_compra.Text = "UltraMaskedEdit1"
        '
        'txt_obs_compra
        '
        Me.txt_obs_compra.Location = New System.Drawing.Point(126, 158)
        Me.txt_obs_compra.MaxLength = 250
        Me.txt_obs_compra.Name = "txt_obs_compra"
        Me.txt_obs_compra.Size = New System.Drawing.Size(280, 21)
        Me.txt_obs_compra.TabIndex = 4
        '
        'une_dias_compra
        '
        Me.une_dias_compra.Location = New System.Drawing.Point(127, 31)
        Me.une_dias_compra.MaskInput = "nn"
        Me.une_dias_compra.Name = "une_dias_compra"
        Me.une_dias_compra.Size = New System.Drawing.Size(41, 21)
        Me.une_dias_compra.TabIndex = 0
        '
        'UltraLabel19
        '
        Appearance22.BackColor = System.Drawing.Color.Transparent
        Appearance22.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel19.Appearance = Appearance22
        Me.UltraLabel19.AutoSize = True
        Me.UltraLabel19.Location = New System.Drawing.Point(32, 35)
        Me.UltraLabel19.Name = "UltraLabel19"
        Me.UltraLabel19.Size = New System.Drawing.Size(27, 14)
        Me.UltraLabel19.TabIndex = 11
        Me.UltraLabel19.Text = "Dias"
        '
        'UltraLabel18
        '
        Appearance8.BackColor = System.Drawing.Color.Transparent
        Appearance8.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel18.Appearance = Appearance8
        Me.UltraLabel18.AutoSize = True
        Me.UltraLabel18.Location = New System.Drawing.Point(31, 162)
        Me.UltraLabel18.Name = "UltraLabel18"
        Me.UltraLabel18.Size = New System.Drawing.Size(80, 14)
        Me.UltraLabel18.TabIndex = 9
        Me.UltraLabel18.Text = "Observaciones"
        '
        'UltraLabel17
        '
        Appearance39.BackColor = System.Drawing.Color.Transparent
        Appearance39.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel17.Appearance = Appearance39
        Me.UltraLabel17.Location = New System.Drawing.Point(31, 120)
        Me.UltraLabel17.Name = "UltraLabel17"
        Me.UltraLabel17.Size = New System.Drawing.Size(81, 30)
        Me.UltraLabel17.TabIndex = 9
        Me.UltraLabel17.Text = "Fecha de Liquidacion"
        '
        'UltraLabel16
        '
        Appearance40.BackColor = System.Drawing.Color.Transparent
        Appearance40.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel16.Appearance = Appearance40
        Me.UltraLabel16.AutoSize = True
        Me.UltraLabel16.Location = New System.Drawing.Point(32, 66)
        Me.UltraLabel16.Name = "UltraLabel16"
        Me.UltraLabel16.Size = New System.Drawing.Size(43, 14)
        Me.UltraLabel16.TabIndex = 9
        Me.UltraLabel16.Text = "Importe"
        '
        'ugb_trabajador
        '
        Me.ugb_trabajador.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ugb_trabajador.Controls.Add(Me.txt_nom_per)
        Me.ugb_trabajador.Controls.Add(Me.txt_cod_per)
        Me.ugb_trabajador.Controls.Add(Me.txt_id_per)
        Me.ugb_trabajador.Controls.Add(Me.UltraLabel15)
        Me.ugb_trabajador.Location = New System.Drawing.Point(16, 8)
        Me.ugb_trabajador.Name = "ugb_trabajador"
        Me.ugb_trabajador.Size = New System.Drawing.Size(626, 64)
        Me.ugb_trabajador.TabIndex = 14
        Me.ugb_trabajador.Text = "Trabajador"
        '
        'txt_nom_per
        '
        Me.txt_nom_per.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_nom_per.Location = New System.Drawing.Point(215, 27)
        Me.txt_nom_per.Name = "txt_nom_per"
        Me.txt_nom_per.ReadOnly = True
        Me.txt_nom_per.Size = New System.Drawing.Size(381, 21)
        Me.txt_nom_per.TabIndex = 9
        '
        'txt_cod_per
        '
        Appearance14.ImageHAlign = Infragistics.Win.HAlign.Center
        EditorButton1.Appearance = Appearance14
        Me.txt_cod_per.ButtonsRight.Add(EditorButton1)
        Me.txt_cod_per.Location = New System.Drawing.Point(67, 27)
        Me.txt_cod_per.Name = "txt_cod_per"
        Me.txt_cod_per.Size = New System.Drawing.Size(101, 21)
        Me.txt_cod_per.TabIndex = 0
        '
        'txt_id_per
        '
        Me.txt_id_per.Location = New System.Drawing.Point(168, 27)
        Me.txt_id_per.Name = "txt_id_per"
        Me.txt_id_per.ReadOnly = True
        Me.txt_id_per.Size = New System.Drawing.Size(47, 21)
        Me.txt_id_per.TabIndex = 8
        '
        'UltraLabel15
        '
        Appearance41.BackColor = System.Drawing.Color.Transparent
        Appearance41.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel15.Appearance = Appearance41
        Me.UltraLabel15.AutoSize = True
        Me.UltraLabel15.Location = New System.Drawing.Point(12, 30)
        Me.UltraLabel15.Name = "UltraLabel15"
        Me.UltraLabel15.Size = New System.Drawing.Size(49, 14)
        Me.UltraLabel15.TabIndex = 8
        Me.UltraLabel15.Text = "Personal"
        '
        'ToolS_Mantenimiento
        '
        Me.ToolS_Mantenimiento.BackColor = System.Drawing.Color.White
        Me.ToolS_Mantenimiento.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Tool_Nuevo, Me.ToolStripSeparator1, Me.Tool_Grabar, Me.ToolStripSeparator3, Me.Tool_Editar, Me.ToolStripSeparator4, Me.Tool_Cancelar, Me.ToolStripSeparator2, Me.Tool_Eliminar, Me.ToolStripSeparator5, Me.Tool_Salir})
        Me.ToolS_Mantenimiento.Location = New System.Drawing.Point(0, 0)
        Me.ToolS_Mantenimiento.Name = "ToolS_Mantenimiento"
        Me.ToolS_Mantenimiento.Size = New System.Drawing.Size(686, 25)
        Me.ToolS_Mantenimiento.TabIndex = 9
        Me.ToolS_Mantenimiento.Text = "ToolStrip1"
        '
        'Tool_Nuevo
        '
        Me.Tool_Nuevo.Image = Global.Contabilidad.My.Resources.Resources._16__File_new_2_
        Me.Tool_Nuevo.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Tool_Nuevo.Name = "Tool_Nuevo"
        Me.Tool_Nuevo.Size = New System.Drawing.Size(58, 22)
        Me.Tool_Nuevo.Text = "Nuevo"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'Tool_Grabar
        '
        Me.Tool_Grabar.Image = Global.Contabilidad.My.Resources.Resources._003
        Me.Tool_Grabar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Tool_Grabar.Name = "Tool_Grabar"
        Me.Tool_Grabar.Size = New System.Drawing.Size(60, 22)
        Me.Tool_Grabar.Text = "Grabar"
        Me.Tool_Grabar.ToolTipText = "Grabar (F4)"
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
        'Tool_Eliminar
        '
        Me.Tool_Eliminar.Image = Global.Contabilidad.My.Resources.Resources._16__Delete_
        Me.Tool_Eliminar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Tool_Eliminar.Name = "Tool_Eliminar"
        Me.Tool_Eliminar.Size = New System.Drawing.Size(63, 22)
        Me.Tool_Eliminar.Text = "Eliminar"
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
        Me.Tool_Salir.Size = New System.Drawing.Size(47, 22)
        Me.Tool_Salir.Text = "Salir"
        '
        'utc_compras
        '
        Me.utc_compras.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.utc_compras.Controls.Add(Me.UltraTabSharedControlsPage1)
        Me.utc_compras.Controls.Add(Me.UltraTabPageControl1)
        Me.utc_compras.Controls.Add(Me.UltraTabPageControl2)
        Me.utc_compras.Location = New System.Drawing.Point(12, 28)
        Me.utc_compras.Name = "utc_compras"
        Me.utc_compras.SharedControlsPage = Me.UltraTabSharedControlsPage1
        Me.utc_compras.Size = New System.Drawing.Size(662, 386)
        Me.utc_compras.TabIndex = 10
        UltraTab1.TabPage = Me.UltraTabPageControl1
        UltraTab1.Text = "Lista de Compras"
        UltraTab2.TabPage = Me.UltraTabPageControl2
        UltraTab2.Text = "Ingreso de Datos"
        Me.utc_compras.Tabs.AddRange(New Infragistics.Win.UltraWinTabControl.UltraTab() {UltraTab1, UltraTab2})
        '
        'UltraTabSharedControlsPage1
        '
        Me.UltraTabSharedControlsPage1.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabSharedControlsPage1.Name = "UltraTabSharedControlsPage1"
        Me.UltraTabSharedControlsPage1.Size = New System.Drawing.Size(658, 360)
        '
        'PL_PR_Compra_Vaca
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(686, 426)
        Me.Controls.Add(Me.utc_compras)
        Me.Controls.Add(Me.ToolS_Mantenimiento)
        Me.Name = "PL_PR_Compra_Vaca"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Compras de Vacaciones"
        Me.UltraTabPageControl1.ResumeLayout(False)
        CType(Me.ug_lista_emp_compra, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.uds_Lista_Emp_Compras, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabPageControl2.ResumeLayout(False)
        CType(Me.ugb_datos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ugb_datos.ResumeLayout(False)
        Me.ugb_datos.PerformLayout()
        CType(Me.txt_idRegistro, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.uce_periodo_compra, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.udte_fec_liqui, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_obs_compra, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.une_dias_compra, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ugb_trabajador, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ugb_trabajador.ResumeLayout(False)
        Me.ugb_trabajador.PerformLayout()
        CType(Me.txt_nom_per, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_cod_per, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_id_per, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolS_Mantenimiento.ResumeLayout(False)
        Me.ToolS_Mantenimiento.PerformLayout()
        CType(Me.utc_compras, System.ComponentModel.ISupportInitialize).EndInit()
        Me.utc_compras.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolS_Mantenimiento As System.Windows.Forms.ToolStrip
    Friend WithEvents Tool_Nuevo As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents Tool_Grabar As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents Tool_Editar As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents Tool_Cancelar As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents Tool_Eliminar As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator5 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents Tool_Salir As System.Windows.Forms.ToolStripButton
    Friend WithEvents utc_compras As Infragistics.Win.UltraWinTabControl.UltraTabControl
    Friend WithEvents UltraTabSharedControlsPage1 As Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage
    Friend WithEvents UltraTabPageControl1 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents UltraTabPageControl2 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents ugb_trabajador As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents txt_nom_per As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents txt_cod_per As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents txt_id_per As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents UltraLabel15 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents ugb_datos As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents uchk_consi_liqui As Infragistics.Win.UltraWinEditors.UltraCheckEditor
    Friend WithEvents UltraLabel21 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents uce_periodo_compra As Infragistics.Win.UltraWinEditors.UltraComboEditor
    Friend WithEvents UltraLabel20 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents udte_fec_liqui As Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
    Friend WithEvents ume_importe_compra As Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit
    Friend WithEvents txt_obs_compra As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents une_dias_compra As Infragistics.Win.UltraWinEditors.UltraNumericEditor
    Friend WithEvents UltraLabel19 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel18 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel17 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel16 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents ug_lista_emp_compra As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents uds_Lista_Emp_Compras As Infragistics.Win.UltraWinDataSource.UltraDataSource
    Friend WithEvents txt_idRegistro As Infragistics.Win.UltraWinEditors.UltraNumericEditor
End Class
