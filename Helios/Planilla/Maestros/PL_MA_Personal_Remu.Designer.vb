<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PL_MA_Personal_Remu
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
        Me.components = New System.ComponentModel.Container
        Dim UltraDataColumn1 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("PR_ITEM")
        Dim UltraDataColumn2 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("PR_FECHA")
        Dim UltraDataColumn3 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("PR_REMUNERACION")
        Dim UltraGridBand1 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1)
        Dim UltraGridColumn1 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("PR_ITEM")
        Dim UltraGridColumn2 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("PR_FECHA")
        Dim UltraGridColumn3 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("PR_REMUNERACION")
        Dim Appearance1 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance4 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Me.uds_Remus = New Infragistics.Win.UltraWinDataSource.UltraDataSource(Me.components)
        Me.ug_remus = New Infragistics.Win.UltraWinGrid.UltraGrid
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip
        Me.Tool_Salir = New System.Windows.Forms.ToolStripButton
        CType(Me.uds_Remus, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ug_remus, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'uds_Remus
        '
        UltraDataColumn1.DataType = GetType(Short)
        UltraDataColumn2.DataType = GetType(Date)
        UltraDataColumn3.DataType = GetType(Double)
        Me.uds_Remus.Band.Columns.AddRange(New Object() {UltraDataColumn1, UltraDataColumn2, UltraDataColumn3})
        '
        'ug_remus
        '
        Me.ug_remus.DataSource = Me.uds_Remus
        Me.ug_remus.DisplayLayout.AutoFitStyle = Infragistics.Win.UltraWinGrid.AutoFitStyle.ExtendLastColumn
        UltraGridColumn1.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn1.Header.Caption = "Numero"
        UltraGridColumn1.Header.VisiblePosition = 0
        UltraGridColumn1.Width = 37
        UltraGridColumn2.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn2.Header.Caption = "Fecha"
        UltraGridColumn2.Header.VisiblePosition = 1
        UltraGridColumn2.Width = 79
        UltraGridColumn3.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        Appearance1.TextHAlignAsString = "Right"
        UltraGridColumn3.CellAppearance = Appearance1
        UltraGridColumn3.Header.Caption = "Remuneracion"
        UltraGridColumn3.Header.VisiblePosition = 2
        UltraGridColumn3.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Double]
        UltraGridColumn3.Width = 119
        UltraGridBand1.Columns.AddRange(New Object() {UltraGridColumn1, UltraGridColumn2, UltraGridColumn3})
        Me.ug_remus.DisplayLayout.BandsSerializer.Add(UltraGridBand1)
        Me.ug_remus.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.[False]
        Me.ug_remus.DisplayLayout.MaxColScrollRegions = 1
        Me.ug_remus.DisplayLayout.MaxRowScrollRegions = 1
        Me.ug_remus.DisplayLayout.Override.AllowAddNew = Infragistics.Win.UltraWinGrid.AllowAddNew.TemplateOnBottom
        Me.ug_remus.DisplayLayout.Override.AllowDelete = Infragistics.Win.DefaultableBoolean.[True]
        Me.ug_remus.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.[True]
        Appearance4.BackColor = System.Drawing.Color.WhiteSmoke
        Appearance4.BackColor2 = System.Drawing.Color.WhiteSmoke
        Me.ug_remus.DisplayLayout.Override.RowAlternateAppearance = Appearance4
        Me.ug_remus.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.ug_remus.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ug_remus.Location = New System.Drawing.Point(12, 41)
        Me.ug_remus.Name = "ug_remus"
        Me.ug_remus.Size = New System.Drawing.Size(309, 232)
        Me.ug_remus.TabIndex = 0
        Me.ug_remus.Text = "UltraGrid1"
        '
        'ToolStrip1
        '
        Me.ToolStrip1.BackColor = System.Drawing.Color.Gainsboro
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Tool_Salir})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(332, 25)
        Me.ToolStrip1.TabIndex = 1
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
        'PL_MA_Personal_Remu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(332, 285)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.ug_remus)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "PL_MA_Personal_Remu"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Historial de Remuneraciones"
        CType(Me.uds_Remus, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ug_remus, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents uds_Remus As Infragistics.Win.UltraWinDataSource.UltraDataSource
    Friend WithEvents ug_remus As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents Tool_Salir As System.Windows.Forms.ToolStripButton
End Class
