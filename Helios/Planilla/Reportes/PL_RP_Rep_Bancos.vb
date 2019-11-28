Public Class PL_RP_Rep_Bancos
    Dim comenzar As Boolean = False

    Private Sub PL_RP_Rep_Bancos_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        une_ayo.Value = gDat_Fecha_Sis.Year
        Call Formatear_Grilla_Selector(ug_bancos)
        Call CargarCombo_ConMeses(uce_Mes)
        Call Cargar_TipoPersonal()
        uce_TipoPersonal.SelectedIndex = 0
        comenzar = Not comenzar

        ubtn_rep2.Visible = False
        If gStr_Usuario_Sis = "lsarasi" Or gStr_Usuario_Sis = "ksolis" Then
            ubtn_rep2.Visible = True
        End If

    End Sub

    Private Sub Tool_Salir_Click(sender As System.Object, e As System.EventArgs) Handles Tool_Salir.Click
        Me.Close()
    End Sub

    Private Sub Tool_imprimir_Click(sender As System.Object, e As System.EventArgs) Handles Tool_imprimir.Click


        If uce_Mes.SelectedIndex = -1 Then
            Avisar("Seleccione un mes")
            uce_Mes.Focus()
            Exit Sub
        End If

        If uce_TipoPersonal.SelectedIndex = -1 Then
            Avisar("Seleccione un Tipo de Trabajador")
            uce_Mes.Focus()
            Exit Sub
        End If

        Me.Cursor = Cursors.WaitCursor
        Dim dt_tmp As DataTable = CType(ug_bancos.DataSource, DataTable)
        Dim reportesBL As New BL.PlanillaBL.SG_PL_TB_PERSONAL
        Dim str_fecha As String = uce_Mes.Text
        Using crystalBL As New LR.ClsReporte
            crystalBL.Muestra_Reporte(gStr_RutaRep & "\SG_PL_18.rpt", dt_tmp, "", "pEmp;" & gStr_NomEmpresa, _
                                                                              "pMes;" & str_fecha.ToUpper, _
                                                                                "pTipoPer;" & uce_TipoPersonal.Text)
        End Using
        reportesBL = Nothing
        Me.Cursor = Cursors.Default

    End Sub

    Private Sub Cargar_TipoPersonal()
        Dim tipoPersonalBL As New BL.PlanillaBL.SG_PL_TB_TIPO_PERSONAL
        uce_TipoPersonal.DataSource = tipoPersonalBL.getTipos()
        uce_TipoPersonal.ValueMember = "TP_ID"
        uce_TipoPersonal.DisplayMember = "TP_DESCRIPCION"
        tipoPersonalBL = Nothing
    End Sub

    Private Sub uce_Mes_ValueChanged(sender As System.Object, e As System.EventArgs) Handles uce_Mes.ValueChanged
        Call Cargar_Data_para_Bancos()
    End Sub

    Private Sub uce_TipoPersonal_ValueChanged(sender As System.Object, e As System.EventArgs) Handles uce_TipoPersonal.ValueChanged
        Call Cargar_Data_para_Bancos()
    End Sub

    Private Sub Cargar_Data_para_Bancos()

        If uce_Mes.SelectedIndex = -1 Then Exit Sub
        If uce_TipoPersonal.SelectedIndex = -1 Then Exit Sub

        Dim reportesBL As New BL.PlanillaBL.SG_PL_Reportes
        ug_bancos.DataSource = reportesBL.get_Reporte_para_Bancos(une_ayo.Value, uce_Mes.Value, uce_TipoPersonal.Value, gInt_IdEmpresa, uos_Periodo.Value, uos_Neto.Value)
        reportesBL = Nothing

    End Sub

    Private Sub une_ayo_ValueChanged(sender As System.Object, e As System.EventArgs) Handles une_ayo.ValueChanged
        Call Cargar_Data_para_Bancos()
    End Sub

    Private Sub uos_Neto_ValueChanged(sender As System.Object, e As System.EventArgs) Handles uos_Neto.ValueChanged
        Call Cargar_Data_para_Bancos()
    End Sub

    Private Sub uos_Periodo_ValueChanged(sender As System.Object, e As System.EventArgs) Handles uos_Periodo.ValueChanged
        Call Cargar_Data_para_Bancos()
    End Sub

    Private Sub ubtn_rep2_Click(sender As System.Object, e As System.EventArgs) Handles ubtn_rep2.Click

        If uce_Mes.SelectedIndex = -1 Then
            Avisar("Seleccione un mes")
            uce_Mes.Focus()
            Exit Sub
        End If

        If uce_TipoPersonal.SelectedIndex = -1 Then
            Avisar("Seleccione un Tipo de Trabajador")
            uce_Mes.Focus()
            Exit Sub
        End If

        Me.Cursor = Cursors.WaitCursor


        Dim empresaBL As New BL.ContabilidadBL.SG_CO_TB_EMPRESA
        Dim empresaBE As New BE.ContabilidadBE.SG_CO_TB_EMPRESA
        empresaBE.EM_ID = gInt_IdEmpresa
        empresaBL.getEmpresas_2(empresaBE)

        Dim total As Double = 0
        For i As Integer = 0 To ug_bancos.Rows.Count - 1
            total += ug_bancos.Rows(i).Cells("IMPORTE").Value
        Next

        Dim dt_tmp As DataTable = Nothing
        Dim reportesBL As New BL.PlanillaBL.SG_PL_Reportes
        dt_tmp = reportesBL.get_Reporte_para_Bancos_02(une_ayo.Value, uce_Mes.Value, uce_TipoPersonal.Value, gInt_IdEmpresa, uos_Periodo.Value, uos_Neto.Value)
        Dim str_mes As String = uce_Mes.Text
        Dim ayo As Integer = une_ayo.Value
        Dim fecha As String = "Lima, " & Now.Day & " de " & get_Nombre_Mes(Now.Month) & " del " & Now.Year.ToString
        Dim ruc As String = empresaBE.EM_RUC
        Dim monto_texto As String = Letras(total)
        Dim nomb_gerente As String = empresaBE.EM_REPRESENTANTE
        Dim quincena_1_2 As String = IIf(uos_Periodo.Value = "1", "primera", "segunda")
        Dim cuentasBanco As String = ""

        monto_texto = monto_texto & " Soles"
        Select Case gInt_IdEmpresa
            Case 3 'Gestar
                cuentasBanco = "014-0002015"
            Case 4 'Ginefert
                cuentasBanco = "014-0002023"
            Case 5 'GyF
                cuentasBanco = "014-0002007"
            Case 6 'Ecogest
                cuentasBanco = "014-0001990"
        End Select

        Using crystalBL As New LR.ClsReporte
            crystalBL.Muestra_Reporte(gStr_RutaRep & "\SG_PL_28.rpt", dt_tmp, "", "pFecha;" & fecha, "pEmpresa;" & gStr_NomEmpresa, "pRuc;" & ruc, "pImpTexto;" & monto_texto, "pGerente;" & nomb_gerente, "pQuincena;" & quincena_1_2, "pMes;" & str_mes.ToUpper, "pAnho;" & ayo.ToString, "pCuentaBanco;" & cuentasBanco)
        End Using

        empresaBE = Nothing
        empresaBL = Nothing
        reportesBL = Nothing
        Me.Cursor = Cursors.Default
    End Sub
End Class