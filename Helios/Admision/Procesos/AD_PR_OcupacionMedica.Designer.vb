<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AD_PR_OcupacionMedica
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
        Dim Appearance7 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance8 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance9 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance10 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance12 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance14 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance5 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Me.ToolS_Mantenimiento = New System.Windows.Forms.ToolStrip()
        Me.Tool_Grabar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.Tool_Eliminar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator()
        Me.Tool_Salir = New System.Windows.Forms.ToolStripButton()
        Me.ugb_Datos = New Infragistics.Win.Misc.UltraGroupBox()
        Me.txt_Descripcion = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.UltraLabel13 = New Infragistics.Win.Misc.UltraLabel()
        Me.udte_fecha = New Infragistics.Win.UltraWinEditors.UltraDateTimeEditor()
        Me.txt_idOcupacion = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.txt_idprogramacion = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.txt_Medico = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.UltraLabel6 = New Infragistics.Win.Misc.UltraLabel()
        Me.txt_Servicio = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.UltraLabel5 = New Infragistics.Win.Misc.UltraLabel()
        Me.txt_Orden = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.UltraLabel4 = New Infragistics.Win.Misc.UltraLabel()
        Me.txt_Hora = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.UltraLabel3 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraLabel1 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraLabel2 = New Infragistics.Win.Misc.UltraLabel()
        Me.ToolS_Mantenimiento.SuspendLayout()
        CType(Me.ugb_Datos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ugb_Datos.SuspendLayout()
        CType(Me.txt_Descripcion, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.udte_fecha, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_idOcupacion, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_idprogramacion, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_Medico, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_Servicio, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_Orden, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_Hora, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ToolS_Mantenimiento
        '
        Me.ToolS_Mantenimiento.BackColor = System.Drawing.Color.White
        Me.ToolS_Mantenimiento.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Tool_Grabar, Me.ToolStripSeparator3, Me.Tool_Eliminar, Me.ToolStripSeparator5, Me.Tool_Salir})
        Me.ToolS_Mantenimiento.Location = New System.Drawing.Point(0, 0)
        Me.ToolS_Mantenimiento.Name = "ToolS_Mantenimiento"
        Me.ToolS_Mantenimiento.Size = New System.Drawing.Size(644, 25)
        Me.ToolS_Mantenimiento.TabIndex = 35
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
        'Tool_Eliminar
        '
        Me.Tool_Eliminar.Image = Global.Contabilidad.My.Resources.Resources._16__Delete_
        Me.Tool_Eliminar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Tool_Eliminar.Name = "Tool_Eliminar"
        Me.Tool_Eliminar.Size = New System.Drawing.Size(70, 22)
        Me.Tool_Eliminar.Text = "Eliminar"
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
        Me.Tool_Salir.Size = New System.Drawing.Size(49, 22)
        Me.Tool_Salir.Text = "Salir"
        '
        'ugb_Datos
        '
        Me.ugb_Datos.Controls.Add(Me.txt_Descripcion)
        Me.ugb_Datos.Controls.Add(Me.UltraLabel13)
        Me.ugb_Datos.Controls.Add(Me.udte_fecha)
        Me.ugb_Datos.Controls.Add(Me.txt_idOcupacion)
        Me.ugb_Datos.Controls.Add(Me.txt_idprogramacion)
        Me.ugb_Datos.Controls.Add(Me.txt_Medico)
        Me.ugb_Datos.Controls.Add(Me.UltraLabel6)
        Me.ugb_Datos.Controls.Add(Me.txt_Servicio)
        Me.ugb_Datos.Controls.Add(Me.UltraLabel5)
        Me.ugb_Datos.Controls.Add(Me.txt_Orden)
        Me.ugb_Datos.Controls.Add(Me.UltraLabel4)
        Me.ugb_Datos.Controls.Add(Me.txt_Hora)
        Me.ugb_Datos.Controls.Add(Me.UltraLabel3)
        Me.ugb_Datos.Controls.Add(Me.UltraLabel1)
        Me.ugb_Datos.Controls.Add(Me.UltraLabel2)
        Me.ugb_Datos.Location = New System.Drawing.Point(9, 35)
        Me.ugb_Datos.Name = "ugb_Datos"
        Me.ugb_Datos.Size = New System.Drawing.Size(627, 198)
        Me.ugb_Datos.TabIndex = 34
        '
        'txt_Descripcion
        '
        Me.txt_Descripcion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_Descripcion.Location = New System.Drawing.Point(87, 114)
        Me.txt_Descripcion.MaxLength = 250
        Me.txt_Descripcion.Multiline = True
        Me.txt_Descripcion.Name = "txt_Descripcion"
        Me.txt_Descripcion.Size = New System.Drawing.Size(524, 68)
        Me.txt_Descripcion.TabIndex = 145
        '
        'UltraLabel13
        '
        Appearance7.BackColor = System.Drawing.Color.Transparent
        Appearance7.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel13.Appearance = Appearance7
        Me.UltraLabel13.AutoSize = True
        Me.UltraLabel13.Location = New System.Drawing.Point(13, 118)
        Me.UltraLabel13.Name = "UltraLabel13"
        Me.UltraLabel13.Size = New System.Drawing.Size(63, 14)
        Me.UltraLabel13.TabIndex = 146
        Me.UltraLabel13.Text = "Descripción"
        '
        'udte_fecha
        '
        Me.udte_fecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.udte_fecha.Location = New System.Drawing.Point(63, 41)
        Me.udte_fecha.Name = "udte_fecha"
        Me.udte_fecha.ReadOnly = True
        Me.udte_fecha.Size = New System.Drawing.Size(102, 24)
        Me.udte_fecha.TabIndex = 135
        '
        'txt_idOcupacion
        '
        Me.txt_idOcupacion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_idOcupacion.Location = New System.Drawing.Point(569, 41)
        Me.txt_idOcupacion.MaxLength = 50
        Me.txt_idOcupacion.Name = "txt_idOcupacion"
        Me.txt_idOcupacion.ReadOnly = True
        Me.txt_idOcupacion.Size = New System.Drawing.Size(20, 21)
        Me.txt_idOcupacion.TabIndex = 134
        Me.txt_idOcupacion.Visible = False
        '
        'txt_idprogramacion
        '
        Me.txt_idprogramacion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_idprogramacion.Location = New System.Drawing.Point(591, 41)
        Me.txt_idprogramacion.MaxLength = 50
        Me.txt_idprogramacion.Name = "txt_idprogramacion"
        Me.txt_idprogramacion.ReadOnly = True
        Me.txt_idprogramacion.Size = New System.Drawing.Size(20, 21)
        Me.txt_idprogramacion.TabIndex = 130
        Me.txt_idprogramacion.Visible = False
        '
        'txt_Medico
        '
        Me.txt_Medico.Location = New System.Drawing.Point(373, 79)
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
        Me.UltraLabel6.Location = New System.Drawing.Point(317, 83)
        Me.UltraLabel6.Name = "UltraLabel6"
        Me.UltraLabel6.Size = New System.Drawing.Size(41, 14)
        Me.UltraLabel6.TabIndex = 36
        Me.UltraLabel6.Text = "Médico"
        '
        'txt_Servicio
        '
        Me.txt_Servicio.Location = New System.Drawing.Point(63, 79)
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
        Me.UltraLabel5.Location = New System.Drawing.Point(13, 83)
        Me.UltraLabel5.Name = "UltraLabel5"
        Me.UltraLabel5.Size = New System.Drawing.Size(45, 14)
        Me.UltraLabel5.TabIndex = 34
        Me.UltraLabel5.Text = "Servicio"
        '
        'txt_Orden
        '
        Me.txt_Orden.Location = New System.Drawing.Point(373, 44)
        Me.txt_Orden.MaxLength = 5
        Me.txt_Orden.Name = "txt_Orden"
        Me.txt_Orden.ReadOnly = True
        Me.txt_Orden.Size = New System.Drawing.Size(65, 21)
        Me.txt_Orden.TabIndex = 33
        '
        'UltraLabel4
        '
        Appearance10.BackColor = System.Drawing.Color.Transparent
        Appearance10.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel4.Appearance = Appearance10
        Me.UltraLabel4.AutoSize = True
        Me.UltraLabel4.Location = New System.Drawing.Point(317, 48)
        Me.UltraLabel4.Name = "UltraLabel4"
        Me.UltraLabel4.Size = New System.Drawing.Size(51, 14)
        Me.UltraLabel4.TabIndex = 32
        Me.UltraLabel4.Text = "Nº Orden"
        '
        'txt_Hora
        '
        Me.txt_Hora.Location = New System.Drawing.Point(231, 44)
        Me.txt_Hora.MaxLength = 5
        Me.txt_Hora.Name = "txt_Hora"
        Me.txt_Hora.ReadOnly = True
        Me.txt_Hora.Size = New System.Drawing.Size(70, 21)
        Me.txt_Hora.TabIndex = 30
        '
        'UltraLabel3
        '
        Appearance12.BackColor = System.Drawing.Color.Transparent
        Appearance12.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel3.Appearance = Appearance12
        Me.UltraLabel3.AutoSize = True
        Me.UltraLabel3.Location = New System.Drawing.Point(171, 48)
        Me.UltraLabel3.Name = "UltraLabel3"
        Me.UltraLabel3.Size = New System.Drawing.Size(59, 14)
        Me.UltraLabel3.TabIndex = 28
        Me.UltraLabel3.Text = "Hora Prog."
        '
        'UltraLabel1
        '
        Appearance14.BackColor = System.Drawing.Color.Transparent
        Appearance14.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel1.Appearance = Appearance14
        Me.UltraLabel1.AutoSize = True
        Me.UltraLabel1.Location = New System.Drawing.Point(13, 48)
        Me.UltraLabel1.Name = "UltraLabel1"
        Me.UltraLabel1.Size = New System.Drawing.Size(36, 14)
        Me.UltraLabel1.TabIndex = 29
        Me.UltraLabel1.Text = "Fecha"
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
        Me.UltraLabel2.Text = "Ocupación Medica"
        '
        'AD_PR_OcupacionMedica
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(644, 240)
        Me.Controls.Add(Me.ToolS_Mantenimiento)
        Me.Controls.Add(Me.ugb_Datos)
        Me.Name = "AD_PR_OcupacionMedica"
        Me.Text = "Ocupaciones Medicas"
        Me.ToolS_Mantenimiento.ResumeLayout(False)
        Me.ToolS_Mantenimiento.PerformLayout()
        CType(Me.ugb_Datos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ugb_Datos.ResumeLayout(False)
        Me.ugb_Datos.PerformLayout()
        CType(Me.txt_Descripcion, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.udte_fecha, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_idOcupacion, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_idprogramacion, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_Medico, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_Servicio, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_Orden, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_Hora, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolS_Mantenimiento As System.Windows.Forms.ToolStrip
    Friend WithEvents Tool_Grabar As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents Tool_Eliminar As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator5 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents Tool_Salir As System.Windows.Forms.ToolStripButton
    Friend WithEvents ugb_Datos As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents udte_fecha As Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
    Friend WithEvents txt_idOcupacion As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents txt_idprogramacion As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents txt_Medico As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents UltraLabel6 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents txt_Servicio As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents UltraLabel5 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents txt_Orden As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents UltraLabel4 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents txt_Hora As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents UltraLabel3 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel1 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel2 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents txt_Descripcion As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents UltraLabel13 As Infragistics.Win.Misc.UltraLabel
End Class
