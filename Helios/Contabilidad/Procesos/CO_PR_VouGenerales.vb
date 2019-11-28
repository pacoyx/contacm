Imports BE.ContabilidadBE

Public Class CO_PR_VouGenerales
    Dim Obj_Voucher As New BL.ContabilidadBL.SG_CO_TB_ASIENTO_CONTABLE
    Dim Str_Mon_Nac As Integer = 1
    Dim Bol_NuevoDet As Boolean
    Dim Bol_Edicion As Boolean = False
    Dim Bol_Copy As Boolean = False
    Dim Int_IdCab_Edit As Integer = 0
    Dim BYTFormatContable As Integer = 2
    Dim Int_TipoAnexo As Integer = 0
    Dim ListaDocPendiente As New List(Of Cls_DocPendientes)
    Dim Bol_Insertar_Detalle_Medio As Boolean = False
    Dim Int_Posicion_fila_Insertar As Integer = 0

    Private Sub CO_PR_VouGenerales_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Dim Bol_EstaCerrado As Boolean = False
        Call Verificar_Mes_Cerrado(Me, gDat_Fecha_Sis.Year, gDat_Fecha_Sis.Month, Bol_EstaCerrado)

        If Not Bol_EstaCerrado Then
            Call Cargar_Cmb_SubDiario()
            Call Cargar_Cmb_Monedas()
            Call Cargar_Documentos()
            Call Cargar_TipoCambioFormato()
            Call Limpiar_Controls_InGroupox(ugb_Cabecera)
            Call Cargar_Cuentas_Combo()
            Call Cargar_MedioPago()
            Call Cargar_Combo_CC()
            Call Iniciar_Formulario()
            Call Formatear_Grilla_Selector(ug_asiento)
            Call Ocultar_Columnas(True)
            Call MostrarTabs(0, utc_Asiento, 0)
            Call Cargar_Imagenes_a_Botones()
            ugb_detalle.Visible = False
            utc_Asiento.Height = 365
        End If
        ubtn_Salir.Enabled = True

    End Sub

    Private Sub Cargar_Imagenes_a_Botones()
        ubtn_CrearAnexo.Appearance.Image = My.Resources.User_01_48x48_32
        btn_Nuevo.Appearance.Image = My.Resources._16__File_new_2_
        btn_GrabarDet.Appearance.Image = My.Resources._16__Ok_
        btn_CancelarDet.Appearance.Image = My.Resources._16__Cancel_
        ubtn_GrabarVoucher.Appearance.Image = My.Resources._003
        ubtn_Cancelar.Appearance.Image = My.Resources._16__Cancel_
        ubtn_Salir.Appearance.Image = My.Resources._28
        ubtn_GrabarVoucher.Appearance.Image = My.Resources._003
        'txt_Glosa.ButtonsRight(0).Appearance.Image = My.Resources._16__Fill_left_
        txt_Anexo_Det.ButtonsRight(0).Appearance.Image = My.Resources._104


    End Sub

    Private Sub Cargar_Combo_CC()
        Dim ccostoBL As New BL.ContabilidadBL.SG_CO_TB_CENTROCOSTO
        Dim ccostoBE As New BE.ContabilidadBE.SG_CO_TB_CENTROCOSTO
        ccostoBE.CC_IDEMPRESA = New BE.ContabilidadBE.SG_CO_TB_EMPRESA With {.EM_ID = gInt_IdEmpresa}
        uce_cc.DataSource = ccostoBL.getCentroCostos_cmb(ccostoBE)
        uce_cc.DisplayMember = "CC_DESCRIPCION"
        uce_cc.ValueMember = "CC_CODIGO"

        ccostoBE = Nothing
        ccostoBL = Nothing

    End Sub

    Public Sub Cargar_MedioPago()
        Dim MedioBL As New BL.ContabilidadBL.SG_CO_TB_MEDIOPAGO

        uce_MedioPago.DataSource = MedioBL.getMedios
        uce_MedioPago.DisplayMember = "MP_DESCRIPCION"
        uce_MedioPago.ValueMember = "MP_CODIGO"

    End Sub

    Public Sub Ocultar_Columnas(ByVal Ocultar As Boolean)

        ug_asiento.DisplayLayout.Bands(0).Columns("Fecha Emi").Hidden = Ocultar
        ug_asiento.DisplayLayout.Bands(0).Columns("Fecha ven").Hidden = Ocultar
        ug_asiento.DisplayLayout.Bands(0).Columns("Tip_Doc").Hidden = Ocultar
        ug_asiento.DisplayLayout.Bands(0).Columns("Serie").Hidden = Ocultar
        ug_asiento.DisplayLayout.Bands(0).Columns("Numero").Hidden = Ocultar
        ug_asiento.DisplayLayout.Bands(0).Columns("TipoCam").Hidden = Ocultar
        ug_asiento.DisplayLayout.Bands(0).Columns("Soles").Hidden = Ocultar
        ug_asiento.DisplayLayout.Bands(0).Columns("CenCosto").Hidden = Ocultar
        ug_asiento.DisplayLayout.Bands(0).Columns("MedioPago").Hidden = Ocultar
        ug_asiento.DisplayLayout.Bands(0).Columns("Banco").Hidden = Ocultar
        ug_asiento.DisplayLayout.Bands(0).Columns("porce_destino").Hidden = Ocultar
        ug_asiento.DisplayLayout.Bands(0).Columns("TipoAnexo").Hidden = Ocultar
        ug_asiento.DisplayLayout.Bands(0).Columns("Es_Destino").Hidden = Ocultar
        ug_asiento.DisplayLayout.Bands(0).Columns("cc_id").Hidden = Ocultar
        ug_asiento.DisplayLayout.Bands(0).Columns("Sec_Ori_Destino").Hidden = Ocultar
        ug_asiento.DisplayLayout.Bands(0).Columns("Descripcion").Width = 370

    End Sub

    Private Sub ELiminar_Item_DocPen()
        Try
            If gInt_IdEmpresa = 1 Then 'clinica

                For Each doc As Cls_DocPendientes In ListaDocPendiente

                    If Not ugb_docCola.Visible Then
                        ListaDocPendiente.Remove(doc)
                        Exit For
                    End If

                    If doc.ndoc.Trim.PadLeft(7, "0") = txt_NumDoc_Det.Text.Trim.PadLeft(7, "0") Then
                        If doc.sdoc = txt_SerieDoc_Det.Text.Trim Then
                            If doc.tdoc = uce_TipoDoc_Det.Text.Trim Then
                                ListaDocPendiente.Remove(doc)
                                Exit For
                            End If
                        End If

                        Exit For
                    End If
                Next

             
                For Each item As ListViewItem In lv_Doc_En_Cola.Items

                    If item.SubItems(0).Text.Substring(item.SubItems(0).Text.Length - 10, 10).Trim.Equals(txt_NumDoc_Det.Text.Trim) Then
                        If item.SubItems(0).Text.Substring(6, txt_SerieDoc_Det.Text.Length).Trim.Equals(txt_SerieDoc_Det.Text.Trim) Then
                            If item.SubItems(0).Text.Substring(0, 3).Equals(uce_TipoDoc_Det.Text.Substring(0, 3)) Then
                                item.StateImageIndex = 0
                                Exit For
                            End If
                        End If
                    End If


                Next
               
            Else
                For Each doc As Cls_DocPendientes In ListaDocPendiente
                    If doc.ndoc.Trim.PadLeft(10, "0") = txt_NumDoc_Det.Text.Trim Then
                        If doc.sdoc = txt_SerieDoc_Det.Text.Trim Then
                            If doc.tdoc = uce_TipoDoc_Det.Text.Trim Then
                                ListaDocPendiente.Remove(doc)
                                Exit For
                            End If
                        End If

                        Exit For
                    End If
                Next

                For Each item As ListViewItem In lv_Doc_En_Cola.Items
                    If item.SubItems(0).Text.Substring(item.SubItems(0).Text.Length - 10, 10).Trim.Equals(txt_NumDoc_Det.Text.Trim) Then
                        If item.SubItems(0).Text.Substring(6, txt_SerieDoc_Det.Text.Length).Trim.Equals(txt_SerieDoc_Det.Text.Trim) Then
                            If item.SubItems(0).Text.Substring(0, 3).Equals(uce_TipoDoc_Det.Text.Substring(0, 3)) Then
                                item.StateImageIndex = 0
                                Exit For
                            End If
                        End If
                    End If
                Next
            End If


        Catch ex As Exception

        End Try
    End Sub

    Private Sub udte_fec_Vou_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles udte_fec_Vou.Enter
        udte_fec_Vou.SelectAll()
    End Sub

    Private Sub uce_SubDiario_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles uce_SubDiario.KeyDown, udte_fec_Vou.KeyDown, uce_TipoCambio.KeyDown, txt_Glosa.KeyDown
        If e.KeyCode = Keys.Enter Then SendKeys.Send(vbTab)
    End Sub

    Private Sub Cargar_Cmb_SubDiario()

        Dim Obj_SubDBL As New BL.ContabilidadBL.SG_CO_TB_SUBDIARIO
        Dim E_SD As New BE.ContabilidadBE.SG_CO_TB_SUBDIARIO
        E_SD.SD_IDOPERACION = New SG_CO_TB_OPERACION With {.OP_CODIGO = gCInt_Ope_Generales}
        E_SD.SD_IDEMPRESA = New SG_CO_TB_EMPRESA With {.EM_ID = gInt_IdEmpresa}

        uce_SubDiario.DataSource = Obj_SubDBL.getSubdiarios_x_Modulo(E_SD)
        uce_SubDiario.DisplayMember = "SD_DESCRIPCION"
        uce_SubDiario.ValueMember = "SD_ID"

        E_SD = Nothing
        Obj_SubDBL = Nothing

    End Sub

    Private Sub Cargar_Cuentas_Combo()

        Dim Obj_PlanCtasBL As New BL.ContabilidadBL.SG_CO_TB_PLANCTAS
        Dim E_PlanCtas As New BE.ContabilidadBE.SG_CO_TB_PLANCTAS

        E_PlanCtas.PC_IDEMPRESA = New BE.ContabilidadBE.SG_CO_TB_EMPRESA With {.EM_ID = gInt_IdEmpresa}
        E_PlanCtas.PC_PERIODO = gDat_Fecha_Sis.Year

        uc_Cuentas.DataSource = Obj_PlanCtasBL.getCuentas_Movimiento(E_PlanCtas)

        E_PlanCtas = Nothing
        Obj_PlanCtasBL = Nothing

    End Sub

    Private Sub Cargar_Cmb_Monedas()

        Dim Obj_MonedaBL As New BL.ContabilidadBL.SG_CO_TB_MONEDA

        uce_Moneda_Det.DataSource = Obj_MonedaBL.getMonedas()
        uce_Moneda_Det.DisplayMember = "MO_DESCRIPCION"
        uce_Moneda_Det.ValueMember = "MO_CODIGO"

        Obj_MonedaBL = Nothing

    End Sub

    Private Sub Cargar_Documentos()
        Try
            Dim Obj_DocBL As New BL.ContabilidadBL.SG_CO_TB_DOCUMENTO
            Dim E_Doc As New BE.ContabilidadBE.SG_CO_TB_DOCUMENTO
            E_Doc.DO_IDEMPRESA = New SG_CO_TB_EMPRESA With {.EM_ID = gInt_IdEmpresa}

            uce_TipoDoc_Det.DataSource = Obj_DocBL.getDocumentos(E_Doc)
            uce_TipoDoc_Det.DisplayMember = "DO_DESCRIPCION"
            uce_TipoDoc_Det.ValueMember = "DO_CODIGO"

            E_Doc = Nothing
            Obj_DocBL = Nothing

        Catch ex As Exception
            ShowError(ex.Message)
        End Try
    End Sub

    Private Sub Cargar_TipoCambioFormato()
        Try
            Dim Obj_ForTC As New BL.ContabilidadBL.SG_CO_TB_FORM_TIPCAMB

            uce_TipoCambio.DataSource = Obj_ForTC.getFormatos
            uce_TipoCambio.DisplayMember = "FT_DESCRIPCION"
            uce_TipoCambio.ValueMember = "FT_CODIGO"

        Catch ex As Exception
            ShowError(ex.Message)
        End Try
    End Sub

    Private Sub Iniciar_Formulario()

        Me.Text = "Operaciones Generales"
        ugb_Cabecera.Enabled = True
        Call LimpiaGrid(ug_asiento, uds_Asiento)
        uce_TipoCambio.Value = 2
        uce_SubDiario.SelectedIndex = -1

        udte_fec_Vou.Value = gDat_Fecha_Sis
        'udte_fec_Vou.Value = Nothing
        uce_TipoCambio.SelectedIndex = -1
        uce_TipoCambio.SelectedIndex = 1
        ubtn_Impresion.Visible = False
        txt_Glosa.Text = String.Empty
        txt_Num_Voucher.Text = String.Empty
        ugb_Cabecera.Enabled = True
        btn_Nuevo.Enabled = True
        ume_tot_d.Value = 0
        ume_tot_h.Value = 0
        ume_dif.Value = 0

        lv_Doc_En_Cola.Items.Clear()
        ListaDocPendiente.Clear()

        Call AgrandarForm()

    End Sub

    Private Sub btn_Nuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Nuevo.Click
        Call IngresarFilas()
    End Sub
    Private Sub IngresarFilas()
        Call LimpiarDetalle()
        'Call MostrarTabs(1, utc_Asiento, 1)
        uce_Moneda_Det.Value = 1
        Bol_NuevoDet = True
        txt_Glosa_Det.Text = txt_Glosa.Text
        txt_Anexo_Det.Enabled = False
        ume_ValorTipoCambio_Det.Value = ume_ValorTipoCambio.Value
        utc_Asiento.Height = 202
        ugb_detalle.Visible = True
        uc_Cuentas.Focus()
    End Sub

    Private Sub LimpiarDetalle()
        Try
            uc_Cuentas.Value = Nothing
            lbl_des_cta.Text = String.Empty
            txt_Anexo_Det.Text = String.Empty
            lbl_Des_Anexo.Text = String.Empty
            uce_TipoDoc_Det.SelectedIndex = -1
            txt_SerieDoc_Det.Text = String.Empty
            txt_NumDoc_Det.Text = String.Empty
            ume_FecEmi_Det.Value = Nothing
            ume_FecVen_Det.Value = Nothing
            ume_Debe_Det.Value = 0
            ume_Haber_Det.Value = 0
            txt_Glosa_Det.Text = String.Empty
            txt_idAnexoDet.Text = String.Empty
            uce_MedioPago.SelectedIndex = -1
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btn_GrabarDet_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_GrabarDet.Click
        Try
            If lbl_des_cta.Text.Length > 0 Then
                If lbl_des_cta.Text.Chars(0) = "*" Then
                    Avisar("Debe ingresar una cuenta valida")
                    If uc_Cuentas.Enabled Then uc_Cuentas.Focus()
                    Exit Sub
                End If

            End If

            If lbl_Des_Anexo.Text.Length > 0 Then
                If lbl_Des_Anexo.Text.Chars(0) = "*" Then
                    Avisar("Debe ingresar un anexo valido")
                    If txt_Anexo_Det.Enabled Then txt_Anexo_Det.Focus()
                    Exit Sub
                End If
            End If

            If ume_Debe_Det.Value = 0 And ume_Haber_Det.Value = 0 Then
                Avisar("Debe ingresar el importe mayor a cero")
                ume_Debe_Det.Focus()
                Exit Sub
            End If

            If uce_cc.Enabled Then
                If uce_cc.SelectedIndex = -1 Then
                    Avisar("La cuenta requiere centro de costo")
                    uce_cc.Focus()
                    Exit Sub
                End If
            End If


            If Bol_NuevoDet Then
                Call SaveFilaDet()
                Call ELiminar_Item_DocPen()

                If ListaDocPendiente.Count = 0 Then
                    ugb_docCola.Visible = False
                    lv_Doc_En_Cola.Items.Clear()

                    Call LimpiarDetalle()

                    txt_Glosa_Det.Text = txt_Glosa.Text
                    uce_Moneda_Det.Value = "1"
                    ume_ValorTipoCambio_Det.Value = ume_ValorTipoCambio.Value
                    uc_Cuentas.Focus()
                Else
                    Call Cargar_DocPendiente_aCajas()
                    btn_GrabarDet.Focus()
                End If

                If Bol_Insertar_Detalle_Medio Then Call Insertar_UltimaFila_alMedio()

            Else
                Call SaveRowDet_edit()
                Call Sum_Tot()
                Call ELiminar_Item_DocPen()
                If ListaDocPendiente.Count = 0 Then
                    Call MostrarTabs(0, utc_Asiento, 0)
                    Exit Sub
                End If
            End If

            Call Sum_Tot()

        Catch ex As Exception

        End Try
    End Sub

    Private Sub Insertar_UltimaFila_alMedio()
        Try
            Dim lista_filas As New List(Of List(Of String))
            Dim lista_columnas As List(Of String)
            Dim ultima_fila As List(Of String)


            For i As Integer = 0 To ug_asiento.Rows.Count - 1
                lista_columnas = New List(Of String)
                For c As Integer = 0 To ug_asiento.DisplayLayout.Bands(0).Columns.Count - 1
                    lista_columnas.Add(ug_asiento.Rows(i).Cells(c).Value.ToString)
                Next
                lista_filas.Add(lista_columnas)
            Next


            ultima_fila = lista_filas(lista_filas.Count - 1)

            Call LimpiaGrid(ug_asiento, uds_Asiento)
            Dim entro As Boolean = False

            For i As Integer = 0 To lista_filas.Count - 1
                If i = lista_filas.Count - 1 Then
                    Exit For
                End If

                If Int_Posicion_fila_Insertar = (i + 1) Then
                    ug_asiento.DisplayLayout.Bands(0).AddNew()
                    For c As Integer = 0 To ultima_fila.Count - 1
                        ug_asiento.Rows(i).Cells(c).Value = ultima_fila(c)
                    Next
                    entro = Not entro
                End If

                If entro Then
                    ug_asiento.DisplayLayout.Bands(0).AddNew()
                    For c As Integer = 0 To ug_asiento.DisplayLayout.Bands(0).Columns.Count - 1
                        ug_asiento.Rows(i + 1).Cells(c).Value = lista_filas(i)(c)
                    Next
                Else
                    ug_asiento.DisplayLayout.Bands(0).AddNew()
                    For c As Integer = 0 To ug_asiento.DisplayLayout.Bands(0).Columns.Count - 1
                        ug_asiento.Rows(i).Cells(c).Value = lista_filas(i)(c)
                    Next
                End If

            Next

            ug_asiento.UpdateData()

            Call ReHacerSecuencia()

            ug_asiento.Rows(Int_Posicion_fila_Insertar - 1).Activate()
            utc_Asiento.Height = 370

            Bol_Insertar_Detalle_Medio = False

        Catch ex As Exception

        End Try
    End Sub

    Private Sub Cargar_DocPendiente_aCajas()
        Try
            If ListaDocPendiente.Count > 0 Then

                txt_cod_Doc_Det.Text = ListaDocPendiente(0).tdoc
                uce_TipoDoc_Det.Value = ListaDocPendiente(0).tdoc
                txt_SerieDoc_Det.Text = ListaDocPendiente(0).sdoc

                If gInt_IdEmpresa = 1 Then
                    txt_NumDoc_Det.Text = ListaDocPendiente(0).ndoc.ToString.Trim
                Else
                    txt_NumDoc_Det.Text = ListaDocPendiente(0).ndoc.ToString.Trim.PadLeft(10, "0")
                End If

                txt_Cod_Mon_Det.Text = "1"
                uce_Moneda_Det.Value = "1"
                'ume_FecEmi_Det.Value = ListaDocPendiente(0).fecha


                If ListaDocPendiente(0).fecha = "" Then
                    ume_FecEmi_Det.Value = Nothing
                Else
                    ume_FecEmi_Det.Value = ListaDocPendiente(0).fecha
                End If


                'Busco por el Id del Detalle si es en Dolares.
                Dim DetalleBL As New BL.ContabilidadBL.SG_CO_TB_ASIENTO_CONTABLE
                Dim DetalleBE As New BE.ContabilidadBE.SG_CO_TB_ASIENTO_DET
                Dim DetalleBE2 As New BE.ContabilidadBE.SG_CO_TB_ASIENTO_DET
                Dim Bol_EsDolar As Boolean = False

                DetalleBE.AD_IDCAB = New SG_CO_TB_ASIENTO_CAB With {.AC_ID = ListaDocPendiente(0).ID_MIN}
                DetalleBE.AD_TDOC = New SG_CO_TB_DOCUMENTO With {.DO_CODIGO = txt_cod_Doc_Det.Text}
                DetalleBE.AD_SDOC = txt_SerieDoc_Det.Text
                DetalleBE.AD_NDOC = txt_NumDoc_Det.Text
                DetalleBE.AD_CUENTA = uc_Cuentas.Text.Trim
                DetalleBE.AD_IDANEXO = New SG_CO_TB_ANEXO With {.AN_IDANEXO = txt_idAnexoDet.Text.Trim}
                Try
                    DetalleBE2 = DetalleBL.getDetalle_x_Id(DetalleBE)
                Catch ex As Exception
                    GoTo Saltar_punto1
                End Try

                If DetalleBE2 Is Nothing Then
                    GoTo Saltar_punto1
                End If

                Bol_EsDolar = False
                If DetalleBE2.AD_TCAM > 0 Then Bol_EsDolar = Not Bol_EsDolar

                'Si es Dolares Cargo los datos con el importe en dolares
                If Bol_EsDolar Then
                    If ListaDocPendiente(0).haber > 0 Then
                        ume_Debe_Det.Value = DetalleBE2.AD_MONTO_ORI
                        ume_Haber_Det.Value = 0
                    Else
                        ume_Debe_Det.Value = 0
                        ume_Haber_Det.Value = DetalleBE2.AD_MONTO_ORI
                    End If

                    txt_Cod_Mon_Det.Text = "2"
                    uce_Moneda_Det.Value = "2"

                    ume_ValorTipoCambio_Det.Value = DetalleBE2.AD_TCAM

                Else
Saltar_punto1:
                    ume_Debe_Det.Value = ListaDocPendiente(0).haber
                    ume_Haber_Det.Value = ListaDocPendiente(0).debe
                    txt_Cod_Mon_Det.Text = "1"
                    uce_Moneda_Det.Value = "1"
                    ume_ValorTipoCambio_Det.Value = ume_ValorTipoCambio.Value

                End If

            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub SaveRowDet_edit()
        Try
            Dim valor As Double = 0
            Dim tcambio As Double = ume_ValorTipoCambio_Det.Value

            If ume_Debe_Det.Value > 0 Then
                valor = ume_Debe_Det.Value
            Else
                valor = ume_Haber_Det.Value
            End If

            With ug_asiento.ActiveRow
                .Cells("Cuenta").Value = uc_Cuentas.Text.Trim
                If lbl_Des_Anexo.Text.Trim.Length > 0 Then
                    .Cells("Descripcion").Value = lbl_Des_Anexo.Text.Trim
                Else
                    .Cells("Descripcion").Value = lbl_des_cta.Text.Trim
                End If

                If IsDBNull(ume_FecEmi_Det.Value) Then
                    .Cells("Fecha Emi").Value = ""
                Else
                    .Cells("Fecha Emi").Value = CDate(ume_FecEmi_Det.Value).ToShortDateString
                End If

                If IsDBNull(ume_FecVen_Det.Value) Then
                    .Cells("Fecha ven").Value = ""
                Else
                    .Cells("Fecha ven").Value = CDate(ume_FecVen_Det.Value).ToShortDateString
                End If

                .Cells("Tip_Doc").Value = uce_TipoDoc_Det.Value
                .Cells("Serie").Value = txt_SerieDoc_Det.Text
                .Cells("Numero").Value = txt_NumDoc_Det.Text
                .Cells("Anexo").Value = txt_idAnexoDet.Text

                If CDbl(ume_Debe_Det.Value) > 0 Then
                    .Cells("Debe").Value = IIf(uce_Moneda_Det.Value = 1, valor.ToString("##,##0.00"), (valor * tcambio).ToString("##,##0.00"))
                    .Cells("Haber").Value = Nothing
                Else
                    .Cells("Debe").Value = Nothing
                    .Cells("Haber").Value = IIf(uce_Moneda_Det.Value = 1, valor.ToString("##,##0.00"), (valor * tcambio).ToString("##,##0.00"))
                End If

                .Cells("TipoCam").Value = IIf(uce_Moneda_Det.Value = 1, Nothing, tcambio)
                .Cells("CenCosto").Value = IIf(uce_cc.SelectedIndex <> -1, uce_cc.Text.Trim, "")
                .Cells("cc_id").Value = IIf(uce_cc.SelectedIndex <> -1, uce_cc.Value, 0)
                .Cells("Glosa").Value = txt_Glosa_Det.Text.Trim

                .Cells("Soles").Value = valor.ToString("##,##0.000")

                ug_asiento.UpdateData()
                Call Actualizar_Importe_CtaDestino(.Cells("Item").Value, valor)
                Call AgrandarForm()
                Call LimpiarDetalle()



            End With

        Catch ex As Exception
            ShowError("Ocurrio un error : " & ex.Message)
        End Try
    End Sub

    Private Sub AchicarForm()
        'utc_Asiento.Height = 202
    End Sub
    Private Sub AgrandarForm()
        'utc_Asiento.Height = 370
    End Sub

    Private Sub SaveFilaDet()
        Try
            'validamos los datos
            Dim PlanCtasBL As New BL.ContabilidadBL.SG_CO_TB_PLANCTAS
            Dim E_PlanCtas As New BE.ContabilidadBE.SG_CO_TB_PLANCTAS

            E_PlanCtas.PC_IDEMPRESA = New SG_CO_TB_EMPRESA With {.EM_ID = gInt_IdEmpresa}
            E_PlanCtas.PC_PERIODO = gDat_Fecha_Sis.Year
            E_PlanCtas.PC_NUM_CUENTA = uc_Cuentas.Text.Trim
            PlanCtasBL.getCuenta_X_NumeroCta(E_PlanCtas)

            If Not E_PlanCtas.PC_IDTIPO_ANEXO Is Nothing Then
                If txt_Anexo_Det.Text = "" Then
                    Avisar("La cuenta requiere un anexo.")
                    txt_Anexo_Det.Focus()
                    Exit Sub
                End If
            End If

           

            ug_asiento.DisplayLayout.Bands(0).AddNew()
            Dim Int_NumFilas As Integer = ug_asiento.Rows.Count
            Dim valor As Double = 0
            Dim tcambio As Double = ume_ValorTipoCambio_Det.Value

            If ume_Debe_Det.Value > 0 Then
                valor = ume_Debe_Det.Value
            Else
                valor = ume_Haber_Det.Value
            End If

            ug_asiento.Rows(Int_NumFilas - 1).Cells("Item").Value = Int_NumFilas.ToString.PadLeft("3", "0")
            ug_asiento.Rows(Int_NumFilas - 1).Cells("Cuenta").Value = uc_Cuentas.Text.Trim
            ug_asiento.Rows(Int_NumFilas - 1).Cells("Descripcion").Value = lbl_des_cta.Text

            If Not E_PlanCtas.PC_IDTIPO_ANEXO Is Nothing Then
                ug_asiento.Rows(Int_NumFilas - 1).Cells("TipoAnexo").Value = CInt(E_PlanCtas.PC_IDTIPO_ANEXO.TA_CODIGO)
            Else
                ug_asiento.Rows(Int_NumFilas - 1).Cells("TipoAnexo").Value = Nothing
            End If


            If Not IsDBNull(ume_FecEmi_Det.Value) Then
                ug_asiento.Rows(Int_NumFilas - 1).Cells("Fecha Emi").Value = CDate(ume_FecEmi_Det.Value).ToShortDateString
            End If

            If Not IsDBNull(ume_FecVen_Det.Value) Then
                ug_asiento.Rows(Int_NumFilas - 1).Cells("Fecha ven").Value = CDate(ume_FecVen_Det.Value).ToShortDateString
            End If

            ug_asiento.Rows(Int_NumFilas - 1).Cells("Tip_Doc").Value = uce_TipoDoc_Det.Value
            ug_asiento.Rows(Int_NumFilas - 1).Cells("Serie").Value = txt_SerieDoc_Det.Text
            ug_asiento.Rows(Int_NumFilas - 1).Cells("Numero").Value = txt_NumDoc_Det.Text
            ug_asiento.Rows(Int_NumFilas - 1).Cells("Anexo").Value = txt_idAnexoDet.Text


            If CDbl(ume_Debe_Det.Value) > 0 Then
                ug_asiento.Rows(Int_NumFilas - 1).Cells("Debe").Value = IIf(uce_Moneda_Det.Value = 1, valor.ToString("##,##0.00"), (valor * tcambio).ToString("##,##0.00"))
                ug_asiento.Rows(Int_NumFilas - 1).Cells("Haber").Value = Nothing
            Else
                ug_asiento.Rows(Int_NumFilas - 1).Cells("Debe").Value = Nothing
                ug_asiento.Rows(Int_NumFilas - 1).Cells("Haber").Value = IIf(uce_Moneda_Det.Value = 1, valor.ToString("##,##0.00"), (valor * tcambio).ToString("##,##0.00"))
            End If

            ug_asiento.Rows(Int_NumFilas - 1).Cells("TipoCam").Value = IIf(uce_Moneda_Det.Value = 1, Nothing, tcambio)
            ug_asiento.Rows(Int_NumFilas - 1).Cells("CenCosto").Value = IIf(uce_cc.SelectedIndex <> -1, uce_cc.Text.Trim, "")
            ug_asiento.Rows(Int_NumFilas - 1).Cells("cc_id").Value = IIf(uce_cc.SelectedIndex <> -1, uce_cc.Value, 0)
            ug_asiento.Rows(Int_NumFilas - 1).Cells("Glosa").Value = txt_Glosa_Det.Text.Trim
            ug_asiento.Rows(Int_NumFilas - 1).Cells("Es_Destino").Value = "0"


            ug_asiento.Rows(Int_NumFilas - 1).Cells("Soles").Value = valor.ToString("##,##0.000")
            ug_asiento.UpdateData()

            Dim Obj_DestinoBL As New BL.ContabilidadBL.SG_CO_TB_CTA_DESTINO

            If Obj_DestinoBL.Tiene_Destinos(uc_Cuentas.Value) Then '______________________ Consultamos si la cuenta tiene destinos 
                CO_PR_VouCompras_Destinos.Inicializar_Form()
                CO_PR_VouCompras_Destinos.uc_Cuentas.Value = uc_Cuentas.Value
                CO_PR_VouCompras_Destinos.txt_Des_Cta.Text = lbl_des_cta.Text
                CO_PR_VouCompras_Destinos.ShowDialog()
                If CO_PR_VouCompras_Destinos.Bol_Aceptar Then
                    Call Creamos_Asiento_Destino(valor, False)
                End If
            End If


            'Call LimpiarDetalle()
            txt_Glosa_Det.Text = txt_Glosa.Text
            uc_Cuentas.Focus()
        Catch ex As Exception
            ShowError("Ocurrio un error: (SaveFilaDet) " & ex.Message)
        End Try
    End Sub

    Private Sub Creamos_Asiento_Destino(ByVal Dbl_importe As Double, ByVal Bol_EsCab As Boolean)
        Try
            Dim Dt_destinos As DataTable

            Dim Str_Cta_Origen As String = CO_PR_VouCompras_Destinos.uc_Cuentas.ActiveRow.Cells("PC_NUM_CUENTA").Text.Trim
            Dim Str_Des_Cta_Origen = CO_PR_VouCompras_Destinos.txt_Des_Cta.Text.Trim
            Dim Int_NumFilas As Integer = 0

            Dt_destinos = CO_PR_VouCompras_Destinos.getDestinos

            If Bol_EsCab Then
                ug_asiento.DisplayLayout.Bands(0).AddNew()
                Int_NumFilas = ug_asiento.Rows.Count
                ug_asiento.Rows(Int_NumFilas - 1).Cells("Item").Value = Int_NumFilas.ToString.PadLeft("3", "0")
                ug_asiento.Rows(Int_NumFilas - 1).Cells("Cuenta").Value = Str_Cta_Origen
                ug_asiento.Rows(Int_NumFilas - 1).Cells("Descripcion").Value = Str_Des_Cta_Origen

                ug_asiento.Rows(Int_NumFilas - 1).Cells("Debe").Value = Convert.ToDouble(IIf(uce_Moneda_Det.Value = 1, Dbl_importe, Dbl_importe * ume_ValorTipoCambio.Value)).ToString("##,##0.00")
                ug_asiento.Rows(Int_NumFilas - 1).Cells("Haber").Value = Nothing


                ug_asiento.Rows(Int_NumFilas - 1).Cells("Es_Destino").Value = "0"
                ug_asiento.Rows(Int_NumFilas - 1).Cells("Soles").Value = Dbl_importe.ToString("##,##0.000")
                ug_asiento.Rows(Int_NumFilas - 1).Cells("TipoCam").Value = IIf(uce_Moneda_Det.Value = 1, Nothing, ume_ValorTipoCambio.Value)
                ug_asiento.Rows(Int_NumFilas - 1).Cells("Glosa").Value = txt_Glosa.Text.Trim
                ug_asiento.Rows(Int_NumFilas - 1).Cells("cc_id").Value = 0
                ug_asiento.UpdateData()
            End If



            Dim Obj_PlanCtasBL As New BL.ContabilidadBL.SG_CO_TB_PLANCTAS
            Dim E_PlanCtas As New BE.ContabilidadBE.SG_CO_TB_PLANCTAS
            E_PlanCtas.PC_IDEMPRESA = New SG_CO_TB_EMPRESA With {.EM_ID = gInt_IdEmpresa}
            E_PlanCtas.PC_PERIODO = gDat_Fecha_Sis.Year

            Dim Int_Secuencia_Origen As Integer = ug_asiento.Rows.Count
            Dim Dbl_Importe_Prora As Double = 0
            Dim Dbl_porcentaje_destino As Double = 0

            For i As Integer = 0 To Dt_destinos.Rows.Count - 1
                If Dt_destinos.Rows(i)("Porcentaje") > 0 Then

                    E_PlanCtas.PC_NUM_CUENTA = Dt_destinos.Rows(i)("Cuenta")
                    Obj_PlanCtasBL.getCuenta_X_NumeroCta(E_PlanCtas)
                    Dbl_porcentaje_destino = Dt_destinos.Rows(i)("Porcentaje")
                    Dbl_Importe_Prora = Dbl_importe * (Dt_destinos.Rows(i)("Porcentaje") / 100)

                    ug_asiento.DisplayLayout.Bands(0).AddNew()
                    Int_NumFilas = ug_asiento.Rows.Count
                    ug_asiento.Rows(Int_NumFilas - 1).Cells("Item").Value = Int_NumFilas.ToString.PadLeft("3", "0")
                    ug_asiento.Rows(Int_NumFilas - 1).Cells("Cuenta").Value = E_PlanCtas.PC_NUM_CUENTA
                    ug_asiento.Rows(Int_NumFilas - 1).Cells("Descripcion").Value = E_PlanCtas.PC_DESCRIPCION

                    If Dt_destinos.Rows(i)("DH") = "D" Then
                        ug_asiento.Rows(Int_NumFilas - 1).Cells("Debe").Value = Convert.ToDouble(IIf(uce_Moneda_Det.Value = 1, Dbl_Importe_Prora, Dbl_Importe_Prora * ume_ValorTipoCambio.Value)).ToString("##,##0.00")
                    Else
                        ug_asiento.Rows(Int_NumFilas - 1).Cells("Haber").Value = Convert.ToDouble(IIf(uce_Moneda_Det.Value = 1, Dbl_Importe_Prora, Dbl_Importe_Prora * ume_ValorTipoCambio.Value)).ToString("##,##0.00")
                    End If

                    ug_asiento.Rows(Int_NumFilas - 1).Cells("Es_Destino").Value = "1"
                    ug_asiento.Rows(Int_NumFilas - 1).Cells("Soles").Value = Convert.ToDouble(Dbl_Importe_Prora).ToString("##,##0.000")
                    ug_asiento.Rows(Int_NumFilas - 1).Cells("TipoCam").Value = IIf(uce_Moneda_Det.Value = 1, Nothing, ume_ValorTipoCambio.Value)
                    ug_asiento.Rows(Int_NumFilas - 1).Cells("Glosa").Value = txt_Glosa.Text.Trim
                    ug_asiento.Rows(Int_NumFilas - 1).Cells("cc_id").Value = 0
                    ug_asiento.Rows(Int_NumFilas - 1).Cells("porce_destino").Value = Dbl_porcentaje_destino
                    ug_asiento.Rows(Int_NumFilas - 1).Cells("sec_Ori_Destino").Value = Int_Secuencia_Origen.ToString.PadLeft("3", "0")
                    ug_asiento.UpdateData()

                End If
            Next

        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub Actualizar_Importe_CtaDestino(ByVal Secuencia As String, ByVal importe As Double)
        Try
            Dim contador As Integer = 0
            For i As Integer = 0 To ug_asiento.Rows.Count - 1
                If ug_asiento.Rows(i).Cells("Sec_Ori_Destino").Value.ToString.Equals(Secuencia) Then
                    contador += 1
                End If
            Next

            If contador = 2 Then
                For i As Integer = 0 To ug_asiento.Rows.Count - 1
                    If ug_asiento.Rows(i).Cells("Sec_Ori_Destino").Value.ToString.Equals(Secuencia) Then
                        If CDbl(IIf(IsDBNull(ug_asiento.Rows(i).Cells("Debe").Value), 0, ug_asiento.Rows(i).Cells("Debe").Value)) > 0 Then
                            ug_asiento.Rows(i).Cells("Debe").Value = IIf(uce_Moneda_Det.Value = 1, importe.ToString("##,##0.00"), CDbl(importe * CDbl(ume_ValorTipoCambio.Value)).ToString("##,##0.00"))
                        Else
                            ug_asiento.Rows(i).Cells("Haber").Value = IIf(uce_Moneda_Det.Value = 1, importe.ToString("##,##0.00"), CDbl(importe * CDbl(ume_ValorTipoCambio.Value)).ToString("##,##0.00"))
                        End If
                        ug_asiento.Rows(i).Cells("Soles").Value = importe.ToString("##,##0.000")
                    End If
                Next
            End If

            ug_asiento.UpdateData()

        Catch ex As Exception

        End Try
    End Sub

    Private Sub Sum_Tot()
        Try
            Dim Dbl_Debe As Double = 0
            Dim Dbl_Haber As Double = 0
            Dim Dbl_Dif As Double = 0

            For i As Integer = 0 To ug_asiento.Rows.Count - 1
                Dbl_Debe = Dbl_Debe + IIf(ug_asiento.Rows(i).Cells("Debe").Value.ToString = "", 0, ug_asiento.Rows(i).Cells("Debe").Value)
                Dbl_Haber = Dbl_Haber + IIf(ug_asiento.Rows(i).Cells("Haber").Value.ToString = "", 0, ug_asiento.Rows(i).Cells("Haber").Value)
            Next

            ume_tot_d.Value = Math.Round(Dbl_Debe, 2)
            ume_tot_h.Value = Math.Round(Dbl_Haber, 2)

            Try
                Dbl_Dif = Math.Round(CDbl(ume_tot_d.Value) - CDbl(ume_tot_h.Value), 2)
            Catch ex As Exception
                Dbl_Dif = Dbl_Debe - Dbl_Haber
            End Try

            ume_dif.Value = Dbl_Dif

        Catch ex As Exception

        End Try
    End Sub


    Private Sub uce_TipoCambio_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles uce_TipoCambio.ValueChanged
        Try

            Dim Obj_tcBL As New BL.ContabilidadBL.SG_CO_TB_TIPOCAMBIO
            Dim E_tc As New BE.ContabilidadBE.SG_CO_TB_TIPOCAMBIO
            E_tc.TC_IDEMPRESA = New BE.ContabilidadBE.SG_CO_TB_EMPRESA With {.EM_ID = gInt_IdEmpresa}
            E_tc.TC_FECHA = CDate(udte_fec_Vou.Value).ToShortDateString
            E_tc.TC_IDMONEDA = New BE.ContabilidadBE.SG_CO_TB_MONEDA With {.MO_CODIGO = 2}
            Obj_tcBL.getTipoCambio(E_tc)
            Select Case uce_TipoCambio.Value
                Case 1
                    ume_ValorTipoCambio.Value = E_tc.TC_COMPRA
                Case 2
                    ume_ValorTipoCambio.Value = E_tc.TC_VENTA
                Case 3
                    ume_ValorTipoCambio.Value = 0
                    ume_ValorTipoCambio.Focus()
            End Select

        Catch ex As Exception

        End Try
    End Sub
    Private Sub uc_Cuentas_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles uc_Cuentas.KeyDown

        If e.KeyCode = Keys.Escape Then btn_CancelarDet_Click(sender, e)
        Dim Int_TipoAnexo_Local As Integer = 0

        If e.KeyCode = Keys.Enter Then
            Try

                If lbl_des_cta.Text.Chars(0) = "*" Then Exit Sub

                Dim PlanCtasBE As New SG_CO_TB_PLANCTAS With {.PC_IDCUENTA = uc_Cuentas.Value}
                Dim PlanCtasBL As New BL.ContabilidadBL.SG_CO_TB_PLANCTAS
                PlanCtasBL.getCuenta(PlanCtasBE)

                Int_TipoAnexo_Local = 0
                If Not PlanCtasBE.PC_IDTIPO_ANEXO Is Nothing Then
                    Int_TipoAnexo_Local = PlanCtasBE.PC_IDTIPO_ANEXO.TA_CODIGO
                End If

                If Int_TipoAnexo_Local <> 0 Then
                    txt_Anexo_Det.Enabled = True
                    txt_Anexo_Det.Focus()
                Else
                    txt_Anexo_Det.Enabled = False
                    txt_Anexo_Det.Text = String.Empty
                    txt_idAnexoDet.Text = String.Empty
                    lbl_Des_Anexo.Text = String.Empty
                    SendKeys.Send(vbTab)
                End If

                If PlanCtasBE.PC_ES_CC = 1 Then
                    uce_cc.Enabled = True
                Else
                    uce_cc.SelectedIndex = -1
                    uce_cc.Enabled = False
                End If


                If PlanCtasBE.PC_IDMONEDA.MO_CODIGO = 2 Then
                    txt_Cod_Mon_Det.Text = 2
                    uce_Moneda_Det.Value = 2
                    ume_ValorTipoCambio_Det.Value = ume_ValorTipoCambio.Value
                End If

                PlanCtasBE = Nothing
                PlanCtasBL = Nothing

            Catch ex As Exception
            End Try
        End If

        If e.KeyCode = Keys.Down Then
            uc_Cuentas.PerformAction(Infragistics.Win.UltraWinGrid.UltraComboAction.Dropdown)
        End If

    End Sub

    Private Sub uc_Cuentas_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles uc_Cuentas.ValueChanged
        Try
            lbl_des_cta.Text = uc_Cuentas.ActiveRow.Cells("PC_DESCRIPCION").Value
            lbl_des_cta.Appearance.ForeColor = Color.Black
        Catch ex As Exception
            lbl_des_cta.Text = "*La cuenta no existe!"
            lbl_des_cta.Appearance.ForeColor = Color.Red
        End Try

    End Sub

    Private Sub btn_CancelarDet_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_CancelarDet.Click
        Call CancelSaveDet()
    End Sub

    Private Sub CancelSaveDet()

        Call LimpiarDetalle()
        Call MostrarTabs(0, utc_Asiento, 0)
        ugb_detalle.Visible = False
        ug_asiento.UpdateData()
        utc_Asiento.Height = 370
        ug_asiento.Focus()


    End Sub


    Private Sub txt_Anexo_Det_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_Anexo_Det.KeyDown
        If e.KeyCode = Keys.Escape Then btn_CancelarDet_Click(sender, e)

        If e.KeyCode = Keys.Enter Then
            If txt_Anexo_Det.Text.Trim.Length > 0 Then
                Call Ayuda_Proveedor_Cab()
            Else
                SendKeys.Send(vbTab)
            End If
        End If

        If e.KeyCode = Keys.F2 Then
            Call Ayuda_Proveedor_Cab()
        End If
    End Sub

    Private Sub txt_cod_Doc_Det_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_cod_Doc_Det.KeyDown
        If e.KeyCode = Keys.Escape Then btn_CancelarDet_Click(sender, e)
        If e.KeyCode = Keys.Enter Then SendKeys.Send(vbTab)
    End Sub

    Private Sub uce_TipoDoc_Det_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles uce_TipoDoc_Det.KeyDown
        If e.KeyCode = Keys.Enter Then SendKeys.Send(vbTab)
    End Sub

    Private Sub txt_SerieDoc_Det_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_SerieDoc_Det.KeyDown
        If e.KeyCode = Keys.Enter Then SendKeys.Send(vbTab)
    End Sub

    Private Sub txt_NumDoc_Det_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_NumDoc_Det.KeyDown
        If e.KeyCode = Keys.Enter Then SendKeys.Send(vbTab)
    End Sub

    Private Sub txt_Cod_Mon_Det_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_Cod_Mon_Det.KeyDown
        If e.KeyCode = Keys.Enter Then SendKeys.Send(vbTab)
    End Sub

    Private Sub uce_Moneda_Det_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles uce_Moneda_Det.KeyDown
        If e.KeyCode = Keys.Enter Then SendKeys.Send(vbTab)
    End Sub

    Private Sub ume_FecEmi_Det_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles ume_FecEmi_Det.KeyDown
        If e.KeyCode = Keys.Enter Then SendKeys.Send(vbTab)
    End Sub

    Private Sub ume_FecVen_Det_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles ume_FecVen_Det.KeyDown
        If e.KeyCode = Keys.Enter Then SendKeys.Send(vbTab)
    End Sub

    Private Sub ume_Debe_Det_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles ume_Debe_Det.KeyDown
        If e.KeyCode = Keys.Enter Then SendKeys.Send(vbTab)
    End Sub

    Private Sub ume_Haber_Det_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles ume_Haber_Det.KeyDown
        If e.KeyCode = Keys.Enter Then SendKeys.Send(vbTab)
    End Sub

    Private Sub txt_Banco_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        If e.KeyCode = Keys.Enter Then SendKeys.Send(vbTab)
    End Sub

    Private Sub uce_MedioPago_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles uce_MedioPago.KeyDown
        If e.KeyCode = Keys.Enter Then SendKeys.Send(vbTab)
        If e.KeyCode = Keys.Delete Then
            uce_MedioPago.SelectedIndex = -1
        End If
    End Sub

    Private Sub txt_Glosa_Det_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_Glosa_Det.KeyDown
        If e.KeyCode = Keys.Enter Then SendKeys.Send(vbTab)
    End Sub

    Private Sub txt_Anexo_Det_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_Anexo_Det.Leave
        Try

            If uce_SubDiario.SelectedIndex = -1 Then
                Avisar("Seleccione un subdiario.")
                uce_SubDiario.Focus()
                Exit Sub
            End If

            Dim E_PlanCtas As New SG_CO_TB_PLANCTAS With {.PC_IDCUENTA = uc_Cuentas.Value}
            Dim PlanCtasBL As New BL.ContabilidadBL.SG_CO_TB_PLANCTAS
            PlanCtasBL.getCuenta(E_PlanCtas)
            Dim Int_TipoAnexo_local As Integer
            Int_TipoAnexo_local = 0
            If Not E_PlanCtas.PC_IDTIPO_ANEXO Is Nothing Then
                Int_TipoAnexo_local = E_PlanCtas.PC_IDTIPO_ANEXO.TA_CODIGO
            End If


            Dim Obj_AnexoBL As New BL.ContabilidadBL.SG_CO_TB_ANEXO
            Dim Obj_TipoAnexoBL As New BL.ContabilidadBL.SG_CO_TB_TIPOANEXO

            Dim E_Anexo As New SG_CO_TB_ANEXO
            Dim E_SubDiario As New SG_CO_TB_SUBDIARIO
            E_SubDiario.SD_ID = uce_SubDiario.Value
            E_SubDiario.SD_IDEMPRESA = New SG_CO_TB_EMPRESA With {.EM_ID = gInt_IdEmpresa}

            E_Anexo.AN_IDEMPRESA = New SG_CO_TB_EMPRESA With {.EM_ID = gInt_IdEmpresa}
            E_Anexo.AN_TIPO_ANEXO = New SG_CO_TB_TIPOANEXO With {.TA_CODIGO = Int_TipoAnexo_local}
            E_Anexo.AN_NUM_DOC = txt_Anexo_Det.Text.Trim
            Obj_AnexoBL.getAnexo_x_Ruc(E_Anexo)

            If E_Anexo.AN_DESCRIPCION.Length = 0 Then
                lbl_Des_Anexo.Text = "*El anexo no existe."
                txt_idAnexoDet.Text = String.Empty
            Else
                lbl_Des_Anexo.Text = E_Anexo.AN_DESCRIPCION
                txt_idAnexoDet.Text = E_Anexo.AN_IDANEXO
            End If

            E_Anexo = Nothing
            Obj_AnexoBL = Nothing
            E_PlanCtas = Nothing
            PlanCtasBL = Nothing

            Obj_TipoAnexoBL.Dispose()

        Catch ex As Exception

        End Try
    End Sub

    Private Sub txt_cod_Doc_Det_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_cod_Doc_Det.Leave
        uce_TipoDoc_Det.Value = txt_cod_Doc_Det.Value
    End Sub

    Private Sub uce_TipoDoc_Det_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles uce_TipoDoc_Det.ValueChanged
        txt_cod_Doc_Det.Text = uce_TipoDoc_Det.Value
    End Sub

    Private Sub txt_NumDoc_Det_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_NumDoc_Det.Leave
        If txt_NumDoc_Det.Text.Trim.Length > 0 Then
            Select Case gInt_IdEmpresa
                Case 1 ' Clinica
                    If txt_Anexo_Det.Text.Trim.Length > 0 And txt_cod_Doc_Det.Text.Trim.Length > 0 Then
                        txt_NumDoc_Det.Text = txt_NumDoc_Det.Text.PadLeft(7, "0")
                    Else
                        txt_NumDoc_Det.Text = txt_NumDoc_Det.Text.PadLeft(10, "0")
                    End If

                Case 7 'botica
                    txt_NumDoc_Det.Text = txt_NumDoc_Det.Text.PadLeft(10, "0")

                Case Else
                    txt_NumDoc_Det.Text = txt_NumDoc_Det.Text.PadLeft(10, "0")

            End Select

        End If
    End Sub

    Private Sub txt_Cod_Mon_Det_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_Cod_Mon_Det.Leave
        uce_Moneda_Det.Value = txt_Cod_Mon_Det.Text.Trim
    End Sub

    Private Sub uce_Moneda_Det_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles uce_Moneda_Det.ValueChanged
        txt_Cod_Mon_Det.Text = uce_Moneda_Det.Value
    End Sub

    Private Sub ume_Debe_Det_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ume_Debe_Det.Leave
        Try
            If IsDBNull(ume_Debe_Det.Value) Then
                ume_Debe_Det.Value = 0
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub ume_Haber_Det_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ume_Haber_Det.Leave
        Try
            If IsDBNull(ume_Haber_Det.Value) Then
                ume_Haber_Det.Value = 0
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub ubtn_Salir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ubtn_Salir.Click
        Me.Close()
    End Sub

    Private Sub ubtn_Cancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ubtn_Cancelar.Click

        If Bol_Edicion Then
            If Preguntar("Esta seguro de Salir?") Then
                Me.Close()
            End If
            Exit Sub
        End If

        If ubtn_Cancelar.Text.Equals("&Cancelar") Then
            If Preguntar("Esta seguro de cancelar?") Then
                Call Limpiar_Controls_InGroupox(ugb_Cabecera)
                Call Iniciar_Formulario()
                uce_SubDiario.Focus()
            End If
        Else


            ugb_Cabecera.Enabled = True
            ubtn_GrabarVoucher.Enabled = True
            ubtn_Cancelar.Text = "&Cancelar"
            ubtn_Cancelar.Appearance.Image = My.Resources._16__Cancel_
            uce_SubDiario.Focus()
            Call Limpiar_Controls_InGroupox(ugb_Cabecera)
            Call Iniciar_Formulario()
            uce_SubDiario.Focus()
        End If
    End Sub

    Private Sub ubtn_GrabarVoucher_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ubtn_GrabarVoucher.Click
        Try

            If CDate(udte_fec_Vou.Value).Year <> gDat_Fecha_Sis.Year Then
                Avisar("El año no corresponde a la fecha de trabajo.")
                Exit Sub
            End If

            Dim Bol_EstaCerrado As Boolean = False
            Call Verificar_Mes_Cerrado(Me, CDate(udte_fec_Vou.Value).Year, CDate(udte_fec_Vou.Value).Month, Bol_EstaCerrado)

            If Bol_EstaCerrado Then
                Call Avisar("La fecha de voucher esta en un Periodo CERRADO. Revise")
                Exit Sub
            End If

            If udte_fec_Vou.Value Is Nothing Then
                Avisar("Ingrese una fecha valida")
                udte_fec_Vou.Focus()
                Exit Sub
            End If

            If CDbl(ume_dif.Value) <> 0 Then
                Avisar(String.Format("El asiento no esta cuadrando por {0}", CDbl(ume_dif.Value)))
                Exit Sub
            End If

            If ug_asiento.Rows.Count = 0 Then
                Avisar("ingrese cuenta al asiento")
                Exit Sub
            End If

            Dim AsientoBL As New BL.ContabilidadBL.SG_CO_TB_ASIENTO_CONTABLE
            Dim E_Cabecera As New BE.ContabilidadBE.SG_CO_TB_ASIENTO_CAB
            Dim Detalles As New List(Of BE.ContabilidadBE.SG_CO_TB_ASIENTO_DET)

            With E_Cabecera
                .AC_ID = Int_IdCab_Edit
                .AC_IDSUBDIARIO = New BE.ContabilidadBE.SG_CO_TB_SUBDIARIO With {.SD_ID = uce_SubDiario.Value}
                .AC_NUM_VOUCHER = txt_Num_Voucher.Text.Trim
                .AC_ANHO = CDate(udte_fec_Vou.Value).Year
                .AC_MES = CDate(udte_fec_Vou.Value).Month
                .AC_FEC_VOUCHER = CDate(udte_fec_Vou.Value).ToShortDateString
                .AC_IDMONEDA = New BE.ContabilidadBE.SG_CO_TB_MONEDA With {.MO_CODIGO = 1}
                .AC_DEBE = ume_tot_d.Value
                .AC_HABER = ume_tot_h.Value
                .AC_TC_OPE = ume_ValorTipoCambio.Value
                .AC_TC_ESPECIAL = 0

                If uce_TipoCambio.Value = 3 Then
                    .AC_TC_ESPECIAL = ume_ValorTipoCambio.Value
                End If

                .AC_ESTADO = 1
                .AC_GLOSA_VOU = txt_Glosa.Text.Trim
                .AC_ES_INTERFACE = 0
                .AC_TC_FORMATO = New BE.ContabilidadBE.SG_CO_TB_FORM_TIPCAMB With {.FT_CODIGO = uce_TipoCambio.Value}
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
                    .AD_SECUENCIA = ug_asiento.Rows(i).Cells("Item").Value.ToString
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

                    If ug_asiento.Rows(i).Cells("Tip_Doc").Value.ToString.Equals(String.Empty) Then
                        .AD_TDOC = Nothing
                    Else
                        .AD_TDOC = New BE.ContabilidadBE.SG_CO_TB_DOCUMENTO With {.DO_CODIGO = ug_asiento.Rows(i).Cells("Tip_Doc").Value.ToString}
                    End If

                    .AD_SDOC = ug_asiento.Rows(i).Cells("Serie").Value.ToString
                    .AD_NDOC = ug_asiento.Rows(i).Cells("Numero").Value.ToString
                    .AD_FDOC = ug_asiento.Rows(i).Cells("Fecha Emi").Value.ToString
                    .AD_VDOC = ug_asiento.Rows(i).Cells("Fecha ven").Value.ToString


                    .AD_DEBE = IIf(ug_asiento.Rows(i).Cells("Debe").Value.ToString = String.Empty, 0, ug_asiento.Rows(i).Cells("Debe").Value)
                    .AD_HABER = IIf(ug_asiento.Rows(i).Cells("Haber").Value.ToString = String.Empty, 0, ug_asiento.Rows(i).Cells("Haber").Value)
                    .AD_MONTO_ORI = ug_asiento.Rows(i).Cells("Soles").Value
                    .AD_PORCE_DESTINO = IIf(ug_asiento.Rows(i).Cells("porce_destino").Value.ToString = String.Empty, 0, ug_asiento.Rows(i).Cells("porce_destino").Value)

                    If ug_asiento.Rows(i).Cells("TipoCam").Value.ToString.Equals(String.Empty) Then
                        .AD_TCAM = 0
                    Else
                        .AD_TCAM = ug_asiento.Rows(i).Cells("TipoCam").Value
                    End If

                    .AD_SEC_ORI_DESTINO = IIf(ug_asiento.Rows(i).Cells("Sec_Ori_Destino").Value.ToString.Equals(String.Empty), 0, ug_asiento.Rows(i).Cells("Sec_Ori_Destino").Value)
                    .AD_GLOSA = ug_asiento.Rows(i).Cells("Glosa").Value.ToString
                    .AD_IDCC = New BE.ContabilidadBE.SG_CO_TB_CENTROCOSTO With {.CC_CODIGO = ug_asiento.Rows(i).Cells("cc_id").Value}
                    .AD_ES_DESTINO = ug_asiento.Rows(i).Cells("Es_Destino").Value
                    .AD_USUARIO = String.Format("{0}-{1}", Environment.UserName, gStr_Usuario_Sis)
                    .AD_TERMINAL = Environment.MachineName
                    .AD_FECREG = Date.Now
                    .AD_IDMEDIOPAGO = New BE.ContabilidadBE.SG_CO_TB_MEDIOPAGO With {.MP_CODIGO = ug_asiento.Rows(i).Cells("MedioPago").Value.ToString}

                End With
                Detalles.Add(E_Detalle)
            Next





            Dim StrVoucher As String = String.Empty
            If Bol_Edicion Then StrVoucher = txt_Num_Voucher.Text

            AsientoBL.Insert_Generales(E_Cabecera, Detalles, StrVoucher, Bol_Edicion)
            txt_Num_Voucher.Text = StrVoucher
            txt_IdCabecera.Text = E_Cabecera.AC_ID

            Call Avisar("Listo!")

            If Bol_Edicion Or Bol_Copy Then
                CO_PR_EdicionVoucher.Cargar_Voucher_II(uce_SubDiario.Value, CDate(udte_fec_Vou.Value).Month)
                Me.Close()
            End If

            ubtn_Impresion.Visible = True
            ugb_Cabecera.Enabled = False
            ubtn_GrabarVoucher.Enabled = False
            ubtn_Cancelar.Text = "&Nuevo"
            ubtn_Cancelar.Appearance.Image = My.Resources._16__File_new_2_
            ubtn_Cancelar.Focus()

        Catch ex As Exception
            Call ShowError(ex.Message)
        End Try
    End Sub

    Private Sub txt_Anexo_Det_EditorButtonClick(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinEditors.EditorButtonEventArgs) Handles txt_Anexo_Det.EditorButtonClick
        Select Case e.Button.Key
            Case "Ayuda"
                Call Ayuda_Proveedor_Cab()
            Case ""

        End Select
    End Sub

    Private Sub Ayuda_Proveedor_Cab_Ori()

        Dim ListaDocPendiente As New List(Of Cls_DocPendientes)
        Dim E_PlanCtas As New SG_CO_TB_PLANCTAS With {.PC_IDCUENTA = uc_Cuentas.Value}
        Dim PlanCtasBL As New BL.ContabilidadBL.SG_CO_TB_PLANCTAS
        PlanCtasBL.getCuenta(E_PlanCtas)
        Dim Int_TipoAnexo_local As Integer
        Int_TipoAnexo_local = 0
        If Not E_PlanCtas.PC_IDTIPO_ANEXO Is Nothing Then
            Int_TipoAnexo_local = E_PlanCtas.PC_IDTIPO_ANEXO.TA_CODIGO
        End If

        If txt_Anexo_Det.Text.Trim.Length = 0 Then
            GoTo primeraOpcion
        End If

        'si el anexo existe y esta validado saltamos a mostrar la ventana
        'de documentos pendientes!

        Dim Obj_AnexoBL As New BL.ContabilidadBL.SG_CO_TB_ANEXO
        Dim Obj_TipoAnexoBL As New BL.ContabilidadBL.SG_CO_TB_TIPOANEXO

        Dim E_Anexo As New SG_CO_TB_ANEXO

        E_Anexo.AN_IDEMPRESA = New SG_CO_TB_EMPRESA With {.EM_ID = gInt_IdEmpresa}
        E_Anexo.AN_TIPO_ANEXO = New SG_CO_TB_TIPOANEXO With {.TA_CODIGO = Int_TipoAnexo_local}
        E_Anexo.AN_NUM_DOC = txt_Anexo_Det.Text.Trim
        Obj_AnexoBL.getAnexo_x_Ruc(E_Anexo)

        If E_Anexo.AN_DESCRIPCION.Length = 0 Then
            lbl_Des_Anexo.Text = "*El anexo no existe."
            txt_idAnexoDet.Text = String.Empty
            GoTo primeraOpcion
        Else
            lbl_Des_Anexo.Text = E_Anexo.AN_DESCRIPCION
            txt_idAnexoDet.Text = E_Anexo.AN_IDANEXO
            GoTo segundaOpcion
        End If


primeraOpcion:
        CO_MT_Buscar.Int_Opcion = 4
        CO_MT_Buscar.Int_TipoAnexo = Int_TipoAnexo_local
        CO_MT_Buscar.ShowDialog()

        Dim matriz As List(Of String) = CO_MT_Buscar.GetLista

        If matriz.Count > 0 Then
            txt_Anexo_Det.Text = matriz(2)
            txt_idAnexoDet.Text = matriz(0)
            lbl_Des_Anexo.Text = matriz(3)
        Else
            txt_cod_Doc_Det.Focus()
            Exit Sub
        End If



segundaOpcion:
        CO_PR_DocPendientes.Str_Cuenta = uc_Cuentas.Text.Trim
        CO_PR_DocPendientes.Int_Anexo = txt_idAnexoDet.Text.Trim
        CO_PR_DocPendientes.ShowDialog()

        If CO_PR_DocPendientes.Bol_Aceptar Then

Saltar_punto1:

            ListaDocPendiente = CO_PR_DocPendientes.getListaDocs
            txt_cod_Doc_Det.Text = ListaDocPendiente(0).tdoc
            uce_TipoDoc_Det.Value = ListaDocPendiente(0).tdoc
            txt_SerieDoc_Det.Text = ListaDocPendiente(0).sdoc

            If txt_cod_Doc_Det.Text.Trim.Length > 0 And txt_idAnexoDet.Text.Trim.Length > 0 Then
                txt_NumDoc_Det.Text = ListaDocPendiente(0).ndoc.ToString
            Else
                txt_NumDoc_Det.Text = ListaDocPendiente(0).ndoc.ToString.Trim.PadLeft(10, "0")
            End If


            ume_Debe_Det.Value = ListaDocPendiente(0).haber
            ume_Haber_Det.Value = ListaDocPendiente(0).debe
            txt_Cod_Mon_Det.Text = "1"
            uce_Moneda_Det.Value = "1"
            ume_ValorTipoCambio_Det.Value = ume_ValorTipoCambio.Value


            If ListaDocPendiente(0).fecha = "" Then
                ume_FecEmi_Det.Value = DBNull.Value
            Else
                ume_FecEmi_Det.Value = ListaDocPendiente(0).fecha
            End If

            ume_Debe_Det.Focus()
        Else
            txt_cod_Doc_Det.Focus()
        End If

    End Sub

    Private Sub Ayuda_Proveedor_Cab()

        Dim E_PlanCtas As New SG_CO_TB_PLANCTAS With {.PC_IDCUENTA = uc_Cuentas.Value}
        Dim PlanCtasBL As New BL.ContabilidadBL.SG_CO_TB_PLANCTAS
        PlanCtasBL.getCuenta(E_PlanCtas)
        Dim Int_TipoAnexo_local As Integer
        Int_TipoAnexo_local = 0
        If Not E_PlanCtas.PC_IDTIPO_ANEXO Is Nothing Then
            Int_TipoAnexo_local = E_PlanCtas.PC_IDTIPO_ANEXO.TA_CODIGO
        End If

        If txt_Anexo_Det.Text.Trim.Length = 0 Then
            GoTo primeraOpcion
        End If

        'si el anexo existe y esta validado saltamos a mostrar la ventana
        'de documentos pendientes!

        Dim Obj_AnexoBL As New BL.ContabilidadBL.SG_CO_TB_ANEXO
        Dim Obj_TipoAnexoBL As New BL.ContabilidadBL.SG_CO_TB_TIPOANEXO

        Dim E_Anexo As New SG_CO_TB_ANEXO

        E_Anexo.AN_IDEMPRESA = New SG_CO_TB_EMPRESA With {.EM_ID = gInt_IdEmpresa}
        E_Anexo.AN_TIPO_ANEXO = New SG_CO_TB_TIPOANEXO With {.TA_CODIGO = Int_TipoAnexo_local}
        E_Anexo.AN_NUM_DOC = txt_Anexo_Det.Text.Trim
        Obj_AnexoBL.getAnexo_x_Ruc(E_Anexo)

        If E_Anexo.AN_DESCRIPCION.Length = 0 Then
            lbl_Des_Anexo.Text = "*El anexo no existe."
            txt_idAnexoDet.Text = String.Empty
            GoTo primeraOpcion
        Else
            lbl_Des_Anexo.Text = E_Anexo.AN_DESCRIPCION
            txt_idAnexoDet.Text = E_Anexo.AN_IDANEXO
            GoTo segundaOpcion
        End If


primeraOpcion:
        CO_MT_Buscar.Int_Opcion = 4
        CO_MT_Buscar.Int_TipoAnexo = Int_TipoAnexo_local
        CO_MT_Buscar.ShowDialog()

        Dim matriz As List(Of String) = CO_MT_Buscar.GetLista

        If matriz.Count > 0 Then
            txt_Anexo_Det.Text = matriz(2)
            txt_idAnexoDet.Text = matriz(0)
            lbl_Des_Anexo.Text = matriz(3)
        Else
            Exit Sub
        End If



segundaOpcion:
        CO_PR_DocPendientes.Str_Cuenta = uc_Cuentas.Text.Trim
        CO_PR_DocPendientes.Int_Anexo = txt_idAnexoDet.Text.Trim
        CO_PR_DocPendientes.ShowDialog()

        Dim DetalleBL As New BL.ContabilidadBL.SG_CO_TB_ASIENTO_CONTABLE

        If CO_PR_DocPendientes.Bol_Aceptar Then
            If CO_PR_DocPendientes.getListaDocs.Count > 0 Then
                ListaDocPendiente = CO_PR_DocPendientes.getListaDocs
                txt_cod_Doc_Det.Text = ListaDocPendiente(0).tdoc
                uce_TipoDoc_Det.Value = ListaDocPendiente(0).tdoc
                txt_SerieDoc_Det.Text = ListaDocPendiente(0).sdoc
                txt_NumDoc_Det.Text = ListaDocPendiente(0).ndoc.ToString.Trim '.PadLeft(10, "0")

                'Busco por el Id del Detalle si es en Dolares.

                Dim DetalleBE As New BE.ContabilidadBE.SG_CO_TB_ASIENTO_DET
                Dim DetalleBE2 As New BE.ContabilidadBE.SG_CO_TB_ASIENTO_DET
                Dim Bol_EsDolar As Boolean = False

                DetalleBE.AD_IDCAB = New SG_CO_TB_ASIENTO_CAB With {.AC_ID = ListaDocPendiente(0).ID_MIN}
                DetalleBE.AD_TDOC = New SG_CO_TB_DOCUMENTO With {.DO_CODIGO = txt_cod_Doc_Det.Text}
                DetalleBE.AD_SDOC = txt_SerieDoc_Det.Text
                DetalleBE.AD_NDOC = txt_NumDoc_Det.Text
                DetalleBE.AD_CUENTA = uc_Cuentas.Text.Trim
                DetalleBE.AD_IDANEXO = New SG_CO_TB_ANEXO With {.AN_IDANEXO = txt_idAnexoDet.Text.Trim}


                Try
                    'aqui se deberia agregar el año y empresa para traer el detalle 
                    'en algun momento el id del detalle podria repetirse


                    DetalleBE2 = DetalleBL.getDetalle_x_Id(DetalleBE)
                Catch ex As Exception
                    GoTo Saltar_punto1
                End Try


                If DetalleBE2 Is Nothing Then
                    GoTo Saltar_punto1
                End If

                Bol_EsDolar = False
                If DetalleBE2.AD_TCAM > 0 Then Bol_EsDolar = Not Bol_EsDolar

                'Si es Dolares Cargo los datos con el importe en dolares
                If Bol_EsDolar Then
                    If ListaDocPendiente(0).haber > 0 Then
                        ume_Debe_Det.Value = DetalleBE2.AD_MONTO_ORI
                        ume_Haber_Det.Value = 0
                    Else
                        ume_Debe_Det.Value = 0
                        ume_Haber_Det.Value = DetalleBE2.AD_MONTO_ORI
                    End If

                    txt_Cod_Mon_Det.Text = "2"
                    uce_Moneda_Det.Value = "2"

                    ume_ValorTipoCambio_Det.Value = DetalleBE2.AD_TCAM

                Else
Saltar_punto1:
                    ume_Debe_Det.Value = ListaDocPendiente(0).haber
                    ume_Haber_Det.Value = ListaDocPendiente(0).debe
                    txt_Cod_Mon_Det.Text = "1"
                    uce_Moneda_Det.Value = "1"
                    ume_ValorTipoCambio_Det.Value = ume_ValorTipoCambio.Value

                End If

                If ListaDocPendiente(0).fecha = "" Then
                    ume_FecEmi_Det.Value = DBNull.Value
                Else
                    ume_FecEmi_Det.Value = ListaDocPendiente(0).fecha
                End If

                If ListaDocPendiente.Count > 1 Then
                    For i As Integer = 0 To ListaDocPendiente.Count - 1
                        Dim Str_doc As String = ""

                        If gInt_IdEmpresa = 1 Then
                            If ListaDocPendiente(i).tdoc.Length = 0 Then
                                Str_doc = ListaDocPendiente(i).tdoc & ListaDocPendiente(i).sdoc & ListaDocPendiente(i).ndoc.ToString.Trim
                            Else
                                Str_doc = ListaDocPendiente(i).tdoc.Substring(0, 3) & " - " & ListaDocPendiente(i).sdoc & " - " & ListaDocPendiente(i).ndoc.ToString.Trim
                            End If

                        Else
                            Str_doc = ListaDocPendiente(i).tdoc.Substring(0, 3) & " - " & ListaDocPendiente(i).sdoc & " - " & ListaDocPendiente(i).ndoc.ToString.Trim.PadLeft(10, "0")
                        End If


                        Dim Dbl_importe As Double = IIf(ListaDocPendiente(i).debe > 0, ListaDocPendiente(i).debe, ListaDocPendiente(i).haber)
                        lv_Doc_En_Cola.Items.Add(Str_doc, 1)
                        lv_Doc_En_Cola.Items(i).SubItems.Add(Dbl_importe)
                    Next
                    ugb_docCola.Visible = True
                End If
                ume_Debe_Det.Focus()


            End If
        Else
            'si el usuario cancela la ventana de doc. pendientes(click en Cancelar)
            'se asume que es una provision de anticipos

            'cuentas de anticipos a proveedores y medicos
            If uc_Cuentas.Text = "422001" Or uc_Cuentas.Text = "422002" Then
                txt_cod_Doc_Det.Text = "22"
                uce_TipoDoc_Det.Value = "22"
                txt_SerieDoc_Det.Text = CDate(udte_fec_Vou.Value).Year.ToString
                txt_NumDoc_Det.Text = DetalleBL.get_Ultimo_num_anticipo(CDate(udte_fec_Vou.Value).Year, gInt_IdEmpresa)
                ume_FecEmi_Det.Value = udte_fec_Vou.Value
            End If

            txt_cod_Doc_Det.Focus()

        End If

        DetalleBL = Nothing

    End Sub


    Private Sub uchk_Ocultar_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles uchk_Ocultar.CheckedChanged
        Ocultar_Columnas(uchk_Ocultar.Checked)
    End Sub

    Private Sub ug_asiento_AfterRowsDeleted(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ug_asiento.AfterRowsDeleted

        Call ReHacerSecuencia()
        ug_asiento.UpdateData()

        Call Sum_Tot()
        ug_asiento.Focus()

        If ug_asiento.Rows.Count > 0 Then
            ug_asiento.Focus()
            If Int_Posicion_fila_Insertar > 0 Then
                If Int_Posicion_fila_Insertar >= ug_asiento.Rows.Count Then
                    ug_asiento.Rows(Int_Posicion_fila_Insertar - 1).Activate()
                    ug_asiento.Rows(Int_Posicion_fila_Insertar - 1).Selected = True
                Else
                    ug_asiento.Rows(Int_Posicion_fila_Insertar).Activate()
                    ug_asiento.Rows(Int_Posicion_fila_Insertar).Selected = True
                End If
                
            Else
                ug_asiento.Rows(0).Activate()
                ug_asiento.Rows(0).Selected = True
            End If
            
        End If

    End Sub
    Private Sub ug_asiento_BeforeRowsDeleted(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.BeforeRowsDeletedEventArgs) Handles ug_asiento.BeforeRowsDeleted
        Int_Posicion_fila_Insertar = ug_asiento.ActiveRow.Index
        e.DisplayPromptMsg = False
        e.Cancel = False

    End Sub

    Private Sub ReHacerSecuencia()
        For i As Integer = 0 To ug_asiento.Rows.Count - 1
            ug_asiento.Rows(i).Cells("Item").Value = (i + 1).ToString.PadLeft("3", "0")
        Next
        ug_asiento.UpdateData()

    End Sub


    Public Sub CargarVoucher_toEdit(ByVal Ent_cabecera As BE.ContabilidadBE.SG_CO_TB_ASIENTO_CAB)
        Try
            Bol_Edicion = True
            Int_IdCab_Edit = Ent_cabecera.AC_ID
            Dim Ds_Voucher As DataSet = Obj_Voucher.getVouchers_x_Id(Ent_cabecera)
            '____________________________________________________________________________Llenamos la cabecera

            If Ds_Voucher.Tables(0).Rows.Count > 0 Then '__________________________Tabla Cabecera
                With Ds_Voucher.Tables(0).Rows(0)
                    uce_Subdiario.Value = .Item("AC_IDSUBDIARIO")
                    txt_Num_Voucher.Text = .Item("AC_NUM_VOUCHER")
                    uce_TipoCambio.Value = .Item("AC_TC_FORMATO")
                    ume_ValorTipoCambio.Value = .Item("AC_TC_OPE")
                    txt_Glosa.Text = .Item("AC_GLOSA_VOU")
                    udte_fec_Vou.Value = .Item("AC_FEC_VOUCHER")
                End With
            End If

            '____________________________________________________________________________Llenamos el detalle

            Call LimpiaGrid(ug_asiento, uds_Asiento)


            If Ds_Voucher.Tables(1).Rows.Count > 0 Then
                With Ds_Voucher.Tables(1)
                    For i As Integer = 0 To .Rows.Count - 1
                        ug_asiento.DisplayLayout.Bands(0).AddNew()
                        Dim Int_NumFilas As Integer = ug_asiento.Rows.Count
                        '
                        ug_asiento.Rows(i).Cells("Item").Value = .Rows(i)("AD_SECUENCIA").ToString.PadLeft("3", "0")
                        ug_asiento.Rows(i).Cells("Cuenta").Value = .Rows(i)("ad_cuenta").ToString

                        Dim Obj_PlanCtas As New BL.ContabilidadBL.SG_CO_TB_PLANCTAS
                        Dim E_PlanCtas As New BE.ContabilidadBE.SG_CO_TB_PLANCTAS
                        E_PlanCtas.PC_IDEMPRESA = New SG_CO_TB_EMPRESA With {.EM_ID = gInt_IdEmpresa}
                        E_PlanCtas.PC_PERIODO = gDat_Fecha_Sis.Year
                        E_PlanCtas.PC_NUM_CUENTA = .Rows(i)("ad_cuenta").ToString

                        Obj_PlanCtas.getCuenta_X_NumeroCta(E_PlanCtas)

                        If Not E_PlanCtas.PC_IDTIPO_ANEXO Is Nothing Then
                            Dim AnexoBL As New BL.ContabilidadBL.SG_CO_TB_ANEXO
                            Dim AnexoBE As New BE.ContabilidadBE.SG_CO_TB_ANEXO
                            If .Rows(i)("AD_IDANEXO").ToString <> "" Then
                                AnexoBE.AN_IDANEXO = .Rows(i)("AD_IDANEXO")
                                AnexoBL.getAnexo(AnexoBE)

                                ug_asiento.Rows(i).Cells("Descripcion").Value = AnexoBE.AN_DESCRIPCION
                            Else
                                ug_asiento.Rows(i).Cells("Descripcion").Value = E_PlanCtas.PC_DESCRIPCION
                            End If
                            
                            AnexoBE = Nothing
                            AnexoBL = Nothing
                        Else
                            ug_asiento.Rows(i).Cells("Descripcion").Value = E_PlanCtas.PC_DESCRIPCION
                        End If

                        ug_asiento.Rows(i).Cells("TipoAnexo").Value = .Rows(i)("AD_TANEXO").ToString

                        If Not Ds_Voucher.Tables(1).Rows(i)("AD_FDOC").ToString.Trim.Length = 0 Then
                            ug_asiento.Rows(i).Cells("Fecha Emi").Value = CDate(Ds_Voucher.Tables(1).Rows(i)("AD_FDOC")).ToShortDateString
                        End If

                        If Not Ds_Voucher.Tables(1).Rows(i)("AD_VDOC").ToString.Trim.Length = 0 Then
                            ug_asiento.Rows(i).Cells("Fecha ven").Value = CDate(Ds_Voucher.Tables(1).Rows(i)("AD_VDOC")).ToShortDateString
                        End If

                        ug_asiento.Rows(i).Cells("Tip_Doc").Value = .Rows(i)("AD_TDOC").ToString
                        ug_asiento.Rows(i).Cells("Serie").Value = .Rows(i)("AD_SDOC").ToString
                        ug_asiento.Rows(i).Cells("Numero").Value = .Rows(i)("AD_NDOC").ToString
                        ug_asiento.Rows(i).Cells("Anexo").Value = .Rows(i)("AD_IDANEXO").ToString
                        If .Rows(i)("AD_DEBE") > 0 Then
                            ug_asiento.Rows(i).Cells("Debe").Value = Convert.ToDouble(.Rows(i)("AD_DEBE")).ToString("##,##0.00")
                        End If

                        If .Rows(i)("AD_HABER") > 0 Then
                            ug_asiento.Rows(i).Cells("Haber").Value = Convert.ToDouble(.Rows(i)("AD_HABER")).ToString("##,##0.00")
                        End If

                        If .Rows(i)("AD_TCAM") > 0 Then
                            ug_asiento.Rows(i).Cells("TipoCam").Value = .Rows(i)("AD_TCAM")
                        Else
                            ug_asiento.Rows(i).Cells("TipoCam").Value = Nothing
                        End If

                        ug_asiento.Rows(i).Cells("Glosa").Value = .Rows(i)("AD_GLOSA").ToString
                        ug_asiento.Rows(i).Cells("Es_Destino").Value = .Rows(i)("AD_ES_DESTINO").ToString
                        ug_asiento.Rows(i).Cells("cc_id").Value = IIf(.Rows(i)("AD_IDCC").ToString.Equals(String.Empty), 0, .Rows(i)("AD_IDCC"))
                        ug_asiento.Rows(i).Cells("Soles").Value = .Rows(i)("AD_MONTO_ORI")
                        ug_asiento.Rows(i).Cells("porce_destino").Value = .Rows(i)("AD_PORCE_DESTINO")

                        If .Rows(i)("AD_SEC_ORI_DESTINO") <> 0 Then
                            ug_asiento.Rows(i).Cells("Sec_Ori_Destino").Value = .Rows(i)("AD_SEC_ORI_DESTINO").ToString.PadLeft("3", "0")
                        Else
                            ug_asiento.Rows(i).Cells("Sec_Ori_Destino").Value = .Rows(i)("AD_SEC_ORI_DESTINO")
                        End If



                        ' si todo esta ok actualizamos la data confirmandola!
                        ug_asiento.UpdateData()
                    Next
                End With
            End If

            Call Sum_Tot()

            btn_Nuevo.Enabled = True
            'ugb_Cabecera.Enabled = False
            Call MostrarTabs(0, utc_Asiento, 0)

        Catch ex As Exception
            Throw ex
        End Try
    End Sub


    Public Sub CargarVoucher_to_Copy(ByVal Ent_cabecera As BE.ContabilidadBE.SG_CO_TB_ASIENTO_CAB)
        Try
            Bol_Edicion = False
            Bol_Copy = True
            Int_IdCab_Edit = Ent_cabecera.AC_ID
            Dim Ds_Voucher As DataSet = Obj_Voucher.getVouchers_x_Id(Ent_cabecera)
            '____________________________________________________________________________Llenamos la cabecera

            If Ds_Voucher.Tables(0).Rows.Count > 0 Then '__________________________Tabla Cabecera
                With Ds_Voucher.Tables(0).Rows(0)
                    uce_Subdiario.Value = .Item("AC_IDSUBDIARIO")
                    'txt_Num_Voucher.Text = .Item("AC_NUM_VOUCHER")
                    uce_TipoCambio.Value = .Item("AC_TC_FORMATO")
                    ume_ValorTipoCambio.Value = .Item("AC_TC_OPE")
                    txt_Glosa.Text = .Item("AC_GLOSA_VOU")
                    udte_fec_Vou.Value = .Item("AC_FEC_VOUCHER")
                End With
            End If

            '____________________________________________________________________________Llenamos el detalle

            Call LimpiaGrid(ug_asiento, uds_Asiento)


            If Ds_Voucher.Tables(1).Rows.Count > 0 Then
                With Ds_Voucher.Tables(1)
                    For i As Integer = 0 To .Rows.Count - 1
                        ug_asiento.DisplayLayout.Bands(0).AddNew()
                        Dim Int_NumFilas As Integer = ug_asiento.Rows.Count
                        '
                        ug_asiento.Rows(i).Cells("Item").Value = .Rows(i)("AD_SECUENCIA").ToString.PadLeft("3", "0")
                        ug_asiento.Rows(i).Cells("Cuenta").Value = .Rows(i)("ad_cuenta").ToString

                        Dim Obj_PlanCtas As New BL.ContabilidadBL.SG_CO_TB_PLANCTAS
                        Dim E_PlanCtas As New BE.ContabilidadBE.SG_CO_TB_PLANCTAS
                        E_PlanCtas.PC_IDEMPRESA = New SG_CO_TB_EMPRESA With {.EM_ID = gInt_IdEmpresa}
                        E_PlanCtas.PC_PERIODO = gDat_Fecha_Sis.Year
                        E_PlanCtas.PC_NUM_CUENTA = .Rows(i)("ad_cuenta").ToString

                        Obj_PlanCtas.getCuenta_X_NumeroCta(E_PlanCtas)

                        If Not E_PlanCtas.PC_IDTIPO_ANEXO Is Nothing Then

                            Dim AnexoBL As New BL.ContabilidadBL.SG_CO_TB_ANEXO
                            Dim AnexoBE As New BE.ContabilidadBE.SG_CO_TB_ANEXO
                            AnexoBE.AN_IDANEXO = .Rows(i)("AD_IDANEXO")
                            AnexoBL.getAnexo(AnexoBE)

                            ug_asiento.Rows(i).Cells("Descripcion").Value = AnexoBE.AN_DESCRIPCION
                            AnexoBE = Nothing
                            AnexoBL = Nothing

                        Else
                            ug_asiento.Rows(i).Cells("Descripcion").Value = E_PlanCtas.PC_DESCRIPCION
                        End If

                        ug_asiento.Rows(i).Cells("TipoAnexo").Value = .Rows(i)("AD_TANEXO").ToString

                        If Not Ds_Voucher.Tables(1).Rows(i)("AD_FDOC").ToString.Trim.Length = 0 Then
                            ug_asiento.Rows(i).Cells("Fecha Emi").Value = CDate(Ds_Voucher.Tables(1).Rows(i)("AD_FDOC")).ToShortDateString
                        End If

                        If Not Ds_Voucher.Tables(1).Rows(i)("AD_VDOC").ToString.Trim.Length = 0 Then
                            ug_asiento.Rows(i).Cells("Fecha ven").Value = CDate(Ds_Voucher.Tables(1).Rows(i)("AD_VDOC")).ToShortDateString
                        End If

                        ug_asiento.Rows(i).Cells("Tip_Doc").Value = .Rows(i)("AD_TDOC").ToString
                        ug_asiento.Rows(i).Cells("Serie").Value = .Rows(i)("AD_SDOC").ToString
                        ug_asiento.Rows(i).Cells("Numero").Value = .Rows(i)("AD_NDOC").ToString
                        ug_asiento.Rows(i).Cells("Anexo").Value = .Rows(i)("AD_IDANEXO").ToString
                        If .Rows(i)("AD_DEBE") > 0 Then
                            ug_asiento.Rows(i).Cells("Debe").Value = Convert.ToDouble(.Rows(i)("AD_DEBE")).ToString("##,##0.00")
                        End If

                        If .Rows(i)("AD_HABER") > 0 Then
                            ug_asiento.Rows(i).Cells("Haber").Value = Convert.ToDouble(.Rows(i)("AD_HABER")).ToString("##,##0.00")
                        End If

                        If .Rows(i)("AD_TCAM") > 0 Then
                            ug_asiento.Rows(i).Cells("TipoCam").Value = .Rows(i)("AD_TCAM")
                        Else
                            ug_asiento.Rows(i).Cells("TipoCam").Value = Nothing
                        End If

                        ug_asiento.Rows(i).Cells("Glosa").Value = .Rows(i)("AD_GLOSA").ToString
                        ug_asiento.Rows(i).Cells("Es_Destino").Value = .Rows(i)("AD_ES_DESTINO").ToString
                        ug_asiento.Rows(i).Cells("cc_id").Value = IIf(.Rows(i)("AD_IDCC").ToString.Equals(String.Empty), 0, .Rows(i)("AD_IDCC"))
                        ug_asiento.Rows(i).Cells("Soles").Value = .Rows(i)("AD_MONTO_ORI")
                        ug_asiento.Rows(i).Cells("porce_destino").Value = .Rows(i)("AD_PORCE_DESTINO")

                        ' si todo esta ok actualizamos la data confirmandola!
                        ug_asiento.UpdateData()
                    Next
                End With
            End If

            Call Sum_Tot()
            Call MostrarTabs(0, utc_Asiento, 0)
            btn_Nuevo.Enabled = True

        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub ug_asiento_DoubleClickRow(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.DoubleClickRowEventArgs) Handles ug_asiento.DoubleClickRow
        Call EditarDetalle()
    End Sub

    Private Sub EditarDetalle()
        Try
            If ug_asiento.ActiveRow Is Nothing Then Exit Sub

            Call LimpiarDetalle()
            With ug_asiento.ActiveRow
                uc_Cuentas.Text = .Cells("Cuenta").Value.ToString
                Call Boxes_to_Enable(uc_Cuentas.Text)

                txt_Anexo_Det.Text = String.Empty
                lbl_Des_Anexo.Text = String.Empty
                If Not .Cells("Anexo").Value.ToString = String.Empty Then
                    Dim AnexoBL As New BL.ContabilidadBL.SG_CO_TB_ANEXO
                    Dim E_Anexo As New BE.ContabilidadBE.SG_CO_TB_ANEXO

                    E_Anexo.AN_IDANEXO = ug_asiento.ActiveRow.Cells("Anexo").Value
                    AnexoBL.getAnexo(E_Anexo)

                    txt_idAnexoDet.Text = E_Anexo.AN_IDANEXO
                    txt_Anexo_Det.Text = E_Anexo.AN_NUM_DOC
                    lbl_Des_Anexo.Text = E_Anexo.AN_DESCRIPCION

                    E_Anexo = Nothing
                    AnexoBL = Nothing
                End If

                uce_TipoDoc_Det.Value = .Cells("Tip_Doc").Value.ToString
                txt_SerieDoc_Det.Text = .Cells("Serie").Value.ToString
                txt_NumDoc_Det.Text = .Cells("Numero").Value.ToString

                If (.Cells("Fecha Emi").Value.ToString.Equals(String.Empty)) Then
                    ume_FecEmi_Det.Value = Nothing
                Else
                    If IsDate(.Cells("Fecha Emi").Value) Then
                        ume_FecEmi_Det.Value = CDate(.Cells("Fecha Emi").Value)
                    Else
                        ume_FecEmi_Det.Value = Nothing
                    End If
                End If

                If (.Cells("Fecha Emi").Value.ToString.Equals(String.Empty)) Then
                    ume_FecVen_Det.Value = Nothing
                Else
                    If IsDate(.Cells("Fecha ven").Value) Then
                        ume_FecVen_Det.Value = CDate(.Cells("Fecha ven").Value)
                    Else
                        ume_FecVen_Det.Value = Nothing
                    End If
                End If

                ume_Debe_Det.Value = IIf(.Cells("Debe").Value.ToString.Equals(String.Empty), 0, .Cells("Soles").Value.ToString)
                ume_Haber_Det.Value = IIf(.Cells("Haber").Value.ToString.Equals(String.Empty), 0, .Cells("Soles").Value.ToString)

                If .Cells("TipoCam").Value.ToString.Equals(String.Empty) Then
                    uce_Moneda_Det.Value = 1
                    ume_ValorTipoCambio_Det.Value = 0
                Else
                    uce_Moneda_Det.Value = 2
                    ume_ValorTipoCambio_Det.Value = .Cells("TipoCam").Value
                End If

                uce_cc.Value = .Cells("cc_id").Value.ToString
                txt_Glosa_Det.Text = .Cells("Glosa").Value.ToString

                utc_Asiento.Height = 202

                If txt_Anexo_Det.Enabled Then
                    txt_Anexo_Det.Focus()
                Else
                    txt_cod_Doc_Det.Focus()
                End If
                ugb_detalle.Visible = True
                Bol_NuevoDet = False

            End With
        Catch ex As Exception
            ShowError("Ocurrio un error:  " & ex.Message)
        End Try
    End Sub

    Public Sub Boxes_to_Enable(ByVal Str_MyCuenta As String)
        Try
            Dim PlanCtasBL As New BL.ContabilidadBL.SG_CO_TB_PLANCTAS
            Dim E_PlanCtas As New BE.ContabilidadBE.SG_CO_TB_PLANCTAS

            E_PlanCtas.PC_IDEMPRESA = New SG_CO_TB_EMPRESA With {.EM_ID = gInt_IdEmpresa}
            E_PlanCtas.PC_PERIODO = gDat_Fecha_Sis.Year
            E_PlanCtas.PC_NUM_CUENTA = Str_MyCuenta.Trim
            PlanCtasBL.getCuenta_X_NumeroCta(E_PlanCtas)

            lbl_des_cta.Text = E_PlanCtas.PC_DESCRIPCION

            If E_PlanCtas.PC_IDTIPO_ANEXO Is Nothing Then
                txt_Anexo_Det.Enabled = False
            Else
                txt_Anexo_Det.Enabled = True
            End If

            If E_PlanCtas.PC_ES_CC = 1 Then
                uce_cc.Enabled = True
            Else
                uce_cc.SelectedIndex = -1
                uce_cc.Enabled = False
            End If


        Catch ex As Exception
            Throw ex
        End Try
    End Sub


    Private Sub ubtn_CrearAnexo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ubtn_CrearAnexo.Click
        Try
            CO_PR_Reg_AnexoNuevo.ShowDialog()
            If CO_PR_Reg_AnexoNuevo.GetBol_Aceptar Then
                txt_Anexo_Det.Text = CO_PR_Reg_AnexoNuevo.GetE_Anexo.AN_NUM_DOC
                txt_idAnexoDet.Text = CO_PR_Reg_AnexoNuevo.GetE_Anexo.AN_IDANEXO
                lbl_Des_Anexo.Text = CO_PR_Reg_AnexoNuevo.GetE_Anexo.AN_DESCRIPCION
            End If
        Catch ex As Exception
            ShowError(ex.Message)
        End Try

    End Sub

    Private Sub ubtn_Impresion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ubtn_Impresion.Click
        Try
            If txt_IdCabecera.Text.Trim.Length = 0 Then Exit Sub
            Call Ver_Impresion_Voucher(udte_fec_Vou.Value, "Generales", uce_SubDiario.Text, txt_Num_Voucher.Text, txt_Glosa.Text, txt_IdCabecera.Text)
        Catch ex As Exception
            ShowError(ex.Message)
        End Try
    End Sub


    Private Sub txt_Num_Voucher_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_Num_Voucher.KeyDown
        If e.KeyCode = Keys.F9 Then uchk_Ocultar.Visible = Not uchk_Ocultar.Visible
    End Sub

    Private Sub uce_cc_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles uce_cc.KeyDown
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send(vbTab)
        End If
    End Sub

    Private Sub udte_fec_Vou_Validated(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles udte_fec_Vou.Validated
        'Validamos que el año no este cerrado
        If Verificar_Anho_Cerrado(CDate(udte_fec_Vou.Value).Year) Then
            udte_fec_Vou.SelectAll()
            udte_fec_Vou.Focus()
            Exit Sub
        End If
    End Sub

    Private Sub ug_asiento_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles ug_asiento.KeyDown
        If e.KeyCode = Keys.Insert Then
            Bol_Insertar_Detalle_Medio = True
            Int_Posicion_fila_Insertar = ug_asiento.ActiveRow.Index + 1
            Call IngresarFilas()
        End If
    End Sub
End Class