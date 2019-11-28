Public Class FA_RE_Mante_ComproRE

    '    Dim es_super As Boolean = False

    Private Sub FA_PR_Mante_Compro_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Call CargarCombo_ConMeses(uce_Mes)
        Call Cargar_Empresas_Combo()
        '  Call Validar_Super_ft()
        uce_tipo.SelectedIndex = 2
        uce_Mes.SelectedIndex = -1

    End Sub

    Private Sub Cargar_Empresas_Combo()

        Dim usuarioBL As New BL.ContabilidadBL.SG_CO_TB_USUARIO

        uce_Empresas.DataSource = usuarioBL.get_Empresas_x_usuario(gStr_Usuario_Sis)
        uce_Empresas.DisplayMember = "EM_NOMBRE"
        uce_Empresas.ValueMember = "PU_IDEMPRESA"
        uce_Empresas.Value = gInt_IdEmpresa

        usuarioBL = Nothing

        If gInt_IdEmpresa = 1 Then
            uce_Empresas.Visible = False
            UltraLabel20.Visible = False
            uce_Empresas.Value = gInt_IdEmpresa
        Else
            uce_Empresas.Visible = True
            UltraLabel20.Visible = True
        End If

    End Sub

    Private Sub Cargar_Comprobantes()
        Dim comprobantesBL As New BL.FacturacionBL.SG_FA_TB_COMPROBANTE_C
        Dim comprobantesBE As New BE.FacturacionBE.SG_FA_TB_COMPROBANTE_C

        comprobantesBE.CO_IDEMPRESA = New BE.ContabilidadBE.SG_CO_TB_EMPRESA With {.EM_ID = gInt_IdEmpresa}
        comprobantesBE.CO_IDUSUARIO = New BE.ContabilidadBE.SG_CO_TB_USUARIO With {.US_ID = gInt_IdUsuario_Sis}

        Select Case uce_tipo.Value
            Case 1 'diario
                comprobantesBE.CO_FEC_EMI = CDate(udte_desde.Value).ToShortDateString
                ug_Listado.DataSource = comprobantesBL.get_Lista_Edi_x_Dia_03(comprobantesBE)

            Case 2 'semanal
                comprobantesBE.CO_FEC_EMI = CDate(udte_desde.Value).ToShortDateString
                comprobantesBE.CO_FEC_VEN = CDate(udte_hasta.Value).ToShortDateString
                ug_Listado.DataSource = comprobantesBL.get_Lista_Edi_x_Semana_03(comprobantesBE)

            Case 3 'mensual
                ug_Listado.DataSource = comprobantesBL.get_Lista_Edi_x_Mes_03(gDat_Fecha_Sis.Year, uce_Mes.Value, comprobantesBE.CO_IDEMPRESA)

        End Select

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
        Select Case uce_tipo.Value
            Case 1 'diario
                udte_hasta.Visible = False
                uce_Mes.Visible = False

                lbl_hasta.Visible = False
            Case 2 'semanal
                uce_Mes.Visible = False

            Case 3 'mensual

                lbl_desde.Text = "Mes"
                lbl_hasta.Visible = False
                udte_desde.Visible = False
                udte_hasta.Visible = False

        End Select

        Call Cargar_Comprobantes()

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

    Private Sub uce_Empresas_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles uce_Empresas.ValueChanged
        gInt_IdEmpresa = uce_Empresas.Value
        gStr_NomEmpresa = uce_Empresas.Text
        CO_MN_MenuInicial.Text = "Sistema Contable - " & uce_Empresas.Text
        Call Cargar_Comprobantes()

    End Sub

    Private Sub uce_tipo_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles uce_tipo.KeyDown
        If e.KeyCode = Keys.Enter Then
            If uce_tipo.Value = "1" Then 'por dia
                udte_desde.Focus()
            End If
        End If
    End Sub

End Class