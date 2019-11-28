Public Class PL_RP_Detalle_Planilla

    Private Sub PL_RP_Detalle_Planilla_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

        une_ayo.Value = gDat_Fecha_Sis.Year
        Call CargarCombo_ConMeses(uce_Mes)
        Call Cargar_TipoPersonal()
        Call Cargar_Tipo_Identificador()
        uce_TipoPersonal.SelectedIndex = 0
        uce_Mes.Value = gDat_Fecha_Sis.Month

    End Sub

    Private Sub Cargar_TipoPersonal()
        Dim tipoPersonalBL As New BL.PlanillaBL.SG_PL_TB_TIPO_PERSONAL
        uce_TipoPersonal.DataSource = tipoPersonalBL.getTipos()
        uce_TipoPersonal.ValueMember = "TP_ID"
        uce_TipoPersonal.DisplayMember = "TP_DESCRIPCION"
        tipoPersonalBL = Nothing
    End Sub

    Private Sub Cargar_Tipo_Identificador()
        Dim identificadorBL As New BL.PlanillaBL.SG_PL_TB_IDENTIFICADOR
        uos_identificador.DataSource = identificadorBL.get_Identificadores()
        uos_identificador.DisplayMember = "ID_DESCRIPCION"
        uos_identificador.ValueMember = "ID_ID"
    End Sub

    Private Sub Cargar_Conceptos()

        If uos_identificador.Value = Nothing Then
            Avisar("Seleccione un tipo")
            Exit Sub
        End If

        Dim conceptoBL As New BL.PlanillaBL.SG_PL_TB_CONCEPTOS
        Dim dt_tmp As DataTable = conceptoBL.get_Conceptos_x_Identificador(New BE.PlanillaBE.SG_PL_TB_IDENTIFICADOR With {.ID_ID = uos_identificador.Value}, New BE.ContabilidadBE.SG_CO_TB_EMPRESA With {.EM_ID = gInt_IdEmpresa})

        Call LimpiaGrid(ug_conceptos, uds_conceptos)

        For i As Integer = 0 To dt_tmp.Rows.Count - 1
            ug_conceptos.DisplayLayout.Bands(0).AddNew()
            ug_conceptos.Rows(i).Cells("sel").Value = False
            ug_conceptos.Rows(i).Cells("CO_ID").Value = dt_tmp.Rows(i)("CO_ID")
            ug_conceptos.Rows(i).Cells("CO_DESCRIPCION").Value = dt_tmp.Rows(i)("CO_DESCRIPCION")
        Next

        ug_conceptos.UpdateData()
        ug_conceptos.Rows(0).Activate()

        conceptoBL = Nothing

    End Sub

    Private Sub Tool_Salir_Click(sender As System.Object, e As System.EventArgs) Handles Tool_Salir.Click
        Me.Close()
    End Sub

    Private Sub Tool_imprimir_Click(sender As System.Object, e As System.EventArgs) Handles Tool_imprimir.Click

        Dim p1 As String = ""
        Dim p2 As String = ""
        Dim p3 As String = ""
        Dim p4 As String = ""

        Dim p1_des As String = ""
        Dim p2_des As String = ""
        Dim p3_des As String = ""
        Dim p4_des As String = ""
        Dim str_fecha As String = uce_Mes.Text & " de " & une_ayo.Value

        Dim c As Integer = 0
        For i As Integer = 0 To ug_conceptos.Rows.Count - 1
            If ug_conceptos.Rows(i).Cells("sel").Value Then c += 1
        Next
        If c > 4 Then Avisar("Solo puede seleccionar 4 conceptos" & Chr(13) & "Solo se tomara los 4 primeros.")


        ug_conceptos.UpdateData()
        For i As Integer = 0 To ug_conceptos.Rows.Count - 1

            If p1 = "" Then
                If ug_conceptos.Rows(i).Cells("sel").Value Then
                    p1 = ug_conceptos.Rows(i).Cells("CO_ID").Value
                    p1_des = ug_conceptos.Rows(i).Cells("CO_DESCRIPCION").Value
                    GoTo siguiente
                End If
            End If
            

            If p1 <> "" Then
                If ug_conceptos.Rows(i).Cells("sel").Value And p2 = "" Then
                    p2 = ug_conceptos.Rows(i).Cells("CO_ID").Value
                    p2_des = ug_conceptos.Rows(i).Cells("CO_DESCRIPCION").Value
                    GoTo siguiente
                End If
            End If

            If p2 <> "" Then
                If ug_conceptos.Rows(i).Cells("sel").Value And p3 = "" Then
                    p3 = ug_conceptos.Rows(i).Cells("CO_ID").Value
                    p3_des = ug_conceptos.Rows(i).Cells("CO_DESCRIPCION").Value
                    GoTo siguiente
                End If
            End If

            If p3 <> "" Then
                If ug_conceptos.Rows(i).Cells("sel").Value Then
                    p4 = ug_conceptos.Rows(i).Cells("CO_ID").Value
                    p4_des = ug_conceptos.Rows(i).Cells("CO_DESCRIPCION").Value
                    Exit For
                End If
            End If
siguiente:
        Next



        Me.Cursor = Cursors.Default

        Dim reportesBL As New BL.PlanillaBL.SG_PL_Reportes
        Dim dt_tmp As DataTable = reportesBL.get_Detalle_de_Planilla(une_ayo.Value, uce_Mes.Value, uce_TipoPersonal.Value, p1, p2, p3, p4, gInt_IdEmpresa)

        Using crystalBL As New LR.ClsReporte
            crystalBL.Muestra_Reporte(gStr_RutaRep & "\SG_PL_16.rpt", dt_tmp, "", "pEmp;" & gStr_NomEmpresa, _
                                      "pIden;" & uos_identificador.Text, _
                                      "pFecha;" & str_fecha.ToUpper, _
                                      "pTipoPer;" & uce_TipoPersonal.Text, _
                                      "pP1;" & p1_des, _
                                      "pP2;" & p2_des, _
                                      "pP3;" & p3_des, _
                                      "pP4;" & p4_des)
        End Using
        Me.Cursor = Cursors.Default

    End Sub

    Private Sub uos_identificador_ValueChanged(sender As System.Object, e As System.EventArgs) Handles uos_identificador.ValueChanged
        Call Cargar_Conceptos()
    End Sub

    Private Sub ug_conceptos_AfterRowUpdate(sender As Object, e As Infragistics.Win.UltraWinGrid.RowEventArgs) Handles ug_conceptos.AfterRowUpdate
        Dim c As Integer = 0
        For i As Integer = 0 To ug_conceptos.Rows.Count - 1
            If ug_conceptos.Rows(i).Cells("sel").Value Then c += 1
        Next
        If c > 4 Then Avisar("Solo puede seleccionar 4 conceptos")
    End Sub

    Private Sub ug_conceptos_BeforeRowUpdate(sender As System.Object, e As Infragistics.Win.UltraWinGrid.CancelableRowEventArgs) Handles ug_conceptos.BeforeRowUpdate
        Dim c As Integer = 0
        For i As Integer = 0 To ug_conceptos.Rows.Count - 1
            If ug_conceptos.Rows(i).Cells("sel").Value Then c += 1
        Next

        If c > 4 Then
            If e.Row.Cells("sel").Value Then
                Avisar("Solo puede seleccionar 4 conceptos")
                e.Cancel = True
            End If
        End If

    End Sub
End Class