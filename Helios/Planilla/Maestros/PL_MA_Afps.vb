Public Class PL_MA_Afps

    Dim Bol_Nuevo As Boolean

    Private Sub PL_MA_Afps_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call Inicializar_Estado_Botones_Tool(ToolS_Mantenimiento)
        Call Cargar_Lista_Afp()
        Call Cargar_Codigo_Sunat()
        Call Cargar_Cuentas_Combo()
        Call Formatear_Grilla_Selector(ug_Listado)
        Call MostrarTabs(0, utc_Impuestos, 0)

    End Sub

    Private Sub Cargar_Lista_Afp()
        Dim afpBL As New BL.PlanillaBL.SG_PL_TB_AFP
        Dim empresaBE As New BE.ContabilidadBE.SG_CO_TB_EMPRESA
        Dim dt_tmp As DataTable = Nothing
        empresaBE.EM_ID = gInt_IdEmpresa
        dt_tmp = afpBL.getAfp(empresaBE)

        Call LimpiaGrid(ug_Listado, uds_Afp)

        For i As Integer = 0 To dt_tmp.Rows.Count - 1
            ug_Listado.DisplayLayout.Bands(0).AddNew()
            ug_Listado.Rows(i).Cells("AF_ID").Value = dt_tmp.Rows(i)("AF_ID")
            ug_Listado.Rows(i).Cells("AF_NOMBRE").Value = dt_tmp.Rows(i)("AF_NOMBRE")
            ug_Listado.Rows(i).Cells("AF_COMISION_FIJA").Value = dt_tmp.Rows(i)("AF_COMISION_FIJA")
            ug_Listado.Rows(i).Cells("AF_COMISION_VAR").Value = dt_tmp.Rows(i)("AF_COMISION_VAR")
            ug_Listado.Rows(i).Cells("AF_COMISION_VAR2").Value = dt_tmp.Rows(i)("AF_COMISION_VAR2")
            ug_Listado.Rows(i).Cells("AF_SEGURO").Value = dt_tmp.Rows(i)("AF_SEGURO")
            ug_Listado.Rows(i).Cells("AF_IDCUENTA_CONTA").Value = dt_tmp.Rows(i)("AF_IDCUENTA_CONTA").ToString
        Next
        ug_Listado.UpdateData()

        dt_tmp = Nothing
        empresaBE = Nothing
        afpBL = Nothing
    End Sub

    Private Sub Cargar_Cuentas_Combo()

        Dim PlanCtasBL As New BL.ContabilidadBL.SG_CO_TB_PLANCTAS
        Dim PlanCtasBE As New BE.ContabilidadBE.SG_CO_TB_PLANCTAS

        PlanCtasBE.PC_IDEMPRESA = New BE.ContabilidadBE.SG_CO_TB_EMPRESA With {.EM_ID = gInt_IdEmpresa}
        PlanCtasBE.PC_PERIODO = gDat_Fecha_Sis.Year

        uc_Cuentas.DataSource = PlanCtasBL.getCuentas_Movimiento(PlanCtasBE)

        PlanCtasBE = Nothing
        PlanCtasBL = Nothing

    End Sub

    Private Sub Cargar_Codigo_Sunat()
        Dim pensionesBL As New BL.PlanillaBL.SG_PL_TB_PENSIONES
        uce_cod_sunat.DataSource = pensionesBL.getPensiones()
        uce_cod_sunat.ValueMember = "PE_ID"
        uce_cod_sunat.DisplayMember = "PE_DESCRIPCION"
        pensionesBL = Nothing
    End Sub

    Private Sub Tool_Nuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_Nuevo.Click
        Call Cambiar_Estado_Botones_Tool(ToolS_Mantenimiento)
        Call MostrarTabs(1, utc_Impuestos, 1)
        Call Limpiar_Controls_InGroupox(ugb_datos)
        ume_tel.Value = Nothing
        uce_cod_sunat.Value = 12

        Dim afpBL As New BL.PlanillaBL.SG_PL_TB_AFP
        txt_codigo.Text = afpBL.get_Ult_Cod(gInt_IdEmpresa)
        afpBL = Nothing

        Bol_Nuevo = True
        txt_codigo.Enabled = True
        txt_nombre.Focus()

    End Sub

    Private Sub txt_codigo_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_codigo.KeyDown, ume_tope_seguro.KeyDown, ume_tel.KeyDown, ume_seguro.KeyDown, ume_comi_var.KeyDown, ume_comi_fija.KeyDown, txt_nombre.KeyDown, txt_dir.KeyDown, ume_comi_var2.KeyDown
        If e.KeyCode = Keys.Enter Then SendKeys.Send(vbTab)
    End Sub

    Private Sub Tool_Salir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_Salir.Click
        Me.Close()
    End Sub

    Private Sub Tool_Editar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_Editar.Click
        Bol_Nuevo = False
        Call Cambiar_Estado_Botones_Tool(ToolS_Mantenimiento)
        Dim afpBL As New BL.PlanillaBL.SG_PL_TB_AFP
        Dim afpBE As New BE.PlanillaBE.SG_PL_TB_AFP
        afpBE.AF_ID = ug_Listado.ActiveRow.Cells("AF_ID").Value
        afpBE.AF_IDEMPRESA = New BE.ContabilidadBE.SG_CO_TB_EMPRESA With {.EM_ID = gInt_IdEmpresa}
        afpBL.getAfp_x_Id(afpBE)

        Call Limpiar_Controls_InGroupox(ugb_datos)

        With afpBE
            txt_codigo.Text = .AF_ID
            txt_nombre.Text = .AF_NOMBRE
            txt_dir.Text = .AF_DIRECCION
            ume_tel.Value = .AF_TELEFONO
            ume_comi_fija.Value = .AF_COMISION_FIJA
            ume_comi_var.Value = .AF_COMISION_VAR
            ume_comi_var2.Value = .AF_COMISION_VAR2
            ume_seguro.Value = .AF_SEGURO
            ume_tope_seguro.Value = .AF_TOPE_SEGURO
            uc_Cuentas.Value = .AF_IDCUENTA_CONTA.PC_NUM_CUENTA
            uce_cod_sunat.Value = .AF_COD_SUNAT.PE_ID
        End With

        txt_codigo.Enabled = False
        Call MostrarTabs(1, utc_Impuestos, 1)
        txt_nombre.Focus()

        afpBE = Nothing
        afpBL = Nothing

    End Sub

    Private Sub Tool_Cancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_Cancelar.Click
        Call MostrarTabs(0, utc_Impuestos, 0)
        Call Cambiar_Estado_Botones_Tool(ToolS_Mantenimiento)
    End Sub

    Private Sub Tool_Eliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_Eliminar.Click
        Dim afpBL As New BL.PlanillaBL.SG_PL_TB_AFP
        Dim afpBE As New BE.PlanillaBE.SG_PL_TB_AFP

        If Preguntar("Seguro de eliminar?") Then
            afpBE.AF_IDEMPRESA = New BE.ContabilidadBE.SG_CO_TB_EMPRESA With {.EM_ID = gInt_IdEmpresa}
            afpBE.AF_ID = ug_Listado.ActiveRow.Cells("AF_ID").Value
            afpBL.Delete(afpBE)
            Call Cargar_Lista_Afp()
            Avisar("Listo!")
        End If

        afpBE = Nothing
        afpBL = Nothing
    End Sub

    Private Sub Tool_Grabar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_Grabar.Click

        If txt_codigo.Text = "" Then
            Avisar("Ingrese el codigo de la AFP")
            txt_codigo.Focus()
            Exit Sub
        End If

        If txt_nombre.Text = "" Then
            Avisar("Ingrese el nombre de la AFP")
            txt_nombre.Focus()
            Exit Sub
        End If


        If uce_cod_sunat.Value Is Nothing Then
            Avisar("Ingrese el codigod Sunat de la AFP")
            uce_cod_sunat.Focus()
            Exit Sub
        End If

        Dim afpBL As New BL.PlanillaBL.SG_PL_TB_AFP
        Dim afpBE As New BE.PlanillaBE.SG_PL_TB_AFP

        With afpBE
            .AF_ID = txt_codigo.Text.Trim
            .AF_NOMBRE = txt_nombre.Text.Trim
            .AF_DIRECCION = txt_dir.Text.Trim
            .AF_TELEFONO = ume_tel.Value.ToString
            .AF_COMISION_FIJA = ume_comi_fija.Value
            .AF_COMISION_VAR = ume_comi_var.Value
            .AF_COMISION_VAR2 = ume_comi_var2.Value
            .AF_SEGURO = ume_seguro.Value
            .AF_TOPE_SEGURO = ume_tope_seguro.Value
            .AF_IDCUENTA_CONTA = New BE.ContabilidadBE.SG_CO_TB_PLANCTAS With {.PC_NUM_CUENTA = uc_Cuentas.Value}
            .AF_IDEMPRESA = New BE.ContabilidadBE.SG_CO_TB_EMPRESA With {.EM_ID = gInt_IdEmpresa}
            .AF_COD_SUNAT = New BE.PlanillaBE.SG_PL_TB_PENSIONES With {.PE_ID = uce_cod_sunat.Value}
        End With

        If Bol_Nuevo Then afpBL.Insert(afpBE) Else afpBL.Update(afpBE)

        afpBE = Nothing
        afpBL = Nothing

        Call Cargar_Lista_Afp()

        Call Avisar("Listo!")

        Call Tool_Cancelar_Click(sender, e)

    End Sub

    Private Sub ug_Listado_DoubleClickRow(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.DoubleClickRowEventArgs) Handles ug_Listado.DoubleClickRow
        Call Tool_Editar_Click(sender, e)
    End Sub

    Private Sub uc_Cuentas_InitializeLayout(sender As System.Object, e As Infragistics.Win.UltraWinGrid.InitializeLayoutEventArgs) Handles uc_Cuentas.InitializeLayout

    End Sub

    Private Sub uc_Cuentas_ValueChanged(sender As Object, e As System.EventArgs) Handles uc_Cuentas.ValueChanged
        Try
            txt_des_cta.Text = uc_Cuentas.ActiveRow.Cells("PC_DESCRIPCION").Value
        Catch ex As Exception
            txt_des_cta.Text = ""
        End Try
    End Sub
End Class