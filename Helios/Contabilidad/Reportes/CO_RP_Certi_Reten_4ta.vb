Public Class CO_RP_Certi_Reten_4ta

    Private Sub CO_RP_Certi_Reten_4ta_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        txt_Ayo.Text = gDat_Fecha_Sis.Year

        Call Cargar_Anexos()
        ' Call Formatear_Grilla_Selector(ug_detalle)

    End Sub

    Private Sub Cargar_Anexos()
        Dim anexoBL As New BL.ContabilidadBL.SG_CO_TB_ANEXO
        uce_anexo.DataSource = anexoBL.get_Anexo_Tipo_Hono(gInt_IdEmpresa)
        uce_anexo.DisplayMember = "NOMBRES"
        uce_anexo.ValueMember = "COD_ANE"
        anexoBL = Nothing
    End Sub

    Private Sub ubtn_Cancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ubtn_Cancelar.Click
        Me.Close()
    End Sub

    Private Sub ubtn_Procesar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ubtn_Procesar.Click

        Dim reportesBL As New BL.ContabilidadBL.SG_CO_Reportes_Registros
        Dim dt_detalle As DataTable = Nothing

        Select Case txt_Ayo.Text
            Case 2011
                dt_detalle = reportesBL.get_Liq_Anual_Aportes_Retenciones(txt_Ayo.Text.Trim, uce_anexo.Value, gInt_IdEmpresa)
            Case Is > 2011
                dt_detalle = reportesBL.get_Liq_Anual_Aportes_Retenciones_Conta12(txt_Ayo.Text.Trim, uce_anexo.Value, gInt_IdEmpresa)
        End Select

        ug_detalle.DataSource = dt_detalle
        'ug_detalle.Refresh()

        'sumamos totales por item
        ume_rentas_no_sujetas.Value = dt_detalle.Compute("sum(monto)", "retencion = 0")
        ume_rentas_sujetas.Value = dt_detalle.Compute("sum(total)", "retencion > 0")
        ume_imp_retenido.Value = dt_detalle.Compute("sum(retencion)", "")

        If ume_rentas_no_sujetas.Value.ToString = "" Then ume_rentas_no_sujetas.Value = 0
        If ume_rentas_sujetas.Value.ToString = "" Then ume_rentas_sujetas.Value = 0
        If ume_imp_retenido.Value.ToString = "" Then ume_imp_retenido.Value = 0

        reportesBL = Nothing

    End Sub

    Private Sub ubtn_Imprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ubtn_Imprimir.Click
        Me.Cursor = Cursors.WaitCursor
        Dim reporteBL As New BL.PlanillaBL.SG_PL_Reportes
        Dim dt_data As DataTable = reporteBL.get_Tabla_Vacia()
        Dim Obj_Crystal As New LR.ClsReporte

        Dim empresaBE As New BE.ContabilidadBE.SG_CO_TB_EMPRESA With {.EM_ID = gInt_IdEmpresa}
        Dim empresaBL As New BL.ContabilidadBL.SG_CO_TB_EMPRESA
        empresaBL.getEmpresas_2(empresaBE)
        Dim fecha As String = "Miraflores, " & gDat_Fecha_Sis.Day & " de " & Format(gDat_Fecha_Sis, "MMMM") & " de " & gDat_Fecha_Sis.Year
        Dim nombre As String = uce_anexo.Text.Trim.Substring(14, uce_anexo.Text.Trim.Length - 14).Trim
        Dim ruc As String = uce_anexo.Text.Trim.Substring(0, 11)
        Dim dir As String = txt_dir.Text.Trim
        Dim actividad As String = txt_actividad.Text.Trim
        Dim canedaLetras As String = ModBasConta.Letras(ume_imp_retenido.Value)
        Dim imp_letras As String = ""
        Dim str_tmp As String = ""

        imp_letras = canedaLetras.Substring(0, 1).ToUpper
        str_tmp = canedaLetras.Remove(0, 1)
        imp_letras = imp_letras & str_tmp

        Dim str_formato_rep As String = "SG_CO_39.rpt"
        Dim str_titulo As String = "0"
        Select Case gInt_IdEmpresa
            Case 3 To 6
                str_titulo = "0"
                str_formato_rep = "SG_CO_39_1.rpt"
            Case Else
                str_titulo = "1"
        End Select


        'Obj_Crystal.Muestra_Reporte(gStr_RutaRep & "\" & str_formato_rep, dt_data, "")

        Obj_Crystal.Muestra_Reporte(gStr_RutaRep & "\" & str_formato_rep, dt_data, "", _
                                    "pAyo;" & txt_Ayo.Text, _
                                    "pNombre;" & nombre, _
                                    "pRuc;" & ruc, _
                                    "pDir;" & dir, _
                                    "pActividad;" & actividad, _
                                    "pImp_No_Sujeto;" & ume_rentas_no_sujetas.Value, _
                                    "pImp_Sujeto;" & ume_rentas_sujetas.Value, _
                                    "pImp_Retenido;" & ume_imp_retenido.Value, _
                                    "pImp_Letras;" & imp_letras, _
                                    "pFecha;" & fecha, _
                                    "pRepre;" & empresaBE.EM_REPRESENTANTE, _
                                    "pCargo_Repre;" & empresaBE.EM_CARGO_REPRE, _
                                    "pNomEmpresa;" & empresaBE.EM_NOMBRE, _
                                    "pBol_Titulo;" & str_titulo)

        empresaBL = Nothing
        empresaBE = Nothing
        Obj_Crystal.Dispose()
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub txt_Ayo_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_Ayo.KeyDown
        If e.KeyCode = Keys.Enter Then
            uce_anexo.Focus()
        End If
    End Sub

    Private Sub uce_anexo_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles uce_anexo.KeyDown
        If e.KeyCode = Keys.Enter Then
            ubtn_Procesar.Focus()
        End If
    End Sub

    Private Sub uce_anexo_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles uce_anexo.ValueChanged
        Dim honorraioBL As New BL.ContabilidadBL.SG_CO_TB_HONORARIO_PROFE
        Dim dt_tmp As DataTable = honorraioBL.getHonorarios(uce_anexo.Value)

        If dt_tmp.Rows.Count > 0 Then
            With dt_tmp.Rows(0)
                txt_dir.Text = .Item("HP_DIR")
                txt_actividad.Text = .Item("HP_PROFESION")
            End With
        End If

        honorraioBL = Nothing
        dt_tmp.Dispose()
    End Sub
End Class