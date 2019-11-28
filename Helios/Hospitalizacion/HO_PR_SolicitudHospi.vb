Public Class HO_PR_SolicitudHospi
    Dim bol_nuevo As Boolean = False
    Private Sub pKeyPressNumero(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_idHistoria.KeyPress
        e.KeyChar = fKeyPress(e.KeyChar, sender.Text, 2)
        e.Handled = (e.KeyChar = "")
    End Sub
    Private Sub HO_PR_SolicitudHospi_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

        Call Inicializar_Estado_Botones_Tool(ToolS_Mantenimiento)
        Call MostrarTabs(0, utc_Solicitud)
        Call Cargar_Datos()
        Call Cargar_Combos()
        txt_idHistoria.ButtonsRight(0).Appearance.Image = My.Resources._104
        txt_idHistoria.Enabled = True
        ucm_SeguroEps.Enabled = False
        Me.KeyPreview = True
    End Sub

    Private Sub Cargar_Combos()

        Try

            Dim origenAteBL As New BL.AdmisionBL.SG_AD_TB_ORIGEN_ATENC
            uce_procedencia.DataSource = origenAteBL.getOrigen2()
            uce_procedencia.DisplayMember = "OA_DESCRIPCION"
            uce_procedencia.ValueMember = "OA_ID"
            origenAteBL = Nothing

            Dim servicioBL As New BL.AdmisionBL.SG_AD_TB_SERVICIO_MEDICO
            uce_servicio.DataSource = servicioBL.get_Servicios(gInt_IdEmpresa)
            uce_servicio.DisplayMember = "SM_DESCRIPCION"
            uce_servicio.ValueMember = "SM_ID"
            servicioBL = Nothing

            Dim medicoBL As New BL.AdmisionBL.SG_AD_TB_MEDICO
            uce_Medico.DataSource = medicoBL.get_Medicos(gInt_IdEmpresa)
            uce_Medico.DisplayMember = "NOMBRES"
            uce_Medico.ValueMember = "ME_CODIGO"
            medicoBL = Nothing

            Dim esta_paciBL As New BL.HospitalBL.SG_HO_TB_ESTA_PACI
            uce_est_paciente.DataSource = esta_paciBL.get_Estados()
            uce_est_paciente.ValueMember = "EP_ID"
            uce_est_paciente.DisplayMember = "EP_DESCRIPCION"
            esta_paciBL = Nothing

            Dim tipohabiBL As New BL.HospitalBL.SG_HO_TB_TIPO_HABI
            uce_tipo_Habi.DataSource = tipohabiBL.get_Tipos(gInt_IdEmpresa)
            uce_tipo_Habi.ValueMember = "P_ID"
            uce_tipo_Habi.DisplayMember = "P_DESCRIPCION"
            tipohabiBL = Nothing

            Dim gestanteBL As New BL.HospitalBL.SG_HO_TB_TIPO_GESTANTE
            uce_Gestante.DataSource = gestanteBL.get_Tipos(gInt_IdEmpresa)
            uce_Gestante.DisplayMember = "TG_DESCRIPCION"
            uce_Gestante.ValueMember = "TG_ID"
            gestanteBL = Nothing

            Dim asegBL As New BL.FacturacionBL.SG_FA_TB_CIA_ASEG
            ucm_SeguroEps.DataSource = asegBL.getAseguradoras(gInt_IdEmpresa)
            ucm_SeguroEps.DisplayMember = "CA_DESCRIPCION"
            ucm_SeguroEps.ValueMember = "CA_ID"
            asegBL = Nothing


            Dim tipoPacienteBL As New BL.HospitalBL.SG_HO_TB_TIPO_PACI
            uce_tipoPaciente.DataSource = tipoPacienteBL.get_Tipos()
            uce_tipoPaciente.ValueMember = "TP_ID"
            uce_tipoPaciente.DisplayMember = "TP_DESCRIPCION"
            tipoPacienteBL = Nothing

        Catch ex As Exception
            ShowError(ex.Message)
        End Try

    End Sub

    Private Sub Cargar_Datos()
        Try

            Dim SolicitudBL As New BL.HospitalBL.SG_HO_TB_SOLICITUD_HOSPI
            Dim SolicitudBE As New BE.HospitalBE.SG_HO_TB_SOLICITUD_HOSPI
            SolicitudBE.SH_IDEMPRESA = gInt_IdEmpresa
            ug_solicitud.DataSource = SolicitudBL.get_Solicitudes(SolicitudBE)

            SolicitudBE = Nothing
            SolicitudBL = Nothing

        Catch ex As Exception
            Avisar("Error: " & ex.Message)
        End Try

    End Sub

    Private Sub Tool_Nuevo_Click(sender As System.Object, e As System.EventArgs) Handles Tool_Nuevo.Click
        bol_nuevo = True
        Call MostrarTabs(1, utc_Solicitud)
        Call Cambiar_Estado_Botones_Tool(ToolS_Mantenimiento)
        Call Limpiar_Controls_InGroupox(ugb_datos)

        ucm_SeguroEps.SelectedIndex = -1
        uce_procedencia.Value = 2
        uce_est_paciente.Value = 1
        uce_tipoPaciente.Value = 1
        uce_Gestante.Value = 4
        uce_tipo_Habi.Value = 5
        txt_idHistoria.Enabled = True
        txt_idHistoria.Focus()

    End Sub

    Private Sub Tool_Grabar_Click(sender As System.Object, e As System.EventArgs) Handles Tool_Grabar.Click
        If txt_idHistoria.Text.Trim = "" Then
            Avisar("Ingrese la historia del paciente")
            txt_idHistoria.Focus()
            Exit Sub
        End If

        If udte_fecha.Value = Nothing Then
            Avisar("Ingrese la fecha de la solicitud")
            udte_fecha.Focus()
            Exit Sub
        End If

        If uce_servicio.SelectedIndex < 0 Then
            Avisar("Seleccione un servicio")
            uce_servicio.Focus()
            Exit Sub
        End If

        If uce_Medico.SelectedIndex < 0 Then
            Avisar("Seleccione un medico")
            uce_Medico.Focus()
            Exit Sub
        End If
        If uce_tipoPaciente.Value = 2 And ucm_SeguroEps.SelectedIndex < 0 Then
            Avisar("Seleccione el seguro")
            ucm_SeguroEps.Focus()
            Exit Sub
        End If

        If uce_procedencia.Value = 3 And Val(txt_idCuenta.Text) = 0 Then
            Avisar("Seleccione la Cuenta de Fertilidad")
            ubtn_Consultar.Focus()
            Exit Sub
        End If

        Dim solicitudBL As New BL.HospitalBL.SG_HO_TB_SOLICITUD_HOSPI
        Dim solicitudBE As New BE.HospitalBE.SG_HO_TB_SOLICITUD_HOSPI

        With solicitudBE
            If bol_nuevo Then
                .SH_ID = 0
            Else
                .SH_ID = txt_num_sol.Text.Trim
            End If
            .SH_IDCuenta = Val(txt_idCuenta.Text)
            .SH_FECHA_SOLI = CDate(udte_fecha.Value).ToShortDateString
            .SH_IDHISTORIA = txt_idHistoria.Text.Trim
            .SH_IDTIPPAC = uce_tipoPaciente.Value
            .SH_IDPROCED = uce_procedencia.Value
            .SH_IDSERVICIO = uce_servicio.Value
            .SH_IDMEDICO = uce_Medico.Value
            .SH_DIAGNISTICO = txt_diagnostico.Text.Trim
            .SH_IDESTADO_PAC = uce_est_paciente.Value
            .SH_IDHABITACION = uce_tipo_Habi.Value
            .SH_IDGES = uce_Gestante.Value
            .SH_ESTADO_SOL = uos_estado.Value
            .SH_USUARIO = String.Format("{0}-{1}", Environment.UserName, gStr_Usuario_Sis)
            .SH_TERMINAL = Environment.MachineName
            .SH_FECREG = Now.ToString
            .SH_IDEMPRESA = gInt_IdEmpresa
            .SH_IDSEGURO = IIf(uce_tipoPaciente.Value = 2, ucm_SeguroEps.Value, "")
        End With

        If bol_nuevo Then
            solicitudBL.Insert(solicitudBE)
        Else
            Dim i As Integer = 0
            i = solicitudBL.Update(solicitudBE)
            If i = -3 Then
                Call Avisar("No puede Grabar Fertilidad si la cuenta es de otro Tipo")
                solicitudBE = Nothing
                solicitudBL = Nothing
                Exit Sub
            End If
        End If

        solicitudBE = Nothing
        solicitudBL = Nothing

        Call Avisar("Listo!")
        Call Cargar_Datos()
        Call Cambiar_Estado_Botones_Tool(ToolS_Mantenimiento)
        Call MostrarTabs(0, utc_Solicitud)

    End Sub

    Private Sub Tool_Editar_Click(sender As System.Object, e As System.EventArgs) Handles Tool_Editar.Click
        bol_nuevo = False
        Call Limpiar_Controls_InGroupox(ugb_datos)
        Dim solicitudBL As New BL.HospitalBL.SG_HO_TB_SOLICITUD_HOSPI
        Dim solicitudBE As New BE.HospitalBE.SG_HO_TB_SOLICITUD_HOSPI
        solicitudBE.SH_ID = ug_solicitud.ActiveRow.Cells("SH_ID").Value
        solicitudBE.SH_IDEMPRESA = gInt_IdEmpresa
        solicitudBL.get_solicitud_x_id(solicitudBE)

        Dim historiaBL As New BL.AdmisionBL.SG_AD_TB_HISTO_CLINI
        Dim dt_tmp As DataTable = historiaBL.getHistorias_Base_x_Id(solicitudBE.SH_IDHISTORIA, gInt_IdEmpresa)

        With solicitudBE
            txt_num_sol.Text = .SH_ID
            udte_fecha.Value = .SH_FECHA_SOLI
            txt_idHistoria.Text = .SH_IDHISTORIA
            txt_Des_Paciente.Text = dt_tmp.Rows(0)("HC_NOMBRE1").ToString & " " & dt_tmp.Rows(0)("HC_NOMBRE2").ToString & " " & dt_tmp.Rows(0)("HC_APE_PAT").ToString & " " & dt_tmp.Rows(0)("HC_APE_MAT").ToString & " " & dt_tmp.Rows(0)("HC_APE_CASADA").ToString
            uce_tipoPaciente.Value = .SH_IDTIPPAC
            uce_procedencia.Value = .SH_IDPROCED
            uce_servicio.Value = .SH_IDSERVICIO
            uce_Medico.Value = .SH_IDMEDICO
            uce_est_paciente.Value = .SH_IDESTADO_PAC
            uce_tipo_Habi.Value = .SH_IDHABITACION
            uce_Gestante.Value = .SH_IDGES
            txt_diagnostico.Text = .SH_DIAGNISTICO
            uos_estado.Value = .SH_ESTADO_SOL
            ucm_SeguroEps.Value = .SH_IDSEGURO
            txt_idCuenta.Text = .SH_IDCuenta
        End With

        dt_tmp = Nothing
        historiaBL = Nothing

        Dim ver As New DataTable
        ver = solicitudBL.get_verifica(solicitudBE)

        If Val(ver.Rows(0)(0)) > 0 Then
            txt_idHistoria.Enabled = False
        Else
            txt_idHistoria.Enabled = True
        End If
        If uce_procedencia.Value = 3 Then
            txt_idHistoria.Enabled = False
        End If
        solicitudBE = Nothing
        solicitudBL = Nothing

        Call MostrarTabs(1, utc_Solicitud)
        Call Cambiar_Estado_Botones_Tool(ToolS_Mantenimiento)


        udte_fecha.Focus()

    End Sub

    Private Sub Tool_Cancelar_Click(sender As System.Object, e As System.EventArgs) Handles Tool_Cancelar.Click
        Call MostrarTabs(0, utc_Solicitud)
        Call Cambiar_Estado_Botones_Tool(ToolS_Mantenimiento)
    End Sub

    Private Sub Tool_Eliminar_Click(sender As System.Object, e As System.EventArgs) Handles Tool_Eliminar.Click

        If ug_solicitud.ActiveRow.IsFilterRow Then Exit Sub
        If ug_solicitud.ActiveRow Is Nothing Then Exit Sub

        If Preguntar("Seguro de Eliminar?") Then

            Dim solicitudBL As New BL.HospitalBL.SG_HO_TB_SOLICITUD_HOSPI
            Dim solicitudBE As New BE.HospitalBE.SG_HO_TB_SOLICITUD_HOSPI
            Dim dt_tmp As DataTable = Nothing
            Dim bol_salir As Boolean = False

            solicitudBE.SH_ID = ug_solicitud.ActiveRow.Cells("SH_ID").Value
            solicitudBE.SH_IDEMPRESA = gInt_IdEmpresa
            solicitudBE.SH_IDCuenta = ug_solicitud.ActiveRow.Cells("SH_IDCUENTA").Value

            Dim ver As New DataTable
            ver = solicitudBL.get_verifica(solicitudBE)
            If Val(ver.Rows(0)(0)) > 0 Then
                txt_idHistoria.Enabled = False
                Avisar("La solicitud Tiene una Cuenta que esta siendo usada")
                solicitudBE = Nothing
                solicitudBL = Nothing
                Exit Sub
            End If

            'dt_tmp = solicitudBL.get_Busca_Solicitud_EnAdmiPiso(solicitudBE)

            'If dt_tmp.Rows.Count > 0 Then
            '    If dt_tmp.Rows(0)("PH_ESTADO") = 1 Then
            '        Avisar("La solicitud esta registrada en 'Admision a Piso'. " & Chr(13) & " Dele de alta y vuelva crear otra Solicitud.")
            '        bol_salir = True
            '    End If

            '    If dt_tmp.Rows(0)("PH_ESTADO") = 2 Then
            '        Avisar("La solicitud ya fue registrada y dada de alta en 'Admision a Piso'." & Chr(13) & "Vuelva crear otra Solicitud si desea volver a utilizar .")

            '        bol_salir = True
            '    End If

            '    If bol_salir Then
            '        dt_tmp.Dispose()
            '        solicitudBE = Nothing
            '        solicitudBL = Nothing
            '        Exit Sub
            '    End If

            'Else
            solicitudBL.Delete(solicitudBE)
            solicitudBE = Nothing
            solicitudBL = Nothing
            Call Cargar_Datos()
            Call Avisar("Listo!")
            'End If

        End If

    End Sub

    Private Sub Tool_Salir_Click(sender As System.Object, e As System.EventArgs) Handles Tool_Salir.Click
        Me.Close()
    End Sub

    Private Sub txt_idHistoria_EditorButtonClick(sender As System.Object, e As Infragistics.Win.UltraWinEditors.EditorButtonEventArgs) Handles txt_idHistoria.EditorButtonClick
        Select Case e.Button.Key
            Case "ayuda"
                Call Mostrar_Ayuda_Historias()
        End Select
    End Sub

    Private Sub Mostrar_Ayuda_Historias()

        HO_MA_AyudaHistorias.ShowDialog()

        If HO_MA_AyudaHistorias.Bol_Aceptar Then
            Dim matriz As New List(Of BE.AdmisionBE.SG_AD_TB_HISTO_CLINI)
            matriz = HO_MA_AyudaHistorias.lista_empleados
            If matriz.Count > 0 Then
                txt_idHistoria.Text = matriz(0).HC_NUM_HIST
                txt_Des_Paciente.Text = matriz(0).HC_APE_PAT & " " & matriz(0).HC_APE_MAT & " " & matriz(0).HC_APE_CASADA.ToString & " " & matriz(0).HC_NOMBRE1
            End If
        End If
    End Sub

    Private Sub Buscar_historia()
        Dim HBL As New BL.AdmisionBL.SG_AD_TB_HISTO_CLINI
        Dim HBE As New BE.AdmisionBE.SG_AD_TB_HISTO_CLINI
        Dim drr_MOV As System.Data.SqlClient.SqlDataReader
        HBE.HC_NUM_HIST = Val(txt_idHistoria.Text)
        HBE.HC_IDEMPRESA = gInt_IdEmpresa
        drr_MOV = HBL.get_Historias_x_HIstoria(HBE)
        If drr_MOV.HasRows Then
            drr_MOV.Read()
            txt_Des_Paciente.Text = drr_MOV("HC_APE_PAT").ToString & " " & drr_MOV("HC_APE_MAT").ToString & " " & drr_MOV("HC_APE_CASADA").ToString & " " & drr_MOV("HC_NOMBRE1").ToString
        Else
            Avisar("No existe la Historia")
        End If

        HBE = Nothing
        HBL = Nothing

    End Sub

    Private Sub pKeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Me.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Return) Then
            SendKeys.Send("{TAB}")
            e.Handled = True
        End If
    End Sub

    Private Sub txt_idHistoria_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_idHistoria.KeyDown
        If e.KeyCode = Keys.Enter Then
            Call Buscar_historia()
        End If
        If e.KeyCode = Keys.F2 Then Call Mostrar_Ayuda_Historias()
    End Sub

    Private Sub uce_tipoPaciente_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles uce_tipoPaciente.ValueChanged
        If uce_tipoPaciente.Value = 2 Then
            ucm_SeguroEps.Enabled = True
        Else
            ucm_SeguroEps.Enabled = False
            ucm_SeguroEps.SelectedIndex = -1
        End If
    End Sub

    Private Sub ug_solicitud_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles ug_solicitud.DoubleClick

    End Sub

    Private Sub ubtn_Consultar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ubtn_Consultar.Click
        PR_PR_ListaCuentas.ShowDialog()

        Dim matriz As List(Of String) = PR_PR_ListaCuentas.GetLista

        If matriz.Count > 0 Then
            txt_idCuenta.Text = matriz(0)
            uce_procedencia.Value = matriz(1)
            ' txt_idHistoria.Value = matriz(3)
            uce_Medico.Value = matriz(18)

            Cargar_PreFacturacion(Val(matriz(9)))
            uce_tipoPaciente.Value = 1
            ucm_SeguroEps.SelectedIndex = -1
            ucm_SeguroEps.Enabled = False
            txt_idHistoria.Enabled = False
        End If
    End Sub
    Private Sub Cargar_PreFacturacion(ByVal id_preFac As Integer)
        Dim obe As New BE.FacturacionBE.SG_FA_TB_PRE_FACTURA_CAB
        Dim obr As New BL.FacturacionBL.SG_FA_TB_PRE_FACTURA_CAB

        obe.PF_ID = id_preFac
        obe.HasRow = False
        obr.SEL01(obe)
        If obe.HasRow Then
            With obe

                txt_idHistoria.Value = .PF_IDNUMHIST
                ' udte_fecha.Value = .PF_FECHA
                uce_Medico.Value = .PF_IDMEDICO
                txt_diagnostico.Text = .PF_Tratamiento

                Dim historiaBL As New BL.AdmisionBL.SG_AD_TB_HISTO_CLINI
                Dim dt_histo_tmp As DataTable = historiaBL.getHistorias_Base_x_Id(txt_idHistoria.Value, gInt_IdEmpresa)
                If dt_histo_tmp.Rows.Count > 0 Then
                    txt_Des_Paciente.Text = dt_histo_tmp.Rows(0)("HC_APE_PAT") & " " & dt_histo_tmp.Rows(0)("HC_APE_MAT") & " " & dt_histo_tmp.Rows(0)("HC_APE_CASADA") & " " & dt_histo_tmp.Rows(0)("HC_NOMBRE1") & " " & dt_histo_tmp.Rows(0)("HC_NOMBRE2")
                End If
            End With
        End If
    End Sub

    Private Sub ug_solicitud_DoubleClickRow(sender As System.Object, e As Infragistics.Win.UltraWinGrid.DoubleClickRowEventArgs) Handles ug_solicitud.DoubleClickRow

        If e.Row.IsFilterRow Then Exit Sub
        Call Tool_Editar_Click(sender, e)

    End Sub

 
End Class