Imports Infragistics.Win.UltraWinGrid

Public Class PL_RP_Tardanzas

    Private Sub PL_RP_Tardanzas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        une_Ayo.Value = gDat_Fecha_Sis.Year

        Call Cargar_TipoPersonal()
        Call CargarCombo_ConMeses(uce_Mes)
        'Call Formatear_Grilla_Selector(ug_exporta)
        uce_TipoPersonal.SelectedIndex = 0
        'ug_exporta.DisplayLayout.Bands(0).Columns("HORA_L").CellActivation = Infragistics.Win.UltraWinGrid.Activation.AllowEdit

    End Sub


    Private Sub Verificar_Estado_Mes()

        Dim AdmMesBL As New BL.ContabilidadBL.SG_CO_TB_ADMMES
        Dim AdmMesBE As New BE.ContabilidadBE.SG_CO_TB_ADMMES

        With AdmMesBE
            .AM_ANHO = une_Ayo.Value
            .AM_MES = uce_Mes.Value
            .AM_IDEMPRESA = New BE.ContabilidadBE.SG_CO_TB_EMPRESA With {.EM_ID = gInt_IdEmpresa}
            .AM_MODULO = 3
        End With

        ug_exporta.DisplayLayout.Bands(0).Columns("HORA_L").CellActivation = Activation.AllowEdit

        If AdmMesBL.Esta_Cerrado_Mes(AdmMesBE) Then
            ug_exporta.DisplayLayout.Bands(0).Columns("HORA_L").CellActivation = Activation.NoEdit
            AdmMesBL = Nothing
            AdmMesBE = Nothing
        End If

        AdmMesBL = Nothing
        AdmMesBE = Nothing

    End Sub


    Private Sub Cargar_TipoPersonal()
        Dim tipoPersonalBL As New BL.PlanillaBL.SG_PL_TB_TIPO_PERSONAL
        uce_TipoPersonal.DataSource = tipoPersonalBL.getTipos()
        uce_TipoPersonal.ValueMember = "TP_ID"
        uce_TipoPersonal.DisplayMember = "TP_DESCRIPCION"
        tipoPersonalBL = Nothing
    End Sub

    Private Sub Tool_imprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_imprimir.Click

        If udte_fec_ini.Value Is Nothing Then
            Avisar("Seleccione una fecha valida")
            udte_fec_ini.Focus()
            Exit Sub
        End If

        If udte_fec_fin.Value Is Nothing Then
            Avisar("Seleccione una fecha valida")
            udte_fec_fin.Focus()
            Exit Sub
        End If


        Me.Cursor = Cursors.WaitCursor

        Dim marcaBL As New BL.PlanillaBL.Dicon
        Dim personalBL As New BL.PlanillaBL.SG_PL_TB_PERSONAL
        Dim personalBE As New BE.PlanillaBE.SG_PL_TB_PERSONAL
        Dim dt_personal As DataTable = Nothing



        personalBE.PE_ID_EMPRESA = gInt_IdEmpresa
        personalBE.PE_ID_TIPO_PER = uce_TipoPersonal.Value
        personalBE.PE_AFECTO_QUINTA = 0 '(0= no solo activos)
        personalBE.PE_ID = 0

        'If uchk_todos.Checked Then 'Todos
        dt_personal = personalBL.getPersonal_x_Tipo_Tardanzas(personalBE)
        'Else
        '    dt_personal = personalBL.getPersonal_x_Tipo_x_IdPersonal_Tardanza(personalBE)
        'End If


        Dim dt_reporte As DataTable = Nothing
        Dim dt_tmp As DataTable = Nothing

        upb_estado.Value = 0
        upb_estado.Minimum = 0
        upb_estado.Maximum = dt_personal.Rows.Count
        upb_estado.Visible = True



        'solo para este caso abro la conexion en el formulario y la envio como parametro a la funcion
        'para poder controlar el progressBar

        Dim cnDicon As New SqlClient.SqlConnection("server=serverigf\sqlexpress;user=dicon;pwd=webdicon;Initial catalog=BD_CLINMIRA;Pooling=true; Min Pool Size=5; Max Pool Size=10; Pooling = True")
        cnDicon.Open()


        Dim dat_fecha_ini_ As Date = CDate(udte_fec_ini.Value)
        Dim dat_fecha_fin_ As Date = CDate(udte_fec_fin.Value)


        For i As Integer = 0 To dt_personal.Rows.Count - 1
            If i = 0 Then
                dt_reporte = marcaBL.get_Tardanzas_Reporte(cnDicon, une_Ayo.Value, uce_Mes.Value, dt_personal.Rows(i)("PE_CONSIDERA_FT"), dt_personal.Rows(i)("PE_NUM_DOC_PER"), dat_fecha_ini_, dat_fecha_fin_)
                dt_reporte.Columns.Add("CODPER", Type.GetType("System.String"))
                dt_reporte.Columns.Add("NOMBRES", Type.GetType("System.String"))
                dt_reporte.Columns.Add("APELLIDOS", Type.GetType("System.String"))


                dt_reporte.Rows(0)("CODPER") = dt_personal.Rows(i)("PE_CODIGO")
                dt_reporte.Rows(0)("NOMBRES") = dt_personal.Rows(i)("NOMBRES")
                dt_reporte.Rows(0)("APELLIDOS") = dt_personal.Rows(i)("PE_APE_PAT") & " " & dt_personal.Rows(i)("PE_APE_MAT")



            Else
                dt_tmp = marcaBL.get_Tardanzas_Reporte(cnDicon, une_Ayo.Value, uce_Mes.Value, dt_personal.Rows(i)("PE_CONSIDERA_FT"), dt_personal.Rows(i)("PE_NUM_DOC_PER"), dat_fecha_ini_, dat_fecha_fin_)
                If dt_tmp.Rows.Count > 0 Then
                    Dim fila As DataRow
                    fila = dt_reporte.NewRow

                    fila("CODPER") = dt_personal.Rows(i)("PE_CODIGO")
                    fila("NOMBRES") = dt_personal.Rows(i)("NOMBRES")
                    fila("APELLIDOS") = dt_personal.Rows(i)("PE_APE_PAT") & " " & dt_personal.Rows(i)("PE_APE_MAT")

                    '2 = trabajdor de confianza y no se debe procesar las horas de tardanza
                    If dt_personal.Rows(i)("PE_ID_SITUACION_ESPECIAL") <> 2 Then
                        fila("TOTAL_HRAS_TARDANZA") = dt_tmp.Rows(0)("TOTAL_HRAS_TARDANZA")
                        fila("TOTAL_MENOS45_MIN") = dt_tmp.Rows(0)("TOTAL_MENOS45_MIN")
                        fila("HORAS") = dt_tmp.Rows(0)("HORAS")
                        fila("MINUTOS") = dt_tmp.Rows(0)("MINUTOS")
                        fila("HORAS_TARDE") = dt_tmp.Rows(0)("HORAS_TARDE")
                        fila("MINUTOS_TARDE") = dt_tmp.Rows(0)("MINUTOS_TARDE")
                    End If
                    dt_reporte.Rows.Add(fila)
                End If
            End If
            upb_estado.IncrementValue(1)
        Next

        upb_estado.Value = 0
        upb_estado.Visible = False

        cnDicon.Close()

        marcaBL = Nothing


        'levantamos el reporte

        Dim str_rango_fechas As String = "Del  " & udte_fec_ini.Value & "  al  " & udte_fec_fin.Value

        Using crystalBL As New LR.ClsReporte

            crystalBL.Muestra_Reporte(gStr_RutaRep & "\SG_PL_03.rpt", dt_reporte, "", "pEmpresa;" & gStr_NomEmpresa, "pPeriodo;" & une_Ayo.Value & " - " & uce_Mes.Text.ToUpper, "pRangoFecha;" & str_rango_fechas)

        End Using

        Me.Cursor = Cursors.Default

    End Sub

    Private Sub Tool_Salir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_Salir.Click
        Me.Close()
    End Sub

    Private Sub uce_Mes_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles uce_Mes.ValueChanged
        Dim fecha_tmp As Date = "01/" & uce_Mes.Value.ToString.PadLeft(2, "0") & "/" & une_Ayo.Value.ToString
        udte_fec_ini.Value = "25/" & fecha_tmp.AddMonths(-1).Month.ToString.PadLeft(2, "0") & "/" & fecha_tmp.AddMonths(-1).Year.ToString  'ObtenerPrimerDia(fecha_tmp)
        udte_fec_fin.Value = "24/" & fecha_tmp.Month.ToString.PadLeft(2, "0") & "/" & fecha_tmp.Year.ToString 'ObtenerUltimoDia(fecha_tmp)

        Call Verificar_Estado_Mes()

    End Sub

    Private Sub Procesar_Individual2()

        If udte_fec_ini.Value Is Nothing Then
            Avisar("Seleccione una fecha valida")
            udte_fec_ini.Focus()
            Exit Sub
        End If

        If udte_fec_fin.Value Is Nothing Then
            Avisar("Seleccione una fecha valida")
            udte_fec_fin.Focus()
            Exit Sub
        End If

        Me.Cursor = Cursors.WaitCursor

        Dim marcaBL As New BL.PlanillaBL.Dicon
        Dim personalBL As New BL.PlanillaBL.SG_PL_TB_PERSONAL
        Dim personalBE As New BE.PlanillaBE.SG_PL_TB_PERSONAL
        Dim dt_personal As DataTable = Nothing
        Dim hora_tardanza_mod As String = String.Empty


        personalBE.PE_ID_EMPRESA = gInt_IdEmpresa
        personalBE.PE_ID_TIPO_PER = uce_TipoPersonal.Value
        personalBE.PE_AFECTO_QUINTA = 0 '(0= no solo activos)
        personalBE.PE_ID = 0

        ' If uchk_todos.Checked Then 'Todos
        dt_personal = personalBL.getPersonal_x_Tipo_Tardanzas(personalBE)


        Dim dt_reporte As New DataTable
        Dim dt_marcaciones As DataTable = Nothing

        upb_estado.Value = 0
        upb_estado.Minimum = 0
        upb_estado.Maximum = dt_personal.Rows.Count
        upb_estado.Visible = True


        'agregamos los campos a la tabla 
        dt_reporte.Columns.Add("CODPER", Type.GetType("System.String"))
        dt_reporte.Columns.Add("NOMBRES", Type.GetType("System.String"))
        dt_reporte.Columns.Add("APELLIDOS", Type.GetType("System.String"))
        dt_reporte.Columns.Add("TOTAL_HRAS_TARDANZA", Type.GetType("System.DateTime"))
        dt_reporte.Columns.Add("HORAS_TARDE", Type.GetType("System.DateTime"))
        dt_reporte.Columns.Add("MINUTOS_TARDE", Type.GetType("System.DateTime"))
        dt_reporte.Columns.Add("TOTAL_MENOS45_MIN", Type.GetType("System.DateTime"))
        dt_reporte.Columns.Add("HORAS", Type.GetType("System.Double"))
        dt_reporte.Columns.Add("MINUTOS", Type.GetType("System.Double"))

        dt_reporte.Columns.Add("DNI", Type.GetType("System.String"))
        dt_reporte.Columns.Add("ES_FT", Type.GetType("System.String"))
        dt_reporte.Columns.Add("HORA_L", Type.GetType("System.DateTime"))

      




        'solo para este caso abro la conexion en el formulario y la envio como parametro a la funcion
        'para poder controlar el progressBar

        Dim cnDicon As New SqlClient.SqlConnection("server=192.168.1.111;user=sa;pwd=Igf348;Initial catalog=BD_CLINMIRA;Pooling=true; Min Pool Size=5; Max Pool Size=10; Pooling = True")
        cnDicon.Open()

        Dim dat_fecha_ini_ As Date = CDate(udte_fec_ini.Value)
        Dim dat_fecha_fin_ As Date = CDate(udte_fec_fin.Value)

        Call LimpiaGrid(ug_exporta, uds_exportar)

        For i As Integer = 0 To dt_personal.Rows.Count - 1
            Dim tardanza As TimeSpan = Nothing

            dt_marcaciones = marcaBL.get_Tardanzas_Detalle_cnx(cnDicon, dt_personal.Rows(i)("PE_NUM_DOC_PER"), dat_fecha_ini_, dat_fecha_fin_)
            For j As Integer = 0 To dt_marcaciones.Rows.Count - 1
                Dim HMS As String()
                HMS = dt_marcaciones.Rows(j)("TARDANZA").ToString.Split(":")

                If dt_personal.Rows(i)("PE_CONSIDERA_FT") = 1 Then
                    If dt_marcaciones.Rows(j)("ESTADO") <> "FT" Then
                        tardanza = tardanza.Add(New TimeSpan(CInt(HMS(0)), CInt(HMS(1)), CInt(HMS(2))))
                    End If
                Else
                    tardanza = tardanza.Add(New TimeSpan(CInt(HMS(0)), CInt(HMS(1)), CInt(HMS(2))))
                End If

            Next

            Dim tiempo_cero As New TimeSpan(0, 0, 0)

            'aqui grabamos la fila con el total de la tardanza
            '2 = trabajdor de confianza y no se debe procesar las horas de tardanza
            If dt_personal.Rows(i)("PE_ID_SITUACION_ESPECIAL") <> 2 And tardanza.TotalMinutes > 0 Then

                Dim tiempo_tolerancia As New TimeSpan(0, 45, 0)

                ug_exporta.DisplayLayout.Bands(0).AddNew()
                ug_exporta.Rows(ug_exporta.Rows.Count - 1).Cells("CODPER").Value = dt_personal.Rows(i)("PE_CODIGO")
                ug_exporta.Rows(ug_exporta.Rows.Count - 1).Cells("NOMBRES").Value = dt_personal.Rows(i)("NOMBRES")
                ug_exporta.Rows(ug_exporta.Rows.Count - 1).Cells("APELLIDOS").Value = dt_personal.Rows(i)("PE_APE_PAT") & " " & dt_personal.Rows(i)("PE_APE_MAT")
                ug_exporta.Rows(ug_exporta.Rows.Count - 1).Cells("DNI").Value = dt_personal.Rows(i)("PE_NUM_DOC_PER")
                ug_exporta.Rows(ug_exporta.Rows.Count - 1).Cells("ES_FT").Value = dt_personal.Rows(i)("PE_CONSIDERA_FT")

                ug_exporta.Rows(ug_exporta.Rows.Count - 1).Cells("TOTAL_HRAS_TARDANZA").Value = New DateTime(1, 1, 1, tardanza.Hours, tardanza.Minutes, tardanza.Seconds)
                ug_exporta.Rows(ug_exporta.Rows.Count - 1).Cells("HORAS_TARDE").Value = tardanza.Hours
                ug_exporta.Rows(ug_exporta.Rows.Count - 1).Cells("MINUTOS_TARDE").Value = tardanza.Minutes

                tardanza = tardanza.Subtract(tiempo_tolerancia)

                If tardanza < tiempo_cero Then
                    ug_exporta.Rows(ug_exporta.Rows.Count - 1).Cells("TOTAL_MENOS45_MIN").Value = New DateTime(1, 1, 1, 0, 0, 0)
                    ug_exporta.Rows(ug_exporta.Rows.Count - 1).Cells("HORAS").Value = 0
                    ug_exporta.Rows(ug_exporta.Rows.Count - 1).Cells("MINUTOS").Value = 0
                Else
                    ug_exporta.Rows(ug_exporta.Rows.Count - 1).Cells("TOTAL_MENOS45_MIN").Value = New DateTime(1, 1, 1, tardanza.Hours, tardanza.Minutes, tardanza.Seconds)
                    ug_exporta.Rows(ug_exporta.Rows.Count - 1).Cells("HORAS").Value = tardanza.Hours
                    ug_exporta.Rows(ug_exporta.Rows.Count - 1).Cells("MINUTOS").Value = tardanza.Minutes
                End If

                



                hora_tardanza_mod = get_HorasTardanza_Modifi(dt_personal.Rows(i)("PE_ID"))

                If hora_tardanza_mod = String.Empty Then
                    ug_exporta.Rows(ug_exporta.Rows.Count - 1).Cells("HORA_L").Value = DBNull.Value
                Else
                    ug_exporta.Rows(ug_exporta.Rows.Count - 1).Cells("HORA_L").Value = hora_tardanza_mod
                End If


            End If
            upb_estado.IncrementValue(1)
        Next

        dt_marcaciones.Dispose()

        upb_estado.Value = 0
        upb_estado.Visible = False

        cnDicon.Close()
        marcaBL = Nothing

        Me.Cursor = Cursors.Default

    End Sub

    Private Sub Procesar_Original()

        If udte_fec_ini.Value Is Nothing Then
            Avisar("Seleccione una fecha valida")
            udte_fec_ini.Focus()
            Exit Sub
        End If

        If udte_fec_fin.Value Is Nothing Then
            Avisar("Seleccione una fecha valida")
            udte_fec_fin.Focus()
            Exit Sub
        End If

        Me.Cursor = Cursors.WaitCursor

        Dim marcaBL As New BL.PlanillaBL.Dicon
        Dim personalBL As New BL.PlanillaBL.SG_PL_TB_PERSONAL
        Dim personalBE As New BE.PlanillaBE.SG_PL_TB_PERSONAL
        Dim dt_personal As DataTable = Nothing




        personalBE.PE_ID_EMPRESA = gInt_IdEmpresa
        personalBE.PE_ID_TIPO_PER = uce_TipoPersonal.Value
        personalBE.PE_AFECTO_QUINTA = 0 '(0= no solo activos)
        personalBE.PE_ID = 0

        ' If uchk_todos.Checked Then 'Todos
        dt_personal = personalBL.getPersonal_x_Tipo_Tardanzas(personalBE)
        ' Else
        'dt_personal = personalBL.getPersonal_x_Tipo_x_IdPersonal_Tardanza(personalBE)
        'End If


        Dim dt_reporte As DataTable = Nothing
        Dim dt_tmp As DataTable = Nothing

        upb_estado.Value = 0
        upb_estado.Minimum = 0
        upb_estado.Maximum = dt_personal.Rows.Count
        upb_estado.Visible = True

        'solo para este caso abro la conexion en el formulario y la envio como parametro a la funcion
        'para poder controlar el progressBar

        Dim cnDicon As New SqlClient.SqlConnection("server=serverigf\sqlexpress;user=dicon;pwd=webdicon;Initial catalog=BD_CLINMIRA;Pooling=true; Min Pool Size=5; Max Pool Size=10; Pooling = True")
        cnDicon.Open()


        Dim dat_fecha_ini_ As Date = CDate(udte_fec_ini.Value)
        Dim dat_fecha_fin_ As Date = CDate(udte_fec_fin.Value)
        Dim hora_tardanza_mod As String = String.Empty

        For i As Integer = 0 To dt_personal.Rows.Count - 1
            If i = 0 Then
                dt_reporte = marcaBL.get_Tardanzas_Reporte(cnDicon, une_Ayo.Value, uce_Mes.Value, dt_personal.Rows(i)("PE_CONSIDERA_FT"), dt_personal.Rows(i)("PE_NUM_DOC_PER"), dat_fecha_ini_, dat_fecha_fin_)
                dt_reporte.Columns.Add("CODPER", Type.GetType("System.String"))
                dt_reporte.Columns.Add("NOMBRES", Type.GetType("System.String"))
                dt_reporte.Columns.Add("APELLIDOS", Type.GetType("System.String"))
                dt_reporte.Columns.Add("DNI", Type.GetType("System.String"))
                dt_reporte.Columns.Add("ES_FT", Type.GetType("System.String"))
                dt_reporte.Columns.Add("HORA_L", Type.GetType("System.DateTime"))


                dt_reporte.Rows(0)("CODPER") = dt_personal.Rows(i)("PE_CODIGO")
                dt_reporte.Rows(0)("NOMBRES") = dt_personal.Rows(i)("NOMBRES")
                dt_reporte.Rows(0)("APELLIDOS") = dt_personal.Rows(i)("PE_APE_PAT") & " " & dt_personal.Rows(i)("PE_APE_MAT")
                dt_reporte.Rows(0)("DNI") = dt_personal.Rows(i)("PE_NUM_DOC_PER")
                dt_reporte.Rows(0)("ES_FT") = dt_personal.Rows(i)("PE_CONSIDERA_FT")
                dt_reporte.Rows(0)("HORA_L") = DBNull.Value

                dt_tmp = marcaBL.get_Tardanzas_Reporte(cnDicon, une_Ayo.Value, uce_Mes.Value, dt_personal.Rows(i)("PE_CONSIDERA_FT"), dt_personal.Rows(i)("PE_NUM_DOC_PER"), dat_fecha_ini_, dat_fecha_fin_)

                '2 = trabajdor de confianza y no se debe procesar las horas de tardanza
                If dt_personal.Rows(i)("PE_ID_SITUACION_ESPECIAL") <> 2 Then
                    dt_reporte.Rows(0)("TOTAL_HRAS_TARDANZA") = dt_tmp.Rows(0)("TOTAL_HRAS_TARDANZA")
                    dt_reporte.Rows(0)("TOTAL_MENOS45_MIN") = dt_tmp.Rows(0)("TOTAL_MENOS45_MIN")
                    dt_reporte.Rows(0)("HORAS") = dt_tmp.Rows(0)("HORAS")
                    dt_reporte.Rows(0)("MINUTOS") = dt_tmp.Rows(0)("MINUTOS")
                    dt_reporte.Rows(0)("HORAS_TARDE") = dt_tmp.Rows(0)("HORAS_TARDE")
                    dt_reporte.Rows(0)("MINUTOS_TARDE") = dt_tmp.Rows(0)("MINUTOS_TARDE")

                    hora_tardanza_mod = get_HorasTardanza_Modifi(dt_personal.Rows(i)("PE_ID"))
                    If hora_tardanza_mod = String.Empty Then
                        dt_reporte.Rows(0)("HORA_L") = DBNull.Value
                    Else
                        dt_reporte.Rows(0)("HORA_L") = hora_tardanza_mod
                    End If



                    If dt_tmp.Rows(0)("HORAS_TARDE").ToString <> "" Then
                        If dt_tmp.Rows(0)("HORAS_TARDE") = 0 Then
                            If (dt_tmp.Rows(0)("MINUTOS_TARDE") - 45) < 0 Then
                                dt_reporte.Rows(0)("TOTAL_MENOS45_MIN") = Date.Now.ToString("00:00")
                                dt_reporte.Rows(0)("MINUTOS") = 0
                                dt_reporte.Rows(0)("HORAS") = 0
                            End If
                        End If
                    End If
                End If


            Else
                dt_tmp = marcaBL.get_Tardanzas_Reporte(cnDicon, une_Ayo.Value, uce_Mes.Value, dt_personal.Rows(i)("PE_CONSIDERA_FT"), dt_personal.Rows(i)("PE_NUM_DOC_PER"), dat_fecha_ini_, dat_fecha_fin_)
                If dt_tmp.Rows.Count > 0 Then
                    Dim fila As DataRow
                    fila = dt_reporte.NewRow

                    fila("CODPER") = dt_personal.Rows(i)("PE_CODIGO")
                    fila("NOMBRES") = dt_personal.Rows(i)("NOMBRES")
                    fila("APELLIDOS") = dt_personal.Rows(i)("PE_APE_PAT") & " " & dt_personal.Rows(i)("PE_APE_MAT")
                    fila("DNI") = dt_personal.Rows(i)("PE_NUM_DOC_PER")
                    fila("ES_FT") = dt_personal.Rows(i)("PE_CONSIDERA_FT")

                    hora_tardanza_mod = get_HorasTardanza_Modifi(dt_personal.Rows(i)("PE_ID"))
                    If hora_tardanza_mod = String.Empty Then
                        fila("HORA_L") = DBNull.Value
                    Else
                        fila("HORA_L") = CDate(hora_tardanza_mod)
                    End If


                    '2 = trabajdor de confianza y no se debe procesar las horas de tardanza
                    If dt_personal.Rows(i)("PE_ID_SITUACION_ESPECIAL") <> 2 Then
                        fila("TOTAL_HRAS_TARDANZA") = dt_tmp.Rows(0)("TOTAL_HRAS_TARDANZA")
                        fila("TOTAL_MENOS45_MIN") = dt_tmp.Rows(0)("TOTAL_MENOS45_MIN")
                        fila("HORAS") = dt_tmp.Rows(0)("HORAS")
                        fila("MINUTOS") = dt_tmp.Rows(0)("MINUTOS")
                        fila("HORAS_TARDE") = dt_tmp.Rows(0)("HORAS_TARDE")
                        fila("MINUTOS_TARDE") = dt_tmp.Rows(0)("MINUTOS_TARDE")

                        If dt_tmp.Rows(0)("HORAS_TARDE").ToString <> "" Then
                            If dt_tmp.Rows(0)("HORAS_TARDE") = 0 Then
                                If (dt_tmp.Rows(0)("MINUTOS_TARDE") - 45) < 0 Then
                                    fila("TOTAL_MENOS45_MIN") = Date.Now.ToString("00:00")
                                    fila("MINUTOS") = 0
                                    fila("HORAS") = 0
                                End If
                            End If
                        End If



                    End If
                    dt_reporte.Rows.Add(fila)
                End If
            End If
            upb_estado.IncrementValue(1)
        Next

        upb_estado.Value = 0
        upb_estado.Visible = False

        cnDicon.Close()
        marcaBL = Nothing

        ug_exporta.DataSource = dt_reporte

        Me.Cursor = Cursors.Default

    End Sub

    Private Sub Tool_Procesar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_Procesar.Click
        Call Procesar_Individual2()
    End Sub

    Private Function get_HorasTardanza_Modifi(idPersonal_ As Integer) As String
        'aqui buscamos si tiene horas de tardanza modificadas en la tabla "SG_PL_TB_TARDANZA_PERSONAL"
        Dim tardanzaAuxBL As New BL.PlanillaBL.SG_PL_TB_TARDANZA_PERSONAL
        Dim tardanzaBE As New BE.PlanillaBE.SG_PL_TB_TARDANZA_PERSONAL
        Dim tiempo_tardanza As String = String.Empty

        tardanzaBE.TP_IDPERSONAL = idPersonal_
        tardanzaBE.TP_ANHO = une_Ayo.Value
        tardanzaBE.TP_MES = uce_Mes.Value
        tiempo_tardanza = tardanzaAuxBL.get_Tardanza_aux(tardanzaBE)

        tardanzaBE = Nothing
        tardanzaAuxBL = Nothing

        If tiempo_tardanza Is Nothing Then
            Return String.Empty
        Else
            Return tiempo_tardanza.ToString
        End If


    End Function

    Private Sub ug_exporta_ClickCellButton(sender As System.Object, e As Infragistics.Win.UltraWinGrid.CellEventArgs) Handles ug_exporta.ClickCellButton

        PL_RP_Tardanza_Detalle.str_Dni = e.Cell.Row.Cells("DNI").Value
        PL_RP_Tardanza_Detalle.str_nom_trab = e.Cell.Row.Cells("NOMBRES").Value & " " & e.Cell.Row.Cells("APELLIDOS").Value
        PL_RP_Tardanza_Detalle.dat_fec_ini = CDate(udte_fec_ini.Value)
        PL_RP_Tardanza_Detalle.dat_fec_fin = CDate(udte_fec_fin.Value)
        PL_RP_Tardanza_Detalle.bol_Considerar_FT = IIf(e.Cell.Row.Cells("ES_FT").Value = 1, True, False)
        PL_RP_Tardanza_Detalle.ShowDialog()

    End Sub

    Private Sub ug_exporta_InitializeRow(sender As System.Object, e As Infragistics.Win.UltraWinGrid.InitializeRowEventArgs) Handles ug_exporta.InitializeRow
        e.Row.Cells("col_btn_detalle").Value = ""
        e.Row.Cells("col_btn_detalle").ButtonAppearance.Image = My.Resources._16Grid_properties
        e.Row.Cells("col_btn_detalle").ButtonAppearance.ImageHAlign = Infragistics.Win.HAlign.Center
    End Sub

    Private Sub uchk_modificar_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles uchk_modificar.CheckedChanged
        ug_exporta.DisplayLayout.Bands(0).Columns("HORA_L").Hidden = Not uchk_modificar.Checked
        ug_exporta.DisplayLayout.Bands(0).Columns("HORA_L").Width = 50
        ug_exporta.DisplayLayout.Bands(0).Columns("MINUTOS").Width = 50
    End Sub

    Private Sub ug_exporta_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles ug_exporta.KeyDown

        If e.KeyCode = Keys.Enter Then
            Try
                ug_exporta.UpdateData()
            Catch ex As Exception
                Avisar("Ingrese correctamente la hora")
                Exit Sub
            End Try


            With ug_exporta

                Select Case .ActiveRow.Cells(.ActiveCell.Column.Index).Column.Key

                    Case "HORA_L"
                        

                        Dim personalBL As New BL.PlanillaBL.SG_PL_TB_PERSONAL
                        Dim personalBE As New BE.PlanillaBE.SG_PL_TB_PERSONAL
                        personalBE.PE_NUM_DOC_PER = ug_exporta.ActiveRow.Cells("DNI").Value
                        personalBE.PE_ID_EMPRESA = gInt_IdEmpresa
                        personalBL.getPersonal_x_DNI(personalBE)

                        If personalBE.PE_ID = 0 Then Exit Sub

                        'grabamos el dato en la tabla
                        Dim tardanzaBL As New BL.PlanillaBL.SG_PL_TB_TARDANZA_PERSONAL
                        Dim tardanzaBE As New BE.PlanillaBE.SG_PL_TB_TARDANZA_PERSONAL

                        With tardanzaBE
                            .TP_IDPERSONAL = personalBE.PE_ID
                            .TP_ANHO = une_Ayo.Value
                            .TP_MES = uce_Mes.Value
                            .TP_TARDANZA = ug_exporta.ActiveRow.Cells("HORA_L").Value.ToString
                            .TP_USUARIO = String.Format("{0}-{1}", Environment.UserName, gStr_Usuario_Sis)
                            .TP_TERMINAL = Environment.MachineName
                            .TP_FECREG = Date.Now
                        End With

                        tardanzaBL.Insert(tardanzaBE)


                        personalBE = Nothing
                        personalBL = Nothing

                        tardanzaBE = Nothing
                        tardanzaBL = Nothing

                        .PerformAction(UltraGridAction.NextCellByTab, False, False)
                        .PerformAction(UltraGridAction.NextCellByTab, False, False)
                        .PerformAction(UltraGridAction.NextCellByTab, False, False)
                        .PerformAction(UltraGridAction.NextCellByTab, False, False)
                        .PerformAction(UltraGridAction.NextCellByTab, False, False)
                        .PerformAction(UltraGridAction.NextCellByTab, False, False)
                        .PerformAction(UltraGridAction.NextCellByTab, False, False)
                        .PerformAction(UltraGridAction.NextCellByTab, False, False)
                        .PerformAction(UltraGridAction.NextCellByTab, False, False)
                        .PerformAction(UltraGridAction.NextCellByTab, False, False)
                        .PerformAction(UltraGridAction.NextCellByTab, False, False)


                End Select

            End With
        End If
    End Sub

    Private Sub ToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim frmjjj As New PL_RP_HorasTrabajadas
        frmjjj.Show()
    End Sub
End Class