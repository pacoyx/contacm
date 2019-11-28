Public Class PL_RP_GR_Distri_xCargo

    Private Sub PL_RP_GR_Distri_xCargo_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Call Cargar_Data_Graficos()
    End Sub

    Private Sub Tool_Salir_Click(sender As System.Object, e As System.EventArgs) Handles Tool_Salir.Click
        Me.Close()
    End Sub

    Private Sub Tool_imprimir_Click(sender As System.Object, e As System.EventArgs) Handles Tool_imprimir.Click
        uc_grafico.PrintChart()
    End Sub

    Private Sub uchk_Cesados_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles uchk_Cesados.CheckedChanged
        Call Cargar_Data_Graficos()
    End Sub

    Private Sub Cargar_Data_Graficos()
        Dim reporteBL As New BL.PlanillaBL.SG_PL_Reportes
        uc_grafico.Data.DataSource = reporteBL.get_Gra_Distribucion_x_Cargo(gInt_IdEmpresa, uchk_Cesados.Checked)
        uc_grafico.TitleTop.Text = "Distribución por Cargos"
        reporteBL = Nothing
    End Sub

    Private Sub uchk_3d_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles uchk_3d.CheckedChanged
        If uchk_3d.Checked Then
            uc_grafico.ChartType = Infragistics.UltraChart.Shared.Styles.ChartType.PieChart3D
            uc_grafico.Transform3D.Scale = 100
        Else
            uc_grafico.ChartType = Infragistics.UltraChart.Shared.Styles.ChartType.PieChart
        End If
    End Sub
End Class