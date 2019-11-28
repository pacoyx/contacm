<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PL_MA_Opc_Reporte
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
        Dim Appearance1 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance2 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance3 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Me.ubtn_Listado_Gen = New Infragistics.Win.Misc.UltraButton()
        Me.ubtn_Ficha = New Infragistics.Win.Misc.UltraButton()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.uchk_activos = New Infragistics.Win.UltraWinEditors.UltraCheckEditor()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ubtn_Listado_Gen
        '
        Appearance1.ImageBackgroundStyle = Infragistics.Win.ImageBackgroundStyle.Centered
        Appearance1.ImageHAlign = Infragistics.Win.HAlign.Center
        Appearance1.ImageVAlign = Infragistics.Win.VAlign.Top
        Me.ubtn_Listado_Gen.Appearance = Appearance1
        Me.ubtn_Listado_Gen.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ubtn_Listado_Gen.Location = New System.Drawing.Point(27, 42)
        Me.ubtn_Listado_Gen.Name = "ubtn_Listado_Gen"
        Me.ubtn_Listado_Gen.Size = New System.Drawing.Size(116, 50)
        Me.ubtn_Listado_Gen.TabIndex = 0
        Me.ubtn_Listado_Gen.Text = "Listado General"
        '
        'ubtn_Ficha
        '
        Appearance2.ImageHAlign = Infragistics.Win.HAlign.Center
        Appearance2.ImageVAlign = Infragistics.Win.VAlign.Top
        Me.ubtn_Ficha.Appearance = Appearance2
        Me.ubtn_Ficha.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ubtn_Ficha.Location = New System.Drawing.Point(165, 42)
        Me.ubtn_Ficha.Name = "ubtn_Ficha"
        Me.ubtn_Ficha.Size = New System.Drawing.Size(116, 50)
        Me.ubtn_Ficha.TabIndex = 0
        Me.ubtn_Ficha.Text = "Ficha"
        '
        'ToolStrip1
        '
        Me.ToolStrip1.BackColor = System.Drawing.Color.Gainsboro
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton1})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(298, 25)
        Me.ToolStrip1.TabIndex = 1
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.Image = Global.Contabilidad.My.Resources.Resources._28
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(47, 22)
        Me.ToolStripButton1.Text = "Salir"
        '
        'uchk_activos
        '
        Appearance3.ForeColor = System.Drawing.Color.Navy
        Me.uchk_activos.Appearance = Appearance3
        Me.uchk_activos.BackColor = System.Drawing.Color.Transparent
        Me.uchk_activos.BackColorInternal = System.Drawing.Color.Transparent
        Me.uchk_activos.Checked = True
        Me.uchk_activos.CheckState = System.Windows.Forms.CheckState.Checked
        Me.uchk_activos.Location = New System.Drawing.Point(27, 109)
        Me.uchk_activos.Name = "uchk_activos"
        Me.uchk_activos.Size = New System.Drawing.Size(181, 20)
        Me.uchk_activos.TabIndex = 2
        Me.uchk_activos.Text = "Solo Personal Activos"
        '
        'PL_MA_Opc_Reporte
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(298, 141)
        Me.Controls.Add(Me.uchk_activos)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.ubtn_Ficha)
        Me.Controls.Add(Me.ubtn_Listado_Gen)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "PL_MA_Opc_Reporte"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Opc. Reporte"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ubtn_Listado_Gen As Infragistics.Win.Misc.UltraButton
    Friend WithEvents ubtn_Ficha As Infragistics.Win.Misc.UltraButton
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripButton1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents uchk_activos As Infragistics.Win.UltraWinEditors.UltraCheckEditor
End Class
