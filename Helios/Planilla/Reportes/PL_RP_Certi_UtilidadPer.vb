Public Class PL_RP_Certi_UtilidadPer

    Private Sub Tool_Reporte_Click(sender As System.Object, e As System.EventArgs) Handles Tool_Reporte.Click

        If ug_lista.Rows.Count = 0 Then
            Avisar("Cargue la informacion.")
            une_ayo.Focus()
            Exit Sub
        End If


        Dim Obj_Crystal As New LR.ClsReporte
        Dim dt_data As New DataTable
        dt_data.Columns.Add("CODPER", Type.GetType("System.String"))

        Dim emp As String = ug_lista.ActiveRow.Cells("nombres").Value
        Dim num_hor_lab As String = ug_lista.ActiveRow.Cells("num_horas").Value
        Dim partici_trabajador As Double = ug_lista.ActiveRow.Cells("participa_horas").Value
        Dim remu_computable As Double = ug_lista.ActiveRow.Cells("computable_emp").Value
        Dim participacion As Double = ug_lista.ActiveRow.Cells("participa_emp").Value

        Me.Cursor = Cursors.WaitCursor

        Obj_Crystal.Muestra_Reporte(gStr_RutaRep & "\SG_PL_27.rpt", dt_data, "", "pfecha;" & txt_fec.Text.Trim, "pEmpleado;" & emp, "pPeriodo;" & une_ayo.Text.Trim, _
                                    "pP01;" & txt_renta_anual.Text.Trim, "pP02;" & txt_porc_distri.Text, "pP03;" & txt_monto_distri.Text, "pP04;" & txt_num_tot_hor.Text, _
                                    "pP05;" & txt_remu_compu.Text, "pP06;" & num_hor_lab, "pP07;" & partici_trabajador, "pP08;" & remu_computable, "pP09;" & participacion)

        Me.Cursor = Cursors.Default
    End Sub

    Private Sub Tool_Salir_Click(sender As System.Object, e As System.EventArgs) Handles Tool_Salir.Click
        Me.Close()
    End Sub

    Private Sub PL_RP_Certi_UtilidadPer_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

        txt_fec.Text = "Miraflores, " & Format(Now.Date, "dd") & " de " & Format(Now.Date, "MMMM ") & " del " & Format(Now.Date, "yyyy")

    End Sub

    Private Sub Cargar_Datos()
        Dim utilidadBL As New BL.PlanillaBL.SG_PL_TB_REG_UTILIDAD_C
        Dim ds_datos As DataSet = utilidadBL.get_reg_utilidad(une_Ayo.Value, gInt_IdEmpresa)
        utilidadBL = Nothing

        If ds_datos.Tables(0).Rows.Count > 0 Then
            txt_renta_anual.Text = ds_datos.Tables(0).Rows(0)("RU_RENTA_ANUAL")
            txt_porc_distri.Text = ds_datos.Tables(0).Rows(0)("RU_PORCEN_DISTRI")
            txt_monto_distri.Text = ds_datos.Tables(0).Rows(0)("RU_MONTO_DISTRI")
            txt_num_tot_hor.Text = ds_datos.Tables(0).Rows(0)("RU_NUM_TOT_HOR")
            txt_remu_compu.Text = ds_datos.Tables(0).Rows(0)("RU_REMU_COMPU")
        End If

        Call LimpiaGrid(ug_lista, uds_lista)

        For i As Integer = 0 To ds_datos.Tables(1).Rows.Count - 1
            ug_lista.DisplayLayout.Bands(0).AddNew()
            ug_lista.Rows(i).Cells("idpersonal").Value = ds_datos.Tables(1).Rows(i)("RD_IDPERSONAL")
            ug_lista.Rows(i).Cells("nombres").Value = ds_datos.Tables(1).Rows(i)("personal")
            ug_lista.Rows(i).Cells("num_horas").Value = ds_datos.Tables(1).Rows(i)("RD_NUM_HORAS_LAB_EMP")
            ug_lista.Rows(i).Cells("participa_horas").Value = ds_datos.Tables(1).Rows(i)("RD_PARTICI_EMP_HOR")
            ug_lista.Rows(i).Cells("computable_emp").Value = ds_datos.Tables(1).Rows(i)("RD_REMU_COMPU_EMP")
            ug_lista.Rows(i).Cells("participa_emp").Value = ds_datos.Tables(1).Rows(i)("RD_PARTICI_EMP_REMU")
        Next

        ug_lista.UpdateData()


    End Sub

    Private Sub une_ayo_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles une_ayo.KeyDown
        If une_ayo.Text = "" Then
            Exit Sub
        End If

        If e.KeyCode = Keys.Enter Then
            Call Cargar_Datos()
        End If
    End Sub

    Private Sub ugb_Parametros_Click(sender As System.Object, e As System.EventArgs) Handles ugb_Parametros.Click

    End Sub
End Class