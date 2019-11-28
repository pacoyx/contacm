<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CO_RP_Balance_Gral
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
        Dim Appearance8 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim ValueListItem1 As Infragistics.Win.ValueListItem = New Infragistics.Win.ValueListItem()
        Dim ValueListItem2 As Infragistics.Win.ValueListItem = New Infragistics.Win.ValueListItem()
        Dim Appearance10 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance11 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance2 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance1 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Me.ugb_formato = New Infragistics.Win.Misc.UltraGroupBox()
        Me.uos_Formato = New Infragistics.Win.UltraWinEditors.UltraOptionSet()
        Me.ugb_Datos = New Infragistics.Win.Misc.UltraGroupBox()
        Me.UltraLabel4 = New Infragistics.Win.Misc.UltraLabel()
        Me.uce_Mes = New Infragistics.Win.UltraWinEditors.UltraComboEditor()
        Me.UltraLabel1 = New Infragistics.Win.Misc.UltraLabel()
        Me.txt_Ayo = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.pb1 = New System.Windows.Forms.ProgressBar()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.Tool_imprimir = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.Tool_exportar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.Tool_salir = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.UltraGroupBox1 = New Infragistics.Win.Misc.UltraGroupBox()
        Me.uchk_Detalle = New Infragistics.Win.UltraWinEditors.UltraCheckEditor()
        Me.uchk_Cierre = New Infragistics.Win.UltraWinEditors.UltraCheckEditor()
        CType(Me.ugb_formato, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ugb_formato.SuspendLayout()
        CType(Me.uos_Formato, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ugb_Datos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ugb_Datos.SuspendLayout()
        CType(Me.uce_Mes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_Ayo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip1.SuspendLayout()
        CType(Me.UltraGroupBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraGroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ugb_formato
        '
        Me.ugb_formato.CaptionAlignment = Infragistics.Win.Misc.GroupBoxCaptionAlignment.Center
        Me.ugb_formato.Controls.Add(Me.uos_Formato)
        Me.ugb_formato.HeaderPosition = Infragistics.Win.Misc.GroupBoxHeaderPosition.TopOutsideBorder
        Me.ugb_formato.Location = New System.Drawing.Point(211, 37)
        Me.ugb_formato.Name = "ugb_formato"
        Me.ugb_formato.Size = New System.Drawing.Size(102, 87)
        Me.ugb_formato.TabIndex = 15
        Me.ugb_formato.Text = "Formato"
        '
        'uos_Formato
        '
        Appearance8.ForeColor = System.Drawing.Color.Navy
        Me.uos_Formato.Appearance = Appearance8
        Me.uos_Formato.BackColor = System.Drawing.Color.Transparent
        Me.uos_Formato.BackColorInternal = System.Drawing.Color.Transparent
        Me.uos_Formato.BorderStyle = Infragistics.Win.UIElementBorderStyle.None
        Me.uos_Formato.CheckedIndex = 1
        ValueListItem1.DataValue = CType(1, Short)
        ValueListItem1.DisplayText = "Mensual"
        ValueListItem2.DataValue = CType(2, Short)
        ValueListItem2.DisplayText = "Acumulado"
        Me.uos_Formato.Items.AddRange(New Infragistics.Win.ValueListItem() {ValueListItem1, ValueListItem2})
        Me.uos_Formato.ItemSpacingHorizontal = 5
        Me.uos_Formato.ItemSpacingVertical = 5
        Me.uos_Formato.Location = New System.Drawing.Point(17, 28)
        Me.uos_Formato.Name = "uos_Formato"
        Me.uos_Formato.Size = New System.Drawing.Size(79, 48)
        Me.uos_Formato.TabIndex = 0
        Me.uos_Formato.Text = "Acumulado"
        '
        'ugb_Datos
        '
        Me.ugb_Datos.CaptionAlignment = Infragistics.Win.Misc.GroupBoxCaptionAlignment.Center
        Me.ugb_Datos.Controls.Add(Me.UltraLabel4)
        Me.ugb_Datos.Controls.Add(Me.uce_Mes)
        Me.ugb_Datos.Controls.Add(Me.UltraLabel1)
        Me.ugb_Datos.Controls.Add(Me.txt_Ayo)
        Me.ugb_Datos.HeaderPosition = Infragistics.Win.Misc.GroupBoxHeaderPosition.TopOutsideBorder
        Me.ugb_Datos.Location = New System.Drawing.Point(12, 37)
        Me.ugb_Datos.Name = "ugb_Datos"
        Me.ugb_Datos.Size = New System.Drawing.Size(198, 87)
        Me.ugb_Datos.TabIndex = 14
        Me.ugb_Datos.Text = "Periodo"
        '
        'UltraLabel4
        '
        Appearance10.BackColor = System.Drawing.Color.Transparent
        Appearance10.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel4.Appearance = Appearance10
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
        Me.uce_Mes.Name = "uce_Mes"
        Me.uce_Mes.Size = New System.Drawing.Size(123, 21)
        Me.uce_Mes.TabIndex = 1
        '
        'UltraLabel1
        '
        Appearance11.BackColor = System.Drawing.Color.Transparent
        Appearance11.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel1.Appearance = Appearance11
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
        'pb1
        '
        Me.pb1.ForeColor = System.Drawing.Color.Navy
        Me.pb1.Location = New System.Drawing.Point(12, 130)
        Me.pb1.Name = "pb1"
        Me.pb1.Size = New System.Drawing.Size(476, 17)
        Me.pb1.Style = System.Windows.Forms.ProgressBarStyle.Continuous
        Me.pb1.TabIndex = 18
        '
        'ToolStrip1
        '
        Me.ToolStrip1.BackColor = System.Drawing.Color.Gainsboro
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Tool_imprimir, Me.ToolStripSeparator2, Me.Tool_exportar, Me.ToolStripSeparator3, Me.Tool_salir, Me.ToolStripSeparator1})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(496, 25)
        Me.ToolStrip1.TabIndex = 202
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
        'UltraGroupBox1
        '
        Me.UltraGroupBox1.CaptionAlignment = Infragistics.Win.Misc.GroupBoxCaptionAlignment.Center
        Me.UltraGroupBox1.Controls.Add(Me.uchk_Cierre)
        Me.UltraGroupBox1.Controls.Add(Me.uchk_Detalle)
        Me.UltraGroupBox1.HeaderPosition = Infragistics.Win.Misc.GroupBoxHeaderPosition.TopOutsideBorder
        Me.UltraGroupBox1.Location = New System.Drawing.Point(314, 37)
        Me.UltraGroupBox1.Name = "UltraGroupBox1"
        Me.UltraGroupBox1.Size = New System.Drawing.Size(174, 87)
        Me.UltraGroupBox1.TabIndex = 203
        Me.UltraGroupBox1.Text = "Opciones"
        '
        'uchk_Detalle
        '
        Appearance2.ForeColor = System.Drawing.Color.Navy
        Me.uchk_Detalle.Appearance = Appearance2
        Me.uchk_Detalle.BackColor = System.Drawing.Color.Transparent
        Me.uchk_Detalle.BackColorInternal = System.Drawing.Color.Transparent
        Me.uchk_Detalle.Location = New System.Drawing.Point(10, 23)
        Me.uchk_Detalle.Name = "uchk_Detalle"
        Me.uchk_Detalle.Size = New System.Drawing.Size(151, 26)
        Me.uchk_Detalle.TabIndex = 0
        Me.uchk_Detalle.Text = "Exportacion con Detalles"
        '
        'uchk_Cierre
        '
        Appearance1.ForeColor = System.Drawing.Color.Navy
        Me.uchk_Cierre.Appearance = Appearance1
        Me.uchk_Cierre.BackColor = System.Drawing.Color.Transparent
        Me.uchk_Cierre.BackColorInternal = System.Drawing.Color.Transparent
        Me.uchk_Cierre.Location = New System.Drawing.Point(10, 49)
        Me.uchk_Cierre.Name = "uchk_Cierre"
        Me.uchk_Cierre.Size = New System.Drawing.Size(151, 27)
        Me.uchk_Cierre.TabIndex = 0
        Me.uchk_Cierre.Text = "Sin Asiento de Cierre"
        '
        'CO_RP_Balance_Gral
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(496, 153)
        Me.Controls.Add(Me.UltraGroupBox1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.pb1)
        Me.Controls.Add(Me.ugb_formato)
        Me.Controls.Add(Me.ugb_Datos)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "CO_RP_Balance_Gral"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Balance General"
        CType(Me.ugb_formato, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ugb_formato.ResumeLayout(False)
        CType(Me.uos_Formato, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ugb_Datos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ugb_Datos.ResumeLayout(False)
        Me.ugb_Datos.PerformLayout()
        CType(Me.uce_Mes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_Ayo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        CType(Me.UltraGroupBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraGroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ugb_formato As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents uos_Formato As Infragistics.Win.UltraWinEditors.UltraOptionSet
    Friend WithEvents ugb_Datos As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents UltraLabel4 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents uce_Mes As Infragistics.Win.UltraWinEditors.UltraComboEditor
    Friend WithEvents UltraLabel1 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents txt_Ayo As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents pb1 As System.Windows.Forms.ProgressBar
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents Tool_imprimir As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents Tool_salir As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents Tool_exportar As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents UltraGroupBox1 As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents uchk_Detalle As Infragistics.Win.UltraWinEditors.UltraCheckEditor
    Friend WithEvents uchk_Cierre As Infragistics.Win.UltraWinEditors.UltraCheckEditor
End Class
