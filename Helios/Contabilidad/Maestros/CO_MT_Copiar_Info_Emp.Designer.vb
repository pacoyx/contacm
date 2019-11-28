<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CO_MT_Copiar_Info_Emp
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
        Me.ubtn_cancelar = New Infragistics.Win.Misc.UltraButton()
        Me.UltraLabel2 = New Infragistics.Win.Misc.UltraLabel()
        Me.ubtn_Aceptar = New Infragistics.Win.Misc.UltraButton()
        Me.UltraGroupBox1 = New Infragistics.Win.Misc.UltraGroupBox()
        Me.uce_empresa = New Infragistics.Win.UltraWinEditors.UltraComboEditor()
        Me.UltraLabel1 = New Infragistics.Win.Misc.UltraLabel()
        CType(Me.UltraGroupBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraGroupBox1.SuspendLayout()
        CType(Me.uce_empresa, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ubtn_cancelar
        '
        Me.ubtn_cancelar.Location = New System.Drawing.Point(426, 145)
        Me.ubtn_cancelar.Name = "ubtn_cancelar"
        Me.ubtn_cancelar.Size = New System.Drawing.Size(75, 25)
        Me.ubtn_cancelar.TabIndex = 8
        Me.ubtn_cancelar.Text = "Cancelar"
        '
        'UltraLabel2
        '
        Appearance2.FontData.BoldAsString = "False"
        Appearance2.FontData.SizeInPoints = 10.0!
        Appearance2.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel2.Appearance = Appearance2
        Me.UltraLabel2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel2.Location = New System.Drawing.Point(12, 12)
        Me.UltraLabel2.Name = "UltraLabel2"
        Me.UltraLabel2.Size = New System.Drawing.Size(489, 60)
        Me.UltraLabel2.TabIndex = 7
        Me.UltraLabel2.Text = "Seleccione la empresa de la cual se copiara la informacion para configurar, esta " & _
    "configuracion consta de Plan de cuentas, documentos, subdiarios, impuestos,, etc" & _
    "."
        '
        'ubtn_Aceptar
        '
        Me.ubtn_Aceptar.Appearance = Appearance1
        Me.ubtn_Aceptar.Location = New System.Drawing.Point(345, 145)
        Me.ubtn_Aceptar.Name = "ubtn_Aceptar"
        Me.ubtn_Aceptar.Size = New System.Drawing.Size(75, 25)
        Me.ubtn_Aceptar.TabIndex = 6
        Me.ubtn_Aceptar.Text = "Aceptar"
        '
        'UltraGroupBox1
        '
        Me.UltraGroupBox1.Controls.Add(Me.uce_empresa)
        Me.UltraGroupBox1.Controls.Add(Me.UltraLabel1)
        Me.UltraGroupBox1.Location = New System.Drawing.Point(12, 78)
        Me.UltraGroupBox1.Name = "UltraGroupBox1"
        Me.UltraGroupBox1.Size = New System.Drawing.Size(489, 61)
        Me.UltraGroupBox1.TabIndex = 5
        '
        'uce_empresa
        '
        Me.uce_empresa.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.uce_empresa.Location = New System.Drawing.Point(75, 22)
        Me.uce_empresa.Name = "uce_empresa"
        Me.uce_empresa.Size = New System.Drawing.Size(268, 21)
        Me.uce_empresa.TabIndex = 1
        '
        'UltraLabel1
        '
        Me.UltraLabel1.AutoSize = True
        Me.UltraLabel1.Location = New System.Drawing.Point(20, 26)
        Me.UltraLabel1.Name = "UltraLabel1"
        Me.UltraLabel1.Size = New System.Drawing.Size(49, 14)
        Me.UltraLabel1.TabIndex = 0
        Me.UltraLabel1.Text = "Empresa"
        '
        'CO_MT_Copiar_Info_Emp
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(515, 180)
        Me.Controls.Add(Me.ubtn_cancelar)
        Me.Controls.Add(Me.UltraLabel2)
        Me.Controls.Add(Me.ubtn_Aceptar)
        Me.Controls.Add(Me.UltraGroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "CO_MT_Copiar_Info_Emp"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Copiar Informacion de Empresas"
        CType(Me.UltraGroupBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraGroupBox1.ResumeLayout(False)
        Me.UltraGroupBox1.PerformLayout()
        CType(Me.uce_empresa, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ubtn_cancelar As Infragistics.Win.Misc.UltraButton
    Friend WithEvents UltraLabel2 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents ubtn_Aceptar As Infragistics.Win.Misc.UltraButton
    Friend WithEvents UltraGroupBox1 As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents uce_empresa As Infragistics.Win.UltraWinEditors.UltraComboEditor
    Friend WithEvents UltraLabel1 As Infragistics.Win.Misc.UltraLabel
End Class
