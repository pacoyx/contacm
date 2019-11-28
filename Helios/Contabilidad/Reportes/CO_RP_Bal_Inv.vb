Public Class CO_RP_Bal_Inv

    Private Sub CO_RP_Bal_Inv_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txt_Ayo.Text = gDat_Fecha_Sis.Year.ToString
    End Sub

    Private Sub Tool_imprimir_Click(sender As System.Object, e As System.EventArgs) Handles Tool_imprimir.Click
        Dim Obj_Crystal As New LR.ClsReporte
        Dim reporteBL As New BL.ContabilidadBL.SG_CO_Reportes_Registros

        Dim dt_repor As DataTable = Nothing


        Dim Obj_EmpresaBL As New BL.ContabilidadBL.SG_CO_TB_EMPRESA
        Dim E_Empresa As New BE.ContabilidadBE.SG_CO_TB_EMPRESA With {.EM_ID = gInt_IdEmpresa}
        Obj_EmpresaBL.getEmpresas_2(E_Empresa)

        Dim periodo As String = txt_Ayo.Text
        Dim ruc As String = E_Empresa.EM_RUC
        Dim emp As String = E_Empresa.EM_NOMBRE


        Select Case uos_Formato.Value
            Case "10"
                dt_repor = reporteBL.get_BI_formato_3_2_cta10(txt_Ayo.Text.Trim, gInt_IdEmpresa)
                Obj_Crystal.Muestra_Reporte(gStr_RutaRep & "\SG_CO_29.rpt", dt_repor, "", "pPeriodo;" & periodo, "pRuc;" & ruc, "pEmp;" & emp)
            Case "12"
                dt_repor = reporteBL.get_BI_formato_3_3_cta12(txt_Ayo.Text.Trim, gInt_IdEmpresa)
                Obj_Crystal.Muestra_Reporte(gStr_RutaRep & "\SG_CO_30.rpt", dt_repor, "", "pPeriodo;" & periodo, "pRuc;" & ruc, "pEmp;" & emp)
            Case "14"
                dt_repor = reporteBL.get_BI_formato_3_4_cta14(txt_Ayo.Text.Trim, gInt_IdEmpresa)
                Obj_Crystal.Muestra_Reporte(gStr_RutaRep & "\SG_CO_31.rpt", dt_repor, "", "pPeriodo;" & periodo, "pRuc;" & ruc, "pEmp;" & emp)
            Case "16"
                dt_repor = reporteBL.get_BI_formato_3_5_cta16(txt_Ayo.Text.Trim, gInt_IdEmpresa)
                Obj_Crystal.Muestra_Reporte(gStr_RutaRep & "\SG_CO_32.rpt", dt_repor, "", "pPeriodo;" & periodo, "pRuc;" & ruc, "pEmp;" & emp)
            Case "19"
                dt_repor = reporteBL.get_BI_formato_3_5_cta19(txt_Ayo.Text.Trim, gInt_IdEmpresa)
                Obj_Crystal.Muestra_Reporte(gStr_RutaRep & "\SG_CO_32_2.rpt", dt_repor, "", "pPeriodo;" & periodo, "pRuc;" & ruc, "pEmp;" & emp)
            Case "34"
                dt_repor = reporteBL.get_BI_formato_3_5_cta34(txt_Ayo.Text.Trim, gInt_IdEmpresa)
                Obj_Crystal.Muestra_Reporte(gStr_RutaRep & "\SG_CO_32_3.rpt", dt_repor, "", "pPeriodo;" & periodo, "pRuc;" & ruc, "pEmp;" & emp)
            Case "40"
                dt_repor = reporteBL.get_BI_formato_3_10_cta40(txt_Ayo.Text.Trim, gInt_IdEmpresa)
                Obj_Crystal.Muestra_Reporte(gStr_RutaRep & "\SG_CO_48.rpt", dt_repor, "", "pPeriodo;" & periodo, "pRuc;" & ruc, "pEmp;" & emp)

            Case "41"
                dt_repor = reporteBL.get_BI_formato_3_11_cta41(txt_Ayo.Text.Trim, gInt_IdEmpresa)
                Obj_Crystal.Muestra_Reporte(gStr_RutaRep & "\SG_CO_33.rpt", dt_repor, "", "pPeriodo;" & periodo, "pRuc;" & ruc, "pEmp;" & emp)
            Case "42"
                dt_repor = reporteBL.get_BI_formato_3_12_cta42_det(txt_Ayo.Text.Trim, gInt_IdEmpresa)
                Obj_Crystal.Muestra_Reporte(gStr_RutaRep & "\SG_CO_34.rpt", dt_repor, "", "pPeriodo;" & periodo, "pRuc;" & ruc, "pEmp;" & emp)
            Case "43"
                dt_repor = reporteBL.get_BI_formato_3_12_cta43(txt_Ayo.Text.Trim, gInt_IdEmpresa)
                Obj_Crystal.Muestra_Reporte(gStr_RutaRep & "\SG_CO_34_2.rpt", dt_repor, "", "pPeriodo;" & periodo, "pRuc;" & ruc, "pEmp;" & emp)
            Case "46"
                dt_repor = reporteBL.get_BI_formato_3_13_cta46(txt_Ayo.Text.Trim, gInt_IdEmpresa)
                Obj_Crystal.Muestra_Reporte(gStr_RutaRep & "\SG_CO_35.rpt", dt_repor, "", "pPeriodo;" & periodo, "pRuc;" & ruc, "pEmp;" & emp)
            Case "49"


            Case "50"
                CO_RP_DetCta50.ShowDialog()
                If CO_RP_DetCta50.bol_Aceptar Then
                    Dim dt_tmp_cab As DataTable = reporteBL.get_Grabar_Cabecera_DetCta50(txt_Ayo.Text.Trim, gInt_IdEmpresa)
                    dt_repor = reporteBL.get_Grabat_Detalle_DetCta50(txt_Ayo.Text.Trim, gInt_IdEmpresa)
                    Obj_Crystal.Muestra_Reporte(gStr_RutaRep & "\SG_CO_36.rpt", dt_repor, "", _
                                                "pPeriodo;" & periodo, _
                                                "pRuc;" & ruc, _
                                                "pEmpresa;" & emp, _
                                                "pV1;" & dt_tmp_cab.Rows(0)("RC_CS"), _
                                                "pV2;" & dt_tmp_cab.Rows(0)("RC_VN"), _
                                                "pV3;" & dt_tmp_cab.Rows(0)("RC_NA1"), _
                                                "pV4;" & dt_tmp_cab.Rows(0)("RC_NA2"), _
                                                "pV5;" & dt_tmp_cab.Rows(0)("RC_NA3"))
                End If

        End Select

        Obj_Crystal.Dispose()
        reporteBL = Nothing

    End Sub

    Private Sub Tool_salir_Click(sender As System.Object, e As System.EventArgs) Handles Tool_salir.Click
        Me.Close()
    End Sub

    Private Sub btn_inv_per_Click(sender As System.Object, e As System.EventArgs) Handles btn_inv_per.Click

        Dim reportesBL As New BL.ContabilidadBL.SG_CO_Reportes_Registros
        Dim Obj_Crystal As New LR.ClsReporte
        Dim dt_tmp As DataTable = reportesBL.get_Inv_Permanen_01(txt_Ayo.Text, txt_mes.Text, gInt_IdEmpresa)

        If gInt_IdEmpresa = 1 Then
            Obj_Crystal.Muestra_Reporte(gStr_RutaRep & "\SG_CO_44.rpt", dt_tmp, "", "pPeriodo;" & txt_Ayo.Text) '& "/" & txt_mes.Text)
        End If

        If gInt_IdEmpresa = 7 Then
            Obj_Crystal.Muestra_Reporte(gStr_RutaRep & "\SG_CO_45.rpt", dt_tmp, "", "pPeriodo;" & txt_Ayo.Text)
        End If

    End Sub

    Private Sub UltraButton1_Click(sender As System.Object, e As System.EventArgs) Handles UltraButton1.Click
        Dim reportesBL As New BL.ContabilidadBL.SG_CO_Reportes_Registros
        Dim Obj_Crystal As New LR.ClsReporte
        Dim dt_tmp As DataTable = reportesBL.get_IB_Cta_20_21(txt_Ayo.Text)

        If gInt_IdEmpresa = 7 Then
            Obj_Crystal.Muestra_Reporte(gStr_RutaRep & "\SG_CO_46.rpt", dt_tmp, "", "pPeriodo;" & txt_Ayo.Text)
        End If
    End Sub

    Private Sub txt_mes_ValueChanged(sender As System.Object, e As System.EventArgs) Handles txt_mes.ValueChanged

    End Sub
End Class