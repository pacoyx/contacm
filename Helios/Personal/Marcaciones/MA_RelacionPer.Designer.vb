<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MA_RelacionPer
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
        Dim UltraDataColumn1 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("PE_ID")
        Dim UltraDataColumn2 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("PE_CODIGO")
        Dim UltraDataColumn3 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("EMPLEADO")
        Dim UltraDataColumn4 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("PE_ID_EMPRESA")
        Dim UltraGridBand1 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1)
        Dim UltraGridColumn1 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("PE_ID")
        Dim UltraGridColumn2 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("PE_CODIGO")
        Dim UltraGridColumn3 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("EMPLEADO")
        Dim UltraGridColumn4 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("PE_ID_EMPRESA")
        Dim Appearance2 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridBand2 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1)
        Dim UltraGridColumn5 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("PE_ID")
        Dim UltraGridColumn6 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("PE_CODIGO")
        Dim UltraGridColumn7 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("EMPLEADO")
        Dim UltraGridColumn8 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("PE_ID_EMPRESA")
        Dim Appearance1 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridBand3 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1)
        Dim UltraGridColumn9 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IDEMPRESA")
        Dim UltraGridColumn10 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CODIGO")
        Dim UltraGridColumn11 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("PERSONAL_ASIGNADO")
        Dim UltraGridColumn12 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("PE_ID")
        Dim Appearance6 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraDataColumn5 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IDEMPRESA")
        Dim UltraDataColumn6 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("CODIGO")
        Dim UltraDataColumn7 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("PERSONAL_ASIGNADO")
        Dim UltraDataColumn8 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("PE_ID")
        Dim Appearance4 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance5 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance3 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Me.uds_Personal = New Infragistics.Win.UltraWinDataSource.UltraDataSource(Me.components)
        Me.ug_ListaA = New Infragistics.Win.UltraWinGrid.UltraGrid()
        Me.ug_ListaB = New Infragistics.Win.UltraWinGrid.UltraGrid()
        Me.ug_Relacion = New Infragistics.Win.UltraWinGrid.UltraGrid()
        Me.uds_relacion = New Infragistics.Win.UltraWinDataSource.UltraDataSource(Me.components)
        Me.ubtn_agregar = New Infragistics.Win.Misc.UltraButton()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.UltraLabel1 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraLabel2 = New Infragistics.Win.Misc.UltraLabel()
        Me.lbl_con_rel = New Infragistics.Win.Misc.UltraLabel()
        CType(Me.uds_Personal, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ug_ListaA, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ug_ListaB, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ug_Relacion, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.uds_relacion, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'uds_Personal
        '
        UltraDataColumn1.DataType = GetType(Integer)
        UltraDataColumn4.DataType = GetType(UShort)
        Me.uds_Personal.Band.Columns.AddRange(New Object() {UltraDataColumn1, UltraDataColumn2, UltraDataColumn3, UltraDataColumn4})
        '
        'ug_ListaA
        '
        Me.ug_ListaA.DataSource = Me.uds_Personal
        Me.ug_ListaA.DisplayLayout.AutoFitStyle = Infragistics.Win.UltraWinGrid.AutoFitStyle.ExtendLastColumn
        UltraGridColumn1.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn1.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn1.Header.VisiblePosition = 0
        UltraGridColumn1.Hidden = True
        UltraGridColumn1.Width = 39
        UltraGridColumn2.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn2.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn2.Header.VisiblePosition = 2
        UltraGridColumn2.Width = 58
        UltraGridColumn3.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn3.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn3.Header.VisiblePosition = 3
        UltraGridColumn4.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn4.Header.VisiblePosition = 1
        UltraGridColumn4.Width = 27
        UltraGridBand1.Columns.AddRange(New Object() {UltraGridColumn1, UltraGridColumn2, UltraGridColumn3, UltraGridColumn4})
        Me.ug_ListaA.DisplayLayout.BandsSerializer.Add(UltraGridBand1)
        Me.ug_ListaA.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.[False]
        Me.ug_ListaA.DisplayLayout.MaxColScrollRegions = 1
        Me.ug_ListaA.DisplayLayout.MaxRowScrollRegions = 1
        Me.ug_ListaA.DisplayLayout.Override.AllowAddNew = Infragistics.Win.UltraWinGrid.AllowAddNew.No
        Me.ug_ListaA.DisplayLayout.Override.AllowDelete = Infragistics.Win.DefaultableBoolean.[False]
        Me.ug_ListaA.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.[False]
        Appearance2.BackColor = System.Drawing.Color.WhiteSmoke
        Appearance2.BackColor2 = System.Drawing.Color.WhiteSmoke
        Me.ug_ListaA.DisplayLayout.Override.RowAlternateAppearance = Appearance2
        Me.ug_ListaA.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.[True]
        Me.ug_ListaA.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.ug_ListaA.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.ug_ListaA.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ug_ListaA.Location = New System.Drawing.Point(12, 62)
        Me.ug_ListaA.Name = "ug_ListaA"
        Me.ug_ListaA.Size = New System.Drawing.Size(337, 328)
        Me.ug_ListaA.TabIndex = 0
        Me.ug_ListaA.Text = "UltraGrid1"
        '
        'ug_ListaB
        '
        Me.ug_ListaB.DataSource = Me.uds_Personal
        Me.ug_ListaB.DisplayLayout.AutoFitStyle = Infragistics.Win.UltraWinGrid.AutoFitStyle.ExtendLastColumn
        UltraGridColumn5.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn5.Header.VisiblePosition = 0
        UltraGridColumn5.Hidden = True
        UltraGridColumn5.Width = 36
        UltraGridColumn6.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn6.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn6.Header.VisiblePosition = 2
        UltraGridColumn6.Width = 51
        UltraGridColumn7.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn7.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn7.Header.VisiblePosition = 3
        UltraGridColumn8.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn8.Header.VisiblePosition = 1
        UltraGridColumn8.Width = 33
        UltraGridBand2.Columns.AddRange(New Object() {UltraGridColumn5, UltraGridColumn6, UltraGridColumn7, UltraGridColumn8})
        Me.ug_ListaB.DisplayLayout.BandsSerializer.Add(UltraGridBand2)
        Me.ug_ListaB.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.[False]
        Me.ug_ListaB.DisplayLayout.MaxColScrollRegions = 1
        Me.ug_ListaB.DisplayLayout.MaxRowScrollRegions = 1
        Me.ug_ListaB.DisplayLayout.Override.AllowAddNew = Infragistics.Win.UltraWinGrid.AllowAddNew.No
        Me.ug_ListaB.DisplayLayout.Override.AllowDelete = Infragistics.Win.DefaultableBoolean.[False]
        Me.ug_ListaB.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.[False]
        Appearance1.BackColor = System.Drawing.Color.WhiteSmoke
        Appearance1.BackColor2 = System.Drawing.Color.WhiteSmoke
        Me.ug_ListaB.DisplayLayout.Override.RowAlternateAppearance = Appearance1
        Me.ug_ListaB.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.[True]
        Me.ug_ListaB.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.ug_ListaB.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.ug_ListaB.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ug_ListaB.Location = New System.Drawing.Point(355, 62)
        Me.ug_ListaB.Name = "ug_ListaB"
        Me.ug_ListaB.Size = New System.Drawing.Size(344, 283)
        Me.ug_ListaB.TabIndex = 0
        Me.ug_ListaB.Text = "UltraGrid1"
        '
        'ug_Relacion
        '
        Me.ug_Relacion.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.ug_Relacion.DataSource = Me.uds_relacion
        Me.ug_Relacion.DisplayLayout.AutoFitStyle = Infragistics.Win.UltraWinGrid.AutoFitStyle.ExtendLastColumn
        UltraGridColumn9.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn9.Header.VisiblePosition = 0
        UltraGridColumn9.Width = 33
        UltraGridColumn10.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn10.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn10.Header.VisiblePosition = 1
        UltraGridColumn11.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn11.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn11.Header.VisiblePosition = 2
        UltraGridColumn12.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn12.Header.VisiblePosition = 3
        UltraGridColumn12.Hidden = True
        UltraGridBand3.Columns.AddRange(New Object() {UltraGridColumn9, UltraGridColumn10, UltraGridColumn11, UltraGridColumn12})
        Me.ug_Relacion.DisplayLayout.BandsSerializer.Add(UltraGridBand3)
        Me.ug_Relacion.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.[False]
        Me.ug_Relacion.DisplayLayout.MaxColScrollRegions = 1
        Me.ug_Relacion.DisplayLayout.MaxRowScrollRegions = 1
        Me.ug_Relacion.DisplayLayout.Override.AllowDelete = Infragistics.Win.DefaultableBoolean.[True]
        Appearance6.BackColor = System.Drawing.Color.WhiteSmoke
        Appearance6.BackColor2 = System.Drawing.Color.WhiteSmoke
        Me.ug_Relacion.DisplayLayout.Override.RowAlternateAppearance = Appearance6
        Me.ug_Relacion.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.[True]
        Me.ug_Relacion.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.ug_Relacion.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.ug_Relacion.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ug_Relacion.Location = New System.Drawing.Point(11, 396)
        Me.ug_Relacion.Name = "ug_Relacion"
        Me.ug_Relacion.Size = New System.Drawing.Size(688, 156)
        Me.ug_Relacion.TabIndex = 0
        Me.ug_Relacion.Text = "UltraGrid1"
        '
        'uds_relacion
        '
        UltraDataColumn5.DataType = GetType(Short)
        UltraDataColumn8.DataType = GetType(Integer)
        Me.uds_relacion.Band.Columns.AddRange(New Object() {UltraDataColumn5, UltraDataColumn6, UltraDataColumn7, UltraDataColumn8})
        '
        'ubtn_agregar
        '
        Me.ubtn_agregar.Location = New System.Drawing.Point(355, 351)
        Me.ubtn_agregar.Name = "ubtn_agregar"
        Me.ubtn_agregar.Size = New System.Drawing.Size(344, 39)
        Me.ubtn_agregar.TabIndex = 1
        Me.ubtn_agregar.Text = "Agregar"
        '
        'ToolStrip1
        '
        Me.ToolStrip1.BackColor = System.Drawing.Color.Gainsboro
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton1, Me.ToolStripSeparator1})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(711, 25)
        Me.ToolStrip1.TabIndex = 2
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.Image = Global.Contabilidad.My.Resources.Resources._28
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(49, 22)
        Me.ToolStripButton1.Text = "Salir"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'UltraLabel1
        '
        Appearance4.BackColor = System.Drawing.Color.DeepSkyBlue
        Appearance4.FontData.BoldAsString = "True"
        Appearance4.FontData.SizeInPoints = 12.0!
        Appearance4.ForeColor = System.Drawing.Color.White
        Appearance4.TextHAlignAsString = "Center"
        Me.UltraLabel1.Appearance = Appearance4
        Me.UltraLabel1.Location = New System.Drawing.Point(12, 33)
        Me.UltraLabel1.Name = "UltraLabel1"
        Me.UltraLabel1.Size = New System.Drawing.Size(337, 23)
        Me.UltraLabel1.TabIndex = 3
        Me.UltraLabel1.Text = "Responsable"
        '
        'UltraLabel2
        '
        Appearance5.BackColor = System.Drawing.Color.DeepSkyBlue
        Appearance5.FontData.BoldAsString = "True"
        Appearance5.FontData.SizeInPoints = 12.0!
        Appearance5.ForeColor = System.Drawing.Color.White
        Appearance5.TextHAlignAsString = "Center"
        Me.UltraLabel2.Appearance = Appearance5
        Me.UltraLabel2.Location = New System.Drawing.Point(355, 33)
        Me.UltraLabel2.Name = "UltraLabel2"
        Me.UltraLabel2.Size = New System.Drawing.Size(344, 23)
        Me.UltraLabel2.TabIndex = 3
        Me.UltraLabel2.Text = "a Asignarse"
        '
        'lbl_con_rel
        '
        Appearance3.BackColor = System.Drawing.Color.Transparent
        Appearance3.ForeColor = System.Drawing.Color.Navy
        Me.lbl_con_rel.Appearance = Appearance3
        Me.lbl_con_rel.AutoSize = True
        Me.lbl_con_rel.Location = New System.Drawing.Point(11, 558)
        Me.lbl_con_rel.Name = "lbl_con_rel"
        Me.lbl_con_rel.Size = New System.Drawing.Size(63, 14)
        Me.lbl_con_rel.TabIndex = 4
        Me.lbl_con_rel.Text = "Descripcion"
        '
        'MA_RelacionPer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(711, 590)
        Me.Controls.Add(Me.lbl_con_rel)
        Me.Controls.Add(Me.UltraLabel2)
        Me.Controls.Add(Me.UltraLabel1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.ubtn_agregar)
        Me.Controls.Add(Me.ug_Relacion)
        Me.Controls.Add(Me.ug_ListaB)
        Me.Controls.Add(Me.ug_ListaA)
        Me.MaximizeBox = False
        Me.Name = "MA_RelacionPer"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Relacion Personal"
        CType(Me.uds_Personal, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ug_ListaA, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ug_ListaB, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ug_Relacion, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.uds_relacion, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents uds_Personal As Infragistics.Win.UltraWinDataSource.UltraDataSource
    Friend WithEvents ug_ListaA As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents ug_ListaB As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents ug_Relacion As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents ubtn_agregar As Infragistics.Win.Misc.UltraButton
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripButton1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents uds_relacion As Infragistics.Win.UltraWinDataSource.UltraDataSource
    Friend WithEvents UltraLabel1 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel2 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents lbl_con_rel As Infragistics.Win.Misc.UltraLabel
End Class
