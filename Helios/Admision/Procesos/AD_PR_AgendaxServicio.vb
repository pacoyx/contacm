Public Class AD_PR_AgendaxServicio
    Dim IGVTasa As Double

    Private Sub AD_PR_AgendaCitas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call Cargar_Combos()
        udte_fecha.Value = gDat_Fecha_Sis
        ucbo_Turno.SelectedIndex = 0
        ubtn_a.Appearance.Image = My.Resources._16__Db_previous_
        ubtn_s.Appearance.Image = My.Resources._16__Db_next_

        Timer1.Enabled = True
        Timer1.Interval = 60000
    End Sub

    Private Sub Cargar_Combos()

        Dim servicioBL As New BL.AdmisionBL.SG_AD_TB_SERVICIO_MEDICO
        uce_Servicio.DataSource = servicioBL.get_Servicios_X_Medico(gInt_IdEmpresa, gInt_IdUsuario_Sis)
        uce_Servicio.ValueMember = "SM_ID"
        uce_Servicio.DisplayMember = "SM_DESCRIPCION"
        servicioBL = Nothing

        Dim TurnoBL As New BL.AdmisionBL.SG_AD_TB_TURNO
        Dim obj As New DataTable
        TurnoBL.SEL01(gInt_IdEmpresa, obj)
        ucbo_Turno.DataSource = obj
        ucbo_Turno.ValueMember = "TU_ID"
        ucbo_Turno.DisplayMember = "TU_DESCRIPCION"
        TurnoBL = Nothing

    End Sub

    Private Sub uce_Servicio_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles uce_Servicio.ValueChanged
        Dim obj2 As New DataTable
        Dim UsuMeBL As New BL.AdmisionBL.SG_AD_TB_UsuXMedico
        Dim UsuMeBE As New BE.AdmisionBE.SG_AD_TB_UsuXMedico
        UsuMeBE.UM_IDUSUARIO = gInt_IdUsuario_Sis
        UsuMeBE.UM_IDEMPRESA = gInt_IdEmpresa
        UsuMeBL.SEL04(UsuMeBE, udte_fecha.Value, obj2, uce_Servicio.Value)
        uce_Medico.DataSource = obj2
        uce_Medico.ValueMember = "ME_CODIGO"
        uce_Medico.DisplayMember = "NOMBRES"
        UsuMeBL = Nothing
        uce_Medico.SelectedIndex = 0
    End Sub

    Private Sub ubtn_a_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ubtn_a.Click
        udte_fecha.Value = CDate(udte_fecha.Value).AddDays(-1)
        Call Cargar_Agenda(udte_fecha.Value, uce_Servicio.Value, uce_Medico.Value, ucbo_Turno.Value)
    End Sub

    Private Sub ubtn_s_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ubtn_s.Click
        udte_fecha.Value = CDate(udte_fecha.Value).AddDays(1)
        Call Cargar_Agenda(udte_fecha.Value, uce_Servicio.Value, uce_Medico.Value, ucbo_Turno.Value)
    End Sub

    Public Sub Cargar_Agenda(ByVal fecha As String, ByVal servicio As String, ByVal Medico As String, ByVal Turno As Integer)

        Dim scrollPos = ug_intervalos.ActiveRowScrollRegion.ScrollPosition

        Dim programacionBL As New BL.AdmisionBL.SG_AD_TB_PROGRAMA_CITA

        ug_intervalos.DataSource = programacionBL.get_Programacion_x_Fecha(CDate(fecha).ToShortDateString, servicio, Medico, gInt_IdEmpresa, Turno)
        programacionBL = Nothing

        If ug_intervalos.Rows.Count > 0 Then
            txt_idprogramacion.Text = ug_intervalos.DataSource.Rows(0)("PR_ID").ToString
        Else
            txt_idprogramacion.Text = ""
        End If

        ug_intervalos.ActiveRowScrollRegion.ScrollPosition = scrollPos

    End Sub

    Private Sub ubtn_Consultar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ubtn_Consultar.Click
        Call Cargar_Agenda(udte_fecha.Value, uce_Servicio.Value, uce_Medico.Value, ucbo_Turno.Value)
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
        If ug_intervalos.ActiveRow.Cells(1).Value = 0 Then
            With AD_PR_AtencionxServicio

                Call Inicio_Atencion()

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
        If e.Row.Cells(9).Value = "Paso Consulta" Then
            e.Row.Appearance.BackColor = Color.FromArgb(192, 255, 192)
        ElseIf e.Row.Cells(9).Value = "" Then
            e.Row.Appearance.BackColor = Color.White

        ElseIf e.Row.Cells(9).Value = "Salio" Then
            e.Row.Appearance.BackColor = Color.FromArgb(170, 234, 244)
        Else
            e.Row.Appearance.BackColor = Color.LightYellow
        End If


    End Sub

    Private Sub Tool_Salir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_Salir.Click
        Me.Close()
    End Sub

    Private Sub uce_Medico_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles uce_Medico.ValueChanged
        Call Cargar_Agenda(udte_fecha.Value, uce_Servicio.Value, uce_Medico.Value, ucbo_Turno.Value)
    End Sub
End Class