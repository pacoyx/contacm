<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FA_PR_ListaCajaAbiertas
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
        Me.ubtn_Aceptar = New Infragistics.Win.Misc.UltraButton()
        Me.ug_data = New Infragistics.Win.UltraWinGrid.UltraGrid()
        CType(Me.ug_data, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ubtn_Aceptar
        '
        Me.ubtn_Aceptar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ubtn_Aceptar.Location = New System.Drawing.Point(129, 187)
        Me.ubtn_Aceptar.Name = "ubtn_Aceptar"
        Me.ubtn_Aceptar.Size = New System.Drawing.Size(75, 30)
        Me.ubtn_Aceptar.TabIndex = 9
        Me.ubtn_Aceptar.Text = "&Aceptar"
        '
        'ug_data
        '
        Me.ug_data.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ug_data.DisplayLayout.AutoFitStyle = Infragistics.Win.UltraWinGrid.AutoFitStyle.ExtendLastColumn
        Me.ug_data.DisplayLayout.MaxColScrollRegions = 1
        Me.ug_data.DisplayLayout.MaxRowScrollRegions = 1
        Me.ug_data.DisplayLayout.Override.AllowAddNew = Infragistics.Win.UltraWinGrid.AllowAddNew.No
        Me.ug_data.DisplayLayout.Override.AllowDelete = Infragistics.Win.DefaultableBoolean.[False]
        Me.ug_data.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.[False]
        Me.ug_data.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Appearance1.BackColor = System.Drawing.Color.WhiteSmoke
        Appearance1.BackColor2 = System.Drawing.Color.WhiteSmoke
        Me.ug_data.DisplayLayout.Override.RowAlternateAppearance = Appearance1
        Me.ug_data.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.ug_data.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.ug_data.Location = New System.Drawing.Point(12, 8)
        Me.ug_data.Name = "ug_data"
        Me.ug_data.Size = New System.Drawing.Size(324, 173)
        Me.ug_data.TabIndex = 8
        '
        'FA_PR_ListaCajaAbiertas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(348, 223)
        Me.Controls.Add(Me.ubtn_Aceptar)
        Me.Controls.Add(Me.ug_data)
        Me.Name = "FA_PR_ListaCajaAbiertas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Listado de Cajas"
        CType(Me.ug_data, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ubtn_Aceptar As Infragistics.Win.Misc.UltraButton
    Friend WithEvents ug_data As Infragistics.Win.UltraWinGrid.UltraGrid
End Class
