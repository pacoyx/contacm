Public Class PL_PR_Contabilizacion
    Dim dt_cuenta_importe As DataTable = Nothing
    Dim dt_ctas_destino As DataTable = Nothing
    Dim dt_afp As DataTable = Nothing
    Dim dt_PlanCtas As DataTable = Nothing

    Private Sub PL_PR_Contabilizacion_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        une_Ayo.Value = gDat_Fecha_Sis.Year

        Call CargarCombo_ConMeses(uce_Mes)
        Call Formatear_Grilla_Selector(ug_asiento)
        Call Cargar_TipoPersonal()
        Call Cargar_Tmp_Afp()
        Call Cargar_PlanCtas()
        Call Cargar_Ctas_Destino()


        'inicializamos controles
        Me.Width = 552
        uce_Mes.SelectedIndex = -1
        uce_TipoPersonal.SelectedIndex = 0

    End Sub

    Private Sub Cargar_Ctas_Destino()
        Dim historialBL As New BL.PlanillaBL.SG_PL_TB_HISTORIAL
        dt_ctas_destino = historialBL.get_Todas_Cuentas_Destino(une_Ayo.Value, gInt_IdEmpresa)
        historialBL = Nothing
    End Sub

    Private Sub Cargar_PlanCtas()
        Dim planctasBL As New BL.ContabilidadBL.SG_CO_TB_PLANCTAS
        Dim planctasBE As New BE.ContabilidadBE.SG_CO_TB_PLANCTAS
        planctasBE.PC_IDEMPRESA = New BE.ContabilidadBE.SG_CO_TB_EMPRESA With {.EM_ID = gInt_IdEmpresa}
        planctasBE.PC_PERIODO = une_Ayo.Value
        dt_PlanCtas = planctasBL.getCuentas_Manejan_Anexo(planctasBE)
        planctasBE = Nothing
        planctasBL = Nothing
    End Sub

    Private Sub Cargar_Tmp_Afp()
        Dim afpBL As New BL.PlanillaBL.SG_PL_TB_AFP
        dt_afp = afpBL.getAfp(New BE.ContabilidadBE.SG_CO_TB_EMPRESA With {.EM_ID = gInt_IdEmpresa})
        afpBL = Nothing

    End Sub

    Private Sub Cargar_TipoPersonal()
        Dim tipoPersonalBL As New BL.PlanillaBL.SG_PL_TB_TIPO_PERSONAL
        uce_TipoPersonal.DataSource = tipoPersonalBL.getTipos()
        uce_TipoPersonal.ValueMember = "TP_ID"
        uce_TipoPersonal.DisplayMember = "TP_DESCRIPCION"
        tipoPersonalBL = Nothing
    End Sub

    Private Sub Tool_Aceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_Aceptar.Click

        If uce_Mes.SelectedIndex = -1 Then
            Avisar("Seleccione un Mes")
            uce_Mes.Focus()
            Exit Sub
        End If

        Dim historialBL As New BL.PlanillaBL.SG_PL_TB_HISTORIAL

        'If historialBL.Existe_Asiento_Planilla(une_ayo.Value, uce_Mes.Value, IIf(uce_TipoPersonal.Value = 1, IIf(gInt_IdEmpresa = 7, "07", "10"), "15"), gInt_IdEmpresa) Then
        '    If Preguntar("Ya existe un asiento de Planillas en el periodo : " & uce_Mes.Text & "/" & une_ayo.Text & Chr(13) _
        '                  & "Desea Continuar? ") Then
        '        historialBL.Delete_Asiento_Planilla(une_ayo.Value, uce_Mes.Value, IIf(uce_TipoPersonal.Value = 1, "10", "15"), gInt_IdEmpresa)
        '    Else
        '        Exit Sub
        '    End If
        'End If


        Call Crear_Tabla_temporal()


        Dim conceptoBL As New BL.PlanillaBL.SG_PL_TB_CONCEPTOS

        Dim dt_conceptos As DataTable = conceptoBL.get_Conceptos(New BE.ContabilidadBE.SG_CO_TB_EMPRESA With {.EM_ID = gInt_IdEmpresa})
        Dim dt_perso As DataTable = historialBL.get_Personal_Planilla(une_Ayo.Value, uce_Mes.Value, gInt_IdEmpresa, uce_TipoPersonal.Value)

        Dim dt_cc_perso As DataTable = Nothing 'Tabla => SG_PL_TB_PERSONAL_CCOSTO
        Dim dt_boleta As DataTable = Nothing
        Dim id_persona As Integer = 0
        Dim id_AnexoConta As Integer = 0
        Dim str_Nom_Per As String = String.Empty
        Dim id_afp As Integer = 0
        Dim monto_tmp As Double = 0
        Dim monto_tmp_Concepto As Double = 0
        Dim str_dh As String = ""
        Dim str_cta_conta As String = ""
        Dim cta_60 As String = String.Empty
        Dim bol_esAfp As Boolean = False
        Dim bol_salto As Boolean = False




        Me.Refresh()

        Me.Cursor = Cursors.WaitCursor

        upg_1.Value = 0
        upg_1.Minimum = 0
        upg_1.Maximum = dt_perso.Rows.Count

        For i As Integer = 0 To dt_perso.Rows.Count - 1

            id_persona = dt_perso.Rows(i)("PE_ID")
            id_afp = Val(dt_perso.Rows(i)("PE_ID_AFP").ToString)
            id_AnexoConta = Val(dt_perso.Rows(i)("PE_ID_ANEXO_CONTA").ToString)
            str_Nom_Per = dt_perso.Rows(i)("NOMBRE").ToString.Trim
            dt_cc_perso = historialBL.get_CentroCosto_x_Persona(id_persona)
            dt_boleta = historialBL.get_Boleta_x_Persona(une_Ayo.Value, uce_Mes.Value, gInt_IdEmpresa, id_persona)



            Dim fila_concepto() As DataRow
            For j As Integer = 0 To dt_boleta.Rows.Count - 1

                'If dt_boleta(j)("HI_COD_HD") = "111" Then
                '    'Avisar("llego")
                'End If

                fila_concepto = dt_conceptos.Select("co_id = '" & dt_boleta(j)("HI_COD_HD").ToString & "'")
                str_dh = ""
                bol_esAfp = IIf(fila_concepto(0)("CO_ES_AFP") = 1, True, False)

                If fila_concepto(0)("CO_ID_CUENTA_D").ToString.Length > 3 Then
                    str_dh = "D"
                    cta_60 = fila_concepto(0)("CO_ID_CUENTA_D").ToString

Inicio:

                    monto_tmp_Concepto = dt_boleta(j)("HI_MONTO")
                    If bol_esAfp Then
                        Dim dr_fila_afp() As DataRow
                        dr_fila_afp = dt_afp.Select("AF_ID = " & id_afp)
                        If dr_fila_afp.Length > 0 Then Call Ins_Fila("AFP_" & id_afp, dr_fila_afp(0)("AF_IDCUENTA_CONTA"), monto_tmp_Concepto, str_dh, id_persona, id_AnexoConta, fila_concepto(0)("CO_ID"), str_Nom_Per, )
                        dr_fila_afp = Nothing
                    Else
                        Call Ins_Fila("00", cta_60, monto_tmp_Concepto, str_dh, id_persona, id_AnexoConta, fila_concepto(0)("CO_ID"), str_Nom_Per)
                    End If

                    Dim importe79 As Double = 0
                    monto_tmp = 0
                    Dim ls_cta_des As List(Of String)
                    For k As Integer = 0 To dt_cc_perso.Rows.Count - 1
                        If cta_60 <> "" Then
                            ls_cta_des = get_cta_destino(cta_60, dt_cc_perso(k)("CC_CC"))
                            If ls_cta_des.Count > 0 Then

                                monto_tmp = (monto_tmp_Concepto * dt_cc_perso(k)("CC_PORCENTAJE")) / 100
                                monto_tmp = Math.Round(monto_tmp, 2)

                                If k = dt_cc_perso.Rows.Count - 1 Then
                                    If Math.Round((importe79 + monto_tmp), 2) <> Math.Round(monto_tmp_Concepto, 2) Then
                                        monto_tmp = monto_tmp + Math.Round(monto_tmp_Concepto - (importe79 + monto_tmp), 2)
                                    End If
                                End If

                                monto_tmp = Math.Round(monto_tmp, 2)
                                
                                Call Ins_Fila(dt_cc_perso(k)("CC_CC"), ls_cta_des(0), monto_tmp, ls_cta_des(1), id_persona, id_AnexoConta, fila_concepto(0)("CO_ID"), str_Nom_Per, "1")
                                importe79 += monto_tmp
                            End If
                        End If
                    Next

                    importe79 = Math.Round(importe79, 2)
                    If importe79 > 0 Then
                        Call Ins_Fila(cta_60, "791101", importe79, "H", id_persona, id_AnexoConta, fila_concepto(0)("CO_ID"), str_Nom_Per, "1")
                    End If

                    If bol_salto Then
                        bol_salto = Not bol_salto
                        GoTo siguiente
                    End If

                End If


                If fila_concepto(0)("CO_ID_CUENTA_H").ToString.Length > 3 Then
                    str_dh = "H"
                    cta_60 = fila_concepto(0)("CO_ID_CUENTA_H").ToString
                    bol_salto = Not bol_salto
                    GoTo Inicio
                End If

siguiente:

            Next
            upg_1.IncrementValue(1)
        Next

        Call Ins_Fila_Difer_Haber_Descto()
        upg_1.Value = 0


        t1.Text = dt_cuenta_importe.Compute("sum(Debe)", "")
        t2.Text = dt_cuenta_importe.Compute("sum(haber)", "")
        txt_diferencia.Text = CDbl(t1.Text) - CDbl(t2.Text)

        Call Ordenar_Asiento()
        Call Generar_Asiento()


        Me.Refresh()

        Me.Cursor = Cursors.Default

    End Sub

    Private Sub Generar_Asiento()

        Dim str_cod_subdiario As String = String.Empty
        Dim AsientoBL As New BL.ContabilidadBL.SG_CO_TB_ASIENTO_CONTABLE
        Dim E_Cabecera As New BE.ContabilidadBE.SG_CO_TB_ASIENTO_CAB
        Dim Detalles As New List(Of BE.ContabilidadBE.SG_CO_TB_ASIENTO_DET)


        Select Case gInt_IdEmpresa
            Case 7 'botica
                If uce_TipoPersonal.Value = 1 Then str_cod_subdiario = "07"
                If uce_TipoPersonal.Value = 2 Then str_cod_subdiario = "15"
            Case Else
                If uce_TipoPersonal.Value = 1 Then str_cod_subdiario = "10"
                If uce_TipoPersonal.Value = 2 Then str_cod_subdiario = "15"
        End Select

        

        Dim fecha_voucher As Date = CDate(ume_fec_vou.Value)
        Dim ayo As Integer = fecha_voucher.Year
        Dim mes As Integer = fecha_voucher.Month

        With E_Cabecera
            .AC_ID = 0
            .AC_IDSUBDIARIO = New BE.ContabilidadBE.SG_CO_TB_SUBDIARIO With {.SD_ID = str_cod_subdiario}
            .AC_NUM_VOUCHER = ""
            .AC_ANHO = ayo
            .AC_MES = mes
            .AC_FEC_VOUCHER = fecha_voucher
            .AC_IDMONEDA = New BE.ContabilidadBE.SG_CO_TB_MONEDA With {.MO_CODIGO = 1}
            .AC_DEBE = t1.Value
            .AC_HABER = t2.Value
            .AC_TC_OPE = 0
            .AC_TC_ESPECIAL = 0
            .AC_ESTADO = 1
            .AC_GLOSA_VOU = "Planilla de Sueldos Periodo " & mes.ToString.PadLeft(2, "0") & "-" & ayo.ToString
            .AC_ES_INTERFACE = 0
            .AC_TC_FORMATO = New BE.ContabilidadBE.SG_CO_TB_FORM_TIPCAMB With {.FT_CODIGO = 2}
            .AC_USUARIO = String.Format("{0}-{1}", Environment.UserName, gStr_Usuario_Sis)
            .AC_TERMINAL = Environment.MachineName
            .AC_FECREG = Date.Now
            .AC_IDEMPRESA = New BE.ContabilidadBE.SG_CO_TB_EMPRESA With {.EM_ID = gInt_IdEmpresa}
        End With


        Dim E_Detalle As BE.ContabilidadBE.SG_CO_TB_ASIENTO_DET
        For i As Integer = 0 To ug_asiento.Rows.Count - 1

            E_Detalle = New BE.ContabilidadBE.SG_CO_TB_ASIENTO_DET()

            With E_Detalle
                .AD_IDCAB = E_Cabecera
                .AD_SECUENCIA = i + 1 'ug_asiento.Rows(i).Cells("Item").Value.ToString
                .AD_CUENTA = ug_asiento.Rows(i).Cells("Cuenta").Value.ToString

                If ug_asiento.Rows(i).Cells("TipoAnexo").Value.ToString.Equals(String.Empty) Then
                    .AD_TANEXO = Nothing
                Else
                    .AD_TANEXO = New BE.ContabilidadBE.SG_CO_TB_TIPOANEXO With {.TA_CODIGO = ug_asiento.Rows(i).Cells("TipoAnexo").Value}
                End If

                If ug_asiento.Rows(i).Cells("Anexo").Value.ToString.Equals(String.Empty) Then
                    .AD_IDANEXO = Nothing
                Else
                    .AD_IDANEXO = New BE.ContabilidadBE.SG_CO_TB_ANEXO With {.AN_IDANEXO = ug_asiento.Rows(i).Cells("Anexo").Value.ToString}
                End If

                If ug_asiento.Rows(i).Cells("td").Value.ToString.Equals(String.Empty) Then
                    .AD_TDOC = Nothing
                Else
                    .AD_TDOC = New BE.ContabilidadBE.SG_CO_TB_DOCUMENTO With {.DO_CODIGO = ug_asiento.Rows(i).Cells("td").Value.ToString}
                End If

                .AD_SDOC = ug_asiento.Rows(i).Cells("sd").Value.ToString
                .AD_NDOC = ug_asiento.Rows(i).Cells("nd").Value.ToString
                .AD_FDOC = fecha_voucher.ToShortDateString
                .AD_VDOC = fecha_voucher.ToShortDateString


                .AD_DEBE = IIf(ug_asiento.Rows(i).Cells("Debe").Value.ToString = String.Empty, 0, ug_asiento.Rows(i).Cells("Debe").Value)
                .AD_HABER = IIf(ug_asiento.Rows(i).Cells("Haber").Value.ToString = String.Empty, 0, ug_asiento.Rows(i).Cells("Haber").Value)
                .AD_DEBE = Format(.AD_DEBE, "#.000")
                .AD_HABER = Format(.AD_HABER, "#.000")

                .AD_MONTO_ORI = .AD_DEBE + .AD_HABER
                .AD_PORCE_DESTINO = 0
                .AD_TCAM = 0
                .AD_SEC_ORI_DESTINO = 0
                .AD_GLOSA = ug_asiento.Rows(i).Cells("Glosa").Value.ToString
                .AD_IDCC = New BE.ContabilidadBE.SG_CO_TB_CENTROCOSTO With {.CC_CODIGO = 0}
                .AD_ES_DESTINO = IIf(ug_asiento.Rows(i).Cells("EsDestino").Value.ToString = String.Empty, 0, ug_asiento.Rows(i).Cells("EsDestino").Value)
                .AD_USUARIO = String.Format("{0}-{1}", Environment.UserName, gStr_Usuario_Sis)
                .AD_TERMINAL = Environment.MachineName
                .AD_FECREG = Date.Now
                .AD_IDMEDIOPAGO = Nothing

            End With
            Detalles.Add(E_Detalle)
        Next

        Dim StrVoucher As String = String.Empty
        AsientoBL.Insert_Generales(E_Cabecera, Detalles, StrVoucher, False)
        Call Avisar("Listo!" & Chr(13) & "Se genero el voucher : " & StrVoucher)



    End Sub

    Private Sub Ordenar_Asiento()

        Dim dt_ordenado As New DataTable
        Dim filas697 As DataRow()
        Dim filas1 As DataRow()
        Dim filas4 As DataRow()

        dt_ordenado = dt_cuenta_importe.Clone

        filas697 = dt_cuenta_importe.Select("Cuenta like '6%' or Cuenta like '9%' or Cuenta like '7%'", "Item")
        filas1 = dt_cuenta_importe.Select("Cuenta like '1%'")
        filas4 = dt_cuenta_importe.Select("Cuenta like '4%'")


        For Each fila_tmp As DataRow In filas697
            dt_ordenado.ImportRow(fila_tmp)
        Next

        For Each fila_tmp As DataRow In filas1
            dt_ordenado.ImportRow(fila_tmp)
        Next

        For Each fila_tmp As DataRow In filas4
            dt_ordenado.ImportRow(fila_tmp)
        Next

        ug_asiento.DataSource = dt_ordenado



    End Sub

    Public Function get_cta_destino(ByVal cta6_ As String, ByVal cta9_ As String) As List(Of String)
        'Dim historialBL As New BL.PlanillaBL.SG_PL_TB_HISTORIAL
        'Return historialBL.get_Info_CtaDestino(cta6_, cta9_, une_Ayo.Value, gInt_IdEmpresa)
        'historialBL = Nothing
        Dim ls_tmp As New List(Of String)
        Dim fila_tmp() As DataRow
        fila_tmp = dt_ctas_destino.Select("PC_NUM_CUENTA = '" & cta6_ & "'")

        ls_tmp.Clear()
        For i As Integer = 0 To fila_tmp.Length - 1
            If LSet(fila_tmp(i)("CD_CTA_DESTINO"), cta9_.Length).Equals(cta9_) Then
                ls_tmp.Add(fila_tmp(i)("CD_CTA_DESTINO"))
                ls_tmp.Add(fila_tmp(i)("CD_DH"))
            End If
            If fila_tmp(i)("CD_DH") = "H" Then
                ls_tmp.Add(fila_tmp(i)("CD_CTA_DESTINO"))
                ls_tmp.Add(fila_tmp(i)("CD_DH"))
            End If
        Next

        Return ls_tmp

    End Function

    Private Sub Tool_Salir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_Salir.Click
        Me.Close()
    End Sub

    Private Sub Crear_Tabla_temporal()
        dt_cuenta_importe = New DataTable
        dt_cuenta_importe.Columns.Clear()
        dt_cuenta_importe.Columns.Add("Item", Type.GetType("System.Int32"))
        dt_cuenta_importe.Columns.Add("CC", Type.GetType("System.String"))
        dt_cuenta_importe.Columns.Add("Cuenta", Type.GetType("System.String"))
        dt_cuenta_importe.Columns.Add("DH", Type.GetType("System.String"))
        dt_cuenta_importe.Columns.Add("Debe", Type.GetType("System.Double"))
        dt_cuenta_importe.Columns.Add("Haber", Type.GetType("System.Double"))
        dt_cuenta_importe.Columns.Add("Anexo", Type.GetType("System.String"))
        dt_cuenta_importe.Columns.Add("TipoAnexo", Type.GetType("System.String"))
        dt_cuenta_importe.Columns.Add("td", Type.GetType("System.String"))
        dt_cuenta_importe.Columns.Add("sd", Type.GetType("System.String"))
        dt_cuenta_importe.Columns.Add("nd", Type.GetType("System.String"))
        dt_cuenta_importe.Columns.Add("glosa", Type.GetType("System.String"))
        dt_cuenta_importe.Columns.Add("EsDestino", Type.GetType("System.String"))
    End Sub

    Private Sub Ins_Fila(ByVal cc_ As String, ByVal cta_ As String, ByVal imp_ As Double, ByVal dh_ As String, id_personal As Integer, idanexoConta_ As Integer, concepto_ As String, nombre_per_ As String, Optional esDestino_ As String = "")
        Dim filita() As DataRow
        Dim hasAnexo As Boolean = False
        Dim int_tipoAnexo As Integer = 0
        Dim int_anexo_boleta As Integer = 295

        Select Case gInt_IdEmpresa
            Case 1 'clinica
                int_anexo_boleta = 295
            Case 2 'fertifarm
                int_anexo_boleta = 295
            Case 3 'ginefert
                int_anexo_boleta = 7469
            Case 4 'gestar
                int_anexo_boleta = 7308
            Case 5 'gyf
                int_anexo_boleta = 7616
            Case 6 'ecogest
                int_anexo_boleta = 7820
            Case 7 'botica igfarma
                int_anexo_boleta = 6064

        End Select




        If TieneAnexo(cta_, int_tipoAnexo) Then
            filita = dt_cuenta_importe.Select("Cuenta = '" & cta_ & "' and DH = '" & dh_ & "' and cc = '" & cc_ & "' and anexo = '" & idanexoConta_.ToString & "'")
            hasAnexo = Not hasAnexo
        Else
            filita = dt_cuenta_importe.Select("Cuenta = '" & cta_ & "' and DH = '" & dh_ & "' and cc = '" & cc_ & "'")
        End If


        If filita.Length > 0 Then
            If dh_ = "D" Then filita(0)("Debe") = filita(0)("Debe") + imp_
            If dh_ = "H" Then filita(0)("Haber") = filita(0)("Haber") + imp_
        Else
            Dim fila As DataRow
            fila = dt_cuenta_importe.NewRow
            fila("Item") = dt_cuenta_importe.Rows.Count + 1
            fila("CC") = cc_
            fila("Cuenta") = cta_
            fila("DH") = dh_
            fila("Anexo") = ""
            fila("td") = ""
            fila("sd") = ""
            fila("nd") = ""

            Dim planctasBL As New BL.ContabilidadBL.SG_CO_TB_PLANCTAS
            Dim planctasBE As New BE.ContabilidadBE.SG_CO_TB_PLANCTAS

            planctasBE.PC_PERIODO = une_ayo.Value
            planctasBE.PC_NUM_CUENTA = cta_
            planctasBE.PC_IDEMPRESA = New BE.ContabilidadBE.SG_CO_TB_EMPRESA With {.EM_ID = gInt_IdEmpresa}

            planctasBL.getCuenta_X_NumeroCta(planctasBE)


            If esDestino_ = "1" Then
                Dim ccBL As New BL.ContabilidadBL.SG_CO_TB_CENTROCOSTO
                Dim ccBE As New BE.ContabilidadBE.SG_CO_TB_CENTROCOSTO

                ccBE.CC_CODIGO = cc_
                ccBE.CC_IDEMPRESA = New BE.ContabilidadBE.SG_CO_TB_EMPRESA With {.EM_ID = gInt_IdEmpresa}

                fila("glosa") = planctasBE.PC_DESCRIPCION & " " & ccBL.getCentroCostos_x_Id(ccBE).ToString

                ccBE = Nothing
                ccBL = Nothing

            Else
                fila("glosa") = planctasBE.PC_DESCRIPCION
            End If



            planctasBE = Nothing
            planctasBL = Nothing



            fila("TipoAnexo") = ""
            fila("EsDestino") = ""
            If esDestino_ <> "" Then fila("EsDestino") = esDestino_


            If hasAnexo Then

                Select Case int_tipoAnexo
                    Case 1 'clientes
                        fila("TipoAnexo") = int_tipoAnexo
                        fila("Anexo") = int_anexo_boleta

                        Dim ls_datos As List(Of String) = get_Comprobante_deFolio(concepto_, id_personal, une_ayo.Value, uce_Mes.Value)
                        If ls_datos.Count > 0 Then
                            fila("td") = ls_datos(0)
                            fila("sd") = ls_datos(1)
                            fila("nd") = ls_datos(2)
                            fila("glosa") = nombre_per_
                        End If
                        ls_datos = Nothing

                    Case 3 'personal
                        fila("TipoAnexo") = int_tipoAnexo
                        fila("Anexo") = idanexoConta_
                        fila("glosa") = nombre_per_
                End Select
            End If

            If dh_ = "D" Then fila("Debe") = imp_ Else fila("Debe") = 0
            If dh_ = "H" Then fila("Haber") = imp_ Else fila("Haber") = 0

            dt_cuenta_importe.Rows.Add(fila)
        End If
    End Sub

    Private Function TieneAnexo(cta_ As String, ByRef TipoAnexo As Integer) As Boolean
        Dim rpta As Boolean = False
        Dim fila_tmp() As DataRow
        fila_tmp = dt_PlanCtas.Select("pc_num_cuenta = '" & cta_ & "'")
        If fila_tmp.Length > 0 Then
            TipoAnexo = fila_tmp(0)("PC_IDTIPO_ANEXO")
            rpta = Not rpta
        End If

        Return rpta
    End Function

    Private Function get_Comprobante_deFolio(str_idfolio As String, int_idpersonal As Integer, int_ayo As Integer, int_mes As Integer) As List(Of String)
        Dim ls_compro As New List(Of String)

        Dim dt_tmp As DataTable = Nothing
        Dim comprobanteBL As New BL.PlanillaBL.SG_PL_TB_FOLIO_DOC_COMPRO
        Dim comprobanteBE As New BE.PlanillaBE.SG_PL_TB_FOLIO_DOC_COMPRO
        comprobanteBE.FC_IDFOLIO = str_idfolio
        comprobanteBE.FC_IDPERSONAL = int_idpersonal
        comprobanteBE.FC_ANHO = int_ayo
        comprobanteBE.FC_MES = int_mes
        comprobanteBE.FC_IDEMPRESA = gInt_IdEmpresa
        dt_tmp = comprobanteBL.get_Info_Trabajador(comprobanteBE)
        If dt_tmp.Rows.Count > 0 Then
            ls_compro.Add(dt_tmp(0)("FC_TDOC"))
            ls_compro.Add(dt_tmp(0)("FC_SDOC"))
            ls_compro.Add(dt_tmp(0)("FC_NDOC"))
        End If

        dt_tmp.Dispose()
        comprobanteBE = Nothing
        comprobanteBL = Nothing

        Return ls_compro
    End Function

    Private Sub Ins_Fila_Difer_Haber_Descto()
        Dim importe As Double = 0
        Dim historialBL As New BL.PlanillaBL.SG_PL_TB_HISTORIAL
        importe = historialBL.get_Dif_Haber_Descto(une_Ayo.Value, uce_Mes.Value, uce_TipoPersonal.Value, gInt_IdEmpresa)

        Dim fila As DataRow
        fila = dt_cuenta_importe.NewRow
        fila("Item") = dt_cuenta_importe.Rows.Count - 1
        fila("CC") = ""
        fila("Cuenta") = "411101"
        fila("DH") = "H"
        fila("Debe") = 0
        fila("Haber") = importe

        Dim planctasBL As New BL.ContabilidadBL.SG_CO_TB_PLANCTAS
        Dim planctasBE As New BE.ContabilidadBE.SG_CO_TB_PLANCTAS

        planctasBE.PC_PERIODO = une_ayo.Value
        planctasBE.PC_NUM_CUENTA = "411101"
        planctasBE.PC_IDEMPRESA = New BE.ContabilidadBE.SG_CO_TB_EMPRESA With {.EM_ID = gInt_IdEmpresa}
        planctasBL.getCuenta_X_NumeroCta(planctasBE)

        fila("glosa") = planctasBE.PC_DESCRIPCION

        planctasBE = Nothing
        planctasBL = Nothing

        dt_cuenta_importe.Rows.Add(fila)

        historialBL = Nothing

    End Sub

    Private Sub ToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim facturasBL As New BL.ContabilidadBL.Migrador
        'facturasBL.Migrar_Asiento_Ventas_Sisa(2012, 6, "121201", "131251", "401111")
    End Sub

    Private Sub ToolStripButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim facturasBL As New BL.ContabilidadBL.Migrador
        'facturasBL.Migrar_Asiento_Ventas_Sisa_Botica(2012, 6, "121201", "131251", "401111")
    End Sub

    Private Sub ToolStripButton3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim facturasBL As New BL.ContabilidadBL.Migrador
        'facturasBL.Migrar_Asiento_Compras_Sisa_Clinica(6)
    End Sub

    Private Sub uce_TipoPersonal_ValueChanged(sender As System.Object, e As System.EventArgs) Handles uce_TipoPersonal.ValueChanged
        Select Case uce_TipoPersonal.Value
            Case 1
                If gInt_IdEmpresa = 7 Then
                    txt_Subdiario.Text = "07 - PLANILLAS"
                Else
                    txt_Subdiario.Text = "10 - PLANILLAS"
                End If

            Case 2
                txt_Subdiario.Text = "15 -PLANILLAS POR HORAS - TIEMPO PARCIAL"
        End Select
    End Sub

    Private Sub uce_Mes_ValueChanged(sender As System.Object, e As System.EventArgs) Handles uce_Mes.ValueChanged
        Dim fcha As Date = "01/" & uce_Mes.Value & "/" & une_ayo.Text
        ume_fec_vou.Value = (ObtenerUltimoDia(fcha))
    End Sub
End Class