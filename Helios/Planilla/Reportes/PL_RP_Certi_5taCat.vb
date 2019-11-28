Public Class PL_RP_Certi_5taCat

    Private Sub PL_RP_Certi_5taCat_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        une_ayo.Value = gDat_Fecha_Sis.Year
        Call Cargar_TipoPersonal()
        Call Cargar_Trabajadores_bs()
        Call Cargar_Iconos()
    End Sub

    Private Sub Cargar_Iconos()
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

    Private Sub Tool_Salir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_Salir.Click
        Me.Close()
    End Sub


    Private Sub Tool_Reporte_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_Reporte.Click

    End Sub
End Class