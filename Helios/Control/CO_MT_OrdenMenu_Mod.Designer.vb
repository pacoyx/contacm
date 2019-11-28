<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CO_MT_OrdenMenu_Mod
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
        Dim Appearance3 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance4 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance5 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance9 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance6 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance8 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance10 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance11 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance12 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance2 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance1 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance7 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Me.lb_Modulos = New System.Windows.Forms.ListBox()
        Me.ToolS_Mantenimiento = New System.Windows.Forms.ToolStrip()
        Me.Tool_Grabar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.Tool_Salir = New System.Windows.Forms.ToolStripButton()
        Me.ubtn_up_mod = New Infragistics.Win.Misc.UltraButton()
        Me.ubtn_down_mod = New Infragistics.Win.Misc.UltraButton()
        Me.UltraLabel3 = New Infragistics.Win.Misc.UltraLabel()
        Me.lb_Grupos = New System.Windows.Forms.ListBox()
        Me.UltraLabel1 = New Infragistics.Win.Misc.UltraLabel()
        Me.ubtn_down_gru = New Infragistics.Win.Misc.UltraButton()
        Me.ubtn_up_gru = New Infragistics.Win.Misc.UltraButton()
        Me.lb_Opciones_padres = New System.Windows.Forms.ListBox()
        Me.ubtn_down_opc = New Infragistics.Win.Misc.UltraButton()
        Me.ubtn_up_opc = New Infragistics.Win.Misc.UltraButton()
        Me.UltraLabel2 = New Infragistics.Win.Misc.UltraLabel()
        Me.lb_opciones_hijos = New System.Windows.Forms.ListBox()
        Me.ubtn_down_opc_hijo = New Infragistics.Win.Misc.UltraButton()
        Me.ubtn_up_opc_hijo = New Infragistics.Win.Misc.UltraButton()
        Me.UltraLabel4 = New Infragistics.Win.Misc.UltraLabel()
        Me.ToolS_Mantenimiento.SuspendLayout()
        Me.SuspendLayout()
        '
        'lb_Modulos
        '
        Me.lb_Modulos.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_Modulos.ForeColor = System.Drawing.Color.Navy
        Me.lb_Modulos.FormattingEnabled = True
        Me.lb_Modulos.ItemHeight = 16
        Me.lb_Modulos.Location = New System.Drawing.Point(12, 56)
        Me.lb_Modulos.Name = "lb_Modulos"
        Me.lb_Modulos.Size = New System.Drawing.Size(177, 244)
        Me.lb_Modulos.TabIndex = 0
        '
        'ToolS_Mantenimiento
        '
        Me.ToolS_Mantenimiento.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ToolS_Mantenimiento.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Tool_Grabar, Me.ToolStripSeparator3, Me.Tool_Salir})
        Me.ToolS_Mantenimiento.Location = New System.Drawing.Point(0, 0)
        Me.ToolS_Mantenimiento.Name = "ToolS_Mantenimiento"
        Me.ToolS_Mantenimiento.Size = New System.Drawing.Size(944, 25)
        Me.ToolS_Mantenimiento.TabIndex = 5
        Me.ToolS_Mantenimiento.Text = "ToolStrip1"
        '
        'Tool_Grabar
        '
        Me.Tool_Grabar.Image = Global.Contabilidad.My.Resources.Resources._003
        Me.Tool_Grabar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Tool_Grabar.Name = "Tool_Grabar"
        Me.Tool_Grabar.Size = New System.Drawing.Size(60, 22)
        Me.Tool_Grabar.Text = "Grabar"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 25)
        '
        'Tool_Salir
        '
        Me.Tool_Salir.Image = Global.Contabilidad.My.Resources.Resources._28
        Me.Tool_Salir.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Tool_Salir.Name = "Tool_Salir"
        Me.Tool_Salir.Size = New System.Drawing.Size(47, 22)
        Me.Tool_Salir.Text = "Salir"
        '
        'ubtn_up_mod
        '
        Appearance3.ImageHAlign = Infragistics.Win.HAlign.Center
        Appearance3.ImageVAlign = Infragistics.Win.VAlign.Middle
        Appearance3.TextHAlignAsString = "Center"
        Me.ubtn_up_mod.Appearance = Appearance3
        Me.ubtn_up_mod.ImageSize = New System.Drawing.Size(20, 20)
        Me.ubtn_up_mod.Location = New System.Drawing.Point(195, 133)
        Me.ubtn_up_mod.Name = "ubtn_up_mod"
        Me.ubtn_up_mod.Size = New System.Drawing.Size(38, 33)
        Me.ubtn_up_mod.TabIndex = 6
        '
        'ubtn_down_mod
        '
        Appearance4.ImageHAlign = Infragistics.Win.HAlign.Center
        Appearance4.ImageVAlign = Infragistics.Win.VAlign.Middle
        Appearance4.TextHAlignAsString = "Center"
        Me.ubtn_down_mod.Appearance = Appearance4
        Me.ubtn_down_mod.ImageSize = New System.Drawing.Size(20, 20)
        Me.ubtn_down_mod.Location = New System.Drawing.Point(195, 172)
        Me.ubtn_down_mod.Name = "ubtn_down_mod"
        Me.ubtn_down_mod.Size = New System.Drawing.Size(38, 33)
        Me.ubtn_down_mod.TabIndex = 6
        '
        'UltraLabel3
        '
        Appearance5.BackColor = System.Drawing.Color.Transparent
        Appearance5.FontData.UnderlineAsString = "True"
        Appearance5.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel3.Appearance = Appearance5
        Me.UltraLabel3.AutoSize = True
        Me.UltraLabel3.Location = New System.Drawing.Point(12, 36)
        Me.UltraLabel3.Name = "UltraLabel3"
        Me.UltraLabel3.Size = New System.Drawing.Size(47, 14)
        Me.UltraLabel3.TabIndex = 7
        Me.UltraLabel3.Text = "Modulos"
        '
        'lb_Grupos
        '
        Me.lb_Grupos.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_Grupos.ForeColor = System.Drawing.Color.Navy
        Me.lb_Grupos.FormattingEnabled = True
        Me.lb_Grupos.ItemHeight = 16
        Me.lb_Grupos.Location = New System.Drawing.Point(239, 56)
        Me.lb_Grupos.Name = "lb_Grupos"
        Me.lb_Grupos.Size = New System.Drawing.Size(177, 244)
        Me.lb_Grupos.TabIndex = 8
        '
        'UltraLabel1
        '
        Appearance9.BackColor = System.Drawing.Color.Transparent
        Appearance9.FontData.UnderlineAsString = "True"
        Appearance9.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel1.Appearance = Appearance9
        Me.UltraLabel1.AutoSize = True
        Me.UltraLabel1.Location = New System.Drawing.Point(239, 36)
        Me.UltraLabel1.Name = "UltraLabel1"
        Me.UltraLabel1.Size = New System.Drawing.Size(41, 14)
        Me.UltraLabel1.TabIndex = 7
        Me.UltraLabel1.Text = "Grupos"
        '
        'ubtn_down_gru
        '
        Appearance6.ImageHAlign = Infragistics.Win.HAlign.Center
        Appearance6.ImageVAlign = Infragistics.Win.VAlign.Middle
        Appearance6.TextHAlignAsString = "Center"
        Me.ubtn_down_gru.Appearance = Appearance6
        Me.ubtn_down_gru.ImageSize = New System.Drawing.Size(20, 20)
        Me.ubtn_down_gru.Location = New System.Drawing.Point(422, 172)
        Me.ubtn_down_gru.Name = "ubtn_down_gru"
        Me.ubtn_down_gru.Size = New System.Drawing.Size(38, 33)
        Me.ubtn_down_gru.TabIndex = 10
        '
        'ubtn_up_gru
        '
        Appearance8.ImageHAlign = Infragistics.Win.HAlign.Center
        Appearance8.ImageVAlign = Infragistics.Win.VAlign.Middle
        Appearance8.TextHAlignAsString = "Center"
        Me.ubtn_up_gru.Appearance = Appearance8
        Me.ubtn_up_gru.ImageSize = New System.Drawing.Size(20, 20)
        Me.ubtn_up_gru.Location = New System.Drawing.Point(422, 133)
        Me.ubtn_up_gru.Name = "ubtn_up_gru"
        Me.ubtn_up_gru.Size = New System.Drawing.Size(38, 33)
        Me.ubtn_up_gru.TabIndex = 9
        '
        'lb_Opciones_padres
        '
        Me.lb_Opciones_padres.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_Opciones_padres.ForeColor = System.Drawing.Color.Navy
        Me.lb_Opciones_padres.FormattingEnabled = True
        Me.lb_Opciones_padres.ItemHeight = 16
        Me.lb_Opciones_padres.Location = New System.Drawing.Point(466, 56)
        Me.lb_Opciones_padres.Name = "lb_Opciones_padres"
        Me.lb_Opciones_padres.Size = New System.Drawing.Size(187, 244)
        Me.lb_Opciones_padres.TabIndex = 11
        '
        'ubtn_down_opc
        '
        Appearance10.ImageHAlign = Infragistics.Win.HAlign.Center
        Appearance10.ImageVAlign = Infragistics.Win.VAlign.Middle
        Appearance10.TextHAlignAsString = "Center"
        Me.ubtn_down_opc.Appearance = Appearance10
        Me.ubtn_down_opc.ImageSize = New System.Drawing.Size(20, 20)
        Me.ubtn_down_opc.Location = New System.Drawing.Point(659, 172)
        Me.ubtn_down_opc.Name = "ubtn_down_opc"
        Me.ubtn_down_opc.Size = New System.Drawing.Size(38, 33)
        Me.ubtn_down_opc.TabIndex = 13
        '
        'ubtn_up_opc
        '
        Appearance11.ImageHAlign = Infragistics.Win.HAlign.Center
        Appearance11.ImageVAlign = Infragistics.Win.VAlign.Middle
        Appearance11.TextHAlignAsString = "Center"
        Me.ubtn_up_opc.Appearance = Appearance11
        Me.ubtn_up_opc.ImageSize = New System.Drawing.Size(20, 20)
        Me.ubtn_up_opc.Location = New System.Drawing.Point(659, 133)
        Me.ubtn_up_opc.Name = "ubtn_up_opc"
        Me.ubtn_up_opc.Size = New System.Drawing.Size(38, 33)
        Me.ubtn_up_opc.TabIndex = 12
        '
        'UltraLabel2
        '
        Appearance12.BackColor = System.Drawing.Color.Transparent
        Appearance12.FontData.UnderlineAsString = "True"
        Appearance12.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel2.Appearance = Appearance12
        Me.UltraLabel2.AutoSize = True
        Me.UltraLabel2.Location = New System.Drawing.Point(466, 36)
        Me.UltraLabel2.Name = "UltraLabel2"
        Me.UltraLabel2.Size = New System.Drawing.Size(91, 14)
        Me.UltraLabel2.TabIndex = 7
        Me.UltraLabel2.Text = "Opciones Padres"
        '
        'lb_opciones_hijos
        '
        Me.lb_opciones_hijos.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_opciones_hijos.ForeColor = System.Drawing.Color.Navy
        Me.lb_opciones_hijos.FormattingEnabled = True
        Me.lb_opciones_hijos.ItemHeight = 16
        Me.lb_opciones_hijos.Location = New System.Drawing.Point(703, 54)
        Me.lb_opciones_hijos.Name = "lb_opciones_hijos"
        Me.lb_opciones_hijos.Size = New System.Drawing.Size(187, 244)
        Me.lb_opciones_hijos.TabIndex = 14
        '
        'ubtn_down_opc_hijo
        '
        Appearance2.ImageHAlign = Infragistics.Win.HAlign.Center
        Appearance2.ImageVAlign = Infragistics.Win.VAlign.Middle
        Appearance2.TextHAlignAsString = "Center"
        Me.ubtn_down_opc_hijo.Appearance = Appearance2
        Me.ubtn_down_opc_hijo.ImageSize = New System.Drawing.Size(20, 20)
        Me.ubtn_down_opc_hijo.Location = New System.Drawing.Point(896, 172)
        Me.ubtn_down_opc_hijo.Name = "ubtn_down_opc_hijo"
        Me.ubtn_down_opc_hijo.Size = New System.Drawing.Size(38, 33)
        Me.ubtn_down_opc_hijo.TabIndex = 16
        '
        'ubtn_up_opc_hijo
        '
        Appearance1.ImageHAlign = Infragistics.Win.HAlign.Center
        Appearance1.ImageVAlign = Infragistics.Win.VAlign.Middle
        Appearance1.TextHAlignAsString = "Center"
        Me.ubtn_up_opc_hijo.Appearance = Appearance1
        Me.ubtn_up_opc_hijo.ImageSize = New System.Drawing.Size(20, 20)
        Me.ubtn_up_opc_hijo.Location = New System.Drawing.Point(896, 133)
        Me.ubtn_up_opc_hijo.Name = "ubtn_up_opc_hijo"
        Me.ubtn_up_opc_hijo.Size = New System.Drawing.Size(38, 33)
        Me.ubtn_up_opc_hijo.TabIndex = 15
        '
        'UltraLabel4
        '
        Appearance7.BackColor = System.Drawing.Color.Transparent
        Appearance7.FontData.UnderlineAsString = "True"
        Appearance7.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel4.Appearance = Appearance7
        Me.UltraLabel4.AutoSize = True
        Me.UltraLabel4.Location = New System.Drawing.Point(703, 36)
        Me.UltraLabel4.Name = "UltraLabel4"
        Me.UltraLabel4.Size = New System.Drawing.Size(80, 14)
        Me.UltraLabel4.TabIndex = 7
        Me.UltraLabel4.Text = "Opciones Hijos"
        '
        'CO_MT_OrdenMenu_Mod
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(944, 308)
        Me.Controls.Add(Me.ubtn_down_opc_hijo)
        Me.Controls.Add(Me.ubtn_up_opc_hijo)
        Me.Controls.Add(Me.lb_opciones_hijos)
        Me.Controls.Add(Me.ubtn_down_opc)
        Me.Controls.Add(Me.ubtn_up_opc)
        Me.Controls.Add(Me.lb_Opciones_padres)
        Me.Controls.Add(Me.ubtn_down_gru)
        Me.Controls.Add(Me.ubtn_up_gru)
        Me.Controls.Add(Me.lb_Grupos)
        Me.Controls.Add(Me.UltraLabel4)
        Me.Controls.Add(Me.UltraLabel2)
        Me.Controls.Add(Me.UltraLabel1)
        Me.Controls.Add(Me.UltraLabel3)
        Me.Controls.Add(Me.ubtn_down_mod)
        Me.Controls.Add(Me.ubtn_up_mod)
        Me.Controls.Add(Me.ToolS_Mantenimiento)
        Me.Controls.Add(Me.lb_Modulos)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "CO_MT_OrdenMenu_Mod"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Orden de Menu"
        Me.ToolS_Mantenimiento.ResumeLayout(False)
        Me.ToolS_Mantenimiento.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lb_Modulos As System.Windows.Forms.ListBox
    Friend WithEvents ToolS_Mantenimiento As System.Windows.Forms.ToolStrip
    Friend WithEvents Tool_Grabar As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents Tool_Salir As System.Windows.Forms.ToolStripButton
    Friend WithEvents ubtn_up_mod As Infragistics.Win.Misc.UltraButton
    Friend WithEvents ubtn_down_mod As Infragistics.Win.Misc.UltraButton
    Friend WithEvents UltraLabel3 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents lb_Grupos As System.Windows.Forms.ListBox
    Friend WithEvents UltraLabel1 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents ubtn_down_gru As Infragistics.Win.Misc.UltraButton
    Friend WithEvents ubtn_up_gru As Infragistics.Win.Misc.UltraButton
    Friend WithEvents lb_Opciones_padres As System.Windows.Forms.ListBox
    Friend WithEvents ubtn_down_opc As Infragistics.Win.Misc.UltraButton
    Friend WithEvents ubtn_up_opc As Infragistics.Win.Misc.UltraButton
    Friend WithEvents UltraLabel2 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents lb_opciones_hijos As System.Windows.Forms.ListBox
    Friend WithEvents ubtn_down_opc_hijo As Infragistics.Win.Misc.UltraButton
    Friend WithEvents ubtn_up_opc_hijo As Infragistics.Win.Misc.UltraButton
    Friend WithEvents UltraLabel4 As Infragistics.Win.Misc.UltraLabel
End Class
