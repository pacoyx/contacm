Public Class AD_MA_CentroCosto
    Dim bol_nuevo As Boolean = False
    Private Sub Tool_Nuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_Nuevo.Click
        Call Cambiar_Estado_Botones_Tool(ToolS_Mantenimiento)
        Call MostrarTabs(1, utc_Consultorios)
        Call limpiar_controles()
        txt_id.Enabled = True
        txt_id.Focus()
        bol_nuevo = True
    End Sub
    Private Sub AD_MA_CentroCosto_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Call cargar_grilla()
            Call Inicializar_Estado_Botones_Tool(ToolS_Mantenimiento)
            Me.KeyPreview = True
            MostrarTabs(0, utc_Consultorios)
            Dim cc_conta As New BL.ContabilidadBL.SG_CO_TB_CENTROCOSTO
            uc_idcc.DataSource = cc_conta.get_combo(gInt_IdEmpresa)
            uc_idcc.ValueMember = "CC_CODIGO"
            uc_idcc.DisplayMember = "CC_DESCRIPCION"
        Catch ex As Exception
            Avisar(ex.Message)
        End Try
    End Sub
    Public Sub limpiar_controles()
        txt_id.Text = ""
        txt_Descripcion.Text = ""
        txt_DesCorto.Text = ""
        uc_idcc.SelectedIndex = -1
    End Sub

    Private Sub Tool_Grabar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_Grabar.Click
        If txt_id.Text = "" Or txt_DesCorto.Text = "" Or txt_Descripcion.Text = "" Then
            MsgBox("Falta completar")
            Exit Sub
        End If
        Dim ccBL As New BL.AdmisionBL.SG_AD_TB_Centro_Costo
        Dim ccBE As New BE.AdmisionBE.SG_AD_TB_CENTRO_COSTO
        If bol_nuevo = True Then
            If ccBL.get_val(txt_id.Text, gInt_IdEmpresa).Rows.Count > 0 Then
                MsgBox("Codigo ya existente")
                Call limpiar_controles()
                txt_id.Focus()
                Exit Sub
            End If
        End If
        With ccBE
            .id = txt_id.Text
            .abreviatura = txt_DesCorto.Text
            .descripcion = txt_Descripcion.Text
            .idcc_conta = uc_idcc.SelectedValue
            .usuario = String.Format("{0}-{1}", Environment.UserName, gStr_Usuario_Sis)
            .terminal = Environment.MachineName
            .fecreg = Date.Now
            .idempresa = gInt_IdEmpresa
        End With
        If bol_nuevo = True Then
            ccBL.insert(ccBE)
        Else
            ccBL.update(ccBE)
            txt_id.Enabled = True
        End If
        Call Avisar("Listo!")

        Call cargar_grilla()
        Call Cambiar_Estado_Botones_Tool(ToolS_Mantenimiento)
        Call MostrarTabs(0, utc_Consultorios)
        ccBE = Nothing
        ccBL = Nothing
    End Sub
    Public Sub cargar_grilla()
        Dim ccBL As New BL.AdmisionBL.SG_AD_TB_Centro_Costo
        Dim ccBE As New BE.AdmisionBE.SG_AD_TB_CENTRO_COSTO
        ug_Consultorio.DataSource = ccBL.get_grilla(gInt_IdEmpresa)
        ug_Consultorio.DisplayLayout.Bands(0).Columns(0).Header.Caption = "Codigo"
        ug_Consultorio.DisplayLayout.Bands(0).Columns(1).Header.Caption = "Descripcion"
        ug_Consultorio.DisplayLayout.Bands(0).Columns(2).Header.Caption = "Abreviatura"
        ug_Consultorio.DisplayLayout.Bands(0).Columns(3).Hidden = True
        ug_Consultorio.DisplayLayout.Bands(0).Columns(4).Hidden = True
        ug_Consultorio.DisplayLayout.Bands(0).Columns(5).Hidden = True
        ug_Consultorio.DisplayLayout.Bands(0).Columns(6).Hidden = True
        ug_Consultorio.DisplayLayout.Bands(0).Columns(7).Hidden = True
        ccBE = Nothing
        ccBL = Nothing
    End Sub

    Private Sub Tool_Editar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_Editar.Click
        If ug_Consultorio.Rows.Count <= 0 Then
            MsgBox("Elegir una fila")
            Exit Sub
        Else
            txt_id.Text = ug_Consultorio.ActiveRow.Cells(0).Value
            txt_Descripcion.Text = ug_Consultorio.ActiveRow.Cells(1).Value
            txt_DesCorto.Text = ug_Consultorio.ActiveRow.Cells(2).Value
            txt_id.Enabled = False
            txt_DesCorto.Focus()
            Cambiar_Estado_Botones_Tool(ToolS_Mantenimiento)
            Call MostrarTabs(1, utc_Consultorios)
            bol_nuevo = False
        End If
    End Sub

    Private Sub Tool_Cancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_Cancelar.Click
        Call limpiar_controles()
        MostrarTabs(0, utc_Consultorios)
        Call Cambiar_Estado_Botones_Tool(ToolS_Mantenimiento)
    End Sub

    Private Sub Tool_Eliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_Eliminar.Click
        If ug_Consultorio.Rows.Count <= 0 Then
            MsgBox("Elija una Fila")
            Exit Sub
        End If
        If Preguntar("Esta seguro de eliminar?") Then
            Dim ccBL As New BL.AdmisionBL.SG_AD_TB_Centro_Costo
            Dim ccBE As New BE.AdmisionBE.SG_AD_TB_CENTRO_COSTO
            ccBE.id = ug_Consultorio.ActiveRow.Cells("CC_CODIGO").Value
            ccBE.idempresa = gInt_IdEmpresa
            ccBL.delete(ccBE)
            Avisar("Listo!")
            Call Inicializar_Estado_Botones_Tool(ToolS_Mantenimiento)
            Call cargar_grilla()
            MostrarTabs(0, utc_Consultorios)
            ccBE = Nothing
            ccBL = Nothing
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