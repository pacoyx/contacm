Public Class BB_LT_REGISTRO_BEBE
    Private obe As BE.NeoBE.SA_TB_BB_REGISTRO
    Private obr As BL.NeoBL.SA_TB_BB_REGISTRO
    Private lNew As Boolean = False
    Public Sub New()
        InitializeComponent()
        obe = New BE.NeoBE.SA_TB_BB_REGISTRO
        obr = New BL.NeoBL.SA_TB_BB_REGISTRO
    End Sub

    Private Sub pKeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Me.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Return) Then
            SendKeys.Send("{TAB}")
            e.Handled = True
        End If
    End Sub
    Private Sub pLostfocus(ByVal sender As Object, ByVal e As System.EventArgs)
        sender.BackColor = Color.White
        If sender.Text.Trim.Length < 1 Then
            sender.BackColor = Color.LightPink
        End If
    End Sub
    Private Function fValida() As Boolean
        pLostfocus(txt_idCuenta, Nothing)
        'pLostfocus(txt_IDArticulo, Nothing)
        pLostfocus(txt_bebe, Nothing)
        uce_Medico.BackColor = Color.White
        If uce_Medico.Text <> "" And uce_Medico.SelectedIndex = -1 Then
            uce_Medico.BackColor = Color.LightPink
        End If
        If uce_Medico.BackColor = Color.LightPink Then GoTo Err_Valida
        If txt_idCuenta.BackColor = Color.LightPink Then GoTo Err_Valida
        If txt_bebe.BackColor = Color.LightPink Then GoTo Err_Valida
        Return True
        Exit Function
Err_Valida:
        MessageBox.Show("Corrija ó Complete los campos errados !!", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Return False
    End Function
    Private Sub Inicializa()
        Call Limpiar_Controls_InGroupox(ugb_datos)
        Call Limpiar_Controls_InGroupox(ugb_DatosDet)
        dtp_FechaIngreso.Value = Now
        ugb_DatosDet.Enabled = True
        'txt_des.BackColor = Color.White
        'txt_IDArticulo.BackColor = Color.White
        'ucb_tip.BackColor = Color.White
    End Sub
    Private Sub cargar_lista()

        Dim dt_tmp As DataTable = Nothing
        Call Formatear_Grilla_Selector(ug_SalaBebes)
        obe.RE_IDEMPRESA = gInt_IdEmpresa
        dt_tmp = obr.SEL02(obe)
        'ug_SalaBebes.DataSource = obr.SEL01(obe)

        Me.Cursor = Cursors.WaitCursor

        Call LimpiaGrid(ug_SalaBebes, uds_SalaBebes)
        For i As Integer = 0 To dt_tmp.Rows.Count - 1
            ug_SalaBebes.DisplayLayout.Bands(0).AddNew()
            ug_SalaBebes.Rows(i).Cells("IMAGEN").Value = My.Resources.incubadora
            ug_SalaBebes.Rows(i).Cells("UB_ID").Value = dt_tmp.Rows(i)("UB_ID")
            ug_SalaBebes.Rows(i).Cells("UB_NOMBRE").Value = dt_tmp.Rows(i)("UB_NOMBRE")
            ug_SalaBebes.Rows(i).Cells("BEBE").Value = dt_tmp.Rows(i)("BEBE")
            ug_SalaBebes.Rows(i).Cells("CB_IDREGISTRO").Value = dt_tmp.Rows(i)("CB_IDREGISTRO")
            ug_SalaBebes.Rows(i).Cells("PF_FacTramite").Value = dt_tmp.Rows(i)("PF_FacTramite")
            ug_SalaBebes.UpdateData()
        Next

        ug_SalaBebes.Rows(0).Activate()
        ug_SalaBebes.Rows(0).Selected = True


        Me.Cursor = Cursors.Default
        dt_tmp.Dispose()
    End Sub

    Private Sub BB_LT_SALA_BEBE_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ' Call Inicializar_Estado_Botones_Tool(ToolS_Mantenimiento)
        Call MostrarTabs(0, utc_hospi, 0)

        obe = New BE.NeoBE.SA_TB_BB_REGISTRO
        obr = New BL.NeoBL.SA_TB_BB_REGISTRO
        Me.KeyPreview = True

        Dim medicosBL As New BL.AdmisionBL.SG_AD_TB_MEDICO
        uce_Medico.DataSource = medicosBL.get_Medicos(gInt_IdEmpresa)
        uce_Medico.ValueMember = "ME_CODIGO"
        uce_Medico.DisplayMember = "NOMBRES"
        medicosBL = Nothing


        Dim GrupoSan As New BL.AdmisionBL.SG_AD_TB_GrupoSanguineo
        Dim obj3 As New DataTable
        GrupoSan.SEL02(obj3)
        ucb_GrupoS.DataSource = obj3
        ucb_GrupoS.DisplayMember = "GS_NOMBRE"
        ucb_GrupoS.ValueMember = "GS_ID"
        GrupoSan = Nothing

        cargar_lista()

        ubtn_Ubicacion.Appearance.Image = My.Resources._16__User_
        ubtn_Farmacia.Appearance.Image = My.Resources._16__Bullets_and_numbering_
        ubtn_Facturacion.Appearance.Image = My.Resources._16__Settings_
        ubtn_Logistica.Appearance.Image = My.Resources._16__Options_

        txt_idCuenta.ButtonsRight(0).Appearance.Image = My.Resources._104
        Tool_Grabar.Enabled = False
        Tool_Cancelar.Enabled = False

        Inicializa()
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

    Private Sub Tool_Grabar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_Grabar.Click
        If fValida() = False Then Exit Sub
        Dim comproBL As New BL.FacturacionBL.SG_FA_TB_COMPROBANTE_C
        If comproBL.Existe_Comprob_Cuenta(Val(txt_idCuenta.Text)) Then
            Call Avisar("La Cuenta ya fue facturada, No puede usarla.")
            Exit Sub
        End If
        comproBL = Nothing

        With obe
            .RE_ID = Val(txt_idRegistro.Text)
            .RE_NOMBRE = txt_bebe.Text
            .RE_IDCUENTA = Val(txt_idCuenta.Text)
            .RE_IDMEDICO = uce_Medico.Value
            .RE_MADRE = txt_madre.Text
            .RE_DIAGNOSTICO = txt_diag.Text
            .RE_OBSERVACION = txt_obs.Text
            .RE_PESO = Val(txt_Peso.Text)
            .RE_TALLA = Val(txt_Talla.Text)
            .RE_FECHA_INGRESO = dtp_FechaIngreso.Value
            .RE_IDEMPRESA = gInt_IdEmpresa
            .RE_IDGRUPO_SANG = ucb_GrupoS.Value
        End With

        If lNew Then
            If Val(txt_idRegistro.Text) > 0 Then
                If obr.Update3(obe, String.Format("{0}-{1}", Environment.UserName, gStr_Usuario_Sis), Environment.MachineName) < 0 Then
                    MessageBox.Show("La operación solicitada no ha podido ser realizada", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Exit Sub
                End If
            End If
            Dim i As Integer
            i = obr.Insert(obe, String.Format("{0}-{1}", Environment.UserName, gStr_Usuario_Sis), Environment.MachineName, Val(txt_idcuna.Text))
            If i < 0 Then
                MessageBox.Show("La operación solicitada no ha podido ser realizada", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If
        Else
            If obr.Update(obe, String.Format("{0}-{1}", Environment.UserName, gStr_Usuario_Sis), Environment.MachineName) < 0 Then
                MessageBox.Show("La operación solicitada no ha podido ser realizada", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If
        End If
        Call Avisar("Listo!")
        Call MostrarTabs(0, utc_hospi, 0)
        Inicializa()
        Tool_Grabar.Enabled = False
        Tool_Cancelar.Enabled = False
        Tool_daralta.Enabled = True
        Tool_CambCuenta.Enabled = True
        cargar_lista()

    End Sub

    Private Sub ug_SalaBebes_DoubleClickRow(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinGrid.DoubleClickRowEventArgs) Handles ug_SalaBebes.DoubleClickRow

        If Val(ug_SalaBebes.ActiveRow.Cells(5).Value.ToString) = 1 Then
            Avisar("La cuenta esta Bloqueada, No puede Modificar.")
            Exit Sub
        End If
        Inicializa()
        lNew = True

        txt_idcuna.Text = ug_SalaBebes.ActiveRow.Cells(1).Value
        txt_idRegistro.Text = ug_SalaBebes.ActiveRow.Cells(4).Value.ToString
        If Val(txt_idRegistro.Text) > 0 Then
            obe.RE_ID = Val(txt_idRegistro.Text)
            Dim drr_RE As System.Data.SqlClient.SqlDataReader
            drr_RE = obr.SEL01(obe)
            If drr_RE.HasRows Then
                drr_RE.Read()

                txt_idCuenta.Text = drr_RE("RE_IDCUENTA")
                uce_Medico.Value = drr_RE("RE_IDMEDICO")
                txt_bebe.Text = drr_RE("RE_NOMBRE")
                txt_diag.Text = drr_RE("RE_DIAGNOSTICO")
                txt_obs.Text = drr_RE("RE_OBSERVACION")
                txt_Peso.Text = drr_RE("RE_PESO")
                txt_Talla.Text = drr_RE("RE_TALLA")
                txt_madre.Text = drr_RE("RE_MADRE")
                dtp_FechaIngreso.Value = drr_RE("RE_FECHA_INGRESO")
                udtp_fechaAlta.Value = drr_RE("RE_FECHA_ALTA")

                Dim obrT As New BL.AdmisionBL.SG_AD_TB_CUENTA_CAB
                Dim obeC As New BE.AdmisionBE.SG_AD_TB_CUENTA_CAB
                obeC.CC_ID = Val(txt_idCuenta.Text)
                Format(Val(txt_idCuenta.Text), "0000000000#")
                obeC.HasRow = False
                obrT.SEL04(obeC)
                If obeC.HasRow Then
                    Format(Val(txt_idCuenta.Text), "0000000000#")
                    txt_num_historia.Value = obeC.CC_IDNUM_HIST

                    Dim historiaBL As New BL.AdmisionBL.SG_AD_TB_HISTO_CLINI
                    Dim dt_histo_tmp As DataTable = historiaBL.getHistorias_Base_x_Id(txt_num_historia.Value, 1)
                    If dt_histo_tmp.Rows.Count > 0 Then
                        txt_PACIENTE.Text = dt_histo_tmp.Rows(0)("HC_APE_PAT") & " " & dt_histo_tmp.Rows(0)("HC_APE_MAT") & " " & dt_histo_tmp.Rows(0)("HC_APE_CASADA") & " " & dt_histo_tmp.Rows(0)("HC_NOMBRE1") & " " & dt_histo_tmp.Rows(0)("HC_NOMBRE2")
                        'txt_ruc_cliente.Text = dt_histo_tmp.Rows(0)("HC_NDOC")
                        'uce_tip_doc.Value = dt_histo_tmp.Rows(0)("HC_TDOC")
                    End If
                    Format(Val(txt_num_historia.Text), "0000000000#")
                End If
                obrT = Nothing
                obeC = Nothing
            End If
            drr_RE.Close()
            lNew = False
        End If

        Dim comproBL As New BL.FacturacionBL.SG_FA_TB_COMPROBANTE_C
        If comproBL.Existe_Comprob_Cuenta(Val(txt_idCuenta.Text)) Then
            Call Avisar("La Cuenta ya fue facturada, No puede modificar.")
            Inicializa()
            cargar_lista()
        Else
            Call MostrarTabs(1, utc_hospi, 1)
            Tool_Grabar.Enabled = True
            Tool_Cancelar.Enabled = True
            Tool_daralta.Enabled = False
            Tool_CambCuenta.Enabled = False
        End If
        comproBL = Nothing
    End Sub

    Private Sub Tool_Cancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_Cancelar.Click
        Call MostrarTabs(0, utc_hospi, 0)
        Inicializa()
        Tool_Grabar.Enabled = False
        Tool_Cancelar.Enabled = False
        Tool_daralta.Enabled = True
        Tool_CambCuenta.Enabled = True
    End Sub

    'Cuenta
    Private Sub Ayuda_Anexo_Cuenta()
        'FA_PR_ListaClientesAyuda.Int_Opcion = 1
        BB_LT_AyudaCuenta.ShowDialog()

        Dim matriz As List(Of String) = BB_LT_AyudaCuenta.GetLista

        If matriz.Count > 0 Then
            txt_idCuenta.Text = matriz(0)

            Dim comproBL As New BL.FacturacionBL.SG_FA_TB_COMPROBANTE_C
            If comproBL.Existe_Comprob_Cuenta(Val(txt_IdCuenta.Text)) Then
                Call Avisar("La Cuenta ya fue facturada a la aseguradora, No puede usarla.")
                txt_idCuenta.Text = ""
                Exit Sub
            End If
            comproBL = Nothing

            Format(Val(txt_idCuenta.Text), "0000000000#")
            txt_num_historia.Value = matriz(3)
            'txtIDSeguro.Text = IIf(matriz(6) = 1, "000", matriz(7))

            Dim historiaBL As New BL.AdmisionBL.SG_AD_TB_HISTO_CLINI
            Dim dt_histo_tmp As DataTable = historiaBL.getHistorias_Base_x_Id(txt_num_historia.Value, 1)
            If dt_histo_tmp.Rows.Count > 0 Then
                txt_PACIENTE.Text = dt_histo_tmp.Rows(0)("HC_APE_PAT") & " " & dt_histo_tmp.Rows(0)("HC_APE_MAT") & " " & dt_histo_tmp.Rows(0)("HC_APE_CASADA") & " " & dt_histo_tmp.Rows(0)("HC_NOMBRE1") & " " & dt_histo_tmp.Rows(0)("HC_NOMBRE2")
                'txt_ruc_cliente.Text = dt_histo_tmp.Rows(0)("HC_NDOC")
                'uce_tip_doc.Value = dt_histo_tmp.Rows(0)("HC_TDOC")
            End If
            Format(Val(txt_num_historia.Text), "0000000000#")

        End If

    End Sub

    Private Sub Buscar_Cuenta()
        '  Dim obeT As BE.AdmisionBE.TMP_SG_AD_TB_CUENTA_DET
        Dim obrT As New BL.AdmisionBL.SG_AD_TB_CUENTA_CAB
        Dim obeC As New BE.AdmisionBE.SG_AD_TB_CUENTA_CAB

        obeC.CC_ID = Val(txt_IdCuenta.Text)
        Format(Val(txt_IdCuenta.Text), "0000000000#")
        obeC.HasRow = False
        obrT.SEL14(obeC)
        If obeC.HasRow Then
            With obeC
                'Dim comproBL As New BL.FacturacionBL.SG_FA_TB_COMPROBANTE_C
                'If comproBL.Existe_Comprob_Cuenta(Val(txt_IdCuenta.Text)) Then
                '    Call Avisar("La Cuenta ya fue facturada a la aseguradora, No puede usarla.")
                '    Inicializa()
                '    Exit Sub
                'End If
                'comproBL = Nothing

                txt_num_historia.Value = .CC_IDNUM_HIST
                'txtIDSeguro.Text = IIf(.CC_IDTIPO_ATENC = 1, "000", .CC_IDSEGURO)

                Dim historiaBL As New BL.AdmisionBL.SG_AD_TB_HISTO_CLINI
                Dim dt_histo_tmp As DataTable = historiaBL.getHistorias_Base_x_Id(txt_num_historia.Value, 1)
                If dt_histo_tmp.Rows.Count > 0 Then
                    txt_PACIENTE.Text = dt_histo_tmp.Rows(0)("HC_APE_PAT") & " " & dt_histo_tmp.Rows(0)("HC_APE_MAT") & " " & dt_histo_tmp.Rows(0)("HC_APE_CASADA") & " " & dt_histo_tmp.Rows(0)("HC_NOMBRE1") & " " & dt_histo_tmp.Rows(0)("HC_NOMBRE2")
                    'txt_ruc_cliente.Text = dt_histo_tmp.Rows(0)("HC_NDOC")
                    'uce_tip_doc.Value = dt_histo_tmp.Rows(0)("HC_TDOC")
                End If
                Format(Val(txt_num_historia.Text), "0000000000#")
            End With

        Else
            Avisar("Cuenta no Existe O esta Bloqueada")
            txt_idCuenta.Text = ""
        End If

    End Sub

    Private Sub txt_IdCuenta_EditorButtonClick(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinEditors.EditorButtonEventArgs) Handles txt_idCuenta.EditorButtonClick
        Select Case e.Button.Key
            Case "ayuda"
                Call Ayuda_Anexo_Cuenta()
            Case "editar"

        End Select
    End Sub

    Private Sub txt_IdCuenta_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_idCuenta.KeyDown
        If e.KeyCode = Keys.Enter Or e.KeyCode = Keys.Tab Then
            Call Buscar_Cuenta()
        End If

        If e.KeyCode = Keys.F2 Then Call Ayuda_Anexo_Cuenta()
    End Sub

    Private Sub ubtn_Ubicacion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ubtn_Ubicacion.Click
        If Val(ug_SalaBebes.ActiveRow.Cells(5).Value.ToString) = 1 Then
            Avisar("La cuenta esta Bloqueada, No puede Modificar.")
            Exit Sub
        End If
        With BB_LT_RegUbicacion
            .txt_idRegistro.Text = ug_SalaBebes.ActiveRow.Cells(4).Value.ToString
            If Val(.txt_idRegistro.Text) > 0 Then
                obe.RE_ID = Val(.txt_idRegistro.Text)
                Dim drr_RE As System.Data.SqlClient.SqlDataReader
                drr_RE = obr.SEL01(obe)
                If drr_RE.HasRows Then
                    drr_RE.Read()
                    .txt_IDCUENTA.Text = drr_RE("RE_IDCUENTA")
                    .txt_bebe.Text = drr_RE("RE_NOMBRE")
                End If
                drr_RE.Close()
                .ShowDialog()
            Else
                Exit Sub
            End If

            cargar_lista()
        End With
    End Sub

    Private Sub ubtn_Farmacia_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ubtn_Farmacia.Click
        If Val(ug_SalaBebes.ActiveRow.Cells(5).Value.ToString) = 1 Then
            Avisar("La cuenta esta Bloqueada, No puede Modificar.")
            Exit Sub
        End If

        With BB_LT_RegConsumoFar
            .txt_idRegistro.Text = ug_SalaBebes.ActiveRow.Cells(4).Value.ToString
            '--almacenes
            Dim AlcBL As New BL.LogisticaBL.SG_LO_TB_ALMACEN
            .uce_Almacen.DataSource = AlcBL.get_almacen_2(7, gInt_IdUsuario_Sis)
            .uce_Almacen.DisplayMember = "AL_DESCRIPCION"
            .uce_Almacen.ValueMember = "AL_ID"
            AlcBL = Nothing

            .uce_Almacen.Value = "004"
            If Val(ug_SalaBebes.ActiveRow.Cells(4).Value.ToString) > 0 Then
                obe.RE_ID = Val(ug_SalaBebes.ActiveRow.Cells(4).Value.ToString)
                Dim drr_RE As System.Data.SqlClient.SqlDataReader
                drr_RE = obr.SEL01(obe)
                If drr_RE.HasRows Then
                    drr_RE.Read()
                    .txt_IDCUENTA.Text = drr_RE("RE_IDCUENTA")
                    .txt_bebe.Text = drr_RE("RE_NOMBRE")
                End If
                drr_RE.Close()
                .ShowDialog()
            Else
                Exit Sub
            End If

            cargar_lista()
        End With
    End Sub

    Private Sub ubtn_Facturacion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ubtn_Facturacion.Click
        If Val(ug_SalaBebes.ActiveRow.Cells(5).Value.ToString) = 1 Then
            Avisar("La cuenta esta Bloqueada, No puede Modificar.")
            Exit Sub
        End If
        With BB_LT_RegConsumoFac
            .txt_idRegistro.Text = ug_SalaBebes.ActiveRow.Cells(4).Value.ToString
            If Val(.txt_idRegistro.Text) > 0 Then
                obe.RE_ID = Val(.txt_idRegistro.Text)
                Dim drr_RE As System.Data.SqlClient.SqlDataReader
                drr_RE = obr.SEL01(obe)
                If drr_RE.HasRows Then
                    drr_RE.Read()
                    .txt_IDCUENTA.Text = drr_RE("RE_IDCUENTA")
                    .txt_bebe.Text = drr_RE("RE_NOMBRE")
                End If
                drr_RE.Close()
                .ShowDialog()
            Else
                Exit Sub
            End If

            cargar_lista()
        End With
    End Sub

    Private Sub ubtn_Logistica_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ubtn_Logistica.Click
        If Val(ug_SalaBebes.ActiveRow.Cells(5).Value.ToString) = 1 Then
            Avisar("La cuenta esta Bloqueada, No puede Modificar.")
            Exit Sub
        End If

        With BB_LT_RegLogistica
            .txt_idRegistro.Text = ug_SalaBebes.ActiveRow.Cells(4).Value.ToString
            '--almacenes
            Dim AlcBL As New BL.LogisticaBL.SG_LO_TB_AREA
            .uce_Area.DataSource = AlcBL.getar(gInt_IdEmpresa)
            .uce_Area.DisplayMember = "AR_DESCRIPCION"
            .uce_Area.ValueMember = "AR_ID"
            AlcBL = Nothing

            .uce_Area.Value = "007"

            If Val(ug_SalaBebes.ActiveRow.Cells(4).Value.ToString) > 0 Then
                obe.RE_ID = Val(ug_SalaBebes.ActiveRow.Cells(4).Value.ToString)
                Dim drr_RE As System.Data.SqlClient.SqlDataReader
                drr_RE = obr.SEL01(obe)
                If drr_RE.HasRows Then
                    drr_RE.Read()
                    .txt_IDCUENTA.Text = drr_RE("RE_IDCUENTA")
                    .txt_bebe.Text = drr_RE("RE_NOMBRE")
                End If
                drr_RE.Close()
                .ShowDialog()
            Else
                Exit Sub
            End If

            cargar_lista()
        End With
    End Sub

    Private Sub Tool_daralta_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_daralta.Click
        If Val(ug_SalaBebes.ActiveRow.Cells(4).Value.ToString) = 0 Then Exit Sub

        With obe
            .RE_ID = Val(ug_SalaBebes.ActiveRow.Cells(4).Value.ToString)
        End With

        If obr.Update2(obe, String.Format("{0}-{1}", Environment.UserName, gStr_Usuario_Sis), Environment.MachineName) < 0 Then
            MessageBox.Show("La operación solicitada no ha podido ser realizada", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        Call Avisar("Listo!")
        cargar_lista()

    End Sub

    Private Sub Tool_CambCuenta_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_CambCuenta.Click
        If Val(ug_SalaBebes.ActiveRow.Cells(4).Value.ToString) = 0 Then Exit Sub
        If Val(ug_SalaBebes.ActiveRow.Cells(5).Value.ToString) <> 1 Then Exit Sub

        Inicializa()
        lNew = True

        txt_idcuna.Text = ug_SalaBebes.ActiveRow.Cells(1).Value
        txt_idRegistro.Text = ug_SalaBebes.ActiveRow.Cells(4).Value.ToString
        obe.RE_ID = Val(txt_idRegistro.Text)
        Dim drr_RE As System.Data.SqlClient.SqlDataReader
        drr_RE = obr.SEL01(obe)
        If drr_RE.HasRows Then
            drr_RE.Read()
            txt_idCuenta.Text = drr_RE("RE_IDCUENTA")
            uce_Medico.Value = drr_RE("RE_IDMEDICO")
            txt_bebe.Text = drr_RE("RE_NOMBRE")
            txt_diag.Text = drr_RE("RE_DIAGNOSTICO")
            txt_obs.Text = drr_RE("RE_OBSERVACION")
            txt_Peso.Text = drr_RE("RE_PESO")
            txt_Talla.Text = drr_RE("RE_TALLA")
            txt_madre.Text = drr_RE("RE_MADRE")
            dtp_FechaIngreso.Value = drr_RE("RE_FECHA_INGRESO")
            udtp_fechaAlta.Value = drr_RE("RE_FECHA_ALTA")
        End If
        drr_RE.Close()

        Dim comproBL As New BL.FacturacionBL.SG_FA_TB_COMPROBANTE_C
        If comproBL.Existe_Comprob_Cuenta(Val(txt_idCuenta.Text)) Then
            txt_idCuenta.Text = ""

            Call MostrarTabs(1, utc_hospi, 1)
            Tool_Grabar.Enabled = True
            Tool_Cancelar.Enabled = True
            Tool_daralta.Enabled = False
            Tool_CambCuenta.Enabled = False
            ugb_DatosDet.Enabled = False
        Else
            Call Avisar("La Cuenta todavia no esta facturada, no puede cambiarla.")
            Inicializa()
            cargar_lista()
        End If
        comproBL = Nothing

    End Sub

End Class