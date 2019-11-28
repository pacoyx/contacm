Public Class HO_MA_PISO
    Dim boton As Boolean = False

    Private Sub HO_MA_PISO_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Call Cargar_Lista_Piso()
            Call Inicializar_Estado_Botones_Tool(ToolS_Mantenimiento)
            MostrarTabs(0, utc_Bancos)
        Catch ex As Exception
            Avisar(ex.Message)
        End Try
        
    End Sub

    Private Sub Tool_Nuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_Nuevo.Click
        Call limpiar_controles()
        Call Cambiar_Estado_Botones_Tool(ToolS_Mantenimiento)
        MostrarTabs(1, utc_Bancos)

        boton = True
        txt_codigo.Enabled = True
        txt_codigo.Focus()

    End Sub
    Public Sub limpiar_controles()
        txt_codigo.Text = ""
        txt_descripcion.Text = ""
    End Sub

    Private Sub Tool_Grabar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_Grabar.Click
        If txt_codigo.Text = "" Or txt_descripcion.Text = "" Then
            MsgBox("Falta completar datos")
            Exit Sub
        End If
        Call Cambiar_Estado_Botones_Tool(ToolS_Mantenimiento)
        Dim piBE As New BE.HospitalBE.SG_HO_TB_PISO
        Dim piBL As New BL.HospitalBL.SG_HO_TB_PISO
        If boton = True Then
            If piBL.getpii(gInt_IdEmpresa, Val(txt_codigo.Text)).Rows.Count > 0 Then
                MsgBox("Codigo ya Existente")
                Call limpiar_controles()
                MostrarTabs(0, utc_Bancos)
                Exit Sub
            End If
        End If
        With piBE
            .HO_ID = Val(txt_codigo.Text)
            .HO_DESCRIPCION = txt_descripcion.Text
            .HO_IDEMPRESA = gInt_IdEmpresa
        End With
        If boton Then
            piBL.Insert(piBE)
        Else
            piBL.Update(piBE)
        End If

        Call Avisar("Listo!")
        Call Cargar_Lista_Piso()
        MostrarTabs(0, utc_Bancos)

        piBE = Nothing
        piBL = Nothing

    End Sub
    Public Sub Cargar_Lista_Piso()
        Dim piBL As New BL.HospitalBL.SG_HO_TB_PISO
        Dim piBE As New BE.HospitalBE.SG_HO_TB_PISO
        udgv_piso.DataSource = piBL.getpi(gInt_IdEmpresa)
        piBE = Nothing
        piBL = Nothing
    End Sub

    Private Sub Tool_Cancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_Cancelar.Click
        Call Cambiar_Estado_Botones_Tool(ToolS_Mantenimiento)
        Call limpiar_controles()
        MostrarTabs(0, utc_Bancos)
    End Sub

    Private Sub Tool_Eliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_Eliminar.Click
        If udgv_piso.Rows.Count > 0 Then
            If Preguntar("Esta seguro de eliminar?") Then
                Dim piBL As New BL.HospitalBL.SG_HO_TB_PISO
                Dim piBE As New BE.HospitalBE.SG_HO_TB_PISO
                piBE.HO_ID = udgv_piso.ActiveRow.Cells("P_ID").Value
                piBE.HO_IDEMPRESA = gInt_IdEmpresa
                piBL.Delete(piBE)
                Avisar("Listo!")
                Call Cargar_Lista_Piso()
                piBE = Nothing
                piBL = Nothing
            End If
        End If
        Exit Sub
    End Sub

    Private Sub Tool_Salir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_Salir.Click
        Me.Close()
    End Sub

    Private Sub Tool_Editar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_Editar.Click
        If udgv_piso.Rows.Count > 0 Then
            Call Cambiar_Estado_Botones_Tool(ToolS_Mantenimiento)
            Call limpiar_controles()
            MostrarTabs(1, utc_Bancos)
            txt_codigo.Text = udgv_piso.ActiveRow.Cells("P_ID").Value
            txt_descripcion.Text = udgv_piso.ActiveRow.Cells("P_DESCRIPCION").Value
            boton = False
            txt_codigo.Enabled = False
            txt_descripcion.Focus()
        Else
            MsgBox("Elija una fila")
            Exit Sub
        End If
    End Sub
    Private Sub une_codigo_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_codigo.KeyDown
        If e.KeyCode = Keys.Enter Then
            txt_descripcion.Focus()
        End If
    End Sub

    Private Sub dgv_piso_CellContentDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs)
        If udgv_piso.Rows.Count = 0 Then Exit Sub
        Call Tool_Editar_Click(sender, e)
    End Sub

    Private Sub txt_codigo_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_codigo.KeyPress
        e.KeyChar = fKeyPress(e.KeyChar, txt_codigo.Text, 1)
        e.Handled = (e.KeyChar = "")
    End Sub
End Class