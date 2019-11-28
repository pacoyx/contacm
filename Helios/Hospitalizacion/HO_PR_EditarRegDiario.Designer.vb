<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class HO_PR_EditarRegDiario
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
        Dim UltraDataColumn1 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("MA_ITEM")
        Dim UltraDataColumn2 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("MA_FECHA")
        Dim UltraDataColumn3 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("MA_HORA_ENT")
        Dim UltraDataColumn4 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("MA_TM_ENT")
        Dim UltraDataColumn5 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("MA_HORA_SAL")
        Dim UltraDataColumn6 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("MA_TM_SAL")
        Dim UltraDataColumn7 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("MA_TIEMPO")
        Dim UltraDataColumn8 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("MA_IDTIPO_REG")
        Dim UltraDataColumn9 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("TR_DESCRIPCION")
        Dim UltraDataColumn10 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("MA_OBS")
        Dim UltraDataColumn11 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("MA_IDSERVICIO")
        Dim UltraDataColumn12 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("MA_VACA_INI")
        Dim UltraDataColumn13 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("MA_VACA_FIN")
        Dim UltraDataColumn14 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("MA_ES_REFRI")
        Dim UltraDataColumn15 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("MA_ES_FERIADO")
        Dim UltraDataColumn16 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("REFRIGERIO")
        Dim UltraDataColumn17 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("PE_ID")
        Dim UltraDataColumn18 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("PE_CODIGO")
        Dim UltraDataColumn19 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("NOMBRES")
        Dim Appearance12 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance15 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance8 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance18 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridBand1 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1)
        Dim UltraGridColumn1 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("PE_ID")
        Dim UltraGridColumn2 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("PE_CODIGO")
        Dim UltraGridColumn3 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NOMBRES")
        Dim Appearance16 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridBand2 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1)
        Dim UltraGridColumn4 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("MA_ITEM")
        Dim UltraGridColumn5 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("MA_FECHA")
        Dim UltraGridColumn6 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("MA_HORA_ENT")
        Dim Appearance2 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn7 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("MA_TM_ENT")
        Dim Appearance7 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn8 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("MA_HORA_SAL")
        Dim Appearance9 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn9 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("MA_TM_SAL")
        Dim Appearance10 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn10 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("MA_TIEMPO")
        Dim Appearance11 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn11 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("MA_IDTIPO_REG")
        Dim UltraGridColumn12 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TR_DESCRIPCION")
        Dim UltraGridColumn13 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("MA_OBS")
        Dim UltraGridColumn14 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("MA_IDSERVICIO")
        Dim UltraGridColumn15 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("MA_VACA_INI")
        Dim UltraGridColumn16 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("MA_VACA_FIN")
        Dim UltraGridColumn17 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("MA_ES_REFRI")
        Dim UltraGridColumn18 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("MA_ES_FERIADO")
        Dim UltraGridColumn19 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("REFRIGERIO")
        Dim Appearance4 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance14 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance5 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance3 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance1 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance17 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance19 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance20 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance13 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance6 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Me.uds_ListaMarcaciones = New Infragistics.Win.UltraWinDataSource.UltraDataSource(Me.components)
        Me.Tools_Mante = New System.Windows.Forms.ToolStrip()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.Tool_Nuevo = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator()
        Me.Tool_Modificar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.Tool_Eliminar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.Tool_salir = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.uds_ListaPer = New Infragistics.Win.UltraWinDataSource.UltraDataSource(Me.components)
        Me.txt_Area = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.ume_tot_hor_ext = New Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit()
        Me.ume_tot_horas = New Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit()
        Me.UltraLabel8 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraLabel9 = New Infragistics.Win.Misc.UltraLabel()
        Me.ug_ListaPer = New Infragistics.Win.UltraWinGrid.UltraGrid()
        Me.ug_ListaMarcaciones = New Infragistics.Win.UltraWinGrid.UltraGrid()
        Me.UltraGroupBox1 = New Infragistics.Win.Misc.UltraGroupBox()
        Me.udte_fec_fin = New Infragistics.Win.UltraWinEditors.UltraDateTimeEditor()
        Me.udte_fec_ini = New Infragistics.Win.UltraWinEditors.UltraDateTimeEditor()
        Me.UltraLabel6 = New Infragistics.Win.Misc.UltraLabel()
        Me.txt_idper = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.UltraLabel5 = New Infragistics.Win.Misc.UltraLabel()
        Me.txt_ayo = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.uce_mes = New Infragistics.Win.UltraWinEditors.UltraComboEditor()
        Me.UltraLabel3 = New Infragistics.Win.Misc.UltraLabel()
        Me.ubtn_Mostrar_Data = New Infragistics.Win.Misc.UltraButton()
        Me.txt_codper = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.txt_Filtro = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.UltraLabel1 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraLabel2 = New Infragistics.Win.Misc.UltraLabel()
        Me.ume_tot_refri = New Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit()
        Me.ume_tot_feriado = New Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit()
        Me.UltraLabel4 = New Infragistics.Win.Misc.UltraLabel()
        CType(Me.uds_ListaMarcaciones, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Tools_Mante.SuspendLayout()
        CType(Me.uds_ListaPer, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_Area, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ug_ListaPer, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ug_ListaMarcaciones, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UltraGroupBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraGroupBox1.SuspendLayout()
        CType(Me.udte_fec_fin, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.udte_fec_ini, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_idper, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_ayo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.uce_mes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_codper, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_Filtro, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'uds_ListaMarcaciones
        '
        Me.uds_ListaMarcaciones.AllowDelete = False
        UltraDataColumn1.DataType = GetType(Short)
        UltraDataColumn2.DataType = GetType(Date)
        UltraDataColumn8.DataType = GetType(Short)
        UltraDataColumn11.DataType = GetType(Short)
        UltraDataColumn12.DataType = GetType(Date)
        UltraDataColumn13.DataType = GetType(Date)
        UltraDataColumn14.DataType = GetType(Short)
        UltraDataColumn15.DataType = GetType(Short)
        UltraDataColumn16.DataType = GetType(Boolean)
        Me.uds_ListaMarcaciones.Band.Columns.AddRange(New Object() {UltraDataColumn1, UltraDataColumn2, UltraDataColumn3, UltraDataColumn4, UltraDataColumn5, UltraDataColumn6, UltraDataColumn7, UltraDataColumn8, UltraDataColumn9, UltraDataColumn10, UltraDataColumn11, UltraDataColumn12, UltraDataColumn13, UltraDataColumn14, UltraDataColumn15, UltraDataColumn16})
        '
        'Tools_Mante
        '
        Me.Tools_Mante.BackColor = System.Drawing.Color.White
        Me.Tools_Mante.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripSeparator1, Me.Tool_Nuevo, Me.ToolStripSeparator5, Me.Tool_Modificar, Me.ToolStripSeparator3, Me.Tool_Eliminar, Me.ToolStripSeparator2, Me.Tool_salir, Me.ToolStripSeparator4})
        Me.Tools_Mante.Location = New System.Drawing.Point(0, 0)
        Me.Tools_Mante.Name = "Tools_Mante"
        Me.Tools_Mante.Size = New System.Drawing.Size(799, 25)
        Me.Tools_Mante.TabIndex = 17
        Me.Tools_Mante.Text = "ToolStrip1"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'Tool_Nuevo
        '
        Me.Tool_Nuevo.Image = Global.Contabilidad.My.Resources.Resources._16__File_new_2_
        Me.Tool_Nuevo.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Tool_Nuevo.Name = "Tool_Nuevo"
        Me.Tool_Nuevo.Size = New System.Drawing.Size(120, 22)
        Me.Tool_Nuevo.Text = "Nueva Marcacion"
        '
        'ToolStripSeparator5
        '
        Me.ToolStripSeparator5.Name = "ToolStripSeparator5"
        Me.ToolStripSeparator5.Size = New System.Drawing.Size(6, 25)
        '
        'Tool_Modificar
        '
        Me.Tool_Modificar.Image = Global.Contabilidad.My.Resources.Resources._16__Card_edit_
        Me.Tool_Modificar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Tool_Modificar.Name = "Tool_Modificar"
        Me.Tool_Modificar.Size = New System.Drawing.Size(78, 22)
        Me.Tool_Modificar.Text = "Modificar"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 25)
        '
        'Tool_Eliminar
        '
        Me.Tool_Eliminar.Image = Global.Contabilidad.My.Resources.Resources._132
        Me.Tool_Eliminar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Tool_Eliminar.Name = "Tool_Eliminar"
        Me.Tool_Eliminar.Size = New System.Drawing.Size(70, 22)
        Me.Tool_Eliminar.Text = "Eliminar"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'Tool_salir
        '
        Me.Tool_salir.Image = Global.Contabilidad.My.Resources.Resources._28
        Me.Tool_salir.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Tool_salir.Name = "Tool_salir"
        Me.Tool_salir.Size = New System.Drawing.Size(49, 22)
        Me.Tool_salir.Text = "Salir"
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(6, 25)
        '
        'uds_ListaPer
        '
        Me.uds_ListaPer.AllowDelete = False
        UltraDataColumn17.DataType = GetType(Long)
        Me.uds_ListaPer.Band.Columns.AddRange(New Object() {UltraDataColumn17, UltraDataColumn18, UltraDataColumn19})
        '
        'txt_Area
        '
        Me.txt_Area.Location = New System.Drawing.Point(344, 81)
        Me.txt_Area.Name = "txt_Area"
        Me.txt_Area.ReadOnly = True
        Me.txt_Area.Size = New System.Drawing.Size(108, 21)
        Me.txt_Area.TabIndex = 44
        '
        'ume_tot_hor_ext
        '
        Me.ume_tot_hor_ext.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Appearance12.FontData.SizeInPoints = 12.0!
        Appearance12.ForeColor = System.Drawing.Color.Navy
        Appearance12.TextHAlignAsString = "Right"
        Me.ume_tot_hor_ext.Appearance = Appearance12
        Me.ume_tot_hor_ext.EditAs = Infragistics.Win.UltraWinMaskedEdit.EditAsType.UseSpecifiedMask
        Me.ume_tot_hor_ext.Location = New System.Drawing.Point(726, 385)
        Me.ume_tot_hor_ext.Name = "ume_tot_hor_ext"
        Me.ume_tot_hor_ext.ReadOnly = True
        Me.ume_tot_hor_ext.Size = New System.Drawing.Size(61, 26)
        Me.ume_tot_hor_ext.TabIndex = 43
        Me.ume_tot_hor_ext.Text = "UltraMaskedEdit2"
        '
        'ume_tot_horas
        '
        Me.ume_tot_horas.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Appearance15.FontData.SizeInPoints = 12.0!
        Appearance15.ForeColor = System.Drawing.Color.Navy
        Appearance15.TextHAlignAsString = "Right"
        Me.ume_tot_horas.Appearance = Appearance15
        Me.ume_tot_horas.EditAs = Infragistics.Win.UltraWinMaskedEdit.EditAsType.UseSpecifiedMask
        Me.ume_tot_horas.Location = New System.Drawing.Point(505, 385)
        Me.ume_tot_horas.Name = "ume_tot_horas"
        Me.ume_tot_horas.ReadOnly = True
        Me.ume_tot_horas.Size = New System.Drawing.Size(61, 26)
        Me.ume_tot_horas.TabIndex = 42
        Me.ume_tot_horas.Text = "UltraMaskedEdit1"
        '
        'UltraLabel8
        '
        Me.UltraLabel8.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Appearance8.BackColor = System.Drawing.Color.Transparent
        Appearance8.FontData.BoldAsString = "True"
        Appearance8.FontData.SizeInPoints = 10.0!
        Appearance8.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel8.Appearance = Appearance8
        Me.UltraLabel8.AutoSize = True
        Me.UltraLabel8.Location = New System.Drawing.Point(594, 390)
        Me.UltraLabel8.Name = "UltraLabel8"
        Me.UltraLabel8.Size = New System.Drawing.Size(123, 17)
        Me.UltraLabel8.TabIndex = 40
        Me.UltraLabel8.Text = "Total Horas Extras"
        '
        'UltraLabel9
        '
        Me.UltraLabel9.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Appearance18.BackColor = System.Drawing.Color.Transparent
        Appearance18.FontData.BoldAsString = "True"
        Appearance18.FontData.SizeInPoints = 10.0!
        Appearance18.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel9.Appearance = Appearance18
        Me.UltraLabel9.AutoSize = True
        Me.UltraLabel9.Location = New System.Drawing.Point(415, 392)
        Me.UltraLabel9.Name = "UltraLabel9"
        Me.UltraLabel9.Size = New System.Drawing.Size(79, 17)
        Me.UltraLabel9.TabIndex = 41
        Me.UltraLabel9.Text = "Total Horas "
        '
        'ug_ListaPer
        '
        Me.ug_ListaPer.DataSource = Me.uds_ListaPer
        Me.ug_ListaPer.DisplayLayout.AutoFitStyle = Infragistics.Win.UltraWinGrid.AutoFitStyle.ExtendLastColumn
        UltraGridColumn1.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn1.Header.VisiblePosition = 0
        UltraGridColumn1.Hidden = True
        UltraGridColumn2.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn2.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn2.Header.Caption = "Codigo"
        UltraGridColumn2.Header.VisiblePosition = 1
        UltraGridColumn3.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn3.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn3.Header.Caption = "Apellidos y Nombres"
        UltraGridColumn3.Header.VisiblePosition = 2
        UltraGridBand1.Columns.AddRange(New Object() {UltraGridColumn1, UltraGridColumn2, UltraGridColumn3})
        Me.ug_ListaPer.DisplayLayout.BandsSerializer.Add(UltraGridBand1)
        Me.ug_ListaPer.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.[False]
        Me.ug_ListaPer.DisplayLayout.MaxColScrollRegions = 1
        Me.ug_ListaPer.DisplayLayout.MaxRowScrollRegions = 1
        Appearance16.BackColor = System.Drawing.Color.WhiteSmoke
        Appearance16.BackColor2 = System.Drawing.Color.WhiteSmoke
        Me.ug_ListaPer.DisplayLayout.Override.RowAlternateAppearance = Appearance16
        Me.ug_ListaPer.DisplayLayout.Override.TipStyleScroll = Infragistics.Win.UltraWinGrid.TipStyle.Show
        Me.ug_ListaPer.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.ug_ListaPer.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.ug_ListaPer.Location = New System.Drawing.Point(-204, 427)
        Me.ug_ListaPer.Name = "ug_ListaPer"
        Me.ug_ListaPer.Size = New System.Drawing.Size(411, 180)
        Me.ug_ListaPer.TabIndex = 35
        Me.ug_ListaPer.Text = "UltraGrid1"
        Me.ug_ListaPer.Visible = False
        '
        'ug_ListaMarcaciones
        '
        Me.ug_ListaMarcaciones.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ug_ListaMarcaciones.DataSource = Me.uds_ListaMarcaciones
        Me.ug_ListaMarcaciones.DisplayLayout.AutoFitStyle = Infragistics.Win.UltraWinGrid.AutoFitStyle.ExtendLastColumn
        UltraGridColumn4.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn4.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn4.Header.Caption = "SEC."
        UltraGridColumn4.Header.VisiblePosition = 0
        UltraGridColumn4.Width = 29
        UltraGridColumn5.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn5.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn5.Header.Caption = "FECHA"
        UltraGridColumn5.Header.VisiblePosition = 1
        UltraGridColumn5.Width = 71
        UltraGridColumn6.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn6.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        Appearance2.TextHAlignAsString = "Center"
        UltraGridColumn6.CellAppearance = Appearance2
        UltraGridColumn6.Header.Caption = "ENTRADA"
        UltraGridColumn6.Header.VisiblePosition = 2
        UltraGridColumn6.Width = 62
        UltraGridColumn7.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn7.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        Appearance7.TextHAlignAsString = "Center"
        UltraGridColumn7.CellAppearance = Appearance7
        UltraGridColumn7.Header.Caption = "TM"
        UltraGridColumn7.Header.VisiblePosition = 3
        UltraGridColumn7.Width = 29
        UltraGridColumn8.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn8.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        Appearance9.TextHAlignAsString = "Center"
        UltraGridColumn8.CellAppearance = Appearance9
        UltraGridColumn8.Header.Caption = "SALIDA"
        UltraGridColumn8.Header.VisiblePosition = 4
        UltraGridColumn8.Width = 49
        UltraGridColumn9.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn9.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        Appearance10.TextHAlignAsString = "Center"
        UltraGridColumn9.CellAppearance = Appearance10
        UltraGridColumn9.Header.Caption = "TM"
        UltraGridColumn9.Header.VisiblePosition = 5
        UltraGridColumn9.Width = 32
        UltraGridColumn10.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn10.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        Appearance11.ForeColor = System.Drawing.Color.Navy
        Appearance11.TextHAlignAsString = "Center"
        UltraGridColumn10.CellAppearance = Appearance11
        UltraGridColumn10.Header.Caption = "TIEMPO"
        UltraGridColumn10.Header.VisiblePosition = 6
        UltraGridColumn10.Width = 53
        UltraGridColumn11.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn11.Header.VisiblePosition = 7
        UltraGridColumn11.Hidden = True
        UltraGridColumn12.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn12.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn12.Header.Caption = "TIPO"
        UltraGridColumn12.Header.VisiblePosition = 8
        UltraGridColumn12.Width = 113
        UltraGridColumn13.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn13.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn13.Header.Caption = "OBSERVACIONES"
        UltraGridColumn13.Header.VisiblePosition = 11
        UltraGridColumn14.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn14.Header.VisiblePosition = 12
        UltraGridColumn14.Hidden = True
        UltraGridColumn15.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn15.Header.VisiblePosition = 13
        UltraGridColumn15.Hidden = True
        UltraGridColumn16.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn16.Header.VisiblePosition = 14
        UltraGridColumn16.Hidden = True
        UltraGridColumn17.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn17.Header.Caption = "REFRI"
        UltraGridColumn17.Header.VisiblePosition = 9
        UltraGridColumn17.Hidden = True
        UltraGridColumn17.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.CheckBox
        UltraGridColumn17.Width = 48
        UltraGridColumn18.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn18.Header.VisiblePosition = 15
        UltraGridColumn18.Hidden = True
        UltraGridColumn19.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn19.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn19.Header.VisiblePosition = 10
        UltraGridColumn19.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.CheckBox
        UltraGridColumn19.Width = 44
        UltraGridBand2.Columns.AddRange(New Object() {UltraGridColumn4, UltraGridColumn5, UltraGridColumn6, UltraGridColumn7, UltraGridColumn8, UltraGridColumn9, UltraGridColumn10, UltraGridColumn11, UltraGridColumn12, UltraGridColumn13, UltraGridColumn14, UltraGridColumn15, UltraGridColumn16, UltraGridColumn17, UltraGridColumn18, UltraGridColumn19})
        Me.ug_ListaMarcaciones.DisplayLayout.BandsSerializer.Add(UltraGridBand2)
        Me.ug_ListaMarcaciones.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.[True]
        Me.ug_ListaMarcaciones.DisplayLayout.MaxColScrollRegions = 1
        Me.ug_ListaMarcaciones.DisplayLayout.MaxRowScrollRegions = 1
        Appearance4.BackColor = System.Drawing.Color.WhiteSmoke
        Appearance4.BackColor2 = System.Drawing.Color.WhiteSmoke
        Me.ug_ListaMarcaciones.DisplayLayout.Override.RowAlternateAppearance = Appearance4
        Me.ug_ListaMarcaciones.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.ug_ListaMarcaciones.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.ug_ListaMarcaciones.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ug_ListaMarcaciones.Location = New System.Drawing.Point(12, 118)
        Me.ug_ListaMarcaciones.Name = "ug_ListaMarcaciones"
        Me.ug_ListaMarcaciones.Size = New System.Drawing.Size(775, 261)
        Me.ug_ListaMarcaciones.TabIndex = 39
        Me.ug_ListaMarcaciones.Text = "Marcaciones"
        '
        'UltraGroupBox1
        '
        Me.UltraGroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.UltraGroupBox1.Controls.Add(Me.udte_fec_fin)
        Me.UltraGroupBox1.Controls.Add(Me.udte_fec_ini)
        Me.UltraGroupBox1.Controls.Add(Me.UltraLabel6)
        Me.UltraGroupBox1.Controls.Add(Me.txt_idper)
        Me.UltraGroupBox1.Controls.Add(Me.UltraLabel5)
        Me.UltraGroupBox1.Controls.Add(Me.txt_ayo)
        Me.UltraGroupBox1.Controls.Add(Me.uce_mes)
        Me.UltraGroupBox1.Controls.Add(Me.UltraLabel3)
        Me.UltraGroupBox1.Location = New System.Drawing.Point(8, 29)
        Me.UltraGroupBox1.Name = "UltraGroupBox1"
        Me.UltraGroupBox1.Size = New System.Drawing.Size(779, 41)
        Me.UltraGroupBox1.TabIndex = 38
        '
        'udte_fec_fin
        '
        Me.udte_fec_fin.Location = New System.Drawing.Point(388, 12)
        Me.udte_fec_fin.Name = "udte_fec_fin"
        Me.udte_fec_fin.Size = New System.Drawing.Size(88, 21)
        Me.udte_fec_fin.TabIndex = 17
        '
        'udte_fec_ini
        '
        Me.udte_fec_ini.Location = New System.Drawing.Point(267, 11)
        Me.udte_fec_ini.Name = "udte_fec_ini"
        Me.udte_fec_ini.Size = New System.Drawing.Size(92, 21)
        Me.udte_fec_ini.TabIndex = 18
        '
        'UltraLabel6
        '
        Appearance14.BackColor = System.Drawing.Color.Transparent
        Appearance14.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel6.Appearance = Appearance14
        Me.UltraLabel6.AutoSize = True
        Me.UltraLabel6.Location = New System.Drawing.Point(365, 15)
        Me.UltraLabel6.Name = "UltraLabel6"
        Me.UltraLabel6.Size = New System.Drawing.Size(18, 14)
        Me.UltraLabel6.TabIndex = 15
        Me.UltraLabel6.Text = "A :"
        '
        'txt_idper
        '
        Me.txt_idper.Location = New System.Drawing.Point(543, 15)
        Me.txt_idper.Name = "txt_idper"
        Me.txt_idper.ReadOnly = True
        Me.txt_idper.Size = New System.Drawing.Size(33, 21)
        Me.txt_idper.TabIndex = 21
        Me.txt_idper.Visible = False
        '
        'UltraLabel5
        '
        Appearance5.BackColor = System.Drawing.Color.Transparent
        Appearance5.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel5.Appearance = Appearance5
        Me.UltraLabel5.AutoSize = True
        Me.UltraLabel5.Location = New System.Drawing.Point(238, 15)
        Me.UltraLabel5.Name = "UltraLabel5"
        Me.UltraLabel5.Size = New System.Drawing.Size(25, 14)
        Me.UltraLabel5.TabIndex = 16
        Me.UltraLabel5.Text = "De :"
        '
        'txt_ayo
        '
        Me.txt_ayo.Location = New System.Drawing.Point(65, 11)
        Me.txt_ayo.Name = "txt_ayo"
        Me.txt_ayo.ReadOnly = True
        Me.txt_ayo.Size = New System.Drawing.Size(47, 21)
        Me.txt_ayo.TabIndex = 7
        '
        'uce_mes
        '
        Me.uce_mes.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.uce_mes.Location = New System.Drawing.Point(112, 11)
        Me.uce_mes.Name = "uce_mes"
        Me.uce_mes.Size = New System.Drawing.Size(112, 21)
        Me.uce_mes.TabIndex = 4
        '
        'UltraLabel3
        '
        Appearance3.BackColor = System.Drawing.Color.Transparent
        Appearance3.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel3.Appearance = Appearance3
        Me.UltraLabel3.AutoSize = True
        Me.UltraLabel3.Location = New System.Drawing.Point(10, 15)
        Me.UltraLabel3.Name = "UltraLabel3"
        Me.UltraLabel3.Size = New System.Drawing.Size(49, 14)
        Me.UltraLabel3.TabIndex = 1
        Me.UltraLabel3.Text = "Periodo :"
        '
        'ubtn_Mostrar_Data
        '
        Appearance1.FontData.BoldAsString = "True"
        Me.ubtn_Mostrar_Data.Appearance = Appearance1
        Me.ubtn_Mostrar_Data.Location = New System.Drawing.Point(467, 78)
        Me.ubtn_Mostrar_Data.Name = "ubtn_Mostrar_Data"
        Me.ubtn_Mostrar_Data.Size = New System.Drawing.Size(84, 28)
        Me.ubtn_Mostrar_Data.TabIndex = 34
        Me.ubtn_Mostrar_Data.Text = "Mostrar"
        '
        'txt_codper
        '
        Me.txt_codper.Location = New System.Drawing.Point(291, 81)
        Me.txt_codper.Name = "txt_codper"
        Me.txt_codper.ReadOnly = True
        Me.txt_codper.Size = New System.Drawing.Size(53, 21)
        Me.txt_codper.TabIndex = 37
        '
        'txt_Filtro
        '
        Me.txt_Filtro.Location = New System.Drawing.Point(73, 81)
        Me.txt_Filtro.Name = "txt_Filtro"
        Me.txt_Filtro.Size = New System.Drawing.Size(218, 21)
        Me.txt_Filtro.TabIndex = 33
        '
        'UltraLabel1
        '
        Appearance17.BackColor = System.Drawing.Color.Transparent
        Appearance17.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel1.Appearance = Appearance17
        Me.UltraLabel1.AutoSize = True
        Me.UltraLabel1.Location = New System.Drawing.Point(12, 85)
        Me.UltraLabel1.Name = "UltraLabel1"
        Me.UltraLabel1.Size = New System.Drawing.Size(55, 14)
        Me.UltraLabel1.TabIndex = 36
        Me.UltraLabel1.Text = "Personal :"
        '
        'UltraLabel2
        '
        Me.UltraLabel2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Appearance19.BackColor = System.Drawing.Color.Transparent
        Appearance19.FontData.BoldAsString = "True"
        Appearance19.FontData.SizeInPoints = 10.0!
        Appearance19.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel2.Appearance = Appearance19
        Me.UltraLabel2.AutoSize = True
        Me.UltraLabel2.Location = New System.Drawing.Point(42, 392)
        Me.UltraLabel2.Name = "UltraLabel2"
        Me.UltraLabel2.Size = New System.Drawing.Size(110, 17)
        Me.UltraLabel2.TabIndex = 45
        Me.UltraLabel2.Text = "Total Refrigerios"
        '
        'ume_tot_refri
        '
        Me.ume_tot_refri.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Appearance20.FontData.SizeInPoints = 12.0!
        Appearance20.ForeColor = System.Drawing.Color.Navy
        Appearance20.TextHAlignAsString = "Center"
        Me.ume_tot_refri.Appearance = Appearance20
        Me.ume_tot_refri.EditAs = Infragistics.Win.UltraWinMaskedEdit.EditAsType.[Integer]
        Me.ume_tot_refri.InputMask = "nn"
        Me.ume_tot_refri.Location = New System.Drawing.Point(160, 385)
        Me.ume_tot_refri.Name = "ume_tot_refri"
        Me.ume_tot_refri.ReadOnly = True
        Me.ume_tot_refri.Size = New System.Drawing.Size(35, 26)
        Me.ume_tot_refri.TabIndex = 46
        '
        'ume_tot_feriado
        '
        Me.ume_tot_feriado.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Appearance13.FontData.SizeInPoints = 12.0!
        Appearance13.ForeColor = System.Drawing.Color.Navy
        Appearance13.TextHAlignAsString = "Center"
        Me.ume_tot_feriado.Appearance = Appearance13
        Me.ume_tot_feriado.EditAs = Infragistics.Win.UltraWinMaskedEdit.EditAsType.[Integer]
        Me.ume_tot_feriado.InputMask = "nn"
        Me.ume_tot_feriado.Location = New System.Drawing.Point(324, 385)
        Me.ume_tot_feriado.Name = "ume_tot_feriado"
        Me.ume_tot_feriado.ReadOnly = True
        Me.ume_tot_feriado.Size = New System.Drawing.Size(35, 26)
        Me.ume_tot_feriado.TabIndex = 48
        '
        'UltraLabel4
        '
        Me.UltraLabel4.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Appearance6.BackColor = System.Drawing.Color.Transparent
        Appearance6.FontData.BoldAsString = "True"
        Appearance6.FontData.SizeInPoints = 10.0!
        Appearance6.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel4.Appearance = Appearance6
        Me.UltraLabel4.AutoSize = True
        Me.UltraLabel4.Location = New System.Drawing.Point(228, 392)
        Me.UltraLabel4.Name = "UltraLabel4"
        Me.UltraLabel4.Size = New System.Drawing.Size(89, 17)
        Me.UltraLabel4.TabIndex = 47
        Me.UltraLabel4.Text = "Total Feriado"
        '
        'HO_PR_EditarRegDiario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(799, 423)
        Me.Controls.Add(Me.ume_tot_feriado)
        Me.Controls.Add(Me.UltraLabel4)
        Me.Controls.Add(Me.ume_tot_refri)
        Me.Controls.Add(Me.UltraLabel2)
        Me.Controls.Add(Me.txt_Area)
        Me.Controls.Add(Me.ume_tot_hor_ext)
        Me.Controls.Add(Me.ume_tot_horas)
        Me.Controls.Add(Me.UltraLabel8)
        Me.Controls.Add(Me.UltraLabel9)
        Me.Controls.Add(Me.ug_ListaPer)
        Me.Controls.Add(Me.ug_ListaMarcaciones)
        Me.Controls.Add(Me.UltraGroupBox1)
        Me.Controls.Add(Me.ubtn_Mostrar_Data)
        Me.Controls.Add(Me.txt_codper)
        Me.Controls.Add(Me.txt_Filtro)
        Me.Controls.Add(Me.UltraLabel1)
        Me.Controls.Add(Me.Tools_Mante)
        Me.Name = "HO_PR_EditarRegDiario"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Edicion de Registros"
        CType(Me.uds_ListaMarcaciones, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Tools_Mante.ResumeLayout(False)
        Me.Tools_Mante.PerformLayout()
        CType(Me.uds_ListaPer, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_Area, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ug_ListaPer, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ug_ListaMarcaciones, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UltraGroupBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraGroupBox1.ResumeLayout(False)
        Me.UltraGroupBox1.PerformLayout()
        CType(Me.udte_fec_fin, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.udte_fec_ini, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_idper, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_ayo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.uce_mes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_codper, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_Filtro, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents uds_ListaMarcaciones As Infragistics.Win.UltraWinDataSource.UltraDataSource
    Friend WithEvents Tools_Mante As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents Tool_Nuevo As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator5 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents Tool_Modificar As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents Tool_Eliminar As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents Tool_salir As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents uds_ListaPer As Infragistics.Win.UltraWinDataSource.UltraDataSource
    Friend WithEvents txt_Area As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents ume_tot_hor_ext As Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit
    Friend WithEvents ume_tot_horas As Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit
    Friend WithEvents UltraLabel8 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel9 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents ug_ListaPer As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents ug_ListaMarcaciones As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents UltraGroupBox1 As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents udte_fec_fin As Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
    Friend WithEvents udte_fec_ini As Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
    Friend WithEvents UltraLabel6 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents txt_idper As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents UltraLabel5 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents txt_ayo As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents uce_mes As Infragistics.Win.UltraWinEditors.UltraComboEditor
    Friend WithEvents UltraLabel3 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents ubtn_Mostrar_Data As Infragistics.Win.Misc.UltraButton
    Friend WithEvents txt_codper As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents txt_Filtro As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents UltraLabel1 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel2 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents ume_tot_refri As Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit
    Friend WithEvents ume_tot_feriado As Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit
    Friend WithEvents UltraLabel4 As Infragistics.Win.Misc.UltraLabel
End Class
