<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PL_PR_Liquidacion_Planilla
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
        Dim Appearance3 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim ValueListItem3 As Infragistics.Win.ValueListItem = New Infragistics.Win.ValueListItem()
        Dim ValueListItem2 As Infragistics.Win.ValueListItem = New Infragistics.Win.ValueListItem()
        Me.Period = New Infragistics.Win.Misc.UltraLabel()
        Me.udte_Periodo = New Infragistics.Win.UltraWinEditors.UltraDateTimeEditor()
        Me.UltraLabel1 = New Infragistics.Win.Misc.UltraLabel()
        Me.uce_TipoPersonal = New Infragistics.Win.UltraWinEditors.UltraComboEditor()
        Me.uos_alcance = New Infragistics.Win.UltraWinEditors.UltraOptionSet()
        Me.UltraGroupBox1 = New Infragistics.Win.Misc.UltraGroupBox()
        Me.upb_estado = New Infragistics.Win.UltraWinProgressBar.UltraProgressBar()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.Tool_Procesar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.Tool_Salir = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.uchk_Tardanzas = New Infragistics.Win.UltraWinEditors.UltraCheckEditor()
        Me.uchk_3roPiso = New Infragistics.Win.UltraWinEditors.UltraCheckEditor()
        CType(Me.udte_Periodo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.uce_TipoPersonal, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.uos_alcance, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UltraGroupBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraGroupBox1.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Period
        '
        Appearance2.BackColor = System.Drawing.Color.Transparent
        Appearance2.ForeColor = System.Drawing.Color.Navy
        Me.Period.Appearance = Appearance2
        Me.Period.AutoSize = True
        Me.Period.Location = New System.Drawing.Point(15, 18)
        Me.Period.Name = "Period"
        Me.Period.Size = New System.Drawing.Size(43, 14)
        Me.Period.TabIndex = 1
        Me.Period.Text = "Periodo"
        '
        'udte_Periodo
        '
        Me.udte_Periodo.Location = New System.Drawing.Point(95, 14)
        Me.udte_Periodo.Name = "udte_Periodo"
        Me.udte_Periodo.Size = New System.Drawing.Size(103, 21)
        Me.udte_Periodo.TabIndex = 2
        '
        'UltraLabel1
        '
        Appearance1.BackColor = System.Drawing.Color.Transparent
        Appearance1.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel1.Appearance = Appearance1
        Me.UltraLabel1.AutoSize = True
        Me.UltraLabel1.Location = New System.Drawing.Point(15, 45)
        Me.UltraLabel1.Name = "UltraLabel1"
        Me.UltraLabel1.Size = New System.Drawing.Size(74, 14)
        Me.UltraLabel1.TabIndex = 3
        Me.UltraLabel1.Text = "Tipo Personal"
        '
        'uce_TipoPersonal
        '
        Me.uce_TipoPersonal.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.uce_TipoPersonal.Location = New System.Drawing.Point(95, 41)
        Me.uce_TipoPersonal.Name = "uce_TipoPersonal"
        Me.uce_TipoPersonal.Size = New System.Drawing.Size(154, 21)
        Me.uce_TipoPersonal.TabIndex = 4
        '
        'uos_alcance
        '
        Appearance3.ForeColor = System.Drawing.Color.Navy
        Me.uos_alcance.Appearance = Appearance3
        Me.uos_alcance.BackColor = System.Drawing.Color.Transparent
        Me.uos_alcance.BackColorInternal = System.Drawing.Color.Transparent
        Me.uos_alcance.BorderStyle = Infragistics.Win.UIElementBorderStyle.None
        Me.uos_alcance.CheckedIndex = 0
        ValueListItem3.DataValue = CType(2, Short)
        ValueListItem3.DisplayText = "General"
        ValueListItem2.DataValue = CType(1, Short)
        ValueListItem2.DisplayText = "Individual"
        Me.uos_alcance.Items.AddRange(New Infragistics.Win.ValueListItem() {ValueListItem3, ValueListItem2})
        Me.uos_alcance.ItemSpacingHorizontal = 10
        Me.uos_alcance.ItemSpacingVertical = 10
        Me.uos_alcance.Location = New System.Drawing.Point(287, 13)
        Me.uos_alcance.Name = "uos_alcance"
        Me.uos_alcance.Size = New System.Drawing.Size(112, 48)
        Me.uos_alcance.TabIndex = 5
        Me.uos_alcance.Text = "General"
        '
        'UltraGroupBox1
        '
        Me.UltraGroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.UltraGroupBox1.Controls.Add(Me.uos_alcance)
        Me.UltraGroupBox1.Controls.Add(Me.uce_TipoPersonal)
        Me.UltraGroupBox1.Controls.Add(Me.UltraLabel1)
        Me.UltraGroupBox1.Controls.Add(Me.udte_Periodo)
        Me.UltraGroupBox1.Controls.Add(Me.Period)
        Me.UltraGroupBox1.Location = New System.Drawing.Point(12, 30)
        Me.UltraGroupBox1.Name = "UltraGroupBox1"
        Me.UltraGroupBox1.Size = New System.Drawing.Size(413, 77)
        Me.UltraGroupBox1.TabIndex = 6
        '
        'upb_estado
        '
        Me.upb_estado.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.upb_estado.Location = New System.Drawing.Point(12, 113)
        Me.upb_estado.Name = "upb_estado"
        Me.upb_estado.Size = New System.Drawing.Size(413, 19)
        Me.upb_estado.TabIndex = 7
        Me.upb_estado.Text = "[Formatted]"
        Me.upb_estado.Visible = False
        '
        'ToolStrip1
        '
        Me.ToolStrip1.BackColor = System.Drawing.Color.Gainsboro
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Tool_Procesar, Me.ToolStripSeparator2, Me.Tool_Salir, Me.ToolStripSeparator3})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(437, 25)
        Me.ToolStrip1.TabIndex = 8
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'Tool_Procesar
        '
        Me.Tool_Procesar.Image = Global.Contabilidad.My.Resources.Resources._16__Configure_
        Me.Tool_Procesar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Tool_Procesar.Name = "Tool_Procesar"
        Me.Tool_Procesar.Size = New System.Drawing.Size(72, 22)
        Me.Tool_Procesar.Text = "Procesar"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'Tool_Salir
        '
        Me.Tool_Salir.Image = Global.Contabilidad.My.Resources.Resources._28
        Me.Tool_Salir.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Tool_Salir.Name = "Tool_Salir"
        Me.Tool_Salir.Size = New System.Drawing.Size(49, 22)
        Me.Tool_Salir.Text = "Salir"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 25)
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.uchk_Tardanzas)
        Me.GroupBox1.Controls.Add(Me.uchk_3roPiso)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 142)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(417, 49)
        Me.GroupBox1.TabIndex = 9
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Opciones"
        '
        'uchk_Tardanzas
        '
        Me.uchk_Tardanzas.Location = New System.Drawing.Point(200, 19)
        Me.uchk_Tardanzas.Name = "uchk_Tardanzas"
        Me.uchk_Tardanzas.Size = New System.Drawing.Size(199, 20)
        Me.uchk_Tardanzas.TabIndex = 2
        Me.uchk_Tardanzas.Text = "Considerar Reporte de Tardanzas"
        '
        'uchk_3roPiso
        '
        Me.uchk_3roPiso.Location = New System.Drawing.Point(15, 19)
        Me.uchk_3roPiso.Name = "uchk_3roPiso"
        Me.uchk_3roPiso.Size = New System.Drawing.Size(183, 20)
        Me.uchk_3roPiso.TabIndex = 1
        Me.uchk_3roPiso.Text = "Considerar Reg. Hras. 3er Piso"
        '
        'PL_PR_Liquidacion_Planilla
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(437, 138)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.upb_estado)
        Me.Controls.Add(Me.UltraGroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "PL_PR_Liquidacion_Planilla"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Liquidacion de Planilla"
        CType(Me.udte_Periodo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.uce_TipoPersonal, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.uos_alcance, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UltraGroupBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraGroupBox1.ResumeLayout(False)
        Me.UltraGroupBox1.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Period As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents udte_Periodo As Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
    Friend WithEvents UltraLabel1 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents uce_TipoPersonal As Infragistics.Win.UltraWinEditors.UltraComboEditor
    Friend WithEvents uos_alcance As Infragistics.Win.UltraWinEditors.UltraOptionSet
    Friend WithEvents UltraGroupBox1 As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents upb_estado As Infragistics.Win.UltraWinProgressBar.UltraProgressBar
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents Tool_Procesar As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents Tool_Salir As System.Windows.Forms.ToolStripButton
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents uchk_3roPiso As Infragistics.Win.UltraWinEditors.UltraCheckEditor
    Friend WithEvents uchk_Tardanzas As Infragistics.Win.UltraWinEditors.UltraCheckEditor
End Class
