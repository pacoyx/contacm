Public Class CO_RP_ChequeGirado

    Private Sub CO_RP_ChequeGirado_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call Cargar_Bancos()
    End Sub

    Private Sub Cargar_Bancos()
        Dim bancosBL As New BL.ContabilidadBL.SG_CO_TB_BANCO
        Dim bancosBE As New BE.ContabilidadBE.SG_CO_TB_BANCO
        bancosBE.BA_IDEMPRESA = New BE.ContabilidadBE.SG_CO_TB_EMPRESA With {.EM_ID = gInt_IdEmpresa}
        uce_banco.DataSource = bancosBL.getBancos(bancosBE)
        uce_banco.DisplayMember = "BA_NOMBRE"
        uce_banco.ValueMember = "BA_ID"
        bancosBE = Nothing
        bancosBL = Nothing
    End Sub

    Private Sub Tool_salir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_salir.Click
        Me.Close()
    End Sub

    Private Sub uce_banco_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles uce_banco.ValueChanged
        Dim ctacteBL As New BL.ContabilidadBL.SG_CO_TB_BANCO_CTACTE
        Dim ctacteBE As New BE.ContabilidadBE.SG_CO_TB_BANCO_CTACTE
        ctacteBE.BC_IDBANCO = New BE.ContabilidadBE.SG_CO_TB_BANCO With {.BA_ID = uce_banco.Value}
        uce_ctacte.DataSource = ctacteBL.getCtasCorrientes_dt_02(ctacteBE)
        uce_ctacte.DisplayMember = "DESCRIPCION"
        uce_ctacte.ValueMember = "PC_NUM_CUENTA"
        ctacteBE = Nothing
        ctacteBL = Nothing
    End Sub

    Private Sub Tool_exportar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_exportar.Click
        Try
            Me.Cursor = Cursors.WaitCursor
            Call Tool_consultar_Click(sender, e)
            UltraGridExcelExporter1.Export(ug_cheques, "chequess.xls")
            Process.Start("chequess.xls")
            Me.Cursor = Cursors.Default
        Catch ex As Exception
            Call Avisar("Cierre el excel antes de exportar de nuevo.")
            Me.Cursor = Cursors.Default
        End Try
    End Sub

    Private Sub Tool_consultar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_consultar.Click
        Dim reportesBL As New BL.ContabilidadBL.SG_CO_Reportes_Registros
        ug_cheques.DataSource = reportesBL.get_Cheques_Girados(uce_ctacte.Value, udte_f1.Value, udte_f2.Value, gInt_IdEmpresa)
        reportesBL = Nothing
    End Sub
End Class