Public Class HO_MA_CAMA
    Dim bol_nuevo As Boolean = False
    Private Sub Tool_Nuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_Nuevo.Click
        Call Cambiar_Estado_Botones_Tool(ToolS_Mantenimiento)
        Call Limpiar_controles()
        Call cargar_grilla()
        gb_cama.Enabled = True
        bol_nuevo = True
        txt_cod.Focus()
    End Sub
    Public Sub limpiar_controles()
        txt_cod.Text = ""
        txt_numero.Text = ""
        txt_descripcion.Text = ""
        cb_habitacion.SelectedIndex = -1
        rb_disponible.Checked = True
    End Sub
    Public Sub cargar_grilla()
        Dim camaBE As New BE.HospitalBE.SG_HO_TB_CAMA
        Dim camaBL As New BL.HospitalBL.SG_HO_TB_CAMA
        dgv_cama.DataSource = camaBL.getcama(gInt_IdEmpresa)
        dgv_cama.DisplayLayout.Bands(0).Columns(0).Header.Caption = "Codigo"
        dgv_cama.DisplayLayout.Bands(0).Columns(1).Header.Caption = "Numero"
        dgv_cama.DisplayLayout.Bands(0).Columns(2).Header.Caption = "Descripcion"
        dgv_cama.DisplayLayout.Bands(0).Columns(3).Header.Caption = "Habitacion"
        dgv_cama.DisplayLayout.Bands(0).Columns(4).Hidden = True
        dgv_cama.DisplayLayout.Bands(0).Columns(5).Hidden = True
        'ug_Anexos.Rows(i).Cells("AN_DESCRIPCION").Value = anexo.AN_DESCRIPCION
        camaBE = Nothing
        camaBL = Nothing
    End Sub

    Private Sub Tool_Grabar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_Grabar.Click
        If txt_cod.Text = "" Or txt_numero.Text = "" Or txt_descripcion.Text = "" Or cb_habitacion.SelectedIndex = -1 Then
            MsgBox("Falta Completar")
            Exit Sub
            txt_cod.Focus()
        End If
        Call Cambiar_Estado_Botones_Tool(ToolS_Mantenimiento)
        Dim camaBE As New BE.HospitalBE.SG_HO_TB_CAMA
        Dim camaBL As New BL.HospitalBL.SG_HO_TB_CAMA
        With camaBE
            If bol_nuevo = True Then
                If camaBL.getccama(Val(txt_cod.Text), gInt_IdEmpresa).Rows.Count > 0 Then
                    MsgBox("Codigo ya existente ")
                    Call limpiar_controles()
                    gb_cama.Enabled = False
                    Exit Sub
                End If
            End If
            .CODIGO = Val(txt_cod.Text)
            .NUMERO = Val(txt_numero.Text)
            .DESCRIPCION = txt_descripcion.Text
            .HABITACION = cb_habitacion.Value
            If rb_disponible.Checked = True Then .ESTADO = 1
            If rb_mantenimiento.Checked = True Then .ESTADO = 0
            If rb_reservada.Checked = True Then .ESTADO = 2
            .IDEMPRESA = gInt_IdEmpresa
        End With
        If bol_nuevo = True Then
            camaBL.Insert(camaBE)
        Else
            camaBL.Update(camaBE)
        End If
        gb_cama.Enabled = False
        Call Avisar("Listo!")
        Call cargar_grilla()
        camaBE = Nothing
        camaBL = Nothing
    End Sub

    Private Sub Tool_Editar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_Editar.Click
        If dgv_cama.Rows.Count <= 0 Then
            MsgBox("Elija una fila")
            Exit Sub
        Else
            Call Cambiar_Estado_Botones_Tool(ToolS_Mantenimiento)
            gb_cama.Enabled = True
            txt_cod.Enabled = False
            txt_numero.Text = ""
            txt_descripcion.Text = ""
            cb_habitacion.SelectedIndex = -1
            rb_disponible.Checked = True
            txt_cod.Text = dgv_cama.ActiveRow.Cells(0).Value
            txt_numero.Text = dgv_cama.ActiveRow.Cells(1).Value
            txt_descripcion.Text = dgv_cama.ActiveRow.Cells(2).Value
            cb_habitacion.Value = dgv_cama.ActiveRow.Cells(3).Value
            If dgv_cama.ActiveRow.Cells(4).Value = 0 Then rb_mantenimiento.Checked = True
            If dgv_cama.ActiveRow.Cells(4).Value = 1 Then rb_disponible.Checked = True
            If dgv_cama.ActiveRow.Cells(4).Value = 2 Then rb_reservada.Checked = True
            bol_nuevo = False
        End If
    End Sub

    Private Sub Tool_Cancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_Cancelar.Click
        Call limpiar_controles()
        gb_cama.Enabled = True
        Call cargar_grilla()
        Call Cambiar_Estado_Botones_Tool(ToolS_Mantenimiento)
    End Sub

    Private Sub Tool_Eliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_Eliminar.Click
        If dgv_cama.Rows.Count <= 0 Then
            MsgBox("Elija una fila")
            Exit Sub
        Else
            If Preguntar("Esta seguro de eliminar?") Then
                Dim camaBE As New BE.HospitalBE.SG_HO_TB_CAMA
                Dim camaBL As New BL.HospitalBL.SG_HO_TB_CAMA
                camaBE.CODIGO = dgv_cama.ActiveRow.Cells(0).Value
                camaBE.IDEMPRESA = gInt_IdEmpresa
                camaBL.Delete(camaBE)
                Avisar("Listo")
                Call cargar_grilla()
                camaBE = Nothing
                camaBL = Nothing
            End If
        End If
    End Sub

    Private Sub Tool_Salir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_Salir.Click
        Me.Close()
    End Sub

    Private Sub HO_MA_CAMA_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Call Inicializar_Estado_Botones_Tool(ToolS_Mantenimiento)
            Call cargar_grilla()
            gb_cama.Enabled = False
            Dim camaBE As New BE.HospitalBE.SG_HO_TB_HABITACION
            Dim camaBL As New BL.HospitalBL.SG_HO_TB_HABITACION
            cb_habitacion.DataSource = camaBL.geth(gInt_IdEmpresa)
            cb_habitacion.ValueMember = "P_CODIGO"
            cb_habitacion.DisplayMember = "P_DESCRIPCION"
            camaBE = Nothing
            camaBL = Nothing
            Me.KeyPreview = True
        Catch ex As Exception
            Avisar(ex.Message)
        End Try
        
    End Sub

    Private Sub txt_cod_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_cod.KeyPress
        e.KeyChar = fKeyPress(e.KeyChar, txt_cod.Text, 1)
        e.Handled = (e.KeyChar = "")
    End Sub

    Private Sub txt_numero_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_numero.KeyPress
        e.KeyChar = fKeyPress(e.KeyChar, txt_numero.Text, 102)
        e.Handled = (e.KeyChar = "")
    End Sub
    Private Sub pKeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Me.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Return) Then
            SendKeys.Send("{TAB}")
            e.Handled = True
        End If
    End Sub

End Class