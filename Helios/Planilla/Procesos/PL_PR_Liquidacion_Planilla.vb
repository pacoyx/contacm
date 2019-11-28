Public Class PL_PR_Liquidacion_Planilla

    Private Sub PL_PR_Liquidacion_Planilla_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Call Cargar_Combo()
        udte_Periodo.Value = ObtenerUltimoDia(gDat_Fecha_Sis)
        'Me.Height = 211
        Me.Width = 428
        uce_TipoPersonal.SelectedIndex = 0

    End Sub

    Private Function Verificar_Estado_Mes() As Boolean
        Verificar_Estado_Mes = False
        Dim AdmMesBL As New BL.ContabilidadBL.SG_CO_TB_ADMMES
        Dim AdmMesBE As New BE.ContabilidadBE.SG_CO_TB_ADMMES

        With AdmMesBE
            .AM_ANHO = CDate(udte_Periodo.Value).Year
            .AM_MES = CDate(udte_Periodo.Value).Month
            .AM_IDEMPRESA = New BE.ContabilidadBE.SG_CO_TB_EMPRESA With {.EM_ID = gInt_IdEmpresa}
            .AM_MODULO = 3
        End With


        If AdmMesBL.Esta_Cerrado_Mes(AdmMesBE) Then
            Avisar("El mes esta cerrado." & Chr(13) & "Tiene que abrirlo antes.")
            AdmMesBL = Nothing
            AdmMesBE = Nothing
            Return True
        End If

        AdmMesBL = Nothing
        AdmMesBE = Nothing

    End Function

    Private Sub Cargar_Combo()
        Dim tipoPersonalBL As New BL.PlanillaBL.SG_PL_TB_TIPO_PERSONAL
        uce_TipoPersonal.DataSource = tipoPersonalBL.getTipos()
        uce_TipoPersonal.ValueMember = "TP_ID"
        uce_TipoPersonal.DisplayMember = "TP_DESCRIPCION"
        tipoPersonalBL = Nothing

    End Sub

    Private Sub ubtn_Salir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
    End Sub

    Private Sub Calcular_Planilla()

        '1=individual
        '2=general
        If uos_alcance.Value = 2 Then
            If Not Preguntar("Seguro de Procesar en forma General?") Then
                Exit Sub
            End If
        End If


        Me.Cursor = Cursors.WaitCursor

        



        

        Dim IdEmpleado As Integer = 0

        If uos_alcance.Value = 1 Then
            PL_PR_Lista_Personal.Int_tipo_Personal = uce_TipoPersonal.Value
            PL_PR_Lista_Personal.Bol_habilitar_uos = False
            PL_PR_Lista_Personal.Bol_MultiSeleccion = False
            PL_PR_Lista_Personal.ShowDialog()

            If PL_PR_Lista_Personal.Bol_Aceptar Then
                If PL_PR_Lista_Personal.lista_empleados.Count > 0 Then
                    IdEmpleado = PL_PR_Lista_Personal.lista_empleados(0).PE_ID
                End If
            Else
                Me.Cursor = Cursors.Default
                Exit Sub
            End If
        End If





        'variables para cargar lista personal
        Dim personalBL As New BL.PlanillaBL.SG_PL_TB_PERSONAL
        Dim personalBE As New BE.PlanillaBE.SG_PL_TB_PERSONAL
        Dim dt_personal As DataTable = Nothing
        Dim fecha_proceso As Date = CDate(udte_Periodo.Value)

        personalBE.PE_ID_EMPRESA = gInt_IdEmpresa
        personalBE.PE_ID_TIPO_PER = uce_TipoPersonal.Value
        personalBE.PE_AFECTO_QUINTA = 0 '(0= no solo activos)
        personalBE.PE_ID = IdEmpleado

        If uos_alcance.Value = 1 Then 'Individual
            dt_personal = personalBL.getPersonal_x_Tipo_x_IdPersonal(personalBE)
        Else
            dt_personal = personalBL.getPersonal_x_Tipo(personalBE)
        End If


        'cargamos los folios del mes
        Dim dt_Folio_Mes As DataTable = Nothing
        'cargamos los folios del mes
        Dim folioBL As New BL.PlanillaBL.SG_PL_TB_FOLIO
        Dim folioBE As New BE.PlanillaBE.SG_PL_TB_FOLIO
        folioBE.FO_ANHO = fecha_proceso.Year
        folioBE.FO_MES = fecha_proceso.Month
        folioBE.FO_ID_EMPRESA = New BE.ContabilidadBE.SG_CO_TB_EMPRESA With {.EM_ID = gInt_IdEmpresa}
        dt_Folio_Mes = folioBL.get_Folio_del_Mes(folioBE)
        folioBE = Nothing
        folioBL = Nothing


        'Me.Height = 243

        Me.Refresh()

        upb_estado.Minimum = 0
        upb_estado.Maximum = dt_personal.Rows.Count

        For i As Integer = 0 To dt_personal.Rows.Count - 1
            personalBE.PE_ID = dt_personal.Rows(i)("PE_ID")
            personalBL.getPersonal_x_Id(personalBE)

            Call Liquida_Fin_de_Mes(personalBE, fecha_proceso, True, dt_Folio_Mes, True)

            upb_estado.IncrementValue(1)
        Next

        upb_estado.Value = 0


        personalBE = Nothing
        personalBL = Nothing

        'Me.Height = 211

        Me.Refresh()


        Me.Cursor = Cursors.Default

        Call Avisar("Listo!")

    End Sub

    Private Sub Tool_Procesar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_Procesar.Click
        If Verificar_Estado_Mes() Then Exit Sub
        Call Calcular_Planilla()
    End Sub

    Private Sub Tool_Salir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_Salir.Click
        Me.Close()
    End Sub

    Private Sub uchk_3roPiso_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles uchk_3roPiso.CheckedChanged
        'debemos consultar si el periodo del registro de horas del personal de
        'tecnicas/enfermeras del mes de calculo esta con los vistos
        'buenos de sistemas y contabilidad 

        Dim dat_fecha_periodo As Date = CDate(udte_Periodo.Value)
        Dim planillaHorasBL As New BL.PlanillaBL.SG_PL_TB_PERSONAL_HORAS_CAB
        Dim bol_resp As Boolean = planillaHorasBL.Planilla_Horas_Visto_ok(dat_fecha_periodo.Year, dat_fecha_periodo.Month, gInt_IdEmpresa)
        planillaHorasBL = Nothing

        If bol_resp Then
            'uchk_3roPiso.Checked = True
        Else
            Avisar("La Planilla de Horas Falta ser Aprobada por Sistemas y/o RR.HH.")
            'uchk_3roPiso.Checked = False
        End If

    End Sub
End Class