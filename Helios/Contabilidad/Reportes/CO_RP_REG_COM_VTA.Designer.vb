<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CO_RP_REG_COM_VTA
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
        Dim Appearance4 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim ValueListItem1 As Infragistics.Win.ValueListItem = New Infragistics.Win.ValueListItem()
        Dim ValueListItem2 As Infragistics.Win.ValueListItem = New Infragistics.Win.ValueListItem()
        Dim ValueListItem5 As Infragistics.Win.ValueListItem = New Infragistics.Win.ValueListItem()
        Dim Appearance5 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim ValueListItem3 As Infragistics.Win.ValueListItem = New Infragistics.Win.ValueListItem()
        Dim ValueListItem4 As Infragistics.Win.ValueListItem = New Infragistics.Win.ValueListItem()
        Dim ValueListItem6 As Infragistics.Win.ValueListItem = New Infragistics.Win.ValueListItem()
        Me.txt_Ayo = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.ugb_Datos = New Infragistics.Win.Misc.UltraGroupBox()
        Me.UltraLabel4 = New Infragistics.Win.Misc.UltraLabel()
        Me.uce_Mes = New Infragistics.Win.UltraWinEditors.UltraComboEditor()
        Me.UltraLabel1 = New Infragistics.Win.Misc.UltraLabel()
        Me.uos_Tipo = New Infragistics.Win.UltraWinEditors.UltraOptionSet()
        Me.ugb_opciones = New Infragistics.Win.Misc.UltraGroupBox()
        Me.uos_opciones = New Infragistics.Win.UltraWinEditors.UltraOptionSet()
        Me.UltraGroupBox1 = New Infragistics.Win.Misc.UltraGroupBox()
        Me.ex_registro = New Infragistics.Win.UltraWinGrid.ExcelExport.UltraGridExcelExporter(Me.components)
        Me.ug_registro = New Infragistics.Win.UltraWinGrid.UltraGrid()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.Tool_imprimir = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.Tool_exportar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.Tool_salir = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        CType(Me.txt_Ayo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ugb_Datos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ugb_Datos.SuspendLayout()
        CType(Me.uce_Mes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.uos_Tipo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ugb_opciones, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ugb_opciones.SuspendLayout()
        CType(Me.uos_opciones, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UltraGroupBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraGroupBox1.SuspendLayout()
        CType(Me.ug_registro, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'txt_Ayo
        '
        Me.txt_Ayo.Location = New System.Drawing.Point(58, 28)
        Me.txt_Ayo.Name = "txt_Ayo"
        Me.txt_Ayo.Size = New System.Drawing.Size(62, 21)
        Me.txt_Ayo.TabIndex = 0
        '
        'ugb_Datos
        '
        Me.ugb_Datos.CaptionAlignment = Infragistics.Win.Misc.GroupBoxCaptionAlignment.Center
        Me.ugb_Datos.Controls.Add(Me.UltraLabel4)
        Me.ugb_Datos.Controls.Add(Me.uce_Mes)
        Me.ugb_Datos.Controls.Add(Me.UltraLabel1)
        Me.ugb_Datos.Controls.Add(Me.txt_Ayo)
        Me.ugb_Datos.HeaderPosition = Infragistics.Win.Misc.GroupBoxHeaderPosition.TopOutsideBorder
        Me.ugb_Datos.Location = New System.Drawing.Point(168, 37)
        Me.ugb_Datos.Name = "ugb_Datos"
        Me.ugb_Datos.Size = New System.Drawing.Size(221, 97)
        Me.ugb_Datos.TabIndex = 2
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
        'uos_Tipo
        '
        Appearance4.ForeColor = System.Drawing.Color.Navy
        Me.uos_Tipo.Appearance = Appearance4
        Me.uos_Tipo.BackColor = System.Drawing.Color.Transparent
        Me.uos_Tipo.BackColorInternal = System.Drawing.Color.Transparent
        Me.uos_Tipo.BorderStyle = Infragistics.Win.UIElementBorderStyle.None
        Me.uos_Tipo.CheckedIndex = 0
        ValueListItem1.DataValue = "C"
        ValueListItem1.DisplayText = "Registro de Compras"
        ValueListItem2.DataValue = "V"
        ValueListItem2.DisplayText = "Registro de Ventas"
        ValueListItem5.DataValue = "H"
        ValueListItem5.DisplayText = "Registro de Honorarios"
        Me.uos_Tipo.Items.AddRange(New Infragistics.Win.ValueListItem() {ValueListItem1, ValueListItem2, ValueListItem5})
        Me.uos_Tipo.ItemSpacingHorizontal = 10
        Me.uos_Tipo.ItemSpacingVertical = 5
        Me.uos_Tipo.Location = New System.Drawing.Point(13, 23)
        Me.uos_Tipo.Name = "uos_Tipo"
        Me.uos_Tipo.Size = New System.Drawing.Size(133, 69)
        Me.uos_Tipo.TabIndex = 2
        Me.uos_Tipo.Text = "Registro de Compras"
        '
        'ugb_opciones
        '
        Me.ugb_opciones.CaptionAlignment = Infragistics.Win.Misc.GroupBoxCaptionAlignment.Center
        Me.ugb_opciones.Controls.Add(Me.uos_opciones)
        Me.ugb_opciones.HeaderPosition = Infragistics.Win.Misc.GroupBoxHeaderPosition.TopOutsideBorder
        Me.ugb_opciones.Location = New System.Drawing.Point(5, 140)
        Me.ugb_opciones.Name = "ugb_opciones"
        Me.ugb_opciones.Size = New System.Drawing.Size(160, 98)
        Me.ugb_opciones.TabIndex = 3
        Me.ugb_opciones.Text = "Formatos"
        '
        'uos_opciones
        '
        Appearance5.ForeColor = System.Drawing.Color.Navy
        Me.uos_opciones.Appearance = Appearance5
        Me.uos_opciones.BackColor = System.Drawing.Color.Transparent
        Me.uos_opciones.BackColorInternal = System.Drawing.Color.Transparent
        Me.uos_opciones.BorderStyle = Infragistics.Win.UIElementBorderStyle.None
        Me.uos_opciones.CheckedIndex = 0
        ValueListItem3.DataValue = "S"
        ValueListItem3.DisplayText = "Formato Simple"
        ValueListItem4.DataValue = "SN"
        ValueListItem4.DisplayText = "Sunat ( Matricial )"
        ValueListItem6.DataValue = "SNC"
        ValueListItem6.DisplayText = "Sunat ( Carta Horizontal)"
        Me.uos_opciones.Items.AddRange(New Infragistics.Win.ValueListItem() {ValueListItem3, ValueListItem4, ValueListItem6})
        Me.uos_opciones.ItemSpacingHorizontal = 10
        Me.uos_opciones.ItemSpacingVertical = 5
        Me.uos_opciones.Location = New System.Drawing.Point(6, 22)
        Me.uos_opciones.Name = "uos_opciones"
        Me.uos_opciones.Size = New System.Drawing.Size(148, 70)
        Me.uos_opciones.TabIndex = 0
        Me.uos_opciones.Text = "Formato Simple"
        '
        'UltraGroupBox1
        '
        Me.UltraGroupBox1.CaptionAlignment = Infragistics.Win.Misc.GroupBoxCaptionAlignment.Center
        Me.UltraGroupBox1.Controls.Add(Me.uos_Tipo)
        Me.UltraGroupBox1.HeaderPosition = Infragistics.Win.Misc.GroupBoxHeaderPosition.TopOutsideBorder
        Me.UltraGroupBox1.Location = New System.Drawing.Point(5, 36)
        Me.UltraGroupBox1.Name = "UltraGroupBox1"
        Me.UltraGroupBox1.Size = New System.Drawing.Size(161, 98)
        Me.UltraGroupBox1.TabIndex = 4
        Me.UltraGroupBox1.Text = "Registro"
        '
        'ug_registro
        '
        Me.ug_registro.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy
        Me.ug_registro.Location = New System.Drawing.Point(6, 270)
        Me.ug_registro.Name = "ug_registro"
        Me.ug_registro.Size = New System.Drawing.Size(145, 131)
        Me.ug_registro.TabIndex = 6
        Me.ug_registro.Text = "UltraGrid1"
        Me.ug_registro.Visible = False
        '
        'ToolStrip1
        '
        Me.ToolStrip1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Tool_imprimir, Me.ToolStripSeparator2, Me.Tool_exportar, Me.ToolStripSeparator3, Me.Tool_salir, Me.ToolStripSeparator1})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(404, 25)
        Me.ToolStrip1.TabIndex = 7
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
        'Tool_exportar
        '
        Me.Tool_exportar.Image = Global.Contabilidad.My.Resources.Resources._16__Doc_excel_
        Me.Tool_exportar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Tool_exportar.Name = "Tool_exportar"
        Me.Tool_exportar.Size = New System.Drawing.Size(70, 22)
        Me.Tool_exportar.Text = "Exportar"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 25)
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
        'CO_RP_REG_COM_VTA
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(404, 244)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.ug_registro)
        Me.Controls.Add(Me.UltraGroupBox1)
        Me.Controls.Add(Me.ugb_opciones)
        Me.Controls.Add(Me.ugb_Datos)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "CO_RP_REG_COM_VTA"
        Me.Text = "Registro de Compra / Venta / Honorario"
        CType(Me.txt_Ayo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ugb_Datos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ugb_Datos.ResumeLayout(False)
        Me.ugb_Datos.PerformLayout()
        CType(Me.uce_Mes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.uos_Tipo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ugb_opciones, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ugb_opciones.ResumeLayout(False)
        CType(Me.uos_opciones, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UltraGroupBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraGroupBox1.ResumeLayout(False)
        CType(Me.ug_registro, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txt_Ayo As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents ugb_Datos As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents UltraLabel1 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel4 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents uce_Mes As Infragistics.Win.UltraWinEditors.UltraComboEditor
    Friend WithEvents uos_Tipo As Infragistics.Win.UltraWinEditors.UltraOptionSet
    Friend WithEvents ugb_opciones As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents uos_opciones As Infragistics.Win.UltraWinEditors.UltraOptionSet
    Friend WithEvents UltraGroupBox1 As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents ex_registro As Infragistics.Win.UltraWinGrid.ExcelExport.UltraGridExcelExporter
    Friend WithEvents ug_registro As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents Tool_imprimir As System.Windows.Forms.ToolStripButton
    Friend WithEvents Tool_exportar As System.Windows.Forms.ToolStripButton
    Friend WithEvents Tool_salir As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
End Class
