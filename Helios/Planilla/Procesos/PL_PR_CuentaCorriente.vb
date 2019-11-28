Imports Infragistics.Win.UltraWinGrid

Public Class PL_PR_CuentaCorriente

    Dim Bol_Nuevo As Boolean = False
    Dim Bol_Editar_Imp As Boolean = False
    Dim Lista_A_Eliminar As New List(Of Integer)

    Dim dt_cronograma As DataTable = Nothing

    Private Sub PL_PR_CuentaCorriente_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call MostrarTabs(0, utc_Cta_Cte, 0)
        Call Inicializar_Estado_Botones_Tool(ToolS_Mantenimiento)
        Call Formatear_Grilla_Selector(ug_listado_cta_cte)
        'Call Formatear_Grilla_Selector(ug_cronograma)
        Call Cargar_Combos()
        Call Cargar_Listado_CtaCte()
        Call Cargar_DocumentoRecibo()



        ubtn_Cronograma.Appearance.Image = My.Resources._16__Calendar_
        txt_cod_personal.ButtonsRight(0).Appearance.Image = My.Resources._104
        uce_Motivo.ButtonsRight(0).Appearance.Image = My.Resources._16__File_new_2_
        ubtn_Regresar.Appearance.Image = My.Resources._16__Back_
        ubtn_Cancelar.Appearance.Image = My.Resources._16__Cancel_
        ubtn_Mod_Cronograma.Appearance.Image = My.Resources._16__Card_edit_
        ubtn_Anular.Appearance.Image = My.Resources.delete
        ubtn_exportar.Appearance.Image = My.Resources._16__Doc_excel_

    End Sub

    Private Sub Cargar_DocumentoRecibo()

        Dim docBL As New BL.ContabilidadBL.SG_CO_TB_DOCUMENTO
        Dim docs As List(Of String) = docBL.get_doc_recibo_prestamo(New BE.ContabilidadBE.SG_CO_TB_EMPRESA With {.EM_ID = gInt_IdEmpresa})

        If docs.Count > 0 Then
            txt_tip_doc.Text = docs(0)
            txt_des_doc.Text = docs(1)
        End If


        docs = Nothing


    End Sub

    Private Sub Cargar_Combos()
        Dim monedaBL As New BL.ContabilidadBL.SG_CO_TB_MONEDA
        uce_Moneda.DataSource = monedaBL.getMonedas()
        uce_Moneda.ValueMember = "MO_CODIGO"
        uce_Moneda.DisplayMember = "MO_DESCRIPCION"

        Dim estadoBL As New BL.PlanillaBL.SG_PL_TB_ESTADO_PRESTAMO
        uce_estado.DataSource = estadoBL.get_Estados
        uce_estado.ValueMember = "EP_ID"
        uce_estado.DisplayMember = "EP_DESCRIPCION"

        Dim motivoBL As New BL.PlanillaBL.SG_PL_TB_MOTIVO_PRESTAMO
        uce_Motivo.DataSource = motivoBL.get_Motivos
        uce_Motivo.ValueMember = "MP_ID"
        uce_Motivo.DisplayMember = "MP_DESCRIPCION"

        'cargamos los option's
        uos_estado.DataSource = estadoBL.get_Estados
        uos_estado.DisplayMember = "EP_DESCRIPCION"
        uos_estado.ValueMember = "EP_ID"
        uos_estado.Value = 1

        motivoBL = Nothing
        estadoBL = Nothing
        monedaBL = Nothing
    End Sub

    Private Sub Cargar_Listado_CtaCte()
        Dim ctacteBL As New BL.PlanillaBL.SG_PL_TB_CTA_CTE
        Dim estadoBE As New BE.PlanillaBE.SG_PL_TB_ESTADO_PRESTAMO With {.EP_ID = uos_estado.Value}
        ug_listado_cta_cte.DataSource = ctacteBL.get_ctacte(estadoBE, New BE.ContabilidadBE.SG_CO_TB_EMPRESA With {.EM_ID = gInt_IdEmpresa})
        ctacteBL = Nothing
    End Sub

    Private Sub Tool_Nuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_Nuevo.Click
        Bol_Nuevo = True
        Call Cambiar_Estado_Botones_Tool(ToolS_Mantenimiento)
        Call Limpiar_Controls_InGroupox(ugb_datos)
        Call MostrarTabs(1, utc_Cta_Cte, 1)
        Call Cargar_Tipo_Cambio()
        Call Cargar_Numero_Recibo()
        txt_ser_doc.Text = CDate(udte_fecha_Reg.Value).Year.ToString

        ume_Importe.Value = 0
        une_num_cuota.Value = 1
        ume_tasaInteres.Value = (15 / 12)
        uce_Moneda.Value = 1
        uce_Motivo.SelectedIndex = 0
        uce_estado.Value = 1
        uce_estado.Enabled = False
        ume_saldo.Enabled = False
        uchk_Afecta.Checked = True

        txt_cod_personal.Focus()
    End Sub

    Private Sub Cargar_Numero_Recibo()
        Dim ctacteBL As New BL.PlanillaBL.SG_PL_TB_CTA_CTE
        une_num_recibo.Value = ctacteBL.get_Ultimo_Num_Recibo(New BE.ContabilidadBE.SG_CO_TB_EMPRESA With {.EM_ID = gInt_IdEmpresa})
        ctacteBL = Nothing
    End Sub

    Private Sub Cargar_Tipo_Cambio()
        Dim tcBL As New BL.ContabilidadBL.SG_CO_TB_TIPOCAMBIO
        Dim tcBE As New BE.ContabilidadBE.SG_CO_TB_TIPOCAMBIO
        tcBE.TC_FECHA = gDat_Fecha_Sis.ToShortDateString
        tcBE.TC_IDMONEDA = New BE.ContabilidadBE.SG_CO_TB_MONEDA With {.MO_CODIGO = 2}
        tcBE.TC_IDEMPRESA = New BE.ContabilidadBE.SG_CO_TB_EMPRESA With {.EM_ID = gInt_IdEmpresa}
        tcBL.getTipoCambio(tcBE)
        ume_tipoCambio.Value = tcBE.TC_VENTA

        tcBE = Nothing
        tcBL = Nothing

    End Sub

    Private Sub Mostrar_Ayuda_Empleado()
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

    Private Sub txt_cod_personal_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_cod_personal.KeyDown
        If e.KeyCode = Keys.F2 Then
            Call Mostrar_Ayuda_Empleado()
        End If

        If e.KeyCode = Keys.Enter Then SendKeys.Send(vbTab)

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
    End Sub

    Private Sub Tool_Salir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_Salir.Click
        Me.Close()
    End Sub

    Private Sub udte_fecha_Reg_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles udte_fecha_Reg.KeyDown
        If e.KeyCode = Keys.Enter Then SendKeys.Send(vbTab)
    End Sub

    Private Sub uce_Motivo_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles uce_Motivo.KeyDown
        If e.KeyCode = Keys.Enter Then SendKeys.Send(vbTab)
    End Sub

    Private Sub uce_Moneda_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles uce_Moneda.KeyDown
        If e.KeyCode = Keys.Enter Then SendKeys.Send(vbTab)
    End Sub

    Private Sub ume_Importe_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles ume_Importe.KeyDown
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send(vbTab)
        End If

    End Sub

    Private Sub une_num_cuota_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles une_num_cuota.KeyDown
        If e.KeyCode = Keys.Enter Then SendKeys.Send(vbTab)
    End Sub

    Private Sub uchk_Afecta_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles uchk_Afecta.KeyDown
        If e.KeyCode = Keys.Enter Then ume_Importe.Focus()
    End Sub

    Private Sub uce_estado_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles uce_estado.KeyDown
        If e.KeyCode = Keys.Enter Then SendKeys.Send(vbTab)
    End Sub

    Private Sub Tool_Cancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_Cancelar.Click
        Call MostrarTabs(0, utc_Cta_Cte, 0)
        Call Cambiar_Estado_Botones_Tool(ToolS_Mantenimiento)
    End Sub

    Private Sub Tool_Grabar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_Grabar.Click
        Dim ctacteBL As New BL.PlanillaBL.SG_PL_TB_CTA_CTE
        Dim ctacteBE As New BE.PlanillaBE.SG_PL_TB_CTA_CTE

        With ctacteBE
            .CC_ID = Val(txt_id_registro.Text.Trim)
            .CC_NUMERO = une_num_recibo.Value
            .CC_FECHA_REGISTRO = CDate(udte_fecha_Reg.Value).ToShortDateString
            .CC_ID_PERSONAL = New BE.PlanillaBE.SG_PL_TB_PERSONAL With {.PE_ID = txt_id_personal.Text.Trim}
            .CC_ID_MOTIVO = New BE.PlanillaBE.SG_PL_TB_MOTIVO_PRESTAMO With {.MP_ID = uce_Motivo.Value}
            .CC_AFECTA_PLANILLA = IIf(uchk_Afecta.Checked, 1, 0)
            .CC_ID_MONEDA = New BE.ContabilidadBE.SG_CO_TB_MONEDA With {.MO_CODIGO = uce_Moneda.Value}
            .CC_IMPORTE = ume_Importe.Value
            .CC_TC = ume_tipoCambio.Value
            .CC_NUM_CUOTAS = une_num_cuota.Value
            .CC_OBSERVACIONES = txt_obs.Text.Trim
            .CC_ESTADO = New BE.PlanillaBE.SG_PL_TB_ESTADO_PRESTAMO With {.EP_ID = uce_estado.Value}
            .CC_SALDO = ume_saldo.Value
            .CC_USUARIO = String.Format("{0}-{1}", Environment.UserName, gStr_Usuario_Sis)
            .CC_TERMINAL = Environment.MachineName
            .CC_FECREG = Date.Now

            .CC_TDOC = txt_tip_doc.Text
            .CC_SDOC = txt_ser_doc.Text
            .CC_TASA_INTERES = ume_tasaInteres.Value
            .CC_MONTO_TOTAL = ume_monto_total.Value
            .CC_CUOTA_MENSUAL = ume_cuota_mensual.Value
            .CC_TOTAL_INTERES = ume_total_interes.Value

        End With

        If Bol_Nuevo Then
            ctacteBL.Insert(ctacteBE, dt_cronograma)
        Else
            ctacteBL.Update(ctacteBE)
        End If

        Call Avisar("Listo!")
        Call Cargar_Listado_CtaCte()
        Call Tool_Cancelar_Click(sender, e)

        ctacteBL = Nothing
        ctacteBE = Nothing
    End Sub

    Private Sub Tool_Editar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_Editar.Click

        If ug_listado_cta_cte.Rows.Count = 0 Then Exit Sub

        Dim ctacteBL As New BL.PlanillaBL.SG_PL_TB_CTA_CTE
        Dim ctacteBE As New BE.PlanillaBE.SG_PL_TB_CTA_CTE
        ctacteBE.CC_ID = ug_listado_cta_cte.ActiveRow.Cells("CC_ID").Value
        ctacteBL.get_ctacte_x_Id(ctacteBE)

        If Verificar_Tiene_Pagos() Then
            Avisar("La Cuenta Corriente ya tiene cuotas pagadas." & Chr(13) & "No se puede editar el registro.")
            ctacteBL = Nothing
            ctacteBE = Nothing
            Exit Sub
        End If


        With ctacteBE
            txt_id_registro.Text = .CC_ID
            une_num_recibo.Value = .CC_NUMERO
            txt_id_personal.Text = .CC_ID_PERSONAL.PE_ID
            txt_cod_personal.Text = .CC_ID_PERSONAL.PE_CODIGO
            txt_nombres.Text = .CC_ID_PERSONAL.PE_APE_PAT & " " & .CC_ID_PERSONAL.PE_APE_MAT & " " & .CC_ID_PERSONAL.PE_NOM_PRI & " " & .CC_ID_PERSONAL.PE_NOM_SEG
            udte_fecha_Reg.Value = .CC_FECHA_REGISTRO
            uce_Motivo.Value = .CC_ID_MOTIVO.MP_ID
            uce_Moneda.Value = .CC_ID_MONEDA.MO_CODIGO
            ume_Importe.Value = .CC_IMPORTE
            ume_tipoCambio.Value = .CC_TC
            une_num_cuota.Value = .CC_NUM_CUOTAS
            uchk_Afecta.Checked = IIf(.CC_AFECTA_PLANILLA = 1, True, False)
            uce_estado.Value = .CC_ESTADO.EP_ID
            ume_saldo.Value = .CC_SALDO
            txt_obs.Text = .CC_OBSERVACIONES
            ume_tasaInteres.Value = .CC_TASA_INTERES
            ume_monto_total.Value = .CC_MONTO_TOTAL
            ume_cuota_mensual.Value = .CC_CUOTA_MENSUAL
            ume_total_interes.Value = .CC_TOTAL_INTERES

            uce_estado.Enabled = False

        End With

        ctacteBL = Nothing
        ctacteBE = Nothing


        une_num_recibo.Enabled = False
        ume_saldo.Enabled = False
        Call MostrarTabs(1, utc_Cta_Cte, 1)
        Call Cambiar_Estado_Botones_Tool(ToolS_Mantenimiento)

        txt_cod_personal.Focus()

    End Sub

    Private Function Verificar_Tiene_Pagos() As Boolean
        Verificar_Tiene_Pagos = False
        Dim cronogramaBL As New BL.PlanillaBL.SG_PL_TB_CTA_CTE_CRONOGRAMA
        Dim ctacteBE As New BE.PlanillaBE.SG_PL_TB_CTA_CTE With {.CC_ID = ug_listado_cta_cte.ActiveRow.Cells("CC_ID").Value}
        Dim dt_tmp As DataTable = cronogramaBL.get_Cronograma(ctacteBE)

        For i As Integer = 0 To dt_tmp.Rows.Count - 1
            If dt_tmp(i)("CR_ESTADO") = "2" Then
                Verificar_Tiene_Pagos = True
                Exit For
            End If
        Next

        dt_tmp.Dispose()
        ctacteBE = Nothing
        cronogramaBL = Nothing

    End Function

    Private Sub Tool_Eliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_Eliminar.Click

        If ug_listado_cta_cte.Rows.Count = 0 Then Exit Sub
        If Preguntar("Esta seguro de eliminar") Then
            Dim ctacteBL As New BL.PlanillaBL.SG_PL_TB_CTA_CTE
            Dim ctacteBE As New BE.PlanillaBE.SG_PL_TB_CTA_CTE

            ctacteBE.CC_ID = ug_listado_cta_cte.ActiveRow.Cells("CC_ID").Value
            ctacteBL.Delete(ctacteBE)

            Call Avisar("Listo!")
            Call Cargar_Listado_CtaCte()

            ctacteBL = Nothing
            ctacteBE = Nothing

        End If
    End Sub

    Private Sub ubtn_Cronograma_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ubtn_Cronograma.Click
        If ug_listado_cta_cte.Rows.Count = 0 Then Exit Sub

        Dim cronogramaBL As New BL.PlanillaBL.SG_PL_TB_CTA_CTE_CRONOGRAMA
        Dim ctacteBE As New BE.PlanillaBE.SG_PL_TB_CTA_CTE With {.CC_ID = ug_listado_cta_cte.ActiveRow.Cells("CC_ID").Value}
        Dim dt_tmp As DataTable = cronogramaBL.get_Cronograma(ctacteBE)
        Dim cuotas_can As Integer = 0

        Call LimpiaGrid(ug_cronograma, uds_Cronograma)

        For i As Integer = 0 To dt_tmp.Rows.Count - 1
            ug_cronograma.DisplayLayout.Bands(0).AddNew()
            ug_cronograma.Rows(i).Cells("CR_ID_CTACTE").Value = dt_tmp.Rows(i)("CR_ID_CTACTE")
            ug_cronograma.Rows(i).Cells("CR_NUM_CUOTA").Value = dt_tmp.Rows(i)("CR_NUM_CUOTA")
            ug_cronograma.Rows(i).Cells("CR_FECHA_PAGO").Value = dt_tmp.Rows(i)("CR_FECHA_PAGO")
            ug_cronograma.Rows(i).Cells("CR_IMPORTE").Value = dt_tmp.Rows(i)("CR_IMPORTE")
            ug_cronograma.Rows(i).Cells("CR_CAPITAL").Value = dt_tmp.Rows(i)("CR_CAPITAL")
            ug_cronograma.Rows(i).Cells("CR_CUOTA").Value = dt_tmp.Rows(i)("CR_CUOTA")
            ug_cronograma.Rows(i).Cells("CR_INTERES").Value = dt_tmp.Rows(i)("CR_INTERES")
            ug_cronograma.Rows(i).Cells("CR_ESTADO").Value = IIf(dt_tmp.Rows(i)("CR_ESTADO") = 1, False, True)
            ug_cronograma.Rows(i).Cells("CR_NO_CONSIDERAR").Value = IIf(dt_tmp.Rows(i)("CR_NO_CONSIDERAR") = 1, True, False)
            If dt_tmp.Rows(i)("CR_ESTADO") = 2 Then cuotas_can += 1
        Next

        ug_cronograma.UpdateData()

        lbl_personal.Text = ug_listado_cta_cte.ActiveRow.Cells("NOMBRES").Value



        ume_cro_fecha_prestamo.Value = ug_listado_cta_cte.ActiveRow.Cells("CC_FECHA_REGISTRO").Value
        ume_cro_importe.Value = ug_listado_cta_cte.ActiveRow.Cells("CC_IMPORTE").Value
        une_cro_num_cuotas.Value = ug_listado_cta_cte.ActiveRow.Cells("CC_NUM_CUOTAS").Value
        ume_cro_saldo.Value = ug_listado_cta_cte.ActiveRow.Cells("CC_SALDO").Value
        ume_imp_total.Value = ug_listado_cta_cte.ActiveRow.Cells("CC_MONTO_TOTAL").Value
        une_cro_cuotas_can.Value = cuotas_can
        une_cuotas_pen.Value = CInt(une_cro_num_cuotas.Value) - cuotas_can
        ubtn_Mod_Cronograma.Appearance.Image = My.Resources._16__Card_edit_

        Lista_A_Eliminar.Clear()

        ToolS_Mantenimiento.Enabled = False
        Call MostrarTabs(2, utc_Cta_Cte, 2)


        ug_cronograma.DisplayLayout.Bands(0).Columns("CR_FECHA_PAGO").CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        ug_cronograma.DisplayLayout.Bands(0).Columns("CR_IMPORTE").CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        ug_cronograma.DisplayLayout.Bands(0).Columns("CR_ESTADO").CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        ug_cronograma.DisplayLayout.Bands(0).Columns("CR_NO_CONSIDERAR").CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        

        'PENDIENTE


        Dim ctacteBL As New BL.PlanillaBL.SG_PL_TB_CTA_CTE
        ctacteBE.CC_ID = ug_listado_cta_cte.ActiveRow.Cells("CC_ID").Value
        ctacteBL.get_ctacte_x_Id(ctacteBE)

        If ctacteBE.CC_ESTADO.EP_ID = 1 Then
            ubtn_Mod_Cronograma.Enabled = True
            ubtn_Cancelar.Enabled = True
        Else
            ubtn_Mod_Cronograma.Enabled = False
            ubtn_Cancelar.Enabled = False
        End If

        Bol_Editar_Imp = False
        ctacteBE = Nothing
        ctacteBL = Nothing
        cronogramaBL = Nothing

    End Sub

    Private Sub ubtn_Regresar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ubtn_Regresar.Click
        ToolS_Mantenimiento.Enabled = True
        Call MostrarTabs(0, utc_Cta_Cte, 0)
    End Sub

    Private Sub ubtn_Mod_Importe_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ubtn_Mod_Cronograma.Click
        ubtn_Regresar.Enabled = Bol_Editar_Imp

        If Not Bol_Editar_Imp Then
            ug_cronograma.DisplayLayout.Bands(0).Columns("CR_FECHA_PAGO").CellActivation = Infragistics.Win.UltraWinGrid.Activation.AllowEdit
            ug_cronograma.DisplayLayout.Bands(0).Columns("CR_IMPORTE").CellActivation = Infragistics.Win.UltraWinGrid.Activation.AllowEdit
            ug_cronograma.DisplayLayout.Bands(0).Columns("CR_ESTADO").CellActivation = Infragistics.Win.UltraWinGrid.Activation.AllowEdit
            ug_cronograma.DisplayLayout.Bands(0).Columns("CR_NO_CONSIDERAR").CellActivation = Infragistics.Win.UltraWinGrid.Activation.AllowEdit

            Bol_Editar_Imp = True
            ubtn_Mod_Cronograma.Appearance.Image = My.Resources._003
            ubtn_Mod_Cronograma.Text = "Actualizar Cronograma"
            ubtn_Cancelar.Visible = True
        Else

            Dim dbl_total As Double = 0
            For i As Integer = 0 To ug_cronograma.Rows.Count - 1
                dbl_total += ug_cronograma.Rows(i).Cells("CR_IMPORTE").Value
            Next

            If dbl_total <> Double.Parse(ume_imp_total.Value) Then
                Call Avisar("La suma de las cuotas mensuales no es igual al total del prestamo." & Chr(13) & "Revise los importes mensuales.")
                If Not Preguntar("Desea continuar?") Then
                    Exit Sub
                End If
            End If

            Dim cronogramaBL As New BL.PlanillaBL.SG_PL_TB_CTA_CTE_CRONOGRAMA
            Dim cronogramaBE As New BE.PlanillaBE.SG_PL_TB_CTA_CTE_CRONOGRAMA

            ug_cronograma.UpdateData()


            For Each item As Integer In Lista_A_Eliminar
                cronogramaBE = New BE.PlanillaBE.SG_PL_TB_CTA_CTE_CRONOGRAMA With {.CR_ID_CTACTE = New BE.PlanillaBE.SG_PL_TB_CTA_CTE With {.CC_ID = ug_cronograma.Rows(0).Cells("CR_ID_CTACTE").Value}, .CR_NUM_CUOTA = item}
                cronogramaBL.Delete(cronogramaBE)
            Next


            For i As Integer = 0 To ug_cronograma.Rows.Count - 1
                With cronogramaBE
                    .CR_ID_CTACTE = New BE.PlanillaBE.SG_PL_TB_CTA_CTE With {.CC_ID = ug_cronograma.Rows(i).Cells("CR_ID_CTACTE").Value}
                    .CR_NUM_CUOTA = ug_cronograma.Rows(i).Cells("CR_NUM_CUOTA").Value
                    .CR_FECHA_PAGO = ug_cronograma.Rows(i).Cells("CR_FECHA_PAGO").Value
                    .CR_IMPORTE = ug_cronograma.Rows(i).Cells("CR_IMPORTE").Value
                    .CR_ESTADO = New BE.PlanillaBE.SG_PL_TB_ESTADO_PRESTAMO With {.EP_ID = IIf(ug_cronograma.Rows(i).Cells("CR_ESTADO").Value, 2, 1)}
                    .CR_TIPO_PAGO = IIf(ug_cronograma.Rows(i).Cells("CR_ESTADO").Value, "M", "")
                    .CR_NO_CONSIDERAR = IIf(ug_cronograma.Rows(i).Cells("CR_NO_CONSIDERAR").Value, 1, 0)
                End With
                cronogramaBL.Update(cronogramaBE)
            Next

            Bol_Editar_Imp = False
            ug_cronograma.DisplayLayout.Bands(0).Columns("CR_FECHA_PAGO").CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
            ug_cronograma.DisplayLayout.Bands(0).Columns("CR_IMPORTE").CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit

            Call Avisar("Listo!")

            ubtn_Mod_Cronograma.Text = "Modificar Cronograma"
            ubtn_Cancelar.Visible = False

            cronogramaBL = Nothing
            cronogramaBE = Nothing
        End If



    End Sub

    Private Sub ug_cronograma_AfterRowsDeleted(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ug_cronograma.AfterRowsDeleted
        For i As Int16 = 0 To ug_cronograma.Rows.Count - 1
            ug_cronograma.Rows(i).Cells("CR_NUM_CUOTA").Value = i + 1
        Next

        ug_cronograma.UpdateData()

    End Sub

    Private Sub ug_cronograma_BeforeRowsDeleted(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinGrid.BeforeRowsDeletedEventArgs) Handles ug_cronograma.BeforeRowsDeleted

        If Not Bol_Editar_Imp Then
            e.Cancel = True
        End If
        e.DisplayPromptMsg = False


        Lista_A_Eliminar.Add(ug_cronograma.ActiveRow.Cells("CR_NUM_CUOTA").Value)

    End Sub

    Private Sub ubtn_Cancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ubtn_Cancelar.Click
        Dim cronogramaBL As New BL.PlanillaBL.SG_PL_TB_CTA_CTE_CRONOGRAMA
        Dim ctacteBL As New BE.PlanillaBE.SG_PL_TB_CTA_CTE With {.CC_ID = ug_listado_cta_cte.ActiveRow.Cells("CC_ID").Value}
        Dim dt_tmp As DataTable = cronogramaBL.get_Cronograma(ctacteBL)
        Dim cuotas_can As Integer = 0

        Call LimpiaGrid(ug_cronograma, uds_Cronograma)

        For i As Integer = 0 To dt_tmp.Rows.Count - 1
            ug_cronograma.DisplayLayout.Bands(0).AddNew()
            ug_cronograma.Rows(i).Cells("CR_ID_CTACTE").Value = dt_tmp.Rows(i)("CR_ID_CTACTE")
            ug_cronograma.Rows(i).Cells("CR_NUM_CUOTA").Value = dt_tmp.Rows(i)("CR_NUM_CUOTA")
            ug_cronograma.Rows(i).Cells("CR_FECHA_PAGO").Value = dt_tmp.Rows(i)("CR_FECHA_PAGO")
            ug_cronograma.Rows(i).Cells("CR_IMPORTE").Value = dt_tmp.Rows(i)("CR_IMPORTE")
            ug_cronograma.Rows(i).Cells("CR_CAPITAL").Value = dt_tmp.Rows(i)("CR_CAPITAL")
            ug_cronograma.Rows(i).Cells("CR_CUOTA").Value = dt_tmp.Rows(i)("CR_CUOTA")
            ug_cronograma.Rows(i).Cells("CR_INTERES").Value = dt_tmp.Rows(i)("CR_INTERES")
            ug_cronograma.Rows(i).Cells("CR_ESTADO").Value = IIf(dt_tmp.Rows(i)("CR_ESTADO") = 1, False, True)
            ug_cronograma.Rows(i).Cells("CR_NO_CONSIDERAR").Value = IIf(dt_tmp.Rows(i)("CR_NO_CONSIDERAR") = 1, True, False)
            If dt_tmp.Rows(i)("CR_ESTADO") = 2 Then cuotas_can += 1

        Next

        ug_cronograma.UpdateData()

        lbl_personal.Text = ug_listado_cta_cte.ActiveRow.Cells("NOMBRES").Value



        ume_cro_fecha_prestamo.Value = ug_listado_cta_cte.ActiveRow.Cells("CC_FECHA_REGISTRO").Value
        ume_cro_importe.Value = ug_listado_cta_cte.ActiveRow.Cells("CC_IMPORTE").Value
        une_cro_num_cuotas.Value = ug_listado_cta_cte.ActiveRow.Cells("CC_NUM_CUOTAS").Value
        ume_cro_saldo.Value = ug_listado_cta_cte.ActiveRow.Cells("CC_SALDO").Value
        une_cro_cuotas_can.Value = cuotas_can
        une_cuotas_pen.Value = CInt(une_cro_num_cuotas.Value) - cuotas_can
        ubtn_Mod_Cronograma.Appearance.Image = My.Resources._16__Card_edit_

        ug_cronograma.DisplayLayout.Bands(0).Columns("CR_FECHA_PAGO").CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        ug_cronograma.DisplayLayout.Bands(0).Columns("CR_IMPORTE").CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        ug_cronograma.DisplayLayout.Bands(0).Columns("CR_NO_CONSIDERAR").CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit

        Lista_A_Eliminar.Clear()
        ubtn_Mod_Cronograma.Text = "Modificar Cronograma"
        ubtn_Cancelar.Visible = False
        ubtn_Regresar.Enabled = True
        Bol_Editar_Imp = False

        ctacteBL = Nothing
        cronogramaBL = Nothing
    End Sub

    Private Sub txt_cod_personal_EditorButtonClick(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinEditors.EditorButtonEventArgs) Handles txt_cod_personal.EditorButtonClick
        Call Mostrar_Ayuda_Empleado()
    End Sub

    Private Sub Calcular_Prestamo()

        ' M= C*(1+i*n) donde M es el monto, C el capital, i es la tasa de interés y n el tiempo

        Dim dbl_monto_total As Double = 0
        Dim dbl_capital As Double = ume_Importe.Value
        Dim dbl_interes As Double = ume_tasaInteres.Value
        Dim dbl_tiempo As Double = une_num_cuota.Value

        dbl_monto_total = dbl_capital * (1 + dbl_interes * dbl_tiempo)


        ume_monto_total.Value = dbl_monto_total
        ume_cuota_mensual.Value = (dbl_monto_total / dbl_tiempo)
        ume_total_interes.Value = (dbl_monto_total - dbl_capital)

        If Bol_Nuevo Then ume_saldo.Value = ume_monto_total.Value

    End Sub

    Private Sub Calcular_Prestamo_IGF()
        'este calculo es realizado por jefa de RRHH

        Call Crear_Tabla_Cronograma()

        Dim dbl_Tasa_interes As Double = (ume_tasaInteres.Value / 100)
        Dim int_num_cuotas As Integer = une_num_cuota.Value
        Dim dbl_capital As Double = ume_Importe.Value
        Dim dbl_capital_dividido As Double = 0
        Dim dbl_cuota1 As Double = 0
        Dim dbl_interes1 As Double = 0
        Dim dbl_capital_auxi As Double = dbl_capital
        Dim dat_fecha_ini As Date = CDate(udte_fecha_Reg.Value).AddDays(30)
        dbl_capital_dividido = dbl_capital / int_num_cuotas

        Dim dr_tmp As DataRow
        For i As Integer = 1 To int_num_cuotas

            dbl_interes1 = dbl_capital_auxi * dbl_Tasa_interes
            dbl_cuota1 = dbl_capital_dividido + dbl_interes1

            dr_tmp = dt_cronograma.NewRow()

            dr_tmp("Num") = i
            dr_tmp("Fecha") = dat_fecha_ini
            dr_tmp("Capital") = dbl_capital_auxi
            dr_tmp("Cuota") = dbl_capital_dividido
            dr_tmp("Interes") = dbl_interes1
            dr_tmp("PagoTotal") = dbl_cuota1

            dt_cronograma.Rows.Add(dr_tmp)

            dbl_capital_auxi = dbl_capital_auxi - dbl_capital_dividido
            dat_fecha_ini = dat_fecha_ini.AddDays(30)

        Next


        ume_monto_total.Value = dt_cronograma.Compute("sum(PagoTotal)", "")
        ume_total_interes.Value = dt_cronograma.Compute("sum(Interes)", "")
        ume_cuota_mensual.Value = dbl_capital_dividido

        If Bol_Nuevo Then ume_saldo.Value = ume_monto_total.Value



    End Sub

    Private Sub Crear_Tabla_Cronograma()
        dt_cronograma = New DataTable
        dt_cronograma.Columns.Add("Num", Type.GetType("System.Int32"))
        dt_cronograma.Columns.Add("Fecha", Type.GetType("System.DateTime"))
        dt_cronograma.Columns.Add("Capital", Type.GetType("System.Double"))
        dt_cronograma.Columns.Add("Cuota", Type.GetType("System.Double"))
        dt_cronograma.Columns.Add("Interes", Type.GetType("System.Double"))
        dt_cronograma.Columns.Add("PagoTotal", Type.GetType("System.Double"))

    End Sub

    Private Sub ume_tasaInteres_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles ume_tasaInteres.KeyDown
        If e.KeyCode = Keys.Enter Then
            'Call Calcular_Prestamo()
            Call Calcular_Prestamo_IGF()
            SendKeys.Send(vbTab)
        End If
    End Sub

    Private Sub uos_estado_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles uos_estado.ValueChanged

        Call Cargar_Listado_CtaCte()

        ubtn_Anular.Enabled = True
        Tool_Editar.Enabled = True

        Select Case uos_estado.Value
            Case 2, 3 'CANCELADO,ANULADO
                ubtn_Anular.Enabled = False
                Tool_Editar.Enabled = False
        End Select
    End Sub

    Private Sub ubtn_formula_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ubtn_formula.Click
        PL_PR_Cronograma.dt_data = dt_cronograma
        PL_PR_Cronograma.ShowDialog()
    End Sub

    Private Sub ug_cronograma_InitializeLayout(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.InitializeLayoutEventArgs) Handles ug_cronograma.InitializeLayout
        'Dim tt As SummarySettings

        'If Not e.Layout.Bands(0).Summaries.Exists("sum_Cuota") Then
        '    tt = e.Layout.Bands(0).Summaries.Add("sum_Cuota", SummaryType.Sum, e.Layout.Bands(0).Columns("cr_Cuota"), SummaryPosition.UseSummaryPositionColumn)
        '    tt.DisplayFormat = "{0:##,##0.00#}"
        '    tt.Appearance.TextHAlign = Infragistics.Win.HAlign.Right
        '    tt.SummaryDisplayArea = SummaryDisplayAreas.BottomFixed
        'End If

        'If Not e.Layout.Bands(0).Summaries.Exists("sum_Interes") Then
        '    tt = e.Layout.Bands(0).Summaries.Add("sum_Interes", SummaryType.Sum, e.Layout.Bands(0).Columns("cr_Interes"), SummaryPosition.UseSummaryPositionColumn)
        '    tt.DisplayFormat = "{0:##,##0.00#}"
        '    tt.Appearance.TextHAlign = Infragistics.Win.HAlign.Right
        '    tt.SummaryDisplayArea = SummaryDisplayAreas.BottomFixed
        'End If

        'If Not e.Layout.Bands(0).Summaries.Exists("sum_PagoTotal") Then
        '    tt = e.Layout.Bands(0).Summaries.Add("sum_PagoTotal", SummaryType.Sum, e.Layout.Bands(0).Columns("CR_IMPORTE"), SummaryPosition.UseSummaryPositionColumn)
        '    tt.DisplayFormat = "{0:##,##0.00#}"
        '    tt.Appearance.TextHAlign = Infragistics.Win.HAlign.Right
        '    tt.SummaryDisplayArea = SummaryDisplayAreas.BottomFixed
        'End If


        'e.Layout.Bands(0).SummaryFooterCaption = "Totales"
    End Sub

    Private Sub ubtn_Anular_Click(sender As System.Object, e As System.EventArgs) Handles ubtn_Anular.Click

        If ug_listado_cta_cte.Rows.Count = 0 Then Exit Sub

        Dim ctacteBL As New BL.PlanillaBL.SG_PL_TB_CTA_CTE
        Dim ctacteBE As New BE.PlanillaBE.SG_PL_TB_CTA_CTE With {.CC_ID = ug_listado_cta_cte.ActiveRow.Cells("CC_ID").Value}
        Dim estadoBE As New BE.PlanillaBE.SG_PL_TB_ESTADO_PRESTAMO With {.EP_ID = 3}

        If Preguntar("Seguro de Anular el Registro") Then
            ctacteBL.Actualizar_Estado_Prestamo(estadoBE, ctacteBE)
            Call Avisar("Listo!")
            Call Cargar_Listado_CtaCte()
        End If

        estadoBE = Nothing
        ctacteBL = Nothing
        ctacteBE = Nothing
    End Sub

    Private Sub ume_monto_total_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles ume_monto_total.KeyDown
        If e.KeyCode = Keys.Enter Then SendKeys.Send(vbTab)
    End Sub

    Private Sub ume_cuota_mensual_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles ume_cuota_mensual.KeyDown
        If e.KeyCode = Keys.Enter Then SendKeys.Send(vbTab)
    End Sub

    Private Sub ume_total_interes_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles ume_total_interes.KeyDown
        If e.KeyCode = Keys.Enter Then SendKeys.Send(vbTab)
    End Sub

    Private Sub ume_saldo_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles ume_saldo.KeyDown
        If e.KeyCode = Keys.Enter Then SendKeys.Send(vbTab)
    End Sub

    Private Sub ubtn_exportar_Click(sender As System.Object, e As System.EventArgs) Handles ubtn_exportar.Click
        Me.Cursor = Cursors.WaitCursor
        Dim nombreFile As String = "CtaCorri_" & lbl_personal.Text.Trim & Date.Now.Minute.ToString & Date.Now.Second.ToString & ".xls"
        uge_ctacor.Export(ug_cronograma, nombreFile)
        Process.Start(nombreFile)
        Me.Cursor = Cursors.Default
    End Sub
End Class