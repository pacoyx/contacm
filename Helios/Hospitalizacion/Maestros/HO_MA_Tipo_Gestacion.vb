Public Class HO_MA_Tipo_Gestacion
    Dim bol_nuevo As Boolean = False
    Private Sub Tool_Nuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_Nuevo.Click
        Call Cambiar_Estado_Botones_Tool(ToolS_Mantenimiento)
        Call Limpiar_controles()
        Call cargar_grilla()
        gb_tipo_ges.Enabled = True
        txt_cod.Enabled = True
        bol_nuevo = True
        txt_cod.Focus()
    End Sub
    Public Sub Limpiar_controles()
        txt_cod.Text = ""
        txt_descripcion.Text = ""
    End Sub
    Public Sub cargar_grilla()
        Dim tipoBE As New BE.HospitalBE.SG_HO_TB_TIPO_GESTANTE
        Dim tipoBL As New BL.HospitalBL.SG_HO_TB_TIPO_GESTANTE
        udgv_tipo_ges.DataSource = tipoBL.get_Tipos(gInt_IdEmpresa)
        udgv_tipo_ges.DisplayLayout.Bands(0).Columns(0).Header.Caption = " Codigo"
        udgv_tipo_ges.DisplayLayout.Bands(0).Columns(1).Header.Caption = " Descripcion"
        tipoBE = Nothing
        tipoBL = Nothing
    End Sub

    Private Sub Tool_Grabar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_Grabar.Click
        If txt_cod.Text = "" Or txt_descripcion.Text = "" Then
            MsgBox("Falta Completar")
            Exit Sub
            txt_cod.Focus()
        End If
        Call Cambiar_Estado_Botones_Tool(ToolS_Mantenimiento)
        Dim tipoBE As New BE.HospitalBE.SG_HO_TB_TIPO_GESTANTE
        Dim tipoBL As New BL.HospitalBL.SG_HO_TB_TIPO_GESTANTE
        With tipoBE
            If bol_nuevo = True Then
                If tipoBL.get_Tiposc(Val(txt_cod.Text), gInt_IdEmpresa).Rows.Count > 0 Then
                    MsgBox("Codigo ya existente ")
                    Call Limpiar_controles()
                    gb_tipo_ges.Enabled = False
                    Exit Sub
                End If
            End If
            .ID = Val(txt_cod.Text)
            .DESCRIPCION = txt_descripcion.Text
            .IDEMPRESA = gInt_IdEmpresa
        End With
        If bol_nuevo = True Then
            tipoBL.insert(tipoBE)
        Else
            tipoBL.update(tipoBE)
        End If
        gb_tipo_ges.Enabled = False
        Call Avisar("Listo!")
        Call cargar_grilla()
        tipoBE = Nothing
        tipoBL = Nothing
    End Sub

    Private Sub Tool_Editar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_Editar.Click
        If udgv_tipo_ges.Rows.Count <= 0 Then
            MsgBox("Elija una fila")
            Exit Sub
        Else
            Call Cambiar_Estado_Botones_Tool(ToolS_Mantenimiento)
            gb_tipo_ges.Enabled = True
            txt_cod.Enabled = False
            txt_descripcion.Text = ""
            txt_cod.Text = udgv_tipo_ges.ActiveRow.Cells(0).Value
            txt_descripcion.Text = udgv_tipo_ges.ActiveRow.Cells(1).Value
            bol_nuevo = False
        End If
    End Sub

    Private Sub Tool_Cancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_Cancelar.Click
        Call Limpiar_controles()
        gb_tipo_ges.Enabled = True
        Call cargar_grilla()
        Call Cambiar_Estado_Botones_Tool(ToolS_Mantenimiento)
    End Sub

    Private Sub Tool_Eliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_Eliminar.Click
        If udgv_tipo_ges.Rows.Count <= 0 Then
            MsgBox("Elija una fila")
            Exit Sub
        Else
            If Preguntar("Esta seguro de eliminar?") Then
                Dim tipoBE As New BE.HospitalBE.SG_HO_TB_TIPO_GESTANTE
                Dim tipoBL As New BL.HospitalBL.SG_HO_TB_TIPO_GESTANTE
                tipoBE.ID = udgv_tipo_ges.ActiveRow.Cells(0).Value
                tipoBE.IDEMPRESA = gInt_IdEmpresa
                tipoBL.Delete(tipoBE)
                Avisar("Listo")
                Call cargar_grilla()
                tipoBE = Nothing
                tipoBL = Nothing
            End If
        End If
    End Sub

    Private Sub Tool_Salir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_Salir.Click
        Me.Close()
    End Sub

    Private Sub HO_MA_Tipo_Gestacion_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Call Inicializar_Estado_Botones_Tool(ToolS_Mantenimiento)
            Call cargar_grilla()
            gb_tipo_ges.Enabled = False
            Me.KeyPreview = True
        Catch ex As Exception
            Avisar(ex.Message)
        End Try
    End Sub

    Private Sub txt_cod_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_cod.KeyPress
        e.KeyChar = fKeyPress(e.KeyChar, txt_cod.Text, 1)
        e.Handled = (e.KeyChar = "")
    End Sub

    Private Sub pKeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Me.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Return) Then
            SendKeys.Send("{TAB}")
            e.Handled = True
        End If
    End Sub
End Class