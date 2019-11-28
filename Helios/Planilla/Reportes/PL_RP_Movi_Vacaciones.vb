Public Class PL_RP_Movi_Vacaciones

    Private Sub PL_RP_Movi_Vacaciones_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

        Call Cargar_Cargos_Personal()
        Call Formatear_Grilla_Selector(ug_vaca)
        udte_fec_corte.Value = Nothing
        txt_codper.ButtonsRight(0).Appearance.Image = My.Resources._104
        Call MostrarTabs(0, utc_1, 0)
        udte_fec_corte.Value = gDat_Fecha_Sis
        udte_fec_corte.Focus()

    End Sub

    Private Sub Cargar_Cargos_Personal()
        Dim cargosBL As New BL.PlanillaBL.SG_PL_TB_CARGO
        Dim cargosBE As New BE.PlanillaBE.SG_PL_TB_CARGO
        cargosBE.EC_IDEMPRESA = New BE.ContabilidadBE.SG_CO_TB_EMPRESA With {.EM_ID = gInt_IdEmpresa}
        uce_CARGO.DataSource = cargosBL.getCargos(cargosBE)
        uce_CARGO.ValueMember = "EC_ID"
        uce_CARGO.DisplayMember = "EC_CARGO"
        cargosBE = Nothing
        cargosBL = Nothing
    End Sub

    Private Sub Tool_Salir_Click(sender As System.Object, e As System.EventArgs) Handles Tool_Salir.Click
        Me.Close()
    End Sub

    Private Sub Tool_imprimir_Click(sender As System.Object, e As System.EventArgs) Handles Tool_imprimir.Click

        If udte_fec_corte.Value Is Nothing Then
            Avisar("Ingrese una fecha de corte")
            udte_fec_corte.Focus()
            Exit Sub
        End If

        Dim dt_tmp As DataTable = Nothing
        Dim reportesBL As New BL.PlanillaBL.SG_PL_Reportes

        Select Case uos_filtros.Value
            Case "0" 'todos
                If ug_vaca.Rows.Count <> 0 Then
                    dt_tmp = CType(ug_vaca.DataSource, DataTable)
                Else
                    dt_tmp = reportesBL.get_Movimi_Vacaciones(CDate(udte_fec_corte.Value), Environment.MachineName, 0, IIf(uchk_inicio.Checked, 1, 0), gInt_IdEmpresa)
                End If

            Case "1" 'por trabajador
                If txt_idpersonal.Text.Trim.Length = 0 Then
                    Avisar("Seleccione un trabajador")
                    txt_codper.Focus()
                    Exit Sub
                End If

                If ug_vaca.Rows.Count <> 0 Then
                    dt_tmp = CType(ug_vaca.DataSource, DataTable)
                Else
                    dt_tmp = reportesBL.get_Movimi_Vacaciones(CDate(udte_fec_corte.Value), Environment.MachineName, txt_idpersonal.Text.Trim, IIf(uchk_inicio.Checked, 1, 0), gInt_IdEmpresa)
                End If

            Case "2" 'por cargos
                If uce_CARGO.SelectedIndex = -1 Then
                    Avisar("Seleccione un Cargo")
                    uce_CARGO.Focus()
                    Exit Sub
                End If

                If ug_vaca.Rows.Count <> 0 Then
                    dt_tmp = CType(ug_vaca.DataSource, DataTable)
                Else
                    dt_tmp = reportesBL.get_Movimi_Vacaciones_x_Cargo(CDate(udte_fec_corte.Value), Environment.MachineName, uce_CARGO.Value, IIf(uchk_inicio.Checked, 1, 0), gInt_IdEmpresa)
                End If

        End Select


        Me.Cursor = Cursors.WaitCursor

        Dim str_fecha As String = udte_fec_corte.Value
        Using crystalBL As New LR.ClsReporte
            crystalBL.Muestra_Reporte(gStr_RutaRep & "\SG_PL_21.rpt", dt_tmp, "", "pEmp;" & gStr_NomEmpresa, _
                                                                              "pFecha;Fecha de Corte " & str_fecha.ToUpper)
        End Using

        reportesBL = Nothing
        Me.Cursor = Cursors.Default

    End Sub

    Private Sub Tool_Consultar_Click(sender As System.Object, e As System.EventArgs) Handles Tool_Consultar.Click

        Call Consultar()
    End Sub

    Private Sub Consultar()
        If udte_fec_corte.Value Is Nothing Then
            Avisar("Ingrese una fecha de corte")
            udte_fec_corte.Focus()
            Exit Sub
        End If

        Dim reportesBL As New BL.PlanillaBL.SG_PL_Reportes

        Select Case uos_filtros.Value
            Case "0" 'todos
                ug_vaca.DataSource = reportesBL.get_Movimi_Vacaciones(CDate(udte_fec_corte.Value), Environment.MachineName, 0, IIf(uchk_inicio.Checked, 1, 0), gInt_IdEmpresa)


            Case "1" 'por trabajador
                If txt_idpersonal.Text.Trim.Length = 0 Then
                    Avisar("Seleccione un trabajador")
                    txt_codper.Focus()
                    Exit Sub
                End If

                ug_vaca.DataSource = reportesBL.get_Movimi_Vacaciones(CDate(udte_fec_corte.Value), Environment.MachineName, txt_idpersonal.Text.Trim, IIf(uchk_inicio.Checked, 1, 0), gInt_IdEmpresa)


            Case "2" 'por cargos
                If uce_CARGO.SelectedIndex = -1 Then
                    Avisar("Seleccione un Cargo")
                    uce_CARGO.Focus()
                    Exit Sub
                End If

                ug_vaca.DataSource = reportesBL.get_Movimi_Vacaciones_x_Cargo(CDate(udte_fec_corte.Value), Environment.MachineName, uce_CARGO.Value, IIf(uchk_inicio.Checked, 1, 0), gInt_IdEmpresa)

        End Select

        reportesBL = Nothing
    End Sub

    Private Sub ug_vaca_InitializeGroupByRow(sender As System.Object, e As Infragistics.Win.UltraWinGrid.InitializeGroupByRowEventArgs) Handles ug_vaca.InitializeGroupByRow
        e.Row.Expanded = True
        If (e.Row.ChildBands.Count > 0) Then
            e.Row.ChildBands(0).Rows.ExpandAll(True)
            'e.Row.ChildBands(0).Rows.CollapseAll(True)
        End If

    End Sub

    Private Sub txt_codper_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles txt_codper.KeyDown
        If e.KeyCode = Keys.F2 Then Mostrar_Ayuda_Empleado()
    End Sub

    Private Sub Mostrar_Ayuda_Empleado()

        PL_PR_Lista_Personal.Int_tipo_Personal = 0
        PL_PR_Lista_Personal.Bol_habilitar_uos = True
        PL_PR_Lista_Personal.Bol_MultiSeleccion = False
        PL_PR_Lista_Personal.ShowDialog()
        If PL_PR_Lista_Personal.Bol_Aceptar Then
            Dim matriz As New List(Of BE.PlanillaBE.SG_PL_TB_PERSONAL)
            matriz = PL_PR_Lista_Personal.lista_empleados
            If matriz.Count > 0 Then

                For Each empleado As BE.PlanillaBE.SG_PL_TB_PERSONAL In matriz
                    txt_codper.Text = empleado.PE_CODIGO
                    txt_nombres.Text = empleado.PE_APE_PAT & " " & empleado.PE_APE_MAT & " " & empleado.PE_NOM_PRI
                    txt_idpersonal.Text = empleado.PE_ID
                Next
            End If
            matriz = Nothing
            Call Consultar()
        End If
    End Sub

    Private Sub txt_codper_EditorButtonClick(sender As System.Object, e As Infragistics.Win.UltraWinEditors.EditorButtonEventArgs) Handles txt_codper.EditorButtonClick
        Call Mostrar_Ayuda_Empleado()
    End Sub

    Private Sub txt_codper_TextChanged(sender As System.Object, e As System.EventArgs) Handles txt_codper.TextChanged
        If txt_codper.Text.Trim.Length = 0 Then
            txt_nombres.Text = String.Empty
            txt_idpersonal.Text = String.Empty
        End If
    End Sub

    Private Sub Tool_Enviar_Click(sender As System.Object, e As System.EventArgs) Handles Tool_Enviar.Click

        Select Case uos_filtros.Value
            Case "0"
            Case "1"
                Call Enviar_por_Trabajador()
            Case "2"
                Call Enviar_por_Cargo()
        End Select

    End Sub

    Private Sub Enviar_por_Trabajador()
        If txt_idpersonal.Text.Trim = "" Then
            Avisar("Seleccione un trabajador")
            Exit Sub
        End If

        Me.Cursor = Cursors.WaitCursor

        Dim dt_tmp As DataTable = Nothing
        Dim crystalBL As New LR.ClsFunciones
        Dim str_Ruta_archivo_pdf As String = String.Empty
        Dim str_nom_pdf As String = String.Empty
        Dim x As New BL.ContabilidadBL.MyCorreo


        If ug_vaca.Rows.Count <> 0 Then dt_tmp = CType(ug_vaca.DataSource, DataTable)
        crystalBL.CrearPDF(dt_tmp, gStr_RutaRep, str_Ruta_archivo_pdf, str_nom_pdf)

        PL_RP_EnvioMail.int_idpersonal = txt_idpersonal.Text.Trim
        'PL_RP_EnvioMail.dt_data_rep = dt_tmp
        PL_RP_EnvioMail.str_Ruta_nom_pdf = str_Ruta_archivo_pdf
        PL_RP_EnvioMail.str_Nom_Archivo_pdf = str_nom_pdf
        PL_RP_EnvioMail.str_fecha = CDate(udte_fec_corte.Value).ToShortDateString
        PL_RP_EnvioMail.ShowDialog()

        x = Nothing
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub Enviar_por_Cargo()

        If uce_CARGO.SelectedIndex = -1 Then
            Avisar("Seleccione un cargo")
            uce_CARGO.Focus()
            Exit Sub
        End If

        Dim dt_tmp As DataTable = Nothing
        Dim crystalBL As New LR.ClsFunciones
        Dim str_Ruta_archivo_pdf As String = String.Empty
        Dim str_nom_pdf As String = String.Empty
        Dim x As New BL.ContabilidadBL.MyCorreo
        If ug_vaca.Rows.Count <> 0 Then dt_tmp = CType(ug_vaca.DataSource, DataTable)
        crystalBL.CrearPDF(dt_tmp, gStr_RutaRep, str_Ruta_archivo_pdf, str_nom_pdf)

        PL_RP_EnvioMail_xCargos.str_Ruta_nom_pdf = str_Ruta_archivo_pdf
        PL_RP_EnvioMail_xCargos.str_Nom_Archivo_pdf = str_nom_pdf
        PL_RP_EnvioMail_xCargos.str_fecha = CDate(udte_fec_corte.Value).ToShortDateString
        PL_RP_EnvioMail_xCargos.int_idcargo = uce_CARGO.Value
        PL_RP_EnvioMail_xCargos.ShowDialog()

        x = Nothing
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub uos_filtros_ValueChanged(sender As System.Object, e As System.EventArgs) Handles uos_filtros.ValueChanged
        utc_1.Enabled = True

        Dim reportesBL As New BL.PlanillaBL.SG_PL_Reportes

        Call LimpiaGrid(ug_vaca, uds_vaca)

        Select Case uos_filtros.Value
            Case "0"
                utc_1.Enabled = False
                If udte_fec_corte.Value Is Nothing Then Exit Sub
                ug_vaca.DataSource = reportesBL.get_Movimi_Vacaciones(CDate(udte_fec_corte.Value), Environment.MachineName, 0, IIf(uchk_inicio.Checked, 1, 0), gInt_IdEmpresa)

            Case "1"
                Call MostrarTabs(0, utc_1, 0)
                If udte_fec_corte.Value Is Nothing Then Exit Sub
                If txt_idpersonal.Text.Trim.Length = 0 Then Exit Sub
                ug_vaca.DataSource = reportesBL.get_Movimi_Vacaciones(CDate(udte_fec_corte.Value), Environment.MachineName, txt_idpersonal.Text.Trim, IIf(uchk_inicio.Checked, 1, 0), gInt_IdEmpresa)


            Case "2"
                Call MostrarTabs(1, utc_1, 1)
                If udte_fec_corte.Value Is Nothing Then Exit Sub
                If uce_CARGO.SelectedIndex = -1 Then Exit Sub
                ug_vaca.DataSource = reportesBL.get_Movimi_Vacaciones_x_Cargo(CDate(udte_fec_corte.Value), Environment.MachineName, uce_CARGO.Value, IIf(uchk_inicio.Checked, 1, 0), gInt_IdEmpresa)
        End Select

        reportesBL = Nothing

    End Sub

    Private Sub uce_CARGO_ValueChanged(sender As System.Object, e As System.EventArgs) Handles uce_CARGO.ValueChanged


        If udte_fec_corte.Value Is Nothing Then Exit Sub
        If uce_CARGO.SelectedIndex = -1 Then
            Avisar("Seleccione un Cargo")
            uce_CARGO.Focus()
            Exit Sub
        End If

        Dim reportesBL As New BL.PlanillaBL.SG_PL_Reportes
        ug_vaca.DataSource = reportesBL.get_Movimi_Vacaciones_x_Cargo(CDate(udte_fec_corte.Value), Environment.MachineName, uce_CARGO.Value, IIf(uchk_inicio.Checked, 1, 0), gInt_IdEmpresa)
        reportesBL = Nothing

    End Sub

    Private Sub ug_vaca_InitializeLayout(sender As System.Object, e As Infragistics.Win.UltraWinGrid.InitializeLayoutEventArgs) Handles ug_vaca.InitializeLayout

    End Sub
End Class