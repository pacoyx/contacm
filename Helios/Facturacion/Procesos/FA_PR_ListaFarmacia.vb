Public Class FA_PR_ListaFarmacia

    Public Cuenta As Integer
    Public Tipo As Integer

    Private Sub FA_PR_ListaAyuda_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim ReporteBL As New BL.FacturacionBL.SG_FA_Reportes
        'Dim dt_prog As DataTable
        ug_data.DataSource = ReporteBL.get_ConsumoFarmacia(Cuenta, Tipo)
        ReporteBL = Nothing
        Calcular_Totales()
    End Sub

    Private Sub ug_data_InitializeRow(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinGrid.InitializeRowEventArgs) Handles ug_data.InitializeRow
        If e.Row.Cells(7).Value = 1 Then
            e.Row.Appearance.BackColor = Color.FromArgb(255, 128, 128)
        Else
            e.Row.Appearance.BackColor = Color.LightBlue
        End If
    End Sub

    Private Sub Calcular_Totales()

        txt_TotalC.Text = ""
        txt_TotalN.Text = ""

        Dim subtotalC As Decimal = "0.00"
        Dim subtotalN As Decimal = "0.00"

        For i As Integer = 0 To ug_data.Rows.Count - 1
            If ug_data.Rows(i).Cells(7).Value = 0 Then
                subtotalC = subtotalC + Val(ug_data.Rows(i).Cells(6).Value.ToString)
            Else
                subtotalN = subtotalN + Val(ug_data.Rows(i).Cells(6).Value.ToString)
            End If
        Next

        txt_TotalC.Value = Math.Round(subtotalC, 2)
        txt_TotalN.Value = Math.Round(subtotalN, 2)
    End Sub

End Class