Public Class PL_RP_ListaPersonal

    Private Sub Tool_Salir_Click(sender As System.Object, e As System.EventArgs) Handles Tool_Salir.Click
        Me.Close()
    End Sub

    Private Sub Tool_imprimir_Click(sender As System.Object, e As System.EventArgs) Handles Tool_imprimir.Click

        Dim reportesBL As New BL.PlanillaBL.SG_PL_TB_PERSONAL
        Dim crystalBL As New LR.ClsReporte
        Dim dt_data As DataTable = reportesBL.getPersonal_Rep_Lista(gInt_IdEmpresa, IIf(uchk_activos.Checked, 1, 0))

        crystalBL.Muestra_Reporte(gStr_RutaRep & "\SG_PL_06.rpt", dt_data, "", "pEmpresa;" & gStr_NomEmpresa)

        crystalBL.Dispose()
        reportesBL = Nothing

    End Sub
End Class