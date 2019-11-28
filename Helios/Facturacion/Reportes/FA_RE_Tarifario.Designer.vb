<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FA_RE_Tarifario
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
        Dim ValueListItem3 As Infragistics.Win.ValueListItem = New Infragistics.Win.ValueListItem()
        Dim ValueListItem4 As Infragistics.Win.ValueListItem = New Infragistics.Win.ValueListItem()
        Dim UltraGridBand1 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1)
        Dim UltraGridColumn1 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("SEL")
        Dim UltraGridColumn2 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("AR_ID")
        Dim UltraGridColumn3 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FA_DESCRIPCION")
        Dim UltraGridColumn4 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CA_DESCRIPCION")
        Dim UltraGridColumn5 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("AR_CODIGO")
        Dim UltraGridColumn6 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("AR_DESCRIPCION")
        Dim UltraGridColumn7 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("AR_PRECIO_VENTA")
        Dim Appearance1 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn8 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CA_Consulta")
        Dim UltraGridColumn9 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CA_SINPAGO")
        Dim Appearance2 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraDataColumn1 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("SEL")
        Dim UltraDataColumn2 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("AR_ID")
        Dim UltraDataColumn3 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("FA_DESCRIPCION")
        Dim UltraDataColumn4 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("CA_DESCRIPCION")
        Dim UltraDataColumn5 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("AR_CODIGO")
        Dim UltraDataColumn6 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("AR_DESCRIPCION")
        Dim UltraDataColumn7 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("AR_PRECIO_VENTA")
        Dim UltraDataColumn8 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("CA_Consulta")
        Dim UltraDataColumn9 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("CA_SINPAGO")
        Me.UltraGroupBox1 = New Infragistics.Win.Misc.UltraGroupBox()
        Me.ub_Detallar = New Infragistics.Win.Misc.UltraButton()
        Me.uos_opcion = New Infragistics.Win.UltraWinEditors.UltraOptionSet()
        Me.ucm_SeguroEps = New Infragistics.Win.UltraWinEditors.UltraComboEditor()
        Me.ug_data = New Infragistics.Win.UltraWinGrid.UltraGrid()
        Me.uds_Lista = New Infragistics.Win.UltraWinDataSource.UltraDataSource(Me.components)
        CType(Me.UltraGroupBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraGroupBox1.SuspendLayout()
        CType(Me.uos_opcion, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ucm_SeguroEps, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ug_data, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.uds_Lista, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'UltraGroupBox1
        '
        Me.UltraGroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.UltraGroupBox1.Controls.Add(Me.ub_Detallar)
        Me.UltraGroupBox1.Controls.Add(Me.uos_opcion)
        Me.UltraGroupBox1.Controls.Add(Me.ucm_SeguroEps)
        Me.UltraGroupBox1.Location = New System.Drawing.Point(5, 4)
        Me.UltraGroupBox1.Name = "UltraGroupBox1"
        Me.UltraGroupBox1.Size = New System.Drawing.Size(859, 37)
        Me.UltraGroupBox1.TabIndex = 9
        '
        'ub_Detallar
        '
        Me.ub_Detallar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Appearance4.ImageHAlign = Infragistics.Win.HAlign.Center
        Me.ub_Detallar.Appearance = Appearance4
        Me.ub_Detallar.Location = New System.Drawing.Point(618, 6)
        Me.ub_Detallar.Name = "ub_Detallar"
        Me.ub_Detallar.Size = New System.Drawing.Size(95, 26)
        Me.ub_Detallar.TabIndex = 194
        Me.ub_Detallar.Text = "Consultar"
        '
        'uos_opcion
        '
        Me.uos_opcion.BackColor = System.Drawing.Color.Transparent
        Me.uos_opcion.BackColorInternal = System.Drawing.Color.Transparent
        Me.uos_opcion.BorderStyle = Infragistics.Win.UIElementBorderStyle.None
        Me.uos_opcion.CheckedIndex = 0
        ValueListItem3.DataValue = "0"
        ValueListItem3.DisplayText = "Particular"
        ValueListItem4.DataValue = "1"
        ValueListItem4.DisplayText = "Seguro"
        Me.uos_opcion.Items.AddRange(New Infragistics.Win.ValueListItem() {ValueListItem3, ValueListItem4})
        Me.uos_opcion.ItemSpacingHorizontal = 15
        Me.uos_opcion.ItemSpacingVertical = 5
        Me.uos_opcion.Location = New System.Drawing.Point(21, 8)
        Me.uos_opcion.Name = "uos_opcion"
        Me.uos_opcion.Size = New System.Drawing.Size(141, 26)
        Me.uos_opcion.TabIndex = 15
        Me.uos_opcion.Text = "Particular"
        '
        'ucm_SeguroEps
        '
        Me.ucm_SeguroEps.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.ucm_SeguroEps.Location = New System.Drawing.Point(168, 9)
        Me.ucm_SeguroEps.Name = "ucm_SeguroEps"
        Me.ucm_SeguroEps.Size = New System.Drawing.Size(338, 21)
        Me.ucm_SeguroEps.TabIndex = 14
        '
        'ug_data
        '
        Me.ug_data.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ug_data.DataSource = Me.uds_Lista
        Me.ug_data.DisplayLayout.AutoFitStyle = Infragistics.Win.UltraWinGrid.AutoFitStyle.ExtendLastColumn
        UltraGridColumn1.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn1.Header.Caption = "Sel"
        UltraGridColumn1.Header.VisiblePosition = 0
        UltraGridColumn1.Hidden = True
        UltraGridColumn1.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.CheckBox
        UltraGridColumn2.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn2.Header.VisiblePosition = 1
        UltraGridColumn2.Hidden = True
        UltraGridColumn3.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn3.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn3.Header.Caption = "Familia"
        UltraGridColumn3.Header.VisiblePosition = 2
        UltraGridColumn3.Width = 139
        UltraGridColumn4.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn4.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn4.Header.Caption = "Categoria"
        UltraGridColumn4.Header.VisiblePosition = 3
        UltraGridColumn4.Width = 225
        UltraGridColumn5.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn5.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn5.Header.Caption = "Codigo"
        UltraGridColumn5.Header.VisiblePosition = 4
        UltraGridColumn5.Width = 60
        UltraGridColumn6.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn6.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn6.Header.Caption = "DESCRIPCION"
        UltraGridColumn6.Header.VisiblePosition = 5
        UltraGridColumn6.Width = 320
        UltraGridColumn7.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn7.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        Appearance1.TextHAlignAsString = "Right"
        UltraGridColumn7.CellAppearance = Appearance1
        UltraGridColumn7.Header.Caption = "PRECIO"
        UltraGridColumn7.Header.VisiblePosition = 6
        UltraGridColumn7.MaskDisplayMode = Infragistics.Win.UltraWinMaskedEdit.MaskMode.IncludeLiterals
        UltraGridColumn7.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Double]
        UltraGridColumn8.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn8.Header.Caption = "INC_IGV"
        UltraGridColumn8.Header.VisiblePosition = 7
        UltraGridColumn8.Hidden = True
        UltraGridColumn9.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn9.Header.VisiblePosition = 8
        UltraGridColumn9.Hidden = True
        UltraGridBand1.Columns.AddRange(New Object() {UltraGridColumn1, UltraGridColumn2, UltraGridColumn3, UltraGridColumn4, UltraGridColumn5, UltraGridColumn6, UltraGridColumn7, UltraGridColumn8, UltraGridColumn9})
        Me.ug_data.DisplayLayout.BandsSerializer.Add(UltraGridBand1)
        Me.ug_data.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.[False]
        Me.ug_data.DisplayLayout.MaxColScrollRegions = 1
        Me.ug_data.DisplayLayout.MaxRowScrollRegions = 1
        Me.ug_data.DisplayLayout.Override.FilterOperatorDefaultValue = Infragistics.Win.UltraWinGrid.FilterOperatorDefaultValue.Contains
        Appearance2.BackColor = System.Drawing.Color.LemonChiffon
        Me.ug_data.DisplayLayout.Override.FilterRowAppearance = Appearance2
        Me.ug_data.DisplayLayout.Override.FilterUIType = Infragistics.Win.UltraWinGrid.FilterUIType.FilterRow
        Me.ug_data.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.ug_data.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.ug_data.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ug_data.Location = New System.Drawing.Point(5, 47)
        Me.ug_data.Name = "ug_data"
        Me.ug_data.Size = New System.Drawing.Size(859, 416)
        Me.ug_data.TabIndex = 23
        Me.ug_data.Text = "UltraGrid1"
        '
        'uds_Lista
        '
        Me.uds_Lista.AllowDelete = False
        UltraDataColumn1.DataType = GetType(Boolean)
        UltraDataColumn2.DataType = GetType(Integer)
        UltraDataColumn7.DataType = GetType(Double)
        UltraDataColumn8.DataType = GetType(Short)
        UltraDataColumn9.DataType = GetType(Short)
        Me.uds_Lista.Band.Columns.AddRange(New Object() {UltraDataColumn1, UltraDataColumn2, UltraDataColumn3, UltraDataColumn4, UltraDataColumn5, UltraDataColumn6, UltraDataColumn7, UltraDataColumn8, UltraDataColumn9})
        '
        'FA_RE_Tarifario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(867, 465)
        Me.Controls.Add(Me.ug_data)
        Me.Controls.Add(Me.UltraGroupBox1)
        Me.Name = "FA_RE_Tarifario"
        Me.Text = "Tarifario"
        CType(Me.UltraGroupBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraGroupBox1.ResumeLayout(False)
        Me.UltraGroupBox1.PerformLayout()
        CType(Me.uos_opcion, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ucm_SeguroEps, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ug_data, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.uds_Lista, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents UltraGroupBox1 As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents ucm_SeguroEps As Infragistics.Win.UltraWinEditors.UltraComboEditor
    Friend WithEvents uos_opcion As Infragistics.Win.UltraWinEditors.UltraOptionSet
    Friend WithEvents ub_Detallar As Infragistics.Win.Misc.UltraButton
    Friend WithEvents ug_data As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents uds_Lista As Infragistics.Win.UltraWinDataSource.UltraDataSource
End Class
