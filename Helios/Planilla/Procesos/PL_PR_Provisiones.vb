Public Class PL_PR_Provisiones

    Private Sub PL_PR_Provisiones_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'cargamos el periodo
        Call CargarCombo_ConMeses(uce_Mes)
        une_Ayo.Value = gDat_Fecha_Sis.Year
        uce_Mes.Value = gDat_Fecha_Sis.Month

        udte_fec_Vou.Value = ObtenerUltimoDia(gDat_Fecha_Sis)
        Call Cargar_Subdiarios()
        uce_SubDiario.Value = 13

    End Sub

    Private Sub Cargar_Subdiarios()

        Dim subdiarioBL As New BL.ContabilidadBL.SG_CO_TB_SUBDIARIO
        Dim subdiarioBE As New BE.ContabilidadBE.SG_CO_TB_SUBDIARIO With {.SD_IDEMPRESA = New BE.ContabilidadBE.SG_CO_TB_EMPRESA With {.EM_ID = gInt_IdEmpresa}}
        Dim dt_tmp As DataTable = subdiarioBL.getSubdiarios(subdiarioBE)

        'uce_SubDiario.DataSource = subdiarioBL.getSubdiarios(subdiarioBE)
        'uce_SubDiario.DisplayMember = "SD_DESCRIPCION"
        'uce_SubDiario.ValueMember = "SD_ID"

        For i As Integer = 0 To dt_tmp.Rows.Count - 1
            uce_SubDiario.Items.Add(dt_tmp.Rows(i)("SD_ID"), dt_tmp.Rows(i)("SD_ID") & " - " & dt_tmp.Rows(i)("SD_DESCRIPCION"))
        Next


        uce_SubDiario.SelectedIndex = -1

        dt_tmp.Dispose()
        subdiarioBE = Nothing
        subdiarioBL = Nothing


    End Sub

    Private Sub Tool_Procesar_Click(sender As System.Object, e As System.EventArgs) Handles Tool_Procesar.Click
        Dim provisionBL As New BL.PlanillaBL.Calculos
        ug_Asiento.DataSource = provisionBL.get_Provision_Cts(une_Ayo.Value, uce_Mes.Value, gInt_IdEmpresa, uos_tipo.Value)
        provisionBL = Nothing
    End Sub

    Private Sub Tool_Generar_Click(sender As System.Object, e As System.EventArgs) Handles Tool_Generar.Click

        If ug_Asiento.Rows.Count = 0 Then
            Avisar("No hay filas en el asiento para continuar")
            Exit Sub
        End If



        If Preguntar("Esta seguro que quiere generar el asiento?") Then


            Dim str_glosa As String = String.Empty
            Dim AsientoBL As New BL.ContabilidadBL.SG_CO_TB_ASIENTO_CONTABLE
            Dim E_Cabecera As New BE.ContabilidadBE.SG_CO_TB_ASIENTO_CAB
            Dim Detalles As New List(Of BE.ContabilidadBE.SG_CO_TB_ASIENTO_DET)

            If uos_tipo.Value = 1 Then
                str_glosa = "PROVISION CTS " & CDate(udte_fec_Vou.Value).Month & "-" & CDate(udte_fec_Vou.Value).Year.ToString
            Else
                str_glosa = "PROVISION VACACIONES " & CDate(udte_fec_Vou.Value).Month & "-" & CDate(udte_fec_Vou.Value).Year.ToString
            End If


            Dim debe_total As Double = 0
            Dim haber_total As Double = 0

            For i As Integer = 0 To ug_Asiento.Rows.Count - 1
                debe_total += ug_Asiento.Rows(i).Cells("debe").Value
                haber_total += ug_Asiento.Rows(i).Cells("haber").Value
            Next


            With E_Cabecera
                .AC_ID = 0
                .AC_IDSUBDIARIO = New BE.ContabilidadBE.SG_CO_TB_SUBDIARIO With {.SD_ID = uce_SubDiario.Value}
                .AC_NUM_VOUCHER = String.Empty
                .AC_ANHO = CDate(udte_fec_Vou.Value).Year
                .AC_MES = CDate(udte_fec_Vou.Value).Month
                .AC_FEC_VOUCHER = CDate(udte_fec_Vou.Value).ToShortDateString
                .AC_IDMONEDA = New BE.ContabilidadBE.SG_CO_TB_MONEDA With {.MO_CODIGO = 1}
                .AC_DEBE = debe_total
                .AC_HABER = haber_total
                .AC_TC_OPE = Obtener_TipoCambio_Fin_deMes()
                .AC_TC_ESPECIAL = 0
                .AC_ESTADO = 1
                .AC_GLOSA_VOU = str_glosa
                .AC_ES_INTERFACE = 0
                .AC_TC_FORMATO = New BE.ContabilidadBE.SG_CO_TB_FORM_TIPCAMB With {.FT_CODIGO = 1}
                .AC_USUARIO = String.Format("{0}-{1}", Environment.UserName, gStr_Usuario_Sis)
                .AC_TERMINAL = Environment.MachineName
                .AC_FECREG = Date.Now
                .AC_IDEMPRESA = New BE.ContabilidadBE.SG_CO_TB_EMPRESA With {.EM_ID = gInt_IdEmpresa}
            End With

            Dim E_Detalle As BE.ContabilidadBE.SG_CO_TB_ASIENTO_DET

            For i As Integer = 0 To ug_Asiento.Rows.Count - 1
                E_Detalle = New BE.ContabilidadBE.SG_CO_TB_ASIENTO_DET()
                With E_Detalle
                    .AD_IDCAB = E_Cabecera
                    .AD_SECUENCIA = ug_Asiento.Rows(i).Cells("Item").Value.ToString
                    .AD_CUENTA = ug_Asiento.Rows(i).Cells("Cuenta").Value.ToString
                    .AD_TANEXO = Nothing
                    .AD_IDANEXO = Nothing
                    .AD_TDOC = Nothing

                    .AD_SDOC = String.Empty
                    .AD_NDOC = String.Empty
                    .AD_FDOC = String.Empty
                    .AD_VDOC = String.Empty

                    .AD_DEBE = IIf(ug_Asiento.Rows(i).Cells("Debe").Value.ToString = String.Empty, 0, ug_Asiento.Rows(i).Cells("Debe").Value)
                    .AD_HABER = IIf(ug_Asiento.Rows(i).Cells("Haber").Value.ToString = String.Empty, 0, ug_Asiento.Rows(i).Cells("Haber").Value)
                    .AD_MONTO_ORI = .AD_DEBE + .AD_HABER
                    .AD_PORCE_DESTINO = 0
                    .AD_TCAM = 0

                    .AD_SEC_ORI_DESTINO = 0
                    .AD_GLOSA = str_glosa
                    .AD_IDCC = New BE.ContabilidadBE.SG_CO_TB_CENTROCOSTO With {.CC_CODIGO = 0}
                    .AD_ES_DESTINO = ug_Asiento.Rows(i).Cells("EsDestino").Value
                    .AD_USUARIO = String.Format("{0}-{1}", Environment.UserName, gStr_Usuario_Sis)
                    .AD_TERMINAL = Environment.MachineName
                    .AD_FECREG = Date.Now
                    .AD_IDMEDIOPAGO = Nothing

                End With
                Detalles.Add(E_Detalle)
            Next



            Try
                'Grabamos el voucher
                Dim StrVoucher As String = String.Empty
                AsientoBL.Insert_Generales(E_Cabecera, Detalles, StrVoucher, False)

                Call Avisar("Listo!")

            Catch ex As Exception
                ShowError(ex.Message)
            End Try

        End If
    End Sub

    Private Sub Tool_Salir_Click(sender As System.Object, e As System.EventArgs) Handles Tool_Salir.Click
        Me.Close()
    End Sub

    Private Function Obtener_TipoCambio_Fin_deMes() As Double
        Obtener_TipoCambio_Fin_deMes = 0

        If uce_Mes.SelectedIndex = -1 Then Exit Function

        Dim tcBL As New BL.ContabilidadBL.SG_CO_TB_TIPOCAMBIO
        Dim tcBE As New BE.ContabilidadBE.SG_CO_TB_TIPOCAMBIO
        tcBE.TC_IDEMPRESA = New BE.ContabilidadBE.SG_CO_TB_EMPRESA With {.EM_ID = gInt_IdEmpresa}
        tcBE.TC_IDMONEDA = New BE.ContabilidadBE.SG_CO_TB_MONEDA With {.MO_CODIGO = 2}
        tcBE.TC_FECHA = ObtenerUltimoDia("01/" & uce_Mes.Value.ToString.PadLeft(1, "0") & "/" & une_Ayo.Value.ToString)
        tcBL.getTipoCambio(tcBE)

        If tcBE.TC_COMPRA > 0 Then
            Obtener_TipoCambio_Fin_deMes = tcBE.TC_COMPRA
        End If

        tcBE = Nothing
        tcBL = Nothing

    End Function

    Private Sub uce_Mes_ValueChanged(sender As System.Object, e As System.EventArgs) Handles uce_Mes.ValueChanged
        Dim fecha As String = "01/" & uce_Mes.Value.ToString.PadLeft(2, "0") & "/" & CDate(udte_fec_Vou.Value).Year.ToString
        udte_fec_Vou.Value = ObtenerUltimoDia(fecha)
        Call LimpiaGrid(ug_Asiento, uds_Asiento)
    End Sub

    Private Sub uos_tipo_ValueChanged(sender As System.Object, e As System.EventArgs) Handles uos_tipo.ValueChanged
        Call LimpiaGrid(ug_Asiento, uds_Asiento)
    End Sub
End Class