<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PL_PR_Cronograma
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
        Dim UltraDataColumn1 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Num")
        Dim UltraDataColumn2 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Fecha")
        Dim UltraDataColumn3 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Capital")
        Dim UltraDataColumn4 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Cuota")
        Dim UltraDataColumn5 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Interes")
        Dim UltraDataColumn6 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("PagoTotal")
        Dim UltraGridBand1 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1)
        Dim UltraGridColumn1 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Num")
        Dim Appearance2 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn2 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Fecha")
        Dim UltraGridColumn3 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Capital")
        Dim Appearance3 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn4 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Cuota")
        Dim Appearance4 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn5 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Interes")
        Dim Appearance5 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn6 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("PagoTotal")
        Dim Appearance6 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance1 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Me.uds_Data = New Infragistics.Win.UltraWinDataSource.UltraDataSource(Me.components)
        Me.ug_Crono = New Infragistics.Win.UltraWinGrid.UltraGrid()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.Tool_Salir = New System.Windows.Forms.ToolStripButton()
        CType(Me.uds_Data, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ug_Crono, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'uds_Data
        '
        Me.uds_Data.AllowDelete = False
        UltraDataColumn1.DataType = GetType(Short)
        UltraDataColumn2.DataType = GetType(Date)
        UltraDataColumn3.DataType = GetType(Double)
        UltraDataColumn4.DataType = GetType(Double)
        UltraDataColumn5.DataType = GetType(Double)
        UltraDataColumn6.DataType = GetType(Double)
        Me.uds_Data.Band.Columns.AddRange(New Object() {UltraDataColumn1, UltraDataColumn2, UltraDataColumn3, UltraDataColumn4, UltraDataColumn5, UltraDataColumn6})
        '
        'ug_Crono
        '
        Me.ug_Crono.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ug_Crono.DataSource = Me.uds_Data
        Me.ug_Crono.DisplayLayout.AutoFitStyle = Infragistics.Win.UltraWinGrid.AutoFitStyle.ExtendLastColumn
        UltraGridColumn1.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        Appearance2.TextHAlignAsString = "Center"
        UltraGridColumn1.CellAppearance = Appearance2
        UltraGridColumn1.Header.VisiblePosition = 0
        UltraGridColumn1.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Integer]
        UltraGridColumn1.Width = 38
        UltraGridColumn2.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn2.Header.VisiblePosition = 1
        UltraGridColumn2.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Date]
        UltraGridColumn2.Width = 72
        UltraGridColumn3.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        Appearance3.TextHAlignAsString = "Right"
        UltraGridColumn3.CellAppearance = Appearance3
        UltraGridColumn3.Header.VisiblePosition = 2
        UltraGridColumn3.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Double]
        UltraGridColumn3.Width = 89
        UltraGridColumn4.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        Appearance4.TextHAlignAsString = "Right"
        UltraGridColumn4.CellAppearance = Appearance4
        UltraGridColumn4.Header.VisiblePosition = 3
        UltraGridColumn4.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Double]
        UltraGridColumn5.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        Appearance5.TextHAlignAsString = "Right"
        UltraGridColumn5.CellAppearance = Appearance5
        UltraGridColumn5.Header.VisiblePosition = 4
        UltraGridColumn5.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Double]
        UltraGridColumn5.Width = 73
        UltraGridColumn6.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        Appearance6.TextHAlignAsString = "Right"
        UltraGridColumn6.CellAppearance = Appearance6
        UltraGridColumn6.Header.VisiblePosition = 5
        UltraGridColumn6.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Double]
        UltraGridBand1.Columns.AddRange(New Object() {UltraGridColumn1, UltraGridColumn2, UltraGridColumn3, UltraGridColumn4, UltraGridColumn5, UltraGridColumn6})
        Me.ug_Crono.DisplayLayout.BandsSerializer.Add(UltraGridBand1)
        Me.ug_Crono.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.[False]
        Appearance1.BackColor = System.Drawing.Color.WhiteSmoke
        Appearance1.BackColor2 = System.Drawing.Color.WhiteSmoke
        Me.ug_Crono.DisplayLayout.Override.RowAlternateAppearance = Appearance1
        Me.ug_Crono.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ug_Crono.Location = New System.Drawing.Point(12, 43)
        Me.ug_Crono.Name = "ug_Crono"
        Me.ug_Crono.Size = New System.Drawing.Size(480, 256)
        Me.ug_Crono.TabIndex = 0
        Me.ug_Crono.Text = "UltraGrid1"
        '
        'ToolStrip1
        '
        Me.ToolStrip1.BackColor = System.Drawing.Color.Gainsboro
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Tool_Salir})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(504, 25)
        Me.ToolStrip1.TabIndex = 2
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'Tool_Salir
        '
        Me.Tool_Salir.Image = Global.Contabilidad.My.Resources.Resources._28
        Me.Tool_Salir.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Tool_Salir.Name = "Tool_Salir"
        Me.Tool_Salir.Size = New System.Drawing.Size(47, 22)
        Me.Tool_Salir.Text = "Salir"
        '
        'PL_PR_Cronograma
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(504, 305)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.ug_Crono)
        Me.Name = "PL_PR_Cronograma"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cronograma Temporal"
        CType(Me.uds_Data, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ug_Crono, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents uds_Data As Infragistics.Win.UltraWinDataSource.UltraDataSource
    Friend WithEvents ug_Crono As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents Tool_Salir As System.Windows.Forms.ToolStripButton
End Class
