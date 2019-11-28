Public Class AD_RE_GraficoEcoXMedico

    Private Sub pKeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Me.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Return) Then
            SendKeys.Send("{TAB}")
            e.Handled = True
        End If
    End Sub
    Private Sub pKeyPressNumero(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_Año.KeyPress
        e.KeyChar = fKeyPress(e.KeyChar, sender.Text, 1)
        e.Handled = (e.KeyChar = "")
    End Sub

    Private Sub AD_RE_GraficoAtenciones_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txt_Año.Text = Now.Year

        Dim medicosBL As New BL.AdmisionBL.SG_AD_TB_MEDICO
        uce_Medico.DataSource = medicosBL.get_Medicos(gInt_IdEmpresa)
        uce_Medico.ValueMember = "ME_CODIGO"
        uce_Medico.DisplayMember = "NOMBRES"
        medicosBL = Nothing

        Cargar_Comprobantes()
    End Sub

    Private Sub Tool_Consultar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_Consultar.Click
        Cargar_Comprobantes()
    End Sub

    Private Sub Cargar_Comprobantes()
        Dim ReportBL As New BL.AdmisionBL.SG_AD_TB_Reportes
        Dim obj As New DataTable
        obj = ReportBL.get_Gra_EcoXMedico(gInt_IdEmpresa, Val(txt_Año.Text), uce_Medico.Value)
        If obj.Rows.Count > 0 Then
            uc_Grafico.Visible = True
            uc_Grafico.Data.DataSource = obj
        Else
            uc_Grafico.Visible = False
        End If

        ReportBL = Nothing
    End Sub
   
    Private Sub Tool_Salir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_Salir.Click
        Me.Close()
    End Sub

    Private Sub uce_Medico_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles uce_Medico.ValueChanged
        Call Cargar_Comprobantes()
    End Sub
End Class