<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AD_RE_ConsultaEcografia
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
        Dim Appearance54 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraDataColumn1 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("fecha")
        Dim UltraDataColumn2 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("tipo")
        Dim UltraDataColumn3 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Cobertura")
        Dim UltraDataColumn4 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("medico")
        Dim UltraDataColumn5 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("paciente")
        Dim UltraDataColumn6 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("numide")
        Dim UltraDataColumn7 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("CD_SEG_CUBRE")
        Dim UltraGridBand1 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1)
        Dim UltraGridColumn1 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("fecha")
        Dim UltraGridColumn2 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("tipo")
        Dim UltraGridColumn3 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Cobertura")
        Dim UltraGridColumn4 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("medico")
        Dim UltraGridColumn5 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("paciente")
        Dim UltraGridColumn6 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("numide")
        Dim UltraGridColumn7 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CD_SEG_CUBRE")
        Dim Appearance1 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim ValueListItem1 As Infragistics.Win.ValueListItem = New Infragistics.Win.ValueListItem()
        Dim ValueListItem2 As Infragistics.Win.ValueListItem = New Infragistics.Win.ValueListItem()
        Dim ValueListItem3 As Infragistics.Win.ValueListItem = New Infragistics.Win.ValueListItem()
        Me.ubtn_Consultar = New Infragistics.Win.Misc.UltraButton()
        Me.uds_Lista = New Infragistics.Win.UltraWinDataSource.UltraDataSource(Me.components)
        Me.ug_Lista = New Infragistics.Win.UltraWinGrid.UltraGrid()
        Me.txt_Filtro = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.ucb_Campos = New Infragistics.Win.UltraWinEditors.UltraComboEditor()
        CType(Me.uds_Lista, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ug_Lista, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_Filtro, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ucb_Campos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ubtn_Consultar
        '
        Me.ubtn_Consultar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Appearance54.FontData.SizeInPoints = 8.0!
        Appearance54.ImageHAlign = Infragistics.Win.HAlign.Center
        Me.ubtn_Consultar.Appearance = Appearance54
        Me.ubtn_Consultar.Location = New System.Drawing.Point(778, 2)
        Me.ubtn_Consultar.Name = "ubtn_Consultar"
        Me.ubtn_Consultar.Size = New System.Drawing.Size(120, 33)
        Me.ubtn_Consultar.TabIndex = 1
        Me.ubtn_Consultar.Text = "Consultar"
        '
        'uds_Lista
        '
        Me.uds_Lista.AllowDelete = False
        UltraDataColumn7.DataType = GetType(Integer)
        Me.uds_Lista.Band.Columns.AddRange(New Object() {UltraDataColumn1, UltraDataColumn2, UltraDataColumn3, UltraDataColumn4, UltraDataColumn5, UltraDataColumn6, UltraDataColumn7})
        '
        'ug_Lista
        '
        Me.ug_Lista.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ug_Lista.DataSource = Me.uds_Lista
        Me.ug_Lista.DisplayLayout.AutoFitStyle = Infragistics.Win.UltraWinGrid.AutoFitStyle.ExtendLastColumn
        UltraGridColumn1.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn1.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn1.Header.Caption = "Fecha Cita"
        UltraGridColumn1.Header.VisiblePosition = 0
        UltraGridColumn1.Width = 70
        UltraGridColumn2.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn2.Header.Caption = "Tipo de Ecografia"
        UltraGridColumn2.Header.VisiblePosition = 1
        UltraGridColumn2.Width = 200
        UltraGridColumn3.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn3.Header.VisiblePosition = 2
        UltraGridColumn3.Width = 200
        UltraGridColumn4.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn4.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn4.Header.Caption = "Médico"
        UltraGridColumn4.Header.VisiblePosition = 3
        UltraGridColumn4.Width = 150
        UltraGridColumn5.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn5.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn5.Header.Caption = "Paciente"
        UltraGridColumn5.Header.VisiblePosition = 4
        UltraGridColumn5.Width = 250
        UltraGridColumn6.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn6.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn6.Header.Caption = "Nº Historia"
        UltraGridColumn6.Header.VisiblePosition = 5
        UltraGridColumn6.Width = 100
        UltraGridColumn7.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn7.Header.VisiblePosition = 6
        UltraGridColumn7.Hidden = True
        UltraGridBand1.Columns.AddRange(New Object() {UltraGridColumn1, UltraGridColumn2, UltraGridColumn3, UltraGridColumn4, UltraGridColumn5, UltraGridColumn6, UltraGridColumn7})
        Me.ug_Lista.DisplayLayout.BandsSerializer.Add(UltraGridBand1)
        Me.ug_Lista.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.[False]
        Me.ug_Lista.DisplayLayout.MaxColScrollRegions = 1
        Me.ug_Lista.DisplayLayout.MaxRowScrollRegions = 1
        Me.ug_Lista.DisplayLayout.Override.FilterUIType = Infragistics.Win.UltraWinGrid.FilterUIType.FilterRow
        Appearance1.BackColor = System.Drawing.Color.WhiteSmoke
        Appearance1.BackColor2 = System.Drawing.Color.WhiteSmoke
        Me.ug_Lista.DisplayLayout.Override.RowAlternateAppearance = Appearance1
        Me.ug_Lista.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.ug_Lista.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.ug_Lista.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ug_Lista.Location = New System.Drawing.Point(1, 41)
        Me.ug_Lista.Name = "ug_Lista"
        Me.ug_Lista.Size = New System.Drawing.Size(1000, 526)
        Me.ug_Lista.TabIndex = 2
        Me.ug_Lista.Text = "UltraGrid1"
        '
        'txt_Filtro
        '
        Me.txt_Filtro.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_Filtro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_Filtro.Location = New System.Drawing.Point(177, 10)
        Me.txt_Filtro.MaxLength = 50
        Me.txt_Filtro.Name = "txt_Filtro"
        Me.txt_Filtro.Size = New System.Drawing.Size(527, 21)
        Me.txt_Filtro.TabIndex = 0
        '
        'ucb_Campos
        '
        Me.ucb_Campos.DropDownListWidth = 300
        Me.ucb_Campos.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        ValueListItem1.DataValue = "1"
        ValueListItem1.DisplayText = "Apellidos o Nombres"
        ValueListItem2.DataValue = "2"
        ValueListItem2.DisplayText = "Nº Historia"
        ValueListItem3.DataValue = "3"
        ValueListItem3.DisplayText = "Nº Documento"
        Me.ucb_Campos.Items.AddRange(New Infragistics.Win.ValueListItem() {ValueListItem1, ValueListItem2, ValueListItem3})
        Me.ucb_Campos.Location = New System.Drawing.Point(9, 10)
        Me.ucb_Campos.Name = "ucb_Campos"
        Me.ucb_Campos.Size = New System.Drawing.Size(162, 21)
        Me.ucb_Campos.TabIndex = 3
        '
        'AD_RE_ConsultaEcografia
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1004, 569)
        Me.Controls.Add(Me.txt_Filtro)
        Me.Controls.Add(Me.ucb_Campos)
        Me.Controls.Add(Me.ubtn_Consultar)
        Me.Controls.Add(Me.ug_Lista)
        Me.Name = "AD_RE_ConsultaEcografia"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Consulta de Atenciones de Ecografia"
        CType(Me.uds_Lista, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ug_Lista, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_Filtro, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ucb_Campos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ubtn_Consultar As Infragistics.Win.Misc.UltraButton
    Friend WithEvents uds_Lista As Infragistics.Win.UltraWinDataSource.UltraDataSource
    Friend WithEvents ug_Lista As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents txt_Filtro As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents ucb_Campos As Infragistics.Win.UltraWinEditors.UltraComboEditor
End Class
