Imports Infragistics.Win.UltraWinGrid


Public Class ClsMerge
    Implements IMergedCellEvaluator

    Public Function ShouldCellsBeMerged(row1 As Infragistics.Win.UltraWinGrid.UltraGridRow, row2 As Infragistics.Win.UltraWinGrid.UltraGridRow, column As Infragistics.Win.UltraWinGrid.UltraGridColumn) As Boolean Implements Infragistics.Win.UltraWinGrid.IMergedCellEvaluator.ShouldCellsBeMerged
        Return row1.GetCellValue(column) = row2.GetCellValue(column)
    End Function
End Class
