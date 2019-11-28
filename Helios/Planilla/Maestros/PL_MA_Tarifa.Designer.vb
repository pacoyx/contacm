<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PL_MA_Tarifa
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
        Dim UltraDataColumn1 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("TA_ID_TIPO_PER")
        Dim UltraDataColumn2 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("TA_ID_TIPO_TARIFA")
        Dim UltraDataColumn3 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("TA_VALOR")
        Dim UltraGridBand1 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1)
        Dim UltraGridColumn1 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TA_ID_TIPO_PER")
        Dim UltraGridColumn2 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TA_ID_TIPO_TARIFA")
        Dim UltraGridColumn3 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TA_VALOR")
        Dim Appearance1 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Me.uds_Tarifa = New Infragistics.Win.UltraWinDataSource.UltraDataSource(Me.components)
        Me.ug_Tarifa = New Infragistics.Win.UltraWinGrid.UltraGrid()
        Me.ToolS_Mantenimiento = New System.Windows.Forms.ToolStrip()
        Me.Tool_Salir = New System.Windows.Forms.ToolStripButton()
        CType(Me.uds_Tarifa, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ug_Tarifa, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolS_Mantenimiento.SuspendLayout()
        Me.SuspendLayout()
        '
        'uds_Tarifa
        '
        UltraDataColumn1.DataType = GetType(Short)
        UltraDataColumn2.DataType = GetType(Integer)
        UltraDataColumn3.DataType = GetType(Double)
        Me.uds_Tarifa.Band.Columns.AddRange(New Object() {UltraDataColumn1, UltraDataColumn2, UltraDataColumn3})
        '
        'ug_Tarifa
        '
        Me.ug_Tarifa.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ug_Tarifa.DataSource = Me.uds_Tarifa
        Me.ug_Tarifa.DisplayLayout.AutoFitStyle = Infragistics.Win.UltraWinGrid.AutoFitStyle.ExtendLastColumn
        UltraGridColumn1.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn1.Header.Caption = "Tipo Personal"
        UltraGridColumn1.Header.VisiblePosition = 0
        UltraGridColumn1.Width = 146
        UltraGridColumn2.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn2.Header.Caption = "Tipo Tarifa"
        UltraGridColumn2.Header.VisiblePosition = 1
        UltraGridColumn2.Width = 205
        UltraGridColumn3.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        Appearance1.TextHAlignAsString = "Right"
        UltraGridColumn3.CellAppearance = Appearance1
        UltraGridColumn3.Header.Caption = "Valor por Hora"
        UltraGridColumn3.Header.VisiblePosition = 2
        UltraGridColumn3.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Double]
        UltraGridBand1.Columns.AddRange(New Object() {UltraGridColumn1, UltraGridColumn2, UltraGridColumn3})
        Me.ug_Tarifa.DisplayLayout.BandsSerializer.Add(UltraGridBand1)
        Me.ug_Tarifa.DisplayLayout.Override.AllowAddNew = Infragistics.Win.UltraWinGrid.AllowAddNew.TemplateOnBottom
        Me.ug_Tarifa.Location = New System.Drawing.Point(12, 42)
        Me.ug_Tarifa.Name = "ug_Tarifa"
        Me.ug_Tarifa.Size = New System.Drawing.Size(595, 260)
        Me.ug_Tarifa.TabIndex = 0
        '
        'ToolS_Mantenimiento
        '
        Me.ToolS_Mantenimiento.BackColor = System.Drawing.Color.Gainsboro
        Me.ToolS_Mantenimiento.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Tool_Salir})
        Me.ToolS_Mantenimiento.Location = New System.Drawing.Point(0, 0)
        Me.ToolS_Mantenimiento.Name = "ToolS_Mantenimiento"
        Me.ToolS_Mantenimiento.Size = New System.Drawing.Size(619, 25)
        Me.ToolS_Mantenimiento.TabIndex = 6
        Me.ToolS_Mantenimiento.Text = "ToolStrip1"
        '
        'Tool_Salir
        '
        Me.Tool_Salir.Image = Global.Contabilidad.My.Resources.Resources._28
        Me.Tool_Salir.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Tool_Salir.Name = "Tool_Salir"
        Me.Tool_Salir.Size = New System.Drawing.Size(47, 22)
        Me.Tool_Salir.Text = "Salir"
        '
        'PL_MA_Tarifa
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(619, 314)
        Me.Controls.Add(Me.ToolS_Mantenimiento)
        Me.Controls.Add(Me.ug_Tarifa)
        Me.Name = "PL_MA_Tarifa"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Tarifa de Horas - Personal X Horas"
        CType(Me.uds_Tarifa, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ug_Tarifa, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolS_Mantenimiento.ResumeLayout(False)
        Me.ToolS_Mantenimiento.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents uds_Tarifa As Infragistics.Win.UltraWinDataSource.UltraDataSource
    Friend WithEvents ug_Tarifa As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents ToolS_Mantenimiento As System.Windows.Forms.ToolStrip
    Friend WithEvents Tool_Salir As System.Windows.Forms.ToolStripButton
End Class
