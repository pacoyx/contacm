<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CO_MT_Buscar
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CO_MT_Buscar))
        Me.ug_data = New Infragistics.Win.UltraWinGrid.UltraGrid()
        Me.ubtn_Aceptar = New Infragistics.Win.Misc.UltraButton()
        Me.ubtn_Cancelar = New Infragistics.Win.Misc.UltraButton()
        Me.txt_filtro = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.uce_campos = New Infragistics.Win.UltraWinEditors.UltraComboEditor()
        Me.chk_filtro1 = New System.Windows.Forms.CheckBox()
        CType(Me.ug_data, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_filtro, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.uce_campos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ug_data
        '
        Me.ug_data.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ug_data.DisplayLayout.AutoFitStyle = Infragistics.Win.UltraWinGrid.AutoFitStyle.ExtendLastColumn
        Me.ug_data.DisplayLayout.Override.AllowAddNew = Infragistics.Win.UltraWinGrid.AllowAddNew.No
        Me.ug_data.DisplayLayout.Override.AllowDelete = Infragistics.Win.DefaultableBoolean.[False]
        Me.ug_data.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.[False]
        Me.ug_data.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Appearance1.BackColor = System.Drawing.Color.WhiteSmoke
        Appearance1.BackColor2 = System.Drawing.Color.WhiteSmoke
        Me.ug_data.DisplayLayout.Override.RowAlternateAppearance = Appearance1
        Me.ug_data.Location = New System.Drawing.Point(12, 54)
        Me.ug_data.Name = "ug_data"
        Me.ug_data.Size = New System.Drawing.Size(539, 263)
        Me.ug_data.TabIndex = 2
        '
        'ubtn_Aceptar
        '
        Me.ubtn_Aceptar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ubtn_Aceptar.Location = New System.Drawing.Point(388, 323)
        Me.ubtn_Aceptar.Name = "ubtn_Aceptar"
        Me.ubtn_Aceptar.Size = New System.Drawing.Size(75, 30)
        Me.ubtn_Aceptar.TabIndex = 3
        Me.ubtn_Aceptar.Text = "&Aceptar"
        '
        'ubtn_Cancelar
        '
        Me.ubtn_Cancelar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ubtn_Cancelar.Location = New System.Drawing.Point(469, 323)
        Me.ubtn_Cancelar.Name = "ubtn_Cancelar"
        Me.ubtn_Cancelar.Size = New System.Drawing.Size(82, 30)
        Me.ubtn_Cancelar.TabIndex = 4
        Me.ubtn_Cancelar.Text = "&Cancelar"
        '
        'txt_filtro
        '
        Me.txt_filtro.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_filtro.Location = New System.Drawing.Point(179, 27)
        Me.txt_filtro.Name = "txt_filtro"
        Me.txt_filtro.Size = New System.Drawing.Size(372, 21)
        Me.txt_filtro.TabIndex = 0
        '
        'uce_campos
        '
        Me.uce_campos.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.uce_campos.Location = New System.Drawing.Point(12, 27)
        Me.uce_campos.Name = "uce_campos"
        Me.uce_campos.Size = New System.Drawing.Size(161, 21)
        Me.uce_campos.TabIndex = 1
        '
        'chk_filtro1
        '
        Me.chk_filtro1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.chk_filtro1.AutoSize = True
        Me.chk_filtro1.Checked = True
        Me.chk_filtro1.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chk_filtro1.Location = New System.Drawing.Point(12, 323)
        Me.chk_filtro1.Name = "chk_filtro1"
        Me.chk_filtro1.Size = New System.Drawing.Size(85, 17)
        Me.chk_filtro1.TabIndex = 5
        Me.chk_filtro1.Text = "Empiece por"
        Me.chk_filtro1.UseVisualStyleBackColor = True
        '
        'CO_MT_Buscar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(565, 359)
        Me.Controls.Add(Me.chk_filtro1)
        Me.Controls.Add(Me.uce_campos)
        Me.Controls.Add(Me.txt_filtro)
        Me.Controls.Add(Me.ubtn_Aceptar)
        Me.Controls.Add(Me.ubtn_Cancelar)
        Me.Controls.Add(Me.ug_data)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "CO_MT_Buscar"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.ug_data, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_filtro, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.uce_campos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ug_data As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents ubtn_Aceptar As Infragistics.Win.Misc.UltraButton
    Friend WithEvents ubtn_Cancelar As Infragistics.Win.Misc.UltraButton
    Friend WithEvents txt_filtro As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents uce_campos As Infragistics.Win.UltraWinEditors.UltraComboEditor
    Friend WithEvents chk_filtro1 As System.Windows.Forms.CheckBox
End Class
