<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PL_RP_GR_Distri_xEstadoCivil
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
        Dim PaintElement1 As Infragistics.UltraChart.Resources.Appearance.PaintElement = New Infragistics.UltraChart.Resources.Appearance.PaintElement()
        Dim GradientEffect1 As Infragistics.UltraChart.Resources.Appearance.GradientEffect = New Infragistics.UltraChart.Resources.Appearance.GradientEffect()
        Dim Appearance1 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance2 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Me.uc_grafico = New Infragistics.Win.UltraWinChart.UltraChart()
        Me.uchk_Cesados = New Infragistics.Win.UltraWinEditors.UltraCheckEditor()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.Tool_imprimir = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.Tool_Salir = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.uchk_3d = New Infragistics.Win.UltraWinEditors.UltraCheckEditor()
        CType(Me.uc_grafico, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        '			'UltraChart' properties's serialization: Since 'ChartType' changes the way axes look,
        '			'ChartType' must be persisted ahead of any Axes change made in design time.
        '		
        Me.uc_grafico.ChartType = Infragistics.UltraChart.[Shared].Styles.ChartType.PieChart
        '
        'uc_grafico
        '
        Me.uc_grafico.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.uc_grafico.Axis.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(220, Byte), Integer))
        PaintElement1.ElementType = Infragistics.UltraChart.[Shared].Styles.PaintElementType.None
        PaintElement1.Fill = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.uc_grafico.Axis.PE = PaintElement1
        Me.uc_grafico.Axis.X.Labels.Font = New System.Drawing.Font("Verdana", 7.0!)
        Me.uc_grafico.Axis.X.Labels.FontColor = System.Drawing.Color.DimGray
        Me.uc_grafico.Axis.X.Labels.HorizontalAlign = System.Drawing.StringAlignment.Near
        Me.uc_grafico.Axis.X.Labels.ItemFormatString = "<ITEM_LABEL>"
        Me.uc_grafico.Axis.X.Labels.Layout.Behavior = Infragistics.UltraChart.[Shared].Styles.AxisLabelLayoutBehaviors.[Auto]
        Me.uc_grafico.Axis.X.Labels.Orientation = Infragistics.UltraChart.[Shared].Styles.TextOrientation.Horizontal
        Me.uc_grafico.Axis.X.Labels.SeriesLabels.Font = New System.Drawing.Font("Verdana", 7.0!)
        Me.uc_grafico.Axis.X.Labels.SeriesLabels.FontColor = System.Drawing.Color.DimGray
        Me.uc_grafico.Axis.X.Labels.SeriesLabels.FormatString = ""
        Me.uc_grafico.Axis.X.Labels.SeriesLabels.HorizontalAlign = System.Drawing.StringAlignment.Near
        Me.uc_grafico.Axis.X.Labels.SeriesLabels.Layout.Behavior = Infragistics.UltraChart.[Shared].Styles.AxisLabelLayoutBehaviors.[Auto]
        Me.uc_grafico.Axis.X.Labels.SeriesLabels.Orientation = Infragistics.UltraChart.[Shared].Styles.TextOrientation.Horizontal
        Me.uc_grafico.Axis.X.Labels.SeriesLabels.VerticalAlign = System.Drawing.StringAlignment.Center
        Me.uc_grafico.Axis.X.Labels.VerticalAlign = System.Drawing.StringAlignment.Center
        Me.uc_grafico.Axis.X.LineThickness = 1
        Me.uc_grafico.Axis.X.MajorGridLines.AlphaLevel = CType(255, Byte)
        Me.uc_grafico.Axis.X.MajorGridLines.Color = System.Drawing.Color.Gainsboro
        Me.uc_grafico.Axis.X.MajorGridLines.DrawStyle = Infragistics.UltraChart.[Shared].Styles.LineDrawStyle.Dot
        Me.uc_grafico.Axis.X.MajorGridLines.Visible = True
        Me.uc_grafico.Axis.X.MinorGridLines.AlphaLevel = CType(255, Byte)
        Me.uc_grafico.Axis.X.MinorGridLines.Color = System.Drawing.Color.LightGray
        Me.uc_grafico.Axis.X.MinorGridLines.DrawStyle = Infragistics.UltraChart.[Shared].Styles.LineDrawStyle.Dot
        Me.uc_grafico.Axis.X.MinorGridLines.Visible = False
        Me.uc_grafico.Axis.X.TickmarkStyle = Infragistics.UltraChart.[Shared].Styles.AxisTickStyle.Smart
        Me.uc_grafico.Axis.X.Visible = True
        Me.uc_grafico.Axis.X2.Labels.Font = New System.Drawing.Font("Verdana", 7.0!)
        Me.uc_grafico.Axis.X2.Labels.FontColor = System.Drawing.Color.Gray
        Me.uc_grafico.Axis.X2.Labels.HorizontalAlign = System.Drawing.StringAlignment.Near
        Me.uc_grafico.Axis.X2.Labels.ItemFormatString = ""
        Me.uc_grafico.Axis.X2.Labels.Layout.Behavior = Infragistics.UltraChart.[Shared].Styles.AxisLabelLayoutBehaviors.[Auto]
        Me.uc_grafico.Axis.X2.Labels.Orientation = Infragistics.UltraChart.[Shared].Styles.TextOrientation.Horizontal
        Me.uc_grafico.Axis.X2.Labels.SeriesLabels.Font = New System.Drawing.Font("Verdana", 7.0!)
        Me.uc_grafico.Axis.X2.Labels.SeriesLabels.FontColor = System.Drawing.Color.Gray
        Me.uc_grafico.Axis.X2.Labels.SeriesLabels.FormatString = ""
        Me.uc_grafico.Axis.X2.Labels.SeriesLabels.HorizontalAlign = System.Drawing.StringAlignment.Near
        Me.uc_grafico.Axis.X2.Labels.SeriesLabels.Layout.Behavior = Infragistics.UltraChart.[Shared].Styles.AxisLabelLayoutBehaviors.[Auto]
        Me.uc_grafico.Axis.X2.Labels.SeriesLabels.Orientation = Infragistics.UltraChart.[Shared].Styles.TextOrientation.Horizontal
        Me.uc_grafico.Axis.X2.Labels.SeriesLabels.VerticalAlign = System.Drawing.StringAlignment.Center
        Me.uc_grafico.Axis.X2.Labels.VerticalAlign = System.Drawing.StringAlignment.Center
        Me.uc_grafico.Axis.X2.Labels.Visible = False
        Me.uc_grafico.Axis.X2.LineThickness = 1
        Me.uc_grafico.Axis.X2.MajorGridLines.AlphaLevel = CType(255, Byte)
        Me.uc_grafico.Axis.X2.MajorGridLines.Color = System.Drawing.Color.Gainsboro
        Me.uc_grafico.Axis.X2.MajorGridLines.DrawStyle = Infragistics.UltraChart.[Shared].Styles.LineDrawStyle.Dot
        Me.uc_grafico.Axis.X2.MajorGridLines.Visible = True
        Me.uc_grafico.Axis.X2.MinorGridLines.AlphaLevel = CType(255, Byte)
        Me.uc_grafico.Axis.X2.MinorGridLines.Color = System.Drawing.Color.LightGray
        Me.uc_grafico.Axis.X2.MinorGridLines.DrawStyle = Infragistics.UltraChart.[Shared].Styles.LineDrawStyle.Dot
        Me.uc_grafico.Axis.X2.MinorGridLines.Visible = False
        Me.uc_grafico.Axis.X2.TickmarkStyle = Infragistics.UltraChart.[Shared].Styles.AxisTickStyle.Smart
        Me.uc_grafico.Axis.X2.Visible = False
        Me.uc_grafico.Axis.Y.Labels.Font = New System.Drawing.Font("Verdana", 7.0!)
        Me.uc_grafico.Axis.Y.Labels.FontColor = System.Drawing.Color.DimGray
        Me.uc_grafico.Axis.Y.Labels.HorizontalAlign = System.Drawing.StringAlignment.Near
        Me.uc_grafico.Axis.Y.Labels.ItemFormatString = "<DATA_VALUE:00.##>"
        Me.uc_grafico.Axis.Y.Labels.Layout.Behavior = Infragistics.UltraChart.[Shared].Styles.AxisLabelLayoutBehaviors.[Auto]
        Me.uc_grafico.Axis.Y.Labels.Orientation = Infragistics.UltraChart.[Shared].Styles.TextOrientation.Horizontal
        Me.uc_grafico.Axis.Y.Labels.SeriesLabels.Font = New System.Drawing.Font("Verdana", 7.0!)
        Me.uc_grafico.Axis.Y.Labels.SeriesLabels.FontColor = System.Drawing.Color.DimGray
        Me.uc_grafico.Axis.Y.Labels.SeriesLabels.FormatString = ""
        Me.uc_grafico.Axis.Y.Labels.SeriesLabels.HorizontalAlign = System.Drawing.StringAlignment.Near
        Me.uc_grafico.Axis.Y.Labels.SeriesLabels.Layout.Behavior = Infragistics.UltraChart.[Shared].Styles.AxisLabelLayoutBehaviors.[Auto]
        Me.uc_grafico.Axis.Y.Labels.SeriesLabels.Orientation = Infragistics.UltraChart.[Shared].Styles.TextOrientation.Horizontal
        Me.uc_grafico.Axis.Y.Labels.SeriesLabels.VerticalAlign = System.Drawing.StringAlignment.Center
        Me.uc_grafico.Axis.Y.Labels.VerticalAlign = System.Drawing.StringAlignment.Center
        Me.uc_grafico.Axis.Y.LineThickness = 1
        Me.uc_grafico.Axis.Y.MajorGridLines.AlphaLevel = CType(255, Byte)
        Me.uc_grafico.Axis.Y.MajorGridLines.Color = System.Drawing.Color.Gainsboro
        Me.uc_grafico.Axis.Y.MajorGridLines.DrawStyle = Infragistics.UltraChart.[Shared].Styles.LineDrawStyle.Dot
        Me.uc_grafico.Axis.Y.MajorGridLines.Visible = True
        Me.uc_grafico.Axis.Y.MinorGridLines.AlphaLevel = CType(255, Byte)
        Me.uc_grafico.Axis.Y.MinorGridLines.Color = System.Drawing.Color.LightGray
        Me.uc_grafico.Axis.Y.MinorGridLines.DrawStyle = Infragistics.UltraChart.[Shared].Styles.LineDrawStyle.Dot
        Me.uc_grafico.Axis.Y.MinorGridLines.Visible = False
        Me.uc_grafico.Axis.Y.TickmarkInterval = 10.0R
        Me.uc_grafico.Axis.Y.TickmarkStyle = Infragistics.UltraChart.[Shared].Styles.AxisTickStyle.Smart
        Me.uc_grafico.Axis.Y.Visible = True
        Me.uc_grafico.Axis.Y2.Labels.Font = New System.Drawing.Font("Verdana", 7.0!)
        Me.uc_grafico.Axis.Y2.Labels.FontColor = System.Drawing.Color.Gray
        Me.uc_grafico.Axis.Y2.Labels.HorizontalAlign = System.Drawing.StringAlignment.Near
        Me.uc_grafico.Axis.Y2.Labels.ItemFormatString = ""
        Me.uc_grafico.Axis.Y2.Labels.Layout.Behavior = Infragistics.UltraChart.[Shared].Styles.AxisLabelLayoutBehaviors.[Auto]
        Me.uc_grafico.Axis.Y2.Labels.Orientation = Infragistics.UltraChart.[Shared].Styles.TextOrientation.Horizontal
        Me.uc_grafico.Axis.Y2.Labels.SeriesLabels.Font = New System.Drawing.Font("Verdana", 7.0!)
        Me.uc_grafico.Axis.Y2.Labels.SeriesLabels.FontColor = System.Drawing.Color.Gray
        Me.uc_grafico.Axis.Y2.Labels.SeriesLabels.FormatString = ""
        Me.uc_grafico.Axis.Y2.Labels.SeriesLabels.HorizontalAlign = System.Drawing.StringAlignment.Near
        Me.uc_grafico.Axis.Y2.Labels.SeriesLabels.Layout.Behavior = Infragistics.UltraChart.[Shared].Styles.AxisLabelLayoutBehaviors.[Auto]
        Me.uc_grafico.Axis.Y2.Labels.SeriesLabels.Orientation = Infragistics.UltraChart.[Shared].Styles.TextOrientation.Horizontal
        Me.uc_grafico.Axis.Y2.Labels.SeriesLabels.VerticalAlign = System.Drawing.StringAlignment.Center
        Me.uc_grafico.Axis.Y2.Labels.VerticalAlign = System.Drawing.StringAlignment.Center
        Me.uc_grafico.Axis.Y2.Labels.Visible = False
        Me.uc_grafico.Axis.Y2.LineThickness = 1
        Me.uc_grafico.Axis.Y2.MajorGridLines.AlphaLevel = CType(255, Byte)
        Me.uc_grafico.Axis.Y2.MajorGridLines.Color = System.Drawing.Color.Gainsboro
        Me.uc_grafico.Axis.Y2.MajorGridLines.DrawStyle = Infragistics.UltraChart.[Shared].Styles.LineDrawStyle.Dot
        Me.uc_grafico.Axis.Y2.MajorGridLines.Visible = True
        Me.uc_grafico.Axis.Y2.MinorGridLines.AlphaLevel = CType(255, Byte)
        Me.uc_grafico.Axis.Y2.MinorGridLines.Color = System.Drawing.Color.LightGray
        Me.uc_grafico.Axis.Y2.MinorGridLines.DrawStyle = Infragistics.UltraChart.[Shared].Styles.LineDrawStyle.Dot
        Me.uc_grafico.Axis.Y2.MinorGridLines.Visible = False
        Me.uc_grafico.Axis.Y2.TickmarkInterval = 10.0R
        Me.uc_grafico.Axis.Y2.TickmarkStyle = Infragistics.UltraChart.[Shared].Styles.AxisTickStyle.Smart
        Me.uc_grafico.Axis.Y2.Visible = False
        Me.uc_grafico.Axis.Z.Labels.Font = New System.Drawing.Font("Verdana", 7.0!)
        Me.uc_grafico.Axis.Z.Labels.FontColor = System.Drawing.Color.DimGray
        Me.uc_grafico.Axis.Z.Labels.HorizontalAlign = System.Drawing.StringAlignment.Near
        Me.uc_grafico.Axis.Z.Labels.ItemFormatString = ""
        Me.uc_grafico.Axis.Z.Labels.Layout.Behavior = Infragistics.UltraChart.[Shared].Styles.AxisLabelLayoutBehaviors.[Auto]
        Me.uc_grafico.Axis.Z.Labels.Orientation = Infragistics.UltraChart.[Shared].Styles.TextOrientation.Horizontal
        Me.uc_grafico.Axis.Z.Labels.SeriesLabels.Font = New System.Drawing.Font("Verdana", 7.0!)
        Me.uc_grafico.Axis.Z.Labels.SeriesLabels.FontColor = System.Drawing.Color.DimGray
        Me.uc_grafico.Axis.Z.Labels.SeriesLabels.HorizontalAlign = System.Drawing.StringAlignment.Near
        Me.uc_grafico.Axis.Z.Labels.SeriesLabels.Layout.Behavior = Infragistics.UltraChart.[Shared].Styles.AxisLabelLayoutBehaviors.[Auto]
        Me.uc_grafico.Axis.Z.Labels.SeriesLabels.Orientation = Infragistics.UltraChart.[Shared].Styles.TextOrientation.Horizontal
        Me.uc_grafico.Axis.Z.Labels.SeriesLabels.VerticalAlign = System.Drawing.StringAlignment.Center
        Me.uc_grafico.Axis.Z.Labels.VerticalAlign = System.Drawing.StringAlignment.Center
        Me.uc_grafico.Axis.Z.Labels.Visible = False
        Me.uc_grafico.Axis.Z.LineThickness = 1
        Me.uc_grafico.Axis.Z.MajorGridLines.AlphaLevel = CType(255, Byte)
        Me.uc_grafico.Axis.Z.MajorGridLines.Color = System.Drawing.Color.Gainsboro
        Me.uc_grafico.Axis.Z.MajorGridLines.DrawStyle = Infragistics.UltraChart.[Shared].Styles.LineDrawStyle.Dot
        Me.uc_grafico.Axis.Z.MajorGridLines.Visible = True
        Me.uc_grafico.Axis.Z.MinorGridLines.AlphaLevel = CType(255, Byte)
        Me.uc_grafico.Axis.Z.MinorGridLines.Color = System.Drawing.Color.LightGray
        Me.uc_grafico.Axis.Z.MinorGridLines.DrawStyle = Infragistics.UltraChart.[Shared].Styles.LineDrawStyle.Dot
        Me.uc_grafico.Axis.Z.MinorGridLines.Visible = False
        Me.uc_grafico.Axis.Z.TickmarkStyle = Infragistics.UltraChart.[Shared].Styles.AxisTickStyle.Smart
        Me.uc_grafico.Axis.Z.Visible = False
        Me.uc_grafico.Axis.Z2.Labels.Font = New System.Drawing.Font("Verdana", 7.0!)
        Me.uc_grafico.Axis.Z2.Labels.FontColor = System.Drawing.Color.Gray
        Me.uc_grafico.Axis.Z2.Labels.HorizontalAlign = System.Drawing.StringAlignment.Near
        Me.uc_grafico.Axis.Z2.Labels.ItemFormatString = ""
        Me.uc_grafico.Axis.Z2.Labels.Layout.Behavior = Infragistics.UltraChart.[Shared].Styles.AxisLabelLayoutBehaviors.[Auto]
        Me.uc_grafico.Axis.Z2.Labels.Orientation = Infragistics.UltraChart.[Shared].Styles.TextOrientation.Horizontal
        Me.uc_grafico.Axis.Z2.Labels.SeriesLabels.Font = New System.Drawing.Font("Verdana", 7.0!)
        Me.uc_grafico.Axis.Z2.Labels.SeriesLabels.FontColor = System.Drawing.Color.Gray
        Me.uc_grafico.Axis.Z2.Labels.SeriesLabels.HorizontalAlign = System.Drawing.StringAlignment.Near
        Me.uc_grafico.Axis.Z2.Labels.SeriesLabels.Layout.Behavior = Infragistics.UltraChart.[Shared].Styles.AxisLabelLayoutBehaviors.[Auto]
        Me.uc_grafico.Axis.Z2.Labels.SeriesLabels.Orientation = Infragistics.UltraChart.[Shared].Styles.TextOrientation.Horizontal
        Me.uc_grafico.Axis.Z2.Labels.SeriesLabels.VerticalAlign = System.Drawing.StringAlignment.Center
        Me.uc_grafico.Axis.Z2.Labels.VerticalAlign = System.Drawing.StringAlignment.Center
        Me.uc_grafico.Axis.Z2.Labels.Visible = False
        Me.uc_grafico.Axis.Z2.LineThickness = 1
        Me.uc_grafico.Axis.Z2.MajorGridLines.AlphaLevel = CType(255, Byte)
        Me.uc_grafico.Axis.Z2.MajorGridLines.Color = System.Drawing.Color.Gainsboro
        Me.uc_grafico.Axis.Z2.MajorGridLines.DrawStyle = Infragistics.UltraChart.[Shared].Styles.LineDrawStyle.Dot
        Me.uc_grafico.Axis.Z2.MajorGridLines.Visible = True
        Me.uc_grafico.Axis.Z2.MinorGridLines.AlphaLevel = CType(255, Byte)
        Me.uc_grafico.Axis.Z2.MinorGridLines.Color = System.Drawing.Color.LightGray
        Me.uc_grafico.Axis.Z2.MinorGridLines.DrawStyle = Infragistics.UltraChart.[Shared].Styles.LineDrawStyle.Dot
        Me.uc_grafico.Axis.Z2.MinorGridLines.Visible = False
        Me.uc_grafico.Axis.Z2.TickmarkStyle = Infragistics.UltraChart.[Shared].Styles.AxisTickStyle.Smart
        Me.uc_grafico.Axis.Z2.Visible = False
        Me.uc_grafico.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.uc_grafico.ColorModel.AlphaLevel = CType(150, Byte)
        Me.uc_grafico.ColorModel.ColorBegin = System.Drawing.Color.Pink
        Me.uc_grafico.ColorModel.ColorEnd = System.Drawing.Color.DarkRed
        Me.uc_grafico.ColorModel.ModelStyle = Infragistics.UltraChart.[Shared].Styles.ColorModels.CustomLinear
        Me.uc_grafico.Effects.Effects.Add(GradientEffect1)
        Me.uc_grafico.Legend.Location = Infragistics.UltraChart.[Shared].Styles.LegendLocation.Bottom
        Me.uc_grafico.Legend.Visible = True
        Me.uc_grafico.Location = New System.Drawing.Point(12, 54)
        Me.uc_grafico.Name = "uc_grafico"
        Me.uc_grafico.Size = New System.Drawing.Size(400, 322)
        Me.uc_grafico.TabIndex = 0
        Me.uc_grafico.Tooltips.HighlightFillColor = System.Drawing.Color.DimGray
        Me.uc_grafico.Tooltips.HighlightOutlineColor = System.Drawing.Color.DarkGray
        '
        'uchk_Cesados
        '
        Appearance1.ForeColor = System.Drawing.Color.Navy
        Me.uchk_Cesados.Appearance = Appearance1
        Me.uchk_Cesados.BackColor = System.Drawing.Color.Transparent
        Me.uchk_Cesados.BackColorInternal = System.Drawing.Color.Transparent
        Me.uchk_Cesados.Location = New System.Drawing.Point(12, 28)
        Me.uchk_Cesados.Name = "uchk_Cesados"
        Me.uchk_Cesados.Size = New System.Drawing.Size(153, 20)
        Me.uchk_Cesados.TabIndex = 2
        Me.uchk_Cesados.Text = "Incluir Personal Cesado"
        '
        'ToolStrip1
        '
        Me.ToolStrip1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripSeparator4, Me.Tool_imprimir, Me.ToolStripSeparator2, Me.Tool_Salir, Me.ToolStripSeparator1})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(422, 25)
        Me.ToolStrip1.TabIndex = 31
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
        'uchk_3d
        '
        Appearance2.ForeColor = System.Drawing.Color.Navy
        Me.uchk_3d.Appearance = Appearance2
        Me.uchk_3d.BackColor = System.Drawing.Color.Transparent
        Me.uchk_3d.BackColorInternal = System.Drawing.Color.Transparent
        Me.uchk_3d.Location = New System.Drawing.Point(162, 28)
        Me.uchk_3d.Name = "uchk_3d"
        Me.uchk_3d.Size = New System.Drawing.Size(120, 20)
        Me.uchk_3d.TabIndex = 34
        Me.uchk_3d.Text = "Ver en 3D"
        '
        'PL_RP_GR_Distri_xEstadoCivil
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(422, 388)
        Me.Controls.Add(Me.uchk_3d)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.uchk_Cesados)
        Me.Controls.Add(Me.uc_grafico)
        Me.Name = "PL_RP_GR_Distri_xEstadoCivil"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Reporte Grafico"
        CType(Me.uc_grafico, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Private WithEvents uc_grafico As Infragistics.Win.UltraWinChart.UltraChart
    Friend WithEvents uchk_Cesados As Infragistics.Win.UltraWinEditors.UltraCheckEditor
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents Tool_imprimir As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents Tool_Salir As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents uchk_3d As Infragistics.Win.UltraWinEditors.UltraCheckEditor
End Class
