Public Class PL_RP_Afp_Net

    Dim comenzar As Boolean = False

    Private Sub PL_RP_Afp_Net_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Call CargarCombo_ConMeses(uce_Mes)
        Call Formatear_Grilla_Selector(ug_afp_net)
        une_ayo.Value = gDat_Fecha_Sis.Year
        uce_Mes.SelectedIndex = -1
        comenzar = Not comenzar
    End Sub

    Private Sub Tool_imprimir_Click(sender As System.Object, e As System.EventArgs) Handles Tool_imprimir.Click

        If uce_Mes.SelectedIndex = -1 Then
            Avisar("Seleccione un mes")
            uce_Mes.Focus()
            Exit Sub
        End If

        Me.Cursor = Cursors.WaitCursor
        Dim dt_tmp As DataTable = CType(ug_afp_net.DataSource, DataTable)
        Dim reportesBL As New BL.PlanillaBL.SG_PL_TB_PERSONAL
        Dim str_fecha As String = uce_Mes.Text & " de " & une_ayo.Value.ToString
        Using crystalBL As New LR.ClsReporte
            crystalBL.Muestra_Reporte(gStr_RutaRep & "\SG_PL_20.rpt", dt_tmp, "", "pEmp;" & gStr_NomEmpresa, _
                                                                              "pFecha;" & str_fecha.ToUpper)
        End Using

        reportesBL = Nothing
        Me.Cursor = Cursors.Default

    End Sub

    Private Sub Tool_Salir_Click(sender As System.Object, e As System.EventArgs) Handles Tool_Salir.Click
        Me.Close()
    End Sub

    Private Sub Cargar_Data_AfpNet()
        If Not comenzar Then Exit Sub
        If uce_Mes.SelectedIndex = -1 Then Exit Sub

        Dim reportesBL As New BL.PlanillaBL.SG_PL_Reportes
        ug_afp_net.DataSource = reportesBL.get_Afp_Net(une_ayo.Value, uce_Mes.Value, gInt_IdEmpresa, IIf(uchk_Todos.Checked, 1, 0))
        reportesBL = Nothing

    End Sub

    Private Sub uce_Mes_ValueChanged(sender As System.Object, e As System.EventArgs) Handles uce_Mes.ValueChanged
        Call Cargar_Data_AfpNet()
    End Sub

    Private Sub une_ayo_ValueChanged(sender As System.Object, e As System.EventArgs) Handles une_ayo.ValueChanged
        Call Cargar_Data_AfpNet()
    End Sub

    Private Sub Tool_exportar_Click(sender As System.Object, e As System.EventArgs) Handles Tool_exportar.Click

        If uce_Mes.SelectedIndex = -1 Then Exit Sub
        Dim reportesBL As New BL.PlanillaBL.SG_PL_Reportes

        Dim dt_tmp As DataTable = reportesBL.get_Afp_Net_Excel(une_ayo.Value, uce_Mes.Value, gInt_IdEmpresa, IIf(uchk_Todos.Checked, 1, 0))
        Dim Str_titulo As String = "Afp Net"

        For i As Integer = 0 To dt_tmp.Rows.Count - 1
            dt_tmp.Rows(i)(0) = i + 1
        Next

        ug_excel.DataSource = dt_tmp

        Dim str_nom_excel As String = "afnet_" & Now.Second.ToString & ".xls"

        Try

            uge1.Export(ug_excel, str_nom_excel)
            Process.Start(str_nom_excel)

        Catch ex As Exception

            Dim Obj_Funciones As New LR.ClsFunciones
            Obj_Funciones.exportar_A_MS_Excel(dt_tmp, Str_titulo)
            Obj_Funciones = Nothing
            Process.Start("explorer.exe", Application.StartupPath)

        End Try

        reportesBL = Nothing

    End Sub

    Private Sub uchk_Todos_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles uchk_Todos.CheckedChanged
        Call Cargar_Data_AfpNet()
    End Sub
End Class