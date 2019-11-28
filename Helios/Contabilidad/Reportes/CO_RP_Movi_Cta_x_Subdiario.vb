Public Class CO_RP_Movi_Cta_x_Subdiario

    Private Sub CO_RP_Movi_Cta_x_Subdiario_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Call Cargar_Subdiarios()
        Call CargarCombo_ConMeses(uce_Mes)
        txt_Ayo.Text = gDat_Fecha_Sis.Year
        txt_Ayo.ReadOnly = True
        uce_Mes.Value = gDat_Fecha_Sis.Month
        uce_nivel.Value = 3

    End Sub

    Private Sub Tool_imprimir_Click(sender As System.Object, e As System.EventArgs) Handles Tool_imprimir.Click

        Call Grabar_Codigos()
        Call Mostrar_Reporte()

    End Sub

    Private Sub Tool_salir_Click(sender As System.Object, e As System.EventArgs) Handles Tool_salir.Click
        Me.Close()
    End Sub

    Private Sub Cargar_Subdiarios()

        Dim SubdiariosBL As New BL.ContabilidadBL.SG_CO_TB_SUBDIARIO
        Dim SubdiariosBE As New BE.ContabilidadBE.SG_CO_TB_SUBDIARIO With {.SD_IDEMPRESA = New BE.ContabilidadBE.SG_CO_TB_EMPRESA With {.EM_ID = gInt_IdEmpresa}}
        Dim Dt As DataTable = SubdiariosBL.getSubdiarios(SubdiariosBE)

        Call LimpiaGrid(ug_subdiarios, uds_subdiarios)

        For i As Integer = 0 To Dt.Rows.Count - 1
            ug_subdiarios.DisplayLayout.Bands(0).AddNew()
            ug_subdiarios.Rows(i).Cells("Sel").Value = True
            ug_subdiarios.Rows(i).Cells("Codigo").Value = Dt.Rows(i)("SD_ID")
            ug_subdiarios.Rows(i).Cells("Subdiario").Value = Dt.Rows(i)("SD_DESCRIPCION")
        Next
        ug_subdiarios.UpdateData()

        SubdiariosBE = Nothing
        SubdiariosBL = Nothing

        If ug_subdiarios.Rows.Count > 0 Then ug_subdiarios.Rows(0).Activate()

    End Sub

    Private Sub uchk_todos_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles uchk_todos.CheckedChanged
        For i As Integer = 0 To ug_subdiarios.Rows.Count - 1
            ug_subdiarios.Rows(i).Cells("Sel").Value = uchk_todos.Checked
        Next
        ug_subdiarios.UpdateData()
    End Sub

    Private Sub Grabar_Codigos()

        Dim lista_codigos As New List(Of BE.ContabilidadBE.SG_CO_TB_CODIGOS_TMP)
        Dim ReportesBL As New BL.ContabilidadBL.SG_CO_Reportes_Registros

        ug_subdiarios.UpdateData()

        For i As Integer = 0 To ug_subdiarios.Rows.Count - 1
            If ug_subdiarios.Rows(i).Cells("Sel").Value Then
                lista_codigos.Add(New BE.ContabilidadBE.SG_CO_TB_CODIGOS_TMP(ug_subdiarios.Rows(i).Cells("Codigo").Value.ToString, Environment.MachineName, gInt_IdEmpresa))
            End If
        Next

        Call ReportesBL.setCodigos(lista_codigos)

    End Sub

    Private Sub Mostrar_Reporte()

        Dim Obj_ReporteBL As New BL.ContabilidadBL.SG_CO_Reportes_Registros

        Dim Dt As DataTable = Nothing
        Dim Str_mensaje As String = String.Empty
        Dim Str_ConFecha As Integer = IIf(uchk_SinFecha.Checked, "1", "0")
        Dim Str_Resumen As String = IIf(uchk_Resumen.Checked, "1", "0")

        Me.Cursor = Cursors.WaitCursor

        Dt = Obj_ReporteBL.get_Resumen_Movimi_Cuentas_x_Subdiarios(uce_nivel.Value, txt_Ayo.Text, uce_Mes.Value, uos_opciones.Value, Environment.MachineName, gInt_IdEmpresa)

        Dim Str_NombreRep As String = "SG_CO_40.RPT"
        Dim ObjReporte As New LR.ClsReporte

        ObjReporte.Muestra_Reporte(String.Format("{0}\{1}", gStr_RutaRep, Str_NombreRep), Dt, "", String.Format("pPeriodo;{0} / {1}", uce_Mes.Text.Trim, txt_Ayo.Text.Trim), _
                                                          "pEmp;" & gStr_NomEmpresa, "pNivel;" & uce_nivel.Text, "pForma;" & uos_opciones.Text, "pResumen;" & Str_Resumen, "pConFecha;" & Str_ConFecha)
        ObjReporte.Dispose()
        Me.Cursor = Cursors.Default

    End Sub

End Class