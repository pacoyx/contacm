Public Class CO_RP_DocPen_x_Vencer_Fechas

    Private Sub CO_RP_DocPen_x_Vencer_Fechas_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'cargamos el periodo
        Call CargarCombo_ConMeses(uce_Mes)
        une_Ayo.Value = gDat_Fecha_Sis.Year
        uce_Mes.SelectedIndex = -1

    End Sub

    Private Sub Tool_salir_Click(sender As System.Object, e As System.EventArgs) Handles Tool_salir.Click
        Me.Close()
    End Sub

    Private Sub Tool_Aceptar_Click(sender As System.Object, e As System.EventArgs) Handles Tool_Aceptar.Click
        Dim fechasBL As New BL.ContabilidadBL.SG_CO_TB_RANGO_FECHAS
        Dim fechasBE As New BE.ContabilidadBE.SG_CO_TB_RANGO_FECHAS
        fechasBE.RF_PC = Environment.MachineName
        fechasBE.RF_EMPRESA = gInt_IdEmpresa
        fechasBL.Delete(fechasBE)

        ug_Fechas.UpdateData()
        For i As Integer = 0 To ug_Fechas.Rows.Count - 1
            fechasBE = New BE.ContabilidadBE.SG_CO_TB_RANGO_FECHAS
            fechasBE.RF_ITEM = i + 1
            fechasBE.RF_FECHA1 = ug_Fechas.Rows(i).Cells("RF_FECHA1").Value
            fechasBE.RF_FECHA2 = ug_Fechas.Rows(i).Cells("RF_FECHA2").Value
            fechasBE.RF_EMPRESA = gInt_IdEmpresa
            fechasBE.RF_PC = Environment.MachineName
            fechasBL.Insert(fechasBE)
        Next


        fechasBE = Nothing
        fechasBL = Nothing

        Me.Close()
    End Sub

    Private Sub Cargar_Fechas_Manual()

        If uce_Mes.SelectedIndex = -1 Then Exit Sub

        Dim mes As Integer = uce_Mes.Value

        Dim fecha As String = "01/" & mes.ToString.PadLeft(2, "0") & "/" & gDat_Fecha_Sis.Year
        Dim primer_dia As Date = ObtenerPrimerDia(fecha)
        Dim ultimo_dia As Date = ObtenerUltimoDia(fecha)

        Dim fecha_aux As Date = primer_dia
        Dim fecha_aux_w As Date = Nothing

        Call LimpiaGrid(ug_Fechas, uds_Fechas)

        Do While fecha_aux <= ultimo_dia


            If Weekday(fecha_aux) = 1 Then
                If fecha_aux_w = Nothing Then
                    Insert_fila(fecha_aux, fecha_aux)
                    fecha_aux_w = Nothing
                Else
                    Insert_fila(fecha_aux_w, fecha_aux)
                    fecha_aux_w = Nothing
                End If
            Else
                If fecha_aux_w = Nothing Then
                    fecha_aux_w = fecha_aux
                End If

            End If

            If fecha_aux = ultimo_dia Then
                Insert_fila(fecha_aux_w, fecha_aux)
            End If

            fecha_aux = fecha_aux.AddDays(1)
        Loop

    End Sub

    Private Sub Insert_fila(fecha1_ As Date, fecha2_ As Date)
        ug_Fechas.DisplayLayout.Bands(0).AddNew()

        ug_Fechas.Rows(ug_Fechas.Rows.Count - 1).Cells("RF_ITEM").Value = ug_Fechas.Rows.Count
        ug_Fechas.Rows(ug_Fechas.Rows.Count - 1).Cells("RF_FECHA1").Value = fecha1_
        ug_Fechas.Rows(ug_Fechas.Rows.Count - 1).Cells("RF_FECHA2").Value = fecha2_
        ug_Fechas.UpdateData()

    End Sub

    Private Sub uce_Mes_ValueChanged(sender As System.Object, e As System.EventArgs) Handles uce_Mes.ValueChanged
        Call Cargar_Fechas_Manual()
    End Sub

    Private Sub ug_Fechas_AfterRowsDeleted(sender As Object, e As System.EventArgs) Handles ug_Fechas.AfterRowsDeleted
        For i As Integer = 0 To ug_Fechas.Rows.Count - 1
            ug_Fechas.Rows(i).Cells("RF_ITEM").Value = i + 1
        Next
        ug_Fechas.UpdateData()
    End Sub

    Private Sub ug_Fechas_BeforeRowsDeleted(sender As System.Object, e As Infragistics.Win.UltraWinGrid.BeforeRowsDeletedEventArgs) Handles ug_Fechas.BeforeRowsDeleted
        e.DisplayPromptMsg = False
    End Sub
End Class