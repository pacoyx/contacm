<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PL_MA_Compatibilidad
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
        Dim Appearance1 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PL_MA_Compatibilidad))
        Me.ubtn_cerrar = New Infragistics.Win.Misc.UltraButton
        Me.UltraPictureBox1 = New Infragistics.Win.UltraWinEditors.UltraPictureBox
        Me.SuspendLayout()
        '
        'ubtn_cerrar
        '
        Appearance1.Image = Global.Contabilidad.My.Resources.Resources._28
        Me.ubtn_cerrar.Appearance = Appearance1
        Me.ubtn_cerrar.Location = New System.Drawing.Point(301, 271)
        Me.ubtn_cerrar.Name = "ubtn_cerrar"
        Me.ubtn_cerrar.Size = New System.Drawing.Size(92, 25)
        Me.ubtn_cerrar.TabIndex = 1
        Me.ubtn_cerrar.Text = "&Cerrar"
        '
        'UltraPictureBox1
        '
        Me.UltraPictureBox1.AutoSize = True
        Me.UltraPictureBox1.BorderShadowColor = System.Drawing.Color.Empty
        Me.UltraPictureBox1.Image = CType(resources.GetObject("UltraPictureBox1.Image"), Object)
        Me.UltraPictureBox1.Location = New System.Drawing.Point(4, 7)
        Me.UltraPictureBox1.Name = "UltraPictureBox1"
        Me.UltraPictureBox1.Size = New System.Drawing.Size(397, 259)
        Me.UltraPictureBox1.TabIndex = 0
        '
        'PL_MA_Compatibilidad
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(405, 306)
        Me.Controls.Add(Me.ubtn_cerrar)
        Me.Controls.Add(Me.UltraPictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "PL_MA_Compatibilidad"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Tabla de Compatibilidad"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents UltraPictureBox1 As Infragistics.Win.UltraWinEditors.UltraPictureBox
    Friend WithEvents ubtn_cerrar As Infragistics.Win.Misc.UltraButton
End Class
