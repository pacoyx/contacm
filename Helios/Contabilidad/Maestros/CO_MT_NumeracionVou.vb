Public Class CO_MT_NumeracionVou

    Private Sub CO_MT_NumeracionVou_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        une_Ayo.Value = gDat_Fecha_Sis.Year
        Call CargarCombo_ConMeses(uce_Mes)
        uce_Mes.SelectedIndex = -1
        Tool_Grabar.Enabled = False
    End Sub

    Private Sub Tool_Salir_Click(sender As System.Object, e As System.EventArgs) Handles Tool_Salir.Click
        Me.Close()
    End Sub

    Private Sub Tool_Grabar_Click(sender As System.Object, e As System.EventArgs) Handles Tool_Grabar.Click

        If txt_ultimo_num.Value Is Nothing Then
            Avisar("Ingrese un Numero")
            txt_ultimo_num.Focus()
            Exit Sub
        End If

        Dim numeracionBL As New BL.ContabilidadBL.SG_CO_TB_NUMVOUCHER
        Dim numeracionBE As New BE.ContabilidadBE.SG_CO_TB_NUMVOUCHER
        numeracionBE.NV_IDEMPRESA = New BE.ContabilidadBE.SG_CO_TB_EMPRESA With {.EM_ID = gInt_IdEmpresa}
        numeracionBE.NV_ANHO = une_Ayo.Value
        numeracionBE.NV_MES = uce_Mes.Value
        numeracionBE.NV_IDSUBDIARIO = New BE.ContabilidadBE.SG_CO_TB_SUBDIARIO With {.SD_ID = ug_Numeracion.ActiveRow.Cells("NV_IDSUBDIARIO").Value}
        numeracionBE.NV_IDEMPRESA = New BE.ContabilidadBE.SG_CO_TB_EMPRESA With {.EM_ID = gInt_IdEmpresa}
        numeracionBE.NV_ULTIMO_NUMERO = txt_ultimo_num.Value
        numeracionBL.Update(numeracionBE)

        numeracionBE = Nothing
        numeracionBL = Nothing

        Call Cargar_Datos()

        Call Avisar("Listo!")

        Call Tool_Cancelar_Click(sender, e)

    End Sub

    Private Sub Tool_Editar_Click(sender As System.Object, e As System.EventArgs) Handles Tool_Editar.Click
        Call MostrarTabs(1, utc_numeracion, 1)
        Tool_Grabar.Enabled = True
        txt_subdiario.Text = ug_Numeracion.ActiveRow.Cells("SUBDIARIO").Value
        txt_ultimo_num.Value = ug_Numeracion.ActiveRow.Cells("NV_ULTIMO_NUMERO").Value
        txt_ultimo_num.Focus()
    End Sub

    Private Sub Tool_Cancelar_Click(sender As System.Object, e As System.EventArgs) Handles Tool_Cancelar.Click
        Call MostrarTabs(0, utc_numeracion, 0)
        txt_subdiario.Text = String.Empty
        txt_ultimo_num.Value = Nothing
        Tool_Grabar.Enabled = False
    End Sub

    Private Sub uce_Mes_ValueChanged(sender As System.Object, e As System.EventArgs) Handles uce_Mes.ValueChanged
        Call Cargar_Datos()
    End Sub

    Private Sub Cargar_Datos()
        If uce_Mes.SelectedIndex = -1 Then Exit Sub

        Dim numeracionBL As New BL.ContabilidadBL.SG_CO_TB_NUMVOUCHER
        Dim numeracionBE As New BE.ContabilidadBE.SG_CO_TB_NUMVOUCHER
        numeracionBE.NV_ANHO = une_Ayo.Value
        numeracionBE.NV_MES = uce_Mes.Value
        numeracionBE.NV_IDEMPRESA = New BE.ContabilidadBE.SG_CO_TB_EMPRESA With {.EM_ID = gInt_IdEmpresa}
        ug_Numeracion.DataSource = numeracionBL.get_Lista_Numeracion_xMes(numeracionBE)
        numeracionBL = Nothing
    End Sub

    Private Sub UltraTextEditor2_ValueChanged(sender As System.Object, e As System.EventArgs)

    End Sub

    Private Sub ug_Numeracion_BeforeRowsDeleted(sender As System.Object, e As Infragistics.Win.UltraWinGrid.BeforeRowsDeletedEventArgs) Handles ug_Numeracion.BeforeRowsDeleted
        e.DisplayPromptMsg = False
        e.Cancel = True
    End Sub
End Class