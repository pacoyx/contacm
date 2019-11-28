Public Class PL_PR_Sincro_Vacaciones

    Private Sub PL_PR_Sincro_Vacaciones_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        upb_1.Visible = False

        Call CargarCombo_ConMeses(uce_Mes)
        une_Ayo.Value = gDat_Fecha_Sis.Year
        uce_Mes.SelectedIndex = -1

        Call Agregar_Columna_Periodo()

        Me.Width = 842

    End Sub

    Private Sub Agregar_Columna_Periodo()

        Dim dt_periodos As New DataTable
        dt_periodos.Columns.Add("COD", Type.GetType("System.String"))
        dt_periodos.Columns.Add("DES", Type.GetType("System.String"))

        Dim str_periodo As String = ""
        Dim fila As DataRow = Nothing

        For i As Integer = 2009 To 2015
            fila = dt_periodos.NewRow()
            str_periodo = i.ToString & " - " & (i + 1).ToString
            fila(0) = str_periodo
            fila(1) = str_periodo
            dt_periodos.Rows.Add(fila)
        Next


        'igual se llama
        Call CrearComboGrid("PERIODO", "DES", ug_ListaVaca, dt_periodos, True)

    End Sub

    Private Sub Tool_Salir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_Salir.Click
        Me.Close()
    End Sub

    Private Sub Tool_Sincronizar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_Sincronizar.Click

        ug_ListaVaca.UpdateData()
        For i As Integer = 0 To ug_ListaVaca.Rows.Count - 1
            If ug_ListaVaca.Rows(i).Cells("SEL").Value Then
                If ug_ListaVaca.Rows(i).Cells("PERIODO").Value.ToString = String.Empty Then
                    Avisar("Debe seleccionar un periodo para las filas marcadas")
                    Exit Sub
                End If
            End If
        Next

        If Not Preguntar("Seguro de seguir?") Then
            Exit Sub
        End If


        Me.Cursor = Cursors.WaitCursor
        Me.Width = 878

        Dim suspensionBE As New BE.PlanillaBE.SG_PL_TB_SUSPENSIONES
        Dim suspensionBL As BL.PlanillaBL.SG_PL_TB_SUSPENSIONES
        


        upb_1.Visible = True
        upb_1.Minimum = 0
        upb_1.Maximum = ug_ListaVaca.Rows.Count

        For i As Integer = 0 To ug_ListaVaca.Rows.Count - 1

            If ug_ListaVaca.Rows(i).Cells("SEL").Value Then


                Dim fec_ini As Date = ug_ListaVaca.Rows(i).Cells("ALCANCEINICIO").Value.ToString
                Dim fec_fin As Date = ug_ListaVaca.Rows(i).Cells("ALCANCEFIN").Value.ToString


                suspensionBL = New BL.PlanillaBL.SG_PL_TB_SUSPENSIONES
                With suspensionBE
                    .SU_ID = 0
                    .SU_ID_TIPO_SUSPENSION = New BE.PlanillaBE.SG_PL_TB_TIPO_SUSPENSION With {.TS_ID = 1}
                    .SU_ID_PERSONAL = New BE.PlanillaBE.SG_PL_TB_PERSONAL With {.PE_ID = ug_ListaVaca.Rows(i).Cells("IDPERSONAL").Value}
                    .SU_FECHA_INI = fec_ini.ToShortDateString
                    .SU_FECHA_FIN = fec_fin.ToShortDateString


                    Dim dif As Integer = DateDiff(DateInterval.Day, fec_ini, fec_fin)
                    .SU_DIAS_VACA = dif + 1
                    .SU_DIAS_TRABAJO = 30 - (dif + 1)


                    .SU_USUARIO = String.Format("{0}-{1}", Environment.UserName, gStr_Usuario_Sis)
                    .SU_TERMINAL = Environment.MachineName
                    .SU_FECREG = Date.Now
                    .SU_ID_TIPO_SUSPE_SUNAT = New BE.PlanillaBE.SG_PL_TB_TIPO_SUSPENSION_SUNAT With {.TS_CODIGO = "23"}
                    .SU_PROCESAR = 1
                    .SU_PERIODO = ug_ListaVaca.Rows(i).Cells("PERIODO").Value.ToString
                    .SU_OBS = "Papeleta: " & ug_ListaVaca.Rows(i).Cells("DOC_REF").Value.ToString & " - Autoriza: " & ug_ListaVaca.Rows(i).Cells("AUT_PERMISO").Value.ToString
                    .SU_PERIODO_INI = String.Empty
                    .SU_PERIODO_FIN = String.Empty
                    .SU_NCITT = ""

                End With

                suspensionBL.Insert(suspensionBE)

            End If

            upb_1.IncrementValue(1)
        Next


        upb_1.Visible = False
        upb_1.Value = 0
        Me.Width = 842

        
        suspensionBE = Nothing
        suspensionBL = Nothing

        Me.Cursor = Cursors.Default

        Call Avisar("Listo!")

    End Sub

    Private Sub uce_Mes_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles uce_Mes.ValueChanged

        If uce_Mes.SelectedIndex = -1 Then Exit Sub
        Me.Cursor = Cursors.WaitCursor

        Dim diconBL As New BL.PlanillaBL.Dicon
        Dim dt_tmp As DataTable = diconBL.get_Vacaciones_Registradas(une_Ayo.Value, uce_Mes.Value, gInt_IdEmpresa)
        diconBL = Nothing

        Dim suspeBL As New BL.PlanillaBL.SG_PL_TB_SUSPENSIONES
        Dim suspeBE As BE.PlanillaBE.SG_PL_TB_SUSPENSIONES
        Dim personalBL As New BL.PlanillaBL.SG_PL_TB_PERSONAL
        Dim personalBE As BE.PlanillaBE.SG_PL_TB_PERSONAL
        Dim str_periodo As String = String.Empty

        upb_1.Value = 0
        upb_1.Minimum = 0
        upb_1.Maximum = dt_tmp.Rows.Count
        upb_1.Visible = True



        Call LimpiaGrid(ug_ListaVaca, uds_ListaVaca)

        For i As Integer = 0 To dt_tmp.Rows.Count - 1

            ug_ListaVaca.DisplayLayout.Bands(0).AddNew()
            ug_ListaVaca.Rows(i).Cells("SEL").Value = True
            ug_ListaVaca.Rows(i).Cells("DNI").Value = dt_tmp.Rows(i)("DNI")
            ug_ListaVaca.Rows(i).Cells("APELLIDOS").Value = dt_tmp.Rows(i)("APELLIDOS")
            ug_ListaVaca.Rows(i).Cells("NOMBRES").Value = dt_tmp.Rows(i)("NOMBRES")
            ug_ListaVaca.Rows(i).Cells("ALCANCEINICIO").Value = dt_tmp.Rows(i)("ALCANCEINICIO")
            ug_ListaVaca.Rows(i).Cells("ALCANCEFIN").Value = dt_tmp.Rows(i)("ALCANCEFIN")
            ug_ListaVaca.Rows(i).Cells("DOC_REF").Value = dt_tmp.Rows(i)("DOC_REF")
            ug_ListaVaca.Rows(i).Cells("AUT_PERMISO").Value = dt_tmp.Rows(i)("AUT_PERMISO")




            personalBE = New BE.PlanillaBE.SG_PL_TB_PERSONAL With {.PE_NUM_DOC_PER = ug_ListaVaca.Rows(i).Cells("DNI").Value.ToString, .PE_ID_EMPRESA = gInt_IdEmpresa}
            personalBL.getPersonal_x_DNI(personalBE)

            suspeBE = New BE.PlanillaBE.SG_PL_TB_SUSPENSIONES
            suspeBE.SU_ID_TIPO_SUSPENSION = New BE.PlanillaBE.SG_PL_TB_TIPO_SUSPENSION With {.TS_ID = 1}
            suspeBE.SU_ID_PERSONAL = personalBE
            suspeBE.SU_FECHA_INI = ug_ListaVaca.Rows(i).Cells("ALCANCEINICIO").Value
            suspeBE.SU_FECHA_FIN = ug_ListaVaca.Rows(i).Cells("ALCANCEFIN").Value

            str_periodo = String.Empty
            If suspeBL.Existe_Registro_EnConta(suspeBE, str_periodo) Then
                ug_ListaVaca.Rows(i).Cells("PERIODO").Value = str_periodo
                ug_ListaVaca.Rows(i).Cells("ESTADO").Value = My.Resources._16__Ok_
            Else
                ug_ListaVaca.Rows(i).Cells("ESTADO").Value = My.Resources.flag_orange
            End If

            ug_ListaVaca.Rows(i).Cells("IDPERSONAL").Value = personalBE.PE_ID

            upb_1.IncrementValue(1)
        Next

        ug_ListaVaca.UpdateData()


        upb_1.Value = 0
        upb_1.Visible = False

        Call Agregar_Columna_Periodo()
        uchk_todos.Checked = True

        Me.Cursor = Cursors.Default

    End Sub

    Private Sub uchk_todos_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles uchk_todos.CheckedChanged
        For i As Integer = 0 To ug_ListaVaca.Rows.Count - 1
            ug_ListaVaca.Rows(i).Cells("SEL").Value = uchk_todos.Checked
            ug_ListaVaca.Rows(i).Cells("PERIODO").Value = Nothing
        Next
        ug_ListaVaca.UpdateData()
    End Sub

End Class