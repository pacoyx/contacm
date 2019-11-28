Public Class AD_PR_Topico

    Private Sub pFormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Timer1.Enabled = False
    End Sub
    Private Sub AD_PR_TOPICO_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        udte_fecha.Value = gDat_Fecha_Sis
        Dim TurnoBL As New BL.AdmisionBL.SG_AD_TB_TURNO
        Dim obj As New DataTable
        TurnoBL.SEL01(gInt_IdEmpresa, obj)
        ucbo_Turno.DataSource = obj
        ucbo_Turno.ValueMember = "TU_ID"
        ucbo_Turno.DisplayMember = "TU_DESCRIPCION"
        TurnoBL = Nothing
        ucbo_Turno.Value = IIf(Now.Hour > 13, 2, 1)


        ubtn_a.Appearance.Image = My.Resources._16__Db_previous_
        ubtn_s.Appearance.Image = My.Resources._16__Db_next_

        Timer1.Enabled = True
        Timer1.Interval = 60000

    End Sub

    Private Sub ubtn_a_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ubtn_a.Click
        udte_fecha.Value = CDate(udte_fecha.Value).AddDays(-1)
        Call Cargar_Agenda(udte_fecha.Value, ucbo_Turno.Value)
    End Sub

    Private Sub ubtn_s_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ubtn_s.Click
        udte_fecha.Value = CDate(udte_fecha.Value).AddDays(1)
        Call Cargar_Agenda(udte_fecha.Value, ucbo_Turno.Value)
    End Sub
    Public Sub Cargar_Agenda(ByVal fecha As String, ByVal Turno As Integer)

        Dim CargarAtencionBL As New BL.AdmisionBL.SG_AD_TB_TOPICO
        Dim CargarAtencionBE As New BE.AdmisionBE.SG_AD_TB_TOPICO
        CargarAtencionBE.TO_FECHA = CDate(fecha).ToShortDateString
        CargarAtencionBE.TO_IDTURNO = Turno
        CargarAtencionBE.TO_IDEMPRESA = gInt_IdEmpresa
        ug_intervalos.DataSource = CargarAtencionBL.SEL01(CargarAtencionBE)
        CargarAtencionBL = Nothing
        CargarAtencionBE = Nothing
    End Sub

    Private Sub ubtn_Consultar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ubtn_Consultar.Click
        Call Cargar_Agenda(udte_fecha.Value, ucbo_Turno.Value)
    End Sub

    Private Sub Tool_Salir_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_Salir.Click
        Me.Close()
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Call Cargar_Agenda(udte_fecha.Value, ucbo_Turno.Value)
    End Sub

    Private Sub ug_intervalos_DoubleClickCell(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinGrid.DoubleClickCellEventArgs) Handles ug_intervalos.DoubleClickCell
        Call Tool_Editar_Click(sender, e)
    End Sub
    Private Sub ug_intervalos_InitializeRow(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinGrid.InitializeRowEventArgs) Handles ug_intervalos.InitializeRow
        'If uce_Servicio.Value = 7 Then
        '    If e.Row.Cells(9).Value = "Paso Consulta" Then
        '        e.Row.Appearance.BackColor = Color.FromArgb(192, 255, 192)
        '    ElseIf e.Row.Cells(9).Value = "" Then
        '        e.Row.Appearance.BackColor = Color.White
        '    ElseIf e.Row.Cells(9).Value = "Salio" Then
        '        e.Row.Appearance.BackColor = Color.FromArgb(170, 234, 244)
        '    Else
        '        e.Row.Appearance.BackColor = Color.LightYellow
        '    End If

        'Else
        '    If e.Row.Cells(9).Value = "Paso Consulta" Then
        '        e.Row.Appearance.BackColor = Color.FromArgb(154, 233, 180)
        '    ElseIf e.Row.Cells(9).Value = "" Then
        '        e.Row.Appearance.BackColor = Color.White
        '    ElseIf e.Row.Cells(9).Value = "Citado" Then
        '        e.Row.Appearance.BackColor = Color.FromArgb(170, 234, 244)
        '    Else
        '        e.Row.Appearance.BackColor = Color.LightYellow
        '    End If
        'End If
    End Sub

    Private Sub Inicio_Atencion()
        With AD_PR_AtencionTopico
            Call Limpiar_Controls_InGroupox(.ugb_Datos)

            .lNew = True

            .ubt_Agregar.Enabled = True
            .ubt_Quitar.Enabled = True

            '.txt_ruc_cliente.Enabled = True
            '.uce_tip_doc.Enabled = True

            Dim documentosBL As New BL.AdmisionBL.SG_AD_TB_TIP_DOC_PER
            .uce_tip_doc.DataSource = documentosBL.getTiposDocs(gInt_IdEmpresa)
            .uce_tip_doc.DisplayMember = "TD_ABREVIATURA"
            .uce_tip_doc.ValueMember = "TD_ID"
            documentosBL = Nothing
            .uce_tip_doc.SelectedIndex = 0

            Dim TurnoBL As New BL.AdmisionBL.SG_AD_TB_TURNO
            Dim obj As New DataTable
            TurnoBL.SEL01(gInt_IdEmpresa, obj)
            .ucbo_Turno.DataSource = obj
            .ucbo_Turno.ValueMember = "TU_ID"
            .ucbo_Turno.DisplayMember = "TU_DESCRIPCION"
            TurnoBL = Nothing

            Dim medicosBL As New BL.AdmisionBL.SG_AD_TB_MEDICO
            .uce_Medico.DataSource = medicosBL.get_Medicos(gInt_IdEmpresa)
            .uce_Medico.ValueMember = "ME_CODIGO"
            .uce_Medico.DisplayMember = "NOMBRES"
            medicosBL = Nothing

            .uds_detalle.Rows.Clear()
            .ug_detalle.DataSource = .uds_detalle

            .udte_fecha.Value = udte_fecha.Value
            .txt_Orden.Value = 0
            .ume_HoraLLegada.Value = Date.Now.TimeOfDay.ToString
            .txt_idCita_Topico.Text = 0
            .ucbo_Turno.Value = ucbo_Turno.Value
        End With
    End Sub

    Private Sub Tool_Atencion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_Atencion.Click
        'If ug_intervalos.Rows.Count = 0 Then Exit Sub
        'If udte_fecha.Value < Now.Date And ug_intervalos.ActiveRow.Cells(9).Value = "" Then Exit Sub
        'If ug_intervalos.ActiveRow.Cells(1).Value = 0 Then

        With AD_PR_AtencionTopico
            Inicio_Atencion()

            .ShowDialog()
            Call Cargar_Agenda(udte_fecha.Value, ucbo_Turno.Value)
        End With
        'End If
    End Sub

    Private Sub Tool_Eliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_Eliminar.Click

        If ug_intervalos.Rows.Count = 0 Then Exit Sub
        If ug_intervalos.ActiveRow.Cells(0).Value = 0 Then Exit Sub

        Dim TopicoBL As New BL.AdmisionBL.SG_AD_TB_TOPICO
        Dim TopicoBE As New BE.AdmisionBE.SG_AD_TB_TOPICO

        TopicoBE.TO_ID = ug_intervalos.ActiveRow.Cells("TO_ID").Value
        If Preguntar("Seguro de Eliminar el " & TopicoBE.TO_ID.ToString & "?") Then
            If TopicoBL.Delete(TopicoBE, String.Format("{0}-{1}", Environment.UserName, gStr_Usuario_Sis), Environment.MachineName) < 0 Then
                MessageBox.Show("La operación solicitada no ha podido ser realizada", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                Call Avisar("Listo!")
                Call Cargar_Agenda(udte_fecha.Value, ucbo_Turno.Value)
            End If
        End If

        TopicoBL = Nothing
        TopicoBE = Nothing

    End Sub

    Private Sub Tool_Imprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_Imprimir.Click

    End Sub

    Private Sub ucbo_Turno_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ucbo_Turno.ValueChanged
        Call Cargar_Agenda(udte_fecha.Value, ucbo_Turno.Value)
    End Sub

    Private Sub Tool_Editar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_Editar.Click
        If ug_intervalos.Rows.Count = 0 Then Exit Sub
        If ug_intervalos.ActiveRow.Cells(0).Value = 0 Then Exit Sub
        With AD_PR_AtencionTopico
            Inicio_Atencion()
            .lNew = False
            .txt_idCita_Topico.Text = ug_intervalos.ActiveRow.Cells(0).Value
            .txt_Orden.Value = ug_intervalos.ActiveRow.Cells(1).Value
            .ume_HoraLLegada.Value = ug_intervalos.ActiveRow.Cells(2).Value
            .txt_Observacion.Text = ug_intervalos.ActiveRow.Cells(9).Value

            If ug_intervalos.ActiveRow.Cells(10).Value.ToString <> "" Then .uce_Medico.Value = ug_intervalos.ActiveRow.Cells(10).Value.ToString
            Dim TopicoBL As New BL.AdmisionBL.SG_AD_TB_TOPICO
            Dim TopicoBE As New BE.AdmisionBE.SG_AD_TB_TOPICO

            '.ume_HoraLLegada.Value = Date.Now.TimeOfDay.ToString
            Dim HBL As New BL.AdmisionBL.SG_AD_TB_HISTO_CLINI
            Dim HBE As New BE.AdmisionBE.SG_AD_TB_HISTO_CLINI
            Dim drr_MOV As System.Data.SqlClient.SqlDataReader
            HBE.HC_NUM_HIST = Val(ug_intervalos.ActiveRow.Cells(3).Value.ToString)
            .txt_idHistoria.Text = Val(ug_intervalos.ActiveRow.Cells(3).Value.ToString)
            HBE.HC_IDEMPRESA = gInt_IdEmpresa
            drr_MOV = HBL.get_Historias_x_HIstoria(HBE)
            If drr_MOV.HasRows Then
                drr_MOV.Read()
                .txt_Des_Cliente.Text = drr_MOV("HC_APE_PAT").ToString & " " & drr_MOV("HC_APE_MAT").ToString & " " & drr_MOV("HC_APE_CASADA").ToString & " " & drr_MOV("HC_NOMBRE1").ToString
                .txt_ruc_cliente.Text = drr_MOV("HC_NDOC").ToString
                .uce_tip_doc.Value = drr_MOV("HC_TDOC").ToString
                .udte_fechaNac.Value = drr_MOV("HC_FNAC").ToString
            Else
                .txt_Des_Cliente.Text = ug_intervalos.ActiveRow.Cells(4).Value
                ' Avisar("No existe la Historia")
            End If
            HBE = Nothing
            HBL = Nothing
            
            TopicoBE.TO_ID = Val(.txt_idCita_Topico.Text)
            .ug_detalle.DataSource = TopicoBL.SEL02(TopicoBE)
            .ug_detalle.UpdateData()

            TopicoBE = Nothing
            TopicoBL = Nothing

            .ShowDialog()
            Call Cargar_Agenda(udte_fecha.Value, ucbo_Turno.Value)
        End With
    End Sub
End Class