<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class HO_PR_ManteRegHospi
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
        Dim UltraGridColumn1 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IDCAMA")
        Dim UltraGridColumn2 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CAMA")
        Dim UltraGridColumn3 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("HABITACION")
        Dim Appearance2 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn4 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("PISO")
        Dim UltraGridColumn5 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("PACIENTE")
        Dim Appearance10 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn6 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FEC_INGRESO")
        Dim Appearance11 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn7 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("DIAGNOSTICO")
        Dim UltraGridColumn8 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NUM_CAMA")
        Dim UltraGridColumn9 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("PH_IDSOLICI")
        Dim UltraGridColumn10 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("PH_IDHISTORIA")
        Dim Appearance12 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn11 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("MEDICO")
        Dim UltraGridColumn12 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("PH_FAMILIAR")
        Dim UltraGridColumn13 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("PH_TELEF")
        Dim UltraGridColumn14 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("PH_DIR")
        Dim UltraGridColumn15 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IMG")
        Dim Appearance15 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraDataColumn1 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IDCAMA")
        Dim UltraDataColumn2 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("CAMA")
        Dim UltraDataColumn3 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("HABITACION")
        Dim UltraDataColumn4 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("PISO")
        Dim UltraDataColumn5 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("PACIENTE")
        Dim UltraDataColumn6 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("FEC_INGRESO")
        Dim UltraDataColumn7 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("DIAGNOSTICO")
        Dim UltraDataColumn8 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("NUM_CAMA")
        Dim UltraDataColumn9 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("PH_IDSOLICI")
        Dim UltraDataColumn10 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("PH_IDHISTORIA")
        Dim UltraDataColumn11 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("MEDICO")
        Dim UltraDataColumn12 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("PH_FAMILIAR")
        Dim UltraDataColumn13 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("PH_TELEF")
        Dim UltraDataColumn14 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("PH_DIR")
        Dim UltraDataColumn15 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IMG")
        Dim Appearance6 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance5 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance14 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance4 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance8 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance3 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance7 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance9 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraTab1 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraTab2 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraTab3 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraTab4 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim Appearance1 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Me.UltraTabPageControl1 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.ug_ListaCamas = New Infragistics.Win.UltraWinGrid.UltraGrid()
        Me.uds_hospi = New Infragistics.Win.UltraWinDataSource.UltraDataSource(Me.components)
        Me.UltraTabPageControl2 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.ugb_Datos1 = New Infragistics.Win.Misc.UltraGroupBox()
        Me.txt_paciente = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.txt_num_historia = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.txt_num_soli = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.UltraLabel2 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraLabel1 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraLabel3 = New Infragistics.Win.Misc.UltraLabel()
        Me.ubtn_darAlta = New Infragistics.Win.Misc.UltraButton()
        Me.ume_fec_alta = New Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit()
        Me.UltraLabel5 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraTabPageControl3 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.ugb_datos2 = New Infragistics.Win.Misc.UltraGroupBox()
        Me.UltraTabPageControl4 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.ugb_camb_habi = New Infragistics.Win.Misc.UltraGroupBox()
        Me.txt_cama_Act = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.ubtn_camb_habi = New Infragistics.Win.Misc.UltraButton()
        Me.UltraLabel6 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraLabel4 = New Infragistics.Win.Misc.UltraLabel()
        Me.uce_Habi = New Infragistics.Win.UltraWinEditors.UltraComboEditor()
        Me.ToolS_Mantenimiento = New System.Windows.Forms.ToolStrip()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.Tool_Cancelar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator()
        Me.Tool_daralta = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.Tool_Consumos = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator6 = New System.Windows.Forms.ToolStripSeparator()
        Me.Tool_Actualizar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.Tool_Imprimir = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.Tool_camb_cama = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator7 = New System.Windows.Forms.ToolStripSeparator()
        Me.Tool_Salir = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator8 = New System.Windows.Forms.ToolStripSeparator()
        Me.utc_hospi = New Infragistics.Win.UltraWinTabControl.UltraTabControl()
        Me.UltraTabSharedControlsPage1 = New Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage()
        Me.UltraLabel15 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraTabPageControl1.SuspendLayout()
        CType(Me.ug_ListaCamas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.uds_hospi, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabPageControl2.SuspendLayout()
        CType(Me.ugb_Datos1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ugb_Datos1.SuspendLayout()
        CType(Me.txt_paciente, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_num_historia, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_num_soli, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabPageControl3.SuspendLayout()
        CType(Me.ugb_datos2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabPageControl4.SuspendLayout()
        CType(Me.ugb_camb_habi, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ugb_camb_habi.SuspendLayout()
        CType(Me.txt_cama_Act, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.uce_Habi, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolS_Mantenimiento.SuspendLayout()
        CType(Me.utc_hospi, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.utc_hospi.SuspendLayout()
        Me.SuspendLayout()
        '
        'UltraTabPageControl1
        '
        Me.UltraTabPageControl1.Controls.Add(Me.ug_ListaCamas)
        Me.UltraTabPageControl1.Location = New System.Drawing.Point(1, 23)
        Me.UltraTabPageControl1.Name = "UltraTabPageControl1"
        Me.UltraTabPageControl1.Size = New System.Drawing.Size(831, 424)
        '
        'ug_ListaCamas
        '
        Me.ug_ListaCamas.DataSource = Me.uds_hospi
        Me.ug_ListaCamas.DisplayLayout.AutoFitStyle = Infragistics.Win.UltraWinGrid.AutoFitStyle.ExtendLastColumn
        UltraGridColumn1.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn1.Header.VisiblePosition = 0
        UltraGridColumn1.Hidden = True
        UltraGridColumn2.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn2.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn2.Header.VisiblePosition = 1
        UltraGridColumn2.Hidden = True
        UltraGridColumn2.Width = 79
        UltraGridColumn3.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn3.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        Appearance2.FontData.BoldAsString = "True"
        Appearance2.FontData.SizeInPoints = 12.0!
        Appearance2.TextHAlignAsString = "Center"
        UltraGridColumn3.CellAppearance = Appearance2
        UltraGridColumn3.Header.VisiblePosition = 3
        UltraGridColumn3.RowLayoutColumnInfo.OriginX = 3
        UltraGridColumn3.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn3.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(87, 0)
        UltraGridColumn3.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn3.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn3.Width = 64
        UltraGridColumn4.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn4.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn4.Header.VisiblePosition = 4
        UltraGridColumn4.Hidden = True
        UltraGridColumn4.Width = 33
        UltraGridColumn5.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn5.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        Appearance10.FontData.BoldAsString = "True"
        Appearance10.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        UltraGridColumn5.CellAppearance = Appearance10
        UltraGridColumn5.Header.VisiblePosition = 6
        UltraGridColumn5.RowLayoutColumnInfo.OriginX = 5
        UltraGridColumn5.RowLayoutColumnInfo.OriginY = 2
        UltraGridColumn5.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(0, 78)
        UltraGridColumn5.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn5.RowLayoutColumnInfo.SpanY = 4
        UltraGridColumn5.Width = 177
        UltraGridColumn6.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn6.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        Appearance11.TextHAlignAsString = "Center"
        UltraGridColumn6.CellAppearance = Appearance11
        UltraGridColumn6.Header.Caption = "F.INGRESO"
        UltraGridColumn6.Header.VisiblePosition = 7
        UltraGridColumn6.RowLayoutColumnInfo.OriginX = 3
        UltraGridColumn6.RowLayoutColumnInfo.OriginY = 2
        UltraGridColumn6.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(87, 78)
        UltraGridColumn6.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn6.RowLayoutColumnInfo.SpanY = 4
        UltraGridColumn6.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Date]
        UltraGridColumn6.Width = 70
        UltraGridColumn7.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn7.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn7.Header.VisiblePosition = 8
        UltraGridColumn7.RowLayoutColumnInfo.OriginX = 7
        UltraGridColumn7.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn7.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(0, 66)
        UltraGridColumn7.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn7.RowLayoutColumnInfo.SpanY = 5
        UltraGridColumn7.Width = 192
        UltraGridColumn8.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn8.Header.VisiblePosition = 9
        UltraGridColumn8.Hidden = True
        UltraGridColumn9.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn9.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn9.Header.VisiblePosition = 10
        UltraGridColumn9.Hidden = True
        UltraGridColumn10.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn10.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        Appearance12.FontData.BoldAsString = "True"
        Appearance12.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        UltraGridColumn10.CellAppearance = Appearance12
        UltraGridColumn10.Header.Caption = "NºHISTORIA"
        UltraGridColumn10.Header.VisiblePosition = 5
        UltraGridColumn10.RowLayoutColumnInfo.OriginX = 5
        UltraGridColumn10.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn10.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn10.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn10.Width = 71
        UltraGridColumn11.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn11.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn11.Header.VisiblePosition = 11
        UltraGridColumn11.RowLayoutColumnInfo.OriginX = 7
        UltraGridColumn11.RowLayoutColumnInfo.OriginY = 5
        UltraGridColumn11.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(0, 29)
        UltraGridColumn11.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn11.RowLayoutColumnInfo.SpanY = 1
        UltraGridColumn12.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn12.Header.VisiblePosition = 12
        UltraGridColumn12.Hidden = True
        UltraGridColumn13.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn13.Header.VisiblePosition = 13
        UltraGridColumn13.Hidden = True
        UltraGridColumn14.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn14.Header.VisiblePosition = 14
        UltraGridColumn14.Hidden = True
        UltraGridColumn15.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn15.Header.VisiblePosition = 2
        UltraGridColumn15.RowLayoutColumnInfo.OriginX = 0
        UltraGridColumn15.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn15.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(108, 98)
        UltraGridColumn15.RowLayoutColumnInfo.SpanX = 3
        UltraGridColumn15.RowLayoutColumnInfo.SpanY = 6
        UltraGridColumn15.Width = 76
        UltraGridBand1.Columns.AddRange(New Object() {UltraGridColumn1, UltraGridColumn2, UltraGridColumn3, UltraGridColumn4, UltraGridColumn5, UltraGridColumn6, UltraGridColumn7, UltraGridColumn8, UltraGridColumn9, UltraGridColumn10, UltraGridColumn11, UltraGridColumn12, UltraGridColumn13, UltraGridColumn14, UltraGridColumn15})
        UltraGridBand1.UseRowLayout = True
        Me.ug_ListaCamas.DisplayLayout.BandsSerializer.Add(UltraGridBand1)
        Me.ug_ListaCamas.DisplayLayout.MaxColScrollRegions = 1
        Me.ug_ListaCamas.DisplayLayout.MaxRowScrollRegions = 1
        Appearance15.BackColor = System.Drawing.Color.WhiteSmoke
        Appearance15.BackColor2 = System.Drawing.Color.WhiteSmoke
        Me.ug_ListaCamas.DisplayLayout.Override.RowAlternateAppearance = Appearance15
        Me.ug_ListaCamas.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.ug_ListaCamas.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.ug_ListaCamas.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ug_ListaCamas.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ug_ListaCamas.Location = New System.Drawing.Point(0, 0)
        Me.ug_ListaCamas.Name = "ug_ListaCamas"
        Me.ug_ListaCamas.Size = New System.Drawing.Size(831, 424)
        Me.ug_ListaCamas.TabIndex = 0
        '
        'uds_hospi
        '
        Me.uds_hospi.AllowDelete = False
        UltraDataColumn1.DataType = GetType(Integer)
        UltraDataColumn6.DataType = GetType(Date)
        UltraDataColumn8.DataType = GetType(Double)
        UltraDataColumn9.DataType = GetType(Long)
        UltraDataColumn10.DataType = GetType(Long)
        UltraDataColumn15.DataType = GetType(System.Drawing.Bitmap)
        Me.uds_hospi.Band.Columns.AddRange(New Object() {UltraDataColumn1, UltraDataColumn2, UltraDataColumn3, UltraDataColumn4, UltraDataColumn5, UltraDataColumn6, UltraDataColumn7, UltraDataColumn8, UltraDataColumn9, UltraDataColumn10, UltraDataColumn11, UltraDataColumn12, UltraDataColumn13, UltraDataColumn14, UltraDataColumn15})
        '
        'UltraTabPageControl2
        '
        Me.UltraTabPageControl2.Controls.Add(Me.ugb_Datos1)
        Me.UltraTabPageControl2.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl2.Name = "UltraTabPageControl2"
        Me.UltraTabPageControl2.Size = New System.Drawing.Size(831, 424)
        '
        'ugb_Datos1
        '
        Me.ugb_Datos1.Controls.Add(Me.txt_paciente)
        Me.ugb_Datos1.Controls.Add(Me.txt_num_historia)
        Me.ugb_Datos1.Controls.Add(Me.txt_num_soli)
        Me.ugb_Datos1.Controls.Add(Me.UltraLabel2)
        Me.ugb_Datos1.Controls.Add(Me.UltraLabel1)
        Me.ugb_Datos1.Controls.Add(Me.UltraLabel3)
        Me.ugb_Datos1.Controls.Add(Me.ubtn_darAlta)
        Me.ugb_Datos1.Controls.Add(Me.ume_fec_alta)
        Me.ugb_Datos1.Controls.Add(Me.UltraLabel5)
        Me.ugb_Datos1.Location = New System.Drawing.Point(12, 7)
        Me.ugb_Datos1.Name = "ugb_Datos1"
        Me.ugb_Datos1.Size = New System.Drawing.Size(806, 406)
        Me.ugb_Datos1.TabIndex = 0
        '
        'txt_paciente
        '
        Me.txt_paciente.Location = New System.Drawing.Point(93, 70)
        Me.txt_paciente.MaxLength = 100
        Me.txt_paciente.Name = "txt_paciente"
        Me.txt_paciente.ReadOnly = True
        Me.txt_paciente.Size = New System.Drawing.Size(564, 21)
        Me.txt_paciente.TabIndex = 54
        '
        'txt_num_historia
        '
        Me.txt_num_historia.Location = New System.Drawing.Point(93, 43)
        Me.txt_num_historia.MaxLength = 100
        Me.txt_num_historia.Name = "txt_num_historia"
        Me.txt_num_historia.ReadOnly = True
        Me.txt_num_historia.Size = New System.Drawing.Size(110, 21)
        Me.txt_num_historia.TabIndex = 55
        '
        'txt_num_soli
        '
        Appearance6.FontData.BoldAsString = "True"
        Me.txt_num_soli.Appearance = Appearance6
        Me.txt_num_soli.Location = New System.Drawing.Point(93, 16)
        Me.txt_num_soli.MaxLength = 11
        Me.txt_num_soli.Name = "txt_num_soli"
        Me.txt_num_soli.ReadOnly = True
        Me.txt_num_soli.Size = New System.Drawing.Size(127, 21)
        Me.txt_num_soli.TabIndex = 50
        '
        'UltraLabel2
        '
        Appearance5.BackColor = System.Drawing.Color.Transparent
        Appearance5.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel2.Appearance = Appearance5
        Me.UltraLabel2.AutoSize = True
        Me.UltraLabel2.Location = New System.Drawing.Point(39, 74)
        Me.UltraLabel2.Name = "UltraLabel2"
        Me.UltraLabel2.Size = New System.Drawing.Size(48, 14)
        Me.UltraLabel2.TabIndex = 51
        Me.UltraLabel2.Text = "Paciente"
        '
        'UltraLabel1
        '
        Appearance14.BackColor = System.Drawing.Color.Transparent
        Appearance14.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel1.Appearance = Appearance14
        Me.UltraLabel1.AutoSize = True
        Me.UltraLabel1.Location = New System.Drawing.Point(29, 47)
        Me.UltraLabel1.Name = "UltraLabel1"
        Me.UltraLabel1.Size = New System.Drawing.Size(58, 14)
        Me.UltraLabel1.TabIndex = 52
        Me.UltraLabel1.Text = "Nº Historia"
        '
        'UltraLabel3
        '
        Appearance4.BackColor = System.Drawing.Color.Transparent
        Appearance4.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel3.Appearance = Appearance4
        Me.UltraLabel3.AutoSize = True
        Me.UltraLabel3.Location = New System.Drawing.Point(24, 20)
        Me.UltraLabel3.Name = "UltraLabel3"
        Me.UltraLabel3.Size = New System.Drawing.Size(63, 14)
        Me.UltraLabel3.TabIndex = 53
        Me.UltraLabel3.Text = "Nº Solicitud"
        '
        'ubtn_darAlta
        '
        Me.ubtn_darAlta.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ubtn_darAlta.Location = New System.Drawing.Point(193, 113)
        Me.ubtn_darAlta.Name = "ubtn_darAlta"
        Me.ubtn_darAlta.Size = New System.Drawing.Size(133, 39)
        Me.ubtn_darAlta.TabIndex = 49
        Me.ubtn_darAlta.Text = "Dar Alta"
        '
        'ume_fec_alta
        '
        Me.ume_fec_alta.EditAs = Infragistics.Win.UltraWinMaskedEdit.EditAsType.UseSpecifiedMask
        Me.ume_fec_alta.InputMask = "{date}"
        Me.ume_fec_alta.Location = New System.Drawing.Point(93, 122)
        Me.ume_fec_alta.Name = "ume_fec_alta"
        Me.ume_fec_alta.Size = New System.Drawing.Size(80, 20)
        Me.ume_fec_alta.TabIndex = 48
        Me.ume_fec_alta.Text = "UltraMaskedEdit1"
        '
        'UltraLabel5
        '
        Appearance8.BackColor = System.Drawing.Color.Transparent
        Appearance8.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel5.Appearance = Appearance8
        Me.UltraLabel5.AutoSize = True
        Me.UltraLabel5.Location = New System.Drawing.Point(29, 125)
        Me.UltraLabel5.Name = "UltraLabel5"
        Me.UltraLabel5.Size = New System.Drawing.Size(58, 14)
        Me.UltraLabel5.TabIndex = 47
        Me.UltraLabel5.Text = "Fecha Alta"
        '
        'UltraTabPageControl3
        '
        Me.UltraTabPageControl3.Controls.Add(Me.ugb_datos2)
        Me.UltraTabPageControl3.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl3.Name = "UltraTabPageControl3"
        Me.UltraTabPageControl3.Size = New System.Drawing.Size(831, 424)
        '
        'ugb_datos2
        '
        Me.ugb_datos2.Location = New System.Drawing.Point(12, 7)
        Me.ugb_datos2.Name = "ugb_datos2"
        Me.ugb_datos2.Size = New System.Drawing.Size(806, 399)
        Me.ugb_datos2.TabIndex = 0
        '
        'UltraTabPageControl4
        '
        Me.UltraTabPageControl4.Controls.Add(Me.ugb_camb_habi)
        Me.UltraTabPageControl4.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl4.Name = "UltraTabPageControl4"
        Me.UltraTabPageControl4.Size = New System.Drawing.Size(831, 424)
        '
        'ugb_camb_habi
        '
        Me.ugb_camb_habi.Controls.Add(Me.txt_cama_Act)
        Me.ugb_camb_habi.Controls.Add(Me.ubtn_camb_habi)
        Me.ugb_camb_habi.Controls.Add(Me.UltraLabel6)
        Me.ugb_camb_habi.Controls.Add(Me.UltraLabel4)
        Me.ugb_camb_habi.Controls.Add(Me.uce_Habi)
        Me.ugb_camb_habi.Location = New System.Drawing.Point(9, 5)
        Me.ugb_camb_habi.Name = "ugb_camb_habi"
        Me.ugb_camb_habi.Size = New System.Drawing.Size(814, 416)
        Me.ugb_camb_habi.TabIndex = 0
        '
        'txt_cama_Act
        '
        Appearance3.FontData.BoldAsString = "True"
        Me.txt_cama_Act.Appearance = Appearance3
        Me.txt_cama_Act.Location = New System.Drawing.Point(178, 26)
        Me.txt_cama_Act.MaxLength = 11
        Me.txt_cama_Act.Name = "txt_cama_Act"
        Me.txt_cama_Act.ReadOnly = True
        Me.txt_cama_Act.Size = New System.Drawing.Size(127, 21)
        Me.txt_cama_Act.TabIndex = 56
        '
        'ubtn_camb_habi
        '
        Me.ubtn_camb_habi.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ubtn_camb_habi.Location = New System.Drawing.Point(178, 117)
        Me.ubtn_camb_habi.Name = "ubtn_camb_habi"
        Me.ubtn_camb_habi.Size = New System.Drawing.Size(133, 39)
        Me.ubtn_camb_habi.TabIndex = 55
        Me.ubtn_camb_habi.Text = "Cambiar Cama"
        '
        'UltraLabel6
        '
        Appearance7.BackColor = System.Drawing.Color.Transparent
        Appearance7.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel6.Appearance = Appearance7
        Me.UltraLabel6.AutoSize = True
        Me.UltraLabel6.Location = New System.Drawing.Point(88, 30)
        Me.UltraLabel6.Name = "UltraLabel6"
        Me.UltraLabel6.Size = New System.Drawing.Size(84, 14)
        Me.UltraLabel6.TabIndex = 54
        Me.UltraLabel6.Text = "Nº Cama Actual"
        '
        'UltraLabel4
        '
        Appearance9.BackColor = System.Drawing.Color.Transparent
        Appearance9.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel4.Appearance = Appearance9
        Me.UltraLabel4.AutoSize = True
        Me.UltraLabel4.Location = New System.Drawing.Point(70, 68)
        Me.UltraLabel4.Name = "UltraLabel4"
        Me.UltraLabel4.Size = New System.Drawing.Size(102, 14)
        Me.UltraLabel4.TabIndex = 54
        Me.UltraLabel4.Text = "Nº Cama a cambiar"
        '
        'uce_Habi
        '
        Me.uce_Habi.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.uce_Habi.Location = New System.Drawing.Point(178, 64)
        Me.uce_Habi.Name = "uce_Habi"
        Me.uce_Habi.Size = New System.Drawing.Size(220, 21)
        Me.uce_Habi.TabIndex = 0
        '
        'ToolS_Mantenimiento
        '
        Me.ToolS_Mantenimiento.BackColor = System.Drawing.Color.White
        Me.ToolS_Mantenimiento.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripSeparator1, Me.Tool_Cancelar, Me.ToolStripSeparator5, Me.Tool_daralta, Me.ToolStripSeparator2, Me.Tool_Consumos, Me.ToolStripSeparator6, Me.Tool_Actualizar, Me.ToolStripSeparator3, Me.Tool_Imprimir, Me.ToolStripSeparator4, Me.Tool_camb_cama, Me.ToolStripSeparator7, Me.Tool_Salir, Me.ToolStripSeparator8})
        Me.ToolS_Mantenimiento.Location = New System.Drawing.Point(0, 0)
        Me.ToolS_Mantenimiento.Name = "ToolS_Mantenimiento"
        Me.ToolS_Mantenimiento.Size = New System.Drawing.Size(857, 25)
        Me.ToolS_Mantenimiento.TabIndex = 15
        Me.ToolS_Mantenimiento.Text = "ToolStrip1"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'Tool_Cancelar
        '
        Me.Tool_Cancelar.Image = Global.Contabilidad.My.Resources.Resources._16__Cancel_
        Me.Tool_Cancelar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Tool_Cancelar.Name = "Tool_Cancelar"
        Me.Tool_Cancelar.Size = New System.Drawing.Size(73, 22)
        Me.Tool_Cancelar.Text = "Cancelar"
        '
        'ToolStripSeparator5
        '
        Me.ToolStripSeparator5.Name = "ToolStripSeparator5"
        Me.ToolStripSeparator5.Size = New System.Drawing.Size(6, 25)
        '
        'Tool_daralta
        '
        Me.Tool_daralta.Image = Global.Contabilidad.My.Resources.Resources._16__Full_screen_
        Me.Tool_daralta.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Tool_daralta.Name = "Tool_daralta"
        Me.Tool_daralta.Size = New System.Drawing.Size(69, 22)
        Me.Tool_daralta.Text = "Dar Alta"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'Tool_Consumos
        '
        Me.Tool_Consumos.Image = Global.Contabilidad.My.Resources.Resources._16__Paste_
        Me.Tool_Consumos.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Tool_Consumos.Name = "Tool_Consumos"
        Me.Tool_Consumos.Size = New System.Drawing.Size(84, 22)
        Me.Tool_Consumos.Text = "Consumos"
        '
        'ToolStripSeparator6
        '
        Me.ToolStripSeparator6.Name = "ToolStripSeparator6"
        Me.ToolStripSeparator6.Size = New System.Drawing.Size(6, 25)
        '
        'Tool_Actualizar
        '
        Me.Tool_Actualizar.Image = Global.Contabilidad.My.Resources.Resources._726
        Me.Tool_Actualizar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Tool_Actualizar.Name = "Tool_Actualizar"
        Me.Tool_Actualizar.Size = New System.Drawing.Size(79, 22)
        Me.Tool_Actualizar.Text = "Actualizar"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 25)
        '
        'Tool_Imprimir
        '
        Me.Tool_Imprimir.Image = Global.Contabilidad.My.Resources.Resources._004
        Me.Tool_Imprimir.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Tool_Imprimir.Name = "Tool_Imprimir"
        Me.Tool_Imprimir.Size = New System.Drawing.Size(99, 22)
        Me.Tool_Imprimir.Text = "Hoja Filiacion"
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(6, 25)
        '
        'Tool_camb_cama
        '
        Me.Tool_camb_cama.Image = Global.Contabilidad.My.Resources.Resources._16__Bullets_and_numbering_
        Me.Tool_camb_cama.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Tool_camb_cama.Name = "Tool_camb_cama"
        Me.Tool_camb_cama.Size = New System.Drawing.Size(103, 22)
        Me.Tool_camb_cama.Text = "Cambio Cama"
        '
        'ToolStripSeparator7
        '
        Me.ToolStripSeparator7.Name = "ToolStripSeparator7"
        Me.ToolStripSeparator7.Size = New System.Drawing.Size(6, 25)
        '
        'Tool_Salir
        '
        Me.Tool_Salir.Image = Global.Contabilidad.My.Resources.Resources._28
        Me.Tool_Salir.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Tool_Salir.Name = "Tool_Salir"
        Me.Tool_Salir.Size = New System.Drawing.Size(49, 22)
        Me.Tool_Salir.Text = "Salir"
        '
        'ToolStripSeparator8
        '
        Me.ToolStripSeparator8.Name = "ToolStripSeparator8"
        Me.ToolStripSeparator8.Size = New System.Drawing.Size(6, 25)
        '
        'utc_hospi
        '
        Me.utc_hospi.Controls.Add(Me.UltraTabSharedControlsPage1)
        Me.utc_hospi.Controls.Add(Me.UltraTabPageControl1)
        Me.utc_hospi.Controls.Add(Me.UltraTabPageControl2)
        Me.utc_hospi.Controls.Add(Me.UltraTabPageControl3)
        Me.utc_hospi.Controls.Add(Me.UltraTabPageControl4)
        Me.utc_hospi.Location = New System.Drawing.Point(10, 62)
        Me.utc_hospi.Name = "utc_hospi"
        Me.utc_hospi.SharedControlsPage = Me.UltraTabSharedControlsPage1
        Me.utc_hospi.Size = New System.Drawing.Size(835, 450)
        Me.utc_hospi.TabIndex = 16
        UltraTab1.TabPage = Me.UltraTabPageControl1
        UltraTab1.Text = "Pacientes Hospitalizados"
        UltraTab2.TabPage = Me.UltraTabPageControl2
        UltraTab2.Text = "Alta de Paciente"
        UltraTab3.TabPage = Me.UltraTabPageControl3
        UltraTab3.Text = "Consumos"
        UltraTab4.TabPage = Me.UltraTabPageControl4
        UltraTab4.Text = "Cambio de Habitacion"
        Me.utc_hospi.Tabs.AddRange(New Infragistics.Win.UltraWinTabControl.UltraTab() {UltraTab1, UltraTab2, UltraTab3, UltraTab4})
        '
        'UltraTabSharedControlsPage1
        '
        Me.UltraTabSharedControlsPage1.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabSharedControlsPage1.Name = "UltraTabSharedControlsPage1"
        Me.UltraTabSharedControlsPage1.Size = New System.Drawing.Size(831, 424)
        '
        'UltraLabel15
        '
        Appearance1.BackColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(125, Byte), Integer), CType(CType(125, Byte), Integer))
        Appearance1.ForeColor = System.Drawing.Color.White
        Appearance1.TextHAlignAsString = "Center"
        Me.UltraLabel15.Appearance = Appearance1
        Me.UltraLabel15.BorderStyleOuter = Infragistics.Win.UIElementBorderStyle.Solid
        Me.UltraLabel15.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel15.Location = New System.Drawing.Point(-2, 28)
        Me.UltraLabel15.Name = "UltraLabel15"
        Me.UltraLabel15.Size = New System.Drawing.Size(864, 28)
        Me.UltraLabel15.TabIndex = 35
        Me.UltraLabel15.Text = "Mantenimiento de Pacientes Hospitalizados"
        '
        'HO_PR_ManteRegHospi
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(857, 524)
        Me.Controls.Add(Me.UltraLabel15)
        Me.Controls.Add(Me.utc_hospi)
        Me.Controls.Add(Me.ToolS_Mantenimiento)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "HO_PR_ManteRegHospi"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Mantenimiento de Reg. Hospitalizacion"
        Me.UltraTabPageControl1.ResumeLayout(False)
        CType(Me.ug_ListaCamas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.uds_hospi, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabPageControl2.ResumeLayout(False)
        CType(Me.ugb_Datos1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ugb_Datos1.ResumeLayout(False)
        Me.ugb_Datos1.PerformLayout()
        CType(Me.txt_paciente, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_num_historia, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_num_soli, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabPageControl3.ResumeLayout(False)
        CType(Me.ugb_datos2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabPageControl4.ResumeLayout(False)
        CType(Me.ugb_camb_habi, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ugb_camb_habi.ResumeLayout(False)
        Me.ugb_camb_habi.PerformLayout()
        CType(Me.txt_cama_Act, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.uce_Habi, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolS_Mantenimiento.ResumeLayout(False)
        Me.ToolS_Mantenimiento.PerformLayout()
        CType(Me.utc_hospi, System.ComponentModel.ISupportInitialize).EndInit()
        Me.utc_hospi.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolS_Mantenimiento As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents Tool_Cancelar As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents Tool_Salir As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator5 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents utc_hospi As Infragistics.Win.UltraWinTabControl.UltraTabControl
    Friend WithEvents UltraTabSharedControlsPage1 As Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage
    Friend WithEvents UltraTabPageControl1 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents ug_ListaCamas As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents UltraTabPageControl2 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents uds_hospi As Infragistics.Win.UltraWinDataSource.UltraDataSource
    Friend WithEvents ugb_Datos1 As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents Tool_daralta As System.Windows.Forms.ToolStripButton
    Friend WithEvents Tool_Consumos As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator6 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents UltraTabPageControl3 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents UltraLabel15 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents ubtn_darAlta As Infragistics.Win.Misc.UltraButton
    Friend WithEvents ume_fec_alta As Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit
    Friend WithEvents UltraLabel5 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents ugb_datos2 As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents txt_paciente As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents txt_num_historia As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents txt_num_soli As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents UltraLabel2 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel1 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel3 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents Tool_Actualizar As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents Tool_Imprimir As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator7 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents UltraTabPageControl4 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents ugb_camb_habi As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents ubtn_camb_habi As Infragistics.Win.Misc.UltraButton
    Friend WithEvents UltraLabel4 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents uce_Habi As Infragistics.Win.UltraWinEditors.UltraComboEditor
    Friend WithEvents txt_cama_Act As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents UltraLabel6 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents Tool_camb_cama As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator8 As System.Windows.Forms.ToolStripSeparator
End Class
