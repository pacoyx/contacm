<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PL_PR_Lista_Personal
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
        Dim UltraDataColumn2 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("PE_ID")
        Dim UltraDataColumn3 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("PE_CODIGO")
        Dim UltraDataColumn4 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("PE_APE_PAT")
        Dim UltraDataColumn5 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("PE_APE_MAT")
        Dim UltraDataColumn6 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("NOMBRES")
        Dim UltraGridBand1 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1)
        Dim UltraGridColumn1 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Sel")
        Dim UltraGridColumn2 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("PE_ID")
        Dim UltraGridColumn3 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("PE_CODIGO")
        Dim UltraGridColumn4 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("PE_APE_PAT")
        Dim UltraGridColumn5 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("PE_APE_MAT")
        Dim UltraGridColumn6 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NOMBRES")
        Dim Appearance4 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance1 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim ValueListItem1 As Infragistics.Win.ValueListItem = New Infragistics.Win.ValueListItem()
        Dim ValueListItem2 As Infragistics.Win.ValueListItem = New Infragistics.Win.ValueListItem()
        Dim ValueListItem3 As Infragistics.Win.ValueListItem = New Infragistics.Win.ValueListItem()
        Dim Appearance2 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance3 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Me.uds_Listado_Personal = New Infragistics.Win.UltraWinDataSource.UltraDataSource(Me.components)
        Me.ug_Listado_Personal = New Infragistics.Win.UltraWinGrid.UltraGrid()
        Me.uos_tipos = New Infragistics.Win.UltraWinEditors.UltraOptionSet()
        Me.uchk_Cesados = New Infragistics.Win.UltraWinEditors.UltraCheckEditor()
        Me.ToolS_Mantenimiento = New System.Windows.Forms.ToolStrip()
        Me.Tool_Aceptar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.Tool_Salir = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.UltraGroupBox1 = New Infragistics.Win.Misc.UltraGroupBox()
        Me.uchk_Todos = New Infragistics.Win.UltraWinEditors.UltraCheckEditor()
        CType(Me.uds_Listado_Personal, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ug_Listado_Personal, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.uos_tipos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolS_Mantenimiento.SuspendLayout()
        CType(Me.UltraGroupBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraGroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'uds_Listado_Personal
        '
        Me.uds_Listado_Personal.AllowDelete = False
        UltraDataColumn1.DataType = GetType(Boolean)
        UltraDataColumn2.DataType = GetType(Integer)
        Me.uds_Listado_Personal.Band.Columns.AddRange(New Object() {UltraDataColumn1, UltraDataColumn2, UltraDataColumn3, UltraDataColumn4, UltraDataColumn5, UltraDataColumn6})
        '
        'ug_Listado_Personal
        '
        Me.ug_Listado_Personal.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ug_Listado_Personal.DataSource = Me.uds_Listado_Personal
        Me.ug_Listado_Personal.DisplayLayout.AutoFitStyle = Infragistics.Win.UltraWinGrid.AutoFitStyle.ExtendLastColumn
        UltraGridColumn1.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn1.Header.VisiblePosition = 0
        UltraGridColumn2.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn2.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn2.Header.VisiblePosition = 1
        UltraGridColumn2.Hidden = True
        UltraGridColumn3.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn3.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn3.Header.Caption = "Codigo"
        UltraGridColumn3.Header.VisiblePosition = 2
        UltraGridColumn3.Width = 52
        UltraGridColumn4.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn4.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn4.Header.Caption = "Paterno"
        UltraGridColumn4.Header.VisiblePosition = 3
        UltraGridColumn4.Width = 196
        UltraGridColumn5.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn5.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn5.Header.Caption = "Materno"
        UltraGridColumn5.Header.VisiblePosition = 4
        UltraGridColumn5.Width = 187
        UltraGridColumn6.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn6.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn6.Header.Caption = "Nombres"
        UltraGridColumn6.Header.VisiblePosition = 5
        UltraGridBand1.Columns.AddRange(New Object() {UltraGridColumn1, UltraGridColumn2, UltraGridColumn3, UltraGridColumn4, UltraGridColumn5, UltraGridColumn6})
        Me.ug_Listado_Personal.DisplayLayout.BandsSerializer.Add(UltraGridBand1)
        Me.ug_Listado_Personal.DisplayLayout.MaxColScrollRegions = 1
        Me.ug_Listado_Personal.DisplayLayout.MaxRowScrollRegions = 1
        Me.ug_Listado_Personal.DisplayLayout.Override.FilterUIType = Infragistics.Win.UltraWinGrid.FilterUIType.FilterRow
        Me.ug_Listado_Personal.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Appearance4.BackColor = System.Drawing.Color.WhiteSmoke
        Appearance4.BackColor2 = System.Drawing.Color.WhiteSmoke
        Me.ug_Listado_Personal.DisplayLayout.Override.RowAlternateAppearance = Appearance4
        Me.ug_Listado_Personal.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.ug_Listado_Personal.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.ug_Listado_Personal.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ug_Listado_Personal.Location = New System.Drawing.Point(12, 109)
        Me.ug_Listado_Personal.Name = "ug_Listado_Personal"
        Me.ug_Listado_Personal.Size = New System.Drawing.Size(696, 337)
        Me.ug_Listado_Personal.TabIndex = 0
        '
        'uos_tipos
        '
        Appearance1.ForeColor = System.Drawing.Color.Navy
        Me.uos_tipos.Appearance = Appearance1
        Me.uos_tipos.BackColor = System.Drawing.Color.Transparent
        Me.uos_tipos.BackColorInternal = System.Drawing.Color.Transparent
        Me.uos_tipos.BorderStyle = Infragistics.Win.UIElementBorderStyle.None
        Me.uos_tipos.CheckedIndex = 0
        ValueListItem1.DataValue = CType(0, Short)
        ValueListItem1.DisplayText = "Todos"
        ValueListItem2.DataValue = CType(1, Short)
        ValueListItem2.DisplayText = "Empleados"
        ValueListItem3.DataValue = CType(2, Short)
        ValueListItem3.DisplayText = "Por Horas"
        Me.uos_tipos.Items.AddRange(New Infragistics.Win.ValueListItem() {ValueListItem1, ValueListItem2, ValueListItem3})
        Me.uos_tipos.ItemSpacingHorizontal = 10
        Me.uos_tipos.Location = New System.Drawing.Point(16, 14)
        Me.uos_tipos.Name = "uos_tipos"
        Me.uos_tipos.Size = New System.Drawing.Size(249, 20)
        Me.uos_tipos.TabIndex = 1
        Me.uos_tipos.Text = "Todos"
        '
        'uchk_Cesados
        '
        Appearance2.ForeColor = System.Drawing.Color.Navy
        Me.uchk_Cesados.Appearance = Appearance2
        Me.uchk_Cesados.BackColor = System.Drawing.Color.Transparent
        Me.uchk_Cesados.BackColorInternal = System.Drawing.Color.Transparent
        Me.uchk_Cesados.Location = New System.Drawing.Point(587, 14)
        Me.uchk_Cesados.Name = "uchk_Cesados"
        Me.uchk_Cesados.Size = New System.Drawing.Size(103, 20)
        Me.uchk_Cesados.TabIndex = 2
        Me.uchk_Cesados.Text = "Incluir Cesados"
        '
        'ToolS_Mantenimiento
        '
        Me.ToolS_Mantenimiento.BackColor = System.Drawing.Color.White
        Me.ToolS_Mantenimiento.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Tool_Aceptar, Me.ToolStripSeparator1, Me.Tool_Salir, Me.ToolStripSeparator2})
        Me.ToolS_Mantenimiento.Location = New System.Drawing.Point(0, 0)
        Me.ToolS_Mantenimiento.Name = "ToolS_Mantenimiento"
        Me.ToolS_Mantenimiento.Size = New System.Drawing.Size(720, 25)
        Me.ToolS_Mantenimiento.TabIndex = 8
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
        'UltraGroupBox1
        '
        Me.UltraGroupBox1.Controls.Add(Me.uos_tipos)
        Me.UltraGroupBox1.Controls.Add(Me.uchk_Cesados)
        Me.UltraGroupBox1.Location = New System.Drawing.Point(12, 32)
        Me.UltraGroupBox1.Name = "UltraGroupBox1"
        Me.UltraGroupBox1.Size = New System.Drawing.Size(696, 45)
        Me.UltraGroupBox1.TabIndex = 9
        '
        'uchk_Todos
        '
        Appearance3.ForeColor = System.Drawing.Color.Navy
        Me.uchk_Todos.Appearance = Appearance3
        Me.uchk_Todos.BackColor = System.Drawing.Color.Transparent
        Me.uchk_Todos.BackColorInternal = System.Drawing.Color.Transparent
        Me.uchk_Todos.Location = New System.Drawing.Point(12, 83)
        Me.uchk_Todos.Name = "uchk_Todos"
        Me.uchk_Todos.Size = New System.Drawing.Size(103, 20)
        Me.uchk_Todos.TabIndex = 2
        Me.uchk_Todos.Text = "Todos"
        '
        'PL_PR_Lista_Personal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(720, 458)
        Me.Controls.Add(Me.UltraGroupBox1)
        Me.Controls.Add(Me.uchk_Todos)
        Me.Controls.Add(Me.ToolS_Mantenimiento)
        Me.Controls.Add(Me.ug_Listado_Personal)
        Me.Name = "PL_PR_Lista_Personal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Filtro de Personal"
        CType(Me.uds_Listado_Personal, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ug_Listado_Personal, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.uos_tipos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolS_Mantenimiento.ResumeLayout(False)
        Me.ToolS_Mantenimiento.PerformLayout()
        CType(Me.UltraGroupBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraGroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents uds_Listado_Personal As Infragistics.Win.UltraWinDataSource.UltraDataSource
    Friend WithEvents ug_Listado_Personal As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents uos_tipos As Infragistics.Win.UltraWinEditors.UltraOptionSet
    Friend WithEvents uchk_Cesados As Infragistics.Win.UltraWinEditors.UltraCheckEditor
    Friend WithEvents ToolS_Mantenimiento As System.Windows.Forms.ToolStrip
    Friend WithEvents Tool_Aceptar As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents Tool_Salir As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents UltraGroupBox1 As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents uchk_Todos As Infragistics.Win.UltraWinEditors.UltraCheckEditor
End Class
