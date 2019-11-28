Public Class HO_MA_Tipo_Habitacion
    Dim boton As Boolean = False
    Private Sub Tool_Grabar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_Grabar.Click
        If txt_cod.Text = "" Or txt_des.Text = "" Then
            MsgBox("Falta completar datos")
            Exit Sub
        Else
            Dim thBE As New BE.HospitalBE.SG_HO_TB_TIPO_HABITACION
            Dim thBL As New BL.HospitalBL.SG_HO_TB_TIPO_HABITACION
            If boton = True Then
                If thBL.getthc(Val(txt_cod.Text), gInt_IdEmpresa).Rows.Count > 0 Then
                    MsgBox("Codigo ya existente ")
                    Exit Sub
                End If
            End If
            With thBE
                .HO_ID = Val(txt_cod.Text)
                .HO_DESCRIPCION = txt_des.Text
                .HO_CANTIDAD = Val(txt_cant.Text)
                .HO_PRECIO = Val(txt_precio.Text)
                .HO_ESTADO = IIf(rb_activo.Checked = True, 1, 0)
                .HO_IDEMPRESA = gInt_IdEmpresa
            End With
            If boton Then
                thBL.Insert(thBE)

            Else
                thBL.Update(thBE)
            End If

            Call Avisar("Listo!")
            Call Cambiar_Estado_Botones_Tool(ToolS_Mantenimiento)
            Call Cargar_Lista_th()
            Call MostrarTabs(0, utc_tipo_habi)

            thBE = Nothing
            thBL = Nothing
            End If

    End Sub

    Public Sub limpiar_controles()
        txt_cod.Text = ""
        txt_des.Text = ""
        txt_cant.Text = ""
        txt_precio.Text = "0.00"
        rb_activo.Checked = True
    End Sub
    Public Sub Cargar_Lista_th()
        Dim thBL As New BL.HospitalBL.SG_HO_TB_TIPO_HABITACION
        Dim thBE As New BE.HospitalBE.SG_HO_TB_TIPO_HABITACION
        udgv_tipo_habi.DataSource = thBL.getth(gInt_IdEmpresa)
        udgv_tipo_habi.DisplayLayout.Bands(0).Columns(0).Header.Caption = " Codigo"
        udgv_tipo_habi.DisplayLayout.Bands(0).Columns(1).Header.Caption = " Descripcion"
        udgv_tipo_habi.DisplayLayout.Bands(0).Columns(2).Header.Caption = " Cantidad"
        udgv_tipo_habi.DisplayLayout.Bands(0).Columns(3).Header.Caption = " Precio"
        udgv_tipo_habi.DisplayLayout.Bands(0).Columns(4).Hidden = True

        thBE = Nothing
        thBL = Nothing
    End Sub

    Private Sub Tool_Nuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_Nuevo.Click
        Call limpiar_controles()
        Call Cambiar_Estado_Botones_Tool(ToolS_Mantenimiento)
        Call MostrarTabs(1, utc_tipo_habi)

        boton = True
        txt_cod.Enabled = True
        txt_cod.Focus()

    End Sub

    Private Sub Tool_Editar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_Editar.Click
        If udgv_tipo_habi.Rows.Count > 0 Then
            Call Cambiar_Estado_Botones_Tool(ToolS_Mantenimiento)
            Call MostrarTabs(1, utc_tipo_habi)
            txt_cod.Text = udgv_tipo_habi.ActiveRow.Cells(0).Value
            txt_des.Text = udgv_tipo_habi.ActiveRow.Cells(1).Value
            txt_cant.Text = udgv_tipo_habi.ActiveRow.Cells(2).Value
            txt_precio.Text = udgv_tipo_habi.ActiveRow.Cells(3).Value
            If udgv_tipo_habi.ActiveRow.Cells(4).Value = 0 Then
                rb_inactivo.Checked = True
            Else
                rb_activo.Checked = True
            End If
            txt_cod.Enabled = False
            txt_des.Focus()
            boton = False
        Else
            MsgBox("Elija una fila")
            Exit Sub
        End If

    End Sub

    Private Sub Tool_Cancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_Cancelar.Click
        Call Cambiar_Estado_Botones_Tool(ToolS_Mantenimiento)
        Call limpiar_controles()
        Call MostrarTabs(0, utc_tipo_habi)
    End Sub

    Private Sub Tool_Eliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_Eliminar.Click
        If udgv_tipo_habi.Rows.Count > 0 Then
            If Preguntar("Esta seguro de eliminar?") Then
                Dim thBL As New BL.HospitalBL.SG_HO_TB_TIPO_HABITACION
                Dim thBE As New BE.HospitalBE.SG_HO_TB_TIPO_HABITACION
                thBE.HO_ID = udgv_tipo_habi.ActiveRow.Cells("P_ID").Value
                thBE.HO_IDEMPRESA = gInt_IdEmpresa
                thBL.Delete(thBE)
                Avisar("Listo!")
                Call Cargar_Lista_th()
                Call MostrarTabs(1, utc_tipo_habi)
                thBE = Nothing
                thBL = Nothing
            End If
        Else
            Exit Sub
        End If
        
    End Sub

    Private Sub Tool_Salir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_Salir.Click
        Me.Close()
    End Sub

    Private Sub HO_MA_Tipo_Habitacion_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Call Cargar_Lista_th()
            Call Inicializar_Estado_Botones_Tool(ToolS_Mantenimiento)
            Call MostrarTabs(0, utc_tipo_habi)
            Me.KeyPreview = True
        Catch ex As Exception
            Avisar(ex.Message)
        End Try
    End Sub

    Private Sub txt_cant_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_cant.KeyPress
        e.KeyChar = fKeyPress(e.KeyChar, txt_cant.Text, 1)
        e.Handled = (e.KeyChar = "")
    End Sub

    Private Sub txt_precio_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_precio.KeyPress
        e.KeyChar = fKeyPress(e.KeyChar, txt_precio.Text, 2)
        e.Handled = (e.KeyChar = "")
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