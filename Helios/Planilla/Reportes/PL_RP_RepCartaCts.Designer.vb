<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PL_RP_RepCartaCts
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
        Dim Appearance23 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance1 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim EditorButton4 As Infragistics.Win.UltraWinEditors.EditorButton = New Infragistics.Win.UltraWinEditors.EditorButton()
        Dim Appearance6 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim EditorButton5 As Infragistics.Win.UltraWinEditors.EditorButton = New Infragistics.Win.UltraWinEditors.EditorButton("btn_ant")
        Dim Appearance9 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim EditorButton6 As Infragistics.Win.UltraWinEditors.EditorButton = New Infragistics.Win.UltraWinEditors.EditorButton("btn_sig")
        Dim Appearance10 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance13 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance2 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Me.ugb_Parametros = New Infragistics.Win.Misc.UltraGroupBox()
        Me.une_ayo = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.UltraLabel7 = New Infragistics.Win.Misc.UltraLabel()
        Me.uce_Mes = New Infragistics.Win.UltraWinEditors.UltraComboEditor()
        Me.uce_TipoPersonal = New Infragistics.Win.UltraWinEditors.UltraComboEditor()
        Me.UltraLabel2 = New Infragistics.Win.Misc.UltraLabel()
        Me.txt_codper = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.txt_nombres = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.txt_nom = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.txt_ape_mat = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.txt_ape_pat = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.txt_idpersonal = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ume_fecha = New Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit()
        Me.UltraGroupBox1 = New Infragistics.Win.Misc.UltraGroupBox()
        Me.UltraGroupBox2 = New Infragistics.Win.Misc.UltraGroupBox()
        Me.ume_tc = New Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit()
        Me.UltraLabel3 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraLabel1 = New Infragistics.Win.Misc.UltraLabel()
        Me.Tool_Reporte = New System.Windows.Forms.ToolStripButton()
        Me.Tool_Salir = New System.Windows.Forms.ToolStripButton()
        Me.bs_trabajadores = New System.Windows.Forms.BindingSource(Me.components)
        CType(Me.ugb_Parametros, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ugb_Parametros.SuspendLayout()
        CType(Me.une_ayo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.uce_Mes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.uce_TipoPersonal, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_codper, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_nombres, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_nom, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_ape_mat, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_ape_pat, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_idpersonal, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip1.SuspendLayout()
        CType(Me.UltraGroupBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraGroupBox1.SuspendLayout()
        CType(Me.UltraGroupBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraGroupBox2.SuspendLayout()
        CType(Me.bs_trabajadores, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ugb_Parametros
        '
        Me.ugb_Parametros.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ugb_Parametros.Controls.Add(Me.une_ayo)
        Me.ugb_Parametros.Controls.Add(Me.UltraLabel7)
        Me.ugb_Parametros.Controls.Add(Me.uce_Mes)
        Me.ugb_Parametros.Location = New System.Drawing.Point(12, 28)
        Me.ugb_Parametros.Name = "ugb_Parametros"
        Me.ugb_Parametros.Size = New System.Drawing.Size(522, 37)
        Me.ugb_Parametros.TabIndex = 8
        '
        'une_ayo
        '
        Me.une_ayo.Location = New System.Drawing.Point(71, 10)
        Me.une_ayo.Name = "une_ayo"
        Me.une_ayo.Size = New System.Drawing.Size(36, 21)
        Me.une_ayo.TabIndex = 15
        '
        'UltraLabel7
        '
        Appearance23.BackColor = System.Drawing.Color.Transparent
        Appearance23.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel7.Appearance = Appearance23
        Me.UltraLabel7.AutoSize = True
        Me.UltraLabel7.Location = New System.Drawing.Point(10, 14)
        Me.UltraLabel7.Name = "UltraLabel7"
        Me.UltraLabel7.Size = New System.Drawing.Size(43, 14)
        Me.UltraLabel7.TabIndex = 12
        Me.UltraLabel7.Text = "Periodo"
        '
        'uce_Mes
        '
        Me.uce_Mes.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.uce_Mes.Location = New System.Drawing.Point(107, 10)
        Me.uce_Mes.Name = "uce_Mes"
        Me.uce_Mes.Size = New System.Drawing.Size(114, 21)
        Me.uce_Mes.TabIndex = 0
        '
        'uce_TipoPersonal
        '
        Me.uce_TipoPersonal.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.uce_TipoPersonal.Location = New System.Drawing.Point(70, 9)
        Me.uce_TipoPersonal.Name = "uce_TipoPersonal"
        Me.uce_TipoPersonal.Size = New System.Drawing.Size(96, 21)
        Me.uce_TipoPersonal.TabIndex = 14
        '
        'UltraLabel2
        '
        Appearance1.BackColor = System.Drawing.Color.Transparent
        Appearance1.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel2.Appearance = Appearance1
        Me.UltraLabel2.AutoSize = True
        Me.UltraLabel2.Location = New System.Drawing.Point(9, 13)
        Me.UltraLabel2.Name = "UltraLabel2"
        Me.UltraLabel2.Size = New System.Drawing.Size(59, 14)
        Me.UltraLabel2.TabIndex = 3
        Me.UltraLabel2.Text = "Trabajador"
        '
        'txt_codper
        '
        Appearance6.ImageHAlign = Infragistics.Win.HAlign.Center
        EditorButton4.Appearance = Appearance6
        Me.txt_codper.ButtonsRight.Add(EditorButton4)
        Me.txt_codper.Location = New System.Drawing.Point(166, 9)
        Me.txt_codper.Name = "txt_codper"
        Me.txt_codper.Size = New System.Drawing.Size(75, 21)
        Me.txt_codper.TabIndex = 1
        '
        'txt_nombres
        '
        Me.txt_nombres.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Appearance9.ImageHAlign = Infragistics.Win.HAlign.Center
        Appearance9.ImageVAlign = Infragistics.Win.VAlign.Middle
        EditorButton5.Appearance = Appearance9
        EditorButton5.Key = "btn_ant"
        Appearance10.ImageHAlign = Infragistics.Win.HAlign.Center
        Appearance10.ImageVAlign = Infragistics.Win.VAlign.Middle
        EditorButton6.Appearance = Appearance10
        EditorButton6.Key = "btn_sig"
        Me.txt_nombres.ButtonsRight.Add(EditorButton5)
        Me.txt_nombres.ButtonsRight.Add(EditorButton6)
        Me.txt_nombres.Location = New System.Drawing.Point(241, 9)
        Me.txt_nombres.Name = "txt_nombres"
        Me.txt_nombres.ReadOnly = True
        Me.txt_nombres.Size = New System.Drawing.Size(262, 21)
        Me.txt_nombres.TabIndex = 1
        '
        'txt_nom
        '
        Me.txt_nom.Location = New System.Drawing.Point(190, 218)
        Me.txt_nom.Name = "txt_nom"
        Me.txt_nom.Size = New System.Drawing.Size(38, 21)
        Me.txt_nom.TabIndex = 21
        Me.txt_nom.Visible = False
        '
        'txt_ape_mat
        '
        Me.txt_ape_mat.Location = New System.Drawing.Point(146, 218)
        Me.txt_ape_mat.Name = "txt_ape_mat"
        Me.txt_ape_mat.Size = New System.Drawing.Size(38, 21)
        Me.txt_ape_mat.TabIndex = 20
        Me.txt_ape_mat.Visible = False
        '
        'txt_ape_pat
        '
        Me.txt_ape_pat.Location = New System.Drawing.Point(102, 218)
        Me.txt_ape_pat.Name = "txt_ape_pat"
        Me.txt_ape_pat.Size = New System.Drawing.Size(38, 21)
        Me.txt_ape_pat.TabIndex = 19
        Me.txt_ape_pat.Visible = False
        '
        'txt_idpersonal
        '
        Me.txt_idpersonal.Location = New System.Drawing.Point(58, 218)
        Me.txt_idpersonal.Name = "txt_idpersonal"
        Me.txt_idpersonal.Size = New System.Drawing.Size(38, 21)
        Me.txt_idpersonal.TabIndex = 18
        Me.txt_idpersonal.Visible = False
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Tool_Reporte, Me.ToolStripSeparator2, Me.Tool_Salir, Me.ToolStripSeparator1})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(557, 25)
        Me.ToolStrip1.TabIndex = 22
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
        'ume_fecha
        '
        Me.ume_fecha.EditAs = Infragistics.Win.UltraWinMaskedEdit.EditAsType.UseSpecifiedMask
        Me.ume_fecha.InputMask = "{date}"
        Me.ume_fecha.Location = New System.Drawing.Point(104, 11)
        Me.ume_fecha.Name = "ume_fecha"
        Me.ume_fecha.Size = New System.Drawing.Size(78, 20)
        Me.ume_fecha.TabIndex = 16
        Me.ume_fecha.Text = "UltraMaskedEdit1"
        '
        'UltraGroupBox1
        '
        Me.UltraGroupBox1.Controls.Add(Me.uce_TipoPersonal)
        Me.UltraGroupBox1.Controls.Add(Me.UltraLabel2)
        Me.UltraGroupBox1.Controls.Add(Me.txt_codper)
        Me.UltraGroupBox1.Controls.Add(Me.txt_nombres)
        Me.UltraGroupBox1.Location = New System.Drawing.Point(12, 71)
        Me.UltraGroupBox1.Name = "UltraGroupBox1"
        Me.UltraGroupBox1.Size = New System.Drawing.Size(520, 39)
        Me.UltraGroupBox1.TabIndex = 23
        '
        'UltraGroupBox2
        '
        Me.UltraGroupBox2.Controls.Add(Me.ume_tc)
        Me.UltraGroupBox2.Controls.Add(Me.UltraLabel3)
        Me.UltraGroupBox2.Controls.Add(Me.UltraLabel1)
        Me.UltraGroupBox2.Controls.Add(Me.ume_fecha)
        Me.UltraGroupBox2.Location = New System.Drawing.Point(12, 116)
        Me.UltraGroupBox2.Name = "UltraGroupBox2"
        Me.UltraGroupBox2.Size = New System.Drawing.Size(522, 45)
        Me.UltraGroupBox2.TabIndex = 24
        '
        'ume_tc
        '
        Me.ume_tc.EditAs = Infragistics.Win.UltraWinMaskedEdit.EditAsType.UseSpecifiedMask
        Me.ume_tc.InputMask = "{double:1.3}"
        Me.ume_tc.Location = New System.Drawing.Point(296, 11)
        Me.ume_tc.Name = "ume_tc"
        Me.ume_tc.Size = New System.Drawing.Size(43, 20)
        Me.ume_tc.TabIndex = 19
        '
        'UltraLabel3
        '
        Appearance13.BackColor = System.Drawing.Color.Transparent
        Appearance13.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel3.Appearance = Appearance13
        Me.UltraLabel3.AutoSize = True
        Me.UltraLabel3.Location = New System.Drawing.Point(211, 14)
        Me.UltraLabel3.Name = "UltraLabel3"
        Me.UltraLabel3.Size = New System.Drawing.Size(68, 14)
        Me.UltraLabel3.TabIndex = 18
        Me.UltraLabel3.Text = "Tipo Cambio"
        '
        'UltraLabel1
        '
        Appearance2.BackColor = System.Drawing.Color.Transparent
        Appearance2.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel1.Appearance = Appearance2
        Me.UltraLabel1.AutoSize = True
        Me.UltraLabel1.Location = New System.Drawing.Point(6, 14)
        Me.UltraLabel1.Name = "UltraLabel1"
        Me.UltraLabel1.Size = New System.Drawing.Size(83, 14)
        Me.UltraLabel1.TabIndex = 17
        Me.UltraLabel1.Text = "Fecha Deposito"
        '
        'Tool_Reporte
        '
        Me.Tool_Reporte.Image = Global.Contabilidad.My.Resources.Resources._004
        Me.Tool_Reporte.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Tool_Reporte.Name = "Tool_Reporte"
        Me.Tool_Reporte.Size = New System.Drawing.Size(68, 22)
        Me.Tool_Reporte.Text = "Reporte"
        '
        'Tool_Salir
        '
        Me.Tool_Salir.Image = Global.Contabilidad.My.Resources.Resources._28
        Me.Tool_Salir.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Tool_Salir.Name = "Tool_Salir"
        Me.Tool_Salir.Size = New System.Drawing.Size(49, 22)
        Me.Tool_Salir.Text = "Salir"
        '
        'bs_trabajadores
        '
        '
        'PL_RP_RepCartaCts
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(557, 169)
        Me.Controls.Add(Me.UltraGroupBox2)
        Me.Controls.Add(Me.UltraGroupBox1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.txt_nom)
        Me.Controls.Add(Me.txt_ape_mat)
        Me.Controls.Add(Me.txt_ape_pat)
        Me.Controls.Add(Me.txt_idpersonal)
        Me.Controls.Add(Me.ugb_Parametros)
        Me.Name = "PL_RP_RepCartaCts"
        Me.Text = "Reporte Carta Cts"
        CType(Me.ugb_Parametros, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ugb_Parametros.ResumeLayout(False)
        Me.ugb_Parametros.PerformLayout()
        CType(Me.une_ayo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.uce_Mes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.uce_TipoPersonal, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_codper, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_nombres, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_nom, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_ape_mat, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_ape_pat, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_idpersonal, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        CType(Me.UltraGroupBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraGroupBox1.ResumeLayout(False)
        Me.UltraGroupBox1.PerformLayout()
        CType(Me.UltraGroupBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraGroupBox2.ResumeLayout(False)
        Me.UltraGroupBox2.PerformLayout()
        CType(Me.bs_trabajadores, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ugb_Parametros As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents une_ayo As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents uce_TipoPersonal As Infragistics.Win.UltraWinEditors.UltraComboEditor
    Friend WithEvents UltraLabel2 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel7 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents uce_Mes As Infragistics.Win.UltraWinEditors.UltraComboEditor
    Friend WithEvents txt_codper As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents txt_nombres As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents txt_nom As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents txt_ape_mat As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents txt_ape_pat As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents txt_idpersonal As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents Tool_Reporte As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents Tool_Salir As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents bs_trabajadores As System.Windows.Forms.BindingSource
    Friend WithEvents ume_fecha As Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit
    Friend WithEvents UltraGroupBox1 As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents UltraGroupBox2 As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents ume_tc As Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit
    Friend WithEvents UltraLabel3 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel1 As Infragistics.Win.Misc.UltraLabel
End Class
