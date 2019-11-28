Public Class LO_LT_Requerimiento_C
    'Dim boton As Boolean = False
    'Private Sub LO_LT_Requerimiento_C_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
    '    Try
    '        ute_usuario.Text = gStr_Usuario_Sis
    '        Call cargar_grilla()
    '        Call Inicializar_Estado_Botones_Tool(ToolS_Mantenimiento)
    '        Me.KeyPreview = True
    '        'Inicializando combos
    '        MostrarTabs(0, utc_reque)
    '        Dim areaBL As New BL.LogisticaBL.SG_LO_TB_AREA
    '        ucb_area.DataSource = areaBL.getar(gInt_IdEmpresa)
    '        ucb_area.DisplayMember = "AR_DESCRIPCION"
    '        ucb_area.ValueMember = "AR_ID"
    '        areaBL = Nothing

    '        Dim ccBL As New BL.LogisticaBL.SG_LO_TB_CENTRO_COSTO
    '        ucb_cc.DataSource = ccBL.getcc(gInt_IdEmpresa)
    '        ucb_cc.DisplayMember = "CC_DESCRIPCION"
    '        ucb_cc.ValueMember = "CC_ID"

    '        Dim proBL As New BL.LogisticaBL.SG_LO_TB_PROYECTO
    '        ucb_pro.DataSource = proBL.get_grilla(gInt_IdEmpresa)
    '        ucb_pro.DisplayMember = "PR_DESCRIPCION"
    '        ucb_pro.ValueMember = "PR_ID"

    '        Dim trBL As New BL.LogisticaBL.SG_LO_TB_TIPO_REQ
    '        ucb_tipo.DataSource = trBL.get_grilla(gInt_IdEmpresa)
    '        ucb_tipo.DisplayMember = "TR_DESCRIPCION"
    '        ucb_tipo.ValueMember = "TR_ID"


    '    Catch ex As Exception
    '        Avisar(ex.Message)
    '    End Try

    'End Sub
    'Private Sub ub_busqueda_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ub_busqueda.Click
    '    Dim f As New LO_LT_Ayuda_Articulo
    '    f.ShowDialog()
    '    If f.bol_aceptar Then
    '        ug_detalle.DisplayLayout.Bands(0).AddNew()
    '        With ug_detalle.Rows(ug_detalle.Rows.Count - 1)
    '            .Cells("Item").Value = ug_detalle.Rows.Count
    '            .Cells("Articulo").Value = f.lista(0)
    '            .Cells("Descripcion").Value = f.lista(1)
    '            .Cells("Cantidad").Value = 0
    '            .Cells("Estado").Value = 1
    '            .Cells("Nota").Value = ""
    '            .Cells("Uni_Med").Value = f.lista(2)
    '            .Cells("Des_Med").Value = f.lista(3)
    '        End With
    '        ug_detalle.UpdateData()
    '    End If
    'End Sub
    'Public Sub cargar_grilla_detalle()
    '    Dim rdBE As New BE.LogisticaBE.SG_LO_TB_REQUERIMIENTO_D
    '    Dim rdBL As New BL.LogisticaBL.SG_LO_TB_REQUERIMIENTO_D
    '    ug_detalle.DataSource = rdBL.get_grilla(Val(ute_cod.Text))
    'End Sub
    'Public Sub cargar_grilla()
    '    Dim reBE As New BE.LogisticaBE.SG_LO_TB_REQUERIMIENTO_C
    '    Dim reBL As New BL.LogisticaBL.SG_LO_TB_REQUERIMIENTO_C
    '    ug_cabecera.DataSource = reBL.get_grilla(gInt_IdEmpresa)
    '    ug_cabecera.DisplayLayout.Bands(0).Columns(0).Header.Caption = "Codigo"
    '    ug_cabecera.DisplayLayout.Bands(0).Columns(1).Header.Caption = "Descripcion"
    '    ug_cabecera.DisplayLayout.Bands(0).Columns(2).Header.Caption = "Direccion"
    '    ug_cabecera.DisplayLayout.Bands(0).Columns(3).Header.Caption = "Pais"
    '    ug_cabecera.DisplayLayout.Bands(0).Columns(4).Header.Caption = "Nota"
    '    ug_cabecera.DisplayLayout.Bands(0).Columns(5).Header.Caption = "Area"
    '    ug_cabecera.DisplayLayout.Bands(0).Columns(6).Header.Caption = "Centro_Costo"
    '    ug_cabecera.DisplayLayout.Bands(0).Columns(7).Header.Caption = "Estado"
    '    ug_cabecera.DisplayLayout.Bands(0).Columns(8).Header.Caption = "Proyecto"
    '    ug_cabecera.DisplayLayout.Bands(0).Columns(9).Header.Caption = "Usuario"
    '    ug_cabecera.DisplayLayout.Bands(0).Columns(10).Hidden = True
    '    ug_cabecera.DisplayLayout.Bands(0).Columns(11).Hidden = True
    '    ug_cabecera.DisplayLayout.Bands(0).Columns(12).Hidden = True
    'End Sub
    'Private Sub Tool_Nuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_Nuevo.Click
    '    Call Cambiar_Estado_Botones_Tool(ToolS_Mantenimiento)
    '    Call MostrarTabs(1, utc_reque)
    '    Call limpiar_controles()
    '    Call LimpiaGrid(ug_detalle, uds_detalle)
    '    ucb_tipo.Focus()
    '    boton = True
    'End Sub
    'Public Sub limpiar_controles()
    '    ute_cod.Text = ""
    '    ucb_tipo.SelectedIndex = -1
    '    ute_usuario.Text = ""
    '    ucb_area.SelectedIndex = -1
    '    udte_fec_req.Value = Nothing
    '    ucb_cc.SelectedIndex = -1
    '    If rb_acti.Checked = False Then
    '        rb_inacti.Checked = True
    '    End If
    '    ute_nota.Text = ""
    '    ucb_pro.SelectedIndex = -1
    'End Sub
    'Private Sub Tool_Grabar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_Grabar.Click
    '    If ucb_tipo.SelectedIndex = -1 Or ucb_area.SelectedIndex = -1 Or ucb_cc.SelectedIndex = -1 Or ucb_pro.SelectedIndex = -1 Or udte_fec_req.Value = Nothing Then
    '        MsgBox("Falta completar")
    '        Exit Sub
    '    End If
    '    Dim reBL As New BL.LogisticaBL.SG_LO_TB_REQUERIMIENTO_C
    '    Dim reBE As New BE.LogisticaBE.SG_LO_TB_REQUERIMIENTO_C
    '    Dim detalleBE As BE.LogisticaBE.SG_LO_TB_REQUERIMIENTO_D
    '    Dim lstdetalle As New List(Of BE.LogisticaBE.SG_LO_TB_REQUERIMIENTO_D)
    '    With reBE
    '        .id = ute_cod.Value
    '        .idtipo = ucb_tipo.Value
    '        .idusuario = ute_usuario.Value
    '        .fecha_req = CDate(udte_fec_req.Value).ToShortDateString
    '        .nota = ute_nota.Text
    '        .idarea = ucb_area.Value
    '        .idcc = ucb_cc.Value
    '        If rb_acti.Checked = True Then
    '            .estado = 1
    '        Else
    '            .estado = 0
    '        End If
    '        .idproyecto = ucb_pro.Value
    '        .usuario = String.Format("{0}-{1}", Environment.UserName, gStr_Usuario_Sis)
    '        .terminal = Environment.MachineName
    '        .fecreg = Date.Now
    '        .idempresa = gInt_IdEmpresa
    '    End With
    '    If boton = True Then
    '        reBL.Insert(reBE, lstdetalle)
    '    Else
    '        reBL.Update(reBE)
    '    End If
    '    Call Avisar("Listo!")

    '    Call cargar_grilla()
    '    Call Cambiar_Estado_Botones_Tool(ToolS_Mantenimiento)
    '    Call MostrarTabs(0, utc_reque)
    '    reBE = Nothing
    '    reBL = Nothing

    '    For i As Integer = 0 To ug_detalle.Rows.Count - 1
    '        detalleBE = New BE.LogisticaBE.SG_LO_TB_REQUERIMIENTO_D
    '        With detalleBE
    '            .idcab = 0
    '            .item = ug_detalle.Rows(i).Cells("Item").Value
    '            .idarticulo = ug_detalle.Rows(i).Cells("Articulo").Value
    '            .cant = ug_detalle.Rows(i).Cells("Cantidad").Value
    '            .estado = ug_detalle.Rows(i).Cells("Estado").Value
    '            .nota = ug_detalle.Rows(i).Cells("Nota").Value
    '        End With
    '        lstdetalle.Add(detalleBE)
    '    Next
    'End Sub
    'Private Sub Tool_Editar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_Editar.Click
    '    If ug_cabecera.Rows.Count <= 0 Then
    '        MsgBox("Elegir una fila")
    '        Exit Sub
    '    Else
    '        ute_cod.Text = ug_cabecera.ActiveRow.Cells(0).Value
    '        ucb_tipo.Value = ug_cabecera.ActiveRow.Cells(1).Value
    '        ute_usuario.Text = ug_cabecera.ActiveRow.Cells(2).Value
    '        udte_fec_req.Value = ug_cabecera.ActiveRow.Cells(3).Value
    '        ute_nota.Text = ug_cabecera.ActiveRow.Cells(4).Value
    '        ucb_area.Value = ug_cabecera.ActiveRow.Cells(5).Value
    '        ucb_cc.Value = ug_cabecera.ActiveRow.Cells(6).Value
    '        If ug_cabecera.ActiveRow.Cells(7).Value = 1 Then
    '            rb_acti.Checked = True
    '        Else
    '            rb_acti.Checked = False
    '        End If
    '        ucb_pro.Value = ug_cabecera.ActiveRow.Cells(8).Value
    '        ucb_tipo.Focus()
    '        Cambiar_Estado_Botones_Tool(ToolS_Mantenimiento)
    '        Call MostrarTabs(1, utc_reque)
    '        boton = False
    '    End If
    'End Sub
    'Private Sub Tool_Cancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_Cancelar.Click
    '    Call limpiar_controles()
    '    MostrarTabs(0, utc_reque)
    '    Call Inicializar_Estado_Botones_Tool(ToolS_Mantenimiento)
    'End Sub
    'Private Sub Tool_Eliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_Eliminar.Click
    '    If ug_cabecera.Rows.Count <= 0 Then
    '        MsgBox("Elija una Fila")
    '        Exit Sub
    '    End If
    '    If Preguntar("Esta seguro de eliminar?") Then
    '        Dim reBL As New BL.LogisticaBL.SG_LO_TB_REQUERIMIENTO_C
    '        Dim reBE As New BE.LogisticaBE.SG_LO_TB_REQUERIMIENTO_C
    '        reBE.id = ug_cabecera.ActiveRow.Cells("RC_ID").Value
    '        reBE.idempresa = gInt_IdEmpresa
    '        reBL.Delete(reBE)
    '        Avisar("Listo!")
    '        Call Inicializar_Estado_Botones_Tool(ToolS_Mantenimiento)
    '        Call cargar_grilla()
    '        MostrarTabs(0, utc_reque)
    '        reBE = Nothing
    '        reBL = Nothing
    '    End If
    'End Sub
    'Private Sub Tool_Salir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_Salir.Click
    '    Me.Close()
    'End Sub
    'Private Sub pKeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Me.KeyPress
    '    If e.KeyChar = Convert.ToChar(Keys.Return) Then
    '        SendKeys.Send("{TAB}")
    '        e.Handled = True
    '    End If
    'End Sub
    'Private Sub ug_detalle_BeforeRowsDeleted(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinGrid.BeforeRowsDeletedEventArgs) Handles ug_detalle.BeforeRowsDeleted
    '    e.DisplayPromptMsg = False
    'End Sub
End Class