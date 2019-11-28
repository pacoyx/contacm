Public Class AD_MA_Nacionalidad
    Dim boton As Boolean = False
    Private Sub AD_MA_Nacionalidad_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Call cargar_grilla()
            Call Inicializar_Estado_Botones_Tool(ToolS_Mantenimiento)
            Me.KeyPreview = True
            MostrarTabs(0, utc_naci)
        Catch ex As Exception
            Avisar(ex.Message)
        End Try
    End Sub

    Private Sub Tool_Nuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_Nuevo.Click
        Call Cambiar_Estado_Botones_Tool(ToolS_Mantenimiento)
        Call MostrarTabs(1, utc_naci)
        Call limpiar_controles()
        txt_cod.Enabled = True
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
        Dim naBL As New BL.AdmisionBL.SG_AD_TB_NACIONALIDAD
        Dim naBE As New BE.AdmisionBE.SG_AD_TB_NACIONALIDAD
        If boton = True Then
            If naBL.get_vali(txt_cod.Text, gInt_IdEmpresa).Rows.Count > 0 Then
                MsgBox("Codigo ya existente")
                Call limpiar_controles()
                txt_cod.Focus()
                Exit Sub
            End If
        End If
        With naBE
            .NA_ID = txt_cod.Text
            .NA_DESCRIPCION = txt_des.Text
            .NA_IDEMPRESA = gInt_IdEmpresa
        End With
        If boton = True Then
            naBL.Insert(naBE)
        Else
            naBL.Update(naBE)
            txt_cod.Enabled = True
        End If
        Call Avisar("Listo!")

        Call cargar_grilla()
        Call Cambiar_Estado_Botones_Tool(ToolS_Mantenimiento)
        Call MostrarTabs(0, utc_naci)
        naBE = Nothing
        naBL = Nothing
    End Sub
    Public Sub cargar_grilla()
        Dim naBL As New BL.AdmisionBL.SG_AD_TB_NACIONALIDAD
        Dim naBE As New BE.AdmisionBE.SG_AD_TB_NACIONALIDAD
        udg_naci.DataSource = naBL.getNacionalidades(gInt_IdEmpresa)
        udg_naci.DisplayLayout.Bands(0).Columns(0).Header.Caption = "Codigo"
        udg_naci.DisplayLayout.Bands(0).Columns(1).Header.Caption = "Descripcion"
        naBE = Nothing
        naBL = Nothing
    End Sub

    Private Sub Tool_Editar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_Editar.Click
        If udg_naci.Rows.Count <= 0 Then
            MsgBox("Elegir una fila")
            Exit Sub
        Else
            txt_cod.Text = udg_naci.ActiveRow.Cells(0).Value
            txt_des.Text = udg_naci.ActiveRow.Cells(1).Value
            txt_cod.Enabled = False
            txt_des.Focus()
            Cambiar_Estado_Botones_Tool(ToolS_Mantenimiento)
            Call MostrarTabs(1, utc_naci)
            boton = False
        End If
    End Sub

    Private Sub Tool_Cancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_Cancelar.Click
        Call limpiar_controles()
        MostrarTabs(0, utc_naci)
        Call Cambiar_Estado_Botones_Tool(ToolS_Mantenimiento)
    End Sub

    Private Sub Tool_Eliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_Eliminar.Click
        If udg_naci.Rows.Count <= 0 Then
            MsgBox("Elija una Fila")
            Exit Sub
        End If
        If Preguntar("Esta seguro de eliminar?") Then
            Dim naBL As New BL.AdmisionBL.SG_AD_TB_NACIONALIDAD
            Dim naBE As New BE.AdmisionBE.SG_AD_TB_NACIONALIDAD
            naBE.NA_ID = udg_naci.ActiveRow.Cells("NA_ID").Value
            naBE.NA_IDEMPRESA = gInt_IdEmpresa
            naBL.Delete(naBE)
            Avisar("Listo!")
            Call Inicializar_Estado_Botones_Tool(ToolS_Mantenimiento)
            Call cargar_grilla()
            MostrarTabs(0, utc_naci)
            naBL = Nothing
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
End Class