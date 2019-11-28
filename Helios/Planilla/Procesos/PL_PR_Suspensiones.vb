Public Class PL_PR_Suspensiones

    Dim Bol_Nuevo As Boolean = False

    Private Sub PL_PR_Suspensiones_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            For i As Integer = 0 To ToolS_Mantenimiento.Items.Count - 1
                ToolS_Mantenimiento.Items(i).Enabled = False
            Next
            ToolS_Mantenimiento.Items("Tool_Salir").Enabled = True
            ToolS_Mantenimiento.Items("Tool_Nuevo").Enabled = True

            Call Cargar_Tipo_Suspension()
            Call Cargar_Listado_Registrados()
            Call Formatear_Grilla_Selector(ug_detalle)
            Call MostrarTabs(0, utc_Contenedor)


            ubtn_refrescar.Appearance.Image = My.Resources._726
            ubtn_atraz.Appearance.Image = My.Resources._16__Back_
            txt_cod_personal.ButtonsRight(0).Appearance.Image = My.Resources._104

        Catch ex As Exception
            ShowError(ex.Message)
        End Try

    End Sub


    Private Sub Cargar_Listado_Registrados()
        If uos_tipos.Items.Count > 0 Then
            Dim suspensionesBL As New BL.PlanillaBL.SG_PL_TB_SUSPENSIONES
            ug_nombres.DataSource = suspensionesBL.get_Lista_Personal_Suspendido(uos_tipos.Value, gInt_IdEmpresa)
            suspensionesBL = Nothing
        End If
    End Sub

    Private Sub Cargar_Tipo_Suspension()
        Dim tipoSuspensionBL As New BL.PlanillaBL.SG_PL_TB_TIPO_SUSPENSION
        uce_Tipo_Suspension.DataSource = tipoSuspensionBL.get_Tipos()
        uce_Tipo_Suspension.ValueMember = "TS_ID"
        uce_Tipo_Suspension.DisplayMember = "TS_DESCRIPCION"

        uos_tipos.DataSource = tipoSuspensionBL.get_Tipos()
        uos_tipos.ValueMember = "TS_ID"
        uos_tipos.DisplayMember = "TS_DESCRIPCION"
        uos_tipos.Value = 1

        
        tipoSuspensionBL = Nothing

    End Sub

    Private Sub Cargar_Lista_Suspension_x_Tipo()
        Dim tipoSuspensionSUnatBL As New BL.PlanillaBL.SG_PL_TB_TIPO_SUSPENSION_SUNAT

        uce_tipo_suspe_sunat.DataSource = tipoSuspensionSUnatBL.get_Tipos(uce_Tipo_Suspension.Value)
        uce_tipo_suspe_sunat.ValueMember = "TS_CODIGO"
        uce_tipo_suspe_sunat.DisplayMember = "TS_DESCRIPCION"

        tipoSuspensionSUnatBL = Nothing
    End Sub

    Private Sub Tool_Salir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_Salir.Click
        Me.Close()
    End Sub

    Private Sub Tool_Nuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_Nuevo.Click
        Bol_Nuevo = True
        Dim idpersonal As String = txt_IdPersonal.Text.Trim

        Call Inicializar_Estado_Botones_Tool(ToolS_Mantenimiento)
        Call Cambiar_Estado_Botones_Tool(ToolS_Mantenimiento)
        Call Limpiar_Controls_InGroupox_Nativo(gb1)
        Call Limpiar_Controls_InGroupox_Nativo(gb2)
        Call Limpiar_Controls_InGroupox_Nativo(gb3)
        Call MostrarTabs(1, utc_Contenedor, 1)

        une_Dias_Traba.Value = 0
        une_dias_vaca.Value = 0
        uce_Tipo_Suspension.Value = 1
        uchk_Procesar.Checked = True
        uce_tipo_suspe_sunat.Value = "23"
        lbl_obs.Text = "0 de 250"
        udte_fecha_inicio.Value = Nothing
        udte_fecha_fin.Value = Nothing
        uce_Periodos_vaca.Items.Clear()
        txt_cod_personal.Focus()

        If Not ug_nombres.Visible Then

            If idpersonal.Length > 0 Then
                Dim personalBL As New BL.PlanillaBL.SG_PL_TB_PERSONAL
                Dim personalBE As New BE.PlanillaBE.SG_PL_TB_PERSONAL

                personalBE.PE_ID = CInt(idpersonal)
                personalBE.PE_ID_EMPRESA = gInt_IdEmpresa

                personalBL.getPersonal_x_Id(personalBE)

                If personalBE.PE_ID_EST_TRABAJADOR = 2 Then
                    Avisar("el trabajador ya ceso, seleccione otro")
                    personalBE = Nothing
                    personalBL = Nothing
                    Exit Sub
                End If

                txt_id_personal.Text = personalBE.PE_ID
                txt_cod_personal.Text = personalBE.PE_CODIGO
                txt_nombres.Text = personalBE.PE_APE_PAT & " " & personalBE.PE_APE_MAT & " " & personalBE.PE_NOM_PRI & " " & personalBE.PE_NOM_SEG.ToString

                personalBE = Nothing
                personalBL = Nothing

                uce_Tipo_Suspension.Focus()

            End If

        End If

    End Sub

    Private Sub Tool_Cancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_Cancelar.Click
        Call MostrarTabs(0, utc_Contenedor, 0)
        Call Cambiar_Estado_Botones_Tool(ToolS_Mantenimiento)
    End Sub

    Private Sub Tool_Grabar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_Grabar.Click

        If uce_Tipo_Suspension.Value = 1 Then
            If uce_Periodos_vaca.SelectedIndex = -1 Then
                Avisar("Seleccione el periodo para " & uce_Tipo_Suspension.Text)
                uce_Periodos_vaca.Focus()
                Exit Sub
            End If
        End If

        If uce_tipo_suspe_sunat.SelectedIndex = -1 Then
            Call Avisar("Seleccione el tipo de suspesion laboral")
            uce_tipo_suspe_sunat.Focus()
            Exit Sub
        End If



        Dim suspensionBE As New BE.PlanillaBE.SG_PL_TB_SUSPENSIONES
        Dim suspensionBL As New BL.PlanillaBL.SG_PL_TB_SUSPENSIONES
        With suspensionBE
            .SU_ID = Val(txt_id_registro.Text.Trim)
            .SU_ID_TIPO_SUSPENSION = New BE.PlanillaBE.SG_PL_TB_TIPO_SUSPENSION With {.TS_ID = uce_Tipo_Suspension.Value}
            .SU_ID_PERSONAL = New BE.PlanillaBE.SG_PL_TB_PERSONAL With {.PE_ID = txt_id_personal.Text.Trim}
            .SU_FECHA_INI = CDate(udte_fecha_inicio.Value).ToShortDateString
            .SU_FECHA_FIN = CDate(udte_fecha_fin.Value).ToShortDateString
            .SU_DIAS_VACA = une_dias_vaca.Value
            .SU_DIAS_TRABAJO = une_Dias_Traba.Value
            .SU_USUARIO = String.Format("{0}-{1}", Environment.UserName, gStr_Usuario_Sis)
            .SU_TERMINAL = Environment.MachineName
            .SU_FECREG = Date.Now
            .SU_ID_TIPO_SUSPE_SUNAT = New BE.PlanillaBE.SG_PL_TB_TIPO_SUSPENSION_SUNAT With {.TS_CODIGO = uce_tipo_suspe_sunat.Value}
            .SU_PROCESAR = IIf(uchk_Procesar.Checked, 1, 0)
            .SU_PERIODO = uce_Periodos_vaca.Text
            .SU_OBS = txt_obs.Text.Trim
            If uce_Tipo_Suspension.Value = 2 Or uce_Tipo_Suspension.Value = 3 Then
                .SU_PERIODO_INI = udte_per_ini.Value
                .SU_PERIODO_FIN = udte_per_fin.Value
            Else
                .SU_PERIODO_INI = String.Empty
                .SU_PERIODO_FIN = String.Empty
            End If
            .SU_NCITT = txt_citt.Text.Trim
            .SU_CONGOSE = IIf(uchk_congoce.Checked, 1, 0)
        End With

        If Bol_Nuevo Then
            suspensionBL.Insert(suspensionBE)
        Else
            suspensionBL.Update(suspensionBE)

            Dim suspensionesBL As New BL.PlanillaBL.SG_PL_TB_SUSPENSIONES
            ug_detalle.DataSource = suspensionesBL.get_Suspensiones_x_Tipo(txt_IdPersonal.Text.Trim, uos_tipos.Value)
            suspensionesBL = Nothing

        End If

        Call Avisar("Listo!")

        Call Cargar_Listado_Registrados()
        Call Tool_Cancelar_Click(sender, e)

    End Sub

    Private Sub txt_cod_personal_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_cod_personal.KeyDown
        If e.KeyCode = Keys.F2 Then
            Call Mostrar_Ayuda_Empleado()
        End If

        If e.KeyCode = Keys.Enter Then
            uce_Tipo_Suspension.Focus()
        End If
    End Sub

    Private Sub Mostrar_Ayuda_Empleado()

        PL_PR_Lista_Personal.Int_tipo_Personal = 0
        PL_PR_Lista_Personal.Bol_habilitar_uos = True
        PL_PR_Lista_Personal.Bol_MultiSeleccion = False
        PL_PR_Lista_Personal.ShowDialog()
        If PL_PR_Lista_Personal.Bol_Aceptar Then
            Dim matriz As New List(Of BE.PlanillaBE.SG_PL_TB_PERSONAL)
            matriz = PL_PR_Lista_Personal.lista_empleados
            If matriz.Count > 0 Then

                For Each empleado As BE.PlanillaBE.SG_PL_TB_PERSONAL In matriz
                    txt_cod_personal.Text = empleado.PE_CODIGO
                    txt_nombres.Text = empleado.PE_APE_PAT & " " & empleado.PE_APE_MAT & " " & empleado.PE_NOM_PRI
                    txt_id_personal.Text = empleado.PE_ID
                Next
            End If
            matriz = Nothing

        End If
    End Sub

    Private Sub txt_nombres_EditorButtonClick(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinEditors.EditorButtonEventArgs) Handles txt_nombres.EditorButtonClick
        If e.Button.Key = "btn_ayuda" Then
            Call Mostrar_Ayuda_Empleado()
        End If
    End Sub

    Private Sub txt_nombres_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_nombres.KeyDown
        If e.KeyCode = Keys.Enter Then
            Call Mostrar_Ayuda_Empleado()
        End If
    End Sub

    Private Sub txt_cod_personal_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_cod_personal.Leave
        If txt_cod_personal.Text.Trim = String.Empty Then Exit Sub

        Dim personalBL As New BL.PlanillaBL.SG_PL_TB_PERSONAL
        Dim personalBE As New BE.PlanillaBE.SG_PL_TB_PERSONAL
        personalBE.PE_CODIGO = txt_cod_personal.Text.Trim
        personalBE.PE_ID_EMPRESA = gInt_IdEmpresa
        personalBL.getPersonal_x_Codigo(personalBE)

        If personalBE.PE_ID = 0 Then
            Call Avisar("El codigo no existe")
            txt_nombres.Text = String.Empty
            txt_id_personal.Text = String.Empty
        Else
            txt_nombres.Text = personalBE.PE_APE_PAT & " " & personalBE.PE_APE_MAT & " " & personalBE.PE_NOM_PRI & " " & personalBE.PE_NOM_SEG
            txt_id_personal.Text = personalBE.PE_ID
        End If

        personalBE = Nothing
        personalBL = Nothing

        Call Buscar_Periodos()

    End Sub

    Private Sub uce_Tipo_Suspension_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles uce_Tipo_Suspension.KeyDown
        If e.KeyCode = Keys.Enter Then SendKeys.Send(vbTab)
    End Sub

    Private Sub udte_fecha_inicio_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles udte_fecha_inicio.KeyDown
        If e.KeyCode = Keys.Enter Then SendKeys.Send(vbTab)
    End Sub

    Private Sub udte_fecha_fin_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles udte_fecha_fin.KeyDown
        If e.KeyCode = Keys.Enter Then SendKeys.Send(vbTab)
    End Sub

    Private Sub une_dias_vaca_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles une_dias_vaca.KeyDown
        If e.KeyCode = Keys.Enter Then SendKeys.Send(vbTab)
    End Sub

    Private Sub une_Dias_Traba_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles une_Dias_Traba.KeyDown
        If e.KeyCode = Keys.Enter Then uce_tipo_suspe_sunat.Focus()
    End Sub

    Private Sub uce_tipo_suspe_sunat_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles uce_tipo_suspe_sunat.KeyDown
        If e.KeyCode = Keys.Enter Then SendKeys.Send(vbTab)
    End Sub

    Private Sub udte_fecha_fin_Leave(sender As Object, e As System.EventArgs) Handles udte_fecha_fin.Leave
        If CDate(udte_fecha_inicio.Value) > CDate(udte_fecha_fin.Value) Then
            Avisar("La fecha de inicio no puede ser mayor al fecha final")
            une_dias_vaca.Value = 0
            une_Dias_Traba.Value = 0
        End If
    End Sub

    Private Sub udte_fecha_fin_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles udte_fecha_fin.ValueChanged
        udte_per_fin.Value = udte_fecha_fin.Value

        Dim dif As Integer = DateDiff(DateInterval.Day, CDate(udte_fecha_inicio.Value), CDate(udte_fecha_fin.Value))
        une_dias_vaca.Value = dif + 1
        une_Dias_Traba.Value = 30 - (dif + 1)
    End Sub

    Private Sub udte_fecha_inicio_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles udte_fecha_inicio.ValueChanged
        udte_per_ini.Value = udte_fecha_inicio.Value
    End Sub

    Private Sub uos_tipos_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles uos_tipos.ValueChanged
        Call Cargar_Listado_Registrados()

        For i As Integer = 0 To ToolS_Mantenimiento.Items.Count - 1
            ToolS_Mantenimiento.Items(i).Enabled = False
        Next
        ToolS_Mantenimiento.Items("Tool_Salir").Enabled = True
        ToolS_Mantenimiento.Items("Tool_Nuevo").Enabled = True

        ug_detalle.Visible = False
        ug_nombres.Visible = True
        ubtn_atraz.Enabled = False
    End Sub

    Private Sub Tool_Editar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_Editar.Click

        If ug_detalle.Rows.Count = 0 Then Exit Sub
        If ug_detalle.ActiveRow Is Nothing Then Exit Sub


        Dim suspensionesBL As New BL.PlanillaBL.SG_PL_TB_SUSPENSIONES
        Dim suspensionesBE As New BE.PlanillaBE.SG_PL_TB_SUSPENSIONES

        Dim tmp_idPersonal As String = txt_IdPersonal.Text

        Call Limpiar_Controls_InGroupox_Nativo(gb1)
        Call Limpiar_Controls_InGroupox_Nativo(gb2)
        Call Limpiar_Controls_InGroupox_Nativo(gb3)

        txt_IdPersonal.Text = tmp_idPersonal

        Try
            suspensionesBE.SU_ID = ug_detalle.ActiveRow.Cells("SU_ID").Value
        Catch ex As Exception
            Exit Sub
        End Try

        txt_id_registro.Text = ug_detalle.ActiveRow.Cells("SU_ID").Value

        If suspensionesBL.Procesado(suspensionesBE) Then
            Avisar("El periodo de la suspension ya se proceso. No se puede Modificar")
            Exit Sub
        End If


        suspensionesBL.get_Suspensiones_x_Id(suspensionesBE)

        If suspensionesBE.SU_ID_PERSONAL.PE_ID <> 0 Then

            Dim personalBL As New BL.PlanillaBL.SG_PL_TB_PERSONAL
            Dim personalBE As New BE.PlanillaBE.SG_PL_TB_PERSONAL With {.PE_ID = suspensionesBE.SU_ID_PERSONAL.PE_ID, .PE_ID_EMPRESA = gInt_IdEmpresa}
            personalBL.getPersonal_x_Id(personalBE)

            txt_cod_personal.Text = personalBE.PE_CODIGO
            txt_nombres.Text = personalBE.PE_APE_PAT & " " & personalBE.PE_APE_MAT & " " & personalBE.PE_NOM_PRI & " " & personalBE.PE_NOM_SEG

            personalBL = Nothing
            personalBE = Nothing

            txt_id_personal.Text = suspensionesBE.SU_ID_PERSONAL.PE_ID
            uce_Tipo_Suspension.Value = suspensionesBE.SU_ID_TIPO_SUSPENSION.TS_ID
            udte_fecha_inicio.Value = suspensionesBE.SU_FECHA_INI
            udte_fecha_fin.Value = suspensionesBE.SU_FECHA_FIN
            une_dias_vaca.Value = suspensionesBE.SU_DIAS_VACA
            une_Dias_Traba.Value = suspensionesBE.SU_DIAS_TRABAJO
            uce_tipo_suspe_sunat.Value = suspensionesBE.SU_ID_TIPO_SUSPE_SUNAT.TS_CODIGO
            uchk_Procesar.Checked = IIf(suspensionesBE.SU_PROCESAR = 1, True, False)
            uce_Periodos_vaca.Text = suspensionesBE.SU_PERIODO
            txt_obs.Text = suspensionesBE.SU_OBS.ToString

            udte_per_ini.Value = suspensionesBE.SU_PERIODO_INI.ToString
            udte_per_fin.Value = suspensionesBE.SU_PERIODO_FIN.ToString
            txt_citt.Text = suspensionesBE.SU_NCITT.ToString

            uchk_congoce.Checked = IIf(suspensionesBE.SU_CONGOSE = 1, True, False)

            Call MostrarTabs(1, utc_Contenedor, 1)
            Call Cambiar_Estado_Botones_Tool(ToolS_Mantenimiento)
            uce_Tipo_Suspension.Focus()
            Bol_Nuevo = False

        End If

        suspensionesBE = Nothing
        suspensionesBL = Nothing

    End Sub

    Private Sub Tool_Eliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_Eliminar.Click
        Dim suspensionesBL As New BL.PlanillaBL.SG_PL_TB_SUSPENSIONES
        Dim suspensionesBE As New BE.PlanillaBE.SG_PL_TB_SUSPENSIONES

        suspensionesBE.SU_ID = ug_detalle.ActiveRow.Cells("SU_ID").Value
        '__________________________________________verificamos si esta procesado  o no

        If suspensionesBL.Procesado(suspensionesBE) Then
            Avisar("El periodo de la suspension ya se proceso. No se puede Eliminar")
            Exit Sub
        End If

        '__________________________________________confirmamos eliminacion
        If Preguntar("Esta seguro de eliminar") Then

            suspensionesBL.Delete(suspensionesBE)

            Call Avisar("    Listo!  ")

            ug_detalle.DataSource = suspensionesBL.get_Suspensiones(ug_nombres.ActiveRow.Cells("PE_ID").Value)

        End If


        suspensionesBE = Nothing
        suspensionesBL = Nothing
    End Sub


    Private Sub uce_Tipo_Suspension_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles uce_Tipo_Suspension.ValueChanged

        Pa_Vaca.Visible = False
        pa_otros.Visible = True
        txt_citt.Enabled = True

        If uce_Tipo_Suspension.Value = 1 Then 'vacaciones
            Call Buscar_Periodos()
            Pa_Vaca.Visible = True
            pa_otros.Visible = False
            txt_citt.Enabled = False
            uce_tipo_suspe_sunat.Enabled = True
        End If


        'If uce_Tipo_Suspension.Value <> 1 Then 'vacaciones
        '    uce_tipo_suspe_sunat.Enabled = False
        'End If

        Call Cargar_Lista_Suspension_x_Tipo()

        uchk_congoce.Enabled = False
        uchk_congoce.Checked = False

        If uce_Tipo_Suspension.Value = 3 Then 'Licencias
            uchk_congoce.Enabled = True
        End If


    End Sub

    Private Sub Buscar_Periodos()
        Dim fecha_ing As Date = Date.Now
        Dim fecha_1 As Date = Date.Now
        If txt_id_personal.Text = String.Empty Then Exit Sub

        Dim personalBL As New BL.PlanillaBL.SG_PL_TB_PERSONAL
        Dim personalBE As New BE.PlanillaBE.SG_PL_TB_PERSONAL With {.PE_ID = Val(txt_id_personal.Text.Trim), .PE_ID_EMPRESA = gInt_IdEmpresa}
        personalBL.getPersonal_x_Id(personalBE)

        Dim ayo1 As Integer = 0
        Dim ayo2 As Integer = 0
        Dim fecha_ult As Date
        fecha_ing = personalBE.PE_FEC_ING

        fecha_ult = fecha_ing
        uce_Periodos_vaca.Items.Clear()
        For i As Integer = fecha_ing.Year To gDat_Fecha_Sis.Year + 2
            ayo1 = fecha_ult.Year
            ayo2 = fecha_ult.AddYears(1).Year
            uce_Periodos_vaca.Items.Add(i, ayo1.ToString & " - " & ayo2.ToString)
            fecha_ult = fecha_ult.AddYears(1)
        Next

    End Sub

    Private Sub txt_cod_personal_EditorButtonClick(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinEditors.EditorButtonEventArgs) Handles txt_cod_personal.EditorButtonClick
        Call Mostrar_Ayuda_Empleado()
    End Sub

    Private Sub txt_obs_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_obs.ValueChanged

        lbl_obs.Text = (txt_obs.Text.Trim.Length).ToString & " de 250"

    End Sub

    Private Sub ug_nombres_DoubleClickRow(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.DoubleClickRowEventArgs) Handles ug_nombres.DoubleClickRow

        If e.Row.IsFilterRow Then Exit Sub

        If ug_nombres.Rows.Count = 0 Then Exit Sub

        If ug_nombres.ActiveRow.Cells("PE_ID").Value.ToString = "" Then
            Exit Sub
        End If

        Call Inicializar_Estado_Botones_Tool(ToolS_Mantenimiento)
        'Call Cambiar_Estado_Botones_Tool(ToolS_Mantenimiento)
        txt_IdPersonal.Text = ug_nombres.ActiveRow.Cells("PE_ID").Value
        Dim suspensionesBL As New BL.PlanillaBL.SG_PL_TB_SUSPENSIONES
        ug_detalle.DataSource = suspensionesBL.get_Suspensiones_x_Tipo(txt_IdPersonal.Text.Trim, uos_tipos.Value)
        suspensionesBL = Nothing


        ug_detalle.Visible = True
        ug_nombres.Visible = False
        ubtn_atraz.Enabled = True

        ug_detalle.Text = ug_nombres.ActiveRow.Cells("TRABAJADOR").Value.ToString


    End Sub

    Private Sub ug_detalle_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles ug_detalle.KeyDown
        If e.KeyCode = Keys.Escape Then
            ug_detalle.Visible = False
            ug_nombres.Visible = True
        End If
    End Sub

    Private Sub ubtn_atraz_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ubtn_atraz.Click
        For i As Integer = 0 To ToolS_Mantenimiento.Items.Count - 1
            ToolS_Mantenimiento.Items(i).Enabled = False
        Next
        ToolS_Mantenimiento.Items("Tool_Salir").Enabled = True
        ToolS_Mantenimiento.Items("Tool_Nuevo").Enabled = True

        ug_detalle.Visible = False
        ug_nombres.Visible = True
        ubtn_atraz.Enabled = False
        '
    End Sub

    Private Sub ubtn_refrescar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ubtn_refrescar.Click
        Call Cargar_Listado_Registrados()
    End Sub

    Private Sub ug_detalle_DoubleClickRow(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.DoubleClickRowEventArgs) Handles ug_detalle.DoubleClickRow
        Tool_Editar_Click(sender, e)
    End Sub

    Private Sub ug_detalle_InitializeGroupByRow(sender As System.Object, e As Infragistics.Win.UltraWinGrid.InitializeGroupByRowEventArgs) Handles ug_detalle.InitializeGroupByRow
        e.Row.Expanded = True
    End Sub

    Private Sub udte_per_ini_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles udte_per_ini.KeyDown
        If e.KeyCode = Keys.Enter Then
            udte_per_fin.Focus()
        End If
    End Sub

    Private Sub udte_per_fin_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles udte_per_fin.KeyDown
        If e.KeyCode = Keys.Enter Then
            une_dias_vaca.Focus()
        End If
    End Sub

    Private Sub ug_detalle_BeforeRowsDeleted(sender As System.Object, e As Infragistics.Win.UltraWinGrid.BeforeRowsDeletedEventArgs) Handles ug_detalle.BeforeRowsDeleted
        e.Cancel = True
    End Sub

    Private Sub ug_nombres_BeforeRowsDeleted(sender As System.Object, e As Infragistics.Win.UltraWinGrid.BeforeRowsDeletedEventArgs) Handles ug_nombres.BeforeRowsDeleted
        e.Cancel = True
    End Sub
End Class