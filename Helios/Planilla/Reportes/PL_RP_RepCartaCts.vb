Public Class PL_RP_RepCartaCts

    Private Sub PL_RP_RepCartaCts_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'cargamos el periodo
        Call CargarCombo_ConMeses(uce_Mes)
        une_ayo.Value = gDat_Fecha_Sis.Year
        uce_Mes.Value = gDat_Fecha_Sis.Month

        Call Cargar_TipoPersonal()

        'cargamos la lista de trabajadores
        Call Cargar_Trabajadores_bs()

        ume_tc.Value = 0


        txt_nombres.ButtonsRight(0).Appearance.Image = My.Resources._16__Db_previous_
        txt_nombres.ButtonsRight(1).Appearance.Image = My.Resources._16__Db_next_
        txt_codper.ButtonsRight(0).Appearance.Image = My.Resources._104

    End Sub

    Private Sub Cargar_TipoPersonal()
        Dim tipoPersonalBL As New BL.PlanillaBL.SG_PL_TB_TIPO_PERSONAL
        uce_TipoPersonal.DataSource = tipoPersonalBL.getTipos()
        uce_TipoPersonal.ValueMember = "TP_ID"
        uce_TipoPersonal.DisplayMember = "TP_DESCRIPCION"
        tipoPersonalBL = Nothing
    End Sub

    Private Sub Cargar_Trabajadores_bs()

        Dim personalBL As New BL.PlanillaBL.SG_PL_TB_PERSONAL
        Dim personalBE As New BE.PlanillaBE.SG_PL_TB_PERSONAL
        personalBE.PE_ID_EMPRESA = gInt_IdEmpresa
        personalBE.PE_ID_TIPO_PER = uce_TipoPersonal.Value

        bs_trabajadores.DataSource = personalBL.getPersonal_activos(personalBE)

        txt_idpersonal.DataBindings.Clear()
        txt_idpersonal.DataBindings.Add(New System.Windows.Forms.Binding("Text", bs_trabajadores, "PE_ID", True))
        txt_codper.DataBindings.Clear()
        txt_codper.DataBindings.Add(New System.Windows.Forms.Binding("Text", bs_trabajadores, "PE_CODIGO", True))

        txt_ape_pat.DataBindings.Clear()
        txt_ape_pat.DataBindings.Add(New System.Windows.Forms.Binding("Text", bs_trabajadores, "PE_APE_PAT", True))
        txt_ape_mat.DataBindings.Clear()
        txt_ape_mat.DataBindings.Add(New System.Windows.Forms.Binding("Text", bs_trabajadores, "PE_APE_mAT", True))
        txt_nom.DataBindings.Clear()
        txt_nom.DataBindings.Add(New System.Windows.Forms.Binding("Text", bs_trabajadores, "NOMBRES", True))

        bs_trabajadores.MoveFirst()
        bs_trabajadores.MoveNext()
        bs_trabajadores.MoveFirst()

        personalBE = Nothing
        personalBL = Nothing

        If txt_idpersonal.Text.Trim.Length > 0 Then
            'Call Obtener_Boleta_Trabajador(txt_idpersonal.Text.Trim)
        End If
        txt_nombres.Text = txt_ape_pat.Text.Trim + " " + txt_ape_mat.Text.Trim + " " + txt_nom.Text.Trim

    End Sub

    Private Sub bs_trabajadores_PositionChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles bs_trabajadores.PositionChanged
        txt_nombres.Text = txt_ape_pat.Text.Trim + " " + txt_ape_mat.Text.Trim + " " + txt_nom.Text.Trim
    End Sub

    Private Sub uce_TipoPersonal_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles uce_TipoPersonal.ValueChanged
        If uce_TipoPersonal.SelectedIndex <> -1 Then
            Call Cargar_Trabajadores_bs()
        End If
    End Sub


    Private Sub txt_nombres_EditorButtonClick(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinEditors.EditorButtonEventArgs) Handles txt_nombres.EditorButtonClick
        Select Case e.Button.Key
            Case "btn_ant"
                If bs_trabajadores.Position - 1 >= 0 Then
                    bs_trabajadores.MovePrevious()
                Else
                    bs_trabajadores.MoveLast()
                End If
            Case "btn_sig"
                If bs_trabajadores.Position + 1 < bs_trabajadores.Count Then
                    bs_trabajadores.MoveNext()
                Else
                    bs_trabajadores.MoveFirst()
                End If
            Case "btn_refrescar"
                If uce_TipoPersonal.SelectedIndex <> -1 Then
                    Call Cargar_Trabajadores_bs()
                End If
        End Select
    End Sub

    Private Sub Tool_Salir_Click(sender As System.Object, e As System.EventArgs) Handles Tool_Salir.Click
        Me.Close()
    End Sub

    Private Sub Tool_Reporte_Click(sender As System.Object, e As System.EventArgs) Handles Tool_Reporte.Click
        Dim ls_importes As New List(Of Double)
        Dim dt_personal As DataTable = Nothing
        Dim dt_tmp As New DataTable

        dt_tmp.Columns.Add("COD_PER", Type.GetType("System.String"))
        dt_tmp.NewRow("COD_PER") = "Prueba"

        Dim calculosBL As New BL.PlanillaBL.Calculos

        Dim empresaBL As New BL.ContabilidadBL.SG_CO_TB_EMPRESA
        Dim empresaBE As New BE.ContabilidadBE.SG_CO_TB_EMPRESA
        empresaBE.EM_ID = gInt_IdEmpresa
        empresaBL.getEmpresas_2(empresaBE)

        Dim personalBL As New BL.PlanillaBL.SG_PL_TB_PERSONAL
        Dim personalBE As New BE.PlanillaBE.SG_PL_TB_PERSONAL


        personalBE.PE_ID_TIPO_PER = uce_TipoPersonal.Value
        personalBE.PE_AFECTO_QUINTA = 0 '(0= no solo activos)
        personalBE.PE_ID = txt_idpersonal.Text.Trim
        personalBE.PE_ID_EMPRESA = gInt_IdEmpresa

        personalBL.getPersonal_x_Id(personalBE)


        dt_personal = personalBL.getPersonal_x_Tipo_x_IdPersonal(personalBE)


        Dim bancoBL As New BL.ContabilidadBL.SG_CO_TB_BANCO
        Dim bancoBE As New BE.ContabilidadBE.SG_CO_TB_BANCO
        bancoBE.BA_ID = personalBE.PE_ID_BANCO_CTS
        bancoBL.getBanco(bancoBE)

        Dim periodo As String = String.Empty

        Select Case uce_Mes.Value
            Case 5
                periodo = "DEL 01/11/" & (une_ayo.Value - 1) & " AL 30/04/" & (une_ayo.Value).ToString
            Case 11
                periodo = "DEL 01/05/" & (une_ayo.Value).ToString & " AL 31/10/" & une_ayo.Value.ToString
        End Select



        ls_importes = calculosBL.get_Cts_x_Personal(personalBE, une_ayo.Value, uce_Mes.Value)


        Dim tc As Double = ume_tc.Value

        Dim equivalente As Double = 0
        Dim texto_equivalent As String = ""
        If personalBE.PE_ID_MONEDA_CTS = 2 Then
            If tc = 0 Then
                Avisar("Ingrese el tipo de cambio")
                ume_tc.Focus()
                Exit Sub
            End If

            equivalente = Math.Round(ls_importes(7) / tc, 2)
            texto_equivalent = "T.C. : S/. " & tc.ToString & " EQUIVALENTE US$ " & equivalente.ToString

        End If

        Dim total_remu_rep As Double = 0
        Dim representante As String = "DR. RAFAEL ASCENZO APARICIO"
        Dim nombre_rep As String = "\SG_PL_24.rpt"
        Dim titulo As String = "0"

        If gInt_IdEmpresa <> 1 Then
            representante = empresaBE.EM_REPRESENTANTE
            nombre_rep = "\SG_PL_24_2.rpt"
        End If

        If personalBE.PE_ID_TIPO_PER = 1 Then
            total_remu_rep = ls_importes(0) + ls_importes(1) + ls_importes(4) + ls_importes(9) + ls_importes(2) + ls_importes(11)
            'total_remu_rep = ls_importes(0) + ls_importes(4) + ls_importes(4) + ls_importes(9) + ls_importes(2) + ls_importes(11)
        Else
            total_remu_rep = (ls_importes(0) / ls_importes(6)) + (ls_importes(1) / ls_importes(6)) + ls_importes(9) '+ ls_importes(5)
        End If

        Dim horExtras As Double = 0
        Dim texto As String = String.Empty

        Select Case personalBE.PE_ID_EMPRESA
            Case 3, 4, 5
                'aqui va "promedio variable" + "compensacion vacacional"(LO SUMO EN LA DLL)
                horExtras = ls_importes(8)
                texto = "Promedio Variable"
            Case Else
                horExtras = ls_importes(3)
                texto = "Promedio de Horas Extras"
        End Select

        Me.Cursor = Cursors.WaitCursor
        If gInt_IdEmpresa <> 1 Then
            Using crystalBL As New LR.ClsReporte
                crystalBL.Muestra_Reporte(gStr_RutaRep & nombre_rep, dt_tmp, "", _
                "pEmp;" & gStr_NomEmpresa, _
                "pDir;" & empresaBE.EM_DIR1, _
                "pRuc;" & empresaBE.EM_RUC, _
                "pFecDep;" & ume_fecha.Text, _
                "pApe;" & personalBE.PE_APE_PAT & " " & personalBE.PE_APE_MAT & " " & personalBE.PE_NOM_PRI & " " & personalBE.PE_NOM_SEG, _
                "pPeriodo;" & periodo, _
                "pFecIng;" & personalBE.PE_FEC_ING, _
                "pMoneda;" & IIf(personalBE.PE_ID_MONEDA_CTS = 1, "NUEVOS SOLES", "EXTRANJERA US$(DOLARES AMERICANOS)"), _
                "pEntidad;" & bancoBE.BA_NOMBRE, _
                "pTipoDep;EN EFECTIVO", _
                "pTotRemu;" & total_remu_rep, _
                "pProGra;" & ls_importes(5), _
                "pHorExt;" & horExtras, _
                "pTotCom;" & ls_importes(10), _
                "pAyos;0", _
                "pMeses;" & ls_importes(6), _
                "pDias;0", _
                "pTieCom;" & ls_importes(7), _
                "pTipCam;" & tc, _
                "pEqui;" & equivalente, _
                "pLetras;" & IIf(personalBE.PE_ID_MONEDA_CTS = 2, Letras(equivalente).ToUpper & " DOLARES AMERICANOS", Letras(ls_importes(7)).ToUpper & " NUEVOS SOLES"), _
                "pRepre;" & representante, _
                "pTextoEqui;" & texto_equivalent, "pBol_Titulo;" & titulo, "pNomEmpresa;" & gStr_NomEmpresa, "Ptexto1;" & texto)

            End Using
        Else

            Using crystalBL As New LR.ClsReporte
                crystalBL.Muestra_Reporte(gStr_RutaRep & nombre_rep, dt_tmp, "", _
                "pEmp;" & gStr_NomEmpresa, _
                "pDir;" & empresaBE.EM_DIR1, _
                "pRuc;" & empresaBE.EM_RUC, _
                "pFecDep;" & ume_fecha.Text, _
                "pApe;" & personalBE.PE_APE_PAT & " " & personalBE.PE_APE_MAT & " " & personalBE.PE_NOM_PRI & " " & personalBE.PE_NOM_SEG, _
                "pPeriodo;" & periodo, _
                "pFecIng;" & personalBE.PE_FEC_ING, _
                "pMoneda;" & IIf(personalBE.PE_ID_MONEDA_CTS = 1, "NUEVOS SOLES", "EXTRANJERA US$(DOLARES AMERICANOS)"), _
                "pEntidad;" & bancoBE.BA_NOMBRE, _
                "pTipoDep;EN EFECTIVO", _
                "pTotRemu;" & total_remu_rep, _
                "pProGra;" & ls_importes(5), _
                "pHorExt;" & horExtras, _
                "pTotCom;" & ls_importes(10), _
                "pAyos;0", _
                "pMeses;" & ls_importes(6), _
                "pDias;0", _
                "pTieCom;" & ls_importes(7), _
                "pTipCam;" & tc, _
                "pEqui;" & equivalente, _
                "pLetras;" & IIf(personalBE.PE_ID_MONEDA_CTS = 2, Letras(equivalente).ToUpper & " DOLARES AMERICANOS", Letras(ls_importes(7)).ToUpper & " NUEVOS SOLES"), _
                "pRepre;" & representante, _
                "pTextoEqui;" & texto_equivalent, "pBol_Titulo;" & titulo, "pNomEmpresa;" & gStr_NomEmpresa)

            End Using
        End If




        empresaBL = Nothing
        empresaBE = Nothing

        calculosBL = Nothing

        personalBL = Nothing
        personalBE = Nothing

        bancoBL = Nothing
        bancoBE = Nothing

        Me.Cursor = Cursors.Default

    End Sub

    Private Sub txt_codper_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_codper.KeyDown
        If e.KeyCode = Keys.F2 Then
            Call Mostrar_Ayuda_ListaPersonal()
        End If
    End Sub

    Private Sub Mostrar_Ayuda_ListaPersonal()
        PL_PR_Lista_Personal.Int_tipo_Personal = uce_TipoPersonal.Value
        PL_PR_Lista_Personal.Bol_habilitar_uos = False
        PL_PR_Lista_Personal.Bol_MultiSeleccion = False
        PL_PR_Lista_Personal.ShowDialog()

        If PL_PR_Lista_Personal.Bol_Aceptar Then
            Dim matriz As New List(Of BE.PlanillaBE.SG_PL_TB_PERSONAL)
            matriz = PL_PR_Lista_Personal.lista_empleados
            If matriz.Count > 0 Then
                txt_codper.Text = matriz(0).PE_CODIGO
                txt_nombres.Text = matriz(0).PE_APE_PAT & " " & matriz(0).PE_APE_MAT & " " & matriz(0).PE_NOM_PRI
                txt_idpersonal.Text = matriz(0).PE_ID
                'Call Cargar_Boleta_Trabajador("A", matriz(0).PE_ID)
            End If
        End If
    End Sub

    Private Sub txt_codper_EditorButtonClick(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinEditors.EditorButtonEventArgs) Handles txt_codper.EditorButtonClick
        Call Mostrar_Ayuda_ListaPersonal()
    End Sub

End Class