Public Class AD_MA_Medicamentos
    Dim boton As Boolean = False
    Private Sub AD_MA_Medicamentos_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        cargar_medicamentos()
        MostrarTabs(0, utc_medicamentos)
        cargar_cb_categoria()
        cargar_cb_presentacion()
        Bloquear_barra_Ini()
        ugb_datos.Enabled = False
    End Sub
    Public Sub Limpiar_controles()
        txt_id.Text = "" : txt_Descripcion.Text = "" : txt_compo_gene.Text = ""
        cb_categoria.SelectedIndex = -1 : cb_presentacion.SelectedIndex = -1
    End Sub
    Public Sub Bloquear_controles(opcion As Boolean)
        ugb_datos.Enabled = opcion
    End Sub
    Public Sub Bloquear_barra_Ini()
        Tool_Nuevo.Enabled = True
        Tool_Editar.Enabled = True
        Tool_Grabar.Enabled = False
        Tool_Cancelar.Enabled = False
        Tool_Eliminar.Enabled = True
        Tool_Salir.Enabled = True
    End Sub
    Public Sub Bloquear_barra_edi()
        Tool_Nuevo.Enabled = False
        Tool_Editar.Enabled = False
        Tool_Grabar.Enabled = True
        Tool_Cancelar.Enabled = True
        Tool_Eliminar.Enabled = False
        Tool_Salir.Enabled = False
    End Sub

    Public Sub cargar_medicamentos()

        Dim grilla_medic As New BL.AdmisionBL.SG_AD_TB_MEDICA_RE
        ug_medicamentos.DataSource = grilla_medic.mostrar(gInt_IdEmpresa)
        grilla_medic = Nothing

        'ug_medicamentos.DisplayLayout.Bands(0).Columns(0).Header.Caption = "CODIGO"
        'ug_medicamentos.DisplayLayout.Bands(0).Columns(1).Header.Caption = "DESCRIPCION"
        'ug_medicamentos.DisplayLayout.Bands(0).Columns(2).Hidden = True
        'ug_medicamentos.DisplayLayout.Bands(0).Columns(3).Header.Caption = "CATEGORIA"
        'ug_medicamentos.DisplayLayout.Bands(0).Columns(5).Header.Caption = "PRESENTACION"
        'ug_medicamentos.DisplayLayout.Bands(0).Columns(4).Header.Caption = "COMPOSICION GENERICA"
        'ug_medicamentos.DisplayLayout.Bands(0).Columns(6).Hidden = True
        'ug_medicamentos.DisplayLayout.Bands(0).Columns(7).Hidden = True

    End Sub
    Public Sub cargar_cb_categoria()
        Dim BL_categoria As New BL.AdmisionBL.SG_AD_TB_MEDICA_RE
        cb_categoria.DataSource = BL_categoria.mostrar_categoria()
        cb_categoria.ValueMember = "CM_ID"
        cb_categoria.DisplayMember = "CM_DESCRIPCION"
        BL_categoria = Nothing
    End Sub
    Public Sub cargar_cb_presentacion()
        Dim BL_presentacion As New BL.AdmisionBL.SG_AD_TB_MEDICA_RE
        cb_presentacion.DataSource = BL_presentacion.mostrar_presentacion()
        cb_presentacion.ValueMember = "PM_ID"
        cb_presentacion.DisplayMember = "PM_DESCRIPCION"
        BL_presentacion = Nothing
    End Sub
    Private Sub Tool_Nuevo_Click(sender As System.Object, e As System.EventArgs) Handles Tool_Nuevo.Click
        MostrarTabs(1, utc_medicamentos)
        Bloquear_barra_edi()
        Limpiar_controles()
        ugb_datos.Enabled = True
        boton = True
        txt_Descripcion.Focus()
    End Sub

    Private Sub Tool_Grabar_Click(sender As System.Object, e As System.EventArgs) Handles Tool_Grabar.Click
        If txt_Descripcion.Text = "" Or txt_compo_gene.Text = "" Or cb_categoria.SelectedIndex = -1 _
            Or cb_presentacion.SelectedIndex = -1 Then
            Avisar(" Falta Completar ")
            Exit Sub
        End If
        Dim BE_medic As New BE.AdmisionBE.SG_AD_TB_MEDICA_RE
        Dim BL_medic As New BL.AdmisionBL.SG_AD_TB_MEDICA_RE
        With BE_medic
            .id = ug_medicamentos.ActiveRow.Cells(0).Value
            .descripcion = txt_Descripcion.Text
            .idcat = cb_categoria.SelectedValue
            .presentacion = cb_presentacion.Text
            .compo_gene = txt_compo_gene.Text
            .idempresa = gInt_IdEmpresa
        End With
        If boton = True Then
            BL_medic.insercion(BE_medic)
            Avisar("Grabo Exitosamente")
        Else
            BL_medic.actualizar(BE_medic)
            Avisar("Actualizado Exitosamente")
        End If
        Bloquear_barra_Ini()
        MostrarTabs(0, utc_medicamentos)
        ugb_datos.Enabled = False
        cargar_medicamentos()
        BE_medic = Nothing
        BL_medic = Nothing
    End Sub

    Private Sub Tool_Editar_Click(sender As System.Object, e As System.EventArgs) Handles Tool_Editar.Click
        If ug_medicamentos.ActiveRow Is Nothing Then
            Avisar("Elija una Fila")
            Exit Sub
        End If
        txt_id.Text = ug_medicamentos.ActiveRow.Cells(0).Value.ToString
        txt_Descripcion.Text = ug_medicamentos.ActiveRow.Cells(1).Value.ToString
        cb_categoria.SelectedValue = ug_medicamentos.ActiveRow.Cells(2).Value.ToString
        cb_presentacion.Text = ug_medicamentos.ActiveRow.Cells(5).Value.ToString
        txt_compo_gene.Text = ug_medicamentos.ActiveRow.Cells(4).Value.ToString
        MostrarTabs(1, utc_medicamentos)
        boton = False
        Bloquear_barra_edi()
        ugb_datos.Enabled = True
    End Sub

    Private Sub Tool_Cancelar_Click(sender As System.Object, e As System.EventArgs) Handles Tool_Cancelar.Click
        Limpiar_controles()
        Bloquear_barra_Ini()
        cargar_medicamentos()
        MostrarTabs(0, utc_medicamentos)
    End Sub

    Private Sub Tool_Eliminar_Click(sender As System.Object, e As System.EventArgs) Handles Tool_Eliminar.Click
        If ug_medicamentos.ActiveRow Is Nothing Then
            Avisar("Elija una Fila")
            Exit Sub
        End If
        If ug_medicamentos.Rows.Count = 0 Then
            Avisar("No existe registro")
            Exit Sub
        End If
        If Preguntar("Esta seguro de eliminar?") Then
            Dim BE_medic As New BE.AdmisionBE.SG_AD_TB_MEDICA_RE
            Dim BL_medic As New BL.AdmisionBL.SG_AD_TB_MEDICA_RE
            With BE_medic
                .id = ug_medicamentos.ActiveRow.Cells(0).Value
            End With
            BL_medic.eliminar(BE_medic)
            Avisar("Listo")

            Bloquear_barra_Ini()
            MostrarTabs(0, utc_medicamentos)
            ugb_datos.Enabled = False
            cargar_medicamentos()
            BE_medic = Nothing
            BL_medic = Nothing
        End If
    End Sub

    Private Sub Tool_Salir_Click(sender As System.Object, e As System.EventArgs) Handles Tool_Salir.Click
        Me.Close()
    End Sub
End Class