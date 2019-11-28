<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FA_PR_ListaTratamientos
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
        Me.uce_campos = New Infragistics.Win.UltraWinEditors.UltraComboEditor()
        Me.txt_filtro = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.ubtn_Aceptar = New Infragistics.Win.Misc.UltraButton()
        Me.ubtn_Cancelar = New Infragistics.Win.Misc.UltraButton()
        Me.ug_data = New Infragistics.Win.UltraWinGrid.UltraGrid()
        CType(Me.uce_campos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_filtro, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ug_data, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'uce_campos
        '
        Me.uce_campos.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.uce_campos.Location = New System.Drawing.Point(12, 7)
        Me.uce_campos.Name = "uce_campos"
        Me.uce_campos.Size = New System.Drawing.Size(161, 21)
        Me.uce_campos.TabIndex = 2
        '
        'txt_filtro
        '
        Me.txt_filtro.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_filtro.Location = New System.Drawing.Point(179, 7)
        Me.txt_filtro.Name = "txt_filtro"
        Me.txt_filtro.Size = New System.Drawing.Size(419, 21)
        Me.txt_filtro.TabIndex = 0
        '
        'ubtn_Aceptar
        '
        Me.ubtn_Aceptar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ubtn_Aceptar.Location = New System.Drawing.Point(438, 417)
        Me.ubtn_Aceptar.Name = "ubtn_Aceptar"
        Me.ubtn_Aceptar.Size = New System.Drawing.Size(75, 30)
        Me.ubtn_Aceptar.TabIndex = 9
        Me.ubtn_Aceptar.Text = "&Aceptar"
        '
        'ubtn_Cancelar
        '
        Me.ubtn_Cancelar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ubtn_Cancelar.Location = New System.Drawing.Point(516, 417)
        Me.ubtn_Cancelar.Name = "ubtn_Cancelar"
        Me.ubtn_Cancelar.Size = New System.Drawing.Size(82, 30)
        Me.ubtn_Cancelar.TabIndex = 10
        Me.ubtn_Cancelar.Text = "&Cancelar"
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
        Me.ug_data.Location = New System.Drawing.Point(12, 34)
        Me.ug_data.Name = "ug_data"
        Me.ug_data.Size = New System.Drawing.Size(586, 377)
        Me.ug_data.TabIndex = 1
        '
        'FA_PR_ListaTratamientos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(610, 451)
        Me.Controls.Add(Me.uce_campos)
        Me.Controls.Add(Me.txt_filtro)
        Me.Controls.Add(Me.ubtn_Aceptar)
        Me.Controls.Add(Me.ubtn_Cancelar)
        Me.Controls.Add(Me.ug_data)
        Me.Name = "FA_PR_ListaTratamientos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Listado de Tratamiento"
        CType(Me.uce_campos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_filtro, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ug_data, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents uce_campos As Infragistics.Win.UltraWinEditors.UltraComboEditor
    Friend WithEvents txt_filtro As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents ubtn_Aceptar As Infragistics.Win.Misc.UltraButton
    Friend WithEvents ubtn_Cancelar As Infragistics.Win.Misc.UltraButton
    Friend WithEvents ug_data As Infragistics.Win.UltraWinGrid.UltraGrid
End Class
