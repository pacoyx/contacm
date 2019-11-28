<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CO_RE_IC_Diario01
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
        Dim Appearance2 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance1 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim ValueListItem6 As Infragistics.Win.ValueListItem = New Infragistics.Win.ValueListItem()
        Dim ValueListItem7 As Infragistics.Win.ValueListItem = New Infragistics.Win.ValueListItem()
        Dim ValueListItem1 As Infragistics.Win.ValueListItem = New Infragistics.Win.ValueListItem()
        Dim ValueListItem4 As Infragistics.Win.ValueListItem = New Infragistics.Win.ValueListItem()
        Dim ValueListItem5 As Infragistics.Win.ValueListItem = New Infragistics.Win.ValueListItem()
        Dim Appearance7 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ugb_Datos = New Infragistics.Win.Misc.UltraGroupBox()
        Me.UltraLabel4 = New Infragistics.Win.Misc.UltraLabel()
        Me.uce_Mes = New Infragistics.Win.UltraWinEditors.UltraComboEditor()
        Me.UltraLabel1 = New Infragistics.Win.Misc.UltraLabel()
        Me.txt_Ayo = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.UltraGroupBox1 = New Infragistics.Win.Misc.UltraGroupBox()
        Me.uos_opc = New Infragistics.Win.UltraWinEditors.UltraOptionSet()
        Me.UltraGroupBox2 = New Infragistics.Win.Misc.UltraGroupBox()
        Me.uop_tipo = New Infragistics.Win.UltraWinEditors.UltraOptionSet()
        Me.UltraLabel2 = New Infragistics.Win.Misc.UltraLabel()
        Me.uce_subdiario = New Infragistics.Win.UltraWinEditors.UltraComboEditor()
        Me.Tool_ok = New System.Windows.Forms.ToolStripButton()
        Me.Tool_salir = New System.Windows.Forms.ToolStripButton()
        Me.ToolStrip1.SuspendLayout()
        CType(Me.ugb_Datos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ugb_Datos.SuspendLayout()
        CType(Me.uce_Mes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_Ayo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UltraGroupBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraGroupBox1.SuspendLayout()
        CType(Me.uos_opc, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UltraGroupBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraGroupBox2.SuspendLayout()
        CType(Me.uop_tipo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.uce_subdiario, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ToolStrip1
        '
        Me.ToolStrip1.BackColor = System.Drawing.Color.Gainsboro
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Tool_ok, Me.ToolStripSeparator2, Me.Tool_salir, Me.ToolStripSeparator1})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(377, 25)
        Me.ToolStrip1.TabIndex = 13
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'ugb_Datos
        '
        Me.ugb_Datos.CaptionAlignment = Infragistics.Win.Misc.GroupBoxCaptionAlignment.Center
        Me.ugb_Datos.Controls.Add(Me.UltraLabel4)
        Me.ugb_Datos.Controls.Add(Me.uce_Mes)
        Me.ugb_Datos.Controls.Add(Me.UltraLabel1)
        Me.ugb_Datos.Controls.Add(Me.txt_Ayo)
        Me.ugb_Datos.Location = New System.Drawing.Point(12, 80)
        Me.ugb_Datos.Name = "ugb_Datos"
        Me.ugb_Datos.Size = New System.Drawing.Size(198, 97)
        Me.ugb_Datos.TabIndex = 14
        Me.ugb_Datos.Text = "Periodo"
        '
        'UltraLabel4
        '
        Appearance2.BackColor = System.Drawing.Color.Transparent
        Appearance2.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel4.Appearance = Appearance2
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
        'UltraGroupBox1
        '
        Me.UltraGroupBox1.CaptionAlignment = Infragistics.Win.Misc.GroupBoxCaptionAlignment.Center
        Me.UltraGroupBox1.Controls.Add(Me.uos_opc)
        Me.UltraGroupBox1.Location = New System.Drawing.Point(216, 80)
        Me.UltraGroupBox1.Name = "UltraGroupBox1"
        Me.UltraGroupBox1.Size = New System.Drawing.Size(142, 97)
        Me.UltraGroupBox1.TabIndex = 15
        Me.UltraGroupBox1.Text = "Opciones"
        '
        'uos_opc
        '
        Me.uos_opc.BorderStyle = Infragistics.Win.UIElementBorderStyle.None
        Me.uos_opc.CheckedIndex = 0
        ValueListItem6.DataValue = "M"
        ValueListItem6.DisplayText = "Mensual"
        ValueListItem7.DataValue = "A"
        ValueListItem7.DisplayText = "Acumulado"
        Me.uos_opc.Items.AddRange(New Infragistics.Win.ValueListItem() {ValueListItem6, ValueListItem7})
        Me.uos_opc.ItemSpacingVertical = 10
        Me.uos_opc.Location = New System.Drawing.Point(19, 19)
        Me.uos_opc.Name = "uos_opc"
        Me.uos_opc.Size = New System.Drawing.Size(99, 57)
        Me.uos_opc.TabIndex = 0
        Me.uos_opc.Text = "Mensual"
        '
        'UltraGroupBox2
        '
        Me.UltraGroupBox2.Controls.Add(Me.uop_tipo)
        Me.UltraGroupBox2.Location = New System.Drawing.Point(12, 36)
        Me.UltraGroupBox2.Name = "UltraGroupBox2"
        Me.UltraGroupBox2.Size = New System.Drawing.Size(346, 44)
        Me.UltraGroupBox2.TabIndex = 16
        '
        'uop_tipo
        '
        Me.uop_tipo.BorderStyle = Infragistics.Win.UIElementBorderStyle.None
        Me.uop_tipo.CheckedIndex = 0
        ValueListItem1.DataValue = "A"
        ValueListItem1.DisplayText = "Analitico"
        ValueListItem4.DataValue = "O"
        ValueListItem4.DisplayText = "Por Origen"
        ValueListItem5.DataValue = "R"
        ValueListItem5.DisplayText = "Resumen"
        Me.uop_tipo.Items.AddRange(New Infragistics.Win.ValueListItem() {ValueListItem1, ValueListItem4, ValueListItem5})
        Me.uop_tipo.ItemSpacingHorizontal = 10
        Me.uop_tipo.Location = New System.Drawing.Point(34, 13)
        Me.uop_tipo.Name = "uop_tipo"
        Me.uop_tipo.Size = New System.Drawing.Size(278, 18)
        Me.uop_tipo.TabIndex = 0
        Me.uop_tipo.Text = "Analitico"
        '
        'UltraLabel2
        '
        Appearance7.BackColor = System.Drawing.Color.Transparent
        Appearance7.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel2.Appearance = Appearance7
        Me.UltraLabel2.AutoSize = True
        Me.UltraLabel2.Location = New System.Drawing.Point(20, 189)
        Me.UltraLabel2.Name = "UltraLabel2"
        Me.UltraLabel2.Size = New System.Drawing.Size(44, 14)
        Me.UltraLabel2.TabIndex = 197
        Me.UltraLabel2.Text = "Origen :"
        '
        'uce_subdiario
        '
        Me.uce_subdiario.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.uce_subdiario.Location = New System.Drawing.Point(70, 185)
        Me.uce_subdiario.MaxDropDownItems = 12
        Me.uce_subdiario.Name = "uce_subdiario"
        Me.uce_subdiario.Size = New System.Drawing.Size(276, 21)
        Me.uce_subdiario.TabIndex = 196
        '
        'Tool_ok
        '
        Me.Tool_ok.Image = Global.Contabilidad.My.Resources.Resources._16__Ok_
        Me.Tool_ok.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Tool_ok.Name = "Tool_ok"
        Me.Tool_ok.Size = New System.Drawing.Size(42, 22)
        Me.Tool_ok.Text = "Ok"
        Me.Tool_ok.ToolTipText = "Imprimir"
        '
        'Tool_salir
        '
        Me.Tool_salir.Image = Global.Contabilidad.My.Resources.Resources._28
        Me.Tool_salir.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Tool_salir.Name = "Tool_salir"
        Me.Tool_salir.Size = New System.Drawing.Size(49, 22)
        Me.Tool_salir.Text = "Salir"
        '
        'CO_RE_IC_Diario01
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(377, 220)
        Me.Controls.Add(Me.UltraLabel2)
        Me.Controls.Add(Me.uce_subdiario)
        Me.Controls.Add(Me.UltraGroupBox2)
        Me.Controls.Add(Me.UltraGroupBox1)
        Me.Controls.Add(Me.ugb_Datos)
        Me.Controls.Add(Me.ToolStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "CO_RE_IC_Diario01"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Seleccion de Libro Diario"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        CType(Me.ugb_Datos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ugb_Datos.ResumeLayout(False)
        Me.ugb_Datos.PerformLayout()
        CType(Me.uce_Mes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_Ayo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UltraGroupBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraGroupBox1.ResumeLayout(False)
        CType(Me.uos_opc, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UltraGroupBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraGroupBox2.ResumeLayout(False)
        CType(Me.uop_tipo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.uce_subdiario, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents Tool_ok As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents Tool_salir As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ugb_Datos As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents UltraLabel4 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents uce_Mes As Infragistics.Win.UltraWinEditors.UltraComboEditor
    Friend WithEvents UltraLabel1 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents txt_Ayo As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents UltraGroupBox1 As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents uos_opc As Infragistics.Win.UltraWinEditors.UltraOptionSet
    Friend WithEvents UltraGroupBox2 As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents uop_tipo As Infragistics.Win.UltraWinEditors.UltraOptionSet
    Friend WithEvents UltraLabel2 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents uce_subdiario As Infragistics.Win.UltraWinEditors.UltraComboEditor
End Class
