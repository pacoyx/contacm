<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FE_RE_BuscarPacienteC
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
        Dim ValueListItem1 As Infragistics.Win.ValueListItem = New Infragistics.Win.ValueListItem()
        Dim ValueListItem2 As Infragistics.Win.ValueListItem = New Infragistics.Win.ValueListItem()
        Dim UltraGridBand1 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1)
        Dim UltraGridColumn1 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("cf_codpac")
        Dim UltraGridColumn2 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("cuenta")
        Dim UltraGridColumn3 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("paciente")
        Dim UltraGridColumn4 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("prestacion")
        Dim UltraGridColumn5 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("codigo")
        Dim UltraGridColumn6 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ficha")
        Dim Appearance1 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraDataColumn1 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("cf_codpac")
        Dim UltraDataColumn2 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("cuenta")
        Dim UltraDataColumn3 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("paciente")
        Dim UltraDataColumn4 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("prestacion")
        Dim UltraDataColumn5 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("codigo")
        Dim UltraDataColumn6 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("ficha")
        Me.ubtn_Consultar = New Infragistics.Win.Misc.UltraButton()
        Me.txt_Filtro = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.ucb_Campos = New Infragistics.Win.UltraWinEditors.UltraComboEditor()
        Me.ug_Lista = New Infragistics.Win.UltraWinGrid.UltraGrid()
        Me.uds_Lista = New Infragistics.Win.UltraWinDataSource.UltraDataSource(Me.components)
        CType(Me.txt_Filtro, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ucb_Campos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ug_Lista, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.uds_Lista, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ubtn_Consultar
        '
        Me.ubtn_Consultar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Appearance54.FontData.SizeInPoints = 8.0!
        Appearance54.ImageHAlign = Infragistics.Win.HAlign.Center
        Me.ubtn_Consultar.Appearance = Appearance54
        Me.ubtn_Consultar.Location = New System.Drawing.Point(472, 11)
        Me.ubtn_Consultar.Name = "ubtn_Consultar"
        Me.ubtn_Consultar.Size = New System.Drawing.Size(120, 24)
        Me.ubtn_Consultar.TabIndex = 1
        Me.ubtn_Consultar.Text = "Consultar"
        '
        'txt_Filtro
        '
        Me.txt_Filtro.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_Filtro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_Filtro.Location = New System.Drawing.Point(180, 12)
        Me.txt_Filtro.MaxLength = 50
        Me.txt_Filtro.Name = "txt_Filtro"
        Me.txt_Filtro.Size = New System.Drawing.Size(284, 21)
        Me.txt_Filtro.TabIndex = 0
        '
        'ucb_Campos
        '
        Me.ucb_Campos.DropDownListWidth = 300
        Me.ucb_Campos.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        ValueListItem1.DataValue = "1"
        ValueListItem1.DisplayText = "Paciente"
        ValueListItem2.DataValue = "2"
        ValueListItem2.DisplayText = "Nº Cuenta"
        Me.ucb_Campos.Items.AddRange(New Infragistics.Win.ValueListItem() {ValueListItem1, ValueListItem2})
        Me.ucb_Campos.Location = New System.Drawing.Point(12, 12)
        Me.ucb_Campos.Name = "ucb_Campos"
        Me.ucb_Campos.Size = New System.Drawing.Size(162, 21)
        Me.ucb_Campos.TabIndex = 4
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
        UltraGridColumn1.Header.Caption = "APELLIDOS Y NOMBRES"
        UltraGridColumn1.Header.VisiblePosition = 0
        UltraGridColumn1.Hidden = True
        UltraGridColumn1.Width = 270
        UltraGridColumn2.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn2.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn2.Header.Caption = "Cuenta"
        UltraGridColumn2.Header.VisiblePosition = 1
        UltraGridColumn2.Width = 100
        UltraGridColumn3.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn3.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn3.Header.Caption = "Paciente"
        UltraGridColumn3.Header.VisiblePosition = 2
        UltraGridColumn3.Width = 300
        UltraGridColumn4.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn4.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn4.Header.Caption = "Procedimiento"
        UltraGridColumn4.Header.VisiblePosition = 3
        UltraGridColumn4.Width = 200
        UltraGridColumn5.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn5.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn5.Header.VisiblePosition = 4
        UltraGridColumn5.Hidden = True
        UltraGridColumn5.Width = 131
        UltraGridColumn6.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn6.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn6.Header.VisiblePosition = 5
        UltraGridColumn6.Hidden = True
        UltraGridBand1.Columns.AddRange(New Object() {UltraGridColumn1, UltraGridColumn2, UltraGridColumn3, UltraGridColumn4, UltraGridColumn5, UltraGridColumn6})
        Me.ug_Lista.DisplayLayout.BandsSerializer.Add(UltraGridBand1)
        Me.ug_Lista.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.[False]
        Me.ug_Lista.DisplayLayout.MaxColScrollRegions = 1
        Me.ug_Lista.DisplayLayout.MaxRowScrollRegions = 1
        Appearance1.BackColor = System.Drawing.Color.WhiteSmoke
        Appearance1.BackColor2 = System.Drawing.Color.WhiteSmoke
        Me.ug_Lista.DisplayLayout.Override.RowAlternateAppearance = Appearance1
        Me.ug_Lista.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.ug_Lista.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.ug_Lista.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ug_Lista.Location = New System.Drawing.Point(12, 43)
        Me.ug_Lista.Name = "ug_Lista"
        Me.ug_Lista.Size = New System.Drawing.Size(681, 416)
        Me.ug_Lista.TabIndex = 2
        Me.ug_Lista.Text = "UltraGrid1"
        '
        'uds_Lista
        '
        Me.uds_Lista.AllowDelete = False
        Me.uds_Lista.Band.Columns.AddRange(New Object() {UltraDataColumn1, UltraDataColumn2, UltraDataColumn3, UltraDataColumn4, UltraDataColumn5, UltraDataColumn6})
        '
        'FE_RE_BuscarPacienteC
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(705, 470)
        Me.Controls.Add(Me.ug_Lista)
        Me.Controls.Add(Me.ubtn_Consultar)
        Me.Controls.Add(Me.txt_Filtro)
        Me.Controls.Add(Me.ucb_Campos)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "FE_RE_BuscarPacienteC"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Busca de Cuenta - Fertilidad"
        CType(Me.txt_Filtro, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ucb_Campos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ug_Lista, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.uds_Lista, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ubtn_Consultar As Infragistics.Win.Misc.UltraButton
    Friend WithEvents txt_Filtro As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents ucb_Campos As Infragistics.Win.UltraWinEditors.UltraComboEditor
    Friend WithEvents ug_Lista As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents uds_Lista As Infragistics.Win.UltraWinDataSource.UltraDataSource
End Class
