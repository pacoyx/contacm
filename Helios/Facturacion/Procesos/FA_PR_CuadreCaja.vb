Imports Infragistics.Win.UltraWinGrid
Public Class FA_PR_CuadreCaja

    Dim es_super As Boolean = False

    Private Sub FA_PR_Mante_Compro_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Call Validar_Super_ft()
        ubtn_aceptar.Appearance.Image = My.Resources._003

        Cargar_Comprobantes()
    End Sub

    Private Sub Validar_Super_ft()
        Dim usuarioBL As New BL.ContabilidadBL.SG_CO_TB_USUARIO
        es_super = usuarioBL.es_super_ft(gStr_Usuario_Sis)
        usuarioBL = Nothing
        If gStr_Usuario_Sis = "admin" Then
            es_super = True
        End If
    End Sub

    Private Sub Cargar_Comprobantes()
        Dim comprobantesBL As New BL.FacturacionBL.SG_FA_TB_COMPROBANTE_C
        Dim comprobantesBE As New BE.FacturacionBE.SG_FA_TB_COMPROBANTE_C

        comprobantesBE.CO_IDEMPRESA = New BE.ContabilidadBE.SG_CO_TB_EMPRESA With {.EM_ID = gInt_IdEmpresa}
        comprobantesBE.CO_IDUSUARIO = New BE.ContabilidadBE.SG_CO_TB_USUARIO With {.US_ID = gInt_IdUsuario_Sis}

        comprobantesBE.CO_FEC_EMI = CDate(udte_desde.Value).ToShortDateString
        If es_super Then
            ug_Listado.DataSource = comprobantesBL.get_Lista_Edi_x_Dia(comprobantesBE)
        Else
            ug_Listado.DataSource = comprobantesBL.get_Lista_Edi_x_Dia_02(comprobantesBE)
        End If

        If ug_Listado.Rows.Count > 0 Then
            Call Cargar_DocumentoPago()
            ume_total_det.Value = 0.0

            Cargar_Detalle1()
            'Call Cargar_Detalle()
            Call Sumar_detalles1()


            'ug_detalle.Rows(0).Cells("Importe").Activate()
            'ug_detalle.Focus()
            'ug_detalle.PerformAction(UltraGridAction.ToggleEditMode, False, False)
            'SendKeys.Send(Keys.F2)
            'SendKeys.Send(Keys.F2)
            'SendKeys.Send(Keys.Escape)

        End If
        comprobantesBE = Nothing
        comprobantesBL = Nothing
    End Sub

    Private Sub Tool_Consultar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_Consultar.Click

        If ug_Listado.Rows.Count = 0 Then Exit Sub
        If ug_Listado.ActiveRow Is Nothing Then Exit Sub
        If ug_Listado.ActiveRow.IsFilterRow Then Exit Sub

        Dim comprobanteBE As New BE.FacturacionBE.SG_FA_TB_COMPROBANTE_C
        comprobanteBE.CO_IDEMPRESA = New BE.ContabilidadBE.SG_CO_TB_EMPRESA With {.EM_ID = gInt_IdEmpresa}
        comprobanteBE.CO_ID = ug_Listado.ActiveRow.Cells("CO_ID").Value

        If gInt_IdEmpresa = 1 Then
            FA_PR_Emi_ComproCaja.MdiParent = CO_MN_MenuInicial
            FA_PR_Emi_ComproCaja.bol_nuevo = False
            FA_PR_Emi_ComproCaja.Show()
            FA_PR_Emi_ComproCaja.Text = FA_PR_Emi_ComproCaja.Text & " ( Consulta )"
            FA_PR_Emi_ComproCaja.Cargar_Comprobante_toEdit(comprobanteBE)
            FA_PR_Emi_ComproCaja.txt_notas.Focus()
        Else
            FA_PR_Emi_Compro.MdiParent = CO_MN_MenuInicial
            FA_PR_Emi_Compro.bol_nuevo = False
            FA_PR_Emi_Compro.Show()
            FA_PR_Emi_Compro.Text = FA_PR_Emi_Compro.Text & " ( Consulta )"
            FA_PR_Emi_Compro.Cargar_Comprobante_toEdit(comprobanteBE)

            FA_PR_Emi_Compro.txt_notas.Focus()
        End If


    End Sub

    Private Sub Tool_Actualizar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_Actualizar.Click
        Call Cargar_Comprobantes()
    End Sub

    Private Sub Tool_Salir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_Salir.Click
        Me.Close()
    End Sub

    Private Sub ug_Listado_ClickCell(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinGrid.ClickCellEventArgs) Handles ug_Listado.ClickCell
        If ug_Listado.Rows.Count = 0 Then Exit Sub
        If ug_Listado.ActiveRow Is Nothing Then Exit Sub
        If ug_Listado.ActiveRow.IsFilterRow Then Exit Sub

        Call Cargar_DocumentoPago()

        ume_total_det.Value = 0.0

        Call Cargar_Detalle()
        Call Sumar_detalles()
    End Sub

    Private Sub ug_Listado_InitializeRow(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinGrid.InitializeRowEventArgs) Handles ug_Listado.InitializeRow
        If e.Row.Cells("CO_ESTADO").Value = 0 Then
            e.Row.Appearance.ForeColor = Color.Tomato
        End If
    End Sub

    Private Sub udte_desde_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles udte_desde.KeyDown
        If e.KeyCode = Keys.Enter Then
            Call Cargar_Comprobantes()
        End If
    End Sub

    Private Sub Cargar_Detalle()
        'MsgBox(ug_Listado.ActiveRow.Cells("CO_ID").Value.ToString)
        Dim reporteBL As New BL.FacturacionBL.SG_FA_Reportes
        'MsgBox(ug_Listado.ActiveRow.Cells("CO_ID").Value)
        Dim dt_detalle As DataTable = reporteBL.get_Detalle_Pago_x_IdCompro(Val(ug_Listado.ActiveRow.Cells("CO_ID").Value.ToString))

        For Each fdet As DataRow In dt_detalle.Rows
            For i As Integer = 0 To ug_detalle.Rows.Count - 1
                If ug_detalle.Rows(i).Cells("DP_CODIGO").Value.ToString = fdet.Item("CD_IDDOCPAGO").ToString Then
                    ug_detalle.Rows(i).Cells("ImporteS").Value = fdet.Item("CD_IMPORTE")
                    ug_detalle.Rows(i).Cells("ImporteD").Value = fdet.Item("CD_IMPORTED")
                    ug_detalle.UpdateData()
                End If
            Next
        Next

    End Sub
    Private Sub Cargar_Detalle1()

        Dim reporteBL As New BL.FacturacionBL.SG_FA_Reportes
        'MsgBox(ug_Listado.ActiveRow.Cells("CO_ID").Value)
        Dim dt_detalle As DataTable = reporteBL.get_Detalle_Pago_x_IdCompro(ug_Listado.Rows(0).Cells("CO_ID").Value)

        For Each fdet As DataRow In dt_detalle.Rows
            For i As Integer = 0 To ug_detalle.Rows.Count - 1
                If ug_detalle.Rows(i).Cells("DP_CODIGO").Value = fdet.Item("CD_IDDOCPAGO") Then
                    ug_detalle.Rows(i).Cells("ImporteS").Value = fdet.Item("CD_IMPORTE")
                    ug_detalle.Rows(i).Cells("ImporteD").Value = fdet.Item("CD_IMPORTED")
                    ug_detalle.UpdateData()
                End If
            Next
        Next

    End Sub

    Private Sub Cargar_DocumentoPago()

        Dim docPago As New BL.FacturacionBL.SG_FA_TB_DOCU_PAGO
        Dim dt_tmp As DataTable = docPago.get_DocuPagos(gInt_IdEmpresa)
        LimpiaGrid(ug_detalle, uds_detalle)
        For i As Integer = 0 To dt_tmp.Rows.Count - 1
            ug_detalle.DisplayLayout.Bands(0).AddNew()
            ug_detalle.Rows(i).Cells("DP_CODIGO").Value = dt_tmp.Rows(i)("DP_CODIGO")
            ug_detalle.Rows(i).Cells("DP_DESCRIPCION").Value = dt_tmp.Rows(i)("DP_DESCRIPCION")
            ug_detalle.Rows(i).Cells("ImporteS").Value = 0
            ug_detalle.Rows(i).Cells("ImporteD").Value = 0
        Next

        ug_detalle.UpdateData()

    End Sub

    Private Sub Sumar_detalles()
        Dim total As Double = 0

        ug_detalle.UpdateData()

        For i As Integer = 0 To ug_detalle.Rows.Count - 1
            If ug_detalle.Rows(i).Cells("ImporteS").Value.ToString <> "" Then
                total += ug_detalle.Rows(i).Cells("ImporteS").Value
            End If
            ' ug_Listado.ActiveRow.Cells("CO_ID").Value
            If ug_detalle.Rows(i).Cells("ImporteD").Value.ToString <> "" Then
                total += Math.Round(ug_detalle.Rows(i).Cells("ImporteD").Value * ug_Listado.ActiveRow.Cells("CO_TCAM").Value, 2)
            End If
        Next
        ume_total_det.Value = total

    End Sub
    Private Sub Sumar_detalles1()
        Dim total As Double = 0

        ug_detalle.UpdateData()

        For i As Integer = 0 To ug_detalle.Rows.Count - 1
            If ug_detalle.Rows(i).Cells("ImporteS").Value.ToString <> "" Then
                total += ug_detalle.Rows(i).Cells("ImporteS").Value
            End If
            ' ug_Listado.ActiveRow.Cells("CO_ID").Value
            If ug_detalle.Rows(i).Cells("ImporteD").Value.ToString <> "" Then
                total += Math.Round(ug_detalle.Rows(i).Cells("ImporteD").Value * ug_Listado.Rows(0).Cells("CO_TCAM").Value, 2)
            End If
        Next
        ume_total_det.Value = total

    End Sub

    'Private Sub ug_detalle_AfterRowUpdate(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinGrid.RowEventArgs) Handles ug_detalle.AfterRowUpdate
    '    Call Sumar_detalles()
    '    With ug_detalle
    '        .PerformAction(UltraGridAction.NextCellByTab, False, False)
    '        .PerformAction(UltraGridAction.NextCellByTab, False, False)
    '    End With
    '    If ug_detalle.ActiveRow.Index = ug_detalle.Rows.Count - 1 Then
    '        ubtn_aceptar.Focus()
    '    End If
    'End Sub

    Private Sub ug_detalle_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles ug_detalle.KeyDown

        If e.KeyCode = Keys.Enter Then
            Call Sumar_detalles()
            With ug_detalle
                .PerformAction(UltraGridAction.NextCellByTab, False, False)
                .PerformAction(UltraGridAction.NextCellByTab, False, False)
            End With
            If ug_detalle.ActiveRow.Index = ug_detalle.Rows.Count - 1 Then
                ubtn_aceptar.Focus()
            End If
        End If


        If e.KeyCode = Keys.Delete Then
            ug_detalle.ActiveRow.Cells("Importe").Value = 0.0
        End If

    End Sub

    Private Sub ubtn_aceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ubtn_aceptar.Click
        Call Sumar_detalles()
        If ug_Listado.ActiveRow.Cells("CO_TOTAL").Value <> ume_total_det.Text Then
            Avisar("El monto detallado debe ser igual al monto del comprobante")
            Exit Sub
        End If

        Dim detalleBE As BE.FacturacionBE.SG_FA_TB_COMPRO_DOCPAGO
        Dim detalleBL As New BL.FacturacionBL.SG_FA_TB_COMPRO_DOCPAGO
        Dim ls_lista As New List(Of BE.FacturacionBE.SG_FA_TB_COMPRO_DOCPAGO)

        For i As Integer = 0 To ug_detalle.Rows.Count - 1
            If ug_detalle.Rows(i).Cells("ImporteS").Value > 0 Or ug_detalle.Rows(i).Cells("ImporteD").Value > 0 Then
                detalleBE = New BE.FacturacionBE.SG_FA_TB_COMPRO_DOCPAGO
                With detalleBE
                    .CD_IDCOMPROBANTE = ug_Listado.ActiveRow.Cells("CO_ID").Value
                    .CD_IDDOCPAGO = ug_detalle.Rows(i).Cells("DP_CODIGO").Value.ToString
                    .CD_IMPORTE = ug_detalle.Rows(i).Cells("ImporteS").Value
                    .CD_IMPORTED = ug_detalle.Rows(i).Cells("ImporteD").Value
                    .CD_USUARIO = String.Format("{0}-{1}", Environment.UserName, gStr_Usuario_Sis)
                    .CD_PC = Environment.MachineName
                    .CD_FECREG = Date.Now
                End With
                ls_lista.Add(detalleBE)
            End If
        Next


        detalleBL.Insert(ls_lista)

        Call Avisar("Listo")
        'Me.Close()

    End Sub
End Class