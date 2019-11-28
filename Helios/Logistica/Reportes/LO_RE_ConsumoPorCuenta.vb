Public Class LO_RE_ConsumoPorCuenta
    Dim IGVTasa As Double
    Private Sub Cargar_Tasas_Impuestos()

        Dim impuestosBL As New BL.ContabilidadBL.SG_CO_TB_IMPUESTO
        Dim impuestoBE As New BE.ContabilidadBE.SG_CO_TB_IMPUESTO

        impuestoBE.IM_IDEMPRESA = New BE.ContabilidadBE.SG_CO_TB_EMPRESA With {.EM_ID = gInt_IdEmpresa}
        impuestoBE.IM_IDTIPOIMPUESTO = New BE.ContabilidadBE.SG_CO_TB_TIPO_IMPUESTO With {.TI_CODIGO = "01"}
        impuestoBE.IM_PERIODO = CDate(Now).Year
        impuestoBE.IM_MES = CDate(Now).Month

        impuestosBL.getImpuestos_x_Tipo(impuestoBE)
        IGVTasa = impuestoBE.IM_TASA


        impuestosBL = Nothing
        impuestoBE = Nothing

    End Sub
    Private Sub pKeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles MyBase.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Return) Then
            SendKeys.Send("{TAB}")
            e.Handled = True
        End If
    End Sub

    Private Sub pKeyPressNumero(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_IdCuenta.KeyPress
        e.KeyChar = fKeyPress(e.KeyChar, sender.Text, 1)
        e.Handled = (e.KeyChar = "")
    End Sub

    Private Sub Inicializa()
        Call LimpiaGrid(ug_data, uds_Lista)
        txt_IdCuenta.BackColor = Color.White
        uce_tip_doc.SelectedIndex = 0
        txt_IdCuenta.Text = ""
        txt_ruc_cliente.Text = ""
        txt_Des_Cliente.Text = ""
        'txt_idHistoria.Text = ""
        txt_Tratamiento.Text = ""
        uck_Area.Checked = False
        ucb_Tipo.SelectedIndex = 3
        'uck_Cubre.Checked = True
        'uck_NoCubre.Checked = True
        lbl_estado.Text = ""
    End Sub

    '-------------pacientes clientes
    Private Sub Ayuda_Anexo_Cab()
        ' FA_PR_ListaClientesAyuda.Int_Opcion = 1
        AD_PR_BuscaPaciente.ShowDialog()

        Dim matriz As List(Of String) = AD_PR_BuscaPaciente.GetLista

        If matriz.Count > 0 Then

            ' txt_idHistoria.Text = matriz(0)
            txt_ruc_cliente.Text = matriz(9)
            uce_tip_doc.Value = matriz(8)
            txt_Des_Cliente.Text = matriz(2)
            'udte_fechaNac.Value = matriz(10)
            'txt_Edad.Value = Int(DateDiff("m", matriz(10), Date.Now) / 12)
            ' txt_ruc_cliente.ButtonsRight("editar").Enabled = True

            LO_LT_ListaCuentas.txt_filtro.Text = txt_Des_Cliente.Text
            LO_LT_ListaCuentas.TIPO = 0
            LO_LT_ListaCuentas.ShowDialog()
            Dim matrizC As List(Of String) = LO_LT_ListaCuentas.GetLista

            If matrizC.Count > 0 Then
                txt_IdCuenta.Text = matrizC(0)
                Dim obrP As New BL.FacturacionBL.SG_FA_TB_PRE_FACTURA_CAB
                Dim obeP As New BE.FacturacionBE.SG_FA_TB_PRE_FACTURA_CAB

                obeP.PF_IDCUENTA = Val(txt_IdCuenta.Text)
                obeP.HasRow = False
                obrP.SEL02(obeP)
                If obeP.HasRow Then
                    With obeP
                        txt_Tratamiento.Text = .PF_Tratamiento
                    End With
                Else
                    txt_Tratamiento.Text = ""
                End If
                Format(Val(txt_IdCuenta.Text), "0000000000#")

                Dim comproBL As New BL.FacturacionBL.SG_FA_TB_COMPROBANTE_C
                If comproBL.Existe_Comprob_Cuenta(Val(txt_IdCuenta.Text)) Then
                    lbl_estado.Text = "Facturado"
                    'Call Avisar("La Cuenta ya fue facturada a la aseguradora, No puede usarla.")
                    'Inicializa()
                    'Exit Sub
                Else
                    lbl_estado.Text = "Pendiente"
                End If
                comproBL = Nothing
                Tool_Consultar_Click(Nothing, Nothing)
            Else
                txt_IdCuenta.Text = ""
                Inicializa()
            End If

            Call LimpiaGrid(ug_data, uds_Lista)
            ug_data.UpdateData()
        End If

    End Sub

    Private Sub Buscar_Cliente()

        Dim clienteBL As New BL.AdmisionBL.SG_AD_TB_HISTO_CLINI
        Dim clienteBE As New BE.AdmisionBE.SG_AD_TB_HISTO_CLINI

        clienteBE.HC_NDOC = txt_ruc_cliente.Text.Trim
        clienteBE.HC_IDEMPRESA = 1
        clienteBE.HC_TDOC = uce_tip_doc.Value

        clienteBL.get_Historias_x_Doc(clienteBE)
        If clienteBE.HasRow Then
            '  txt_idHistoria.Text = clienteBE.HC_NUM_HIST
            txt_Des_Cliente.Text = clienteBE.HC_NOMBRE1

            LO_LT_ListaCuentas.txt_filtro.Text = txt_Des_Cliente.Text
            LO_LT_ListaCuentas.TIPO = 0
            LO_LT_ListaCuentas.ShowDialog()
            Dim matrizC As List(Of String) = LO_LT_ListaCuentas.GetLista

            If matrizC.Count > 0 Then
                txt_IdCuenta.Text = matrizC(0)
                Dim obrP As New BL.FacturacionBL.SG_FA_TB_PRE_FACTURA_CAB
                Dim obeP As New BE.FacturacionBE.SG_FA_TB_PRE_FACTURA_CAB

                obeP.PF_IDCUENTA = Val(txt_IdCuenta.Text)
                obeP.HasRow = False
                obrP.SEL02(obeP)
                If obeP.HasRow Then
                    With obeP
                        txt_Tratamiento.Text = .PF_Tratamiento
                    End With
                Else
                    txt_Tratamiento.Text = ""
                End If
                Format(Val(txt_IdCuenta.Text), "0000000000#")
                Dim comproBL As New BL.FacturacionBL.SG_FA_TB_COMPROBANTE_C
                If comproBL.Existe_Comprob_Cuenta(Val(txt_IdCuenta.Text)) Then
                    lbl_estado.Text = "Facturado"
                    'Call Avisar("La Cuenta ya fue facturada a la aseguradora, No puede usarla.")
                    'Inicializa()
                    'Exit Sub
                Else
                    lbl_estado.Text = "Pendiente"
                End If
                comproBL = Nothing
                Tool_Consultar_Click(Nothing, Nothing)
            Else
                txt_IdCuenta.Text = ""
                Inicializa()
            End If

            Call LimpiaGrid(ug_data, uds_Lista)
            ug_data.UpdateData()

        Else
            Avisar("El Paciente no existe!")
        End If

        clienteBE = Nothing
        clienteBL = Nothing

    End Sub

    Private Sub txt_ruc_cliente_EditorButtonClick(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinEditors.EditorButtonEventArgs) Handles txt_ruc_cliente.EditorButtonClick
        Select Case e.Button.Key
            Case "ayuda"
                Call Ayuda_Anexo_Cab()
            Case "editar"

        End Select
    End Sub
    Private Sub txt_ruc_cliente_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_ruc_cliente.ValueChanged
        If txt_ruc_cliente.Text.Trim.Length = 0 Then
            txt_Des_Cliente.Text = String.Empty
        End If
    End Sub
    Private Sub txt_ruc_cliente_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_ruc_cliente.KeyDown
        If e.KeyCode = Keys.Enter Or e.KeyCode = Keys.Tab Then
            Call Buscar_Cliente()
        End If

        If e.KeyCode = Keys.F2 Then Call Ayuda_Anexo_Cab()
    End Sub

    'Cuenta
    Private Sub Ayuda_Anexo_Cuenta()
        'FA_PR_ListaClientesAyuda.Int_Opcion = 1
        LO_LT_ListaCuentas.TIPO = 0
        LO_LT_ListaCuentas.ShowDialog()

        Dim matriz As List(Of String) = LO_LT_ListaCuentas.GetLista

        If matriz.Count > 0 Then
            txt_IdCuenta.Text = matriz(0)
            Dim obrP As New BL.FacturacionBL.SG_FA_TB_PRE_FACTURA_CAB
            Dim obeP As New BE.FacturacionBE.SG_FA_TB_PRE_FACTURA_CAB

            obeP.PF_IDCUENTA = Val(txt_IdCuenta.Text)
            obeP.HasRow = False
            obrP.SEL02(obeP)
            If obeP.HasRow Then
                With obeP
                    txt_Tratamiento.Text = .PF_Tratamiento
                    uce_Medico.Value = .PF_IDMEDICO
                End With
            Else
                txt_Tratamiento.Text = ""
                uce_Medico.Value = ""
            End If
            utxtSeguro.Text = IIf(matriz(6) = 1, "000", matriz(7))
            Dim comproBL As New BL.FacturacionBL.SG_FA_TB_COMPROBANTE_C
            If comproBL.Existe_Comprob_Cuenta(Val(txt_IdCuenta.Text)) Then
                lbl_estado.Text = "Facturado"
                'Call Avisar("La Cuenta ya fue facturada a la aseguradora, No puede usarla.")
                'Inicializa()
                'Exit Sub
                ubtn_ActualizarPre.Enabled = False
                ubtn_Quitar.Enabled = False
            Else
                lbl_estado.Text = "Pendiente"
                ubtn_ActualizarPre.Enabled = True
                ubtn_Quitar.Enabled = True
            End If
            comproBL = Nothing

            Format(Val(txt_IdCuenta.Text), "0000000000#")
            ' txt_idHistoria.Value = matriz(3)

            Dim historiaBL As New BL.AdmisionBL.SG_AD_TB_HISTO_CLINI
            Dim dt_histo_tmp As DataTable = historiaBL.getHistorias_Base_x_Id(matriz(3), 1)
            If dt_histo_tmp.Rows.Count > 0 Then
                txt_Des_Cliente.Text = dt_histo_tmp.Rows(0)("HC_APE_PAT") & " " & dt_histo_tmp.Rows(0)("HC_APE_MAT") & " " & dt_histo_tmp.Rows(0)("HC_APE_CASADA") & " " & dt_histo_tmp.Rows(0)("HC_NOMBRE1") & " " & dt_histo_tmp.Rows(0)("HC_NOMBRE2")
                txt_ruc_cliente.Text = dt_histo_tmp.Rows(0)("HC_NDOC")
                uce_tip_doc.Value = dt_histo_tmp.Rows(0)("HC_TDOC")
            End If
            'Format(Val(txt_idHistoria.Text), "0000000000#")
            Call LimpiaGrid(ug_data, uds_Lista)
            Tool_Consultar_Click(Nothing, Nothing)
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
                'If .CC_IDTIPO_ORI <> 2 Then
                '    Avisar("Cuenta no apta!")
                '    Exit Sub
                'End If
                Dim obrP As New BL.FacturacionBL.SG_FA_TB_PRE_FACTURA_CAB
                Dim obeP As New BE.FacturacionBE.SG_FA_TB_PRE_FACTURA_CAB

                obeP.PF_IDCUENTA = Val(txt_IdCuenta.Text)
                obeP.HasRow = False
                obrP.SEL02(obeP)
                If obeP.HasRow Then
                    With obeP
                        txt_Tratamiento.Text = .PF_Tratamiento
                        uce_Medico.Value = .PF_IDMEDICO
                    End With
                Else
                    txt_Tratamiento.Text = ""
                    uce_Medico.Value = ""
                End If
                
                utxtSeguro.Text = IIf(.CC_IDTIPO_ATENC = 1, "000", .CC_IDSEGURO)
                Dim comproBL As New BL.FacturacionBL.SG_FA_TB_COMPROBANTE_C
                If comproBL.Existe_Comprob_Cuenta(Val(txt_IdCuenta.Text)) Then
                    lbl_estado.Text = "Facturado"
                    'Call Avisar("La Cuenta ya fue facturada a la aseguradora, No puede usarla.")
                    'Inicializa()
                    'Exit Sub
                    ubtn_ActualizarPre.Enabled = False
                    ubtn_Quitar.Enabled = False
                Else
                    lbl_estado.Text = "Pendiente"
                    ubtn_ActualizarPre.Enabled = True
                    ubtn_Quitar.Enabled = True
                End If
                comproBL = Nothing

                'txt_idHistoria.Value = .CC_IDNUM_HIST

                Dim historiaBL As New BL.AdmisionBL.SG_AD_TB_HISTO_CLINI
                Dim dt_histo_tmp As DataTable = historiaBL.getHistorias_Base_x_Id(.CC_IDNUM_HIST, 1)
                If dt_histo_tmp.Rows.Count > 0 Then
                    txt_Des_Cliente.Text = dt_histo_tmp.Rows(0)("HC_APE_PAT") & " " & dt_histo_tmp.Rows(0)("HC_APE_MAT") & " " & dt_histo_tmp.Rows(0)("HC_APE_CASADA") & " " & dt_histo_tmp.Rows(0)("HC_NOMBRE1") & " " & dt_histo_tmp.Rows(0)("HC_NOMBRE2")
                    txt_ruc_cliente.Text = dt_histo_tmp.Rows(0)("HC_NDOC")
                    uce_tip_doc.Value = dt_histo_tmp.Rows(0)("HC_TDOC")
                End If
                ' Format(Val(txt_idHistoria.Text), "0000000000#")

                Call LimpiaGrid(ug_data, uds_Lista)
                ug_data.UpdateData()

                Tool_Consultar_Click(Nothing, Nothing)
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


    Private Sub LO_RE_ConsumoPorCuenta_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.KeyPreview = True
        Dim documentoscBL As New BL.AdmisionBL.SG_AD_TB_TIP_DOC_PER
        uce_tip_doc.DataSource = documentoscBL.getTiposDocs(gInt_IdEmpresa)
        uce_tip_doc.DisplayMember = "TD_ABREVIATURA"
        uce_tip_doc.ValueMember = "TD_ID"
        documentoscBL = Nothing

        txt_ruc_cliente.ButtonsRight(0).Appearance.Image = My.Resources._104
        txt_IdCuenta.ButtonsRight(0).Appearance.Image = My.Resources._104

        Dim AlcBL As New BL.LogisticaBL.SG_LO_TB_ALMACEN
        uce_Almacen.DataSource = AlcBL.get_almacen_2(gInt_IdEmpresa, gInt_IdUsuario_Sis)
        uce_Almacen.DisplayMember = "AL_DESCRIPCION"
        uce_Almacen.ValueMember = "AL_ID"
        AlcBL = Nothing

        Dim medicosBL As New BL.AdmisionBL.SG_AD_TB_MEDICO
        uce_Medico.DataSource = medicosBL.get_Medicos(1)
        uce_Medico.ValueMember = "ME_CODIGO"
        uce_Medico.DisplayMember = "NOMBRES"
        medicosBL = Nothing

        Inicializa()

        Cargar_Tasas_Impuestos()
    End Sub

    Private Sub Tool_Consultar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_Consultar.Click
        Call LimpiaGrid(ug_data, uds_Lista)
        If txt_IdCuenta.Text = "" Then Exit Sub
        '  If uck_Cubre.Checked = False And uck_NoCubre.Checked = False Then Exit Sub
        'Dim obj As New DataTable
        '  Dim segcu As String
        Dim obe As New BE.LogisticaBE.SG_LO_TB_CONSUMO_C
        Dim obr As New BL.LogisticaBL.SG_LO_TB_CONSUMO_C
        obe.CM_IDCUENTA = Val(txt_IdCuenta.Text)
        obe.CM_IDALMACEN = IIf(uck_Area.Checked = True, uce_Almacen.Value, "")
        'If uck_Cubre.Checked = True And uck_NoCubre.Checked = True Then
        '    segcu = "2"
        'ElseIf uck_Cubre.Checked = True Then
        '    segcu = "0"
        'Else
        '    segcu = "1"
        'End If

        ug_data.DataSource = obr.SEL06(obe, ucb_Tipo.Value)
        ug_data.UpdateData()
        obe = Nothing
        obr = Nothing
    End Sub

    Private Sub Tool_Imprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_Imprimir.Click
        If txt_IdCuenta.Text = "" Then Exit Sub
        ' If uck_Cubre.Checked = False And uck_NoCubre.Checked = False Then Exit Sub

        Me.Cursor = Cursors.WaitCursor
        Dim obj As New DataTable

        'Dim obj As New DataTable
        '  Dim segcu As Integer
        Dim obe As New BE.LogisticaBE.SG_LO_TB_CONSUMO_C
        Dim obr As New BL.LogisticaBL.SG_LO_TB_CONSUMO_C
        obe.CM_IDCUENTA = Val(txt_IdCuenta.Text)
        obe.CM_IDALMACEN = IIf(uck_Area.Checked = True, uce_Almacen.Value, "")
        'If uck_Cubre.Checked = True And uck_NoCubre.Checked = True Then
        '    segcu = 2
        'ElseIf uck_Cubre.Checked = True Then
        '    segcu = 0
        'Else
        '    segcu = 1
        'End If

        Dim nom_reporte As String = "SG_LO_01.RPT"
        Dim crystalBL As New LR.ClsReporte
        Dim dt_data As New DataTable
        dt_data = obr.SEL06(obe, ucb_Tipo.Value)

        crystalBL.Muestra_Reporte(gStr_RutaRep & "\" & nom_reporte, dt_data, "", "pCuenta;" & txt_IdCuenta.Text, "pPaciente;" & txt_Des_Cliente.Text)

        crystalBL = Nothing
        ' reportesBL = Nothing

        Me.Cursor = Cursors.Default
    End Sub

    Private Sub Tool_Salir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_Salir.Click
        Me.Close()
    End Sub

    Private Sub uck_Area_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles uck_Area.CheckedChanged
        If uck_Area.Checked = True Then
            uce_Almacen.Enabled = True
        Else
            uce_Almacen.Enabled = False
        End If
    End Sub

    Private Sub ubtn_ActualizarPre_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ubtn_ActualizarPre.Click
        If Preguntar("Los precios se actualizara de acuerdo a los datos de la cuenta ¿Esta de acuerdo en actualizar los precios de farmacia del consumo que realizo el paciente?") = True Then
            'Dim obe As New BE.LogisticaBE.SG_LO_TB_CONSUMO_C
            'Dim obr As New BL.LogisticaBL.SG_LO_TB_CONSUMO_C
            Dim obe As New BE.FacturacionBE.SG_FA_TB_PRE_FACTURA_CAB
            Dim obr As New BL.FacturacionBL.SG_FA_TB_PRE_FACTURA_CAB

            obe.PF_IDCUENTA = Val(txt_IdCuenta.Text)
            obe.PF_IDSEGURO = utxtSeguro.Text
            obe.PF_IGV = IGVTasa

            Dim I As Integer
            I = obr.Update_Farmacia_Det(obe)
            If I < 0 Then
                MessageBox.Show("La operación solicitada no ha podido ser realizada", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If
            Avisar("Precios Actualizados Correctamente")

            Tool_Consultar_Click(Nothing, Nothing)
        End If
    End Sub

    Private Sub ubtn_Quitar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ubtn_Quitar.Click
        Dim obe As New BE.LogisticaBE.SG_LO_TB_CONSUMO_C
        Dim obr As New BL.LogisticaBL.SG_LO_TB_CONSUMO_C
        obe.CM_ID = Val(ug_data.ActiveRow.Cells("CM_ID").Value)
        Dim I As Integer
        I = obr.Delete2(obe, Val(ug_data.ActiveRow.Cells("1").Value))
        If I = -2 Then
            MessageBox.Show("No se puede quitar el articulo, corresponde a un Inventario ya cerrado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf I < 0 Then
            MessageBox.Show("La operación solicitada no ha podido ser realizada", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            Call Avisar("Listo!")
            Tool_Consultar_Click(Nothing, Nothing)
        End If

        obe = Nothing
        obr = Nothing
    End Sub

End Class