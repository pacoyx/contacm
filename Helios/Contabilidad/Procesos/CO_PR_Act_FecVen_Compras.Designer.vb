<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CO_PR_Act_FecVen_Compras
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
        Dim UltraDataColumn1 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("CO_IDCAB")
        Dim UltraDataColumn2 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("AN_DESCRIPCION")
        Dim UltraDataColumn3 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("DO_ABREVIATURA")
        Dim UltraDataColumn4 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("CO_SER_DOC")
        Dim UltraDataColumn5 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("CO_NUM_DOC")
        Dim UltraDataColumn6 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("CO_FEC_EMI")
        Dim UltraDataColumn7 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("CO_FEC_VEN")
        Dim UltraDataColumn8 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("BASE")
        Dim UltraDataColumn9 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IMPUESTO")
        Dim UltraDataColumn10 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("TOTAL")
        Dim UltraDataColumn11 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("AC_GLOSA_VOU")
        Dim UltraDataColumn12 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("AN_IDANEXO")
        Dim UltraDataColumn13 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("DO_CODIGO")
        Dim UltraDataColumn14 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("CO_FEC_VEN2")
        Dim Appearance1 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance23 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance13 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridBand1 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1)
        Dim UltraGridColumn1 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CO_IDCAB")
        Dim UltraGridColumn2 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("AN_DESCRIPCION", -1, Nothing, 26902187, 0, 0)
        Dim Appearance2 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn3 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("DO_ABREVIATURA", -1, Nothing, 26902186, 0, 0)
        Dim Appearance3 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn4 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CO_SER_DOC", -1, Nothing, 26902186, 1, 0)
        Dim Appearance4 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn5 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CO_NUM_DOC", -1, Nothing, 26902186, 2, 0)
        Dim Appearance5 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn6 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CO_FEC_EMI", -1, Nothing, 26902186, 3, 0)
        Dim Appearance6 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn7 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CO_FEC_VEN", -1, Nothing, 26902186, 4, 0)
        Dim Appearance8 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn8 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("BASE")
        Dim Appearance9 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn9 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IMPUESTO")
        Dim Appearance10 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn10 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TOTAL", -1, Nothing, 26902186, 5, 0)
        Dim Appearance11 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn11 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("AC_GLOSA_VOU", -1, Nothing, 26902186, 6, 0)
        Dim UltraGridColumn12 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("AN_IDANEXO")
        Dim UltraGridColumn13 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("DO_CODIGO")
        Dim UltraGridColumn14 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CO_FEC_VEN2")
        Dim UltraGridGroup1 As Infragistics.Win.UltraWinGrid.UltraGridGroup = New Infragistics.Win.UltraWinGrid.UltraGridGroup("COMPROBANTE", 26902186)
        Dim UltraGridGroup2 As Infragistics.Win.UltraWinGrid.UltraGridGroup = New Infragistics.Win.UltraWinGrid.UltraGridGroup("PROVEEDOR", 26902187)
        Dim Appearance12 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance29 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance30 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance31 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance32 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance7 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Me.uds_Lista = New Infragistics.Win.UltraWinDataSource.UltraDataSource(Me.components)
        Me.ugb_Parametros = New Infragistics.Win.Misc.UltraGroupBox()
        Me.une_Ayo = New Infragistics.Win.UltraWinEditors.UltraNumericEditor()
        Me.UltraLabel1 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraLabel4 = New Infragistics.Win.Misc.UltraLabel()
        Me.uce_Mes = New Infragistics.Win.UltraWinEditors.UltraComboEditor()
        Me.ToolS_Subdiarios = New System.Windows.Forms.ToolStrip()
        Me.Tool_Grabar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.Tool_Salir = New System.Windows.Forms.ToolStripButton()
        Me.ug_Lista = New Infragistics.Win.UltraWinGrid.UltraGrid()
        Me.lbl_num_filas = New Infragistics.Win.Misc.UltraLabel()
        CType(Me.uds_Lista, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ugb_Parametros, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ugb_Parametros.SuspendLayout()
        CType(Me.une_Ayo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.uce_Mes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolS_Subdiarios.SuspendLayout()
        CType(Me.ug_Lista, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'uds_Lista
        '
        Me.uds_Lista.AllowDelete = False
        UltraDataColumn1.DataType = GetType(Long)
        UltraDataColumn6.DataType = GetType(Date)
        UltraDataColumn7.DataType = GetType(Date)
        UltraDataColumn8.DataType = GetType(Double)
        UltraDataColumn9.DataType = GetType(Double)
        UltraDataColumn10.DataType = GetType(Double)
        UltraDataColumn12.DataType = GetType(Long)
        UltraDataColumn14.DataType = GetType(Date)
        Me.uds_Lista.Band.Columns.AddRange(New Object() {UltraDataColumn1, UltraDataColumn2, UltraDataColumn3, UltraDataColumn4, UltraDataColumn5, UltraDataColumn6, UltraDataColumn7, UltraDataColumn8, UltraDataColumn9, UltraDataColumn10, UltraDataColumn11, UltraDataColumn12, UltraDataColumn13, UltraDataColumn14})
        '
        'ugb_Parametros
        '
        Me.ugb_Parametros.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ugb_Parametros.Controls.Add(Me.une_Ayo)
        Me.ugb_Parametros.Controls.Add(Me.UltraLabel1)
        Me.ugb_Parametros.Controls.Add(Me.UltraLabel4)
        Me.ugb_Parametros.Controls.Add(Me.uce_Mes)
        Me.ugb_Parametros.Location = New System.Drawing.Point(12, 33)
        Me.ugb_Parametros.Name = "ugb_Parametros"
        Me.ugb_Parametros.Size = New System.Drawing.Size(814, 38)
        Me.ugb_Parametros.TabIndex = 7
        '
        'une_Ayo
        '
        Appearance1.TextHAlignAsString = "Center"
        Me.une_Ayo.Appearance = Appearance1
        Me.une_Ayo.Location = New System.Drawing.Point(48, 9)
        Me.une_Ayo.MaskInput = "nnnn"
        Me.une_Ayo.Name = "une_Ayo"
        Me.une_Ayo.Size = New System.Drawing.Size(46, 21)
        Me.une_Ayo.TabIndex = 13
        '
        'UltraLabel1
        '
        Appearance23.BackColor = System.Drawing.Color.Transparent
        Appearance23.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel1.Appearance = Appearance23
        Me.UltraLabel1.AutoSize = True
        Me.UltraLabel1.Location = New System.Drawing.Point(15, 13)
        Me.UltraLabel1.Name = "UltraLabel1"
        Me.UltraLabel1.Size = New System.Drawing.Size(30, 14)
        Me.UltraLabel1.TabIndex = 12
        Me.UltraLabel1.Text = "Año :"
        '
        'UltraLabel4
        '
        Appearance13.BackColor = System.Drawing.Color.Transparent
        Appearance13.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel4.Appearance = Appearance13
        Me.UltraLabel4.AutoSize = True
        Me.UltraLabel4.Location = New System.Drawing.Point(129, 13)
        Me.UltraLabel4.Name = "UltraLabel4"
        Me.UltraLabel4.Size = New System.Drawing.Size(32, 14)
        Me.UltraLabel4.TabIndex = 12
        Me.UltraLabel4.Text = "Mes :"
        '
        'uce_Mes
        '
        Me.uce_Mes.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.uce_Mes.Location = New System.Drawing.Point(167, 9)
        Me.uce_Mes.Name = "uce_Mes"
        Me.uce_Mes.Size = New System.Drawing.Size(112, 21)
        Me.uce_Mes.TabIndex = 0
        '
        'ToolS_Subdiarios
        '
        Me.ToolS_Subdiarios.BackColor = System.Drawing.Color.White
        Me.ToolS_Subdiarios.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Tool_Grabar, Me.ToolStripSeparator3, Me.Tool_Salir})
        Me.ToolS_Subdiarios.Location = New System.Drawing.Point(0, 0)
        Me.ToolS_Subdiarios.Name = "ToolS_Subdiarios"
        Me.ToolS_Subdiarios.Size = New System.Drawing.Size(836, 25)
        Me.ToolS_Subdiarios.TabIndex = 8
        Me.ToolS_Subdiarios.Text = "ToolStrip1"
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
        'Tool_Salir
        '
        Me.Tool_Salir.Image = Global.Contabilidad.My.Resources.Resources._28
        Me.Tool_Salir.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Tool_Salir.Name = "Tool_Salir"
        Me.Tool_Salir.Size = New System.Drawing.Size(49, 22)
        Me.Tool_Salir.Text = "Salir"
        '
        'ug_Lista
        '
        Me.ug_Lista.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ug_Lista.DataSource = Me.uds_Lista
        Me.ug_Lista.DisplayLayout.AutoFitStyle = Infragistics.Win.UltraWinGrid.AutoFitStyle.ExtendLastColumn
        UltraGridBand1.ColHeaderLines = 2
        UltraGridColumn1.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn1.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn1.Header.VisiblePosition = 0
        UltraGridColumn1.Hidden = True
        UltraGridColumn2.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn2.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        Appearance2.TextVAlignAsString = "Middle"
        UltraGridColumn2.CellAppearance = Appearance2
        UltraGridColumn2.Header.Caption = "Proveedor"
        UltraGridColumn2.MergedCellContentArea = Infragistics.Win.UltraWinGrid.MergedCellContentArea.VisibleRect
        UltraGridColumn2.Width = 201
        UltraGridColumn3.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn3.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        Appearance3.TextVAlignAsString = "Middle"
        UltraGridColumn3.CellAppearance = Appearance3
        UltraGridColumn3.Header.Caption = "T.D."
        UltraGridColumn3.Width = 43
        UltraGridColumn4.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn4.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        Appearance4.TextVAlignAsString = "Middle"
        UltraGridColumn4.CellAppearance = Appearance4
        UltraGridColumn4.Header.Caption = "Serie"
        UltraGridColumn4.Width = 42
        UltraGridColumn5.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn5.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        Appearance5.TextVAlignAsString = "Middle"
        UltraGridColumn5.CellAppearance = Appearance5
        UltraGridColumn5.Header.Caption = "Numero"
        UltraGridColumn5.Width = 133
        UltraGridColumn6.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn6.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        Appearance6.TextHAlignAsString = "Center"
        Appearance6.TextVAlignAsString = "Middle"
        UltraGridColumn6.CellAppearance = Appearance6
        UltraGridColumn6.Header.Caption = "Fec. Emi."
        UltraGridColumn6.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Date]
        UltraGridColumn6.Width = 104
        UltraGridColumn7.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        Appearance8.ForeColor = System.Drawing.Color.Navy
        Appearance8.TextHAlignAsString = "Center"
        Appearance8.TextVAlignAsString = "Middle"
        UltraGridColumn7.CellAppearance = Appearance8
        UltraGridColumn7.Header.Caption = "Fec. Ven."
        UltraGridColumn7.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Date]
        UltraGridColumn7.Width = 112
        UltraGridColumn8.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn8.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        Appearance9.TextHAlignAsString = "Right"
        UltraGridColumn8.CellAppearance = Appearance9
        UltraGridColumn8.Header.Caption = "Base"
        UltraGridColumn8.Header.VisiblePosition = 9
        UltraGridColumn8.Hidden = True
        UltraGridColumn8.MaskDisplayMode = Infragistics.Win.UltraWinMaskedEdit.MaskMode.IncludeLiterals
        UltraGridColumn8.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Double]
        UltraGridColumn8.Width = 63
        UltraGridColumn9.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn9.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        Appearance10.TextHAlignAsString = "Right"
        UltraGridColumn9.CellAppearance = Appearance10
        UltraGridColumn9.Header.Caption = "Impuesto"
        UltraGridColumn9.Header.VisiblePosition = 10
        UltraGridColumn9.Hidden = True
        UltraGridColumn9.MaskDisplayMode = Infragistics.Win.UltraWinMaskedEdit.MaskMode.IncludeLiterals
        UltraGridColumn9.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Double]
        UltraGridColumn9.Width = 60
        UltraGridColumn10.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn10.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        Appearance11.TextHAlignAsString = "Right"
        UltraGridColumn10.CellAppearance = Appearance11
        UltraGridColumn10.Header.Caption = "Total"
        UltraGridColumn10.MaskDisplayMode = Infragistics.Win.UltraWinMaskedEdit.MaskMode.IncludeLiterals
        UltraGridColumn10.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Double]
        UltraGridColumn10.Width = 59
        UltraGridColumn11.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn11.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn11.Header.Caption = "Glosa"
        UltraGridColumn11.Width = 86
        UltraGridColumn12.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn12.Header.VisiblePosition = 11
        UltraGridColumn12.Hidden = True
        UltraGridColumn13.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn13.Header.VisiblePosition = 12
        UltraGridColumn13.Hidden = True
        UltraGridColumn14.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn14.Header.VisiblePosition = 13
        UltraGridColumn14.Hidden = True
        UltraGridBand1.Columns.AddRange(New Object() {UltraGridColumn1, UltraGridColumn2, UltraGridColumn3, UltraGridColumn4, UltraGridColumn5, UltraGridColumn6, UltraGridColumn7, UltraGridColumn8, UltraGridColumn9, UltraGridColumn10, UltraGridColumn11, UltraGridColumn12, UltraGridColumn13, UltraGridColumn14})
        UltraGridGroup1.Header.VisiblePosition = 1
        UltraGridGroup1.Key = "COMPROBANTE"
        UltraGridGroup2.Header.VisiblePosition = 0
        UltraGridGroup2.Key = "PROVEEDOR"
        UltraGridBand1.Groups.AddRange(New Infragistics.Win.UltraWinGrid.UltraGridGroup() {UltraGridGroup1, UltraGridGroup2})
        Appearance12.ForeColor = System.Drawing.Color.Navy
        UltraGridBand1.Header.Appearance = Appearance12
        Me.ug_Lista.DisplayLayout.BandsSerializer.Add(UltraGridBand1)
        Appearance29.FontData.BoldAsString = "True"
        Appearance29.FontData.SizeInPoints = 10.0!
        Appearance29.ForeColor = System.Drawing.Color.Red
        Me.ug_Lista.DisplayLayout.CaptionAppearance = Appearance29
        Me.ug_Lista.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.[True]
        Me.ug_Lista.DisplayLayout.MaxColScrollRegions = 1
        Me.ug_Lista.DisplayLayout.MaxRowScrollRegions = 1
        Me.ug_Lista.DisplayLayout.Override.FilterClearButtonLocation = Infragistics.Win.UltraWinGrid.FilterClearButtonLocation.Row
        Me.ug_Lista.DisplayLayout.Override.FilterOperatorDefaultValue = Infragistics.Win.UltraWinGrid.FilterOperatorDefaultValue.Contains
        Appearance30.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ug_Lista.DisplayLayout.Override.FilterRowAppearance = Appearance30
        Me.ug_Lista.DisplayLayout.Override.FilterUIType = Infragistics.Win.UltraWinGrid.FilterUIType.FilterRow
        Appearance31.BackColor = System.Drawing.Color.White
        Appearance31.ForeColor = System.Drawing.Color.Navy
        Me.ug_Lista.DisplayLayout.Override.HeaderAppearance = Appearance31
        Me.ug_Lista.DisplayLayout.Override.MergedCellContentArea = Infragistics.Win.UltraWinGrid.MergedCellContentArea.VisibleRect
        Appearance32.BackColor = System.Drawing.Color.WhiteSmoke
        Appearance32.BackColor2 = System.Drawing.Color.WhiteSmoke
        Me.ug_Lista.DisplayLayout.Override.RowAlternateAppearance = Appearance32
        Me.ug_Lista.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.ug_Lista.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.ug_Lista.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ug_Lista.Location = New System.Drawing.Point(12, 81)
        Me.ug_Lista.Name = "ug_Lista"
        Me.ug_Lista.Size = New System.Drawing.Size(814, 397)
        Me.ug_Lista.TabIndex = 9
        Me.ug_Lista.Text = "Documentos de Compras"
        '
        'lbl_num_filas
        '
        Me.lbl_num_filas.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Appearance7.BackColor = System.Drawing.Color.Transparent
        Appearance7.ForeColor = System.Drawing.Color.Navy
        Me.lbl_num_filas.Appearance = Appearance7
        Me.lbl_num_filas.AutoSize = True
        Me.lbl_num_filas.Location = New System.Drawing.Point(12, 484)
        Me.lbl_num_filas.Name = "lbl_num_filas"
        Me.lbl_num_filas.Size = New System.Drawing.Size(64, 14)
        Me.lbl_num_filas.TabIndex = 14
        Me.lbl_num_filas.Text = "Num. Filas :"
        '
        'CO_PR_Act_FecVen_Compras
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(836, 504)
        Me.Controls.Add(Me.lbl_num_filas)
        Me.Controls.Add(Me.ug_Lista)
        Me.Controls.Add(Me.ToolS_Subdiarios)
        Me.Controls.Add(Me.ugb_Parametros)
        Me.Name = "CO_PR_Act_FecVen_Compras"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Actualizar Fecha Vencto"
        CType(Me.uds_Lista, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ugb_Parametros, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ugb_Parametros.ResumeLayout(False)
        Me.ugb_Parametros.PerformLayout()
        CType(Me.une_Ayo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.uce_Mes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolS_Subdiarios.ResumeLayout(False)
        Me.ToolS_Subdiarios.PerformLayout()
        CType(Me.ug_Lista, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents uds_Lista As Infragistics.Win.UltraWinDataSource.UltraDataSource
    Friend WithEvents ugb_Parametros As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents une_Ayo As Infragistics.Win.UltraWinEditors.UltraNumericEditor
    Friend WithEvents UltraLabel1 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel4 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents uce_Mes As Infragistics.Win.UltraWinEditors.UltraComboEditor
    Friend WithEvents ToolS_Subdiarios As System.Windows.Forms.ToolStrip
    Friend WithEvents Tool_Grabar As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents Tool_Salir As System.Windows.Forms.ToolStripButton
    Friend WithEvents ug_Lista As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents lbl_num_filas As Infragistics.Win.Misc.UltraLabel
End Class
