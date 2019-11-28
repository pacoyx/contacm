<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AD_MA_CentroCosto
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
        Me.components = New System.ComponentModel.Container()
        Dim UltraGridBand1 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1)
        Dim UltraGridColumn1 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CM_ID")
        Dim UltraGridColumn2 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CM_DES_CORTA")
        Dim UltraGridColumn3 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CM_DESCRIPCION")
        Dim Appearance7 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance5 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance6 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance16 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraTab1 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraTab2 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Me.UltraTabPageControl1 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.ug_Consultorio = New Infragistics.Win.UltraWinGrid.UltraGrid()
        Me.UltraTabPageControl2 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.ugb_datos = New Infragistics.Win.Misc.UltraGroupBox()
        Me.UltraLabel3 = New Infragistics.Win.Misc.UltraLabel()
        Me.txt_Descripcion = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.txt_DesCorto = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.UltraLabel2 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraLabel1 = New Infragistics.Win.Misc.UltraLabel()
        Me.txt_id = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.UltraLabel4 = New Infragistics.Win.Misc.UltraLabel()
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
        Me.utc_Consultorios = New Infragistics.Win.UltraWinTabControl.UltraTabControl()
        Me.UltraTabSharedControlsPage1 = New Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage()
        Me.UltraDataSource1 = New Infragistics.Win.UltraWinDataSource.UltraDataSource(Me.components)
        Me.Ds_Reportes_Conta1 = New LR.Ds_Reportes_Conta()
        Me.uc_idcc = New System.Windows.Forms.ComboBox()
        Me.UltraTabPageControl1.SuspendLayout()
        CType(Me.ug_Consultorio, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabPageControl2.SuspendLayout()
        CType(Me.ugb_datos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ugb_datos.SuspendLayout()
        CType(Me.txt_Descripcion, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_DesCorto, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_id, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolS_Mantenimiento.SuspendLayout()
        CType(Me.utc_Consultorios, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.utc_Consultorios.SuspendLayout()
        CType(Me.UltraDataSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Ds_Reportes_Conta1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'UltraTabPageControl1
        '
        Me.UltraTabPageControl1.Controls.Add(Me.ug_Consultorio)
        Me.UltraTabPageControl1.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl1.Name = "UltraTabPageControl1"
        Me.UltraTabPageControl1.Size = New System.Drawing.Size(529, 316)
        '
        'ug_Consultorio
        '
        Me.ug_Consultorio.DisplayLayout.AutoFitStyle = Infragistics.Win.UltraWinGrid.AutoFitStyle.ExtendLastColumn
        UltraGridColumn1.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn1.Header.Caption = "CÓDIGO"
        UltraGridColumn1.Header.VisiblePosition = 0
        UltraGridColumn2.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn2.Header.Caption = "DESC. CORTA"
        UltraGridColumn2.Header.VisiblePosition = 1
        UltraGridColumn3.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn3.Header.Caption = "DESCRIPCIÓN"
        UltraGridColumn3.Header.VisiblePosition = 2
        UltraGridColumn3.Width = 95
        UltraGridBand1.Columns.AddRange(New Object() {UltraGridColumn1, UltraGridColumn2, UltraGridColumn3})
        Me.ug_Consultorio.DisplayLayout.BandsSerializer.Add(UltraGridBand1)
        Me.ug_Consultorio.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ug_Consultorio.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ug_Consultorio.Location = New System.Drawing.Point(0, 0)
        Me.ug_Consultorio.Name = "ug_Consultorio"
        Me.ug_Consultorio.Size = New System.Drawing.Size(529, 316)
        Me.ug_Consultorio.TabIndex = 0
        '
        'UltraTabPageControl2
        '
        Me.UltraTabPageControl2.Controls.Add(Me.ugb_datos)
        Me.UltraTabPageControl2.Location = New System.Drawing.Point(1, 23)
        Me.UltraTabPageControl2.Name = "UltraTabPageControl2"
        Me.UltraTabPageControl2.Size = New System.Drawing.Size(529, 316)
        '
        'ugb_datos
        '
        Me.ugb_datos.Controls.Add(Me.uc_idcc)
        Me.ugb_datos.Controls.Add(Me.UltraLabel3)
        Me.ugb_datos.Controls.Add(Me.txt_Descripcion)
        Me.ugb_datos.Controls.Add(Me.txt_DesCorto)
        Me.ugb_datos.Controls.Add(Me.UltraLabel2)
        Me.ugb_datos.Controls.Add(Me.UltraLabel1)
        Me.ugb_datos.Controls.Add(Me.txt_id)
        Me.ugb_datos.Controls.Add(Me.UltraLabel4)
        Me.ugb_datos.Location = New System.Drawing.Point(14, 25)
        Me.ugb_datos.Name = "ugb_datos"
        Me.ugb_datos.Size = New System.Drawing.Size(501, 184)
        Me.ugb_datos.TabIndex = 0
        '
        'UltraLabel3
        '
        Appearance7.BackColor = System.Drawing.Color.Transparent
        Appearance7.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel3.Appearance = Appearance7
        Me.UltraLabel3.AutoSize = True
        Me.UltraLabel3.Location = New System.Drawing.Point(289, 38)
        Me.UltraLabel3.Name = "UltraLabel3"
        Me.UltraLabel3.Size = New System.Drawing.Size(57, 14)
        Me.UltraLabel3.TabIndex = 25
        Me.UltraLabel3.Text = "CC_Conta"
        '
        'txt_Descripcion
        '
        Me.txt_Descripcion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_Descripcion.Location = New System.Drawing.Point(119, 106)
        Me.txt_Descripcion.MaxLength = 100
        Me.txt_Descripcion.Name = "txt_Descripcion"
        Me.txt_Descripcion.Size = New System.Drawing.Size(359, 21)
        Me.txt_Descripcion.TabIndex = 2
        '
        'txt_DesCorto
        '
        Me.txt_DesCorto.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_DesCorto.Location = New System.Drawing.Point(119, 76)
        Me.txt_DesCorto.MaxLength = 4
        Me.txt_DesCorto.Name = "txt_DesCorto"
        Me.txt_DesCorto.Size = New System.Drawing.Size(132, 21)
        Me.txt_DesCorto.TabIndex = 1
        '
        'UltraLabel2
        '
        Appearance5.BackColor = System.Drawing.Color.Transparent
        Appearance5.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel2.Appearance = Appearance5
        Me.UltraLabel2.AutoSize = True
        Me.UltraLabel2.Location = New System.Drawing.Point(17, 109)
        Me.UltraLabel2.Name = "UltraLabel2"
        Me.UltraLabel2.Size = New System.Drawing.Size(63, 14)
        Me.UltraLabel2.TabIndex = 23
        Me.UltraLabel2.Text = "Descripción"
        '
        'UltraLabel1
        '
        Appearance6.BackColor = System.Drawing.Color.Transparent
        Appearance6.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel1.Appearance = Appearance6
        Me.UltraLabel1.AutoSize = True
        Me.UltraLabel1.Location = New System.Drawing.Point(17, 79)
        Me.UltraLabel1.Name = "UltraLabel1"
        Me.UltraLabel1.Size = New System.Drawing.Size(94, 14)
        Me.UltraLabel1.TabIndex = 23
        Me.UltraLabel1.Text = "Descripción Corta"
        '
        'txt_id
        '
        Me.txt_id.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_id.Location = New System.Drawing.Point(119, 35)
        Me.txt_id.MaxLength = 50
        Me.txt_id.Name = "txt_id"
        Me.txt_id.Size = New System.Drawing.Size(132, 21)
        Me.txt_id.TabIndex = 0
        '
        'UltraLabel4
        '
        Appearance16.BackColor = System.Drawing.Color.Transparent
        Appearance16.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel4.Appearance = Appearance16
        Me.UltraLabel4.AutoSize = True
        Me.UltraLabel4.Location = New System.Drawing.Point(17, 38)
        Me.UltraLabel4.Name = "UltraLabel4"
        Me.UltraLabel4.Size = New System.Drawing.Size(40, 14)
        Me.UltraLabel4.TabIndex = 23
        Me.UltraLabel4.Text = "Codigo"
        '
        'ToolS_Mantenimiento
        '
        Me.ToolS_Mantenimiento.BackColor = System.Drawing.Color.White
        Me.ToolS_Mantenimiento.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Tool_Nuevo, Me.ToolStripSeparator1, Me.Tool_Grabar, Me.ToolStripSeparator3, Me.Tool_Editar, Me.ToolStripSeparator4, Me.Tool_Cancelar, Me.ToolStripSeparator2, Me.Tool_Eliminar, Me.ToolStripSeparator5, Me.Tool_Salir})
        Me.ToolS_Mantenimiento.Location = New System.Drawing.Point(0, 0)
        Me.ToolS_Mantenimiento.Name = "ToolS_Mantenimiento"
        Me.ToolS_Mantenimiento.Size = New System.Drawing.Size(555, 25)
        Me.ToolS_Mantenimiento.TabIndex = 11
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
        'utc_Consultorios
        '
        Me.utc_Consultorios.Controls.Add(Me.UltraTabSharedControlsPage1)
        Me.utc_Consultorios.Controls.Add(Me.UltraTabPageControl1)
        Me.utc_Consultorios.Controls.Add(Me.UltraTabPageControl2)
        Me.utc_Consultorios.Location = New System.Drawing.Point(12, 31)
        Me.utc_Consultorios.Name = "utc_Consultorios"
        Me.utc_Consultorios.SharedControlsPage = Me.UltraTabSharedControlsPage1
        Me.utc_Consultorios.Size = New System.Drawing.Size(533, 342)
        Me.utc_Consultorios.TabIndex = 12
        UltraTab1.TabPage = Me.UltraTabPageControl1
        UltraTab1.Text = "Lista de Consultorios"
        UltraTab2.TabPage = Me.UltraTabPageControl2
        UltraTab2.Text = "Ingreso / Edicion de Datos"
        Me.utc_Consultorios.Tabs.AddRange(New Infragistics.Win.UltraWinTabControl.UltraTab() {UltraTab1, UltraTab2})
        '
        'UltraTabSharedControlsPage1
        '
        Me.UltraTabSharedControlsPage1.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabSharedControlsPage1.Name = "UltraTabSharedControlsPage1"
        Me.UltraTabSharedControlsPage1.Size = New System.Drawing.Size(529, 316)
        '
        'Ds_Reportes_Conta1
        '
        Me.Ds_Reportes_Conta1.DataSetName = "Ds_Reportes_Conta"
        Me.Ds_Reportes_Conta1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'uc_idcc
        '
        Me.uc_idcc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.uc_idcc.FormattingEnabled = True
        Me.uc_idcc.Location = New System.Drawing.Point(357, 35)
        Me.uc_idcc.Name = "uc_idcc"
        Me.uc_idcc.Size = New System.Drawing.Size(121, 21)
        Me.uc_idcc.TabIndex = 26
        '
        'AD_MA_CentroCosto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(555, 385)
        Me.Controls.Add(Me.utc_Consultorios)
        Me.Controls.Add(Me.ToolS_Mantenimiento)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "AD_MA_CentroCosto"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Centro de Costo"
        Me.UltraTabPageControl1.ResumeLayout(False)
        CType(Me.ug_Consultorio, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabPageControl2.ResumeLayout(False)
        CType(Me.ugb_datos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ugb_datos.ResumeLayout(False)
        Me.ugb_datos.PerformLayout()
        CType(Me.txt_Descripcion, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_DesCorto, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_id, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolS_Mantenimiento.ResumeLayout(False)
        Me.ToolS_Mantenimiento.PerformLayout()
        CType(Me.utc_Consultorios, System.ComponentModel.ISupportInitialize).EndInit()
        Me.utc_Consultorios.ResumeLayout(False)
        CType(Me.UltraDataSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Ds_Reportes_Conta1, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents utc_Consultorios As Infragistics.Win.UltraWinTabControl.UltraTabControl
    Friend WithEvents UltraTabSharedControlsPage1 As Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage
    Friend WithEvents UltraTabPageControl1 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents ug_Consultorio As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents UltraTabPageControl2 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents ugb_datos As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents txt_Descripcion As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents txt_DesCorto As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents UltraLabel2 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel1 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents txt_id As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents UltraLabel4 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraDataSource1 As Infragistics.Win.UltraWinDataSource.UltraDataSource
    Friend WithEvents Ds_Reportes_Conta1 As LR.Ds_Reportes_Conta
    Friend WithEvents UltraLabel3 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents uc_idcc As System.Windows.Forms.ComboBox
End Class
