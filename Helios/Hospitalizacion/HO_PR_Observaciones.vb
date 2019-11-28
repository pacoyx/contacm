Public Class HO_PR_Observaciones
    Public str_Observaciones As String = String.Empty
    Public bol_Aceptar As Boolean = False

    Private Sub HO_PR_Observaciones_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        txt_obs.Text = str_Observaciones
    End Sub

    Private Sub ubtn_Aceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ubtn_Aceptar.Click
        bol_Aceptar = True
        str_Observaciones = txt_obs.Text
        Me.Close()
    End Sub

    Private Sub ubtn_Cancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ubtn_Cancelar.Click
        bol_Aceptar = False
        Me.Close()
    End Sub

End Class