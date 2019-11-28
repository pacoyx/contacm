Public Class MA_PR_RegPapeleta

    Private Sub MA_PR_RegPapeleta_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

        Call cargar_Motivos()
        Call Cargar_Personal_Jefe()
        Call Cargar_Datos_Usuario()

        uce_cod_per.Enabled = False
        udte_fecha_inicio.Value = Nothing
        udte_fecha_fin.Value = Nothing
        Tool_Imprimir.Enabled = False
        ug_periodos.Visible = False

    End Sub

    Private Sub Cargar_Datos_Usuario()

        Dim marcaBL As New BL.MarcacionesBL.SG_MA_TB_PAPELETA
        Dim dt_info As DataTable = marcaBL.get_Info_Usuario(gInt_IdUsuario_Sis)

        If dt_info.Rows.Count > 0 Then

            txt_nom_emple.Text = dt_info(0)("PE_CODIGO") & " - " & dt_info(0)("NOMBRES")
            txt_id_personal.Text = dt_info(0)("US_IDPERSONAL")
            txt_area.Text = dt_info(0)("AR_DESCRIPCION")
            uce_cod_per.Value = dt_info(0)("AR_IDJEFE")

        End If

        dt_info = Nothing


    End Sub

    Private Sub Cargar_Personal_Jefe()
        Dim personalBL As New BL.PlanillaBL.SG_PL_TB_PERSONAL
        uce_cod_per.DataSource = personalBL.getPersonal_Cmb_Login(gInt_IdEmpresa)
        uce_cod_per.DisplayMember = "NOMBRES"
        uce_cod_per.ValueMember = "PE_ID"
        personalBL = Nothing
    End Sub

    Private Sub cargar_Motivos()
        Dim motivosBL As New BL.MarcacionesBL.SG_MA_TB_MOTIVO
        uce_motivo.DataSource = motivosBL.get_Motivos
        uce_motivo.DisplayMember = "MO_DESCRIPCION"
        uce_motivo.ValueMember = "MO_ID"
        motivosBL = Nothing

    End Sub

    Private Sub Tool_salir_Click(sender As System.Object, e As System.EventArgs) Handles Tool_salir.Click
        Me.Close()
    End Sub

    Private Sub Tool_Grabar_Click(sender As System.Object, e As System.EventArgs) Handles Tool_Grabar.Click

        Dim periodo As String = String.Empty


        ug_periodos.UpdateData()

        If udte_fecha_inicio.Value = Nothing Then
            Avisar("Ingrese la fecha de inicio")
            udte_fecha_inicio.Focus()
            Exit Sub
        End If

        If udte_fecha_fin.Value = Nothing Then
            Avisar("Ingrese la fecha de fin")
            udte_fecha_fin.Focus()
            Exit Sub
        End If

        If ume_hora_ent.Value.ToString = "" Then
            Avisar("Ingrese la hora de entrada")
            ume_hora_ent.Focus()
            Exit Sub
        End If

        If ume_hora_sal.Value.ToString = "" Then
            Avisar("Ingrese la hora de salida")
            ume_hora_sal.Focus()
            Exit Sub
        End If

        If uce_motivo.Value = 6 Then
            If txt_obs.Text.Length = 0 Then
                Avisar("Debe ingresar una descripcion de la papeleta")
                txt_obs.Focus()
                Exit Sub
            End If
        End If




        If uce_motivo.Value = 3 Then 'vacaciones

            Dim c As Integer = 0
            For i As Integer = 0 To ug_periodos.Rows.Count - 1
                If ug_periodos.Rows(i).Cells("SEL").Value Then
                    c += 1
                End If
            Next

            If c > 1 Then
                Avisar("Solo puede seleccionar un periodo por papeleta")
                Exit Sub
            End If

            If c = 0 Then
                Avisar("Debe seleccionar un periodo para las vacaciones")
                Exit Sub
            End If



            'validamos que los dias de vacaciones no pasen los 30 por periodo
            Dim dias_periodo As Integer = 0
            Dim dias_vaca As Integer = 0
            Dim total_periodo As Integer = 0


            dias_vaca = une_dif_dias.Value

            For i As Integer = 0 To ug_periodos.Rows.Count - 1
                If ug_periodos.Rows(i).Cells("SEL").Value Then
                    dias_periodo = ug_periodos.Rows(i).Cells("TOT_DIAS").Value
                    periodo = ug_periodos.Rows(i).Cells("SU_PERIODO").Value
                End If
            Next

            total_periodo = dias_periodo + dias_vaca


            If total_periodo > 30 Then
                Avisar("La cantidad de dias de vacaciones para el periodo " & periodo & " no pueden pasar los 30 dias")
                Exit Sub
            End If

        End If

        Me.Cursor = Cursors.WaitCursor

        Dim marcaBL As New BL.MarcacionesBL.SG_MA_TB_PAPELETA
        Dim marcaBE As New BE.MarcacionesBE.SG_MA_TB_PAPELETA

        With marcaBE
            .PA_ID = 0
            .PA_IDPERSONAL = txt_id_personal.Text
            .PA_IDJEFE = uce_cod_per.Value
            .PA_IDMOTIVO = uce_motivo.Value
            .PA_FEC_INI = CDate(udte_fecha_inicio.Value)
            .PA_FEC_FIN = CDate(udte_fecha_fin.Value)
            .PA_HOR_INI = ume_hora_ent.Value
            .PA_HOR_FIN = ume_hora_sal.Value
            .PA_DET_OTROS = txt_obs.Text.Trim
            .PA_VISTO_JEFE = 0
            .PA_FEC_VIS_JEFE = String.Empty
            .PA_VISTO_RRHH = 0
            .PA_FEC_VIS_RRHH = String.Empty
            .PA_USER = String.Format("{0}-{1}", Environment.UserName, gStr_Usuario_Sis)
            .PA_FEC_REG = Date.Now
            .PA_PC = Environment.MachineName
            .PA_FEC_MOD = Date.Now
            .PA_PERIODO_VACA = periodo
        End With

        marcaBL.Insert(marcaBE)

        txt_idpapeleta.Text = marcaBE.PA_ID.ToString().PadLeft(6, "0")

        marcaBL = Nothing
        marcaBE = Nothing

        Tool_Imprimir.Enabled = True

        Me.Cursor = Cursors.Default

        Call Avisar("Listo!")


    End Sub

    Private Sub uchk_otro_jefe_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles uchk_otro_jefe.CheckedChanged
        uce_cod_per.Enabled = uchk_otro_jefe.Checked
    End Sub

   
    Private Sub Tool_Nuevo_Click(sender As System.Object, e As System.EventArgs) Handles Tool_Nuevo.Click

        udte_fecha_inicio.Value = Nothing
        udte_fecha_fin.Value = Nothing

        ume_hora_ent.Text = Nothing
        ume_hora_sal.Text = Nothing

        txt_obs.Clear()

        uce_motivo.Value = Nothing
        Tool_Imprimir.Enabled = False

        udte_fecha_inicio.Focus()

        txt_idpapeleta.Text = ""

    End Sub

    Private Sub udte_fecha_inicio_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles udte_fecha_inicio.KeyDown
        If e.KeyCode = Keys.Enter Then
            udte_fecha_fin.Focus()
        End If
    End Sub

    Private Sub udte_fecha_fin_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles udte_fecha_fin.KeyDown
        If e.KeyCode = Keys.Enter Then
            ume_hora_ent.Focus()
        End If
    End Sub

    Private Sub ume_hora_ent_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles ume_hora_ent.KeyDown
        If e.KeyCode = Keys.Enter Then
            ume_hora_sal.Focus()
        End If
    End Sub

    Private Sub ume_hora_sal_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles ume_hora_sal.KeyDown
        If e.KeyCode = Keys.Enter Then
            uce_motivo.Focus()
        End If
    End Sub

    Private Sub uce_cod_per_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles uce_cod_per.KeyDown
        If e.KeyCode = Keys.Enter Then
            udte_fecha_inicio.Focus()
        End If
    End Sub

    Private Sub Tool_Imprimir_Click(sender As System.Object, e As System.EventArgs) Handles Tool_Imprimir.Click

        Me.Cursor = Cursors.WaitCursor

        Dim ObjReporte As New LR.ClsReporte
        Dim marcaBL As New BL.MarcacionesBL.SG_MA_TB_PAPELETA
        Dim dt As DataTable = marcaBL.get_Rep_01(Integer.Parse(txt_idpapeleta.Text))
        Dim empresaBL As New BL.ContabilidadBL.SG_CO_TB_EMPRESA
        Dim empresaBE As New BE.ContabilidadBE.SG_CO_TB_EMPRESA With {.EM_ID = gInt_IdEmpresa}
        empresaBL.getEmpresas_2(empresaBE)

        ObjReporte.Muestra_Reporte(String.Format("{0}\{1}", gStr_RutaRep, "MA_01.rpt"), dt, "", "pEmp;" & empresaBE.EM_NOMBRE, "pRuc;" & empresaBE.EM_RUC)

        ObjReporte = Nothing
        marcaBL = Nothing
        empresaBE = Nothing
        empresaBL = Nothing

        Me.Cursor = Cursors.Default

    End Sub

    Private Sub uos_Motivos_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs)
        If e.KeyCode = Keys.Enter Then
            txt_obs.Focus()
        End If
    End Sub

    Private Sub uce_motivo_ValueChanged(sender As System.Object, e As System.EventArgs) Handles uce_motivo.ValueChanged

        ug_periodos.Visible = False
        txt_obs.Width = 387

        If uce_motivo.Value = 3 Then

            Dim marcaBL As New BL.MarcacionesBL.SG_MA_TB_PAPELETA
            Dim dt_dias As DataTable = marcaBL.get_Dias_x_Periodo_Vacacional(txt_id_personal.Text)

            Dim periodo As String
            Dim f As DataRow()

            Call LimpiaGrid(ug_periodos, uds_periodos)

            For i As Integer = 2011 To 2014

                periodo = i.ToString & " - " & (i + 1).ToString
                f = dt_dias.Select("SU_PERIODO = '" & periodo & "'")


                If f.Length > 0 Then

                    ug_periodos.DisplayLayout.Bands(0).AddNew()
                    ug_periodos.Rows(ug_periodos.Rows.Count - 1).Cells("SU_PERIODO").Value = f(0)("SU_PERIODO")
                    ug_periodos.Rows(ug_periodos.Rows.Count - 1).Cells("TOT_DIAS").Value = f(0)("TOT_DIAS")
                    ug_periodos.Rows(ug_periodos.Rows.Count - 1).Cells("SEL").Value = False
                    ug_periodos.UpdateData()

                Else
                    ug_periodos.DisplayLayout.Bands(0).AddNew()
                    ug_periodos.Rows(ug_periodos.Rows.Count - 1).Cells("SU_PERIODO").Value = periodo
                    ug_periodos.Rows(ug_periodos.Rows.Count - 1).Cells("TOT_DIAS").Value = 0
                    ug_periodos.Rows(ug_periodos.Rows.Count - 1).Cells("SEL").Value = False
                    ug_periodos.UpdateData()
                End If

            Next

            txt_obs.Width = 209

            ug_periodos.Visible = True

            marcaBL = Nothing

        End If

    End Sub


    Private Sub ug_periodos_BeforeRowUpdate(sender As System.Object, e As Infragistics.Win.UltraWinGrid.CancelableRowEventArgs) Handles ug_periodos.BeforeRowUpdate

    End Sub

    Private Sub udte_fecha_fin_ValueChanged(sender As System.Object, e As System.EventArgs) Handles udte_fecha_fin.ValueChanged
        Try
            une_dif_dias.Value = DateDiff(DateInterval.Day, udte_fecha_inicio.Value, udte_fecha_fin.Value) + 1
        Catch ex As Exception

        End Try

    End Sub
End Class