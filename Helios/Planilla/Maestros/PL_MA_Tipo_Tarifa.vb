Public Class PL_MA_Tipo_Tarifa

    Private Sub PL_MA_Tipo_Tarifa_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call Cargar_Tipos_de_Tarifas()
    End Sub

    Private Sub Cargar_Tipos_de_Tarifas()
        Dim tipoTarifaBL As New BL.PlanillaBL.SG_PL_TB_TIPO_TARIFA
        Dim empresaBE As New BE.ContabilidadBE.SG_CO_TB_EMPRESA With {.EM_ID = gInt_IdEmpresa}
        Dim dt_tipoTarifa As DataTable = tipoTarifaBL.get_Tipos(empresaBE)
        ug_Tipos.DataSource = dt_tipoTarifa
        tipoTarifaBL = Nothing
    End Sub

    Private Sub ug_Tipos_AfterRowUpdate(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.RowEventArgs) Handles ug_Tipos.AfterRowUpdate

        Dim tipoTarifaBL As New BL.PlanillaBL.SG_PL_TB_TIPO_TARIFA
        Dim tipoTarifaBE As New BE.PlanillaBE.SG_PL_TB_TIPO_TARIFA
        tipoTarifaBE.TI_ID = e.Row.Cells("TI_ID").Value
        tipoTarifaBE.TI_IDCONCEPTO = New BE.PlanillaBE.SG_PL_TB_CONCEPTOS With {.CO_ID = e.Row.Cells("TI_IDCONCEPTO").Value}
        tipoTarifaBE.TI_ID_EMPRESA = New BE.ContabilidadBE.SG_CO_TB_EMPRESA With {.EM_ID = gInt_IdEmpresa}
        tipoTarifaBL.Update(tipoTarifaBE)

        tipoTarifaBL = Nothing

    End Sub

    Private Sub Tool_Salir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_Salir.Click
        Me.Close()
    End Sub

    Private Sub ug_Tipos_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles ug_Tipos.KeyDown
        If e.KeyCode = Keys.Enter Then
            ug_Tipos.UpdateData()
            ug_Tipos.PerformAction(Infragistics.Win.UltraWinGrid.UltraGridAction.NextCellByTab, False, False)
            ug_Tipos.PerformAction(Infragistics.Win.UltraWinGrid.UltraGridAction.NextCellByTab, False, False)
            ug_Tipos.PerformAction(Infragistics.Win.UltraWinGrid.UltraGridAction.NextCellByTab, False, False)
        End If
    End Sub
End Class