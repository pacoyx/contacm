<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PL_RP_Certi_UtilidadPer
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
        Dim Appearance12 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance3 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridBand1 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1)
        Dim UltraGridColumn1 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("idpersonal")
        Dim UltraGridColumn2 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("nombres")
        Dim UltraGridColumn3 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("num_horas")
        Dim Appearance9 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn4 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("participa_horas")
        Dim Appearance10 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn5 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("computable_emp")
        Dim Appearance13 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn6 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("participa_emp")
        Dim Appearance14 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraDataColumn1 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("idpersonal")
        Dim UltraDataColumn2 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("nombres")
        Dim UltraDataColumn3 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("num_horas")
        Dim UltraDataColumn4 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("participa_horas")
        Dim UltraDataColumn5 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("computable_emp")
        Dim UltraDataColumn6 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("participa_emp")
        Dim Appearance72 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance8 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance6 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance2 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance1 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance23 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Me.ugb_Parametros = New Infragistics.Win.Misc.UltraGroupBox()
        Me.txt_fec = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.UltraLabel6 = New Infragistics.Win.Misc.UltraLabel()
        Me.une_ayo = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.UltraLabel7 = New Infragistics.Win.Misc.UltraLabel()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.Tool_Reporte = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.Tool_Salir = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ug_lista = New Infragistics.Win.UltraWinGrid.UltraGrid()
        Me.uds_lista = New Infragistics.Win.UltraWinDataSource.UltraDataSource(Me.components)
        Me.UltraGroupBox1 = New Infragistics.Win.Misc.UltraGroupBox()
        Me.txt_remu_compu = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.txt_num_tot_hor = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.txt_monto_distri = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.txt_porc_distri = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.txt_renta_anual = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.UltraLabel5 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraLabel4 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraLabel1 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraLabel3 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraLabel2 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraLabel8 = New Infragistics.Win.Misc.UltraLabel()
        CType(Me.ugb_Parametros, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ugb_Parametros.SuspendLayout()
        CType(Me.txt_fec, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.une_ayo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip1.SuspendLayout()
        CType(Me.ug_lista, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.uds_lista, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UltraGroupBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraGroupBox1.SuspendLayout()
        CType(Me.txt_remu_compu, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_num_tot_hor, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_monto_distri, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_porc_distri, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_renta_anual, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ugb_Parametros
        '
        Me.ugb_Parametros.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ugb_Parametros.Controls.Add(Me.UltraLabel8)
        Me.ugb_Parametros.Controls.Add(Me.txt_fec)
        Me.ugb_Parametros.Controls.Add(Me.UltraLabel6)
        Me.ugb_Parametros.Controls.Add(Me.une_ayo)
        Me.ugb_Parametros.Controls.Add(Me.UltraLabel7)
        Me.ugb_Parametros.Location = New System.Drawing.Point(12, 28)
        Me.ugb_Parametros.Name = "ugb_Parametros"
        Me.ugb_Parametros.Size = New System.Drawing.Size(871, 35)
        Me.ugb_Parametros.TabIndex = 26
        '
        'txt_fec
        '
        Me.txt_fec.Location = New System.Drawing.Point(466, 8)
        Me.txt_fec.Name = "txt_fec"
        Me.txt_fec.Size = New System.Drawing.Size(370, 21)
        Me.txt_fec.TabIndex = 142
        '
        'UltraLabel6
        '
        Appearance12.BackColor = System.Drawing.Color.Transparent
        Appearance12.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel6.Appearance = Appearance12
        Me.UltraLabel6.AutoSize = True
        Me.UltraLabel6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel6.Location = New System.Drawing.Point(394, 10)
        Me.UltraLabel6.Name = "UltraLabel6"
        Me.UltraLabel6.Size = New System.Drawing.Size(66, 16)
        Me.UltraLabel6.TabIndex = 141
        Me.UltraLabel6.Text = "Fecha Imp."
        '
        'une_ayo
        '
        Me.une_ayo.Location = New System.Drawing.Point(58, 8)
        Me.une_ayo.Name = "une_ayo"
        Me.une_ayo.Size = New System.Drawing.Size(82, 21)
        Me.une_ayo.TabIndex = 15
        '
        'UltraLabel7
        '
        Appearance3.BackColor = System.Drawing.Color.Transparent
        Appearance3.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel7.Appearance = Appearance3
        Me.UltraLabel7.AutoSize = True
        Me.UltraLabel7.Location = New System.Drawing.Point(10, 12)
        Me.UltraLabel7.Name = "UltraLabel7"
        Me.UltraLabel7.Size = New System.Drawing.Size(43, 14)
        Me.UltraLabel7.TabIndex = 12
        Me.UltraLabel7.Text = "Periodo"
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Tool_Reporte, Me.ToolStripSeparator2, Me.Tool_Salir, Me.ToolStripSeparator1})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(895, 25)
        Me.ToolStrip1.TabIndex = 25
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'Tool_Reporte
        '
        Me.Tool_Reporte.Image = Global.Contabilidad.My.Resources.Resources._004
        Me.Tool_Reporte.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Tool_Reporte.Name = "Tool_Reporte"
        Me.Tool_Reporte.Size = New System.Drawing.Size(68, 22)
        Me.Tool_Reporte.Text = "Reporte"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'Tool_Salir
        '
        Me.Tool_Salir.Image = Global.Contabilidad.My.Resources.Resources._28
        Me.Tool_Salir.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Tool_Salir.Name = "Tool_Salir"
        Me.Tool_Salir.Size = New System.Drawing.Size(49, 22)
        Me.Tool_Salir.Text = "Salir"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'ug_lista
        '
        Me.ug_lista.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ug_lista.DisplayLayout.AutoFitStyle = Infragistics.Win.UltraWinGrid.AutoFitStyle.ExtendLastColumn
        UltraGridColumn1.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn1.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn1.Header.VisiblePosition = 0
        UltraGridColumn1.Width = 40
        UltraGridColumn2.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn2.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn2.Header.VisiblePosition = 1
        UltraGridColumn2.Width = 244
        UltraGridColumn3.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn3.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        Appearance9.TextHAlignAsString = "Right"
        UltraGridColumn3.CellAppearance = Appearance9
        UltraGridColumn3.Header.Caption = "Número de horas laboradas "
        UltraGridColumn3.Header.VisiblePosition = 2
        UltraGridColumn3.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Double]
        UltraGridColumn3.Width = 147
        UltraGridColumn4.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn4.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        Appearance10.TextHAlignAsString = "Right"
        UltraGridColumn4.CellAppearance = Appearance10
        UltraGridColumn4.Header.Caption = "Participación del trabajador "
        UltraGridColumn4.Header.VisiblePosition = 3
        UltraGridColumn4.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Double]
        UltraGridColumn4.Width = 134
        UltraGridColumn5.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn5.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        Appearance13.TextHAlignAsString = "Right"
        UltraGridColumn5.CellAppearance = Appearance13
        UltraGridColumn5.Header.Caption = "Remuneración computable percibida "
        UltraGridColumn5.Header.VisiblePosition = 4
        UltraGridColumn5.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Double]
        UltraGridColumn5.Width = 127
        UltraGridColumn6.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn6.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        Appearance14.TextHAlignAsString = "Right"
        UltraGridColumn6.CellAppearance = Appearance14
        UltraGridColumn6.Header.Caption = "Participación del trabajador "
        UltraGridColumn6.Header.VisiblePosition = 5
        UltraGridColumn6.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Double]
        UltraGridBand1.Columns.AddRange(New Object() {UltraGridColumn1, UltraGridColumn2, UltraGridColumn3, UltraGridColumn4, UltraGridColumn5, UltraGridColumn6})
        Me.ug_lista.DisplayLayout.BandsSerializer.Add(UltraGridBand1)
        Me.ug_lista.DisplayLayout.MaxColScrollRegions = 1
        Me.ug_lista.DisplayLayout.MaxRowScrollRegions = 1
        Me.ug_lista.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.ug_lista.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.ug_lista.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ug_lista.Location = New System.Drawing.Point(12, 169)
        Me.ug_lista.Name = "ug_lista"
        Me.ug_lista.Size = New System.Drawing.Size(871, 284)
        Me.ug_lista.TabIndex = 27
        '
        'uds_lista
        '
        UltraDataColumn4.DataType = GetType(Double)
        UltraDataColumn5.DataType = GetType(Double)
        UltraDataColumn6.DataType = GetType(Double)
        Me.uds_lista.Band.Columns.AddRange(New Object() {UltraDataColumn1, UltraDataColumn2, UltraDataColumn3, UltraDataColumn4, UltraDataColumn5, UltraDataColumn6})
        '
        'UltraGroupBox1
        '
        Me.UltraGroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.UltraGroupBox1.Controls.Add(Me.txt_remu_compu)
        Me.UltraGroupBox1.Controls.Add(Me.txt_num_tot_hor)
        Me.UltraGroupBox1.Controls.Add(Me.txt_monto_distri)
        Me.UltraGroupBox1.Controls.Add(Me.txt_porc_distri)
        Me.UltraGroupBox1.Controls.Add(Me.txt_renta_anual)
        Me.UltraGroupBox1.Controls.Add(Me.UltraLabel5)
        Me.UltraGroupBox1.Controls.Add(Me.UltraLabel4)
        Me.UltraGroupBox1.Controls.Add(Me.UltraLabel1)
        Me.UltraGroupBox1.Controls.Add(Me.UltraLabel3)
        Me.UltraGroupBox1.Controls.Add(Me.UltraLabel2)
        Me.UltraGroupBox1.Location = New System.Drawing.Point(12, 68)
        Me.UltraGroupBox1.Name = "UltraGroupBox1"
        Me.UltraGroupBox1.Size = New System.Drawing.Size(870, 95)
        Me.UltraGroupBox1.TabIndex = 28
        '
        'txt_remu_compu
        '
        Me.txt_remu_compu.Location = New System.Drawing.Point(569, 39)
        Me.txt_remu_compu.Name = "txt_remu_compu"
        Me.txt_remu_compu.ReadOnly = True
        Me.txt_remu_compu.Size = New System.Drawing.Size(100, 21)
        Me.txt_remu_compu.TabIndex = 144
        '
        'txt_num_tot_hor
        '
        Me.txt_num_tot_hor.Location = New System.Drawing.Point(569, 15)
        Me.txt_num_tot_hor.Name = "txt_num_tot_hor"
        Me.txt_num_tot_hor.ReadOnly = True
        Me.txt_num_tot_hor.Size = New System.Drawing.Size(100, 21)
        Me.txt_num_tot_hor.TabIndex = 143
        '
        'txt_monto_distri
        '
        Me.txt_monto_distri.Location = New System.Drawing.Point(167, 66)
        Me.txt_monto_distri.Name = "txt_monto_distri"
        Me.txt_monto_distri.ReadOnly = True
        Me.txt_monto_distri.Size = New System.Drawing.Size(100, 21)
        Me.txt_monto_distri.TabIndex = 142
        '
        'txt_porc_distri
        '
        Me.txt_porc_distri.Location = New System.Drawing.Point(167, 42)
        Me.txt_porc_distri.Name = "txt_porc_distri"
        Me.txt_porc_distri.ReadOnly = True
        Me.txt_porc_distri.Size = New System.Drawing.Size(100, 21)
        Me.txt_porc_distri.TabIndex = 141
        '
        'txt_renta_anual
        '
        Me.txt_renta_anual.Location = New System.Drawing.Point(167, 15)
        Me.txt_renta_anual.Name = "txt_renta_anual"
        Me.txt_renta_anual.ReadOnly = True
        Me.txt_renta_anual.Size = New System.Drawing.Size(100, 21)
        Me.txt_renta_anual.TabIndex = 140
        '
        'UltraLabel5
        '
        Appearance72.BackColor = System.Drawing.Color.Transparent
        Appearance72.ForeColor = System.Drawing.Color.Navy
        Appearance72.TextHAlignAsString = "Right"
        Me.UltraLabel5.Appearance = Appearance72
        Me.UltraLabel5.AutoSize = True
        Me.UltraLabel5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel5.Location = New System.Drawing.Point(343, 39)
        Me.UltraLabel5.Name = "UltraLabel5"
        Me.UltraLabel5.Size = New System.Drawing.Size(186, 16)
        Me.UltraLabel5.TabIndex = 139
        Me.UltraLabel5.Text = "Remuneracion Computable Total "
        '
        'UltraLabel4
        '
        Appearance8.BackColor = System.Drawing.Color.Transparent
        Appearance8.ForeColor = System.Drawing.Color.Navy
        Appearance8.TextHAlignAsString = "Right"
        Me.UltraLabel4.Appearance = Appearance8
        Me.UltraLabel4.AutoSize = True
        Me.UltraLabel4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel4.Location = New System.Drawing.Point(343, 17)
        Me.UltraLabel4.Name = "UltraLabel4"
        Me.UltraLabel4.Size = New System.Drawing.Size(179, 16)
        Me.UltraLabel4.TabIndex = 138
        Me.UltraLabel4.Text = "Num. Total de Horas trabajadas"
        '
        'UltraLabel1
        '
        Appearance6.BackColor = System.Drawing.Color.Transparent
        Appearance6.ForeColor = System.Drawing.Color.Navy
        Appearance6.TextHAlignAsString = "Right"
        Me.UltraLabel1.Appearance = Appearance6
        Me.UltraLabel1.AutoSize = True
        Me.UltraLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel1.Location = New System.Drawing.Point(10, 39)
        Me.UltraLabel1.Name = "UltraLabel1"
        Me.UltraLabel1.Size = New System.Drawing.Size(132, 16)
        Me.UltraLabel1.TabIndex = 137
        Me.UltraLabel1.Text = "Porcentaje Distribucion"
        '
        'UltraLabel3
        '
        Appearance2.BackColor = System.Drawing.Color.Transparent
        Appearance2.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel3.Appearance = Appearance2
        Me.UltraLabel3.AutoSize = True
        Me.UltraLabel3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel3.Location = New System.Drawing.Point(10, 61)
        Me.UltraLabel3.Name = "UltraLabel3"
        Me.UltraLabel3.Size = New System.Drawing.Size(107, 16)
        Me.UltraLabel3.TabIndex = 136
        Me.UltraLabel3.Text = "Monto Distribucion"
        '
        'UltraLabel2
        '
        Appearance1.BackColor = System.Drawing.Color.Transparent
        Appearance1.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel2.Appearance = Appearance1
        Me.UltraLabel2.AutoSize = True
        Me.UltraLabel2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel2.Location = New System.Drawing.Point(10, 17)
        Me.UltraLabel2.Name = "UltraLabel2"
        Me.UltraLabel2.Size = New System.Drawing.Size(72, 16)
        Me.UltraLabel2.TabIndex = 135
        Me.UltraLabel2.Text = "Renta Anual"
        '
        'UltraLabel8
        '
        Appearance23.BackColor = System.Drawing.Color.Transparent
        Appearance23.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel8.Appearance = Appearance23
        Me.UltraLabel8.AutoSize = True
        Me.UltraLabel8.Location = New System.Drawing.Point(144, 12)
        Me.UltraLabel8.Name = "UltraLabel8"
        Me.UltraLabel8.Size = New System.Drawing.Size(154, 14)
        Me.UltraLabel8.TabIndex = 143
        Me.UltraLabel8.Text = "[Ingrese año y presione enter]"
        '
        'PL_RP_Certi_UtilidadPer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(895, 465)
        Me.Controls.Add(Me.UltraGroupBox1)
        Me.Controls.Add(Me.ug_lista)
        Me.Controls.Add(Me.ugb_Parametros)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Name = "PL_RP_Certi_UtilidadPer"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Certificado de  Utilidades del Personal"
        CType(Me.ugb_Parametros, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ugb_Parametros.ResumeLayout(False)
        Me.ugb_Parametros.PerformLayout()
        CType(Me.txt_fec, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.une_ayo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        CType(Me.ug_lista, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.uds_lista, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UltraGroupBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraGroupBox1.ResumeLayout(False)
        Me.UltraGroupBox1.PerformLayout()
        CType(Me.txt_remu_compu, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_num_tot_hor, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_monto_distri, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_porc_distri, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_renta_anual, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ugb_Parametros As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents une_ayo As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents UltraLabel7 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents Tool_Reporte As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents Tool_Salir As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ug_lista As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents uds_lista As Infragistics.Win.UltraWinDataSource.UltraDataSource
    Friend WithEvents UltraGroupBox1 As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents UltraLabel1 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel3 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel2 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel5 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel4 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents txt_remu_compu As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents txt_num_tot_hor As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents txt_monto_distri As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents txt_porc_distri As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents txt_renta_anual As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents txt_fec As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents UltraLabel6 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel8 As Infragistics.Win.Misc.UltraLabel
End Class
