Public Class AD_PR_ReservaCita
    Private obe As BE.AdmisionBE.SG_AD_TB_CITA_MED
    Private obr As BL.AdmisionBL.SG_AD_TB_CITA_MED
    Public lNew As Boolean = False
    Public OPCION As Integer
    Public Servicio As Integer
    Public Medico As String

    Public Sub New()
        InitializeComponent()
        obe = New BE.AdmisionBE.SG_AD_TB_CITA_MED
        obr = New BL.AdmisionBL.SG_AD_TB_CITA_MED
    End Sub

    Private Sub pKeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Me.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Return) Then
            SendKeys.Send("{TAB}")
            e.Handled = True
        End If
    End Sub
    Private Sub pLostfocus(ByVal sender As Object, ByVal e As System.EventArgs) ' Handles txt_DesCorto.LostFocus, txt_Descripcion.LostFocus
        sender.BackColor = Color.White
        If sender.Text.Trim.Length < 1 Then
            sender.BackColor = Color.LightPink
        End If
    End Sub
    Private Function fValida() As Boolean
        pLostfocus(txt_ruc_cliente, Nothing)

        If txt_ruc_cliente.BackColor = Color.LightPink Then GoTo Err_Valida

        If OPCION = 3 Then
            udte_fechaP.BackColor = Color.White
            ucb_Orden.BackColor = Color.White
            If udte_fechaP.Value = Nothing Then udte_fechaP.BackColor = Color.LightPink
            If ucb_Orden.SelectedIndex = -1 Then ucb_Orden.BackColor = Color.LightPink

            pLostfocus(txt_HoraPost, Nothing)

            If txt_HoraPost.BackColor = Color.LightPink Then GoTo Err_Valida
            If udte_fechaP.BackColor = Color.LightPink Then GoTo Err_Valida
            If ucb_Orden.BackColor = Color.LightPink Then GoTo Err_Valida
        End If

        Return True
        Exit Function
Err_Valida:
        MessageBox.Show("Corrija ó Complete los campos errados !!", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Return False
    End Function
    'Private Sub Inicializa()
    '    udte_fechaP.BackColor = Color.White
    '    ucb_Orden.BackColor = Color.White
    'End Sub

    Private Sub AD_PR_ReservaCita_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txt_ruc_cliente.ButtonsRight(0).Appearance.Image = My.Resources._104
        '  txt_NumDoc.ButtonsRight(0).Appearance.Image = My.Resources._16__Page_number_
        udte_fechaP.BackColor = Color.White
        ucb_Orden.BackColor = Color.White
        txt_HoraPost.BackColor = Color.White
        txt_ruc_cliente.BackColor = Color.White

        Dim medicosBL As New BL.AdmisionBL.SG_AD_TB_MEDICO
        uce_Medico.DataSource = medicosBL.get_Medicos(gInt_IdEmpresa)
        uce_Medico.ValueMember = "ME_CODIGO"
        uce_Medico.DisplayMember = "NOMBRES"
        medicosBL = Nothing

        'Dim documentosBL As New BL.AdmisionBL.SG_AD_TB_TIP_DOC_PER
        'uce_tip_doc.DataSource = documentosBL.getTiposDocs(gInt_IdEmpresa)
        'uce_tip_doc.DisplayMember = "TD_ABREVIATURA"
        'uce_tip_doc.ValueMember = "TD_ID"
        'documentosBL = Nothing

        obe = New BE.AdmisionBE.SG_AD_TB_CITA_MED
        obr = New BL.AdmisionBL.SG_AD_TB_CITA_MED

        Me.KeyPreview = True

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

    'Private Sub Validar_existe_Cliente(ByRef existe As Boolean)
    '    existe = True

    '    Dim clienteBL As New BL.FacturacionBL.SG_FA_TB_CLIENTE
    '    Dim clienteBE As New BE.FacturacionBE.SG_FA_TB_CLIENTE
    '    clienteBE.CL_ID = txt_IdCliente.Text
    '    clienteBE.CL_IDEMPRESA = New BE.ContabilidadBE.SG_CO_TB_EMPRESA With {.EM_ID = gInt_IdEmpresa}
    '    clienteBL.get_Cliente_x_Id(clienteBE)

    '    If clienteBE.CL_NOMBRE.Length = 0 Then
    '        Call Avisar("Cliente no existe en la base de datos,Revise por favor.")
    '        existe = False
    '    End If

    '    clienteBL = Nothing
    '    clienteBE = Nothing

    'End Sub

    Private Sub Ayuda_Anexo_Cab()
        ' FA_PR_ListaClientesAyuda.Int_Opcion = 1
        AD_PR_BuscaPaciente.ShowDialog()

        Dim matriz As List(Of String) = AD_PR_BuscaPaciente.GetLista

        'txt_ruc_cliente.ButtonsRight("editar").Enabled = False

        If matriz.Count > 0 Then
            txt_IdCliente.Text = matriz(1)
            txt_idHistoria.Text = matriz(0)
            txt_ruc_cliente.Text = matriz(9)
            uce_tip_doc.Value = matriz(8)
            txt_Des_Cliente.Text = matriz(2)
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
            txt_Des_Cliente.Text = clienteBE.HC_NOMBRE1
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
                    End If
                End If
            End If

        End If

        clienteBE = Nothing
        clienteBL = Nothing

    End Sub

    Private Sub Tool_Grabar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_Grabar.Click
        If fValida() = False Then Exit Sub

        With obe
            .CM_IDPROGRAMACION = txt_idprogramacion.Value
            .CM_FECHACITA = udte_fecha.Value
            .CM_HORA_PROG = txt_Hora.Value
            .CM_NUM_ORDEN = txt_Orden.Value
            .CM_IDNUMHIST = Val(txt_idHistoria.Value)
            .CM_IDCLIENTE = Val(txt_IdCliente.Value)
            .CM_USUARIO = String.Format("{0}-{1}", Environment.UserName, gStr_Usuario_Sis)
            .CM_PC = Environment.MachineName
            .CM_IDEMPRESA = gInt_IdEmpresa
            .CM_IDMEDICODERI = uce_Medico.Value
        End With

        If lNew Then
            Dim I As Integer
            I = obr.Insert_CITA(obe, String.Format("{0}-{1}", Environment.UserName, gStr_Usuario_Sis), Environment.MachineName)
            txt_idCita.Text = I
            If I < 0 Then
                MessageBox.Show("La operación solicitada no ha podido ser realizada", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If
        Else
            obe.CM_ID = txt_idCita.Text
            If OPCION = 3 Then
                obe.CM_FECHACITA = udte_fechaP.Value
                obe.CM_HORA_PROG = txt_HoraPost.Value
                obe.CM_NUM_ORDEN = ucb_Orden.Value
            End If
            
            If obr.Update_CITA(obe, String.Format("{0}-{1}", Environment.UserName, gStr_Usuario_Sis), Environment.MachineName) < 0 Then
                MessageBox.Show("La operación solicitada no ha podido ser realizada", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If

        End If
        Call Avisar("Listo!")
        'AD_PR_AgendaCitas.Cargar_Agenda(udte_fecha.Value, Servicio, Medico)
        Me.Close()

    End Sub

    Private Sub udte_fechaP_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles udte_fechaP.ValueChanged
        If udte_fechaP.Value <> Nothing Then
            Dim programacionBL As New BL.AdmisionBL.SG_AD_TB_PROGRAMA_CITA
            ucb_Orden.DataSource = programacionBL.get_Programacion_x_Fecha(CDate(udte_fechaP.Value).ToShortDateString, Servicio, Medico, gInt_IdEmpresa, Val(txt_idTurno.Text))
            ucb_Orden.ValueMember = "value"
            ucb_Orden.DisplayMember = "value"
            programacionBL = Nothing
        Else
            ucb_Orden.DataSource = Nothing
        End If
        txt_HoraPost.Text = ""
    End Sub

    Private Sub ucb_Orden_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ucb_Orden.ValueChanged
        If udte_fechaP.Value <> Nothing Then
            Dim ProgramaBL As New BL.AdmisionBL.SG_AD_TB_PROGRAMA_CITA
            Dim ProgramaBE As New BE.AdmisionBE.SG_AD_TB_PROGRAMA_CITA

            ProgramaBL.get_Programacion_x_Orden(ProgramaBE, udte_fechaP.Value, Servicio, Medico, gInt_IdEmpresa, Val(ucb_Orden.Value), Val(txt_idTurno.Text))
            If ProgramaBE.HasRow Then
                txt_idprogramacion.Value = ProgramaBE.PR_ID
                txt_HoraPost.Value = ProgramaBE.PR_TURNO_INI
            End If
        End If
    End Sub

    Private Sub Tool_Eliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_Eliminar.Click
        If txt_idCita.Text = "" Then Exit Sub
        If Preguntar("Seguro de Eliminar?") Then
            obe.CM_ID = Val(txt_idCita.Value)

            If obr.Delete_CITA(obe, String.Format("{0}-{1}", Environment.UserName, gStr_Usuario_Sis), Environment.MachineName) < 0 Then
                MessageBox.Show("La operación solicitada no ha podido ser realizada", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                Call Avisar("Listo!")
                'AD_PR_AgendaCitas.Cargar_Agenda(udte_fecha.Value, Servicio, Medico)
                Me.Close()
            End If
        End If
    End Sub
End Class