Public Class CO_PR_DifCam_Mensual
    Dim str_cuenta_ganancia As String = ""
    Dim str_cuenta_perdida As String = ""


    Private Sub CO_PR_DifCam_Mensual_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        une_Ayo.Value = gDat_Fecha_Sis.Year
        Call CargarCombo_ConMeses(uce_Mes)
        ume_ValorTipoCambio.Value = Obtener_TipoCambio_Fin_deMes()
        udte_fec_Vou.Value = ObtenerUltimoDia(gDat_Fecha_Sis)
        Call Cargar_Cuentas_DifCambio()
        Call Formatear_Grilla_Selector(ug_Dif_Prove)
        Call Formatear_Grilla_Selector(ug_resultado_bancos)
        Call Cargar_Subdiario_DifCambio()

    End Sub

    Private Sub Cargar_Subdiario_DifCambio()
        Dim subdiarioBL As New BL.ContabilidadBL.SG_CO_TB_SUBDIARIO
        txt_subdiario.Text = subdiarioBL.get_Subdiario_DifCambio(gInt_IdEmpresa)
        subdiarioBL = Nothing

        If txt_subdiario.Text.Trim.Length = 0 Then
            Avisar("No se ha establecido un Subdiario para el proceso de 'Diferencia de Cambio'.")
        End If

    End Sub


    Private Sub Procesar_DifCambio_Mensual_Bancos()

        Dim diferenciaBL As New BL.ContabilidadBL.Cls_AjuDifCam
        Dim tipoCambio_31Mes As Double = ume_ValorTipoCambio.Value
        Dim saldo_ctaBanco_Sol As Double = 0
        Dim saldo_ctaBanco_Dol As Double = 0
        Dim dt_ctasBancoDol As DataTable = diferenciaBL.get_Ctas_Banco_Dolares(une_Ayo.Value, gInt_IdEmpresa)


        Dim importe_provi As Double = 0
        Dim importe_al31 As Double = 0
        Dim importe_diferencia As Double = 0

        LimpiaGrid(ug_resultado_bancos, uds_diferencia)

        For i As Integer = 0 To dt_ctasBancoDol.Rows.Count - 1

            saldo_ctaBanco_Sol = diferenciaBL.get_Saldo_CtaBanco_Sol(dt_ctasBancoDol.Rows(i)("PC_NUM_CUENTA"), une_Ayo.Value, uce_Mes.Value, gInt_IdEmpresa)
            saldo_ctaBanco_Dol = diferenciaBL.get_Saldo_CtaBanco_Dol(dt_ctasBancoDol.Rows(i)("PC_NUM_CUENTA"), une_Ayo.Value, uce_Mes.Value, gInt_IdEmpresa)

            importe_al31 = saldo_ctaBanco_Dol * tipoCambio_31Mes
            importe_diferencia = importe_al31 - saldo_ctaBanco_Sol


            'si es mayor a cero es que hay ganancia
            '           Debe  Haber
            '104________dif
            '77_______________xx

            'check-cuenta-descripcion-ganacia-perdida-
            ug_resultado_bancos.DisplayLayout.Bands(0).AddNew()
            ug_resultado_bancos.Rows(i).Cells("Sel").Value = True
            ug_resultado_bancos.Rows(i).Cells("Cuenta").Value = dt_ctasBancoDol.Rows(i)("PC_NUM_CUENTA")
            ug_resultado_bancos.Rows(i).Cells("Descripcion").Value = dt_ctasBancoDol.Rows(i)("PC_DESCRIPCION")

            If importe_diferencia > 0 Then
                ug_resultado_bancos.Rows(i).Cells("Ganancia").Value = Math.Abs(importe_diferencia)
                ug_resultado_bancos.Rows(i).Cells("Perdida").Value = 0
            Else
                ug_resultado_bancos.Rows(i).Cells("Ganancia").Value = 0
                ug_resultado_bancos.Rows(i).Cells("Perdida").Value = Math.Abs(importe_diferencia)
            End If

            ug_resultado_bancos.Update()

        Next


        diferenciaBL = Nothing

        ulbl_total.Text = "N° de Filas : " & ug_resultado_bancos.Rows.Count

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

    Private Sub ubtn_Procesar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ubtn_Procesar.Click

        Call LimpiaGrid(ug_resultado_bancos, uds_diferencia)

        Select Case uos_tipo.Value
            Case 1 'bancos
                Call Procesar_DifCambio_Mensual_Bancos()
            Case 2 'proveedores
                Call Procesar_Dif_Cambio_mensual_Proveedores()
        End Select

        ug_Dif_Prove.UpdateData()

    End Sub


    Private Sub Procesar_Dif_Cambio_Mensual_Proveedores()

        Me.Cursor = Cursors.WaitCursor


        Dim diferenciaBL As New BL.ContabilidadBL.Cls_AjuDifCam
        Dim dt_diferencias As DataTable = diferenciaBL.get_Dif_Cambio_Proveedores(une_Ayo.Value, ume_ValorTipoCambio.Value, gInt_IdEmpresa)

        'ug_Dif_Prove.DataSource = dt_diferencias

        Call LimpiaGrid(ug_Dif_Prove, uds_dif_prove)

        For i As Integer = 0 To dt_diferencias.Rows.Count - 1
            ug_Dif_Prove.DisplayLayout.Bands(0).AddNew()
            ug_Dif_Prove.Rows(i).Cells("CUENTA").Value = dt_diferencias(i)("CUENTA")
            ug_Dif_Prove.Rows(i).Cells("DOCUMENTO").Value = dt_diferencias(i)("DOCUMENTO")
            ug_Dif_Prove.Rows(i).Cells("ANEXO").Value = dt_diferencias(i)("ANEXO")
            ug_Dif_Prove.Rows(i).Cells("GANANCIA").Value = dt_diferencias(i)("GANANCIA")
            ug_Dif_Prove.Rows(i).Cells("PERDIDA").Value = dt_diferencias(i)("PERDIDA")
            ug_Dif_Prove.Rows(i).Cells("ANEXOID").Value = dt_diferencias(i)("ANEXOID")
            ug_Dif_Prove.UpdateData()
        Next


        If ug_Dif_Prove.Rows.Count > 0 Then ug_Dif_Prove.Rows(0).Activate()


        Me.Cursor = Cursors.Default

        ulbl_total.Text = "N° de Filas : " & ug_Dif_Prove.Rows.Count

    End Sub


    Private Sub ubtn_GeneraAsiento_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ubtn_GeneraAsiento.Click


        If Preguntar("Esta seguro que quiere generar el asiento?") Then
            Select Case uos_tipo.Value
                Case 1 'bancos

                    Dim idsubdiario As String = LSet(txt_subdiario.Text, 2)

                    ug_resultado_bancos.UpdateData()
                    For i As Integer = 0 To ug_resultado_bancos.Rows.Count - 1
                        With ug_resultado_bancos.Rows(i)
                            If .Cells("Sel").Value Then
                                Call Generar_Asiento_Diferencia_Bancos(.Cells("cuenta").Value, .Cells("ganancia").Value, .Cells("perdida").Value, idsubdiario.Trim)
                            End If
                        End With
                    Next

                Case 2 'proveedores

                    Call Generar_Asiento_Diferencia_Proveedores()

            End Select
        End If
    End Sub

    Private Sub uce_Mes_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles uce_Mes.ValueChanged
        ume_ValorTipoCambio.Value = Obtener_TipoCambio_Fin_deMes()
        udte_fec_Vou.Value = ObtenerUltimoDia("01/" & uce_Mes.Value.ToString.PadLeft(2, "0") & "/" & une_Ayo.Value)
    End Sub

    Private Sub Cargar_Cuentas_DifCambio()

        Dim ayuda As New BL.ContabilidadBL.SG_CO_TB_ASIENTO_CONTABLE
        Dim lista_ctas As New List(Of String)
        lista_ctas = ayuda.get_Ctas_Diferencia(gDat_Fecha_Sis.Year, gInt_IdEmpresa)

        str_cuenta_ganancia = lista_ctas(0)
        str_cuenta_perdida = lista_ctas(1)

        ayuda = Nothing
        lista_ctas = Nothing

    End Sub


    Private Sub Generar_Asiento_Diferencia_Bancos(ByVal cuenta_ As String, ByVal ganancia_ As Double, ByVal perdida_ As Double, idSubdiario_ As String)

        Dim str_cod_subdiario_dif As String = idSubdiario_


        Dim str_glosa As String = "Por el ajuste de la diferencia de cambio mensual Cuentas Bancos"
        Dim AsientoBL As New BL.ContabilidadBL.SG_CO_TB_ASIENTO_CONTABLE
        Dim E_Cabecera As New BE.ContabilidadBE.SG_CO_TB_ASIENTO_CAB
        Dim Detalles As New List(Of BE.ContabilidadBE.SG_CO_TB_ASIENTO_DET)

        With E_Cabecera
            .AC_ID = 0
            .AC_IDSUBDIARIO = New BE.ContabilidadBE.SG_CO_TB_SUBDIARIO With {.SD_ID = str_cod_subdiario_dif}
            .AC_NUM_VOUCHER = String.Empty
            .AC_ANHO = CDate(udte_fec_Vou.Value).Year
            .AC_MES = CDate(udte_fec_Vou.Value).Month
            .AC_FEC_VOUCHER = CDate(udte_fec_Vou.Value).ToShortDateString
            .AC_IDMONEDA = New BE.ContabilidadBE.SG_CO_TB_MONEDA With {.MO_CODIGO = 1}
            .AC_DEBE = IIf(ganancia_ > 0, ganancia_, perdida_)
            .AC_HABER = IIf(ganancia_ > 0, ganancia_, perdida_)
            .AC_TC_OPE = ume_ValorTipoCambio.Value
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

        'Agregamos la cuenta 104 de bancos
        E_Detalle = New BE.ContabilidadBE.SG_CO_TB_ASIENTO_DET()
        With E_Detalle
            .AD_IDCAB = E_Cabecera
            .AD_SECUENCIA = 1
            .AD_CUENTA = cuenta_
            .AD_TANEXO = Nothing
            .AD_IDANEXO = Nothing
            .AD_TDOC = Nothing
            .AD_SDOC = String.Empty
            .AD_NDOC = String.Empty
            .AD_FDOC = String.Empty
            .AD_VDOC = String.Empty


            If ganancia_ > 0 Then
                .AD_DEBE = ganancia_
                .AD_HABER = 0
                .AD_MONTO_ORI = 0
            Else
                .AD_DEBE = 0
                .AD_HABER = perdida_
                .AD_MONTO_ORI = 0
            End If

            .AD_PORCE_DESTINO = 0
            .AD_TCAM = 0
            .AD_SEC_ORI_DESTINO = 0
            .AD_GLOSA = str_glosa
            .AD_IDCC = Nothing
            .AD_ES_DESTINO = 0
            .AD_USUARIO = String.Format("{0}-{1}", Environment.UserName, gStr_Usuario_Sis)
            .AD_TERMINAL = Environment.MachineName
            .AD_FECREG = Date.Now
            .AD_IDMEDIOPAGO = Nothing
        End With

        Detalles.Add(E_Detalle)


        'Agregamos la cuenta de diferncia cambiaria ( ganancia o perdida )
        E_Detalle = New BE.ContabilidadBE.SG_CO_TB_ASIENTO_DET()
        With E_Detalle
            .AD_IDCAB = E_Cabecera
            .AD_SECUENCIA = 2
            .AD_TANEXO = Nothing
            .AD_IDANEXO = Nothing
            .AD_TDOC = Nothing
            .AD_SDOC = String.Empty
            .AD_NDOC = String.Empty
            .AD_FDOC = String.Empty
            .AD_VDOC = String.Empty


            If ganancia_ > 0 Then
                .AD_CUENTA = str_cuenta_ganancia
                .AD_DEBE = 0
                .AD_HABER = ganancia_
                .AD_MONTO_ORI = 0
            Else
                .AD_CUENTA = str_cuenta_perdida
                .AD_DEBE = perdida_
                .AD_HABER = 0
                .AD_MONTO_ORI = 0
            End If

            .AD_PORCE_DESTINO = 0
            .AD_TCAM = 0
            .AD_SEC_ORI_DESTINO = 0
            .AD_GLOSA = str_glosa
            .AD_IDCC = Nothing
            .AD_ES_DESTINO = 0
            .AD_USUARIO = String.Format("{0}-{1}", Environment.UserName, gStr_Usuario_Sis)
            .AD_TERMINAL = Environment.MachineName
            .AD_FECREG = Date.Now
            .AD_IDMEDIOPAGO = Nothing
        End With

        Detalles.Add(E_Detalle)


        'grabamos el voucher

        Dim StrVoucher As String = String.Empty
        AsientoBL.Insert_Generales(E_Cabecera, Detalles, StrVoucher, False)

        Call Avisar("Listo!")






    End Sub

    Private Sub Generar_Asiento_Diferencia_Proveedores()

        Dim str_cod_subdiario_dif As String = txt_subdiario.Text.Split("-")(0).Trim


        Dim str_glosa As String = "Por el ajuste de la diferencia de cambio Mensual Proveedores"
        Dim AsientoBL As New BL.ContabilidadBL.SG_CO_TB_ASIENTO_CONTABLE
        Dim E_Cabecera As New BE.ContabilidadBE.SG_CO_TB_ASIENTO_CAB
        Dim Detalles As New List(Of BE.ContabilidadBE.SG_CO_TB_ASIENTO_DET)

        With E_Cabecera
            .AC_ID = 0
            .AC_IDSUBDIARIO = New BE.ContabilidadBE.SG_CO_TB_SUBDIARIO With {.SD_ID = str_cod_subdiario_dif}
            .AC_NUM_VOUCHER = String.Empty
            .AC_ANHO = CDate(udte_fec_Vou.Value).Year
            .AC_MES = CDate(udte_fec_Vou.Value).Month
            .AC_FEC_VOUCHER = CDate(udte_fec_Vou.Value).ToShortDateString
            .AC_IDMONEDA = New BE.ContabilidadBE.SG_CO_TB_MONEDA With {.MO_CODIGO = 1}
            .AC_DEBE = 0
            .AC_HABER = 0
            .AC_TC_OPE = ume_ValorTipoCambio.Value
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

        Dim suma_ganancias As Double = 0
        Dim suma_perdidas As Double = 0

        Dim suma_debe As Double = 0
        Dim suma_haber As Double = 0

        Dim secuencia As Integer = 0

        For i As Integer = 0 To ug_Dif_Prove.Rows.Count - 1

            Dim arr_documento() As String = ug_Dif_Prove.Rows(i).Cells("Documento").Value.ToString.Split("-")

            secuencia += 1

            E_Detalle = New BE.ContabilidadBE.SG_CO_TB_ASIENTO_DET()
            With E_Detalle
                .AD_IDCAB = E_Cabecera
                .AD_SECUENCIA = secuencia
                .AD_CUENTA = ug_Dif_Prove.Rows(i).Cells("Cuenta").Value
                .AD_TANEXO = New BE.ContabilidadBE.SG_CO_TB_TIPOANEXO With {.TA_CODIGO = BE.ContabilidadBE.TipoA.Proveedor}
                .AD_IDANEXO = New BE.ContabilidadBE.SG_CO_TB_ANEXO With {.AN_IDANEXO = ug_Dif_Prove.Rows(i).Cells("AnexoId").Value}
                .AD_TDOC = New BE.ContabilidadBE.SG_CO_TB_DOCUMENTO With {.DO_CODIGO = arr_documento(0).ToString.Trim}
                .AD_SDOC = arr_documento(1).ToString.Trim
                .AD_NDOC = arr_documento(2).ToString.Trim
                .AD_FDOC = String.Empty
                .AD_VDOC = String.Empty


                If ug_Dif_Prove.Rows(i).Cells("Ganancia").Value > 0 Then
                    .AD_DEBE = ug_Dif_Prove.Rows(i).Cells("Ganancia").Value
                    .AD_HABER = 0
                    .AD_MONTO_ORI = ug_Dif_Prove.Rows(i).Cells("Ganancia").Value
                    suma_ganancias += Math.Round(ug_Dif_Prove.Rows(i).Cells("Ganancia").Value, 2)
                Else
                    .AD_DEBE = 0
                    .AD_HABER = ug_Dif_Prove.Rows(i).Cells("Perdida").Value
                    .AD_MONTO_ORI = ug_Dif_Prove.Rows(i).Cells("Perdida").Value
                    suma_perdidas += Math.Round(ug_Dif_Prove.Rows(i).Cells("Perdida").Value, 2)
                End If

                .AD_PORCE_DESTINO = 0
                .AD_TCAM = 0
                .AD_SEC_ORI_DESTINO = 0
                .AD_GLOSA = str_glosa
                .AD_IDCC = Nothing
                .AD_ES_DESTINO = 0
                .AD_USUARIO = String.Format("{0}-{1}", Environment.UserName, gStr_Usuario_Sis)
                .AD_TERMINAL = Environment.MachineName
                .AD_FECREG = Date.Now
                .AD_IDMEDIOPAGO = Nothing



                suma_debe += .AD_DEBE
                suma_haber += .AD_HABER

            End With

            Detalles.Add(E_Detalle)



        Next



        secuencia += 1

        'AGREGAMOS LA CUENTA DE DIFERENCIA CAMBIARIA POR PERDIDA 
        E_Detalle = New BE.ContabilidadBE.SG_CO_TB_ASIENTO_DET()
        With E_Detalle
            .AD_IDCAB = E_Cabecera
            .AD_SECUENCIA = secuencia
            .AD_TANEXO = Nothing
            .AD_IDANEXO = Nothing
            .AD_TDOC = Nothing
            .AD_SDOC = String.Empty
            .AD_NDOC = String.Empty
            .AD_FDOC = String.Empty
            .AD_VDOC = String.Empty
            .AD_CUENTA = str_cuenta_perdida

            .AD_DEBE = suma_perdidas
            .AD_HABER = 0
            .AD_MONTO_ORI = suma_perdidas

            .AD_PORCE_DESTINO = 0
            .AD_TCAM = 0
            .AD_SEC_ORI_DESTINO = 0
            .AD_GLOSA = str_glosa
            .AD_IDCC = Nothing
            .AD_ES_DESTINO = 0
            .AD_USUARIO = String.Format("{0}-{1}", Environment.UserName, gStr_Usuario_Sis)
            .AD_TERMINAL = Environment.MachineName
            .AD_FECREG = Date.Now
            .AD_IDMEDIOPAGO = Nothing

            suma_debe += .AD_DEBE
            suma_haber += .AD_HABER


        End With

        Detalles.Add(E_Detalle)


        secuencia += 1
        'AGREGAMOS LA CUENTA DE DIFERENCIA CAMBIARIA POR GANANCIA 
        E_Detalle = New BE.ContabilidadBE.SG_CO_TB_ASIENTO_DET()
        With E_Detalle
            .AD_IDCAB = E_Cabecera
            .AD_SECUENCIA = secuencia
            .AD_TANEXO = Nothing
            .AD_IDANEXO = Nothing
            .AD_TDOC = Nothing
            .AD_SDOC = String.Empty
            .AD_NDOC = String.Empty
            .AD_FDOC = String.Empty
            .AD_VDOC = String.Empty
            .AD_CUENTA = str_cuenta_ganancia

            .AD_DEBE = 0
            .AD_HABER = suma_ganancias
            .AD_MONTO_ORI = suma_ganancias

            .AD_PORCE_DESTINO = 0
            .AD_TCAM = 0
            .AD_SEC_ORI_DESTINO = 0
            .AD_GLOSA = str_glosa
            .AD_IDCC = Nothing
            .AD_ES_DESTINO = 0
            .AD_USUARIO = String.Format("{0}-{1}", Environment.UserName, gStr_Usuario_Sis)
            .AD_TERMINAL = Environment.MachineName
            .AD_FECREG = Date.Now
            .AD_IDMEDIOPAGO = Nothing

            suma_debe += .AD_DEBE
            suma_haber += .AD_HABER

        End With

        Detalles.Add(E_Detalle)


        E_Cabecera.AC_DEBE = suma_debe
        E_Cabecera.AC_HABER = suma_haber



        'grabamos el voucher

        Dim StrVoucher As String = String.Empty
        AsientoBL.Insert_Generales(E_Cabecera, Detalles, StrVoucher, False)

        Call Avisar("Listo!" & Chr(13) & "Se genero el voucher : " & StrVoucher & Chr(13) & "en el libro : Generales " & Chr(13) & "Subdiario : " & txt_subdiario.Text)


    End Sub

    Private Sub Tool_Salir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_Salir.Click
        Me.Close()
    End Sub

    Private Sub uos_tipo_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles uos_tipo.ValueChanged

        Select Case uos_tipo.Value
            Case 1 'ctas ctes
                ug_Dif_Prove.Visible = False
                ug_resultado_bancos.Visible = True
            Case 2 'proveedores
                ug_Dif_Prove.Visible = True
                ug_resultado_bancos.Visible = False
        End Select


    End Sub
End Class