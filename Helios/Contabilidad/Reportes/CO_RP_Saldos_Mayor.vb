Public Class CO_RP_Saldos_Mayor

    Private Sub CO_RP_Saldos_Mayor_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call CargarCombo_ConMeses(uce_Mes)
        txt_Ayo.Text = gDat_Fecha_Sis.Year
        txt_Ayo.ReadOnly = True
        uce_Mes.Value = gDat_Fecha_Sis.Month

        Call Cargar_Cuentas_Combo()
        Call Formatear_Grilla_Selector(ug_saldos)
        ug_saldos2.Visible = uchk_saldos2.Checked

    End Sub

    Private Sub Cargar_Cuentas_Combo()

        Dim Obj_PlanCtasBL As New BL.ContabilidadBL.SG_CO_TB_PLANCTAS
        Dim E_PlanCtas As New BE.ContabilidadBE.SG_CO_TB_PLANCTAS

        E_PlanCtas.PC_IDEMPRESA = New BE.ContabilidadBE.SG_CO_TB_EMPRESA With {.EM_ID = gInt_IdEmpresa}
        E_PlanCtas.PC_PERIODO = gDat_Fecha_Sis.Year

        uc_Cuentas1.DataSource = Obj_PlanCtasBL.getCuentas_DT(E_PlanCtas)
        uc_Cuentas2.DataSource = Obj_PlanCtasBL.getCuentas_DT(E_PlanCtas)


        E_PlanCtas = Nothing
        Obj_PlanCtasBL = Nothing


    End Sub

    Private Sub Tool_Salir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_Salir.Click
        Me.Close()
    End Sub

    Private Sub Tool_Consultar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_Consultar.Click
        Me.Cursor = Cursors.WaitCursor

        Dim Obj_ReporteBL As New BL.ContabilidadBL.SG_CO_Reportes_Registros
        Dim EmpresaBE As New BE.ContabilidadBE.SG_CO_TB_EMPRESA With {.EM_ID = gInt_IdEmpresa}
        Dim Dt As DataTable = Nothing


        If uchk_CtasTitulo.Checked Then

            Dim PlanCtasBL As New BL.ContabilidadBL.SG_CO_TB_PLANCTAS
            Dim PlanCtasBE As New BE.ContabilidadBE.SG_CO_TB_PLANCTAS
            PlanCtasBE.PC_PERIODO = txt_Ayo.Text.Trim
            PlanCtasBE.PC_IDEMPRESA = EmpresaBE

            Dim Dt_cuentas As DataTable = Nothing
            If uc_Cuentas1.Text.Trim <> "" And uc_Cuentas2.Text.Trim <> "" Then
                Dt_cuentas = PlanCtasBL.getCuentas_DT_X_cuentas(PlanCtasBE, uc_Cuentas1.Text.Trim, uc_Cuentas2.Text.Trim)
            Else
                Dt_cuentas = PlanCtasBL.getCuentas_DT(PlanCtasBE)
            End If

            Obj_ReporteBL.Limpiar_Tabla_Saldos_Mayor()

            pb1.Visible = True
            pb1.Minimum = 0
            pb1.Maximum = Dt_cuentas.Rows.Count

            For i As Integer = 0 To Dt_cuentas.Rows.Count - 1
                Obj_ReporteBL.set_Saldos_Mayor(txt_Ayo.Text, uce_Mes.Value, gInt_IdEmpresa, Dt_cuentas.Rows(i)("PC_NUM_CUENTA"))
                pb1.Increment(1)
            Next

            pb1.Value = 0
            pb1.Visible = False

            Dt = Obj_ReporteBL.get_Saldo_Mayor_ConCtasTitulo()

        Else

            Dt = Obj_ReporteBL.get_Saldo_Mayor_SinCtasTitulo(txt_Ayo.Text, uce_Mes.Value, gInt_IdEmpresa, uc_Cuentas1.Text.Trim, uc_Cuentas2.Text.Trim)

        End If

        ug_saldos.DataSource = Dt

        Me.Cursor = Cursors.Default
    End Sub

    Private Sub Tool_imprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_imprimir.Click

        Dim Obj_repo As New LR.ClsReporte
        Dim dt As DataTable
        Dim Str_Periodo As String = uce_Mes.Text & " - " & txt_Ayo.Text
        Dim str_titulo As String = txt_titulo.Text
        Dim str_conFecha As String = IIf(uchk_fecha.Checked, "1", "0")
        Dim str_fecha As String = "Fecha :   " & Now.Date.ToShortDateString

        Me.Cursor = Cursors.WaitCursor

        If uchk_saldos2.Checked Then
            dt = CType(ug_saldos2.DataSource, DataTable)
        Else
            dt = CType(ug_saldos.DataSource, DataTable)
        End If


        If uchk_saldos2.Checked Then
            Obj_repo.Muestra_Reporte(gStr_RutaRep & "\SG_CO_27_2.rpt", dt, "", "pEmp;" & gStr_NomEmpresa, "pPeriodo;" & Str_Periodo, "pTitulo;" & str_titulo, "pConFec;" & str_conFecha, "pFecha;" & str_fecha)
        Else
            Obj_repo.Muestra_Reporte(gStr_RutaRep & "\SG_CO_27.rpt", dt, "", "pEmp;" & gStr_NomEmpresa, "pPeriodo;" & Str_Periodo)
        End If

        Obj_repo.Dispose()

        Me.Cursor = Cursors.Default

    End Sub

    Private Sub Tool_excel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_excel.Click

        Dim utilesBL As New LR.ClsFunciones


        If uchk_saldos2.Checked Then
            'Call Exportar_Datos_a_Excel()

            uge_1.Export(ug_saldos2, "saldos.xls")
        Else
            uge_1.Export(ug_saldos, "saldos.xls")
        End If

        Process.Start("saldos.xls")

        Exit Sub


        'Dim Str_titulo As String = "Saldos de Mayor - Periodo : " & txt_Ayo.Text & " / " & uce_Mes.Text
        'Dim dt_datos As DataTable
        'dt_datos = CType(ug_saldos.DataSource, DataTable)

        'Dim oExcel As Microsoft.Office.Interop.Excel.ApplicationClass
        'Dim oBooks As Microsoft.Office.Interop.Excel.Workbooks
        'Dim oBook As Microsoft.Office.Interop.Excel.WorkbookClass
        'Dim oSheet As Microsoft.Office.Interop.Excel.Worksheet


        'Me.Cursor = Cursors.WaitCursor

        '' Inicia Excel y abre el workbook
        'oExcel = CreateObject("Excel.Application")
        'oExcel.Visible = True
        'oBooks = oExcel.Workbooks
        'oBook = oExcel.Workbooks.Add
        'oSheet = oBook.Sheets(1)



        'Const ROW_FIRST = 4
        'Dim iRow As Int64 = 1
        'Dim iCols As Int16 = dt_datos.Columns.Count


        'oSheet.Cells(1, 1) = Str_titulo
        'oSheet.Cells(1, 1).font.bold = True

        ''Llenamos la cabecera
        'For i As Integer = 1 To iCols
        '    oSheet.Cells(ROW_FIRST, i) = dt_datos.Columns(i - 1).Caption
        '    oSheet.Cells(ROW_FIRST, i).font.bold = True
        '    oSheet.Columns(i).ColumnWidth = 15
        'Next



        'For j As Integer = 0 To dt_datos.Rows.Count - 1
        '    Dim iCurrRow As Int64 = ROW_FIRST + iRow

        '    For iCol As Integer = 1 To iCols
        '        oSheet.Cells(iCurrRow, iCol) = dt_datos.Rows(j)(iCol - 1)
        '    Next

        '    Dim objCelda As Microsoft.Office.Interop.Excel.Range = oSheet.Range("G" & iCurrRow, "I" & iCurrRow)
        '    objCelda.EntireColumn.NumberFormat = "###,###,###.00"



        '    iRow += 1
        'Next


        'Dim objRango As Microsoft.Office.Interop.Excel.Range = oSheet.Range("A" & ROW_FIRST, "I" & iRow)
        'objRango.Select()
        'objRango.Borders.ColorIndex = 0

        'objRango.Columns.AutoFit()
        ''        objRango.Columns.Borders


        'oBook.PrintPreview()

        'Me.Cursor = Cursors.Default
    End Sub

    Private Sub uc_Cuentas1_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles uc_Cuentas1.KeyDown
        If e.KeyCode = Keys.Enter Then
            uc_Cuentas2.Value = uc_Cuentas1.Value
            uc_Cuentas2.Focus()
        End If
    End Sub

    Private Sub uchk_saldos2_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles uchk_saldos2.CheckedChanged
        ug_saldos2.Visible = uchk_saldos2.Checked

        If uchk_saldos2.Checked Then
            Call Cargar_Saldos2()
        End If

    End Sub

    Private Sub Cargar_Saldos2()
        Dim Dt As DataTable
        Dim Obj_ReporteBL As New BL.ContabilidadBL.SG_CO_Reportes_Registros

        Dt = Obj_ReporteBL.get_Saldo_Mayor_SinCtasTitulo_3(txt_Ayo.Text, uce_Mes.Value, gInt_IdEmpresa, uc_Cuentas1.Text.Trim, uc_Cuentas2.Text.Trim)

        ug_saldos2.DataSource = Dt

        Obj_ReporteBL = Nothing

    End Sub



    Private Sub Exportar_Datos_a_Excel()

        Dim Dt As DataTable
        Dt = CType(ug_saldos2.DataSource, DataTable)


        Dim excel As Object
        Dim wBook As Object
        Dim wSheet As Object

        excel = excel.ApplicationClass
        wBook = excel.Workbook
        wSheet = excel.Worksheet

        wBook = excel.Workbooks.Add()
        wSheet = wBook.ActiveSheet()

        For c As Integer = 1 To Dt.Columns.Count
            excel.Cells(5, c + 2) = Dt.Columns(c - 1).ColumnName
        Next

        wSheet.Columns.AutoFit()
        Dim strFileName As String = "D:\ss.xls"
        Dim blnFileOpen As Boolean = False
        Try
            Dim fileTemp As System.IO.FileStream = System.IO.File.OpenWrite(strFileName)
            fileTemp.Close()
        Catch ex As Exception
            blnFileOpen = False
        End Try

        If System.IO.File.Exists(strFileName) Then
            System.IO.File.Delete(strFileName)
        End If

        wBook.SaveAs(strFileName)
        excel.Workbooks.Open(strFileName)
        excel.Visible = True



    End Sub

End Class