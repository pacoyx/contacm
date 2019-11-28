Public Class LO_MA_ESTADO_REQUE
    Dim boton As Boolean = False
    Private Sub LO_MA_ESTADO_REQUE_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Call cargar_grilla()
            Call Inicializar_Estado_Botones_Tool(ToolS_Mantenimiento)
            Me.KeyPreview = True
            MostrarTabs(0, utc_er)
        Catch ex As Exception
            Avisar(ex.Message)
        End Try
    End Sub

    Private Sub Tool_Nuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_Nuevo.Click
        Call Cambiar_Estado_Botones_Tool(ToolS_Mantenimiento)
        Call MostrarTabs(1, utc_er)
        Call limpiar_controles()
        txt_des.Focus()
        boton = True
    End Sub
    Public Sub limpiar_controles()
        txt_cod.Text = ""
        txt_des.Text = ""
    End Sub

    Private Sub Tool_Grabar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_Grabar.Click
        If txt_des.Text = "" Then
            MsgBox("Falta completar")
            Exit Sub
        End If
        Dim erBL As New BL.LogisticaBL.SG_LO_TB_ESTADO_REQUERIMIENTO
        Dim erBE As New BE.LogisticaBE.SG_LO_TB_ESTADO_REQUERIMIENTO
        With erBE
            .id = Val(txt_cod.Text)
            .descripcion = txt_des.Text
            .empresa = gInt_IdEmpresa
        End With
        If boton = True Then
            erBL.Insert(erBE)
        Else
            erBL.Update(erBE)
        End If
        Call Avisar("Listo!")

        Call cargar_grilla()
        Call Cambiar_Estado_Botones_Tool(ToolS_Mantenimiento)
        Call MostrarTabs(0, utc_er)
        erBE = Nothing
        erBL = Nothing
    End Sub
    Public Sub cargar_grilla()
        Dim erBL As New BL.LogisticaBL.SG_LO_TB_ESTADO_REQUERIMIENTO
        Dim erBE As New BE.LogisticaBE.SG_LO_TB_ESTADO_REQUERIMIENTO
        ug_er.DataSource = erBL.get_grilla(gInt_IdEmpresa)
        ug_er.DisplayLayout.Bands(0).Columns(0).Header.Caption = "Codigo"
        ug_er.DisplayLayout.Bands(0).Columns(1).Header.Caption = "Descripcion"
        ug_er.DisplayLayout.Bands(0).Columns(2).Hidden = True
        erBE = Nothing
        erBL = Nothing
    End Sub

    Private Sub Tool_Editar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_Editar.Click
        If ug_er.Rows.Count <= 0 Then
            MsgBox("Elegir una fila")
            Exit Sub
        Else
            txt_cod.Text = ug_er.ActiveRow.Cells(0).Value
            txt_des.Text = ug_er.ActiveRow.Cells(1).Value
            Cambiar_Estado_Botones_Tool(ToolS_Mantenimiento)
            Call MostrarTabs(1, utc_er)
            txt_des.Focus()
            boton = False
        End If
    End Sub

    Private Sub Tool_Cancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_Cancelar.Click
        Call limpiar_controles()
        MostrarTabs(0, utc_er)
        Call Cambiar_Estado_Botones_Tool(ToolS_Mantenimiento)
    End Sub

    Private Sub Tool_Eliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_Eliminar.Click
        If ug_er.Rows.Count <= 0 Then
            MsgBox("Elija una Fila")
            Exit Sub
        End If
        If Preguntar("Esta seguro de eliminar?") Then
            Dim erBL As New BL.LogisticaBL.SG_LO_TB_ESTADO_REQUERIMIENTO
            Dim erBE As New BE.LogisticaBE.SG_LO_TB_ESTADO_REQUERIMIENTO
            erBE.id = ug_er.ActiveRow.Cells("ER_ID").Value
            erBE.empresa = gInt_IdEmpresa
            erBL.Delete(erBE)
            Avisar("Listo!")
            Call Inicializar_Estado_Botones_Tool(ToolS_Mantenimiento)
            Call cargar_grilla()
            MostrarTabs(0, utc_er)
            erBE = Nothing
            erBL = Nothing
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