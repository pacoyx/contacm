Public Class LO_MA_Area
    Dim Bol_Nuevo As Boolean = False
    Private Sub CO_MT_Area_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Call Cargar_Lista_Area()
            Call Formatear_Grilla_Selector(ug_ar)
            Call Inicializar_Estado_Botones_Tool(ToolS_Mantenimiento)
            Cargar_Lista_CentroCosto()
            Me.KeyPreview = True
            MostrarTabs(0, utc_ar)
        Catch ex As Exception
            Avisar(ex.Message)
        End Try
    End Sub

    Private Sub Cargar_Lista_Area()
        Dim arBL As New BL.LogisticaBL.SG_LO_TB_AREA
        Dim arBE As New BE.LogisticaBE.SG_LO_TB_AREA
        arBE.AR_IDEMPRESA = gInt_IdEmpresa
        ug_ar.DataSource = arBL.getar(gInt_IdEmpresa)
        arBE = Nothing
        arBL = Nothing
    End Sub

    Private Sub Cargar_Lista_CentroCosto()
        Dim arBL As New BL.LogisticaBL.SG_LO_TB_CENTRO_COSTO
        Dim arBE As New BE.LogisticaBE.SG_LO_TB_CENTRO_COSTO
        ucbo_CentroCosto.DataSource = arBL.getcc(gInt_IdEmpresa)
        ucbo_CentroCosto.DisplayMember = "CC_DESCRIPCION"
        ucbo_CentroCosto.ValueMember = "CC_ID"
        arBE = Nothing
        arBL = Nothing
    End Sub

    Private Sub Tool_Salir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_Salir.Click
        Me.Close()
    End Sub
    Public Sub Limpiar_Controles()
        txt_cod.Text = ""
        txt_des.Text = ""
    End Sub
    Private Sub Tool_Nuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_Nuevo.Click
        Call Cambiar_Estado_Botones_Tool(ToolS_Mantenimiento)
        Call Limpiar_Controles()
        Call MostrarTabs(1, utc_ar, 1)
        'Dim arBL As New BL.LogisticaBL.SG_LO_TB_AREA
        'Dim arBE As New BE.LogisticaBE.SG_LO_TB_AREA
        'une_codigo.Value = ccBL.get_Generar_Codigo_CC(gInt_IdEmpresa)
        'arBE = Nothing
        'arBL = Nothing
        Bol_Nuevo = True
        txt_cod.Enabled = False

        Dim arBL As New BL.LogisticaBL.SG_LO_TB_AREA
        txt_cod.Text = arBL.get_ult_codigo(gInt_IdEmpresa)
        arBL = Nothing

        txt_des.Focus()
    End Sub



    Private Sub Tool_Eliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_Eliminar.Click
        If ug_ar.Rows.Count > 0 Then
            If Preguntar("Esta seguro de eliminar?") Then
                Dim arBL As New BL.LogisticaBL.SG_LO_TB_AREA
                Dim arBE As New BE.LogisticaBE.SG_LO_TB_AREA
                arBE.AR_ID = ug_ar.ActiveRow.Cells("AR_ID").Value
                arBE.AR_IDEMPRESA = gInt_IdEmpresa
                arBL.Delete(arBE)
                Avisar("Listo!")
                Call Cargar_Lista_Area()
                arBE = Nothing
                arBL = Nothing
            End If
        Else
            MsgBox("Elija una Fila")
            Exit Sub
        End If
    End Sub

    Private Sub Tool_Cancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_Cancelar.Click
        Call Cambiar_Estado_Botones_Tool(ToolS_Mantenimiento)
        Call MostrarTabs(0, utc_ar, 0)
        Call Limpiar_Controles()
    End Sub

    Private Sub Tool_Grabar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_Grabar.Click
        Dim arBL As New BL.LogisticaBL.SG_LO_TB_AREA
        Dim arBE As New BE.LogisticaBE.SG_LO_TB_AREA
        If txt_cod.Text = "" And txt_des.Text = "" Then
            Avisar("Falta Completar")
            Exit Sub
        Else
            If Bol_Nuevo = True Then
                If arBL.get_val(txt_cod.Text, gInt_IdEmpresa).Rows.Count > 0 Then
                    MsgBox("Codigo ya existente")
                    Exit Sub
                End If
            End If
            With arBE
                .AR_ID = txt_cod.Text
                .AR_DESCRIPCION = txt_des.Text
                .AR_IDEMPRESA = gInt_IdEmpresa
                .AR_IDCentroCosto = ucbo_CentroCosto.Value
            End With

            If Bol_Nuevo Then
                arBL.Insert(arBE)
            Else
                arBL.Update(arBE)
            End If

        End If

        Call Avisar("Listo!")
        Call Cargar_Lista_Area()
        Call Tool_Cancelar_Click(sender, e)

        arBE = Nothing
        arBL = Nothing

    End Sub

    Private Sub Tool_Editar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_Editar.Click
        If ug_ar.Rows.Count <= 0 Then
            MsgBox("Elegir una fila")
            Exit Sub
        Else
            txt_cod.Text = ug_ar.ActiveRow.Cells("AR_ID").Value
            txt_des.Text = ug_ar.ActiveRow.Cells("AR_DESCRIPCION").Value
            ucbo_CentroCosto.Value = ug_ar.ActiveRow.Cells("AR_IDCentroCosto").Value
            Call Cambiar_Estado_Botones_Tool(ToolS_Mantenimiento)
            Call MostrarTabs(1, utc_ar, 1)
            txt_cod.Enabled = False
            txt_des.Focus()
            Bol_Nuevo = False
        End If
    End Sub

    Private Sub ug_cc_DoubleClickRow(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.DoubleClickRowEventArgs) Handles ug_ar.DoubleClickRow
        If ug_ar.Rows.Count = 0 Then Exit Sub
        Call Tool_Editar_Click(sender, e)
    End Sub
    Private Sub pKeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Me.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Return) Then
            SendKeys.Send("{TAB}")
            e.Handled = True
        End If
    End Sub
End Class