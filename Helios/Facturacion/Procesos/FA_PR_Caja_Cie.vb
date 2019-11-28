Public Class FA_PR_Caja_Cie

    Private Sub FA_PR_Caja_Cie_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        btn_cargar.Appearance.Image = My.Resources._16__Build_
        ume_fecha.Value = gDat_Fecha_Sis
        txt_cod_cajero.Text = gInt_IdUsuario_Sis
        txt_des_cajero.Text = gStr_Usuario_Sis
        Tool_Grabar.Enabled = True
        If gInt_IdEmpresa = 1 Or gInt_IdEmpresa = 7 Then
            ume_dol_fin.ReadOnly = False
        Else
            ume_dol_fin.ReadOnly = True
        End If
        If gInt_IdEmpresa = 1 Then
            ub_Agregar.Visible = True
            ub_Quitar.Visible = True
        Else
            ub_Agregar.Visible = False
            ub_Quitar.Visible = False
        End If
    End Sub

    Private Sub Cargar_Comprobantes()
        Dim cajaBL As New BL.FacturacionBL.SG_FA_TB_CAJA_CAB
        ug_comprobantes.DataSource = cajaBL.get_Comprobantes_x_Usuario(txt_cod_cajero.Text, Val(txt_idcaja.Text), gInt_IdEmpresa)
        cajaBL = Nothing
    End Sub

    Private Sub Cargar_Datos_Caja()
        Dim ini_sol As Double = 0
        Dim ini_dol As Double = 0
        Dim cajaBL As New BL.FacturacionBL.SG_FA_TB_CAJA_CAB
        Dim dt_data As DataTable = cajaBL.get_Data_Caja(txt_cod_cajero.Text, CDate(ume_fecha.Value).ToShortDateString, gInt_IdEmpresa)
        cajaBL = Nothing
        uce_turno.Items.Clear()
        If dt_data.Rows.Count > 0 Then
            txt_idcaja.Text = dt_data.Rows(0)("CA_ID").ToString.PadLeft(5, "0")
            uce_turno.Items.Add(dt_data.Rows(0)("CA_IDTURNO"), dt_data.Rows(0)("CA_IDTURNO") & " - " & dt_data.Rows(0)("TU_DESCRIPCION"))
            ini_sol = dt_data.Rows(0)("CA_APE_SOL")
            ini_dol = dt_data.Rows(0)("CA_APE_DOL")
            uce_turno.SelectedIndex = 0
        End If
        dt_data.Dispose()

        ume_sol_ini.Value = ini_sol
        ume_dol_ini.Value = ini_dol


        Call Cargar_Comprobantes()

        Dim mov_sol As Double = 0
        Dim mov_dol As Double = 0
        For i As Integer = 0 To ug_comprobantes.Rows.Count - 1
            If ug_comprobantes.Rows(i).Cells("CO_IDMONEDA").Value.ToString = "01" Then
                If ug_comprobantes.Rows(i).Cells("DO_ES_RESTA").Value = 1 Then
                    mov_sol -= ug_comprobantes.Rows(i).Cells("CO_TOTAL").Value
                Else
                    mov_sol += ug_comprobantes.Rows(i).Cells("CO_TOTAL").Value
                End If
            Else
                If ug_comprobantes.Rows(i).Cells("DO_ES_RESTA").Value = 1 Then
                    mov_dol -= ug_comprobantes.Rows(i).Cells("CO_TOTAL").Value
                Else
                    mov_dol += ug_comprobantes.Rows(i).Cells("CO_TOTAL").Value
                End If
            End If
        Next

        ume_sol_mov.Value = mov_sol
        ume_dol_mov.Value = mov_dol

        ume_sol_fin.Value = ini_sol + mov_sol
        ume_dol_fin.Value = ini_dol + mov_dol

    End Sub

    Private Sub Tool_salir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_salir.Click
        Me.Close()
    End Sub

    Private Sub Tool_Grabar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_Grabar.Click

        'If ug_comprobantes.Rows.Count = 0 Then Exit Sub

        Dim comprobanteBL As New BL.FacturacionBL.SG_FA_TB_COMPROBANTE_C
        Dim cajaBL As New BL.FacturacionBL.SG_FA_TB_CAJA_CAB
        Dim str_Num_voucher As String = String.Empty

        Try
            Me.Cursor = Cursors.WaitCursor

            Dim cajaBE As New BE.FacturacionBE.SG_FA_TB_CAJA_CAB
            Dim cajaDetBE As BE.FacturacionBE.SG_FA_TB_CAJA_DET
            Dim ls_detcaj As New List(Of BE.FacturacionBE.SG_FA_TB_CAJA_DET)

            With cajaBE
                .CA_ID = txt_idcaja.Text.Trim
                .CA_IDEMPRESA = gInt_IdEmpresa
                .CA_IDUSUARIO = txt_cod_cajero.Text.Trim
                .CA_USUARIO_CIE = String.Format("{0}-{1}", Environment.UserName, gStr_Usuario_Sis)
                .CA_TERMINAL_CIE = Environment.MachineName
                .CA_FECREG_CIE = Now.Date
                .CA_ESTADO = 1
                .CA_CIE_DOL = ume_dol_fin.Text
                .CA_CIE_SOL = ume_sol_fin.Text
                .CA_NUM_VOU_CONTA = 0
                .CA_IDVOUCHER = 0
            End With

            For i As Integer = 0 To ug_comprobantes.Rows.Count - 1
                cajaDetBE = New BE.FacturacionBE.SG_FA_TB_CAJA_DET
                cajaDetBE.CD_IDCOMPRO = ug_comprobantes.Rows(i).Cells("CO_ID").Value
                ls_detcaj.Add(cajaDetBE)
            Next

            If ug_comprobantes.Rows.Count > 0 Then

                comprobanteBL.Generar_Asiento_Caja_02(ume_fecha.Value, gInt_IdEmpresa, gStr_Usuario_Sis, str_Num_voucher, cajaBE, ls_detcaj)
                comprobanteBL = Nothing

                txt_numVoucherCaja.Text = str_Num_voucher
            Else
                cajaBL.Update(cajaBE)
                cajaBL = Nothing
                txt_numVoucherCaja.Text = ""
            End If

            ugb_2.Enabled = False
            ugb_3.Enabled = False
            Tool_Grabar.Enabled = False

            Call Avisar("Listo!")

            Me.Cursor = Cursors.Default
        Catch ex As Exception
            Avisar("Ocurrio un error :" & ex.Message)
            Me.Cursor = Cursors.Default
        End Try

    End Sub

    Private Sub ume_fecha_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles ume_fecha.KeyDown
        If e.KeyCode = Keys.Enter Then
            btn_cargar.Focus()
        End If
    End Sub

    Private Sub btn_cargar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_cargar.Click
        Call Cargar_Datos_Caja()
        'Call Cargar_Comprobantes()
    End Sub

    Private Sub ub_Agregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ub_Agregar.Click
        If Val(txt_idcaja.Text) <= 0 Then Exit Sub
        FA_PR_ListaComproLibres.IdCaja = Val(txt_idcaja.Text)
        FA_PR_ListaComproLibres.ShowDialog()
        Call btn_cargar_Click(sender, e)
    End Sub

    Private Sub ub_Quitar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ub_Quitar.Click
        If ug_comprobantes.Rows.Count <= 0 Then Exit Sub
        If Preguntar("Esta Seguro de Quitar el Comprobante de su cierre de caja? El comprobante quedara pendiente hasta que lo agregen a otro Cierre de Caja.") = True Then
            Dim cajaBL As New BL.FacturacionBL.SG_FA_TB_CAJA_CAB
            cajaBL.Delete_Comp(ug_comprobantes.ActiveRow.Cells(0).Value)
            Avisar("Se Quito Correctamente")
            Call btn_cargar_Click(sender, e)
        End If
    End Sub
End Class