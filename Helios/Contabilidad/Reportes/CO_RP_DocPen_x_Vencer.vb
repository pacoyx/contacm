Public Class CO_RP_DocPen_x_Vencer

    Private Sub CO_RP_DocPen_x_Vencer_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        une_ayo.Value = gDat_Fecha_Sis.Year
        Call Formatear_Grilla_Selector(ug_data)
    End Sub

    Private Sub Tool_salir_Click(sender As System.Object, e As System.EventArgs) Handles Tool_salir.Click
        Me.Close()
    End Sub

    Private Sub Tool_imprimir_Click(sender As System.Object, e As System.EventArgs) Handles Tool_imprimir.Click

        Me.Cursor = Cursors.WaitCursor

        Dim str_cap_ant1 As String = ug_data.DisplayLayout.Bands(0).Columns("SEMANA1").Header.Caption
        Dim str_cap_ant2 As String = ug_data.DisplayLayout.Bands(0).Columns("SEMANA2").Header.Caption
        Dim str_cap_ant3 As String = ug_data.DisplayLayout.Bands(0).Columns("SEMANA3").Header.Caption
        Dim str_cap_ant4 As String = ug_data.DisplayLayout.Bands(0).Columns("SEMANA4").Header.Caption
        Dim str_cap_ant5 As String = ug_data.DisplayLayout.Bands(0).Columns("SEMANA5").Header.Caption

        If ug_data.DisplayLayout.Bands(0).Columns("SEMANA1").Hidden Then str_cap_ant1 = ""
        If ug_data.DisplayLayout.Bands(0).Columns("SEMANA2").Hidden Then str_cap_ant2 = ""
        If ug_data.DisplayLayout.Bands(0).Columns("SEMANA3").Hidden Then str_cap_ant3 = ""
        If ug_data.DisplayLayout.Bands(0).Columns("SEMANA4").Hidden Then str_cap_ant4 = ""
        If ug_data.DisplayLayout.Bands(0).Columns("SEMANA5").Hidden Then str_cap_ant5 = ""



        ug_data.DisplayLayout.Bands(0).Columns("SEMANA1").Header.Caption = "SEMANA1"
        ug_data.DisplayLayout.Bands(0).Columns("SEMANA2").Header.Caption = "SEMANA2"
        ug_data.DisplayLayout.Bands(0).Columns("SEMANA3").Header.Caption = "SEMANA3"
        ug_data.DisplayLayout.Bands(0).Columns("SEMANA4").Header.Caption = "SEMANA4"
        ug_data.DisplayLayout.Bands(0).Columns("SEMANA5").Header.Caption = "SEMANA5"

        Dim dt_tmp As DataTable = CType(ug_data.DataSource, DataTable)

        Dim str_fecha As String = ""

        Using crystalBL As New LR.ClsReporte
            crystalBL.Muestra_Reporte(gStr_RutaRep & "\SG_CO_41.rpt", dt_tmp, "", "pEmp;" & gStr_NomEmpresa, _
                                                                              "pSem1;" & str_cap_ant1, _
                                                                              "pSem2;" & str_cap_ant2, _
                                                                              "pSem3;" & str_cap_ant3, _
                                                                              "pSem4;" & str_cap_ant4, _
                                                                              "pSem5;" & str_cap_ant5)

        End Using

        ug_data.DisplayLayout.Bands(0).Columns("SEMANA1").Header.Caption = str_cap_ant1
        ug_data.DisplayLayout.Bands(0).Columns("SEMANA2").Header.Caption = str_cap_ant2
        ug_data.DisplayLayout.Bands(0).Columns("SEMANA3").Header.Caption = str_cap_ant3
        ug_data.DisplayLayout.Bands(0).Columns("SEMANA4").Header.Caption = str_cap_ant4
        ug_data.DisplayLayout.Bands(0).Columns("SEMANA5").Header.Caption = str_cap_ant5

        Me.Cursor = Cursors.Default

    End Sub

    Private Sub Tool_Procesar_Click(sender As System.Object, e As System.EventArgs) Handles Tool_Procesar.Click
        Call Procesar()
    End Sub

    Private Sub ubtn_est_rango_Click(sender As System.Object, e As System.EventArgs) Handles ubtn_est_rango.Click
        CO_RP_DocPen_x_Vencer_Fechas.ShowDialog()
    End Sub

    Private Sub uchk_Agrupado_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles uchk_Agrupado.CheckedChanged
        'Call Procesar()
    End Sub

    Private Sub Procesar()



        Dim ds_data As DataSet = Nothing
        Dim reportesBL As New BL.ContabilidadBL.SG_CO_Reportes_Registros
        Me.Cursor = Cursors.WaitCursor
        ds_data = reportesBL.get_DocPen_x_vencer(une_ayo.Value, Environment.MachineName, IIf(uchk_Agrupado.Checked, 1, 0), gInt_IdEmpresa)
        ug_data.DataSource = ds_data.Tables(0)
        Me.Cursor = Cursors.Default
        reportesBL = Nothing



        ug_data.DisplayLayout.Bands(0).Columns("SEMANA1").Header.Caption = "SEMANA1"
        ug_data.DisplayLayout.Bands(0).Columns("SEMANA2").Header.Caption = "SEMANA2"
        ug_data.DisplayLayout.Bands(0).Columns("SEMANA3").Header.Caption = "SEMANA3"
        ug_data.DisplayLayout.Bands(0).Columns("SEMANA4").Header.Caption = "SEMANA4"
        ug_data.DisplayLayout.Bands(0).Columns("SEMANA5").Header.Caption = "SEMANA5"

        ug_data.DisplayLayout.Bands(0).Columns("SEMANA1").Hidden = True
        ug_data.DisplayLayout.Bands(0).Columns("SEMANA2").Hidden = True
        ug_data.DisplayLayout.Bands(0).Columns("SEMANA3").Hidden = True
        ug_data.DisplayLayout.Bands(0).Columns("SEMANA4").Hidden = True
        ug_data.DisplayLayout.Bands(0).Columns("SEMANA5").Hidden = True

        'cambiamos los caption de las cabeceras
        Dim str_caption As String = String.Empty
        Dim fecha1 As String = String.Empty
        Dim fecha2 As String = String.Empty
        For i As Integer = 0 To ds_data.Tables(1).Rows.Count - 1
            fecha1 = CDate(ds_data.Tables(1).Rows(i)("RF_FECHA1")).Day.ToString.PadLeft(2, "0")
            fecha2 = CDate(ds_data.Tables(1).Rows(i)("RF_FECHA2")).Day & "/" & CDate(ds_data.Tables(1).Rows(i)("RF_FECHA2")).Month.ToString.PadLeft(2, "0")
            str_caption = fecha1 & " - " & fecha2

            Select Case i
                Case 0
                    ug_data.DisplayLayout.Bands(0).Columns("SEMANA1").Header.Caption = str_caption
                    ug_data.DisplayLayout.Bands(0).Columns("SEMANA1").Hidden = False
                Case 1
                    ug_data.DisplayLayout.Bands(0).Columns("SEMANA2").Header.Caption = str_caption
                    ug_data.DisplayLayout.Bands(0).Columns("SEMANA2").Hidden = False
                Case 2
                    ug_data.DisplayLayout.Bands(0).Columns("SEMANA3").Header.Caption = str_caption
                    ug_data.DisplayLayout.Bands(0).Columns("SEMANA3").Hidden = False
                Case 3
                    ug_data.DisplayLayout.Bands(0).Columns("SEMANA4").Header.Caption = str_caption
                    ug_data.DisplayLayout.Bands(0).Columns("SEMANA4").Hidden = False
                Case 4
                    ug_data.DisplayLayout.Bands(0).Columns("SEMANA5").Header.Caption = str_caption
                    ug_data.DisplayLayout.Bands(0).Columns("SEMANA5").Hidden = False
            End Select
        Next

        lbl_num_filas.Text = "Num. Filas : " & ug_data.Rows.Count

        ug_data.DisplayLayout.Bands(0).Groups("documento").Hidden = uchk_Agrupado.Checked
        'ug_data.DisplayLayout.Bands(0).Columns("TD").Hidden = uchk_Agrupado.Checked

    End Sub

    Private Sub ug_data_InitializeRow(sender As System.Object, e As Infragistics.Win.UltraWinGrid.InitializeRowEventArgs) Handles ug_data.InitializeRow
        If Val(e.Row.Cells("Semana1").Value.ToString) < 0 Then e.Row.Cells("Semana1").Appearance.ForeColor = Color.Red
        If Val(e.Row.Cells("Semana2").Value.ToString) < 0 Then e.Row.Cells("Semana2").Appearance.ForeColor = Color.Red
        If Val(e.Row.Cells("Semana3").Value.ToString) < 0 Then e.Row.Cells("Semana3").Appearance.ForeColor = Color.Red
        If Val(e.Row.Cells("Semana4").Value.ToString) < 0 Then e.Row.Cells("Semana4").Appearance.ForeColor = Color.Red
        If Val(e.Row.Cells("Semana5").Value.ToString) < 0 Then e.Row.Cells("Semana5").Appearance.ForeColor = Color.Red

    End Sub
End Class