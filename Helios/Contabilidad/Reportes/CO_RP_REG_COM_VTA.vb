Imports System.Drawing.Printing

Public Class CO_RP_REG_COM_VTA

    Private Sub CO_RP_REG_COM_VTA_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Call CargarCombo_ConMeses(uce_Mes)
        txt_Ayo.Text = gDat_Fecha_Sis.Year
        'txt_Ayo.ReadOnly = True
        uce_Mes.Value = gDat_Fecha_Sis.Month

    End Sub

    Private Sub Registro_Compras()
        Try
            Dim Obj_ReporteBL As New BL.ContabilidadBL.SG_CO_Reportes_Registros
            Dim E_Cabecera As New BE.ContabilidadBE.SG_CO_TB_ASIENTO_CAB
            Dim E_Empresa As New BE.ContabilidadBE.SG_CO_TB_EMPRESA With {.EM_ID = gInt_IdEmpresa}

            E_Cabecera.AC_ANHO = CInt(txt_Ayo.Text.Trim)
            E_Cabecera.AC_MES = CInt(uce_Mes.Value)
            E_Cabecera.AC_IDEMPRESA = E_Empresa

            Dim Dt_Compras As DataTable = Obj_ReporteBL.getRegistro_Compras(E_Cabecera)
            Dim Obj_EmpresaBL As New BL.ContabilidadBL.SG_CO_TB_EMPRESA
            Obj_EmpresaBL.getEmpresas_2(E_Empresa)

            Dim Str_NombreRep As String = "SG_CO_03.RPT"
            Dim texto_sinMovi As String = ""

            If Dt_Compras.Rows.Count = 0 Then
                texto_sinMovi = "S i n   M o v i m i e n t o "
            End If


            Select Case uos_opciones.Value
                Case "S"
                    Str_NombreRep = "SG_CO_03.RPT"
                Case "SN"

                    Dim pd As New PrintDocument
                    Dim IPredet As String = pd.PrinterSettings.PrinterName
                    Dim vector_p As String() = IPredet.Split("\")

                    Str_NombreRep = "SG_CO_02.RPT"
                    'la impresora Epson FX-2180 es de la PC de Maria
                    If vector_p(vector_p.Count - 1) = "Epson FX-2180" Then
                        Str_NombreRep = "SG_CO_02_2.RPT"
                    End If

                    vector_p = Nothing
                    IPredet = Nothing
                    pd = Nothing

                Case "SNC"
                    Str_NombreRep = "SG_CO_02_1.RPT"
            End Select

            Dim ObjReporte As New LR.ClsReporte

            ObjReporte.Muestra_Reporte(String.Format("{0}\{1}", gStr_RutaRep, Str_NombreRep), Dt_Compras, "", String.Format("pPeriodo;{0} / {1}", uce_Mes.Text.Trim, txt_Ayo.Text.Trim), _
                                 "pRuc;" & E_Empresa.EM_RUC, _
                                 "pRazon;" & E_Empresa.EM_NOMBRE.Trim, "pSinMovi;" & texto_sinMovi)
            ObjReporte.Dispose()

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub Registro_Ventas()
        Try
            Dim Obj_ReporteBL As New BL.ContabilidadBL.SG_CO_Reportes_Registros
            Dim E_Cabecera As New BE.ContabilidadBE.SG_CO_TB_ASIENTO_CAB
            Dim E_Empresa As New BE.ContabilidadBE.SG_CO_TB_EMPRESA With {.EM_ID = gInt_IdEmpresa}

            E_Cabecera.AC_ANHO = CInt(txt_Ayo.Text.Trim)
            E_Cabecera.AC_MES = CInt(uce_Mes.Value)
            E_Cabecera.AC_IDEMPRESA = E_Empresa

            Dim Dt As DataTable = Obj_ReporteBL.getRegistro_Ventas(E_Cabecera)
            Dim Obj_EmpresaBL As New BL.ContabilidadBL.SG_CO_TB_EMPRESA
            Obj_EmpresaBL.getEmpresas_2(E_Empresa)

            Dim Str_NombreRep As String = "SG_CO_04.RPT"
            Dim texto_sinMovi As String = ""

            If Dt.Rows.Count = 0 Then
                texto_sinMovi = "S i n   M o v i m i e n t o "
            End If

            Select Case uos_opciones.Value
                Case "S"
                    Str_NombreRep = "SG_CO_05.RPT"
                Case "SN"
                    Str_NombreRep = "SG_CO_04.RPT"
                Case "SNC"
                    Str_NombreRep = "SG_CO_04_1.RPT"
            End Select

            Dim ObjReporte As New LR.ClsReporte

            ObjReporte.Muestra_Reporte(String.Format("{0}\{1}", gStr_RutaRep, Str_NombreRep), Dt, "", String.Format("pPeriodo;{0} / {1}", uce_Mes.Text.Trim, txt_Ayo.Text.Trim), _
                                 "pRuc;" & E_Empresa.EM_RUC, _
                                 "pRazon;" & E_Empresa.EM_NOMBRE.Trim, "pSinMovi;" & texto_sinMovi)
            ObjReporte.Dispose()

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub Registro_Honorarios()
        Try
            Dim reporteBL As New BL.ContabilidadBL.SG_CO_Reportes_Registros
            Dim cabeceraBE As New BE.ContabilidadBE.SG_CO_TB_ASIENTO_CAB
            Dim empresaBE As New BE.ContabilidadBE.SG_CO_TB_EMPRESA With {.EM_ID = gInt_IdEmpresa}

            cabeceraBE.AC_ANHO = CInt(txt_Ayo.Text.Trim)
            cabeceraBE.AC_MES = CInt(uce_Mes.Value)
            cabeceraBE.AC_IDEMPRESA = empresaBE

            Dim Dt As DataTable = reporteBL.getRegistro_Honorarios(cabeceraBE)
            Dim empresaBL As New BL.ContabilidadBL.SG_CO_TB_EMPRESA
            empresaBL.getEmpresas_2(empresaBE)

            Dim Str_NombreRep As String = "SG_CO_04.RPT"

            Select Case uos_opciones.Value
                Case "S"
                    Str_NombreRep = "SG_CO_06.RPT"
                Case "SN"
                    Str_NombreRep = "SG_CO_06.RPT"
                Case "SNC"
                    Str_NombreRep = "SG_CO_06.RPT"
            End Select

            Dim ObjReporte As New LR.ClsReporte

            ObjReporte.Muestra_Reporte(String.Format("{0}\{1}", gStr_RutaRep, Str_NombreRep), Dt, "", String.Format("pPeriodo;{0} / {1}", uce_Mes.Text.Trim, txt_Ayo.Text.Trim), _
                                 "pRuc;" & empresaBE.EM_RUC, _
                                 "pRazon;" & empresaBE.EM_NOMBRE.Trim)
            ObjReporte.Dispose()

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub Tool_imprimir_Click(sender As System.Object, e As System.EventArgs) Handles Tool_imprimir.Click
        Try
            Me.Cursor = Cursors.WaitCursor

            If txt_Ayo.Text.Trim.Length = 0 Then
                Avisar("El periodo no se a cargado.")
                Exit Sub
            End If

            If uce_Mes.SelectedIndex = -1 Then
                Avisar("Seleccione mes")
                uce_Mes.Focus()
                Exit Sub
            End If

            Select Case uos_Tipo.Value
                Case "C"
                    Registro_Compras()
                Case "V"
                    Registro_Ventas()
                Case "H"
                    Registro_Honorarios()
            End Select

            Me.Cursor = Cursors.Default

        Catch ex As Exception
            Avisar("Ocurrio un error : " & ex.Message)
            Me.Cursor = Cursors.Default
        End Try

    End Sub

    Private Sub Tool_exportar_Click(sender As System.Object, e As System.EventArgs) Handles Tool_exportar.Click
        Dim Obj_ReporteBL As New BL.ContabilidadBL.SG_CO_Reportes_Registros
        Dim E_Cabecera As New BE.ContabilidadBE.SG_CO_TB_ASIENTO_CAB
        Dim E_Empresa As New BE.ContabilidadBE.SG_CO_TB_EMPRESA With {.EM_ID = gInt_IdEmpresa}

        E_Cabecera.AC_ANHO = CInt(txt_Ayo.Text.Trim)
        E_Cabecera.AC_MES = CInt(uce_Mes.Value)
        E_Cabecera.AC_IDEMPRESA = E_Empresa

        Dim Dt As DataTable = Nothing
        Select Case uos_Tipo.Value
            Case "C"
                Dt = Obj_ReporteBL.getRegistro_Compras_toExcel(E_Cabecera)
                ug_registro.Text = "Registro de Compras"

            Case "V"
                Dt = Obj_ReporteBL.getRegistro_Ventas_toExcel(E_Cabecera)
                ug_registro.Text = "Registro de Ventas"

            Case "H"
                Dt = Obj_ReporteBL.getRegistro_Honorarios_toExcel(E_Cabecera)
                ug_registro.Text = "Registro de Honorarios"
        End Select

        ug_registro.DataSource = Dt
        ug_registro.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy
        ug_registro.DisplayLayout.GroupByBox.Hidden = True
        'ug_registro.DisplayLayout.Bands(0).SortedColumns.Add("TDOC", False, True)
        'ug_registro.DisplayLayout.Bands(0).Override.SummaryDisplayArea = Infragistics.Win.UltraWinGrid.SummaryDisplayAreas.GroupByRowsFooter

        ex_registro.Export(ug_registro, "prueba.xls")
        Process.Start(Application.StartupPath & "\prueba.xls")

        Dt = Nothing
    End Sub

    Private Sub Tool_salir_Click(sender As System.Object, e As System.EventArgs) Handles Tool_salir.Click
        Me.Close()
    End Sub

    Private Sub ToolStrip1_ItemClicked(sender As System.Object, e As System.Windows.Forms.ToolStripItemClickedEventArgs) Handles ToolStrip1.ItemClicked

    End Sub
End Class