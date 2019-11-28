Public Class AD_PR_ProgramacionEmerg

    Dim Bol_Nuevo As Boolean = False
    Dim Dias As String = ""

    Private Sub pKeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Me.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Return) Then
            SendKeys.Send("{TAB}")
            e.Handled = True
        End If
    End Sub

    Private Sub AD_PR_Programacion_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Call Formatear_Grilla_Selector(ug_Programacion)
        Call Inicializar_Estado_Botones_Tool(ToolS_Mantenimiento)
        Call MostrarTabs(0, utc_Program, 0)
        Call Cargar_Combos()
        Call CargarDatos()
        Dias = ""
        ug_Programacion.DisplayLayout.Appearance.FontData.Name = "Calibri"
        urb_Estado.CheckedIndex = 0
        Me.KeyPreview = True
    End Sub

    Public Sub CargarDatos()

        Dim programaBL As New BL.AdmisionBL.SG_AD_TB_PROGRAMA_CITA
        ug_Programacion.DataSource = programaBL.get_Programaciones_02(gInt_IdEmpresa)
        programaBL = Nothing
    End Sub

    Private Sub Cargar_Combos()

        Dim medicosBL As New BL.AdmisionBL.SG_AD_TB_MEDICO
        uce_Medico.DataSource = medicosBL.get_Medicos(gInt_IdEmpresa)
        uce_Medico.ValueMember = "ME_CODIGO"
        uce_Medico.DisplayMember = "NOMBRES"
        medicosBL = Nothing


        Dim consultorioBL As New BL.AdmisionBL.SG_AD_TB_CONSULTORIO_MEDICO
        uce_Consultorio.DataSource = consultorioBL.get_Consultorios(gInt_IdEmpresa)
        uce_Consultorio.ValueMember = "CM_ID"
        uce_Consultorio.DisplayMember = "CM_DESCRIPCION"
        consultorioBL = Nothing

        Dim servicioBL As New BL.AdmisionBL.SG_AD_TB_SERVICIO_MEDICO
        uce_Servicio.DataSource = servicioBL.get_Servicios(gInt_IdEmpresa)
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

    Private Sub Tool_Nuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_Nuevo.Click
        Call Cambiar_Estado_Botones_Tool(ToolS_Mantenimiento)
        Call MostrarTabs(1, utc_Program, 1)
        Call Limpiar_Controls_InGroupox(ugb_datos)
        Call Limpiar_Controls_InGroupox(ugb_Dias)
        urb_Estado.CheckedIndex = 0
        urb_Tipo.Value = 1
        ucbo_Turno.SelectedIndex = 0
        Dias = ""
        Bol_Nuevo = True
        une_cupos.Value = 0
        udte_fecha.Value = gDat_Fecha_Sis
        uce_Servicio.Value = ServicioEmergencia
        udte_fecha.Focus()
    End Sub

    Private Sub udte_fecha_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles udte_fecha.KeyDown, uce_Servicio.KeyDown, uce_Medico.KeyDown, uce_Consultorio.KeyDown
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send(vbTab)
        End If
    End Sub

    Private Sub Tool_Cancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_Cancelar.Click
        Call Cambiar_Estado_Botones_Tool(ToolS_Mantenimiento)
        Call MostrarTabs(0, utc_Program, 0)
    End Sub

    Private Sub Tool_Grabar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_Grabar.Click

        If udte_fecha.Value = Nothing Then
            Avisar("ingrese una fecha")
            udte_fecha.Focus()
            Exit Sub
        End If

        If uce_Medico.SelectedIndex = -1 Then
            Avisar("Seleccione un medico")
            uce_Medico.Focus()
            Exit Sub
        End If

        If uce_Consultorio.SelectedIndex = -1 Then
            Avisar("Seleccione un consultorio")
            uce_Consultorio.Focus()
            Exit Sub
        End If

        'If uce_Servicio.SelectedIndex = -1 Then
        '    Avisar("Seleccione un servicio")
        '    uce_Servicio.Focus()
        '    Exit Sub
        'End If

        'If ume_inicio.Value.ToString.Length <> 5 Then
        '    Avisar("ingrese la Hora de Inicio")
        '    ume_inicio.Focus()
        '    Exit Sub
        'End If

        'If ume_termino.Value.ToString.Length <> 5 Then
        '    Avisar("ingrese la Hora de termino")
        '    ume_termino.Focus()
        '    Exit Sub
        'End If

        'If ume_inicio.Value = Nothing Then
        '    Avisar("ingrese la Hora de Inicio")
        '    ume_inicio.Focus()
        '    Exit Sub
        'End If

        'If ume_termino.Value = Nothing Then
        '    Avisar("ingrese la Hora de termino")
        '    ume_termino.Focus()
        '    Exit Sub
        'End If

        Dim programacionBE As New BE.AdmisionBE.SG_AD_TB_PROGRAMA_CITA
        Dim programacionBL As New BL.AdmisionBL.SG_AD_TB_PROGRAMA_CITA
        If uck_Lunes.Checked = True Then Dias = "1"
        If uck_Martes.Checked = True Then Dias = Dias & IIf(Dias = "", "", ",") & "2"
        If uck_Miercoles.Checked = True Then Dias = Dias & IIf(Dias = "", "", ",") & "3"
        If uck_Jueves.Checked = True Then Dias = Dias & IIf(Dias = "", "", ",") & "4"
        If uck_Viernes.Checked = True Then Dias = Dias & IIf(Dias = "", "", ",") & "5"
        If uck_Sabado.Checked = True Then Dias = Dias & IIf(Dias = "", "", ",") & "6"
        If uck_Domingo.Checked = True Then Dias = Dias & IIf(Dias = "", "", ",") & "7"

        With programacionBE
            .PR_ID = IIf(Bol_Nuevo, 0, txt_idprogramacion.Text.Trim)
            .PR_MEDICO = uce_Medico.Value
            .PR_IDCONSULTORIO = uce_Consultorio.Value
            .PR_IDSERVICIO = uce_Servicio.Value
            .PR_TURNO_INI = Date.Now.TimeOfDay.ToString
            .PR_TURNO_FIN = Date.Now.TimeOfDay.ToString
            .PR_FECHA = CDate(udte_fecha.Value).ToShortDateString
            .PR_ESTADO = urb_Estado.Value
            .PR_CUPOS = une_cupos.Value
            .PR_PC = 0
            .PR_USUARIO = 0
            .PR_FECREG = Date.Now
            .PR_IDEMPRESA = gInt_IdEmpresa
            .PR_DIAS = Dias
            .PR_Tipo = urb_Tipo.Value
            .PR_Turno = ucbo_Turno.Value
        End With

        If Bol_Nuevo Then
            programacionBL.Insert(programacionBE)
        Else
            If programacionBL.Update(programacionBE) < 0 Then
                MessageBox.Show("La Programacion tiene registros relacionados solo se puede inactivar o activar", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If
        End If

        Call Avisar("Listo!")
        Call CargarDatos()

        programacionBL = Nothing
        programacionBE = Nothing

        Call Cambiar_Estado_Botones_Tool(ToolS_Mantenimiento)
        Call Tool_Nuevo_Click(sender, e)

    End Sub

    Private Sub Tool_Editar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_Editar.Click
        If ug_Programacion.Rows.Count = 0 Then Exit Sub
        If ug_Programacion.ActiveRow Is Nothing Then Exit Sub

        Bol_Nuevo = False
        Call Limpiar_Controls_InGroupox(ugb_Dias)

        Call Cambiar_Estado_Botones_Tool(ToolS_Mantenimiento)

        txt_idprogramacion.Text = ug_Programacion.ActiveRow.Cells("PR_ID").Value
        udte_fecha.Value = ug_Programacion.ActiveRow.Cells("PR_FECHA").Value
        uce_Consultorio.Value = ug_Programacion.ActiveRow.Cells("PR_IDCONSULTORIO").Value
        uce_Medico.Value = ug_Programacion.ActiveRow.Cells("PR_MEDICO").Value
        uce_Servicio.Value = ug_Programacion.ActiveRow.Cells("PR_IDSERVICIO").Value
        'ume_inicio.Value = ug_Programacion.ActiveRow.Cells("PR_TURNO_INI").Value
        'ume_termino.Value = ug_Programacion.ActiveRow.Cells("PR_TURNO_FIN").Value
        une_cupos.Value = ug_Programacion.ActiveRow.Cells("PR_CUPOS").Value
        urb_Tipo.Value = ug_Programacion.ActiveRow.Cells("PR_Tipo").Value
        ucbo_Turno.Value = ug_Programacion.ActiveRow.Cells(14).Value
        If ug_Programacion.ActiveRow.Cells("PR_ESTADO").Value = "ACTIVO" Then
            urb_Estado.CheckedIndex = 0
        Else
            urb_Estado.CheckedIndex = 1
        End If
        'Dias = ug_Programacion.ActiveRow.Cells("PR_DIAS").Value
        Dim DiasSepar() As String = ug_Programacion.ActiveRow.Cells("PR_DIAS").Value.Split(",")
        For i As Integer = 0 To DiasSepar.Count - 1
            If DiasSepar(i) = "1" Then uck_Lunes.Checked = True
            If DiasSepar(i) = "2" Then uck_Martes.Checked = True
            If DiasSepar(i) = "3" Then uck_Miercoles.Checked = True
            If DiasSepar(i) = "4" Then uck_Jueves.Checked = True
            If DiasSepar(i) = "5" Then uck_Viernes.Checked = True
            If DiasSepar(i) = "6" Then uck_Sabado.Checked = True
            If DiasSepar(i) = "7" Then uck_Domingo.Checked = True
        Next

        Call MostrarTabs(1, utc_Program, 1)
        udte_fecha.Focus()

    End Sub

    Private Sub Tool_Eliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_Eliminar.Click
        If ug_Programacion.Rows.Count = 0 Then Exit Sub
        If ug_Programacion.ActiveRow Is Nothing Then Exit Sub

        If Preguntar("Seguro de Eliminar?") Then

            Dim programacionBL As New BL.AdmisionBL.SG_AD_TB_PROGRAMA_CITA
            Dim programacionBE As New BE.AdmisionBE.SG_AD_TB_PROGRAMA_CITA

            programacionBE.PR_ID = ug_Programacion.ActiveRow.Cells("PR_ID").Value
            programacionBE.PR_IDEMPRESA = gInt_IdEmpresa
            programacionBL.Delete(programacionBE)

            programacionBE = Nothing
            programacionBL = Nothing

            Call Avisar("Listo!")
            Call CargarDatos()

        End If

    End Sub

    Private Sub Tool_Salir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_Salir.Click
        Me.Close()
    End Sub

    Private Sub ug_Programacion_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ug_Programacion.DoubleClick
        Tool_Editar_Click(sender, e)
    End Sub

    'Private Sub ume_termino_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs)

    '    If ume_inicio.Value.ToString.Length = 5 And ume_termino.Value.ToString.Length = 5 Then
    '        Dim medicoBL As New BL.AdmisionBL.SG_AD_TB_MEDICO
    '        Dim medicoBE As New BE.AdmisionBE.SG_AD_TB_MEDICO
    '        medicoBE.ME_CODIGO = uce_Medico.Value
    '        medicoBE.ME_IDEMPRESA = gInt_IdEmpresa
    '        Dim dt_medico As DataTable = medicoBL.get_Medicos_x_Id(medicoBE)

    '        Dim marcacion As String = ume_inicio.Text
    '        Dim indice As Integer = marcacion.IndexOf(":")
    '        Dim hora As Integer = marcacion.Substring(0, indice)
    '        Dim minuto As Integer = marcacion.Remove(0, indice + 1)
    '        Dim tiempo_Inicio As New TimeSpan(hora, minuto, 0)

    '        marcacion = ume_termino.Text
    '        hora = marcacion.Substring(0, indice)
    '        minuto = marcacion.Remove(0, indice + 1)

    '        Dim intervalos As Double = dt_medico.Rows(0)("ME_INTERVALO")
    '        Dim tiempo_Fin As New TimeSpan(hora, minuto, 0)
    '        Dim tiempo_tmp As New TimeSpan(0, intervalos, 0)
    '        Dim c As Integer = 0

    '        Do While tiempo_Inicio < tiempo_Fin
    '            c += 1
    '            tiempo_Inicio = tiempo_Inicio.Add(tiempo_tmp)
    '            ' tiempo_Inicio = tiempo_Inicio.Ad
    '        Loop

    '        une_cupos.Value = c

    '        dt_medico.Dispose()
    '        medicoBE = Nothing
    '        medicoBL = Nothing
    '    End If

    'End Sub

    Private Sub urb_Tipo_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles urb_Tipo.ValueChanged
        If urb_Tipo.Value = 1 Then
            ugb_Dias.Enabled = True
        Else
            Call Limpiar_Controls_InGroupox(ugb_Dias)
            ugb_Dias.Enabled = False
        End If
    End Sub

End Class