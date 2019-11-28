Public Class FE_PR_CuentasCrio
    Private bsDistritos As New BindingSource
    Private bsProvincias As New BindingSource

    Private Sub FE_PR_CuentasCrio_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Call MostrarTabs(0, utc_crio)
        limpiar_controles()
        bloquear_boton_Ini()
        Call cargar_referencia()
        Call cargar_ubicacion()
        Call cargar_tipo_doc()
        Call cargar_arti()
        Call cargar_mone()
        Call cargar_medic()
        Call cargar_grilla_crio()
    End Sub
    Public Sub cargar_referencia()
        Dim refBL As New BL.FertilidadBL.SG_CF_TB_CUENTA_CRIO_C
        uos_referido.DataSource = refBL.get_referencia()
        uos_referido.DisplayMember = "RE_NOMBRE"
        uos_referido.ValueMember = "RE_ID"
        refBL = Nothing
    End Sub
    Public Sub cargar_ubicacion()
        Dim DepaBL As New BL.ContabilidadBL.SG_CO_TB_DEPARTAMENTO
        cb_depa.DataSource = DepaBL.getDepartamentos()
        cb_depa.ValueMember = "DE_ID"
        cb_depa.DisplayMember = "DE_DESCRIPCION"
        DepaBL = Nothing

        Dim uBIGEOBL As New BL.AdmisionBL.SG_AD_TB_UBIGEO
        bsProvincias.DataSource = uBIGEOBL.getProvincias()
        bsProvincias.Filter = String.Format("DEPARTAMENTO = '{0}'", cb_depa.Value)
        cb_prov.DataSource = bsProvincias
        cb_prov.ValueMember = "PR_CODIGO"
        cb_prov.DisplayMember = "PR_DESCRIPCION"

        bsDistritos.DataSource = uBIGEOBL.getUbigeo()
        bsDistritos.Filter = String.Format("PROVINCIA = '{0}'", cb_prov.Value)
        cb_ciu.DataSource = bsDistritos
        cb_ciu.DisplayMember = "UB_DESCRIPCION"
        cb_ciu.ValueMember = "UB_CODIGO"
        uBIGEOBL = Nothing
    End Sub

    Private Sub cb_depa_ValueChanged(sender As System.Object, e As System.EventArgs) Handles cb_depa.ValueChanged
        Try
            'txtIdDepartamento.Text = cboIdDepartamento.SelectedValue
            bsProvincias.Filter = String.Format("DEPARTAMENTO = '{0}'", cb_depa.Value)
        Catch ex As Exception
            Select Case ex.Message
                Case "La conversión del tipo 'DataRowView' en el tipo 'String' no es válida."
                Case Else
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Select
        End Try
    End Sub

    Private Sub cb_prov_ValueChanged(sender As System.Object, e As System.EventArgs) Handles cb_prov.ValueChanged
        Try
            bsDistritos.Filter = String.Format("PROVINCIA = '{0}'", cb_prov.Value)
        Catch ex As Exception
            Select Case ex.Message
                Case "La conversión del tipo 'DataRowView' en el tipo 'String' no es válida."
                Case Else
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Select
        End Try
    End Sub
    Public Sub cargar_tipo_doc()
        Dim tidocBL As New BL.FertilidadBL.SG_CF_TB_CUENTA_CRIO_C
        cb_tip_doc.DataSource = tidocBL.get_tipo_doc
        cb_tip_doc.DisplayMember = "DI_ABREVIATURA"
        cb_tip_doc.ValueMember = "DI_CODIGO"
        tidocBL = Nothing
    End Sub
    Public Sub cargar_arti()
        Dim articBL As New BL.FertilidadBL.SG_CF_TB_CUENTA_CRIO_C
        cb_arti.DataSource = articBL.get_arti
        cb_arti.DisplayMember = "AR_DESCRIPCION"
        cb_arti.ValueMember = "AR_ID"
        articBL = Nothing
    End Sub
    Public Sub cargar_mone()
        Dim moneBL As New BL.FertilidadBL.SG_CF_TB_CUENTA_CRIO_C
        cb_imp_cong.DataSource = moneBL.get_mone
        cb_imp_cong.DisplayMember = "MO_SIMBOLO"
        cb_imp_cong.ValueMember = "MO_CODIGO"

        cb_imp_semes.DataSource = moneBL.get_mone
        cb_imp_semes.DisplayMember = "MO_SIMBOLO"
        cb_imp_semes.ValueMember = "MO_CODIGO"
        moneBL = Nothing
    End Sub
    Public Sub cargar_medic()
        Dim medicBL As New BL.FertilidadBL.SG_CF_TB_CUENTA_CRIO_C
        cb_medic.DataSource = medicBL.get_medic
        cb_medic.DisplayMember = "NOMBRE"
        cb_medic.ValueMember = "ME_CODIGO"
        medicBL = Nothing
    End Sub

    Private Sub Tool_Salir_Click(sender As System.Object, e As System.EventArgs) Handles Tool_Salir.Click
        Me.Close()
    End Sub
    Private Sub Tool_Nuevo_Click(sender As System.Object, e As System.EventArgs) Handles Tool_Nuevo.Click
        limpiar_controles()
        udt_fec_pro.Focus()
        bloquear_boton_edi()
        MostrarTabs(1, utc_crio)
    End Sub
    Public Sub limpiar_controles()
        txt_cuenta.Text = "" : txt_n_historia.Text = "" : txt_ficha.Text = ""
        txt_nombre.Text = "" : txt_ape_mat.Text = "" : txt_ape_pat.Text = ""
        txt_email.Text = "" : txt_dir1.Text = "" : txt_dir2.Text = ""
        txt_n_doc.Text = "" : txt_imp_conge.Text = ""
        txt_imp_semes.Text = "" : txt_responsa.Text = "" : txt_obs.Text = ""
        cb_imp_cong.SelectedIndex = 0 : cb_imp_semes.SelectedIndex = 0
    End Sub
    Public Sub bloquear_boton_Ini()
        Tool_Nuevo.Enabled = True
        Tool_Grabar.Enabled = False
        Tool_Cancelar.Enabled = False
        Tool_Salir.Enabled = True
    End Sub
    Public Sub bloquear_boton_edi()
        Tool_Nuevo.Enabled = False
        Tool_Grabar.Enabled = True
        Tool_Cancelar.Enabled = True
        Tool_Salir.Enabled = False
    End Sub
    Private Sub Tool_Grabar_Click(sender As System.Object, e As System.EventArgs) Handles Tool_Grabar.Click
        If txt_n_historia.Text = "" Or txt_nombre.Text = "" _
            Or txt_ape_pat.Text = "" Or txt_ape_mat.Text = "" Or txt_n_doc.Text = "" Or uos_referido.Value = -1 Then
            Avisar(" Falta Completar ")
            Exit Sub
            ubtn_buscar_historia.Focus()
        End If
        Dim CuencrioBE As New BE.FertilidadBE.SG_CF_TB_CUENTA_CRIO_C
        Dim CuencrioBL As New BL.FertilidadBL.SG_CF_TB_CUENTA_CRIO_C
        With CuencrioBE
            .IDHISTORIA = txt_n_historia.Text
            .IDFICHA = txt_ficha.Text
            .IDARTICULO = cb_arti.Value
            .FEC_PROCESO = udt_fec_pro.Value
            .NOMBRES = txt_nombre.Text
            .APE_PAT = txt_ape_pat.Text
            .APE_MAT = txt_ape_mat.Text
            .IDTIPO_DOC = cb_tip_doc.Value
            .NUM_DOC = txt_n_doc.Text
            .IDMEDICO = cb_medic.Value
            .FEC_CONGE = udt_fec_cong.Value
            .IMP_CONGELACION = Val(txt_imp_conge.Text)
            .IDMONEDA_CONGE = cb_imp_cong.Value
            .IMP_SEMESTRAL = Val(txt_imp_semes.Text)
            .IDMONEDA_SEME = cb_imp_semes.Value
            .DIR1 = txt_dir1.Text
            .DIR2 = txt_dir2.Text
            .UBIGEO = cb_ciu.Value
            .EMAIL = txt_email.Text
            .OBS = txt_obs.Text
            .REFERIDO = uos_referido.Value
            .RESPONSABLE = txt_responsa.Text
            If rb_act.Checked = True Then
                .ESTADO = 1
            Else
                .ESTADO = 0
            End If
            .USUARIO = String.Format("{0}-{1}", Environment.UserName, gStr_Usuario_Sis)
            .TERMINAL = Environment.MachineName
            .FECREG = Date.Now
            .IDEMPRESA = gInt_IdEmpresa
        End With

        CuencrioBL.Insert(CuencrioBE)

        Avisar(" SE GRABO CON EXITO  ")
        MostrarTabs(0, utc_crio)
        Call cargar_grilla_crio()
        bloquear_boton_Ini()
        limpiar_controles()

        CuencrioBE = Nothing
        CuencrioBL = Nothing
    End Sub

    Private Sub Tool_Cancelar_Click(sender As System.Object, e As System.EventArgs) Handles Tool_Cancelar.Click
        limpiar_controles()
        Exit Sub
        Call cargar_grilla_crio()
        MostrarTabs(0, utc_crio)
        bloquear_boton_Ini()
    End Sub
    Public Sub cargar_grilla_crio()

        Dim crioBL As New BL.FertilidadBL.SG_CF_TB_CUENTA_CRIO_C
        ug_crio.DataSource = crioBL.get_grilla(gInt_IdEmpresa)
        ug_crio.DisplayLayout.Bands(0).Columns(0).Header.Caption = "Cuenta"
        ug_crio.DisplayLayout.Bands(0).Columns(1).Header.Caption = "Cod_Historia"
        ug_crio.DisplayLayout.Bands(0).Columns(2).Header.Caption = "N°_Ficha"
        ug_crio.DisplayLayout.Bands(0).Columns(3).Hidden = True
        ug_crio.DisplayLayout.Bands(0).Columns(4).Header.Caption = "Congelacion"
        ug_crio.DisplayLayout.Bands(0).Columns(5).Hidden = True
        ug_crio.DisplayLayout.Bands(0).Columns(6).Header.Caption = "Nombres"
        ug_crio.DisplayLayout.Bands(0).Columns(7).Header.Caption = "Ape_Paterno"
        ug_crio.DisplayLayout.Bands(0).Columns(8).Header.Caption = "Ape_Materno"
        ug_crio.DisplayLayout.Bands(0).Columns(9).Hidden = True
        ug_crio.DisplayLayout.Bands(0).Columns(10).Hidden = True
        ug_crio.DisplayLayout.Bands(0).Columns(11).Hidden = True
        ug_crio.DisplayLayout.Bands(0).Columns(12).Header.Caption = "Medico"
        ug_crio.DisplayLayout.Bands(0).Columns(13).Header.Caption = "Fecha_Congelación"
        ug_crio.DisplayLayout.Bands(0).Columns(14).Hidden = True
        ug_crio.DisplayLayout.Bands(0).Columns(15).Hidden = True
        ug_crio.DisplayLayout.Bands(0).Columns(16).Hidden = True
        ug_crio.DisplayLayout.Bands(0).Columns(17).Hidden = True
        ug_crio.DisplayLayout.Bands(0).Columns(18).Hidden = True
        ug_crio.DisplayLayout.Bands(0).Columns(19).Hidden = True
        ug_crio.DisplayLayout.Bands(0).Columns(20).Hidden = True
        ug_crio.DisplayLayout.Bands(0).Columns(21).Hidden = True
        ug_crio.DisplayLayout.Bands(0).Columns(22).Hidden = True
        ug_crio.DisplayLayout.Bands(0).Columns(23).Hidden = True
        ug_crio.DisplayLayout.Bands(0).Columns(24).Hidden = True
        ug_crio.DisplayLayout.Bands(0).Columns(25).Hidden = True
        ug_crio.DisplayLayout.Bands(0).Columns(26).Hidden = True
        ug_crio.DisplayLayout.Bands(0).Columns(27).Hidden = True
        ug_crio.DisplayLayout.Bands(0).Columns(28).Hidden = True
        ug_crio.DisplayLayout.Bands(0).Columns(29).Hidden = True

        crioBL = Nothing
    End Sub

    Private Sub ubtn_buscar_historia_Click(sender As System.Object, e As System.EventArgs) Handles ubtn_buscar_historia.Click
        AD_PR_BuscaPaciente.ShowDialog()
        Dim matriz As List(Of String) = AD_PR_BuscaPaciente.GetLista

        If matriz.Count > 0 Then

            txt_n_historia.Text = matriz(0)
            txt_nombre.Text = matriz(6) & "  " & matriz(7)
            txt_ape_pat.Text = matriz(3)
            txt_ape_mat.Text = matriz(4)
            cb_tip_doc.Value = matriz(8)
            txt_n_doc.Text = matriz(9)

            Format(Val(txt_n_historia.Text), "0000000000#")
            txt_dir1.Text = matriz(14)
            cb_depa.Value = Mid(matriz(17), 1, 2)
            cb_prov.Value = Mid(matriz(17), 1, 4)
            cb_ciu.Value = matriz(17)
            uos_referido.Value = matriz(20)
        End If

    End Sub

    Private Sub ubtn_buscar_ficha_Click(sender As System.Object, e As System.EventArgs) Handles ubtn_buscar_ficha.Click

    End Sub
End Class