Public Class CO_PR_PLE

    Private Sub CO_PR_PLE_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Call CargarCombo_ConMeses(uce_Mes)
        une_Ayo.Value = gDat_Fecha_Sis.Year
        uce_Mes.Value = gDat_Fecha_Sis.Month
    End Sub


    Private Sub Tool_Salir_Click(sender As System.Object, e As System.EventArgs) Handles Tool_Salir.Click
        Me.Close()
    End Sub

    Private Sub Tool_Generar_Click(sender As System.Object, e As System.EventArgs) Handles Tool_Generar.Click
        Call Generar_Archivos_ple()
    End Sub

    Private Sub Generar_Archivos_ple()

        If uchk_RegCompras.Checked Then Call Generar_Archivo_Compras()
        If uchk_RegVentas.Checked Then Call Generar_Archivo_Ventas()
        If uchk_LibDiario.Checked Then Call Generar_Archivo_Libro_Diario()
        If uchk_LibMayor.Checked Then Call Generar_Archivo_Libro_Mayor()
        If uchk_balcom.Checked Then Call Generar_Archivo_Balance_Compro()
        If uchk_planCuentas.Checked Then Call Generar_Archivo_PlanCuentas()
        Call Avisar("Listo!")

    End Sub

    Private Sub Generar_Archivo_Balance_Compro()
        Dim reportesBL As New BL.ContabilidadBL.SG_CO_Reportes_Registros
        reportesBL.get_BalCom_Pdt(une_Ayo.Value, gInt_IdEmpresa, gStr_RutaRep & "\PLE")
        reportesBL = Nothing
    End Sub

    Private Sub Generar_Archivo_Compras()
        Dim reportesBL As New BL.ContabilidadBL.SG_CO_Reportes_Registros
        reportesBL.get_PLE_RegCompras_V3(une_Ayo.Value, uce_Mes.Value, gInt_IdEmpresa, gStr_RutaRep & "\PLE")
        reportesBL.get_PLE_RegCompras_V3_NoDomiciliado(une_Ayo.Value, uce_Mes.Value, gInt_IdEmpresa, gStr_RutaRep & "\PLE")
        reportesBL = Nothing
    End Sub

    Private Sub Generar_Archivo_Ventas()
        Dim reportesBL As New BL.ContabilidadBL.SG_CO_Reportes_Registros
        reportesBL.get_PLE_RegVentas_V3(une_Ayo.Value, uce_Mes.Value, gInt_IdEmpresa, gStr_RutaRep & "\PLE")
        reportesBL = Nothing
    End Sub

    Private Sub Generar_Archivo_Libro_Diario()
        Dim reportesBL As New BL.ContabilidadBL.SG_CO_Reportes_Registros
        reportesBL.get_PLE_Diario_V3(une_Ayo.Value, uce_Mes.Value, gInt_IdEmpresa, gStr_RutaRep & "\PLE")
        reportesBL = Nothing
    End Sub

    Private Sub Generar_Archivo_PlanCuentas()
        Dim reportesBL As New BL.ContabilidadBL.SG_CO_Reportes_Registros
        reportesBL.get_PLE_PlanCuentas(une_Ayo.Value, uce_Mes.Value, gInt_IdEmpresa, gStr_RutaRep & "\PLE")
        reportesBL = Nothing
    End Sub

    Private Sub Generar_Archivo_Libro_Mayor()
        Dim reportesBL As New BL.ContabilidadBL.SG_CO_Reportes_Registros
        reportesBL.get_PLE_Mayor_V3(une_Ayo.Value, uce_Mes.Value, gInt_IdEmpresa, gStr_RutaRep & "\PLE")
        reportesBL = Nothing
    End Sub


    Private Sub Tool_Abrir_Click(sender As System.Object, e As System.EventArgs) Handles Tool_Abrir.Click
        Process.Start("explorer.exe", gStr_RutaRep & "\PLE")
    End Sub

    Private Sub uchk_LibDiario_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles uchk_LibDiario.CheckedChanged

    End Sub
End Class