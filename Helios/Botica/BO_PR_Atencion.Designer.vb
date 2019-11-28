<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BO_PR_Atencion
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
        Dim UltraGridColumn1 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CC_ID")
        Dim UltraGridColumn2 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CC_FECHA")
        Dim UltraGridColumn3 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("HC_NOMBRE1")
        Dim UltraGridColumn4 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CC_IDTIPO_ATENC")
        Dim UltraGridColumn5 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CC_SIT_COPG_FIJO")
        Dim UltraGridColumn6 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CC_SIT_COPG_VARI")
        Dim UltraGridColumn7 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CB_DESCRIPCION")
        Dim UltraGridColumn8 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ME_NOMBRES")
        Dim Appearance6 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraDataColumn1 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("CC_ID")
        Dim UltraDataColumn2 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("CC_FECHA")
        Dim UltraDataColumn3 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("HC_NOMBRE1")
        Dim UltraDataColumn4 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("CC_IDTIPO_ATENC")
        Dim UltraDataColumn5 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("CC_SIT_COPG_FIJO")
        Dim UltraDataColumn6 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("CC_SIT_COPG_VARI")
        Dim UltraDataColumn7 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("CB_DESCRIPCION")
        Dim UltraDataColumn8 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("ME_NOMBRES")
        Dim UltraGridBand2 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1)
        Dim UltraGridColumn9 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("AT_ID")
        Dim UltraGridColumn10 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("AT_IDCuenta")
        Dim UltraGridColumn11 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("AT_IDTipoDoc")
        Dim UltraGridColumn12 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("AT_Serie")
        Dim UltraGridColumn13 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("AT_Numero")
        Dim Appearance1 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraDataColumn9 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("AT_ID")
        Dim UltraDataColumn10 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("AT_IDCuenta")
        Dim UltraDataColumn11 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("AT_IDTipoDoc")
        Dim UltraDataColumn12 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("AT_Serie")
        Dim UltraDataColumn13 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("AT_Numero")
        Dim Appearance12 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance10 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance4 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance24 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim ValueListItem1 As Infragistics.Win.ValueListItem = New Infragistics.Win.ValueListItem()
        Dim ValueListItem2 As Infragistics.Win.ValueListItem = New Infragistics.Win.ValueListItem()
        Dim Appearance11 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraTab1 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraTab2 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim Appearance45 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance3 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance5 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Me.UltraTabPageControl1 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.ug_Cuentas = New Infragistics.Win.UltraWinGrid.UltraGrid()
        Me.uds_Cuentas = New Infragistics.Win.UltraWinDataSource.UltraDataSource(Me.components)
        Me.UltraTabPageControl2 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.ugb_Datos = New Infragistics.Win.Misc.UltraGroupBox()
        Me.txt_id = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.ug_Lista = New Infragistics.Win.UltraWinGrid.UltraGrid()
        Me.uds_Lista = New Infragistics.Win.UltraWinDataSource.UltraDataSource(Me.components)
        Me.UltraLabel3 = New Infragistics.Win.Misc.UltraLabel()
        Me.txt_idCuenta = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.UltraLabel2 = New Infragistics.Win.Misc.UltraLabel()
        Me.ugb_Cuenta = New Infragistics.Win.Misc.UltraGroupBox()
        Me.UltraLabel7 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraLabel8 = New Infragistics.Win.Misc.UltraLabel()
        Me.txt_Numero = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.txt_Serie = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.uce_TipoDoc = New Infragistics.Win.UltraWinEditors.UltraComboEditor()
        Me.UltraLabel6 = New Infragistics.Win.Misc.UltraLabel()
        Me.ToolS_Mantenimiento = New System.Windows.Forms.ToolStrip()
        Me.Tool_Nuevo = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.Tool_Grabar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.Tool_Editar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.Tool_Cancelar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.Tool_Eliminar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator()
        Me.Tool_Salir = New System.Windows.Forms.ToolStripButton()
        Me.utc_Datos = New Infragistics.Win.UltraWinTabControl.UltraTabControl()
        Me.UltraTabSharedControlsPage1 = New Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage()
        Me.udte_fechaH = New Infragistics.Win.UltraWinEditors.UltraDateTimeEditor()
        Me.UltraLabel1 = New Infragistics.Win.Misc.UltraLabel()
        Me.udte_fechaD = New Infragistics.Win.UltraWinEditors.UltraDateTimeEditor()
        Me.UltraLabel4 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraGroupBox1 = New Infragistics.Win.Misc.UltraGroupBox()
        Me.ubtn_consultar = New Infragistics.Win.Misc.UltraButton()
        Me.UltraTabPageControl1.SuspendLayout()
        CType(Me.ug_Cuentas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.uds_Cuentas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabPageControl2.SuspendLayout()
        CType(Me.ugb_Datos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ugb_Datos.SuspendLayout()
        CType(Me.txt_id, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ug_Lista, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.uds_Lista, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_idCuenta, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ugb_Cuenta, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ugb_Cuenta.SuspendLayout()
        CType(Me.txt_Numero, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_Serie, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.uce_TipoDoc, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolS_Mantenimiento.SuspendLayout()
        CType(Me.utc_Datos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.utc_Datos.SuspendLayout()
        CType(Me.udte_fechaH, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.udte_fechaD, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UltraGroupBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraGroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'UltraTabPageControl1
        '
        Me.UltraTabPageControl1.Controls.Add(Me.UltraGroupBox1)
        Me.UltraTabPageControl1.Controls.Add(Me.ug_Cuentas)
        Me.UltraTabPageControl1.Location = New System.Drawing.Point(1, 23)
        Me.UltraTabPageControl1.Name = "UltraTabPageControl1"
        Me.UltraTabPageControl1.Size = New System.Drawing.Size(965, 415)
        '
        'ug_Cuentas
        '
        Me.ug_Cuentas.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ug_Cuentas.DataSource = Me.uds_Cuentas
        Me.ug_Cuentas.DisplayLayout.AutoFitStyle = Infragistics.Win.UltraWinGrid.AutoFitStyle.ExtendLastColumn
        UltraGridColumn1.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn1.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn1.Header.Caption = "Cuenta"
        UltraGridColumn1.Header.VisiblePosition = 0
        UltraGridColumn1.Width = 79
        UltraGridColumn2.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn2.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn2.Header.Caption = "Fecha"
        UltraGridColumn2.Header.VisiblePosition = 1
        UltraGridColumn2.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Date]
        UltraGridColumn2.Width = 70
        UltraGridColumn3.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn3.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn3.Header.Caption = "Paciente"
        UltraGridColumn3.Header.VisiblePosition = 2
        UltraGridColumn3.Width = 276
        UltraGridColumn4.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn4.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn4.Header.Caption = "Seguro"
        UltraGridColumn4.Header.VisiblePosition = 3
        UltraGridColumn4.Width = 94
        UltraGridColumn5.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn5.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn5.Header.Caption = "Deducible"
        UltraGridColumn5.Header.VisiblePosition = 4
        UltraGridColumn5.Width = 60
        UltraGridColumn6.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn6.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn6.Header.Caption = "COASEGURO"
        UltraGridColumn6.Header.VisiblePosition = 5
        UltraGridColumn6.Width = 60
        UltraGridColumn7.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn7.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn7.Header.Caption = "Cobertura"
        UltraGridColumn7.Header.VisiblePosition = 6
        UltraGridColumn7.Width = 71
        UltraGridColumn8.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn8.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn8.Header.Caption = "Medico"
        UltraGridColumn8.Header.VisiblePosition = 7
        UltraGridColumn8.Width = 100
        UltraGridBand1.Columns.AddRange(New Object() {UltraGridColumn1, UltraGridColumn2, UltraGridColumn3, UltraGridColumn4, UltraGridColumn5, UltraGridColumn6, UltraGridColumn7, UltraGridColumn8})
        Me.ug_Cuentas.DisplayLayout.BandsSerializer.Add(UltraGridBand1)
        Me.ug_Cuentas.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.[False]
        Me.ug_Cuentas.DisplayLayout.MaxColScrollRegions = 1
        Me.ug_Cuentas.DisplayLayout.MaxRowScrollRegions = 1
        Me.ug_Cuentas.DisplayLayout.Override.FilterUIType = Infragistics.Win.UltraWinGrid.FilterUIType.FilterRow
        Appearance6.BackColor = System.Drawing.Color.WhiteSmoke
        Appearance6.BackColor2 = System.Drawing.Color.WhiteSmoke
        Me.ug_Cuentas.DisplayLayout.Override.RowAlternateAppearance = Appearance6
        Me.ug_Cuentas.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.ug_Cuentas.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.ug_Cuentas.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ug_Cuentas.Location = New System.Drawing.Point(10, 50)
        Me.ug_Cuentas.Name = "ug_Cuentas"
        Me.ug_Cuentas.Size = New System.Drawing.Size(946, 366)
        Me.ug_Cuentas.TabIndex = 1
        Me.ug_Cuentas.Text = "UltraGrid1"
        '
        'uds_Cuentas
        '
        Me.uds_Cuentas.AllowDelete = False
        UltraDataColumn1.DataType = GetType(Long)
        UltraDataColumn2.DataType = GetType(Date)
        Me.uds_Cuentas.Band.Columns.AddRange(New Object() {UltraDataColumn1, UltraDataColumn2, UltraDataColumn3, UltraDataColumn4, UltraDataColumn5, UltraDataColumn6, UltraDataColumn7, UltraDataColumn8})
        '
        'UltraTabPageControl2
        '
        Me.UltraTabPageControl2.Controls.Add(Me.ugb_Datos)
        Me.UltraTabPageControl2.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl2.Name = "UltraTabPageControl2"
        Me.UltraTabPageControl2.Size = New System.Drawing.Size(965, 415)
        '
        'ugb_Datos
        '
        Me.ugb_Datos.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ugb_Datos.Controls.Add(Me.txt_id)
        Me.ugb_Datos.Controls.Add(Me.ug_Lista)
        Me.ugb_Datos.Controls.Add(Me.UltraLabel3)
        Me.ugb_Datos.Controls.Add(Me.txt_idCuenta)
        Me.ugb_Datos.Controls.Add(Me.Panel2)
        Me.ugb_Datos.Controls.Add(Me.UltraLabel2)
        Me.ugb_Datos.Controls.Add(Me.ugb_Cuenta)
        Me.ugb_Datos.Location = New System.Drawing.Point(35, 27)
        Me.ugb_Datos.Name = "ugb_Datos"
        Me.ugb_Datos.Size = New System.Drawing.Size(894, 361)
        Me.ugb_Datos.TabIndex = 33
        '
        'txt_id
        '
        Me.txt_id.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_id.Location = New System.Drawing.Point(376, 41)
        Me.txt_id.MaxLength = 50
        Me.txt_id.Name = "txt_id"
        Me.txt_id.ReadOnly = True
        Me.txt_id.Size = New System.Drawing.Size(29, 21)
        Me.txt_id.TabIndex = 181
        Me.txt_id.Visible = False
        '
        'ug_Lista
        '
        Me.ug_Lista.DataSource = Me.uds_Lista
        Me.ug_Lista.DisplayLayout.AutoFitStyle = Infragistics.Win.UltraWinGrid.AutoFitStyle.ExtendLastColumn
        UltraGridColumn9.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn9.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn9.Header.Caption = "CÓDIGO"
        UltraGridColumn9.Header.VisiblePosition = 0
        UltraGridColumn9.Hidden = True
        UltraGridColumn9.Width = 120
        UltraGridColumn10.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn10.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn10.Header.Caption = "Cuenta"
        UltraGridColumn10.Header.VisiblePosition = 1
        UltraGridColumn10.Width = 100
        UltraGridColumn11.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn11.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn11.Header.Caption = "Tipo Doc."
        UltraGridColumn11.Header.VisiblePosition = 2
        UltraGridColumn11.Width = 150
        UltraGridColumn12.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn12.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn12.Header.Caption = "Serie"
        UltraGridColumn12.Header.VisiblePosition = 3
        UltraGridColumn13.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn13.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn13.Header.Caption = "Numero"
        UltraGridColumn13.Header.VisiblePosition = 4
        UltraGridBand2.Columns.AddRange(New Object() {UltraGridColumn9, UltraGridColumn10, UltraGridColumn11, UltraGridColumn12, UltraGridColumn13})
        Me.ug_Lista.DisplayLayout.BandsSerializer.Add(UltraGridBand2)
        Me.ug_Lista.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.[False]
        Me.ug_Lista.DisplayLayout.MaxColScrollRegions = 1
        Me.ug_Lista.DisplayLayout.MaxRowScrollRegions = 1
        Appearance1.BackColor = System.Drawing.Color.WhiteSmoke
        Appearance1.BackColor2 = System.Drawing.Color.WhiteSmoke
        Me.ug_Lista.DisplayLayout.Override.RowAlternateAppearance = Appearance1
        Me.ug_Lista.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.ug_Lista.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.ug_Lista.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ug_Lista.Location = New System.Drawing.Point(56, 158)
        Me.ug_Lista.Name = "ug_Lista"
        Me.ug_Lista.Size = New System.Drawing.Size(699, 176)
        Me.ug_Lista.TabIndex = 0
        Me.ug_Lista.Text = "UltraGrid1"
        '
        'uds_Lista
        '
        Me.uds_Lista.AllowDelete = False
        UltraDataColumn9.DataType = GetType(Long)
        UltraDataColumn10.DataType = GetType(Integer)
        Me.uds_Lista.Band.Columns.AddRange(New Object() {UltraDataColumn9, UltraDataColumn10, UltraDataColumn11, UltraDataColumn12, UltraDataColumn13})
        '
        'UltraLabel3
        '
        Appearance12.BackColor = System.Drawing.Color.Transparent
        Appearance12.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel3.Appearance = Appearance12
        Me.UltraLabel3.AutoSize = True
        Me.UltraLabel3.Location = New System.Drawing.Point(24, 43)
        Me.UltraLabel3.Name = "UltraLabel3"
        Me.UltraLabel3.Size = New System.Drawing.Size(41, 14)
        Me.UltraLabel3.TabIndex = 180
        Me.UltraLabel3.Text = "Cuenta"
        '
        'txt_idCuenta
        '
        Me.txt_idCuenta.Location = New System.Drawing.Point(66, 39)
        Me.txt_idCuenta.Name = "txt_idCuenta"
        Me.txt_idCuenta.ReadOnly = True
        Me.txt_idCuenta.Size = New System.Drawing.Size(115, 21)
        Me.txt_idCuenta.TabIndex = 179
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.Panel2.Location = New System.Drawing.Point(55, 150)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(700, 2)
        Me.Panel2.TabIndex = 154
        '
        'UltraLabel2
        '
        Appearance10.BackColor = System.Drawing.Color.DeepSkyBlue
        Appearance10.ForeColor = System.Drawing.Color.White
        Appearance10.TextHAlignAsString = "Center"
        Me.UltraLabel2.Appearance = Appearance10
        Me.UltraLabel2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel2.Location = New System.Drawing.Point(2, 2)
        Me.UltraLabel2.Name = "UltraLabel2"
        Me.UltraLabel2.Size = New System.Drawing.Size(805, 28)
        Me.UltraLabel2.TabIndex = 27
        Me.UltraLabel2.Text = "Registrar Atención"
        '
        'ugb_Cuenta
        '
        Me.ugb_Cuenta.Controls.Add(Me.UltraLabel7)
        Me.ugb_Cuenta.Controls.Add(Me.UltraLabel8)
        Me.ugb_Cuenta.Controls.Add(Me.txt_Numero)
        Me.ugb_Cuenta.Controls.Add(Me.txt_Serie)
        Me.ugb_Cuenta.Controls.Add(Me.uce_TipoDoc)
        Me.ugb_Cuenta.Controls.Add(Me.UltraLabel6)
        Me.ugb_Cuenta.Location = New System.Drawing.Point(132, 71)
        Me.ugb_Cuenta.Name = "ugb_Cuenta"
        Me.ugb_Cuenta.Size = New System.Drawing.Size(555, 59)
        Me.ugb_Cuenta.TabIndex = 141
        Me.ugb_Cuenta.Text = "Informacion Atencion"
        '
        'UltraLabel7
        '
        Appearance4.BackColor = System.Drawing.Color.Transparent
        Appearance4.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel7.Appearance = Appearance4
        Me.UltraLabel7.AutoSize = True
        Me.UltraLabel7.Location = New System.Drawing.Point(389, 31)
        Me.UltraLabel7.Name = "UltraLabel7"
        Me.UltraLabel7.Size = New System.Drawing.Size(44, 14)
        Me.UltraLabel7.TabIndex = 128
        Me.UltraLabel7.Text = "Numero"
        '
        'UltraLabel8
        '
        Appearance24.BackColor = System.Drawing.Color.Transparent
        Appearance24.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel8.Appearance = Appearance24
        Me.UltraLabel8.AutoSize = True
        Me.UltraLabel8.Location = New System.Drawing.Point(249, 31)
        Me.UltraLabel8.Name = "UltraLabel8"
        Me.UltraLabel8.Size = New System.Drawing.Size(31, 14)
        Me.UltraLabel8.TabIndex = 129
        Me.UltraLabel8.Text = "Serie"
        '
        'txt_Numero
        '
        Me.txt_Numero.Location = New System.Drawing.Point(434, 27)
        Me.txt_Numero.Name = "txt_Numero"
        Me.txt_Numero.Size = New System.Drawing.Size(83, 21)
        Me.txt_Numero.TabIndex = 8
        '
        'txt_Serie
        '
        Me.txt_Serie.Location = New System.Drawing.Point(284, 27)
        Me.txt_Serie.Name = "txt_Serie"
        Me.txt_Serie.Size = New System.Drawing.Size(83, 21)
        Me.txt_Serie.TabIndex = 7
        '
        'uce_TipoDoc
        '
        Me.uce_TipoDoc.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Suggest
        Me.uce_TipoDoc.DropDownListWidth = 50
        Me.uce_TipoDoc.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        ValueListItem1.DataValue = "01"
        ValueListItem1.DisplayText = "Factura"
        ValueListItem2.DataValue = "02"
        ValueListItem2.DisplayText = "Boleta"
        Me.uce_TipoDoc.Items.AddRange(New Infragistics.Win.ValueListItem() {ValueListItem1, ValueListItem2})
        Me.uce_TipoDoc.Location = New System.Drawing.Point(108, 27)
        Me.uce_TipoDoc.Name = "uce_TipoDoc"
        Me.uce_TipoDoc.Size = New System.Drawing.Size(112, 21)
        Me.uce_TipoDoc.TabIndex = 6
        '
        'UltraLabel6
        '
        Appearance11.BackColor = System.Drawing.Color.Transparent
        Appearance11.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel6.Appearance = Appearance11
        Me.UltraLabel6.AutoSize = True
        Me.UltraLabel6.Location = New System.Drawing.Point(31, 30)
        Me.UltraLabel6.Name = "UltraLabel6"
        Me.UltraLabel6.Size = New System.Drawing.Size(73, 14)
        Me.UltraLabel6.TabIndex = 125
        Me.UltraLabel6.Text = "Comprobante"
        '
        'ToolS_Mantenimiento
        '
        Me.ToolS_Mantenimiento.BackColor = System.Drawing.Color.White
        Me.ToolS_Mantenimiento.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Tool_Nuevo, Me.ToolStripSeparator1, Me.Tool_Grabar, Me.ToolStripSeparator2, Me.Tool_Editar, Me.ToolStripSeparator4, Me.Tool_Cancelar, Me.ToolStripSeparator3, Me.Tool_Eliminar, Me.ToolStripSeparator5, Me.Tool_Salir})
        Me.ToolS_Mantenimiento.Location = New System.Drawing.Point(0, 0)
        Me.ToolS_Mantenimiento.Name = "ToolS_Mantenimiento"
        Me.ToolS_Mantenimiento.Size = New System.Drawing.Size(987, 25)
        Me.ToolS_Mantenimiento.TabIndex = 32
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
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 25)
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
        'utc_Datos
        '
        Me.utc_Datos.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.utc_Datos.Controls.Add(Me.UltraTabSharedControlsPage1)
        Me.utc_Datos.Controls.Add(Me.UltraTabPageControl1)
        Me.utc_Datos.Controls.Add(Me.UltraTabPageControl2)
        Me.utc_Datos.Location = New System.Drawing.Point(9, 27)
        Me.utc_Datos.Name = "utc_Datos"
        Me.utc_Datos.SharedControlsPage = Me.UltraTabSharedControlsPage1
        Me.utc_Datos.Size = New System.Drawing.Size(969, 441)
        Me.utc_Datos.TabIndex = 34
        UltraTab1.TabPage = Me.UltraTabPageControl1
        UltraTab1.Text = "Lista de Cuentas"
        UltraTab2.TabPage = Me.UltraTabPageControl2
        UltraTab2.Text = "Ingreso / Edicion de Datos"
        Me.utc_Datos.Tabs.AddRange(New Infragistics.Win.UltraWinTabControl.UltraTab() {UltraTab1, UltraTab2})
        '
        'UltraTabSharedControlsPage1
        '
        Me.UltraTabSharedControlsPage1.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabSharedControlsPage1.Name = "UltraTabSharedControlsPage1"
        Me.UltraTabSharedControlsPage1.Size = New System.Drawing.Size(965, 415)
        '
        'udte_fechaH
        '
        Me.udte_fechaH.DateTime = New Date(2014, 1, 28, 0, 0, 0, 0)
        Me.udte_fechaH.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.udte_fechaH.Location = New System.Drawing.Point(294, 9)
        Me.udte_fechaH.Name = "udte_fechaH"
        Me.udte_fechaH.Size = New System.Drawing.Size(100, 24)
        Me.udte_fechaH.TabIndex = 157
        Me.udte_fechaH.Value = New Date(2014, 1, 28, 0, 0, 0, 0)
        '
        'UltraLabel1
        '
        Appearance45.BackColor = System.Drawing.Color.Transparent
        Appearance45.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel1.Appearance = Appearance45
        Me.UltraLabel1.AutoSize = True
        Me.UltraLabel1.Location = New System.Drawing.Point(216, 15)
        Me.UltraLabel1.Name = "UltraLabel1"
        Me.UltraLabel1.Size = New System.Drawing.Size(68, 14)
        Me.UltraLabel1.TabIndex = 159
        Me.UltraLabel1.Text = "Fecha Hasta"
        '
        'udte_fechaD
        '
        Me.udte_fechaD.DateTime = New Date(2014, 1, 28, 0, 0, 0, 0)
        Me.udte_fechaD.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.udte_fechaD.Location = New System.Drawing.Point(74, 9)
        Me.udte_fechaD.Name = "udte_fechaD"
        Me.udte_fechaD.Size = New System.Drawing.Size(104, 24)
        Me.udte_fechaD.TabIndex = 156
        Me.udte_fechaD.Value = New Date(2014, 1, 28, 0, 0, 0, 0)
        '
        'UltraLabel4
        '
        Appearance3.BackColor = System.Drawing.Color.Transparent
        Appearance3.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel4.Appearance = Appearance3
        Me.UltraLabel4.AutoSize = True
        Me.UltraLabel4.Location = New System.Drawing.Point(32, 15)
        Me.UltraLabel4.Name = "UltraLabel4"
        Me.UltraLabel4.Size = New System.Drawing.Size(37, 14)
        Me.UltraLabel4.TabIndex = 158
        Me.UltraLabel4.Text = "Desde"
        '
        'UltraGroupBox1
        '
        Me.UltraGroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.UltraGroupBox1.Controls.Add(Me.ubtn_consultar)
        Me.UltraGroupBox1.Controls.Add(Me.udte_fechaH)
        Me.UltraGroupBox1.Controls.Add(Me.UltraLabel1)
        Me.UltraGroupBox1.Controls.Add(Me.udte_fechaD)
        Me.UltraGroupBox1.Controls.Add(Me.UltraLabel4)
        Me.UltraGroupBox1.Location = New System.Drawing.Point(10, 5)
        Me.UltraGroupBox1.Name = "UltraGroupBox1"
        Me.UltraGroupBox1.Size = New System.Drawing.Size(946, 39)
        Me.UltraGroupBox1.TabIndex = 160
        '
        'ubtn_consultar
        '
        Appearance5.ImageHAlign = Infragistics.Win.HAlign.Left
        Me.ubtn_consultar.Appearance = Appearance5
        Me.ubtn_consultar.Location = New System.Drawing.Point(418, 7)
        Me.ubtn_consultar.Name = "ubtn_consultar"
        Me.ubtn_consultar.Size = New System.Drawing.Size(105, 25)
        Me.ubtn_consultar.TabIndex = 160
        Me.ubtn_consultar.Text = "Consultar"
        '
        'BO_PR_Atencion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(987, 474)
        Me.Controls.Add(Me.utc_Datos)
        Me.Controls.Add(Me.ToolS_Mantenimiento)
        Me.Name = "BO_PR_Atencion"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Registro de Atención"
        Me.UltraTabPageControl1.ResumeLayout(False)
        CType(Me.ug_Cuentas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.uds_Cuentas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabPageControl2.ResumeLayout(False)
        CType(Me.ugb_Datos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ugb_Datos.ResumeLayout(False)
        Me.ugb_Datos.PerformLayout()
        CType(Me.txt_id, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ug_Lista, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.uds_Lista, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_idCuenta, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ugb_Cuenta, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ugb_Cuenta.ResumeLayout(False)
        Me.ugb_Cuenta.PerformLayout()
        CType(Me.txt_Numero, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_Serie, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.uce_TipoDoc, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolS_Mantenimiento.ResumeLayout(False)
        Me.ToolS_Mantenimiento.PerformLayout()
        CType(Me.utc_Datos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.utc_Datos.ResumeLayout(False)
        CType(Me.udte_fechaH, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.udte_fechaD, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UltraGroupBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraGroupBox1.ResumeLayout(False)
        Me.UltraGroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolS_Mantenimiento As System.Windows.Forms.ToolStrip
    Friend WithEvents Tool_Grabar As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents Tool_Salir As System.Windows.Forms.ToolStripButton
    Friend WithEvents ugb_Datos As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents UltraLabel2 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents ugb_Cuenta As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents uce_TipoDoc As Infragistics.Win.UltraWinEditors.UltraComboEditor
    Friend WithEvents UltraLabel6 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel7 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel8 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents txt_Numero As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents txt_Serie As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents Tool_Nuevo As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents Tool_Cancelar As System.Windows.Forms.ToolStripButton
    Friend WithEvents uds_Lista As Infragistics.Win.UltraWinDataSource.UltraDataSource
    Friend WithEvents utc_Datos As Infragistics.Win.UltraWinTabControl.UltraTabControl
    Friend WithEvents UltraTabSharedControlsPage1 As Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage
    Friend WithEvents UltraTabPageControl1 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents ug_Lista As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents UltraTabPageControl2 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents Tool_Editar As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents Tool_Eliminar As System.Windows.Forms.ToolStripButton
    Friend WithEvents UltraLabel3 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents txt_idCuenta As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents txt_id As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents ug_Cuentas As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents uds_Cuentas As Infragistics.Win.UltraWinDataSource.UltraDataSource
    Friend WithEvents ToolStripSeparator5 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents UltraGroupBox1 As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents udte_fechaH As Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
    Friend WithEvents UltraLabel1 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents udte_fechaD As Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
    Friend WithEvents UltraLabel4 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents ubtn_consultar As Infragistics.Win.Misc.UltraButton
End Class
