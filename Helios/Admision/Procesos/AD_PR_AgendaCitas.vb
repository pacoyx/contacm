Public Class AD_PR_AgendaCitas
    Dim IGVTasa As Double
    Private Sub pFormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Timer1.Enabled = False
    End Sub

    Private Sub AD_PR_AgendaCitas_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        udte_fecha.Value = gDat_Fecha_Sis
        Dim TurnoBL As New BL.AdmisionBL.SG_AD_TB_TURNO
        Dim obj As New DataTable
        TurnoBL.SEL01(gInt_IdEmpresa, obj)
        ucbo_Turno.DataSource = obj
        ucbo_Turno.ValueMember = "TU_ID"
        ucbo_Turno.DisplayMember = "TU_DESCRIPCION"
        TurnoBL = Nothing
        ucbo_Turno.Value = IIf(Now.Hour > 13, 2, 1)

        Call Cargar_Combos()

        ubtn_a.Appearance.Image = My.Resources._16__Db_previous_
        ubtn_s.Appearance.Image = My.Resources._16__Db_next_

        Timer1.Enabled = True
        Timer1.Interval = 60000
        Cargar_Tasas_Impuestos()
        ' Timer1.Start()
    End Sub

    Private Sub Cargar_Combos()

        Dim servicioBL As New BL.AdmisionBL.SG_AD_TB_SERVICIO_MEDICO
        uce_Servicio.DataSource = servicioBL.get_Servicios_X_Medico2(gInt_IdEmpresa, udte_fecha.Value)
        uce_Servicio.ValueMember = "SM_ID"
        uce_Servicio.DisplayMember = "SM_DESCRIPCION"
        servicioBL = Nothing

        If uce_Servicio.Items.Count = 0 Then
            uce_Medico.DataSource = Nothing
            uce_Medico.SelectedIndex = -1
        Else
            uce_Servicio.SelectedIndex = 0
            uce_Servicio_ValueChanged(Nothing, Nothing)
        End If

    End Sub

    Private Sub uce_Servicio_ValueChanged(sender As System.Object, e As System.EventArgs) Handles uce_Servicio.ValueChanged

        Dim obj2 As New DataTable
        uce_Medico.SelectedIndex = -1
        Dim UsuMeBL As New BL.AdmisionBL.SG_AD_TB_MEDICO
        Dim UsuMeBE As New BE.AdmisionBE.SG_AD_TB_MEDICO
        UsuMeBE.ME_IDEMPRESA = gInt_IdEmpresa
        'MsgBox(uce_Servicio.Value)
        UsuMeBL.SEL02(UsuMeBE, udte_fecha.Value, obj2, uce_Servicio.Value)
        uce_Medico.DataSource = obj2
        uce_Medico.ValueMember = "ME_CODIGO"
        uce_Medico.DisplayMember = "NOMBRES"
        UsuMeBL = Nothing

        uce_Medico.SelectedIndex = 0
        ' uce_Medico_ValueChanged(Nothing, Nothing)
    End Sub

    Private Sub ubtn_a_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ubtn_a.Click
        udte_fecha.Value = CDate(udte_fecha.Value).AddDays(-1)
        Cargar_Combos()
        uce_Servicio_ValueChanged(sender, e)
        ' uce_Medico.SelectedIndex = -1
        'Call Cargar_Agenda(udte_fecha.Value, uce_Servicio.Value, uce_Medico.Value, ucbo_Turno.Value)
    End Sub

    Private Sub ubtn_s_Click(sender As System.Object, e As System.EventArgs) Handles ubtn_s.Click
        udte_fecha.Value = CDate(udte_fecha.Value).AddDays(1)
        Cargar_Combos()
        uce_Servicio_ValueChanged(sender, e)
        ' uce_Medico.SelectedIndex = -1
        ' Call Cargar_Agenda(udte_fecha.Value, uce_Servicio.Value, uce_Medico.Value, ucbo_Turno.Value)
    End Sub


    Public Sub Cargar_Agenda(ByVal fecha As String, ByVal servicio As String, ByVal Medico As String, ByVal Turno As Integer)

        Dim scrollPos = ug_intervalos.ActiveRowScrollRegion.ScrollPosition

        Dim programacionBL As New BL.AdmisionBL.SG_AD_TB_PROGRAMA_CITA
        'Dim dt_prog As DataTable
        ug_intervalos.DataSource = programacionBL.get_Programacion_x_Fecha(CDate(fecha).ToShortDateString, servicio, Medico, gInt_IdEmpresa, Turno)
        programacionBL = Nothing

        'Call LimpiaGrid(ug_intervalos, uds_intervalos)

        If ug_intervalos.Rows.Count > 0 Then
            txt_idprogramacion.Text = ug_intervalos.DataSource.Rows(0)("PR_ID").ToString
        Else
            txt_idprogramacion.Text = ""
        End If

        If uce_Servicio.Value = 7 Then
            ug_intervalos.DisplayLayout.Bands(0).Columns("H. Atendida").Hidden = True
            ug_intervalos.DisplayLayout.Bands(0).Columns("CC_ID").Hidden = True
            ug_intervalos.DisplayLayout.Bands(0).Columns("Hora").Hidden = True
            ug_intervalos.DisplayLayout.Bands(0).Columns("Nº DOC.").Hidden = True
            ug_intervalos.DisplayLayout.Bands(0).Columns("Medico").Hidden = False
            ug_intervalos.DisplayLayout.Bands(0).Columns("CM_OBSERVACIONES").Hidden = False
            ug_intervalos.DisplayLayout.Bands(0).Columns("AR_Abreviado").Hidden = False

        Else
            ug_intervalos.DisplayLayout.Bands(0).Columns("Hora").Hidden = False
            ug_intervalos.DisplayLayout.Bands(0).Columns("Hora").Hidden = False
            ug_intervalos.DisplayLayout.Bands(0).Columns("H. Atendida").Hidden = False
            ug_intervalos.DisplayLayout.Bands(0).Columns("CC_ID").Hidden = False
            ug_intervalos.DisplayLayout.Bands(0).Columns("Nº DOC.").Hidden = False
            ug_intervalos.DisplayLayout.Bands(0).Columns("Medico").Hidden = True
            ug_intervalos.DisplayLayout.Bands(0).Columns("CM_OBSERVACIONES").Hidden = True
            ug_intervalos.DisplayLayout.Bands(0).Columns("AR_Abreviado").Hidden = True
        End If
        If uce_Servicio.Value = 7 Then
            ug_intervalos.ActiveRowScrollRegion.ScrollPosition = scrollPos
        End If


    End Sub

    Private Sub ubtn_Consultar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ubtn_Consultar.Click
        Call Cargar_Agenda(udte_fecha.Value, uce_Servicio.Value, uce_Medico.Value, ucbo_Turno.Value)
    
    End Sub

    Private Sub Tool_Salir_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_Salir.Click
        Me.Close()
    End Sub

    Private Sub Tool_Reserva_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_Reserva.Click
        If ug_intervalos.Rows.Count = 0 Then Exit Sub
        If (ug_intervalos.ActiveRow.Cells(0).Value = 0 And ug_intervalos.ActiveRow.Cells(1).Value = 0) Or ug_intervalos.ActiveRow.Cells(9).Value = "Citado" Then
            With AD_PR_ReservaCita
                .udte_fecha.Value = udte_fecha.Value
                .txt_Servicio.Text = uce_Servicio.Text
                .txt_idTurno.Text = ucbo_Turno.Value
                .txt_Medico.Text = uce_Medico.Text
                .txt_Orden.Value = ug_intervalos.ActiveRow.Cells(2).Value
                .txt_Hora.Value = ug_intervalos.ActiveRow.Cells(3).Value
                .txt_idprogramacion.Value = ug_intervalos.ActiveRow.Cells(10).Value
                Dim documentosBL As New BL.AdmisionBL.SG_AD_TB_TIP_DOC_PER
                .uce_tip_doc.DataSource = documentosBL.getTiposDocs(gInt_IdEmpresa)
                .uce_tip_doc.DisplayMember = "TD_ABREVIATURA"
                .uce_tip_doc.ValueMember = "TD_ID"
                documentosBL = Nothing

                .OPCION = 1
                .lNew = True
                .ugb_Postergar.Enabled = False
                .Height = 232
                .txt_IdCliente.Text = ""
                .txt_idHistoria.Text = ""
                .txt_Des_Cliente.Text = ""
                .txt_ruc_cliente.Text = ""
                .Medico = uce_Medico.Value
                .Servicio = uce_Servicio.Value
                If ug_intervalos.ActiveRow.Cells(9).Value = "Citado" Then

                    .txt_idCita.Text = ug_intervalos.ActiveRow.Cells(0).Value
                    Dim clienteBL As New BL.AdmisionBL.SG_AD_TB_HISTO_CLINI
                    Dim clienteBE As New BE.AdmisionBE.SG_AD_TB_HISTO_CLINI

                    clienteBE.HC_NDOC = ug_intervalos.ActiveRow.Cells(8).Value
                    clienteBE.HC_IDEMPRESA = gInt_IdEmpresa
                    clienteBE.HC_TDOC = ug_intervalos.ActiveRow.Cells(12).Value
                    clienteBL.get_Historias_x_Doc(clienteBE)

                    If clienteBE.HasRow Then
                        .txt_IdCliente.Text = clienteBE.HC_IDCLIENTE
                        .txt_idHistoria.Text = clienteBE.HC_NUM_HIST
                        .txt_Des_Cliente.Text = clienteBE.HC_NOMBRE1
                        .uce_tip_doc.Value = clienteBE.HC_TDOC
                        .txt_ruc_cliente.Text = clienteBE.HC_NDOC

                        '  ubtn_agregar.Focus()
                    End If
                    .lNew = False
                End If

                .ShowDialog()
                Call Cargar_Agenda(udte_fecha.Value, uce_Servicio.Value, uce_Medico.Value, ucbo_Turno.Value)
            End With
        End If
    End Sub

    Private Sub Tool_Postergar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_Postergar.Click
        If ug_intervalos.Rows.Count = 0 Then Exit Sub
        'uce_Servicio.Value = 7 And 
        If ug_intervalos.ActiveRow.Cells(9).Value = "Atendido" And ug_intervalos.ActiveRow.Cells(0).Value <> 0 Then
            With AD_PR_PostergarAtencion
                Call Limpiar_Controls_InGroupox(.ugb_Datos)
                .Medico = uce_Medico.Value
                .Servicio = uce_Servicio.Value
                .txt_Servicio.Text = uce_Servicio.Text
                .txt_Medico.Text = uce_Medico.Text

                Dim documentosBL As New BL.AdmisionBL.SG_AD_TB_TIP_DOC_PER
                .uce_tip_doc.DataSource = documentosBL.getTiposDocs(gInt_IdEmpresa)
                .uce_tip_doc.DisplayMember = "TD_ABREVIATURA"
                .uce_tip_doc.ValueMember = "TD_ID"
                documentosBL = Nothing
                Dim medicosBL As New BL.AdmisionBL.SG_AD_TB_MEDICO
                .uce_Medico.DataSource = medicosBL.get_Medicos(gInt_IdEmpresa)
                .uce_Medico.ValueMember = "ME_CODIGO"
                .uce_Medico.DisplayMember = "NOMBRES"
                medicosBL = Nothing

                .txt_idCita.Text = ug_intervalos.ActiveRow.Cells(0).Value

                Dim clienteBL As New BL.AdmisionBL.SG_AD_TB_HISTO_CLINI
                Dim clienteBE As New BE.AdmisionBE.SG_AD_TB_HISTO_CLINI

                clienteBE.HC_NDOC = ug_intervalos.ActiveRow.Cells(8).Value
                clienteBE.HC_IDEMPRESA = gInt_IdEmpresa
                clienteBE.HC_TDOC = ug_intervalos.ActiveRow.Cells(12).Value
                clienteBL.get_Historias_x_Doc(clienteBE)

                If clienteBE.HasRow Then
                    .txt_IdCliente.Text = clienteBE.HC_IDCLIENTE
                    .txt_idHistoria.Text = clienteBE.HC_NUM_HIST
                    .txt_Des_Cliente.Text = clienteBE.HC_NOMBRE1
                    .uce_tip_doc.Value = clienteBE.HC_TDOC
                    .txt_ruc_cliente.Text = clienteBE.HC_NDOC
                End If

                Dim CitaBL As New BL.AdmisionBL.SG_AD_TB_CITA_MED
                Dim CitaBE As New BE.AdmisionBE.SG_AD_TB_CITA_MED
                CitaBE.CM_ID = ug_intervalos.ActiveRow.Cells(0).Value
                CitaBL.SEL01(CitaBE)
                If CitaBE.HasRow Then
                    If CitaBE.CM_IDMEDICODERI <> "" Then .uce_Medico.Value = CitaBE.CM_IDMEDICODERI
                    .ume_HoraLLegada.Value = CitaBE.CM_HORA_ATENC
                    .txt_Observacion.Text = CitaBE.CM_OBSERVACIONES
                End If
                .udte_fechaP.Value = Now
                .ShowDialog()
                Call Cargar_Agenda(udte_fecha.Value, uce_Servicio.Value, uce_Medico.Value, ucbo_Turno.Value)
                Exit Sub
            End With
        End If

        If ug_intervalos.ActiveRow.Cells(9).Value = "Citado" Then
            With AD_PR_ReservaCita
                .udte_fecha.Value = udte_fecha.Value
                .txt_Servicio.Text = uce_Servicio.Text
                .txt_Medico.Text = uce_Medico.Text
                .Medico = uce_Medico.Value
                .Servicio = uce_Servicio.Value
                .txt_idTurno.Text = ucbo_Turno.Value

                .txt_Orden.Value = ug_intervalos.ActiveRow.Cells(2).Value
                .txt_Hora.Value = ug_intervalos.ActiveRow.Cells(3).Value
                .txt_idprogramacion.Value = ug_intervalos.ActiveRow.Cells(10).Value
                .txt_idCita.Text = ug_intervalos.ActiveRow.Cells(0).Value
                Dim documentosBL As New BL.AdmisionBL.SG_AD_TB_TIP_DOC_PER
                .uce_tip_doc.DataSource = documentosBL.getTiposDocs(gInt_IdEmpresa)
                .uce_tip_doc.DisplayMember = "TD_ABREVIATURA"
                .uce_tip_doc.ValueMember = "TD_ID"
                documentosBL = Nothing

                .OPCION = 3
                .lNew = False
                .ugb_Postergar.Enabled = True
                .Height = 326

                Dim clienteBL As New BL.AdmisionBL.SG_AD_TB_HISTO_CLINI
                Dim clienteBE As New BE.AdmisionBE.SG_AD_TB_HISTO_CLINI

                clienteBE.HC_NDOC = ug_intervalos.ActiveRow.Cells(8).Value
                clienteBE.HC_IDEMPRESA = gInt_IdEmpresa
                clienteBE.HC_TDOC = ug_intervalos.ActiveRow.Cells(12).Value
                clienteBL.get_Historias_x_Doc(clienteBE)

                If clienteBE.HasRow Then
                    .txt_IdCliente.Text = clienteBE.HC_IDCLIENTE
                    .txt_idHistoria.Text = clienteBE.HC_NUM_HIST
                    .txt_Des_Cliente.Text = clienteBE.HC_NOMBRE1
                    .uce_tip_doc.Value = clienteBE.HC_TDOC
                    .txt_ruc_cliente.Text = clienteBE.HC_NDOC

                    '  ubtn_agregar.Focus()
                End If

                Dim programacionBL As New BL.AdmisionBL.SG_AD_TB_PROGRAMA_CITA
                .ucb_Orden.DataSource = programacionBL.get_Programacion_x_Fecha(CDate(.udte_fechaP.Value).ToShortDateString, .Servicio, .Medico, gInt_IdEmpresa, ucbo_Turno.Value)
                .ucb_Orden.ValueMember = "value"
                .ucb_Orden.DisplayMember = "value"
                programacionBL = Nothing

                .txt_HoraPost.Text = ""

                .ShowDialog()
                Call Cargar_Agenda(udte_fecha.Value, uce_Servicio.Value, uce_Medico.Value, ucbo_Turno.Value)
            End With
        End If
    End Sub

    Private Sub Inicio_Atencion()
        With AD_PR_Atencion
            Call Limpiar_Controls_InGroupox(.ugb_Cuenta)
            Call Limpiar_Controls_InGroupox(.ugb_Datos)

            .uds_detalle.Rows.Clear()
            .ug_detalle.DataSource = .uds_detalle

            .udte_fecha.Value = udte_fecha.Value
            .txt_Servicio.Text = uce_Servicio.Text
            .txt_Medico.Text = uce_Medico.Text
            .IDMEDICO = uce_Medico.Value

            .txt_Orden.Value = ug_intervalos.ActiveRow.Cells(2).Value
            .txt_Hora.Value = ug_intervalos.ActiveRow.Cells(3).Value
            .txt_idprogramacion.Value = ug_intervalos.ActiveRow.Cells(10).Value
            .txt_idCita.Text = ug_intervalos.ActiveRow.Cells(0).Value

            .OPCION = 1
            .lNew = True

            .uck_HoraIngreso.Enabled = True
            .uck_HoraLlegada.Checked = False
            .uck_HoraIngreso.Checked = False
            .uck_Anamnesis.Checked = False

            .ume_horaIngreso.Enabled = False
            .ume_HoraLLegada.Enabled = False

            .uchk_SeguroEps.Checked = False
            .uchk_GenerarCta.Checked = False

            .ucm_SeguroEps.Enabled = False
            .ugb_Cuenta.Enabled = False

            .uchk_GenerarCta.Enabled = True
            .uchk_SeguroEps.Enabled = True

            '.ucm_Tipo.Enabled = False
            .ubt_Agregar.Enabled = False
            .ubt_Quitar.Enabled = False

            .uckIngresoManual.Checked = False
            .txt_PagoFijo.ReadOnly = True
            .txt_PagoVariable.ReadOnly = True

            .txt_ruc_cliente.Enabled = True
            .uce_tip_doc.Enabled = True

            .txt_CodAutoriza.ReadOnly = False

            .ucm_Tipo.ReadOnly = True
            .txt_DesCobertura.ReadOnly = True
            .txt_CodAsegurado.ReadOnly = True

            Dim documentosBL As New BL.AdmisionBL.SG_AD_TB_TIP_DOC_PER
            .uce_tip_doc.DataSource = documentosBL.getTiposDocs(gInt_IdEmpresa)
            .uce_tip_doc.DisplayMember = "TD_ABREVIATURA"
            .uce_tip_doc.ValueMember = "TD_ID"
            documentosBL = Nothing
            .uce_tip_doc.SelectedIndex = 0

            Dim asegBL As New BL.FacturacionBL.SG_FA_TB_CIA_ASEG
            .ucm_SeguroEps.DataSource = asegBL.getAseguradoras(gInt_IdEmpresa)
            .ucm_SeguroEps.DisplayMember = "CA_DESCRIPCION"
            .ucm_SeguroEps.ValueMember = "CA_ID"
            asegBL = Nothing

            Dim medicosBL As New BL.AdmisionBL.SG_AD_TB_MEDICO
            .uce_Medico.DataSource = medicosBL.get_Medicos(gInt_IdEmpresa)
            .uce_Medico.ValueMember = "ME_CODIGO"
            .uce_Medico.DisplayMember = "NOMBRES"
            medicosBL = Nothing

            Dim OrigenBL As New BL.AdmisionBL.SG_AD_TB_ORIGEN_ATENC
            .ucm_Tipo.DataSource = OrigenBL.getOrigen()
            .ucm_Tipo.DisplayMember = "OA_DESCRIPCION"
            .ucm_Tipo.ValueMember = "OA_ID"
            OrigenBL = Nothing
            .ucm_Tipo.SelectedIndex = 0

            'Dim bscOBERTURA As New BindingSource
            Dim cOBERTURABL As New BL.AdmisionBL.SG_AD_TB_COBERTURA
            'bscOBERTURA.DataSource = cOBERTURABL.getOrigen()
            'bscOBERTURA.Filter = String.Format("CB_IDTIPO_ORIGEN = '{0}'", .ucm_Tipo.Value)
            .txt_DesCobertura.DataSource = cOBERTURABL.getOrigen()
            .txt_DesCobertura.DisplayMember = "CB_DESCRIPCION"
            .txt_DesCobertura.ValueMember = "CB_ID"
            cOBERTURABL = Nothing

            If ug_intervalos.ActiveRow.Cells(0).Value <> 0 Then
                .lNew = False
                .txt_idCita.Text = ug_intervalos.ActiveRow.Cells(0).Value
                Dim clienteBL As New BL.AdmisionBL.SG_AD_TB_HISTO_CLINI
                Dim clienteBE As New BE.AdmisionBE.SG_AD_TB_HISTO_CLINI

                clienteBE.HC_NDOC = ug_intervalos.ActiveRow.Cells(8).Value
                clienteBE.HC_IDEMPRESA = gInt_IdEmpresa
                clienteBE.HC_TDOC = ug_intervalos.ActiveRow.Cells(12).Value
                clienteBL.get_Historias_x_Doc(clienteBE)

                If clienteBE.HasRow Then
                    .txt_IdCliente.Text = clienteBE.HC_IDCLIENTE
                    .txt_idHistoria.Text = clienteBE.HC_NUM_HIST
                    .txt_Des_Cliente.Text = clienteBE.HC_NOMBRE1
                    .uce_tip_doc.Value = clienteBE.HC_TDOC
                    .txt_ruc_cliente.Text = clienteBE.HC_NDOC
                    .udte_fechaNac.Value = clienteBE.HC_FNAC
                    .txt_Edad.Value = Int(DateDiff("m", clienteBE.HC_FNAC, Date.Now) / 12)
                End If
            End If

        End With
    End Sub

    Private Sub Cargar_Tasas_Impuestos()
        Dim impuestosBL As New BL.ContabilidadBL.SG_CO_TB_IMPUESTO
        Dim impuestoBE As New BE.ContabilidadBE.SG_CO_TB_IMPUESTO

        impuestoBE.IM_IDEMPRESA = New BE.ContabilidadBE.SG_CO_TB_EMPRESA With {.EM_ID = gInt_IdEmpresa}
        impuestoBE.IM_IDTIPOIMPUESTO = New BE.ContabilidadBE.SG_CO_TB_TIPO_IMPUESTO With {.TI_CODIGO = "01"}
        impuestoBE.IM_PERIODO = Date.Now.Year
        impuestoBE.IM_MES = Date.Now.Month

        impuestosBL.getImpuestos_x_Tipo(impuestoBE)
        IGVTasa = impuestoBE.IM_TASA

        impuestosBL = Nothing
        impuestoBE = Nothing

    End Sub

    Private Sub Inicio_AtencionE()
        Cargar_Tasas_Impuestos()
        With AD_PR_AtencionxServicio
            Call Limpiar_Controls_InGroupox(.ugb_Datos)

            .ucb_Articulo.Enabled = True
            .udte_fecha.Value = udte_fecha.Value
            .txt_Servicio.Text = uce_Servicio.Text
            .txt_Medico.Text = uce_Medico.Text
            .txt_Orden.Value = ug_intervalos.ActiveRow.Cells(2).Value
            .txt_Hora.Value = ug_intervalos.ActiveRow.Cells(3).Value
            .txt_idprogramacion.Value = ug_intervalos.ActiveRow.Cells(10).Value
            .txt_idCita.Text = ug_intervalos.ActiveRow.Cells(0).Value
            .ulbl_DatosCuenta.Text = ""
            .lNew = True
            .Opcion = 0
            .txt_idTipoSeg.Text = 1

            .uck_HoraLlegada.Checked = False
            .uck_HoraIngreso.Checked = False
            .uck_HoraSalida.Checked = False

            .ume_horaIngreso.Enabled = False
            .ume_HoraLLegada.Enabled = False
            .ume_horaSalida.Enabled = False

            .txt_ruc_cliente.Enabled = True
            .uce_tip_doc.Enabled = True

            .uck_AtencionP.Checked = False
            .uck_AtencionP.Enabled = True

            Dim documentosBL As New BL.AdmisionBL.SG_AD_TB_TIP_DOC_PER
            .uce_tip_doc.DataSource = documentosBL.getTiposDocs(gInt_IdEmpresa)
            .uce_tip_doc.DisplayMember = "TD_ABREVIATURA"
            .uce_tip_doc.ValueMember = "TD_ID"
            documentosBL = Nothing

            Dim asegBL As New BL.FacturacionBL.SG_FA_TB_CIA_ASEG
            .ucm_SeguroEps.DataSource = asegBL.getAseguradoras(gInt_IdEmpresa)
            .ucm_SeguroEps.DisplayMember = "CA_DESCRIPCION"
            .ucm_SeguroEps.ValueMember = "CA_ID"
            asegBL = Nothing

            Dim medicosBL As New BL.AdmisionBL.SG_AD_TB_MEDICO
            .uce_Medico.DataSource = medicosBL.get_Medicos(gInt_IdEmpresa)
            .uce_Medico.ValueMember = "ME_CODIGO"
            .uce_Medico.DisplayMember = "NOMBRES"
            medicosBL = Nothing

            If ug_intervalos.ActiveRow.Cells(0).Value <> 0 Then
                .lNew = False
                .txt_idCita.Text = ug_intervalos.ActiveRow.Cells(0).Value
                Dim clienteBL As New BL.AdmisionBL.SG_AD_TB_HISTO_CLINI
                Dim clienteBE As New BE.AdmisionBE.SG_AD_TB_HISTO_CLINI

                clienteBE.HC_NDOC = ug_intervalos.ActiveRow.Cells(8).Value
                clienteBE.HC_IDEMPRESA = gInt_IdEmpresa
                clienteBE.HC_TDOC = ug_intervalos.ActiveRow.Cells(12).Value
                clienteBL.get_Historias_x_Doc(clienteBE)

                If clienteBE.HasRow Then
                    .txt_IdCliente.Text = clienteBE.HC_IDCLIENTE
                    .txt_idHistoria.Text = clienteBE.HC_NUM_HIST
                    .txt_Des_Cliente.Text = clienteBE.HC_NOMBRE1
                    .uce_tip_doc.Value = clienteBE.HC_TDOC
                    .txt_ruc_cliente.Text = clienteBE.HC_NDOC
                    .udte_fechaNac.Value = clienteBE.HC_FNAC
                    .txt_Edad.Value = Int(DateDiff("m", clienteBE.HC_FNAC, Date.Now) / 12)
                End If

                Dim Cuenta2BL As New BL.AdmisionBL.SG_AD_TB_CUENTA_CAB
                Dim Cuenta2BE As New BE.AdmisionBE.SG_AD_TB_CUENTA_CAB

                Cuenta2BE.CC_IDNUM_HIST = Val(.txt_idHistoria.Text)
                Cuenta2BE.CC_FECHA = udte_fecha.Value
                Cuenta2BL.SEL02(Cuenta2BE)
                If Cuenta2BE.HasRow Then
                    .txt_IdCuenta.Text = Cuenta2BE.CC_ID
                    .txt_ruc_cliente.Enabled = False
                    .uce_tip_doc.Enabled = False

                    .txt_idTipoSeg.Text = Cuenta2BE.CC_IDTIPO_ATENC
                    If Cuenta2BE.CC_IDTIPO_ATENC = 2 Then .ucm_SeguroEps.Value = Cuenta2BE.CC_IDSEGURO

                    Dim ArticulosBL As New BL.FacturacionBL.SG_FA_TB_ARTICULO
                    .ucb_Articulo.DataSource = ArticulosBL.get_Articulos_Ayuda03(gInt_IdEmpresa, .ucm_SeguroEps.Value, Cuenta2BE.CC_IDTIPO_ATENC, IGVTasa, "025")
                    .ucb_Articulo.DisplayMember = "AR_DESCRIPCION"
                    .ucb_Articulo.ValueMember = "AR_ID"
                    ArticulosBL = Nothing
                    .ArticuloAnt = 0
                    If Cuenta2BE.CC_IDTIPO_ATENC = 2 Then
                        .txt_PagoFijo.Text = Cuenta2BE.CC_SIT_COPG_FIJO
                        .txt_PagoVariable.Text = Cuenta2BE.CC_SIT_COPG_VARI
                    End If

                    'idcuenta
                    'idSeguro
                End If
            End If

        End With
    End Sub

    Private Sub Tool_Atencion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_Atencion.Click
        If ug_intervalos.Rows.Count = 0 Then Exit Sub
        If udte_fecha.Value < Now.Date And ug_intervalos.ActiveRow.Cells(9).Value = "" Then Exit Sub
        If uce_Servicio.Value = 7 Then
            If ug_intervalos.ActiveRow.Cells(1).Value = 0 Then
                With AD_PR_AtencionxServicio

                    Call Inicio_AtencionE()

                    If ug_intervalos.ActiveRow.Cells(9).Value = "Atendido" Or ug_intervalos.ActiveRow.Cells(9).Value = "Paso Consulta" Or ug_intervalos.ActiveRow.Cells(9).Value = "Salio" Then

                        Dim CitaBL As New BL.AdmisionBL.SG_AD_TB_CITA_MED
                        Dim CitaBE As New BE.AdmisionBE.SG_AD_TB_CITA_MED

                        CitaBE.CM_ID = ug_intervalos.ActiveRow.Cells(0).Value
                        CitaBL.SEL01(CitaBE)
                        If CitaBE.HasRow Then
                            If CitaBE.CM_HORA_ATENC <> "" Then .uck_HoraLlegada.Checked = True
                            If CitaBE.CM_HORA_ING <> "" Then .uck_HoraIngreso.Checked = True
                            If CitaBE.CM_HORA_SAL <> "" Then .uck_HoraSalida.Checked = True

                            If CitaBE.CM_IDMEDICODERI <> "" Then .uce_Medico.Value = CitaBE.CM_IDMEDICODERI
                            .ume_HoraLLegada.Value = CitaBE.CM_HORA_ATENC
                            .ume_horaIngreso.Value = CitaBE.CM_HORA_ING
                            .ume_horaSalida.Value = CitaBE.CM_HORA_SAL

                            .txt_Observacion.Text = CitaBE.CM_OBSERVACIONES
                            .txt_Edad.Text = CitaBE.CM_EDAD_ATENC


                            Dim CuentaBL As New BL.AdmisionBL.SG_AD_TB_CUENTA_CAB
                            Dim CuentaBE As New BE.AdmisionBE.SG_AD_TB_CUENTA_CAB

                            CuentaBE.CC_IDCITA = ug_intervalos.ActiveRow.Cells(0).Value
                            CuentaBL.SEL03(CuentaBE)
                            If CuentaBE.HasRow Then
                                .txt_IdCuenta.Text = CuentaBE.CC_ID
                                .txt_ruc_cliente.Enabled = False
                                .uce_tip_doc.Enabled = False

                                .txt_idTipoSeg.Text = CuentaBE.CC_IDTIPO_ATENC
                                If CuentaBE.CC_IDTIPO_ATENC = 2 Then
                                    .ucm_SeguroEps.Value = CuentaBE.CC_IDSEGURO
                                    .txt_PagoFijo.Text = CuentaBE.CC_SIT_COPG_FIJO
                                    .txt_PagoVariable.Text = CuentaBE.CC_SIT_COPG_VARI
                                    .ulbl_DatosCuenta.Text = "La Cuenta Es Por Seguro de la Fecha: " & CuentaBE.CC_FECHA
                                    If DateAdd(DateInterval.Day, 7, udte_fecha.Value.date) < Now.Date Then
                                        .uck_AtencionP.Enabled = False
                                        .ucb_Articulo.Enabled = False
                                    End If

                                End If
                            End If

                            Dim CuentaDBE As New BE.AdmisionBE.TMP_SG_AD_TB_CUENTA_DET

                            CuentaDBE.TCD_IDCAB = Val(.txt_IdCuenta.Text)
                            CuentaDBE.TCD_IDCITA = ug_intervalos.ActiveRow.Cells(0).Value
                            CuentaBL.SEL02_TMP(CuentaDBE)

                            If CuentaDBE.HasRow Then

                                Dim ArticulosBL As New BL.FacturacionBL.SG_FA_TB_ARTICULO
                                .ucb_Articulo.DataSource = ArticulosBL.get_Articulos_Ayuda03(gInt_IdEmpresa, .ucm_SeguroEps.Value, IIf(CitaBE.CM_IDTIPO_ATENC = 2, IIf(CuentaDBE.TCD_SEG_CUBRE = 1, 2, 1), CitaBE.CM_IDTIPO_ATENC), IGVTasa, "025")
                                .ucb_Articulo.DisplayMember = "AR_DESCRIPCION"
                                .ucb_Articulo.ValueMember = "AR_ID"
                                ArticulosBL = Nothing

                                .ucb_Articulo.Value = CuentaDBE.TCD_IDARTICULO
                                .ArticuloAnt = CuentaDBE.TCD_IDARTICULO
                                If CuentaDBE.TCD_IDCOMPROBANTE <> 0 Then
                                    .ucb_Articulo.Enabled = False
                                    .uck_AtencionP.Enabled = False
                                End If
                                .txt_Total.Text = CuentaDBE.TCD_TOTAL
                                .txt_Precio.Text = CuentaDBE.TCD_PRECIO
                                .txt_Descuento.Text = CuentaDBE.TCD_DESCUENTO
                                .txt_DesctoOtro.Text = CuentaDBE.TCD_DSCTO_OTRO
                                .txt_SubTotal.Text = CuentaDBE.TCD_SUB_TOTAL
                                .txt_IGV.Text = CuentaDBE.TCD_IGV
                                .uck_AtencionP.Checked = IIf(CuentaDBE.TCD_SEG_CUBRE = 1, False, True)
                                .Opcion = 1
                            Else
                                Dim ArticulosBL As New BL.FacturacionBL.SG_FA_TB_ARTICULO
                                .ucb_Articulo.DataSource = ArticulosBL.get_Articulos_Ayuda03(gInt_IdEmpresa, .ucm_SeguroEps.Value, CitaBE.CM_IDTIPO_ATENC, IGVTasa, "025")
                                .ucb_Articulo.DisplayMember = "AR_DESCRIPCION"
                                .ucb_Articulo.ValueMember = "AR_ID"
                                ArticulosBL = Nothing
                            End If

                        End If

                        If ug_intervalos.ActiveRow.Cells(9).Value = "Paso Consulta" Then
                            ''llenar la hora q ingreso
                            .ume_horaIngreso.Enabled = True
                            .uck_HoraIngreso.Enabled = True
                        End If
                    End If

                    If ug_intervalos.ActiveRow.Cells(9).Value = "Citado" Then
                        .Buscar_Cuenta()
                    End If
                    .uck_HoraIngreso.Focus()
                    .ShowDialog()
                    Call Cargar_Agenda(udte_fecha.Value, uce_Servicio.Value, uce_Medico.Value, ucbo_Turno.Value)
                End With

            End If
        Else
            If ug_intervalos.ActiveRow.Cells(1).Value = 0 Then
                With AD_PR_Atencion
                    Call Inicio_Atencion()

                    If ug_intervalos.ActiveRow.Cells(9).Value = "Atendido" Or ug_intervalos.ActiveRow.Cells(9).Value = "Paso Consulta" Then

                        '.uck_HoraIngreso.Enabled = False
                        'llenar los datos de seguro Y LA CUENTA

                        Dim CitaBL As New BL.AdmisionBL.SG_AD_TB_CITA_MED
                        Dim CitaBE As New BE.AdmisionBE.SG_AD_TB_CITA_MED

                        CitaBE.CM_ID = ug_intervalos.ActiveRow.Cells(0).Value
                        CitaBL.SEL01(CitaBE)
                        If CitaBE.HasRow Then
                            If CitaBE.CM_HORA_ATENC <> "" Then .uck_HoraLlegada.Checked = True
                            If CitaBE.CM_HORA_ING <> "" Then .uck_HoraIngreso.Checked = True
                            If CitaBE.CM_IDMEDICODERI <> "" Then .uce_Medico.Value = CitaBE.CM_IDMEDICODERI

                            .uck_Anamnesis.Checked = CitaBE.CM_Anamnesis
                            .ume_HoraLLegada.Value = CitaBE.CM_HORA_ATENC
                            .ume_horaIngreso.Value = CitaBE.CM_HORA_ING
                            .txt_Observacion.Text = CitaBE.CM_OBSERVACIONES
                            .txt_Edad.Text = CitaBE.CM_EDAD_ATENC
                            .uchk_SeguroEps.Checked = IIf(CitaBE.CM_IDTIPO_ATENC = 2, True, False)
                            If .uchk_SeguroEps.Checked = True Then
                                .ucm_SeguroEps.Value = CitaBE.CM_IDSEGURO
                                .ucm_SeguroEps.Enabled = True
                            Else
                                .ucm_SeguroEps.Enabled = False
                            End If


                            Dim CuentaBL As New BL.AdmisionBL.SG_AD_TB_CUENTA_CAB
                            Dim CuentaBE As New BE.AdmisionBE.SG_AD_TB_CUENTA_CAB

                            CuentaBE.CC_IDCITA = ug_intervalos.ActiveRow.Cells(0).Value
                            CuentaBL.SEL01(CuentaBE)
                            If CuentaBE.HasRow Then
                                .txt_IdCuenta.Text = CuentaBE.CC_ID
                                .ucm_Tipo.Value = CuentaBE.CC_IDTIPO_ORI

                                .txt_EPS.Text = CuentaBE.CC_SIT_COD_EPS
                                .txt_CodAsegurado.Text = CuentaBE.CC_SIT_COD_ASEG
                                .txt_FechaAutoriza.Value = CuentaBE.CC_SIT_FEC_AUTORI
                                .txt_DesCobertura.Value = CuentaBE.CC_SIT_COD_COBER
                                .txt_CodAutoriza.Text = CuentaBE.CC_SIT_COD_GENE
                                .uckIngresoManual.Checked = IIf(CuentaBE.CC_INGRESO_MANUAL = 1, True, False)
                                .TXT_TIPOAFILIACION.Text = CuentaBE.CC_TIPOAFILIACION
                                .uchk_GenerarCta.Checked = True
                                .ugb_Cuenta.Enabled = True
                                .ubt_Agregar.Enabled = True
                                .ubt_Quitar.Enabled = True

                                .uchk_GenerarCta.Enabled = False
                                .uchk_SeguroEps.Enabled = False
                                .ucm_SeguroEps.Enabled = False
                                .txt_ruc_cliente.Enabled = False
                                .uce_tip_doc.Enabled = False

                                .ucm_Tipo.ReadOnly = False

                                If .uchk_SeguroEps.Checked = True And .uchk_GenerarCta.Checked = True Then
                                    .txt_PagoFijo.Text = Math.Round(Math.Round((CuentaBE.CC_SIT_COPG_FIJO * (IGVTasa / 100)), 2) + CuentaBE.CC_SIT_COPG_FIJO, 0)
                                    .txt_FijoC.Text = CuentaBE.CC_SIT_COPG_FIJO
                                    .txt_PagoVariable.Text = CuentaBE.CC_SIT_COPG_VARI
                                End If
                            Else
                                CuentaBL.SEL05_CuentaDet(CuentaBE)
                                If CuentaBE.HasRow Then
                                    .txt_IdCuenta.Text = CuentaBE.CC_ID
                                    .ucm_Tipo.Value = CuentaBE.CC_IDTIPO_ORI

                                    .txt_EPS.Text = CuentaBE.CC_SIT_COD_EPS
                                    .txt_CodAsegurado.Text = CuentaBE.CC_SIT_COD_ASEG
                                    .txt_FechaAutoriza.Value = CuentaBE.CC_SIT_FEC_AUTORI
                                    .txt_DesCobertura.Value = CuentaBE.CC_SIT_COD_COBER
                                    .txt_CodAutoriza.Text = CuentaBE.CC_SIT_COD_GENE
                                    .uckIngresoManual.Checked = IIf(CuentaBE.CC_INGRESO_MANUAL = 1, True, False)
                                    .TXT_TIPOAFILIACION.Text = CuentaBE.CC_TIPOAFILIACION
                                    .uchk_GenerarCta.Checked = True
                                    .ugb_Cuenta.Enabled = True
                                    .ubt_Agregar.Enabled = True
                                    .ubt_Quitar.Enabled = True

                                    .uchk_GenerarCta.Enabled = False
                                    .uchk_SeguroEps.Enabled = False
                                    .ucm_SeguroEps.Enabled = False
                                    .txt_ruc_cliente.Enabled = False
                                    .uce_tip_doc.Enabled = False

                                    .ucm_Tipo.ReadOnly = False

                                    If .uchk_SeguroEps.Checked = True And .uchk_GenerarCta.Checked = True Then
                                        .txt_PagoFijo.Text = Math.Round(Math.Round((CuentaBE.CC_SIT_COPG_FIJO * (IGVTasa / 100)), 2) + CuentaBE.CC_SIT_COPG_FIJO, 0)
                                        .txt_FijoC.Text = CuentaBE.CC_SIT_COPG_FIJO
                                        .txt_PagoVariable.Text = CuentaBE.CC_SIT_COPG_VARI
                                    End If
                                End If
                            End If

                            Dim obrT As New BL.AdmisionBL.SG_AD_TB_CUENTA_CAB
                            Dim obeT As New BE.AdmisionBE.TMP_SG_AD_TB_CUENTA_DET
                            Dim obj As New DataTable
                            obeT.TCD_IDCAB = Val(.txt_IdCuenta.Text)
                            obrT.SEL01_TMP(obeT, String.Format("{0}-{1}", Environment.UserName, gStr_Usuario_Sis), Environment.MachineName, obj)
                            .ug_detalle.DataSource = obj
                            Dim a As Integer = 0
                            For i As Integer = 0 To .ug_detalle.Rows.Count - 1
                                If .ug_detalle.Rows(i).Cells(13).Value <> 0 Then
                                    a += 1
                                End If
                            Next

                            If .uckIngresoManual.Checked = True Then
                                If a = 0 Then
                                    .txt_PagoFijo.ReadOnly = False
                                    .txt_PagoVariable.ReadOnly = False

                                    .txt_DesCobertura.ReadOnly = False
                                    .txt_CodAsegurado.ReadOnly = False
                                Else
                                    .txt_PagoFijo.ReadOnly = True
                                    .txt_PagoVariable.ReadOnly = True
                                    .txt_DesCobertura.ReadOnly = True
                                    .txt_CodAsegurado.ReadOnly = True
                                End If
                            Else
                                .txt_DesCobertura.ReadOnly = True
                                .txt_CodAsegurado.ReadOnly = True
                                .txt_PagoFijo.ReadOnly = True
                                .txt_PagoVariable.ReadOnly = True
                            End If

                            Dim comproBL As New BL.FacturacionBL.SG_FA_TB_COMPROBANTE_C
                            If comproBL.Existe_Comprob_CuentaTodos(Val(.txt_IdCuenta.Text)) Then
                                .txt_CodAutoriza.ReadOnly = True
                                .uckIngresoManual.Enabled = False
                            Else
                                .txt_CodAutoriza.ReadOnly = False
                                .uckIngresoManual.Enabled = True
                            End If
                            comproBL = Nothing

                            'If a > 0 Then
                            '    .txt_CodAutoriza.ReadOnly = True
                            '    .uckIngresoManual.Enabled = False
                            'Else
                            '    .txt_CodAutoriza.ReadOnly = False
                            '    .uckIngresoManual.Enabled = True
                            'End If

                        End If


                        If .uchk_SeguroEps.Checked = True Then
                            If DateAdd(DateInterval.Day, 7, udte_fecha.Value.date) < Now.Date Then
                                .ugb_Cuenta.Enabled = False
                                .ubt_Agregar.Enabled = False
                                .ubt_Quitar.Enabled = False
                            End If
                        Else
                            If udte_fecha.Value < Now.Date Then
                                .ugb_Cuenta.Enabled = False
                                .ubt_Agregar.Enabled = False
                                .ubt_Quitar.Enabled = False
                            End If
                        End If

                        If ug_intervalos.ActiveRow.Cells(9).Value = "Paso Consulta" Then
                            ''llenar la hora q ingreso
                            .ume_horaIngreso.Enabled = True
                            .uck_HoraIngreso.Enabled = True
                        End If
                        If uce_Servicio.Value = "6" Then
                            .OPCION = 3
                        End If

                    End If

                    .ShowDialog()
                    Call Cargar_Agenda(udte_fecha.Value, uce_Servicio.Value, uce_Medico.Value, ucbo_Turno.Value)
                End With
            End If
        End If
    End Sub

    Private Sub Tool_PasoConsulta_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If ug_intervalos.Rows.Count = 0 Then Exit Sub
        If ug_intervalos.ActiveRow.Cells(9).Value = "Atendido" Or ug_intervalos.ActiveRow.Cells(9).Value = "Paso Consulta" Then
            With AD_PR_Atencion
                Call Inicio_Atencion()
                Dim CitaBL As New BL.AdmisionBL.SG_AD_TB_CITA_MED
                Dim CitaBE As New BE.AdmisionBE.SG_AD_TB_CITA_MED

                CitaBE.CM_ID = ug_intervalos.ActiveRow.Cells(0).Value
                CitaBL.SEL01(CitaBE)
                If CitaBE.HasRow Then
                    If CitaBE.CM_HORA_ATENC <> "" Then
                        .uck_HoraLlegada.Checked = True
                        .uck_HoraLlegada.Enabled = False
                        .ume_HoraLLegada.Enabled = False
                    End If
                    If CitaBE.CM_HORA_ING <> "" Then .uck_HoraIngreso.Checked = True

                    If CitaBE.CM_IDMEDICODERI <> "" Then .uce_Medico.Value = CitaBE.CM_IDMEDICODERI

                    .uck_Anamnesis.Checked = CitaBE.CM_Anamnesis
                    .ume_HoraLLegada.Value = CitaBE.CM_HORA_ATENC
                    .ume_horaIngreso.Value = CitaBE.CM_HORA_ING
                    .txt_Observacion.Text = CitaBE.CM_OBSERVACIONES
                    .txt_Edad.Text = CitaBE.CM_EDAD_ATENC
                    .uchk_SeguroEps.Checked = IIf(CitaBE.CM_IDTIPO_ATENC = 2, True, False)
                    If .uchk_SeguroEps.Checked = True Then
                        .ucm_SeguroEps.Value = CitaBE.CM_IDSEGURO
                        .ucm_SeguroEps.Enabled = True
                    Else
                        .ucm_SeguroEps.Enabled = False
                    End If

                    Dim CuentaBL As New BL.AdmisionBL.SG_AD_TB_CUENTA_CAB
                    Dim CuentaBE As New BE.AdmisionBE.SG_AD_TB_CUENTA_CAB

                    CuentaBE.CC_IDCITA = ug_intervalos.ActiveRow.Cells(0).Value
                    CuentaBL.SEL01(CuentaBE)
                    If CuentaBE.HasRow Then
                        .txt_IdCuenta.Text = CuentaBE.CC_ID
                        .ucm_Tipo.Value = CuentaBE.CC_IDTIPO_ORI

                        .txt_EPS.Text = CuentaBE.CC_SIT_COD_EPS
                        .txt_CodAsegurado.Text = CuentaBE.CC_SIT_COD_ASEG
                        .txt_FechaAutoriza.Value = CuentaBE.CC_SIT_FEC_AUTORI
                        .txt_DesCobertura.Value = CuentaBE.CC_SIT_COD_COBER
                        .txt_CodAutoriza.Text = CuentaBE.CC_SIT_COD_GENE
                        .uckIngresoManual.Checked = IIf(CuentaBE.CC_INGRESO_MANUAL = 1, True, False)

                        .uchk_GenerarCta.Checked = True
                        .ugb_Cuenta.Enabled = True
                        .ubt_Agregar.Enabled = True
                        .ubt_Quitar.Enabled = True

                        .uchk_GenerarCta.Enabled = False
                        .uchk_SeguroEps.Enabled = False
                        .ucm_SeguroEps.Enabled = False
                        .txt_ruc_cliente.Enabled = False
                        .uce_tip_doc.Enabled = False

                        .ucm_Tipo.ReadOnly = False

                        If .uchk_SeguroEps.Checked = True And .uchk_GenerarCta.Checked = True Then
                            .txt_FijoC.Text = CuentaBE.CC_SIT_COPG_FIJO
                            'Dim sss As Decimal
                            'sss = Math.Round((CuentaBE.CC_SIT_COPG_FIJO * (IGVTasa / 100)), 2)
                            .txt_PagoFijo.Value = Math.Round(Math.Round((CuentaBE.CC_SIT_COPG_FIJO * (IGVTasa / 100)), 2) + CuentaBE.CC_SIT_COPG_FIJO, 0)
                            '  MsgBox(.txt_PagoFijo.Value)
                            '.txt_PagoFijo.Text = Math.Round(.txt_PagoFijo.Value, 0)
                            .txt_PagoVariable.Text = CuentaBE.CC_SIT_COPG_VARI
                        End If
                    End If

                    Dim obrT As New BL.AdmisionBL.SG_AD_TB_CUENTA_CAB
                    Dim obeT As New BE.AdmisionBE.TMP_SG_AD_TB_CUENTA_DET
                    Dim obj As New DataTable
                    obeT.TCD_IDCAB = Val(.txt_IdCuenta.Text)
                    obrT.SEL01_TMP(obeT, String.Format("{0}-{1}", Environment.UserName, gStr_Usuario_Sis), Environment.MachineName, obj)
                    .ug_detalle.DataSource = obj
                    Dim a As Integer = 0
                    For i As Integer = 0 To .ug_detalle.Rows.Count - 1
                        If .ug_detalle.Rows(i).Cells(12).Value <> 0 Then
                            a += 0
                        End If
                    Next

                    If .uckIngresoManual.Checked = True Then
                        If a = 0 Then
                            .txt_PagoFijo.ReadOnly = False
                            .txt_PagoVariable.ReadOnly = False
                            .txt_DesCobertura.ReadOnly = False
                        Else
                            .txt_PagoFijo.ReadOnly = True
                            .txt_PagoVariable.ReadOnly = True
                            .txt_DesCobertura.ReadOnly = True
                        End If
                    Else
                        .txt_PagoFijo.ReadOnly = True
                        .txt_PagoVariable.ReadOnly = True
                        .txt_DesCobertura.ReadOnly = True
                    End If

                    If a = 0 Then .txt_CodAutoriza.ReadOnly = True
                End If
                If .uchk_SeguroEps.Checked = True Then
                    If DateAdd(DateInterval.Day, 7, udte_fecha.Value.date) < Now.Date Then
                        .ugb_Cuenta.Enabled = False
                        .ubt_Agregar.Enabled = False
                        .ubt_Quitar.Enabled = False
                    End If
                Else
                    If udte_fecha.Value < Now.Date Then
                        .ugb_Cuenta.Enabled = False
                        .ubt_Agregar.Enabled = False
                        .ubt_Quitar.Enabled = False
                    End If
                End If
                .OPCION = 3
                .ume_horaIngreso.Enabled = True
                .uck_HoraIngreso.Enabled = True
                .ShowDialog()
                Call Cargar_Agenda(udte_fecha.Value, uce_Servicio.Value, uce_Medico.Value, ucbo_Turno.Value)
            End With
        End If
    End Sub

    Private Sub Tool_OcupacionMed_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_OcupacionMed.Click
        If ug_intervalos.Rows.Count = 0 Then Exit Sub
        If (ug_intervalos.ActiveRow.Cells(0).Value = 0 And ug_intervalos.ActiveRow.Cells(1).Value = 0) Or ug_intervalos.ActiveRow.Cells(9).Value = "Ocupado" Then
            With AD_PR_OcupacionMedica
                .txt_Descripcion.Text = ""
                .udte_fecha.Value = udte_fecha.Value
                .txt_Servicio.Text = uce_Servicio.Text
                .txt_Medico.Text = uce_Medico.Text
                .txt_Orden.Value = ug_intervalos.ActiveRow.Cells(2).Value
                .txt_Hora.Value = ug_intervalos.ActiveRow.Cells(3).Value
                .txt_idprogramacion.Value = ug_intervalos.ActiveRow.Cells(10).Value
                .lNew = True

                If ug_intervalos.ActiveRow.Cells(9).Value = "Ocupado" Then

                    .txt_idOcupacion.Text = ug_intervalos.ActiveRow.Cells(1).Value

                    'llenar descripcion de la ocupacion 
                    Dim OcuMedBL As New BL.AdmisionBL.SG_AD_TB_OCUPACIONES_MEDICAS
                    Dim OcuMedBE As New BE.AdmisionBE.SG_AD_TB_OCUPACIONES_MEDICAS

                    OcuMedBE.OM_ID = ug_intervalos.ActiveRow.Cells(1).Value
                    OcuMedBL.SEL01(OcuMedBE)

                    If OcuMedBE.HasRow Then
                        .txt_Descripcion.Text = OcuMedBE.OM_DESCRIPCION
                    End If
                    .lNew = False
                End If

                .ShowDialog()
                Call Cargar_Agenda(udte_fecha.Value, uce_Servicio.Value, uce_Medico.Value, ucbo_Turno.Value)
            End With
        End If
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick

        Call Cargar_Agenda(udte_fecha.Value, uce_Servicio.Value, uce_Medico.Value, ucbo_Turno.Value)
    End Sub

    Private Sub ug_intervalos_DoubleClickCell(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinGrid.DoubleClickCellEventArgs) Handles ug_intervalos.DoubleClickCell
        Call Tool_Atencion_Click(sender, e)
    End Sub
    Private Sub ug_intervalos_InitializeRow(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinGrid.InitializeRowEventArgs) Handles ug_intervalos.InitializeRow
        If uce_Servicio.Value = 7 Then
            If e.Row.Cells(9).Value = "Paso Consulta" Then
                e.Row.Appearance.BackColor = Color.FromArgb(192, 255, 192)
            ElseIf e.Row.Cells(9).Value = "" Then
                e.Row.Appearance.BackColor = Color.White
            ElseIf e.Row.Cells(9).Value = "Salio" Then
                e.Row.Appearance.BackColor = Color.FromArgb(170, 234, 244)
            Else
                e.Row.Appearance.BackColor = Color.LightYellow
            End If

        Else
            If e.Row.Cells(9).Value = "Paso Consulta" Then
                e.Row.Appearance.BackColor = Color.FromArgb(154, 233, 180)
            ElseIf e.Row.Cells(9).Value = "" Then
                e.Row.Appearance.BackColor = Color.White
            ElseIf e.Row.Cells(9).Value = "Citado" Then
                e.Row.Appearance.BackColor = Color.FromArgb(170, 234, 244)
            Else
                e.Row.Appearance.BackColor = Color.LightYellow
            End If
        End If
    End Sub

    Private Sub udte_fecha_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles udte_fecha.ValueChanged
        Cargar_Combos()
        uce_Servicio_ValueChanged(sender, e)
        '  uce_Medico.SelectedIndex = -1
    End Sub

    Private Sub uce_Medico_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles uce_Medico.ValueChanged
        Call Cargar_Agenda(udte_fecha.Value, uce_Servicio.Value, uce_Medico.Value, ucbo_Turno.Value)
    End Sub

    Private Sub Tool_Eliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_Eliminar.Click

        If ug_intervalos.Rows.Count = 0 Then Exit Sub
        If ug_intervalos.ActiveRow.Cells(0).Value = 0 Then Exit Sub

        If uce_Servicio.Value = 7 Then
            Dim obe As New BE.AdmisionBE.SG_AD_TB_CUENTA_CAB
            Dim obr As New BL.AdmisionBL.SG_AD_TB_CUENTA_CAB

            obe.CC_ID = Val(ug_intervalos.ActiveRow.Cells("CC_ID").Value)

            If Preguntar("Seguro de Eliminar el " & obe.CC_ID.ToString & "?") Then

                Dim i As Integer = 0
                i = obr.Delete(obe, String.Format("{0}-{1}", Environment.UserName, gStr_Usuario_Sis), Environment.MachineName, Val(ug_intervalos.ActiveRow.Cells(0).Value))

                If i < 0 Then
                    MessageBox.Show("La operación solicitada no ha podido ser realizada", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                ElseIf i = 1 Then
                    MessageBox.Show("No puede Eliminar una cuenta Cancelada", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Else
                    Call Avisar("Listo!")
                    Call Cargar_Agenda(udte_fecha.Value, uce_Servicio.Value, uce_Medico.Value, ucbo_Turno.Value)
                End If
            End If

            obe = Nothing
            obr = Nothing

        Else
            If ug_intervalos.ActiveRow.Cells("CC_ID").Value.ToString = "" Then

                Dim oblC As New BL.AdmisionBL.SG_AD_TB_CITA_MED
                Dim obeC As New BE.AdmisionBE.SG_AD_TB_CITA_MED

                obeC.CM_ID = ug_intervalos.ActiveRow.Cells("CM_ID").Value

                If Preguntar("Seguro de Eliminar el " & obeC.CM_ID.ToString & "?") Then

                    If oblC.Delete_CITA(obeC, String.Format("{0}-{1}", Environment.UserName, gStr_Usuario_Sis), Environment.MachineName) < 0 Then
                        MessageBox.Show("La operación solicitada no ha podido ser realizada", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Else
                        Call Avisar("Listo!")
                        Call Cargar_Agenda(udte_fecha.Value, uce_Servicio.Value, uce_Medico.Value, ucbo_Turno.Value)
                    End If
                End If

                obeC = Nothing
                oblC = Nothing

            Else
                Avisar("La Cita Tiene Cuenta, No puede Eliminar, comuniquese con el Area de Sistemas")
            End If
        End If


    End Sub

    Private Sub ucbo_Turno_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ucbo_Turno.ValueChanged
        Call Cargar_Agenda(udte_fecha.Value, uce_Servicio.Value, uce_Medico.Value, ucbo_Turno.Value)
    End Sub

    Private Sub Tool_Imprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_Imprimir.Click
        If uce_Servicio.Value = 7 Then
            Me.Cursor = Cursors.WaitCursor

            Dim nom_reporte As String = "SG_AD_07.RPT"
            Dim crystalBL As New LR.ClsReporte
            Dim dt_data As New DataTable
            Dim programacionBL As New BL.AdmisionBL.SG_AD_TB_PROGRAMA_CITA
            dt_data = programacionBL.get_Programacion_citas_Eco(CDate(udte_fecha.Value).ToShortDateString, uce_Servicio.Value, gInt_IdEmpresa, ucbo_Turno.Value)
            programacionBL = Nothing

            crystalBL.Muestra_Reporte(gStr_RutaRep & "\" & nom_reporte, dt_data, "", "pFecha;" & CDate(udte_fecha.Value).ToShortDateString)

            crystalBL = Nothing
            ' reportesBL = Nothing

            Me.Cursor = Cursors.Default
        Else

        End If
    End Sub

End Class