<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AD_PR_PostergarAtencion
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
        Dim Appearance2 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance7 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance1 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance41 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance4 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim EditorButton2 As Infragistics.Win.UltraWinEditors.EditorButton = New Infragistics.Win.UltraWinEditors.EditorButton("ayuda")
        Dim Appearance6 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance10 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance8 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance9 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance5 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Me.ugb_Datos = New Infragistics.Win.Misc.UltraGroupBox()
        Me.uce_MedicoC = New Infragistics.Win.UltraWinEditors.UltraComboEditor()
        Me.UltraLabel4 = New Infragistics.Win.Misc.UltraLabel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.UltraLabel3 = New Infragistics.Win.Misc.UltraLabel()
        Me.txt_Observacion = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.UltraLabel1 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraLabel11 = New Infragistics.Win.Misc.UltraLabel()
        Me.ucbo_Turno = New Infragistics.Win.UltraWinEditors.UltraComboEditor()
        Me.ume_HoraLLegada = New Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit()
        Me.udte_fechaP = New Infragistics.Win.UltraWinEditors.UltraDateTimeEditor()
        Me.uce_Medico = New Infragistics.Win.UltraWinEditors.UltraComboEditor()
        Me.UltraLabel8 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraLabel13 = New Infragistics.Win.Misc.UltraLabel()
        Me.txt_idCita = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.uce_tip_doc = New Infragistics.Win.UltraWinEditors.UltraComboEditor()
        Me.txt_Des_Cliente = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.txt_ruc_cliente = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.UltraLabel7 = New Infragistics.Win.Misc.UltraLabel()
        Me.txt_Medico = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.UltraLabel6 = New Infragistics.Win.Misc.UltraLabel()
        Me.txt_Servicio = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.UltraLabel5 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraLabel2 = New Infragistics.Win.Misc.UltraLabel()
        Me.txt_IdCliente = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.txt_idHistoria = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.ToolS_Mantenimiento = New System.Windows.Forms.ToolStrip()
        Me.Tool_Grabar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.Tool_Salir = New System.Windows.Forms.ToolStripButton()
        CType(Me.ugb_Datos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ugb_Datos.SuspendLayout()
        CType(Me.uce_MedicoC, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_Observacion, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ucbo_Turno, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.udte_fechaP, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.uce_Medico, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_idCita, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.uce_tip_doc, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_Des_Cliente, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_ruc_cliente, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_Medico, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_Servicio, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_IdCliente, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_idHistoria, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolS_Mantenimiento.SuspendLayout()
        Me.SuspendLayout()
        '
        'ugb_Datos
        '
        Me.ugb_Datos.Controls.Add(Me.uce_MedicoC)
        Me.ugb_Datos.Controls.Add(Me.UltraLabel4)
        Me.ugb_Datos.Controls.Add(Me.Panel1)
        Me.ugb_Datos.Controls.Add(Me.UltraLabel3)
        Me.ugb_Datos.Controls.Add(Me.txt_Observacion)
        Me.ugb_Datos.Controls.Add(Me.UltraLabel1)
        Me.ugb_Datos.Controls.Add(Me.UltraLabel11)
        Me.ugb_Datos.Controls.Add(Me.ucbo_Turno)
        Me.ugb_Datos.Controls.Add(Me.ume_HoraLLegada)
        Me.ugb_Datos.Controls.Add(Me.udte_fechaP)
        Me.ugb_Datos.Controls.Add(Me.uce_Medico)
        Me.ugb_Datos.Controls.Add(Me.UltraLabel8)
        Me.ugb_Datos.Controls.Add(Me.UltraLabel13)
        Me.ugb_Datos.Controls.Add(Me.txt_idCita)
        Me.ugb_Datos.Controls.Add(Me.uce_tip_doc)
        Me.ugb_Datos.Controls.Add(Me.txt_Des_Cliente)
        Me.ugb_Datos.Controls.Add(Me.txt_ruc_cliente)
        Me.ugb_Datos.Controls.Add(Me.UltraLabel7)
        Me.ugb_Datos.Controls.Add(Me.txt_Medico)
        Me.ugb_Datos.Controls.Add(Me.UltraLabel6)
        Me.ugb_Datos.Controls.Add(Me.txt_Servicio)
        Me.ugb_Datos.Controls.Add(Me.UltraLabel5)
        Me.ugb_Datos.Controls.Add(Me.UltraLabel2)
        Me.ugb_Datos.Controls.Add(Me.txt_IdCliente)
        Me.ugb_Datos.Controls.Add(Me.txt_idHistoria)
        Me.ugb_Datos.Location = New System.Drawing.Point(12, 28)
        Me.ugb_Datos.Name = "ugb_Datos"
        Me.ugb_Datos.Size = New System.Drawing.Size(627, 283)
        Me.ugb_Datos.TabIndex = 30
        '
        'uce_MedicoC
        '
        Me.uce_MedicoC.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.uce_MedicoC.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.uce_MedicoC.Location = New System.Drawing.Point(295, 177)
        Me.uce_MedicoC.MaxDropDownItems = 12
        Me.uce_MedicoC.Name = "uce_MedicoC"
        Me.uce_MedicoC.Size = New System.Drawing.Size(316, 21)
        Me.uce_MedicoC.TabIndex = 184
        '
        'UltraLabel4
        '
        Appearance3.BackColor = System.Drawing.Color.Transparent
        Appearance3.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel4.Appearance = Appearance3
        Me.UltraLabel4.AutoSize = True
        Me.UltraLabel4.Location = New System.Drawing.Point(253, 181)
        Me.UltraLabel4.Name = "UltraLabel4"
        Me.UltraLabel4.Size = New System.Drawing.Size(41, 14)
        Me.UltraLabel4.TabIndex = 185
        Me.UltraLabel4.Text = "Medico"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.Panel1.Location = New System.Drawing.Point(13, 155)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(600, 2)
        Me.Panel1.TabIndex = 183
        '
        'UltraLabel3
        '
        Appearance2.BackColor = System.Drawing.Color.Transparent
        Appearance2.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel3.Appearance = Appearance2
        Me.UltraLabel3.AutoSize = True
        Me.UltraLabel3.Location = New System.Drawing.Point(253, 216)
        Me.UltraLabel3.Name = "UltraLabel3"
        Me.UltraLabel3.Size = New System.Drawing.Size(91, 14)
        Me.UltraLabel3.TabIndex = 182
        Me.UltraLabel3.Text = "Hora de LLegada"
        '
        'txt_Observacion
        '
        Me.txt_Observacion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_Observacion.Location = New System.Drawing.Point(95, 243)
        Me.txt_Observacion.MaxLength = 100
        Me.txt_Observacion.Name = "txt_Observacion"
        Me.txt_Observacion.Size = New System.Drawing.Size(516, 21)
        Me.txt_Observacion.TabIndex = 3
        '
        'UltraLabel1
        '
        Appearance7.BackColor = System.Drawing.Color.Transparent
        Appearance7.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel1.Appearance = Appearance7
        Me.UltraLabel1.AutoSize = True
        Me.UltraLabel1.Location = New System.Drawing.Point(23, 247)
        Me.UltraLabel1.Name = "UltraLabel1"
        Me.UltraLabel1.Size = New System.Drawing.Size(68, 14)
        Me.UltraLabel1.TabIndex = 181
        Me.UltraLabel1.Text = "Observacion"
        '
        'UltraLabel11
        '
        Appearance1.BackColor = System.Drawing.Color.Transparent
        Appearance1.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel11.Appearance = Appearance1
        Me.UltraLabel11.AutoSize = True
        Me.UltraLabel11.Location = New System.Drawing.Point(25, 216)
        Me.UltraLabel11.Name = "UltraLabel11"
        Me.UltraLabel11.Size = New System.Drawing.Size(34, 14)
        Me.UltraLabel11.TabIndex = 179
        Me.UltraLabel11.Text = "Turno"
        '
        'ucbo_Turno
        '
        Me.ucbo_Turno.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.ucbo_Turno.Location = New System.Drawing.Point(77, 212)
        Me.ucbo_Turno.Name = "ucbo_Turno"
        Me.ucbo_Turno.Size = New System.Drawing.Size(161, 21)
        Me.ucbo_Turno.TabIndex = 1
        '
        'ume_HoraLLegada
        '
        Me.ume_HoraLLegada.EditAs = Infragistics.Win.UltraWinMaskedEdit.EditAsType.UseSpecifiedMask
        Me.ume_HoraLLegada.InputMask = "{LOC}hh:mm"
        Me.ume_HoraLLegada.Location = New System.Drawing.Point(352, 212)
        Me.ume_HoraLLegada.Name = "ume_HoraLLegada"
        Me.ume_HoraLLegada.Size = New System.Drawing.Size(49, 20)
        Me.ume_HoraLLegada.TabIndex = 2
        Me.ume_HoraLLegada.Text = "UltraMaskedEdit1"
        '
        'udte_fechaP
        '
        Me.udte_fechaP.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.udte_fechaP.Location = New System.Drawing.Point(77, 177)
        Me.udte_fechaP.Name = "udte_fechaP"
        Me.udte_fechaP.Size = New System.Drawing.Size(161, 24)
        Me.udte_fechaP.TabIndex = 0
        '
        'uce_Medico
        '
        Me.uce_Medico.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Suggest
        Me.uce_Medico.Location = New System.Drawing.Point(126, 115)
        Me.uce_Medico.Name = "uce_Medico"
        Me.uce_Medico.ReadOnly = True
        Me.uce_Medico.Size = New System.Drawing.Size(485, 21)
        Me.uce_Medico.TabIndex = 175
        '
        'UltraLabel8
        '
        Appearance41.BackColor = System.Drawing.Color.Transparent
        Appearance41.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel8.Appearance = Appearance41
        Me.UltraLabel8.AutoSize = True
        Me.UltraLabel8.Location = New System.Drawing.Point(13, 119)
        Me.UltraLabel8.Name = "UltraLabel8"
        Me.UltraLabel8.Size = New System.Drawing.Size(92, 14)
        Me.UltraLabel8.TabIndex = 174
        Me.UltraLabel8.Text = "Médico Derivante"
        '
        'UltraLabel13
        '
        Appearance4.BackColor = System.Drawing.Color.Transparent
        Appearance4.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel13.Appearance = Appearance4
        Me.UltraLabel13.AutoSize = True
        Me.UltraLabel13.Location = New System.Drawing.Point(27, 184)
        Me.UltraLabel13.Name = "UltraLabel13"
        Me.UltraLabel13.Size = New System.Drawing.Size(36, 14)
        Me.UltraLabel13.TabIndex = 29
        Me.UltraLabel13.Text = "Fecha"
        '
        'txt_idCita
        '
        Me.txt_idCita.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_idCita.Location = New System.Drawing.Point(604, 33)
        Me.txt_idCita.MaxLength = 50
        Me.txt_idCita.Name = "txt_idCita"
        Me.txt_idCita.ReadOnly = True
        Me.txt_idCita.Size = New System.Drawing.Size(20, 21)
        Me.txt_idCita.TabIndex = 134
        Me.txt_idCita.Visible = False
        '
        'uce_tip_doc
        '
        Me.uce_tip_doc.DropDownListWidth = 300
        Me.uce_tip_doc.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.uce_tip_doc.Location = New System.Drawing.Point(63, 83)
        Me.uce_tip_doc.Name = "uce_tip_doc"
        Me.uce_tip_doc.ReadOnly = True
        Me.uce_tip_doc.Size = New System.Drawing.Size(63, 21)
        Me.uce_tip_doc.TabIndex = 131
        '
        'txt_Des_Cliente
        '
        Me.txt_Des_Cliente.Location = New System.Drawing.Point(229, 83)
        Me.txt_Des_Cliente.Name = "txt_Des_Cliente"
        Me.txt_Des_Cliente.ReadOnly = True
        Me.txt_Des_Cliente.Size = New System.Drawing.Size(382, 21)
        Me.txt_Des_Cliente.TabIndex = 128
        '
        'txt_ruc_cliente
        '
        Appearance6.ImageHAlign = Infragistics.Win.HAlign.Center
        Appearance6.ImageVAlign = Infragistics.Win.VAlign.Middle
        EditorButton2.Appearance = Appearance6
        EditorButton2.Key = "ayuda"
        Me.txt_ruc_cliente.ButtonsRight.Add(EditorButton2)
        Me.txt_ruc_cliente.Enabled = False
        Me.txt_ruc_cliente.Location = New System.Drawing.Point(126, 83)
        Me.txt_ruc_cliente.MaxLength = 11
        Me.txt_ruc_cliente.Name = "txt_ruc_cliente"
        Me.txt_ruc_cliente.ReadOnly = True
        Me.txt_ruc_cliente.Size = New System.Drawing.Size(102, 21)
        Me.txt_ruc_cliente.TabIndex = 126
        '
        'UltraLabel7
        '
        Appearance10.BackColor = System.Drawing.Color.Transparent
        Appearance10.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel7.Appearance = Appearance10
        Me.UltraLabel7.AutoSize = True
        Me.UltraLabel7.Location = New System.Drawing.Point(13, 87)
        Me.UltraLabel7.Name = "UltraLabel7"
        Me.UltraLabel7.Size = New System.Drawing.Size(48, 14)
        Me.UltraLabel7.TabIndex = 129
        Me.UltraLabel7.Text = "Paciente"
        '
        'txt_Medico
        '
        Me.txt_Medico.Location = New System.Drawing.Point(373, 50)
        Me.txt_Medico.MaxLength = 5
        Me.txt_Medico.Name = "txt_Medico"
        Me.txt_Medico.ReadOnly = True
        Me.txt_Medico.Size = New System.Drawing.Size(238, 21)
        Me.txt_Medico.TabIndex = 37
        '
        'UltraLabel6
        '
        Appearance8.BackColor = System.Drawing.Color.Transparent
        Appearance8.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel6.Appearance = Appearance8
        Me.UltraLabel6.AutoSize = True
        Me.UltraLabel6.Location = New System.Drawing.Point(317, 54)
        Me.UltraLabel6.Name = "UltraLabel6"
        Me.UltraLabel6.Size = New System.Drawing.Size(41, 14)
        Me.UltraLabel6.TabIndex = 36
        Me.UltraLabel6.Text = "Médico"
        '
        'txt_Servicio
        '
        Me.txt_Servicio.Location = New System.Drawing.Point(63, 50)
        Me.txt_Servicio.MaxLength = 5
        Me.txt_Servicio.Name = "txt_Servicio"
        Me.txt_Servicio.ReadOnly = True
        Me.txt_Servicio.Size = New System.Drawing.Size(238, 21)
        Me.txt_Servicio.TabIndex = 35
        '
        'UltraLabel5
        '
        Appearance9.BackColor = System.Drawing.Color.Transparent
        Appearance9.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel5.Appearance = Appearance9
        Me.UltraLabel5.AutoSize = True
        Me.UltraLabel5.Location = New System.Drawing.Point(13, 54)
        Me.UltraLabel5.Name = "UltraLabel5"
        Me.UltraLabel5.Size = New System.Drawing.Size(45, 14)
        Me.UltraLabel5.TabIndex = 34
        Me.UltraLabel5.Text = "Servicio"
        '
        'UltraLabel2
        '
        Appearance5.BackColor = System.Drawing.Color.DeepSkyBlue
        Appearance5.ForeColor = System.Drawing.Color.White
        Appearance5.TextHAlignAsString = "Center"
        Me.UltraLabel2.Appearance = Appearance5
        Me.UltraLabel2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel2.Location = New System.Drawing.Point(2, 2)
        Me.UltraLabel2.Name = "UltraLabel2"
        Me.UltraLabel2.Size = New System.Drawing.Size(623, 28)
        Me.UltraLabel2.TabIndex = 27
        Me.UltraLabel2.Text = "Postergar Atención"
        '
        'txt_IdCliente
        '
        Me.txt_IdCliente.Location = New System.Drawing.Point(108, 76)
        Me.txt_IdCliente.Name = "txt_IdCliente"
        Me.txt_IdCliente.Size = New System.Drawing.Size(37, 21)
        Me.txt_IdCliente.TabIndex = 127
        Me.txt_IdCliente.Visible = False
        '
        'txt_idHistoria
        '
        Me.txt_idHistoria.Location = New System.Drawing.Point(151, 76)
        Me.txt_idHistoria.Name = "txt_idHistoria"
        Me.txt_idHistoria.Size = New System.Drawing.Size(37, 21)
        Me.txt_idHistoria.TabIndex = 132
        Me.txt_idHistoria.Visible = False
        '
        'ToolS_Mantenimiento
        '
        Me.ToolS_Mantenimiento.BackColor = System.Drawing.Color.White
        Me.ToolS_Mantenimiento.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Tool_Grabar, Me.ToolStripSeparator3, Me.Tool_Salir})
        Me.ToolS_Mantenimiento.Location = New System.Drawing.Point(0, 0)
        Me.ToolS_Mantenimiento.Name = "ToolS_Mantenimiento"
        Me.ToolS_Mantenimiento.Size = New System.Drawing.Size(651, 25)
        Me.ToolS_Mantenimiento.TabIndex = 4
        Me.ToolS_Mantenimiento.Text = "ToolStrip1"
        '
        'Tool_Grabar
        '
        Me.Tool_Grabar.Image = Global.Contabilidad.My.Resources.Resources._003
        Me.Tool_Grabar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Tool_Grabar.Name = "Tool_Grabar"
        Me.Tool_Grabar.Size = New System.Drawing.Size(62, 22)
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
        Me.Tool_Salir.Size = New System.Drawing.Size(49, 22)
        Me.Tool_Salir.Text = "Salir"
        '
        'AD_PR_PostergarAtencion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(651, 323)
        Me.Controls.Add(Me.ToolS_Mantenimiento)
        Me.Controls.Add(Me.ugb_Datos)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "AD_PR_PostergarAtencion"
        Me.Text = "Postergar Atención"
        CType(Me.ugb_Datos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ugb_Datos.ResumeLayout(False)
        Me.ugb_Datos.PerformLayout()
        CType(Me.uce_MedicoC, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_Observacion, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ucbo_Turno, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.udte_fechaP, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.uce_Medico, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_idCita, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.uce_tip_doc, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_Des_Cliente, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_ruc_cliente, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_Medico, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_Servicio, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_IdCliente, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_idHistoria, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolS_Mantenimiento.ResumeLayout(False)
        Me.ToolS_Mantenimiento.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ugb_Datos As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents UltraLabel2 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents ToolS_Mantenimiento As System.Windows.Forms.ToolStrip
    Friend WithEvents Tool_Grabar As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents Tool_Salir As System.Windows.Forms.ToolStripButton
    Friend WithEvents txt_Medico As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents UltraLabel6 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents txt_Servicio As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents UltraLabel5 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents txt_IdCliente As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents txt_Des_Cliente As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents txt_ruc_cliente As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents UltraLabel7 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents uce_tip_doc As Infragistics.Win.UltraWinEditors.UltraComboEditor
    Friend WithEvents txt_idHistoria As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents UltraLabel13 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents udte_fechaP As Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
    Friend WithEvents txt_idCita As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Public WithEvents uce_Medico As Infragistics.Win.UltraWinEditors.UltraComboEditor
    Friend WithEvents UltraLabel8 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents ume_HoraLLegada As Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit
    Friend WithEvents UltraLabel11 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents ucbo_Turno As Infragistics.Win.UltraWinEditors.UltraComboEditor
    Friend WithEvents txt_Observacion As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents UltraLabel1 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel3 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Public WithEvents uce_MedicoC As Infragistics.Win.UltraWinEditors.UltraComboEditor
    Friend WithEvents UltraLabel4 As Infragistics.Win.Misc.UltraLabel
End Class
