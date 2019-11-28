Imports Infragistics.Win.UltraWinGrid

Public Class LO_LT_ComprasBot
    Public bol_nuevo As Boolean = True
    Private Sub pKeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Me.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Return) Then
            SendKeys.Send("{TAB}")
            e.Handled = True
        End If
    End Sub
    Private Sub pKeyPressNumero(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_NumDoc.KeyPress
        e.KeyChar = fKeyPress(e.KeyChar, sender.Text, 1)
        e.Handled = (e.KeyChar = "")
    End Sub
    Private Sub LO_LT_ComprasBot_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.KeyPreview = True
        Call Cargar_Combos()

        txt_cod_prove.ButtonsRight(0).Appearance.Image = My.Resources._104
        ubtn_agregar.Appearance.Image = My.Resources._16__Plus_
        ubtn_quitar.Appearance.Image = My.Resources._132
        'ubtn_doc_ref.Appearance.Image = My.Resources._16__Page_number_

        Tool_Cancelar.Enabled = False
        Tool_Grabar.Enabled = False
        Tool_Salir.Enabled = True
        Tool_Nuevo.Enabled = True
        Tool_Imprimir.Enabled = False
        ugb_Cab.Enabled = False
        ubtn_agregar.Enabled = False

        'Dim unidadesBL As New BL.LogisticaBL.SG_LO_TB_UNI_MED
        'Call CrearComboGrid("Cod_um", "UM_ABREVI", ug_detalle, unidadesBL.getMedidas(gInt_IdEmpresa), True)
        'unidadesBL = Nothing

    End Sub

    Private Sub Cargar_Combos()

        Dim monedasBL As New BL.LogisticaBL.SG_LO_TB_MONEDA
        uce_moneda.DataSource = monedasBL.get_Monedas(gInt_IdEmpresa)
        uce_moneda.DisplayMember = "MO_DESCRIPCION"
        uce_moneda.ValueMember = "MO_ID"
        monedasBL = Nothing

        Dim documentoBL As New BL.LogisticaBL.SG_LO_TB_TIPO_DOCUMENTO
        uce_TipoDoc.DataSource = documentoBL.get_Documentos(gInt_IdEmpresa)
        uce_TipoDoc.DisplayMember = "DES"
        uce_TipoDoc.ValueMember = "TD_ID"

        uce_TipoDocRef.DataSource = documentoBL.get_Documentos(gInt_IdEmpresa)
        uce_TipoDocRef.DisplayMember = "DES"
        uce_TipoDocRef.ValueMember = "TD_ID"
        documentoBL = Nothing

        Dim formapaBL As New BL.LogisticaBL.SG_LO_TB_FORMA_PAGO
        uce_for_pag.DataSource = formapaBL.get_Formas(gInt_IdEmpresa)
        uce_for_pag.DisplayMember = "FP_DESCRIPCION"
        uce_for_pag.ValueMember = "FP_ID"
        formapaBL = Nothing

    End Sub

    Private Sub ReHacerSecuencia()
        For i As Integer = 0 To ug_detalle.Rows.Count - 1
            ug_detalle.Rows(i).Cells(0).Value = i + 1
        Next
        ug_detalle.UpdateData()
    End Sub

    Public Sub Cargar_Comprobante_toNC(ByVal entidad As BE.LogisticaBE.SG_LO_TB_COMPROBANTES_CAB)
        Try

            Dim comprobantesBL As New BL.LogisticaBL.SG_LO_TB_COMPROBANTES_CAB
            Dim ds_comprobante As New DataSet

            ds_comprobante = comprobantesBL.get_Comprobante_x_Id(entidad)

            With ds_comprobante.Tables(0)

                uce_TipoDoc.Value = "NC"
                uce_TipoDocRef.Value = .Rows(0)("CO_TDOC")
                txt_SerieDocRef.Value = .Rows(0)("CO_SDOC")
                txt_NumDocRef.Value = .Rows(0)("CO_NDOC")
                udte_Fec_EmiRef.Value = .Rows(0)("CO_FDOC")

                txt_Notas.Text = .Rows(0)("CO_NOTAS") & "  Doc. de Ref. : " & uce_TipoDocRef.Text & "-" & txt_SerieDocRef.Text & "-" & txt_NumDocRef.Text

                uce_moneda.Value = .Rows(0)("CO_IDMONEDA")
                ume_tc.Value = .Rows(0)("CO_TC")
                uce_for_pag.Value = .Rows(0)("CO_IDFORMA_PAGO")
                udte_Fec_Emi.Value = Now
                udte_Fec_Ven.Value = Now
                udte_fec_entrega.Value = Now
                Cargar_Tasas_Impuestos()
                txt_idcompra.Text = .Rows(0)("CO_ID")
                txt_Idprove.Value = .Rows(0)("CO_IDPROVE")
                ume_SubExone.Value = .Rows(0)("CO_SUBTOTAL_NA")

                txt_Idprove.Value = .Rows(0)("CO_IDPROVE")

                Dim proveedorBL As New BL.LogisticaBL.SG_LO_TB_PROVEEDOR
                Dim drr_prove As System.Data.SqlClient.SqlDataReader
                drr_prove = proveedorBL.get_Proveedores_x_Id(txt_Idprove.Value)
                If drr_prove.HasRows Then
                    drr_prove.Read()
                    txt_cod_prove.Text = drr_prove("PR_NDOC")
                    txt_Des_Prove.Text = drr_prove("PR_DESCRIPCION")
                End If
                drr_prove.Close()

            End With

            Call LimpiaGrid(ug_detalle, uds_detalle)

            'Detalle del Comprobante
            For i As Integer = 0 To ds_comprobante.Tables(1).Rows.Count - 1
                ug_detalle.DisplayLayout.Bands(0).AddNew()

                With ds_comprobante.Tables(1)

                    ug_detalle.Rows(i).Cells("DE_ITEM").Value = .Rows(i)("DE_ITEM")
                    ug_detalle.Rows(i).Cells("DE_IDARTICULO").Value = .Rows(i)("DE_IDARTICULO")
                    ug_detalle.Rows(i).Cells("AR_DESCRIPCION").Value = .Rows(i)("AR_DESCRIPCION")
                    ug_detalle.Rows(i).Cells("DE_IDLOTE").Value = .Rows(i)("DE_IDLOTE")
                    ug_detalle.Rows(i).Cells("DE_FEC_LOT").Value = .Rows(i)("DE_FEC_LOT")
                    ug_detalle.Rows(i).Cells("UM_ID").Value = .Rows(i)("DE_IDUM")
                    ug_detalle.Rows(i).Cells("UM_DESCRIPCION").Value = .Rows(i)("UMC")
                    ug_detalle.Rows(i).Cells("DE_CANT").Value = .Rows(i)("DE_CANT")
                    ug_detalle.Rows(i).Cells("Des_UmV").Value = .Rows(i)("UMV")
                    ug_detalle.Rows(i).Cells("Cant_UmV").Value = .Rows(i)("DE_CANT_V")
                    'If uck_IncluyeIGV.Checked = True Then
                    '    ug_detalle.Rows(i).Cells("DE_PRECIO").Value = .Rows(i)("DE_PRECIO_IGV")
                    '    ug_detalle.Rows(i).Cells("DE_DESCUENTO").Value = .Rows(i)("DE_DESCUENTO_IGV")
                    'Else
                    ug_detalle.Rows(i).Cells("DE_PRECIO").Value = .Rows(i)("DE_PRECIO")
                    ug_detalle.Rows(i).Cells("DE_DESCUENTO").Value = .Rows(i)("DE_DESCUENTO")
                    '  End If
                    ug_detalle.Rows(i).Cells("DSCTO").Value = (Val(.Rows(i)("DE_DESCUENTO")) * 100) / IIf(Val(.Rows(i)("DE_PRECIO")) = 0, 1, Val(.Rows(i)("DE_PRECIO")))
                    ug_detalle.Rows(i).Cells("DE_SUBTOTAL").Value = .Rows(i)("DE_SUBTOTAL")
                    ug_detalle.Rows(i).Cells("AR_SIN_IGV").Value = .Rows(i)("AR_SIN_IGV")
                    ug_detalle.Rows(i).Cells("DE_IGV").Value = .Rows(i)("DE_IGV")
                    ug_detalle.Rows(i).Cells("DE_TOTAL").Value = .Rows(i)("DE_TOTAL")
                    ug_detalle.Rows(i).Cells("AR_CANT_UMC").Value = .Rows(i)("AR_CANT_UMC")
                    ug_detalle.Rows(i).Cells("DE_IDUM_V").Value = .Rows(i)("DE_IDUM_V")

                    ug_detalle.UpdateData()
                End With
            Next

            Call Calcular_Totales()

            ds_comprobante = Nothing
            comprobantesBL = Nothing

            Tool_Nuevo.Enabled = False
            Tool_Grabar.Enabled = True
            ugb_Cab.Enabled = True
            Tool_Imprimir.Enabled = False

            ubtn_agregar.Enabled = True
            ubtn_quitar.Enabled = True
        Catch ex As Exception
            ShowError("Ocurrio un problema " & ex.Message)
        End Try
    End Sub

    Public Sub Cargar_Comprobante_toEdit(ByVal entidad As BE.LogisticaBE.SG_LO_TB_COMPROBANTES_CAB)
        Try

            Dim comprobantesBL As New BL.LogisticaBL.SG_LO_TB_COMPROBANTES_CAB
            Dim ds_comprobante As New DataSet

            ds_comprobante = comprobantesBL.get_Comprobante_x_Id(entidad)

            With ds_comprobante.Tables(0)

                uce_TipoDoc.Value = .Rows(0)("CO_TDOC")
                txt_SerieDoc.Value = .Rows(0)("CO_SDOC")
                txt_NumDoc.Value = .Rows(0)("CO_NDOC")

                uce_TipoDocRef.Value = .Rows(0)("CO_TDOC_REF")
                txt_SerieDocRef.Value = .Rows(0)("CO_SDOC_REF")
                txt_NumDocRef.Value = .Rows(0)("CO_NDOC_REF")
                txt_Notas.Text = .Rows(0)("CO_NOTAS").ToString

                uce_moneda.Value = .Rows(0)("CO_IDMONEDA")
                ume_tc.Value = .Rows(0)("CO_TC")
                uce_for_pag.Value = .Rows(0)("CO_IDFORMA_PAGO")
                udte_Fec_Emi.Value = .Rows(0)("CO_FDOC")
                udte_Fec_Ven.Value = .Rows(0)("CO_VDOC")
                udte_fec_entrega.Value = .Rows(0)("CO_FECHA_ENT")
                Cargar_Tasas_Impuestos()
                txt_idcompra.Text = .Rows(0)("CO_ID")
                txt_num_voucher.Text = .Rows(0)("CO_IDVOUCHER").ToString
                txt_Idprove.Value = .Rows(0)("CO_IDPROVE")
                ume_SubExone.Value = .Rows(0)("CO_SUBTOTAL_NA")
                uck_IncluyeIGV.Checked = True = IIf(.Rows(0)("CO_INCLUYE_IGV") = 1, True, False)

                Dim proveedorBL As New BL.LogisticaBL.SG_LO_TB_PROVEEDOR
                Dim drr_prove As System.Data.SqlClient.SqlDataReader
                drr_prove = proveedorBL.get_Proveedores_x_Id(txt_Idprove.Value)
                If drr_prove.HasRows Then
                    drr_prove.Read()
                    txt_cod_prove.Text = drr_prove("PR_NDOC")
                    txt_Des_Prove.Text = drr_prove("PR_DESCRIPCION")
                End If
                drr_prove.Close()
            End With


            Call LimpiaGrid(ug_detalle, uds_detalle)

            'Detalle del Comprobante
            For i As Integer = 0 To ds_comprobante.Tables(1).Rows.Count - 1
                ug_detalle.DisplayLayout.Bands(0).AddNew()

                With ds_comprobante.Tables(1)

                    ug_detalle.Rows(i).Cells("DE_ITEM").Value = .Rows(i)("DE_ITEM")
                    ug_detalle.Rows(i).Cells("DE_IDARTICULO").Value = .Rows(i)("DE_IDARTICULO")
                    ug_detalle.Rows(i).Cells("AR_DESCRIPCION").Value = .Rows(i)("AR_DESCRIPCION")
                    ug_detalle.Rows(i).Cells("DE_IDLOTE").Value = .Rows(i)("DE_IDLOTE")
                    ug_detalle.Rows(i).Cells("DE_FEC_LOT").Value = .Rows(i)("DE_FEC_LOT")
                    ug_detalle.Rows(i).Cells("UM_ID").Value = .Rows(i)("DE_IDUM")
                    ug_detalle.Rows(i).Cells("UM_DESCRIPCION").Value = .Rows(i)("UMC")
                    ug_detalle.Rows(i).Cells("DE_CANT").Value = .Rows(i)("DE_CANT")
                    ug_detalle.Rows(i).Cells("Des_UmV").Value = .Rows(i)("UMV")
                    ug_detalle.Rows(i).Cells("Cant_UmV").Value = .Rows(i)("DE_CANT_V")
                    'If uck_IncluyeIGV.Checked = True Then
                    '    ug_detalle.Rows(i).Cells("DE_PRECIO").Value = .Rows(i)("DE_PRECIO_IGV")
                    '    ug_detalle.Rows(i).Cells("DE_DESCUENTO").Value = .Rows(i)("DE_DESCUENTO_IGV")
                    'Else
                    ug_detalle.Rows(i).Cells("DE_PRECIO").Value = .Rows(i)("DE_PRECIO")
                    ug_detalle.Rows(i).Cells("DE_DESCUENTO").Value = .Rows(i)("DE_DESCUENTO")
                    'End If
                    ug_detalle.Rows(i).Cells("DSCTO").Value = (Val(.Rows(i)("DE_DESCUENTO")) * 100) / IIf(Val(.Rows(i)("DE_PRECIO")) = 0, 1, Val(.Rows(i)("DE_PRECIO")))
                    ug_detalle.Rows(i).Cells("DE_SUBTOTAL").Value = .Rows(i)("DE_SUBTOTAL")
                    ug_detalle.Rows(i).Cells("AR_SIN_IGV").Value = .Rows(i)("AR_SIN_IGV")
                    ug_detalle.Rows(i).Cells("DE_IGV").Value = .Rows(i)("DE_IGV")
                    ug_detalle.Rows(i).Cells("DE_TOTAL").Value = .Rows(i)("DE_TOTAL")
                    ug_detalle.Rows(i).Cells("AR_CANT_UMC").Value = .Rows(i)("AR_CANT_UMC")
                    ug_detalle.Rows(i).Cells("DE_IDUM_V").Value = .Rows(i)("DE_IDUM_V")

                    ug_detalle.UpdateData()
                End With
            Next


            Call Calcular_Totales()

            ds_comprobante = Nothing
            comprobantesBL = Nothing

            Tool_Nuevo.Enabled = False
            Tool_Grabar.Enabled = True
            Tool_Imprimir.Enabled = True
            ugb_Cab.Enabled = True

            ubtn_agregar.Enabled = True
            ubtn_quitar.Enabled = True

        Catch ex As Exception
            ShowError("Ocurrio un problema " & ex.Message)
        End Try

    End Sub

    Private Sub Validar_existe_num_comprobante(ByRef existe As Boolean)

        Dim comproBL As New BL.LogisticaBL.SG_LO_TB_COMPROBANTES_CAB
        Dim comproBE As New BE.LogisticaBE.SG_LO_TB_COMPROBANTES_CAB

        comproBE.CO_TDOC = uce_TipoDoc.Value
        comproBE.CO_SDOC = txt_SerieDoc.Text
        comproBE.CO_NDOC = txt_NumDoc.Text
        comproBE.CO_IDPROVE = Val(txt_Idprove.Text)
        comproBE.CO_IDEMPRESA = gInt_IdEmpresa

        If comproBL.Existe_Comprobante(comproBE) Then
            Call Avisar("El numero de comprobante " & uce_TipoDoc.Text & "-" & txt_SerieDoc.Text & "-" & txt_NumDoc.Text & " del proveedor: " & txt_Des_Prove.Text & " ya esta registrado,! Cuidado")
            existe = True
        End If

        comproBE = Nothing
        comproBL = Nothing

    End Sub

    Private Sub Tool_Salir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_Salir.Click
        Me.Close()
    End Sub
    Private Sub Tool_Cancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_Cancelar.Click
        Tool_Cancelar.Enabled = False
        Tool_Grabar.Enabled = False
        Tool_Salir.Enabled = True
        Tool_Nuevo.Enabled = True
        Tool_Imprimir.Enabled = False

        ugb_Cab.Enabled = False
        ubtn_agregar.Enabled = False
        Call LimpiaGrid(ug_detalle, uds_detalle)
        Call Limpiar_Controls_InGroupox(ugb_Cab)

        ume_descuento.Value = 0
        ume_subtotal.Value = 0
        ume_igv.Value = 0
        ume_total.Value = 0
    End Sub
    Private Sub Tool_Grabar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_Grabar.Click

        If txt_cod_prove.Text.Trim = "" Then
            Avisar("Ingrese el proveedor")
            txt_cod_prove.Focus()
            Exit Sub
        End If

        If uce_TipoDoc.SelectedIndex = -1 Then
            Avisar("Seleccione un tipo de documento")
            uce_TipoDoc.Focus()
            Exit Sub
        End If

        If txt_SerieDoc.Text.Trim = "" Then
            Avisar("Ingrese el numero de serie")
            txt_SerieDoc.Focus()
            Exit Sub
        End If

        If txt_NumDoc.Text.Trim = "" Then
            Avisar("Ingrese el numero de comprobante")
            txt_NumDoc.Focus()
            Exit Sub
        End If

        If uce_for_pag.SelectedIndex = -1 Then
            Avisar("Seleccione una forma de pago")
            uce_for_pag.Focus()
            Exit Sub
        End If

        If udte_Fec_Emi.Value.ToString = "" Then
            Avisar("Ingrese la fecha de emision")
            udte_Fec_Emi.Focus()
            Exit Sub
        End If

        If CDate(udte_Fec_Ven.Value).Date < CDate(udte_Fec_Emi.Value).Date Then
            Avisar("La fecha de vencimiento no puede ser menor a la fecha de emision")
            udte_Fec_Ven.Focus()
            Exit Sub
        End If

        If ug_detalle.Rows.Count = 0 Then
            Avisar("No hay productos en el detalle")
            Exit Sub
        End If

        If uce_TipoDoc.Text = "NC" Then
            If uce_TipoDocRef.SelectedIndex = -1 Then
                Avisar("Seleccione un tipo de documento de referencia")
                Exit Sub
            End If

            If txt_SerieDocRef.Text.Trim.Length = 0 Then
                Avisar("Ingrese el num. de serie de referencia")
                Exit Sub
            End If

            If txt_NumDocRef.Text.Trim.Length = 0 Then
                Avisar("Ingrese el numero del doc. de referencia")
                Exit Sub
            End If
        End If
        If bol_nuevo Then
            Dim rpta_existe As Boolean = False
            Call Validar_existe_num_comprobante(rpta_existe)

            If rpta_existe Then
                Avisar("El comprobante ya fue registrado, verifique los datos!")
                Exit Sub
            End If
        End If
       

        Dim facturaBL As New BL.LogisticaBL.SG_LO_TB_COMPROBANTES_CAB
        Dim cabeceraBE As New BE.LogisticaBE.SG_LO_TB_COMPROBANTES_CAB
        Dim detalleBE As BE.LogisticaBE.SG_LO_TB_COMPROBANTES_DET
        Dim ls_detalles As New List(Of BE.LogisticaBE.SG_LO_TB_COMPROBANTES_DET)

        With cabeceraBE
            .CO_ID = Val(txt_idcompra.Text)
            .CO_FEC_DOC = gDat_Fecha_Sis
            .CO_IDPROVE = txt_Idprove.Text.Trim
            .CO_TDOC = uce_TipoDoc.Value
            .CO_SDOC = txt_SerieDoc.Text
            .CO_NDOC = txt_NumDoc.Text
            .CO_FDOC = udte_Fec_Emi.Value
            .CO_VDOC = CDate(udte_Fec_Ven.Value).ToShortDateString
            .CO_IDMONEDA = uce_moneda.Value
            .CO_IDFORMA_PAGO = uce_for_pag.Value
            .CO_TC = ume_tc.Value
            .CO_FECHA_ENT = CDate(udte_fec_entrega.Value).ToShortDateString
            .CO_COMENTARIO = ""
            .CO_IDAUTORIZADO = 0
            .CO_ESTADO = 1
            .CO_SUBTOTAL = ume_subtotal.Value
            .CO_SUBTOTAL_NA = ume_SubExone.Value
            .CO_DESCUENTO = ume_descuento.Value
            .CO_IGV = ume_igv.Value
            .CO_TOTAL = ume_total.Value
            .CO_USUARIO = String.Format("{0}-{1}", Environment.UserName, gStr_Usuario_Sis)
            .CO_TERMINAL = Environment.MachineName
            .CO_IDEMPRESA = gInt_IdEmpresa
            .CO_NOTAS = txt_Notas.Text.Trim
            .CO_TDOC_REF = String.Empty
            .CO_SDOC_REF = String.Empty
            .CO_NDOC_REF = String.Empty
            .CO_INCLUYE_IGV = IIf(uck_IncluyeIGV.Checked = True, 1, 0)

            If uce_TipoDoc.Text = "NC" Then
                .CO_TDOC_REF = uce_TipoDocRef.Value
                .CO_SDOC_REF = txt_SerieDocRef.Text.Trim
                .CO_NDOC_REF = txt_NumDocRef.Text.Trim
                .CO_FDOC_REF = udte_Fec_EmiRef.Value 'listo falta q jale el valor del control!!   =)
            End If

            .CO_TASA_IGV = ume_Tasa_Igv.Value

        End With

        For i As Integer = 0 To ug_detalle.Rows.Count - 1
            detalleBE = New BE.LogisticaBE.SG_LO_TB_COMPROBANTES_DET
            With detalleBE
                .DE_IDCAB = 0
                .DE_ITEM = ug_detalle.Rows(i).Cells(0).Value
                .DE_IDARTICULO = ug_detalle.Rows(i).Cells("DE_IDARTICULO").Value
                .DE_IDUM = ug_detalle.Rows(i).Cells("UM_ID").Value
                .DE_IDUM_V = ug_detalle.Rows(i).Cells("DE_IDUM_V").Value
                .DE_CANT = ug_detalle.Rows(i).Cells("DE_CANT").Value
                .DE_CANT_V = ug_detalle.Rows(i).Cells("Cant_UmV").Value

                'If ug_detalle.Rows(i).Cells("AR_SIN_IGV").Value = 1 Then
                '    .DE_PRECIO_IGV = ug_detalle.Rows(i).Cells("DE_PRECIO").Value
                '    .DE_DESCUENTO_IGV = ug_detalle.Rows(i).Cells("DE_DESCUENTO").Value
                .DE_PRECIO = ug_detalle.Rows(i).Cells("DE_PRECIO").Value
                .DE_DESCUENTO = ug_detalle.Rows(i).Cells("DE_DESCUENTO").Value
                'ElseIf uck_IncluyeIGV.Checked = True Then
                '    .DE_PRECIO_IGV = ug_detalle.Rows(i).Cells("DE_PRECIO").Value
                '    .DE_DESCUENTO_IGV = ug_detalle.Rows(i).Cells("DE_DESCUENTO").Value

                '    .DE_PRECIO = ug_detalle.Rows(i).Cells("DE_PRECIO").Value / ((Val(ume_Tasa_Igv.Value) + 100) / 100)
                '    .DE_DESCUENTO = ug_detalle.Rows(i).Cells("DE_DESCUENTO").Value / ((Val(ume_Tasa_Igv.Value) + 100) / 100)
                'Else
                '.DE_PRECIO = ug_detalle.Rows(i).Cells("DE_PRECIO").Value
                '.DE_DESCUENTO = ug_detalle.Rows(i).Cells("DE_DESCUENTO").Value

                '.DE_PRECIO_IGV = (Val(ug_detalle.Rows(i).Cells("DE_PRECIO").Value) * (Val(ume_Tasa_Igv.Value) / 100)) + Val(ug_detalle.Rows(i).Cells("DE_PRECIO").Value)
                '.DE_DESCUENTO_IGV = (Val(ug_detalle.Rows(i).Cells("DE_DESCUENTO").Value) * (Val(ume_Tasa_Igv.Value) / 100)) + Val(ug_detalle.Rows(i).Cells("DE_DESCUENTO").Value)
                'End If

                .DE_IGV = ug_detalle.Rows(i).Cells(14).Value
                .DE_SUBTOTAL = ug_detalle.Rows(i).Cells(13).Value
                .DE_TOTAL = ug_detalle.Rows(i).Cells(15).Value
                .DE_ESTADO = 1
                .DE_COMENTARIO = String.Empty
                .DE_IDLOTE = ug_detalle.Rows(i).Cells("DE_IDLOTE").Value.ToString
                .DE_FEC_LOT = String.Empty
                If ug_detalle.Rows(i).Cells("DE_FEC_LOT").Value.ToString.Length > 0 Then
                    .DE_FEC_LOT = ug_detalle.Rows(i).Cells("DE_FEC_LOT").Value
                End If
            End With
            ls_detalles.Add(detalleBE)
        Next

        Try
            Dim num_voucher As String = ""
            Dim idcompra As Integer = 0
            If gInt_IdEmpresa = 7 Then
                If bol_nuevo Then
                    facturaBL.Insert_B(cabeceraBE, gInt_IdEmpresa, ls_detalles, num_voucher, idcompra, IIf(uchk_Movimiento.Checked = True, 0, 1))
                Else
                    facturaBL.update_B(cabeceraBE, gInt_IdEmpresa, ls_detalles)
                End If
            ElseIf gInt_IdEmpresa = 8 Then

                If bol_nuevo Then
                    facturaBL.Insert_STEM(cabeceraBE, gInt_IdEmpresa, ls_detalles, num_voucher, idcompra, IIf(uchk_Movimiento.Checked = True, 0, 1))
                Else
                    facturaBL.Update_STEM(cabeceraBE, gInt_IdEmpresa, ls_detalles)
                End If
            Else
                If bol_nuevo Then
                    facturaBL.Insert_CM(cabeceraBE, gInt_IdEmpresa, ls_detalles, num_voucher, idcompra, IIf(uchk_Movimiento.Checked = True, 0, 1))
                Else
                    facturaBL.Update_STEM(cabeceraBE, gInt_IdEmpresa, ls_detalles)
                End If
            End If

            txt_num_voucher.Text = num_voucher
            txt_idcompra.Text = idcompra
            If txt_num_voucher.Text <> "" Then
                Call Avisar("Listo!")
            End If

            Tool_Salir.Enabled = True
            Tool_Nuevo.Enabled = True
            Tool_Grabar.Enabled = False
            Tool_Cancelar.Enabled = False
            Tool_Imprimir.Enabled = True

            ubtn_agregar.Enabled = False
            ubtn_quitar.Enabled = False
            ugb_Cab.Enabled = False
            ug_detalle.Enabled = False

        Catch ex As Exception
            Call ShowError(ex.Message)
        End Try

    End Sub
    Private Sub Tool_Nuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_Nuevo.Click
        Tool_Cancelar.Enabled = True
        Tool_Grabar.Enabled = True
        Tool_Salir.Enabled = False
        Tool_Nuevo.Enabled = False
        Tool_Imprimir.Enabled = False
        Call Iniciar_Factura()
        bol_nuevo = True
        txt_cod_prove.Focus()
    End Sub

    Private Sub Iniciar_Factura()
        Call Limpiar_Controls_InGroupox(ugb_Cab)
        uce_moneda.SelectedIndex = 1
        uce_TipoDoc.SelectedIndex = 1
        uce_for_pag.SelectedIndex = 0
        udte_Fec_Emi.Value = Now
        udte_Fec_Ven.Value = Now
        udte_fec_entrega.Value = Now
        ugb_Cab.Enabled = True
        ubtn_agregar.Enabled = True
        ubtn_quitar.Enabled = True

        Call LimpiaGrid(ug_detalle, uds_detalle)
        ug_detalle.Enabled = True

        txt_idcompra.Text = ""
        txt_num_voucher.Text = ""
    End Sub

    Private Sub Ayuda_Proveedor()

        Dim f As New LO_LT_Ayuda_Prove
        f.ShowDialog()
        If f.GetLista().Count > 0 Then
            txt_cod_prove.Text = f.GetLista()(0).PR_NDOC
            txt_Idprove.Text = f.GetLista()(0).PR_ID
            txt_Des_Prove.Text = f.GetLista()(0).PR_DESCRIPCION
        End If

    End Sub
    Private Sub Buscar_Proveedor()
        Dim proveedorBL As New BL.LogisticaBL.SG_LO_TB_PROVEEDOR
        Dim drr_prove As System.Data.SqlClient.SqlDataReader
        drr_prove = proveedorBL.get_Proveedores_x_numeroDoc(txt_cod_prove.Text, gInt_IdEmpresa)
        If drr_prove.HasRows Then
            drr_prove.Read()
            txt_Idprove.Text = drr_prove("PR_ID")
            txt_Des_Prove.Text = drr_prove("PR_DESCRIPCION")
        End If
        drr_prove.Close()
    End Sub
    Private Sub txt_cod_prove_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_cod_prove.ValueChanged
        If txt_cod_prove.Text.Trim.Length = 0 Then
            txt_Idprove.Text = String.Empty
            txt_Des_Prove.Text = String.Empty
        End If
    End Sub
    Private Sub txt_cod_prove_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_cod_prove.KeyDown
        If e.KeyCode = Keys.F2 Then
            Call Ayuda_Proveedor()
        End If

        If e.KeyCode = Keys.Enter Then
            Call Buscar_Proveedor()
            uce_TipoDoc.Focus()
        End If

    End Sub
    Private Sub txt_cod_prove_EditorButtonClick(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinEditors.EditorButtonEventArgs) Handles txt_cod_prove.EditorButtonClick
        Call Ayuda_Proveedor()
    End Sub


    Private Sub udte_Fec_Emi_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles udte_Fec_Emi.ValueChanged
        Call Obtener_TipoCambio_dia()
        Call Cargar_Tasas_Impuestos()
        udte_Fec_Ven.Value = udte_Fec_Emi.Value
        udte_fec_entrega.Value = udte_Fec_Emi.Value
        Call Establecer_dias_credito()

    End Sub
    Private Sub Cargar_Tasas_Impuestos()

        Dim impuestosBL As New BL.ContabilidadBL.SG_CO_TB_IMPUESTO
        Dim impuestoBE As New BE.ContabilidadBE.SG_CO_TB_IMPUESTO

        impuestoBE.IM_IDEMPRESA = New BE.ContabilidadBE.SG_CO_TB_EMPRESA With {.EM_ID = gInt_IdEmpresa}
        impuestoBE.IM_IDTIPOIMPUESTO = New BE.ContabilidadBE.SG_CO_TB_TIPO_IMPUESTO With {.TI_CODIGO = "01"}
        impuestoBE.IM_PERIODO = CDate(udte_Fec_Emi.Value).Year
        impuestoBE.IM_MES = CDate(udte_Fec_Emi.Value).Month

        impuestosBL.getImpuestos_x_Tipo(impuestoBE)
        ume_Tasa_Igv.Value = impuestoBE.IM_TASA


        impuestosBL = Nothing
        impuestoBE = Nothing

    End Sub
    Private Sub Obtener_TipoCambio_dia()

        If udte_Fec_Emi.Value Is Nothing Then Exit Sub

        Dim Obj_tcBL As New BL.ContabilidadBL.SG_CO_TB_TIPOCAMBIO
        Dim E_tc As New BE.ContabilidadBE.SG_CO_TB_TIPOCAMBIO
        E_tc.TC_IDEMPRESA = New BE.ContabilidadBE.SG_CO_TB_EMPRESA With {.EM_ID = gInt_IdEmpresa}
        E_tc.TC_FECHA = CDate(udte_Fec_Emi.Value).ToShortDateString
        E_tc.TC_IDMONEDA = New BE.ContabilidadBE.SG_CO_TB_MONEDA With {.MO_CODIGO = 2}
        Obj_tcBL.getTipoCambio(E_tc)

        ume_tc.Value = E_tc.TC_VENTA

        E_tc = Nothing
        Obj_tcBL = Nothing


    End Sub


    Private Sub txt_SerieDoc_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_SerieDoc.Leave
        txt_SerieDoc.Text = txt_SerieDoc.Text.PadLeft(4, "0")
    End Sub
    Private Sub txt_NumDoc_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_NumDoc.Leave
        txt_NumDoc.Text = txt_NumDoc.Text.PadLeft(10, "0")
    End Sub
    Private Sub Establecer_dias_credito()
        If uce_for_pag.SelectedIndex = -1 Then Exit Sub
        If udte_Fec_Emi.Value Is Nothing Then Exit Sub

        Dim formapagoBL As New BL.LogisticaBL.SG_LO_TB_FORMA_PAGO
        Dim dt_tmp As DataTable = formapagoBL.get_fpvali(gInt_IdEmpresa, uce_for_pag.Value)
        If dt_tmp.Rows.Count > 0 Then
            If dt_tmp.Rows(0)("FP_DIAS") > 0 Then
                udte_Fec_Ven.Value = CDate(udte_Fec_Emi.Value).AddDays(dt_tmp.Rows(0)("FP_DIAS"))
            End If
        End If
        dt_tmp.Dispose()
        formapagoBL = Nothing

    End Sub


    Private Sub ug_Detalle_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles ug_detalle.KeyDown
        If e.KeyCode = Keys.Enter Then
            ug_detalle.PerformAction(UltraGridAction.NextCellByTab, False, False)
            ug_detalle.UpdateData()
        End If
    End Sub
    Private Sub ug_Detalle_BeforeRowsDeleted(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.BeforeRowsDeletedEventArgs) Handles ug_detalle.BeforeRowsDeleted
        e.DisplayPromptMsg = False
    End Sub
    Private Sub ug_Detalle_AfterRowUpdate(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinGrid.RowEventArgs) Handles ug_detalle.AfterRowUpdate
        Try
            Dim igv_cal As Double = 0
            Dim total_cal As Double = 0
            Dim subtotal_cal As Double = 0
            Dim precio_Arti As Double = 0
            Dim sINigv As Integer

            Dim cant As Double = 0
            Dim cantUM As Double = 0
            Dim cantTV As Double = 0
            Dim descuento As Double = 0
            Dim Descto_POR As Double = 0

            sINigv = e.Row.Cells("AR_SIN_IGV").Value
            '  precio_Arti = e.Row.Cells("DE_PRECIO").Value
            cant = e.Row.Cells("DE_CANT").Value
            cantUM = e.Row.Cells(16).Value
            Descto_POR = e.Row.Cells("DSCTO").Value

            'bruto = precio_Arti * cant
            If uck_IncluyeIGV.Checked = True Then
                total_cal = e.Row.Cells(15).Value
                If sINigv = 1 Then
                    subtotal_cal = total_cal
                Else
                    subtotal_cal = Math.Round(total_cal / ((Val(ume_Tasa_Igv.Value) + 100) / 100), 2)
                End If
            Else
                subtotal_cal = e.Row.Cells(13).Value
                If sINigv = 1 Then
                    total_cal = subtotal_cal
                Else
                    total_cal = Math.Round(subtotal_cal + (subtotal_cal * (Val(ume_Tasa_Igv.Value) / 100)), 2)
                End If
            End If

            igv_cal = Math.Round(total_cal - subtotal_cal, 2)
            precio_Arti = Math.Round(subtotal_cal / cant, 2)
            descuento = (precio_Arti * (Descto_POR / 100))

            'If sINigv = 1 Then
            '    subtotal_cal = (precio_Arti - descuento) * cant
            '    igv_cal = 0
            '    total_cal = Math.Round(subtotal_cal + igv_cal, 2)
            'ElseIf uck_IncluyeIGV.Checked = True Then
            '    total_cal = (precio_Arti - descuento) * cant
            '    subtotal_cal = Math.Round(total_cal / ((Val(ume_Tasa_Igv.Value) + 100) / 100), 2)
            '    igv_cal = Math.Round(total_cal - subtotal_cal, 2)
            'Else
            '    subtotal_cal = (precio_Arti - descuento) * cant
            '    igv_cal = Math.Round(subtotal_cal * (ume_Tasa_Igv.Value / 100), 2)
            '    total_cal = Math.Round(subtotal_cal + igv_cal, 2)
            'End If

            cantTV = Math.Round(cant * cantUM)

            e.Row.Cells("Cant_UmV").Value = cantTV
            e.Row.Cells("DE_DESCUENTO").Value = descuento
            e.Row.Cells(15).Value = total_cal
            e.Row.Cells(14).Value = igv_cal
            e.Row.Cells(13).Value = subtotal_cal
            e.Row.Cells("DE_PRECIO").Value = precio_Arti

            Call Calcular_Totales()
        Catch ex As Exception
            Call ShowError(ex.Message)
        End Try
    End Sub
    Private Sub ug_detalle_AfterRowsDeleted(ByVal sender As Object, ByVal e As System.EventArgs) Handles ug_detalle.AfterRowsDeleted
        Call ReHacerSecuencia()
        Call Calcular_Totales()
    End Sub

    Private Sub Calcular_Totales()
            Dim subtotal As Double = 0
            Dim subtotalNA As Double = 0
            ' Dim igv As Double = 0
            Dim descuento As Double = 0
            Dim total As Double = 0

            For i As Integer = 0 To ug_detalle.Rows.Count - 1
                ' subtotal += ug_detalle.Rows(i).Cells(13).Value
                If ug_detalle.Rows(i).Cells(14).Value = 0 Then
                    subtotalNA += ug_detalle.Rows(i).Cells(13).Value
                Else
                    subtotal += ug_detalle.Rows(i).Cells(13).Value
                    total += ug_detalle.Rows(i).Cells(15).Value
                End If
                ' igv += ug_detalle.Rows(i).Cells(14).Value
                descuento += ug_detalle.Rows(i).Cells("DE_DESCUENTO").Value
            Next
            If uck_IncluyeIGV.Checked = True Then
                subtotal = total / ((ume_Tasa_Igv.Value + 100) / 100)
            Else
                total = subtotal + (subtotal * (ume_Tasa_Igv.Value / 100))
            End If

            ume_descuento.Value = descuento
            ume_subtotal.Value = Math.Round(subtotal, 2) + Math.Round(subtotalNA, 2)
            ume_SubExone.Value = Math.Round(subtotalNA, 2)
            ume_igv.Value = Math.Round(total, 2) - Math.Round(subtotal, 2)
            ume_total.Value = Math.Round(total, 2) + Math.Round(subtotalNA, 2)

    End Sub

    Private Sub ubtn_quitar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ubtn_quitar.Click
        If ug_detalle.Rows.Count = 0 Then Exit Sub
        If ug_detalle.ActiveRow Is Nothing Then Exit Sub

        ug_detalle.ActiveRow.Delete()

        Call ReHacerSecuencia()
        Call Calcular_Totales()
    End Sub
    Private Sub ubtn_agregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ubtn_agregar.Click
        ' Dim f As New LO_LT_AyuArtiCom
        LO_LT_AyuArtiCom.ShowDialog()
        If LO_LT_AyuArtiCom.bol_Aceptar Then

            Dim matriz As List(Of BE.LogisticaBE.SG_LO_TB_ARTICULO) = LO_LT_AyuArtiCom.GetLista

            For Each articulo As BE.LogisticaBE.SG_LO_TB_ARTICULO In matriz

                ug_detalle.DisplayLayout.Bands(0).AddNew()
                With ug_detalle.Rows(ug_detalle.Rows.Count - 1)
                    .Cells(0).Value = ug_detalle.Rows.Count
                    .Cells("DE_IDARTICULO").Value = articulo.AR_ID
                    .Cells("AR_DESCRIPCION").Value = articulo.AR_DESCRIPCION
                    .Cells("DE_IDLOTE").Value = ""
                    .Cells("DE_FEC_LOT").Value = Now.Date
                    .Cells("UM_ID").Value = articulo.AR_UM_COMPRA
                    .Cells("UM_DESCRIPCION").Value = articulo.UM_Des
                    .Cells("DE_CANT").Value = 1
                    .Cells("Des_UmV").Value = articulo.UM_DesV
                    .Cells("Cant_UmV").Value = articulo.AR_CANT_UMC
                    .Cells("DE_PRECIO").Value = articulo.AR_PRECIO_COMPRA
                    .Cells("DE_DESCUENTO").Value = 0
                    .Cells("DSCTO").Value = 0
                    .Cells("DE_IDUM_V").Value = articulo.AR_UM_VENTA
                    .Cells("AR_SIN_IGV").Value = articulo.AR_SIN_IGV

                    .Cells(13).Value = 0
                    .Cells(14).Value = 0
                    .Cells(15).Value = 0
                    .Cells(16).Value = articulo.AR_CANT_UMC
                End With
                ug_detalle.UpdateData()
            Next


        End If

    End Sub

    'Private Sub uce_TipoDoc_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles uce_TipoDoc.KeyDown
    '    If e.KeyCode = Keys.Enter Then
    '        txt_SerieDoc.Focus()
    '    End If
    'End Sub

    'Private Sub txt_SerieDoc_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles txt_SerieDoc.KeyDown
    '    If e.KeyCode = Keys.Enter Then
    '        txt_NumDoc.Focus()
    '    End If
    'End Sub

    'Private Sub txt_NumDoc_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles txt_NumDoc.KeyDown
    '    If e.KeyCode = Keys.Enter Then
    '        uce_for_pag.Focus()
    '    End If
    'End Sub

    'Private Sub uce_for_pag_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles uce_for_pag.KeyDown
    '    If e.KeyCode = Keys.Enter Then
    '        uce_moneda.Focus()
    '    End If
    'End Sub

    'Private Sub uce_moneda_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles uce_moneda.KeyDown
    '    If e.KeyCode = Keys.Enter Then
    '        txt_Notas.Focus()
    '    End If
    'End Sub

    'Private Sub txt_Notas_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles txt_Notas.KeyDown
    '    If e.KeyCode = Keys.Enter Then
    '        udte_Fec_Emi.Focus()
    '    End If
    'End Sub

    'Private Sub udte_Fec_Emi_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles udte_Fec_Emi.KeyDown
    '    If e.KeyCode = Keys.Enter Then
    '        udte_Fec_Ven.Focus()
    '    End If
    'End Sub

    'Private Sub udte_Fec_Ven_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles udte_Fec_Ven.KeyDown
    '    If e.KeyCode = Keys.Enter Then
    '        udte_fec_entrega.Focus()
    '    End If
    'End Sub

    'Private Sub udte_fec_entrega_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles udte_fec_entrega.KeyDown
    '    If e.KeyCode = Keys.Enter Then
    '        ubtn_agregar.Focus()
    '    End If
    'End Sub

    Private Sub uce_for_pag_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles uce_for_pag.ValueChanged
        Establecer_dias_credito()
    End Sub

    Private Sub Tool_Imprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_Imprimir.Click
        If txt_idcompra.Text = "" Then Exit Sub
        Me.Cursor = Cursors.WaitCursor
        Dim obj As New DataTable

        'Dim obj As New DataTable
        'Dim obe As New BE.LogisticaBE.SG_LO_TB_COMPROBANTES_CAB
        Dim obr As New BL.LogisticaBL.SG_LO_TB_COMPROBANTES_CAB
        'obe.CO_ID = Val(txt_idcompra.Text)
        'obe.CO_IDEMPRESA = gInt_IdEmpresa
        'obe.CM_IDALMACEN = IIf(uck_Area.Checked = True, uce_Almacen.Value, "")

        Dim nom_reporte As String = "SG_LO_06.RPT"
        Dim crystalBL As New LR.ClsReporte
        Dim dt_data As New DataTable
        dt_data = obr.get_ComprobanteImprimir(Val(txt_idcompra.Text), gInt_IdEmpresa)
     
        crystalBL.Muestra_Reporte(gStr_RutaRep & "\" & nom_reporte, dt_data, "", "pSubTotal;" & ume_subtotal.Text, "pIgv;" & ume_igv.Text, "pTotal;" & ume_total.Text, "pProveedor;" & txt_Des_Prove.Text, "pRuc;" & txt_cod_prove.Text, "pComprobante;" & txt_SerieDoc.Text & " - " & txt_NumDoc.Text)

        crystalBL = Nothing
        ' reportesBL = Nothing

        Me.Cursor = Cursors.Default
    End Sub

    Private Sub uce_TipoDoc_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles uce_TipoDoc.Leave
        If uce_TipoDoc.Text = "NC" Then
            uce_TipoDocRef.ReadOnly = False
            txt_SerieDocRef.ReadOnly = False
            txt_NumDocRef.ReadOnly = False
            udte_Fec_EmiRef.ReadOnly = False
            uchk_Movimiento.Checked = False
            uchk_Movimiento.Enabled = True
        Else
            uce_TipoDocRef.ReadOnly = True
            txt_SerieDocRef.ReadOnly = True
            txt_NumDocRef.ReadOnly = True
            udte_Fec_EmiRef.ReadOnly = True
            uchk_Movimiento.Checked = False
            uchk_Movimiento.Enabled = False
        End If
    End Sub

    Private Sub uck_IncluyeIGV_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles uck_IncluyeIGV.CheckedChanged

        If uck_IncluyeIGV.Checked = True Then

            ug_detalle.DisplayLayout.Bands(0).Columns(15).CellActivation = Activation.AllowEdit
            ug_detalle.DisplayLayout.Bands(0).Columns(13).CellActivation = Activation.NoEdit
        Else
            ug_detalle.DisplayLayout.Bands(0).Columns(13).CellActivation = Activation.AllowEdit
            ug_detalle.DisplayLayout.Bands(0).Columns(15).CellActivation = Activation.NoEdit
        End If
        ReHacerSecuencia()
    End Sub

End Class