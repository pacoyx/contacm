Imports Infragistics.Win.UltraWinGrid

Public Class PL_PR_Folios

    Private Sub PL_PR_Folios_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call Cargar_Conceptos()
        Call Formatear_Grilla_Selector(ug_Folios)
        udte_fecha.Value = gDat_Fecha_Sis

        ubtn_previo.Appearance.Image = My.Resources._16__Db_previous_
        ubtn_siguiente.Appearance.Image = My.Resources._16__Db_next_

    End Sub

    Private Sub Verificar_Estado_Mes()

        Dim AdmMesBL As New BL.ContabilidadBL.SG_CO_TB_ADMMES
        Dim AdmMesBE As New BE.ContabilidadBE.SG_CO_TB_ADMMES

        With AdmMesBE
            .AM_ANHO = CDate(udte_fecha.Value).Year
            .AM_MES = CDate(udte_fecha.Value).Month
            .AM_IDEMPRESA = New BE.ContabilidadBE.SG_CO_TB_EMPRESA With {.EM_ID = gInt_IdEmpresa}
            .AM_MODULO = 3
        End With

        ug_Detalle.DisplayLayout.Bands(0).Columns("FO_VALOR").CellActivation = Activation.AllowEdit
        tool_agregar.Enabled = True
        Tool_agregar_ConValor.Enabled = True
        Tool_Eliminar.Enabled = True
        Tool_eliminar_todos.Enabled = True
        Tool_CargarFolio.Enabled = True

        If AdmMesBL.Esta_Cerrado_Mes(AdmMesBE) Then
            'Avisar("El mes esta cerrado." & Chr(13) & "Tiene que abrirlo antes.")
            ug_Detalle.DisplayLayout.Bands(0).Columns("FO_VALOR").CellActivation = Activation.NoEdit
            tool_agregar.Enabled = False
            Tool_agregar_ConValor.Enabled = False
            Tool_Eliminar.Enabled = False
            Tool_eliminar_todos.Enabled = False
            Tool_CargarFolio.Enabled = False

            AdmMesBL = Nothing
            AdmMesBE = Nothing
        End If

        AdmMesBL = Nothing
        AdmMesBE = Nothing

    End Sub

    Private Sub Cargar_Conceptos()
        Dim conceptoBL As New BL.PlanillaBL.SG_PL_TB_CONCEPTOS
        ug_Folios.DataSource = conceptoBL.get_Conceptos_Lista_Chica(New BE.ContabilidadBE.SG_CO_TB_EMPRESA With {.EM_ID = gInt_IdEmpresa})
        conceptoBL = Nothing
    End Sub

    Private Sub Tool_Salir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
    End Sub

    Private Sub ubtn_previo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ubtn_previo.Click
        udte_fecha.Value = CDate(udte_fecha.Value).AddMonths(-1)
        Call Cargar_Detalle_de_Folio()
    End Sub

    Private Sub ubtn_siguiente_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ubtn_siguiente.Click
        udte_fecha.Value = CDate(udte_fecha.Value).AddMonths(1)
        Call Cargar_Detalle_de_Folio()
    End Sub

    Private Sub ug_Folios_DoubleClickRow(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinGrid.DoubleClickRowEventArgs) Handles ug_Folios.DoubleClickRow
        'Call Cargar_Detalle_de_Folio()
    End Sub

    Private Sub Cargar_Detalle_de_Folio()
        Dim folioBL As New BL.PlanillaBL.SG_PL_TB_FOLIO
        Dim folioBE As New BE.PlanillaBE.SG_PL_TB_FOLIO
        folioBE.FO_ANHO = CDate(udte_fecha.Value).Year
        folioBE.FO_MES = CDate(udte_fecha.Value).Month
        folioBE.FO_ID_EMPRESA = New BE.ContabilidadBE.SG_CO_TB_EMPRESA With {.EM_ID = gInt_IdEmpresa}
        folioBE.FO_ID_CONCEPTO = New BE.PlanillaBE.SG_PL_TB_CONCEPTOS With {.CO_ID = ug_Folios.ActiveRow.Cells("CO_ID").Value}
        ug_Detalle.DataSource = folioBL.get_Folios(folioBE)
        lbl_titulo.Text = ug_Folios.ActiveRow.Cells("CO_DESCRIPCION").Value.ToString

        folioBE = Nothing
        folioBL = Nothing
    End Sub

    Private Function Existe_Personal_EnGrilla(ByVal Personal As String) As Boolean
        Existe_Personal_EnGrilla = False

        For i As Integer = 0 To ug_Detalle.Rows.Count - 1
            If ug_Detalle.Rows(i).Cells("PE_CODIGO").Value.ToString.Equals(Personal) Then
                Existe_Personal_EnGrilla = Not Existe_Personal_EnGrilla
                Exit For
            End If
        Next

    End Function

    Private Sub ug_Detalle_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles ug_Detalle.KeyDown
        If e.KeyCode = Keys.Enter Then

            ug_Detalle.UpdateData()

            Dim folioBL As New BL.PlanillaBL.SG_PL_TB_FOLIO
            Dim folioBE As BE.PlanillaBE.SG_PL_TB_FOLIO

            folioBE = New BE.PlanillaBE.SG_PL_TB_FOLIO()
            folioBE.FO_ANHO = CDate(udte_fecha.Value).Year
            folioBE.FO_MES = CDate(udte_fecha.Value).Month
            folioBE.FO_ID_PERSONA = New BE.PlanillaBE.SG_PL_TB_PERSONAL With {.PE_ID = ug_Detalle.ActiveRow.Cells("FO_ID_PERSONA").Value}
            folioBE.FO_ID_CONCEPTO = New BE.PlanillaBE.SG_PL_TB_CONCEPTOS With {.CO_ID = ug_Folios.ActiveRow.Cells("CO_ID").Value}
            folioBE.FO_VALOR = ug_Detalle.ActiveRow.Cells("FO_VALOR").Value
            folioBE.FO_ID_EMPRESA = New BE.ContabilidadBE.SG_CO_TB_EMPRESA With {.EM_ID = gInt_IdEmpresa}
            folioBE.FO_USUARIO = String.Format("{0}-{1}", Environment.UserName, gStr_Usuario_Sis)
            folioBE.FO_TERMINAL = Environment.MachineName
            folioBE.FO_FECREG = Date.Now

            folioBL.Update(folioBE)

            folioBL = Nothing
            folioBE = Nothing

            ug_Detalle.PerformAction(UltraGridAction.NextCellByTab, False, False)
            ug_Detalle.PerformAction(UltraGridAction.NextCellByTab, False, False)
            ug_Detalle.PerformAction(UltraGridAction.NextCellByTab, False, False)
            ug_Detalle.PerformAction(UltraGridAction.NextCellByTab, False, False)

            ug_Detalle.UpdateData()

        End If
    End Sub

    Private Sub ug_Detalle_BeforeRowsDeleted(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.BeforeRowsDeletedEventArgs) Handles ug_Detalle.BeforeRowsDeleted
        e.DisplayPromptMsg = False
    End Sub

    Private Sub ubtn_Grabar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Call Guardar_Datos()
        Call Avisar("Listo!")
    End Sub

    Private Sub Guardar_Datos()
        Dim folioBL As New BL.PlanillaBL.SG_PL_TB_FOLIO
        Dim folioBE As BE.PlanillaBE.SG_PL_TB_FOLIO

        folioBE = New BE.PlanillaBE.SG_PL_TB_FOLIO()
        folioBE.FO_ANHO = CDate(udte_fecha.Value).Year
        folioBE.FO_MES = CDate(udte_fecha.Value).Month
        folioBE.FO_ID_CONCEPTO = New BE.PlanillaBE.SG_PL_TB_CONCEPTOS With {.CO_ID = ug_Folios.ActiveRow.Cells("CO_ID").Value}
        folioBE.FO_ID_EMPRESA = New BE.ContabilidadBE.SG_CO_TB_EMPRESA With {.EM_ID = gInt_IdEmpresa}
        folioBL.Delete(folioBE)

        For i As Integer = 0 To ug_Detalle.Rows.Count - 1
            folioBE = New BE.PlanillaBE.SG_PL_TB_FOLIO()
            folioBE.FO_ANHO = CDate(udte_fecha.Value).Year
            folioBE.FO_MES = CDate(udte_fecha.Value).Month
            folioBE.FO_ID_PERSONA = New BE.PlanillaBE.SG_PL_TB_PERSONAL With {.PE_ID = ug_Detalle.Rows(i).Cells("FO_ID_PERSONA").Value}
            folioBE.FO_ID_CONCEPTO = New BE.PlanillaBE.SG_PL_TB_CONCEPTOS With {.CO_ID = ug_Folios.ActiveRow.Cells("CO_ID").Value}
            folioBE.FO_ID_EMPRESA = New BE.ContabilidadBE.SG_CO_TB_EMPRESA With {.EM_ID = gInt_IdEmpresa}
            folioBE.FO_VALOR = ug_Detalle.Rows(i).Cells("FO_VALOR").Value
            folioBE.FO_USUARIO = String.Format("{0}-{1}", Environment.UserName, gStr_Usuario_Sis)
            folioBE.FO_TERMINAL = Environment.MachineName
            folioBE.FO_FECREG = Date.Now
            folioBL.Insert(folioBE)
        Next

        folioBL = Nothing
        folioBE = Nothing

    End Sub

    Private Sub ug_Folios_AfterRowActivate(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ug_Folios.AfterRowActivate
        Call Cargar_Detalle_de_Folio()
    End Sub

    Private Sub ug_Folios_InitializeRow(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.InitializeRowEventArgs) Handles ug_Folios.InitializeRow
        If e.Row.Cells("CO_ID").Value.ToString.StartsWith("1") Then
            e.Row.Appearance.BackColor = Color.Beige
        End If

        If e.Row.Cells("CO_ID").Value.ToString.StartsWith("2") Then
            e.Row.Appearance.BackColor = Color.AliceBlue
        End If

        If e.Row.Cells("CO_ID").Value.ToString.StartsWith("3") Then
            e.Row.Appearance.BackColor = Color.LavenderBlush
        End If
    End Sub

    Private Sub ug_Detalle_ClickCellButton(sender As System.Object, e As Infragistics.Win.UltraWinGrid.CellEventArgs) Handles ug_Detalle.ClickCellButton
        Dim str_cod_per As String = e.Cell.Row.Cells("PE_CODIGO").Value

        PL_PR_Folio_Comprobante.str_cod_per = e.Cell.Row.Cells("PE_CODIGO").Value
        PL_PR_Folio_Comprobante.str_nom_per = e.Cell.Row.Cells("NOMBRES").Value
        PL_PR_Folio_Comprobante.int_idpersonal = e.Cell.Row.Cells("FO_ID_PERSONA").Value
        PL_PR_Folio_Comprobante.str_idfolio = ug_Folios.ActiveRow.Cells("CO_ID").Value
        PL_PR_Folio_Comprobante.str_desfolio = ug_Folios.ActiveRow.Cells("CO_DESCRIPCION").Value
        PL_PR_Folio_Comprobante.int_ayo = CDate(udte_fecha.Value).Year
        PL_PR_Folio_Comprobante.int_mes = CDate(udte_fecha.Value).Month
        PL_PR_Folio_Comprobante.ShowDialog()

    End Sub

    Private Sub ug_Detalle_InitializeRow(sender As System.Object, e As Infragistics.Win.UltraWinGrid.InitializeRowEventArgs) Handles ug_Detalle.InitializeRow
        e.Row.Cells("col_btn_doc").Value = ""
        e.Row.Cells("col_btn_doc").ButtonAppearance.Image = My.Resources.layout
        e.Row.Cells("col_btn_doc").ButtonAppearance.ImageHAlign = Infragistics.Win.HAlign.Center

    End Sub

    Private Sub Tool_Salir_Click_1(sender As System.Object, e As System.EventArgs) Handles Tool_Salir.Click
        Me.Close()
    End Sub

    Private Sub Tool_CargarFolio_Click(sender As System.Object, e As System.EventArgs) Handles Tool_CargarFolio.Click
        PL_PR_Folio_Cargas.fecha_a = CDate(udte_fecha.Value)
        PL_PR_Folio_Cargas.folio_destino = ug_Folios.ActiveRow.Cells("CO_ID").Value
        PL_PR_Folio_Cargas.ShowDialog()
        Call Cargar_Detalle_de_Folio()
    End Sub

    Private Sub tool_agregar_Click(sender As System.Object, e As System.EventArgs) Handles tool_agregar.Click
        'jalamos la lista de empleados con la ayuda
        PL_PR_Lista_Personal.Int_tipo_Personal = 0
        PL_PR_Lista_Personal.Bol_habilitar_uos = True
        PL_PR_Lista_Personal.Bol_MultiSeleccion = True
        PL_PR_Lista_Personal.ShowDialog()
        If PL_PR_Lista_Personal.Bol_Aceptar Then
            Dim matriz As New List(Of BE.PlanillaBE.SG_PL_TB_PERSONAL)
            matriz = PL_PR_Lista_Personal.lista_empleados
            If matriz.Count > 0 Then

                For Each empleado As BE.PlanillaBE.SG_PL_TB_PERSONAL In matriz
                    If Not Existe_Personal_EnGrilla(empleado.PE_CODIGO) Then
                        ug_Detalle.DisplayLayout.Bands(0).AddNew()
                        Dim fila As Integer = ug_Detalle.Rows.Count - 1
                        ug_Detalle.Rows(fila).Cells("FO_ID_PERSONA").Value = empleado.PE_ID
                        ug_Detalle.Rows(fila).Cells("PE_CODIGO").Value = empleado.PE_CODIGO
                        ug_Detalle.Rows(fila).Cells("NOMBRES").Value = empleado.PE_APE_PAT & " " & empleado.PE_APE_MAT & " " & empleado.PE_NOM_PRI
                        ug_Detalle.Rows(fila).Cells("FO_VALOR").Value = 0
                    End If
                Next
            End If
        End If

        ug_Detalle.UpdateData()

        Call Guardar_Datos()
        'luego de grabar a la grilla graba
    End Sub

    Private Sub Tool_agregar_ConValor_Click(sender As System.Object, e As System.EventArgs) Handles Tool_agregar_ConValor.Click
        'jalamos la lista de empleados con la ayuda

        PL_PR_Lista_Personal.Int_tipo_Personal = 0
        PL_PR_Lista_Personal.Bol_habilitar_uos = True
        PL_PR_Lista_Personal.Bol_MultiSeleccion = True
        PL_PR_Lista_Personal.ShowDialog()

        If PL_PR_Lista_Personal.Bol_Aceptar Then

            Dim valor_tmp As Double = InputBox("Ingrese Valor", "Folios", "0")

            Dim matriz As New List(Of BE.PlanillaBE.SG_PL_TB_PERSONAL)
            matriz = PL_PR_Lista_Personal.lista_empleados
            If matriz.Count > 0 Then

                For Each empleado As BE.PlanillaBE.SG_PL_TB_PERSONAL In matriz
                    If Not Existe_Personal_EnGrilla(empleado.PE_CODIGO) Then
                        ug_Detalle.DisplayLayout.Bands(0).AddNew()
                        Dim fila As Integer = ug_Detalle.Rows.Count - 1
                        ug_Detalle.Rows(fila).Cells("FO_ID_PERSONA").Value = empleado.PE_ID
                        ug_Detalle.Rows(fila).Cells("PE_CODIGO").Value = empleado.PE_CODIGO
                        ug_Detalle.Rows(fila).Cells("NOMBRES").Value = empleado.PE_APE_PAT & " " & empleado.PE_APE_MAT & " " & empleado.PE_NOM_PRI
                        ug_Detalle.Rows(fila).Cells("FO_VALOR").Value = valor_tmp
                    End If
                Next
            End If
        End If

        ug_Detalle.UpdateData()


        'luego de grabar a la grilla grabamos en la base de datos
        Call Guardar_Datos()
    End Sub

    Private Sub Tool_Eliminar_Click(sender As System.Object, e As System.EventArgs) Handles Tool_Eliminar.Click
        If ug_Detalle.ActiveRow Is Nothing Then Exit Sub
        If ug_Detalle.Rows.Count = 0 Then Exit Sub


        'borramos de la base de datos
        Dim folioBL As New BL.PlanillaBL.SG_PL_TB_FOLIO
        Dim folioBE As BE.PlanillaBE.SG_PL_TB_FOLIO

        folioBE = New BE.PlanillaBE.SG_PL_TB_FOLIO()
        folioBE.FO_ANHO = CDate(udte_fecha.Value).Year
        folioBE.FO_MES = CDate(udte_fecha.Value).Month
        folioBE.FO_ID_EMPRESA = New BE.ContabilidadBE.SG_CO_TB_EMPRESA With {.EM_ID = gInt_IdEmpresa}
        folioBE.FO_ID_CONCEPTO = New BE.PlanillaBE.SG_PL_TB_CONCEPTOS With {.CO_ID = ug_Folios.ActiveRow.Cells("CO_ID").Value}
        folioBE.FO_ID_PERSONA = New BE.PlanillaBE.SG_PL_TB_PERSONAL With {.PE_ID = ug_Detalle.ActiveRow.Cells("FO_ID_PERSONA").Value}
        folioBL.Delete_x_Trabajador(folioBE)


        folioBL = Nothing
        folioBE = Nothing



        'borramos de la grilla
        ug_Detalle.ActiveRow.Delete()
    End Sub

    Private Sub Tool_eliminar_todos_Click(sender As System.Object, e As System.EventArgs) Handles Tool_eliminar_todos.Click
        If Preguntar("Seguro de eliminar a todos los trabajadores de este folio?") Then

            'borramos de la grilla
            Call LimpiaGrid(ug_Detalle, uds_detalle)

            'borramos de la base de datos
            Dim folioBL As New BL.PlanillaBL.SG_PL_TB_FOLIO
            Dim folioBE As BE.PlanillaBE.SG_PL_TB_FOLIO

            folioBE = New BE.PlanillaBE.SG_PL_TB_FOLIO()
            folioBE.FO_ANHO = CDate(udte_fecha.Value).Year
            folioBE.FO_MES = CDate(udte_fecha.Value).Month
            folioBE.FO_ID_EMPRESA = New BE.ContabilidadBE.SG_CO_TB_EMPRESA With {.EM_ID = gInt_IdEmpresa}
            folioBE.FO_ID_CONCEPTO = New BE.PlanillaBE.SG_PL_TB_CONCEPTOS With {.CO_ID = ug_Folios.ActiveRow.Cells("CO_ID").Value}
            folioBL.Delete(folioBE)


            folioBL = Nothing
            folioBE = Nothing

        End If
    End Sub

    Private Sub udte_fecha_ValueChanged(sender As System.Object, e As System.EventArgs) Handles udte_fecha.ValueChanged
        Verificar_Estado_Mes()
    End Sub

    Private Sub ug_Folios_InitializeLayout(sender As System.Object, e As Infragistics.Win.UltraWinGrid.InitializeLayoutEventArgs) Handles ug_Folios.InitializeLayout

    End Sub
End Class