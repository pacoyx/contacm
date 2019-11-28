Imports Infragistics.Win.UltraWinGrid
Public Class AD_MA_HistoClini_DatGen
    Private obe As BE.AdmisionBE.SG_AD_TB_HISTO_CLINI
    Private obr As BL.AdmisionBL.SG_AD_TB_HISTO_CLINI
    Private lNew As Boolean = False
    Private bsDistritos As New BindingSource
    Private bsProvincias As New BindingSource
    Dim apepat As String
    Dim Docu As String
    Dim apemat As String
    Dim apecas As String
    Dim nombre As String
    Dim historia As String

    Public Sub New()
        InitializeComponent()
        obe = New BE.AdmisionBE.SG_AD_TB_HISTO_CLINI
        obr = New BL.AdmisionBL.SG_AD_TB_HISTO_CLINI
    End Sub

    Private Sub pKeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Me.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Return) Then
            SendKeys.Send("{TAB}")
            e.Handled = True
        End If
    End Sub

    Private Sub pLostfocus(ByVal sender As Object, ByVal e As System.EventArgs) ' Handles txt_DesCorto.LostFocus, txt_Descripcion.LostFocus
        sender.BackColor = Color.White
        If sender.Text.Trim.Length < 1 Then
            sender.BackColor = Color.LightPink
        End If
    End Sub

    Private Function fValida() As Boolean
        pLostfocus(txt_ape_pat, Nothing)
        'pLostfocus(txt_ape_mat, Nothing)
        pLostfocus(txt_nom1, Nothing)
        pLostfocus(txt_num_doc, Nothing)
        uce_Departamento.BackColor = Color.White
        uce_Provincia.BackColor = Color.White
        uce_Ubigeo.BackColor = Color.White
        udte_fec_reg.BackColor = Color.White
        udte_fec_nac.BackColor = Color.White
        uce_Nacionalidad.BackColor = Color.White
        uce_est_civil.BackColor = Color.White
        uce_tip_doc.BackColor = Color.White
        uos_sexo.BackColor = Color.White

        If udte_fec_nac.Value = Nothing Then udte_fec_nac.BackColor = Color.LightPink
        If udte_fec_reg.Value = Nothing Then udte_fec_reg.BackColor = Color.LightPink
        If uos_sexo.Value = Nothing Then uos_sexo.BackColor = Color.LightPink
        If uce_Departamento.SelectedIndex = -1 Then uce_Departamento.BackColor = Color.LightPink
        If uce_Provincia.SelectedIndex = -1 Then uce_Provincia.BackColor = Color.LightPink
        If uce_Ubigeo.SelectedIndex = -1 Then uce_Ubigeo.BackColor = Color.LightPink
        If uce_Nacionalidad.SelectedIndex = -1 Then uce_Nacionalidad.BackColor = Color.LightPink
        If uce_est_civil.SelectedIndex = -1 Then uce_est_civil.BackColor = Color.LightPink
        If uce_tip_doc.SelectedIndex = -1 Then uce_tip_doc.BackColor = Color.LightPink

        If txt_num_doc.Text.Trim.Length <> 8 And (uce_tip_doc.Value = 1) Then
            txt_num_doc.BackColor = Color.LightPink
        End If

        If uce_Departamento.BackColor = Color.LightPink Then GoTo Err_Valida
        If uce_Provincia.BackColor = Color.LightPink Then GoTo Err_Valida
        If uce_Ubigeo.BackColor = Color.LightPink Then GoTo Err_Valida
        If udte_fec_reg.BackColor = Color.LightPink Then GoTo Err_Valida
        If uos_sexo.BackColor = Color.LightPink Then GoTo Err_Valida
        If udte_fec_nac.BackColor = Color.LightPink Then GoTo Err_Valida
        If txt_ape_pat.BackColor = Color.LightPink Then GoTo Err_Valida
        ' If txt_ape_mat.BackColor = Color.LightPink Then GoTo Err_Valida
        If txt_nom1.BackColor = Color.LightPink Then GoTo Err_Valida
        If uce_Nacionalidad.BackColor = Color.LightPink Then GoTo Err_Valida
        If uce_est_civil.BackColor = Color.LightPink Then GoTo Err_Valida
        If uce_tip_doc.BackColor = Color.LightPink Then GoTo Err_Valida
        If txt_num_doc.BackColor = Color.LightPink Then GoTo Err_Valida
        Return True
        Exit Function
Err_Valida:
        MessageBox.Show("Corrija ó Complete los campos errados !!", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Return False
    End Function

    Private Sub Cargar_Combos()

        Dim Ubi As New BL.AdmisionBL.SG_AD_TB_UBICACION
        Dim UbiE As New BE.AdmisionBE.SG_AD_TB_UBICACION
        Dim objU As New DataTable
        UbiE.UB_IdEmpresa = gInt_IdEmpresa
        Ubi.SEL01(UbiE, objU)
        utxt_Ubicacion.DataSource = objU
        utxt_Ubicacion.DisplayMember = "UB_Descripcion"
        utxt_Ubicacion.ValueMember = "UB_ID"
        Ubi = Nothing

        Dim nacionalidadBL As New BL.AdmisionBL.SG_AD_TB_NACIONALIDAD
        uce_Nacionalidad.DataSource = nacionalidadBL.getNacionalidades(gInt_IdEmpresa)
        uce_Nacionalidad.DisplayMember = "NA_DESCRIPCION"
        uce_Nacionalidad.ValueMember = "NA_ID"
        nacionalidadBL = Nothing

        Dim documentosBL As New BL.AdmisionBL.SG_AD_TB_TIP_DOC_PER
        uce_tip_doc.DataSource = documentosBL.getTiposDocs(gInt_IdEmpresa)
        uce_tip_doc.DisplayMember = "TD_ABREVIATURA"
        uce_tip_doc.ValueMember = "TD_ID"
        documentosBL = Nothing

        Dim sexoBL As New BL.AdmisionBL.SG_AD_TB_SEXO
        uos_sexo.DataSource = sexoBL.getSexos()
        uos_sexo.ValueMember = "SE_ID"
        uos_sexo.DisplayMember = "SE_DESCRIPCION"
        sexoBL = Nothing

        Dim estcivilBL As New BL.AdmisionBL.SG_AD_TB_ESTADO_CIVIL
        uce_est_civil.DataSource = estcivilBL.getEstados(gInt_IdEmpresa)
        uce_est_civil.DisplayMember = "EC_DESCRIPCION"
        uce_est_civil.ValueMember = "EC_ID"
        estcivilBL = Nothing

        Dim DepaBL As New BL.ContabilidadBL.SG_CO_TB_DEPARTAMENTO
        uce_Departamento.DataSource = DepaBL.getDepartamentos()
        uce_Departamento.ValueMember = "DE_ID"
        uce_Departamento.DisplayMember = "DE_DESCRIPCION"
        DepaBL = Nothing

        Dim uBIGEOBL As New BL.AdmisionBL.SG_AD_TB_UBIGEO
        bsProvincias.DataSource = uBIGEOBL.getProvincias()
        bsProvincias.Filter = String.Format("DEPARTAMENTO = '{0}'", uce_Departamento.Value)
        uce_Provincia.DataSource = bsProvincias
        uce_Provincia.ValueMember = "PR_CODIGO"
        uce_Provincia.DisplayMember = "PR_DESCRIPCION"

        bsDistritos.DataSource = uBIGEOBL.getUbigeo()
        bsDistritos.Filter = String.Format("PROVINCIA = '{0}'", uce_Provincia.Value)
        uce_Ubigeo.DataSource = bsDistritos
        uce_Ubigeo.DisplayMember = "UB_DESCRIPCION"
        uce_Ubigeo.ValueMember = "UB_CODIGO"
        uBIGEOBL = Nothing

        Dim CondiAseg As New BL.AdmisionBL.SG_AD_TB_CONDICION_ASEGURADO
        Dim obj As New DataTable
        CondiAseg.SEL02(obj)
        ucb_Condicion.DataSource = obj
        ucb_Condicion.DisplayMember = "CA_NOMBRE"
        ucb_Condicion.ValueMember = "CA_ID"
        CondiAseg = Nothing

        Dim Recomenda As New BL.AdmisionBL.SG_AD_TB_RECOMENDADO
        Dim obj2 As New DataTable
        Recomenda.SEL02(obj2)
        ucb_recomendado.DataSource = obj2
        ucb_recomendado.DisplayMember = "RE_NOMBRE"
        ucb_recomendado.ValueMember = "RE_ID"
        Recomenda = Nothing

        Dim GrupoSan As New BL.AdmisionBL.SG_AD_TB_GrupoSanguineo
        Dim obj3 As New DataTable
        GrupoSan.SEL02(obj3)
        ucb_GrupoS.DataSource = obj3
        ucb_GrupoS.DisplayMember = "GS_NOMBRE"
        ucb_GrupoS.ValueMember = "GS_ID"
        GrupoSan = Nothing

        Dim medicosBL As New BL.AdmisionBL.SG_AD_TB_MEDICO
        ucb_MedicoT.DataSource = medicosBL.get_Medicos(gInt_IdEmpresa)
        ucb_MedicoT.ValueMember = "ME_CODIGO"
        ucb_MedicoT.DisplayMember = "NOMBRES"
        medicosBL = Nothing

        Dim servicioBL As New BL.AdmisionBL.SG_AD_TB_SERVICIO_MEDICO
        ucb_TipoHC.DataSource = servicioBL.get_Servicios(gInt_IdEmpresa)
        ucb_TipoHC.ValueMember = "SM_ID"
        ucb_TipoHC.DisplayMember = "SM_DESCRIPCION"
        servicioBL = Nothing

    End Sub

    Private Sub Inicializa()
        '.HC_ALERGIAS = utxt_Alergias.Text
        '.HC_IDGRUPO_S = ucb_GrupoS.Value
        '.HC_IDCONDICION = ucb_Condicion.Value
        '.HC_IDMEDICO = ucb_MedicoT.Value
        '.HC_IDRECOMENDACION = ucb_recomendado.Value
        '.HC_TITULAR = utxt_Titular.Text
        '.HC_UBICACION = utxt_Ubicacion.Text
        '.HC_FNAC_TITU = udte_fec_NacTitular.Value


        Call Limpiar_Controls_InGroupox(ugb_datos)
        Call Limpiar_Controls_InGroupox(ugb_codigos)

        If uce_est_civil.Items.Count > 0 Then uce_est_civil.SelectedIndex = 0
        If uce_Nacionalidad.Items.Count > 0 Then uce_Nacionalidad.SelectedIndex = 0
        If uce_tip_doc.Items.Count > 0 Then uce_tip_doc.SelectedIndex = 0
        If ucb_Condicion.Items.Count > 0 Then ucb_Condicion.SelectedIndex = 0
        'If ucb_GrupoS.Items.Count > 0 Then ucb_GrupoS.SelectedIndex = 0
        'If ucb_recomendado.Items.Count > 0 Then ucb_recomendado.SelectedIndex = 0
        'If ucb_MedicoT.Items.Count > 0 Then ucb_MedicoT.SelectedIndex = 0

        apepat = ""
        Docu = ""
        apemat = ""
        apecas = ""
        nombre = ""
        historia = ""

        uck_ApePat.Checked = True
        uck_ApeMat.Checked = False
        uck_ApeCas.Checked = False
        uck_Nombres.Checked = False
        uck_Historia.Checked = False
        uck_Doc.Checked = False
        txt_ApePat.Text = ""
        utxt_ApeMat.Text = ""
        utxt_Nombres.Text = ""
        utxt_ApeCas.Text = ""
        utxt_Historia.Text = ""
        utxt_Documento.Text = ""

        txt_ApePat.Enabled = True
        utxt_ApeMat.Enabled = False
        utxt_Nombres.Enabled = False
        utxt_ApeCas.Enabled = False
        utxt_Historia.Enabled = False
        utxt_Documento.Enabled = False

        uce_Departamento.Value = 15
        uce_Provincia.SelectedIndex = 0
        uce_Ubigeo.SelectedIndex = 0
        uds_Comunicaciones.Rows.Clear()
        ug_Comunicacion.DataSource = uds_Comunicaciones

        udte_fec_NacTitular.Value = ""
        udte_fec_nac.Value = ""
        udte_fec_reg.Value = Now

        ucb_TipoHC.Value = 2

        uce_Departamento.BackColor = Color.White
        uce_Provincia.BackColor = Color.White
        uce_Ubigeo.BackColor = Color.White
        udte_fec_reg.BackColor = Color.White
        udte_fec_nac.BackColor = Color.White
        txt_ape_pat.BackColor = Color.White
        txt_ape_mat.BackColor = Color.White
        txt_nom1.BackColor = Color.White
        uce_Nacionalidad.BackColor = Color.White
        uce_est_civil.BackColor = Color.White
        uce_tip_doc.BackColor = Color.White
        txt_num_doc.BackColor = Color.White


        ''uce_Departamento.SelectedIndex =
        'uce_Provincia.BackColor = Color.White
        'uce_Ubigeo.BackColor = Color.White
    End Sub

    Private Sub pLoad() Handles MyBase.Load
        Call Inicializar_Estado_Botones_Tool(ToolS_Mantenimiento)
        Call MostrarTabs(0, utc_historia, 0)
        ToolS_Mantenimiento.Items("Tool_Imprimir").Enabled = False

        Call Cargar_Combos()

        obe = New BE.AdmisionBE.SG_AD_TB_HISTO_CLINI
        obr = New BL.AdmisionBL.SG_AD_TB_HISTO_CLINI

        Me.KeyPreview = True

        Call Formatear_Grilla_Selector(ug_Lista_Hist_Clin)
        Call Inicializa()

        cargar_datos()

        Dim ComunicacionBL As New BL.FacturacionBL.SG_FA_TB_TIPO_COMUNICACION
        Call CrearComboGrid("CODIGO", "TC_DESCRIPCION", ug_Comunicacion, ComunicacionBL.getTipos(gInt_IdEmpresa), True)
        ComunicacionBL = Nothing

        ubtn_Consultar.Appearance.Image = My.Resources._16__Search_
        ubt_Reniec.Appearance.Image = My.Resources._104
        ubtn_Consultar.Appearance.ImageHAlign = Infragistics.Win.HAlign.Left


    End Sub

    Private Sub Editar()
        If ug_Lista_Hist_Clin.Rows.Count <= 0 Then Exit Sub
        lNew = False

        Call Inicializar_Estado_Botones_Tool(ToolS_Mantenimiento)
        Call Cambiar_Estado_Botones_Tool(ToolS_Mantenimiento)
        Call Bloquear_Controls_InGroupox(ugb_datos, True)

        ToolS_Mantenimiento.Items("Tool_Imprimir").Enabled = Not ToolS_Mantenimiento.Items("Tool_Imprimir").Enabled
        txt_num_histo.Text = ug_Lista_Hist_Clin.ActiveRow.Cells(0).Value
        txt_cod_id.Text = ug_Lista_Hist_Clin.ActiveRow.Cells(1).Value.ToString
        txt_NombreC.Text = ug_Lista_Hist_Clin.ActiveRow.Cells(2).Value
        txt_ape_pat.Text = ug_Lista_Hist_Clin.ActiveRow.Cells(3).Value
        txt_ape_mat.Text = ug_Lista_Hist_Clin.ActiveRow.Cells(4).Value
        txt_ape_cas.Text = ug_Lista_Hist_Clin.ActiveRow.Cells(5).Value
        txt_nom1.Text = ug_Lista_Hist_Clin.ActiveRow.Cells(6).Value
        txt_nom2.Text = ug_Lista_Hist_Clin.ActiveRow.Cells(7).Value
        uce_tip_doc.Value = ug_Lista_Hist_Clin.ActiveRow.Cells(8).Value
        txt_num_doc.Text = ug_Lista_Hist_Clin.ActiveRow.Cells(9).Value
        udte_fec_nac.Value = ug_Lista_Hist_Clin.ActiveRow.Cells(10).Value
        udte_fec_reg.Value = ug_Lista_Hist_Clin.ActiveRow.Cells(11).Value
        uos_sexo.Value = ug_Lista_Hist_Clin.ActiveRow.Cells(12).Value
        uce_est_civil.Value = ug_Lista_Hist_Clin.ActiveRow.Cells(13).Value
        txt_dir.Text = ug_Lista_Hist_Clin.ActiveRow.Cells(14).Value
        txt_ocupacion.Text = ug_Lista_Hist_Clin.ActiveRow.Cells(15).Value
        uce_Nacionalidad.Value = ug_Lista_Hist_Clin.ActiveRow.Cells(16).Value

        uce_Departamento.Value = Mid(ug_Lista_Hist_Clin.ActiveRow.Cells(17).Value.ToString, 1, 2)
        uce_Provincia.Value = Mid(ug_Lista_Hist_Clin.ActiveRow.Cells(17).Value.ToString, 1, 4)
        uce_Ubigeo.Value = ug_Lista_Hist_Clin.ActiveRow.Cells(17).Value.ToString

        ucb_GrupoS.Value = ug_Lista_Hist_Clin.ActiveRow.Cells(18).Value
        ucb_Condicion.Value = ug_Lista_Hist_Clin.ActiveRow.Cells(19).Value
        ucb_recomendado.Value = ug_Lista_Hist_Clin.ActiveRow.Cells(20).Value
        ucb_MedicoT.Value = ug_Lista_Hist_Clin.ActiveRow.Cells(21).Value
        udte_fec_NacTitular.Value = ug_Lista_Hist_Clin.ActiveRow.Cells(22).Value
        utxt_Titular.Value = ug_Lista_Hist_Clin.ActiveRow.Cells(23).Value
        utxt_Ubicacion.Value = ug_Lista_Hist_Clin.ActiveRow.Cells(24).Value
        utxt_Alergias.Value = ug_Lista_Hist_Clin.ActiveRow.Cells(25).Value

        ucb_TipoHC.Value = ug_Lista_Hist_Clin.ActiveRow.Cells(26).Value
        utxtEdad.Text = ug_Lista_Hist_Clin.ActiveRow.Cells(27).Value
        utxt_Detalle.Text = ug_Lista_Hist_Clin.ActiveRow.Cells(28).Value

        'If ug_Lista.ActiveRow.Cells(14).Value = "ACTIVO" Then urb_Estado.CheckedIndex = 0 Else urb_Estado.CheckedIndex = 1

        uds_Comunicaciones.Rows.Clear()
        ug_Comunicacion.DataSource = uds_Comunicaciones

        Dim comunicacionesBL As New BL.FacturacionBL.SG_FA_TB_CLIENTE_COMUNI
        Dim comunicacionesBE As New BE.FacturacionBE.SG_FA_TB_CLIENTE_COMUNI
        comunicacionesBE.CC_IDCLIENTE = Val(txt_cod_id.Text)
        Dim dt_tmp As DataTable = comunicacionesBL.get_Comuninicaciones_xId(comunicacionesBE)
        comunicacionesBE = Nothing
        comunicacionesBL = Nothing

        For i As Integer = 0 To dt_tmp.Rows.Count - 1
            ug_Comunicacion.DisplayLayout.Bands(0).AddNew()
            ug_Comunicacion.Rows(i).Cells("Codigo").Value = dt_tmp.Rows(i)("CC_IDCOMUNICA")
            ug_Comunicacion.Rows(i).Cells("Descripcion").Value = dt_tmp.Rows(i)("CC_DESCRIPCION")
            ug_Comunicacion.UpdateData()
        Next
        ug_Comunicacion.DisplayLayout.Bands(0).AddNew()

        Tool_Imprimir.Enabled = False
        Call MostrarTabs(1, utc_historia, 1)
        Me.Text = "Historia Clinica Datos Generales ( EDICION ) "
        lbl_estado.Text = "EDICION"
        txt_ape_pat.Focus()
    End Sub

    Private Sub Consultar()

        If ug_Lista_Hist_Clin.Rows.Count <= 0 Then Exit Sub

        'Call Cambiar_Estado_Botones_Tool(ToolS_Mantenimiento)
        ToolS_Mantenimiento.Items("Tool_Imprimir").Enabled = Not ToolS_Mantenimiento.Items("Tool_Imprimir").Enabled
        txt_num_histo.Text = ug_Lista_Hist_Clin.ActiveRow.Cells(0).Value
        txt_cod_id.Text = ug_Lista_Hist_Clin.ActiveRow.Cells(1).Value.ToString
        txt_NombreC.Text = ug_Lista_Hist_Clin.ActiveRow.Cells(2).Value
        txt_ape_pat.Text = ug_Lista_Hist_Clin.ActiveRow.Cells(3).Value
        txt_ape_mat.Text = ug_Lista_Hist_Clin.ActiveRow.Cells(4).Value
        txt_ape_cas.Text = ug_Lista_Hist_Clin.ActiveRow.Cells(5).Value
        txt_nom1.Text = ug_Lista_Hist_Clin.ActiveRow.Cells(6).Value
        txt_nom2.Text = ug_Lista_Hist_Clin.ActiveRow.Cells(7).Value
        uce_tip_doc.Value = ug_Lista_Hist_Clin.ActiveRow.Cells(8).Value
        txt_num_doc.Text = ug_Lista_Hist_Clin.ActiveRow.Cells(9).Value
        udte_fec_nac.Value = ug_Lista_Hist_Clin.ActiveRow.Cells(10).Value
        udte_fec_reg.Value = ug_Lista_Hist_Clin.ActiveRow.Cells(11).Value
        uos_sexo.Value = ug_Lista_Hist_Clin.ActiveRow.Cells(12).Value
        uce_est_civil.Value = ug_Lista_Hist_Clin.ActiveRow.Cells(13).Value
        txt_dir.Text = ug_Lista_Hist_Clin.ActiveRow.Cells(14).Value
        txt_ocupacion.Text = ug_Lista_Hist_Clin.ActiveRow.Cells(15).Value
        uce_Nacionalidad.Value = ug_Lista_Hist_Clin.ActiveRow.Cells(16).Value

        uce_Departamento.Value = Mid(ug_Lista_Hist_Clin.ActiveRow.Cells(17).Value.ToString, 1, 2)
        uce_Provincia.Value = Mid(ug_Lista_Hist_Clin.ActiveRow.Cells(17).Value.ToString, 1, 4)
        uce_Ubigeo.Value = ug_Lista_Hist_Clin.ActiveRow.Cells(17).Value.ToString

        ucb_GrupoS.Value = ug_Lista_Hist_Clin.ActiveRow.Cells(18).Value
        ucb_Condicion.Value = ug_Lista_Hist_Clin.ActiveRow.Cells(19).Value
        ucb_recomendado.Value = ug_Lista_Hist_Clin.ActiveRow.Cells(20).Value
        ucb_MedicoT.Value = ug_Lista_Hist_Clin.ActiveRow.Cells(21).Value
        udte_fec_NacTitular.Value = ug_Lista_Hist_Clin.ActiveRow.Cells(22).Value
        utxt_Titular.Value = ug_Lista_Hist_Clin.ActiveRow.Cells(23).Value
        utxt_Ubicacion.Value = ug_Lista_Hist_Clin.ActiveRow.Cells(24).Value
        utxt_Alergias.Value = ug_Lista_Hist_Clin.ActiveRow.Cells(25).Value

        ucb_TipoHC.Value = ug_Lista_Hist_Clin.ActiveRow.Cells(26).Value
        utxtEdad.Text = ug_Lista_Hist_Clin.ActiveRow.Cells(27).Value
        utxt_Detalle.Text = ug_Lista_Hist_Clin.ActiveRow.Cells(28).Value


        'If ug_Lista.ActiveRow.Cells(14).Value = "ACTIVO" Then urb_Estado.CheckedIndex = 0 Else urb_Estado.CheckedIndex = 1

        uds_Comunicaciones.Rows.Clear()
        ug_Comunicacion.DataSource = uds_Comunicaciones

        Dim comunicacionesBL As New BL.FacturacionBL.SG_FA_TB_CLIENTE_COMUNI
        Dim comunicacionesBE As New BE.FacturacionBE.SG_FA_TB_CLIENTE_COMUNI
        comunicacionesBE.CC_IDCLIENTE = Val(txt_cod_id.Text)
        Dim dt_tmp As DataTable = comunicacionesBL.get_Comuninicaciones_xId(comunicacionesBE)
        comunicacionesBE = Nothing
        comunicacionesBL = Nothing

        For i As Integer = 0 To dt_tmp.Rows.Count - 1
            ug_Comunicacion.DisplayLayout.Bands(0).AddNew()
            ug_Comunicacion.Rows(i).Cells("Codigo").Value = dt_tmp.Rows(i)("CC_IDCOMUNICA")
            ug_Comunicacion.Rows(i).Cells("Descripcion").Value = dt_tmp.Rows(i)("CC_DESCRIPCION")
            ug_Comunicacion.UpdateData()
        Next
        ug_Comunicacion.DisplayLayout.Bands(0).AddNew()


        Call MostrarTabs(1, utc_historia, 1)
        'txt_ape_pat.Focus()

        Call Bloquear_Controls_InGroupox(ugb_datos, False)
        Call Cambiar_Estado_Botones_Tool(ToolS_Mantenimiento)
        Tool_Imprimir.Enabled = False
        Tool_Grabar.Enabled = False
        Tool_Editar.Enabled = True
        Me.Text = "Historia Clinica Datos Generales ( CONSULTA ) "
        lbl_estado.Text = "CONSULTAR"

    End Sub

    Private Sub Tool_Nuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_Nuevo.Click
        Call Cambiar_Estado_Botones_Tool(ToolS_Mantenimiento)
        Call Bloquear_Controls_InGroupox(ugb_datos, True)
        ToolS_Mantenimiento.Items("Tool_Imprimir").Enabled = Not ToolS_Mantenimiento.Items("Tool_Imprimir").Enabled
        Call MostrarTabs(1, utc_historia, 1)
        Inicializa()
        lNew = True
        Me.Text = "Historia Clinica Datos Generales ( NUEVO ) "
        lbl_estado.Text = "NUEVO"
        Tool_Imprimir.Enabled = False
        txt_ape_pat.Focus()

    End Sub

    Private Sub Tool_Cancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_Cancelar.Click
        'Call Cambiar_Estado_Botones_Tool(ToolS_Mantenimiento)
        Call Inicializar_Estado_Botones_Tool(ToolS_Mantenimiento)
        Tool_Imprimir.Enabled = True
        Tool_Editar.Enabled = True
        Tool_Eliminar.Enabled = True
        Me.Text = "Historia Clinica Datos Generales"
        Call MostrarTabs(0, utc_historia, 0)
    End Sub

    Private Sub Tool_Grabar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_Grabar.Click
        If fValida() = False Then Exit Sub

        With obe
            .HC_APE_PAT = txt_ape_pat.Text.Trim
            .HC_APE_MAT = txt_ape_mat.Text.Trim
            .HC_NOMBRE1 = txt_nom1.Text.Trim
            .HC_NOMBRE2 = txt_nom2.Text.Trim
            .HC_APE_CASADA = txt_ape_cas.Text.Trim
            .HC_TDOC = uce_tip_doc.Value
            .HC_NDOC = txt_num_doc.Text
            .HC_FNAC = udte_fec_nac.Value
            .HC_FING = udte_fec_reg.Value
            .HC_SEXO = uos_sexo.Value
            .HC_EST_CIVIL = uce_est_civil.Value
            .HC_DIR = txt_dir.Text
            .HC_OCUPACION = txt_ocupacion.Text.Trim
            .HC_IDNACIONALIDAD = uce_Nacionalidad.Value
            .HC_IDEMPRESA = gInt_IdEmpresa
            .HC_UBIGEO = uce_Ubigeo.Value
            .HC_TERMINAL = Environment.MachineName
            .HC_USUARIO = String.Format("{0}-{1}", Environment.UserName, gStr_Usuario_Sis)
            .HC_ALERGIAS = utxt_Alergias.Text
            .HC_IDGRUPO_S = ucb_GrupoS.Value
            .HC_IDCONDICION = ucb_Condicion.Value
            .HC_IDMEDICO = ucb_MedicoT.Value
            .HC_IDRECOMENDACION = ucb_recomendado.Value
            .HC_TITULAR = utxt_Titular.Text
            .HC_UBICACION = utxt_Ubicacion.Value
            .HC_FNAC_TITU = IIf(udte_fec_NacTitular.Value = Nothing, Now.Date, udte_fec_NacTitular.Value)
            .HC_TIPO_H_C = ucb_TipoHC.Value
            .HC_EDAD_REG = Val(utxtEdad.Text)
            .HC_DetRecom = utxt_Detalle.Text
        End With

        ug_Comunicacion.UpdateData()

        Dim ls_comunica As New List(Of BE.FacturacionBE.SG_FA_TB_CLIENTE_COMUNI)

        For i As Integer = 0 To ug_Comunicacion.Rows.Count - 1
            If ug_Comunicacion.Rows(i).Cells("Descripcion").Value.ToString.Length > 0 Then
                ls_comunica.Add(New BE.FacturacionBE.SG_FA_TB_CLIENTE_COMUNI With {.CC_IDCLIENTE = Val(txt_cod_id.Text), .CC_IDCOMUNICA = ug_Comunicacion.Rows(i).Cells("Codigo").Value, .CC_DESCRIPCION = ug_Comunicacion.Rows(i).Cells("Descripcion").Value.ToString})
            End If
        Next

        If lNew Then
            Dim I As Integer
            I = obr.Insert(obe, String.Format("{0}-{1}", Environment.UserName, gStr_Usuario_Sis), Environment.MachineName, ls_comunica)
            txt_cod_id.Text = I
            If I < 0 Then
                Dim drr_MOV As System.Data.SqlClient.SqlDataReader
                drr_MOV = obr.SEL05(obe, gInt_IdEmpresa)
                If drr_MOV.HasRows Then
                    drr_MOV.Read()
                    MessageBox.Show("Paciente Ya Existe, Verificar Datos Duplicados. Nº Historia " & drr_MOV("HC_NUM_HIST"), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Else
                    MessageBox.Show("La operación solicitada no ha podido ser realizada", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
                drr_MOV.Close()
                Exit Sub
            End If
            Else
                obe.HC_NUM_HIST = txt_num_histo.Text
                obe.HC_IDCLIENTE = Val(txt_cod_id.Text)
                If obr.Update(obe, String.Format("{0}-{1}", Environment.UserName, gStr_Usuario_Sis), Environment.MachineName, ls_comunica) < 0 Then
                    MessageBox.Show("Datos Existen en Otro Paciente, Verificar Datos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Exit Sub
                End If
            End If

        Call Avisar("Listo!")
        Call cargar_datos()
        Call Cambiar_Estado_Botones_Tool(ToolS_Mantenimiento)

        ToolS_Mantenimiento.Items("Tool_Imprimir").Enabled = Not ToolS_Mantenimiento.Items("Tool_Imprimir").Enabled

        Call Tool_Nuevo_Click(sender, e)
        'ToolS_Mantenimiento.Items("Tool_").Enabled = True
    End Sub

    Private Sub Tool_Editar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_Editar.Click
        Call Editar()
    End Sub

    Private Sub Tool_Eliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_Eliminar.Click
        If ug_Lista_Hist_Clin.Rows.Count <= 0 Then Exit Sub
        If ug_Lista_Hist_Clin.ActiveRow.Cells(0).Value = 0 Then Exit Sub
        If Preguntar("Seguro de Eliminar?") Then
            obe.HC_NUM_HIST = ug_Lista_Hist_Clin.ActiveRow.Cells(0).Value
            obe.HC_IDEMPRESA = gInt_IdEmpresa

            If obr.Delete(obe, String.Format("{0}-{1}", Environment.UserName, gStr_Usuario_Sis), Environment.MachineName) < 0 Then
                MessageBox.Show("La operación solicitada no ha podido ser realizada", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                Call Avisar("Listo!")
                cargar_datos()
            End If
        End If
    End Sub

    Private Sub Tool_Salir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_Salir.Click
        Me.Close()
    End Sub

    Private Sub pFormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If Tool_Grabar.Enabled = True Then
            MessageBox.Show("Culmine ó cancele la transacción activa !!!", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
            e.Cancel = True
        Else
            obe = Nothing
            obr = Nothing
            e.Cancel = False
        End If
    End Sub

    Private Sub ug_Lista_Hist_Clin_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ug_Lista_Hist_Clin.DoubleClick
        Call Consultar()
    End Sub

    'Private Sub uos_sexo_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles uos_sexo.KeyDown
    '    If e.KeyCode = Keys.Enter Then
    '        uce_est_civil.Focus()
    '    End If
    'End Sub

    Private Sub uce_Departamento_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles uce_Departamento.ValueChanged
        Try
            'txtIdDepartamento.Text = cboIdDepartamento.SelectedValue
            bsProvincias.Filter = String.Format("DEPARTAMENTO = '{0}'", uce_Departamento.Value)
        Catch ex As Exception
            Select Case ex.Message
                Case "La conversión del tipo 'DataRowView' en el tipo 'String' no es válida."
                Case Else
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Select
        End Try
    End Sub

    Private Sub uce_Provincia_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles uce_Provincia.ValueChanged
        Try
            bsDistritos.Filter = String.Format("PROVINCIA = '{0}'", uce_Provincia.Value)
        Catch ex As Exception
            Select Case ex.Message
                Case "La conversión del tipo 'DataRowView' en el tipo 'String' no es válida."
                Case Else
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Select
        End Try
    End Sub

 
    Private Sub validar()
        If uck_ApePat.Checked = True Then
            apepat = " AND HC_APE_PAT like '" & txt_ApePat.Text & "%'"
        Else
            apepat = ""
        End If
        If uck_ApeMat.Checked = True Then
            apemat = " AND HC_APE_MAT like '" & utxt_ApeMat.Text & "%'"
        Else
            apemat = ""
        End If
        If uck_ApeCas.Checked = True Then
            apecas = " AND HC_APE_CASADA like '" & utxt_ApeCas.Text & "%'"
        Else
            apecas = ""
        End If
        If uck_Nombres.Checked = True Then
            nombre = " AND HC_NOMBRE1 +' '+ HC_NOMBRE2 like '%" & utxt_Nombres.Text & "%'"
        Else
            nombre = ""
        End If
        If uck_Historia.Checked = True Then
            historia = " AND HC_NUM_HIST like '" & utxt_Historia.Text & "%'"
        Else
            historia = ""
        End If
        If uck_Doc.Checked = True Then
            Docu = " AND HC_NDOC like '" & utxt_Documento.Text & "%'"
        Else
            Docu = ""
        End If
    End Sub

    Private Sub cargar_datos()
        validar()
        Dim obj As New DataTable
        obe.HC_IDEMPRESA = gInt_IdEmpresa
        obr.SEL01(obe, apepat, apemat, apecas, nombre, historia, Docu, obj)
        ug_Lista_Hist_Clin.DataSource = obj

    End Sub

    Private Sub ubtn_Consultar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ubtn_Consultar.Click
       cargar_datos()
    End Sub
    Private Sub consul(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_ApePat.KeyDown, utxt_ApeMat.KeyDown, utxt_ApeCas.KeyDown, utxt_Nombres.KeyDown, utxt_Historia.KeyDown, utxt_Documento.KeyDown
        If e.KeyCode = Keys.Enter Then
            Call cargar_datos()
        End If
    End Sub
    Private Sub uck_ApePat_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles uck_ApePat.CheckedChanged
        If uck_ApePat.Checked = True Then
            txt_ApePat.Enabled = True
            apepat = " AND HC_APE_PAT like '" & txt_ApePat.Text & "%'"
            txt_ApePat.Focus()
        Else
            txt_ApePat.Enabled = False
            txt_ApePat.Text = ""
            apepat = ""
        End If
    End Sub
    Private Sub uck_ApeMat_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles uck_ApeMat.CheckedChanged
        If uck_ApeMat.Checked = True Then
            utxt_ApeMat.Enabled = True
            apemat = " AND HC_APE_MAT like '" & utxt_ApeMat.Text & "%'"
            utxt_ApeMat.Focus()
        Else
            utxt_ApeMat.Enabled = False
            utxt_ApeMat.Text = ""
            apemat = ""
        End If
    End Sub
    Private Sub uck_ApeCas_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles uck_ApeCas.CheckedChanged
        If uck_ApeCas.Checked = True Then
            utxt_ApeCas.Enabled = True
            apecas = " AND HC_APE_CASADA like '" & utxt_ApeCas.Text & "%'"
            utxt_ApeCas.Focus()
        Else
            utxt_ApeCas.Enabled = False
            utxt_ApeCas.Text = ""
            apecas = ""
        End If
    End Sub
    Private Sub uck_Nombres_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles uck_Nombres.CheckedChanged
        If uck_Nombres.Checked = True Then
            utxt_Nombres.Enabled = True
            nombre = " AND HC_NOMBRE1 +' '+ HC_NOMBRE2 like '%" & utxt_Nombres.Text & "%'"
            utxt_Nombres.Focus()
        Else
            utxt_Nombres.Enabled = False
            utxt_Nombres.Text = ""
            nombre = ""
        End If
    End Sub
    Private Sub uck_Historia_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles uck_Historia.CheckedChanged
        If uck_Historia.Checked = True Then
            utxt_Historia.Enabled = True
            historia = " AND HC_NUM_HIST like '" & utxt_Historia.Text & "%'"
            utxt_Historia.Focus()
        Else
            utxt_Historia.Enabled = False
            utxt_Historia.Text = ""
            historia = ""
        End If
    End Sub
    Private Sub uck_Doc_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles uck_Doc.CheckedChanged
        If uck_Doc.Checked = True Then
            utxt_Documento.Enabled = True
            Docu = " AND HC_NDOC like '" & utxt_Documento.Text & "%'"
            utxt_Documento.Focus()
        Else
            utxt_Documento.Enabled = False
            utxt_Documento.Text = ""
            Docu = ""
        End If
    End Sub

    Private Sub ug_Comunicacion_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles ug_Comunicacion.KeyDown
        If e.KeyCode = Keys.Enter Then
            With ug_Comunicacion
                Select Case ug_Comunicacion.ActiveRow.Cells(ug_Comunicacion.ActiveCell.Column.Index).Column.Key
                    Case "Codigo"
                        .PerformAction(UltraGridAction.NextCellByTab, False, False)
                    Case "Descripcion"
                        .PerformAction(UltraGridAction.NextCellByTab, False, False)
                        '.PerformAction(UltraGridAction.NextCellByTab, False, False)
                End Select
            End With
        End If
    End Sub

    Private Sub Tool_Imprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_Imprimir.Click
        If ug_Lista_Hist_Clin.Rows.Count <= 0 Then Exit Sub
        Me.Cursor = Cursors.WaitCursor

        Dim nom_reporte As String = "SG_AD_01.RPT"
        Dim crystalBL As New LR.ClsReporte
        Dim dt_data As New DataTable ' = reportesBL.get_Comprobante(idComprobante, gInt_IdEmpresa)

        Dim Telefono As String = ""
        Dim Celular As String = ""
        Dim Edad As String = Int(DateDiff("m", udte_fec_nac.Value, Date.Now) / 12)
        Dim EdadT As String = Int(DateDiff("m", udte_fec_NacTitular.Value, Date.Now) / 12)


        For i As Integer = 0 To ug_Comunicacion.Rows.Count - 2
            If ug_Comunicacion.Rows(i).Cells("Codigo").Value = "1" Then Telefono = ug_Comunicacion.Rows(i).Cells("Descripcion").Value
            If ug_Comunicacion.Rows(i).Cells("Codigo").Value = "2" Then Celular = ug_Comunicacion.Rows(i).Cells("Descripcion").Value
        Next

        crystalBL.Muestra_Reporte(gStr_RutaRep & "\" & nom_reporte, dt_data, "", "pApePat;" & txt_ape_pat.Text, _
                                  "pApeMat;" & txt_ape_mat.Text, "pNombres;" & txt_nom1.Text & " " & txt_nom2.Text, "pHC;" & Format(Val(txt_num_histo.Text), "0000000000#") _
                                  , "pDomicilio;" & txt_dir.Text, "pTelefono;" & Telefono, "pOcupacion;" & txt_ocupacion.Text _
                                  , "pDNI;" & txt_num_doc.Text, "pFechaNac;" & udte_fec_nac.Text, "pEdad;" & Edad _
                                  , "pEstCivil;" & uce_est_civil.Text, "pSexo;" & IIf(uos_sexo.Value = "F", "Femenino", "Masculino"), "pNacionalidad;" & uce_Nacionalidad.Text _
                                  , "pTitular;" & utxt_Titular.Text & " " & udte_fec_NacTitular.Text, "pEdadT;" & EdadT, "pCelular;" & Celular _
                                  , "pGrupoS;" & ucb_GrupoS.Text, "pMedico;" & ucb_MedicoT.Text, "pFechaAd;" & Now.Date _
                                  , "pHoraAd;" & Now.ToString("hh:mm:ss"), "pUsu;" & String.Format("{0}-{1}", Environment.UserName, gStr_Usuario_Sis))


        crystalBL = Nothing
        ' reportesBL = Nothing

        Me.Cursor = Cursors.Default
    End Sub

    Private Sub udte_fec_nac_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles udte_fec_nac.Leave
        utxtEdad.Value = Int(DateDiff("m", udte_fec_nac.Value, Date.Now) / 12)
    End Sub

    Private Sub ubt_Reniec_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ubt_Reniec.Click
        txt_nom1.Text = ""
        txt_nom2.Text = ""
        txt_ape_mat.Text = ""
        txt_ape_pat.Text = ""
        Dim drr_MOV As System.Data.SqlClient.SqlDataReader
        drr_MOV = obr.SEL06(txt_num_doc.Text.Trim)
        If drr_MOV.HasRows Then
            drr_MOV.Read()

            txt_ape_pat.Text = drr_MOV("AP_PAT")
            txt_ape_mat.Text = drr_MOV("AP_MAT")
            Dim texto() As String = Split(drr_MOV("nombre"), " ")
            Dim i As Integer
            For i = 0 To UBound(texto)
                If i = 0 Then
                    txt_nom1.Text = texto(i)
                Else
                    If txt_nom2.Text = "" Then
                        txt_nom2.Text = texto(i)
                    Else
                        txt_nom2.Text = txt_nom2.Text & " " & texto(i)
                    End If
                End If
            Next
            udte_fec_nac.Value = drr_MOV("FNAC2")
            uos_sexo.Value = IIf(drr_MOV("SEXO") = 0, "F", "M")
            utxtEdad.Value = Int(DateDiff("m", udte_fec_nac.Value, Date.Now) / 12)
            'uce_Departamento.Value = Mid(drr_MOV("UBIGEO").ToString, 1, 2)
            'uce_Provincia.Value = Mid(drr_MOV("UBIGEO").ToString, 1, 4)
            'uce_Ubigeo.Value = drr_MOV("UBIGEO").ToString

        End If
        drr_MOV.Close()

    End Sub

    Private Sub ucb_recomendado_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ucb_recomendado.ValueChanged
        If ucb_recomendado.Value = 1 Or ucb_recomendado.Value = 7 Or ucb_recomendado.Value = 8 Then
            utxt_Detalle.Enabled = True
        Else
            utxt_Detalle.Enabled = False
        End If
    End Sub
End Class