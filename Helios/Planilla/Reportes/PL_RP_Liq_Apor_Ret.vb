Public Class PL_RP_Liq_Apor_Ret

    Private Sub PL_RP_Liq_Apor_Ret_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txt_Ayo.Text = gDat_Fecha_Sis.Year
        Call Cargar_Afps()

        ubtn_Imprimir.Appearance.Image = My.Resources._004
        ubtn_Cancelar.Appearance.Image = My.Resources._16__Cancel_

    End Sub

    Private Sub Cargar_Afps()
        Dim reporteBL As New BL.PlanillaBL.SG_PL_Reportes
        Dim dt_tmp As DataTable = reporteBL.get_afp_tmp(gInt_IdEmpresa)
        reporteBL = Nothing

        uce_afp.DataSource = Nothing
        uce_afp.Items.Clear()
        uce_afp.Items.Add("0", "ONP")
        For i As Integer = 0 To dt_tmp.Rows.Count - 1
            uce_afp.Items.Add(dt_tmp.Rows(i)("AF_ID"), dt_tmp.Rows(i)("AF_NOMBRE"))
        Next

        dt_tmp.Dispose()
    End Sub

    Private Sub Cargar_Empleados()
        Dim reporteBL As New BL.PlanillaBL.SG_PL_Reportes
        Dim dt_empleados As DataTable = reporteBL.get_empleados_bdigf(gInt_IdEmpresa)

        uce_afp.DataSource = Nothing
        uce_afp.DataSource = dt_empleados
        uce_afp.DisplayMember = "NOMBRES"
        uce_afp.ValueMember = "PE_ID"

        reporteBL = Nothing
    End Sub

    Private Sub ubtn_Cancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ubtn_Cancelar.Click
        Me.Close()
    End Sub

    Private Sub ubtn_Imprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ubtn_Imprimir.Click
        Me.Cursor = Cursors.WaitCursor
        Select Case uos_formato.Value
            Case 1
                Call Imprimir_1()
            Case 2
                Call Imprimir_2()
            Case 3
                Call Imprimir_3()
        End Select
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub Imprimir_3()
        Dim reporteBL As New BL.PlanillaBL.SG_PL_Reportes
        Dim dt_data As DataTable = reporteBL.get_Certi_Rentas_Reten_5ta(uce_afp.Value, txt_Ayo.Text, gInt_IdEmpresa)
        Dim dt_info_per As DataTable = reporteBL.get_info_empleado(uce_afp.Value, gInt_IdEmpresa)
        Dim Obj_Crystal As New LR.ClsReporte


        If dt_data.Rows.Count = 0 Then
            Avisar("No hay informacion para mostrar")
            Exit Sub
        End If

        If dt_info_per.Rows.Count = 0 Then
            Avisar("No hay informacion del empleado para mostrar")
            Exit Sub
        End If

        Dim dt_tmp As New DataTable

        dt_tmp.Columns.Add("COD_PER", Type.GetType("System.String"))
        Dim f As DataRow
        f = dt_tmp.NewRow()
        f.Item("COD_PER") = "0001"

        dt_tmp.Rows.Add(f)



        Dim empresaBE As New BE.ContabilidadBE.SG_CO_TB_EMPRESA With {.EM_ID = gInt_IdEmpresa}
        Dim empresaBL As New BL.ContabilidadBL.SG_CO_TB_EMPRESA
        empresaBL.getEmpresas_2(empresaBE)
        Dim fecha As String = "Miraflores, " & gDat_Fecha_Sis.Day & " de " & Format(gDat_Fecha_Sis, "MMMM") & " de " & gDat_Fecha_Sis.Year

        Obj_Crystal.Muestra_Reporte(gStr_RutaRep & "\SG_PL_29.rpt", dt_tmp, "", _
                                    "pEmpresa;" & empresaBE.EM_NOMBRE, _
                                    "pRucEmp;" & empresaBE.EM_RUC, _
                                    "pDomicilio;" & empresaBE.EM_DIR1, _
                                    "pRepre;" & empresaBE.EM_REPRESENTANTE, _
                                    "pDniRepre;" & empresaBE.EM_DOCREPRE, _
                                    "pAyo;" & txt_Ayo.Text.Trim, _
                                    "pEmpleado;" & uce_afp.Text.Trim, _
                                    "pDniEmp;" & dt_info_per.Rows(0)("DOC_PER").ToString, _
                                    "pDomiEmp;" & dt_info_per.Rows(0)("DIR_PER").ToString, _
                                    "pCargoEmp;" & dt_info_per.Rows(0)("CARGO").ToString, _
                                    "pLugarFecha;" & fecha, _
                                    "pSueldos;" & dt_data.Rows(0)("sueldos"), _
                                    "pUtilidad;" & dt_data.Rows(0)("utilidad"), _
                                    "pRentaBruta;" & dt_data.Rows(0)("renta_bruta"), _
                                    "pDeducciones;" & dt_data.Rows(0)("deducciones"), _
                                    "pRentaNeta;" & dt_data.Rows(0)("renta_neta"), _
                                    "pImpuestoRenta;" & dt_data.Rows(0)("impuesto_renta"), _
                                    "pFecha;" & gDat_Fecha_Sis.ToShortDateString, _
                                    "pCargoRepre;" & empresaBE.EM_CARGO_REPRE, _
                                    "pCts;" & dt_data.Rows(0)("cts"))

        dt_data = Nothing
        dt_info_per = Nothing
        empresaBL = Nothing
        empresaBE = Nothing
        Obj_Crystal.Dispose()
    End Sub

    Private Sub Imprimir_2()

        Dim Obj_Crystal As New LR.ClsReporte
        Dim reporteBL As New BL.PlanillaBL.SG_PL_Reportes
        Dim dt_data As DataTable = reporteBL.get_Comproba_trabaja_reten(uce_afp.Value, txt_Ayo.Text)

        Obj_Crystal.Muestra_Reporte(gStr_RutaRep & "\SG_PL_26.rpt", dt_data, "", "pEmp;" & gStr_NomEmpresa, "pRuc;" & dt_data.Rows(0)("RUC_EMP").ToString, _
                                    "pEjercicio;" & txt_Ayo.Text.Trim, "pNombre;" & uce_afp.Text.Trim, "pDni;" & dt_data.Rows(0)("DNI").ToString & ",", _
                                    "pImp_rete;" & dt_data.Rows(0)("IMPORTE_RETE"), _
                                    "pTipoSistema;" & dt_data.Rows(0)("TIPO_SISTEMA").ToString, _
                                    "pRemu_asegu;" & dt_data.Rows(0)("REMU_ASE"), "pTotalsnp;" & dt_data.Rows(0)("RETE_ONP"), "pComision;" & dt_data.Rows(0)("COMISION"), _
                                    "pPrima;" & dt_data.Rows(0)("PRIMA"), "pAporte;" & dt_data.Rows(0)("APORTE"), _
                                    "pTotalSpp;" & dt_data.Rows(0)("RETE_SPP"), "pCargo;" & dt_data.Rows(0)("CARGO").ToString)

        Obj_Crystal.Dispose()

    End Sub

    Private Sub Imprimir_1()
        Dim reporteBL As New BL.PlanillaBL.SG_PL_Reportes
        Dim dt_data As DataTable = reporteBL.get_Liq_Anual_Aportes_Retenciones(txt_Ayo.Text, uce_afp.Value, gInt_IdEmpresa)
        Dim Obj_Crystal As New LR.ClsReporte

        Dim empresaBE As New BE.ContabilidadBE.SG_CO_TB_EMPRESA With {.EM_ID = gInt_IdEmpresa}
        Dim empresaBL As New BL.ContabilidadBL.SG_CO_TB_EMPRESA
        empresaBL.getEmpresas_2(empresaBE)
        Dim fecha As String = "Lima, " & gDat_Fecha_Sis.Day & " de " & Format(gDat_Fecha_Sis, "MMMM") & " de " & gDat_Fecha_Sis.Year

        Obj_Crystal.Muestra_Reporte(gStr_RutaRep & "\SG_PL_01.rpt", dt_data, "", _
                                    "pAfp;" & uce_afp.Text, _
                                    "pEmpresa;" & gStr_NomEmpresa, _
                                    "pRUC;" & empresaBE.EM_RUC, _
                                    "pEjercicio;" & "EJERCICIO " & txt_Ayo.Text, _
                                    "pRepre;" & empresaBE.EM_REPRESENTANTE, _
                                    "pCargo;" & empresaBE.EM_CARGO_REPRE, _
                                    "pDocu;" & empresaBE.EM_DOCREPRE, _
                                    "pFecha;" & fecha)

        empresaBL = Nothing
        empresaBE = Nothing
        Obj_Crystal.Dispose()
    End Sub

    Private Sub uos_formato_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles uos_formato.ValueChanged
        Select Case uos_formato.Value
            Case 1
                Call Cargar_Afps()
                ulbl_combo.Text = "AFP"
                ugb_combo.Text = "AFP / SNP"
            Case 2
                Call Cargar_Empleados()
                ulbl_combo.Text = "Empl."
                ugb_combo.Text = "Seleccione Empleado"
            Case 3
                Call Cargar_Empleados()
                ulbl_combo.Text = "Empl."
                ugb_combo.Text = "Seleccione Empleado"
        End Select
    End Sub

    Private Sub txt_Ayo_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_Ayo.KeyDown
        If e.KeyCode = Keys.Enter Then
            uce_afp.Focus()
        End If
    End Sub
End Class