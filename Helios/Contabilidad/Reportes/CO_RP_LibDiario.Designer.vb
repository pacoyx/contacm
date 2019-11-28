<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CO_RP_LibDiario
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
        Dim Appearance7 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance1 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridBand1 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1)
        Dim UltraGridColumn1 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Sel")
        Dim UltraGridColumn2 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Codigo")
        Dim UltraGridColumn3 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Subdiario")
        Dim UltraDataColumn1 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Sel")
        Dim UltraDataColumn2 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Codigo")
        Dim UltraDataColumn3 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Subdiario")
        Dim Appearance5 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance4 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance6 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Me.ugb_Datos = New Infragistics.Win.Misc.UltraGroupBox()
        Me.UltraLabel4 = New Infragistics.Win.Misc.UltraLabel()
        Me.uce_Mes = New Infragistics.Win.UltraWinEditors.UltraComboEditor()
        Me.UltraLabel1 = New Infragistics.Win.Misc.UltraLabel()
        Me.txt_Ayo = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.ug_subdiarios = New Infragistics.Win.UltraWinGrid.UltraGrid()
        Me.uds_subdiarios = New Infragistics.Win.UltraWinDataSource.UltraDataSource(Me.components)
        Me.uchk_todos = New Infragistics.Win.UltraWinEditors.UltraCheckEditor()
        Me.ugb_Opciones = New Infragistics.Win.Misc.UltraGroupBox()
        Me.uchk_Resumen = New Infragistics.Win.UltraWinEditors.UltraCheckEditor()
        Me.uchk_SinFecha = New Infragistics.Win.UltraWinEditors.UltraCheckEditor()
        Me.uchk_Asientos_Descu = New Infragistics.Win.UltraWinEditors.UltraCheckEditor()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.Tool_imprimir = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.Tool_salir = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        CType(Me.ugb_Datos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ugb_Datos.SuspendLayout()
        CType(Me.uce_Mes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_Ayo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ug_subdiarios, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.uds_subdiarios, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ugb_Opciones, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ugb_Opciones.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ugb_Datos
        '
        Me.ugb_Datos.CaptionAlignment = Infragistics.Win.Misc.GroupBoxCaptionAlignment.Center
        Me.ugb_Datos.Controls.Add(Me.UltraLabel4)
        Me.ugb_Datos.Controls.Add(Me.uce_Mes)
        Me.ugb_Datos.Controls.Add(Me.UltraLabel1)
        Me.ugb_Datos.Controls.Add(Me.txt_Ayo)
        Me.ugb_Datos.HeaderPosition = Infragistics.Win.Misc.GroupBoxHeaderPosition.TopOutsideBorder
        Me.ugb_Datos.Location = New System.Drawing.Point(5, 37)
        Me.ugb_Datos.Name = "ugb_Datos"
        Me.ugb_Datos.Size = New System.Drawing.Size(198, 97)
        Me.ugb_Datos.TabIndex = 5
        Me.ugb_Datos.Text = "Periodo"
        '
        'UltraLabel4
        '
        Appearance7.BackColor = System.Drawing.Color.Transparent
        Appearance7.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel4.Appearance = Appearance7
        Me.UltraLabel4.AutoSize = True
        Me.UltraLabel4.Location = New System.Drawing.Point(20, 59)
        Me.UltraLabel4.Name = "UltraLabel4"
        Me.UltraLabel4.Size = New System.Drawing.Size(32, 14)
        Me.UltraLabel4.TabIndex = 195
        Me.UltraLabel4.Text = "Mes :"
        '
        'uce_Mes
        '
        Me.uce_Mes.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.uce_Mes.Location = New System.Drawing.Point(58, 55)
        Me.uce_Mes.MaxDropDownItems = 12
        Me.uce_Mes.Name = "uce_Mes"
        Me.uce_Mes.Size = New System.Drawing.Size(123, 21)
        Me.uce_Mes.TabIndex = 1
        '
        'UltraLabel1
        '
        Appearance1.BackColor = System.Drawing.Color.Transparent
        Appearance1.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel1.Appearance = Appearance1
        Me.UltraLabel1.AutoSize = True
        Me.UltraLabel1.Location = New System.Drawing.Point(20, 32)
        Me.UltraLabel1.Name = "UltraLabel1"
        Me.UltraLabel1.Size = New System.Drawing.Size(30, 14)
        Me.UltraLabel1.TabIndex = 1
        Me.UltraLabel1.Text = "Año :"
        '
        'txt_Ayo
        '
        Me.txt_Ayo.Location = New System.Drawing.Point(58, 28)
        Me.txt_Ayo.Name = "txt_Ayo"
        Me.txt_Ayo.Size = New System.Drawing.Size(62, 21)
        Me.txt_Ayo.TabIndex = 0
        '
        'ug_subdiarios
        '
        Me.ug_subdiarios.DataSource = Me.uds_subdiarios
        Me.ug_subdiarios.DisplayLayout.AutoFitStyle = Infragistics.Win.UltraWinGrid.AutoFitStyle.ExtendLastColumn
        UltraGridColumn1.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn1.Header.VisiblePosition = 0
        UltraGridColumn2.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn2.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn2.Header.VisiblePosition = 1
        UltraGridColumn2.Width = 47
        UltraGridColumn3.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn3.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn3.Header.VisiblePosition = 2
        UltraGridBand1.Columns.AddRange(New Object() {UltraGridColumn1, UltraGridColumn2, UltraGridColumn3})
        Me.ug_subdiarios.DisplayLayout.BandsSerializer.Add(UltraGridBand1)
        Me.ug_subdiarios.DisplayLayout.MaxColScrollRegions = 1
        Me.ug_subdiarios.DisplayLayout.MaxRowScrollRegions = 1
        Me.ug_subdiarios.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.ug_subdiarios.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.ug_subdiarios.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ug_subdiarios.Location = New System.Drawing.Point(5, 173)
        Me.ug_subdiarios.Name = "ug_subdiarios"
        Me.ug_subdiarios.Size = New System.Drawing.Size(395, 206)
        Me.ug_subdiarios.TabIndex = 9
        '
        'uds_subdiarios
        '
        Me.uds_subdiarios.AllowDelete = False
        UltraDataColumn1.DataType = GetType(Boolean)
        Me.uds_subdiarios.Band.Columns.AddRange(New Object() {UltraDataColumn1, UltraDataColumn2, UltraDataColumn3})
        '
        'uchk_todos
        '
        Me.uchk_todos.Checked = True
        Me.uchk_todos.CheckState = System.Windows.Forms.CheckState.Checked
        Me.uchk_todos.Location = New System.Drawing.Point(5, 147)
        Me.uchk_todos.Name = "uchk_todos"
        Me.uchk_todos.Size = New System.Drawing.Size(120, 20)
        Me.uchk_todos.TabIndex = 10
        Me.uchk_todos.Text = "Todos"
        '
        'ugb_Opciones
        '
        Me.ugb_Opciones.CaptionAlignment = Infragistics.Win.Misc.GroupBoxCaptionAlignment.Center
        Me.ugb_Opciones.Controls.Add(Me.uchk_Resumen)
        Me.ugb_Opciones.Controls.Add(Me.uchk_SinFecha)
        Me.ugb_Opciones.Controls.Add(Me.uchk_Asientos_Descu)
        Me.ugb_Opciones.HeaderPosition = Infragistics.Win.Misc.GroupBoxHeaderPosition.TopOutsideBorder
        Me.ugb_Opciones.Location = New System.Drawing.Point(209, 37)
        Me.ugb_Opciones.Name = "ugb_Opciones"
        Me.ugb_Opciones.Size = New System.Drawing.Size(191, 97)
        Me.ugb_Opciones.TabIndex = 11
        Me.ugb_Opciones.Text = "Opciones"
        '
        'uchk_Resumen
        '
        Appearance5.ForeColor = System.Drawing.Color.Navy
        Me.uchk_Resumen.Appearance = Appearance5
        Me.uchk_Resumen.BackColor = System.Drawing.Color.Transparent
        Me.uchk_Resumen.BackColorInternal = System.Drawing.Color.Transparent
        Me.uchk_Resumen.Location = New System.Drawing.Point(15, 71)
        Me.uchk_Resumen.Name = "uchk_Resumen"
        Me.uchk_Resumen.Size = New System.Drawing.Size(165, 20)
        Me.uchk_Resumen.TabIndex = 1
        Me.uchk_Resumen.Text = "Resumen"
        '
        'uchk_SinFecha
        '
        Appearance4.ForeColor = System.Drawing.Color.Navy
        Me.uchk_SinFecha.Appearance = Appearance4
        Me.uchk_SinFecha.BackColor = System.Drawing.Color.Transparent
        Me.uchk_SinFecha.BackColorInternal = System.Drawing.Color.Transparent
        Me.uchk_SinFecha.Location = New System.Drawing.Point(15, 53)
        Me.uchk_SinFecha.Name = "uchk_SinFecha"
        Me.uchk_SinFecha.Size = New System.Drawing.Size(165, 20)
        Me.uchk_SinFecha.TabIndex = 0
        Me.uchk_SinFecha.Text = "Sin Fecha de Impresion"
        '
        'uchk_Asientos_Descu
        '
        Appearance6.ForeColor = System.Drawing.Color.Navy
        Me.uchk_Asientos_Descu.Appearance = Appearance6
        Me.uchk_Asientos_Descu.BackColor = System.Drawing.Color.Transparent
        Me.uchk_Asientos_Descu.BackColorInternal = System.Drawing.Color.Transparent
        Me.uchk_Asientos_Descu.Location = New System.Drawing.Point(15, 32)
        Me.uchk_Asientos_Descu.Name = "uchk_Asientos_Descu"
        Me.uchk_Asientos_Descu.Size = New System.Drawing.Size(165, 20)
        Me.uchk_Asientos_Descu.TabIndex = 0
        Me.uchk_Asientos_Descu.Text = "Asientos Descuadrados"
        '
        'ToolStrip1
        '
        Me.ToolStrip1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Tool_imprimir, Me.ToolStripSeparator2, Me.Tool_salir, Me.ToolStripSeparator1})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(409, 25)
        Me.ToolStrip1.TabIndex = 12
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
        'CO_RP_LibDiario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(409, 386)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.ugb_Opciones)
        Me.Controls.Add(Me.uchk_todos)
        Me.Controls.Add(Me.ug_subdiarios)
        Me.Controls.Add(Me.ugb_Datos)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "CO_RP_LibDiario"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Libro Diario"
        CType(Me.ugb_Datos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ugb_Datos.ResumeLayout(False)
        Me.ugb_Datos.PerformLayout()
        CType(Me.uce_Mes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_Ayo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ug_subdiarios, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.uds_subdiarios, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ugb_Opciones, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ugb_Opciones.ResumeLayout(False)
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ugb_Datos As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents UltraLabel4 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents uce_Mes As Infragistics.Win.UltraWinEditors.UltraComboEditor
    Friend WithEvents UltraLabel1 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents txt_Ayo As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents ug_subdiarios As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents uds_subdiarios As Infragistics.Win.UltraWinDataSource.UltraDataSource
    Friend WithEvents uchk_todos As Infragistics.Win.UltraWinEditors.UltraCheckEditor
    Friend WithEvents ugb_Opciones As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents uchk_Asientos_Descu As Infragistics.Win.UltraWinEditors.UltraCheckEditor
    Friend WithEvents uchk_SinFecha As Infragistics.Win.UltraWinEditors.UltraCheckEditor
    Friend WithEvents uchk_Resumen As Infragistics.Win.UltraWinEditors.UltraCheckEditor
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents Tool_imprimir As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents Tool_salir As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
End Class
