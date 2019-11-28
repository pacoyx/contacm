Public Class PL_RP_HorasTrabajadas
    Dim dt_personal_planilla As DataTable

    Private Sub PL_RP_HorasTrabajadas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        une_Ayo.Value = gDat_Fecha_Sis.Year

    End Sub



    Private Sub Tool_Procesar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_Procesar.Click

        Dim marcacionesBL As New BL.PlanillaBL.Dicon
        Dim dt_personal_dicon As DataTable = marcacionesBL.get_Personal()
        Dim dt_Data_Marcacion As DataTable
        Dim dni_per As String = ""


        Dim fec_act As Date
        Dim fila As DataRow()
        Dim acumula_tiempo As New TimeSpan(0, 0, 0)
        Dim personalBL As New BL.PlanillaBL.SG_PL_TB_PERSONAL
        dt_personal_planilla = personalBL.get_Personal_x_Utilidades(une_Ayo.Value)
        personalBL = Nothing

        pb_personal.Minimum = 0
        pb_personal.Maximum = dt_personal_dicon.Rows.Count

        For i As Integer = 0 To dt_personal_dicon.Rows.Count - 1
            dni_per = dt_personal_dicon(i)("DNI")

            dt_Data_Marcacion = marcacionesBL.get_Marcaciones_x_empleado(dt_personal_dicon.Rows(i)("COD_PER"), une_Ayo.Value)
            fec_act = "01/01/" & une_Ayo.Value.ToString


            While fec_act <= "31/12/" & une_Ayo.Value.ToString
                fila = dt_Data_Marcacion.Select("fecha = '" & fec_act & "'")

                Dim fec_entrada As DateTime
                Dim fec_salida As DateTime
                Dim diferencia_en_min As Double
                Dim diferencia_en_horas As Double

                If fila.Length > 0 Then

                    If fila(0)("Estado") = "VA" Then
                        If fila(0)("Entradaoficial").ToString <> "" And fila(0)("salidaoficial").ToString <> "" Then
                            fec_entrada = fila(0)("Entradaoficial")
                            fec_salida = fila(0)("salidaoficial")
                            diferencia_en_min = DateDiff(DateInterval.Minute, fec_entrada, fec_salida)
                            diferencia_en_horas = (diferencia_en_min / 60)
                            acumula_tiempo = acumula_tiempo.Add(New TimeSpan(diferencia_en_horas, 0, 0))
                        End If
                    Else
                        If fila.Length > 1 Then
                            fec_entrada = fila(0)("HORA")
                            fec_salida = fila(1)("HORA")
                            diferencia_en_min = DateDiff(DateInterval.Minute, fec_entrada, fec_salida)
                            diferencia_en_horas = (diferencia_en_min / 60)
                            acumula_tiempo = acumula_tiempo.Add(New TimeSpan(diferencia_en_horas, 0, 0))
                        Else

                            If fila(0)("Entradaoficial").ToString <> "" And fila(0)("salidaoficial").ToString <> "" Then
                                fec_entrada = fila(0)("Entradaoficial")
                                fec_salida = fila(0)("salidaoficial")
                                diferencia_en_min = DateDiff(DateInterval.Minute, fec_entrada, fec_salida)
                                diferencia_en_horas = (diferencia_en_min / 60)
                                acumula_tiempo = acumula_tiempo.Add(New TimeSpan(diferencia_en_horas, 0, 0))
                            End If

                        End If
                    End If
                End If
                fec_act = fec_act.AddDays(1)
            End While


            If dt_personal_planilla.Select("DNI = '" & dni_per & "'").Length > 0 Then
                ug_personal.DisplayLayout.Bands(0).AddNew()
                ug_personal.Rows(ug_personal.Rows.Count - 1).Cells("personal").Value = dt_personal_dicon.Rows(i)("apellidos") & " " & dt_personal_dicon.Rows(i)("nombres")
                ug_personal.Rows(ug_personal.Rows.Count - 1).Cells("horas").Value = acumula_tiempo.TotalHours
                ug_personal.UpdateData()
            End If



            pb_personal.IncrementValue(1)
        Next

        pb_personal.Value = 0


    End Sub
End Class