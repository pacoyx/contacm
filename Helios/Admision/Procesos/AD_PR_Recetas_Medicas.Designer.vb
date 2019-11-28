<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AD_PR_Recetas_Medicas
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
        Dim Appearance35 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance38 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance4 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance17 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance16 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance23 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance5 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance24 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance25 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance30 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance2 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance31 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance32 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance33 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance34 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance1 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance36 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance37 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance22 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance19 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance20 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance26 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridBand1 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1)
        Dim UltraGridColumn1 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CC_ID", -1, Nothing, 0, Infragistics.Win.UltraWinGrid.SortIndicator.Ascending, False)
        Dim UltraGridColumn2 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CC_DESCRIPCION")
        Dim UltraGridColumn3 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CC_IDEMPRESA")
        Dim Appearance27 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridBand2 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1)
        Dim UltraGridColumn4 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("DR_IDMEDICAMENTO")
        Dim UltraGridColumn5 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Medicamentos")
        Dim UltraGridColumn6 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Composición Generica")
        Dim UltraGridColumn7 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Presentación")
        Dim UltraGridColumn8 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Observación", -1, Nothing, 0, Infragistics.Win.UltraWinGrid.SortIndicator.Ascending, False)
        Dim UltraGridColumn9 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("DR_CANT_TOMA")
        Dim UltraGridColumn10 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IDCAT")
        Dim UltraGridColumn11 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("obs2")
        Dim UltraDataColumn1 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("DR_IDMEDICAMENTO")
        Dim UltraDataColumn2 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Medicamentos")
        Dim UltraDataColumn3 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Composición Generica")
        Dim UltraDataColumn4 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Presentación")
        Dim UltraDataColumn5 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Observación")
        Dim UltraDataColumn6 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("DR_CANT_TOMA")
        Dim UltraDataColumn7 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IDCAT")
        Dim UltraDataColumn8 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("obs2")
        Dim Appearance29 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridBand3 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1)
        Dim UltraGridColumn12 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CC_ID")
        Dim UltraGridColumn13 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CC_DESCRIPCION", -1, Nothing, 0, Infragistics.Win.UltraWinGrid.SortIndicator.Ascending, False)
        Dim UltraGridColumn14 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CC_IDEMPRESA")
        Dim Appearance28 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridBand4 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1)
        Dim UltraGridColumn15 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("1")
        Dim Appearance3 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn16 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("2")
        Dim UltraGridColumn17 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("3")
        Dim UltraGridColumn18 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("4")
        Dim Appearance18 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraDataColumn9 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("1")
        Dim UltraDataColumn10 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("2")
        Dim UltraDataColumn11 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("3")
        Dim UltraDataColumn12 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("4")
        Dim UltraGridBand5 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1)
        Dim UltraGridColumn19 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("RM_ID")
        Dim UltraGridColumn20 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("RM_FECHA")
        Dim UltraGridColumn21 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CM_HORA_ATENC")
        Dim UltraGridColumn22 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Medico")
        Dim Appearance6 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraDataColumn13 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("RM_ID")
        Dim UltraDataColumn14 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("RM_FECHA")
        Dim UltraDataColumn15 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("CM_HORA_ATENC")
        Dim UltraDataColumn16 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Medico")
        Dim UltraTab1 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraTab2 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Me.UltraTabPageControl1 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.ugb_Datos = New Infragistics.Win.Misc.UltraGroupBox()
        Me.UltraLabel8 = New Infragistics.Win.Misc.UltraLabel()
        Me.txt_Observacion = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.utxt_idReceta = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.txt_idCita = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.uce_tip_doc = New Infragistics.Win.UltraWinEditors.UltraComboEditor()
        Me.ubt_Quitar = New Infragistics.Win.Misc.UltraButton()
        Me.txt_idHistoria = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.UltraGroupBox1 = New Infragistics.Win.Misc.UltraGroupBox()
        Me.uc_Intramuscular = New Infragistics.Win.UltraWinEditors.UltraCheckEditor()
        Me.uc_Subcutaneo = New Infragistics.Win.UltraWinEditors.UltraCheckEditor()
        Me.uc_antescomida = New Infragistics.Win.UltraWinEditors.UltraCheckEditor()
        Me.uc_durantecomida = New Infragistics.Win.UltraWinEditors.UltraCheckEditor()
        Me.uc_ayunas = New Infragistics.Win.UltraWinEditors.UltraCheckEditor()
        Me.uc_despuescomida = New Infragistics.Win.UltraWinEditors.UltraCheckEditor()
        Me.UltraLabel14 = New Infragistics.Win.Misc.UltraLabel()
        Me.btn_agregar = New Infragistics.Win.Misc.UltraButton()
        Me.UltraLabel5 = New Infragistics.Win.Misc.UltraLabel()
        Me.txt_ruc_cliente = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.txt_Des_Cliente = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.UltraGroupBox2 = New Infragistics.Win.Misc.UltraGroupBox()
        Me.utxt_Cantidad = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.UltraLabel11 = New Infragistics.Win.Misc.UltraLabel()
        Me.txt_duracion = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.txt_cada = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.txt_tomar = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.txt_segunavolucionclinica = New Infragistics.Win.UltraWinEditors.UltraCheckEditor()
        Me.uc_dias2 = New Infragistics.Win.UltraWinEditors.UltraCheckEditor()
        Me.uc_horas = New Infragistics.Win.UltraWinEditors.UltraCheckEditor()
        Me.txt_dias1 = New Infragistics.Win.UltraWinEditors.UltraCheckEditor()
        Me.lbl_tomar = New Infragistics.Win.Misc.UltraLabel()
        Me.lbl_presentacion = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraLabel10 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraLabel9 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraLabel6 = New Infragistics.Win.Misc.UltraLabel()
        Me.txt_presentacion = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.UltraLabel1 = New Infragistics.Win.Misc.UltraLabel()
        Me.txt_compogene = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.UltraLabel2 = New Infragistics.Win.Misc.UltraLabel()
        Me.ug_medicamentos = New Infragistics.Win.UltraWinGrid.UltraGrid()
        Me.UltraLabel3 = New Infragistics.Win.Misc.UltraLabel()
        Me.ug_receta = New Infragistics.Win.UltraWinGrid.UltraGrid()
        Me.uds_receta = New Infragistics.Win.UltraWinDataSource.UltraDataSource(Me.components)
        Me.UltraLabel7 = New Infragistics.Win.Misc.UltraLabel()
        Me.ug_categoria = New Infragistics.Win.UltraWinGrid.UltraGrid()
        Me.UltraLabel4 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraTabPageControl2 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.ug_ListaDet = New Infragistics.Win.UltraWinGrid.UltraGrid()
        Me.uds_ListaDet = New Infragistics.Win.UltraWinDataSource.UltraDataSource(Me.components)
        Me.ug_Lista = New Infragistics.Win.UltraWinGrid.UltraGrid()
        Me.uds_Lista = New Infragistics.Win.UltraWinDataSource.UltraDataSource(Me.components)
        Me.ToolS_Mantenimiento = New System.Windows.Forms.ToolStrip()
        Me.Tool_Nuevo = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.Tool_Grabar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.Tool_Imprimir = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.Tool_Salir = New System.Windows.Forms.ToolStripButton()
        Me.utc_Datos = New Infragistics.Win.UltraWinTabControl.UltraTabControl()
        Me.UltraTabSharedControlsPage1 = New Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage()
        Me.UltraTabPageControl1.SuspendLayout()
        CType(Me.ugb_Datos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ugb_Datos.SuspendLayout()
        CType(Me.txt_Observacion, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.utxt_idReceta, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_idCita, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.uce_tip_doc, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_idHistoria, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UltraGroupBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraGroupBox1.SuspendLayout()
        CType(Me.txt_ruc_cliente, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_Des_Cliente, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UltraGroupBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraGroupBox2.SuspendLayout()
        CType(Me.utxt_Cantidad, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_duracion, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_cada, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_tomar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_presentacion, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_compogene, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ug_medicamentos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ug_receta, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.uds_receta, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ug_categoria, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabPageControl2.SuspendLayout()
        CType(Me.ug_ListaDet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.uds_ListaDet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ug_Lista, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.uds_Lista, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolS_Mantenimiento.SuspendLayout()
        CType(Me.utc_Datos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.utc_Datos.SuspendLayout()
        Me.SuspendLayout()
        '
        'UltraTabPageControl1
        '
        Me.UltraTabPageControl1.Controls.Add(Me.ugb_Datos)
        Me.UltraTabPageControl1.Location = New System.Drawing.Point(1, 23)
        Me.UltraTabPageControl1.Name = "UltraTabPageControl1"
        Me.UltraTabPageControl1.Size = New System.Drawing.Size(872, 615)
        '
        'ugb_Datos
        '
        Me.ugb_Datos.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ugb_Datos.Controls.Add(Me.UltraLabel8)
        Me.ugb_Datos.Controls.Add(Me.txt_Observacion)
        Me.ugb_Datos.Controls.Add(Me.utxt_idReceta)
        Me.ugb_Datos.Controls.Add(Me.txt_idCita)
        Me.ugb_Datos.Controls.Add(Me.Panel1)
        Me.ugb_Datos.Controls.Add(Me.uce_tip_doc)
        Me.ugb_Datos.Controls.Add(Me.ubt_Quitar)
        Me.ugb_Datos.Controls.Add(Me.txt_idHistoria)
        Me.ugb_Datos.Controls.Add(Me.UltraGroupBox1)
        Me.ugb_Datos.Controls.Add(Me.UltraLabel14)
        Me.ugb_Datos.Controls.Add(Me.btn_agregar)
        Me.ugb_Datos.Controls.Add(Me.UltraLabel5)
        Me.ugb_Datos.Controls.Add(Me.txt_ruc_cliente)
        Me.ugb_Datos.Controls.Add(Me.txt_Des_Cliente)
        Me.ugb_Datos.Controls.Add(Me.UltraGroupBox2)
        Me.ugb_Datos.Controls.Add(Me.UltraLabel6)
        Me.ugb_Datos.Controls.Add(Me.txt_presentacion)
        Me.ugb_Datos.Controls.Add(Me.UltraLabel1)
        Me.ugb_Datos.Controls.Add(Me.txt_compogene)
        Me.ugb_Datos.Controls.Add(Me.UltraLabel2)
        Me.ugb_Datos.Controls.Add(Me.ug_medicamentos)
        Me.ugb_Datos.Controls.Add(Me.UltraLabel3)
        Me.ugb_Datos.Controls.Add(Me.ug_receta)
        Me.ugb_Datos.Controls.Add(Me.UltraLabel7)
        Me.ugb_Datos.Controls.Add(Me.ug_categoria)
        Me.ugb_Datos.Controls.Add(Me.UltraLabel4)
        Me.ugb_Datos.Location = New System.Drawing.Point(0, 1)
        Me.ugb_Datos.Name = "ugb_Datos"
        Me.ugb_Datos.Size = New System.Drawing.Size(871, 611)
        Me.ugb_Datos.TabIndex = 154
        '
        'UltraLabel8
        '
        Appearance35.BackColor = System.Drawing.Color.Transparent
        Appearance35.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel8.Appearance = Appearance35
        Me.UltraLabel8.AutoSize = True
        Me.UltraLabel8.Location = New System.Drawing.Point(400, 335)
        Me.UltraLabel8.Name = "UltraLabel8"
        Me.UltraLabel8.Size = New System.Drawing.Size(68, 14)
        Me.UltraLabel8.TabIndex = 157
        Me.UltraLabel8.Text = "Observación"
        '
        'txt_Observacion
        '
        Me.txt_Observacion.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_Observacion.Location = New System.Drawing.Point(399, 355)
        Me.txt_Observacion.MaxLength = 100
        Me.txt_Observacion.Multiline = True
        Me.txt_Observacion.Name = "txt_Observacion"
        Me.txt_Observacion.Size = New System.Drawing.Size(289, 51)
        Me.txt_Observacion.TabIndex = 156
        '
        'utxt_idReceta
        '
        Me.utxt_idReceta.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.utxt_idReceta.Location = New System.Drawing.Point(25, 3)
        Me.utxt_idReceta.MaxLength = 50
        Me.utxt_idReceta.Name = "utxt_idReceta"
        Me.utxt_idReceta.ReadOnly = True
        Me.utxt_idReceta.Size = New System.Drawing.Size(10, 21)
        Me.utxt_idReceta.TabIndex = 155
        Me.utxt_idReceta.Visible = False
        '
        'txt_idCita
        '
        Me.txt_idCita.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_idCita.Location = New System.Drawing.Point(9, 3)
        Me.txt_idCita.MaxLength = 50
        Me.txt_idCita.Name = "txt_idCita"
        Me.txt_idCita.ReadOnly = True
        Me.txt_idCita.Size = New System.Drawing.Size(10, 21)
        Me.txt_idCita.TabIndex = 154
        Me.txt_idCita.Visible = False
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.Panel1.Location = New System.Drawing.Point(14, 49)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(840, 2)
        Me.Panel1.TabIndex = 153
        '
        'uce_tip_doc
        '
        Me.uce_tip_doc.DropDownListWidth = 300
        Me.uce_tip_doc.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.uce_tip_doc.Location = New System.Drawing.Point(66, 15)
        Me.uce_tip_doc.Name = "uce_tip_doc"
        Me.uce_tip_doc.ReadOnly = True
        Me.uce_tip_doc.Size = New System.Drawing.Size(63, 21)
        Me.uce_tip_doc.TabIndex = 0
        '
        'ubt_Quitar
        '
        Me.ubt_Quitar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ubt_Quitar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ubt_Quitar.Location = New System.Drawing.Point(778, 373)
        Me.ubt_Quitar.Name = "ubt_Quitar"
        Me.ubt_Quitar.Size = New System.Drawing.Size(74, 34)
        Me.ubt_Quitar.TabIndex = 20
        Me.ubt_Quitar.Text = "Quitar"
        '
        'txt_idHistoria
        '
        Me.txt_idHistoria.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_idHistoria.Location = New System.Drawing.Point(729, 15)
        Me.txt_idHistoria.Name = "txt_idHistoria"
        Me.txt_idHistoria.ReadOnly = True
        Me.txt_idHistoria.Size = New System.Drawing.Size(126, 21)
        Me.txt_idHistoria.TabIndex = 3
        '
        'UltraGroupBox1
        '
        Me.UltraGroupBox1.Controls.Add(Me.uc_Intramuscular)
        Me.UltraGroupBox1.Controls.Add(Me.uc_Subcutaneo)
        Me.UltraGroupBox1.Controls.Add(Me.uc_antescomida)
        Me.UltraGroupBox1.Controls.Add(Me.uc_durantecomida)
        Me.UltraGroupBox1.Controls.Add(Me.uc_ayunas)
        Me.UltraGroupBox1.Controls.Add(Me.uc_despuescomida)
        Me.UltraGroupBox1.Location = New System.Drawing.Point(662, 116)
        Me.UltraGroupBox1.Name = "UltraGroupBox1"
        Me.UltraGroupBox1.Size = New System.Drawing.Size(170, 213)
        Me.UltraGroupBox1.TabIndex = 31
        Me.UltraGroupBox1.Text = "Opciones"
        '
        'uc_Intramuscular
        '
        Appearance38.BackColor = System.Drawing.Color.Transparent
        Me.uc_Intramuscular.Appearance = Appearance38
        Me.uc_Intramuscular.BackColor = System.Drawing.Color.Transparent
        Me.uc_Intramuscular.BackColorInternal = System.Drawing.Color.Transparent
        Me.uc_Intramuscular.Location = New System.Drawing.Point(10, 158)
        Me.uc_Intramuscular.Name = "uc_Intramuscular"
        Me.uc_Intramuscular.Size = New System.Drawing.Size(145, 25)
        Me.uc_Intramuscular.TabIndex = 20
        Me.uc_Intramuscular.Text = "Intramuscular"
        '
        'uc_Subcutaneo
        '
        Appearance4.BackColor = System.Drawing.Color.Transparent
        Me.uc_Subcutaneo.Appearance = Appearance4
        Me.uc_Subcutaneo.BackColor = System.Drawing.Color.Transparent
        Me.uc_Subcutaneo.BackColorInternal = System.Drawing.Color.Transparent
        Me.uc_Subcutaneo.Location = New System.Drawing.Point(10, 131)
        Me.uc_Subcutaneo.Name = "uc_Subcutaneo"
        Me.uc_Subcutaneo.Size = New System.Drawing.Size(145, 25)
        Me.uc_Subcutaneo.TabIndex = 19
        Me.uc_Subcutaneo.Text = "Via subcutaneo"
        '
        'uc_antescomida
        '
        Appearance17.BackColor = System.Drawing.Color.Transparent
        Me.uc_antescomida.Appearance = Appearance17
        Me.uc_antescomida.BackColor = System.Drawing.Color.Transparent
        Me.uc_antescomida.BackColorInternal = System.Drawing.Color.Transparent
        Me.uc_antescomida.Location = New System.Drawing.Point(10, 52)
        Me.uc_antescomida.Name = "uc_antescomida"
        Me.uc_antescomida.Size = New System.Drawing.Size(133, 20)
        Me.uc_antescomida.TabIndex = 16
        Me.uc_antescomida.Text = "Antes de la Comida"
        '
        'uc_durantecomida
        '
        Appearance16.BackColor = System.Drawing.Color.Transparent
        Me.uc_durantecomida.Appearance = Appearance16
        Me.uc_durantecomida.BackColor = System.Drawing.Color.Transparent
        Me.uc_durantecomida.BackColorInternal = System.Drawing.Color.Transparent
        Me.uc_durantecomida.Location = New System.Drawing.Point(10, 78)
        Me.uc_durantecomida.Name = "uc_durantecomida"
        Me.uc_durantecomida.Size = New System.Drawing.Size(133, 20)
        Me.uc_durantecomida.TabIndex = 17
        Me.uc_durantecomida.Text = "Durante la Comida"
        '
        'uc_ayunas
        '
        Appearance23.BackColor = System.Drawing.Color.Transparent
        Me.uc_ayunas.Appearance = Appearance23
        Me.uc_ayunas.BackColor = System.Drawing.Color.Transparent
        Me.uc_ayunas.BackColorInternal = System.Drawing.Color.Transparent
        Me.uc_ayunas.Location = New System.Drawing.Point(10, 26)
        Me.uc_ayunas.Name = "uc_ayunas"
        Me.uc_ayunas.Size = New System.Drawing.Size(106, 20)
        Me.uc_ayunas.TabIndex = 15
        Me.uc_ayunas.Text = "En Ayunas"
        '
        'uc_despuescomida
        '
        Appearance5.BackColor = System.Drawing.Color.Transparent
        Me.uc_despuescomida.Appearance = Appearance5
        Me.uc_despuescomida.BackColor = System.Drawing.Color.Transparent
        Me.uc_despuescomida.BackColorInternal = System.Drawing.Color.Transparent
        Me.uc_despuescomida.Location = New System.Drawing.Point(10, 102)
        Me.uc_despuescomida.Name = "uc_despuescomida"
        Me.uc_despuescomida.Size = New System.Drawing.Size(145, 25)
        Me.uc_despuescomida.TabIndex = 18
        Me.uc_despuescomida.Text = "Despues de la Comida"
        '
        'UltraLabel14
        '
        Me.UltraLabel14.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Appearance24.BackColor = System.Drawing.Color.Transparent
        Appearance24.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel14.Appearance = Appearance24
        Me.UltraLabel14.AutoSize = True
        Me.UltraLabel14.Location = New System.Drawing.Point(643, 19)
        Me.UltraLabel14.Name = "UltraLabel14"
        Me.UltraLabel14.Size = New System.Drawing.Size(80, 14)
        Me.UltraLabel14.TabIndex = 151
        Me.UltraLabel14.Text = "Historia Clínica"
        '
        'btn_agregar
        '
        Me.btn_agregar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_agregar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_agregar.Location = New System.Drawing.Point(703, 373)
        Me.btn_agregar.Name = "btn_agregar"
        Me.btn_agregar.Size = New System.Drawing.Size(74, 34)
        Me.btn_agregar.TabIndex = 19
        Me.btn_agregar.Text = "Agregar"
        '
        'UltraLabel5
        '
        Appearance25.BackColor = System.Drawing.Color.Transparent
        Appearance25.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel5.Appearance = Appearance25
        Me.UltraLabel5.AutoSize = True
        Me.UltraLabel5.Location = New System.Drawing.Point(16, 19)
        Me.UltraLabel5.Name = "UltraLabel5"
        Me.UltraLabel5.Size = New System.Drawing.Size(48, 14)
        Me.UltraLabel5.TabIndex = 149
        Me.UltraLabel5.Text = "Paciente"
        '
        'txt_ruc_cliente
        '
        Me.txt_ruc_cliente.Location = New System.Drawing.Point(129, 15)
        Me.txt_ruc_cliente.MaxLength = 11
        Me.txt_ruc_cliente.Name = "txt_ruc_cliente"
        Me.txt_ruc_cliente.ReadOnly = True
        Me.txt_ruc_cliente.Size = New System.Drawing.Size(102, 21)
        Me.txt_ruc_cliente.TabIndex = 1
        '
        'txt_Des_Cliente
        '
        Me.txt_Des_Cliente.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_Des_Cliente.Location = New System.Drawing.Point(232, 15)
        Me.txt_Des_Cliente.Name = "txt_Des_Cliente"
        Me.txt_Des_Cliente.Size = New System.Drawing.Size(405, 21)
        Me.txt_Des_Cliente.TabIndex = 2
        '
        'UltraGroupBox2
        '
        Appearance30.ForeColor = System.Drawing.Color.Navy
        Me.UltraGroupBox2.Appearance = Appearance30
        Me.UltraGroupBox2.Controls.Add(Me.utxt_Cantidad)
        Me.UltraGroupBox2.Controls.Add(Me.UltraLabel11)
        Me.UltraGroupBox2.Controls.Add(Me.txt_duracion)
        Me.UltraGroupBox2.Controls.Add(Me.txt_cada)
        Me.UltraGroupBox2.Controls.Add(Me.txt_tomar)
        Me.UltraGroupBox2.Controls.Add(Me.txt_segunavolucionclinica)
        Me.UltraGroupBox2.Controls.Add(Me.uc_dias2)
        Me.UltraGroupBox2.Controls.Add(Me.uc_horas)
        Me.UltraGroupBox2.Controls.Add(Me.txt_dias1)
        Me.UltraGroupBox2.Controls.Add(Me.lbl_tomar)
        Me.UltraGroupBox2.Controls.Add(Me.lbl_presentacion)
        Me.UltraGroupBox2.Controls.Add(Me.UltraLabel10)
        Me.UltraGroupBox2.Controls.Add(Me.UltraLabel9)
        Me.UltraGroupBox2.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraGroupBox2.Location = New System.Drawing.Point(397, 116)
        Me.UltraGroupBox2.Name = "UltraGroupBox2"
        Me.UltraGroupBox2.Size = New System.Drawing.Size(259, 213)
        Me.UltraGroupBox2.TabIndex = 29
        Me.UltraGroupBox2.Text = "Dosis y Periodo"
        '
        'utxt_Cantidad
        '
        Me.utxt_Cantidad.Location = New System.Drawing.Point(80, 24)
        Me.utxt_Cantidad.MaxLength = 10
        Me.utxt_Cantidad.Name = "utxt_Cantidad"
        Me.utxt_Cantidad.Size = New System.Drawing.Size(31, 22)
        Me.utxt_Cantidad.TabIndex = 27
        '
        'UltraLabel11
        '
        Appearance2.BackColor = System.Drawing.Color.Transparent
        Appearance2.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel11.Appearance = Appearance2
        Me.UltraLabel11.AutoSize = True
        Me.UltraLabel11.Location = New System.Drawing.Point(10, 28)
        Me.UltraLabel11.Name = "UltraLabel11"
        Me.UltraLabel11.Size = New System.Drawing.Size(34, 15)
        Me.UltraLabel11.TabIndex = 28
        Me.UltraLabel11.Text = "Cant."
        '
        'txt_duracion
        '
        Me.txt_duracion.Location = New System.Drawing.Point(80, 147)
        Me.txt_duracion.MaxLength = 10
        Me.txt_duracion.Name = "txt_duracion"
        Me.txt_duracion.Size = New System.Drawing.Size(31, 22)
        Me.txt_duracion.TabIndex = 10
        '
        'txt_cada
        '
        Me.txt_cada.Location = New System.Drawing.Point(80, 89)
        Me.txt_cada.MaxLength = 10
        Me.txt_cada.Name = "txt_cada"
        Me.txt_cada.Size = New System.Drawing.Size(31, 22)
        Me.txt_cada.TabIndex = 9
        '
        'txt_tomar
        '
        Me.txt_tomar.Location = New System.Drawing.Point(80, 55)
        Me.txt_tomar.MaxLength = 10
        Me.txt_tomar.Name = "txt_tomar"
        Me.txt_tomar.Size = New System.Drawing.Size(31, 22)
        Me.txt_tomar.TabIndex = 8
        '
        'txt_segunavolucionclinica
        '
        Appearance31.BackColor = System.Drawing.Color.Transparent
        Me.txt_segunavolucionclinica.Appearance = Appearance31
        Me.txt_segunavolucionclinica.BackColor = System.Drawing.Color.Transparent
        Me.txt_segunavolucionclinica.BackColorInternal = System.Drawing.Color.Transparent
        Me.txt_segunavolucionclinica.Location = New System.Drawing.Point(115, 170)
        Me.txt_segunavolucionclinica.Name = "txt_segunavolucionclinica"
        Me.txt_segunavolucionclinica.Size = New System.Drawing.Size(133, 26)
        Me.txt_segunavolucionclinica.TabIndex = 14
        Me.txt_segunavolucionclinica.Text = "Segun Evolucion Clínica "
        '
        'uc_dias2
        '
        Appearance32.BackColor = System.Drawing.Color.Transparent
        Me.uc_dias2.Appearance = Appearance32
        Me.uc_dias2.BackColor = System.Drawing.Color.Transparent
        Me.uc_dias2.BackColorInternal = System.Drawing.Color.Transparent
        Me.uc_dias2.Checked = True
        Me.uc_dias2.CheckState = System.Windows.Forms.CheckState.Checked
        Me.uc_dias2.Location = New System.Drawing.Point(115, 147)
        Me.uc_dias2.Name = "uc_dias2"
        Me.uc_dias2.Size = New System.Drawing.Size(49, 20)
        Me.uc_dias2.TabIndex = 13
        Me.uc_dias2.Text = "Dias"
        '
        'uc_horas
        '
        Appearance33.BackColor = System.Drawing.Color.Transparent
        Me.uc_horas.Appearance = Appearance33
        Me.uc_horas.BackColor = System.Drawing.Color.Transparent
        Me.uc_horas.BackColorInternal = System.Drawing.Color.Transparent
        Me.uc_horas.Checked = True
        Me.uc_horas.CheckState = System.Windows.Forms.CheckState.Checked
        Me.uc_horas.Location = New System.Drawing.Point(115, 88)
        Me.uc_horas.Name = "uc_horas"
        Me.uc_horas.Size = New System.Drawing.Size(61, 20)
        Me.uc_horas.TabIndex = 11
        Me.uc_horas.Text = "Horas"
        '
        'txt_dias1
        '
        Appearance34.BackColor = System.Drawing.Color.Transparent
        Me.txt_dias1.Appearance = Appearance34
        Me.txt_dias1.BackColor = System.Drawing.Color.Transparent
        Me.txt_dias1.BackColorInternal = System.Drawing.Color.Transparent
        Me.txt_dias1.Location = New System.Drawing.Point(115, 114)
        Me.txt_dias1.Name = "txt_dias1"
        Me.txt_dias1.Size = New System.Drawing.Size(61, 20)
        Me.txt_dias1.TabIndex = 12
        Me.txt_dias1.Text = "Dias"
        '
        'lbl_tomar
        '
        Appearance1.BackColor = System.Drawing.Color.Transparent
        Appearance1.ForeColor = System.Drawing.Color.Navy
        Me.lbl_tomar.Appearance = Appearance1
        Me.lbl_tomar.AutoSize = True
        Me.lbl_tomar.Location = New System.Drawing.Point(10, 61)
        Me.lbl_tomar.Name = "lbl_tomar"
        Me.lbl_tomar.Size = New System.Drawing.Size(40, 15)
        Me.lbl_tomar.TabIndex = 26
        Me.lbl_tomar.Text = "Tomar"
        '
        'lbl_presentacion
        '
        Appearance36.BackColor = System.Drawing.Color.Transparent
        Appearance36.ForeColor = System.Drawing.Color.Navy
        Me.lbl_presentacion.Appearance = Appearance36
        Me.lbl_presentacion.AutoSize = True
        Me.lbl_presentacion.Location = New System.Drawing.Point(117, 61)
        Me.lbl_presentacion.Name = "lbl_presentacion"
        Me.lbl_presentacion.Size = New System.Drawing.Size(49, 15)
        Me.lbl_presentacion.TabIndex = 26
        Me.lbl_presentacion.Text = "Ampolla"
        '
        'UltraLabel10
        '
        Appearance37.BackColor = System.Drawing.Color.Transparent
        Appearance37.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel10.Appearance = Appearance37
        Me.UltraLabel10.AutoSize = True
        Me.UltraLabel10.Location = New System.Drawing.Point(10, 154)
        Me.UltraLabel10.Name = "UltraLabel10"
        Me.UltraLabel10.Size = New System.Drawing.Size(54, 15)
        Me.UltraLabel10.TabIndex = 26
        Me.UltraLabel10.Text = "Duracion"
        '
        'UltraLabel9
        '
        Appearance22.BackColor = System.Drawing.Color.Transparent
        Appearance22.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel9.Appearance = Appearance22
        Me.UltraLabel9.AutoSize = True
        Me.UltraLabel9.Location = New System.Drawing.Point(10, 96)
        Me.UltraLabel9.Name = "UltraLabel9"
        Me.UltraLabel9.Size = New System.Drawing.Size(34, 15)
        Me.UltraLabel9.TabIndex = 26
        Me.UltraLabel9.Text = "Cada"
        '
        'UltraLabel6
        '
        Appearance19.BackColor = System.Drawing.Color.Transparent
        Appearance19.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel6.Appearance = Appearance19
        Me.UltraLabel6.AutoSize = True
        Me.UltraLabel6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel6.Location = New System.Drawing.Point(16, 68)
        Me.UltraLabel6.Name = "UltraLabel6"
        Me.UltraLabel6.Size = New System.Drawing.Size(72, 17)
        Me.UltraLabel6.TabIndex = 26
        Me.UltraLabel6.Text = "Categorias"
        '
        'txt_presentacion
        '
        Me.txt_presentacion.Location = New System.Drawing.Point(656, 89)
        Me.txt_presentacion.MaxLength = 10
        Me.txt_presentacion.Name = "txt_presentacion"
        Me.txt_presentacion.ReadOnly = True
        Me.txt_presentacion.Size = New System.Drawing.Size(170, 21)
        Me.txt_presentacion.TabIndex = 7
        '
        'UltraLabel1
        '
        Appearance20.BackColor = System.Drawing.Color.Transparent
        Appearance20.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel1.Appearance = Appearance20
        Me.UltraLabel1.AutoSize = True
        Me.UltraLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel1.Location = New System.Drawing.Point(181, 68)
        Me.UltraLabel1.Name = "UltraLabel1"
        Me.UltraLabel1.Size = New System.Drawing.Size(95, 17)
        Me.UltraLabel1.TabIndex = 26
        Me.UltraLabel1.Text = "Medicamentos"
        '
        'txt_compogene
        '
        Me.txt_compogene.Location = New System.Drawing.Point(397, 89)
        Me.txt_compogene.MaxLength = 10
        Me.txt_compogene.Name = "txt_compogene"
        Me.txt_compogene.ReadOnly = True
        Me.txt_compogene.Size = New System.Drawing.Size(253, 21)
        Me.txt_compogene.TabIndex = 6
        '
        'UltraLabel2
        '
        Appearance26.BackColor = System.Drawing.Color.Transparent
        Appearance26.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel2.Appearance = Appearance26
        Me.UltraLabel2.AutoSize = True
        Me.UltraLabel2.Location = New System.Drawing.Point(53, 197)
        Me.UltraLabel2.Name = "UltraLabel2"
        Me.UltraLabel2.Size = New System.Drawing.Size(0, 0)
        Me.UltraLabel2.TabIndex = 26
        '
        'ug_medicamentos
        '
        Me.ug_medicamentos.DisplayLayout.AutoFitStyle = Infragistics.Win.UltraWinGrid.AutoFitStyle.ExtendLastColumn
        UltraGridColumn1.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn1.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn1.Header.Caption = "Codigo"
        UltraGridColumn1.Header.VisiblePosition = 0
        UltraGridColumn1.Width = 22
        UltraGridColumn2.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn2.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn2.Header.Caption = "Descripcion"
        UltraGridColumn2.Header.VisiblePosition = 1
        UltraGridColumn3.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn3.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn3.Header.VisiblePosition = 2
        UltraGridColumn3.Hidden = True
        UltraGridBand1.Columns.AddRange(New Object() {UltraGridColumn1, UltraGridColumn2, UltraGridColumn3})
        Me.ug_medicamentos.DisplayLayout.BandsSerializer.Add(UltraGridBand1)
        Me.ug_medicamentos.DisplayLayout.GroupByBox.Hidden = True
        Me.ug_medicamentos.DisplayLayout.MaxColScrollRegions = 1
        Me.ug_medicamentos.DisplayLayout.MaxRowScrollRegions = 1
        Me.ug_medicamentos.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        Me.ug_medicamentos.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Me.ug_medicamentos.DisplayLayout.Override.SelectTypeRow = Infragistics.Win.UltraWinGrid.SelectType.[Single]
        Me.ug_medicamentos.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.ug_medicamentos.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.ug_medicamentos.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy
        Me.ug_medicamentos.Location = New System.Drawing.Point(181, 91)
        Me.ug_medicamentos.Name = "ug_medicamentos"
        Me.ug_medicamentos.Size = New System.Drawing.Size(204, 315)
        Me.ug_medicamentos.TabIndex = 5
        '
        'UltraLabel3
        '
        Appearance27.BackColor = System.Drawing.Color.Transparent
        Appearance27.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel3.Appearance = Appearance27
        Me.UltraLabel3.AutoSize = True
        Me.UltraLabel3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel3.Location = New System.Drawing.Point(397, 67)
        Me.UltraLabel3.Name = "UltraLabel3"
        Me.UltraLabel3.Size = New System.Drawing.Size(130, 16)
        Me.UltraLabel3.TabIndex = 26
        Me.UltraLabel3.Text = "Composición Génerica"
        '
        'ug_receta
        '
        Me.ug_receta.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ug_receta.DataSource = Me.uds_receta
        Me.ug_receta.DisplayLayout.AutoFitStyle = Infragistics.Win.UltraWinGrid.AutoFitStyle.ExtendLastColumn
        UltraGridColumn4.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn4.Header.VisiblePosition = 0
        UltraGridColumn4.Hidden = True
        UltraGridColumn5.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn5.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn5.Header.VisiblePosition = 1
        UltraGridColumn5.MinWidth = 15
        UltraGridColumn5.Width = 106
        UltraGridColumn6.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn6.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn6.Header.VisiblePosition = 2
        UltraGridColumn6.MinWidth = 15
        UltraGridColumn6.Width = 101
        UltraGridColumn7.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn7.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn7.Header.VisiblePosition = 3
        UltraGridColumn7.MinWidth = 15
        UltraGridColumn7.Width = 69
        UltraGridColumn8.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn8.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn8.Header.Caption = "Indicaciones"
        UltraGridColumn8.Header.VisiblePosition = 4
        UltraGridColumn8.MinWidth = 200
        UltraGridColumn8.Width = 342
        UltraGridColumn9.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn9.Header.VisiblePosition = 5
        UltraGridColumn9.Hidden = True
        UltraGridColumn10.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn10.Header.VisiblePosition = 6
        UltraGridColumn10.Hidden = True
        UltraGridColumn11.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn11.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn11.Header.Caption = "Observaciones"
        UltraGridColumn11.Header.VisiblePosition = 7
        UltraGridBand2.Columns.AddRange(New Object() {UltraGridColumn4, UltraGridColumn5, UltraGridColumn6, UltraGridColumn7, UltraGridColumn8, UltraGridColumn9, UltraGridColumn10, UltraGridColumn11})
        Me.ug_receta.DisplayLayout.BandsSerializer.Add(UltraGridBand2)
        Me.ug_receta.DisplayLayout.GroupByBox.Hidden = True
        Me.ug_receta.DisplayLayout.MaxColScrollRegions = 1
        Me.ug_receta.DisplayLayout.MaxRowScrollRegions = 1
        Me.ug_receta.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        Me.ug_receta.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Me.ug_receta.DisplayLayout.Override.SelectTypeRow = Infragistics.Win.UltraWinGrid.SelectType.[Single]
        Me.ug_receta.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.ug_receta.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.ug_receta.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy
        Me.ug_receta.Location = New System.Drawing.Point(16, 412)
        Me.ug_receta.Name = "ug_receta"
        Me.ug_receta.Size = New System.Drawing.Size(839, 193)
        Me.ug_receta.TabIndex = 21
        '
        'uds_receta
        '
        UltraDataColumn1.DataType = GetType(Integer)
        UltraDataColumn6.DataType = GetType(Integer)
        UltraDataColumn7.DataType = GetType(Integer)
        Me.uds_receta.Band.Columns.AddRange(New Object() {UltraDataColumn1, UltraDataColumn2, UltraDataColumn3, UltraDataColumn4, UltraDataColumn5, UltraDataColumn6, UltraDataColumn7, UltraDataColumn8})
        '
        'UltraLabel7
        '
        Appearance29.BackColor = System.Drawing.Color.Transparent
        Appearance29.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel7.Appearance = Appearance29
        Me.UltraLabel7.AutoSize = True
        Me.UltraLabel7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel7.Location = New System.Drawing.Point(695, 69)
        Me.UltraLabel7.Name = "UltraLabel7"
        Me.UltraLabel7.Size = New System.Drawing.Size(77, 16)
        Me.UltraLabel7.TabIndex = 26
        Me.UltraLabel7.Text = "Presentación"
        '
        'ug_categoria
        '
        Me.ug_categoria.DisplayLayout.AutoFitStyle = Infragistics.Win.UltraWinGrid.AutoFitStyle.ExtendLastColumn
        UltraGridColumn12.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn12.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn12.Header.Caption = "Codigo"
        UltraGridColumn12.Header.VisiblePosition = 0
        UltraGridColumn12.Width = 25
        UltraGridColumn13.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn13.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn13.Header.Caption = "Descripcion"
        UltraGridColumn13.Header.VisiblePosition = 1
        UltraGridColumn14.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn14.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn14.Header.VisiblePosition = 2
        UltraGridColumn14.Hidden = True
        UltraGridBand3.Columns.AddRange(New Object() {UltraGridColumn12, UltraGridColumn13, UltraGridColumn14})
        Me.ug_categoria.DisplayLayout.BandsSerializer.Add(UltraGridBand3)
        Me.ug_categoria.DisplayLayout.GroupByBox.Hidden = True
        Me.ug_categoria.DisplayLayout.MaxColScrollRegions = 1
        Me.ug_categoria.DisplayLayout.MaxRowScrollRegions = 1
        Me.ug_categoria.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        Me.ug_categoria.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Me.ug_categoria.DisplayLayout.Override.SelectTypeRow = Infragistics.Win.UltraWinGrid.SelectType.[Single]
        Me.ug_categoria.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.ug_categoria.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.ug_categoria.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy
        Me.ug_categoria.Location = New System.Drawing.Point(16, 91)
        Me.ug_categoria.Name = "ug_categoria"
        Me.ug_categoria.Size = New System.Drawing.Size(159, 315)
        Me.ug_categoria.TabIndex = 4
        '
        'UltraLabel4
        '
        Appearance28.BackColor = System.Drawing.Color.Transparent
        Appearance28.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel4.Appearance = Appearance28
        Me.UltraLabel4.AutoSize = True
        Me.UltraLabel4.Location = New System.Drawing.Point(397, 190)
        Me.UltraLabel4.Name = "UltraLabel4"
        Me.UltraLabel4.Size = New System.Drawing.Size(0, 0)
        Me.UltraLabel4.TabIndex = 26
        '
        'UltraTabPageControl2
        '
        Me.UltraTabPageControl2.Controls.Add(Me.ug_ListaDet)
        Me.UltraTabPageControl2.Controls.Add(Me.ug_Lista)
        Me.UltraTabPageControl2.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl2.Name = "UltraTabPageControl2"
        Me.UltraTabPageControl2.Size = New System.Drawing.Size(872, 615)
        '
        'ug_ListaDet
        '
        Me.ug_ListaDet.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ug_ListaDet.DataSource = Me.uds_ListaDet
        Me.ug_ListaDet.DisplayLayout.AutoFitStyle = Infragistics.Win.UltraWinGrid.AutoFitStyle.ExtendLastColumn
        UltraGridColumn15.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn15.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        Appearance3.TextHAlignAsString = "Center"
        UltraGridColumn15.CellAppearance = Appearance3
        UltraGridColumn15.Header.Caption = "Medicamento"
        UltraGridColumn15.Header.VisiblePosition = 0
        UltraGridColumn15.Width = 221
        UltraGridColumn16.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn16.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn16.Header.Caption = "Receta"
        UltraGridColumn16.Header.VisiblePosition = 1
        UltraGridColumn16.Width = 450
        UltraGridColumn17.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn17.Header.VisiblePosition = 2
        UltraGridColumn17.Hidden = True
        UltraGridColumn18.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn18.Header.VisiblePosition = 3
        UltraGridColumn18.Hidden = True
        UltraGridBand4.Columns.AddRange(New Object() {UltraGridColumn15, UltraGridColumn16, UltraGridColumn17, UltraGridColumn18})
        Me.ug_ListaDet.DisplayLayout.BandsSerializer.Add(UltraGridBand4)
        Me.ug_ListaDet.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.[True]
        Me.ug_ListaDet.DisplayLayout.MaxColScrollRegions = 1
        Me.ug_ListaDet.DisplayLayout.MaxRowScrollRegions = 1
        Appearance18.BackColor = System.Drawing.Color.WhiteSmoke
        Appearance18.BackColor2 = System.Drawing.Color.WhiteSmoke
        Me.ug_ListaDet.DisplayLayout.Override.RowAlternateAppearance = Appearance18
        Me.ug_ListaDet.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.ug_ListaDet.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.ug_ListaDet.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ug_ListaDet.Location = New System.Drawing.Point(11, 385)
        Me.ug_ListaDet.Name = "ug_ListaDet"
        Me.ug_ListaDet.Size = New System.Drawing.Size(852, 223)
        Me.ug_ListaDet.TabIndex = 163
        Me.ug_ListaDet.Text = "Detalle de la Receta"
        '
        'uds_ListaDet
        '
        Me.uds_ListaDet.AllowDelete = False
        UltraDataColumn11.DataType = GetType(Integer)
        UltraDataColumn12.DataType = GetType(Integer)
        Me.uds_ListaDet.Band.Columns.AddRange(New Object() {UltraDataColumn9, UltraDataColumn10, UltraDataColumn11, UltraDataColumn12})
        '
        'ug_Lista
        '
        Me.ug_Lista.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ug_Lista.DataSource = Me.uds_Lista
        Me.ug_Lista.DisplayLayout.AutoFitStyle = Infragistics.Win.UltraWinGrid.AutoFitStyle.ExtendLastColumn
        UltraGridColumn19.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn19.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn19.Header.Caption = "id"
        UltraGridColumn19.Header.VisiblePosition = 0
        UltraGridColumn19.Hidden = True
        UltraGridColumn19.Width = 70
        UltraGridColumn20.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn20.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn20.Header.Caption = "Fecha"
        UltraGridColumn20.Header.VisiblePosition = 1
        UltraGridColumn20.Width = 138
        UltraGridColumn21.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn21.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn21.Header.Caption = "Hora Atencion"
        UltraGridColumn21.Header.VisiblePosition = 2
        UltraGridColumn21.Width = 158
        UltraGridColumn22.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn22.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn22.Header.VisiblePosition = 3
        UltraGridColumn22.Width = 70
        UltraGridBand5.Columns.AddRange(New Object() {UltraGridColumn19, UltraGridColumn20, UltraGridColumn21, UltraGridColumn22})
        Me.ug_Lista.DisplayLayout.BandsSerializer.Add(UltraGridBand5)
        Me.ug_Lista.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.[False]
        Me.ug_Lista.DisplayLayout.MaxColScrollRegions = 1
        Me.ug_Lista.DisplayLayout.MaxRowScrollRegions = 1
        Me.ug_Lista.DisplayLayout.Override.FilterUIType = Infragistics.Win.UltraWinGrid.FilterUIType.FilterRow
        Appearance6.BackColor = System.Drawing.Color.WhiteSmoke
        Appearance6.BackColor2 = System.Drawing.Color.WhiteSmoke
        Me.ug_Lista.DisplayLayout.Override.RowAlternateAppearance = Appearance6
        Me.ug_Lista.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.ug_Lista.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.ug_Lista.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ug_Lista.Location = New System.Drawing.Point(11, 14)
        Me.ug_Lista.Name = "ug_Lista"
        Me.ug_Lista.Size = New System.Drawing.Size(852, 354)
        Me.ug_Lista.TabIndex = 162
        Me.ug_Lista.Text = "UltraGrid1"
        '
        'uds_Lista
        '
        Me.uds_Lista.AllowDelete = False
        UltraDataColumn13.DataType = GetType(Integer)
        Me.uds_Lista.Band.Columns.AddRange(New Object() {UltraDataColumn13, UltraDataColumn14, UltraDataColumn15, UltraDataColumn16})
        '
        'ToolS_Mantenimiento
        '
        Me.ToolS_Mantenimiento.BackColor = System.Drawing.Color.White
        Me.ToolS_Mantenimiento.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Tool_Nuevo, Me.ToolStripSeparator2, Me.Tool_Grabar, Me.ToolStripSeparator3, Me.Tool_Imprimir, Me.ToolStripSeparator1, Me.Tool_Salir})
        Me.ToolS_Mantenimiento.Location = New System.Drawing.Point(0, 0)
        Me.ToolS_Mantenimiento.Name = "ToolS_Mantenimiento"
        Me.ToolS_Mantenimiento.Size = New System.Drawing.Size(876, 25)
        Me.ToolS_Mantenimiento.TabIndex = 153
        Me.ToolS_Mantenimiento.Text = "ToolStrip1"
        '
        'Tool_Nuevo
        '
        Me.Tool_Nuevo.Image = Global.Contabilidad.My.Resources.Resources._16__View_normal_
        Me.Tool_Nuevo.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Tool_Nuevo.Name = "Tool_Nuevo"
        Me.Tool_Nuevo.Size = New System.Drawing.Size(62, 22)
        Me.Tool_Nuevo.Text = "Nuevo"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 25)
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
        'Tool_Imprimir
        '
        Me.Tool_Imprimir.Image = Global.Contabilidad.My.Resources.Resources._004
        Me.Tool_Imprimir.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Tool_Imprimir.Name = "Tool_Imprimir"
        Me.Tool_Imprimir.Size = New System.Drawing.Size(73, 22)
        Me.Tool_Imprimir.Text = "Imprimir"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'Tool_Salir
        '
        Me.Tool_Salir.Image = Global.Contabilidad.My.Resources.Resources._28
        Me.Tool_Salir.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Tool_Salir.Name = "Tool_Salir"
        Me.Tool_Salir.Size = New System.Drawing.Size(49, 22)
        Me.Tool_Salir.Text = "Salir"
        '
        'utc_Datos
        '
        Me.utc_Datos.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.utc_Datos.Controls.Add(Me.UltraTabSharedControlsPage1)
        Me.utc_Datos.Controls.Add(Me.UltraTabPageControl1)
        Me.utc_Datos.Controls.Add(Me.UltraTabPageControl2)
        Me.utc_Datos.Location = New System.Drawing.Point(0, 27)
        Me.utc_Datos.Name = "utc_Datos"
        Me.utc_Datos.SharedControlsPage = Me.UltraTabSharedControlsPage1
        Me.utc_Datos.Size = New System.Drawing.Size(876, 641)
        Me.utc_Datos.TabIndex = 155
        UltraTab1.TabPage = Me.UltraTabPageControl1
        UltraTab1.Text = "Receta"
        UltraTab2.TabPage = Me.UltraTabPageControl2
        UltraTab2.Text = "Historial de Recetas"
        Me.utc_Datos.Tabs.AddRange(New Infragistics.Win.UltraWinTabControl.UltraTab() {UltraTab1, UltraTab2})
        '
        'UltraTabSharedControlsPage1
        '
        Me.UltraTabSharedControlsPage1.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabSharedControlsPage1.Name = "UltraTabSharedControlsPage1"
        Me.UltraTabSharedControlsPage1.Size = New System.Drawing.Size(872, 615)
        '
        'AD_PR_Recetas_Medicas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(876, 669)
        Me.Controls.Add(Me.utc_Datos)
        Me.Controls.Add(Me.ToolS_Mantenimiento)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "AD_PR_Recetas_Medicas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Recetas Medicas"
        Me.UltraTabPageControl1.ResumeLayout(False)
        CType(Me.ugb_Datos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ugb_Datos.ResumeLayout(False)
        Me.ugb_Datos.PerformLayout()
        CType(Me.txt_Observacion, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.utxt_idReceta, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_idCita, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.uce_tip_doc, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_idHistoria, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UltraGroupBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraGroupBox1.ResumeLayout(False)
        CType(Me.txt_ruc_cliente, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_Des_Cliente, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UltraGroupBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraGroupBox2.ResumeLayout(False)
        Me.UltraGroupBox2.PerformLayout()
        CType(Me.utxt_Cantidad, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_duracion, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_cada, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_tomar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_presentacion, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_compogene, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ug_medicamentos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ug_receta, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.uds_receta, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ug_categoria, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabPageControl2.ResumeLayout(False)
        CType(Me.ug_ListaDet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.uds_ListaDet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ug_Lista, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.uds_Lista, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolS_Mantenimiento.ResumeLayout(False)
        Me.ToolS_Mantenimiento.PerformLayout()
        CType(Me.utc_Datos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.utc_Datos.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents UltraLabel6 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel1 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel2 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel3 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel4 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents ug_categoria As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents ug_medicamentos As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents UltraLabel7 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents txt_compogene As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents txt_presentacion As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents UltraGroupBox2 As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents uc_despuescomida As Infragistics.Win.UltraWinEditors.UltraCheckEditor
    Friend WithEvents uc_antescomida As Infragistics.Win.UltraWinEditors.UltraCheckEditor
    Friend WithEvents txt_segunavolucionclinica As Infragistics.Win.UltraWinEditors.UltraCheckEditor
    Friend WithEvents uc_durantecomida As Infragistics.Win.UltraWinEditors.UltraCheckEditor
    Friend WithEvents uc_ayunas As Infragistics.Win.UltraWinEditors.UltraCheckEditor
    Friend WithEvents uc_dias2 As Infragistics.Win.UltraWinEditors.UltraCheckEditor
    Friend WithEvents uc_horas As Infragistics.Win.UltraWinEditors.UltraCheckEditor
    Friend WithEvents txt_dias1 As Infragistics.Win.UltraWinEditors.UltraCheckEditor
    Friend WithEvents btn_agregar As Infragistics.Win.Misc.UltraButton
    Friend WithEvents txt_tomar As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents txt_cada As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents lbl_tomar As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents txt_duracion As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents lbl_presentacion As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel10 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel9 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents ug_receta As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents uds_receta As Infragistics.Win.UltraWinDataSource.UltraDataSource
    Friend WithEvents UltraGroupBox1 As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents UltraLabel14 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents uce_tip_doc As Infragistics.Win.UltraWinEditors.UltraComboEditor
    Friend WithEvents txt_Des_Cliente As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents txt_ruc_cliente As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents UltraLabel5 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents txt_idHistoria As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents ubt_Quitar As Infragistics.Win.Misc.UltraButton
    Friend WithEvents ToolS_Mantenimiento As System.Windows.Forms.ToolStrip
    Friend WithEvents Tool_Grabar As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents Tool_Salir As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents Tool_Imprimir As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ugb_Datos As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Tool_Nuevo As System.Windows.Forms.ToolStripButton
    Friend WithEvents txt_idCita As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents utxt_idReceta As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents utc_Datos As Infragistics.Win.UltraWinTabControl.UltraTabControl
    Friend WithEvents UltraTabSharedControlsPage1 As Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage
    Friend WithEvents UltraTabPageControl1 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents UltraTabPageControl2 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents ug_ListaDet As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents uds_ListaDet As Infragistics.Win.UltraWinDataSource.UltraDataSource
    Friend WithEvents ug_Lista As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents uds_Lista As Infragistics.Win.UltraWinDataSource.UltraDataSource
    Friend WithEvents UltraLabel8 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents txt_Observacion As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents utxt_Cantidad As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents UltraLabel11 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents uc_Intramuscular As Infragistics.Win.UltraWinEditors.UltraCheckEditor
    Friend WithEvents uc_Subcutaneo As Infragistics.Win.UltraWinEditors.UltraCheckEditor
End Class
