Public Class PL_RP_GR_Distri_xEdad



    Private Sub PL_RP_GR_Distri_xEdad_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Call Cargar_Data_Graficos()
    End Sub

    Private Sub Cargar_Data_Graficos()
        Dim reporteBL As New BL.PlanillaBL.SG_PL_Reportes
        uc_grafico.Data.DataSource = reporteBL.get_Gra_Distribucion_x_Edad(gInt_IdEmpresa)
        uc_grafico.TitleTop.Text = "Distribución por Edades"
        reporteBL = Nothing
    End Sub

    Private Sub Tool_Salir_Click(sender As System.Object, e As System.EventArgs) Handles Tool_Salir.Click
        Me.Close()
    End Sub

    Private Sub Tool_imprimir_Click(sender As System.Object, e As System.EventArgs) Handles Tool_imprimir.Click
        uc_grafico.PrintChart()
    End Sub

    Private Sub uchk_3d_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles uchk_3d.CheckedChanged
        If uchk_3d.Checked Then
            uc_grafico.ChartType = Infragistics.UltraChart.Shared.Styles.ChartType.ColumnChart3D
            uc_grafico.Transform3D.XRotation = 112
            uc_grafico.Transform3D.YRotation = 75
            uc_grafico.Transform3D.ZRotation = -10

        Else
            uc_grafico.ChartType = Infragistics.UltraChart.Shared.Styles.ChartType.ColumnChart
        End If
        uc_grafico.Axis.X.Labels.ItemFormatString = ""
    End Sub

    Private Sub PL_RP_GR_Distri_xEdad_MouseWheel(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles MyBase.MouseWheel
        Select Case e.Delta
            Case 120
                'Se ha movido hacia arriba
                If uc_grafico.Transform3D.Scale + 10 < 100 Then
                    uc_grafico.Transform3D.Scale += 10
                End If
            Case -120
                If uc_grafico.Transform3D.Scale - 10 > 0 Then
                    uc_grafico.Transform3D.Scale -= 10
                End If

        End Select
    End Sub
End Class