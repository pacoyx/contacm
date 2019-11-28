Public Class HO_PR_ManteRegHospi

    Private Sub HO_PR_ManteRegHospi_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Call Cargar_Datos()
        Call Cargar_Camas()
        Tool_Cancelar.Enabled = False
        Call MostrarTabs(0, utc_hospi)
    End Sub

    Private Sub Cargar_Datos()


        Dim dt_tmp As DataTable = Nothing
        Dim pacienteHospiBL As New BL.HospitalBL.SG_HO_TB_PACI_HOSPI

        Try
            dt_tmp = pacienteHospiBL.get_Pacientes_Hospi(gInt_IdEmpresa)
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
                ug_ListaCamas.Rows(i).Cells("MEDICO").Value = dt_tmp.Rows(i)("MEDICO")
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

    End Sub


    Private Sub Cargar_Camas()
        Dim habitaBL As New BL.HospitalBL.SG_HO_TB_CAMA
        uce_Habi.DataSource = habitaBL.getccama_cmb(gInt_IdEmpresa)
        uce_Habi.DisplayMember = "CA_DESCRIPCION"
        uce_Habi.ValueMember = "CA_CODIGO"
        habitaBL = Nothing
    End Sub

    Private Sub Tool_Salir_Click(sender As System.Object, e As System.EventArgs) Handles Tool_Salir.Click
        Me.Close()
    End Sub

    Private Sub Tool_daralta_Click(sender As System.Object, e As System.EventArgs) Handles Tool_daralta.Click

        If ug_ListaCamas.ActiveRow Is Nothing Then Exit Sub
        If ug_ListaCamas.Rows.Count = 0 Then Exit Sub

        If ug_ListaCamas.ActiveRow.Cells("PH_IDHISTORIA").Value.ToString.Length = 0 Then
            Avisar("No tiene solicitud asignada a esta cama")
            Exit Sub
        End If

        Call MostrarTabs(1, utc_hospi, 1)
        txt_num_soli.Text = ug_ListaCamas.ActiveRow.Cells("PH_IDSOLICI").Value
        txt_num_historia.Text = ug_ListaCamas.ActiveRow.Cells("PH_IDHISTORIA").Value
        txt_paciente.Text = ug_ListaCamas.ActiveRow.Cells("PACIENTE").Value
        Tool_Cancelar.Enabled = True
        Tool_daralta.Enabled = False
        Tool_Consumos.Enabled = False
        ume_fec_alta.Focus()
    End Sub

    Private Sub ubtn_darAlta_Click(sender As System.Object, e As System.EventArgs) Handles ubtn_darAlta.Click

        If txt_num_soli.Text = "" Then
            Call Avisar("Falta el numero de solicitud")
            Exit Sub
        End If

        If ume_fec_alta.Value.ToString = "" Then
            Avisar("Ingrese la fecha de alta")
            ume_fec_alta.Focus()
            Exit Sub
        End If

        Dim hospiBL As New BL.HospitalBL.SG_HO_TB_PACI_HOSPI
        hospiBL.Dar_Alta(CInt(txt_num_soli.Text))
        hospiBL = Nothing

        Call Avisar("    Listo!  ")
        Call Cargar_Datos()
        Call Tool_Cancelar_Click(sender, e)

    End Sub

    Private Sub Tool_Cancelar_Click(sender As System.Object, e As System.EventArgs) Handles Tool_Cancelar.Click
        Call MostrarTabs(0, utc_hospi)
        Tool_Cancelar.Enabled = False
        Tool_daralta.Enabled = True
        Tool_Consumos.Enabled = True
    End Sub

    Private Sub ume_fec_alta_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles ume_fec_alta.KeyDown
        If e.KeyCode = Keys.Enter Then
            ubtn_darAlta.Focus()
        End If
    End Sub

    Private Sub Tool_Consumos_Click(sender As System.Object, e As System.EventArgs) Handles Tool_Consumos.Click
        Call MostrarTabs(2, utc_hospi)
        Tool_Cancelar.Enabled = True
        Tool_daralta.Enabled = False
        Tool_Consumos.Enabled = False
    End Sub

    Private Sub Tool_Actualizar_Click(sender As System.Object, e As System.EventArgs) Handles Tool_Actualizar.Click
        Call Cargar_Datos()
    End Sub

    Private Sub Tool_Imprimir_Click(sender As System.Object, e As System.EventArgs) Handles Tool_Imprimir.Click

        If ug_ListaCamas.Rows.Count <= 0 Then Exit Sub
        If ug_ListaCamas.ActiveRow Is Nothing Then Exit Sub

        If ug_ListaCamas.ActiveRow.Cells("PACIENTE").Value = "" Then
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


    Private Sub Tool_camb_cama_Click(sender As System.Object, e As System.EventArgs) Handles Tool_camb_cama.Click

        Call MostrarTabs(3, utc_hospi)
        txt_cama_Act.Text = ug_ListaCamas.ActiveRow.Cells("cama").Value
        Tool_Cancelar.Enabled = True
        Tool_daralta.Enabled = False
        Tool_Consumos.Enabled = False
        uce_Habi.Focus()
    End Sub

    Private Sub ubtn_camb_habi_Click(sender As System.Object, e As System.EventArgs) Handles ubtn_camb_habi.Click

        If ug_ListaCamas.ActiveRow Is Nothing Then Exit Sub
        If ug_ListaCamas.ActiveRow.Cells("PH_IDSOLICI").Value.ToString = "" Then Exit Sub
        If uce_Habi.SelectedIndex = -1 Then
            Avisar("Seleccione una cama")
            Exit Sub
        End If


        Dim admisionpisoBL As New BL.HospitalBL.SG_HO_TB_PACI_HOSPI
        admisionpisoBL.Cambiar_Cama(ug_ListaCamas.ActiveRow.Cells("PH_IDSOLICI").Value, uce_Habi.Value, gInt_IdEmpresa)
        admisionpisoBL = Nothing
        Call Avisar("Listo")

        Call Cargar_Datos()
        Call MostrarTabs(0, utc_hospi)



    End Sub
End Class