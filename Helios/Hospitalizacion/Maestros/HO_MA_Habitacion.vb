Public Class HO_MA_Habitacion
    Dim bol_nuevo As Boolean = False
    Private Sub HO_MA_Habitacion_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            gb_habitacion.Enabled = False
            Call cargar_grilla()
            Call Inicializar_Estado_Botones_Tool(ToolS_Mantenimiento)
            Dim hBL As New BL.HospitalBL.SG_HO_TB_PISO
            Dim thBL As New BL.HospitalBL.SG_HO_TB_TIPO_HABITACION
            rb_on.Checked = True
            cb_piso.DataSource = hBL.getpi(gInt_IdEmpresa)
            cb_piso.ValueMember = "P_ID"
            cb_piso.DisplayMember = "P_DESCRIPCION"
            hBL = Nothing

            cb_tipo_habitacion.DataSource = thBL.getth(gInt_IdEmpresa)
            cb_tipo_habitacion.ValueMember = "P_ID"
            cb_tipo_habitacion.DisplayMember = "P_DESCRIPCION"
            thBL = Nothing
            Me.KeyPreview = True
        Catch ex As Exception
            Avisar(ex.Message)
        End Try
    End Sub

    Private Sub Tool_Nuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_Nuevo.Click
        gb_habitacion.Enabled = True
        Call cargar_grilla()
        Call Limpiar_controles()
        Call Cambiar_Estado_Botones_Tool(ToolS_Mantenimiento)
        txt_codigo.Enabled = True
        txt_codigo.Focus()
        bol_nuevo = True
        gb_habitacion.Enabled = True
    End Sub
    Public Sub Limpiar_controles()
        txt_codigo.Text = ""
        txt_numero.Text = ""
        cb_piso.SelectedIndex = -1
        txt_descripcion.Text = ""
        cb_tipo_habitacion.SelectedIndex = -1
        If rb_off.Checked = True Then
            rb_on.Checked = True
        End If
    End Sub
    Public Sub cargar_grilla()
        Dim hBL As New BL.HospitalBL.SG_HO_TB_HABITACION
        Dim hBE As New BE.HospitalBE.SG_HO_TB_HABITACION
        'Dim tabla As New DataTable
        udgv_habi.DataSource = hBL.geth(gInt_IdEmpresa)
        udgv_habi.DisplayLayout.Bands(0).Columns(2).Hidden = True
        udgv_habi.DisplayLayout.Bands(0).Columns(5).Hidden = True
        udgv_habi.DisplayLayout.Bands(0).Columns(7).Hidden = True
        udgv_habi.DisplayLayout.Bands(0).Columns(0).Header.Caption = "Codigo"
        udgv_habi.DisplayLayout.Bands(0).Columns(1).Header.Caption = "Numero"
        udgv_habi.DisplayLayout.Bands(0).Columns(3).Header.Caption = "Piso"
        udgv_habi.DisplayLayout.Bands(0).Columns(4).Header.Caption = "Descripcion"
        udgv_habi.DisplayLayout.Bands(0).Columns(6).Header.Caption = "Tipo Habitacion"
        'dgv_habitacion.Rows.Clear()
        ''For i As Integer = 0 To tabla.Rows.Count - 1
        'dgv_habitacion.Rows.Add()
        'dgv_habitacion.Rows(i).Cells(0).Value = tabla.Rows(i)(0)
        'dgv_habitacion.Rows(i).Cells(1).Value = tabla.Rows(i)(1)
        'dgv_habitacion.Rows(i).Cells(2).Value = tabla.Rows(i)(2)
        'dgv_habitacion.Rows(i).Cells(3).Value = tabla.Rows(i)(3)
        'Next
        hBE = Nothing
        hBL = Nothing
    End Sub

    Private Sub Tool_Grabar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_Grabar.Click
        If txt_codigo.Text = "" Or cb_piso.SelectedIndex < 0 Or cb_tipo_habitacion.SelectedIndex < 0 Then
            MsgBox(" Falta completar ")
            Exit Sub
        End If
        Dim hBE As New BE.HospitalBE.SG_HO_TB_HABITACION
        Dim hBL As New BL.HospitalBL.SG_HO_TB_HABITACION
        If bol_nuevo = True Then
            If hBL.gethc(Val(txt_codigo.Text), gInt_IdEmpresa).Rows.Count > 0 Then
                MsgBox("Codigo ya existente ")
                gb_habitacion.Enabled = False
                Exit Sub
            End If
        End If
        With hBE
            .HO_ID = Val(txt_codigo.Text)
            .HO_NUMERO = Val(txt_numero.Text)
            .HO_PISO = cb_piso.SelectedValue
            .HO_DESCRIPCION = txt_descripcion.Text
            .HO_TIPO_HABITACION = cb_tipo_habitacion.SelectedValue
            .HO_ESTADO = IIf(rb_on.Checked = True, 1, 0)
            .HO_IDEMPRESA = gInt_IdEmpresa
        End With
        If bol_nuevo Then
            hBL.Insert(hBE)
        Else
            hBL.Update(hBE)
        End If
        Call Avisar("Listo!")
        Call Cambiar_Estado_Botones_Tool(ToolS_Mantenimiento)
        Call cargar_grilla()
        gb_habitacion.Enabled = False

        hBE = Nothing
        hBL = Nothing
    End Sub

    Private Sub Tool_Editar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_Editar.Click
        gb_habitacion.Enabled = True
        If udgv_habi.Rows.Count > 0 Then
            Call Cambiar_Estado_Botones_Tool(ToolS_Mantenimiento)
            txt_codigo.Text = udgv_habi.ActiveRow.Cells("P_CODIGO").Value
            txt_numero.Text = udgv_habi.ActiveRow.Cells("P_NUMERO").Value
            cb_piso.SelectedValue = udgv_habi.ActiveRow.Cells("P_PISO").Value
            txt_descripcion.Text = udgv_habi.ActiveRow.Cells(4).Value
            cb_tipo_habitacion.SelectedValue = udgv_habi.ActiveRow.Cells("P_TIPO_HABITACION").Value
            If udgv_habi.ActiveRow.Cells("P_ESTADO").Value = 0 Then
                rb_off.Checked = True
            Else
                rb_on.Checked = True
            End If
            bol_nuevo = False
            txt_codigo.Enabled = False
            txt_descripcion.Focus()
        Else
            MsgBox("No hay filas")
            Exit Sub
        End If
    End Sub

    Private Sub Tool_Cancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_Cancelar.Click
        Call Cambiar_Estado_Botones_Tool(ToolS_Mantenimiento)
        Call Limpiar_controles()
        gb_habitacion.Enabled = False
    End Sub

    Private Sub Tool_Eliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_Eliminar.Click
        If udgv_habi.Rows.Count > 0 Then
            If Preguntar("Esta seguro de eliminar?") Then
                gb_estado.Enabled = True
                Dim hBL As New BL.HospitalBL.SG_HO_TB_HABITACION
                Dim hBE As New BE.HospitalBE.SG_HO_TB_HABITACION
                hBE.HO_ID = udgv_habi.ActiveRow.Cells("P_CODIGO").Value
                hBE.HO_IDEMPRESA = gInt_IdEmpresa
                hBL.Delete(hBE)
                Avisar("Listo!")
                Call cargar_grilla()
                hBE = Nothing
                hBL = Nothing
            End If
        Else
            MsgBox("Elija una Fila")
            Exit Sub
        End If

    End Sub

    Private Sub Tool_Salir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_Salir.Click
        Me.Close()
    End Sub

    Private Sub txt_codigo_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_codigo.KeyPress
        e.KeyChar = fKeyPress(e.KeyChar, txt_codigo.Text, 1)
        e.Handled = (e.KeyChar = "")
    End Sub

    Private Sub txt_numero_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_numero.KeyPress
        e.KeyChar = fKeyPress(e.KeyChar, txt_codigo.Text, 1)
        e.Handled = (e.KeyChar = "")
    End Sub
    Private Sub pKeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Me.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Return) Then
            SendKeys.Send("{TAB}")
            e.Handled = True
        End If
    End Sub
End Class