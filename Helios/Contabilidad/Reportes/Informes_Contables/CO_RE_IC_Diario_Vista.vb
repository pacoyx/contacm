Public Class CO_RE_IC_Diario_Vista

    Public pdt_data As DataTable
    Public ptitulo As String

    Private Sub CO_RE_IC_Diario_Vista_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        lbl_titulo.Text = ptitulo
        ug_detalle.DataSource = pdt_data
    End Sub
End Class