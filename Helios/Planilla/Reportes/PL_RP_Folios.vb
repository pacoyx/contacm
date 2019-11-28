Public Class PL_RP_Folios

    Dim comenzar As Boolean = False

    Private Sub PL_RP_Folios_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Call CargarCombo_ConMeses(uce_Mes)
        Call Formatear_Grilla_Selector(ug_Folios)
        une_ayo.Value = gDat_Fecha_Sis.Year
        uce_Mes.SelectedIndex = -1
        comenzar = Not comenzar
    End Sub

    Private Sub uce_Mes_ValueChanged(sender As System.Object, e As System.EventArgs) Handles uce_Mes.ValueChanged
        Call Cargar_Data_Folios()
    End Sub

    Private Sub Cargar_Data_Folios()
        If Not comenzar Then Exit Sub
        If uce_Mes.SelectedIndex = -1 Then
            Avisar("Seleccione un mes por favor")
            uce_Mes.Focus()
            Exit Sub
        End If

        Dim reportesBL As New BL.PlanillaBL.SG_PL_Reportes
        ug_Folios.DataSource = reportesBL.get_Reprte_de_Folios(une_ayo.Value, uce_Mes.Value, gInt_IdEmpresa)

        reportesBL = Nothing
    End Sub


    Private Sub ToolStripButton3_Click(sender As System.Object, e As System.EventArgs) Handles ToolStripButton3.Click
        If uce_Mes.SelectedIndex = -1 Then
            Avisar("Seleccione un mes por favor")
            uce_Mes.Focus()
            Exit Sub
        End If

        Me.Cursor = Cursors.WaitCursor
        Dim dt_reporte As DataTable = CType(ug_Folios.DataSource, DataTable)

        Using crystalBL As New LR.ClsReporte
            crystalBL.Muestra_Reporte(gStr_RutaRep & "\SG_PL_13.rpt", dt_reporte, "", "pEmp;" & gStr_NomEmpresa, "pMes;" & uce_Mes.Text.ToUpper & " del " & une_ayo.Value.ToString)
        End Using
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub ToolStripButton4_Click(sender As System.Object, e As System.EventArgs) Handles ToolStripButton4.Click
        Me.Close()
    End Sub

    Private Sub ug_Folios_InitializeGroupByRow(sender As System.Object, e As Infragistics.Win.UltraWinGrid.InitializeGroupByRowEventArgs) Handles ug_Folios.InitializeGroupByRow
        e.Row.Expanded = True
    End Sub

    Private Sub une_ayo_ValueChanged(sender As System.Object, e As System.EventArgs) Handles une_ayo.ValueChanged
        Call Cargar_Data_Folios()
    End Sub
End Class