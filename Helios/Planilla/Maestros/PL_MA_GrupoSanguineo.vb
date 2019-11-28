Public Class PL_MA_GrupoSanguineo

    Private Sub Tool_Salir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_Salir.Click
        Me.Close()
    End Sub

    Private Sub ug_listado_AfterRowUpdate(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinGrid.RowEventArgs) Handles ug_listado.AfterRowUpdate
        Dim grupoSanguineoBL As New BL.PlanillaBL.SG_PL_TB_GRUPO_SANGUINEO
        Dim grupoSanguineoBE As New BE.PlanillaBE.SG_PL_TB_GRUPO_SANGUINEO
        grupoSanguineoBE.GS_TIPO = e.Row.Cells(1).Value
        grupoSanguineoBE.GS_DESCRIPCION = e.Row.Cells(2).Value

        If ug_listado.ActiveRow.Cells(0).Text.Trim <> String.Empty Then
            grupoSanguineoBE.GS_ID = ug_listado.ActiveRow.Cells(0).Value
            grupoSanguineoBL.Update(grupoSanguineoBE)
        Else
            grupoSanguineoBL.Insert(grupoSanguineoBE)
            ug_listado.ActiveRow.Cells(0).Value = grupoSanguineoBE.GS_ID
        End If

        grupoSanguineoBE = Nothing
        grupoSanguineoBL = Nothing

    End Sub

    Private Sub ug_listado_BeforeRowsDeleted(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.BeforeRowsDeletedEventArgs) Handles ug_listado.BeforeRowsDeleted
        e.DisplayPromptMsg = False
        Dim grupoSanguineoBL As New BL.PlanillaBL.SG_PL_TB_GRUPO_SANGUINEO
        Dim grupoSanguineoBE As New BE.PlanillaBE.SG_PL_TB_GRUPO_SANGUINEO
        grupoSanguineoBE.GS_ID = ug_listado.ActiveRow.Cells(0).Value
        grupoSanguineoBL.Delete(grupoSanguineoBE)
    End Sub

    Private Sub ToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton1.Click
        PL_MA_Compatibilidad.ShowDialog()
    End Sub

    Private Sub PL_MA_GrupoSanguineo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim grupoSanguiBL As New BL.PlanillaBL.SG_PL_TB_GRUPO_SANGUINEO
        ug_listado.DataSource = grupoSanguiBL.getGrupoSanguineo()
        grupoSanguiBL = Nothing
    End Sub
End Class