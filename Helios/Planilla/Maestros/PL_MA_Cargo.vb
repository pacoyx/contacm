Public Class PL_MA_Cargo

    Private Sub PL_MA_Cargo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call Cargar_ListadoCargos()

    End Sub

    Private Sub Cargar_ListadoCargos()
        Dim cargoBL As New BL.PlanillaBL.SG_PL_TB_CARGO
        Dim cargoBE As New BE.PlanillaBE.SG_PL_TB_CARGO
        cargoBE.EC_IDEMPRESA = New BE.ContabilidadBE.SG_CO_TB_EMPRESA With {.EM_ID = gInt_IdEmpresa}
        ug_listado.DataSource = cargoBL.getCargos(cargoBE)
    End Sub

    Private Sub ug_listado_AfterRowUpdate(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinGrid.RowEventArgs) Handles ug_listado.AfterRowUpdate
        Dim cargoBL As New BL.PlanillaBL.SG_PL_TB_CARGO
        Dim cargoBE As New BE.PlanillaBE.SG_PL_TB_CARGO
        cargoBE.EC_CARGO = e.Row.Cells(1).Value
        cargoBE.EC_IDEMPRESA = New BE.ContabilidadBE.SG_CO_TB_EMPRESA With {.EM_ID = gInt_IdEmpresa}

        If ug_listado.ActiveRow.Cells(0).Text.Trim <> String.Empty Then
            cargoBE.EC_ID = ug_listado.ActiveRow.Cells(0).Value
            cargoBL.Update(cargoBE)
        Else
            cargoBL.Insert(cargoBE)
            ug_listado.ActiveRow.Cells(0).Value = cargoBE.EC_ID
        End If


    End Sub

    Private Sub ug_listado_BeforeRowsDeleted(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.BeforeRowsDeletedEventArgs) Handles ug_listado.BeforeRowsDeleted
        e.DisplayPromptMsg = False
        Dim cargoBL As New BL.PlanillaBL.SG_PL_TB_CARGO
        Dim cargoBE As New BE.PlanillaBE.SG_PL_TB_CARGO
        cargoBE.EC_ID = ug_listado.ActiveRow.Cells(0).Value
        cargoBL.Delete(cargoBE)
    End Sub

    Private Sub Tool_Salir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_Salir.Click
        Me.Close()
    End Sub
End Class