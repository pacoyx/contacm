Public Class CO_RP_Balance_Gral

    Private Sub CO_RP_Balance_Gral_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call CargarCombo_ConMeses(uce_Mes)
        txt_Ayo.Text = gDat_Fecha_Sis.Year
        'txt_Ayo.ReadOnly = True
        uce_Mes.Value = gDat_Fecha_Sis.Month
    End Sub

    Private Sub Tool_imprimir_Click(sender As System.Object, e As System.EventArgs) Handles Tool_imprimir.Click
        Dim Str_NombreRep As String = "SG_CO_18.RPT"
        Dim ObjReporte As New LR.ClsReporte
        Dim Obj_ReporteBL As New BL.ContabilidadBL.SG_CO_Reportes_Registros
        Dim Dt As DataTable = Nothing
        Dim Dt_ctas_sobregiro As DataTable = Nothing

        Dim ClasesBL As New BL.ContabilidadBL.SG_CO_TB_CLASES_BG
        Dim clasesBG As New List(Of BE.ContabilidadBE.SG_CO_TB_CLASES_BG)
        Dim clase As BE.ContabilidadBE.SG_CO_TB_CLASES_BG

        Dim gruposBG As New List(Of BE.ContabilidadBE.SG_CO_TB_GRUPOS_BG)
        Dim GruposBL As New BL.ContabilidadBL.SG_CO_TB_GRUPOS_BG
        Dim grupo As BE.ContabilidadBE.SG_CO_TB_GRUPOS_BG

        Dim grupoBgCuentasBL As New BL.ContabilidadBL.SG_CO_TB_GRUPOBG_CUENTAS
        Dim cuentas As List(Of BE.ContabilidadBE.SG_CO_TB_PLANCTAS)
        Dim cuenta As BE.ContabilidadBE.SG_CO_TB_PLANCTAS

        Dim EmpresaBE As New BE.ContabilidadBE.SG_CO_TB_EMPRESA With {.EM_ID = gInt_IdEmpresa}

        Try

            Me.Cursor = Cursors.WaitCursor
            clasesBG = ClasesBL.getClases()
            Dt_ctas_sobregiro = Obj_ReporteBL.getCuentas10s_sobreGiro(txt_Ayo.Text.Trim, gInt_IdEmpresa)


            pb1.Value = 0
            pb1.Minimum = 0
            pb1.Maximum = clasesBG.Count
            pb1.Visible = True

            Obj_ReporteBL.Limpiar_Tabla_Balance_Gral()

            For Each clase In clasesBG
                gruposBG = GruposBL.getGrupos_x_Clase(clase)
                For Each grupo In gruposBG
                    cuentas = grupoBgCuentasBL.getCuentas_x_Grupo(grupo, gInt_IdEmpresa, txt_Ayo.Value)
                    For Each cuenta In cuentas
                        Obj_ReporteBL.setImportes_Balance_Gral(clase.CBG_ID, grupo.GBG_ID, cuenta.PC_NUM_CUENTA, CInt(txt_Ayo.Text.Trim), uce_Mes.Value, gInt_IdEmpresa, IIf(uos_Formato.Value = 1, True, False), IIf(uchk_Cierre.Checked, 0, 1))
                    Next
                Next
                pb1.Increment(1)
            Next

            pb1.Value = 0

            Obj_ReporteBL.set_Actualiza_Importe_CajaBancos_Cero()

            Me.Refresh()

            pb1.Value = 0
            pb1.Minimum = 0
            pb1.Maximum = Dt_ctas_sobregiro.Rows.Count
            pb1.Visible = True

            For j As Integer = 0 To Dt_ctas_sobregiro.Rows.Count - 1
                Obj_ReporteBL.setActualizar_Cta10_SobreGiro(Dt_ctas_sobregiro.Rows(j)("PC_NUM_CUENTA"), txt_Ayo.Text.Trim, uce_Mes.Value, gInt_IdEmpresa, IIf(uos_Formato.Value = 1, 0, 1), IIf(uchk_Cierre.Checked, 0, 1))
                pb1.Increment(1)
            Next

            pb1.Visible = False
            pb1.Value = 0


            'actualizo el bal. gen. la cta 89 de resultado de ejercicio
            Obj_ReporteBL.set_Actualizar_Resultado_Ejercicio(txt_Ayo.Text, uce_Mes.Value, gInt_IdEmpresa, "89", IIf(uchk_Cierre.Checked, 0, 1))


            'actualiza los totales del pasivo y patrimonio
            Obj_ReporteBL.setActualizar_Importe_PasivoPatrimonio()


            'Hacemos un select a la tabla
            Dt = Obj_ReporteBL.getBalance_Gral_1()

            Dim Str_Titulo As String = "Estado de Situacion Financiera a " & uce_Mes.Text & " " & txt_Ayo.Text.Trim
            Dim EmpresaBL As New BL.ContabilidadBL.SG_CO_TB_EMPRESA
            EmpresaBL.getEmpresas_2(EmpresaBE)

            ObjReporte.Muestra_Reporte(String.Format("{0}\{1}", gStr_RutaRep, Str_NombreRep), Dt, "", _
            "pTitulo;" & Str_Titulo, "pFormato;(" & uos_Formato.CheckedItem.DisplayText & ")", _
            "pRuc;" & EmpresaBE.EM_RUC, "pRazon;" & EmpresaBE.EM_NOMBRE)

            Me.Cursor = Cursors.Default

            EmpresaBL = Nothing
            EmpresaBE = Nothing
            grupoBgCuentasBL = Nothing
            ClasesBL = Nothing
            clasesBG = Nothing
            gruposBG = Nothing
            GruposBL = Nothing
            Dt = Nothing


        Catch ex As Exception
            Me.Cursor = Cursors.Default
            ShowError(ex.Message)
        End Try
    End Sub

    Private Sub Tool_salir_Click(sender As System.Object, e As System.EventArgs) Handles Tool_salir.Click
        Me.Close()
    End Sub

    Private Sub Tool_exportar_Click(sender As System.Object, e As System.EventArgs) Handles Tool_exportar.Click
        If uchk_Detalle.Checked Then
            Call Exportar_BG_ConDetalle()
        Else
            Call Exportar_Solo_BG()
        End If
    End Sub


    Private Sub Exportar_BG_ConDetalle()
        Dim Obj_ReporteBL As New BL.ContabilidadBL.SG_CO_Reportes_Registros
        Dim Dt_BalGen As DataTable = Nothing
        Dim Dt_ctas_sobregiro As DataTable = Nothing

        Dim ClasesBL As New BL.ContabilidadBL.SG_CO_TB_CLASES_BG
        Dim clasesBG As New List(Of BE.ContabilidadBE.SG_CO_TB_CLASES_BG)
        Dim clase As BE.ContabilidadBE.SG_CO_TB_CLASES_BG

        Dim gruposBG As New List(Of BE.ContabilidadBE.SG_CO_TB_GRUPOS_BG)
        Dim GruposBL As New BL.ContabilidadBL.SG_CO_TB_GRUPOS_BG
        Dim grupo As BE.ContabilidadBE.SG_CO_TB_GRUPOS_BG

        Dim grupoBgCuentasBL As New BL.ContabilidadBL.SG_CO_TB_GRUPOBG_CUENTAS
        Dim cuentas As List(Of BE.ContabilidadBE.SG_CO_TB_PLANCTAS)
        Dim cuentaBE As BE.ContabilidadBE.SG_CO_TB_PLANCTAS
        Dim cuentaBL As BL.ContabilidadBL.SG_CO_TB_PLANCTAS

        Dim EmpresaBE As New BE.ContabilidadBE.SG_CO_TB_EMPRESA With {.EM_ID = gInt_IdEmpresa}
        Dim fecha_ini As String = ""
        Dim fecha_fin As String = ""

        fecha_ini = "01/01/" & txt_Ayo.Text.Trim
        fecha_fin = ObtenerUltimoDia("01/" & uce_Mes.Value.ToString.PadLeft(2, "0") & "/" & txt_Ayo.Text.Trim)

        Try

            Me.Cursor = Cursors.WaitCursor
            clasesBG = ClasesBL.getClases()
            Dt_ctas_sobregiro = Obj_ReporteBL.getCuentas10s_sobreGiro(txt_Ayo.Text.Trim, gInt_IdEmpresa)


            pb1.Value = 0
            pb1.Minimum = 0
            pb1.Maximum = clasesBG.Count
            pb1.Visible = True

            Obj_ReporteBL.Limpiar_Tabla_Balance_Gral()

            For Each clase In clasesBG
                gruposBG = GruposBL.getGrupos_x_Clase(clase)
                For Each grupo In gruposBG
                    cuentas = grupoBgCuentasBL.getCuentas_x_Grupo(grupo, gInt_IdEmpresa, txt_Ayo.Value)
                    For Each cuentaBE In cuentas
                        Obj_ReporteBL.setImportes_Balance_Gral(clase.CBG_ID, grupo.GBG_ID, cuentaBE.PC_NUM_CUENTA, CInt(txt_Ayo.Text.Trim), uce_Mes.Value, gInt_IdEmpresa, IIf(uos_Formato.Value = 1, True, False), IIf(uchk_Cierre.Checked, 0, 1))
                    Next
                Next
                pb1.Increment(1)
            Next

            pb1.Value = 0

            Obj_ReporteBL.set_Actualiza_Importe_CajaBancos_Cero()

            Me.Refresh()

            pb1.Value = 0
            pb1.Minimum = 0
            pb1.Maximum = Dt_ctas_sobregiro.Rows.Count
            pb1.Visible = True

            For j As Integer = 0 To Dt_ctas_sobregiro.Rows.Count - 1
                Obj_ReporteBL.setActualizar_Cta10_SobreGiro(Dt_ctas_sobregiro.Rows(j)("PC_NUM_CUENTA"), txt_Ayo.Text.Trim, uce_Mes.Value, gInt_IdEmpresa, IIf(uos_Formato.Value = 1, 0, 1), IIf(uchk_Cierre.Checked, 0, 1))
                pb1.Increment(1)
            Next

            pb1.Visible = False
            pb1.Value = 0


            'actualizo el bal. gen. la cta 89 de resultado de ejercicio
            Obj_ReporteBL.set_Actualizar_Resultado_Ejercicio(txt_Ayo.Text, uce_Mes.Value, gInt_IdEmpresa, "89", IIf(uchk_Cierre.Checked, 0, 1))


            'actualiza los totales del pasivo y patrimonio
            Obj_ReporteBL.setActualizar_Importe_PasivoPatrimonio()


            'Hacemos un select a la tabla
            Dt_BalGen = Obj_ReporteBL.getBalance_Gral_1()

            Dim Str_Titulo As String = "Estado de Situacion Financiera a " & uce_Mes.Text & " " & txt_Ayo.Text.Trim
            Dim EmpresaBL As New BL.ContabilidadBL.SG_CO_TB_EMPRESA
            EmpresaBL.getEmpresas_2(EmpresaBE)


            '___________________________________________________________________________________________________





            'Dim excel As New Microsoft.Office.Interop.Excel.Application
            'Dim dsdexcel As New Microsoft.Office.Interop.Excel.Application
            'Dim wBook As Microsoft.Office.Interop.Excel.Workbook
            'Dim wSheet As Microsoft.Office.Interop.Excel.Worksheet

            Const xlEdgeLeft = 7
            Const xlEdgeRight = 10
            Const xlEdgeTop = 8
            Const xlEdgeBottom = 9
            Const xlInsideHorizontal = 12
            Const xlInsideVertical = 11
            Const xlContinuous = 1
            Const xlThin = 2

            Dim excel As Object
            Dim wBook As Object
            Dim wSheet As Object

            excel = CreateObject("Excel.Application")
            wBook = excel.Workbooks.Add
            wSheet = wBook.Worksheets(1)


            'wBook = excel.Workbooks.Add()
            'wSheet = wBook.ActiveSheet()



            wSheet.Name = "Balance General"
            wSheet.Range("A1", "A3").Font.Bold = True
            wSheet.Range("C1", "C2").Font.Bold = True

            wSheet.Range("C3", "G4").Font.Bold = True

            wSheet.Range("D8", "D35").NumberFormat = "#,##0.00"
            wSheet.Range("H8", "H35").NumberFormat = "#,##0.00"

            wSheet.Range("C3", "G3").Merge()
            wSheet.Range("C4", "G4").Merge()

            wSheet.Range("C3", "G3").HorizontalAlignment = HorizontalAlignment.Center
            wSheet.Range("C3", "G4").HorizontalAlignment = HorizontalAlignment.Center


            'excel.Cells(1, 1) = "Empresa"
            'excel.Cells(2, 1) = "Ruc"
            excel.Cells(1, 3) = EmpresaBE.EM_NOMBRE
            excel.Cells(2, 3) = "'" & EmpresaBE.EM_RUC.ToString

            'wSheet.Range("C2", "C2").HorizontalAlignment = HorizontalAlignment.Left


            excel.Cells(3, 3) = Str_Titulo
            excel.Cells(4, 3) = uos_Formato.CheckedItem.DisplayText


            With wSheet.Range("C3", "G4").Borders(xlEdgeBottom)
                .Weight = xlThin
                .LineStyle = xlContinuous
                .ColorIndex = 0
                '.TintAndShade = 0
            End With

            With wSheet.Range("C3", "G4").Borders(xlEdgeTop)
                .Weight = xlThin
                .LineStyle = xlContinuous
                .ColorIndex = 0
            End With

            wSheet.Range("C3", "G4").Interior.ColorIndex = 34
            wSheet.Range("C3", "G4").Font.ColorIndex = 0


            Dim drfilas() As DataRow
            Dim subtotal As Double = 0
            Dim total_activo As Double = 0
            Dim total_pasivo As Double = 0
            Dim cont_filas_tmp As Integer = 0


            excel.Cells(6, 3) = "A c t i v o"
            excel.Cells(7, 3) = "Activo Corriente"


            drfilas = Dt_BalGen.Select("rb_idmod = 1")
            cont_filas_tmp = 8

            For f As Integer = 0 To drfilas.Length - 1
                'excel.Cells(cont_filas_tmp + f, 2) = drfilas(f)(4)
                excel.Cells(cont_filas_tmp + f, 3) = drfilas(f)(5)
                excel.Cells(cont_filas_tmp + f, 4) = drfilas(f)(6)
                'wSheet.Cells(cont_filas_tmp + f, 4).numberformat = "#,##0.00"
            Next

            cont_filas_tmp += drfilas.Length

            'subtotal activo corriente
            subtotal = Dt_BalGen.Compute("sum(RB_IMPORTE)", "RB_IDMOD = 1")
            total_activo += subtotal
            cont_filas_tmp += 1
            excel.Cells(cont_filas_tmp, 3) = "Total Activo Corriente"
            excel.Cells(cont_filas_tmp, 4) = subtotal



            cont_filas_tmp += 2
            excel.Cells(cont_filas_tmp, 3) = "Activos No Corrientes"

            drfilas = Dt_BalGen.Select("rb_idmod = 2")
            cont_filas_tmp += 1

            For f As Integer = 0 To drfilas.Length - 1
                ' excel.Cells(cont_filas_tmp + f, 2) = drfilas(f)(4)
                excel.Cells(cont_filas_tmp + f, 3) = drfilas(f)(5)
                excel.Cells(cont_filas_tmp + f, 4) = drfilas(f)(6)
            Next

            cont_filas_tmp += drfilas.Length

            'subtotal activo NO corriente
            subtotal = Dt_BalGen.Compute("sum(RB_IMPORTE)", "RB_IDMOD = 2")
            total_activo += subtotal
            cont_filas_tmp += 1
            excel.Cells(cont_filas_tmp, 3) = "Total Activo No Corriente"
            excel.Cells(cont_filas_tmp, 4) = subtotal

            cont_filas_tmp += 1
            excel.Cells(cont_filas_tmp, 3) = "TOTAL ACTIVO "
            excel.Cells(cont_filas_tmp, 4) = total_activo


            ''P a s i v o  y  P a t r i m o n i o
            'pasivo  corriente
            excel.Cells(6, 7) = "'P a s i v o  y  P a t r i m o n i o"
            excel.Cells(7, 7) = "Pasivo Corriente"

            drfilas = Dt_BalGen.Select("rb_idmod = 3")
            cont_filas_tmp = 8

            For f As Integer = 0 To drfilas.Length - 1
                ' excel.Cells(cont_filas_tmp + f, 6) = drfilas(f)(4)
                excel.Cells(cont_filas_tmp + f, 7) = drfilas(f)(5)
                excel.Cells(cont_filas_tmp + f, 8) = drfilas(f)(6)
            Next

            cont_filas_tmp += drfilas.Length

            'subtotal pasivo corriente
            subtotal = Dt_BalGen.Compute("sum(RB_IMPORTE)", "RB_IDMOD = 3")
            total_pasivo += subtotal
            cont_filas_tmp += 1

            excel.Cells(cont_filas_tmp, 7) = "Total Pasivo Corriente"
            excel.Cells(cont_filas_tmp, 8) = subtotal





            'pasivo  No corriente 
            cont_filas_tmp += 2
            excel.Cells(cont_filas_tmp, 7) = "Pasivo No Corriente"

            drfilas = Dt_BalGen.Select("rb_idmod = 4")
            cont_filas_tmp += 1

            For f As Integer = 0 To drfilas.Length - 1
                'excel.Cells(cont_filas_tmp + f, 6) = drfilas(f)(4)
                excel.Cells(cont_filas_tmp + f, 7) = drfilas(f)(5)
                excel.Cells(cont_filas_tmp + f, 8) = drfilas(f)(6)
            Next

            cont_filas_tmp += drfilas.Length

            'subtotal pasivo No corriente
            subtotal = Dt_BalGen.Compute("sum(RB_IMPORTE)", "RB_IDMOD = 4")
            total_pasivo += subtotal
            cont_filas_tmp += 1

            excel.Cells(cont_filas_tmp, 7) = "Total Pasivo No Corriente"
            excel.Cells(cont_filas_tmp, 8) = subtotal

            cont_filas_tmp += 1

            excel.Cells(cont_filas_tmp, 7) = "TOTAL PASIVO "
            excel.Cells(cont_filas_tmp, 8) = total_pasivo


            'pasivo  No corriente
            cont_filas_tmp += 2
            excel.Cells(cont_filas_tmp, 7) = "P a t r i m o n i o   N e t o"
            cont_filas_tmp += 1
            excel.Cells(cont_filas_tmp, 7) = "Patrimonio Neto"

            drfilas = Dt_BalGen.Select("rb_idmod = 5")
            cont_filas_tmp += 1

            For f As Integer = 0 To drfilas.Length - 1
                'excel.Cells(cont_filas_tmp + f, 6) = drfilas(f)(4)
                excel.Cells(cont_filas_tmp + f, 7) = drfilas(f)(5)
                excel.Cells(cont_filas_tmp + f, 8) = drfilas(f)(6)
            Next


            cont_filas_tmp += drfilas.Length

            'subtotal pasivo No corriente
            subtotal = Dt_BalGen.Compute("sum(RB_IMPORTE)", "RB_IDMOD = 5")
            cont_filas_tmp += 1

            excel.Cells(cont_filas_tmp, 7) = "Total del Patrimonio"
            excel.Cells(cont_filas_tmp, 8) = subtotal

            cont_filas_tmp += 1
            excel.Cells(cont_filas_tmp, 7) = "Total del Pasivo y Patrimonio"
            excel.Cells(cont_filas_tmp, 8) = Dt_BalGen.Rows(0)(8)

            wSheet.Columns.AutoFit()


            'Estado de Resultado **************************************************************************************************
            Dim wSheet_Det As Object
            wSheet_Det = wBook.Sheets.Add(, wSheet)
            wSheet_Det.Name = "A1_EstadoResultado"

            excel.Cells(2, 2) = gStr_NomEmpresa
            excel.Cells(3, 2) = "Estado de Resultados Separado"
            excel.Cells(4, 2) = "Al 31 de " & uce_Mes.Text & " del " & txt_Ayo.Text
            excel.Cells(5, 2) = "Nuevos Soles"

            wSheet_Det.Range("B2", "B5").Font.Bold = True
            wSheet_Det.Range("B2", "B5").HorizontalAlignment = 3
            wSheet_Det.Range("D8", "D29").NumberFormat = "#,##0.00"



            Dim dt_data As DataTable = Obj_ReporteBL.get_Reporte_EGP(txt_Ayo.Text.Trim, uce_Mes.Value, gInt_IdEmpresa, 1)


            excel.Cells(8, 2) = "Ingresos Operacionales"
            excel.Cells(9, 2) = "Servicios prestados"
            excel.Cells(9, 4) = dt_data.Rows(0)(3)
            excel.Cells(10, 2) = "Total de Ingresos Brutos"
            excel.Cells(10, 4) = dt_data.Rows(0)(3)



            excel.Cells(12, 2) = "Costo de Servicios prestados (operacionales)"
            excel.Cells(12, 4) = dt_data.Rows(13)(3)
            excel.Cells(13, 2) = "Total costos operacionales"
            excel.Cells(13, 4) = dt_data.Rows(13)(3)
            excel.Cells(14, 2) = "Utilidad bruta"
            excel.Cells(14, 4).Formula = "=D10-D13"

            excel.Cells(16, 2) = "Otros ingresos operacionales"
            excel.Cells(16, 4) = dt_data.Rows(12)(3)

            excel.Cells(18, 2) = "Gastos Administrativos"
            excel.Cells(18, 4) = dt_data.Rows(5)(3)
            excel.Cells(19, 2) = "Otros Gastos"
            excel.Cells(20, 2) = "Utilidad Operativa"
            excel.Cells(20, 4).Formula = "=D14-D18+D16"

            excel.Cells(22, 2) = "Ingresos Financieros "
            excel.Cells(22, 4) = dt_data.Rows(10)(3)
            excel.Cells(23, 2) = "Gastos Financieros"
            excel.Cells(23, 4) = dt_data.Rows(11)(3)
            excel.Cells(24, 2) = "Resultado antes del Impuesto a la Renta"
            excel.Cells(24, 4).Formula = "=D20+D22-D23"

            excel.Cells(26, 2) = "Participación de los trabajadores 5%"
            excel.Cells(26, 4) = dt_data.Rows(19)(3)
            excel.Cells(27, 2) = "Impuesto a la Renta"
            excel.Cells(27, 4) = dt_data.Rows(20)(3)

            excel.Cells(29, 2) = "Utilidad (perdida) Neta del Ejercicio"
            excel.Cells(29, 4).Formula = "=D24-D27-D28"

            dt_data = Nothing
            wSheet_Det.Columns.AutoFit()



            'detalle de cuentas ***********************************

            wSheet_Det = wBook.Worksheets

            Dim dt_detalleBG As DataTable = Nothing

            For Each clase In clasesBG
                gruposBG = GruposBL.getGrupos_x_Clase(clase)
                For Each grupo In gruposBG
                    cuentas = grupoBgCuentasBL.getCuentas_x_Grupo(grupo, gInt_IdEmpresa, txt_Ayo.Value)
                    For Each cuentaBE In cuentas



                        If cuentaBE.PC_NUM_CUENTA = "12" Or _
                            cuentaBE.PC_NUM_CUENTA = "13" Or _
                            cuentaBE.PC_NUM_CUENTA = "41" Or _
                            cuentaBE.PC_NUM_CUENTA = "42" Or _
                            cuentaBE.PC_NUM_CUENTA = "43" Or _
                            cuentaBE.PC_NUM_CUENTA = "44" Or _
                            cuentaBE.PC_NUM_CUENTA = "46" Or _
                            cuentaBE.PC_NUM_CUENTA = "16" Or _
                            cuentaBE.PC_NUM_CUENTA = "18" Or _
                            cuentaBE.PC_NUM_CUENTA = "19" Or _
                            cuentaBE.PC_NUM_CUENTA = "25" Or _
                            cuentaBE.PC_NUM_CUENTA = "10" Or _
                            cuentaBE.PC_NUM_CUENTA = "14" Then

                            dt_detalleBG = Obj_ReporteBL.get_Balance_Gral_Detalle(clase.CBG_ID, grupo.GBG_ID, cuentaBE.PC_NUM_CUENTA, CInt(txt_Ayo.Text.Trim), uce_Mes.Value, gInt_IdEmpresa, IIf(uos_Formato.Value = 1, True, False), IIf(uchk_Cierre.Checked, 0, 1))


                            If dt_detalleBG.Rows.Count > 0 Then

                                wSheet_Det = wBook.Sheets.Add(, wSheet)
                                wSheet_Det.Name = "A" & grupo.GBG_ID & "_" & cuentaBE.PC_NUM_CUENTA

                                excel.Cells(3, 3) = "Detalle Cuenta " & cuentaBE.PC_NUM_CUENTA
                                excel.Cells(4, 3) = cuentaBE.PC_DESCRIPCION

                                excel.Cells(6, 3) = "Cuenta"
                                excel.Cells(6, 4) = "Descripcion"
                                excel.Cells(6, 5) = "Importe"

                                Dim r As Object
                                'r = excel.Range
                                r = wSheet_Det.Range("C3", "E3")
                                r.Merge()
                                r.Font.Bold = True
                                r.Font.Size = 12
                                wSheet_Det.Range("C3", "C3").HorizontalAlignment = HorizontalAlignment.Center

                                r = wSheet_Det.Range("C4", "E4")
                                r.Merge()
                                r.Font.Bold = True
                                r.Font.Size = 12
                                wSheet_Det.Range("C4", "C4").HorizontalAlignment = HorizontalAlignment.Center



                                wSheet_Det.Range("E6", "E35").NumberFormat = "#,##0.00"

                                wSheet_Det.Range("C6", "E6").Font.Bold = True
                                With wSheet_Det.Range("C6", "E6").Borders(xlEdgeBottom)
                                    .Weight = xlThin
                                    .LineStyle = xlContinuous
                                    .ColorIndex = 0
                                    '.TintAndShade = 0
                                End With

                                With wSheet_Det.Range("C6", "E6").Borders(xlEdgeTop)
                                    .Weight = xlThin
                                    .LineStyle = xlContinuous
                                    .ColorIndex = 0
                                    '.TintAndShade = 0
                                End With


                                wSheet_Det.Range("C6", "E6").Interior.ColorIndex = 34
                                wSheet_Det.Range("C6", "E6").Font.ColorIndex = 0

                                'For i As Integer = 13 To 50
                                '    wSheet_Det.Range("C" & i.ToString, "C" & i.ToString).Interior.ColorIndex = (i - 8)
                                'Next
                                Dim dt_det_anexo As DataTable = Nothing
                                Dim fil As Integer = 7
                                Dim i_tmp As Integer = 7

                                cont_filas_tmp = 7

                                For f As Integer = 0 To dt_detalleBG.Rows.Count - 1
                                    excel.Cells(cont_filas_tmp + f, 3) = dt_detalleBG.Rows(f)(0)
                                    excel.Cells(cont_filas_tmp + f, 4) = dt_detalleBG.Rows(f)(1)
                                    excel.Cells(cont_filas_tmp + f, 5) = dt_detalleBG.Rows(f)(2)
                                Next

                                cont_filas_tmp += dt_detalleBG.Rows.Count

                                cont_filas_tmp += 2

                                excel.Cells(cont_filas_tmp, 4) = "Saldo"
                                excel.Cells(cont_filas_tmp, 5) = dt_detalleBG.Compute("sum(saldo)", "")
                                cont_filas_tmp += 2


                                excel.Cells(cont_filas_tmp, 4) = "Detalle de Saldo"

                                cont_filas_tmp += 1


                                Dim str_ctacont_ini As String = ""
                                Dim str_ctacont_fin As String = ""
                                Dim tot_d As Double = 0
                                Dim tot_h As Double = 0

                                If cuentaBE.PC_NUM_CUENTA = "12" Or _
                                    cuentaBE.PC_NUM_CUENTA = "13" Or _
                                    cuentaBE.PC_NUM_CUENTA = "42" Or _
                                    cuentaBE.PC_NUM_CUENTA = "43" Or _
                                    cuentaBE.PC_NUM_CUENTA = "44" Or _
                                    cuentaBE.PC_NUM_CUENTA = "46" Or _
                                    cuentaBE.PC_NUM_CUENTA = "16" Or _
                                    cuentaBE.PC_NUM_CUENTA = "18" Or _
                                    cuentaBE.PC_NUM_CUENTA = "14" Then

                                    Select Case cuentaBE.PC_NUM_CUENTA
                                        Case "12"
                                            str_ctacont_ini = "121201"
                                            str_ctacont_fin = "122001"

                                        Case "13"
                                            str_ctacont_ini = "131251"
                                            str_ctacont_fin = "131251"

                                        Case "14"
                                            str_ctacont_ini = "141101"
                                            str_ctacont_fin = "141902"

                                        Case "16"
                                            str_ctacont_ini = "162901"
                                            str_ctacont_fin = "162901"

                                        Case "18"
                                            str_ctacont_ini = "189001"
                                            str_ctacont_fin = "189001"

                                        Case "42"
                                            str_ctacont_ini = "421101"
                                            str_ctacont_fin = "424001"

                                        Case "43"
                                            str_ctacont_ini = "431151"
                                            str_ctacont_fin = "431251"

                                        Case "44"
                                            str_ctacont_ini = "441101"
                                            str_ctacont_fin = "441101"

                                        Case "46"
                                            str_ctacont_ini = "469901"
                                            str_ctacont_fin = "469901"
                                        Case Else

                                            str_ctacont_ini = ""
                                            str_ctacont_fin = ""
                                    End Select


                                    dt_det_anexo = Obj_ReporteBL.get_Balance_Gral_Detalle_xAnexo(fecha_ini, fecha_fin, str_ctacont_ini, str_ctacont_fin, CInt(txt_Ayo.Text), gInt_IdEmpresa, IIf(uchk_Cierre.Checked, 0, 1))


                                    tot_d = 0
                                    tot_h = 0

                                    If dt_det_anexo.Rows.Count > 0 Then
                                        tot_d = dt_det_anexo.Compute("sum(ad_debe)", "")
                                        tot_h = dt_det_anexo.Compute("sum(ad_haber)", "")
                                    End If



                                    If tot_d - tot_h <> 0 Then

                                        i_tmp = cont_filas_tmp
                                        For d As Integer = 0 To dt_det_anexo.Rows.Count - 1
                                            i_tmp = i_tmp + 1

                                            excel.Cells(i_tmp, 4) = dt_det_anexo.Rows(d)(0) & " - " & dt_det_anexo.Rows(d)(1) ' & " - " & dt_det_anexo.Rows(d)(4) & " " & dt_det_anexo.Rows(d)(5) & " " & dt_det_anexo.Rows(d)(6)

                                            If dt_det_anexo.Rows(d)(2) > 0 Then
                                                excel.Cells(i_tmp, 5) = dt_det_anexo.Rows(d)(2)
                                            Else
                                                excel.Cells(i_tmp, 5) = dt_det_anexo.Rows(d)(3) * (-1)
                                            End If

                                        Next 'detalle anexo

                                        cont_filas_tmp = cont_filas_tmp + i_tmp


                                    End If ' de diferencia


                                End If 'es cta anexo / if de cuenta anexos

                                wSheet_Det.Columns.AutoFit()


                            End If

                        End If


                    Next
                Next
            Next

            'cuenta 33 *******************************************************************

            Dim ds_detalle_cta33 As DataSet = Obj_ReporteBL.get_Balance_Gral_Detalle_cta33(CInt(txt_Ayo.Text.Trim), uce_Mes.Value, gInt_IdEmpresa, IIf(uos_Formato.Value = 1, True, False), IIf(uchk_Cierre.Checked, 0, 2))

            If ds_detalle_cta33.Tables(0).Rows.Count > 0 Then

                wSheet_Det = wBook.Sheets.Add(, wSheet)
                wSheet_Det.Name = "A1_33"

                excel.Cells(3, 3) = "Detalle Cuenta 33"
                excel.Cells(4, 3) = "INMUEBLES MAQUINARIA Y EQUIPO"

                excel.Cells(6, 3) = "Cuenta"
                excel.Cells(6, 4) = "Descripcion"
                excel.Cells(6, 5) = "Importe"

                Dim r As Object
                'r = excel.Range
                r = wSheet_Det.Range("C3", "E3")
                r.Merge()
                r.Font.Bold = True
                r.Font.Size = 12
                wSheet_Det.Range("C3", "C3").HorizontalAlignment = HorizontalAlignment.Center

                r = wSheet_Det.Range("C4", "E4")
                r.Merge()
                r.Font.Bold = True
                r.Font.Size = 12
                wSheet_Det.Range("C4", "C4").HorizontalAlignment = HorizontalAlignment.Center



                wSheet_Det.Range("E6", "E35").NumberFormat = "#,##0.00"

                wSheet_Det.Range("C6", "E6").Font.Bold = True
                With wSheet_Det.Range("C6", "E6").Borders(xlEdgeBottom)
                    .Weight = xlThin
                    .LineStyle = xlContinuous
                    .ColorIndex = 0
                    '.TintAndShade = 0
                End With

                With wSheet_Det.Range("C6", "E6").Borders(xlEdgeTop)
                    .Weight = xlThin
                    .LineStyle = xlContinuous
                    .ColorIndex = 0
                    '.TintAndShade = 0
                End With


                wSheet_Det.Range("C6", "E6").Interior.ColorIndex = 34
                wSheet_Det.Range("C6", "E6").Font.ColorIndex = 0

                'For i As Integer = 13 To 50
                '    wSheet_Det.Range("C" & i.ToString, "C" & i.ToString).Interior.ColorIndex = (i - 8)
                'Next
                Dim dt_det_anexo As DataTable = Nothing
                Dim fil As Integer = 7
                Dim i_tmp As Integer = 7

                cont_filas_tmp = 7

                For f As Integer = 0 To ds_detalle_cta33.Tables(0).Rows.Count - 1
                    excel.Cells(cont_filas_tmp + f, 3) = ds_detalle_cta33.Tables(0).Rows(f)(0)
                    excel.Cells(cont_filas_tmp + f, 4) = ds_detalle_cta33.Tables(0).Rows(f)(1)
                    excel.Cells(cont_filas_tmp + f, 5) = ds_detalle_cta33.Tables(0).Rows(f)(2)
                Next

                cont_filas_tmp += ds_detalle_cta33.Tables(0).Rows.Count

                cont_filas_tmp += 2

                excel.Cells(cont_filas_tmp, 4) = "Saldo"
                excel.Cells(cont_filas_tmp, 5) = ds_detalle_cta33.Tables(0).Compute("sum(saldo)", "")
                cont_filas_tmp += 3



                'parte 2 de abajo de la 33

                For f As Integer = 0 To ds_detalle_cta33.Tables(1).Rows.Count - 1
                    excel.Cells(cont_filas_tmp + f, 3) = ds_detalle_cta33.Tables(1).Rows(f)(0)
                    excel.Cells(cont_filas_tmp + f, 4) = ds_detalle_cta33.Tables(1).Rows(f)(1)
                    excel.Cells(cont_filas_tmp + f, 5) = ds_detalle_cta33.Tables(1).Rows(f)(2)
                Next

                cont_filas_tmp += ds_detalle_cta33.Tables(1).Rows.Count

                cont_filas_tmp += 2

                excel.Cells(cont_filas_tmp, 4) = "Saldo"
                excel.Cells(cont_filas_tmp, 5) = ds_detalle_cta33.Tables(1).Compute("sum(saldo)", "")
                cont_filas_tmp += 2


                wBook.Worksheets(1).Cells(24, 3) = "INMUEBLES MAQUINARIA Y EQUIPO(Neto)"
                wBook.Worksheets(1).Cells(24, 4) = ds_detalle_cta33.Tables(0).Compute("sum(saldo)", "")
                wBook.Worksheets(1).Cells(25, 3) = "INTANGIBLES(Neto)"
                wBook.Worksheets(1).Cells(25, 4) = ds_detalle_cta33.Tables(1).Compute("sum(saldo)", "")

                wBook.Worksheets(1).Cells(26, 3) = ""
                wBook.Worksheets(1).Cells(27, 3) = ""
                wBook.Worksheets(1).Cells(28, 3) = ""
                wBook.Worksheets(1).Cells(29, 3) = ""
                wBook.Worksheets(1).Cells(30, 3) = ""

                wBook.Worksheets(1).Cells(26, 4) = ""
                wBook.Worksheets(1).Cells(27, 4) = ""
                wBook.Worksheets(1).Cells(28, 4) = ""
                wBook.Worksheets(1).Cells(29, 4) = ""
                wBook.Worksheets(1).Cells(30, 4) = ""

                wBook.Worksheets(1).Cells(26, 2) = ""
                wBook.Worksheets(1).Cells(27, 2) = ""
                wBook.Worksheets(1).Cells(28, 2) = ""
                wBook.Worksheets(1).Cells(29, 2) = ""
                wBook.Worksheets(1).Cells(30, 2) = ""



            End If

            '*****************fin cuenta 33



            'cuenta 40 *******************************************************************

            Dim ds_detalle_cta40 As DataSet = Obj_ReporteBL.get_Balance_Gral_Detalle_cta40(CInt(txt_Ayo.Text.Trim), uce_Mes.Value, gInt_IdEmpresa, IIf(uos_Formato.Value = 1, True, False), IIf(uchk_Cierre.Checked, 0, 2))

            If ds_detalle_cta40.Tables(0).Rows.Count > 0 Then

                wSheet_Det = wBook.Sheets.Add(, wSheet)
                wSheet_Det.Name = "A1_40"

                excel.Cells(3, 3) = "Detalle Cuenta 40"
                excel.Cells(4, 3) = "TRIBUTOS CONTRAPRESTACIONES Y APORTES AL SISTEMA"

                excel.Cells(6, 3) = "Cuenta"
                excel.Cells(6, 4) = "Descripcion"
                excel.Cells(6, 5) = "Importe"

                Dim r As Object
                'r = excel.Range
                r = wSheet_Det.Range("C3", "E3")
                r.Merge()
                r.Font.Bold = True
                r.Font.Size = 12
                wSheet_Det.Range("C3", "C3").HorizontalAlignment = HorizontalAlignment.Center

                r = wSheet_Det.Range("C4", "E4")
                r.Merge()
                r.Font.Bold = True
                r.Font.Size = 12
                wSheet_Det.Range("C4", "C4").HorizontalAlignment = HorizontalAlignment.Center



                wSheet_Det.Range("E6", "E35").NumberFormat = "#,##0.00"

                wSheet_Det.Range("C6", "E6").Font.Bold = True
                With wSheet_Det.Range("C6", "E6").Borders(xlEdgeBottom)
                    .Weight = xlThin
                    .LineStyle = xlContinuous
                    .ColorIndex = 0
                    '.TintAndShade = 0
                End With

                With wSheet_Det.Range("C6", "E6").Borders(xlEdgeTop)
                    .Weight = xlThin
                    .LineStyle = xlContinuous
                    .ColorIndex = 0
                    '.TintAndShade = 0
                End With


                wSheet_Det.Range("C6", "E6").Interior.ColorIndex = 34
                wSheet_Det.Range("C6", "E6").Font.ColorIndex = 0

                'For i As Integer = 13 To 50
                '    wSheet_Det.Range("C" & i.ToString, "C" & i.ToString).Interior.ColorIndex = (i - 8)
                'Next
                Dim dt_det_anexo As DataTable = Nothing
                Dim fil As Integer = 7
                Dim i_tmp As Integer = 7

                cont_filas_tmp = 7

                For f As Integer = 0 To ds_detalle_cta40.Tables(0).Rows.Count - 1
                    excel.Cells(cont_filas_tmp + f, 3) = ds_detalle_cta40.Tables(0).Rows(f)(0)
                    excel.Cells(cont_filas_tmp + f, 4) = ds_detalle_cta40.Tables(0).Rows(f)(1)
                    excel.Cells(cont_filas_tmp + f, 5) = ds_detalle_cta40.Tables(0).Rows(f)(2)
                Next

                cont_filas_tmp += ds_detalle_cta40.Tables(0).Rows.Count

                cont_filas_tmp += 2

                excel.Cells(cont_filas_tmp, 4) = "Saldo"
                excel.Cells(cont_filas_tmp, 5) = ds_detalle_cta40.Tables(0).Compute("sum(saldo)", "")
                cont_filas_tmp += 3



                'parte 2 de abajo de la 40

                For f As Integer = 0 To ds_detalle_cta40.Tables(1).Rows.Count - 1
                    excel.Cells(cont_filas_tmp + f, 3) = ds_detalle_cta40.Tables(1).Rows(f)(0)
                    excel.Cells(cont_filas_tmp + f, 4) = ds_detalle_cta40.Tables(1).Rows(f)(1)
                    excel.Cells(cont_filas_tmp + f, 5) = ds_detalle_cta40.Tables(1).Rows(f)(2)
                Next

                cont_filas_tmp += ds_detalle_cta40.Tables(1).Rows.Count

                cont_filas_tmp += 2

                excel.Cells(cont_filas_tmp, 4) = "Saldo"
                excel.Cells(cont_filas_tmp, 5) = ds_detalle_cta40.Tables(1).Compute("sum(saldo)", "")
                cont_filas_tmp += 2

                wBook.Worksheets(1).Cells(20, 3) = "OTROS ACTIVOS"
                wBook.Worksheets(1).Cells(20, 4) = Math.Abs(ds_detalle_cta40.Tables(1).Compute("sum(saldo)", ""))

                wBook.Worksheets(1).Cells(8, 8) = ds_detalle_cta40.Tables(0).Compute("sum(saldo)", "")
            End If

            '*****************fin cuenta 40





            'balance comprobacion *****************************************
            Dim monto70 As Double = 0
            Dim monto75 As Double = 0
            Dim monto_costo_servicios As Double = 0

            Dim Dt_BalCom As DataTable = Obj_ReporteBL.getBalance_Comprobacion_1(txt_Ayo.Text, uce_Mes.Value, gInt_IdEmpresa, "70", "7099999", True, 1, 2)
            Dim wSheet_bc As Object
            'wSheet_bc = wBook.Worksheet

            Dim saldo_d As Double = 0
            Dim saldo_h As Double = 0
            Dim fechas As String = "01/" & uce_Mes.Value.ToString.PadLeft(2, "0") & "/" & txt_Ayo.Text

            wSheet_bc = wBook.Sheets.Add(, wSheet)
            wSheet_bc.Name = "Balance de Comprobacion"
            excel.Cells(2, 4) = "Clinica Miraflores"
            excel.Cells(3, 4) = "Balance de Comprobacion"
            excel.Cells(4, 4) = "AL " & CDate(ObtenerUltimoDia(fechas)).Day & " DE " & uce_Mes.Text & " DEL " & txt_Ayo.Text


            cont_filas_tmp = 7

            For f As Integer = 0 To Dt_BalCom.Rows.Count - 1

                If f = 0 Then
                    saldo_d = Dt_BalCom.Compute("sum(debe)", "len(cuenta)<>2")
                    saldo_h = Dt_BalCom.Compute("sum(haber)", "len(cuenta)<>2")
                    monto70 = Math.Abs(saldo_d - saldo_h)
                    excel.Cells(cont_filas_tmp + f, 8) = monto70
                End If

                excel.Cells(cont_filas_tmp + f, 3) = Dt_BalCom.Rows(f)(0) 'cuenta
                excel.Cells(cont_filas_tmp + f, 4) = Dt_BalCom.Rows(f)(1) 'descripcion
                excel.Cells(cont_filas_tmp + f, 5) = Dt_BalCom.Rows(f)(2) 'saldo debe
                excel.Cells(cont_filas_tmp + f, 6) = Dt_BalCom.Rows(f)(3) 'saldo haber
            Next

            cont_filas_tmp += Dt_BalCom.Rows.Count + 2


            Dt_BalCom = Obj_ReporteBL.getBalance_Comprobacion_1(txt_Ayo.Text, uce_Mes.Value, gInt_IdEmpresa, "75", "7599999", True, 1, 2)

            For f As Integer = 0 To Dt_BalCom.Rows.Count - 1

                If f = 0 Then
                    saldo_d = Dt_BalCom.Compute("sum(debe)", "len(cuenta)<>2")
                    saldo_h = Dt_BalCom.Compute("sum(haber)", "len(cuenta)<>2")
                    monto75 = Math.Abs(saldo_d - saldo_h)
                    excel.Cells(cont_filas_tmp + f, 8) = monto75
                End If

                excel.Cells(cont_filas_tmp + f, 3) = Dt_BalCom.Rows(f)(0) 'cuenta
                excel.Cells(cont_filas_tmp + f, 4) = Dt_BalCom.Rows(f)(1) 'descripcion
                excel.Cells(cont_filas_tmp + f, 5) = Dt_BalCom.Rows(f)(4) 'saldo debe
                excel.Cells(cont_filas_tmp + f, 6) = Dt_BalCom.Rows(f)(5) 'saldo haber
            Next

            cont_filas_tmp += Dt_BalCom.Rows.Count + 2

            excel.Cells(cont_filas_tmp, 4) = "TOTAL DE INGRESOS BRUTOS"
            excel.Cells(cont_filas_tmp, 8) = monto70 + monto75

            cont_filas_tmp += 2

            excel.Cells(cont_filas_tmp, 4) = "COSTO DE LOS SERVICIOS PRESTADOS OPERACIONALES"
            excel.Cells(cont_filas_tmp, 8) = 0

            cont_filas_tmp += 2



            Dt_BalCom = Obj_ReporteBL.getBalance_Comprobacion_1(txt_Ayo.Text, uce_Mes.Value, gInt_IdEmpresa, "90", "9099999", True, 1, 2)

            For f As Integer = 0 To Dt_BalCom.Rows.Count - 1

                If f = 0 Then
                    saldo_d = Dt_BalCom.Compute("sum(debe)", "len(cuenta)<>2")
                    saldo_h = Dt_BalCom.Compute("sum(haber)", "len(cuenta)<>2")
                    monto_costo_servicios += Math.Abs(saldo_d - saldo_h)
                    excel.Cells(cont_filas_tmp + f, 8) = Math.Abs(saldo_d - saldo_h)
                End If

                excel.Cells(cont_filas_tmp + f, 3) = Dt_BalCom.Rows(f)(0) 'cuenta
                excel.Cells(cont_filas_tmp + f, 4) = Dt_BalCom.Rows(f)(1) 'descripcion
                excel.Cells(cont_filas_tmp + f, 5) = Dt_BalCom.Rows(f)(4) 'saldo debe
                excel.Cells(cont_filas_tmp + f, 6) = Dt_BalCom.Rows(f)(5) 'saldo haber
            Next

            cont_filas_tmp += Dt_BalCom.Rows.Count + 2


            Dt_BalCom = Obj_ReporteBL.getBalance_Comprobacion_1(txt_Ayo.Text, uce_Mes.Value, gInt_IdEmpresa, "91", "9199999", True, 1, 2)

            For f As Integer = 0 To Dt_BalCom.Rows.Count - 1

                If f = 0 Then
                    saldo_d = Dt_BalCom.Compute("sum(debe)", "len(cuenta)<>2")
                    saldo_h = Dt_BalCom.Compute("sum(haber)", "len(cuenta)<>2")
                    monto_costo_servicios += Math.Abs(saldo_d - saldo_h)
                    excel.Cells(cont_filas_tmp + f, 8) = Math.Abs(saldo_d - saldo_h)
                End If

                excel.Cells(cont_filas_tmp + f, 3) = Dt_BalCom.Rows(f)(0) 'cuenta
                excel.Cells(cont_filas_tmp + f, 4) = Dt_BalCom.Rows(f)(1) 'descripcion
                excel.Cells(cont_filas_tmp + f, 5) = Dt_BalCom.Rows(f)(4) 'saldo debe
                excel.Cells(cont_filas_tmp + f, 6) = Dt_BalCom.Rows(f)(5) 'saldo haber
            Next


            cont_filas_tmp += Dt_BalCom.Rows.Count + 2


            Dt_BalCom = Obj_ReporteBL.getBalance_Comprobacion_1(txt_Ayo.Text, uce_Mes.Value, gInt_IdEmpresa, "92", "9299999", True, 1, 2)

            For f As Integer = 0 To Dt_BalCom.Rows.Count - 1

                If f = 0 Then
                    saldo_d = Dt_BalCom.Compute("sum(debe)", "len(cuenta)<>2")
                    saldo_h = Dt_BalCom.Compute("sum(haber)", "len(cuenta)<>2")
                    monto_costo_servicios += Math.Abs(saldo_d - saldo_h)
                    excel.Cells(cont_filas_tmp + f, 8) = Math.Abs(saldo_d - saldo_h)
                End If

                excel.Cells(cont_filas_tmp + f, 3) = Dt_BalCom.Rows(f)(0) 'cuenta
                excel.Cells(cont_filas_tmp + f, 4) = Dt_BalCom.Rows(f)(1) 'descripcion
                excel.Cells(cont_filas_tmp + f, 5) = Dt_BalCom.Rows(f)(4) 'saldo debe
                excel.Cells(cont_filas_tmp + f, 6) = Dt_BalCom.Rows(f)(5) 'saldo haber
            Next



            cont_filas_tmp += Dt_BalCom.Rows.Count + 2


            Dt_BalCom = Obj_ReporteBL.getBalance_Comprobacion_1(txt_Ayo.Text, uce_Mes.Value, gInt_IdEmpresa, "93", "9399999", True, 1, 2)

            For f As Integer = 0 To Dt_BalCom.Rows.Count - 1

                If f = 0 Then
                    saldo_d = Dt_BalCom.Compute("sum(debe)", "len(cuenta)<>2")
                    saldo_h = Dt_BalCom.Compute("sum(haber)", "len(cuenta)<>2")
                    monto_costo_servicios += Math.Abs(saldo_d - saldo_h)
                    excel.Cells(cont_filas_tmp + f, 8) = Math.Abs(saldo_d - saldo_h)
                End If

                excel.Cells(cont_filas_tmp + f, 3) = Dt_BalCom.Rows(f)(0) 'cuenta
                excel.Cells(cont_filas_tmp + f, 4) = Dt_BalCom.Rows(f)(1) 'descripcion
                excel.Cells(cont_filas_tmp + f, 5) = Dt_BalCom.Rows(f)(4) 'saldo debe
                excel.Cells(cont_filas_tmp + f, 6) = Dt_BalCom.Rows(f)(5) 'saldo haber
            Next



            cont_filas_tmp += Dt_BalCom.Rows.Count + 2


            Dt_BalCom = Obj_ReporteBL.getBalance_Comprobacion_1(txt_Ayo.Text, uce_Mes.Value, gInt_IdEmpresa, "94", "9499999", True, 1, 2)

            For f As Integer = 0 To Dt_BalCom.Rows.Count - 1

                If f = 0 Then
                    saldo_d = Dt_BalCom.Compute("sum(debe)", "len(cuenta)<>2")
                    saldo_h = Dt_BalCom.Compute("sum(haber)", "len(cuenta)<>2")
                    monto_costo_servicios += Math.Abs(saldo_d - saldo_h)
                    excel.Cells(cont_filas_tmp + f, 8) = Math.Abs(saldo_d - saldo_h)
                End If

                excel.Cells(cont_filas_tmp + f, 3) = Dt_BalCom.Rows(f)(0) 'cuenta
                excel.Cells(cont_filas_tmp + f, 4) = Dt_BalCom.Rows(f)(1) 'descripcion
                excel.Cells(cont_filas_tmp + f, 5) = Dt_BalCom.Rows(f)(4) 'saldo debe
                excel.Cells(cont_filas_tmp + f, 6) = Dt_BalCom.Rows(f)(5) 'saldo haber
            Next



            cont_filas_tmp += Dt_BalCom.Rows.Count + 2


            Dt_BalCom = Obj_ReporteBL.getBalance_Comprobacion_1(txt_Ayo.Text, uce_Mes.Value, gInt_IdEmpresa, "95", "9599999", True, 1, 2)

            For f As Integer = 0 To Dt_BalCom.Rows.Count - 1

                If f = 0 Then
                    saldo_d = Dt_BalCom.Compute("sum(debe)", "len(cuenta)<>2")
                    saldo_h = Dt_BalCom.Compute("sum(haber)", "len(cuenta)<>2")
                    monto_costo_servicios += Math.Abs(saldo_d - saldo_h)
                    excel.Cells(cont_filas_tmp + f, 8) = Math.Abs(saldo_d - saldo_h)
                End If

                excel.Cells(cont_filas_tmp + f, 3) = Dt_BalCom.Rows(f)(0) 'cuenta
                excel.Cells(cont_filas_tmp + f, 4) = Dt_BalCom.Rows(f)(1) 'descripcion
                excel.Cells(cont_filas_tmp + f, 5) = Dt_BalCom.Rows(f)(4) 'saldo debe
                excel.Cells(cont_filas_tmp + f, 6) = Dt_BalCom.Rows(f)(5) 'saldo haber
            Next


            cont_filas_tmp += Dt_BalCom.Rows.Count + 2


            Dt_BalCom = Obj_ReporteBL.getBalance_Comprobacion_1(txt_Ayo.Text, uce_Mes.Value, gInt_IdEmpresa, "96", "9699999", True, 1, 2)

            For f As Integer = 0 To Dt_BalCom.Rows.Count - 1

                If f = 0 Then
                    saldo_d = Dt_BalCom.Compute("sum(debe)", "len(cuenta)<>2")
                    saldo_h = Dt_BalCom.Compute("sum(haber)", "len(cuenta)<>2")
                    monto_costo_servicios += Math.Abs(saldo_d - saldo_h)
                    excel.Cells(cont_filas_tmp + f, 8) = Math.Abs(saldo_d - saldo_h)
                End If

                excel.Cells(cont_filas_tmp + f, 3) = Dt_BalCom.Rows(f)(0) 'cuenta
                excel.Cells(cont_filas_tmp + f, 4) = Dt_BalCom.Rows(f)(1) 'descripcion
                excel.Cells(cont_filas_tmp + f, 5) = Dt_BalCom.Rows(f)(4) 'saldo debe
                excel.Cells(cont_filas_tmp + f, 6) = Dt_BalCom.Rows(f)(5) 'saldo haber
            Next



            cont_filas_tmp += Dt_BalCom.Rows.Count + 2


            Dt_BalCom = Obj_ReporteBL.getBalance_Comprobacion_1(txt_Ayo.Text, uce_Mes.Value, gInt_IdEmpresa, "97", "9799999", True, 1, 2)

            For f As Integer = 0 To Dt_BalCom.Rows.Count - 1

                If f = 0 Then
                    saldo_d = Dt_BalCom.Compute("sum(debe)", "len(cuenta)<>2")
                    saldo_h = Dt_BalCom.Compute("sum(haber)", "len(cuenta)<>2")
                    monto_costo_servicios += Math.Abs(saldo_d - saldo_h)
                    excel.Cells(cont_filas_tmp + f, 8) = Math.Abs(saldo_d - saldo_h)
                End If

                excel.Cells(cont_filas_tmp + f, 3) = Dt_BalCom.Rows(f)(0) 'cuenta
                excel.Cells(cont_filas_tmp + f, 4) = Dt_BalCom.Rows(f)(1) 'descripcion
                excel.Cells(cont_filas_tmp + f, 5) = Dt_BalCom.Rows(f)(4) 'saldo debe
                excel.Cells(cont_filas_tmp + f, 6) = Dt_BalCom.Rows(f)(5) 'saldo haber
            Next


            cont_filas_tmp += Dt_BalCom.Rows.Count + 2


            Dt_BalCom = Obj_ReporteBL.getBalance_Comprobacion_1(txt_Ayo.Text, uce_Mes.Value, gInt_IdEmpresa, "99", "9999999", True, 1, 2)

            For f As Integer = 0 To Dt_BalCom.Rows.Count - 1

                If f = 0 Then
                    saldo_d = Dt_BalCom.Compute("sum(debe)", "len(cuenta)<>2")
                    saldo_h = Dt_BalCom.Compute("sum(haber)", "len(cuenta)<>2")
                    monto_costo_servicios += Math.Abs(saldo_d - saldo_h)
                    excel.Cells(cont_filas_tmp + f, 8) = Math.Abs(saldo_d - saldo_h)
                End If

                excel.Cells(cont_filas_tmp + f, 3) = Dt_BalCom.Rows(f)(0) 'cuenta
                excel.Cells(cont_filas_tmp + f, 4) = Dt_BalCom.Rows(f)(1) 'descripcion
                excel.Cells(cont_filas_tmp + f, 5) = Dt_BalCom.Rows(f)(4) 'saldo debe
                excel.Cells(cont_filas_tmp + f, 6) = Dt_BalCom.Rows(f)(5) 'saldo haber
            Next

            cont_filas_tmp += Dt_BalCom.Rows.Count + 2

            excel.Cells(cont_filas_tmp, 4) = "(-) CONSUMOS"

            cont_filas_tmp += 2




            Dt_BalCom = Obj_ReporteBL.getBalance_Comprobacion_1(txt_Ayo.Text, uce_Mes.Value, gInt_IdEmpresa, "69", "694108", True, 1, 2)

            For f As Integer = 0 To Dt_BalCom.Rows.Count - 1

                If f = 0 Then
                    saldo_d = Dt_BalCom.Compute("sum(debe)", "len(cuenta)<>2")
                    saldo_h = Dt_BalCom.Compute("sum(haber)", "len(cuenta)<>2")
                    monto_costo_servicios += Math.Abs(saldo_d - saldo_h)
                    excel.Cells(cont_filas_tmp + f, 8) = Math.Abs(saldo_d - saldo_h)
                End If

                excel.Cells(cont_filas_tmp + f, 3) = Dt_BalCom.Rows(f)(0) 'cuenta
                excel.Cells(cont_filas_tmp + f, 4) = Dt_BalCom.Rows(f)(1) 'descripcion
                excel.Cells(cont_filas_tmp + f, 5) = Dt_BalCom.Rows(f)(4) 'saldo debe
                excel.Cells(cont_filas_tmp + f, 6) = Dt_BalCom.Rows(f)(5) 'saldo haber
            Next

            cont_filas_tmp += Dt_BalCom.Rows.Count + 2


            excel.Cells(cont_filas_tmp, 4) = "GASTOS ADMINISTRATIVOS"

            cont_filas_tmp += 2


            wSheet_bc.Range("G54").Value = monto_costo_servicios


            Dt_BalCom = Obj_ReporteBL.getBalance_Comprobacion_1(txt_Ayo.Text, uce_Mes.Value, gInt_IdEmpresa, "694109", "69999", False, 1, 2)

            For f As Integer = 0 To Dt_BalCom.Rows.Count - 1

                If f = 0 Then
                    saldo_d = Dt_BalCom.Compute("sum(debe)", "len(cuenta)<>2")
                    saldo_h = Dt_BalCom.Compute("sum(haber)", "len(cuenta)<>2")
                    excel.Cells(cont_filas_tmp + f, 8) = Math.Abs(saldo_d - saldo_h)
                End If

                excel.Cells(cont_filas_tmp + f, 3) = Dt_BalCom.Rows(f)(0) 'cuenta
                excel.Cells(cont_filas_tmp + f, 4) = Dt_BalCom.Rows(f)(1) 'descripcion
                excel.Cells(cont_filas_tmp + f, 5) = Dt_BalCom.Rows(f)(4) 'saldo debe
                excel.Cells(cont_filas_tmp + f, 6) = Dt_BalCom.Rows(f)(5) 'saldo haber
            Next

            cont_filas_tmp += Dt_BalCom.Rows.Count + 2


            Dt_BalCom = Obj_ReporteBL.getBalance_Comprobacion_1(txt_Ayo.Text, uce_Mes.Value, gInt_IdEmpresa, "98", "989999", True, 1, 2)

            For f As Integer = 0 To Dt_BalCom.Rows.Count - 1

                If f = 0 Then
                    saldo_d = Dt_BalCom.Compute("sum(debe)", "len(cuenta)<>2")
                    saldo_h = Dt_BalCom.Compute("sum(haber)", "len(cuenta)<>2")
                    excel.Cells(cont_filas_tmp + f, 8) = Math.Abs(saldo_d - saldo_h)
                End If

                excel.Cells(cont_filas_tmp + f, 3) = Dt_BalCom.Rows(f)(0) 'cuenta
                excel.Cells(cont_filas_tmp + f, 4) = Dt_BalCom.Rows(f)(1) 'descripcion
                excel.Cells(cont_filas_tmp + f, 5) = Dt_BalCom.Rows(f)(4) 'saldo debe
                excel.Cells(cont_filas_tmp + f, 6) = Dt_BalCom.Rows(f)(5) 'saldo haber
            Next

            cont_filas_tmp += Dt_BalCom.Rows.Count + 2



            Dt_BalCom = Obj_ReporteBL.getBalance_Comprobacion_1(txt_Ayo.Text, uce_Mes.Value, gInt_IdEmpresa, "77", "779999", True, 1, 2)

            For f As Integer = 0 To Dt_BalCom.Rows.Count - 1

                If f = 0 Then
                    saldo_d = Dt_BalCom.Compute("sum(debe)", "len(cuenta)<>2")
                    saldo_h = Dt_BalCom.Compute("sum(haber)", "len(cuenta)<>2")
                    excel.Cells(cont_filas_tmp + f, 8) = Math.Abs(saldo_d - saldo_h)
                End If

                excel.Cells(cont_filas_tmp + f, 3) = Dt_BalCom.Rows(f)(0) 'cuenta
                excel.Cells(cont_filas_tmp + f, 4) = Dt_BalCom.Rows(f)(1) 'descripcion
                excel.Cells(cont_filas_tmp + f, 5) = Dt_BalCom.Rows(f)(4) 'saldo debe
                excel.Cells(cont_filas_tmp + f, 6) = Dt_BalCom.Rows(f)(5) 'saldo haber
            Next

            cont_filas_tmp += Dt_BalCom.Rows.Count + 2



            Dt_BalCom = Obj_ReporteBL.getBalance_Comprobacion_1(txt_Ayo.Text, uce_Mes.Value, gInt_IdEmpresa, "67", "679999", True, 1, 2)

            For f As Integer = 0 To Dt_BalCom.Rows.Count - 1

                If f = 0 Then
                    saldo_d = Dt_BalCom.Compute("sum(debe)", "len(cuenta)<>2")
                    saldo_h = Dt_BalCom.Compute("sum(haber)", "len(cuenta)<>2")
                    excel.Cells(cont_filas_tmp + f, 8) = Math.Abs(saldo_d - saldo_h)
                End If

                excel.Cells(cont_filas_tmp + f, 3) = Dt_BalCom.Rows(f)(0) 'cuenta
                excel.Cells(cont_filas_tmp + f, 4) = Dt_BalCom.Rows(f)(1) 'descripcion
                excel.Cells(cont_filas_tmp + f, 5) = Dt_BalCom.Rows(f)(4) 'saldo debe
                excel.Cells(cont_filas_tmp + f, 6) = Dt_BalCom.Rows(f)(5) 'saldo haber
            Next

            cont_filas_tmp += Dt_BalCom.Rows.Count + 2

            'sumatorias
            wBook.Worksheets(1).Cells(21, 4).Formula = "=SUMA(D8:D20)"
            wBook.Worksheets(1).Cells(32, 4).Formula = "=SUMA(D24:D31)"
            wBook.Worksheets(1).Cells(33, 4).Formula = "=D21+D32"

            wBook.Worksheets(1).Cells(16, 8).Formula = "=SUMA(H8:H15)"
            wBook.Worksheets(1).Cells(24, 8).Formula = "=SUMA(H19:H22)"
            wBook.Worksheets(1).Cells(25, 8).Formula = "=H16+H24"

            wBook.Worksheets(1).Cells(34, 8).Formula = "=SUMA(H29:H32)"
            wBook.Worksheets(1).Cells(35, 8).Formula = "=H34+H25"


            wSheet_bc.Columns.AutoFit()


            '****************** finalizamos *******************
            Dim strFileName As String = "D:\BalanceGeneral" & Now.Year.ToString & Now.Month.ToString & Now.Day.ToString & Now.Hour.ToString & Now.Minute & Now.Second.ToString & ".xls"
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




            '___________________________________________________________________________________________________

            'ObjReporte.Muestra_Reporte(String.Format("{0}\{1}", gStr_RutaRep, Str_NombreRep), Dt, "", _
            '"pTitulo;" & Str_Titulo, "pFormato;(" & uos_Formato.CheckedItem.DisplayText & ")", _
            '"pRuc;" & EmpresaBE.EM_RUC, "pRazon;" & EmpresaBE.EM_NOMBRE)

            Me.Cursor = Cursors.Default

            EmpresaBL = Nothing
            EmpresaBE = Nothing
            grupoBgCuentasBL = Nothing
            ClasesBL = Nothing
            clasesBG = Nothing
            gruposBG = Nothing
            GruposBL = Nothing
            Dt_BalGen = Nothing


        Catch ex As Exception
            Me.Cursor = Cursors.Default
            ShowError(ex.Message)
        End Try
    End Sub

    Private Sub Exportar_Solo_BG()
        Dim Obj_ReporteBL As New BL.ContabilidadBL.SG_CO_Reportes_Registros
        Dim Dt_BalGen As DataTable = Nothing
        Dim Dt_ctas_sobregiro As DataTable = Nothing

        Dim ClasesBL As New BL.ContabilidadBL.SG_CO_TB_CLASES_BG
        Dim clasesBG As New List(Of BE.ContabilidadBE.SG_CO_TB_CLASES_BG)
        Dim clase As BE.ContabilidadBE.SG_CO_TB_CLASES_BG

        Dim gruposBG As New List(Of BE.ContabilidadBE.SG_CO_TB_GRUPOS_BG)
        Dim GruposBL As New BL.ContabilidadBL.SG_CO_TB_GRUPOS_BG
        Dim grupo As BE.ContabilidadBE.SG_CO_TB_GRUPOS_BG

        Dim grupoBgCuentasBL As New BL.ContabilidadBL.SG_CO_TB_GRUPOBG_CUENTAS
        Dim cuentas As List(Of BE.ContabilidadBE.SG_CO_TB_PLANCTAS)
        Dim cuentaBE As BE.ContabilidadBE.SG_CO_TB_PLANCTAS
        'Dim cuentaBL As BL.ContabilidadBL.SG_CO_TB_PLANCTAS

        Dim EmpresaBE As New BE.ContabilidadBE.SG_CO_TB_EMPRESA With {.EM_ID = gInt_IdEmpresa}
        Dim fecha_ini As String = ""
        Dim fecha_fin As String = ""

        fecha_ini = "01/01/" & txt_Ayo.Text.Trim
        fecha_fin = ObtenerUltimoDia("01/" & uce_Mes.Value.ToString.PadLeft(2, "0") & "/" & txt_Ayo.Text.Trim)

        Try

            Me.Cursor = Cursors.WaitCursor
            clasesBG = ClasesBL.getClases()
            Dt_ctas_sobregiro = Obj_ReporteBL.getCuentas10s_sobreGiro(txt_Ayo.Text.Trim, gInt_IdEmpresa)


            pb1.Value = 0
            pb1.Minimum = 0
            pb1.Maximum = clasesBG.Count
            pb1.Visible = True

            Obj_ReporteBL.Limpiar_Tabla_Balance_Gral()

            For Each clase In clasesBG
                gruposBG = GruposBL.getGrupos_x_Clase(clase)
                For Each grupo In gruposBG
                    cuentas = grupoBgCuentasBL.getCuentas_x_Grupo(grupo, gInt_IdEmpresa, txt_Ayo.Value)
                    For Each cuentaBE In cuentas
                        Obj_ReporteBL.setImportes_Balance_Gral(clase.CBG_ID, grupo.GBG_ID, cuentaBE.PC_NUM_CUENTA, CInt(txt_Ayo.Text.Trim), uce_Mes.Value, gInt_IdEmpresa, IIf(uos_Formato.Value = 1, True, False), IIf(uchk_Cierre.Checked, 0, 1))
                    Next
                Next
                pb1.Increment(1)
            Next

            pb1.Value = 0

            Obj_ReporteBL.set_Actualiza_Importe_CajaBancos_Cero()

            Me.Refresh()

            pb1.Value = 0
            pb1.Minimum = 0
            pb1.Maximum = Dt_ctas_sobregiro.Rows.Count
            pb1.Visible = True

            For j As Integer = 0 To Dt_ctas_sobregiro.Rows.Count - 1
                Obj_ReporteBL.setActualizar_Cta10_SobreGiro(Dt_ctas_sobregiro.Rows(j)("PC_NUM_CUENTA"), txt_Ayo.Text.Trim, uce_Mes.Value, gInt_IdEmpresa, IIf(uos_Formato.Value = 1, 0, 1), IIf(uchk_Cierre.Checked, 0, 1))
                pb1.Increment(1)
            Next

            pb1.Visible = False
            pb1.Value = 0


            'actualizo el bal. gen. la cta 89 de resultado de ejercicio
            Obj_ReporteBL.set_Actualizar_Resultado_Ejercicio(txt_Ayo.Text, uce_Mes.Value, gInt_IdEmpresa, "89", IIf(uchk_Cierre.Checked, 0, 1))


            'actualiza los totales del pasivo y patrimonio
            Obj_ReporteBL.setActualizar_Importe_PasivoPatrimonio()


            'Hacemos un select a la tabla
            Dt_BalGen = Obj_ReporteBL.getBalance_Gral_1()

            Dim Str_Titulo As String = "Estado de Situacion Financiera a " & uce_Mes.Text & " " & txt_Ayo.Text.Trim
            Dim EmpresaBL As New BL.ContabilidadBL.SG_CO_TB_EMPRESA
            EmpresaBL.getEmpresas_2(EmpresaBE)


            '___________________________________________________________________________________________________





            'Dim excel As New Microsoft.Office.Interop.Excel.Application
            'Dim dsdexcel As New Microsoft.Office.Interop.Excel.Application
            'Dim wBook As Microsoft.Office.Interop.Excel.Workbook
            'Dim wSheet As Microsoft.Office.Interop.Excel.Worksheet

            Const xlEdgeLeft = 7
            Const xlEdgeRight = 10
            Const xlEdgeTop = 8
            Const xlEdgeBottom = 9
            Const xlInsideHorizontal = 12
            Const xlInsideVertical = 11
            Const xlContinuous = 1
            Const xlThin = 2

            Dim excel As Object
            Dim wBook As Object
            Dim wSheet As Object

            excel = CreateObject("Excel.Application")
            wBook = excel.Workbooks.Add
            wSheet = wBook.Worksheets(1)


            wBook = excel.Workbooks.Add()
            wSheet = wBook.ActiveSheet()


            wSheet.Name = "Balance General"
            wSheet.Range("A1", "A3").Font.Bold = True
            wSheet.Range("C1", "C2").Font.Bold = True

            wSheet.Range("C3", "G4").Font.Bold = True

            wSheet.Range("D8", "D35").NumberFormat = "#,##0.00"
            wSheet.Range("H8", "H35").NumberFormat = "#,##0.00"

            wSheet.Range("C3", "G3").Merge()
            wSheet.Range("C4", "G4").Merge()

            wSheet.Range("C3", "G3").HorizontalAlignment = HorizontalAlignment.Center
            wSheet.Range("C3", "G4").HorizontalAlignment = HorizontalAlignment.Center


            excel.Cells(1, 1) = "Empresa"
            excel.Cells(2, 1) = "Ruc"
            excel.Cells(1, 3) = EmpresaBE.EM_NOMBRE
            excel.Cells(2, 3) = "'" & EmpresaBE.EM_RUC.ToString

            'wSheet.Range("C2", "C2").HorizontalAlignment = HorizontalAlignment.Left


            excel.Cells(3, 3) = Str_Titulo
            excel.Cells(4, 3) = uos_Formato.CheckedItem.DisplayText


            With wSheet.Range("C3", "G4").Borders(xlEdgeBottom)
                .Weight = xlThin
                .LineStyle = xlContinuous
                .ColorIndex = 0
                '.TintAndShade = 0
            End With

            With wSheet.Range("C3", "G4").Borders(xlEdgeTop)
                .Weight = xlThin
                .LineStyle = xlContinuous
                .ColorIndex = 0
            End With

            wSheet.Range("C3", "G4").Interior.ColorIndex = 34
            wSheet.Range("C3", "G4").Font.ColorIndex = 0


            Dim drfilas() As DataRow
            Dim subtotal As Double = 0
            Dim total_activo As Double = 0
            Dim total_pasivo As Double = 0
            Dim cont_filas_tmp As Integer = 0


            excel.Cells(6, 3) = "A c t i v o"
            excel.Cells(7, 3) = "Activo Corriente"


            drfilas = Dt_BalGen.Select("rb_idmod = 1")
            cont_filas_tmp = 8

            For f As Integer = 0 To drfilas.Length - 1
                excel.Cells(cont_filas_tmp + f, 2) = drfilas(f)(4)
                excel.Cells(cont_filas_tmp + f, 3) = drfilas(f)(5)
                excel.Cells(cont_filas_tmp + f, 4) = drfilas(f)(6)
                'wSheet.Cells(cont_filas_tmp + f, 4).numberformat = "#,##0.00"
            Next

            cont_filas_tmp += drfilas.Length

            'subtotal activo corriente
            subtotal = Dt_BalGen.Compute("sum(RB_IMPORTE)", "RB_IDMOD = 1")
            total_activo += subtotal
            cont_filas_tmp += 1
            excel.Cells(cont_filas_tmp, 3) = "Total Activo Corriente"
            excel.Cells(cont_filas_tmp, 4) = subtotal



            cont_filas_tmp += 2
            excel.Cells(cont_filas_tmp, 3) = "Activos No Corrientes"

            drfilas = Dt_BalGen.Select("rb_idmod = 2")
            cont_filas_tmp += 1

            For f As Integer = 0 To drfilas.Length - 1
                excel.Cells(cont_filas_tmp + f, 2) = drfilas(f)(4)
                excel.Cells(cont_filas_tmp + f, 3) = drfilas(f)(5)
                excel.Cells(cont_filas_tmp + f, 4) = drfilas(f)(6)
            Next

            cont_filas_tmp += drfilas.Length

            'subtotal activo NO corriente
            subtotal = Dt_BalGen.Compute("sum(RB_IMPORTE)", "RB_IDMOD = 2")
            total_activo += subtotal
            cont_filas_tmp += 1
            excel.Cells(cont_filas_tmp, 3) = "Total Activo No Corriente"
            excel.Cells(cont_filas_tmp, 4) = subtotal

            cont_filas_tmp += 1
            excel.Cells(cont_filas_tmp, 3) = "TOTAL ACTIVO "
            excel.Cells(cont_filas_tmp, 4) = total_activo


            ''P a s i v o  y  P a t r i m o n i o
            'pasivo  corriente
            excel.Cells(6, 7) = "'P a s i v o  y  P a t r i m o n i o"
            excel.Cells(7, 7) = "Pasivo Corriente"

            drfilas = Dt_BalGen.Select("rb_idmod = 3")
            cont_filas_tmp = 8

            For f As Integer = 0 To drfilas.Length - 1
                excel.Cells(cont_filas_tmp + f, 6) = drfilas(f)(4)
                excel.Cells(cont_filas_tmp + f, 7) = drfilas(f)(5)
                excel.Cells(cont_filas_tmp + f, 8) = drfilas(f)(6)
            Next

            cont_filas_tmp += drfilas.Length

            'subtotal pasivo corriente
            subtotal = Dt_BalGen.Compute("sum(RB_IMPORTE)", "RB_IDMOD = 3")
            total_pasivo += subtotal
            cont_filas_tmp += 1

            excel.Cells(cont_filas_tmp, 7) = "Total Pasivo Corriente"
            excel.Cells(cont_filas_tmp, 8) = subtotal





            'pasivo  No corriente 
            cont_filas_tmp += 2
            excel.Cells(cont_filas_tmp, 7) = "Pasivo No Corriente"

            drfilas = Dt_BalGen.Select("rb_idmod = 4")
            cont_filas_tmp += 1

            For f As Integer = 0 To drfilas.Length - 1
                excel.Cells(cont_filas_tmp + f, 6) = drfilas(f)(4)
                excel.Cells(cont_filas_tmp + f, 7) = drfilas(f)(5)
                excel.Cells(cont_filas_tmp + f, 8) = drfilas(f)(6)
            Next

            cont_filas_tmp += drfilas.Length

            'subtotal pasivo No corriente
            subtotal = Dt_BalGen.Compute("sum(RB_IMPORTE)", "RB_IDMOD = 4")
            total_pasivo += subtotal
            cont_filas_tmp += 1

            excel.Cells(cont_filas_tmp, 7) = "Total Pasivo No Corriente"
            excel.Cells(cont_filas_tmp, 8) = subtotal

            cont_filas_tmp += 1

            excel.Cells(cont_filas_tmp, 7) = "TOTAL PASIVO "
            excel.Cells(cont_filas_tmp, 8) = total_pasivo


            'pasivo  No corriente
            cont_filas_tmp += 2
            excel.Cells(cont_filas_tmp, 7) = "P a t r i m o n i o   N e t o"
            cont_filas_tmp += 1
            excel.Cells(cont_filas_tmp, 7) = "Patrimonio Neto"

            drfilas = Dt_BalGen.Select("rb_idmod = 5")
            cont_filas_tmp += 1

            For f As Integer = 0 To drfilas.Length - 1
                excel.Cells(cont_filas_tmp + f, 6) = drfilas(f)(4)
                excel.Cells(cont_filas_tmp + f, 7) = drfilas(f)(5)
                excel.Cells(cont_filas_tmp + f, 8) = drfilas(f)(6)
            Next


            cont_filas_tmp += drfilas.Length

            'subtotal pasivo No corriente
            subtotal = Dt_BalGen.Compute("sum(RB_IMPORTE)", "RB_IDMOD = 5")
            cont_filas_tmp += 1

            excel.Cells(cont_filas_tmp, 7) = "Total del Patrimonio"
            excel.Cells(cont_filas_tmp, 8) = subtotal

            cont_filas_tmp += 1
            excel.Cells(cont_filas_tmp, 7) = "Total del Pasivo y Patrimonio"
            excel.Cells(cont_filas_tmp, 8) = Dt_BalGen.Rows(0)(8)

            wSheet.Columns.AutoFit()

            '****************** finalizamos *******************
            Dim strFileName As String = "D:\BalanceGeneral.xls"
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




            '___________________________________________________________________________________________________

            'ObjReporte.Muestra_Reporte(String.Format("{0}\{1}", gStr_RutaRep, Str_NombreRep), Dt, "", _
            '"pTitulo;" & Str_Titulo, "pFormato;(" & uos_Formato.CheckedItem.DisplayText & ")", _
            '"pRuc;" & EmpresaBE.EM_RUC, "pRazon;" & EmpresaBE.EM_NOMBRE)

            Me.Cursor = Cursors.Default

            EmpresaBL = Nothing
            EmpresaBE = Nothing
            grupoBgCuentasBL = Nothing
            ClasesBL = Nothing
            clasesBG = Nothing
            gruposBG = Nothing
            GruposBL = Nothing
            Dt_BalGen = Nothing

        Catch ex As Exception
            Me.Cursor = Cursors.Default
            ShowError(ex.Message)
        End Try

    End Sub
End Class