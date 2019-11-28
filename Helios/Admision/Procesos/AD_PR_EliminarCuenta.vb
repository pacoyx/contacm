Public Class AD_PR_EliminarCuenta

    Private Sub AD_PR_AgendaCitas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call Cargar_Combos()
        udte_fecha.Value = gDat_Fecha_Sis
        ucbo_Turno.SelectedIndex = 0
        ubtn_a.Appearance.Image = My.Resources._16__Db_previous_
        ubtn_s.Appearance.Image = My.Resources._16__Db_next_
    End Sub

    Private Sub Cargar_Combos()

        Dim TurnoBL As New BL.AdmisionBL.SG_AD_TB_TURNO
        Dim obj As New DataTable
        TurnoBL.SEL01(gInt_IdEmpresa, obj)
        ucbo_Turno.DataSource = obj
        ucbo_Turno.ValueMember = "TU_ID"
        ucbo_Turno.DisplayMember = "TU_DESCRIPCION"
        TurnoBL = Nothing
        ucbo_Turno.SelectedIndex = 0

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

    End Sub

    Private Sub uce_Servicio_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles uce_Servicio.ValueChanged
        'uce_Medico.SelectedIndex = -1
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
    End Sub

    Private Sub ubtn_a_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ubtn_a.Click
        udte_fecha.Value = CDate(udte_fecha.Value).AddDays(-1)
    End Sub

    Private Sub ubtn_s_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ubtn_s.Click
        udte_fecha.Value = CDate(udte_fecha.Value).AddDays(1)
    End Sub

    Public Sub Cargar_Agenda(ByVal fecha As String, ByVal servicio As String, ByVal Medico As String, ByVal Turno As Integer)

        Dim programacionBL As New BL.AdmisionBL.SG_AD_TB_PROGRAMA_CITA
        'Dim dt_prog As DataTable
        ug_intervalos.DataSource = programacionBL.get_Programacion_x_Cuenta(CDate(fecha).ToShortDateString, servicio, Medico, gInt_IdEmpresa, Turno)
        programacionBL = Nothing

        'Call LimpiaGrid(ug_intervalos, uds_intervalos)

        If ug_intervalos.Rows.Count > 0 Then
            txt_idprogramacion.Text = ug_intervalos.DataSource.Rows(0)("PR_ID").ToString
        Else
            txt_idprogramacion.Text = ""
        End If

    End Sub

    Private Sub ubtn_Consultar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ubtn_Consultar.Click
        Call Cargar_Agenda(udte_fecha.Value, uce_Servicio.Value, uce_Medico.Value, ucbo_Turno.Value)
    End Sub

    Private Sub Tool_Salir_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_Salir.Click
        Me.Close()
    End Sub

    Private Sub Tool_Eliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_Eliminar.Click
        If ug_intervalos.ActiveRow.Cells(10).Value <> "" Then
            Dim obe As New BE.AdmisionBE.SG_AD_TB_CUENTA_CAB
            Dim obr As New BL.AdmisionBL.SG_AD_TB_CUENTA_CAB

            If Preguntar("Seguro de Eliminar?") Then
                obe.CC_ID = Val(ug_intervalos.ActiveRow.Cells(10).Value)
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
        Else
            MessageBox.Show("La cita no tiene cuenta.", ".:. Aviso .:.", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub uce_Medico_ValueChanged(sender As System.Object, e As System.EventArgs) Handles uce_Medico.ValueChanged
        Call Cargar_Agenda(udte_fecha.Value, uce_Servicio.Value, uce_Medico.Value, ucbo_Turno.Value)
    End Sub
End Class