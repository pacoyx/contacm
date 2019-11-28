Imports Infragistics.Win.UltraWinGrid



Public Class CO_PR_Act_FecVen_Compras


    Private Sub CO_PR_Act_FecVen_Compras_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Call CargarCombo_ConMeses(uce_Mes)
        une_Ayo.Value = gDat_Fecha_Sis.Year
        uce_Mes.SelectedIndex = -1
        Call Formatear_Grilla_Selector(ug_Lista)
    End Sub

    Private Sub Tool_Salir_Click(sender As System.Object, e As System.EventArgs) Handles Tool_Salir.Click
        Me.Close()
    End Sub

    Private Sub Tool_Grabar_Click(sender As System.Object, e As System.EventArgs) Handles Tool_Grabar.Click

        Dim asientoBL As New BL.ContabilidadBL.SG_CO_TB_ASIENTO_CONTABLE
        Dim comprasBE As New BE.ContabilidadBE.SG_CO_TB_COMPRAS

        ug_Lista.UpdateData()
        For i As Integer = 0 To ug_Lista.Rows.Count - 1
            If ug_Lista.Rows(i).Cells("CO_FEC_VEN").Value <> ug_Lista.Rows(i).Cells("CO_FEC_VEN2").Value Then
                With comprasBE
                    .CO_IDCAB = New BE.ContabilidadBE.SG_CO_TB_ASIENTO_CAB With {.AC_ID = ug_Lista.Rows(i).Cells("CO_IDCAB").Value}
                    .CO_TIP_DOC = New BE.ContabilidadBE.SG_CO_TB_DOCUMENTO With {.DO_CODIGO = ug_Lista.Rows(i).Cells("DO_CODIGO").Value}
                    .CO_SER_DOC = ug_Lista.Rows(i).Cells("CO_SER_DOC").Value
                    .CO_NUM_DOC = ug_Lista.Rows(i).Cells("CO_NUM_DOC").Value
                    .CO_FEC_VEN = ug_Lista.Rows(i).Cells("CO_FEC_VEN").Value
                    .CO_ANEXO_ID = New BE.ContabilidadBE.SG_CO_TB_ANEXO With {.AN_IDANEXO = ug_Lista.Rows(i).Cells("AN_IDANEXO").Value}
                End With
                asientoBL.Update_FecVen_Compras(comprasBE)
            End If
        Next

        asientoBL = Nothing
        comprasBE = Nothing

        Call Avisar("Listo!")

    End Sub

    Private Sub uce_Mes_ValueChanged(sender As System.Object, e As System.EventArgs) Handles uce_Mes.ValueChanged
        Call Cargar_Documentos_de_Compras()
    End Sub

    Private Sub Cargar_Documentos_de_Compras()

        If uce_Mes.SelectedIndex = -1 Then Exit Sub
        Me.Cursor = Cursors.WaitCursor
        Dim consultasBL As New BL.ContabilidadBL.Consultas
        ug_Lista.DataSource = consultasBL.get_Listado_Compras_x_Periodo(une_Ayo.Value, uce_Mes.Value, gInt_IdEmpresa)
        consultasBL.Dispose()
        Me.Cursor = Cursors.Default

        lbl_num_filas.Text = "Num. Filas : " & ug_Lista.Rows.Count

    End Sub

    Private Sub ug_Lista_InitializeLayout(sender As System.Object, e As Infragistics.Win.UltraWinGrid.InitializeLayoutEventArgs) Handles ug_Lista.InitializeLayout

        'e.Layout.Override.MergedCellStyle = MergedCellStyle.Always
        e.Layout.Bands(0).Columns("AN_DESCRIPCION").MergedCellStyle = MergedCellStyle.Always
        'e.Layout.Bands(0).Columns("DO_ABREVIATURA").MergedCellEvaluator = New ClsMerge()

    End Sub


    Private Sub ug_Lista_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles ug_Lista.KeyDown
        If e.KeyCode = Keys.Enter Then
            ug_Lista.PerformAction(UltraGridAction.NextCellByTab, False, False)
            ug_Lista.UpdateData()
        End If
    End Sub
End Class