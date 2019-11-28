Public Class LO_MA_Estado_Documento
    Dim boton As Boolean = False
    Private Sub LO_MA_Estado_Documento_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Call cargar_grilla()
            Call Inicializar_Estado_Botones_Tool(ToolS_Mantenimiento)
            Me.KeyPreview = True
            MostrarTabs(0, utc_ed)
        Catch ex As Exception
            Avisar(ex.Message)
        End Try
    End Sub

    Private Sub Tool_Nuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_Nuevo.Click
        Call Cambiar_Estado_Botones_Tool(ToolS_Mantenimiento)
        Call MostrarTabs(1, utc_ed)
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
        Dim edBL As New BL.LogisticaBL.SG_LO_TB_ESTADO_DOCU
        Dim edBE As New BE.LogisticaBE.SG_LO_TB_ESTADO_DOCU
        If boton = True Then
            If edBL.get_edval(gInt_IdEmpresa, txt_cod.Text).Rows.Count > 0 Then
                MsgBox("Codigo ya existente")
                Call limpiar_controles()
                txt_cod.Focus()
                Exit Sub
            End If
        End If
        With edBE
            .id = txt_cod.Text
            .descripcion = txt_des.Text
            .empresa = gInt_IdEmpresa
        End With
        If boton = True Then
            edBL.insert(edBE)
        Else
            edBL.update(edBE)
            txt_cod.Enabled = True
        End If
        Call Avisar("Listo!")

        Call cargar_grilla()
        Call Cambiar_Estado_Botones_Tool(ToolS_Mantenimiento)
        Call MostrarTabs(0, utc_ed)
        edBE = Nothing
        edBL = Nothing
    End Sub
    Public Sub cargar_grilla()
        Dim edBL As New BL.LogisticaBL.SG_LO_TB_ESTADO_DOCU
        Dim edBE As New BE.LogisticaBE.SG_LO_TB_ESTADO_DOCU
        udg_ed.DataSource = edBL.get_edgrilla(gInt_IdEmpresa)
        udg_ed.DisplayLayout.Bands(0).Columns(0).Header.Caption = "Codigo"
        udg_ed.DisplayLayout.Bands(0).Columns(1).Header.Caption = "Descripcion"
        udg_ed.DisplayLayout.Bands(0).Columns(2).Hidden = True
        edBE = Nothing
        edBL = Nothing
    End Sub

    Private Sub Tool_Editar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_Editar.Click
        If udg_ed.Rows.Count <= 0 Then
            MsgBox("Elegir una fila")
            Exit Sub
        Else
            txt_cod.Text = udg_ed.ActiveRow.Cells(0).Value
            txt_des.Text = udg_ed.ActiveRow.Cells(1).Value
            txt_cod.Enabled = False
            txt_des.Focus()
            Cambiar_Estado_Botones_Tool(ToolS_Mantenimiento)
            Call MostrarTabs(1, utc_ed)
            boton = False
        End If
    End Sub

    Private Sub Tool_Cancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_Cancelar.Click
        Call limpiar_controles()
        MostrarTabs(0, utc_ed)
        Call Cambiar_Estado_Botones_Tool(ToolS_Mantenimiento)
    End Sub

    Private Sub Tool_Eliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_Eliminar.Click
        If udg_ed.Rows.Count <= 0 Then
            MsgBox("Elija una Fila")
            Exit Sub
        End If
        If Preguntar("Esta seguro de eliminar?") Then
            Dim edBL As New BL.LogisticaBL.SG_LO_TB_ESTADO_DOCU
            Dim edBE As New BE.LogisticaBE.SG_LO_TB_ESTADO_DOCU
            edBE.id = udg_ed.ActiveRow.Cells("ED_ID").Value
            edBE.empresa = gInt_IdEmpresa
            edBL.delete(edBE)
            Avisar("Listo!")
            Call Inicializar_Estado_Botones_Tool(ToolS_Mantenimiento)
            Call cargar_grilla()
            MostrarTabs(0, utc_ed)
            edBE = Nothing
            edBL = Nothing
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