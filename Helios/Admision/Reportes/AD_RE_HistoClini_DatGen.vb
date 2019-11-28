Imports Infragistics.Win.UltraWinGrid
Public Class AD_RE_HistoClini_DatGen
    Private obe As BE.AdmisionBE.SG_AD_TB_HISTO_CLINI
    Private obr As BL.AdmisionBL.SG_AD_TB_HISTO_CLINI
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
        Call MostrarTabs(0, utc_historia, 0)
        Call Cargar_Combos()

        obe = New BE.AdmisionBE.SG_AD_TB_HISTO_CLINI
        obr = New BL.AdmisionBL.SG_AD_TB_HISTO_CLINI

        Me.KeyPreview = True

        Call Formatear_Grilla_Selector(ug_Lista_Hist_Clin)
        Call Inicializa()

        validar()
        Dim obj As New DataTable
        obe.HC_IDEMPRESA = gInt_IdEmpresa
        obr.SEL01(obe, apepat, apemat, apecas, nombre, historia, Docu, obj)
        ug_Lista_Hist_Clin.DataSource = obj


        Dim ComunicacionBL As New BL.FacturacionBL.SG_FA_TB_TIPO_COMUNICACION
        Call CrearComboGrid("CODIGO", "TC_DESCRIPCION", ug_Comunicacion, ComunicacionBL.getTipos(gInt_IdEmpresa), True)
        ComunicacionBL = Nothing

        ubtn_Consultar.Appearance.Image = My.Resources._16__Search_
        ubtn_Consultar.Appearance.ImageHAlign = Infragistics.Win.HAlign.Left


    End Sub

    Private Sub Tool_Cancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_Cancelar.Click
        ' Call Cambiar_Estado_Botones_Tool(ToolS_Mantenimiento)
        Inicializa()
        Call MostrarTabs(0, utc_historia, 0)
    End Sub

    Private Sub Tool_Salir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_Salir.Click
        Me.Close()
    End Sub

    Private Sub ug_Lista_Hist_Clin_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ug_Lista_Hist_Clin.DoubleClick
        If ug_Lista_Hist_Clin.Rows.Count <= 0 Then Exit Sub

        'Call Bloquear_Controls_InGroupox(ugb_datos, True)

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
        txt_ape_pat.Focus()

    End Sub

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


    Private Sub ubtn_Consultar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ubtn_Consultar.Click
        validar()
        Dim obj As New DataTable
        obe.HC_IDEMPRESA = gInt_IdEmpresa
        obr.SEL01(obe, apepat, apemat, apecas, nombre, historia, Docu, obj)
        ug_Lista_Hist_Clin.DataSource = obj
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


    Private Sub uck_ApePat_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles uck_ApePat.CheckedChanged
        If uck_ApePat.Checked = True Then
            txt_ApePat.Enabled = True
            apepat = " AND HC_APE_PAT like '" & txt_ApePat.Text & "%'"
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
        Else
            utxt_Documento.Enabled = False
            utxt_Documento.Text = ""
            Docu = ""
        End If
    End Sub

End Class