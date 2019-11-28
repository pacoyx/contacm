Public Class AD_PR_PostergarAtencion
    Private obe As BE.AdmisionBE.SG_AD_TB_CITA_MED
    Private obr As BL.AdmisionBL.SG_AD_TB_CITA_MED
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
        udte_fechaP.BackColor = Color.White
        ucbo_Turno.BackColor = Color.White
        ume_HoraLLegada.BackColor = Color.White
        uce_Medico.BackColor = Color.White
        If udte_fechaP.Value = Nothing Then udte_fechaP.BackColor = Color.LightPink
        If udte_fechaP.Text < Now.Date Then udte_fechaP.BackColor = Color.LightPink
        If uce_Medico.SelectedIndex = -1 Then uce_Medico.BackColor = Color.LightPink
        If ucbo_Turno.SelectedIndex = -1 Then ucbo_Turno.BackColor = Color.LightPink
        If ume_HoraLLegada.Value.ToString Is Nothing Then ume_HoraLLegada.BackColor = Color.LightPink


        If ume_HoraLLegada.BackColor = Color.LightPink Then GoTo Err_Valida
        If udte_fechaP.BackColor = Color.LightPink Then GoTo Err_Valida
        If ucbo_Turno.BackColor = Color.LightPink Then GoTo Err_Valida

        Return True
        Exit Function
Err_Valida:
        MessageBox.Show("Corrija ó Complete los campos errados !!", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Return False
    End Function

    Private Sub AD_PR_ReservaCita_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txt_ruc_cliente.ButtonsRight(0).Appearance.Image = My.Resources._104
        '  txt_NumDoc.ButtonsRight(0).Appearance.Image = My.Resources._16__Page_number_
        udte_fechaP.BackColor = Color.White
        ume_HoraLLegada.BackColor = Color.White
        ucbo_Turno.BackColor = Color.White
        uce_Medico.BackColor = Color.White

        Dim TurnoBL As New BL.AdmisionBL.SG_AD_TB_TURNO
        Dim obj As New DataTable
        TurnoBL.SEL01(gInt_IdEmpresa, obj)
        ucbo_Turno.DataSource = obj
        ucbo_Turno.ValueMember = "TU_ID"
        ucbo_Turno.DisplayMember = "TU_DESCRIPCION"
        TurnoBL = Nothing

        Dim obj2 As New DataTable
        uce_MedicoC.SelectedIndex = -1
        Dim UsuMeBL As New BL.AdmisionBL.SG_AD_TB_MEDICO
        Dim UsuMeBE As New BE.AdmisionBE.SG_AD_TB_MEDICO
        UsuMeBE.ME_IDEMPRESA = gInt_IdEmpresa
        'MsgBox(uce_Servicio.Value)
        UsuMeBL.SEL02(UsuMeBE, udte_fechaP.Value, obj2, Servicio)
        uce_MedicoC.DataSource = obj2
        uce_MedicoC.ValueMember = "ME_CODIGO"
        uce_MedicoC.DisplayMember = "NOMBRES"
        UsuMeBL = Nothing

        uce_MedicoC.Value = Medico

        obe = New BE.AdmisionBE.SG_AD_TB_CITA_MED
        obr = New BL.AdmisionBL.SG_AD_TB_CITA_MED

        Me.KeyPreview = True

    End Sub

    Private Sub Tool_Salir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_Salir.Click
        Me.Close()
    End Sub

    Private Sub Tool_Grabar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_Grabar.Click
        If fValida() = False Then Exit Sub

        With obe
            obe.CM_ID = txt_idCita.Text
            .CM_FECHACITA = udte_fechaP.Value
            .CM_HORA_ATENC = ume_HoraLLegada.Value
            .CM_OBSERVACIONES = txt_Observacion.Text
            .CM_IDEMPRESA = gInt_IdEmpresa
        End With
        Dim i As Integer
        i = obr.Update_Atencion(obe, String.Format("{0}-{1}", Environment.UserName, gStr_Usuario_Sis), Environment.MachineName, uce_MedicoC.Value, Servicio, ucbo_Turno.Value)
        If i < 0 Then
            If i = -2 Then Avisar("No se encuentra Cupo para esa fecha") Else MessageBox.Show("La operación solicitada no ha podido ser realizada", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        Call Avisar("Listo!")

        Me.Close()

    End Sub

    Private Sub udte_fechaP_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles udte_fechaP.Leave
        Dim obj2 As New DataTable
        uce_MedicoC.SelectedIndex = -1
        Dim UsuMeBL As New BL.AdmisionBL.SG_AD_TB_MEDICO
        Dim UsuMeBE As New BE.AdmisionBE.SG_AD_TB_MEDICO
        UsuMeBE.ME_IDEMPRESA = gInt_IdEmpresa
        'MsgBox(uce_Servicio.Value)
        UsuMeBL.SEL02(UsuMeBE, udte_fechaP.Value, obj2, Servicio)
        uce_MedicoC.DataSource = obj2
        uce_MedicoC.ValueMember = "ME_CODIGO"
        uce_MedicoC.DisplayMember = "NOMBRES"
        UsuMeBL = Nothing

        uce_MedicoC.Value = Medico
    End Sub

End Class