Public Class LO_MA_Motivos
    Dim bol_nuevo As Boolean = False

    Private Sub LO_MA_Motivos_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Call Inicializar_Estado_Botones_Tool(ToolS_Mantenimiento)
        Call Cargar_Datos()
    End Sub

    Private Sub Cargar_Datos()
        Dim motivoBL As New BL.LogisticaBL.SG_LO_TB_MOTIVO
        ug_motivos.DataSource = motivoBL.get_Motivos(gInt_IdEmpresa)
        motivoBL = Nothing
    End Sub

    Private Sub Tool_Nuevo_Click(sender As System.Object, e As System.EventArgs) Handles Tool_Nuevo.Click

        Call Cambiar_Estado_Botones_Tool(ToolS_Mantenimiento)
        Call Limpiar_Controls_InGroupox(ugb_Datos)
        Call MostrarTabs(1, utc_datos, 1)

        Dim tipocomuBL As New BL.LogisticaBL.SG_LO_TB_MOTIVO
        une_cod.Value = tipocomuBL.get_Motivos_ult_cod(gInt_IdEmpresa)
        tipocomuBL = Nothing

        bol_nuevo = True
        une_cod.Enabled = True
        uce_tipo.SelectedIndex = 0
        txt_des.Focus()

    End Sub

    Private Sub Tool_Grabar_Click(sender As System.Object, e As System.EventArgs) Handles Tool_Grabar.Click


        If txt_des.Text.Trim.Length = 0 Then
            Avisar("Ingrese la descripcion del motivo")
            txt_des.Focus()
            Exit Sub
        End If

        Dim motivoBE As New BE.LogisticaBE.SG_LO_TB_MOTIVO
        With motivoBE
            .MT_ID = IIf(bol_nuevo, 0, une_cod.Value)
            .MT_NOMBRE = txt_des.Text.Trim
            .MT_TIPO = uce_tipo.Value
            .MT_IDEMPRESA = gInt_IdEmpresa
            .MT_TVER = uos_verMovi.Value
            .MT_AREA = uos_area.Value
        End With

        Dim motivoBL As New BL.LogisticaBL.SG_LO_TB_MOTIVO

        If bol_nuevo Then
            motivoBL.Insert(motivoBE)
        Else
            motivoBL.Update(motivoBE)
        End If

        motivoBL = Nothing
        motivoBE = Nothing

        Call Avisar("Listo!")
        Call Cargar_Datos()
        Call Tool_Cancelar_Click(sender, e)

    End Sub

    Private Sub Tool_Editar_Click(sender As System.Object, e As System.EventArgs) Handles Tool_Editar.Click

        If ug_motivos.Rows.Count = 0 Then Exit Sub
        If ug_motivos.ActiveRow Is Nothing Then Exit Sub

        une_cod.Value = ug_motivos.ActiveRow.Cells("MT_ID").Value
        txt_des.Text = ug_motivos.ActiveRow.Cells("MT_NOMBRE").Value
        uce_tipo.Value = ug_motivos.ActiveRow.Cells("MT_TIPO").Value
        uos_verMovi.Value = ug_motivos.ActiveRow.Cells("MT_TVER").Value
        uos_area.Value = ug_motivos.ActiveRow.Cells("MT_AREA").Value
        une_cod.Enabled = False
        Call MostrarTabs(1, utc_datos, 1)
        txt_des.Focus()

    End Sub

    Private Sub Tool_Cancelar_Click(sender As System.Object, e As System.EventArgs) Handles Tool_Cancelar.Click
        Call Cambiar_Estado_Botones_Tool(ToolS_Mantenimiento)
        Call MostrarTabs(0, utc_datos, 0)
    End Sub

    Private Sub Tool_Eliminar_Click(sender As System.Object, e As System.EventArgs) Handles Tool_Eliminar.Click
        If ug_motivos.Rows.Count = 0 Then Exit Sub
        If ug_motivos.ActiveRow Is Nothing Then Exit Sub

        If Preguntar("Seguro de eliminar?") Then
            Dim tipoComuBL As New BL.LogisticaBL.SG_LO_TB_MOTIVO
            Dim tipoComuBE As New BE.LogisticaBE.SG_LO_TB_MOTIVO
            tipoComuBE.MT_ID = ug_motivos.ActiveRow.Cells("MT_ID").Value
            tipoComuBE.MT_IDEMPRESA = gInt_IdEmpresa
            tipoComuBL.Delete(tipoComuBE)
            tipoComuBL = Nothing
            tipoComuBE = Nothing

            Call Avisar("Listo!")
            Call Cargar_Datos()

        End If
    End Sub

    Private Sub Tool_Salir_Click(sender As System.Object, e As System.EventArgs) Handles Tool_Salir.Click
        Me.Close()
    End Sub
End Class