Public Class PL_RP_GR_Tardones

    Private Sub PL_RP_GR_Tardones_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Call Grafico_x_Anho()

        'uce_Mes.Items.Add(0, "[Todos]")
        Call CargarCombo_ConMeses(uce_Mes)
        uce_Mes.SelectedIndex = 0
    End Sub

    Private Sub Tool_Salir_Click(sender As System.Object, e As System.EventArgs) Handles Tool_Salir.Click
        Me.Close()
    End Sub

    Private Sub Tool_imprimir_Click(sender As System.Object, e As System.EventArgs) Handles Tool_imprimir.Click
        uc_grafico.PrintChart()
    End Sub

    Private Sub Grafico_x_Anho()
        uc_grafico.Legend.Visible = True
        uc_grafico.ChartType = Infragistics.UltraChart.Shared.Styles.ChartType.DoughnutChart3D
        Dim reporteBL As New BL.PlanillaBL.SG_PL_Reportes
        uc_grafico.Data.DataSource = reporteBL.get_Gra_Tardones_x_Anho(gDat_Fecha_Sis.Year, gInt_IdEmpresa)
        uc_grafico.TitleTop.Text = "Tardanza por Personal"
        reporteBL = Nothing
    End Sub

    Private Sub Grafico_x_Mes()

        If uce_Mes.Value = 0 Then
            uc_grafico.ChartType = Infragistics.UltraChart.Shared.Styles.ChartType.ColumnChart3D
            uc_grafico.Transform3D.XRotation = 112
            uc_grafico.Transform3D.YRotation = 75
            uc_grafico.Transform3D.ZRotation = -10

        Else


            uc_grafico.ChartType = Infragistics.UltraChart.Shared.Styles.ChartType.ColumnChart
            uc_grafico.Axis.X.Labels.Orientation = Infragistics.UltraChart.Shared.Styles.TextOrientation.VerticalLeftFacing
            uc_grafico.Axis.X.axisNumber = Infragistics.UltraChart.Shared.Styles.AxisNumber.X_Axis
            'uc_grafico.Axis.X.Visible = False
            uc_grafico.Legend.Visible = False

            'uc_grafico.Axis.X.Labels.ItemFormatString = ""

        End If

        Dim reporteBL As New BL.PlanillaBL.SG_PL_Reportes
        uc_grafico.DataSource = reporteBL.get_Gra_Tardones_x_Mes(gDat_Fecha_Sis.Year, uce_Mes.Value, gInt_IdEmpresa)
        uc_grafico.DataBind()
        uc_grafico.TitleTop.Text = "Tardanza por Personal Mensual"
        reporteBL = Nothing
    End Sub

    Private Sub uos_opc_ValueChanged(sender As System.Object, e As System.EventArgs) Handles uos_opc.ValueChanged
        Select Case uos_opc.Value
            Case 1
                Call Grafico_x_Anho()
            Case 2
                Call Grafico_x_Mes()
        End Select
    End Sub

    Private Sub uce_Mes_ValueChanged(sender As System.Object, e As System.EventArgs) Handles uce_Mes.ValueChanged
        If uos_opc.Value = 2 Then Call Grafico_x_Mes()
    End Sub
End Class