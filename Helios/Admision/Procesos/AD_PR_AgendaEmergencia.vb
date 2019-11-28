Public Class AD_PR_AgendaEmergencia
    Dim IGVTasa As Double
    Private Sub pFormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Timer1.Enabled = False
    End Sub

    Private Sub AD_PR_AgendaCitas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call Cargar_Combos()
        udte_fecha.Value = gDat_Fecha_Sis
        ucbo_Turno.SelectedIndex = 0
        ubtn_a.Appearance.Image = My.Resources._16__Db_previous_
        ubtn_s.Appearance.Image = My.Resources._16__Db_next_

        Timer1.Enabled = True
        Timer1.Interval = 60000
        Cargar_Tasas_Impuestos()
        ' Timer1.Start()
    End Sub

    Private Sub Cargar_Combos()

        'Dim servicioBL As New BL.AdmisionBL.SG_AD_TB_SERVICIO_MEDICO
        'uce_Servicio.DataSource = servicioBL.get_Servicios_X_Medico2(gInt_IdEmpresa)
        'uce_Servicio.ValueMember = "SM_ID"
        'uce_Servicio.DisplayMember = "SM_DESCRIPCION"
        'servicioBL = Nothing


        Dim obj2 As New DataTable
        Dim UsuMeBL As New BL.AdmisionBL.SG_AD_TB_MEDICO
        Dim UsuMeBE As New BE.AdmisionBE.SG_AD_TB_MEDICO
        UsuMeBE.ME_IDEMPRESA = gInt_IdEmpresa
        UsuMeBL.SEL03(UsuMeBE, udte_fecha.Value, obj2)
        uce_Medico.DataSource = obj2
        uce_Medico.ValueMember = "ME_CODIGO"
        uce_Medico.DisplayMember = "NOMBRES"
        UsuMeBL = Nothing

        Dim TurnoBL As New BL.AdmisionBL.SG_AD_TB_TURNO
        Dim obj As New DataTable
        TurnoBL.SEL01(gInt_IdEmpresa, obj)
        ucbo_Turno.DataSource = obj
        ucbo_Turno.ValueMember = "TU_ID"
        ucbo_Turno.DisplayMember = "TU_DESCRIPCION"
        TurnoBL = Nothing

    End Sub

    Private Sub uce_Servicio_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles uce_Servicio.ValueChanged
        uce_Medico.SelectedIndex = -1
    End Sub

    Private Sub ubtn_a_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ubtn_a.Click
        udte_fecha.Value = CDate(udte_fecha.Value).AddDays(-1)
        Cargar_Combos()
        uce_Servicio.SelectedIndex = 0
        uce_Medico.SelectedIndex = -1
        ' Call Cargar_Agenda(udte_fecha.Value, uce_Servicio.Value, uce_Medico.Value, ucbo_Turno.Value)
    End Sub

    Private Sub ubtn_s_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ubtn_s.Click
        udte_fecha.Value = CDate(udte_fecha.Value).AddDays(1)
        Cargar_Combos()
        uce_Servicio.SelectedIndex = 0
        uce_Medico.SelectedIndex = -1
        'Call Cargar_Agenda(udte_fecha.Value, uce_Servicio.Value, uce_Medico.Value, ucbo_Turno.Value)
    End Sub

    'Private Sub ug_intervalos_AfterCellActivate(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    Dim idCita As Integer = 0
    '    If ug_intervalos.ActiveRow.Cells("IdCita").Value.ToString <> "" Then
    '        idCita = ug_intervalos.ActiveRow.Cells("IdCita").Value

    '        Call Avisar("Cita : " & idCita)
    '    End If
    'End Sub

    Public Sub Cargar_Agenda(ByVal fecha As String, ByVal Medico As String, ByVal Turno As Integer)

        Dim programacionBL As New BL.AdmisionBL.SG_AD_TB_PROGRAMA_CITA
        'Dim dt_prog As DataTable
        ug_intervalos.DataSource = programacionBL.get_Programacion_x_Fecha_Emerg(CDate(fecha).ToShortDateString, Medico, gInt_IdEmpresa, Turno)
        programacionBL = Nothing

        'Call LimpiaGrid(ug_intervalos, uds_intervalos)

        If ug_intervalos.Rows.Count > 0 Then
            txt_idprogramacion.Text = ug_intervalos.DataSource.Rows(0)("PR_ID").ToString
        Else
            txt_idprogramacion.Text = ""
        End If

    End Sub

    Private Sub ubtn_Consultar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ubtn_Consultar.Click
        Call Cargar_Agenda(udte_fecha.Value, uce_Medico.Value, ucbo_Turno.Value)
    End Sub

    Private Sub Tool_Salir_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_Salir.Click
        Me.Close()
    End Sub


    Private Sub Inicio_Atencion()
        With AD_PR_AtencionEmergencia
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
            'Dim cOBERTURABL As New BL.AdmisionBL.SG_AD_TB_COBERTURA
            'bscOBERTURA.DataSource = cOBERTURABL.getOrigen()
            'bscOBERTURA.Filter = String.Format("CB_IDTIPO_ORIGEN = '{0}'", .ucm_Tipo.Value)
            '.txt_DesCobertura.DataSource = bscOBERTURA
            '.txt_DesCobertura.DisplayMember = "CB_DESCRIPCION"
            '.txt_DesCobertura.ValueMember = "CB_ID"
            'cOBERTURABL = Nothing

            Dim cOBERTURABL As New BL.AdmisionBL.SG_AD_TB_COBERTURA
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

    Private Sub Inicio_AtencionNuevo()
        With AD_PR_AtencionEmergencia
            Call Limpiar_Controls_InGroupox(.ugb_Cuenta)
            Call Limpiar_Controls_InGroupox(.ugb_Datos)

            .uds_detalle.Rows.Clear()
            .ug_detalle.DataSource = .uds_detalle

            .udte_fecha.Value = udte_fecha.Value
            .txt_Servicio.Text = uce_Servicio.Text
            .txt_Medico.Text = uce_Medico.Text
            .IDMEDICO = uce_Medico.Value

            If ug_intervalos.Rows.Count = 1 And ug_intervalos.DataSource.Rows(0)("CM_ID").ToString = 0 Then
                .txt_Orden.Value = 1
            Else
                .txt_Orden.Value = ug_intervalos.Rows.Count + 1
            End If
            .txt_Hora.Value = ""
            .txt_idprogramacion.Value = txt_idprogramacion.Text
            .txt_idCita.Text = 0

            .OPCION = 1
            .lNew = True

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
            'Dim cOBERTURABL As New BL.AdmisionBL.SG_AD_TB_COBERTURA
            'bscOBERTURA.DataSource = cOBERTURABL.getOrigen()
            'bscOBERTURA.Filter = String.Format("CB_IDTIPO_ORIGEN = '{0}'", .ucm_Tipo.Value)
            '.txt_DesCobertura.DataSource = bscOBERTURA
            '.txt_DesCobertura.DisplayMember = "CB_DESCRIPCION"
            '.txt_DesCobertura.ValueMember = "CB_ID"
            'cOBERTURABL = Nothing

            Dim cOBERTURABL As New BL.AdmisionBL.SG_AD_TB_COBERTURA
            .txt_DesCobertura.DataSource = cOBERTURABL.getOrigen()
            .txt_DesCobertura.DisplayMember = "CB_DESCRIPCION"
            .txt_DesCobertura.ValueMember = "CB_ID"
            cOBERTURABL = Nothing
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

    Private Sub Tool_Atencion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_Atencion.Click
        If ug_intervalos.Rows.Count = 0 Then Exit Sub
        If udte_fecha.Value < Now.Date And ug_intervalos.ActiveRow.Cells(9).Value = "" Then Exit Sub
        With AD_PR_AtencionEmergencia
            Call Inicio_AtencionNuevo()
            .ShowDialog()
            Call Cargar_Agenda(udte_fecha.Value, uce_Medico.Value, ucbo_Turno.Value)
        End With
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Call Cargar_Agenda(udte_fecha.Value, uce_Medico.Value, ucbo_Turno.Value)
    End Sub

    Private Sub ug_intervalos_DoubleClickCell(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinGrid.DoubleClickCellEventArgs) Handles ug_intervalos.DoubleClickCell
        If ug_intervalos.Rows.Count = 0 Then Exit Sub

        With AD_PR_AtencionEmergencia
            Call Inicio_Atencion()

            If ug_intervalos.ActiveRow.Cells(9).Value = "Atendido" Or ug_intervalos.ActiveRow.Cells(9).Value = "Paso Consulta" Then

                '.uck_HoraIngreso.Enabled = False
                'llenar los datos de seguro Y LA CUENTA

                Dim CitaBL As New BL.AdmisionBL.SG_AD_TB_CITA_MED
                Dim CitaBE As New BE.AdmisionBE.SG_AD_TB_CITA_MED

                CitaBE.CM_ID = ug_intervalos.ActiveRow.Cells(0).Value
                CitaBL.SEL01(CitaBE)
                If CitaBE.HasRow Then
                    If CitaBE.CM_IDMEDICODERI <> "" Then .uce_Medico.Value = CitaBE.CM_IDMEDICODERI
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
                            .txt_FijoC.Text = CuentaBE.CC_SIT_COPG_FIJO
                            .txt_PagoFijo.Text = Math.Round(Math.Round((CuentaBE.CC_SIT_COPG_FIJO * (IGVTasa / 100)), 2) + CuentaBE.CC_SIT_COPG_FIJO, 0)
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
                        If .ug_detalle.Rows(i).Cells(13).Value <> 0 Then
                            a += 0
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
            End If

            .ShowDialog()
            Call Cargar_Agenda(udte_fecha.Value, uce_Medico.Value, ucbo_Turno.Value)
        End With
    End Sub

    Private Sub ug_intervalos_InitializeRow(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinGrid.InitializeRowEventArgs) Handles ug_intervalos.InitializeRow
        If e.Row.Cells(9).Value = "Paso Consulta" Then
            e.Row.Appearance.BackColor = Color.FromArgb(154, 233, 180)
        ElseIf e.Row.Cells(9).Value = "" Then
            e.Row.Appearance.BackColor = Color.White
        ElseIf e.Row.Cells(9).Value = "Citado" Then
            e.Row.Appearance.BackColor = Color.FromArgb(170, 234, 244)
        Else
            e.Row.Appearance.BackColor = Color.LightYellow
        End If

    End Sub

    Private Sub udte_fecha_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles udte_fecha.ValueChanged
        Cargar_Combos()
        uce_Servicio.SelectedIndex = 0
        uce_Medico.SelectedIndex = -1
    End Sub

End Class