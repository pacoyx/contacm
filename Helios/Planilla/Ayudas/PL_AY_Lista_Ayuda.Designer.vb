<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PL_AY_Lista_Ayuda
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
        Dim UltraDataColumn1 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Sel")
        Dim UltraDataColumn2 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Codigo")
        Dim UltraDataColumn3 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Descripcion")
        Dim UltraGridBand1 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1)
        Dim UltraGridColumn1 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Sel")
        Dim UltraGridColumn2 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Codigo")
        Dim UltraGridColumn3 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Descripcion")
        Dim Appearance1 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim ValueListItem1 As Infragistics.Win.ValueListItem = New Infragistics.Win.ValueListItem()
        Dim ValueListItem2 As Infragistics.Win.ValueListItem = New Infragistics.Win.ValueListItem()
        Dim Appearance3 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Me.uds_ayuda = New Infragistics.Win.UltraWinDataSource.UltraDataSource(Me.components)
        Me.ug_ayuda = New Infragistics.Win.UltraWinGrid.UltraGrid()
        Me.ToolS_Mantenimiento = New System.Windows.Forms.ToolStrip()
        Me.Tool_Aceptar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.Tool_Salir = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.txt_filtro = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.uce_filtro = New Infragistics.Win.UltraWinEditors.UltraComboEditor()
        Me.uchk_Todos = New Infragistics.Win.UltraWinEditors.UltraCheckEditor()
        CType(Me.uds_ayuda, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ug_ayuda, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolS_Mantenimiento.SuspendLayout()
        CType(Me.txt_filtro, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.uce_filtro, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'uds_ayuda
        '
        Me.uds_ayuda.AllowDelete = False
        UltraDataColumn1.DataType = GetType(Boolean)
        Me.uds_ayuda.Band.Columns.AddRange(New Object() {UltraDataColumn1, UltraDataColumn2, UltraDataColumn3})
        '
        'ug_ayuda
        '
        Me.ug_ayuda.DataSource = Me.uds_ayuda
        Me.ug_ayuda.DisplayLayout.AutoFitStyle = Infragistics.Win.UltraWinGrid.AutoFitStyle.ExtendLastColumn
        UltraGridColumn1.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn1.Header.VisiblePosition = 0
        UltraGridColumn2.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn2.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn2.Header.VisiblePosition = 1
        UltraGridColumn3.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn3.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn3.Header.VisiblePosition = 2
        UltraGridBand1.Columns.AddRange(New Object() {UltraGridColumn1, UltraGridColumn2, UltraGridColumn3})
        Me.ug_ayuda.DisplayLayout.BandsSerializer.Add(UltraGridBand1)
        Me.ug_ayuda.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.[False]
        Me.ug_ayuda.DisplayLayout.MaxColScrollRegions = 1
        Me.ug_ayuda.DisplayLayout.MaxRowScrollRegions = 1
        Me.ug_ayuda.DisplayLayout.Override.AllowColSizing = Infragistics.Win.UltraWinGrid.AllowColSizing.None
        Me.ug_ayuda.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Appearance1.BackColor = System.Drawing.Color.WhiteSmoke
        Appearance1.BackColor2 = System.Drawing.Color.WhiteSmoke
        Me.ug_ayuda.DisplayLayout.Override.RowAlternateAppearance = Appearance1
        Me.ug_ayuda.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.ug_ayuda.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.ug_ayuda.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ug_ayuda.Location = New System.Drawing.Point(12, 81)
        Me.ug_ayuda.Name = "ug_ayuda"
        Me.ug_ayuda.Size = New System.Drawing.Size(494, 341)
        Me.ug_ayuda.TabIndex = 0
        Me.ug_ayuda.Text = "UltraGrid1"
        '
        'ToolS_Mantenimiento
        '
        Me.ToolS_Mantenimiento.BackColor = System.Drawing.Color.White
        Me.ToolS_Mantenimiento.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Tool_Aceptar, Me.ToolStripSeparator1, Me.Tool_Salir, Me.ToolStripSeparator2})
        Me.ToolS_Mantenimiento.Location = New System.Drawing.Point(0, 0)
        Me.ToolS_Mantenimiento.Name = "ToolS_Mantenimiento"
        Me.ToolS_Mantenimiento.Size = New System.Drawing.Size(518, 25)
        Me.ToolS_Mantenimiento.TabIndex = 9
        Me.ToolS_Mantenimiento.Text = "ToolStrip1"
        '
        'Tool_Aceptar
        '
        Me.Tool_Aceptar.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Tool_Aceptar.Image = Global.Contabilidad.My.Resources.Resources._16__Ok_
        Me.Tool_Aceptar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Tool_Aceptar.Name = "Tool_Aceptar"
        Me.Tool_Aceptar.Size = New System.Drawing.Size(72, 22)
        Me.Tool_Aceptar.Text = "&Aceptar"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'Tool_Salir
        '
        Me.Tool_Salir.Image = Global.Contabilidad.My.Resources.Resources._28
        Me.Tool_Salir.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Tool_Salir.Name = "Tool_Salir"
        Me.Tool_Salir.Size = New System.Drawing.Size(47, 22)
        Me.Tool_Salir.Text = "Salir"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'txt_filtro
        '
        Me.txt_filtro.Location = New System.Drawing.Point(115, 54)
        Me.txt_filtro.Name = "txt_filtro"
        Me.txt_filtro.Size = New System.Drawing.Size(391, 21)
        Me.txt_filtro.TabIndex = 10
        '
        'uce_filtro
        '
        Me.uce_filtro.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        ValueListItem1.DataValue = "Codigo"
        ValueListItem1.DisplayText = "Codigo"
        ValueListItem2.DataValue = "Descripcion"
        ValueListItem2.DisplayText = "Descripcion"
        Me.uce_filtro.Items.AddRange(New Infragistics.Win.ValueListItem() {ValueListItem1, ValueListItem2})
        Me.uce_filtro.Location = New System.Drawing.Point(12, 54)
        Me.uce_filtro.Name = "uce_filtro"
        Me.uce_filtro.Size = New System.Drawing.Size(103, 21)
        Me.uce_filtro.TabIndex = 11
        '
        'uchk_Todos
        '
        Appearance3.ForeColor = System.Drawing.Color.Navy
        Me.uchk_Todos.Appearance = Appearance3
        Me.uchk_Todos.BackColor = System.Drawing.Color.Transparent
        Me.uchk_Todos.BackColorInternal = System.Drawing.Color.Transparent
        Me.uchk_Todos.Location = New System.Drawing.Point(12, 28)
        Me.uchk_Todos.Name = "uchk_Todos"
        Me.uchk_Todos.Size = New System.Drawing.Size(103, 20)
        Me.uchk_Todos.TabIndex = 12
        Me.uchk_Todos.Text = "Todos"
        '
        'PL_AY_Lista_Ayuda
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(518, 434)
        Me.Controls.Add(Me.uchk_Todos)
        Me.Controls.Add(Me.uce_filtro)
        Me.Controls.Add(Me.txt_filtro)
        Me.Controls.Add(Me.ToolS_Mantenimiento)
        Me.Controls.Add(Me.ug_ayuda)
        Me.Name = "PL_AY_Lista_Ayuda"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Lista"
        CType(Me.uds_ayuda, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ug_ayuda, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolS_Mantenimiento.ResumeLayout(False)
        Me.ToolS_Mantenimiento.PerformLayout()
        CType(Me.txt_filtro, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.uce_filtro, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents uds_ayuda As Infragistics.Win.UltraWinDataSource.UltraDataSource
    Friend WithEvents ug_ayuda As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents ToolS_Mantenimiento As System.Windows.Forms.ToolStrip
    Friend WithEvents Tool_Aceptar As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents Tool_Salir As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents txt_filtro As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents uce_filtro As Infragistics.Win.UltraWinEditors.UltraComboEditor
    Friend WithEvents uchk_Todos As Infragistics.Win.UltraWinEditors.UltraCheckEditor
End Class
