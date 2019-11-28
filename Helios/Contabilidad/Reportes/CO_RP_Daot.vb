Public Class CO_RP_Daot

    Private Sub Tool_Salir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_Salir.Click
        Me.Close()
    End Sub

    Private Sub CO_RP_Daot_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        txt_Ayo.Text = gDat_Fecha_Sis.Year
        ume_uit.Value = 3850
        une_por.Value = 2
        ume_tope.Value = ume_uit.Value * une_por.Value

    End Sub

    Private Sub une_por_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles une_por.KeyDown
        If e.KeyCode = Keys.Enter Then
            une_por.Focus()
        End If
    End Sub

    Private Sub une_por_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles une_por.Leave
        If ume_uit.Value Is Nothing Then Exit Sub
        If une_por.Value Is Nothing Then Exit Sub

        ume_tope.Value = CDbl(ume_uit.Value) * CDbl(une_por.Value)

    End Sub

    Private Sub ume_uit_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles ume_uit.KeyDown
        If e.KeyCode = Keys.Enter Then
            If ume_uit.Value Is Nothing Then Exit Sub
            If une_por.Value Is Nothing Then Exit Sub

            ume_tope.Value = CDbl(ume_uit.Value) * CDbl(une_por.Value)

        End If
    End Sub

    Private Sub Tool_imprimir_Click(sender As System.Object, e As System.EventArgs) Handles Tool_imprimir.Click
        If ume_tope.Value Is Nothing Then Exit Sub


        Me.Cursor = Cursors.WaitCursor

        Dim reporteBL As New BL.ContabilidadBL.SG_CO_Reportes_Registros
        Dim dbl_tope As Double = ume_tope.Value
        Dim dt_daot As DataTable = reporteBL.get_DAOT(txt_Ayo.Text.Trim, uos_tipo.Value, dbl_tope, gInt_IdEmpresa)
        Dim Str_titulo As String = String.Empty

        If uos_tipo.Value = 1 Then
            Str_titulo = "Gastos acumulados a Diciembre " & txt_Ayo.Text
        Else
            Str_titulo = "Ingresos acumulados a Diciembre " & txt_Ayo.Text
        End If

        Dim Obj_Crystal As New LR.ClsReporte
        Obj_Crystal.Muestra_Reporte(gStr_RutaRep & "\SG_CO_42.rpt", dt_daot, "", "pEmpresa;" & gStr_NomEmpresa, "pRuc;", "pTitulo;" & Str_titulo, "pResumen;" & uos_detalle.Value.ToString)

        'SG_CO_28.rpt

        Obj_Crystal.Dispose()

        Me.Cursor = Cursors.Default
    End Sub

    Private Sub ume_uit_EditorButtonClick(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinEditors.EditorButtonEventArgs) Handles ume_uit.EditorButtonClick
        Select Case e.Button.Key
            Case "btn_VerSunat"
                CO_MT_TCamb_Web.Show()
            Case ""
        End Select
    End Sub

    Private Sub ume_uit_Leave(sender As Object, e As System.EventArgs) Handles ume_uit.Leave
        If ume_uit.Value Is Nothing Then Exit Sub
        If une_por.Value Is Nothing Then Exit Sub

        ume_tope.Value = CDbl(ume_uit.Value) * CDbl(une_por.Value)
    End Sub
End Class