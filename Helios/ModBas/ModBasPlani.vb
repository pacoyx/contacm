

Module ModBasPlani

    Public Sub Liquida_Fin_de_Mes(ByVal personalBE As BE.PlanillaBE.SG_PL_TB_PERSONAL, ByVal fecha_periodo_ As Date, ByVal check_3erPiso_ As Boolean, dt_Folio_Mes_ As DataTable, ByVal check_Tardanzas_ As Boolean)

        'varibales generales del calculo
        Dim dbl_Vdolar As Double = 0
        Dim int_Num_Vacaciones As Integer = 0
        Dim int_Num_Licencias_SinGoce As Integer = 0
        Dim int_Num_Licencias_ConnGoce As Integer = 0

        Dim int_Num_Subsidios As Integer = 0
        Dim int_Num_Faltas As Integer = 0
        Dim dat_fecha_periodo As Date = fecha_periodo_
        Dim Bol_Grabar_Histo As Boolean = True
        Dim nhoras As String = String.Empty
        Dim nvalorhora As Double = 0
        Dim General As Boolean = True
        Dim Dbl_Tot_Ingreso As Double = 0
        Dim Dbl_Tot_Ing_afecto_afp As Double = 0
        Dim DblTransporte As Double = 0
        Dim Dbl_TopeMensual As Double = 0
        Dim Dbl_Segur As Double = 0
        Dim Dbl_ComiF As Double = 0
        Dim Dbl_ComiV As Double = 0
        Dim Dbl_ComiV2 As Double = 0
        Dim empresaBE As New BE.ContabilidadBE.SG_CO_TB_EMPRESA With {.EM_ID = gInt_IdEmpresa}
        Dim dt_afp As DataTable = Nothing
        Dim Dbl_montoSubsidio As Double = 0
        Dim Dbl_montoLicencia_ConGoce As Double = 0
        Dim Dbl_desctQuinta As Double = 0
        Dim bol_entroFolio As Boolean = False


        'cargamos el tope mensual
        Dbl_TopeMensual = Obtener_Tope_Mensual(empresaBE, dat_fecha_periodo)

        'cargamos tabla AFP
        dt_afp = Obtener_Tabla_AFP(empresaBE)



        Dim folioBL As New BL.PlanillaBL.SG_PL_TB_FOLIO
        Dim folioBE As New BE.PlanillaBE.SG_PL_TB_FOLIO



        'Buscamos sus vaciones,licencias,subsidios
        Call Obtener_Num_Suspensiones(personalBE.PE_ID, int_Num_Vacaciones, int_Num_Licencias_SinGoce, int_Num_Subsidios, int_Num_Faltas, dat_fecha_periodo, int_Num_Licencias_ConnGoce)

        'se limpia la tabla de historial 
        Call Borrar_Historial_Personal(personalBE, empresaBE, dat_fecha_periodo)

        'se revisa que no este cesado5
        If personalBE.PE_FEC_CESE.ToString <> String.Empty Then
            Exit Sub
        End If


        'se trae los conceptos por personal
        Dim perConceptoBL As New BL.PlanillaBL.SG_PL_TB_PERSONAL_CONCEPTO
        Dim dt_personalConcepto As DataTable = perConceptoBL.get_Conceptos(personalBE)
        perConceptoBL = Nothing

        'se listan los folios(conceptos)
        Dim conceptosBL As New BL.PlanillaBL.SG_PL_TB_CONCEPTOS
        Dim Lis_Conceptos As List(Of BE.PlanillaBE.SG_PL_TB_CONCEPTOS)
        Lis_Conceptos = conceptosBL.get_Conceptos_Matriz(empresaBE)




        Dbl_Tot_Ingreso = 0
        Dbl_montoSubsidio = 0




        'AQUI calculamos las horas registradas por la coordinadora asistencial(3er piso)
        'calculamos,registramos en la boleta y devuelve el total para sumarlo a la variable "Dbl_Tot_Ingreso"
        Dim bol_calculo_PET As Boolean = False

        If check_3erPiso_ Then

            Dim importe_salida As Double = 0

            '1=empleados
            '2=horas
            If personalBE.PE_ID_TIPO_PER = 2 Then

                importe_salida = 0

                'OJO PARA EL CASO DEL PERSONAL DE "SALA DE BEBES" TODAS SON PERSONAL POR HORAS (J)

                'si el valor es nothing es por que no es ni tecnica ni enfermera
                If personalBE.PE_ID_TIPO_PERSO_TARIFA Is Nothing Then
                    Call Calcular_y_Registrar_Horas_Normal(dat_fecha_periodo, personalBE, importe_salida)
                Else
                    Call Calcular_y_Registrar_Horas_TecnicasEnfermeras(personalBE.PE_ID, personalBE.PE_ID_TIPO_PERSO_TARIFA.TT_ID, importe_salida, dat_fecha_periodo)
                End If

                Dbl_Tot_Ingreso = Dbl_Tot_Ingreso + importe_salida
                Dbl_Tot_Ing_afecto_afp += importe_salida

                If importe_salida > 0 Then bol_calculo_PET = True

            Else 'Empleados




                'si es de Hospitalizacion buscamos si tiene horas extras(simples y dobles)
                'el area 10 es hospitalizacion, no hay que cambiar ese codigo y/o parametrizar ese dato

                If personalBE.PE_ID_AREA = 10 Then
                    importe_salida = 0
                    Call Horas_Extras_Personal_Hospi(personalBE, dat_fecha_periodo.Year, dat_fecha_periodo.Month, gInt_IdEmpresa, dat_fecha_periodo.ToShortDateString, importe_salida)
                    Dbl_Tot_Ingreso += importe_salida
                    Dbl_Tot_Ing_afecto_afp += importe_salida
                End If

            End If

            'Calculamos los Refrigerios
            importe_salida = 0
            Call Calcular_Refrigerios(personalBE, importe_salida, dat_fecha_periodo)
            Dbl_Tot_Ingreso += importe_salida
            Dbl_Tot_Ing_afecto_afp += importe_salida



        End If
        '......................._____________________________________________________________________________


        'aqui debemos calcular las horas de tardanzas del personal
        Dim bol_calculo_tardanza As Boolean = False
        Dim salida_Tardanzas As Double = 0

        If check_Tardanzas_ And (gInt_IdEmpresa = 1 Or gInt_IdEmpresa = 7) Then

            'buscamos si tiene info en folios
            folioBE.FO_ANHO = dat_fecha_periodo.Year
            folioBE.FO_MES = dat_fecha_periodo.Month
            folioBE.FO_ID_CONCEPTO = New BE.PlanillaBE.SG_PL_TB_CONCEPTOS With {.CO_ID = "200"}
            folioBE.FO_ID_PERSONA = personalBE
            folioBE.FO_ID_EMPRESA = empresaBE


            If Not folioBL.Tiene_Folio_Registrado(folioBE) Then
                Call Calcular_Horas_Tardanzas(personalBE, salida_Tardanzas, dat_fecha_periodo)
                If salida_Tardanzas > 0 Then bol_calculo_tardanza = True
            End If
        End If



        '......................._____________________________________________________________________________






        'aqui debemos calcular los PRESTAMOS que tiene el personal descontarlos.
        'Para esto se usara el folio 215 en duro, se debera crear una parametrizacion para esto.
        Dim bol_Desconto_Prestamos As Boolean = False
        Dim dbl_importe_prestamo As Double = 0

        folioBE.FO_ANHO = dat_fecha_periodo.Year
        folioBE.FO_MES = dat_fecha_periodo.Month
        folioBE.FO_ID_PERSONA = personalBE
        folioBE.FO_ID_EMPRESA = empresaBE
        folioBE.FO_ID_CONCEPTO = New BE.PlanillaBE.SG_PL_TB_CONCEPTOS With {.CO_ID = "215"}

        If Not folioBL.Tiene_Folio_Registrado(folioBE) Then
            Call Calcular_Prestamos_Personal(personalBE, dat_fecha_periodo.Year, dat_fecha_periodo.Month, dbl_importe_prestamo)
            If dbl_importe_prestamo > 0 Then bol_Desconto_Prestamos = True
        End If
        '......................._____________________________________________________________________________






        Dim dbl_monto_grati As Double = 0
        nvalorhora = personalBE.PE_HORAS_TRABAJO

        For Each conceptoBE As BE.PlanillaBE.SG_PL_TB_CONCEPTOS In Lis_Conceptos

            Dim dbl_monto As Double = 0
            Dim valor_tmp As Double = 0
            Dim str_desConcepto As String = conceptoBE.CO_DESCRIPCION
            Dim Int_Tipo As Integer = conceptoBE.CO_ID_TIPO.TC_ID
            General = True
            Bol_Grabar_Histo = False
            bol_entroFolio = False
            nhoras = String.Empty

            If conceptoBE.CO_ID = "123" Then
                Avisar(conceptoBE.CO_ID)
            End If

            valor_tmp = conceptoBE.CO_VALOR
            If conceptoBE.CO_ID_ALCANCE.AC_ID = 2 Then '1=General;  2=Particular
                General = False
            End If


            Dim fila_tmp As DataRow()
            fila_tmp = dt_Folio_Mes_.Select("fo_id_concepto = '" & conceptoBE.CO_ID & "' and fo_id_persona = " & personalBE.PE_ID)

            If fila_tmp.Length = 0 Then
                '__por valor de "concepto"
                If Int_Tipo = 1 Then 'porcentaje
                    dbl_monto = (valor_tmp * IIf(personalBE.PE_ID_MONEDA_REMU = 2, (Dbl_Tot_Ing_afecto_afp - Dbl_montoSubsidio) * dbl_Vdolar, (Dbl_Tot_Ing_afecto_afp - Dbl_montoSubsidio))) / 100
                Else
                    dbl_monto = valor_tmp * IIf(personalBE.PE_ID_MONEDA_REMU = 2, dbl_Vdolar, 1)
                End If

                dbl_monto = Math.Round(dbl_monto, 2)

                If dbl_monto > 0 Then
                    'General = True
                    str_desConcepto = conceptoBE.CO_DESCRIPCION & " " & IIf(Int_Tipo = 1, IIf(valor_tmp <> 0, Format(valor_tmp, "#.00") & "%", 0), "")
                    GoTo comienza_general
                End If

            End If
            fila_tmp = Nothing




            '__por valor "Concepto x Personal"
            valor_tmp = 0

            Dim fila() As DataRow
            fila = dt_personalConcepto.Select("PC_ID_PERSONAL = " & personalBE.PE_ID & " and PC_ID_CONCEPTO = " & conceptoBE.CO_ID & " and PC_ID_EMPRESA = " & personalBE.PE_ID_EMPRESA)

            If fila.Length > 0 Then
                valor_tmp = fila(0).Item("PC_VALOR")
            Else
                valor_tmp = 0
            End If


            If Int_Tipo = 1 Then 'porcentaje
                dbl_monto = (valor_tmp * IIf(personalBE.PE_ID_MONEDA_REMU = 2, valor_tmp * dbl_Vdolar, valor_tmp)) / 100
                str_desConcepto = conceptoBE.CO_DESCRIPCION & " " & IIf(Int_Tipo = 1, IIf(valor_tmp <> 0, Format(valor_tmp, "#.00") & "%", 0), "")
            Else
                dbl_monto = CDbl(valor_tmp) * IIf(personalBE.PE_ID_MONEDA_REMU = 2, dbl_Vdolar, 1)
            End If

            If dbl_monto > 0 Then
                General = True
                GoTo comienza_general
            End If




            '__por valor del "Folio"
            valor_tmp = 0
            bol_entroFolio = False


            fila_tmp = dt_Folio_Mes_.Select("fo_id_concepto = '" & conceptoBE.CO_ID & "' and fo_id_persona = " & personalBE.PE_ID)

            If fila_tmp.Length > 0 Then
                valor_tmp = fila_tmp(0)("FO_VALOR")
                bol_entroFolio = True
                General = True
                If valor_tmp = 0 Then General = False
                If Int_Tipo = 1 Then 'porcentaje
                    'dbl_monto = (valor_tmp * IIf(personalBE.PE_ID_MONEDA_REMU = 2, personalBE.PE_IMPORTE_REMUNERACION * dbl_Vdolar, personalBE.PE_IMPORTE_REMUNERACION)) / 100
                    'str_desConcepto = conceptoBE.CO_DESCRIPCION & " " & IIf(Int_Tipo = 1, IIf(valor_tmp <> 0, Format(valor_tmp, "#.00") & "%", 0), "")
                    dbl_monto = CDbl(valor_tmp) * IIf(personalBE.PE_ID_MONEDA_REMU = 2, dbl_Vdolar, 1)
                Else
                    dbl_monto = CDbl(valor_tmp) * IIf(personalBE.PE_ID_MONEDA_REMU = 2, dbl_Vdolar, 1)
                End If
                If dbl_monto = 0 Then General = False


                'con este select case lo obligo a pasar por "General" para procesar otros calculos
                'esto funciona con la opcioon de la ventana "plantilla codigo", donde configuramos que conceptos
                'van a pasar por el case de "General"
                Select Case conceptoBE.CO_ID_INTERNO
                    Case "123"
                        General = True
                End Select

            End If

comienza_general:


            'str_desConcepto = conceptoBE.CO_DESCRIPCION & " " & IIf(Int_Tipo = 1, IIf(valor_tmp = 0, Format(valor_tmp, "#.00"), 0), "") 
            Dim npromediohorasextras As Double = 0


            If General Then
                Select Case conceptoBE.CO_ID_INTERNO

                    Case 1 '101	Remuner.  Ordinaria

                        If Not bol_entroFolio Then
                            dbl_monto = personalBE.PE_IMPORTE_REMUNERACION
                        End If


                        'dbl_monto = dbl_monto * ((30 - (int_Num_Licencias + int_Num_Subsidios)) / 30)

                        Dim monto_tmp As Double = 0
                        If int_Num_Vacaciones <> 0 Then
                            npromediohorasextras = npromediohorasextras * dbl_monto / IIf(dat_fecha_periodo.Month = 2, 29, 30)
                            monto_tmp = dbl_monto * int_Num_Vacaciones / IIf(dat_fecha_periodo.Month = 2, 29, 30) + npromediohorasextras
                            Dim concepto_auxi As String = conceptoBE.CO_ID
                            conceptoBE.CO_ID = "126"

                            Call Grabar_en_Historial(personalBE, conceptoBE, empresaBE, dat_fecha_periodo.Month, dat_fecha_periodo, monto_tmp, conceptoBE.CO_ID_IDENTIFICADOR.ID_ID, 1, _
                                                     "Vacaciones (" + Str(int_Num_Vacaciones) + " dias)", 0, 0, 0, int_Num_Vacaciones)

                            conceptoBE.CO_ID = concepto_auxi

                            If conceptoBE.CO_ID_IDENTIFICADOR.ID_ID = 1 Then ' 1 = ingresos
                                Dbl_Tot_Ingreso += monto_tmp
                            End If

                            If conceptoBE.CO_NO_AFECT_AFP = 0 Then
                                Dbl_Tot_Ing_afecto_afp += monto_tmp
                            End If

                        End If

                        If int_Num_Subsidios <> 0 Then
                            'en feb se le suma 2 al num de subsidios
                            'si e sfeb viciesto se le suma 1

                            conceptoBE.CO_ID = "106"
                            Dbl_montoSubsidio = (dbl_monto * IIf(dat_fecha_periodo.Month = 2, int_Num_Subsidios + 1, int_Num_Subsidios) / 30) + npromediohorasextras
                            npromediohorasextras = npromediohorasextras * dbl_monto / 30
                            monto_tmp = dbl_monto * IIf(dat_fecha_periodo.Month = 2, int_Num_Subsidios + 1, int_Num_Subsidios) / 30 + npromediohorasextras
                            Call Grabar_en_Historial(personalBE, conceptoBE, empresaBE, dat_fecha_periodo.Month, dat_fecha_periodo, monto_tmp, conceptoBE.CO_ID_IDENTIFICADOR.ID_ID, 1, _
                                                     "Subsidio (" + Str(int_Num_Subsidios) + " dias)", 0, 0, 0, int_Num_Subsidios)

                            If conceptoBE.CO_ID_IDENTIFICADOR.ID_ID = 1 Then ' 1 = ingresos
                                Dbl_Tot_Ingreso += Dbl_montoSubsidio
                            End If

                            If conceptoBE.CO_NO_AFECT_AFP = 0 Then
                                Dbl_Tot_Ing_afecto_afp += Dbl_montoSubsidio
                            End If

                        End If

                        If int_Num_Licencias_ConnGoce <> 0 Then
                            conceptoBE.CO_ID = "132"
                            Dbl_montoLicencia_ConGoce = (dbl_monto * int_Num_Licencias_ConnGoce / 30) + npromediohorasextras
                            npromediohorasextras = npromediohorasextras * dbl_monto / 30

                            ' monto_tmp = dbl_monto * int_Num_Licencias_ConnGoce / 30 + npromediohorasextras
                            monto_tmp = dbl_monto * IIf(dat_fecha_periodo.Month = 2, int_Num_Licencias_ConnGoce + 1, int_Num_Licencias_ConnGoce) / 30 + npromediohorasextras


                            Call Grabar_en_Historial(personalBE, conceptoBE, empresaBE, dat_fecha_periodo.Month, dat_fecha_periodo, _
                                                     monto_tmp, conceptoBE.CO_ID_IDENTIFICADOR.ID_ID, 1, _
                                                     "Lic. con Goce de Haber (" + Str(int_Num_Licencias_ConnGoce) + " dias)", 0, 0, 0, int_Num_Licencias_ConnGoce)

                            If conceptoBE.CO_ID_IDENTIFICADOR.ID_ID = 1 Then ' 1 = ingresos
                                Dbl_Tot_Ingreso += Dbl_montoLicencia_ConGoce
                            End If

                            If conceptoBE.CO_NO_AFECT_AFP = 0 Then
                                Dbl_Tot_Ing_afecto_afp += Dbl_montoLicencia_ConGoce
                            End If

                        End If




                        Dim tot_dias As Integer
                        Dim dias_Trabajo As Integer
                        Dim fecha_tmp As Date = Now


                        fecha_tmp = CDate(IIf(fecha_periodo_.Month = 2, "29", "30") & "/" & fecha_periodo_.Month.ToString.PadLeft(2, "0") & "/" & fecha_periodo_.Year.ToString)

                        If CDate(personalBE.PE_FEC_ING).Year = fecha_periodo_.Year And CDate(personalBE.PE_FEC_ING).Month = fecha_periodo_.Month Then
                            dias_Trabajo = DateDiff(DateInterval.Day, CDate(personalBE.PE_FEC_ING), fecha_tmp) + 1
                        Else
                            If fecha_periodo_.Month = 2 Then
                                dias_Trabajo = 29
                            Else
                                dias_Trabajo = 30
                            End If

                        End If

                        'tot_dias = 30 - int_Num_Vacaciones - int_Num_Licencias_SinGoce - int_Num_Subsidios - int_Num_Faltas - int_Num_Licencias_ConnGoce

                        If int_Num_Subsidios > 0 Then
                            tot_dias = dias_Trabajo - int_Num_Vacaciones - int_Num_Licencias_SinGoce - IIf(dat_fecha_periodo.Month = 2, int_Num_Subsidios + 1, int_Num_Subsidios) - int_Num_Faltas - int_Num_Licencias_ConnGoce
                        Else
                            tot_dias = dias_Trabajo - int_Num_Vacaciones - int_Num_Licencias_SinGoce - int_Num_Subsidios - int_Num_Faltas - int_Num_Licencias_ConnGoce
                        End If



                        If tot_dias > 0 Then

                            'dbl_monto = dbl_monto * (30 - int_Num_Vacaciones - int_Num_Licencias_SinGoce - int_Num_Subsidios - int_Num_Faltas) / 30
                            If dat_fecha_periodo.Month = 2 Then
                                dbl_monto = dbl_monto * (dias_Trabajo - int_Num_Vacaciones - int_Num_Licencias_SinGoce - int_Num_Subsidios - int_Num_Faltas - int_Num_Licencias_ConnGoce) / 29

                                If tot_dias = 29 Then
                                    str_desConcepto = conceptoBE.CO_DESCRIPCION
                                Else
                                    str_desConcepto = conceptoBE.CO_DESCRIPCION & "(" & Str(tot_dias) & " dias)"
                                End If
                            Else

                                dbl_monto = dbl_monto * (dias_Trabajo - int_Num_Vacaciones - int_Num_Licencias_SinGoce - int_Num_Subsidios - int_Num_Faltas - int_Num_Licencias_ConnGoce) / 30

                                If tot_dias = 30 Then
                                    str_desConcepto = conceptoBE.CO_DESCRIPCION
                                Else
                                    str_desConcepto = conceptoBE.CO_DESCRIPCION & "(" & Str(tot_dias) & " dias)"
                                End If

                            End If





                            If dbl_monto > 0 Then
                                conceptoBE.CO_ID = "101"
                                Call Grabar_en_Historial(personalBE, conceptoBE, empresaBE, dat_fecha_periodo.Month, _
                                                         dat_fecha_periodo, dbl_monto, conceptoBE.CO_ID_IDENTIFICADOR.ID_ID, 1, str_desConcepto, tot_dias, 0, 0, 0)
                            End If

                            If conceptoBE.CO_ID_IDENTIFICADOR.ID_ID = 1 Then ' 1 = ingresos
                                Dbl_Tot_Ingreso += dbl_monto
                            End If

                            If conceptoBE.CO_NO_AFECT_AFP = 0 Then
                                Dbl_Tot_Ing_afecto_afp += dbl_monto
                            End If

                            Bol_Grabar_Histo = False
                        End If



                    Case 2 '102 'Asig. Familiar
                        Bol_Grabar_Histo = False
                        If dbl_monto > 0 Then
                            If personalBE.PE_ASIGNACION_FAM = 0 Then ' no tiene hijos
                                dbl_monto = 0
                                Bol_Grabar_Histo = False
                            Else
                                dbl_monto = valor_tmp
                                Bol_Grabar_Histo = True
                            End If
                        Else
                            If Int_Tipo = 1 Then 'porcentaje
                                dbl_monto = (conceptoBE.CO_VALOR * personalBE.PE_IMPORTE_REMUNERACION) / 100
                            Else
                                dbl_monto = conceptoBE.CO_VALOR
                            End If
                            If dbl_monto > 0 Then Bol_Grabar_Histo = True

                        End If


                    Case 11 '111 Horas Extras 1.25
                        'nhoras = dbl_monto

                        '1=Empleados;2=Horas
                        'If personalBE.PE_ID_TIPO_PER = 2 Then
                        '    dbl_monto = 1.25 * nvalorhora * Val(dbl_monto) * IIf(int_Num_Subsidios + int_Num_Licencias_SinGoce + int_Num_Faltas = 0, 1, (30 / (30 - int_Num_Subsidios - int_Num_Licencias_SinGoce - int_Num_Faltas)))
                        'Else
                        '    '1 = Administrativo
                        '    '2 = Asistencial
                        '    If personalBE.PE_ID_PERSONAL = 1 Then
                        '        dbl_monto = 1.25 * Val(personalBE.PE_IMPORTE_REMUNERACION) / 240 * Val(dbl_monto)
                        '    Else
                        '        dbl_monto = 1.25 * Val(personalBE.PE_IMPORTE_REMUNERACION) / 180 * Val(dbl_monto)
                        '    End If
                        'End If

                        If dbl_monto > 0 Then Bol_Grabar_Histo = True


                    Case 12 '"113" 'Horas Extras 1.35

                        nhoras = dbl_monto
                        If personalBE.PE_ID_TIPO_PER = 2 Then
                            dbl_monto = 1.35 * nvalorhora * Val(dbl_monto) * IIf(int_Num_Subsidios + int_Num_Licencias_SinGoce + int_Num_Faltas = 0, 1, (30 / (30 - int_Num_Subsidios - int_Num_Licencias_SinGoce - int_Num_Faltas)))
                        Else
                            'cambiamos la variable 'nMontomes' por 'Dbl_RemuOrdinario' para este calculo
                            'nmonto = 1.35 * Val(nMontomes) / 240 * Val(nmonto) '* IIf(nSUBSIDIO + nLICENCIA = 0, 1, (30 / (30 - nSUBSIDIO - nLICENCIA)))

                            '1 = Administrativo
                            '2 = Asistencial
                            If personalBE.PE_ID_PERSONAL = 1 Then
                                dbl_monto = Math.Round(1.35 * Val(personalBE.PE_IMPORTE_REMUNERACION) / 240 * Val(dbl_monto), 3)
                            Else 'Asistencial
                                dbl_monto = Math.Round(1.35 * Val(personalBE.PE_IMPORTE_REMUNERACION) / 180 * Val(dbl_monto), 3)
                            End If
                        End If

                        If dbl_monto > 0 Then Bol_Grabar_Histo = True


                    Case 13 '"114" 'Horas Extras 2

                        nhoras = dbl_monto


                        ' 1 = Empleados
                        ' 2 = Horas
                        If personalBE.PE_ID_TIPO_PER = 2 Then
                            dbl_monto = 2 * nvalorhora * Val(dbl_monto)
                        Else

                            '1 = Administrativo
                            '2 = Asistencial
                            If personalBE.PE_ID_PERSONAL = 1 Then
                                dbl_monto = 2 * Val(personalBE.PE_IMPORTE_REMUNERACION) / 240 * Val(dbl_monto)
                            Else 'Asistencial
                                dbl_monto = 2 * Val(personalBE.PE_IMPORTE_REMUNERACION) / 180 * Val(dbl_monto)
                            End If
                        End If


                        If dbl_monto > 0 Then Bol_Grabar_Histo = True




                    Case 15 ' "116" 'Gratificación


                        If dbl_monto > 0 Then
                            dbl_monto_grati = dbl_monto
                            Bol_Grabar_Histo = True
                        End If


                    Case 18 ' "119" 'Remuner. x Horas 119
                        'este concepto sera reemplazdo por 119-cuna/normal
                        nhoras = dbl_monto
                        dbl_monto = nvalorhora * dbl_monto 'Cambio JLKB
                        If dbl_monto > 0 Then Bol_Grabar_Histo = True

                    Case 20 '"121" 'Bon. Extr. Ley 29351 9%, ahora la ley es la 30334  

                        If dbl_monto_grati > 0 Then

                            'si esta afiliado a EPS el porcentaje es menos
                            If personalBE.PE_AFILIADO_EPS_SER_PRO = 1 Then
                                dbl_monto = Math.Round(6.75 * dbl_monto_grati / 100, 2)
                            Else
                                dbl_monto = Math.Round(conceptoBE.CO_VALOR * dbl_monto_grati / 100, 2)
                            End If


                            If dbl_monto < 67.5 And dbl_monto > 0 And Dbl_montoSubsidio = 0 Then
                                'nmonto = 60.75
                                dbl_monto = 67.5
                            End If

                            If dbl_monto > 0 Then Bol_Grabar_Histo = True
                        End If

                    Case 22 ' '123 ; valor de transporte

                        If dbl_monto > 0 Then

                            Dim dias_Trabajo As Integer
                            Dim fecha_tmp As Date = Now

                            fecha_tmp = CDate(IIf(fecha_periodo_.Month = 2, "29", "30") & "/" & fecha_periodo_.Month.ToString.PadLeft(2, "0") & "/" & fecha_periodo_.Year.ToString)

                            If CDate(personalBE.PE_FEC_ING).Year = fecha_periodo_.Year And CDate(personalBE.PE_FEC_ING).Month = fecha_periodo_.Month Then
                                dias_Trabajo = DateDiff(DateInterval.Day, CDate(personalBE.PE_FEC_ING), fecha_tmp) + 1
                            Else
                                'dias_Trabajo = 30
                                dias_Trabajo = IIf(fecha_periodo_.Month = 2, 29, 30)
                            End If


                            If int_Num_Faltas > 0 Or int_Num_Licencias_SinGoce > 0 Or int_Num_Licencias_ConnGoce > 0 Or dias_Trabajo <> 30 Or int_Num_Subsidios > 0 Then
                                Dim totalDias As Integer = IIf(fecha_periodo_.Month = 2, 30, 30)
                                Dim Valor_por_dia As Double = dbl_monto / totalDias
                                Dim num_dias_restar As Integer = (totalDias - dias_Trabajo) + (int_Num_Faltas + int_Num_Licencias_SinGoce + int_Num_Licencias_ConnGoce + int_Num_Subsidios)
                                Dim valor_descto As Double = num_dias_restar * Valor_por_dia

                                dbl_monto = Math.Round(dbl_monto - valor_descto, 2)
                                str_desConcepto = conceptoBE.CO_DESCRIPCION & "(" & Str(dias_Trabajo - (int_Num_Faltas + int_Num_Licencias_SinGoce + int_Num_Licencias_ConnGoce)) & " dias)"

                            End If

                            If dbl_monto > 0 Then
                                Bol_Grabar_Histo = True
                            End If

                        End If

                    Case 29 ' "200" 'Faltas y Tardanzas

                        If Not bol_calculo_tardanza Then
                            '1 = Empleados
                            '2 = Horas
                            If personalBE.PE_ID_TIPO_PER = 2 Then
                                dbl_monto = nvalorhora * dbl_monto
                            Else
                                Select Case personalBE.PE_ID_PERSONAL
                                    Case 1 '1 = administrativo
                                        nhoras = dbl_monto
                                        DblTransporte = DblTransporte / 240 * Val(dbl_monto)
                                        dbl_monto = (Val(personalBE.PE_IMPORTE_REMUNERACION) / 240 * Val(dbl_monto)) + DblTransporte
                                    Case 2 '2 = asistencial
                                        nhoras = dbl_monto
                                        DblTransporte = DblTransporte / 150 * Val(dbl_monto)
                                        dbl_monto = (Val(personalBE.PE_IMPORTE_REMUNERACION) / 150 * Val(dbl_monto)) + DblTransporte
                                End Select
                            End If
                            If dbl_monto > 0 Then Bol_Grabar_Histo = True
                        End If

                    Case 31 '"202" 'Sist. Nac. Pensiones

                        If personalBE.PE_ID_AFP > 0 Then
                            Dim dr_fila() As DataRow
                            dr_fila = dt_afp.Select("AF_ID = " & personalBE.PE_ID_AFP)
                            If dr_fila.Length > 0 Then
                                Dbl_Segur = dr_fila(0).Item("AF_SEGURO")
                                Dbl_ComiF = dr_fila(0).Item("AF_COMISION_FIJA")
                                Dbl_ComiV = dr_fila(0).Item("AF_COMISION_VAR")
                                Dbl_ComiV2 = dr_fila(0).Item("AF_COMISION_VAR2")
                            End If
                            dr_fila = Nothing

                            Bol_Grabar_Histo = False
                        Else

                            If dbl_monto > 0 Then Bol_Grabar_Histo = True
                        End If

                    Case 32 '"204" '5ta. Categoria

                        If Not bol_entroFolio Then

                            If personalBE.PE_AFECTO_QUINTA = 1 Then
                                Dim quintaBL As New BL.PlanillaBL.Calculos
                                Dim dbl_imp_qinta As Double = quintaBL.get_Dsto_5taCat(personalBE, dat_fecha_periodo.Year, dat_fecha_periodo.Month)

                                If dbl_imp_qinta > 0 Then
                                    dbl_monto = dbl_imp_qinta
                                End If

                                quintaBL = Nothing

                                If dbl_monto > 0 Then Bol_Grabar_Histo = True
                            End If
                        Else
                            Bol_Grabar_Histo = True
                        End If


                    Case 34 '"206" 'AFP Jubilación 206
                        'Si el empleado esta registrado a una AFP se graba el monto en el historial
                        'si no esta registrado no se graba en el historial

                        Dim valorFolio As Double = 0


                        If personalBE.PE_ID_AFP > 0 And personalBE.PE_DISCAPACIDAD = 0 Then

                            If pl_TieneValor_de_Folio(personalBE.PE_ID, "206", valorFolio, dat_fecha_periodo) Then
                                dbl_monto = Dbl_Tot_Ing_afecto_afp * (valorFolio / 100)
                            Else
                                dbl_monto = Dbl_Tot_Ing_afecto_afp * (conceptoBE.CO_VALOR / 100)
                            End If

                            If dbl_monto > 0 Then Bol_Grabar_Histo = True

                        End If


                    Case 35 '"208" 'Sobrev. Sep.


                        Dim edad As Integer = 0
                        edad = DateDiff(DateInterval.Year, CDate(personalBE.PE_FEC_NAC), dat_fecha_periodo)


                        If personalBE.PE_ID_AFP > 0 And personalBE.PE_DISCAPACIDAD = 0 And edad < 65 Then

                            '1=porcentaje
                            '2=cantidad
                            If conceptoBE.CO_ID_TIPO.TC_ID = 1 Then
                                If Dbl_TopeMensual <> 0 Then
                                    If Dbl_TopeMensual > Val(Dbl_Tot_Ing_afecto_afp) - Dbl_desctQuinta Then
                                        dbl_monto = Math.Round(Val(Dbl_Segur) * (Val(Dbl_Tot_Ing_afecto_afp)) / 100, 2)
                                    Else
                                        dbl_monto = Math.Round(Val(Dbl_Segur) * Val(Dbl_TopeMensual) / 100, 2)
                                    End If
                                Else
                                    dbl_monto = Math.Round(Val(Dbl_Segur) * (Val(Val(Dbl_Tot_Ing_afecto_afp))) / 100, 2)
                                End If

                                If Int_Tipo = 1 Then 'porcentaje
                                    str_desConcepto = conceptoBE.CO_DESCRIPCION & " " & IIf(Int_Tipo = 1, IIf(dbl_monto <> 0, Format(Dbl_Segur, "#.00") & "%", 0), "")
                                End If

                            End If
                        End If


                        If dbl_monto > 0 Then Bol_Grabar_Histo = True


                    Case 36 ' "209" 'Com. Porc./Rem A.

                        If personalBE.PE_ID_AFP > 0 And personalBE.PE_DISCAPACIDAD = 0 Then
                            'If Not entrfolio Then
                            If conceptoBE.CO_ID_TIPO.TC_ID = 1 Then
                                If personalBE.PE_IDCOMISION = 1 Then '1=flujo;2=mmixta
                                    dbl_monto = Math.Round(Val(Dbl_ComiV) * ((Val(Dbl_Tot_Ing_afecto_afp)) - Dbl_desctQuinta) / 100, 2)
                                Else
                                    dbl_monto = Math.Round(Val(Dbl_ComiV2) * ((Val(Dbl_Tot_Ing_afecto_afp)) - Dbl_desctQuinta) / 100, 2)
                                End If

                            End If
                            'End If

                            If Int_Tipo = 1 Then 'porcentaje
                                If personalBE.PE_IDCOMISION = 1 Then '1=flujo;2=mmixta
                                    str_desConcepto = conceptoBE.CO_DESCRIPCION & " " & IIf(Int_Tipo = 1, IIf(dbl_monto <> 0, Format(Dbl_ComiV, "#.00") & "%", 0), "")
                                Else
                                    str_desConcepto = conceptoBE.CO_DESCRIPCION & " " & IIf(Int_Tipo = 1, IIf(dbl_monto <> 0, Format(Dbl_ComiV2, "#.00") & "%", 0), "")
                                End If

                            End If

                        End If

                        If dbl_monto > 0 Then Bol_Grabar_Histo = True


                    Case 37 '"210" 'Comisión Fija
                        If personalBE.PE_ID_AFP > 0 Then
                            'If Not entrfolio Then
                            dbl_monto = Val(Dbl_ComiF)
                            'End If
                        End If

                        If dbl_monto > 0 Then Bol_Grabar_Histo = True


                    Case 40 '"215" 'Préstamos al persona

                        If dbl_monto = 0 Then
                            If dbl_importe_prestamo > 0 And bol_Desconto_Prestamos Then
                                dbl_monto = dbl_importe_prestamo


                                Dim cronoBL As New BL.PlanillaBL.SG_PL_TB_CTA_CTE_CRONOGRAMA
                                cronoBL.Update_estado_registro(personalBE.PE_ID, dat_fecha_periodo.Year, _
                                                               dat_fecha_periodo.Month)
                                cronoBL = Nothing

                            End If
                        Else
                            If dbl_monto > 0 Then Bol_Grabar_Histo = True
                        End If


                    Case 53 '"301" 'EsSalud

                        If dbl_monto < 67.5 And dbl_monto > 0 And Dbl_montoSubsidio = 0 Then

                            dbl_monto = 67.5


                        End If

                        If dbl_monto > 0 Then Bol_Grabar_Histo = True

                    Case Else
                        If dbl_monto > 0 Then Bol_Grabar_Histo = True
                End Select

            End If 'if de particular


            If Bol_Grabar_Histo Then

                Call Grabar_en_Historial(personalBE, conceptoBE, empresaBE, _
                                         dat_fecha_periodo.Month, dat_fecha_periodo, _
                                         dbl_monto, conceptoBE.CO_ID_IDENTIFICADOR.ID_ID, 1, _
                                         str_desConcepto & " " & IIf(nhoras = "" Or nhoras = "0", "", "(" + Trim(nhoras) + "h)"), _
                                         Val(nhoras), 0, 0, 0)

                If conceptoBE.CO_ID_IDENTIFICADOR.ID_ID = 1 Then ' 1 = ingresos
                    'aqui hay que validar si esta afecto a afp entre otras cosas

                    Dbl_Tot_Ingreso += dbl_monto

                    If conceptoBE.CO_NO_AFECT_AFP = 0 Then
                        Dbl_Tot_Ing_afecto_afp += dbl_monto
                    End If


                End If

            End If



        Next 'next de conceptos

    End Sub

    Private Sub Horas_Extras_Personal_Hospi(personalBE_ As BE.PlanillaBE.SG_PL_TB_PERSONAL, ayo_ As Integer, mes_ As Integer, empresa_ As Integer, fechaPeriodo_ As String, ByRef importe_salida As Double)

        Dim _historialBL As New BL.PlanillaBL.SG_PL_TB_PERSONAL_HORAS_CAB
        Dim _hora_Ext_sim As Double = 0
        Dim _hora_Ext_dob As Double = 0
        Dim dbl_monto As Double = 0
        Dim empresaBE As New BE.ContabilidadBE.SG_CO_TB_EMPRESA With {.EM_ID = gInt_IdEmpresa}
        Dim conceptoBE As New BE.PlanillaBE.SG_PL_TB_CONCEPTOS With {.CO_ID = "113"}
        conceptoBE.CO_ID_IDENTIFICADOR = New BE.PlanillaBE.SG_PL_TB_IDENTIFICADOR With {.ID_ID = 1}



        'buscamos si tiene info en folios
        Dim folioBE As New BE.PlanillaBE.SG_PL_TB_FOLIO
        Dim folioBL As New BL.PlanillaBL.SG_PL_TB_FOLIO

        folioBE.FO_ANHO = ayo_
        folioBE.FO_MES = mes_
        folioBE.FO_ID_CONCEPTO = New BE.PlanillaBE.SG_PL_TB_CONCEPTOS With {.CO_ID = "113"}
        folioBE.FO_ID_PERSONA = personalBE_
        folioBE.FO_ID_EMPRESA = empresaBE


        If Not folioBL.Tiene_Folio_Registrado(folioBE) Then
            _historialBL.Horas_Extras_Personal_Hospi(personalBE_, ayo_, mes_, empresa_, _hora_Ext_sim, _hora_Ext_dob)
            importe_salida = 0

            'para las horas de 1.35 _________________________________________________________________________
            If personalBE_.PE_ID_TIPO_PER = 2 Then
                dbl_monto = 1.35 * personalBE_.PE_HORAS_TRABAJO * Val(_hora_Ext_sim) * 1
            Else

                '1 = Administrativo '2 = Asistencial
                If personalBE_.PE_ID_PERSONAL = 1 Then
                    dbl_monto = Math.Round(1.35 * Val(personalBE_.PE_IMPORTE_REMUNERACION) / 240 * Val(_hora_Ext_sim), 3)
                Else
                    dbl_monto = Math.Round(1.35 * Val(personalBE_.PE_IMPORTE_REMUNERACION) / 180 * Val(_hora_Ext_sim), 3)
                End If
            End If

            If dbl_monto > 0 Then 'Grabamos en la tabla de boletas(historial)
                Call Grabar_en_Historial(personalBE_, conceptoBE, empresaBE, mes_, fechaPeriodo_, _
                                             dbl_monto, conceptoBE.CO_ID_IDENTIFICADOR.ID_ID, 1, _
                                             "Hora Extras 1.35 (" & _hora_Ext_sim & "h)", Val(_hora_Ext_sim), 0, 0, 0)
            End If

            importe_salida += dbl_monto
        End If





        'para las horas de 2(dobles) feriados _________________________________________________________________________


        folioBE.FO_ID_CONCEPTO = New BE.PlanillaBE.SG_PL_TB_CONCEPTOS With {.CO_ID = "114"}

        If Not folioBL.Tiene_Folio_Registrado(folioBE) Then

            conceptoBE.CO_ID = "114"
            dbl_monto = 0

            If _hora_Ext_dob > 0 Then

                ' 1 = Empleados ; 2 = Horas
                If personalBE_.PE_ID_TIPO_PER = 2 Then
                    dbl_monto = 2 * personalBE_.PE_HORAS_TRABAJO * Val(_hora_Ext_dob)
                Else

                    '1 = Administrativo; 2 = Asistencial
                    If personalBE_.PE_ID_PERSONAL = 1 Then
                        dbl_monto = 2 * Val(personalBE_.PE_IMPORTE_REMUNERACION) / 240 * Val(_hora_Ext_dob)
                    Else
                        dbl_monto = 2 * Val(personalBE_.PE_IMPORTE_REMUNERACION) / 180 * Val(_hora_Ext_dob)
                    End If
                End If

                If dbl_monto > 0 Then 'Grabamos en la tabla de boletas(historial)
                    Call Grabar_en_Historial(personalBE_, conceptoBE, empresaBE, mes_, fechaPeriodo_, _
                                                 dbl_monto, conceptoBE.CO_ID_IDENTIFICADOR.ID_ID, 1, _
                                                 "Hora Extras 2 (" & _hora_Ext_dob & "h)", Val(_hora_Ext_dob), 0, 0, 0)
                End If

            End If
            importe_salida += dbl_monto

        End If

        

        _historialBL = Nothing
        folioBE = Nothing
        folioBL = Nothing

    End Sub

    Private Function Obtener_Tabla_AFP(ByVal empresa As BE.ContabilidadBE.SG_CO_TB_EMPRESA) As DataTable
        Dim afpBL As New BL.PlanillaBL.SG_PL_TB_AFP
        Obtener_Tabla_AFP = afpBL.getAfp(empresa)
        afpBL = Nothing
    End Function

    Private Function Obtener_Tope_Mensual(ByVal empresa As BE.ContabilidadBE.SG_CO_TB_EMPRESA, ByVal dat_fecha_periodo_ As Date) As Double
        Dim topeBL As New BL.PlanillaBL.SG_PL_TB_TOPE_MENSUAL
        Dim topeBE As New BE.PlanillaBE.SG_PL_TB_TOPE_MENSUAL
        Dim dbl_resultado As Double = 0

        topeBE.TM_PERIODO = dat_fecha_periodo_.Year
        topeBE.TM_MES = dat_fecha_periodo_.Month
        topeBE.TM_IDEMPRESA = empresa

        dbl_resultado = topeBL.get_tope_mensual(topeBE)

        topeBE = Nothing
        topeBL = Nothing

        Return dbl_resultado

    End Function

    Private Sub Borrar_Historial_Personal(ByVal personalBE As BE.PlanillaBE.SG_PL_TB_PERSONAL, ByVal empresaBE As BE.ContabilidadBE.SG_CO_TB_EMPRESA, ByVal fecha_ As Date)
        Dim historialBL As New BL.PlanillaBL.SG_PL_TB_HISTORIAL
        Dim historialBE As New BE.PlanillaBE.SG_PL_TB_HISTORIAL

        With historialBE
            .HI_ID_PERSONAL = personalBE
            .HI_ID_EMPRESA = empresaBE
            .HI_FEC_OPE = fecha_
        End With

        historialBL.Delete(historialBE)

        historialBE = Nothing
        historialBL = Nothing
    End Sub

    Private Sub Obtener_Num_Suspensiones(ByVal id_personal As Integer, ByRef int_Num_Vacaciones As Integer, ByRef int_Num_Licencias_SinGoce As Integer, ByRef int_Num_Subsidios As Integer, ByRef int_Num_Faltas_ As Integer, ByVal dat_fecha_periodo As Date, ByRef int_Num_Licencias_ConGoce_ As Integer)
        Dim suspensionesBL As New BL.PlanillaBL.SG_PL_TB_SUSPENSIONES
        int_Num_Vacaciones = suspensionesBL.get_Suspensiones_x_Tipo_x_Personal_x_Periodo(1, id_personal, dat_fecha_periodo)
        int_Num_Subsidios = suspensionesBL.get_Suspensiones_x_Tipo_x_Personal_x_Periodo(2, id_personal, dat_fecha_periodo)
        int_Num_Licencias_SinGoce = suspensionesBL.get_Suspensiones_x_Tipo_x_Personal_x_Periodo(3, id_personal, dat_fecha_periodo)
        int_Num_Licencias_ConGoce_ = suspensionesBL.get_Suspensiones_x_Tipo_x_Personal_x_Periodo_Lice_singoce(3, id_personal, dat_fecha_periodo)
        int_Num_Faltas_ = suspensionesBL.get_Suspensiones_x_Tipo_x_Personal_x_Periodo(4, id_personal, dat_fecha_periodo)
        suspensionesBL = Nothing
    End Sub

    Private Sub Calcular_y_Registrar_Horas_TecnicasEnfermeras(ByVal idEmpleado As Integer, ByVal idTipoPersonal As Integer, ByRef total As Double, ByVal dat_fecha_periodo_ As Date)
        'aqui se lee la tabla que alimenta la Coordinadora Asistencial
        'las horas registradas por periodos(año-mes) en cabecera y detalle
        'Estas horas las calcula elprocedimiento almacenado y luego las graba en la tabla de movimiento
        '___________________________________________________________________

        Dim int_ayo As Integer = dat_fecha_periodo_.Year
        Dim int_mes As Integer = dat_fecha_periodo_.Month
        Dim fecha_proc As String = dat_fecha_periodo_.ToShortDateString

        Dim HorasPTECabeceraBL As New BL.PlanillaBL.SG_PL_TB_PERSONAL_HORAS_CAB
        total = HorasPTECabeceraBL.get_calcular_Horas_PTE(idEmpleado, int_ayo, int_mes, _
                                                              idTipoPersonal, fecha_proc, _
                                                              gStr_Usuario_Sis, Environment.MachineName, _
                                                              Now.Date, gInt_IdEmpresa)

        HorasPTECabeceraBL = Nothing

    End Sub

    Private Sub Calcular_Refrigerios(ByVal personalBE_ As BE.PlanillaBE.SG_PL_TB_PERSONAL, ByRef _total_ As Double, ByVal fecha_periodo_ As Date)

        Dim HorasPTECabeceraBL As New BL.PlanillaBL.SG_PL_TB_PERSONAL_HORAS_CAB
        Dim cant_refri As Integer = 0
        Dim cal_tmp As Double = 0

        cant_refri = HorasPTECabeceraBL.get_Refrigerios(fecha_periodo_.Year, fecha_periodo_.Month, personalBE_.PE_ID, gInt_IdEmpresa)

        If cant_refri > 0 Then
            Select Case personalBE_.PE_ID_CARGO
                Case 18 'OBSTETRIZ
                    cal_tmp = cant_refri * 10
                Case Else 'tecnica de enfermeria-ENFERMERA DE BEBES
                    cal_tmp = cant_refri * 10
            End Select
        End If



        _total_ = 0

        If cal_tmp > 0 Then

            _total_ = cal_tmp

            'Grabamos en el historial
            Dim conceptoBE As New BE.PlanillaBE.SG_PL_TB_CONCEPTOS With {.CO_ID = "105"}
            Dim empresaBE As New BE.ContabilidadBE.SG_CO_TB_EMPRESA With {.EM_ID = gInt_IdEmpresa}

            Call Grabar_en_Historial(personalBE_, conceptoBE, empresaBE, _
                                     fecha_periodo_.Month, fecha_periodo_, _total_, _
                                     1, 1, "Refrigerio", 0, 0, 0, 0)

            conceptoBE = Nothing
            empresaBE = Nothing

        End If



        HorasPTECabeceraBL = Nothing
    End Sub

    Private Sub Calcular_y_Registrar_Horas_Normal(ByVal fecha_proc_ As Date, ByVal personalBE_ As BE.PlanillaBE.SG_PL_TB_PERSONAL, ByRef _total_ As Double)

        Dim dbl_horas_reg_3er_piso As Double = 0
        Dim HorasPTECabeceraBL As New BL.PlanillaBL.SG_PL_TB_PERSONAL_HORAS_CAB

        dbl_horas_reg_3er_piso = HorasPTECabeceraBL.get_Horas_personal_NoEnfTec(personalBE_.PE_ID, fecha_proc_.Year, fecha_proc_.Month, gInt_IdEmpresa)


        _total_ = personalBE_.PE_HORAS_TRABAJO * dbl_horas_reg_3er_piso


        If _total_ > 0 Then
            'Grabamos en el historial
            Dim conceptoBE As New BE.PlanillaBE.SG_PL_TB_CONCEPTOS With {.CO_ID = "119"}
            Dim empresaBE As New BE.ContabilidadBE.SG_CO_TB_EMPRESA With {.EM_ID = gInt_IdEmpresa}

            Call Grabar_en_Historial(personalBE_, conceptoBE, empresaBE, _
                                     fecha_proc_.Month, fecha_proc_, _total_, _
                                     1, 1, "Remuner. x Horas", 0, 0, 0, 0)

            conceptoBE = Nothing
            empresaBE = Nothing

        End If

        HorasPTECabeceraBL = Nothing

    End Sub

    Private Sub Grabar_en_Historial(ByVal personalBE As BE.PlanillaBE.SG_PL_TB_PERSONAL, ByVal conceptoBE As BE.PlanillaBE.SG_PL_TB_CONCEPTOS, ByVal empresaBE As BE.ContabilidadBE.SG_CO_TB_EMPRESA, ByVal mes As Integer, ByVal fecha As String, ByVal monto As Double, ByVal iden_dh As Integer, ByVal estado As Integer, ByVal descripcion_hd As String, ByVal horas As Double, idcuentacte_ As Integer, num_couta_ctacte_ As Integer, dias_vaca_ As Double)

        Dim historialBL As New BL.PlanillaBL.SG_PL_TB_HISTORIAL
        Dim historialBE As New BE.PlanillaBE.SG_PL_TB_HISTORIAL

        With historialBE
            .HI_ID_PERSONAL = personalBE
            .HI_MES = mes
            .HI_FEC_OPE = fecha
            .HI_COD_HD = conceptoBE
            .HI_MONTO = Math.Round(monto, 2, MidpointRounding.AwayFromZero)
            .HI_IDEN_HD = iden_dh
            .HI_EST_ASI = estado
            .HI_COD_AFP = personalBE.PE_ID_AFP
            .HI_DES_HD = descripcion_hd
            .HI_HORAS = horas
            .HI_ID_EMPRESA = empresaBE
            .HI_USUARIO = String.Format("{0}-{1}", Environment.UserName, gStr_Usuario_Sis)
            .HI_TERMINAL = Environment.MachineName
            .HI_FECREG = Now
            .HI_ID_CTACTE = idcuentacte_
            .HI_NUM_CUOTA_CTACTE = num_couta_ctacte_
            .HI_DIAS_VACA = dias_vaca_
        End With
        historialBL.Insert(historialBE)

        historialBE = Nothing
        historialBL = Nothing
    End Sub

    Private Function pl_TieneValor_de_Folio(ByVal personal_ As String, ByVal concepto_ As String, ByRef valor_ As Double, ByVal dat_fecha_periodo_ As Date) As Boolean

        Dim respuesta As Boolean = False
        Dim foliosBL As New BL.PlanillaBL.SG_PL_TB_FOLIO
        Dim foliosBE As New BE.PlanillaBE.SG_PL_TB_FOLIO

        foliosBE.FO_ANHO = dat_fecha_periodo_.Year
        foliosBE.FO_MES = dat_fecha_periodo_.Month
        foliosBE.FO_ID_EMPRESA = New BE.ContabilidadBE.SG_CO_TB_EMPRESA With {.EM_ID = gInt_IdEmpresa}
        foliosBE.FO_ID_CONCEPTO = New BE.PlanillaBE.SG_PL_TB_CONCEPTOS With {.CO_ID = concepto_}
        foliosBE.FO_ID_PERSONA = New BE.PlanillaBE.SG_PL_TB_PERSONAL With {.PE_ID = personal_}
        foliosBL.get_Folios_x_IdPersonal(foliosBE)


        If foliosBE.HasRow Then
            respuesta = True
            valor_ = foliosBE.FO_VALOR
        End If

        foliosBE = Nothing
        foliosBL = Nothing

        Return respuesta

    End Function

    Private Sub Calcular_Horas_Tardanzas_sinRegistro(ByVal trabajadorBE As BE.PlanillaBE.SG_PL_TB_PERSONAL, ByRef respuesta As Double, ByVal fecha_periodo_ As Date)

        '0=NINGUNO;   1=TRABAJADOR DE DIRECCION;    2=TRABAJADOR DE CONFIANZA
        If trabajadorBE.PE_ID_SITUACION_ESPECIAL = 2 Then
            respuesta = 0
            Exit Sub
        End If


        'aqui buscamos si tiene horas de tardanza modificadas en la tabla "SG_PL_TB_TARDANZA_PERSONAL"
        Dim tardanzaAuxBL As New BL.PlanillaBL.SG_PL_TB_TARDANZA_PERSONAL
        Dim tardanzaBE As New BE.PlanillaBE.SG_PL_TB_TARDANZA_PERSONAL
        Dim tiempo_tardanza As String = String.Empty

        tardanzaBE.TP_IDPERSONAL = trabajadorBE.PE_ID
        tardanzaBE.TP_ANHO = fecha_periodo_.Year
        tardanzaBE.TP_MES = fecha_periodo_.Month
        tiempo_tardanza = tardanzaAuxBL.get_Tardanza_aux_MinSeg(tardanzaBE)

        tardanzaBE = Nothing
        tardanzaAuxBL = Nothing

        If tiempo_tardanza.Length > 0 Then GoTo calcula_tiempo_tadanza



        Dim fecha_tmp As Date = "01/" & fecha_periodo_.Month.ToString.PadLeft(2, "0") & "/" & fecha_periodo_.Year.ToString
        Dim udte_fec_ini As Date = "25/" & fecha_tmp.AddMonths(-1).Month.ToString.PadLeft(2, "0") & "/" & fecha_tmp.AddMonths(-1).Year.ToString  'ObtenerPrimerDia(fecha_tmp)
        Dim udte_fec_fin As Date = "24/" & fecha_tmp.Month.ToString.PadLeft(2, "0") & "/" & fecha_tmp.Year.ToString 'ObtenerUltimoDia(fecha_tmp)


        Dim fecha_periodo As Date = fecha_periodo_
        Dim ayo As Integer = fecha_periodo.Year
        Dim mes As Integer = fecha_periodo.Month
        Dim dbl_resultado As Double = 0
        Dim marcacionesBL As New BL.PlanillaBL.Dicon
        Dim dt_tardanza As DataTable = Nothing
        Dim tadanza As DateTime
        Dim tadanza_menos45 As DateTime
        Dim horas As String = ""
        Dim minutos As String = ""
        Dim horas_tarde As String = ""
        Dim minutos_tarde As String = ""


        'dt_tardanza = marcacionesBL.Tardanzas(ayo, mes, trabajadorBE.PE_CONSIDERA_FT, trabajadorBE.PE_NUM_DOC_PER, udte_fec_ini, udte_fec_fin)



        Dim tardanza As TimeSpan = Nothing

        dt_tardanza = marcacionesBL.get_Tardanzas_Detalle_Con_cnx(trabajadorBE.PE_NUM_DOC_PER, udte_fec_ini, udte_fec_fin)

        For j As Integer = 0 To dt_tardanza.Rows.Count - 1
            Dim HMS As String()
            HMS = dt_tardanza.Rows(j)("TARDANZA").ToString.Split(":")

            If trabajadorBE.PE_CONSIDERA_FT = 1 Then
                If dt_tardanza.Rows(j)("ESTADO") <> "FT" Then
                    tardanza = tardanza.Add(New TimeSpan(CInt(HMS(0)), CInt(HMS(1)), CInt(HMS(2))))
                End If
            Else
                tardanza = tardanza.Add(New TimeSpan(CInt(HMS(0)), CInt(HMS(1)), CInt(HMS(2))))
            End If

        Next



        Dim tiempo_tolerancia As New TimeSpan(0, 45, 0)

        'tardanza = tardanza.Subtract(tiempo_tolerancia)


        If trabajadorBE.PE_ID_SITUACION_ESPECIAL <> 2 And tardanza.TotalMinutes > 45 Then

            tadanza = New DateTime(1, 1, 1, tardanza.Hours, tardanza.Minutes, tardanza.Seconds)
            horas_tarde = tardanza.Hours
            minutos_tarde = tardanza.Minutes

            tardanza = tardanza.Subtract(tiempo_tolerancia)


            tadanza_menos45 = New DateTime(1, 1, 1, tardanza.Hours, tardanza.Minutes, tardanza.Seconds)
            horas = tardanza.Hours
            minutos = tardanza.Minutes


        Else
            marcacionesBL = Nothing
            dt_tardanza = Nothing
            respuesta = 0
            Exit Sub
        End If

        'If dt_tardanza.Rows(0)("TOTAL_HRAS_TARDANZA").ToString = "" Then
        '    marcacionesBL = Nothing
        '    dt_tardanza = Nothing
        '    respuesta = 0
        '    Exit Sub
        'End If





        'If horas_tarde = 0 Then
        '    If minutos_tarde <= 45 Then
        '        marcacionesBL = Nothing
        '        dt_tardanza = Nothing
        '        respuesta = 0
        '        Exit Sub
        '    End If
        'End If


        tiempo_tardanza = (horas & "." & minutos)

calcula_tiempo_tadanza:



        '1 = Empleados
        '2 = Horas
        If trabajadorBE.PE_ID_TIPO_PER = 2 Then
            dbl_resultado = trabajadorBE.PE_HORAS_TRABAJO * Val(tiempo_tardanza)
        Else
            dbl_resultado = (Val(trabajadorBE.PE_IMPORTE_REMUNERACION) / 240 * Val(tiempo_tardanza))
        End If

        respuesta = Math.Round(dbl_resultado, 2)




        If respuesta > 0 Then
            'Grabamos en la tabla de historial

            'Dim conceptoBE As New BE.PlanillaBE.SG_PL_TB_CONCEPTOS With {.CO_ID = "200"}
            'Dim empresaBE As New BE.ContabilidadBE.SG_CO_TB_EMPRESA With {.EM_ID = gInt_IdEmpresa}
            'Dim str_desConcepto As String = "Faltas y Tardanzas  (" & tiempo_tardanza & "h)"

            'Call Grabar_en_Historial(trabajadorBE, conceptoBE, empresaBE, mes, _
            '                         fecha_periodo, respuesta, 2, 1, str_desConcepto, Val(tiempo_tardanza), 0, 0)
        End If



        marcacionesBL = Nothing
        dt_tardanza = Nothing

    End Sub

    Private Sub Calcular_Horas_Tardanzas(ByVal trabajadorBE As BE.PlanillaBE.SG_PL_TB_PERSONAL, ByRef respuesta As Double, ByVal fecha_periodo_ As Date)

        '0=NINGUNO;   1=TRABAJADOR DE DIRECCION;    2=TRABAJADOR DE CONFIANZA
        If trabajadorBE.PE_ID_SITUACION_ESPECIAL = 2 Then
            respuesta = 0
            Exit Sub
        End If


        'aqui buscamos si tiene horas de tardanza modificadas en la tabla "SG_PL_TB_TARDANZA_PERSONAL"
        Dim tardanzaAuxBL As New BL.PlanillaBL.SG_PL_TB_TARDANZA_PERSONAL
        Dim tardanzaBE As New BE.PlanillaBE.SG_PL_TB_TARDANZA_PERSONAL
        Dim tiempo_tardanza As String = String.Empty

        tardanzaBE.TP_IDPERSONAL = trabajadorBE.PE_ID
        tardanzaBE.TP_ANHO = fecha_periodo_.Year
        tardanzaBE.TP_MES = fecha_periodo_.Month
        tiempo_tardanza = tardanzaAuxBL.get_Tardanza_aux_MinSeg(tardanzaBE)

        tardanzaBE = Nothing
        tardanzaAuxBL = Nothing

        If tiempo_tardanza.Length > 0 Then GoTo calcula_tiempo_tadanza



        Dim fecha_tmp As Date = "01/" & fecha_periodo_.Month.ToString.PadLeft(2, "0") & "/" & fecha_periodo_.Year.ToString
        Dim udte_fec_ini As Date = "25/" & fecha_tmp.AddMonths(-1).Month.ToString.PadLeft(2, "0") & "/" & fecha_tmp.AddMonths(-1).Year.ToString  'ObtenerPrimerDia(fecha_tmp)
        Dim udte_fec_fin As Date = "24/" & fecha_tmp.Month.ToString.PadLeft(2, "0") & "/" & fecha_tmp.Year.ToString 'ObtenerUltimoDia(fecha_tmp)


        Dim fecha_periodo As Date = fecha_periodo_
        Dim ayo As Integer = fecha_periodo.Year
        Dim mes As Integer = fecha_periodo.Month
        Dim dbl_resultado As Double = 0
        Dim marcacionesBL As New BL.PlanillaBL.Dicon
        Dim dt_tardanza As DataTable = Nothing
        Dim tadanza As DateTime
        Dim tadanza_menos45 As DateTime
        Dim horas As String = ""
        Dim minutos As String = ""
        Dim horas_tarde As String = ""
        Dim minutos_tarde As String = ""


        'dt_tardanza = marcacionesBL.Tardanzas(ayo, mes, trabajadorBE.PE_CONSIDERA_FT, trabajadorBE.PE_NUM_DOC_PER, udte_fec_ini, udte_fec_fin)



        Dim tardanza As TimeSpan = Nothing

        dt_tardanza = marcacionesBL.get_Tardanzas_Detalle_Con_cnx(trabajadorBE.PE_NUM_DOC_PER, udte_fec_ini, udte_fec_fin)

        For j As Integer = 0 To dt_tardanza.Rows.Count - 1
            Dim HMS As String()
            HMS = dt_tardanza.Rows(j)("TARDANZA").ToString.Split(":")

            If trabajadorBE.PE_CONSIDERA_FT = 1 Then
                If dt_tardanza.Rows(j)("ESTADO") <> "FT" Then
                    tardanza = tardanza.Add(New TimeSpan(CInt(HMS(0)), CInt(HMS(1)), CInt(HMS(2))))
                End If
            Else
                tardanza = tardanza.Add(New TimeSpan(CInt(HMS(0)), CInt(HMS(1)), CInt(HMS(2))))
            End If

        Next



        Dim tiempo_tolerancia As New TimeSpan(0, 45, 0)

        'tardanza = tardanza.Subtract(tiempo_tolerancia)


        If trabajadorBE.PE_ID_SITUACION_ESPECIAL <> 2 And tardanza.TotalMinutes > 0 Then

            tadanza = New DateTime(1, 1, 1, tardanza.Hours, tardanza.Minutes, tardanza.Seconds)
            horas_tarde = tardanza.Hours
            minutos_tarde = tardanza.Minutes

            tardanza = tardanza.Subtract(tiempo_tolerancia)


            If tardanza.TotalMinutes < 0 Then
                marcacionesBL = Nothing
                dt_tardanza = Nothing
                respuesta = 0
                Exit Sub
            End If


            tadanza_menos45 = New DateTime(1, 1, 1, tardanza.Hours, tardanza.Minutes, tardanza.Seconds)
            horas = tardanza.Hours
            minutos = tardanza.Minutes


        Else
            marcacionesBL = Nothing
            dt_tardanza = Nothing
            respuesta = 0
            Exit Sub
        End If


        tiempo_tardanza = (horas & "." & minutos)

calcula_tiempo_tadanza:

        Dim tot_minutes As Double = (Val(horas) * 60) + Val(minutos)

        '1 = Empleados
        '2 = Horas
        If trabajadorBE.PE_ID_TIPO_PER = 2 Then
            dbl_resultado = trabajadorBE.PE_HORAS_TRABAJO * Val(tiempo_tardanza)
        Else
            Select Case trabajadorBE.PE_ID_EMPRESA

                Case 1 'Clinica Miraflores sac
                    'dbl_resultado = (Val(trabajadorBE.PE_IMPORTE_REMUNERACION) / 240 * Val(tiempo_tardanza))
                    dbl_resultado = (((Val(trabajadorBE.PE_IMPORTE_REMUNERACION) / 240) / 60) * tot_minutes)

                Case 7 'Botica IGFarma
                    'dbl_resultado = (((Val(trabajadorBE.PE_IMPORTE_REMUNERACION) / 150) / IIf(Val(horas) = 0, 60, 1)) * Val(tiempo_tardanza))
                    dbl_resultado = (((Val(trabajadorBE.PE_IMPORTE_REMUNERACION) / 150) / 60) * tot_minutes)




                Case Else
                    dbl_resultado = (((Val(trabajadorBE.PE_IMPORTE_REMUNERACION) / 240) / 60) * tot_minutes)
            End Select

        End If

        respuesta = Math.Round(dbl_resultado, 2)


        If respuesta > 0 Then
            'Grabamos en la tabla de historial

            Dim conceptoBE As New BE.PlanillaBE.SG_PL_TB_CONCEPTOS With {.CO_ID = "200"}
            Dim empresaBE As New BE.ContabilidadBE.SG_CO_TB_EMPRESA With {.EM_ID = gInt_IdEmpresa}
            Dim str_desConcepto As String = "Faltas y Tardanzas  (" & tiempo_tardanza & "h)"

            Call Grabar_en_Historial(trabajadorBE, conceptoBE, empresaBE, mes, _
                                     fecha_periodo, respuesta, 2, 1, str_desConcepto, Val(tiempo_tardanza), 0, 0, 0)
        End If
        

        marcacionesBL = Nothing
        dt_tardanza = Nothing

    End Sub

    Private Sub Calcular_Prestamos_Personal(ByVal trabajadorBE As BE.PlanillaBE.SG_PL_TB_PERSONAL, ByVal ayo As Integer, ByVal mes As Integer, ByRef importe_salida As Double)


        Dim cronoBL As New BL.PlanillaBL.SG_PL_TB_CTA_CTE_CRONOGRAMA
        Dim ls_importe As List(Of Double) = cronoBL.get_Importe_aPagar_x_Trabajador(trabajadorBE.PE_ID, ayo, mes)
        Dim str_desConcepto As String = String.Empty
        Dim fecha_periodo As Date = "01/" & mes.ToString.PadLeft(2, "0") & "/" & ayo.ToString

        Dim conceptoBE As New BE.PlanillaBE.SG_PL_TB_CONCEPTOS
        Dim empresaBE As New BE.ContabilidadBE.SG_CO_TB_EMPRESA With {.EM_ID = gInt_IdEmpresa}

        If ls_importe.Count > 0 Then

            If ls_importe(0) > 0 Then
                conceptoBE.CO_ID = "215"
                str_desConcepto = "Prestamos al Personal"
                Call Grabar_en_Historial(trabajadorBE, conceptoBE, empresaBE, mes, fecha_periodo, ls_importe(0), 2, 1, str_desConcepto, 0, ls_importe(2), ls_importe(3), 0)
            End If

            If ls_importe(1) > 0 Then
                conceptoBE.CO_ID = "227"
                str_desConcepto = "Otros Dsctos."
                Call Grabar_en_Historial(trabajadorBE, conceptoBE, empresaBE, mes, fecha_periodo, ls_importe(1), 2, 1, str_desConcepto, 0, ls_importe(2), ls_importe(3), 0)
            End If

            empresaBE = Nothing
            conceptoBE = Nothing
            cronoBL = Nothing

        End If

        importe_salida = ls_importe(0) + ls_importe(1)

    End Sub

End Module
