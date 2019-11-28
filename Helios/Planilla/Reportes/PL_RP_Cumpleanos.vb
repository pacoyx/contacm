Public Class PL_RP_Cumpleanos

    Dim comenzar As Boolean = False
    Private Sub PL_RP_Cumpleanos_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Call CargarCombo_ConMeses(uce_Mes)
        Call Formatear_Grilla_Selector(ug_cumpleanos)
        uce_Mes.SelectedIndex = -1
        comenzar = Not comenzar
    End Sub

    Private Sub Tool_Salir_Click(sender As System.Object, e As System.EventArgs) Handles Tool_Salir.Click
        Me.Close()
    End Sub

    Private Sub Tool_imprimir_Click(sender As System.Object, e As System.EventArgs) Handles Tool_imprimir.Click

        If uce_Mes.SelectedIndex = -1 Then
            Avisar("Seleccione un mes por favor")
            uce_Mes.Focus()
            Exit Sub
        End If

        Me.Cursor = Cursors.WaitCursor

        Dim dt_reporte As DataTable = CType(ug_cumpleanos.DataSource, DataTable)

        Using crystalBL As New LR.ClsReporte
            crystalBL.Muestra_Reporte(gStr_RutaRep & "\SG_PL_12.rpt", dt_reporte, "", "pEmp;" & gStr_NomEmpresa, "pMes;" & uce_Mes.Text.ToUpper)
        End Using

        Me.Cursor = Cursors.Default

    End Sub

    Private Sub Cargar_Lista_Cumpleanos()
        If Not comenzar Then Exit Sub
        If uce_Mes.SelectedIndex = -1 Then
            Avisar("Seleccione un mes por favor")
            uce_Mes.Focus()
            Exit Sub
        End If

        Dim reportesBL As New BL.PlanillaBL.SG_PL_Reportes
        ug_cumpleanos.DataSource = reportesBL.get_Cumpleanos_Personal(uce_Mes.Value, IIf(uchk_activos.Checked, 1, 0), gInt_IdEmpresa)
        reportesBL = Nothing
    End Sub

    Private Sub uce_Mes_ValueChanged(sender As System.Object, e As System.EventArgs) Handles uce_Mes.ValueChanged
        Call Cargar_Lista_Cumpleanos()
    End Sub

    Private Sub uchk_activos_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles uchk_activos.CheckedChanged
        Call Cargar_Lista_Cumpleanos()
    End Sub
End Class