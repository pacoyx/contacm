Public Class FA_PR_ListaComproLibres
    Dim cajaBL As New BL.FacturacionBL.SG_FA_TB_CAJA_CAB
    Public IdCaja As Integer = 0

    Private Sub FA_PR_ListaComproLibres_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        ug_data.DataSource = cajaBL.get_comprobantesLibres(gInt_IdEmpresa)
        'ug_data.DisplayLayout .c = True
        ug_data.DisplayLayout.Bands(0).Columns(0).CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        ug_data.DisplayLayout.Bands(0).Columns(1).CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        ug_data.DisplayLayout.Bands(0).Columns(2).CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        ug_data.DisplayLayout.Bands(0).Columns(3).CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        ug_data.DisplayLayout.Bands(0).Columns(4).CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        ug_data.DisplayLayout.Bands(0).Columns(5).CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        ug_data.DisplayLayout.Bands(0).Columns(6).CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
    End Sub

    Private Sub ubtn_Aceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ubtn_Aceptar.Click
        If ug_data.Rows.Count <= 0 Then Exit Sub

        cajaBL.Insert_Comp(IdCaja, ug_data.ActiveRow.Cells(0).Value)
        Avisar("Ingresado Correctamente")
        Me.Close()
    End Sub
End Class