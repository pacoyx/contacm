Public Class PL_RP_ConceptosHDA

    Private Sub Tool_Salir_Click(sender As System.Object, e As System.EventArgs) Handles Tool_Salir.Click
        Me.Close()
    End Sub

    Private Sub Tool_imprimir_Click(sender As System.Object, e As System.EventArgs) Handles Tool_imprimir.Click
        Dim conceptoBL As New BL.PlanillaBL.SG_PL_TB_CONCEPTOS
        Dim crystalBL As New LR.ClsReporte
        Dim dt_data As DataTable = conceptoBL.get_Conceptos(New BE.ContabilidadBE.SG_CO_TB_EMPRESA With {.EM_ID = gInt_IdEmpresa})

        crystalBL.Muestra_Reporte(gStr_RutaRep & "\SG_PL_14.rpt", dt_data, "", "pEmp;" & gStr_NomEmpresa)

        crystalBL.Dispose()
        conceptoBL = Nothing

    End Sub
End Class