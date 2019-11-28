Public Class HO_PR_VistoSistemas

    Private Sub HO_PR_VistoSistemas_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Call CargarCombo_ConMeses(uce_mes)
        une_ayo.Value = gDat_Fecha_Sis.Year
    End Sub


    Private Sub Cargar_Datos()

        Me.Cursor = Cursors.WaitCursor

        Dim miFuncion As New BL.HospitalBL.Funciones
        Dim cabeceraBE As New BE.HospitalBE.SG_PL_TB_PERSONAL_HORAS_CAB
        cabeceraBE.PHC_ANHO = une_ayo.Value
        cabeceraBE.PHC_IDEMPRESA = gInt_IdEmpresa
        cabeceraBE.PHC_MES = uce_mes.Value

        ug_detalle.DataSource = miFuncion.get_Cabeceras_Para_Visto(une_ayo.Value, uce_mes.Value, gInt_IdEmpresa)
        ug_detalle.Refresh()

        miFuncion = Nothing

        Me.Cursor = Cursors.Default
    End Sub

    Private Sub Tool_salir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_salir.Click
        Me.Close()
    End Sub

    Private Sub ubtn_actualizar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ubtn_actualizar.Click
        Try

            If uos_visto.Value = 1 Then 'conforme

                For i As Integer = 0 To ug_detalle.Rows.Count - 1
                    If Not ug_detalle.Rows(i).Cells("OK").Value Then
                        MessageBox.Show("No se puede dar CONFORME mientras no esten con Visto bueno todos los registros.", "Alerta!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                        Exit Sub
                    End If
                Next
            End If


            'Actualizamos la cabecera por Año y Mes
            Dim miFuncion As New BL.HospitalBL.Funciones
            Dim cabeceraBE As New BE.HospitalBE.SG_PL_TB_PERSONAL_HORAS_CAB
            cabeceraBE.PHC_ANHO = une_ayo.Value
            cabeceraBE.PHC_IDEMPRESA = gInt_IdEmpresa
            cabeceraBE.PHC_MES = uce_mes.Value
            cabeceraBE.PHC_OK_SISTEMAS = uos_visto.Value
            miFuncion.Update_Visto_Bueno_Sistemas(cabeceraBE)

            Dim detalleBE As BE.HospitalBE.SG_PL_TB_PERSONAL_HORAS_DET
            For i As Integer = 0 To ug_detalle.Rows.Count - 1
                detalleBE = New BE.HospitalBE.SG_PL_TB_PERSONAL_HORAS_DET
                With detalleBE
                    .PHD_IDPERSONAL = ug_detalle.Rows(i).Cells("PE_ID").Value
                    .PHD_ANHO = une_ayo.Value
                    .PHD_MES = uce_mes.Value
                    .PHD_SIS_OK = IIf(ug_detalle.Rows(i).Cells("OK").Value, 1, 0)
                    .PHD_IDEMPRESA = gInt_IdEmpresa
                    .PHD_OBS = ug_detalle.Rows(i).Cells("OBS").Value.ToString
                End With
                miFuncion.Update_Visto_Sistema_x_Personal(detalleBE)
            Next


            MessageBox.Show("Listo!", "Estado de Registro Actualizado", MessageBoxButtons.OK, MessageBoxIcon.Information)
            miFuncion = Nothing

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub uce_mes_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles uce_mes.ValueChanged
        Call Cargar_Datos()
        Call Poner_Estado_Periodo()
    End Sub

    Private Sub Poner_Estado_Periodo()
        'aqui debemos mostrar el estado del mes:
        '0=pendiente
        '1=procesado
        '2=enviado a sistemas(por parte de 3er piso)

        Dim miFuncion As New BL.HospitalBL.Funciones
        Dim dt_estados As DataTable = miFuncion.get_Estado_por_Periodo(une_ayo.Value, uce_mes.Value, gInt_IdEmpresa)

        ugb_act_estado.Enabled = True

        If dt_estados.Rows.Count > 0 Then

            Select Case dt_estados.Rows(0)("PHC_ESTADO")
                Case 0
                    txt_estado.Text = "Periodo esta pendiente"
                Case 1
                    txt_estado.Text = "Periodo Procesado"
                    ugb_act_estado.Enabled = False
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

            uos_visto.Value = dt_estados.Rows(0)("PHC_OK_SISTEMAS")

        End If

        dt_estados.Dispose()
        miFuncion = Nothing

    End Sub

    Private Sub Tool_exportar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_exportar.Click

        If ug_detalle.Rows.Count = 0 Then Exit Sub

        Try
            export1.Export(ug_detalle, "Detalle.xls")
        Catch ex As Exception
        End Try

        Process.Start("Detalle.xls")
    End Sub

    Private Sub Tool_Actualizar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_Actualizar.Click
        Call Cargar_Datos()
        Call Poner_Estado_Periodo()
    End Sub

    Private Sub ug_detalle_InitializeRow(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.InitializeRowEventArgs) Handles ug_detalle.InitializeRow

        'e.Row.Cells("col_btn_obs").Value = "OBS"
        e.Row.Cells("col_btn_obs").Appearance.TextHAlign = Infragistics.Win.HAlign.Center
        e.Row.Cells("col_btn_obs").ButtonAppearance.ImageHAlign = Infragistics.Win.HAlign.Center

        If e.Row.Cells("OBS").Value.ToString <> "" Then
            'e.Row.Cells("col_btn_obs").Value = "OBS"
            e.Row.Cells("col_btn_obs").ButtonAppearance.Image = My.Resources.database
        Else
            'e.Row.Cells("col_btn_obs").Value = "*OBS"
            e.Row.Cells("col_btn_obs").ButtonAppearance.Image = My.Resources.edit
        End If

    End Sub

    Private Sub ug_detalle_ClickCellButton(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.CellEventArgs) Handles ug_detalle.ClickCellButton

        HO_PR_Observaciones.str_Observaciones = e.Cell.Row.Cells("OBS").Value.ToString
        HO_PR_Observaciones.ShowDialog()
        If HO_PR_Observaciones.bol_Aceptar Then e.Cell.Row.Cells("OBS").Value = HO_PR_Observaciones.str_Observaciones
        ug_detalle.UpdateData()

    End Sub

End Class