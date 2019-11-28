Public Class FA_RE_PlanillaCaja

    Dim dt_reporte As New DataTable
    Dim es_super As Boolean = False
    Dim tipoCambio As Decimal
    Private Sub pKeyPressNumero(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_Año.KeyPress
        e.KeyChar = fKeyPress(e.KeyChar, sender.Text, 1)
        e.Handled = (e.KeyChar = "")
    End Sub
    Private Sub FA_RE_PlanillaCaja_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Call Crear_Tabla_Reporte()
        Call Validar_Super_ft()

        txt_Año.Text = Now.Year
        Call CargarCombo_ConMeses(uce_Mes)
        uce_Mes.Value = Now.Month

    End Sub
    Private Sub Validar_Super_ft()
        Dim usuarioBL As New BL.ContabilidadBL.SG_CO_TB_USUARIO
        es_super = usuarioBL.es_super_ft(gStr_Usuario_Sis)
        usuarioBL = Nothing
        If gStr_Usuario_Sis = "admin" Then
            es_super = True
        End If
    End Sub

    Private Sub Crear_Tabla_Reporte()
        dt_reporte.Columns.Clear()
        dt_reporte.Columns.Add("TD", Type.GetType("System.String"))
        dt_reporte.Columns.Add("SD", Type.GetType("System.String"))
        dt_reporte.Columns.Add("ND", Type.GetType("System.String"))
        dt_reporte.Columns.Add("EFECTIVO", Type.GetType("System.Double"))
        dt_reporte.Columns.Add("VISANET", Type.GetType("System.Double"))
        dt_reporte.Columns.Add("MASTERCARD", Type.GetType("System.Double"))
        dt_reporte.Columns.Add("AMEX", Type.GetType("System.Double"))
        dt_reporte.Columns.Add("DINNER", Type.GetType("System.Double"))
        dt_reporte.Columns.Add("REMESAS", Type.GetType("System.Double"))
        dt_reporte.Columns.Add("TOTAL", Type.GetType("System.Double"))
    End Sub

    Private Sub Procesar_Reporte()
        If ug_Lista.Rows.Count = 0 Then Exit Sub
        If ug_Lista.ActiveRow Is Nothing Then Exit Sub
        If ug_Lista.ActiveRow.IsFilterRow Then Exit Sub

        Dim reportBL As New BL.FacturacionBL.SG_FA_Reportes
        Dim dt_tmp As DataTable = Nothing
        Dim dt_detalle As DataTable = Nothing
        Dim nuevaf As DataRow

        'If es_super Then
        '    dt_tmp = reportBL.get_Planilla_Caja_super(CDate(ug_Lista.ActiveRow.Cells(3).Value).ToShortDateString, ug_Lista.ActiveRow.Cells(4).Value, gInt_IdEmpresa)
        'Else
        dt_tmp = reportBL.get_Planilla_Caja(ug_Lista.ActiveRow.Cells(1).Value, CDate(ug_Lista.ActiveRow.Cells(3).Value).ToShortDateString, ug_Lista.ActiveRow.Cells(4).Value, gInt_IdEmpresa)
        'End If

        Try
            Me.Cursor = Cursors.WaitCursor
            dt_reporte.Rows.Clear()

            For Each fila As DataRow In dt_tmp.Rows
                nuevaf = dt_reporte.NewRow()
                With nuevaf
                    .Item("TD") = fila.Item("TDOC").ToString
                    .Item("SD") = fila.Item("SDOC").ToString
                    .Item("ND") = fila.Item("NDOC").ToString
                    .Item("EFECTIVO") = 0
                    .Item("VISANET") = 0
                    .Item("MASTERCARD") = 0
                    .Item("AMEX") = 0
                    .Item("DINNER") = 0
                    .Item("REMESAS") = 0
                    .Item("TOTAL") = 0
                    dt_detalle = reportBL.get_Detalle_Pago_x_IdCompro(fila.Item("CO_ID"))

                    If dt_detalle.Rows.Count > 0 Then
                        Dim total As Double = 0

                        For Each fdet As DataRow In dt_detalle.Rows
                            If fdet.Item("CD_IDDOCPAGO").ToString = "001" Then .Item("EFECTIVO") = fdet.Item("CD_IMPORTE") : total += fdet.Item("CD_IMPORTE")
                            If fdet.Item("CD_IDDOCPAGO").ToString = "002" Then .Item("VISANET") = fdet.Item("CD_IMPORTE") : total += fdet.Item("CD_IMPORTE")
                            If fdet.Item("CD_IDDOCPAGO").ToString = "003" Then .Item("MASTERCARD") = fdet.Item("CD_IMPORTE") : total += fdet.Item("CD_IMPORTE")
                            If fdet.Item("CD_IDDOCPAGO").ToString = "004" Then .Item("AMEX") = fdet.Item("CD_IMPORTE") : total += fdet.Item("CD_IMPORTE")
                            If fdet.Item("CD_IDDOCPAGO").ToString = "005" Then .Item("DINNER") = fdet.Item("CD_IMPORTE") : total += fdet.Item("CD_IMPORTE")
                            If fdet.Item("CD_IDDOCPAGO").ToString = "006" Then .Item("REMESAS") = fdet.Item("CD_IMPORTE") : total += fdet.Item("CD_IMPORTE")
                        Next
                        .Item("TOTAL") = total
                    Else
                        If fila.Item("CO_IDDOCU_PAGO").ToString = "001" Then .Item("EFECTIVO") = fila.Item("TOTAL")
                        If fila.Item("CO_IDDOCU_PAGO").ToString = "002" Then .Item("VISANET") = fila.Item("TOTAL")
                        If fila.Item("CO_IDDOCU_PAGO").ToString = "003" Then .Item("MASTERCARD") = fila.Item("TOTAL")
                        If fila.Item("CO_IDDOCU_PAGO").ToString = "004" Then .Item("AMEX") = fila.Item("TOTAL")
                        If fila.Item("CO_IDDOCU_PAGO").ToString = "005" Then .Item("DINNER") = fila.Item("TOTAL")
                        If fila.Item("CO_IDDOCU_PAGO").ToString = "006" Then .Item("REMESAS") = fila.Item("TOTAL")
                        .Item("TOTAL") = fila.Item("TOTAL")
                    End If

                End With
                dt_reporte.Rows.Add(nuevaf)
            Next

            dt_tmp.Dispose()
            reportBL = Nothing


            Dim crystalBL As New LR.ClsReporte
            crystalBL.Muestra_Reporte(gStr_RutaRep & "\SG_FA_09.RPT", dt_reporte, "", "pEmpresa;" & gStr_NomEmpresa, "pCajero;" & ug_Lista.ActiveRow.Cells(2).Value, "pTurno;" & ug_Lista.ActiveRow.Cells(5).Value, "pFecha;" & CDate(ug_Lista.ActiveRow.Cells(3).Value).ToShortDateString)
            crystalBL = Nothing

            Me.Cursor = Cursors.Default

        Catch ex As Exception
            Me.Cursor = Cursors.Default
        End Try



    End Sub
    Private Sub Obtener_TipoCambio_dia()
        ug_Lista.UpdateData()
        If ug_Lista.Rows.Count = 0 Then Exit Sub
        If ug_Lista.ActiveRow Is Nothing Then Exit Sub
        If ug_Lista.ActiveRow.IsFilterRow Then Exit Sub

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
            tipocambioBE.PA_FECHA = CDate(ug_Lista.ActiveRow.Cells(3).Value).ToShortDateString
            Dim dt_tc As DataTable = tipocambioBL.get_Pariedad_x_UltimoXFecha(tipocambioBE)

            If dt_tc.Rows.Count > 0 Then
                tipoCambio = dt_tc.Rows(0)("PA_VENTA")
            Else
                tipoCambio = 0
            End If

            dt_tc = Nothing

            tipocambioBE = Nothing
            tipocambioBL = Nothing

        Else ' rpta = "C"

            Dim tipocamBL As New BL.ContabilidadBL.SG_CO_TB_TIPOCAMBIO
            Dim tipocamBE As New BE.ContabilidadBE.SG_CO_TB_TIPOCAMBIO

            tipocamBE.TC_IDEMPRESA = New BE.ContabilidadBE.SG_CO_TB_EMPRESA With {.EM_ID = 1}
            tipocamBE.TC_FECHA = CDate(ug_Lista.ActiveRow.Cells(3).Value).ToShortDateString
            tipocamBE.TC_IDMONEDA = New BE.ContabilidadBE.SG_CO_TB_MONEDA With {.MO_CODIGO = 2}
            tipocamBL.getTipoCambio(tipocamBE)

            tipoCambio = tipocamBE.TC_VENTA

            tipocamBE = Nothing
            tipocamBL = Nothing

        End If


    End Sub
    Private Sub Procesar_ReporteM()
        If ug_Lista.Rows.Count = 0 Then Exit Sub
        If ug_Lista.ActiveRow Is Nothing Then Exit Sub
        If ug_Lista.ActiveRow.IsFilterRow Then Exit Sub

        Dim reportBL As New BL.FacturacionBL.SG_FA_Reportes

        '   Dim dt_detalle As DataTable = Nothing
        Dim dt_comprobante As DataTable = Nothing
        'If es_super Then
        '    dt_comprobante = reportBL.get_Planilla_Caja_superM(CDate(ug_Lista.ActiveRow.Cells(3).Value).ToShortDateString, uce_turno.Value, gInt_IdEmpresa)
        'Else
        dt_comprobante = reportBL.get_Planilla_CajaM(ug_Lista.ActiveRow.Cells(1).Value, ug_Lista.ActiveRow.Cells(0).Value, ug_Lista.ActiveRow.Cells(4).Value, gInt_IdEmpresa)
        'End If
        Dim cajaBL As New BL.FacturacionBL.SG_FA_TB_CAJA_CAB
        Dim dt_data As DataTable = cajaBL.get_Data_Caja2(ug_Lista.ActiveRow.Cells(1).Value, CDate(ug_Lista.ActiveRow.Cells(3).Value).ToShortDateString, gInt_IdEmpresa, ug_Lista.ActiveRow.Cells(4).Value)
        Dim DOLARES As Decimal
        cajaBL = Nothing
        If dt_data.Rows.Count > 0 Then
            DOLARES = dt_data.Rows(0)(0)
        End If
        dt_data.Dispose()

        Try
            Me.Cursor = Cursors.WaitCursor

            If dt_comprobante.Rows.Count > 0 Then
                Dim crystalBL As New LR.ClsReporte
                crystalBL.Muestra_Reporte(gStr_RutaRep & "\SG_FA_10.RPT", dt_comprobante, "", "pTCambio;" & Math.Round(tipoCambio, 2), "pCajero;" & ug_Lista.ActiveRow.Cells(2).Value, "pTurno;" & ug_Lista.ActiveRow.Cells(5).Value.ToString, "pDolares;" & DOLARES, "pFecha;" & CDate(ug_Lista.ActiveRow.Cells(3).Value).ToShortDateString, "pEmpresa;" & gStr_NomEmpresa)
                crystalBL = Nothing

            End If

            Me.Cursor = Cursors.Default

        Catch ex As Exception
            Throw ex
            Me.Cursor = Cursors.Default
        End Try


    End Sub

    Private Sub Procesar_ReporteB()
        If ug_Lista.Rows.Count = 0 Then Exit Sub
        If ug_Lista.ActiveRow Is Nothing Then Exit Sub
        If ug_Lista.ActiveRow.IsFilterRow Then Exit Sub

        Dim reportBL As New BL.FacturacionBL.SG_FA_Reportes

        '   Dim dt_detalle As DataTable = Nothing
        Dim dt_comprobante As DataTable = Nothing
        'If es_super Then
        '    dt_comprobante = reportBL.get_Planilla_Caja_superM(CDate(ug_Lista.ActiveRow.Cells(3).Value).ToShortDateString, uce_turno.Value, gInt_IdEmpresa)
        'Else
        dt_comprobante = reportBL.get_Planilla_CajaB(ug_Lista.ActiveRow.Cells(1).Value, ug_Lista.ActiveRow.Cells(0).Value, ug_Lista.ActiveRow.Cells(4).Value, gInt_IdEmpresa)
        'End If
        Dim cajaBL As New BL.FacturacionBL.SG_FA_TB_CAJA_CAB
        Dim dt_data As DataTable = cajaBL.get_Data_Caja2(ug_Lista.ActiveRow.Cells(1).Value, CDate(ug_Lista.ActiveRow.Cells(3).Value).ToShortDateString, gInt_IdEmpresa, ug_Lista.ActiveRow.Cells(4).Value)
        Dim DOLARES As Decimal
        cajaBL = Nothing
        If dt_data.Rows.Count > 0 Then
            DOLARES = dt_data.Rows(0)(0)
        End If
        dt_data.Dispose()

        Try
            Me.Cursor = Cursors.WaitCursor

            If dt_comprobante.Rows.Count > 0 Then
                Dim crystalBL As New LR.ClsReporte
                crystalBL.Muestra_Reporte(gStr_RutaRep & "\SG_FA_14.RPT", dt_comprobante, "", "pTCambio;" & Math.Round(tipoCambio, 2), "pCajero;" & ug_Lista.ActiveRow.Cells(2).Value, "pTurno;" & ug_Lista.ActiveRow.Cells(5).Value.ToString, "pDolares;" & DOLARES, "pFecha;" & CDate(ug_Lista.ActiveRow.Cells(3).Value).ToShortDateString, "pEmpresa;" & gStr_NomEmpresa)
                crystalBL = Nothing

            End If

            Me.Cursor = Cursors.Default

        Catch ex As Exception
            Throw ex
            Me.Cursor = Cursors.Default
        End Try
    End Sub

    Private Sub Tool_imprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_imprimir.Click

        If txt_Año.Text = "" Then
            Call Avisar("Ingrese un año valido")
            Exit Sub
        End If

        If uce_Mes.SelectedIndex = -1 Then
            Avisar("Seleccione un mes valido")
            Exit Sub
        End If

        Call Obtener_TipoCambio_dia()

        If gInt_IdEmpresa = 1 Then
            Call Procesar_ReporteM()
        ElseIf gInt_IdEmpresa = 7 Then
            Call Procesar_ReporteB()
        Else
            Call Procesar_Reporte()
        End If

    End Sub

    Private Sub Tool_salir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_salir.Click
        Me.Close()
    End Sub

    Private Sub uce_Mes_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles uce_Mes.ValueChanged
        Dim ReportBL As New BL.FacturacionBL.SG_FA_Reportes
        ug_Lista.DataSource = ReportBL.get_CAJA01(uce_Mes.Value, Val(txt_Año.Text), gInt_IdEmpresa)

        If ug_Lista.Rows.Count > 0 Then
            ' Dim ReportBL2 As New BL.FacturacionBL.SG_FA_Reportes
            ug_comprobantes.DataSource = ReportBL.get_CAJA_Deta01(ug_Lista.Rows(0).Cells(1).Value, ug_Lista.Rows(0).Cells(0).Value, ug_Lista.Rows(0).Cells(4).Value, gInt_IdEmpresa)
        Else
            uds_Compro.Rows.Clear()
            ug_comprobantes.DataSource = uds_Compro
        End If
        ReportBL = Nothing

    End Sub

    Private Sub ug_Lista_AfterSelectChange(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinGrid.AfterSelectChangeEventArgs) Handles ug_Lista.AfterSelectChange
        If ug_Lista.Rows.Count = 0 Then Exit Sub
        If ug_Lista.ActiveRow Is Nothing Then Exit Sub
        If ug_Lista.ActiveRow.IsFilterRow Then Exit Sub

        Dim ReportBL As New BL.FacturacionBL.SG_FA_Reportes
        ug_comprobantes.DataSource = ReportBL.get_CAJA_Deta01(ug_Lista.ActiveRow.Cells(1).Value, ug_Lista.ActiveRow.Cells(0).Value, ug_Lista.ActiveRow.Cells(4).Value, gInt_IdEmpresa)
    End Sub
End Class