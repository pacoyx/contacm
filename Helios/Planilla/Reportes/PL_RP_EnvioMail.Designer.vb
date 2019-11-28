<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PL_RP_EnvioMail
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
        Dim Appearance38 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance7 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance3 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance2 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance4 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance5 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance6 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PL_RP_EnvioMail))
        Dim Appearance8 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance9 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Me.UltraGroupBox1 = New Infragistics.Win.Misc.UltraGroupBox()
        Me.UltraGroupBox2 = New Infragistics.Win.Misc.UltraGroupBox()
        Me.lbl_datos_adj = New System.Windows.Forms.LinkLabel()
        Me.txt_correo_trab_alt = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.txt_mensaje = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.UltraLabel4 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraLabel1 = New Infragistics.Win.Misc.UltraLabel()
        Me.lbl_cargo = New Infragistics.Win.Misc.UltraLabel()
        Me.lbl_nom1 = New Infragistics.Win.Misc.UltraLabel()
        Me.lbl_ape_mat = New Infragistics.Win.Misc.UltraLabel()
        Me.lbl_ape_pat = New Infragistics.Win.Misc.UltraLabel()
        Me.lbl_correo_trabajador = New Infragistics.Win.Misc.UltraLabel()
        Me.upb_img = New Infragistics.Win.UltraWinEditors.UltraPictureBox()
        Me.lbl_correo_de = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraLabel3 = New Infragistics.Win.Misc.UltraLabel()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.Tool_Enviar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator()
        Me.Tool_Salir = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        CType(Me.UltraGroupBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraGroupBox1.SuspendLayout()
        CType(Me.UltraGroupBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraGroupBox2.SuspendLayout()
        CType(Me.txt_correo_trab_alt, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_mensaje, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'UltraGroupBox1
        '
        Me.UltraGroupBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.UltraGroupBox1.Controls.Add(Me.UltraGroupBox2)
        Me.UltraGroupBox1.Controls.Add(Me.lbl_correo_de)
        Me.UltraGroupBox1.Controls.Add(Me.UltraLabel3)
        Me.UltraGroupBox1.Location = New System.Drawing.Point(8, 34)
        Me.UltraGroupBox1.Name = "UltraGroupBox1"
        Me.UltraGroupBox1.Size = New System.Drawing.Size(502, 292)
        Me.UltraGroupBox1.TabIndex = 0
        '
        'UltraGroupBox2
        '
        Me.UltraGroupBox2.Controls.Add(Me.lbl_datos_adj)
        Me.UltraGroupBox2.Controls.Add(Me.txt_correo_trab_alt)
        Me.UltraGroupBox2.Controls.Add(Me.txt_mensaje)
        Me.UltraGroupBox2.Controls.Add(Me.UltraLabel4)
        Me.UltraGroupBox2.Controls.Add(Me.UltraLabel1)
        Me.UltraGroupBox2.Controls.Add(Me.lbl_cargo)
        Me.UltraGroupBox2.Controls.Add(Me.lbl_nom1)
        Me.UltraGroupBox2.Controls.Add(Me.lbl_ape_mat)
        Me.UltraGroupBox2.Controls.Add(Me.lbl_ape_pat)
        Me.UltraGroupBox2.Controls.Add(Me.lbl_correo_trabajador)
        Me.UltraGroupBox2.Controls.Add(Me.upb_img)
        Me.UltraGroupBox2.Location = New System.Drawing.Point(12, 40)
        Me.UltraGroupBox2.Name = "UltraGroupBox2"
        Me.UltraGroupBox2.Size = New System.Drawing.Size(480, 245)
        Me.UltraGroupBox2.TabIndex = 30
        Me.UltraGroupBox2.Text = "Para :"
        '
        'lbl_datos_adj
        '
        Me.lbl_datos_adj.BackColor = System.Drawing.Color.Transparent
        Me.lbl_datos_adj.Location = New System.Drawing.Point(133, 146)
        Me.lbl_datos_adj.Name = "lbl_datos_adj"
        Me.lbl_datos_adj.Size = New System.Drawing.Size(209, 16)
        Me.lbl_datos_adj.TabIndex = 38
        Me.lbl_datos_adj.TabStop = True
        Me.lbl_datos_adj.Text = "LinkLabel1"
        '
        'txt_correo_trab_alt
        '
        Me.txt_correo_trab_alt.Location = New System.Drawing.Point(250, 110)
        Me.txt_correo_trab_alt.Name = "txt_correo_trab_alt"
        Me.txt_correo_trab_alt.Size = New System.Drawing.Size(216, 21)
        Me.txt_correo_trab_alt.TabIndex = 31
        Me.txt_correo_trab_alt.Visible = False
        '
        'txt_mensaje
        '
        Me.txt_mensaje.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_mensaje.Location = New System.Drawing.Point(136, 169)
        Me.txt_mensaje.Multiline = True
        Me.txt_mensaje.Name = "txt_mensaje"
        Me.txt_mensaje.Size = New System.Drawing.Size(330, 64)
        Me.txt_mensaje.TabIndex = 29
        '
        'UltraLabel4
        '
        Appearance38.BackColor = System.Drawing.Color.Transparent
        Appearance38.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel4.Appearance = Appearance38
        Me.UltraLabel4.AutoSize = True
        Me.UltraLabel4.Location = New System.Drawing.Point(12, 169)
        Me.UltraLabel4.Name = "UltraLabel4"
        Me.UltraLabel4.Size = New System.Drawing.Size(47, 14)
        Me.UltraLabel4.TabIndex = 28
        Me.UltraLabel4.Text = "Mensaje"
        '
        'UltraLabel1
        '
        Appearance7.BackColor = System.Drawing.Color.Transparent
        Appearance7.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel1.Appearance = Appearance7
        Me.UltraLabel1.AutoSize = True
        Me.UltraLabel1.Location = New System.Drawing.Point(12, 146)
        Me.UltraLabel1.Name = "UltraLabel1"
        Me.UltraLabel1.Size = New System.Drawing.Size(81, 14)
        Me.UltraLabel1.TabIndex = 28
        Me.UltraLabel1.Text = "Datos Adjuntos"
        '
        'lbl_cargo
        '
        Appearance3.BackColor = System.Drawing.Color.Transparent
        Appearance3.FontData.BoldAsString = "True"
        Appearance3.ForeColor = System.Drawing.Color.Navy
        Me.lbl_cargo.Appearance = Appearance3
        Me.lbl_cargo.Location = New System.Drawing.Point(136, 88)
        Me.lbl_cargo.Name = "lbl_cargo"
        Me.lbl_cargo.Size = New System.Drawing.Size(336, 14)
        Me.lbl_cargo.TabIndex = 28
        Me.lbl_cargo.Text = "cargo"
        '
        'lbl_nom1
        '
        Appearance2.BackColor = System.Drawing.Color.Transparent
        Appearance2.FontData.BoldAsString = "True"
        Appearance2.ForeColor = System.Drawing.Color.Navy
        Me.lbl_nom1.Appearance = Appearance2
        Me.lbl_nom1.Location = New System.Drawing.Point(136, 68)
        Me.lbl_nom1.Name = "lbl_nom1"
        Me.lbl_nom1.Size = New System.Drawing.Size(336, 14)
        Me.lbl_nom1.TabIndex = 28
        Me.lbl_nom1.Text = "nombres"
        '
        'lbl_ape_mat
        '
        Appearance4.BackColor = System.Drawing.Color.Transparent
        Appearance4.FontData.BoldAsString = "True"
        Appearance4.ForeColor = System.Drawing.Color.Navy
        Me.lbl_ape_mat.Appearance = Appearance4
        Me.lbl_ape_mat.Location = New System.Drawing.Point(136, 48)
        Me.lbl_ape_mat.Name = "lbl_ape_mat"
        Me.lbl_ape_mat.Size = New System.Drawing.Size(336, 14)
        Me.lbl_ape_mat.TabIndex = 28
        Me.lbl_ape_mat.Text = "materno"
        '
        'lbl_ape_pat
        '
        Appearance5.BackColor = System.Drawing.Color.Transparent
        Appearance5.FontData.BoldAsString = "True"
        Appearance5.ForeColor = System.Drawing.Color.Navy
        Me.lbl_ape_pat.Appearance = Appearance5
        Me.lbl_ape_pat.Location = New System.Drawing.Point(136, 28)
        Me.lbl_ape_pat.Name = "lbl_ape_pat"
        Me.lbl_ape_pat.Size = New System.Drawing.Size(336, 14)
        Me.lbl_ape_pat.TabIndex = 28
        Me.lbl_ape_pat.Text = "paterno"
        '
        'lbl_correo_trabajador
        '
        Appearance6.BackColor = System.Drawing.Color.Transparent
        Appearance6.ForeColor = System.Drawing.Color.Navy
        Me.lbl_correo_trabajador.Appearance = Appearance6
        Me.lbl_correo_trabajador.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_correo_trabajador.Location = New System.Drawing.Point(136, 110)
        Me.lbl_correo_trabajador.Name = "lbl_correo_trabajador"
        Me.lbl_correo_trabajador.Size = New System.Drawing.Size(336, 14)
        Me.lbl_correo_trabajador.TabIndex = 28
        Me.lbl_correo_trabajador.Text = "Correo Electronico"
        '
        'upb_img
        '
        Me.upb_img.BorderShadowColor = System.Drawing.Color.Empty
        Me.upb_img.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.upb_img.Image = CType(resources.GetObject("upb_img.Image"), Object)
        Me.upb_img.Location = New System.Drawing.Point(12, 28)
        Me.upb_img.Name = "upb_img"
        Me.upb_img.Size = New System.Drawing.Size(98, 96)
        Me.upb_img.TabIndex = 24
        '
        'lbl_correo_de
        '
        Appearance8.BackColor = System.Drawing.Color.Transparent
        Appearance8.FontData.BoldAsString = "True"
        Appearance8.ForeColor = System.Drawing.Color.Navy
        Me.lbl_correo_de.Appearance = Appearance8
        Me.lbl_correo_de.Location = New System.Drawing.Point(71, 18)
        Me.lbl_correo_de.Name = "lbl_correo_de"
        Me.lbl_correo_de.Size = New System.Drawing.Size(417, 14)
        Me.lbl_correo_de.TabIndex = 28
        Me.lbl_correo_de.Text = "De :"
        '
        'UltraLabel3
        '
        Appearance9.BackColor = System.Drawing.Color.Transparent
        Appearance9.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel3.Appearance = Appearance9
        Me.UltraLabel3.AutoSize = True
        Me.UltraLabel3.Location = New System.Drawing.Point(22, 18)
        Me.UltraLabel3.Name = "UltraLabel3"
        Me.UltraLabel3.Size = New System.Drawing.Size(25, 14)
        Me.UltraLabel3.TabIndex = 28
        Me.UltraLabel3.Text = "De :"
        '
        'ToolStrip1
        '
        Me.ToolStrip1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripSeparator4, Me.Tool_Enviar, Me.ToolStripSeparator5, Me.Tool_Salir, Me.ToolStripSeparator1})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(516, 25)
        Me.ToolStrip1.TabIndex = 30
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(6, 25)
        '
        'Tool_Enviar
        '
        Me.Tool_Enviar.Image = Global.Contabilidad.My.Resources.Resources._16__Mail_style_2_
        Me.Tool_Enviar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Tool_Enviar.Name = "Tool_Enviar"
        Me.Tool_Enviar.Size = New System.Drawing.Size(69, 22)
        Me.Tool_Enviar.Text = "Enviar..."
        '
        'ToolStripSeparator5
        '
        Me.ToolStripSeparator5.Name = "ToolStripSeparator5"
        Me.ToolStripSeparator5.Size = New System.Drawing.Size(6, 25)
        '
        'Tool_Salir
        '
        Me.Tool_Salir.Image = Global.Contabilidad.My.Resources.Resources._28
        Me.Tool_Salir.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Tool_Salir.Name = "Tool_Salir"
        Me.Tool_Salir.Size = New System.Drawing.Size(47, 22)
        Me.Tool_Salir.Text = "Salir"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'PL_RP_EnvioMail
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(516, 331)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.UltraGroupBox1)
        Me.Name = "PL_RP_EnvioMail"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Envio Mail ..."
        CType(Me.UltraGroupBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraGroupBox1.ResumeLayout(False)
        Me.UltraGroupBox1.PerformLayout()
        CType(Me.UltraGroupBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraGroupBox2.ResumeLayout(False)
        Me.UltraGroupBox2.PerformLayout()
        CType(Me.txt_correo_trab_alt, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_mensaje, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents UltraGroupBox1 As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents upb_img As Infragistics.Win.UltraWinEditors.UltraPictureBox
    Friend WithEvents lbl_correo_trabajador As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents Tool_Enviar As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator5 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents Tool_Salir As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents txt_mensaje As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents UltraLabel4 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents lbl_cargo As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents lbl_nom1 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents lbl_ape_mat As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents lbl_ape_pat As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel1 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents lbl_correo_de As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel3 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraGroupBox2 As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents txt_correo_trab_alt As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents lbl_datos_adj As System.Windows.Forms.LinkLabel
End Class
