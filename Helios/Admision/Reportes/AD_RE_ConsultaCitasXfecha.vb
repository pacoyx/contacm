Public Class AD_RE_ConsultaCitasXfecha
    Private obr As BL.AdmisionBL.SG_AD_TB_Reportes
    Private Paciente As String
    Private Servicio As String
    Private Medico As String
    Private PacienteSisa As String
    Private ServicioSisa As String
    Private MedicoSisa As String
    Private PacienteEcoSisa As String
    Private MEcoSisa As String
    Private SEcoSisa As String
    Public Sub New()
        InitializeComponent()
        obr = New BL.AdmisionBL.SG_AD_TB_Reportes
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

        udte_fechaD.BackColor = Color.White
        udte_fechaH.BackColor = Color.White
        If udte_fechaD.Value = Nothing Then udte_fechaD.BackColor = Color.LightPink
        If udte_fechaH.Value = Nothing Then udte_fechaH.BackColor = Color.LightPink

        If udte_fechaD.BackColor = Color.LightPink Then GoTo Err_Valida
        If udte_fechaH.BackColor = Color.LightPink Then GoTo Err_Valida

        Return True
        Exit Function
Err_Valida:
        MessageBox.Show("Corrija ó Complete los campos errados !!", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Return False

    End Function


    Private Sub AD_RE_ConsultaCitasXfecha_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        txt_ruc_cliente.ButtonsRight(0).Appearance.Image = My.Resources._104
        '  txt_NumDoc.ButtonsRight(0).Appearance.Image = My.Resources._16__Page_number_
        txt_ruc_cliente.BackColor = Color.White

        Dim documentosBL As New BL.AdmisionBL.SG_AD_TB_TIP_DOC_PER
        uce_tip_doc.DataSource = documentosBL.getTiposDocs(gInt_IdEmpresa)
        uce_tip_doc.DisplayMember = "TD_ABREVIATURA"
        uce_tip_doc.ValueMember = "TD_ID"
        documentosBL = Nothing

        Dim medicosBL As New BL.AdmisionBL.SG_AD_TB_MEDICO
        uce_Medico.DataSource = medicosBL.get_Medicos(gInt_IdEmpresa)
        uce_Medico.ValueMember = "ME_CODIGO"
        uce_Medico.DisplayMember = "NOMBRES"
        medicosBL = Nothing

        Dim servicioBL As New BL.AdmisionBL.SG_AD_TB_SERVICIO_MEDICO
        uce_Servicio.DataSource = servicioBL.get_Servicios(gInt_IdEmpresa)
        uce_Servicio.ValueMember = "SM_ID"
        uce_Servicio.DisplayMember = "SM_DESCRIPCION"
        servicioBL = Nothing

        obr = New BL.AdmisionBL.SG_AD_TB_Reportes

        Cancelar()

        Me.KeyPreview = True

        udte_fechaD.Focus()
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
            utxt_Historia.Text = matriz(0)
            txt_ruc_cliente.Text = matriz(9)
            uce_tip_doc.Value = matriz(8)
            txt_Des_Cliente.Text = matriz(2)
            ' udte_fechaNac.Value = matriz(10)
            'txt_Edad.Value = Int(DateDiff("m", matriz(10), Date.Now) / 12)
            ' txt_ruc_cliente.ButtonsRight("editar").Enabled = True
        End If
        If uck_Paciente.Checked = True Then
            Paciente = " AND CL_NDOC='" & txt_ruc_cliente.Text & "'"
            PacienteSisa = " and ci_numhist=RIGHT(REPLICATE('0',10)+CAST('" & utxt_Historia.Text & "' AS VARCHAR(10)),10)"
            PacienteEcoSisa = " and ce_numhist=RIGHT(REPLICATE('0',10)+CAST('" & utxt_Historia.Text & "' AS VARCHAR(10)),10)"
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
            utxt_Historia.Text = clienteBE.HC_NUM_HIST
            txt_Des_Cliente.Text = clienteBE.HC_NOMBRE1
            'udte_fechaNac.Value = clienteBE.HC_FNAC
            'txt_Edad.Value = Int(DateDiff("m", clienteBE.HC_FNAC, Date.Now) / 12)
            'uce_tip_doc.Value = clienteBE.HC_TDOC
            'txt_ruc_cliente.Text = clienteBE.HC_NDOC
        End If
        If uck_Paciente.Checked = True Then
            Paciente = " AND CL_NDOC='" & txt_ruc_cliente.Text & "'"
            PacienteSisa = " and ci_numhist=RIGHT(REPLICATE('0',10)+CAST('" & utxt_Historia.Text & "' AS VARCHAR(10)),10)"
            PacienteEcoSisa = " and ce_numhist=RIGHT(REPLICATE('0',10)+CAST('" & utxt_Historia.Text & "' AS VARCHAR(10)),10)"
        End If

        clienteBE = Nothing
        clienteBL = Nothing

    End Sub

    Private Sub uck_Paciente_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles uck_Paciente.CheckedChanged
        If uck_Paciente.Checked = True Then
            txt_ruc_cliente.Enabled = True
            uce_tip_doc.Enabled = True
            Paciente = " AND CL_NDOC='" & txt_ruc_cliente.Text & "'"
            PacienteSisa = " and ci_numhist=RIGHT(REPLICATE('0',10)+CAST('" & utxt_Historia.Text & "' AS VARCHAR(10)),10)"
            PacienteEcoSisa = " and ce_numhist=RIGHT(REPLICATE('0',10)+CAST('" & utxt_Historia.Text & "' AS VARCHAR(10)),10)"
        Else
            txt_ruc_cliente.Enabled = False
            uce_tip_doc.Enabled = False
            txt_ruc_cliente.Text = ""
            utxt_Historia.Text = ""
            uce_tip_doc.SelectedIndex = 0
            Paciente = ""
            PacienteSisa = ""
            PacienteEcoSisa = ""
        End If
    End Sub

    Private Sub Cancelar()
        uck_Medico.Checked = False
        uck_Servicio.Checked = False
        uck_Paciente.Checked = True

        txt_ruc_cliente.Enabled = True
        uce_tip_doc.Enabled = True
        uce_Medico.Enabled = False
        uce_Servicio.Enabled = False

        udte_fechaD.Value = "01/01/" & Now.Year
        udte_fechaH.Value = Now.Date

        txt_ruc_cliente.Text = ""
        utxt_Historia.Text = ""
        uce_tip_doc.SelectedIndex = 0
        uce_Medico.SelectedIndex = 0
        uce_Servicio.SelectedIndex = 0


        Servicio = ""
        Paciente = ""
        Medico = ""
        ServicioSisa = ""
        PacienteSisa = ""
        MedicoSisa = ""
        PacienteEcoSisa = ""
        MEcoSisa = ""
        SEcoSisa = ""
        txt_ruc_cliente.Focus()
        uds_Lista.Rows.Clear()
        ug_Lista.DataSource = uds_Lista
    End Sub

    Private Sub Tool_Cancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_Cancelar.Click
        Cancelar()
    End Sub

    Private Sub uck_Medico_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles uck_Medico.CheckedChanged
        If uck_Medico.Checked = True Then
            uce_Medico.Enabled = True
            Medico = " AND PR_MEDICO='" & uce_Medico.Value & "'"
            MedicoSisa = " AND ci_medico='" & uce_Medico.Value & "'"
            If uce_Medico.Value = "012" Then
                MEcoSisa = " "
            Else
                MEcoSisa = " and ce_id='0' "
            End If
        Else
            uce_Medico.Enabled = False
            uce_Medico.SelectedIndex = -1
            Medico = ""
            MedicoSisa = ""
            MEcoSisa = ""
        End If
    End Sub

    Private Sub uce_Medico_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles uce_Medico.ValueChanged
        If uck_Medico.Checked = True Then
            Medico = " AND PR_MEDICO='" & uce_Medico.Value & "'"
            MedicoSisa = " AND ci_medico='" & uce_Medico.Value & "'"
            If uce_Medico.Value = "012" Then
                MEcoSisa = " "
            Else
                MEcoSisa = " and ce_id='0' "
            End If
        End If
    End Sub

    Private Sub uck_Servicio_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles uck_Servicio.CheckedChanged
        If uck_Servicio.Checked = True Then
            uce_Servicio.Enabled = True
            Servicio = " AND PR_IDSERVICIO='" & uce_Servicio.Value & "'"
            ServicioSisa = " and ci_servicio=RIGHT(REPLICATE('0',3)+CAST('" & uce_Servicio.Value & "' AS VARCHAR(3)),3)"
            If uce_Servicio.Value = "007" Then
                SEcoSisa = " "
            Else
                SEcoSisa = " and ce_id='0' "
            End If
        Else
            uce_Servicio.Enabled = False
            uce_Servicio.SelectedIndex = -1
            Servicio = ""
            ServicioSisa = ""
            SEcoSisa = ""
        End If
    End Sub

    Private Sub uce_Servicio_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles uce_Servicio.ValueChanged
        If uck_Servicio.Checked = True Then
            Servicio = " AND PR_IDSERVICIO='" & uce_Servicio.Value & "'"
            ServicioSisa = " and ci_servicio=RIGHT(REPLICATE('0',3)+CAST('" & uce_Servicio.Value & "' AS VARCHAR(3)),3)"
            If uce_Servicio.Value = "007" Then
                SEcoSisa = " "
            Else
                SEcoSisa = " and ce_id='0' "
            End If
        End If
    End Sub

    Private Sub ubtn_Consultar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ubtn_Consultar.Click
        Dim obj As New DataTable
        obr.SEL01(udte_fechaD.Text, udte_fechaH.Text, gInt_IdEmpresa, Paciente, Servicio, Medico, PacienteSisa, ServicioSisa, MedicoSisa, PacienteEcoSisa, MEcoSisa, SEcoSisa, obj)
        ug_Lista.DataSource = obj
    End Sub

    Private Sub Tool_Imprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_Imprimir.Click
        Me.Cursor = Cursors.WaitCursor
        Dim obj As New DataTable
        obr.SEL01(udte_fechaD.Text, udte_fechaH.Text, gInt_IdEmpresa, Paciente, Servicio, Medico, PacienteSisa, ServicioSisa, MedicoSisa, PacienteEcoSisa, MEcoSisa, SEcoSisa, obj)

        Dim nom_reporte As String = "SG_AD_04.RPT"
        Dim crystalBL As New LR.ClsReporte
        Dim dt_data As New DataTable
        dt_data = obj

        crystalBL.Muestra_Reporte(gStr_RutaRep & "\" & nom_reporte, dt_data, "")


        crystalBL = Nothing
        ' reportesBL = Nothing

        Me.Cursor = Cursors.Default
    End Sub

    Private Sub Tool_Salir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_Salir.Click
        Me.Close()
    End Sub

End Class