Imports Infragistics.Win.UltraWinGrid
Public Class FA_PR_Emi_ComproFacPac
    'Dim imp_min_bol As Double = 700 'importe minimo para boletas en el caso que se pida DNI
    Public bol_nuevo As Boolean = True

    Private Sub pKeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Me.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Return) Then
            SendKeys.Send("{TAB}")
            e.Handled = True
        End If
    End Sub

    Private Sub pLostfocus(ByVal sender As Object, ByVal e As System.EventArgs) ' Handles txt_DesCorto.LostFocus, txt_Descripcion.LostFocus
        sender.BackColor = Color.White
        If sender.Text.Trim.Length < 1 Then
            sender.BackColor = Color.LightPink
        End If
    End Sub

    Private Sub FA_PR_Emi_Compro_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        Me.Refresh()
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

    Private Sub FA_PR_Emi_Compro_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.KeyPreview = True

        If Verificar_Estado_Caja() And bol_nuevo Then
            Call Avisar("Falta Aperturar la caja para la fecha : " & gDat_Fecha_Sis.ToShortDateString)
            ugb_cabecera.Enabled = False
            ToolS_Mantenimiento.Enabled = False
            ugb_docref.Visible = False
            Exit Sub
        Else
            ugb_cabecera.Enabled = True
            ToolS_Mantenimiento.Enabled = True
            ugb_docref.Visible = False
        End If


        Call Cargar_Combos()
        txt_IdCuenta.ButtonsRight(0).Appearance.Image = My.Resources._104
        txt_ruc_cliente.ButtonsRight(0).Appearance.Image = My.Resources._104
        txt_NumDoc.ButtonsRight(0).Appearance.Image = My.Resources._16__Page_number_
        txt_Ruc_ClientesC.ButtonsRight(0).Appearance.Image = My.Resources._104
        ubtn_aceptar.Appearance.Image = My.Resources._16__Ok_
        ubtn_agregar_Adela.Appearance.Image = My.Resources._092
        ubtn_Quitar_adela.Appearance.Image = My.Resources._16__Delete_

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

    'Private Function Tiene_TipodeCambio() As Boolean
    '    Dim respuesta As Boolean = False

    '    Dim rpta As String = String.Empty
    '    Dim paraetrosBL As New BL.FacturacionBL.SG_FA_TB_PARAMETROS
    '    Dim paraetrosBE As New BE.FacturacionBE.SG_FA_TB_PARAMETROS

    '    paraetrosBE.AD_IDEMPRESA = New BE.ContabilidadBE.SG_CO_TB_EMPRESA With {.EM_ID = gInt_IdEmpresa}
    '    paraetrosBE.AD_TIPO = "SISTE"
    '    paraetrosBE.AD_NOMBRE = "TC"

    '    rpta = paraetrosBL.get_Valor(paraetrosBE)

    '    If rpta = "F" Then

    '        Dim tipocambioBL As New BL.FacturacionBL.SG_FA_TB_PARIDAD
    '        Dim tipocambioBE As New BE.FacturacionBE.SG_FA_TB_PARIDAD

    '        tipocambioBE.PA_IDEMPRESA = New BE.ContabilidadBE.SG_CO_TB_EMPRESA With {.EM_ID = gInt_IdEmpresa}
    '        tipocambioBE.PA_FECHA = gDat_Fecha_Sis.ToShortDateString
    '        Dim dt_tc As DataTable = tipocambioBL.get_Pariedad_x_Fecha(tipocambioBE)

    '        If dt_tc.Rows.Count > 0 Then
    '            respuesta = True
    '        End If

    '        dt_tc = Nothing

    '        tipocambioBE = Nothing
    '        tipocambioBL = Nothing

    '    Else ' rpta = "C"  ==>  de contabilidad

    '        Dim tipocamBL As New BL.ContabilidadBL.SG_CO_TB_TIPOCAMBIO
    '        Dim tipocamBE As New BE.ContabilidadBE.SG_CO_TB_TIPOCAMBIO

    '        tipocamBE.TC_IDEMPRESA = New BE.ContabilidadBE.SG_CO_TB_EMPRESA With {.EM_ID = gInt_IdEmpresa}
    '        tipocamBE.TC_FECHA = gDat_Fecha_Sis.ToShortDateString
    '        tipocamBE.TC_IDMONEDA = New BE.ContabilidadBE.SG_CO_TB_MONEDA With {.MO_CODIGO = 2}
    '        tipocamBL.getTipoCambio(tipocamBE)

    '        If tipocamBE.TC_VENTA > 0 Then
    '            respuesta = True
    '        End If

    '        tipocamBE = Nothing
    '        tipocamBL = Nothing

    '    End If

    '    Return respuesta

    'End Function

    Public Sub Cargar_Comprobante_toNC(ByVal entidad As BE.FacturacionBE.SG_FA_TB_COMPROBANTE_C)
        Try

            Dim comprobantesBL As New BL.FacturacionBL.SG_FA_TB_COMPROBANTE_C
            Dim ds_comprobante As New DataSet

            ds_comprobante = comprobantesBL.get_Comprobante_x_Id(entidad)

            With ds_comprobante.Tables(0)

                uce_PuntoVenta.Value = .Rows(0)("CO_IDPTOVTA")
                uce_TipoDoc.Value = "07"
                'uce_TipoDoc.Value = .Rows(0)("CO_TDOC")
                'uce_Serie.Value = .Rows(0)("CO_SDOC")
                'txt_NumDoc.Value = .Rows(0)("CO_NDOC")
                uce_TipDocRef.Value = .Rows(0)("CO_TDOC")
                txt_serie_ref.Value = .Rows(0)("CO_SDOC")
                txt_numero_ref.Value = .Rows(0)("CO_NDOC")

                ume_fec_emi_ref.Value = .Rows(0)("CO_FEC_EMI")
                ume_fec_ven_ref.Value = .Rows(0)("CO_FEC_VEN")


                ' Call Cargar_Comprobante_para_NotCred(uce_TipDocRef.Value, txt_serie_ref.Text.Trim, txt_numero_ref.Text.Trim)

                txt_notas.Text = .Rows(0)("CO_NOTAS") & "  Doc. de Ref. : " & uce_TipDocRef.Text & "-" & txt_serie_ref.Text & "-" & txt_numero_ref.Text

                'txt_notas.Text = .Rows(0)("CO_NOTAS")
                'txt_notas.Enabled = False
                txt_idClienteC.Value = .Rows(0)("CO_IDCLIENTE")
                txt_idHistoria.Value = Val(.Rows(0)("CO_IDNUM_HIST").ToString)
                Dim historiaBL As New BL.AdmisionBL.SG_AD_TB_HISTO_CLINI
                Dim dt_histo_tmp As DataTable = historiaBL.getHistorias_Base_x_Id(txt_idHistoria.Value, gInt_IdEmpresa)

                If dt_histo_tmp.Rows.Count > 0 Then
                    txt_Des_Cliente.Text = dt_histo_tmp.Rows(0)("HC_APE_PAT") & " " & dt_histo_tmp.Rows(0)("HC_APE_MAT") & " " & dt_histo_tmp.Rows(0)("HC_NOMBRE1")
                    txt_ruc_cliente.Text = dt_histo_tmp.Rows(0)("HC_NDOC")
                    txt_IdCliente.Value = dt_histo_tmp.Rows(0)("HC_IDCLIENTE")
                    uce_tip_doc.Value = dt_histo_tmp.Rows(0)("HC_TDOC")
                    txt_Titular.Text = dt_histo_tmp.Rows(0)("HC_TITULAR")
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
                'udte_fec_emi.Value = .Rows(0)("CO_FEC_EMI")
                'udte_fec_Ven.Value = .Rows(0)("CO_FEC_VEN")
                udte_fec_emi.Value = Now
                udte_fec_Ven.Value = Now

                txt_num_voucher_conta.Text = .Rows(0)("CO_NUMVOUCHER").ToString
                txt_IdComprobante.Text = .Rows(0)("CO_ID")
                uce_Medico.Value = .Rows(0)("CO_MEDICO")
                ucm_Tipo.Value = .Rows(0)("CO_IDTIPO_ORI")

            End With


            Call LimpiaGrid(ug_Detalle, uds_detalle)

            'Detalle del Comprobante
            For i As Integer = 0 To ds_comprobante.Tables(1).Rows.Count - 1
                If ds_comprobante.Tables(1).Rows(i)("CD_IDARTICULO") <> "214" And ds_comprobante.Tables(1).Rows(i)("CD_IDARTICULO") <> "215" Then


                    ug_Detalle.DisplayLayout.Bands(0).AddNew()

                    With ds_comprobante.Tables(1)

                        ug_Detalle.Rows(i).Cells("Item").Value = ds_comprobante.Tables(1).Rows(i)("CD_ITEM")
                        ug_Detalle.Rows(i).Cells("Cant").Value = ds_comprobante.Tables(1).Rows(i)("CD_CANT")
                        ug_Detalle.Rows(i).Cells("IdArticulo").Value = ds_comprobante.Tables(1).Rows(i)("CD_IDARTICULO")

                        ug_Detalle.Rows(i).Cells("DesArticulo").Value = ds_comprobante.Tables(1).Rows(i)("AR_DESCRIPCION")
                        ug_Detalle.Rows(i).Cells("Precio").Value = ds_comprobante.Tables(1).Rows(i)("CD_PRECIO")
                        ug_Detalle.Rows(i).Cells("DSCTO").Value = .Rows(i)("CD_DSCTO")

                        ug_Detalle.Rows(i).Cells("SubTotal").Value = ds_comprobante.Tables(1).Rows(i)("CD_SUBTOTAL")
                        ug_Detalle.Rows(i).Cells("Impuesto").Value = ds_comprobante.Tables(1).Rows(i)("CD_IGV")
                        ug_Detalle.Rows(i).Cells("Total").Value = ds_comprobante.Tables(1).Rows(i)("CD_TOTAL")
                        ug_Detalle.Rows(i).Cells("InIGV").Value = ds_comprobante.Tables(1).Rows(i)("CD_INC_IGV")

                        ug_Detalle.Rows(i).Cells("IDCUENTA").Value = Val(.Rows(i)("CD_IDCUENTA").ToString)
                        If Val(.Rows(i)("CD_IDCUENTA").ToString) > 0 Then
                            txt_IdCuenta.Text = Val(.Rows(i)("CD_IDCUENTA").ToString)
                        End If
                        ug_Detalle.Rows(i).Cells("CuentaItems").Value = Val(.Rows(i)("CD_CUENTA_ITEM").ToString)

                        ug_Detalle.Rows(i).Cells("DSCTO_OTRO").Value = Val(.Rows(i)("CD_DSCTO_OTRO").ToString)


                    End With

                    ug_Detalle.UpdateData()
                End If
            Next

            Dim obrT As New BL.AdmisionBL.SG_AD_TB_CUENTA_CAB
            Dim obeC As New BE.AdmisionBE.SG_AD_TB_CUENTA_CAB
            obeC.CC_ID = Val(txt_IdCuenta.Text)
            obeC.HasRow = False
            obrT.SEL04(obeC)
            If obeC.HasRow Then
                With obeC
                    txt_idPreFactura.Text = .CC_IDPREFAC
                    'txt_COAseguroPorc.Text = 100 - .CC_SIT_COPG_VARI
                    'txt_fijo.Text = .CC_SIT_COPG_FIJO
                End With
            End If
            Dim obe As New BE.FacturacionBE.SG_FA_TB_PRE_FACTURA_CAB
            Dim obr As New BL.FacturacionBL.SG_FA_TB_PRE_FACTURA_CAB
            obe.PF_ID = Val(txt_idPreFactura.Text)
            obe.HasRow = False
            obr.SEL01(obe)
            If obe.HasRow Then
                With obe

                    Dim Presupuesto As String = ""
                    Presupuesto = IIf(.PF_IDPRESUPUESTO = 0, "", .PF_IDPRESUPUESTO)
                    If Presupuesto <> "" Then
                        Dim PRESBL As New BL.FacturacionBL.SG_FA_TB_PRESUPUESTO_CAB
                        Dim PRESBE As New BE.FacturacionBE.SG_FA_TB_PRESUPUESTO_CAB
                        PRESBE.PR_ID = Val(Presupuesto)
                        PRESBE.HasRow = False
                        PRESBL.SEL02(PRESBE)
                        If PRESBE.HasRow Then

                            With PRESBE
                                txt_IDTratamiento.Text = .PR_IDPAQUETE
                                Dim TBL As New BL.FacturacionBL.SG_FA_TB_PAQUETE_CAB
                                Dim TBE As New BE.FacturacionBE.SG_FA_TB_PAQUETE_CAB
                                TBE.PC_ID = .PR_IDPAQUETE
                                TBL.SEL02(TBE)
                                If TBE.HasRow = True Then
                                    txt_CuentaCon.Text = TBE.PC_CuentaCont
                                Else
                                    txt_CuentaCon.Text = ""
                                End If
                            End With
                        End If
                    Else
                        txt_IDTratamiento.Text = ""
                        txt_CuentaCon.Text = ""
                    End If
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

            txt_NumDoc.ButtonsRight(0).Enabled = True
            ds_comprobante = Nothing
            comprobantesBL = Nothing

            'Tool_Nuevo.Enabled = False
            'Tool_Grabar.Enabled = False
            'Tool_Nuevo.Enabled = False
            'ugb_cabecera.Enabled = False

            'ubtn_agregar.Enabled = False
            'ubtn_quitar.Enabled = False
            '  uce_Empresas.Enabled = False
            ubtn_agregar.Visible = True
            ubtn_quitar.Visible = True
        Catch ex As Exception
            ShowError("Ocurrio un problema " & ex.Message)
        End Try
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
                Dim dt_histo_tmp As DataTable = historiaBL.getHistorias_Base_x_Id(txt_idHistoria.Value, gInt_IdEmpresa)

                If dt_histo_tmp.Rows.Count > 0 Then
                    txt_Des_Cliente.Text = dt_histo_tmp.Rows(0)("HC_APE_PAT") & " " & dt_histo_tmp.Rows(0)("HC_APE_MAT") & " " & dt_histo_tmp.Rows(0)("HC_NOMBRE1")
                    txt_ruc_cliente.Text = dt_histo_tmp.Rows(0)("HC_NDOC")
                    txt_IdCliente.Value = dt_histo_tmp.Rows(0)("HC_IDCLIENTE")
                    uce_tip_doc.Value = dt_histo_tmp.Rows(0)("HC_TDOC")
                    txt_Titular.Text = dt_histo_tmp.Rows(0)("HC_TITULAR")
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
                uce_Medico.Value = .Rows(0)("CO_MEDICO")
                ucm_Tipo.Value = .Rows(0)("CO_IDTIPO_ORI")

            End With


            Call LimpiaGrid(ug_Detalle, uds_detalle)

            'Detalle del Comprobante
            For i As Integer = 0 To ds_comprobante.Tables(1).Rows.Count - 1
                ug_Detalle.DisplayLayout.Bands(0).AddNew()

                With ds_comprobante.Tables(1)

                    ug_Detalle.Rows(i).Cells("Item").Value = ds_comprobante.Tables(1).Rows(i)("CD_ITEM")
                    ug_Detalle.Rows(i).Cells("Cant").Value = ds_comprobante.Tables(1).Rows(i)("CD_CANT")
                    ug_Detalle.Rows(i).Cells("IdArticulo").Value = ds_comprobante.Tables(1).Rows(i)("CD_IDARTICULO")

                    ug_Detalle.Rows(i).Cells("DesArticulo").Value = ds_comprobante.Tables(1).Rows(i)("AR_DESCRIPCION")
                    ug_Detalle.Rows(i).Cells("Precio").Value = ds_comprobante.Tables(1).Rows(i)("CD_PRECIO")
                    ug_Detalle.Rows(i).Cells("DSCTO").Value = .Rows(i)("CD_DSCTO")

                    ug_Detalle.Rows(i).Cells("SubTotal").Value = ds_comprobante.Tables(1).Rows(i)("CD_SUBTOTAL")
                    ug_Detalle.Rows(i).Cells("Impuesto").Value = ds_comprobante.Tables(1).Rows(i)("CD_IGV")
                    ug_Detalle.Rows(i).Cells("Total").Value = ds_comprobante.Tables(1).Rows(i)("CD_TOTAL")
                    ug_Detalle.Rows(i).Cells("InIGV").Value = ds_comprobante.Tables(1).Rows(i)("CD_INC_IGV")

                    ug_Detalle.Rows(i).Cells("IDCUENTA").Value = Val(.Rows(i)("CD_IDCUENTA").ToString)
                    If Val(.Rows(i)("CD_IDCUENTA").ToString) > 0 Then
                        txt_IdCuenta.Text = Val(.Rows(i)("CD_IDCUENTA").ToString)
                    End If
                    ug_Detalle.Rows(i).Cells("CuentaItems").Value = Val(.Rows(i)("CD_CUENTA_ITEM").ToString)

                    ug_Detalle.Rows(i).Cells("DSCTO_OTRO").Value = Val(.Rows(i)("CD_DSCTO_OTRO").ToString)

                End With
                If ug_Detalle.Rows(i).Cells("IdArticulo").Value = "214" Or ug_Detalle.Rows(i).Cells("IdArticulo").Value = "215" Then
                    uck_Redondear.Checked = True
                End If
                ug_Detalle.UpdateData()

            Next

            Dim obrT As New BL.AdmisionBL.SG_AD_TB_CUENTA_CAB
            Dim obeC As New BE.AdmisionBE.SG_AD_TB_CUENTA_CAB

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
            Tool_Cancelar.Enabled = False
            Tool_Imprimir.Enabled = True
            ugb_cabecera.Enabled = False

            ubtn_agregar.Enabled = False
            ubtn_quitar.Enabled = False
            '  uce_Empresas.Enabled = False

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

        Dim medicosBL As New BL.AdmisionBL.SG_AD_TB_MEDICO
        uce_Medico.DataSource = medicosBL.get_Medicos(gInt_IdEmpresa)
        uce_Medico.ValueMember = "ME_CODIGO"
        uce_Medico.DisplayMember = "NOMBRES"
        medicosBL = Nothing

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
            '  tipocambioBE.PA_FECHA = CDate(udte_fec_emi.Value).ToShortDateString
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

    Private Sub udte_fec_emi_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles udte_fec_emi.ValueChanged
        Call Obtener_TipoCambio_dia()
        Call Cargar_Tasas_Impuestos()
        udte_fec_Ven.Value = udte_fec_emi.Value
    End Sub

    '-------------pacientes clientes

    Private Sub Ayuda_Anexo_Cab_C()
        FA_PR_ListaClientesAyuda.Int_Opcion = 1
        FA_PR_ListaClientesAyuda.ShowDialog()

        Dim matriz As List(Of String) = FA_PR_ListaClientesAyuda.GetLista

        'txt_ruc_cliente.ButtonsRight("editar").Enabled = False

        If matriz.Count > 0 Then
            txt_idClienteC.Text = matriz(0)
            txt_Ruc_ClientesC.Text = matriz(1)
            txt_Des_ClienteC.Text = matriz(2)
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
                        ubtn_agregar.Focus()
                    End If
                End If
            End If

        End If

        clienteBE = Nothing
        clienteBL = Nothing

    End Sub
    'Private Sub Ayuda_Anexo_Cab()
    '    ' FA_PR_ListaClientesAyuda.Int_Opcion = 1
    '    AD_PR_BuscaPaciente.ShowDialog()

    '    Dim matriz As List(Of String) = AD_PR_BuscaPaciente.GetLista

    '    'txt_ruc_cliente.ButtonsRight("editar").Enabled = False

    '    If matriz.Count > 0 Then

    '        txt_IdCliente.Text = matriz(1)
    '        txt_idHistoria.Text = matriz(0)
    '        txt_ruc_cliente.Text = matriz(9)
    '        uce_tip_doc.Value = matriz(8)
    '        txt_Des_Cliente.Text = matriz(2)
    '        'udte_fechaNac.Value = matriz(10)
    '        'txt_Edad.Value = Int(DateDiff("m", matriz(10), Date.Now) / 12)
    '        ' txt_ruc_cliente.ButtonsRight("editar").Enabled = True

    '        txt_idClienteC.Text = matriz(1)
    '        txt_Ruc_ClientesC.Text = matriz(9)
    '        txt_Des_ClienteC.Text = matriz(2)

    '        '   AgregarCuentas()
    '    End If

    'End Sub
    'Private Sub Buscar_Cliente()

    '    Dim clienteBL As New BL.AdmisionBL.SG_AD_TB_HISTO_CLINI
    '    Dim clienteBE As New BE.AdmisionBE.SG_AD_TB_HISTO_CLINI

    '    clienteBE.HC_NDOC = txt_ruc_cliente.Text.Trim
    '    clienteBE.HC_IDEMPRESA = gInt_IdEmpresa
    '    clienteBE.HC_TDOC = uce_tip_doc.Value
    '    clienteBL.get_Historias_x_Doc(clienteBE)

    '    If clienteBE.HasRow Then
    '        txt_IdCliente.Text = clienteBE.HC_IDCLIENTE
    '        txt_idHistoria.Text = clienteBE.HC_NUM_HIST
    '        txt_Des_Cliente.Text = clienteBE.HC_NOMBRE1

    '        txt_idClienteC.Text = clienteBE.HC_IDCLIENTE
    '        txt_Ruc_ClientesC.Text = txt_ruc_cliente.Text.Trim
    '        txt_Des_ClienteC.Text = clienteBE.HC_NOMBRE1

    '        '   AgregarCuentas()
    '    Else
    '        uce_Medico.Enabled = True
    '        ucm_Tipo.Enabled = True
    '        Avisar("El Paciente no existe!")
    '        'If Preguntar("El cliente no existe!, Desea Crearlo?") Then

    '        '    FA_PR_IngClienteRapido.str_num_ruc = txt_ruc_cliente.Text.Trim
    '        '    'FA_PR_IngClienteRapido.str_ = uce_tip_doc.Value
    '        '    FA_PR_IngClienteRapido.ShowDialog()
    '        '    If FA_PR_IngClienteRapido.bol_Grabo Then
    '        '        clienteBE.HC_NDOC = FA_PR_IngClienteRapido.txt_num_doc.Text.Trim
    '        '        clienteBE.HC_IDEMPRESA = gInt_IdEmpresa
    '        '        clienteBE.HC_TDOC = FA_PR_IngClienteRapido.uce_TipoDoc.Value
    '        '        clienteBL.get_Historias_x_Doc(clienteBE)
    '        '        If clienteBE.HasRow Then
    '        '            txt_IdCliente.Text = clienteBE.HC_IDCLIENTE
    '        '            txt_idHistoria.Text = clienteBE.HC_NUM_HIST
    '        '            txt_Des_Cliente.Text = clienteBE.HC_NOMBRE1
    '        '            uce_tip_doc.Value = clienteBE.HC_TDOC
    '        '            txt_ruc_cliente.Text = clienteBE.HC_NDOC
    '        '            'udte_fechaNac.Value = clienteBE.HC_FNAC
    '        '            'txt_Edad.Value = Int(DateDiff("m", clienteBE.HC_FNAC, Date.Now) / 12)
    '        '        End If
    '        '    End If
    '        'End If

    '    End If

    '    clienteBE = Nothing
    '    clienteBL = Nothing

    'End Sub
    'Private Sub txt_ruc_cliente_EditorButtonClick(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinEditors.EditorButtonEventArgs) Handles txt_ruc_cliente.EditorButtonClick
    '    Select Case e.Button.Key
    '        Case "ayuda"
    '            Call Ayuda_Anexo_Cab()
    '        Case "editar"

    '    End Select
    'End Sub
    'Private Sub txt_ruc_cliente_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_ruc_cliente.ValueChanged
    '    If txt_ruc_cliente.Text.Trim.Length = 0 Then
    '        txt_IdCliente.Text = String.Empty
    '        txt_Des_Cliente.Text = String.Empty
    '    End If
    'End Sub
    'Private Sub txt_ruc_cliente_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_ruc_cliente.KeyDown
    '    If e.KeyCode = Keys.Enter Or e.KeyCode = Keys.Tab Then
    '        Call Buscar_Cliente()
    '    End If

    '    If e.KeyCode = Keys.F2 Then Call Ayuda_Anexo_Cab()
    'End Sub

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

    Private Sub txt_NumDoc_EditorButtonClick(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinEditors.EditorButtonEventArgs) Handles txt_NumDoc.EditorButtonClick
        ugb_docref.Visible = True
    End Sub

    Private Sub txt_NumDoc_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_NumDoc.Leave
        txt_NumDoc.Text = txt_NumDoc.Text.PadLeft(7, "0")

        Call Validar_existe_num_comprobante(Nothing)

    End Sub

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

    Private Sub uce_TipoDoc_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles uce_TipoDoc.KeyDown
        If e.KeyCode = Keys.Enter Then
            '  If uce_TipoDoc.Value = "07" Then
            'ugb_docref.Visible = True
            'uce_TipDocRef.Focus()
            'Else
            txt_ruc_cliente.Focus()
            'End If
        End If
    End Sub

    Private Sub uce_TipoDoc_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles uce_TipoDoc.ValueChanged

        Call Cargar_Series_Doc()
        Call Obtener_Ult_Num_Compro()

        'Notas de Credito
        If uce_TipoDoc.Value = "07" Then
            txt_NumDoc.ButtonsRight(0).Enabled = True
        Else
            txt_NumDoc.ButtonsRight(0).Enabled = False
        End If




    End Sub

    Private Sub ubtn_agregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ubtn_agregar.Click
        'FA_PR_ListaArticuloAyuda.MdiParent = CO_MN_MenuInicial

        FA_PR_ListaArticuloAyuda.Int_Opcion = 1
        FA_PR_ListaArticuloAyuda.IGVTas = ume_Tasa_Igv.Value
        FA_PR_ListaArticuloAyuda.ShowDialog()

        Dim matriz As List(Of BE.FacturacionBE.SG_FA_TB_ARTICULO) = FA_PR_ListaArticuloAyuda.GetLista
        Dim igv_cal As Double = 0
        Dim total_cal As Double = 0
        Dim subtotal_cal As Double = 0
        Dim precio_Arti As Double = 0
        '  Dim bruto As Double = 0
        Dim cant As Double = 0

        For Each articulo As BE.FacturacionBE.SG_FA_TB_ARTICULO In matriz

            precio_Arti = articulo.AR_PRECIO_VENTA

            If articulo.AR_INCLUYE_IGV = 1 Then

                subtotal_cal = Math.Round(precio_Arti / ((ume_Tasa_Igv.Value + 100) / 100), 2)
                igv_cal = Math.Round(precio_Arti - subtotal_cal, 2)
                total_cal = precio_Arti
                precio_Arti = subtotal_cal
            Else

                subtotal_cal = precio_Arti
                igv_cal = precio_Arti * (ume_Tasa_Igv.Value / 100)
                total_cal = subtotal_cal + igv_cal
            End If

            Call AgregarDetalle(1, articulo.AR_ID, articulo.AR_DESCRIPCION, precio_Arti, 0, igv_cal, total_cal, articulo.AR_INCLUYE_IGV, subtotal_cal, 0, 0, 0)

        Next

        Call Calcular_Totales()
    End Sub

    Public Sub AgregarDetalle(ByVal cant_ As Integer, ByVal idarticulo_ As Integer, ByVal desarticulo_ As String, ByVal precio_ As Double, ByVal Dscto_ As Double, ByVal impuesto_ As Double, ByVal total_ As Double, ByVal inIgv_ As Integer, ByVal SubTotal_ As Double, ByVal idCuenta_ As Integer, ByVal CuentaItems_ As Integer, IdCompro_Adela As Integer)

        ug_Detalle.DisplayLayout.Bands(0).AddNew()

        ug_Detalle.Rows(ug_Detalle.Rows.Count - 1).Cells("Item").Value = ug_Detalle.Rows.Count
        ug_Detalle.Rows(ug_Detalle.Rows.Count - 1).Cells("Cant").Value = cant_
        ug_Detalle.Rows(ug_Detalle.Rows.Count - 1).Cells("IdArticulo").Value = idarticulo_
        ug_Detalle.Rows(ug_Detalle.Rows.Count - 1).Cells("DesArticulo").Value = desarticulo_
        ug_Detalle.Rows(ug_Detalle.Rows.Count - 1).Cells("Precio").Value = precio_
        ug_Detalle.Rows(ug_Detalle.Rows.Count - 1).Cells("DSCTO").Value = Dscto_
        ug_Detalle.Rows(ug_Detalle.Rows.Count - 1).Cells("Impuesto").Value = impuesto_
        ug_Detalle.Rows(ug_Detalle.Rows.Count - 1).Cells("Total").Value = total_
        ug_Detalle.Rows(ug_Detalle.Rows.Count - 1).Cells("InIgv").Value = inIgv_
        ug_Detalle.Rows(ug_Detalle.Rows.Count - 1).Cells("SubTotal").Value = SubTotal_
        ug_Detalle.Rows(ug_Detalle.Rows.Count - 1).Cells("IDCUENTA").Value = idCuenta_
        ug_Detalle.Rows(ug_Detalle.Rows.Count - 1).Cells("CuentaItems").Value = CuentaItems_
        ug_Detalle.Rows(ug_Detalle.Rows.Count - 1).Cells("DSCTO_OTRO").Value = 0.0
        ug_Detalle.Rows(ug_Detalle.Rows.Count - 1).Cells("IDCOMPRO_ADELA").Value = IdCompro_Adela


        ug_Detalle.UpdateData()
        ug_Detalle.Refresh()

    End Sub

    Private Sub Calcular_Totales()

        Dim subtotal As Double = 0
        'Dim igv As Double = 0
        'Dim total As Double = 0
        Dim precioRe As Double = 0
        For i As Integer = 0 To ug_Detalle.Rows.Count - 1
            If ug_Detalle.Rows(i).Cells("IdArticulo").Value <> "214" And ug_Detalle.Rows(i).Cells("IdArticulo").Value <> "215" Then
                subtotal += ug_Detalle.Rows(i).Cells("SubTotal").Value
                'igv += ug_Detalle.Rows(i).Cells("Impuesto").Value
                'total += ug_Detalle.Rows(i).Cells("Total").Value
            Else
                precioRe = ug_Detalle.Rows(i).Cells("SubTotal").Value
            End If
        Next

        ume_subtotal.Value = Math.Round(subtotal, 2) ' ug_Detalle.DisplayLayout.Bands(0).Summaries("sSubtotal").
        ume_igv.Value = Math.Round(subtotal * (ume_Tasa_Igv.Value / 100), 2) 'ug_Detalle.DisplayLayout.Bands(0).Summaries("sIgv")
        'ume_total.Value = Math.Round(ume_subtotal.Value + ume_igv.Value, 2)
        ume_total.Value = Math.Round(CType(ume_subtotal.Value, Decimal) + CType(ume_igv.Value, Decimal), 2)

        If uck_Redondear.Checked = True Then
            If precioRe = 0 Then
                ' Dim total_Redon As Decimal
                Dim Dec As Decimal
                Dim TotalSinD As Decimal
                TotalSinD = Int(ume_total.Value)
                Dec = CType(ume_total.Value, Decimal) - TotalSinD
                Dec = Math.Round(Dec / 0.05, 0) * 0.05
                '    total_Redon = TotalSinD + Dec

                ume_total.Value = Math.Round(TotalSinD + Dec, 2)
            Else
                ume_total.Value = Math.Round(ume_total.Value + precioRe, 2)
            End If

            ' ume_total.Value = Math.Round(ume_total.Value + precioRe, 2)
            ume_subtotal.Value = Math.Round(ume_total.Value / ((ume_Tasa_Igv.Value / 100) + 1), 2)
            ume_igv.Value = Math.Round(ume_total.Value - ume_subtotal.Value, 2)
        End If
        'ume_subtotal.Value = subtotal ' ug_Detalle.DisplayLayout.Bands(0).Summaries("sSubtotal").
        'ume_igv.Value = igv 'ug_Detalle.DisplayLayout.Bands(0).Summaries("sIgv")
        'ume_total.Value = total 'ug_Detalle.DisplayLayout.Bands(0).Summaries("sTotal")

    End Sub

    Private Sub ug_Detalle_AfterRowUpdate(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinGrid.RowEventArgs) Handles ug_Detalle.AfterRowUpdate
        'e.Row.Cells("Total").Value = e.Row.Cells("Precio").Value * e.Row.Cells("Cant").Value


        Dim igv_cal As Double = 0.0
        Dim total_cal As Double = 0.0
        Dim subtotal_cal As Double = 0.0
        Dim precio_Arti As Double = 0.0
        Dim cant As Double = 0.0
        Dim Descto As Double = 0.0
        Dim Descto_OTRO As Double = 0.0

        precio_Arti = e.Row.Cells("Precio").Value
        cant = e.Row.Cells("Cant").Value
        Descto = e.Row.Cells("DSCTO").Value
        Descto_OTRO = e.Row.Cells("DSCTO_OTRO").Value

        subtotal_cal = (precio_Arti * cant) - Descto - Descto_OTRO
        igv_cal = subtotal_cal * (ume_Tasa_Igv.Value / 100)
        total_cal = subtotal_cal + igv_cal

        e.Row.Cells("Total").Value = total_cal
        e.Row.Cells("Impuesto").Value = igv_cal
        e.Row.Cells("SubTotal").Value = subtotal_cal

        Call Calcular_Totales()

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

    Private Sub ubtn_quitar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ubtn_quitar.Click

        If ug_Detalle.Rows.Count = 0 Then Exit Sub
        If ug_Detalle.ActiveRow Is Nothing Then Exit Sub

        ug_Detalle.ActiveRow.Delete()

        Call Calcular_Totales()

    End Sub

    Private Sub Iniciar_Ventana()
        'ubtn_agregar.Visible = False
        'ubtn_quitar.Visible = False
        Call Inicializar_Estado_Botones_Tool(ToolS_Mantenimiento)
        Call Limpiar_Controls_InGroupox(ugb_cabecera)
        Call LimpiaGrid(ug_Detalle, uds_detalle)

        ume_subtotal.Value = 0
        ume_igv.Value = 0
        ume_total.Value = 0
        txt_notas.Clear()
        txt_num_voucher_conta.Clear()
        txt_IdComprobante.Clear()

        'uce_TipoDoc.Value = "3"

        uce_Moneda.SelectedIndex = 0
        'udte_fec_emi.Value = gDat_Fecha_Sis
        'udte_fec_Ven.Value = gDat_Fecha_Sis


        Call Cargar_Tasas_Impuestos()
        Call Obtener_TipoCambio_dia()

        'uce_PuntoVenta.SelectedIndex = 0
        uce_PuntoVenta.Value = "02"
        uce_FormaPago.SelectedIndex = 0
        uce_docu_pago.SelectedIndex = 0

        uce_TipDocRef.Value = Nothing
        txt_serie_ref.Text = ""
        txt_numero_ref.Text = ""
        ume_fec_emi_ref.Value = Nothing
        ume_fec_ven_ref.Value = Nothing

        udtpFecha_Ingreso.Value = ""
        udtpFechaAlta.Value = ""

        Tool_Imprimir.Enabled = False
        Tool_Grabar.Enabled = True
        ubtn_agregar.Enabled = True
        ubtn_quitar.Enabled = True
        'uce_Empresas.Enabled = True
        txt_doc_pago.Visible = False
        ugb_docref.Visible = False

        For Each ctrl As Control In ugb_cabecera.Controls
            ctrl.Enabled = True
        Next
        uce_Medico.Enabled = True
        ucm_Tipo.Enabled = True
        txt_notas.Width = 489
        'txt_dni.Visible = False
        'lbl_dni.Visible = False
        'txt_dni.Text = ""
        txt_ruc_cliente.Enabled = False
        txt_IdCuenta.Focus()

    End Sub

    Private Function fValida() As Boolean

        pLostfocus(txt_idHistoria, Nothing)
        pLostfocus(txt_idClienteC, Nothing)
        uce_TipDocRef.BackColor = Color.White

        txt_Ruc_ClientesC.BackColor = Color.White
        txt_serie_ref.BackColor = Color.White
        txt_numero_ref.BackColor = Color.White

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

        If txt_Ruc_ClientesC.BackColor = Color.LightPink Then GoTo Err_Valida
        If txt_idHistoria.BackColor = Color.LightPink Then GoTo Err_Valida
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

    Private Sub uce_Serie_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles uce_Serie.ValueChanged
        Call Obtener_Ult_Num_Compro()
    End Sub

    Private Sub Obtener_Ult_Num_Compro()
        Dim numeracionBL As New BL.FacturacionBL.SG_FA_TB_NUM_COMPRO
        Dim numeracionBE As New BE.FacturacionBE.SG_FA_TB_NUM_COMPRO

        numeracionBE.NC_IDTIPO = New BE.FacturacionBE.SG_FA_TB_DOCUMENTO With {.DO_CODIGO = uce_TipoDoc.Value}
        numeracionBE.NC_IDEMPRESA = New BE.ContabilidadBE.SG_CO_TB_EMPRESA With {.EM_ID = gInt_IdEmpresa}
        numeracionBE.NC_SERIE = uce_Serie.Value

        txt_NumDoc.Text = numeracionBL.get_NumCompro_xTD_SD(numeracionBE)

        numeracionBE = Nothing
        numeracionBL = Nothing
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

    Private Sub Tool_Grabar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_Grabar.Click

        If fValida() = False Then Exit Sub

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

        Dim rpta_existe As Boolean = False
        Call Validar_existe_num_comprobante(rpta_existe)

        If rpta_existe Then
            Avisar("No se puede continuar!")
            Exit Sub
        End If

        If uce_TipoDoc.Value = "07" And txt_serie_ref.Text = "" Then
            Avisar("No puede grabar Nota de Credito sin Referencia")
            Exit Sub
        End If

        'Comenzamos a Grabar
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
            .CO_FEC_EMI = udte_fec_emi.Value
            .CO_FEC_VEN = udte_fec_Ven.Value
            .CO_SUBTOTAL = ume_subtotal.Value
            .CO_SUBTOTAL_NA = 0
            .CO_IGV = ume_igv.Value
            .CO_TOTAL = ume_total.Value
            .CO_IDMONEDA = New BE.FacturacionBE.SG_FA_TB_MONEDA With {.MO_ID = uce_Moneda.Value}
            .CO_TCAM = ume_ValorTipoCambio.Value
            If uce_TipoDoc.Value = "07" Then
                .CO_TDOC_REF = documentoBE2
                .CO_SDOC_REF = txt_serie_ref.Text
                .CO_NDOC_REF = txt_numero_ref.Text

                If ume_fec_emi_ref.Value.ToString = "" Then
                    .CO_FEC_EMI_REF = String.Empty
                Else
                    .CO_FEC_EMI_REF = CDate(ume_fec_emi_ref.Value).ToShortDateString
                End If

                If ume_fec_ven_ref.Value.ToString = "" Then
                    .CO_FEC_VEN_REF = String.Empty
                Else
                    .CO_FEC_VEN_REF = CDate(ume_fec_ven_ref.Value).ToShortDateString
                End If

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
            .CO_IDCLIENTE = New BE.FacturacionBE.SG_FA_TB_CLIENTE With {.CL_ID = txt_idClienteC.Text.Trim}
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
        End With


        Dim detalleBE As BE.FacturacionBE.SG_FA_TB_COMPROBANTE_D

        ug_Detalle.UpdateData()

        For i As Integer = 0 To ug_Detalle.Rows.Count - 1
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
                .CD_INC_IGV = ug_Detalle.Rows(i).Cells("InIgv").Value
                .CD_IDCUENTA = ug_Detalle.Rows(i).Cells("IDCUENTA").Value
                .CD_CUENTA_ITEM = ug_Detalle.Rows(i).Cells("CuentaItems").Value
                .CD_DSCTO_OTRO = ug_Detalle.Rows(i).Cells("DSCTO_OTRO").Value


                If ug_Detalle.Rows(i).Cells("IDCOMPRO_ADELA").Value.ToString = "" Then
                    .CD_IDCOMPRO_ADELA = 0
                Else
                    .CD_IDCOMPRO_ADELA = ug_Detalle.Rows(i).Cells("IDCOMPRO_ADELA").Value
                End If


            End With

            comprobanteBE.Detalles.Add(detalleBE)
        Next

        Dim voucherConta As String = String.Empty

        Try

            Dim dato_nc As Integer = 1 '1=cargar a la planilla ;  0=no cargar
            If uce_TipoDoc.Value = "07" Then '07=nota de credito
                If uck_NC.Checked Then 'true = marcador el check
                    dato_nc = 1
                Else
                    dato_nc = 0
                End If
            End If

            comprobanteBL.Insert_CajaPac(comprobanteBE, voucherConta, Val(txt_IDTratamiento.Text), txt_CuentaCon.Text, dato_nc)

            txt_IdComprobante.Text = comprobanteBE.CO_ID
            txt_num_voucher_conta.Text = voucherConta

            comprobanteBE = Nothing
            comprobanteBL = Nothing


            Call Avisar("Listo!")

            Tool_Imprimir.Enabled = True
            Tool_Grabar.Enabled = False
            Tool_Cancelar.Enabled = False
            ubtn_agregar.Enabled = False
            ubtn_quitar.Enabled = False

            For Each ctrl As Control In ugb_cabecera.Controls
                ctrl.Enabled = False
            Next
        Catch ex As Exception
            ShowError(ex.Message)
        End Try
    End Sub

    Private Sub Tool_Nuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_Nuevo.Click
        Dim ult_doc As String = uce_TipoDoc.Value

        Call Iniciar_Ventana()

        uce_TipoDoc.Value = ult_doc

    End Sub

    Private Sub Tool_Cancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_Cancelar.Click
        Call Iniciar_Ventana()
    End Sub

    Private Sub Tool_Imprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_Imprimir.Click

        If txt_IdComprobante.Text.Length = 0 Then Exit Sub

        Me.Cursor = Cursors.WaitCursor

        Dim nom_reporte As String = "SG_FA_01.RPT"
        Dim nom_param_linea As String = ""
        Dim texto_nota_cre As String = ""
        Dim bol_es_nc As Boolean = False

        Select Case uce_TipoDoc.Value
            Case "01" 'factura
                nom_reporte = "SG_FA_06_1F.RPT"
                '  nom_reporte = "SG_FA_01_" & gInt_IdEmpresa.ToString & ".RPT"
                nom_param_linea = "LINFACFAC"

            Case "03" 'boleta
                nom_reporte = "SG_FA_06_1F.RPT"
                ' nom_reporte = "SG_FA_06_" & gInt_IdEmpresa.ToString & ".RPT"
                nom_param_linea = "LINFACBOL"

            Case "07" 'nota de credito
                nom_reporte = "SG_FA_07_1.RPT"
                ' nom_reporte = "SG_FA_07_" & gInt_IdEmpresa.ToString & ".RPT"
                nom_param_linea = "LINFACNCR"

                ' texto_nota_cre = "Por la anulacion del comprobante " & uce_TipDocRef.Value.ToString & " - " & txt_serie_ref.Text & " - " & txt_numero_ref.Text & " emitido el " & ume_fec_emi_ref.Value.ToString
                ' bol_es_nc = True

        End Select

        Dim idComprobante As Integer = txt_IdComprobante.Text
        Dim reportesBL As New BL.FacturacionBL.SG_FA_Reportes
        Dim crystalBL As New LR.ClsReporte
        Dim dt_comprobante As DataTable = reportesBL.get_Comprobante(idComprobante, gInt_IdEmpresa)
        Dim Monto_en_Letras As String = Letras(ume_total.Value).ToUpper
        Dim moneda As String = uce_Moneda.Value

        Dim obrmo As New BL.FacturacionBL.SG_FA_TB_MONEDA
        Dim drr_MOV As System.Data.SqlClient.SqlDataReader
        drr_MOV = obrmo.get_Moneda(moneda, gInt_IdEmpresa)
        If drr_MOV.HasRows Then
            drr_MOV.Read()
            Monto_en_Letras = Monto_en_Letras & " " & drr_MOV("MO_DESCRIPCION")
        End If
        drr_MOV.Close()

        If uce_TipoDoc.Value = "01" Then
            'crystalBL.Muestra_Reporte(gStr_RutaRep & "\" & nom_reporte, dt_comprobante, "", "pMontoLetras;" & Monto_en_Letras, "pMoneda;" & moneda, "pPaciente;" & txt_Des_Cliente.Text)
            crystalBL.Muestra_Reporte(gStr_RutaRep & "\" & nom_reporte, dt_comprobante, "", "pMontoLetras;" & Monto_en_Letras, "pMoneda;" & moneda, "pPaciente;" & txt_Des_Cliente.Text, "pFechaI;" & udtpFecha_Ingreso.Text, "pFechaA;" & udtpFechaAlta.Text, "pVoucher;" & Val(txt_num_voucher_conta.Text.Substring(txt_num_voucher_conta.Text.Length - 6, 6)))
        ElseIf uce_TipoDoc.Value = "03" Then
            crystalBL.Muestra_Reporte(gStr_RutaRep & "\" & nom_reporte, dt_comprobante, "", "pMontoLetras;" & Monto_en_Letras, "pMoneda;" & moneda, "pPaciente;" & txt_Des_Cliente.Text, "pFechaI;" & udtpFecha_Ingreso.Text, "pFechaA;" & udtpFechaAlta.Text, "pVoucher;" & Val(txt_num_voucher_conta.Text.Substring(txt_num_voucher_conta.Text.Length - 6, 6)))
            'crystalBL.Muestra_Reporte(gStr_RutaRep & "\" & nom_reporte, dt_comprobante, "", "pMontoLetras;" & Monto_en_Letras, "pMoneda;" & moneda, "pPaciente;" & txt_Des_Cliente.Text)
        Else
            Call Completar_Lineas(nom_param_linea, dt_comprobante, bol_es_nc, texto_nota_cre)
            crystalBL.Muestra_Reporte(gStr_RutaRep & "\" & nom_reporte, dt_comprobante, "", "pMontoLetras;" & Monto_en_Letras, "pMontoDolates;", "pMoneda;" & moneda, "pVaucher;" & Val(txt_num_voucher_conta.Text.Substring(txt_num_voucher_conta.Text.Length - 6, 6)))
        End If

        crystalBL = Nothing
        reportesBL = Nothing

        Me.Cursor = Cursors.Default

    End Sub

    Private Sub Tool_Salir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_Salir.Click
        Me.Close()
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

        If uce_TipoDoc.Items.Count > 0 Then uce_TipoDoc.SelectedIndex = 0

    End Sub

    'Private Sub txt_NumDoc_EditorButtonClick(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinEditors.EditorButtonEventArgs) Handles txt_NumDoc.EditorButtonClick
    '    ugb_docref.Visible = True
    '    uce_TipDocRef.Focus()
    'End Sub

    'Private Sub ubtn_aceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ubtn_aceptar.Click

    '    If uce_TipDocRef.SelectedIndex = -1 Then
    '        uce_TipDocRef.Focus()
    '        Avisar("Seleccione un tipo de documento")
    '        Exit Sub
    '    End If

    '    If txt_serie_ref.Text.Trim.Length = 0 Then
    '        txt_serie_ref.Focus()
    '        Call Avisar("Ingrese la serie")
    '        Exit Sub
    '    End If

    '    If txt_numero_ref.Text.Trim.Length = 0 Then
    '        txt_numero_ref.Focus()
    '        Call Avisar("Ingrese el numero del comprobante")
    '        Exit Sub
    '    End If

    '    'Aqui se debe buscar el documento por referencia de comprobante ingresado.
    '    Call Cargar_Comprobante_para_NotCred(uce_TipDocRef.Value, txt_serie_ref.Text.Trim, txt_numero_ref.Text.Trim)

    '    ugb_docref.Visible = False
    '    txt_notas.Focus()

    'End Sub

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
    '            txt_Titular.Text = dt_histo_tmp.Rows(0)("HC_TITULAR")
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

    '        End With

    '        ug_Detalle.UpdateData()

    '    Next
    '    Call Calcular_Totales()
    '    ds_tmp.Dispose()

    'End Sub

    Private Sub txt_notas_EditorButtonClick(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinEditors.EditorButtonEventArgs) Handles txt_notas.EditorButtonClick
        txt_notas.Text = txt_Des_Cliente.Text.Trim
    End Sub

    'Private Sub txt_numero_ref_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_numero_ref.Leave
    '    'Buscar Fechas del documentos
    '    If txt_numero_ref.Text.Trim.Length < 6 Then
    '        txt_numero_ref.Text = txt_numero_ref.Text.PadLeft(10, "0")
    '    End If
    'End Sub

    'Private Sub txt_serie_ref_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_serie_ref.Leave
    '    If txt_serie_ref.Text.Trim.Length < 3 Then
    '        txt_serie_ref.Text = txt_serie_ref.Text.PadLeft(4, "0")
    '    End If
    'End Sub

    'Private Sub ume_fec_emi_ref_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles ume_fec_emi_ref.Leave
    '    ume_fec_ven_ref.Value = ume_fec_emi_ref.Value
    'End Sub

    'Cuenta
    Private Sub Ayuda_Anexo_Cuenta()
        Dim obe As New BE.FacturacionBE.SG_FA_TB_PRE_FACTURA_CAB
        Dim obr As New BL.FacturacionBL.SG_FA_TB_PRE_FACTURA_CAB
        Dim obeT As New BE.AdmisionBE.TMP_SG_AD_TB_CUENTA_DET
        Dim obeC As New BE.AdmisionBE.SG_AD_TB_CUENTA_CAB
        Dim obrT As New BL.AdmisionBL.SG_AD_TB_CUENTA_CAB
        'Dim obeC As New BE.AdmisionBE.SG_AD_TB_CUENTA_CAB

        ' FA_PR_ListaClientesAyuda.Int_Opcion = 1
        FA_PR_ListaCuentas.ShowDialog()

        Dim matriz As List(Of String) = FA_PR_ListaCuentas.GetLista

        If matriz.Count > 0 Then

            obe.PF_ID = Val(matriz(9))
            obe.HasRow = False
            obr.SEL01(obe)
            If obe.HasRow Then
                With obe
                    'If .PF_IDTIPO_ATENC = 1 Then
                    '    Avisar("Pre-Factura es Particular")
                    '    Iniciar_Ventana()
                    '    Exit Sub
                    'End If
                    obeC.CC_ID = matriz(0)
                    'obeC.HasRow = False
                    'obrT.SEL08(obeC, 1)
                    'If obeC.HasRow Then
                    '    If obeC.Cant > 0 Then
                    '        Avisar("Pre-Factura ya esta Facturada")
                    '        Iniciar_Ventana()
                    '        Exit Sub
                    '    End If
                    'End If

                    'If .PF_ESTADO_PRE_F = 2 Then
                    '    Avisar("Pre-Factura ya esta Facturada")
                    '    Iniciar_Ventana()
                    '    Exit Sub
                    'End If
                    'Buscar seguro y llenar cliente

                    txt_idClienteC.Text = .PF_IDCLIENTE
                    Dim clienteBL As New BL.FacturacionBL.SG_FA_TB_CLIENTE
                    Dim clienteBE As New BE.FacturacionBE.SG_FA_TB_CLIENTE
                    clienteBE.CL_ID = txt_idClienteC.Value
                    clienteBE.CL_IDEMPRESA = New BE.ContabilidadBE.SG_CO_TB_EMPRESA With {.EM_ID = gInt_IdEmpresa}
                    clienteBL.get_Cliente_x_Id(clienteBE)
                    txt_Des_ClienteC.Text = clienteBE.CL_NOMBRE
                    txt_Ruc_ClientesC.Text = clienteBE.CL_NDOC
                    clienteBE = Nothing
                    clienteBL = Nothing
                    txt_idHistoria.Value = .PF_IDNUMHIST
                    uce_Medico.Value = .PF_IDMEDICO
                    If .PF_FECHAIngreso = Nothing Then udtpFecha_Ingreso.Value = "" Else udtpFecha_Ingreso.Value = .PF_FECHAIngreso
                    If .PF_FECHAAlta = Nothing Then udtpFechaAlta.Value = "" Else udtpFechaAlta.Value = .PF_FECHAAlta
                    Dim Presupuesto As String = ""

                    Presupuesto = IIf(.PF_IDPRESUPUESTO = 0, "", .PF_IDPRESUPUESTO)
                    If Presupuesto <> "" Then
                        Dim PRESBL As New BL.FacturacionBL.SG_FA_TB_PRESUPUESTO_CAB
                        Dim PRESBE As New BE.FacturacionBE.SG_FA_TB_PRESUPUESTO_CAB
                        PRESBE.PR_ID = Val(Presupuesto)
                        PRESBE.HasRow = False
                        PRESBL.SEL02(PRESBE)
                        If PRESBE.HasRow Then

                            With PRESBE
                                txt_IDTratamiento.Text = .PR_IDPAQUETE
                                Dim TBL As New BL.FacturacionBL.SG_FA_TB_PAQUETE_CAB
                                Dim TBE As New BE.FacturacionBE.SG_FA_TB_PAQUETE_CAB
                                TBE.PC_ID = .PR_IDPAQUETE
                                TBL.SEL02(TBE)
                                If TBE.HasRow = True Then
                                    txt_CuentaCon.Text = TBE.PC_CuentaCont
                                Else
                                    txt_CuentaCon.Text = ""
                                End If
                            End With
                        End If
                    Else
                        txt_IDTratamiento.Text = ""
                        txt_CuentaCon.Text = ""
                    End If

                    Dim historiaBL As New BL.AdmisionBL.SG_AD_TB_HISTO_CLINI
                    Dim dt_histo_tmp As DataTable = historiaBL.getHistorias_Base_x_Id(txt_idHistoria.Value, gInt_IdEmpresa)
                    If dt_histo_tmp.Rows.Count > 0 Then
                        txt_Des_Cliente.Text = dt_histo_tmp.Rows(0)("HC_APE_PAT") & " " & dt_histo_tmp.Rows(0)("HC_APE_MAT") & " " & dt_histo_tmp.Rows(0)("HC_APE_CASADA") & " " & dt_histo_tmp.Rows(0)("HC_NOMBRE1") & " " & dt_histo_tmp.Rows(0)("HC_NOMBRE2")
                        txt_ruc_cliente.Text = dt_histo_tmp.Rows(0)("HC_NDOC")
                        txt_IdCliente.Value = dt_histo_tmp.Rows(0)("HC_IDCLIENTE")
                        uce_tip_doc.Value = dt_histo_tmp.Rows(0)("HC_TDOC")
                        txt_Titular.Text = dt_histo_tmp.Rows(0)("HC_TITULAR")
                    End If
                End With
            Else
                Avisar("Pre-Factura no Existe!")
                Iniciar_Ventana()
                Exit Sub
            End If
            txt_IdCuenta.Text = matriz(0)
            ucm_Tipo.Value = matriz(1)
            'txt_COAseguroPorc.Text = 100 - matriz(15)
            'txt_fijo.Text = matriz(14)

            Dim obj As New DataTable
            obeT.TCD_IDCAB = Val(txt_IdCuenta.Text)
            obrT.SEL05_TMP(obeT, String.Format("{0}-{1}", Environment.UserName, gStr_Usuario_Sis), Environment.MachineName, obj)
            ug_Detalle.DataSource = obj

            Call Calcular_Totales()

        End If

    End Sub

    Private Sub Buscar_Cuenta()
        Dim obe As New BE.FacturacionBE.SG_FA_TB_PRE_FACTURA_CAB
        Dim obr As New BL.FacturacionBL.SG_FA_TB_PRE_FACTURA_CAB
        Dim obeT As New BE.AdmisionBE.TMP_SG_AD_TB_CUENTA_DET
        Dim obrT As New BL.AdmisionBL.SG_AD_TB_CUENTA_CAB
        Dim obeC As New BE.AdmisionBE.SG_AD_TB_CUENTA_CAB

        obeC.CC_ID = Val(txt_IdCuenta.Text)
        obeC.HasRow = False
        obrT.SEL04(obeC)
        If obeC.HasRow And obeC.CC_IDPREFAC <> 0 Then
            With obeC
                'txt_idPreFactura.Text = .CC_IDPREFAC
                obe.PF_ID = .CC_IDPREFAC
                obe.HasRow = False
                obr.SEL01(obe)
                If obe.HasRow Then
                    With obe
                        'obeC.HasRow = False
                        'obrT.SEL08(obeC, 1)
                        'If obeC.HasRow Then
                        '    If obeC.Cant > 0 Then
                        '        Avisar("Pre-Factura ya esta Facturada")
                        '        Iniciar_Ventana()
                        '        Exit Sub
                        '    End If
                        'End If
                        'If .PF_ESTADO_PRE_F = 2 Then
                        '    Avisar("Pre-Factura ya esta Facturada")
                        '    Iniciar_Ventana()
                        '    Exit Sub
                        'End If
                        'Buscar seguro y llenar cliente
                        txt_idClienteC.Text = .PF_IDCLIENTE
                        Dim clienteBL As New BL.FacturacionBL.SG_FA_TB_CLIENTE
                        Dim clienteBE As New BE.FacturacionBE.SG_FA_TB_CLIENTE
                        clienteBE.CL_ID = txt_idClienteC.Value
                        clienteBE.CL_IDEMPRESA = New BE.ContabilidadBE.SG_CO_TB_EMPRESA With {.EM_ID = gInt_IdEmpresa}
                        clienteBL.get_Cliente_x_Id(clienteBE)
                        txt_Des_ClienteC.Text = clienteBE.CL_NOMBRE
                        txt_Ruc_ClientesC.Text = clienteBE.CL_NDOC
                        clienteBE = Nothing
                        clienteBL = Nothing

                        txt_idHistoria.Value = .PF_IDNUMHIST
                        uce_Medico.Value = .PF_IDMEDICO
                        If .PF_FECHAIngreso = Nothing Then udtpFecha_Ingreso.Value = "" Else udtpFecha_Ingreso.Value = .PF_FECHAIngreso
                        If .PF_FECHAAlta = Nothing Then udtpFechaAlta.Value = "" Else udtpFechaAlta.Value = .PF_FECHAAlta

                        Dim Presupuesto As String = ""
                        Presupuesto = IIf(.PF_IDPRESUPUESTO = 0, "", .PF_IDPRESUPUESTO)
                        If Presupuesto <> "" Then
                            Dim PRESBL As New BL.FacturacionBL.SG_FA_TB_PRESUPUESTO_CAB
                            Dim PRESBE As New BE.FacturacionBE.SG_FA_TB_PRESUPUESTO_CAB
                            PRESBE.PR_ID = Val(Presupuesto)
                            PRESBE.HasRow = False
                            PRESBL.SEL02(PRESBE)
                            If PRESBE.HasRow Then

                                With PRESBE
                                    txt_IDTratamiento.Text = .PR_IDPAQUETE
                                    Dim TBL As New BL.FacturacionBL.SG_FA_TB_PAQUETE_CAB
                                    Dim TBE As New BE.FacturacionBE.SG_FA_TB_PAQUETE_CAB
                                    TBE.PC_ID = .PR_IDPAQUETE
                                    TBL.SEL02(TBE)
                                    If TBE.HasRow = True Then
                                        txt_CuentaCon.Text = TBE.PC_CuentaCont
                                    Else
                                        txt_CuentaCon.Text = ""
                                    End If
                                End With
                            End If
                        Else
                            txt_IDTratamiento.Text = ""
                            txt_CuentaCon.Text = ""
                        End If
                        Dim historiaBL As New BL.AdmisionBL.SG_AD_TB_HISTO_CLINI
                        Dim dt_histo_tmp As DataTable = historiaBL.getHistorias_Base_x_Id(txt_idHistoria.Value, gInt_IdEmpresa)
                        If dt_histo_tmp.Rows.Count > 0 Then
                            txt_Des_Cliente.Text = dt_histo_tmp.Rows(0)("HC_APE_PAT") & " " & dt_histo_tmp.Rows(0)("HC_APE_MAT") & " " & dt_histo_tmp.Rows(0)("HC_APE_CASADA") & " " & dt_histo_tmp.Rows(0)("HC_NOMBRE1") & " " & dt_histo_tmp.Rows(0)("HC_NOMBRE2")
                            txt_ruc_cliente.Text = dt_histo_tmp.Rows(0)("HC_NDOC")
                            txt_IdCliente.Value = dt_histo_tmp.Rows(0)("HC_IDCLIENTE")
                            uce_tip_doc.Value = dt_histo_tmp.Rows(0)("HC_TDOC")
                            txt_Titular.Text = dt_histo_tmp.Rows(0)("HC_TITULAR")
                        End If
                    End With
                Else
                    Avisar("Pre-Factura no Existe!")
                    Exit Sub
                End If
                ucm_Tipo.Value = .CC_IDTIPO_ORI
                'txt_COAseguroPorc.Text = 100 - .CC_SIT_COPG_VARI
                'txt_fijo.Text = .CC_SIT_COPG_FIJO

                Dim obj As New DataTable
                obeT.TCD_IDCAB = Val(txt_IdCuenta.Text)
                obrT.SEL05_TMP(obeT, String.Format("{0}-{1}", Environment.UserName, gStr_Usuario_Sis), Environment.MachineName, obj)
                ug_Detalle.DataSource = obj

                Call Calcular_Totales()

            End With
        Else
            Avisar("Cuenta no Existe! o no tiene Pre-Factura")
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


    Private Sub uck_Redondear_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles uck_Redondear.CheckedChanged
        If bol_nuevo Then
            If uck_Redondear.Checked = True Then
                Dim total_Redon As Decimal
                Dim Precio As Decimal

                'total_Redon = Math.Round(CType(ume_total.Value, Decimal), 1)
                Dim Dec As Decimal
                Dim TotalSinD As Decimal
                'TotalSinD = Int(ume_total.Value)
                TotalSinD = Int(ume_total.Value)
                Dec = CType(ume_total.Value, Decimal) - TotalSinD
                Dec = Math.Round(Dec / 0.05, 0) * 0.05
                total_Redon = TotalSinD + Dec
                'Precio = (total_Redon / ((ume_Tasa_Igv.Value / 100) + 1)) - ume_subtotal.Value
                Precio = Math.Round(total_Redon - ume_total.Value, 2)
                '214 +
                ' 215 -

                If ume_subtotal.Value <> Math.Round(total_Redon / ((ume_Tasa_Igv.Value / 100) + 1), 2) Then
                    AgregarDetalle(1, IIf(Precio > 0, 214, 215), "REDONDEO", Precio, 0, 0, Precio, 0, Precio, 0, 0, 0)
                Else
                    ume_total.Value = Math.Round(total_Redon, 2)
                    ume_subtotal.Value = Math.Round(ume_total.Value / ((ume_Tasa_Igv.Value / 100) + 1), 2)
                    ume_igv.Value = Math.Round(ume_total.Value - ume_subtotal.Value, 2)
                End If



            Else
                For i As Integer = 0 To ug_Detalle.Rows.Count - 1
                    If ug_Detalle.Rows(i).Cells("IdArticulo").Value = "214" Or ug_Detalle.Rows(i).Cells("IdArticulo").Value = "215" Then
                        ug_Detalle.Rows(i).Delete()
                        Exit For
                    End If
                Next

                Call Calcular_Totales()

            End If
        End If
    End Sub

    Private Sub ubtn_aceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ubtn_aceptar.Click
        ugb_docref.Visible = False
    End Sub

    Private Sub ubtn_agregar_Adela_Click(sender As System.Object, e As System.EventArgs) Handles ubtn_agregar_Adela.Click

        If txt_idHistoria.Text.Trim = "" Then
            Avisar("Numero de Historia no valido.")
            Exit Sub
        End If

        Dim comprobanteBL As New BL.FacturacionBL.SG_FA_TB_COMPROBANTE_C
        Dim dt_adelantos As DataTable = comprobanteBL.get_adelantos_x_Historia(CInt(txt_idHistoria.Text), gInt_IdEmpresa)
        comprobanteBL = Nothing

        Dim subtotal As Double = 0
        For i As Integer = 0 To dt_adelantos.Rows.Count - 1
            subtotal = dt_adelantos.Rows(i)("CO_SUBTOTAL")
            Call AgregarDetalle(1, 521, "ADELANTO POR INTERVENCION QUIRURGICA", (subtotal * -1), 0, 0, (subtotal * -1), 0, (subtotal * -1), 0, 0, dt_adelantos.Rows(i)("CO_ID"))
        Next

        If dt_adelantos.Rows.Count = 0 Then
            Avisar("Esta Historia No tiene adelantos registrados")
        End If

        Call Calcular_Totales()

    End Sub

    Private Sub ug_Detalle_AfterRowsDeleted(sender As System.Object, e As System.EventArgs) Handles ug_Detalle.AfterRowsDeleted
        ug_Detalle.UpdateData()
    End Sub

    Private Sub ubtn_Quitar_adela_Click(sender As System.Object, e As System.EventArgs) Handles ubtn_Quitar_adela.Click

        If ug_Detalle.Rows.Count = 0 Then Exit Sub
        If ug_Detalle.ActiveRow Is Nothing Then Exit Sub
        If ug_Detalle.ActiveRow.Cells("IdArticulo").Value <> 521 Then Exit Sub
        ug_Detalle.ActiveRow.Delete()
        Call Calcular_Totales()

    End Sub
End Class