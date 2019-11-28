Public Class LO_MA_Proveedor

    Dim Bol_Nuevo As Boolean = False

    Private Sub pKeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Me.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Return) Then
            SendKeys.Send("{TAB}")
            e.Handled = True
        End If
    End Sub

    Private Sub LO_MA_Proveedor_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

        Call Inicializar_Estado_Botones_Tool(ToolS_Mantenimiento)
        Call Cargar_Documentos()
        Call Cargar_Paises()
        Call Cargar_proveedores()

        Dim ComunicacionBL As New BL.LogisticaBL.SG_LO_TB_TIPO_COMUNICACION
        Call CrearComboGrid("CODIGO", "TC_DESCRIPCION", ug_Comunicacion, ComunicacionBL.get_Tipos(gInt_IdEmpresa), True)
        ComunicacionBL = Nothing

        ubtn_ir_web.Appearance.Image = My.Resources._16__Internet_
        ' uce_pais.ButtonsRight("btn_nuevo").Appearance.Image = My.Resources._16__File_new_2_

        Me.KeyPreview = True
    End Sub

    Private Sub Cargar_proveedores()
        Me.Cursor = Cursors.WaitCursor

        Dim proveedorBL As New BL.LogisticaBL.SG_LO_TB_PROVEEDOR
        ug_Proveedor.DataSource = proveedorBL.get_Proveedores(gInt_IdEmpresa)
        proveedorBL = Nothing

        Me.Cursor = Cursors.Default
    End Sub

    Private Sub Tool_Nuevo_Click(sender As System.Object, e As System.EventArgs) Handles Tool_Nuevo.Click
        Call Cambiar_Estado_Botones_Tool(ToolS_Mantenimiento)
        Call Limpiar_Controls_InGroupox(ugb_datos)
        Call MostrarTabs(1, utc_Proves, 1)

        uds_Comunicaciones.Rows.Clear()
        ug_Comunicacion.DataSource = uds_Comunicaciones
        ug_Comunicacion.DisplayLayout.Bands(0).AddNew()

        Bol_Nuevo = True
        txt_cod_prove.ReadOnly = True
        uchk_estado.Checked = True
        uce_pais.SelectedIndex = 0
        uce_tipo_Docu.SelectedIndex = 1
        txt_Notas.Text = "Sin Observaciones"
        txt_razon.Focus()

    End Sub

    Private Sub Tool_Grabar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_Grabar.Click

        'Validar
        If txt_razon.Text = "" Then
            Avisar("Ingresar Razon Social")
            txt_razon.Focus()
            Exit Sub
        End If

        If txt_num_doc.Text = "" Then
            Avisar("Ingrese Num. de Documento")
            txt_num_doc.Focus()
            Exit Sub
        End If

        If uce_tipo_Docu.SelectedIndex = 1 Then 'ruc
            If txt_num_doc.Text.Trim.Length <> 11 Then
                Avisar("El numero de ruc es incorrecto")
                txt_num_doc.Focus()
                Exit Sub
            End If
        End If

        If Bol_Nuevo Then
            For i As Integer = 0 To ug_Proveedor.Rows.Count - 1
                If txt_num_doc.Text.Trim = ug_Proveedor.Rows(i).Cells("PR_NDOC").Value.ToString.Trim Then
                    Call Avisar("El numero de documento ya esta registrado en la lista de proveedores")
                    Exit Sub
                End If
            Next
        End If


        'Grabamos
        Dim proveedorBL As New BL.LogisticaBL.SG_LO_TB_PROVEEDOR
        Dim proveedorBE As New BE.LogisticaBE.SG_LO_TB_PROVEEDOR

        With proveedorBE
            .PR_ID = IIf(Bol_Nuevo, 0, txt_cod_prove.Text.Trim)
            .PR_DESCRIPCION = txt_razon.Text.Trim
            .PR_TDOC = uce_tipo_Docu.Value
            .PR_NDOC = txt_num_doc.Text.Trim
            .PR_DIRECCION = txt_dir.Text.Trim
            .PR_ES_RELACIONADO = IIf(uchk_es_rela.Checked, 1, 0)
            .PR_IDPAIS = uce_pais.Value
            .PR_DIR_WEB = txt_web.Text.Trim
            .PR_ESTADO = IIf(uchk_estado.Checked, 1, 0)
            .PR_NOTAS = txt_Notas.Text.Trim
            .PR_USUARIO = String.Format("{0}-{1}", Environment.UserName, gStr_Usuario_Sis)
            .PR_TERMINAL = Environment.MachineName
            .PR_FECREG = Now
            .PR_IDEMPRESA = gInt_IdEmpresa
            .PR_IDANEXO_CONTA = IIf(Bol_Nuevo, 0, txt_cod_conta.Text.Trim)
        End With

        ug_Comunicacion.UpdateData()

        Dim ls_comunica As New List(Of BE.LogisticaBE.SG_LO_TB_PROVE_COMUNI)

        For i As Integer = 0 To ug_Comunicacion.Rows.Count - 1
            If ug_Comunicacion.Rows(i).Cells("Descripcion").Value.ToString.Length > 0 Then
                ls_comunica.Add(New BE.LogisticaBE.SG_LO_TB_PROVE_COMUNI With {.CC_IDPROVE = Val(txt_cod_prove.Text), .CC_IDCOMUNICA = ug_Comunicacion.Rows(i).Cells("Codigo").Value, .CC_DESCRIPCION = ug_Comunicacion.Rows(i).Cells("Descripcion").Value.ToString})
            End If
        Next

        If Bol_Nuevo Then
            proveedorBL.Insert(proveedorBE, ls_comunica)
            txt_cod_prove.Text = proveedorBE.PR_ID
            txt_cod_conta.Text = proveedorBE.PR_IDANEXO_CONTA
        Else
            proveedorBL.Update(proveedorBE, ls_comunica)
        End If

        ls_comunica = Nothing
        proveedorBE = Nothing
        proveedorBL = Nothing

        Call Avisar("Listo!")
        Call Cargar_proveedores()
        Call Tool_Cancelar_Click(sender, e)

    End Sub

    Private Sub Tool_Editar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_Editar.Click
        Bol_Nuevo = False

        Dim proveedorBL As New BL.LogisticaBL.SG_LO_TB_PROVEEDOR
        Dim drr_prove As System.Data.SqlClient.SqlDataReader
        drr_prove = proveedorBL.get_Proveedores_x_Id(ug_Proveedor.ActiveRow.Cells("PR_ID").Value)
        If drr_prove.HasRows Then
            drr_prove.Read()
            txt_cod_prove.Text = drr_prove("PR_ID")
            txt_razon.Text = drr_prove("PR_DESCRIPCION")
            uce_tipo_Docu.Value = drr_prove("PR_TDOC")
            txt_dir.Text = drr_prove("PR_DIRECCION").ToString
            txt_num_doc.Text = drr_prove("PR_NDOC")
            uchk_es_rela.Checked = IIf(drr_prove("PR_ES_RELACIONADO") = 1, True, False)
            uchk_estado.Checked = IIf(drr_prove("PR_ESTADO") = 1, True, False)
            uce_pais.Value = drr_prove("PR_IDPAIS")
            txt_web.Text = drr_prove("PR_DIR_WEB")
            txt_Notas.Text = drr_prove("PR_NOTAS")
            txt_cod_conta.Text = drr_prove("PR_IDANEXO_CONTA").ToString
        End If
        drr_prove.Close()


        Dim comunicacionesBL As New BL.LogisticaBL.SG_LO_TB_PROVE_COMUNI
        Dim comunicacionesBE As New BE.LogisticaBE.SG_LO_TB_PROVE_COMUNI
        comunicacionesBE.CC_IDPROVE = txt_cod_prove.Text
        Dim dt_tmp As DataTable = comunicacionesBL.get_Comunicaciones_x_Id(comunicacionesBE)
        comunicacionesBE = Nothing
        comunicacionesBL = Nothing

        uds_Comunicaciones.Rows.Clear()
        ug_Comunicacion.DataSource = uds_Comunicaciones

        For i As Integer = 0 To dt_tmp.Rows.Count - 1
            ug_Comunicacion.DisplayLayout.Bands(0).AddNew()
            ug_Comunicacion.Rows(i).Cells("Codigo").Value = dt_tmp.Rows(i)("CC_IDCOMUNICA")
            ug_Comunicacion.Rows(i).Cells("Descripcion").Value = dt_tmp.Rows(i)("CC_DESCRIPCION")
            ug_Comunicacion.UpdateData()
        Next
        ug_Comunicacion.DisplayLayout.Bands(0).AddNew()

        txt_cod_prove.ReadOnly = True


        Dim obr As New BL.LogisticaBL.SG_LO_TB_COMPROBANTES_CAB
        ug_Lista.DataSource = obr.get_Comprobante_xProv(Val(txt_cod_prove.Text), gInt_IdEmpresa)

        If ug_Lista.Rows.Count > 0 Then
            ug_ListaDet.DataSource = obr.get_Comprobante_DET_xProv(ug_Lista.Rows(0).Cells(0).Value)
        Else
            uds_ListaDet.Rows.Clear()
            ug_ListaDet.DataSource = uds_ListaDet
        End If

        Call MostrarTabs(1, utc_Proves, 2)
        Call Cambiar_Estado_Botones_Tool(ToolS_Mantenimiento)
        txt_razon.Focus()


    End Sub

    Private Sub Tool_Cancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_Cancelar.Click
        Call Cambiar_Estado_Botones_Tool(ToolS_Mantenimiento)
        Call MostrarTabs(0, utc_Proves, 0)
    End Sub

    Private Sub Tool_Eliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_Eliminar.Click

        If ug_Proveedor.Rows.Count = 0 Then Exit Sub
        If ug_Proveedor.ActiveRow.IsFilterRow Then Exit Sub

        If Preguntar("Seguro de eliminar?") Then
            Dim proveedorBL As New BL.LogisticaBL.SG_LO_TB_PROVEEDOR
            Dim proveedorBE As New BE.LogisticaBE.SG_LO_TB_PROVEEDOR
            proveedorBE.PR_ID = ug_Proveedor.ActiveRow.Cells("PR_ID").Value
            proveedorBL.Delete(proveedorBE)
            proveedorBL = Nothing
            proveedorBE = Nothing

            Call Avisar("Listo!")
            Call Cargar_proveedores()

        End If





    End Sub

    Private Sub Tool_Salir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_Salir.Click
        Me.Close()
    End Sub

    Public Sub Cargar_Documentos()
        Dim docuemntosBL As New BL.LogisticaBL.SG_LO_TB_TIPO_DOCU_PERSO
        uce_tipo_Docu.DataSource = docuemntosBL.get_Documentos_cmb(gInt_IdEmpresa)
        uce_tipo_Docu.DisplayMember = "DO_DESCRIPCION"
        uce_tipo_Docu.ValueMember = "DO_CODIGO"
        docuemntosBL = Nothing
    End Sub

    Private Sub Cargar_Paises()
        Dim paisBL As New BL.LogisticaBL.SG_LO_TB_PAIS
        uce_pais.DataSource = paisBL.getPaises(gInt_IdEmpresa)
        uce_pais.DisplayMember = "PA_DESCRIPCION"
        uce_pais.ValueMember = "PA_ID"
        paisBL = Nothing
    End Sub

    Private Sub ubtn_cons_sunat_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ubtn_cons_sunat.Click
        CO_MT_TCamb_Web.Str_Direccion_Defecto = "http://www.sunat.gob.pe/cl-ti-itmrconsruc/jcrS00Alias"
        CO_MT_TCamb_Web.Show()
    End Sub

    Private Sub ubtn_ir_web_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ubtn_ir_web.Click
        If txt_web.Text.Trim = "" Then
            Avisar("Ingrese una direccion valida")
            txt_web.Focus()
            Exit Sub
        End If
        System.Diagnostics.Process.Start(txt_web.Text.Trim)
    End Sub

    Private Sub ug_Comunicacion_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles ug_Comunicacion.KeyDown
        If e.KeyCode = Keys.F5 Then
            Dim ComunicacionBL As New BL.LogisticaBL.SG_LO_TB_TIPO_COMUNICACION
            Call CrearComboGrid("CODIGO", "TC_DESCRIPCION", ug_Comunicacion, ComunicacionBL.get_Tipos(gInt_IdEmpresa), True)
            ComunicacionBL = Nothing
        End If
    End Sub

    Private Sub ug_Proveedor_DoubleClickRow(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.DoubleClickRowEventArgs) Handles ug_Proveedor.DoubleClickRow
        If ug_Proveedor.Rows.Count = 0 Then Exit Sub
        If ug_Proveedor.ActiveRow.IsFilterRow Then Exit Sub
        Call Tool_Editar_Click(sender, e)
    End Sub

    Private Sub ug_Lista_AfterSelectChange(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinGrid.AfterSelectChangeEventArgs) Handles ug_Lista.AfterSelectChange
        If ug_Lista.ActiveRow.IsFilterRow Then Exit Sub

        Dim obr As New BL.LogisticaBL.SG_LO_TB_COMPROBANTES_CAB
        ug_ListaDet.DataSource = obr.get_Comprobante_DET_xProv(ug_Lista.ActiveRow.Cells(0).Value)

    End Sub
End Class
