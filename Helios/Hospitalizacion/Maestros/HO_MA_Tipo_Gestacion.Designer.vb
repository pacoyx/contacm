<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class HO_MA_Tipo_Gestacion
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
        Dim UltraGridBand1 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1)
        Dim UltraGridColumn1 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TU_ID")
        Dim UltraGridColumn2 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TU_DESCRIPCION", -1, Nothing, 0, Infragistics.Win.UltraWinGrid.SortIndicator.Descending, False)
        Dim UltraGridColumn3 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TU_IDEMPRESA")
        Dim Appearance8 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance5 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance7 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraTab2 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim Appearance1 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Me.UltraTabPageControl2 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.ugb_data = New Infragistics.Win.Misc.UltraGroupBox()
        Me.udgv_tipo_ges = New Infragistics.Win.UltraWinGrid.UltraGrid()
        Me.gb_tipo_ges = New System.Windows.Forms.GroupBox()
        Me.txt_descripcion = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.txt_cod = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.UltraLabel3 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraLabel2 = New Infragistics.Win.Misc.UltraLabel()
        Me.ToolS_Mantenimiento = New System.Windows.Forms.ToolStrip()
        Me.Tool_Nuevo = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.Tool_Grabar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.Tool_Editar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.Tool_Cancelar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.Tool_Eliminar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator()
        Me.Tool_Salir = New System.Windows.Forms.ToolStripButton()
        Me.utc_tipo_ges = New Infragistics.Win.UltraWinTabControl.UltraTabControl()
        Me.UltraTabSharedControlsPage1 = New Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage()
        Me.UltraTabPageControl2.SuspendLayout()
        CType(Me.ugb_data, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ugb_data.SuspendLayout()
        CType(Me.udgv_tipo_ges, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gb_tipo_ges.SuspendLayout()
        CType(Me.txt_descripcion, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_cod, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolS_Mantenimiento.SuspendLayout()
        CType(Me.utc_tipo_ges, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.utc_tipo_ges.SuspendLayout()
        Me.SuspendLayout()
        '
        'UltraTabPageControl2
        '
        Me.UltraTabPageControl2.Controls.Add(Me.ugb_data)
        Me.UltraTabPageControl2.Location = New System.Drawing.Point(1, 22)
        Me.UltraTabPageControl2.Name = "UltraTabPageControl2"
        Me.UltraTabPageControl2.Size = New System.Drawing.Size(690, 270)
        '
        'ugb_data
        '
        Me.ugb_data.Controls.Add(Me.udgv_tipo_ges)
        Me.ugb_data.Controls.Add(Me.gb_tipo_ges)
        Me.ugb_data.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ugb_data.Location = New System.Drawing.Point(0, 0)
        Me.ugb_data.Name = "ugb_data"
        Me.ugb_data.Size = New System.Drawing.Size(690, 270)
        Me.ugb_data.TabIndex = 0
        Me.ugb_data.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2003
        '
        'udgv_tipo_ges
        '
        Me.udgv_tipo_ges.DisplayLayout.AutoFitStyle = Infragistics.Win.UltraWinGrid.AutoFitStyle.ExtendLastColumn
        UltraGridColumn1.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn1.Header.Caption = "CODIGO"
        UltraGridColumn1.Header.VisiblePosition = 0
        UltraGridColumn2.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn2.Header.Caption = "DESCRIPCION"
        UltraGridColumn2.Header.VisiblePosition = 1
        UltraGridColumn2.Width = 8
        UltraGridColumn3.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn3.Header.VisiblePosition = 2
        UltraGridColumn3.Hidden = True
        UltraGridBand1.Columns.AddRange(New Object() {UltraGridColumn1, UltraGridColumn2, UltraGridColumn3})
        Me.udgv_tipo_ges.DisplayLayout.BandsSerializer.Add(UltraGridBand1)
        Me.udgv_tipo_ges.DisplayLayout.Override.AllowDelete = Infragistics.Win.DefaultableBoolean.[False]
        Me.udgv_tipo_ges.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.[False]
        Me.udgv_tipo_ges.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Appearance8.BackColor = System.Drawing.Color.WhiteSmoke
        Appearance8.BackColor2 = System.Drawing.Color.WhiteSmoke
        Me.udgv_tipo_ges.DisplayLayout.Override.RowAlternateAppearance = Appearance8
        Me.udgv_tipo_ges.DisplayLayout.Override.SelectTypeRow = Infragistics.Win.UltraWinGrid.SelectType.[Single]
        Me.udgv_tipo_ges.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.udgv_tipo_ges.Location = New System.Drawing.Point(11, 9)
        Me.udgv_tipo_ges.Name = "udgv_tipo_ges"
        Me.udgv_tipo_ges.Size = New System.Drawing.Size(390, 243)
        Me.udgv_tipo_ges.TabIndex = 24
        '
        'gb_tipo_ges
        '
        Me.gb_tipo_ges.Controls.Add(Me.txt_descripcion)
        Me.gb_tipo_ges.Controls.Add(Me.txt_cod)
        Me.gb_tipo_ges.Controls.Add(Me.UltraLabel3)
        Me.gb_tipo_ges.Controls.Add(Me.UltraLabel2)
        Me.gb_tipo_ges.Location = New System.Drawing.Point(419, 34)
        Me.gb_tipo_ges.Name = "gb_tipo_ges"
        Me.gb_tipo_ges.Size = New System.Drawing.Size(257, 189)
        Me.gb_tipo_ges.TabIndex = 23
        Me.gb_tipo_ges.TabStop = False
        '
        'txt_descripcion
        '
        Me.txt_descripcion.Location = New System.Drawing.Point(14, 117)
        Me.txt_descripcion.MaxLength = 50
        Me.txt_descripcion.Name = "txt_descripcion"
        Me.txt_descripcion.Size = New System.Drawing.Size(237, 21)
        Me.txt_descripcion.TabIndex = 1
        '
        'txt_cod
        '
        Me.txt_cod.Location = New System.Drawing.Point(74, 34)
        Me.txt_cod.MaxLength = 10
        Me.txt_cod.Name = "txt_cod"
        Me.txt_cod.Size = New System.Drawing.Size(89, 21)
        Me.txt_cod.TabIndex = 0
        '
        'UltraLabel3
        '
        Appearance5.BackColor = System.Drawing.Color.Transparent
        Appearance5.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel3.Appearance = Appearance5
        Me.UltraLabel3.AutoSize = True
        Me.UltraLabel3.Location = New System.Drawing.Point(14, 85)
        Me.UltraLabel3.Name = "UltraLabel3"
        Me.UltraLabel3.Size = New System.Drawing.Size(63, 14)
        Me.UltraLabel3.TabIndex = 26
        Me.UltraLabel3.Text = "Descripción"
        '
        'UltraLabel2
        '
        Appearance7.BackColor = System.Drawing.Color.Transparent
        Appearance7.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel2.Appearance = Appearance7
        Me.UltraLabel2.AutoSize = True
        Me.UltraLabel2.Location = New System.Drawing.Point(14, 19)
        Me.UltraLabel2.Name = "UltraLabel2"
        Me.UltraLabel2.Size = New System.Drawing.Size(40, 14)
        Me.UltraLabel2.TabIndex = 24
        Me.UltraLabel2.Text = "Codigo"
        '
        'ToolS_Mantenimiento
        '
        Me.ToolS_Mantenimiento.BackColor = System.Drawing.Color.White
        Me.ToolS_Mantenimiento.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Tool_Nuevo, Me.ToolStripSeparator1, Me.Tool_Grabar, Me.ToolStripSeparator3, Me.Tool_Editar, Me.ToolStripSeparator4, Me.Tool_Cancelar, Me.ToolStripSeparator2, Me.Tool_Eliminar, Me.ToolStripSeparator5, Me.Tool_Salir})
        Me.ToolS_Mantenimiento.Location = New System.Drawing.Point(0, 0)
        Me.ToolS_Mantenimiento.Name = "ToolS_Mantenimiento"
        Me.ToolS_Mantenimiento.Size = New System.Drawing.Size(691, 25)
        Me.ToolS_Mantenimiento.TabIndex = 13
        Me.ToolS_Mantenimiento.Text = "ToolStrip1"
        '
        'Tool_Nuevo
        '
        Me.Tool_Nuevo.Image = Global.Contabilidad.My.Resources.Resources._16__File_new_2_
        Me.Tool_Nuevo.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Tool_Nuevo.Name = "Tool_Nuevo"
        Me.Tool_Nuevo.Size = New System.Drawing.Size(58, 22)
        Me.Tool_Nuevo.Text = "Nuevo"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'Tool_Grabar
        '
        Me.Tool_Grabar.Image = Global.Contabilidad.My.Resources.Resources._003
        Me.Tool_Grabar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Tool_Grabar.Name = "Tool_Grabar"
        Me.Tool_Grabar.Size = New System.Drawing.Size(60, 22)
        Me.Tool_Grabar.Text = "Grabar"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 25)
        '
        'Tool_Editar
        '
        Me.Tool_Editar.Image = Global.Contabilidad.My.Resources.Resources._16__Card_edit_
        Me.Tool_Editar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Tool_Editar.Name = "Tool_Editar"
        Me.Tool_Editar.Size = New System.Drawing.Size(55, 22)
        Me.Tool_Editar.Text = "Editar"
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(6, 25)
        '
        'Tool_Cancelar
        '
        Me.Tool_Cancelar.Image = Global.Contabilidad.My.Resources.Resources._16__Cancel_
        Me.Tool_Cancelar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Tool_Cancelar.Name = "Tool_Cancelar"
        Me.Tool_Cancelar.Size = New System.Drawing.Size(69, 22)
        Me.Tool_Cancelar.Text = "Cancelar"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'Tool_Eliminar
        '
        Me.Tool_Eliminar.Image = Global.Contabilidad.My.Resources.Resources._16__Delete_
        Me.Tool_Eliminar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Tool_Eliminar.Name = "Tool_Eliminar"
        Me.Tool_Eliminar.Size = New System.Drawing.Size(63, 22)
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
        Me.Tool_Salir.Size = New System.Drawing.Size(47, 22)
        Me.Tool_Salir.Text = "Salir"
        '
        'utc_tipo_ges
        '
        Me.utc_tipo_ges.Controls.Add(Me.UltraTabSharedControlsPage1)
        Me.utc_tipo_ges.Controls.Add(Me.UltraTabPageControl2)
        Me.utc_tipo_ges.Location = New System.Drawing.Point(0, 28)
        Me.utc_tipo_ges.Name = "utc_tipo_ges"
        Me.utc_tipo_ges.SharedControlsPage = Me.UltraTabSharedControlsPage1
        Me.utc_tipo_ges.Size = New System.Drawing.Size(692, 293)
        Me.utc_tipo_ges.Style = Infragistics.Win.UltraWinTabControl.UltraTabControlStyle.Office2007Ribbon
        Me.utc_tipo_ges.TabIndex = 26
        Appearance1.ForeColor = System.Drawing.Color.Navy
        UltraTab2.SelectedAppearance = Appearance1
        UltraTab2.TabPage = Me.UltraTabPageControl2
        UltraTab2.Text = "Mantenimiento Tipo de Gestante"
        Me.utc_tipo_ges.Tabs.AddRange(New Infragistics.Win.UltraWinTabControl.UltraTab() {UltraTab2})
        '
        'UltraTabSharedControlsPage1
        '
        Me.UltraTabSharedControlsPage1.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabSharedControlsPage1.Name = "UltraTabSharedControlsPage1"
        Me.UltraTabSharedControlsPage1.Size = New System.Drawing.Size(690, 270)
        '
        'HO_MA_Tipo_Gestacion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(691, 320)
        Me.Controls.Add(Me.utc_tipo_ges)
        Me.Controls.Add(Me.ToolS_Mantenimiento)
        Me.MaximizeBox = False
        Me.Name = "HO_MA_Tipo_Gestacion"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Tipo de Gestacion"
        Me.UltraTabPageControl2.ResumeLayout(False)
        CType(Me.ugb_data, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ugb_data.ResumeLayout(False)
        CType(Me.udgv_tipo_ges, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gb_tipo_ges.ResumeLayout(False)
        Me.gb_tipo_ges.PerformLayout()
        CType(Me.txt_descripcion, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_cod, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolS_Mantenimiento.ResumeLayout(False)
        Me.ToolS_Mantenimiento.PerformLayout()
        CType(Me.utc_tipo_ges, System.ComponentModel.ISupportInitialize).EndInit()
        Me.utc_tipo_ges.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolS_Mantenimiento As System.Windows.Forms.ToolStrip
    Friend WithEvents Tool_Nuevo As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents Tool_Grabar As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents Tool_Editar As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents Tool_Cancelar As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents Tool_Eliminar As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator5 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents Tool_Salir As System.Windows.Forms.ToolStripButton
    Friend WithEvents utc_tipo_ges As Infragistics.Win.UltraWinTabControl.UltraTabControl
    Friend WithEvents UltraTabSharedControlsPage1 As Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage
    Friend WithEvents UltraTabPageControl2 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents ugb_data As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents udgv_tipo_ges As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents gb_tipo_ges As System.Windows.Forms.GroupBox
    Friend WithEvents txt_descripcion As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents txt_cod As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents UltraLabel3 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel2 As Infragistics.Win.Misc.UltraLabel
End Class
