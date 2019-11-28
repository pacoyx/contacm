Imports Infragistics.Win.UltraWinGrid

Public Class PL_PR_Mantenimiento

    Dim str_ruc As String = ""

    Private Sub PL_PR_Mantenimiento_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'cargamos el periodo
        Call CargarCombo_ConMeses(uce_Mes)
        une_Ayo.Value = gDat_Fecha_Sis.Year
        uce_Mes.Value = gDat_Fecha_Sis.Month

        Call Cargar_TipoPersonal()

        'cargamos la lista de trabajadores
        Call Cargar_Trabajadores_bs()

        'Call Formatear_Grilla_Selector(ug_haberes)
        'Call Formatear_Grilla_Selector(ug_descuentos)
        'Call Formatear_Grilla_Selector(ug_aportaciones)


        'cargamos el ruc de la empresa actual para no demorar en el reporte
        Dim empresaBE As New BE.ContabilidadBE.SG_CO_TB_EMPRESA With {.EM_ID = gInt_IdEmpresa}
        Dim empresaBL As New BL.ContabilidadBL.SG_CO_TB_EMPRESA
        empresaBL.getEmpresas_2(empresaBE)

        str_ruc = empresaBE.EM_RUC

        empresaBE = Nothing
        empresaBL = Nothing

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

        Call LimpiaGrid(ug_haberes, uds_haberes)
        Call LimpiaGrid(ug_descuentos, uds_descuentos)
        Call LimpiaGrid(ug_aportaciones, uds_aportaciones)

        If txt_idpersonal.Text.Trim.Length > 0 Then
            Call Obtener_Boleta_Trabajador(txt_idpersonal.Text.Trim)
        End If







    End Sub

    Private Sub Cargar_Boleta_Trabajador(ByVal tipo As String, ByVal codigo_trabajador As Integer)

        Dim int_IdPersonal As Integer = 0

        If codigo_trabajador = 0 Then
            Select Case tipo
                Case "A"

                    If bs_trabajadores.Position - 1 >= 0 Then
                        bs_trabajadores.MovePrevious()
                    Else
                        bs_trabajadores.MoveLast()
                    End If

                Case "S"

                    If bs_trabajadores.Position + 1 < bs_trabajadores.Count Then
                        bs_trabajadores.MoveNext()
                    Else
                        bs_trabajadores.MoveFirst()
                    End If

            End Select

            If txt_idpersonal.Text.Trim = String.Empty Then
                Exit Sub
            End If
            int_IdPersonal = txt_idpersonal.Text.Trim

        Else
            int_IdPersonal = codigo_trabajador
            Dim item As Integer = bs_trabajadores.Find("PE_ID", codigo_trabajador)
            bs_trabajadores.Position = item
        End If

        Call Obtener_Boleta_Trabajador(int_IdPersonal)

    End Sub

    Private Sub Obtener_Boleta_Trabajador(ByVal int_IdPersonal As Integer)

        Dim histoBL As New BL.PlanillaBL.SG_PL_TB_HISTORIAL
        Dim histoBE As New BE.PlanillaBE.SG_PL_TB_HISTORIAL
        Dim ds_historial As DataSet

        histoBE.HI_FEC_OPE = une_Ayo.Value
        histoBE.HI_MES = uce_Mes.Value
        histoBE.HI_ID_EMPRESA = New BE.ContabilidadBE.SG_CO_TB_EMPRESA With {.EM_ID = gInt_IdEmpresa}
        histoBE.HI_ID_PERSONAL = New BE.PlanillaBE.SG_PL_TB_PERSONAL With {.PE_ID = int_IdPersonal}

        ds_historial = histoBL.get_Consulta_Boleta_Mantenimiento(histoBE)


        ug_haberes.DataSource = ds_historial.Tables(0)
        ug_descuentos.DataSource = ds_historial.Tables(1)
        ug_aportaciones.DataSource = ds_historial.Tables(2)

        If ds_historial.Tables(0).Rows.Count > 0 Then uce_tot_hab.Value = ds_historial.Tables(0).Compute("sum(HI_MONTO)", "")
        If ds_historial.Tables(1).Rows.Count > 0 Then uce_tot_des.Value = ds_historial.Tables(1).Compute("sum(HI_MONTO)", "")
        If ds_historial.Tables(2).Rows.Count > 0 Then uce_tot_apo.Value = ds_historial.Tables(2).Compute("sum(HI_MONTO)", "")

        uce_neto.Value = uce_tot_hab.Value - uce_tot_des.Value


        histoBE = Nothing
        histoBL = Nothing


        For i As Integer = 0 To ug_haberes.Rows.Count - 1
            ug_haberes.Rows(i).Cells("HI_COD_HD").Activation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        Next

        For i As Integer = 0 To ug_descuentos.Rows.Count - 1
            ug_descuentos.Rows(i).Cells("HI_COD_HD").Activation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        Next

        For i As Integer = 0 To ug_aportaciones.Rows.Count - 1
            ug_aportaciones.Rows(i).Cells("HI_COD_HD").Activation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        Next

    End Sub

    Private Sub bs_trabajadores_PositionChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles bs_trabajadores.PositionChanged
        txt_nombres.Text = txt_ape_pat.Text.Trim + " " + txt_ape_mat.Text.Trim + " " + txt_nom.Text.Trim
    End Sub

    Private Sub Tool_Salir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_Salir.Click
        Me.Close()
    End Sub

    Private Sub ubtn_Buscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub


    Private Sub uce_Mes_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles uce_Mes.ValueChanged
        Try
            Call Obtener_Boleta_Trabajador(txt_idpersonal.Text)
        Catch ex As Exception

        End Try

    End Sub

    Private Sub txt_codper_EditorButtonClick(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinEditors.EditorButtonEventArgs) Handles txt_codper.EditorButtonClick
        Call Mostrar_Ayuda_ListaPersonal()
    End Sub

    Private Sub uce_TipoPersonal_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles uce_TipoPersonal.ValueChanged
        If uce_TipoPersonal.SelectedIndex <> -1 Then
            Call Cargar_Trabajadores_bs()
        End If
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
                Call Cargar_Boleta_Trabajador("A", matriz(0).PE_ID)
            End If
        End If
    End Sub

    Private Sub ug_haberes_BeforeRowsDeleted(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.BeforeRowsDeletedEventArgs) Handles ug_haberes.BeforeRowsDeleted
        e.DisplayPromptMsg = False
        If ug_haberes.ActiveRow.Cells("MONTO_ORI").Value.ToString <> "" Then
            e.Cancel = True
        End If
    End Sub

    Private Sub Tool_Grabar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_Grabar.Click

        If txt_idpersonal.Text.Trim.Length = 0 Then
            Avisar("El codigo de interno del personal no esta establecido")
            Exit Sub
        End If

        ug_haberes.UpdateData()
        For i As Integer = 0 To ug_haberes.Rows.Count - 1
            If ug_haberes.Rows(i).Cells("MONTO_ORI").Value.ToString = "" Then
                ug_haberes.Rows(i).Cells("MONTO_ORI").Value = 0
            End If
        Next


        ug_descuentos.UpdateData()
        For i As Integer = 0 To ug_descuentos.Rows.Count - 1
            If ug_descuentos.Rows(i).Cells("MONTO_ORI").Value.ToString = "" Then
                ug_descuentos.Rows(i).Cells("MONTO_ORI").Value = 0
            End If
        Next


        ug_aportaciones.UpdateData()
        For i As Integer = 0 To ug_aportaciones.Rows.Count - 1
            If ug_aportaciones.Rows(i).Cells("MONTO_ORI").Value.ToString = "" Then
                ug_aportaciones.Rows(i).Cells("MONTO_ORI").Value = 0
            End If
        Next





        'obtenemos informacion del personal
        Dim personalBL As New BL.PlanillaBL.SG_PL_TB_PERSONAL
        Dim personalBE As New BE.PlanillaBE.SG_PL_TB_PERSONAL With {.PE_ID = txt_idpersonal.Text.Trim, .PE_ID_EMPRESA = gInt_IdEmpresa}
        personalBL.getPersonal_x_Id(personalBE)


        'PRIMERO GRABAMOS LA INFO A FOLIOS
        Dim foliosBL As New BL.PlanillaBL.SG_PL_TB_FOLIO
        Dim folioBE As New BE.PlanillaBE.SG_PL_TB_FOLIO
        folioBE.FO_ID_PERSONA = personalBE
        folioBE.FO_ID_EMPRESA = New BE.ContabilidadBE.SG_CO_TB_EMPRESA With {.EM_ID = gInt_IdEmpresa}
        folioBE.FO_ANHO = une_Ayo.Value
        folioBE.FO_MES = uce_Mes.Value
        folioBE.FO_FECREG = Now.Date
        folioBE.FO_TERMINAL = Environment.MachineName
        folioBE.FO_USUARIO = String.Format("{0}-{1}", Environment.UserName, gStr_Usuario_Sis)

        Dim dt_folios As DataTable = foliosBL.get_Folios_x_IdPersonal_Dt(folioBE)
        ug_haberes.UpdateData()
        For i As Integer = 0 To ug_haberes.Rows.Count - 1
            With ug_haberes.Rows(i)
                If .Cells("HI_MONTO").Value.ToString <> .Cells("MONTO_ORI").Value.ToString Then
                    If .Cells("HI_MONTO").Value.ToString <> String.Empty Then

                        folioBE.FO_ID_CONCEPTO = New BE.PlanillaBE.SG_PL_TB_CONCEPTOS With {.CO_ID = ug_haberes.Rows(i).Cells("HI_COD_HD").Value}
                        folioBE.FO_VALOR = .Cells("HI_MONTO").Value

                        If dt_folios.Select("FO_ID_CONCEPTO = '" & .Cells("HI_COD_HD").Value & "'").Length > 0 Then
                            foliosBL.Update(folioBE)
                        Else
                            foliosBL.Insert(folioBE)
                        End If
                    End If
                End If
            End With
        Next


        For i As Integer = 0 To ug_descuentos.Rows.Count - 1
            With ug_descuentos.Rows(i)
                If .Cells("HI_MONTO").Value <> .Cells("MONTO_ORI").Value Then
                    If .Cells("HI_MONTO").Value.ToString <> String.Empty Then

                        folioBE.FO_ID_CONCEPTO = New BE.PlanillaBE.SG_PL_TB_CONCEPTOS With {.CO_ID = ug_descuentos.Rows(i).Cells("HI_COD_HD").Value}
                        folioBE.FO_VALOR = .Cells("HI_MONTO").Value

                        If dt_folios.Select("FO_ID_CONCEPTO = '" & .Cells("HI_COD_HD").Value & "'").Length > 0 Then
                            foliosBL.Update(folioBE)
                        Else
                            foliosBL.Insert(folioBE)
                        End If
                    End If
                End If
            End With
        Next


        For i As Integer = 0 To ug_aportaciones.Rows.Count - 1
            With ug_aportaciones.Rows(i)
                If .Cells("HI_MONTO").Value <> .Cells("MONTO_ORI").Value Then
                    If .Cells("HI_MONTO").Value.ToString <> String.Empty Then

                        folioBE.FO_ID_CONCEPTO = New BE.PlanillaBE.SG_PL_TB_CONCEPTOS With {.CO_ID = ug_aportaciones.Rows(i).Cells("HI_COD_HD").Value}
                        folioBE.FO_VALOR = .Cells("HI_MONTO").Value

                        If dt_folios.Select("FO_ID_CONCEPTO = '" & .Cells("HI_COD_HD").Value & "'").Length > 0 Then
                            foliosBL.Update(folioBE)
                        Else
                            foliosBL.Insert(folioBE)
                        End If
                    End If
                End If
            End With
        Next


        'cargamos los folios del mes
        Dim dt_Folio_Mes As DataTable = Nothing
        'cargamos los folios del mes

        folioBE.FO_ANHO = une_Ayo.Value
        folioBE.FO_MES = uce_Mes.Value
        folioBE.FO_ID_EMPRESA = New BE.ContabilidadBE.SG_CO_TB_EMPRESA With {.EM_ID = gInt_IdEmpresa}
        dt_Folio_Mes = foliosBL.get_Folio_del_Mes(folioBE)
        

        'Luego procesamos la planilla

        Dim ultimo_dia As Date = ObtenerUltimoDia("01/" & uce_Mes.Value.ToString.PadLeft(2, "0") & "/" & une_Ayo.Value.ToString)
        Call Liquida_Fin_de_Mes(personalBE, ultimo_dia, True, dt_Folio_Mes, True)


        folioBE = Nothing
        foliosBL = Nothing
        personalBE = Nothing
        personalBL = Nothing

        Call Obtener_Boleta_Trabajador(txt_idpersonal.Text.Trim)

        Me.Cursor = Cursors.Default

        Call Avisar("Listo!")

    End Sub

    Private Sub txt_nombres_EditorButtonClick(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinEditors.EditorButtonEventArgs) Handles txt_nombres.EditorButtonClick
        Select Case e.Button.Key
            Case "btn_ant"
                Cargar_Boleta_Trabajador("A", 0)
            Case "btn_sig"
                Cargar_Boleta_Trabajador("S", 0)
            Case "btn_refrescar"
                If uce_TipoPersonal.SelectedIndex <> -1 Then
                    Call Cargar_Trabajadores_bs()
                End If
        End Select
    End Sub

    Private Sub ug_descuentos_BeforeRowsDeleted(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.BeforeRowsDeletedEventArgs) Handles ug_descuentos.BeforeRowsDeleted
        e.DisplayPromptMsg = False
        If ug_descuentos.ActiveRow.Cells("MONTO_ORI").Value.ToString <> "" Then
            e.Cancel = True
        End If
    End Sub

    Private Sub ug_aportaciones_BeforeRowsDeleted(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.BeforeRowsDeletedEventArgs) Handles ug_aportaciones.BeforeRowsDeleted
        e.DisplayPromptMsg = False
        If ug_aportaciones.ActiveRow.Cells("MONTO_ORI").Value.ToString <> "" Then
            e.Cancel = True
        End If
    End Sub

    Private Sub ug_haberes_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles ug_haberes.KeyDown

        If ug_haberes.ActiveCell Is Nothing Then Exit Sub

        If e.KeyCode = Keys.F2 Then

            If ug_haberes.ActiveCell.Column.Index = 0 Then
                Dim conceptoBL As New BL.PlanillaBL.SG_PL_TB_CONCEPTOS
                PL_AY_Lista_Ayuda.Text = "Lista de Conceptos"
                PL_AY_Lista_Ayuda.Data = conceptoBL.get_Conceptos_Ayuda(New BE.ContabilidadBE.SG_CO_TB_EMPRESA With {.EM_ID = gInt_IdEmpresa})
                PL_AY_Lista_Ayuda.Bol_MultiSeleccion = False
                PL_AY_Lista_Ayuda.ShowDialog()

                If PL_AY_Lista_Ayuda.Bol_Aceptar Then
                    Dim lista_respuesta As List(Of BE.PlanillaBE.SG_PL_TB_MATRIZ_RESPUESTA)
                    lista_respuesta = PL_AY_Lista_Ayuda.Matriz
                    If lista_respuesta.Count > 0 Then
                        ug_haberes.ActiveRow.Cells("HI_COD_HD").Value = lista_respuesta(0).CODIGO
                        ug_haberes.ActiveRow.Cells("HI_DES_HD").Value = lista_respuesta(0).DESCRIPCION
                        ug_haberes.ActiveRow.Cells("HI_MONTO").Value = 0
                        ug_haberes.ActiveCell = ug_haberes.Rows(ug_haberes.ActiveRow.Index).Cells("HI_COD_HD")
                        'ug_haberes.PerformAction(UltraGridAction.NextCellByTab, False, False)

                        ug_haberes.UpdateData()
                        ug_haberes.ActiveCell = ug_haberes.Rows(ug_haberes.ActiveRow.Index).Cells("HI_MONTO")
                        ug_haberes.PerformAction(UltraGridAction.EnterEditMode)
                        'SendKeys.Send("F2")
                    End If
                End If
            End If


        End If

        If e.KeyCode = Keys.Enter Then
            With ug_haberes
                Select Case ug_haberes.ActiveRow.Cells(ug_haberes.ActiveCell.Column.Index).Column.Key
                    Case "HI_MONTO"
                        .PerformAction(UltraGridAction.NextCellByTab, False, False)
                    Case "HI_COD_HD"
                        .PerformAction(UltraGridAction.NextCellByTab, False, False)


                        Dim conceptoBL As New BL.PlanillaBL.SG_PL_TB_CONCEPTOS
                        Dim conceptoBE As New BE.PlanillaBE.SG_PL_TB_CONCEPTOS

                        conceptoBE.CO_ID = ug_haberes.ActiveRow.Cells("HI_COD_HD").Value.ToString
                        conceptoBE.CO_ID_EMPRESA = New BE.ContabilidadBE.SG_CO_TB_EMPRESA With {.EM_ID = gInt_IdEmpresa}
                        Dim dt_concepto As DataTable = conceptoBL.get_Conceptos_x_Id(conceptoBE)

                        If dt_concepto.Rows.Count > 0 Then
                            ug_haberes.ActiveRow.Cells("HI_DES_HD").Value = dt_concepto.Rows(0)("CO_DESCRIPCION")
                        End If

                        dt_concepto = Nothing
                        conceptoBE = Nothing
                        conceptoBL = Nothing
                        ug_haberes.UpdateData()
                        ug_haberes.ActiveCell = ug_haberes.Rows(ug_haberes.ActiveRow.Index).Cells("HI_MONTO")
                        ug_haberes.PerformAction(UltraGridAction.EnterEditMode)

                    Case Else
                        .PerformAction(UltraGridAction.NextCellByTab, False, False)
                End Select

            End With
        End If
    End Sub

    Private Sub ug_descuentos_BeforeRowUpdate(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinGrid.CancelableRowEventArgs) Handles ug_descuentos.BeforeRowUpdate
        Dim dbl_sumatoria As Double = 0
        For i As Integer = 0 To ug_descuentos.Rows.Count - 1
            If ug_descuentos.Rows(i).Cells("HI_MONTO").Value.ToString <> "" Then
                dbl_sumatoria = dbl_sumatoria + ug_descuentos.Rows(i).Cells("HI_MONTO").Value
            End If
        Next
        uce_tot_des.Value = dbl_sumatoria
        uce_neto.Value = uce_tot_hab.Value - uce_tot_des.Value
    End Sub

    Private Sub ug_descuentos_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles ug_descuentos.KeyDown
        If ug_descuentos.ActiveCell Is Nothing Then Exit Sub



        If e.KeyCode = Keys.F2 Then

            If ug_descuentos.ActiveCell.Column.Index = 0 Then
                Dim conceptoBL As New BL.PlanillaBL.SG_PL_TB_CONCEPTOS
                PL_AY_Lista_Ayuda.Text = "Lista de Conceptos"
                PL_AY_Lista_Ayuda.Data = conceptoBL.get_Conceptos_Ayuda(New BE.ContabilidadBE.SG_CO_TB_EMPRESA With {.EM_ID = gInt_IdEmpresa})
                PL_AY_Lista_Ayuda.Bol_MultiSeleccion = False
                PL_AY_Lista_Ayuda.ShowDialog()

                If PL_AY_Lista_Ayuda.Bol_Aceptar Then
                    Dim lista_respuesta As List(Of BE.PlanillaBE.SG_PL_TB_MATRIZ_RESPUESTA)
                    lista_respuesta = PL_AY_Lista_Ayuda.Matriz
                    If lista_respuesta.Count > 0 Then
                        ug_descuentos.ActiveRow.Cells("HI_COD_HD").Value = lista_respuesta(0).CODIGO
                        ug_descuentos.ActiveRow.Cells("HI_DES_HD").Value = lista_respuesta(0).DESCRIPCION
                        ug_descuentos.ActiveRow.Cells("HI_MONTO").Value = 0
                        ug_descuentos.ActiveCell = ug_descuentos.Rows(ug_descuentos.ActiveRow.Index).Cells("HI_COD_HD")
                        'ug_haberes.PerformAction(UltraGridAction.NextCellByTab, False, False)

                        ug_descuentos.UpdateData()
                        ug_descuentos.ActiveCell = ug_descuentos.Rows(ug_descuentos.ActiveRow.Index).Cells("HI_MONTO")
                        ug_descuentos.PerformAction(UltraGridAction.EnterEditMode)
                        'SendKeys.Send("F2")
                    End If
                End If
            End If


        End If

        If e.KeyCode = Keys.Enter Then
            With ug_descuentos
                Select Case ug_descuentos.ActiveRow.Cells(ug_descuentos.ActiveCell.Column.Index).Column.Key
                    Case "HI_MONTO"
                        .PerformAction(UltraGridAction.NextCellByTab, False, False)
                    Case "HI_COD_HD"
                        .PerformAction(UltraGridAction.NextCellByTab, False, False)
                        '.PerformAction(UltraGridAction.NextCellByTab, False, False)

                        Dim conceptoBL As New BL.PlanillaBL.SG_PL_TB_CONCEPTOS
                        Dim conceptoBE As New BE.PlanillaBE.SG_PL_TB_CONCEPTOS

                        conceptoBE.CO_ID = ug_descuentos.ActiveRow.Cells("HI_COD_HD").Value.ToString
                        conceptoBE.CO_ID_EMPRESA = New BE.ContabilidadBE.SG_CO_TB_EMPRESA With {.EM_ID = gInt_IdEmpresa}
                        Dim dt_concepto As DataTable = conceptoBL.get_Conceptos_x_Id(conceptoBE)

                        If dt_concepto.Rows.Count > 0 Then
                            ug_descuentos.ActiveRow.Cells("HI_DES_HD").Value = dt_concepto.Rows(0)("CO_DESCRIPCION")
                        End If

                        dt_concepto = Nothing
                        conceptoBE = Nothing
                        conceptoBL = Nothing

                        ug_descuentos.UpdateData()
                        ug_descuentos.ActiveCell = ug_descuentos.Rows(ug_descuentos.ActiveRow.Index).Cells("HI_MONTO")
                        ug_descuentos.PerformAction(UltraGridAction.EnterEditMode)

                    Case Else
                        .PerformAction(UltraGridAction.NextCellByTab, False, False)
                End Select

            End With
        End If
    End Sub

    Private Sub ug_aportaciones_BeforeRowUpdate(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinGrid.CancelableRowEventArgs) Handles ug_aportaciones.BeforeRowUpdate
        Dim dbl_sumatoria As Double = 0
        For i As Integer = 0 To ug_aportaciones.Rows.Count - 1
            If ug_aportaciones.Rows(i).Cells("HI_MONTO").Value.ToString <> "" Then
                dbl_sumatoria = dbl_sumatoria + ug_aportaciones.Rows(i).Cells("HI_MONTO").Value
            End If
        Next

        uce_tot_apo.Value = dbl_sumatoria
        uce_neto.Value = uce_tot_hab.Value - uce_tot_des.Value
    End Sub

    Private Sub ug_aportaciones_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles ug_aportaciones.KeyDown
        If ug_aportaciones.ActiveCell Is Nothing Then Exit Sub


        If e.KeyCode = Keys.F2 Then
            If ug_aportaciones.ActiveCell.Column.Index = 0 Then
                Dim conceptoBL As New BL.PlanillaBL.SG_PL_TB_CONCEPTOS
                PL_AY_Lista_Ayuda.Text = "Lista de Conceptos"
                PL_AY_Lista_Ayuda.Data = conceptoBL.get_Conceptos_Ayuda(New BE.ContabilidadBE.SG_CO_TB_EMPRESA With {.EM_ID = gInt_IdEmpresa})
                PL_AY_Lista_Ayuda.Bol_MultiSeleccion = False
                PL_AY_Lista_Ayuda.ShowDialog()

                If PL_AY_Lista_Ayuda.Bol_Aceptar Then
                    Dim lista_respuesta As List(Of BE.PlanillaBE.SG_PL_TB_MATRIZ_RESPUESTA)
                    lista_respuesta = PL_AY_Lista_Ayuda.Matriz
                    If lista_respuesta.Count > 0 Then
                        ug_aportaciones.ActiveRow.Cells("HI_COD_HD").Value = lista_respuesta(0).CODIGO
                        ug_aportaciones.ActiveRow.Cells("HI_DES_HD").Value = lista_respuesta(0).DESCRIPCION
                        ug_aportaciones.ActiveRow.Cells("HI_MONTO").Value = 0
                        ug_aportaciones.ActiveCell = ug_aportaciones.Rows(ug_aportaciones.ActiveRow.Index).Cells("HI_COD_HD")
                        'ug_haberes.PerformAction(UltraGridAction.NextCellByTab, False, False)

                        ug_aportaciones.UpdateData()
                        ug_aportaciones.ActiveCell = ug_aportaciones.Rows(ug_aportaciones.ActiveRow.Index).Cells("HI_MONTO")
                        ug_aportaciones.PerformAction(UltraGridAction.EnterEditMode)
                        'SendKeys.Send("F2")
                    End If
                End If
            End If
        End If


        If e.KeyCode = Keys.Enter Then
            With ug_aportaciones
                Select Case ug_aportaciones.ActiveRow.Cells(ug_aportaciones.ActiveCell.Column.Index).Column.Key
                    Case "HI_MONTO"
                        .PerformAction(UltraGridAction.NextCellByTab, False, False)
                    Case "HI_COD_HD"
                        .PerformAction(UltraGridAction.NextCellByTab, False, False)

                        Dim conceptoBL As New BL.PlanillaBL.SG_PL_TB_CONCEPTOS
                        Dim conceptoBE As New BE.PlanillaBE.SG_PL_TB_CONCEPTOS

                        conceptoBE.CO_ID = ug_aportaciones.ActiveRow.Cells("HI_COD_HD").Value.ToString
                        conceptoBE.CO_ID_EMPRESA = New BE.ContabilidadBE.SG_CO_TB_EMPRESA With {.EM_ID = gInt_IdEmpresa}
                        Dim dt_concepto As DataTable = conceptoBL.get_Conceptos_x_Id(conceptoBE)

                        If dt_concepto.Rows.Count > 0 Then
                            ug_aportaciones.ActiveRow.Cells("HI_DES_HD").Value = dt_concepto.Rows(0)("CO_DESCRIPCION")
                        End If

                        dt_concepto = Nothing
                        conceptoBE = Nothing
                        conceptoBL = Nothing

                        ug_aportaciones.UpdateData()
                        ug_aportaciones.ActiveCell = ug_aportaciones.Rows(ug_aportaciones.ActiveRow.Index).Cells("HI_MONTO")
                        ug_aportaciones.PerformAction(UltraGridAction.EnterEditMode)

                    Case Else
                        .PerformAction(UltraGridAction.NextCellByTab, False, False)
                End Select

            End With
        End If
    End Sub

    Private Sub ug_haberes_BeforeRowUpdate(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.CancelableRowEventArgs) Handles ug_haberes.BeforeRowUpdate
        Dim dbl_sumatoria As Double = 0
        For i As Integer = 0 To ug_haberes.Rows.Count - 1
            If ug_haberes.Rows(i).Cells("HI_MONTO").Value.ToString <> "" Then
                dbl_sumatoria = dbl_sumatoria + ug_haberes.Rows(i).Cells("HI_MONTO").Value
            End If
        Next
        uce_tot_hab.Value = dbl_sumatoria
        uce_neto.Value = uce_tot_hab.Value - uce_tot_des.Value
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
End Class