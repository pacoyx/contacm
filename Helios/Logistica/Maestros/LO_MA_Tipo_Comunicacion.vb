Public Class LO_MA_Tipo_Comunicacion
    Dim bol_nuevo As Boolean = False

    Private Sub LO_MA_Tipo_Comunicacion_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Call Inicializar_Estado_Botones_Tool(ToolS_Mantenimiento)
        Call Cargar_Datos()
    End Sub

    Private Sub Cargar_Datos()
        Dim tipocomuBL As New BL.LogisticaBL.SG_LO_TB_TIPO_COMUNICACION
        ug_tipos.DataSource = tipocomuBL.get_Tipos(gInt_IdEmpresa)
        tipocomuBL = Nothing
    End Sub

    Private Sub Tool_Nuevo_Click(sender As System.Object, e As System.EventArgs) Handles Tool_Nuevo.Click

        Call Cambiar_Estado_Botones_Tool(ToolS_Mantenimiento)
        Call Limpiar_Controls_InGroupox(ugb_Datos)
        Call MostrarTabs(1, utc_tipo_comu, 1)

        Dim tipocomuBL As New BL.LogisticaBL.SG_LO_TB_TIPO_COMUNICACION
        une_cod.Value = tipocomuBL.get_ult_cod(gInt_IdEmpresa)
        tipocomuBL = Nothing

        bol_nuevo = True
        une_cod.Enabled = True
        txt_des.Focus()

    End Sub

    Private Sub Tool_Grabar_Click(sender As System.Object, e As System.EventArgs) Handles Tool_Grabar.Click
        If une_cod.Value = 0 Then
            Call Avisar("Ingrese el codigo")
            une_cod.Focus()
            Exit Sub
        End If

        If txt_des.Text.Trim = "" Then
            Call Avisar("Ingrese la descripcion")
            txt_des.Focus()
            Exit Sub
        End If

        Dim tipocomuBL As New BL.LogisticaBL.SG_LO_TB_TIPO_COMUNICACION
        Dim tipocomuBE As New BE.LogisticaBE.SG_LO_TB_TIPO_COMUNICACION
        With tipocomuBE
            .TC_ID = une_cod.Value
            .TC_DESCRIPCION = txt_des.Text.Trim
            .TC_IDEMPRESA = gInt_IdEmpresa
        End With

        If bol_nuevo Then
            tipocomuBL.Insert(tipocomuBE)
        Else
            tipocomuBL.Update(tipocomuBE)
        End If

        tipocomuBE = Nothing
        tipocomuBL = Nothing

        Call Avisar("Listo")
        Call Cargar_Datos()
        Call Tool_Cancelar_Click(sender, e)

    End Sub

    Private Sub Tool_Editar_Click(sender As System.Object, e As System.EventArgs) Handles Tool_Editar.Click

        If ug_tipos.Rows.Count = 0 Then Exit Sub
        If ug_tipos.ActiveRow Is Nothing Then Exit Sub

        Call Cambiar_Estado_Botones_Tool(ToolS_Mantenimiento)

        bol_nuevo = False
        une_cod.Value = ug_tipos.ActiveRow.Cells("TC_ID").Value
        txt_des.Text = ug_tipos.ActiveRow.Cells("TC_DESCRIPCION").Value

        Call MostrarTabs(1, utc_tipo_comu, 1)

        une_cod.Enabled = False
        txt_des.Focus()

    End Sub

    Private Sub Tool_Cancelar_Click(sender As System.Object, e As System.EventArgs) Handles Tool_Cancelar.Click
        Call Cambiar_Estado_Botones_Tool(ToolS_Mantenimiento)
        Call MostrarTabs(0, utc_tipo_comu, 0)
    End Sub

    Private Sub Tool_Eliminar_Click(sender As System.Object, e As System.EventArgs) Handles Tool_Eliminar.Click

        If ug_tipos.Rows.Count = 0 Then Exit Sub
        If ug_tipos.ActiveRow.IsFilterRow Then Exit Sub

        If Preguntar("Seguro de eliminar?") Then
            Dim tipoComuBL As New BL.LogisticaBL.SG_LO_TB_TIPO_COMUNICACION
            Dim tipoComuBE As New BE.LogisticaBE.SG_LO_TB_TIPO_COMUNICACION
            tipoComuBE.TC_ID = ug_tipos.ActiveRow.Cells("PR_ID").Value
            tipoComuBE.TC_IDEMPRESA = gInt_IdEmpresa
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