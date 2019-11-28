Public Class PL_RP_Aportaciones_AFP
    Dim comenzar As Boolean = False
    Private Sub PL_RP_Aportaciones_AFP_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        une_ayo.Value = gDat_Fecha_Sis.Year
        Call Formatear_Grilla_Selector(ug_aportaciones)
        Call CargarCombo_ConMeses(uce_Mes)
        Call Cargar_TipoPersonal()
        uce_TipoPersonal.SelectedIndex = 0
        comenzar = Not comenzar
    End Sub

    Private Sub Tool_Salir_Click(sender As System.Object, e As System.EventArgs) Handles Tool_Salir.Click
        Me.Close()
    End Sub

    Private Sub Tool_imprimir_Click(sender As System.Object, e As System.EventArgs) Handles Tool_imprimir.Click
        If uce_Mes.SelectedIndex = -1 Then
            Avisar("Seleccione un mes")
            uce_Mes.Focus()
            Exit Sub
        End If

        If uce_TipoPersonal.SelectedIndex = -1 Then
            Avisar("Seleccione un Tipo de Trabajador")
            uce_Mes.Focus()
            Exit Sub
        End If

        Me.Cursor = Cursors.WaitCursor
        Dim dt_tmp As DataTable = CType(ug_aportaciones.DataSource, DataTable)
        Dim reportesBL As New BL.PlanillaBL.SG_PL_TB_PERSONAL
        Dim str_fecha As String = uce_Mes.Text & "de " & une_ayo.Value.ToString
        Using crystalBL As New LR.ClsReporte
            crystalBL.Muestra_Reporte(gStr_RutaRep & "\SG_PL_19.rpt", dt_tmp, "", "pEmp;" & gStr_NomEmpresa, _
                                                                              "pFecha;" & str_fecha.ToUpper, _
                                                                                "pTipoPer;" & uce_TipoPersonal.Text)
        End Using
        reportesBL = Nothing
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub Cargar_Data_Aportaciones()

        If Not comenzar Then Exit Sub
        If uce_Mes.SelectedIndex = -1 Then Exit Sub
        If uce_TipoPersonal.SelectedIndex = -1 Then Exit Sub

        Dim reportesBL As New BL.PlanillaBL.SG_PL_Reportes

        If uce_TipoPersonal.Value = 5 Then 'independientes
            ug_aportaciones.DataSource = reportesBL.get_Aportaciones_AFP_Independiente(une_ayo.Value, uce_Mes.Value, gInt_IdEmpresa)
        Else
            ug_aportaciones.DataSource = reportesBL.get_Aportaciones_AFP(une_ayo.Value, uce_Mes.Value, uce_TipoPersonal.Value, gInt_IdEmpresa)
        End If

        reportesBL = Nothing

        If ug_aportaciones.Rows.Count > 0 Then ug_aportaciones.Rows(0).Activate()

    End Sub

    Private Sub Cargar_TipoPersonal()
        Dim tipoPersonalBL As New BL.PlanillaBL.SG_PL_TB_TIPO_PERSONAL
        uce_TipoPersonal.DataSource = tipoPersonalBL.getTipos()
        uce_TipoPersonal.ValueMember = "TP_ID"
        uce_TipoPersonal.DisplayMember = "TP_DESCRIPCION"
        tipoPersonalBL = Nothing
    End Sub

    Private Sub ug_aportaciones_InitializeGroupByRow(sender As System.Object, e As Infragistics.Win.UltraWinGrid.InitializeGroupByRowEventArgs) Handles ug_aportaciones.InitializeGroupByRow
        e.Row.Expanded = True
    End Sub

    Private Sub uce_Mes_ValueChanged(sender As System.Object, e As System.EventArgs) Handles uce_Mes.ValueChanged
        Call Cargar_Data_Aportaciones()
    End Sub

    Private Sub uce_TipoPersonal_ValueChanged(sender As System.Object, e As System.EventArgs) Handles uce_TipoPersonal.ValueChanged
        Call Cargar_Data_Aportaciones()
    End Sub

    Private Sub une_ayo_ValueChanged(sender As System.Object, e As System.EventArgs) Handles une_ayo.ValueChanged
        Call Cargar_Data_Aportaciones()
    End Sub

    Private Sub ug_aportaciones_InitializeRow(sender As System.Object, e As Infragistics.Win.UltraWinGrid.InitializeRowEventArgs) Handles ug_aportaciones.InitializeRow

    End Sub
End Class