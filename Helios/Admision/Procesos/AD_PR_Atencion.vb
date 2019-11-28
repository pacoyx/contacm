Imports Infragistics.Win.UltraWinGrid
Public Class AD_PR_Atencion
    Private obe As BE.AdmisionBE.SG_AD_TB_CITA_MED
    Private obr As BL.AdmisionBL.SG_AD_TB_CITA_MED

    Private obeT As BE.AdmisionBE.TMP_SG_AD_TB_CUENTA_DET
    Private obrT As BL.AdmisionBL.SG_AD_TB_CUENTA_CAB

    Public lNew As Boolean = False
    Public OPCION As Integer
    Dim IGVTasa As Double
    Dim TipoCambio As Double
    Public IDMEDICO As String

    Public Sub New()
        InitializeComponent()
        obe = New BE.AdmisionBE.SG_AD_TB_CITA_MED
        obr = New BL.AdmisionBL.SG_AD_TB_CITA_MED
        obeT = New BE.AdmisionBE.TMP_SG_AD_TB_CUENTA_DET
        obrT = New BL.AdmisionBL.SG_AD_TB_CUENTA_CAB
    End Sub
    Private Sub pKeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Me.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Return) Then
            SendKeys.Send("{TAB}")
            e.Handled = True
        End If
    End Sub
    Private Sub pKeyPressNumero(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_PagoFijo.KeyPress, txt_PagoVariable.KeyPress
        e.KeyChar = fKeyPress(e.KeyChar, sender.Text, 1)
        e.Handled = (e.KeyChar = "")
    End Sub
    Private Sub pLostfocus(ByVal sender As Object, ByVal e As System.EventArgs) ' Handles txt_DesCorto.LostFocus, txt_Descripcion.LostFocus
        sender.BackColor = Color.White
        If sender.Text.Trim.Length < 1 Then
            sender.BackColor = Color.LightPink
        End If
    End Sub
    Private Sub Obtener_TipoCambio_dia()

        Dim rpta As String = String.Empty
        Dim paraetrosBL As New BL.FacturacionBL.SG_FA_TB_PARAMETROS
        Dim paraetrosBE As New BE.FacturacionBE.SG_FA_TB_PARAMETROS

        paraetrosBE.AD_IDEMPRESA = New BE.ContabilidadBE.SG_CO_TB_EMPRESA With {.EM_ID = gInt_IdEmpresa}
        paraetrosBE.AD_TIPO = "SISTE"
        paraetrosBE.AD_NOMBRE = "TC"

        rpta = paraetrosBL.get_Valor(paraetrosBE)

        If rpta = "F" Then

            Dim tipocambioBL As New BL.FacturacionBL.SG_FA_TB_PARIDAD
            Dim tipocambioBE As New BE.FacturacionBE.SG_FA_TB_PARIDAD

            tipocambioBE.PA_IDEMPRESA = New BE.ContabilidadBE.SG_CO_TB_EMPRESA With {.EM_ID = 1}
            'tipocambioBE.PA_FECHA = CDate(udte_fec_emi.Value).ToShortDateString
            Dim dt_tc As DataTable = tipocambioBL.get_Pariedad_x_Ultimo(tipocambioBE)

            If dt_tc.Rows.Count > 0 Then
                TipoCambio = dt_tc.Rows(0)("PA_VENTA")
            Else
                TipoCambio = 0
            End If

            dt_tc = Nothing

            tipocambioBE = Nothing
            tipocambioBL = Nothing

        Else ' rpta = "C"

            Dim tipocamBL As New BL.ContabilidadBL.SG_CO_TB_TIPOCAMBIO
            Dim tipocamBE As New BE.ContabilidadBE.SG_CO_TB_TIPOCAMBIO

            tipocamBE.TC_IDEMPRESA = New BE.ContabilidadBE.SG_CO_TB_EMPRESA With {.EM_ID = gInt_IdEmpresa}
            tipocamBE.TC_FECHA = CDate(udte_fecha.Value).ToShortDateString
            tipocamBE.TC_IDMONEDA = New BE.ContabilidadBE.SG_CO_TB_MONEDA With {.MO_CODIGO = 2}
            tipocamBL.getTipoCambio(tipocamBE)

            TipoCambio = tipocamBE.TC_VENTA

            tipocamBE = Nothing
            tipocamBL = Nothing

        End If
    End Sub

    Private Function fValida() As Boolean
        pLostfocus(txt_idHistoria, Nothing)
        If Val(txt_idHistoria.Text) = 0 Then
            txt_idHistoria.BackColor = Color.LightPink
        End If
        If uchk_GenerarCta.Checked = True Then
            ucm_Tipo.BackColor = Color.White
            If ucm_Tipo.SelectedIndex = -1 Then ucm_Tipo.BackColor = Color.LightPink
            If ucm_Tipo.BackColor = Color.LightPink Then GoTo Err_Valida
        End If

        If txt_idHistoria.BackColor = Color.LightPink Then GoTo Err_Valida

        If OPCION = 3 Then
            ume_horaIngreso.BackColor = Color.White
            If ume_horaIngreso.Value.ToString Is Nothing Then ume_horaIngreso.BackColor = Color.LightPink

            If ume_horaIngreso.BackColor = Color.LightPink Then GoTo Err_Valida
        End If

        uck_HoraLlegada.BackColor = Color.Transparent
        If uck_HoraLlegada.Checked = False Then uck_HoraLlegada.BackColor = Color.LightPink
        If uck_HoraLlegada.BackColor = Color.LightPink Then GoTo Err_Valida

        ume_HoraLLegada.BackColor = Color.White
        If ume_HoraLLegada.Value.ToString = Nothing Then ume_HoraLLegada.BackColor = Color.LightPink

        If ume_HoraLLegada.BackColor = Color.LightPink Then GoTo Err_Valida

        Return True
        Exit Function
Err_Valida:
        MessageBox.Show("Corrija ó Complete los campos errados !!", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Return False
    End Function

    Private Sub AD_PR_Atencion_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txt_ruc_cliente.ButtonsRight(0).Appearance.Image = My.Resources._104
        '  txt_NumDoc.ButtonsRight(0).Appearance.Image = My.Resources._16__Page_number_
        txt_ruc_cliente.BackColor = Color.White
        txt_idHistoria.BackColor = Color.White

        Calcular_Totales()
        Cargar_Tasas_Impuestos()

        obe = New BE.AdmisionBE.SG_AD_TB_CITA_MED
        obr = New BL.AdmisionBL.SG_AD_TB_CITA_MED
        obeT = New BE.AdmisionBE.TMP_SG_AD_TB_CUENTA_DET
        obrT = New BL.AdmisionBL.SG_AD_TB_CUENTA_CAB

        Me.KeyPreview = True

        ume_HoraLLegada.Focus()
        ubt_Agregar.Appearance.Image = My.Resources._16__Plus_
        ubt_Quitar.Appearance.Image = My.Resources._132

        Obtener_TipoCambio_dia()

    End Sub

    Private Sub Tool_Salir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_Salir.Click
        Me.Close()
    End Sub

    Private Sub txt_ruc_cliente_EditorButtonClick(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinEditors.EditorButtonEventArgs) Handles txt_ruc_cliente.EditorButtonClick
        Select Case e.Button.Key
            Case "ayuda"
                Call Ayuda_Anexo_Cab()
            Case "editar"

        End Select
    End Sub

    Private Sub txt_ruc_cliente_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_ruc_cliente.ValueChanged
        If txt_ruc_cliente.Text.Trim.Length = 0 Then
            txt_IdCliente.Text = String.Empty
            txt_Des_Cliente.Text = String.Empty
        End If
    End Sub

    Private Sub txt_ruc_cliente_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_ruc_cliente.KeyDown
        If e.KeyCode = Keys.Enter Or e.KeyCode = Keys.Tab Then
            Call Buscar_Cliente()
        End If

        If e.KeyCode = Keys.F2 Then Call Ayuda_Anexo_Cab()
    End Sub

    Private Sub Ayuda_Anexo_Cab()
        ' FA_PR_ListaClientesAyuda.Int_Opcion = 1
        AD_PR_BuscaPaciente.ShowDialog()

        Dim matriz As List(Of String) = AD_PR_BuscaPaciente.GetLista

        'txt_ruc_cliente.ButtonsRight("editar").Enabled = False

        If matriz.Count > 0 Then
            txt_IdCliente.Text = matriz(1)
            txt_idHistoria.Text = matriz(0)
            Format(Val(txt_idHistoria.Text), "0000000000#")
            txt_ruc_cliente.Text = matriz(9)
            uce_tip_doc.Value = matriz(8)
            txt_Des_Cliente.Text = matriz(2)
            udte_fechaNac.Value = matriz(10)
            txt_Edad.Value = Int(DateDiff("m", matriz(10), Date.Now) / 12)
            ' txt_ruc_cliente.ButtonsRight("editar").Enabled = True
        End If

    End Sub

    Private Sub Buscar_Cliente()

        Dim clienteBL As New BL.AdmisionBL.SG_AD_TB_HISTO_CLINI
        Dim clienteBE As New BE.AdmisionBE.SG_AD_TB_HISTO_CLINI

        clienteBE.HC_NDOC = txt_ruc_cliente.Text.Trim
        clienteBE.HC_IDEMPRESA = gInt_IdEmpresa
        clienteBE.HC_TDOC = uce_tip_doc.Value
        clienteBL.get_Historias_x_Doc(clienteBE)

        If clienteBE.HasRow Then
            txt_IdCliente.Text = clienteBE.HC_IDCLIENTE
            txt_idHistoria.Text = clienteBE.HC_NUM_HIST
            Format(Val(txt_idHistoria.Text), "0000000000#")
            txt_Des_Cliente.Text = clienteBE.HC_NOMBRE1
            udte_fechaNac.Value = clienteBE.HC_FNAC
            txt_Edad.Value = Int(DateDiff("m", clienteBE.HC_FNAC, Date.Now) / 12)
            'uce_tip_doc.Value = clienteBE.HC_TDOC
            'txt_ruc_cliente.Text = clienteBE.HC_NDOC

            '  ubtn_agregar.Focus()
        Else

            If Preguntar("El cliente no existe!, Desea Crearlo?") Then

                FA_PR_IngClienteRapido.str_num_ruc = txt_ruc_cliente.Text.Trim
                'FA_PR_IngClienteRapido.str_ = uce_tip_doc.Value
                FA_PR_IngClienteRapido.ShowDialog()
                If FA_PR_IngClienteRapido.bol_Grabo Then
                    clienteBE.HC_NDOC = FA_PR_IngClienteRapido.txt_num_doc.Text.Trim
                    clienteBE.HC_IDEMPRESA = gInt_IdEmpresa
                    clienteBE.HC_TDOC = FA_PR_IngClienteRapido.uce_TipoDoc.Value
                    clienteBL.get_Historias_x_Doc(clienteBE)
                    If clienteBE.HasRow Then
                        txt_IdCliente.Text = clienteBE.HC_IDCLIENTE
                        txt_idHistoria.Text = clienteBE.HC_NUM_HIST
                        txt_Des_Cliente.Text = clienteBE.HC_NOMBRE1
                        uce_tip_doc.Value = clienteBE.HC_TDOC
                        txt_ruc_cliente.Text = clienteBE.HC_NDOC
                        udte_fechaNac.Value = clienteBE.HC_FNAC
                        txt_Edad.Value = Int(DateDiff("m", clienteBE.HC_FNAC, Date.Now) / 12)
                    End If
                End If
            End If

        End If

        clienteBE = Nothing
        clienteBL = Nothing

    End Sub

    Private Sub Obtener_Datos_Seguro()

        Dim AsegBL As New BL.FacturacionBL.SG_FA_TB_CIA_ASEG
        Dim AsegBE As New BE.FacturacionBE.SG_FA_TB_CIA_ASEG
        AsegBE.CA_ID = ucm_SeguroEps.Value
        AsegBE.CA_IDEMPRESA = gInt_IdEmpresa
        AsegBL.get_Aseguradora_x_id(AsegBE)
        txt_EPS.Value = AsegBE.CA_IDASEGU_SITED

        Dim sitedsBL As New BL.AdmisionBL.Siteds
        Dim objS As New DataTable
        sitedsBL.get_Cobertura_x_Paciente(txt_ruc_cliente.Value.ToString, txt_EPS.Text, objS)
        If objS.Rows.Count <= 0 Then sitedsBL.get_Cobertura_x_Paciente2(txt_ruc_cliente.Value.ToString, txt_EPS.Text, objS)
        If objS.Rows.Count > 0 Then
            txt_CodAutoriza.Value = objS.Rows(0)(0)
            txt_FechaAutoriza.Value = objS.Rows(0)(1)
            txt_CodAsegurado.Value = objS.Rows(0)(2)

            'TipoCambio()
            If objS.Rows(0)(8) = "PEN" Or objS.Rows(0)(8) = "S/." Then
                txt_PagoFijo.Value = objS.Rows(0)(5)
            Else
                txt_PagoFijo.Value = Val(objS.Rows(0)(5)) * TipoCambio
            End If

            txt_PagoVariable.Value = objS.Rows(0)(6)
            TXT_TIPOAFILIACION.Text = objS.Rows(0)(7)

            txt_FijoC.Value = Math.Round(txt_PagoFijo.Value / ((IGVTasa / 100) + 1), 2)

            'ACTUALIZAR CON LA TABLA COBERTURA Y TIPO ORIGEN
            Dim cBL As New BL.AdmisionBL.SG_AD_TB_COBERTURA
            Dim cBE As New BE.AdmisionBE.SG_AD_TB_COBERTURA
            cBE.CB_SITEDS = objS.Rows(0)(3).ToString
            cBL.SEL02(cBE)
            If cBE.HasRow Then
                'ucm_Tipo.Value = cBE.CB_IDTIPO_ORIGEN
                txt_DesCobertura.Value = cBE.CB_ID
            End If
            ' txt_CodCobertura.Value = objS.Rows(0)(3)
            ' txt_DesCobertura.Value = objS.Rows(0)(4)

        Else
            Avisar("El Codigo de Autorización no se a encontrado!")
        End If

    End Sub

    Public Function Buscar_Cuenta() As Integer

        Dim Cuenta2BL As New BL.AdmisionBL.SG_AD_TB_CUENTA_CAB
        Dim Cuenta2BE As New BE.AdmisionBE.SG_AD_TB_CUENTA_CAB

        Cuenta2BE.CC_IDNUM_HIST = Val(txt_idHistoria.Text)
        Cuenta2BE.CC_FECHA = udte_fecha.Value
        Cuenta2BL.SEL06_VALCuenta(Cuenta2BE)
        If Cuenta2BE.HasRow Then
            If Cuenta2BE.CC_IDSEGURO = "" Then
                If Preguntar("Tiene una Cuenta " & IIf(Cuenta2BE.CC_IDTIPO_ORI = 1, "Ambulatoria", "de Hospitalicion") & " " & IIf(Cuenta2BE.CC_IDSEGURO = "", "Particular", " por Seguro Abierta") & ", Desea Usarla?") = True Then
                    txt_IdCuenta.Text = Cuenta2BE.CC_ID
                    ucm_Tipo.Value = Cuenta2BE.CC_IDTIPO_ORI
                    uchk_SeguroEps.Checked = IIf(Cuenta2BE.CC_IDTIPO_ATENC = 2, True, False)
                    If Cuenta2BE.CC_IDTIPO_ATENC = 2 Then ucm_SeguroEps.Value = Cuenta2BE.CC_IDSEGURO

                    txt_EPS.Text = Cuenta2BE.CC_SIT_COD_EPS
                    txt_CodAsegurado.Text = Cuenta2BE.CC_SIT_COD_ASEG
                    txt_FechaAutoriza.Value = Cuenta2BE.CC_SIT_FEC_AUTORI
                    txt_DesCobertura.Value = Cuenta2BE.CC_SIT_COD_COBER
                    txt_CodAutoriza.Text = Cuenta2BE.CC_SIT_COD_GENE
                    uckIngresoManual.Checked = IIf(Cuenta2BE.CC_INGRESO_MANUAL = 1, True, False)
                    TXT_TIPOAFILIACION.Text = Cuenta2BE.CC_TIPOAFILIACION
                    uchk_GenerarCta.Checked = True
                    ugb_Cuenta.Enabled = False
                    ubt_Agregar.Enabled = True
                    ubt_Quitar.Enabled = True

                    'uchk_GenerarCta.Enabled = False
                    txt_ruc_cliente.Enabled = False
                    uce_tip_doc.Enabled = False

                    ucm_Tipo.ReadOnly = False
                    '.txt_ruc_cliente.Enabled = False
                    '.uce_tip_doc.Enabled = False

                    If Cuenta2BE.CC_IDTIPO_ATENC = 2 Then
                        'ucm_SeguroEps.Value = Cuenta2BE.CC_IDSEGURO
                        txt_FijoC.Text = Cuenta2BE.CC_SIT_COPG_FIJO
                        txt_PagoVariable.Text = Cuenta2BE.CC_SIT_COPG_VARI
                        txt_PagoFijo.Text = Math.Round(Math.Round((Cuenta2BE.CC_SIT_COPG_FIJO * (IGVTasa / 100)), 2) + Cuenta2BE.CC_SIT_COPG_FIJO, 0)
                    End If
                    ugb_Cuenta.Enabled = False
                    ubt_Agregar.Enabled = True
                    ubt_Quitar.Enabled = True

                    Return 1
                Else
                    Return 0
                End If
               
            Else
                If Preguntar("Tiene una Cuenta " & IIf(Cuenta2BE.CC_IDTIPO_ORI = 1, "Ambulatoria", "de Hospitalicion") & " " & IIf(Cuenta2BE.CC_IDSEGURO = "", "Particular", " por Seguro Abierta") & ", Desea Usarla?") = True Then
                    txt_IdCuenta.Text = Cuenta2BE.CC_ID
                    ucm_Tipo.Value = Cuenta2BE.CC_IDTIPO_ORI
                    uchk_SeguroEps.Checked = IIf(Cuenta2BE.CC_IDTIPO_ATENC = 2, True, False)
                    If Cuenta2BE.CC_IDTIPO_ATENC = 2 Then ucm_SeguroEps.Value = Cuenta2BE.CC_IDSEGURO

                    txt_EPS.Text = Cuenta2BE.CC_SIT_COD_EPS
                    txt_CodAsegurado.Text = Cuenta2BE.CC_SIT_COD_ASEG
                    txt_FechaAutoriza.Value = Cuenta2BE.CC_SIT_FEC_AUTORI
                    txt_DesCobertura.Value = Cuenta2BE.CC_SIT_COD_COBER
                    txt_CodAutoriza.Text = Cuenta2BE.CC_SIT_COD_GENE
                    uckIngresoManual.Checked = IIf(Cuenta2BE.CC_INGRESO_MANUAL = 1, True, False)
                    TXT_TIPOAFILIACION.Text = Cuenta2BE.CC_TIPOAFILIACION
                    uchk_GenerarCta.Checked = True
                    ugb_Cuenta.Enabled = False
                    ubt_Agregar.Enabled = True
                    ubt_Quitar.Enabled = True

                    'uchk_GenerarCta.Enabled = False
                    txt_ruc_cliente.Enabled = False
                    uce_tip_doc.Enabled = False

                    ucm_Tipo.ReadOnly = False
                    '.txt_ruc_cliente.Enabled = False
                    '.uce_tip_doc.Enabled = False

                    If Cuenta2BE.CC_IDTIPO_ATENC = 2 Then
                        'ucm_SeguroEps.Value = Cuenta2BE.CC_IDSEGURO
                        txt_FijoC.Text = Cuenta2BE.CC_SIT_COPG_FIJO
                        txt_PagoVariable.Text = Cuenta2BE.CC_SIT_COPG_VARI
                        txt_PagoFijo.Text = Math.Round(Math.Round((Cuenta2BE.CC_SIT_COPG_FIJO * (IGVTasa / 100)), 2) + Cuenta2BE.CC_SIT_COPG_FIJO, 0)
                    End If
                    ugb_Cuenta.Enabled = False
                    ubt_Agregar.Enabled = True
                    ubt_Quitar.Enabled = True

                    Return 1
                Else
                    Return 0
                End If
            End If
        Else
            Return 0
        End If
    End Function

    Private Sub uchk_GenerarCta_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles uchk_GenerarCta.CheckedChanged

        If uchk_GenerarCta.Checked = True And txt_IdCuenta.Text = "" Then
            If Buscar_Cuenta() = 0 Then
                If uchk_SeguroEps.Checked = True Then
                    Call Obtener_Datos_Seguro()
                    uckIngresoManual.Checked = False
                    uckIngresoManual.Enabled = True
                    txt_DesCobertura.ReadOnly = True
                Else
                    uckIngresoManual.Enabled = False
                    txt_DesCobertura.ReadOnly = True
                End If
                ugb_Cuenta.Enabled = True
                ubt_Agregar.Enabled = True
                ubt_Quitar.Enabled = True
                ucm_Tipo.ReadOnly = False
                obrT.Delete2_TMP(String.Format("{0}-{1}", Environment.UserName, gStr_Usuario_Sis), Environment.MachineName)

                ' Dim obrT As New BL.AdmisionBL.SG_AD_TB_CUENTA_CAB
                'Dim obeT As New BE.AdmisionBE.TMP_SG_AD_TB_CUENTA_DET
            Else
                If uchk_SeguroEps.Checked = False Then
                    Dim obj As New DataTable
                    obeT.TCD_IDCAB = Val(txt_IdCuenta.Text)
                    obrT.SEL01_TMP(obeT, String.Format("{0}-{1}", Environment.UserName, gStr_Usuario_Sis), Environment.MachineName, obj)
                    ug_detalle.DataSource = obj
                End If
            End If
        ElseIf uchk_GenerarCta.Checked = False Then
            ugb_Cuenta.Enabled = False
            ubt_Agregar.Enabled = False
            ubt_Quitar.Enabled = False


            uds_detalle.Rows.Clear()
            obrT.Delete2_TMP(String.Format("{0}-{1}", Environment.UserName, gStr_Usuario_Sis), Environment.MachineName)

            ug_detalle.DataSource = uds_detalle
            Calcular_Totales()

            Call Limpiar_Controls_InGroupox(ugb_Cuenta)
            txt_IdCuenta.Text = ""
            ucm_Tipo.SelectedIndex = 0
            ucm_Tipo.ReadOnly = True
        End If

    End Sub

    Private Sub uchk_SeguroEps_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles uchk_SeguroEps.CheckedChanged
        If uchk_SeguroEps.Checked = True Then
            ucm_SeguroEps.Enabled = True
            uchk_GenerarCta.Checked = False
        Else
            ucm_SeguroEps.SelectedIndex = -1
            ucm_SeguroEps.Enabled = False
            uchk_GenerarCta.Checked = False
            ugb_Cuenta.Enabled = False
            ubt_Agregar.Enabled = False
            ubt_Quitar.Enabled = False
            'ucm_Tipo.Enabled = False

            uds_detalle.Rows.Clear()
            ug_detalle.DataSource = uds_detalle
            obrT.Delete2_TMP(String.Format("{0}-{1}", Environment.UserName, gStr_Usuario_Sis), Environment.MachineName)

            Calcular_Totales()
            'ug_detalle .cl
            'ug_detalle.Rows. = Nothing
            'ug_detalle.DataSource = Nothing
            Call Limpiar_Controls_InGroupox(ugb_Cuenta)
            txt_IdCuenta.Text = ""
            ucm_Tipo.SelectedIndex = 0
        End If
    End Sub

    Private Sub txt_CodAutoriza_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_CodAutoriza.KeyDown
        If e.KeyCode = Keys.Enter Or e.KeyCode = Keys.Tab Then

            Dim AsegBL As New BL.FacturacionBL.SG_FA_TB_CIA_ASEG
            Dim AsegBE As New BE.FacturacionBE.SG_FA_TB_CIA_ASEG
            AsegBE.CA_ID = ucm_SeguroEps.Value
            AsegBE.CA_IDEMPRESA = gInt_IdEmpresa
            AsegBL.get_Aseguradora_x_id(AsegBE)
            txt_EPS.Value = AsegBE.CA_IDASEGU_SITED

            Dim sitedsBL As New BL.AdmisionBL.Siteds
            Dim objS As New DataTable
            sitedsBL.get_Cobertura_x_CodeAutoriza(txt_CodAutoriza.Text, txt_EPS.Text, objS)
            If objS.Rows.Count <= 0 Then sitedsBL.get_Cobertura_x_CodeAutoriza2(txt_CodAutoriza.Text, txt_EPS.Text, objS)
            If objS.Rows.Count > 0 Then
                txt_CodAutoriza.Value = objS.Rows(0)(0)
                txt_FechaAutoriza.Value = objS.Rows(0)(1)
                txt_CodAsegurado.Value = objS.Rows(0)(2)

                If objS.Rows(0)(8) = "PEN" Or objS.Rows(0)(8) = "S/." Then
                    txt_PagoFijo.Value = objS.Rows(0)(5)
                Else
                    txt_PagoFijo.Value = Val(objS.Rows(0)(5)) * TipoCambio
                End If

                txt_PagoVariable.Value = objS.Rows(0)(6)
                TXT_TIPOAFILIACION.Text = objS.Rows(0)(7)

                txt_FijoC.Value = Math.Round(txt_PagoFijo.Value / ((IGVTasa / 100) + 1), 2)

                'ACTUALIZAR CON LA TABLA COBERTURA Y TIPO ORIGEN
                Dim cBL As New BL.AdmisionBL.SG_AD_TB_COBERTURA
                Dim cBE As New BE.AdmisionBE.SG_AD_TB_COBERTURA
                cBE.CB_SITEDS = objS.Rows(0)(3).ToString
                cBL.SEL02(cBE)
                If cBE.HasRow Then
                    'ucm_Tipo.Value = cBE.CB_IDTIPO_ORIGEN
                    txt_DesCobertura.Value = cBE.CB_ID
                End If

            Else
                Avisar("No Se Encontro el DNI en el SITED, INGRESE EL CODIGO DE AUTORIZACION!")
                txt_CodAutoriza.Focus()
            End If

            uds_detalle.Rows.Clear()
            obrT.Delete2_TMP(String.Format("{0}-{1}", Environment.UserName, gStr_Usuario_Sis), Environment.MachineName)

            ug_detalle.DataSource = uds_detalle
            Calcular_Totales()
        End If
    End Sub

    Private Sub uckIngresoManual_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles uckIngresoManual.CheckedChanged
        If uckIngresoManual.Checked = True Then
            Dim a As Integer = 0
            For i As Integer = 0 To ug_detalle.Rows.Count - 1
                If ug_detalle.Rows(i).Cells(13).Value <> 0 Then
                    a += 0
                End If
            Next
            If a = 0 Then
                txt_PagoFijo.ReadOnly = False
                txt_PagoVariable.ReadOnly = False
            Else
                txt_PagoFijo.ReadOnly = True
                txt_PagoVariable.ReadOnly = True
            End If
            txt_DesCobertura.ReadOnly = False
            txt_CodAsegurado.ReadOnly = False
        Else
            txt_PagoFijo.Text = ""
            txt_PagoVariable.Text = ""
            txt_FijoC.Text = ""
            txt_PagoFijo.ReadOnly = True
            txt_PagoVariable.ReadOnly = True
            'txt_DesCobertura.ReadOnly = True
            txt_CodAsegurado.ReadOnly = True
        End If
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

    Private Sub ubt_Agregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ubt_Agregar.Click

        Dim igv_cal As Decimal = "0.00"
        Dim total_cal As Decimal = "0.00"
        Dim subtotal_cal As Decimal = "0.00"
        Dim descuento As Decimal = "0.00"
        'AD_PR_ListaArticulosSeg.  poner el check de atencion particular n false 
        AD_PR_ListaArticulosSeg.TipoSeg = IIf(uchk_SeguroEps.Checked = True, 1, 0)
        If uchk_SeguroEps.Checked = False Then
            AD_PR_ListaArticulosSeg.idSeguro = "000"
        Else
            AD_PR_ListaArticulosSeg.idSeguro = ucm_SeguroEps.Value.ToString
        End If
        AD_PR_ListaArticulosSeg.idMedico = IDMEDICO
        '  AD_PR_ListaArticulosSeg.idSeguro = IIf(uchk_SeguroEps.Checked = False, "000", ucm_SeguroEps.Value.ToString)
        AD_PR_ListaArticulosSeg.IGVTas = IGVTasa
        AD_PR_ListaArticulosSeg.ShowDialog()

        Dim matriz As List(Of BE.FacturacionBE.SG_FA_TB_ARTICULO) = AD_PR_ListaArticulosSeg.GetLista

        For Each articulo As BE.FacturacionBE.SG_FA_TB_ARTICULO In matriz

            If uchk_SeguroEps.Checked = True Then
                '  If AD_PR_ListaArticulosSeg.pbol_atencion_parti = False Then
                If articulo.CA_Consulta = 1 Then
                    descuento = Math.Round(articulo.AR_PRECIO_VENTA - Val(txt_FijoC.Value), 2)
                Else
                    descuento = Math.Round((articulo.AR_PRECIO_VENTA * Val(txt_PagoVariable.Value)) / 100, 2)
                End If
                'End If

            Else
                descuento = 0.0
            End If
            subtotal_cal = Math.Round(articulo.AR_PRECIO_VENTA - descuento, 2)
            igv_cal = Math.Round((subtotal_cal * IGVTasa) / 100, 2)
            total_cal = Math.Round(subtotal_cal + igv_cal, 2)

            Dim valItem As Integer = 0
            For i As Integer = 0 To ug_detalle.Rows.Count - 1
                If ug_detalle.Rows(i).Cells(14).Value > valItem Then
                    valItem = ug_detalle.Rows(i).Cells(14).Value
                End If
            Next

            ug_detalle.DisplayLayout.Bands(0).AddNew()
            ug_detalle.Rows(ug_detalle.Rows.Count - 1).Cells(0).Value = 1  ' cant
            ug_detalle.Rows(ug_detalle.Rows.Count - 1).Cells(1).Value = articulo.AR_ID  ' codigo id
            ug_detalle.Rows(ug_detalle.Rows.Count - 1).Cells(2).Value = articulo.AR_CODIGO 'codigo
            ug_detalle.Rows(ug_detalle.Rows.Count - 1).Cells(3).Value = articulo.AR_DESCRIPCION  'descripcion
            ug_detalle.Rows(ug_detalle.Rows.Count - 1).Cells(4).Value = articulo.AR_PRECIO_VENTA  'costo
            If uchk_SeguroEps.Checked = True Then
                'If AD_PR_ListaArticulosSeg.pbol_atencion_parti Then
                '    ug_detalle.Rows(ug_detalle.Rows.Count - 1).Cells(5).Value = 0 'No CUBRE
                'Else
                ug_detalle.Rows(ug_detalle.Rows.Count - 1).Cells(5).Value = IIf(articulo.CA_Consulta = 1, 0, 1) 'CUBRE
                'End If

                ug_detalle.Rows(ug_detalle.Rows.Count - 1).Cells(6).Value = articulo.CA_Consulta 'DEDUCLIBLE
            Else
                ug_detalle.Rows(ug_detalle.Rows.Count - 1).Cells(5).Value = 0
                ug_detalle.Rows(ug_detalle.Rows.Count - 1).Cells(6).Value = 0
            End If


            ug_detalle.Rows(ug_detalle.Rows.Count - 1).Cells(7).Value = descuento 'descuen
            ug_detalle.Rows(ug_detalle.Rows.Count - 1).Cells(8).Value = 0.0 'descuen
            ug_detalle.Rows(ug_detalle.Rows.Count - 1).Cells(9).Value = subtotal_cal 'sub tot
            ug_detalle.Rows(ug_detalle.Rows.Count - 1).Cells(10).Value = igv_cal 'igv
            ug_detalle.Rows(ug_detalle.Rows.Count - 1).Cells(11).Value = total_cal ' total
            ug_detalle.Rows(ug_detalle.Rows.Count - 1).Cells(12).Value = articulo.CA_Consulta ' consul
            ug_detalle.Rows(ug_detalle.Rows.Count - 1).Cells(13).Value = 0 ' comprobante
            ug_detalle.Rows(ug_detalle.Rows.Count - 1).Cells(14).Value = valItem + 1 ' items
            ug_detalle.Rows(ug_detalle.Rows.Count - 1).Cells(15).Value = articulo.CA_SINPAGO ' SIN PAGO
            ug_detalle.UpdateData()
            ug_detalle.Refresh()

            With obeT
                .TCD_CANT = 1
                .TCD_DESCUENTO = descuento
                .TCD_IDARTICULO = articulo.AR_ID
                .TCD_IDCAB = 0
                .TCD_IGV = igv_cal
                .TCD_ITEM = valItem + 1
                .TCD_PRECIO = articulo.AR_PRECIO_VENTA
                .TCD_SUB_TOTAL = subtotal_cal
                .TCD_TOTAL = total_cal

                .TCD_SINPAGO = 0
                .TCD_DSCTO_OTRO = 0.0
                If uchk_SeguroEps.Checked = True Then
                    'If AD_PR_ListaArticulosSeg.pbol_atencion_parti Then
                    '    .TCD_SEG_CUBRE = 0
                    'Else
                    .TCD_SEG_CUBRE = IIf(articulo.CA_Consulta = 1, 0, 1)
                    'End If
                    .TCD_DEDUCIBLE = articulo.CA_Consulta
                Else
                    .TCD_SEG_CUBRE = 0
                    .TCD_DEDUCIBLE = 0
                End If

            End With
            obrT.Insert_TMP(obeT, String.Format("{0}-{1}", Environment.UserName, gStr_Usuario_Sis), Environment.MachineName)

            'PARA COBRAR MENOS LAS ATENCIONES DEL MEDICO DERIVANTE PINILLA , SOLO RIESGO QUIRURGICO
            If (uce_Medico.Value = "027" Or uce_Medico.Value = "187") And (articulo.AR_ID = 320 Or articulo.AR_ID = 4743) And uchk_SeguroEps.Checked = False Then
                ug_detalle.Rows(ug_detalle.Rows.Count - 1).Cells(8).Value = 67.79

                ug_detalle.UpdateData()
                ug_detalle.Refresh()
            End If
        Next
        ' Call Calcular_Totales()
    End Sub

    Private Sub ubt_Quitar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ubt_Quitar.Click
        If ug_detalle.Rows.Count = 0 Then Exit Sub
        If ug_detalle.ActiveRow Is Nothing Then Exit Sub

        If ug_detalle.ActiveRow.Cells(13).Value <> 0 Then
            Call Avisar("El Servicio ya fue Cancelado")
            Exit Sub
        End If
        obeT.TCD_ITEM = ug_detalle.ActiveRow.Cells(14).Value
        obeT.TCD_IDCAB = Val(txt_IdCuenta.Text)
        obeT.TCD_IDCITA = Val(txt_idCita.Text)

        If obrT.DeleteDetalle_val(obeT, String.Format("{0}-{1}", Environment.UserName, gStr_Usuario_Sis), Environment.MachineName).Rows.Count = 0 Then
            Call Avisar("El Servicio Pertenece a otra cita, Solo es visual no puede eliminar")
            Exit Sub
        End If
        If Preguntar("Seguro que deseas eliminar el registro?") Then
            ug_detalle.ActiveRow.Hidden = True
            'ug_detalle.ActiveRow.Delete()

            obrT.Delete_TMP_ADMIN(obeT, String.Format("{0}-{1}", Environment.UserName, gStr_Usuario_Sis), Environment.MachineName)

            Call Calcular_Totales()
        End If
        'ug_detalle.Rows(ug_detalle.Rows.Count - 1).Hidden = True




    End Sub

    Private Sub Calcular_Totales()

        txt_SubTotal.Text = ""
        txt_IGV.Text = ""
        txt_Total.Text = ""
        Dim subtotal As Decimal = "0.00"
        Dim igv As Decimal = "0.00"
        Dim total As Decimal = "0.00"
        For i As Integer = 0 To ug_detalle.Rows.Count - 1
            If ug_detalle.Rows(i).Hidden = False Then
                subtotal += Val(ug_detalle.Rows(i).Cells(9).Value.ToString)
                igv += Val(ug_detalle.Rows(i).Cells(10).Value.ToString)
                total += Val(ug_detalle.Rows(i).Cells(11).Value.ToString)
            End If
        Next
        txt_SubTotal.Text = Math.Round(subtotal, 2)
        txt_IGV.Text = Math.Round(igv, 2)
        txt_Total.Text = Math.Round(total, 2)
    End Sub

    Private Sub ucm_SeguroEps_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ucm_SeguroEps.ValueChanged

        uchk_GenerarCta.Checked = False
        ugb_Cuenta.Enabled = False
        ubt_Agregar.Enabled = False
        ubt_Quitar.Enabled = False
        'ucm_Tipo.Enabled = False

        uds_detalle.Rows.Clear()
        ug_detalle.DataSource = uds_detalle

        obrT.Delete2_TMP(String.Format("{0}-{1}", Environment.UserName, gStr_Usuario_Sis), Environment.MachineName)

        Calcular_Totales()
        'ug_detalle .cl
        'ug_detalle.Rows. = Nothing
        'ug_detalle.DataSource = Nothing
        Call Limpiar_Controls_InGroupox(ugb_Cuenta)
        ucm_Tipo.SelectedIndex = 0

    End Sub

    Private Sub txt_PagoFijo_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_PagoFijo.ValueChanged
        uds_detalle.Rows.Clear()
        ug_detalle.DataSource = uds_detalle
        obrT.Delete2_TMP(String.Format("{0}-{1}", Environment.UserName, gStr_Usuario_Sis), Environment.MachineName)
        Calcular_Totales()
        txt_FijoC.Value = Math.Round(txt_PagoFijo.Value / ((IGVTasa / 100) + 1), 2)
    End Sub

    Private Sub txt_PagoVariable_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_PagoVariable.ValueChanged
        uds_detalle.Rows.Clear()
        ug_detalle.DataSource = uds_detalle
        obrT.Delete2_TMP(String.Format("{0}-{1}", Environment.UserName, gStr_Usuario_Sis), Environment.MachineName)
        Calcular_Totales()
    End Sub

    Private Sub Tool_Grabar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_Grabar.Click
        If fValida() = False Then Exit Sub

        With obe
            .CM_IDPROGRAMACION = txt_idprogramacion.Value
            .CM_IDNUMHIST = Val(txt_idHistoria.Value)
            .CM_FECHACITA = udte_fecha.Value
            .CM_NUM_ORDEN = txt_Orden.Value
            .CM_HORA_PROG = txt_Hora.Value
            .CM_HORA_ATENC = ume_HoraLLegada.Text
            .CM_OBSERVACIONES = txt_Observacion.Text
            .CM_EDAD_ATENC = Val(txt_Edad.Value)
            .CM_IDTIPO_ATENC = IIf(uchk_SeguroEps.Checked = True, 2, 1)
            .CM_IDSEGURO = IIf(uchk_SeguroEps.Checked = True, ucm_SeguroEps.Value, "")

            .CM_IDCLIENTE = Val(txt_IdCliente.Value)
            .CM_USUARIO = String.Format("{0}-{1}", Environment.UserName, gStr_Usuario_Sis)
            .CM_PC = Environment.MachineName
            .CM_IDEMPRESA = gInt_IdEmpresa
            .CM_HORA_ING = "" 'ume_horaIngreso.Value
            .CM_IDMEDICODERI = uce_Medico.Value
            .CM_Anamnesis = IIf(uck_Anamnesis.Checked = True, 1, 0)
        End With
        Dim TIPO As Integer = 0
        Dim obeC As New BE.AdmisionBE.SG_AD_TB_CUENTA_CAB
        If uchk_GenerarCta.Checked = True Then
            If txt_IdCuenta.Text = "" Then
                TIPO = 0
            Else
                TIPO = 1
                obeC.CC_ID = Val(txt_IdCuenta.Text)
            End If
        Else
            TIPO = 2
        End If

        With obeC
            .CC_IDTIPO_ORI = ucm_Tipo.Value
            .CC_IDNUM_HIST = Val(txt_idHistoria.Value)
            .CC_IDCLIENTE = Val(txt_IdCliente.Value)
            .CC_IDTIPO_ATENC = IIf(uchk_SeguroEps.Checked = True, 2, 1)
            .CC_IDSEGURO = IIf(uchk_SeguroEps.Checked = True, ucm_SeguroEps.Value, "")
            .CC_FECHA = udte_fecha.Value
            .CC_USUARIO = String.Format("{0}-{1}", Environment.UserName, gStr_Usuario_Sis)
            .CC_TERMINAL = Environment.MachineName
            .CC_IDEMPRESA = gInt_IdEmpresa
            .CC_IDPREFAC = 0

            .CC_SIT_COD_EPS = txt_EPS.Text
            .CC_SIT_COD_ASEG = txt_CodAsegurado.Text
            .CC_SIT_FEC_AUTORI = IIf(txt_FechaAutoriza.Value = Nothing, Date.Now, txt_FechaAutoriza.Value)
            .CC_SIT_COD_COBER = IIf(txt_DesCobertura.SelectedIndex = -1, 0, txt_DesCobertura.Value)

            .CC_SIT_COPG_FIJO = Val(txt_FijoC.Text)
            .CC_SIT_COPG_VARI = Val(txt_PagoVariable.Text)
            .CC_SIT_COD_GENE = txt_CodAutoriza.Text
            .CC_INGRESO_MANUAL = IIf(uckIngresoManual.Checked = True, 1, 0)
            .CC_TIPOAFILIACION = Val(TXT_TIPOAFILIACION.Text)
            .CC_SIT_MONTO_IMP = 0
        End With

        If lNew Then
            Dim I As Integer
            I = obr.Insert(obe, obeC, String.Format("{0}-{1}", Environment.UserName, gStr_Usuario_Sis), Environment.MachineName, TIPO)
            txt_IdCuenta.Text = I
            Format(Val(txt_IdCuenta.Text), "0000000000#")
            If I = -2 Then
                MessageBox.Show("El Numero De Orden Ya a sido usado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            Else
                If I < 0 Then
                    MessageBox.Show("La operación solicitada no ha podido ser realizada", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Exit Sub
                End If
            End If
        Else
            obe.CM_ID = txt_idCita.Text
            If OPCION = 3 Then
                'PASO A CONSULTA
                obe.CM_HORA_ING = ume_horaIngreso.Value.ToString
            End If
            Dim I As Integer
            I = obr.Update(obe, obeC, String.Format("{0}-{1}", Environment.UserName, gStr_Usuario_Sis), Environment.MachineName, TIPO)
            If I < 0 Then
                MessageBox.Show("La operación solicitada no ha podido ser realizada", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            Else
                If txt_IdCuenta.Text = "" Then txt_idCita.Text = I
            End If

        End If
        Call Avisar("Listo!")
        'AD_PR_AgendaCitas.Cargar_Agenda(udte_fecha.Value, Servicio, Medico)
        Me.Close()

    End Sub

    Private Sub uck_HoraLlegada_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles uck_HoraLlegada.CheckedChanged
        If uck_HoraLlegada.Checked = True Then
            ume_HoraLLegada.Value = Date.Now.TimeOfDay.ToString
            ume_HoraLLegada.Enabled = True
        Else
            ume_HoraLLegada.Value = ""
            ume_HoraLLegada.Enabled = False
        End If
    End Sub

    Private Sub uck_HoraIngreso_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles uck_HoraIngreso.CheckedChanged
        If uck_HoraIngreso.Checked = True Then
            ume_horaIngreso.Value = Date.Now.TimeOfDay.ToString
            ume_horaIngreso.Enabled = True
        Else
            ume_horaIngreso.Value = ""
            ume_horaIngreso.Enabled = False
        End If
    End Sub

    Private Sub Tool_ImprimirF_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_ImprimirF.Click
        Me.Cursor = Cursors.WaitCursor

        Dim nom_reporte As String = "SG_AD_02.RPT"
        Dim crystalBL As New LR.ClsReporte
        Dim dt_data As New DataTable

        Dim Telefono As String = ""
        Dim Celular As String = ""
        Dim Email As String = ""


        'Dim Edad As String = Int(DateDiff("m", udte_fechaNac.Value, Date.Now) / 12)

        'For i As Integer = 0 To ug_Comunicacion.Rows.Count - 2
        '    If ug_Comunicacion.Rows(i).Cells("Codigo").Value = "1" Then Telefono = ug_Comunicacion.Rows(i).Cells("Descripcion").Value
        '    If ug_Comunicacion.Rows(i).Cells("Codigo").Value = "2" Then Celular = ug_Comunicacion.Rows(i).Cells("Descripcion").Value
        'Next

        Dim clienteBL As New BL.AdmisionBL.SG_AD_TB_HISTO_CLINI
        Dim clienteBE As New BE.AdmisionBE.SG_AD_TB_HISTO_CLINI

        Dim GSBE As New BE.AdmisionBE.SG_AD_TB_GrupoSanguineo
        Dim MEBE As New BE.AdmisionBE.SG_AD_TB_MEDICO
        Dim REBE As New BE.AdmisionBE.SG_AD_TB_RECOMENDADO
        Dim ECBE As New BE.AdmisionBE.SG_AD_TB_ESTADO_CIVIL
        Dim NABE As New BE.AdmisionBE.SG_AD_TB_NACIONALIDAD


        ' clienteBE.HC_NDOC = txt_ruc_cliente.Text
        clienteBE.HC_IDEMPRESA = gInt_IdEmpresa
        ' --clienteBE.HC_TDOC = 1 'uce_tip_doc.Value
        clienteBE.HC_NUM_HIST = Val(txt_idHistoria.Text)
        clienteBL.get_Historias_x_DocCOmpleto(clienteBE, GSBE, MEBE, REBE, ECBE, NABE)

        Dim EdadTitular As Integer = 0
        EdadTitular = Int(DateDiff("m", clienteBE.HC_FNAC_TITU, Date.Now) / 12)

        If clienteBE.HasRow Then
            Dim comunicacionesBL As New BL.FacturacionBL.SG_FA_TB_CLIENTE_COMUNI
            Dim comunicacionesBE As New BE.FacturacionBE.SG_FA_TB_CLIENTE_COMUNI
            comunicacionesBE.CC_IDCLIENTE = clienteBE.HC_IDCLIENTE
            Dim dt_tmp As DataTable = comunicacionesBL.get_Comuninicaciones_xId(comunicacionesBE)
            comunicacionesBE = Nothing
            comunicacionesBL = Nothing
            For i As Integer = 0 To dt_tmp.Rows.Count - 1
                If dt_tmp.Rows(i)("CC_IDCOMUNICA") = "1" Then Telefono = Telefono & " " & dt_tmp.Rows(i)("CC_DESCRIPCION")
                If dt_tmp.Rows(i)("CC_IDCOMUNICA") = "2" Then Celular = Celular & " " & dt_tmp.Rows(i)("CC_DESCRIPCION")
                If dt_tmp.Rows(i)("CC_IDCOMUNICA") = "3" Then Email = dt_tmp.Rows(i)("CC_DESCRIPCION")
            Next
            crystalBL.Muestra_Reporte(gStr_RutaRep & "\" & nom_reporte, dt_data, "", "pApePat;" & clienteBE.HC_APE_PAT, "pTipoA;" & txt_DesCobertura.Text, "pCopeFijo;" & txt_PagoFijo.Text, "pCopeVar;" & txt_PagoVariable.Text, _
                                      "pApeMat;" & clienteBE.HC_APE_MAT, "pNombres;" & clienteBE.HC_NOMBRE1, "pHC;" & Format(Val(clienteBE.HC_NUM_HIST), "0000000000#") _
                                      , "pDomicilio;" & clienteBE.HC_DIR, "pTelefono;" & Telefono, "pMail;" & Email, "pOcupacion;" & clienteBE.HC_DetRecom _
                                      , "pDNI;" & clienteBE.HC_NDOC, "pFechaNac;" & udte_fechaNac.Text, "pEdad;" & txt_Edad.Text, "pCompania;" & ucm_SeguroEps.Text _
                                      , "pEstCivil;" & ECBE.EC_DESCRIPCION, "pSexo;" & clienteBE.HC_SEXO, "pFechaNacT;" & IIf(clienteBE.HC_IDCONDICION = 1, "", clienteBE.HC_FNAC_TITU), "pEdadT;" & IIf(clienteBE.HC_IDCONDICION = 1, "", EdadTitular), "pNacionalidad;" & NABE.NA_DESCRIPCION _
                                      , "pTitular;" & IIf(clienteBE.HC_IDCONDICION = 1, "", clienteBE.HC_TITULAR), "pCelular;" & Celular, "pAlergias;" & clienteBE.HC_ALERGIAS, "pRecomendacion;" & REBE.RE_NOMBRE _
                                      , "pGrupoS;" & GSBE.GS_NOMBRE, "pMedico;" & MEBE.ME_NOMBRES, "pDistrito;" & clienteBE.HC_UBIGEO, "pFechaAd;" & Now.Date, "pTerminal;" & Environment.MachineName _
                                      , "pHoraAd;" & Now.ToString("HH:mm:ss"), "pUsu;" & String.Format("{0}-{1}", Environment.UserName, gStr_Usuario_Sis))

        End If

        crystalBL = Nothing
        ' reportesBL = Nothing

        Me.Cursor = Cursors.Default
    End Sub

    Private Sub Tool_ImprimirA_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_ImprimirA.Click
        Me.Cursor = Cursors.WaitCursor

        Dim nom_reporte As String = "SG_AD_03.RPT"
        Dim crystalBL As New LR.ClsReporte
        Dim dt_data As New DataTable

        Dim clienteBL As New BL.AdmisionBL.SG_AD_TB_HISTO_CLINI
        Dim clienteBE As New BE.AdmisionBE.SG_AD_TB_HISTO_CLINI

        Dim GSBE As New BE.AdmisionBE.SG_AD_TB_GrupoSanguineo
        Dim MEBE As New BE.AdmisionBE.SG_AD_TB_MEDICO
        Dim REBE As New BE.AdmisionBE.SG_AD_TB_RECOMENDADO
        Dim ECBE As New BE.AdmisionBE.SG_AD_TB_ESTADO_CIVIL
        Dim NABE As New BE.AdmisionBE.SG_AD_TB_NACIONALIDAD


        'clienteBE.HC_NDOC = txt_ruc_cliente.Text
        clienteBE.HC_IDEMPRESA = gInt_IdEmpresa
        'clienteBE.HC_TDOC = 1 'uce_tip_doc.Value
        clienteBE.HC_NUM_HIST = Val(txt_idHistoria.Text)
        clienteBL.get_Historias_x_DocCOmpleto(clienteBE, GSBE, MEBE, REBE, ECBE, NABE)

        If clienteBE.HasRow Then

            crystalBL.Muestra_Reporte(gStr_RutaRep & "\" & nom_reporte, dt_data, "", "pNombres;" & clienteBE.HC_APE_PAT + " " + clienteBE.HC_APE_MAT + " " + clienteBE.HC_NOMBRE1, _
                                      "pTipoA;" & txt_DesCobertura.Text, "pCopeFijo;" & txt_PagoFijo.Text, "pCopeVar;" & txt_PagoVariable.Text, _
                                      "pcodAutorizacion;" & txt_CodAutoriza.Text, "pServicio;" & txt_Servicio.Text, "pHC;" & Format(Val(clienteBE.HC_NUM_HIST), "0000000000#") _
                                      , "pConsultorio;" & "CONSULTORIO", "pCuenta;" & Format(Val(txt_IdCuenta.Text), "0000000000#"), "pFechaVen;" & DateAdd(DateInterval.Day, 7, udte_fecha.Value).Date _
                                      , "pCompania;" & ucm_SeguroEps.Text, "pTitular;" & clienteBE.HC_TITULAR, "pHoraA;" & txt_Hora.Text _
                                      , "pMedico;" & txt_Medico.Text, "pFechaAd;" & udte_fecha.Text, "pTerminal;" & Environment.MachineName _
                                      , "pHoraAd;" & Now.ToString("hh:mm:ss"), "pUsu;" & String.Format("{0}-{1}", Environment.UserName, gStr_Usuario_Sis))
        End If

        crystalBL = Nothing
        ' reportesBL = Nothing

        Me.Cursor = Cursors.Default
    End Sub

    Private Sub ug_Detalle_AfterRowUpdate(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinGrid.RowEventArgs) Handles ug_detalle.AfterRowUpdate
        'e.Row.Cells("Total").Value = e.Row.Cells("Precio").Value * e.Row.Cells("Cant").Value
        Dim igv_cal As Decimal = "0.00"
        Dim total_cal As Decimal = "0.00"
        Dim subtotal_cal As Decimal = "0.00"
        Dim descuento As Decimal = "0.00"

        Dim Descto_OTRO As Double = e.Row.Cells(8).Value

        If uchk_SeguroEps.Checked = True Then
            If e.Row.Cells(12).Value = 1 Then
                descuento = Math.Round(e.Row.Cells(4).Value - Val(txt_FijoC.Value), 2)
            Else
                descuento = Math.Round((e.Row.Cells(4).Value * Val(txt_PagoVariable.Value)) / 100, 2)
            End If
        Else
            descuento = 0.0
        End If
        subtotal_cal = Math.Round(e.Row.Cells(4).Value - descuento - Descto_OTRO, 2)
        igv_cal = Math.Round((subtotal_cal * IGVTasa) / 100, 2)
        total_cal = Math.Round(subtotal_cal + igv_cal, 2)

        With obeT
            .TCD_CANT = e.Row.Cells(0).Value
            .TCD_IDARTICULO = e.Row.Cells(1).Value
            .TCD_ITEM = e.Row.Cells(14).Value
            .TCD_PRECIO = e.Row.Cells(4).Value
            .TCD_SINPAGO = 0
            .TCD_DSCTO_OTRO = Descto_OTRO
            If uchk_SeguroEps.Checked = True Then
                .TCD_SEG_CUBRE = IIf(e.Row.Cells(5).Value = True, 1, 0)
                .TCD_DEDUCIBLE = e.Row.Cells(12).Value
            Else
                .TCD_SEG_CUBRE = 0
                .TCD_DEDUCIBLE = 0
            End If
            .TCD_DESCUENTO = descuento
            .TCD_SUB_TOTAL = subtotal_cal
            .TCD_IGV = igv_cal
            .TCD_TOTAL = total_cal
            .TCD_DSCTO_PORC = 0
        End With
        'obrT.Insert_TMP(obeT, String.Format("{0}-{1}", Environment.UserName, gStr_Usuario_Sis), Environment.MachineName)
        obrT.Update_TMP(obeT, String.Format("{0}-{1}", Environment.UserName, gStr_Usuario_Sis), Environment.MachineName)


        e.Row.Cells(8).Value = Descto_OTRO
        e.Row.Cells(9).Value = subtotal_cal
        e.Row.Cells(10).Value = igv_cal
        e.Row.Cells(11).Value = total_cal

        Call Calcular_Totales()

    End Sub

    Private Sub ug_Detalle_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles ug_detalle.KeyDown

        If e.KeyCode = Keys.Enter Then

            ug_detalle.PerformAction(UltraGridAction.NextCellByTab, False, False)
            ug_detalle.UpdateData()

        End If

    End Sub

    Private Sub ug_Detalle_BeforeRowsDeleted(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.BeforeRowsDeletedEventArgs) Handles ug_detalle.BeforeRowsDeleted
        e.DisplayPromptMsg = False
        e.Cancel = False
    End Sub

    Private Sub uce_Medico_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles uce_Medico.ValueChanged
        'PARA COBRAR MENOS LAS ATENCIONES DEL MEDICO DERIVANTE PINILLA , SOLO RIESGO QUIRURGICO
        If uchk_SeguroEps.Checked = False Then
            'And (articulo.AR_ID = 320 Or articulo.AR_ID = 4743)
            For i As Integer = 0 To ug_detalle.Rows.Count - 1
                If ug_detalle.Rows(i).Cells(1).Value = 320 Or ug_detalle.Rows(i).Cells(1).Value = 4743 Then
                    If uce_Medico.Value = "027" Then
                        ug_detalle.Rows(i).Cells(8).Value = 67.79
                    Else
                        ug_detalle.Rows(i).Cells(8).Value = 0.0
                    End If
                    ug_detalle.UpdateData()
                    ug_detalle.Refresh()
                End If
            Next

        End If
    End Sub
End Class