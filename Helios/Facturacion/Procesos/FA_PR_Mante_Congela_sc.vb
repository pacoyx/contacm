Public Class FA_PR_Mante_Congela_sc

    Dim bol_nuevo As Boolean = False

    'para grabar cabecera y detalle
    'SG_FA_SP_I_PAGO_CONGE_C
    'SG_FA_SP_I_PAGO_CONGE_D
    'SG_FA_SP_S_PAGO_CONGE_C - para el selec de la grilla 
    'SG_FA_TB_TIPO_CONGELA

    Private Sub FA_PR_Mante_Congela_sc_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

        Call Cargar_Cmbs()
        Call Cargar_Datos()
        Call Inicializar_Estado_Botones_Tool(ToolS_Mantenimiento)

        txt_ruc_cliente.ButtonsRight(0).Appearance.Image = My.Resources._104
        btn_quitar.Appearance.Image = My.Resources._16__Delete_
        btn_nuevo_det.Appearance.Image = My.Resources._16__Plus_
        btn_Aceptar.Appearance.Image = My.Resources._16__Ok_
        btn_cancelar.Appearance.Image = My.Resources._16__Cancel_
    End Sub

    Private Sub Cargar_Datos()
        Dim cabeceraBL As New BL.FacturacionBL.SG_FA_TB_PAGO_CONGE_C
        ug_Lista.DataSource = cabeceraBL.get_Congelaciones(gInt_IdEmpresa)
        cabeceraBL = Nothing
    End Sub

    Private Sub Reiniciar_Secuencia()

        For i As Integer = 0 To ug_detalle.Rows.Count - 1
            ug_detalle.Rows(i).Cells("ITEM").Value = i + 1
        Next
        ug_detalle.Update()

    End Sub

    Private Sub Obtener_TipoCambio_dia()

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
            tipocambioBE.PA_FECHA = gDat_Fecha_Sis.ToShortDateString
            Dim dt_tc As DataTable = tipocambioBL.get_Pariedad_x_Fecha(tipocambioBE)

            If dt_tc.Rows.Count > 0 Then

                If bol_nuevo Then
                    ume_ValorTipoCambio.Value = dt_tc.Rows(0)("PA_VENTA")
                End If

                ume_tc_det.Value = dt_tc.Rows(0)("PA_VENTA")
            Else
                ume_ValorTipoCambio.Value = 0
                ume_tc_det.Value = 0
            End If

            dt_tc = Nothing

            tipocambioBE = Nothing
            tipocambioBL = Nothing

        Else ' rpta = "C"

            Dim tipocamBL As New BL.ContabilidadBL.SG_CO_TB_TIPOCAMBIO
            Dim tipocamBE As New BE.ContabilidadBE.SG_CO_TB_TIPOCAMBIO

            tipocamBE.TC_IDEMPRESA = New BE.ContabilidadBE.SG_CO_TB_EMPRESA With {.EM_ID = gInt_IdEmpresa}


            tipocamBE.TC_IDMONEDA = New BE.ContabilidadBE.SG_CO_TB_MONEDA With {.MO_CODIGO = 2}
            tipocamBE.TC_FECHA = gDat_Fecha_Sis.ToShortDateString
            tipocamBL.getTipoCambio(tipocamBE)

            If bol_nuevo Then
                ume_ValorTipoCambio.Value = tipocamBE.TC_VENTA
            End If

            ume_tc_det.Value = tipocamBE.TC_VENTA

            tipocamBE = Nothing
            tipocamBL = Nothing

        End If

        If uce_Moneda.Value = "02" Then
            If ume_ValorTipoCambio.Value = 0 Then
                Avisar("Ingrese el tipo de cambio del dia para comprobantes en DOLARES")
            End If
        End If

    End Sub

    Private Sub Cargar_Cmbs()

        Call CargarCombo_ConMeses(uce_mes)

        For i As Integer = 2015 To 2020
            uce_ayo.Items.Add(i, i)
        Next

        Dim medicoBL As New BL.AdmisionBL.SG_AD_TB_MEDICO
        Dim dt_tmp As DataTable = medicoBL.get_Medicos_cmb(1) 'pasamos el codigo de empresa 1 = clinica , para que cargue los medicos de clinica.
        medicoBL = Nothing

        uce_Medico.DataSource = dt_tmp
        uce_Medico.DisplayMember = "NOMBRES"
        uce_Medico.ValueMember = "ME_CODIGO"


        Dim Obj_MonedaBL As New BL.FacturacionBL.SG_FA_TB_MONEDA
        Dim dt_tmp1 As DataTable = Obj_MonedaBL.get_Monedas(New BE.ContabilidadBE.SG_CO_TB_EMPRESA With {.EM_ID = gInt_IdEmpresa})
        Dim dt_tmp2 As DataTable = Obj_MonedaBL.get_Monedas(New BE.ContabilidadBE.SG_CO_TB_EMPRESA With {.EM_ID = gInt_IdEmpresa})

        uce_Moneda.DataSource = dt_tmp1
        uce_Moneda.DisplayMember = "MO_ABREVIATURA"
        uce_Moneda.ValueMember = "MO_ID"

        uce_moneda_det.DataSource = dt_tmp2
        uce_moneda_det.DisplayMember = "MO_ABREVIATURA"
        uce_moneda_det.ValueMember = "MO_ID"

        Obj_MonedaBL = Nothing



        Dim cabeceraBL As New BL.FacturacionBL.SG_FA_TB_PAGO_CONGE_C
        uce_tipoconge.DataSource = cabeceraBL.get_Articulos_Cogelacion(gInt_IdEmpresa)
        uce_tipoconge.DisplayMember = "AR_DESCRIPCION"
        uce_tipoconge.ValueMember = "AR_ID"
        cabeceraBL = Nothing

    End Sub

    Private Sub Ayuda_Anexo_Cab()
        FA_PR_ListaClientesAyuda.Int_Opcion = 1
        FA_PR_ListaClientesAyuda.ShowDialog()

        Dim matriz As List(Of String) = FA_PR_ListaClientesAyuda.GetLista

        'txt_ruc_cliente.ButtonsRight("editar").Enabled = False

        If matriz.Count > 0 Then
            txt_IdCliente.Text = matriz(0)
            txt_ruc_cliente.Text = matriz(1)
            txt_Des_Cliente.Text = matriz(2)
            ' txt_ruc_cliente.ButtonsRight("editar").Enabled = True
        End If

    End Sub

    Private Sub txt_ruc_cliente_EditorButtonClick(sender As System.Object, e As Infragistics.Win.UltraWinEditors.EditorButtonEventArgs) Handles txt_ruc_cliente.EditorButtonClick
        Call Ayuda_Anexo_Cab()
    End Sub

    Private Sub Tool_Nuevo_Click(sender As System.Object, e As System.EventArgs) Handles Tool_Nuevo.Click
        bol_nuevo = True
        Call Limpiar_Controls_InGroupox(ugb_datos)
        Call Limpiar_Controls_InGroupox(ugb_detalle)
        Call MostrarTabs(1, utc_congela, 1)
        Call MostrarTabs(0, utc_Detalle, 0)
        Call Cambiar_Estado_Botones_Tool(ToolS_Mantenimiento)
        Call Obtener_TipoCambio_dia()
        Call LimpiaGrid(ug_detalle, uds_Detalle)
        uce_Moneda.SelectedIndex = 0


        txt_ruc_cliente.Focus()

    End Sub

    Private Sub Tool_Grabar_Click(sender As System.Object, e As System.EventArgs) Handles Tool_Grabar.Click


        If txt_ruc_cliente.Text.Trim = String.Empty Then
            Avisar("Ingrese el cliente")
            txt_ruc_cliente.Focus()
            Exit Sub
        End If


        If uce_tipoconge.SelectedIndex = -1 Then
            Avisar("Seleccione el tipo de congelacion")
            uce_tipoconge.Focus()
            Exit Sub
        End If

        If uce_Medico.SelectedIndex = -1 Then
            Avisar("Seleccione el medico")
            uce_Medico.Focus()
            Exit Sub
        End If

        If uce_Moneda.SelectedIndex = -1 Then
            Avisar("Seleccione la moneda")
            uce_Moneda.Focus()
            Exit Sub
        End If

        If ume_total.Value = 0 Then
            Avisar("El importe no puede ser cero")
            ume_total.Focus()
            Exit Sub
        End If


        Dim cabeceraBE As New BE.FacturacionBE.SG_FA_TB_PAGO_CONGE_C
        Dim cabeceraBL As New BL.FacturacionBL.SG_FA_TB_PAGO_CONGE_C

        With cabeceraBE
            .PG_ID = IIf(bol_nuevo, 0, txt_idconge.Text.Trim)
            .PG_FEC_CONGE = udte_fec_conge.Value
            .PG_IDCOMPROBANTE = IIf(txt_idcompro.Text.Trim = "", 0, txt_idcompro.Text.Trim)
            .PG_IDCLIENTE = txt_IdCliente.Text.Trim
            .PG_IDCONGELACION = uce_tipoconge.Value
            .PG_IDMEDICO = uce_Medico.Value
            .PG_COMENTARIOS = txt_notas.Text.Trim
            .PG_IMPORTE = ume_total.Value
            .PG_ESTADO = 1
            .PG_USUARIO = gStr_Usuario_Sis
            .PG_TERMINAL = Environment.MachineName
            .PG_FECREG = Now
            .PG_IDEMPRESA = gInt_IdEmpresa
            .PG_REF = txt_ref.Text.Trim
            .PG_IDMONEDA = uce_Moneda.Value
            .PG_TIPCAM = ume_ValorTipoCambio.Value
        End With


        Dim ls_det As New List(Of BE.FacturacionBE.SG_FA_TB_PAGO_CONGE_D)
        Dim detalleBE As BE.FacturacionBE.SG_FA_TB_PAGO_CONGE_D

        For i As Integer = 0 To ug_detalle.Rows.Count - 1
            detalleBE = New BE.FacturacionBE.SG_FA_TB_PAGO_CONGE_D
            With detalleBE
                .PD_IDCAB = ug_detalle.Rows(i).Cells("ITEM").Value
                .PD_ANHO = ug_detalle.Rows(i).Cells("PD_ANHO").Value
                .PD_MES = ug_detalle.Rows(i).Cells("PD_MES").Value
                .PD_FECPAGO = ug_detalle.Rows(i).Cells("PD_FECPAGO").Value
                .PD_IMPORTE = ug_detalle.Rows(i).Cells("PD_IMPORTE").Value
                .PD_IDCOMPROBANTE = ug_detalle.Rows(i).Cells("PD_IDCOMPROBANTE").Value
                .PD_EST_CUOTA = ug_detalle.Rows(i).Cells("PD_EST_CUOTA").Value
                .PD_COMENTARIOS = ug_detalle.Rows(i).Cells("PD_COMENTARIOS").Value
                .PD_IDMONEDA = ug_detalle.Rows(i).Cells("PD_IDMONEDA").Value
                .PD_TIPCAM = ug_detalle.Rows(i).Cells("PD_TIPCAM").Value
                .PD_REF = ug_detalle.Rows(i).Cells("PD_REF").Value
            End With
            ls_det.Add(detalleBE)
        Next


        If bol_nuevo Then
            cabeceraBL.Insert(cabeceraBE, ls_det)
        Else
            cabeceraBL.Update(cabeceraBE, ls_det)
        End If


        Call Avisar("Listo!")
        Call Cargar_Datos()
        Call Tool_Cancelar_Click(sender, e)

    End Sub

    Private Sub Tool_Editar_Click(sender As System.Object, e As System.EventArgs) Handles Tool_Editar.Click

        If ug_Lista.Rows.Count = 0 Then Exit Sub
        If ug_Lista.ActiveRow Is Nothing Then Exit Sub

        bol_nuevo = False
        Dim cabeceraBL As New BL.FacturacionBL.SG_FA_TB_PAGO_CONGE_C
        Dim ds_tmp As DataSet = cabeceraBL.get_Congelaciones_xID(ug_Lista.ActiveRow.Cells("PG_ID").Value)
        cabeceraBL = Nothing

        With ds_tmp.Tables(0).Rows(0)
            txt_idconge.Text = .Item("PG_ID")
            udte_fec_conge.Value = .Item("PG_FEC_CONGE")
            txt_idcompro.Text = .Item("PG_IDCOMPROBANTE")
            txt_IdCliente.Text = .Item("PG_IDCLIENTE")
            uce_tipoconge.Value = .Item("PG_IDCONGELACION")
            uce_Medico.Value = .Item("PG_IDMEDICO")
            txt_notas.Text = .Item("PG_COMENTARIOS")
            ume_total.Value = .Item("PG_IMPORTE")
            txt_ref.Text = .Item("PG_REF")
            uce_Moneda.Value = .Item("PG_IDMONEDA")
            ume_ValorTipoCambio.Value = .Item("PG_TIPCAM")
            txt_ruc_cliente.Text = .Item("CL_NDOC")
            txt_Des_Cliente.Text = .Item("CL_NOMBRE")
        End With

        Call LimpiaGrid(ug_detalle, uds_Detalle)

        For i As Integer = 0 To ds_tmp.Tables(1).Rows.Count - 1
            ug_detalle.DisplayLayout.Bands(0).AddNew()

            ug_detalle.Rows(i).Cells("ITEM").Value = i + 1
            ug_detalle.Rows(i).Cells("PD_ANHO").Value = ds_tmp.Tables(1).Rows(i)("PD_ANHO")
            ug_detalle.Rows(i).Cells("PD_MES").Value = ds_tmp.Tables(1).Rows(i)("PD_MES")
            ug_detalle.Rows(i).Cells("PD_MES_DES").Value = get_Nombre_Mes(ds_tmp.Tables(1).Rows(i)("PD_MES"))

            ug_detalle.Rows(i).Cells("PD_FECPAGO").Value = ds_tmp.Tables(1).Rows(i)("PD_FECPAGO")
            ug_detalle.Rows(i).Cells("PD_IMPORTE").Value = ds_tmp.Tables(1).Rows(i)("PD_IMPORTE")
            ug_detalle.Rows(i).Cells("PD_IDCOMPROBANTE").Value = ds_tmp.Tables(1).Rows(i)("PD_IDCOMPROBANTE")
            ug_detalle.Rows(i).Cells("PD_EST_CUOTA").Value = ds_tmp.Tables(1).Rows(i)("PD_EST_CUOTA")
            ug_detalle.Rows(i).Cells("PD_COMENTARIOS").Value = ds_tmp.Tables(1).Rows(i)("PD_COMENTARIOS")
            ug_detalle.Rows(i).Cells("PD_IDMONEDA").Value = ds_tmp.Tables(1).Rows(i)("PD_IDMONEDA")
            ug_detalle.Rows(i).Cells("PD_IDMONEDA_DES").Value = ds_tmp.Tables(1).Rows(i)("MO_ABREVIATURA")

            ug_detalle.Rows(i).Cells("PD_TIPCAM").Value = ds_tmp.Tables(1).Rows(i)("PD_TIPCAM")
            ug_detalle.Rows(i).Cells("PD_REF").Value = ds_tmp.Tables(1).Rows(i)("PD_REF")

            ug_detalle.UpdateData()
        Next

        ds_tmp = Nothing

        Call Cambiar_Estado_Botones_Tool(ToolS_Mantenimiento)
        Call MostrarTabs(1, utc_congela, 1)

    End Sub

    Private Sub Tool_Cancelar_Click(sender As System.Object, e As System.EventArgs) Handles Tool_Cancelar.Click
        Call MostrarTabs(0, utc_congela)
        Call Cambiar_Estado_Botones_Tool(ToolS_Mantenimiento)
    End Sub

    Private Sub Tool_Eliminar_Click(sender As System.Object, e As System.EventArgs) Handles Tool_Eliminar.Click

    End Sub

    Private Sub Tool_Salir_Click(sender As System.Object, e As System.EventArgs) Handles Tool_Salir.Click
        Me.Close()
    End Sub

    Private Sub btn_Aceptar_Click(sender As System.Object, e As System.EventArgs) Handles btn_Aceptar.Click

        ug_detalle.DisplayLayout.Bands(0).AddNew()
        With ug_detalle.Rows(ug_detalle.Rows.Count - 1)
            .Cells("ITEM").Value = ug_detalle.Rows.Count
            .Cells("PD_IDCAB").Value = 0
            .Cells("PD_ANHO").Value = uce_ayo.Value
            .Cells("PD_MES").Value = uce_mes.Value
            .Cells("PD_MES_DES").Value = uce_mes.Text
            .Cells("PD_FECPAGO").Value = udte_fec_pago.Value
            .Cells("PD_IMPORTE").Value = ume_importe_det.Value
            .Cells("PD_IDCOMPROBANTE").Value = 0
            .Cells("PD_EST_CUOTA").Value = uce_estado_det.Value
            .Cells("PD_COMENTARIOS").Value = txt_comen_det.Text.Trim
            .Cells("PD_IDMONEDA").Value = uce_moneda_det.Value
            .Cells("PD_IDMONEDA_DES").Value = uce_moneda_det.Text
            .Cells("PD_TIPCAM").Value = ume_tc_det.Value
            .Cells("PD_REF").Value = txt_ref_det.Text.Trim
        End With
        ug_detalle.UpdateData()

        btn_quitar.Enabled = True
        Call MostrarTabs(0, utc_Detalle)

    End Sub

    Private Sub btn_nuevo_det_Click(sender As System.Object, e As System.EventArgs) Handles btn_nuevo_det.Click

        Call MostrarTabs(1, utc_Detalle, 1)
        Call Obtener_TipoCambio_dia()

        btn_quitar.Enabled = False
        uce_ayo.Value = gDat_Fecha_Sis.Year
        uce_mes.Value = gDat_Fecha_Sis.Month
        ume_importe_det.Value = "0.00"
        uce_moneda_det.SelectedIndex = 0
        uce_estado_det.SelectedIndex = 0
        txt_ref_det.Text = String.Empty
        txt_comen_det.Text = String.Empty
        udte_fec_pago.Value = gDat_Fecha_Sis
        uce_ayo.Focus()
    End Sub

    Private Sub btn_quitar_Click(sender As System.Object, e As System.EventArgs) Handles btn_quitar.Click

        If ug_detalle.Rows.Count = 0 Then Exit Sub
        If ug_detalle.ActiveRow Is Nothing Then Exit Sub

        ug_detalle.ActiveRow.Delete(False)
        Call Reiniciar_Secuencia()
    End Sub

    Private Sub uce_ayo_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles uce_ayo.KeyDown
        If e.KeyCode = Keys.Enter Then SendKeys.Send(vbTab)
    End Sub

    Private Sub uce_mes_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles uce_mes.KeyDown
        If e.KeyCode = Keys.Enter Then SendKeys.Send(vbTab)
    End Sub

    Private Sub ume_importe_det_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles ume_importe_det.KeyDown
        If e.KeyCode = Keys.Enter Then SendKeys.Send(vbTab)
    End Sub

    Private Sub uce_moneda_det_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles uce_moneda_det.KeyDown
        If e.KeyCode = Keys.Enter Then SendKeys.Send(vbTab)
    End Sub

    Private Sub ume_tc_det_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles ume_tc_det.KeyDown
        If e.KeyCode = Keys.Enter Then SendKeys.Send(vbTab)
    End Sub

    Private Sub txt_ref_det_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles txt_ref_det.KeyDown
        If e.KeyCode = Keys.Enter Then SendKeys.Send(vbTab)
    End Sub

    Private Sub txt_comen_det_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles txt_comen_det.KeyDown
        If e.KeyCode = Keys.Enter Then SendKeys.Send(vbTab)
    End Sub

    Private Sub uce_estado_det_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles uce_estado_det.KeyDown
        If e.KeyCode = Keys.Enter Then SendKeys.Send(vbTab)
    End Sub

    Private Sub udte_fec_pago_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles udte_fec_pago.KeyDown
        If e.KeyCode = Keys.Enter Then SendKeys.Send(vbTab)
    End Sub

    Private Sub btn_cancelar_Click(sender As System.Object, e As System.EventArgs) Handles btn_cancelar.Click
        btn_quitar.Enabled = True
        Call MostrarTabs(0, utc_Detalle)
    End Sub

    Private Sub txt_idconge_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles txt_idconge.KeyDown
        If e.KeyCode = Keys.Enter Then SendKeys.Send(vbTab)
    End Sub

    Private Sub udte_fec_conge_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles udte_fec_conge.KeyDown
        If e.KeyCode = Keys.Enter Then SendKeys.Send(vbTab)
    End Sub

    Private Sub txt_ruc_cliente_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles txt_ruc_cliente.KeyDown
        If e.KeyCode = Keys.Enter Then SendKeys.Send(vbTab)
    End Sub

    Private Sub uce_tipoconge_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles uce_tipoconge.KeyDown
        If e.KeyCode = Keys.Enter Then SendKeys.Send(vbTab)
    End Sub

    Private Sub txt_notas_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles txt_notas.KeyDown
        If e.KeyCode = Keys.Enter Then SendKeys.Send(vbTab)
    End Sub

    Private Sub txt_ref_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles txt_ref.KeyDown
        If e.KeyCode = Keys.Enter Then SendKeys.Send(vbTab)
    End Sub

    Private Sub uce_Medico_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles uce_Medico.KeyDown
        If e.KeyCode = Keys.Enter Then SendKeys.Send(vbTab)
    End Sub

    Private Sub uce_Moneda_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles uce_Moneda.KeyDown
        If e.KeyCode = Keys.Enter Then SendKeys.Send(vbTab)
    End Sub

    Private Sub ume_ValorTipoCambio_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles ume_ValorTipoCambio.KeyDown
        If e.KeyCode = Keys.Enter Then SendKeys.Send(vbTab)
    End Sub

    Private Sub ume_total_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles ume_total.KeyDown
        If e.KeyCode = Keys.Enter Then SendKeys.Send(vbTab)
    End Sub
End Class