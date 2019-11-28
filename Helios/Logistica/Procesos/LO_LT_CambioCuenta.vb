Public Class LO_LT_CambioCuenta
    Private Sub pKeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles MyBase.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Return) Then
            SendKeys.Send("{TAB}")
            e.Handled = True
        End If
    End Sub

    Private Sub pKeyPressNumero(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_IdCuenta.KeyPress, txt_idCuentaNueva.KeyPress
        e.KeyChar = fKeyPress(e.KeyChar, sender.Text, 1)
        e.Handled = (e.KeyChar = "")
    End Sub

    Private Sub Inicializa()
        Call LimpiaGrid(ug_data, uds_Lista)
        txt_IdCuenta.BackColor = Color.White
        uce_tip_doc.SelectedIndex = 0
        txt_IdCuenta.Text = ""
        txt_idCuentaNueva.Text = ""
        txt_ruc_cliente.Text = ""
        txt_Des_Cliente.Text = ""
        txt_idHistoria.Text = ""
        'uck_Cubre.Checked = True
        'uck_NoCubre.Checked = True
        lbl_estado.Text = ""
        lbl_estadoNuevo.Text = ""
    End Sub
    Private Sub LO_LT_CambioCuenta_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.KeyPreview = True
        Dim documentoscBL As New BL.AdmisionBL.SG_AD_TB_TIP_DOC_PER
        uce_tip_doc.DataSource = documentoscBL.getTiposDocs(gInt_IdEmpresa)
        uce_tip_doc.DisplayMember = "TD_ABREVIATURA"
        uce_tip_doc.ValueMember = "TD_ID"
        documentoscBL = Nothing

        txt_IdCuenta.ButtonsRight(0).Appearance.Image = My.Resources._104
        txt_idCuentaNueva.ButtonsRight(0).Appearance.Image = My.Resources._104

        Inicializa()


    End Sub

    'Cuenta
    Private Sub Ayuda_Anexo_Cuenta()
        LO_LT_ListaCuentas.TIPO = 0
        LO_LT_ListaCuentas.ShowDialog()

        Dim matriz As List(Of String) = LO_LT_ListaCuentas.GetLista

        If matriz.Count > 0 Then
            txt_IdCuenta.Text = matriz(0)
            Dim comproBL As New BL.FacturacionBL.SG_FA_TB_COMPROBANTE_C
            If comproBL.Existe_Comprob_Cuenta(Val(txt_IdCuenta.Text)) Then
                lbl_estado.Text = "Facturado"
            Else
                lbl_estado.Text = "Pendiente"
            End If
            comproBL = Nothing

            Format(Val(txt_IdCuenta.Text), "0000000000#")
            txt_idHistoria.Value = matriz(3)

            Dim historiaBL As New BL.AdmisionBL.SG_AD_TB_HISTO_CLINI
            Dim dt_histo_tmp As DataTable = historiaBL.getHistorias_Base_x_Id(txt_idHistoria.Value, 1)
            If dt_histo_tmp.Rows.Count > 0 Then
                txt_Des_Cliente.Text = dt_histo_tmp.Rows(0)("HC_APE_PAT") & " " & dt_histo_tmp.Rows(0)("HC_APE_MAT") & " " & dt_histo_tmp.Rows(0)("HC_APE_CASADA") & " " & dt_histo_tmp.Rows(0)("HC_NOMBRE1") & " " & dt_histo_tmp.Rows(0)("HC_NOMBRE2")
                txt_ruc_cliente.Text = dt_histo_tmp.Rows(0)("HC_NDOC")
                uce_tip_doc.Value = dt_histo_tmp.Rows(0)("HC_TDOC")
            End If
            Format(Val(txt_idHistoria.Text), "0000000000#")
            Call LimpiaGrid(ug_data, uds_Lista)
            Consultar()
            ug_data.UpdateData()

        End If

    End Sub

    Private Sub Buscar_Cuenta()
        '  Dim obeT As BE.AdmisionBE.TMP_SG_AD_TB_CUENTA_DET
        Dim obrT As New BL.AdmisionBL.SG_AD_TB_CUENTA_CAB
        Dim obeC As New BE.AdmisionBE.SG_AD_TB_CUENTA_CAB

        obeC.CC_ID = Val(txt_IdCuenta.Text)
        Format(Val(txt_IdCuenta.Text), "0000000000#")
        obeC.HasRow = False
        obrT.SEL04(obeC)
        If obeC.HasRow Then
            With obeC
                Dim comproBL As New BL.FacturacionBL.SG_FA_TB_COMPROBANTE_C
                If comproBL.Existe_Comprob_Cuenta(Val(txt_IdCuenta.Text)) Then
                    lbl_estado.Text = "Facturado"
                Else
                    lbl_estado.Text = "Pendiente"
                End If
                comproBL = Nothing

                txt_idHistoria.Value = .CC_IDNUM_HIST

                Dim historiaBL As New BL.AdmisionBL.SG_AD_TB_HISTO_CLINI
                Dim dt_histo_tmp As DataTable = historiaBL.getHistorias_Base_x_Id(txt_idHistoria.Value, 1)
                If dt_histo_tmp.Rows.Count > 0 Then
                    txt_Des_Cliente.Text = dt_histo_tmp.Rows(0)("HC_APE_PAT") & " " & dt_histo_tmp.Rows(0)("HC_APE_MAT") & " " & dt_histo_tmp.Rows(0)("HC_APE_CASADA") & " " & dt_histo_tmp.Rows(0)("HC_NOMBRE1") & " " & dt_histo_tmp.Rows(0)("HC_NOMBRE2")
                    txt_ruc_cliente.Text = dt_histo_tmp.Rows(0)("HC_NDOC")
                    uce_tip_doc.Value = dt_histo_tmp.Rows(0)("HC_TDOC")
                End If
                Format(Val(txt_idHistoria.Text), "0000000000#")

                Call LimpiaGrid(ug_data, uds_Lista)
                ug_data.UpdateData()

                Consultar()
            End With

        Else
            Avisar("Cuenta no Existe!")
            Inicializa()
        End If

    End Sub

    Private Sub txt_IdCuenta_EditorButtonClick(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinEditors.EditorButtonEventArgs) Handles txt_IdCuenta.EditorButtonClick
        Select Case e.Button.Key
            Case "ayuda"
                Call Ayuda_Anexo_Cuenta()
            Case "editar"

        End Select
    End Sub

    Private Sub txt_IdCuenta_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_IdCuenta.KeyDown
        If e.KeyCode = Keys.Enter Or e.KeyCode = Keys.Tab Then
            Call Buscar_Cuenta()
        End If

        If e.KeyCode = Keys.F2 Then Call Ayuda_Anexo_Cuenta()
    End Sub

    'Cuenta Nueva
    Private Sub Ayuda_Anexo_CuentaN()
        LO_LT_ListaCuentas.TIPO = 0
        LO_LT_ListaCuentas.ShowDialog()
        Dim matriz As List(Of String) = LO_LT_ListaCuentas.GetLista
        If matriz.Count > 0 Then
            txt_idCuentaNueva.Text = matriz(0)
            Dim comproBL As New BL.FacturacionBL.SG_FA_TB_COMPROBANTE_C
            If comproBL.Existe_Comprob_Cuenta(Val(txt_idCuentaNueva.Text)) Then
                lbl_estadoNuevo.Text = "Facturado"
            Else
                lbl_estadoNuevo.Text = "Pendiente"
            End If
            comproBL = Nothing
            Format(Val(txt_idCuentaNueva.Text), "0000000000#")
        End If

    End Sub

    Private Sub Buscar_CuentaN()
        Dim obrT As New BL.AdmisionBL.SG_AD_TB_CUENTA_CAB
        Dim obeC As New BE.AdmisionBE.SG_AD_TB_CUENTA_CAB

        obeC.CC_ID = Val(txt_idCuentaNueva.Text)
        Format(Val(txt_idCuentaNueva.Text), "0000000000#")
        obeC.HasRow = False
        obrT.SEL04(obeC)
        If obeC.HasRow Then
            With obeC
                Dim comproBL As New BL.FacturacionBL.SG_FA_TB_COMPROBANTE_C
                If comproBL.Existe_Comprob_Cuenta(Val(txt_idCuentaNueva.Text)) Then
                    lbl_estadoNuevo.Text = "Facturado"
                Else
                    lbl_estadoNuevo.Text = "Pendiente"
                End If
                comproBL = Nothing
            End With
        Else
            Avisar("Cuenta no Existe!")
            txt_idCuentaNueva.Text = ""
        End If

    End Sub

    Private Sub txt_idCuentaNueva_EditorButtonClick(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinEditors.EditorButtonEventArgs) Handles txt_idCuentaNueva.EditorButtonClick
        Select Case e.Button.Key
            Case "ayuda"
                Call Ayuda_Anexo_CuentaN()
            Case "editar"
        End Select
    End Sub

    Private Sub txt_idCuentaNueva_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_idCuentaNueva.KeyDown
        If e.KeyCode = Keys.Enter Or e.KeyCode = Keys.Tab Then
            Call Buscar_CuentaN()
        End If

        If e.KeyCode = Keys.F2 Then Call Ayuda_Anexo_CuentaN()
    End Sub


    Private Sub Consultar()
        Call LimpiaGrid(ug_data, uds_Lista)
        If txt_IdCuenta.Text = "" Then Exit Sub
        Dim obe As New BE.LogisticaBE.SG_LO_TB_CONSUMO_C
        Dim obr As New BL.LogisticaBL.SG_LO_TB_CONSUMO_C
        obe.CM_IDCUENTA = Val(txt_IdCuenta.Text)
        obe.CM_IDALMACEN = ""
        ug_data.DataSource = obr.SEL06(obe, "")
        ug_data.UpdateData()
        obe = Nothing
        obr = Nothing
    End Sub

    Private Sub Tool_Cambiar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_Cambiar.Click
        If Val(txt_IdCuenta.Text) = 0 Or Val(txt_idCuentaNueva.Text) = 0 Then
            Avisar("Ingrese Correctamente la Cuenta")
            Exit Sub
        End If
        If lbl_estadoNuevo.Text = "Facturado" Or lbl_estado.Text = "Facturado" Then
            Avisar("Las 2 Cuentas Tienen que ser Pendiente")
            Exit Sub
        End If


        Dim obe As New BE.LogisticaBE.SG_LO_TB_CONSUMO_C
        Dim obr As New BL.LogisticaBL.SG_LO_TB_CONSUMO_C
        obe.CM_ID = Val(ug_data.ActiveRow.Cells("CM_ID").Value)

        If obr.Cambio(Val(txt_IdCuenta.Text), String.Format("{0}-{1}", Environment.UserName, gStr_Usuario_Sis), Environment.MachineName, Val(txt_idCuentaNueva.Text)) < 0 Then
            MessageBox.Show("La operación solicitada no ha podido ser realizada", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            Call Avisar("Listo!")
            Inicializa()
        End If

        obe = Nothing
        obr = Nothing
    End Sub

    Private Sub Tool_Cancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_Cancelar.Click
        Inicializa()
    End Sub

    Private Sub Tool_Salir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_Salir.Click
        Me.Close()
    End Sub
End Class