Public Class PL_MA_Tarifa

    Dim Bol_Cargando As Boolean = False
    Dim Bol_NuevaFila As Boolean = False

    Private Sub PL_MA_Tarifa_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call Cargar_Tarifas()
        Call Setear_Columnas_Grilla()
    End Sub
    Private Sub Cargar_Tarifas()
        Dim tarifaBL As New BL.PlanillaBL.SG_PL_TB_TARIFA
        Dim empresaBE As New BE.ContabilidadBE.SG_CO_TB_EMPRESA With {.EM_ID = gInt_IdEmpresa}
        Dim dt_tmp As DataTable = tarifaBL.get_Tarifas(empresaBE)

        Call LimpiaGrid(ug_Tarifa, uds_Tarifa)


        Try
            Bol_Cargando = True
            For i As Integer = 0 To dt_tmp.Rows.Count - 1
                ug_Tarifa.DisplayLayout.Bands(0).AddNew()
                ug_Tarifa.Rows(i).Cells("TA_ID_TIPO_PER").Value = dt_tmp.Rows(i)("TA_ID_TIPO_PER")
                ug_Tarifa.Rows(i).Cells("TA_ID_TIPO_TARIFA").Value = dt_tmp.Rows(i)("TA_ID_TIPO_TARIFA")
                ug_Tarifa.Rows(i).Cells("TA_VALOR").Value = dt_tmp.Rows(i)("TA_VALOR")
            Next

        Catch ex As Exception
            Avisar(ex.Message)
        End Try

        ug_Tarifa.UpdateData()
        ug_Tarifa.DisplayLayout.Bands(0).AddNew()

        Bol_Cargando = False
        Bol_NuevaFila = False

        If ug_Tarifa.Rows.Count > 0 Then ug_Tarifa.Rows(0).Selected = True

    End Sub

    Private Sub Setear_Columnas_Grilla()

        Dim tipoPersonalTarifaBL As New BL.PlanillaBL.SG_PL_TB_TIPO_PERSO_TARIFA
        Dim tipoTarifaBL As New BL.PlanillaBL.SG_PL_TB_TIPO_TARIFA
        Dim empresaBE As New BE.ContabilidadBE.SG_CO_TB_EMPRESA With {.EM_ID = gInt_IdEmpresa}

        Call CrearComboGrid("TA_ID_TIPO_PER", "TT_DESCRIPCION", ug_Tarifa, tipoPersonalTarifaBL.get_Tipos(empresaBE), True)
        Call CrearComboGrid("TA_ID_TIPO_TARIFA", "TI_DESCRIPCION", ug_Tarifa, tipoTarifaBL.get_Tipos(empresaBE), True)

        empresaBE = Nothing
        tipoTarifaBL = Nothing
        tipoPersonalTarifaBL = Nothing

    End Sub

    Private Sub ug_Tarifa_AfterRowUpdate(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.RowEventArgs) Handles ug_Tarifa.AfterRowUpdate
        If Not Bol_Cargando Then

            If e.Row.Cells("TA_ID_TIPO_PER").Value.ToString = "" Then Exit Sub
            If e.Row.Cells("TA_ID_TIPO_TARIFA").Value.ToString = "" Then Exit Sub
            If e.Row.Cells("TA_VALOR").Value.ToString = "" Then Exit Sub


            Dim tarifaBL As New BL.PlanillaBL.SG_PL_TB_TARIFA
            Dim tarifaBE As New BE.PlanillaBE.SG_PL_TB_TARIFA

            tarifaBE.TA_ID_TIPO_PER = New BE.PlanillaBE.SG_PL_TB_TIPO_PERSO_TARIFA With {.TT_ID = e.Row.Cells("TA_ID_TIPO_PER").Value}
            tarifaBE.TA_ID_TIPO_TARIFA = New BE.PlanillaBE.SG_PL_TB_TIPO_TARIFA With {.TI_ID = e.Row.Cells("TA_ID_TIPO_TARIFA").Value}
            tarifaBE.TA_VALOR = e.Row.Cells("TA_VALOR").Value
            tarifaBE.TA_ID_EMPRESA = New BE.ContabilidadBE.SG_CO_TB_EMPRESA With {.EM_ID = gInt_IdEmpresa}

            tarifaBL.Update(tarifaBE)

            tarifaBE = Nothing
            tarifaBL = Nothing

            Avisar("se procede a actualizar!")
            Bol_NuevaFila = False
        End If
    End Sub

    Private Sub ug_Tarifa_BeforeRowUpdate(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinGrid.CancelableRowEventArgs) Handles ug_Tarifa.BeforeRowUpdate

        If Not Bol_Cargando Then

            If e.Row.Cells("TA_ID_TIPO_PER").Value.ToString = "" Then Exit Sub
            If e.Row.Cells("TA_ID_TIPO_TARIFA").Value.ToString = "" Then Exit Sub


            Dim tarifaBL As New BL.PlanillaBL.SG_PL_TB_TARIFA
            Dim tarifaBE As New BE.PlanillaBE.SG_PL_TB_TARIFA

            tarifaBE.TA_ID_TIPO_PER = New BE.PlanillaBE.SG_PL_TB_TIPO_PERSO_TARIFA With {.TT_ID = e.Row.Cells("TA_ID_TIPO_PER").Value}
            tarifaBE.TA_ID_TIPO_TARIFA = New BE.PlanillaBE.SG_PL_TB_TIPO_TARIFA With {.TI_ID = e.Row.Cells("TA_ID_TIPO_TARIFA").Value}
            tarifaBE.TA_ID_EMPRESA = New BE.ContabilidadBE.SG_CO_TB_EMPRESA With {.EM_ID = gInt_IdEmpresa}

            If Bol_NuevaFila Then
                If tarifaBL.Existe_Llave(tarifaBE) Then
                    e.Cancel = True
                    Avisar("Esta combinacion de tarifa ya existe")
                    Bol_NuevaFila = False
                End If
            End If
            


            tarifaBE = Nothing
            tarifaBL = Nothing
        End If

    End Sub

    Private Sub ug_Tarifa_AfterRowInsert(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.RowEventArgs) Handles ug_Tarifa.AfterRowInsert
        Bol_NuevaFila = True
    End Sub

    Private Sub Tool_Salir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_Salir.Click
        Me.Close()
    End Sub
End Class