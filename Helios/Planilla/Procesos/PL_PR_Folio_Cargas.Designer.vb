<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PL_PR_Folio_Cargas
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
        Dim Appearance8 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance28 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance2 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance7 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance6 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance1 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Me.UltraLabel1 = New Infragistics.Win.Misc.UltraLabel()
        Me.uce_Folios_origen = New Infragistics.Win.UltraWinEditors.UltraComboEditor()
        Me.ubtn_siguiente = New Infragistics.Win.Misc.UltraButton()
        Me.ubtn_previo = New Infragistics.Win.Misc.UltraButton()
        Me.udte_fecha = New Infragistics.Win.UltraWinEditors.UltraDateTimeEditor()
        Me.UltraLabel2 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraLabel3 = New Infragistics.Win.Misc.UltraLabel()
        Me.une_porcentaje = New Infragistics.Win.UltraWinEditors.UltraNumericEditor()
        Me.ubtn_Aceptar = New Infragistics.Win.Misc.UltraButton()
        Me.ubtn_Cancelar = New Infragistics.Win.Misc.UltraButton()
        Me.UltraGroupBox1 = New Infragistics.Win.Misc.UltraGroupBox()
        Me.UltraLabel4 = New Infragistics.Win.Misc.UltraLabel()
        Me.lbl_mensaje = New Infragistics.Win.Misc.UltraLabel()
        CType(Me.uce_Folios_origen, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.udte_fecha, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.une_porcentaje, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UltraGroupBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraGroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'UltraLabel1
        '
        Appearance3.BackColor = System.Drawing.Color.Transparent
        Appearance3.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel1.Appearance = Appearance3
        Me.UltraLabel1.AutoSize = True
        Me.UltraLabel1.Location = New System.Drawing.Point(12, 18)
        Me.UltraLabel1.Name = "UltraLabel1"
        Me.UltraLabel1.Size = New System.Drawing.Size(87, 14)
        Me.UltraLabel1.TabIndex = 0
        Me.UltraLabel1.Text = "Folio Referencia"
        '
        'uce_Folios_origen
        '
        Me.uce_Folios_origen.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.uce_Folios_origen.Location = New System.Drawing.Point(120, 14)
        Me.uce_Folios_origen.Name = "uce_Folios_origen"
        Me.uce_Folios_origen.Size = New System.Drawing.Size(348, 21)
        Me.uce_Folios_origen.TabIndex = 0
        '
        'ubtn_siguiente
        '
        Appearance8.ImageHAlign = Infragistics.Win.HAlign.Center
        Appearance8.ImageVAlign = Infragistics.Win.VAlign.Middle
        Me.ubtn_siguiente.Appearance = Appearance8
        Me.ubtn_siguiente.Location = New System.Drawing.Point(278, 41)
        Me.ubtn_siguiente.Name = "ubtn_siguiente"
        Me.ubtn_siguiente.Size = New System.Drawing.Size(25, 22)
        Me.ubtn_siguiente.TabIndex = 19
        '
        'ubtn_previo
        '
        Appearance28.ImageHAlign = Infragistics.Win.HAlign.Center
        Appearance28.ImageVAlign = Infragistics.Win.VAlign.Middle
        Me.ubtn_previo.Appearance = Appearance28
        Me.ubtn_previo.Location = New System.Drawing.Point(254, 41)
        Me.ubtn_previo.Name = "ubtn_previo"
        Me.ubtn_previo.Size = New System.Drawing.Size(25, 22)
        Me.ubtn_previo.TabIndex = 20
        '
        'udte_fecha
        '
        Me.udte_fecha.FormatString = "MMMM  /  yyyy"
        Me.udte_fecha.Location = New System.Drawing.Point(120, 41)
        Me.udte_fecha.Name = "udte_fecha"
        Me.udte_fecha.Size = New System.Drawing.Size(128, 21)
        Me.udte_fecha.TabIndex = 1
        '
        'UltraLabel2
        '
        Appearance2.BackColor = System.Drawing.Color.Transparent
        Appearance2.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel2.Appearance = Appearance2
        Me.UltraLabel2.AutoSize = True
        Me.UltraLabel2.Location = New System.Drawing.Point(12, 48)
        Me.UltraLabel2.Name = "UltraLabel2"
        Me.UltraLabel2.Size = New System.Drawing.Size(101, 14)
        Me.UltraLabel2.TabIndex = 0
        Me.UltraLabel2.Text = "Periodo Referencia"
        '
        'UltraLabel3
        '
        Appearance7.BackColor = System.Drawing.Color.Transparent
        Appearance7.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel3.Appearance = Appearance7
        Me.UltraLabel3.AutoSize = True
        Me.UltraLabel3.Location = New System.Drawing.Point(12, 77)
        Me.UltraLabel3.Name = "UltraLabel3"
        Me.UltraLabel3.Size = New System.Drawing.Size(58, 14)
        Me.UltraLabel3.TabIndex = 0
        Me.UltraLabel3.Text = "Porcentaje"
        '
        'une_porcentaje
        '
        Me.une_porcentaje.Location = New System.Drawing.Point(120, 73)
        Me.une_porcentaje.Name = "une_porcentaje"
        Me.une_porcentaje.Size = New System.Drawing.Size(89, 21)
        Me.une_porcentaje.TabIndex = 2
        '
        'ubtn_Aceptar
        '
        Me.ubtn_Aceptar.Location = New System.Drawing.Point(334, 130)
        Me.ubtn_Aceptar.Name = "ubtn_Aceptar"
        Me.ubtn_Aceptar.Size = New System.Drawing.Size(85, 27)
        Me.ubtn_Aceptar.TabIndex = 0
        Me.ubtn_Aceptar.Text = "&Aceptar"
        '
        'ubtn_Cancelar
        '
        Me.ubtn_Cancelar.Location = New System.Drawing.Point(420, 130)
        Me.ubtn_Cancelar.Name = "ubtn_Cancelar"
        Me.ubtn_Cancelar.Size = New System.Drawing.Size(85, 27)
        Me.ubtn_Cancelar.TabIndex = 1
        Me.ubtn_Cancelar.Text = "&Cancelar"
        '
        'UltraGroupBox1
        '
        Me.UltraGroupBox1.Controls.Add(Me.UltraLabel4)
        Me.UltraGroupBox1.Controls.Add(Me.une_porcentaje)
        Me.UltraGroupBox1.Controls.Add(Me.ubtn_siguiente)
        Me.UltraGroupBox1.Controls.Add(Me.ubtn_previo)
        Me.UltraGroupBox1.Controls.Add(Me.udte_fecha)
        Me.UltraGroupBox1.Controls.Add(Me.uce_Folios_origen)
        Me.UltraGroupBox1.Controls.Add(Me.UltraLabel3)
        Me.UltraGroupBox1.Controls.Add(Me.UltraLabel2)
        Me.UltraGroupBox1.Controls.Add(Me.UltraLabel1)
        Me.UltraGroupBox1.Location = New System.Drawing.Point(16, 13)
        Me.UltraGroupBox1.Name = "UltraGroupBox1"
        Me.UltraGroupBox1.Size = New System.Drawing.Size(489, 111)
        Me.UltraGroupBox1.TabIndex = 24
        '
        'UltraLabel4
        '
        Appearance6.BackColor = System.Drawing.Color.Transparent
        Appearance6.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel4.Appearance = Appearance6
        Me.UltraLabel4.AutoSize = True
        Me.UltraLabel4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel4.Location = New System.Drawing.Point(215, 77)
        Me.UltraLabel4.Name = "UltraLabel4"
        Me.UltraLabel4.Size = New System.Drawing.Size(14, 14)
        Me.UltraLabel4.TabIndex = 21
        Me.UltraLabel4.Text = "%"
        '
        'lbl_mensaje
        '
        Appearance1.BackColor = System.Drawing.Color.Transparent
        Appearance1.ForeColor = System.Drawing.Color.Navy
        Me.lbl_mensaje.Appearance = Appearance1
        Me.lbl_mensaje.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_mensaje.Location = New System.Drawing.Point(16, 128)
        Me.lbl_mensaje.Name = "lbl_mensaje"
        Me.lbl_mensaje.Size = New System.Drawing.Size(312, 30)
        Me.lbl_mensaje.TabIndex = 0
        Me.lbl_mensaje.Text = "Porcentaje"
        '
        'PL_PR_Folio_Cargas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(517, 164)
        Me.Controls.Add(Me.UltraGroupBox1)
        Me.Controls.Add(Me.ubtn_Cancelar)
        Me.Controls.Add(Me.ubtn_Aceptar)
        Me.Controls.Add(Me.lbl_mensaje)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "PL_PR_Folio_Cargas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cargar desde otro Folio..."
        CType(Me.uce_Folios_origen, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.udte_fecha, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.une_porcentaje, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UltraGroupBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraGroupBox1.ResumeLayout(False)
        Me.UltraGroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents UltraLabel1 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents uce_Folios_origen As Infragistics.Win.UltraWinEditors.UltraComboEditor
    Friend WithEvents ubtn_siguiente As Infragistics.Win.Misc.UltraButton
    Friend WithEvents ubtn_previo As Infragistics.Win.Misc.UltraButton
    Friend WithEvents udte_fecha As Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
    Friend WithEvents UltraLabel2 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel3 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents une_porcentaje As Infragistics.Win.UltraWinEditors.UltraNumericEditor
    Friend WithEvents ubtn_Aceptar As Infragistics.Win.Misc.UltraButton
    Friend WithEvents ubtn_Cancelar As Infragistics.Win.Misc.UltraButton
    Friend WithEvents UltraGroupBox1 As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents lbl_mensaje As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel4 As Infragistics.Win.Misc.UltraLabel
End Class
