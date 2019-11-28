Imports Infragistics.Win.UltraWinGrid

Public Class PL_PR_Cronograma

    Public dt_data As DataTable = Nothing

    Private Sub PL_PR_Cronograma_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ug_Crono.DataSource = dt_data
        Call Formatear_Grilla_Selector(ug_Crono)





    End Sub

    Private Sub Tool_Salir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_Salir.Click
        Me.Close()
    End Sub

    Private Sub ug_Crono_InitializeLayout(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.InitializeLayoutEventArgs) Handles ug_Crono.InitializeLayout
        Dim tt As SummarySettings

        If Not e.Layout.Bands(0).Summaries.Exists("sum_Cuota") Then
            tt = e.Layout.Bands(0).Summaries.Add("sum_Cuota", SummaryType.Sum, e.Layout.Bands(0).Columns("Cuota"), SummaryPosition.UseSummaryPositionColumn)
            tt.DisplayFormat = "{0:##,##0.00#}"
            tt.Appearance.TextHAlign = Infragistics.Win.HAlign.Right
            tt.SummaryDisplayArea = SummaryDisplayAreas.BottomFixed
        End If

        If Not e.Layout.Bands(0).Summaries.Exists("sum_Interes") Then
            tt = e.Layout.Bands(0).Summaries.Add("sum_Interes", SummaryType.Sum, e.Layout.Bands(0).Columns("Interes"), SummaryPosition.UseSummaryPositionColumn)
            tt.DisplayFormat = "{0:##,##0.00#}"
            tt.Appearance.TextHAlign = Infragistics.Win.HAlign.Right
            tt.SummaryDisplayArea = SummaryDisplayAreas.BottomFixed
        End If

        If Not e.Layout.Bands(0).Summaries.Exists("sum_PagoTotal") Then
            tt = e.Layout.Bands(0).Summaries.Add("sum_PagoTotal", SummaryType.Sum, e.Layout.Bands(0).Columns("PagoTotal"), SummaryPosition.UseSummaryPositionColumn)
            tt.DisplayFormat = "{0:##,##0.00#}"
            tt.Appearance.TextHAlign = Infragistics.Win.HAlign.Right
            tt.SummaryDisplayArea = SummaryDisplayAreas.BottomFixed
        End If


        e.Layout.Bands(0).SummaryFooterCaption = "Totales"

    End Sub
End Class