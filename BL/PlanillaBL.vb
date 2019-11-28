
Imports Microsoft.ApplicationBlocks.Data
Imports System.Data.SqlClient
Imports System.Data
Imports System.IO
Imports Ionic.Utils.Zip
'Imports Excel = Microsoft.Office.Interop.Excel

Public Class PlanillaBL

    Public Class SG_PL_TB_REG_UTILIDAD_C
        Inherits ClsBD

        Public Sub insert(entidad As BE.PlanillaBE.SG_PL_TB_REG_UTILIDAD_C)
            With entidad
                SqlHelper.ExecuteNonQuery(Cn, "SG_PL_SP_I_REG_UTILIDAD_C", .RU_IDANHO, .RU_RENTA_ANUAL, .RU_PORCEN_DISTRI, .RU_MONTO_DISTRI, .RU_NUM_TOT_HOR, .RU_REMU_COMPU, .RU_IDEMPRESA)
            End With
        End Sub

        Public Sub update(entidad As BE.PlanillaBE.SG_PL_TB_REG_UTILIDAD_C)
            With entidad
                SqlHelper.ExecuteNonQuery(Cn, "", .RU_IDANHO, .RU_RENTA_ANUAL, .RU_PORCEN_DISTRI, .RU_MONTO_DISTRI, .RU_NUM_TOT_HOR, .RU_REMU_COMPU, .RU_IDEMPRESA)
            End With
        End Sub

        Public Function get_reg_utilidad(ayo_ As Integer, empresa_ As Integer) As DataSet
            Return SqlHelper.ExecuteDataset(Cn, "SG_PL_SP_S_REG_UTILIDAD", ayo_, empresa_)
        End Function

        Public Sub delete(entidad As BE.PlanillaBE.SG_PL_TB_REG_UTILIDAD_C)
            SqlHelper.ExecuteNonQuery(Cn, "SG_PL_SP_D_REG_UTILIDAD", entidad.RU_IDANHO, entidad.RU_IDEMPRESA)
        End Sub
    End Class

    Public Class SG_PL_TB_REG_UTILIDAD_D
        Inherits ClsBD

        Public Sub insert(entidad As BE.PlanillaBE.SG_PL_TB_REG_UTILIDAD_D)
            With entidad
                SqlHelper.ExecuteNonQuery(Cn, "SG_PL_SP_I_REG_UTILIDAD_D", .RD_IDANHO, .RD_IDEMPRESA, .RD_IDPERSONAL, .RD_NUM_HORAS_LAB_EMP, .RD_PARTICI_EMP_HOR, .RD_REMU_COMPU_EMP, .RD_PARTICI_EMP_REMU, .RD_FACT_HORAS, .RD_FACT_REMU, .RD_TOTAL_UTI)
            End With
        End Sub
    End Class


    Public Class SG_PL_TB_PLANCOD_EMPRESA
        Inherits ClsBD

        Public Sub Insert(lista As List(Of BE.PlanillaBE.SG_PL_TB_PLANCOD_EMPRESA))

            SqlHelper.ExecuteNonQuery(Cn, "SG_PL_TB_D_RELA_PLANI_EMP", lista(0).PE_IDEMPRESA)

            For Each tabla As BE.PlanillaBE.SG_PL_TB_PLANCOD_EMPRESA In lista
                SqlHelper.ExecuteNonQuery(Cn, "SG_PL_TB_I_RELA_PLANI_EMP", tabla.PE_IDPLANTILLA, tabla.PE_IDCONCEPTO, tabla.PE_IDEMPRESA)
            Next

        End Sub

        Public Function get_Relacion_Plantilla_Empresa(entidad As BE.ContabilidadBE.SG_CO_TB_EMPRESA) As DataTable
            Return SqlHelper.ExecuteDataset(Cn, "SG_PL_SP_S_RELA_PLANTI_EMP", entidad.EM_ID).Tables(0)
        End Function

    End Class


    Public Class SG_PL_TB_PLANTILLA_CODIGO
        Inherits ClsBD

        Public Function get_Plantilla() As DataTable
            Return SqlHelper.ExecuteDataset(Cn, "SG_PL_SP_S_PLANTI_COD").Tables(0)
        End Function


    End Class

    Public Class SG_PL_TB_TARDANZA_PERSONAL
        Inherits ClsBD

        Public Sub Insert(Entidad As BE.PlanillaBE.SG_PL_TB_TARDANZA_PERSONAL)
            With Entidad

                If .TP_TARDANZA = "" Then
                    SqlHelper.ExecuteNonQuery(Cn, "SG_PL_SP_D_TARDANZA_PERSONAL", .TP_IDPERSONAL, .TP_ANHO, .TP_MES)
                Else
                    SqlHelper.ExecuteNonQuery(Cn, "SG_PL_SP_I_TARDANZA_PERSONAL", .TP_IDPERSONAL, .TP_ANHO, .TP_MES, _
                                          .TP_TARDANZA, .TP_USUARIO, .TP_TERMINAL, .TP_FECREG)
                End If

            End With
        End Sub

        Public Function get_Tardanza_aux(entidad As BE.PlanillaBE.SG_PL_TB_TARDANZA_PERSONAL) As String
            Dim valor As String = SqlHelper.ExecuteScalar(Cn, "SG_PL_SP_S_TARDANZA_PER_AUX", entidad.TP_IDPERSONAL, entidad.TP_ANHO, entidad.TP_MES)

            If valor Is Nothing Then
                valor = String.Empty
            End If

            Return valor
        End Function

        Public Function get_Tardanza_aux_MinSeg(entidad As BE.PlanillaBE.SG_PL_TB_TARDANZA_PERSONAL) As String
            Dim valor As String = SqlHelper.ExecuteScalar(Cn, "SG_PL_SP_S_TARDANZA_PER_AUX_MINSEG", entidad.TP_IDPERSONAL, entidad.TP_ANHO, entidad.TP_MES)

            'If valor = "0.0" Then
            'valor = String.Empty
            'End If

            If valor Is Nothing Then
                valor = String.Empty
            End If

            Return valor
        End Function

    End Class

    Public Class Calculos
        Inherits ClsBD

        Public Function get_Provision_Cts(ayo_ As Integer, mes_ As Integer, empresa_ As Integer, tipo_ As Integer) As DataTable

            'Creamos la Tabla
            Dim dt_cuenta_importe As DataTable = Nothing
            dt_cuenta_importe = New DataTable
            dt_cuenta_importe.Columns.Clear()
            dt_cuenta_importe.Columns.Add("Item", Type.GetType("System.Int32"))
            dt_cuenta_importe.Columns.Add("CC", Type.GetType("System.String"))
            dt_cuenta_importe.Columns.Add("Cuenta", Type.GetType("System.String"))
            dt_cuenta_importe.Columns.Add("Descripcion", Type.GetType("System.String"))
            dt_cuenta_importe.Columns.Add("Debe", Type.GetType("System.Double"))
            dt_cuenta_importe.Columns.Add("Haber", Type.GetType("System.Double"))
            dt_cuenta_importe.Columns.Add("EsDestino", Type.GetType("System.String"))


            Dim Num_cta62 As String = "629101"
            Dim Num_cta41 As String = "410000"
            Dim Num_cta62_Vac As String = "629101"
            Dim Num_cta41_Vac As String = "410000"

            Dim parametrosBL As New BL.PlanillaBL.SG_PL_TB_PARAMETROS
            Dim parametrosBE As New BE.PlanillaBE.SG_PL_TB_PARAMETROS
            parametrosBE.AD_TIPO = "CTAPR"
            parametrosBE.AD_IDEMPRESA = empresa_

            parametrosBE.AD_NOMBRE = "CTS60"
            Num_cta62 = parametrosBL.get_Valor(parametrosBE)

            parametrosBE.AD_NOMBRE = "CTS40"
            Num_cta41 = parametrosBL.get_Valor(parametrosBE)

            parametrosBE.AD_NOMBRE = "VAC60"
            Num_cta62_Vac = parametrosBL.get_Valor(parametrosBE)

            parametrosBE.AD_NOMBRE = "VAC40"
            Num_cta41_Vac = parametrosBL.get_Valor(parametrosBE)

            parametrosBE = Nothing
            parametrosBL = Nothing




            Dim dt_Montos As DataTable = SqlHelper.ExecuteDataset(Cn, "SG_PL_SP_S_REMU_TOT_COMPU", ayo_, mes_, empresa_, tipo_).Tables(0)
            Dim historialBL As New PlanillaBL.SG_PL_TB_HISTORIAL
            Dim dt_cc_perso As DataTable = Nothing 'Tabla => SG_PL_TB_PERSONAL_CCOSTO
            Dim dt_ctas_Destinos As DataTable = SqlHelper.ExecuteDataset(Cn, "SG_PL_SP_S_CTAS_DESTINO_X_NUMCTA", ayo_, IIf(tipo_ = 1, Num_cta62, Num_cta62_Vac), empresa_).Tables(0)
            Dim Monto_cta62 As Double = 0
            Dim Monto_cta41 As Double = 0
            Dim Monto_cta79 As Double = 0

            Dim monto_tmp As Double = 0
            Dim monto_calculado As Double = 0
            Dim porcentaje As Double = 0
            Dim cod_cc As String = String.Empty


            'Grabamos la cuenta 60 
            If dt_Montos.Rows.Count > 0 Then
                Monto_cta62 = dt_Montos.Compute("sum(MONTO)", "")
            End If

            Monto_cta41 = Monto_cta62
            Monto_cta79 = Monto_cta62

            If tipo_ = 1 Then
                Call Insert_Fila_Provi(dt_cuenta_importe, "", Num_cta62, Monto_cta62, "D", "0", empresa_, ayo_)
            Else
                Call Insert_Fila_Provi(dt_cuenta_importe, "", Num_cta62_Vac, Monto_cta62, "D", "0", empresa_, ayo_)
            End If



            For i As Integer = 0 To dt_Montos.Rows.Count - 1


                monto_tmp = dt_Montos.Rows(i)("MONTO")
                Monto_cta62 += monto_tmp
                dt_cc_perso = historialBL.get_CentroCosto_x_Persona(dt_Montos.Rows(i)("PE_ID"))



                'aqui grabamos las 90's
                For k As Integer = 0 To dt_cc_perso.Rows.Count - 1

                    porcentaje = dt_cc_perso.Rows(k)("CC_PORCENTAJE")
                    cod_cc = dt_cc_perso.Rows(k)("CC_CC")

                    For Each fila As DataRow In dt_ctas_Destinos.Rows

                        If LSet(fila("CD_CTA_DESTINO"), cod_cc.Length) = cod_cc Then
                            monto_calculado = ((monto_tmp * porcentaje) / 100)
                            Insert_Fila_Provi(dt_cuenta_importe, cod_cc, fila("CD_CTA_DESTINO"), monto_calculado, fila("CD_DH"), "1", empresa_, ayo_)
                        End If

                    Next
                Next

            Next

            'aki grabamos la cuenta 79
            Call Insert_Fila_Provi(dt_cuenta_importe, "", "791101", Monto_cta79, "H", "1", empresa_, ayo_)


            If tipo_ = 1 Then
                'Grabamos la cuenta 41 de la CTS
                Call Insert_Fila_Provi(dt_cuenta_importe, "", Num_cta41, Monto_cta41, "H", "0", empresa_, ayo_)
            Else
                'Grabamos la cuenta 41 de la vacaciones
                Call Insert_Fila_Provi(dt_cuenta_importe, "", Num_cta41_Vac, Monto_cta41, "H", "0", empresa_, ayo_)
            End If
            


            monto_calculado = 0

            Return dt_cuenta_importe

        End Function

        Private Sub Insert_Fila_Provi(dt_ As DataTable, cc_ As String, cuenta_ As String, importe_ As Double, dh_ As String, esDestino_ As String, empresa_ As Integer, ayo_ As Integer)

            Dim fila As DataRow
            Dim str_des_cta As String = ""

            Dim ctasBL As New BL.ContabilidadBL.SG_CO_TB_PLANCTAS
            Dim ctasBE As New BE.ContabilidadBE.SG_CO_TB_PLANCTAS
            ctasBE.PC_NUM_CUENTA = cuenta_
            ctasBE.PC_IDEMPRESA = New BE.ContabilidadBE.SG_CO_TB_EMPRESA With {.EM_ID = empresa_}
            ctasBE.PC_PERIODO = ayo_
            ctasBL.getCuenta_X_NumeroCta(ctasBE)
            str_des_cta = ctasBE.PC_DESCRIPCION

            ctasBE = Nothing
            ctasBL = Nothing

            If dt_.Select("cuenta = '" & cuenta_ & "'").Length > 0 Then
                fila = dt_.Select("cuenta = '" & cuenta_ & "'")(0)
                fila("Descripcion") = str_des_cta
                'fila("CC") = cc_
                'fila("Cuenta") = cuenta_

                'fila("Debe") = 0
                'fila("Haber") = 0

                If dh_ = "D" Then fila("Debe") += importe_
                If dh_ = "H" Then fila("Haber") += importe_

                'fila("EsDestino") = esDestino_

            Else

                fila = dt_.NewRow
                fila("Item") = dt_.Rows.Count + 1
                fila("CC") = cc_
                fila("Cuenta") = cuenta_
                fila("Descripcion") = str_des_cta

                fila("Debe") = 0
                fila("Haber") = 0

                If dh_ = "D" Then fila("Debe") = importe_
                If dh_ = "H" Then fila("Haber") = importe_

                fila("EsDestino") = esDestino_

                dt_.Rows.Add(fila)

            End If




        End Sub

        Public Function get_Gratificacion_x_Personal(ByVal personalBE As BE.PlanillaBE.SG_PL_TB_PERSONAL, ByVal ayo_ As Integer, ByVal mes_ As Integer, ByVal bol_semestre_completo_ As Boolean) As List(Of Double)

            'Declaramos las variables >>>>>
            Dim Dbl_RemuBas As Double       'Remuneracion Basica
            Dim Dbl_RemuBas_ficha As Double       'Remuneracion Basica de ficha de planilla
            Dim Dbl_Asig_Familiar As Double 'Asignacion Familiar
            Dim Dbl_Pro_HE_Simple As Double 'promedio de horas extras simples
            Dim Dbl_Pro_HE_Dobles As Double 'promedio de horas extras doubles
            Dim Dbl_Pro_HE_100Ecogest As Double 'promedio de horas extras del concepto 110 de ecogest
            Dim Dbl_Pro_Boni As Double      'promedio de bonificaciones
            Dim Dbl_RiesgoCaja As Double    'Riesgo de Caja
            Dim Dbl_Suma_tc As Double = 0       'Suma del total computable
            Dim Int_MesTraba As Double       'Numero de meses trabajados
            Dim Dbl_Resultado As Double     'Total calculado
            Dim Dbl_PromedioHE As Double    'Promedio de las suma de las HE
            Dim Dbl_BonoEspLey29351 As Double 'bono especial de la ley 29351
            Dim Dbl_Refrigerio As Double = 0 'valor del refrigerio
            Dim Dbl_Remu_Variable As Double 'Remunercion variable de las chicas de consultorio
            Dim dbl_importe_minimo As Double = 67.5
            Dim dbl_Porce_Bono9_conEPS As Double = 0.0675
            Dim dbl_Porce_Bono9_sinEPS As Double = 0.09
            Dim Dbl_BonoEncargatura As Double = 0
            Dim Dbl_subtotal As Double = 0

            'Horas____________________________________________________
            Dim Dbl_Suma119 As Double 'remuneracion por horas
            Dim Dbl_Suma102 As Double 'asignacion familiar
            Dim Dbl_Suma117 As Double 'Hora UCIN
            Dim Dbl_Suma105 As Double 'Refrigerio
            Dim Dbl_Suma107 As Double 'Compens.  Vacacional
            Dim Dbl_Suma106 As Double 'Subsidio

            Dim Dbl_Horas_Ucin As Double
            Dim Dbl_Horas_Normal As Double
            Dim Dbl_Horas_Intermedio As Double
            '______________________________________________________________

            Dim Dbl_MesesTrabajados As Double
            Dim Dbl_total_sum_6meses As Double
            Dim Dbl_total1 As Double
            Dim ls_cts As New List(Of Double)



            Dim parametrosBL As New BL.PlanillaBL.SG_PL_TB_PARAMETROS
            Dim parametrosBE As New BE.PlanillaBE.SG_PL_TB_PARAMETROS
            parametrosBE.AD_TIPO = "PLANI"
            parametrosBE.AD_IDEMPRESA = personalBE.PE_ID_EMPRESA

            parametrosBE.AD_NOMBRE = "MONTO_MIN_ESSALUD"
            dbl_importe_minimo = CDbl(parametrosBL.get_Valor(parametrosBE))
            parametrosBE.AD_NOMBRE = "PORCE_BONO9_CON_EPS"
            dbl_Porce_Bono9_conEPS = CDbl(parametrosBL.get_Valor(parametrosBE))
            parametrosBE.AD_NOMBRE = "PORCE_BONO9_SIN_EPS"
            dbl_Porce_Bono9_sinEPS = CDbl(parametrosBL.get_Valor(parametrosBE))

            If personalBE.PE_ID_TIPO_PER = 1 Then

                'para el caso de las empresas GINEFERT,GESTAR Y GINECOLOGIA Y FERTILIDAD
                'esto para el caso de las chicas que trabajan en el consultorio

                Int_MesTraba = get_Grati_MesesTrabajados(personalBE, ayo_, mes_, bol_semestre_completo_)

                Select Case personalBE.PE_ID_EMPRESA
                    Case 3, 4, 5
                        Dbl_Remu_Variable = get_Grati_Prome_Remuneracion_Variable(personalBE, ayo_, mes_, bol_semestre_completo_, Int_MesTraba)
                End Select


                Dbl_RemuBas_ficha = personalBE.PE_IMPORTE_REMUNERACION
                

                Dbl_RemuBas = get_Concepto_Boleta(personalBE.PE_ID, ayo_, mes_ - 1, "101") 'remune ordinaria
                Dbl_RemuBas += get_Concepto_Boleta(personalBE.PE_ID, ayo_, mes_ - 1, "106") 'subsidio

                'Or personalBE.PE_ID = 185
                If Dbl_RemuBas < Dbl_RemuBas_ficha Then
                    Dbl_RemuBas = personalBE.PE_IMPORTE_REMUNERACION
                Else
                    Dbl_RemuBas += get_Concepto_Boleta(personalBE.PE_ID, ayo_, mes_ - 1, "126") 'vacaciones
                    'Dbl_RemuBas += get_Concepto_Boleta(personalBE.PE_ID, ayo_, mes_ - 1, "105") 'refrigerio
                    'Dbl_RemuBas += get_Concepto_Boleta(personalBE.PE_ID, ayo_, mes_ - 1, "129") 'encargatura
                    'Dbl_RemuBas += get_Concepto_Boleta(personalBE.PE_ID, ayo_, mes_ - 1, "128") 'reintegro
                    Dbl_RemuBas += get_Concepto_Boleta(personalBE.PE_ID, ayo_, mes_ - 1, "132") 'Lic. con goce de haber

                    personalBE.PE_IMPORTE_REMUNERACION = Dbl_RemuBas
                End If



                Dbl_Asig_Familiar = get_Grati_AsignacionFamiliar(personalBE)

                Dbl_Refrigerio = get_Grati_SumaConcepto_6Meses_Atraz(personalBE, ayo_, mes_, "105")
                Dbl_BonoEncargatura = get_Grati_Prome_Bono_Encargatura(personalBE, ayo_, mes_, bol_semestre_completo_)
                Dbl_Refrigerio = Math.Round(Dbl_Refrigerio / IIf(bol_semestre_completo_, 6, 5), 2)
                Dbl_RiesgoCaja = get_Grati_RiesgoCaja(personalBE, ayo_, mes_)
                Dbl_Pro_HE_Simple = get_Grati_Prome_HE_Simples(personalBE, ayo_, mes_)
                Dbl_Pro_HE_Dobles = get_Grati_Prome_HE_Dobles(personalBE, ayo_, mes_)

                'para el caso de ecogest
                Dbl_Pro_HE_100Ecogest = get_Grati_Prome_HE_110_Ecogest(personalBE, ayo_, mes_)

                Select Case personalBE.PE_ID_EMPRESA
                    Case 6
                        Dbl_PromedioHE = Math.Round((Dbl_Pro_HE_100Ecogest + Dbl_Pro_HE_Simple + Dbl_Pro_HE_Dobles) / 6, 2)
                    Case Else
                        Dbl_PromedioHE = Math.Round((Dbl_Pro_HE_Simple + Dbl_Pro_HE_Dobles) / IIf(bol_semestre_completo_, 6, 5), 2)
                End Select

                Dbl_Pro_Boni = get_Grati_Prome_Bonificaciones(personalBE, ayo_, mes_, bol_semestre_completo_)
                Dbl_Suma_tc = Dbl_RemuBas + Dbl_Asig_Familiar + Dbl_PromedioHE + Dbl_Pro_Boni + Dbl_RiesgoCaja + Dbl_Refrigerio + Dbl_Remu_Variable + Dbl_BonoEncargatura


                'Dbl_Resultado = Math.Round((Dbl_Suma_tc / IIf(bol_semestre_completo_, 6, 5)) * Int_MesTraba, 2)
                Dbl_subtotal = Math.Round((Dbl_Suma_tc / 6) * Int_MesTraba, 2)
                Dbl_BonoEspLey29351 = 0

                If personalBE.PE_AFILIADO_EPS_SER_PRO = 1 Then
                    Dbl_BonoEspLey29351 = Math.Round((Dbl_subtotal * dbl_Porce_Bono9_conEPS), 2)
                Else
                    Dbl_BonoEspLey29351 = Math.Round((Dbl_subtotal * dbl_Porce_Bono9_sinEPS), 2)
                End If

                If Dbl_BonoEspLey29351 < dbl_importe_minimo Then Dbl_BonoEspLey29351 = dbl_importe_minimo
                Dbl_Resultado = Dbl_subtotal + Dbl_BonoEspLey29351

                ls_cts.Add(Dbl_RemuBas) '0
                ls_cts.Add(Dbl_Asig_Familiar) '1
                ls_cts.Add(Dbl_RiesgoCaja) '2
                ls_cts.Add(Dbl_PromedioHE) '3
                ls_cts.Add(Dbl_Pro_Boni) '4
                ls_cts.Add(Dbl_BonoEspLey29351) '5
                ls_cts.Add(Int_MesTraba) '6
                ls_cts.Add(Dbl_Resultado) '7 TOTAL
                ls_cts.Add(Dbl_Remu_Variable) '8    
                ls_cts.Add(Dbl_Refrigerio) '9'
                ls_cts.Add(Dbl_Suma_tc) '10 total computable
                ls_cts.Add(Dbl_Suma117) '11 UCIN
                ls_cts.Add(Dbl_Suma107) '12 COMPENSACION VACACIONAL
                ls_cts.Add(Dbl_BonoEncargatura) '13 
                ls_cts.Add(Dbl_subtotal) '14 subtotal
                ls_cts.Add(0) '15 NORMAL
                ls_cts.Add(0) '16 INTERMEDIO
                ls_cts.Add(0) '17 TOTAL HORAS (NORMAL+INTERMEDIO+UCIN)

            Else
                'ESTO ES PARA LOS EMPLEADOS POR HORAS
                'tengo k sumar el concepto 119,102,117 de los 6 meses atraz
                '119 Remuner. x Horas
                '102 Asig. Familiar
                '117 Horas UCIN /Extra TP
                '105 Refrigerio
                '126 Vacaciones
                '106 SubSidio

                'Dbl_Remu_Basica = get_Cts_SumaConceptoRango(personalBE, ayo_, mes_, "119")
                'Dbl_Horas_Ucin = get_Cts_SumaConceptoRango(personalBE, ayo_, mes_, "115")
                'Dbl_Horas_Normal = get_Cts_SumaConceptoRango(personalBE, ayo_, mes_, "130")
                'Dbl_Horas_Intermedio = get_Cts_SumaConceptoRango(personalBE, ayo_, mes_, "117")


                Dbl_Suma119 = get_Grati_SumaConcepto_6Meses_Atraz(personalBE, ayo_, mes_, "119")
                Dbl_Suma102 = get_Grati_SumaConcepto_6Meses_Atraz(personalBE, ayo_, mes_, "102")
                Dbl_Suma105 = get_Grati_SumaConcepto_6Meses_Atraz(personalBE, ayo_, mes_, "105")
                Dbl_Suma107 = get_Grati_SumaConcepto_6Meses_Atraz(personalBE, ayo_, mes_, "107")
                Dbl_Suma106 = get_Grati_SumaConcepto_6Meses_Atraz(personalBE, ayo_, mes_, "106")

                'Dbl_Suma117 = get_Grati_SumaConcepto_6Meses_Atraz(personalBE, ayo_, mes_, "117")
                Dbl_Horas_Ucin = get_Grati_SumaConcepto_6Meses_Atraz(personalBE, ayo_, mes_, "115")
                Dbl_Horas_Normal = get_Grati_SumaConcepto_6Meses_Atraz(personalBE, ayo_, mes_, "130")
                Dbl_Horas_Intermedio = get_Grati_SumaConcepto_6Meses_Atraz(personalBE, ayo_, mes_, "117")

                Dbl_Suma117 = Dbl_Horas_Ucin + Dbl_Horas_Normal + Dbl_Horas_Intermedio

                Dbl_total_sum_6meses = Math.Round(Dbl_Suma119 + Dbl_Suma102 + Dbl_Suma117 + Dbl_Suma105 + Dbl_Suma107 + Dbl_Suma106, 2)
                Dbl_Suma_tc = Dbl_total_sum_6meses
                Dbl_MesesTrabajados = get_Grati_MesesTrabajados_xHoras(personalBE, ayo_, mes_, bol_semestre_completo_)



                'If Not bol_semestre_completo_ Then
                '    If Dbl_MesesTrabajados > 5 Then
                '        Dbl_MesesTrabajados = 5
                '    End If
                'End If

                If Dbl_MesesTrabajados = 0 Then GoTo salida
                If mes_ = 12 Then
                    If bol_semestre_completo_ Then
                        Dbl_total1 = Math.Round((Dbl_total_sum_6meses / 6), 2)
                    Else
                        Dbl_total1 = Math.Round((Dbl_total_sum_6meses / 5), 2)
                    End If
                Else
                    Dbl_total1 = Math.Round(Dbl_total_sum_6meses / Dbl_MesesTrabajados, 2)
                End If

                Dbl_subtotal = Math.Round((Dbl_total1 / 6) * Dbl_MesesTrabajados, 2)

                If personalBE.PE_AFILIADO_EPS_SER_PRO = 1 Then
                    Dbl_BonoEspLey29351 = Math.Round((Dbl_subtotal * dbl_Porce_Bono9_conEPS), 2)
                Else
                    Dbl_BonoEspLey29351 = Math.Round((Dbl_subtotal * dbl_Porce_Bono9_sinEPS), 2)
                End If


                If Dbl_BonoEspLey29351 < dbl_importe_minimo Then Dbl_BonoEspLey29351 = dbl_importe_minimo
                Dbl_total1 = Dbl_subtotal + Dbl_BonoEspLey29351


                ls_cts.Add(Dbl_Suma119) '0remun. basica
                ls_cts.Add(Dbl_Suma102) '1asignacion familiar
                ls_cts.Add(0) '2riesgo caja
                ls_cts.Add(0) '3promedio horas extras
                ls_cts.Add(0) '4promedio bonificacion
                ls_cts.Add(Dbl_BonoEspLey29351) '5
                ls_cts.Add(Dbl_MesesTrabajados) '6
                ls_cts.Add(Dbl_total1) '7
                ls_cts.Add(Dbl_Remu_Variable) '8
                ls_cts.Add(Dbl_Suma105) '9refrigerio
                ls_cts.Add(Dbl_Suma_tc) '10
                ls_cts.Add(Dbl_Horas_Ucin) '11UCIN
                ls_cts.Add(Dbl_Suma107) '12COMPENSACION VACACIONAL
                ls_cts.Add(Dbl_BonoEncargatura) '13 bono de encargatura
                ls_cts.Add(Dbl_subtotal) '14 subtotal
                ls_cts.Add(Dbl_Horas_Normal) '15 NORMAL
                ls_cts.Add(Dbl_Horas_Intermedio) '16 INTERMEDIO
                ls_cts.Add(Dbl_Suma117) '17 TOTAL HORAS (NORMAL+INTERMEDIO+UCIN)


                SqlHelper.ExecuteNonQuery(Cn, CommandType.Text, "insert into _DIF_VACA values(" & personalBE.PE_ID & "," & Dbl_subtotal & ")")

            End If

salida:

            Return ls_cts
        End Function


        Private Function get_Grati_MesesTrabajados_xHoras(ByVal personalBE As BE.PlanillaBE.SG_PL_TB_PERSONAL, ByVal ayo_ As Integer, ByVal mes_ As Integer, bol_SemestreCompleto_ As Boolean) As Double
            get_Grati_MesesTrabajados_xHoras = 0

            Dim Dbl_SumaDias As Double = 0

            If personalBE.PE_ID_TIPO_PER = 2 Then

                If mes_ = 12 Then
                    If CDate(personalBE.PE_FEC_ING) <= "31/07/" & ayo_.ToString Then
                        Dbl_SumaDias = 180
                    Else
                        For i = CDate(personalBE.PE_FEC_ING).Month To 12
                            Dbl_SumaDias += 30
                        Next
                    End If
                End If

                If mes_ = 7 Then
                    If CDate(personalBE.PE_FEC_ING) < "02/01/" & ayo_.ToString Then
                        Dbl_SumaDias = 180
                    Else
                        'sacamos la diferencia entre la fecha de ingreso al 30 de junio del año en curso
                        Dim fec1 As Date = personalBE.PE_FEC_ING
                        Dim fec2 As Date = "30/06/" & ayo_.ToString

                        Dbl_SumaDias = DateDiff(DateInterval.Day, fec1, fec2)

                        'For i = CDate(personalBE.PE_FEC_ING).Month To 6
                        '    Dbl_SumaDias += 30
                        'Next
                    End If
                End If

            End If

            Return Math.Round((Dbl_SumaDias / 30), 2)
            'Return Math.Round((90 / 30), 2)

        End Function

        Private Function get_Grati_MesesTrabajados(ByVal personalBE As BE.PlanillaBE.SG_PL_TB_PERSONAL, ByVal ayo_ As Integer, ByVal mes_ As Integer, bol_semestreFull_ As Boolean) As Double
            get_Grati_MesesTrabajados = 0


            Dim IntInicio As Integer
            Dim IntFin As Integer
            Dim Dbl_SumaDias As Double

            Dbl_SumaDias = 0

            Select Case mes_
                Case 7              'Julio
                    IntInicio = 1  'enero
                    IntFin = 6      'junio
                Case 12             'Noviembre
                    IntInicio = 7   'julio
                    IntFin = 12      'Diciembre
                Case Else           'No es el mes de Gratificacion
                    IntInicio = 0
                    IntFin = 0
            End Select

            Dim dtt As DataTable = SqlHelper.ExecuteDataset(Cn, "SG_PL_SP_S_DIASTRABAJADOS_GRATI", personalBE.PE_ID, ayo_, IntInicio, IntFin, personalBE.PE_ID_EMPRESA).Tables(0)

            Dim mes_aux As Int16 = IntInicio
            Dim ayo_aux As Int16 = ayo_
            Dim dias_tmp As Double = 0

            For j As Integer = 1 To 6

                If dtt.Select("HI_MES = " & mes_aux.ToString).Length > 0 Then
                    dias_tmp = dtt.Compute("sum(HI_HORAS)", "HI_MES = " & mes_aux.ToString)
                    Dbl_SumaDias += dias_tmp
                    If mes_aux = 2 Then
                        Dbl_SumaDias += 2
                    End If
                End If

                mes_aux += 1
                If mes_aux = 13 Then
                    mes_aux = 1
                    ayo_aux += 1
                End If
            Next


            Dbl_SumaDias = Dbl_SumaDias + IIf(bol_semestreFull_, 0, 30)
            'Dbl_SumaDias = 107
            get_Grati_MesesTrabajados = Math.Round((Dbl_SumaDias / 30), 2)
            'get_Grati_MesesTrabajados = 7
            If get_Grati_MesesTrabajados > 6 Then get_Grati_MesesTrabajados = 6

        End Function

        Private Function get_Grati_RiesgoCaja(ByVal personalBE As BE.PlanillaBE.SG_PL_TB_PERSONAL, ByVal ayo_ As Integer, ByVal mes_ As Integer) As Double
            get_Grati_RiesgoCaja = 0
            Dim str_query As String
            Dim auxi_ayo As Integer = ayo_
            Dim auxi_mes As Integer = mes_ - 1
            Dim resultado As Double = 0

            If auxi_mes = 1 Then
                auxi_mes = 12
                auxi_ayo = auxi_ayo - 1
            End If

            If mes_ = 12 Then
                auxi_mes = 11
            End If

            If mes_ = 7 Then
                auxi_mes = 6
            End If


            str_query = "SELECT HI_MONTO FROM SG_PL_TB_HISTORIAL   WHERE HI_COD_HD = '103'   AND  YEAR(HI_FEC_OPE) = " & auxi_ayo & " AND  MONTH(HI_FEC_OPE) = " & auxi_mes & " AND HI_ID_PERSONAL = " & personalBE.PE_ID & " ORDER BY HI_FEC_OPE ASC"

            resultado = SqlHelper.ExecuteScalar(Cn, CommandType.Text, str_query)

            Return resultado

        End Function

        Private Function get_Grati_SumaConcepto_6Meses_Atraz(ByVal personalBE As BE.PlanillaBE.SG_PL_TB_PERSONAL, ByVal ayo_ As Integer, ByVal mes_ As Integer, ByVal concepto_ As String)

            Dim StrQuery As String
            Dim IntInicio As Integer
            Dim IntFin As Integer
            Dim Dbl_Sumatoria As Double

            Select Case mes_
                Case 7 'julio
                    IntInicio = 1  'enero
                    IntFin = 6      'junio
                Case 12 'Diciembre
                    IntInicio = 7   'julio
                    IntFin = 12     'diciembre
                Case Else    'No es el mes de Grati
                    IntInicio = 0
                    IntFin = 0
            End Select

            'Inicializamos la sumatoria
            Dbl_Sumatoria = 0
            StrQuery = "SELECT isnull(HI_MONTO,0) as 'MONTO' FROM SG_PL_TB_HISTORIAL where year(hi_fec_ope) = " & ayo_ & " and hi_cod_hd = " & concepto_ & " and  month(hi_fec_ope)  between " & IntInicio & " and " & IntFin & " and HI_ID_PERSONAL = " & personalBE.PE_ID & " order by hi_mes"

            Dim dtt As DataTable = SqlHelper.ExecuteDataset(Cn, CommandType.Text, StrQuery).Tables(0)
            If dtt.Rows.Count > 0 Then Dbl_Sumatoria = dtt.Compute("sum(MONTO)", "")
            dtt.Dispose()

            Return Dbl_Sumatoria

        End Function

        Private Function get_Grati_Prome_HE_Simples(ByVal personalBE As BE.PlanillaBE.SG_PL_TB_PERSONAL, ByVal ayo_ As Integer, ByVal mes_ As Integer) As Double
            get_Grati_Prome_HE_Simples = 0
            Dim Dbl_Valor_135 As Double

            If get_Grati_Verificar_Tiene3Meses(personalBE, ayo_, mes_, "113") Or get_Grati_Verificar_Tiene3Meses(personalBE, ayo_, mes_, "114") Then
                Dbl_Valor_135 = get_Grati_SumaConceptoRango(personalBE, ayo_, mes_, "113")
                Return Dbl_Valor_135
            End If
        End Function

        Private Function get_Grati_Prome_HE_Dobles(ByVal personalBE As BE.PlanillaBE.SG_PL_TB_PERSONAL, ByVal ayo_ As Integer, ByVal mes_ As Integer) As Double
            get_Grati_Prome_HE_Dobles = 0
            Dim Dbl_Valor As Double

            If get_Grati_Verificar_Tiene3Meses(personalBE, ayo_, mes_, "113") Or get_Grati_Verificar_Tiene3Meses(personalBE, ayo_, mes_, "114") Then
                Dbl_Valor = get_Grati_SumaConceptoRango(personalBE, ayo_, mes_, "114")
                Return Dbl_Valor
            End If

        End Function

        Private Function get_Grati_Prome_HE_110_Ecogest(ByVal personalBE As BE.PlanillaBE.SG_PL_TB_PERSONAL, ByVal ayo_ As Integer, ByVal mes_ As Integer) As Double
            get_Grati_Prome_HE_110_Ecogest = 0
            Dim Dbl_Valor As Double

            If get_Grati_Verificar_Tiene3Meses(personalBE, ayo_, mes_, "110") Then
                Dbl_Valor = get_Grati_SumaConceptoRango(personalBE, ayo_, mes_, "110")
                Return Dbl_Valor
            End If

        End Function

        Private Function get_Grati_Verificar_Tiene3Meses(ByVal personalBE As BE.PlanillaBE.SG_PL_TB_PERSONAL, ByVal ayo_ As Integer, ByVal mes_ As Integer, ByVal concepto_ As String) As Boolean
            get_Grati_Verificar_Tiene3Meses = False

            Dim i As Integer
            Dim contador As Integer
            Dim StrQuery As String
            Dim IntInicio As Integer
            Dim IntFin As Integer

            Select Case mes_
                Case 7          'abril
                    IntInicio = 1      'novimebre del año pasado
                    IntFin = 6         'abril del presente
                Case 12         'Diciembre
                    IntInicio = 7       'mayo del presente
                    IntFin = 12         'octubre del presente
                Case Else       'No es el mes de Grati
                    IntInicio = 0
                    IntFin = 0
            End Select

            contador = 0
            Dim Ayo_aux As Integer
            Dim Mes_Aux As Integer
            Ayo_aux = (ayo_ - 1)
            Mes_Aux = 11


            For i = IntInicio To IntFin
                StrQuery = "SELECT COUNT(*) FROM SG_PL_TB_HISTORIAL WHERE HI_ID_PERSONAL = " & personalBE.PE_ID.ToString & " AND YEAR(HI_FEC_OPE)= " & ayo_ & " AND MONTH(HI_FEC_OPE) = " & i & " AND HI_COD_HD = '" & concepto_ & "'"
                If SqlHelper.ExecuteScalar(Cn, CommandType.Text, StrQuery) > 0 Then contador = contador + 1
            Next

            If contador >= 3 Then Return True

        End Function

        Private Function get_Grati_SumaConceptoRango(ByVal personalBE As BE.PlanillaBE.SG_PL_TB_PERSONAL, ByVal ayo_ As Integer, ByVal mes_ As Integer, ByVal concepto_ As String) As Double
            get_Grati_SumaConceptoRango = 0

            Dim IntInicio As Integer
            Dim IntFin As Integer
            Dim Dbl_Sumatoria As Double
            Dim StrQuery As String

            Select Case mes_
                Case 7 'julio
                    IntInicio = 1
                    IntFin = 6
                Case 12 'Diciembre
                    IntInicio = 7
                    IntFin = 12
                Case Else    'No es el mes de Gratificacion
                    IntInicio = 0
                    IntFin = 0
            End Select

            'Inicializamos la sumatoria
            Dbl_Sumatoria = 0

            StrQuery = "SELECT isnull(HI_MONTO,0) as 'MONTO' FROM SG_PL_TB_HISTORIAL where year(hi_fec_ope) = " & ayo_ & " and hi_cod_hd = " & concepto_ & " and  month(hi_fec_ope)  between " & IntInicio & " and " & IntFin & " and HI_ID_PERSONAL = " & personalBE.PE_ID & " and HI_ID_EMPRESA = " & personalBE.PE_ID_EMPRESA.ToString & "  order by hi_mes "

            Dim dtt As DataTable = SqlHelper.ExecuteDataset(Cn, CommandType.Text, StrQuery).Tables(0)
            If dtt.Rows.Count > 0 Then Dbl_Sumatoria = dtt.Compute("sum(MONTO)", "")
            dtt.Dispose()

            Return Dbl_Sumatoria

        End Function

        Private Function get_Grati_Prome_Bonificaciones(ByVal personalBE As BE.PlanillaBE.SG_PL_TB_PERSONAL, ByVal ayo_ As Integer, ByVal mes_ As Integer, ByVal bol_semestre_completo_ As Boolean) As Double
            get_Grati_Prome_Bonificaciones = 0

            Dim Dbl_ValorBon_124 As Double 'Bonificación
            Dim Dbl_ValorBon_104 As Double 'Bonificación
            Dim Dbl_ValorBon_encarga As Double 'encargatura
            Dim Dbl_ValorBon_sobreTasa As Double 'sobre tasa turno noche


            'Solo considero 2 bonificaciones pork otras mas no usan
            'Inicializamos las variables a Cero(0)
            Dbl_ValorBon_124 = 0
            Dbl_ValorBon_104 = 0
            Dbl_ValorBon_encarga = 0
            Dbl_ValorBon_sobreTasa = 0

            'Verificamos el concepto si tiene 3
            '104 concepto de bonificacion
            If get_Grati_Verificar_Tiene3Meses(personalBE, ayo_, mes_, "104") Then
                Dbl_ValorBon_104 = get_Grati_SumaConceptoRango(personalBE, ayo_, mes_, "104")
            End If

            'Verificamos el concepto si tiene 3
            '124 concepto de bonificacion
            If get_Grati_Verificar_Tiene3Meses(personalBE, ayo_, mes_, "124") Then
                Dbl_ValorBon_124 = get_Grati_SumaConceptoRango(personalBE, ayo_, mes_, "124")
            End If


            'Verificamos el concepto si tiene 3
            '131 concepto de bonificacion
            If get_Grati_Verificar_Tiene3Meses(personalBE, ayo_, mes_, "131") Then
                Dbl_ValorBon_124 = get_Grati_SumaConceptoRango(personalBE, ayo_, mes_, "131")
                'If personalBE.PE_ID = 122 Then 'davalos para calc jul2015
                '    Dbl_ValorBon_124 = 8400
                'End If

                'If personalBE.PE_ID = 29 Then 'peña para calc jul2015
                '    Dbl_ValorBon_124 = 9600
                'End If

            End If

            'bono de encargatura, este bono lo calculamos por separado, hay que juntarlo como mejora de este proc.
            'Dbl_ValorBon_encarga = get_Grati_SumaConceptoRango(personalBE, ayo_, mes_, "129")

            'sobre tasa turno noche
            Dbl_ValorBon_sobreTasa = get_Grati_SumaConceptoRango(personalBE, ayo_, mes_, "111")


            Return Math.Round((Dbl_ValorBon_104 + Dbl_ValorBon_124 + Dbl_ValorBon_encarga + Dbl_ValorBon_sobreTasa) / IIf(bol_semestre_completo_, 6, 5), 2)

        End Function

        Public Function get_Cts_x_Personal(ByVal personalBE As BE.PlanillaBE.SG_PL_TB_PERSONAL, ByVal ayo_ As Integer, ByVal mes_ As Integer) As List(Of Double)

            Dim Dbl_Remu_Basica As Double
            Dim Dbl_AsigFamiliar As Double
            Dim Dbl_Pro_HE_Simple As Double
            Dim Dbl_Pro_HE_Dobles As Double
            Dim Dbl_PromedioHE As Double
            Dim Dbl_Pro_Boni As Double
            Dim Dbl_Ultima_Grati As Double = 0
            Dim Dbl_MesesTrabajados As Double
            Dim Dbl_Total_Computable As Double
            Dim Int_Num_Meses_Ayo As Integer
            Dim Dbl_Riesgo_Caja As Double
            Dim Dbl_Remu_Variable As Double
            Dim Dbl_Horas_Ucin As Double
            Dim Dbl_Horas_Normal As Double
            Dim Dbl_Horas_Intermedio As Double
            Dim Dbl_Refrigerio As Double
            Dim Dbl_Promedio_Refrigerio As Double
            Dim Dbl_CompraVta_Vaca As Double
            Dim Dbl_BonoEncargatura As Double
            Dim Dbl_total_parcial As Double

            Int_Num_Meses_Ayo = 12
            Dbl_Remu_Variable = 0

            If personalBE.PE_ID_TIPO_PER = 1 Then


                Dbl_Remu_Basica = personalBE.PE_IMPORTE_REMUNERACION
                'Dbl_Remu_Basica = get_Concepto_Boleta(personalBE.PE_ID, ayo_, mes_ - 1, "101")
                'Dbl_Remu_Basica += get_Concepto_Boleta(personalBE.PE_ID, ayo_, mes_ - 1, "126")
                'get_Concepto_Boleta


                Dbl_AsigFamiliar = get_Cts_AsignacionFamiliar(personalBE)
                Dbl_BonoEncargatura = get_Cts_Prome_Bono_Encargatura(personalBE, ayo_, mes_)
                Dbl_Riesgo_Caja = get_Cts_Suma_RiesgoCaja(personalBE, ayo_, mes_)
                Dbl_Riesgo_Caja = Dbl_Riesgo_Caja / 6


                'para el caso de las empresas GINEFERT,GESTAR Y GINECOLOGIA Y FERTILIDAD
                'esto para el caso de las chicas que trabajan en el consultorio
                Select Case personalBE.PE_ID_EMPRESA
                    Case 3, 4, 5
                        Dbl_Remu_Variable = get_Cts_Prome_Remuneracion_Variable(personalBE, ayo_, mes_)
                        Dbl_CompraVta_Vaca = get_Cts_SumaConceptoRango(personalBE, ayo_, mes_, "107")
                        Dbl_Remu_Variable += Dbl_CompraVta_Vaca
                End Select

                'Obtenemos las horas extras simples
                Dbl_Pro_HE_Simple = get_Cts_Prome_HE_Simples(personalBE, ayo_, mes_)

                'Obtenemos las horas extras Dobles
                Dbl_Pro_HE_Dobles = get_Cts_Prome_HE_Dobles(personalBE, ayo_, mes_)

                'Obtenemos elpromedio de la HE-sumamos horas y dividimos /6
                Dbl_PromedioHE = Math.Round((Dbl_Pro_HE_Simple + Dbl_Pro_HE_Dobles) / 6, 2)

                'Obtenemos el promedio de las Bonificaciones
                Dbl_Pro_Boni = get_Cts_Prome_Bonificaciones(personalBE, ayo_, mes_)

                'Obtenemos la ultima grati ( si la tuviera ojo!)
                Dbl_Ultima_Grati = get_Cts_Ultima_Grati(personalBE, ayo_, mes_)

                'Refrigerio
                Dbl_Refrigerio = get_Cts_SumaConceptoRango(personalBE, ayo_, mes_, "105")
                Dbl_Promedio_Refrigerio = Math.Round((Dbl_Refrigerio) / 6, 2)

                'Obtenemos los meses trabajados
                Dbl_MesesTrabajados = get_Cts_MesesTrabajados(personalBE, ayo_, mes_)

                Dbl_Ultima_Grati = Math.Round(Dbl_Ultima_Grati / 6, 2)


                'Sumamos todas las varaiables
                Dbl_Total_Computable = (Dbl_Remu_Basica + Dbl_AsigFamiliar + Dbl_Riesgo_Caja + Dbl_Remu_Variable + Dbl_Ultima_Grati + Dbl_Pro_Boni + Dbl_PromedioHE + Dbl_BonoEncargatura + Dbl_Promedio_Refrigerio)
                Dbl_total_parcial = Dbl_Total_Computable
                Dbl_Total_Computable = (Dbl_Total_Computable / Int_Num_Meses_Ayo) * Dbl_MesesTrabajados
                Dbl_Total_Computable = Math.Round(Dbl_Total_Computable, 2)

            Else

                Dim dbl_promedio As Double
                Dim dbl_suma_remu_basi As Double

                Dbl_Remu_Basica = get_Cts_SumaConceptoRango(personalBE, ayo_, mes_, "119")
                Dbl_Horas_Ucin = get_Cts_SumaConceptoRango(personalBE, ayo_, mes_, "115")
                Dbl_Horas_Normal = get_Cts_SumaConceptoRango(personalBE, ayo_, mes_, "130")
                Dbl_Horas_Intermedio = get_Cts_SumaConceptoRango(personalBE, ayo_, mes_, "117")
                Dbl_CompraVta_Vaca = get_Cts_SumaConceptoRango(personalBE, ayo_, mes_, "107")
                dbl_suma_remu_basi = Dbl_Remu_Basica + Dbl_Horas_Ucin + Dbl_Horas_Normal + Dbl_Horas_Intermedio + Dbl_CompraVta_Vaca


                Dbl_Refrigerio = get_Cts_SumaConceptoRango(personalBE, ayo_, mes_, "105")


                Dbl_AsigFamiliar = get_Cts_SumaConceptoRango(personalBE, ayo_, mes_, "102")
                Dbl_PromedioHE = 0


                'Obtenemos la ultima grati ( si la tuviera ojo!)
                Dbl_Ultima_Grati = get_Cts_Ultima_Grati(personalBE, ayo_, mes_)
                Dbl_Ultima_Grati = Math.Round(Dbl_Ultima_Grati / 6, 2)

                'Obtenemos los meses trabajados
                Dbl_MesesTrabajados = get_Cts_MesesTrabajados(personalBE, ayo_, mes_)
                Dbl_Promedio_Refrigerio = Math.Round((Dbl_Refrigerio) / Dbl_MesesTrabajados, 2)


                dbl_promedio = (Dbl_Remu_Basica + Dbl_AsigFamiliar + Dbl_Horas_Ucin + Dbl_Horas_Normal + Dbl_Horas_Intermedio + Dbl_CompraVta_Vaca) / Dbl_MesesTrabajados
                dbl_promedio = dbl_promedio + Dbl_Ultima_Grati + Dbl_Promedio_Refrigerio
                Dbl_total_parcial = dbl_promedio

                Dbl_Total_Computable = (dbl_promedio / Int_Num_Meses_Ayo) * Dbl_MesesTrabajados
                Dbl_Total_Computable = Math.Round(Dbl_Total_Computable, 2)


                Dbl_Remu_Basica = dbl_suma_remu_basi


            End If


            Dim ls_cts As New List(Of Double)


            'Select Case personalBE.PE_ID

            'Case 194 'angeles chero
            '    ls_cts.Add(613.5) 'Dbl_Remu_Basica
            '    ls_cts.Add(0) 'Dbl_AsigFamiliar
            '    ls_cts.Add(0) 'Dbl_Riesgo_Caja
            '    ls_cts.Add(0) 'Dbl_PromedioHE
            '    ls_cts.Add(0) 'Dbl_Pro_Boni
            '    ls_cts.Add(103.17) 'Dbl_Ultima_Grati
            '    ls_cts.Add(6) 'Dbl_MesesTrabajados
            '    ls_cts.Add(406.67) 'Dbl_Total_Computable
            '    ls_cts.Add(0) 'Dbl_Remu_Variable
            '    ls_cts.Add(96.67) 'Dbl_Promedio_Refrigerio
            '    ls_cts.Add(813.34) 'Dbl_total_parcial
            '    ls_cts.Add(0) 'Dbl_BonoEncargatura


            'Case 122 'Rocio Davalos

            '    ls_cts.Add(3600) 'Dbl_Remu_Basica
            '    ls_cts.Add(75) 'Dbl_AsigFamiliar
            '    ls_cts.Add(0) 'Dbl_Riesgo_Caja
            '    ls_cts.Add(0) 'Dbl_PromedioHE
            '    ls_cts.Add(1400) 'Dbl_Pro_Boni
            '    ls_cts.Add(833.33) 'Dbl_Ultima_Grati
            '    ls_cts.Add(6) 'Dbl_MesesTrabajados
            '    ls_cts.Add(2954.17) 'Dbl_Total_Computable
            '    ls_cts.Add(0) 'Dbl_Remu_Variable
            '    ls_cts.Add(0) 'Dbl_Promedio_Refrigerio
            '    ls_cts.Add(5908.33) 'Dbl_total_parcial
            '    ls_cts.Add(0) 'Dbl_BonoEncargatura

            'Case 104 'gamboa malpartida

            '    ls_cts.Add(950) 'Dbl_Remu_Basica
            '    ls_cts.Add(75) 'Dbl_AsigFamiliar
            '    ls_cts.Add(0) 'Dbl_Riesgo_Caja
            '    ls_cts.Add(0) 'Dbl_PromedioHE
            '    ls_cts.Add(0) 'Dbl_Pro_Boni
            '    ls_cts.Add(214.13) 'Dbl_Ultima_Grati
            '    ls_cts.Add(6) 'Dbl_MesesTrabajados
            '    ls_cts.Add(631.23) 'Dbl_Total_Computable
            '    ls_cts.Add(0) 'Dbl_Remu_Variable
            '    ls_cts.Add(23.33) 'Dbl_Promedio_Refrigerio
            '    ls_cts.Add(1262.46) 'Dbl_total_parcial
            '    ls_cts.Add(0) 'Dbl_BonoEncargatura

            'Case 42 'Olga Jimenez

            '    ls_cts.Add(950) 'Dbl_Remu_Basica
            '    ls_cts.Add(0) 'Dbl_AsigFamiliar
            '    ls_cts.Add(0) 'Dbl_Riesgo_Caja
            '    ls_cts.Add(205.17) 'Dbl_PromedioHE
            '    ls_cts.Add(0) 'Dbl_Pro_Boni
            '    ls_cts.Add(0) 'Dbl_Ultima_Grati
            '    ls_cts.Add(1) 'Dbl_MesesTrabajados
            '    ls_cts.Add(107.93) 'Dbl_Total_Computable
            '    ls_cts.Add(0) 'Dbl_Remu_Variable
            '    ls_cts.Add(140) 'Dbl_Promedio_Refrigerio
            '    ls_cts.Add(1295.17) 'Dbl_total_parcial
            '    ls_cts.Add(0) 'Dbl_BonoEncargatura


            '    Case Else 'caso en el que todos estan bien

            '        ls_cts.Add(Dbl_Remu_Basica)
            '        ls_cts.Add(Dbl_AsigFamiliar)
            '        ls_cts.Add(Dbl_Riesgo_Caja)
            '        ls_cts.Add(Dbl_PromedioHE)
            '        ls_cts.Add(Dbl_Pro_Boni)
            '        ls_cts.Add(Dbl_Ultima_Grati)
            '        ls_cts.Add(Dbl_MesesTrabajados)
            '        ls_cts.Add(Dbl_Total_Computable)
            '        ls_cts.Add(Dbl_Remu_Variable)
            '        ls_cts.Add(Dbl_Promedio_Refrigerio)
            '        ls_cts.Add(Dbl_total_parcial)
            '        ls_cts.Add(Dbl_BonoEncargatura)

            'End Select

            ls_cts.Add(Dbl_Remu_Basica) '0
            ls_cts.Add(Dbl_AsigFamiliar) '1
            ls_cts.Add(Dbl_Riesgo_Caja)
            ls_cts.Add(Dbl_PromedioHE)
            ls_cts.Add(Dbl_Pro_Boni)
            ls_cts.Add(Dbl_Ultima_Grati) '5
            ls_cts.Add(Dbl_MesesTrabajados)
            ls_cts.Add(Dbl_Total_Computable)
            ls_cts.Add(Dbl_Remu_Variable) '8
            ls_cts.Add(Dbl_Promedio_Refrigerio)
            ls_cts.Add(Dbl_total_parcial)
            ls_cts.Add(Dbl_BonoEncargatura)
            ls_cts.Add(Dbl_CompraVta_Vaca) '12





            Return ls_cts

        End Function

        Private Function get_Concepto_Boleta(ByVal Int_Emp_ As Integer, ByVal Int_Ayo_ As Integer, ByVal Int_Mes_ As Integer, ByVal concepto_ As String) As Double
            get_Concepto_Boleta = 0
            Dim Query As String = "select isnull(sum(hi_monto),0) from sg_pl_tb_historial where year(hi_fec_ope)=" & Int_Ayo_ & " and month(hi_fec_ope) = " & Int_Mes_ & " and hi_id_personal = '" & Int_Emp_ & "' and hi_cod_hd = '" & concepto_ & "'"
            Return SqlHelper.ExecuteScalar(Cn, CommandType.Text, Query)
        End Function

        Private Function get_Cts_MesesTrabajados(ByVal personalBE As BE.PlanillaBE.SG_PL_TB_PERSONAL, ByVal ayo_ As Integer, ByVal mes_ As Integer) As Double
            get_Cts_MesesTrabajados = 0

            Dim IntInicio As Integer
            Dim IntFin As Integer
            Dim Dbl_SumaDias As Double
            Dim ls_meses As New List(Of Integer)

            'llenamos para el caso de personal por horas y cuando sea el periodo de Noviembre a Mayo.
            ls_meses.Add(11)
            ls_meses.Add(12)
            ls_meses.Add(1)
            ls_meses.Add(2)
            ls_meses.Add(3)
            ls_meses.Add(4)

            Dbl_SumaDias = 0

            Select Case mes_
                Case 5              'Mayo
                    IntInicio = 11  'noviembre ayo anterior
                    IntFin = 4      'abril
                Case 11             'Noviembre
                    IntInicio = 5   'mayo
                    IntFin = 10     'octubre
                Case Else           'No es el mes de CTS
                    IntInicio = 0
                    IntFin = 0
            End Select

            'Traemos los registros del rango de meses para ver sus horas
            Dim fecha_1 As Date = "01/11/" & (ayo_ - 1).ToString
            Dim fecha_2 As Date = "30/04/" & ayo_.ToString

            Select Case mes_
                Case 5              'Mayo
                    fecha_1 = "01/11/" & (ayo_ - 1).ToString  'noviembre ayo anterior
                    fecha_2 = "30/04/" & ayo_.ToString      'abril
                Case 11             'Noviembre
                    fecha_1 = "01/05/" & ayo_.ToString    'mayo
                    fecha_2 = "31/10/" & ayo_.ToString      'octubre
            End Select



            '30/10/13 - el proc. "SG_PL_SP_S_DIASTRABAJADOS" se modifico para que obtengas los dias trabajdos y vacaciones en un mismo select.

            Dim dtt As DataTable = SqlHelper.ExecuteDataset(Cn, "SG_PL_SP_S_DIASTRABAJADOS", personalBE.PE_ID, ayo_, IntInicio, IntFin, fecha_1, fecha_2, personalBE.PE_ID_EMPRESA).Tables(0)
            'Dim dtt As DataTable = SqlHelper.ExecuteDataset(Cn, "SG_PL_SP_S_DIASTRABAJADOS", personalBE.PE_ID, ayo_, 1, 4, "01/01/2015", "30/04/2015", personalBE.PE_ID_EMPRESA).Tables(0)

            Dim mes_aux As Int16 = IntInicio
            Dim ayo_aux As Int16 = fecha_1.Year
            Dim dias_tmp As Double = 0

            If personalBE.PE_ID_TIPO_PER = 1 Then
                For j As Integer = 1 To 6

                    If dtt.Select("HI_MES = " & mes_aux.ToString).Length > 0 Then
                        dias_tmp = dtt.Compute("sum(HI_HORAS)", "HI_MES = " & mes_aux.ToString)
                        Dbl_SumaDias += dias_tmp

                        If mes_aux = 2 Then 'febrero tiene solo 28 dias
                            Dbl_SumaDias += 2
                        End If
                    End If

                    mes_aux += 1
                    If mes_aux = 13 Then
                        mes_aux = 1
                        ayo_aux += 1
                    End If
                Next

            Else

                If IntInicio = 11 Then 'Mayo
                    For Each m As Integer In ls_meses
                        If dtt.Select("HI_MES = " & m.ToString).Length > 0 Then
                            Dbl_SumaDias += 30
                        End If
                    Next
                Else
                    For z As Integer = IntInicio To IntFin
                        If dtt.Select("HI_MES = " & z.ToString).Length > 0 Then
                            Dbl_SumaDias += 30
                        End If
                    Next
                End If
            End If

            'For i As Integer = 0 To dtt.Rows.Count - 1
            '    If dtt.Rows(i)("HI_HORAS") = 0 Then 'Si las horas son 0 entonces consideramos como 30 dias
            '        Dbl_SumaDias += 30

            '    Else 'Si es deferente de 0 sumamos el campo horas k guarda los dias trabajados
            '        Dbl_SumaDias += Val(dtt.Rows(i)("HI_HORAS"))
            '        'buscamos si tiene vacaciones en el mes para sumar los dias de vaca y completar los 30 Dias
            '        Dbl_SumaDias += get_Cts_DiasSuspensiones(personalBE, CDate(dtt.Rows(i)("HI_FEC_OPE")).Year, dtt.Rows(i)("HI_MES"), 1) '1=vacaciones
            '        Dbl_SumaDias += get_Cts_DiasSuspensiones(personalBE, CDate(dtt.Rows(i)("HI_FEC_OPE")).Year, dtt.Rows(i)("HI_MES"), 2) '2=subsidios
            '    End If
            'Next
            'Dbl_SumaDias = 180

            'If personalBE.PE_ID = 187 Then 'Rumualdo_____
            '    Dbl_SumaDias = 138
            'End If
            'Dbl_SumaDias = 108

            get_Cts_MesesTrabajados = Math.Round((Dbl_SumaDias / 30), 2)
            If get_Cts_MesesTrabajados > 6 Then get_Cts_MesesTrabajados = 6
        End Function

        Private Function get_Cts_DiasSuspensiones(ByVal personalBE As BE.PlanillaBE.SG_PL_TB_PERSONAL, ByVal ayo_ As Integer, ByVal mes_ As Integer, ByVal tipoSus As Integer) As Double
            get_Cts_DiasSuspensiones = 0

            Dim func As New LR.Class1
            Dim StrQuery As String
            'StrQuery = "SELECT isnull(SU_DIAS_VACA,0) FROM SG_PL_TB_SUSPENSIONES WHERE SU_ID_PERSONAL = " & personalBE.PE_ID.ToString & " AND SU_ID_TIPO_SUSPENSION = " & tipoSus & " AND  MONTH(SU_FECHA_INI) = " & mes_ & " AND  MONTH(SU_FECHA_FIN) = " & mes_ & " AND YEAR(SU_FECHA_FIN) = " & ayo_
            StrQuery = "SELECT * FROM SG_PL_TB_SUSPENSIONES WHERE SU_ID_PERSONAL = " & personalBE.PE_ID.ToString & " AND SU_ID_TIPO_SUSPENSION = " & tipoSus & " AND  MONTH(SU_FECHA_INI) = " & mes_ & "  AND YEAR(SU_FECHA_INI) = " & ayo_
            Dim dtt As DataTable = SqlHelper.ExecuteDataset(Cn, CommandType.Text, StrQuery).Tables(0)
            Dim diferencia As Integer = 0

            If dtt.Rows.Count > 0 Then
                Dim fecha_ini As Date = dtt(0)("SU_FECHA_INI")
                Dim fecha_fin As Date = dtt(0)("SU_FECHA_FIN")
                Dim ultimo_dia As Date

                If fecha_ini.Month = fecha_fin.Month Then
                    'diferencia = dtt(0)("SU_DIAS_VACA")
                    diferencia = dtt.Compute("sum(SU_DIAS_VACA)", "")

                    GoTo siguiente
                Else
                    ultimo_dia = DateSerial(Year(fecha_ini), Month(fecha_ini) + 1, 0)
                    diferencia = DateDiff(DateInterval.Day, fecha_ini, ultimo_dia) + 1
                End If

                GoTo siguiente


            End If

            StrQuery = "SELECT * FROM SG_PL_TB_SUSPENSIONES WHERE SU_ID_PERSONAL = " & personalBE.PE_ID.ToString & " AND SU_ID_TIPO_SUSPENSION = " & tipoSus & " AND  MONTH(SU_FECHA_FIN) = " & mes_ & "  AND YEAR(SU_FECHA_FIN) = " & ayo_
            dtt = SqlHelper.ExecuteDataset(Cn, CommandType.Text, StrQuery).Tables(0)


            If dtt.Rows.Count > 0 Then

                Dim fecha_ini As Date = dtt(0)("SU_FECHA_INI")
                Dim fecha_fin As Date = dtt(0)("SU_FECHA_FIN")
                Dim primer_dia As Date

                diferencia = 0

                If fecha_ini.Month = fecha_fin.Month Then
                    diferencia = dtt(0)("SU_DIAS_VACA")
                    GoTo siguiente
                Else
                    primer_dia = DateSerial(Year(fecha_fin), Month(fecha_fin) + 0, 1)
                    diferencia = DateDiff(DateInterval.Day, primer_dia, fecha_fin) + 1
                End If

            End If

siguiente:

            get_Cts_DiasSuspensiones = diferencia

        End Function

        Private Function get_Grati_DiasSuspensiones(ByVal personalBE As BE.PlanillaBE.SG_PL_TB_PERSONAL, ByVal ayo_ As Integer, ByVal mes_ As Integer, ByVal tipoSus As Integer) As Double
            get_Grati_DiasSuspensiones = 0

            Dim func As New LR.Class1
            Dim StrQuery As String
            'StrQuery = "SELECT isnull(SU_DIAS_VACA,0) FROM SG_PL_TB_SUSPENSIONES WHERE SU_ID_PERSONAL = " & personalBE.PE_ID.ToString & " AND SU_ID_TIPO_SUSPENSION = " & tipoSus & " AND  MONTH(SU_FECHA_INI) = " & mes_ & " AND  MONTH(SU_FECHA_FIN) = " & mes_ & " AND YEAR(SU_FECHA_FIN) = " & ayo_
            StrQuery = "SELECT * FROM SG_PL_TB_SUSPENSIONES WHERE SU_ID_PERSONAL = " & personalBE.PE_ID.ToString & " AND SU_ID_TIPO_SUSPENSION = " & tipoSus & " AND  MONTH(SU_FECHA_INI) = " & mes_ & "  AND YEAR(SU_FECHA_INI) = " & ayo_
            Dim dtt As DataTable = SqlHelper.ExecuteDataset(Cn, CommandType.Text, StrQuery).Tables(0)
            Dim diferencia As Integer = 0

            If dtt.Rows.Count > 0 Then
                Dim fecha_ini As Date = dtt(0)("SU_FECHA_INI")
                Dim fecha_fin As Date = dtt(0)("SU_FECHA_FIN")
                Dim ultimo_dia As Date

                If fecha_ini.Month = fecha_fin.Month Then
                    diferencia = dtt(0)("SU_DIAS_VACA")
                    GoTo siguiente
                Else
                    ultimo_dia = DateSerial(Year(fecha_fin), Month(fecha_fin) + 1, 0)
                    diferencia = DateDiff(DateInterval.Day, fecha_ini, ultimo_dia) + 1
                End If

                GoTo siguiente


            End If

            StrQuery = "SELECT * FROM SG_PL_TB_SUSPENSIONES WHERE SU_ID_PERSONAL = " & personalBE.PE_ID.ToString & " AND SU_ID_TIPO_SUSPENSION = " & tipoSus & " AND  MONTH(SU_FECHA_FIN) = " & mes_ & "  AND YEAR(SU_FECHA_FIN) = " & ayo_
            dtt = SqlHelper.ExecuteDataset(Cn, CommandType.Text, StrQuery).Tables(0)


            If dtt.Rows.Count > 0 Then

                Dim fecha_ini As Date = dtt(0)("SU_FECHA_INI")
                Dim fecha_fin As Date = dtt(0)("SU_FECHA_FIN")
                Dim primer_dia As Date

                diferencia = 0

                If fecha_ini.Month = fecha_fin.Month Then
                    diferencia = dtt(0)("SU_DIAS_VACA")
                    GoTo siguiente
                Else
                    primer_dia = DateSerial(Year(fecha_fin), Month(fecha_fin) + 0, 1)
                    diferencia = DateDiff(DateInterval.Day, primer_dia, fecha_fin) + 1
                End If

            End If

siguiente:

            get_Grati_DiasSuspensiones = diferencia

        End Function

        Private Function get_Cts_Ultima_Grati(ByVal personalBE As BE.PlanillaBE.SG_PL_TB_PERSONAL, ByVal ayo_ As Integer, ByVal mes_ As Integer) As Double
            get_Cts_Ultima_Grati = 0

            Dim Query As String

            If mes_ = 5 Then
                Query = "SELECT HI_MONTO FROM SG_PL_TB_HISTORIAL WHERE YEAR(HI_FEC_OPE)=" & (ayo_ - 1) & " AND HI_COD_HD=116 AND  MONTH(HI_FEC_OPE) = 12 and HI_ID_EMPRESA = " & personalBE.PE_ID_EMPRESA.ToString & " AND HI_ID_PERSONAL = " & personalBE.PE_ID.ToString
            Else
                Query = "SELECT HI_MONTO FROM SG_PL_TB_HISTORIAL WHERE YEAR(hi_FEC_OPE)=" & ayo_ & " AND hi_COD_HD=116 AND  MONTH(hi_FEC_OPE) = 7  and HI_ID_EMPRESA = " & personalBE.PE_ID_EMPRESA.ToString & " AND HI_ID_PERSONAL = " & personalBE.PE_ID.ToString
            End If

            Dim drr As SqlDataReader = SqlHelper.ExecuteReader(Cn, CommandType.Text, Query)
            If drr.HasRows Then
                drr.Read()
                If drr(0) > 0 Then
                    get_Cts_Ultima_Grati = drr(0)
                End If
            End If

            drr.Close()
            drr = Nothing


        End Function

        Private Function get_Cts_Prome_Remuneracion_Variable(ByVal personalBE As BE.PlanillaBE.SG_PL_TB_PERSONAL, ByVal ayo_ As Integer, ByVal mes_ As Integer) As Double
            'el concepto 120 debe ser fijo para todas las empresas sino debe detallarse en el codigo
            'a la fecha (07/11/12) se esta tomando el codigo 120 como remuneracion variable para todas las empresas
            'para sacar su promedio

            Dim Dbl_Valor As Double
            Dim Dbl_rpta As Double = 0

            Dbl_Valor = get_Cts_SumaConceptoRango(personalBE, ayo_, mes_, "120")

            If Dbl_Valor > 0 Then
                Dbl_rpta = Dbl_Valor / 6
            End If

            Return Dbl_rpta

        End Function

        Private Function get_Grati_Prome_Remuneracion_Variable(ByVal personalBE As BE.PlanillaBE.SG_PL_TB_PERSONAL, ByVal ayo_ As Integer, ByVal mes_ As Integer, ByVal bol_semestre_Complero_ As Boolean, ByVal meses_trabaja_ As Integer) As Double
            'el concepto 120 debe ser fijo para todas las empresas sino debe detallarse en el codigo
            'a la fecha (07/11/12) se esta tomando el codigo 120 como remuneracion variable para todas las empresas
            'para sacar su promedio

            Dim Dbl_Valor As Double
            Dim Dbl_rpta As Double = 0

            Dbl_Valor = get_Grati_SumaConceptoRango(personalBE, ayo_, mes_, "120")

            If personalBE.PE_ID_EMPRESA = 3 Then
                Dbl_Valor += get_Grati_SumaConceptoRango(personalBE, ayo_, mes_, "107")
                Dbl_Valor += get_Grati_SumaConceptoRango(personalBE, ayo_, mes_, "117")
            End If

            If personalBE.PE_ID_EMPRESA = 5 Then
                Dbl_Valor += get_Grati_SumaConceptoRango(personalBE, ayo_, mes_, "117")
            End If


            If Dbl_Valor > 0 Then
                If meses_trabaja_ < 6 Then
                    Dbl_rpta = Dbl_Valor / meses_trabaja_
                Else
                    Dbl_rpta = Dbl_Valor / IIf(bol_semestre_Complero_, 6, 5)
                End If


            End If

            Return Dbl_rpta

        End Function

        Private Function get_Cts_Prome_Bonificaciones(ByVal personalBE As BE.PlanillaBE.SG_PL_TB_PERSONAL, ByVal ayo_ As Integer, ByVal mes_ As Integer) As Double
            get_Cts_Prome_Bonificaciones = 0
            Dim Dbl_ValorBon_124 As Double 'Bonificación exclusividad
            Dim Dbl_ValorBon_104 As Double 'Bonificación
            Dim Dbl_ValorBon_131 As Double 'Bonificación por permanencia

            'Solo considero 2 bonificaciones pork otras mas no usan
            'Inicializamos las variables a Cero(0)
            Dbl_ValorBon_124 = 0
            Dbl_ValorBon_104 = 0

            'Verificamos el concepto si tiene 3
            '104 concepto de bonificacion
            If get_Cts_Verificar_Tiene3Meses(personalBE, ayo_, mes_, "104", "") Then
                Dbl_ValorBon_104 = get_Cts_SumaConceptoRango(personalBE, ayo_, mes_, "104")
            End If

            'Verificamos el concepto si tiene 3
            '124 concepto de bonificacion por exclusividad
            If get_Cts_Verificar_Tiene3Meses(personalBE, ayo_, mes_, "124", "") Then
                Dbl_ValorBon_124 = get_Cts_SumaConceptoRango(personalBE, ayo_, mes_, "124")
            End If

            'Verificamos el concepto si tiene 3
            '131 concepto de bonificacion por permanencia
            If get_Cts_Verificar_Tiene3Meses(personalBE, ayo_, mes_, "131", "") Then
                Dbl_ValorBon_131 = get_Cts_SumaConceptoRango(personalBE, ayo_, mes_, "131")
            End If

            'el importe del bono especial de la ley 29351
            '121 => bono extra 9%
            'Dbl_ValorBon_121 = get_Cts_SumaConceptoRango(personalBE, ayo_, mes_, "121")

            'Prome_Bonificaciones = Round((Dbl_ValorBon_104 + Dbl_ValorBon_124 + Dbl_ValorBon_121) / 6, 2)
            Return Math.Round((Dbl_ValorBon_104 + Dbl_ValorBon_124 + Dbl_ValorBon_131) / 6, 2)


        End Function

        Private Function get_Cts_Prome_Bonifi_Permanencia(ByVal personalBE As BE.PlanillaBE.SG_PL_TB_PERSONAL, ByVal ayo_ As Integer, ByVal mes_ As Integer) As Double
            get_Cts_Prome_Bonifi_Permanencia = 0

            Dim Dbl_ValorBon_131 As Double = 0 'Bonificación por permanencia

            'Verificamos el concepto si tiene 3
            '124 concepto de bonificacion por permanencia
            If get_Cts_Verificar_Tiene3Meses(personalBE, ayo_, mes_, "131", "") Then
                Dbl_ValorBon_131 = get_Cts_SumaConceptoRango(personalBE, ayo_, mes_, "131")
            End If


            'Prome_Bonificaciones = Round((Dbl_ValorBon_104 + Dbl_ValorBon_124 + Dbl_ValorBon_121) / 6, 2)
            Return Math.Round(Dbl_ValorBon_131 / 6, 2)


        End Function

        Private Function get_Cts_Prome_Bono_Encargatura(ByVal personalBE As BE.PlanillaBE.SG_PL_TB_PERSONAL, ByVal ayo_ As Integer, ByVal mes_ As Integer) As Double
            get_Cts_Prome_Bono_Encargatura = 0
            Dim Dbl_BonoEncargatura As Double 'Bonificación


            'Inicializamos las variables a Cero(0)
            Dbl_BonoEncargatura = 0

            'Verificamos el concepto si tiene 3 meses
            '129 Bonificacion por Encargatura
            If get_Cts_Verificar_Tiene3Meses(personalBE, ayo_, mes_, "129", "") Then
                Dbl_BonoEncargatura = get_Cts_SumaConceptoRango(personalBE, ayo_, mes_, "129")
            End If


            'Prome_Bonificaciones = Round((Dbl_ValorBon_104 + Dbl_ValorBon_124 + Dbl_ValorBon_121) / 6, 2)
            Return Math.Round((Dbl_BonoEncargatura) / 6, 2)


        End Function

        Private Function get_Grati_Prome_Bono_Encargatura(ByVal personalBE As BE.PlanillaBE.SG_PL_TB_PERSONAL, ByVal ayo_ As Integer, ByVal mes_ As Integer, ByVal bol_semestre_completo_ As Boolean) As Double
            get_Grati_Prome_Bono_Encargatura = 0
            Dim Dbl_BonoEncargatura As Double 'Bonificación


            'Inicializamos las variables a Cero(0)
            Dbl_BonoEncargatura = 0

            'Verificamos el concepto si tiene 3 meses
            '129 Bonificacion por Encargatura
            If get_Grati_Verificar_Tiene3Meses(personalBE, ayo_, mes_, "129") Then
                Dbl_BonoEncargatura = get_Grati_SumaConceptoRango(personalBE, ayo_, mes_, "129")
            End If


            'Prome_Bonificaciones = Round((Dbl_ValorBon_104 + Dbl_ValorBon_124 + Dbl_ValorBon_121) / 6, 2)
            Return Math.Round((Dbl_BonoEncargatura) / IIf(bol_semestre_completo_, 6, 5), 2)
            'Return Math.Round(Dbl_BonoEncargatura / 6, 2)


        End Function

        Private Function get_Cts_Prome_HE_Simples(ByVal personalBE As BE.PlanillaBE.SG_PL_TB_PERSONAL, ByVal ayo_ As Integer, ByVal mes_ As Integer) As Double
            get_Cts_Prome_HE_Simples = 0
            Dim Dbl_Valor_135 As Double
            Dim Dbl_Valor_125 As Double
            Dim Dbl_Valor_110 As Double = 0
            Dim Dbl_Valor_total As Double = 0


            'If personalBE.PE_ID_EMPRESA = 6 Then
            '    Dbl_Valor_110 = get_Cts_SumaConceptoRango(personalBE, ayo_, mes_, "110")
            'End If

            If get_Cts_Verificar_Tiene3Meses(personalBE, ayo_, mes_, "113", "114") Then
                Dbl_Valor_135 = get_Cts_SumaConceptoRango(personalBE, ayo_, mes_, "113")
                Dbl_Valor_125 = get_Cts_SumaConceptoRango(personalBE, ayo_, mes_, "111")
                Dbl_Valor_total = Dbl_Valor_135 + Dbl_Valor_125
            End If

            Return Dbl_Valor_total + Dbl_Valor_110

        End Function

        Private Function get_Cts_Prome_HE_Dobles(ByVal personalBE As BE.PlanillaBE.SG_PL_TB_PERSONAL, ByVal ayo_ As Integer, ByVal mes_ As Integer) As Double
            get_Cts_Prome_HE_Dobles = 0
            Dim Dbl_Valor As Double

            If get_Cts_Verificar_Tiene3Meses(personalBE, ayo_, mes_, "113", "114") Then
                Dbl_Valor = get_Cts_SumaConceptoRango(personalBE, ayo_, mes_, "114")
                Return Dbl_Valor
            End If

        End Function

        Private Function get_Cts_SumaConceptoRango(ByVal personalBE As BE.PlanillaBE.SG_PL_TB_PERSONAL, ByVal ayo_ As Integer, ByVal mes_ As Integer, ByVal concepto_ As String) As Double
            get_Cts_SumaConceptoRango = 0

            Dim IntInicio As Integer
            Dim IntFin As Integer
            Dim Dbl_Sumatoria As Double


            Select Case mes_
                Case 5 'Mayo
                    IntInicio = 11  'noviembre año anterior
                    IntFin = 4      'abril
                Case 11 'Noviembre
                    IntInicio = 5   'mayo
                    IntFin = 10     'octubre
                Case Else    'No es el mes de CTS
                    IntInicio = 0
                    IntFin = 0
            End Select

            'Inicializamos la sumatoria
            Dbl_Sumatoria = 0


            'Traemos los registros del rango de meses para ver sus horas
            Dim fecha_1 As Date = "01/11/" & (ayo_ - 1).ToString
            Dim fecha_2 As Date = "30/04/" & ayo_.ToString

            Select Case mes_
                Case 5
                    fecha_1 = "01/11/" & (ayo_ - 1).ToString
                    fecha_2 = "30/04/" & ayo_.ToString
                Case 11
                    fecha_1 = "01/05/" & ayo_.ToString
                    fecha_2 = "31/10/" & ayo_.ToString
            End Select

            Dim dtt As DataTable = SqlHelper.ExecuteDataset(Cn, "SG_PL_SP_S_CONCEPTOS_TRABAJADOS", personalBE.PE_ID, ayo_, IntInicio, IntFin, fecha_1, fecha_2, concepto_, personalBE.PE_ID_EMPRESA).Tables(0)
            'Dim dtt As DataTable = SqlHelper.ExecuteDataset(Cn, "SG_PL_SP_S_CONCEPTOS_TRABAJADOS", personalBE.PE_ID, ayo_, 1, 4, "01/01/2015", "30/04/2015", concepto_, personalBE.PE_ID_EMPRESA).Tables(0)


            If dtt.Rows.Count > 0 Then
                Dbl_Sumatoria = dtt.Compute("sum(HI_MONTO)", "")
            End If

            Return Dbl_Sumatoria

        End Function

        Private Function get_Cts_Verificar_Tiene3Meses(ByVal personalBE As BE.PlanillaBE.SG_PL_TB_PERSONAL, ByVal ayo_ As Integer, ByVal mes_ As Integer, ByVal concepto_ As String, ByVal concepto2_ As String) As Boolean
            get_Cts_Verificar_Tiene3Meses = False

            Dim i As Integer
            Dim contador As Integer
            Dim StrQuery As String
            Dim IntInicio As Integer
            Dim IntFin As Integer
            Dim Ayo_aux As Integer
            Dim Mes_Aux As Integer

            Select Case mes_
                Case 5          'abril
                    IntInicio = 5       'novimebre del año pasado
                    IntFin = 10         'abril del presente
                    Ayo_aux = (ayo_ - 1)
                    Mes_Aux = 11
                Case 11         'Noviembre
                    IntInicio = 5       'mayo del presente
                    IntFin = 10         'octubre del presente

                    Ayo_aux = ayo_
                    Mes_Aux = 5

                Case Else       'No es el mes de Grati
                    IntInicio = 0
                    IntFin = 0
            End Select

            contador = 0




            For i = IntInicio To IntFin
                If mes_ = 5 Then  ' mayo
                    If concepto2_ = "" Then
                        StrQuery = "SELECT COUNT(*) FROM SG_PL_TB_HISTORIAL WHERE HI_ID_PERSONAL = " & personalBE.PE_ID.ToString & " AND YEAR(HI_FEC_OPE)= " & Ayo_aux & " AND MONTH(HI_FEC_OPE) = " & Mes_Aux & " AND HI_COD_HD = '" & concepto_ & "' and HI_ID_EMPRESA = " & personalBE.PE_ID_EMPRESA.ToString
                    Else
                        StrQuery = "SELECT COUNT(*) FROM SG_PL_TB_HISTORIAL WHERE HI_ID_PERSONAL = " & personalBE.PE_ID.ToString & " AND YEAR(HI_FEC_OPE)= " & Ayo_aux & " AND MONTH(HI_FEC_OPE) = " & Mes_Aux & " AND HI_COD_HD in (" & concepto_ & "," & concepto2_ & ")  and HI_ID_EMPRESA = " & personalBE.PE_ID_EMPRESA.ToString
                    End If

                    Mes_Aux = Mes_Aux + 1
                    If Mes_Aux = 13 Then
                        Mes_Aux = 1
                        Ayo_aux = Ayo_aux + 1
                    End If
                Else
                    If concepto2_ = "" Then
                        StrQuery = "SELECT COUNT(*) FROM SG_PL_TB_HISTORIAL WHERE HI_ID_PERSONAL = " & personalBE.PE_ID.ToString & " AND YEAR(HI_FEC_OPE)= " & ayo_ & " AND MONTH(HI_FEC_OPE) = " & i & " AND HI_COD_HD = '" & concepto_ & "' and HI_ID_EMPRESA = " & personalBE.PE_ID_EMPRESA.ToString
                    Else
                        StrQuery = "SELECT COUNT(*) FROM SG_PL_TB_HISTORIAL WHERE HI_ID_PERSONAL = " & personalBE.PE_ID.ToString & " AND YEAR(HI_FEC_OPE)= " & ayo_ & " AND MONTH(HI_FEC_OPE) = " & i & " AND HI_COD_HD in (" & concepto_ & "," & concepto2_ & ") and HI_ID_EMPRESA = " & personalBE.PE_ID_EMPRESA.ToString
                    End If

                End If

                If SqlHelper.ExecuteScalar(Cn, CommandType.Text, StrQuery) > 0 Then contador = contador + 1
            Next

            If contador >= 3 Then Return True

        End Function

        Private Function get_Cts_Suma_RiesgoCaja(ByVal personalBE As BE.PlanillaBE.SG_PL_TB_PERSONAL, ByVal ayo_ As Integer, ByVal mes_ As Integer) As Double
            get_Cts_Suma_RiesgoCaja = 0

            Dim IntInicio As Integer
            Dim IntFin As Integer
            Dim Dbl_Sumatoria As Double


            Select Case mes_
                Case 5 'Mayo
                    IntInicio = 11  'noviembre año anterior
                    IntFin = 4      'abril
                Case 11 'Diciembre
                    IntInicio = 5   'mayo
                    IntFin = 10     'octubre
                Case Else    'No es el mes de CTS
                    IntInicio = 0
                    IntFin = 0
            End Select


            'Inicializamos la sumatoria
            Dbl_Sumatoria = 0

            'Traemos los registros del rango de meses para ver sus horas
            Dim fecha_1 As Date = "01/11/" & (ayo_ - 1).ToString
            Dim fecha_2 As Date = "30/04/" & ayo_.ToString

            Select Case mes_
                Case 5
                    fecha_1 = "01/11/" & (ayo_ - 1).ToString
                    fecha_2 = "30/04/" & ayo_.ToString
                Case 11
                    fecha_1 = "01/05/" & ayo_.ToString
                    fecha_2 = "31/10/" & ayo_.ToString
            End Select

            Dim dtt As DataTable = SqlHelper.ExecuteDataset(Cn, "SG_PL_SP_S_CONCEPTOS_TRABAJADOS", personalBE.PE_ID, _
                                                            ayo_, IntInicio, IntFin, fecha_1, fecha_2, _
                                                            "103", personalBE.PE_ID_EMPRESA).Tables(0)

            If dtt.Rows.Count > 0 Then
                Dbl_Sumatoria = dtt.Compute("sum(HI_MONTO)", "")
            End If

            Return Dbl_Sumatoria

        End Function

        Private Function get_Cts_AsignacionFamiliar(ByVal personalBE As BE.PlanillaBE.SG_PL_TB_PERSONAL) As Double
            get_Cts_AsignacionFamiliar = 0
            If personalBE.PE_NUM_HIJOS > 0 Then
                Dim query As String = String.Format("SELECT isnull(CO_VALOR,0) FROM SG_PL_TB_CONCEPTOS WHERE CO_ID_EMPRESA = {0} AND CO_ID = '102'", personalBE.PE_ID_EMPRESA)
                Return SqlHelper.ExecuteScalar(Cn, CommandType.Text, query)
            End If
        End Function

        Private Function get_Grati_AsignacionFamiliar(ByVal personalBE As BE.PlanillaBE.SG_PL_TB_PERSONAL) As Double
            get_Grati_AsignacionFamiliar = 0
            If personalBE.PE_NUM_HIJOS > 0 Then
                Dim query As String = String.Format("SELECT isnull(CO_VALOR,0) FROM SG_PL_TB_CONCEPTOS WHERE CO_ID_EMPRESA = {0} AND CO_ID = '102'", personalBE.PE_ID_EMPRESA)
                Return SqlHelper.ExecuteScalar(Cn, CommandType.Text, query)
            End If
        End Function

        Public Function get_Dsto_5taCat(ByVal personalBE As BE.PlanillaBE.SG_PL_TB_PERSONAL, ByVal ayo_ As Integer, ByVal mes_ As Integer) As Decimal

            Dim dbl_remu_pagada_Enmes As Double = 0
            Dim dbl_remu_pagada_Enmes_aux As Double = 0
            Dim dbl_Valor_UIT As Double = 0
            Dim dbl_Renta_Neta_Anual_Proyectada As Double = 0
            Dim dbl_Renta_Bruta_Anual_Proyec As Double = 0
            Dim dbl_Impuesto As Decimal = 0
            Dim dbl_valor_grati As Double = 0
            Dim dbl_valor_Bono9 As Double = 0
            Dim dbl_retencion_ant As Double = 0
            Dim dbl_tasa_escala As Double = 0
            Dim dbl_tmp_valor_conEscala As Double = 0
            Dim dbl_tmp_importe_extraordi As Double = 0
            Dim int_meses_concluir_ayo As Integer = 0
            Dim dbl_remu_otrosIng_meses_ant As Double = 0

            Select Case mes_
                Case 1
                    int_meses_concluir_ayo = 12
                Case 2
                    int_meses_concluir_ayo = 11
                Case 3
                    int_meses_concluir_ayo = 10
                Case 4
                    int_meses_concluir_ayo = 9
                Case 5
                    int_meses_concluir_ayo = 8
                Case 6
                    int_meses_concluir_ayo = 7
                Case 7
                    int_meses_concluir_ayo = 6
                Case 8
                    int_meses_concluir_ayo = 5
                Case 9
                    int_meses_concluir_ayo = 4
                Case 10
                    int_meses_concluir_ayo = 3
                Case 11
                    int_meses_concluir_ayo = 2
                Case 12
                    int_meses_concluir_ayo = 1
            End Select

            dbl_tmp_importe_extraordi = 0
            dbl_tmp_valor_conEscala = 0
            dbl_Valor_UIT = get_UIT(personalBE.PE_ID_EMPRESA)


            'PE_ES_RIA => remuneracion integral 
            If personalBE.PE_ES_RIA = 1 Then
                dbl_remu_pagada_Enmes = qta12_Suma_RemuOrdinaria_RIA(personalBE.PE_ID, ayo_, mes_, personalBE.PE_ID_EMPRESA)
            Else
                dbl_remu_pagada_Enmes = qta12_Suma_RemuOrdinaria(personalBE.PE_ID, ayo_, mes_, personalBE.PE_ID_EMPRESA)
                dbl_remu_pagada_Enmes_aux = dbl_remu_pagada_Enmes
                'dbl_remu_pagada_Enmes = personalBE.PE_IMPORTE_REMUNERACION
            End If

            dbl_remu_pagada_Enmes = dbl_remu_pagada_Enmes * int_meses_concluir_ayo


            If personalBE.PE_ES_RIA = 1 Then
                dbl_valor_grati = 0
            Else
                If mes_ = 12 Or mes_ = 7 Then
                    'sacamos de la boleta
                    dbl_valor_grati = qta12_get_MontoGrati_boleta(personalBE.PE_ID, ayo_, mes_, personalBE.PE_ID_EMPRESA)
                Else
                    dbl_valor_grati = (dbl_remu_pagada_Enmes_aux * IIf(mes_ > 7, 1, 2)) 'julio y diciembre 
                End If

            End If

            If personalBE.PE_ES_RIA = 1 Then
                dbl_remu_otrosIng_meses_ant = qta12_Suma_Remuneracion_Ant_RIA(personalBE.PE_ID, ayo_, mes_, personalBE.PE_ID_EMPRESA)
            Else
                dbl_remu_otrosIng_meses_ant = qta12_Suma_Remuneracion_Ant(personalBE.PE_ID, ayo_, mes_, personalBE.PE_ID_EMPRESA)
            End If

            dbl_valor_Bono9 = qta12_get_MontoBono9_boleta(personalBE.PE_ID, ayo_, mes_, personalBE.PE_ID_EMPRESA)


            dbl_Renta_Bruta_Anual_Proyec = dbl_remu_pagada_Enmes + dbl_valor_grati + dbl_remu_otrosIng_meses_ant + dbl_valor_Bono9




            dbl_Renta_Neta_Anual_Proyectada = dbl_Renta_Bruta_Anual_Proyec - (dbl_Valor_UIT * 7)

            If dbl_Renta_Neta_Anual_Proyectada < 0 Then GoTo salida1

            dbl_tmp_valor_conEscala = qta12_Escala_UIT(dbl_Renta_Neta_Anual_Proyectada, dbl_tasa_escala, personalBE.PE_ID_EMPRESA)
            dbl_Impuesto = dbl_tmp_valor_conEscala

            Select Case mes_

                Case 1 To 3   ' Ene - Marzo
                    dbl_Impuesto = (dbl_Impuesto / 12)


                Case 4        ' Abril
                    'Retencion hasta Marzo
                    dbl_retencion_ant = qta12_Suma_Retenciones_Ant(personalBE.PE_ID, ayo_, 3, personalBE.PE_ID_EMPRESA)
                    dbl_Impuesto = (dbl_Impuesto - dbl_retencion_ant) / 9


                Case 5 To 7   ' Mayo - Julio
                    'Retencion hasta Abril
                    dbl_retencion_ant = qta12_Suma_Retenciones_Ant(personalBE.PE_ID, ayo_, 4, personalBE.PE_ID_EMPRESA)
                    dbl_Impuesto = (dbl_Impuesto - dbl_retencion_ant) / 8


                Case 8        ' Agosto
                    'Retencion hasta Julio
                    dbl_retencion_ant = qta12_Suma_Retenciones_Ant(personalBE.PE_ID, ayo_, 7, personalBE.PE_ID_EMPRESA)
                    dbl_Impuesto = (dbl_Impuesto - dbl_retencion_ant) / 5


                Case 9 To 11  ' Sept - Nov.
                    'Retencion hasta Agosto
                    dbl_retencion_ant = qta12_Suma_Retenciones_Ant(personalBE.PE_ID, ayo_, 8, personalBE.PE_ID_EMPRESA)
                    dbl_Impuesto = (dbl_Impuesto - dbl_retencion_ant) / 4


                Case 12       ' Diciembre
                    'Retencion hasta Enero
                    dbl_retencion_ant = qta12_Suma_Retenciones_Ant(personalBE.PE_ID, ayo_, 11, personalBE.PE_ID_EMPRESA)
                    dbl_Impuesto = (dbl_Impuesto - dbl_retencion_ant)

            End Select


            dbl_tmp_importe_extraordi = 0

            If qta12_Tiene_Remu_Extraordinaria(personalBE, ayo_, mes_, dbl_tmp_importe_extraordi) Then
                dbl_tmp_importe_extraordi = (dbl_tmp_importe_extraordi * dbl_tasa_escala)
                dbl_Impuesto = dbl_Impuesto + dbl_tmp_importe_extraordi
            End If

            If dbl_Impuesto < 0 Then
                dbl_Impuesto = 0
            End If
salida1:
            dbl_Impuesto = Math.Round(dbl_Impuesto, 2, MidpointRounding.AwayFromZero)
            Return dbl_Impuesto

        End Function

        Private Function qta12_Tiene_Remu_Extraordinaria(ByVal perosnal_ As BE.PlanillaBE.SG_PL_TB_PERSONAL, ByVal Int_Ayo_ As Integer, ByVal Int_Mes_ As Integer, ByRef remu_extraordi As Double) As Boolean
            qta12_Tiene_Remu_Extraordinaria = False
            Dim Query As String = "select count(*) from sg_pl_tb_historial where year(hi_fec_ope) = " & Int_Ayo_.ToString & " and month(hi_fec_ope) = " & Int_Mes_.ToString & " and hi_id_personal = '" & perosnal_.PE_ID.ToString & "' and hi_cod_hd in ('118','113') "
            Dim resp As Integer = SqlHelper.ExecuteScalar(Cn, CommandType.Text, Query)

            If resp > 0 Then
                Query = "select isnull(sum(hi_monto),0) from sg_pl_tb_historial where year(hi_fec_ope) = " & Int_Ayo_.ToString & " and month(hi_fec_ope) = " & Int_Mes_.ToString & " and hi_id_personal = '" & perosnal_.PE_ID.ToString & "' and hi_cod_hd in ('118','113') "
                remu_extraordi = SqlHelper.ExecuteScalar(Cn, CommandType.Text, Query)
                qta12_Tiene_Remu_Extraordinaria = True
            End If

        End Function

        Private Function qta12_Suma_Retenciones_Ant(ByVal Int_Emp_ As Integer, ByVal Int_Ayo_ As Integer, ByVal Int_Mes_Hasta_ As Integer, ByVal empresa_ As Integer) As Double
            qta12_Suma_Retenciones_Ant = 0
            Dim Query As String = "select isnull(sum(hi_monto),0) from sg_pl_tb_historial where year(hi_fec_ope)=" & Int_Ayo_ & " and month(hi_fec_ope) between 1 and " & Int_Mes_Hasta_ & " and hi_id_personal = '" & Int_Emp_ & "' and hi_cod_hd = '204' and hi_id_empresa = " & empresa_.ToString
            Return SqlHelper.ExecuteScalar(Cn, CommandType.Text, Query)
        End Function

        Private Function qta12_Escala_UIT(ByVal Dbl_Importe As Double, ByRef tasa As Double, ByVal empresa_ As Integer) As Double
            qta12_Escala_UIT = 0

            Dim Dbl_UIT As Double
            Dim Dbl_UIT_5 As Double
            Dim Dbl_UIT_20 As Double
            Dim Dbl_UIT_35 As Double
            Dim Dbl_UIT_45 As Double
            Dim ira As Double
            Dim Dbl_importe_auxi As Double


            Dbl_importe_auxi = Dbl_Importe
            Dbl_UIT = UIT_x7(empresa_) / 7
            Dbl_UIT_5 = Dbl_UIT * 5
            Dbl_UIT_20 = Dbl_UIT * 20
            Dbl_UIT_35 = Dbl_UIT * 35
            Dbl_UIT_45 = Dbl_UIT * 45

            Select Case Dbl_Importe
                Case 0 To Dbl_UIT_5
                    tasa = 0.08
                    ira = Math.Round(Dbl_importe_auxi * tasa, 2)

                Case Dbl_UIT_5 To Dbl_UIT_20
                    tasa = 0.08
                    ira = Math.Round(Dbl_UIT_5 * tasa, 2)

                    Dbl_importe_auxi = Dbl_Importe - Dbl_UIT_5
                    tasa = 0.14
                    ira += Math.Round(Dbl_importe_auxi * tasa, 2)



                Case Dbl_UIT_20 To Dbl_UIT_35

                    tasa = 0.08
                    ira = Math.Round(Dbl_UIT_5 * tasa, 2)

                    tasa = 0.14
                    ira += Math.Round(Dbl_UIT_20 * tasa, 2)

                    Dbl_importe_auxi = Dbl_Importe - Dbl_UIT_20
                    tasa = 0.17
                    ira += Math.Round(Dbl_importe_auxi * tasa, 2)



                Case Dbl_UIT_35 To Dbl_UIT_45


                    tasa = 0.08
                    ira = Math.Round(Dbl_UIT_5 * tasa, 2)

                    tasa = 0.14
                    ira += Math.Round(Dbl_UIT_20 * tasa, 2)

                    tasa = 0.17
                    ira += Math.Round(Dbl_UIT_35 * tasa, 2)

                    tasa = 0.2
                    Dbl_importe_auxi = Dbl_Importe - Dbl_UIT_35
                    ira += Math.Round(Dbl_importe_auxi * tasa, 2)



                Case Is > Dbl_UIT_45


                    tasa = 0.08
                    ira = Math.Round(Dbl_UIT_5 * tasa, 2)

                    tasa = 0.14
                    ira += Math.Round(Dbl_UIT_20 * tasa, 2)

                    tasa = 0.17
                    ira += Math.Round(Dbl_UIT_35 * tasa, 2)

                    tasa = 0.2
                    ira += Math.Round(Dbl_UIT_45 * tasa, 2)

                    tasa = 0.3
                    Dbl_importe_auxi = Dbl_Importe - Dbl_UIT_45
                    ira += Math.Round(Dbl_importe_auxi * tasa, 2)


                Case Else
                    qta12_Escala_UIT = Dbl_Importe
                    tasa = 0
            End Select

            'qta12_Escala_UIT = Math.Round(Dbl_Importe * tasa, 2)
            qta12_Escala_UIT = ira

        End Function

        Private Function UIT_x7(ByVal empresa_ As Integer) As Double
            UIT_x7 = 0
            Dim StrQuery As String = "select des_item from tablaprm where nom_tabla='UIT'"
            'Return SqlHelper.ExecuteScalar(Cn, CommandType.Text, StrQuery) * 7
            Dim paraBL As New SG_PL_TB_PARAMETROS
            Dim paraBE As New BE.PlanillaBE.SG_PL_TB_PARAMETROS
            With paraBE
                .AD_TIPO = "PLANI"
                .AD_NOMBRE = "UIT"
                .AD_IDEMPRESA = empresa_
            End With

            Dim dbl_UIT As Double = Val(paraBL.get_Valor(paraBE))

            paraBE = Nothing
            paraBL = Nothing

            Return (dbl_UIT * 7)

        End Function

        Private Function get_UIT(ByVal empresa_ As Integer) As Double
            get_UIT = 0

            Dim paraBL As New SG_PL_TB_PARAMETROS
            Dim paraBE As New BE.PlanillaBE.SG_PL_TB_PARAMETROS
            With paraBE
                .AD_TIPO = "PLANI"
                .AD_NOMBRE = "UIT"
                .AD_IDEMPRESA = empresa_
            End With

            Dim dbl_UIT As Double = Val(paraBL.get_Valor(paraBE))

            paraBE = Nothing
            paraBL = Nothing

            Return dbl_UIT

        End Function

        Private Function qta12_Suma_RemuOrdinaria(ByVal Idpersonal As Integer, ByVal Int_Ayo As Integer, ByVal Int_Mes As Integer, ByVal empresa_ As Integer) As Double
            qta12_Suma_RemuOrdinaria = 0
            Dim Query As String
            '109,106 no son afectosa Quinta(cts, y subsidios respectivamente)

            '118 "UTILIDAD" no se considera en el mes de marzo
            '125 "GRATIFICACIÓN EXTRA"  no se considera en el mes de marzo

            If Int_Mes = 3 Then
                Query = "select isnull(sum(hi_monto),0) from sg_pl_tb_historial where year(hi_fec_ope) = " & Int_Ayo & " and month(hi_fec_ope) = " & Int_Mes & " and hi_iden_hd = 1 and hi_id_personal = " & Idpersonal & " and hi_cod_hd not in('109','106','118','125') and hi_id_empresa = " & empresa_.ToString
            Else
                Query = "select isnull(sum(hi_monto),0) from sg_pl_tb_historial where year(hi_fec_ope) = " & Int_Ayo & " and month(hi_fec_ope) = " & Int_Mes & " and hi_iden_hd = 1 and hi_id_personal = " & Idpersonal & " and hi_cod_hd not in('109','106','116','121','113') and hi_id_empresa = " & empresa_.ToString
            End If

            qta12_Suma_RemuOrdinaria = SqlHelper.ExecuteScalar(Cn, CommandType.Text, Query)

        End Function

        Private Function qta12_Suma_RemuOrdinaria_RIA(ByVal Idpersonal As Integer, ByVal Int_Ayo As Integer, ByVal Int_Mes As Integer, ByVal empresa_ As Integer) As Double
            qta12_Suma_RemuOrdinaria_RIA = 0
            Dim Query As String
            '101+102+116+121
            'no se considera la CTS

            Query = "select isnull(sum(hi_monto),0) from sg_pl_tb_historial where year(hi_fec_ope) = " & Int_Ayo & " and month(hi_fec_ope) = " & Int_Mes & " and hi_iden_hd = 1 and hi_id_personal = " & Idpersonal & " and hi_cod_hd in('101','102','116','121') and hi_id_empresa = " & empresa_.ToString

            qta12_Suma_RemuOrdinaria_RIA = SqlHelper.ExecuteScalar(Cn, CommandType.Text, Query)

        End Function

        Private Function qta12_Suma_Remuneracion_Ant(ByVal Idpersonal As Integer, ByVal Int_Ayo As Integer, ByVal Int_Mes As Integer, ByVal empresa_ As Integer) As Double
            qta12_Suma_Remuneracion_Ant = 0
            Dim Query As String
            '109,106 no son afectosa Quinta(cts, y subsidios respectivamente)
            Query = "select isnull(sum(hi_monto),0) from sg_pl_tb_historial where year(hi_fec_ope) = " & Int_Ayo & " and month(hi_fec_ope) < " & Int_Mes & " and hi_iden_hd = 1 and hi_id_personal = " & Idpersonal & " and hi_cod_hd not in('109','106') and hi_id_empresa = " & empresa_.ToString
            qta12_Suma_Remuneracion_Ant = SqlHelper.ExecuteScalar(Cn, CommandType.Text, Query)

        End Function

        Private Function qta12_get_MontoGrati_boleta(ByVal Idpersonal As Integer, ByVal Int_Ayo As Integer, ByVal Int_Mes As Integer, ByVal empresa_ As Integer) As Double
            qta12_get_MontoGrati_boleta = 0
            Dim Query As String

            Query = "select isnull(hi_monto,0) from sg_pl_tb_historial where year(hi_fec_ope) = " & Int_Ayo & " and month(hi_fec_ope) = " & Int_Mes & " and hi_id_personal = " & Idpersonal & " and hi_cod_hd = '116' and hi_id_empresa = " & empresa_.ToString
            qta12_get_MontoGrati_boleta = SqlHelper.ExecuteScalar(Cn, CommandType.Text, Query)

        End Function

        Private Function qta12_get_MontoBono9_boleta(ByVal Idpersonal As Integer, ByVal Int_Ayo As Integer, ByVal Int_Mes As Integer, ByVal empresa_ As Integer) As Double
            qta12_get_MontoBono9_boleta = 0
            Dim Query As String

            Query = "select isnull(hi_monto,0) from sg_pl_tb_historial where year(hi_fec_ope) = " & Int_Ayo & " and month(hi_fec_ope) = " & Int_Mes & " and hi_id_personal = " & Idpersonal & " and hi_cod_hd = '121' and hi_id_empresa = " & empresa_.ToString
            qta12_get_MontoBono9_boleta = SqlHelper.ExecuteScalar(Cn, CommandType.Text, Query)

        End Function

        Private Function qta12_Suma_Remuneracion_Ant_RIA(ByVal Idpersonal As Integer, ByVal Int_Ayo As Integer, ByVal Int_Mes As Integer, ByVal empresa_ As Integer) As Double
            qta12_Suma_Remuneracion_Ant_RIA = 0
            Dim Query As String
            '109,106 no son afectosa Quinta(cts, y subsidios respectivamente)
            Query = "select isnull(sum(hi_monto),0) from sg_pl_tb_historial where year(hi_fec_ope) = " & Int_Ayo & " and month(hi_fec_ope) < " & Int_Mes & " and hi_iden_hd = 1 and hi_id_personal = " & Idpersonal & " and hi_cod_hd in('101','102','116','121') and hi_id_empresa = " & empresa_.ToString
            qta12_Suma_Remuneracion_Ant_RIA = SqlHelper.ExecuteScalar(Cn, CommandType.Text, Query)

        End Function

        Private Function qta12_Valor_Grati(ByVal Str_Emp As String) As Double
            qta12_Valor_Grati = 0
            Dim Query As String
            'obtenemos el sueldo que gana para tomarlo como su valor grati.
            Query = "select val_hd from hdperson where cod_per='" & Str_Emp & "' and cod_hd = '101'"
            qta12_Valor_Grati = SqlHelper.ExecuteScalar(Cn, CommandType.Text, Query)

        End Function

    End Class

    Public Class Dicon
        Inherits ClsBD
        Public Function get_Personal() As DataTable
            Dim cnDicon As New SqlConnection("server=192.168.1.111;user=sa;pwd=Igf348;Initial catalog=BD_CLINMIRA;Pooling=true; Min Pool Size=5; Max Pool Size=10; Pooling = True")
            cnDicon.Open()
            Dim query As String = "SELECT COD_PER,NOMBRES,APELLIDOS,DNI FROM PERSONAL order by APELLIDOS"
            Return SqlHelper.ExecuteDataset(cnDicon, CommandType.Text, query).Tables(0)
        End Function

        Public Function get_Marcaciones_x_empleado(ByVal empleado_ As Integer, ByVal ayo_ As Integer) As DataTable
            Dim cnDicon As New SqlConnection("server=192.168.1.111;user=sa;pwd=Igf348;Initial catalog=BD_CLINMIRA;Pooling=true; Min Pool Size=5; Max Pool Size=10; Pooling = True")
            cnDicon.Open()
            Dim query As String = "SELECT * FROM MARCACIONES  A WHERE a.COD_PER = " & empleado_.ToString & " AND YEAR(FECHA) = " & ayo_.ToString & " ORDER BY FECHA"
            Return SqlHelper.ExecuteDataset(cnDicon, CommandType.Text, query).Tables(0)
        End Function

        Public Function Tardanzas(ByVal ayo As Integer, ByVal mes As Integer, ByVal ft As Integer, ByVal dni As String, ByVal f_ini_ As Date, ByVal f_fin_ As Date) As DataTable
            Dim cnDicon As New SqlConnection("server=192.168.1.111;user=sa;pwd=Igf348;Initial catalog=BD_CLINMIRA;Pooling=true; Min Pool Size=5; Max Pool Size=10; Pooling = True")
            cnDicon.Open()

            Return SqlHelper.ExecuteDataset(cnDicon, "SG_PL_SP_S_TARDANZA", ayo, mes, ft, dni, f_ini_, f_fin_).Tables(0)

        End Function

        Public Function get_Tardanzas_Detalle(dni_ As String, fec_ini_ As Date, fec_fin_ As Date) As DataTable
            Dim cnDicon As New SqlConnection("server=192.168.1.111;user=sa;pwd=Igf348;Initial catalog=BD_CLINMIRA;Pooling=true; Min Pool Size=5; Max Pool Size=10; Pooling = True")
            cnDicon.Open()
            Return SqlHelper.ExecuteDataset(cnDicon, "SG_PL_SP_S_TARDANZA_DET", dni_, fec_ini_, fec_fin_).Tables(0)
        End Function


        Public Function get_Tardanzas_Detalle_cnx(ByVal cnx_ As SqlClient.SqlConnection, dni_ As String, fec_ini_ As Date, fec_fin_ As Date) As DataTable
            'Dim cnDicon As New SqlConnection("server=serverigf\sqlexpress;user=dicon;pwd=webdicon;Initial catalog=BD_CLINMIRA;Pooling=true; Min Pool Size=5; Max Pool Size=10; Pooling = True")
            'cnx_.Open()
            Return SqlHelper.ExecuteDataset(cnx_, "SG_PL_SP_S_TARDANZA_DET", dni_, fec_ini_, fec_fin_).Tables(0)
        End Function

        Public Function get_Tardanzas_Detalle_Con_cnx(dni_ As String, fec_ini_ As Date, fec_fin_ As Date) As DataTable
            Dim cnDicon As New SqlConnection("server=192.168.1.111;user=sa;pwd=Igf348;Initial catalog=BD_CLINMIRA;Pooling=true; Min Pool Size=5; Max Pool Size=10; Pooling = True")
            cnDicon.Open()
            Return SqlHelper.ExecuteDataset(cnDicon, "SG_PL_SP_S_TARDANZA_DET", dni_, fec_ini_, fec_fin_).Tables(0)
        End Function

        Public Function get_Tardanzas_Reporte(ByVal cnx_ As SqlClient.SqlConnection, ByVal ayo As Integer, ByVal mes As Integer, ByVal ft As Integer, ByVal dni As String, ByVal fecha_ini_ As Date, ByVal fecha_fin_ As Date) As DataTable
            'Dim cnDicon As New SqlConnection("server=serverigf\sqlexpress;user=dicon;pwd=webdicon;Initial catalog=BD_CLINMIRA;Pooling=true; Min Pool Size=5; Max Pool Size=10; Pooling = True")
            'cnDicon.Open()
            Return SqlHelper.ExecuteDataset(cnx_, "SG_PL_SP_S_TARDANZA", ayo, mes, ft, dni, fecha_ini_, fecha_fin_).Tables(0)
        End Function

        Public Function get_Vacaciones_Registradas(ByVal ayo_ As Integer, ByVal mes_ As Integer, ByVal empresa_ As Integer) As DataTable
            Dim cnDicon As New SqlConnection("server=192.168.1.111;user=sa;pwd=Igf348;Initial catalog=BD_CLINMIRA;Pooling=true; Min Pool Size=5; Max Pool Size=10; Pooling = True")
            cnDicon.Open()
            Return SqlHelper.ExecuteDataset(cnDicon, "SG_PL_SP_S_VACA_X_PERIODO", ayo_, mes_, empresa_).Tables(0)
        End Function


    End Class

    Public Class PDT
        Inherits ClsBD
        Dim Str_vRutaPdt As String

        Public Sub New(ByVal empresa_ As Integer)

            Dim paraetrosBL As New SG_PL_TB_PARAMETROS
            Dim paraetrosBE As New BE.PlanillaBE.SG_PL_TB_PARAMETROS
            paraetrosBE.AD_IDEMPRESA = empresa_
            paraetrosBE.AD_TIPO = "RUTA"
            paraetrosBE.AD_NOMBRE = "PDT"

            Str_vRutaPdt = paraetrosBL.get_Valor(paraetrosBE)

            paraetrosBE = Nothing
            paraetrosBL = Nothing

            '"Z:\Reportes_SG\pdt\"
        End Sub

        Public Sub get_Estruc_04(ByVal ayo_ As Integer, ByVal mes_ As Integer, ByVal empresa_ As Integer)
            Dim StrNomArchivo As String
            Dim ARRcadena As String()
            Dim Strdatos As String

            Dim empresaBE As New BE.ContabilidadBE.SG_CO_TB_EMPRESA With {.EM_ID = empresa_}
            Dim empresaBL As New BL.ContabilidadBL.SG_CO_TB_EMPRESA
            empresaBL.getEmpresas_2(empresaBE)

            Dim dt_tmp As DataTable = SqlHelper.ExecuteDataset(Cn, "SG_PL_SP_S_PLAME_04", empresa_).Tables(0)

            StrNomArchivo = Str_vRutaPdt & empresaBE.EM_NOMBRE & "\" & ayo_.ToString & mes_.ToString & "\RP_" & empresaBE.EM_RUC & ".ide"
            If Dir(StrNomArchivo) <> "" Then Kill(StrNomArchivo)
            If Dir(Str_vRutaPdt & empresaBE.EM_NOMBRE & "\" & ayo_.ToString & mes_.ToString, vbDirectory) = "" Then MkDir(Str_vRutaPdt & empresaBE.EM_NOMBRE & "\" & ayo_ & mes_)


            ReDim ARRcadena(0 To dt_tmp.Rows.Count - 1)
            Strdatos = ""

            For i As Integer = 0 To dt_tmp.Rows.Count - 1

                Strdatos = Left(dt_tmp(i)("DP_CODIGO") & Space(2), 2) & "|"
                Strdatos = Strdatos & Trim(dt_tmp(i)("PE_NUM_DOC_PER")) & "|"
                Strdatos = Strdatos & Trim(dt_tmp(i)("PAIS_EMI")) & "|"
                Strdatos = Strdatos & Trim(dt_tmp(i)("PE_FEC_NAC")) & "|"
                Strdatos = Strdatos & Trim(dt_tmp(i)("PE_APE_PAT")) & "|"
                Strdatos = Strdatos & Trim(dt_tmp(i)("PE_APE_MAT")) & "|"
                Strdatos = Strdatos & Trim(dt_tmp(i)("NOMBRES")) & "|"
                Strdatos = Strdatos & Trim(dt_tmp(i)("PE_ID_SEXO")) & "|"
                Strdatos = Strdatos & Trim(dt_tmp(i)("NACIONALIDAD")) & "|"
                Strdatos = Strdatos & Trim(dt_tmp(i)("COD_LARGA_DIS_TEL")) & "|"
                Strdatos = Strdatos & Trim(dt_tmp(i)("NUM_TEL_DIS")) & "|"
                Strdatos = Strdatos & Trim(dt_tmp(i)("EMAIL")) & "|"
                Strdatos = Strdatos & Trim(dt_tmp(i)("PE_ID_TIPO_VIA").ToString) & "|"
                Strdatos = Strdatos & Trim(dt_tmp(i)("PE_NOMBRE_VIA")) & "|"
                Strdatos = Strdatos & Trim(dt_tmp(i)("PE_NUMERO_VIA")) & "|"
                Strdatos = Strdatos & Trim(dt_tmp(i)("DEPAR")) & "|"
                Strdatos = Strdatos & Trim(dt_tmp(i)("PE_INTERIOR")) & "|"
                Strdatos = Strdatos & Trim(dt_tmp(i)("MAZANA")) & "|"
                Strdatos = Strdatos & Trim(dt_tmp(i)("LOTE")) & "|"
                Strdatos = Strdatos & Trim(dt_tmp(i)("KILO")) & "|"
                Strdatos = Strdatos & Trim(dt_tmp(i)("BLOCK")) & "|"
                Strdatos = Strdatos & Trim(dt_tmp(i)("ETAPA")) & "|"
                Strdatos = Strdatos & Trim(dt_tmp(i)("PE_ID_TIPO_ZONA").ToString) & "|"
                Strdatos = Strdatos & Trim(dt_tmp(i)("PE_NOMBRE_ZONA")) & "|"
                Strdatos = Strdatos & Trim(dt_tmp(i)("PE_REFERENCIA")) & "|"
                Strdatos = Strdatos & Trim(dt_tmp(i)("PE_UBIGEO")) & "|"
                Strdatos = Strdatos & Trim(dt_tmp(i)("TIPOVIA2")) & "|"
                Strdatos = Strdatos & Trim(dt_tmp(i)("NOMVIA2")) & "|"
                Strdatos = Strdatos & Trim(dt_tmp(i)("NUMVIA2")) & "|"
                Strdatos = Strdatos & Trim(dt_tmp(i)("DEPA2")) & "|"
                Strdatos = Strdatos & Trim(dt_tmp(i)("INTE2")) & "|"
                Strdatos = Strdatos & Trim(dt_tmp(i)("MANZA2")) & "|"
                Strdatos = Strdatos & Trim(dt_tmp(i)("LOTE2")) & "|"
                Strdatos = Strdatos & Trim(dt_tmp(i)("KILO2")) & "|"
                Strdatos = Strdatos & Trim(dt_tmp(i)("BLOCK2")) & "|"
                Strdatos = Strdatos & Trim(dt_tmp(i)("ETAPA2")) & "|"
                Strdatos = Strdatos & Trim(dt_tmp(i)("TIPOZONA2")) & "|"
                Strdatos = Strdatos & Trim(dt_tmp(i)("NOMZONA2")) & "|"
                Strdatos = Strdatos & Trim(dt_tmp(i)("REFE2")) & "|"
                Strdatos = Strdatos & Trim(dt_tmp(i)("UBI2")) & "|"
                Strdatos = Strdatos & Trim(dt_tmp(i)("INDICADOR")) & "|"

                ARRcadena(i) = Strdatos

            Next

            File.WriteAllLines(StrNomArchivo, ARRcadena)

            empresaBL = Nothing
            empresaBE = Nothing

        End Sub

        Public Sub get_Estruc_14(ByVal ayo_ As Integer, ByVal mes_ As Integer, ByVal empresa_ As Integer)
            Dim StrNomArchivo As String
            Dim ARRcadena As String()
            Dim Strdatos As String
            Dim MyDecimal As String
            Dim Posicion As Integer
            Dim empresaBE As New BE.ContabilidadBE.SG_CO_TB_EMPRESA With {.EM_ID = empresa_}
            Dim empresaBL As New BL.ContabilidadBL.SG_CO_TB_EMPRESA
            empresaBL.getEmpresas_2(empresaBE)

            Dim dt_tmp As DataTable = SqlHelper.ExecuteDataset(Cn, "SG_PL_SP_S_PLAME_14", ayo_, mes_, empresa_).Tables(0)

            StrNomArchivo = Str_vRutaPdt & empresaBE.EM_NOMBRE & "\" & ayo_.ToString & mes_.ToString & "\0601" & ayo_ & mes_.ToString.PadLeft(2, "0") & empresaBE.EM_RUC & ".jor"
            If Dir(StrNomArchivo) <> "" Then Kill(StrNomArchivo)
            If Dir(Str_vRutaPdt & empresaBE.EM_NOMBRE & "\" & ayo_.ToString & mes_.ToString, vbDirectory) = "" Then MkDir(Str_vRutaPdt & empresaBE.EM_NOMBRE & "\" & ayo_ & mes_)

            Dim sw As New System.IO.StreamWriter(StrNomArchivo, True)

            ReDim ARRcadena(0 To dt_tmp.Rows.Count - 1)
            Strdatos = ""

            For i As Integer = 0 To dt_tmp.Rows.Count - 1

                'If dt_tmp(i)("num_doc") = "44617985" Then
                '    MsgBox("aki")
                'End If

                Strdatos = Left(dt_tmp(i)("tipo_doc") & Space(1), 1) & "|"
                Strdatos = Strdatos & Trim(dt_tmp(i)("num_doc")) & "|"
                Strdatos = Strdatos & Trim(dt_tmp(i)("NUM_HR_ORDINARIAS")) & "|"
                Strdatos = Strdatos & Trim(dt_tmp(i)("NUM_MIN_ORDINARIAS")) & "|"
                Strdatos = Strdatos & Trim(Int(dt_tmp(i)("NUM_HR_SOBRE"))) & "|"

                MyDecimal = dt_tmp(i)("NUM_HR_SOBRE") - Int(dt_tmp(i)("NUM_HR_SOBRE"))
                Posicion = InStr(MyDecimal, ".")
                If Posicion > 0 Then
                    MyDecimal = Right(MyDecimal, Len(MyDecimal) - Posicion)
                    Strdatos = Strdatos & Trim(Left(MyDecimal & Space(2), 2)) & "|"
                Else
                    Strdatos = Strdatos & Left("0" & Space(1), 1) & "|"
                End If

                'ARRcadena(i) = Strdatos
                sw.WriteLine(Strdatos)

            Next
            sw.Close()
            'File.WriteAllLines(StrNomArchivo, ARRcadena)

            empresaBL = Nothing
            empresaBE = Nothing


        End Sub

        Public Sub get_Estruc_15(ByVal ayo_ As Integer, ByVal mes_ As Integer, ByVal empresa_ As Integer)

            Dim StrNomArchivo As String
            Dim ARRcadena As String()
            Dim Strdatos As String
            Dim empresaBE As New BE.ContabilidadBE.SG_CO_TB_EMPRESA With {.EM_ID = empresa_}
            Dim empresaBL As New BL.ContabilidadBL.SG_CO_TB_EMPRESA
            empresaBL.getEmpresas_2(empresaBE)

            Dim dt_tmp As DataTable = SqlHelper.ExecuteDataset(Cn, "SG_PL_SP_S_PLAME_15", ayo_, mes_, empresa_).Tables(0)

            StrNomArchivo = Str_vRutaPdt & empresaBE.EM_NOMBRE & "\" & ayo_.ToString & mes_.ToString & "\0601" & ayo_ & mes_.ToString.PadLeft(2, "0") & empresaBE.EM_RUC & ".sub"

            If Dir(StrNomArchivo) <> "" Then Kill(StrNomArchivo)
            If Dir(Str_vRutaPdt & empresaBE.EM_NOMBRE & "\" & ayo_.ToString & mes_.ToString, vbDirectory) = "" Then MkDir(Str_vRutaPdt & empresaBE.EM_NOMBRE & "\" & ayo_ & mes_)

            Dim sw As New System.IO.StreamWriter(StrNomArchivo, True)


            ReDim ARRcadena(0 To dt_tmp.Rows.Count - 1)
            Strdatos = ""
            For i As Integer = 0 To dt_tmp.Rows.Count - 1

                Strdatos = Left(dt_tmp(i)("TIPO_DOC") & Space(2), 2) & "|"
                Strdatos = Strdatos & Trim(dt_tmp(i)("NUM_DNI")) & "|"
                Strdatos = Strdatos & Left(dt_tmp(i)("TIPO_SUSPE") & Space(2), 2) & "|"
                Strdatos = Strdatos & Left(dt_tmp(i)("NUM_CITT") & Space(16), 16) & "|"
                Strdatos = Strdatos & dt_tmp(i)("FEC_INI") & "|"
                Strdatos = Strdatos & Trim(dt_tmp(i)("FEC_FIN")) & "|"

                sw.WriteLine(Strdatos)

            Next

            sw.Close()

            empresaBL = Nothing
            empresaBE = Nothing

        End Sub

        Public Sub get_Estruc_15_v2(ByVal ayo_ As Integer, ByVal mes_ As Integer, ByVal empresa_ As Integer)

            Dim StrNomArchivo As String
            Dim ARRcadena As String()
            Dim Strdatos As String
            Dim empresaBE As New BE.ContabilidadBE.SG_CO_TB_EMPRESA With {.EM_ID = empresa_}
            Dim empresaBL As New BL.ContabilidadBL.SG_CO_TB_EMPRESA
            empresaBL.getEmpresas_2(empresaBE)

            Dim dt_tmp As DataTable = SqlHelper.ExecuteDataset(Cn, "SG_PL_SP_S_PLAME_15_V2", ayo_, mes_, empresa_).Tables(0)

            StrNomArchivo = Str_vRutaPdt & empresaBE.EM_NOMBRE & "\" & ayo_.ToString & mes_.ToString & "\0601" & ayo_ & mes_.ToString.PadLeft(2, "0") & empresaBE.EM_RUC & ".snl"

            If Dir(StrNomArchivo) <> "" Then Kill(StrNomArchivo)
            If Dir(Str_vRutaPdt & empresaBE.EM_NOMBRE & "\" & ayo_.ToString & mes_.ToString, vbDirectory) = "" Then MkDir(Str_vRutaPdt & empresaBE.EM_NOMBRE & "\" & ayo_ & mes_)

            Dim sw As New System.IO.StreamWriter(StrNomArchivo, True)


            ReDim ARRcadena(0 To dt_tmp.Rows.Count - 1)
            Strdatos = ""
            For i As Integer = 0 To dt_tmp.Rows.Count - 1

                Strdatos = Left(dt_tmp(i)("TIPO_DOC") & Space(2), 2) & "|"
                Strdatos = Strdatos & Trim(dt_tmp(i)("NUM_DNI")) & "|"
                Strdatos = Strdatos & Left(dt_tmp(i)("TIPO_SUSPE") & Space(2), 2) & "|"
                Strdatos = Strdatos & Trim(dt_tmp(i)("DIAS")) & "|"

                sw.WriteLine(Strdatos)

            Next

            sw.Close()

            empresaBL = Nothing
            empresaBE = Nothing

        End Sub

        Public Sub get_Estruc_16(ByVal ayo_ As Integer, ByVal mes_ As Integer, ByVal empresa_ As Integer)

            Dim StrNomArchivo As String
            Dim ARRcadena As String()
            Dim Strdatos As String
            Dim empresaBE As New BE.ContabilidadBE.SG_CO_TB_EMPRESA With {.EM_ID = empresa_}
            Dim empresaBL As New BL.ContabilidadBL.SG_CO_TB_EMPRESA
            empresaBL.getEmpresas_2(empresaBE)

            Dim dt_tmp As DataTable = SqlHelper.ExecuteDataset(Cn, "SG_PL_SP_S_PLAME_16", ayo_, mes_, empresa_).Tables(0)

            StrNomArchivo = Str_vRutaPdt & empresaBE.EM_NOMBRE & "\" & ayo_.ToString & mes_.ToString & "\0601" & ayo_ & mes_.ToString.PadLeft(2, "0") & empresaBE.EM_RUC & ".not"

            If Dir(StrNomArchivo) <> "" Then Kill(StrNomArchivo)
            If Dir(Str_vRutaPdt & empresaBE.EM_NOMBRE & "\" & ayo_.ToString & mes_.ToString, vbDirectory) = "" Then MkDir(Str_vRutaPdt & empresaBE.EM_NOMBRE & "\" & ayo_ & mes_)

            Dim sw As New System.IO.StreamWriter(StrNomArchivo, True)


            ReDim ARRcadena(0 To dt_tmp.Rows.Count - 1)
            Strdatos = ""
            For i As Integer = 0 To dt_tmp.Rows.Count - 1

                Strdatos = Left(dt_tmp(i)("TIPO_DOC") & Space(2), 2) & "|"
                Strdatos = Strdatos & Trim(dt_tmp(i)("NUM_DNI")) & "|"
                Strdatos = Strdatos & Left(dt_tmp(i)("TIPO_SUSPE") & Space(2), 2) & "|"
                Strdatos = Strdatos & dt_tmp(i)("FEC_INI") & "|"
                Strdatos = Strdatos & Trim(dt_tmp(i)("FEC_FIN")) & "|"

                sw.WriteLine(Strdatos)

            Next

            sw.Close()

            empresaBL = Nothing
            empresaBE = Nothing

        End Sub

        Public Sub get_Estruc_20(ByVal ayo_ As Integer, ByVal mes_ As Integer, ByVal empresa_ As Integer)

            Dim StrNomArchivo As String
            Dim ARRcadena As String()
            Dim Strdatos As String
            Dim empresaBE As New BE.ContabilidadBE.SG_CO_TB_EMPRESA With {.EM_ID = empresa_}
            Dim empresaBL As New BL.ContabilidadBL.SG_CO_TB_EMPRESA
            empresaBL.getEmpresas_2(empresaBE)

            Dim dt_tmp As DataTable = SqlHelper.ExecuteDataset(Cn, "SG_PL_SP_S_PLAME_20", ayo_, mes_, empresa_).Tables(0)

            StrNomArchivo = Str_vRutaPdt & empresaBE.EM_NOMBRE & "\" & ayo_.ToString & mes_.ToString & "\0601" & ayo_ & mes_.ToString.PadLeft(2, "0") & empresaBE.EM_RUC & ".4ta"

            If Dir(StrNomArchivo) <> "" Then Kill(StrNomArchivo)
            If Dir(Str_vRutaPdt & empresaBE.EM_NOMBRE & "\" & ayo_.ToString & mes_.ToString, vbDirectory) = "" Then MkDir(Str_vRutaPdt & empresaBE.EM_NOMBRE & "\" & ayo_ & mes_)

            Dim sw As New System.IO.StreamWriter(StrNomArchivo, True)


            ReDim ARRcadena(0 To dt_tmp.Rows.Count - 1)
            Strdatos = ""
            For i As Integer = 0 To dt_tmp.Rows.Count - 1

                Strdatos = Left(dt_tmp(i)("Tipo_doc") & Space(2), 2) & "|"
                Strdatos = Strdatos & Trim(dt_tmp(i)("Num_Doc")) & "|"
                Strdatos = Strdatos & Left(dt_tmp(i)("tipo_compro") & Space(1), 1) & "|"
                Strdatos = Strdatos & dt_tmp(i)("serie_compro") & "|"
                Strdatos = Strdatos & Right(Space(8) & dt_tmp(i)("num_compro"), 8) & "|"
                Strdatos = Strdatos & Trim(dt_tmp(i)("monto_total")) & "|"
                Strdatos = Strdatos & Trim(dt_tmp(i)("fecha_emi")) & "|"
                Strdatos = Strdatos & Trim(dt_tmp(i)("fecha_pago")) & "|"
                Strdatos = Strdatos & Left(IIf(dt_tmp(i)("RETENCION") = 1, "1", "0") & Space(1), 1) & "|"
                'Strdatos = Strdatos & Trim(dt_tmp(i)("RET_AFP")) & "|"
                Strdatos = Strdatos & "|"
                Strdatos = Strdatos & "|"
                'Strdatos = Strdatos & IIf(dt_tmp(i)("RET_AFP") = "3", "", Trim(Math.Round(dt_tmp(i)("MONTO_RET_AFP"), 2))) & "|"

                'ARRcadena(i) = Strdatos
                sw.WriteLine(Strdatos)

            Next

            sw.Close()
            'File.WriteAllLines(StrNomArchivo, ARRcadena)

            empresaBL = Nothing
            empresaBE = Nothing

        End Sub

        Public Sub get_Estruc_CTS_Banco_Comercio()

            Dim StrNomArchivo As String
            Dim ARRcadena As String()
            Dim Strdatos As String

        
            Dim dt_tmp As DataTable = SqlHelper.ExecuteDataset(Cn, CommandType.Text, "select * from A_CTS").Tables(0)

            StrNomArchivo = "cts_banco_comercio.txt"

            'If Dir(StrNomArchivo) <> "" Then Kill(StrNomArchivo)
            'If Dir(Str_vRutaPdt & empresaBE.EM_NOMBRE & "\" & ayo_.ToString & mes_.ToString, vbDirectory) = "" Then MkDir(Str_vRutaPdt & empresaBE.EM_NOMBRE & "\" & ayo_ & mes_)

            Dim sw As New System.IO.StreamWriter(StrNomArchivo, True)

            Dim importe_tmp As String
            Dim valor_decimal_tmp As String
            ReDim ARRcadena(0 To dt_tmp.Rows.Count - 1)
            Strdatos = ""

            For i As Integer = 0 To dt_tmp.Rows.Count - 1

                Strdatos = Left(dt_tmp(i)("cuenta").ToString.Replace("-", "") & Space(12), 12)

                importe_tmp = dt_tmp(i)("importe").ToString
                If importe_tmp.IndexOf(".") <> -1 Then

                    valor_decimal_tmp = importe_tmp.Remove(0, importe_tmp.IndexOf(".") + 1)

                    If valor_decimal_tmp.Length = 1 Then
                        Strdatos = Strdatos & Right(importe_tmp.PadLeft(12, "0").Replace(".", "") & "0", 11)
                    Else
                        Strdatos = Strdatos & Right(importe_tmp.PadLeft(12, "0").Replace(".", ""), 11)
                    End If

                Else
                    Strdatos = Strdatos & Right(dt_tmp(i)("importe").ToString.PadLeft(12, "0").Replace(".", "") & "00", 11)
                End If


                importe_tmp = dt_tmp(i)("ultimas").ToString
                If importe_tmp.IndexOf(".") <> -1 Then

                    valor_decimal_tmp = importe_tmp.Remove(0, importe_tmp.IndexOf(".") + 1)

                    If valor_decimal_tmp.Length = 1 Then
                        Strdatos = Strdatos & Right(importe_tmp.PadLeft(12, "0").Replace(".", "") & "0", 11)
                    Else
                        Strdatos = Strdatos & Right(importe_tmp.PadLeft(12, "0").Replace(".", ""), 11)
                    End If

                Else
                    Strdatos = Strdatos & Right(dt_tmp(i)("ultimas").ToString.PadLeft(12, "0").Replace(".", "") & "00", 11)
                End If

                


                Strdatos = Strdatos & "0000000000"

                'ARRcadena(i) = Strdatos
                sw.WriteLine(Strdatos)

            Next

            sw.Close()
            'File.WriteAllLines(StrNomArchivo, ARRcadena)

 

        End Sub

        Public Sub get_Estruc_17(ByVal ayo_ As Integer, ByVal mes_ As Integer, ByVal empresa_ As Integer)

            Dim StrNomArchivo As String
            Dim ARRcadena As String()
            Dim Strdatos As String
            Dim empresaBE As New BE.ContabilidadBE.SG_CO_TB_EMPRESA With {.EM_ID = empresa_}
            Dim empresaBL As New BL.ContabilidadBL.SG_CO_TB_EMPRESA
            empresaBL.getEmpresas_2(empresaBE)

            Dim dt_tmp As DataTable = SqlHelper.ExecuteDataset(Cn, "SG_PL_SP_S_PLAME_17", ayo_, mes_, empresa_).Tables(0)

            StrNomArchivo = Str_vRutaPdt & empresaBE.EM_NOMBRE & "\" & ayo_.ToString & mes_.ToString & "\0601" & ayo_ & mes_.ToString.PadLeft(2, "0") & empresaBE.EM_RUC & ".tes"

            If Dir(StrNomArchivo) <> "" Then Kill(StrNomArchivo)
            If Dir(Str_vRutaPdt & empresaBE.EM_NOMBRE & "\" & ayo_.ToString & mes_.ToString, vbDirectory) = "" Then MkDir(Str_vRutaPdt & empresaBE.EM_NOMBRE & "\" & ayo_ & mes_)

            Dim sw As New System.IO.StreamWriter(StrNomArchivo, True)


            ReDim ARRcadena(0 To dt_tmp.Rows.Count - 1)
            Strdatos = ""
            For i As Integer = 0 To dt_tmp.Rows.Count - 1

                Strdatos = Left(dt_tmp(i)("Tipo_doc") & Space(2), 2) & "|"
                Strdatos = Strdatos & Left(dt_tmp(i)("doc_per") & Space(2), 15) & "|"
                Strdatos = Strdatos & Left(dt_tmp(i)("ruc") & Space(11), 11) & "|"
                Strdatos = Strdatos & Left(dt_tmp(i)("estable") & Space(4), 4) & "|"
                'Strdatos = Strdatos & Left(dt_tmp(i)("tasa") & Space(6), 6) & "|"
                Strdatos = Strdatos & Space(6) & "|"
                sw.WriteLine(Strdatos)

            Next

            sw.Close()
            'File.WriteAllLines(StrNomArchivo, ARRcadena)

            empresaBL = Nothing
            empresaBE = Nothing

        End Sub

        Public Sub get_Estruc_07(ByVal ayo_ As Integer, ByVal mes_ As Integer, ByVal empresa_ As Integer)

            Dim StrNomArchivo As String
            Dim ARRcadena As String()
            Dim Strdatos As String
            Dim empresaBE As New BE.ContabilidadBE.SG_CO_TB_EMPRESA With {.EM_ID = empresa_}
            Dim empresaBL As New BL.ContabilidadBL.SG_CO_TB_EMPRESA
            empresaBL.getEmpresas_2(empresaBE)

            Dim dt_tmp As DataTable = SqlHelper.ExecuteDataset(Cn, "SG_PL_SP_S_PLAME_07", ayo_, mes_, empresa_).Tables(0)

            StrNomArchivo = Str_vRutaPdt & empresaBE.EM_NOMBRE & "\" & ayo_.ToString & mes_.ToString & "\0601" & ayo_.ToString & mes_.ToString.PadLeft(2, "0") & empresaBE.EM_RUC & ".ps4"

            If Dir(StrNomArchivo) <> "" Then Kill(StrNomArchivo)
            If Dir(Str_vRutaPdt & empresaBE.EM_NOMBRE & "\" & ayo_.ToString & mes_.ToString, vbDirectory) = "" Then MkDir(Str_vRutaPdt & empresaBE.EM_NOMBRE & "\" & ayo_ & mes_)

            Dim sw As New System.IO.StreamWriter(StrNomArchivo, True)


            ReDim ARRcadena(0 To dt_tmp.Rows.Count - 1)
            Strdatos = ""
            Dim nombres() As String
            For i As Integer = 0 To dt_tmp.Rows.Count - 1
                nombres = dt_tmp(i)("NOMBRES").ToString.Split(" ")


                Strdatos = Left(dt_tmp(i)("TD") & Space(2), 2) & "|"
                Strdatos = Strdatos & Left(dt_tmp(i)("RUC") & Space(11), 11) & "|"
                Strdatos = Strdatos & nombres(0) & "|"
                Strdatos = Strdatos & nombres(1) & "|"

                If nombres.Length > 3 Then
                    Strdatos = Strdatos & nombres(2) & " " & nombres(3) & "|"
                Else
                    Strdatos = Strdatos & nombres(2) & "|"
                End If

                Strdatos = Strdatos & dt_tmp(i)("DOMI") & "|"
                Strdatos = Strdatos & dt_tmp(i)("CONVENIO") & "|"
                sw.WriteLine(Strdatos)

            Next

            sw.Close()
            'File.WriteAllLines(StrNomArchivo, ARRcadena)

            empresaBL = Nothing
            empresaBE = Nothing

        End Sub

        Public Sub get_Estruc_18(ByVal ayo_ As Integer, ByVal mes_ As Integer, ByVal empresa_ As Integer)

            Dim dt_tmp As DataTable = SqlHelper.ExecuteDataset(Cn, "SG_PL_SP_S_PLAME_18", ayo_, mes_, empresa_).Tables(0)

            Dim StrNomArchivo As String
            Dim Bol_HasFive As Boolean
            Dim StrCodigoAux As String

            Dim Strdatos As String
            Dim ARRcadena As String()
            Dim empresaBE As New BE.ContabilidadBE.SG_CO_TB_EMPRESA With {.EM_ID = empresa_}
            Dim empresaBL As New BL.ContabilidadBL.SG_CO_TB_EMPRESA
            empresaBL.getEmpresas_2(empresaBE)

            StrNomArchivo = Str_vRutaPdt & empresaBE.EM_NOMBRE & "\" & ayo_.ToString & mes_.ToString & "\0601" & ayo_ & mes_.ToString.PadLeft(2, "0") & empresaBE.EM_RUC & ".rem"

            If Dir(StrNomArchivo) <> "" Then Kill(StrNomArchivo)
            If Dir(Str_vRutaPdt & empresaBE.EM_NOMBRE & "\" & ayo_.ToString & mes_.ToString, vbDirectory) = "" Then MkDir(Str_vRutaPdt & empresaBE.EM_NOMBRE & "\" & ayo_ & mes_)

            'Strdatos
            StrCodigoAux = String.Empty

            Dim sw As New System.IO.StreamWriter(StrNomArchivo, True)

            Dim co As Integer = 0
            ReDim ARRcadena(0 To dt_tmp.Rows.Count - 1)


            For i As Integer = 0 To dt_tmp.Rows.Count - 1

                co += 1

                'guardanos el codigo
                If dt_tmp.Rows(i)("pl_Num_Doc") = "80653108" Then
                    'MsgBox("saw")
                End If

                If StrCodigoAux <> dt_tmp.Rows(i)("pl_Num_Doc") Then

                    'preguntamos por el co sea mayor a 1 para k on ingrese en la primera vuelta nada mas
                    If Not Bol_HasFive And co > 1 Then 'agregamos la kinta(0) si en toda las vueltas no ha tenido
                        Strdatos = "01|"
                        Strdatos = Strdatos & StrCodigoAux & "|"
                        Strdatos = Strdatos & "0605" & "|"
                        Strdatos = Strdatos & Math.Round(0, 2) & "|"
                        Strdatos = Strdatos & Math.Round(0, 2) & "|"
                        Strdatos = Strdatos
                        'Print #NumeroArchivo, Strdatos
                        'ARRcadena(i) = Strdatos
                        sw.WriteLine(Strdatos)
                        Bol_HasFive = False
                    End If
                    If Bol_HasFive Then Bol_HasFive = Not Bol_HasFive
                    StrCodigoAux = dt_tmp.Rows(i)("pl_Num_Doc")
                End If

                'preguntar si tienen kinta
                If dt_tmp.Rows(i)("pl_cod_hd") = "204" Then Bol_HasFive = True

                If dt_tmp.Rows(i)("pl_cod_hd") = "114" Then
                    '0107 _____50%
                    '0308 _____50%
                    Dim j As Integer
                    Dim Dbl_Resul_Fx As Double
                    Dim Dbl_sueldo As Double ' 101
                    Dim Dbl_asignacionF As Double '102
                    Dim Dbl_Hora As Double
                    Dim Dbl_diferencia As Double

                    'Dbl_Hora = dt_tmp.Rows(i)("pl_horas") 'este es el Numero de las horas extras dobles de Ehistori
                    'Dbl_asignacionF = ObtenerImporte_oF_Concepto("102", dt_tmp.Rows(i)("pl_Num_Doc"), ayo_, mes_)
                    Dbl_sueldo = ObtenerImporte_oF_Concepto("101", dt_tmp.Rows(i)("pl_Num_Doc"), ayo_, mes_)
                    'Dbl_Resul_Fx = (((Dbl_sueldo + Dbl_asignacionF) / 30) / IIf(dt_tmp.Rows(i)("pl_tipo_trab") = "1", 8, 6)) * Dbl_Hora 'se va a ==>115


                    Dbl_Resul_Fx = dt_tmp.Rows(i)("pl_devengado") / 2
                    Dbl_diferencia = Dbl_sueldo - Dbl_Resul_Fx  ' se va a ==> 121

                    For j = 1 To 2
                        Strdatos = dt_tmp.Rows(i)("pl_Tipo_doc") & "|"
                        Strdatos = Strdatos & dt_tmp.Rows(i)("pl_Num_Doc") & "|"
                        Strdatos = Strdatos & IIf(j = 1, "0115", "0121") & "|"
                        Strdatos = Strdatos & Math.Round(IIf(j = 1, Dbl_Resul_Fx, Dbl_diferencia), 2) & "|"
                        Strdatos = Strdatos & Math.Round(IIf(j = 1, Dbl_Resul_Fx, Dbl_diferencia), 2) & "|"
                        Strdatos = Strdatos
                        'Print #NumeroArchivo, Strdatos
                        'ARRcadena(i) = Strdatos - Ffr = u.N



                        'fr = u.N
                        'fr = u.mg
                        'fr = (0.200).(5.00)(9.81)
                        'fr = 47.1 N



                        'Ffr = fr.URDE>?>X
                        sw.WriteLine(Strdatos)
                    Next

                    For j = 1 To 2
                        Strdatos = dt_tmp.Rows(i)("pl_Tipo_doc") & "|"
                        Strdatos = Strdatos & dt_tmp.Rows(i)("pl_Num_Doc") & "|"
                        Strdatos = Strdatos & IIf(j = 1, "0107", "0308") & "|"
                        Strdatos = Strdatos & Trim(Math.Round(dt_tmp.Rows(i)("pl_devengado") / 2, 2)) & "|"
                        Strdatos = Strdatos & Trim(Math.Round(dt_tmp.Rows(i)("pl_pagado_descon") / 2, 2)) & "|"
                        Strdatos = Strdatos
                        sw.WriteLine(Strdatos)
                    Next



                Else

                    Strdatos = dt_tmp.Rows(i)("pl_Tipo_doc") & "|"
                    Strdatos = Strdatos & dt_tmp.Rows(i)("pl_Num_Doc") & "|"
                    Strdatos = Strdatos & dt_tmp.Rows(i)("pl_codigo_sunat") & "|"
                    Strdatos = Strdatos & Math.Round(dt_tmp.Rows(i)("pl_devengado"), 2) & "|"
                    Strdatos = Strdatos & Math.Round(dt_tmp.Rows(i)("pl_pagado_descon"), 2) & "|"
                    Strdatos = Strdatos

                    'Print #NumeroArchivo, Strdatos
                    'ARRcadena(i) = Strdatos
                    sw.WriteLine(Strdatos)
                End If

            Next

            sw.Close()


            'File.WriteAllLines(StrNomArchivo, ARRcadena)

            empresaBL = Nothing
            empresaBE = Nothing

        End Sub

        Private Function ObtenerImporte_oF_Concepto(ByVal Concepto_ As String, ByVal dni_ As String, ByVal int_ayo_ As Integer, ByVal int_mes_ As Integer) As Double
            Dim Str_Query As String = String.Format("SELECT HI_MONTO FROM SG_PL_TB_HISTORIAL WHERE YEAR(HI_FEC_OPE) = {0} AND MONTH(HI_FEC_OPE) = {1} AND HI_ID_PERSONAL in (SELECT PE_ID FROM SG_PL_TB_PERSONAL WHERE PE_NUM_DOC_PER = '{2}') AND HI_COD_HD = '{3}'", int_ayo_, int_mes_, dni_, Concepto_)
            Return SqlHelper.ExecuteScalar(Cn, CommandType.Text, Str_Query)
        End Function

        Public Function get_Lista_para_ArchivoMasivo(ByVal ayo_ As Integer, ByVal mes_ As Integer, ByVal frecuencia_ As Integer, tipoPersonal_ As Integer) As DataTable
            Dim cnigf As New SqlConnection("server=serverigf;user=ct;pwd=chelas;Initial catalog=Planilla;Pooling=true; Min Pool Size=5; Max Pool Size=10; Pooling = True")
            Dim str_procedimiento As String = ""
            If tipoPersonal_ = 1 Then str_procedimiento = "SG_PL_SP_S_ARCH_MASIV_SUELDO_E"
            If tipoPersonal_ = 2 Then str_procedimiento = "SG_PL_SP_S_ARCH_MASIV_SUELDO_J"
            Return SqlHelper.ExecuteDataset(cnigf, str_procedimiento, ayo_, mes_, frecuencia_).Tables(0)
        End Function

        Public Function get_Lista_para_ArchivoMasivo_2012(ByVal ayo_ As Integer, ByVal mes_ As Integer, ByVal frecuencia_ As Integer, empresa_ As Integer, cod_folio_ As String) As DataTable
            Return SqlHelper.ExecuteDataset(Cn, "SG_PL_SP_S_ARCH_MASIV_SUELDO", ayo_, mes_, frecuencia_, empresa_, cod_folio_).Tables(0)
        End Function

        Public Sub Generar_ArchivoMasivo_EnExcel(ByVal ayo_ As Integer, ByVal mes_ As Integer, ByVal periodo_ As Integer, ByVal empresa_ As Integer, ByVal cod_servicio_ As Integer, ByVal cuenta_cargo_ As String, ByVal responsable_ As String, ByVal fecha_abono_ As Date, ByVal ruc_empresa_ As String, ByVal zipear_ As Boolean, tipoPersonal_ As Integer)

            Dim cnigf As New SqlConnection("server=serverigf;user=ct;pwd=chelas;Initial catalog=Planilla;Pooling=true; Min Pool Size=5; Max Pool Size=10; Pooling = True")

            Dim str_procedimiento As String = ""
            If tipoPersonal_ = 1 Then str_procedimiento = "SG_PL_SP_S_ARCH_MASIV_SUELDO_E"
            If tipoPersonal_ = 2 Then str_procedimiento = "SG_PL_SP_S_ARCH_MASIV_SUELDO_J"
            Dim dtt As DataTable = SqlHelper.ExecuteDataset(cnigf, str_procedimiento, ayo_, mes_, periodo_).Tables(0)


            Dim xlApp As Object
            Dim xlWorkBook As Object
            Dim xlWorkSheet As Object

            xlApp = CreateObject("Excel.Application")
            xlWorkBook = xlApp.Workbook
            xlWorkSheet = xlApp.Worksheet


            Dim sPath As String = System.AppDomain.CurrentDomain.BaseDirectory

            xlWorkBook = xlApp.Workbooks.Open(Str_vRutaPdt & "Banco\" & "Plantilla.xls")
            xlWorkSheet = xlWorkBook.Worksheets("Hoja1")

            xlWorkSheet.Cells(4, 12) = fecha_abono_

            For i As Integer = 0 To 200
                xlWorkSheet.Cells(i + 8, 2) = ""
                xlWorkSheet.Cells(i + 8, 3) = ""
                xlWorkSheet.Cells(i + 8, 4) = ""
                xlWorkSheet.Cells(i + 8, 5) = ""
                xlWorkSheet.Cells(i + 8, 11) = ""
                xlWorkSheet.Cells(i + 8, 12) = ""
                xlWorkSheet.Cells(i + 8, 13) = ""
                xlWorkSheet.Cells(i + 8, 14) = ""
            Next

            For i As Integer = 0 To dtt.Rows.Count - 1
                xlWorkSheet.Cells(i + 8, 2) = dtt(i)("COD_PER").ToString
                xlWorkSheet.Cells(i + 8, 3) = (dtt(i)("NOM_PER") & " " & dtt(i)("APE_PAT") & " " & dtt(i)("APE_MAT")).ToString
                xlWorkSheet.Cells(i + 8, 4) = "1"
                xlWorkSheet.Cells(i + 8, 5) = dtt(i)("IMPORTE")
                xlWorkSheet.Cells(i + 8, 11) = "14" & dtt(i)("CTA_CTE").ToString.Replace("-", "")
                xlWorkSheet.Cells(i + 8, 12) = "5"
                xlWorkSheet.Cells(i + 8, 13) = "01"
                xlWorkSheet.Cells(i + 8, 14) = dtt(i)("DOC_PER").ToString
            Next


            'display the cells value B2
            'MsgBox(xlWorkSheet.Cells(2, 2).value)
            'edit the cell with new value
            'xlWorkSheet.Cells(2, 2) = "http://vb.net-informations.com"
            'xlWorkBook.SaveAs("Sueldos.xls")
            xlWorkBook.Close(True)
            xlApp.Quit()

            releaseObject(xlApp)
            releaseObject(xlWorkBook)
            releaseObject(xlWorkSheet)

        End Sub

        Public Sub Generar_ArchivoMasivo_EnExcel_2012(ByVal ayo_ As Integer, ByVal mes_ As Integer, ByVal periodo_ As Integer, ByVal empresa_ As Integer, fecha_abono_ As Date, cod_folio_ As String)

            Dim str_procedimiento As String = "SG_PL_SP_S_ARCH_MASIV_SUELDO"
            Dim dtt As DataTable = SqlHelper.ExecuteDataset(Cn, str_procedimiento, ayo_, mes_, periodo_, empresa_, cod_folio_).Tables(0)

            Dim xlApp As Object
            Dim xlWorkBook As Object
            Dim xlWorkSheet As Object

            xlApp = CreateObject("Excel.Application")
            xlWorkBook = xlApp.Workbooks.Add
            xlWorkSheet = xlApp.Worksheets(1)


            Dim sPath As String = System.AppDomain.CurrentDomain.BaseDirectory


            xlWorkBook = xlApp.Workbooks.Open(Str_vRutaPdt & "Banco\" & "Plantilla.xls")
            xlWorkSheet = xlWorkBook.Worksheets("Hoja1")

            xlWorkSheet.Cells(4, 12) = fecha_abono_

            For i As Integer = 0 To 200
                xlWorkSheet.Cells(i + 8, 2) = ""
                xlWorkSheet.Cells(i + 8, 3) = ""
                xlWorkSheet.Cells(i + 8, 4) = ""
                xlWorkSheet.Cells(i + 8, 5) = ""
                xlWorkSheet.Cells(i + 8, 11) = ""
                xlWorkSheet.Cells(i + 8, 12) = ""
                xlWorkSheet.Cells(i + 8, 13) = ""
                xlWorkSheet.Cells(i + 8, 14) = ""
                xlWorkSheet.Cells(i + 8, 15) = ""
            Next

            For i As Integer = 0 To dtt.Rows.Count - 1
                xlWorkSheet.Cells(i + 8, 2) = dtt(i)("PE_CODIGO").ToString
                'xlWorkSheet.Cells(i + 8, 3) = (dtt(i)("NOM_PER").ToString.Replace("Ñ", "N") & " " & dtt(i)("PE_APE_PAT").ToString.Replace("Ñ", "N") & " " & dtt(i)("PE_APE_MAT").ToString.Replace("Ñ", "N")).ToString
                xlWorkSheet.Cells(i + 8, 3) = (dtt(i)("PE_APE_PAT").ToString.Replace("Ñ", "N") & " " & dtt(i)("PE_APE_MAT").ToString.Replace("Ñ", "N") & " " & dtt(i)("NOM_PER").ToString.Replace("Ñ", "N")).ToString
                xlWorkSheet.Cells(i + 8, 4) = "1"
                xlWorkSheet.Cells(i + 8, 5) = dtt(i)("IMPORTE")

                If dtt(i)("PE_COD_INTERBANCA").ToString.Trim.Length > 0 Then
                    xlWorkSheet.Cells(i + 8, 11) = ""
                Else
                    xlWorkSheet.Cells(i + 8, 11) = "14" & dtt(i)("CTA_CTE").ToString.Replace("-", "")
                End If

                xlWorkSheet.Cells(i + 8, 12) = "5"
                xlWorkSheet.Cells(i + 8, 13) = "01"
                xlWorkSheet.Cells(i + 8, 14) = dtt(i)("DOC_PER").ToString

                xlWorkSheet.Cells(i + 8, 15) = dtt(i)("PE_COD_INTERBANCA").ToString
            Next


            'display the cells value B2
            'MsgBox(xlWorkSheet.Cells(2, 2).value)
            'edit the cell with new value
            'xlWorkSheet.Cells(2, 2) = "http://vb.net-informations.com"
            'xlWorkBook.SaveAs("Sueldos.xls")
            xlWorkBook.Close(True)
            xlApp.Quit()

            releaseObject(xlApp)
            releaseObject(xlWorkBook)
            releaseObject(xlWorkSheet)

        End Sub

        Private Sub releaseObject(ByVal obj As Object)
            Try
                System.Runtime.InteropServices.Marshal.ReleaseComObject(obj)
                obj = Nothing
            Catch ex As Exception
                obj = Nothing
            Finally
                GC.Collect()
            End Try
        End Sub

        Public Sub Generar_ArchivoMasivo(ByVal ayo_ As Integer, ByVal mes_ As Integer, ByVal periodo_ As Integer, ByVal empresa_ As Integer, ByVal cod_servicio_ As Integer, ByVal cuenta_cargo_ As String, ByVal responsable_ As String, ByVal fecha_abono_ As Date, ByVal ruc_empresa_ As String, ByVal zipear_ As Boolean, tipoPersonal_ As Integer)

            Dim cnigf As New SqlConnection("server=serverigf;user=ct;pwd=chelas;Initial catalog=Planilla;Pooling=true; Min Pool Size=5; Max Pool Size=10; Pooling = True")
            Dim str_procedimiento As String = ""
            If tipoPersonal_ = 1 Then str_procedimiento = "SG_PL_SP_S_ARCH_MASIV_SUELDO_E"
            If tipoPersonal_ = 2 Then str_procedimiento = "SG_PL_SP_S_ARCH_MASIV_SUELDO_J"

            Dim dtt As DataTable = SqlHelper.ExecuteDataset(cnigf, str_procedimiento, ayo_, mes_, periodo_).Tables(0)
            Dim Strdatos As String
            Dim ARRcadena As String()
            Dim str_nombre_Archivo As String = "Sueldos.txt"
            Dim Str_Ruta_Archivo As String = Str_vRutaPdt & "Banco\" & str_nombre_Archivo

            If Dir(Str_Ruta_Archivo) <> "" Then Kill(Str_Ruta_Archivo)
            If Dir(Str_vRutaPdt & "Banco\Sueldos.zip") <> "" Then Kill(Str_vRutaPdt & "Banco\Sueldos.zip")
            If Dir(Str_vRutaPdt & "Banco", vbDirectory) = "" Then MkDir(Str_vRutaPdt & "Banco")


            Dim sw As New System.IO.StreamWriter(Str_Ruta_Archivo, True)

            ReDim ARRcadena(0 To dtt.Rows.Count - 1)
            For i As Integer = 0 To dtt.Rows.Count - 1

                Strdatos = ruc_empresa_
                Strdatos = Strdatos & cod_servicio_
                Strdatos = Strdatos & Space(10)
                Strdatos = Strdatos & dtt(i)("COD_PER").ToString.PadRight(10, "").Substring(0, 10)
                Strdatos = Strdatos & (dtt(i)("NOM_PER") & " " & dtt(i)("APE_PAT") & " " & dtt(i)("APE_MAT")).ToString.PadRight(30, "").Substring(0, 30)
                Strdatos = Strdatos & "1" 'situacion 1= Activo / 2= Anulado
                Strdatos = Strdatos & Space(8)
                Strdatos = Strdatos & "0.0000"
                Strdatos = Strdatos & Format(dtt(i)("IMPORTE"), "#####.00").ToString().PadLeft(10, "0").Substring(0, 10)
                Strdatos = Strdatos & ("0000000.00").ToString.PadRight(10, "").Substring(0, 10)
                Strdatos = Strdatos & ("0000000.00").ToString.PadRight(10, "").Substring(0, 10)
                Strdatos = Strdatos & ("0000000.00").ToString.PadRight(10, "").Substring(0, 10)
                Strdatos = Strdatos & ("0000000.00").ToString.PadRight(10, "").Substring(0, 10)
                Strdatos = Strdatos & ("0000000.00").ToString.PadRight(10, "").Substring(0, 10)

                Strdatos = Strdatos & "14" & dtt(i)("CTA_CTE").ToString.Replace("-", "").PadRight(10, "").Substring(0, 10) & "  "
                Strdatos = Strdatos & Space(16)
                Strdatos = Strdatos & "5"
                Strdatos = Strdatos & cuenta_cargo_.PadRight(14, "").Substring(0, 14)
                Strdatos = Strdatos & "01"
                Strdatos = Strdatos & dtt(i)("DOC_PER").ToString.PadRight(12, "").Substring(0, 12)
                Strdatos = Strdatos & responsable_.PadRight(30, "").Substring(0, 30)
                Strdatos = Strdatos & fecha_abono_.ToShortDateString.Replace("/", "")
                Strdatos = Strdatos & Space(20)

                sw.WriteLine(Strdatos)
                'ARRcadena(i) = Strdatos

            Next
            sw.Close()

            'File.WriteAllLines(Str_Ruta_Archivo, ARRcadena)

            Try
                If zipear_ Then
                    Dim drives As String()
                    drives = System.IO.Directory.GetLogicalDrives()
                    If drives.Length > 0 Then File.WriteAllLines(drives(0) & str_nombre_Archivo, ARRcadena)
                    Dim zip As New ZipFile(Str_vRutaPdt & "Banco\Sueldos.zip")
                    zip.AddFile(drives(0) & str_nombre_Archivo)
                    zip.Save()
                    Kill(drives(0) & str_nombre_Archivo)
                End If
            Catch ex As Exception

            End Try



        End Sub

        Public Sub Generar_ArchivoMasivo_2012(ByVal ayo_ As Integer, ByVal mes_ As Integer, ByVal periodo_ As Integer, ByVal empresa_ As Integer, ByVal cod_servicio_ As Integer, ByVal cuenta_cargo_ As String, ByVal responsable_ As String, ByVal fecha_abono_ As Date, ByVal ruc_empresa_ As String, ByVal zipear_ As Boolean, codfolio_ As String)


            Dim dtt As DataTable = SqlHelper.ExecuteDataset(Cn, "SG_PL_SP_S_ARCH_MASIV_SUELDO", ayo_, mes_, periodo_, empresa_, codfolio_).Tables(0)
            Dim Strdatos As String
            Dim ARRcadena As String()
            Dim str_nombre_Archivo As String = "Sueldos.txt"
            Dim Str_Ruta_Archivo As String = Str_vRutaPdt & "Banco\" & str_nombre_Archivo

            If Dir(Str_Ruta_Archivo) <> "" Then Kill(Str_Ruta_Archivo)
            If Dir(Str_vRutaPdt & "Banco\Sueldos.zip") <> "" Then Kill(Str_vRutaPdt & "Banco\Sueldos.zip")
            If Dir(Str_vRutaPdt & "Banco", vbDirectory) = "" Then MkDir(Str_vRutaPdt & "Banco")


            Dim sw As New System.IO.StreamWriter(Str_Ruta_Archivo, True)

            ReDim ARRcadena(0 To dtt.Rows.Count - 1)
            For i As Integer = 0 To dtt.Rows.Count - 1

                Strdatos = ruc_empresa_
                Strdatos = Strdatos & cod_servicio_
                Strdatos = Strdatos & Space(10)
                Strdatos = Strdatos & dtt(i)("PE_CODIGO").ToString.PadRight(10, "").Substring(0, 10)
                Strdatos = Strdatos & (dtt(i)("NOM_PER").ToString.Replace("Ñ", "N") & " " & dtt(i)("PE_APE_PAT").ToString.Replace("Ñ", "N") & " " & dtt(i)("PE_APE_MAT").ToString.Replace("Ñ", "N")).ToString.PadRight(30, "").Substring(0, 30)
                Strdatos = Strdatos & "1" 'situacion 1= Activo / 2= Anulado
                Strdatos = Strdatos & Space(8)
                Strdatos = Strdatos & "0.0000"
                Strdatos = Strdatos & Format(dtt(i)("IMPORTE"), "#####.00").ToString().PadLeft(10, "0").Substring(0, 10)
                Strdatos = Strdatos & ("0000000.00").ToString.PadRight(10, "").Substring(0, 10)
                Strdatos = Strdatos & ("0000000.00").ToString.PadRight(10, "").Substring(0, 10)
                Strdatos = Strdatos & ("0000000.00").ToString.PadRight(10, "").Substring(0, 10)
                Strdatos = Strdatos & ("0000000.00").ToString.PadRight(10, "").Substring(0, 10)
                Strdatos = Strdatos & ("0000000.00").ToString.PadRight(10, "").Substring(0, 10)


                If dtt(i)("PE_COD_INTERBANCA").ToString.Trim.Length > 0 Then
                    Strdatos = Strdatos & Space(14)
                Else
                    Strdatos = Strdatos & "14" & dtt(i)("CTA_CTE").ToString.Replace("-", "").Substring(0, 10) & "  "
                End If

                'Strdatos = Strdatos & "14" & dtt(i)("CTA_CTE").ToString.Replace("-", "").PadRight(10, "").Substring(0, 10) & "  "
                Strdatos = Strdatos & Space(16)
                Strdatos = Strdatos & "5"
                Strdatos = Strdatos & cuenta_cargo_.PadRight(14, "").Substring(0, 14)
                Strdatos = Strdatos & "01"
                Strdatos = Strdatos & dtt(i)("DOC_PER").ToString.PadRight(12, "").Substring(0, 12)
                Strdatos = Strdatos & responsable_.PadRight(30, "").Substring(0, 30)
                Strdatos = Strdatos & fecha_abono_.ToShortDateString.Replace("/", "") & " "
                If dtt(i)("PE_COD_INTERBANCA").ToString.Trim.Length > 0 Then
                    Strdatos = Strdatos & dtt(i)("PE_COD_INTERBANCA").ToString.Replace("-", "").Substring(0, 20)
                    'Strdatos = Strdatos & Space(20)
                End If


                sw.WriteLine(Strdatos)
                'ARRcadena(i) = Strdatos

            Next
            sw.Close()

            'File.WriteAllLines(Str_Ruta_Archivo, ARRcadena)

            Try
                If zipear_ Then
                    Dim drives As String()
                    drives = System.IO.Directory.GetLogicalDrives()
                    If drives.Length > 0 Then File.WriteAllLines(drives(0) & str_nombre_Archivo, ARRcadena)
                    Dim zip As New ZipFile(Str_vRutaPdt & "Banco\Sueldos.zip")
                    zip.AddFile(drives(0) & str_nombre_Archivo)
                    zip.Save()
                    Kill(drives(0) & str_nombre_Archivo)
                End If
            Catch ex As Exception

            End Try



        End Sub
    End Class

    Public Class SG_PL_Reportes
        Inherits ClsBD

        Public Function get_Tabla_Vacia()
            Return SqlHelper.ExecuteDataset(Cn, CommandType.Text, "SELECT '000S' AS 'CODIGO'").Tables(0)
        End Function

        Public Function get_Gra_Tardones_x_Anho(ayo_ As Integer, empresa_ As Integer) As DataTable
            Return SqlHelper.ExecuteDataset(Cn, "SG_PL_SP_S_TARDONES", ayo_, empresa_).Tables(0)
        End Function

        Public Function get_Gra_Tardones_x_Mes(ayo_ As Integer, mes_ As Integer, empresa_ As Integer) As DataTable
            If mes_ = 0 Then
                Return SqlHelper.ExecuteDataset(Cn, "SG_PL_SP_S_TARDONES_MES_TDOS", ayo_, empresa_).Tables(0)
            Else
                Return SqlHelper.ExecuteDataset(Cn, "SG_PL_SP_S_TARDONES_MES", ayo_, mes_, empresa_).Tables(0)
            End If
        End Function

        Public Function get_Gra_Distribucion_x_Cargo(IdEmpresa_ As Integer, bol_cesados_ As Boolean) As DataTable
            Return SqlHelper.ExecuteDataset(Cn, "SG_PL_SP_S_DISTRI_X_CARGOS", IIf(bol_cesados_, 1, 0), IdEmpresa_).Tables(0)
        End Function

        Public Function get_Gra_Distribucion_x_Grado_Ins(IdEmpresa_ As Integer, bol_cesados_ As Boolean) As DataTable
            Return SqlHelper.ExecuteDataset(Cn, "SG_PL_SP_S_NIVEL_EDU", IIf(bol_cesados_, 1, 0), IdEmpresa_).Tables(0)
        End Function

        Public Function get_Gra_Distribucion_x_Edad(IdEmpresa_ As Integer) As DataTable
            Return SqlHelper.ExecuteDataset(Cn, "SG_PL_SP_S_DISTRI_EDAD", IdEmpresa_).Tables(0)
        End Function

        Public Function get_Gra_Distribucion_x_Estado_Civil(IdEmpresa_ As Integer, bol_cesados_ As Boolean) As DataTable
            Return SqlHelper.ExecuteDataset(Cn, "SG_PL_SP_S_DISTRI_EST_CIVIL", IIf(bol_cesados_, 1, 0), IdEmpresa_).Tables(0)
        End Function

        Public Function get_Gra_Distribucion_x_Genero(IdEmpresa_ As Integer, bol_cesados_ As Boolean) As DataTable
            Return SqlHelper.ExecuteDataset(Cn, "SG_PL_SP_S_DISTRI_GENERO", IIf(bol_cesados_, 1, 0), IdEmpresa_).Tables(0)
        End Function

        Public Function get_Gra_Monto_Pagado_x_Periodo(IdEmpresa_ As Integer) As DataTable
            Return SqlHelper.ExecuteDataset(Cn, "SG_PL_SP_S_MONTO_PAGADO_PER", IdEmpresa_).Tables(0)
        End Function

        Public Function get_Estado_CtaCte_x_Emp(idpersonal_ As Integer, idestado_ As Integer, idmotivo_ As Integer, empresa_ As Integer) As DataTable

            Dim str_query As String = "SELECT PE_CODIGO,PE_APE_PAT+' '+PE_APE_MAT+' '+PE_NOM_PRI+' '+PE_NOM_SEG as 'PE_APE_PAT',CC_NUMERO,CC_FECHA_REGISTRO,MP_DESCRIPCION,CC_ID_MONEDA,CC_IMPORTE, "
            str_query = str_query + "CC_TC,CC_NUM_CUOTAS,CC_OBSERVACIONES,C.EP_DESCRIPCION AS 'ESTADO_CAB',CC_SALDO,CC_TDOC,CC_SDOC,CC_TASA_INTERES,CC_MONTO_TOTAL, "
            str_query = str_query + "CC_CUOTA_MENSUAL,CC_TOTAL_INTERES,CR_NUM_CUOTA,CR_FECHA_PAGO,CR_IMPORTE,C2.EP_DESCRIPCION AS 'ESTADO_DET',CR_CAPITAL,CR_CUOTA,CR_INTERES "
            str_query = str_query + "FROM SG_PL_TB_CTA_CTE A "
            str_query = str_query + "INNER JOIN SG_PL_TB_CTA_CTE_CRONOGRAMA B ON A.CC_ID = B.CR_ID_CTACTE "
            str_query = str_query + "INNER JOIN SG_PL_TB_ESTADO_PRESTAMO C ON A.CC_ESTADO = C.EP_ID "
            str_query = str_query + "INNER JOIN SG_PL_TB_ESTADO_PRESTAMO C2 ON B.CR_ESTADO = C2.EP_ID "
            str_query = str_query + "INNER JOIN SG_PL_TB_MOTIVO_PRESTAMO D ON A.CC_ID_MOTIVO = D.MP_ID "
            str_query = str_query + "INNER JOIN SG_PL_TB_PERSONAL E ON A.CC_ID_PERSONAL = E.PE_ID "
            str_query = str_query + "where e.pe_id_empresa =  " & empresa_

            If idpersonal_ > 0 Then
                str_query = str_query + " and a.CC_ID_PERSONAL = " & idpersonal_.ToString
            End If

            If idestado_ > 0 Then
                str_query = str_query + " and a.CC_ESTADO = " & idestado_.ToString
            End If

            If idmotivo_ > 0 Then
                str_query = str_query + " and a.CC_ID_MOTIVO = " & idmotivo_.ToString
            End If

            Return SqlHelper.ExecuteDataset(Cn, CommandType.Text, str_query).Tables(0)

        End Function

        Public Function get_Movimi_Vacaciones(fec_corte_ As Date, pc_ As String, idpersonal_ As Integer, inicio_ As Integer, empresa_ As Integer) As DataTable
            Return SqlHelper.ExecuteDataset(Cn, "SG_PL_SP_S_MOVI_VACA", fec_corte_, pc_, idpersonal_, inicio_, empresa_).Tables(0)
        End Function

        Public Function get_Movimi_Vacaciones_x_Cargo(fec_corte_ As Date, pc_ As String, idCargo_ As Integer, inicio_ As Integer, empresa_ As Integer) As DataTable
            Return SqlHelper.ExecuteDataset(Cn, "SG_PL_SP_S_MOVI_VACA_X_CARGO", fec_corte_, pc_, idCargo_, inicio_, empresa_).Tables(0)
        End Function

        Public Function get_Afp_Net(ayo_ As Integer, mes_ As Integer, empresa_ As Integer, todos_ As Integer) As DataTable
            Return SqlHelper.ExecuteDataset(Cn, "SG_PL_SP_S_AFP_NET", ayo_, mes_, empresa_, todos_).Tables(0)
        End Function

        Public Function get_Afp_Net_Excel(ayo_ As Integer, mes_ As Integer, empresa_ As Integer, todos_ As Integer) As DataTable
            Return SqlHelper.ExecuteDataset(Cn, "SG_PL_SP_S_AFP_NET_EXCEL", ayo_, mes_, empresa_, todos_).Tables(0)
        End Function

        Public Function get_Aportaciones_AFP(ayo_ As Integer, mes_ As Integer, tipoPer_ As Integer, empresa_ As Integer) As DataTable
            Return SqlHelper.ExecuteDataset(Cn, "SG_PL_SP_S_APORTACION_AFP", ayo_, mes_, tipoPer_, empresa_).Tables(0)
        End Function

        Public Function get_Aportaciones_AFP_Independiente(ayo_ As Integer, mes_ As Integer, empresa_ As Integer) As DataTable
            Return SqlHelper.ExecuteDataset(Cn, "SG_PL_SP_S_APORTACION_AFP_I", ayo_, mes_, empresa_).Tables(0)
        End Function

        Public Function get_Reporte_para_Bancos(ayo_ As Integer, mes_ As Integer, tipoPer_ As Integer, empresa_ As Integer, periodo_ As Integer, neto_ As Integer) As DataTable
            Return SqlHelper.ExecuteDataset(Cn, "SG_PL_SP_S_REP_BANCOS", ayo_, mes_, tipoPer_, periodo_, neto_, empresa_).Tables(0)
        End Function

        Public Function get_Reporte_para_Bancos_02(ayo_ As Integer, mes_ As Integer, tipoPer_ As Integer, empresa_ As Integer, periodo_ As Integer, neto_ As Integer) As DataTable
            Return SqlHelper.ExecuteDataset(Cn, "SG_PL_SP_S_REP_BANCOS_02", ayo_, mes_, tipoPer_, periodo_, neto_, empresa_).Tables(0)
        End Function

        Public Function get_Reporte_de_Pagos(ayo_ As Integer, mes_ As Integer, tipoPer_ As Integer, empresa_ As Integer) As DataTable
            Return SqlHelper.ExecuteDataset(Cn, "SG_PL_SP_S_REP_PAGOS", ayo_, mes_, tipoPer_, empresa_).Tables(0)
        End Function

        Public Function get_Detalle_de_Planilla(ayo_ As Integer, mes_ As Integer, tipoPer_ As Integer, p1_ As String, p2_ As String, p3_ As String, p4_ As String, empresa_ As Integer) As DataTable
            Return SqlHelper.ExecuteDataset(Cn, "SG_PL_SP_S_DETA_PLANILLAS", ayo_, mes_, tipoPer_, p1_, p2_, p3_, p4_, empresa_).Tables(0)
        End Function

        Public Function get_Dscto_Quinta_Acumulado(ayo_ As Integer, mes_ As Integer, tipo_ As Integer, idpersonal_ As Integer, empresa_ As Integer) As DataTable
            Return SqlHelper.ExecuteDataset(Cn, "SG_PL_SP_S_DSCTO_QUINTA", ayo_, tipo_, idpersonal_, empresa_).Tables(0)
        End Function

        Public Function get_Reprte_de_Folios(ayo_ As Integer, mes_ As Integer, empresa_ As Integer) As DataTable
            Return SqlHelper.ExecuteDataset(Cn, "SG_PL_SP_S_LISTAFOLIOS", ayo_, mes_, empresa_).Tables(0)
        End Function

        Public Function get_Cumpleanos_Personal(mes_ As Integer, estado_ As Integer, empresa_ As Integer) As DataTable
            Return SqlHelper.ExecuteDataset(Cn, "SG_PL_SP_S_CUMPLEANOS", mes_, estado_, empresa_).Tables(0)
        End Function

        Public Function get_Planilla_mes_1(ByVal ayo_ As Integer, ByVal mes_ As Integer, ByVal empresa_ As Integer, ByVal tipo_ As Integer) As DataTable
            Return SqlHelper.ExecuteDataset(Cn, "SG_PL_SP_S_PLANILLA_MES", ayo_, mes_, empresa_, tipo_).Tables(0)
        End Function

        Public Function get_info_empleado(ByVal cod_per As String, ByVal empresa As Integer) As DataTable

            Dim query As String = ""
            query = "SELECT PE_NOMBRE_VIA+' '+PE_NUMERO_VIA+' '+PE_INTERIOR+' '+PE_NOMBRE_ZONA+' '+PE_REFERENCIA +' - ' + UB_DESCRIPCION 'DIR_PER',PE_NUM_DOC_PER AS 'DOC_PER',EC_CARGO AS 'CARGO'   "
            query += "FROM SG_PL_TB_PERSONAL A "
            query += "LEFT JOIN SG_PL_TB_CARGO B ON A.PE_ID_CARGO = B.EC_ID AND A.PE_ID_EMPRESA = B.EC_IDEMPRESA "
            query += "LEFT JOIN SG_PL_TB_UBI_UBIGEO C ON A.PE_UBIGEO = C.UB_CODIGO "
            query += "WHERE PE_ID = " & cod_per

            Return SqlHelper.ExecuteDataset(Cn, CommandType.Text, query).Tables(0)

        End Function

        Public Function get_empleados_bdigf(ByVal empresa As Integer) As DataTable
            'Dim str_database As String = "Planilla"

            'Select Case empresa
            '    Case 1 'CLINICA MIRAFLORES S.A.C
            '        str_database = "Planilla"
            '    Case 2 'FERTI FARM S.A.C.
            '        str_database = "Planilla_Fertifarm"
            '    Case 3 'GESTAR S.A.C
            '        str_database = "Planilla_Gestar"
            '    Case 4 'GINEFERT SA.C
            '        str_database = "Planilla_Ginefert"
            '    Case 5 'GINECOLOGIA Y FERTILIDAD S.A.C
            '        str_database = "Planilla_GyFSAC"
            '    Case 6 'ECOGEST S.A.C
            '        str_database = "Planilla_Ecogest"
            '    Case 7 'BOTICA IGFARMA SAC
            '        str_database = "Planilla_Igfarma"
            'End Select

            'Dim cnigf As New SqlConnection("server=serverigf;user=ct;pwd=chelas;Initial catalog=" & str_database & ";Pooling=true; Min Pool Size=5; Max Pool Size=10; Pooling = True")
            'cnigf.Open()
            'Return SqlHelper.ExecuteDataset(cnigf, CommandType.Text, "SELECT COD_PER,APE_PAT+' '+APE_MAT+' '+NOM_PER AS NOMBRES FROM GPERSONA order by nombres").Tables(0)
            Return SqlHelper.ExecuteDataset(Cn, CommandType.Text, "SELECT PE_ID, PE_APE_PAT+' '+PE_APE_MAT+' '+PE_NOM_PRI+' '+PE_NOM_SEG AS 'NOMBRES' FROM SG_PL_TB_PERSONAL WHERE PE_ID_EMPRESA = " & empresa & "  AND PE_ID_EST_TRABAJADOR=1 ORDER BY 2").Tables(0)


        End Function

        Public Function get_afp_tmp(ByVal empresa As Integer) As DataTable
            'Dim str_database As String = "Planilla"

            'Select Case empresa
            '    Case 1 'CLINICA MIRAFLORES S.A.C
            '        str_database = "Planilla"
            '    Case 2 'FERTI FARM S.A.C.
            '        str_database = "Planilla_Fertifarm"
            '    Case 3 'GESTAR S.A.C
            '        str_database = "Planilla_Gestar"
            '    Case 4 'GINEFERT SA.C
            '        str_database = "Planilla_Ginefert"
            '    Case 5 'GINECOLOGIA Y FERTILIDAD S.A.C
            '        str_database = "Planilla_GyFSAC"
            '    Case 6 'ECOGEST S.A.C
            '        str_database = "Planilla_Ecogest"
            '    Case 7 'BOTICA IGFARMA SAC
            '        str_database = "Planilla_Igfarma"
            'End Select


            'Dim cnigf As New SqlConnection("server=serverigf;user=ct;pwd=chelas;Initial catalog=" & str_database & ";Pooling=true; Min Pool Size=5; Max Pool Size=10; Pooling = True")
            'cnigf.Open()
            'Return SqlHelper.ExecuteDataset(cnigf, CommandType.Text, "select * from afp order by 1").Tables(0)
            Return SqlHelper.ExecuteDataset(Cn, CommandType.Text, "SELECT * FROM SG_PL_TB_AFP WHERE AF_IDEMPRESA = " & empresa.ToString & " ORDER BY 1").Tables(0)
        End Function

        Public Function get_Liq_Anual_Aportes_Retenciones(ByVal anho As Integer, ByVal afp As Integer, ByVal empresa As Integer) As DataTable
            'Dim str_database As String = "Planilla"

            'Select Case empresa
            '    Case 1 'CLINICA MIRAFLORES S.A.C
            '        str_database = "Planilla"
            '    Case 2 'FERTI FARM S.A.C.
            '        str_database = "Planilla_Fertifarm"
            '    Case 3 'GESTAR S.A.C
            '        str_database = "Planilla_Gestar"
            '    Case 4 'GINEFERT SA.C
            '        str_database = "Planilla_Ginefert"
            '    Case 5 'GINECOLOGIA Y FERTILIDAD S.A.C
            '        str_database = "Planilla_GyFSAC"
            '    Case 6 'ECOGEST S.A.C
            '        str_database = "Planilla_Ecogest"
            '    Case 7 'BOTICA IGFARMA SAC
            '        str_database = "Planilla_Igfarma"
            'End Select


            'Dim cnigf As New SqlConnection("server=serverigf;user=ct;pwd=chelas;Initial catalog=" & str_database & ";Pooling=true; Min Pool Size=5; Max Pool Size=10; Pooling = True")
            'cnigf.Open()
            Return SqlHelper.ExecuteDataset(Cn, "SG_PL_LIQ_ANUAL_APORTES_RETENC", anho, afp, empresa).Tables(0)

        End Function

        Public Function get_Certi_Rentas_Reten_5ta(ByVal empleado As String, ByVal anho As Integer, ByVal empresa As Integer) As DataTable
            'Dim str_database As String = "Planilla"

            'Select Case empresa
            '    Case 1 'CLINICA MIRAFLORES S.A.C
            '        str_database = "Planilla"
            '    Case 2 'FERTI FARM S.A.C.
            '        str_database = "Planilla_Fertifarm"
            '    Case 3 'GESTAR S.A.C
            '        str_database = "Planilla_Gestar"
            '    Case 4 'GINEFERT SA.C
            '        str_database = "Planilla_Ginefert"
            '    Case 5 'GINECOLOGIA Y FERTILIDAD S.A.C
            '        str_database = "Planilla_GyFSAC"
            '    Case 6 'ECOGEST S.A.C
            '        str_database = "Planilla_Ecogest"
            '    Case 7 'BOTICA IGFARMA SAC
            '        str_database = "Planilla_Igfarma"
            'End Select

            'Dim cnigf As New SqlConnection("server=serverigf;user=ct;pwd=chelas;Initial catalog=" & str_database & ";Pooling=true; Min Pool Size=5; Max Pool Size=10; Pooling = True")
            'cnigf.Open()
            Return SqlHelper.ExecuteDataset(Cn, "SG_PL_CERTI_RENTAS_RETEN_5TA", empleado, anho, empresa).Tables(0)

        End Function

        Public Function get_Comproba_trabaja_reten(personal_ As Integer, empresa_ As Integer) As DataTable
            Return SqlHelper.ExecuteDataset(Cn, "SG_PL_SP_S_COMPRO_TRABA_RETEN", personal_, empresa_).Tables(0)
        End Function

        Public Function get_Boleta_Mensual(ByVal ayo_ As Integer, ByVal mes_ As Integer, ByVal tipopersonal_ As Integer, ByVal idpersonal_ As Integer, ByVal pc_ As String, ByVal empresa_ As Integer) As DataTable
            Return SqlHelper.ExecuteDataset(Cn, "SG_PL_SP_S_BOLETA", ayo_, mes_, tipopersonal_, idpersonal_, pc_, empresa_).Tables(0)
        End Function
    End Class

    Public Class SG_PL_TB_COMPRA_VACA
        Inherits ClsBD

        Public Function get_Compras(empresa As BE.ContabilidadBE.SG_CO_TB_EMPRESA) As DataSet

            Dim ds_tmp As DataSet = SqlHelper.ExecuteDataset(Cn, "SG_PL_SP_S_COMPRA_VACA", empresa.EM_ID)
            ds_tmp.Relations.Add("cod_empleado", ds_tmp.Tables(0).Columns("CV_ID_PERSONAL"), ds_tmp.Tables(1).Columns("CV_ID_PERSONAL"))

            Return ds_tmp
        End Function

        Public Sub get_Compra(ByRef entidad As BE.PlanillaBE.SG_PL_TB_COMPRA_VACA)
            Dim drr As SqlDataReader = SqlHelper.ExecuteReader(Cn, "SG_PL_SP_S_COMPRA_VACA_BYID", entidad.CV_ID)

            If drr.HasRows Then
                drr.Read()

                With entidad
                    .CV_ID_PERSONAL = drr("CV_ID_PERSONAL")
                    .CV_DIAS = drr("CV_DIAS")
                    .CV_IMPORTE = drr("CV_IMPORTE")
                    .CV_PERIODO = drr("CV_PERIODO")
                    .CV_FECHA_LIQUI = drr("CV_FECHA_LIQUI")
                    .CV_OBS = drr("CV_OBS")
                    .CV_PROCESAR = drr("CV_PROCESAR")
                End With
            End If

            drr.Close()
            drr = Nothing

        End Sub

        Public Sub Insert(entidad As BE.PlanillaBE.SG_PL_TB_COMPRA_VACA)
            With entidad
                SqlHelper.ExecuteNonQuery(Cn, "SG_PL_SP_I_COMPRA_VACA", .CV_ID_PERSONAL, .CV_DIAS, .CV_IMPORTE, .CV_PERIODO, .CV_FECHA_LIQUI, .CV_OBS, .CV_PROCESAR)
            End With
        End Sub

        Public Sub Update(entidad As BE.PlanillaBE.SG_PL_TB_COMPRA_VACA)
            With entidad
                SqlHelper.ExecuteNonQuery(Cn, "SG_PL_SP_U_COMPRA_VACA", .CV_ID, .CV_ID_PERSONAL, .CV_DIAS, .CV_IMPORTE, .CV_PERIODO, .CV_FECHA_LIQUI, .CV_OBS, .CV_PROCESAR)
            End With
        End Sub

        Public Sub Delete(entidad As BE.PlanillaBE.SG_PL_TB_COMPRA_VACA)
            SqlHelper.ExecuteNonQuery(Cn, "SG_PL_SP_D_COMPRA_VACA", entidad.CV_ID)
        End Sub

    End Class

    Public Class SG_PL_TB_FOLIO_DOC_COMPRO
        Inherits ClsBD

        Public Sub Insert(entidad As BE.PlanillaBE.SG_PL_TB_FOLIO_DOC_COMPRO)

            SqlHelper.ExecuteNonQuery(Cn, "SG_PL_SP_D_FOLIO_DOC_COMPRO", entidad.FC_IDFOLIO, entidad.FC_IDPERSONAL, _
                                                                                entidad.FC_ANHO, entidad.FC_MES, entidad.FC_IDEMPRESA)

            SqlHelper.ExecuteNonQuery(Cn, "SG_PL_SP_I_FOLIO_DOC_COMPRO", entidad.FC_IDFOLIO, entidad.FC_IDPERSONAL, _
                                      entidad.FC_ANHO, entidad.FC_MES, entidad.FC_TDOC, entidad.FC_SDOC, _
                                      entidad.FC_NDOC, entidad.FC_BASE, entidad.FC_IGV, entidad.FC_IMPORTE, entidad.FC_IDEMPRESA)
        End Sub

        Public Function get_Info_Trabajador(entidad As BE.PlanillaBE.SG_PL_TB_FOLIO_DOC_COMPRO) As DataTable
            Return SqlHelper.ExecuteDataset(Cn, "SG_PL_SP_S_FOLIO_DOC_COMPRO", entidad.FC_IDFOLIO, entidad.FC_IDPERSONAL, _
                                                                                entidad.FC_ANHO, entidad.FC_MES, entidad.FC_IDEMPRESA).Tables(0)
        End Function
    End Class

    Public Class SG_PL_TB_PARAMETROS
        Inherits ClsBD

        Public Function get_Valor(ByVal entidad As BE.PlanillaBE.SG_PL_TB_PARAMETROS) As String
            Return SqlHelper.ExecuteScalar(Cn, "SG_PL_SP_S_VAL_PARA", entidad.AD_TIPO, entidad.AD_NOMBRE, entidad.AD_IDEMPRESA)
        End Function

        Public Function get_Lista_Parametros(empresa As BE.ContabilidadBE.SG_CO_TB_EMPRESA) As DataTable
            Return SqlHelper.ExecuteDataset(Cn, "SG_PL_SP_S_PARAMETROS", empresa.EM_ID).Tables(0)
        End Function

        Public Sub Insert(ByVal entidad As BE.PlanillaBE.SG_PL_TB_PARAMETROS)
            SqlHelper.ExecuteNonQuery(Cn, "SG_PL_SP_I_PARAMETROS", entidad.AD_TIPO, entidad.AD_NOMBRE, entidad.AD_VALOR, entidad.AD_IDEMPRESA)
        End Sub

        Public Sub Update(ByVal entidad As BE.PlanillaBE.SG_PL_TB_PARAMETROS)
            SqlHelper.ExecuteNonQuery(Cn, "SG_PL_SP_U_PARAMETROS", entidad.AD_TIPO, entidad.AD_NOMBRE, entidad.AD_VALOR, entidad.AD_IDEMPRESA)
        End Sub

        Public Sub Delete(ByVal entidad As BE.PlanillaBE.SG_PL_TB_PARAMETROS)
            SqlHelper.ExecuteNonQuery(Cn, "SG_PL_SP_D_PARAMETROS", entidad.AD_TIPO, entidad.AD_NOMBRE, entidad.AD_IDEMPRESA)
        End Sub

    End Class


    Public Class SG_PL_TB_PERMISO_INFO_PLA
        Inherits ClsBD

        Public Sub Insert(ByVal idpersonal As Integer)
            SqlHelper.ExecuteNonQuery(Cn, "SG_PL_SP_I_PER_INFO_PER", idpersonal)
        End Sub
        Public Sub Delete()
            SqlHelper.ExecuteNonQuery(Cn, "SG_PL_SP_D_PER_INFO_PER")
        End Sub

        Public Sub Delete_x_Idusuario(ByVal idUsuario As Integer)
            SqlHelper.ExecuteNonQuery(Cn, "SG_PL_SP_D_PER_INFO_PER_BYID", idUsuario)
        End Sub

        Public Function get_usuarios() As DataTable
            Return SqlHelper.ExecuteDataset(Cn, "SG_PL_SP_S_PER_INFO").Tables(0)
        End Function

    End Class

    Public Class SG_PL_TB_PERSONAL_REMUNERACION
        Inherits ClsBD

        Public Sub Insert(ByVal entidad As BE.PlanillaBE.SG_PL_TB_PERSONAL_REMUNERACION)
            With entidad
                SqlHelper.ExecuteNonQuery(Cn, "SG_PL_SP_I_REMUNERACIONES", .PR_IDPERSONAL, .PR_ITEM, .PR_FECHA, .PR_REMUNERACION, .PR_USUARIO, .PR_TERMINAL, .PR_FECREG)
            End With
        End Sub

        Public Sub Delete(ByVal entidad As BE.PlanillaBE.SG_PL_TB_PERSONAL_REMUNERACION)
            With entidad
                SqlHelper.ExecuteNonQuery(Cn, "SG_PL_SP_D_REMUNERACIONES", .PR_IDPERSONAL, .PR_ITEM)
            End With
        End Sub

        Public Function get_Remuneracion_x_Personal(ByVal personalBE As BE.PlanillaBE.SG_PL_TB_PERSONAL) As DataTable
            Return SqlHelper.ExecuteDataset(Cn, "SG_PL_SP_S_REMU_X_PERSONAL", personalBE.PE_ID).Tables(0)
        End Function

        Public Function get_Ultima_Remuneracion(ByVal entidad As BE.PlanillaBE.SG_PL_TB_PERSONAL_REMUNERACION) As Double
            Return SqlHelper.ExecuteScalar(Cn, "SG_PL_SP_S_ULT_REMU_X_PERSONAL", entidad.PR_IDPERSONAL)
        End Function

    End Class

    Public Class SG_PL_TB_PAIS
        Inherits ClsBD

        Public Function get_Paises() As DataTable
            Return SqlHelper.ExecuteDataset(Cn, "SG_PL_SP_S_PAIS").Tables(0)
        End Function
    End Class

    Public Class SG_PL_TB_MOTIVO_BAJA
        Inherits ClsBD

        Public Function get_Motivos() As DataTable
            Return SqlHelper.ExecuteDataset(Cn, "SG_PL_sp_s_MOTIVO_BAJA").Tables(0)
        End Function

    End Class

    Public Class SG_PL_TB_DOC_SUSTENTA_VIN_FAM
        Inherits ClsBD
        Public Function get_Documentos() As DataTable
            Return SqlHelper.ExecuteDataset(Cn, CommandType.StoredProcedure, "SG_PL_SP_S_DOC_SUSTENTA_VIN_FAM").Tables(0)
        End Function

    End Class

    Public Class SG_PL_TB_VINCULO_FAMILIAR
        Inherits ClsBD

        Public Function get_vinculos() As DataTable
            Return SqlHelper.ExecuteDataset(Cn, CommandType.StoredProcedure, "SG_PL_SP_S_VINCULO_FAMILIAR").Tables(0)
        End Function

    End Class

    Public Class SG_PL_TB_DERECHO_HABIENTE
        Inherits ClsBD

        Public Sub Insert(ByVal Entidad As BE.PlanillaBE.SG_PL_TB_DERECHO_HABIENTE)
            With Entidad
                SqlHelper.ExecuteNonQuery(Cn, "SG_PL_SP_I_DERECHO_HAB", .DA_IDPERSONAL, .DA_TDOC_DA, _
                                          .DA_NDOC_DA, .DA_IDPAIS, .DA_FEC_NAC, .DA_APE_PAT, .DA_APE_MAT, _
                                          .DA_NOMBRES, .DA_SEXO, .DA_VINCULO_FAM, .DA_TDOC_ACRE_VIN, _
                                          .DA_NDOC_ACRE_VIN, .DA_MES_CONCEPCION, .DA_TIPO_VIA, _
                                          .DA_NOM_VIA, .DA_NUM_VIA, .DA_DEPARTAMENTO, .DA_INTERIOR, _
                                          .DA_MANZANA, .DA_LOTE, .DA_KILOMETRO, .DA_BLOCK, .DA_ETAPA, _
                                          .DA_TIPO_ZONA, .DA_NOM_ZONA, .DA_REFERENCIA, .DA_UBIGEO, _
                                          .DA_TEL_COD_CIUDAD, .DA_TEL_NUMERO, .DA_CORREO, .DA_USUARIO, _
                                          .DA_TERMINAL, .DA_FECREG)
            End With
        End Sub

        Public Sub Update(ByVal Entidad As BE.PlanillaBE.SG_PL_TB_DERECHO_HABIENTE)
            With Entidad
                SqlHelper.ExecuteNonQuery(Cn, "SG_PL_SP_U_DERECHO_HAB", .DA_IDPERSONAL, .DA_TDOC_DA, _
                                          .DA_NDOC_DA, .DA_IDPAIS, .DA_FEC_NAC, .DA_APE_PAT, .DA_APE_MAT, _
                                          .DA_NOMBRES, .DA_SEXO, .DA_VINCULO_FAM, .DA_TDOC_ACRE_VIN, _
                                          .DA_NDOC_ACRE_VIN, .DA_MES_CONCEPCION, .DA_TIPO_VIA, _
                                          .DA_NOM_VIA, .DA_NUM_VIA, .DA_DEPARTAMENTO, .DA_INTERIOR, _
                                          .DA_MANZANA, .DA_LOTE, .DA_KILOMETRO, .DA_BLOCK, .DA_ETAPA, _
                                          .DA_TIPO_ZONA, .DA_NOM_ZONA, .DA_REFERENCIA, .DA_UBIGEO, _
                                          .DA_TEL_COD_CIUDAD, .DA_TEL_NUMERO, .DA_CORREO, .DA_USUARIO, _
                                          .DA_TERMINAL, .DA_FECREG, _
                                          IIf(.DA_FEC_BAJA = String.Empty, DBNull.Value, .DA_FEC_BAJA), _
                                          .DA_IDMOTIVO)
            End With
        End Sub

        Public Sub Delete(ByVal Entidad As BE.PlanillaBE.SG_PL_TB_DERECHO_HABIENTE)
            With Entidad
                SqlHelper.ExecuteNonQuery(Cn, "SG_PL_SP_D_DERECHO_HAB", .DA_IDPERSONAL, .DA_TDOC_DA, _
                                          .DA_NDOC_DA)
            End With
        End Sub

        Public Function get_Derecho_Habiente(ByVal Entidad As BE.PlanillaBE.SG_PL_TB_DERECHO_HABIENTE) As DataTable
            Return SqlHelper.ExecuteDataset(Cn, "SG_PL_SP_S_DERECHO_HAB", Entidad.DA_IDPERSONAL).Tables(0)
        End Function

        Public Function get_Derecho_Habiente_x_IdPersonal(ByVal Entidad As BE.PlanillaBE.SG_PL_TB_DERECHO_HABIENTE) As DataTable
            Return SqlHelper.ExecuteDataset(Cn, "SG_PL_SP_S_DERECHO_HAB_BYID", Entidad.DA_IDPERSONAL, Entidad.DA_TDOC_DA, Entidad.DA_NDOC_DA).Tables(0)
        End Function

        Public Function get_Derecho_Habiente_Rep(ByVal empresa_ As Integer) As DataTable
            Return SqlHelper.ExecuteDataset(Cn, "SG_PL_SP_S_DERECHO_HAB_REP", empresa_).Tables(0)
        End Function

    End Class


    Public Class SG_PL_TB_PERSONAL_HORAS_CAB
        Inherits ClsBD
        'Entidad o clase que almacena las horas del personal de
        'tecnicas / Enfermeras
        'SG_PL_TB_PERSONAL_HORAS_CAB = cabecera
        'SG_PL_TB_PERSONAL_HORAS_DET = detalle

        Public Sub Update_Visto_Bueno_RR_HH(ByVal Entidad_C As BE.PlanillaBE.SG_PL_TB_PERSONAL_HORAS_CAB)
            Dim query As String = ""
            With Entidad_C
                query = "UPDATE SG_PL_TB_PERSONAL_HORAS_CAB SET  PHC_OK_CONTABILIDAD = " & .PHC_OK_CONTABILIDAD.ToString & " WHERE PHC_ANHO = " & .PHC_ANHO.ToString & " AND PHC_MES = " & .PHC_MES.ToString & " AND PHC_IDEMPRESA = " & .PHC_IDEMPRESA.ToString
            End With

            SqlHelper.ExecuteNonQuery(Cn, CommandType.Text, query)

        End Sub

        Public Function get_Cabeceras_Para_Visto(ayo_ As Integer, mes_ As Integer, empresa_ As Integer) As DataTable
            Return SqlHelper.ExecuteDataset(Cn, "SG_PL_SP_S_LISTA_VISTA_RRHH", ayo_, mes_, empresa_).Tables(0)
        End Function

        Public Function get_Estado_por_Periodo(ByVal ayo_ As Integer, ByVal mes_ As Integer, ByVal empresa_ As Integer) As DataTable
            Return SqlHelper.ExecuteDataset(Cn, "SG_PL_SP_S_ESTADO_X_PERIODO", ayo_, mes_, empresa_).Tables(0)
        End Function

        Public Function get_calcular_Horas_PTE(ByVal idpersonal As Integer, ByVal ayo As Integer, _
                                               ByVal mes As Integer, ByVal idtipoPersonal As Integer, _
                                               ByVal fecha_proc As String, ByVal usuario As String, _
                                               ByVal pc As String, ByVal fecha_reg As String, _
                                               ByVal empresa As Integer) As Double

            Return SqlHelper.ExecuteScalar(Cn, "SG_PL_SP_S_HORASPTE_X_PERIODO", idpersonal, _
                                           ayo, mes, idtipoPersonal, fecha_proc, usuario, pc, fecha_reg, empresa)

        End Function

        Public Function get_Refrigerios(ayo_ As Integer, mes_ As Integer, personal_ As Integer, empresa_ As Integer) As Integer

            Dim respuesta As Integer = 0
            Dim drr As SqlDataReader = SqlHelper.ExecuteReader(Cn, "SG_PL_SP_S_REFRIS_X_PERSO", ayo_, mes_, personal_, empresa_)

            If drr.HasRows Then
                drr.Read()
                respuesta = drr(0)
            End If

            drr.Close()

            Return respuesta

        End Function

        Public Function get_Horas_personal_NoEnfTec(ByVal idpersonal_ As Integer, ByVal ayo_ As Integer, ByVal mes_ As Integer, ByVal empresa_ As Integer) As Double

            Return SqlHelper.ExecuteScalar(Cn, "SG_PL_SP_S_VALHRA_X_PERSO_NO_ENFTEC", idpersonal_, _
                                           ayo_, mes_, empresa_)
        End Function

        Public Sub Horas_Extras_Personal_Hospi(ByVal personalBE As BE.PlanillaBE.SG_PL_TB_PERSONAL, ByVal ayo_ As Integer, _
                                               ByVal mes_ As Integer, empresa_ As Integer, ByRef hora_ext_sim As Double, ByRef hora_ext_dob As Double)

            Dim horaFija As Double = 0
            Dim horaExtra_s As Double = 0
            Dim horaExtra_d As Double = 0

            Dim query As New System.Text.StringBuilder
            query.Append("SELECT PHD_HORA_F,PHD_HORA_E,PHD_HORA_E_DOBLE ")
            query.Append("FROM SG_PL_TB_PERSONAL_HORAS_DET   ")
            query.Append("WHERE PHD_ANHO = " & ayo_.ToString & " AND PHD_MES = " & mes_.ToString & " ")
            query.Append("AND PHD_IDEMPRESA = " & empresa_.ToString & " AND PHD_IDPERSONAL = " & personalBE.PE_ID.ToString)

            Dim drr As SqlDataReader = SqlHelper.ExecuteReader(Cn, CommandType.Text, query.ToString)
            If drr.HasRows Then
                drr.Read()
                horaFija = drr("PHD_HORA_F")
                horaExtra_s = drr("PHD_HORA_E")
                horaExtra_d = drr("PHD_HORA_E_DOBLE")
            End If
            drr.Close()
            drr = Nothing

            'redondear importes

            Dim parte_decimal As Double = 0


            parte_decimal = horaExtra_s - Convert.ToInt32(horaExtra_s)

            If parte_decimal >= 0.3 Then
                hora_ext_sim = Convert.ToInt32(horaExtra_s) + 0.5
            Else
                hora_ext_sim = Convert.ToInt32(horaExtra_s)
            End If


            parte_decimal = horaExtra_d - Convert.ToInt32(horaExtra_d)

            If parte_decimal >= 30 Then
                hora_ext_dob = Convert.ToInt32(horaExtra_d) + 0.5
            Else
                hora_ext_dob = Convert.ToInt32(horaExtra_d)
            End If


        End Sub


        Public Function Planilla_Horas_Visto_ok(ayo_ As Integer, mes_ As Integer, empresa_ As Integer) As Boolean
            Dim rpta As Boolean = False

            Dim query As New System.Text.StringBuilder
            query.Append("SELECT PHC_OK_SISTEMAS,PHC_OK_CONTABILIDAD,PHC_ESTADO ")
            query.Append("FROM SG_PL_TB_PERSONAL_HORAS_CAB ")
            query.Append("WHERE PHC_ANHO = " & ayo_.ToString & " AND PHC_MES = " & mes_.ToString & " AND PHC_IDEMPRESA  = " & empresa_.ToString)

            Dim drr As SqlDataReader = SqlHelper.ExecuteReader(Cn, CommandType.Text, query.ToString)
            If drr.HasRows Then
                drr.Read()

                If drr("PHC_OK_SISTEMAS") = 1 And drr("PHC_OK_CONTABILIDAD") = 1 Then
                    rpta = True
                End If

            End If

            Return rpta

        End Function

    End Class

    Public Class SG_PL_TB_TOPE_MENSUAL
        Inherits ClsBD

        Public Sub Update(ByVal Entidad As BE.PlanillaBE.SG_PL_TB_TOPE_MENSUAL)
            SqlHelper.ExecuteNonQuery(Cn, "SG_PL_SP_U_TOPE_MENSUAL", Entidad.TM_PERIODO, Entidad.TM_MES, Entidad.TM_VALOR, Entidad.TM_IDEMPRESA.EM_ID)
        End Sub

        Public Function get_tope_mensual(ByVal Entidad As BE.PlanillaBE.SG_PL_TB_TOPE_MENSUAL) As Double
            Return SqlHelper.ExecuteScalar(Cn, "SG_PL_SP_S_TOPE_MEN_X_MES", Entidad.TM_PERIODO, Entidad.TM_MES, Entidad.TM_IDEMPRESA.EM_ID)
        End Function

        Public Function get_Lista_Tope_Mensual(Entidad As BE.PlanillaBE.SG_PL_TB_TOPE_MENSUAL) As DataTable
            Return SqlHelper.ExecuteDataset(Cn, "SG_PL_SP_S_LISTATOPEMEN", Entidad.TM_PERIODO, Entidad.TM_IDEMPRESA.EM_ID).Tables(0)
        End Function

    End Class

    Public Class SG_PL_TB_HISTORIAL
        Inherits ClsBD

        Public Sub Insert(ByVal Entidad As BE.PlanillaBE.SG_PL_TB_HISTORIAL)
            With Entidad
                SqlHelper.ExecuteNonQuery(Cn, "SG_PL_SP_I_HISTORIAL", .HI_ID_PERSONAL.PE_ID, .HI_MES, .HI_FEC_OPE, .HI_COD_HD.CO_ID, .HI_MONTO, .HI_IDEN_HD, .HI_EST_ASI, .HI_COD_AFP, .HI_DES_HD, .HI_HORAS, .HI_ID_EMPRESA.EM_ID, .HI_USUARIO, .HI_TERMINAL, .HI_FECREG, IIf(.HI_ID_CTACTE = 0, DBNull.Value, .HI_ID_CTACTE), IIf(.HI_NUM_CUOTA_CTACTE = 0, DBNull.Value, .HI_NUM_CUOTA_CTACTE), .HI_DIAS_VACA)
            End With
        End Sub

        Public Function get_Historial() As DataTable
            Return SqlHelper.ExecuteDataset(Cn, "").Tables(0)
        End Function

        Public Sub Delete(ByVal Entidad As BE.PlanillaBE.SG_PL_TB_HISTORIAL)
            SqlHelper.ExecuteNonQuery(Cn, "SG_PL_SP_D_HISTORIAL_BY_IDPERSON", Entidad.HI_ID_PERSONAL.PE_ID, Entidad.HI_ID_EMPRESA.EM_ID, Entidad.HI_FEC_OPE)
        End Sub

        Public Function get_Consulta_Boleta(ByVal Entidad As BE.PlanillaBE.SG_PL_TB_HISTORIAL) As DataSet
            Return SqlHelper.ExecuteDataset(Cn, "SG_PL_SP_S_CON_BOLETA", Entidad.HI_ID_PERSONAL.PE_ID, _
                                                                    Entidad.HI_FEC_OPE, _
                                                                    Entidad.HI_MES, _
                                                                    Entidad.HI_ID_EMPRESA.EM_ID)
        End Function

        Public Function get_Consulta_Boleta_Mantenimiento(ByVal Entidad As BE.PlanillaBE.SG_PL_TB_HISTORIAL) As DataSet
            Return SqlHelper.ExecuteDataset(Cn, "SG_PL_SP_S_CON_BOLETA_MANTE", Entidad.HI_ID_PERSONAL.PE_ID, _
                                                                    Entidad.HI_FEC_OPE, _
                                                                    Entidad.HI_MES, _
                                                                    Entidad.HI_ID_EMPRESA.EM_ID)
        End Function

        Public Function get_Personal_Planilla(ByVal ayo_ As Integer, ByVal mes_ As Integer, ByVal empresa_ As Integer, ByVal tipo_ As Integer) As DataTable
            Return SqlHelper.ExecuteDataset(Cn, "SG_PL_SP_LISTA_PERSO_PLANI", ayo_, mes_, empresa_, tipo_).Tables(0)
        End Function

        Public Function get_CentroCosto_x_Persona(ByVal id_perso_ As Integer) As DataTable
            Dim query As String = "SELECT CC_CC,CC_PORCENTAJE FROM SG_PL_TB_PERSONAL_CCOSTO WHERE  CC_ID_PERSONA = " & id_perso_.ToString & " AND CC_PORCENTAJE > 0 ORDER BY CC_CC "
            Return SqlHelper.ExecuteDataset(Cn, CommandType.Text, query).Tables(0)
        End Function

        Public Function get_Boleta_x_Persona(ByVal ayo_ As Integer, ByVal mes_ As Integer, ByVal empresa_ As Integer, ByVal idepersona_ As Integer) As DataTable
            Dim query As String = "SELECT HI_COD_HD,HI_MONTO FROM SG_PL_TB_HISTORIAL WHERE YEAR(HI_FEC_OPE) = " & ayo_.ToString & " AND MONTH(HI_FEC_OPE) = " & mes_.ToString & " AND HI_ID_PERSONAL = " & idepersona_ & " and HI_ID_EMPRESA = " & empresa_.ToString
            Return SqlHelper.ExecuteDataset(Cn, CommandType.Text, query).Tables(0)
        End Function

        Public Function get_Info_CtaDestino(ByVal cta6_ As String, ByVal cta9_ As String, ByVal ayo_ As Integer, ByVal empresa_ As Integer) As List(Of String)
            Dim ls_respuesta As New List(Of String)
            Dim drr As SqlDataReader = SqlHelper.ExecuteReader(Cn, "SG_CO_SP_S_INFO_CTA_DES", cta6_, cta9_, ayo_, empresa_)
            If drr.HasRows Then
                While drr.Read()
                    ls_respuesta.Add(drr("CD_CTA_DESTINO"))
                    ls_respuesta.Add(drr("CD_DH"))
                End While
                
            End If
            drr.Close()
            drr = Nothing

            Return ls_respuesta
        End Function

        Public Function get_Todas_Cuentas_Destino(ByVal ayo_ As Integer, ByVal empresa_ As Integer) As DataTable
            Return SqlHelper.ExecuteDataset(Cn, "SG_CO_SP_S_CTAS_DES_TODAS", ayo_, empresa_).Tables(0)
        End Function

        Public Function get_Dif_Haber_Descto(ayo_ As Integer, mes_ As Integer, tipoPer_ As Integer, empresa_ As Integer) As Double
            Return SqlHelper.ExecuteScalar(Cn, "SG_PL_SP_S_DIF_HAB_DES", ayo_, mes_, tipoPer_, empresa_)
        End Function

        Public Function Existe_Asiento_Planilla(anho_ As Integer, mes_ As Integer, subdiario_ As String, empresa_ As Integer) As Boolean
            Dim result As Boolean = False
            Dim query As String = "select isnull(count(*),0) from sg_co_tb_asiento_cab where AC_IDSUBDIARIO = '" & subdiario_ & "' and AC_ANHO =  " & anho_ & " and AC_MES = " & mes_ & " and AC_IDEMPRESA = " & empresa_
            Dim rpta As Integer = SqlHelper.ExecuteScalar(Cn, CommandType.Text, query)
            If rpta > 0 Then result = Not result
            Return result
        End Function

        Public Sub Delete_Asiento_Planilla(anho_ As Integer, mes_ As Integer, subdiario_ As String, empresa_ As Integer)
            Dim query As String = "Delete from sg_co_tb_asiento_cab where AC_IDSUBDIARIO = '" & subdiario_ & "' and AC_ANHO =  " & anho_ & " and AC_MES = " & mes_ & " and AC_IDEMPRESA = " & empresa_
            SqlHelper.ExecuteNonQuery(Cn, CommandType.Text, query)
        End Sub





    End Class

    Public Class SG_PL_TB_PERSONAL_CONCEPTO
        Inherits ClsBD

        Public Sub Insert(ByVal Entidad As BE.PlanillaBE.SG_PL_TB_PERSONAL_CONCEPTO)
            With Entidad
                SqlHelper.ExecuteNonQuery(Cn, "SG_PL_SP_I_PERSONAL_CONCEPTO", .PC_ID_PERSONAL.PE_ID, .PC_ID_CONCEPTO.CO_ID, .PC_VALOR, .PC_ID_EMPRESA.EM_ID)
            End With
        End Sub

        Public Sub Update(ByVal Entidad As BE.PlanillaBE.SG_PL_TB_PERSONAL_CONCEPTO)
            With Entidad
                SqlHelper.ExecuteNonQuery(Cn, "SG_PL_SP_U_PERSONAL_CONCEPTO", .PC_ID_PERSONAL.PE_ID, .PC_ID_CONCEPTO.CO_ID, .PC_VALOR, .PC_ID_EMPRESA.EM_ID)
            End With
        End Sub

        Public Sub Delete(ByVal Entidad As BE.PlanillaBE.SG_PL_TB_PERSONAL_CONCEPTO)
            With Entidad
                SqlHelper.ExecuteNonQuery(Cn, "SG_PL_SP_D_PERSONAL_CONCEPTO", .PC_ID_PERSONAL.PE_ID, .PC_ID_CONCEPTO.CO_ID, .PC_ID_EMPRESA.EM_ID)
            End With
        End Sub

        Public Function get_Conceptos(ByVal Entidad As BE.PlanillaBE.SG_PL_TB_PERSONAL) As DataTable
            Return SqlHelper.ExecuteDataset(Cn, "SG_PL_SP_S_PERSONAL_CONCEPTO", Entidad.PE_ID).Tables(0)
        End Function


    End Class

    Public Class SG_PL_TB_CTA_CTE_CRONOGRAMA
        Inherits ClsBD

        Public Sub Update(ByVal Entidad As BE.PlanillaBE.SG_PL_TB_CTA_CTE_CRONOGRAMA)
            With Entidad
                SqlHelper.ExecuteNonQuery(Cn, "SG_PL_SP_U_CTA_CTE_CRONOGRAMA", .CR_ID_CTACTE.CC_ID, .CR_NUM_CUOTA, .CR_FECHA_PAGO, .CR_IMPORTE, .CR_ESTADO.EP_ID, .CR_TIPO_PAGO, .CR_NO_CONSIDERAR)
            End With

            SqlHelper.ExecuteNonQuery(Cn, CommandType.Text, "UPDATE SG_PL_TB_CTA_CTE SET CC_NUM_CUOTAS = " & Entidad.CR_NUM_CUOTA & " WHERE CC_ID = " & Entidad.CR_ID_CTACTE.CC_ID)

        End Sub

        Public Sub Delete(ByVal Entidad As BE.PlanillaBE.SG_PL_TB_CTA_CTE_CRONOGRAMA)
            SqlHelper.ExecuteNonQuery(Cn, "SG_PL_SP_D_CTA_CTE_CRONOGRAMA", Entidad.CR_ID_CTACTE.CC_ID,Entidad.CR_NUM_CUOTA)
        End Sub

        Public Function get_Cronograma(ByVal Entidad As BE.PlanillaBE.SG_PL_TB_CTA_CTE) As DataTable
            Return SqlHelper.ExecuteDataset(Cn, "SG_PL_SP_S_CTA_CTE_CRONO", Entidad.CC_ID).Tables(0)
        End Function

        Public Function get_Importe_aPagar_x_Trabajador(ByVal idempleado As Integer, ByVal ayo As Integer, ByVal mes As Integer) As List(Of Double)

            Dim lista As New List(Of Double)
            Dim drr As SqlDataReader = SqlHelper.ExecuteReader(Cn, "SG_PL_SP_S_IMPORTE_APAGAR_X_EMP", idempleado, ayo, mes)

            If drr.HasRows Then
                drr.Read()
                lista.Add(drr(0))
                lista.Add(drr(1))
                lista.Add(drr(2))
                lista.Add(drr(3))
            End If
            drr.Close()
            drr = Nothing

            Return lista
        End Function

        Public Sub Update_estado_registro(ByVal idempleado As Integer, ByVal ayo As Integer, ByVal mes As Integer)
            SqlHelper.ExecuteNonQuery(Cn, "SG_PL_SP_U_IMPORTE_APAGAR_X_EMP", idempleado, ayo, mes)
        End Sub

    End Class

    Public Class SG_PL_TB_CTA_CTE
        Inherits ClsBD

        Public Sub Insert(ByVal Entidad As BE.PlanillaBE.SG_PL_TB_CTA_CTE, ByVal dt_crono As DataTable)
            With Entidad
                Entidad.CC_ID = SqlHelper.ExecuteScalar(Cn, "SG_PL_SP_I_CTA_CTE", .CC_NUMERO, .CC_FECHA_REGISTRO, _
                                          .CC_ID_PERSONAL.PE_ID, .CC_ID_MOTIVO.MP_ID, .CC_AFECTA_PLANILLA, _
                                          .CC_ID_MONEDA.MO_CODIGO, .CC_IMPORTE, .CC_TC, .CC_NUM_CUOTAS, _
                                          .CC_OBSERVACIONES, .CC_ESTADO.EP_ID, .CC_SALDO, .CC_USUARIO, _
                                          .CC_TERMINAL, .CC_FECREG, .CC_TDOC, .CC_SDOC, .CC_TASA_INTERES, _
                                          .CC_MONTO_TOTAL, .CC_CUOTA_MENSUAL, .CC_TOTAL_INTERES)


                For i As Integer = 0 To dt_crono.Rows.Count - 1

                    SqlHelper.ExecuteNonQuery(Cn, "SG_PL_SP_I_CTA_CTE_CRONO", Entidad.CC_ID, (i + 1), _
                                              dt_crono.Rows(i)("Fecha"), dt_crono.Rows(i)("PagoTotal"), 1, "", 0, _
                                              dt_crono.Rows(i)("Capital"), dt_crono.Rows(i)("Cuota"), dt_crono.Rows(i)("Interes"))

                Next


                'Dim dbl_Cuotas As Double = (Entidad.CC_MONTO_TOTAL / Entidad.CC_NUM_CUOTAS)
                'Dim dat_fecha_pago As Date = CDate(Entidad.CC_FECHA_REGISTRO)

                'Dim tmp As Double = IIf((dbl_Cuotas * Entidad.CC_NUM_CUOTAS) = Entidad.CC_MONTO_TOTAL, 0, (Entidad.CC_MONTO_TOTAL - (dbl_Cuotas * Entidad.CC_NUM_CUOTAS)))

                'For i As Integer = 1 To Entidad.CC_NUM_CUOTAS
                '    dat_fecha_pago = dat_fecha_pago.AddMonths(1)

                '    If i = Entidad.CC_NUM_CUOTAS Then
                '        SqlHelper.ExecuteNonQuery(Cn, "SG_PL_SP_I_CTA_CTE_CRONO", Entidad.CC_ID, i, dat_fecha_pago, dbl_Cuotas + Math.Abs(tmp), 1, "", 0)
                '    Else
                '        SqlHelper.ExecuteNonQuery(Cn, "SG_PL_SP_I_CTA_CTE_CRONO", Entidad.CC_ID, i, dat_fecha_pago, dbl_Cuotas, 1, "", 0)
                '    End If
                'Next

            End With
        End Sub

        Public Sub Update(ByVal Entidad As BE.PlanillaBE.SG_PL_TB_CTA_CTE)
            With Entidad
                SqlHelper.ExecuteNonQuery(Cn, "SG_PL_SP_U_CTA_CTE", .CC_ID, .CC_NUMERO, .CC_FECHA_REGISTRO, _
                                          .CC_ID_PERSONAL.PE_ID, .CC_ID_MOTIVO.MP_ID, .CC_AFECTA_PLANILLA, _
                                          .CC_ID_MONEDA.MO_CODIGO, .CC_IMPORTE, .CC_TC, .CC_NUM_CUOTAS, _
                                          .CC_OBSERVACIONES, .CC_ESTADO.EP_ID, .CC_SALDO, .CC_USUARIO, _
                                          .CC_TERMINAL, .CC_FECREG, .CC_TDOC, .CC_SDOC, .CC_TASA_INTERES, _
                                          .CC_MONTO_TOTAL, .CC_CUOTA_MENSUAL, .CC_TOTAL_INTERES)
            End With
        End Sub

        Public Sub Delete(ByVal Entidad As BE.PlanillaBE.SG_PL_TB_CTA_CTE)
            With Entidad
                SqlHelper.ExecuteNonQuery(Cn, "SG_PL_SP_D_CTA_CTE", .CC_ID)
            End With
        End Sub

        Public Function get_ctacte(ByVal estado As BE.PlanillaBE.SG_PL_TB_ESTADO_PRESTAMO, ByVal empresa As BE.ContabilidadBE.SG_CO_TB_EMPRESA) As DataTable
            Return SqlHelper.ExecuteDataset(Cn, "SG_PL_SP_S_CTA_CTE", empresa.EM_ID, estado.EP_ID).Tables(0)
        End Function

        Public Sub get_ctacte_x_Id(ByRef Entidad As BE.PlanillaBE.SG_PL_TB_CTA_CTE)
            Dim drr As SqlDataReader = SqlHelper.ExecuteReader(Cn, "SG_PL_SP_S_CTA_CTE_BY_ID", Entidad.CC_ID)
            If drr.HasRows Then
                drr.Read()
                With Entidad
                    .CC_NUMERO = drr("CC_NUMERO")
                    .CC_FECHA_REGISTRO = drr("CC_FECHA_REGISTRO")
                    .CC_ID_PERSONAL = New BE.PlanillaBE.SG_PL_TB_PERSONAL With {.PE_ID = drr("CC_ID_PERSONAL"), .PE_APE_PAT = drr("PE_APE_PAT"), .PE_APE_MAT = drr("PE_APE_MAT"), .PE_NOM_PRI = drr("PE_NOM_PRI"), .PE_NOM_SEG = drr("PE_NOM_SEG"), .PE_CODIGO = drr("PE_CODIGO")}
                    .CC_ID_MOTIVO = New BE.PlanillaBE.SG_PL_TB_MOTIVO_PRESTAMO With {.MP_ID = drr("CC_ID_MOTIVO")}
                    .CC_AFECTA_PLANILLA = drr("CC_AFECTA_PLANILLA")
                    .CC_ID_MONEDA = New BE.ContabilidadBE.SG_CO_TB_MONEDA With {.MO_CODIGO = drr("CC_ID_MONEDA")}
                    .CC_IMPORTE = drr("CC_IMPORTE")
                    .CC_TC = drr("CC_TC")
                    .CC_NUM_CUOTAS = drr("CC_NUM_CUOTAS")
                    .CC_OBSERVACIONES = drr("CC_OBSERVACIONES")
                    .CC_ESTADO = New BE.PlanillaBE.SG_PL_TB_ESTADO_PRESTAMO With {.EP_ID = drr("CC_ESTADO")}
                    .CC_SALDO = drr("CC_SALDO")

                    .CC_TDOC = drr("CC_TDOC")
                    .CC_SDOC = drr("CC_SDOC")
                    .CC_TASA_INTERES = drr("CC_TASA_INTERES")
                    .CC_MONTO_TOTAL = drr("CC_MONTO_TOTAL")
                    .CC_CUOTA_MENSUAL = drr("CC_CUOTA_MENSUAL")
                    .CC_TOTAL_INTERES = drr("CC_TOTAL_INTERES")

                End With
            End If
            drr.Close()
        End Sub

        Public Function get_Ultimo_Num_Recibo(ByVal empresa As BE.ContabilidadBE.SG_CO_TB_EMPRESA) As Integer
            Return SqlHelper.ExecuteScalar(Cn, "SG_PL_SP_S_ULT_NUM_RECIBO", empresa.EM_ID)
        End Function

        Public Sub Actualizar_Estado_Prestamo(estado_ As BE.PlanillaBE.SG_PL_TB_ESTADO_PRESTAMO, ctacte_ As BE.PlanillaBE.SG_PL_TB_CTA_CTE)
            SqlHelper.ExecuteNonQuery(Cn, "SG_PL_SP_ACT_ESTADO_CTACTE", estado_.EP_ID, ctacte_.CC_ID)
        End Sub
    End Class

    Public Class SG_PL_TB_ESTADO_PRESTAMO
        Inherits ClsBD

        Public Function get_Estados() As DataTable
            Return SqlHelper.ExecuteDataset(Cn, "SG_PL_SP_S_ESTADO_PRESTAMO").Tables(0)
        End Function

    End Class

    Public Class SG_PL_TB_MOTIVO_PRESTAMO
        Inherits ClsBD

        Public Function get_Motivos() As DataTable
            Return SqlHelper.ExecuteDataset(Cn, "SG_PL_SP_S_MOTIVO_PRESTAMO").Tables(0)
        End Function

    End Class

    Public Class SG_PL_TB_SUSPENSIONES
        Inherits ClsBD

        Public Function Existe_Registro_EnConta(ByVal Entidad_ As BE.PlanillaBE.SG_PL_TB_SUSPENSIONES, ByRef periodo_ As String) As Boolean

            Existe_Registro_EnConta = False

            If SqlHelper.ExecuteScalar(Cn, "SG_PL_SP_S_EXISTE_SUSPE", Entidad_.SU_ID_TIPO_SUSPENSION.TS_ID, _
                                           Entidad_.SU_ID_PERSONAL.PE_ID, _
                                           Entidad_.SU_FECHA_INI, _
                                           Entidad_.SU_FECHA_FIN) = 1 Then

                periodo_ = SqlHelper.ExecuteScalar(Cn, "SG_PL_SP_S_OBT_PERIODO_VACA", _
                                           Entidad_.SU_ID_TIPO_SUSPENSION.TS_ID, _
                                           Entidad_.SU_ID_PERSONAL.PE_ID, _
                                           Entidad_.SU_FECHA_INI, _
                                           Entidad_.SU_FECHA_FIN)
                Return True

            End If

        End Function

        Public Sub Insert(ByVal Entidad As BE.PlanillaBE.SG_PL_TB_SUSPENSIONES)
            With Entidad

                If SqlHelper.ExecuteScalar(Cn, "SG_PL_SP_S_EXISTE_SUSPE", Entidad.SU_ID_TIPO_SUSPENSION.TS_ID, _
                                           Entidad.SU_ID_PERSONAL.PE_ID, _
                                           Entidad.SU_FECHA_INI, _
                                           Entidad.SU_FECHA_FIN) = 0 Then

                    SqlHelper.ExecuteNonQuery(Cn, "SG_PL_SP_I_SUSPENSIONES", .SU_ID_TIPO_SUSPENSION.TS_ID, _
                                          .SU_ID_PERSONAL.PE_ID, .SU_FECHA_INI, .SU_FECHA_FIN, _
                                          .SU_DIAS_VACA, .SU_DIAS_TRABAJO, .SU_USUARIO, _
                                          .SU_TERMINAL, .SU_FECREG, .SU_ID_TIPO_SUSPE_SUNAT.TS_CODIGO, _
                                          .SU_PROCESAR, .SU_PERIODO, .SU_OBS, _
                                          IIf(.SU_PERIODO_INI = String.Empty, DBNull.Value, .SU_PERIODO_INI), _
                                          IIf(.SU_PERIODO_FIN = String.Empty, DBNull.Value, .SU_PERIODO_FIN), _
                                          .SU_NCITT, .SU_CONGOSE)
                End If

            End With
        End Sub

        Public Sub Update(ByVal Entidad As BE.PlanillaBE.SG_PL_TB_SUSPENSIONES)
            With Entidad
                SqlHelper.ExecuteNonQuery(Cn, "SG_PL_SP_U_SUSPENSIONES", .SU_ID, .SU_ID_TIPO_SUSPENSION.TS_ID, _
                                          .SU_ID_PERSONAL.PE_ID, .SU_FECHA_INI, .SU_FECHA_FIN, .SU_DIAS_VACA, _
                                          .SU_DIAS_TRABAJO, .SU_USUARIO, .SU_TERMINAL, .SU_FECREG, _
                                          .SU_ID_TIPO_SUSPE_SUNAT.TS_CODIGO, .SU_PROCESAR, .SU_PERIODO, _
                                          .SU_OBS, _
                                          IIf(.SU_PERIODO_INI = String.Empty, DBNull.Value, .SU_PERIODO_INI), _
                                          IIf(.SU_PERIODO_FIN = String.Empty, DBNull.Value, .SU_PERIODO_FIN), _
                                          .SU_NCITT, .SU_CONGOSE)
            End With
        End Sub

        Public Sub Delete(ByVal Entidad As BE.PlanillaBE.SG_PL_TB_SUSPENSIONES)
            With Entidad
                SqlHelper.ExecuteNonQuery(Cn, "SG_PL_SP_D_SUSPENSIONES", .SU_ID)
            End With
        End Sub

        Public Function Procesado(ByRef Entidad As BE.PlanillaBE.SG_PL_TB_SUSPENSIONES) As Boolean
            Procesado = False
            Dim drr As SqlDataReader = SqlHelper.ExecuteReader(Cn, "SG_PL_SP_S_SUSPENSIONES_BY_ID", Entidad.SU_ID)
            If drr.HasRows Then
                drr.Read()
                If drr("SU_PROCESASADO") = 1 Then
                    Procesado = True
                End If
            End If
            drr.Close()
        End Function

        Public Function get_Suspensiones(ByVal idpersonal As Integer) As DataTable
            Return SqlHelper.ExecuteDataset(Cn, "SG_PL_SP_S_SUSPENSIONES", idpersonal).Tables(0)
        End Function

        Public Function get_Suspensiones_x_Tipo(ByVal idpersonal_ As Integer, ByVal tipo_ As Int16) As DataTable
            Return SqlHelper.ExecuteDataset(Cn, "SG_PL_SP_S_SUSPENSIONES_BY_TIPO", idpersonal_, tipo_).Tables(0)
        End Function

        Public Function get_Suspensiones_x_Tipo_x_Personal_x_Periodo(ByVal id_tipo As Integer, ByVal id_personal As Integer, ByVal periodo As Date) As Integer
            get_Suspensiones_x_Tipo_x_Personal_x_Periodo = 0
            Dim int_dias As Integer = 0
            'Dim str_query As String = "SELECT SU_FECHA_INI,SU_FECHA_FIN FROM SG_PL_TB_SUSPENSIONES   WHERE SU_ID_TIPO_SUSPENSION = " & id_tipo.ToString & " AND SU_ID_PERSONAL = " & id_personal.ToString & " AND YEAR(SU_FECHA_INI) = " & periodo.Year.ToString & " AND  MONTH(SU_FECHA_INI) = " & periodo.Month.ToString

            'Dim dtt As DataTable = SqlHelper.ExecuteDataset(Cn, CommandType.Text, str_query).Tables(0)
            'Dim fecha_ini As Date
            'Dim fecha_aux As Date

            'If dtt.Rows.Count > 0 Then
            '    fecha_ini = dtt(0)("SU_FECHA_INI")
            '    fecha_aux = fecha_ini

            '    While fecha_aux.Month = fecha_ini.Month
            '        int_dias += 1
            '        fecha_aux = fecha_aux.AddDays(1)
            '    End While
            '    GoTo salir
            'End If


            'str_query = "SELECT SU_FECHA_INI,SU_FECHA_FIN FROM SG_PL_TB_SUSPENSIONES   WHERE SU_ID_TIPO_SUSPENSION = " & id_tipo.ToString & " AND SU_ID_PERSONAL = " & id_personal.ToString & " AND YEAR(SU_FECHA_FIN) = " & periodo.Year.ToString & " AND  MONTH(SU_FECHA_FIN) = " & periodo.Month.ToString
            'dtt = SqlHelper.ExecuteDataset(Cn, CommandType.Text, str_query).Tables(0)
            'Dim fecha_fin As Date
            'If dtt.Rows.Count > 0 Then
            '    fecha_fin = dtt(0)("SU_FECHA_FIN")
            '    fecha_aux = DateSerial(Year(fecha_fin), Month(fecha_fin) + 0, 1)

            '    While fecha_aux <= fecha_fin
            '        int_dias += 1
            '        fecha_aux = fecha_aux.AddDays(1)
            '    End While

            'End If



            Dim drr As SqlDataReader = SqlHelper.ExecuteReader(Cn, "SG_PL_SP_S_SUSPEN_BY_IDPER_IDTIPO", id_tipo, id_personal, periodo.Year, periodo.Month)
            If drr.HasRows Then
                While drr.Read()
                    If drr("SU_PROCESAR") = 1 Then int_dias += drr("SU_DIAS_VACA")
                End While

            End If
            drr.Close()
salir:

            'caso davalos enero 2015
            If periodo.Year = 2015 And periodo.Month = 1 And id_personal = 122 And id_tipo = 1 Then
                int_dias -= 1
            End If

            Return int_dias

        End Function

        Public Function get_Suspensiones_x_Tipo_x_Personal_x_Periodo_Lice_singoce(ByVal id_tipo As Integer, ByVal id_personal As Integer, ByVal periodo As Date) As Integer
            get_Suspensiones_x_Tipo_x_Personal_x_Periodo_Lice_singoce = 0

            Dim int_dias As Integer = 0

            Dim drr As SqlDataReader = SqlHelper.ExecuteReader(Cn, "SG_PL_SP_S_SUSPEN_SIN_GOCE", id_tipo, id_personal, periodo.Year, periodo.Month)
            If drr.HasRows Then
                While drr.Read()
                    If drr("SU_PROCESAR") = 1 Then int_dias += drr("SU_DIAS_VACA")
                End While

            End If
            drr.Close()
salir:
            Return int_dias

        End Function
        Public Sub get_Suspensiones_x_Id(ByRef Entidad As BE.PlanillaBE.SG_PL_TB_SUSPENSIONES)
            Dim drr As SqlDataReader = SqlHelper.ExecuteReader(Cn, "SG_PL_SP_S_SUSPENSIONES_BY_ID", Entidad.SU_ID)
            If drr.HasRows Then
                drr.Read()
                With Entidad
                    .SU_ID = drr("SU_ID")
                    .SU_ID_TIPO_SUSPENSION = New BE.PlanillaBE.SG_PL_TB_TIPO_SUSPENSION With {.TS_ID = drr("SU_ID_TIPO_SUSPENSION")}
                    .SU_ID_PERSONAL = New BE.PlanillaBE.SG_PL_TB_PERSONAL With {.PE_ID = drr("SU_ID_PERSONAL")}
                    .SU_FECHA_INI = drr("SU_FECHA_INI")
                    .SU_FECHA_FIN = drr("SU_FECHA_FIN")
                    .SU_DIAS_VACA = drr("SU_DIAS_VACA")
                    .SU_DIAS_TRABAJO = drr("SU_DIAS_TRABAJO")
                    .SU_ID_TIPO_SUSPE_SUNAT = New BE.PlanillaBE.SG_PL_TB_TIPO_SUSPENSION_SUNAT With {.TS_CODIGO = drr("SU_ID_TIPO_SUSPE_SUNAT")}
                    .SU_PROCESAR = drr("SU_PROCESAR")
                    .SU_PERIODO = drr("SU_PERIODO").ToString
                    .SU_OBS = drr("SU_OBS").ToString
                    .SU_PERIODO_INI = drr("SU_PERIODO_INI").ToString
                    .SU_PERIODO_FIN = drr("SU_PERIODO_FIN").ToString
                    .SU_CONGOSE = drr("SU_CONGOSE")
                End With
            End If
            drr.Close()
        End Sub

        Public Function get_Lista_Personal_Suspendido(ByVal tipo As Integer, ByVal empresa As Integer) As DataTable
            Return SqlHelper.ExecuteDataset(Cn, "SG_PL_SP_S_LIS_PER_SUSPEN", tipo, empresa).Tables(0)
        End Function

    End Class

    Public Class SG_PL_TB_TIPO_SUSPENSION_SUNAT
        Inherits ClsBD

        Public Function get_Tipos(tipo_ As Integer) As DataTable
            Return SqlHelper.ExecuteDataset(Cn, "SG_PL_SP_S_TIPO_SUSPENSION_SUNAT", tipo_).Tables(0)
        End Function

    End Class

    Public Class SG_PL_TB_TIPO_SUSPENSION
        Inherits ClsBD

        Public Function get_Tipos() As DataTable
            Return SqlHelper.ExecuteDataset(Cn, "SG_PL_SP_S_TIPO_SUSPENSION").Tables(0)
        End Function
    End Class

    Public Class SG_PL_TB_FOLIO
        Inherits ClsBD

        Public Sub Insert(ByVal Entidad As BE.PlanillaBE.SG_PL_TB_FOLIO)
            With Entidad
                SqlHelper.ExecuteNonQuery(Cn, "SG_PL_SP_I_FOLIO", .FO_ANHO, .FO_MES, .FO_ID_PERSONA.PE_ID, .FO_ID_CONCEPTO.CO_ID, .FO_VALOR, .FO_ID_EMPRESA.EM_ID, .FO_USUARIO, .FO_TERMINAL, .FO_FECREG)
            End With
        End Sub

        Public Sub Update(ByVal Entidad As BE.PlanillaBE.SG_PL_TB_FOLIO)
            With Entidad
                SqlHelper.ExecuteNonQuery(Cn, "SG_PL_SP_U_FOLIO", .FO_ANHO, _
                                          .FO_MES, .FO_ID_PERSONA.PE_ID, _
                                          .FO_ID_CONCEPTO.CO_ID, .FO_VALOR, _
                                          .FO_ID_EMPRESA.EM_ID, .FO_USUARIO, _
                                          .FO_TERMINAL, .FO_FECREG)
            End With
        End Sub

        Public Sub Delete(ByVal Entidad As BE.PlanillaBE.SG_PL_TB_FOLIO)
            With Entidad
                SqlHelper.ExecuteNonQuery(Cn, "SG_PL_SP_D_FOLIO", .FO_ANHO, .FO_MES, .FO_ID_CONCEPTO.CO_ID, .FO_ID_EMPRESA.EM_ID)
            End With
        End Sub

        Public Sub Delete_x_Trabajador(ByVal Entidad As BE.PlanillaBE.SG_PL_TB_FOLIO)
            With Entidad
                SqlHelper.ExecuteNonQuery(Cn, "SG_PL_SP_D_FOLIO_X_IDTRAB", .FO_ANHO, .FO_MES, .FO_ID_CONCEPTO.CO_ID, .FO_ID_EMPRESA.EM_ID, .FO_ID_PERSONA.PE_ID)
            End With
        End Sub

        Public Function get_Folios(ByVal Entidad As BE.PlanillaBE.SG_PL_TB_FOLIO) As DataTable
            Return SqlHelper.ExecuteDataset(Cn, "SG_PL_SP_S_FOLIO", Entidad.FO_ANHO, Entidad.FO_MES, Entidad.FO_ID_CONCEPTO.CO_ID, Entidad.FO_ID_EMPRESA.EM_ID).Tables(0)
        End Function

        Public Function get_Folios_x_IdPersonal_Dt(ByVal Entidad As BE.PlanillaBE.SG_PL_TB_FOLIO) As DataTable
            With Entidad
                Return SqlHelper.ExecuteDataset(Cn, "SG_PL_SP_S_FOLIO2", .FO_ID_PERSONA.PE_ID, .FO_ANHO, .FO_MES, .FO_ID_EMPRESA.EM_ID).Tables(0)
            End With
        End Function

        Public Function Tiene_Folio_Registrado(Entidad As BE.PlanillaBE.SG_PL_TB_FOLIO) As Boolean
            'esta funcion devuelve verdadero o falso
            'si tiene un registro en el folio del mes es verdadero
            Dim bol_rpta As Boolean = False
            Dim int_rpta As Integer = SqlHelper.ExecuteScalar(Cn, "SG_PL_SP_S_TIENE_FOLIO_REG", Entidad.FO_ANHO, Entidad.FO_MES, Entidad.FO_ID_CONCEPTO.CO_ID, Entidad.FO_ID_PERSONA.PE_ID, Entidad.FO_ID_EMPRESA.EM_ID)
            If int_rpta > 0 Then bol_rpta = Not bol_rpta
            Return bol_rpta
        End Function

        Public Sub get_Folios_x_IdPersonal(ByRef Entidad As BE.PlanillaBE.SG_PL_TB_FOLIO)
            Dim drr As SqlDataReader = SqlHelper.ExecuteReader(Cn, "SG_PL_SP_S_FOLIO_BY_ID_PER", Entidad.FO_ANHO, Entidad.FO_MES, Entidad.FO_ID_CONCEPTO.CO_ID, Entidad.FO_ID_PERSONA.PE_ID, Entidad.FO_ID_EMPRESA.EM_ID)
            If drr.HasRows Then
                drr.Read()
                With Entidad
                    '.FO_ANHO = drr("FO_ANHO")
                    '.FO_MES = drr("FO_MES")
                    '.FO_ID_PERSONA = drr("FO_ID_PERSONA")
                    '.FO_ID_CONCEPTO = drr("FO_ID_CONCEPTO")
                    .FO_VALOR = drr("FO_VALOR")
                    .HasRow = True
                End With
            End If
            drr.Close()
        End Sub

        Public Function get_Folio_del_Mes(ByVal Entidad As BE.PlanillaBE.SG_PL_TB_FOLIO) As DataTable
            Return SqlHelper.ExecuteDataset(Cn, "SG_PL_SP_S_FOLIO_BY_MES", Entidad.FO_ANHO, Entidad.FO_MES, Entidad.FO_ID_EMPRESA.EM_ID).Tables(0)
        End Function

    End Class

    Public Class SG_PL_TB_IDENTIFICADOR
        Inherits ClsBD

        Public Function get_Identificadores() As DataTable
            Return SqlHelper.ExecuteDataset(Cn, "SG_PL_SP_S_IDENTIFICADOR").Tables(0)
        End Function

    End Class

    Public Class SG_PL_TB_ALCANCE_CONCEPTO
        Inherits ClsBD

        Public Function get_Alcances() As DataTable
            Return SqlHelper.ExecuteDataset(Cn, "SG_PL_SP_S_ALCANCE_CONCEPTO").Tables(0)
        End Function

    End Class

    Public Class SG_PL_TB_TIPO_CONCEPTO
        Inherits ClsBD

        Public Function get_Tipos() As DataTable
            Return SqlHelper.ExecuteDataset(Cn, "SG_PL_SP_S_TIPO_CONCEPTO").Tables(0)
        End Function

        Public Function get_Tipo_X_Concepto(ByVal concepto, ByVal empresa) As String
            Return SqlHelper.ExecuteScalar(Cn, "SG_PL_SP_S_TIPO_X_IDCONCEPTO", concepto, empresa)
        End Function
    End Class

    Public Class SG_PL_TB_CONCEPTOS
        Inherits ClsBD

        Public Sub Insert(ByVal Entidad As BE.PlanillaBE.SG_PL_TB_CONCEPTOS)
            With Entidad
                SqlHelper.ExecuteNonQuery(Cn, "SG_PL_SP_I_CONCEPTOS", .CO_ID, .CO_DESCRIPCION, .CO_ID_TIPO.TC_ID, _
                                          .CO_VALOR, .CO_ESTADO, .CO_ID_ALCANCE.AC_ID, .CO_ID_IDENTIFICADOR.ID_ID, _
                                          .CO_ID_CUENTA_D.PC_NUM_CUENTA, .CO_ID_CUENTA_H.PC_NUM_CUENTA, .CO_ID_SUNAT.CS_ID, _
                                          .CO_NO_AFECT_AFP, .CO_NO_AFECTA_QUINTA, .CO_NO_PROYECTA_QUINTA, .CO_AFECTA_GRATI, _
                                          .CO_ID_INTERNO, .CO_USUARIO, .CO_TERMINAL, .CO_FECREG, .CO_ID_EMPRESA.EM_ID, .CO_ES_AFP, .CO_AFECTA_CTS)
            End With
        End Sub

        Public Sub Update(ByVal Entidad As BE.PlanillaBE.SG_PL_TB_CONCEPTOS)
            With Entidad
                SqlHelper.ExecuteNonQuery(Cn, "SG_PL_SP_U_CONCEPTOS", .CO_ID, .CO_DESCRIPCION, .CO_ID_TIPO.TC_ID, _
                                          .CO_VALOR, .CO_ESTADO, .CO_ID_ALCANCE.AC_ID, .CO_ID_IDENTIFICADOR.ID_ID, _
                                          .CO_ID_CUENTA_D.PC_NUM_CUENTA, .CO_ID_CUENTA_H.PC_NUM_CUENTA, .CO_ID_SUNAT.CS_ID, _
                                          .CO_NO_AFECT_AFP, .CO_NO_AFECTA_QUINTA, .CO_NO_PROYECTA_QUINTA, .CO_AFECTA_GRATI, _
                                          .CO_ID_INTERNO, .CO_USUARIO, .CO_TERMINAL, .CO_FECREG, .CO_ID_EMPRESA.EM_ID, .CO_ES_AFP, .CO_AFECTA_CTS)
            End With
        End Sub

        Public Sub Delete(ByVal Entidad As BE.PlanillaBE.SG_PL_TB_CONCEPTOS)
            With Entidad
                SqlHelper.ExecuteNonQuery(Cn, "SG_PL_SP_D_CONCEPTOS", .CO_ID, .CO_ID_EMPRESA.EM_ID)
            End With
        End Sub

        Public Function get_Conceptos(ByVal Empresa As BE.ContabilidadBE.SG_CO_TB_EMPRESA) As DataTable
            Return SqlHelper.ExecuteDataset(Cn, "SG_PL_SP_S_CONCEPTOS", Empresa.EM_ID).Tables(0)
        End Function

        Public Function get_Conceptos_x_Identificador(identificador As BE.PlanillaBE.SG_PL_TB_IDENTIFICADOR, ByVal Empresa As BE.ContabilidadBE.SG_CO_TB_EMPRESA) As DataTable
            Return SqlHelper.ExecuteDataset(Cn, "SG_PL_SP_S_CONCEPTOS_XID_IDENTIFI", identificador.ID_ID, Empresa.EM_ID).Tables(0)
        End Function

        Public Function get_Conceptos_Ayuda(ByVal Empresa As BE.ContabilidadBE.SG_CO_TB_EMPRESA) As DataTable
            Return SqlHelper.ExecuteDataset(Cn, "SG_PL_SP_S_CONCEPTOS_AYUDA", Empresa.EM_ID).Tables(0)
        End Function

        Public Function get_Conceptos_Matriz(ByVal Empresa As BE.ContabilidadBE.SG_CO_TB_EMPRESA) As List(Of BE.PlanillaBE.SG_PL_TB_CONCEPTOS)
            Dim drr As SqlDataReader = SqlHelper.ExecuteReader(Cn, "SG_PL_SP_S_CONCEPTOS_ACTIVOS", Empresa.EM_ID)
            Dim lista_conceptos As New List(Of BE.PlanillaBE.SG_PL_TB_CONCEPTOS)
            Dim concepto As BE.PlanillaBE.SG_PL_TB_CONCEPTOS

            If drr.HasRows Then
                Do While drr.Read
                    concepto = New BE.PlanillaBE.SG_PL_TB_CONCEPTOS()
                    With concepto
                        .CO_ID = drr("CO_ID")
                        .CO_DESCRIPCION = drr("CO_DESCRIPCION")
                        .CO_ID_TIPO = New BE.PlanillaBE.SG_PL_TB_TIPO_CONCEPTO With {.TC_ID = drr("CO_ID_TIPO")}
                        .CO_VALOR = drr("CO_VALOR")
                        .CO_ESTADO = drr("CO_ESTADO")
                        .CO_ID_ALCANCE = New BE.PlanillaBE.SG_PL_TB_ALCANCE_CONCEPTO With {.AC_ID = drr("CO_ID_ALCANCE")}
                        .CO_ID_IDENTIFICADOR = New BE.PlanillaBE.SG_PL_TB_IDENTIFICADOR With {.ID_ID = drr("CO_ID_IDENTIFICADOR")}
                        .CO_ID_CUENTA_D = New BE.ContabilidadBE.SG_CO_TB_PLANCTAS With {.PC_NUM_CUENTA = drr("CO_ID_CUENTA_D").ToString}
                        .CO_ID_CUENTA_H = New BE.ContabilidadBE.SG_CO_TB_PLANCTAS With {.PC_NUM_CUENTA = drr("CO_ID_CUENTA_H").ToString}

                        If drr("CO_ID_SUNAT").ToString.Equals(String.Empty) Then
                            .CO_ID_SUNAT = Nothing
                        Else
                            .CO_ID_SUNAT = New BE.PlanillaBE.SG_PL_TB_CONCEPTO_SUNAT With {.CS_ID = drr("CO_ID_SUNAT")}
                        End If

                        .CO_NO_AFECT_AFP = drr("CO_NO_AFECT_AFP")
                        .CO_NO_AFECTA_QUINTA = drr("CO_NO_AFECTA_QUINTA")
                        .CO_NO_PROYECTA_QUINTA = drr("CO_NO_PROYECTA_QUINTA")
                        .CO_AFECTA_GRATI = drr("CO_AFECTA_GRATI")

                        'el campo CO_ID_INTERNO  se va reemplaza por el campo PE_IDPLANTILLA
                        'para guardar el codigo de la tabla de "Plantilla Codigo", relacionado a cada concepto
                        '

                        .CO_ID_INTERNO = drr("PE_IDPLANTILLA")

                    End With
                    lista_conceptos.Add(concepto)
                Loop
            End If

            drr.Close()

            Return lista_conceptos

        End Function

        Public Function get_Conceptos_Lista_Chica(ByVal Empresa As BE.ContabilidadBE.SG_CO_TB_EMPRESA) As DataTable
            Return SqlHelper.ExecuteDataset(Cn, "SG_PL_SP_S_CONCEPTOS_LISTA_CHICA", Empresa.EM_ID).Tables(0)
        End Function

        Public Function get_Conceptos_Lista_Calculo(ByVal Empresa As BE.ContabilidadBE.SG_CO_TB_EMPRESA) As DataTable
            Return SqlHelper.ExecuteDataset(Cn, "SG_PL_SP_S_CONCEPTOS_LISTA_CALCULO", Empresa.EM_ID).Tables(0)
        End Function

        Public Function get_Conceptos_x_Id(ByVal Entidad As BE.PlanillaBE.SG_PL_TB_CONCEPTOS) As DataTable
            Return SqlHelper.ExecuteDataset(Cn, "SG_PL_SP_S_CONCEPTOS_BY_ID", Entidad.CO_ID, Entidad.CO_ID_EMPRESA.EM_ID).Tables(0)
        End Function

        Public Sub get_Concepto(ByRef Entidad As BE.PlanillaBE.SG_PL_TB_CONCEPTOS)
            Dim drr As SqlDataReader = SqlHelper.ExecuteReader(Cn, "SG_PL_SP_S_CONCEPTOS_BY_ID", Entidad.CO_ID, Entidad.CO_ID_EMPRESA.EM_ID)

            If drr.HasRows Then
                While drr.Read
                    With Entidad
                        .CO_ID = drr("CO_ID")
                        .CO_DESCRIPCION = drr("CO_DESCRIPCION").ToString
                        .CO_ID_TIPO = New BE.PlanillaBE.SG_PL_TB_TIPO_CONCEPTO With {.TC_ID = drr("CO_ID_TIPO")}
                        .CO_VALOR = drr("CO_VALOR")
                        .CO_ESTADO = drr("CO_ESTADO")
                        .CO_ID_ALCANCE = New BE.PlanillaBE.SG_PL_TB_ALCANCE_CONCEPTO With {.AC_ID = drr("CO_ID_ALCANCE")}
                        .CO_ID_IDENTIFICADOR = New BE.PlanillaBE.SG_PL_TB_IDENTIFICADOR With {.ID_ID = drr("CO_ID_IDENTIFICADOR")}
                        .CO_ID_CUENTA_D = New BE.ContabilidadBE.SG_CO_TB_PLANCTAS With {.PC_NUM_CUENTA = drr("CO_ID_CUENTA_D").ToString}
                        .CO_ID_CUENTA_H = New BE.ContabilidadBE.SG_CO_TB_PLANCTAS With {.PC_NUM_CUENTA = drr("CO_ID_CUENTA_H").ToString}
                        .CO_ID_SUNAT = New BE.PlanillaBE.SG_PL_TB_CONCEPTO_SUNAT With {.CS_ID = drr("CO_ID_SUNAT").ToString}
                        .CO_NO_AFECT_AFP = drr("CO_NO_AFECT_AFP")
                        .CO_NO_AFECTA_QUINTA = drr("CO_NO_AFECTA_QUINTA")
                        .CO_NO_PROYECTA_QUINTA = drr("CO_NO_PROYECTA_QUINTA")
                        .CO_AFECTA_GRATI = drr("CO_AFECTA_GRATI")
                        .CO_ID_INTERNO = drr("CO_ID_INTERNO")
                    End With
                End While
            End If

            drr.Close()
            drr = Nothing
        End Sub

        Public Function get_Ultimo_Num_Interno_concepto(ByVal int_empresa As Integer) As String
            Dim ultimo As String = SqlHelper.ExecuteScalar(Cn, "SG_PL_SP_S_ULT_NUM_CONCEP_INT", int_empresa)
            Return ultimo
        End Function

        Public Sub Copiar_de_otro_Folio(ByVal ayo As Integer, ByVal mes As Integer, ByVal ayo_a As Integer, ByVal mes_a As Integer, ByVal folio_origen_ As String, ByVal folio_des_ As String, ByVal porcentaje As Double, ByVal empresa As Integer)
            SqlHelper.ExecuteNonQuery(Cn, "SG_PL_SP_I_FOLIO_DESDE_OTRO", ayo, mes, ayo_a, mes_a, folio_origen_, folio_des_, porcentaje, empresa)
        End Sub
    End Class

    Public Class SG_PL_TB_CONCEPTO_SUNAT
        Inherits ClsBD

        Public Function get_Conceptos() As DataTable
            Return SqlHelper.ExecuteDataset(Cn, "SG_PL_SP_S_CONCEPTO_SUNAT").Tables(0)
        End Function

        Public Function get_Conceptos_x_Tipo(ByVal Entidad As BE.PlanillaBE.SG_PL_TB_CONCEPTO_SUNAT) As DataTable
            Return SqlHelper.ExecuteDataset(Cn, "SG_PL_SP_S_CONCEPTO_SUNAT_BY_TIPO", Entidad.CS_TIPO).Tables(0)
        End Function

    End Class

    Public Class SG_PL_TB_TIPO_TARIFA
        Inherits ClsBD


        Public Sub Insert()

        End Sub

        Public Sub Update(ByVal Entidad As BE.PlanillaBE.SG_PL_TB_TIPO_TARIFA)
            With Entidad
                SqlHelper.ExecuteNonQuery(Cn, "SG_PL_SP_U_TIPO_TARIFA", .TI_ID, .TI_IDCONCEPTO.CO_ID, .TI_ID_EMPRESA.EM_ID)
            End With

        End Sub


        Public Function get_Tipos(ByVal empresa As BE.ContabilidadBE.SG_CO_TB_EMPRESA) As DataTable
            Return SqlHelper.ExecuteDataset(Cn, "SG_PL_SP_S_TIPO_TARIFA", empresa.EM_ID).Tables(0)
        End Function

    End Class

    Public Class SG_PL_TB_TARIFA
        Inherits ClsBD

        Public Function get_Tarifas(ByVal Empresa As BE.ContabilidadBE.SG_CO_TB_EMPRESA) As DataTable
            Return SqlHelper.ExecuteDataset(Cn, "SG_PL_SP_S_TARIFA", Empresa.EM_ID).Tables(0)
        End Function

        Public Function Existe_Llave(ByVal Entidad As BE.PlanillaBE.SG_PL_TB_TARIFA) As Boolean
            Dim cantidad As Integer = SqlHelper.ExecuteScalar(Cn, "SG_PL_SP_S_TARIFA_X_LLAVE", Entidad.TA_ID_TIPO_TARIFA.TI_ID, Entidad.TA_ID_TIPO_PER.TT_ID, Entidad.TA_ID_EMPRESA.EM_ID)
            If cantidad > 0 Then
                Return True
            Else
                Return False
            End If
        End Function

        Public Sub Insert(ByVal Entidad As BE.PlanillaBE.SG_PL_TB_TARIFA)
            SqlHelper.ExecuteNonQuery(Cn, "SG_PL_SP_I_TARIFA", Entidad.TA_ID_TIPO_PER.TT_ID, Entidad.TA_ID_TIPO_TARIFA.TI_ID, Entidad.TA_VALOR, Entidad.TA_ID_EMPRESA.EM_ID)
        End Sub

        Public Sub Update(ByVal Entidad As BE.PlanillaBE.SG_PL_TB_TARIFA)
            SqlHelper.ExecuteNonQuery(Cn, "SG_PL_SP_U_TARIFA", Entidad.TA_ID_TIPO_PER.TT_ID, Entidad.TA_ID_TIPO_TARIFA.TI_ID, Entidad.TA_VALOR, Entidad.TA_ID_EMPRESA.EM_ID)
        End Sub

    End Class

    Public Class SG_PL_TB_TIPO_PERSO_TARIFA
        Inherits ClsBD

        Public Function get_Tipos(ByVal Entidad As BE.ContabilidadBE.SG_CO_TB_EMPRESA) As DataTable
            Return SqlHelper.ExecuteDataset(Cn, "SG_PL_SP_S_TIPO_PERSO_TARIFA", Entidad.EM_ID).Tables(0)
        End Function

    End Class

    Public Class SG_PL_TB_PERSONAL_CCOSTO
        Inherits ClsBD

        Public Sub Insert(ByVal Entidad As BE.PlanillaBE.SG_PL_TB_PERSONAL_CCOSTO)
            With Entidad
                SqlHelper.ExecuteNonQuery(Cn, "SG_PL_SP_I_PERSONAL_CCOSTO", .CC_CC.CC_CODIGO, .CC_ID_PERSONA.PE_ID, .CC_PORCENTAJE, .CC_USUARIO, .CC_TERMINAL, .CC_FECREG)
            End With
        End Sub

        Public Sub Update(ByVal Entidad As BE.PlanillaBE.SG_PL_TB_PERSONAL_CCOSTO)
            With Entidad
                SqlHelper.ExecuteNonQuery(Cn, "SG_PL_SP_U_PERSONAL_CCOSTO", .CC_CC.CC_CODIGO, .CC_ID_PERSONA.PE_ID, .CC_PORCENTAJE, .CC_USUARIO, .CC_TERMINAL, .CC_FECREG)
            End With
        End Sub

        Public Function get_CCostosPersonal_x_IdPersonal(ByVal personaBE As BE.PlanillaBE.SG_PL_TB_PERSONAL) As DataTable
            Return SqlHelper.ExecuteDataset(Cn, "SG_PL_TB_S_PERSO_CCOSTO_BY_IDPER", personaBE.PE_ID, personaBE.PE_ID_EMPRESA).Tables(0)
        End Function

    End Class

    Public Class SG_PL_TB_PERSONAL_CONTRATOS
        Inherits ClsBD

        Public Sub Insert(ByRef Entidad As BE.PlanillaBE.SG_PL_TB_PERSONAL_CONTRATOS)
            With Entidad
                Entidad.CO_ID = SqlHelper.ExecuteScalar(Cn, "SG_PL_SP_I_PERSONAL_CONTRATOS", .CO_ID_PERSONAL.PE_ID, .CO_ID_TIPO_CONTRATO.TC_ID, .CO_FECHA_INI, .CO_FECHA_FIN, .CO_COMENTARIO, .CO_USUARIO, .CO_TERMINAL, .CO_FECREG)
            End With
        End Sub

        Public Sub Update(ByVal Entidad As BE.PlanillaBE.SG_PL_TB_PERSONAL_CONTRATOS)
            With Entidad
                SqlHelper.ExecuteNonQuery(Cn, "SG_PL_SP_U_PERSONAL_CONTRATOS", .CO_ID, .CO_ID_PERSONAL.PE_ID, .CO_ID_TIPO_CONTRATO.TC_ID, .CO_FECHA_INI, .CO_FECHA_FIN, .CO_COMENTARIO, .CO_USUARIO, .CO_TERMINAL, .CO_FECREG)
            End With
        End Sub

        Public Sub Delete(ByVal Entidad As BE.PlanillaBE.SG_PL_TB_PERSONAL_CONTRATOS)
            SqlHelper.ExecuteNonQuery(Cn, "SG_PL_SP_D_PERSONAL_CONTRATOS", Entidad.CO_ID)
        End Sub

        Public Function get_Data_Generar_Contrato(ByVal Entidad As BE.PlanillaBE.SG_PL_TB_PERSONAL) As DataTable
            Return SqlHelper.ExecuteDataset(Cn, "SG_PL_SP_S_DATOS_CONTRATO", Entidad.PE_ID).Tables(0)
        End Function

        Public Function get_Contratos_x_IdPersonal(ByVal Entidad As BE.PlanillaBE.SG_PL_TB_PERSONAL) As DataTable
            Return SqlHelper.ExecuteDataset(Cn, "SG_PL_SP_S_PERSONAL_CONTRATOS", Entidad.PE_ID).Tables(0)
        End Function

        Public Function get_Lista_Personal_Contrato(ByVal empresa_ As Integer) As DataTable
            Return SqlHelper.ExecuteDataset(Cn, "SG_PL_SP_S_LISTA_PERSONA_CONTRATO", empresa_).Tables(0)
        End Function

    End Class

    Public Class SG_PL_TB_TIPO_CONTRATO
        Inherits ClsBD

        Public Function get_Tipos() As DataTable
            Return SqlHelper.ExecuteDataset(Cn, "SG_PL_SP_S_TIPO_CONTRATO").Tables(0)
        End Function

    End Class

    Public Class SG_PL_TB_PERSONAL_DOCUMENTOS
        Inherits ClsBD

        Public Sub Insert(ByRef Entidad As BE.PlanillaBE.SG_PL_TB_PERSONAL_DOCUMENTOS)
            With Entidad
                Entidad.DO_ID = SqlHelper.ExecuteScalar(Cn, "SG_PL_SP_I_PERSONAL_DOCUMENTOS", .DO_ID_PERSONAL.PE_ID, .DO_NOMBRE_ARCHIVO, .DO_DESCRIPCION, .DO_FILE, .DO_USUARIO, .DO_TERMINAL, .DO_FECREG)
            End With
        End Sub

        Public Sub Update(ByVal Entidad As BE.PlanillaBE.SG_PL_TB_PERSONAL_DOCUMENTOS)
            With Entidad
                SqlHelper.ExecuteNonQuery(Cn, "SG_PL_SP_U_PERSONAL_DOCUMENTOS", .DO_ID, .DO_DESCRIPCION)
            End With
        End Sub

        Public Sub Delete(ByVal Entidad As BE.PlanillaBE.SG_PL_TB_PERSONAL_DOCUMENTOS)
            With Entidad
                SqlHelper.ExecuteNonQuery(Cn, "SG_PL_SP_D_PERSONAL_DOCUMENTOS", .DO_ID)
            End With
        End Sub

        Public Function get_Documentos_X_IdPersona(ByVal Entidad As BE.PlanillaBE.SG_PL_TB_PERSONAL) As DataTable
            Return SqlHelper.ExecuteDataset(Cn, "SG_PL_SP_S_PERSO_DOC_BY_IDPER", Entidad.PE_ID).Tables(0)
        End Function

        Public Sub Recuperar_Documento_Almacenado(ByVal Entidad As BE.PlanillaBE.SG_PL_TB_PERSONAL_DOCUMENTOS)
            Dim drr As SqlDataReader = SqlHelper.ExecuteReader(Cn, "SG_PL_SP_S_PERSO_DOC_BY_IDDOC", Entidad.DO_ID)
            If drr.HasRows Then
                drr.Read()
                Dim bufferSize As Int32 = Convert.ToInt32(drr.GetBytes(0, 0, Nothing, 0, 0))
                Dim aByte(bufferSize - 1) As Byte
                drr.GetBytes(0, 0, aByte, 0, bufferSize)

                Dim cls_funciones As New LR.ClsFunciones
                cls_funciones.WriteBinaryFile(aByte, Entidad.DO_NOMBRE_ARCHIVO)
                cls_funciones = Nothing
                Process.Start(Entidad.DO_NOMBRE_ARCHIVO)
            End If
            drr.Close()
        End Sub

    End Class

    Public Class SG_PL_TB_PERSONA_COMUNICACION
        Inherits ClsBD

        Public Sub Insert(ByRef Entidad As BE.PlanillaBE.SG_PL_TB_PERSONA_COMUNICACION)
            With Entidad
                Entidad.PC_ID = SqlHelper.ExecuteScalar(Cn, "SG_PL_SP_I_PERSONA_COMUNICACION", .PC_ID_PERSONA.PE_ID, .PC_ID_COMUNICACION.TC_ID, .PC_NUMERO, .PC_DESCRIPCION, .PC_ISTATUS, .PC_USUARIO, .PC_TERMINAL, .PC_FECREG)
            End With
        End Sub

        Public Sub Update(ByVal Entidad As BE.PlanillaBE.SG_PL_TB_PERSONA_COMUNICACION)
            With Entidad
                SqlHelper.ExecuteNonQuery(Cn, "SG_PL_SP_U_PERSONA_COMUNICACION", .PC_ID, .PC_ID_PERSONA.PE_ID, .PC_ID_COMUNICACION.TC_ID, .PC_NUMERO, .PC_DESCRIPCION, .PC_ISTATUS, .PC_USUARIO, .PC_TERMINAL, .PC_FECREG)
            End With
        End Sub

        Public Sub Delete(ByVal Entidad As BE.PlanillaBE.SG_PL_TB_PERSONA_COMUNICACION)
            With Entidad
                SqlHelper.ExecuteNonQuery(Cn, "SG_PL_SP_D_PERSONA_COMUNICACION", .PC_ID)
            End With
        End Sub

        Public Function getComunicaciones_x_IdPersona(ByVal Entidad As BE.PlanillaBE.SG_PL_TB_PERSONAL) As DataTable
            Return SqlHelper.ExecuteDataset(Cn, "SG_PL_SP_S_PERS_COMUN_BY_IDPER", Entidad.PE_ID).Tables(0)
        End Function

        Public Function get_Correo_Personal(idPersonal_ As Integer) As String
            Return SqlHelper.ExecuteScalar(Cn, "SG_PL_SP_S_CORREO_PER", idPersonal_)
        End Function
    End Class

    Public Class SG_PL_TB_UBI_UBIGEO
        Inherits ClsBD

        Public Function getUbigeo() As DataTable
            Return SqlHelper.ExecuteDataset(Cn, "SG_PL_SP_S_UBI_UBIGEO").Tables(0)
        End Function

        Public Function getUbigeo_x_Provincia(ByVal Entidad As BE.PlanillaBE.SG_PL_TB_UBI_PROVINCIA) As DataTable
            Return SqlHelper.ExecuteDataset(Cn, "SG_PL_SP_S_UBI_UBIGEO_BY_PROVI", Entidad.PR_CODIGO).Tables(0)
        End Function

        Public Sub getUbigeo_x_Id(ByVal Entidad As BE.PlanillaBE.SG_PL_TB_UBI_UBIGEO)
            Dim drr As SqlDataReader = SqlHelper.ExecuteReader(Cn, "SG_PL_SP_S_UBI_UBIGEO_BY_ID")

            If drr.HasRows Then
                drr.Read()
                Entidad.UB_DESCRIPCION = drr("UB_DESCRIPCION")
            End If
            drr.Close()
        End Sub

    End Class

    Public Class SG_PL_TB_UBI_PROVINCIA
        Inherits ClsBD

        Public Function getProvincias() As DataTable
            Return SqlHelper.ExecuteDataset(Cn, "SG_PL_SP_S_UBI_PROVINCIA").Tables(0)
        End Function

        Public Function getProvincias_x_Departamento(ByVal Entidad As BE.PlanillaBE.SG_PL_TB_UBI_DEPARTAMENTO) As DataTable
            Return SqlHelper.ExecuteDataset(Cn, "SG_PL_SP_S_UBI_PROVINCIA_BY_DEPA", Entidad.DE_CODIGO).Tables(0)
        End Function

    End Class

    Public Class SG_PL_TB_UBI_DEPARTAMENTO
        Inherits ClsBD

        Public Function getDepartamentos() As DataTable
            Return SqlHelper.ExecuteDataset(Cn, "SG_PL_SP_S_UBI_DEPARTAMENTO").Tables(0)
        End Function

    End Class

    Public Class SG_PL_TB_AFP
        Inherits ClsBD

        Public Sub Insert(ByVal Entidad As BE.PlanillaBE.SG_PL_TB_AFP)
            With Entidad
                SqlHelper.ExecuteNonQuery(Cn, "SG_PL_SP_I_AFP", .AF_ID, .AF_NOMBRE, .AF_DIRECCION, .AF_TELEFONO, .AF_COMISION_FIJA, .AF_COMISION_VAR, .AF_SEGURO, .AF_TOPE_SEGURO, .AF_IDCUENTA_CONTA.PC_NUM_CUENTA, .AF_IDEMPRESA.EM_ID, .AF_COD_SUNAT.PE_ID, .AF_COMISION_VAR2)
            End With
        End Sub

        Public Sub Update(ByVal Entidad As BE.PlanillaBE.SG_PL_TB_AFP)
            With Entidad
                SqlHelper.ExecuteNonQuery(Cn, "SG_PL_SP_U_AFP", .AF_ID, .AF_NOMBRE, .AF_DIRECCION, .AF_TELEFONO, .AF_COMISION_FIJA, .AF_COMISION_VAR, .AF_SEGURO, .AF_TOPE_SEGURO, .AF_IDCUENTA_CONTA.PC_NUM_CUENTA, .AF_IDEMPRESA.EM_ID, .AF_COD_SUNAT.PE_ID, .AF_COMISION_VAR2)
            End With
        End Sub

        Public Sub Delete(ByVal Entidad As BE.PlanillaBE.SG_PL_TB_AFP)
            With Entidad
                SqlHelper.ExecuteNonQuery(Cn, "SG_PL_SP_D_AFP", .AF_ID, .AF_IDEMPRESA.EM_ID)
            End With
        End Sub

        Public Function getAfp(ByVal Entidad As BE.ContabilidadBE.SG_CO_TB_EMPRESA) As DataTable
            Return SqlHelper.ExecuteDataset(Cn, "SG_PL_SP_S_AFP", Entidad.EM_ID).Tables(0)
        End Function

        Public Sub getAfp_x_Id(ByRef Entidad As BE.PlanillaBE.SG_PL_TB_AFP)
            Dim drr As SqlDataReader = SqlHelper.ExecuteReader(Cn, "SG_PL_SP_S_AFP_BY_ID", Entidad.AF_ID, Entidad.AF_IDEMPRESA.EM_ID)
            If drr.HasRows Then
                drr.Read()
                With Entidad
                    .AF_ID = drr("AF_ID")
                    .AF_NOMBRE = drr("AF_NOMBRE").ToString
                    .AF_DIRECCION = drr("AF_DIRECCION").ToString
                    .AF_TELEFONO = Val(drr("AF_TELEFONO").ToString)
                    .AF_COMISION_FIJA = Val(drr("AF_COMISION_FIJA").ToString)
                    .AF_COMISION_VAR = Val(drr("AF_COMISION_VAR").ToString)
                    .AF_COMISION_VAR2 = Val(drr("AF_COMISION_VAR2").ToString)
                    .AF_SEGURO = Val(drr("AF_SEGURO").ToString)
                    .AF_TOPE_SEGURO = Val(drr("AF_TOPE_SEGURO").ToString)
                    .AF_IDCUENTA_CONTA = New BE.ContabilidadBE.SG_CO_TB_PLANCTAS With {.PC_NUM_CUENTA = Val(drr("AF_IDCUENTA_CONTA").ToString)}
                    .AF_IDEMPRESA = New BE.ContabilidadBE.SG_CO_TB_EMPRESA With {.EM_ID = drr("AF_IDEMPRESA")}
                    .AF_COD_SUNAT = New BE.PlanillaBE.SG_PL_TB_PENSIONES With {.PE_ID = Val(drr("AF_COD_SUNAT").ToString)}
                End With
            End If
            drr.Close()
            drr = Nothing
        End Sub

        Public Function get_Ult_Cod(empresa_ As Integer)
            Return SqlHelper.ExecuteScalar(Cn, "SG_CO_SP_S_ULT_COD", empresa_)
        End Function

    End Class

    Public Class SG_PL_TB_AREA
        Inherits ClsBD

        Public Sub Insert(ByVal Entidad As BE.PlanillaBE.SG_PL_TB_AREA)
            Entidad.AR_ID = SqlHelper.ExecuteScalar(Cn, "SG_PL_SP_I_AREA", Entidad.AR_DESCRIPCION, Entidad.AR_ID_EMPRESA.EM_ID, Entidad.AR_IDJEFE)
        End Sub
        Public Sub Update(ByVal Entidad As BE.PlanillaBE.SG_PL_TB_AREA)
            SqlHelper.ExecuteNonQuery(Cn, "SG_PL_SP_U_AREA", Entidad.AR_ID, Entidad.AR_DESCRIPCION, Entidad.AR_ID_EMPRESA.EM_ID, Entidad.AR_IDJEFE)
        End Sub
        Public Sub Delete(ByVal Entidad As BE.PlanillaBE.SG_PL_TB_AREA)
            SqlHelper.ExecuteNonQuery(Cn, "SG_PL_SP_D_AREA", Entidad.AR_ID, Entidad.AR_ID_EMPRESA.EM_ID)
        End Sub
        Public Sub getArea_x_Id(ByRef Entidad As BE.PlanillaBE.SG_PL_TB_AREA)
            Dim drr As SqlDataReader = SqlHelper.ExecuteReader(Cn, "SG_PL_SP_S_AREA_BY_ID", Entidad.AR_ID, Entidad.AR_ID_EMPRESA.EM_ID)
            If drr.HasRows Then
                drr.Read()
                With Entidad
                    .AR_ID = drr("AR_ID")
                    .AR_DESCRIPCION = drr("AR_DESCRIPCION")
                    .AR_ID_EMPRESA = drr("AR_ID_EMPRESA")
                End With
            End If
            drr.Close()
            drr = Nothing
        End Sub
        Public Function getArea(ByVal Entidad As BE.PlanillaBE.SG_PL_TB_AREA) As DataTable
            Return SqlHelper.ExecuteDataset(Cn, "SG_PL_SP_S_AREA", Entidad.AR_ID_EMPRESA.EM_ID).Tables(0)
        End Function

    End Class

    Public Class SG_PL_TB_CARGO
        Inherits ClsBD


        Public Sub Insert(ByRef Entidad As BE.PlanillaBE.SG_PL_TB_CARGO)
            Entidad.EC_ID = SqlHelper.ExecuteScalar(Cn, "SG_PL_SP_I_CARGO", Entidad.EC_CARGO, Entidad.EC_IDEMPRESA.EM_ID)
        End Sub

        Public Sub Update(ByVal Entidad As BE.PlanillaBE.SG_PL_TB_CARGO)
            SqlHelper.ExecuteNonQuery(Cn, "SG_PL_SP_U_CARGO", Entidad.EC_ID, Entidad.EC_CARGO, Entidad.EC_IDEMPRESA.EM_ID)
        End Sub

        Public Sub Delete(ByVal Entidad As BE.PlanillaBE.SG_PL_TB_CARGO)
            SqlHelper.ExecuteNonQuery(Cn, "SG_PL_SP_D_CARGO", Entidad.EC_ID)
        End Sub

        Public Sub getCargo_x_Id(ByRef Entidad As BE.PlanillaBE.SG_PL_TB_CARGO)
            Dim drr As SqlDataReader = SqlHelper.ExecuteReader(Cn, "SG_PL_SP_S_CARGO_BY_ID", Entidad.EC_ID, Entidad.EC_IDEMPRESA.EM_ID)
            If drr.HasRows Then
                drr.Read()
                With Entidad
                    .EC_CARGO = drr("EC_CARGO")
                End With
            End If
            drr.Close()
            drr = Nothing
        End Sub

        Public Function getCargos(ByVal Entidad As BE.PlanillaBE.SG_PL_TB_CARGO) As DataTable
            Return SqlHelper.ExecuteDataset(Cn, "SG_PL_SP_S_CARGO", Entidad.EC_IDEMPRESA.EM_ID).Tables(0)
        End Function

    End Class

    Public Class SG_PL_TB_CLASIFICACION_PERSONAL
        Inherits ClsBD

        Public Sub Insert(ByVal Entidad As BE.PlanillaBE.SG_PL_TB_CLASIFICACION_PERSONAL)
            SqlHelper.ExecuteNonQuery(Cn, "SG_PL_SP_I_CLASIF_PERSONAL", Entidad.CP_ID, Entidad.CP_DESCRIPCION)
        End Sub
        Public Sub Update(ByVal Entidad As BE.PlanillaBE.SG_PL_TB_CLASIFICACION_PERSONAL)
            SqlHelper.ExecuteNonQuery(Cn, "SG_PL_SP_U_CLASIF_PERSONAL", Entidad.CP_ID, Entidad.CP_DESCRIPCION)
        End Sub
        Public Sub Delete(ByVal Entidad As BE.PlanillaBE.SG_PL_TB_CLASIFICACION_PERSONAL)
            SqlHelper.ExecuteNonQuery(Cn, "SG_PL_SP_D_CLASIF_PERSONAL", Entidad.CP_ID)
        End Sub
        Public Sub getClasificacion_x_Id(ByRef Entidad As BE.PlanillaBE.SG_PL_TB_CLASIFICACION_PERSONAL)
            Dim drr As SqlDataReader = SqlHelper.ExecuteReader(Cn, "SG_PL_SP_S_CLASIF_PER_BY_ID", Entidad.CP_ID)
            If drr.HasRows Then
                drr.Read()
                Entidad.CP_DESCRIPCION = drr("CP_DESCRIPCION")
            End If
            drr.Close()
        End Sub
        Public Function getClasificacion() As DataTable
            getClasificacion = Nothing
            Return SqlHelper.ExecuteDataset(Cn, CommandType.StoredProcedure, "SG_PL_SP_S_CLASIF_PER").Tables(0)
        End Function
    End Class

    Public Class SG_PL_TB_PENSIONES
        Inherits ClsBD

        Public Sub Insert(ByVal Entidad As BE.PlanillaBE.SG_PL_TB_PENSIONES)
            SqlHelper.ExecuteNonQuery(Cn, "SG_PL_SP_I_PENSIONES", Entidad.PE_ID, Entidad.PE_DESCRIPCION)
        End Sub
        Public Sub Update(ByVal Entidad As BE.PlanillaBE.SG_PL_TB_PENSIONES)
            SqlHelper.ExecuteNonQuery(Cn, "SG_PL_SP_U_PENSIONES", Entidad.PE_ID, Entidad.PE_DESCRIPCION)
        End Sub
        Public Sub Delete(ByVal Entidad As BE.PlanillaBE.SG_PL_TB_PENSIONES)
            SqlHelper.ExecuteNonQuery(Cn, "SG_PL_SP_D_PENSIONES", Entidad.PE_ID)
        End Sub
        Public Function getPensiones() As DataTable
            Return SqlHelper.ExecuteDataset(Cn, CommandType.StoredProcedure, "SG_PL_SP_S_PENSIONES").Tables(0)
        End Function

    End Class

    Public Class SG_PL_TB_DOCUMENTO_PERSONAL
        Inherits ClsBD

        Public Sub Insert(ByVal Entidad As BE.PlanillaBE.SG_PL_TB_DOCUMENTO_PERSONAL)
            SqlHelper.ExecuteNonQuery(Cn, "SG_PL_SP_I_DOCUMENTO_PERSONAL", Entidad.DP_ID, Entidad.DP_CODIGO, Entidad.DP_DESCRIPCION)
        End Sub

        Public Sub Update(ByVal Entidad As BE.PlanillaBE.SG_PL_TB_DOCUMENTO_PERSONAL)
            SqlHelper.ExecuteNonQuery(Cn, "SG_PL_SP_I_DOCUMENTO_PERSONAL", Entidad.DP_ID, Entidad.DP_DESCRIPCION)
        End Sub

        Public Sub Delete(ByVal Entidad As BE.PlanillaBE.SG_PL_TB_DOCUMENTO_PERSONAL)
            SqlHelper.ExecuteNonQuery(Cn, "SG_PL_SP_D_DOCUMENTO_PERSONAL", Entidad.DP_ID)
        End Sub

        Public Function getDocumentos() As DataTable
            getDocumentos = Nothing
            Return SqlHelper.ExecuteDataset(Cn, "SG_PL_SP_S_DOCUMENTO_PERSONAL").Tables(0)
        End Function

    End Class

    Public Class SG_PL_TB_EPS_SERVICIO_PROPIO
        Inherits ClsBD

        Public Sub Insert(ByVal Entidad As BE.PlanillaBE.SG_PL_TB_EPS_SERVICIO_PROPIO)
            SqlHelper.ExecuteNonQuery(Cn, "SG_PL_SP_I_EPS_SERVICIO_PROPIO", Entidad.EP_ID, Entidad.EP_RUC, Entidad.EP_DESCRIPCION)
        End Sub

        Public Sub Update(ByVal Entidad As BE.PlanillaBE.SG_PL_TB_EPS_SERVICIO_PROPIO)
            SqlHelper.ExecuteNonQuery(Cn, "SG_PL_SP_U_EPS_SERVICIO_PROPIO", Entidad.EP_ID, Entidad.EP_RUC, Entidad.EP_DESCRIPCION)
        End Sub

        Public Sub Delete(ByVal Entidad As BE.PlanillaBE.SG_PL_TB_EPS_SERVICIO_PROPIO)
            SqlHelper.ExecuteNonQuery(Cn, "SG_PL_SP_D_EPS_SERVICIO_PROPIO", Entidad.EP_ID)
        End Sub

        Public Function getEPS() As DataTable
            Return SqlHelper.ExecuteDataset(Cn, "SG_PL_SP_S_EPS_SERVICIO_PROPIO").Tables(0)
        End Function
    End Class

    Public Class SG_PL_TB_ESTADO_TRABAJADOR
        Inherits ClsBD

        Public Function getEstados() As DataTable
            Return SqlHelper.ExecuteDataset(Cn, "SG_PL_SP_S_ESTADO_TRABAJADOR").Tables(0)
        End Function

    End Class

    Public Class SG_PL_TB_ESTADO_VICIL
        Inherits ClsBD

        Public Function getEstados() As DataTable
            Return SqlHelper.ExecuteDataset(Cn, "SG_PL_SP_S_ESTADO_VICIL").Tables(0)
        End Function

    End Class

    Public Class SG_PL_TB_GRUPO_SANGUINEO
        Inherits ClsBD

        Public Sub Insert(ByRef Entidad As BE.PlanillaBE.SG_PL_TB_GRUPO_SANGUINEO)
            Entidad.GS_ID = SqlHelper.ExecuteScalar(Cn, "SG_PL_SP_I_GRUPO_SANGUINEO", Entidad.GS_TIPO, Entidad.GS_DESCRIPCION)
        End Sub

        Public Sub Update(ByVal Entidad As BE.PlanillaBE.SG_PL_TB_GRUPO_SANGUINEO)
            SqlHelper.ExecuteNonQuery(Cn, "SG_PL_SP_U_GRUPO_SANGUINEO", Entidad.GS_ID, Entidad.GS_TIPO, Entidad.GS_DESCRIPCION)
        End Sub

        Public Sub Delete(ByVal Entidad As BE.PlanillaBE.SG_PL_TB_GRUPO_SANGUINEO)
            SqlHelper.ExecuteNonQuery(Cn, "SG_PL_SP_D_GRUPO_SANGUINEO", Entidad.GS_ID)
        End Sub

        Public Function getGrupoSanguineo() As DataTable
            Return SqlHelper.ExecuteDataset(Cn, "SG_PL_SP_S_GRUPO_SANGUINEO").Tables(0)
        End Function

    End Class

    Public Class SG_PL_TB_NACIONALIDAD
        Inherits ClsBD

        Public Function getNacionalidades() As DataTable
            Return SqlHelper.ExecuteDataset(Cn, "SG_PL_SP_S_NACIONALIDAD").Tables(0)
        End Function
    End Class

    Public Class SG_PL_TB_NIVEL_EDUCATIVO
        Inherits ClsBD

        Public Function getNiveles() As DataTable
            Return SqlHelper.ExecuteDataset(Cn, "SG_PL_SP_S_NIVEL_EDUCATIVO").Tables(0)
        End Function

    End Class

    Public Class SG_PL_TB_OCUPACION
        Inherits ClsBD
        Public Function getOcupaciones() As DataTable
            Return SqlHelper.ExecuteDataset(Cn, "SG_PL_SP_S_OCUPACION").Tables(0)
        End Function

    End Class

    Public Class SG_PL_TB_PERIODO_REMUNERATIVO
        Inherits ClsBD

        Public Function getPeriodos() As DataTable
            Return SqlHelper.ExecuteDataset(Cn, "SG_PL_SP_S_PERIODO_REMUNERATIVO").Tables(0)
        End Function

    End Class

    Public Class SG_PL_TB_REGIMEN_LABORAL
        Inherits ClsBD

        Public Function getRegimenes() As DataTable
            Return SqlHelper.ExecuteDataset(Cn, "SG_PL_SP_S_REGIMEN_LABORAL").Tables(0)
        End Function

    End Class

    Public Class SG_PL_TB_SCTR_PENSION
        Inherits ClsBD

        Public Function getSctr() As DataTable
            Return SqlHelper.ExecuteDataset(Cn, "SG_PL_SP_S_SCTR_PENSION").Tables(0)
        End Function

    End Class

    Public Class SG_PL_TB_SCTR_SALUD
        Inherits ClsBD

        Public Function getSctr() As DataTable
            Return SqlHelper.ExecuteDataset(Cn, "SG_PL_SP_S_SCTR_SALUD").Tables(0)
        End Function
    End Class

    Public Class SG_PL_TB_SEXO
        Inherits ClsBD

        Public Function getSexos() As DataTable
            Return SqlHelper.ExecuteDataset(Cn, "SG_PL_SP_S_SEXO").Tables(0)
        End Function

    End Class

    Public Class SG_PL_TB_SITUACION_EPS
        Inherits ClsBD

        Public Function getSituaciones_x_Tipo(ByVal Entidad As BE.PlanillaBE.SG_PL_TB_SITUACION_EPS) As DataTable
            Return SqlHelper.ExecuteDataset(Cn, "SG_PL_SP_S_SIT_EPS_BY_TIPO", Entidad.SE_TIPO).Tables(0)
        End Function
    End Class

    Public Class SG_PL_TB_SITUACION_ESPECIAL
        Inherits ClsBD

        Public Function getSituaciones() As DataTable
            Return SqlHelper.ExecuteDataset(Cn, "SG_PL_SP_S_SITUACION_ESPECIAL").Tables(0)
        End Function
    End Class

    Public Class SG_PL_TB_TIPO_CESE
        Inherits ClsBD

        Public Function getTipos() As DataTable
            Return SqlHelper.ExecuteDataset(Cn, "SG_PL_SP_S_TIPO_CESE").Tables(0)
        End Function

    End Class

    Public Class SG_PL_TB_TIPO_CTA_BANCO
        Inherits ClsBD

        Public Function getTipos() As DataTable
            Return SqlHelper.ExecuteDataset(Cn, "SG_PL_SP_S_TIPO_CTA_BANCO").Tables(0)
        End Function
    End Class

    Public Class SG_PL_TB_TIPO_PAGO
        Inherits ClsBD

        Public Function getTipos() As DataTable
            Return SqlHelper.ExecuteDataset(Cn, "SG_PL_SP_S_TIPO_PAGO").Tables(0)
        End Function

    End Class

    Public Class SG_PL_TB_TIPO_PERSONAL
        Inherits ClsBD

        Public Function getTipos() As DataTable
            Return SqlHelper.ExecuteDataset(Cn, "SG_PL_SP_S_TIPO_PERSONAL").Tables(0)
        End Function
    End Class

    Public Class SG_PL_TB_TIPO_PERSONAL_CLI
        Inherits ClsBD

        Public Function getTipos() As DataTable
            Return SqlHelper.ExecuteDataset(Cn, "SG_PL_SP_S_TIPO_PERSONAL_CLI").Tables(0)
        End Function
    End Class

    Public Class SG_PL_TB_TIPO_REMUNERACION
        Inherits ClsBD

        Public Function getTipos() As DataTable
            Return SqlHelper.ExecuteDataset(Cn, "SG_PL_SP_S_TIPO_REMUNERACION").Tables(0)
        End Function
    End Class

    Public Class SG_PL_TB_TIPO_TRABAJADOR
        Inherits ClsBD

        Public Function getTipos() As DataTable
            Return SqlHelper.ExecuteDataset(Cn, "SG_PL_SP_S_TIPO_TRABAJADOR").Tables(0)
        End Function

    End Class

    Public Class SG_PL_TB_TIPO_VIA
        Inherits ClsBD

        Public Function getVias() As DataTable
            Return SqlHelper.ExecuteDataset(Cn, "SG_PL_SP_S_TIPO_VIA").Tables(0)
        End Function

    End Class

    Public Class SG_PL_TB_TIPO_ZONA
        Inherits ClsBD

        Public Function getZonas() As DataTable
            Return SqlHelper.ExecuteDataset(Cn, "SG_PL_SP_S_TIPO_ZONA").Tables(0)
        End Function
    End Class

    Public Class SG_PL_TB_PERSONAL_FOTO
        Inherits ClsBD

        Public Sub Insert(entidad As BE.PlanillaBE.SG_PL_TB_PERSONAL_FOTO)
            SqlHelper.ExecuteNonQuery(Cn, "SG_PL_SP_I_PERSO_FOTO", entidad.PF_IDPERSONAL, entidad.PF_FOTO)
        End Sub

        Public Sub Update(entidad As BE.PlanillaBE.SG_PL_TB_PERSONAL_FOTO)
            SqlHelper.ExecuteNonQuery(Cn, "SG_PL_SP_U_PERSO_FOTO", entidad.PF_IDPERSONAL, entidad.PF_FOTO)
        End Sub

        Public Function get_Foto_x_IdPersonal(idpersonal_ As Integer) As Byte()
            Dim FOTO As Byte()
            FOTO = SqlHelper.ExecuteScalar(Cn, "SG_PL_SP_S_FOTO_X_IDPER", idpersonal_)
            Return FOTO
        End Function

    End Class

    Public Class SG_PL_TB_PERSONAL
        Inherits ClsBD

        Public Function get_Personal_x_Utilidades(ByVal ayo_ As Integer) As DataTable
            Dim query As String = "SELECT PE_NUM_DOC_PER  AS 'DNI' FROM SG_PL_TB_PERSONAL WHERE PE_ID IN ( SELECT DISTINCT HI_ID_PERSONAL FROM SG_PL_TB_HISTORIAL WHERE  YEAR(HI_FEC_OPE)=" & ayo_ & ")"
            Return SqlHelper.ExecuteDataset(Cn, CommandType.Text, query).Tables(0)
        End Function

        Public Sub Insert(ByVal Entidad As BE.PlanillaBE.SG_PL_TB_PERSONAL, ByVal Lis_Comunicacion As List(Of BE.PlanillaBE.SG_PL_TB_PERSONA_COMUNICACION), ByVal Lis_ccostos As List(Of BE.PlanillaBE.SG_PL_TB_PERSONAL_CCOSTO), ByVal Lis_documentos As List(Of BE.PlanillaBE.SG_PL_TB_PERSONAL_DOCUMENTOS), ByVal Lis_contratos As List(Of BE.PlanillaBE.SG_PL_TB_PERSONAL_CONTRATOS), ByVal Lis_conceptos As List(Of BE.PlanillaBE.SG_PL_TB_PERSONAL_CONCEPTO), foto As BE.PlanillaBE.SG_PL_TB_PERSONAL_FOTO)
            With Entidad
                Entidad.PE_ID = SqlHelper.ExecuteScalar(Cn, "SG_PL_SP_I_PERSONAL", .PE_CODIGO, .PE_CODIGO_ALT, .PE_ID_TIPO_PER, _
                                          .PE_APE_PAT, .PE_APE_MAT, .PE_NOM_PRI, .PE_NOM_SEG, .PE_ID_TIPO_DOC_PER, _
                                          .PE_NUM_DOC_PER, .PE_FEC_NAC, .PE_ID_EST_CIVIL, _
                                          IIf(.PE_ID_CARGO = 0, DBNull.Value, .PE_ID_CARGO), .PE_NUM_IPSS, _
                                          IIf(.PE_ID_AFP = 0, DBNull.Value, .PE_ID_AFP), .PE_NUM_AFP, .PE_ID_EST_TRABAJADOR, .PE_IMPORTE_REMUNERACION, _
                                          .PE_ID_MONEDA_REMU, .PE_ID_TIPO_REMU, .PE_ID_TIPO_CUENTA_REMU, _
                                          .PE_ID_MONEDA_CUENTA, .PE_NUM_CUENTA, .PE_ID_SEXO, .PE_ID_NACIONALIDAD, _
                                          IIf(.PE_ID_ANEXO_CONTA = 0, DBNull.Value, .PE_ID_ANEXO_CONTA), _
                                          IIf(.PE_ID_GRUPO_SANGUINEO = 0, DBNull.Value, .PE_ID_GRUPO_SANGUINEO), .PE_HORAS_TRABAJO, .PE_DOMICILIADO, _
                                          .PE_ID_TIPO_VIA, .PE_NOMBRE_VIA, .PE_NUMERO_VIA, .PE_INTERIOR, .PE_ID_TIPO_ZONA, _
                                          .PE_NOMBRE_ZONA, .PE_REFERENCIA, LSet(.PE_UBIGEO, 6).Trim, .PE_ID_TIPO_TRABAJADOR, _
                                          IIf(.PE_ID_NIVEL_EDU Is Nothing, DBNull.Value, .PE_ID_NIVEL_EDU), _
                                          IIf(.PE_ID_OCUPACION Is Nothing, DBNull.Value, .PE_ID_OCUPACION), .PE_DISCAPACIDAD, _
                                          IIf(.PE_FEC_INSCRIP_REG_PEN = "", DBNull.Value, .PE_FEC_INSCRIP_REG_PEN), .PE_ID_REGIMEN_LABORAL, _
                                          .PE_SUJETO_JOR_MAX, .PE_SUJETO_REG_ALT, .PE_FEC_ING, _
                                          IIf(.PE_FEC_CESE = "", DBNull.Value, .PE_FEC_CESE), _
                                          IIf(.PE_ID_TIPO_CESE Is Nothing, DBNull.Value, .PE_ID_TIPO_CESE), _
                                          .PE_ID_SCTR_SALUD, .PE_ID_SCTR_PENSION, .PE_SUJETO_HORA_NOC, .PE_OTRO_ING_5TA, _
                                          .PE_ES_SINDICALIZADO, .PE_ID_PERIODO_REMUNERA, .PE_AFILIADO_EPS_SER_PRO, _
                                          IIf(.PE_ID_COD_EPS_SER_PRO = 0, DBNull.Value, .PE_ID_COD_EPS_SER_PRO), _
                                          IIf(.PE_ID_SITUACION_EPS Is Nothing, DBNull.Value, .PE_ID_SITUACION_EPS), .PE_ID_TIPO_PAGO, _
                                          .PE_ID_SITUACION_ESPECIAL, .PE_ID_CLASIFI_PER, .PE_ID_PERSONAL, _
                                          IIf(.PE_ID_AREA = 0, DBNull.Value, .PE_ID_AREA), _
                                          .PE_ASIGNACION_FAM, .PE_NUM_HIJOS, _
                                          IIf(.PE_ID_BANCO_CTS = 0, DBNull.Value, .PE_ID_BANCO_CTS), _
                                          IIf(.PE_ID_TIPO_CUENTA_CTS = 0, DBNull.Value, .PE_ID_TIPO_CUENTA_CTS), _
                                          .PE_NUM_CUENTA_CTS, .PE_ID_MONEDA_CTS, .PE_AFECTO_QUINTA, .PE_ID_EMPRESA, _
                                          .PE_FICHA, .PE_USUARIO, .PE_TERMINAL, .PE_FECREG, _
                                          IIf(.PE_ID_TIPO_PERSO_TARIFA.TT_ID = 0, DBNull.Value, .PE_ID_TIPO_PERSO_TARIFA.TT_ID), _
                                          .PE_CONSIDERA_FT, .PE_CALCULAR_CTS, .PE_COD_INTERBANCA, .PE_QUINTA_ANT, .PE_ES_RIA, .PE_IDCOMISION)
            End With

            If Not Lis_Comunicacion Is Nothing Then
                Dim comuniBL As New BL.PlanillaBL.SG_PL_TB_PERSONA_COMUNICACION
                For Each comunicaiconBE As BE.PlanillaBE.SG_PL_TB_PERSONA_COMUNICACION In Lis_Comunicacion
                    comunicaiconBE.PC_ID_PERSONA = Entidad
                    comuniBL.Insert(comunicaiconBE)
                Next
                comuniBL = Nothing
            End If


            If Not Lis_ccostos Is Nothing Then
                Dim ccostoBL As New SG_PL_TB_PERSONAL_CCOSTO
                For Each ccosto As BE.PlanillaBE.SG_PL_TB_PERSONAL_CCOSTO In Lis_ccostos
                    ccosto.CC_ID_PERSONA = Entidad
                    ccostoBL.Insert(ccosto)
                Next
                ccostoBL = Nothing
            End If

            If Not Lis_documentos Is Nothing Then
                Dim docBL As New BL.PlanillaBL.SG_PL_TB_PERSONAL_DOCUMENTOS
                For Each doc As BE.PlanillaBE.SG_PL_TB_PERSONAL_DOCUMENTOS In Lis_documentos
                    doc.DO_ID_PERSONAL = Entidad
                    docBL.Insert(doc)
                Next
                docBL = Nothing
            End If

            If Not Lis_contratos Is Nothing Then
                Dim contratoBL As New BL.PlanillaBL.SG_PL_TB_PERSONAL_CONTRATOS
                For Each contrato As BE.PlanillaBE.SG_PL_TB_PERSONAL_CONTRATOS In Lis_contratos
                    contrato.CO_ID_PERSONAL = Entidad
                    contratoBL.Insert(contrato)
                Next
                contratoBL = Nothing
            End If

            If Not Lis_conceptos Is Nothing Then
                Dim PerConceptoBL As New BL.PlanillaBL.SG_PL_TB_PERSONAL_CONCEPTO
                For Each personaConcepto As BE.PlanillaBE.SG_PL_TB_PERSONAL_CONCEPTO In Lis_conceptos
                    personaConcepto.PC_ID_PERSONAL = Entidad
                    PerConceptoBL.Insert(personaConcepto)
                Next
                PerConceptoBL = Nothing
            End If

            'Guardamos la foto
            foto.PF_IDPERSONAL = Entidad.PE_ID
            Dim fotoBL As New BL.PlanillaBL.SG_PL_TB_PERSONAL_FOTO
            fotoBL.Insert(foto)
            fotoBL = Nothing


            'Obtenemos y/o grabamos el codigo del anexo de contabilidad

            Dim anexoBL As New BL.ContabilidadBL.SG_CO_TB_ANEXO
            Dim anexoBE As New BE.ContabilidadBE.SG_CO_TB_ANEXO
            anexoBE.AN_IDANEXO = 0
            anexoBE.AN_DESCRIPCION = Entidad.PE_NOM_PRI + " " + Entidad.PE_NOM_SEG + " " + Entidad.PE_APE_PAT + " " + Entidad.PE_APE_MAT
            anexoBE.AN_ES_RELACIONADO = 0
            anexoBE.AN_IDEMPRESA = New BE.ContabilidadBE.SG_CO_TB_EMPRESA With {.EM_ID = Entidad.PE_ID_EMPRESA}
            anexoBE.AN_NUM_DOC = Entidad.PE_NUM_DOC_PER
            anexoBE.AN_PC_FECREG = Entidad.PE_FECREG
            anexoBE.AN_PC_TERMINAL = Entidad.PE_TERMINAL
            anexoBE.AN_PC_USUARIO = Entidad.PE_USUARIO
            anexoBE.AN_TIPO_ANEXO = New BE.ContabilidadBE.SG_CO_TB_TIPOANEXO With {.TA_CODIGO = BE.ContabilidadBE.TipoA.Personal}
            anexoBE.AN_TIPO_DOC = New BE.ContabilidadBE.SG_CO_TB_TIPO_DOC_IDENTIDAD With {.DI_CODIGO = BE.ContabilidadBE.TipoDocPersonal.Dni}
            anexoBE.AN_TIPO_EMPRESA = New BE.ContabilidadBE.SG_CO_TB_TIPOEMPRESA With {.TE_CODIGO = BE.ContabilidadBE.TipoEmpresa.Natural}

            Dim query_U_Personal As String = String.Empty
            Dim Id_Anexo_Nuevo As Integer = 0
            Try
                anexoBL.Insert_x_Planillas(anexoBE)
                Id_Anexo_Nuevo = anexoBE.AN_IDANEXO
            Catch ex As Exception
                If ex.Message.Equals("DUPLICADO") Then
                    Dim anexo_tmp As New BE.ContabilidadBE.SG_CO_TB_ANEXO
                    anexo_tmp.AN_IDEMPRESA = New BE.ContabilidadBE.SG_CO_TB_EMPRESA With {.EM_ID = Entidad.PE_ID_EMPRESA}
                    anexo_tmp.AN_TIPO_ANEXO = New BE.ContabilidadBE.SG_CO_TB_TIPOANEXO With {.TA_CODIGO = BE.ContabilidadBE.TipoA.Personal}
                    anexo_tmp.AN_NUM_DOC = Entidad.PE_NUM_DOC_PER
                    anexoBL.getAnexo_x_Ruc(anexo_tmp)
                    Id_Anexo_Nuevo = anexo_tmp.AN_IDANEXO
                    anexo_tmp = Nothing
                End If

            End Try

            query_U_Personal = "UPDATE SG_PL_TB_PERSONAL SET PE_ID_ANEXO_CONTA = " & Id_Anexo_Nuevo & " WHERE PE_ID = " & Entidad.PE_ID.ToString
            SqlHelper.ExecuteNonQuery(Cn, CommandType.Text, query_U_Personal)


            anexoBE = Nothing
            anexoBL = Nothing


            'Grabamos en la tabla de usuario

            'Dim usuarioBE As New BE.ContabilidadBE.SG_CO_TB_USUARIO
            'Dim usuarioBL As New BL.ContabilidadBL.SG_CO_TB_USUARIO

            'With usuarioBE
            '    .US_NOMBRE = Entidad.PE_NUM_DOC_PER
            '    .US_CLAVE = Entidad.PE_NUM_DOC_PER
            '    .US_DESCRIPCION = Entidad.PE_APE_PAT & " " & Entidad.PE_APE_MAT & " " & Entidad.PE_NOM_PRI
            '    .US_ISTATUS = 1
            '    .US_USUARIO = Entidad.PE_USUARIO
            '    .US_TERMINAL = Entidad.PE_TERMINAL
            '    .US_FECREG = Entidad.PE_FECREG
            '    .US_IDTIPO_USU = New BE.ContabilidadBE.SG_CO_TB_TIPO_USUARIO With {.TU_CODIGO = 8} 'perfil MARCACIONES   
            '    .US_FOTO = foto.PF_FOTO
            '    .US_TIPO_ACCESO = 2
            '    .US_ES_WEB = 0
            '    .US_IDPERSONAL = Entidad.PE_ID
            'End With

            'Try
            'Grabamos los datos de usuario de sistema
            'usuarioBL.Insert(usuarioBE)


            'ENVIAMOS CORREO AL PERSONAL SI TIENE CORREO ELECTRONICO
            'If Not Lis_Comunicacion Is Nothing Then
            '    For Each comunicaiconBE As BE.PlanillaBE.SG_PL_TB_PERSONA_COMUNICACION In Lis_Comunicacion
            '        comunicaiconBE.PC_ID_PERSONA = Entidad
            '        If comunicaiconBE.PC_ID_COMUNICACION.TC_ID = 4 Then

            '            'enviamos el correo
            '            Dim correoBL As New BL.ContabilidadBL.MyCorreo
            '            Dim mensaje As String = ""
            '            correoBL.Enviar_Correo_Nuevo_Personal("NoReply@igf.com.pe", comunicaiconBE.PC_NUMERO, mensaje)
            '            correoBL = Nothing

            '        End If
            '    Next

            'End If

            'Catch ex As Exception

            'End Try


            'usuarioBL = Nothing
            'usuarioBE = Nothing

        End Sub

        Public Sub Update(ByVal Entidad As BE.PlanillaBE.SG_PL_TB_PERSONAL, ByVal Lis_ccostos As List(Of BE.PlanillaBE.SG_PL_TB_PERSONAL_CCOSTO), ByVal Lis_conceptos As List(Of BE.PlanillaBE.SG_PL_TB_PERSONAL_CONCEPTO), fotoPer As BE.PlanillaBE.SG_PL_TB_PERSONAL_FOTO)
            With Entidad
                SqlHelper.ExecuteNonQuery(Cn, "SG_PL_SP_U_PERSONAL", .PE_ID, .PE_CODIGO, .PE_CODIGO_ALT, .PE_ID_TIPO_PER, _
                                          .PE_APE_PAT, .PE_APE_MAT, .PE_NOM_PRI, .PE_NOM_SEG, .PE_ID_TIPO_DOC_PER, _
                                          .PE_NUM_DOC_PER, .PE_FEC_NAC, .PE_ID_EST_CIVIL, _
                                          IIf(.PE_ID_CARGO = 0, DBNull.Value, .PE_ID_CARGO), .PE_NUM_IPSS, _
                                          IIf(.PE_ID_AFP = 0, DBNull.Value, .PE_ID_AFP), .PE_NUM_AFP, .PE_ID_EST_TRABAJADOR, .PE_IMPORTE_REMUNERACION, _
                                          .PE_ID_MONEDA_REMU, .PE_ID_TIPO_REMU, .PE_ID_TIPO_CUENTA_REMU, _
                                          .PE_ID_MONEDA_CUENTA, .PE_NUM_CUENTA, .PE_ID_SEXO, .PE_ID_NACIONALIDAD, _
                                          IIf(.PE_ID_ANEXO_CONTA = 0, DBNull.Value, .PE_ID_ANEXO_CONTA), _
                                          IIf(.PE_ID_GRUPO_SANGUINEO = 0, DBNull.Value, .PE_ID_GRUPO_SANGUINEO), .PE_HORAS_TRABAJO, .PE_DOMICILIADO, _
                                          .PE_ID_TIPO_VIA, .PE_NOMBRE_VIA, .PE_NUMERO_VIA, .PE_INTERIOR, .PE_ID_TIPO_ZONA, _
                                          .PE_NOMBRE_ZONA, .PE_REFERENCIA, LSet(.PE_UBIGEO, 6).Trim, .PE_ID_TIPO_TRABAJADOR, _
                                          IIf(.PE_ID_NIVEL_EDU Is Nothing, DBNull.Value, .PE_ID_NIVEL_EDU), _
                                          IIf(.PE_ID_OCUPACION Is Nothing, DBNull.Value, .PE_ID_OCUPACION), .PE_DISCAPACIDAD, _
                                          IIf(.PE_FEC_INSCRIP_REG_PEN = "", DBNull.Value, .PE_FEC_INSCRIP_REG_PEN), .PE_ID_REGIMEN_LABORAL, _
                                          .PE_SUJETO_JOR_MAX, .PE_SUJETO_REG_ALT, .PE_FEC_ING, _
                                          IIf(.PE_FEC_CESE = "", DBNull.Value, .PE_FEC_CESE), _
                                          IIf(.PE_ID_TIPO_CESE Is Nothing, DBNull.Value, .PE_ID_TIPO_CESE), _
                                          .PE_ID_SCTR_SALUD, .PE_ID_SCTR_PENSION, .PE_SUJETO_HORA_NOC, .PE_OTRO_ING_5TA, _
                                          .PE_ES_SINDICALIZADO, .PE_ID_PERIODO_REMUNERA, .PE_AFILIADO_EPS_SER_PRO, _
                                          IIf(.PE_ID_COD_EPS_SER_PRO = 0, DBNull.Value, .PE_ID_COD_EPS_SER_PRO), _
                                          IIf(.PE_ID_SITUACION_EPS Is Nothing, DBNull.Value, .PE_ID_SITUACION_EPS), .PE_ID_TIPO_PAGO, _
                                          .PE_ID_SITUACION_ESPECIAL, .PE_ID_CLASIFI_PER, .PE_ID_PERSONAL, _
                                          IIf(.PE_ID_AREA = 0, DBNull.Value, .PE_ID_AREA), _
                                          .PE_ASIGNACION_FAM, .PE_NUM_HIJOS, _
                                          IIf(.PE_ID_BANCO_CTS = 0, DBNull.Value, .PE_ID_BANCO_CTS), _
                                          IIf(.PE_ID_TIPO_CUENTA_CTS = 0, DBNull.Value, .PE_ID_TIPO_CUENTA_CTS), _
                                          .PE_NUM_CUENTA_CTS, .PE_ID_MONEDA_CTS, .PE_AFECTO_QUINTA, .PE_ID_EMPRESA, _
                                          .PE_FICHA, .PE_USUARIO, .PE_TERMINAL, .PE_FECREG, _
                                          IIf(.PE_ID_TIPO_PERSO_TARIFA.TT_ID = 0, DBNull.Value, .PE_ID_TIPO_PERSO_TARIFA.TT_ID), _
                                          .PE_CONSIDERA_FT, .PE_CALCULAR_CTS, .PE_COD_INTERBANCA, .PE_QUINTA_ANT, .PE_ES_RIA, _
                                          .PE_IDCOMISION)
            End With

            If Not Lis_ccostos Is Nothing Then
                Dim ccostoBL As New SG_PL_TB_PERSONAL_CCOSTO
                For Each ccosto As BE.PlanillaBE.SG_PL_TB_PERSONAL_CCOSTO In Lis_ccostos
                    ccosto.CC_ID_PERSONA = Entidad
                    ccostoBL.Update(ccosto)
                Next
            End If


            SqlHelper.ExecuteNonQuery(Cn, CommandType.Text, "DELETE FROM SG_PL_TB_PERSONAL_CONCEPTO WHERE PC_ID_PERSONAL = " & Entidad.PE_ID.ToString & " AND PC_ID_EMPRESA = " & Entidad.PE_ID_EMPRESA.ToString)

            If Not Lis_conceptos Is Nothing Then
                Dim PerConceptoBL As New BL.PlanillaBL.SG_PL_TB_PERSONAL_CONCEPTO
                For Each personaConcepto As BE.PlanillaBE.SG_PL_TB_PERSONAL_CONCEPTO In Lis_conceptos
                    personaConcepto.PC_ID_PERSONAL = Entidad
                    PerConceptoBL.Insert(personaConcepto)
                Next
            End If


            'actualizamos la foto
            Dim fotoPerBL As New BL.PlanillaBL.SG_PL_TB_PERSONAL_FOTO
            fotoPerBL.Update(fotoPer)
            fotoPerBL = Nothing

        End Sub

        Public Sub Delete(ByVal Entidad As BE.PlanillaBE.SG_PL_TB_PERSONAL)
            With Entidad
                SqlHelper.ExecuteNonQuery(Cn, "SG_PL_SP_D_PERSONAL", .PE_ID)
            End With
        End Sub

        Public Function getPersonal_Rep_Lista(ByVal empresa_ As Integer, activos_ As Integer) As DataTable
            Return SqlHelper.ExecuteDataset(Cn, "SG_PL_SP_S_PERSONAL_REP2", empresa_, activos_).Tables(0)
        End Function

        Public Function getPersonal_Rep_Ficha(ByVal idpersonal_ As Integer) As DataTable
            Return SqlHelper.ExecuteDataset(Cn, "SG_PL_SP_S_PERSONAL_REP1", idpersonal_).Tables(0)
        End Function

        Public Function getPersonal(ByVal Entidad As BE.PlanillaBE.SG_PL_TB_PERSONAL) As DataTable
            Return SqlHelper.ExecuteDataset(Cn, "SG_PL_SP_S_PERSONAL", Entidad.PE_ID_EMPRESA).Tables(0)
        End Function

        Public Function getPersonal_Lista_Mante(ByVal Entidad As BE.PlanillaBE.SG_PL_TB_PERSONAL) As DataTable
            Return SqlHelper.ExecuteDataset(Cn, "SG_PL_SP_S_PERSONAL_3", Entidad.PE_ID_EMPRESA).Tables(0)
        End Function

        Public Function getPersonal_ParaCalculos(ByVal Entidad As BE.PlanillaBE.SG_PL_TB_PERSONAL) As DataTable
            Return SqlHelper.ExecuteDataset(Cn, "SG_PL_SP_S_PERSONAL_2", Entidad.PE_ID_EMPRESA).Tables(0)
        End Function

        Public Function getPersonal_activos(ByVal Entidad As BE.PlanillaBE.SG_PL_TB_PERSONAL) As DataTable
            Return SqlHelper.ExecuteDataset(Cn, "SG_PL_SP_S_PERSONAL_ACTIVOS", Entidad.PE_ID_TIPO_PER, Entidad.PE_ID_EMPRESA).Tables(0)
        End Function

        Public Function getPersonal_RelacionPer(empresa_ As Integer) As DataTable
            Return SqlHelper.ExecuteDataset(Cn, "SG_PL_SP_S_PERSONAL_RELA", empresa_).Tables(0)
        End Function

        Public Function getPersonal_Consula_Boleta(ByVal Entidad As BE.PlanillaBE.SG_PL_TB_PERSONAL, ayo_ As Integer, mes_ As Integer) As DataTable
            Return SqlHelper.ExecuteDataset(Cn, "SG_PL_SP_S_PERSONAL_CONBOL", Entidad.PE_ID_TIPO_PER, Entidad.PE_ID_EMPRESA, ayo_, mes_).Tables(0)
        End Function

        Public Function getPersonal_Vista_1(ByVal Entidad As BE.PlanillaBE.SG_PL_TB_PERSONAL) As DataTable
            Return SqlHelper.ExecuteDataset(Cn, "SG_PL_SP_S_PERSONAL_V1", Entidad.PE_ID_EMPRESA).Tables(0)
        End Function

        Public Function getPersonal_Cmb_Login(empresa_ As Integer) As DataTable
            Return SqlHelper.ExecuteDataset(Cn, "SG_PL_SP_S_PERSO_LOGIN", empresa_).Tables(0)
        End Function

        Public Function getPersonal_Cmb_Login_02() As DataTable
            Return SqlHelper.ExecuteDataset(Cn, "SG_PL_SP_S_PERSO_LOGIN_02").Tables(0)
        End Function

        Public Function getPersonal_x_Tipo(ByVal Entidad As BE.PlanillaBE.SG_PL_TB_PERSONAL) As DataTable
            Return SqlHelper.ExecuteDataset(Cn, "SG_PL_SP_S_PERSONAL_X_TIPO", Entidad.PE_ID_TIPO_PER, Entidad.PE_AFECTO_QUINTA, Entidad.PE_ID_EMPRESA).Tables(0)
        End Function

        Public Function getPersonal_x_Tipo_Tardanzas(ByVal Entidad As BE.PlanillaBE.SG_PL_TB_PERSONAL) As DataTable
            Return SqlHelper.ExecuteDataset(Cn, "SG_PL_SP_S_PERSONAL_X_TIPO_TARDANZAS", Entidad.PE_ID_TIPO_PER, Entidad.PE_AFECTO_QUINTA, Entidad.PE_ID_EMPRESA).Tables(0)
        End Function

        Public Function getPersonal_x_Tipo_x_IdPersonal(ByVal Entidad As BE.PlanillaBE.SG_PL_TB_PERSONAL) As DataTable
            Return SqlHelper.ExecuteDataset(Cn, "SG_PL_SP_S_PERSONAL_X_TIPO_XIDPER", Entidad.PE_ID_TIPO_PER, Entidad.PE_AFECTO_QUINTA, Entidad.PE_ID_EMPRESA, Entidad.PE_ID).Tables(0)
        End Function

        Public Function getPersonal_x_Tipo_x_IdPersonal_Tardanza(ByVal Entidad As BE.PlanillaBE.SG_PL_TB_PERSONAL) As DataTable
            Return SqlHelper.ExecuteDataset(Cn, "SG_PL_SP_S_PERS_X_TIPO_XIDPER_TARDA", Entidad.PE_ID_TIPO_PER, Entidad.PE_AFECTO_QUINTA, Entidad.PE_ID_EMPRESA, Entidad.PE_ID).Tables(0)
        End Function

        Public Sub getPersonal_x_Id(ByRef Entidad As BE.PlanillaBE.SG_PL_TB_PERSONAL)

            Dim drr As SqlDataReader = SqlHelper.ExecuteReader(Cn, "SG_PL_SP_S_PERSONAL_BY_ID", Entidad.PE_ID, Entidad.PE_ID_EMPRESA)
            If drr.HasRows Then
                drr.Read()
                With Entidad
                    .PE_ID = drr("PE_ID")
                    .PE_CODIGO = drr("PE_CODIGO")
                    .PE_CODIGO_ALT = drr("PE_CODIGO_ALT")
                    .PE_ID_TIPO_PER = drr("PE_ID_TIPO_PER")
                    .PE_APE_PAT = drr("PE_APE_PAT")
                    .PE_APE_MAT = drr("PE_APE_MAT")
                    .PE_NOM_PRI = drr("PE_NOM_PRI")
                    .PE_NOM_SEG = drr("PE_NOM_SEG")
                    .PE_ID_TIPO_DOC_PER = drr("PE_ID_TIPO_DOC_PER")
                    .PE_NUM_DOC_PER = drr("PE_NUM_DOC_PER")
                    .PE_FEC_NAC = drr("PE_FEC_NAC")
                    .PE_ID_EST_CIVIL = drr("PE_ID_EST_CIVIL")
                    .PE_ID_CARGO = Val(drr("PE_ID_CARGO").ToString)
                    .PE_NUM_IPSS = drr("PE_NUM_IPSS")
                    .PE_ID_AFP = Val(drr("PE_ID_AFP").ToString)
                    .PE_NUM_AFP = drr("PE_NUM_AFP")
                    .PE_ID_EST_TRABAJADOR = drr("PE_ID_EST_TRABAJADOR")
                    .PE_IMPORTE_REMUNERACION = IIf(drr("PE_IMPORTE_REMUNERACION").ToString = "", 0, drr("PE_IMPORTE_REMUNERACION"))
                    .PE_ID_MONEDA_REMU = drr("PE_ID_MONEDA_REMU")
                    .PE_ID_TIPO_REMU = drr("PE_ID_TIPO_REMU")
                    .PE_ID_TIPO_CUENTA_REMU = drr("PE_ID_TIPO_CUENTA_REMU")
                    .PE_ID_MONEDA_CUENTA = drr("PE_ID_MONEDA_CUENTA")
                    .PE_NUM_CUENTA = drr("PE_NUM_CUENTA")
                    .PE_ID_SEXO = drr("PE_ID_SEXO")
                    .PE_ID_NACIONALIDAD = drr("PE_ID_NACIONALIDAD")
                    .PE_ID_ANEXO_CONTA = IIf(drr("PE_ID_ANEXO_CONTA").ToString = "", Nothing, drr("PE_ID_ANEXO_CONTA"))
                    .PE_ID_GRUPO_SANGUINEO = Val(drr("PE_ID_GRUPO_SANGUINEO").ToString)
                    .PE_HORAS_TRABAJO = drr("PE_HORAS_TRABAJO")
                    .PE_DOMICILIADO = drr("PE_DOMICILIADO")
                    .PE_ID_TIPO_VIA = drr("PE_ID_TIPO_VIA").ToString
                    .PE_NOMBRE_VIA = drr("PE_NOMBRE_VIA").ToString
                    .PE_NUMERO_VIA = drr("PE_NUMERO_VIA").ToString
                    .PE_INTERIOR = drr("PE_INTERIOR").ToString
                    .PE_ID_TIPO_ZONA = drr("PE_ID_TIPO_ZONA").ToString
                    .PE_NOMBRE_ZONA = drr("PE_NOMBRE_ZONA").ToString
                    .PE_REFERENCIA = drr("PE_REFERENCIA").ToString
                    .PE_UBIGEO = drr("PE_UBIGEO").ToString
                    .PE_ID_TIPO_TRABAJADOR = drr("PE_ID_TIPO_TRABAJADOR")
                    .PE_ID_NIVEL_EDU = Val(drr("PE_ID_NIVEL_EDU").ToString)
                    .PE_ID_OCUPACION = Val(drr("PE_ID_OCUPACION").ToString)
                    .PE_DISCAPACIDAD = drr("PE_DISCAPACIDAD")
                    .PE_FEC_INSCRIP_REG_PEN = drr("PE_FEC_INSCRIP_REG_PEN").ToString
                    .PE_ID_REGIMEN_LABORAL = IIf(drr("PE_ID_REGIMEN_LABORAL").ToString = "", 0, drr("PE_ID_REGIMEN_LABORAL"))
                    .PE_SUJETO_JOR_MAX = IIf(drr("PE_SUJETO_JOR_MAX").ToString = "", 0, drr("PE_SUJETO_JOR_MAX"))
                    .PE_SUJETO_REG_ALT = IIf(drr("PE_SUJETO_REG_ALT").ToString = "", 0, drr("PE_SUJETO_REG_ALT"))
                    .PE_FEC_ING = drr("PE_FEC_ING")
                    .PE_FEC_CESE = drr("PE_FEC_CESE").ToString
                    .PE_ID_TIPO_CESE = drr("PE_ID_TIPO_CESE").ToString
                    .PE_ID_SCTR_SALUD = IIf(drr("PE_ID_SCTR_SALUD").ToString = "", 0, drr("PE_ID_SCTR_SALUD"))
                    .PE_ID_SCTR_PENSION = IIf(drr("PE_ID_SCTR_PENSION").ToString = "", 0, drr("PE_ID_SCTR_PENSION"))
                    .PE_SUJETO_HORA_NOC = IIf(drr("PE_SUJETO_HORA_NOC").ToString = "", 0, drr("PE_SUJETO_HORA_NOC"))
                    .PE_OTRO_ING_5TA = IIf(drr("PE_OTRO_ING_5TA").ToString = "", 0, drr("PE_OTRO_ING_5TA"))
                    .PE_ES_SINDICALIZADO = IIf(drr("PE_ES_SINDICALIZADO").ToString = "", 0, drr("PE_ES_SINDICALIZADO"))
                    .PE_ID_PERIODO_REMUNERA = drr("PE_ID_PERIODO_REMUNERA")
                    .PE_AFILIADO_EPS_SER_PRO = drr("PE_AFILIADO_EPS_SER_PRO")
                    .PE_ID_COD_EPS_SER_PRO = Val(drr("PE_ID_COD_EPS_SER_PRO").ToString)
                    .PE_ID_SITUACION_EPS = Val(drr("PE_ID_SITUACION_EPS").ToString)
                    .PE_ID_TIPO_PAGO = drr("PE_ID_TIPO_PAGO")
                    .PE_ID_SITUACION_ESPECIAL = drr("PE_ID_SITUACION_ESPECIAL")
                    .PE_ID_CLASIFI_PER = drr("PE_ID_CLASIFI_PER")
                    .PE_ID_PERSONAL = drr("PE_ID_PERSONAL")
                    .PE_ID_AREA = Val(drr("PE_ID_AREA").ToString)
                    .PE_ASIGNACION_FAM = drr("PE_ASIGNACION_FAM")
                    .PE_NUM_HIJOS = drr("PE_NUM_HIJOS")
                    .PE_ID_BANCO_CTS = Val(drr("PE_ID_BANCO_CTS").ToString)
                    .PE_ID_TIPO_CUENTA_CTS = Val(drr("PE_ID_TIPO_CUENTA_CTS").ToString)
                    .PE_NUM_CUENTA_CTS = drr("PE_NUM_CUENTA_CTS")
                    .PE_ID_MONEDA_CTS = drr("PE_ID_MONEDA_CTS")
                    .PE_AFECTO_QUINTA = drr("PE_AFECTO_QUINTA")
                    .PE_ID_EMPRESA = drr("PE_ID_EMPRESA")
                    .PE_FICHA = drr("PE_FICHA")
                    .PE_CONSIDERA_FT = IIf(drr("PE_CONSIDERA_FT").ToString = "", 0, drr("PE_CONSIDERA_FT"))
                    .PE_CALCULAR_CTS = IIf(drr("PE_CALCULAR_CTS").ToString = "", 0, drr("PE_CALCULAR_CTS"))

                    If drr("PE_ID_TIPO_PERSO_TARIFA").ToString <> "" Then
                        .PE_ID_TIPO_PERSO_TARIFA = New BE.PlanillaBE.SG_PL_TB_TIPO_PERSO_TARIFA With {.TT_ID = drr("PE_ID_TIPO_PERSO_TARIFA")}
                    Else
                        .PE_ID_TIPO_PERSO_TARIFA = Nothing

                    End If

                    .PE_COD_INTERBANCA = drr("PE_COD_INTERBANCA").ToString
                    .PE_QUINTA_ANT = drr("PE_QUINTA_ANT")
                    .PE_ES_RIA = drr("PE_ES_RIA")
                    .PE_IDCOMISION = drr("PE_IDCOMISION")

                End With
            End If

            drr.Close()
            drr = Nothing

        End Sub

        Public Sub getPersonal_x_Codigo(ByRef Entidad As BE.PlanillaBE.SG_PL_TB_PERSONAL)

            Dim drr As SqlDataReader = SqlHelper.ExecuteReader(Cn, "SG_PL_SP_S_PERSONAL_BY_COD", Entidad.PE_CODIGO, Entidad.PE_ID_EMPRESA)
            If drr.HasRows Then
                drr.Read()
                With Entidad
                    .PE_ID = drr("PE_ID")
                    .PE_CODIGO = drr("PE_CODIGO")
                    .PE_CODIGO_ALT = drr("PE_CODIGO_ALT")
                    .PE_ID_TIPO_PER = drr("PE_ID_TIPO_PER")
                    .PE_APE_PAT = drr("PE_APE_PAT")
                    .PE_APE_MAT = drr("PE_APE_MAT")
                    .PE_NOM_PRI = drr("PE_NOM_PRI")
                    .PE_NOM_SEG = drr("PE_NOM_SEG")
                    .PE_ID_TIPO_DOC_PER = drr("PE_ID_TIPO_DOC_PER")
                    .PE_NUM_DOC_PER = drr("PE_NUM_DOC_PER")
                    .PE_FEC_NAC = drr("PE_FEC_NAC")
                    .PE_ID_EST_CIVIL = drr("PE_ID_EST_CIVIL")
                    .PE_ID_CARGO = Val(drr("PE_ID_CARGO").ToString)
                    .PE_NUM_IPSS = drr("PE_NUM_IPSS")
                    .PE_ID_AFP = Val(drr("PE_ID_AFP").ToString)
                    .PE_NUM_AFP = drr("PE_NUM_AFP")
                    .PE_ID_EST_TRABAJADOR = drr("PE_ID_EST_TRABAJADOR")
                    .PE_IMPORTE_REMUNERACION = drr("PE_IMPORTE_REMUNERACION")
                    .PE_ID_MONEDA_REMU = drr("PE_ID_MONEDA_REMU")
                    .PE_ID_TIPO_REMU = drr("PE_ID_TIPO_REMU")
                    .PE_ID_TIPO_CUENTA_REMU = drr("PE_ID_TIPO_CUENTA_REMU")
                    .PE_ID_MONEDA_CUENTA = drr("PE_ID_MONEDA_CUENTA")
                    .PE_NUM_CUENTA = drr("PE_NUM_CUENTA")
                    .PE_ID_SEXO = drr("PE_ID_SEXO")
                    .PE_ID_NACIONALIDAD = drr("PE_ID_NACIONALIDAD")
                    If drr("PE_ID_ANEXO_CONTA").ToString = "" Then
                        .PE_ID_ANEXO_CONTA = 0
                    Else
                        .PE_ID_ANEXO_CONTA = drr("PE_ID_ANEXO_CONTA")
                    End If

                    .PE_ID_GRUPO_SANGUINEO = Val(drr("PE_ID_GRUPO_SANGUINEO").ToString)
                    .PE_HORAS_TRABAJO = drr("PE_HORAS_TRABAJO")
                    .PE_DOMICILIADO = drr("PE_DOMICILIADO")
                    .PE_ID_TIPO_VIA = drr("PE_ID_TIPO_VIA").ToString
                    .PE_NOMBRE_VIA = drr("PE_NOMBRE_VIA")
                    .PE_NUMERO_VIA = drr("PE_NUMERO_VIA")
                    .PE_INTERIOR = drr("PE_INTERIOR")
                    .PE_ID_TIPO_ZONA = drr("PE_ID_TIPO_ZONA").ToString
                    .PE_NOMBRE_ZONA = drr("PE_NOMBRE_ZONA")
                    .PE_REFERENCIA = drr("PE_REFERENCIA")
                    .PE_UBIGEO = drr("PE_UBIGEO")
                    .PE_ID_TIPO_TRABAJADOR = drr("PE_ID_TIPO_TRABAJADOR")
                    .PE_ID_NIVEL_EDU = Val(drr("PE_ID_NIVEL_EDU").ToString)
                    .PE_ID_OCUPACION = Val(drr("PE_ID_OCUPACION").ToString)
                    .PE_DISCAPACIDAD = drr("PE_DISCAPACIDAD")
                    .PE_FEC_INSCRIP_REG_PEN = drr("PE_FEC_INSCRIP_REG_PEN").ToString
                    .PE_ID_REGIMEN_LABORAL = drr("PE_ID_REGIMEN_LABORAL")
                    .PE_SUJETO_JOR_MAX = drr("PE_SUJETO_JOR_MAX")
                    .PE_SUJETO_REG_ALT = drr("PE_SUJETO_REG_ALT")
                    .PE_FEC_ING = drr("PE_FEC_ING")
                    .PE_FEC_CESE = drr("PE_FEC_CESE").ToString
                    .PE_ID_TIPO_CESE = drr("PE_ID_TIPO_CESE").ToString
                    .PE_ID_SCTR_SALUD = drr("PE_ID_SCTR_SALUD")
                    .PE_ID_SCTR_PENSION = drr("PE_ID_SCTR_PENSION")
                    .PE_SUJETO_HORA_NOC = drr("PE_SUJETO_HORA_NOC")
                    .PE_OTRO_ING_5TA = drr("PE_OTRO_ING_5TA")
                    .PE_ES_SINDICALIZADO = drr("PE_ES_SINDICALIZADO")
                    .PE_ID_PERIODO_REMUNERA = drr("PE_ID_PERIODO_REMUNERA")
                    .PE_AFILIADO_EPS_SER_PRO = drr("PE_AFILIADO_EPS_SER_PRO")
                    .PE_ID_COD_EPS_SER_PRO = Val(drr("PE_ID_COD_EPS_SER_PRO").ToString)
                    .PE_ID_SITUACION_EPS = Val(drr("PE_ID_SITUACION_EPS").ToString)
                    .PE_ID_TIPO_PAGO = drr("PE_ID_TIPO_PAGO")
                    .PE_ID_SITUACION_ESPECIAL = drr("PE_ID_SITUACION_ESPECIAL")
                    .PE_ID_CLASIFI_PER = drr("PE_ID_CLASIFI_PER")
                    .PE_ID_PERSONAL = drr("PE_ID_PERSONAL")
                    .PE_ID_AREA = Val(drr("PE_ID_AREA").ToString)
                    .PE_ASIGNACION_FAM = drr("PE_ASIGNACION_FAM")
                    .PE_NUM_HIJOS = drr("PE_NUM_HIJOS")
                    .PE_ID_BANCO_CTS = Val(drr("PE_ID_BANCO_CTS").ToString)
                    .PE_ID_TIPO_CUENTA_CTS = Val(drr("PE_ID_TIPO_CUENTA_CTS").ToString)
                    .PE_NUM_CUENTA_CTS = drr("PE_NUM_CUENTA_CTS")
                    .PE_ID_MONEDA_CTS = drr("PE_ID_MONEDA_CTS")
                    .PE_AFECTO_QUINTA = drr("PE_AFECTO_QUINTA")
                    .PE_ID_EMPRESA = drr("PE_ID_EMPRESA")
                    .PE_FICHA = drr("PE_FICHA")
                    .PE_CONSIDERA_FT = IIf(drr("PE_CONSIDERA_FT").ToString = "", 0, drr("PE_CONSIDERA_FT"))
                    .PE_CALCULAR_CTS = IIf(drr("PE_CALCULAR_CTS").ToString = "", 0, drr("PE_CALCULAR_CTS"))

                    If drr("PE_ID_TIPO_PERSO_TARIFA").ToString <> "" Then
                        .PE_ID_TIPO_PERSO_TARIFA = New BE.PlanillaBE.SG_PL_TB_TIPO_PERSO_TARIFA With {.TT_ID = drr("PE_ID_TIPO_PERSO_TARIFA")}
                    Else
                        .PE_ID_TIPO_PERSO_TARIFA = Nothing

                    End If

                    .PE_COD_INTERBANCA = drr("PE_COD_INTERBANCA").ToString
                    .PE_QUINTA_ANT = drr("PE_QUINTA_ANT")
                    .PE_ES_RIA = drr("PE_ES_RIA")
                    .PE_IDCOMISION = drr("PE_IDCOMISION")

                End With
            End If

            drr.Close()
            drr = Nothing

        End Sub

        Public Sub getPersonal_x_DNI(ByRef Entidad As BE.PlanillaBE.SG_PL_TB_PERSONAL)

            Dim drr As SqlDataReader = SqlHelper.ExecuteReader(Cn, "SG_PL_SP_S_PERSONAL_BY_DNI", Entidad.PE_NUM_DOC_PER, Entidad.PE_ID_EMPRESA)
            If drr.HasRows Then
                drr.Read()
                With Entidad
                    .PE_ID = drr("PE_ID")
                    .PE_CODIGO = drr("PE_CODIGO")
                    .PE_CODIGO_ALT = drr("PE_CODIGO_ALT")
                    .PE_ID_TIPO_PER = drr("PE_ID_TIPO_PER")
                    .PE_APE_PAT = drr("PE_APE_PAT")
                    .PE_APE_MAT = drr("PE_APE_MAT")
                    .PE_NOM_PRI = drr("PE_NOM_PRI")
                    .PE_NOM_SEG = drr("PE_NOM_SEG")
                    .PE_ID_TIPO_DOC_PER = drr("PE_ID_TIPO_DOC_PER")
                    .PE_NUM_DOC_PER = drr("PE_NUM_DOC_PER")
                    .PE_FEC_NAC = drr("PE_FEC_NAC")
                    .PE_ID_EST_CIVIL = drr("PE_ID_EST_CIVIL")
                    .PE_ID_CARGO = Val(drr("PE_ID_CARGO").ToString)
                    .PE_NUM_IPSS = drr("PE_NUM_IPSS")
                    .PE_ID_AFP = Val(drr("PE_ID_AFP").ToString)
                    .PE_NUM_AFP = drr("PE_NUM_AFP")
                    .PE_ID_EST_TRABAJADOR = drr("PE_ID_EST_TRABAJADOR")
                    .PE_IMPORTE_REMUNERACION = drr("PE_IMPORTE_REMUNERACION")
                    .PE_ID_MONEDA_REMU = drr("PE_ID_MONEDA_REMU")
                    .PE_ID_TIPO_REMU = drr("PE_ID_TIPO_REMU")
                    .PE_ID_TIPO_CUENTA_REMU = drr("PE_ID_TIPO_CUENTA_REMU")
                    .PE_ID_MONEDA_CUENTA = drr("PE_ID_MONEDA_CUENTA")
                    .PE_NUM_CUENTA = drr("PE_NUM_CUENTA")
                    .PE_ID_SEXO = drr("PE_ID_SEXO")
                    .PE_ID_NACIONALIDAD = drr("PE_ID_NACIONALIDAD")
                    If drr("PE_ID_ANEXO_CONTA").ToString = "" Then
                        .PE_ID_ANEXO_CONTA = 0
                    Else
                        .PE_ID_ANEXO_CONTA = drr("PE_ID_ANEXO_CONTA")
                    End If

                    .PE_ID_GRUPO_SANGUINEO = Val(drr("PE_ID_GRUPO_SANGUINEO").ToString)
                    .PE_HORAS_TRABAJO = drr("PE_HORAS_TRABAJO")
                    .PE_DOMICILIADO = drr("PE_DOMICILIADO")
                    .PE_ID_TIPO_VIA = drr("PE_ID_TIPO_VIA").ToString
                    .PE_NOMBRE_VIA = drr("PE_NOMBRE_VIA")
                    .PE_NUMERO_VIA = drr("PE_NUMERO_VIA")
                    .PE_INTERIOR = drr("PE_INTERIOR")
                    .PE_ID_TIPO_ZONA = drr("PE_ID_TIPO_ZONA").ToString
                    .PE_NOMBRE_ZONA = drr("PE_NOMBRE_ZONA")
                    .PE_REFERENCIA = drr("PE_REFERENCIA")
                    .PE_UBIGEO = drr("PE_UBIGEO")
                    .PE_ID_TIPO_TRABAJADOR = drr("PE_ID_TIPO_TRABAJADOR")
                    .PE_ID_NIVEL_EDU = Val(drr("PE_ID_NIVEL_EDU").ToString)
                    .PE_ID_OCUPACION = Val(drr("PE_ID_OCUPACION").ToString)
                    .PE_DISCAPACIDAD = drr("PE_DISCAPACIDAD")
                    .PE_FEC_INSCRIP_REG_PEN = drr("PE_FEC_INSCRIP_REG_PEN").ToString
                    .PE_ID_REGIMEN_LABORAL = drr("PE_ID_REGIMEN_LABORAL")
                    .PE_SUJETO_JOR_MAX = drr("PE_SUJETO_JOR_MAX")
                    .PE_SUJETO_REG_ALT = drr("PE_SUJETO_REG_ALT")
                    .PE_FEC_ING = drr("PE_FEC_ING")
                    .PE_FEC_CESE = drr("PE_FEC_CESE").ToString
                    .PE_ID_TIPO_CESE = drr("PE_ID_TIPO_CESE").ToString
                    .PE_ID_SCTR_SALUD = drr("PE_ID_SCTR_SALUD")
                    .PE_ID_SCTR_PENSION = drr("PE_ID_SCTR_PENSION")
                    .PE_SUJETO_HORA_NOC = drr("PE_SUJETO_HORA_NOC")
                    .PE_OTRO_ING_5TA = drr("PE_OTRO_ING_5TA")
                    .PE_ES_SINDICALIZADO = drr("PE_ES_SINDICALIZADO")
                    .PE_ID_PERIODO_REMUNERA = drr("PE_ID_PERIODO_REMUNERA")
                    .PE_AFILIADO_EPS_SER_PRO = drr("PE_AFILIADO_EPS_SER_PRO")
                    .PE_ID_COD_EPS_SER_PRO = Val(drr("PE_ID_COD_EPS_SER_PRO").ToString)
                    .PE_ID_SITUACION_EPS = Val(drr("PE_ID_SITUACION_EPS").ToString)
                    .PE_ID_TIPO_PAGO = drr("PE_ID_TIPO_PAGO")
                    .PE_ID_SITUACION_ESPECIAL = drr("PE_ID_SITUACION_ESPECIAL")
                    .PE_ID_CLASIFI_PER = drr("PE_ID_CLASIFI_PER")
                    .PE_ID_PERSONAL = drr("PE_ID_PERSONAL")
                    .PE_ID_AREA = Val(drr("PE_ID_AREA").ToString)
                    .PE_ASIGNACION_FAM = drr("PE_ASIGNACION_FAM")
                    .PE_NUM_HIJOS = drr("PE_NUM_HIJOS")
                    .PE_ID_BANCO_CTS = Val(drr("PE_ID_BANCO_CTS").ToString)
                    .PE_ID_TIPO_CUENTA_CTS = Val(drr("PE_ID_TIPO_CUENTA_CTS").ToString)
                    .PE_NUM_CUENTA_CTS = drr("PE_NUM_CUENTA_CTS")
                    .PE_ID_MONEDA_CTS = drr("PE_ID_MONEDA_CTS")
                    .PE_AFECTO_QUINTA = drr("PE_AFECTO_QUINTA")
                    .PE_ID_EMPRESA = drr("PE_ID_EMPRESA")
                    .PE_FICHA = drr("PE_FICHA")

                    .PE_CONSIDERA_FT = IIf(drr("PE_CONSIDERA_FT").ToString = "", 0, drr("PE_CONSIDERA_FT"))
                    .PE_CALCULAR_CTS = IIf(drr("PE_CALCULAR_CTS").ToString = "", 0, drr("PE_CALCULAR_CTS"))

                    If drr("PE_ID_TIPO_PERSO_TARIFA").ToString <> "" Then
                        .PE_ID_TIPO_PERSO_TARIFA = New BE.PlanillaBE.SG_PL_TB_TIPO_PERSO_TARIFA With {.TT_ID = drr("PE_ID_TIPO_PERSO_TARIFA")}
                    Else
                        .PE_ID_TIPO_PERSO_TARIFA = Nothing

                    End If

                    .PE_COD_INTERBANCA = drr("PE_COD_INTERBANCA").ToString
                    .PE_QUINTA_ANT = drr("PE_QUINTA_ANT")
                    .PE_ES_RIA = drr("PE_ES_RIA")
                    .PE_IDCOMISION = drr("PE_IDCOMISION")

                End With
            End If

            drr.Close()
            drr = Nothing

        End Sub

        Public Function get_Nuevo_Codigo_Personal(ByVal Empresa As BE.ContabilidadBE.SG_CO_TB_EMPRESA) As String
            Dim codigo_tmp As String = SqlHelper.ExecuteScalar(Cn, "SG_PL_SP_S_ULTIMO_COD_PER", Empresa.EM_ID)
            codigo_tmp = codigo_tmp.PadLeft(5, "0")
            Return codigo_tmp
        End Function

        Public Function get_Nuevo_Codigo_Alterno_Personal(ByVal Empresa As BE.ContabilidadBE.SG_CO_TB_EMPRESA) As String
            Dim codigo_tmp As String = SqlHelper.ExecuteScalar(Cn, "SG_PL_SP_S_ULTIMO_COD_PER_ALT", Empresa.EM_ID)
            codigo_tmp = codigo_tmp.PadLeft(5, "0")
            Return codigo_tmp
        End Function

        Public Function get_Personal_x_Cargo(idcargo_ As Integer, empresa_ As Integer) As DataTable
            Return SqlHelper.ExecuteDataset(Cn, "SG_PL_SP_S_EMPLE_X_CARGO", idcargo_, empresa_).Tables(0)
        End Function
    End Class


End Class
