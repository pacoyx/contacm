Imports Infragistics.Win.UltraWinGrid

Public Class PL_PR_Calculo_Cts

    Private Sub PL_PR_Calculo_Cts_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load


        'cargamos el periodo
        Call CargarCombo_ConMeses_Cts(uce_Mes)
        une_Ayo.Value = gDat_Fecha_Sis.Year
        uce_Mes.Value = gDat_Fecha_Sis.Month

        uce_TipoPersonal.Enabled = False
        txt_codper.Enabled = False
        txt_nombres.Enabled = False
        upb_1.Visible = False

        Call Cargar_TipoPersonal()
        Call Formatear_Grilla_Selector(ug_cts)

        txt_codper.ButtonsRight(0).Appearance.Image = My.Resources._104

    End Sub

    Private Sub Cargar_TipoPersonal()
        Dim tipoPersonalBL As New BL.PlanillaBL.SG_PL_TB_TIPO_PERSONAL
        uce_TipoPersonal.DataSource = tipoPersonalBL.getTipos()
        uce_TipoPersonal.ValueMember = "TP_ID"
        uce_TipoPersonal.DisplayMember = "TP_DESCRIPCION"
        tipoPersonalBL = Nothing
    End Sub

    Private Sub uchk_Todos_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles uchk_Todos.CheckedChanged
        uce_TipoPersonal.Enabled = Not uchk_Todos.Checked
        txt_codper.Enabled = Not uchk_Todos.Checked
        txt_nombres.Enabled = Not uchk_Todos.Checked
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
            End If
        End If
    End Sub

    Private Sub Tool_Procesar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_Procesar.Click


        If Not uchk_Todos.Checked Then
            If txt_idpersonal.Text.Trim = "" Then
                Avisar("Seleccione el personal para realizar el calculo")
                Exit Sub
            End If
        End If


        Dim calculosBL As New BL.PlanillaBL.Calculos
        Dim ls_importes As New List(Of Double)
        Dim dt_personal As DataTable = Nothing
        Dim personalBE As New BE.PlanillaBE.SG_PL_TB_PERSONAL
        Dim personalBL As New BL.PlanillaBL.SG_PL_TB_PERSONAL

        personalBE.PE_ID_EMPRESA = gInt_IdEmpresa


        

        If uchk_Todos.Checked Then
            dt_personal = personalBL.getPersonal_ParaCalculos(personalBE)
        Else
            personalBE.PE_ID_TIPO_PER = uce_TipoPersonal.Value
            personalBE.PE_AFECTO_QUINTA = 0 '(0= no solo activos)
            personalBE.PE_ID = txt_idpersonal.Text.Trim
            dt_personal = personalBL.getPersonal_x_Tipo_x_IdPersonal(personalBE)
        End If


        upb_1.Value = 0
        upb_1.Minimum = 0
        upb_1.Maximum = dt_personal.Rows.Count

        upb_1.Visible = True


        Me.Refresh()

        Call LimpiaGrid(ug_cts, uds_cts)

        Me.Cursor = Cursors.WaitCursor
        For i As Integer = 0 To dt_personal.Rows.Count - 1
            personalBE.PE_ID = dt_personal.Rows(i)("PE_ID")
            personalBL.getPersonal_x_Id(personalBE)


            If personalBE.PE_CALCULAR_CTS = 0 Then '1=calcular   ;    2=No calcular 
                GoTo siguiente
            End If



            ls_importes = calculosBL.get_Cts_x_Personal(personalBE, une_Ayo.Value, uce_Mes.Value)

            ug_cts.DisplayLayout.Bands(0).AddNew()
            ug_cts.Rows(ug_cts.Rows.Count - 1).Cells("PE_ID").Value = personalBE.PE_ID
            ug_cts.Rows(ug_cts.Rows.Count - 1).Cells("TIPO_PER").Value = personalBE.PE_ID_TIPO_PER
            ug_cts.Rows(ug_cts.Rows.Count - 1).Cells("COD_PER").Value = personalBE.PE_CODIGO
            ug_cts.Rows(ug_cts.Rows.Count - 1).Cells("NOM_PER").Value = personalBE.PE_APE_PAT & " " & personalBE.PE_APE_MAT & " " & personalBE.PE_NOM_PRI
            ug_cts.Rows(ug_cts.Rows.Count - 1).Cells("REMU_BASICA").Value = ls_importes(0)
            ug_cts.Rows(ug_cts.Rows.Count - 1).Cells("ASIG_FAMILIAR").Value = ls_importes(1)
            ug_cts.Rows(ug_cts.Rows.Count - 1).Cells("RIESGO_CAJA").Value = ls_importes(2)
            ug_cts.Rows(ug_cts.Rows.Count - 1).Cells("PROMEDIO_HE").Value = ls_importes(3)
            ug_cts.Rows(ug_cts.Rows.Count - 1).Cells("PROMEDIO_BONI").Value = ls_importes(4)
            ug_cts.Rows(ug_cts.Rows.Count - 1).Cells("ULTIMA_GRATI").Value = ls_importes(5)
            ug_cts.Rows(ug_cts.Rows.Count - 1).Cells("MESES_TRABAJADOS").Value = ls_importes(6)
            ug_cts.Rows(ug_cts.Rows.Count - 1).Cells("TOTAL_COMPU").Value = ls_importes(7)
            ug_cts.Rows(ug_cts.Rows.Count - 1).Cells("REMU_VAR").Value = ls_importes(8)
            ug_cts.Rows(ug_cts.Rows.Count - 1).Cells("REFRIGERIO").Value = ls_importes(9)
            ug_cts.Rows(ug_cts.Rows.Count - 1).Cells("SUBTOTAL").Value = ls_importes(10)
            ug_cts.Rows(ug_cts.Rows.Count - 1).Cells("ENCARGATURA").Value = ls_importes(11)



            ug_cts.UpdateData()
siguiente:
            upb_1.IncrementValue(1)
        Next

        ug_cts.Refresh()

        Me.Cursor = Cursors.Default

        upb_1.Value = 0
        upb_1.Visible = False


        Me.Refresh()

        ug_cts.Text = "CTS - Periodo : " & une_Ayo.Value.ToString & " - " & uce_Mes.Text

        calculosBL = Nothing
    End Sub

    Private Sub txt_codper_EditorButtonClick(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinEditors.EditorButtonEventArgs) Handles txt_codper.EditorButtonClick
        Call Mostrar_Ayuda_ListaPersonal()
    End Sub

    Private Sub Tool_Salir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_Salir.Click
        Me.Close()
    End Sub

    Private Sub uce_Mes_EditorButtonClick(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinEditors.EditorButtonEventArgs) Handles uce_Mes.EditorButtonClick
        Select Case e.Button.Key
            Case "btn_ant"

                If uce_Mes.Value > 1 Then
                    uce_Mes.Value -= 1
                End If

            Case "btn_sig"

                If uce_Mes.Value < 12 Then
                    uce_Mes.Value += 1
                End If

        End Select
    End Sub

    Private Sub Tool_Exportar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_Exportar.Click
        Me.Cursor = Cursors.WaitCursor
        UltraGridExcelExporter1.Export(ug_cts, "cts_1" & Date.Now.Minute.ToString & ".xls")
        Process.Start("cts_1" & Date.Now.Minute.ToString & ".xls")
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub ug_cts_InitializeLayout(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.InitializeLayoutEventArgs) Handles ug_cts.InitializeLayout
        If Not e.Layout.Bands(0).Summaries.Exists("sum_REMU_BASICA") Then
            Dim tt As SummarySettings
            tt = e.Layout.Bands(0).Summaries.Add("sum_REMU_BASICA", SummaryType.Sum, e.Layout.Bands(0).Columns("REMU_BASICA"), SummaryPosition.UseSummaryPositionColumn)
            tt.DisplayFormat = "{0:##,##0.00#}"
            tt.Appearance.TextHAlign = Infragistics.Win.HAlign.Right
            tt.SummaryDisplayArea = SummaryDisplayAreas.BottomFixed
        End If

        If Not e.Layout.Bands(0).Summaries.Exists("sum_ASIG_FAMILIAR") Then
            Dim tt As SummarySettings
            tt = e.Layout.Bands(0).Summaries.Add("sum_ASIG_FAMILIAR", SummaryType.Sum, e.Layout.Bands(0).Columns("ASIG_FAMILIAR"), SummaryPosition.UseSummaryPositionColumn)
            tt.DisplayFormat = "{0:##,##0.00#}"
            tt.Appearance.TextHAlign = Infragistics.Win.HAlign.Right
            tt.SummaryDisplayArea = SummaryDisplayAreas.BottomFixed
        End If

        If Not e.Layout.Bands(0).Summaries.Exists("sum_RIESGO_CAJA") Then
            Dim tt As SummarySettings
            tt = e.Layout.Bands(0).Summaries.Add("sum_RIESGO_CAJA", SummaryType.Sum, e.Layout.Bands(0).Columns("RIESGO_CAJA"), SummaryPosition.UseSummaryPositionColumn)
            tt.DisplayFormat = "{0:##,##0.00#}"
            tt.Appearance.TextHAlign = Infragistics.Win.HAlign.Right
            tt.SummaryDisplayArea = SummaryDisplayAreas.BottomFixed
        End If

        If Not e.Layout.Bands(0).Summaries.Exists("sum_PROMEDIO_HE") Then
            Dim tt As SummarySettings
            tt = e.Layout.Bands(0).Summaries.Add("sum_PROMEDIO_HE", SummaryType.Sum, e.Layout.Bands(0).Columns("PROMEDIO_HE"), SummaryPosition.UseSummaryPositionColumn)
            tt.DisplayFormat = "{0:##,##0.00#}"
            tt.Appearance.TextHAlign = Infragistics.Win.HAlign.Right
            tt.SummaryDisplayArea = SummaryDisplayAreas.BottomFixed
        End If

        If Not e.Layout.Bands(0).Summaries.Exists("sum_PROMEDIO_BONI") Then
            Dim tt As SummarySettings
            tt = e.Layout.Bands(0).Summaries.Add("sum_PROMEDIO_BONI", SummaryType.Sum, e.Layout.Bands(0).Columns("PROMEDIO_BONI"), SummaryPosition.UseSummaryPositionColumn)
            tt.DisplayFormat = "{0:##,##0.00#}"
            tt.Appearance.TextHAlign = Infragistics.Win.HAlign.Right
            tt.SummaryDisplayArea = SummaryDisplayAreas.BottomFixed
        End If

        If Not e.Layout.Bands(0).Summaries.Exists("sum_ULTIMA_GRATI") Then
            Dim tt As SummarySettings
            tt = e.Layout.Bands(0).Summaries.Add("sum_ULTIMA_GRATI", SummaryType.Sum, e.Layout.Bands(0).Columns("ULTIMA_GRATI"), SummaryPosition.UseSummaryPositionColumn)
            tt.DisplayFormat = "{0:##,##0.00#}"
            tt.Appearance.TextHAlign = Infragistics.Win.HAlign.Right
            tt.SummaryDisplayArea = SummaryDisplayAreas.BottomFixed
        End If


        If Not e.Layout.Bands(0).Summaries.Exists("sum_TOTAL_COMPU") Then
            Dim tt As SummarySettings
            tt = e.Layout.Bands(0).Summaries.Add("sum_TOTAL_COMPU", SummaryType.Sum, e.Layout.Bands(0).Columns("TOTAL_COMPU"), SummaryPosition.UseSummaryPositionColumn)
            tt.DisplayFormat = "{0:##,##0.00#}"
            tt.Appearance.TextHAlign = Infragistics.Win.HAlign.Right
            tt.SummaryDisplayArea = SummaryDisplayAreas.BottomFixed
        End If



        e.Layout.Bands(0).SummaryFooterCaption = "Totales"

    End Sub

    Private Sub uce_TipoPersonal_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles uce_TipoPersonal.ValueChanged
        txt_codper.Text = String.Empty
        txt_nombres.Text = String.Empty
    End Sub

    Private Sub Tool_Imprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_Imprimir.Click
        Dim dtt As DataTable = Ultragrid_to_DataTable(ug_cts)
        Dim str_periodo As String = "Periodo : " & une_Ayo.Value.ToString & " - " & uce_Mes.Text
        Me.Cursor = Cursors.WaitCursor
        Using crystalBL As New LR.ClsReporte
            crystalBL.Muestra_Reporte(gStr_RutaRep & "\sg_pl_10.rpt", dtt, "", "pEmp;" & gStr_NomEmpresa, "pPeriodo;" & str_periodo)
        End Using
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub Tool_Reporte_Cts_Click(sender As System.Object, e As System.EventArgs) Handles Tool_Reporte_Cts.Click


        If ug_cts.ActiveRow Is Nothing Then
            Avisar("Seleccione una fila en la grilla")
            Exit Sub
        End If


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
        personalBE.PE_ID = ug_cts.ActiveRow.Cells("PE_ID").Value
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
                periodo = "DEL 01/11/" & (une_Ayo.Value - 1) & " AL 31/05/" & (une_Ayo.Value).ToString
            Case 11
                periodo = "DEL 01/05/" & (une_Ayo.Value).ToString & " AL 31/05/" & une_Ayo.Value.ToString
        End Select


        ls_importes = calculosBL.get_Cts_x_Personal(personalBE, une_Ayo.Value, uce_Mes.Value)


        Dim tc As Double = 0
        Dim equivalente As Double = 0

        If personalBE.PE_ID_MONEDA_CTS = 2 Then
            tc = 0
            equivalente = ls_importes(7) / tc
        End If

        Me.Cursor = Cursors.WaitCursor
        Using crystalBL As New LR.ClsReporte
            crystalBL.Muestra_Reporte(gStr_RutaRep & "\SG_PL_24.rpt", dt_tmp, "", _
            "pEmp;" & gStr_NomEmpresa, _
            "pDir;" & empresaBE.EM_DIR1, _
            "pRuc;" & empresaBE.EM_RUC, _
            "pFecDep;01/01/2013", _
            "pApe;" & personalBE.PE_APE_PAT & " " & personalBE.PE_APE_MAT & " " & personalBE.PE_NOM_PRI & " " & personalBE.PE_NOM_SEG, _
            "pPeriodo;" & periodo, _
            "pFecIng;" & personalBE.PE_FEC_ING, _
            "pMoneda;" & IIf(personalBE.PE_ID_MONEDA_CTS = 1, "NUEVOS SOLES", "EXTRANJERA US$(DOLARES AMERICANOS)"), _
            "pEntidad;" & bancoBE.BA_NOMBRE, _
            "pTipoDep;EN EFECTIVO", _
            "pTotRemu;" & (ls_importes(0) + ls_importes(1)), _
            "pProGra;" & ls_importes(5), _
            "pHorExt;" & ls_importes(3), _
            "pTotCom;" & ls_importes(10), _
            "pAyos;0", _
            "pMeses;" & ls_importes(6), _
            "pDias;0", _
            "pTieCom;" & ls_importes(7), _
            "pTipCam;" & tc, _
            "pEqui;" & equivalente, _
            "pLetras;" & IIf(personalBE.PE_ID_MONEDA_CTS = 2, Letras(equivalente), Letras(ls_importes(7))))


        End Using
        Me.Cursor = Cursors.Default




    End Sub
End Class