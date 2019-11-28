Public Class PL_MA_DerechoHab

    Dim Bol_Nuevo As Boolean = False

    Private Sub PL_MA_DerechoHab_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call Inicializar_Estado_Botones_Tool(ToolS_Mantenimiento)
        Call Cargar_TipoDoc()
        Call Cargar_Vinculo_Familiar()
        Call Cargar_Doc_Acredita_Vinculo()
        Call Cargar_Tipo_Zona()
        Call Cargar_Tipo_Via()
        Call Cargar_Pais_Emisor_Documento()
        Call Formatear_Grilla_Selector(ug_listado)
        Call Cargar_Motivo_baja()
        Call MostrarTabs(0, utc_Contenedor, 0)

        txt_cod_personal.ButtonsRight(0).Appearance.Image = My.Resources._104
        txt_ubigeo.ButtonsRight(0).Appearance.Image = My.Resources._104

    End Sub

    Private Sub Cargar_Motivo_baja()
        Dim motivoBL As New BL.PlanillaBL.SG_PL_TB_MOTIVO_BAJA

        uce_motivo_baja.DataSource = motivoBL.get_Motivos
        uce_motivo_baja.DisplayMember = "MB_DESCRIPCION"
        uce_motivo_baja.ValueMember = "MB_CODIGO"
        motivoBL = Nothing

    End Sub

    Private Sub Cargar_Familiares()
        Dim derechoBL As New BL.PlanillaBL.SG_PL_TB_DERECHO_HABIENTE
        Dim derechoBE As New BE.PlanillaBE.SG_PL_TB_DERECHO_HABIENTE
        Dim dt_familiares As DataTable = Nothing

        derechoBE.DA_IDPERSONAL = txt_id_personal.Text.Trim
        dt_familiares = derechoBL.get_Derecho_Habiente(derechoBE)

        Call LimpiaGrid(ug_listado, uds_Lista)

        For i As Integer = 0 To dt_familiares.Rows.Count - 1
            ug_listado.DisplayLayout.Bands(0).AddNew()
            ug_listado.Rows(i).Cells("DA_IDPERSONAL").Value = dt_familiares.Rows(i)("DA_IDPERSONAL")
            ug_listado.Rows(i).Cells("DA_TDOC_DA").Value = dt_familiares.Rows(i)("DA_TDOC_DA")
            ug_listado.Rows(i).Cells("DA_NDOC_DA").Value = dt_familiares.Rows(i)("DA_NDOC_DA")
            ug_listado.Rows(i).Cells("DA_APE_PAT").Value = dt_familiares.Rows(i)("DA_APE_PAT")
            ug_listado.Rows(i).Cells("DA_APE_MAT").Value = dt_familiares.Rows(i)("DA_APE_MAT")
            ug_listado.Rows(i).Cells("DA_NOMBRES").Value = dt_familiares.Rows(i)("DA_NOMBRES")

            ug_listado.UpdateData()
        Next

        If ug_listado.Rows.Count > 0 Then
            ug_listado.Rows(0).Activate()
        End If

        dt_familiares = Nothing
        derechoBE = Nothing
        derechoBL = Nothing

    End Sub

    Private Sub Cargar_Doc_Acredita_Vinculo()
        Dim docVinculoBL As New BL.PlanillaBL.SG_PL_TB_DOC_SUSTENTA_VIN_FAM
        uce_doc_vinculo.DataSource = docVinculoBL.get_Documentos()
        uce_doc_vinculo.DisplayMember = "DS_ABREVIADA"
        uce_doc_vinculo.ValueMember = "DS_CODIGO"
        docVinculoBL = Nothing
    End Sub

    Private Sub Cargar_Tipo_Zona()
        Dim tipoZonaBL As New BL.PlanillaBL.SG_PL_TB_TIPO_ZONA
        uce_tip_zona.DataSource = tipoZonaBL.getZonas
        uce_tip_zona.ValueMember = "TZ_ID"
        uce_tip_zona.DisplayMember = "TZ_DESCRIPCION"
        tipoZonaBL = Nothing
    End Sub

    Private Sub Cargar_Tipo_Via()
        Dim tipoViaBL As New BL.PlanillaBL.SG_PL_TB_TIPO_VIA
        uce_tip_via.DataSource = tipoViaBL.getVias
        uce_tip_via.ValueMember = "TV_ID"
        uce_tip_via.DisplayMember = "TV_DESCRIPCION"
        tipoViaBL = Nothing
    End Sub

    Private Sub Cargar_Pais_Emisor_Documento()
        Dim nacionalidadBL As New BL.PlanillaBL.SG_PL_TB_PAIS
        uce_pais.DataSource = nacionalidadBL.get_Paises
        uce_pais.ValueMember = "PA_CODIGO"
        uce_pais.DisplayMember = "PA_DESCRIPCION"
        nacionalidadBL = Nothing
    End Sub

    Private Sub Cargar_TipoDoc()
        Dim documentoBL As New BL.PlanillaBL.SG_PL_TB_DOCUMENTO_PERSONAL
        uce_tip_doc.DataSource = documentoBL.getDocumentos
        uce_tip_doc.DisplayMember = "DP_DESCRIPCION"
        uce_tip_doc.ValueMember = "DP_ID"
        documentoBL = Nothing
    End Sub

    Private Sub Cargar_Vinculo_Familiar()
        Dim vinculoBL As New BL.PlanillaBL.SG_PL_TB_VINCULO_FAMILIAR
        uce_vinculo.DataSource = vinculoBL.get_vinculos()
        uce_vinculo.DisplayMember = "VF_DESCRIPCION"
        uce_vinculo.ValueMember = "VF_CODIGO"
        vinculoBL = Nothing
    End Sub

    Private Sub Tool_Salir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_Salir.Click
        Me.Close()
    End Sub

    Private Sub Mostrar_Ayuda_Empleado()

        PL_PR_Lista_Personal.Bol_habilitar_uos = True
        PL_PR_Lista_Personal.Bol_MultiSeleccion = False
        PL_PR_Lista_Personal.ShowDialog()
        If PL_PR_Lista_Personal.Bol_Aceptar Then

            Dim matriz As New List(Of BE.PlanillaBE.SG_PL_TB_PERSONAL)
            matriz = PL_PR_Lista_Personal.lista_empleados
            If matriz.Count > 0 Then



                For Each empleado As BE.PlanillaBE.SG_PL_TB_PERSONAL In matriz
                    txt_cod_personal.Text = empleado.PE_CODIGO
                    txt_nombres.Text = empleado.PE_APE_PAT & " " & empleado.PE_APE_MAT & " " & empleado.PE_NOM_PRI
                    txt_id_personal.Text = empleado.PE_ID
                Next

                Call Cargar_Familiares()
            End If
            matriz = Nothing

        End If
    End Sub

    Private Sub txt_cod_personal_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_cod_personal.KeyDown
        If e.KeyCode = Keys.F2 Then
            Call Mostrar_Ayuda_Empleado()
        End If
    End Sub

    Private Sub txt_cod_personal_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_cod_personal.ValueChanged
        If txt_cod_personal.Text.Trim.Length = 0 Then
            txt_id_personal.Text = String.Empty
            txt_nombres.Text = String.Empty
            Call LimpiaGrid(ug_listado, uds_Lista)
        End If
    End Sub

    Private Sub Tool_Nuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_Nuevo.Click


        If txt_id_personal.Text.Trim.Length = 0 Then
            Avisar("Seleccione un personal")
            txt_cod_personal.Focus()
            Exit Sub
        End If

        Bol_Nuevo = True
        Call Cambiar_Estado_Botones_Tool(ToolS_Mantenimiento)
        Call Limpiar_Controls_InGroupox(ugb_datos_personales)
        Call Limpiar_Controls_InGroupox(ugb_direccion)
        Call Limpiar_Controls_InGroupox(ugb_baja)
        Call Limpiar_Controls_InGroupox(ugb_det_dir)
        Call MostrarTabs(1, utc_Contenedor, 1)
        uce_pais.Value = "604" 'peru

        uce_tip_doc.SelectedIndex = 0
        uce_vinculo.SelectedIndex = 0
        uce_doc_vinculo.SelectedIndex = 0
        uce_tip_via.SelectedIndex = 0
        uce_tip_zona.SelectedIndex = 0
        uce_tip_doc.Enabled = True
        txt_num_doc.Enabled = True
        ume_baja.Value = Nothing

        txt_cod_personal.Enabled = False
        udte_mes_concep.Value = Nothing

        txt_ape_pat.Focus()

    End Sub

    Private Sub Tool_Grabar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_Grabar.Click


        If txt_ape_pat.Text.Trim.Length = 0 Then
            Avisar("Ingrese el apellido paterno")
            txt_ape_pat.Focus()
            Exit Sub
        End If

        If txt_ape_mat.Text.Trim.Length = 0 Then
            Avisar("Ingrese el apellido materno")
            txt_ape_mat.Focus()
            Exit Sub
        End If

        If txt_nom.Text.Trim.Length = 0 Then
            Avisar("Ingrese el nombre")
            txt_nom.Focus()
            Exit Sub
        End If

        If txt_num_doc.Text.Trim.Length = 0 Then
            Avisar("Ingrese el numero del Documento de Identidad")
            txt_num_doc.Focus()
            Exit Sub
        End If




        Dim derechoBE As New BE.PlanillaBE.SG_PL_TB_DERECHO_HABIENTE
        Dim derechoBL As New BL.PlanillaBL.SG_PL_TB_DERECHO_HABIENTE

        With derechoBE
            .DA_IDPERSONAL = txt_id_personal.Text.Trim
            .DA_TDOC_DA = uce_tip_doc.Value
            .DA_NDOC_DA = txt_num_doc.Text
            .DA_IDPAIS = uce_pais.Value
            .DA_FEC_NAC = udte_fec_nac.Value
            .DA_APE_PAT = txt_ape_pat.Text.Trim
            .DA_APE_MAT = txt_ape_mat.Text.Trim
            .DA_NOMBRES = txt_nom.Text.Trim
            .DA_SEXO = uos_PE_ID_SEXO.Value
            .DA_VINCULO_FAM = uce_vinculo.Value
            .DA_TDOC_ACRE_VIN = uce_doc_vinculo.Value
            .DA_NDOC_ACRE_VIN = txt_num_doc_vinculo.Text.Trim
            .DA_MES_CONCEPCION = udte_mes_concep.Value
            .DA_TIPO_VIA = uce_tip_via.Value
            .DA_NOM_VIA = txt_nom_via.Text.Trim
            .DA_NUM_VIA = txt_num_via.Text.Trim
            .DA_DEPARTAMENTO = txt_depa.Text.Trim
            .DA_INTERIOR = txt_interior.Text.Trim
            .DA_MANZANA = txt_manzana.Text.Trim
            .DA_LOTE = txt_lote.Text.Trim
            .DA_KILOMETRO = txt_kilo.Text.Trim
            .DA_BLOCK = txt_block.Text.Trim.Trim
            .DA_ETAPA = txt_etapa.Text.Trim
            .DA_TIPO_ZONA = uce_tip_zona.Value
            .DA_NOM_ZONA = txt_nom_zona.Text.Trim
            .DA_REFERENCIA = txt_refe.Text.Trim
            .DA_UBIGEO = txt_ubigeo.Text.Trim
            .DA_TEL_COD_CIUDAD = txt_cod_tel.Text.Trim
            .DA_TEL_NUMERO = txt_num_tel.Text.Trim
            .DA_CORREO = txt_correo.Text.Trim

            .DA_USUARIO = String.Format("{0}-{1}", Environment.UserName, gStr_Usuario_Sis)
            .DA_TERMINAL = Environment.MachineName
            .DA_FECREG = Date.Now

            If ume_baja.Value.ToString = String.Empty Then
                .DA_FEC_BAJA = String.Empty
            Else
                .DA_FEC_BAJA = ume_baja.Value
            End If

            .DA_IDMOTIVO = uce_motivo_baja.Value

        End With

        If Bol_Nuevo Then
            derechoBL.Insert(derechoBE)
        Else
            derechoBL.Update(derechoBE)
        End If

        derechoBE = Nothing
        derechoBL = Nothing

        Call Avisar("Listo!")

        Call Cargar_Familiares()

        Call Tool_Cancelar_Click(sender, e)
    End Sub

    Private Sub txt_ape_pat_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_ape_pat.KeyDown, txt_correo.KeyDown, txt_num_tel.KeyDown, txt_cod_tel.KeyDown, txt_etapa.KeyDown, txt_block.KeyDown, txt_kilo.KeyDown, txt_lote.KeyDown, txt_manzana.KeyDown, txt_depa.KeyDown, udte_fec_nac.KeyDown, uce_vinculo.KeyDown, uce_tip_doc.KeyDown, uce_tip_zona.KeyDown, uce_tip_via.KeyDown, uce_pais.KeyDown, uce_motivo_baja.KeyDown, uce_doc_vinculo.KeyDown, txt_ubigeo.KeyDown, txt_refe.KeyDown, txt_num_via.KeyDown, txt_num_doc_vinculo.KeyDown, txt_num_doc.KeyDown, txt_nom_zona.KeyDown, txt_nom_via.KeyDown, txt_nom.KeyDown, txt_interior.KeyDown, txt_ape_mat.KeyDown
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send(vbTab)
        End If
        If e.KeyCode = Keys.F2 Then
            PL_MA_Ubigeo.ShowDialog()
            If PL_MA_Ubigeo.Bol_Aceptar Then
                txt_ubigeo.Text = PL_MA_Ubigeo.Str_Ubigeo.ToString
            End If
        End If
    End Sub

    Private Sub Tool_Editar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_Editar.Click


        If ug_listado.Rows.Count = 0 Then Exit Sub

        Bol_Nuevo = False
        Call Cambiar_Estado_Botones_Tool(ToolS_Mantenimiento)
        Call Limpiar_Controls_InGroupox(ugb_datos_personales)
        Call Limpiar_Controls_InGroupox(ugb_direccion)
        Call Limpiar_Controls_InGroupox(ugb_baja)
        Call Limpiar_Controls_InGroupox(ugb_det_dir)

        ume_baja.Value = Nothing


        Dim derechoBE As New BE.PlanillaBE.SG_PL_TB_DERECHO_HABIENTE
        Dim derechoBL As New BL.PlanillaBL.SG_PL_TB_DERECHO_HABIENTE
        Dim dt_datos As DataTable = Nothing

        With derechoBE
            .DA_IDPERSONAL = txt_id_personal.Text.Trim
            .DA_TDOC_DA = ug_listado.ActiveRow.Cells("DA_TDOC_DA").Value
            .DA_NDOC_DA = ug_listado.ActiveRow.Cells("DA_NDOC_DA").Value
        End With

        dt_datos = derechoBL.get_Derecho_Habiente_x_IdPersonal(derechoBE)

        If dt_datos.Rows.Count > 0 Then
            With dt_datos.Rows(0)

                uce_tip_doc.Value = .Item("DA_TDOC_DA")
                txt_num_doc.Text = .Item("DA_NDOC_DA")
                uce_pais.Value = .Item("DA_IDPAIS")
                udte_fec_nac.Value = .Item("DA_FEC_NAC")
                txt_ape_pat.Text = .Item("DA_APE_PAT")
                txt_ape_mat.Text = .Item("DA_APE_MAT")
                txt_nom.Text = .Item("DA_NOMBRES")
                uos_PE_ID_SEXO.Value = .Item("DA_SEXO")
                uce_vinculo.Value = .Item("DA_VINCULO_FAM")
                uce_doc_vinculo.Value = .Item("DA_TDOC_ACRE_VIN")
                txt_num_doc_vinculo.Text = .Item("DA_NDOC_ACRE_VIN")
                If .Item("DA_MES_CONCEPCION").ToString = String.Empty Then
                    udte_mes_concep.Value = Nothing
                Else
                    udte_mes_concep.Value = .Item("DA_MES_CONCEPCION")
                End If

                uce_tip_via.Value = .Item("DA_TIPO_VIA")
                txt_nom_via.Text = .Item("DA_NOM_VIA")
                txt_num_via.Text = .Item("DA_NUM_VIA")
                txt_depa.Text = .Item("DA_DEPARTAMENTO")
                txt_interior.Text = .Item("DA_INTERIOR")
                txt_manzana.Text = .Item("DA_MANZANA")
                txt_lote.Text = .Item("DA_LOTE")
                txt_kilo.Text = .Item("DA_KILOMETRO")
                txt_block.Text = .Item("DA_BLOCK")
                txt_etapa.Text = .Item("DA_ETAPA")
                uce_tip_zona.Value = .Item("DA_TIPO_ZONA")
                txt_nom_zona.Text = .Item("DA_NOM_ZONA")
                txt_refe.Text = .Item("DA_REFERENCIA")
                txt_ubigeo.Text = .Item("DA_UBIGEO")
                txt_cod_tel.Text = .Item("DA_TEL_COD_CIUDAD")
                txt_num_tel.Text = .Item("DA_TEL_NUMERO")
                txt_correo.Text = .Item("DA_CORREO")

                ume_baja.Value = .Item("DA_FEC_BAJA")
                uce_motivo_baja.Value = .Item("DA_IDMOTIVO")

            End With
        End If

        txt_cod_personal.Enabled = False
        uce_tip_doc.Enabled = False
        txt_num_doc.Enabled = False

        derechoBE = Nothing
        derechoBL = Nothing
        Call MostrarTabs(1, utc_Contenedor, 1)
        txt_ape_pat.Focus()

    End Sub

    Private Sub Tool_Eliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_Eliminar.Click

        If Not Preguntar("Seguro de Eliminar?") Then Exit Sub

        Dim derechoBE As New BE.PlanillaBE.SG_PL_TB_DERECHO_HABIENTE
        Dim derechoBL As New BL.PlanillaBL.SG_PL_TB_DERECHO_HABIENTE

        With derechoBE
            .DA_IDPERSONAL = ug_listado.ActiveRow.Cells("DA_IDPERSONAL").Value
            .DA_TDOC_DA = ug_listado.ActiveRow.Cells("DA_TDOC_DA").Value
            .DA_NDOC_DA = ug_listado.ActiveRow.Cells("DA_NDOC_DA").Value
        End With

        derechoBL.Delete(derechoBE)

        Call Avisar("Listo!")

    End Sub

    Private Sub Tool_Cancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_Cancelar.Click
        Call Cambiar_Estado_Botones_Tool(ToolS_Mantenimiento)
        Call MostrarTabs(0, utc_Contenedor, 0)
        txt_cod_personal.Enabled = True
    End Sub

    Private Sub txt_cod_personal_EditorButtonClick(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinEditors.EditorButtonEventArgs) Handles txt_cod_personal.EditorButtonClick
        Call Mostrar_Ayuda_Empleado()
    End Sub

    Private Sub udte_mes_concep_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles udte_mes_concep.KeyDown
        If e.KeyCode = Keys.Enter Then
            uce_tip_via.Focus()
        End If
    End Sub

    Private Sub Tool_Reporte_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_Reporte.Click
        PL_MA_Opc_Reporte.ShowDialog()

        If PL_MA_Opc_Reporte.bol_salir Then
            Exit Sub
        End If

        If PL_MA_Opc_Reporte.bol_listado Then
            Dim reportesBL As New BL.PlanillaBL.SG_PL_TB_DERECHO_HABIENTE
            Dim crystalBL As New LR.ClsReporte
            Dim dt_data As DataTable = reportesBL.get_Derecho_Habiente_Rep(gInt_IdEmpresa)

            crystalBL.Muestra_Reporte(gStr_RutaRep & "\SG_PL_04.rpt", dt_data, "", "pEmpresa;" & gStr_NomEmpresa)

            crystalBL.Dispose()
            reportesBL = Nothing
        End If

        If PL_MA_Opc_Reporte.bol_ficha Then

            Dim reportesBL As New BL.PlanillaBL.SG_PL_TB_DERECHO_HABIENTE
            Dim crystalBL As New LR.ClsReporte
            Dim dt_data As DataTable = reportesBL.get_Derecho_Habiente_Rep(gInt_IdEmpresa)

            crystalBL.Muestra_Reporte(gStr_RutaRep & "\SG_PL_05.rpt", dt_data, "", "pEmpresa;" & gStr_NomEmpresa)

            crystalBL.Dispose()
            reportesBL = Nothing
        End If

    End Sub

    Private Sub ug_listado_DoubleClickRow(sender As System.Object, e As Infragistics.Win.UltraWinGrid.DoubleClickRowEventArgs) Handles ug_listado.DoubleClickRow
        Tool_Editar_Click(sender, e)
    End Sub
End Class