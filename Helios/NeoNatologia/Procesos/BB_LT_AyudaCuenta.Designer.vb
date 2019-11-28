<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BB_LT_AyudaCuenta
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
        Dim UltraDataColumn1 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("CC_ID")
        Dim UltraDataColumn2 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("CC_IDTIPO_ORI")
        Dim UltraDataColumn3 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("TIPO")
        Dim UltraDataColumn4 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("CC_IDNUM_HIST")
        Dim UltraDataColumn5 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("PACIENTE")
        Dim UltraDataColumn6 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("CC_IDCLIENTE")
        Dim UltraDataColumn7 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("CC_IDTIPO_ATENC")
        Dim UltraDataColumn8 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("CC_IDSEGURO")
        Dim UltraDataColumn9 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("CC_FECHA")
        Dim UltraDataColumn10 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("CC_SIT_COPG_FIJO")
        Dim UltraDataColumn11 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("CC_SIT_COPG_VARI")
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
        Dim UltraGridColumn10 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CC_SIT_COPG_FIJO")
        Dim UltraGridColumn11 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CC_SIT_COPG_VARI")
        Dim Appearance1 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance54 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Me.uce_campos = New Infragistics.Win.UltraWinEditors.UltraComboEditor()
        Me.txt_filtro = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.uds_Lista = New Infragistics.Win.UltraWinDataSource.UltraDataSource(Me.components)
        Me.ug_data = New Infragistics.Win.UltraWinGrid.UltraGrid()
        Me.ubtn_Consultar = New Infragistics.Win.Misc.UltraButton()
        CType(Me.uce_campos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_filtro, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.uds_Lista, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ug_data, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.uce_campos.Location = New System.Drawing.Point(24, 17)
        Me.uce_campos.Name = "uce_campos"
        Me.uce_campos.Size = New System.Drawing.Size(161, 21)
        Me.uce_campos.TabIndex = 9
        '
        'txt_filtro
        '
        Me.txt_filtro.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_filtro.Location = New System.Drawing.Point(191, 17)
        Me.txt_filtro.Name = "txt_filtro"
        Me.txt_filtro.Size = New System.Drawing.Size(511, 21)
        Me.txt_filtro.TabIndex = 10
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
        UltraDataColumn10.DataType = GetType(Double)
        UltraDataColumn11.DataType = GetType(Double)
        Me.uds_Lista.Band.Columns.AddRange(New Object() {UltraDataColumn1, UltraDataColumn2, UltraDataColumn3, UltraDataColumn4, UltraDataColumn5, UltraDataColumn6, UltraDataColumn7, UltraDataColumn8, UltraDataColumn9, UltraDataColumn10, UltraDataColumn11})
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
        UltraGridBand1.Columns.AddRange(New Object() {UltraGridColumn1, UltraGridColumn2, UltraGridColumn3, UltraGridColumn4, UltraGridColumn5, UltraGridColumn6, UltraGridColumn7, UltraGridColumn8, UltraGridColumn9, UltraGridColumn10, UltraGridColumn11})
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
        Me.ug_data.Location = New System.Drawing.Point(14, 47)
        Me.ug_data.Name = "ug_data"
        Me.ug_data.Size = New System.Drawing.Size(827, 422)
        Me.ug_data.TabIndex = 12
        '
        'ubtn_Consultar
        '
        Me.ubtn_Consultar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Appearance54.FontData.SizeInPoints = 8.0!
        Appearance54.ImageHAlign = Infragistics.Win.HAlign.Center
        Me.ubtn_Consultar.Appearance = Appearance54
        Me.ubtn_Consultar.Location = New System.Drawing.Point(711, 15)
        Me.ubtn_Consultar.Name = "ubtn_Consultar"
        Me.ubtn_Consultar.Size = New System.Drawing.Size(120, 24)
        Me.ubtn_Consultar.TabIndex = 11
        Me.ubtn_Consultar.Text = "Consultar"
        '
        'BB_LT_AyudaCuenta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(855, 481)
        Me.Controls.Add(Me.ug_data)
        Me.Controls.Add(Me.ubtn_Consultar)
        Me.Controls.Add(Me.uce_campos)
        Me.Controls.Add(Me.txt_filtro)
        Me.Name = "BB_LT_AyudaCuenta"
        Me.Text = "Listado de Cuentas"
        CType(Me.uce_campos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_filtro, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.uds_Lista, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ug_data, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents uce_campos As Infragistics.Win.UltraWinEditors.UltraComboEditor
    Friend WithEvents txt_filtro As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents uds_Lista As Infragistics.Win.UltraWinDataSource.UltraDataSource
    Friend WithEvents ug_data As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents ubtn_Consultar As Infragistics.Win.Misc.UltraButton
End Class
