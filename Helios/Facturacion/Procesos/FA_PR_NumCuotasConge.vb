Public Class FA_PR_NumCuotasConge

    Public pNumeroCuotas As Double = 0

    Private Sub FA_PR_NumCuotasConge_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Call Cargar_Numero_Cuotas()
    End Sub


    Private Sub Cargar_Numero_Cuotas()

        For i As Integer = 0 To 50
            uce_numcuotas.Items.Add(i, i)
        Next

    End Sub

    Private Sub btn_aceptar_Click(sender As System.Object, e As System.EventArgs) Handles btn_aceptar.Click
        pNumeroCuotas = uce_numcuotas.Value
        Me.Close()
    End Sub
End Class