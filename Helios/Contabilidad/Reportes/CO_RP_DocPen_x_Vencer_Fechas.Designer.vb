<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CO_RP_DocPen_x_Vencer_Fechas
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
        Dim UltraDataColumn1 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("RF_ITEM")
        Dim UltraDataColumn2 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("RF_FECHA1")
        Dim UltraDataColumn3 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("RF_FECHA2")
        Dim UltraGridBand1 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1)
        Dim UltraGridColumn1 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("RF_ITEM")
        Dim Appearance3 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn2 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("RF_FECHA1")
        Dim UltraGridColumn3 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("RF_FECHA2")
        Dim Appearance2 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance1 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance23 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance12 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Me.uds_Fechas = New Infragistics.Win.UltraWinDataSource.UltraDataSource(Me.components)
        Me.ug_Fechas = New Infragistics.Win.UltraWinGrid.UltraGrid()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.Tool_Aceptar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.Tool_salir = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.UltraGroupBox1 = New Infragistics.Win.Misc.UltraGroupBox()
        Me.une_Ayo = New Infragistics.Win.UltraWinEditors.UltraNumericEditor()
        Me.UltraLabel7 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraLabel8 = New Infragistics.Win.Misc.UltraLabel()
        Me.uce_Mes = New Infragistics.Win.UltraWinEditors.UltraComboEditor()
        CType(Me.uds_Fechas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ug_Fechas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip1.SuspendLayout()
        CType(Me.UltraGroupBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraGroupBox1.SuspendLayout()
        CType(Me.une_Ayo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.uce_Mes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'uds_Fechas
        '
        UltraDataColumn1.DataType = GetType(Short)
        UltraDataColumn2.DataType = GetType(Date)
        UltraDataColumn3.DataType = GetType(Date)
        Me.uds_Fechas.Band.Columns.AddRange(New Object() {UltraDataColumn1, UltraDataColumn2, UltraDataColumn3})
        '
        'ug_Fechas
        '
        Me.ug_Fechas.DataSource = Me.uds_Fechas
        Me.ug_Fechas.DisplayLayout.AutoFitStyle = Infragistics.Win.UltraWinGrid.AutoFitStyle.ExtendLastColumn
        UltraGridColumn1.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn1.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        Appearance3.TextHAlignAsString = "Center"
        UltraGridColumn1.CellAppearance = Appearance3
        UltraGridColumn1.Header.Caption = "Secuencia"
        UltraGridColumn1.Header.VisiblePosition = 0
        UltraGridColumn1.Width = 79
        UltraGridColumn2.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn2.Header.Caption = "Fecha 1"
        UltraGridColumn2.Header.VisiblePosition = 1
        UltraGridColumn2.Width = 145
        UltraGridColumn3.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn3.Header.Caption = "Fecha 2"
        UltraGridColumn3.Header.VisiblePosition = 2
        UltraGridColumn3.Width = 113
        UltraGridBand1.Columns.AddRange(New Object() {UltraGridColumn1, UltraGridColumn2, UltraGridColumn3})
        Me.ug_Fechas.DisplayLayout.BandsSerializer.Add(UltraGridBand1)
        Me.ug_Fechas.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.[False]
        Appearance2.BackColor = System.Drawing.Color.WhiteSmoke
        Appearance2.BackColor2 = System.Drawing.Color.WhiteSmoke
        Me.ug_Fechas.DisplayLayout.Override.RowAlternateAppearance = Appearance2
        Me.ug_Fechas.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ug_Fechas.Location = New System.Drawing.Point(12, 85)
        Me.ug_Fechas.Name = "ug_Fechas"
        Me.ug_Fechas.Size = New System.Drawing.Size(411, 207)
        Me.ug_Fechas.TabIndex = 0
        Me.ug_Fechas.Text = "UltraGrid1"
        '
        'ToolStrip1
        '
        Me.ToolStrip1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripSeparator3, Me.Tool_Aceptar, Me.ToolStripSeparator2, Me.Tool_salir, Me.ToolStripSeparator1})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(435, 25)
        Me.ToolStrip1.TabIndex = 204
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 25)
        '
        'Tool_Aceptar
        '
        Me.Tool_Aceptar.Image = Global.Contabilidad.My.Resources.Resources._16__Ok_
        Me.Tool_Aceptar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Tool_Aceptar.Name = "Tool_Aceptar"
        Me.Tool_Aceptar.Size = New System.Drawing.Size(68, 22)
        Me.Tool_Aceptar.Text = "Aceptar"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'Tool_salir
        '
        Me.Tool_salir.Image = Global.Contabilidad.My.Resources.Resources._28
        Me.Tool_salir.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Tool_salir.Name = "Tool_salir"
        Me.Tool_salir.Size = New System.Drawing.Size(49, 22)
        Me.Tool_salir.Text = "Salir"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'UltraGroupBox1
        '
        Me.UltraGroupBox1.Controls.Add(Me.une_Ayo)
        Me.UltraGroupBox1.Controls.Add(Me.UltraLabel7)
        Me.UltraGroupBox1.Controls.Add(Me.UltraLabel8)
        Me.UltraGroupBox1.Controls.Add(Me.uce_Mes)
        Me.UltraGroupBox1.Location = New System.Drawing.Point(12, 37)
        Me.UltraGroupBox1.Name = "UltraGroupBox1"
        Me.UltraGroupBox1.Size = New System.Drawing.Size(411, 42)
        Me.UltraGroupBox1.TabIndex = 205
        '
        'une_Ayo
        '
        Appearance1.TextHAlignAsString = "Center"
        Me.une_Ayo.Appearance = Appearance1
        Me.une_Ayo.Location = New System.Drawing.Point(52, 13)
        Me.une_Ayo.MaskInput = "nnnn"
        Me.une_Ayo.Name = "une_Ayo"
        Me.une_Ayo.Size = New System.Drawing.Size(36, 21)
        Me.une_Ayo.TabIndex = 17
        '
        'UltraLabel7
        '
        Appearance23.BackColor = System.Drawing.Color.Transparent
        Appearance23.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel7.Appearance = Appearance23
        Me.UltraLabel7.AutoSize = True
        Me.UltraLabel7.Location = New System.Drawing.Point(19, 17)
        Me.UltraLabel7.Name = "UltraLabel7"
        Me.UltraLabel7.Size = New System.Drawing.Size(30, 14)
        Me.UltraLabel7.TabIndex = 16
        Me.UltraLabel7.Text = "Año :"
        '
        'UltraLabel8
        '
        Appearance12.BackColor = System.Drawing.Color.Transparent
        Appearance12.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel8.Appearance = Appearance12
        Me.UltraLabel8.AutoSize = True
        Me.UltraLabel8.Location = New System.Drawing.Point(100, 17)
        Me.UltraLabel8.Name = "UltraLabel8"
        Me.UltraLabel8.Size = New System.Drawing.Size(32, 14)
        Me.UltraLabel8.TabIndex = 15
        Me.UltraLabel8.Text = "Mes :"
        '
        'uce_Mes
        '
        Me.uce_Mes.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.uce_Mes.Location = New System.Drawing.Point(135, 11)
        Me.uce_Mes.Name = "uce_Mes"
        Me.uce_Mes.Size = New System.Drawing.Size(120, 21)
        Me.uce_Mes.TabIndex = 14
        '
        'CO_RP_DocPen_x_Vencer_Fechas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(435, 299)
        Me.Controls.Add(Me.UltraGroupBox1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.ug_Fechas)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "CO_RP_DocPen_x_Vencer_Fechas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Fechas para reporte"
        CType(Me.uds_Fechas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ug_Fechas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        CType(Me.UltraGroupBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraGroupBox1.ResumeLayout(False)
        Me.UltraGroupBox1.PerformLayout()
        CType(Me.une_Ayo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.uce_Mes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents uds_Fechas As Infragistics.Win.UltraWinDataSource.UltraDataSource
    Friend WithEvents ug_Fechas As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents Tool_Aceptar As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents Tool_salir As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents UltraGroupBox1 As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents une_Ayo As Infragistics.Win.UltraWinEditors.UltraNumericEditor
    Friend WithEvents UltraLabel7 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel8 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents uce_Mes As Infragistics.Win.UltraWinEditors.UltraComboEditor
End Class
