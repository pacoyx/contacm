Public Class HO_PR_HospitalPaci

    Private Sub HO_PR_HospitalPaci_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        ugb_alta.Visible = False
        ugb_camb_habi.Visible = False
        Call Cargar_Datos()
        Call Cargar_Camas()
        txt_num_soli.ButtonsRight(0).Appearance.Image = My.Resources._104
        ubtn_darAlta.Appearance.Image = My.Resources._16__Ok_
        ubtn_darAlta.Appearance.Image = My.Resources._16__Ok_
        ubtn_cancelar.Appearance.Image = My.Resources._16__Cancel_
        ubtn_cancelar_cambCama.Appearance.Image = My.Resources._16__Cancel_


        Tool_Grabar.Enabled = False
        Tool_Cancelar.Enabled = False
        Call MostrarTabs(0, utc_hospi)
    End Sub

    Private Sub Cargar_Datos()

        Dim dt_tmp As DataTable = Nothing
        Dim pacienteHospiBL As New BL.HospitalBL.SG_HO_TB_PACI_HOSPI


        Try
            dt_tmp = pacienteHospiBL.get_Camas(gInt_IdEmpresa)
            Me.Cursor = Cursors.WaitCursor

            Call LimpiaGrid(ug_ListaCamas, uds_hospi)
            For i As Integer = 0 To dt_tmp.Rows.Count - 1
                ug_ListaCamas.DisplayLayout.Bands(0).AddNew()
                ug_ListaCamas.Rows(i).Cells("IDCAMA").Value = dt_tmp.Rows(i)("IDCAMA")
                ug_ListaCamas.Rows(i).Cells("CAMA").Value = dt_tmp.Rows(i)("CAMA")
                ug_ListaCamas.Rows(i).Cells("HABITACION").Value = dt_tmp.Rows(i)("HABITACION")
                ug_ListaCamas.Rows(i).Cells("PISO").Value = dt_tmp.Rows(i)("PISO")
                ug_ListaCamas.Rows(i).Cells("PACIENTE").Value = dt_tmp.Rows(i)("PACIENTE")
                ug_ListaCamas.Rows(i).Cells("FEC_INGRESO").Value = dt_tmp.Rows(i)("FEC_INGRESO")
                ug_ListaCamas.Rows(i).Cells("DIAGNOSTICO").Value = dt_tmp.Rows(i)("DIAGNOSTICO")
                ug_ListaCamas.Rows(i).Cells("NUM_CAMA").Value = dt_tmp.Rows(i)("NUM_CAMA")
                ug_ListaCamas.Rows(i).Cells("PH_IDSOLICI").Value = dt_tmp.Rows(i)("PH_IDSOLICI")
                ug_ListaCamas.Rows(i).Cells("PH_IDHISTORIA").Value = dt_tmp.Rows(i)("PH_IDHISTORIA")
                'ug_ListaCamas.Rows(i).Cells("MEDICO").Value = dt_tmp.Rows(i)("MEDICO")
                ug_ListaCamas.Rows(i).Cells("PH_FAMILIAR").Value = dt_tmp.Rows(i)("PH_FAMILIAR")
                ug_ListaCamas.Rows(i).Cells("PH_TELEF").Value = dt_tmp.Rows(i)("PH_TELEF")
                ug_ListaCamas.Rows(i).Cells("PH_DIR").Value = dt_tmp.Rows(i)("PH_DIR")
                ug_ListaCamas.Rows(i).Cells("IMG").Value = My.Resources.cama04
                ug_ListaCamas.UpdateData()
            Next

            ug_ListaCamas.Rows(0).Activate()
            ug_ListaCamas.Rows(0).Selected = True


            Me.Cursor = Cursors.Default
            dt_tmp.Dispose()
            pacienteHospiBL = Nothing

        Catch ex As Exception
            Me.Cursor = Cursors.Default
        End Try


        pacienteHospiBL = Nothing

    End Sub

    Private Sub Cargar_Camas()
        Dim habitaBL As New BL.HospitalBL.SG_HO_TB_CAMA
        uce_camas.DataSource = habitaBL.getccama_cmb(gInt_IdEmpresa)
        uce_camas.DisplayMember = "CA_DESCRIPCION"
        uce_camas.ValueMember = "CA_CODIGO"
        habitaBL = Nothing
    End Sub

    Private Sub Cargar_Ayuda()
        Dim f As New HO_PR_Lista_SoliciHospi
        f.ShowDialog()
        If f.bol_aceptar Then
            txt_num_soli.Text = f.ls_datos(0)
            txt_num_historia.Text = f.ls_datos(1)
            txt_paciente.Text = f.ls_datos(2)
            txt_diag.Text = f.ls_datos(3)
            txt_medico.Text = f.ls_datos(5)
            ume_fec_ing.Value = f.ls_datos(6)
        End If
        f = Nothing
    End Sub

    Private Sub Tool_Grabar_Click(sender As System.Object, e As System.EventArgs) Handles Tool_Grabar.Click

        'validar datos
        If txt_num_soli.Text = "" Then
            Call Avisar("Ingrese el numero de solicitud de hospitalizacion")
            txt_num_soli.Focus()
            Exit Sub
        End If

        Dim pacienteHospiBE As New BE.HospitalBE.SG_HO_TB_PACI_HOSPI
        Dim pacienteHospiBL As New BL.HospitalBL.SG_HO_TB_PACI_HOSPI

        With pacienteHospiBE
            .PH_IDHISTORIA = txt_num_historia.Text.Trim
            .PH_IDSOLICI = txt_num_soli.Text.Trim
            .PH_FEC_ING = ume_fec_ing.Value.ToString
            .PH_FEC_ALTA = ""
            .PH_NUM_CAM = txt_num_cama.Text.Trim
            .PH_DIAGNOS = txt_diag.Text.Trim
            .PH_INDICACION = txt_indica.Text.Trim
            .PH_DIAS = IIf(txt_dias.Text = "", 0, txt_dias.Text)
            '1=ingreso, 0 = alta
            .PH_ESTADO = 1
            .PH_FAMILIAR = txt_familiar.Text.Trim
            .PH_TELEF = txt_telef.Text.Trim
            .PH_DIR = txt_dir.Text.Trim
            .PH_USUARIO = String.Format("{0}-{1}", Environment.UserName, gStr_Usuario_Sis)
            .PH_PC = Environment.MachineName
            .PH_FECREG = Date.Now
            .PH_IDEMPRESA = gInt_IdEmpresa
            .PH_IDCAMA = CInt(txt_idcama.Text)
        End With

        pacienteHospiBL.insert(pacienteHospiBE)

        pacienteHospiBE = Nothing
        pacienteHospiBL = Nothing

        Call Avisar("Listo!")
        Call Cargar_Datos()
        Call MostrarTabs(0, utc_hospi)
        Tool_Grabar.Enabled = False
        Tool_Cancelar.Enabled = False
        Tool_Imprimir.Enabled = True
    End Sub

    Private Sub Tool_Cancelar_Click(sender As System.Object, e As System.EventArgs) Handles Tool_Cancelar.Click
        Call MostrarTabs(0, utc_hospi)
        Tool_Grabar.Enabled = False
        Tool_Cancelar.Enabled = False
        Tool_daralta.Enabled = False
        Tool_camb_cama.Enabled = False
        Tool_Imprimir.Enabled = True
    End Sub

    Private Sub Tool_Salir_Click(sender As System.Object, e As System.EventArgs) Handles Tool_Salir.Click
        Me.Close()
    End Sub

    Private Sub txt_num_soli_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles txt_num_soli.KeyDown
        If e.KeyCode = Keys.F2 Then
            Call Cargar_Ayuda()
        End If
    End Sub

    Private Sub txt_num_soli_EditorButtonClick(sender As System.Object, e As Infragistics.Win.UltraWinEditors.EditorButtonEventArgs) Handles txt_num_soli.EditorButtonClick
        Call Cargar_Ayuda()
    End Sub

    Private Sub ug_ListaCamas_DoubleClickRow(sender As System.Object, e As Infragistics.Win.UltraWinGrid.DoubleClickRowEventArgs) Handles ug_ListaCamas.DoubleClickRow

        Call Limpiar_Controls_InGroupox(ugb_datos)
        ume_fec_alta.Value = Nothing

        If ug_ListaCamas.ActiveRow.Cells("PACIENTE").Value.ToString = "" Then
            txt_num_cama.Text = ug_ListaCamas.ActiveRow.Cells("NUM_CAMA").Value
            txt_idcama.Text = ug_ListaCamas.ActiveRow.Cells("IDCAMA").Value
            txt_Habitacion.Text = ug_ListaCamas.ActiveRow.Cells("HABITACION").Value

        Else

            txt_num_soli.Text = ug_ListaCamas.ActiveRow.Cells("PH_IDSOLICI").Value
            txt_num_cama.Text = ug_ListaCamas.ActiveRow.Cells("NUM_CAMA").Value
            txt_idcama.Text = ug_ListaCamas.ActiveRow.Cells("IDCAMA").Value
            txt_Habitacion.Text = ug_ListaCamas.ActiveRow.Cells("HABITACION").Value

            If txt_num_soli.Text <> "" Then
                'jalar datos del registro
                Dim registroBL As New BL.HospitalBL.SG_HO_TB_PACI_HOSPI
                Dim dt_tmp As DataTable = registroBL.get_Lista_Soli_Hospi_x_id(CInt(txt_num_soli.Text), gInt_IdEmpresa)

                If dt_tmp.Rows.Count > 0 Then
                    txt_num_historia.Text = dt_tmp.Rows(0)("PH_IDHISTORIA")
                    txt_medico.Text = dt_tmp.Rows(0)("MEDICO")
                    txt_paciente.Text = dt_tmp.Rows(0)("PACIENTE")
                    ume_fec_ing.Value = dt_tmp.Rows(0)("PH_FEC_ING")
                    txt_dias.Text = dt_tmp.Rows(0)("PH_DIAS")
                    txt_diag.Text = dt_tmp.Rows(0)("PH_DIAGNOS")
                    txt_indica.Text = dt_tmp.Rows(0)("PH_INDICACION")
                    txt_familiar.Text = dt_tmp.Rows(0)("PH_FAMILIAR")
                    txt_telef.Text = dt_tmp.Rows(0)("PH_TELEF")
                    txt_dir.Text = dt_tmp.Rows(0)("PH_DIR")
                End If

                dt_tmp.Dispose()
                registroBL = Nothing
            End If


        End If

        Tool_Grabar.Enabled = True
        Tool_Cancelar.Enabled = True
        Tool_daralta.Enabled = False
        Tool_camb_cama.Enabled = False
        Tool_Imprimir.Enabled = False

        Call MostrarTabs(1, utc_hospi)
        txt_num_soli.Focus()

    End Sub

    Private Sub Tool_Imprimir_Click(sender As System.Object, e As System.EventArgs) Handles Tool_Imprimir.Click
        If ug_ListaCamas.Rows.Count <= 0 Then Exit Sub
        If ug_ListaCamas.ActiveRow Is Nothing Then Exit Sub

        If ug_ListaCamas.ActiveRow.Cells("PACIENTE").Value.ToString = "" Then
            Avisar("No hay paciente registrado")
            Exit Sub
        End If

        Me.Cursor = Cursors.WaitCursor

        Dim nom_reporte As String = "SG_AD_01_1.RPT"
        Dim crystalBL As New LR.ClsReporte
        Dim dt_data As New DataTable
        Dim historiasBL As New BL.AdmisionBL.SG_AD_TB_HISTO_CLINI
        Dim numHistoria As Integer = ug_ListaCamas.ActiveRow.Cells("PH_IDHISTORIA").Value
        dt_data = historiasBL.getHistorias_Hoja_Afiliacion(numHistoria)

        Dim Telefono As String = ""
        Dim Celular As String = ""
        Dim Edad As String = "" 'Int(DateDiff("m", udte_fec_nac.Value, Date.Now) / 12)
        Dim EdadT As String = "" 'Int(DateDiff("m", udte_fec_NacTitular.Value, Date.Now) / 12)
        Dim num_cama As String = ug_ListaCamas.ActiveRow.Cells("CAMA").Value.ToString

        Dim notificar As String = ug_ListaCamas.ActiveRow.Cells("PH_FAMILIAR").Value.ToString
        Dim domicilio_fam As String = ug_ListaCamas.ActiveRow.Cells("PH_DIR").Value.ToString
        Dim telfe_fam As String = ug_ListaCamas.ActiveRow.Cells("PH_TELEF").Value.ToString

        If dt_data.Rows(0)("HC_FNAC").ToString.Length > 0 Then
            Edad = Int(DateDiff("m", dt_data.Rows(0)("HC_FNAC"), Date.Now) / 12)
        End If

        If dt_data.Rows(0)("HC_FNAC_TITU").ToString.Length > 0 Then
            EdadT = Int(DateDiff("m", dt_data.Rows(0)("HC_FNAC_TITU"), Date.Now) / 12)
        End If

        For i As Integer = 0 To dt_data.Rows.Count - 1
            If dt_data.Rows(i)("CC_IDCOMUNICA").ToString = "1" Then
                Telefono = dt_data.Rows(i)("CC_DESCRIPCION").ToString
            End If

            If dt_data.Rows(i)("CC_IDCOMUNICA").ToString = "2" Then
                Celular = dt_data.Rows(i)("CC_DESCRIPCION").ToString
            End If
        Next

        crystalBL.Muestra_Reporte(gStr_RutaRep & "\" & nom_reporte, dt_data, "", "pApePat;" & dt_data.Rows(0)("HC_APE_PAT").ToString, _
                                  "pApeMat;" & dt_data.Rows(0)("HC_APE_MAT").ToString, "pNombres;" & dt_data.Rows(0)("NOMBRE").ToString, "pHC;" & numHistoria.ToString.PadLeft(10, "0") _
                                  , "pDomicilio;" & dt_data.Rows(0)("HC_DIR").ToString, "pTelefono;" & Telefono, "pOcupacion;" & dt_data.Rows(0)("OCUPACION").ToString _
                                  , "pDNI;" & dt_data.Rows(0)("HC_NDOC").ToString, "pFechaNac;" & CDate(dt_data.Rows(0)("HC_FNAC")).ToShortDateString, "pEdad;" & Edad _
                                  , "pEstCivil;" & dt_data.Rows(0)("EST_CIVIL").ToString, "pSexo;" & dt_data.Rows(0)("SEXO").ToString, "pNacionalidad;" & dt_data.Rows(0)("NACIONALIDAD").ToString _
                                  , "pTitular;" & dt_data.Rows(0)("HC_TITULAR").ToString & " " & dt_data.Rows(0)("HC_FNAC_TITU").ToString, "pEdadT;" & EdadT, "pCelular;" & Celular _
                                  , "pGrupoS;" & dt_data.Rows(0)("GRUPOSANGRE").ToString, "pMedico;" & dt_data.Rows(0)("MEDICO").ToString, "pFechaAd;" & Now.Date _
                                  , "pHoraAd;" & Now.ToString("HH:mm:ss"), "pUsu;" & gStr_Usuario_Sis, "pNum_cama;" & num_cama, "pNotificar;" & notificar, "pDomicilio_fam;" & domicilio_fam, "pTelf_fam;" & telfe_fam _
                                  , "pTipoAtencion;" & dt_data.Rows(0)("CA_DESCRIPCION").ToString, "pCuenta;" & dt_data.Rows(0)("SH_IDCUENTA").ToString, "pDistrito;" & dt_data.Rows(0)("UB_DESCRIPCION").ToString)


        dt_data = Nothing
        crystalBL = Nothing

        Me.Cursor = Cursors.Default
    End Sub

    Private Sub ubtn_darAlta_Click(sender As System.Object, e As System.EventArgs) Handles ubtn_darAlta.Click


        If ume_fecha_alta2.Value.ToString = "" Then
            Avisar("Ingrese la fecha de alta")
            ume_fec_alta.Focus()
            Exit Sub
        End If

        If ug_ListaCamas.ActiveRow Is Nothing Then
            Avisar("Seleccione una fila de la lista")
            Exit Sub
        End If

        Dim hospiBL As New BL.HospitalBL.SG_HO_TB_PACI_HOSPI
        hospiBL.Dar_Alta(CInt(ug_ListaCamas.ActiveRow.Cells("PH_IDSOLICI").Value))
        hospiBL = Nothing

        Call Avisar("    Listo!  ")
        Call Cargar_Datos()
        ugb_alta.Visible = False

    End Sub

    Private Sub Tool_daralta_Click(sender As System.Object, e As System.EventArgs) Handles Tool_daralta.Click
        If ug_ListaCamas.ActiveRow.Cells("PH_IDHISTORIA").Value.ToString = "" Then
            Avisar("No tiene paciente registrado")
            Exit Sub
        End If


        ugb_alta.Visible = True
        ume_fec_alta.Text = ""
        ume_fec_alta.Focus()

    End Sub

    Private Sub ubtn_cancelar_Click(sender As System.Object, e As System.EventArgs) Handles ubtn_cancelar.Click
        ugb_alta.Visible = False
    End Sub

    Private Sub Tool_camb_cama_Click(sender As System.Object, e As System.EventArgs) Handles Tool_camb_cama.Click
        If ug_ListaCamas.ActiveRow Is Nothing Then Exit Sub
        If ug_ListaCamas.ActiveRow.Cells("PH_IDSOLICI").Value.ToString = "" Then Exit Sub

        txt_paciente02.Text = ug_ListaCamas.ActiveRow.Cells("PACIENTE").Value.ToString
        txt_cama_Act.Text = ug_ListaCamas.ActiveRow.Cells("cama").Value
        uce_camas.SelectedIndex = -1
        ugb_camb_habi.Visible = True

    End Sub

    Private Sub UltraButton1_Click(sender As System.Object, e As System.EventArgs) Handles ubtn_cancelar_cambCama.Click
        ugb_camb_habi.Visible = False
    End Sub

    Private Sub ubtn_camb_habi_Click(sender As System.Object, e As System.EventArgs) Handles ubtn_camb_habi.Click

        If uce_camas.SelectedIndex = -1 Then
            Avisar("Seleccione una cama")
            Exit Sub
        End If


        Dim admisionpisoBL As New BL.HospitalBL.SG_HO_TB_PACI_HOSPI
        admisionpisoBL.Cambiar_Cama(ug_ListaCamas.ActiveRow.Cells("PH_IDSOLICI").Value, uce_camas.Value, gInt_IdEmpresa)
        admisionpisoBL = Nothing

        Call Cargar_Datos()

        Call Avisar("Listo")

        ugb_camb_habi.Visible = False



    End Sub

    Private Sub txt_num_soli_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_num_soli.ValueChanged

    End Sub
End Class