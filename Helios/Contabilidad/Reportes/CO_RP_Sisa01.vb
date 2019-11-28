Public Class CO_RP_Sisa01

    Private Sub CO_RP_Sisa01_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call Cargar_Medicos()
    End Sub

    Private Sub Cargar_Medicos()
        Dim interfaceBL As New BL.ContabilidadBL.Consultas
        uce_medico.DataSource = interfaceBL.get_Medicos(gInt_IdEmpresa)
        uce_medico.DisplayMember = "ME_NOMBRES"
        uce_medico.ValueMember = "ME_CODIGO"
        interfaceBL = Nothing
    End Sub

    Private Sub Tool_salir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_salir.Click
        Me.Close()
    End Sub

    Private Sub Tool_imprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_imprimir.Click

        If Not uchk_todos.Checked Then
            If uce_medico.SelectedIndex = -1 Then
                Avisar("Seleccione un medico")
                uce_medico.Focus()
                Exit Sub
            End If
        End If

        'Me.Cursor = Cursors.WaitCursor
        'Dim interfaceBL As New BL.ContabilidadBL.Consultas
        'Dim dt_tmp As DataTable = Nothing
        'Dim str_nom_rep As String = IIf(uchk_presta.Checked, "SG_CO_47_1.RPT", "SG_CO_47.RPT")
        'Dim ObjReporte As New LR.ClsReporte
        'Dim fechas As String = "Desde " & udte_f1.Value & " al " & udte_f2.Value

        'If uchk_todos.Checked Then
        '    str_nom_rep = "SG_CO_47_2.RPT"
        '    dt_tmp = interfaceBL.get_Sisa02(CDate(udte_f1.Value).ToShortDateString, CDate(udte_f2.Value).ToShortDateString)
        'Else
        '    dt_tmp = interfaceBL.get_Sisa01(uce_medico.Value, CDate(udte_f1.Value).ToShortDateString, CDate(udte_f2.Value).ToShortDateString)
        'End If


        'ObjReporte.Muestra_Reporte(String.Format("{0}\{1}", gStr_RutaRep, str_nom_rep), dt_tmp, "", "pFechas;" & fechas, "pMedico;" & uce_medico.Text)
        'ObjReporte.Dispose()
        'dt_tmp.Dispose()
        'interfaceBL = Nothing

        'Me.Cursor = Cursors.Default

        Dim obr As New BL.FacturacionBL.SG_FA_Reportes
        Me.Cursor = Cursors.WaitCursor
        Dim obj As New DataTable
        obj = obr.get_Atencion_comprobantes(gInt_IdEmpresa, udte_f1.Text, udte_f2.Text, IIf(uchk_todos.Checked = False, uce_medico.Value, ""))

        Dim nom_reporte As String = "SG_SI_01.RPT"
        If uchk_presta.Checked = True Then
            nom_reporte = "SG_SI_01.RPT"
        Else
            nom_reporte = "SG_SI_01_2.RPT"
        End If
        Dim crystalBL As New LR.ClsReporte
        Dim dt_data As New DataTable
        dt_data = obj
        Dim MedicoD As String
        If uchk_todos.Checked = True Then
            MedicoD = "Todos los Medicos"
        Else
            MedicoD = uce_medico.Text
        End If
        crystalBL.Muestra_Reporte(gStr_RutaRep & "\" & nom_reporte, dt_data, "", "pFecha1;" & udte_f1.Text, "pFecha2;" & udte_f2.Text, "pMedico;" & MedicoD)


        crystalBL = Nothing
        ' reportesBL = Nothing

        Me.Cursor = Cursors.Default

    End Sub

    Private Sub Tool_exportar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_exportar.Click
        If Not uchk_todos.Checked Then
            If uce_medico.SelectedIndex = -1 Then
                Avisar("Seleccione un medico")
                uce_medico.Focus()
                Exit Sub
            End If
        End If

        'Dim obj As New DataTable
        Dim obr As New BL.FacturacionBL.SG_FA_Reportes
        If uchk_presta.Checked Then
            ug_Lista.DataSource = obr.get_Atencion_comprobantes(gInt_IdEmpresa, udte_f1.Text, udte_f2.Text, IIf(uchk_todos.Checked = False, uce_medico.Value, ""))
        Else
            ug_Lista2.DataSource = obr.get_Atencion_comprobantes(gInt_IdEmpresa, udte_f1.Text, udte_f2.Text, IIf(uchk_todos.Checked = False, uce_medico.Value, ""))
        End If


        ' Dim interfaceBL As New BL.ContabilidadBL.Consultas

        'ug_data.DataSource = Nothing
        'ug_data_agru_pres.DataSource = Nothing

        'If uchk_presta.Checked Then
        '    ug_data_agru_pres.DataSource = interfaceBL.get_Sisa01(uce_medico.Value, CDate(udte_f1.Value).ToShortDateString, CDate(udte_f2.Value).ToShortDateString)
        'Else
        '    ug_data.DataSource = interfaceBL.get_Sisa01(uce_medico.Value, CDate(udte_f1.Value).ToShortDateString, CDate(udte_f2.Value).ToShortDateString)
        'End If

        'interfaceBL = Nothing

        Dim str_nombre_arc_exc As String = "Facturas " & Date.Now.Day & Date.Now.Month & Date.Now.Year & Date.Now.Hour & Date.Now.Minute & Date.Now.Second & ".xls"

        Try
            Me.Cursor = Cursors.WaitCursor
            If uchk_presta.Checked Then
                uge_detra.Export(ug_Lista, str_nombre_arc_exc)
            Else
                uge_detra.Export(ug_Lista2, str_nombre_arc_exc)
            End If

            Process.Start(str_nombre_arc_exc)
            Me.Cursor = Cursors.Default
        Catch ex As Exception
            Call Avisar("Ocurrio un error.")
            Me.Cursor = Cursors.Default
        End Try

    End Sub

    Private Sub uchk_todos_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles uchk_todos.CheckedChanged
        uce_medico.Enabled = Not uchk_todos.Checked
    End Sub

    Private Sub ug_Lista_InitializeGroupByRow(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.InitializeGroupByRowEventArgs) Handles ug_Lista.InitializeGroupByRow
        e.Row.Expanded = True
        If (e.Row.ChildBands.Count > 0) Then
            e.Row.ChildBands(0).Rows.ExpandAll(True)
            'e.Row.ChildBands(0).Rows.CollapseAll(True)
        End If

    End Sub

    Private Sub ug_Lista2_InitializeGroupByRow(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.InitializeGroupByRowEventArgs) Handles ug_Lista2.InitializeGroupByRow
        e.Row.Expanded = True
        If (e.Row.ChildBands.Count > 0) Then
            e.Row.ChildBands(0).Rows.ExpandAll(True)
            'e.Row.ChildBands(0).Rows.CollapseAll(True)
        End If

    End Sub

End Class