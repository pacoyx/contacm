Public Class LO_MA_Pais
    Dim Bol_Nuevo As Boolean = False
    Private Sub LO_MA_Pais_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Call Cargar_Lista_pais()
            Call Formatear_Grilla_Selector(ug_pa)
            Call Inicializar_Estado_Botones_Tool(ToolS_Mantenimiento)
            Me.KeyPreview = True
            MostrarTabs(0, utc_pa)
        Catch ex As Exception
            Avisar(ex.Message)
        End Try
    End Sub
    Private Sub Cargar_Lista_pais()
        Dim paBL As New BL.LogisticaBL.SG_LO_TB_PAIS
        Dim paBE As New BE.LogisticaBE.SG_LO_TB_PAIS
        paBE.idempresa_ = gInt_IdEmpresa
        ug_pa.DataSource = paBL.getpa(gInt_IdEmpresa)
        paBE = Nothing
        paBL = Nothing
    End Sub

    Private Sub Tool_Salir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_Salir.Click
        Me.Close()
    End Sub
    Public Sub Limpiar_Controles()
        txt_cod.Text = ""
        txt_pais.Text = ""
    End Sub

    Private Sub Tool_Nuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_Nuevo.Click
        Call Cambiar_Estado_Botones_Tool(ToolS_Mantenimiento)
        Call Limpiar_Controles()
        Call MostrarTabs(1, utc_pa, 1)

        Dim paBL As New BL.LogisticaBL.SG_LO_TB_PAIS
        txt_cod.Text = paBL.get_Ult_cod_Pais(gInt_IdEmpresa)
        paBL = Nothing
        txt_cod.Enabled = False
        txt_pais.Focus()
        Bol_Nuevo = True
    End Sub

    Private Sub Tool_Eliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_Eliminar.Click
        If ug_pa.Rows.Count > 0 Then
            If Preguntar("Esta seguro de eliminar?") Then
                Dim paBL As New BL.LogisticaBL.SG_LO_TB_PAIS
                Dim paBE As New BE.LogisticaBE.SG_LO_TB_PAIS
                paBE.codigo_ = ug_pa.ActiveRow.Cells("PA_ID").Value
                paBE.idempresa_ = gInt_IdEmpresa
                paBL.delete(paBE)
                Avisar("Listo!")
                Call Cargar_Lista_pais()
                paBE = Nothing
                paBL = Nothing
            End If
        Else
            MsgBox("Elija una Fila")
            Exit Sub
        End If
    End Sub

    Private Sub Tool_Cancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_Cancelar.Click
        Call Cambiar_Estado_Botones_Tool(ToolS_Mantenimiento)
        Call MostrarTabs(0, utc_pa, 0)
        Call Limpiar_Controles()
    End Sub

    Private Sub Tool_Grabar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_Grabar.Click
        Dim paBL As New BL.LogisticaBL.SG_LO_TB_PAIS
        Dim paBE As New BE.LogisticaBE.SG_LO_TB_PAIS
        If txt_cod.Text = "" And txt_pais.Text = "" Then
            Avisar("Falta Completar")
            Exit Sub
        Else
            If Bol_Nuevo = True Then
                If paBL.getpaval(txt_cod.Text, gInt_IdEmpresa).Rows.Count > 0 Then
                    MsgBox("Codigo ya existente")
                    Exit Sub
                End If
            End If
            With paBE
                .codigo_ = txt_cod.Text
                .descripcion_ = txt_pais.Text
                .idempresa_ = gInt_IdEmpresa
            End With

            If Bol_Nuevo Then
                paBL.insert(paBE)
            Else
                paBL.update(paBE)
            End If

        End If

        Call Avisar("Listo!")
        Call Cargar_Lista_pais()
        Call Tool_Cancelar_Click(sender, e)

        paBE = Nothing
        paBL = Nothing

    End Sub

    Private Sub Tool_Editar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_Editar.Click
        If ug_pa.Rows.Count <= 0 Then
            MsgBox("Elegir una fila")
            Exit Sub
        Else
            txt_cod.Text = ug_pa.ActiveRow.Cells("PA_ID").Value
            txt_pais.Text = ug_pa.ActiveRow.Cells("PA_DESCRIPCION").Value
            Call Cambiar_Estado_Botones_Tool(ToolS_Mantenimiento)
            Call MostrarTabs(1, utc_pa, 1)
            txt_cod.Enabled = False
            txt_pais.Focus()
            Bol_Nuevo = False
        End If
    End Sub
    Private Sub pKeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Me.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Return) Then
            SendKeys.Send("{TAB}")
            e.Handled = True
        End If
    End Sub
End Class