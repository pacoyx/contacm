Public Class CO_MT_OrdenMenu_Mod

    Private Sub CO_MT_OrdenMenu_Mod_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Call Cargar_Modulos()

        ubtn_up_mod.Appearance.Image = My.Resources.ARROW12Dx
        ubtn_down_mod.Appearance.Image = My.Resources.ARROW12Ax

        ubtn_up_gru.Appearance.Image = My.Resources.ARROW12Dx
        ubtn_down_gru.Appearance.Image = My.Resources.ARROW12Ax

        ubtn_up_opc.Appearance.Image = My.Resources.ARROW12Dx
        ubtn_down_opc.Appearance.Image = My.Resources.ARROW12Ax

        ubtn_up_opc_hijo.Appearance.Image = My.Resources.ARROW12Dx
        ubtn_down_opc_hijo.Appearance.Image = My.Resources.ARROW12Ax


    End Sub

    Private Sub ubtn_up_Click(sender As System.Object, e As System.EventArgs) Handles ubtn_up_mod.Click
        Dim intIndice As Integer = lb_Modulos.SelectedIndex
        If intIndice > 0 Then
            lb_Modulos.Items.Insert(intIndice - 1, Me.lb_Modulos.SelectedItem)
            lb_Modulos.Items.RemoveAt(intIndice + 1)
            lb_Modulos.SelectedIndex = intIndice - 1
        End If
    End Sub

    Private Sub ubtn_down_Click(sender As System.Object, e As System.EventArgs) Handles ubtn_down_mod.Click
        Dim intIndice As Integer = Me.lb_Modulos.SelectedIndex
        If intIndice < lb_Modulos.Items.Count - 1 Then
            Me.lb_Modulos.Items.Insert(intIndice + 2, Me.lb_Modulos.SelectedItem)
            Me.lb_Modulos.Items.RemoveAt(intIndice)
            Me.lb_Modulos.SelectedIndex = intIndice + 1
        End If
    End Sub

    Private Sub Tool_Salir_Click(sender As System.Object, e As System.EventArgs) Handles Tool_Salir.Click
        Me.Close()
    End Sub

    Private Sub Tool_Grabar_Click(sender As System.Object, e As System.EventArgs) Handles Tool_Grabar.Click

        Dim modulosBL As New BL.ContabilidadBL.SG_CO_TB_MODULO
        Dim modulosBE As New BE.ContabilidadBE.SG_CO_TB_MODULO

        For i As Integer = 0 To lb_Modulos.Items.Count - 1
            modulosBE.MO_ID = lb_Modulos.Items(i).ToString.Substring(0, 2).TrimEnd
            modulosBE.MO_ORDEN = i + 1
            modulosBL.Update_Orden(modulosBE)
        Next

        modulosBE = Nothing
        modulosBL = Nothing


        Dim gruposBL As New BL.ContabilidadBL.SG_CO_TB_GRUPO_MENU
        Dim gruposBE As New BE.ContabilidadBE.SG_CO_TB_GRUPO_MENU

        For i As Integer = 0 To lb_Grupos.Items.Count - 1
            gruposBE.GM_ID = lb_Grupos.Items(i).ToString.Substring(0, 2).TrimEnd
            gruposBE.GM_ORDEN = i + 1
            gruposBL.Update_Orden(gruposBE)
        Next
        
        gruposBL = Nothing
        gruposBE = Nothing




        Dim opcionesBL As New BL.ContabilidadBL.SG_CO_TB_OPCIONES_MNU
        Dim opcionesBE As New BE.ContabilidadBE.SG_CO_TB_OPCIONES_MNU

        For i As Integer = 0 To lb_Opciones_padres.Items.Count - 1
            opcionesBE.OM_ID = lb_Opciones_padres.Items(i).ToString.Substring(0, 3).TrimEnd
            opcionesBE.OM_ORDEN = i + 1
            opcionesBL.Update_Orden(opcionesBE)
        Next


        For i As Integer = 0 To lb_opciones_hijos.Items.Count - 1
            opcionesBE.OM_ID = lb_opciones_hijos.Items(i).ToString.Substring(0, 3).TrimEnd
            opcionesBE.OM_ORDEN = i + 1
            opcionesBL.Update_Orden(opcionesBE)
        Next


        opcionesBE = Nothing
        opcionesBL = Nothing


        Avisar("Listo!")

    End Sub

    Private Sub Cargar_Modulos()

        Dim modulosBL As New BL.ContabilidadBL.SG_CO_TB_MODULO
        Dim ls_mods As List(Of BE.ContabilidadBE.SG_CO_TB_MODULO)
        ls_mods = modulosBL.getModulos()


        lb_Modulos.Items.Clear()
        For Each modulo As BE.ContabilidadBE.SG_CO_TB_MODULO In ls_mods
            lb_Modulos.Items.Add(modulo.MO_ID & " - " & modulo.MO_DESCRIPCION)
        Next

    End Sub

    Private Sub lb_Modulos_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles lb_Modulos.SelectedIndexChanged

        If lb_Modulos.SelectedItem = Nothing Then Exit Sub
        Dim idModulo As Integer = lb_Modulos.SelectedItem.ToString.Substring(0, 2).TrimEnd

        Dim gruposBL As New BL.ContabilidadBL.SG_CO_TB_GRUPO_MENU
        Dim ls_grupos As List(Of BE.ContabilidadBE.SG_CO_TB_GRUPO_MENU)
        ls_grupos = gruposBL.getGrupos_x_Modulo(idModulo)

        lb_Grupos.Items.Clear()
        lb_Opciones_padres.Items.Clear()
        lb_opciones_hijos.Items.Clear()
        For Each grupo As BE.ContabilidadBE.SG_CO_TB_GRUPO_MENU In ls_grupos
            lb_Grupos.Items.Add(grupo.GM_ID & " - " & grupo.GM_NOMBRE)
        Next




    End Sub

    Private Sub ubtn_up_gru_Click(sender As System.Object, e As System.EventArgs) Handles ubtn_up_gru.Click
        Dim intIndice As Integer = lb_Grupos.SelectedIndex
        If intIndice > 0 Then
            lb_Grupos.Items.Insert(intIndice - 1, Me.lb_Grupos.SelectedItem)
            lb_Grupos.Items.RemoveAt(intIndice + 1)
            lb_Grupos.SelectedIndex = intIndice - 1
        End If
    End Sub

    Private Sub ubtn_down_gru_Click(sender As System.Object, e As System.EventArgs) Handles ubtn_down_gru.Click
        Dim intIndice As Integer = Me.lb_Grupos.SelectedIndex
        If intIndice < lb_Grupos.Items.Count - 1 Then
            Me.lb_Grupos.Items.Insert(intIndice + 2, Me.lb_Grupos.SelectedItem)
            Me.lb_Grupos.Items.RemoveAt(intIndice)
            Me.lb_Grupos.SelectedIndex = intIndice + 1
        End If
    End Sub

    Private Sub lb_Grupos_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles lb_Grupos.SelectedIndexChanged
        If lb_Grupos.SelectedItem = Nothing Then Exit Sub
        Dim idGrupo As Integer = lb_Grupos.SelectedItem.ToString.Substring(0, 2).TrimEnd

        Dim opcionesBL As New BL.ContabilidadBL.SG_CO_TB_OPCIONES_MNU
        Dim dt_opc As DataTable = opcionesBL.get_Opc_NoHijos(idGrupo)

        lb_Opciones_padres.Items.Clear()
        lb_opciones_hijos.Items.Clear()

        For i As Integer = 0 To dt_opc.Rows.Count - 1
            lb_Opciones_padres.Items.Add(dt_opc.Rows(i)("OM_ID") & "  - " & dt_opc.Rows(i)("OM_DESCRIPCION"))
        Next

        dt_opc = Nothing
        opcionesBL = Nothing

    End Sub

    Private Sub ubtn_up_opc_Click(sender As System.Object, e As System.EventArgs) Handles ubtn_up_opc.Click
        Dim intIndice As Integer = lb_Opciones_padres.SelectedIndex
        If intIndice > 0 Then
            lb_Opciones_padres.Items.Insert(intIndice - 1, Me.lb_Opciones_padres.SelectedItem)
            lb_Opciones_padres.Items.RemoveAt(intIndice + 1)
            lb_Opciones_padres.SelectedIndex = intIndice - 1
        End If
    End Sub

    Private Sub ubtn_down_opc_Click(sender As System.Object, e As System.EventArgs) Handles ubtn_down_opc.Click
        Dim intIndice As Integer = Me.lb_Opciones_padres.SelectedIndex
        If intIndice < lb_Opciones_padres.Items.Count - 1 Then
            Me.lb_Opciones_padres.Items.Insert(intIndice + 2, Me.lb_Opciones_padres.SelectedItem)
            Me.lb_Opciones_padres.Items.RemoveAt(intIndice)
            Me.lb_Opciones_padres.SelectedIndex = intIndice + 1
        End If
    End Sub

    Private Sub lb_Opciones_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles lb_Opciones_padres.SelectedIndexChanged
        If lb_Opciones_padres.SelectedItem = Nothing Then Exit Sub
        Dim idpadre As Integer = lb_Opciones_padres.SelectedItem.ToString.Substring(0, 3).TrimEnd
        Dim opcionesBL As New BL.ContabilidadBL.SG_CO_TB_OPCIONES_MNU
        Dim ls_opc_Hijos As List(Of BE.ContabilidadBE.SG_CO_TB_OPCIONES_MNU)
        ls_opc_Hijos = opcionesBL.getOpcionesMenu_x_ItemPadre(idpadre)

        lb_opciones_hijos.Items.Clear()

        For Each opc As BE.ContabilidadBE.SG_CO_TB_OPCIONES_MNU In ls_opc_Hijos
            lb_opciones_hijos.Items.Add(opc.OM_ID & "  - " & opc.OM_DESCRIPCION)
        Next

    End Sub

    
    Private Sub ubtn_up_opc_hijo_Click(sender As System.Object, e As System.EventArgs) Handles ubtn_up_opc_hijo.Click
        Dim intIndice As Integer = lb_opciones_hijos.SelectedIndex
        If intIndice > 0 Then
            lb_opciones_hijos.Items.Insert(intIndice - 1, Me.lb_opciones_hijos.SelectedItem)
            lb_opciones_hijos.Items.RemoveAt(intIndice + 1)
            lb_opciones_hijos.SelectedIndex = intIndice - 1
        End If
    End Sub

    Private Sub ubtn_down_opc_hijo_Click(sender As System.Object, e As System.EventArgs) Handles ubtn_down_opc_hijo.Click
        Dim intIndice As Integer = Me.lb_opciones_hijos.SelectedIndex
        If intIndice < lb_Opciones_padres.Items.Count - 1 Then
            Me.lb_opciones_hijos.Items.Insert(intIndice + 2, Me.lb_opciones_hijos.SelectedItem)
            Me.lb_opciones_hijos.Items.RemoveAt(intIndice)
            Me.lb_opciones_hijos.SelectedIndex = intIndice + 1
        End If
    End Sub
End Class