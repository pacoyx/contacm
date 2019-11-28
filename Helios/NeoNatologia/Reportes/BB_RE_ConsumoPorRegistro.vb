Public Class BB_RE_ConsumoPorRegistro
    Private Sub pKeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles MyBase.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Return) Then
            SendKeys.Send("{TAB}")
            e.Handled = True
        End If
    End Sub

    Private Sub Inicializa()
        Call LimpiaGrid(ug_ListaFar, uds_ListaFar)
        Call LimpiaGrid(ug_ListaFac, uds_ListaFac)
        Call LimpiaGrid(ug_ListaLog, uds_ListaLog)
        Call LimpiaGrid(ug_ListaUbi, uds_ListaUbi)
        txt_IdRegistro.BackColor = Color.White
        txt_IdRegistro.Text = ""
        txt_bebe.Text = ""
        txt_madre.Text = ""
        txt_diag.Text = ""
        uce_Medico.SelectedIndex = 0
        dtp_FechaIngreso.Value = Now
        udtp_fechaAlta.Value = Nothing
        lbl_estado.Text = ""
    End Sub

    Private Sub BB_RE_ConsumoPorCuenta_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.KeyPreview = True

        Dim medicosBL As New BL.AdmisionBL.SG_AD_TB_MEDICO
        uce_Medico.DataSource = medicosBL.get_Medicos(gInt_IdEmpresa)
        uce_Medico.ValueMember = "ME_CODIGO"
        uce_Medico.DisplayMember = "NOMBRES"
        medicosBL = Nothing
        txt_IdRegistro.ButtonsRight(0).Appearance.Image = My.Resources._104

        Inicializa()
    End Sub

    Private Sub Ayuda_Anexo_Registro()
        BB_RE_ListaRegistro.ShowDialog()

        Dim matriz As List(Of String) = BB_RE_ListaRegistro.GetLista

        If matriz.Count > 0 Then
            txt_IdRegistro.Text = matriz(0)
            txt_bebe.Text = matriz(1)
            txt_diag.Text = matriz(3)
            txt_madre.Text = matriz(7)
            dtp_FechaIngreso.Value = matriz(8)
            udtp_fechaAlta.Value = matriz(9)
            uce_Medico.Value = matriz(10)

            Dim comproBL As New BL.FacturacionBL.SG_FA_TB_COMPROBANTE_C
            If comproBL.Existe_Comprob_Cuenta(Val(matriz(2))) Then
                lbl_estado.Text = "Facturado"
            Else
                lbl_estado.Text = "Pendiente"
            End If
            comproBL = Nothing
            
            Tool_Consultar_Click(Nothing, Nothing)

        End If

    End Sub

    Private Sub Buscar_Registro()
        Dim obe As New BE.NeoBE.SA_TB_BB_REGISTRO
        Dim obr As New BL.NeoBL.SA_TB_BB_REGISTRO
        obe.RE_ID = Val(txt_IdRegistro.Text)
        Dim drr_RE As System.Data.SqlClient.SqlDataReader
        drr_RE = obr.SEL01(obe)
        If drr_RE.HasRows Then
            drr_RE.Read()

            uce_Medico.Value = drr_RE("RE_IDMEDICO")
            txt_bebe.Text = drr_RE("RE_NOMBRE")
            txt_diag.Text = drr_RE("RE_DIAGNOSTICO")
            txt_madre.Text = drr_RE("RE_MADRE")
            dtp_FechaIngreso.Value = drr_RE("RE_FECHA_INGRESO")
            udtp_fechaAlta.Value = drr_RE("RE_FECHA_ALTA")

            Dim comproBL As New BL.FacturacionBL.SG_FA_TB_COMPROBANTE_C
            If comproBL.Existe_Comprob_Cuenta(Val(drr_RE("RE_IDCUENTA").ToString)) Then
                lbl_estado.Text = "Facturado"
            Else
                lbl_estado.Text = "Pendiente"
            End If
            comproBL = Nothing

            Tool_Consultar_Click(Nothing, Nothing)
        Else
            Avisar("N° de Registro no existe.")
        End If
        drr_RE.Close()

    End Sub



    Private Sub Tool_Consultar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_Consultar.Click
        Call LimpiaGrid(ug_ListaFar, uds_ListaFar)
        Call LimpiaGrid(ug_ListaFac, uds_ListaFac)
        Call LimpiaGrid(ug_ListaLog, uds_ListaLog)
        Call LimpiaGrid(ug_ListaUbi, uds_ListaUbi)

        If txt_IdRegistro.Text = "" Then Exit Sub

        Dim obeConsumo As New BE.NeoBE.SA_TB_BB_CONSUMO
        Dim obrConsumo As New BL.NeoBL.SA_TB_BB_CONSUMO

        obeConsumo.CB_IDREGISTRO = Val(txt_IdRegistro.Text)
        obeConsumo.CB_IDUBICACION = 0
        ug_ListaFac.DataSource = obrConsumo.SEL04(obeConsumo)
        ug_ListaFac.UpdateData()

        obeConsumo.CB_IDREGISTRO = Val(txt_IdRegistro.Text)
        obeConsumo.CB_IDUBICACION = 1
        ug_ListaUbi.DataSource = obrConsumo.SEL04(obeConsumo)
        ug_ListaUbi.UpdateData()

        obeConsumo = Nothing
        obrConsumo = Nothing

        Dim obrfarmacia As New BL.LogisticaBL.SG_LO_TB_CONSUMO_C
        ug_ListaFar.DataSource = obrfarmacia.SEL08(7, Val(txt_IdRegistro.Text))
        ug_ListaFar.UpdateData()
        obrfarmacia = Nothing

        Dim obrLog As New BL.LogisticaBL.SG_LO_TB_REQUERIMIENTO_C
        ug_ListaLog.DataSource = obrLog.SEL05(Val(txt_IdRegistro.Text))
        ug_ListaLog.UpdateData()
        obrLog = Nothing

    End Sub

    Private Sub Tool_Salir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_Salir.Click
        Me.Close()
    End Sub

    Private Sub txt_IdRegistro_EditorButtonClick(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinEditors.EditorButtonEventArgs) Handles txt_IdRegistro.EditorButtonClick
        Select Case e.Button.Key
            Case "ayuda"
                Call Ayuda_Anexo_Registro()
            Case "editar"

        End Select
    End Sub

    Private Sub txt_IdRegistro_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_IdRegistro.KeyDown
        If e.KeyCode = Keys.Enter Or e.KeyCode = Keys.Tab Then
            Call Buscar_Registro()
        End If

        If e.KeyCode = Keys.F2 Then Call Ayuda_Anexo_Registro()
    End Sub

End Class