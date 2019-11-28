Public Class PL_PR_Calculo_Utilidad
    Dim total_horas_x_per As TimeSpan = Nothing
    Dim total_remus As Double = 0

    Private Sub PL_PR_Calculo_Utilidad_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        ugb_Parametros.Enabled = False
        btn_agregar.Enabled = False
        une_Ayo.Value = gDat_Fecha_Sis.Year
    End Sub

    Private Sub Tool_Salir_Click(sender As System.Object, e As System.EventArgs) Handles Tool_Salir.Click
        Me.Close()
    End Sub

    Private Sub Tool_Imprimir_Click(sender As System.Object, e As System.EventArgs) Handles Tool_Imprimir.Click

    End Sub

    Private Sub Tool_Exportar_Click(sender As System.Object, e As System.EventArgs)

    End Sub

    Private Sub btn_agregar_Click(sender As System.Object, e As System.EventArgs) Handles btn_agregar.Click

        PL_PR_Lista_Personal.Int_tipo_Personal = 0
        PL_PR_Lista_Personal.Bol_habilitar_uos = True
        PL_PR_Lista_Personal.Bol_MultiSeleccion = True
        PL_PR_Lista_Personal.ShowDialog()
        If PL_PR_Lista_Personal.Bol_Aceptar Then
            Dim matriz As New List(Of BE.PlanillaBE.SG_PL_TB_PERSONAL)
            matriz = PL_PR_Lista_Personal.lista_empleados
            If matriz.Count > 0 Then
                For Each empleado As BE.PlanillaBE.SG_PL_TB_PERSONAL In matriz
                    If Not Existe_Personal_EnGrilla(empleado.PE_ID) Then
                        ug_lista.DisplayLayout.Bands(0).AddNew()
                        Dim fila As Integer = ug_lista.Rows.Count - 1
                        ug_lista.Rows(fila).Cells("idpersonal").Value = empleado.PE_ID
                        ug_lista.Rows(fila).Cells("nombres").Value = empleado.PE_APE_PAT & " " & empleado.PE_APE_MAT & " " & empleado.PE_NOM_PRI
                        ug_lista.Rows(fila).Cells("num_horas").Value = 0
                        ug_lista.Rows(fila).Cells("participa_horas").Value = 0
                        ug_lista.Rows(fila).Cells("computable_emp").Value = 0
                        ug_lista.Rows(fila).Cells("participa_emp").Value = 0
                    End If
                Next
            End If
        End If

        ug_lista.UpdateData()
    End Sub

    Private Function Existe_Personal_EnGrilla(ByVal Personal As String) As Boolean
        Existe_Personal_EnGrilla = False

        For i As Integer = 0 To ug_lista.Rows.Count - 1
            If ug_lista.Rows(i).Cells("idpersonal").Value.ToString.Equals(Personal) Then
                Existe_Personal_EnGrilla = Not Existe_Personal_EnGrilla
                Exit For
            End If
        Next

    End Function


    Private Sub Tool_grabar_Click(sender As System.Object, e As System.EventArgs) Handles Tool_grabar.Click

        Dim utilidadesBL As New BL.PlanillaBL.SG_PL_TB_REG_UTILIDAD_C
        Dim utilidadesBE As New BE.PlanillaBE.SG_PL_TB_REG_UTILIDAD_C

        Dim detalleBL As New BL.PlanillaBL.SG_PL_TB_REG_UTILIDAD_D
        Dim detalleBE As BE.PlanillaBE.SG_PL_TB_REG_UTILIDAD_D

        With utilidadesBE
            .RU_IDANHO = une_Ayo.Value
            .RU_RENTA_ANUAL = ume_renta_anual.Value
            .RU_PORCEN_DISTRI = ume_porcentaje.Value
            .RU_MONTO_DISTRI = ume_monto_distri.Value
            .RU_NUM_TOT_HOR = txt_tot_horas.Text
            .RU_REMU_COMPU = txt_tot_remu.Text
            .RU_IDEMPRESA = gInt_IdEmpresa
        End With

        utilidadesBL.delete(utilidadesBE)
        utilidadesBL.insert(utilidadesBE)


        For i As Integer = 0 To ug_lista.Rows.Count - 1
            detalleBE = New BE.PlanillaBE.SG_PL_TB_REG_UTILIDAD_D
            With detalleBE
                .RD_IDANHO = une_Ayo.Value
                .RD_IDEMPRESA = gInt_IdEmpresa
                .RD_IDPERSONAL = ug_lista.Rows(i).Cells("idpersonal").Value
                .RD_NUM_HORAS_LAB_EMP = ug_lista.Rows(i).Cells("num_horas").Value
                .RD_PARTICI_EMP_HOR = ug_lista.Rows(i).Cells("participa_horas").Value
                .RD_REMU_COMPU_EMP = ug_lista.Rows(i).Cells("computable_emp").Value
                .RD_PARTICI_EMP_REMU = ug_lista.Rows(i).Cells("participa_emp").Value
                .RD_FACT_HORAS = ug_lista.Rows(i).Cells("fact_horas").Value
                .RD_FACT_REMU = ug_lista.Rows(i).Cells("fact_remu").Value
                .RD_TOTAL_UTI = ug_lista.Rows(i).Cells("total_util").Value
            End With
            detalleBL.insert(detalleBE)
        Next

        Avisar("Listo!")
        Call bloquear()

    End Sub

    Private Sub bloquear()
        ugb_Parametros.Enabled = Not ugb_Parametros.Enabled
        btn_agregar.Enabled = Not btn_agregar.Enabled

    End Sub

    Private Sub une_Ayo_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles une_Ayo.KeyDown
        If e.KeyCode = Keys.Enter Then
            Call Cargar_Datos()
            Call Sumar_Horas()
            Call Sumar_Remuneraciones()
            Call bloquear()
        End If
    End Sub

    Private Sub Cargar_Datos()
        Dim utilidadBL As New BL.PlanillaBL.SG_PL_TB_REG_UTILIDAD_C
        Dim ds_datos As DataSet = utilidadBL.get_reg_utilidad(une_Ayo.Value, gInt_IdEmpresa)

        If ds_datos.Tables(0).Rows.Count > 0 Then
            ume_renta_anual.Value = ds_datos.Tables(0).Rows(0)("RU_RENTA_ANUAL")
            ume_porcentaje.Value = ds_datos.Tables(0).Rows(0)("RU_PORCEN_DISTRI")
            ume_monto_distri.Value = ds_datos.Tables(0).Rows(0)("RU_MONTO_DISTRI")
            txt_tot_horas.Text = ds_datos.Tables(0).Rows(0)("RU_NUM_TOT_HOR")
            txt_tot_remu.Text = ds_datos.Tables(0).Rows(0)("RU_REMU_COMPU")
        End If

        LimpiaGrid(ug_lista, uds_lista)

        For i As Integer = 0 To ds_datos.Tables(1).Rows.Count - 1
            ug_lista.DisplayLayout.Bands(0).AddNew()
            ug_lista.Rows(i).Cells("idpersonal").Value = ds_datos.Tables(1).Rows(i)("RD_IDPERSONAL")
            ug_lista.Rows(i).Cells("nombres").Value = ds_datos.Tables(1).Rows(i)("personal")
            ug_lista.Rows(i).Cells("num_horas").Value = ds_datos.Tables(1).Rows(i)("RD_NUM_HORAS_LAB_EMP")
            ug_lista.Rows(i).Cells("participa_horas").Value = ds_datos.Tables(1).Rows(i)("RD_PARTICI_EMP_HOR")
            ug_lista.Rows(i).Cells("computable_emp").Value = ds_datos.Tables(1).Rows(i)("RD_REMU_COMPU_EMP")
            ug_lista.Rows(i).Cells("participa_emp").Value = ds_datos.Tables(1).Rows(i)("RD_PARTICI_EMP_REMU")

            ug_lista.Rows(i).Cells("fact_horas").Value = ds_datos.Tables(1).Rows(i)("RD_FACT_HORAS")
            ug_lista.Rows(i).Cells("fact_remu").Value = ds_datos.Tables(1).Rows(i)("RD_FACT_REMU")
            ug_lista.Rows(i).Cells("total_util").Value = ds_datos.Tables(1).Rows(i)("RD_TOTAL_UTI")
        Next

        ug_lista.UpdateData()


    End Sub

    Private Sub Sumar_Horas()

        total_horas_x_per = New TimeSpan(0, 0, 0)

        For i As Integer = 0 To ug_lista.Rows.Count - 1
            Dim HMS As String()

            If ug_lista.Rows(i).Cells("num_horas").Value.ToString <> "" Then
                HMS = ug_lista.Rows(i).Cells("num_horas").Value.ToString.Split(":")
                total_horas_x_per = total_horas_x_per.Add(New TimeSpan(CInt(HMS(0)), CInt(HMS(1)), CInt(HMS(2))))
            End If
        Next

        txt_tot_horas.Text = total_horas_x_per.TotalHours

    End Sub

    Private Sub Sumar_Remuneraciones()

        total_remus = 0
        For i As Integer = 0 To ug_lista.Rows.Count - 1
            If ug_lista.Rows(i).Cells("computable_emp").Value.ToString <> "" Then
                total_remus += ug_lista.Rows(i).Cells("computable_emp").Value
            End If
        Next

        txt_tot_remu.Text = Math.Round(total_remus, 2)
    End Sub

    Private Sub ume_renta_anual_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles ume_renta_anual.KeyDown
        If e.KeyCode = Keys.Enter Then
            ume_porcentaje.Focus()
        End If
    End Sub

    Private Sub ume_porcentaje_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles ume_porcentaje.KeyDown
        If e.KeyCode = Keys.Enter Then
            ume_monto_distri.Focus()
        End If
    End Sub

    Private Sub ume_monto_distri_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles ume_monto_distri.KeyDown
        If e.KeyCode = Keys.Enter Then
            txt_tot_horas.Focus()
        End If
    End Sub

    Private Sub ume_num_tot_hor_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs)
        If e.KeyCode = Keys.Enter Then
            txt_tot_remu.Focus()
        End If
    End Sub

    Private Sub btn_eliminar_Click(sender As System.Object, e As System.EventArgs) Handles btn_eliminar.Click
        If ug_lista.ActiveRow Is Nothing Then Exit Sub

        ug_lista.ActiveRow.Delete(False)
    End Sub


    Private Sub ubtn_procesar_Click(sender As System.Object, e As System.EventArgs) Handles ubtn_procesar.Click
        Call Sumar_Horas()
        Call Sumar_Remuneraciones()
        Call Procesar()
    End Sub

    Private Sub Procesar()
        Dim HMS As String()
        Dim hora_x_per As TimeSpan = Nothing
        For i As Integer = 0 To ug_lista.Rows.Count - 1
            If ug_lista.Rows(i).Cells("num_horas").Value.ToString <> "" Then
                HMS = ug_lista.Rows(i).Cells("num_horas").Value.ToString.Split(":")
                hora_x_per = New TimeSpan(CInt(HMS(0)), CInt(HMS(1)), CInt(HMS(2)))
                ug_lista.Rows(i).Cells("fact_horas").Value = Math.Round((hora_x_per.TotalHours / total_horas_x_per.TotalHours), 13)
                ug_lista.Rows(i).Cells("participa_horas").Value = Math.Round((hora_x_per.TotalHours / total_horas_x_per.TotalHours), 13) * (CDbl(ume_monto_distri.Value) / 2)
            Else
                ug_lista.Rows(i).Cells("fact_horas").Value = 0
                ug_lista.Rows(i).Cells("participa_horas").Value = 0
            End If

            If ug_lista.Rows(i).Cells("computable_emp").Value.ToString <> "" Then
                ug_lista.Rows(i).Cells("fact_remu").Value = Math.Round(ug_lista.Rows(i).Cells("computable_emp").Value / total_remus, 11)
                ug_lista.Rows(i).Cells("participa_emp").Value = Math.Round(ug_lista.Rows(i).Cells("computable_emp").Value / total_remus, 11) * (CDbl(ume_monto_distri.Value) / 2)
            Else
                ug_lista.Rows(i).Cells("fact_remu").Value = 0
                ug_lista.Rows(i).Cells("participa_emp").Value = 0
            End If

            ug_lista.Rows(i).Cells("total_util").Value = Math.Round(ug_lista.Rows(i).Cells("participa_horas").Value, 2) + Math.Round(ug_lista.Rows(i).Cells("participa_emp").Value, 2)
        Next
        ug_lista.UpdateData()
    End Sub
End Class