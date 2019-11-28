Public Class HO_PR_ConsolidarHoras

    Private Sub HO_PR_ConsolidarHoras_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Call CargarCombo_ConMeses(uce_mes)
        txt_ayo.Value = gDat_Fecha_Sis.Year
        uce_mes.SelectedIndex = -1
    End Sub

    Private Sub Poner_Estado_Periodo()
        'aqui debemos mostrar el estado del mes:
        '0=pendiente
        '1=procesado
        '2=enviado a sistemas(por parte de 3er piso)

        Dim miFuncion As New BL.HospitalBL.Funciones
        Dim dt_estados As DataTable = miFuncion.get_Estado_por_Periodo(txt_ayo.Text, uce_mes.Value, gInt_IdEmpresa)

        'ugb_act_estado.Enabled = True

        If dt_estados.Rows.Count > 0 Then

            Select Case dt_estados.Rows(0)("PHC_ESTADO")
                Case 0
                    txt_estado.Text = "Periodo esta pendiente"
                Case 1
                    txt_estado.Text = "Periodo Procesado"
                    'ugb_act_estado.Enabled = False
                Case 2
                    txt_estado.Text = "Periodo enviado a sistemas"
                Case Else
            End Select


            If dt_estados.Rows(0)("PHC_OK_SISTEMAS") = 1 And dt_estados.Rows(0)("PHC_OK_CONTABILIDAD") = 1 Then
                utxt_estado2.Text = "Periodo aprobado por Sistemas y Contabilidad"
            End If

            If dt_estados.Rows(0)("PHC_OK_SISTEMAS") = 1 And dt_estados.Rows(0)("PHC_OK_CONTABILIDAD") = 0 Then
                utxt_estado2.Text = "Periodo aprobado por Sistemas"
            End If

            If dt_estados.Rows(0)("PHC_OK_SISTEMAS") = 0 And dt_estados.Rows(0)("PHC_OK_CONTABILIDAD") = 1 Then
                utxt_estado2.Text = "Periodo aprobado por Contabilidad"
            End If

            If dt_estados.Rows(0)("PHC_OK_SISTEMAS") = 0 And dt_estados.Rows(0)("PHC_OK_CONTABILIDAD") = 0 Then
                utxt_estado2.Text = "Periodo falta de aprobacion"
            End If

        End If


        dt_estados.Dispose()
        miFuncion = Nothing

    End Sub

    Private Sub Tool_salir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_salir.Click
        Me.Close()
    End Sub

    Private Sub Tool_Grabar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_Grabar.Click

        Dim cabeceraBE As New BE.HospitalBE.SG_PL_TB_PERSONAL_HORAS_CAB

        With cabeceraBE
            .PHC_ANHO = txt_ayo.Value
            .PHC_MES = uce_mes.Value
            .PHC_OK_SISTEMAS = 0
            .PHC_OK_CONTABILIDAD = 0
            .PHC_ESTADO = 0
            .PHC_IDEMPRESA = gInt_IdEmpresa
            .PHC_USUARIO = String.Format("{0}-{1}", Environment.UserName, gStr_Usuario_Sis)
            .PHC_TERMINAL = Environment.MachineName
            .PHC_FECREG = Date.Now.ToShortDateString
        End With



        Dim miFuncion As New BL.HospitalBL.Funciones
        Dim Lista_detalles As New List(Of BE.HospitalBE.SG_PL_TB_PERSONAL_HORAS_DET)
        Dim detalle As BE.HospitalBE.SG_PL_TB_PERSONAL_HORAS_DET

        Lista_detalles.Clear()

        For i As Integer = 0 To ug_registro.Rows.Count - 1

            If CDbl(ug_registro.Rows(i).Cells("CUNA_NORMAL").Value.ToString.Replace(":", ".")) > 0 Then
                detalle = New BE.HospitalBE.SG_PL_TB_PERSONAL_HORAS_DET
                With detalle
                    .PHD_OBS = String.Empty
                    .PHD_ANHO = txt_ayo.Value
                    .PHD_MES = uce_mes.Value
                    .PHD_IDEMPRESA = gInt_IdEmpresa
                    .PHD_USUARIO = String.Format("{0}-{1}", Environment.UserName, gStr_Usuario_Sis)
                    .PHD_TERMINAL = Environment.MachineName
                    .PHD_FECREG = Date.Now.ToShortDateString
                    .PHD_IDTIPO_TARIFA = 1
                    .PHD_VALOR_HORA = CDbl(ug_registro.Rows(i).Cells("CUNA_NORMAL").Value.ToString.Replace(":", "."))
                    .PHD_IDPERSONAL = ug_registro.Rows(i).Cells("PE_ID").Value
                    .PHD_HORA_F = 0
                    .PHD_HORA_E = 0
                    .PHD_HORA_E_DOBLE = 0
                    .PHD_TOT_HOR_SALA_BBS = CDbl(ug_registro.Rows(i).Cells("TOTAL").Value.ToString.Replace(":", "."))
                    .PHD_TOT_REFRI = ug_registro.Rows(i).Cells("REFRIGERIO").Value
                    Lista_detalles.Add(detalle)
                End With
            End If

            If ug_registro.Rows(i).Cells("INTERMEDIOS").Value.ToString.Replace(":", ".") > 0 Then
                detalle = New BE.HospitalBE.SG_PL_TB_PERSONAL_HORAS_DET
                With detalle
                    .PHD_OBS = String.Empty
                    .PHD_ANHO = txt_ayo.Value
                    .PHD_MES = uce_mes.Value
                    .PHD_IDEMPRESA = gInt_IdEmpresa
                    .PHD_USUARIO = String.Format("{0}-{1}", Environment.UserName, gStr_Usuario_Sis)
                    .PHD_TERMINAL = Environment.MachineName
                    .PHD_FECREG = Date.Now.ToShortDateString
                    .PHD_IDTIPO_TARIFA = 2
                    .PHD_VALOR_HORA = CDbl(ug_registro.Rows(i).Cells("INTERMEDIOS").Value.ToString.Replace(":", "."))
                    .PHD_IDPERSONAL = ug_registro.Rows(i).Cells("PE_ID").Value
                    .PHD_HORA_F = 0
                    .PHD_HORA_E = 0
                    .PHD_HORA_E_DOBLE = 0
                    .PHD_TOT_HOR_SALA_BBS = CDbl(ug_registro.Rows(i).Cells("TOTAL").Value.ToString.Replace(":", "."))
                    .PHD_TOT_REFRI = ug_registro.Rows(i).Cells("REFRIGERIO").Value
                    Lista_detalles.Add(detalle)
                End With
            End If

            If ug_registro.Rows(i).Cells("UCI").Value.ToString.Replace(":", ".") > 0 Then
                detalle = New BE.HospitalBE.SG_PL_TB_PERSONAL_HORAS_DET
                With detalle
                    .PHD_OBS = String.Empty
                    .PHD_ANHO = txt_ayo.Value
                    .PHD_MES = uce_mes.Value
                    .PHD_IDEMPRESA = gInt_IdEmpresa
                    .PHD_USUARIO = String.Format("{0}-{1}", Environment.UserName, gStr_Usuario_Sis)
                    .PHD_TERMINAL = Environment.MachineName
                    .PHD_FECREG = Date.Now.ToShortDateString
                    .PHD_IDTIPO_TARIFA = 3
                    .PHD_VALOR_HORA = CDbl(ug_registro.Rows(i).Cells("UCI").Value.ToString.Replace(":", "."))
                    .PHD_IDPERSONAL = ug_registro.Rows(i).Cells("PE_ID").Value
                    .PHD_HORA_F = 0
                    .PHD_HORA_E = 0
                    .PHD_HORA_E_DOBLE = 0
                    .PHD_TOT_HOR_SALA_BBS = CDbl(ug_registro.Rows(i).Cells("TOTAL").Value.ToString.Replace(":", "."))
                    .PHD_TOT_REFRI = ug_registro.Rows(i).Cells("REFRIGERIO").Value
                    Lista_detalles.Add(detalle)
                End With
            End If

            'este es para los de HOSPITALIZACION
            If ug_registro.Rows(i).Cells("FIJAS").Value.ToString.Replace(":", ".") > 0 Then
                detalle = New BE.HospitalBE.SG_PL_TB_PERSONAL_HORAS_DET
                With detalle
                    .PHD_OBS = String.Empty
                    .PHD_ANHO = txt_ayo.Value
                    .PHD_MES = uce_mes.Value
                    .PHD_IDEMPRESA = gInt_IdEmpresa
                    .PHD_USUARIO = String.Format("{0}-{1}", Environment.UserName, gStr_Usuario_Sis)
                    .PHD_TERMINAL = Environment.MachineName
                    .PHD_FECREG = Date.Now.ToShortDateString
                    .PHD_IDTIPO_TARIFA = 0
                    .PHD_VALOR_HORA = 0
                    .PHD_IDPERSONAL = ug_registro.Rows(i).Cells("PE_ID").Value
                    .PHD_HORA_F = CDbl(ug_registro.Rows(i).Cells("FIJAS").Value.ToString.Replace(":", "."))
                    .PHD_HORA_E = CDbl(ug_registro.Rows(i).Cells("EXTRAS").Value.ToString.Replace(":", "."))
                    .PHD_HORA_E_DOBLE = CDbl(ug_registro.Rows(i).Cells("EXTRAS_DOBLE").Value.ToString.Replace(":", "."))
                    .PHD_TOT_HOR_SALA_BBS = 0
                    .PHD_TOT_REFRI = ug_registro.Rows(i).Cells("REFRIGERIO").Value
                    Lista_detalles.Add(detalle)
                End With
            End If


            Try
                miFuncion.Insert_Horas_Personal_ET_Cabecera(cabeceraBE)
                miFuncion.Insert_Horas_Personal_ET(Lista_detalles, False)

            Catch ex As Exception
                MessageBox.Show(ex.Message, "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try


        Next

        MessageBox.Show("Listo!", "Sistema")

    End Sub

    Private Sub Cargar_Datos_Mes()

        If uce_mes.SelectedIndex = -1 Then Exit Sub
        Me.Cursor = Cursors.WaitCursor

        Dim miFuncion As New BL.HospitalBL.Funciones
        ug_registro.DataSource = miFuncion.get_Detalle_Mes_Mod(txt_ayo.Text, uce_mes.Value, gInt_IdEmpresa)
        miFuncion = Nothing

        Me.Cursor = Cursors.Default

    End Sub

    Private Sub uce_mes_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles uce_mes.ValueChanged
        uds_registro.Rows.Clear()
        ug_registro.DataSource = uds_registro
        Call Poner_Estado_Periodo()
    End Sub

    Private Sub ubtn_Mostrar_Data_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ubtn_Mostrar_Data.Click

        Tool_Grabar.Enabled = True

        'primero grabamos el periodo
        Dim miFuncion As New BL.HospitalBL.Funciones
        Dim cabeceraBE As New BE.HospitalBE.SG_PL_TB_PERSONAL_HORAS_CAB

        With cabeceraBE
            .PHC_ANHO = txt_ayo.Text
            .PHC_MES = uce_mes.Value
            .PHC_OK_SISTEMAS = 0
            .PHC_OK_CONTABILIDAD = 0
            .PHC_ESTADO = 0
            .PHC_IDEMPRESA = gInt_IdEmpresa
            .PHC_USUARIO = String.Format("{0}-{1}", Environment.UserName, gStr_Usuario_Sis)
            .PHC_TERMINAL = Environment.MachineName
            .PHC_FECREG = Date.Now.ToShortDateString
        End With

        Try
            miFuncion.Insert_Horas_Personal_ET_Cabecera(cabeceraBE)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

        End Try

        miFuncion = Nothing
        cabeceraBE = Nothing

        Call Cargar_Datos_Mes()

    End Sub


End Class