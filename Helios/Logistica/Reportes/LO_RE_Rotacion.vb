Public Class LO_RE_Rotacion
    Private obe As BE.LogisticaBE.SG_LO_TB_SALDOS_C
    Private obr As BL.LogisticaBL.SG_LO_TB_SALDOS_C
    Public Sub New()
        InitializeComponent()
        obe = New BE.LogisticaBE.SG_LO_TB_SALDOS_C
        obr = New BL.LogisticaBL.SG_LO_TB_SALDOS_C
    End Sub

    Private Sub pKeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If e.KeyChar = Convert.ToChar(Keys.Return) Then
            SendKeys.Send("{TAB}")
            e.Handled = True
        End If
    End Sub

    Private Sub pKeyPressNumero(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_año.KeyPress
        e.KeyChar = fKeyPress(e.KeyChar, sender.Text, 1)
        e.Handled = (e.KeyChar = "")
    End Sub

    Private Sub Tool_Consultar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_Consultar.Click
        Call LimpiaGrid(ug_data, uds_Lista)
        If txt_año.Text.Length <> 4 Then Exit Sub
        ug_data.DataSource = obr.Rotacion(uce_Mes.Value, Val(txt_año.Text))
        ug_data.UpdateData()
    End Sub

    'Private Sub Tool_Imprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_Imprimir.Click
    '    If txt_año.Text.Length <> 4 Then Exit Sub
    '    Me.Cursor = Cursors.WaitCursor
    '    Dim obj As New DataTable

    '    Dim nom_reporte As String = "SG_LO_10.RPT"
    '    Dim crystalBL As New LR.ClsReporte
    '    Dim dt_data As New DataTable
    '    dt_data = obr.Rotacion(uce_Mes.Value, Val(txt_año.Text))

    '    crystalBL.Muestra_Reporte(gStr_RutaRep & "\" & nom_reporte, dt_data, "", "Mes;" & uce_Mes.Text, "ayo;" & Val(txt_año.Text))

    '    crystalBL = Nothing
    '    ' reportesBL = Nothing

    '    Me.Cursor = Cursors.Default
    'End Sub

    Private Sub LO_RE_InventarioValoriz_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        obe = New BE.LogisticaBE.SG_LO_TB_SALDOS_C
        obr = New BL.LogisticaBL.SG_LO_TB_SALDOS_C
        Me.KeyPreview = True

        Call LimpiaGrid(ug_data, uds_Lista)
        txt_año.Text = Now.Year
        uce_Mes.Value = IIf(Now.Month < 10, "0" & Now.Month, Now.Month)
    End Sub

    Private Sub Tool_Exportar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_Exportar.Click
        Dim str_nombre_arc_exc As String = "Rotacion " & Date.Now.Day & Date.Now.Month & Date.Now.Year & Date.Now.Hour & Date.Now.Minute & Date.Now.Second & ".xls"
        Try
            Me.Cursor = Cursors.WaitCursor
            uge_detra.Export(ug_data, str_nombre_arc_exc)

            Process.Start(str_nombre_arc_exc)
            Me.Cursor = Cursors.Default
        Catch ex As Exception
            Call Avisar("Ocurrio un error.")
            Me.Cursor = Cursors.Default
        End Try
    End Sub

    Private Sub uce_Mes_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles uce_Mes.ValueChanged
        Tool_Consultar_Click(Nothing, Nothing)
    End Sub

    Private Sub Tool_Salir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_Salir.Click
        Me.Close()
    End Sub
    Private Sub pFormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        obe = Nothing
        obr = Nothing
        e.Cancel = False
    End Sub
    Private Sub txt_año_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_año.LostFocus
        Tool_Consultar_Click(Nothing, Nothing)
    End Sub

End Class