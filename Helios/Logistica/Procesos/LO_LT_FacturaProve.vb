Imports Infragistics.Win.UltraWinGrid

Public Class LO_LT_FacturaProve
    Public bol_nuevo As Boolean = True
    Private Sub LO_LT_FacturaProve_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Call Cargar_Monedas()
        Call Cargar_Documentos()
        Call Cargar_Forma_Pago()


        txt_cod_prove.ButtonsRight(0).Appearance.Image = My.Resources._104
        ubtn_agregar.Appearance.Image = My.Resources._16__Plus_
        ubtn_doc_ref.Appearance.Image = My.Resources._16__Page_number_

        Tool_Cancelar.Enabled = False
        Tool_Grabar.Enabled = False
        Tool_Salir.Enabled = True
        Tool_Nuevo.Enabled = True
        ugb_Cab.Enabled = False
        ubtn_agregar.Enabled = False

        Dim unidadesBL As New BL.LogisticaBL.SG_LO_TB_UNI_MED
        Call CrearComboGrid("Cod_um", "UM_ABREVI", ug_detalle, unidadesBL.getMedidas(gInt_IdEmpresa), True)
        unidadesBL = Nothing

    End Sub

    Private Sub Cargar_Forma_Pago()
        Dim formapaBL As New BL.LogisticaBL.SG_LO_TB_FORMA_PAGO
        uce_for_pag.DataSource = formapaBL.get_Formas(gInt_IdEmpresa)
        uce_for_pag.DisplayMember = "FP_DESCRIPCION"
        uce_for_pag.ValueMember = "FP_ID"
        formapaBL = Nothing
    End Sub

    Private Sub Cargar_Documentos()
        Dim documentoBL As New BL.LogisticaBL.SG_LO_TB_TIPO_DOCUMENTO
        uce_TipoDoc.DataSource = documentoBL.get_Documentos(gInt_IdEmpresa)
        uce_TipoDoc.DisplayMember = "DES"
        uce_TipoDoc.ValueMember = "TD_ID"
        documentoBL = Nothing
    End Sub

    Private Sub Cargar_Monedas()
        Dim monedasBL As New BL.LogisticaBL.SG_LO_TB_MONEDA
        uce_moneda.DataSource = monedasBL.get_Monedas(gInt_IdEmpresa)
        uce_moneda.DisplayMember = "MO_DESCRIPCION"
        uce_moneda.ValueMember = "MO_ID"
        monedasBL = Nothing
    End Sub

    Private Sub ReHacerSecuencia()
        For i As Integer = 0 To ug_detalle.Rows.Count - 1
            ug_detalle.Rows(i).Cells("Item").Value = i + 1
        Next
        ug_detalle.UpdateData()
    End Sub

    Private Sub ug_detalle_AfterRowsDeleted(ByVal sender As Object, ByVal e As System.EventArgs) Handles ug_detalle.AfterRowsDeleted
        Call ReHacerSecuencia()
        Call Calcular_Totales()
    End Sub

    Private Sub ToolS_Mantenimiento_ItemClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolStripItemClickedEventArgs) Handles ToolS_Mantenimiento.ItemClicked

    End Sub

    Private Sub txt_Glosa_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_Notas.ValueChanged

    End Sub

    Private Sub Tool_Salir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_Salir.Click
        Me.Close()
    End Sub

    Private Sub Tool_Cancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_Cancelar.Click
        Tool_Cancelar.Enabled = False
        Tool_Grabar.Enabled = False
        Tool_Salir.Enabled = True
        Tool_Nuevo.Enabled = True
        ugb_Cab.Enabled = False
        ubtn_agregar.Enabled = False
        Call Limpiar_Controls_InGroupox(ugb_Cab)
        Call LimpiaGrid(ug_detalle, uds_detalle)

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

        If CDate(udte_Fec_Ven.Value) < CDate(udte_Fec_Emi.Value) Then
            Avisar("La fecha de vencimiento no puede ser menor a la fecha de emision")
            udte_Fec_Ven.Focus()
            Exit Sub
        End If


        If ug_detalle.Rows.Count = 0 Then
            Avisar("No hay productos en el detalle")
            Exit Sub
        End If

        If uce_TipoDoc.Text = "NC" Then
            If LO_LT_DocRef.uce_TipoDocRef.SelectedIndex = -1 Then
                Avisar("Seleccione un tipo de documento de referencia")
                Exit Sub
            End If

            If LO_LT_DocRef.txt_SerieDocRef.Text.Trim.Length = 0 Then
                Avisar("Ingrese el num. de serie de referencia")
                Exit Sub
            End If


            If LO_LT_DocRef.txt_NumDocRef.Text.Trim.Length = 0 Then
                Avisar("Ingrese el numero del doc. de referencia")
                Exit Sub
            End If
        End If


        Dim facturaBL As New BL.LogisticaBL.SG_LO_TB_COMPROBANTES_CAB
        Dim cabeceraBE As New BE.LogisticaBE.SG_LO_TB_COMPROBANTES_CAB
        Dim detalleBE As BE.LogisticaBE.SG_LO_TB_COMPROBANTES_DET
        Dim ls_detalles As New List(Of BE.LogisticaBE.SG_LO_TB_COMPROBANTES_DET)


        With cabeceraBE
            .CO_ID = 0
            .CO_FEC_DOC = gDat_Fecha_Sis
            .CO_IDPROVE = txt_Idprove.Text.Trim
            .CO_TDOC = uce_TipoDoc.Value
            .CO_SDOC = txt_SerieDoc.Text
            .CO_NDOC = txt_NumDoc.Text
            .CO_FDOC = CDate(udte_Fec_Emi.Value).ToShortDateString
            .CO_VDOC = CDate(udte_Fec_Ven.Value).ToShortDateString
            .CO_IDMONEDA = uce_moneda.Value
            .CO_IDFORMA_PAGO = uce_for_pag.Value
            .CO_TC = ume_tc.Value
            .CO_FECHA_ENT = CDate(udte_fec_entrega.Value).ToShortDateString
            .CO_COMENTARIO = txt_Notas.Text.Trim
            .CO_IDAUTORIZADO = 0
            .CO_HOR_ENT = ""
            .CO_DIR_ENT = ""
            .CO_ESTADO = 1
            .CO_SUBTOTAL = ume_subtotal.Value
            .CO_DESCUENTO = ume_descuento.Value
            .CO_IGV = ume_igv.Value
            .CO_TOTAL = ume_total.Value
            .CO_USUARIO = String.Format("{0}-{1}", Environment.UserName, gStr_Usuario_Sis)
            .CO_TERMINAL = Environment.MachineName
            .CO_FEC_REG = Now
            .CO_IDORDCOM = IIf(txt_idordencompra.Text.Trim = "", 0, txt_idordencompra.Text.Trim)
            .CO_IDEMPRESA = gInt_IdEmpresa
            .CO_NOTAS = txt_Notas.Text.Trim
            .CO_TDOC_REF = String.Empty
            .CO_SDOC_REF = String.Empty
            .CO_NDOC_REF = String.Empty

            If uce_TipoDoc.Text = "NC" Then
                .CO_TDOC_REF = LO_LT_DocRef.uce_TipoDocRef.Value
                .CO_SDOC_REF = LO_LT_DocRef.txt_SerieDocRef.Text.Trim
                .CO_NDOC_REF = LO_LT_DocRef.txt_NumDocRef.Text.Trim
            End If
            
        End With


        For i As Integer = 0 To ug_detalle.Rows.Count - 1
            detalleBE = New BE.LogisticaBE.SG_LO_TB_COMPROBANTES_DET
            With detalleBE
                .DE_IDCAB = 0
                .DE_ITEM = ug_detalle.Rows(i).Cells("Item").Value
                .DE_IDARTICULO = ug_detalle.Rows(i).Cells("Cod_Articulo").Value
                .DE_IDUM = ug_detalle.Rows(i).Cells("Cod_um").Value
                .DE_CANT = ug_detalle.Rows(i).Cells("Cantidad").Value
                .DE_PRECIO = ug_detalle.Rows(i).Cells("Precio").Value
                .DE_DESCUENTO = ug_detalle.Rows(i).Cells("Descuento").Value
                .DE_IGV = ug_detalle.Rows(i).Cells("Igv").Value
                .DE_SUBTOTAL = ug_detalle.Rows(i).Cells("Subtotal").Value
                .DE_TOTAL = ug_detalle.Rows(i).Cells("Total").Value
                .DE_ESTADO = 1
                .DE_COMENTARIO = String.Empty
                .DE_IDLOTE = ug_detalle.Rows(i).Cells("Lote").Value.ToString
                .DE_FEC_LOT = String.Empty
                If ug_detalle.Rows(i).Cells("FecLot").Value.ToString.Length > 0 Then
                    .DE_FEC_LOT = ug_detalle.Rows(i).Cells("FecLot").Value
                End If

            End With
            ls_detalles.Add(detalleBE)
        Next

        Try
            'facturaBL.Insert_L(cabeceraBE, gInt_IdEmpresa, ls_detalles)
            'Call Avisar("Listo!")
        Catch ex As Exception
            Call ShowError(ex.Message)
        End Try

    End Sub

    Private Sub Tool_Nuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_Nuevo.Click
        Tool_Cancelar.Enabled = True
        Tool_Grabar.Enabled = True
        Tool_Salir.Enabled = False
        Tool_Nuevo.Enabled = False
        Call Iniciar_Factura()
        txt_cod_prove.Focus()
    End Sub

    Private Sub Iniciar_Factura()
        uce_moneda.SelectedIndex = 1
        uce_TipoDoc.SelectedIndex = 1
        uce_for_pag.SelectedIndex = 0
        udte_Fec_Emi.Value = Nothing
        udte_Fec_Ven.Value = Nothing
        udte_fec_entrega.Value = Nothing
        ugb_Cab.Enabled = True
        ubtn_agregar.Enabled = True
    End Sub

    Private Sub ubtn_agregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ubtn_agregar.Click
        'Dim f As New LO_LT_AyuArtiCom
        'f.ShowDialog()
        'If f.bol_Aceptar Then
        '    ug_detalle.DisplayLayout.Bands(0).AddNew()
        '    With ug_detalle.Rows(ug_detalle.Rows.Count - 1)
        '        .Cells("Item").Value = ug_detalle.Rows.Count
        '        .Cells("Cod_Articulo").Value = f.ls_lista(0)
        '        .Cells("Des_Articulo").Value = f.ls_lista(1)
        '        .Cells("Cod_um").Value = f.ls_lista(2)
        '        .Cells("Des_um").Value = f.ls_lista(3)
        '        .Cells("Lote").Value = ""
        '        .Cells("Cantidad").Value = 1
        '        .Cells("Precio").Value = 1
        '        .Cells("Descuento").Value = 0
        '        .Cells("Igv").Value = 0
        '        .Cells("Subtotal").Value = 0
        '        .Cells("Total").Value = 0
        '    End With
        '    ug_detalle.UpdateData()
        'End If
    End Sub

    Private Sub txt_cod_prove_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles txt_cod_prove.KeyDown

        If e.KeyCode = Keys.F2 Then
            Call Ayuda_Proveedor()
        End If

        If e.KeyCode = Keys.Enter Then
            uce_TipoDoc.Focus()
        End If

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

    Private Sub txt_cod_prove_EditorButtonClick(sender As System.Object, e As Infragistics.Win.UltraWinEditors.EditorButtonEventArgs) Handles txt_cod_prove.EditorButtonClick
        Call Ayuda_Proveedor()
    End Sub

    Private Sub udte_Fec_Emi_ValueChanged(sender As System.Object, e As System.EventArgs) Handles udte_Fec_Emi.ValueChanged
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
        impuestoBE.IM_PERIODO = CDate(udte_fec_emi.Value).Year
        impuestoBE.IM_MES = CDate(udte_fec_emi.Value).Month

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

    Private Sub txt_SerieDoc_Leave(sender As System.Object, e As System.EventArgs) Handles txt_SerieDoc.Leave
        txt_SerieDoc.Text = txt_SerieDoc.Text.PadLeft(4, "0")
    End Sub

    Private Sub txt_NumDoc_Leave(sender As System.Object, e As System.EventArgs) Handles txt_NumDoc.Leave
        txt_NumDoc.Text = txt_NumDoc.Text.PadLeft(10, "0")
    End Sub

    Private Sub uce_TipoDoc_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles uce_TipoDoc.KeyDown
        If e.KeyCode = Keys.Enter Then
            txt_SerieDoc.Focus()
        End If
        If e.KeyCode = Keys.F5 Then
            Call Cargar_Documentos()
        End If
    End Sub

    Private Sub txt_NumDoc_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles txt_NumDoc.KeyDown
        If e.KeyCode = Keys.Enter Then
            If uce_TipoDoc.Text = "NC" Then
                ubtn_doc_ref.Focus()
            Else
                uce_for_pag.Focus()
            End If

        End If
    End Sub

    Private Sub txt_SerieDoc_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles txt_SerieDoc.KeyDown
        If e.KeyCode = Keys.Enter Then
            txt_NumDoc.Focus()
        End If
    End Sub

    Private Sub uce_for_pag_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles uce_for_pag.KeyDown
        If e.KeyCode = Keys.Enter Then
            udte_Fec_Emi.Focus()
        End If
        If e.KeyCode = Keys.F5 Then
            Call Cargar_Forma_Pago()
        End If
    End Sub

    Private Sub uce_moneda_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles uce_moneda.KeyDown
        If e.KeyCode = Keys.Enter Then
            ume_tc.Focus()
        End If
    End Sub

    Private Sub ume_tc_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles ume_tc.KeyDown
        If e.KeyCode = Keys.Enter Then
            txt_Notas.Focus()
        End If
    End Sub

    Private Sub udte_Fec_Emi_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles udte_Fec_Emi.KeyDown
        If e.KeyCode = Keys.Enter Then
            udte_Fec_Ven.Focus()
        End If
    End Sub

    Private Sub udte_Fec_Ven_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles udte_Fec_Ven.KeyDown
        If e.KeyCode = Keys.Enter Then
            udte_fec_entrega.Focus()
        End If
    End Sub

    Private Sub udte_fec_entrega_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles udte_fec_entrega.KeyDown
        If e.KeyCode = Keys.Enter Then
            uce_moneda.Focus()
        End If
    End Sub

    Private Sub txt_Notas_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles txt_Notas.KeyDown
        If e.KeyCode = Keys.Enter Then
            ubtn_agregar.Focus()
        End If
    End Sub

    Private Sub uce_for_pag_ValueChanged(sender As System.Object, e As System.EventArgs) Handles uce_for_pag.ValueChanged

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

    Private Sub ug_Detalle_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles ug_detalle.KeyDown
        If e.KeyCode = Keys.Enter Then
            ug_detalle.PerformAction(UltraGridAction.NextCellByTab, False, False)
            ug_detalle.UpdateData()
        End If
    End Sub

    Private Sub ug_Detalle_BeforeRowsDeleted(sender As System.Object, e As Infragistics.Win.UltraWinGrid.BeforeRowsDeletedEventArgs) Handles ug_detalle.BeforeRowsDeleted
        e.DisplayPromptMsg = False
    End Sub

    Private Sub ug_Detalle_AfterRowUpdate(sender As Object, e As Infragistics.Win.UltraWinGrid.RowEventArgs) Handles ug_detalle.AfterRowUpdate
        'e.Row.Cells("Total").Value = e.Row.Cells("Precio").Value * e.Row.Cells("Cant").Value

        Dim igv_cal As Double = 0
        Dim total_cal As Double = 0
        Dim subtotal_cal As Double = 0
        Dim precio_Arti As Double = 0
        Dim bruto As Double = 0
        Dim cant As Double = 0
        Dim descuento As Double = 0

        precio_Arti = e.Row.Cells("Precio").Value
        cant = e.Row.Cells("Cantidad").Value
        descuento = e.Row.Cells("Descuento").Value
        bruto = precio_Arti * cant
        subtotal_cal = bruto - descuento
        igv_cal = Math.Round(subtotal_cal * (ume_Tasa_Igv.Value / 100), 2)
        total_cal = Math.Round(subtotal_cal + igv_cal, 2)


        e.Row.Cells("Total").Value = total_cal
        e.Row.Cells("Igv").Value = igv_cal
        e.Row.Cells("SubTotal").Value = subtotal_cal

        Call Calcular_Totales()

    End Sub

    Private Sub Calcular_Totales()

        Dim subtotal As Double = 0
        Dim igv As Double = 0
        Dim descuento As Double = 0
        Dim total As Double = 0

        ug_detalle.UpdateData()

        For i As Integer = 0 To ug_detalle.Rows.Count - 1
            subtotal += ug_detalle.Rows(i).Cells("SubTotal").Value
            igv += ug_detalle.Rows(i).Cells("Igv").Value
            total += ug_detalle.Rows(i).Cells("Total").Value
            descuento += ug_detalle.Rows(i).Cells("Descuento").Value
        Next

        ume_descuento.Value = descuento
        ume_subtotal.Value = subtotal
        ume_igv.Value = igv
        ume_total.Value = total
        ug_detalle.UpdateData()

    End Sub

    Private Sub uce_TipoDoc_ValueChanged(sender As System.Object, e As System.EventArgs) Handles uce_TipoDoc.ValueChanged
        ubtn_doc_ref.Enabled = False
        If uce_TipoDoc.Text = "NC" Then ubtn_doc_ref.Enabled = Not ubtn_doc_ref.Enabled
    End Sub

    'Private Sub ubtn_doc_ref_Click(sender As System.Object, e As System.EventArgs) Handles ubtn_doc_ref.Click
    '    LO_LT_DocRef.ShowDialog()
    '    Call Cargar_Doc_x_NC()
    'End Sub

    'Private Sub Cargar_Doc_x_NC()

    '    If txt_Idprove.Text.Trim.Length = 0 Then
    '        Avisar("Ingrese el proveedor")
    '        txt_Idprove.Focus()
    '        Exit Sub
    '    End If


    '    udte_Fec_Emi.Value = gDat_Fecha_Sis

    '    Dim tdoc As String = LO_LT_DocRef.uce_TipoDocRef.Value
    '    Dim sdoc As String = LO_LT_DocRef.txt_SerieDocRef.Text.Trim
    '    Dim ndoc As String = LO_LT_DocRef.txt_NumDocRef.Text.Trim

    '    Dim comprobanteBL As New BL.LogisticaBL.SG_LO_TB_COMPROBANTES_CAB
    '    Dim dt_tmp As DataTable = comprobanteBL.get_Comprobante_xDoc(txt_Idprove.Text.Trim, tdoc, sdoc, ndoc, gInt_IdEmpresa)

    '    If dt_tmp.Rows.Count > 0 Then

    '        For i As Integer = 0 To dt_tmp.Rows.Count - 1
    '            ug_detalle.DisplayLayout.Bands(0).AddNew()
    '            With ug_detalle.Rows(ug_detalle.Rows.Count - 1)
    '                .Cells("Item").Value = ug_detalle.Rows.Count
    '                .Cells("Cod_Articulo").Value = dt_tmp.Rows(i)("DE_IDARTICULO")
    '                .Cells("Des_Articulo").Value = dt_tmp.Rows(i)("AR_DESCRIPCION")
    '                .Cells("Cod_um").Value = dt_tmp.Rows(i)("DE_IDUM")
    '                .Cells("Des_um").Value = String.Empty
    '                .Cells("Lote").Value = dt_tmp.Rows(i)("DE_IDLOTE").ToString
    '                .Cells("FecLot").Value = dt_tmp.Rows(i)("DE_FEC_LOT")
    '                .Cells("Cantidad").Value = dt_tmp.Rows(i)("DE_CANT")
    '                .Cells("Precio").Value = dt_tmp.Rows(i)("DE_PRECIO")
    '                .Cells("Descuento").Value = 0
    '                .Cells("Igv").Value = 0
    '                .Cells("Subtotal").Value = 0
    '                .Cells("Total").Value = 0
    '            End With
    '            ug_detalle.UpdateData()
    '        Next

    '    End If

    '    dt_tmp.Dispose()
    '    comprobanteBL = Nothing

    '    txt_Notas.Text = "Doc. Ref. " & tdoc & "-" & sdoc & "-" & ndoc

    'End Sub

End Class