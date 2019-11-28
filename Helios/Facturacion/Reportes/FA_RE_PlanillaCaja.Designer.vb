<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FA_RE_PlanillaCaja
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
        Dim Appearance5 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance2 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridBand1 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1)
        Dim UltraGridColumn1 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CA_ID")
        Dim UltraGridColumn2 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CA_IDUSUARIO")
        Dim UltraGridColumn3 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("USUARIO")
        Dim UltraGridColumn4 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CA_FECHA")
        Dim Appearance1 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn5 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CA_IDTURNO")
        Dim Appearance3 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn6 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TU_DESCRIPCION")
        Dim Appearance4 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn7 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CA_APE_SOL")
        Dim Appearance6 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn8 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CA_APE_DOL")
        Dim Appearance7 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn9 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CA_CIE_SOL")
        Dim Appearance8 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn10 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CA_CIE_DOL")
        Dim Appearance9 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn11 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ESTADO")
        Dim Appearance10 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance20 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraDataColumn1 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("CA_ID")
        Dim UltraDataColumn2 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("CA_IDUSUARIO")
        Dim UltraDataColumn3 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("USUARIO")
        Dim UltraDataColumn4 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("CA_FECHA")
        Dim UltraDataColumn5 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("CA_IDTURNO")
        Dim UltraDataColumn6 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("TU_DESCRIPCION")
        Dim UltraDataColumn7 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("CA_APE_SOL")
        Dim UltraDataColumn8 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("CA_APE_DOL")
        Dim UltraDataColumn9 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("CA_CIE_SOL")
        Dim UltraDataColumn10 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("CA_CIE_DOL")
        Dim UltraDataColumn11 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("ESTADO")
        Dim UltraDataColumn12 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("DO_ABREVIATURA")
        Dim UltraDataColumn13 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("CO_SDOC")
        Dim UltraDataColumn14 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("CO_NDOC")
        Dim UltraDataColumn15 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("CO_FEC_EMI")
        Dim UltraDataColumn16 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("CO_NOTAS")
        Dim UltraDataColumn17 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("CO_TOTAL")
        Dim UltraGridBand2 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1)
        Dim UltraGridColumn12 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("DO_ABREVIATURA")
        Dim Appearance12 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn13 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CO_SDOC")
        Dim Appearance13 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn14 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CO_NDOC")
        Dim Appearance14 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn15 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CO_FEC_EMI")
        Dim Appearance15 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn16 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CO_NOTAS")
        Dim UltraGridColumn17 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CO_TOTAL")
        Dim Appearance16 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance11 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.Tool_imprimir = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.Tool_salir = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.UltraGroupBox2 = New Infragistics.Win.Misc.UltraGroupBox()
        Me.txt_Año = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.UltraLabel10 = New Infragistics.Win.Misc.UltraLabel()
        Me.uce_Mes = New Infragistics.Win.UltraWinEditors.UltraComboEditor()
        Me.lbl_desde = New Infragistics.Win.Misc.UltraLabel()
        Me.ug_Lista = New Infragistics.Win.UltraWinGrid.UltraGrid()
        Me.uds_Lista = New Infragistics.Win.UltraWinDataSource.UltraDataSource(Me.components)
        Me.uds_Compro = New Infragistics.Win.UltraWinDataSource.UltraDataSource(Me.components)
        Me.ug_comprobantes = New Infragistics.Win.UltraWinGrid.UltraGrid()
        Me.ToolStrip1.SuspendLayout()
        CType(Me.UltraGroupBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraGroupBox2.SuspendLayout()
        CType(Me.txt_Año, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.uce_Mes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ug_Lista, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.uds_Lista, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.uds_Compro, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ug_comprobantes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ToolStrip1
        '
        Me.ToolStrip1.BackColor = System.Drawing.Color.Gainsboro
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Tool_imprimir, Me.ToolStripSeparator2, Me.Tool_salir, Me.ToolStripSeparator1})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(828, 25)
        Me.ToolStrip1.TabIndex = 10
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'Tool_imprimir
        '
        Me.Tool_imprimir.Image = Global.Contabilidad.My.Resources.Resources._004
        Me.Tool_imprimir.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Tool_imprimir.Name = "Tool_imprimir"
        Me.Tool_imprimir.Size = New System.Drawing.Size(73, 22)
        Me.Tool_imprimir.Text = "Imprimir"
        Me.Tool_imprimir.ToolTipText = "Imprimir"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'Tool_salir
        '
        Me.Tool_salir.Image = Global.Contabilidad.My.Resources.Resources._28
        Me.Tool_salir.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Tool_salir.Name = "Tool_salir"
        Me.Tool_salir.Size = New System.Drawing.Size(49, 22)
        Me.Tool_salir.Text = "Salir"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'UltraGroupBox2
        '
        Me.UltraGroupBox2.Controls.Add(Me.txt_Año)
        Me.UltraGroupBox2.Controls.Add(Me.UltraLabel10)
        Me.UltraGroupBox2.Controls.Add(Me.uce_Mes)
        Me.UltraGroupBox2.Controls.Add(Me.lbl_desde)
        Me.UltraGroupBox2.Location = New System.Drawing.Point(12, 28)
        Me.UltraGroupBox2.Name = "UltraGroupBox2"
        Me.UltraGroupBox2.Size = New System.Drawing.Size(806, 36)
        Me.UltraGroupBox2.TabIndex = 15
        '
        'txt_Año
        '
        Me.txt_Año.Location = New System.Drawing.Point(48, 7)
        Me.txt_Año.MaxLength = 4
        Me.txt_Año.Name = "txt_Año"
        Me.txt_Año.Size = New System.Drawing.Size(48, 21)
        Me.txt_Año.TabIndex = 197
        '
        'UltraLabel10
        '
        Appearance5.BackColor = System.Drawing.Color.Transparent
        Appearance5.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel10.Appearance = Appearance5
        Me.UltraLabel10.AutoSize = True
        Me.UltraLabel10.Location = New System.Drawing.Point(16, 11)
        Me.UltraLabel10.Name = "UltraLabel10"
        Me.UltraLabel10.Size = New System.Drawing.Size(24, 14)
        Me.UltraLabel10.TabIndex = 198
        Me.UltraLabel10.Text = "Año"
        '
        'uce_Mes
        '
        Me.uce_Mes.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.uce_Mes.Location = New System.Drawing.Point(136, 7)
        Me.uce_Mes.Name = "uce_Mes"
        Me.uce_Mes.Size = New System.Drawing.Size(122, 21)
        Me.uce_Mes.TabIndex = 195
        '
        'lbl_desde
        '
        Appearance2.BackColor = System.Drawing.Color.Transparent
        Appearance2.ForeColor = System.Drawing.Color.Navy
        Me.lbl_desde.Appearance = Appearance2
        Me.lbl_desde.AutoSize = True
        Me.lbl_desde.Location = New System.Drawing.Point(104, 11)
        Me.lbl_desde.Name = "lbl_desde"
        Me.lbl_desde.Size = New System.Drawing.Size(26, 14)
        Me.lbl_desde.TabIndex = 194
        Me.lbl_desde.Text = "Mes"
        '
        'ug_Lista
        '
        Me.ug_Lista.DataSource = Me.uds_Lista
        Me.ug_Lista.DisplayLayout.AutoFitStyle = Infragistics.Win.UltraWinGrid.AutoFitStyle.ExtendLastColumn
        UltraGridColumn1.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn1.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn1.Header.Caption = "id"
        UltraGridColumn1.Header.VisiblePosition = 0
        UltraGridColumn1.Hidden = True
        UltraGridColumn1.Width = 70
        UltraGridColumn2.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn2.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn2.Header.Caption = "Serie"
        UltraGridColumn2.Header.VisiblePosition = 1
        UltraGridColumn2.Hidden = True
        UltraGridColumn2.Width = 50
        UltraGridColumn3.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn3.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn3.Header.Caption = "Usuario"
        UltraGridColumn3.Header.VisiblePosition = 2
        UltraGridColumn3.Width = 85
        UltraGridColumn4.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn4.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        Appearance1.TextHAlignAsString = "Center"
        UltraGridColumn4.CellAppearance = Appearance1
        UltraGridColumn4.Header.Caption = "Fecha"
        UltraGridColumn4.Header.VisiblePosition = 3
        UltraGridColumn4.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Date]
        UltraGridColumn4.Width = 95
        UltraGridColumn5.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn5.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        Appearance3.TextHAlignAsString = "Right"
        UltraGridColumn5.CellAppearance = Appearance3
        UltraGridColumn5.Header.VisiblePosition = 4
        UltraGridColumn5.Hidden = True
        UltraGridColumn5.Width = 100
        UltraGridColumn6.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn6.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        Appearance4.TextHAlignAsString = "Left"
        UltraGridColumn6.CellAppearance = Appearance4
        UltraGridColumn6.Header.Caption = "Turno"
        UltraGridColumn6.Header.VisiblePosition = 5
        UltraGridColumn6.Width = 93
        UltraGridColumn7.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn7.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        Appearance6.TextHAlignAsString = "Right"
        UltraGridColumn7.CellAppearance = Appearance6
        UltraGridColumn7.Header.Caption = "Apertura S/."
        UltraGridColumn7.Header.VisiblePosition = 6
        UltraGridColumn7.MaskDisplayMode = Infragistics.Win.UltraWinMaskedEdit.MaskMode.IncludeLiterals
        UltraGridColumn7.MaskInput = "{double:9.2}"
        UltraGridColumn7.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Double]
        UltraGridColumn7.Width = 87
        UltraGridColumn8.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn8.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        Appearance7.TextHAlignAsString = "Right"
        UltraGridColumn8.CellAppearance = Appearance7
        UltraGridColumn8.Header.Caption = "Apertura $"
        UltraGridColumn8.Header.VisiblePosition = 7
        UltraGridColumn8.MaskDisplayMode = Infragistics.Win.UltraWinMaskedEdit.MaskMode.IncludeLiterals
        UltraGridColumn8.MaskInput = "{double:9.2}"
        UltraGridColumn8.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Double]
        UltraGridColumn8.Width = 84
        UltraGridColumn9.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn9.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        Appearance8.TextHAlignAsString = "Right"
        UltraGridColumn9.CellAppearance = Appearance8
        UltraGridColumn9.Header.Caption = "Cierre S/."
        UltraGridColumn9.Header.VisiblePosition = 8
        UltraGridColumn9.MaskDisplayMode = Infragistics.Win.UltraWinMaskedEdit.MaskMode.IncludeLiterals
        UltraGridColumn9.MaskInput = "{double:9.2}"
        UltraGridColumn9.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Double]
        UltraGridColumn9.Width = 79
        UltraGridColumn10.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn10.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        Appearance9.TextHAlignAsString = "Right"
        UltraGridColumn10.CellAppearance = Appearance9
        UltraGridColumn10.Header.Caption = "Cierre $"
        UltraGridColumn10.Header.VisiblePosition = 9
        UltraGridColumn10.MaskDisplayMode = Infragistics.Win.UltraWinMaskedEdit.MaskMode.IncludeLiterals
        UltraGridColumn10.MaskInput = "{double:9.2}"
        UltraGridColumn10.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Double]
        UltraGridColumn10.Width = 78
        UltraGridColumn11.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn11.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        Appearance10.TextHAlignAsString = "Center"
        UltraGridColumn11.CellAppearance = Appearance10
        UltraGridColumn11.Header.Caption = "Estado"
        UltraGridColumn11.Header.VisiblePosition = 10
        UltraGridColumn11.Width = 70
        UltraGridBand1.Columns.AddRange(New Object() {UltraGridColumn1, UltraGridColumn2, UltraGridColumn3, UltraGridColumn4, UltraGridColumn5, UltraGridColumn6, UltraGridColumn7, UltraGridColumn8, UltraGridColumn9, UltraGridColumn10, UltraGridColumn11})
        Me.ug_Lista.DisplayLayout.BandsSerializer.Add(UltraGridBand1)
        Me.ug_Lista.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.[True]
        Me.ug_Lista.DisplayLayout.MaxColScrollRegions = 1
        Me.ug_Lista.DisplayLayout.MaxRowScrollRegions = 1
        Appearance20.BackColor = System.Drawing.Color.WhiteSmoke
        Appearance20.BackColor2 = System.Drawing.Color.WhiteSmoke
        Me.ug_Lista.DisplayLayout.Override.RowAlternateAppearance = Appearance20
        Me.ug_Lista.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.ug_Lista.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.ug_Lista.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ug_Lista.Location = New System.Drawing.Point(12, 70)
        Me.ug_Lista.Name = "ug_Lista"
        Me.ug_Lista.Size = New System.Drawing.Size(806, 156)
        Me.ug_Lista.TabIndex = 162
        Me.ug_Lista.Text = "Listado de Cajas"
        '
        'uds_Lista
        '
        Me.uds_Lista.AllowDelete = False
        UltraDataColumn1.DataType = GetType(Integer)
        UltraDataColumn2.DataType = GetType(Integer)
        UltraDataColumn4.DataType = GetType(Date)
        UltraDataColumn7.DataType = GetType(Double)
        UltraDataColumn8.DataType = GetType(Double)
        UltraDataColumn9.DataType = GetType(Double)
        UltraDataColumn10.DataType = GetType(Double)
        Me.uds_Lista.Band.Columns.AddRange(New Object() {UltraDataColumn1, UltraDataColumn2, UltraDataColumn3, UltraDataColumn4, UltraDataColumn5, UltraDataColumn6, UltraDataColumn7, UltraDataColumn8, UltraDataColumn9, UltraDataColumn10, UltraDataColumn11})
        '
        'uds_Compro
        '
        Me.uds_Compro.AllowDelete = False
        UltraDataColumn15.DataType = GetType(Date)
        UltraDataColumn17.DataType = GetType(Double)
        Me.uds_Compro.Band.Columns.AddRange(New Object() {UltraDataColumn12, UltraDataColumn13, UltraDataColumn14, UltraDataColumn15, UltraDataColumn16, UltraDataColumn17})
        '
        'ug_comprobantes
        '
        Me.ug_comprobantes.DataSource = Me.uds_Compro
        Me.ug_comprobantes.DisplayLayout.AutoFitStyle = Infragistics.Win.UltraWinGrid.AutoFitStyle.ExtendLastColumn
        UltraGridColumn12.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn12.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        Appearance12.TextHAlignAsString = "Center"
        UltraGridColumn12.CellAppearance = Appearance12
        UltraGridColumn12.Header.Caption = "TD"
        UltraGridColumn12.Header.VisiblePosition = 0
        UltraGridColumn12.Width = 60
        UltraGridColumn13.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn13.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        Appearance13.TextHAlignAsString = "Center"
        UltraGridColumn13.CellAppearance = Appearance13
        UltraGridColumn13.Header.Caption = "Serie"
        UltraGridColumn13.Header.VisiblePosition = 1
        UltraGridColumn13.Width = 80
        UltraGridColumn14.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn14.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        Appearance14.TextHAlignAsString = "Center"
        UltraGridColumn14.CellAppearance = Appearance14
        UltraGridColumn14.Header.Caption = "Numero"
        UltraGridColumn14.Header.VisiblePosition = 2
        UltraGridColumn14.Width = 100
        UltraGridColumn15.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn15.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        Appearance15.TextHAlignAsString = "Center"
        UltraGridColumn15.CellAppearance = Appearance15
        UltraGridColumn15.Header.Caption = "Fecha"
        UltraGridColumn15.Header.VisiblePosition = 3
        UltraGridColumn15.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Date]
        UltraGridColumn15.Width = 100
        UltraGridColumn16.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn16.Header.Caption = "Cliente"
        UltraGridColumn16.Header.VisiblePosition = 4
        UltraGridColumn16.Width = 348
        UltraGridColumn17.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn17.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        Appearance16.TextHAlignAsString = "Right"
        UltraGridColumn17.CellAppearance = Appearance16
        UltraGridColumn17.Header.Caption = "Total"
        UltraGridColumn17.Header.VisiblePosition = 5
        UltraGridColumn17.MaskDisplayMode = Infragistics.Win.UltraWinMaskedEdit.MaskMode.IncludeLiterals
        UltraGridColumn17.MaskInput = "{double:9.2}"
        UltraGridColumn17.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Double]
        UltraGridColumn17.Width = 70
        UltraGridBand2.Columns.AddRange(New Object() {UltraGridColumn12, UltraGridColumn13, UltraGridColumn14, UltraGridColumn15, UltraGridColumn16, UltraGridColumn17})
        Me.ug_comprobantes.DisplayLayout.BandsSerializer.Add(UltraGridBand2)
        Me.ug_comprobantes.DisplayLayout.MaxColScrollRegions = 1
        Me.ug_comprobantes.DisplayLayout.MaxRowScrollRegions = 1
        Appearance11.BackColor = System.Drawing.Color.WhiteSmoke
        Appearance11.BackColor2 = System.Drawing.Color.WhiteSmoke
        Me.ug_comprobantes.DisplayLayout.Override.RowAlternateAppearance = Appearance11
        Me.ug_comprobantes.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.ug_comprobantes.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.ug_comprobantes.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ug_comprobantes.Location = New System.Drawing.Point(12, 232)
        Me.ug_comprobantes.Name = "ug_comprobantes"
        Me.ug_comprobantes.Size = New System.Drawing.Size(806, 229)
        Me.ug_comprobantes.TabIndex = 163
        Me.ug_comprobantes.Text = "Comprobantes"
        '
        'FA_RE_PlanillaCaja
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(828, 467)
        Me.Controls.Add(Me.ug_comprobantes)
        Me.Controls.Add(Me.ug_Lista)
        Me.Controls.Add(Me.UltraGroupBox2)
        Me.Controls.Add(Me.ToolStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "FA_RE_PlanillaCaja"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Planilla de Caja"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        CType(Me.UltraGroupBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraGroupBox2.ResumeLayout(False)
        Me.UltraGroupBox2.PerformLayout()
        CType(Me.txt_Año, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.uce_Mes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ug_Lista, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.uds_Lista, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.uds_Compro, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ug_comprobantes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents Tool_imprimir As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents Tool_salir As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents UltraGroupBox2 As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents ug_Lista As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents uds_Lista As Infragistics.Win.UltraWinDataSource.UltraDataSource
    Friend WithEvents txt_Año As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents UltraLabel10 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents uce_Mes As Infragistics.Win.UltraWinEditors.UltraComboEditor
    Friend WithEvents lbl_desde As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents uds_Compro As Infragistics.Win.UltraWinDataSource.UltraDataSource
    Friend WithEvents ug_comprobantes As Infragistics.Win.UltraWinGrid.UltraGrid
End Class
