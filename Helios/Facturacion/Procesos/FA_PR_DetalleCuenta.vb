Imports Infragistics.Win.UltraWinGrid
Public Class FA_PR_DetalleCuenta
    Private Sub AD_PR_Atencion_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Calcular_Totales()
        'obe = New BE.AdmisionBE.SG_AD_TB_CITA_MED
        'obr = New BL.AdmisionBL.SG_AD_TB_CITA_MED
        'obeT = New BE.AdmisionBE.TMP_SG_AD_TB_CUENTA_DET
        'obrT = New BL.AdmisionBL.SG_AD_TB_CUENTA_CAB

        Me.KeyPreview = True

    End Sub

    Private Sub Tool_Salir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
    End Sub

    Private Sub Calcular_Totales()

        txt_SubTotal.Text = ""
        txt_IGV.Text = ""
        txt_Total.Text = ""
        Dim subtotal As Decimal = "0.00"
        Dim igv As Decimal = "0.00"
        Dim total As Decimal = "0.00"
        For i As Integer = 0 To ug_detalle.Rows.Count - 1
            If ug_detalle.Rows(i).Hidden = False Then
                subtotal += Val(ug_detalle.Rows(i).Cells(9).Value.ToString)
                igv += Val(ug_detalle.Rows(i).Cells(10).Value.ToString)
                total += Val(ug_detalle.Rows(i).Cells(11).Value.ToString)
            End If
        Next
        txt_SubTotal.Text = Math.Round(subtotal, 2)
        txt_IGV.Text = Math.Round(igv, 2)
        txt_Total.Text = Math.Round(total, 2)
    End Sub
    
End Class