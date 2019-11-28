
Public Class PL_PR_Exp_Arch_MasivoSueldo

    Private Sub PL_PR_Exp_Arch_MasivoSueldo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Call CargarCombo_ConMeses(uce_Mes)
        une_Ayo.Value = gDat_Fecha_Sis.Year
        uce_Mes.Value = gDat_Fecha_Sis.Month

        Call Formatear_Grilla_Selector(ug_datos)

        

    End Sub

    Private Sub Tool_Salir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_Salir.Click
        Me.Close()
    End Sub

    Private Sub Tool_Abrir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_Abrir.Click
        Dim Str_vRutaPdt As String
        Dim paraetrosBL As New BL.PlanillaBL.SG_PL_TB_PARAMETROS
        Dim paraetrosBE As New BE.PlanillaBE.SG_PL_TB_PARAMETROS
        paraetrosBE.AD_IDEMPRESA = gInt_IdEmpresa
        paraetrosBE.AD_TIPO = "RUTA"
        paraetrosBE.AD_NOMBRE = "PDT"

        Str_vRutaPdt = paraetrosBL.get_Valor(paraetrosBE)

        paraetrosBE = Nothing
        paraetrosBL = Nothing

        Process.Start("explorer.exe", Str_vRutaPdt & "Banco")
    End Sub

    Private Sub Tool_Procesar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_Procesar.Click
        Call Generar_Archivo_aExportar()
    End Sub

    Private Sub Generar_Archivo_aExportar()

        If uos_periodo.Value = 4 Then
            If txt_cod_folio.Text = "" Then
                Avisar("Ingrese el codigo del folio")
                txt_cod_folio.Focus()
                Exit Sub
            End If
        End If

        Dim archivosBL As New BL.PlanillaBL.PDT(gInt_IdEmpresa)
        Dim dtt As DataTable = Nothing
        dtt = archivosBL.get_Lista_para_ArchivoMasivo_2012(une_Ayo.Value, uce_Mes.Value, uos_periodo.Value, gInt_IdEmpresa, txt_cod_folio.Text.Trim)
        ug_datos.DataSource = dtt
    End Sub

    Private Sub Tool_Generar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_Generar.Click

      

        If ug_datos.Rows.Count = 0 Then
            Avisar("No hay datos para continuar")
            Exit Sub
        End If

        

        PL_PR_DatosArchivo_Plani_ScotiaBank.ShowDialog()
        If PL_PR_DatosArchivo_Plani_ScotiaBank.pbol_Aceptar Then



            If PL_PR_DatosArchivo_Plani_ScotiaBank.pCod_Intit.Length = 0 Then
                Avisar("Ingresar el ruc de la empresa")
                Exit Sub
            End If

            If PL_PR_DatosArchivo_Plani_ScotiaBank.pCod_tipoServi.Length = 0 Then
                Avisar("Seleccione un tipo de servicio")
                Exit Sub
            End If

            If PL_PR_DatosArchivo_Plani_ScotiaBank.pCod_FechaAbo.Length = 0 Then
                Avisar("Seleccione una fecha")
                Exit Sub
            End If

            If PL_PR_DatosArchivo_Plani_ScotiaBank.pCod_Responsable.Length = 0 Then
                Avisar("Ingrese el nombre de la persona responsable del envio")
                Exit Sub
            End If

            If PL_PR_DatosArchivo_Plani_ScotiaBank.pCod_Intit.Length = 0 Then
                Avisar("Ingrese la cuenta corriente de la institucion")
                Exit Sub
            End If





            Me.Cursor = Cursors.WaitCursor
            Dim archivosBL As New BL.PlanillaBL.PDT(gInt_IdEmpresa)
            archivosBL.Generar_ArchivoMasivo_2012(une_Ayo.Value, uce_Mes.Value, uos_periodo.Value, gInt_IdEmpresa, _
                                                   PL_PR_DatosArchivo_Plani_ScotiaBank.pCod_tipoServi, _
                                                  PL_PR_DatosArchivo_Plani_ScotiaBank.pCod_CuentaCargo, _
                                                  PL_PR_DatosArchivo_Plani_ScotiaBank.pCod_Responsable, _
                                                  CDate(PL_PR_DatosArchivo_Plani_ScotiaBank.pCod_FechaAbo), _
                                                  PL_PR_DatosArchivo_Plani_ScotiaBank.pCod_Intit, _
                                                  PL_PR_DatosArchivo_Plani_ScotiaBank.pZipear, txt_cod_folio.Text.Trim)
            archivosBL = Nothing
            Me.Cursor = Cursors.Default

            Avisar("Listo!")
        End If

        

    End Sub

    Private Sub uos_periodo_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles uos_periodo.ValueChanged
        Call LimpiaGrid(ug_datos, uds_datos)

        If uos_periodo.Value = 4 Then
            txt_cod_folio.Enabled = True
        Else
            txt_cod_folio.Enabled = False
            txt_cod_folio.Text = ""
        End If
    End Sub

    Private Sub txt_cod_inti_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        If e.KeyCode = Keys.Enter Then SendKeys.Send(vbTab)
    End Sub

    Private Sub uce_tipo_servicio_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        If e.KeyCode = Keys.Enter Then SendKeys.Send(vbTab)
    End Sub

    Private Sub udte_fec_abono_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        If e.KeyCode = Keys.Enter Then SendKeys.Send(vbTab)
    End Sub

    Private Sub txt_responsable_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        If e.KeyCode = Keys.Enter Then SendKeys.Send(vbTab)
    End Sub

    Private Sub txt_cta_cargo_insti_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        If e.KeyCode = Keys.Enter Then SendKeys.Send(vbTab)
    End Sub

    Private Sub Tool_GenerarConExcel_Click(sender As System.Object, e As System.EventArgs) Handles Tool_GenerarConExcel.Click

        If uos_periodo.Value = 4 Then
            If txt_cod_folio.Text = "" Then
                Avisar("Ingrese el codigo del folio")
                txt_cod_folio.Focus()
                Exit Sub
            End If
        End If


        Dim archivosBL As New BL.PlanillaBL.PDT(gInt_IdEmpresa)
        Dim dtt As DataTable = Nothing
        'archivosBL.Generar_ArchivoMasivo_EnExcel(une_Ayo.Value, uce_Mes.Value, uos_periodo.Value, gInt_IdEmpresa, 0, "", "", CDate(udte_fec_abono.Value), "", False, 0)


        Me.Cursor = Cursors.WaitCursor
        archivosBL.Generar_ArchivoMasivo_EnExcel_2012(une_Ayo.Value, uce_Mes.Value, uos_periodo.Value, gInt_IdEmpresa, gDat_Fecha_Sis, txt_cod_folio.Text.Trim)
        archivosBL = Nothing
        Me.Cursor = Cursors.Default
        Avisar("Listo!")
        Tool_Abrir_Click(sender, e)

        
        
        
    End Sub

    Private Sub ToolStrip1_ItemClicked(sender As System.Object, e As System.Windows.Forms.ToolStripItemClickedEventArgs) Handles ToolStrip1.ItemClicked

    End Sub
End Class