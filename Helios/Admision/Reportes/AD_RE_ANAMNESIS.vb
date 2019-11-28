Public Class AD_RE_ANAMNESIS
    Private obr As BL.AdmisionBL.SG_AD_TB_Reportes
    Public Sub New()
        InitializeComponent()
        obr = New BL.AdmisionBL.SG_AD_TB_Reportes
    End Sub

    Private Sub pKeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If e.KeyChar = Convert.ToChar(Keys.Return) Then
            SendKeys.Send("{TAB}")
            e.Handled = True
        End If
    End Sub

    Private Sub Tool_Consultar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_Consultar.Click
        Call LimpiaGrid(ug_Lista, uds_Lista)
        ug_Lista.DataSource = obr.SEL06(gInt_IdEmpresa, udte_fechaD.Text, udte_fechaH.Text)
        ug_Lista.UpdateData()
    End Sub

    Private Sub AD_RE_ANAMNESIS_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        obr = New BL.AdmisionBL.SG_AD_TB_Reportes
        Me.KeyPreview = True

        Call LimpiaGrid(ug_Lista, uds_Lista)
        udte_fechaD.Value = Now
        udte_fechaH.Value = Now
    End Sub
    Private Sub Tool_Exportar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_Exportar.Click
        Dim str_nombre_arc_exc As String = "Anamnesis " & Date.Now.Day & Date.Now.Month & Date.Now.Year & Date.Now.Hour & Date.Now.Minute & Date.Now.Second & ".xls"
        Try
            Me.Cursor = Cursors.WaitCursor

            uge_detra.Export(ug_Lista, str_nombre_arc_exc)

            Process.Start(str_nombre_arc_exc)
            Me.Cursor = Cursors.Default
        Catch ex As Exception
            Call Avisar("Ocurrio un error.")
            Me.Cursor = Cursors.Default
        End Try
    End Sub

    Private Sub Tool_Salir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_Salir.Click
        Me.Close()
    End Sub

    Private Sub pFormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        obr = Nothing
        e.Cancel = False
    End Sub

End Class