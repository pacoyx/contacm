<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PL_PR_Suspensiones
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
        Dim Appearance18 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridBand1 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1)
        Dim UltraGridColumn1 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("SU_ID")
        Dim UltraGridColumn2 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("SU_PERIODO", -1, Nothing, 0, Infragistics.Win.UltraWinGrid.SortIndicator.Ascending, True)
        Dim UltraGridColumn3 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("SU_FECHA_INI", -1, Nothing, 1, Infragistics.Win.UltraWinGrid.SortIndicator.Ascending, False)
        Dim Appearance11 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn4 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("SU_FECHA_FIN")
        Dim Appearance16 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn5 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("SU_DIAS_VACA")
        Dim Appearance17 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn6 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("SU_OBS")
        Dim UltraGridColumn7 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("SU_PROCESAR")
        Dim UltraGridColumn8 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("SU_PROCESASADO")
        Dim SummarySettings1 As Infragistics.Win.UltraWinGrid.SummarySettings = New Infragistics.Win.UltraWinGrid.SummarySettings("", Infragistics.Win.UltraWinGrid.SummaryType.Sum, Nothing, "SU_DIAS_VACA", 4, True, "Band 0", 0, Infragistics.Win.UltraWinGrid.SummaryPosition.UseSummaryPositionColumn, "SU_DIAS_VACA", 4, True)
        Dim Appearance19 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance20 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance44 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance45 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance46 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraDataColumn1 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("SU_ID")
        Dim UltraDataColumn2 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("SU_PERIODO")
        Dim UltraDataColumn3 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("SU_FECHA_INI")
        Dim UltraDataColumn4 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("SU_FECHA_FIN")
        Dim UltraDataColumn5 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("SU_DIAS_VACA")
        Dim UltraDataColumn6 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("SU_OBS")
        Dim UltraDataColumn7 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("SU_PROCESAR")
        Dim UltraDataColumn8 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("SU_PROCESASADO")
        Dim UltraGridBand2 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1)
        Dim UltraGridColumn9 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("PE_ID")
        Dim UltraGridColumn10 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("PE_CODIGO")
        Dim UltraGridColumn11 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TRABAJADOR")
        Dim Appearance24 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance25 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraDataColumn9 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("PE_ID")
        Dim UltraDataColumn10 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("PE_CODIGO")
        Dim UltraDataColumn11 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("TRABAJADOR")
        Dim Appearance12 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance2 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance15 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance23 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance42 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance5 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance7 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance43 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance21 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance6 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance38 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance1 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance3 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance13 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance9 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim EditorButton1 As Infragistics.Win.UltraWinEditors.EditorButton = New Infragistics.Win.UltraWinEditors.EditorButton()
        Dim Appearance28 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance29 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance10 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance4 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance22 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance8 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance39 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance40 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim EditorButton2 As Infragistics.Win.UltraWinEditors.EditorButton = New Infragistics.Win.UltraWinEditors.EditorButton()
        Dim Appearance14 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance41 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraTab1 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraTab2 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Me.UltraTabPageControl1 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.ubtn_refrescar = New Infragistics.Win.Misc.UltraButton()
        Me.ubtn_atraz = New Infragistics.Win.Misc.UltraButton()
        Me.ug_detalle = New Infragistics.Win.UltraWinGrid.UltraGrid()
        Me.uds_detalle = New Infragistics.Win.UltraWinDataSource.UltraDataSource(Me.components)
        Me.ug_nombres = New Infragistics.Win.UltraWinGrid.UltraGrid()
        Me.uds_nombres = New Infragistics.Win.UltraWinDataSource.UltraDataSource(Me.components)
        Me.uos_tipos = New Infragistics.Win.UltraWinEditors.UltraOptionSet()
        Me.UltraTabPageControl2 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.gb3 = New System.Windows.Forms.GroupBox()
        Me.txt_citt = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.txt_obs = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.uchk_Procesar = New Infragistics.Win.UltraWinEditors.UltraCheckEditor()
        Me.lbl_obs = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraLabel14 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraLabel12 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraLabel8 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraLabel9 = New Infragistics.Win.Misc.UltraLabel()
        Me.uce_tipo_suspe_sunat = New Infragistics.Win.UltraWinEditors.UltraComboEditor()
        Me.gb2 = New System.Windows.Forms.GroupBox()
        Me.txt_IdPersonal = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.pa_otros = New System.Windows.Forms.Panel()
        Me.UltraLabel13 = New Infragistics.Win.Misc.UltraLabel()
        Me.udte_per_ini = New Infragistics.Win.UltraWinEditors.UltraDateTimeEditor()
        Me.udte_per_fin = New Infragistics.Win.UltraWinEditors.UltraDateTimeEditor()
        Me.UltraLabel11 = New Infragistics.Win.Misc.UltraLabel()
        Me.Pa_Vaca = New System.Windows.Forms.Panel()
        Me.uce_Periodos_vaca = New Infragistics.Win.UltraWinEditors.UltraComboEditor()
        Me.txt_id_registro = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.une_Dias_Traba = New Infragistics.Win.UltraWinEditors.UltraNumericEditor()
        Me.une_dias_vaca = New Infragistics.Win.UltraWinEditors.UltraNumericEditor()
        Me.udte_fecha_fin = New Infragistics.Win.UltraWinEditors.UltraDateTimeEditor()
        Me.udte_fecha_inicio = New Infragistics.Win.UltraWinEditors.UltraDateTimeEditor()
        Me.UltraLabel7 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraLabel6 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraLabel2 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraLabel5 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraLabel4 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraLabel1 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraLabel3 = New Infragistics.Win.Misc.UltraLabel()
        Me.uce_Tipo_Suspension = New Infragistics.Win.UltraWinEditors.UltraComboEditor()
        Me.gb1 = New System.Windows.Forms.GroupBox()
        Me.txt_nombres = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.txt_id_personal = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.txt_cod_personal = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.UltraLabel10 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraTabPageControl4 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.UltraGroupBox2 = New Infragistics.Win.Misc.UltraGroupBox()
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
        Me.UltraGroupBox1 = New Infragistics.Win.Misc.UltraGroupBox()
        Me.txt_nom_per = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.txt_cod_per = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.txt_id_per = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.UltraLabel15 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraTabPageControl3 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.Tool_Grabar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.UltraTabSharedControlsPage1 = New Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage()
        Me.ToolS_Mantenimiento = New System.Windows.Forms.ToolStrip()
        Me.Tool_Nuevo = New System.Windows.Forms.ToolStripButton()
        Me.Tool_Editar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.Tool_Cancelar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.Tool_Eliminar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator()
        Me.Tool_Salir = New System.Windows.Forms.ToolStripButton()
        Me.utc_Contenedor = New Infragistics.Win.UltraWinTabControl.UltraTabControl()
        Me.uchk_congoce = New Infragistics.Win.UltraWinEditors.UltraCheckEditor()
        Me.UltraTabPageControl1.SuspendLayout()
        CType(Me.ug_detalle, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.uds_detalle, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ug_nombres, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.uds_nombres, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.uos_tipos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabPageControl2.SuspendLayout()
        Me.gb3.SuspendLayout()
        CType(Me.txt_citt, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_obs, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.uce_tipo_suspe_sunat, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gb2.SuspendLayout()
        CType(Me.txt_IdPersonal, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pa_otros.SuspendLayout()
        CType(Me.udte_per_ini, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.udte_per_fin, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Pa_Vaca.SuspendLayout()
        CType(Me.uce_Periodos_vaca, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_id_registro, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.une_Dias_Traba, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.une_dias_vaca, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.udte_fecha_fin, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.udte_fecha_inicio, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.uce_Tipo_Suspension, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gb1.SuspendLayout()
        CType(Me.txt_nombres, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_id_personal, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_cod_personal, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabPageControl4.SuspendLayout()
        CType(Me.UltraGroupBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraGroupBox2.SuspendLayout()
        CType(Me.uce_periodo_compra, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.udte_fec_liqui, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_obs_compra, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.une_dias_compra, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UltraGroupBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraGroupBox1.SuspendLayout()
        CType(Me.txt_nom_per, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_cod_per, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_id_per, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolS_Mantenimiento.SuspendLayout()
        CType(Me.utc_Contenedor, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.utc_Contenedor.SuspendLayout()
        Me.SuspendLayout()
        '
        'UltraTabPageControl1
        '
        Me.UltraTabPageControl1.Controls.Add(Me.ubtn_refrescar)
        Me.UltraTabPageControl1.Controls.Add(Me.ubtn_atraz)
        Me.UltraTabPageControl1.Controls.Add(Me.ug_detalle)
        Me.UltraTabPageControl1.Controls.Add(Me.ug_nombres)
        Me.UltraTabPageControl1.Controls.Add(Me.uos_tipos)
        Me.UltraTabPageControl1.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl1.Name = "UltraTabPageControl1"
        Me.UltraTabPageControl1.Size = New System.Drawing.Size(724, 377)
        '
        'ubtn_refrescar
        '
        Me.ubtn_refrescar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Appearance18.ImageHAlign = Infragistics.Win.HAlign.Center
        Me.ubtn_refrescar.Appearance = Appearance18
        Me.ubtn_refrescar.Location = New System.Drawing.Point(683, 15)
        Me.ubtn_refrescar.Name = "ubtn_refrescar"
        Me.ubtn_refrescar.Size = New System.Drawing.Size(32, 27)
        Me.ubtn_refrescar.TabIndex = 5
        '
        'ubtn_atraz
        '
        Me.ubtn_atraz.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ubtn_atraz.Location = New System.Drawing.Point(599, 15)
        Me.ubtn_atraz.Name = "ubtn_atraz"
        Me.ubtn_atraz.Size = New System.Drawing.Size(78, 27)
        Me.ubtn_atraz.TabIndex = 4
        Me.ubtn_atraz.Text = "Atraz"
        '
        'ug_detalle
        '
        Me.ug_detalle.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ug_detalle.DataSource = Me.uds_detalle
        Me.ug_detalle.DisplayLayout.AutoFitStyle = Infragistics.Win.UltraWinGrid.AutoFitStyle.ResizeAllColumns
        UltraGridColumn1.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn1.Header.VisiblePosition = 0
        UltraGridColumn1.Hidden = True
        UltraGridColumn1.Width = 48
        UltraGridColumn2.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn2.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn2.Header.Caption = "PERIODO"
        UltraGridColumn2.Header.VisiblePosition = 1
        UltraGridColumn2.Width = 53
        UltraGridColumn3.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn3.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        Appearance11.TextHAlignAsString = "Center"
        UltraGridColumn3.CellAppearance = Appearance11
        UltraGridColumn3.Header.Caption = "FECHA_INI"
        UltraGridColumn3.Header.VisiblePosition = 2
        UltraGridColumn3.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Date]
        UltraGridColumn3.Width = 78
        UltraGridColumn4.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn4.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        Appearance16.TextHAlignAsString = "Center"
        UltraGridColumn4.CellAppearance = Appearance16
        UltraGridColumn4.Header.Caption = "FECHA_FIN"
        UltraGridColumn4.Header.VisiblePosition = 3
        UltraGridColumn4.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Date]
        UltraGridColumn4.Width = 77
        UltraGridColumn5.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn5.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        Appearance17.TextHAlignAsString = "Center"
        UltraGridColumn5.CellAppearance = Appearance17
        UltraGridColumn5.Header.Caption = "DIAS VAC."
        UltraGridColumn5.Header.VisiblePosition = 4
        UltraGridColumn5.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Integer]
        UltraGridColumn5.Width = 66
        UltraGridColumn6.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn6.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn6.Header.Caption = "OBS."
        UltraGridColumn6.Header.VisiblePosition = 7
        UltraGridColumn6.Width = 254
        UltraGridColumn7.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn7.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn7.Header.Caption = "PROCESAR"
        UltraGridColumn7.Header.VisiblePosition = 5
        UltraGridColumn7.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.CheckBox
        UltraGridColumn7.Width = 92
        UltraGridColumn8.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn8.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn8.Header.Caption = "PROCESADO"
        UltraGridColumn8.Header.VisiblePosition = 6
        UltraGridColumn8.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.CheckBox
        UltraGridColumn8.Width = 99
        UltraGridBand1.Columns.AddRange(New Object() {UltraGridColumn1, UltraGridColumn2, UltraGridColumn3, UltraGridColumn4, UltraGridColumn5, UltraGridColumn6, UltraGridColumn7, UltraGridColumn8})
        Appearance19.BackColor = System.Drawing.Color.White
        Appearance19.ForeColor = System.Drawing.Color.Navy
        Appearance19.TextHAlignAsString = "Center"
        SummarySettings1.Appearance = Appearance19
        SummarySettings1.DisplayFormat = "Tot. {0}"
        SummarySettings1.GroupBySummaryValueAppearance = Appearance20
        SummarySettings1.SummaryDisplayArea = Infragistics.Win.UltraWinGrid.SummaryDisplayAreas.BottomFixed
        UltraGridBand1.Summaries.AddRange(New Infragistics.Win.UltraWinGrid.SummarySettings() {SummarySettings1})
        UltraGridBand1.SummaryFooterCaption = ""
        Me.ug_detalle.DisplayLayout.BandsSerializer.Add(UltraGridBand1)
        Me.ug_detalle.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.[True]
        Appearance44.BackColor = System.Drawing.Color.Silver
        Me.ug_detalle.DisplayLayout.GroupByBox.Appearance = Appearance44
        Appearance45.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ug_detalle.DisplayLayout.GroupByBox.BandLabelAppearance = Appearance45
        Me.ug_detalle.DisplayLayout.GroupByBox.Prompt = " "
        Appearance46.BackColor = System.Drawing.Color.Lime
        Appearance46.FontData.BoldAsString = "False"
        Me.ug_detalle.DisplayLayout.GroupByBox.PromptAppearance = Appearance46
        Me.ug_detalle.DisplayLayout.MaxRowScrollRegions = 1
        Me.ug_detalle.DisplayLayout.Override.GroupBySummaryDisplayStyle = Infragistics.Win.UltraWinGrid.GroupBySummaryDisplayStyle.SummaryCells
        Me.ug_detalle.DisplayLayout.Override.SummaryDisplayArea = Infragistics.Win.UltraWinGrid.SummaryDisplayAreas.GroupByRowsFooter
        Me.ug_detalle.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.ug_detalle.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.ug_detalle.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy
        Me.ug_detalle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ug_detalle.Location = New System.Drawing.Point(13, 48)
        Me.ug_detalle.Name = "ug_detalle"
        Me.ug_detalle.Size = New System.Drawing.Size(702, 334)
        Me.ug_detalle.TabIndex = 3
        Me.ug_detalle.Text = "UltraGrid1"
        Me.ug_detalle.Visible = False
        '
        'uds_detalle
        '
        Me.uds_detalle.AllowDelete = False
        UltraDataColumn1.DataType = GetType(Integer)
        UltraDataColumn3.DataType = GetType(Date)
        UltraDataColumn4.DataType = GetType(Date)
        UltraDataColumn5.DataType = GetType(Short)
        Me.uds_detalle.Band.Columns.AddRange(New Object() {UltraDataColumn1, UltraDataColumn2, UltraDataColumn3, UltraDataColumn4, UltraDataColumn5, UltraDataColumn6, UltraDataColumn7, UltraDataColumn8})
        '
        'ug_nombres
        '
        Me.ug_nombres.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ug_nombres.DataSource = Me.uds_nombres
        Me.ug_nombres.DisplayLayout.AutoFitStyle = Infragistics.Win.UltraWinGrid.AutoFitStyle.ExtendLastColumn
        UltraGridColumn9.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn9.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn9.Header.Caption = "ID"
        UltraGridColumn9.Header.VisiblePosition = 0
        UltraGridColumn9.Width = 51
        UltraGridColumn10.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn10.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn10.Header.Caption = "CODIGO"
        UltraGridColumn10.Header.VisiblePosition = 1
        UltraGridColumn10.Width = 106
        UltraGridColumn11.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn11.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn11.Header.VisiblePosition = 2
        UltraGridBand2.Columns.AddRange(New Object() {UltraGridColumn9, UltraGridColumn10, UltraGridColumn11})
        Me.ug_nombres.DisplayLayout.BandsSerializer.Add(UltraGridBand2)
        Me.ug_nombres.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.[False]
        Me.ug_nombres.DisplayLayout.MaxColScrollRegions = 1
        Me.ug_nombres.DisplayLayout.MaxRowScrollRegions = 1
        Appearance24.BackColor = System.Drawing.Color.Beige
        Me.ug_nombres.DisplayLayout.Override.FilterRowAppearance = Appearance24
        Me.ug_nombres.DisplayLayout.Override.FilterUIType = Infragistics.Win.UltraWinGrid.FilterUIType.FilterRow
        Me.ug_nombres.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Appearance25.BackColor = System.Drawing.Color.WhiteSmoke
        Appearance25.BackColor2 = System.Drawing.Color.WhiteSmoke
        Me.ug_nombres.DisplayLayout.Override.RowAlternateAppearance = Appearance25
        Me.ug_nombres.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.ug_nombres.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.ug_nombres.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ug_nombres.Location = New System.Drawing.Point(13, 48)
        Me.ug_nombres.Name = "ug_nombres"
        Me.ug_nombres.Size = New System.Drawing.Size(702, 326)
        Me.ug_nombres.TabIndex = 2
        Me.ug_nombres.Text = "UltraGrid1"
        '
        'uds_nombres
        '
        Me.uds_nombres.AllowDelete = False
        Me.uds_nombres.Band.Columns.AddRange(New Object() {UltraDataColumn9, UltraDataColumn10, UltraDataColumn11})
        '
        'uos_tipos
        '
        Appearance12.ForeColor = System.Drawing.Color.Navy
        Me.uos_tipos.Appearance = Appearance12
        Me.uos_tipos.BackColor = System.Drawing.Color.Transparent
        Me.uos_tipos.BackColorInternal = System.Drawing.Color.Transparent
        Me.uos_tipos.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.uos_tipos.ItemSpacingHorizontal = 10
        Me.uos_tipos.ItemSpacingVertical = 5
        Me.uos_tipos.Location = New System.Drawing.Point(13, 10)
        Me.uos_tipos.Name = "uos_tipos"
        Me.uos_tipos.Size = New System.Drawing.Size(462, 32)
        Me.uos_tipos.TabIndex = 1
        '
        'UltraTabPageControl2
        '
        Me.UltraTabPageControl2.Controls.Add(Me.gb3)
        Me.UltraTabPageControl2.Controls.Add(Me.gb2)
        Me.UltraTabPageControl2.Controls.Add(Me.gb1)
        Me.UltraTabPageControl2.Location = New System.Drawing.Point(1, 23)
        Me.UltraTabPageControl2.Name = "UltraTabPageControl2"
        Me.UltraTabPageControl2.Size = New System.Drawing.Size(724, 377)
        '
        'gb3
        '
        Me.gb3.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gb3.Controls.Add(Me.txt_citt)
        Me.gb3.Controls.Add(Me.txt_obs)
        Me.gb3.Controls.Add(Me.uchk_congoce)
        Me.gb3.Controls.Add(Me.uchk_Procesar)
        Me.gb3.Controls.Add(Me.lbl_obs)
        Me.gb3.Controls.Add(Me.UltraLabel14)
        Me.gb3.Controls.Add(Me.UltraLabel12)
        Me.gb3.Controls.Add(Me.UltraLabel8)
        Me.gb3.Controls.Add(Me.UltraLabel9)
        Me.gb3.Controls.Add(Me.uce_tipo_suspe_sunat)
        Me.gb3.Location = New System.Drawing.Point(18, 199)
        Me.gb3.Name = "gb3"
        Me.gb3.Size = New System.Drawing.Size(694, 161)
        Me.gb3.TabIndex = 13
        Me.gb3.TabStop = False
        Me.gb3.Text = "Observaciones"
        '
        'txt_citt
        '
        Me.txt_citt.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_citt.Location = New System.Drawing.Point(105, 55)
        Me.txt_citt.Name = "txt_citt"
        Me.txt_citt.Size = New System.Drawing.Size(224, 21)
        Me.txt_citt.TabIndex = 10
        '
        'txt_obs
        '
        Me.txt_obs.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_obs.Location = New System.Drawing.Point(105, 89)
        Me.txt_obs.MaxLength = 250
        Me.txt_obs.Name = "txt_obs"
        Me.txt_obs.Size = New System.Drawing.Size(558, 21)
        Me.txt_obs.TabIndex = 9
        '
        'uchk_Procesar
        '
        Me.uchk_Procesar.BackColor = System.Drawing.Color.Transparent
        Me.uchk_Procesar.BackColorInternal = System.Drawing.Color.Transparent
        Me.uchk_Procesar.Location = New System.Drawing.Point(105, 123)
        Me.uchk_Procesar.Name = "uchk_Procesar"
        Me.uchk_Procesar.Size = New System.Drawing.Size(120, 20)
        Me.uchk_Procesar.TabIndex = 7
        Me.uchk_Procesar.Text = "Considerar"
        '
        'lbl_obs
        '
        Me.lbl_obs.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Appearance2.BackColor = System.Drawing.Color.Transparent
        Appearance2.ForeColor = System.Drawing.Color.Navy
        Me.lbl_obs.Appearance = Appearance2
        Me.lbl_obs.AutoSize = True
        Me.lbl_obs.Location = New System.Drawing.Point(598, 123)
        Me.lbl_obs.Name = "lbl_obs"
        Me.lbl_obs.Size = New System.Drawing.Size(14, 14)
        Me.lbl_obs.TabIndex = 8
        Me.lbl_obs.Text = "..."
        '
        'UltraLabel14
        '
        Appearance15.BackColor = System.Drawing.Color.Transparent
        Appearance15.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel14.Appearance = Appearance15
        Me.UltraLabel14.AutoSize = True
        Me.UltraLabel14.Location = New System.Drawing.Point(40, 62)
        Me.UltraLabel14.Name = "UltraLabel14"
        Me.UltraLabel14.Size = New System.Drawing.Size(45, 14)
        Me.UltraLabel14.TabIndex = 8
        Me.UltraLabel14.Text = "N° CITT"
        '
        'UltraLabel12
        '
        Appearance23.BackColor = System.Drawing.Color.Transparent
        Appearance23.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel12.Appearance = Appearance23
        Me.UltraLabel12.AutoSize = True
        Me.UltraLabel12.Location = New System.Drawing.Point(10, 92)
        Me.UltraLabel12.Name = "UltraLabel12"
        Me.UltraLabel12.Size = New System.Drawing.Size(80, 14)
        Me.UltraLabel12.TabIndex = 8
        Me.UltraLabel12.Text = "Observaciones"
        '
        'UltraLabel8
        '
        Appearance42.BackColor = System.Drawing.Color.Transparent
        Appearance42.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel8.Appearance = Appearance42
        Me.UltraLabel8.AutoSize = True
        Me.UltraLabel8.Location = New System.Drawing.Point(36, 126)
        Me.UltraLabel8.Name = "UltraLabel8"
        Me.UltraLabel8.Size = New System.Drawing.Size(49, 14)
        Me.UltraLabel8.TabIndex = 8
        Me.UltraLabel8.Text = "Procesar"
        '
        'UltraLabel9
        '
        Appearance5.BackColor = System.Drawing.Color.Transparent
        Appearance5.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel9.Appearance = Appearance5
        Me.UltraLabel9.Location = New System.Drawing.Point(10, 19)
        Me.UltraLabel9.Name = "UltraLabel9"
        Me.UltraLabel9.Size = New System.Drawing.Size(89, 37)
        Me.UltraLabel9.TabIndex = 8
        Me.UltraLabel9.Text = "Tipo Suspension Laboral  - Sunat"
        '
        'uce_tipo_suspe_sunat
        '
        Me.uce_tipo_suspe_sunat.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.uce_tipo_suspe_sunat.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.uce_tipo_suspe_sunat.Location = New System.Drawing.Point(105, 19)
        Me.uce_tipo_suspe_sunat.Name = "uce_tipo_suspe_sunat"
        Me.uce_tipo_suspe_sunat.Size = New System.Drawing.Size(484, 21)
        Me.uce_tipo_suspe_sunat.TabIndex = 6
        '
        'gb2
        '
        Me.gb2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gb2.Controls.Add(Me.txt_IdPersonal)
        Me.gb2.Controls.Add(Me.pa_otros)
        Me.gb2.Controls.Add(Me.UltraLabel11)
        Me.gb2.Controls.Add(Me.Pa_Vaca)
        Me.gb2.Controls.Add(Me.txt_id_registro)
        Me.gb2.Controls.Add(Me.une_Dias_Traba)
        Me.gb2.Controls.Add(Me.une_dias_vaca)
        Me.gb2.Controls.Add(Me.udte_fecha_fin)
        Me.gb2.Controls.Add(Me.udte_fecha_inicio)
        Me.gb2.Controls.Add(Me.UltraLabel7)
        Me.gb2.Controls.Add(Me.UltraLabel6)
        Me.gb2.Controls.Add(Me.UltraLabel2)
        Me.gb2.Controls.Add(Me.UltraLabel5)
        Me.gb2.Controls.Add(Me.UltraLabel4)
        Me.gb2.Controls.Add(Me.UltraLabel1)
        Me.gb2.Controls.Add(Me.UltraLabel3)
        Me.gb2.Controls.Add(Me.uce_Tipo_Suspension)
        Me.gb2.Location = New System.Drawing.Point(18, 68)
        Me.gb2.Name = "gb2"
        Me.gb2.Size = New System.Drawing.Size(694, 125)
        Me.gb2.TabIndex = 12
        Me.gb2.TabStop = False
        Me.gb2.Text = "Detalle de Salida"
        '
        'txt_IdPersonal
        '
        Me.txt_IdPersonal.Location = New System.Drawing.Point(262, 35)
        Me.txt_IdPersonal.Name = "txt_IdPersonal"
        Me.txt_IdPersonal.Size = New System.Drawing.Size(35, 21)
        Me.txt_IdPersonal.TabIndex = 13
        Me.txt_IdPersonal.Visible = False
        '
        'pa_otros
        '
        Me.pa_otros.Controls.Add(Me.UltraLabel13)
        Me.pa_otros.Controls.Add(Me.udte_per_ini)
        Me.pa_otros.Controls.Add(Me.udte_per_fin)
        Me.pa_otros.Location = New System.Drawing.Point(430, 19)
        Me.pa_otros.Name = "pa_otros"
        Me.pa_otros.Size = New System.Drawing.Size(254, 41)
        Me.pa_otros.TabIndex = 12
        '
        'UltraLabel13
        '
        Appearance7.BackColor = System.Drawing.Color.Transparent
        Appearance7.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel13.Appearance = Appearance7
        Me.UltraLabel13.AutoSize = True
        Me.UltraLabel13.Location = New System.Drawing.Point(113, 13)
        Me.UltraLabel13.Name = "UltraLabel13"
        Me.UltraLabel13.Size = New System.Drawing.Size(12, 14)
        Me.UltraLabel13.TabIndex = 9
        Me.UltraLabel13.Text = "A"
        '
        'udte_per_ini
        '
        Me.udte_per_ini.Location = New System.Drawing.Point(3, 9)
        Me.udte_per_ini.MaskInput = ""
        Me.udte_per_ini.Name = "udte_per_ini"
        Me.udte_per_ini.Size = New System.Drawing.Size(96, 21)
        Me.udte_per_ini.TabIndex = 0
        '
        'udte_per_fin
        '
        Me.udte_per_fin.Location = New System.Drawing.Point(139, 9)
        Me.udte_per_fin.Name = "udte_per_fin"
        Me.udte_per_fin.Size = New System.Drawing.Size(96, 21)
        Me.udte_per_fin.TabIndex = 0
        '
        'UltraLabel11
        '
        Appearance43.BackColor = System.Drawing.Color.Transparent
        Appearance43.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel11.Appearance = Appearance43
        Me.UltraLabel11.AutoSize = True
        Me.UltraLabel11.Location = New System.Drawing.Point(376, 32)
        Me.UltraLabel11.Name = "UltraLabel11"
        Me.UltraLabel11.Size = New System.Drawing.Size(43, 14)
        Me.UltraLabel11.TabIndex = 8
        Me.UltraLabel11.Text = "Periodo"
        '
        'Pa_Vaca
        '
        Me.Pa_Vaca.Controls.Add(Me.uce_Periodos_vaca)
        Me.Pa_Vaca.Location = New System.Drawing.Point(430, 19)
        Me.Pa_Vaca.Name = "Pa_Vaca"
        Me.Pa_Vaca.Size = New System.Drawing.Size(254, 41)
        Me.Pa_Vaca.TabIndex = 11
        '
        'uce_Periodos_vaca
        '
        Me.uce_Periodos_vaca.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.uce_Periodos_vaca.Location = New System.Drawing.Point(4, 8)
        Me.uce_Periodos_vaca.Name = "uce_Periodos_vaca"
        Me.uce_Periodos_vaca.Size = New System.Drawing.Size(158, 21)
        Me.uce_Periodos_vaca.TabIndex = 10
        '
        'txt_id_registro
        '
        Me.txt_id_registro.Location = New System.Drawing.Point(221, 35)
        Me.txt_id_registro.Name = "txt_id_registro"
        Me.txt_id_registro.Size = New System.Drawing.Size(35, 21)
        Me.txt_id_registro.TabIndex = 8
        Me.txt_id_registro.Visible = False
        '
        'une_Dias_Traba
        '
        Me.une_Dias_Traba.Location = New System.Drawing.Point(432, 89)
        Me.une_Dias_Traba.MaskInput = "nn"
        Me.une_Dias_Traba.Name = "une_Dias_Traba"
        Me.une_Dias_Traba.Size = New System.Drawing.Size(41, 21)
        Me.une_Dias_Traba.TabIndex = 5
        '
        'une_dias_vaca
        '
        Me.une_dias_vaca.Location = New System.Drawing.Point(432, 62)
        Me.une_dias_vaca.MaskInput = "nn"
        Me.une_dias_vaca.Name = "une_dias_vaca"
        Me.une_dias_vaca.Size = New System.Drawing.Size(41, 21)
        Me.une_dias_vaca.TabIndex = 4
        '
        'udte_fecha_fin
        '
        Me.udte_fecha_fin.Location = New System.Drawing.Point(71, 89)
        Me.udte_fecha_fin.Name = "udte_fecha_fin"
        Me.udte_fecha_fin.Size = New System.Drawing.Size(144, 21)
        Me.udte_fecha_fin.TabIndex = 3
        '
        'udte_fecha_inicio
        '
        Me.udte_fecha_inicio.Location = New System.Drawing.Point(71, 62)
        Me.udte_fecha_inicio.Name = "udte_fecha_inicio"
        Me.udte_fecha_inicio.Size = New System.Drawing.Size(144, 21)
        Me.udte_fecha_inicio.TabIndex = 2
        '
        'UltraLabel7
        '
        Appearance21.BackColor = System.Drawing.Color.Transparent
        Appearance21.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel7.Appearance = Appearance21
        Me.UltraLabel7.AutoSize = True
        Me.UltraLabel7.Location = New System.Drawing.Point(479, 93)
        Me.UltraLabel7.Name = "UltraLabel7"
        Me.UltraLabel7.Size = New System.Drawing.Size(68, 14)
        Me.UltraLabel7.TabIndex = 8
        Me.UltraLabel7.Text = "Dias Trabajo"
        '
        'UltraLabel6
        '
        Appearance6.BackColor = System.Drawing.Color.Transparent
        Appearance6.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel6.Appearance = Appearance6
        Me.UltraLabel6.AutoSize = True
        Me.UltraLabel6.Location = New System.Drawing.Point(479, 66)
        Me.UltraLabel6.Name = "UltraLabel6"
        Me.UltraLabel6.Size = New System.Drawing.Size(115, 14)
        Me.UltraLabel6.TabIndex = 8
        Me.UltraLabel6.Text = "Dias Vacac. / Suspen."
        '
        'UltraLabel2
        '
        Appearance38.BackColor = System.Drawing.Color.Transparent
        Appearance38.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel2.Appearance = Appearance38
        Me.UltraLabel2.AutoSize = True
        Me.UltraLabel2.Location = New System.Drawing.Point(392, 66)
        Me.UltraLabel2.Name = "UltraLabel2"
        Me.UltraLabel2.Size = New System.Drawing.Size(27, 14)
        Me.UltraLabel2.TabIndex = 8
        Me.UltraLabel2.Text = "Dias"
        '
        'UltraLabel5
        '
        Appearance1.BackColor = System.Drawing.Color.Transparent
        Appearance1.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel5.Appearance = Appearance1
        Me.UltraLabel5.AutoSize = True
        Me.UltraLabel5.Location = New System.Drawing.Point(221, 91)
        Me.UltraLabel5.Name = "UltraLabel5"
        Me.UltraLabel5.Size = New System.Drawing.Size(88, 14)
        Me.UltraLabel5.TabIndex = 8
        Me.UltraLabel5.Text = "(Fecha Termino)"
        '
        'UltraLabel4
        '
        Appearance3.BackColor = System.Drawing.Color.Transparent
        Appearance3.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel4.Appearance = Appearance3
        Me.UltraLabel4.AutoSize = True
        Me.UltraLabel4.Location = New System.Drawing.Point(221, 66)
        Me.UltraLabel4.Name = "UltraLabel4"
        Me.UltraLabel4.Size = New System.Drawing.Size(97, 14)
        Me.UltraLabel4.TabIndex = 8
        Me.UltraLabel4.Text = "(Fecha Comienzo)"
        '
        'UltraLabel1
        '
        Appearance13.BackColor = System.Drawing.Color.Transparent
        Appearance13.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel1.Appearance = Appearance13
        Me.UltraLabel1.AutoSize = True
        Me.UltraLabel1.Location = New System.Drawing.Point(22, 66)
        Me.UltraLabel1.Name = "UltraLabel1"
        Me.UltraLabel1.Size = New System.Drawing.Size(36, 14)
        Me.UltraLabel1.TabIndex = 8
        Me.UltraLabel1.Text = "Salida"
        '
        'UltraLabel3
        '
        Appearance9.BackColor = System.Drawing.Color.Transparent
        Appearance9.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel3.Appearance = Appearance9
        Me.UltraLabel3.AutoSize = True
        Me.UltraLabel3.Location = New System.Drawing.Point(32, 35)
        Me.UltraLabel3.Name = "UltraLabel3"
        Me.UltraLabel3.Size = New System.Drawing.Size(26, 14)
        Me.UltraLabel3.TabIndex = 8
        Me.UltraLabel3.Text = "Tipo "
        '
        'uce_Tipo_Suspension
        '
        Me.uce_Tipo_Suspension.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.uce_Tipo_Suspension.Location = New System.Drawing.Point(71, 35)
        Me.uce_Tipo_Suspension.Name = "uce_Tipo_Suspension"
        Me.uce_Tipo_Suspension.Size = New System.Drawing.Size(144, 21)
        Me.uce_Tipo_Suspension.TabIndex = 1
        '
        'gb1
        '
        Me.gb1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gb1.Controls.Add(Me.txt_nombres)
        Me.gb1.Controls.Add(Me.txt_id_personal)
        Me.gb1.Controls.Add(Me.txt_cod_personal)
        Me.gb1.Controls.Add(Me.UltraLabel10)
        Me.gb1.Location = New System.Drawing.Point(18, 14)
        Me.gb1.Name = "gb1"
        Me.gb1.Size = New System.Drawing.Size(692, 48)
        Me.gb1.TabIndex = 11
        Me.gb1.TabStop = False
        Me.gb1.Text = "Identificacion"
        '
        'txt_nombres
        '
        Me.txt_nombres.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_nombres.Location = New System.Drawing.Point(242, 18)
        Me.txt_nombres.Name = "txt_nombres"
        Me.txt_nombres.ReadOnly = True
        Me.txt_nombres.Size = New System.Drawing.Size(423, 21)
        Me.txt_nombres.TabIndex = 9
        '
        'txt_id_personal
        '
        Me.txt_id_personal.Location = New System.Drawing.Point(173, 18)
        Me.txt_id_personal.Name = "txt_id_personal"
        Me.txt_id_personal.ReadOnly = True
        Me.txt_id_personal.Size = New System.Drawing.Size(69, 21)
        Me.txt_id_personal.TabIndex = 8
        '
        'txt_cod_personal
        '
        Appearance28.ImageHAlign = Infragistics.Win.HAlign.Center
        EditorButton1.Appearance = Appearance28
        Me.txt_cod_personal.ButtonsRight.Add(EditorButton1)
        Me.txt_cod_personal.Location = New System.Drawing.Point(72, 18)
        Me.txt_cod_personal.Name = "txt_cod_personal"
        Me.txt_cod_personal.Size = New System.Drawing.Size(101, 21)
        Me.txt_cod_personal.TabIndex = 0
        '
        'UltraLabel10
        '
        Appearance29.BackColor = System.Drawing.Color.Transparent
        Appearance29.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel10.Appearance = Appearance29
        Me.UltraLabel10.AutoSize = True
        Me.UltraLabel10.Location = New System.Drawing.Point(17, 21)
        Me.UltraLabel10.Name = "UltraLabel10"
        Me.UltraLabel10.Size = New System.Drawing.Size(49, 14)
        Me.UltraLabel10.TabIndex = 8
        Me.UltraLabel10.Text = "Personal"
        '
        'UltraTabPageControl4
        '
        Me.UltraTabPageControl4.Controls.Add(Me.UltraGroupBox2)
        Me.UltraTabPageControl4.Controls.Add(Me.UltraGroupBox1)
        Me.UltraTabPageControl4.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl4.Name = "UltraTabPageControl4"
        Me.UltraTabPageControl4.Size = New System.Drawing.Size(730, 357)
        '
        'UltraGroupBox2
        '
        Me.UltraGroupBox2.Controls.Add(Me.uchk_consi_liqui)
        Me.UltraGroupBox2.Controls.Add(Me.UltraLabel21)
        Me.UltraGroupBox2.Controls.Add(Me.uce_periodo_compra)
        Me.UltraGroupBox2.Controls.Add(Me.UltraLabel20)
        Me.UltraGroupBox2.Controls.Add(Me.udte_fec_liqui)
        Me.UltraGroupBox2.Controls.Add(Me.ume_importe_compra)
        Me.UltraGroupBox2.Controls.Add(Me.txt_obs_compra)
        Me.UltraGroupBox2.Controls.Add(Me.une_dias_compra)
        Me.UltraGroupBox2.Controls.Add(Me.UltraLabel19)
        Me.UltraGroupBox2.Controls.Add(Me.UltraLabel18)
        Me.UltraGroupBox2.Controls.Add(Me.UltraLabel17)
        Me.UltraGroupBox2.Controls.Add(Me.UltraLabel16)
        Me.UltraGroupBox2.Location = New System.Drawing.Point(16, 84)
        Me.UltraGroupBox2.Name = "UltraGroupBox2"
        Me.UltraGroupBox2.Size = New System.Drawing.Size(467, 262)
        Me.UltraGroupBox2.TabIndex = 14
        Me.UltraGroupBox2.Text = "Detalle de Compra"
        '
        'uchk_consi_liqui
        '
        Me.uchk_consi_liqui.BackColor = System.Drawing.Color.Transparent
        Me.uchk_consi_liqui.BackColorInternal = System.Drawing.Color.Transparent
        Me.uchk_consi_liqui.Checked = True
        Me.uchk_consi_liqui.CheckState = System.Windows.Forms.CheckState.Checked
        Me.uchk_consi_liqui.Location = New System.Drawing.Point(156, 199)
        Me.uchk_consi_liqui.Name = "uchk_consi_liqui"
        Me.uchk_consi_liqui.Size = New System.Drawing.Size(120, 20)
        Me.uchk_consi_liqui.TabIndex = 17
        Me.uchk_consi_liqui.Text = "Considerar"
        '
        'UltraLabel21
        '
        Appearance10.BackColor = System.Drawing.Color.Transparent
        Appearance10.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel21.Appearance = Appearance10
        Me.UltraLabel21.AutoSize = True
        Me.UltraLabel21.Location = New System.Drawing.Point(33, 202)
        Me.UltraLabel21.Name = "UltraLabel21"
        Me.UltraLabel21.Size = New System.Drawing.Size(49, 14)
        Me.UltraLabel21.TabIndex = 18
        Me.UltraLabel21.Text = "Procesar"
        '
        'uce_periodo_compra
        '
        Me.uce_periodo_compra.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.uce_periodo_compra.Location = New System.Drawing.Point(156, 89)
        Me.uce_periodo_compra.Name = "uce_periodo_compra"
        Me.uce_periodo_compra.Size = New System.Drawing.Size(158, 21)
        Me.uce_periodo_compra.TabIndex = 16
        '
        'UltraLabel20
        '
        Appearance4.BackColor = System.Drawing.Color.Transparent
        Appearance4.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel20.Appearance = Appearance4
        Me.UltraLabel20.AutoSize = True
        Me.UltraLabel20.Location = New System.Drawing.Point(32, 96)
        Me.UltraLabel20.Name = "UltraLabel20"
        Me.UltraLabel20.Size = New System.Drawing.Size(43, 14)
        Me.UltraLabel20.TabIndex = 15
        Me.UltraLabel20.Text = "Periodo"
        '
        'udte_fec_liqui
        '
        Me.udte_fec_liqui.Location = New System.Drawing.Point(155, 116)
        Me.udte_fec_liqui.Name = "udte_fec_liqui"
        Me.udte_fec_liqui.Size = New System.Drawing.Size(121, 21)
        Me.udte_fec_liqui.TabIndex = 14
        '
        'ume_importe_compra
        '
        Me.ume_importe_compra.EditAs = Infragistics.Win.UltraWinMaskedEdit.EditAsType.UseSpecifiedMask
        Me.ume_importe_compra.InputMask = "{double:9.2}"
        Me.ume_importe_compra.Location = New System.Drawing.Point(156, 63)
        Me.ume_importe_compra.Name = "ume_importe_compra"
        Me.ume_importe_compra.Size = New System.Drawing.Size(79, 20)
        Me.ume_importe_compra.TabIndex = 13
        Me.ume_importe_compra.Text = "UltraMaskedEdit1"
        '
        'txt_obs_compra
        '
        Me.txt_obs_compra.Location = New System.Drawing.Point(156, 169)
        Me.txt_obs_compra.MaxLength = 250
        Me.txt_obs_compra.Name = "txt_obs_compra"
        Me.txt_obs_compra.Size = New System.Drawing.Size(280, 21)
        Me.txt_obs_compra.TabIndex = 12
        '
        'une_dias_compra
        '
        Me.une_dias_compra.Location = New System.Drawing.Point(156, 36)
        Me.une_dias_compra.MaskInput = "nn"
        Me.une_dias_compra.Name = "une_dias_compra"
        Me.une_dias_compra.Size = New System.Drawing.Size(41, 21)
        Me.une_dias_compra.TabIndex = 10
        '
        'UltraLabel19
        '
        Appearance22.BackColor = System.Drawing.Color.Transparent
        Appearance22.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel19.Appearance = Appearance22
        Me.UltraLabel19.AutoSize = True
        Me.UltraLabel19.Location = New System.Drawing.Point(32, 36)
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
        Me.UltraLabel18.Location = New System.Drawing.Point(32, 173)
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
        Me.UltraLabel17.AutoSize = True
        Me.UltraLabel17.Location = New System.Drawing.Point(31, 120)
        Me.UltraLabel17.Name = "UltraLabel17"
        Me.UltraLabel17.Size = New System.Drawing.Size(112, 14)
        Me.UltraLabel17.TabIndex = 9
        Me.UltraLabel17.Text = "Fecha de Liquidacion"
        '
        'UltraLabel16
        '
        Appearance40.BackColor = System.Drawing.Color.Transparent
        Appearance40.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel16.Appearance = Appearance40
        Me.UltraLabel16.AutoSize = True
        Me.UltraLabel16.Location = New System.Drawing.Point(32, 69)
        Me.UltraLabel16.Name = "UltraLabel16"
        Me.UltraLabel16.Size = New System.Drawing.Size(43, 14)
        Me.UltraLabel16.TabIndex = 9
        Me.UltraLabel16.Text = "Importe"
        '
        'UltraGroupBox1
        '
        Me.UltraGroupBox1.Controls.Add(Me.txt_nom_per)
        Me.UltraGroupBox1.Controls.Add(Me.txt_cod_per)
        Me.UltraGroupBox1.Controls.Add(Me.txt_id_per)
        Me.UltraGroupBox1.Controls.Add(Me.UltraLabel15)
        Me.UltraGroupBox1.Location = New System.Drawing.Point(14, 15)
        Me.UltraGroupBox1.Name = "UltraGroupBox1"
        Me.UltraGroupBox1.Size = New System.Drawing.Size(438, 64)
        Me.UltraGroupBox1.TabIndex = 13
        Me.UltraGroupBox1.Text = "Trabajador"
        '
        'txt_nom_per
        '
        Me.txt_nom_per.Location = New System.Drawing.Point(237, 27)
        Me.txt_nom_per.Name = "txt_nom_per"
        Me.txt_nom_per.ReadOnly = True
        Me.txt_nom_per.Size = New System.Drawing.Size(172, 21)
        Me.txt_nom_per.TabIndex = 9
        '
        'txt_cod_per
        '
        Appearance14.ImageHAlign = Infragistics.Win.HAlign.Center
        EditorButton2.Appearance = Appearance14
        Me.txt_cod_per.ButtonsRight.Add(EditorButton2)
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
        Me.txt_id_per.Size = New System.Drawing.Size(69, 21)
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
        'UltraTabPageControl3
        '
        Me.UltraTabPageControl3.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl3.Name = "UltraTabPageControl3"
        Me.UltraTabPageControl3.Size = New System.Drawing.Size(761, 287)
        '
        'Tool_Grabar
        '
        Me.Tool_Grabar.Image = Global.Contabilidad.My.Resources.Resources._003
        Me.Tool_Grabar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Tool_Grabar.Name = "Tool_Grabar"
        Me.Tool_Grabar.Size = New System.Drawing.Size(62, 22)
        Me.Tool_Grabar.Text = "Grabar"
        Me.Tool_Grabar.ToolTipText = "Grabar (F4)"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'UltraTabSharedControlsPage1
        '
        Me.UltraTabSharedControlsPage1.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabSharedControlsPage1.Name = "UltraTabSharedControlsPage1"
        Me.UltraTabSharedControlsPage1.Size = New System.Drawing.Size(724, 377)
        '
        'ToolS_Mantenimiento
        '
        Me.ToolS_Mantenimiento.BackColor = System.Drawing.Color.White
        Me.ToolS_Mantenimiento.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Tool_Nuevo, Me.ToolStripSeparator1, Me.Tool_Grabar, Me.ToolStripSeparator3, Me.Tool_Editar, Me.ToolStripSeparator4, Me.Tool_Cancelar, Me.ToolStripSeparator2, Me.Tool_Eliminar, Me.ToolStripSeparator5, Me.Tool_Salir})
        Me.ToolS_Mantenimiento.Location = New System.Drawing.Point(0, 0)
        Me.ToolS_Mantenimiento.Name = "ToolS_Mantenimiento"
        Me.ToolS_Mantenimiento.Size = New System.Drawing.Size(750, 25)
        Me.ToolS_Mantenimiento.TabIndex = 8
        Me.ToolS_Mantenimiento.Text = "ToolStrip1"
        '
        'Tool_Nuevo
        '
        Me.Tool_Nuevo.Image = Global.Contabilidad.My.Resources.Resources._16__File_new_2_
        Me.Tool_Nuevo.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Tool_Nuevo.Name = "Tool_Nuevo"
        Me.Tool_Nuevo.Size = New System.Drawing.Size(62, 22)
        Me.Tool_Nuevo.Text = "Nuevo"
        '
        'Tool_Editar
        '
        Me.Tool_Editar.Image = Global.Contabilidad.My.Resources.Resources._16__Card_edit_
        Me.Tool_Editar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Tool_Editar.Name = "Tool_Editar"
        Me.Tool_Editar.Size = New System.Drawing.Size(57, 22)
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
        Me.Tool_Cancelar.Size = New System.Drawing.Size(73, 22)
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
        Me.Tool_Eliminar.Size = New System.Drawing.Size(70, 22)
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
        Me.Tool_Salir.Size = New System.Drawing.Size(49, 22)
        Me.Tool_Salir.Text = "Salir"
        '
        'utc_Contenedor
        '
        Me.utc_Contenedor.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.utc_Contenedor.Controls.Add(Me.UltraTabSharedControlsPage1)
        Me.utc_Contenedor.Controls.Add(Me.UltraTabPageControl1)
        Me.utc_Contenedor.Controls.Add(Me.UltraTabPageControl2)
        Me.utc_Contenedor.Location = New System.Drawing.Point(12, 28)
        Me.utc_Contenedor.Name = "utc_Contenedor"
        Me.utc_Contenedor.SharedControlsPage = Me.UltraTabSharedControlsPage1
        Me.utc_Contenedor.Size = New System.Drawing.Size(728, 403)
        Me.utc_Contenedor.TabIndex = 7
        UltraTab1.TabPage = Me.UltraTabPageControl1
        UltraTab1.Text = "Listado de Personal"
        UltraTab2.TabPage = Me.UltraTabPageControl2
        UltraTab2.Text = "Registro de Suspension"
        Me.utc_Contenedor.Tabs.AddRange(New Infragistics.Win.UltraWinTabControl.UltraTab() {UltraTab1, UltraTab2})
        '
        'uchk_congoce
        '
        Me.uchk_congoce.BackColor = System.Drawing.Color.Transparent
        Me.uchk_congoce.BackColorInternal = System.Drawing.Color.Transparent
        Me.uchk_congoce.Location = New System.Drawing.Point(242, 123)
        Me.uchk_congoce.Name = "uchk_congoce"
        Me.uchk_congoce.Size = New System.Drawing.Size(170, 20)
        Me.uchk_congoce.TabIndex = 7
        Me.uchk_congoce.Text = "Con Goce de Haberes"
        '
        'PL_PR_Suspensiones
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(750, 443)
        Me.Controls.Add(Me.ToolS_Mantenimiento)
        Me.Controls.Add(Me.utc_Contenedor)
        Me.Name = "PL_PR_Suspensiones"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Registro de Suspensiones"
        Me.UltraTabPageControl1.ResumeLayout(False)
        CType(Me.ug_detalle, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.uds_detalle, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ug_nombres, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.uds_nombres, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.uos_tipos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabPageControl2.ResumeLayout(False)
        Me.gb3.ResumeLayout(False)
        Me.gb3.PerformLayout()
        CType(Me.txt_citt, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_obs, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.uce_tipo_suspe_sunat, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gb2.ResumeLayout(False)
        Me.gb2.PerformLayout()
        CType(Me.txt_IdPersonal, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pa_otros.ResumeLayout(False)
        Me.pa_otros.PerformLayout()
        CType(Me.udte_per_ini, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.udte_per_fin, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Pa_Vaca.ResumeLayout(False)
        Me.Pa_Vaca.PerformLayout()
        CType(Me.uce_Periodos_vaca, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_id_registro, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.une_Dias_Traba, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.une_dias_vaca, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.udte_fecha_fin, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.udte_fecha_inicio, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.uce_Tipo_Suspension, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gb1.ResumeLayout(False)
        Me.gb1.PerformLayout()
        CType(Me.txt_nombres, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_id_personal, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_cod_personal, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabPageControl4.ResumeLayout(False)
        CType(Me.UltraGroupBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraGroupBox2.ResumeLayout(False)
        Me.UltraGroupBox2.PerformLayout()
        CType(Me.uce_periodo_compra, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.udte_fec_liqui, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_obs_compra, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.une_dias_compra, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UltraGroupBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraGroupBox1.ResumeLayout(False)
        Me.UltraGroupBox1.PerformLayout()
        CType(Me.txt_nom_per, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_cod_per, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_id_per, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolS_Mantenimiento.ResumeLayout(False)
        Me.ToolS_Mantenimiento.PerformLayout()
        CType(Me.utc_Contenedor, System.ComponentModel.ISupportInitialize).EndInit()
        Me.utc_Contenedor.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txt_nombres As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents UltraTabPageControl1 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents uos_tipos As Infragistics.Win.UltraWinEditors.UltraOptionSet
    Friend WithEvents uds_detalle As Infragistics.Win.UltraWinDataSource.UltraDataSource
    Friend WithEvents txt_id_registro As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents Tool_Grabar As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents txt_cod_personal As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents txt_id_personal As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents UltraTabSharedControlsPage1 As Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage
    Friend WithEvents uchk_Procesar As Infragistics.Win.UltraWinEditors.UltraCheckEditor
    Friend WithEvents ToolS_Mantenimiento As System.Windows.Forms.ToolStrip
    Friend WithEvents Tool_Nuevo As System.Windows.Forms.ToolStripButton
    Friend WithEvents Tool_Editar As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents Tool_Cancelar As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents Tool_Eliminar As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator5 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents Tool_Salir As System.Windows.Forms.ToolStripButton
    Friend WithEvents une_Dias_Traba As Infragistics.Win.UltraWinEditors.UltraNumericEditor
    Friend WithEvents une_dias_vaca As Infragistics.Win.UltraWinEditors.UltraNumericEditor
    Friend WithEvents udte_fecha_fin As Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
    Friend WithEvents udte_fecha_inicio As Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
    Friend WithEvents UltraLabel7 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents utc_Contenedor As Infragistics.Win.UltraWinTabControl.UltraTabControl
    Friend WithEvents UltraTabPageControl2 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents UltraLabel6 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel8 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel2 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel5 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel4 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel1 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel9 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel10 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel3 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents uce_tipo_suspe_sunat As Infragistics.Win.UltraWinEditors.UltraComboEditor
    Friend WithEvents uce_Tipo_Suspension As Infragistics.Win.UltraWinEditors.UltraComboEditor
    Friend WithEvents UltraTabPageControl3 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents UltraLabel11 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents uce_Periodos_vaca As Infragistics.Win.UltraWinEditors.UltraComboEditor
    Friend WithEvents gb3 As System.Windows.Forms.GroupBox
    Friend WithEvents UltraLabel12 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents gb2 As System.Windows.Forms.GroupBox
    Friend WithEvents gb1 As System.Windows.Forms.GroupBox
    Friend WithEvents txt_obs As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents lbl_obs As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents uds_nombres As Infragistics.Win.UltraWinDataSource.UltraDataSource
    Friend WithEvents ug_nombres As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents ug_detalle As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents ubtn_atraz As Infragistics.Win.Misc.UltraButton
    Friend WithEvents pa_otros As System.Windows.Forms.Panel
    Friend WithEvents udte_per_ini As Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
    Friend WithEvents udte_per_fin As Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
    Friend WithEvents Pa_Vaca As System.Windows.Forms.Panel
    Friend WithEvents UltraLabel13 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents txt_citt As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents UltraLabel14 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents ubtn_refrescar As Infragistics.Win.Misc.UltraButton
    Friend WithEvents UltraTabPageControl4 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents txt_nom_per As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents txt_id_per As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents txt_cod_per As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents UltraLabel15 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents txt_IdPersonal As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents UltraGroupBox1 As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents UltraGroupBox2 As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents ume_importe_compra As Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit
    Friend WithEvents txt_obs_compra As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents une_dias_compra As Infragistics.Win.UltraWinEditors.UltraNumericEditor
    Friend WithEvents UltraLabel19 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel18 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel17 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel16 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents uchk_consi_liqui As Infragistics.Win.UltraWinEditors.UltraCheckEditor
    Friend WithEvents UltraLabel21 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents uce_periodo_compra As Infragistics.Win.UltraWinEditors.UltraComboEditor
    Friend WithEvents UltraLabel20 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents udte_fec_liqui As Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
    Friend WithEvents uchk_congoce As Infragistics.Win.UltraWinEditors.UltraCheckEditor
End Class
