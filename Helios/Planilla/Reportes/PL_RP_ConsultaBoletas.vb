Public Class PL_RP_ConsultaBoletas

    Dim str_ruc As String = ""
    Dim nombreReprote As String = "SG_PL_08.rpt"
    Dim nombreEmpleador As String = "SG_PL_08.rpt"


    Private Sub PL_RP_ConsultaBoletas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        'cargamos el periodo
        Call CargarCombo_ConMeses(uce_Mes)
        une_ayo.Value = gDat_Fecha_Sis.Year
        uce_Mes.Value = gDat_Fecha_Sis.Month

        Call Cargar_TipoPersonal()

        'cargamos la lista de trabajadores
        Call Cargar_Trabajadores_bs()

        Call Formatear_Grilla_Selector(ug_haberes)
        Call Formatear_Grilla_Selector(ug_descuentos)
        Call Formatear_Grilla_Selector(ug_aportaciones)
        Call Obtener_Nombre_Reporte_Boleta()
        Call Cargar_Nombre_Empleador()

        'cargamos el ruc de la empresa actual para no demorar en el reporte
        Dim empresaBE As New BE.ContabilidadBE.SG_CO_TB_EMPRESA With {.EM_ID = gInt_IdEmpresa}
        Dim empresaBL As New BL.ContabilidadBL.SG_CO_TB_EMPRESA
        empresaBL.getEmpresas_2(empresaBE)

        str_ruc = empresaBE.EM_RUC

        empresaBE = Nothing
        empresaBL = Nothing

        txt_nombres.ButtonsRight(0).Appearance.Image = My.Resources._16__Db_previous_
        txt_nombres.ButtonsRight(1).Appearance.Image = My.Resources._16__Db_next_
        txt_codper.ButtonsRight(0).Appearance.Image = My.Resources._104
    End Sub

    Private Sub Obtener_Nombre_Reporte_Boleta()
        Dim paraetrosBL As New BL.PlanillaBL.SG_PL_TB_PARAMETROS
        Dim paraetrosBE As New BE.PlanillaBE.SG_PL_TB_PARAMETROS
        paraetrosBE.AD_IDEMPRESA = gInt_IdEmpresa
        paraetrosBE.AD_TIPO = "REPOR"
        paraetrosBE.AD_NOMBRE = "BOLETA"

        nombreReprote = paraetrosBL.get_Valor(paraetrosBE)

        paraetrosBE = Nothing
        paraetrosBL = Nothing

        If nombreReprote = String.Empty Then
            Avisar("No esta establecido el reporte de la Boleta")
        End If

    End Sub

    Private Sub Cargar_Nombre_Empleador()

        Dim empresaBL As New BL.ContabilidadBL.SG_CO_TB_EMPRESA
        Dim empresaBE As New BE.ContabilidadBE.SG_CO_TB_EMPRESA
        empresaBE.EM_ID = gInt_IdEmpresa
        empresaBL.getEmpresas_2(empresaBE)

        nombreEmpleador = empresaBE.EM_REPRESENTANTE.ToString

        empresaBE = Nothing
        empresaBL = Nothing

        If nombreEmpleador = String.Empty Then
            Avisar("El nombre del Representante no esta establecido")
        End If

    End Sub

    Private Sub Cargar_TipoPersonal()
        Dim tipoPersonalBL As New BL.PlanillaBL.SG_PL_TB_TIPO_PERSONAL
        uce_TipoPersonal.DataSource = tipoPersonalBL.getTipos()
        uce_TipoPersonal.ValueMember = "TP_ID"
        uce_TipoPersonal.DisplayMember = "TP_DESCRIPCION"
        tipoPersonalBL = Nothing
    End Sub

    Private Sub Cargar_Trabajadores_bs()

        Dim tmp_id As String = txt_idpersonal.Text.Trim
        Dim tmp_cod As String = txt_codper.Text.Trim
        Dim tmp_pat As String = txt_ape_pat.Text.Trim
        Dim tmp_mat As String = txt_ape_mat.Text.Trim
        Dim tmp_nom As String = txt_nom.Text.Trim

        Dim personalBL As New BL.PlanillaBL.SG_PL_TB_PERSONAL
        Dim personalBE As New BE.PlanillaBE.SG_PL_TB_PERSONAL
        personalBE.PE_ID_EMPRESA = gInt_IdEmpresa
        personalBE.PE_ID_TIPO_PER = uce_TipoPersonal.Value

        Try
            txt_idpersonal.DataBindings.Clear()
            txt_codper.DataBindings.Clear()
            txt_ape_pat.DataBindings.Clear()
            txt_ape_mat.DataBindings.Clear()
            txt_nom.DataBindings.Clear()
            bs_trabajadores.DataSource = Nothing
        Catch ex As Exception

        End Try

        bs_trabajadores.DataSource = personalBL.getPersonal_Consula_Boleta(personalBE, une_ayo.Value, uce_Mes.Value)

        txt_idpersonal.DataBindings.Add(New System.Windows.Forms.Binding("Text", bs_trabajadores, "PE_ID", True))

        txt_codper.DataBindings.Add(New System.Windows.Forms.Binding("Text", bs_trabajadores, "PE_CODIGO", True))

        txt_ape_pat.DataBindings.Add(New System.Windows.Forms.Binding("Text", bs_trabajadores, "PE_APE_PAT", True))

        txt_ape_mat.DataBindings.Add(New System.Windows.Forms.Binding("Text", bs_trabajadores, "PE_APE_mAT", True))

        txt_nom.DataBindings.Add(New System.Windows.Forms.Binding("Text", bs_trabajadores, "NOMBRES", True))

        bs_trabajadores.MoveFirst()
        bs_trabajadores.MoveNext()
        bs_trabajadores.MoveFirst()

        personalBE = Nothing
        personalBL = Nothing

        'If tmp_id <> "" Then
        '    txt_idpersonal.Text = tmp_id
        '    txt_codper.Text = tmp_cod
        '    txt_ape_pat.Text = tmp_pat
        '    txt_ape_mat.Text = tmp_mat
        '    txt_nom.Text = tmp_nom
        'End If
        

        Call LimpiaGrid(ug_haberes, uds_haberes)
        Call LimpiaGrid(ug_descuentos, uds_descuentos)
        Call LimpiaGrid(ug_aportaciones, uds_aportaciones)

        If txt_idpersonal.Text.Trim.Length > 0 Then
            Call Obtener_Boleta_Trabajador(txt_idpersonal.Text.Trim)
        End If
        txt_nombres.Text = txt_ape_pat.Text.Trim + " " + txt_ape_mat.Text.Trim + " " + txt_nom.Text.Trim

    End Sub

    Private Sub Cargar_Boleta_Trabajador(ByVal tipo As String, ByVal codigo_trabajador As Integer)

        Dim int_IdPersonal As Integer = 0

        If codigo_trabajador = 0 Then
            Select Case tipo
                Case "A"

                    If bs_trabajadores.Position - 1 >= 0 Then
                        bs_trabajadores.MovePrevious()
                    Else
                        bs_trabajadores.MoveLast()
                    End If

                Case "S"

                    If bs_trabajadores.Position + 1 < bs_trabajadores.Count Then
                        bs_trabajadores.MoveNext()
                    Else
                        bs_trabajadores.MoveFirst()
                    End If

            End Select

            If txt_idpersonal.Text.Trim = String.Empty Then
                Exit Sub
            End If
            int_IdPersonal = txt_idpersonal.Text.Trim

        Else
            int_IdPersonal = codigo_trabajador
            Dim item As Integer = bs_trabajadores.Find("PE_ID", codigo_trabajador)
            bs_trabajadores.Position = item
        End If

        Call Obtener_Boleta_Trabajador(int_IdPersonal)

    End Sub

    Private Sub Obtener_Boleta_Trabajador(ByVal int_IdPersonal As Integer)

        Dim histoBL As New BL.PlanillaBL.SG_PL_TB_HISTORIAL
        Dim histoBE As New BE.PlanillaBE.SG_PL_TB_HISTORIAL
        Dim ds_historial As DataSet

        histoBE.HI_FEC_OPE = une_Ayo.Value
        histoBE.HI_MES = uce_Mes.Value
        histoBE.HI_ID_EMPRESA = New BE.ContabilidadBE.SG_CO_TB_EMPRESA With {.EM_ID = gInt_IdEmpresa}
        histoBE.HI_ID_PERSONAL = New BE.PlanillaBE.SG_PL_TB_PERSONAL With {.PE_ID = int_IdPersonal}

        ds_historial = histoBL.get_Consulta_Boleta(histoBE)

        ug_haberes.DataSource = ds_historial.Tables(0)
        ug_descuentos.DataSource = ds_historial.Tables(1)
        ug_aportaciones.DataSource = ds_historial.Tables(2)

        uce_tot_hab.Value = 0
        uce_tot_des.Value = 0
        uce_tot_apo.Value = 0

        If ds_historial.Tables(0).Rows.Count > 0 Then uce_tot_hab.Value = ds_historial.Tables(0).Compute("sum(HI_MONTO)", "")
        If ds_historial.Tables(1).Rows.Count > 0 Then uce_tot_des.Value = ds_historial.Tables(1).Compute("sum(HI_MONTO)", "")
        If ds_historial.Tables(2).Rows.Count > 0 Then uce_tot_apo.Value = ds_historial.Tables(2).Compute("sum(HI_MONTO)", "")

        uce_neto.Value = uce_tot_hab.Value - uce_tot_des.Value


        histoBE = Nothing
        histoBL = Nothing

    End Sub

    Private Sub bs_trabajadores_PositionChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles bs_trabajadores.PositionChanged
        txt_nombres.Text = txt_ape_pat.Text.Trim + " " + txt_ape_mat.Text.Trim + " " + txt_nom.Text.Trim
    End Sub

    Private Sub Tool_Salir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_Salir.Click
        Me.Close()
    End Sub

   
    Private Sub ug_exporta_InitializeRow(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinGrid.InitializeRowEventArgs)
        If e.Row.Cells("HI_COD_HD").Value.ToString = "------" Then
            e.Row.Appearance.BackColor = Color.WhiteSmoke
            e.Row.Appearance.BackColor2 = Color.White
            e.Row.Appearance.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        End If

        If e.Row.Cells("HI_COD_HD").Value.ToString = "--" Then
            e.Row.Appearance.BackColor = Color.White
            e.Row.Appearance.BackColor2 = Color.White
            e.Row.Appearance.FontData.Bold = Infragistics.Win.DefaultableBoolean.True
            e.Row.Appearance.TextHAlign = Infragistics.Win.HAlign.Right
        End If

        If e.Row.Cells("HI_COD_HD").Value.ToString = "-" Then
            e.Row.Appearance.BackColor = Color.SkyBlue
            e.Row.Appearance.BackColor2 = Color.White
            e.Row.Appearance.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
            e.Row.Appearance.FontData.Bold = Infragistics.Win.DefaultableBoolean.True
            e.Row.Appearance.TextHAlign = Infragistics.Win.HAlign.Right
        End If

    End Sub

    Private Sub uce_Mes_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles uce_Mes.ValueChanged

        Dim codigo_trabajador As Integer = 0

        codigo_trabajador = Val(txt_idpersonal.Text)

        Call Cargar_Trabajadores_bs()
        'If txt_idpersonal.Text.Trim = "" Then Exit Sub

        Dim item As Integer = bs_trabajadores.Find("PE_ID", codigo_trabajador)
        bs_trabajadores.Position = item

        Call Obtener_Boleta_Trabajador(codigo_trabajador)

    End Sub

    Private Sub txt_codper_EditorButtonClick(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinEditors.EditorButtonEventArgs) Handles txt_codper.EditorButtonClick
        Call Mostrar_Ayuda_ListaPersonal()
    End Sub

    Private Sub uce_TipoPersonal_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles uce_TipoPersonal.ValueChanged
        If uce_TipoPersonal.SelectedIndex <> -1 Then
            Call Cargar_Trabajadores_bs()
        End If
    End Sub

    Private Sub txt_codper_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_codper.KeyDown
        If e.KeyCode = Keys.F2 Then
            Call Mostrar_Ayuda_ListaPersonal()
        End If
    End Sub

    Private Sub Mostrar_Ayuda_ListaPersonal()


        PL_PR_Lista_Personal.Int_tipo_Personal = uce_TipoPersonal.Value
        PL_PR_Lista_Personal.Bol_habilitar_uos = False
        PL_PR_Lista_Personal.Bol_MultiSeleccion = False
        PL_PR_Lista_Personal.ShowDialog()

        If PL_PR_Lista_Personal.Bol_Aceptar Then
            Dim matriz As New List(Of BE.PlanillaBE.SG_PL_TB_PERSONAL)
            matriz = PL_PR_Lista_Personal.lista_empleados
            If matriz.Count > 0 Then
                txt_codper.Text = matriz(0).PE_CODIGO
                txt_nombres.Text = matriz(0).PE_APE_PAT & " " & matriz(0).PE_APE_MAT & " " & matriz(0).PE_NOM_PRI
                txt_idpersonal.Text = matriz(0).PE_ID
                Call Cargar_Boleta_Trabajador("A", matriz(0).PE_ID)
            End If
        End If
    End Sub

    Private Sub Tool_rep_general_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_rep_general.Click
        Call Ver_Reporte(0)
    End Sub

    Private Sub Tool_reporte_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_reporte.Click
        Call Ver_Reporte(txt_idpersonal.Text.Trim)
    End Sub

    Private Sub Ver_Reporte(ByVal int_idpesonal_ As Integer)

        Me.Cursor = Cursors.WaitCursor

        Dim reportesBL As New BL.PlanillaBL.SG_PL_Reportes
        Dim crystalBL As New LR.ClsReporte
        Dim dt_boleta As DataTable = Nothing

        dt_boleta = reportesBL.get_Boleta_Mensual(une_Ayo.Value, uce_Mes.Value, uce_TipoPersonal.Value, int_idpesonal_, Environment.MachineName, gInt_IdEmpresa)

        crystalBL.Muestra_Reporte(gStr_RutaRep & "\" & nombreReprote, dt_boleta, "", _
                                  "pEmpresa;" & gStr_NomEmpresa, _
                                  "pRuc;" & str_ruc, _
                                  "pTipoPersonal;" & uce_TipoPersonal.Text.Trim, _
                                  "pMes;" & uce_Mes.Text.ToUpper.Trim & " " & une_ayo.Value.ToString, _
                                  "pEmpleador;" & nombreEmpleador)

        crystalBL = Nothing
        reportesBL = Nothing

        Me.Cursor = Cursors.Default

    End Sub

    Private Sub Ver_Reporte_Vacio(ByVal int_idpesonal_ As Integer)

        Me.Cursor = Cursors.WaitCursor

        Dim reportesBL As New BL.PlanillaBL.SG_PL_Reportes
        Dim crystalBL As New LR.ClsReporte
        Dim dt_boleta As DataTable = Nothing

        dt_boleta = reportesBL.get_Boleta_Mensual(une_ayo.Value, uce_Mes.Value, uce_TipoPersonal.Value, int_idpesonal_, Environment.MachineName, gInt_IdEmpresa)

        crystalBL.Muestra_Reporte(gStr_RutaRep & "\SG_PL_08_Vacio.rpt", dt_boleta, "", _
                                  "pEmpresa;" & gStr_NomEmpresa, _
                                  "pRuc;" & str_ruc, _
                                  "pTipoPersonal;" & uce_TipoPersonal.Text.Trim, _
                                  "pMes;" & uce_Mes.Text.ToUpper.Trim & " " & une_ayo.Value.ToString, _
                                  "pEmpleador;" & nombreEmpleador)

        crystalBL = Nothing
        reportesBL = Nothing

        Me.Cursor = Cursors.Default

    End Sub

    Private Sub txt_nombres_EditorButtonClick(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinEditors.EditorButtonEventArgs) Handles txt_nombres.EditorButtonClick
        Select Case e.Button.Key
            Case "btn_ant"
                Cargar_Boleta_Trabajador("A", 0)
            Case "btn_sig"
                Cargar_Boleta_Trabajador("S", 0)
            Case "btn_refrescar"
                If uce_TipoPersonal.SelectedIndex <> -1 Then
                    Call Cargar_Trabajadores_bs()
                End If
        End Select
    End Sub

    Private Sub uce_Mes_EditorButtonClick(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinEditors.EditorButtonEventArgs) Handles uce_Mes.EditorButtonClick
        Select Case e.Button.Key
            Case "btn_ant"

                If uce_Mes.Value > 1 Then
                    uce_Mes.Value -= 1
                End If

            Case "btn_sig"

                If uce_Mes.Value < 12 Then
                    uce_Mes.Value += 1
                End If

        End Select
    End Sub

    Private Sub txt_nombres_ValueChanged(sender As System.Object, e As System.EventArgs) Handles txt_nombres.ValueChanged

    End Sub

    Private Sub Tool_Vacio_Click(sender As System.Object, e As System.EventArgs) Handles Tool_Vacio.Click
        Call Ver_Reporte_Vacio(txt_idpersonal.Text.Trim)
    End Sub

End Class