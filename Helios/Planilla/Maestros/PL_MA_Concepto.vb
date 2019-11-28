Public Class PL_MA_Concepto
    Dim Bol_Nuevo As Boolean = False

    Private Sub PL_MA_Concepto_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call Inicializar_Estado_Botones_Tool(ToolS_Mantenimiento)
        Call Cargar_Lista_Conceptos()
        Call Formatear_Grilla_Selector(ug_Listado)
        Call Cargar_Tipo_Concepto()
        Call Cargar_Estado_Concepto()
        Call Cargar_Alcance_Concepto()
        Call Cargar_Identificador_Concepto()
        Call Cargar_Cuentas_Combo()
        Call MostrarTabs(0, utc_Mantenimiento, 0)

    End Sub

    Private Sub Cargar_Lista_Conceptos()
        Dim conceptoBL As New BL.PlanillaBL.SG_PL_TB_CONCEPTOS
        Dim dt_tmp As DataTable = conceptoBL.get_Conceptos(New BE.ContabilidadBE.SG_CO_TB_EMPRESA With {.EM_ID = gInt_IdEmpresa})

        Call LimpiaGrid(ug_Listado, uds_Listado)

        For i As Integer = 0 To dt_tmp.Rows.Count - 1
            ug_Listado.DisplayLayout.Bands(0).AddNew()
            ug_Listado.Rows(i).Cells("CO_ID").Value = dt_tmp.Rows(i)("CO_ID")
            ug_Listado.Rows(i).Cells("CO_DESCRIPCION").Value = dt_tmp.Rows(i)("CO_DESCRIPCION")
            ug_Listado.Rows(i).Cells("TC_DESCRIPCION").Value = dt_tmp.Rows(i)("TC_DESCRIPCION").ToString.Substring(0, 2)
            ug_Listado.Rows(i).Cells("CO_VALOR").Value = dt_tmp.Rows(i)("CO_VALOR")
            ug_Listado.Rows(i).Cells("CO_ESTADO").Value = IIf(dt_tmp.Rows(i)("CO_ESTADO") = 1, True, False)
            ug_Listado.Rows(i).Cells("AC_DESCRIPCION").Value = dt_tmp.Rows(i)("AC_DESCRIPCION").ToString.Substring(0, 2)
            ug_Listado.Rows(i).Cells("ID_DESCRIPCION").Value = dt_tmp.Rows(i)("ID_DESCRIPCION").ToString.Substring(0, 2)
            ug_Listado.Rows(i).Cells("CO_ID_CUENTA_D").Value = dt_tmp.Rows(i)("CO_ID_CUENTA_D").ToString
            ug_Listado.Rows(i).Cells("CO_ID_CUENTA_H").Value = dt_tmp.Rows(i)("CO_ID_CUENTA_H").ToString
            ug_Listado.Rows(i).Cells("CO_ID_SUNAT").Value = dt_tmp.Rows(i)("CO_ID_SUNAT").ToString
            ug_Listado.Rows(i).Cells("CO_AFECTA_CTS").Value = IIf(dt_tmp.Rows(i)("CO_AFECTA_CTS") = 1, True, False)
        Next

        ug_Listado.UpdateData()

        If ug_Listado.Rows.Count > 0 Then ug_Listado.Rows(0).Activate()

    End Sub

    Private Sub Cargar_Tipo_Concepto()
        Dim tipoBL As New BL.PlanillaBL.SG_PL_TB_TIPO_CONCEPTO
        uce_Tipo.DataSource = tipoBL.get_Tipos
        uce_Tipo.ValueMember = "TC_ID"
        uce_Tipo.DisplayMember = "TC_DESCRIPCION"
        tipoBL = Nothing
    End Sub

    Private Sub Cargar_Estado_Concepto()
        uce_Estado.Items.Clear()
        uce_Estado.Items.Add(1, "Activo")
        uce_Estado.Items.Add(2, "Desactivado")
    End Sub

    Private Sub Cargar_Alcance_Concepto()
        Dim alcanceBL As New BL.PlanillaBL.SG_PL_TB_ALCANCE_CONCEPTO
        uce_Alcance.DataSource = alcanceBL.get_Alcances
        uce_Alcance.ValueMember = "AC_ID"
        uce_Alcance.DisplayMember = "AC_DESCRIPCION"
        alcanceBL = Nothing
    End Sub

    Private Sub Cargar_Identificador_Concepto()
        Dim identificadorBL As New BL.PlanillaBL.SG_PL_TB_IDENTIFICADOR
        uce_Identificador.DataSource = identificadorBL.get_Identificadores()
        uce_Identificador.ValueMember = "ID_ID"
        uce_Identificador.DisplayMember = "ID_DESCRIPCION"
        identificadorBL = Nothing
    End Sub

    Private Sub Cargar_Conceptos_Sunat(ByVal int_tipo As Integer)
        Dim conceptoSunatBL As New BL.PlanillaBL.SG_PL_TB_CONCEPTO_SUNAT
        Dim conceptoSunatBE As New BE.PlanillaBE.SG_PL_TB_CONCEPTO_SUNAT
        conceptoSunatBE.CS_TIPO = int_tipo
        uc_cod_sunat.DataSource = conceptoSunatBL.get_Conceptos_x_Tipo(conceptoSunatBE)
        conceptoSunatBE = Nothing
        conceptoSunatBL = Nothing
    End Sub

    Private Sub Cargar_Cuentas_Combo()

        Dim PlanCtasBL As New BL.ContabilidadBL.SG_CO_TB_PLANCTAS
        Dim PlanCtasBE As New BE.ContabilidadBE.SG_CO_TB_PLANCTAS

        PlanCtasBE.PC_IDEMPRESA = New BE.ContabilidadBE.SG_CO_TB_EMPRESA With {.EM_ID = gInt_IdEmpresa}
        PlanCtasBE.PC_PERIODO = gDat_Fecha_Sis.Year

        uc_Cuentas_d.DataSource = PlanCtasBL.getCuentas_Movimiento(PlanCtasBE)
        uc_Cuentas_h.DataSource = PlanCtasBL.getCuentas_Movimiento(PlanCtasBE)

        PlanCtasBE = Nothing
        PlanCtasBL = Nothing

    End Sub

    Private Sub uce_Identificador_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles uce_Identificador.ValueChanged
        Call Cargar_Conceptos_Sunat(uce_Identificador.Value)
    End Sub

    Private Sub Tool_Salir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_Salir.Click
        Me.Close()
    End Sub

    Private Sub Tool_Nuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_Nuevo.Click
        Bol_Nuevo = True
        Call Cambiar_Estado_Botones_Tool(ToolS_Mantenimiento)
        Call Limpiar_Controls_InGroupox(ugb1)
        Call Limpiar_Controls_InGroupox(ugb2)
        Call MostrarTabs(1, utc_Mantenimiento, 1)

        Dim conceptoBL As New BL.PlanillaBL.SG_PL_TB_CONCEPTOS
        txt_cod_int.Text = conceptoBL.get_Ultimo_Num_Interno_concepto(gInt_IdEmpresa)
        conceptoBL = Nothing

        uce_Tipo.SelectedIndex = 1
        uce_Estado.SelectedIndex = 0
        uce_Alcance.SelectedIndex = 0
        uce_Identificador.SelectedIndex = 0
        uc_Cuentas_d.Value = Nothing
        uc_Cuentas_h.Value = Nothing
        ume_valor.Value = 0
        txt_Codigo.Enabled = True
        txt_Codigo.Focus()

    End Sub

    Private Sub Tool_Cancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_Cancelar.Click
        Call Cambiar_Estado_Botones_Tool(ToolS_Mantenimiento)
        Call MostrarTabs(0, utc_Mantenimiento, 0)
    End Sub

    Private Sub uc_Cuentas_d_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles uc_Cuentas_d.ValueChanged
        Try
            lbl_des_cta_d.Text = uc_Cuentas_d.ActiveRow.Cells("PC_DESCRIPCION").Value
            lbl_des_cta_d.Appearance.ForeColor = Color.Black
        Catch ex As Exception

            lbl_des_cta_d.Text = "*La cuenta no existe!"
            lbl_des_cta_d.Appearance.ForeColor = Color.Red
            If lbl_des_cta_d.Text.Trim.Length = 0 Then lbl_des_cta_d.Text = ""
        End Try
    End Sub

    Private Sub uc_Cuentas_h_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles uc_Cuentas_h.ValueChanged
        Try
            lbl_des_cta_h.Text = uc_Cuentas_h.ActiveRow.Cells("PC_DESCRIPCION").Value
            lbl_des_cta_h.Appearance.ForeColor = Color.Black
        Catch ex As Exception
            lbl_des_cta_h.Text = "*La cuenta no existe!"
            lbl_des_cta_h.Appearance.ForeColor = Color.Red
        End Try
    End Sub

    Private Sub txt_Codigo_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_Codigo.KeyDown, ume_valor.KeyDown, uchk_no_proyecta.KeyDown, uchk_no_a_quinta.KeyDown, uchk_no_a_afp.KeyDown, uchk_afecta_grati.KeyDown, uce_Tipo.KeyDown, uce_Identificador.KeyDown, uce_Estado.KeyDown, uce_Alcance.KeyDown, uc_Cuentas_h.KeyDown, uc_Cuentas_d.KeyDown, uc_cod_sunat.KeyDown, txt_des.KeyDown, uchk_afecta_cts.KeyDown
        If e.KeyCode = Keys.Enter Then SendKeys.Send(vbTab)
    End Sub

    Private Sub Tool_Grabar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_Grabar.Click

        If txt_Codigo.Text.Trim.Length = 0 Then
            Avisar("Ingrese Codigo de Concepto")
            txt_Codigo.Focus()
            Exit Sub
        End If

        If txt_des.Text.Trim.Length = 0 Then
            Avisar("Ingrese la Descripcion de Concepto")
            txt_des.Focus()
            Exit Sub
        End If

        Dim conceptoBL As New BL.PlanillaBL.SG_PL_TB_CONCEPTOS
        Dim conceptoBE As New BE.PlanillaBE.SG_PL_TB_CONCEPTOS

        With conceptoBE
            .CO_ID = txt_Codigo.Text.Trim
            .CO_DESCRIPCION = txt_des.Text.Trim
            .CO_ID_TIPO = New BE.PlanillaBE.SG_PL_TB_TIPO_CONCEPTO With {.TC_ID = uce_Tipo.Value}
            .CO_VALOR = Val(ume_valor.Value.ToString)
            .CO_ESTADO = uce_Estado.Value
            .CO_ID_ALCANCE = New BE.PlanillaBE.SG_PL_TB_ALCANCE_CONCEPTO With {.AC_ID = uce_Alcance.Value}
            .CO_ID_IDENTIFICADOR = New BE.PlanillaBE.SG_PL_TB_IDENTIFICADOR With {.ID_ID = uce_Identificador.Value}
            .CO_ID_CUENTA_D = New BE.ContabilidadBE.SG_CO_TB_PLANCTAS With {.PC_NUM_CUENTA = uc_Cuentas_d.Value}
            .CO_ID_CUENTA_H = New BE.ContabilidadBE.SG_CO_TB_PLANCTAS With {.PC_NUM_CUENTA = uc_Cuentas_h.Value}
            .CO_ID_SUNAT = New BE.PlanillaBE.SG_PL_TB_CONCEPTO_SUNAT With {.CS_ID = uc_cod_sunat.Value}
            .CO_NO_AFECT_AFP = IIf(uchk_no_a_afp.Checked, 1, 0)
            .CO_NO_AFECTA_QUINTA = IIf(uchk_no_a_quinta.Checked, 1, 0)
            .CO_NO_PROYECTA_QUINTA = IIf(uchk_no_proyecta.Checked, 1, 0)
            .CO_AFECTA_GRATI = IIf(uchk_afecta_grati.Checked, 1, 0)
            .CO_ID_INTERNO = Val(txt_cod_int.Text.Trim)
            .CO_USUARIO = String.Format("{0}-{1}", Environment.UserName, gStr_Usuario_Sis)
            .CO_TERMINAL = Environment.MachineName
            .CO_FECREG = Date.Now
            .CO_ID_EMPRESA = New BE.ContabilidadBE.SG_CO_TB_EMPRESA With {.EM_ID = gInt_IdEmpresa}
            .CO_ES_AFP = IIf(uchk_EsAfp.Checked, 1, 0)
            .CO_AFECTA_CTS = IIf(uchk_afecta_cts.Checked, 1, 0)
        End With

        If Bol_Nuevo Then
            conceptoBL.Insert(conceptoBE)
        Else
            conceptoBL.Update(conceptoBE)
        End If

        Call Avisar("    Listo!  ")
        Call Cargar_Lista_Conceptos()

        If Not Bol_Nuevo Then
            For i As Integer = 0 To ug_Listado.Rows.Count - 1
                If ug_Listado.Rows(i).Cells("CO_ID").Value = conceptoBE.CO_ID Then
                    ug_Listado.Focus()
                    ug_Listado.Rows(i).Activate()
                    Exit For
                End If
            Next
        End If

        Call MostrarTabs(0, utc_Mantenimiento, 0)
        Call Cambiar_Estado_Botones_Tool(ToolS_Mantenimiento)
        conceptoBE = Nothing
        conceptoBL = Nothing

    End Sub

    Private Sub Tool_Eliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_Eliminar.Click

        If ug_Listado.Rows.Count = 0 Then Exit Sub
        If ug_Listado.ActiveRow.IsFilterRow Then Exit Sub
        If ug_Listado.ActiveRow Is Nothing Then Exit Sub


        If Preguntar("Esta seguro de eliminar?") Then
            Dim conceptoBL As New BL.PlanillaBL.SG_PL_TB_CONCEPTOS
            Dim conceptoBE As New BE.PlanillaBE.SG_PL_TB_CONCEPTOS
            conceptoBE.CO_ID = ug_Listado.ActiveRow.Cells("CO_ID").Value
            conceptoBE.CO_ID_EMPRESA = New BE.ContabilidadBE.SG_CO_TB_EMPRESA With {.EM_ID = gInt_IdEmpresa}
            conceptoBL.Delete(conceptoBE)
            Call Cargar_Lista_Conceptos()
            conceptoBE = Nothing
            conceptoBL = Nothing
        End If
    End Sub

    Private Sub Tool_Editar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_Editar.Click

        If ug_Listado.ActiveRow.IsFilterRow Then Exit Sub

        If ug_Listado.Rows.Count = 0 Then Exit Sub

        Dim conceptoBL As New BL.PlanillaBL.SG_PL_TB_CONCEPTOS
        Dim conceptoBE As New BE.PlanillaBE.SG_PL_TB_CONCEPTOS
        conceptoBE.CO_ID = ug_Listado.ActiveRow.Cells("CO_ID").Value
        conceptoBE.CO_ID_EMPRESA = New BE.ContabilidadBE.SG_CO_TB_EMPRESA With {.EM_ID = gInt_IdEmpresa}
        Dim dt_tmp As DataTable = conceptoBL.get_Conceptos_x_Id(conceptoBE)

        Call Limpiar_Controls_InGroupox(ugb1)
        Call Limpiar_Controls_InGroupox(ugb2)

        txt_Codigo.Text = dt_tmp.Rows(0)("CO_ID")
        txt_des.Text = dt_tmp.Rows(0)("CO_DESCRIPCION")
        uce_Tipo.Value = dt_tmp.Rows(0)("CO_ID_TIPO")
        ume_valor.Value = dt_tmp.Rows(0)("CO_VALOR")
        uce_Estado.Value = dt_tmp.Rows(0)("CO_ESTADO")
        uce_Alcance.Value = dt_tmp.Rows(0)("CO_ID_ALCANCE")
        uce_Identificador.Value = dt_tmp.Rows(0)("CO_ID_IDENTIFICADOR")
        uc_Cuentas_d.Value = IIf(dt_tmp.Rows(0)("CO_ID_CUENTA_D").ToString = "", Nothing, dt_tmp.Rows(0)("CO_ID_CUENTA_D"))
        uc_Cuentas_h.Value = IIf(dt_tmp.Rows(0)("CO_ID_CUENTA_H").ToString = "", Nothing, dt_tmp.Rows(0)("CO_ID_CUENTA_H"))
        uc_cod_sunat.Value = dt_tmp.Rows(0)("CO_ID_SUNAT")
        uchk_no_a_afp.Checked = IIf(dt_tmp.Rows(0)("CO_NO_AFECT_AFP") = 1, True, False)
        uchk_no_a_quinta.Checked = IIf(dt_tmp.Rows(0)("CO_NO_AFECTA_QUINTA") = 1, True, False)
        uchk_no_proyecta.Checked = IIf(dt_tmp.Rows(0)("CO_NO_PROYECTA_QUINTA") = 1, True, False)
        uchk_afecta_grati.Checked = IIf(dt_tmp.Rows(0)("CO_AFECTA_GRATI") = 1, True, False)
        txt_cod_int.Text = dt_tmp.Rows(0)("CO_ID_INTERNO")
        uchk_EsAfp.Checked = IIf(dt_tmp.Rows(0)("CO_ES_AFP") = 1, True, False)
        uchk_afecta_cts.Checked = IIf(dt_tmp.Rows(0)("CO_AFECTA_CTS") = 1, True, False)

        Call MostrarTabs(1, utc_Mantenimiento, 1)
        Call Cambiar_Estado_Botones_Tool(ToolS_Mantenimiento)

        Bol_Nuevo = False
        txt_Codigo.Enabled = False
        txt_des.Focus()

        dt_tmp.Dispose()
        conceptoBE = Nothing
        conceptoBL = Nothing
    End Sub

    Private Sub ug_Listado_DoubleClickRow(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.DoubleClickRowEventArgs) Handles ug_Listado.DoubleClickRow

        If ug_Listado.ActiveRow Is Nothing Then Exit Sub
        If e.Row.IsFilterRow Then Exit Sub

        If ug_Listado.Rows.Count = 0 Then Exit Sub



        Call Tool_Editar_Click(sender, e)
    End Sub

    Private Sub uc_Cuentas_d_InitializeLayout(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.InitializeLayoutEventArgs) Handles uc_Cuentas_d.InitializeLayout

    End Sub

    Private Sub txt_Codigo_LostFocus(sender As Object, e As System.EventArgs) Handles txt_Codigo.LostFocus

        If txt_Codigo.Text.Trim.Length = 0 Then Exit Sub
        Dim conceptoBL As New BL.PlanillaBL.SG_PL_TB_CONCEPTOS
        Dim conceptoBE As New BE.PlanillaBE.SG_PL_TB_CONCEPTOS
        conceptoBE.CO_ID = txt_Codigo.Text.Trim
        conceptoBE.CO_ID_EMPRESA = New BE.ContabilidadBE.SG_CO_TB_EMPRESA With {.EM_ID = gInt_IdEmpresa}
        Dim dt_tmp As DataTable = conceptoBL.get_Conceptos_x_Id(conceptoBE)
        If dt_tmp.Rows.Count > 0 Then
            Avisar("El Codigo de Concepto ya esta registrado")
            dt_tmp.Dispose()
            conceptoBE = Nothing
            conceptoBL = Nothing
            txt_Codigo.Text = String.Empty
        End If

        dt_tmp.Dispose()
        conceptoBE = Nothing
        conceptoBL = Nothing
    End Sub
End Class