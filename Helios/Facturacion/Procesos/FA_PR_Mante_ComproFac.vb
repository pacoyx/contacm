Public Class FA_PR_Mante_ComproFac
    Private Sub pKeyPressNumero(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_año.KeyPress
        e.KeyChar = fKeyPress(e.KeyChar, sender.Text, 1)
        e.Handled = (e.KeyChar = "")
    End Sub
    Private Sub FA_PR_Mante_Compro_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Call CargarCombo_ConMeses(uce_Mes)
        uce_tipo.SelectedIndex = 2
        uce_Mes.SelectedIndex = Now.Month - 1
        txt_año.Text = Now.Year
        Cargar_Comprobantes()
    End Sub

    Private Sub Cargar_Comprobantes()
        Dim comprobantesBL As New BL.FacturacionBL.SG_FA_TB_COMPROBANTE_C
        Dim comprobantesBE As New BE.FacturacionBE.SG_FA_TB_COMPROBANTE_C

        comprobantesBE.CO_IDEMPRESA = New BE.ContabilidadBE.SG_CO_TB_EMPRESA With {.EM_ID = gInt_IdEmpresa}
        comprobantesBE.CO_IDUSUARIO = New BE.ContabilidadBE.SG_CO_TB_USUARIO With {.US_ID = gInt_IdUsuario_Sis}
        If gInt_IdEmpresa = 7 Then
            ug_Listado.DataSource = comprobantesBL.get_Lista_Compro(CDate(udte_desde.Value).ToShortDateString, CDate(udte_hasta.Value).ToShortDateString, Val(txt_año.Text), uce_Mes.Value, gInt_IdEmpresa, uce_tipo.Value)
        Else
            Select Case uce_tipo.Value
                Case 1 'diario
                    comprobantesBE.CO_FEC_EMI = CDate(udte_desde.Value).ToShortDateString
                    ug_Listado.DataSource = comprobantesBL.get_Lista_Edi_x_Dia_Fac(comprobantesBE)

                Case 2 'semanal
                    comprobantesBE.CO_FEC_EMI = CDate(udte_desde.Value).ToShortDateString
                    comprobantesBE.CO_FEC_VEN = CDate(udte_hasta.Value).ToShortDateString

                    ug_Listado.DataSource = comprobantesBL.get_Lista_Edi_x_Semana_Fac(comprobantesBE)
                Case 3 'mensual
                    ug_Listado.DataSource = comprobantesBL.get_Lista_Edi_x_Mes_Fac(Val(txt_año.Text), uce_Mes.Value, comprobantesBE.CO_IDEMPRESA)
            End Select
        End If
        

        comprobantesBE = Nothing
        comprobantesBL = Nothing
    End Sub

    Private Sub uce_tipo_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles uce_tipo.ValueChanged

        udte_desde.Visible = True
        udte_hasta.Visible = True
        uce_Mes.Visible = True
        lbl_desde.Visible = True
        lbl_hasta.Visible = True
        lbl_desde.Text = "Desde"
        ulbA.Visible = True
        txt_año.Visible = True
        Select Case uce_tipo.Value
            Case 1 'diario
                udte_hasta.Visible = False
                uce_Mes.Visible = False
                ulbA.Visible = False
                txt_año.Visible = False
                lbl_hasta.Visible = False
            Case 2 'semanal
                uce_Mes.Visible = False
                ulbA.Visible = False
                txt_año.Visible = False

            Case 3 'mensual

                lbl_desde.Text = "Mes"
                lbl_hasta.Visible = False
                udte_desde.Visible = False
                udte_hasta.Visible = False
                
        End Select

        Call Cargar_Comprobantes()

    End Sub

    Private Sub uce_Mes_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles uce_Mes.ValueChanged
        Call Cargar_Comprobantes()
    End Sub

    Private Sub ug_Listado_InitializeRow(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinGrid.InitializeRowEventArgs) Handles ug_Listado.InitializeRow
        If e.Row.Cells("CO_ESTADO").Value = 0 Then
            e.Row.Appearance.ForeColor = Color.Tomato
        End If
    End Sub

    Private Sub udte_desde_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles udte_desde.KeyDown
        If e.KeyCode = Keys.Enter Then
            If uce_tipo.Value = "1" Then 'por dia
                Call Cargar_Comprobantes()
            Else
                udte_hasta.Focus()
            End If
        End If
    End Sub

    Private Sub udte_hasta_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles udte_hasta.KeyDown
        If e.KeyCode = Keys.Enter Then
            Call Cargar_Comprobantes()
        End If
    End Sub

    Private Sub ug_Listado_DoubleClickRow(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.DoubleClickRowEventArgs) Handles ug_Listado.DoubleClickRow

        If ug_Listado.Rows.Count = 0 Then Exit Sub
        If e.Row.IsActiveRow Then Exit Sub
        If e.Row Is Nothing Then Exit Sub

        Call Tool_Consultar_Click(sender, e)

    End Sub

    Private Sub uce_tipo_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles uce_tipo.KeyDown
        If e.KeyCode = Keys.Enter Then
            If uce_tipo.Value = "1" Then 'por dia
                udte_desde.Focus()
            End If
        End If
    End Sub

    Private Sub Tool_Nuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_Nuevo.Click
        If gInt_IdEmpresa = 7 Then
            FA_PR_Emi_ComproBot.MdiParent = CO_MN_MenuInicial
            FA_PR_Emi_ComproBot.Show()
        Else
            FA_PR_Emi_ComproFacSeg.MdiParent = CO_MN_MenuInicial
            FA_PR_Emi_ComproFacSeg.Show()
        End If
        
    End Sub

    Private Sub Tool_Consultar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_Consultar.Click

        If ug_Listado.Rows.Count = 0 Then Exit Sub
        If ug_Listado.ActiveRow Is Nothing Then Exit Sub
        If ug_Listado.ActiveRow.IsFilterRow Then Exit Sub

        Dim comprobanteBE As New BE.FacturacionBE.SG_FA_TB_COMPROBANTE_C
        comprobanteBE.CO_IDEMPRESA = New BE.ContabilidadBE.SG_CO_TB_EMPRESA With {.EM_ID = gInt_IdEmpresa}
        comprobanteBE.CO_ID = ug_Listado.ActiveRow.Cells("CO_ID").Value

        If gInt_IdEmpresa = 7 Then
            FA_PR_Emi_ComproBot.MdiParent = CO_MN_MenuInicial
            FA_PR_Emi_ComproBot.bol_nuevo = False
            FA_PR_Emi_ComproBot.Show()
            FA_PR_Emi_ComproBot.Text = FA_PR_Emi_ComproBot.Text & " ( Consulta )"
            FA_PR_Emi_ComproBot.Cargar_Comprobante_toEdit(comprobanteBE)
            FA_PR_Emi_ComproBot.txt_notas.Focus()
        Else
            If ug_Listado.ActiveRow.Cells("CO_DESTINO").Value = 1 Then
                FA_PR_Emi_ComproFacPac.MdiParent = CO_MN_MenuInicial
                FA_PR_Emi_ComproFacPac.bol_nuevo = False
                FA_PR_Emi_ComproFacPac.Show()
                FA_PR_Emi_ComproFacPac.Text = FA_PR_Emi_ComproFacPac.Text & " ( Consulta )"
                FA_PR_Emi_ComproFacPac.Cargar_Comprobante_toEdit(comprobanteBE)
                FA_PR_Emi_ComproFacPac.txt_notas.Focus()
            Else
                FA_PR_Emi_ComproFacSeg.MdiParent = CO_MN_MenuInicial
                FA_PR_Emi_ComproFacSeg.bol_nuevo = False
                FA_PR_Emi_ComproFacSeg.Show()
                FA_PR_Emi_ComproFacSeg.Text = FA_PR_Emi_ComproFacSeg.Text & " ( Consulta )"
                FA_PR_Emi_ComproFacSeg.Cargar_Comprobante_toEdit(comprobanteBE)

                FA_PR_Emi_ComproFacSeg.txt_notas.Focus()
            End If
        End If
    End Sub

    Private Sub Tool_Anular_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_Anular.Click

        If ug_Listado.Rows.Count = 0 Then Exit Sub
        If ug_Listado.ActiveRow Is Nothing Then Exit Sub
        If ug_Listado.ActiveRow.IsFilterRow Then Exit Sub

        If Preguntar("Esta seguro de Anular el comprobante?") Then

            Dim comprobantesBL As New BL.FacturacionBL.SG_FA_TB_COMPROBANTE_C
            Dim comprobantesBE As New BE.FacturacionBE.SG_FA_TB_COMPROBANTE_C

            comprobantesBE.CO_IDEMPRESA = New BE.ContabilidadBE.SG_CO_TB_EMPRESA With {.EM_ID = gInt_IdEmpresa}
            ug_Listado.UpdateData()
            Dim i As Integer = 0
            For f As Integer = 0 To ug_Listado.Rows.Count - 1
                If ug_Listado.Rows(f).Cells("SEL").Value Then

                    If ug_Listado.Rows(f).Cells("CO_ESTADO").Value = 1 Then
                        Try
                            comprobantesBE.CO_ID = ug_Listado.Rows(f).Cells("CO_ID").Value
                            If gInt_IdEmpresa = 7 Then
                                comprobantesBL.Anular_Bot(comprobantesBE, String.Format("{0}-{1}", Environment.UserName, gStr_Usuario_Sis), Environment.MachineName)
                            Else
                                comprobantesBL.Anular(comprobantesBE)
                            End If

                            'CONSULTAMOS LA TABLA DE PARAMETROS PARA VER SI HAY INTERFACE CON CONTABILIDAD
                            Dim rpta As String = ""
                            Dim paraetrosBL As New BL.FacturacionBL.SG_FA_TB_PARAMETROS
                            Dim paraetrosBE As New BE.FacturacionBE.SG_FA_TB_PARAMETROS
                            paraetrosBE.AD_IDEMPRESA = New BE.ContabilidadBE.SG_CO_TB_EMPRESA With {.EM_ID = gInt_IdEmpresa}
                            paraetrosBE.AD_TIPO = "CONTA"
                            paraetrosBE.AD_NOMBRE = "INTER"

                            rpta = paraetrosBL.get_Valor(paraetrosBE)

                            '1 = Existe interface contabilidad
                            '0 = no hay conta

                            If rpta = "1" Then
                                comprobantesBE.CO_USUARIO = String.Format("{0}-{1}", Environment.UserName, gStr_Usuario_Sis)
                                comprobantesBE.CO_TERMINAL = Environment.MachineName
                                comprobantesBE.CO_IDVOUCHER = ug_Listado.Rows(f).Cells("CO_IDVOUCHER").Value
                                comprobantesBL.Anular_En_Contabilidad(comprobantesBE)
                            End If

                            paraetrosBE = Nothing
                            paraetrosBL = Nothing

                            ug_Listado.Rows(f).Appearance.ForeColor = Color.Tomato
                            ug_Listado.Rows(f).Cells("CO_ESTADO").Value = 0
                            ug_Listado.Rows(f).Cells("ESTADO").Value = "ANULADO"
                            ug_Listado.Rows(f).Cells("SEL").Value = False
                            ug_Listado.UpdateData()
                            i = i + 1
                        Catch ex As Exception
                            Call ShowError(ex.Message)
                        End Try
                    End If

                End If
            Next

            If i > 0 Then
                Avisar("    Listo!  ")
            Else
                Avisar("    Seleccione Correctamente   ")
            End If


            comprobantesBE = Nothing
            comprobantesBL = Nothing
        End If

    End Sub

    Private Sub Tool_Imprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        Me.Cursor = Cursors.WaitCursor

        Dim idComprobante As Integer = ug_Listado.ActiveRow.Cells("CO_ID").Value
        Dim reportesBL As New BL.FacturacionBL.SG_FA_Reportes
        Dim crystalBL As New LR.ClsReporte
        Dim dt_comprobante As DataTable = reportesBL.get_Comprobante(idComprobante, gInt_IdEmpresa)

        Dim nom_reporte As String = "SG_FA_01.RPT"
        Dim nom_param_linea As String = ""
        Dim texto_nota_cre As String = ""
        Dim bol_es_nc As Boolean = False
        Dim moneda As String = ug_Listado.ActiveRow.Cells("CO_IDMONEDA").Value
        Dim total_compro As Double = ug_Listado.ActiveRow.Cells("CO_TOTAL").Value

        Select Case ug_Listado.ActiveRow.Cells("CO_TDOC").Value
            Case "FT" 'factura
                nom_reporte = "SG_FA_01_1F.RPT"
                ' nom_reporte = "SG_FA_01_" & gInt_IdEmpresa.ToString & ".RPT"
                nom_param_linea = "LINFAC"
            Case "BV" 'boleta
                nom_reporte = "SG_FA_06_1F.RPT"
                ' nom_reporte = "SG_FA_06_" & gInt_IdEmpresa.ToString & ".RPT"
                nom_param_linea = "LINBOL"
            Case "NC" 'nota de credito
                nom_reporte = "SG_FA_07_1F.RPT"
                ' nom_reporte = "SG_FA_07_" & gInt_IdEmpresa.ToString & ".RPT"
                nom_param_linea = "LINNCR"
                'texto_nota_cre = "Nota de credito que reemplaza al documento 001-02514"
                bol_es_nc = True
        End Select

        Dim Monto_en_Letras As String = Letras(total_compro).ToUpper

        If moneda = "01" Then
            Monto_en_Letras = Monto_en_Letras & " NUEVOS SOLES"
        Else
            Monto_en_Letras = Monto_en_Letras & " DOLARES AMERICANOS"
        End If

        Call Completar_Lineas(nom_param_linea, dt_comprobante, bol_es_nc, texto_nota_cre)
        If ug_Listado.ActiveRow.Cells("CO_TDOC").Value = "FT" Or ug_Listado.ActiveRow.Cells("CO_TDOC").Value = "BV" Then
            '  crystalBL.Muestra_Reporte(gStr_RutaRep & "\" & nom_reporte, dt_comprobante, "", "pMontoLetras;" & Monto_en_Letras, "pMoneda;" & moneda, "pSubTotal;" & txt_subTotalAseg.Text, "pDeducible;" & txt_Deducible.Text, "pSaldo;" & txt_Saldo.Text, "pCoaseguro;" & txt_COAseguro.Text, "pPor;" & txt_COAseguroPorc.Text, "pFechaI;" & udtpFecha_Ingreso.Text, "pFechaA;" & udtpFechaAlta.Text, "pPaciente;" & txt_Des_Cliente.Text)
        Else
            crystalBL.Muestra_Reporte(gStr_RutaRep & "\" & nom_reporte, dt_comprobante, "", "pMontoLetras;" & Monto_en_Letras, "pMoneda;" & moneda)
        End If



        crystalBL = Nothing
        reportesBL = Nothing

        Me.Cursor = Cursors.Default

    End Sub

    Private Sub Tool_Actualizar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_Actualizar.Click
        Call Cargar_Comprobantes()
    End Sub

    Private Sub Tool_Cancelacion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_Cancelacion.Click
        If ug_Listado.Rows.Count = 0 Then Exit Sub
        If ug_Listado.ActiveRow Is Nothing Then Exit Sub
        If ug_Listado.ActiveRow.IsFilterRow Then Exit Sub

        Dim comprobantesBL As New BL.FacturacionBL.SG_FA_TB_COMPROBANTE_C
        Dim comprobantesBE As New BE.FacturacionBE.SG_FA_TB_COMPROBANTE_C

        comprobantesBL.Delete_codigo(String.Format("{0}-{1}", Environment.UserName, gStr_Usuario_Sis), Environment.MachineName)
        comprobantesBE.CO_IDEMPRESA = New BE.ContabilidadBE.SG_CO_TB_EMPRESA With {.EM_ID = gInt_IdEmpresa}

        ug_Listado.UpdateData()

        Dim i As Integer = 0
        For f As Integer = 0 To ug_Listado.Rows.Count - 1
            If ug_Listado.Rows(f).Cells("SEL").Value Then
                If ug_Listado.Rows(f).Cells("CO_ESTADO_PAGO").Value <> "PENDIENTE" Then
                    Avisar("    Seleccione Correctamente!  ")
                    Exit Sub
                End If
            End If
        Next

        For f As Integer = 0 To ug_Listado.Rows.Count - 1
            If ug_Listado.Rows(f).Cells("SEL").Value Then
                If ug_Listado.Rows(f).Cells("CO_ESTADO_PAGO").Value = "PENDIENTE" Then
                    comprobantesBE.CO_ID = ug_Listado.Rows(f).Cells("CO_ID").Value
                    comprobantesBL.Insert_codigo(comprobantesBE, String.Format("{0}-{1}", Environment.UserName, gStr_Usuario_Sis), Environment.MachineName)
                    i = i + 1
                End If
            End If
        Next
        If i > 0 Then
            comprobantesBL.Generar_Asiento_FacturaCredito(Now.Date, gInt_IdEmpresa, gStr_Usuario_Sis, "", String.Format("{0}-{1}", Environment.UserName, gStr_Usuario_Sis), Environment.MachineName)
            Call Cargar_Comprobantes()
            If Preguntar("Listo!, Desea Imprimir?") Then
                Imprimir()
            End If
            'Avisar("    Listo!  ")
        Else
            Avisar("    Seleccione Correctamente!  ")
        End If
        
        comprobantesBE = Nothing
        comprobantesBL = Nothing
    End Sub

    Private Sub Imprimir()
        Dim obr As New BL.FacturacionBL.SG_FA_TB_COMPROBANTE_C
        Me.Cursor = Cursors.WaitCursor
        'Dim obj As New DataTable
        'obj = 

        Dim nom_reporte As String = "SG_FA_12.RPT"
        Dim crystalBL As New LR.ClsReporte
        Dim dt_data As New DataTable
        dt_data = obr.get_Comprobantes_Cancelados(gInt_IdEmpresa, String.Format("{0}-{1}", Environment.UserName, gStr_Usuario_Sis), Environment.MachineName)

        crystalBL.Muestra_Reporte(gStr_RutaRep & "\" & nom_reporte, dt_data, "", "pUsuario;" & gStr_Usuario_Sis, "pFecha;" & Now.Date)

        crystalBL = Nothing
        ' reportesBL = Nothing

        Me.Cursor = Cursors.Default
    End Sub
    Private Sub Tool_NotaCredito_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_NotaCredito.Click
        If ug_Listado.ActiveRow.Cells("CO_TDOC").Value = "NC" Then
            Avisar("El Comprobante ya es Nota de Credito.")
            Exit Sub
        End If
        If ug_Listado.ActiveRow.Cells("CO_ESTADO").Value = 0 Then Exit Sub

        Dim comprobanteBE As New BE.FacturacionBE.SG_FA_TB_COMPROBANTE_C
        comprobanteBE.CO_IDEMPRESA = New BE.ContabilidadBE.SG_CO_TB_EMPRESA With {.EM_ID = gInt_IdEmpresa}
        comprobanteBE.CO_ID = ug_Listado.ActiveRow.Cells("CO_ID").Value

        If gInt_IdEmpresa = 7 Then
            FA_PR_Emi_ComproBot.MdiParent = CO_MN_MenuInicial
            FA_PR_Emi_ComproBot.bol_nuevo = True
            FA_PR_Emi_ComproBot.Show()
            ' FA_PR_Emi_ComproFacPac.Text = FA_PR_Emi_ComproFacPac.Text & " ( Consulta )"
            FA_PR_Emi_ComproBot.Cargar_Comprobante_toNC(comprobanteBE)
            FA_PR_Emi_ComproBot.txt_notas.Focus()
        Else
            If ug_Listado.ActiveRow.Cells("CO_DESTINO").Value = 1 Then
                FA_PR_Emi_ComproFacPac.MdiParent = CO_MN_MenuInicial
                FA_PR_Emi_ComproFacPac.bol_nuevo = True
                FA_PR_Emi_ComproFacPac.Show()
                ' FA_PR_Emi_ComproFacPac.Text = FA_PR_Emi_ComproFacPac.Text & " ( Consulta )"
                FA_PR_Emi_ComproFacPac.Cargar_Comprobante_toNC(comprobanteBE)
                FA_PR_Emi_ComproFacPac.txt_notas.Focus()
            Else
                FA_PR_Emi_ComproFacSeg.MdiParent = CO_MN_MenuInicial
                FA_PR_Emi_ComproFacSeg.bol_nuevo = True
                FA_PR_Emi_ComproFacSeg.Show()
                'FA_PR_Emi_ComproFacSeg.Text = FA_PR_Emi_ComproFacSeg.Text & " ( Consulta )"
                FA_PR_Emi_ComproFacSeg.Cargar_Comprobante_toNC(comprobanteBE)

                FA_PR_Emi_ComproFacSeg.txt_notas.Focus()
            End If
        End If
        

    End Sub

    Private Sub Tool_Salir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_Salir.Click
        Me.Close()
    End Sub

End Class