<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CO_PR_Aperturar_Periodo
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
        Me.UltraLabel1 = New Infragistics.Win.Misc.UltraLabel()
        Me.ugb_Periodo = New Infragistics.Win.Misc.UltraGroupBox()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.Tool_Aceptar = New System.Windows.Forms.ToolStripButton()
        Me.Tool_Salir = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.une_ayo_des = New Infragistics.Win.UltraWinEditors.UltraNumericEditor()
        Me.UltraLabel2 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraLabel3 = New Infragistics.Win.Misc.UltraLabel()
        CType(Me.ugb_Periodo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ugb_Periodo.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        CType(Me.une_ayo_des, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'UltraLabel1
        '
        Me.UltraLabel1.AutoSize = True
        Me.UltraLabel1.Location = New System.Drawing.Point(27, 36)
        Me.UltraLabel1.Name = "UltraLabel1"
        Me.UltraLabel1.Size = New System.Drawing.Size(30, 14)
        Me.UltraLabel1.TabIndex = 1
        Me.UltraLabel1.Text = "Año :"
        '
        'ugb_Periodo
        '
        Me.ugb_Periodo.Controls.Add(Me.une_ayo_des)
        Me.ugb_Periodo.Controls.Add(Me.UltraLabel1)
        Me.ugb_Periodo.Location = New System.Drawing.Point(12, 76)
        Me.ugb_Periodo.Name = "ugb_Periodo"
        Me.ugb_Periodo.Size = New System.Drawing.Size(531, 65)
        Me.ugb_Periodo.TabIndex = 2
        Me.ugb_Periodo.Text = "Periodo"
        '
        'ToolStrip1
        '
        Me.ToolStrip1.BackColor = System.Drawing.Color.NavajoWhite
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Tool_Aceptar, Me.ToolStripSeparator1, Me.Tool_Salir, Me.ToolStripSeparator2})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(552, 25)
        Me.ToolStrip1.TabIndex = 3
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'Tool_Aceptar
        '
        Me.Tool_Aceptar.BackColor = System.Drawing.Color.Transparent
        Me.Tool_Aceptar.Image = Global.Contabilidad.My.Resources.Resources._16__Ok_
        Me.Tool_Aceptar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Tool_Aceptar.Name = "Tool_Aceptar"
        Me.Tool_Aceptar.Size = New System.Drawing.Size(65, 22)
        Me.Tool_Aceptar.Text = "Aceptar"
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
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'une_ayo_des
        '
        Me.une_ayo_des.Location = New System.Drawing.Point(63, 32)
        Me.une_ayo_des.Name = "une_ayo_des"
        Me.une_ayo_des.Size = New System.Drawing.Size(100, 21)
        Me.une_ayo_des.TabIndex = 2
        '
        'UltraLabel2
        '
        Me.UltraLabel2.AutoSize = True
        Me.UltraLabel2.Location = New System.Drawing.Point(12, 38)
        Me.UltraLabel2.Name = "UltraLabel2"
        Me.UltraLabel2.Size = New System.Drawing.Size(412, 14)
        Me.UltraLabel2.TabIndex = 4
        Me.UltraLabel2.Text = "Ingrese el año a Aperturar y de clic en Aceptar. El sistema validara la informaci" & _
    "ón"
        '
        'UltraLabel3
        '
        Me.UltraLabel3.AutoSize = True
        Me.UltraLabel3.Location = New System.Drawing.Point(12, 58)
        Me.UltraLabel3.Name = "UltraLabel3"
        Me.UltraLabel3.Size = New System.Drawing.Size(435, 14)
        Me.UltraLabel3.TabIndex = 5
        Me.UltraLabel3.Text = "El sistema tomara como referencia el año actual del sistema para las configuracio" & _
    "nes."
        '
        'CO_PR_Aperturar_Periodo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(552, 154)
        Me.Controls.Add(Me.UltraLabel3)
        Me.Controls.Add(Me.UltraLabel2)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.ugb_Periodo)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "CO_PR_Aperturar_Periodo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Aperturar Periodo"
        CType(Me.ugb_Periodo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ugb_Periodo.ResumeLayout(False)
        Me.ugb_Periodo.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        CType(Me.une_ayo_des, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents UltraLabel1 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents ugb_Periodo As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents Tool_Aceptar As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents Tool_Salir As System.Windows.Forms.ToolStripButton
    Friend WithEvents une_ayo_des As Infragistics.Win.UltraWinEditors.UltraNumericEditor
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents UltraLabel2 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel3 As Infragistics.Win.Misc.UltraLabel
End Class
