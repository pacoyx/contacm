<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CO_PR_DocsProve
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
        Dim UltraGridColumn1 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Sel")
        Dim UltraGridColumn2 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FECHA")
        Dim UltraGridColumn3 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TD")
        Dim UltraGridColumn4 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("SD")
        Dim UltraGridColumn5 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ND")
        Dim UltraGridColumn6 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IMPORTE")
        Dim Appearance6 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn7 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ID_DOC")
        Dim Appearance8 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraDataColumn1 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Sel")
        Dim UltraDataColumn2 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("FECHA")
        Dim UltraDataColumn3 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("TD")
        Dim UltraDataColumn4 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("SD")
        Dim UltraDataColumn5 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("ND")
        Dim UltraDataColumn6 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IMPORTE")
        Dim UltraDataColumn7 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("ID_DOC")
        Dim Appearance1 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance2 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance4 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance3 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance5 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance86 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance9 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Me.ug_Documentos = New Infragistics.Win.UltraWinGrid.UltraGrid()
        Me.uds_Documentos = New Infragistics.Win.UltraWinDataSource.UltraDataSource(Me.components)
        Me.ToolStrip2 = New System.Windows.Forms.ToolStrip()
        Me.Tool_Aceptar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.Tool_Salir = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.UltraLabel23 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraLabel1 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraLabel2 = New Infragistics.Win.Misc.UltraLabel()
        Me.txt_num_detra = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.txt_fecha_detra = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.lbl_num_filas = New Infragistics.Win.Misc.UltraLabel()
        Me.txt_num_filas = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        CType(Me.ug_Documentos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.uds_Documentos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip2.SuspendLayout()
        CType(Me.txt_num_detra, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_fecha_detra, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_num_filas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ug_Documentos
        '
        Me.ug_Documentos.DataSource = Me.uds_Documentos
        Me.ug_Documentos.DisplayLayout.AutoFitStyle = Infragistics.Win.UltraWinGrid.AutoFitStyle.ResizeAllColumns
        UltraGridColumn1.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn1.Header.VisiblePosition = 0
        UltraGridColumn1.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.CheckBox
        UltraGridColumn1.Width = 48
        UltraGridColumn2.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn2.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn2.Header.VisiblePosition = 1
        UltraGridColumn2.Width = 75
        UltraGridColumn3.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn3.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn3.Header.VisiblePosition = 2
        UltraGridColumn3.Width = 58
        UltraGridColumn4.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn4.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn4.Header.VisiblePosition = 3
        UltraGridColumn4.Width = 48
        UltraGridColumn5.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn5.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn5.Header.VisiblePosition = 4
        UltraGridColumn5.Width = 328
        UltraGridColumn6.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn6.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        Appearance6.TextHAlignAsString = "Right"
        UltraGridColumn6.CellAppearance = Appearance6
        UltraGridColumn6.Header.VisiblePosition = 5
        UltraGridColumn6.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Double]
        UltraGridColumn6.Width = 180
        UltraGridColumn7.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn7.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn7.Header.VisiblePosition = 6
        UltraGridColumn7.Hidden = True
        UltraGridColumn7.Width = 80
        UltraGridBand1.Columns.AddRange(New Object() {UltraGridColumn1, UltraGridColumn2, UltraGridColumn3, UltraGridColumn4, UltraGridColumn5, UltraGridColumn6, UltraGridColumn7})
        Me.ug_Documentos.DisplayLayout.BandsSerializer.Add(UltraGridBand1)
        Me.ug_Documentos.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.[True]
        Me.ug_Documentos.DisplayLayout.MaxRowScrollRegions = 1
        Me.ug_Documentos.DisplayLayout.Override.AllowDelete = Infragistics.Win.DefaultableBoolean.[False]
        Me.ug_Documentos.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.[True]
        Me.ug_Documentos.DisplayLayout.Override.FilterOperatorDefaultValue = Infragistics.Win.UltraWinGrid.FilterOperatorDefaultValue.Contains
        Appearance8.BackColor = System.Drawing.Color.LightGoldenrodYellow
        Me.ug_Documentos.DisplayLayout.Override.FilterRowAppearance = Appearance8
        Me.ug_Documentos.DisplayLayout.Override.FilterUIType = Infragistics.Win.UltraWinGrid.FilterUIType.FilterRow
        Me.ug_Documentos.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Me.ug_Documentos.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.ug_Documentos.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.ug_Documentos.DisplayLayout.ViewStyle = Infragistics.Win.UltraWinGrid.ViewStyle.SingleBand
        Me.ug_Documentos.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ug_Documentos.Location = New System.Drawing.Point(8, 91)
        Me.ug_Documentos.Name = "ug_Documentos"
        Me.ug_Documentos.Size = New System.Drawing.Size(758, 308)
        Me.ug_Documentos.TabIndex = 1
        Me.ug_Documentos.Text = "Comprobantes de Compras"
        '
        'uds_Documentos
        '
        Me.uds_Documentos.AllowDelete = False
        UltraDataColumn1.DataType = GetType(Boolean)
        UltraDataColumn2.DataType = GetType(Date)
        UltraDataColumn6.DataType = GetType(Double)
        UltraDataColumn7.DataType = GetType(Long)
        Me.uds_Documentos.Band.Columns.AddRange(New Object() {UltraDataColumn1, UltraDataColumn2, UltraDataColumn3, UltraDataColumn4, UltraDataColumn5, UltraDataColumn6, UltraDataColumn7})
        '
        'ToolStrip2
        '
        Me.ToolStrip2.BackColor = System.Drawing.Color.Gainsboro
        Me.ToolStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Tool_Aceptar, Me.ToolStripSeparator5, Me.ToolStripSeparator3, Me.ToolStripSeparator1, Me.Tool_Salir, Me.ToolStripSeparator2})
        Me.ToolStrip2.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip2.Name = "ToolStrip2"
        Me.ToolStrip2.Size = New System.Drawing.Size(772, 25)
        Me.ToolStrip2.TabIndex = 11
        Me.ToolStrip2.Text = "ToolStrip2"
        '
        'Tool_Aceptar
        '
        Me.Tool_Aceptar.Image = Global.Contabilidad.My.Resources.Resources._16__Ok_
        Me.Tool_Aceptar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Tool_Aceptar.Name = "Tool_Aceptar"
        Me.Tool_Aceptar.Size = New System.Drawing.Size(68, 22)
        Me.Tool_Aceptar.Text = "Aceptar"
        '
        'ToolStripSeparator5
        '
        Me.ToolStripSeparator5.Name = "ToolStripSeparator5"
        Me.ToolStripSeparator5.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 25)
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
        Me.Tool_Salir.Size = New System.Drawing.Size(55, 22)
        Me.Tool_Salir.Text = "Salir  "
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'UltraLabel23
        '
        Appearance1.BackColor = System.Drawing.Color.Transparent
        Appearance1.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel23.Appearance = Appearance1
        Me.UltraLabel23.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel23.Location = New System.Drawing.Point(8, 45)
        Me.UltraLabel23.Name = "UltraLabel23"
        Me.UltraLabel23.Size = New System.Drawing.Size(376, 40)
        Me.UltraLabel23.TabIndex = 44
        Me.UltraLabel23.Text = "Seleccione los comprobantes  de compras y de clic en Aceptar para actualizar sus " & _
            "datos de detraccion"
        '
        'UltraLabel1
        '
        Appearance2.BackColor = System.Drawing.Color.Transparent
        Appearance2.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel1.Appearance = Appearance2
        Me.UltraLabel1.AutoSize = True
        Me.UltraLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel1.Location = New System.Drawing.Point(535, 35)
        Me.UltraLabel1.Name = "UltraLabel1"
        Me.UltraLabel1.Size = New System.Drawing.Size(123, 14)
        Me.UltraLabel1.TabIndex = 45
        Me.UltraLabel1.Text = "Numero de Detraccion :"
        '
        'UltraLabel2
        '
        Appearance4.BackColor = System.Drawing.Color.Transparent
        Appearance4.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel2.Appearance = Appearance4
        Me.UltraLabel2.AutoSize = True
        Me.UltraLabel2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel2.Location = New System.Drawing.Point(543, 60)
        Me.UltraLabel2.Name = "UltraLabel2"
        Me.UltraLabel2.Size = New System.Drawing.Size(115, 14)
        Me.UltraLabel2.TabIndex = 46
        Me.UltraLabel2.Text = "Fecha de Detraccion :"
        '
        'txt_num_detra
        '
        Appearance3.TextHAlignAsString = "Left"
        Me.txt_num_detra.Appearance = Appearance3
        Me.txt_num_detra.Location = New System.Drawing.Point(664, 31)
        Me.txt_num_detra.Name = "txt_num_detra"
        Me.txt_num_detra.ReadOnly = True
        Me.txt_num_detra.Size = New System.Drawing.Size(92, 21)
        Me.txt_num_detra.TabIndex = 47
        '
        'txt_fecha_detra
        '
        Appearance5.TextHAlignAsString = "Left"
        Me.txt_fecha_detra.Appearance = Appearance5
        Me.txt_fecha_detra.Location = New System.Drawing.Point(664, 56)
        Me.txt_fecha_detra.Name = "txt_fecha_detra"
        Me.txt_fecha_detra.ReadOnly = True
        Me.txt_fecha_detra.Size = New System.Drawing.Size(92, 21)
        Me.txt_fecha_detra.TabIndex = 48
        '
        'lbl_num_filas
        '
        Appearance86.BackColor = System.Drawing.Color.Transparent
        Appearance86.ForeColor = System.Drawing.Color.Navy
        Me.lbl_num_filas.Appearance = Appearance86
        Me.lbl_num_filas.AutoSize = True
        Me.lbl_num_filas.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_num_filas.Location = New System.Drawing.Point(11, 409)
        Me.lbl_num_filas.Name = "lbl_num_filas"
        Me.lbl_num_filas.Size = New System.Drawing.Size(130, 14)
        Me.lbl_num_filas.TabIndex = 49
        Me.lbl_num_filas.Text = "Num. de Comprobantes :"
        '
        'txt_num_filas
        '
        Appearance9.TextHAlignAsString = "Left"
        Me.txt_num_filas.Appearance = Appearance9
        Me.txt_num_filas.Location = New System.Drawing.Point(147, 405)
        Me.txt_num_filas.Name = "txt_num_filas"
        Me.txt_num_filas.ReadOnly = True
        Me.txt_num_filas.Size = New System.Drawing.Size(57, 21)
        Me.txt_num_filas.TabIndex = 50
        '
        'CO_PR_DocsProve
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(772, 430)
        Me.Controls.Add(Me.txt_num_filas)
        Me.Controls.Add(Me.lbl_num_filas)
        Me.Controls.Add(Me.txt_fecha_detra)
        Me.Controls.Add(Me.txt_num_detra)
        Me.Controls.Add(Me.UltraLabel2)
        Me.Controls.Add(Me.UltraLabel1)
        Me.Controls.Add(Me.UltraLabel23)
        Me.Controls.Add(Me.ToolStrip2)
        Me.Controls.Add(Me.ug_Documentos)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "CO_PR_DocsProve"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Documentos"
        CType(Me.ug_Documentos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.uds_Documentos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip2.ResumeLayout(False)
        Me.ToolStrip2.PerformLayout()
        CType(Me.txt_num_detra, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_fecha_detra, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_num_filas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ug_Documentos As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents uds_Documentos As Infragistics.Win.UltraWinDataSource.UltraDataSource
    Friend WithEvents ToolStrip2 As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripSeparator5 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents Tool_Salir As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents UltraLabel23 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel1 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel2 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents txt_num_detra As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents txt_fecha_detra As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents lbl_num_filas As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents txt_num_filas As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents Tool_Aceptar As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
End Class
