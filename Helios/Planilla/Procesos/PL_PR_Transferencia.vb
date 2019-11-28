Public Class PL_PR_Transferencia

    Private Sub PL_RP_Plame_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call Cargar_Estructuras()
        Call CargarCombo_ConMeses(uce_Mes)
        une_Ayo.Value = gDat_Fecha_Sis.Year
        uce_Mes.Value = gDat_Fecha_Sis.Month

        ug_tregistro.Rows(0).Activate()
        ug_plame.Rows(0).Activate()

    End Sub

    Private Sub Cargar_Estructuras()

        'primero para los pdt del t-registro

        Call Grabar_fila_grilla("1", "Establecimientos Propios del Empleador. Identifique establecimientos de riesgo SCTR.", "T")
        Call Grabar_fila_grilla("2", "Empleadores a quienes destaco o desplazo personal.", "T")
        Call Grabar_fila_grilla("3", "Empleadores que me destacan o desplazan personal", "T")
        Call Grabar_fila_grilla("4", "Datos personales del trabajador, pensionista, personal en formación - modalidad formativa laboral y otros y personal de terceros.", "T")
        Call Grabar_fila_grilla("5", "Datos del trabajador.", "T")
        Call Grabar_fila_grilla("6", "Datos del pensionista.", "T")
        Call Grabar_fila_grilla("9", "Datos del personal en formación -  modalidad formativa laboral y otros.", "T")
        Call Grabar_fila_grilla("10", "Datos del personal de terceros.", "T")
        Call Grabar_fila_grilla("11", "Períodos.", "T")
        Call Grabar_fila_grilla("17", "Datos de los establecimientos donde labora el trabajador.", "T")
        Call Grabar_fila_grilla("23", "Lugar de formación de Personal en formación - modalidad formativa laboral y otros y de destaque del Personal de Terceros", "T")
        Call Grabar_fila_grilla("13", "Datos de derechohabientes - ALTAS", "T")
        Call Grabar_fila_grilla("24", "Baja de derechohabientes - BAJAS", "T")


        'luego para el pdt del plame
        Call Grabar_fila_grilla("7", "Prestador de Servicios con Rentas de Cuarta categoría.", "P")
        Call Grabar_fila_grilla("12", "Trabajador: Otras Rentas de Quinta categoría", "P")
        Call Grabar_fila_grilla("14", "Trabajador: Datos de la jornada laboral.", "P")
        Call Grabar_fila_grilla("15", "Trabajador: Días subsidiados y otros no laborados.", "P")
        Call Grabar_fila_grilla("16", "Trabajador: Datos de los días no trabajados y no subsidiados del trabajador", "P")
        Call Grabar_fila_grilla("18", "Trabajador: Detalle de los ingresos, tributos y descuentos.", "P")
        Call Grabar_fila_grilla("19", "Pensionista: Detalle de los ingresos, tributos y descuentos.", "P")
        Call Grabar_fila_grilla("20", "Prestador de Servicios con Rentas de Cuarta categoría: Detalle de comprobantes.", "P")
        Call Grabar_fila_grilla("21", "Personal en Formación - modalidad formativa laboral y otros: Monto pagado.", "P")
        Call Grabar_fila_grilla("22", "Personal de terceros - SCTR ESSALUD", "P")
        Call Grabar_fila_grilla("25", "Trabajador: Tasas SCTR-EsSalud y/o convenio IES ", "P")
        Call Grabar_fila_grilla("26", "Trabajador: Otras condiciones", "P")
        Call Grabar_fila_grilla("27", "Pensionista: Otras condiciones", "P")

    End Sub


    Private Sub Grabar_fila_grilla(ByVal cod As String, ByVal des As String, ByVal grila As String)

        If grila = "T" Then

            ug_tregistro.DisplayLayout.Bands(0).AddNew()
            ug_tregistro.Rows(ug_tregistro.Rows.Count - 1).Cells("Sel").Value = False
            ug_tregistro.Rows(ug_tregistro.Rows.Count - 1).Cells("Num").Value = cod
            ug_tregistro.Rows(ug_tregistro.Rows.Count - 1).Cells("Des").Value = des
            ug_tregistro.UpdateData()

        End If

        If grila = "P" Then

            ug_plame.DisplayLayout.Bands(0).AddNew()
            ug_plame.Rows(ug_plame.Rows.Count - 1).Cells("Sel").Value = False
            ug_plame.Rows(ug_plame.Rows.Count - 1).Cells("Num").Value = cod
            ug_plame.Rows(ug_plame.Rows.Count - 1).Cells("Des").Value = des
            ug_plame.UpdateData()

        End If



    End Sub


    Private Sub UltraCheckEditor1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UltraCheckEditor1.CheckedChanged
        For i As Integer = 0 To ug_tregistro.Rows.Count - 1
            ug_tregistro.Rows(i).Cells("Sel").Value = UltraCheckEditor1.Checked
        Next
        ug_tregistro.UpdateData()
    End Sub

    Private Sub UltraCheckEditor2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UltraCheckEditor2.CheckedChanged
        For i As Integer = 0 To ug_plame.Rows.Count - 1
            ug_plame.Rows(i).Cells("Sel").Value = UltraCheckEditor2.Checked
        Next
        ug_plame.UpdateData()
    End Sub

    
    Private Sub Tool_Salir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_Salir.Click
        Me.Close()
    End Sub

    Private Sub Tool_Generar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_Generar.Click

        Dim mypdt As New BL.PlanillaBL.PDT(gInt_IdEmpresa)

        ug_tregistro.UpdateData()
        For i As Integer = 0 To ug_tregistro.Rows.Count - 1

            If ug_tregistro.Rows(i).Cells("Sel").Value Then


                Select Case ug_tregistro.Rows(i).Cells("num").Value
                    Case "4"
                        mypdt.get_Estruc_04(une_Ayo.Value, uce_Mes.Value, gInt_IdEmpresa)

                    Case "17" 'establecimientos
                        mypdt.get_Estruc_17(une_Ayo.Value, uce_Mes.Value, gInt_IdEmpresa)

                End Select

            End If

        Next

        ug_plame.UpdateData()
        For i As Integer = 0 To ug_plame.Rows.Count - 1

            If ug_plame.Rows(i).Cells("Sel").Value Then

                Select Case ug_plame.Rows(i).Cells("num").Value

                    Case "7" 'Prestador de Servicios con Rentas de Cuarta categoría

                        mypdt.get_Estruc_07(une_Ayo.Value, uce_Mes.Value, gInt_IdEmpresa)

                    Case "14" 'jornada laboral.
                        mypdt.get_Estruc_14(une_Ayo.Value, uce_Mes.Value, gInt_IdEmpresa)

                    Case "15" 'Datos de los días subsidiados del trabajador
                        mypdt.get_Estruc_15_v2(une_Ayo.Value, uce_Mes.Value, gInt_IdEmpresa)


                    Case "16" 'Datos de los días no trabajados y no subsidiados del trabajador
                        mypdt.get_Estruc_16(une_Ayo.Value, uce_Mes.Value, gInt_IdEmpresa)

                    Case "18" 'Detalle de los ingresos, tributos y descuentos.

                        mypdt.get_Estruc_18(une_Ayo.Value, uce_Mes.Value, gInt_IdEmpresa)

                    Case "20" 'Rentas de Cuarta categoría: 

                        mypdt.get_Estruc_20(une_Ayo.Value, uce_Mes.Value, gInt_IdEmpresa)

                End Select
            End If

        Next

        Avisar("Listo!")

    End Sub


    Private Sub Tool_Abrir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_Abrir.Click
        Dim Str_vRutaPdt As String
        Dim paraetrosBL As New BL.PlanillaBL.SG_PL_TB_PARAMETROS
        Dim paraetrosBE As New BE.PlanillaBE.SG_PL_TB_PARAMETROS
        paraetrosBE.AD_IDEMPRESA = gInt_IdEmpresa
        paraetrosBE.AD_TIPO = "RUTA"
        paraetrosBE.AD_NOMBRE = "PDT"

        Str_vRutaPdt = paraetrosBL.get_Valor(paraetrosBE)

        paraetrosBE = Nothing
        paraetrosBL = Nothing

        Process.Start("explorer.exe", Str_vRutaPdt)
    End Sub

    Private Sub ToolStripButton1_Click(sender As System.Object, e As System.EventArgs)
        Dim mypdt As New BL.PlanillaBL.PDT(gInt_IdEmpresa)
        mypdt.get_Estruc_CTS_Banco_Comercio()
        mypdt = Nothing
    End Sub
End Class