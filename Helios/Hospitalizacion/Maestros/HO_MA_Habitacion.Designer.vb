<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class HO_MA_Habitacion
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
        Dim UltraGridColumn2 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TU_DESCRIPCION")
        Dim UltraGridColumn3 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TU_IDEMPRESA")
        Dim Appearance4 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraTab2 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim Appearance1 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Me.UltraTabPageControl2 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.ugb_data = New Infragistics.Win.Misc.UltraGroupBox()
        Me.udgv_habi = New Infragistics.Win.UltraWinGrid.UltraGrid()
        Me.gb_habitacion = New System.Windows.Forms.GroupBox()
        Me.gb_estado = New System.Windows.Forms.GroupBox()
        Me.rb_off = New System.Windows.Forms.RadioButton()
        Me.rb_on = New System.Windows.Forms.RadioButton()
        Me.cb_tipo_habitacion = New System.Windows.Forms.ComboBox()
        Me.txt_descripcion = New System.Windows.Forms.TextBox()
        Me.cb_piso = New System.Windows.Forms.ComboBox()
        Me.txt_numero = New System.Windows.Forms.TextBox()
        Me.txt_codigo = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
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
        Me.utc_habitacion = New Infragistics.Win.UltraWinTabControl.UltraTabControl()
        Me.UltraTabSharedControlsPage1 = New Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage()
        Me.UltraTabPageControl2.SuspendLayout()
        CType(Me.ugb_data, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ugb_data.SuspendLayout()
        CType(Me.udgv_habi, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gb_habitacion.SuspendLayout()
        Me.gb_estado.SuspendLayout()
        Me.ToolS_Mantenimiento.SuspendLayout()
        CType(Me.utc_habitacion, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.utc_habitacion.SuspendLayout()
        Me.SuspendLayout()
        '
        'UltraTabPageControl2
        '
        Me.UltraTabPageControl2.Controls.Add(Me.ugb_data)
        Me.UltraTabPageControl2.Location = New System.Drawing.Point(1, 22)
        Me.UltraTabPageControl2.Name = "UltraTabPageControl2"
        Me.UltraTabPageControl2.Size = New System.Drawing.Size(756, 379)
        '
        'ugb_data
        '
        Me.ugb_data.Controls.Add(Me.udgv_habi)
        Me.ugb_data.Controls.Add(Me.gb_habitacion)
        Me.ugb_data.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ugb_data.Location = New System.Drawing.Point(0, 0)
        Me.ugb_data.Name = "ugb_data"
        Me.ugb_data.Size = New System.Drawing.Size(756, 379)
        Me.ugb_data.TabIndex = 0
        Me.ugb_data.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2003
        '
        'udgv_habi
        '
        Me.udgv_habi.DisplayLayout.AutoFitStyle = Infragistics.Win.UltraWinGrid.AutoFitStyle.ExtendLastColumn
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
        Me.udgv_habi.DisplayLayout.BandsSerializer.Add(UltraGridBand1)
        Me.udgv_habi.DisplayLayout.Override.AllowDelete = Infragistics.Win.DefaultableBoolean.[False]
        Me.udgv_habi.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.[False]
        Me.udgv_habi.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Appearance4.BackColor = System.Drawing.Color.WhiteSmoke
        Appearance4.BackColor2 = System.Drawing.Color.WhiteSmoke
        Me.udgv_habi.DisplayLayout.Override.RowAlternateAppearance = Appearance4
        Me.udgv_habi.DisplayLayout.Override.SelectTypeRow = Infragistics.Win.UltraWinGrid.SelectType.[Single]
        Me.udgv_habi.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.udgv_habi.Location = New System.Drawing.Point(5, 6)
        Me.udgv_habi.Name = "udgv_habi"
        Me.udgv_habi.Size = New System.Drawing.Size(453, 368)
        Me.udgv_habi.TabIndex = 30
        '
        'gb_habitacion
        '
        Me.gb_habitacion.Controls.Add(Me.gb_estado)
        Me.gb_habitacion.Controls.Add(Me.cb_tipo_habitacion)
        Me.gb_habitacion.Controls.Add(Me.txt_descripcion)
        Me.gb_habitacion.Controls.Add(Me.cb_piso)
        Me.gb_habitacion.Controls.Add(Me.txt_numero)
        Me.gb_habitacion.Controls.Add(Me.txt_codigo)
        Me.gb_habitacion.Controls.Add(Me.Label5)
        Me.gb_habitacion.Controls.Add(Me.Label4)
        Me.gb_habitacion.Controls.Add(Me.Label3)
        Me.gb_habitacion.Controls.Add(Me.Label2)
        Me.gb_habitacion.Controls.Add(Me.Label1)
        Me.gb_habitacion.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gb_habitacion.Location = New System.Drawing.Point(464, 6)
        Me.gb_habitacion.Name = "gb_habitacion"
        Me.gb_habitacion.Size = New System.Drawing.Size(290, 368)
        Me.gb_habitacion.TabIndex = 29
        Me.gb_habitacion.TabStop = False
        '
        'gb_estado
        '
        Me.gb_estado.Controls.Add(Me.rb_off)
        Me.gb_estado.Controls.Add(Me.rb_on)
        Me.gb_estado.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gb_estado.ForeColor = System.Drawing.Color.Navy
        Me.gb_estado.Location = New System.Drawing.Point(20, 256)
        Me.gb_estado.Name = "gb_estado"
        Me.gb_estado.Size = New System.Drawing.Size(191, 75)
        Me.gb_estado.TabIndex = 28
        Me.gb_estado.TabStop = False
        Me.gb_estado.Text = "Estado"
        '
        'rb_off
        '
        Me.rb_off.AutoSize = True
        Me.rb_off.Location = New System.Drawing.Point(14, 49)
        Me.rb_off.Name = "rb_off"
        Me.rb_off.Size = New System.Drawing.Size(110, 17)
        Me.rb_off.TabIndex = 1
        Me.rb_off.TabStop = True
        Me.rb_off.Text = "En Mantenimiento"
        Me.rb_off.UseVisualStyleBackColor = True
        '
        'rb_on
        '
        Me.rb_on.AutoSize = True
        Me.rb_on.Location = New System.Drawing.Point(14, 26)
        Me.rb_on.Name = "rb_on"
        Me.rb_on.Size = New System.Drawing.Size(74, 17)
        Me.rb_on.TabIndex = 0
        Me.rb_on.TabStop = True
        Me.rb_on.Text = "Disponible"
        Me.rb_on.UseVisualStyleBackColor = True
        '
        'cb_tipo_habitacion
        '
        Me.cb_tipo_habitacion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cb_tipo_habitacion.FormattingEnabled = True
        Me.cb_tipo_habitacion.Location = New System.Drawing.Point(20, 218)
        Me.cb_tipo_habitacion.Name = "cb_tipo_habitacion"
        Me.cb_tipo_habitacion.Size = New System.Drawing.Size(158, 21)
        Me.cb_tipo_habitacion.TabIndex = 4
        '
        'txt_descripcion
        '
        Me.txt_descripcion.Location = New System.Drawing.Point(20, 155)
        Me.txt_descripcion.Name = "txt_descripcion"
        Me.txt_descripcion.Size = New System.Drawing.Size(218, 20)
        Me.txt_descripcion.TabIndex = 3
        '
        'cb_piso
        '
        Me.cb_piso.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cb_piso.FormattingEnabled = True
        Me.cb_piso.Location = New System.Drawing.Point(83, 93)
        Me.cb_piso.Name = "cb_piso"
        Me.cb_piso.Size = New System.Drawing.Size(121, 21)
        Me.cb_piso.TabIndex = 2
        '
        'txt_numero
        '
        Me.txt_numero.Location = New System.Drawing.Point(83, 56)
        Me.txt_numero.Name = "txt_numero"
        Me.txt_numero.Size = New System.Drawing.Size(70, 20)
        Me.txt_numero.TabIndex = 1
        '
        'txt_codigo
        '
        Me.txt_codigo.Location = New System.Drawing.Point(83, 21)
        Me.txt_codigo.Name = "txt_codigo"
        Me.txt_codigo.Size = New System.Drawing.Size(70, 20)
        Me.txt_codigo.TabIndex = 0
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Navy
        Me.Label5.Location = New System.Drawing.Point(17, 192)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(82, 13)
        Me.Label5.TabIndex = 21
        Me.Label5.Text = "Tipo Habitacion"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Navy
        Me.Label4.Location = New System.Drawing.Point(17, 129)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(63, 13)
        Me.Label4.TabIndex = 20
        Me.Label4.Text = "Descripcion"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Navy
        Me.Label3.Location = New System.Drawing.Point(17, 93)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(27, 13)
        Me.Label3.TabIndex = 19
        Me.Label3.Text = "Piso"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Navy
        Me.Label2.Location = New System.Drawing.Point(17, 56)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(44, 13)
        Me.Label2.TabIndex = 18
        Me.Label2.Text = "Numero"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Navy
        Me.Label1.Location = New System.Drawing.Point(17, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(40, 13)
        Me.Label1.TabIndex = 17
        Me.Label1.Text = "Codigo"
        '
        'ToolS_Mantenimiento
        '
        Me.ToolS_Mantenimiento.BackColor = System.Drawing.Color.White
        Me.ToolS_Mantenimiento.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Tool_Nuevo, Me.ToolStripSeparator1, Me.Tool_Grabar, Me.ToolStripSeparator3, Me.Tool_Editar, Me.ToolStripSeparator4, Me.Tool_Cancelar, Me.ToolStripSeparator2, Me.Tool_Eliminar, Me.ToolStripSeparator5, Me.Tool_Salir})
        Me.ToolS_Mantenimiento.Location = New System.Drawing.Point(0, 0)
        Me.ToolS_Mantenimiento.Name = "ToolS_Mantenimiento"
        Me.ToolS_Mantenimiento.Size = New System.Drawing.Size(758, 25)
        Me.ToolS_Mantenimiento.TabIndex = 15
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
        'utc_habitacion
        '
        Me.utc_habitacion.Controls.Add(Me.UltraTabSharedControlsPage1)
        Me.utc_habitacion.Controls.Add(Me.UltraTabPageControl2)
        Me.utc_habitacion.Location = New System.Drawing.Point(0, 28)
        Me.utc_habitacion.Name = "utc_habitacion"
        Me.utc_habitacion.SharedControlsPage = Me.UltraTabSharedControlsPage1
        Me.utc_habitacion.Size = New System.Drawing.Size(758, 402)
        Me.utc_habitacion.Style = Infragistics.Win.UltraWinTabControl.UltraTabControlStyle.Office2007Ribbon
        Me.utc_habitacion.TabIndex = 31
        Appearance1.ForeColor = System.Drawing.Color.Navy
        UltraTab2.SelectedAppearance = Appearance1
        UltraTab2.TabPage = Me.UltraTabPageControl2
        UltraTab2.Text = "Mantenimiento de Habitaciones"
        Me.utc_habitacion.Tabs.AddRange(New Infragistics.Win.UltraWinTabControl.UltraTab() {UltraTab2})
        '
        'UltraTabSharedControlsPage1
        '
        Me.UltraTabSharedControlsPage1.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabSharedControlsPage1.Name = "UltraTabSharedControlsPage1"
        Me.UltraTabSharedControlsPage1.Size = New System.Drawing.Size(756, 379)
        '
        'HO_MA_Habitacion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(758, 430)
        Me.Controls.Add(Me.utc_habitacion)
        Me.Controls.Add(Me.ToolS_Mantenimiento)
        Me.MaximizeBox = False
        Me.Name = "HO_MA_Habitacion"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Habitacion"
        Me.UltraTabPageControl2.ResumeLayout(False)
        CType(Me.ugb_data, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ugb_data.ResumeLayout(False)
        CType(Me.udgv_habi, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gb_habitacion.ResumeLayout(False)
        Me.gb_habitacion.PerformLayout()
        Me.gb_estado.ResumeLayout(False)
        Me.gb_estado.PerformLayout()
        Me.ToolS_Mantenimiento.ResumeLayout(False)
        Me.ToolS_Mantenimiento.PerformLayout()
        CType(Me.utc_habitacion, System.ComponentModel.ISupportInitialize).EndInit()
        Me.utc_habitacion.ResumeLayout(False)
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
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txt_codigo As System.Windows.Forms.TextBox
    Friend WithEvents txt_numero As System.Windows.Forms.TextBox
    Friend WithEvents cb_piso As System.Windows.Forms.ComboBox
    Friend WithEvents txt_descripcion As System.Windows.Forms.TextBox
    Friend WithEvents cb_tipo_habitacion As System.Windows.Forms.ComboBox
    Friend WithEvents gb_estado As System.Windows.Forms.GroupBox
    Friend WithEvents rb_off As System.Windows.Forms.RadioButton
    Friend WithEvents rb_on As System.Windows.Forms.RadioButton
    Friend WithEvents gb_habitacion As System.Windows.Forms.GroupBox
    Friend WithEvents udgv_habi As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents utc_habitacion As Infragistics.Win.UltraWinTabControl.UltraTabControl
    Friend WithEvents UltraTabSharedControlsPage1 As Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage
    Friend WithEvents UltraTabPageControl2 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents ugb_data As Infragistics.Win.Misc.UltraGroupBox
End Class
