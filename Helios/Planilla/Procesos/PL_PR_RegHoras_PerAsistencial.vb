Public Class PL_PR_RegHoras_PerAsistencial

    Private Sub Tool_salir_Click(sender As System.Object, e As System.EventArgs) Handles Tool_salir.Click
        Me.Close()
    End Sub

    Private Sub PL_PR_RegHoras_PerAsistencial_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Call CargarCombo_ConMeses(uce_mes)
        une_ayo.Value = gDat_Fecha_Sis.Year

        ubtn_actualizar.Appearance.Image = My.Resources._003

    End Sub

    Private Sub ubtn_actualizar_Click(sender As System.Object, e As System.EventArgs) Handles ubtn_actualizar.Click
        Try
            'Actualizamos la cabecera por Año y Mes
            Dim HorasAsistencialBL As New BL.PlanillaBL.SG_PL_TB_PERSONAL_HORAS_CAB
            Dim cabeceraBE As New BE.PlanillaBE.SG_PL_TB_PERSONAL_HORAS_CAB

            cabeceraBE.PHC_ANHO = une_ayo.Value
            cabeceraBE.PHC_IDEMPRESA = gInt_IdEmpresa
            cabeceraBE.PHC_MES = uce_mes.Value
            cabeceraBE.PHC_OK_CONTABILIDAD = uos_visto.Value

            HorasAsistencialBL.Update_Visto_Bueno_RR_HH(cabeceraBE)

            Avisar("Listo!")
            HorasAsistencialBL = Nothing

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub Cargar_Datos()

        Me.Cursor = Cursors.WaitCursor

        Dim miFuncion As New BL.PlanillaBL.SG_PL_TB_PERSONAL_HORAS_CAB
        Dim cabeceraBE As New BE.PlanillaBE.SG_PL_TB_PERSONAL_HORAS_CAB
        cabeceraBE.PHC_ANHO = une_ayo.Value
        cabeceraBE.PHC_IDEMPRESA = gInt_IdEmpresa
        cabeceraBE.PHC_MES = uce_mes.Value

        ug_detalle.DataSource = miFuncion.get_Cabeceras_Para_Visto(une_ayo.Value, uce_mes.Value, gInt_IdEmpresa)
        ug_detalle.Refresh()

        miFuncion = Nothing

        Call Formatear_Grilla_Selector(ug_detalle)
        Me.Cursor = Cursors.Default
    End Sub


    Private Sub uce_mes_ValueChanged(sender As System.Object, e As System.EventArgs) Handles uce_mes.ValueChanged
        Call Cargar_Datos()
        Call sumar_horas()
        Call Poner_Estado_Periodo()
    End Sub

    Private Sub Poner_Estado_Periodo()
        'aqui debemos mostrar el estado del mes:
        '0=pendiente
        '1=procesado
        '2=enviado a sistemas(por parte de 3er piso)

        Dim miFuncion As New BL.PlanillaBL.SG_PL_TB_PERSONAL_HORAS_CAB
        Dim dt_estados As DataTable = miFuncion.get_Estado_por_Periodo(une_ayo.Value, uce_mes.Value, gInt_IdEmpresa)


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

            uos_visto.Value = dt_estados.Rows(0)("PHC_OK_CONTABILIDAD")

        End If


        dt_estados.Dispose()
        miFuncion = Nothing

    End Sub

    Private Sub sumar_horas()
        'ug_detalle.UpdateData()
        'Dim cont As Double = 0
        'For i As Integer = 0 To ug_detalle.Rows.Count - 1
        '    If ug_detalle.Rows(i).Cells("TOTAL").Value.ToString = "" Then
        '        cont = cont + Val(0)
        '    Else
        '        cont = cont + ug_detalle.Rows(i).Cells("TOTAL").Value
        '    End If

        'Next
        'ume_total.Value = Math.Round(cont, 2)
    End Sub

    Private Sub Tool_Reporte_Click(sender As System.Object, e As System.EventArgs) Handles Tool_Reporte.Click
        If uce_mes.SelectedIndex = -1 Then
            Avisar("Seleccione un mes por favor")
            uce_mes.Focus()
            Exit Sub
        End If

        Me.Cursor = Cursors.WaitCursor

        Dim dt_reporte As DataTable = CType(ug_detalle.DataSource, DataTable)

        Using crystalBL As New LR.ClsReporte
            crystalBL.Muestra_Reporte(gStr_RutaRep & "\SG_PL_23.rpt", dt_reporte, "", "pEmp;" & gStr_NomEmpresa, "pPeriodo;" & une_ayo.Value.ToString & " - " & uce_mes.Text.ToUpper)
        End Using

        Me.Cursor = Cursors.Default
    End Sub
End Class