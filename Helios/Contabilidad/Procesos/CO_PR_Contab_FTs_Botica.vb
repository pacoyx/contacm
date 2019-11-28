Public Class CO_PR_Contab_FTs_Botica

    Private Sub CO_PR_Contab_FTs_Botica_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

        txt_Ayo.Text = gDat_Fecha_Sis.Year
        txt_Ayo.ReadOnly = True

        Call CargarCombo_ConMeses(uce_Mes)
        uce_Mes.Value = gDat_Fecha_Sis.Month

        Call Cargar_Columna_CC()

    End Sub

    Private Sub Cargar_Columna_CC()

        Dim dt_cc As DataTable = Nothing
        Dim ccBL As New BL.ContabilidadBL.SG_CO_TB_CENTROCOSTO
        Dim ccBE As New BE.ContabilidadBE.SG_CO_TB_CENTROCOSTO

        ccBE.CC_IDEMPRESA = New BE.ContabilidadBE.SG_CO_TB_EMPRESA With {.EM_ID = gInt_IdEmpresa}
        dt_cc = ccBL.getCentroCostos(ccBE)

        ccBE = Nothing
        ccBL = Nothing

        Call CrearComboGrid("CC", "CC_DESCRIPCION", ug_FTs_Botica, dt_cc, True)

    End Sub

    Private Sub Tool_salir_Click(sender As System.Object, e As System.EventArgs) Handles Tool_salir.Click
        Me.Close()
    End Sub

    Private Sub Tool_Contabilizar_Click(sender As System.Object, e As System.EventArgs) Handles Tool_Contabilizar.Click

        If Preguntar("Seguro de Contabilizar las Facturas") Then
            Call Contabilizar_Facturas()
        End If

    End Sub

    Private Sub Cargar_Facturas()
        Dim consultasBL As New BL.ContabilidadBL.Consultas
        ug_FTs_Botica.DataSource = consultasBL.get_Facturas_de_Botica(txt_Ayo.Text, uce_Mes.Value)
        consultasBL.Dispose()
    End Sub

    Private Sub Contabilizar_Facturas()
        Dim AsientoBL As New BL.ContabilidadBL.SG_CO_TB_ASIENTO_CONTABLE
        Dim E_Compras As New BE.ContabilidadBE.SG_CO_TB_COMPRAS
        Dim E_Cabecera As New BE.ContabilidadBE.SG_CO_TB_ASIENTO_CAB
        Dim Detalles As New List(Of BE.ContabilidadBE.SG_CO_TB_ASIENTO_DET)

        For i As Integer = 0 To ug_FTs_Botica.Rows.Count - 1

            'With E_Compras
            '    .CO_IDCAB = Nothing
            '    .CO_TIPO_ANEXO = New SG_CO_TB_TIPOANEXO With {.TA_CODIGO = Int_TipoAnexo}
            '    .CO_ANEXO_ID = New SG_CO_TB_ANEXO With {.AN_IDANEXO = txt_IdAnexo.Text.Trim}
            '    .CO_TIP_DOC = New SG_CO_TB_DOCUMENTO With {.DO_CODIGO = uce_TipoDoc.Value}
            '    .CO_SER_DOC = txt_SerieDoc.Text.Trim
            '    .CO_NUM_DOC = txt_NumDoc.Text.Trim
            '    .CO_INDICADOR_DESTINO = uce_Indicador.Value
            '    .CO_FEC_EMI = CDate(udte_Fec_Emi.Value).ToShortDateString
            '    .CO_FEC_VEN = CDate(udte_Fec_Ven.Value).ToShortDateString
            '    .CO_FEC_VOU = CDate(udte_fec_Vou.Value).ToShortDateString

            '    If Bol_Es_NC Then
            '        .CO_TIP_DOC_REF = New SG_CO_TB_DOCUMENTO With {.DO_CODIGO = CO_PR_VouCompras_Referencia.uce_TipoDoc_Ref.Value}
            '        .CO_SER_DOC_REF = CO_PR_VouCompras_Referencia.txt_SerieDoc_Ref.Text.Trim
            '        .CO_NUM_DOC_REF = CO_PR_VouCompras_Referencia.txt_NumDoc_Ref.Text.Trim
            '        .CO_FEC_EMI_REF = CO_PR_VouCompras_Referencia.ume_Fec_Ref.Value
            '    Else
            '        .CO_TIP_DOC_REF = Nothing
            '        .CO_SER_DOC_REF = String.Empty
            '        .CO_NUM_DOC_REF = String.Empty
            '        .CO_FEC_EMI_REF = String.Empty
            '    End If

            '    .CO_TASA_IGV = ume_Tasa_Igv.Value
            '    .CO_MONTO_IGV = ume_Monto_Igv.Value
            '    .CO_MONTO_EXONERADO = ume_ValorNoGrabado.Value
            '    .CO_TASA_ISC = ume_Tasa_ISC.Value
            '    .CO_MONTO_ISC = ume_Valor_ISC.Value
            '    .CO_OTROS_TRIBUTOS = ume_OtrosTributos.Value
            '    .CO_IMPORTE_COMPRA = ume_ValorCompra.Value
            '    .CO_IMPORTE_VENTA = ume_Precioventa.Value

            '    If uce_SubOperacion.Value = 4 Then 'Con Detraccion
            '        .CO_ES_AFECTO_DETRA = 1
            '        .CO_TASA_DETRA = IIf(IsDBNull(CO_PR_VouCompras_Detraccion.ume_Tasa_Detra.Value), 0, CO_PR_VouCompras_Detraccion.ume_Tasa_Detra.Value)
            '        .CO_IMPORTE_DETRA = ume_Imp_Detra.Value
            '        .CO_VALOR_RAZ_DETRA = IIf(IsDBNull(CO_PR_VouCompras_Detraccion.ume_Valor_Razonable.Value), 0, CO_PR_VouCompras_Detraccion.ume_Valor_Razonable.Value)
            '        .CO_NUMERO_DETRA = CO_PR_VouCompras_Detraccion.txt_Num_Dep.Text.Trim

            '        If CO_PR_VouCompras_Detraccion.ume_Fec_Detra.Value.ToString = "" Then
            '            .CO_FEC_EMI_DETRA = String.Empty
            '        Else
            '            .CO_FEC_EMI_DETRA = CDate(CO_PR_VouCompras_Detraccion.ume_Fec_Detra.Value).ToShortDateString
            '        End If

            '        .CO_TIPO_SERV_DETRA = CO_PR_VouCompras_Detraccion.uce_Tipo_Servicio.Value
            '        .CO_SERV_DETRA = CO_PR_VouCompras_Detraccion.uce_Servicio.Value
            '    Else
            '        .CO_ES_AFECTO_DETRA = 0
            '        .CO_TASA_DETRA = 0
            '        .CO_IMPORTE_DETRA = 0
            '        .CO_VALOR_RAZ_DETRA = 0
            '        .CO_NUMERO_DETRA = String.Empty
            '        .CO_FEC_EMI_DETRA = String.Empty
            '        .CO_TIPO_SERV_DETRA = String.Empty
            '        .CO_SERV_DETRA = String.Empty
            '    End If

            '    If uce_SubOperacion.Value = 5 Then 'Con Percepcion
            '        .CO_ES_AFECTO_PERCEP = 1
            '        .CO_TASA_PERCEP = 0
            '    Else
            '        .CO_ES_AFECTO_PERCEP = 0
            '        .CO_TASA_PERCEP = 0
            '    End If

            '    .CO_ISTATUS = 1
            '    .CO_IMPORTE_PAGAR = ume_Imp_Pagar.Value
            '    .CO_TASA_4TA = 0
            '    .CO_TOTAL_HONO = 0
            '    .CO_MONTO_RET = 0
            '    .CO_MONTO_PERCI = 0
            'End With

            'With E_Cabecera
            '    .AC_ID = Int_IdCab_Edit
            '    .AC_IDSUBDIARIO = New BE.ContabilidadBE.SG_CO_TB_SUBDIARIO With {.SD_ID = uce_Subdiario.Value}
            '    .AC_NUM_VOUCHER = txt_Num_Voucher.Text.Trim
            '    .AC_ANHO = CDate(udte_fec_Vou.Value).Year
            '    .AC_MES = CDate(udte_fec_Vou.Value).Month
            '    .AC_FEC_VOUCHER = CDate(udte_fec_Vou.Value).ToShortDateString
            '    .AC_IDMONEDA = New BE.ContabilidadBE.SG_CO_TB_MONEDA With {.MO_CODIGO = 1}
            '    .AC_DEBE = ume_tot_d.Value
            '    .AC_HABER = ume_tot_h.Value
            '    .AC_TC_OPE = ume_ValorTipoCambio.Value
            '    .AC_TC_ESPECIAL = 0
            '    If uce_TipoCambio.Value = 3 Then
            '        .AC_TC_ESPECIAL = ume_ValorTipoCambio.Value
            '    End If
            '    .AC_ESTADO = 1
            '    .AC_GLOSA_VOU = txt_Glosa.Text.Trim
            '    .AC_ES_INTERFACE = 0
            '    .AC_TC_FORMATO = New SG_CO_TB_FORM_TIPCAMB With {.FT_CODIGO = uce_TipoCambio.Value}
            '    .AC_USUARIO = String.Format("{0}-{1}", Environment.UserName, gStr_Usuario_Sis)
            '    .AC_TERMINAL = Environment.MachineName
            '    .AC_FECREG = Date.Now
            '    .AC_IDEMPRESA = New BE.ContabilidadBE.SG_CO_TB_EMPRESA With {.EM_ID = gInt_IdEmpresa}
            'End With



        Next

    End Sub

    Private Sub uce_Mes_ValueChanged(sender As System.Object, e As System.EventArgs) Handles uce_Mes.ValueChanged

    End Sub

    Private Sub ubtn_Cargar_Fts_Click(sender As System.Object, e As System.EventArgs) Handles ubtn_Cargar_Fts.Click
        Call Cargar_Facturas()
    End Sub
End Class