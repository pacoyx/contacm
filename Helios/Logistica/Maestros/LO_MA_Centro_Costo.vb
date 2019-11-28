Public Class LO_MA_Centro_Costo
    Dim Bol_Nuevo As Boolean = False
    Private Sub CO_MT_CentroCosto_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Call Cargar_Lista_CentroCostos()
            Call Formatear_Grilla_Selector(ug_cc)
            Call Inicializar_Estado_Botones_Tool(ToolS_Mantenimiento)
            Me.KeyPreview = True
        Catch ex As Exception
            Avisar(ex.Message)
        End Try
        
    End Sub

    Private Sub Cargar_Lista_CentroCostos()
        Dim ccBL As New BL.LogisticaBL.SG_LO_TB_CENTRO_COSTO
        Dim ccBE As New BE.LogisticaBE.SG_LO_TB_CENTRO_COSTO
        ccBE.CC_IDEMPRESA = gInt_IdEmpresa
        ug_cc.DataSource = ccBL.getcc(gInt_IdEmpresa)
        ccBE = Nothing
        ccBL = Nothing
    End Sub

    Private Sub Tool_Salir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_Salir.Click
        Me.Close()
    End Sub

    Private Sub Tool_Nuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_Nuevo.Click
        Call Cambiar_Estado_Botones_Tool(ToolS_Mantenimiento)
        Call limpiar_controles()
        Call MostrarTabs(1, utc_ccc, 1)

        Dim ccBL As New BL.LogisticaBL.SG_LO_TB_CENTRO_COSTO
        txt_cod.Text = ccBL.get_ult_cod_cc(gInt_IdEmpresa)
        ccBL = Nothing
        txt_cod.Enabled = True
        txt_des.Focus()
        Bol_Nuevo = True
    End Sub

    Private Sub Tool_Eliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_Eliminar.Click
        If ug_cc.Rows.Count > 0 Then
            If Preguntar("Esta seguro de eliminar?") Then
                Dim ccBL As New BL.LogisticaBL.SG_LO_TB_CENTRO_COSTO
                Dim ccBE As New BE.LogisticaBE.SG_LO_TB_CENTRO_COSTO
                ccBE.CC_ID = ug_cc.ActiveRow.Cells("CC_ID").Value
                ccBE.CC_IDEMPRESA = gInt_IdEmpresa
                ccBL.Delete(ccBE)
                Avisar("Listo!")
                Call Cargar_Lista_CentroCostos()
                ccBE = Nothing
                ccBL = Nothing
            End If
        Else
            MsgBox("Elija una Fila")
            Exit Sub
        End If
    End Sub

    Private Sub Tool_Cancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_Cancelar.Click
        Call Cambiar_Estado_Botones_Tool(ToolS_Mantenimiento)
        Call MostrarTabs(0, utc_ccc, 0)
        Call limpiar_controles()
        Call MostrarTabs(0, utc_ccc, 1)
    End Sub
    Public Sub limpiar_controles()
        txt_cod.Text = ""
        txt_des.Text = ""
    End Sub
    Private Sub Tool_Grabar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_Grabar.Click
        Dim ccBL As New BL.LogisticaBL.SG_LO_TB_CENTRO_COSTO
        Dim ccBE As New BE.LogisticaBE.SG_LO_TB_CENTRO_COSTO
        If Bol_Nuevo = True Then
            If ccBL.get_val(Val(txt_cod.Text), gInt_IdEmpresa).Rows.Count > 0 Then
                MsgBox("Codigo Existente")
                Call limpiar_controles()
                txt_cod.Focus()
                Exit Sub
            End If
        End If
        If txt_cod.Text = "" Or txt_des.Text = "" Then
            MsgBox("Falta Completar")
            Exit Sub
        Else
            With ccBE
                .CC_ID = Val(txt_cod.Text)
                .CC_DESCRIPCION = txt_des.Text
                .CC_IDEMPRESA = gInt_IdEmpresa
            End With

            If Bol_Nuevo Then
                ccBL.Insert(ccBE)
            Else
                ccBL.Update(ccBE)
            End If
        End If
       

        Call Avisar("Listo!")
        Call Cargar_Lista_CentroCostos()
        Call Tool_Cancelar_Click(sender, e)

        ccBE = Nothing
        ccBL = Nothing

    End Sub

    Private Sub Tool_Editar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_Editar.Click
        If ug_cc.Rows.Count = 0 Then
            MsgBox("Elija Fila")
            Exit Sub
        End If
        Call Cambiar_Estado_Botones_Tool(ToolS_Mantenimiento)
        Call limpiar_controles()
        Call MostrarTabs(1, utc_ccc, 1)

        txt_cod.Text = ug_cc.ActiveRow.Cells("CC_ID").Value
        txt_des.Text = ug_cc.ActiveRow.Cells("CC_DESCRIPCION").Value

        Bol_Nuevo = False
        txt_cod.Enabled = False
        txt_des.Focus()

    End Sub

    Private Sub ug_cc_DoubleClickRow(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.DoubleClickRowEventArgs) Handles ug_cc.DoubleClickRow
        If ug_cc.Rows.Count = 0 Then Exit Sub
        Call Tool_Editar_Click(sender, e)
    End Sub

    Private Sub une_codigo_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        If e.KeyCode = Keys.Enter Then
            txt_des.Focus()
        End If
    End Sub
    Private Sub pKeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Me.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Return) Then
            SendKeys.Send("{TAB}")
            e.Handled = True
        End If
    End Sub

    Private Sub txt_cod_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        e.KeyChar = fKeyPress(e.KeyChar, txt_cod.Text, 1)
        e.Handled = (e.KeyChar = "")
    End Sub
End Class