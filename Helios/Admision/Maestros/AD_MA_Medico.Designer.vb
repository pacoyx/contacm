<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AD_MA_Medico
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
        Dim UltraGridColumn1 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ME_CODIGO")
        Dim UltraGridColumn2 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ME_APE_PAT")
        Dim UltraGridColumn3 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ME_APE_MAT")
        Dim UltraGridColumn4 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ME_NOMBRES")
        Dim UltraGridColumn5 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ME_NUM_COLEG")
        Dim UltraGridColumn6 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ME_ESPECIALIDAD")
        Dim UltraGridColumn7 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ES_DESCRIPCION")
        Dim UltraGridColumn8 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ME_RUC")
        Dim UltraGridColumn9 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ME_DIRECCION")
        Dim UltraGridColumn10 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ME_TELEFONOFIJO")
        Dim UltraGridColumn11 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ME_TELEFONOCELULAR")
        Dim UltraGridColumn12 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ME_INTERVALO")
        Dim UltraGridColumn13 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ME_FECNAC")
        Dim UltraGridColumn14 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ME_CORREO")
        Dim UltraGridColumn15 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ESTADO")
        Dim UltraGridColumn16 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ME_TDOC")
        Dim UltraGridColumn17 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ME_NDOC")
        Dim Appearance9 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraDataColumn1 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("ME_CODIGO")
        Dim UltraDataColumn2 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("ME_APE_PAT")
        Dim UltraDataColumn3 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("ME_APE_MAT")
        Dim UltraDataColumn4 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("ME_NOMBRES")
        Dim UltraDataColumn5 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("ME_NUM_COLEG")
        Dim UltraDataColumn6 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("ME_ESPECIALIDAD")
        Dim UltraDataColumn7 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("ES_DESCRIPCION")
        Dim UltraDataColumn8 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("ME_RUC")
        Dim UltraDataColumn9 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("ME_DIRECCION")
        Dim UltraDataColumn10 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("ME_TELEFONOFIJO")
        Dim UltraDataColumn11 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("ME_TELEFONOCELULAR")
        Dim UltraDataColumn12 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("ME_INTERVALO")
        Dim UltraDataColumn13 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("ME_FECNAC")
        Dim UltraDataColumn14 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("ME_CORREO")
        Dim UltraDataColumn15 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("ESTADO")
        Dim UltraDataColumn16 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("ME_TDOC")
        Dim UltraDataColumn17 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("ME_NDOC")
        Dim Appearance18 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance41 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance1 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance6 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance10 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance11 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance12 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance13 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance21 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance2 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance8 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance15 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance5 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim ValueListItem1 As Infragistics.Win.ValueListItem = New Infragistics.Win.ValueListItem()
        Dim ValueListItem2 As Infragistics.Win.ValueListItem = New Infragistics.Win.ValueListItem()
        Dim Appearance7 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance3 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance14 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance4 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraTab1 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraTab2 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Me.UltraTabPageControl1 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.ug_Lista = New Infragistics.Win.UltraWinGrid.UltraGrid()
        Me.uds_Lista = New Infragistics.Win.UltraWinDataSource.UltraDataSource(Me.components)
        Me.UltraTabPageControl2 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.ugb_datos = New Infragistics.Win.Misc.UltraGroupBox()
        Me.txt_num_doc = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.UltraLabel16 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraLabel17 = New Infragistics.Win.Misc.UltraLabel()
        Me.uce_tip_doc = New Infragistics.Win.UltraWinEditors.UltraComboEditor()
        Me.txt_Intervalo = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.UltraLabel15 = New Infragistics.Win.Misc.UltraLabel()
        Me.txt_Correo = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.UltraLabel14 = New Infragistics.Win.Misc.UltraLabel()
        Me.txt_Celular = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.UltraLabel13 = New Infragistics.Win.Misc.UltraLabel()
        Me.txt_Fijo = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.UltraLabel12 = New Infragistics.Win.Misc.UltraLabel()
        Me.txt_Direccion = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.UltraLabel11 = New Infragistics.Win.Misc.UltraLabel()
        Me.txt_RUC = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.UltraLabel10 = New Infragistics.Win.Misc.UltraLabel()
        Me.udte_fecha = New Infragistics.Win.UltraWinEditors.UltraDateTimeEditor()
        Me.UltraLabel7 = New Infragistics.Win.Misc.UltraLabel()
        Me.txt_ColegioM = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.UltraLabel6 = New Infragistics.Win.Misc.UltraLabel()
        Me.txt_Nombres = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.UltraLabel5 = New Infragistics.Win.Misc.UltraLabel()
        Me.uce_Especialidades = New Infragistics.Win.UltraWinEditors.UltraComboEditor()
        Me.UltraLabel8 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraLabel3 = New Infragistics.Win.Misc.UltraLabel()
        Me.urb_Estado = New Infragistics.Win.UltraWinEditors.UltraOptionSet()
        Me.UltraLabel9 = New Infragistics.Win.Misc.UltraLabel()
        Me.txt_ApellidoM = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.txt_ApellidoP = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.UltraLabel2 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraLabel1 = New Infragistics.Win.Misc.UltraLabel()
        Me.txt_id = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.UltraLabel4 = New Infragistics.Win.Misc.UltraLabel()
        Me.utc_Datos = New Infragistics.Win.UltraWinTabControl.UltraTabControl()
        Me.UltraTabSharedControlsPage1 = New Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage()
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
        Me.UltraTabPageControl1.SuspendLayout()
        CType(Me.ug_Lista, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.uds_Lista, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabPageControl2.SuspendLayout()
        CType(Me.ugb_datos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ugb_datos.SuspendLayout()
        CType(Me.txt_num_doc, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.uce_tip_doc, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_Intervalo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_Correo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_Celular, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_Fijo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_Direccion, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_RUC, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.udte_fecha, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_ColegioM, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_Nombres, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.uce_Especialidades, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.urb_Estado, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_ApellidoM, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_ApellidoP, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_id, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.utc_Datos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.utc_Datos.SuspendLayout()
        Me.ToolS_Mantenimiento.SuspendLayout()
        Me.SuspendLayout()
        '
        'UltraTabPageControl1
        '
        Me.UltraTabPageControl1.Controls.Add(Me.ug_Lista)
        Me.UltraTabPageControl1.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl1.Name = "UltraTabPageControl1"
        Me.UltraTabPageControl1.Size = New System.Drawing.Size(718, 335)
        '
        'ug_Lista
        '
        Me.ug_Lista.DataSource = Me.uds_Lista
        Me.ug_Lista.DisplayLayout.AutoFitStyle = Infragistics.Win.UltraWinGrid.AutoFitStyle.ExtendLastColumn
        UltraGridColumn1.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn1.Header.Caption = "CÓDIGO"
        UltraGridColumn1.Header.VisiblePosition = 0
        UltraGridColumn1.Width = 50
        UltraGridColumn2.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn2.Header.Caption = "APELLIDO PATERNO"
        UltraGridColumn2.Header.VisiblePosition = 1
        UltraGridColumn2.Width = 163
        UltraGridColumn3.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn3.Header.Caption = "APELLIDO MATERNO"
        UltraGridColumn3.Header.VisiblePosition = 2
        UltraGridColumn3.Width = 124
        UltraGridColumn4.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn4.Header.Caption = "NOMBRES"
        UltraGridColumn4.Header.VisiblePosition = 3
        UltraGridColumn4.Width = 110
        UltraGridColumn5.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn5.Header.Caption = "Nº COLEGIO M."
        UltraGridColumn5.Header.VisiblePosition = 4
        UltraGridColumn5.Width = 80
        UltraGridColumn6.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn6.Header.VisiblePosition = 5
        UltraGridColumn6.Hidden = True
        UltraGridColumn7.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn7.Header.Caption = "ESPECIALIDAD"
        UltraGridColumn7.Header.VisiblePosition = 6
        UltraGridColumn8.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn8.Header.Caption = "RUC"
        UltraGridColumn8.Header.VisiblePosition = 7
        UltraGridColumn8.Width = 80
        UltraGridColumn9.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn9.Header.Caption = "DIRECCION"
        UltraGridColumn9.Header.VisiblePosition = 8
        UltraGridColumn9.Width = 100
        UltraGridColumn10.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn10.Header.Caption = "T. FIJO"
        UltraGridColumn10.Header.VisiblePosition = 9
        UltraGridColumn10.Width = 80
        UltraGridColumn11.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn11.Header.Caption = "T. CELULAR"
        UltraGridColumn11.Header.VisiblePosition = 10
        UltraGridColumn11.Width = 80
        UltraGridColumn12.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn12.Header.Caption = "INTERVALO"
        UltraGridColumn12.Header.VisiblePosition = 11
        UltraGridColumn12.Width = 60
        UltraGridColumn13.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn13.Header.Caption = "F. NACIMIENTO"
        UltraGridColumn13.Header.VisiblePosition = 12
        UltraGridColumn13.Width = 90
        UltraGridColumn14.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn14.Header.Caption = "CORREO"
        UltraGridColumn14.Header.VisiblePosition = 13
        UltraGridColumn14.Width = 100
        UltraGridColumn15.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn15.Header.VisiblePosition = 14
        UltraGridColumn15.Width = 80
        UltraGridColumn16.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn16.Header.VisiblePosition = 15
        UltraGridColumn16.Hidden = True
        UltraGridColumn17.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn17.Header.VisiblePosition = 16
        UltraGridColumn17.Hidden = True
        UltraGridBand1.Columns.AddRange(New Object() {UltraGridColumn1, UltraGridColumn2, UltraGridColumn3, UltraGridColumn4, UltraGridColumn5, UltraGridColumn6, UltraGridColumn7, UltraGridColumn8, UltraGridColumn9, UltraGridColumn10, UltraGridColumn11, UltraGridColumn12, UltraGridColumn13, UltraGridColumn14, UltraGridColumn15, UltraGridColumn16, UltraGridColumn17})
        Me.ug_Lista.DisplayLayout.BandsSerializer.Add(UltraGridBand1)
        Me.ug_Lista.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.[False]
        Me.ug_Lista.DisplayLayout.MaxColScrollRegions = 1
        Me.ug_Lista.DisplayLayout.MaxRowScrollRegions = 1
        Me.ug_Lista.DisplayLayout.Override.FilterUIType = Infragistics.Win.UltraWinGrid.FilterUIType.FilterRow
        Appearance9.BackColor = System.Drawing.Color.WhiteSmoke
        Appearance9.BackColor2 = System.Drawing.Color.WhiteSmoke
        Me.ug_Lista.DisplayLayout.Override.RowAlternateAppearance = Appearance9
        Me.ug_Lista.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.ug_Lista.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.ug_Lista.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ug_Lista.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ug_Lista.Location = New System.Drawing.Point(0, 0)
        Me.ug_Lista.Name = "ug_Lista"
        Me.ug_Lista.Size = New System.Drawing.Size(718, 335)
        Me.ug_Lista.TabIndex = 0
        Me.ug_Lista.Text = "UltraGrid1"
        '
        'uds_Lista
        '
        Me.uds_Lista.AllowDelete = False
        UltraDataColumn1.DataType = GetType(Long)
        UltraDataColumn16.DataType = GetType(Integer)
        Me.uds_Lista.Band.Columns.AddRange(New Object() {UltraDataColumn1, UltraDataColumn2, UltraDataColumn3, UltraDataColumn4, UltraDataColumn5, UltraDataColumn6, UltraDataColumn7, UltraDataColumn8, UltraDataColumn9, UltraDataColumn10, UltraDataColumn11, UltraDataColumn12, UltraDataColumn13, UltraDataColumn14, UltraDataColumn15, UltraDataColumn16, UltraDataColumn17})
        '
        'UltraTabPageControl2
        '
        Me.UltraTabPageControl2.Controls.Add(Me.ugb_datos)
        Me.UltraTabPageControl2.Location = New System.Drawing.Point(1, 23)
        Me.UltraTabPageControl2.Name = "UltraTabPageControl2"
        Me.UltraTabPageControl2.Size = New System.Drawing.Size(718, 335)
        '
        'ugb_datos
        '
        Me.ugb_datos.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ugb_datos.Controls.Add(Me.txt_num_doc)
        Me.ugb_datos.Controls.Add(Me.UltraLabel16)
        Me.ugb_datos.Controls.Add(Me.UltraLabel17)
        Me.ugb_datos.Controls.Add(Me.uce_tip_doc)
        Me.ugb_datos.Controls.Add(Me.txt_Intervalo)
        Me.ugb_datos.Controls.Add(Me.UltraLabel15)
        Me.ugb_datos.Controls.Add(Me.txt_Correo)
        Me.ugb_datos.Controls.Add(Me.UltraLabel14)
        Me.ugb_datos.Controls.Add(Me.txt_Celular)
        Me.ugb_datos.Controls.Add(Me.UltraLabel13)
        Me.ugb_datos.Controls.Add(Me.txt_Fijo)
        Me.ugb_datos.Controls.Add(Me.UltraLabel12)
        Me.ugb_datos.Controls.Add(Me.txt_Direccion)
        Me.ugb_datos.Controls.Add(Me.UltraLabel11)
        Me.ugb_datos.Controls.Add(Me.txt_RUC)
        Me.ugb_datos.Controls.Add(Me.UltraLabel10)
        Me.ugb_datos.Controls.Add(Me.udte_fecha)
        Me.ugb_datos.Controls.Add(Me.UltraLabel7)
        Me.ugb_datos.Controls.Add(Me.txt_ColegioM)
        Me.ugb_datos.Controls.Add(Me.UltraLabel6)
        Me.ugb_datos.Controls.Add(Me.txt_Nombres)
        Me.ugb_datos.Controls.Add(Me.UltraLabel5)
        Me.ugb_datos.Controls.Add(Me.uce_Especialidades)
        Me.ugb_datos.Controls.Add(Me.UltraLabel8)
        Me.ugb_datos.Controls.Add(Me.UltraLabel3)
        Me.ugb_datos.Controls.Add(Me.urb_Estado)
        Me.ugb_datos.Controls.Add(Me.UltraLabel9)
        Me.ugb_datos.Controls.Add(Me.txt_ApellidoM)
        Me.ugb_datos.Controls.Add(Me.txt_ApellidoP)
        Me.ugb_datos.Controls.Add(Me.UltraLabel2)
        Me.ugb_datos.Controls.Add(Me.UltraLabel1)
        Me.ugb_datos.Controls.Add(Me.txt_id)
        Me.ugb_datos.Controls.Add(Me.UltraLabel4)
        Me.ugb_datos.Location = New System.Drawing.Point(9, 5)
        Me.ugb_datos.Name = "ugb_datos"
        Me.ugb_datos.Size = New System.Drawing.Size(700, 323)
        Me.ugb_datos.TabIndex = 0
        '
        'txt_num_doc
        '
        Me.txt_num_doc.Location = New System.Drawing.Point(424, 56)
        Me.txt_num_doc.MaxLength = 50
        Me.txt_num_doc.Name = "txt_num_doc"
        Me.txt_num_doc.Size = New System.Drawing.Size(165, 21)
        Me.txt_num_doc.TabIndex = 50
        '
        'UltraLabel16
        '
        Appearance18.BackColor = System.Drawing.Color.Transparent
        Appearance18.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel16.Appearance = Appearance18
        Me.UltraLabel16.AutoSize = True
        Me.UltraLabel16.Location = New System.Drawing.Point(360, 58)
        Me.UltraLabel16.Name = "UltraLabel16"
        Me.UltraLabel16.Size = New System.Drawing.Size(54, 14)
        Me.UltraLabel16.TabIndex = 52
        Me.UltraLabel16.Text = "Num. Doc"
        '
        'UltraLabel17
        '
        Appearance41.BackColor = System.Drawing.Color.Transparent
        Appearance41.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel17.Appearance = Appearance41
        Me.UltraLabel17.AutoSize = True
        Me.UltraLabel17.Location = New System.Drawing.Point(15, 54)
        Me.UltraLabel17.Name = "UltraLabel17"
        Me.UltraLabel17.Size = New System.Drawing.Size(49, 14)
        Me.UltraLabel17.TabIndex = 51
        Me.UltraLabel17.Text = "Tipo Doc"
        '
        'uce_tip_doc
        '
        Me.uce_tip_doc.DropDownListWidth = 300
        Me.uce_tip_doc.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.uce_tip_doc.Location = New System.Drawing.Point(117, 54)
        Me.uce_tip_doc.Name = "uce_tip_doc"
        Me.uce_tip_doc.Size = New System.Drawing.Size(230, 21)
        Me.uce_tip_doc.TabIndex = 49
        '
        'txt_Intervalo
        '
        Me.txt_Intervalo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_Intervalo.Location = New System.Drawing.Point(358, 222)
        Me.txt_Intervalo.MaxLength = 3
        Me.txt_Intervalo.Name = "txt_Intervalo"
        Me.txt_Intervalo.Size = New System.Drawing.Size(38, 21)
        Me.txt_Intervalo.TabIndex = 11
        '
        'UltraLabel15
        '
        Appearance1.BackColor = System.Drawing.Color.Transparent
        Appearance1.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel15.Appearance = Appearance1
        Me.UltraLabel15.AutoSize = True
        Me.UltraLabel15.Location = New System.Drawing.Point(399, 226)
        Me.UltraLabel15.Name = "UltraLabel15"
        Me.UltraLabel15.Size = New System.Drawing.Size(22, 14)
        Me.UltraLabel15.TabIndex = 48
        Me.UltraLabel15.Text = "Min"
        '
        'txt_Correo
        '
        Me.txt_Correo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_Correo.Location = New System.Drawing.Point(358, 194)
        Me.txt_Correo.MaxLength = 45
        Me.txt_Correo.Name = "txt_Correo"
        Me.txt_Correo.Size = New System.Drawing.Size(295, 21)
        Me.txt_Correo.TabIndex = 9
        '
        'UltraLabel14
        '
        Appearance6.BackColor = System.Drawing.Color.Transparent
        Appearance6.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel14.Appearance = Appearance6
        Me.UltraLabel14.AutoSize = True
        Me.UltraLabel14.Location = New System.Drawing.Point(288, 197)
        Me.UltraLabel14.Name = "UltraLabel14"
        Me.UltraLabel14.Size = New System.Drawing.Size(39, 14)
        Me.UltraLabel14.TabIndex = 47
        Me.UltraLabel14.Text = "Correo"
        '
        'txt_Celular
        '
        Me.txt_Celular.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_Celular.Location = New System.Drawing.Point(117, 194)
        Me.txt_Celular.MaxLength = 20
        Me.txt_Celular.Name = "txt_Celular"
        Me.txt_Celular.Size = New System.Drawing.Size(132, 21)
        Me.txt_Celular.TabIndex = 8
        '
        'UltraLabel13
        '
        Appearance10.BackColor = System.Drawing.Color.Transparent
        Appearance10.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel13.Appearance = Appearance10
        Me.UltraLabel13.AutoSize = True
        Me.UltraLabel13.Location = New System.Drawing.Point(15, 198)
        Me.UltraLabel13.Name = "UltraLabel13"
        Me.UltraLabel13.Size = New System.Drawing.Size(87, 14)
        Me.UltraLabel13.TabIndex = 45
        Me.UltraLabel13.Text = "Teléfono Celular"
        '
        'txt_Fijo
        '
        Me.txt_Fijo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_Fijo.Location = New System.Drawing.Point(117, 222)
        Me.txt_Fijo.MaxLength = 20
        Me.txt_Fijo.Name = "txt_Fijo"
        Me.txt_Fijo.Size = New System.Drawing.Size(132, 21)
        Me.txt_Fijo.TabIndex = 10
        '
        'UltraLabel12
        '
        Appearance11.BackColor = System.Drawing.Color.Transparent
        Appearance11.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel12.Appearance = Appearance11
        Me.UltraLabel12.AutoSize = True
        Me.UltraLabel12.Location = New System.Drawing.Point(15, 226)
        Me.UltraLabel12.Name = "UltraLabel12"
        Me.UltraLabel12.Size = New System.Drawing.Size(70, 14)
        Me.UltraLabel12.TabIndex = 43
        Me.UltraLabel12.Text = "Teléfono Fijo"
        '
        'txt_Direccion
        '
        Me.txt_Direccion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_Direccion.Location = New System.Drawing.Point(117, 139)
        Me.txt_Direccion.MaxLength = 100
        Me.txt_Direccion.Name = "txt_Direccion"
        Me.txt_Direccion.Size = New System.Drawing.Size(536, 21)
        Me.txt_Direccion.TabIndex = 5
        '
        'UltraLabel11
        '
        Appearance12.BackColor = System.Drawing.Color.Transparent
        Appearance12.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel11.Appearance = Appearance12
        Me.UltraLabel11.AutoSize = True
        Me.UltraLabel11.Location = New System.Drawing.Point(15, 143)
        Me.UltraLabel11.Name = "UltraLabel11"
        Me.UltraLabel11.Size = New System.Drawing.Size(52, 14)
        Me.UltraLabel11.TabIndex = 41
        Me.UltraLabel11.Text = "Dirección"
        '
        'txt_RUC
        '
        Me.txt_RUC.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_RUC.Location = New System.Drawing.Point(466, 111)
        Me.txt_RUC.MaxLength = 20
        Me.txt_RUC.Name = "txt_RUC"
        Me.txt_RUC.Size = New System.Drawing.Size(187, 21)
        Me.txt_RUC.TabIndex = 4
        '
        'UltraLabel10
        '
        Appearance13.BackColor = System.Drawing.Color.Transparent
        Appearance13.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel10.Appearance = Appearance13
        Me.UltraLabel10.AutoSize = True
        Me.UltraLabel10.Location = New System.Drawing.Point(424, 115)
        Me.UltraLabel10.Name = "UltraLabel10"
        Me.UltraLabel10.Size = New System.Drawing.Size(38, 14)
        Me.UltraLabel10.TabIndex = 39
        Me.UltraLabel10.Text = "R.U.C."
        '
        'udte_fecha
        '
        Me.udte_fecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.udte_fecha.Location = New System.Drawing.Point(117, 250)
        Me.udte_fecha.Name = "udte_fecha"
        Me.udte_fecha.Size = New System.Drawing.Size(132, 24)
        Me.udte_fecha.TabIndex = 12
        '
        'UltraLabel7
        '
        Appearance21.BackColor = System.Drawing.Color.Transparent
        Appearance21.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel7.Appearance = Appearance21
        Me.UltraLabel7.AutoSize = True
        Me.UltraLabel7.Location = New System.Drawing.Point(15, 256)
        Me.UltraLabel7.Name = "UltraLabel7"
        Me.UltraLabel7.Size = New System.Drawing.Size(95, 14)
        Me.UltraLabel7.TabIndex = 37
        Me.UltraLabel7.Text = "Fecha Nacimiento"
        '
        'txt_ColegioM
        '
        Me.txt_ColegioM.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_ColegioM.Location = New System.Drawing.Point(117, 166)
        Me.txt_ColegioM.MaxLength = 10
        Me.txt_ColegioM.Name = "txt_ColegioM"
        Me.txt_ColegioM.Size = New System.Drawing.Size(132, 21)
        Me.txt_ColegioM.TabIndex = 6
        '
        'UltraLabel6
        '
        Appearance2.BackColor = System.Drawing.Color.Transparent
        Appearance2.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel6.Appearance = Appearance2
        Me.UltraLabel6.AutoSize = True
        Me.UltraLabel6.Location = New System.Drawing.Point(15, 170)
        Me.UltraLabel6.Name = "UltraLabel6"
        Me.UltraLabel6.Size = New System.Drawing.Size(98, 14)
        Me.UltraLabel6.TabIndex = 35
        Me.UltraLabel6.Text = "Nº Colegio Medico"
        '
        'txt_Nombres
        '
        Me.txt_Nombres.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_Nombres.Location = New System.Drawing.Point(117, 111)
        Me.txt_Nombres.MaxLength = 50
        Me.txt_Nombres.Name = "txt_Nombres"
        Me.txt_Nombres.Size = New System.Drawing.Size(293, 21)
        Me.txt_Nombres.TabIndex = 3
        '
        'UltraLabel5
        '
        Appearance8.BackColor = System.Drawing.Color.Transparent
        Appearance8.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel5.Appearance = Appearance8
        Me.UltraLabel5.AutoSize = True
        Me.UltraLabel5.Location = New System.Drawing.Point(15, 114)
        Me.UltraLabel5.Name = "UltraLabel5"
        Me.UltraLabel5.Size = New System.Drawing.Size(50, 14)
        Me.UltraLabel5.TabIndex = 33
        Me.UltraLabel5.Text = "Nombres"
        '
        'uce_Especialidades
        '
        Me.uce_Especialidades.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.uce_Especialidades.Location = New System.Drawing.Point(358, 166)
        Me.uce_Especialidades.Name = "uce_Especialidades"
        Me.uce_Especialidades.Size = New System.Drawing.Size(295, 21)
        Me.uce_Especialidades.TabIndex = 7
        '
        'UltraLabel8
        '
        Appearance15.BackColor = System.Drawing.Color.Transparent
        Appearance15.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel8.Appearance = Appearance15
        Me.UltraLabel8.AutoSize = True
        Me.UltraLabel8.Location = New System.Drawing.Point(288, 226)
        Me.UltraLabel8.Name = "UltraLabel8"
        Me.UltraLabel8.Size = New System.Drawing.Size(48, 14)
        Me.UltraLabel8.TabIndex = 31
        Me.UltraLabel8.Text = "Intervalo"
        '
        'UltraLabel3
        '
        Appearance5.BackColor = System.Drawing.Color.Transparent
        Appearance5.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel3.Appearance = Appearance5
        Me.UltraLabel3.AutoSize = True
        Me.UltraLabel3.Location = New System.Drawing.Point(288, 169)
        Me.UltraLabel3.Name = "UltraLabel3"
        Me.UltraLabel3.Size = New System.Drawing.Size(69, 14)
        Me.UltraLabel3.TabIndex = 30
        Me.UltraLabel3.Text = "Especialidad"
        '
        'urb_Estado
        '
        Me.urb_Estado.BackColor = System.Drawing.Color.Transparent
        Me.urb_Estado.BackColorInternal = System.Drawing.Color.Transparent
        Me.urb_Estado.BorderStyle = Infragistics.Win.UIElementBorderStyle.None
        ValueListItem1.DataValue = 1
        ValueListItem1.DisplayText = "Activo"
        ValueListItem2.DataValue = 0
        ValueListItem2.DisplayText = "Inactivo"
        Me.urb_Estado.Items.AddRange(New Infragistics.Win.ValueListItem() {ValueListItem1, ValueListItem2})
        Me.urb_Estado.Location = New System.Drawing.Point(358, 256)
        Me.urb_Estado.Name = "urb_Estado"
        Me.urb_Estado.Size = New System.Drawing.Size(138, 26)
        Me.urb_Estado.TabIndex = 13
        '
        'UltraLabel9
        '
        Appearance7.BackColor = System.Drawing.Color.Transparent
        Appearance7.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel9.Appearance = Appearance7
        Me.UltraLabel9.AutoSize = True
        Me.UltraLabel9.Location = New System.Drawing.Point(288, 256)
        Me.UltraLabel9.Name = "UltraLabel9"
        Me.UltraLabel9.Size = New System.Drawing.Size(39, 14)
        Me.UltraLabel9.TabIndex = 26
        Me.UltraLabel9.Text = "Estado"
        '
        'txt_ApellidoM
        '
        Me.txt_ApellidoM.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_ApellidoM.Location = New System.Drawing.Point(424, 82)
        Me.txt_ApellidoM.MaxLength = 50
        Me.txt_ApellidoM.Name = "txt_ApellidoM"
        Me.txt_ApellidoM.Size = New System.Drawing.Size(245, 21)
        Me.txt_ApellidoM.TabIndex = 2
        '
        'txt_ApellidoP
        '
        Me.txt_ApellidoP.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_ApellidoP.Location = New System.Drawing.Point(117, 83)
        Me.txt_ApellidoP.MaxLength = 50
        Me.txt_ApellidoP.Name = "txt_ApellidoP"
        Me.txt_ApellidoP.Size = New System.Drawing.Size(230, 21)
        Me.txt_ApellidoP.TabIndex = 1
        '
        'UltraLabel2
        '
        Appearance3.BackColor = System.Drawing.Color.Transparent
        Appearance3.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel2.Appearance = Appearance3
        Me.UltraLabel2.AutoSize = True
        Me.UltraLabel2.Location = New System.Drawing.Point(360, 87)
        Me.UltraLabel2.Name = "UltraLabel2"
        Me.UltraLabel2.Size = New System.Drawing.Size(46, 14)
        Me.UltraLabel2.TabIndex = 23
        Me.UltraLabel2.Text = "Materno"
        '
        'UltraLabel1
        '
        Appearance14.BackColor = System.Drawing.Color.Transparent
        Appearance14.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel1.Appearance = Appearance14
        Me.UltraLabel1.AutoSize = True
        Me.UltraLabel1.Location = New System.Drawing.Point(15, 86)
        Me.UltraLabel1.Name = "UltraLabel1"
        Me.UltraLabel1.Size = New System.Drawing.Size(96, 14)
        Me.UltraLabel1.TabIndex = 23
        Me.UltraLabel1.Text = "Apellidos, Paterno"
        '
        'txt_id
        '
        Me.txt_id.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_id.Location = New System.Drawing.Point(117, 21)
        Me.txt_id.MaxLength = 50
        Me.txt_id.Name = "txt_id"
        Me.txt_id.ReadOnly = True
        Me.txt_id.Size = New System.Drawing.Size(132, 21)
        Me.txt_id.TabIndex = 0
        '
        'UltraLabel4
        '
        Appearance4.BackColor = System.Drawing.Color.Transparent
        Appearance4.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel4.Appearance = Appearance4
        Me.UltraLabel4.AutoSize = True
        Me.UltraLabel4.Location = New System.Drawing.Point(15, 23)
        Me.UltraLabel4.Name = "UltraLabel4"
        Me.UltraLabel4.Size = New System.Drawing.Size(40, 14)
        Me.UltraLabel4.TabIndex = 23
        Me.UltraLabel4.Text = "Codigo"
        '
        'utc_Datos
        '
        Me.utc_Datos.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.utc_Datos.Controls.Add(Me.UltraTabSharedControlsPage1)
        Me.utc_Datos.Controls.Add(Me.UltraTabPageControl1)
        Me.utc_Datos.Controls.Add(Me.UltraTabPageControl2)
        Me.utc_Datos.Location = New System.Drawing.Point(0, 28)
        Me.utc_Datos.Name = "utc_Datos"
        Me.utc_Datos.SharedControlsPage = Me.UltraTabSharedControlsPage1
        Me.utc_Datos.Size = New System.Drawing.Size(722, 361)
        Me.utc_Datos.TabIndex = 17
        UltraTab1.TabPage = Me.UltraTabPageControl1
        UltraTab1.Text = "Lista de Médicos"
        UltraTab2.TabPage = Me.UltraTabPageControl2
        UltraTab2.Text = "Ingreso / Edicion de Datos"
        Me.utc_Datos.Tabs.AddRange(New Infragistics.Win.UltraWinTabControl.UltraTab() {UltraTab1, UltraTab2})
        '
        'UltraTabSharedControlsPage1
        '
        Me.UltraTabSharedControlsPage1.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabSharedControlsPage1.Name = "UltraTabSharedControlsPage1"
        Me.UltraTabSharedControlsPage1.Size = New System.Drawing.Size(718, 335)
        '
        'ToolS_Mantenimiento
        '
        Me.ToolS_Mantenimiento.BackColor = System.Drawing.Color.White
        Me.ToolS_Mantenimiento.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Tool_Nuevo, Me.ToolStripSeparator1, Me.Tool_Grabar, Me.ToolStripSeparator3, Me.Tool_Editar, Me.ToolStripSeparator4, Me.Tool_Cancelar, Me.ToolStripSeparator2, Me.Tool_Eliminar, Me.ToolStripSeparator5, Me.Tool_Salir})
        Me.ToolS_Mantenimiento.Location = New System.Drawing.Point(0, 0)
        Me.ToolS_Mantenimiento.Name = "ToolS_Mantenimiento"
        Me.ToolS_Mantenimiento.Size = New System.Drawing.Size(729, 25)
        Me.ToolS_Mantenimiento.TabIndex = 16
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
        'AD_MA_Medico
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(729, 393)
        Me.Controls.Add(Me.utc_Datos)
        Me.Controls.Add(Me.ToolS_Mantenimiento)
        Me.Name = "AD_MA_Medico"
        Me.Text = "Mantenimiento de Medicos"
        Me.UltraTabPageControl1.ResumeLayout(False)
        CType(Me.ug_Lista, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.uds_Lista, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabPageControl2.ResumeLayout(False)
        CType(Me.ugb_datos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ugb_datos.ResumeLayout(False)
        Me.ugb_datos.PerformLayout()
        CType(Me.txt_num_doc, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.uce_tip_doc, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_Intervalo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_Correo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_Celular, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_Fijo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_Direccion, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_RUC, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.udte_fecha, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_ColegioM, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_Nombres, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.uce_Especialidades, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.urb_Estado, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_ApellidoM, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_ApellidoP, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_id, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.utc_Datos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.utc_Datos.ResumeLayout(False)
        Me.ToolS_Mantenimiento.ResumeLayout(False)
        Me.ToolS_Mantenimiento.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents utc_Datos As Infragistics.Win.UltraWinTabControl.UltraTabControl
    Friend WithEvents UltraTabSharedControlsPage1 As Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage
    Friend WithEvents UltraTabPageControl1 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents ug_Lista As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents uds_Lista As Infragistics.Win.UltraWinDataSource.UltraDataSource
    Friend WithEvents UltraTabPageControl2 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents ugb_datos As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents txt_ApellidoM As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents txt_ApellidoP As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents UltraLabel2 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel1 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents txt_id As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents UltraLabel4 As Infragistics.Win.Misc.UltraLabel
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
    Friend WithEvents urb_Estado As Infragistics.Win.UltraWinEditors.UltraOptionSet
    Friend WithEvents UltraLabel9 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents txt_Nombres As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents UltraLabel5 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents uce_Especialidades As Infragistics.Win.UltraWinEditors.UltraComboEditor
    Friend WithEvents UltraLabel8 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel3 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents txt_ColegioM As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents UltraLabel6 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents udte_fecha As Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
    Friend WithEvents UltraLabel7 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents txt_Correo As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents UltraLabel14 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents txt_Celular As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents UltraLabel13 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents txt_Fijo As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents UltraLabel12 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents txt_Direccion As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents UltraLabel11 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents txt_RUC As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents UltraLabel10 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel15 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents txt_Intervalo As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents txt_num_doc As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents UltraLabel16 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel17 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents uce_tip_doc As Infragistics.Win.UltraWinEditors.UltraComboEditor
End Class
