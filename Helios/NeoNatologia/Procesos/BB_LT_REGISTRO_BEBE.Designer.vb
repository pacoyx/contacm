<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BB_LT_REGISTRO_BEBE
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
        Dim Appearance31 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridBand1 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1)
        Dim UltraGridColumn1 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IMAGEN")
        Dim Appearance2 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn2 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("UB_ID")
        Dim UltraGridColumn3 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("UB_NOMBRE")
        Dim UltraGridColumn4 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("BEBE")
        Dim UltraGridColumn5 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CB_IDREGISTRO")
        Dim UltraGridColumn6 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("PF_FacTramite")
        Dim Appearance33 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance34 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance35 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance36 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraDataColumn1 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IMAGEN")
        Dim UltraDataColumn2 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("UB_ID")
        Dim UltraDataColumn3 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("UB_NOMBRE")
        Dim UltraDataColumn4 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("BEBE")
        Dim UltraDataColumn5 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("CB_IDREGISTRO")
        Dim UltraDataColumn6 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("PF_FacTramite")
        Dim Appearance23 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance15 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance16 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance17 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance18 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance19 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance20 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance21 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance3 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance24 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim EditorButton1 As Infragistics.Win.UltraWinEditors.EditorButton = New Infragistics.Win.UltraWinEditors.EditorButton("ayuda")
        Dim Appearance25 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance26 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance27 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance28 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance1 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraTab1 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraTab2 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Me.UltraTabPageControl1 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.ubtn_Logistica = New Infragistics.Win.Misc.UltraButton()
        Me.ubtn_Facturacion = New Infragistics.Win.Misc.UltraButton()
        Me.ubtn_Farmacia = New Infragistics.Win.Misc.UltraButton()
        Me.ubtn_Ubicacion = New Infragistics.Win.Misc.UltraButton()
        Me.ug_SalaBebes = New Infragistics.Win.UltraWinGrid.UltraGrid()
        Me.uds_SalaBebes = New Infragistics.Win.UltraWinDataSource.UltraDataSource(Me.components)
        Me.UltraTabPageControl2 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.ugb_datos = New Infragistics.Win.Misc.UltraGroupBox()
        Me.ugb_DatosDet = New Infragistics.Win.Misc.UltraGroupBox()
        Me.ucb_GrupoS = New Infragistics.Win.UltraWinEditors.UltraComboEditor()
        Me.UltraLabel11 = New Infragistics.Win.Misc.UltraLabel()
        Me.txt_bebe = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.UltraLabel2 = New Infragistics.Win.Misc.UltraLabel()
        Me.dtp_FechaIngreso = New System.Windows.Forms.DateTimePicker()
        Me.UltraLabel7 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraLabel10 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraLabel8 = New Infragistics.Win.Misc.UltraLabel()
        Me.udtp_fechaAlta = New Infragistics.Win.UltraWinEditors.UltraDateTimeEditor()
        Me.txt_diag = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.UltraLabel9 = New Infragistics.Win.Misc.UltraLabel()
        Me.txt_obs = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.txt_Peso = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.UltraLabel16 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraLabel6 = New Infragistics.Win.Misc.UltraLabel()
        Me.txt_madre = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.UltraLabel5 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraLabel4 = New Infragistics.Win.Misc.UltraLabel()
        Me.uce_Medico = New Infragistics.Win.UltraWinEditors.UltraComboEditor()
        Me.txt_Talla = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.txt_idRegistro = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.txt_idcuna = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.txt_PACIENTE = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.txt_num_historia = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.txt_idCuenta = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.UltraLabel13 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraLabel1 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraLabel3 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraLabel15 = New Infragistics.Win.Misc.UltraLabel()
        Me.ToolS_Mantenimiento = New System.Windows.Forms.ToolStrip()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.Tool_Grabar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.Tool_Cancelar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.Tool_daralta = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator()
        Me.Tool_CambCuenta = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator6 = New System.Windows.Forms.ToolStripSeparator()
        Me.Tool_Salir = New System.Windows.Forms.ToolStripButton()
        Me.utc_hospi = New Infragistics.Win.UltraWinTabControl.UltraTabControl()
        Me.UltraTabSharedControlsPage1 = New Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage()
        Me.UltraTabPageControl1.SuspendLayout()
        CType(Me.ug_SalaBebes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.uds_SalaBebes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabPageControl2.SuspendLayout()
        CType(Me.ugb_datos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ugb_datos.SuspendLayout()
        CType(Me.ugb_DatosDet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ugb_DatosDet.SuspendLayout()
        CType(Me.ucb_GrupoS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_bebe, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.udtp_fechaAlta, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_diag, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_obs, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_Peso, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_madre, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.uce_Medico, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_Talla, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_idRegistro, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_idcuna, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_PACIENTE, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_num_historia, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_idCuenta, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolS_Mantenimiento.SuspendLayout()
        CType(Me.utc_hospi, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.utc_hospi.SuspendLayout()
        Me.SuspendLayout()
        '
        'UltraTabPageControl1
        '
        Me.UltraTabPageControl1.Controls.Add(Me.ubtn_Logistica)
        Me.UltraTabPageControl1.Controls.Add(Me.ubtn_Facturacion)
        Me.UltraTabPageControl1.Controls.Add(Me.ubtn_Farmacia)
        Me.UltraTabPageControl1.Controls.Add(Me.ubtn_Ubicacion)
        Me.UltraTabPageControl1.Controls.Add(Me.ug_SalaBebes)
        Me.UltraTabPageControl1.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl1.Name = "UltraTabPageControl1"
        Me.UltraTabPageControl1.Size = New System.Drawing.Size(761, 428)
        '
        'ubtn_Logistica
        '
        Me.ubtn_Logistica.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ubtn_Logistica.Location = New System.Drawing.Point(532, 7)
        Me.ubtn_Logistica.Name = "ubtn_Logistica"
        Me.ubtn_Logistica.Size = New System.Drawing.Size(140, 30)
        Me.ubtn_Logistica.TabIndex = 59
        Me.ubtn_Logistica.Text = "Logistica"
        '
        'ubtn_Facturacion
        '
        Me.ubtn_Facturacion.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ubtn_Facturacion.Location = New System.Drawing.Point(356, 7)
        Me.ubtn_Facturacion.Name = "ubtn_Facturacion"
        Me.ubtn_Facturacion.Size = New System.Drawing.Size(140, 30)
        Me.ubtn_Facturacion.TabIndex = 58
        Me.ubtn_Facturacion.Text = "Facturacion"
        '
        'ubtn_Farmacia
        '
        Me.ubtn_Farmacia.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ubtn_Farmacia.Location = New System.Drawing.Point(181, 7)
        Me.ubtn_Farmacia.Name = "ubtn_Farmacia"
        Me.ubtn_Farmacia.Size = New System.Drawing.Size(140, 30)
        Me.ubtn_Farmacia.TabIndex = 57
        Me.ubtn_Farmacia.Text = "Farmacia"
        '
        'ubtn_Ubicacion
        '
        Me.ubtn_Ubicacion.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ubtn_Ubicacion.Location = New System.Drawing.Point(7, 7)
        Me.ubtn_Ubicacion.Name = "ubtn_Ubicacion"
        Me.ubtn_Ubicacion.Size = New System.Drawing.Size(140, 30)
        Me.ubtn_Ubicacion.TabIndex = 56
        Me.ubtn_Ubicacion.Text = "Ubicacion"
        '
        'ug_SalaBebes
        '
        Me.ug_SalaBebes.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ug_SalaBebes.DataSource = Me.uds_SalaBebes
        Appearance31.BackColor = System.Drawing.Color.White
        Me.ug_SalaBebes.DisplayLayout.Appearance = Appearance31
        Me.ug_SalaBebes.DisplayLayout.AutoFitStyle = Infragistics.Win.UltraWinGrid.AutoFitStyle.ExtendLastColumn
        UltraGridBand1.AutoPreviewMaxLines = 4
        UltraGridBand1.CardView = True
        UltraGridBand1.ColHeadersVisible = False
        UltraGridColumn1.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn1.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        Appearance2.ImageHAlign = Infragistics.Win.HAlign.Center
        Appearance2.ImageVAlign = Infragistics.Win.VAlign.Middle
        UltraGridColumn1.CellAppearance = Appearance2
        UltraGridColumn1.Header.Caption = "IMG"
        UltraGridColumn1.Header.VisiblePosition = 0
        UltraGridColumn1.RowLayoutColumnInfo.OriginX = 0
        UltraGridColumn1.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn1.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(150, 100)
        UltraGridColumn1.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn1.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn1.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.ImageWithShadow
        UltraGridColumn2.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn2.Header.Caption = "Codigo"
        UltraGridColumn2.Header.VisiblePosition = 1
        UltraGridColumn2.Hidden = True
        UltraGridColumn3.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn3.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn3.Header.Caption = "Nombre"
        UltraGridColumn3.Header.VisiblePosition = 2
        UltraGridColumn3.RowLayoutColumnInfo.OriginX = 0
        UltraGridColumn3.RowLayoutColumnInfo.OriginY = 2
        UltraGridColumn3.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(150, 0)
        UltraGridColumn3.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn3.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn4.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn4.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn4.Header.Caption = "Bebe"
        UltraGridColumn4.Header.VisiblePosition = 3
        UltraGridColumn4.RowLayoutColumnInfo.OriginX = 0
        UltraGridColumn4.RowLayoutColumnInfo.OriginY = 4
        UltraGridColumn4.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(150, 0)
        UltraGridColumn4.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn4.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn5.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn5.Header.VisiblePosition = 4
        UltraGridColumn5.Hidden = True
        UltraGridColumn6.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn6.Header.VisiblePosition = 5
        UltraGridColumn6.Hidden = True
        UltraGridBand1.Columns.AddRange(New Object() {UltraGridColumn1, UltraGridColumn2, UltraGridColumn3, UltraGridColumn4, UltraGridColumn5, UltraGridColumn6})
        UltraGridBand1.UseRowLayout = True
        Me.ug_SalaBebes.DisplayLayout.BandsSerializer.Add(UltraGridBand1)
        Me.ug_SalaBebes.DisplayLayout.Override.AllowColSizing = Infragistics.Win.UltraWinGrid.AllowColSizing.None
        Me.ug_SalaBebes.DisplayLayout.Override.AllowDelete = Infragistics.Win.DefaultableBoolean.[False]
        Me.ug_SalaBebes.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.[False]
        Appearance33.BackColor = System.Drawing.Color.Transparent
        Me.ug_SalaBebes.DisplayLayout.Override.CardAreaAppearance = Appearance33
        Appearance34.BackColor = System.Drawing.Color.FromArgb(CType(CType(168, Byte), Integer), CType(CType(167, Byte), Integer), CType(CType(191, Byte), Integer))
        Appearance34.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(112, Byte), Integer), CType(CType(111, Byte), Integer), CType(CType(145, Byte), Integer))
        Appearance34.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance34.FontData.BoldAsString = "True"
        Appearance34.FontData.Name = "Arial"
        Appearance34.FontData.SizeInPoints = 10.0!
        Appearance34.ForeColor = System.Drawing.Color.White
        Appearance34.ThemedElementAlpha = Infragistics.Win.Alpha.Transparent
        Me.ug_SalaBebes.DisplayLayout.Override.HeaderAppearance = Appearance34
        Appearance35.BackColor = System.Drawing.Color.FromArgb(CType(CType(168, Byte), Integer), CType(CType(167, Byte), Integer), CType(CType(191, Byte), Integer))
        Appearance35.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(112, Byte), Integer), CType(CType(111, Byte), Integer), CType(CType(145, Byte), Integer))
        Appearance35.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Me.ug_SalaBebes.DisplayLayout.Override.RowSelectorAppearance = Appearance35
        Appearance36.BackColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(148, Byte), Integer))
        Appearance36.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(149, Byte), Integer), CType(CType(21, Byte), Integer))
        Appearance36.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Me.ug_SalaBebes.DisplayLayout.Override.SelectedRowAppearance = Appearance36
        Me.ug_SalaBebes.DisplayLayout.Override.SelectTypeRow = Infragistics.Win.UltraWinGrid.SelectType.[Single]
        Me.ug_SalaBebes.Location = New System.Drawing.Point(0, 42)
        Me.ug_SalaBebes.Name = "ug_SalaBebes"
        Me.ug_SalaBebes.Size = New System.Drawing.Size(758, 383)
        Me.ug_SalaBebes.TabIndex = 2
        '
        'uds_SalaBebes
        '
        Me.uds_SalaBebes.AllowDelete = False
        UltraDataColumn1.DataType = GetType(System.Drawing.Bitmap)
        UltraDataColumn2.DataType = GetType(Integer)
        UltraDataColumn5.DataType = GetType(Integer)
        UltraDataColumn6.DataType = GetType(Integer)
        Me.uds_SalaBebes.Band.Columns.AddRange(New Object() {UltraDataColumn1, UltraDataColumn2, UltraDataColumn3, UltraDataColumn4, UltraDataColumn5, UltraDataColumn6})
        '
        'UltraTabPageControl2
        '
        Me.UltraTabPageControl2.Controls.Add(Me.ugb_datos)
        Me.UltraTabPageControl2.Location = New System.Drawing.Point(1, 23)
        Me.UltraTabPageControl2.Name = "UltraTabPageControl2"
        Me.UltraTabPageControl2.Size = New System.Drawing.Size(761, 428)
        '
        'ugb_datos
        '
        Me.ugb_datos.Controls.Add(Me.ugb_DatosDet)
        Me.ugb_datos.Controls.Add(Me.Panel2)
        Me.ugb_datos.Controls.Add(Me.txt_idRegistro)
        Me.ugb_datos.Controls.Add(Me.txt_idcuna)
        Me.ugb_datos.Controls.Add(Me.txt_PACIENTE)
        Me.ugb_datos.Controls.Add(Me.txt_num_historia)
        Me.ugb_datos.Controls.Add(Me.txt_idCuenta)
        Me.ugb_datos.Controls.Add(Me.UltraLabel13)
        Me.ugb_datos.Controls.Add(Me.UltraLabel1)
        Me.ugb_datos.Controls.Add(Me.UltraLabel3)
        Me.ugb_datos.Location = New System.Drawing.Point(3, 3)
        Me.ugb_datos.Name = "ugb_datos"
        Me.ugb_datos.Size = New System.Drawing.Size(755, 418)
        Me.ugb_datos.TabIndex = 0
        '
        'ugb_DatosDet
        '
        Me.ugb_DatosDet.Controls.Add(Me.ucb_GrupoS)
        Me.ugb_DatosDet.Controls.Add(Me.UltraLabel11)
        Me.ugb_DatosDet.Controls.Add(Me.txt_bebe)
        Me.ugb_DatosDet.Controls.Add(Me.UltraLabel2)
        Me.ugb_DatosDet.Controls.Add(Me.dtp_FechaIngreso)
        Me.ugb_DatosDet.Controls.Add(Me.UltraLabel7)
        Me.ugb_DatosDet.Controls.Add(Me.UltraLabel10)
        Me.ugb_DatosDet.Controls.Add(Me.UltraLabel8)
        Me.ugb_DatosDet.Controls.Add(Me.udtp_fechaAlta)
        Me.ugb_DatosDet.Controls.Add(Me.txt_diag)
        Me.ugb_DatosDet.Controls.Add(Me.UltraLabel9)
        Me.ugb_DatosDet.Controls.Add(Me.txt_obs)
        Me.ugb_DatosDet.Controls.Add(Me.txt_Peso)
        Me.ugb_DatosDet.Controls.Add(Me.UltraLabel16)
        Me.ugb_DatosDet.Controls.Add(Me.UltraLabel6)
        Me.ugb_DatosDet.Controls.Add(Me.txt_madre)
        Me.ugb_DatosDet.Controls.Add(Me.UltraLabel5)
        Me.ugb_DatosDet.Controls.Add(Me.UltraLabel4)
        Me.ugb_DatosDet.Controls.Add(Me.uce_Medico)
        Me.ugb_DatosDet.Controls.Add(Me.txt_Talla)
        Me.ugb_DatosDet.Location = New System.Drawing.Point(13, 145)
        Me.ugb_DatosDet.Name = "ugb_DatosDet"
        Me.ugb_DatosDet.Size = New System.Drawing.Size(736, 247)
        Me.ugb_DatosDet.TabIndex = 226
        '
        'ucb_GrupoS
        '
        Me.ucb_GrupoS.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.ucb_GrupoS.Location = New System.Drawing.Point(128, 204)
        Me.ucb_GrupoS.Name = "ucb_GrupoS"
        Me.ucb_GrupoS.Size = New System.Drawing.Size(292, 21)
        Me.ucb_GrupoS.TabIndex = 38
        '
        'UltraLabel11
        '
        Appearance23.BackColor = System.Drawing.Color.Transparent
        Appearance23.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel11.Appearance = Appearance23
        Me.UltraLabel11.AutoSize = True
        Me.UltraLabel11.Location = New System.Drawing.Point(17, 208)
        Me.UltraLabel11.Name = "UltraLabel11"
        Me.UltraLabel11.Size = New System.Drawing.Size(93, 14)
        Me.UltraLabel11.TabIndex = 226
        Me.UltraLabel11.Text = "Grupo Sanguineo"
        '
        'txt_bebe
        '
        Me.txt_bebe.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_bebe.Location = New System.Drawing.Point(128, 29)
        Me.txt_bebe.MaxLength = 100
        Me.txt_bebe.Name = "txt_bebe"
        Me.txt_bebe.Size = New System.Drawing.Size(322, 21)
        Me.txt_bebe.TabIndex = 3
        '
        'UltraLabel2
        '
        Appearance15.BackColor = System.Drawing.Color.Transparent
        Appearance15.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel2.Appearance = Appearance15
        Me.UltraLabel2.AutoSize = True
        Me.UltraLabel2.Location = New System.Drawing.Point(17, 33)
        Me.UltraLabel2.Name = "UltraLabel2"
        Me.UltraLabel2.Size = New System.Drawing.Size(92, 14)
        Me.UltraLabel2.TabIndex = 44
        Me.UltraLabel2.Text = "Nombre del Bebe"
        '
        'dtp_FechaIngreso
        '
        Me.dtp_FechaIngreso.CustomFormat = "dd/MM/yyyy hh:mm tt"
        Me.dtp_FechaIngreso.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtp_FechaIngreso.Location = New System.Drawing.Point(544, 30)
        Me.dtp_FechaIngreso.Name = "dtp_FechaIngreso"
        Me.dtp_FechaIngreso.Size = New System.Drawing.Size(153, 20)
        Me.dtp_FechaIngreso.TabIndex = 5
        '
        'UltraLabel7
        '
        Appearance16.BackColor = System.Drawing.Color.Transparent
        Appearance16.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel7.Appearance = Appearance16
        Me.UltraLabel7.AutoSize = True
        Me.UltraLabel7.Location = New System.Drawing.Point(17, 140)
        Me.UltraLabel7.Name = "UltraLabel7"
        Me.UltraLabel7.Size = New System.Drawing.Size(63, 14)
        Me.UltraLabel7.TabIndex = 44
        Me.UltraLabel7.Text = "Diagnostico"
        '
        'UltraLabel10
        '
        Appearance17.BackColor = System.Drawing.Color.Transparent
        Appearance17.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel10.Appearance = Appearance17
        Me.UltraLabel10.AutoSize = True
        Me.UltraLabel10.Location = New System.Drawing.Point(466, 70)
        Me.UltraLabel10.Name = "UltraLabel10"
        Me.UltraLabel10.Size = New System.Drawing.Size(58, 14)
        Me.UltraLabel10.TabIndex = 224
        Me.UltraLabel10.Text = "Fecha Alta"
        '
        'UltraLabel8
        '
        Appearance18.BackColor = System.Drawing.Color.Transparent
        Appearance18.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel8.Appearance = Appearance18
        Me.UltraLabel8.AutoSize = True
        Me.UltraLabel8.Location = New System.Drawing.Point(17, 173)
        Me.UltraLabel8.Name = "UltraLabel8"
        Me.UltraLabel8.Size = New System.Drawing.Size(68, 14)
        Me.UltraLabel8.TabIndex = 44
        Me.UltraLabel8.Text = "Observacion"
        '
        'udtp_fechaAlta
        '
        Me.udtp_fechaAlta.DateTime = New Date(2014, 1, 28, 0, 0, 0, 0)
        Me.udtp_fechaAlta.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.udtp_fechaAlta.Location = New System.Drawing.Point(544, 64)
        Me.udtp_fechaAlta.Name = "udtp_fechaAlta"
        Me.udtp_fechaAlta.ReadOnly = True
        Me.udtp_fechaAlta.Size = New System.Drawing.Size(153, 24)
        Me.udtp_fechaAlta.TabIndex = 6
        Me.udtp_fechaAlta.Value = New Date(2014, 1, 28, 0, 0, 0, 0)
        '
        'txt_diag
        '
        Me.txt_diag.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_diag.Location = New System.Drawing.Point(87, 136)
        Me.txt_diag.MaxLength = 100
        Me.txt_diag.Name = "txt_diag"
        Me.txt_diag.Size = New System.Drawing.Size(610, 21)
        Me.txt_diag.TabIndex = 10
        '
        'UltraLabel9
        '
        Appearance19.BackColor = System.Drawing.Color.Transparent
        Appearance19.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel9.Appearance = Appearance19
        Me.UltraLabel9.AutoSize = True
        Me.UltraLabel9.Location = New System.Drawing.Point(466, 32)
        Me.UltraLabel9.Name = "UltraLabel9"
        Me.UltraLabel9.Size = New System.Drawing.Size(76, 14)
        Me.UltraLabel9.TabIndex = 222
        Me.UltraLabel9.Text = "Fecha Ingreso"
        '
        'txt_obs
        '
        Me.txt_obs.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_obs.Location = New System.Drawing.Point(87, 170)
        Me.txt_obs.MaxLength = 100
        Me.txt_obs.Name = "txt_obs"
        Me.txt_obs.Size = New System.Drawing.Size(610, 21)
        Me.txt_obs.TabIndex = 11
        '
        'txt_Peso
        '
        Me.txt_Peso.Location = New System.Drawing.Point(633, 101)
        Me.txt_Peso.MaxLength = 100
        Me.txt_Peso.Name = "txt_Peso"
        Me.txt_Peso.Size = New System.Drawing.Size(64, 21)
        Me.txt_Peso.TabIndex = 9
        '
        'UltraLabel16
        '
        Appearance20.BackColor = System.Drawing.Color.Transparent
        Appearance20.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel16.Appearance = Appearance20
        Me.UltraLabel16.AutoSize = True
        Me.UltraLabel16.Location = New System.Drawing.Point(17, 69)
        Me.UltraLabel16.Name = "UltraLabel16"
        Me.UltraLabel16.Size = New System.Drawing.Size(107, 14)
        Me.UltraLabel16.TabIndex = 49
        Me.UltraLabel16.Text = "Nombre de la Madre"
        '
        'UltraLabel6
        '
        Appearance21.BackColor = System.Drawing.Color.Transparent
        Appearance21.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel6.Appearance = Appearance21
        Me.UltraLabel6.AutoSize = True
        Me.UltraLabel6.Location = New System.Drawing.Point(595, 105)
        Me.UltraLabel6.Name = "UltraLabel6"
        Me.UltraLabel6.Size = New System.Drawing.Size(33, 14)
        Me.UltraLabel6.TabIndex = 219
        Me.UltraLabel6.Text = "Peso:"
        '
        'txt_madre
        '
        Me.txt_madre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_madre.Location = New System.Drawing.Point(128, 65)
        Me.txt_madre.MaxLength = 100
        Me.txt_madre.Name = "txt_madre"
        Me.txt_madre.Size = New System.Drawing.Size(322, 21)
        Me.txt_madre.TabIndex = 4
        '
        'UltraLabel5
        '
        Appearance3.BackColor = System.Drawing.Color.Transparent
        Appearance3.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel5.Appearance = Appearance3
        Me.UltraLabel5.AutoSize = True
        Me.UltraLabel5.Location = New System.Drawing.Point(17, 105)
        Me.UltraLabel5.Name = "UltraLabel5"
        Me.UltraLabel5.Size = New System.Drawing.Size(41, 14)
        Me.UltraLabel5.TabIndex = 218
        Me.UltraLabel5.Text = "Medico"
        '
        'UltraLabel4
        '
        Appearance24.BackColor = System.Drawing.Color.Transparent
        Appearance24.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel4.Appearance = Appearance24
        Me.UltraLabel4.AutoSize = True
        Me.UltraLabel4.Location = New System.Drawing.Point(467, 105)
        Me.UltraLabel4.Name = "UltraLabel4"
        Me.UltraLabel4.Size = New System.Drawing.Size(32, 14)
        Me.UltraLabel4.TabIndex = 52
        Me.UltraLabel4.Text = "Talla:"
        '
        'uce_Medico
        '
        Me.uce_Medico.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Suggest
        Me.uce_Medico.Location = New System.Drawing.Point(87, 101)
        Me.uce_Medico.Name = "uce_Medico"
        Me.uce_Medico.Size = New System.Drawing.Size(333, 21)
        Me.uce_Medico.TabIndex = 7
        '
        'txt_Talla
        '
        Me.txt_Talla.Location = New System.Drawing.Point(508, 101)
        Me.txt_Talla.MaxLength = 100
        Me.txt_Talla.Name = "txt_Talla"
        Me.txt_Talla.Size = New System.Drawing.Size(64, 21)
        Me.txt_Talla.TabIndex = 8
        '
        'Panel2
        '
        Me.Panel2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel2.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.Panel2.Location = New System.Drawing.Point(28, 117)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(700, 2)
        Me.Panel2.TabIndex = 225
        '
        'txt_idRegistro
        '
        Me.txt_idRegistro.Location = New System.Drawing.Point(680, 32)
        Me.txt_idRegistro.MaxLength = 100
        Me.txt_idRegistro.Name = "txt_idRegistro"
        Me.txt_idRegistro.ReadOnly = True
        Me.txt_idRegistro.Size = New System.Drawing.Size(32, 21)
        Me.txt_idRegistro.TabIndex = 51
        Me.txt_idRegistro.Visible = False
        '
        'txt_idcuna
        '
        Me.txt_idcuna.Location = New System.Drawing.Point(629, 32)
        Me.txt_idcuna.MaxLength = 100
        Me.txt_idcuna.Name = "txt_idcuna"
        Me.txt_idcuna.ReadOnly = True
        Me.txt_idcuna.Size = New System.Drawing.Size(32, 21)
        Me.txt_idcuna.TabIndex = 48
        Me.txt_idcuna.Visible = False
        '
        'txt_PACIENTE
        '
        Me.txt_PACIENTE.Location = New System.Drawing.Point(296, 66)
        Me.txt_PACIENTE.MaxLength = 100
        Me.txt_PACIENTE.Name = "txt_PACIENTE"
        Me.txt_PACIENTE.ReadOnly = True
        Me.txt_PACIENTE.Size = New System.Drawing.Size(372, 21)
        Me.txt_PACIENTE.TabIndex = 2
        '
        'txt_num_historia
        '
        Me.txt_num_historia.Location = New System.Drawing.Point(107, 66)
        Me.txt_num_historia.MaxLength = 100
        Me.txt_num_historia.Name = "txt_num_historia"
        Me.txt_num_historia.ReadOnly = True
        Me.txt_num_historia.Size = New System.Drawing.Size(127, 21)
        Me.txt_num_historia.TabIndex = 1
        '
        'txt_idCuenta
        '
        Appearance25.ImageHAlign = Infragistics.Win.HAlign.Center
        Appearance25.ImageVAlign = Infragistics.Win.VAlign.Middle
        EditorButton1.Appearance = Appearance25
        EditorButton1.Key = "ayuda"
        Me.txt_idCuenta.ButtonsRight.Add(EditorButton1)
        Me.txt_idCuenta.Location = New System.Drawing.Point(107, 32)
        Me.txt_idCuenta.MaxLength = 11
        Me.txt_idCuenta.Name = "txt_idCuenta"
        Me.txt_idCuenta.Size = New System.Drawing.Size(127, 21)
        Me.txt_idCuenta.TabIndex = 0
        '
        'UltraLabel13
        '
        Appearance26.BackColor = System.Drawing.Color.Transparent
        Appearance26.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel13.Appearance = Appearance26
        Me.UltraLabel13.AutoSize = True
        Me.UltraLabel13.Location = New System.Drawing.Point(248, 70)
        Me.UltraLabel13.Name = "UltraLabel13"
        Me.UltraLabel13.Size = New System.Drawing.Size(44, 14)
        Me.UltraLabel13.TabIndex = 44
        Me.UltraLabel13.Text = "Nombre"
        '
        'UltraLabel1
        '
        Appearance27.BackColor = System.Drawing.Color.Transparent
        Appearance27.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel1.Appearance = Appearance27
        Me.UltraLabel1.AutoSize = True
        Me.UltraLabel1.Location = New System.Drawing.Point(37, 70)
        Me.UltraLabel1.Name = "UltraLabel1"
        Me.UltraLabel1.Size = New System.Drawing.Size(58, 14)
        Me.UltraLabel1.TabIndex = 44
        Me.UltraLabel1.Text = "Nº Historia"
        '
        'UltraLabel3
        '
        Appearance28.BackColor = System.Drawing.Color.Transparent
        Appearance28.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel3.Appearance = Appearance28
        Me.UltraLabel3.AutoSize = True
        Me.UltraLabel3.Location = New System.Drawing.Point(37, 36)
        Me.UltraLabel3.Name = "UltraLabel3"
        Me.UltraLabel3.Size = New System.Drawing.Size(56, 14)
        Me.UltraLabel3.TabIndex = 44
        Me.UltraLabel3.Text = "Nº Cuenta"
        '
        'UltraLabel15
        '
        Me.UltraLabel15.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Appearance1.BackColor = System.Drawing.Color.DeepSkyBlue
        Appearance1.ForeColor = System.Drawing.Color.White
        Appearance1.TextHAlignAsString = "Center"
        Me.UltraLabel15.Appearance = Appearance1
        Me.UltraLabel15.BorderStyleOuter = Infragistics.Win.UIElementBorderStyle.Solid
        Me.UltraLabel15.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel15.Location = New System.Drawing.Point(1, 31)
        Me.UltraLabel15.Name = "UltraLabel15"
        Me.UltraLabel15.Size = New System.Drawing.Size(765, 28)
        Me.UltraLabel15.TabIndex = 37
        Me.UltraLabel15.Text = "Sala de Bebes"
        '
        'ToolS_Mantenimiento
        '
        Me.ToolS_Mantenimiento.BackColor = System.Drawing.Color.White
        Me.ToolS_Mantenimiento.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripSeparator1, Me.Tool_Grabar, Me.ToolStripSeparator3, Me.ToolStripSeparator4, Me.Tool_Cancelar, Me.ToolStripSeparator2, Me.Tool_daralta, Me.ToolStripSeparator5, Me.Tool_CambCuenta, Me.ToolStripSeparator6, Me.Tool_Salir})
        Me.ToolS_Mantenimiento.Location = New System.Drawing.Point(0, 0)
        Me.ToolS_Mantenimiento.Name = "ToolS_Mantenimiento"
        Me.ToolS_Mantenimiento.Size = New System.Drawing.Size(766, 25)
        Me.ToolS_Mantenimiento.TabIndex = 36
        Me.ToolS_Mantenimiento.Text = "ToolStrip1"
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
        Me.Tool_Grabar.Size = New System.Drawing.Size(62, 22)
        Me.Tool_Grabar.Text = "Grabar"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 25)
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
        'Tool_daralta
        '
        Me.Tool_daralta.Image = Global.Contabilidad.My.Resources.Resources._16__Full_screen_
        Me.Tool_daralta.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Tool_daralta.Name = "Tool_daralta"
        Me.Tool_daralta.Size = New System.Drawing.Size(69, 22)
        Me.Tool_daralta.Text = "Dar Alta"
        '
        'ToolStripSeparator5
        '
        Me.ToolStripSeparator5.Name = "ToolStripSeparator5"
        Me.ToolStripSeparator5.Size = New System.Drawing.Size(6, 25)
        '
        'Tool_CambCuenta
        '
        Me.Tool_CambCuenta.Image = Global.Contabilidad.My.Resources.Resources._16__Copy_
        Me.Tool_CambCuenta.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Tool_CambCuenta.Name = "Tool_CambCuenta"
        Me.Tool_CambCuenta.Size = New System.Drawing.Size(102, 22)
        Me.Tool_CambCuenta.Text = "Nueva Cuenta"
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
        Me.Tool_Salir.Size = New System.Drawing.Size(49, 22)
        Me.Tool_Salir.Text = "Salir"
        '
        'utc_hospi
        '
        Me.utc_hospi.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.utc_hospi.Controls.Add(Me.UltraTabSharedControlsPage1)
        Me.utc_hospi.Controls.Add(Me.UltraTabPageControl1)
        Me.utc_hospi.Controls.Add(Me.UltraTabPageControl2)
        Me.utc_hospi.Location = New System.Drawing.Point(1, 60)
        Me.utc_hospi.Name = "utc_hospi"
        Me.utc_hospi.SharedControlsPage = Me.UltraTabSharedControlsPage1
        Me.utc_hospi.Size = New System.Drawing.Size(765, 454)
        Me.utc_hospi.TabIndex = 35
        UltraTab1.TabPage = Me.UltraTabPageControl1
        UltraTab1.Text = "Lista"
        UltraTab2.TabPage = Me.UltraTabPageControl2
        UltraTab2.Text = "Ingreso / Edicion de Registro del bebe"
        Me.utc_hospi.Tabs.AddRange(New Infragistics.Win.UltraWinTabControl.UltraTab() {UltraTab1, UltraTab2})
        '
        'UltraTabSharedControlsPage1
        '
        Me.UltraTabSharedControlsPage1.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabSharedControlsPage1.Name = "UltraTabSharedControlsPage1"
        Me.UltraTabSharedControlsPage1.Size = New System.Drawing.Size(761, 428)
        '
        'BB_LT_REGISTRO_BEBE
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(766, 517)
        Me.Controls.Add(Me.UltraLabel15)
        Me.Controls.Add(Me.ToolS_Mantenimiento)
        Me.Controls.Add(Me.utc_hospi)
        Me.Name = "BB_LT_REGISTRO_BEBE"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "SALA DE BEBES"
        Me.UltraTabPageControl1.ResumeLayout(False)
        CType(Me.ug_SalaBebes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.uds_SalaBebes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabPageControl2.ResumeLayout(False)
        CType(Me.ugb_datos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ugb_datos.ResumeLayout(False)
        Me.ugb_datos.PerformLayout()
        CType(Me.ugb_DatosDet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ugb_DatosDet.ResumeLayout(False)
        Me.ugb_DatosDet.PerformLayout()
        CType(Me.ucb_GrupoS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_bebe, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.udtp_fechaAlta, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_diag, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_obs, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_Peso, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_madre, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.uce_Medico, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_Talla, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_idRegistro, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_idcuna, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_PACIENTE, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_num_historia, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_idCuenta, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolS_Mantenimiento.ResumeLayout(False)
        Me.ToolS_Mantenimiento.PerformLayout()
        CType(Me.utc_hospi, System.ComponentModel.ISupportInitialize).EndInit()
        Me.utc_hospi.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents uds_SalaBebes As Infragistics.Win.UltraWinDataSource.UltraDataSource
    Friend WithEvents ug_SalaBebes As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents UltraLabel15 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents ToolS_Mantenimiento As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents Tool_Grabar As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents Tool_Cancelar As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents Tool_daralta As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator5 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents Tool_Salir As System.Windows.Forms.ToolStripButton
    Friend WithEvents utc_hospi As Infragistics.Win.UltraWinTabControl.UltraTabControl
    Friend WithEvents UltraTabSharedControlsPage1 As Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage
    Friend WithEvents UltraTabPageControl1 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents UltraTabPageControl2 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents ugb_datos As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents txt_idcuna As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents txt_obs As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents txt_diag As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents txt_bebe As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents txt_PACIENTE As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents txt_num_historia As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents txt_idCuenta As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents UltraLabel8 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel7 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel13 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel2 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel1 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel3 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents ubtn_Logistica As Infragistics.Win.Misc.UltraButton
    Friend WithEvents ubtn_Facturacion As Infragistics.Win.Misc.UltraButton
    Friend WithEvents ubtn_Farmacia As Infragistics.Win.Misc.UltraButton
    Friend WithEvents ubtn_Ubicacion As Infragistics.Win.Misc.UltraButton
    Friend WithEvents txt_idRegistro As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents txt_madre As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents UltraLabel16 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents txt_Talla As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents UltraLabel4 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents txt_Peso As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents UltraLabel6 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel5 As Infragistics.Win.Misc.UltraLabel
    Public WithEvents uce_Medico As Infragistics.Win.UltraWinEditors.UltraComboEditor
    Friend WithEvents UltraLabel10 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents udtp_fechaAlta As Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
    Friend WithEvents UltraLabel9 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents dtp_FechaIngreso As System.Windows.Forms.DateTimePicker
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents ugb_DatosDet As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents Tool_CambCuenta As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator6 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents UltraLabel11 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents ucb_GrupoS As Infragistics.Win.UltraWinEditors.UltraComboEditor
End Class
