Public Class LO_MA_Uni_Med
    Dim boton As Boolean = False
    Private Sub LO_MA_Uni_Med_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Call cargar_grilla()
        Call Formatear_Grilla_Selector(udg_um)

        Call Inicializar_Estado_Botones_Tool(ToolS_Mantenimiento)
        Me.KeyPreview = True
        MostrarTabs(0, utc_um)

    End Sub

    Private Sub Tool_Nuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_Nuevo.Click
        Call Cambiar_Estado_Botones_Tool(ToolS_Mantenimiento)
        Call MostrarTabs(1, utc_um)
        Call limpiar_controles()
        txt_cod.Enabled = True
        txt_cod.Focus()
        boton = True
    End Sub
    Public Sub limpiar_controles()
        txt_cod.Text = ""
        txt_des.Text = ""
        txt_abre.Text = ""
    End Sub

    Private Sub Tool_Grabar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_Grabar.Click
        If txt_cod.Text = "" Or txt_des.Text = "" Or txt_abre.Text = "" Then
            MsgBox("Falta completar")
            Exit Sub
        End If
        Dim umBL As New BL.LogisticaBL.SG_LO_TB_UNI_MED
        Dim umBE As New BE.LogisticaBE.SG_LO_TB_UNI_MED
        If boton = True Then
            If umBL.get_val(gInt_IdEmpresa, txt_cod.Text).Rows.Count > 0 Then
                MsgBox("Codigo ya existente")
                Call limpiar_controles()
                txt_cod.Focus()
                Exit Sub
            End If
        End If
        With umBE
            .id = txt_cod.Text
            .descripcion = txt_des.Text
            .abrevi = txt_abre.Text
            .empresa = gInt_IdEmpresa
        End With
        If boton = True Then
            umBL.insert(umBE)
        Else
            umBL.update(umBE)
            txt_cod.Enabled = True
        End If
        Call Avisar("Listo!")

        Call cargar_grilla()
        Call Cambiar_Estado_Botones_Tool(ToolS_Mantenimiento)
        Call MostrarTabs(0, utc_um)
        umBE = Nothing
        umBL = Nothing
    End Sub
    Public Sub cargar_grilla()
        Dim umBL As New BL.LogisticaBL.SG_LO_TB_UNI_MED
        Dim umBE As New BE.LogisticaBE.SG_LO_TB_UNI_MED
        udg_um.DataSource = umBL.get_grilla(gInt_IdEmpresa)
        udg_um.DisplayLayout.Bands(0).Columns(0).Header.Caption = "Codigo"
        udg_um.DisplayLayout.Bands(0).Columns(1).Header.Caption = "Descripcion"
        udg_um.DisplayLayout.Bands(0).Columns(2).Header.Caption = "Abreviatura"
        udg_um.DisplayLayout.Bands(0).Columns(3).Hidden = True
        umBE = Nothing
        umBL = Nothing
    End Sub

    Private Sub Tool_Editar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_Editar.Click
        If udg_um.Rows.Count <= 0 Then
            MsgBox("Elegir una fila")
            Exit Sub
        Else
            txt_cod.Text = udg_um.ActiveRow.Cells(0).Value
            txt_des.Text = udg_um.ActiveRow.Cells(1).Value
            txt_abre.Text = udg_um.ActiveRow.Cells(2).Value
            txt_cod.Enabled = False
            txt_des.Focus()
            Cambiar_Estado_Botones_Tool(ToolS_Mantenimiento)
            Call MostrarTabs(1, utc_um)
            boton = False
        End If
    End Sub

    Private Sub Tool_Cancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_Cancelar.Click
        Call limpiar_controles()
        MostrarTabs(0, utc_um)
        Call Cambiar_Estado_Botones_Tool(ToolS_Mantenimiento)
    End Sub

    Private Sub Tool_Eliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_Eliminar.Click
        If udg_um.Rows.Count <= 0 Then
            MsgBox("Elija una Fila")
            Exit Sub
        End If
        If Preguntar("Esta seguro de eliminar?") Then
            Dim umBL As New BL.LogisticaBL.SG_LO_TB_UNI_MED
            Dim umBE As New BE.LogisticaBE.SG_LO_TB_UNI_MED
            umBE.id = udg_um.ActiveRow.Cells("UM_ID").Value
            umBE.empresa = gInt_IdEmpresa
            umBL.delete(umBE)
            Avisar("Listo!")
            Call Inicializar_Estado_Botones_Tool(ToolS_Mantenimiento)
            Call cargar_grilla()
            MostrarTabs(0, utc_um)
            umBE = Nothing
            umBL = Nothing
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