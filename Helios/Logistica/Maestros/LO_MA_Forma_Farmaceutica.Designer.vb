﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LO_MA_Forma_Farmaceutica
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
        Dim UltraGridColumn1 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FF_ID")
        Dim UltraGridColumn2 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FF_NOMBRE")
        Dim UltraDataColumn1 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("FF_ID")
        Dim UltraDataColumn2 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("FF_NOMBRE")
        Dim Appearance6 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance1 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraTab1 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraTab2 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Me.UltraTabPageControl1 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.ug_Lista_Num = New Infragistics.Win.UltraWinGrid.UltraGrid()
        Me.uds_Lista = New Infragistics.Win.UltraWinDataSource.UltraDataSource(Me.components)
        Me.UltraTabPageControl2 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.ugb_datos = New Infragistics.Win.Misc.UltraGroupBox()
        Me.UltraLabel2 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraLabel1 = New Infragistics.Win.Misc.UltraLabel()
        Me.txt_id = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.txt_Nombre = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.utc_Numeracion = New Infragistics.Win.UltraWinTabControl.UltraTabControl()
        Me.UltraTabSharedControlsPage1 = New Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage()
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
        Me.UltraTabPageControl1.SuspendLayout()
        CType(Me.ug_Lista_Num, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.uds_Lista, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabPageControl2.SuspendLayout()
        CType(Me.ugb_datos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ugb_datos.SuspendLayout()
        CType(Me.txt_id, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_Nombre, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.utc_Numeracion, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.utc_Numeracion.SuspendLayout()
        Me.ToolS_Mantenimiento.SuspendLayout()
        Me.SuspendLayout()
        '
        'UltraTabPageControl1
        '
        Me.UltraTabPageControl1.Controls.Add(Me.ug_Lista_Num)
        Me.UltraTabPageControl1.Location = New System.Drawing.Point(1, 23)
        Me.UltraTabPageControl1.Name = "UltraTabPageControl1"
        Me.UltraTabPageControl1.Size = New System.Drawing.Size(436, 254)
        '
        'ug_Lista_Num
        '
        Me.ug_Lista_Num.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ug_Lista_Num.DataSource = Me.uds_Lista
        Me.ug_Lista_Num.DisplayLayout.AutoFitStyle = Infragistics.Win.UltraWinGrid.AutoFitStyle.ExtendLastColumn
        UltraGridColumn1.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn1.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn1.Header.Caption = "Codigo"
        UltraGridColumn1.Header.VisiblePosition = 0
        UltraGridColumn1.Width = 62
        UltraGridColumn2.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn2.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn2.Header.Caption = "Descripcion"
        UltraGridColumn2.Header.VisiblePosition = 1
        UltraGridColumn2.Width = 76
        UltraGridBand1.Columns.AddRange(New Object() {UltraGridColumn1, UltraGridColumn2})
        Me.ug_Lista_Num.DisplayLayout.BandsSerializer.Add(UltraGridBand1)
        Me.ug_Lista_Num.DisplayLayout.MaxColScrollRegions = 1
        Me.ug_Lista_Num.DisplayLayout.MaxRowScrollRegions = 1
        Me.ug_Lista_Num.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.ug_Lista_Num.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.ug_Lista_Num.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ug_Lista_Num.Location = New System.Drawing.Point(4, 3)
        Me.ug_Lista_Num.Name = "ug_Lista_Num"
        Me.ug_Lista_Num.Size = New System.Drawing.Size(426, 248)
        Me.ug_Lista_Num.TabIndex = 0
        '
        'uds_Lista
        '
        Me.uds_Lista.AllowDelete = False
        UltraDataColumn1.DataType = GetType(Long)
        Me.uds_Lista.Band.Columns.AddRange(New Object() {UltraDataColumn1, UltraDataColumn2})
        '
        'UltraTabPageControl2
        '
        Me.UltraTabPageControl2.Controls.Add(Me.ugb_datos)
        Me.UltraTabPageControl2.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl2.Name = "UltraTabPageControl2"
        Me.UltraTabPageControl2.Size = New System.Drawing.Size(436, 254)
        '
        'ugb_datos
        '
        Me.ugb_datos.Controls.Add(Me.UltraLabel2)
        Me.ugb_datos.Controls.Add(Me.UltraLabel1)
        Me.ugb_datos.Controls.Add(Me.txt_id)
        Me.ugb_datos.Controls.Add(Me.txt_Nombre)
        Me.ugb_datos.Location = New System.Drawing.Point(28, 41)
        Me.ugb_datos.Name = "ugb_datos"
        Me.ugb_datos.Size = New System.Drawing.Size(380, 167)
        Me.ugb_datos.TabIndex = 0
        '
        'UltraLabel2
        '
        Appearance6.BackColor = System.Drawing.Color.Transparent
        Appearance6.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel2.Appearance = Appearance6
        Me.UltraLabel2.AutoSize = True
        Me.UltraLabel2.Location = New System.Drawing.Point(29, 93)
        Me.UltraLabel2.Name = "UltraLabel2"
        Me.UltraLabel2.Size = New System.Drawing.Size(51, 14)
        Me.UltraLabel2.TabIndex = 125
        Me.UltraLabel2.Text = "Nombre :"
        '
        'UltraLabel1
        '
        Appearance1.BackColor = System.Drawing.Color.Transparent
        Appearance1.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel1.Appearance = Appearance1
        Me.UltraLabel1.AutoSize = True
        Me.UltraLabel1.Location = New System.Drawing.Point(29, 52)
        Me.UltraLabel1.Name = "UltraLabel1"
        Me.UltraLabel1.Size = New System.Drawing.Size(46, 14)
        Me.UltraLabel1.TabIndex = 125
        Me.UltraLabel1.Text = "Codigo :"
        '
        'txt_id
        '
        Me.txt_id.Location = New System.Drawing.Point(88, 48)
        Me.txt_id.Name = "txt_id"
        Me.txt_id.ReadOnly = True
        Me.txt_id.Size = New System.Drawing.Size(91, 21)
        Me.txt_id.TabIndex = 0
        '
        'txt_Nombre
        '
        Me.txt_Nombre.Location = New System.Drawing.Point(88, 89)
        Me.txt_Nombre.Name = "txt_Nombre"
        Me.txt_Nombre.Size = New System.Drawing.Size(262, 21)
        Me.txt_Nombre.TabIndex = 1
        '
        'utc_Numeracion
        '
        Me.utc_Numeracion.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.utc_Numeracion.Controls.Add(Me.UltraTabSharedControlsPage1)
        Me.utc_Numeracion.Controls.Add(Me.UltraTabPageControl1)
        Me.utc_Numeracion.Controls.Add(Me.UltraTabPageControl2)
        Me.utc_Numeracion.Location = New System.Drawing.Point(2, 29)
        Me.utc_Numeracion.Name = "utc_Numeracion"
        Me.utc_Numeracion.SharedControlsPage = Me.UltraTabSharedControlsPage1
        Me.utc_Numeracion.Size = New System.Drawing.Size(440, 280)
        Me.utc_Numeracion.TabIndex = 13
        UltraTab1.TabPage = Me.UltraTabPageControl1
        UltraTab1.Text = "Lista de datos"
        UltraTab2.TabPage = Me.UltraTabPageControl2
        UltraTab2.Text = "Ingreso / Edicion de Datos"
        Me.utc_Numeracion.Tabs.AddRange(New Infragistics.Win.UltraWinTabControl.UltraTab() {UltraTab1, UltraTab2})
        '
        'UltraTabSharedControlsPage1
        '
        Me.UltraTabSharedControlsPage1.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabSharedControlsPage1.Name = "UltraTabSharedControlsPage1"
        Me.UltraTabSharedControlsPage1.Size = New System.Drawing.Size(436, 254)
        '
        'ToolS_Mantenimiento
        '
        Me.ToolS_Mantenimiento.BackColor = System.Drawing.Color.White
        Me.ToolS_Mantenimiento.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Tool_Nuevo, Me.ToolStripSeparator1, Me.Tool_Grabar, Me.ToolStripSeparator3, Me.Tool_Editar, Me.ToolStripSeparator4, Me.Tool_Cancelar, Me.ToolStripSeparator2, Me.Tool_Eliminar, Me.ToolStripSeparator5, Me.Tool_Salir})
        Me.ToolS_Mantenimiento.Location = New System.Drawing.Point(0, 0)
        Me.ToolS_Mantenimiento.Name = "ToolS_Mantenimiento"
        Me.ToolS_Mantenimiento.Size = New System.Drawing.Size(442, 25)
        Me.ToolS_Mantenimiento.TabIndex = 12
        Me.ToolS_Mantenimiento.Text = "ToolStrip1"
        '
        'Tool_Nuevo
        '
        Me.Tool_Nuevo.Image = Global.Contabilidad.My.Resources.Resources._16__File_new_2_
        Me.Tool_Nuevo.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Tool_Nuevo.Name = "Tool_Nuevo"
        Me.Tool_Nuevo.Size = New System.Drawing.Size(62, 22)
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
        Me.Tool_Grabar.Size = New System.Drawing.Size(62, 22)
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
        Me.Tool_Editar.Size = New System.Drawing.Size(57, 22)
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
        Me.Tool_Cancelar.Size = New System.Drawing.Size(73, 22)
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
        Me.Tool_Eliminar.Size = New System.Drawing.Size(70, 22)
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
        Me.Tool_Salir.Size = New System.Drawing.Size(49, 22)
        Me.Tool_Salir.Text = "Salir"
        '
        'LO_MA_Forma_Farmaceutica
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(442, 310)
        Me.Controls.Add(Me.utc_Numeracion)
        Me.Controls.Add(Me.ToolS_Mantenimiento)
        Me.Name = "LO_MA_Forma_Farmaceutica"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Forma Farmaceútica"
        Me.UltraTabPageControl1.ResumeLayout(False)
        CType(Me.ug_Lista_Num, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.uds_Lista, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabPageControl2.ResumeLayout(False)
        CType(Me.ugb_datos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ugb_datos.ResumeLayout(False)
        Me.ugb_datos.PerformLayout()
        CType(Me.txt_id, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_Nombre, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.utc_Numeracion, System.ComponentModel.ISupportInitialize).EndInit()
        Me.utc_Numeracion.ResumeLayout(False)
        Me.ToolS_Mantenimiento.ResumeLayout(False)
        Me.ToolS_Mantenimiento.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents utc_Numeracion As Infragistics.Win.UltraWinTabControl.UltraTabControl
    Friend WithEvents UltraTabSharedControlsPage1 As Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage
    Friend WithEvents UltraTabPageControl1 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents ug_Lista_Num As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents uds_Lista As Infragistics.Win.UltraWinDataSource.UltraDataSource
    Friend WithEvents UltraTabPageControl2 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents ugb_datos As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents UltraLabel2 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel1 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents txt_id As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents txt_Nombre As Infragistics.Win.UltraWinEditors.UltraTextEditor
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
End Class
