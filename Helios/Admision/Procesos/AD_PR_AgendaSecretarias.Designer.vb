<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AD_PR_AgendaSecretarias
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
        Dim Appearance2 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridBand1 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1)
        Dim UltraGridColumn1 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CM_ID")
        Dim UltraGridColumn2 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("OM_ID")
        Dim UltraGridColumn3 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("value")
        Dim UltraGridColumn4 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Hora")
        Dim UltraGridColumn5 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("H. LLegada")
        Dim UltraGridColumn6 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("H. Atendida")
        Dim UltraGridColumn7 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Historia")
        Dim UltraGridColumn8 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Paciente")
        Dim UltraGridColumn9 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Nº DOC.")
        Dim UltraGridColumn10 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Estado")
        Dim UltraGridColumn11 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("PR_ID")
        Dim UltraGridColumn12 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CC_ID")
        Dim UltraGridColumn13 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("HC_TDOC")
        Dim UltraGridColumn14 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Medico")
        Dim UltraGridColumn15 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CM_OBSERVACIONES")
        Dim UltraGridColumn16 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("AR_Abreviado")
        Dim Appearance5 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraDataColumn1 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("CM_ID")
        Dim UltraDataColumn2 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("OM_ID")
        Dim UltraDataColumn3 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("value")
        Dim UltraDataColumn4 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Hora")
        Dim UltraDataColumn5 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("H. LLegada")
        Dim UltraDataColumn6 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("H. Atendida")
        Dim UltraDataColumn7 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Historia")
        Dim UltraDataColumn8 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Paciente")
        Dim UltraDataColumn9 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Nº DOC.")
        Dim UltraDataColumn10 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Estado")
        Dim UltraDataColumn11 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("PR_ID")
        Dim UltraDataColumn12 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("CC_ID")
        Dim UltraDataColumn13 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("HC_TDOC")
        Dim UltraDataColumn14 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Medico")
        Dim UltraDataColumn15 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("CM_OBSERVACIONES")
        Dim UltraDataColumn16 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("AR_Abreviado")
        Dim Appearance54 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance1 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance21 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Me.uce_Servicio = New Infragistics.Win.UltraWinEditors.UltraComboEditor()
        Me.uce_Medico = New Infragistics.Win.UltraWinEditors.UltraComboEditor()
        Me.UltraLabel3 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraLabel1 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraGroupBox1 = New Infragistics.Win.Misc.UltraGroupBox()
        Me.UltraLabel11 = New Infragistics.Win.Misc.UltraLabel()
        Me.ucbo_Turno = New Infragistics.Win.UltraWinEditors.UltraComboEditor()
        Me.ug_intervalos = New Infragistics.Win.UltraWinGrid.UltraGrid()
        Me.uds_intervalos = New Infragistics.Win.UltraWinDataSource.UltraDataSource(Me.components)
        Me.ubtn_Consultar = New Infragistics.Win.Misc.UltraButton()
        Me.UltraLabel6 = New Infragistics.Win.Misc.UltraLabel()
        Me.ubtn_s = New Infragistics.Win.Misc.UltraButton()
        Me.ubtn_a = New Infragistics.Win.Misc.UltraButton()
        Me.txt_idprogramacion = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.udte_fecha = New Infragistics.Win.UltraWinEditors.UltraDateTimeEditor()
        Me.UltraLabel7 = New Infragistics.Win.Misc.UltraLabel()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.ToolS_Mantenimiento = New System.Windows.Forms.ToolStrip()
        Me.Tool_Reserva = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.Tool_Postergar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.Tool_PasoConsulta = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.Tool_OcupacionMed = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator()
        Me.Tool_Receta = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.Tool_Salir = New System.Windows.Forms.ToolStripButton()
        CType(Me.uce_Servicio, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.uce_Medico, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UltraGroupBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraGroupBox1.SuspendLayout()
        CType(Me.ucbo_Turno, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ug_intervalos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.uds_intervalos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_idprogramacion, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.udte_fecha, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolS_Mantenimiento.SuspendLayout()
        Me.SuspendLayout()
        '
        'uce_Servicio
        '
        Me.uce_Servicio.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.uce_Servicio.Location = New System.Drawing.Point(365, 39)
        Me.uce_Servicio.Name = "uce_Servicio"
        Me.uce_Servicio.Size = New System.Drawing.Size(113, 21)
        Me.uce_Servicio.TabIndex = 1
        '
        'uce_Medico
        '
        Me.uce_Medico.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.uce_Medico.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.uce_Medico.Location = New System.Drawing.Point(528, 39)
        Me.uce_Medico.MaxDropDownItems = 12
        Me.uce_Medico.Name = "uce_Medico"
        Me.uce_Medico.Size = New System.Drawing.Size(196, 21)
        Me.uce_Medico.TabIndex = 2
        '
        'UltraLabel3
        '
        Appearance4.BackColor = System.Drawing.Color.Transparent
        Appearance4.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel3.Appearance = Appearance4
        Me.UltraLabel3.AutoSize = True
        Me.UltraLabel3.Location = New System.Drawing.Point(316, 43)
        Me.UltraLabel3.Name = "UltraLabel3"
        Me.UltraLabel3.Size = New System.Drawing.Size(45, 14)
        Me.UltraLabel3.TabIndex = 27
        Me.UltraLabel3.Text = "Servicio"
        '
        'UltraLabel1
        '
        Appearance3.BackColor = System.Drawing.Color.Transparent
        Appearance3.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel1.Appearance = Appearance3
        Me.UltraLabel1.AutoSize = True
        Me.UltraLabel1.Location = New System.Drawing.Point(483, 43)
        Me.UltraLabel1.Name = "UltraLabel1"
        Me.UltraLabel1.Size = New System.Drawing.Size(41, 14)
        Me.UltraLabel1.TabIndex = 26
        Me.UltraLabel1.Text = "Medico"
        '
        'UltraGroupBox1
        '
        Me.UltraGroupBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.UltraGroupBox1.Controls.Add(Me.UltraLabel11)
        Me.UltraGroupBox1.Controls.Add(Me.ucbo_Turno)
        Me.UltraGroupBox1.Controls.Add(Me.ug_intervalos)
        Me.UltraGroupBox1.Controls.Add(Me.ubtn_Consultar)
        Me.UltraGroupBox1.Controls.Add(Me.UltraLabel6)
        Me.UltraGroupBox1.Controls.Add(Me.ubtn_s)
        Me.UltraGroupBox1.Controls.Add(Me.ubtn_a)
        Me.UltraGroupBox1.Controls.Add(Me.txt_idprogramacion)
        Me.UltraGroupBox1.Controls.Add(Me.udte_fecha)
        Me.UltraGroupBox1.Controls.Add(Me.UltraLabel7)
        Me.UltraGroupBox1.Controls.Add(Me.uce_Servicio)
        Me.UltraGroupBox1.Controls.Add(Me.uce_Medico)
        Me.UltraGroupBox1.Controls.Add(Me.UltraLabel3)
        Me.UltraGroupBox1.Controls.Add(Me.UltraLabel1)
        Me.UltraGroupBox1.Location = New System.Drawing.Point(5, 28)
        Me.UltraGroupBox1.Name = "UltraGroupBox1"
        Me.UltraGroupBox1.Size = New System.Drawing.Size(791, 495)
        Me.UltraGroupBox1.TabIndex = 0
        '
        'UltraLabel11
        '
        Appearance2.BackColor = System.Drawing.Color.Transparent
        Appearance2.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel11.Appearance = Appearance2
        Me.UltraLabel11.AutoSize = True
        Me.UltraLabel11.Location = New System.Drawing.Point(196, 43)
        Me.UltraLabel11.Name = "UltraLabel11"
        Me.UltraLabel11.Size = New System.Drawing.Size(34, 14)
        Me.UltraLabel11.TabIndex = 38
        Me.UltraLabel11.Text = "Turno"
        '
        'ucbo_Turno
        '
        Me.ucbo_Turno.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.ucbo_Turno.Location = New System.Drawing.Point(233, 39)
        Me.ucbo_Turno.Name = "ucbo_Turno"
        Me.ucbo_Turno.Size = New System.Drawing.Size(78, 21)
        Me.ucbo_Turno.TabIndex = 37
        '
        'ug_intervalos
        '
        Me.ug_intervalos.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ug_intervalos.DataSource = Me.uds_intervalos
        Me.ug_intervalos.DisplayLayout.AutoFitStyle = Infragistics.Win.UltraWinGrid.AutoFitStyle.ExtendLastColumn
        UltraGridColumn1.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn1.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn1.Header.VisiblePosition = 0
        UltraGridColumn1.Hidden = True
        UltraGridColumn2.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn2.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn2.Header.VisiblePosition = 1
        UltraGridColumn2.Hidden = True
        UltraGridColumn3.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn3.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn3.Header.Caption = "Nº"
        UltraGridColumn3.Header.VisiblePosition = 2
        UltraGridColumn3.Width = 23
        UltraGridColumn4.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn4.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn4.Header.VisiblePosition = 3
        UltraGridColumn4.Width = 44
        UltraGridColumn5.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn5.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn5.Header.VisiblePosition = 4
        UltraGridColumn5.Width = 47
        UltraGridColumn6.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn6.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn6.Header.VisiblePosition = 5
        UltraGridColumn6.Width = 48
        UltraGridColumn7.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn7.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn7.Header.VisiblePosition = 6
        UltraGridColumn7.Width = 50
        UltraGridColumn8.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn8.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn8.Header.VisiblePosition = 7
        UltraGridColumn8.Width = 330
        UltraGridColumn9.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn9.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn9.Header.VisiblePosition = 8
        UltraGridColumn9.Hidden = True
        UltraGridColumn9.Width = 72
        UltraGridColumn10.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn10.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn10.Header.VisiblePosition = 9
        UltraGridColumn10.Width = 100
        UltraGridColumn11.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn11.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn11.Header.VisiblePosition = 10
        UltraGridColumn11.Hidden = True
        UltraGridColumn12.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn12.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn12.Header.Caption = "Cuenta"
        UltraGridColumn12.Header.VisiblePosition = 11
        UltraGridColumn12.Width = 90
        UltraGridColumn13.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn13.Header.VisiblePosition = 12
        UltraGridColumn13.Hidden = True
        UltraGridColumn14.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn14.Header.VisiblePosition = 13
        UltraGridColumn14.Hidden = True
        UltraGridColumn14.Width = 150
        UltraGridColumn15.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn15.Header.Caption = "Observaciones"
        UltraGridColumn15.Header.VisiblePosition = 14
        UltraGridColumn15.Hidden = True
        UltraGridColumn15.Width = 100
        UltraGridColumn16.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn16.Header.Caption = "Tipo"
        UltraGridColumn16.Header.VisiblePosition = 15
        UltraGridColumn16.Hidden = True
        UltraGridColumn16.Width = 40
        UltraGridBand1.Columns.AddRange(New Object() {UltraGridColumn1, UltraGridColumn2, UltraGridColumn3, UltraGridColumn4, UltraGridColumn5, UltraGridColumn6, UltraGridColumn7, UltraGridColumn8, UltraGridColumn9, UltraGridColumn10, UltraGridColumn11, UltraGridColumn12, UltraGridColumn13, UltraGridColumn14, UltraGridColumn15, UltraGridColumn16})
        Me.ug_intervalos.DisplayLayout.BandsSerializer.Add(UltraGridBand1)
        Me.ug_intervalos.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.[False]
        Me.ug_intervalos.DisplayLayout.MaxColScrollRegions = 1
        Me.ug_intervalos.DisplayLayout.MaxRowScrollRegions = 1
        Appearance5.BackColor = System.Drawing.Color.WhiteSmoke
        Appearance5.BackColor2 = System.Drawing.Color.WhiteSmoke
        Me.ug_intervalos.DisplayLayout.Override.RowAlternateAppearance = Appearance5
        Me.ug_intervalos.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.ug_intervalos.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.ug_intervalos.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ug_intervalos.Location = New System.Drawing.Point(8, 74)
        Me.ug_intervalos.Name = "ug_intervalos"
        Me.ug_intervalos.Size = New System.Drawing.Size(778, 415)
        Me.ug_intervalos.TabIndex = 36
        Me.ug_intervalos.Text = "UltraGrid1"
        '
        'uds_intervalos
        '
        Me.uds_intervalos.AllowDelete = False
        UltraDataColumn1.DataType = GetType(Integer)
        UltraDataColumn2.DataType = GetType(Integer)
        UltraDataColumn3.DataType = GetType(Integer)
        UltraDataColumn11.DataType = GetType(Integer)
        Me.uds_intervalos.Band.Columns.AddRange(New Object() {UltraDataColumn1, UltraDataColumn2, UltraDataColumn3, UltraDataColumn4, UltraDataColumn5, UltraDataColumn6, UltraDataColumn7, UltraDataColumn8, UltraDataColumn9, UltraDataColumn10, UltraDataColumn11, UltraDataColumn12, UltraDataColumn13, UltraDataColumn14, UltraDataColumn15, UltraDataColumn16})
        '
        'ubtn_Consultar
        '
        Me.ubtn_Consultar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Appearance54.FontData.SizeInPoints = 8.0!
        Appearance54.ImageHAlign = Infragistics.Win.HAlign.Center
        Me.ubtn_Consultar.Appearance = Appearance54
        Me.ubtn_Consultar.Location = New System.Drawing.Point(729, 38)
        Me.ubtn_Consultar.Name = "ubtn_Consultar"
        Me.ubtn_Consultar.Size = New System.Drawing.Size(59, 24)
        Me.ubtn_Consultar.TabIndex = 35
        Me.ubtn_Consultar.Text = "Consultar"
        '
        'UltraLabel6
        '
        Me.UltraLabel6.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Appearance1.BackColor = System.Drawing.Color.DeepSkyBlue
        Appearance1.ForeColor = System.Drawing.Color.White
        Appearance1.TextHAlignAsString = "Center"
        Me.UltraLabel6.Appearance = Appearance1
        Me.UltraLabel6.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel6.Location = New System.Drawing.Point(2, 2)
        Me.UltraLabel6.Name = "UltraLabel6"
        Me.UltraLabel6.Size = New System.Drawing.Size(787, 28)
        Me.UltraLabel6.TabIndex = 33
        Me.UltraLabel6.Text = "Agenda de Consultorio"
        '
        'ubtn_s
        '
        Me.ubtn_s.Location = New System.Drawing.Point(168, 36)
        Me.ubtn_s.Name = "ubtn_s"
        Me.ubtn_s.Size = New System.Drawing.Size(25, 25)
        Me.ubtn_s.TabIndex = 32
        '
        'ubtn_a
        '
        Me.ubtn_a.Location = New System.Drawing.Point(144, 36)
        Me.ubtn_a.Name = "ubtn_a"
        Me.ubtn_a.Size = New System.Drawing.Size(25, 25)
        Me.ubtn_a.TabIndex = 32
        '
        'txt_idprogramacion
        '
        Me.txt_idprogramacion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_idprogramacion.Location = New System.Drawing.Point(13, 60)
        Me.txt_idprogramacion.MaxLength = 50
        Me.txt_idprogramacion.Name = "txt_idprogramacion"
        Me.txt_idprogramacion.ReadOnly = True
        Me.txt_idprogramacion.Size = New System.Drawing.Size(20, 21)
        Me.txt_idprogramacion.TabIndex = 31
        Me.txt_idprogramacion.Visible = False
        '
        'udte_fecha
        '
        Me.udte_fecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.udte_fecha.Location = New System.Drawing.Point(48, 37)
        Me.udte_fecha.Name = "udte_fecha"
        Me.udte_fecha.Size = New System.Drawing.Size(97, 24)
        Me.udte_fecha.TabIndex = 0
        '
        'UltraLabel7
        '
        Appearance21.BackColor = System.Drawing.Color.Transparent
        Appearance21.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel7.Appearance = Appearance21
        Me.UltraLabel7.AutoSize = True
        Me.UltraLabel7.Location = New System.Drawing.Point(8, 43)
        Me.UltraLabel7.Name = "UltraLabel7"
        Me.UltraLabel7.Size = New System.Drawing.Size(36, 14)
        Me.UltraLabel7.TabIndex = 30
        Me.UltraLabel7.Text = "Fecha"
        '
        'Timer1
        '
        '
        'ToolS_Mantenimiento
        '
        Me.ToolS_Mantenimiento.BackColor = System.Drawing.Color.White
        Me.ToolS_Mantenimiento.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Tool_Reserva, Me.ToolStripSeparator1, Me.Tool_Postergar, Me.ToolStripSeparator3, Me.Tool_PasoConsulta, Me.ToolStripSeparator2, Me.Tool_OcupacionMed, Me.ToolStripSeparator5, Me.Tool_Receta, Me.ToolStripSeparator4, Me.Tool_Salir})
        Me.ToolS_Mantenimiento.Location = New System.Drawing.Point(0, 0)
        Me.ToolS_Mantenimiento.Name = "ToolS_Mantenimiento"
        Me.ToolS_Mantenimiento.Size = New System.Drawing.Size(800, 25)
        Me.ToolS_Mantenimiento.TabIndex = 11
        Me.ToolS_Mantenimiento.Text = "ToolStrip1"
        '
        'Tool_Reserva
        '
        Me.Tool_Reserva.Image = Global.Contabilidad.My.Resources.Resources._16__File_new_2_
        Me.Tool_Reserva.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Tool_Reserva.Name = "Tool_Reserva"
        Me.Tool_Reserva.Size = New System.Drawing.Size(95, 22)
        Me.Tool_Reserva.Text = "Reservar Cita"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'Tool_Postergar
        '
        Me.Tool_Postergar.Image = Global.Contabilidad.My.Resources.Resources.book_previous
        Me.Tool_Postergar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Tool_Postergar.Name = "Tool_Postergar"
        Me.Tool_Postergar.Size = New System.Drawing.Size(101, 22)
        Me.Tool_Postergar.Text = "Postergar Cita"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 25)
        '
        'Tool_PasoConsulta
        '
        Me.Tool_PasoConsulta.Image = Global.Contabilidad.My.Resources.Resources._16__Ok_
        Me.Tool_PasoConsulta.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Tool_PasoConsulta.Name = "Tool_PasoConsulta"
        Me.Tool_PasoConsulta.Size = New System.Drawing.Size(111, 22)
        Me.Tool_PasoConsulta.Text = "Paso a Consulta"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'Tool_OcupacionMed
        '
        Me.Tool_OcupacionMed.Image = Global.Contabilidad.My.Resources.Resources.user_add
        Me.Tool_OcupacionMed.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Tool_OcupacionMed.Name = "Tool_OcupacionMed"
        Me.Tool_OcupacionMed.Size = New System.Drawing.Size(146, 22)
        Me.Tool_OcupacionMed.Text = "Ocupaciones Medicas "
        '
        'ToolStripSeparator5
        '
        Me.ToolStripSeparator5.Name = "ToolStripSeparator5"
        Me.ToolStripSeparator5.Size = New System.Drawing.Size(6, 25)
        '
        'Tool_Receta
        '
        Me.Tool_Receta.Image = Global.Contabilidad.My.Resources.Resources._16__Options_
        Me.Tool_Receta.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Tool_Receta.Name = "Tool_Receta"
        Me.Tool_Receta.Size = New System.Drawing.Size(104, 22)
        Me.Tool_Receta.Text = "Receta Médica"
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(6, 25)
        '
        'Tool_Salir
        '
        Me.Tool_Salir.Image = Global.Contabilidad.My.Resources.Resources._28
        Me.Tool_Salir.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Tool_Salir.Name = "Tool_Salir"
        Me.Tool_Salir.Size = New System.Drawing.Size(49, 22)
        Me.Tool_Salir.Text = "Salir"
        '
        'AD_PR_AgendaSecretarias
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(800, 529)
        Me.Controls.Add(Me.ToolS_Mantenimiento)
        Me.Controls.Add(Me.UltraGroupBox1)
        Me.Name = "AD_PR_AgendaSecretarias"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Agenda de Citas - Consultorio"
        CType(Me.uce_Servicio, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.uce_Medico, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UltraGroupBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraGroupBox1.ResumeLayout(False)
        Me.UltraGroupBox1.PerformLayout()
        CType(Me.ucbo_Turno, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ug_intervalos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.uds_intervalos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_idprogramacion, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.udte_fecha, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolS_Mantenimiento.ResumeLayout(False)
        Me.ToolS_Mantenimiento.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents UltraLabel3 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel1 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraGroupBox1 As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents udte_fecha As Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
    Friend WithEvents UltraLabel7 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents uds_intervalos As Infragistics.Win.UltraWinDataSource.UltraDataSource
    Friend WithEvents ubtn_s As Infragistics.Win.Misc.UltraButton
    Friend WithEvents ubtn_a As Infragistics.Win.Misc.UltraButton
    Friend WithEvents UltraLabel6 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents ubtn_Consultar As Infragistics.Win.Misc.UltraButton
    Public WithEvents uce_Servicio As Infragistics.Win.UltraWinEditors.UltraComboEditor
    Public WithEvents uce_Medico As Infragistics.Win.UltraWinEditors.UltraComboEditor
    Public WithEvents ug_intervalos As Infragistics.Win.UltraWinGrid.UltraGrid
    Public WithEvents txt_idprogramacion As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents UltraLabel11 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents ucbo_Turno As Infragistics.Win.UltraWinEditors.UltraComboEditor
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents ToolS_Mantenimiento As System.Windows.Forms.ToolStrip
    Friend WithEvents Tool_Reserva As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents Tool_Postergar As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents Tool_PasoConsulta As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents Tool_OcupacionMed As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator5 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents Tool_Salir As System.Windows.Forms.ToolStripButton
    Friend WithEvents Tool_Receta As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
End Class
