﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AD_RE_GraficoEcoXMedico
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
        Dim ColumnChartAppearance2 As Infragistics.UltraChart.Resources.Appearance.ColumnChartAppearance = New Infragistics.UltraChart.Resources.Appearance.ColumnChartAppearance()
        Dim ChartTextAppearance2 As Infragistics.UltraChart.Resources.Appearance.ChartTextAppearance = New Infragistics.UltraChart.Resources.Appearance.ChartTextAppearance()
        Dim GradientEffect2 As Infragistics.UltraChart.Resources.Appearance.GradientEffect = New Infragistics.UltraChart.Resources.Appearance.GradientEffect()
        Dim Appearance41 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance5 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Me.uc_Grafico = New Infragistics.Win.UltraWinChart.UltraChart()
        Me.UltraGroupBox1 = New Infragistics.Win.Misc.UltraGroupBox()
        Me.uce_Medico = New Infragistics.Win.UltraWinEditors.UltraComboEditor()
        Me.UltraLabel6 = New Infragistics.Win.Misc.UltraLabel()
        Me.txt_Año = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.UltraLabel10 = New Infragistics.Win.Misc.UltraLabel()
        Me.ToolS_Mantenimiento = New System.Windows.Forms.ToolStrip()
        Me.Tool_Consultar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.Tool_Salir = New System.Windows.Forms.ToolStripButton()
        CType(Me.uc_Grafico, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UltraGroupBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraGroupBox1.SuspendLayout()
        CType(Me.uce_Medico, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_Año, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolS_Mantenimiento.SuspendLayout()
        Me.SuspendLayout()
        '
        'uc_Grafico
        '
        Me.uc_Grafico.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.uc_Grafico.Axis.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.uc_Grafico.Axis.X.Extent = 120
        Me.uc_Grafico.Axis.X.Labels.Font = New System.Drawing.Font("Verdana", 7.0!)
        Me.uc_Grafico.Axis.X.Labels.FontColor = System.Drawing.Color.DimGray
        Me.uc_Grafico.Axis.X.Labels.HorizontalAlign = System.Drawing.StringAlignment.Near
        Me.uc_Grafico.Axis.X.Labels.ItemFormatString = "<ITEM_LABEL>"
        Me.uc_Grafico.Axis.X.Labels.Layout.Behavior = Infragistics.UltraChart.[Shared].Styles.AxisLabelLayoutBehaviors.[Auto]
        Me.uc_Grafico.Axis.X.Labels.Orientation = Infragistics.UltraChart.[Shared].Styles.TextOrientation.VerticalLeftFacing
        Me.uc_Grafico.Axis.X.Labels.SeriesLabels.Font = New System.Drawing.Font("Verdana", 7.0!)
        Me.uc_Grafico.Axis.X.Labels.SeriesLabels.FontColor = System.Drawing.Color.DimGray
        Me.uc_Grafico.Axis.X.Labels.SeriesLabels.HorizontalAlign = System.Drawing.StringAlignment.Center
        Me.uc_Grafico.Axis.X.Labels.SeriesLabels.Layout.Behavior = Infragistics.UltraChart.[Shared].Styles.AxisLabelLayoutBehaviors.[Auto]
        Me.uc_Grafico.Axis.X.Labels.SeriesLabels.Orientation = Infragistics.UltraChart.[Shared].Styles.TextOrientation.Horizontal
        Me.uc_Grafico.Axis.X.Labels.SeriesLabels.VerticalAlign = System.Drawing.StringAlignment.Center
        Me.uc_Grafico.Axis.X.Labels.VerticalAlign = System.Drawing.StringAlignment.Center
        Me.uc_Grafico.Axis.X.Labels.Visible = False
        Me.uc_Grafico.Axis.X.LineThickness = 1
        Me.uc_Grafico.Axis.X.MajorGridLines.AlphaLevel = CType(255, Byte)
        Me.uc_Grafico.Axis.X.MajorGridLines.Color = System.Drawing.Color.Gainsboro
        Me.uc_Grafico.Axis.X.MajorGridLines.DrawStyle = Infragistics.UltraChart.[Shared].Styles.LineDrawStyle.Dot
        Me.uc_Grafico.Axis.X.MajorGridLines.Visible = True
        Me.uc_Grafico.Axis.X.Margin.Far.Value = 12.307692307692308R
        Me.uc_Grafico.Axis.X.MinorGridLines.AlphaLevel = CType(255, Byte)
        Me.uc_Grafico.Axis.X.MinorGridLines.Color = System.Drawing.Color.LightGray
        Me.uc_Grafico.Axis.X.MinorGridLines.DrawStyle = Infragistics.UltraChart.[Shared].Styles.LineDrawStyle.Dot
        Me.uc_Grafico.Axis.X.MinorGridLines.Visible = False
        Me.uc_Grafico.Axis.X.TickmarkStyle = Infragistics.UltraChart.[Shared].Styles.AxisTickStyle.Smart
        Me.uc_Grafico.Axis.X.Visible = False
        Me.uc_Grafico.Axis.X2.Labels.Font = New System.Drawing.Font("Verdana", 7.0!)
        Me.uc_Grafico.Axis.X2.Labels.FontColor = System.Drawing.Color.Gray
        Me.uc_Grafico.Axis.X2.Labels.HorizontalAlign = System.Drawing.StringAlignment.Far
        Me.uc_Grafico.Axis.X2.Labels.ItemFormatString = "<ITEM_LABEL>"
        Me.uc_Grafico.Axis.X2.Labels.Layout.Behavior = Infragistics.UltraChart.[Shared].Styles.AxisLabelLayoutBehaviors.[Auto]
        Me.uc_Grafico.Axis.X2.Labels.Orientation = Infragistics.UltraChart.[Shared].Styles.TextOrientation.VerticalLeftFacing
        Me.uc_Grafico.Axis.X2.Labels.SeriesLabels.Font = New System.Drawing.Font("Verdana", 7.0!)
        Me.uc_Grafico.Axis.X2.Labels.SeriesLabels.FontColor = System.Drawing.Color.Gray
        Me.uc_Grafico.Axis.X2.Labels.SeriesLabels.HorizontalAlign = System.Drawing.StringAlignment.Center
        Me.uc_Grafico.Axis.X2.Labels.SeriesLabels.Layout.Behavior = Infragistics.UltraChart.[Shared].Styles.AxisLabelLayoutBehaviors.[Auto]
        Me.uc_Grafico.Axis.X2.Labels.SeriesLabels.Orientation = Infragistics.UltraChart.[Shared].Styles.TextOrientation.Horizontal
        Me.uc_Grafico.Axis.X2.Labels.SeriesLabels.VerticalAlign = System.Drawing.StringAlignment.Center
        Me.uc_Grafico.Axis.X2.Labels.VerticalAlign = System.Drawing.StringAlignment.Center
        Me.uc_Grafico.Axis.X2.Labels.Visible = False
        Me.uc_Grafico.Axis.X2.LineThickness = 1
        Me.uc_Grafico.Axis.X2.MajorGridLines.AlphaLevel = CType(255, Byte)
        Me.uc_Grafico.Axis.X2.MajorGridLines.Color = System.Drawing.Color.Gainsboro
        Me.uc_Grafico.Axis.X2.MajorGridLines.DrawStyle = Infragistics.UltraChart.[Shared].Styles.LineDrawStyle.Dot
        Me.uc_Grafico.Axis.X2.MajorGridLines.Visible = True
        Me.uc_Grafico.Axis.X2.MinorGridLines.AlphaLevel = CType(255, Byte)
        Me.uc_Grafico.Axis.X2.MinorGridLines.Color = System.Drawing.Color.LightGray
        Me.uc_Grafico.Axis.X2.MinorGridLines.DrawStyle = Infragistics.UltraChart.[Shared].Styles.LineDrawStyle.Dot
        Me.uc_Grafico.Axis.X2.MinorGridLines.Visible = False
        Me.uc_Grafico.Axis.X2.TickmarkStyle = Infragistics.UltraChart.[Shared].Styles.AxisTickStyle.Smart
        Me.uc_Grafico.Axis.X2.Visible = False
        Me.uc_Grafico.Axis.Y.Extent = 67
        Me.uc_Grafico.Axis.Y.Labels.Font = New System.Drawing.Font("Verdana", 7.0!)
        Me.uc_Grafico.Axis.Y.Labels.FontColor = System.Drawing.Color.DimGray
        Me.uc_Grafico.Axis.Y.Labels.HorizontalAlign = System.Drawing.StringAlignment.Far
        Me.uc_Grafico.Axis.Y.Labels.ItemFormatString = "<DATA_VALUE:00>"
        Me.uc_Grafico.Axis.Y.Labels.Layout.Behavior = Infragistics.UltraChart.[Shared].Styles.AxisLabelLayoutBehaviors.[Auto]
        Me.uc_Grafico.Axis.Y.Labels.Orientation = Infragistics.UltraChart.[Shared].Styles.TextOrientation.Horizontal
        Me.uc_Grafico.Axis.Y.Labels.SeriesLabels.Font = New System.Drawing.Font("Verdana", 7.0!)
        Me.uc_Grafico.Axis.Y.Labels.SeriesLabels.FontColor = System.Drawing.Color.DimGray
        Me.uc_Grafico.Axis.Y.Labels.SeriesLabels.FormatString = ""
        Me.uc_Grafico.Axis.Y.Labels.SeriesLabels.HorizontalAlign = System.Drawing.StringAlignment.Far
        Me.uc_Grafico.Axis.Y.Labels.SeriesLabels.Layout.Behavior = Infragistics.UltraChart.[Shared].Styles.AxisLabelLayoutBehaviors.[Auto]
        Me.uc_Grafico.Axis.Y.Labels.SeriesLabels.Orientation = Infragistics.UltraChart.[Shared].Styles.TextOrientation.VerticalLeftFacing
        Me.uc_Grafico.Axis.Y.Labels.SeriesLabels.VerticalAlign = System.Drawing.StringAlignment.Center
        Me.uc_Grafico.Axis.Y.Labels.VerticalAlign = System.Drawing.StringAlignment.Center
        Me.uc_Grafico.Axis.Y.LineThickness = 1
        Me.uc_Grafico.Axis.Y.MajorGridLines.AlphaLevel = CType(255, Byte)
        Me.uc_Grafico.Axis.Y.MajorGridLines.Color = System.Drawing.Color.Gainsboro
        Me.uc_Grafico.Axis.Y.MajorGridLines.DrawStyle = Infragistics.UltraChart.[Shared].Styles.LineDrawStyle.Dot
        Me.uc_Grafico.Axis.Y.MajorGridLines.Visible = True
        Me.uc_Grafico.Axis.Y.MinorGridLines.AlphaLevel = CType(255, Byte)
        Me.uc_Grafico.Axis.Y.MinorGridLines.Color = System.Drawing.Color.LightGray
        Me.uc_Grafico.Axis.Y.MinorGridLines.DrawStyle = Infragistics.UltraChart.[Shared].Styles.LineDrawStyle.Dot
        Me.uc_Grafico.Axis.Y.MinorGridLines.Visible = False
        Me.uc_Grafico.Axis.Y.TickmarkInterval = 20.0R
        Me.uc_Grafico.Axis.Y.TickmarkStyle = Infragistics.UltraChart.[Shared].Styles.AxisTickStyle.Smart
        Me.uc_Grafico.Axis.Y.Visible = True
        Me.uc_Grafico.Axis.Y2.Labels.Font = New System.Drawing.Font("Verdana", 7.0!)
        Me.uc_Grafico.Axis.Y2.Labels.FontColor = System.Drawing.Color.Gray
        Me.uc_Grafico.Axis.Y2.Labels.HorizontalAlign = System.Drawing.StringAlignment.Near
        Me.uc_Grafico.Axis.Y2.Labels.ItemFormatString = "<DATA_VALUE:00.##>"
        Me.uc_Grafico.Axis.Y2.Labels.Layout.Behavior = Infragistics.UltraChart.[Shared].Styles.AxisLabelLayoutBehaviors.[Auto]
        Me.uc_Grafico.Axis.Y2.Labels.Orientation = Infragistics.UltraChart.[Shared].Styles.TextOrientation.Horizontal
        Me.uc_Grafico.Axis.Y2.Labels.SeriesLabels.Font = New System.Drawing.Font("Verdana", 7.0!)
        Me.uc_Grafico.Axis.Y2.Labels.SeriesLabels.FontColor = System.Drawing.Color.Gray
        Me.uc_Grafico.Axis.Y2.Labels.SeriesLabels.FormatString = ""
        Me.uc_Grafico.Axis.Y2.Labels.SeriesLabels.HorizontalAlign = System.Drawing.StringAlignment.Near
        Me.uc_Grafico.Axis.Y2.Labels.SeriesLabels.Layout.Behavior = Infragistics.UltraChart.[Shared].Styles.AxisLabelLayoutBehaviors.[Auto]
        Me.uc_Grafico.Axis.Y2.Labels.SeriesLabels.Orientation = Infragistics.UltraChart.[Shared].Styles.TextOrientation.VerticalLeftFacing
        Me.uc_Grafico.Axis.Y2.Labels.SeriesLabels.VerticalAlign = System.Drawing.StringAlignment.Center
        Me.uc_Grafico.Axis.Y2.Labels.VerticalAlign = System.Drawing.StringAlignment.Center
        Me.uc_Grafico.Axis.Y2.Labels.Visible = False
        Me.uc_Grafico.Axis.Y2.LineThickness = 1
        Me.uc_Grafico.Axis.Y2.MajorGridLines.AlphaLevel = CType(255, Byte)
        Me.uc_Grafico.Axis.Y2.MajorGridLines.Color = System.Drawing.Color.Gainsboro
        Me.uc_Grafico.Axis.Y2.MajorGridLines.DrawStyle = Infragistics.UltraChart.[Shared].Styles.LineDrawStyle.Dot
        Me.uc_Grafico.Axis.Y2.MajorGridLines.Visible = True
        Me.uc_Grafico.Axis.Y2.MinorGridLines.AlphaLevel = CType(255, Byte)
        Me.uc_Grafico.Axis.Y2.MinorGridLines.Color = System.Drawing.Color.LightGray
        Me.uc_Grafico.Axis.Y2.MinorGridLines.DrawStyle = Infragistics.UltraChart.[Shared].Styles.LineDrawStyle.Dot
        Me.uc_Grafico.Axis.Y2.MinorGridLines.Visible = False
        Me.uc_Grafico.Axis.Y2.TickmarkInterval = 20.0R
        Me.uc_Grafico.Axis.Y2.TickmarkStyle = Infragistics.UltraChart.[Shared].Styles.AxisTickStyle.Smart
        Me.uc_Grafico.Axis.Y2.Visible = False
        Me.uc_Grafico.Axis.Z.Labels.Font = New System.Drawing.Font("Verdana", 7.0!)
        Me.uc_Grafico.Axis.Z.Labels.FontColor = System.Drawing.Color.DimGray
        Me.uc_Grafico.Axis.Z.Labels.HorizontalAlign = System.Drawing.StringAlignment.Near
        Me.uc_Grafico.Axis.Z.Labels.ItemFormatString = "<ITEM_LABEL>"
        Me.uc_Grafico.Axis.Z.Labels.Layout.Behavior = Infragistics.UltraChart.[Shared].Styles.AxisLabelLayoutBehaviors.[Auto]
        Me.uc_Grafico.Axis.Z.Labels.Orientation = Infragistics.UltraChart.[Shared].Styles.TextOrientation.Horizontal
        Me.uc_Grafico.Axis.Z.Labels.SeriesLabels.Font = New System.Drawing.Font("Verdana", 7.0!)
        Me.uc_Grafico.Axis.Z.Labels.SeriesLabels.FontColor = System.Drawing.Color.DimGray
        Me.uc_Grafico.Axis.Z.Labels.SeriesLabels.HorizontalAlign = System.Drawing.StringAlignment.Near
        Me.uc_Grafico.Axis.Z.Labels.SeriesLabels.Layout.Behavior = Infragistics.UltraChart.[Shared].Styles.AxisLabelLayoutBehaviors.[Auto]
        Me.uc_Grafico.Axis.Z.Labels.SeriesLabels.Orientation = Infragistics.UltraChart.[Shared].Styles.TextOrientation.Horizontal
        Me.uc_Grafico.Axis.Z.Labels.SeriesLabels.VerticalAlign = System.Drawing.StringAlignment.Center
        Me.uc_Grafico.Axis.Z.Labels.VerticalAlign = System.Drawing.StringAlignment.Center
        Me.uc_Grafico.Axis.Z.Labels.Visible = False
        Me.uc_Grafico.Axis.Z.LineThickness = 1
        Me.uc_Grafico.Axis.Z.MajorGridLines.AlphaLevel = CType(255, Byte)
        Me.uc_Grafico.Axis.Z.MajorGridLines.Color = System.Drawing.Color.Gainsboro
        Me.uc_Grafico.Axis.Z.MajorGridLines.DrawStyle = Infragistics.UltraChart.[Shared].Styles.LineDrawStyle.Dot
        Me.uc_Grafico.Axis.Z.MajorGridLines.Visible = True
        Me.uc_Grafico.Axis.Z.MinorGridLines.AlphaLevel = CType(255, Byte)
        Me.uc_Grafico.Axis.Z.MinorGridLines.Color = System.Drawing.Color.LightGray
        Me.uc_Grafico.Axis.Z.MinorGridLines.DrawStyle = Infragistics.UltraChart.[Shared].Styles.LineDrawStyle.Dot
        Me.uc_Grafico.Axis.Z.MinorGridLines.Visible = False
        Me.uc_Grafico.Axis.Z.TickmarkStyle = Infragistics.UltraChart.[Shared].Styles.AxisTickStyle.Smart
        Me.uc_Grafico.Axis.Z.Visible = False
        Me.uc_Grafico.Axis.Z2.Labels.Font = New System.Drawing.Font("Verdana", 7.0!)
        Me.uc_Grafico.Axis.Z2.Labels.FontColor = System.Drawing.Color.Gray
        Me.uc_Grafico.Axis.Z2.Labels.HorizontalAlign = System.Drawing.StringAlignment.Near
        Me.uc_Grafico.Axis.Z2.Labels.ItemFormatString = ""
        Me.uc_Grafico.Axis.Z2.Labels.Layout.Behavior = Infragistics.UltraChart.[Shared].Styles.AxisLabelLayoutBehaviors.[Auto]
        Me.uc_Grafico.Axis.Z2.Labels.Orientation = Infragistics.UltraChart.[Shared].Styles.TextOrientation.Horizontal
        Me.uc_Grafico.Axis.Z2.Labels.SeriesLabels.Font = New System.Drawing.Font("Verdana", 7.0!)
        Me.uc_Grafico.Axis.Z2.Labels.SeriesLabels.FontColor = System.Drawing.Color.Gray
        Me.uc_Grafico.Axis.Z2.Labels.SeriesLabels.HorizontalAlign = System.Drawing.StringAlignment.Near
        Me.uc_Grafico.Axis.Z2.Labels.SeriesLabels.Layout.Behavior = Infragistics.UltraChart.[Shared].Styles.AxisLabelLayoutBehaviors.[Auto]
        Me.uc_Grafico.Axis.Z2.Labels.SeriesLabels.Orientation = Infragistics.UltraChart.[Shared].Styles.TextOrientation.Horizontal
        Me.uc_Grafico.Axis.Z2.Labels.SeriesLabels.VerticalAlign = System.Drawing.StringAlignment.Center
        Me.uc_Grafico.Axis.Z2.Labels.VerticalAlign = System.Drawing.StringAlignment.Center
        Me.uc_Grafico.Axis.Z2.Labels.Visible = False
        Me.uc_Grafico.Axis.Z2.LineThickness = 1
        Me.uc_Grafico.Axis.Z2.MajorGridLines.AlphaLevel = CType(255, Byte)
        Me.uc_Grafico.Axis.Z2.MajorGridLines.Color = System.Drawing.Color.Gainsboro
        Me.uc_Grafico.Axis.Z2.MajorGridLines.DrawStyle = Infragistics.UltraChart.[Shared].Styles.LineDrawStyle.Dot
        Me.uc_Grafico.Axis.Z2.MajorGridLines.Visible = True
        Me.uc_Grafico.Axis.Z2.MinorGridLines.AlphaLevel = CType(255, Byte)
        Me.uc_Grafico.Axis.Z2.MinorGridLines.Color = System.Drawing.Color.LightGray
        Me.uc_Grafico.Axis.Z2.MinorGridLines.DrawStyle = Infragistics.UltraChart.[Shared].Styles.LineDrawStyle.Dot
        Me.uc_Grafico.Axis.Z2.MinorGridLines.Visible = False
        Me.uc_Grafico.Axis.Z2.TickmarkStyle = Infragistics.UltraChart.[Shared].Styles.AxisTickStyle.Smart
        Me.uc_Grafico.Axis.Z2.Visible = False
        Me.uc_Grafico.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.uc_Grafico.ColorModel.AlphaLevel = CType(150, Byte)
        Me.uc_Grafico.ColorModel.ColorBegin = System.Drawing.Color.Pink
        Me.uc_Grafico.ColorModel.ColorEnd = System.Drawing.Color.DarkRed
        Me.uc_Grafico.ColorModel.ModelStyle = Infragistics.UltraChart.[Shared].Styles.ColorModels.CustomLinear
        ChartTextAppearance2.ChartTextFont = New System.Drawing.Font("Arial", 7.0!)
        ChartTextAppearance2.Column = -2
        ChartTextAppearance2.ItemFormatString = "<DATA_VALUE:00.00>"
        ChartTextAppearance2.Row = -2
        ChartTextAppearance2.Visible = True
        ColumnChartAppearance2.ChartText.Add(ChartTextAppearance2)
        Me.uc_Grafico.ColumnChart = ColumnChartAppearance2
        Me.uc_Grafico.Data.SwapRowsAndColumns = True
        Me.uc_Grafico.Data.ZeroAligned = True
        Me.uc_Grafico.Effects.Effects.Add(GradientEffect2)
        Me.uc_Grafico.Legend.Location = Infragistics.UltraChart.[Shared].Styles.LegendLocation.Bottom
        Me.uc_Grafico.Legend.Visible = True
        Me.uc_Grafico.Location = New System.Drawing.Point(12, 74)
        Me.uc_Grafico.Name = "uc_Grafico"
        Me.uc_Grafico.Size = New System.Drawing.Size(648, 413)
        Me.uc_Grafico.TabIndex = 0
        Me.uc_Grafico.TitleBottom.HorizontalAlign = System.Drawing.StringAlignment.Center
        Me.uc_Grafico.TitleTop.HorizontalAlign = System.Drawing.StringAlignment.Center
        Me.uc_Grafico.Tooltips.HighlightFillColor = System.Drawing.Color.DimGray
        Me.uc_Grafico.Tooltips.HighlightOutlineColor = System.Drawing.Color.DarkGray
        Me.uc_Grafico.Tooltips.TooltipControl = Nothing
        '
        'UltraGroupBox1
        '
        Me.UltraGroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.UltraGroupBox1.Controls.Add(Me.uce_Medico)
        Me.UltraGroupBox1.Controls.Add(Me.UltraLabel6)
        Me.UltraGroupBox1.Controls.Add(Me.txt_Año)
        Me.UltraGroupBox1.Controls.Add(Me.UltraLabel10)
        Me.UltraGroupBox1.Location = New System.Drawing.Point(12, 30)
        Me.UltraGroupBox1.Name = "UltraGroupBox1"
        Me.UltraGroupBox1.Size = New System.Drawing.Size(648, 37)
        Me.UltraGroupBox1.TabIndex = 8
        '
        'uce_Medico
        '
        Me.uce_Medico.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.uce_Medico.Location = New System.Drawing.Point(225, 10)
        Me.uce_Medico.Name = "uce_Medico"
        Me.uce_Medico.Size = New System.Drawing.Size(394, 21)
        Me.uce_Medico.TabIndex = 0
        '
        'UltraLabel6
        '
        Appearance41.BackColor = System.Drawing.Color.Transparent
        Appearance41.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel6.Appearance = Appearance41
        Me.UltraLabel6.AutoSize = True
        Me.UltraLabel6.Location = New System.Drawing.Point(178, 14)
        Me.UltraLabel6.Name = "UltraLabel6"
        Me.UltraLabel6.Size = New System.Drawing.Size(41, 14)
        Me.UltraLabel6.TabIndex = 195
        Me.UltraLabel6.Text = "Médico"
        '
        'txt_Año
        '
        Me.txt_Año.Location = New System.Drawing.Point(52, 10)
        Me.txt_Año.MaxLength = 4
        Me.txt_Año.Name = "txt_Año"
        Me.txt_Año.Size = New System.Drawing.Size(70, 21)
        Me.txt_Año.TabIndex = 1
        '
        'UltraLabel10
        '
        Appearance5.BackColor = System.Drawing.Color.Transparent
        Appearance5.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel10.Appearance = Appearance5
        Me.UltraLabel10.AutoSize = True
        Me.UltraLabel10.Location = New System.Drawing.Point(22, 14)
        Me.UltraLabel10.Name = "UltraLabel10"
        Me.UltraLabel10.Size = New System.Drawing.Size(24, 14)
        Me.UltraLabel10.TabIndex = 192
        Me.UltraLabel10.Text = "Año"
        '
        'ToolS_Mantenimiento
        '
        Me.ToolS_Mantenimiento.BackColor = System.Drawing.Color.White
        Me.ToolS_Mantenimiento.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Tool_Consultar, Me.ToolStripSeparator4, Me.Tool_Salir})
        Me.ToolS_Mantenimiento.Location = New System.Drawing.Point(0, 0)
        Me.ToolS_Mantenimiento.Name = "ToolS_Mantenimiento"
        Me.ToolS_Mantenimiento.Size = New System.Drawing.Size(672, 25)
        Me.ToolS_Mantenimiento.TabIndex = 9
        Me.ToolS_Mantenimiento.Text = "ToolStrip1"
        '
        'Tool_Consultar
        '
        Me.Tool_Consultar.Image = Global.Contabilidad.My.Resources.Resources._16__Search_
        Me.Tool_Consultar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Tool_Consultar.Name = "Tool_Consultar"
        Me.Tool_Consultar.Size = New System.Drawing.Size(78, 22)
        Me.Tool_Consultar.Text = "Consultar"
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(6, 25)
        '
        'Tool_Salir
        '
        Me.Tool_Salir.Image = Global.Contabilidad.My.Resources.Resources._28
        Me.Tool_Salir.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Tool_Salir.Name = "Tool_Salir"
        Me.Tool_Salir.Size = New System.Drawing.Size(49, 22)
        Me.Tool_Salir.Text = "Salir"
        '
        'AD_RE_GraficoEcoXMedico
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(672, 499)
        Me.Controls.Add(Me.ToolS_Mantenimiento)
        Me.Controls.Add(Me.UltraGroupBox1)
        Me.Controls.Add(Me.uc_Grafico)
        Me.Name = "AD_RE_GraficoEcoXMedico"
        Me.Text = "GRAFICO DE ECOGRAFIAS ENVIADAS POR MEDICO"
        CType(Me.uc_Grafico, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UltraGroupBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraGroupBox1.ResumeLayout(False)
        Me.UltraGroupBox1.PerformLayout()
        CType(Me.uce_Medico, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_Año, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolS_Mantenimiento.ResumeLayout(False)
        Me.ToolS_Mantenimiento.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Private WithEvents uc_Grafico As Infragistics.Win.UltraWinChart.UltraChart
    Friend WithEvents UltraGroupBox1 As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents UltraLabel10 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents ToolS_Mantenimiento As System.Windows.Forms.ToolStrip
    Friend WithEvents Tool_Consultar As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents Tool_Salir As System.Windows.Forms.ToolStripButton
    Public WithEvents uce_Medico As Infragistics.Win.UltraWinEditors.UltraComboEditor
    Friend WithEvents UltraLabel6 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents txt_Año As Infragistics.Win.UltraWinEditors.UltraTextEditor
End Class
