Imports Infragistics.Win.UltraWinGrid

Public Class FA_PR_Emi_ComproBot

    Dim Direccion As String
    'Dim imp_min_bol As Double = 700 'importe minimo para boletas en el caso que se pida DNI
    Public bol_nuevo As Boolean = True
    Public bol_cal As Boolean = True

    Private Sub pKeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles MyBase.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Return) Then
            SendKeys.Send("{TAB}")
            e.Handled = True
        End If
    End Sub
    Private Sub pLostfocus(ByVal sender As Object, ByVal e As System.EventArgs)
        sender.BackColor = Color.White
        If sender.Text.Trim.Length < 1 Then
            sender.BackColor = Color.LightPink
        End If
    End Sub
    Private Sub pKeyPressNumero(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_IdCuenta.KeyPress
        e.KeyChar = fKeyPress(e.KeyChar, sender.Text, 1)
        e.Handled = (e.KeyChar = "")
    End Sub
    Private Sub pKeyPressNumeroD(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_PagoVariable2.KeyPress
        e.KeyChar = fKeyPress(e.KeyChar, sender.Text, 2)
        e.Handled = (e.KeyChar = "")
    End Sub
    Private Function Verificar_Estado_Caja() As Boolean
        Dim rpta As Boolean = False

        Dim cajaBL As New BL.FacturacionBL.SG_FA_TB_CAJA_CAB
        Dim dt_data As DataTable = cajaBL.get_Data_Caja3(CDate(gDat_Fecha_Sis).ToShortDateString, gInt_IdEmpresa)

        If dt_data.Rows.Count = 0 Then
            dt_data.Dispose()
            cajaBL = Nothing
            rpta = True
        End If

        dt_data.Dispose()

        Return rpta
    End Function

    Private Sub FA_PR_Emi_ComproBot_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Activated
        Me.Refresh()
    End Sub

    Private Sub FA_PR_Emi_ComproBot_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.KeyPreview = True


        If Verificar_Estado_Caja() And bol_nuevo Then
            Call Avisar("Falta Aperturar la caja para la fecha : " & gDat_Fecha_Sis.ToShortDateString)
            ugb_cabecera.Enabled = False
            ToolS_Mantenimiento.Enabled = False
            Exit Sub
        Else
            ugb_cabecera.Enabled = True
            ToolS_Mantenimiento.Enabled = True
        End If

        Cargar_Combos()

        txt_ruc_cliente.ButtonsRight(0).Appearance.Image = My.Resources._104
        'txt_NumDoc.ButtonsRight(0).Appearance.Image = My.Resources._16__Page_number_
        txt_Ruc_ClientesC.ButtonsRight(0).Appearance.Image = My.Resources._104

        txt_IdCuenta.ButtonsRight(0).Appearance.Image = My.Resources._104

        udte_fec_emi.Value = gDat_Fecha_Sis
        udte_fec_Ven.Value = gDat_Fecha_Sis

        Call Iniciar_Ventana()

        usb_compro.Panels("usp_usuario").Text = "Usuario : " & gStr_Usuario_Sis
        usb_compro.Panels("usp_usuario").Appearance.Image = My.Resources._16__User_
        ubtn_quitar.Appearance.Image = My.Resources._16__Delete_
        ubtn_agregar.Appearance.Image = My.Resources._16__Plus_
        txt_notas.ButtonsRight("btn_des_cli").Appearance.Image = My.Resources._16__Fill_left_
        txt_notas.ButtonsRight("btn_des_cli").Appearance.ImageHAlign = Infragistics.Win.HAlign.Center

    End Sub

    Public Sub Cargar_Comprobante_toEdit(ByVal entidad As BE.FacturacionBE.SG_FA_TB_COMPROBANTE_C)
        Try

            Dim comprobantesBL As New BL.FacturacionBL.SG_FA_TB_COMPROBANTE_C
            Dim ds_comprobante As New DataSet

            ds_comprobante = comprobantesBL.get_Comprobante_x_Id(entidad)

            With ds_comprobante.Tables(0)

                uce_PuntoVenta.Value = .Rows(0)("CO_IDPTOVTA")
                uce_TipoDoc.Value = .Rows(0)("CO_TDOC")
                uce_Serie.Value = .Rows(0)("CO_SDOC")
                txt_NumDoc.Value = .Rows(0)("CO_NDOC")
                txt_notas.Text = .Rows(0)("CO_NOTAS")
                txt_notas.Enabled = False
                txt_idClienteC.Value = .Rows(0)("CO_IDCLIENTE")
                txt_idHistoria.Value = Val(.Rows(0)("CO_IDNUM_HIST").ToString)
                Dim historiaBL As New BL.AdmisionBL.SG_AD_TB_HISTO_CLINI
                Dim dt_histo_tmp As DataTable = historiaBL.getHistorias_Base_x_Id(txt_idHistoria.Value, 1)

                If dt_histo_tmp.Rows.Count > 0 Then
                    txt_Des_Cliente.Text = dt_histo_tmp.Rows(0)("HC_APE_PAT") & " " & dt_histo_tmp.Rows(0)("HC_APE_MAT") & " " & dt_histo_tmp.Rows(0)("HC_NOMBRE1")
                    txt_ruc_cliente.Text = dt_histo_tmp.Rows(0)("HC_NDOC")
                    txt_IdCliente.Value = dt_histo_tmp.Rows(0)("HC_IDCLIENTE")
                    uce_tip_doc.Value = dt_histo_tmp.Rows(0)("HC_TDOC")
                End If

                Dim clienteBL As New BL.FacturacionBL.SG_FA_TB_CLIENTE
                Dim clienteBE As New BE.FacturacionBE.SG_FA_TB_CLIENTE

                clienteBE.CL_ID = txt_idClienteC.Value
                clienteBE.CL_IDEMPRESA = New BE.ContabilidadBE.SG_CO_TB_EMPRESA With {.EM_ID = gInt_IdEmpresa}
                clienteBL.get_Cliente_x_Id(clienteBE)

                txt_Des_ClienteC.Text = clienteBE.CL_NOMBRE
                txt_Ruc_ClientesC.Text = clienteBE.CL_NDOC

                clienteBE = Nothing
                clienteBL = Nothing

                uce_Moneda.Value = .Rows(0)("CO_IDMONEDA")
                ume_ValorTipoCambio.Value = .Rows(0)("CO_TCAM")
                ume_Tasa_Igv.Value = .Rows(0)("CO_TASA_IGV")
                uce_FormaPago.Value = .Rows(0)("CO_IDFORMA_PAGO")
                uce_docu_pago.Value = .Rows(0)("CO_IDDOCU_PAGO")
                txt_ref_pago.Text = .Rows(0)("CO_REF_PAGO")
                udte_fec_emi.Value = .Rows(0)("CO_FEC_EMI")
                udte_fec_Ven.Value = .Rows(0)("CO_FEC_VEN")
                txt_num_voucher_conta.Text = .Rows(0)("CO_NUMVOUCHER").ToString
                txt_IdComprobante.Text = .Rows(0)("CO_ID")
                ucm_Tipo.Value = .Rows(0)("CO_IDTIPO_ORI")
                uce_Medico.Value = .Rows(0)("CO_MEDICO")
                ucb_CentroCosto.Value = .Rows(0)("CO_CENTCOS")
                'txtSerieTicket.Text = .Rows(0)("CO_SERIET")
                'txt_NumeroTicket.Text = .Rows(0)("CO_NUMEROT")
            End With


            Call LimpiaGrid(ug_Detalle, uds_detalle)
            Dim idCuenta As Integer = 0
            'Detalle del Comprobante
            For i As Integer = 0 To ds_comprobante.Tables(1).Rows.Count - 1

                ug_Detalle.DisplayLayout.Bands(0).AddNew()

                With ds_comprobante.Tables(1)
                    ug_Detalle.Rows(i).Cells(0).Value = ds_comprobante.Tables(1).Rows(i)("CD_ITEM")
                    ug_Detalle.Rows(i).Cells("IdArticulo").Value = ds_comprobante.Tables(1).Rows(i)("CD_IDARTICULO")
                    ug_Detalle.Rows(i).Cells("DesArticulo").Value = ds_comprobante.Tables(1).Rows(i)("AR_DESCRIPCION")
                    ug_Detalle.Rows(i).Cells("CD_IDLOTE").Value = ds_comprobante.Tables(1).Rows(i)("CD_IDLOTE")
                    ug_Detalle.Rows(i).Cells("UM_VENTA").Value = ds_comprobante.Tables(1).Rows(i)("UM_DESCRIPCION")
                    ug_Detalle.Rows(i).Cells("Precio").Value = ds_comprobante.Tables(1).Rows(i)("CD_PRECIO")
                    ug_Detalle.Rows(i).Cells("DSCTO").Value = .Rows(i)("CD_DSCTO")
                    ug_Detalle.Rows(i).Cells("DSCTO_Por").Value = 0
                    ug_Detalle.Rows(i).Cells("DSCTO_OTRO").Value = Val(.Rows(i)("CD_DSCTO_OTRO").ToString)
                    ug_Detalle.Rows(i).Cells("Cant").Value = ds_comprobante.Tables(1).Rows(i)("CD_CANT")
                    ug_Detalle.Rows(i).Cells("SubTotal").Value = ds_comprobante.Tables(1).Rows(i)("CD_SUBTOTAL")
                    ug_Detalle.Rows(i).Cells("Impuesto").Value = ds_comprobante.Tables(1).Rows(i)("CD_IGV")
                    ug_Detalle.Rows(i).Cells("Total").Value = ds_comprobante.Tables(1).Rows(i)("CD_TOTAL")
                    ug_Detalle.Rows(i).Cells("CD_INAFECTO").Value = ds_comprobante.Tables(1).Rows(i)("AR_SIN_IGV")
                    ug_Detalle.Rows(i).Cells("DS_SALDO").Value = 0
                    ug_Detalle.Rows(i).Cells("AR_TIPO_ARTI").Value = Val(.Rows(i)("AR_TIPO_ARTI").ToString)
                    idCuenta = Val(.Rows(i)("CD_IDCUENTA").ToString)
                    txt_IdCuenta.Text = idCuenta
                End With
                ug_Detalle.UpdateData()

            Next
            txt_IdCuenta.Text = idCuenta
            Dim obeC As New BE.AdmisionBE.SG_AD_TB_CUENTA_CAB
            Dim obrC As New BL.AdmisionBL.SG_AD_TB_CUENTA_CAB
            obeC.CC_ID = Val(txt_IdCuenta.Text)
            obeC.HasRow = False
            obrC.SEL04(obeC)
            If obeC.HasRow Then
                With obeC
                    uchk_SeguroEps.Checked = IIf(.CC_IDTIPO_ATENC = 2, True, False)
                    ucm_SeguroEps.Value = .CC_IDSEGURO
                    txtIDSeguro.Text = IIf(.CC_IDSEGURO = "", "000", .CC_IDSEGURO)

                    txt_FijoC.Text = .CC_SIT_COPG_FIJO
                    txt_PagoVariable.Text = .CC_SIT_COPG_VARI
                    txt_PagoFijo.Text = Math.Round(Math.Round((.CC_SIT_COPG_FIJO * (ume_Tasa_Igv.Value / 100)), 2) + .CC_SIT_COPG_FIJO, 0)

                End With
            End If
            Call Calcular_Totales()

            If ds_comprobante.Tables(2).Rows(0)("CON") > 0 Then
                txt_doc_pago.Visible = True
                txt_doc_pago.Text = "Detallado"
            Else
                txt_doc_pago.Visible = False
                txt_doc_pago.Text = ""
            End If

            ds_comprobante = Nothing
            comprobantesBL = Nothing

            Tool_Nuevo.Enabled = False
            Tool_Grabar.Enabled = False
            Tool_Nuevo.Enabled = False
            Tool_Imprimir.Enabled = True
            ugb_cabecera.Enabled = False

            ubtn_agregar.Enabled = False
            ubtn_quitar.Enabled = False
            '  uce_Empresas.Enabled = False

        Catch ex As Exception
            ShowError("Ocurrio un problema " & ex.Message)
        End Try
    End Sub
    'Public Sub Cargar_Comprobante_para_NotCred(ByVal td_ As String, ByVal sd_ As String, ByVal nd_ As String)

    '    Dim comprobanteBL As New BL.FacturacionBL.SG_FA_TB_COMPROBANTE_C
    '    Dim comprobanteBE As New BE.FacturacionBE.SG_FA_TB_COMPROBANTE_C
    '    Dim ds_tmp As DataSet = Nothing

    '    comprobanteBE.CO_TDOC_REF = New BE.FacturacionBE.SG_FA_TB_DOCUMENTO With {.DO_CODIGO = td_}
    '    comprobanteBE.CO_SDOC_REF = sd_
    '    comprobanteBE.CO_NDOC_REF = nd_
    '    comprobanteBE.CO_IDEMPRESA = New BE.ContabilidadBE.SG_CO_TB_EMPRESA With {.EM_ID = gInt_IdEmpresa}

    '    ds_tmp = comprobanteBL.get_Comprobante_x_Num_Doc(comprobanteBE)

    '    comprobanteBL = Nothing
    '    comprobanteBE = Nothing


    '    If ds_tmp.Tables(0).Rows.Count = 0 Then Exit Sub

    '    With ds_tmp.Tables(0)

    '        txt_idClienteC.Value = .Rows(0)("CO_IDCLIENTE")
    '        txt_idHistoria.Value = Val(.Rows(0)("CO_IDNUM_HIST").ToString)

    '        Dim historiaBL As New BL.AdmisionBL.SG_AD_TB_HISTO_CLINI
    '        Dim dt_histo_tmp As DataTable = historiaBL.getHistorias_Base_x_Id(txt_idHistoria.Value, gInt_IdEmpresa)

    '        If dt_histo_tmp.Rows.Count > 0 Then
    '            txt_Des_Cliente.Text = dt_histo_tmp.Rows(0)("HC_APE_PAT") & " " & dt_histo_tmp.Rows(0)("HC_APE_MAT") & " " & dt_histo_tmp.Rows(0)("HC_NOMBRE1")
    '            txt_ruc_cliente.Text = dt_histo_tmp.Rows(0)("HC_NDOC")
    '            txt_IdCliente.Value = dt_histo_tmp.Rows(0)("HC_IDCLIENTE")
    '            uce_tip_doc.Value = dt_histo_tmp.Rows(0)("HC_TDOC")
    '        End If

    '        Dim clienteBL As New BL.FacturacionBL.SG_FA_TB_CLIENTE
    '        Dim clienteBE As New BE.FacturacionBE.SG_FA_TB_CLIENTE

    '        clienteBE.CL_ID = txt_idClienteC.Value
    '        clienteBE.CL_IDEMPRESA = New BE.ContabilidadBE.SG_CO_TB_EMPRESA With {.EM_ID = gInt_IdEmpresa}
    '        clienteBL.get_Cliente_x_Id(clienteBE)

    '        txt_Des_ClienteC.Text = clienteBE.CL_NOMBRE
    '        txt_Ruc_ClientesC.Text = clienteBE.CL_NDOC

    '        clienteBE = Nothing
    '        clienteBL = Nothing

    '        uce_Moneda.Value = .Rows(0)("CO_IDMONEDA")
    '        uce_FormaPago.Value = .Rows(0)("CO_IDFORMA_PAGO")
    '        uce_docu_pago.Value = .Rows(0)("CO_IDDOCU_PAGO")
    '        txt_ref_pago.Text = .Rows(0)("CO_REF_PAGO")

    '        txt_notas.Text = .Rows(0)("CO_NOTAS") & "  Doc. de Ref. : " & uce_TipDocRef.Text & "-" & txt_serie_ref.Text & "-" & txt_numero_ref.Text

    '    End With

    '    Call LimpiaGrid(ug_Detalle, uds_detalle)
    '    'ccr
    '    'Detalle del Comprobante
    '    For i As Integer = 0 To ds_tmp.Tables(1).Rows.Count - 1
    '        ug_Detalle.DisplayLayout.Bands(0).AddNew()

    '        With ds_tmp.Tables(1)

    '            ug_Detalle.Rows(i).Cells("Item").Value = .Rows(i)("CD_ITEM")
    '            ug_Detalle.Rows(i).Cells("Cant").Value = .Rows(i)("CD_CANT")
    '            ug_Detalle.Rows(i).Cells("IdArticulo").Value = .Rows(i)("CD_IDARTICULO")

    '            ug_Detalle.Rows(i).Cells("DesArticulo").Value = .Rows(i)("AR_DESCRIPCION")
    '            ug_Detalle.Rows(i).Cells("Precio").Value = .Rows(i)("CD_PRECIO")
    '            ug_Detalle.Rows(i).Cells("DSCTO").Value = .Rows(i)("CD_DSCTO")

    '            ug_Detalle.Rows(i).Cells("SubTotal").Value = .Rows(i)("CD_SUBTOTAL")
    '            ug_Detalle.Rows(i).Cells("Impuesto").Value = .Rows(i)("CD_IGV")
    '            ug_Detalle.Rows(i).Cells("Total").Value = .Rows(i)("CD_TOTAL")
    '            ug_Detalle.Rows(i).Cells("InIGV").Value = .Rows(i)("CD_INC_IGV")
    '            ug_Detalle.Rows(i).Cells("IDCUENTA").Value = Val(.Rows(i)("CD_IDCUENTA").ToString)
    '            ug_Detalle.Rows(i).Cells("CuentaItems").Value = Val(.Rows(i)("CD_CUENTA_ITEM").ToString)
    '            ug_Detalle.Rows(i).Cells("DSCTO_OTRO").Value = Val(.Rows(i)("CD_DSCTO_OTRO").ToString)

    '        End With

    '        ug_Detalle.UpdateData()

    '    Next
    '    Call Calcular_Totales()
    '    ds_tmp.Dispose()

    'End Sub

    Public Sub Cargar_Comprobante_toNC(ByVal entidad As BE.FacturacionBE.SG_FA_TB_COMPROBANTE_C)
        Try

            Dim comprobantesBL As New BL.FacturacionBL.SG_FA_TB_COMPROBANTE_C
            Dim ds_comprobante As New DataSet

            ds_comprobante = comprobantesBL.get_Comprobante_x_Id(entidad)

            With ds_comprobante.Tables(0)

                uce_PuntoVenta.Value = .Rows(0)("CO_IDPTOVTA")
                uce_TipoDoc.Value = "07"
                uce_TipDocRef.Value = .Rows(0)("CO_TDOC")
                txt_serie_ref.Value = .Rows(0)("CO_SDOC")
                txt_numero_ref.Value = .Rows(0)("CO_NDOC")
                ume_fec_emi_ref.Value = .Rows(0)("CO_FEC_EMI")
                ume_Fecha_Ven_Ref.Value = .Rows(0)("CO_FEC_VEN")

                txt_notas.Text = .Rows(0)("CO_NOTAS") & "  Doc. de Ref. : " & uce_TipDocRef.Text & "-" & txt_serie_ref.Text & "-" & txt_numero_ref.Text

                'txt_notas.Text = .Rows(0)("CO_NOTAS")
                'txt_notas.Enabled = False
                txt_idClienteC.Value = .Rows(0)("CO_IDCLIENTE")
                txt_idHistoria.Value = Val(.Rows(0)("CO_IDNUM_HIST").ToString)
                Dim historiaBL As New BL.AdmisionBL.SG_AD_TB_HISTO_CLINI
                Dim dt_histo_tmp As DataTable = historiaBL.getHistorias_Base_x_Id(txt_idHistoria.Value, 1)

                If dt_histo_tmp.Rows.Count > 0 Then
                    txt_Des_Cliente.Text = dt_histo_tmp.Rows(0)("HC_APE_PAT") & " " & dt_histo_tmp.Rows(0)("HC_APE_MAT") & " " & dt_histo_tmp.Rows(0)("HC_NOMBRE1")
                    txt_ruc_cliente.Text = dt_histo_tmp.Rows(0)("HC_NDOC")
                    txt_IdCliente.Value = dt_histo_tmp.Rows(0)("HC_IDCLIENTE")
                    uce_tip_doc.Value = dt_histo_tmp.Rows(0)("HC_TDOC")
                End If

                Dim clienteBL As New BL.FacturacionBL.SG_FA_TB_CLIENTE
                Dim clienteBE As New BE.FacturacionBE.SG_FA_TB_CLIENTE

                clienteBE.CL_ID = txt_idClienteC.Value
                clienteBE.CL_IDEMPRESA = New BE.ContabilidadBE.SG_CO_TB_EMPRESA With {.EM_ID = 1}
                clienteBL.get_Cliente_x_Id(clienteBE)

                txt_Des_ClienteC.Text = clienteBE.CL_NOMBRE
                txt_Ruc_ClientesC.Text = clienteBE.CL_NDOC

                clienteBE = Nothing
                clienteBL = Nothing

                uce_Moneda.Value = .Rows(0)("CO_IDMONEDA")
                ume_ValorTipoCambio.Value = .Rows(0)("CO_TCAM")
                ume_Tasa_Igv.Value = .Rows(0)("CO_TASA_IGV")
                uce_FormaPago.Value = .Rows(0)("CO_IDFORMA_PAGO")
                uce_docu_pago.Value = .Rows(0)("CO_IDDOCU_PAGO")
                txt_ref_pago.Text = .Rows(0)("CO_REF_PAGO")
                udte_fec_emi.Value = Now
                udte_fec_Ven.Value = Now

                txt_num_voucher_conta.Text = .Rows(0)("CO_NUMVOUCHER").ToString
                txt_IdComprobante.Text = .Rows(0)("CO_ID")
                ucm_Tipo.Value = .Rows(0)("CO_IDTIPO_ORI")
                uce_Medico.Value = .Rows(0)("CO_MEDICO")
                ucb_CentroCosto.Value = .Rows(0)("CO_CENTCOS")

            End With


            Call LimpiaGrid(ug_Detalle, uds_detalle)
            Dim idCuenta As Integer = 0

            'Detalle del Comprobante
            For i As Integer = 0 To ds_comprobante.Tables(1).Rows.Count - 1
                If ds_comprobante.Tables(1).Rows(i)("CD_IDARTICULO") <> "214" And ds_comprobante.Tables(1).Rows(i)("CD_IDARTICULO") <> "215" Then

                    ug_Detalle.DisplayLayout.Bands(0).AddNew()

                    With ds_comprobante.Tables(1)
                        ug_Detalle.Rows(i).Cells(0).Value = ds_comprobante.Tables(1).Rows(i)("CD_ITEM")
                        ug_Detalle.Rows(i).Cells("IdArticulo").Value = ds_comprobante.Tables(1).Rows(i)("CD_IDARTICULO")
                        ug_Detalle.Rows(i).Cells("DesArticulo").Value = ds_comprobante.Tables(1).Rows(i)("AR_DESCRIPCION")
                        ug_Detalle.Rows(i).Cells("CD_IDLOTE").Value = ds_comprobante.Tables(1).Rows(i)("CD_IDLOTE")
                        ug_Detalle.Rows(i).Cells("UM_VENTA").Value = ds_comprobante.Tables(1).Rows(i)("UM_DESCRIPCION")
                        ug_Detalle.Rows(i).Cells("Precio").Value = ds_comprobante.Tables(1).Rows(i)("CD_PRECIO")
                        ug_Detalle.Rows(i).Cells("DSCTO").Value = .Rows(i)("CD_DSCTO")
                        ug_Detalle.Rows(i).Cells("DSCTO_Por").Value = 0
                        ug_Detalle.Rows(i).Cells("DSCTO_OTRO").Value = Val(.Rows(i)("CD_DSCTO_OTRO").ToString)
                        ug_Detalle.Rows(i).Cells("Cant").Value = ds_comprobante.Tables(1).Rows(i)("CD_CANT")
                        ug_Detalle.Rows(i).Cells("SubTotal").Value = ds_comprobante.Tables(1).Rows(i)("CD_SUBTOTAL")
                        ug_Detalle.Rows(i).Cells("Impuesto").Value = ds_comprobante.Tables(1).Rows(i)("CD_IGV")
                        ug_Detalle.Rows(i).Cells("Total").Value = ds_comprobante.Tables(1).Rows(i)("CD_TOTAL")
                        ug_Detalle.Rows(i).Cells("CD_INAFECTO").Value = ds_comprobante.Tables(1).Rows(i)("AR_SIN_IGV")
                        'ug_Detalle.Rows(i).Cells("IDCUENTA").Value = Val(.Rows(i)("CD_IDCUENTA").ToString)
                        ug_Detalle.Rows(i).Cells("DS_SALDO").Value = 0
                        ug_Detalle.Rows(i).Cells("AR_TIPO_ARTI").Value = Val(.Rows(i)("AR_TIPO_ARTI").ToString)
                        idCuenta = Val(.Rows(i)("CD_IDCUENTA").ToString)
                        txt_IdCuenta.Text = idCuenta
                    End With

                    ug_Detalle.UpdateData()
                End If
            Next
            txt_IdCuenta.Text = idCuenta
            Dim obeC As New BE.AdmisionBE.SG_AD_TB_CUENTA_CAB
            Dim obrC As New BL.AdmisionBL.SG_AD_TB_CUENTA_CAB
            obeC.CC_ID = Val(txt_IdCuenta.Text)
            obeC.HasRow = False
            obrC.SEL04(obeC)
            If obeC.HasRow Then
                With obeC
                    uchk_SeguroEps.Checked = IIf(.CC_IDTIPO_ATENC = 2, True, False)
                    ucm_SeguroEps.Value = .CC_IDSEGURO
                    txtIDSeguro.Text = IIf(.CC_IDSEGURO = "", "000", .CC_IDSEGURO)

                    txt_FijoC.Text = .CC_SIT_COPG_FIJO
                    txt_PagoVariable.Text = .CC_SIT_COPG_VARI
                    txt_PagoFijo.Text = Math.Round(Math.Round((.CC_SIT_COPG_FIJO * (ume_Tasa_Igv.Value / 100)), 2) + .CC_SIT_COPG_FIJO, 0)

                End With
            End If
            Call Calcular_Totales()

            If ds_comprobante.Tables(2).Rows(0)("CON") > 0 Then
                txt_doc_pago.Visible = True
                txt_doc_pago.Text = "Detallado"
            Else
                txt_doc_pago.Visible = False
                txt_doc_pago.Text = ""
            End If

            ds_comprobante = Nothing
            comprobantesBL = Nothing

            ugb_cabecera.Enabled = True

            Tool_Nuevo.Enabled = False
            Tool_Grabar.Enabled = True
            Tool_Cancelar.Enabled = True

            ubtn_agregar.Enabled = True
            ubtn_quitar.Enabled = True
        Catch ex As Exception
            ShowError("Ocurrio un problema " & ex.Message)
        End Try
    End Sub

    '-------------
    Private Sub Cargar_Combos()

        Dim OrigenBL As New BL.AdmisionBL.SG_AD_TB_ORIGEN_ATENC
        ucm_Tipo.DataSource = OrigenBL.getOrigen()
        ucm_Tipo.DisplayMember = "OA_DESCRIPCION"
        ucm_Tipo.ValueMember = "OA_ID"
        OrigenBL = Nothing
        ucm_Tipo.SelectedIndex = 0

        Dim documentoscBL As New BL.AdmisionBL.SG_AD_TB_TIP_DOC_PER
        uce_tip_doc.DataSource = documentoscBL.getTiposDocs(gInt_IdEmpresa)
        uce_tip_doc.DisplayMember = "TD_ABREVIATURA"
        uce_tip_doc.ValueMember = "TD_ID"
        documentoscBL = Nothing

        Dim documentosBL As New BL.ContabilidadBL.SG_CO_TB_DOCUMENTO
        uce_TipDocRef.DataSource = documentosBL.get_Docs_Facturacion(gInt_IdEmpresa)
        uce_TipDocRef.DisplayMember = "DO_ABREVIATURA"
        uce_TipDocRef.ValueMember = "DO_CODIGO"
        documentosBL = Nothing

        Dim Obj_MonedaBL As New BL.FacturacionBL.SG_FA_TB_MONEDA
        uce_Moneda.DataSource = Obj_MonedaBL.get_Monedas(New BE.ContabilidadBE.SG_CO_TB_EMPRESA With {.EM_ID = gInt_IdEmpresa})
        uce_Moneda.DisplayMember = "MO_ABREVIATURA"
        uce_Moneda.ValueMember = "MO_ID"
        Obj_MonedaBL = Nothing

        Dim formapBL As New BL.FacturacionBL.SG_FA_TB_FORMA_PAGO
        uce_FormaPago.DataSource = formapBL.get_Lista_FP(New BE.ContabilidadBE.SG_CO_TB_EMPRESA With {.EM_ID = gInt_IdEmpresa})
        uce_FormaPago.ValueMember = "FP_ID"
        uce_FormaPago.DisplayMember = "FP_DESCRIPCION"
        formapBL = Nothing

        Dim asegBL As New BL.FacturacionBL.SG_FA_TB_CIA_ASEG
        ucm_SeguroEps.DataSource = asegBL.getAseguradoras(1)
        ucm_SeguroEps.DisplayMember = "CA_DESCRIPCION"
        ucm_SeguroEps.ValueMember = "CA_ID"
        asegBL = Nothing

        '---------------------
        Dim usuPtovtaBL As New BL.FacturacionBL.SG_FA_TB_USU_PTOVTA
        Dim usuPtovtaBE As New BE.FacturacionBE.SG_FA_TB_USU_PTOVTA
        Dim usuarioBL As New BL.ContabilidadBL.SG_CO_TB_USUARIO

        usuPtovtaBE.UP_IDUSARIO = New BE.ContabilidadBE.SG_CO_TB_USUARIO With {.US_ID = usuarioBL.getIdUsu_x_NomUsu(gStr_Usuario_Sis)}
        usuPtovtaBE.UP_IDEMPRESA = New BE.ContabilidadBE.SG_CO_TB_EMPRESA With {.EM_ID = gInt_IdEmpresa}
        uce_PuntoVenta.DataSource = usuPtovtaBL.get_Lista_PtosVtas_x_Usuario(usuPtovtaBE)
        uce_PuntoVenta.ValueMember = "UP_IDPTO_VTA"
        uce_PuntoVenta.DisplayMember = "PV_DESCRIPCION"

        usuPtovtaBL = Nothing
        usuPtovtaBE = Nothing
        usuarioBL = Nothing

        If uce_PuntoVenta.Items.Count > 0 Then uce_PuntoVenta.SelectedIndex = 0
        '--------------

        Dim docusBL As New BL.FacturacionBL.SG_FA_TB_DOCU_PAGO
        uce_docu_pago.DataSource = docusBL.get_DocuPagos(gInt_IdEmpresa)
        uce_docu_pago.DisplayMember = "DP_DESCRIPCION"
        uce_docu_pago.ValueMember = "DP_CODIGO"
        docusBL = Nothing

        Dim medicosBL As New BL.AdmisionBL.SG_AD_TB_MEDICO
        uce_Medico.DataSource = medicosBL.get_Medicos(1)
        uce_Medico.ValueMember = "ME_CODIGO"
        uce_Medico.DisplayMember = "NOMBRES"
        medicosBL = Nothing

    End Sub

    Private Sub Obtener_TipoCambio_dia()

        If udte_fec_emi.Value Is Nothing Then Exit Sub

        Dim rpta As String = String.Empty
        Dim paraetrosBL As New BL.FacturacionBL.SG_FA_TB_PARAMETROS
        Dim paraetrosBE As New BE.FacturacionBE.SG_FA_TB_PARAMETROS

        paraetrosBE.AD_IDEMPRESA = New BE.ContabilidadBE.SG_CO_TB_EMPRESA With {.EM_ID = gInt_IdEmpresa}
        paraetrosBE.AD_TIPO = "SISTE"
        paraetrosBE.AD_NOMBRE = "TC"

        rpta = paraetrosBL.get_Valor(paraetrosBE)

        If rpta = "F" Then

            Dim tipocambioBL As New BL.FacturacionBL.SG_FA_TB_PARIDAD
            Dim tipocambioBE As New BE.FacturacionBE.SG_FA_TB_PARIDAD

            tipocambioBE.PA_IDEMPRESA = New BE.ContabilidadBE.SG_CO_TB_EMPRESA With {.EM_ID = gInt_IdEmpresa}
            'tipocambioBE.PA_FECHA = CDate(udte_fec_emi.Value).ToShortDateString
            Dim dt_tc As DataTable = tipocambioBL.get_Pariedad_x_Ultimo(tipocambioBE)

            If dt_tc.Rows.Count > 0 Then
                ume_ValorTipoCambio.Value = dt_tc.Rows(0)("PA_VENTA")
            Else
                ume_ValorTipoCambio.Value = 0
            End If

            dt_tc = Nothing

            tipocambioBE = Nothing
            tipocambioBL = Nothing

        Else ' rpta = "C"

            Dim tipocamBL As New BL.ContabilidadBL.SG_CO_TB_TIPOCAMBIO
            Dim tipocamBE As New BE.ContabilidadBE.SG_CO_TB_TIPOCAMBIO

            tipocamBE.TC_IDEMPRESA = New BE.ContabilidadBE.SG_CO_TB_EMPRESA With {.EM_ID = gInt_IdEmpresa}
            tipocamBE.TC_FECHA = CDate(udte_fec_emi.Value).ToShortDateString
            tipocamBE.TC_IDMONEDA = New BE.ContabilidadBE.SG_CO_TB_MONEDA With {.MO_CODIGO = 2}
            tipocamBL.getTipoCambio(tipocamBE)

            ume_ValorTipoCambio.Value = tipocamBE.TC_VENTA

            tipocamBE = Nothing
            tipocamBL = Nothing

        End If
    End Sub

    Private Sub Cargar_Tasas_Impuestos()

        Dim impuestosBL As New BL.ContabilidadBL.SG_CO_TB_IMPUESTO
        Dim impuestoBE As New BE.ContabilidadBE.SG_CO_TB_IMPUESTO

        impuestoBE.IM_IDEMPRESA = New BE.ContabilidadBE.SG_CO_TB_EMPRESA With {.EM_ID = gInt_IdEmpresa}
        impuestoBE.IM_IDTIPOIMPUESTO = New BE.ContabilidadBE.SG_CO_TB_TIPO_IMPUESTO With {.TI_CODIGO = "01"}
        impuestoBE.IM_PERIODO = CDate(udte_fec_emi.Value).Year
        impuestoBE.IM_MES = CDate(udte_fec_emi.Value).Month

        impuestosBL.getImpuestos_x_Tipo(impuestoBE)
        ume_Tasa_Igv.Value = impuestoBE.IM_TASA


        impuestosBL = Nothing
        impuestoBE = Nothing

    End Sub

    Private Sub Iniciar_Ventana()

        'Call Inicializar_Estado_Botones_Tool(ToolS_Mantenimiento)
        Call Limpiar_Controls_InGroupox(ugb_cabecera)
        Call LimpiaGrid(ug_Detalle, uds_detalle)
        Ucbo_IDCompro.Items.Clear()
        Ucbo_Vaucher.Items.Clear()

        ume_subtotal.Value = 0
        ume_igv.Value = 0
        ume_total.Value = 0
        ume_SubExone.Value = 0
        txt_notas.Clear()
        txt_num_voucher_conta.Clear()
        txt_IdComprobante.Clear()

        'uce_TipoDoc.Value = "3"

        uce_Moneda.SelectedIndex = 0
        'udte_fec_emi.Value = gDat_Fecha_Sis
        'udte_fec_Ven.Value = gDat_Fecha_Sis


        Call Cargar_Tasas_Impuestos()
        Call Obtener_TipoCambio_dia()

        uce_PuntoVenta.SelectedIndex = 0
        uce_FormaPago.SelectedIndex = 0
        uce_docu_pago.SelectedIndex = 0
        ucm_SeguroEps.SelectedIndex = 0

        uchk_SeguroEps.Checked = False

        uce_TipDocRef.Value = Nothing
        txt_serie_ref.Text = ""
        txt_numero_ref.Text = ""
        ume_fec_emi_ref.Value = Nothing
        ume_Fecha_Ven_Ref.Value = Nothing

        Tool_Imprimir.Enabled = False
        Tool_Grabar.Enabled = False
        ubtn_agregar.Enabled = False
        ubtn_quitar.Enabled = False
        Tool_Nuevo.Enabled = True
        'uce_Empresas.Enabled = True
        txt_doc_pago.Visible = False

        For Each ctrl As Control In ugb_cabecera.Controls
            ctrl.Enabled = True
        Next
        'ucm_Tipo.Enabled = True
        'txt_ruc_cliente.Enabled = True
        uchk_SeguroEps.Enabled = False
        uce_Medico.Enabled = True
        txt_notas.Width = 489
        uce_tip_doc.SelectedIndex = 0
        Direccion = ""
        ucb_CentroCosto.SelectedIndex = 0
        ucb_CentroCosto.Enabled = False
        'txt_dni.Visible = False
        'lbl_dni.Visible = False
        'txt_dni.Text = ""
        Dim ALMBL As New BL.LogisticaBL.SG_LO_TB_ALMACEN
        Dim drr_AlM As System.Data.SqlClient.SqlDataReader
        drr_AlM = ALMBL.get_almacen_4(gInt_IdEmpresa)
        If drr_AlM.HasRows Then
            drr_AlM.Read()
            utxt_IdAlmacenC.Text = drr_AlM("AL_ID")
        End If
        drr_AlM.Close()
        ugb_cabecera.Enabled = False
        txt_IdCuenta.Focus()
    End Sub

    Private Sub Iniciar_Cuenta()

        'Call Inicializar_Estado_Botones_Tool(ToolS_Mantenimiento)
        ' Call Limpiar_Controls_InGroupox(ugb_cabecera)
        Call LimpiaGrid(ug_Detalle, uds_detalle)

        ume_subtotal.Value = 0
        ume_igv.Value = 0
        ume_total.Value = 0
        txt_notas.Clear()
        txt_num_voucher_conta.Clear()
        txt_IdComprobante.Clear()

        'uce_TipoDoc.Value = 0
        txt_PagoFijo.Text = ""
        txt_PagoVariable.Text = ""
        txt_FijoC.Text = ""
        txt_IdCuenta.Text = ""

        uce_Moneda.SelectedIndex = 0
        'udte_fec_emi.Value = gDat_Fecha_Sis
        'udte_fec_Ven.Value = gDat_Fecha_Sis


        Call Cargar_Tasas_Impuestos()
        Call Obtener_TipoCambio_dia()

        uce_PuntoVenta.SelectedIndex = 0
        uce_FormaPago.SelectedIndex = 0
        uce_docu_pago.SelectedIndex = 0
        ucm_SeguroEps.SelectedIndex = 0

        uchk_SeguroEps.Checked = False

        uce_TipDocRef.Value = Nothing
        txt_serie_ref.Text = ""
        txt_numero_ref.Text = ""

        'uce_Empresas.Enabled = True

        For Each ctrl As Control In ugb_cabecera.Controls
            ctrl.Enabled = True
        Next
        'ucm_Tipo.Enabled = True
        'txt_ruc_cliente.Enabled = True
        uchk_SeguroEps.Enabled = False
        uce_Medico.Enabled = True
        uce_tip_doc.SelectedIndex = 0
        'txt_dni.Visible = False
        'lbl_dni.Visible = False
        'txt_dni.Text = ""

        uce_Medico.Focus()
    End Sub

    Private Function fValida() As Boolean

        'pLostfocus(txt_idHistoria, Nothing)
        pLostfocus(txt_idClienteC, Nothing)
        pLostfocus(ucm_Tipo, Nothing)
        uce_TipDocRef.BackColor = Color.White
        uce_Medico.BackColor = Color.White

        txt_Ruc_ClientesC.BackColor = Color.White
        txt_serie_ref.BackColor = Color.White
        txt_numero_ref.BackColor = Color.White

        If uce_Medico.Text <> "" And uce_Medico.SelectedIndex = -1 Then
            uce_Medico.BackColor = Color.LightPink
        End If

        ume_Tasa_Igv.BackColor = Color.White
        If ume_Tasa_Igv.Value = 0 Then ume_Tasa_Igv.BackColor = Color.LightPink

        udte_fec_emi.BackColor = Color.White
        If udte_fec_emi.Value Is Nothing Then udte_fec_emi.BackColor = Color.LightPink

        If uce_TipoDoc.Value = "07" Then

            If txt_serie_ref.Text.Trim.Length = 0 Then txt_serie_ref.BackColor = Color.LightPink
            If txt_numero_ref.Text.Trim.Length = 0 Then txt_numero_ref.BackColor = Color.LightPink
            If uce_TipDocRef.SelectedIndex = -1 Then uce_TipDocRef.BackColor = Color.LightPink
        End If
        If uce_TipoDoc.Value = "01" Then
            If txt_Ruc_ClientesC.Text.Trim.Length <> 11 Then txt_Ruc_ClientesC.BackColor = Color.LightPink
        End If

        If ucm_Tipo.BackColor = Color.LightPink Then GoTo Err_Valida
        If txt_Ruc_ClientesC.BackColor = Color.LightPink Then GoTo Err_Valida
        '  If txt_idHistoria.BackColor = Color.LightPink Then GoTo Err_Valida
        If txt_idClienteC.BackColor = Color.LightPink Then GoTo Err_Valida
        If ume_Tasa_Igv.BackColor = Color.LightPink Then GoTo Err_Valida
        If udte_fec_emi.BackColor = Color.LightPink Then GoTo Err_Valida
        If txt_serie_ref.BackColor = Color.LightPink Then GoTo Err_Valida
        If txt_numero_ref.BackColor = Color.LightPink Then GoTo Err_Valida
        If uce_TipDocRef.BackColor = Color.LightPink Then GoTo Err_Valida

        Return True
        Exit Function
Err_Valida:
        MessageBox.Show("Corrija ó Complete los campos errados !!", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Return False
    End Function

    Private Sub udte_fec_emi_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles udte_fec_emi.ValueChanged
        Call Obtener_TipoCambio_dia()
        Call Cargar_Tasas_Impuestos()
        udte_fec_Ven.Value = udte_fec_emi.Value
    End Sub

    Private Sub uce_PuntoVenta_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles uce_PuntoVenta.ValueChanged

        Dim seriesBL As New BL.FacturacionBL.SG_FA_TB_PTO_VTA_SERIE
        Dim seriesBE As New BE.FacturacionBE.SG_FA_TB_PTO_VTA_SERIE

        seriesBE.PS_IDPUNTOVTA = New BE.FacturacionBE.SG_FA_TB_PUNTO_VENTA With {.PV_ID = uce_PuntoVenta.Value}
        seriesBE.PC_IDEMPRESA = New BE.ContabilidadBE.SG_CO_TB_EMPRESA With {.EM_ID = gInt_IdEmpresa}

        uce_TipoDoc.DataSource = seriesBL.get_Lista_TD_X_PtoVta(seriesBE)
        uce_TipoDoc.DisplayMember = "DO_ABREVIATURA"
        uce_TipoDoc.Value = "PS_TD"

        seriesBE = Nothing
        seriesBL = Nothing

        If uce_TipoDoc.Items.Count > 0 Then uce_TipoDoc.SelectedIndex = 1

    End Sub

    Private Sub txt_notas_EditorButtonClick(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinEditors.EditorButtonEventArgs) Handles txt_notas.EditorButtonClick
        txt_notas.Text = txt_Des_Cliente.Text.Trim
    End Sub

    '-------------pacientes clientes
    Private Sub AgregarCuentas()
        Dim obe As New BE.LogisticaBE.SG_LO_TB_CONSUMO_C
        Dim obr As New BL.LogisticaBL.SG_LO_TB_CONSUMO_C
        Dim obeC As New BE.AdmisionBE.SG_AD_TB_CUENTA_CAB
        Dim obrC As New BL.AdmisionBL.SG_AD_TB_CUENTA_CAB
        FA_PR_ListaCuentasBot.HisoriaP = Val(txt_idHistoria.Text)
        FA_PR_ListaCuentasBot.txt_filtro.Text = txt_Des_Cliente.Text
        If FA_PR_ListaCuentasBot.ug_data.Rows.Count > 0 Then
            FA_PR_ListaCuentasBot.ShowDialog()
            Dim matriz As List(Of String) = FA_PR_ListaCuentasBot.GetLista

            If matriz.Count > 0 Then
                txt_IdCuenta.Text = matriz(0)
                ucm_Tipo.Value = matriz(1)

                ucm_Tipo.Enabled = False
                uce_Medico.Value = matriz(18)
                uce_Medico.Enabled = False

                uchk_SeguroEps.Checked = IIf(matriz(6) = 2, True, False)
                ucm_SeguroEps.Value = matriz(7)
                txtIDSeguro.Text = IIf(matriz(7) = "", "000", matriz(7))

                txt_FijoC.Text = matriz(14)
                txt_PagoVariable.Text = matriz(15)
                txt_PagoFijo.Text = Math.Round(Math.Round((matriz(14) * (ume_Tasa_Igv.Value / 100)), 2) + matriz(14), 0)

                Call LimpiaGrid(ug_Detalle, uds_detalle)
                obe.CM_IDCUENTA = Val(txt_IdCuenta.Text)
                
                Dim obj As New DataTable
                obj = obr.SEL07(obe)
                If obj.Rows.Count > 0 Then
                    If Val(obj.Rows(0)("Cubre")) > 0 And (Val(obj.Rows(0)("NoCubre")) > 0 Or Val(obj.Rows(0)("Adicional")) > 0) Then
                        Dim f As String = InputBox("A=Adicional  N=No cubre   C=Cubre", "Ingrese Opción")

                        Select Case f.ToUpper
                            Case "A" 'factura
                                ug_Detalle.DataSource = obr.SEL05(obe, ume_Tasa_Igv.Value, "2")
                            Case "N" 'boleta
                                ug_Detalle.DataSource = obr.SEL05(obe, ume_Tasa_Igv.Value, "0")
                            Case "C" 'nota de credito
                                ug_Detalle.DataSource = obr.SEL05(obe, ume_Tasa_Igv.Value, "1")
                            Case Else
                                ug_Detalle.DataSource = obr.SEL05(obe, ume_Tasa_Igv.Value, "")
                        End Select
                    Else
                        ug_Detalle.DataSource = obr.SEL05(obe, ume_Tasa_Igv.Value, "")
                    End If
                    ug_Detalle.UpdateData()
                    Call Calcular_Totales()

                    Dim clienteBL As New BL.FacturacionBL.SG_FA_TB_CLIENTE
                    Dim clienteBE As New BE.FacturacionBE.SG_FA_TB_CLIENTE
                    clienteBE.CL_NDOC = "20339979490"
                    clienteBE.CL_IDEMPRESA = New BE.ContabilidadBE.SG_CO_TB_EMPRESA With {.EM_ID = gInt_IdEmpresa}
                    clienteBL.get_Cliente_x_Ruc(clienteBE)
                    txt_Des_ClienteC.Text = clienteBE.CL_NOMBRE
                    txt_Ruc_ClientesC.Text = clienteBE.CL_NDOC
                    txt_idClienteC.Text = clienteBE.CL_ID
                    Direccion = clienteBE.CL_DIRECCION
                    clienteBE = Nothing
                    clienteBL = Nothing
                Else
                    Dim comproBL As New BL.FacturacionBL.SG_FA_TB_COMPROBANTE_C
                    If comproBL.Existe_ComprobAseg_Cuenta(Val(txt_IdCuenta.Text)) Then
                        Call Avisar("La Cuenta ya fue facturada a la aseguradora, No puede usarla.")

                        ucm_Tipo.Enabled = True
                        uce_Medico.Enabled = True
                        txt_ruc_cliente.Enabled = True
                        Iniciar_Ventana()
                        Exit Sub
                    End If
                    comproBL = Nothing

                    Dim clienteBL As New BL.FacturacionBL.SG_FA_TB_CLIENTE
                    Dim clienteBE As New BE.FacturacionBE.SG_FA_TB_CLIENTE
                    clienteBE.CL_ID = Val(txt_IdCliente.Text)
                    '  txt_idClienteC.Text = Val(txt_IdCliente.Text)
                    clienteBE.CL_IDEMPRESA = New BE.ContabilidadBE.SG_CO_TB_EMPRESA With {.EM_ID = 1}
                    clienteBL.get_Cliente_x_Id(clienteBE)

                    clienteBE.CL_IDEMPRESA = New BE.ContabilidadBE.SG_CO_TB_EMPRESA With {.EM_ID = gInt_IdEmpresa}
                    If clienteBL.vERIcLI(clienteBE) = 0 Then
                        With clienteBE
                            .CL_USUARIO = String.Format("{0}-{1}", Environment.UserName, gStr_Usuario_Sis)
                            .CL_TERMINAL = Environment.MachineName
                            .CL_FECREG = Now.Date
                            .CL_ESTADO = 1
                        End With
                        txt_idClienteC.Text = clienteBL.InsertbOT(clienteBE)
                    End If

                    clienteBE.CL_IDEMPRESA = New BE.ContabilidadBE.SG_CO_TB_EMPRESA With {.EM_ID = gInt_IdEmpresa}
                    clienteBL.get_Cliente_x_Ruc(clienteBE)

                    txt_idClienteC.Text = clienteBE.CL_ID
                    txt_Des_ClienteC.Text = clienteBE.CL_NOMBRE
                    txt_Ruc_ClientesC.Text = clienteBE.CL_NDOC
                    Direccion = clienteBE.CL_DIRECCION
                    clienteBE = Nothing
                    clienteBL = Nothing
                End If

            Else
                ucm_Tipo.Enabled = True
                uce_Medico.Enabled = True
                txt_ruc_cliente.Enabled = True
                Iniciar_Cuenta()
            End If
        End If

    End Sub

    Private Sub Ayuda_Anexo_Cab()
        'FA_PR_ListaClientesAyuda.Int_Opcion = 1
        AD_PR_BuscaPaciente.ShowDialog()

        Dim matriz As List(Of String) = AD_PR_BuscaPaciente.GetLista

        'txt_ruc_cliente.ButtonsRight("editar").Enabled = False

        If matriz.Count > 0 Then

            txt_IdCliente.Text = matriz(1)
            txt_idHistoria.Text = matriz(0)
            txt_ruc_cliente.Text = matriz(9)
            uce_tip_doc.Value = matriz(8)
            txt_Des_Cliente.Text = matriz(2)
            'udte_fechaNac.Value = matriz(10)
            'txt_Edad.Value = Int(DateDiff("m", matriz(10), Date.Now) / 12)
            ' txt_ruc_cliente.ButtonsRight("editar").Enabled = True

            txt_idClienteC.Text = matriz(1)
            txt_Ruc_ClientesC.Text = matriz(9)
            txt_Des_ClienteC.Text = matriz(2)

            AgregarCuentas()

            Dim clienteCBL As New BL.FacturacionBL.SG_FA_TB_CLIENTE
            Dim clienteCBE As New BE.FacturacionBE.SG_FA_TB_CLIENTE
            clienteCBE.CL_ID = Val(txt_idClienteC.Text)
            'txt_idClienteC.Text = Val(txt_IdCliente.Text)
            clienteCBE.CL_IDEMPRESA = New BE.ContabilidadBE.SG_CO_TB_EMPRESA With {.EM_ID = 1}
            clienteCBL.get_Cliente_x_Id(clienteCBE)

            clienteCBE.CL_IDEMPRESA = New BE.ContabilidadBE.SG_CO_TB_EMPRESA With {.EM_ID = gInt_IdEmpresa}
            If clienteCBL.vERIcLI(clienteCBE) = 0 Then
                With clienteCBE
                    .CL_USUARIO = String.Format("{0}-{1}", Environment.UserName, gStr_Usuario_Sis)
                    .CL_TERMINAL = Environment.MachineName
                    .CL_FECREG = Now.Date
                    .CL_ESTADO = 1
                End With
                txt_idClienteC.Text = clienteCBL.InsertbOT(clienteCBE)
            End If

            clienteCBE.CL_IDEMPRESA = New BE.ContabilidadBE.SG_CO_TB_EMPRESA With {.EM_ID = gInt_IdEmpresa}
            clienteCBL.get_Cliente_x_Ruc(clienteCBE)

            txt_idClienteC.Text = clienteCBE.CL_ID
            txt_Des_ClienteC.Text = clienteCBE.CL_NOMBRE
            txt_Ruc_ClientesC.Text = clienteCBE.CL_NDOC
            Direccion = clienteCBE.CL_DIRECCION
            clienteCBE = Nothing
            clienteCBL = Nothing

           

        End If

    End Sub
    Private Sub Buscar_Cliente()

        Dim clienteBL As New BL.AdmisionBL.SG_AD_TB_HISTO_CLINI
        Dim clienteBE As New BE.AdmisionBE.SG_AD_TB_HISTO_CLINI

        clienteBE.HC_NDOC = txt_ruc_cliente.Text.Trim
        clienteBE.HC_IDEMPRESA = 1
        clienteBE.HC_TDOC = uce_tip_doc.Value
        clienteBL.get_Historias_x_Doc(clienteBE)

        If clienteBE.HasRow Then
            txt_IdCliente.Text = clienteBE.HC_IDCLIENTE
            txt_idHistoria.Text = clienteBE.HC_NUM_HIST
            txt_Des_Cliente.Text = clienteBE.HC_NOMBRE1

            txt_idClienteC.Text = clienteBE.HC_IDCLIENTE
            txt_Ruc_ClientesC.Text = txt_ruc_cliente.Text.Trim
            txt_Des_ClienteC.Text = clienteBE.HC_NOMBRE1

            AgregarCuentas()

            Dim clienteCBL As New BL.FacturacionBL.SG_FA_TB_CLIENTE
            Dim clienteCBE As New BE.FacturacionBE.SG_FA_TB_CLIENTE
            clienteCBE.CL_ID = Val(txt_idClienteC.Text)
            'txt_idClienteC.Text = Val(txt_IdCliente.Text)
            clienteCBE.CL_IDEMPRESA = New BE.ContabilidadBE.SG_CO_TB_EMPRESA With {.EM_ID = 1}
            clienteCBL.get_Cliente_x_Id(clienteCBE)

            clienteCBE.CL_IDEMPRESA = New BE.ContabilidadBE.SG_CO_TB_EMPRESA With {.EM_ID = gInt_IdEmpresa}
            If clienteCBL.vERIcLI(clienteCBE) = 0 Then
                With clienteCBE
                    .CL_USUARIO = String.Format("{0}-{1}", Environment.UserName, gStr_Usuario_Sis)
                    .CL_TERMINAL = Environment.MachineName
                    .CL_FECREG = Now.Date
                    .CL_ESTADO = 1
                End With
                txt_idClienteC.Text = clienteCBL.InsertbOT(clienteCBE)
            End If

            clienteCBE.CL_IDEMPRESA = New BE.ContabilidadBE.SG_CO_TB_EMPRESA With {.EM_ID = gInt_IdEmpresa}
            clienteCBL.get_Cliente_x_Ruc(clienteCBE)

            txt_idClienteC.Text = clienteCBE.CL_ID
            txt_Des_ClienteC.Text = clienteCBE.CL_NOMBRE
            txt_Ruc_ClientesC.Text = clienteCBE.CL_NDOC
            Direccion = clienteCBE.CL_DIRECCION
            clienteCBE = Nothing
            clienteCBL = Nothing



        Else
            ucm_Tipo.Enabled = True
            Avisar("El Paciente no existe!")

        End If


        clienteBE = Nothing
        clienteBL = Nothing

    End Sub

    Private Sub Ayuda_Anexo_Cab_C()
        FA_PR_ListaClientesAyuda.Int_Opcion = 1
        FA_PR_ListaClientesAyuda.ShowDialog()

        Dim matriz As List(Of String) = FA_PR_ListaClientesAyuda.GetLista

        'txt_ruc_cliente.ButtonsRight("editar").Enabled = False

        If matriz.Count > 0 Then
            txt_idClienteC.Text = matriz(0)
            txt_Ruc_ClientesC.Text = matriz(1)
            txt_Des_ClienteC.Text = matriz(2)

            Dim clienteBL As New BL.FacturacionBL.SG_FA_TB_CLIENTE
            Dim clienteBE As New BE.FacturacionBE.SG_FA_TB_CLIENTE

            clienteBE.HasRow = False
            clienteBE.CL_NDOC = txt_Ruc_ClientesC.Text.Trim
            clienteBE.CL_IDEMPRESA = New BE.ContabilidadBE.SG_CO_TB_EMPRESA With {.EM_ID = gInt_IdEmpresa}
            clienteBL.get_Cliente_x_Ruc(clienteBE)

            If clienteBE.HasRow Then
                txt_idClienteC.Text = clienteBE.CL_ID
                txt_Des_ClienteC.Text = clienteBE.CL_NOMBRE
                Direccion = clienteBE.CL_DIRECCION
                ubtn_agregar.Focus()
            Else
                Direccion = ""
            End If
            'Direccion = clienteBE.CL_DIRECCION
            ' txt_ruc_cliente.ButtonsRight("editar").Enabled = True
        End If

    End Sub
    Private Sub Buscar_Cliente_C()

        Dim clienteBL As New BL.FacturacionBL.SG_FA_TB_CLIENTE
        Dim clienteBE As New BE.FacturacionBE.SG_FA_TB_CLIENTE

        clienteBE.CL_NDOC = txt_Ruc_ClientesC.Text.Trim
        clienteBE.CL_IDEMPRESA = New BE.ContabilidadBE.SG_CO_TB_EMPRESA With {.EM_ID = gInt_IdEmpresa}
        clienteBL.get_Cliente_x_Ruc(clienteBE)

        If clienteBE.HasRow Then
            txt_idClienteC.Text = clienteBE.CL_ID
            txt_Des_ClienteC.Text = clienteBE.CL_NOMBRE
            Direccion = clienteBE.CL_DIRECCION
            ubtn_agregar.Focus()
        Else

            If Preguntar("El cliente no existe!, Desea Crearlo?") Then

                FA_PR_IngClienteRapido.str_num_ruc = txt_ruc_cliente.Text.Trim
                FA_PR_IngClienteRapido.ShowDialog()
                If FA_PR_IngClienteRapido.bol_Grabo Then
                    clienteBL.get_Cliente_x_Ruc(clienteBE)
                    If clienteBE.HasRow Then
                        txt_idClienteC.Text = clienteBE.CL_ID
                        txt_Des_ClienteC.Text = clienteBE.CL_NOMBRE
                        Direccion = clienteBE.CL_DIRECCION
                        ubtn_agregar.Focus()
                    End If
                End If
            End If

        End If

        clienteBE = Nothing
        clienteBL = Nothing

    End Sub

    Private Sub txt_ruc_cliente_EditorButtonClick(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinEditors.EditorButtonEventArgs) Handles txt_ruc_cliente.EditorButtonClick
        Select Case e.Button.Key
            Case "ayuda"
                Call Ayuda_Anexo_Cab()
            Case "editar"

        End Select
    End Sub
    Private Sub txt_ruc_cliente_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_ruc_cliente.ValueChanged
        If txt_ruc_cliente.Text.Trim.Length = 0 Then
            txt_IdCliente.Text = String.Empty
            txt_Des_Cliente.Text = String.Empty
        End If
    End Sub
    Private Sub txt_ruc_cliente_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_ruc_cliente.KeyDown
        If e.KeyCode = Keys.Enter Or e.KeyCode = Keys.Tab Then
            Call Buscar_Cliente()
        End If

        If e.KeyCode = Keys.F2 Then Call Ayuda_Anexo_Cab()
    End Sub
    Private Sub txt_Ruc_ClientesC_EditorButtonClick(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinEditors.EditorButtonEventArgs) Handles txt_Ruc_ClientesC.EditorButtonClick
        Select Case e.Button.Key
            Case "ayuda"
                Call Ayuda_Anexo_Cab_C()
            Case "editar"

        End Select
    End Sub
    Private Sub txt_Ruc_ClientesC_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_Ruc_ClientesC.KeyDown
        If e.KeyCode = Keys.Enter Then
            Call Buscar_Cliente_C()
        End If

        If e.KeyCode = Keys.F2 Then Call Ayuda_Anexo_Cab_C()
    End Sub
    Private Sub txt_Ruc_ClientesC_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_Ruc_ClientesC.ValueChanged
        If txt_Ruc_ClientesC.Text.Trim.Length = 0 Then
            txt_idClienteC.Text = String.Empty
            txt_Des_ClienteC.Text = String.Empty
        End If
    End Sub

    '-------------------Comprobante nro
    Private Sub Validar_existe_num_comprobante(ByRef existe As Boolean)

        Dim comproBL As New BL.FacturacionBL.SG_FA_TB_COMPROBANTE_C
        Dim comproBE As New BE.FacturacionBE.SG_FA_TB_COMPROBANTE_C

        comproBE.CO_TDOC = New BE.FacturacionBE.SG_FA_TB_DOCUMENTO With {.DO_CODIGO = uce_TipoDoc.Value}
        comproBE.CO_SDOC = uce_Serie.Value
        comproBE.CO_NDOC = txt_NumDoc.Text
        comproBE.CO_IDEMPRESA = New BE.ContabilidadBE.SG_CO_TB_EMPRESA With {.EM_ID = gInt_IdEmpresa}

        If comproBL.Existe_Comprobante(comproBE) Then
            Call Avisar("El numero de comprobante " & uce_TipoDoc.Text & "-" & uce_Serie.Value & "-" & txt_NumDoc.Text & " ya esta registrado,! Cuidado")
            existe = True
        End If

        comproBE = Nothing
        comproBL = Nothing

    End Sub
    Private Sub Cargar_Series_Doc()

        Dim seriesBL As New BL.FacturacionBL.SG_FA_TB_PTO_VTA_SERIE
        Dim seriesBE As New BE.FacturacionBE.SG_FA_TB_PTO_VTA_SERIE

        seriesBE.PS_IDPUNTOVTA = New BE.FacturacionBE.SG_FA_TB_PUNTO_VENTA With {.PV_ID = uce_PuntoVenta.Value}
        seriesBE.PC_IDEMPRESA = New BE.ContabilidadBE.SG_CO_TB_EMPRESA With {.EM_ID = gInt_IdEmpresa}
        seriesBE.PS_TD = New BE.ContabilidadBE.SG_CO_TB_DOCUMENTO With {.DO_CODIGO = uce_TipoDoc.Value}

        uce_Serie.DataSource = seriesBL.get_Lista_Serie_x_TipDoc_x_PtoVta(seriesBE)
        uce_Serie.DisplayMember = "PS_SERIE"
        uce_Serie.ValueMember = "PS_SERIE"

        seriesBE = Nothing
        seriesBL = Nothing

        If uce_Serie.Items.Count > 0 Then uce_Serie.SelectedIndex = 0

    End Sub
    Private Sub Obtener_Ult_Num_Compro()
        Dim numeracionBL As New BL.FacturacionBL.SG_FA_TB_NUM_COMPRO
        Dim numeracionBE As New BE.FacturacionBE.SG_FA_TB_NUM_COMPRO

        numeracionBE.NC_IDTIPO = New BE.FacturacionBE.SG_FA_TB_DOCUMENTO With {.DO_CODIGO = uce_TipoDoc.Value}
        numeracionBE.NC_IDEMPRESA = New BE.ContabilidadBE.SG_CO_TB_EMPRESA With {.EM_ID = gInt_IdEmpresa}
        numeracionBE.NC_SERIE = uce_Serie.Value

        txt_NumDoc.Text = numeracionBL.get_NumCompro_xTD_SD3(numeracionBE)

        numeracionBE = Nothing
        numeracionBL = Nothing
    End Sub

    Private Sub uce_TipoDoc_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles uce_TipoDoc.ValueChanged
        Call Cargar_Series_Doc()
        Call Obtener_Ult_Num_Compro()
        If uce_TipoDoc.Value = "01" Then
            ucb_CentroCosto.Enabled = True
        Else
            ucb_CentroCosto.Enabled = False
        End If

    End Sub
    Private Sub txt_NumDoc_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_NumDoc.Leave
        txt_NumDoc.Text = txt_NumDoc.Text.PadLeft(11, "0")

        Call Validar_existe_num_comprobante(Nothing)
    End Sub
    Private Sub uce_Serie_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles uce_Serie.ValueChanged
        Call Obtener_Ult_Num_Compro()
    End Sub

    '--------------------------Cuentas
    Private Sub Ayuda_Anexo_Cuenta()
        ''Dim obe As New BE.FacturacionBE.SG_FA_TB_PRE_FACTURA_CAB
        ''Dim obr As New BL.FacturacionBL.SG_FA_TB_PRE_FACTURA_CAB
        Dim obe As New BE.LogisticaBE.SG_LO_TB_CONSUMO_C
        Dim obr As New BL.LogisticaBL.SG_LO_TB_CONSUMO_C
        Dim obeC As New BE.AdmisionBE.SG_AD_TB_CUENTA_CAB
        Dim obrC As New BL.AdmisionBL.SG_AD_TB_CUENTA_CAB

        FA_PR_ListaCuentasCaja.ShowDialog()

        Dim matriz As List(Of String) = FA_PR_ListaCuentasCaja.GetLista
        Dim FechaCuenta As Date
        If matriz.Count > 0 Then
            FechaCuenta = matriz(8)
            ucm_Tipo.Value = matriz(1)
            If DateAdd(DateInterval.Day, 7, FechaCuenta) < Now.Date And ucm_Tipo.Value = 1 Then
                Call Avisar("El Plazo de la Cuenta ambulatoria esta vencida, No puede usarla.")
                Exit Sub
            End If

            txt_idHistoria.Value = matriz(3)
            txt_IdCuenta.Text = matriz(0)
            ucm_Tipo.Enabled = False
            Dim historiaBL As New BL.AdmisionBL.SG_AD_TB_HISTO_CLINI
            Dim dt_histo_tmp As DataTable = historiaBL.getHistorias_Base_x_Id(txt_idHistoria.Value, 1)
            If dt_histo_tmp.Rows.Count > 0 Then
                txt_IdCliente.Text = dt_histo_tmp.Rows(0)("HC_IDCLIENTE")
                txt_Des_Cliente.Text = dt_histo_tmp.Rows(0)("HC_APE_PAT") & " " & dt_histo_tmp.Rows(0)("HC_APE_MAT") & " " & dt_histo_tmp.Rows(0)("HC_APE_CASADA") & " " & dt_histo_tmp.Rows(0)("HC_NOMBRE1") & " " & dt_histo_tmp.Rows(0)("HC_NOMBRE2")
                txt_ruc_cliente.Text = dt_histo_tmp.Rows(0)("HC_NDOC")
                uce_tip_doc.Value = dt_histo_tmp.Rows(0)("HC_TDOC")
            End If

            uce_Medico.Value = matriz(18)
            uce_Medico.Enabled = False

            uchk_SeguroEps.Checked = IIf(matriz(6) = 2, True, False)
            ucm_SeguroEps.Value = matriz(7)
            txtIDSeguro.Text = IIf(matriz(7) = "", "000", matriz(7))

            txt_FijoC.Text = matriz(14)
            txt_PagoVariable.Text = matriz(15)
            txt_PagoFijo.Text = Math.Round(Math.Round((matriz(14) * (ume_Tasa_Igv.Value / 100)), 2) + matriz(14), 0)
            txt_ruc_cliente.Enabled = False

            Call LimpiaGrid(ug_Detalle, uds_detalle)
            obe.CM_IDCUENTA = Val(txt_IdCuenta.Text)

            Dim obj As New DataTable
            obj = obr.SEL07(obe)
            If obj.Rows.Count > 0 Then
                If Val(obj.Rows(0)("Cubre")) > 0 And (Val(obj.Rows(0)("NoCubre")) > 0 Or Val(obj.Rows(0)("Adicional")) > 0) Then
                    Dim f As String = InputBox("A=Adicional  N=No cubre   C=Cubre", "Ingrese Opción")

                    Select Case f.ToUpper
                        Case "A" 'factura
                            ug_Detalle.DataSource = obr.SEL05(obe, ume_Tasa_Igv.Value, "2")
                        Case "N" 'boleta
                            ug_Detalle.DataSource = obr.SEL05(obe, ume_Tasa_Igv.Value, "0")
                        Case "C" 'nota de credito
                            ug_Detalle.DataSource = obr.SEL05(obe, ume_Tasa_Igv.Value, "1")
                        Case Else
                            ug_Detalle.DataSource = obr.SEL05(obe, ume_Tasa_Igv.Value, "")
                    End Select
                Else
                    ug_Detalle.DataSource = obr.SEL05(obe, ume_Tasa_Igv.Value, "")
                End If

                ug_Detalle.UpdateData()
                Call Calcular_Totales()

                Dim clienteBL As New BL.FacturacionBL.SG_FA_TB_CLIENTE
                Dim clienteBE As New BE.FacturacionBE.SG_FA_TB_CLIENTE
                clienteBE.CL_NDOC = "20339979490"
                clienteBE.CL_IDEMPRESA = New BE.ContabilidadBE.SG_CO_TB_EMPRESA With {.EM_ID = gInt_IdEmpresa}
                clienteBL.get_Cliente_x_Ruc(clienteBE)
                txt_Des_ClienteC.Text = clienteBE.CL_NOMBRE
                txt_Ruc_ClientesC.Text = clienteBE.CL_NDOC
                txt_idClienteC.Text = clienteBE.CL_ID
                Direccion = clienteBE.CL_DIRECCION
                clienteBE = Nothing
                clienteBL = Nothing
            Else
                Dim comproBL As New BL.FacturacionBL.SG_FA_TB_COMPROBANTE_C
                If comproBL.Existe_ComprobAseg_Cuenta(Val(txt_IdCuenta.Text)) Then
                    Call Avisar("La Cuenta ya fue facturada a la aseguradora, No puede usarla.")

                    ucm_Tipo.Enabled = True
                    uce_Medico.Enabled = True
                    txt_ruc_cliente.Enabled = True
                    Iniciar_Ventana()
                    Exit Sub
                End If
                comproBL = Nothing

                Dim clienteBL As New BL.FacturacionBL.SG_FA_TB_CLIENTE
                Dim clienteBE As New BE.FacturacionBE.SG_FA_TB_CLIENTE
                clienteBE.CL_ID = Val(txt_IdCliente.Text)
                '  txt_idClienteC.Text = Val(txt_IdCliente.Text)
                clienteBE.CL_IDEMPRESA = New BE.ContabilidadBE.SG_CO_TB_EMPRESA With {.EM_ID = 1}
                clienteBL.get_Cliente_x_Id(clienteBE)

                clienteBE.CL_IDEMPRESA = New BE.ContabilidadBE.SG_CO_TB_EMPRESA With {.EM_ID = gInt_IdEmpresa}
                If clienteBL.vERIcLI(clienteBE) = 0 Then
                    With clienteBE
                        .CL_USUARIO = String.Format("{0}-{1}", Environment.UserName, gStr_Usuario_Sis)
                        .CL_TERMINAL = Environment.MachineName
                        .CL_FECREG = Now.Date
                        .CL_ESTADO = 1
                    End With
                    txt_idClienteC.Text = clienteBL.InsertbOT(clienteBE)
                End If

                clienteBE.CL_IDEMPRESA = New BE.ContabilidadBE.SG_CO_TB_EMPRESA With {.EM_ID = gInt_IdEmpresa}
                clienteBL.get_Cliente_x_Ruc(clienteBE)

                txt_idClienteC.Text = clienteBE.CL_ID
                txt_Des_ClienteC.Text = clienteBE.CL_NOMBRE
                txt_Ruc_ClientesC.Text = clienteBE.CL_NDOC
                Direccion = clienteBE.CL_DIRECCION
                clienteBE = Nothing
                clienteBL = Nothing
            End If

        Else
            ucm_Tipo.Enabled = True
            uce_Medico.Enabled = True
            txt_ruc_cliente.Enabled = True
            Iniciar_Ventana()
        End If

    End Sub
    Private Sub Buscar_Cuenta()
        Dim obe As New BE.LogisticaBE.SG_LO_TB_CONSUMO_C
        Dim obr As New BL.LogisticaBL.SG_LO_TB_CONSUMO_C
        Dim obrC As New BL.AdmisionBL.SG_AD_TB_CUENTA_CAB
        Dim obeC As New BE.AdmisionBE.SG_AD_TB_CUENTA_CAB

        obeC.CC_ID = Val(txt_IdCuenta.Text)
        obeC.HasRow = False
        obrC.SEL04(obeC)
        If obeC.HasRow Then
            With obeC
                Dim FechaCuenta As Date
                ucm_Tipo.Value = .CC_IDTIPO_ORI
                FechaCuenta = .CC_FECHA
                If DateAdd(DateInterval.Day, 7, FechaCuenta) < Now.Date And ucm_Tipo.Value = 1 Then
                    Call Avisar("El Plazo de la Cuenta ambulatoria esta vencida, No puede usarla.")
                    Exit Sub
                End If

                txt_idHistoria.Value = .CC_IDNUM_HIST
                Dim historiaBL As New BL.AdmisionBL.SG_AD_TB_HISTO_CLINI
                Dim dt_histo_tmp As DataTable = historiaBL.getHistorias_Base_x_Id(txt_idHistoria.Value, 1)
                If dt_histo_tmp.Rows.Count > 0 Then
                    txt_IdCliente.Text = dt_histo_tmp.Rows(0)("HC_IDCLIENTE")
                    txt_Des_Cliente.Text = dt_histo_tmp.Rows(0)("HC_APE_PAT") & " " & dt_histo_tmp.Rows(0)("HC_APE_MAT") & " " & dt_histo_tmp.Rows(0)("HC_APE_CASADA") & " " & dt_histo_tmp.Rows(0)("HC_NOMBRE1") & " " & dt_histo_tmp.Rows(0)("HC_NOMBRE2")
                    txt_ruc_cliente.Text = dt_histo_tmp.Rows(0)("HC_NDOC")
                    uce_tip_doc.Value = dt_histo_tmp.Rows(0)("HC_TDOC")
                End If

                uchk_SeguroEps.Checked = IIf(.CC_IDTIPO_ATENC = 2, True, False)
                ucm_SeguroEps.Value = .CC_IDSEGURO
                txtIDSeguro.Text = IIf(.CC_IDSEGURO = "", "000", .CC_IDSEGURO)

                txt_FijoC.Text = .CC_SIT_COPG_FIJO
                txt_PagoVariable.Text = .CC_SIT_COPG_VARI
                txt_PagoFijo.Text = Math.Round(Math.Round((.CC_SIT_COPG_FIJO * (ume_Tasa_Igv.Value / 100)), 2) + .CC_SIT_COPG_FIJO, 0)

                uce_Medico.Value = .CC_MEDICO
                ucm_Tipo.Enabled = False
                txt_ruc_cliente.Enabled = False
                uce_Medico.Enabled = False


                '------consumo
                Call LimpiaGrid(ug_Detalle, uds_detalle)
                'Dim obj As New DataTable

                obe.CM_IDCUENTA = Val(txt_IdCuenta.Text)
                'preguntat cubre no cubre
                Dim obj As New DataTable
                obj = obr.SEL07(obe)
                If obj.Rows.Count > 0 Then
                    If Val(obj.Rows(0)("Cubre")) > 0 And (Val(obj.Rows(0)("NoCubre")) > 0 Or Val(obj.Rows(0)("Adicional")) > 0) Then
                        Dim f As String = InputBox("A=Adicional  N=No cubre   C=Cubre", "Ingrese Opción")

                        Select Case f.ToUpper
                            Case "A" 'factura
                                ug_Detalle.DataSource = obr.SEL05(obe, ume_Tasa_Igv.Value, "2")
                            Case "N" 'boleta
                                ug_Detalle.DataSource = obr.SEL05(obe, ume_Tasa_Igv.Value, "0")
                            Case "C" 'nota de credito
                                ug_Detalle.DataSource = obr.SEL05(obe, ume_Tasa_Igv.Value, "1")
                            Case Else
                                ug_Detalle.DataSource = obr.SEL05(obe, ume_Tasa_Igv.Value, "")
                        End Select

                    Else
                        ug_Detalle.DataSource = obr.SEL05(obe, ume_Tasa_Igv.Value, "")
                    End If

                    ug_Detalle.UpdateData()
                    Call Calcular_Totales()

                    Dim clienteBL As New BL.FacturacionBL.SG_FA_TB_CLIENTE
                    Dim clienteBE As New BE.FacturacionBE.SG_FA_TB_CLIENTE
                    clienteBE.CL_NDOC = "20339979490"
                    clienteBE.CL_IDEMPRESA = New BE.ContabilidadBE.SG_CO_TB_EMPRESA With {.EM_ID = gInt_IdEmpresa}
                    clienteBL.get_Cliente_x_Ruc(clienteBE)
                    txt_Des_ClienteC.Text = clienteBE.CL_NOMBRE
                    txt_Ruc_ClientesC.Text = clienteBE.CL_NDOC
                    txt_idClienteC.Text = clienteBE.CL_ID
                    Direccion = clienteBE.CL_DIRECCION
                    clienteBE = Nothing
                    clienteBL = Nothing
                Else
                    Dim comproBL As New BL.FacturacionBL.SG_FA_TB_COMPROBANTE_C
                    If comproBL.Existe_ComprobAseg_Cuenta(Val(txt_IdCuenta.Text)) Then
                        Call Avisar("La Cuenta ya fue facturada a la aseguradora, No puede usarla.")

                        ucm_Tipo.Enabled = True
                        uce_Medico.Enabled = True
                        txt_ruc_cliente.Enabled = True
                        Iniciar_Ventana()
                        Exit Sub
                    End If
                    comproBL = Nothing

                    Dim clienteBL As New BL.FacturacionBL.SG_FA_TB_CLIENTE
                    Dim clienteBE As New BE.FacturacionBE.SG_FA_TB_CLIENTE
                    clienteBE.CL_ID = .CC_IDCLIENTE
                    txt_idClienteC.Text = .CC_IDCLIENTE
                    clienteBE.CL_IDEMPRESA = New BE.ContabilidadBE.SG_CO_TB_EMPRESA With {.EM_ID = 1}
                    clienteBL.get_Cliente_x_Id(clienteBE)

                    clienteBE.CL_IDEMPRESA = New BE.ContabilidadBE.SG_CO_TB_EMPRESA With {.EM_ID = gInt_IdEmpresa}
                    If clienteBL.vERIcLI(clienteBE) = 0 Then
                        With clienteBE
                            .CL_USUARIO = String.Format("{0}-{1}", Environment.UserName, gStr_Usuario_Sis)
                            .CL_TERMINAL = Environment.MachineName
                            .CL_FECREG = Now.Date
                            .CL_ESTADO = 1
                        End With
                        txt_idClienteC.Text = clienteBL.InsertbOT(clienteBE)
                    End If

                    clienteBE.CL_IDEMPRESA = New BE.ContabilidadBE.SG_CO_TB_EMPRESA With {.EM_ID = gInt_IdEmpresa}
                    clienteBL.get_Cliente_x_Ruc(clienteBE)
                    txt_idClienteC.Text = clienteBE.CL_ID
                    txt_Des_ClienteC.Text = clienteBE.CL_NOMBRE
                    txt_Ruc_ClientesC.Text = clienteBE.CL_NDOC
                    Direccion = clienteBE.CL_DIRECCION
                    clienteBE = Nothing
                    clienteBL = Nothing
                End If

            End With
        Else
            Avisar("Cuenta no Existe!")
            ucm_Tipo.Enabled = True
            uce_Medico.Enabled = True
            txt_ruc_cliente.Enabled = True
            Iniciar_Ventana()
        End If

    End Sub

    Private Sub txt_IdCuenta_EditorButtonClick(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinEditors.EditorButtonEventArgs) Handles txt_IdCuenta.EditorButtonClick
        Select Case e.Button.Key
            Case "ayuda"
                Call Ayuda_Anexo_Cuenta()
            Case "editar"

        End Select
    End Sub
    Private Sub txt_IdCuenta_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_IdCuenta.ValueChanged
        If txt_IdCuenta.Text.Trim.Length = 0 Then
            Iniciar_Ventana()
        End If
    End Sub
    Private Sub txt_IdCuenta_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_IdCuenta.KeyDown
        If e.KeyCode = Keys.Enter Or e.KeyCode = Keys.Tab Then
            Call Buscar_Cuenta()
        End If

        If e.KeyCode = Keys.F2 Then Call Ayuda_Anexo_Cuenta()
    End Sub

    '--------------------Articulos
    Private Sub ubtn_agregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ubtn_agregar.Click
        If ugb_cabecera.Enabled = False Then Exit Sub

        LO_LT_ListaMedicamInsumos.IGVTas = ume_Tasa_Igv.Value
        If ucm_Tipo.Value = 2 Or ucm_Tipo.Value = 3 Or ucm_Tipo.Value = 4 Or ucm_Tipo.Value = 6 Then
            LO_LT_ListaMedicamInsumos.TipoAten = 3
        Else
            LO_LT_ListaMedicamInsumos.TipoAten = 1
        End If

        LO_LT_ListaMedicamInsumos.idSeguro = txtIDSeguro.Text
        LO_LT_ListaMedicamInsumos.idalmacen = utxt_IdAlmacenC.Text
        LO_LT_ListaMedicamInsumos.ShowDialog()

        Dim matriz As List(Of BE.LogisticaBE.SG_LO_TB_ARTICULO) = LO_LT_ListaMedicamInsumos.GetLista
        Dim aa As Integer = 0
        For Each articulo As BE.LogisticaBE.SG_LO_TB_ARTICULO In matriz
            'Item()
            'IdArticulo()
            'DesArticulo()
            'CD_IDLOTE
            'UM_VENTA()
            'Precio()
            'DSCTO()
            'DSCTO_Por()
            'DSCTO_OTRO()
            'Cant()
            'SubTotal()
            'Impuesto()
            'Total()
            'CD_INAFECTO()
            'DS_SALDO()

            Dim descuento As Decimal = "0.00"

            Dim subtotal_cal As Decimal
            Dim igv_cal As Decimal
            Dim total_cal As Decimal

            If articulo.DS_SALDO > 0 Or ucm_Tipo.Value = 2 Or articulo.AR_TIPO_ARTI = "S" Then

                descuento = Math.Round((articulo.AR_PRECIO_VENTA * Val(txt_PagoVariable.Value)) / 100, 2)

                If articulo.AR_SIN_IGV = 1 Then
                    total_cal = Math.Round(articulo.AR_PRECIO_VENTA - descuento, 2)
                    subtotal_cal = total_cal
                    igv_cal = 0
                Else
                    total_cal = Math.Round(articulo.AR_PRECIO_VENTA - descuento, 2)
                    subtotal_cal = Math.Round(total_cal / ((ume_Tasa_Igv.Value + 100) / 100), 2)
                    igv_cal = Math.Round((total_cal - subtotal_cal), 2)
                End If
                bol_cal = False
                ug_Detalle.DisplayLayout.Bands(0).AddNew()
                bol_cal = True
                ug_Detalle.Rows(ug_Detalle.Rows.Count - 1).Cells(0).Value = ug_Detalle.Rows.Count
                ug_Detalle.Rows(ug_Detalle.Rows.Count - 1).Cells("IdArticulo").Value = articulo.AR_ID  'codigo id
                ug_Detalle.Rows(ug_Detalle.Rows.Count - 1).Cells("DesArticulo").Value = articulo.AR_DESCRIPCION 'codigo
                ug_Detalle.Rows(ug_Detalle.Rows.Count - 1).Cells("CD_IDLOTE").Value = articulo.DS_IDLOTE
                ug_Detalle.Rows(ug_Detalle.Rows.Count - 1).Cells("UM_VENTA").Value = articulo.UM_DesV  'descripcion
                ug_Detalle.Rows(ug_Detalle.Rows.Count - 1).Cells("Precio").Value = articulo.AR_PRECIO_VENTA
                ug_Detalle.Rows(ug_Detalle.Rows.Count - 1).Cells("DSCTO").Value = descuento
                ug_Detalle.Rows(ug_Detalle.Rows.Count - 1).Cells("DSCTO_Por").Value = 0
                ug_Detalle.Rows(ug_Detalle.Rows.Count - 1).Cells("DSCTO_OTRO").Value = 0
                ug_Detalle.Rows(ug_Detalle.Rows.Count - 1).Cells("Cant").Value = 1

                ug_Detalle.Rows(ug_Detalle.Rows.Count - 1).Cells("SubTotal").Value = subtotal_cal
                ug_Detalle.Rows(ug_Detalle.Rows.Count - 1).Cells("Impuesto").Value = igv_cal
                ug_Detalle.Rows(ug_Detalle.Rows.Count - 1).Cells("Total").Value = total_cal

                ug_Detalle.Rows(ug_Detalle.Rows.Count - 1).Cells("CD_INAFECTO").Value = articulo.AR_SIN_IGV
                ug_Detalle.Rows(ug_Detalle.Rows.Count - 1).Cells("DS_SALDO").Value = articulo.DS_SALDO
                ug_Detalle.Rows(ug_Detalle.Rows.Count - 1).Cells("AR_TIPO_ARTI").Value = articulo.AR_TIPO_ARTI
            Else
                aa = aa + 1
            End If

        Next
        If aa > 0 Then
            Avisar(aa & " Productos no se pudieron agregar porque no tiene Stock")
        End If
        ug_Detalle.UpdateData()
        ug_Detalle.Refresh()


        Call Calcular_Totales()

    End Sub
    Private Sub ubtn_quitar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ubtn_quitar.Click

        If ug_Detalle.Rows.Count = 0 Then Exit Sub
        If ug_Detalle.ActiveRow Is Nothing Then Exit Sub

        ug_Detalle.ActiveRow.Delete()

        Call Calcular_Totales()

    End Sub

    'Public Sub AgregarDetalle(ByVal cant_ As Integer, ByVal idarticulo_ As Integer, ByVal desarticulo_ As String, ByVal precio_ As Double, ByVal Dscto_ As Double, ByVal impuesto_ As Double, ByVal total_ As Double, ByVal inIgv_ As Integer, ByVal SubTotal_ As Double, ByVal idCuenta_ As Integer, ByVal CuentaItems_ As Integer)

    '    ug_Detalle.DisplayLayout.Bands(0).AddNew()
    '    ug_Detalle.Rows(ug_Detalle.Rows.Count - 1).Cells("Item").Value = ug_Detalle.Rows.Count
    '    ug_Detalle.Rows(ug_Detalle.Rows.Count - 1).Cells("Cant").Value = cant_
    '    ug_Detalle.Rows(ug_Detalle.Rows.Count - 1).Cells("IdArticulo").Value = idarticulo_
    '    ug_Detalle.Rows(ug_Detalle.Rows.Count - 1).Cells("DesArticulo").Value = desarticulo_
    '    ug_Detalle.Rows(ug_Detalle.Rows.Count - 1).Cells("Precio").Value = precio_
    '    ug_Detalle.Rows(ug_Detalle.Rows.Count - 1).Cells("DSCTO").Value = Dscto_
    '    ug_Detalle.Rows(ug_Detalle.Rows.Count - 1).Cells("Impuesto").Value = impuesto_
    '    ug_Detalle.Rows(ug_Detalle.Rows.Count - 1).Cells("Total").Value = total_
    '    ug_Detalle.Rows(ug_Detalle.Rows.Count - 1).Cells("InIgv").Value = inIgv_
    '    ug_Detalle.Rows(ug_Detalle.Rows.Count - 1).Cells("SubTotal").Value = SubTotal_
    '    ug_Detalle.Rows(ug_Detalle.Rows.Count - 1).Cells("IDCUENTA").Value = idCuenta_
    '    ug_Detalle.Rows(ug_Detalle.Rows.Count - 1).Cells("CuentaItems").Value = CuentaItems_

    '    ug_Detalle.Rows(ug_Detalle.Rows.Count - 1).Cells("DSCTO_OTRO").Value = 0.0

    '    ug_Detalle.UpdateData()
    '    ug_Detalle.Refresh()
    'End Sub

    Private Sub ug_Detalle_AfterRowUpdate(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinGrid.RowEventArgs) Handles ug_Detalle.AfterRowUpdate
        'e.Row.Cells("Total").Value = e.Row.Cells("Precio").Value * e.Row.Cells("Cant").Value
        If bol_cal = False Then Exit Sub

        Dim igv_cal As Double = 0.0
        Dim total_cal As Double = 0.0
        Dim subtotal_cal As Double = 0.0

        Dim precio_Arti As Double = 0.0
        Dim cant As Double = 0.0
        Dim Descto As Double = 0.0
        Dim Descto_OTRO As Double = 0.0
        Dim Descto_POR As Double = 0.0
        Dim descuento As Double = 0.0

        'If uce_TipoDoc.Value = "07" And txt_Ruc_ClientesC.Text = "20339979490" And txt_IdCuenta.Text <> "" Then
        precio_Arti = e.Row.Cells("Precio").Value

        cant = e.Row.Cells("Cant").Value
        Descto = e.Row.Cells("DSCTO").Value
        Descto_POR = e.Row.Cells("DSCTO_Por").Value
        Descto_OTRO = (precio_Arti * (Descto_POR / 100))
        descuento = Descto_OTRO + Descto

        If e.Row.Cells("DS_SALDO").Value >= cant Or txt_Ruc_ClientesC.Text = "20339979490" Or e.Row.Cells("AR_TIPO_ARTI").Value = "S" Or uce_TipoDoc.Value = "07" Or bol_nuevo = False Then

            If txt_Ruc_ClientesC.Text = "20339979490" And txt_IdCuenta.Text <> "" Then
                If e.Row.Cells("CD_INAFECTO").Value = 1 Then
                    subtotal_cal = Math.Round((precio_Arti - descuento) * cant, 2)
                    total_cal = subtotal_cal
                    igv_cal = 0
                Else
                    subtotal_cal = Math.Round((precio_Arti - descuento) * cant, 2)
                    total_cal = Math.Round(subtotal_cal + (subtotal_cal * (ume_Tasa_Igv.Value / 100)), 2)
                    igv_cal = Math.Round((total_cal - subtotal_cal), 2)
                End If
            Else
                If e.Row.Cells("CD_INAFECTO").Value = 1 Then
                    total_cal = Math.Round((precio_Arti - descuento) * cant, 2)
                    subtotal_cal = total_cal
                    igv_cal = 0
                Else
                    total_cal = Math.Round((precio_Arti - descuento) * cant, 2)
                    subtotal_cal = Math.Round(total_cal / ((ume_Tasa_Igv.Value + 100) / 100), 2)
                    igv_cal = Math.Round((total_cal - subtotal_cal), 2)
                End If
            End If



            e.Row.Cells("Total").Value = total_cal
            e.Row.Cells("Impuesto").Value = igv_cal
            e.Row.Cells("SubTotal").Value = Math.Round(subtotal_cal, 2)
            e.Row.Cells("DSCTO_OTRO").Value = Math.Round(Descto_OTRO, 2)

            Call Calcular_Totales()
        Else
            Avisar("Stock No Suficiente")
            e.Row.CancelUpdate()
        End If


    End Sub
    Private Sub ug_Detalle_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles ug_Detalle.KeyDown

        If e.KeyCode = Keys.Enter Then
            ug_Detalle.PerformAction(UltraGridAction.NextCellByTab, False, False)
            ug_Detalle.UpdateData()
        End If

    End Sub
    Private Sub ug_Detalle_BeforeRowsDeleted(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.BeforeRowsDeletedEventArgs) Handles ug_Detalle.BeforeRowsDeleted
        e.DisplayPromptMsg = False
        e.Cancel = False

    End Sub

    Private Sub Calcular_Totales()
        Dim subtotal As Double = 0
        Dim subtotalNA As Double = 0
        Dim igv As Double = 0
        Dim total As Double = 0
        For i As Integer = 0 To ug_Detalle.Rows.Count - 1
            'subtotal += ug_Detalle.Rows(i).Cells("SubTotal").Value
            If ug_Detalle.Rows(i).Cells("Impuesto").Value = 0 Then
                subtotalNA += ug_Detalle.Rows(i).Cells("SubTotal").Value
            End If
            igv += ug_Detalle.Rows(i).Cells("Impuesto").Value
            total += ug_Detalle.Rows(i).Cells("Total").Value
        Next
        'subtotal = (Math.Round(total, 2) - Math.Round(subtotalNA, 2)) / ((ume_Tasa_Igv.Value + 100) / 100)
        subtotal = (Math.Round(total, 2) - subtotalNA) / ((ume_Tasa_Igv.Value + 100) / 100)

        ume_subtotal.Value = Math.Round(Math.Round(subtotal, 2) + Math.Round(subtotalNA, 2), 2) ' ug_Detalle.DisplayLayout.Bands(0).Summaries("sSubtotal").
        ume_SubExone.Value = Math.Round(subtotalNA, 2)
        ume_igv.Value = Math.Round(Math.Round(total, 2) - Math.Round(subtotalNA, 2) - Math.Round(subtotal, 2), 2)
        'ume_total.Value = Math.Round(ume_subtotal.Value + ume_igv.Value, 2) 'ug_Detalle.DisplayLayout.Bands(0).Summaries("sTotal")

        ume_total.Value = Math.Round(total, 2)

    End Sub

    'Private Sub uck_Redondear_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles uck_Redondear.CheckedChanged
    '    If bol_nuevo Then
    '        If uck_Redondear.Checked = True Then
    '            Dim total_Redon As Decimal
    '            Dim Precio As Decimal
    '            Dim Dec As Decimal
    '            Dim TotalSinD As Decimal

    '            TotalSinD = Int(ume_total.Value)
    '            Dec = CType(ume_total.Value, Decimal) - TotalSinD

    '            Dec = Math.Round(Dec / 0.05, 0) * 0.05
    '            total_Redon = TotalSinD + Dec
    '            Precio = Math.Round(total_Redon - ume_total.Value, 2)
    '            '214 +
    '            '215 -

    '            If ume_subtotal.Value <> Math.Round(total_Redon / ((ume_Tasa_Igv.Value / 100) + 1), 2) Then
    '                Call AgregarDetalle(1, IIf(Precio > 0, 214, 215), "REDONDEO", Precio, 0, 0, Precio, 0, Precio, 0, 0)
    '            Else
    '                ume_total.Value = Math.Round(total_Redon, 2)
    '                ume_subtotal.Value = Math.Round(ume_total.Value / ((ume_Tasa_Igv.Value / 100) + 1), 2)
    '                ume_igv.Value = Math.Round(ume_total.Value - ume_subtotal.Value, 2)
    '            End If

    '        Else
    '            For i As Integer = 0 To ug_Detalle.Rows.Count - 1
    '                If ug_Detalle.Rows(i).Cells("IdArticulo").Value = "214" Or ug_Detalle.Rows(i).Cells("IdArticulo").Value = "215" Then
    '                    ug_Detalle.Rows(i).Delete()
    '                    Exit For
    '                End If
    '            Next

    '            Call Calcular_Totales()

    '        End If
    '    End If

    'End Sub


    '-------menu

    Private Sub Tool_Grabar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_Grabar.Click
        If fValida() = False Then Exit Sub
        If uce_TipoDoc.Value = "01" Then
            If Direccion = "" Then
                Avisar("Actualizar la Direccion del Cliente")
                Exit Sub
            End If
        End If
        If txt_Ruc_ClientesC.Text = "20339979490" And uce_TipoDoc.Value = "01" And ucb_CentroCosto.SelectedIndex = 0 Then
            Avisar("Seleccione correctamente el centro de costo.")
            ucb_CentroCosto.Focus()
            Exit Sub
        End If

        ug_Detalle.UpdateData()

        If ug_Detalle.Rows.Count = 0 Then
            Avisar("No hay detalles para continuar.")
            Exit Sub
        End If

        If txt_notas.Text.Trim.Length = 0 Then
            If Not Preguntar("El campo NOTAS esta vacio, Desea Continuar?") Then
                txt_notas.Focus()
                Exit Sub
            End If
        End If

        For F As Integer = 1 To (Math.Ceiling(ug_Detalle.Rows.Count / 37))
            If F > 1 Then
                Obtener_Ult_Num_Compro()
            End If

            Dim rpta_existe As Boolean = False
            Call Validar_existe_num_comprobante(rpta_existe)

            If rpta_existe Then
                Avisar("No se puede continuar!")
                Exit Sub
            End If


            Dim comprobanteBL As New BL.FacturacionBL.SG_FA_TB_COMPROBANTE_C
            Dim comprobanteBE As New BE.FacturacionBE.SG_FA_TB_COMPROBANTE_C

            Dim documentoBL As New BL.FacturacionBL.SG_FA_TB_DOCUMENTO
            Dim documentoBE As New BE.FacturacionBE.SG_FA_TB_DOCUMENTO
            Dim documentoBE2 As New BE.FacturacionBE.SG_FA_TB_DOCUMENTO

            documentoBE.DO_IDEMPRESA = New BE.ContabilidadBE.SG_CO_TB_EMPRESA With {.EM_ID = gInt_IdEmpresa}
            documentoBE.DO_CODIGO = uce_TipoDoc.Value
            documentoBL.get_Documentos_x_Cod(documentoBE)

            documentoBE2.DO_IDEMPRESA = New BE.ContabilidadBE.SG_CO_TB_EMPRESA With {.EM_ID = gInt_IdEmpresa}
            documentoBE2.DO_CODIGO = uce_TipDocRef.Value
            documentoBL.get_Documentos_x_Cod(documentoBE2)

            With comprobanteBE
                .CO_ID = 0
                .CO_TDOC = documentoBE
                .CO_SDOC = uce_Serie.Value
                .CO_NDOC = txt_NumDoc.Text.Trim
                .CO_FEC_EMI = FormatDateTime(udte_fec_emi.Value, DateFormat.ShortDate) & " " & FormatDateTime(Now(), DateFormat.ShortTime)
                .CO_FEC_VEN = CDate(udte_fec_Ven.Value).ToShortDateString
                .CO_SUBTOTAL = ume_subtotal.Value
                .CO_SUBTOTAL_NA = ume_SubExone.Value
                .CO_IGV = ume_igv.Value
                .CO_TOTAL = ume_total.Value
                .CO_IDMONEDA = New BE.FacturacionBE.SG_FA_TB_MONEDA With {.MO_ID = uce_Moneda.Value}
                .CO_TCAM = ume_ValorTipoCambio.Value
                If uce_TipoDoc.Value = "07" Then
                    .CO_TDOC_REF = documentoBE2
                    .CO_SDOC_REF = txt_serie_ref.Text
                    .CO_NDOC_REF = txt_numero_ref.Text
                    .CO_FEC_EMI_REF = ume_fec_emi_ref.Value
                    .CO_FEC_VEN_REF = ume_Fecha_Ven_Ref.Value
                Else
                    .CO_TDOC_REF = Nothing
                    .CO_SDOC_REF = String.Empty
                    .CO_NDOC_REF = String.Empty
                    .CO_FEC_EMI_REF = String.Empty
                    .CO_FEC_VEN_REF = String.Empty
                End If

                .CO_IDEMPRESA = New BE.ContabilidadBE.SG_CO_TB_EMPRESA With {.EM_ID = gInt_IdEmpresa}
                .CO_USUARIO = String.Format("{0}-{1}", Environment.UserName, gStr_Usuario_Sis)
                .CO_TERMINAL = Environment.MachineName
                .CO_FECREG = Now
                .CO_IDCLIENTE = New BE.FacturacionBE.SG_FA_TB_CLIENTE With {.CL_ID = txt_idClienteC.Text.Trim, .CL_NDOC = txt_Ruc_ClientesC.Text.Trim}
                .CO_NOTAS = txt_notas.Text.Trim
                .CO_ESTADO = 1
                .CO_IDPTOVTA = New BE.FacturacionBE.SG_FA_TB_PUNTO_VENTA With {.PV_ID = uce_PuntoVenta.Value}
                .CO_IDFORMA_PAGO = New BE.FacturacionBE.SG_FA_TB_FORMA_PAGO With {.FP_ID = uce_FormaPago.Value}
                .CO_ES_CONTA_PROVI = 0
                .CO_ES_CONTA_CANCE = 0
                .CO_TASA_IGV = ume_Tasa_Igv.Value
                .CO_IDUSUARIO = New BE.ContabilidadBE.SG_CO_TB_USUARIO With {.US_ID = gInt_IdUsuario_Sis}
                .CO_IDDOCU_PAGO = New BE.FacturacionBE.SG_FA_TB_DOCU_PAGO With {.DP_CODIGO = uce_docu_pago.Value}
                .CO_REF_PAGO = txt_ref_pago.Text.Trim
                .CO_ES_REEMPLA = 0 'IIf(uchk_Por_Reem.Checked, 1, 0)
                .CO_DNI = "" 'txt_dni.Text.Trim
                .CO_NUM_HIST = Val(txt_idHistoria.Text)
                .CO_MEDICO = uce_Medico.Value
                .CO_DESTINO = 1
                .CO_IDTIPO_ORI = ucm_Tipo.Value
                .CO_SERIET = 0
                .CO_NUMEROT = 0
                .CO_CENTCOS = IIf(uce_TipoDoc.Value = "01", ucb_CentroCosto.Value, "")
            End With


            Dim detalleBE As BE.FacturacionBE.SG_FA_TB_COMPROBANTE_D

            ug_Detalle.UpdateData()
            Dim subtotal As Double = 0
            Dim subtotalNA As Double = 0
            Dim igv As Double = 0
            Dim total As Double = 0

            For i As Integer = 37 * (F - 1) To IIf(Math.Ceiling(ug_Detalle.Rows.Count / 37) = F, ug_Detalle.Rows.Count - 1, (37 * F) - 1)
                detalleBE = New BE.FacturacionBE.SG_FA_TB_COMPROBANTE_D

                With detalleBE
                    .CD_IDCAB = Nothing
                    .CD_ITEM = ug_Detalle.Rows(i).Cells("Item").Value
                    .CD_IDARTICULO = New BE.FacturacionBE.SG_FA_TB_ARTICULO With {.AR_ID = ug_Detalle.Rows(i).Cells("IdArticulo").Value}
                    .CD_CANT = ug_Detalle.Rows(i).Cells("Cant").Value
                    .CD_PRECIO = ug_Detalle.Rows(i).Cells("Precio").Value
                    .CD_DSCTO = ug_Detalle.Rows(i).Cells("DSCTO").Value
                    .CD_SUBTOTAL = ug_Detalle.Rows(i).Cells("SubTotal").Value
                    .CD_INAFECTO = 0
                    .CD_IGV = ug_Detalle.Rows(i).Cells("Impuesto").Value
                    .CD_TOTAL = ug_Detalle.Rows(i).Cells("Total").Value
                    .CD_IDEMPRESA = New BE.ContabilidadBE.SG_CO_TB_EMPRESA With {.EM_ID = gInt_IdEmpresa}
                    .CD_INC_IGV = 1
                    .CD_IDCUENTA = Val(txt_IdCuenta.Text)
                    .CD_CUENTA_ITEM = ug_Detalle.Rows(i).Cells("Item").Value
                    .CD_DSCTO_OTRO = ug_Detalle.Rows(i).Cells("DSCTO_OTRO").Value
                    .CD_LOTE = ug_Detalle.Rows(i).Cells("CD_IDLOTE").Value

                    If ug_Detalle.Rows(i).Cells("Impuesto").Value = 0 Then
                        subtotalNA += ug_Detalle.Rows(i).Cells("SubTotal").Value
                    End If
                    'subtotal += ug_Detalle.Rows(i).Cells("SubTotal").Value
                    igv += ug_Detalle.Rows(i).Cells("Impuesto").Value
                    total += ug_Detalle.Rows(i).Cells("Total").Value
                End With
                comprobanteBE.Detalles.Add(detalleBE)
            Next
            If Math.Ceiling(ug_Detalle.Rows.Count / 37) > 1 Then
                subtotal = (Math.Round(total, 2) - subtotalNA) / ((ume_Tasa_Igv.Value + 100) / 100)

                comprobanteBE.CO_SUBTOTAL = Math.Round(Math.Round(subtotal, 2) + Math.Round(subtotalNA, 2), 2) ' ug_Detalle.DisplayLayout.Bands(0).Summaries("sSubtotal").
                comprobanteBE.CO_SUBTOTAL_NA = Math.Round(subtotalNA, 2)
                comprobanteBE.CO_IGV = Math.Round(Math.Round(total, 2) - Math.Round(subtotalNA, 2) - Math.Round(subtotal, 2), 2)
                'ume_total.Value = Math.Round(ume_subtotal.Value + ume_igv.Value, 2) 'ug_Detalle.DisplayLayout.Bands(0).Summaries("sTotal")
                comprobanteBE.CO_TOTAL = Math.Round(total, 2)
            End If


            Dim voucherConta As String = String.Empty

            Try
                comprobanteBL.Insert_CajaBot(comprobanteBE, voucherConta, Val(txt_IdCuenta.Text), 1, utxt_IdAlmacenC.Text, IIf(ucb_CentroCosto.SelectedIndex <> -1, ucb_CentroCosto.Value, ""))

                txt_IdComprobante.Text = comprobanteBE.CO_ID
                Ucbo_IDCompro.Items.Add(comprobanteBE.CO_ID)
                Ucbo_Vaucher.Items.Add(voucherConta)
                txt_num_voucher_conta.Text = voucherConta

                comprobanteBE = Nothing
                comprobanteBL = Nothing

                If F = Math.Ceiling(ug_Detalle.Rows.Count / 37) Then
                    Call Avisar("Listo!")

                    If Ucbo_IDCompro.Items.Count > 1 Then
                        Call Avisar("Tiene Mas de un comprobante para imprimir.")
                    End If

                    Tool_Imprimir.Enabled = True
                    Tool_Grabar.Enabled = False
                    Tool_Cancelar.Enabled = False
                    ubtn_agregar.Enabled = False
                    ubtn_quitar.Enabled = False
                    Tool_Nuevo.Enabled = True
                    For Each ctrl As Control In ugb_cabecera.Controls
                        ctrl.Enabled = False
                    Next
                End If


            Catch ex As Exception
                ShowError(ex.Message)
            End Try
        Next
    End Sub

    Private Sub Tool_Nuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_Nuevo.Click
        Dim ult_doc As String = uce_TipoDoc.Value
        Call Iniciar_Ventana()
        bol_nuevo = True
        ugb_cabecera.Enabled = True
        uce_TipoDoc.Value = ult_doc

        If uce_TipoDoc.Value = "01" Then
            ucb_CentroCosto.Enabled = True
        Else
            ucb_CentroCosto.Enabled = False
        End If

        Tool_Imprimir.Enabled = False
        Tool_Grabar.Enabled = True
        ubtn_agregar.Enabled = True
        ubtn_quitar.Enabled = True
        Tool_Nuevo.Enabled = False
    End Sub

    Private Sub Tool_Cancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_Cancelar.Click
        Call Iniciar_Ventana()
    End Sub

    Private Sub Tool_Imprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_Imprimir.Click
        If txt_IdComprobante.Text.Length = 0 Then Exit Sub
        ' For F As Integer = 0 To 0 'Ucbo_IDCompro.Items.Count - 1
        If Ucbo_IDCompro.Items.Count > 1 And Ucbo_IDCompro.SelectedIndex < 0 Then
            Ucbo_IDCompro.SelectedIndex = 0
        End If
        Me.Cursor = Cursors.WaitCursor

        Dim nom_reporte As String = "SG_FA_01.RPT"
        Dim nom_param_linea As String = ""
        Dim texto_nota_cre As String = ""
        Dim bol_es_nc As Boolean = False

        Dim instance As New Printing.PrinterSettings
        Dim impresosaPredt As String = instance.PrinterName
        Dim numimpre As String = ""

        If impresosaPredt.LastIndexOf("\") < 0 Then
            If impresosaPredt <> "EPSON LX-350" Then
                numimpre = "1"
            End If
        Else
            If impresosaPredt.Substring(impresosaPredt.LastIndexOf("\") + 1, impresosaPredt.Length - impresosaPredt.Substring(0, impresosaPredt.LastIndexOf("\")).Length - 1) <> "EPSON LX-350" Then
                numimpre = "1"
            End If
        End If

        Select Case uce_TipoDoc.Value
            Case "01" 'factura
                nom_reporte = "SG_FA_01.RPT"
                nom_reporte = "SG_FA_01_" & gInt_IdEmpresa.ToString + numimpre & ".RPT"
                nom_param_linea = "LINFAC"
            Case "03" 'boleta
                nom_reporte = "SG_FA_06.RPT"
                nom_reporte = "SG_FA_06_" & gInt_IdEmpresa.ToString + numimpre & ".RPT"
                nom_param_linea = "LINBOL"
            Case "07" 'nota de credito
                nom_reporte = "SG_FA_07.RPT"
                nom_reporte = "SG_FA_07_" & gInt_IdEmpresa.ToString + numimpre & ".RPT"
                nom_param_linea = "LINNCR"

                ' texto_nota_cre = "Por la anulacion del comprobante " & uce_TipDocRef.Value.ToString & " - " & txt_serie_ref.Text & " - " & txt_numero_ref.Text & " emitido el " & ume_fec_emi_ref.Value.ToString
                ' bol_es_nc = True

        End Select
        'Ucbo_IDCompro.SelectedIndex = F
        Dim idComprobante As Integer = IIf(Ucbo_IDCompro.Items.Count > 1, Val(Ucbo_IDCompro.Text), Val(txt_IdComprobante.Text))
        Dim reportesBL As New BL.FacturacionBL.SG_FA_Reportes
        Dim crystalBL As New LR.ClsReporte
        Dim dt_comprobante As DataTable = reportesBL.get_Comprobante(idComprobante, gInt_IdEmpresa)
        Dim Monto_en_Letras As String = Letras(dt_comprobante.Rows(0)("CO_TOTAL")).ToUpper
        Dim moneda As String = uce_Moneda.Value

        Dim obrmo As New BL.FacturacionBL.SG_FA_TB_MONEDA
        Dim drr_MOV As System.Data.SqlClient.SqlDataReader
        drr_MOV = obrmo.get_Moneda(moneda, gInt_IdEmpresa)
        If drr_MOV.HasRows Then
            drr_MOV.Read()
            Monto_en_Letras = Monto_en_Letras & " " & drr_MOV("MO_DESCRIPCION")
        End If
        drr_MOV.Close()

        Call Completar_Lineas(nom_param_linea, dt_comprobante, bol_es_nc, texto_nota_cre)

        Dim f As Integer
        f = Ucbo_IDCompro.SelectedIndex
        Ucbo_Vaucher.SelectedIndex = f

        'crystalBL.Muestra_Reporte(gStr_RutaRep & "\" & nom_reporte, dt_comprobante, "", "pMontoLetras;" & Monto_en_Letras, "pMoneda;" & moneda, "pVaucher;" & Val(Ucbo_Vaucher.Text.Substring(txt_num_voucher_conta.Text.Length - 6, 6)))
        crystalBL.Muestra_Reporte(gStr_RutaRep & "\" & nom_reporte, dt_comprobante, "", "pMontoLetras;" & Monto_en_Letras, "pMoneda;" & moneda, "pVaucher;" & IIf(Ucbo_IDCompro.Items.Count > 1, Val(Ucbo_Vaucher.Text), txt_num_voucher_conta.Text), "USU;" & String.Format("{0}-{1}", Environment.UserName, gStr_Usuario_Sis), "Pmedico;" & uce_Medico.Text)

        crystalBL = Nothing
        reportesBL = Nothing

        Me.Cursor = Cursors.Default

    End Sub

    Private Sub Tool_Salir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_Salir.Click
        Me.Close()
    End Sub

    Private Sub ubt_CambioCobertura_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ubt_CambioCobertura.Click
        If ug_Detalle.Rows.Count = 0 Then Exit Sub
        If ug_Detalle.ActiveRow Is Nothing Then Exit Sub
        If txt_Ruc_ClientesC.Text <> "20339979490" And txt_IdCuenta.Text <> "" And uchk_SeguroEps.Checked = True Then
            ugb_docref.Visible = True

            txt_PagoVariable2.Text = Math.Round((ug_Detalle.ActiveRow.Cells("DSCTO").Value * 100) / ug_Detalle.ActiveRow.Cells("Precio").Value, 2)
        End If
    End Sub

    Private Sub ubtn_aceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ubtn_aceptar.Click
        Dim descuento As Decimal = "0.00"
        descuento = Math.Round((ug_Detalle.ActiveRow.Cells("Precio").Value * Val(txt_PagoVariable2.Value)) / 100, 2)
        ug_Detalle.ActiveRow.Cells("DSCTO").Value = descuento
        ug_Detalle.UpdateData()
        ug_Detalle.Refresh()


        Call Calcular_Totales()
        ugb_docref.Visible = False
    End Sub
End Class