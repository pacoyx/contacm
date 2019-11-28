<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CO_RP_Bal_Inv
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim ValueListItem2 As Infragistics.Win.ValueListItem = New Infragistics.Win.ValueListItem()
        Dim ValueListItem3 As Infragistics.Win.ValueListItem = New Infragistics.Win.ValueListItem()
        Dim ValueListItem4 As Infragistics.Win.ValueListItem = New Infragistics.Win.ValueListItem()
        Dim ValueListItem1 As Infragistics.Win.ValueListItem = New Infragistics.Win.ValueListItem()
        Dim ValueListItem5 As Infragistics.Win.ValueListItem = New Infragistics.Win.ValueListItem()
        Dim ValueListItem6 As Infragistics.Win.ValueListItem = New Infragistics.Win.ValueListItem()
        Dim ValueListItem7 As Infragistics.Win.ValueListItem = New Infragistics.Win.ValueListItem()
        Dim ValueListItem8 As Infragistics.Win.ValueListItem = New Infragistics.Win.ValueListItem()
        Dim ValueListItem15 As Infragistics.Win.ValueListItem = New Infragistics.Win.ValueListItem()
        Dim ValueListItem9 As Infragistics.Win.ValueListItem = New Infragistics.Win.ValueListItem()
        Dim ValueListItem10 As Infragistics.Win.ValueListItem = New Infragistics.Win.ValueListItem()
        Dim ValueListItem14 As Infragistics.Win.ValueListItem = New Infragistics.Win.ValueListItem()
        Dim ValueListItem11 As Infragistics.Win.ValueListItem = New Infragistics.Win.ValueListItem()
        Dim ValueListItem12 As Infragistics.Win.ValueListItem = New Infragistics.Win.ValueListItem()
        Dim ValueListItem13 As Infragistics.Win.ValueListItem = New Infragistics.Win.ValueListItem()
        Dim Appearance11 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Me.uos_Formato = New Infragistics.Win.UltraWinEditors.UltraOptionSet()
        Me.ugb_Datos = New Infragistics.Win.Misc.UltraGroupBox()
        Me.UltraButton1 = New Infragistics.Win.Misc.UltraButton()
        Me.txt_mes = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.btn_inv_per = New System.Windows.Forms.Button()
        Me.UltraLabel2 = New Infragistics.Win.Misc.UltraLabel()
        Me.txt_Ayo = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.ugb_formato = New Infragistics.Win.Misc.UltraGroupBox()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.Tool_imprimir = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.Tool_salir = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        CType(Me.uos_Formato, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ugb_Datos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ugb_Datos.SuspendLayout()
        CType(Me.txt_mes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_Ayo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ugb_formato, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ugb_formato.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'uos_Formato
        '
        Me.uos_Formato.BackColor = System.Drawing.Color.Transparent
        Me.uos_Formato.BackColorInternal = System.Drawing.Color.Transparent
        Me.uos_Formato.BorderStyle = Infragistics.Win.UIElementBorderStyle.None
        Me.uos_Formato.CheckedIndex = 0
        ValueListItem2.DataValue = "10"
        ValueListItem2.DisplayText = "10 - CAJA Y BANCOS"
        ValueListItem3.DataValue = "12"
        ValueListItem3.DisplayText = "12 - CLIENTES"
        ValueListItem4.DataValue = "14"
        ValueListItem4.DisplayText = "14 - CUENTAS POR COBRAR A ACCIONISTAS (O SOCIOS) Y PERSONAL"
        ValueListItem1.DataValue = "16"
        ValueListItem1.DisplayText = "16 - CUENTAS POR COBRAR DIVERSAS"
        ValueListItem5.DataValue = "19"
        ValueListItem5.DisplayText = "19 - PROVISIÓN PARA CUENTAS DE COBRANZA DUDOSA"
        ValueListItem6.DataValue = "20"
        ValueListItem6.DisplayText = "20 - MERCADERÍAS Y LA CUENTA 21 - PRODUCTOS TERMINADOS"
        ValueListItem7.DataValue = "31"
        ValueListItem7.DisplayText = "31 - VALORES"
        ValueListItem8.DataValue = "34"
        ValueListItem8.DisplayText = "34 - INTANGIBLES"
        ValueListItem15.DataValue = "40"
        ValueListItem15.DisplayText = "40 - TRIBUTOS POR PAGAR"
        ValueListItem9.DataValue = "41"
        ValueListItem9.DisplayText = "41 - REMUNERACIONES POR PAGAR"
        ValueListItem10.DataValue = "42"
        ValueListItem10.DisplayText = "42 - PROVEEDORES"
        ValueListItem14.DataValue = "43"
        ValueListItem14.DisplayText = "43 - PROVE. RELACIONADOS"
        ValueListItem11.DataValue = "46"
        ValueListItem11.DisplayText = "46 - CUENTAS POR PAGAR DIVERSAS"
        ValueListItem12.DataValue = "49"
        ValueListItem12.DisplayText = "49 - GANANCIAS DIFERIDAS"
        ValueListItem13.DataValue = "50"
        ValueListItem13.DisplayText = "50 - CAPITAL"
        Me.uos_Formato.Items.AddRange(New Infragistics.Win.ValueListItem() {ValueListItem2, ValueListItem3, ValueListItem4, ValueListItem1, ValueListItem5, ValueListItem6, ValueListItem7, ValueListItem8, ValueListItem15, ValueListItem9, ValueListItem10, ValueListItem14, ValueListItem11, ValueListItem12, ValueListItem13})
        Me.uos_Formato.ItemSpacingVertical = 3
        Me.uos_Formato.Location = New System.Drawing.Point(16, 25)
        Me.uos_Formato.Name = "uos_Formato"
        Me.uos_Formato.Size = New System.Drawing.Size(465, 310)
        Me.uos_Formato.TabIndex = 0
        Me.uos_Formato.Text = "10 - CAJA Y BANCOS"
        '
        'ugb_Datos
        '
        Me.ugb_Datos.CaptionAlignment = Infragistics.Win.Misc.GroupBoxCaptionAlignment.Center
        Me.ugb_Datos.Controls.Add(Me.UltraButton1)
        Me.ugb_Datos.Controls.Add(Me.txt_mes)
        Me.ugb_Datos.Controls.Add(Me.btn_inv_per)
        Me.ugb_Datos.Controls.Add(Me.UltraLabel2)
        Me.ugb_Datos.Controls.Add(Me.txt_Ayo)
        Me.ugb_Datos.HeaderPosition = Infragistics.Win.Misc.GroupBoxHeaderPosition.TopOutsideBorder
        Me.ugb_Datos.Location = New System.Drawing.Point(11, 28)
        Me.ugb_Datos.Name = "ugb_Datos"
        Me.ugb_Datos.Size = New System.Drawing.Size(497, 36)
        Me.ugb_Datos.TabIndex = 7
        '
        'UltraButton1
        '
        Me.UltraButton1.Location = New System.Drawing.Point(326, 6)
        Me.UltraButton1.Name = "UltraButton1"
        Me.UltraButton1.Size = New System.Drawing.Size(62, 23)
        Me.UltraButton1.TabIndex = 4
        Me.UltraButton1.Text = "Detalle"
        Me.UltraButton1.Visible = False
        '
        'txt_mes
        '
        Me.txt_mes.Location = New System.Drawing.Point(394, 8)
        Me.txt_mes.Name = "txt_mes"
        Me.txt_mes.Size = New System.Drawing.Size(40, 21)
        Me.txt_mes.TabIndex = 3
        Me.txt_mes.Visible = False
        '
        'btn_inv_per
        '
        Me.btn_inv_per.Location = New System.Drawing.Point(440, 8)
        Me.btn_inv_per.Name = "btn_inv_per"
        Me.btn_inv_per.Size = New System.Drawing.Size(42, 23)
        Me.btn_inv_per.TabIndex = 2
        Me.btn_inv_per.Text = "Inv Perman"
        Me.btn_inv_per.UseVisualStyleBackColor = True
        Me.btn_inv_per.Visible = False
        '
        'UltraLabel2
        '
        Appearance11.BackColor = System.Drawing.Color.Transparent
        Appearance11.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel2.Appearance = Appearance11
        Me.UltraLabel2.AutoSize = True
        Me.UltraLabel2.Location = New System.Drawing.Point(17, 12)
        Me.UltraLabel2.Name = "UltraLabel2"
        Me.UltraLabel2.Size = New System.Drawing.Size(30, 14)
        Me.UltraLabel2.TabIndex = 1
        Me.UltraLabel2.Text = "Año :"
        '
        'txt_Ayo
        '
        Me.txt_Ayo.Location = New System.Drawing.Point(55, 8)
        Me.txt_Ayo.Name = "txt_Ayo"
        Me.txt_Ayo.Size = New System.Drawing.Size(46, 21)
        Me.txt_Ayo.TabIndex = 0
        '
        'ugb_formato
        '
        Me.ugb_formato.Controls.Add(Me.uos_Formato)
        Me.ugb_formato.Location = New System.Drawing.Point(12, 70)
        Me.ugb_formato.Name = "ugb_formato"
        Me.ugb_formato.Size = New System.Drawing.Size(496, 350)
        Me.ugb_formato.TabIndex = 8
        Me.ugb_formato.Text = "Detalle del Saldo de la Cuenta :"
        '
        'ToolStrip1
        '
        Me.ToolStrip1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Tool_imprimir, Me.ToolStripSeparator2, Me.Tool_salir, Me.ToolStripSeparator1})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(519, 25)
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
        'CO_RP_Bal_Inv
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(519, 432)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.ugb_formato)
        Me.Controls.Add(Me.ugb_Datos)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "CO_RP_Bal_Inv"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Balance e Inventarios"
        CType(Me.uos_Formato, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ugb_Datos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ugb_Datos.ResumeLayout(False)
        Me.ugb_Datos.PerformLayout()
        CType(Me.txt_mes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_Ayo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ugb_formato, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ugb_formato.ResumeLayout(False)
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents uos_Formato As Infragistics.Win.UltraWinEditors.UltraOptionSet
    Friend WithEvents ugb_Datos As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents UltraLabel2 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents txt_Ayo As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents ugb_formato As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents Tool_imprimir As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents Tool_salir As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btn_inv_per As System.Windows.Forms.Button
    Friend WithEvents txt_mes As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents UltraButton1 As Infragistics.Win.Misc.UltraButton
End Class
