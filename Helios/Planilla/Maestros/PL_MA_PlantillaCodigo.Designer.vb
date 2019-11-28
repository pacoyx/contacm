<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PL_MA_PlantillaCodigo
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
        Dim UltraDataColumn1 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("PC_ID")
        Dim UltraDataColumn2 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("PC_DES_REGISTRO")
        Dim UltraGridBand1 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1)
        Dim UltraGridColumn1 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("PC_ID")
        Dim UltraGridColumn2 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("PC_DES_REGISTRO")
        Dim Appearance3 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridBand2 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1)
        Dim UltraGridColumn3 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("PE_IDPLANTILLA")
        Dim UltraGridColumn4 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("PC_DES_REGISTRO")
        Dim UltraGridColumn5 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("PE_IDCONCEPTO")
        Dim Appearance1 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance4 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraDataColumn3 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("PE_IDPLANTILLA")
        Dim UltraDataColumn4 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("PC_DES_REGISTRO")
        Dim UltraDataColumn5 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("PE_IDCONCEPTO")
        Me.uds_Plantilla = New Infragistics.Win.UltraWinDataSource.UltraDataSource(Me.components)
        Me.ug_Plantilla = New Infragistics.Win.UltraWinGrid.UltraGrid()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.Tool_Grabar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.Tool_Salir = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ug_Relacion = New Infragistics.Win.UltraWinGrid.UltraGrid()
        Me.uds_Relacion = New Infragistics.Win.UltraWinDataSource.UltraDataSource(Me.components)
        Me.UltraLabel1 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraLabel2 = New Infragistics.Win.Misc.UltraLabel()
        CType(Me.uds_Plantilla, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ug_Plantilla, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip1.SuspendLayout()
        CType(Me.ug_Relacion, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.uds_Relacion, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'uds_Plantilla
        '
        Me.uds_Plantilla.AllowDelete = False
        UltraDataColumn1.DataType = GetType(Short)
        Me.uds_Plantilla.Band.Columns.AddRange(New Object() {UltraDataColumn1, UltraDataColumn2})
        '
        'ug_Plantilla
        '
        Me.ug_Plantilla.DataSource = Me.uds_Plantilla
        Me.ug_Plantilla.DisplayLayout.AutoFitStyle = Infragistics.Win.UltraWinGrid.AutoFitStyle.ExtendLastColumn
        UltraGridColumn1.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn1.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn1.Header.Caption = "Codigo"
        UltraGridColumn1.Header.VisiblePosition = 0
        UltraGridColumn1.Width = 33
        UltraGridColumn2.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn2.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn2.Header.Caption = "Descripcion"
        UltraGridColumn2.Header.VisiblePosition = 1
        UltraGridBand1.Columns.AddRange(New Object() {UltraGridColumn1, UltraGridColumn2})
        Me.ug_Plantilla.DisplayLayout.BandsSerializer.Add(UltraGridBand1)
        Me.ug_Plantilla.DisplayLayout.MaxColScrollRegions = 1
        Me.ug_Plantilla.DisplayLayout.MaxRowScrollRegions = 1
        Appearance3.BackColor = System.Drawing.Color.WhiteSmoke
        Appearance3.BackColor2 = System.Drawing.Color.WhiteSmoke
        Me.ug_Plantilla.DisplayLayout.Override.RowAlternateAppearance = Appearance3
        Me.ug_Plantilla.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.ug_Plantilla.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.ug_Plantilla.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ug_Plantilla.Location = New System.Drawing.Point(12, 91)
        Me.ug_Plantilla.Name = "ug_Plantilla"
        Me.ug_Plantilla.Size = New System.Drawing.Size(219, 295)
        Me.ug_Plantilla.TabIndex = 0
        Me.ug_Plantilla.Text = "Plantilla de Codigo"
        '
        'ToolStrip1
        '
        Me.ToolStrip1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripSeparator3, Me.Tool_Grabar, Me.ToolStripSeparator1, Me.Tool_Salir, Me.ToolStripSeparator2})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(579, 25)
        Me.ToolStrip1.TabIndex = 12
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 25)
        '
        'Tool_Grabar
        '
        Me.Tool_Grabar.Image = Global.Contabilidad.My.Resources.Resources._003
        Me.Tool_Grabar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Tool_Grabar.Name = "Tool_Grabar"
        Me.Tool_Grabar.Size = New System.Drawing.Size(60, 22)
        Me.Tool_Grabar.Text = "Grabar"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'Tool_Salir
        '
        Me.Tool_Salir.Image = Global.Contabilidad.My.Resources.Resources._28
        Me.Tool_Salir.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Tool_Salir.Name = "Tool_Salir"
        Me.Tool_Salir.Size = New System.Drawing.Size(47, 22)
        Me.Tool_Salir.Text = "Salir"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'ug_Relacion
        '
        Me.ug_Relacion.DataSource = Me.uds_Relacion
        Me.ug_Relacion.DisplayLayout.AutoFitStyle = Infragistics.Win.UltraWinGrid.AutoFitStyle.ExtendLastColumn
        UltraGridColumn3.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn3.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn3.Header.Caption = "Codigo"
        UltraGridColumn3.Header.VisiblePosition = 0
        UltraGridColumn3.Width = 29
        UltraGridColumn4.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn4.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn4.Header.Caption = "Descripcion"
        UltraGridColumn4.Header.VisiblePosition = 1
        UltraGridColumn4.Width = 142
        UltraGridColumn5.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        Appearance1.TextHAlignAsString = "Center"
        UltraGridColumn5.CellAppearance = Appearance1
        UltraGridColumn5.Header.Caption = "Codigo Concepto"
        UltraGridColumn5.Header.VisiblePosition = 2
        UltraGridBand2.Columns.AddRange(New Object() {UltraGridColumn3, UltraGridColumn4, UltraGridColumn5})
        Me.ug_Relacion.DisplayLayout.BandsSerializer.Add(UltraGridBand2)
        Me.ug_Relacion.DisplayLayout.MaxColScrollRegions = 1
        Me.ug_Relacion.DisplayLayout.MaxRowScrollRegions = 1
        Appearance4.BackColor = System.Drawing.Color.WhiteSmoke
        Appearance4.BackColor2 = System.Drawing.Color.WhiteSmoke
        Me.ug_Relacion.DisplayLayout.Override.RowAlternateAppearance = Appearance4
        Me.ug_Relacion.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.ug_Relacion.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.ug_Relacion.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ug_Relacion.Location = New System.Drawing.Point(237, 91)
        Me.ug_Relacion.Name = "ug_Relacion"
        Me.ug_Relacion.Size = New System.Drawing.Size(327, 295)
        Me.ug_Relacion.TabIndex = 13
        Me.ug_Relacion.Text = "Relacion Plantilla - Concepto "
        '
        'uds_Relacion
        '
        Me.uds_Relacion.AllowDelete = False
        UltraDataColumn3.DataType = GetType(Integer)
        Me.uds_Relacion.Band.Columns.AddRange(New Object() {UltraDataColumn3, UltraDataColumn4, UltraDataColumn5})
        '
        'UltraLabel1
        '
        Me.UltraLabel1.Location = New System.Drawing.Point(12, 38)
        Me.UltraLabel1.Name = "UltraLabel1"
        Me.UltraLabel1.Size = New System.Drawing.Size(219, 47)
        Me.UltraLabel1.TabIndex = 14
        Me.UltraLabel1.Text = "Lista de Conceptos "
        '
        'UltraLabel2
        '
        Me.UltraLabel2.Location = New System.Drawing.Point(237, 38)
        Me.UltraLabel2.Name = "UltraLabel2"
        Me.UltraLabel2.Size = New System.Drawing.Size(327, 47)
        Me.UltraLabel2.TabIndex = 15
        Me.UltraLabel2.Text = "Lista de conceptos con procesos particulares programados en la aplicacion relacio" & _
    "nados a un Folio"
        '
        'PL_MA_PlantillaCodigo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(579, 398)
        Me.Controls.Add(Me.UltraLabel2)
        Me.Controls.Add(Me.UltraLabel1)
        Me.Controls.Add(Me.ug_Relacion)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.ug_Plantilla)
        Me.Name = "PL_MA_PlantillaCodigo"
        Me.Text = "Plantilla Codigo de Conceptos"
        CType(Me.uds_Plantilla, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ug_Plantilla, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        CType(Me.ug_Relacion, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.uds_Relacion, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents uds_Plantilla As Infragistics.Win.UltraWinDataSource.UltraDataSource
    Friend WithEvents ug_Plantilla As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents Tool_Salir As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ug_Relacion As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents uds_Relacion As Infragistics.Win.UltraWinDataSource.UltraDataSource
    Friend WithEvents Tool_Grabar As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents UltraLabel1 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel2 As Infragistics.Win.Misc.UltraLabel
End Class
