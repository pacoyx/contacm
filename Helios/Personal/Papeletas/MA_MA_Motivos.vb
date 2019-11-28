Public Class MA_MA_Motivos

    Dim Bol_Nuevo As Boolean = False

    Private Sub MA_MA_Motivos_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Call CargarDatos()
        Call Formatear_Grilla_Selector(ug_Lista)
        Call Inicializar_Estado_Botones_Tool(ToolS_Mantenimiento)
    End Sub

    Private Sub CargarDatos()
        Dim motivosBL As New BL.MarcacionesBL.SG_MA_TB_MOTIVO
        ug_Lista.DataSource = motivosBL.get_Motivos
        motivosBL = Nothing
    End Sub

    Private Sub Tool_Nuevo_Click(sender As System.Object, e As System.EventArgs) Handles Tool_Nuevo.Click

        Call Cambiar_Estado_Botones_Tool(ToolS_Mantenimiento)
        Call MostrarTabs(1, utc_Mantenimiento, 1)
        Call Limpiar_Controls_InGroupox(ugb_datos)

        Bol_Nuevo = True

        txt_codigo.Enabled = True
        txt_codigo.Value = 0
        txt_codigo.Focus()
    End Sub

    Private Sub Tool_Editar_Click(sender As System.Object, e As System.EventArgs) Handles Tool_Editar.Click
        Call Limpiar_Controls_InGroupox(ugb_datos)

        txt_codigo.Text = ug_Lista.ActiveRow.Cells("MO_ID").Value
        txt_des.Text = ug_Lista.ActiveRow.Cells("MO_DESCRIPCION").Value
        uchk_es_dm.Checked = ug_Lista.ActiveRow.Cells("MO_ES_DM").Value
        uchk_es_va.Checked = ug_Lista.ActiveRow.Cells("MO_ES_VA").Value


        Bol_Nuevo = False
        txt_codigo.Enabled = False

        Call Cambiar_Estado_Botones_Tool(ToolS_Mantenimiento)
        Call MostrarTabs(1, utc_Mantenimiento, 1)

        txt_des.Focus()
    End Sub

    Private Sub Tool_Grabar_Click(sender As System.Object, e As System.EventArgs) Handles Tool_Grabar.Click

        If txt_codigo.Text = "" Then
            Avisar("Ingrese el codigo")
            txt_codigo.Focus()
            Exit Sub
        End If

        If txt_des.Text = "" Then
            Avisar("Ingrese la descripcion")
            txt_des.Focus()
            Exit Sub
        End If


        Dim motivoBL As New BL.MarcacionesBL.SG_MA_TB_MOTIVO
        Dim motivoBE As New BE.MarcacionesBE.SG_MA_TB_MOTIVO

        With motivoBE
            .MO_ID = txt_codigo.Text
            .MO_DESCRIPCION = txt_des.Text
            .MO_ES_DM = IIf(uchk_es_dm.Checked, 1, 0)
            .MO_ES_VA = IIf(uchk_es_va.Checked, 1, 0)
        End With

        If Bol_Nuevo Then
            motivoBL.Insert(motivoBE)
        Else
            motivoBL.Update(motivoBE)
        End If

        motivoBE = Nothing
        motivoBL = Nothing

        Call CargarDatos()
        Call Avisar("Listo!")
        Call Tool_Cancelar_Click(sender, e)

    End Sub

    Private Sub Tool_Cancelar_Click(sender As System.Object, e As System.EventArgs) Handles Tool_Cancelar.Click
        Call Cambiar_Estado_Botones_Tool(ToolS_Mantenimiento)
        Call MostrarTabs(0, utc_Mantenimiento, 0)
    End Sub

    Private Sub Tool_Eliminar_Click(sender As System.Object, e As System.EventArgs) Handles Tool_Eliminar.Click
        Avisar("No se puede eliminar un 'Motivo'")
    End Sub

    Private Sub Tool_Salir_Click(sender As System.Object, e As System.EventArgs) Handles Tool_Salir.Click
        Me.Close()
    End Sub
End Class