<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PL_PR_Calculo_Grati
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
        Dim ValueListItem2 As Infragistics.Win.ValueListItem = New Infragistics.Win.ValueListItem()
        Dim ValueListItem3 As Infragistics.Win.ValueListItem = New Infragistics.Win.ValueListItem()
        Dim Appearance1 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim EditorButton1 As Infragistics.Win.UltraWinEditors.EditorButton = New Infragistics.Win.UltraWinEditors.EditorButton()
        Dim Appearance6 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance4 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance23 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance12 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraDataColumn1 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("TIPO_PER")
        Dim UltraDataColumn2 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("COD_PER")
        Dim UltraDataColumn3 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("NOM_PER")
        Dim UltraDataColumn4 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("REMU_BASICA")
        Dim UltraDataColumn5 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("ASIG_FAMILIAR")
        Dim UltraDataColumn6 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("RIESGO_CAJA")
        Dim UltraDataColumn7 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("PROMEDIO_HE")
        Dim UltraDataColumn8 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("PROMEDIO_BONI")
        Dim UltraDataColumn9 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("BONO_9")
        Dim UltraDataColumn10 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("MESES_TRABAJADOS")
        Dim UltraDataColumn11 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("TOTAL_COMPU")
        Dim UltraDataColumn12 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("REMU_VARI")
        Dim UltraDataColumn13 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("REFRIGERIO")
        Dim UltraDataColumn14 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("TOTAL")
        Dim UltraDataColumn15 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("NORMAL")
        Dim UltraDataColumn16 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("INTERMEDIO")
        Dim UltraDataColumn17 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("UCIN")
        Dim UltraDataColumn18 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("COMPEN_VACA")
        Dim UltraDataColumn19 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("BONO_ENCARGA")
        Dim UltraDataColumn20 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("SUBTOTAL")
        Dim UltraDataColumn21 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("TOTAL_HORAS")
        Dim UltraGridBand1 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1)
        Dim UltraGridColumn1 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TIPO_PER")
        Dim UltraGridColumn2 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("COD_PER")
        Dim UltraGridColumn3 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NOM_PER", -1, Nothing, 0, Infragistics.Win.UltraWinGrid.SortIndicator.Ascending, False)
        Dim UltraGridColumn4 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("REMU_BASICA")
        Dim Appearance2 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn5 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ASIG_FAMILIAR")
        Dim Appearance3 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn6 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("RIESGO_CAJA")
        Dim Appearance5 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn7 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("PROMEDIO_HE")
        Dim Appearance7 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn8 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("PROMEDIO_BONI")
        Dim Appearance8 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn9 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("BONO_9")
        Dim Appearance9 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn10 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("MESES_TRABAJADOS")
        Dim Appearance10 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn11 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TOTAL_COMPU")
        Dim Appearance11 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn12 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("REMU_VARI")
        Dim Appearance13 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn13 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("REFRIGERIO")
        Dim Appearance14 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn14 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TOTAL")
        Dim Appearance15 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn15 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NORMAL")
        Dim Appearance16 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn16 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("INTERMEDIO")
        Dim Appearance17 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn17 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("UCIN")
        Dim Appearance18 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn18 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("COMPEN_VACA")
        Dim Appearance19 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn19 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("BONO_ENCARGA")
        Dim Appearance20 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn20 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("SUBTOTAL")
        Dim Appearance21 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn21 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TOTAL_HORAS")
        Dim Appearance22 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim SummarySettings1 As Infragistics.Win.UltraWinGrid.SummarySettings = New Infragistics.Win.UltraWinGrid.SummarySettings("", Infragistics.Win.UltraWinGrid.SummaryType.Sum, Nothing, "REMU_BASICA", 3, True, "Band 0", 0, Infragistics.Win.UltraWinGrid.SummaryPosition.UseSummaryPositionColumn, "REMU_BASICA", 3, True)
        Dim Appearance24 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance25 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance29 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.Tool_Procesar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.Tool_Exportar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.Tool_Imprimir = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator6 = New System.Windows.Forms.ToolStripSeparator()
        Me.Tool_Salir = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator()
        Me.ugb_Parametros = New Infragistics.Win.Misc.UltraGroupBox()
        Me.uos_Mes = New Infragistics.Win.UltraWinEditors.UltraOptionSet()
        Me.uchk_sem_com = New Infragistics.Win.UltraWinEditors.UltraCheckEditor()
        Me.upb_1 = New Infragistics.Win.UltraWinProgressBar.UltraProgressBar()
        Me.txt_idpersonal = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.une_Ayo = New Infragistics.Win.UltraWinEditors.UltraNumericEditor()
        Me.txt_nombres = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.uchk_Todos = New Infragistics.Win.UltraWinEditors.UltraCheckEditor()
        Me.txt_codper = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.UltraLabel7 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraLabel1 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraLabel8 = New Infragistics.Win.Misc.UltraLabel()
        Me.uce_TipoPersonal = New Infragistics.Win.UltraWinEditors.UltraComboEditor()
        Me.uge_grati = New Infragistics.Win.UltraWinGrid.ExcelExport.UltraGridExcelExporter(Me.components)
        Me.uds_grati = New Infragistics.Win.UltraWinDataSource.UltraDataSource(Me.components)
        Me.ug_grati = New Infragistics.Win.UltraWinGrid.UltraGrid()
        Me.ToolStrip1.SuspendLayout()
        CType(Me.ugb_Parametros, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ugb_Parametros.SuspendLayout()
        CType(Me.uos_Mes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_idpersonal, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.une_Ayo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_nombres, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_codper, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.uce_TipoPersonal, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.uds_grati, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ug_grati, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ToolStrip1
        '
        Me.ToolStrip1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripSeparator3, Me.Tool_Procesar, Me.ToolStripSeparator2, Me.Tool_Exportar, Me.ToolStripSeparator1, Me.Tool_Imprimir, Me.ToolStripSeparator6, Me.Tool_Salir, Me.ToolStripSeparator5})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(1000, 25)
        Me.ToolStrip1.TabIndex = 12
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 25)
        '
        'Tool_Procesar
        '
        Me.Tool_Procesar.Image = Global.Contabilidad.My.Resources.Resources._16__Configure_
        Me.Tool_Procesar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Tool_Procesar.Name = "Tool_Procesar"
        Me.Tool_Procesar.Size = New System.Drawing.Size(72, 22)
        Me.Tool_Procesar.Text = "Procesar"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'Tool_Exportar
        '
        Me.Tool_Exportar.Image = Global.Contabilidad.My.Resources.Resources._16__Doc_excel_
        Me.Tool_Exportar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Tool_Exportar.Name = "Tool_Exportar"
        Me.Tool_Exportar.Size = New System.Drawing.Size(70, 22)
        Me.Tool_Exportar.Text = "Exportar"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
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
        Me.ugb_Parametros.Controls.Add(Me.uos_Mes)
        Me.ugb_Parametros.Controls.Add(Me.uchk_sem_com)
        Me.ugb_Parametros.Controls.Add(Me.upb_1)
        Me.ugb_Parametros.Controls.Add(Me.txt_idpersonal)
        Me.ugb_Parametros.Controls.Add(Me.une_Ayo)
        Me.ugb_Parametros.Controls.Add(Me.txt_nombres)
        Me.ugb_Parametros.Controls.Add(Me.uchk_Todos)
        Me.ugb_Parametros.Controls.Add(Me.txt_codper)
        Me.ugb_Parametros.Controls.Add(Me.UltraLabel7)
        Me.ugb_Parametros.Controls.Add(Me.UltraLabel1)
        Me.ugb_Parametros.Controls.Add(Me.UltraLabel8)
        Me.ugb_Parametros.Controls.Add(Me.uce_TipoPersonal)
        Me.ugb_Parametros.Location = New System.Drawing.Point(12, 29)
        Me.ugb_Parametros.Name = "ugb_Parametros"
        Me.ugb_Parametros.Size = New System.Drawing.Size(980, 58)
        Me.ugb_Parametros.TabIndex = 13
        Me.ugb_Parametros.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.XP
        '
        'uos_Mes
        '
        Me.uos_Mes.BackColor = System.Drawing.Color.Transparent
        Me.uos_Mes.BackColorInternal = System.Drawing.Color.Transparent
        Me.uos_Mes.BorderStyle = Infragistics.Win.UIElementBorderStyle.None
        Me.uos_Mes.CheckedIndex = 0
        ValueListItem2.DataValue = CType(7, Short)
        ValueListItem2.DisplayText = "Julio"
        ValueListItem3.DataValue = CType(12, Short)
        ValueListItem3.DisplayText = "Diciembre"
        Me.uos_Mes.Items.AddRange(New Infragistics.Win.ValueListItem() {ValueListItem2, ValueListItem3})
        Me.uos_Mes.Location = New System.Drawing.Point(133, 12)
        Me.uos_Mes.Name = "uos_Mes"
        Me.uos_Mes.Size = New System.Drawing.Size(131, 17)
        Me.uos_Mes.TabIndex = 18
        Me.uos_Mes.Text = "Julio"
        '
        'uchk_sem_com
        '
        Me.uchk_sem_com.BackColor = System.Drawing.Color.Transparent
        Me.uchk_sem_com.BackColorInternal = System.Drawing.Color.Transparent
        Me.uchk_sem_com.Checked = True
        Me.uchk_sem_com.CheckState = System.Windows.Forms.CheckState.Checked
        Me.uchk_sem_com.Location = New System.Drawing.Point(11, 34)
        Me.uchk_sem_com.Name = "uchk_sem_com"
        Me.uchk_sem_com.Size = New System.Drawing.Size(142, 20)
        Me.uchk_sem_com.TabIndex = 16
        Me.uchk_sem_com.Text = "Semestre Completo"
        '
        'upb_1
        '
        Me.upb_1.Location = New System.Drawing.Point(327, 33)
        Me.upb_1.Name = "upb_1"
        Me.upb_1.Size = New System.Drawing.Size(364, 19)
        Me.upb_1.TabIndex = 17
        Me.upb_1.Text = "[Formatted]"
        '
        'txt_idpersonal
        '
        Me.txt_idpersonal.Location = New System.Drawing.Point(762, 12)
        Me.txt_idpersonal.Name = "txt_idpersonal"
        Me.txt_idpersonal.Size = New System.Drawing.Size(15, 21)
        Me.txt_idpersonal.TabIndex = 15
        Me.txt_idpersonal.Visible = False
        '
        'une_Ayo
        '
        Appearance1.TextHAlignAsString = "Center"
        Me.une_Ayo.Appearance = Appearance1
        Me.une_Ayo.Location = New System.Drawing.Point(41, 6)
        Me.une_Ayo.MaskInput = "nnnn"
        Me.une_Ayo.Name = "une_Ayo"
        Me.une_Ayo.Size = New System.Drawing.Size(36, 21)
        Me.une_Ayo.TabIndex = 13
        '
        'txt_nombres
        '
        Me.txt_nombres.Location = New System.Drawing.Point(504, 6)
        Me.txt_nombres.Name = "txt_nombres"
        Me.txt_nombres.ReadOnly = True
        Me.txt_nombres.Size = New System.Drawing.Size(187, 21)
        Me.txt_nombres.TabIndex = 1
        '
        'uchk_Todos
        '
        Me.uchk_Todos.BackColor = System.Drawing.Color.Transparent
        Me.uchk_Todos.BackColorInternal = System.Drawing.Color.Transparent
        Me.uchk_Todos.Checked = True
        Me.uchk_Todos.CheckState = System.Windows.Forms.CheckState.Checked
        Me.uchk_Todos.Location = New System.Drawing.Point(697, 9)
        Me.uchk_Todos.Name = "uchk_Todos"
        Me.uchk_Todos.Size = New System.Drawing.Size(59, 17)
        Me.uchk_Todos.TabIndex = 15
        Me.uchk_Todos.Text = "Todos"
        '
        'txt_codper
        '
        Appearance6.ImageHAlign = Infragistics.Win.HAlign.Center
        EditorButton1.Appearance = Appearance6
        Me.txt_codper.ButtonsRight.Add(EditorButton1)
        Me.txt_codper.Location = New System.Drawing.Point(426, 6)
        Me.txt_codper.Name = "txt_codper"
        Me.txt_codper.Size = New System.Drawing.Size(78, 21)
        Me.txt_codper.TabIndex = 1
        '
        'UltraLabel7
        '
        Appearance4.BackColor = System.Drawing.Color.Transparent
        Appearance4.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel7.Appearance = Appearance4
        Me.UltraLabel7.AutoSize = True
        Me.UltraLabel7.Location = New System.Drawing.Point(11, 10)
        Me.UltraLabel7.Name = "UltraLabel7"
        Me.UltraLabel7.Size = New System.Drawing.Size(27, 14)
        Me.UltraLabel7.TabIndex = 12
        Me.UltraLabel7.Text = "Año:"
        '
        'UltraLabel1
        '
        Appearance23.BackColor = System.Drawing.Color.Transparent
        Appearance23.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel1.Appearance = Appearance23
        Me.UltraLabel1.AutoSize = True
        Me.UltraLabel1.Location = New System.Drawing.Point(293, 10)
        Me.UltraLabel1.Name = "UltraLabel1"
        Me.UltraLabel1.Size = New System.Drawing.Size(31, 14)
        Me.UltraLabel1.TabIndex = 12
        Me.UltraLabel1.Text = "Trab:"
        '
        'UltraLabel8
        '
        Appearance12.BackColor = System.Drawing.Color.Transparent
        Appearance12.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel8.Appearance = Appearance12
        Me.UltraLabel8.AutoSize = True
        Me.UltraLabel8.Location = New System.Drawing.Point(92, 11)
        Me.UltraLabel8.Name = "UltraLabel8"
        Me.UltraLabel8.Size = New System.Drawing.Size(32, 14)
        Me.UltraLabel8.TabIndex = 12
        Me.UltraLabel8.Text = "Mes :"
        '
        'uce_TipoPersonal
        '
        Me.uce_TipoPersonal.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.uce_TipoPersonal.Location = New System.Drawing.Point(327, 6)
        Me.uce_TipoPersonal.Name = "uce_TipoPersonal"
        Me.uce_TipoPersonal.Size = New System.Drawing.Size(99, 21)
        Me.uce_TipoPersonal.TabIndex = 14
        '
        'uds_grati
        '
        Me.uds_grati.AllowDelete = False
        UltraDataColumn4.DataType = GetType(Double)
        UltraDataColumn5.DataType = GetType(Double)
        UltraDataColumn6.DataType = GetType(Double)
        UltraDataColumn7.DataType = GetType(Double)
        UltraDataColumn8.DataType = GetType(Double)
        UltraDataColumn9.DataType = GetType(Double)
        UltraDataColumn10.DataType = GetType(Double)
        UltraDataColumn11.DataType = GetType(Double)
        UltraDataColumn12.DataType = GetType(Double)
        UltraDataColumn13.DataType = GetType(Double)
        UltraDataColumn14.DataType = GetType(Double)
        UltraDataColumn15.DataType = GetType(Double)
        UltraDataColumn16.DataType = GetType(Double)
        UltraDataColumn17.DataType = GetType(Double)
        UltraDataColumn18.DataType = GetType(Double)
        UltraDataColumn19.DataType = GetType(Double)
        UltraDataColumn20.DataType = GetType(Double)
        UltraDataColumn21.DataType = GetType(Double)
        Me.uds_grati.Band.Columns.AddRange(New Object() {UltraDataColumn1, UltraDataColumn2, UltraDataColumn3, UltraDataColumn4, UltraDataColumn5, UltraDataColumn6, UltraDataColumn7, UltraDataColumn8, UltraDataColumn9, UltraDataColumn10, UltraDataColumn11, UltraDataColumn12, UltraDataColumn13, UltraDataColumn14, UltraDataColumn15, UltraDataColumn16, UltraDataColumn17, UltraDataColumn18, UltraDataColumn19, UltraDataColumn20, UltraDataColumn21})
        '
        'ug_grati
        '
        Me.ug_grati.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ug_grati.DataSource = Me.uds_grati
        Me.ug_grati.DisplayLayout.AutoFitStyle = Infragistics.Win.UltraWinGrid.AutoFitStyle.ExtendLastColumn
        UltraGridBand1.ColHeaderLines = 2
        UltraGridColumn1.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn1.Header.Caption = "TIPO"
        UltraGridColumn1.Header.VisiblePosition = 0
        UltraGridColumn1.Width = 23
        UltraGridColumn2.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn2.Header.Caption = "COD"
        UltraGridColumn2.Header.VisiblePosition = 1
        UltraGridColumn2.Width = 44
        UltraGridColumn3.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn3.Header.Caption = "NOMBRES"
        UltraGridColumn3.Header.VisiblePosition = 2
        UltraGridColumn3.Width = 235
        UltraGridColumn4.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        Appearance2.TextHAlignAsString = "Right"
        UltraGridColumn4.CellAppearance = Appearance2
        UltraGridColumn4.Header.VisiblePosition = 3
        UltraGridColumn4.MaskDisplayMode = Infragistics.Win.UltraWinMaskedEdit.MaskMode.IncludeLiterals
        UltraGridColumn4.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Double]
        UltraGridColumn4.Width = 67
        UltraGridColumn5.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        Appearance3.TextHAlignAsString = "Right"
        UltraGridColumn5.CellAppearance = Appearance3
        UltraGridColumn5.Header.VisiblePosition = 4
        UltraGridColumn5.MaskDisplayMode = Infragistics.Win.UltraWinMaskedEdit.MaskMode.IncludeLiterals
        UltraGridColumn5.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Double]
        UltraGridColumn5.Width = 93
        UltraGridColumn6.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        Appearance5.TextHAlignAsString = "Right"
        UltraGridColumn6.CellAppearance = Appearance5
        UltraGridColumn6.Header.Caption = "R_CAJA"
        UltraGridColumn6.Header.VisiblePosition = 5
        UltraGridColumn6.MaskDisplayMode = Infragistics.Win.UltraWinMaskedEdit.MaskMode.IncludeLiterals
        UltraGridColumn6.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Double]
        UltraGridColumn6.Width = 90
        UltraGridColumn7.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        Appearance7.TextHAlignAsString = "Right"
        UltraGridColumn7.CellAppearance = Appearance7
        UltraGridColumn7.Header.Caption = "PROM_HE"
        UltraGridColumn7.Header.VisiblePosition = 11
        UltraGridColumn7.MaskDisplayMode = Infragistics.Win.UltraWinMaskedEdit.MaskMode.IncludeLiterals
        UltraGridColumn7.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Double]
        UltraGridColumn7.Width = 51
        UltraGridColumn8.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        Appearance8.TextHAlignAsString = "Right"
        UltraGridColumn8.CellAppearance = Appearance8
        UltraGridColumn8.Header.Caption = "PROM_BONI"
        UltraGridColumn8.Header.VisiblePosition = 12
        UltraGridColumn8.MaskDisplayMode = Infragistics.Win.UltraWinMaskedEdit.MaskMode.IncludeLiterals
        UltraGridColumn8.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Double]
        UltraGridColumn8.Width = 87
        UltraGridColumn9.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        Appearance9.TextHAlignAsString = "Right"
        UltraGridColumn9.CellAppearance = Appearance9
        UltraGridColumn9.Header.VisiblePosition = 18
        UltraGridColumn9.MaskDisplayMode = Infragistics.Win.UltraWinMaskedEdit.MaskMode.IncludeLiterals
        UltraGridColumn9.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Double]
        UltraGridColumn9.Width = 53
        UltraGridColumn10.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        Appearance10.TextHAlignAsString = "Right"
        UltraGridColumn10.CellAppearance = Appearance10
        UltraGridColumn10.Header.VisiblePosition = 19
        UltraGridColumn10.MaskDisplayMode = Infragistics.Win.UltraWinMaskedEdit.MaskMode.IncludeLiterals
        UltraGridColumn10.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Double]
        UltraGridColumn10.Width = 41
        UltraGridColumn11.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        Appearance11.TextHAlignAsString = "Right"
        UltraGridColumn11.CellAppearance = Appearance11
        UltraGridColumn11.Header.VisiblePosition = 16
        UltraGridColumn11.MaskDisplayMode = Infragistics.Win.UltraWinMaskedEdit.MaskMode.IncludeLiterals
        UltraGridColumn11.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Double]
        UltraGridColumn11.Width = 71
        UltraGridColumn12.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn12.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        Appearance13.TextHAlignAsString = "Right"
        UltraGridColumn12.CellAppearance = Appearance13
        UltraGridColumn12.Header.VisiblePosition = 15
        UltraGridColumn12.MaskDisplayMode = Infragistics.Win.UltraWinMaskedEdit.MaskMode.IncludeLiterals
        UltraGridColumn12.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Double]
        UltraGridColumn12.Width = 71
        UltraGridColumn13.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        Appearance14.TextHAlignAsString = "Right"
        UltraGridColumn13.CellAppearance = Appearance14
        UltraGridColumn13.Header.VisiblePosition = 10
        UltraGridColumn13.MaskDisplayMode = Infragistics.Win.UltraWinMaskedEdit.MaskMode.IncludeLiterals
        UltraGridColumn13.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Double]
        UltraGridColumn13.Width = 60
        UltraGridColumn14.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        Appearance15.TextHAlignAsString = "Right"
        UltraGridColumn14.CellAppearance = Appearance15
        UltraGridColumn14.Header.VisiblePosition = 20
        UltraGridColumn14.MaskDisplayMode = Infragistics.Win.UltraWinMaskedEdit.MaskMode.IncludeLiterals
        UltraGridColumn14.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Double]
        UltraGridColumn15.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        Appearance16.TextHAlignAsString = "Right"
        UltraGridColumn15.CellAppearance = Appearance16
        UltraGridColumn15.Header.VisiblePosition = 6
        UltraGridColumn15.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Double]
        UltraGridColumn16.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        Appearance17.TextHAlignAsString = "Right"
        UltraGridColumn16.CellAppearance = Appearance17
        UltraGridColumn16.Header.VisiblePosition = 7
        UltraGridColumn16.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Double]
        UltraGridColumn17.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        Appearance18.TextHAlignAsString = "Right"
        UltraGridColumn17.CellAppearance = Appearance18
        UltraGridColumn17.Header.VisiblePosition = 8
        UltraGridColumn17.MaskDisplayMode = Infragistics.Win.UltraWinMaskedEdit.MaskMode.IncludeLiterals
        UltraGridColumn17.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Double]
        UltraGridColumn18.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        Appearance19.TextHAlignAsString = "Right"
        UltraGridColumn18.CellAppearance = Appearance19
        UltraGridColumn18.Header.VisiblePosition = 13
        UltraGridColumn18.MaskDisplayMode = Infragistics.Win.UltraWinMaskedEdit.MaskMode.IncludeLiterals
        UltraGridColumn18.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Double]
        UltraGridColumn18.Width = 85
        UltraGridColumn19.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        Appearance20.TextHAlignAsString = "Right"
        UltraGridColumn19.CellAppearance = Appearance20
        UltraGridColumn19.Header.VisiblePosition = 14
        UltraGridColumn19.MaskDisplayMode = Infragistics.Win.UltraWinMaskedEdit.MaskMode.IncludeLiterals
        UltraGridColumn19.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Double]
        UltraGridColumn20.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        Appearance21.TextHAlignAsString = "Right"
        UltraGridColumn20.CellAppearance = Appearance21
        UltraGridColumn20.Header.VisiblePosition = 17
        UltraGridColumn20.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Double]
        UltraGridColumn21.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        Appearance22.TextHAlignAsString = "Right"
        UltraGridColumn21.CellAppearance = Appearance22
        UltraGridColumn21.Header.VisiblePosition = 9
        UltraGridColumn21.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Double]
        UltraGridBand1.Columns.AddRange(New Object() {UltraGridColumn1, UltraGridColumn2, UltraGridColumn3, UltraGridColumn4, UltraGridColumn5, UltraGridColumn6, UltraGridColumn7, UltraGridColumn8, UltraGridColumn9, UltraGridColumn10, UltraGridColumn11, UltraGridColumn12, UltraGridColumn13, UltraGridColumn14, UltraGridColumn15, UltraGridColumn16, UltraGridColumn17, UltraGridColumn18, UltraGridColumn19, UltraGridColumn20, UltraGridColumn21})
        UltraGridBand1.Header.TextOrientation = New Infragistics.Win.TextOrientationInfo(44, Infragistics.Win.TextFlowDirection.Horizontal)
        Appearance24.TextHAlignAsString = "Right"
        SummarySettings1.Appearance = Appearance24
        SummarySettings1.DisplayFormat = "{0:##,##0.00#}"
        SummarySettings1.GroupBySummaryValueAppearance = Appearance25
        SummarySettings1.ShowCalculatingText = Infragistics.Win.DefaultableBoolean.[True]
        SummarySettings1.SummaryDisplayArea = Infragistics.Win.UltraWinGrid.SummaryDisplayAreas.BottomFixed
        SummarySettings1.ToolTipText = "Total"
        UltraGridBand1.Summaries.AddRange(New Infragistics.Win.UltraWinGrid.SummarySettings() {SummarySettings1})
        UltraGridBand1.SummaryFooterCaption = "Totales"
        Me.ug_grati.DisplayLayout.BandsSerializer.Add(UltraGridBand1)
        Me.ug_grati.DisplayLayout.MaxColScrollRegions = 1
        Me.ug_grati.DisplayLayout.MaxRowScrollRegions = 1
        Me.ug_grati.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Appearance29.BackColor = System.Drawing.Color.WhiteSmoke
        Appearance29.BackColor2 = System.Drawing.Color.WhiteSmoke
        Me.ug_grati.DisplayLayout.Override.RowAlternateAppearance = Appearance29
        Me.ug_grati.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.ug_grati.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ug_grati.Location = New System.Drawing.Point(12, 96)
        Me.ug_grati.Name = "ug_grati"
        Me.ug_grati.Size = New System.Drawing.Size(980, 321)
        Me.ug_grati.TabIndex = 18
        Me.ug_grati.Text = "Calculo de Gratificacion"
        '
        'PL_PR_Calculo_Grati
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(1000, 422)
        Me.Controls.Add(Me.ug_grati)
        Me.Controls.Add(Me.ugb_Parametros)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Name = "PL_PR_Calculo_Grati"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Calculo de la Gratificacion"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        CType(Me.ugb_Parametros, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ugb_Parametros.ResumeLayout(False)
        Me.ugb_Parametros.PerformLayout()
        CType(Me.uos_Mes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_idpersonal, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.une_Ayo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_nombres, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_codper, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.uce_TipoPersonal, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.uds_grati, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ug_grati, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents Tool_Procesar As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents Tool_Exportar As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents Tool_Imprimir As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator6 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents Tool_Salir As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator5 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ugb_Parametros As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents txt_idpersonal As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents une_Ayo As Infragistics.Win.UltraWinEditors.UltraNumericEditor
    Friend WithEvents txt_nombres As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents uchk_Todos As Infragistics.Win.UltraWinEditors.UltraCheckEditor
    Friend WithEvents txt_codper As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents UltraLabel7 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel1 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel8 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents uce_TipoPersonal As Infragistics.Win.UltraWinEditors.UltraComboEditor
    Friend WithEvents uge_grati As Infragistics.Win.UltraWinGrid.ExcelExport.UltraGridExcelExporter
    Friend WithEvents upb_1 As Infragistics.Win.UltraWinProgressBar.UltraProgressBar
    Friend WithEvents uds_grati As Infragistics.Win.UltraWinDataSource.UltraDataSource
    Friend WithEvents uchk_sem_com As Infragistics.Win.UltraWinEditors.UltraCheckEditor
    Friend WithEvents ug_grati As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents uos_Mes As Infragistics.Win.UltraWinEditors.UltraOptionSet
End Class
