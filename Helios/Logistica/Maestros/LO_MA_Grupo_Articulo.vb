Public Class LO_MA_Grupo_Articulo
    Dim boton As Boolean = False
    Private Sub LO_MA_Grupo_Articulo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Call cargar_grilla()
            Call Formatear_Grilla_Selector(udg_ga)
            Call Inicializar_Estado_Botones_Tool(ToolS_Mantenimiento)
            Me.KeyPreview = True
            MostrarTabs(0, utc_ga)
        Catch ex As Exception
            Avisar(ex.Message)
        End Try
    End Sub

    Private Sub Tool_Nuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_Nuevo.Click
        Call Cambiar_Estado_Botones_Tool(ToolS_Mantenimiento)
        Call MostrarTabs(1, utc_ga)
        Call limpiar_controles()
        txt_cod.Enabled = False

        Dim gaBL As New BL.LogisticaBL.SG_LO_TB_GRUPO_ARTICULO
        txt_cod.Text = gaBL.get_ult_codigo(gInt_IdEmpresa)
        gaBL = Nothing
        txt_des.Focus()
        boton = True
    End Sub
    Public Sub limpiar_controles()
        txt_cod.Text = ""
        txt_des.Text = ""
    End Sub
    Private Sub Tool_Grabar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_Grabar.Click
        If txt_cod.Text = "" Or txt_des.Text = "" Then
            MsgBox("Falta completar")
            Exit Sub
        End If
        If txt_cta_conta.Text.Trim.Length > 0 Then
            lbl_des_cta.Text = get_Descripcion_CtaContable(txt_cta_conta.Text.Trim, gDat_Fecha_Sis.Year, gInt_IdEmpresa)
        End If
        Dim gaBL As New BL.LogisticaBL.SG_LO_TB_GRUPO_ARTICULO
        Dim gaBE As New BE.LogisticaBE.SG_LO_TB_GRUPO_ARTICULO
        If boton = True Then
            If gaBL.get_gaval(gInt_IdEmpresa, Val(txt_cod.Text)).Rows.Count > 0 Then
                MsgBox("Codigo ya existente")
                Call limpiar_controles()
                txt_cod.Focus()
                Exit Sub
            End If
        End If
        With gaBE
            .id = Val(txt_cod.Text)
            .descripcion = txt_des.Text
            .empresa = gInt_IdEmpresa
            .CntConta = txt_cta_conta.Text.Trim
        End With
        If boton = True Then
            gaBL.insert(gaBE)
        Else
            gaBL.update(gaBE)
            txt_cod.Enabled = True
        End If
        Call Avisar("Listo!")

        Call cargar_grilla()
        Call Cambiar_Estado_Botones_Tool(ToolS_Mantenimiento)
        Call MostrarTabs(0, utc_ga)
        gaBE = Nothing
        gaBL = Nothing
    End Sub
    Public Sub cargar_grilla()
        Dim gaBL As New BL.LogisticaBL.SG_LO_TB_GRUPO_ARTICULO
        Dim gaBE As New BE.LogisticaBE.SG_LO_TB_GRUPO_ARTICULO
        udg_ga.DataSource = gaBL.get_gagrilla(gInt_IdEmpresa)
        'udg_ga.DisplayLayout.Bands(0).Columns(0).Header.Caption = "Codigo"
        'udg_ga.DisplayLayout.Bands(0).Columns(1).Header.Caption = "Descripcion"
        'udg_ga.DisplayLayout.Bands(0).Columns(2).Hidden = True
        'udg_ga.DisplayLayout.Bands(0).Columns(3).Hidden = True
        gaBE = Nothing
        gaBL = Nothing
    End Sub

    Private Sub Tool_Editar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_Editar.Click
        If udg_ga.Rows.Count <= 0 Then
            MsgBox("Elegir una fila")
            Exit Sub
        Else
            txt_cod.Text = udg_ga.ActiveRow.Cells(0).Value
            txt_des.Text = udg_ga.ActiveRow.Cells(1).Value
            txt_cta_conta.Text = udg_ga.ActiveRow.Cells(3).Value.ToString
            If txt_cta_conta.Text.Trim.Length > 0 Then
                lbl_des_cta.Text = get_Descripcion_CtaContable(txt_cta_conta.Text.Trim, gDat_Fecha_Sis.Year, gInt_IdEmpresa)
            Else
                lbl_des_cta.Text = ""
            End If

            txt_cod.Enabled = False
            txt_des.Focus()
            Cambiar_Estado_Botones_Tool(ToolS_Mantenimiento)
            Call MostrarTabs(1, utc_ga)
            boton = False
        End If
    End Sub

    Private Sub Tool_Cancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_Cancelar.Click
        Call limpiar_controles()
        MostrarTabs(0, utc_ga)
        Call Cambiar_Estado_Botones_Tool(ToolS_Mantenimiento)
    End Sub

    Private Sub Tool_Eliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_Eliminar.Click
        If udg_ga.Rows.Count <= 0 Then
            MsgBox("Elija una Fila")
            Exit Sub
        End If
        If Preguntar("Esta seguro de eliminar?") Then
            Dim gaBL As New BL.LogisticaBL.SG_LO_TB_GRUPO_ARTICULO
            Dim gaBE As New BE.LogisticaBE.SG_LO_TB_GRUPO_ARTICULO
            gaBE.id = udg_ga.ActiveRow.Cells("GA_ID").Value
            gaBE.empresa = gInt_IdEmpresa
            gaBL.delete(gaBE)
            Avisar("Listo!")
            Call Inicializar_Estado_Botones_Tool(ToolS_Mantenimiento)
            Call cargar_grilla()
            MostrarTabs(0, utc_ga)
            gaBE = Nothing
            gaBL = Nothing
        End If
    End Sub

    Private Sub Tool_Salir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_Salir.Click
        Me.Close()
    End Sub
    Private Sub pKeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Me.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Return) Then
            SendKeys.Send("{TAB}")
            e.Handled = True
        End If
    End Sub

    Private Sub txt_cod_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_cod.KeyPress
        e.KeyChar = fKeyPress(e.KeyChar, txt_cod.Text, 1)
        e.Handled = (e.KeyChar = "")
    End Sub
 Private Sub txt_cta_conta_Leave(sender As System.Object, e As System.EventArgs) Handles txt_cta_conta.Leave
        lbl_des_cta.Text = get_Descripcion_CtaContable(txt_cta_conta.Text.Trim, gDat_Fecha_Sis.Year, gInt_IdEmpresa)
    End Sub
End Class