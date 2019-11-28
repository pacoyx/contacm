<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PL_PR_Contabilizacion
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
        Dim Appearance13 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance23 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance8 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance7 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance6 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance5 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance4 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.Tool_Aceptar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.Tool_Salir = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ugb_Parametros = New Infragistics.Win.Misc.UltraGroupBox()
        Me.une_ayo = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.txt_Subdiario = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.ume_fec_vou = New Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit()
        Me.uce_TipoPersonal = New Infragistics.Win.UltraWinEditors.UltraComboEditor()
        Me.UltraLabel2 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraLabel3 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraLabel1 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraLabel7 = New Infragistics.Win.Misc.UltraLabel()
        Me.uce_Mes = New Infragistics.Win.UltraWinEditors.UltraComboEditor()
        Me.ug_asiento = New Infragistics.Win.UltraWinGrid.UltraGrid()
        Me.upg_1 = New Infragistics.Win.UltraWinProgressBar.UltraProgressBar()
        Me.t1 = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.t2 = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.txt_diferencia = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.ToolStrip1.SuspendLayout()
        CType(Me.ugb_Parametros, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ugb_Parametros.SuspendLayout()
        CType(Me.une_ayo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_Subdiario, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.uce_TipoPersonal, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.uce_Mes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ug_asiento, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.t1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.t2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_diferencia, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ToolStrip1
        '
        Me.ToolStrip1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripSeparator3, Me.Tool_Aceptar, Me.ToolStripSeparator1, Me.Tool_Salir, Me.ToolStripSeparator2})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(555, 25)
        Me.ToolStrip1.TabIndex = 11
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 25)
        '
        'Tool_Aceptar
        '
        Me.Tool_Aceptar.Image = Global.Contabilidad.My.Resources.Resources._16__Configure_
        Me.Tool_Aceptar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Tool_Aceptar.Name = "Tool_Aceptar"
        Me.Tool_Aceptar.Size = New System.Drawing.Size(72, 22)
        Me.Tool_Aceptar.Text = "Procesar"
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
        Me.Tool_Salir.Size = New System.Drawing.Size(49, 22)
        Me.Tool_Salir.Text = "Salir"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'ugb_Parametros
        '
        Me.ugb_Parametros.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ugb_Parametros.Controls.Add(Me.une_ayo)
        Me.ugb_Parametros.Controls.Add(Me.txt_Subdiario)
        Me.ugb_Parametros.Controls.Add(Me.ume_fec_vou)
        Me.ugb_Parametros.Controls.Add(Me.uce_TipoPersonal)
        Me.ugb_Parametros.Controls.Add(Me.UltraLabel2)
        Me.ugb_Parametros.Controls.Add(Me.UltraLabel3)
        Me.ugb_Parametros.Controls.Add(Me.UltraLabel1)
        Me.ugb_Parametros.Controls.Add(Me.UltraLabel7)
        Me.ugb_Parametros.Controls.Add(Me.uce_Mes)
        Me.ugb_Parametros.Location = New System.Drawing.Point(12, 36)
        Me.ugb_Parametros.Name = "ugb_Parametros"
        Me.ugb_Parametros.Size = New System.Drawing.Size(536, 77)
        Me.ugb_Parametros.TabIndex = 12
        '
        'une_ayo
        '
        Me.une_ayo.Location = New System.Drawing.Point(71, 15)
        Me.une_ayo.Name = "une_ayo"
        Me.une_ayo.Size = New System.Drawing.Size(36, 21)
        Me.une_ayo.TabIndex = 20
        '
        'txt_Subdiario
        '
        Me.txt_Subdiario.Location = New System.Drawing.Point(313, 42)
        Me.txt_Subdiario.Name = "txt_Subdiario"
        Me.txt_Subdiario.Size = New System.Drawing.Size(199, 21)
        Me.txt_Subdiario.TabIndex = 18
        '
        'ume_fec_vou
        '
        Me.ume_fec_vou.EditAs = Infragistics.Win.UltraWinMaskedEdit.EditAsType.UseSpecifiedMask
        Me.ume_fec_vou.InputMask = "{LOC}dd/mm/yyyy"
        Me.ume_fec_vou.Location = New System.Drawing.Point(313, 16)
        Me.ume_fec_vou.Name = "ume_fec_vou"
        Me.ume_fec_vou.Size = New System.Drawing.Size(84, 20)
        Me.ume_fec_vou.TabIndex = 17
        Me.ume_fec_vou.Text = "UltraMaskedEdit1"
        '
        'uce_TipoPersonal
        '
        Me.uce_TipoPersonal.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.uce_TipoPersonal.Location = New System.Drawing.Point(71, 42)
        Me.uce_TipoPersonal.Name = "uce_TipoPersonal"
        Me.uce_TipoPersonal.Size = New System.Drawing.Size(160, 21)
        Me.uce_TipoPersonal.TabIndex = 16
        '
        'UltraLabel2
        '
        Appearance13.BackColor = System.Drawing.Color.Transparent
        Appearance13.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel2.Appearance = Appearance13
        Me.UltraLabel2.AutoSize = True
        Me.UltraLabel2.Location = New System.Drawing.Point(7, 46)
        Me.UltraLabel2.Name = "UltraLabel2"
        Me.UltraLabel2.Size = New System.Drawing.Size(53, 14)
        Me.UltraLabel2.TabIndex = 15
        Me.UltraLabel2.Text = "Tipo Trab"
        '
        'UltraLabel3
        '
        Appearance23.BackColor = System.Drawing.Color.Transparent
        Appearance23.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel3.Appearance = Appearance23
        Me.UltraLabel3.AutoSize = True
        Me.UltraLabel3.Location = New System.Drawing.Point(255, 46)
        Me.UltraLabel3.Name = "UltraLabel3"
        Me.UltraLabel3.Size = New System.Drawing.Size(52, 14)
        Me.UltraLabel3.TabIndex = 12
        Me.UltraLabel3.Text = "Subdiario"
        '
        'UltraLabel1
        '
        Appearance8.BackColor = System.Drawing.Color.Transparent
        Appearance8.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel1.Appearance = Appearance8
        Me.UltraLabel1.AutoSize = True
        Me.UltraLabel1.Location = New System.Drawing.Point(239, 19)
        Me.UltraLabel1.Name = "UltraLabel1"
        Me.UltraLabel1.Size = New System.Drawing.Size(68, 14)
        Me.UltraLabel1.TabIndex = 12
        Me.UltraLabel1.Text = "Fec Voucher"
        '
        'UltraLabel7
        '
        Appearance7.BackColor = System.Drawing.Color.Transparent
        Appearance7.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel7.Appearance = Appearance7
        Me.UltraLabel7.AutoSize = True
        Me.UltraLabel7.Location = New System.Drawing.Point(7, 19)
        Me.UltraLabel7.Name = "UltraLabel7"
        Me.UltraLabel7.Size = New System.Drawing.Size(43, 14)
        Me.UltraLabel7.TabIndex = 12
        Me.UltraLabel7.Text = "Periodo"
        '
        'uce_Mes
        '
        Me.uce_Mes.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.uce_Mes.Location = New System.Drawing.Point(107, 15)
        Me.uce_Mes.Name = "uce_Mes"
        Me.uce_Mes.Size = New System.Drawing.Size(124, 21)
        Me.uce_Mes.TabIndex = 0
        '
        'ug_asiento
        '
        Me.ug_asiento.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.[False]
        Me.ug_asiento.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Me.ug_asiento.Location = New System.Drawing.Point(16, 206)
        Me.ug_asiento.Name = "ug_asiento"
        Me.ug_asiento.Size = New System.Drawing.Size(520, 275)
        Me.ug_asiento.TabIndex = 13
        Me.ug_asiento.Text = "UltraGrid1"
        Me.ug_asiento.Visible = False
        '
        'upg_1
        '
        Me.upg_1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.upg_1.Location = New System.Drawing.Point(12, 119)
        Me.upg_1.Name = "upg_1"
        Me.upg_1.Size = New System.Drawing.Size(536, 20)
        Me.upg_1.TabIndex = 14
        Me.upg_1.Text = "[Formatted]"
        Me.upg_1.Visible = False
        '
        't1
        '
        Appearance6.TextHAlignAsString = "Right"
        Me.t1.Appearance = Appearance6
        Me.t1.Location = New System.Drawing.Point(330, 487)
        Me.t1.Name = "t1"
        Me.t1.ReadOnly = True
        Me.t1.Size = New System.Drawing.Size(100, 21)
        Me.t1.TabIndex = 15
        Me.t1.Visible = False
        '
        't2
        '
        Appearance5.TextHAlignAsString = "Right"
        Me.t2.Appearance = Appearance5
        Me.t2.Location = New System.Drawing.Point(436, 487)
        Me.t2.Name = "t2"
        Me.t2.ReadOnly = True
        Me.t2.Size = New System.Drawing.Size(100, 21)
        Me.t2.TabIndex = 15
        Me.t2.Visible = False
        '
        'txt_diferencia
        '
        Appearance4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Appearance4.TextHAlignAsString = "Right"
        Me.txt_diferencia.Appearance = Appearance4
        Me.txt_diferencia.Location = New System.Drawing.Point(436, 514)
        Me.txt_diferencia.Name = "txt_diferencia"
        Me.txt_diferencia.ReadOnly = True
        Me.txt_diferencia.Size = New System.Drawing.Size(100, 21)
        Me.txt_diferencia.TabIndex = 16
        Me.txt_diferencia.Visible = False
        '
        'PL_PR_Contabilizacion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(555, 148)
        Me.Controls.Add(Me.txt_diferencia)
        Me.Controls.Add(Me.t2)
        Me.Controls.Add(Me.t1)
        Me.Controls.Add(Me.upg_1)
        Me.Controls.Add(Me.ug_asiento)
        Me.Controls.Add(Me.ugb_Parametros)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Name = "PL_PR_Contabilizacion"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Contabilizacion de Planilla"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        CType(Me.ugb_Parametros, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ugb_Parametros.ResumeLayout(False)
        Me.ugb_Parametros.PerformLayout()
        CType(Me.une_ayo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_Subdiario, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.uce_TipoPersonal, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.uce_Mes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ug_asiento, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.t1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.t2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_diferencia, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents Tool_Aceptar As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents Tool_Salir As System.Windows.Forms.ToolStripButton
    Friend WithEvents ugb_Parametros As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents UltraLabel7 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents uce_Mes As Infragistics.Win.UltraWinEditors.UltraComboEditor
    Friend WithEvents ug_asiento As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents upg_1 As Infragistics.Win.UltraWinProgressBar.UltraProgressBar
    Friend WithEvents t1 As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents t2 As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents uce_TipoPersonal As Infragistics.Win.UltraWinEditors.UltraComboEditor
    Friend WithEvents UltraLabel2 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents txt_diferencia As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ume_fec_vou As Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit
    Friend WithEvents UltraLabel1 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents txt_Subdiario As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents UltraLabel3 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents une_ayo As Infragistics.Win.UltraWinEditors.UltraTextEditor
End Class
