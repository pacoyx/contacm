Public Class FA_MA_TipoCongelacion
    Dim Bol_Nuevo As Boolean

    'SG_FA_TB_TIPO_CONGELA
    'SG_FA_SP_S_TIPO_CONGELA_CMB
    Private Sub FA_MA_TipoCongelacion_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

        Call Cargar_Lista()
        Call Formatear_Grilla_Selector(ug_tipos)
        Call Inicializar_Estado_Botones_Tool(ToolS_Mantenimiento)
        Call MostrarTabs(0, utc_tipo, 0)

    End Sub

    Private Sub Cargar_Lista()
        Dim tiposCongeBL As New BL.FacturacionBL.SG_FA_TB_TIPO_CONGELA
        ug_tipos.DataSource = tiposCongeBL.get_tipos(gInt_IdEmpresa)
        tiposCongeBL = Nothing
    End Sub

    Private Sub Tool_Nuevo_Click(sender As System.Object, e As System.EventArgs) Handles Tool_Nuevo.Click
        Call Cambiar_Estado_Botones_Tool(ToolS_Mantenimiento)
        Call Limpiar_Controls_InGroupox(ugb_datos)
        Call MostrarTabs(1, utc_tipo, 1)

        Bol_Nuevo = True

        txt_cod.Enabled = True
        txt_cod.Focus()
    End Sub

    Private Sub Tool_Grabar_Click(sender As System.Object, e As System.EventArgs) Handles Tool_Grabar.Click
        If txt_cod.Text.Trim.Length = 0 Then
            Avisar("Debe ingresar un codigo")
            txt_cod.Focus()
            Exit Sub
        End If

        If txt_Des.Text.Trim.Length = 0 Then
            Avisar("Debe ingresar una descricpion")
            txt_Des.Focus()
            Exit Sub
        End If



        Dim tipoBE As New BE.FacturacionBE.SG_FA_TB_TIPO_CONGELA
        Dim tiposCongeBL As New BL.FacturacionBL.SG_FA_TB_TIPO_CONGELA

        tipoBE.TC_DESCRIPCION = txt_Des.Text.Trim
        tipoBE.TC_ID = txt_cod.Text.Trim
        tipoBE.TC_IDEMPRESA = gInt_IdEmpresa


        If Bol_Nuevo Then
            tiposCongeBL.Insert(tipoBE)
        Else
            tiposCongeBL.Update(tipoBE)
        End If

        Call Tool_Cancelar_Click(sender, e)
        MsgBox("Listo!")


    End Sub

    Private Sub Tool_Editar_Click(sender As System.Object, e As System.EventArgs) Handles Tool_Editar.Click

        If ug_tipos.Rows.Count = 0 Then Exit Sub
        If ug_tipos.ActiveRow Is Nothing Then Exit Sub

        With ug_tipos.ActiveRow
            txt_cod.Text = .Cells("TC_ID").Value.ToString
            txt_Des.Text = .Cells("TC_DESCRIPCION").Value.ToString
        End With

        txt_cod.Enabled = False

        Call Cambiar_Estado_Botones_Tool(ToolS_Mantenimiento)
        Call MostrarTabs(1, utc_tipo, 1)

        txt_Des.Focus()

    End Sub

    Private Sub Tool_Cancelar_Click(sender As System.Object, e As System.EventArgs) Handles Tool_Cancelar.Click
        Call Cambiar_Estado_Botones_Tool(ToolS_Mantenimiento)
        Call MostrarTabs(0, utc_tipo, 0)
    End Sub

    Private Sub Tool_Eliminar_Click(sender As System.Object, e As System.EventArgs) Handles Tool_Eliminar.Click
        If ug_tipos.Rows.Count = 0 Then Exit Sub
        If ug_tipos.ActiveRow Is Nothing Then Exit Sub

        If Preguntar("Seguro de eliminar el registro.") Then
            Dim tipoBE As New BE.FacturacionBE.SG_FA_TB_TIPO_CONGELA
            tipoBE.TC_ID = ug_tipos.ActiveRow.Cells("TC_ID").Value
            tipoBE.TC_IDEMPRESA = gInt_IdEmpresa
            Call Avisar("Listo!")
            Call Cargar_Lista()
        End If
    End Sub

    Private Sub Tool_Salir_Click(sender As System.Object, e As System.EventArgs) Handles Tool_Salir.Click
        Me.Close()
    End Sub
End Class