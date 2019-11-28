<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class HO_PR_HospitalPaci
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
        Dim Appearance23 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance3 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance24 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance7 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance25 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance9 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance19 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance8 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridBand1 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1)
        Dim UltraGridColumn1 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IDCAMA")
        Dim UltraGridColumn2 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CAMA")
        Dim Appearance26 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn3 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("HABITACION")
        Dim Appearance27 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn4 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("PISO")
        Dim UltraGridColumn5 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("PACIENTE")
        Dim Appearance28 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn6 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FEC_INGRESO")
        Dim Appearance29 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn7 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("DIAGNOSTICO")
        Dim UltraGridColumn8 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NUM_CAMA")
        Dim UltraGridColumn9 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("PH_IDSOLICI")
        Dim UltraGridColumn10 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("PH_FAMILIAR")
        Dim UltraGridColumn11 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("PH_TELEF")
        Dim UltraGridColumn12 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("PH_DIR")
        Dim UltraGridColumn13 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("PH_IDHISTORIA")
        Dim Appearance30 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn14 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IMG")
        Dim Appearance18 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraDataColumn1 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IDCAMA")
        Dim UltraDataColumn2 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("CAMA")
        Dim UltraDataColumn3 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("HABITACION")
        Dim UltraDataColumn4 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("PISO")
        Dim UltraDataColumn5 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("PACIENTE")
        Dim UltraDataColumn6 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("FEC_INGRESO")
        Dim UltraDataColumn7 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("DIAGNOSTICO")
        Dim UltraDataColumn8 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("NUM_CAMA")
        Dim UltraDataColumn9 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("PH_IDSOLICI")
        Dim UltraDataColumn10 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("PH_FAMILIAR")
        Dim UltraDataColumn11 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("PH_TELEF")
        Dim UltraDataColumn12 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("PH_DIR")
        Dim UltraDataColumn13 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("PH_IDHISTORIA")
        Dim UltraDataColumn14 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IMG")
        Dim Appearance20 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance21 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance10 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim EditorButton1 As Infragistics.Win.UltraWinEditors.EditorButton = New Infragistics.Win.UltraWinEditors.EditorButton("ayuda")
        Dim Appearance2 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance11 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance17 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance12 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance15 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance13 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance16 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance4 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance6 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance5 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance14 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance22 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraTab1 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraTab2 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim Appearance1 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Me.UltraTabPageControl1 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.ugb_camb_habi = New Infragistics.Win.Misc.UltraGroupBox()
        Me.ubtn_cancelar_cambCama = New Infragistics.Win.Misc.UltraButton()
        Me.txt_paciente02 = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.txt_cama_Act = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.ubtn_camb_habi = New Infragistics.Win.Misc.UltraButton()
        Me.UltraLabel19 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraLabel17 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraLabel18 = New Infragistics.Win.Misc.UltraLabel()
        Me.uce_camas = New Infragistics.Win.UltraWinEditors.UltraComboEditor()
        Me.ugb_alta = New Infragistics.Win.Misc.UltraGroupBox()
        Me.ubtn_cancelar = New Infragistics.Win.Misc.UltraButton()
        Me.ubtn_darAlta = New Infragistics.Win.Misc.UltraButton()
        Me.ume_fecha_alta2 = New Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit()
        Me.UltraLabel16 = New Infragistics.Win.Misc.UltraLabel()
        Me.ug_ListaCamas = New Infragistics.Win.UltraWinGrid.UltraGrid()
        Me.uds_hospi = New Infragistics.Win.UltraWinDataSource.UltraDataSource(Me.components)
        Me.UltraTabPageControl2 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.ugb_datos = New Infragistics.Win.Misc.UltraGroupBox()
        Me.txt_idcama = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.UltraGroupBox1 = New Infragistics.Win.Misc.UltraGroupBox()
        Me.txt_dir = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.txt_telef = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.txt_familiar = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.UltraLabel12 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraLabel11 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraLabel10 = New Infragistics.Win.Misc.UltraLabel()
        Me.ume_fec_alta = New Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit()
        Me.ume_fec_ing = New Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit()
        Me.txt_dias = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.txt_indica = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.txt_diag = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.txt_Habitacion = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.txt_num_cama = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.txt_paciente = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.txt_medico = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.txt_num_historia = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.txt_num_soli = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.UltraLabel9 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraLabel14 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraLabel8 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraLabel6 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraLabel7 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraLabel5 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraLabel4 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraLabel13 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraLabel2 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraLabel1 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraLabel3 = New Infragistics.Win.Misc.UltraLabel()
        Me.utc_hospi = New Infragistics.Win.UltraWinTabControl.UltraTabControl()
        Me.UltraTabSharedControlsPage1 = New Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage()
        Me.ToolS_Mantenimiento = New System.Windows.Forms.ToolStrip()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.Tool_Grabar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.Tool_Cancelar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.Tool_Imprimir = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator7 = New System.Windows.Forms.ToolStripSeparator()
        Me.Tool_daralta = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator()
        Me.Tool_camb_cama = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator6 = New System.Windows.Forms.ToolStripSeparator()
        Me.Tool_Salir = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator8 = New System.Windows.Forms.ToolStripSeparator()
        Me.UltraLabel15 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraTabPageControl1.SuspendLayout()
        CType(Me.ugb_camb_habi, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ugb_camb_habi.SuspendLayout()
        CType(Me.txt_paciente02, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_cama_Act, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.uce_camas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ugb_alta, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ugb_alta.SuspendLayout()
        CType(Me.ug_ListaCamas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.uds_hospi, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabPageControl2.SuspendLayout()
        CType(Me.ugb_datos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ugb_datos.SuspendLayout()
        CType(Me.txt_idcama, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UltraGroupBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraGroupBox1.SuspendLayout()
        CType(Me.txt_dir, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_telef, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_familiar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_dias, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_indica, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_diag, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_Habitacion, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_num_cama, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_paciente, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_medico, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_num_historia, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_num_soli, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.utc_hospi, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.utc_hospi.SuspendLayout()
        Me.ToolS_Mantenimiento.SuspendLayout()
        Me.SuspendLayout()
        '
        'UltraTabPageControl1
        '
        Me.UltraTabPageControl1.Controls.Add(Me.ugb_camb_habi)
        Me.UltraTabPageControl1.Controls.Add(Me.ugb_alta)
        Me.UltraTabPageControl1.Controls.Add(Me.ug_ListaCamas)
        Me.UltraTabPageControl1.Location = New System.Drawing.Point(1, 23)
        Me.UltraTabPageControl1.Name = "UltraTabPageControl1"
        Me.UltraTabPageControl1.Size = New System.Drawing.Size(810, 428)
        '
        'ugb_camb_habi
        '
        Appearance23.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ugb_camb_habi.Appearance = Appearance23
        Me.ugb_camb_habi.Controls.Add(Me.ubtn_cancelar_cambCama)
        Me.ugb_camb_habi.Controls.Add(Me.txt_paciente02)
        Me.ugb_camb_habi.Controls.Add(Me.txt_cama_Act)
        Me.ugb_camb_habi.Controls.Add(Me.ubtn_camb_habi)
        Me.ugb_camb_habi.Controls.Add(Me.UltraLabel19)
        Me.ugb_camb_habi.Controls.Add(Me.UltraLabel17)
        Me.ugb_camb_habi.Controls.Add(Me.UltraLabel18)
        Me.ugb_camb_habi.Controls.Add(Me.uce_camas)
        Me.ugb_camb_habi.Location = New System.Drawing.Point(207, 43)
        Me.ugb_camb_habi.Name = "ugb_camb_habi"
        Me.ugb_camb_habi.Size = New System.Drawing.Size(417, 174)
        Me.ugb_camb_habi.TabIndex = 2
        Me.ugb_camb_habi.Text = "Cambio de Cama"
        '
        'ubtn_cancelar_cambCama
        '
        Me.ubtn_cancelar_cambCama.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ubtn_cancelar_cambCama.Location = New System.Drawing.Point(301, 115)
        Me.ubtn_cancelar_cambCama.Name = "ubtn_cancelar_cambCama"
        Me.ubtn_cancelar_cambCama.Size = New System.Drawing.Size(102, 39)
        Me.ubtn_cancelar_cambCama.TabIndex = 57
        Me.ubtn_cancelar_cambCama.Text = "Cancelar"
        '
        'txt_paciente02
        '
        Appearance3.FontData.BoldAsString = "True"
        Me.txt_paciente02.Appearance = Appearance3
        Me.txt_paciente02.Location = New System.Drawing.Point(131, 22)
        Me.txt_paciente02.MaxLength = 11
        Me.txt_paciente02.Name = "txt_paciente02"
        Me.txt_paciente02.ReadOnly = True
        Me.txt_paciente02.Size = New System.Drawing.Size(272, 21)
        Me.txt_paciente02.TabIndex = 56
        '
        'txt_cama_Act
        '
        Appearance24.FontData.BoldAsString = "True"
        Me.txt_cama_Act.Appearance = Appearance24
        Me.txt_cama_Act.Location = New System.Drawing.Point(131, 49)
        Me.txt_cama_Act.MaxLength = 11
        Me.txt_cama_Act.Name = "txt_cama_Act"
        Me.txt_cama_Act.ReadOnly = True
        Me.txt_cama_Act.Size = New System.Drawing.Size(127, 21)
        Me.txt_cama_Act.TabIndex = 56
        '
        'ubtn_camb_habi
        '
        Me.ubtn_camb_habi.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ubtn_camb_habi.Location = New System.Drawing.Point(131, 115)
        Me.ubtn_camb_habi.Name = "ubtn_camb_habi"
        Me.ubtn_camb_habi.Size = New System.Drawing.Size(133, 39)
        Me.ubtn_camb_habi.TabIndex = 55
        Me.ubtn_camb_habi.Text = "Cambiar Cama"
        '
        'UltraLabel19
        '
        Appearance7.BackColor = System.Drawing.Color.Transparent
        Appearance7.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel19.Appearance = Appearance7
        Me.UltraLabel19.AutoSize = True
        Me.UltraLabel19.Location = New System.Drawing.Point(77, 26)
        Me.UltraLabel19.Name = "UltraLabel19"
        Me.UltraLabel19.Size = New System.Drawing.Size(48, 14)
        Me.UltraLabel19.TabIndex = 54
        Me.UltraLabel19.Text = "Paciente"
        '
        'UltraLabel17
        '
        Appearance25.BackColor = System.Drawing.Color.Transparent
        Appearance25.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel17.Appearance = Appearance25
        Me.UltraLabel17.AutoSize = True
        Me.UltraLabel17.Location = New System.Drawing.Point(41, 53)
        Me.UltraLabel17.Name = "UltraLabel17"
        Me.UltraLabel17.Size = New System.Drawing.Size(84, 14)
        Me.UltraLabel17.TabIndex = 54
        Me.UltraLabel17.Text = "Nº Cama Actual"
        '
        'UltraLabel18
        '
        Appearance9.BackColor = System.Drawing.Color.Transparent
        Appearance9.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel18.Appearance = Appearance9
        Me.UltraLabel18.AutoSize = True
        Me.UltraLabel18.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel18.Location = New System.Drawing.Point(19, 80)
        Me.UltraLabel18.Name = "UltraLabel18"
        Me.UltraLabel18.Size = New System.Drawing.Size(106, 14)
        Me.UltraLabel18.TabIndex = 54
        Me.UltraLabel18.Text = "Nº Cama a cambiar"
        '
        'uce_camas
        '
        Me.uce_camas.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.uce_camas.Location = New System.Drawing.Point(131, 76)
        Me.uce_camas.Name = "uce_camas"
        Me.uce_camas.Size = New System.Drawing.Size(220, 21)
        Me.uce_camas.TabIndex = 0
        '
        'ugb_alta
        '
        Appearance19.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ugb_alta.Appearance = Appearance19
        Me.ugb_alta.Controls.Add(Me.ubtn_cancelar)
        Me.ugb_alta.Controls.Add(Me.ubtn_darAlta)
        Me.ugb_alta.Controls.Add(Me.ume_fecha_alta2)
        Me.ugb_alta.Controls.Add(Me.UltraLabel16)
        Me.ugb_alta.Location = New System.Drawing.Point(169, 181)
        Me.ugb_alta.Name = "ugb_alta"
        Me.ugb_alta.Size = New System.Drawing.Size(489, 122)
        Me.ugb_alta.TabIndex = 1
        Me.ugb_alta.Text = "Alta de Paciente"
        '
        'ubtn_cancelar
        '
        Me.ubtn_cancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ubtn_cancelar.Location = New System.Drawing.Point(360, 41)
        Me.ubtn_cancelar.Name = "ubtn_cancelar"
        Me.ubtn_cancelar.Size = New System.Drawing.Size(105, 39)
        Me.ubtn_cancelar.TabIndex = 53
        Me.ubtn_cancelar.Text = "Cancelar"
        '
        'ubtn_darAlta
        '
        Me.ubtn_darAlta.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ubtn_darAlta.Location = New System.Drawing.Point(193, 42)
        Me.ubtn_darAlta.Name = "ubtn_darAlta"
        Me.ubtn_darAlta.Size = New System.Drawing.Size(133, 39)
        Me.ubtn_darAlta.TabIndex = 52
        Me.ubtn_darAlta.Text = "Dar Alta"
        '
        'ume_fecha_alta2
        '
        Me.ume_fecha_alta2.EditAs = Infragistics.Win.UltraWinMaskedEdit.EditAsType.UseSpecifiedMask
        Me.ume_fecha_alta2.InputMask = "{date}"
        Me.ume_fecha_alta2.Location = New System.Drawing.Point(93, 51)
        Me.ume_fecha_alta2.Name = "ume_fecha_alta2"
        Me.ume_fecha_alta2.Size = New System.Drawing.Size(80, 20)
        Me.ume_fecha_alta2.TabIndex = 51
        Me.ume_fecha_alta2.Text = "UltraMaskedEdit1"
        '
        'UltraLabel16
        '
        Appearance8.BackColor = System.Drawing.Color.Transparent
        Appearance8.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel16.Appearance = Appearance8
        Me.UltraLabel16.AutoSize = True
        Me.UltraLabel16.Location = New System.Drawing.Point(29, 54)
        Me.UltraLabel16.Name = "UltraLabel16"
        Me.UltraLabel16.Size = New System.Drawing.Size(58, 14)
        Me.UltraLabel16.TabIndex = 50
        Me.UltraLabel16.Text = "Fecha Alta"
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
        Appearance26.TextHAlignAsString = "Center"
        UltraGridColumn2.CellAppearance = Appearance26
        UltraGridColumn2.Header.VisiblePosition = 2
        UltraGridColumn2.RowLayoutColumnInfo.OriginX = 3
        UltraGridColumn2.RowLayoutColumnInfo.OriginY = 2
        UltraGridColumn2.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(103, 0)
        UltraGridColumn2.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn2.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn2.Width = 79
        UltraGridColumn3.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn3.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        Appearance27.FontData.BoldAsString = "True"
        Appearance27.FontData.SizeInPoints = 12.0!
        Appearance27.TextHAlignAsString = "Center"
        UltraGridColumn3.CellAppearance = Appearance27
        UltraGridColumn3.Header.VisiblePosition = 3
        UltraGridColumn3.RowLayoutColumnInfo.OriginX = 3
        UltraGridColumn3.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn3.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(103, 0)
        UltraGridColumn3.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn3.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn3.Width = 107
        UltraGridColumn4.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn4.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn4.Header.VisiblePosition = 4
        UltraGridColumn4.Hidden = True
        UltraGridColumn4.RowLayoutColumnInfo.OriginX = 2
        UltraGridColumn4.RowLayoutColumnInfo.OriginY = 6
        UltraGridColumn4.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn4.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn4.Width = 33
        UltraGridColumn5.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn5.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        Appearance28.FontData.BoldAsString = "True"
        Appearance28.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        UltraGridColumn5.CellAppearance = Appearance28
        UltraGridColumn5.CellMultiLine = Infragistics.Win.DefaultableBoolean.[True]
        UltraGridColumn5.Header.VisiblePosition = 6
        UltraGridColumn5.RowLayoutColumnInfo.OriginX = 5
        UltraGridColumn5.RowLayoutColumnInfo.OriginY = 2
        UltraGridColumn5.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(320, 72)
        UltraGridColumn5.RowLayoutColumnInfo.PreferredLabelSize = New System.Drawing.Size(0, 20)
        UltraGridColumn5.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn5.RowLayoutColumnInfo.SpanY = 7
        UltraGridColumn5.Width = 232
        UltraGridColumn6.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn6.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        Appearance29.TextHAlignAsString = "Center"
        UltraGridColumn6.CellAppearance = Appearance29
        UltraGridColumn6.Header.VisiblePosition = 7
        UltraGridColumn6.RowLayoutColumnInfo.OriginX = 3
        UltraGridColumn6.RowLayoutColumnInfo.OriginY = 4
        UltraGridColumn6.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(103, 54)
        UltraGridColumn6.RowLayoutColumnInfo.PreferredLabelSize = New System.Drawing.Size(0, 20)
        UltraGridColumn6.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn6.RowLayoutColumnInfo.SpanY = 5
        UltraGridColumn6.Width = 72
        UltraGridColumn7.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn7.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn7.Header.VisiblePosition = 8
        UltraGridColumn7.RowLayoutColumnInfo.OriginX = 7
        UltraGridColumn7.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn7.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(0, 64)
        UltraGridColumn7.RowLayoutColumnInfo.PreferredLabelSize = New System.Drawing.Size(0, 30)
        UltraGridColumn7.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn7.RowLayoutColumnInfo.SpanY = 6
        UltraGridColumn8.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn8.Header.VisiblePosition = 9
        UltraGridColumn8.Hidden = True
        UltraGridColumn9.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn9.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn9.Header.VisiblePosition = 10
        UltraGridColumn9.Hidden = True
        UltraGridColumn10.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn10.Header.Caption = "FAMILIAR"
        UltraGridColumn10.Header.VisiblePosition = 11
        UltraGridColumn10.RowLayoutColumnInfo.OriginX = 7
        UltraGridColumn10.RowLayoutColumnInfo.OriginY = 6
        UltraGridColumn10.RowLayoutColumnInfo.PreferredLabelSize = New System.Drawing.Size(0, 20)
        UltraGridColumn10.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn10.RowLayoutColumnInfo.SpanY = 3
        UltraGridColumn11.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn11.Header.VisiblePosition = 12
        UltraGridColumn11.Hidden = True
        UltraGridColumn12.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn12.Header.VisiblePosition = 13
        UltraGridColumn12.Hidden = True
        UltraGridColumn13.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn13.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        Appearance30.FontData.BoldAsString = "True"
        Appearance30.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        UltraGridColumn13.CellAppearance = Appearance30
        UltraGridColumn13.Header.Caption = "Nº Hist."
        UltraGridColumn13.Header.VisiblePosition = 5
        UltraGridColumn13.RowLayoutColumnInfo.OriginX = 5
        UltraGridColumn13.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn13.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(320, 0)
        UltraGridColumn13.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn13.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn13.Width = 52
        UltraGridColumn14.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn14.Header.VisiblePosition = 1
        UltraGridColumn14.RowLayoutColumnInfo.OriginX = 0
        UltraGridColumn14.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn14.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(114, 99)
        UltraGridColumn14.RowLayoutColumnInfo.PreferredLabelSize = New System.Drawing.Size(0, 60)
        UltraGridColumn14.RowLayoutColumnInfo.SpanX = 3
        UltraGridColumn14.RowLayoutColumnInfo.SpanY = 9
        UltraGridColumn14.Width = 75
        UltraGridBand1.Columns.AddRange(New Object() {UltraGridColumn1, UltraGridColumn2, UltraGridColumn3, UltraGridColumn4, UltraGridColumn5, UltraGridColumn6, UltraGridColumn7, UltraGridColumn8, UltraGridColumn9, UltraGridColumn10, UltraGridColumn11, UltraGridColumn12, UltraGridColumn13, UltraGridColumn14})
        UltraGridBand1.UseRowLayout = True
        Me.ug_ListaCamas.DisplayLayout.BandsSerializer.Add(UltraGridBand1)
        Me.ug_ListaCamas.DisplayLayout.MaxColScrollRegions = 1
        Me.ug_ListaCamas.DisplayLayout.MaxRowScrollRegions = 1
        Appearance18.BackColor = System.Drawing.Color.WhiteSmoke
        Appearance18.BackColor2 = System.Drawing.Color.WhiteSmoke
        Me.ug_ListaCamas.DisplayLayout.Override.RowAlternateAppearance = Appearance18
        Me.ug_ListaCamas.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.ug_ListaCamas.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.ug_ListaCamas.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ug_ListaCamas.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ug_ListaCamas.Location = New System.Drawing.Point(0, 0)
        Me.ug_ListaCamas.Name = "ug_ListaCamas"
        Me.ug_ListaCamas.Size = New System.Drawing.Size(810, 428)
        Me.ug_ListaCamas.TabIndex = 0
        '
        'uds_hospi
        '
        Me.uds_hospi.AllowDelete = False
        UltraDataColumn1.DataType = GetType(Integer)
        UltraDataColumn6.DataType = GetType(Date)
        UltraDataColumn8.DataType = GetType(Double)
        UltraDataColumn9.DataType = GetType(Long)
        UltraDataColumn13.DataType = GetType(Long)
        UltraDataColumn14.DataType = GetType(System.Drawing.Bitmap)
        Me.uds_hospi.Band.Columns.AddRange(New Object() {UltraDataColumn1, UltraDataColumn2, UltraDataColumn3, UltraDataColumn4, UltraDataColumn5, UltraDataColumn6, UltraDataColumn7, UltraDataColumn8, UltraDataColumn9, UltraDataColumn10, UltraDataColumn11, UltraDataColumn12, UltraDataColumn13, UltraDataColumn14})
        '
        'UltraTabPageControl2
        '
        Me.UltraTabPageControl2.Controls.Add(Me.ugb_datos)
        Me.UltraTabPageControl2.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl2.Name = "UltraTabPageControl2"
        Me.UltraTabPageControl2.Size = New System.Drawing.Size(810, 428)
        '
        'ugb_datos
        '
        Me.ugb_datos.Controls.Add(Me.txt_idcama)
        Me.ugb_datos.Controls.Add(Me.UltraGroupBox1)
        Me.ugb_datos.Controls.Add(Me.ume_fec_alta)
        Me.ugb_datos.Controls.Add(Me.ume_fec_ing)
        Me.ugb_datos.Controls.Add(Me.txt_dias)
        Me.ugb_datos.Controls.Add(Me.txt_indica)
        Me.ugb_datos.Controls.Add(Me.txt_diag)
        Me.ugb_datos.Controls.Add(Me.txt_Habitacion)
        Me.ugb_datos.Controls.Add(Me.txt_num_cama)
        Me.ugb_datos.Controls.Add(Me.txt_paciente)
        Me.ugb_datos.Controls.Add(Me.txt_medico)
        Me.ugb_datos.Controls.Add(Me.txt_num_historia)
        Me.ugb_datos.Controls.Add(Me.txt_num_soli)
        Me.ugb_datos.Controls.Add(Me.UltraLabel9)
        Me.ugb_datos.Controls.Add(Me.UltraLabel14)
        Me.ugb_datos.Controls.Add(Me.UltraLabel8)
        Me.ugb_datos.Controls.Add(Me.UltraLabel6)
        Me.ugb_datos.Controls.Add(Me.UltraLabel7)
        Me.ugb_datos.Controls.Add(Me.UltraLabel5)
        Me.ugb_datos.Controls.Add(Me.UltraLabel4)
        Me.ugb_datos.Controls.Add(Me.UltraLabel13)
        Me.ugb_datos.Controls.Add(Me.UltraLabel2)
        Me.ugb_datos.Controls.Add(Me.UltraLabel1)
        Me.ugb_datos.Controls.Add(Me.UltraLabel3)
        Me.ugb_datos.Location = New System.Drawing.Point(3, 3)
        Me.ugb_datos.Name = "ugb_datos"
        Me.ugb_datos.Size = New System.Drawing.Size(795, 418)
        Me.ugb_datos.TabIndex = 0
        '
        'txt_idcama
        '
        Me.txt_idcama.Location = New System.Drawing.Point(629, 18)
        Me.txt_idcama.MaxLength = 100
        Me.txt_idcama.Name = "txt_idcama"
        Me.txt_idcama.ReadOnly = True
        Me.txt_idcama.Size = New System.Drawing.Size(32, 21)
        Me.txt_idcama.TabIndex = 48
        Me.txt_idcama.Visible = False
        '
        'UltraGroupBox1
        '
        Me.UltraGroupBox1.Controls.Add(Me.txt_dir)
        Me.UltraGroupBox1.Controls.Add(Me.txt_telef)
        Me.UltraGroupBox1.Controls.Add(Me.txt_familiar)
        Me.UltraGroupBox1.Controls.Add(Me.UltraLabel12)
        Me.UltraGroupBox1.Controls.Add(Me.UltraLabel11)
        Me.UltraGroupBox1.Controls.Add(Me.UltraLabel10)
        Me.UltraGroupBox1.Location = New System.Drawing.Point(28, 236)
        Me.UltraGroupBox1.Name = "UltraGroupBox1"
        Me.UltraGroupBox1.Size = New System.Drawing.Size(633, 91)
        Me.UltraGroupBox1.TabIndex = 47
        Me.UltraGroupBox1.Text = "Datos de Familiar"
        '
        'txt_dir
        '
        Me.txt_dir.Location = New System.Drawing.Point(83, 57)
        Me.txt_dir.MaxLength = 100
        Me.txt_dir.Name = "txt_dir"
        Me.txt_dir.Size = New System.Drawing.Size(461, 21)
        Me.txt_dir.TabIndex = 45
        '
        'txt_telef
        '
        Me.txt_telef.Location = New System.Drawing.Point(398, 30)
        Me.txt_telef.MaxLength = 50
        Me.txt_telef.Name = "txt_telef"
        Me.txt_telef.Size = New System.Drawing.Size(146, 21)
        Me.txt_telef.TabIndex = 45
        '
        'txt_familiar
        '
        Me.txt_familiar.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_familiar.Location = New System.Drawing.Point(83, 30)
        Me.txt_familiar.MaxLength = 100
        Me.txt_familiar.Name = "txt_familiar"
        Me.txt_familiar.Size = New System.Drawing.Size(255, 21)
        Me.txt_familiar.TabIndex = 45
        '
        'UltraLabel12
        '
        Appearance20.BackColor = System.Drawing.Color.Transparent
        Appearance20.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel12.Appearance = Appearance20
        Me.UltraLabel12.AutoSize = True
        Me.UltraLabel12.Location = New System.Drawing.Point(14, 61)
        Me.UltraLabel12.Name = "UltraLabel12"
        Me.UltraLabel12.Size = New System.Drawing.Size(52, 14)
        Me.UltraLabel12.TabIndex = 44
        Me.UltraLabel12.Text = "Direccion"
        '
        'UltraLabel11
        '
        Appearance21.BackColor = System.Drawing.Color.Transparent
        Appearance21.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel11.Appearance = Appearance21
        Me.UltraLabel11.AutoSize = True
        Me.UltraLabel11.Location = New System.Drawing.Point(344, 33)
        Me.UltraLabel11.Name = "UltraLabel11"
        Me.UltraLabel11.Size = New System.Drawing.Size(48, 14)
        Me.UltraLabel11.TabIndex = 44
        Me.UltraLabel11.Text = "Telefono"
        '
        'UltraLabel10
        '
        Appearance10.BackColor = System.Drawing.Color.Transparent
        Appearance10.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel10.Appearance = Appearance10
        Me.UltraLabel10.AutoSize = True
        Me.UltraLabel10.Location = New System.Drawing.Point(18, 33)
        Me.UltraLabel10.Name = "UltraLabel10"
        Me.UltraLabel10.Size = New System.Drawing.Size(45, 14)
        Me.UltraLabel10.TabIndex = 44
        Me.UltraLabel10.Text = "Familiar"
        '
        'ume_fec_alta
        '
        Me.ume_fec_alta.EditAs = Infragistics.Win.UltraWinMaskedEdit.EditAsType.UseSpecifiedMask
        Me.ume_fec_alta.InputMask = "{date}"
        Me.ume_fec_alta.Location = New System.Drawing.Point(97, 125)
        Me.ume_fec_alta.Name = "ume_fec_alta"
        Me.ume_fec_alta.ReadOnly = True
        Me.ume_fec_alta.Size = New System.Drawing.Size(80, 20)
        Me.ume_fec_alta.TabIndex = 46
        Me.ume_fec_alta.Text = "UltraMaskedEdit1"
        '
        'ume_fec_ing
        '
        Me.ume_fec_ing.EditAs = Infragistics.Win.UltraWinMaskedEdit.EditAsType.UseSpecifiedMask
        Me.ume_fec_ing.InputMask = "{date}"
        Me.ume_fec_ing.Location = New System.Drawing.Point(97, 99)
        Me.ume_fec_ing.Name = "ume_fec_ing"
        Me.ume_fec_ing.Size = New System.Drawing.Size(80, 20)
        Me.ume_fec_ing.TabIndex = 46
        Me.ume_fec_ing.Text = "UltraMaskedEdit1"
        '
        'txt_dias
        '
        Me.txt_dias.Location = New System.Drawing.Point(289, 99)
        Me.txt_dias.MaxLength = 100
        Me.txt_dias.Name = "txt_dias"
        Me.txt_dias.Size = New System.Drawing.Size(54, 21)
        Me.txt_dias.TabIndex = 45
        '
        'txt_indica
        '
        Me.txt_indica.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_indica.Location = New System.Drawing.Point(97, 178)
        Me.txt_indica.MaxLength = 100
        Me.txt_indica.Name = "txt_indica"
        Me.txt_indica.Size = New System.Drawing.Size(564, 21)
        Me.txt_indica.TabIndex = 45
        '
        'txt_diag
        '
        Me.txt_diag.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_diag.Location = New System.Drawing.Point(97, 151)
        Me.txt_diag.MaxLength = 100
        Me.txt_diag.Name = "txt_diag"
        Me.txt_diag.Size = New System.Drawing.Size(564, 21)
        Me.txt_diag.TabIndex = 45
        '
        'txt_Habitacion
        '
        Me.txt_Habitacion.Location = New System.Drawing.Point(432, 124)
        Me.txt_Habitacion.MaxLength = 100
        Me.txt_Habitacion.Name = "txt_Habitacion"
        Me.txt_Habitacion.ReadOnly = True
        Me.txt_Habitacion.Size = New System.Drawing.Size(229, 21)
        Me.txt_Habitacion.TabIndex = 45
        '
        'txt_num_cama
        '
        Me.txt_num_cama.Location = New System.Drawing.Point(289, 124)
        Me.txt_num_cama.MaxLength = 100
        Me.txt_num_cama.Name = "txt_num_cama"
        Me.txt_num_cama.ReadOnly = True
        Me.txt_num_cama.Size = New System.Drawing.Size(54, 21)
        Me.txt_num_cama.TabIndex = 45
        '
        'txt_paciente
        '
        Me.txt_paciente.Location = New System.Drawing.Point(97, 72)
        Me.txt_paciente.MaxLength = 100
        Me.txt_paciente.Name = "txt_paciente"
        Me.txt_paciente.ReadOnly = True
        Me.txt_paciente.Size = New System.Drawing.Size(564, 21)
        Me.txt_paciente.TabIndex = 45
        '
        'txt_medico
        '
        Me.txt_medico.Location = New System.Drawing.Point(289, 45)
        Me.txt_medico.MaxLength = 100
        Me.txt_medico.Name = "txt_medico"
        Me.txt_medico.ReadOnly = True
        Me.txt_medico.Size = New System.Drawing.Size(372, 21)
        Me.txt_medico.TabIndex = 45
        '
        'txt_num_historia
        '
        Me.txt_num_historia.Location = New System.Drawing.Point(97, 45)
        Me.txt_num_historia.MaxLength = 100
        Me.txt_num_historia.Name = "txt_num_historia"
        Me.txt_num_historia.ReadOnly = True
        Me.txt_num_historia.Size = New System.Drawing.Size(110, 21)
        Me.txt_num_historia.TabIndex = 45
        '
        'txt_num_soli
        '
        Appearance2.ImageHAlign = Infragistics.Win.HAlign.Center
        Appearance2.ImageVAlign = Infragistics.Win.VAlign.Middle
        EditorButton1.Appearance = Appearance2
        EditorButton1.Key = "ayuda"
        Me.txt_num_soli.ButtonsRight.Add(EditorButton1)
        Me.txt_num_soli.Location = New System.Drawing.Point(97, 18)
        Me.txt_num_soli.MaxLength = 11
        Me.txt_num_soli.Name = "txt_num_soli"
        Me.txt_num_soli.ReadOnly = True
        Me.txt_num_soli.Size = New System.Drawing.Size(127, 21)
        Me.txt_num_soli.TabIndex = 43
        '
        'UltraLabel9
        '
        Appearance11.BackColor = System.Drawing.Color.Transparent
        Appearance11.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel9.Appearance = Appearance11
        Me.UltraLabel9.AutoSize = True
        Me.UltraLabel9.Location = New System.Drawing.Point(224, 103)
        Me.UltraLabel9.Name = "UltraLabel9"
        Me.UltraLabel9.Size = New System.Drawing.Size(59, 14)
        Me.UltraLabel9.TabIndex = 44
        Me.UltraLabel9.Text = "Dias Hospi"
        '
        'UltraLabel14
        '
        Appearance17.BackColor = System.Drawing.Color.Transparent
        Appearance17.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel14.Appearance = Appearance17
        Me.UltraLabel14.AutoSize = True
        Me.UltraLabel14.Location = New System.Drawing.Point(368, 128)
        Me.UltraLabel14.Name = "UltraLabel14"
        Me.UltraLabel14.Size = New System.Drawing.Size(58, 14)
        Me.UltraLabel14.TabIndex = 44
        Me.UltraLabel14.Text = "Habitacion"
        '
        'UltraLabel8
        '
        Appearance12.BackColor = System.Drawing.Color.Transparent
        Appearance12.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel8.Appearance = Appearance12
        Me.UltraLabel8.AutoSize = True
        Me.UltraLabel8.Location = New System.Drawing.Point(24, 181)
        Me.UltraLabel8.Name = "UltraLabel8"
        Me.UltraLabel8.Size = New System.Drawing.Size(67, 14)
        Me.UltraLabel8.TabIndex = 44
        Me.UltraLabel8.Text = "Indicaciones"
        '
        'UltraLabel6
        '
        Appearance15.BackColor = System.Drawing.Color.Transparent
        Appearance15.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel6.Appearance = Appearance15
        Me.UltraLabel6.AutoSize = True
        Me.UltraLabel6.Location = New System.Drawing.Point(218, 128)
        Me.UltraLabel6.Name = "UltraLabel6"
        Me.UltraLabel6.Size = New System.Drawing.Size(65, 14)
        Me.UltraLabel6.TabIndex = 44
        Me.UltraLabel6.Text = "Nº de Cama"
        '
        'UltraLabel7
        '
        Appearance13.BackColor = System.Drawing.Color.Transparent
        Appearance13.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel7.Appearance = Appearance13
        Me.UltraLabel7.AutoSize = True
        Me.UltraLabel7.Location = New System.Drawing.Point(28, 154)
        Me.UltraLabel7.Name = "UltraLabel7"
        Me.UltraLabel7.Size = New System.Drawing.Size(63, 14)
        Me.UltraLabel7.TabIndex = 44
        Me.UltraLabel7.Text = "Diagnostico"
        '
        'UltraLabel5
        '
        Appearance16.BackColor = System.Drawing.Color.Transparent
        Appearance16.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel5.Appearance = Appearance16
        Me.UltraLabel5.AutoSize = True
        Me.UltraLabel5.Location = New System.Drawing.Point(33, 128)
        Me.UltraLabel5.Name = "UltraLabel5"
        Me.UltraLabel5.Size = New System.Drawing.Size(58, 14)
        Me.UltraLabel5.TabIndex = 44
        Me.UltraLabel5.Text = "Fecha Alta"
        '
        'UltraLabel4
        '
        Appearance4.BackColor = System.Drawing.Color.Transparent
        Appearance4.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel4.Appearance = Appearance4
        Me.UltraLabel4.AutoSize = True
        Me.UltraLabel4.Location = New System.Drawing.Point(15, 102)
        Me.UltraLabel4.Name = "UltraLabel4"
        Me.UltraLabel4.Size = New System.Drawing.Size(76, 14)
        Me.UltraLabel4.TabIndex = 44
        Me.UltraLabel4.Text = "Fecha Ingreso"
        '
        'UltraLabel13
        '
        Appearance6.BackColor = System.Drawing.Color.Transparent
        Appearance6.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel13.Appearance = Appearance6
        Me.UltraLabel13.AutoSize = True
        Me.UltraLabel13.Location = New System.Drawing.Point(241, 49)
        Me.UltraLabel13.Name = "UltraLabel13"
        Me.UltraLabel13.Size = New System.Drawing.Size(41, 14)
        Me.UltraLabel13.TabIndex = 44
        Me.UltraLabel13.Text = "Medico"
        '
        'UltraLabel2
        '
        Appearance5.BackColor = System.Drawing.Color.Transparent
        Appearance5.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel2.Appearance = Appearance5
        Me.UltraLabel2.AutoSize = True
        Me.UltraLabel2.Location = New System.Drawing.Point(43, 76)
        Me.UltraLabel2.Name = "UltraLabel2"
        Me.UltraLabel2.Size = New System.Drawing.Size(48, 14)
        Me.UltraLabel2.TabIndex = 44
        Me.UltraLabel2.Text = "Paciente"
        '
        'UltraLabel1
        '
        Appearance14.BackColor = System.Drawing.Color.Transparent
        Appearance14.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel1.Appearance = Appearance14
        Me.UltraLabel1.AutoSize = True
        Me.UltraLabel1.Location = New System.Drawing.Point(33, 49)
        Me.UltraLabel1.Name = "UltraLabel1"
        Me.UltraLabel1.Size = New System.Drawing.Size(58, 14)
        Me.UltraLabel1.TabIndex = 44
        Me.UltraLabel1.Text = "Nº Historia"
        '
        'UltraLabel3
        '
        Appearance22.BackColor = System.Drawing.Color.Transparent
        Appearance22.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel3.Appearance = Appearance22
        Me.UltraLabel3.AutoSize = True
        Me.UltraLabel3.Location = New System.Drawing.Point(28, 22)
        Me.UltraLabel3.Name = "UltraLabel3"
        Me.UltraLabel3.Size = New System.Drawing.Size(63, 14)
        Me.UltraLabel3.TabIndex = 44
        Me.UltraLabel3.Text = "Nº Solicitud"
        '
        'utc_hospi
        '
        Me.utc_hospi.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.utc_hospi.Controls.Add(Me.UltraTabSharedControlsPage1)
        Me.utc_hospi.Controls.Add(Me.UltraTabPageControl1)
        Me.utc_hospi.Controls.Add(Me.UltraTabPageControl2)
        Me.utc_hospi.Location = New System.Drawing.Point(5, 62)
        Me.utc_hospi.Name = "utc_hospi"
        Me.utc_hospi.SharedControlsPage = Me.UltraTabSharedControlsPage1
        Me.utc_hospi.Size = New System.Drawing.Size(814, 454)
        Me.utc_hospi.TabIndex = 0
        UltraTab1.TabPage = Me.UltraTabPageControl1
        UltraTab1.Text = "Lista de Camas"
        UltraTab2.TabPage = Me.UltraTabPageControl2
        UltraTab2.Text = "Ingreso / Edicion de Datos de Hospitalizacion"
        Me.utc_hospi.Tabs.AddRange(New Infragistics.Win.UltraWinTabControl.UltraTab() {UltraTab1, UltraTab2})
        '
        'UltraTabSharedControlsPage1
        '
        Me.UltraTabSharedControlsPage1.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabSharedControlsPage1.Name = "UltraTabSharedControlsPage1"
        Me.UltraTabSharedControlsPage1.Size = New System.Drawing.Size(810, 428)
        '
        'ToolS_Mantenimiento
        '
        Me.ToolS_Mantenimiento.BackColor = System.Drawing.Color.White
        Me.ToolS_Mantenimiento.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripSeparator1, Me.Tool_Grabar, Me.ToolStripSeparator3, Me.ToolStripSeparator4, Me.Tool_Cancelar, Me.ToolStripSeparator2, Me.Tool_Imprimir, Me.ToolStripSeparator7, Me.Tool_daralta, Me.ToolStripSeparator5, Me.Tool_camb_cama, Me.ToolStripSeparator6, Me.Tool_Salir, Me.ToolStripSeparator8})
        Me.ToolS_Mantenimiento.Location = New System.Drawing.Point(0, 0)
        Me.ToolS_Mantenimiento.Name = "ToolS_Mantenimiento"
        Me.ToolS_Mantenimiento.Size = New System.Drawing.Size(826, 25)
        Me.ToolS_Mantenimiento.TabIndex = 14
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
        'Tool_Imprimir
        '
        Me.Tool_Imprimir.Image = Global.Contabilidad.My.Resources.Resources._004
        Me.Tool_Imprimir.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Tool_Imprimir.Name = "Tool_Imprimir"
        Me.Tool_Imprimir.Size = New System.Drawing.Size(99, 22)
        Me.Tool_Imprimir.Text = "Hoja Filiacion"
        '
        'ToolStripSeparator7
        '
        Me.ToolStripSeparator7.Name = "ToolStripSeparator7"
        Me.ToolStripSeparator7.Size = New System.Drawing.Size(6, 25)
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
        'Tool_camb_cama
        '
        Me.Tool_camb_cama.Image = Global.Contabilidad.My.Resources.Resources._16__Bullets_and_numbering_
        Me.Tool_camb_cama.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Tool_camb_cama.Name = "Tool_camb_cama"
        Me.Tool_camb_cama.Size = New System.Drawing.Size(103, 22)
        Me.Tool_camb_cama.Text = "Cambio Cama"
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
        'ToolStripSeparator8
        '
        Me.ToolStripSeparator8.Name = "ToolStripSeparator8"
        Me.ToolStripSeparator8.Size = New System.Drawing.Size(6, 25)
        '
        'UltraLabel15
        '
        Appearance1.BackColor = System.Drawing.Color.DeepSkyBlue
        Appearance1.ForeColor = System.Drawing.Color.White
        Appearance1.TextHAlignAsString = "Center"
        Me.UltraLabel15.Appearance = Appearance1
        Me.UltraLabel15.BorderStyleOuter = Infragistics.Win.UIElementBorderStyle.Solid
        Me.UltraLabel15.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel15.Location = New System.Drawing.Point(-5, 28)
        Me.UltraLabel15.Name = "UltraLabel15"
        Me.UltraLabel15.Size = New System.Drawing.Size(829, 28)
        Me.UltraLabel15.TabIndex = 34
        Me.UltraLabel15.Text = "Admision a Piso"
        '
        'HO_PR_HospitalPaci
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(826, 528)
        Me.Controls.Add(Me.UltraLabel15)
        Me.Controls.Add(Me.ToolS_Mantenimiento)
        Me.Controls.Add(Me.utc_hospi)
        Me.Name = "HO_PR_HospitalPaci"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Registro de Pacientes Hospitalizados"
        Me.UltraTabPageControl1.ResumeLayout(False)
        CType(Me.ugb_camb_habi, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ugb_camb_habi.ResumeLayout(False)
        Me.ugb_camb_habi.PerformLayout()
        CType(Me.txt_paciente02, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_cama_Act, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.uce_camas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ugb_alta, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ugb_alta.ResumeLayout(False)
        Me.ugb_alta.PerformLayout()
        CType(Me.ug_ListaCamas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.uds_hospi, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabPageControl2.ResumeLayout(False)
        CType(Me.ugb_datos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ugb_datos.ResumeLayout(False)
        Me.ugb_datos.PerformLayout()
        CType(Me.txt_idcama, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UltraGroupBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraGroupBox1.ResumeLayout(False)
        Me.UltraGroupBox1.PerformLayout()
        CType(Me.txt_dir, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_telef, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_familiar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_dias, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_indica, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_diag, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_Habitacion, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_num_cama, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_paciente, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_medico, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_num_historia, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_num_soli, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.utc_hospi, System.ComponentModel.ISupportInitialize).EndInit()
        Me.utc_hospi.ResumeLayout(False)
        Me.ToolS_Mantenimiento.ResumeLayout(False)
        Me.ToolS_Mantenimiento.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents utc_hospi As Infragistics.Win.UltraWinTabControl.UltraTabControl
    Friend WithEvents UltraTabSharedControlsPage1 As Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage
    Friend WithEvents UltraTabPageControl1 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents UltraTabPageControl2 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents ug_ListaCamas As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents uds_hospi As Infragistics.Win.UltraWinDataSource.UltraDataSource
    Friend WithEvents ugb_datos As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents txt_num_soli As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents UltraLabel3 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents ume_fec_alta As Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit
    Friend WithEvents ume_fec_ing As Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit
    Friend WithEvents txt_dir As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents txt_telef As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents txt_familiar As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents txt_dias As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents txt_diag As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents txt_num_cama As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents txt_paciente As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents txt_num_historia As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents UltraLabel6 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel5 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel4 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel2 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel1 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents txt_indica As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents UltraLabel12 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel11 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel10 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel9 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel8 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel7 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraGroupBox1 As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents ToolS_Mantenimiento As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents Tool_Grabar As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents Tool_Cancelar As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents Tool_Salir As System.Windows.Forms.ToolStripButton
    Friend WithEvents txt_medico As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents UltraLabel13 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents txt_Habitacion As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents UltraLabel14 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents txt_idcama As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents UltraLabel15 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents Tool_Imprimir As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator5 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator6 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ugb_alta As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents ToolStripSeparator7 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents Tool_daralta As System.Windows.Forms.ToolStripButton
    Friend WithEvents ubtn_darAlta As Infragistics.Win.Misc.UltraButton
    Friend WithEvents ume_fecha_alta2 As Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit
    Friend WithEvents UltraLabel16 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents ubtn_cancelar As Infragistics.Win.Misc.UltraButton
    Friend WithEvents ugb_camb_habi As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents ubtn_cancelar_cambCama As Infragistics.Win.Misc.UltraButton
    Friend WithEvents txt_cama_Act As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents ubtn_camb_habi As Infragistics.Win.Misc.UltraButton
    Friend WithEvents UltraLabel17 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel18 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents uce_camas As Infragistics.Win.UltraWinEditors.UltraComboEditor
    Friend WithEvents Tool_camb_cama As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator8 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents txt_paciente02 As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents UltraLabel19 As Infragistics.Win.Misc.UltraLabel
End Class
