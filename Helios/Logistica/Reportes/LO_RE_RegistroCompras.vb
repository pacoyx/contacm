Public Class LO_RE_RegistroCompras

    Private Sub LO_RE_RegistroCompras_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call CargarCombo_ConMeses(uce_Mes)
        txt_Ayo.Text = gDat_Fecha_Sis.Year
        txt_Ayo.ReadOnly = True
        uce_Mes.Value = gDat_Fecha_Sis.Month
    End Sub
    Private Sub Tool_salir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_salir.Click
        Me.Close()
    End Sub


    Private Sub Tool_imprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_imprimir.Click

        Me.Cursor = Cursors.WaitCursor

        Dim reportesfaBL As New BL.LogisticaBL.SG_LO_TB_COMPROBANTES_CAB
        Dim crystalBL As New LR.ClsReporte
        Dim dt_data As New DataTable
        Dim periodo As String = txt_Ayo.Text & " / " & uce_Mes.Text


        If gInt_IdEmpresa = 7 Then
            dt_data = reportesfaBL.get_ComprobanteRegsitro(Val(txt_Ayo.Text), uce_Mes.Value, gInt_IdEmpresa)
            crystalBL.Muestra_Reporte(gStr_RutaRep & "\SG_LO_11.RPT", dt_data, "", "pEmp;" & gStr_NomEmpresa, "pPeriodo;" & periodo)
        Else
            dt_data = reportesfaBL.get_ComprobanteRegsitro(Val(txt_Ayo.Text), uce_Mes.Value, gInt_IdEmpresa)
            crystalBL.Muestra_Reporte(gStr_RutaRep & "\SG_LO_11.RPT", dt_data, "", "pEmp;" & gStr_NomEmpresa, "pPeriodo;" & periodo)
            'dt_data = reportesfaBL.get_Reg_Venta(txt_Ayo.Text, uce_Mes.Value, gInt_IdEmpresa)
            'crystalBL.Muestra_Reporte(gStr_RutaRep & "\SG_FA_02.RPT", dt_data, "", "pEmp;" & gStr_NomEmpresa, "pPeriodo;" & periodo)
        End If

        crystalBL = Nothing
        reportesfaBL = Nothing

        Me.Cursor = Cursors.Default

    End Sub

    Private Sub Tool_Exportar_Click(sender As System.Object, e As System.EventArgs) Handles Tool_Exportar.Click
        Try

            Me.Cursor = Cursors.WaitCursor

            Dim reportesfaBL As New BL.LogisticaBL.SG_LO_TB_COMPROBANTES_CAB
            Dim dt_data As DataTable = reportesfaBL.get_ComprobanteRegsitro(Val(txt_Ayo.Text), uce_Mes.Value, gInt_IdEmpresa)
            reportesfaBL = Nothing
            ug_RegCompras.DataSource = dt_data
            Dim str_nombre_arc_exc As String = "Registro Compras " & Date.Now.Day & Date.Now.Month & Date.Now.Year & Date.Now.Hour & Date.Now.Minute & Date.Now.Second & ".xls"

            uge_detra.Export(ug_RegCompras, str_nombre_arc_exc)
            Process.Start(str_nombre_arc_exc)
            Me.Cursor = Cursors.Default
        Catch ex As Exception
            Call Avisar("Ocurrio un error.")
            Me.Cursor = Cursors.Default
        End Try
    End Sub
End Class