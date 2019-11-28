<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AD_PR_ProgramacionEmerg
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
        Dim UltraGridColumn1 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("PR_ID")
        Dim UltraGridColumn2 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("PR_MEDICO")
        Dim UltraGridColumn3 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NOMBRES")
        Dim UltraGridColumn4 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("PR_IDCONSULTORIO")
        Dim UltraGridColumn5 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CM_DESCRIPCION")
        Dim UltraGridColumn6 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("PR_IDSERVICIO")
        Dim UltraGridColumn7 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("SM_DESCRIPCION")
        Dim UltraGridColumn8 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("PR_TURNO_INI")
        Dim UltraGridColumn9 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("PR_TURNO_FIN")
        Dim UltraGridColumn10 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("PR_FECHA")
        Dim UltraGridColumn11 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("PR_ESTADO")
        Dim UltraGridColumn12 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("PR_CUPOS")
        Dim UltraGridColumn13 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("PR_DIAS")
        Dim UltraGridColumn14 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("PR_Tipo")
        Dim UltraGridColumn15 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("PR_TURNO")
        Dim Appearance9 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraDataColumn1 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("PR_ID")
        Dim UltraDataColumn2 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("PR_MEDICO")
        Dim UltraDataColumn3 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("NOMBRES")
        Dim UltraDataColumn4 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("PR_IDCONSULTORIO")
        Dim UltraDataColumn5 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("CM_DESCRIPCION")
        Dim UltraDataColumn6 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("PR_IDSERVICIO")
        Dim UltraDataColumn7 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("SM_DESCRIPCION")
        Dim UltraDataColumn8 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("PR_TURNO_INI")
        Dim UltraDataColumn9 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("PR_TURNO_FIN")
        Dim UltraDataColumn10 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("PR_FECHA")
        Dim UltraDataColumn11 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("PR_ESTADO")
        Dim UltraDataColumn12 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("PR_CUPOS")
        Dim UltraDataColumn13 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("PR_DIAS")
        Dim UltraDataColumn14 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("PR_Tipo")
        Dim UltraDataColumn15 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("PR_TURNO")
        Dim Appearance2 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim ValueListItem1 As Infragistics.Win.ValueListItem = New Infragistics.Win.ValueListItem()
        Dim ValueListItem2 As Infragistics.Win.ValueListItem = New Infragistics.Win.ValueListItem()
        Dim Appearance7 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim ValueListItem5 As Infragistics.Win.ValueListItem = New Infragistics.Win.ValueListItem()
        Dim ValueListItem6 As Infragistics.Win.ValueListItem = New Infragistics.Win.ValueListItem()
        Dim Appearance10 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance21 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance1 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance4 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance5 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance6 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance8 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraTab1 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraTab2 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Me.UltraTabPageControl1 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.ug_Programacion = New Infragistics.Win.UltraWinGrid.UltraGrid()
        Me.uds_Programacion = New Infragistics.Win.UltraWinDataSource.UltraDataSource(Me.components)
        Me.UltraTabPageControl2 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.ugb_datos = New Infragistics.Win.Misc.UltraGroupBox()
        Me.UltraLabel11 = New Infragistics.Win.Misc.UltraLabel()
        Me.ucbo_Turno = New Infragistics.Win.UltraWinEditors.UltraComboEditor()
        Me.ugb_Dias = New Infragistics.Win.Misc.UltraGroupBox()
        Me.uck_Lunes = New Infragistics.Win.UltraWinEditors.UltraCheckEditor()
        Me.uck_Miercoles = New Infragistics.Win.UltraWinEditors.UltraCheckEditor()
        Me.uck_Viernes = New Infragistics.Win.UltraWinEditors.UltraCheckEditor()
        Me.uck_Sabado = New Infragistics.Win.UltraWinEditors.UltraCheckEditor()
        Me.uck_Domingo = New Infragistics.Win.UltraWinEditors.UltraCheckEditor()
        Me.uck_Jueves = New Infragistics.Win.UltraWinEditors.UltraCheckEditor()
        Me.uck_Martes = New Infragistics.Win.UltraWinEditors.UltraCheckEditor()
        Me.urb_Tipo = New Infragistics.Win.UltraWinEditors.UltraOptionSet()
        Me.UltraLabel10 = New Infragistics.Win.Misc.UltraLabel()
        Me.urb_Estado = New Infragistics.Win.UltraWinEditors.UltraOptionSet()
        Me.UltraLabel9 = New Infragistics.Win.Misc.UltraLabel()
        Me.une_cupos = New Infragistics.Win.UltraWinEditors.UltraNumericEditor()
        Me.uce_Servicio = New Infragistics.Win.UltraWinEditors.UltraComboEditor()
        Me.uce_Consultorio = New Infragistics.Win.UltraWinEditors.UltraComboEditor()
        Me.uce_Medico = New Infragistics.Win.UltraWinEditors.UltraComboEditor()
        Me.udte_fecha = New Infragistics.Win.UltraWinEditors.UltraDateTimeEditor()
        Me.UltraLabel7 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraLabel8 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraLabel3 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraLabel2 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraLabel1 = New Infragistics.Win.Misc.UltraLabel()
        Me.txt_idprogramacion = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.UltraLabel4 = New Infragistics.Win.Misc.UltraLabel()
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
        Me.utc_Program = New Infragistics.Win.UltraWinTabControl.UltraTabControl()
        Me.UltraTabSharedControlsPage1 = New Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage()
        Me.UltraTabPageControl1.SuspendLayout()
        CType(Me.ug_Programacion, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.uds_Programacion, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabPageControl2.SuspendLayout()
        CType(Me.ugb_datos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ugb_datos.SuspendLayout()
        CType(Me.ucbo_Turno, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ugb_Dias, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ugb_Dias.SuspendLayout()
        CType(Me.urb_Tipo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.urb_Estado, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.une_cupos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.uce_Servicio, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.uce_Consultorio, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.uce_Medico, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.udte_fecha, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_idprogramacion, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolS_Mantenimiento.SuspendLayout()
        CType(Me.utc_Program, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.utc_Program.SuspendLayout()
        Me.SuspendLayout()
        '
        'UltraTabPageControl1
        '
        Me.UltraTabPageControl1.Controls.Add(Me.ug_Programacion)
        Me.UltraTabPageControl1.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl1.Name = "UltraTabPageControl1"
        Me.UltraTabPageControl1.Size = New System.Drawing.Size(722, 345)
        '
        'ug_Programacion
        '
        Me.ug_Programacion.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ug_Programacion.DataSource = Me.uds_Programacion
        Me.ug_Programacion.DisplayLayout.AutoFitStyle = Infragistics.Win.UltraWinGrid.AutoFitStyle.ExtendLastColumn
        UltraGridColumn1.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn1.Header.VisiblePosition = 0
        UltraGridColumn1.Hidden = True
        UltraGridColumn2.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn2.Header.VisiblePosition = 1
        UltraGridColumn2.Hidden = True
        UltraGridColumn3.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn3.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn3.Header.Caption = "MEDICO"
        UltraGridColumn3.Header.VisiblePosition = 2
        UltraGridColumn3.Width = 210
        UltraGridColumn4.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn4.Header.VisiblePosition = 3
        UltraGridColumn4.Hidden = True
        UltraGridColumn5.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn5.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn5.Header.Caption = "CONSULTORIO"
        UltraGridColumn5.Header.VisiblePosition = 4
        UltraGridColumn5.Width = 55
        UltraGridColumn6.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn6.Header.VisiblePosition = 5
        UltraGridColumn6.Hidden = True
        UltraGridColumn7.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn7.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn7.Header.Caption = "SERVICIO MED."
        UltraGridColumn7.Header.VisiblePosition = 6
        UltraGridColumn7.Width = 105
        UltraGridColumn8.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn8.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn8.Header.Caption = "INICIO"
        UltraGridColumn8.Header.VisiblePosition = 7
        UltraGridColumn8.Width = 45
        UltraGridColumn9.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn9.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn9.Header.Caption = "FIN"
        UltraGridColumn9.Header.VisiblePosition = 8
        UltraGridColumn9.Width = 44
        UltraGridColumn10.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn10.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn10.Header.Caption = "FECHA"
        UltraGridColumn10.Header.VisiblePosition = 9
        UltraGridColumn10.Width = 93
        UltraGridColumn11.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn11.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn11.Header.VisiblePosition = 10
        UltraGridColumn12.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn12.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn12.Header.Caption = "CUPOS"
        UltraGridColumn12.Header.VisiblePosition = 11
        UltraGridColumn12.Width = 45
        UltraGridColumn13.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn13.Header.VisiblePosition = 12
        UltraGridColumn13.Hidden = True
        UltraGridColumn14.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn14.Header.VisiblePosition = 13
        UltraGridColumn14.Hidden = True
        UltraGridColumn15.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn15.Header.VisiblePosition = 14
        UltraGridColumn15.Hidden = True
        UltraGridBand1.Columns.AddRange(New Object() {UltraGridColumn1, UltraGridColumn2, UltraGridColumn3, UltraGridColumn4, UltraGridColumn5, UltraGridColumn6, UltraGridColumn7, UltraGridColumn8, UltraGridColumn9, UltraGridColumn10, UltraGridColumn11, UltraGridColumn12, UltraGridColumn13, UltraGridColumn14, UltraGridColumn15})
        Me.ug_Programacion.DisplayLayout.BandsSerializer.Add(UltraGridBand1)
        Me.ug_Programacion.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.[False]
        Me.ug_Programacion.DisplayLayout.MaxColScrollRegions = 1
        Me.ug_Programacion.DisplayLayout.MaxRowScrollRegions = 1
        Me.ug_Programacion.DisplayLayout.Override.FilterUIType = Infragistics.Win.UltraWinGrid.FilterUIType.FilterRow
        Appearance9.BackColor = System.Drawing.Color.WhiteSmoke
        Appearance9.BackColor2 = System.Drawing.Color.WhiteSmoke
        Me.ug_Programacion.DisplayLayout.Override.RowAlternateAppearance = Appearance9
        Me.ug_Programacion.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.ug_Programacion.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.ug_Programacion.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ug_Programacion.Location = New System.Drawing.Point(0, 0)
        Me.ug_Programacion.Name = "ug_Programacion"
        Me.ug_Programacion.Size = New System.Drawing.Size(722, 345)
        Me.ug_Programacion.TabIndex = 0
        Me.ug_Programacion.Text = "UltraGrid1"
        '
        'uds_Programacion
        '
        Me.uds_Programacion.AllowDelete = False
        UltraDataColumn1.DataType = GetType(Long)
        UltraDataColumn10.DataType = GetType(Date)
        UltraDataColumn14.DataType = GetType(Integer)
        UltraDataColumn15.DataType = GetType(Integer)
        Me.uds_Programacion.Band.Columns.AddRange(New Object() {UltraDataColumn1, UltraDataColumn2, UltraDataColumn3, UltraDataColumn4, UltraDataColumn5, UltraDataColumn6, UltraDataColumn7, UltraDataColumn8, UltraDataColumn9, UltraDataColumn10, UltraDataColumn11, UltraDataColumn12, UltraDataColumn13, UltraDataColumn14, UltraDataColumn15})
        '
        'UltraTabPageControl2
        '
        Me.UltraTabPageControl2.Controls.Add(Me.ugb_datos)
        Me.UltraTabPageControl2.Location = New System.Drawing.Point(1, 23)
        Me.UltraTabPageControl2.Name = "UltraTabPageControl2"
        Me.UltraTabPageControl2.Size = New System.Drawing.Size(722, 345)
        '
        'ugb_datos
        '
        Me.ugb_datos.Controls.Add(Me.UltraLabel11)
        Me.ugb_datos.Controls.Add(Me.ucbo_Turno)
        Me.ugb_datos.Controls.Add(Me.ugb_Dias)
        Me.ugb_datos.Controls.Add(Me.urb_Tipo)
        Me.ugb_datos.Controls.Add(Me.UltraLabel10)
        Me.ugb_datos.Controls.Add(Me.urb_Estado)
        Me.ugb_datos.Controls.Add(Me.UltraLabel9)
        Me.ugb_datos.Controls.Add(Me.une_cupos)
        Me.ugb_datos.Controls.Add(Me.uce_Servicio)
        Me.ugb_datos.Controls.Add(Me.uce_Consultorio)
        Me.ugb_datos.Controls.Add(Me.uce_Medico)
        Me.ugb_datos.Controls.Add(Me.udte_fecha)
        Me.ugb_datos.Controls.Add(Me.UltraLabel7)
        Me.ugb_datos.Controls.Add(Me.UltraLabel8)
        Me.ugb_datos.Controls.Add(Me.UltraLabel3)
        Me.ugb_datos.Controls.Add(Me.UltraLabel2)
        Me.ugb_datos.Controls.Add(Me.UltraLabel1)
        Me.ugb_datos.Controls.Add(Me.txt_idprogramacion)
        Me.ugb_datos.Controls.Add(Me.UltraLabel4)
        Me.ugb_datos.Location = New System.Drawing.Point(14, 28)
        Me.ugb_datos.Name = "ugb_datos"
        Me.ugb_datos.Size = New System.Drawing.Size(688, 294)
        Me.ugb_datos.TabIndex = 0
        '
        'UltraLabel11
        '
        Appearance2.BackColor = System.Drawing.Color.Transparent
        Appearance2.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel11.Appearance = Appearance2
        Me.UltraLabel11.AutoSize = True
        Me.UltraLabel11.Location = New System.Drawing.Point(199, 195)
        Me.UltraLabel11.Name = "UltraLabel11"
        Me.UltraLabel11.Size = New System.Drawing.Size(34, 14)
        Me.UltraLabel11.TabIndex = 36
        Me.UltraLabel11.Text = "Turno"
        '
        'ucbo_Turno
        '
        Me.ucbo_Turno.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.ucbo_Turno.Location = New System.Drawing.Point(236, 191)
        Me.ucbo_Turno.Name = "ucbo_Turno"
        Me.ucbo_Turno.Size = New System.Drawing.Size(110, 21)
        Me.ucbo_Turno.TabIndex = 7
        '
        'ugb_Dias
        '
        Me.ugb_Dias.Controls.Add(Me.uck_Lunes)
        Me.ugb_Dias.Controls.Add(Me.uck_Miercoles)
        Me.ugb_Dias.Controls.Add(Me.uck_Viernes)
        Me.ugb_Dias.Controls.Add(Me.uck_Sabado)
        Me.ugb_Dias.Controls.Add(Me.uck_Domingo)
        Me.ugb_Dias.Controls.Add(Me.uck_Jueves)
        Me.ugb_Dias.Controls.Add(Me.uck_Martes)
        Me.ugb_Dias.Location = New System.Drawing.Point(408, 98)
        Me.ugb_Dias.Name = "ugb_Dias"
        Me.ugb_Dias.Size = New System.Drawing.Size(226, 119)
        Me.ugb_Dias.TabIndex = 34
        '
        'uck_Lunes
        '
        Me.uck_Lunes.BackColor = System.Drawing.Color.Transparent
        Me.uck_Lunes.BackColorInternal = System.Drawing.Color.Transparent
        Me.uck_Lunes.Location = New System.Drawing.Point(15, 9)
        Me.uck_Lunes.Name = "uck_Lunes"
        Me.uck_Lunes.Size = New System.Drawing.Size(66, 20)
        Me.uck_Lunes.TabIndex = 9
        Me.uck_Lunes.Text = "Lunes"
        '
        'uck_Miercoles
        '
        Me.uck_Miercoles.BackColor = System.Drawing.Color.Transparent
        Me.uck_Miercoles.BackColorInternal = System.Drawing.Color.Transparent
        Me.uck_Miercoles.Location = New System.Drawing.Point(15, 63)
        Me.uck_Miercoles.Name = "uck_Miercoles"
        Me.uck_Miercoles.Size = New System.Drawing.Size(83, 20)
        Me.uck_Miercoles.TabIndex = 11
        Me.uck_Miercoles.Text = "Miercoles"
        '
        'uck_Viernes
        '
        Me.uck_Viernes.BackColor = System.Drawing.Color.Transparent
        Me.uck_Viernes.BackColorInternal = System.Drawing.Color.Transparent
        Me.uck_Viernes.Location = New System.Drawing.Point(135, 9)
        Me.uck_Viernes.Name = "uck_Viernes"
        Me.uck_Viernes.Size = New System.Drawing.Size(66, 20)
        Me.uck_Viernes.TabIndex = 13
        Me.uck_Viernes.Text = "Viernes"
        '
        'uck_Sabado
        '
        Me.uck_Sabado.BackColor = System.Drawing.Color.Transparent
        Me.uck_Sabado.BackColorInternal = System.Drawing.Color.Transparent
        Me.uck_Sabado.Location = New System.Drawing.Point(135, 36)
        Me.uck_Sabado.Name = "uck_Sabado"
        Me.uck_Sabado.Size = New System.Drawing.Size(83, 20)
        Me.uck_Sabado.TabIndex = 14
        Me.uck_Sabado.Text = "Sabado"
        '
        'uck_Domingo
        '
        Me.uck_Domingo.BackColor = System.Drawing.Color.Transparent
        Me.uck_Domingo.BackColorInternal = System.Drawing.Color.Transparent
        Me.uck_Domingo.Location = New System.Drawing.Point(135, 63)
        Me.uck_Domingo.Name = "uck_Domingo"
        Me.uck_Domingo.Size = New System.Drawing.Size(83, 20)
        Me.uck_Domingo.TabIndex = 15
        Me.uck_Domingo.Text = "Domingo"
        '
        'uck_Jueves
        '
        Me.uck_Jueves.BackColor = System.Drawing.Color.Transparent
        Me.uck_Jueves.BackColorInternal = System.Drawing.Color.Transparent
        Me.uck_Jueves.Location = New System.Drawing.Point(15, 90)
        Me.uck_Jueves.Name = "uck_Jueves"
        Me.uck_Jueves.Size = New System.Drawing.Size(83, 20)
        Me.uck_Jueves.TabIndex = 12
        Me.uck_Jueves.Text = "Jueves"
        '
        'uck_Martes
        '
        Me.uck_Martes.BackColor = System.Drawing.Color.Transparent
        Me.uck_Martes.BackColorInternal = System.Drawing.Color.Transparent
        Me.uck_Martes.Location = New System.Drawing.Point(15, 36)
        Me.uck_Martes.Name = "uck_Martes"
        Me.uck_Martes.Size = New System.Drawing.Size(83, 20)
        Me.uck_Martes.TabIndex = 10
        Me.uck_Martes.Text = "Martes"
        '
        'urb_Tipo
        '
        Me.urb_Tipo.BackColor = System.Drawing.Color.Transparent
        Me.urb_Tipo.BackColorInternal = System.Drawing.Color.Transparent
        Me.urb_Tipo.BorderStyle = Infragistics.Win.UIElementBorderStyle.None
        ValueListItem1.DataValue = 1
        ValueListItem1.DisplayText = "Por Días"
        ValueListItem2.DataValue = 0
        ValueListItem2.DisplayText = "Por Fecha"
        Me.urb_Tipo.Items.AddRange(New Infragistics.Win.ValueListItem() {ValueListItem1, ValueListItem2})
        Me.urb_Tipo.Location = New System.Drawing.Point(486, 66)
        Me.urb_Tipo.Name = "urb_Tipo"
        Me.urb_Tipo.Size = New System.Drawing.Size(173, 26)
        Me.urb_Tipo.TabIndex = 8
        '
        'UltraLabel10
        '
        Appearance7.BackColor = System.Drawing.Color.Transparent
        Appearance7.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel10.Appearance = Appearance7
        Me.UltraLabel10.AutoSize = True
        Me.UltraLabel10.Location = New System.Drawing.Point(408, 66)
        Me.UltraLabel10.Name = "UltraLabel10"
        Me.UltraLabel10.Size = New System.Drawing.Size(67, 14)
        Me.UltraLabel10.TabIndex = 33
        Me.UltraLabel10.Text = "Programado"
        '
        'urb_Estado
        '
        Me.urb_Estado.BackColor = System.Drawing.Color.Transparent
        Me.urb_Estado.BackColorInternal = System.Drawing.Color.Transparent
        Me.urb_Estado.BorderStyle = Infragistics.Win.UIElementBorderStyle.None
        ValueListItem5.DataValue = 1
        ValueListItem5.DisplayText = "Activo"
        ValueListItem6.DataValue = 0
        ValueListItem6.DisplayText = "Inactivo"
        Me.urb_Estado.Items.AddRange(New Infragistics.Win.ValueListItem() {ValueListItem5, ValueListItem6})
        Me.urb_Estado.Location = New System.Drawing.Point(482, 245)
        Me.urb_Estado.Name = "urb_Estado"
        Me.urb_Estado.Size = New System.Drawing.Size(138, 26)
        Me.urb_Estado.TabIndex = 16
        '
        'UltraLabel9
        '
        Appearance10.BackColor = System.Drawing.Color.Transparent
        Appearance10.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel9.Appearance = Appearance10
        Me.UltraLabel9.AutoSize = True
        Me.UltraLabel9.Location = New System.Drawing.Point(421, 244)
        Me.UltraLabel9.Name = "UltraLabel9"
        Me.UltraLabel9.Size = New System.Drawing.Size(39, 14)
        Me.UltraLabel9.TabIndex = 24
        Me.UltraLabel9.Text = "Estado"
        '
        'une_cupos
        '
        Me.une_cupos.Location = New System.Drawing.Point(100, 191)
        Me.une_cupos.MaskInput = "nn"
        Me.une_cupos.Name = "une_cupos"
        Me.une_cupos.Size = New System.Drawing.Size(36, 21)
        Me.une_cupos.TabIndex = 6
        '
        'uce_Servicio
        '
        Me.uce_Servicio.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.uce_Servicio.Location = New System.Drawing.Point(100, 160)
        Me.uce_Servicio.Name = "uce_Servicio"
        Me.uce_Servicio.ReadOnly = True
        Me.uce_Servicio.Size = New System.Drawing.Size(246, 21)
        Me.uce_Servicio.TabIndex = 3
        '
        'uce_Consultorio
        '
        Me.uce_Consultorio.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.uce_Consultorio.Location = New System.Drawing.Point(100, 128)
        Me.uce_Consultorio.Name = "uce_Consultorio"
        Me.uce_Consultorio.Size = New System.Drawing.Size(246, 21)
        Me.uce_Consultorio.TabIndex = 2
        '
        'uce_Medico
        '
        Me.uce_Medico.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.uce_Medico.Location = New System.Drawing.Point(100, 97)
        Me.uce_Medico.Name = "uce_Medico"
        Me.uce_Medico.Size = New System.Drawing.Size(246, 21)
        Me.uce_Medico.TabIndex = 1
        '
        'udte_fecha
        '
        Me.udte_fecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.udte_fecha.Location = New System.Drawing.Point(100, 62)
        Me.udte_fecha.Name = "udte_fecha"
        Me.udte_fecha.Size = New System.Drawing.Size(132, 24)
        Me.udte_fecha.TabIndex = 0
        '
        'UltraLabel7
        '
        Appearance21.BackColor = System.Drawing.Color.Transparent
        Appearance21.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel7.Appearance = Appearance21
        Me.UltraLabel7.AutoSize = True
        Me.UltraLabel7.Location = New System.Drawing.Point(58, 68)
        Me.UltraLabel7.Name = "UltraLabel7"
        Me.UltraLabel7.Size = New System.Drawing.Size(36, 14)
        Me.UltraLabel7.TabIndex = 23
        Me.UltraLabel7.Text = "Fecha"
        '
        'UltraLabel8
        '
        Appearance1.BackColor = System.Drawing.Color.Transparent
        Appearance1.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel8.Appearance = Appearance1
        Me.UltraLabel8.AutoSize = True
        Me.UltraLabel8.Location = New System.Drawing.Point(57, 194)
        Me.UltraLabel8.Name = "UltraLabel8"
        Me.UltraLabel8.Size = New System.Drawing.Size(37, 14)
        Me.UltraLabel8.TabIndex = 23
        Me.UltraLabel8.Text = "Cupos"
        '
        'UltraLabel3
        '
        Appearance4.BackColor = System.Drawing.Color.Transparent
        Appearance4.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel3.Appearance = Appearance4
        Me.UltraLabel3.AutoSize = True
        Me.UltraLabel3.Location = New System.Drawing.Point(48, 164)
        Me.UltraLabel3.Name = "UltraLabel3"
        Me.UltraLabel3.Size = New System.Drawing.Size(45, 14)
        Me.UltraLabel3.TabIndex = 23
        Me.UltraLabel3.Text = "Servicio"
        '
        'UltraLabel2
        '
        Appearance5.BackColor = System.Drawing.Color.Transparent
        Appearance5.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel2.Appearance = Appearance5
        Me.UltraLabel2.AutoSize = True
        Me.UltraLabel2.Location = New System.Drawing.Point(31, 135)
        Me.UltraLabel2.Name = "UltraLabel2"
        Me.UltraLabel2.Size = New System.Drawing.Size(62, 14)
        Me.UltraLabel2.TabIndex = 23
        Me.UltraLabel2.Text = "Consultorio"
        '
        'UltraLabel1
        '
        Appearance6.BackColor = System.Drawing.Color.Transparent
        Appearance6.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel1.Appearance = Appearance6
        Me.UltraLabel1.AutoSize = True
        Me.UltraLabel1.Location = New System.Drawing.Point(52, 104)
        Me.UltraLabel1.Name = "UltraLabel1"
        Me.UltraLabel1.Size = New System.Drawing.Size(41, 14)
        Me.UltraLabel1.TabIndex = 23
        Me.UltraLabel1.Text = "Medico"
        '
        'txt_idprogramacion
        '
        Me.txt_idprogramacion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_idprogramacion.Location = New System.Drawing.Point(100, 28)
        Me.txt_idprogramacion.MaxLength = 50
        Me.txt_idprogramacion.Name = "txt_idprogramacion"
        Me.txt_idprogramacion.ReadOnly = True
        Me.txt_idprogramacion.Size = New System.Drawing.Size(132, 21)
        Me.txt_idprogramacion.TabIndex = 17
        '
        'UltraLabel4
        '
        Appearance8.BackColor = System.Drawing.Color.Transparent
        Appearance8.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel4.Appearance = Appearance8
        Me.UltraLabel4.AutoSize = True
        Me.UltraLabel4.Location = New System.Drawing.Point(54, 32)
        Me.UltraLabel4.Name = "UltraLabel4"
        Me.UltraLabel4.Size = New System.Drawing.Size(40, 14)
        Me.UltraLabel4.TabIndex = 23
        Me.UltraLabel4.Text = "Codigo"
        '
        'ToolS_Mantenimiento
        '
        Me.ToolS_Mantenimiento.BackColor = System.Drawing.Color.White
        Me.ToolS_Mantenimiento.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Tool_Nuevo, Me.ToolStripSeparator1, Me.Tool_Grabar, Me.ToolStripSeparator3, Me.Tool_Editar, Me.ToolStripSeparator4, Me.Tool_Cancelar, Me.ToolStripSeparator2, Me.Tool_Eliminar, Me.ToolStripSeparator5, Me.Tool_Salir})
        Me.ToolS_Mantenimiento.Location = New System.Drawing.Point(0, 0)
        Me.ToolS_Mantenimiento.Name = "ToolS_Mantenimiento"
        Me.ToolS_Mantenimiento.Size = New System.Drawing.Size(730, 25)
        Me.ToolS_Mantenimiento.TabIndex = 9
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
        'utc_Program
        '
        Me.utc_Program.Controls.Add(Me.UltraTabSharedControlsPage1)
        Me.utc_Program.Controls.Add(Me.UltraTabPageControl1)
        Me.utc_Program.Controls.Add(Me.UltraTabPageControl2)
        Me.utc_Program.Location = New System.Drawing.Point(3, 30)
        Me.utc_Program.Name = "utc_Program"
        Me.utc_Program.SharedControlsPage = Me.UltraTabSharedControlsPage1
        Me.utc_Program.Size = New System.Drawing.Size(726, 371)
        Me.utc_Program.TabIndex = 10
        UltraTab1.TabPage = Me.UltraTabPageControl1
        UltraTab1.Text = "Lista de Programaciones"
        UltraTab2.TabPage = Me.UltraTabPageControl2
        UltraTab2.Text = "Ingreso / Edicion de Datos"
        Me.utc_Program.Tabs.AddRange(New Infragistics.Win.UltraWinTabControl.UltraTab() {UltraTab1, UltraTab2})
        '
        'UltraTabSharedControlsPage1
        '
        Me.UltraTabSharedControlsPage1.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabSharedControlsPage1.Name = "UltraTabSharedControlsPage1"
        Me.UltraTabSharedControlsPage1.Size = New System.Drawing.Size(722, 345)
        '
        'AD_PR_ProgramacionEmerg
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(730, 403)
        Me.Controls.Add(Me.utc_Program)
        Me.Controls.Add(Me.ToolS_Mantenimiento)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "AD_PR_ProgramacionEmerg"
        Me.Text = "Programacion de Agenda"
        Me.UltraTabPageControl1.ResumeLayout(False)
        CType(Me.ug_Programacion, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.uds_Programacion, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabPageControl2.ResumeLayout(False)
        CType(Me.ugb_datos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ugb_datos.ResumeLayout(False)
        Me.ugb_datos.PerformLayout()
        CType(Me.ucbo_Turno, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ugb_Dias, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ugb_Dias.ResumeLayout(False)
        CType(Me.urb_Tipo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.urb_Estado, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.une_cupos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.uce_Servicio, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.uce_Consultorio, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.uce_Medico, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.udte_fecha, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_idprogramacion, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolS_Mantenimiento.ResumeLayout(False)
        Me.ToolS_Mantenimiento.PerformLayout()
        CType(Me.utc_Program, System.ComponentModel.ISupportInitialize).EndInit()
        Me.utc_Program.ResumeLayout(False)
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
    Friend WithEvents utc_Program As Infragistics.Win.UltraWinTabControl.UltraTabControl
    Friend WithEvents UltraTabSharedControlsPage1 As Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage
    Friend WithEvents UltraTabPageControl1 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents UltraTabPageControl2 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents ug_Programacion As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents ugb_datos As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents txt_idprogramacion As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents UltraLabel4 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents une_cupos As Infragistics.Win.UltraWinEditors.UltraNumericEditor
    Friend WithEvents uce_Servicio As Infragistics.Win.UltraWinEditors.UltraComboEditor
    Friend WithEvents uce_Consultorio As Infragistics.Win.UltraWinEditors.UltraComboEditor
    Friend WithEvents uce_Medico As Infragistics.Win.UltraWinEditors.UltraComboEditor
    Friend WithEvents udte_fecha As Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
    Friend WithEvents UltraLabel7 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel8 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel3 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel2 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel1 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents uds_Programacion As Infragistics.Win.UltraWinDataSource.UltraDataSource
    Friend WithEvents urb_Estado As Infragistics.Win.UltraWinEditors.UltraOptionSet
    Friend WithEvents UltraLabel9 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents uck_Sabado As Infragistics.Win.UltraWinEditors.UltraCheckEditor
    Friend WithEvents uck_Jueves As Infragistics.Win.UltraWinEditors.UltraCheckEditor
    Friend WithEvents uck_Martes As Infragistics.Win.UltraWinEditors.UltraCheckEditor
    Friend WithEvents uck_Domingo As Infragistics.Win.UltraWinEditors.UltraCheckEditor
    Friend WithEvents uck_Viernes As Infragistics.Win.UltraWinEditors.UltraCheckEditor
    Friend WithEvents uck_Miercoles As Infragistics.Win.UltraWinEditors.UltraCheckEditor
    Friend WithEvents uck_Lunes As Infragistics.Win.UltraWinEditors.UltraCheckEditor
    Friend WithEvents urb_Tipo As Infragistics.Win.UltraWinEditors.UltraOptionSet
    Friend WithEvents UltraLabel10 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents ugb_Dias As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents UltraLabel11 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents ucbo_Turno As Infragistics.Win.UltraWinEditors.UltraComboEditor
End Class
