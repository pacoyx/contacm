<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PL_PR_Calculo_Utilidad
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
        Dim Appearance7 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance5 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance8 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance6 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance3 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance2 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance11 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance12 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance1 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance4 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridBand1 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1)
        Dim UltraGridColumn1 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("idpersonal")
        Dim UltraGridColumn2 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("nombres")
        Dim UltraGridColumn3 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("num_horas")
        Dim Appearance9 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn4 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("fact_horas")
        Dim UltraGridColumn5 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("participa_horas")
        Dim Appearance10 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn6 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("computable_emp")
        Dim Appearance13 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn7 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("fact_remu")
        Dim UltraGridColumn8 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("participa_emp")
        Dim Appearance14 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn9 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("total_util")
        Dim Appearance15 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraDataColumn1 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("idpersonal")
        Dim UltraDataColumn2 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("nombres")
        Dim UltraDataColumn3 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("num_horas")
        Dim UltraDataColumn4 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("fact_horas")
        Dim UltraDataColumn5 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("participa_horas")
        Dim UltraDataColumn6 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("computable_emp")
        Dim UltraDataColumn7 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("fact_remu")
        Dim UltraDataColumn8 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("participa_emp")
        Dim UltraDataColumn9 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("total_util")
        Dim Appearance72 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.Tool_grabar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.Tool_Imprimir = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator6 = New System.Windows.Forms.ToolStripSeparator()
        Me.Tool_Salir = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator()
        Me.ugb_Parametros = New Infragistics.Win.Misc.UltraGroupBox()
        Me.UltraLabel5 = New Infragistics.Win.Misc.UltraLabel()
        Me.txt_tot_remu = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.txt_tot_horas = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.ume_porcentaje = New Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit()
        Me.UltraLabel4 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraLabel1 = New Infragistics.Win.Misc.UltraLabel()
        Me.ume_monto_distri = New Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit()
        Me.UltraLabel3 = New Infragistics.Win.Misc.UltraLabel()
        Me.ume_renta_anual = New Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit()
        Me.UltraLabel2 = New Infragistics.Win.Misc.UltraLabel()
        Me.une_Ayo = New Infragistics.Win.UltraWinEditors.UltraNumericEditor()
        Me.UltraLabel7 = New Infragistics.Win.Misc.UltraLabel()
        Me.ug_lista = New Infragistics.Win.UltraWinGrid.UltraGrid()
        Me.uds_lista = New Infragistics.Win.UltraWinDataSource.UltraDataSource(Me.components)
        Me.btn_agregar = New Infragistics.Win.Misc.UltraButton()
        Me.btn_eliminar = New Infragistics.Win.Misc.UltraButton()
        Me.ubtn_procesar = New Infragistics.Win.Misc.UltraButton()
        Me.UltraGroupBox1 = New Infragistics.Win.Misc.UltraGroupBox()
        Me.UltraLabel6 = New Infragistics.Win.Misc.UltraLabel()
        Me.ToolStrip1.SuspendLayout()
        CType(Me.ugb_Parametros, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ugb_Parametros.SuspendLayout()
        CType(Me.txt_tot_remu, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_tot_horas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.une_Ayo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ug_lista, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.uds_lista, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UltraGroupBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraGroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ToolStrip1
        '
        Me.ToolStrip1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripSeparator3, Me.Tool_grabar, Me.ToolStripSeparator2, Me.Tool_Imprimir, Me.ToolStripSeparator6, Me.Tool_Salir, Me.ToolStripSeparator5})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(983, 25)
        Me.ToolStrip1.TabIndex = 14
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 25)
        '
        'Tool_grabar
        '
        Me.Tool_grabar.Image = Global.Contabilidad.My.Resources.Resources._003
        Me.Tool_grabar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Tool_grabar.Name = "Tool_grabar"
        Me.Tool_grabar.Size = New System.Drawing.Size(77, 22)
        Me.Tool_grabar.Text = "Grabar     "
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
        Me.Tool_Imprimir.Size = New System.Drawing.Size(73, 22)
        Me.Tool_Imprimir.Text = "Imprimir"
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
        'ToolStripSeparator5
        '
        Me.ToolStripSeparator5.Name = "ToolStripSeparator5"
        Me.ToolStripSeparator5.Size = New System.Drawing.Size(6, 25)
        '
        'ugb_Parametros
        '
        Me.ugb_Parametros.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ugb_Parametros.Controls.Add(Me.UltraLabel6)
        Me.ugb_Parametros.Controls.Add(Me.UltraLabel5)
        Me.ugb_Parametros.Controls.Add(Me.txt_tot_remu)
        Me.ugb_Parametros.Controls.Add(Me.txt_tot_horas)
        Me.ugb_Parametros.Controls.Add(Me.ume_porcentaje)
        Me.ugb_Parametros.Controls.Add(Me.UltraLabel4)
        Me.ugb_Parametros.Controls.Add(Me.UltraLabel1)
        Me.ugb_Parametros.Controls.Add(Me.ume_monto_distri)
        Me.ugb_Parametros.Controls.Add(Me.UltraLabel3)
        Me.ugb_Parametros.Controls.Add(Me.ume_renta_anual)
        Me.ugb_Parametros.Controls.Add(Me.UltraLabel2)
        Me.ugb_Parametros.Location = New System.Drawing.Point(12, 89)
        Me.ugb_Parametros.Name = "ugb_Parametros"
        Me.ugb_Parametros.Size = New System.Drawing.Size(955, 124)
        Me.ugb_Parametros.TabIndex = 15
        Me.ugb_Parametros.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.XP
        '
        'UltraLabel5
        '
        Appearance7.BackColor = System.Drawing.Color.Transparent
        Appearance7.ForeColor = System.Drawing.Color.Navy
        Appearance7.TextHAlignAsString = "Right"
        Me.UltraLabel5.Appearance = Appearance7
        Me.UltraLabel5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel5.Location = New System.Drawing.Point(338, 62)
        Me.UltraLabel5.Name = "UltraLabel5"
        Me.UltraLabel5.Size = New System.Drawing.Size(108, 34)
        Me.UltraLabel5.TabIndex = 136
        Me.UltraLabel5.Text = "Remuneracion Computable Total "
        '
        'txt_tot_remu
        '
        Me.txt_tot_remu.Location = New System.Drawing.Point(452, 62)
        Me.txt_tot_remu.Name = "txt_tot_remu"
        Me.txt_tot_remu.ReadOnly = True
        Me.txt_tot_remu.Size = New System.Drawing.Size(151, 21)
        Me.txt_tot_remu.TabIndex = 20
        '
        'txt_tot_horas
        '
        Me.txt_tot_horas.Location = New System.Drawing.Point(452, 17)
        Me.txt_tot_horas.Name = "txt_tot_horas"
        Me.txt_tot_horas.ReadOnly = True
        Me.txt_tot_horas.Size = New System.Drawing.Size(151, 21)
        Me.txt_tot_horas.TabIndex = 19
        '
        'ume_porcentaje
        '
        Appearance5.TextHAlignAsString = "Right"
        Me.ume_porcentaje.Appearance = Appearance5
        Me.ume_porcentaje.EditAs = Infragistics.Win.UltraWinMaskedEdit.EditAsType.Currency
        Me.ume_porcentaje.InputMask = "{double:-9.2}"
        Me.ume_porcentaje.Location = New System.Drawing.Point(118, 51)
        Me.ume_porcentaje.Name = "ume_porcentaje"
        Me.ume_porcentaje.Size = New System.Drawing.Size(109, 20)
        Me.ume_porcentaje.TabIndex = 133
        '
        'UltraLabel4
        '
        Appearance8.BackColor = System.Drawing.Color.Transparent
        Appearance8.ForeColor = System.Drawing.Color.Navy
        Appearance8.TextHAlignAsString = "Right"
        Me.UltraLabel4.Appearance = Appearance8
        Me.UltraLabel4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel4.Location = New System.Drawing.Point(338, 13)
        Me.UltraLabel4.Name = "UltraLabel4"
        Me.UltraLabel4.Size = New System.Drawing.Size(108, 34)
        Me.UltraLabel4.TabIndex = 134
        Me.UltraLabel4.Text = "Num. Total de Horas trabajadas"
        '
        'UltraLabel1
        '
        Appearance6.BackColor = System.Drawing.Color.Transparent
        Appearance6.ForeColor = System.Drawing.Color.Navy
        Appearance6.TextHAlignAsString = "Right"
        Me.UltraLabel1.Appearance = Appearance6
        Me.UltraLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel1.Location = New System.Drawing.Point(12, 43)
        Me.UltraLabel1.Name = "UltraLabel1"
        Me.UltraLabel1.Size = New System.Drawing.Size(97, 40)
        Me.UltraLabel1.TabIndex = 134
        Me.UltraLabel1.Text = "Porcentaje Distribucion"
        '
        'ume_monto_distri
        '
        Appearance3.TextHAlignAsString = "Right"
        Me.ume_monto_distri.Appearance = Appearance3
        Me.ume_monto_distri.EditAs = Infragistics.Win.UltraWinMaskedEdit.EditAsType.Currency
        Me.ume_monto_distri.InputMask = "{double:-9.2}"
        Me.ume_monto_distri.Location = New System.Drawing.Point(118, 86)
        Me.ume_monto_distri.Name = "ume_monto_distri"
        Me.ume_monto_distri.Size = New System.Drawing.Size(109, 20)
        Me.ume_monto_distri.TabIndex = 133
        '
        'UltraLabel3
        '
        Appearance2.BackColor = System.Drawing.Color.Transparent
        Appearance2.ForeColor = System.Drawing.Color.Navy
        Appearance2.TextHAlignAsString = "Right"
        Me.UltraLabel3.Appearance = Appearance2
        Me.UltraLabel3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel3.Location = New System.Drawing.Point(22, 81)
        Me.UltraLabel3.Name = "UltraLabel3"
        Me.UltraLabel3.Size = New System.Drawing.Size(90, 30)
        Me.UltraLabel3.TabIndex = 134
        Me.UltraLabel3.Text = "Monto Distribucion"
        '
        'ume_renta_anual
        '
        Appearance11.TextHAlignAsString = "Right"
        Me.ume_renta_anual.Appearance = Appearance11
        Me.ume_renta_anual.EditAs = Infragistics.Win.UltraWinMaskedEdit.EditAsType.Currency
        Me.ume_renta_anual.InputMask = "{double:-9.2}"
        Me.ume_renta_anual.Location = New System.Drawing.Point(118, 15)
        Me.ume_renta_anual.Name = "ume_renta_anual"
        Me.ume_renta_anual.Size = New System.Drawing.Size(109, 20)
        Me.ume_renta_anual.TabIndex = 133
        '
        'UltraLabel2
        '
        Appearance12.BackColor = System.Drawing.Color.Transparent
        Appearance12.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel2.Appearance = Appearance12
        Me.UltraLabel2.AutoSize = True
        Me.UltraLabel2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel2.Location = New System.Drawing.Point(37, 17)
        Me.UltraLabel2.Name = "UltraLabel2"
        Me.UltraLabel2.Size = New System.Drawing.Size(72, 16)
        Me.UltraLabel2.TabIndex = 134
        Me.UltraLabel2.Text = "Renta Anual"
        '
        'une_Ayo
        '
        Appearance1.TextHAlignAsString = "Center"
        Me.une_Ayo.Appearance = Appearance1
        Me.une_Ayo.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.une_Ayo.Location = New System.Drawing.Point(54, 14)
        Me.une_Ayo.MaskInput = "nnnn"
        Me.une_Ayo.Name = "une_Ayo"
        Me.une_Ayo.Size = New System.Drawing.Size(71, 26)
        Me.une_Ayo.TabIndex = 13
        '
        'UltraLabel7
        '
        Appearance4.BackColor = System.Drawing.Color.Transparent
        Appearance4.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel7.Appearance = Appearance4
        Me.UltraLabel7.AutoSize = True
        Me.UltraLabel7.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel7.Location = New System.Drawing.Point(15, 18)
        Me.UltraLabel7.Name = "UltraLabel7"
        Me.UltraLabel7.Size = New System.Drawing.Size(36, 19)
        Me.UltraLabel7.TabIndex = 12
        Me.UltraLabel7.Text = "Año:"
        '
        'ug_lista
        '
        Me.ug_lista.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ug_lista.DataSource = Me.uds_lista
        Me.ug_lista.DisplayLayout.AutoFitStyle = Infragistics.Win.UltraWinGrid.AutoFitStyle.ExtendLastColumn
        UltraGridColumn1.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn1.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn1.Header.VisiblePosition = 0
        UltraGridColumn1.RowLayoutColumnInfo.OriginX = 0
        UltraGridColumn1.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn1.RowLayoutColumnInfo.PreferredLabelSize = New System.Drawing.Size(0, 40)
        UltraGridColumn1.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn1.RowLayoutColumnInfo.SpanY = 3
        UltraGridColumn1.Width = 40
        UltraGridColumn2.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn2.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn2.Header.VisiblePosition = 1
        UltraGridColumn2.RowLayoutColumnInfo.OriginX = 2
        UltraGridColumn2.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn2.RowLayoutColumnInfo.PreferredLabelSize = New System.Drawing.Size(0, 40)
        UltraGridColumn2.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn2.RowLayoutColumnInfo.SpanY = 3
        UltraGridColumn2.Width = 292
        UltraGridColumn3.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        Appearance9.TextHAlignAsString = "Right"
        UltraGridColumn3.CellAppearance = Appearance9
        UltraGridColumn3.Header.Caption = "Número de horas laboradas "
        UltraGridColumn3.Header.VisiblePosition = 2
        UltraGridColumn3.MaskInput = ""
        UltraGridColumn3.RowLayoutColumnInfo.OriginX = 4
        UltraGridColumn3.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn3.RowLayoutColumnInfo.PreferredLabelSize = New System.Drawing.Size(0, 40)
        UltraGridColumn3.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn3.RowLayoutColumnInfo.SpanY = 3
        UltraGridColumn4.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn4.Header.VisiblePosition = 3
        UltraGridColumn4.RowLayoutColumnInfo.OriginX = 6
        UltraGridColumn4.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn4.RowLayoutColumnInfo.PreferredLabelSize = New System.Drawing.Size(0, 40)
        UltraGridColumn4.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn4.RowLayoutColumnInfo.SpanY = 3
        UltraGridColumn4.Width = 68
        UltraGridColumn5.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        Appearance10.TextHAlignAsString = "Right"
        UltraGridColumn5.CellAppearance = Appearance10
        UltraGridColumn5.Header.Caption = "Participación del trabajador "
        UltraGridColumn5.Header.VisiblePosition = 4
        UltraGridColumn5.RowLayoutColumnInfo.OriginX = 8
        UltraGridColumn5.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn5.RowLayoutColumnInfo.PreferredLabelSize = New System.Drawing.Size(0, 40)
        UltraGridColumn5.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn5.RowLayoutColumnInfo.SpanY = 3
        UltraGridColumn5.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Double]
        UltraGridColumn5.Width = 140
        UltraGridColumn6.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        Appearance13.TextHAlignAsString = "Right"
        UltraGridColumn6.CellAppearance = Appearance13
        UltraGridColumn6.Header.Caption = "Remuneración computable percibida "
        UltraGridColumn6.Header.VisiblePosition = 5
        UltraGridColumn6.RowLayoutColumnInfo.OriginX = 10
        UltraGridColumn6.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn6.RowLayoutColumnInfo.PreferredLabelSize = New System.Drawing.Size(0, 40)
        UltraGridColumn6.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn6.RowLayoutColumnInfo.SpanY = 3
        UltraGridColumn6.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Double]
        UltraGridColumn6.Width = 134
        UltraGridColumn7.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn7.Header.VisiblePosition = 6
        UltraGridColumn7.RowLayoutColumnInfo.OriginX = 12
        UltraGridColumn7.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn7.RowLayoutColumnInfo.PreferredLabelSize = New System.Drawing.Size(0, 40)
        UltraGridColumn7.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn7.RowLayoutColumnInfo.SpanY = 3
        UltraGridColumn7.Width = 69
        UltraGridColumn8.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        Appearance14.TextHAlignAsString = "Right"
        UltraGridColumn8.CellAppearance = Appearance14
        UltraGridColumn8.Header.Caption = "Participación del trabajador "
        UltraGridColumn8.Header.VisiblePosition = 7
        UltraGridColumn8.RowLayoutColumnInfo.OriginX = 14
        UltraGridColumn8.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn8.RowLayoutColumnInfo.PreferredLabelSize = New System.Drawing.Size(0, 40)
        UltraGridColumn8.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn8.RowLayoutColumnInfo.SpanY = 3
        UltraGridColumn8.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Double]
        UltraGridColumn9.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn9.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        Appearance15.TextHAlignAsString = "Right"
        UltraGridColumn9.CellAppearance = Appearance15
        UltraGridColumn9.Header.VisiblePosition = 8
        UltraGridColumn9.RowLayoutColumnInfo.OriginX = 16
        UltraGridColumn9.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn9.RowLayoutColumnInfo.PreferredLabelSize = New System.Drawing.Size(0, 40)
        UltraGridColumn9.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn9.RowLayoutColumnInfo.SpanY = 3
        UltraGridColumn9.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Double]
        UltraGridBand1.Columns.AddRange(New Object() {UltraGridColumn1, UltraGridColumn2, UltraGridColumn3, UltraGridColumn4, UltraGridColumn5, UltraGridColumn6, UltraGridColumn7, UltraGridColumn8, UltraGridColumn9})
        UltraGridBand1.UseRowLayout = True
        Me.ug_lista.DisplayLayout.BandsSerializer.Add(UltraGridBand1)
        Me.ug_lista.DisplayLayout.MaxColScrollRegions = 1
        Me.ug_lista.DisplayLayout.MaxRowScrollRegions = 1
        Me.ug_lista.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.ug_lista.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.ug_lista.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ug_lista.Location = New System.Drawing.Point(12, 252)
        Me.ug_lista.Name = "ug_lista"
        Me.ug_lista.Size = New System.Drawing.Size(955, 340)
        Me.ug_lista.TabIndex = 16
        '
        'uds_lista
        '
        UltraDataColumn5.DataType = GetType(Double)
        UltraDataColumn6.DataType = GetType(Double)
        UltraDataColumn8.DataType = GetType(Double)
        Me.uds_lista.Band.Columns.AddRange(New Object() {UltraDataColumn1, UltraDataColumn2, UltraDataColumn3, UltraDataColumn4, UltraDataColumn5, UltraDataColumn6, UltraDataColumn7, UltraDataColumn8, UltraDataColumn9})
        '
        'btn_agregar
        '
        Me.btn_agregar.Location = New System.Drawing.Point(12, 219)
        Me.btn_agregar.Name = "btn_agregar"
        Me.btn_agregar.Size = New System.Drawing.Size(139, 27)
        Me.btn_agregar.TabIndex = 17
        Me.btn_agregar.Text = "Agregar trabajador"
        '
        'btn_eliminar
        '
        Me.btn_eliminar.Location = New System.Drawing.Point(164, 219)
        Me.btn_eliminar.Name = "btn_eliminar"
        Me.btn_eliminar.Size = New System.Drawing.Size(116, 27)
        Me.btn_eliminar.TabIndex = 18
        Me.btn_eliminar.Text = "Eliminar"
        '
        'ubtn_procesar
        '
        Me.ubtn_procesar.Location = New System.Drawing.Point(854, 219)
        Me.ubtn_procesar.Name = "ubtn_procesar"
        Me.ubtn_procesar.Size = New System.Drawing.Size(113, 27)
        Me.ubtn_procesar.TabIndex = 21
        Me.ubtn_procesar.Text = "Procesar"
        '
        'UltraGroupBox1
        '
        Me.UltraGroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.UltraGroupBox1.Controls.Add(Me.une_Ayo)
        Me.UltraGroupBox1.Controls.Add(Me.UltraLabel7)
        Me.UltraGroupBox1.Location = New System.Drawing.Point(12, 34)
        Me.UltraGroupBox1.Name = "UltraGroupBox1"
        Me.UltraGroupBox1.Size = New System.Drawing.Size(954, 46)
        Me.UltraGroupBox1.TabIndex = 22
        '
        'UltraLabel6
        '
        Appearance72.BackColor = System.Drawing.Color.Transparent
        Appearance72.ForeColor = System.Drawing.Color.Navy
        Appearance72.TextHAlignAsString = "Left"
        Me.UltraLabel6.Appearance = Appearance72
        Me.UltraLabel6.BorderStyleInner = Infragistics.Win.UIElementBorderStyle.Solid
        Me.UltraLabel6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel6.Location = New System.Drawing.Point(690, 16)
        Me.UltraLabel6.Name = "UltraLabel6"
        Me.UltraLabel6.Size = New System.Drawing.Size(259, 92)
        Me.UltraLabel6.TabIndex = 137
        Me.UltraLabel6.Text = "Pasos:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "1.-Ingresar cada trabajador" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "2.-Ingresar total de horas en 'numero de hor" & _
    "as labioradas'" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "3.-Ingresar total remuneracion en la columna 'Remuneracion compu" & _
    "table'"
        '
        'PL_PR_Calculo_Utilidad
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(983, 604)
        Me.Controls.Add(Me.UltraGroupBox1)
        Me.Controls.Add(Me.ubtn_procesar)
        Me.Controls.Add(Me.btn_eliminar)
        Me.Controls.Add(Me.btn_agregar)
        Me.Controls.Add(Me.ug_lista)
        Me.Controls.Add(Me.ugb_Parametros)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Name = "PL_PR_Calculo_Utilidad"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Utilidades"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        CType(Me.ugb_Parametros, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ugb_Parametros.ResumeLayout(False)
        Me.ugb_Parametros.PerformLayout()
        CType(Me.txt_tot_remu, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_tot_horas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.une_Ayo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ug_lista, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.uds_lista, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UltraGroupBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraGroupBox1.ResumeLayout(False)
        Me.UltraGroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents Tool_Imprimir As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator6 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents Tool_Salir As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator5 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ugb_Parametros As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents une_Ayo As Infragistics.Win.UltraWinEditors.UltraNumericEditor
    Friend WithEvents UltraLabel7 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents ug_lista As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents btn_agregar As Infragistics.Win.Misc.UltraButton
    Friend WithEvents uds_lista As Infragistics.Win.UltraWinDataSource.UltraDataSource
    Public WithEvents ume_porcentaje As Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit
    Friend WithEvents UltraLabel4 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel1 As Infragistics.Win.Misc.UltraLabel
    Public WithEvents ume_monto_distri As Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit
    Friend WithEvents UltraLabel3 As Infragistics.Win.Misc.UltraLabel
    Public WithEvents ume_renta_anual As Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit
    Friend WithEvents UltraLabel2 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents Tool_grabar As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents UltraLabel5 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents btn_eliminar As Infragistics.Win.Misc.UltraButton
    Friend WithEvents txt_tot_horas As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents txt_tot_remu As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents ubtn_procesar As Infragistics.Win.Misc.UltraButton
    Friend WithEvents UltraGroupBox1 As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents UltraLabel6 As Infragistics.Win.Misc.UltraLabel
End Class
