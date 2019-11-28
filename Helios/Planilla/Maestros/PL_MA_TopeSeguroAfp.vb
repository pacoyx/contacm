Imports Infragistics.Win.UltraWinGrid

Public Class PL_MA_TopeSeguroAfp

    Private Sub PL_MA_TopeSeguroAfp_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Call Cargar_Lista_Topes()
    End Sub

    Private Sub Cargar_Lista_Topes()
        Dim topeBL As New BL.PlanillaBL.SG_PL_TB_TOPE_MENSUAL
        Dim topeBE As New BE.PlanillaBE.SG_PL_TB_TOPE_MENSUAL
        topeBE.TM_PERIODO = gDat_Fecha_Sis.Year
        topeBE.TM_IDEMPRESA = New BE.ContabilidadBE.SG_CO_TB_EMPRESA With {.EM_ID = gInt_IdEmpresa}
        ug_Tope.DataSource = topeBL.get_Lista_Tope_Mensual(topeBE)
        topeBE = Nothing
        topeBL = Nothing
    End Sub

    Private Sub Tool_Salir_Click(sender As System.Object, e As System.EventArgs) Handles Tool_Salir.Click
        Me.Close()
    End Sub

    Private Sub ug_Tope_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles ug_Tope.KeyDown
        If e.KeyCode = Keys.Enter Then
            With ug_Tope
                Select Case ug_Tope.ActiveRow.Cells(ug_Tope.ActiveCell.Column.Index).Column.Key
                    Case "VALOR"
                        .PerformAction(UltraGridAction.NextCellByTab, False, False)
                        .PerformAction(UltraGridAction.NextCellByTab, False, False)
                        .PerformAction(UltraGridAction.NextCellByTab, False, False)
                End Select

            End With
        End If
    End Sub

    Private Sub Tool_Grabar_Click(sender As System.Object, e As System.EventArgs) Handles Tool_Grabar.Click


        ug_Tope.UpdateData()

        Dim topeBE As New BE.PlanillaBE.SG_PL_TB_TOPE_MENSUAL
        Dim topeBL As New BL.PlanillaBL.SG_PL_TB_TOPE_MENSUAL

        topeBE.TM_PERIODO = gDat_Fecha_Sis.Year
        topeBE.TM_IDEMPRESA = New BE.ContabilidadBE.SG_CO_TB_EMPRESA With {.EM_ID = gInt_IdEmpresa}

        For i As Integer = 0 To ug_Tope.Rows.Count - 1
            topeBE.TM_MES = ug_Tope.Rows(i).Cells("NUMERO").Value
            topeBE.TM_VALOR = ug_Tope.Rows(i).Cells("VALOR").Value
            topeBL.Update(topeBE)
        Next

        topeBE = Nothing
        topeBL = Nothing

        Avisar("    Listo!  ")

    End Sub

    Private Sub Tool_Actualizar_Click(sender As System.Object, e As System.EventArgs) Handles Tool_Actualizar.Click
        Call Cargar_Lista_Topes()
    End Sub
End Class