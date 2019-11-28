<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PR_PR_ListaCuentas
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
        Dim ValueListItem1 As Infragistics.Win.ValueListItem = New Infragistics.Win.ValueListItem()
        Dim ValueListItem2 As Infragistics.Win.ValueListItem = New Infragistics.Win.ValueListItem()
        Dim ValueListItem3 As Infragistics.Win.ValueListItem = New Infragistics.Win.ValueListItem()
        Dim UltraGridBand1 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1)
        Dim UltraGridColumn1 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CC_ID")
        Dim UltraGridColumn2 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CC_IDTIPO_ORI")
        Dim UltraGridColumn3 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TIPO")
        Dim UltraGridColumn4 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CC_IDNUM_HIST")
        Dim UltraGridColumn5 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("PACIENTE")
        Dim UltraGridColumn6 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CC_IDCLIENTE")
        Dim UltraGridColumn7 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CC_IDTIPO_ATENC")
        Dim UltraGridColumn8 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CC_IDSEGURO")
        Dim UltraGridColumn9 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CC_FECHA")
        Dim UltraGridColumn10 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CC_IDPREFAC")
        Dim UltraGridColumn11 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CC_SIT_COD_EPS")
        Dim UltraGridColumn12 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CC_SIT_COD_ASEG")
        Dim UltraGridColumn13 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CC_SIT_FEC_AUTORI")
        Dim UltraGridColumn14 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CC_SIT_COD_COBER")
        Dim UltraGridColumn15 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CC_SIT_COPG_FIJO")
        Dim UltraGridColumn16 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CC_SIT_COPG_VARI")
        Dim UltraGridColumn17 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CC_SIT_COD_GENE")
        Dim UltraGridColumn18 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CC_TIPOAFILIACION")
        Dim UltraGridColumn19 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("MEDICO")
        Dim UltraGridColumn20 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ESTADO", -1, Nothing, 0, Infragistics.Win.UltraWinGrid.SortIndicator.Ascending, False)
        Dim Appearance1 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraDataColumn1 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("CC_ID")
        Dim UltraDataColumn2 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("CC_IDTIPO_ORI")
        Dim UltraDataColumn3 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("TIPO")
        Dim UltraDataColumn4 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("CC_IDNUM_HIST")
        Dim UltraDataColumn5 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("PACIENTE")
        Dim UltraDataColumn6 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("CC_IDCLIENTE")
        Dim UltraDataColumn7 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("CC_IDTIPO_ATENC")
        Dim UltraDataColumn8 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("CC_IDSEGURO")
        Dim UltraDataColumn9 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("CC_FECHA")
        Dim UltraDataColumn10 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("CC_IDPREFAC")
        Dim UltraDataColumn11 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("CC_SIT_COD_EPS")
        Dim UltraDataColumn12 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("CC_SIT_COD_ASEG")
        Dim UltraDataColumn13 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("CC_SIT_FEC_AUTORI")
        Dim UltraDataColumn14 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("CC_SIT_COD_COBER")
        Dim UltraDataColumn15 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("CC_SIT_COPG_FIJO")
        Dim UltraDataColumn16 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("CC_SIT_COPG_VARI")
        Dim UltraDataColumn17 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("CC_SIT_COD_GENE")
        Dim UltraDataColumn18 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("CC_TIPOAFILIACION")
        Dim UltraDataColumn19 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("MEDICO")
        Dim UltraDataColumn20 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("ESTADO")
        Dim Appearance54 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance45 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance3 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance5 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Me.uce_campos = New Infragistics.Win.UltraWinEditors.UltraComboEditor()
        Me.txt_filtro = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.ubtn_Aceptar = New Infragistics.Win.Misc.UltraButton()
        Me.ubtn_Cancelar = New Infragistics.Win.Misc.UltraButton()
        Me.ug_data = New Infragistics.Win.UltraWinGrid.UltraGrid()
        Me.uds_Lista = New Infragistics.Win.UltraWinDataSource.UltraDataSource(Me.components)
        Me.ubtn_Consultar = New Infragistics.Win.Misc.UltraButton()
        Me.udte_fechaH = New Infragistics.Win.UltraWinEditors.UltraDateTimeEditor()
        Me.UltraLabel2 = New Infragistics.Win.Misc.UltraLabel()
        Me.udte_fechaD = New Infragistics.Win.UltraWinEditors.UltraDateTimeEditor()
        Me.UltraLabel1 = New Infragistics.Win.Misc.UltraLabel()
        Me.uck_Fecha = New Infragistics.Win.UltraWinEditors.UltraCheckEditor()
        CType(Me.uce_campos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_filtro, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ug_data, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.uds_Lista, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.udte_fechaH, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.udte_fechaD, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'uce_campos
        '
        Me.uce_campos.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        ValueListItem1.DataValue = "HC_APE_PAT+' '+HC_APE_MAT+' '+HC_APE_CASADA+' '+HC_NOMBRE1+' '+HC_NOMBRE2"
        ValueListItem1.DisplayText = "PACIENTE"
        ValueListItem2.DataValue = "CC_IDNUM_HIST"
        ValueListItem2.DisplayText = "Nº HISTORIA C."
        ValueListItem3.DataValue = "CC_ID"
        ValueListItem3.DisplayText = "Nº CUENTA"
        Me.uce_campos.Items.AddRange(New Infragistics.Win.ValueListItem() {ValueListItem1, ValueListItem2, ValueListItem3})
        Me.uce_campos.Location = New System.Drawing.Point(12, 7)
        Me.uce_campos.Name = "uce_campos"
        Me.uce_campos.Size = New System.Drawing.Size(161, 21)
        Me.uce_campos.TabIndex = 0
        '
        'txt_filtro
        '
        Me.txt_filtro.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_filtro.Location = New System.Drawing.Point(179, 7)
        Me.txt_filtro.Name = "txt_filtro"
        Me.txt_filtro.Size = New System.Drawing.Size(640, 21)
        Me.txt_filtro.TabIndex = 1
        '
        'ubtn_Aceptar
        '
        Me.ubtn_Aceptar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ubtn_Aceptar.Location = New System.Drawing.Point(656, 459)
        Me.ubtn_Aceptar.Name = "ubtn_Aceptar"
        Me.ubtn_Aceptar.Size = New System.Drawing.Size(75, 30)
        Me.ubtn_Aceptar.TabIndex = 9
        Me.ubtn_Aceptar.Text = "&Aceptar"
        '
        'ubtn_Cancelar
        '
        Me.ubtn_Cancelar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ubtn_Cancelar.Location = New System.Drawing.Point(737, 459)
        Me.ubtn_Cancelar.Name = "ubtn_Cancelar"
        Me.ubtn_Cancelar.Size = New System.Drawing.Size(82, 30)
        Me.ubtn_Cancelar.TabIndex = 10
        Me.ubtn_Cancelar.Text = "&Cancelar"
        '
        'ug_data
        '
        Me.ug_data.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ug_data.DataSource = Me.uds_Lista
        Me.ug_data.DisplayLayout.AutoFitStyle = Infragistics.Win.UltraWinGrid.AutoFitStyle.ExtendLastColumn
        UltraGridColumn1.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn1.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn1.Header.Caption = "CUENTA"
        UltraGridColumn1.Header.VisiblePosition = 0
        UltraGridColumn1.Width = 75
        UltraGridColumn2.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn2.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn2.Header.VisiblePosition = 1
        UltraGridColumn2.Hidden = True
        UltraGridColumn3.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn3.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn3.Header.VisiblePosition = 2
        UltraGridColumn3.Width = 120
        UltraGridColumn4.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn4.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn4.Header.Caption = "H.C."
        UltraGridColumn4.Header.VisiblePosition = 3
        UltraGridColumn4.Width = 100
        UltraGridColumn5.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn5.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn5.Header.VisiblePosition = 4
        UltraGridColumn5.Width = 320
        UltraGridColumn6.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn6.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn6.Header.VisiblePosition = 5
        UltraGridColumn6.Hidden = True
        UltraGridColumn7.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn7.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn7.Header.VisiblePosition = 6
        UltraGridColumn7.Hidden = True
        UltraGridColumn8.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn8.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn8.Header.VisiblePosition = 7
        UltraGridColumn8.Hidden = True
        UltraGridColumn9.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn9.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn9.Header.Caption = "FECHA"
        UltraGridColumn9.Header.VisiblePosition = 8
        UltraGridColumn9.Width = 90
        UltraGridColumn10.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn10.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn10.Header.VisiblePosition = 9
        UltraGridColumn10.Hidden = True
        UltraGridColumn11.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn11.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn11.Header.VisiblePosition = 10
        UltraGridColumn11.Hidden = True
        UltraGridColumn12.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn12.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn12.Header.VisiblePosition = 11
        UltraGridColumn12.Hidden = True
        UltraGridColumn13.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn13.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn13.Header.VisiblePosition = 12
        UltraGridColumn13.Hidden = True
        UltraGridColumn14.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn14.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn14.Header.VisiblePosition = 13
        UltraGridColumn14.Hidden = True
        UltraGridColumn15.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn15.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn15.Header.VisiblePosition = 14
        UltraGridColumn15.Hidden = True
        UltraGridColumn16.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn16.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn16.Header.VisiblePosition = 15
        UltraGridColumn16.Hidden = True
        UltraGridColumn17.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn17.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn17.Header.VisiblePosition = 16
        UltraGridColumn17.Hidden = True
        UltraGridColumn18.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn18.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn18.Header.VisiblePosition = 17
        UltraGridColumn18.Hidden = True
        UltraGridColumn19.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn19.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn19.Header.VisiblePosition = 18
        UltraGridColumn19.Hidden = True
        UltraGridColumn20.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn20.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn20.Header.VisiblePosition = 19
        UltraGridBand1.Columns.AddRange(New Object() {UltraGridColumn1, UltraGridColumn2, UltraGridColumn3, UltraGridColumn4, UltraGridColumn5, UltraGridColumn6, UltraGridColumn7, UltraGridColumn8, UltraGridColumn9, UltraGridColumn10, UltraGridColumn11, UltraGridColumn12, UltraGridColumn13, UltraGridColumn14, UltraGridColumn15, UltraGridColumn16, UltraGridColumn17, UltraGridColumn18, UltraGridColumn19, UltraGridColumn20})
        Me.ug_data.DisplayLayout.BandsSerializer.Add(UltraGridBand1)
        Me.ug_data.DisplayLayout.MaxColScrollRegions = 1
        Me.ug_data.DisplayLayout.MaxRowScrollRegions = 1
        Me.ug_data.DisplayLayout.Override.AllowAddNew = Infragistics.Win.UltraWinGrid.AllowAddNew.No
        Me.ug_data.DisplayLayout.Override.AllowDelete = Infragistics.Win.DefaultableBoolean.[False]
        Me.ug_data.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.[False]
        Me.ug_data.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Appearance1.BackColor = System.Drawing.Color.WhiteSmoke
        Appearance1.BackColor2 = System.Drawing.Color.WhiteSmoke
        Me.ug_data.DisplayLayout.Override.RowAlternateAppearance = Appearance1
        Me.ug_data.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.ug_data.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.ug_data.Location = New System.Drawing.Point(2, 67)
        Me.ug_data.Name = "ug_data"
        Me.ug_data.Size = New System.Drawing.Size(827, 386)
        Me.ug_data.TabIndex = 8
        '
        'uds_Lista
        '
        Me.uds_Lista.AllowDelete = False
        UltraDataColumn1.DataType = GetType(Long)
        UltraDataColumn2.DataType = GetType(Long)
        UltraDataColumn4.DataType = GetType(Integer)
        UltraDataColumn6.DataType = GetType(Integer)
        UltraDataColumn7.DataType = GetType(Integer)
        UltraDataColumn8.DataType = GetType(Integer)
        UltraDataColumn10.DataType = GetType(Integer)
        UltraDataColumn14.DataType = GetType(Integer)
        UltraDataColumn15.DataType = GetType(Double)
        UltraDataColumn16.DataType = GetType(Double)
        UltraDataColumn18.DataType = GetType(Integer)
        Me.uds_Lista.Band.Columns.AddRange(New Object() {UltraDataColumn1, UltraDataColumn2, UltraDataColumn3, UltraDataColumn4, UltraDataColumn5, UltraDataColumn6, UltraDataColumn7, UltraDataColumn8, UltraDataColumn9, UltraDataColumn10, UltraDataColumn11, UltraDataColumn12, UltraDataColumn13, UltraDataColumn14, UltraDataColumn15, UltraDataColumn16, UltraDataColumn17, UltraDataColumn18, UltraDataColumn19, UltraDataColumn20})
        '
        'ubtn_Consultar
        '
        Me.ubtn_Consultar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Appearance54.FontData.SizeInPoints = 8.0!
        Appearance54.ImageHAlign = Infragistics.Win.HAlign.Center
        Me.ubtn_Consultar.Appearance = Appearance54
        Me.ubtn_Consultar.Location = New System.Drawing.Point(699, 37)
        Me.ubtn_Consultar.Name = "ubtn_Consultar"
        Me.ubtn_Consultar.Size = New System.Drawing.Size(120, 24)
        Me.ubtn_Consultar.TabIndex = 30
        Me.ubtn_Consultar.Text = "Consultar"
        '
        'udte_fechaH
        '
        Me.udte_fechaH.DateTime = New Date(2014, 1, 28, 0, 0, 0, 0)
        Me.udte_fechaH.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.udte_fechaH.Location = New System.Drawing.Point(479, 37)
        Me.udte_fechaH.Name = "udte_fechaH"
        Me.udte_fechaH.Size = New System.Drawing.Size(116, 24)
        Me.udte_fechaH.TabIndex = 157
        Me.udte_fechaH.Value = New Date(2014, 1, 28, 0, 0, 0, 0)
        '
        'UltraLabel2
        '
        Appearance45.BackColor = System.Drawing.Color.Transparent
        Appearance45.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel2.Appearance = Appearance45
        Me.UltraLabel2.AutoSize = True
        Me.UltraLabel2.Location = New System.Drawing.Point(401, 43)
        Me.UltraLabel2.Name = "UltraLabel2"
        Me.UltraLabel2.Size = New System.Drawing.Size(68, 14)
        Me.UltraLabel2.TabIndex = 159
        Me.UltraLabel2.Text = "Fecha Hasta"
        '
        'udte_fechaD
        '
        Me.udte_fechaD.DateTime = New Date(2014, 1, 28, 0, 0, 0, 0)
        Me.udte_fechaD.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.udte_fechaD.Location = New System.Drawing.Point(253, 37)
        Me.udte_fechaD.Name = "udte_fechaD"
        Me.udte_fechaD.Size = New System.Drawing.Size(116, 24)
        Me.udte_fechaD.TabIndex = 156
        Me.udte_fechaD.Value = New Date(2014, 1, 28, 0, 0, 0, 0)
        '
        'UltraLabel1
        '
        Appearance3.BackColor = System.Drawing.Color.Transparent
        Appearance3.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel1.Appearance = Appearance3
        Me.UltraLabel1.AutoSize = True
        Me.UltraLabel1.Location = New System.Drawing.Point(175, 42)
        Me.UltraLabel1.Name = "UltraLabel1"
        Me.UltraLabel1.Size = New System.Drawing.Size(71, 14)
        Me.UltraLabel1.TabIndex = 158
        Me.UltraLabel1.Text = "Fecha Desde"
        '
        'uck_Fecha
        '
        Appearance5.ForeColor = System.Drawing.Color.Navy
        Me.uck_Fecha.Appearance = Appearance5
        Me.uck_Fecha.BackColor = System.Drawing.Color.Transparent
        Me.uck_Fecha.BackColorInternal = System.Drawing.Color.Transparent
        Me.uck_Fecha.Location = New System.Drawing.Point(12, 38)
        Me.uck_Fecha.Name = "uck_Fecha"
        Me.uck_Fecha.Size = New System.Drawing.Size(137, 22)
        Me.uck_Fecha.TabIndex = 160
        Me.uck_Fecha.Text = "Filtrar por Fecha"
        '
        'FA_PR_ListaCuentas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(831, 493)
        Me.Controls.Add(Me.uck_Fecha)
        Me.Controls.Add(Me.udte_fechaH)
        Me.Controls.Add(Me.UltraLabel2)
        Me.Controls.Add(Me.udte_fechaD)
        Me.Controls.Add(Me.UltraLabel1)
        Me.Controls.Add(Me.ubtn_Consultar)
        Me.Controls.Add(Me.uce_campos)
        Me.Controls.Add(Me.txt_filtro)
        Me.Controls.Add(Me.ubtn_Aceptar)
        Me.Controls.Add(Me.ubtn_Cancelar)
        Me.Controls.Add(Me.ug_data)
        Me.Name = "FA_PR_ListaCuentas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Listado de Cuentas"
        CType(Me.uce_campos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_filtro, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ug_data, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.uds_Lista, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.udte_fechaH, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.udte_fechaD, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents uce_campos As Infragistics.Win.UltraWinEditors.UltraComboEditor
    Friend WithEvents txt_filtro As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents ubtn_Aceptar As Infragistics.Win.Misc.UltraButton
    Friend WithEvents ubtn_Cancelar As Infragistics.Win.Misc.UltraButton
    Friend WithEvents ug_data As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents uds_Lista As Infragistics.Win.UltraWinDataSource.UltraDataSource
    Friend WithEvents ubtn_Consultar As Infragistics.Win.Misc.UltraButton
    Friend WithEvents udte_fechaH As Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
    Friend WithEvents UltraLabel2 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents udte_fechaD As Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
    Friend WithEvents UltraLabel1 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents uck_Fecha As Infragistics.Win.UltraWinEditors.UltraCheckEditor
End Class
