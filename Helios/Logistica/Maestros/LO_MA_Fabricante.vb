Public Class LO_MA_Fabricante
    Dim boton As Boolean = False
    Private Sub LO_MA_Fabricante_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Call cargar_grilla()
            Call Inicializar_Estado_Botones_Tool(ToolS_Mantenimiento)
            Me.KeyPreview = True
            MostrarTabs(0, utc_fabri)
        Catch ex As Exception
            Avisar(ex.Message)
        End Try
    End Sub

    Private Sub Tool_Nuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_Nuevo.Click
        Call Cambiar_Estado_Botones_Tool(ToolS_Mantenimiento)
        Call MostrarTabs(1, utc_fabri)
        Call limpiar_controles()
        txt_cod.Enabled = False
        Dim faBL As New BL.LogisticaBL.SG_LO_TB_FABRICANTE
        txt_cod.Text = faBL.get_Ult_Cod_facbricante(gInt_IdEmpresa)
        faBL = Nothing
        txt_cod.Focus()
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
        Dim faBL As New BL.LogisticaBL.SG_LO_TB_FABRICANTE
        Dim faBE As New BE.LogisticaBE.SG_LO_TB_FABRICANTE
        If boton = True Then
            If faBL.get_faval(gInt_IdEmpresa, Val(txt_cod.Text)).Rows.Count > 0 Then
                MsgBox("Codigo ya existente")
                Call limpiar_controles()
                txt_cod.Focus()
                Exit Sub
            End If
        End If
        With faBE
            .id = Val(txt_cod.Text)
            .descripcion = txt_des.Text
            .empresa = gInt_IdEmpresa
        End With
        If boton = True Then
            faBL.insert(faBE)
        Else
            faBL.update(faBE)
            txt_cod.Enabled = True
        End If
        Call Avisar("Listo!")

        Call cargar_grilla()
        Call Cambiar_Estado_Botones_Tool(ToolS_Mantenimiento)
        Call MostrarTabs(0, utc_fabri)
        faBE = Nothing
        faBL = Nothing
    End Sub
    Public Sub cargar_grilla()
        Dim faBL As New BL.LogisticaBL.SG_LO_TB_FABRICANTE
        Dim faBE As New BE.LogisticaBE.SG_LO_TB_FABRICANTE
        udg_fabri.DataSource = faBL.get_fagrilla(gInt_IdEmpresa)
        udg_fabri.DisplayLayout.Bands(0).Columns(0).Header.Caption = "Codigo"
        udg_fabri.DisplayLayout.Bands(0).Columns(1).Header.Caption = "Descripcion"
        udg_fabri.DisplayLayout.Bands(0).Columns(2).Hidden = True
        faBE = Nothing
        faBL = Nothing
    End Sub

    Private Sub Tool_Editar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_Editar.Click
        If udg_fabri.Rows.Count <= 0 Then
            MsgBox("Elegir una fila")
            Exit Sub
        Else
            txt_cod.Text = udg_fabri.ActiveRow.Cells(0).Value
            txt_des.Text = udg_fabri.ActiveRow.Cells(1).Value
            txt_cod.Enabled = False
            txt_des.Focus()
            Cambiar_Estado_Botones_Tool(ToolS_Mantenimiento)
            Call MostrarTabs(1, utc_fabri)
            boton = False
        End If
    End Sub

    Private Sub Tool_Cancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_Cancelar.Click
        Call limpiar_controles()
        MostrarTabs(0, utc_fabri)
        Call Cambiar_Estado_Botones_Tool(ToolS_Mantenimiento)
    End Sub

    Private Sub Tool_Eliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_Eliminar.Click
        If udg_fabri.Rows.Count <= 0 Then
            MsgBox("Elija una Fila")
            Exit Sub
        End If
        If Preguntar("Esta seguro de eliminar?") Then
            Dim faBL As New BL.LogisticaBL.SG_LO_TB_FABRICANTE
            Dim faBE As New BE.LogisticaBE.SG_LO_TB_FABRICANTE
            faBE.id = udg_fabri.ActiveRow.Cells("FA_ID").Value
            faBE.empresa = gInt_IdEmpresa
            faBL.delete(faBE)
            Avisar("Listo!")
            Call Inicializar_Estado_Botones_Tool(ToolS_Mantenimiento)
            Call cargar_grilla()
            MostrarTabs(0, utc_fabri)
            faBE = Nothing
            faBL = Nothing
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

End Class