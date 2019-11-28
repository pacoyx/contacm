<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CO_RP_ConciliacionBancos
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
        Dim Appearance1 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim ValueListItem1 As Infragistics.Win.ValueListItem = New Infragistics.Win.ValueListItem()
        Dim ValueListItem2 As Infragistics.Win.ValueListItem = New Infragistics.Win.ValueListItem()
        Dim Appearance16 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance8 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance9 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance7 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Me.uos_Reportes = New Infragistics.Win.UltraWinEditors.UltraOptionSet()
        Me.ugb_Parametros = New Infragistics.Win.Misc.UltraGroupBox()
        Me.uce_CtasCorrientes = New Infragistics.Win.UltraWinEditors.UltraComboEditor()
        Me.uce_Bancos = New Infragistics.Win.UltraWinEditors.UltraComboEditor()
        Me.une_Ayo = New Infragistics.Win.UltraWinEditors.UltraNumericEditor()
        Me.UltraLabel3 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraLabel2 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraLabel1 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraLabel4 = New Infragistics.Win.Misc.UltraLabel()
        Me.uce_Mes = New Infragistics.Win.UltraWinEditors.UltraComboEditor()
        Me.UltraGroupBox1 = New Infragistics.Win.Misc.UltraGroupBox()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.Tool_imprimir = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.Tool_salir = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        CType(Me.uos_Reportes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ugb_Parametros, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ugb_Parametros.SuspendLayout()
        CType(Me.uce_CtasCorrientes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.uce_Bancos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.une_Ayo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.uce_Mes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UltraGroupBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraGroupBox1.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'uos_Reportes
        '
        Appearance1.ForeColor = System.Drawing.Color.Navy
        Me.uos_Reportes.Appearance = Appearance1
        Me.uos_Reportes.BackColor = System.Drawing.Color.Transparent
        Me.uos_Reportes.BackColorInternal = System.Drawing.Color.Transparent
        Me.uos_Reportes.BorderStyle = Infragistics.Win.UIElementBorderStyle.None
        Me.uos_Reportes.CheckedIndex = 0
        ValueListItem1.DataValue = CType(1, Short)
        ValueListItem1.DisplayText = "Movimientos No Conciliados"
        ValueListItem2.DataValue = CType(2, Short)
        ValueListItem2.DisplayText = "Conciliacion Bancaria"
        Me.uos_Reportes.Items.AddRange(New Infragistics.Win.ValueListItem() {ValueListItem1, ValueListItem2})
        Me.uos_Reportes.ItemSpacingHorizontal = 5
        Me.uos_Reportes.ItemSpacingVertical = 5
        Me.uos_Reportes.Location = New System.Drawing.Point(14, 10)
        Me.uos_Reportes.Name = "uos_Reportes"
        Me.uos_Reportes.Size = New System.Drawing.Size(181, 42)
        Me.uos_Reportes.TabIndex = 0
        Me.uos_Reportes.Text = "Movimientos No Conciliados"
        '
        'ugb_Parametros
        '
        Me.ugb_Parametros.Controls.Add(Me.uce_CtasCorrientes)
        Me.ugb_Parametros.Controls.Add(Me.uce_Bancos)
        Me.ugb_Parametros.Controls.Add(Me.une_Ayo)
        Me.ugb_Parametros.Controls.Add(Me.UltraLabel3)
        Me.ugb_Parametros.Controls.Add(Me.UltraLabel2)
        Me.ugb_Parametros.Controls.Add(Me.UltraLabel1)
        Me.ugb_Parametros.Controls.Add(Me.UltraLabel4)
        Me.ugb_Parametros.Controls.Add(Me.uce_Mes)
        Me.ugb_Parametros.Location = New System.Drawing.Point(12, 28)
        Me.ugb_Parametros.Name = "ugb_Parametros"
        Me.ugb_Parametros.Size = New System.Drawing.Size(510, 77)
        Me.ugb_Parametros.TabIndex = 8
        '
        'uce_CtasCorrientes
        '
        Me.uce_CtasCorrientes.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.uce_CtasCorrientes.Location = New System.Drawing.Point(284, 43)
        Me.uce_CtasCorrientes.Name = "uce_CtasCorrientes"
        Me.uce_CtasCorrientes.Size = New System.Drawing.Size(216, 21)
        Me.uce_CtasCorrientes.TabIndex = 15
        '
        'uce_Bancos
        '
        Me.uce_Bancos.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.uce_Bancos.Location = New System.Drawing.Point(284, 13)
        Me.uce_Bancos.Name = "uce_Bancos"
        Me.uce_Bancos.Size = New System.Drawing.Size(216, 21)
        Me.uce_Bancos.TabIndex = 15
        '
        'une_Ayo
        '
        Me.une_Ayo.Enabled = False
        Me.une_Ayo.Location = New System.Drawing.Point(48, 13)
        Me.une_Ayo.MaskInput = "nnnn"
        Me.une_Ayo.Name = "une_Ayo"
        Me.une_Ayo.Size = New System.Drawing.Size(46, 21)
        Me.une_Ayo.TabIndex = 13
        '
        'UltraLabel3
        '
        Appearance16.BackColor = System.Drawing.Color.Transparent
        Appearance16.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel3.Appearance = Appearance16
        Me.UltraLabel3.AutoSize = True
        Me.UltraLabel3.Location = New System.Drawing.Point(181, 47)
        Me.UltraLabel3.Name = "UltraLabel3"
        Me.UltraLabel3.Size = New System.Drawing.Size(97, 14)
        Me.UltraLabel3.TabIndex = 12
        Me.UltraLabel3.Text = "Cuenta Corriente :"
        '
        'UltraLabel2
        '
        Appearance8.BackColor = System.Drawing.Color.Transparent
        Appearance8.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel2.Appearance = Appearance8
        Me.UltraLabel2.AutoSize = True
        Me.UltraLabel2.Location = New System.Drawing.Point(236, 17)
        Me.UltraLabel2.Name = "UltraLabel2"
        Me.UltraLabel2.Size = New System.Drawing.Size(42, 14)
        Me.UltraLabel2.TabIndex = 12
        Me.UltraLabel2.Text = "Banco :"
        '
        'UltraLabel1
        '
        Appearance9.BackColor = System.Drawing.Color.Transparent
        Appearance9.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel1.Appearance = Appearance9
        Me.UltraLabel1.AutoSize = True
        Me.UltraLabel1.Location = New System.Drawing.Point(12, 17)
        Me.UltraLabel1.Name = "UltraLabel1"
        Me.UltraLabel1.Size = New System.Drawing.Size(30, 14)
        Me.UltraLabel1.TabIndex = 12
        Me.UltraLabel1.Text = "Año :"
        '
        'UltraLabel4
        '
        Appearance7.BackColor = System.Drawing.Color.Transparent
        Appearance7.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel4.Appearance = Appearance7
        Me.UltraLabel4.AutoSize = True
        Me.UltraLabel4.Location = New System.Drawing.Point(10, 47)
        Me.UltraLabel4.Name = "UltraLabel4"
        Me.UltraLabel4.Size = New System.Drawing.Size(32, 14)
        Me.UltraLabel4.TabIndex = 12
        Me.UltraLabel4.Text = "Mes :"
        '
        'uce_Mes
        '
        Me.uce_Mes.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.uce_Mes.Location = New System.Drawing.Point(48, 43)
        Me.uce_Mes.Name = "uce_Mes"
        Me.uce_Mes.Size = New System.Drawing.Size(112, 21)
        Me.uce_Mes.TabIndex = 0
        '
        'UltraGroupBox1
        '
        Me.UltraGroupBox1.Controls.Add(Me.uos_Reportes)
        Me.UltraGroupBox1.Location = New System.Drawing.Point(12, 111)
        Me.UltraGroupBox1.Name = "UltraGroupBox1"
        Me.UltraGroupBox1.Size = New System.Drawing.Size(510, 68)
        Me.UltraGroupBox1.TabIndex = 11
        '
        'ToolStrip1
        '
        Me.ToolStrip1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Tool_imprimir, Me.ToolStripSeparator2, Me.Tool_salir, Me.ToolStripSeparator1})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(532, 25)
        Me.ToolStrip1.TabIndex = 202
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'Tool_imprimir
        '
        Me.Tool_imprimir.Image = Global.Contabilidad.My.Resources.Resources._004
        Me.Tool_imprimir.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Tool_imprimir.Name = "Tool_imprimir"
        Me.Tool_imprimir.Size = New System.Drawing.Size(65, 22)
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
        Me.Tool_salir.Size = New System.Drawing.Size(47, 22)
        Me.Tool_salir.Text = "Salir"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'CO_RP_ConciliacionBancos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(532, 187)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.UltraGroupBox1)
        Me.Controls.Add(Me.ugb_Parametros)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "CO_RP_ConciliacionBancos"
        Me.Text = "Reportes de Conciliacion Bancaria"
        CType(Me.uos_Reportes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ugb_Parametros, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ugb_Parametros.ResumeLayout(False)
        Me.ugb_Parametros.PerformLayout()
        CType(Me.uce_CtasCorrientes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.uce_Bancos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.une_Ayo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.uce_Mes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UltraGroupBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraGroupBox1.ResumeLayout(False)
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents uos_Reportes As Infragistics.Win.UltraWinEditors.UltraOptionSet
    Friend WithEvents ugb_Parametros As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents uce_CtasCorrientes As Infragistics.Win.UltraWinEditors.UltraComboEditor
    Friend WithEvents uce_Bancos As Infragistics.Win.UltraWinEditors.UltraComboEditor
    Friend WithEvents une_Ayo As Infragistics.Win.UltraWinEditors.UltraNumericEditor
    Friend WithEvents UltraLabel3 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel2 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel1 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel4 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents uce_Mes As Infragistics.Win.UltraWinEditors.UltraComboEditor
    Friend WithEvents UltraGroupBox1 As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents Tool_imprimir As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents Tool_salir As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
End Class
