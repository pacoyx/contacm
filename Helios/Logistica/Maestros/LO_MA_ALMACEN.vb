Public Class LO_MA_ALMACEN
    Dim boton As Boolean = False
    Private Sub LO_MA_ALMACEN_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call limpiar_controles()
        Call Inicializar_Estado_Botones_Tool(ToolS_Mantenimiento)
        MostrarTabs(0, utb_datos)
        Call cargar_grilla()
        Dim BLpais As New BL.LogisticaBL.SG_LO_TB_PAIS
        uce_pais.DataSource = BLpais.getPaises(gInt_IdEmpresa)
        uce_pais.ValueMember = "PA_ID"
        uce_pais.DisplayMember = "PA_DESCRIPCION"
        txt_des_ubigeo.Enabled = False
        txt_ubigeo.ButtonsRight(0).Appearance.Image = My.Resources._104
        Me.KeyPreview = True
    End Sub

    Public Sub limpiar_controles()
        txt_cod.Text = ""
        txt_des.Text = ""
        txt_direc.Text = ""
        txt_tele.Text = ""
        uce_pais.SelectedIndex = -1
        txt_ubigeo.Text = ""
        txt_des_ubigeo.Text = ""
    End Sub

    Private Sub Tool_Salir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_Salir.Click
        Me.Close()
    End Sub

    Private Sub Tool_Nuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_Nuevo.Click
        Call Cambiar_Estado_Botones_Tool(ToolS_Mantenimiento)
        Call limpiar_controles()
        MostrarTabs(1, utb_datos)
        txt_cod.Enabled = True
        txt_cod.Focus()
        boton = True
    End Sub

    Private Sub Tool_Grabar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_Grabar.Click
        If txt_cod.Text = "" Or txt_des.Text = "" Or txt_ubigeo.Text = "" Then
            Avisar("  Falta completar  ")
            Exit Sub
        End If
        Dim BLal As New BL.LogisticaBL.SG_LO_TB_ALMACEN
        Dim BEal As New BE.LogisticaBE.SG_LO_TB_ALMACEN
        BEal.id = txt_cod.Text
        BEal.descripcion = txt_des.Text
        BEal.direccion = txt_direc.Text
        BEal.pais = uce_pais.Value
        BEal.ubigeo = txt_ubigeo.Text
        BEal.telefono = txt_tele.Text
        BEal.estado = urb_Estado.Value
        BEal.afecto = IIf(ucheck_defecto.Checked, 1, 0)
        BEal.terminal = Environment.MachineName
        BEal.usuario = String.Format("{0}-{1}", Environment.UserName, gStr_Usuario_Sis)
        BEal.fecreg = Date.Now
        BEal.idempresa = gInt_IdEmpresa
        If boton = True Then
            BLal.insert(BEal)
            Avisar("  Grabo con exito !!  ")
        Else
            BLal.update(BEal)
            Avisar("  Actualizo con exito !!  ")
            txt_cod.Enabled = True
        End If
        Call limpiar_controles()
        MostrarTabs(0, utb_datos)
        Call Inicializar_Estado_Botones_Tool(ToolS_Mantenimiento)
        Call cargar_grilla()
    End Sub

    Private Sub Tool_Editar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_Editar.Click
        If ug_ar.ActiveRow Is Nothing Then
            Avisar(" Elija una fila ")
            Exit Sub
        End If
        Dim BLal As New BL.LogisticaBL.SG_LO_TB_ALMACEN
        Dim BEal As New BE.LogisticaBE.SG_LO_TB_ALMACEN
        txt_cod.Text = ug_ar.ActiveRow.Cells(0).Value
        txt_des.Text = ug_ar.ActiveRow.Cells(1).Value
        txt_direc.Text = ug_ar.ActiveRow.Cells(2).Value
        uce_pais.Value = ug_ar.ActiveRow.Cells(3).Value
        txt_ubigeo.Text = ug_ar.ActiveRow.Cells(4).Value
        txt_tele.Text = ug_ar.ActiveRow.Cells(5).Value
        If ug_ar.ActiveRow.Cells(6).Value = 1 Then
            urb_Estado.Text = "Activo"
        Else
            urb_Estado.Text = "Inactivo"
        End If
        ucheck_defecto.Checked = ug_ar.ActiveRow.Cells(7).Value
        Call Cambiar_Estado_Botones_Tool(ToolS_Mantenimiento)
        MostrarTabs(1, utb_datos)
        txt_cod.Enabled = False
        boton = False
    End Sub

    Private Sub Tool_Cancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_Cancelar.Click
        Call limpiar_controles()
        Call Cambiar_Estado_Botones_Tool(ToolS_Mantenimiento)
        MostrarTabs(0, utb_datos)
    End Sub

    Private Sub Tool_Eliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_Eliminar.Click
        If ug_ar.ActiveRow Is Nothing Then
            Avisar(" Elija una fila  ")
            Exit Sub
        End If
        If Preguntar("  ¿Esta seguro de eliminar?  ") Then
            Dim reBL As New BL.LogisticaBL.SG_LO_TB_ALMACEN
            Dim reBE As New BE.LogisticaBE.SG_LO_TB_ALMACEN
            reBE.id = ug_ar.ActiveRow.Cells(0).Value
            reBE.idempresa = gInt_IdEmpresa
            Dim val As Integer = 0

            val = reBL.delete(reBE)
            If val = 1 Then
                Avisar("  Registro eliminado !  ")
                Call Inicializar_Estado_Botones_Tool(ToolS_Mantenimiento)
                Call cargar_grilla()
                MostrarTabs(0, utb_datos)
                reBE = Nothing
                reBL = Nothing
            ElseIf val = -2 Then
                Avisar("  No Se Puede Eliminar Tiene Registros Dependientes !  ")
            Else
                Avisar(" No se Puede Eliminar")
            End If
        End If

    End Sub

    Public Sub cargar_grilla()
        Dim BLal As New BL.LogisticaBL.SG_LO_TB_ALMACEN
        ug_ar.DataSource = BLal.get_almacen(gInt_IdEmpresa)
        BLal = Nothing
        'ug_ar.DisplayLayout.Bands(0).Columns(0).Header.Caption = "CODIGO"
        'ug_ar.DisplayLayout.Bands(0).Columns(1).Header.Caption = "DESCRIPCION"
        'ug_ar.DisplayLayout.Bands(0).Columns(2).Header.Caption = "DIRECCION"
        'ug_ar.DisplayLayout.Bands(0).Columns(3).Hidden = True
        'ug_ar.DisplayLayout.Bands(0).Columns(4).Header.Caption = "UBIGEO"
        'ug_ar.DisplayLayout.Bands(0).Columns(5).Header.Caption = "TELEFONO"
        'ug_ar.DisplayLayout.Bands(0).Columns(6).Hidden = True
        'ug_ar.DisplayLayout.Bands(0).Columns(7).Hidden = True
        'ug_ar.DisplayLayout.Bands(0).Columns(8).Hidden = True
        'ug_ar.DisplayLayout.Bands(0).Columns(9).Hidden = True
        'ug_ar.DisplayLayout.Bands(0).Columns(10).Hidden = True
        'ug_ar.DisplayLayout.Bands(0).Columns(11).Hidden = True
    End Sub

    Private Sub txt_ubigeo_EditorButtonClick(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinEditors.EditorButtonEventArgs) Handles txt_ubigeo.EditorButtonClick
        Select Case e.Button.Key
            Case "btn_ubigeo"
                PL_MA_Ubigeo.ShowDialog()
                If PL_MA_Ubigeo.Bol_Aceptar Then
                    txt_ubigeo.Text = PL_MA_Ubigeo.Str_Cod_Ubigeo.ToString
                    txt_des_ubigeo.Text = PL_MA_Ubigeo.Str_Des_Ubigeo.ToString
                End If
        End Select
    End Sub

    Private Sub pKeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Me.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Return) Then
            SendKeys.Send("{TAB}")
            e.Handled = True
        End If
    End Sub
End Class