<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PL_RP_Liq_Apor_Ret
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
        Dim Appearance4 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance1 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim ValueListItem1 As Infragistics.Win.ValueListItem = New Infragistics.Win.ValueListItem()
        Dim ValueListItem5 As Infragistics.Win.ValueListItem = New Infragistics.Win.ValueListItem()
        Dim ValueListItem6 As Infragistics.Win.ValueListItem = New Infragistics.Win.ValueListItem()
        Dim ValueListItem7 As Infragistics.Win.ValueListItem = New Infragistics.Win.ValueListItem()
        Dim ValueListItem8 As Infragistics.Win.ValueListItem = New Infragistics.Win.ValueListItem()
        Dim ValueListItem9 As Infragistics.Win.ValueListItem = New Infragistics.Win.ValueListItem()
        Me.uos_formato = New Infragistics.Win.UltraWinEditors.UltraOptionSet()
        Me.ubtn_Imprimir = New Infragistics.Win.Misc.UltraButton()
        Me.ubtn_Cancelar = New Infragistics.Win.Misc.UltraButton()
        Me.ugb_Datos = New Infragistics.Win.Misc.UltraGroupBox()
        Me.UltraLabel1 = New Infragistics.Win.Misc.UltraLabel()
        Me.txt_Ayo = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.ulbl_combo = New Infragistics.Win.Misc.UltraLabel()
        Me.ugb_combo = New Infragistics.Win.Misc.UltraGroupBox()
        Me.uce_afp = New Infragistics.Win.UltraWinEditors.UltraComboEditor()
        Me.UltraGroupBox1 = New Infragistics.Win.Misc.UltraGroupBox()
        CType(Me.uos_formato, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ugb_Datos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ugb_Datos.SuspendLayout()
        CType(Me.txt_Ayo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ugb_combo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ugb_combo.SuspendLayout()
        CType(Me.uce_afp, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UltraGroupBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraGroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'uos_formato
        '
        Me.uos_formato.BackColor = System.Drawing.Color.Transparent
        Me.uos_formato.BackColorInternal = System.Drawing.Color.Transparent
        Me.uos_formato.BorderStyle = Infragistics.Win.UIElementBorderStyle.None
        Me.uos_formato.CheckedIndex = 0
        ValueListItem2.DataValue = "1"
        ValueListItem2.DisplayText = "Liquidacion Anual de Aportes y Retenciones Previsionales"
        ValueListItem3.DataValue = "2"
        ValueListItem3.DisplayText = "Comprobantes para el trabajador de Retenciones"
        ValueListItem4.DataValue = "3"
        ValueListItem4.DisplayText = "Certificado de Rentas y Retenciones por Rentas de 5ta cat."
        Me.uos_formato.Items.AddRange(New Infragistics.Win.ValueListItem() {ValueListItem2, ValueListItem3, ValueListItem4})
        Me.uos_formato.ItemSpacingVertical = 4
        Me.uos_formato.Location = New System.Drawing.Point(6, 29)
        Me.uos_formato.Name = "uos_formato"
        Me.uos_formato.Size = New System.Drawing.Size(388, 65)
        Me.uos_formato.TabIndex = 0
        Me.uos_formato.Text = "Liquidacion Anual de Aportes y Retenciones Previsionales"
        '
        'ubtn_Imprimir
        '
        Me.ubtn_Imprimir.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ubtn_Imprimir.Location = New System.Drawing.Point(256, 207)
        Me.ubtn_Imprimir.Name = "ubtn_Imprimir"
        Me.ubtn_Imprimir.Size = New System.Drawing.Size(75, 30)
        Me.ubtn_Imprimir.TabIndex = 20
        Me.ubtn_Imprimir.Text = "&Imprimir"
        '
        'ubtn_Cancelar
        '
        Me.ubtn_Cancelar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ubtn_Cancelar.Location = New System.Drawing.Point(337, 207)
        Me.ubtn_Cancelar.Name = "ubtn_Cancelar"
        Me.ubtn_Cancelar.Size = New System.Drawing.Size(75, 30)
        Me.ubtn_Cancelar.TabIndex = 21
        Me.ubtn_Cancelar.Text = "&Salir"
        '
        'ugb_Datos
        '
        Me.ugb_Datos.CaptionAlignment = Infragistics.Win.Misc.GroupBoxCaptionAlignment.Center
        Me.ugb_Datos.Controls.Add(Me.UltraLabel1)
        Me.ugb_Datos.Controls.Add(Me.txt_Ayo)
        Me.ugb_Datos.HeaderPosition = Infragistics.Win.Misc.GroupBoxHeaderPosition.TopOutsideBorder
        Me.ugb_Datos.Location = New System.Drawing.Point(12, 120)
        Me.ugb_Datos.Name = "ugb_Datos"
        Me.ugb_Datos.Size = New System.Drawing.Size(102, 81)
        Me.ugb_Datos.TabIndex = 22
        Me.ugb_Datos.Text = "Periodo"
        '
        'UltraLabel1
        '
        Appearance4.BackColor = System.Drawing.Color.Transparent
        Appearance4.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel1.Appearance = Appearance4
        Me.UltraLabel1.AutoSize = True
        Me.UltraLabel1.Location = New System.Drawing.Point(6, 40)
        Me.UltraLabel1.Name = "UltraLabel1"
        Me.UltraLabel1.Size = New System.Drawing.Size(30, 14)
        Me.UltraLabel1.TabIndex = 1
        Me.UltraLabel1.Text = "Año :"
        '
        'txt_Ayo
        '
        Me.txt_Ayo.Location = New System.Drawing.Point(42, 36)
        Me.txt_Ayo.Name = "txt_Ayo"
        Me.txt_Ayo.Size = New System.Drawing.Size(45, 21)
        Me.txt_Ayo.TabIndex = 0
        '
        'ulbl_combo
        '
        Appearance1.BackColor = System.Drawing.Color.Transparent
        Appearance1.ForeColor = System.Drawing.Color.Navy
        Me.ulbl_combo.Appearance = Appearance1
        Me.ulbl_combo.AutoSize = True
        Me.ulbl_combo.Location = New System.Drawing.Point(6, 37)
        Me.ulbl_combo.Name = "ulbl_combo"
        Me.ulbl_combo.Size = New System.Drawing.Size(32, 14)
        Me.ulbl_combo.TabIndex = 1
        Me.ulbl_combo.Text = "AFP :"
        '
        'ugb_combo
        '
        Me.ugb_combo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ugb_combo.CaptionAlignment = Infragistics.Win.Misc.GroupBoxCaptionAlignment.Center
        Me.ugb_combo.Controls.Add(Me.uce_afp)
        Me.ugb_combo.Controls.Add(Me.ulbl_combo)
        Me.ugb_combo.HeaderPosition = Infragistics.Win.Misc.GroupBoxHeaderPosition.TopOutsideBorder
        Me.ugb_combo.Location = New System.Drawing.Point(120, 120)
        Me.ugb_combo.Name = "ugb_combo"
        Me.ugb_combo.Size = New System.Drawing.Size(292, 81)
        Me.ugb_combo.TabIndex = 23
        Me.ugb_combo.Text = "SNP /  SPP"
        '
        'uce_afp
        '
        Me.uce_afp.DropDownListWidth = 300
        Me.uce_afp.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        ValueListItem1.DataValue = "0"
        ValueListItem1.DisplayText = "ONP"
        ValueListItem5.DataValue = "1"
        ValueListItem5.DisplayText = "HORIZONTE"
        ValueListItem6.DataValue = "2"
        ValueListItem6.DisplayText = "PRIMA AFP"
        ValueListItem7.DataValue = "3"
        ValueListItem7.DisplayText = "INTEGRA"
        ValueListItem8.DataValue = "4"
        ValueListItem8.DisplayText = "UNIONVIDA"
        ValueListItem9.DataValue = "5"
        ValueListItem9.DisplayText = "PROFUTURO"
        Me.uce_afp.Items.AddRange(New Infragistics.Win.ValueListItem() {ValueListItem1, ValueListItem5, ValueListItem6, ValueListItem7, ValueListItem8, ValueListItem9})
        Me.uce_afp.Location = New System.Drawing.Point(44, 33)
        Me.uce_afp.Name = "uce_afp"
        Me.uce_afp.Size = New System.Drawing.Size(235, 21)
        Me.uce_afp.TabIndex = 2
        '
        'UltraGroupBox1
        '
        Me.UltraGroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.UltraGroupBox1.Controls.Add(Me.uos_formato)
        Me.UltraGroupBox1.HeaderPosition = Infragistics.Win.Misc.GroupBoxHeaderPosition.TopOutsideBorder
        Me.UltraGroupBox1.Location = New System.Drawing.Point(12, 13)
        Me.UltraGroupBox1.Name = "UltraGroupBox1"
        Me.UltraGroupBox1.Size = New System.Drawing.Size(400, 101)
        Me.UltraGroupBox1.TabIndex = 24
        Me.UltraGroupBox1.Text = "Formato:"
        '
        'PL_RP_Liq_Apor_Ret
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(422, 244)
        Me.Controls.Add(Me.UltraGroupBox1)
        Me.Controls.Add(Me.ugb_combo)
        Me.Controls.Add(Me.ugb_Datos)
        Me.Controls.Add(Me.ubtn_Imprimir)
        Me.Controls.Add(Me.ubtn_Cancelar)
        Me.Name = "PL_RP_Liq_Apor_Ret"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Liquidacion,Aportaciones y Retenciones"
        CType(Me.uos_formato, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ugb_Datos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ugb_Datos.ResumeLayout(False)
        Me.ugb_Datos.PerformLayout()
        CType(Me.txt_Ayo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ugb_combo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ugb_combo.ResumeLayout(False)
        Me.ugb_combo.PerformLayout()
        CType(Me.uce_afp, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UltraGroupBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraGroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents uos_formato As Infragistics.Win.UltraWinEditors.UltraOptionSet
    Friend WithEvents ubtn_Imprimir As Infragistics.Win.Misc.UltraButton
    Friend WithEvents ubtn_Cancelar As Infragistics.Win.Misc.UltraButton
    Friend WithEvents ugb_Datos As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents UltraLabel1 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents txt_Ayo As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents ulbl_combo As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents ugb_combo As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents uce_afp As Infragistics.Win.UltraWinEditors.UltraComboEditor
    Friend WithEvents UltraGroupBox1 As Infragistics.Win.Misc.UltraGroupBox
End Class
