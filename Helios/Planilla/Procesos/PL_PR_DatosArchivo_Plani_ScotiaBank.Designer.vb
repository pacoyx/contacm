<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PL_PR_DatosArchivo_Plani_ScotiaBank
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
        Dim ValueListItem1 As Infragistics.Win.ValueListItem = New Infragistics.Win.ValueListItem()
        Dim ValueListItem4 As Infragistics.Win.ValueListItem = New Infragistics.Win.ValueListItem()
        Dim Appearance14 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance4 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance2 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance5 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance6 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Me.UltraGroupBox1 = New Infragistics.Win.Misc.UltraGroupBox()
        Me.uchk_zipear = New Infragistics.Win.UltraWinEditors.UltraCheckEditor()
        Me.udte_fec_abono = New Infragistics.Win.UltraWinEditors.UltraDateTimeEditor()
        Me.uce_tipo_servicio = New Infragistics.Win.UltraWinEditors.UltraComboEditor()
        Me.txt_cta_cargo_insti = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.txt_responsable = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.txt_cod_inti = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.UltraLabel6 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraLabel5 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraLabel7 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraLabel3 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraLabel2 = New Infragistics.Win.Misc.UltraLabel()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.Tool_Aceptar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.Tool_Salir = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        CType(Me.UltraGroupBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraGroupBox1.SuspendLayout()
        CType(Me.udte_fec_abono, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.uce_tipo_servicio, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_cta_cargo_insti, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_responsable, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_cod_inti, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'UltraGroupBox1
        '
        Me.UltraGroupBox1.Controls.Add(Me.uchk_zipear)
        Me.UltraGroupBox1.Controls.Add(Me.udte_fec_abono)
        Me.UltraGroupBox1.Controls.Add(Me.uce_tipo_servicio)
        Me.UltraGroupBox1.Controls.Add(Me.txt_cta_cargo_insti)
        Me.UltraGroupBox1.Controls.Add(Me.txt_responsable)
        Me.UltraGroupBox1.Controls.Add(Me.txt_cod_inti)
        Me.UltraGroupBox1.Controls.Add(Me.UltraLabel6)
        Me.UltraGroupBox1.Controls.Add(Me.UltraLabel5)
        Me.UltraGroupBox1.Controls.Add(Me.UltraLabel7)
        Me.UltraGroupBox1.Controls.Add(Me.UltraLabel3)
        Me.UltraGroupBox1.Controls.Add(Me.UltraLabel2)
        Me.UltraGroupBox1.Location = New System.Drawing.Point(12, 32)
        Me.UltraGroupBox1.Name = "UltraGroupBox1"
        Me.UltraGroupBox1.Size = New System.Drawing.Size(460, 170)
        Me.UltraGroupBox1.TabIndex = 21
        '
        'uchk_zipear
        '
        Me.uchk_zipear.BackColor = System.Drawing.Color.Transparent
        Me.uchk_zipear.BackColorInternal = System.Drawing.Color.Transparent
        Me.uchk_zipear.Checked = True
        Me.uchk_zipear.CheckState = System.Windows.Forms.CheckState.Checked
        Me.uchk_zipear.Location = New System.Drawing.Point(267, 63)
        Me.uchk_zipear.Name = "uchk_zipear"
        Me.uchk_zipear.Size = New System.Drawing.Size(150, 20)
        Me.uchk_zipear.TabIndex = 19
        Me.uchk_zipear.Text = "Zipear Archivo Generado"
        '
        'udte_fec_abono
        '
        Me.udte_fec_abono.Location = New System.Drawing.Point(112, 62)
        Me.udte_fec_abono.MaskInput = "{date}"
        Me.udte_fec_abono.Name = "udte_fec_abono"
        Me.udte_fec_abono.Size = New System.Drawing.Size(133, 21)
        Me.udte_fec_abono.TabIndex = 2
        '
        'uce_tipo_servicio
        '
        Me.uce_tipo_servicio.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        ValueListItem1.DataValue = "20"
        ValueListItem1.DisplayText = "20 - Planilla MN"
        ValueListItem4.DataValue = "21"
        ValueListItem4.DisplayText = "21 - Planilla ME"
        Me.uce_tipo_servicio.Items.AddRange(New Infragistics.Win.ValueListItem() {ValueListItem1, ValueListItem4})
        Me.uce_tipo_servicio.Location = New System.Drawing.Point(112, 38)
        Me.uce_tipo_servicio.Name = "uce_tipo_servicio"
        Me.uce_tipo_servicio.Size = New System.Drawing.Size(133, 21)
        Me.uce_tipo_servicio.TabIndex = 1
        '
        'txt_cta_cargo_insti
        '
        Me.txt_cta_cargo_insti.Location = New System.Drawing.Point(200, 123)
        Me.txt_cta_cargo_insti.Name = "txt_cta_cargo_insti"
        Me.txt_cta_cargo_insti.Size = New System.Drawing.Size(234, 21)
        Me.txt_cta_cargo_insti.TabIndex = 4
        Me.txt_cta_cargo_insti.Text = "010140000497"
        '
        'txt_responsable
        '
        Me.txt_responsable.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_responsable.Location = New System.Drawing.Point(200, 98)
        Me.txt_responsable.Name = "txt_responsable"
        Me.txt_responsable.Size = New System.Drawing.Size(234, 21)
        Me.txt_responsable.TabIndex = 3
        Me.txt_responsable.Text = "JAVIER ASCENZO MC CALLUM"
        '
        'txt_cod_inti
        '
        Me.txt_cod_inti.Location = New System.Drawing.Point(112, 10)
        Me.txt_cod_inti.Name = "txt_cod_inti"
        Me.txt_cod_inti.Size = New System.Drawing.Size(118, 21)
        Me.txt_cod_inti.TabIndex = 0
        '
        'UltraLabel6
        '
        Appearance14.BackColor = System.Drawing.Color.Transparent
        Appearance14.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel6.Appearance = Appearance14
        Me.UltraLabel6.AutoSize = True
        Me.UltraLabel6.Location = New System.Drawing.Point(12, 102)
        Me.UltraLabel6.Name = "UltraLabel6"
        Me.UltraLabel6.Size = New System.Drawing.Size(152, 14)
        Me.UltraLabel6.TabIndex = 13
        Me.UltraLabel6.Text = "Responsable de la Institucion"
        '
        'UltraLabel5
        '
        Appearance4.BackColor = System.Drawing.Color.Transparent
        Appearance4.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel5.Appearance = Appearance4
        Me.UltraLabel5.AutoSize = True
        Me.UltraLabel5.Location = New System.Drawing.Point(12, 127)
        Me.UltraLabel5.Name = "UltraLabel5"
        Me.UltraLabel5.Size = New System.Drawing.Size(172, 14)
        Me.UltraLabel5.TabIndex = 13
        Me.UltraLabel5.Text = "Cuenta de Cargo de la Institucion"
        '
        'UltraLabel7
        '
        Appearance2.BackColor = System.Drawing.Color.Transparent
        Appearance2.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel7.Appearance = Appearance2
        Me.UltraLabel7.AutoSize = True
        Me.UltraLabel7.Location = New System.Drawing.Point(12, 69)
        Me.UltraLabel7.Name = "UltraLabel7"
        Me.UltraLabel7.Size = New System.Drawing.Size(71, 14)
        Me.UltraLabel7.TabIndex = 13
        Me.UltraLabel7.Text = "Fecha Abono"
        '
        'UltraLabel3
        '
        Appearance5.BackColor = System.Drawing.Color.Transparent
        Appearance5.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel3.Appearance = Appearance5
        Me.UltraLabel3.AutoSize = True
        Me.UltraLabel3.Location = New System.Drawing.Point(12, 42)
        Me.UltraLabel3.Name = "UltraLabel3"
        Me.UltraLabel3.Size = New System.Drawing.Size(70, 14)
        Me.UltraLabel3.TabIndex = 13
        Me.UltraLabel3.Text = "Tipo Servicio"
        '
        'UltraLabel2
        '
        Appearance6.BackColor = System.Drawing.Color.Transparent
        Appearance6.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel2.Appearance = Appearance6
        Me.UltraLabel2.AutoSize = True
        Me.UltraLabel2.Location = New System.Drawing.Point(12, 14)
        Me.UltraLabel2.Name = "UltraLabel2"
        Me.UltraLabel2.Size = New System.Drawing.Size(94, 14)
        Me.UltraLabel2.TabIndex = 13
        Me.UltraLabel2.Text = "Codigo Institucion"
        '
        'ToolStrip1
        '
        Me.ToolStrip1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Tool_Aceptar, Me.ToolStripSeparator1, Me.Tool_Salir, Me.ToolStripSeparator4})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(484, 25)
        Me.ToolStrip1.TabIndex = 22
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'Tool_Aceptar
        '
        Me.Tool_Aceptar.Image = Global.Contabilidad.My.Resources.Resources._16__Ok_
        Me.Tool_Aceptar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Tool_Aceptar.Name = "Tool_Aceptar"
        Me.Tool_Aceptar.Size = New System.Drawing.Size(65, 22)
        Me.Tool_Aceptar.Text = "Aceptar"
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
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(6, 25)
        '
        'PL_PR_DatosArchivo_Plani_ScotiaBank
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(484, 212)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.UltraGroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MinimizeBox = False
        Me.Name = "PL_PR_DatosArchivo_Plani_ScotiaBank"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Datos Archivo Planilla ScotiaBank"
        CType(Me.UltraGroupBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraGroupBox1.ResumeLayout(False)
        Me.UltraGroupBox1.PerformLayout()
        CType(Me.udte_fec_abono, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.uce_tipo_servicio, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_cta_cargo_insti, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_responsable, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_cod_inti, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents UltraGroupBox1 As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents uchk_zipear As Infragistics.Win.UltraWinEditors.UltraCheckEditor
    Friend WithEvents udte_fec_abono As Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
    Friend WithEvents uce_tipo_servicio As Infragistics.Win.UltraWinEditors.UltraComboEditor
    Friend WithEvents txt_cta_cargo_insti As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents txt_responsable As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents txt_cod_inti As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents UltraLabel6 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel5 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel7 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel3 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel2 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents Tool_Aceptar As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents Tool_Salir As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
End Class
