Public Class PL_PR_Calculo_5ta

    Private Sub PL_PR_Calculo_5ta_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        'cargamos el periodo
        Call CargarCombo_ConMeses(uce_Mes)
        une_Ayo.Value = gDat_Fecha_Sis.Year
        uce_Mes.Value = gDat_Fecha_Sis.Month

        uce_TipoPersonal.Enabled = False
        txt_codper.Enabled = False
        txt_nombres.Enabled = False

        Call Cargar_TipoPersonal()
        Call Formatear_Grilla_Selector(ug_5ta)

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

    Private Sub txt_codper_EditorButtonClick(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinEditors.EditorButtonEventArgs) Handles txt_codper.EditorButtonClick
        Call Mostrar_Ayuda_ListaPersonal()
    End Sub

    Private Sub Tool_Salir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_Salir.Click
        Me.Close()
    End Sub

    Private Sub Tool_Exportar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_Exportar.Click
        Me.Cursor = Cursors.WaitCursor
        uge_5ta.Export(ug_5ta, "5ta_1" & Date.Now.Minute.ToString & ".xls")
        Process.Start("5ta_1" & Date.Now.Minute.ToString & ".xls")
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub uce_TipoPersonal_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles uce_TipoPersonal.ValueChanged
        txt_codper.Text = String.Empty
        txt_nombres.Text = String.Empty
    End Sub

    Private Sub Tool_Procesar_Click(sender As System.Object, e As System.EventArgs) Handles Tool_Procesar.Click


        If uchk_Todos.Checked Then

            Dim personalBE As New BE.PlanillaBE.SG_PL_TB_PERSONAL With {.PE_ID_EMPRESA = gInt_IdEmpresa}
            Dim personalBL As New BL.PlanillaBL.SG_PL_TB_PERSONAL

            personalBE.PE_ID_TIPO_PER = 1
            personalBE.PE_AFECTO_QUINTA = 0
            personalBE.PE_ID_EMPRESA = gInt_IdEmpresa
            Dim dt_personal As DataTable = personalBL.getPersonal_x_Tipo(personalBE)
            Dim quintaBL As New BL.PlanillaBL.Calculos


            Call LimpiaGrid(ug_5ta, uds_Lista)
            For i As Integer = 0 To dt_personal.Rows.Count - 1
                personalBE.PE_ID = dt_personal.Rows(i)("PE_ID")
                personalBL.getPersonal_x_Id(personalBE)

                Dim dbl_imp_qinta As Double = quintaBL.get_Dsto_5taCat(personalBE, une_Ayo.Value, uce_Mes.Value)

                ug_5ta.DisplayLayout.Bands(0).AddNew()
                ug_5ta.Rows(i).Cells("CODIGO").Value = personalBE.PE_CODIGO
                ug_5ta.Rows(i).Cells("NOMBRES").Value = personalBE.PE_APE_PAT & " " & personalBE.PE_APE_MAT & " " & personalBE.PE_NOM_PRI & " " & personalBE.PE_NOM_SEG
                ug_5ta.Rows(i).Cells("VALOR").Value = dbl_imp_qinta

            Next

            quintaBL = Nothing


        Else



            Dim personalBE As New BE.PlanillaBE.SG_PL_TB_PERSONAL With {.PE_ID = txt_idpersonal.Text, .PE_ID_EMPRESA = gInt_IdEmpresa}
            Dim personalBL As New BL.PlanillaBL.SG_PL_TB_PERSONAL
            personalBL.getPersonal_x_Id(personalBE)


            Dim quintaBL As New BL.PlanillaBL.Calculos
            Dim dbl_imp_qinta As Double = quintaBL.get_Dsto_5taCat(personalBE, une_Ayo.Value, uce_Mes.Value)

            Call LimpiaGrid(ug_5ta, uds_Lista)
            ug_5ta.DisplayLayout.Bands(0).AddNew()
            ug_5ta.Rows(0).Cells("CODIGO").Value = personalBE.PE_CODIGO
            ug_5ta.Rows(0).Cells("NOMBRES").Value = personalBE.PE_APE_PAT & " " & personalBE.PE_APE_MAT & " " & personalBE.PE_NOM_PRI & " " & personalBE.PE_NOM_SEG
            ug_5ta.Rows(0).Cells("VALOR").Value = dbl_imp_qinta

            'Avisar(dbl_imp_qinta.ToString)

            quintaBL = Nothing

        End If

    End Sub

    Private Sub txt_codper_ValueChanged(sender As System.Object, e As System.EventArgs) Handles txt_codper.ValueChanged
        If txt_codper.Text.Trim.Length = 0 Then
            txt_nombres.Text = String.Empty
            txt_idpersonal.Text = String.Empty
        End If
    End Sub
End Class