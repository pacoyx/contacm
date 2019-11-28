Public Class HO_PR_RegDiaPer
    Dim dv_Lista As New DataView
    Dim dt_Lista As New DataTable
    Public bol_edicion As Boolean = False
    Public MarcacionBE As BE.HospitalBE.SG_PL_TB_MARCA_ASIS
    Public nomper_ As String
    Public codper_ As String
    Public bol_ok As Boolean = False
    Dim str_AreaPersonal As String = String.Empty
    Public bol_Ultimo_Dia As Boolean = False
    Public dat_fecha_Ini As String = String.Empty
    Public dat_fecha_Fin As String = String.Empty
    Dim MarcacionModBE As BE.HospitalBE.SG_PL_TB_MARCA_ASIS

    Private Sub HO_PR_RegDiaPer_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Call Cargar_Lista_personal()
        Call Cargar_Tipo_Registro()
        Call Cargar_Servicios()
        uce_tm_ent.SelectedIndex = 0
        uce_tm_sal.SelectedIndex = 0
        uos_TipoRegistro.Value = 1
        uce_Servicio.SelectedIndex = 0
        txt_Filtro.ReadOnly = False
        udte_fecha.Enabled = True
        ume_tot_horas.Value = 0
        ume_tot_hor_ext.Value = 0
        udte_fecha.Value = Nothing

        If bol_edicion Then
            Call Editar_Datos_Marcacion()
            Call Buscar_Area_Personal()
            Call Mostrar_Total_Horas()
            txt_Filtro.ReadOnly = True
            udte_fecha.Enabled = False
            uce_Servicio.Focus()
        End If

        ug_ListaPer.Left = 111
        ug_ListaPer.Top = 88
    End Sub

    Private Sub Mostrar_Total_Horas()

        If txt_idper.Text.Trim.Length = 0 Then
            Exit Sub
        End If

        Dim marcacionBL As New BL.HospitalBL.Funciones

        Dim ayo As Integer = CDate(udte_fecha.Value).Year
        Dim mes As Integer = CDate(udte_fecha.Value).Month

        If CDate(udte_fecha.Value).Day >= 25 Then
            mes += 1
            If mes = 12 Then
                mes = 1
                ayo += 1
            End If
        End If

        Dim lista_horas As List(Of String)
        lista_horas = marcacionBL.get_Suma_Total_Horas(txt_idper.Text, ayo, mes, gInt_IdEmpresa)

        If Not lista_horas Is Nothing Then
            ume_tot_horas.Value = lista_horas(0)
            ume_tot_hor_ext.Value = lista_horas(1)
        End If

        marcacionBL = Nothing

    End Sub

    Private Function Paso_Maximo_Horas() As Boolean

        Dim rpta As Boolean = False

        '_______________________________________________________________

        Dim marcacion As String = ume_tiempo.Value
        Dim indice As Integer = marcacion.IndexOf(":")
        Dim hora As Integer = marcacion.Substring(0, indice)
        Dim minuto As Integer = marcacion.Remove(0, indice + 1)

        Dim tiempo_marca As New TimeSpan(hora, minuto, 0)

        marcacion = ume_tot_horas.Value
        indice = marcacion.IndexOf(":")
        hora = marcacion.Substring(0, indice)
        minuto = marcacion.Remove(0, indice + 1)


        Dim tiempo_Acumulado As New TimeSpan(hora, minuto, 0)

        tiempo_Acumulado = tiempo_Acumulado.Add(tiempo_marca)

        Select Case str_AreaPersonal
            Case "9" 'naonatologia - sala de bebes
                If tiempo_Acumulado.TotalHours > 96 Then
                    rpta = True
                End If

            Case "10" 'hospitalizacion

                'If tiempo_Acumulado.TotalHours > 150 Then
                '    rpta = True
                'End If

        End Select


        Return rpta

    End Function

    Private Sub Cargar_Servicios()
        Dim marcaBL As New BL.HospitalBL.Funciones
        Dim drrServicios As SqlClient.SqlDataReader = marcaBL.get_Servicios(gInt_IdEmpresa)

        uce_Servicio.Items.Clear()
        uce_Servicio.Items.Add("0", "[Seleccione]")
        If drrServicios.HasRows Then
            Do While drrServicios.Read
                uce_Servicio.Items.Add(drrServicios(0), drrServicios(1))
            Loop
        End If

        drrServicios.Close()
        drrServicios = Nothing
        marcaBL = Nothing

    End Sub

    Private Sub Editar_Datos_Marcacion()

        'guardamos los datos del ultimo dia
        If bol_Ultimo_Dia Then MarcacionModBE = MarcacionBE

        txt_Filtro.Text = nomper_
        txt_codper.Text = codper_
        txt_idper.Text = MarcacionBE.MA_IDPERSONAL


        uchk_Feriado.Checked = IIf(MarcacionBE.MA_ES_FERIADO = 1, True, False)
        uchk_refrigerio.Checked = IIf(MarcacionBE.MA_ES_REFRI = 1, True, False)

        If MarcacionBE.MA_IDTIPO_REG = 2 Then
            uos_TipoRegistro.Value = MarcacionBE.MA_IDTIPO_REG

            udte_ini_vaca.Value = MarcacionBE.MA_VACA_INI
            udte_fin_vaca.Value = MarcacionBE.MA_VACA_FIN

            Dim hora As String = MarcacionBE.MA_TIEMPO.Substring(0, MarcacionBE.MA_TIEMPO.IndexOf(":"))
            Dim minutos As String = MarcacionBE.MA_TIEMPO.Substring(MarcacionBE.MA_TIEMPO.IndexOf(":") + 1, 2)

            ume_tot_horas_vaca.Value = hora & "." & minutos

            ume_hora_ent.Value = Nothing
            ume_hora_sal.Value = Nothing
            ume_tiempo.Value = Nothing
            txt_obs.Text = MarcacionBE.MA_OBS
            udte_fecha.Value = Nothing

            uce_tm_ent.Value = ""
            uce_tm_sal.Value = ""
            txt_item.Text = MarcacionBE.MA_ITEM
            uce_Servicio.SelectedIndex = 0
            uce_Servicio.Enabled = False
        Else

            ume_hora_ent.Value = MarcacionBE.MA_HORA_ENT
            ume_hora_sal.Value = MarcacionBE.MA_HORA_SAL
            ume_tiempo.Value = MarcacionBE.MA_TIEMPO
            txt_obs.Text = MarcacionBE.MA_OBS
            udte_fecha.Value = MarcacionBE.MA_FECHA
            uos_TipoRegistro.Value = MarcacionBE.MA_IDTIPO_REG
            uce_tm_ent.Value = MarcacionBE.MA_TM_ENT
            uce_tm_sal.Value = MarcacionBE.MA_TM_SAL
            txt_item.Text = MarcacionBE.MA_ITEM
            uce_Servicio.Value = MarcacionBE.MA_IDSERVICIO

        End If



        txt_Filtro.ReadOnly = True
        udte_fecha.Enabled = False
        ume_hora_ent.Focus()

    End Sub

    Private Sub Cargar_Tipo_Registro()
        Dim miFuncion As New BL.HospitalBL.Funciones
        'uce_TipoReg.DataSource = miFuncion.get_Tipo_Registro
        'uce_TipoReg.DisplayMember = "TR_DESCRIPCION"
        'uce_TipoReg.ValueMember = "TR_ID"

        uos_TipoRegistro.DataSource = miFuncion.get_Tipo_Registro
        uos_TipoRegistro.DisplayMember = "TR_DESCRIPCION"
        uos_TipoRegistro.ValueMember = "TR_ID"

        miFuncion = Nothing

    End Sub

    Private Sub Cargar_Lista_personal()
        Dim miFuncion As New BL.HospitalBL.Funciones

        dt_Lista = miFuncion.get_Personal_Asistencial_Horas(gInt_IdEmpresa)
        dt_Lista.TableName = "Lista"
        dv_Lista.Table = dt_Lista
        ug_ListaPer.DataSource = dv_Lista

        miFuncion = Nothing

    End Sub

    Private Sub txt_Filtro_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_Filtro.ValueChanged

        If txt_Filtro.Text.Trim.Length = 0 Then
            dv_Lista.RowFilter = ""
            ug_ListaPer.Visible = False
            txt_codper.Text = ""
            txt_idper.Text = ""
            txt_Area.Text = ""
        Else
            If Not bol_edicion Then
                dv_Lista.RowFilter = "nombres  like '" & txt_Filtro.Text.Trim & "%'"
                ug_ListaPer.Visible = True
            End If
        End If

    End Sub

    Private Sub txt_Filtro_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_Filtro.KeyDown
        If e.KeyCode = Keys.Down Then
            ug_ListaPer.Focus()
        End If
        If e.KeyCode = Keys.Enter Then
            If ug_ListaPer.Visible Then
                txt_Filtro.Text = ug_ListaPer.ActiveRow.Cells("NOMBRES").Value
                txt_codper.Text = ug_ListaPer.ActiveRow.Cells("PE_CODIGO").Value
                txt_idper.Text = ug_ListaPer.ActiveRow.Cells("PE_ID").Value
                ug_ListaPer.Visible = False
                Call Buscar_Area_Personal()
                txt_Filtro.Focus()
            Else
                Call Buscar_Area_Personal()
                Call Mostrar_Total_Horas()
                If udte_fecha.Enabled Then
                    udte_fecha.Focus()
                Else
                    ume_hora_ent.Focus()
                End If

            End If
        End If
    End Sub

    Private Sub Buscar_Area_Personal()

        If txt_idper.Text.Trim.Length = 0 Then Exit Sub
        Dim idpersonal As Integer = txt_idper.Text.Trim

        Dim marcacionBL As New BL.HospitalBL.Funciones
        str_AreaPersonal = marcacionBL.get_Area_Personal(idpersonal, gInt_IdEmpresa)

        If str_AreaPersonal = String.Empty Then
            MessageBox.Show("Falta establecer AREA para el personal, comunicarse con RRHH o con SISTEMAS")
            Exit Sub
        End If

        Select Case str_AreaPersonal
            Case "9" 'sala de bebes
                uce_Servicio.SelectedIndex = 1
                uce_Servicio.Enabled = True
                txt_Area.Text = "Sala de Bebes"
            Case "10" 'hospi
                uce_Servicio.SelectedIndex = 0
                uce_Servicio.Enabled = False
                txt_Area.Text = "Hospitalizacion"
        End Select

        marcacionBL = Nothing

    End Sub

    Private Sub Tool_salir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_salir.Click
        Me.Close()
    End Sub

    Private Sub Calcular_Tiempo()
        If ume_hora_ent.Value Is DBNull.Value Then
            Exit Sub
        End If

        If ume_hora_sal.Value Is DBNull.Value Then
            Exit Sub
        End If

        Dim horaInicial As TimeSpan
        Dim horaFinal As TimeSpan
        Dim diferencia As TimeSpan = Nothing

        horaInicial = New TimeSpan(CDate(ume_hora_ent.Value).Hour, CDate(ume_hora_ent.Value).Minute, 0)
        horaFinal = New TimeSpan(CDate(ume_hora_sal.Value).Hour, CDate(ume_hora_sal.Value).Minute, 0)


        If horaInicial > horaFinal Then
            horaFinal = horaFinal.Add(New TimeSpan(24, 0, 0))
            diferencia = horaFinal.Subtract(horaInicial)
        Else
            diferencia = horaFinal.Subtract(horaInicial)
        End If


        If diferencia.Minutes < 0 Then
            ume_tiempo.Value = diferencia.Hours & ":00"
        Else
            ume_tiempo.Value = diferencia.Hours & ":" & diferencia.Minutes
        End If

    End Sub

    Private Sub ume_hora_sal_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ume_hora_sal.Leave
        Call Calcular_Tiempo()
    End Sub

    Private Sub ume_hora_ent_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles ume_hora_ent.KeyDown
        If e.KeyCode = Keys.Enter Then
            ume_hora_sal.Focus()
        End If
    End Sub

    Private Sub ume_hora_sal_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles ume_hora_sal.KeyDown
        If e.KeyCode = Keys.Enter Then
            uos_TipoRegistro.Focus()
        End If
    End Sub

    Private Sub Tool_Grabar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_Grabar.Click


        If txt_codper.Text.Trim.Length = 0 Then
            MessageBox.Show("Seleccione un personal", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            txt_Filtro.Focus()
            Exit Sub
        End If

        If uos_TipoRegistro.Value <> 2 Then
            If ume_tiempo.Value.ToString = "" Then
                MessageBox.Show("Ingrese las horas correctamente", "Sistema")
                Exit Sub
            End If

            'If Not bol_edicion Then
            '    If Paso_Maximo_Horas() Then
            '        MessageBox.Show("El total de horas esta pasando el tope de 96 Horas", "Sistema")
            '        Exit Sub
            '    End If
            'End If


            If ume_hora_ent.Value.ToString = "" Then
                MessageBox.Show("ingrese la hora de Entrada", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Stop)
                ume_hora_ent.Focus()
                Exit Sub
            End If

            If ume_hora_sal.Value.ToString = "" Then
                MessageBox.Show("ingrese la hora de Salida", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Stop)
                ume_hora_sal.Focus()
                Exit Sub
            End If

        End If




        Dim marcacionBE As New BE.HospitalBE.SG_PL_TB_MARCA_ASIS
        Dim marcacionBL As New BL.HospitalBL.Funciones

        With marcacionBE

            .MA_ES_FERIADO = IIf(uchk_Feriado.Checked, 1, 0)
            .MA_ES_REFRI = IIf(uchk_refrigerio.Checked, 1, 0)

            If uos_TipoRegistro.Value = 2 Then 'vacaciones
                .MA_IDPERSONAL = txt_idper.Text.Trim
                .MA_FECHA = String.Empty
                .MA_HORA_ENT = ""
                .MA_TM_ENT = "" 'uce_tm_ent.Value
                .MA_HORA_SAL = ""
                .MA_TM_SAL = "" 'uce_tm_sal.Value

                Dim hora As String = ume_tot_horas_vaca.Value.ToString.Substring(0, ume_tot_horas_vaca.Value.ToString.IndexOf("."))
                Dim minutos As String = ume_tot_horas_vaca.Value.ToString.Substring(ume_tot_horas_vaca.Value.ToString.IndexOf(".") + 1, 2)

                .MA_TIEMPO = hora & ":" & minutos



                .MA_IDTIPO_REG = uos_TipoRegistro.Value
                .MA_OBS = txt_obs.Text
                .MA_IDEMPRESA = gInt_IdEmpresa
                .MA_IDSERVICIO = uce_Servicio.Value
                .MA_ITEM = Val(txt_item.Text.Trim)
                .MA_VACA_INI = CDate(udte_ini_vaca.Value)
                .MA_VACA_FIN = CDate(udte_fin_vaca.Value)
                .MA_TERMINAL = Environment.MachineName
                .MA_USUARIO = String.Format("{0}-{1}", Environment.UserName, gStr_Usuario_Sis)
                .MA_FECREG = Date.Now
            Else
                .MA_IDPERSONAL = txt_idper.Text.Trim
                .MA_FECHA = CDate(udte_fecha.Value).ToShortDateString
                .MA_HORA_ENT = ume_hora_ent.Value
                .MA_TM_ENT = "" 'uce_tm_ent.Value
                .MA_HORA_SAL = ume_hora_sal.Value
                .MA_TM_SAL = "" 'uce_tm_sal.Value
                .MA_TIEMPO = ume_tiempo.Value
                .MA_IDTIPO_REG = uos_TipoRegistro.Value
                .MA_OBS = txt_obs.Text
                .MA_IDEMPRESA = gInt_IdEmpresa
                .MA_IDSERVICIO = uce_Servicio.Value
                .MA_ITEM = Val(txt_item.Text.Trim)
                .MA_VACA_INI = String.Empty
                .MA_VACA_FIN = String.Empty
                .MA_TERMINAL = Environment.MachineName
                .MA_USUARIO = String.Format("{0}-{1}", Environment.UserName, gStr_Usuario_Sis)
                .MA_FECREG = Date.Now
            End If


        End With

        If bol_edicion Then
            marcacionBL.Update_Marcacion_Diaria(marcacionBE, MarcacionModBE, dat_fecha_Ini, dat_fecha_Fin)
        Else
            marcacionBL.Insert_Marcacion_Diaria(marcacionBE)
        End If

        marcacionBE = Nothing
        marcacionBL = Nothing

        MessageBox.Show("Listo!", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information)


        If bol_edicion Then
            bol_ok = True
            Close()
        End If

        'txt_Filtro.Text = String.Empty 
        'txt_codper.Text = String.Empty
        'txt_idper.Text = String.Empty

        ume_hora_ent.Value = Nothing
        ume_hora_sal.Value = Nothing
        ume_tiempo.Value = Nothing
        txt_obs.Text = String.Empty
        uce_Servicio.SelectedIndex = 0
        udte_fecha.Value = Nothing

        'uce_tm_ent.Value = "AM"
        'uce_tm_sal.Value = "PM"
        uos_TipoRegistro.Value = 1

        'Select Case str_AreaPersonal
        '    Case "9" 'sala de bebes
        '        uce_Servicio.SelectedIndex = 1
        '        uce_Servicio.Enabled = True
        '        txt_Area.Text = "Sala de Bebes"
        '    Case "10" 'hospi
        '        uce_Servicio.SelectedIndex = 0
        '        uce_Servicio.Enabled = False
        '        txt_Area.Text = "Hospitalizacion"
        'End Select

        txt_Filtro.SelectAll()
        txt_Filtro.Focus()

    End Sub

    Private Sub udte_fecha_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles udte_fecha.KeyDown
        If e.KeyCode = Keys.Enter Then
            If uce_Servicio.Enabled Then
                uce_Servicio.Focus()
            Else
                ume_hora_ent.Focus()
            End If
        End If
    End Sub

    Private Sub uce_Servicio_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles uce_Servicio.KeyDown
        If e.KeyCode = Keys.Enter Then
            ume_hora_ent.Focus()
        End If
    End Sub

    Private Sub uce_tm_ent_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles uce_tm_ent.ValueChanged
        Call Calcular_Tiempo()
    End Sub

    Private Sub uce_tm_sal_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles uce_tm_sal.ValueChanged
        Call Calcular_Tiempo()
    End Sub

    Private Sub txt_Filtro_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_Filtro.Enter
        txt_Filtro.SelectAll()
    End Sub

    Private Sub Tool_Limpiar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_Limpiar.Click
        bol_edicion = False
        uce_tm_ent.SelectedIndex = 0
        uce_tm_sal.SelectedIndex = 0
        uos_TipoRegistro.Value = 1
        uce_Servicio.SelectedIndex = 0
        txt_Filtro.ReadOnly = False
        udte_fecha.Enabled = True
        ume_tot_horas.Value = 0
        ume_tot_hor_ext.Value = 0
        udte_fecha.Value = Nothing
        txt_Area.Text = ""
        txt_Filtro.Text = ""
        txt_codper.Text = ""
        uchk_refrigerio.Checked = False
        uchk_Feriado.Checked = False

        uce_tm_ent.Value = "AM"
        uce_tm_sal.Value = "PM"

        txt_Filtro.Focus()

    End Sub

    Private Sub udte_fecha_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles udte_fecha.ValueChanged
        Call Mostrar_Total_Horas()
    End Sub

    Private Sub uos_TipoRegistro_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles uos_TipoRegistro.ValueChanged

        ugb_vaca.Visible = False
        If uos_TipoRegistro.Items.Count = 0 Then Exit Sub
        Call Buscar_Area_Personal()

        ume_hora_ent.Enabled = True
        ume_hora_sal.Enabled = True
        ume_tiempo.Enabled = True
        udte_fecha.Enabled = True

        Select Case uos_TipoRegistro.Value
            Case 1 'NORMAL
            Case 2 'VACACIONES

                udte_fecha.Value = Nothing
                uce_Servicio.Enabled = False
                uce_Servicio.SelectedIndex = -1
                ume_hora_ent.Value = Nothing
                ume_hora_sal.Value = Nothing
                ume_tiempo.Value = Nothing

                udte_fecha.Enabled = False
                ume_hora_ent.Enabled = False
                ume_hora_sal.Enabled = False
                ume_tiempo.Enabled = False

                ugb_vaca.Visible = True
                udte_ini_vaca.Value = Nothing
                udte_fin_vaca.Value = Nothing
                ume_tot_horas_vaca.Value = Nothing
                udte_ini_vaca.Focus()

            Case 3 'DESCANSO MEDICO
            Case 4 'APOYO

        End Select


    End Sub

    Private Sub udte_ini_vaca_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles udte_ini_vaca.KeyDown
        If e.KeyCode = Keys.Enter Then udte_fin_vaca.Focus()
    End Sub

    Private Sub udte_fin_vaca_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles udte_fin_vaca.KeyDown
        If e.KeyCode = Keys.Enter Then

            txt_obs.Text = "Del " & udte_ini_vaca.Value & " al " & udte_fin_vaca.Value

            ume_tot_horas_vaca.Focus()
        End If

    End Sub

    Private Sub ug_ListaPer_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles ug_ListaPer.KeyDown
        If e.KeyCode = Keys.Up Then
            If ug_ListaPer.ActiveRow.Index = 0 Then
                txt_Filtro.Focus()
            End If
        End If

        If e.KeyCode = Keys.Enter Then
            txt_Filtro.Text = ug_ListaPer.ActiveRow.Cells("NOMBRES").Value
            txt_codper.Text = ug_ListaPer.ActiveRow.Cells("PE_CODIGO").Value
            txt_idper.Text = ug_ListaPer.ActiveRow.Cells("PE_ID").Value
            Call Buscar_Area_Personal()
            ug_ListaPer.Visible = False
        End If

    End Sub

    Private Sub ug_ListaPer_DoubleClickRow(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinGrid.DoubleClickRowEventArgs) Handles ug_ListaPer.DoubleClickRow

        txt_Filtro.Text = ug_ListaPer.ActiveRow.Cells("NOMBRES").Value
        txt_codper.Text = ug_ListaPer.ActiveRow.Cells("PE_CODIGO").Value
        txt_idper.Text = ug_ListaPer.ActiveRow.Cells("PE_ID").Value
        ug_ListaPer.Visible = False
        Call Buscar_Area_Personal()
        txt_Filtro.Focus()

    End Sub

End Class