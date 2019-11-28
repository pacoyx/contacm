<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PL_RP_Detalle_Planilla
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
        Dim Appearance13 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance15 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance2 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraDataColumn1 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("CO_ID")
        Dim UltraDataColumn2 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("CO_DESCRIPCION")
        Dim UltraDataColumn3 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("sel")
        Dim UltraGridBand1 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1)
        Dim UltraGridColumn1 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CO_ID")
        Dim UltraGridColumn2 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CO_DESCRIPCION")
        Dim UltraGridColumn3 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("sel")
        Dim Appearance1 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.Tool_imprimir = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.Tool_Salir = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.UltraGroupBox1 = New Infragistics.Win.Misc.UltraGroupBox()
        Me.uce_TipoPersonal = New Infragistics.Win.UltraWinEditors.UltraComboEditor()
        Me.UltraLabel2 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraLabel3 = New Infragistics.Win.Misc.UltraLabel()
        Me.uce_Mes = New Infragistics.Win.UltraWinEditors.UltraComboEditor()
        Me.une_ayo = New Infragistics.Win.UltraWinEditors.UltraNumericEditor()
        Me.UltraLabel1 = New Infragistics.Win.Misc.UltraLabel()
        Me.uos_identificador = New Infragistics.Win.UltraWinEditors.UltraOptionSet()
        Me.uds_conceptos = New Infragistics.Win.UltraWinDataSource.UltraDataSource(Me.components)
        Me.ug_conceptos = New Infragistics.Win.UltraWinGrid.UltraGrid()
        Me.UltraGroupBox2 = New Infragistics.Win.Misc.UltraGroupBox()
        Me.ToolStrip1.SuspendLayout()
        CType(Me.UltraGroupBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraGroupBox1.SuspendLayout()
        CType(Me.uce_TipoPersonal, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.uce_Mes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.une_ayo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.uos_identificador, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.uds_conceptos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ug_conceptos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UltraGroupBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraGroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'ToolStrip1
        '
        Me.ToolStrip1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripSeparator4, Me.Tool_imprimir, Me.ToolStripSeparator2, Me.Tool_Salir, Me.ToolStripSeparator1})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(493, 25)
        Me.ToolStrip1.TabIndex = 11
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(6, 25)
        '
        'Tool_imprimir
        '
        Me.Tool_imprimir.Image = Global.Contabilidad.My.Resources.Resources._004
        Me.Tool_imprimir.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Tool_imprimir.Name = "Tool_imprimir"
        Me.Tool_imprimir.Size = New System.Drawing.Size(65, 22)
        Me.Tool_imprimir.Text = "Imprimir"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'Tool_Salir
        '
        Me.Tool_Salir.Image = Global.Contabilidad.My.Resources.Resources._28
        Me.Tool_Salir.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Tool_Salir.Name = "Tool_Salir"
        Me.Tool_Salir.Size = New System.Drawing.Size(47, 22)
        Me.Tool_Salir.Text = "Salir"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'UltraGroupBox1
        '
        Me.UltraGroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.UltraGroupBox1.Controls.Add(Me.uce_TipoPersonal)
        Me.UltraGroupBox1.Controls.Add(Me.UltraLabel2)
        Me.UltraGroupBox1.Controls.Add(Me.UltraLabel3)
        Me.UltraGroupBox1.Controls.Add(Me.uce_Mes)
        Me.UltraGroupBox1.Controls.Add(Me.une_ayo)
        Me.UltraGroupBox1.Controls.Add(Me.UltraLabel1)
        Me.UltraGroupBox1.Location = New System.Drawing.Point(12, 37)
        Me.UltraGroupBox1.Name = "UltraGroupBox1"
        Me.UltraGroupBox1.Size = New System.Drawing.Size(466, 46)
        Me.UltraGroupBox1.TabIndex = 18
        '
        'uce_TipoPersonal
        '
        Me.uce_TipoPersonal.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.uce_TipoPersonal.Location = New System.Drawing.Point(335, 12)
        Me.uce_TipoPersonal.Name = "uce_TipoPersonal"
        Me.uce_TipoPersonal.Size = New System.Drawing.Size(116, 21)
        Me.uce_TipoPersonal.TabIndex = 16
        '
        'UltraLabel2
        '
        Appearance13.BackColor = System.Drawing.Color.Transparent
        Appearance13.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel2.Appearance = Appearance13
        Me.UltraLabel2.AutoSize = True
        Me.UltraLabel2.Location = New System.Drawing.Point(255, 16)
        Me.UltraLabel2.Name = "UltraLabel2"
        Me.UltraLabel2.Size = New System.Drawing.Size(74, 14)
        Me.UltraLabel2.TabIndex = 15
        Me.UltraLabel2.Text = "Tipo Personal"
        '
        'UltraLabel3
        '
        Appearance15.BackColor = System.Drawing.Color.Transparent
        Appearance15.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel3.Appearance = Appearance15
        Me.UltraLabel3.AutoSize = True
        Me.UltraLabel3.Location = New System.Drawing.Point(113, 14)
        Me.UltraLabel3.Name = "UltraLabel3"
        Me.UltraLabel3.Size = New System.Drawing.Size(26, 14)
        Me.UltraLabel3.TabIndex = 21
        Me.UltraLabel3.Text = "Mes "
        '
        'uce_Mes
        '
        Me.uce_Mes.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.uce_Mes.Location = New System.Drawing.Point(145, 12)
        Me.uce_Mes.Name = "uce_Mes"
        Me.uce_Mes.Size = New System.Drawing.Size(91, 21)
        Me.uce_Mes.TabIndex = 20
        '
        'une_ayo
        '
        Me.une_ayo.Location = New System.Drawing.Point(43, 12)
        Me.une_ayo.MaskInput = "nnnn"
        Me.une_ayo.Name = "une_ayo"
        Me.une_ayo.Size = New System.Drawing.Size(59, 21)
        Me.une_ayo.SpinButtonDisplayStyle = Infragistics.Win.ButtonDisplayStyle.Always
        Me.une_ayo.TabIndex = 19
        '
        'UltraLabel1
        '
        Appearance2.BackColor = System.Drawing.Color.Transparent
        Appearance2.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel1.Appearance = Appearance2
        Me.UltraLabel1.AutoSize = True
        Me.UltraLabel1.Location = New System.Drawing.Point(13, 16)
        Me.UltraLabel1.Name = "UltraLabel1"
        Me.UltraLabel1.Size = New System.Drawing.Size(24, 14)
        Me.UltraLabel1.TabIndex = 18
        Me.UltraLabel1.Text = "Año"
        '
        'uos_identificador
        '
        Me.uos_identificador.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.uos_identificador.Location = New System.Drawing.Point(14, 12)
        Me.uos_identificador.Name = "uos_identificador"
        Me.uos_identificador.Size = New System.Drawing.Size(437, 22)
        Me.uos_identificador.TabIndex = 19
        '
        'uds_conceptos
        '
        Me.uds_conceptos.AllowDelete = False
        UltraDataColumn3.DataType = GetType(Boolean)
        Me.uds_conceptos.Band.Columns.AddRange(New Object() {UltraDataColumn1, UltraDataColumn2, UltraDataColumn3})
        '
        'ug_conceptos
        '
        Me.ug_conceptos.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ug_conceptos.DataSource = Me.uds_conceptos
        Me.ug_conceptos.DisplayLayout.AutoFitStyle = Infragistics.Win.UltraWinGrid.AutoFitStyle.ExtendLastColumn
        UltraGridColumn1.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn1.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn1.Header.Caption = "CODIGO"
        UltraGridColumn1.Header.VisiblePosition = 1
        UltraGridColumn1.Width = 49
        UltraGridColumn2.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn2.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn2.Header.Caption = "DESCRIPCION"
        UltraGridColumn2.Header.VisiblePosition = 2
        UltraGridColumn3.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn3.Header.Caption = "X"
        UltraGridColumn3.Header.VisiblePosition = 0
        UltraGridBand1.Columns.AddRange(New Object() {UltraGridColumn1, UltraGridColumn2, UltraGridColumn3})
        Me.ug_conceptos.DisplayLayout.BandsSerializer.Add(UltraGridBand1)
        Me.ug_conceptos.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.[False]
        Me.ug_conceptos.DisplayLayout.MaxRowScrollRegions = 1
        Appearance1.BackColor = System.Drawing.Color.WhiteSmoke
        Appearance1.BackColor2 = System.Drawing.Color.WhiteSmoke
        Me.ug_conceptos.DisplayLayout.Override.RowAlternateAppearance = Appearance1
        Me.ug_conceptos.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.ug_conceptos.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ug_conceptos.Location = New System.Drawing.Point(12, 140)
        Me.ug_conceptos.Name = "ug_conceptos"
        Me.ug_conceptos.Size = New System.Drawing.Size(466, 318)
        Me.ug_conceptos.TabIndex = 20
        Me.ug_conceptos.Text = "UltraGrid1"
        '
        'UltraGroupBox2
        '
        Me.UltraGroupBox2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.UltraGroupBox2.Controls.Add(Me.uos_identificador)
        Me.UltraGroupBox2.Location = New System.Drawing.Point(12, 89)
        Me.UltraGroupBox2.Name = "UltraGroupBox2"
        Me.UltraGroupBox2.Size = New System.Drawing.Size(466, 45)
        Me.UltraGroupBox2.TabIndex = 21
        '
        'PL_RP_Detalle_Planilla
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(493, 470)
        Me.Controls.Add(Me.UltraGroupBox2)
        Me.Controls.Add(Me.ug_conceptos)
        Me.Controls.Add(Me.UltraGroupBox1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Name = "PL_RP_Detalle_Planilla"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Detalle de Planilla"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        CType(Me.UltraGroupBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraGroupBox1.ResumeLayout(False)
        Me.UltraGroupBox1.PerformLayout()
        CType(Me.uce_TipoPersonal, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.uce_Mes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.une_ayo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.uos_identificador, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.uds_conceptos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ug_conceptos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UltraGroupBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraGroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents Tool_imprimir As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents Tool_Salir As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents UltraGroupBox1 As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents une_ayo As Infragistics.Win.UltraWinEditors.UltraNumericEditor
    Friend WithEvents UltraLabel1 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents uce_TipoPersonal As Infragistics.Win.UltraWinEditors.UltraComboEditor
    Friend WithEvents UltraLabel2 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel3 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents uce_Mes As Infragistics.Win.UltraWinEditors.UltraComboEditor
    Friend WithEvents uos_identificador As Infragistics.Win.UltraWinEditors.UltraOptionSet
    Friend WithEvents uds_conceptos As Infragistics.Win.UltraWinDataSource.UltraDataSource
    Friend WithEvents ug_conceptos As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents UltraGroupBox2 As Infragistics.Win.Misc.UltraGroupBox
End Class
