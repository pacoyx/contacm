Public Class PL_PR_Compra_Vaca

    Dim Bol_Nuevo As Boolean = False

    Private Sub PL_PR_Compra_Vaca_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Call Inicializar_Estado_Botones_Tool(ToolS_Mantenimiento)
        Call Formatear_Grilla_Selector(ug_lista_emp_compra)
        Call MostrarTabs(0, utc_compras, 0)
        Call Cargar_Lista_Empleados_Compras()

        txt_cod_per.ButtonsRight(0).Appearance.Image = My.Resources._104
    End Sub

    Private Sub Cargar_Lista_Empleados_Compras()
        Dim compraBL As New BL.PlanillaBL.SG_PL_TB_COMPRA_VACA
        Dim ds_tmp As DataSet = compraBL.get_Compras(New BE.ContabilidadBE.SG_CO_TB_EMPRESA With {.EM_ID = gInt_IdEmpresa})
        'ug_lista_emp_compra.DataSource =
        ug_lista_emp_compra.SetDataBinding(ds_tmp, "")
        ug_lista_emp_compra.DisplayLayout.Bands(1).Columns("CV_ID_PERSONAL").Hidden = True
        ug_lista_emp_compra.DisplayLayout.Bands(1).Columns("CV_ID").Hidden = True

        ug_lista_emp_compra.DisplayLayout.Bands(1).Columns("CV_DIAS").Header.Caption = "Dias"
        ug_lista_emp_compra.DisplayLayout.Bands(1).Columns("CV_IMPORTE").Header.Caption = "Importe"
        ug_lista_emp_compra.DisplayLayout.Bands(1).Columns("CV_PERIODO").Header.Caption = "Periodo"
        ug_lista_emp_compra.DisplayLayout.Bands(1).Columns("CV_FECHA_LIQUI").Header.Caption = "Fecha"
        ug_lista_emp_compra.DisplayLayout.Bands(1).Columns("CV_OBS").Header.Caption = "Observ."
        ug_lista_emp_compra.DisplayLayout.Bands(1).Columns("CV_PROCESAR").Header.Caption = "Procesado"


        ug_lista_emp_compra.DisplayLayout.Bands(1).Columns("CV_IMPORTE").Style = Infragistics.Win.UltraWinGrid.ColumnStyle.Double
        ug_lista_emp_compra.DisplayLayout.Bands(1).Columns("CV_IMPORTE").MaskDisplayMode = Infragistics.Win.UltraWinMaskedEdit.MaskMode.IncludeLiterals
        ug_lista_emp_compra.DisplayLayout.Bands(1).Columns("CV_IMPORTE").CellAppearance.TextHAlign = Infragistics.Win.HAlign.Right

        ug_lista_emp_compra.DisplayLayout.Bands(1).Columns("CV_PERIODO").CellAppearance.TextHAlign = Infragistics.Win.HAlign.Center


        ug_lista_emp_compra.DisplayLayout.Bands(1).Columns("CV_PROCESAR").Style = Infragistics.Win.UltraWinGrid.ColumnStyle.CheckBox


        ug_lista_emp_compra.DisplayLayout.Bands(1).Columns("CV_FECHA_LIQUI").Style = Infragistics.Win.UltraWinGrid.ColumnStyle.Date
        ug_lista_emp_compra.DisplayLayout.Bands(1).Columns("CV_FECHA_LIQUI").CellAppearance.TextHAlign = Infragistics.Win.HAlign.Center
        ug_lista_emp_compra.DisplayLayout.Bands(1).Columns("CV_FECHA_LIQUI").CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit

        ug_lista_emp_compra.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill



        compraBL = Nothing
    End Sub

    Private Sub Tool_Nuevo_Click(sender As System.Object, e As System.EventArgs) Handles Tool_Nuevo.Click
        Call Cambiar_Estado_Botones_Tool(ToolS_Mantenimiento)
        Call MostrarTabs(1, utc_compras, 1)
        Call Limpiar_Controls_InGroupox(ugb_datos)
        Call Limpiar_Controls_InGroupox(ugb_trabajador)
        uchk_consi_liqui.Checked = True
        Bol_Nuevo = True
        txt_cod_per.Enabled = True
        txt_cod_per.Focus()
    End Sub

    Private Sub Tool_Salir_Click(sender As System.Object, e As System.EventArgs) Handles Tool_Salir.Click
        Me.Close()
    End Sub

    Private Sub Tool_Grabar_Click(sender As System.Object, e As System.EventArgs) Handles Tool_Grabar.Click
        Dim comprasBL As New BL.PlanillaBL.SG_PL_TB_COMPRA_VACA
        Dim comprasBE As New BE.PlanillaBE.SG_PL_TB_COMPRA_VACA

        With comprasBE
            .CV_ID = txt_idRegistro.Value
            .CV_ID_PERSONAL = txt_id_per.Text.Trim
            .CV_DIAS = une_dias_compra.Value
            .CV_IMPORTE = ume_importe_compra.Value
            .CV_PERIODO = uce_periodo_compra.Text
            .CV_FECHA_LIQUI = udte_fec_liqui.Value
            .CV_OBS = txt_obs_compra.Text
            .CV_PROCESAR = IIf(uchk_consi_liqui.Checked, 1, 0)
        End With

        If Bol_Nuevo Then
            comprasBL.Insert(comprasBE)
        Else
            comprasBL.Update(comprasBE)
        End If

        Call Avisar("Listo")

        Tool_Cancelar_Click(sender, e)

    End Sub

    Private Sub Tool_Cancelar_Click(sender As System.Object, e As System.EventArgs) Handles Tool_Cancelar.Click
        Call MostrarTabs(0, utc_compras, 0)
        Call Cambiar_Estado_Botones_Tool(ToolS_Mantenimiento)
    End Sub

    Private Sub Tool_Eliminar_Click(sender As System.Object, e As System.EventArgs) Handles Tool_Eliminar.Click

        If ug_lista_emp_compra.Rows.Count = 0 Then Exit Sub
        If ug_lista_emp_compra.ActiveRow.Band.Index = 0 Then Exit Sub

        If Not Preguntar("Seguro de Eliminar?") Then Exit Sub

        Dim id As Integer = ug_lista_emp_compra.ActiveRow.Cells("CV_ID").Value

        Dim comprasBL As New BL.PlanillaBL.SG_PL_TB_COMPRA_VACA
        Dim comprasBE As New BE.PlanillaBE.SG_PL_TB_COMPRA_VACA

        comprasBE.CV_ID = id
        comprasBL.Delete(comprasBE)

        comprasBE = Nothing
        comprasBL = Nothing

        Call Cargar_Lista_Empleados_Compras()

        Avisar("Listo!")


    End Sub

    Private Sub Buscar_Periodos()
        Dim fecha_ing As Date = Date.Now
        Dim fecha_1 As Date = Date.Now
        If txt_id_per.Text = String.Empty Then Exit Sub

        Dim personalBL As New BL.PlanillaBL.SG_PL_TB_PERSONAL
        Dim personalBE As New BE.PlanillaBE.SG_PL_TB_PERSONAL With {.PE_ID = Val(txt_id_per.Text.Trim), .PE_ID_EMPRESA = gInt_IdEmpresa}
        personalBL.getPersonal_x_Id(personalBE)

        Dim ayo1 As Integer = 0
        Dim ayo2 As Integer = 0
        Dim fecha_ult As Date
        fecha_ing = personalBE.PE_FEC_ING

        fecha_ult = fecha_ing
        uce_periodo_compra.Items.Clear()
        For i As Integer = fecha_ing.Year To gDat_Fecha_Sis.Year + 2
            ayo1 = fecha_ult.Year
            ayo2 = fecha_ult.AddYears(1).Year
            uce_periodo_compra.Items.Add(i, ayo1.ToString & " - " & ayo2.ToString)
            fecha_ult = fecha_ult.AddYears(1)
        Next

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
                    txt_cod_per.Text = empleado.PE_CODIGO
                    txt_nom_per.Text = empleado.PE_APE_PAT & " " & empleado.PE_APE_MAT & " " & empleado.PE_NOM_PRI
                    txt_id_per.Text = empleado.PE_ID
                Next
            End If
            matriz = Nothing

        End If
    End Sub

    Private Sub txt_cod_per_EditorButtonClick(sender As Object, e As Infragistics.Win.UltraWinEditors.EditorButtonEventArgs) Handles txt_cod_per.EditorButtonClick
        Call Mostrar_Ayuda_Empleado()
    End Sub

    Private Sub txt_cod_per_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles txt_cod_per.KeyDown
        If e.KeyCode = Keys.F2 Then Call Mostrar_Ayuda_Empleado()
        If e.KeyCode = Keys.Enter Then une_dias_compra.Focus()
    End Sub

    Private Sub txt_cod_per_Leave(sender As System.Object, e As System.EventArgs) Handles txt_cod_per.Leave
        Call Buscar_Periodos()
    End Sub

    Private Sub une_dias_compra_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles une_dias_compra.KeyDown
        If e.KeyCode = Keys.Enter Then SendKeys.Send(vbTab)
    End Sub

    Private Sub ume_importe_compra_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles ume_importe_compra.KeyDown
        If e.KeyCode = Keys.Enter Then SendKeys.Send(vbTab)
    End Sub

    Private Sub uce_periodo_compra_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles uce_periodo_compra.KeyDown
        If e.KeyCode = Keys.Enter Then SendKeys.Send(vbTab)
    End Sub

    Private Sub udte_fec_liqui_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles udte_fec_liqui.KeyDown
        If e.KeyCode = Keys.Enter Then SendKeys.Send(vbTab)
    End Sub

    Private Sub txt_obs_compra_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles txt_obs_compra.KeyDown
        If e.KeyCode = Keys.Enter Then SendKeys.Send(vbTab)
    End Sub

    Private Sub ug_lista_emp_compra_InitializeGroupByRow(sender As System.Object, e As Infragistics.Win.UltraWinGrid.InitializeGroupByRowEventArgs) Handles ug_lista_emp_compra.InitializeGroupByRow
        e.Row.Expanded = True
    End Sub

    Private Sub Tool_Editar_Click(sender As System.Object, e As System.EventArgs) Handles Tool_Editar.Click
        Call Editar_Registro()
    End Sub

    Private Sub Editar_Registro()
        If ug_lista_emp_compra.Rows.Count = 0 Then Exit Sub
        If ug_lista_emp_compra.ActiveRow.Band.Index = 0 Then Exit Sub


        Dim codper As String = ug_lista_emp_compra.ActiveRow.ParentRow.Cells("PE_CODIGO").Value
        Dim nomper As String = ""
        With ug_lista_emp_compra.ActiveRow.ParentRow
            nomper = .Cells("PE_APE_PAT").Value & " " & .Cells("PE_APE_MAT").Value & " " & .Cells("PE_NOM_SEG").Value & " " & .Cells("PE_NOM_SEG").Value
        End With

        Dim id As Integer = ug_lista_emp_compra.ActiveRow.Cells("CV_ID").Value

        Dim comprasBL As New BL.PlanillaBL.SG_PL_TB_COMPRA_VACA
        Dim comprasBE As New BE.PlanillaBE.SG_PL_TB_COMPRA_VACA
        comprasBE.CV_ID = id
        comprasBL.get_Compra(comprasBE)

        Call Cambiar_Estado_Botones_Tool(ToolS_Mantenimiento)
        Call MostrarTabs(1, utc_compras, 1)
        Call Limpiar_Controls_InGroupox(ugb_datos)
        Call Limpiar_Controls_InGroupox(ugb_trabajador)
        Bol_Nuevo = False


        txt_cod_per.Text = codper
        txt_nom_per.Text = nomper
        txt_id_per.Text = comprasBE.CV_ID_PERSONAL

        txt_idRegistro.Value = comprasBE.CV_ID

        Call Buscar_Periodos()

        une_dias_compra.Value = comprasBE.CV_DIAS
        ume_importe_compra.Value = comprasBE.CV_IMPORTE
        uce_periodo_compra.Text = comprasBE.CV_PERIODO
        udte_fec_liqui.Value = comprasBE.CV_FECHA_LIQUI
        txt_obs_compra.Text = comprasBE.CV_OBS
        uchk_consi_liqui.Checked = IIf(comprasBE.CV_PROCESAR = 1, True, False)

        comprasBE = Nothing
        comprasBL = Nothing

        txt_cod_per.Enabled = False
        une_dias_compra.Focus()



    End Sub

    Private Sub ug_lista_emp_compra_DoubleClickRow(sender As System.Object, e As Infragistics.Win.UltraWinGrid.DoubleClickRowEventArgs) Handles ug_lista_emp_compra.DoubleClickRow
        If e.Row.Band.Index = 0 Then Exit Sub
        Call Editar_Registro()
    End Sub
End Class