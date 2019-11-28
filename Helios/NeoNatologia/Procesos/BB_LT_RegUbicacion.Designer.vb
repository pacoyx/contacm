<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BB_LT_RegUbicacion
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
        Dim Appearance4 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance3 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridBand1 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1)
        Dim UltraGridColumn1 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CB_ITEM")
        Dim UltraGridColumn2 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CB_IDARTICULO")
        Dim UltraGridColumn3 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CB_IDUBICACION")
        Dim UltraGridColumn4 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("UB_NOMBRE")
        Dim UltraGridColumn5 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CB_FECHA")
        Dim UltraGridColumn6 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CB_HORA_INI")
        Dim UltraGridColumn7 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CB_HORA_FIN")
        Dim UltraGridColumn8 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CB_OBSERVACION")
        Dim UltraGridColumn9 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CB_ESTADO")
        Dim UltraGridColumn10 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CB_TOTAL_HORAS")
        Dim Appearance9 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraDataColumn1 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("CB_ITEM")
        Dim UltraDataColumn2 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("CB_IDARTICULO")
        Dim UltraDataColumn3 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("CB_IDUBICACION")
        Dim UltraDataColumn4 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("UB_NOMBRE")
        Dim UltraDataColumn5 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("CB_FECHA")
        Dim UltraDataColumn6 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("CB_HORA_INI")
        Dim UltraDataColumn7 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("CB_HORA_FIN")
        Dim UltraDataColumn8 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("CB_OBSERVACION")
        Dim UltraDataColumn9 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("CB_ESTADO")
        Dim UltraDataColumn10 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("CB_TOTAL_HORAS")
        Dim Appearance7 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance5 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance13 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance1 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance2 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance33 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraTab1 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraTab2 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Me.UltraTabPageControl1 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.UltraLabel1 = New Infragistics.Win.Misc.UltraLabel()
        Me.txt_IDCUENTA = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.txt_idRegistro = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.txt_bebe = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.UltraLabel5 = New Infragistics.Win.Misc.UltraLabel()
        Me.ug_Lista = New Infragistics.Win.UltraWinGrid.UltraGrid()
        Me.uds_Lista = New Infragistics.Win.UltraWinDataSource.UltraDataSource(Me.components)
        Me.UltraTabPageControl2 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.ugb_Datos = New Infragistics.Win.Misc.UltraGroupBox()
        Me.utxt_TotalHoras = New Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit()
        Me.UltraLabel6 = New Infragistics.Win.Misc.UltraLabel()
        Me.txt_Observacion = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.UltraLabel13 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraLabel3 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraLabel2 = New Infragistics.Win.Misc.UltraLabel()
        Me.ume_horaFin = New Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit()
        Me.ume_Horainicio = New Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit()
        Me.txt_IdItem = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.UltraLabel9 = New Infragistics.Win.Misc.UltraLabel()
        Me.dtp_FechaIngreso = New System.Windows.Forms.DateTimePicker()
        Me.uce_Ubicacion = New Infragistics.Win.UltraWinEditors.UltraComboEditor()
        Me.UltraLabel10 = New Infragistics.Win.Misc.UltraLabel()
        Me.utc_Datos = New Infragistics.Win.UltraWinTabControl.UltraTabControl()
        Me.UltraTabSharedControlsPage1 = New Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage()
        Me.ToolS_Mantenimiento = New System.Windows.Forms.ToolStrip()
        Me.Tool_Nuevo = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.Tool_Grabar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.Tool_Editar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.Tool_Cancelar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.Tool_Eliminar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator()
        Me.Tool_Salir = New System.Windows.Forms.ToolStripButton()
        Me.UltraTabPageControl1.SuspendLayout()
        CType(Me.txt_IDCUENTA, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_idRegistro, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_bebe, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ug_Lista, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.uds_Lista, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabPageControl2.SuspendLayout()
        CType(Me.ugb_Datos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ugb_Datos.SuspendLayout()
        CType(Me.txt_Observacion, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_IdItem, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.uce_Ubicacion, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.utc_Datos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.utc_Datos.SuspendLayout()
        Me.ToolS_Mantenimiento.SuspendLayout()
        Me.SuspendLayout()
        '
        'UltraTabPageControl1
        '
        Me.UltraTabPageControl1.Controls.Add(Me.UltraLabel1)
        Me.UltraTabPageControl1.Controls.Add(Me.txt_IDCUENTA)
        Me.UltraTabPageControl1.Controls.Add(Me.txt_idRegistro)
        Me.UltraTabPageControl1.Controls.Add(Me.txt_bebe)
        Me.UltraTabPageControl1.Controls.Add(Me.UltraLabel5)
        Me.UltraTabPageControl1.Controls.Add(Me.ug_Lista)
        Me.UltraTabPageControl1.Location = New System.Drawing.Point(1, 23)
        Me.UltraTabPageControl1.Name = "UltraTabPageControl1"
        Me.UltraTabPageControl1.Size = New System.Drawing.Size(610, 252)
        '
        'UltraLabel1
        '
        Appearance4.BackColor = System.Drawing.Color.Transparent
        Appearance4.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel1.Appearance = Appearance4
        Me.UltraLabel1.AutoSize = True
        Me.UltraLabel1.Location = New System.Drawing.Point(470, 8)
        Me.UltraLabel1.Name = "UltraLabel1"
        Me.UltraLabel1.Size = New System.Drawing.Size(56, 14)
        Me.UltraLabel1.TabIndex = 61
        Me.UltraLabel1.Text = "Nº Cuenta"
        '
        'txt_IDCUENTA
        '
        Me.txt_IDCUENTA.Location = New System.Drawing.Point(529, 4)
        Me.txt_IDCUENTA.MaxLength = 100
        Me.txt_IDCUENTA.Name = "txt_IDCUENTA"
        Me.txt_IDCUENTA.ReadOnly = True
        Me.txt_IDCUENTA.Size = New System.Drawing.Size(62, 21)
        Me.txt_IDCUENTA.TabIndex = 56
        '
        'txt_idRegistro
        '
        Me.txt_idRegistro.Location = New System.Drawing.Point(577, 4)
        Me.txt_idRegistro.MaxLength = 100
        Me.txt_idRegistro.Name = "txt_idRegistro"
        Me.txt_idRegistro.ReadOnly = True
        Me.txt_idRegistro.Size = New System.Drawing.Size(32, 21)
        Me.txt_idRegistro.TabIndex = 55
        Me.txt_idRegistro.Visible = False
        '
        'txt_bebe
        '
        Me.txt_bebe.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_bebe.Location = New System.Drawing.Point(121, 4)
        Me.txt_bebe.MaxLength = 100
        Me.txt_bebe.Name = "txt_bebe"
        Me.txt_bebe.ReadOnly = True
        Me.txt_bebe.Size = New System.Drawing.Size(333, 21)
        Me.txt_bebe.TabIndex = 52
        '
        'UltraLabel5
        '
        Appearance3.BackColor = System.Drawing.Color.Transparent
        Appearance3.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel5.Appearance = Appearance3
        Me.UltraLabel5.AutoSize = True
        Me.UltraLabel5.Location = New System.Drawing.Point(10, 8)
        Me.UltraLabel5.Name = "UltraLabel5"
        Me.UltraLabel5.Size = New System.Drawing.Size(92, 14)
        Me.UltraLabel5.TabIndex = 53
        Me.UltraLabel5.Text = "Nombre del Bebe"
        '
        'ug_Lista
        '
        Me.ug_Lista.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ug_Lista.DataSource = Me.uds_Lista
        Me.ug_Lista.DisplayLayout.AutoFitStyle = Infragistics.Win.UltraWinGrid.AutoFitStyle.ExtendLastColumn
        UltraGridColumn1.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn1.Header.Caption = "ITEM"
        UltraGridColumn1.Header.VisiblePosition = 0
        UltraGridColumn1.Width = 44
        UltraGridColumn2.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn2.Header.VisiblePosition = 1
        UltraGridColumn2.Hidden = True
        UltraGridColumn2.Width = 98
        UltraGridColumn3.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn3.Header.VisiblePosition = 2
        UltraGridColumn3.Hidden = True
        UltraGridColumn3.Width = 54
        UltraGridColumn4.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn4.Header.Caption = "UBICACION"
        UltraGridColumn4.Header.VisiblePosition = 3
        UltraGridColumn4.Width = 259
        UltraGridColumn5.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn5.Header.Caption = "FECHA"
        UltraGridColumn5.Header.VisiblePosition = 4
        UltraGridColumn5.Width = 96
        UltraGridColumn6.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn6.Header.Caption = "HORA INICIO"
        UltraGridColumn6.Header.VisiblePosition = 5
        UltraGridColumn6.Width = 92
        UltraGridColumn7.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn7.Header.Caption = "HORA FIN"
        UltraGridColumn7.Header.VisiblePosition = 6
        UltraGridColumn7.Width = 53
        UltraGridColumn8.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn8.Header.VisiblePosition = 7
        UltraGridColumn8.Hidden = True
        UltraGridColumn8.Width = 71
        UltraGridColumn9.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn9.Header.VisiblePosition = 8
        UltraGridColumn9.Hidden = True
        UltraGridColumn9.Width = 174
        UltraGridColumn10.Header.VisiblePosition = 9
        UltraGridColumn10.Hidden = True
        UltraGridBand1.Columns.AddRange(New Object() {UltraGridColumn1, UltraGridColumn2, UltraGridColumn3, UltraGridColumn4, UltraGridColumn5, UltraGridColumn6, UltraGridColumn7, UltraGridColumn8, UltraGridColumn9, UltraGridColumn10})
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
        Me.ug_Lista.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ug_Lista.Location = New System.Drawing.Point(2, 29)
        Me.ug_Lista.Name = "ug_Lista"
        Me.ug_Lista.Size = New System.Drawing.Size(605, 221)
        Me.ug_Lista.TabIndex = 0
        Me.ug_Lista.Text = "UltraGrid1"
        '
        'uds_Lista
        '
        Me.uds_Lista.AllowDelete = False
        UltraDataColumn1.DataType = GetType(Long)
        UltraDataColumn2.DataType = GetType(Integer)
        UltraDataColumn3.DataType = GetType(Integer)
        UltraDataColumn9.DataType = GetType(Integer)
        Me.uds_Lista.Band.Columns.AddRange(New Object() {UltraDataColumn1, UltraDataColumn2, UltraDataColumn3, UltraDataColumn4, UltraDataColumn5, UltraDataColumn6, UltraDataColumn7, UltraDataColumn8, UltraDataColumn9, UltraDataColumn10})
        '
        'UltraTabPageControl2
        '
        Me.UltraTabPageControl2.Controls.Add(Me.ugb_Datos)
        Me.UltraTabPageControl2.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl2.Name = "UltraTabPageControl2"
        Me.UltraTabPageControl2.Size = New System.Drawing.Size(610, 252)
        '
        'ugb_Datos
        '
        Me.ugb_Datos.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ugb_Datos.Controls.Add(Me.utxt_TotalHoras)
        Me.ugb_Datos.Controls.Add(Me.UltraLabel6)
        Me.ugb_Datos.Controls.Add(Me.txt_Observacion)
        Me.ugb_Datos.Controls.Add(Me.UltraLabel13)
        Me.ugb_Datos.Controls.Add(Me.UltraLabel3)
        Me.ugb_Datos.Controls.Add(Me.UltraLabel2)
        Me.ugb_Datos.Controls.Add(Me.ume_horaFin)
        Me.ugb_Datos.Controls.Add(Me.ume_Horainicio)
        Me.ugb_Datos.Controls.Add(Me.txt_IdItem)
        Me.ugb_Datos.Controls.Add(Me.UltraLabel9)
        Me.ugb_Datos.Controls.Add(Me.dtp_FechaIngreso)
        Me.ugb_Datos.Controls.Add(Me.uce_Ubicacion)
        Me.ugb_Datos.Controls.Add(Me.UltraLabel10)
        Me.ugb_Datos.Location = New System.Drawing.Point(-1, 1)
        Me.ugb_Datos.Name = "ugb_Datos"
        Me.ugb_Datos.Size = New System.Drawing.Size(615, 256)
        Me.ugb_Datos.TabIndex = 33
        '
        'utxt_TotalHoras
        '
        Me.utxt_TotalHoras.EditAs = Infragistics.Win.UltraWinMaskedEdit.EditAsType.UseSpecifiedMask
        Me.utxt_TotalHoras.InputMask = "{LOC}hh:mm"
        Me.utxt_TotalHoras.Location = New System.Drawing.Point(410, 131)
        Me.utxt_TotalHoras.Name = "utxt_TotalHoras"
        Me.utxt_TotalHoras.Size = New System.Drawing.Size(58, 20)
        Me.utxt_TotalHoras.TabIndex = 240
        Me.utxt_TotalHoras.Text = "UltraMaskedEdit1"
        '
        'UltraLabel6
        '
        Appearance7.BackColor = System.Drawing.Color.Transparent
        Appearance7.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel6.Appearance = Appearance7
        Me.UltraLabel6.AutoSize = True
        Me.UltraLabel6.Location = New System.Drawing.Point(338, 134)
        Me.UltraLabel6.Name = "UltraLabel6"
        Me.UltraLabel6.Size = New System.Drawing.Size(66, 14)
        Me.UltraLabel6.TabIndex = 239
        Me.UltraLabel6.Text = "Total Horas:"
        '
        'txt_Observacion
        '
        Me.txt_Observacion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_Observacion.Location = New System.Drawing.Point(105, 177)
        Me.txt_Observacion.MaxLength = 100
        Me.txt_Observacion.Name = "txt_Observacion"
        Me.txt_Observacion.Size = New System.Drawing.Size(421, 21)
        Me.txt_Observacion.TabIndex = 4
        '
        'UltraLabel13
        '
        Appearance5.BackColor = System.Drawing.Color.Transparent
        Appearance5.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel13.Appearance = Appearance5
        Me.UltraLabel13.AutoSize = True
        Me.UltraLabel13.Location = New System.Drawing.Point(33, 181)
        Me.UltraLabel13.Name = "UltraLabel13"
        Me.UltraLabel13.Size = New System.Drawing.Size(68, 14)
        Me.UltraLabel13.TabIndex = 230
        Me.UltraLabel13.Text = "Observacion"
        '
        'UltraLabel3
        '
        Appearance13.BackColor = System.Drawing.Color.Transparent
        Appearance13.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel3.Appearance = Appearance13
        Me.UltraLabel3.AutoSize = True
        Me.UltraLabel3.Location = New System.Drawing.Point(187, 134)
        Me.UltraLabel3.Name = "UltraLabel3"
        Me.UltraLabel3.Size = New System.Drawing.Size(51, 14)
        Me.UltraLabel3.TabIndex = 228
        Me.UltraLabel3.Text = "Hora Fin:"
        '
        'UltraLabel2
        '
        Appearance1.BackColor = System.Drawing.Color.Transparent
        Appearance1.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel2.Appearance = Appearance1
        Me.UltraLabel2.AutoSize = True
        Me.UltraLabel2.Location = New System.Drawing.Point(40, 134)
        Me.UltraLabel2.Name = "UltraLabel2"
        Me.UltraLabel2.Size = New System.Drawing.Size(61, 14)
        Me.UltraLabel2.TabIndex = 227
        Me.UltraLabel2.Text = "Hora Inicio:"
        '
        'ume_horaFin
        '
        Me.ume_horaFin.EditAs = Infragistics.Win.UltraWinMaskedEdit.EditAsType.UseSpecifiedMask
        Me.ume_horaFin.InputMask = "{LOC}hh:mm"
        Me.ume_horaFin.Location = New System.Drawing.Point(243, 131)
        Me.ume_horaFin.Name = "ume_horaFin"
        Me.ume_horaFin.Size = New System.Drawing.Size(45, 20)
        Me.ume_horaFin.TabIndex = 3
        Me.ume_horaFin.Text = "UltraMaskedEdit1"
        '
        'ume_Horainicio
        '
        Me.ume_Horainicio.EditAs = Infragistics.Win.UltraWinMaskedEdit.EditAsType.UseSpecifiedMask
        Me.ume_Horainicio.InputMask = "{LOC}hh:mm"
        Me.ume_Horainicio.Location = New System.Drawing.Point(105, 131)
        Me.ume_Horainicio.Name = "ume_Horainicio"
        Me.ume_Horainicio.Size = New System.Drawing.Size(45, 20)
        Me.ume_Horainicio.TabIndex = 2
        Me.ume_Horainicio.Text = "UltraMaskedEdit1"
        '
        'txt_IdItem
        '
        Me.txt_IdItem.Location = New System.Drawing.Point(561, 13)
        Me.txt_IdItem.MaxLength = 100
        Me.txt_IdItem.Name = "txt_IdItem"
        Me.txt_IdItem.ReadOnly = True
        Me.txt_IdItem.Size = New System.Drawing.Size(32, 21)
        Me.txt_IdItem.TabIndex = 224
        Me.txt_IdItem.Visible = False
        '
        'UltraLabel9
        '
        Appearance2.BackColor = System.Drawing.Color.Transparent
        Appearance2.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel9.Appearance = Appearance2
        Me.UltraLabel9.AutoSize = True
        Me.UltraLabel9.Location = New System.Drawing.Point(40, 90)
        Me.UltraLabel9.Name = "UltraLabel9"
        Me.UltraLabel9.Size = New System.Drawing.Size(36, 14)
        Me.UltraLabel9.TabIndex = 223
        Me.UltraLabel9.Text = "Fecha"
        '
        'dtp_FechaIngreso
        '
        Me.dtp_FechaIngreso.CustomFormat = "dd/MM/yyyy hh:mm tt"
        Me.dtp_FechaIngreso.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_FechaIngreso.Location = New System.Drawing.Point(105, 87)
        Me.dtp_FechaIngreso.Name = "dtp_FechaIngreso"
        Me.dtp_FechaIngreso.Size = New System.Drawing.Size(135, 20)
        Me.dtp_FechaIngreso.TabIndex = 1
        '
        'uce_Ubicacion
        '
        Me.uce_Ubicacion.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.uce_Ubicacion.Location = New System.Drawing.Point(105, 42)
        Me.uce_Ubicacion.Name = "uce_Ubicacion"
        Me.uce_Ubicacion.Size = New System.Drawing.Size(421, 21)
        Me.uce_Ubicacion.TabIndex = 0
        '
        'UltraLabel10
        '
        Appearance33.BackColor = System.Drawing.Color.Transparent
        Appearance33.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel10.Appearance = Appearance33
        Me.UltraLabel10.AutoSize = True
        Me.UltraLabel10.Location = New System.Drawing.Point(40, 46)
        Me.UltraLabel10.Name = "UltraLabel10"
        Me.UltraLabel10.Size = New System.Drawing.Size(54, 14)
        Me.UltraLabel10.TabIndex = 191
        Me.UltraLabel10.Text = "Ubicacion"
        '
        'utc_Datos
        '
        Me.utc_Datos.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.utc_Datos.Controls.Add(Me.UltraTabSharedControlsPage1)
        Me.utc_Datos.Controls.Add(Me.UltraTabPageControl1)
        Me.utc_Datos.Controls.Add(Me.UltraTabPageControl2)
        Me.utc_Datos.Location = New System.Drawing.Point(1, 28)
        Me.utc_Datos.Name = "utc_Datos"
        Me.utc_Datos.SharedControlsPage = Me.UltraTabSharedControlsPage1
        Me.utc_Datos.Size = New System.Drawing.Size(614, 278)
        Me.utc_Datos.TabIndex = 188
        UltraTab1.TabPage = Me.UltraTabPageControl1
        UltraTab1.Text = "Lista de Consumo"
        UltraTab2.TabPage = Me.UltraTabPageControl2
        UltraTab2.Text = "Ingreso / Edicion de Datos"
        Me.utc_Datos.Tabs.AddRange(New Infragistics.Win.UltraWinTabControl.UltraTab() {UltraTab1, UltraTab2})
        '
        'UltraTabSharedControlsPage1
        '
        Me.UltraTabSharedControlsPage1.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabSharedControlsPage1.Name = "UltraTabSharedControlsPage1"
        Me.UltraTabSharedControlsPage1.Size = New System.Drawing.Size(610, 252)
        '
        'ToolS_Mantenimiento
        '
        Me.ToolS_Mantenimiento.BackColor = System.Drawing.Color.White
        Me.ToolS_Mantenimiento.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Tool_Nuevo, Me.ToolStripSeparator1, Me.Tool_Grabar, Me.ToolStripSeparator4, Me.Tool_Editar, Me.ToolStripSeparator3, Me.Tool_Cancelar, Me.ToolStripSeparator2, Me.Tool_Eliminar, Me.ToolStripSeparator5, Me.Tool_Salir})
        Me.ToolS_Mantenimiento.Location = New System.Drawing.Point(0, 0)
        Me.ToolS_Mantenimiento.Name = "ToolS_Mantenimiento"
        Me.ToolS_Mantenimiento.Size = New System.Drawing.Size(615, 25)
        Me.ToolS_Mantenimiento.TabIndex = 187
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
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(6, 25)
        '
        'Tool_Editar
        '
        Me.Tool_Editar.Image = Global.Contabilidad.My.Resources.Resources._16__Card_edit_
        Me.Tool_Editar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Tool_Editar.Name = "Tool_Editar"
        Me.Tool_Editar.Size = New System.Drawing.Size(57, 22)
        Me.Tool_Editar.Text = "Editar"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 25)
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
        Me.Tool_Eliminar.Image = Global.Contabilidad.My.Resources.Resources._132
        Me.Tool_Eliminar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Tool_Eliminar.Name = "Tool_Eliminar"
        Me.Tool_Eliminar.Size = New System.Drawing.Size(62, 22)
        Me.Tool_Eliminar.Text = "Anular"
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
        'BB_LT_RegUbicacion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(615, 309)
        Me.Controls.Add(Me.utc_Datos)
        Me.Controls.Add(Me.ToolS_Mantenimiento)
        Me.Name = "BB_LT_RegUbicacion"
        Me.Text = "Registro de Ubicacion"
        Me.UltraTabPageControl1.ResumeLayout(False)
        Me.UltraTabPageControl1.PerformLayout()
        CType(Me.txt_IDCUENTA, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_idRegistro, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_bebe, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ug_Lista, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.uds_Lista, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabPageControl2.ResumeLayout(False)
        CType(Me.ugb_Datos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ugb_Datos.ResumeLayout(False)
        Me.ugb_Datos.PerformLayout()
        CType(Me.txt_Observacion, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_IdItem, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.uce_Ubicacion, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents ugb_Datos As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents uce_Ubicacion As Infragistics.Win.UltraWinEditors.UltraComboEditor
    Friend WithEvents UltraLabel10 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents ToolS_Mantenimiento As System.Windows.Forms.ToolStrip
    Friend WithEvents Tool_Nuevo As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents Tool_Grabar As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents Tool_Editar As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents Tool_Cancelar As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents Tool_Eliminar As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator5 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents Tool_Salir As System.Windows.Forms.ToolStripButton
    Friend WithEvents txt_idRegistro As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents txt_bebe As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents UltraLabel5 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents dtp_FechaIngreso As System.Windows.Forms.DateTimePicker
    Friend WithEvents UltraLabel9 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents txt_IdItem As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents UltraLabel3 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel2 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents ume_horaFin As Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit
    Friend WithEvents ume_Horainicio As Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit
    Friend WithEvents txt_Observacion As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents UltraLabel13 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents txt_IDCUENTA As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents UltraLabel1 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents utxt_TotalHoras As Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit
    Friend WithEvents UltraLabel6 As Infragistics.Win.Misc.UltraLabel
End Class
