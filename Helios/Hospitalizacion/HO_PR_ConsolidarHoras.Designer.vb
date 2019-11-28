<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class HO_PR_ConsolidarHoras
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
        Dim UltraDataColumn13 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("PE_ID")
        Dim UltraDataColumn14 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("PE_CODIGO")
        Dim UltraDataColumn15 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("NOMBRES")
        Dim UltraDataColumn16 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("TT_DESCRIPCION")
        Dim UltraDataColumn17 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("CUNA_NORMAL")
        Dim UltraDataColumn18 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("INTERMEDIOS")
        Dim UltraDataColumn19 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("UCI")
        Dim UltraDataColumn20 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("TOTAL")
        Dim UltraDataColumn21 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("FIJAS")
        Dim UltraDataColumn22 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("EXTRAS")
        Dim UltraDataColumn23 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("EXTRAS_DOBLE")
        Dim UltraDataColumn24 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("REFRIGERIO")
        Dim Appearance9 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance12 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance1 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance3 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridBand1 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1)
        Dim UltraGridColumn1 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("PE_ID", -1, Nothing, 6675190, 3, 0)
        Dim UltraGridColumn2 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("PE_CODIGO", -1, Nothing, 6675190, 0, 0)
        Dim UltraGridColumn3 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NOMBRES", -1, Nothing, 6675190, 1, 0, 0, Infragistics.Win.UltraWinGrid.SortIndicator.Ascending, False)
        Dim UltraGridColumn4 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TT_DESCRIPCION", -1, Nothing, 6675190, 2, 0)
        Dim Appearance2 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn5 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CUNA_NORMAL", -1, Nothing, 6675191, 0, 0)
        Dim Appearance5 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn6 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("INTERMEDIOS", -1, Nothing, 6675191, 1, 0)
        Dim Appearance6 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn7 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("UCI", -1, Nothing, 6675191, 2, 0)
        Dim Appearance7 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn8 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TOTAL", -1, Nothing, 6675191, 3, 0)
        Dim Appearance8 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn9 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FIJAS", -1, Nothing, 6675192, 0, 0)
        Dim Appearance10 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn10 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("EXTRAS", -1, Nothing, 6675192, 1, 0)
        Dim Appearance11 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn11 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("EXTRAS_DOBLE", -1, Nothing, 6675192, 2, 0)
        Dim Appearance13 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn12 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("REFRIGERIO", -1, Nothing, 6675192, 3, 0)
        Dim Appearance14 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridGroup1 As Infragistics.Win.UltraWinGrid.UltraGridGroup = New Infragistics.Win.UltraWinGrid.UltraGridGroup("PERSONAL", 6675190)
        Dim Appearance15 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridGroup2 As Infragistics.Win.UltraWinGrid.UltraGridGroup = New Infragistics.Win.UltraWinGrid.UltraGridGroup("SALA DE BEBES", 6675191)
        Dim Appearance16 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridGroup3 As Infragistics.Win.UltraWinGrid.UltraGridGroup = New Infragistics.Win.UltraWinGrid.UltraGridGroup("HOSPITALIZACION", 6675192)
        Dim Appearance17 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance19 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Me.uds_registro = New Infragistics.Win.UltraWinDataSource.UltraDataSource(Me.components)
        Me.Tools_Mante = New System.Windows.Forms.ToolStrip()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.Tool_Grabar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.Tool_salir = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.UltraGroupBox1 = New Infragistics.Win.Misc.UltraGroupBox()
        Me.utxt_estado2 = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.txt_estado = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.ubtn_Mostrar_Data = New Infragistics.Win.Misc.UltraButton()
        Me.txt_ayo = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.uce_mes = New Infragistics.Win.UltraWinEditors.UltraComboEditor()
        Me.UltraLabel1 = New Infragistics.Win.Misc.UltraLabel()
        Me.ug_registro = New Infragistics.Win.UltraWinGrid.UltraGrid()
        CType(Me.uds_registro, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Tools_Mante.SuspendLayout()
        CType(Me.UltraGroupBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraGroupBox1.SuspendLayout()
        CType(Me.utxt_estado2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_estado, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_ayo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.uce_mes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ug_registro, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'uds_registro
        '
        Me.uds_registro.AllowDelete = False
        UltraDataColumn13.DataType = GetType(Long)
        UltraDataColumn24.DataType = GetType(Short)
        Me.uds_registro.Band.Columns.AddRange(New Object() {UltraDataColumn13, UltraDataColumn14, UltraDataColumn15, UltraDataColumn16, UltraDataColumn17, UltraDataColumn18, UltraDataColumn19, UltraDataColumn20, UltraDataColumn21, UltraDataColumn22, UltraDataColumn23, UltraDataColumn24})
        '
        'Tools_Mante
        '
        Me.Tools_Mante.BackColor = System.Drawing.Color.White
        Me.Tools_Mante.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripSeparator1, Me.Tool_Grabar, Me.ToolStripSeparator3, Me.Tool_salir, Me.ToolStripSeparator2})
        Me.Tools_Mante.Location = New System.Drawing.Point(0, 0)
        Me.Tools_Mante.Name = "Tools_Mante"
        Me.Tools_Mante.Size = New System.Drawing.Size(950, 25)
        Me.Tools_Mante.TabIndex = 15
        Me.Tools_Mante.Text = "ToolStrip1"
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
        Me.Tool_Grabar.Size = New System.Drawing.Size(95, 22)
        Me.Tool_Grabar.Text = "Grabar Datos"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 25)
        '
        'Tool_salir
        '
        Me.Tool_salir.Image = Global.Contabilidad.My.Resources.Resources._28
        Me.Tool_salir.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Tool_salir.Name = "Tool_salir"
        Me.Tool_salir.Size = New System.Drawing.Size(49, 22)
        Me.Tool_salir.Text = "Salir"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'UltraGroupBox1
        '
        Me.UltraGroupBox1.Controls.Add(Me.utxt_estado2)
        Me.UltraGroupBox1.Controls.Add(Me.txt_estado)
        Me.UltraGroupBox1.Controls.Add(Me.ubtn_Mostrar_Data)
        Me.UltraGroupBox1.Controls.Add(Me.txt_ayo)
        Me.UltraGroupBox1.Controls.Add(Me.uce_mes)
        Me.UltraGroupBox1.Controls.Add(Me.UltraLabel1)
        Me.UltraGroupBox1.Location = New System.Drawing.Point(12, 28)
        Me.UltraGroupBox1.Name = "UltraGroupBox1"
        Me.UltraGroupBox1.Size = New System.Drawing.Size(921, 58)
        Me.UltraGroupBox1.TabIndex = 16
        '
        'utxt_estado2
        '
        Me.utxt_estado2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Appearance9.FontData.BoldAsString = "True"
        Appearance9.ForeColor = System.Drawing.Color.Navy
        Appearance9.TextHAlignAsString = "Center"
        Me.utxt_estado2.Appearance = Appearance9
        Me.utxt_estado2.Location = New System.Drawing.Point(486, 30)
        Me.utxt_estado2.Name = "utxt_estado2"
        Me.utxt_estado2.ReadOnly = True
        Me.utxt_estado2.Size = New System.Drawing.Size(420, 21)
        Me.utxt_estado2.TabIndex = 13
        '
        'txt_estado
        '
        Me.txt_estado.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Appearance12.FontData.BoldAsString = "True"
        Appearance12.ForeColor = System.Drawing.Color.Navy
        Appearance12.TextHAlignAsString = "Center"
        Me.txt_estado.Appearance = Appearance12
        Me.txt_estado.Location = New System.Drawing.Point(486, 8)
        Me.txt_estado.Name = "txt_estado"
        Me.txt_estado.ReadOnly = True
        Me.txt_estado.Size = New System.Drawing.Size(420, 21)
        Me.txt_estado.TabIndex = 9
        '
        'ubtn_Mostrar_Data
        '
        Appearance1.FontData.BoldAsString = "True"
        Me.ubtn_Mostrar_Data.Appearance = Appearance1
        Me.ubtn_Mostrar_Data.Location = New System.Drawing.Point(241, 14)
        Me.ubtn_Mostrar_Data.Name = "ubtn_Mostrar_Data"
        Me.ubtn_Mostrar_Data.Size = New System.Drawing.Size(88, 31)
        Me.ubtn_Mostrar_Data.TabIndex = 8
        Me.ubtn_Mostrar_Data.Text = "Mostrar"
        '
        'txt_ayo
        '
        Me.txt_ayo.Location = New System.Drawing.Point(68, 19)
        Me.txt_ayo.Name = "txt_ayo"
        Me.txt_ayo.Size = New System.Drawing.Size(47, 21)
        Me.txt_ayo.TabIndex = 7
        '
        'uce_mes
        '
        Me.uce_mes.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.uce_mes.Location = New System.Drawing.Point(116, 19)
        Me.uce_mes.Name = "uce_mes"
        Me.uce_mes.Size = New System.Drawing.Size(102, 21)
        Me.uce_mes.TabIndex = 4
        '
        'UltraLabel1
        '
        Appearance3.BackColor = System.Drawing.Color.Transparent
        Appearance3.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel1.Appearance = Appearance3
        Me.UltraLabel1.AutoSize = True
        Me.UltraLabel1.Location = New System.Drawing.Point(20, 22)
        Me.UltraLabel1.Name = "UltraLabel1"
        Me.UltraLabel1.Size = New System.Drawing.Size(49, 14)
        Me.UltraLabel1.TabIndex = 1
        Me.UltraLabel1.Text = "Periodo :"
        '
        'ug_registro
        '
        Me.ug_registro.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ug_registro.DataSource = Me.uds_registro
        Me.ug_registro.DisplayLayout.AutoFitStyle = Infragistics.Win.UltraWinGrid.AutoFitStyle.ExtendLastColumn
        UltraGridColumn1.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn1.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn1.Hidden = True
        UltraGridColumn2.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn2.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn2.Header.Caption = "Cod Per"
        UltraGridColumn2.Width = 46
        UltraGridColumn3.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn3.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn3.Header.Caption = "Nombres"
        UltraGridColumn3.Width = 178
        UltraGridColumn4.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn4.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        Appearance2.FontData.SizeInPoints = 7.0!
        UltraGridColumn4.CellAppearance = Appearance2
        UltraGridColumn4.Header.Caption = "Cargo Tipo"
        UltraGridColumn4.Width = 99
        UltraGridColumn5.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn5.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        Appearance5.ForeColor = System.Drawing.Color.Navy
        Appearance5.TextHAlignAsString = "Center"
        UltraGridColumn5.CellAppearance = Appearance5
        UltraGridColumn5.Header.Caption = "CUNA / NORMAL"
        UltraGridColumn5.MaskInput = ""
        UltraGridColumn5.Width = 88
        UltraGridColumn6.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn6.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        Appearance6.ForeColor = System.Drawing.Color.Navy
        Appearance6.TextHAlignAsString = "Center"
        UltraGridColumn6.CellAppearance = Appearance6
        UltraGridColumn6.MaskInput = ""
        UltraGridColumn6.Width = 66
        UltraGridColumn7.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn7.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        Appearance7.ForeColor = System.Drawing.Color.Navy
        Appearance7.TextHAlignAsString = "Center"
        UltraGridColumn7.CellAppearance = Appearance7
        UltraGridColumn7.MaskInput = ""
        UltraGridColumn7.Width = 71
        UltraGridColumn8.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn8.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        Appearance8.FontData.BoldAsString = "True"
        Appearance8.ForeColor = System.Drawing.Color.Navy
        Appearance8.TextHAlignAsString = "Center"
        UltraGridColumn8.CellAppearance = Appearance8
        UltraGridColumn8.Width = 58
        UltraGridColumn9.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn9.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        Appearance10.ForeColor = System.Drawing.Color.Purple
        Appearance10.TextHAlignAsString = "Center"
        UltraGridColumn9.CellAppearance = Appearance10
        UltraGridColumn9.MaskInput = ""
        UltraGridColumn9.Width = 76
        UltraGridColumn10.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn10.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        Appearance11.ForeColor = System.Drawing.Color.Purple
        Appearance11.TextHAlignAsString = "Center"
        UltraGridColumn10.CellAppearance = Appearance11
        UltraGridColumn10.Header.Caption = "EXT. SIMP."
        UltraGridColumn10.Width = 72
        UltraGridColumn11.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn11.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        Appearance13.ForeColor = System.Drawing.Color.Purple
        Appearance13.TextHAlignAsString = "Center"
        UltraGridColumn11.CellAppearance = Appearance13
        UltraGridColumn11.Header.Caption = "FERIADO"
        UltraGridColumn11.Width = 67
        UltraGridColumn12.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn12.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        Appearance14.ForeColor = System.Drawing.Color.Purple
        Appearance14.TextHAlignAsString = "Center"
        UltraGridColumn12.CellAppearance = Appearance14
        UltraGridColumn12.Width = 48
        UltraGridBand1.Columns.AddRange(New Object() {UltraGridColumn1, UltraGridColumn2, UltraGridColumn3, UltraGridColumn4, UltraGridColumn5, UltraGridColumn6, UltraGridColumn7, UltraGridColumn8, UltraGridColumn9, UltraGridColumn10, UltraGridColumn11, UltraGridColumn12})
        Appearance15.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Appearance15.FontData.SizeInPoints = 9.0!
        Appearance15.ForeColor = System.Drawing.Color.Red
        UltraGridGroup1.Header.Appearance = Appearance15
        UltraGridGroup1.Header.TextOrientation = New Infragistics.Win.TextOrientationInfo(0, Infragistics.Win.TextFlowDirection.Horizontal)
        UltraGridGroup1.Key = "PERSONAL"
        Appearance16.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Appearance16.FontData.SizeInPoints = 9.0!
        Appearance16.ForeColor = System.Drawing.Color.Red
        UltraGridGroup2.Header.Appearance = Appearance16
        UltraGridGroup2.Key = "SALA DE BEBES"
        Appearance17.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Appearance17.BorderColor = System.Drawing.Color.Purple
        Appearance17.BorderColor2 = System.Drawing.Color.Purple
        Appearance17.FontData.SizeInPoints = 9.0!
        Appearance17.ForeColor = System.Drawing.Color.Red
        UltraGridGroup3.Header.Appearance = Appearance17
        UltraGridGroup3.Key = "HOSPITALIZACION"
        UltraGridBand1.Groups.AddRange(New Infragistics.Win.UltraWinGrid.UltraGridGroup() {UltraGridGroup1, UltraGridGroup2, UltraGridGroup3})
        UltraGridBand1.SummaryFooterCaption = ""
        Me.ug_registro.DisplayLayout.BandsSerializer.Add(UltraGridBand1)
        Me.ug_registro.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.[False]
        Me.ug_registro.DisplayLayout.MaxColScrollRegions = 1
        Me.ug_registro.DisplayLayout.MaxRowScrollRegions = 1
        Me.ug_registro.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Appearance19.BackColor = System.Drawing.Color.WhiteSmoke
        Appearance19.BackColor2 = System.Drawing.Color.WhiteSmoke
        Me.ug_registro.DisplayLayout.Override.RowAlternateAppearance = Appearance19
        Me.ug_registro.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.ug_registro.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.ug_registro.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ug_registro.Location = New System.Drawing.Point(12, 92)
        Me.ug_registro.Name = "ug_registro"
        Me.ug_registro.Size = New System.Drawing.Size(921, 301)
        Me.ug_registro.TabIndex = 17
        Me.ug_registro.Text = "UltraGrid1"
        '
        'HO_PR_ConsolidarHoras
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(950, 405)
        Me.Controls.Add(Me.ug_registro)
        Me.Controls.Add(Me.UltraGroupBox1)
        Me.Controls.Add(Me.Tools_Mante)
        Me.Name = "HO_PR_ConsolidarHoras"
        Me.Text = "Resumen de Horas x Personal"
        CType(Me.uds_registro, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Tools_Mante.ResumeLayout(False)
        Me.Tools_Mante.PerformLayout()
        CType(Me.UltraGroupBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraGroupBox1.ResumeLayout(False)
        Me.UltraGroupBox1.PerformLayout()
        CType(Me.utxt_estado2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_estado, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_ayo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.uce_mes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ug_registro, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents uds_registro As Infragistics.Win.UltraWinDataSource.UltraDataSource
    Friend WithEvents Tools_Mante As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents Tool_Grabar As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents Tool_salir As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents UltraGroupBox1 As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents utxt_estado2 As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents txt_estado As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents ubtn_Mostrar_Data As Infragistics.Win.Misc.UltraButton
    Friend WithEvents txt_ayo As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents uce_mes As Infragistics.Win.UltraWinEditors.UltraComboEditor
    Friend WithEvents UltraLabel1 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents ug_registro As Infragistics.Win.UltraWinGrid.UltraGrid
End Class
