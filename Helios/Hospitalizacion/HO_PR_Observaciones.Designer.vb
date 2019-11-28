<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class HO_PR_Observaciones
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
        Me.txt_obs = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.ubtn_Cancelar = New Infragistics.Win.Misc.UltraButton()
        Me.ubtn_Aceptar = New Infragistics.Win.Misc.UltraButton()
        CType(Me.txt_obs, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txt_obs
        '
        Me.txt_obs.Location = New System.Drawing.Point(12, 12)
        Me.txt_obs.Multiline = True
        Me.txt_obs.Name = "txt_obs"
        Me.txt_obs.Size = New System.Drawing.Size(297, 113)
        Me.txt_obs.TabIndex = 2
        '
        'ubtn_Cancelar
        '
        Me.ubtn_Cancelar.Location = New System.Drawing.Point(234, 131)
        Me.ubtn_Cancelar.Name = "ubtn_Cancelar"
        Me.ubtn_Cancelar.Size = New System.Drawing.Size(75, 23)
        Me.ubtn_Cancelar.TabIndex = 4
        Me.ubtn_Cancelar.Text = "Cancelar"
        '
        'ubtn_Aceptar
        '
        Me.ubtn_Aceptar.Location = New System.Drawing.Point(153, 131)
        Me.ubtn_Aceptar.Name = "ubtn_Aceptar"
        Me.ubtn_Aceptar.Size = New System.Drawing.Size(75, 23)
        Me.ubtn_Aceptar.TabIndex = 3
        Me.ubtn_Aceptar.Text = "Aceptar"
        '
        'HO_PR_Observaciones
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(319, 162)
        Me.Controls.Add(Me.txt_obs)
        Me.Controls.Add(Me.ubtn_Cancelar)
        Me.Controls.Add(Me.ubtn_Aceptar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "HO_PR_Observaciones"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Observaciones"
        CType(Me.txt_obs, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txt_obs As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents ubtn_Cancelar As Infragistics.Win.Misc.UltraButton
    Friend WithEvents ubtn_Aceptar As Infragistics.Win.Misc.UltraButton
End Class
