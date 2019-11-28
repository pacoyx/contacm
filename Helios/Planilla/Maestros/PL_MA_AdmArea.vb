Public Class PL_MA_AdmArea

    Dim Bol_Nuevo As Boolean = False

    Private Sub PL_MA_AdmArea_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Call Inicializar_Estado_Botones_Tool(ToolS_Mantenimiento)
        Call Cargar_Lista_Areas()
        Call Cargar_Personal_Jefe()
        Call Formatear_Grilla_Selector(ug_Listado)
        Call MostrarTabs(0, utc_Mante, 0)
    End Sub

    Private Sub Cargar_Lista_Areas()

        Dim areaBL As New BL.PlanillaBL.SG_PL_TB_AREA
        Dim areaBE As New BE.PlanillaBE.SG_PL_TB_AREA

        areaBE.AR_ID_EMPRESA = New BE.ContabilidadBE.SG_CO_TB_EMPRESA With {.EM_ID = gInt_IdEmpresa}
        ug_Listado.DataSource = areaBL.getArea(areaBE)

        areaBE = Nothing
        areaBL = Nothing

    End Sub


    Private Sub Cargar_Personal_Jefe()
        Dim personalBL As New BL.PlanillaBL.SG_PL_TB_PERSONAL
        uce_Jefe_Area.DataSource = personalBL.getPersonal_Cmb_Login(gInt_IdEmpresa)
        uce_Jefe_Area.DisplayMember = "NOMBRES"
        uce_Jefe_Area.ValueMember = "PE_ID"
        personalBL = Nothing
    End Sub

    Private Sub Tool_Nuevo_Click(sender As System.Object, e As System.EventArgs) Handles Tool_Nuevo.Click

        Call Cambiar_Estado_Botones_Tool(ToolS_Mantenimiento)
        Call MostrarTabs(1, utc_Mante, 1)
        Call Limpiar_Controls_InGroupox(ugb_datos)

        Bol_Nuevo = True
        une_codigo.Enabled = False
        txt_des.Focus()

    End Sub

    Private Sub Tool_Grabar_Click(sender As System.Object, e As System.EventArgs) Handles Tool_Grabar.Click

        If txt_des.Text.Trim.Length = 0 Then
            Avisar("Ingresar Descripcion de Area")
            txt_des.Focus()
            Exit Sub
        End If

        If uce_Jefe_Area.SelectedIndex = -1 Then
            Avisar("Seleccione Jefe de Area")
            uce_Jefe_Area.Focus()
            Exit Sub
        End If


        Dim areaBL As New BL.PlanillaBL.SG_PL_TB_AREA
        Dim areaBE As New BE.PlanillaBE.SG_PL_TB_AREA

        areaBE.AR_ID = IIf(Bol_Nuevo, 0, une_codigo.Value)
        areaBE.AR_DESCRIPCION = txt_des.Text.Trim
        areaBE.AR_ID_EMPRESA = New BE.ContabilidadBE.SG_CO_TB_EMPRESA With {.EM_ID = gInt_IdEmpresa}
        areaBE.AR_IDJEFE = uce_Jefe_Area.Value

        If Bol_Nuevo Then
            areaBL.Insert(areaBE)
        Else
            areaBL.Update(areaBE)
        End If

        areaBE = Nothing
        areaBL = Nothing

        Call Cargar_Lista_Areas()
        Call Avisar("Listo")
        Call Tool_Cancelar_Click(sender, e)

    End Sub

    Private Sub Tool_Editar_Click(sender As System.Object, e As System.EventArgs) Handles Tool_Editar.Click

        Bol_Nuevo = False
        Call Cambiar_Estado_Botones_Tool(ToolS_Mantenimiento)
        Call Limpiar_Controls_InGroupox(ugb_datos)

        une_codigo.Value = ug_Listado.ActiveRow.Cells("AR_ID").Value
        txt_des.Text = ug_Listado.ActiveRow.Cells("AR_DESCRIPCION").Value
        uce_Jefe_Area.Value = ug_Listado.ActiveRow.Cells("AR_IDJEFE").Value

        une_codigo.Enabled = False
        Call MostrarTabs(1, utc_Mante, 1)
        txt_des.Focus()

    End Sub

    Private Sub Tool_Cancelar_Click(sender As System.Object, e As System.EventArgs) Handles Tool_Cancelar.Click
        Call MostrarTabs(0, utc_Mante, 0)
        Call Cambiar_Estado_Botones_Tool(ToolS_Mantenimiento)
    End Sub

    Private Sub Tool_Eliminar_Click(sender As System.Object, e As System.EventArgs) Handles Tool_Eliminar.Click

        If ug_Listado.Rows.Count = 0 Then Exit Sub
        If ug_Listado.ActiveRow Is Nothing Then Exit Sub


        Dim areaBL As New BL.PlanillaBL.SG_PL_TB_AREA
        Dim areaBE As New BE.PlanillaBE.SG_PL_TB_AREA

        areaBE.AR_ID = ug_Listado.ActiveRow.Cells("AR_ID").Value
        areaBE.AR_ID_EMPRESA = New BE.ContabilidadBE.SG_CO_TB_EMPRESA With {.EM_ID = gInt_IdEmpresa}

        areaBL.Delete(areaBE)

        areaBE = Nothing
        areaBL = Nothing

    End Sub

    Private Sub Tool_Salir_Click(sender As System.Object, e As System.EventArgs) Handles Tool_Salir.Click
        Me.Close()
    End Sub
End Class