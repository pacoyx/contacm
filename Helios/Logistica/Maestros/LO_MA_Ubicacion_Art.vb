Public Class LO_MA_Ubicacion_Art
    Dim boton As Boolean = False
    Private Sub LO_MA_Ubicacion_Art_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Call cargar_grilla()
            Call Inicializar_Estado_Botones_Tool(ToolS_Mantenimiento)
            Me.KeyPreview = True
            MostrarTabs(0, utc_ua)
        Catch ex As Exception
            Avisar(ex.Message)
        End Try
    End Sub

    Private Sub Tool_Nuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_Nuevo.Click
        Call Cambiar_Estado_Botones_Tool(ToolS_Mantenimiento)
        Call MostrarTabs(1, utc_ua)
        Call limpiar_controles()
        txt_cod.Enabled = False
        Dim uaBL As New BL.LogisticaBL.SG_LO_TB_UBICACION_ART
        txt_cod.Text = uaBL.get_ult_codigo_Ubic(gInt_IdEmpresa)
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
        Dim uaBL As New BL.LogisticaBL.SG_LO_TB_UBICACION_ART
        Dim uaBE As New BE.LogisticaBE.SG_LO_TB_UBICACION_ART
        If boton = True Then
            If uaBL.get_val(gInt_IdEmpresa, txt_cod.Text).Rows.Count > 0 Then
                MsgBox("Codigo ya existente")
                Call limpiar_controles()
                txt_cod.Focus()
                Exit Sub
            End If
        End If
        With uaBE
            .id = txt_cod.Text
            .descripcion = txt_des.Text
            .empresa = gInt_IdEmpresa
        End With
        If boton = True Then
            uaBL.Insert(uaBE)
        Else
            uaBL.Update(uaBE)
            txt_cod.Enabled = True
        End If
        Call Avisar("Listo!")

        Call cargar_grilla()
        Call Cambiar_Estado_Botones_Tool(ToolS_Mantenimiento)
        Call MostrarTabs(0, utc_ua)
        uaBE = Nothing
        uaBL = Nothing
    End Sub
    Public Sub cargar_grilla()
        Dim uaBL As New BL.LogisticaBL.SG_LO_TB_UBICACION_ART
        Dim uaBE As New BE.LogisticaBE.SG_LO_TB_UBICACION_ART
        udg_ua.DataSource = uaBL.get_grilla(gInt_IdEmpresa)
        udg_ua.DisplayLayout.Bands(0).Columns(0).Header.Caption = "Codigo"
        udg_ua.DisplayLayout.Bands(0).Columns(1).Header.Caption = "Descripcion"
        udg_ua.DisplayLayout.Bands(0).Columns(2).Hidden = True
        uaBE = Nothing
        uaBL = Nothing
    End Sub

    Private Sub Tool_Editar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_Editar.Click
        If udg_ua.Rows.Count <= 0 Then
            MsgBox("Elegir una fila")
            Exit Sub
        Else
            txt_cod.Text = udg_ua.ActiveRow.Cells(0).Value
            txt_des.Text = udg_ua.ActiveRow.Cells(1).Value
            txt_cod.Enabled = False
            txt_des.Focus()
            Cambiar_Estado_Botones_Tool(ToolS_Mantenimiento)
            Call MostrarTabs(1, utc_ua)
            boton = False
        End If
    End Sub

    Private Sub Tool_Cancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_Cancelar.Click
        Call limpiar_controles()
        MostrarTabs(0, utc_ua)
        Call Cambiar_Estado_Botones_Tool(ToolS_Mantenimiento)
    End Sub

    Private Sub Tool_Eliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_Eliminar.Click
        If udg_ua.Rows.Count <= 0 Then
            MsgBox("Elija una Fila")
            Exit Sub
        End If
        If Preguntar("Esta seguro de eliminar?") Then
            Dim uaBL As New BL.LogisticaBL.SG_LO_TB_UBICACION_ART
            Dim uaBE As New BE.LogisticaBE.SG_LO_TB_UBICACION_ART
            uaBE.id = udg_ua.ActiveRow.Cells("UA_ID").Value
            uaBE.empresa = gInt_IdEmpresa
            uaBL.Delete(uaBE)
            Avisar("Listo!")
            Call Inicializar_Estado_Botones_Tool(ToolS_Mantenimiento)
            Call cargar_grilla()
            MostrarTabs(0, utc_ua)
            uaBE = Nothing
            uaBL = Nothing
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