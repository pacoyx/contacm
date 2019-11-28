Imports Infragistics.Win.UltraWinGrid
Public Class FA_PR_Pre_Facturacion

    Private obe As BE.FacturacionBE.SG_FA_TB_PRE_FACTURA_CAB
    Private obr As BL.FacturacionBL.SG_FA_TB_PRE_FACTURA_CAB

    Private obeT As BE.AdmisionBE.TMP_SG_AD_TB_CUENTA_DET
    Private obrT As BL.AdmisionBL.SG_AD_TB_CUENTA_CAB
    Private obeC As BE.AdmisionBE.SG_AD_TB_CUENTA_CAB

    Public lNew As Boolean = False
    Public OPCION As Integer
    Public IGVTasa As Double
    Public IDMEDICO As String
    Dim idDiagnostico As Integer = 0
    Public ValModifi As Integer = 0
    Public Sub New()
        InitializeComponent()
        obe = New BE.FacturacionBE.SG_FA_TB_PRE_FACTURA_CAB
        obr = New BL.FacturacionBL.SG_FA_TB_PRE_FACTURA_CAB
        obeT = New BE.AdmisionBE.TMP_SG_AD_TB_CUENTA_DET
        obrT = New BL.AdmisionBL.SG_AD_TB_CUENTA_CAB
        obeC = New BE.AdmisionBE.SG_AD_TB_CUENTA_CAB
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

    Private Sub pKeyPressNumero(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_PagoFijo.KeyPress, txt_PagoVariable.KeyPress, txt_MontoImponible.KeyPress
        e.KeyChar = fKeyPress(e.KeyChar, sender.Text, 2)
        e.Handled = (e.KeyChar = "")
    End Sub

    Private Function fValida() As Boolean

        pLostfocus(txt_ruc_cliente, Nothing)
        pLostfocus(uce_Medico, Nothing)
        ' udtpFechaAlta.BackColor = Color.White
        udtpFechaIngreso.BackColor = Color.White

        'If Val(txt_ruc_cliente.Text) = 0 Then txt_Ruc_ClientesC.BackColor = Color.LightPink
        If uce_Medico.Text = "" Then uce_Medico.BackColor = Color.LightPink
        ' If udtpFechaAlta.Value = Nothing Then udtpFechaAlta.BackColor = Color.LightPink
        If udtpFechaIngreso.Value = Nothing Then udtpFechaIngreso.BackColor = Color.LightPink
        ' If udtpFechaAlta.BackColor = Color.LightPink Then GoTo Err_Valida
        If udtpFechaIngreso.BackColor = Color.LightPink Then GoTo Err_Valida

        If uce_Medico.BackColor = Color.LightPink Then GoTo Err_Valida
        If txt_ruc_cliente.BackColor = Color.LightPink Then GoTo Err_Valida

        Return True
        Exit Function
Err_Valida:
        MessageBox.Show("Corrija ó Complete los campos errados !!", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Return False
    End Function

    Private Sub Inicializa()
        ValModifi = 0
        Call LimpiaGrid(ug_detalle, uds_detalle)
        Call Limpiar_Controls_InGroupox(ugb_Datos)
        Call Limpiar_Controls_InGroupox(ugb_Cuenta)

        txt_ruc_cliente.BackColor = Color.White
        uce_Medico.BackColor = Color.White
        ucbo_Estado.Value = 1
        urb_estaCuenta.Value = 0

        urb_estaCuenta.Enabled = False
        ub_Detallar.Enabled = False
        ubnt_Tratamiento.Enabled = False

        ucm_SeguroEps.Enabled = False
        ugb_Cuenta.Enabled = False
        txt_IdCuenta.Enabled = False
        txt_IDPresupuesto.Enabled = False
        uce_tip_doc.SelectedIndex = 0

        uchk_GenerarCta.Enabled = True
        uchk_Presupuesto.Enabled = True

        ubt_Agregar.Enabled = False
        ubt_Quitar.Enabled = False
        'ubt_Consumo.Enabled = False
        uchk_SeguroEps.Enabled = False
        uce_Medico.Enabled = False
        ucm_Tipo.Enabled = False
        txt_Ruc_ClientesC.Enabled = False
        txt_idDiagnostico.Enabled = False
        udtpFechaAlta.Enabled = False
        udtpFechaIngreso.Enabled = False
        txt_Tratamiento.Enabled = False
        udtpFechaIngreso.Value = ""
        udtpFechaAlta.Value = ""
        idDiagnostico = 0
        ug_detalle.Enabled = False
        txt_SubTotal.Value = 0
        txt_IGV.Value = 0
        txt_Total.Value = 0
        udte_fecha.Value = Now
        ug_detalle.DisplayLayout.Bands(0).Columns("CD_DSCTO_PORC").CellActivation = Activation.AllowEdit
        '  utc_Informe.Tabs(0).Selected = True
        Tool_Imprimir.Enabled = True

        Call LimpiaGrid(ug_adelantos, uds_adelantos)
        Call LimpiaGrid(ug_consumos, uds_consumos)
        txt_TotalC.Text = "0.00"
        txt_TotalN.Text = "0.00"
        utc_vistas.Tabs(0).Selected = True

        uck_Procesar.Checked = False
        lbl_FProcesada.Visible = False
        udt_FProcesada.Visible = False
        udt_FProcesada.Value = Now
        uck_Procesar.Enabled = False
    End Sub

    Private Sub Cargar_Combos()

        Dim documentoscBL As New BL.AdmisionBL.SG_AD_TB_TIP_DOC_PER
        uce_tip_doc.DataSource = documentoscBL.getTiposDocs(gInt_IdEmpresa)
        uce_tip_doc.DisplayMember = "TD_ABREVIATURA"
        uce_tip_doc.ValueMember = "TD_ID"
        documentoscBL = Nothing

        Dim medicosBL As New BL.AdmisionBL.SG_AD_TB_MEDICO
        uce_Medico.DataSource = medicosBL.get_Medicos(gInt_IdEmpresa)
        uce_Medico.ValueMember = "ME_CODIGO"
        uce_Medico.DisplayMember = "NOMBRES"
        medicosBL = Nothing

        Dim asegBL As New BL.FacturacionBL.SG_FA_TB_CIA_ASEG
        ucm_SeguroEps.DataSource = asegBL.getAseguradoras(gInt_IdEmpresa)
        ucm_SeguroEps.DisplayMember = "CA_DESCRIPCION"
        ucm_SeguroEps.ValueMember = "CA_ID"
        asegBL = Nothing

        Dim OrigenBL As New BL.AdmisionBL.SG_AD_TB_ORIGEN_ATENC
        ucm_Tipo.DataSource = OrigenBL.getOrigen()
        ucm_Tipo.DisplayMember = "OA_DESCRIPCION"
        ucm_Tipo.ValueMember = "OA_ID"
        OrigenBL = Nothing
        ucm_Tipo.SelectedIndex = 0

        Dim cOBERTURABL As New BL.AdmisionBL.SG_AD_TB_COBERTURA
        'bscOBERTURA.DataSource = cOBERTURABL.getOrigen()
        'bscOBERTURA.Filter = String.Format("CB_IDTIPO_ORIGEN = '{0}'", .ucm_Tipo.Value)
        txt_DesCobertura.DataSource = cOBERTURABL.getOrigen()
        txt_DesCobertura.DisplayMember = "CB_DESCRIPCION"
        txt_DesCobertura.ValueMember = "CB_ID"
        cOBERTURABL = Nothing
    End Sub

    Private Sub Cargar_Tasas_Impuestos()

        Dim impuestosBL As New BL.ContabilidadBL.SG_CO_TB_IMPUESTO
        Dim impuestoBE As New BE.ContabilidadBE.SG_CO_TB_IMPUESTO

        impuestoBE.IM_IDEMPRESA = New BE.ContabilidadBE.SG_CO_TB_EMPRESA With {.EM_ID = gInt_IdEmpresa}
        impuestoBE.IM_IDTIPOIMPUESTO = New BE.ContabilidadBE.SG_CO_TB_TIPO_IMPUESTO With {.TI_CODIGO = "01"}
        impuestoBE.IM_PERIODO = Date.Now.Year
        impuestoBE.IM_MES = Date.Now.Month

        impuestosBL.getImpuestos_x_Tipo(impuestoBE)
        IGVTasa = impuestoBE.IM_TASA

        impuestosBL = Nothing
        impuestoBE = Nothing

    End Sub

    Private Sub Inicializar_Estado_BotonesPre(ByVal tool_ As ToolStrip)

        tool_.Items("Tool_Nuevo").Enabled = False
        tool_.Items("Tool_Editar").Enabled = False
        tool_.Items("Tool_Eliminar").Enabled = False
        tool_.Items("Tool_Imprimir").Enabled = False

        tool_.Items("Tool_Grabar").Enabled = False
        tool_.Items("Tool_Cancelar").Enabled = False
        tool_.Items("Tool_Salir").Enabled = True

    End Sub

    Private Sub Cargar_Consumo_Farmacia()
        Call LimpiaGrid(ug_consumos, uds_consumos)
        txt_TotalC.Text = "0.00"
        txt_TotalN.Text = "0.00"
        txt_TotalAdi.Text = "0.00"

        Dim ReporteBL As New BL.FacturacionBL.SG_FA_Reportes
        ug_consumos.DataSource = ReporteBL.get_ConsumoFarmacia(Val(txt_IdCuenta.Text), ucm_Tipo.Value)
        ReporteBL = Nothing
        Call Calcular_Totales_Consumos_Farmacia()
    End Sub
    Private Sub Cargar_Consumo_SalaBebes()
        Call LimpiaGrid(ug_SalaBebes, uds_SalaBebes)
        Call LimpiaGrid(ug_SalaBebeLog, uds_SalaBebeLog)

        Dim LogBL As New BL.LogisticaBL.SG_LO_TB_REQUERIMIENTO_C
        Dim LogBE As New BE.LogisticaBE.SG_LO_TB_REQUERIMIENTO_C
        LogBE.RC_IDCC = Val(txt_IdCuenta.Text)
        ug_SalaBebeLog.DataSource = LogBL.SEL04(LogBE)
        LogBL = Nothing

        Dim ConsumoBL As New BL.NeoBL.SA_TB_BB_CONSUMO
        ug_SalaBebes.DataSource = ConsumoBL.SEL03(Val(txt_IdCuenta.Text))
        ConsumoBL = Nothing
    End Sub

    Private Sub Calcular_Totales_Consumos_Farmacia()

        txt_TotalC.Text = ""
        txt_TotalN.Text = ""
        txt_TotalAdi.Text = ""
        Dim subtotalC As Decimal = "0.00"
        Dim subtotalN As Decimal = "0.00"
        Dim subtotalA As Decimal = "0.00"

        For i As Integer = 0 To ug_consumos.Rows.Count - 1
            If ug_consumos.Rows(i).Cells(7).Value = 1 Then
                subtotalC = subtotalC + Val(ug_consumos.Rows(i).Cells(6).Value.ToString)
            ElseIf ug_consumos.Rows(i).Cells(7).Value = 2 Then
                subtotalA = subtotalA + Val(ug_consumos.Rows(i).Cells(6).Value.ToString)
            Else
                subtotalN = subtotalN + Val(ug_consumos.Rows(i).Cells(6).Value.ToString)
            End If
        Next
        txt_TotalAdi.Value = Math.Round(subtotalA, 2)
        txt_TotalC.Value = Math.Round(subtotalC, 2)
        txt_TotalN.Value = Math.Round(subtotalN, 2)
    End Sub

    Private Sub AD_PR_Atencion_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Call Cargar_Combos()
        Call Inicializa()

        Call Inicializar_Estado_BotonesPre(ToolS_Mantenimiento)
        Call MostrarTabs(0, utc_Datos, 0)

        txt_Ruc_ClientesC.ButtonsRight(0).Appearance.Image = My.Resources._104
        txt_idDiagnostico.ButtonsRight(0).Appearance.Image = My.Resources._104
        txt_ruc_cliente.ButtonsRight(0).Appearance.Image = My.Resources._104
        txt_IdCuenta.ButtonsRight(0).Appearance.Image = My.Resources._104
        txt_IDPresupuesto.ButtonsRight(0).Appearance.Image = My.Resources._104
        ubt_Agregar.Appearance.Image = My.Resources._16__Plus_
        ubt_Quitar.Appearance.Image = My.Resources._16__Delete_

        ubtn_ActualizarPre.Appearance.Image = My.Resources.arrow_refresh
        ubtn_ConsultarConsumo.Appearance.Image = My.Resources.arrow_refresh
        ubt_ActSalaBebe.Appearance.Image = My.Resources.arrow_refresh

        utc_vistas.Tabs(0).Appearance.Image = My.Resources._590
        utc_vistas.Tabs(1).Appearance.Image = My.Resources._1030
        utc_vistas.Tabs(2).Appearance.Image = My.Resources._092
        ubtn_imprimir_consu.Appearance.Image = My.Resources._004

        obe = New BE.FacturacionBE.SG_FA_TB_PRE_FACTURA_CAB
        obr = New BL.FacturacionBL.SG_FA_TB_PRE_FACTURA_CAB
        obeT = New BE.AdmisionBE.TMP_SG_AD_TB_CUENTA_DET
        obrT = New BL.AdmisionBL.SG_AD_TB_CUENTA_CAB
        obeC = New BE.AdmisionBE.SG_AD_TB_CUENTA_CAB

        Call Cargar_Tasas_Impuestos()

        Me.KeyPreview = True

    End Sub

    '----Diagnostico CIE10
    Private Sub txt_idDiagnostico_EditorButtonClick(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinEditors.EditorButtonEventArgs) Handles txt_idDiagnostico.EditorButtonClick
        Select Case e.Button.Key
            Case "ayuda"
                Call Ayuda_Anexo_Cab_T()
            Case "editar"

        End Select
    End Sub
    Private Sub txt_idDiagnostico_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_idDiagnostico.KeyDown
        'If e.KeyCode = Keys.Enter Then
        '    Call Buscar_Tratamiento()
        'End If

        If e.KeyCode = Keys.F2 Then Call Ayuda_Anexo_Cab_T()
    End Sub
    Private Sub txt_idDiagnostico_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_idDiagnostico.ValueChanged
        If txt_idDiagnostico.Text.Trim.Length = 0 Then
            txt_idDiagnostico.Text = String.Empty
        End If
    End Sub
    Private Sub Ayuda_Anexo_Cab_T()
        FA_PR_ListaDiagnostico.ShowDialog()

        Dim matriz As List(Of String) = FA_PR_ListaDiagnostico.GetLista

        If matriz.Count > 0 Then
            idDiagnostico = matriz(0)
            txt_idDiagnostico.Text = matriz(1)
        End If

    End Sub

    '-------------pacientes clientes

    Private Sub Ayuda_Anexo_Cab()
        ' FA_PR_ListaClientesAyuda.Int_Opcion = 1
        AD_PR_BuscaPaciente.ShowDialog()

        Dim matriz As List(Of String) = AD_PR_BuscaPaciente.GetLista

        'txt_ruc_cliente.ButtonsRight("editar").Enabled = False

        If matriz.Count > 0 Then

            txt_IdCliente.Text = matriz(1)
            txt_idHistoria.Text = matriz(0)
            Format(Val(txt_idHistoria.Text), "0000000000#")
            txt_ruc_cliente.Text = matriz(9)
            uce_tip_doc.Value = matriz(8)
            txt_Des_Cliente.Text = matriz(2)
            'udte_fechaNac.Value = matriz(10)
            'txt_Edad.Value = Int(DateDiff("m", matriz(10), Date.Now) / 12)
            ' txt_ruc_cliente.ButtonsRight("editar").Enabled = True

            txt_idClienteC.Text = matriz(1)
            txt_Ruc_ClientesC.Text = matriz(9)
            txt_Des_ClienteC.Text = matriz(2)

        End If

    End Sub
    Private Sub Ayuda_Anexo_Cab_C()
        FA_PR_ListaClientesAyuda.Int_Opcion = 1
        FA_PR_ListaClientesAyuda.ShowDialog()

        Dim matriz As List(Of String) = FA_PR_ListaClientesAyuda.GetLista

        'txt_ruc_cliente.ButtonsRight("editar").Enabled = False

        If matriz.Count > 0 Then
            txt_idClienteC.Text = matriz(0)
            txt_Ruc_ClientesC.Text = matriz(1)
            txt_Des_ClienteC.Text = matriz(2)
            ' txt_ruc_cliente.ButtonsRight("editar").Enabled = True
        End If

    End Sub

    Private Sub Buscar_Cliente()

        Dim clienteBL As New BL.AdmisionBL.SG_AD_TB_HISTO_CLINI
        Dim clienteBE As New BE.AdmisionBE.SG_AD_TB_HISTO_CLINI

        clienteBE.HC_NDOC = txt_ruc_cliente.Text.Trim
        clienteBE.HC_IDEMPRESA = gInt_IdEmpresa
        clienteBE.HC_TDOC = uce_tip_doc.Value
        clienteBL.get_Historias_x_Doc(clienteBE)

        If clienteBE.HasRow Then
            txt_IdCliente.Text = clienteBE.HC_IDCLIENTE
            txt_idHistoria.Text = clienteBE.HC_NUM_HIST
            txt_Des_Cliente.Text = clienteBE.HC_NOMBRE1
            Format(Val(txt_idHistoria.Text), "0000000000#")
            txt_idClienteC.Text = clienteBE.HC_IDCLIENTE
            txt_Ruc_ClientesC.Text = txt_ruc_cliente.Text.Trim
            txt_Des_ClienteC.Text = clienteBE.HC_NOMBRE1
        Else
            uce_Medico.Enabled = True
            Avisar("El Paciente no existe!")
        End If

        clienteBE = Nothing
        clienteBL = Nothing

    End Sub
    Private Sub Buscar_Cliente_C()

        Dim clienteBL As New BL.FacturacionBL.SG_FA_TB_CLIENTE
        Dim clienteBE As New BE.FacturacionBE.SG_FA_TB_CLIENTE

        clienteBE.CL_NDOC = txt_ruc_cliente.Text.Trim
        clienteBE.CL_IDEMPRESA = New BE.ContabilidadBE.SG_CO_TB_EMPRESA With {.EM_ID = gInt_IdEmpresa}
        clienteBL.get_Cliente_x_Ruc(clienteBE)

        If clienteBE.HasRow Then
            txt_IdCliente.Text = clienteBE.CL_ID
            txt_Des_Cliente.Text = clienteBE.CL_NOMBRE
            uchk_SeguroEps.Focus()
        Else

            If Preguntar("El cliente no existe!, Desea Crearlo?") Then

                FA_PR_IngClienteRapido.str_num_ruc = txt_ruc_cliente.Text.Trim
                FA_PR_IngClienteRapido.ShowDialog()
                If FA_PR_IngClienteRapido.bol_Grabo Then
                    clienteBL.get_Cliente_x_Ruc(clienteBE)
                    If clienteBE.HasRow Then
                        txt_IdCliente.Text = clienteBE.CL_ID
                        txt_Des_Cliente.Text = clienteBE.CL_NOMBRE
                        uchk_SeguroEps.Focus()
                    End If
                End If
            End If

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
            txt_IdCliente.Text = String.Empty
            txt_Des_Cliente.Text = String.Empty
        End If
    End Sub
    Private Sub txt_ruc_cliente_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_ruc_cliente.KeyDown
        If e.KeyCode = Keys.Enter Or e.KeyCode = Keys.Tab Then
            Call Buscar_Cliente()
        End If

        If e.KeyCode = Keys.F2 Then Call Ayuda_Anexo_Cab()
    End Sub

    Private Sub txt_Ruc_ClientesC_EditorButtonClick(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinEditors.EditorButtonEventArgs) Handles txt_Ruc_ClientesC.EditorButtonClick
        Select Case e.Button.Key
            Case "ayuda"
                Call Ayuda_Anexo_Cab_C()
            Case "editar"

        End Select
    End Sub
    Private Sub txt_Ruc_ClientesC_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_Ruc_ClientesC.KeyDown
        If e.KeyCode = Keys.Enter Then
            Call Buscar_Cliente_C()
        End If

        If e.KeyCode = Keys.F2 Then Call Ayuda_Anexo_Cab_C()
    End Sub
    Private Sub txt_Ruc_ClientesC_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_Ruc_ClientesC.ValueChanged
        If txt_Ruc_ClientesC.Text.Trim.Length = 0 Then
            txt_idClienteC.Text = String.Empty
            txt_Des_ClienteC.Text = String.Empty
        End If
    End Sub
    Private Sub uchk_GenerarCta_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles uchk_GenerarCta.CheckedChanged
        If uchk_GenerarCta.Checked = True Then
            txt_IdCuenta.Enabled = True
        Else
            txt_IdCuenta.Text = ""
            txt_IdCuenta.Enabled = False
        End If
    End Sub
    Private Sub uchk_Presupuesto_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles uchk_Presupuesto.CheckedChanged
        If uchk_Presupuesto.Checked = True Then
            txt_IDPresupuesto.Enabled = True
        Else
            txt_IDPresupuesto.Text = ""
            txt_IDPresupuesto.Enabled = False
        End If
    End Sub
    Private Sub uchk_SeguroEps_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles uchk_SeguroEps.CheckedChanged
        If uchk_SeguroEps.Checked = True Then
            ucm_SeguroEps.Enabled = True
            ugb_Cuenta.Enabled = True
            ucm_SeguroEps.SelectedIndex = 0
            ug_detalle.DisplayLayout.Bands(0).Columns("CD_DSCTO_PORC").CellActivation = Activation.NoEdit
        Else
            ucm_SeguroEps.SelectedIndex = -1
            ucm_SeguroEps.Enabled = False
            ugb_Cuenta.Enabled = False
            ug_detalle.DisplayLayout.Bands(0).Columns("CD_DSCTO_PORC").CellActivation = Activation.AllowEdit
            Call Limpiar_Controls_InGroupox(ugb_Cuenta)
            Calcular_Copago(0)
            Calcular_Totales()
        End If
    End Sub

    Private Sub Calcular_Copago(ByVal CambioVariable As Integer)
        'ug_detalle.Rows(ug_detalle.Rows.Count - 1).Cells(17).Value = Val(txt_PagoVariable.Text)

        For i As Integer = 0 To ug_detalle.Rows.Count - 1
            Dim igv_cal As Decimal = "0.00"
            Dim total_cal As Decimal = "0.00"
            Dim subtotal_cal As Decimal = "0.00"
            Dim descuentoSeg As Decimal = "0.00"
            Dim Precio As Decimal = 0


            If uchk_SeguroEps.Checked = True Then
                If ug_detalle.Rows(i).Cells(6).Value = True Then
                    descuentoSeg = (ug_detalle.Rows(i).Cells(4).Value * ug_detalle.Rows(i).Cells(0).Value) - Val(txt_PagoFijo.Text)
                End If

                If ug_detalle.Rows(i).Cells(5).Value = True Then
                    Precio = IIf(ug_detalle.Rows(i).Cells(6).Value = False, (ug_detalle.Rows(i).Cells(4).Value * ug_detalle.Rows(i).Cells(0).Value), descuentoSeg)
                    ' Precio = (ug_detalle.Rows(i).Cells(4).Value * ug_detalle.Rows(i).Cells(0).Value) - descuentoSeg
                    If CambioVariable = 1 Then
                        descuentoSeg = Math.Round(((Precio * Val(txt_PagoVariable.Value)) / 100), 2)
                        ug_detalle.Rows(i).Cells(17).Value = Val(txt_PagoVariable.Text)
                    Else
                        If Val(ug_detalle.Rows(i).Cells(17).Value) = Val(txt_PagoVariable.Value) Then
                            descuentoSeg = Math.Round(((Precio * Val(txt_PagoVariable.Value)) / 100), 2)
                        Else
                            descuentoSeg = Math.Round(((Precio * Val(ug_detalle.Rows(i).Cells(17).Value)) / 100), 2)
                        End If
                    End If

                End If
            Else
                descuentoSeg = 0.0
            End If


            subtotal_cal = Math.Round((ug_detalle.Rows(i).Cells(4).Value * ug_detalle.Rows(i).Cells(0).Value) - descuentoSeg - ug_detalle.Rows(i).Cells(8).Value, 2)
            igv_cal = Math.Round((subtotal_cal * IGVTasa) / 100, 2)
            total_cal = Math.Round(subtotal_cal + igv_cal, 2)

            With obeT
                .TCD_CANT = ug_detalle.Rows(i).Cells(0).Value
                .TCD_IDARTICULO = ug_detalle.Rows(i).Cells(1).Value
                .TCD_ITEM = ug_detalle.Rows(i).Cells(14).Value
                .TCD_PRECIO = ug_detalle.Rows(i).Cells(4).Value
                .TCD_SINPAGO = ug_detalle.Rows(i).Cells(15).Value
                .TCD_DSCTO_OTRO = ug_detalle.Rows(i).Cells(8).Value
                .TCD_SEG_CUBRE = IIf(ug_detalle.Rows(i).Cells(5).Value = True, 1, 0)
                .TCD_DEDUCIBLE = IIf(ug_detalle.Rows(i).Cells(6).Value = True, 1, 0)
                .TCD_DESCUENTO = descuentoSeg
                .TCD_SUB_TOTAL = subtotal_cal
                .TCD_IGV = igv_cal
                .TCD_TOTAL = total_cal
                .TCD_DSCTO_PORC = 0
            End With
            obrT.Update_TMP(obeT, String.Format("{0}-{1}", Environment.UserName, gStr_Usuario_Sis), Environment.MachineName)

            ug_detalle.Rows(i).Cells("Descuento").Value = descuentoSeg
            ug_detalle.Rows(i).Cells(9).Value = subtotal_cal
            ug_detalle.Rows(i).Cells(10).Value = igv_cal
            ug_detalle.Rows(i).Cells(11).Value = total_cal
        Next

    End Sub
    Private Sub Calcular_Totales()

        txt_SubTotal.Text = ""
        txt_IGV.Text = ""
        txt_Total.Text = ""
        Dim subtotal As Decimal = "0.00"
        'Dim igv As Decimal = "0.00"
        'Dim total As Decimal = "0.00"
        For i As Integer = 0 To ug_detalle.Rows.Count - 1
            If ug_detalle.Rows(i).Hidden = False Then
                subtotal = subtotal + Val(ug_detalle.Rows(i).Cells(9).Value.ToString)
                'igv = igv + Val(ug_detalle.Rows(i).Cells(10).Value.ToString)
                'total = total + Val(ug_detalle.Rows(i).Cells(11).Value.ToString)
            End If
        Next

        txt_SubTotal.Value = Math.Round(subtotal, 2)
        txt_IGV.Value = Math.Round(subtotal * (IGVTasa / 100), 2)
        txt_Total.Value = Math.Round(CType(txt_SubTotal.Value, Decimal) + CType(txt_IGV.Value, Decimal), 2)
    End Sub

    Private Sub Cargar_Adelantos_Pagos()
        Call LimpiaGrid(ug_adelantos, uds_adelantos)
        Dim comprobanteBL As New BL.FacturacionBL.SG_FA_TB_COMPROBANTE_C
        ug_adelantos.DataSource = comprobanteBL.get_adelantos_x_Historia(CInt(txt_idHistoria.Text), gInt_IdEmpresa)
        comprobanteBL = Nothing
    End Sub

    Private Sub txt_PagoFijo_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_PagoFijo.ValueChanged
        Calcular_Copago(0)
        Calcular_Totales()
    End Sub
    Private Sub txt_PagoVariable_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_PagoVariable.ValueChanged
        Calcular_Copago(1)
        Calcular_Totales()
    End Sub

    Private Sub ubt_Agregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ubt_Agregar.Click

        Dim igv_cal As Decimal = "0.00"
        Dim total_cal As Decimal = "0.00"
        Dim subtotal_cal As Decimal = "0.00"
        Dim descuento As Decimal = "0.00"

        AD_PR_ListaArticulosSeg.TipoSeg = IIf(uchk_SeguroEps.Checked = True, 1, 0)
        If uchk_SeguroEps.Checked = False Then
            AD_PR_ListaArticulosSeg.idSeguro = "000"
        Else
            AD_PR_ListaArticulosSeg.idSeguro = ucm_SeguroEps.Value.ToString
        End If
        AD_PR_ListaArticulosSeg.idMedico = uce_Medico.Value
        'AD_PR_ListaArticulosSeg.idSeguro = IIf(uchk_SeguroEps.Checked = False, "000", ucm_SeguroEps.Value.ToString)
        AD_PR_ListaArticulosSeg.IGVTas = IGVTasa
        AD_PR_ListaArticulosSeg.ShowDialog()

        Dim matriz As List(Of BE.FacturacionBE.SG_FA_TB_ARTICULO) = AD_PR_ListaArticulosSeg.GetLista

        For Each articulo As BE.FacturacionBE.SG_FA_TB_ARTICULO In matriz

            If uchk_SeguroEps.Checked = True Then
                descuento = Math.Round((articulo.AR_PRECIO_VENTA * Val(txt_PagoVariable.Value)) / 100, 2)
            Else
                descuento = 0.0
            End If

            subtotal_cal = Math.Round(articulo.AR_PRECIO_VENTA - descuento, 2)
            igv_cal = Math.Round((subtotal_cal * IGVTasa) / 100, 2)
            total_cal = Math.Round(subtotal_cal + igv_cal, 2)

            Dim valItem As Integer = 0
            For i As Integer = 0 To ug_detalle.Rows.Count - 1
                If ug_detalle.Rows(i).Cells(14).Value > valItem Then
                    valItem = ug_detalle.Rows(i).Cells(14).Value
                End If
            Next

            ug_detalle.DisplayLayout.Bands(0).AddNew()
            ug_detalle.Rows(ug_detalle.Rows.Count - 1).Cells(0).Value = 1 ' cant
            ug_detalle.Rows(ug_detalle.Rows.Count - 1).Cells(1).Value = articulo.AR_ID  ' codigo id
            ug_detalle.Rows(ug_detalle.Rows.Count - 1).Cells(2).Value = articulo.AR_CODIGO 'codigo
            ug_detalle.Rows(ug_detalle.Rows.Count - 1).Cells(3).Value = articulo.AR_DESCRIPCION  'descripcion
            ug_detalle.Rows(ug_detalle.Rows.Count - 1).Cells(4).Value = articulo.AR_PRECIO_VENTA  'costo
            ug_detalle.Rows(ug_detalle.Rows.Count - 1).Cells(5).Value = True  'CUBRE
            ug_detalle.Rows(ug_detalle.Rows.Count - 1).Cells(6).Value = False  'DEDUCIBLE
            ug_detalle.Rows(ug_detalle.Rows.Count - 1).Cells(7).Value = descuento 'descuen
            ug_detalle.Rows(ug_detalle.Rows.Count - 1).Cells(8).Value = 0.0 'descuen
            ug_detalle.Rows(ug_detalle.Rows.Count - 1).Cells(9).Value = subtotal_cal 'sub tot
            ug_detalle.Rows(ug_detalle.Rows.Count - 1).Cells(10).Value = igv_cal 'igv
            ug_detalle.Rows(ug_detalle.Rows.Count - 1).Cells(11).Value = total_cal ' total
            ug_detalle.Rows(ug_detalle.Rows.Count - 1).Cells(12).Value = articulo.CA_Consulta ' consul
            ug_detalle.Rows(ug_detalle.Rows.Count - 1).Cells(13).Value = 0 ' comprobante
            ug_detalle.Rows(ug_detalle.Rows.Count - 1).Cells(14).Value = valItem + 1 ' items
            ug_detalle.Rows(ug_detalle.Rows.Count - 1).Cells(15).Value = 0 ' SIN PAGO
            ug_detalle.Rows(ug_detalle.Rows.Count - 1).Cells(16).Value = 0
            ug_detalle.Rows(ug_detalle.Rows.Count - 1).Cells(17).Value = Val(txt_PagoVariable.Text)
            'descuento 0
            'ValModifi = 1
            ug_detalle.UpdateData()
            ug_detalle.Refresh()
            'ValModifi = 0
            With obeT
                .TCD_CANT = 1
                .TCD_DESCUENTO = descuento
                .TCD_IDARTICULO = articulo.AR_ID
                .TCD_IDCAB = 0
                .TCD_IGV = igv_cal
                .TCD_ITEM = valItem + 1
                .TCD_PRECIO = articulo.AR_PRECIO_VENTA
                .TCD_SUB_TOTAL = subtotal_cal
                .TCD_TOTAL = total_cal

                .TCD_SINPAGO = 0
                .TCD_DSCTO_OTRO = 0.0
                .TCD_SEG_CUBRE = IIf(uchk_SeguroEps.Checked = True, 1, 0)
                .TCD_DEDUCIBLE = 0

            End With
            obrT.Insert_TMP(obeT, String.Format("{0}-{1}", Environment.UserName, gStr_Usuario_Sis), Environment.MachineName)
        Next
        'Call Calcular_Totales()
    End Sub
    Private Sub ubt_Quitar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ubt_Quitar.Click
        If ug_detalle.Rows.Count = 0 Then Exit Sub
        If ug_detalle.ActiveRow Is Nothing Then Exit Sub

        If ucm_Tipo.Value = 1 And ug_detalle.ActiveRow.Cells(1).Value <> 179 And ug_detalle.ActiveRow.Cells(1).Value <> 389 And ug_detalle.ActiveRow.Cells(1).Value <> 4793 And ug_detalle.ActiveRow.Cells(1).Value <> 408 And ug_detalle.ActiveRow.Cells(1).Value <> 508 Then
            'If ug_detalle.ActiveRow.Cells(13).Value <> 0 And ucm_Tipo.Value = 1 Then  :
            Call Avisar("No Puede Modificar El Servicio")
            Exit Sub
        End If

        'If ug_detalle.ActiveRow.Cells(13).Value <> 0 And ucm_Tipo.Value = 1 Then
        '    Call Avisar("El Servicio ya fue Cancelado")
        '    Exit Sub
        'End If

        If Preguntar("Seguro que deseas eliminar el registro?") Then
            'ug_detalle.ActiveRow.Delete()
            obeT.TCD_ITEM = ug_detalle.ActiveRow.Cells(14).Value
            If obrT.Delete_TMP(obeT, String.Format("{0}-{1}", Environment.UserName, gStr_Usuario_Sis), Environment.MachineName) = -2 Then
                Call Avisar("No se puede eliminar registro con Cita")
                Exit Sub
            Else
                ug_detalle.ActiveRow.Hidden = True
            End If

            Call Calcular_Totales()
        End If

        'ug_detalle.Rows(ug_detalle.Rows.Count - 1).Hidden = True
    End Sub

    Private Sub ug_Detalle_AfterRowUpdate(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinGrid.RowEventArgs) Handles ug_detalle.AfterRowUpdate
        'e.Row.Cells("Total").Value = e.Row.Cells("Precio").Value * e.Row.Cells("Cant").Value

        Dim igv_cal As Decimal = "0.00"
        Dim total_cal As Decimal = "0.00"
        Dim subtotal_cal As Decimal = "0.00"
        Dim descuentoSeg As Decimal = "0.00"
        Dim descuentoOtro As Decimal = "0.00"
        Dim Precio As Decimal = 0.0

        If uchk_SeguroEps.Checked = True Then
            If e.Row.Cells(6).Value = True Then
                descuentoSeg = (e.Row.Cells(4).Value * e.Row.Cells(0).Value) - Val(txt_PagoFijo.Text)
            End If
            If e.Row.Cells(5).Value = True Then
                Precio = IIf(e.Row.Cells(6).Value = False, (e.Row.Cells(4).Value * e.Row.Cells(0).Value), descuentoSeg)
                'Precio = (e.Row.Cells(4).Value * e.Row.Cells(0).Value) - descuentoSeg
                If Val(e.Row.Cells(17).Value) = Val(txt_PagoVariable.Value) Then
                    descuentoSeg = Math.Round(((Precio * Val(txt_PagoVariable.Value)) / 100), 2)
                Else
                    descuentoSeg = Math.Round(((Precio * Val(e.Row.Cells(17).Value)) / 100), 2)
                End If
            End If
        Else
            descuentoSeg = 0.0
            descuentoOtro = Math.Round((e.Row.Cells(4).Value * e.Row.Cells(0).Value) * (CType(e.Row.Cells("CD_DSCTO_PORC").Value, Integer) / 100), 2)
        End If

        subtotal_cal = Math.Round((e.Row.Cells(4).Value * e.Row.Cells(0).Value) - descuentoSeg - descuentoOtro, 2)
        igv_cal = Math.Round((subtotal_cal * IGVTasa) / 100, 2)
        total_cal = Math.Round(subtotal_cal + igv_cal, 2)

        With obeT
            .TCD_CANT = e.Row.Cells(0).Value
            .TCD_IDARTICULO = e.Row.Cells(1).Value
            .TCD_ITEM = e.Row.Cells(14).Value
            .TCD_PRECIO = e.Row.Cells(4).Value
            .TCD_SINPAGO = e.Row.Cells(15).Value
            .TCD_DSCTO_OTRO = descuentoOtro 'e.Row.Cells(8).Value
            .TCD_SEG_CUBRE = IIf(e.Row.Cells(5).Value = True, 1, 0)
            .TCD_DEDUCIBLE = IIf(e.Row.Cells(6).Value = True, 1, 0)
            .TCD_DESCUENTO = descuentoSeg
            .TCD_SUB_TOTAL = subtotal_cal
            .TCD_IGV = igv_cal
            .TCD_TOTAL = total_cal
            .TCD_DSCTO_PORC = e.Row.Cells("CD_DSCTO_PORC").Value
        End With
        obrT.Update_TMP(obeT, String.Format("{0}-{1}", Environment.UserName, gStr_Usuario_Sis), Environment.MachineName)


        e.Row.Cells(7).Value = descuentoSeg
        e.Row.Cells(8).Value = descuentoOtro
        e.Row.Cells(9).Value = subtotal_cal
        e.Row.Cells(10).Value = igv_cal
        e.Row.Cells(11).Value = total_cal

        Call Calcular_Totales()

    End Sub

    Private Sub ug_Detalle_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles ug_detalle.KeyDown

        If e.KeyCode = Keys.Enter Then
            ug_detalle.PerformAction(UltraGridAction.NextCellByTab, False, False)
            ug_detalle.UpdateData()
        End If

    End Sub

    Private Sub ug_Detalle_BeforeRowsDeleted(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.BeforeRowsDeletedEventArgs) Handles ug_detalle.BeforeRowsDeleted

        e.DisplayPromptMsg = False
        e.Cancel = False
    End Sub

    Private Sub ug_detalle_BeforeRowUpdate(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinGrid.CancelableRowEventArgs) Handles ug_detalle.BeforeRowUpdate
        If ValModifi = 0 And ucm_Tipo.Value = 1 And e.Row.Cells(1).Value <> 179 And e.Row.Cells(1).Value <> 389 And e.Row.Cells(1).Value <> 4793 And e.Row.Cells(1).Value <> 408 And e.Row.Cells(1).Value <> 508 Then
            'If ug_detalle.ActiveRow.Cells(13).Value <> 0 And ucm_Tipo.Value = 1 Then  :
            Call Avisar("No Puede Modificar El Servicio")
            e.Cancel = True
        Else
            ValModifi = 0
        End If
    End Sub

    '--menu
    Private Sub Tool_Grabar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_Grabar.Click
        Dim descuentoSeg As Decimal = "0.00"
        'If DateAdd(DateInterval.Day, 7, udte_fecha.Value.date) >= Now.Date And ucm_Tipo.Value = 1 Then
        '    Avisar("La Cuenta Ambulatoria tiene 7 dias para ser modificada, porfavor esperar ese plazo para pre-facturar")
        '    Exit Sub
        'End If

        If Val(utxt_IdTratamiento.Text) = 0 And ucm_Tipo.Value <> 1 And Val(txt_IDPresupuesto.Value) = 0 Then
            Avisar("Seleccione el Tratamiento")
            Exit Sub
        End If
        If uchk_SeguroEps.Checked = True And ucm_Tipo.Value = 2 Then
            For i As Integer = 0 To ug_detalle.Rows.Count - 1
                If ug_detalle.Rows(i).Cells(6).Value = True Or ug_detalle.Rows(i).Cells(5).Value = True Then
                    descuentoSeg = descuentoSeg + ug_detalle.Rows(i).Cells(7).Value
                End If
            Next
            If descuentoSeg > txt_MontoImponible.Value Then
                If Not Preguntar("El limite de garantia a exedido, Desea Continuar?") Then
                    txt_MontoImponible.Focus()
                    Exit Sub
                End If
            End If
        End If

        If fValida() = False Then Exit Sub
        With obe
            .PF_IDCUENTA = Val(txt_IdCuenta.Value)
            .PF_IDPRESUPUESTO = Val(txt_IDPresupuesto.Value)
            .PF_IDTIPO_ATENC = IIf(uchk_SeguroEps.Checked = True, 2, 1)
            .PF_IDSEGURO = IIf(uchk_SeguroEps.Checked = True, ucm_SeguroEps.Value, "")
            .PF_IDNUMHIST = Val(txt_idHistoria.Value)
            .PF_IDCLIENTE = Val(txt_IdCliente.Value)
            .PF_IDMEDICO = uce_Medico.Value
            .PF_SUBTOTAL = Val(txt_SubTotal.Text)
            .PF_TOTAL = Val(txt_Total.Text)
            .PF_IGV = Val(txt_IGV.Text)
            .PF_IDEMPRESA = gInt_IdEmpresa
            .PF_FECHA = udte_fecha.Value
            .PF_IDCIE10 = idDiagnostico
            .PF_USUARIO = String.Format("{0}-{1}", Environment.UserName, gStr_Usuario_Sis)
            .PF_TERMINAL = Environment.MachineName
            .PF_FECHAIngreso = IIf(udtpFechaIngreso.Value = Nothing, Now, udtpFechaIngreso.Value)
            .PF_FECHAAlta = IIf(udtpFechaAlta.Value = Nothing, Now, udtpFechaAlta.Value)
            .PF_Tratamiento = txt_Tratamiento.Text
            .PF_IDPaquete = Val(utxt_IdTratamiento.Text)
            .PF_FacTramite = urb_estaCuenta.Value
        End With

        'CUENTA
        Dim TIPO As Integer = 0
        If txt_IdCuenta.Text = "" Then
            TIPO = 0
        Else
            TIPO = 1
            obeC.CC_ID = Val(txt_IdCuenta.Text)
        End If

        Dim AsegBL As New BL.FacturacionBL.SG_FA_TB_CIA_ASEG
        Dim AsegBE As New BE.FacturacionBE.SG_FA_TB_CIA_ASEG
        Dim cODIGOeps As String
        AsegBE.CA_ID = ucm_SeguroEps.Value
        AsegBE.CA_IDEMPRESA = gInt_IdEmpresa
        AsegBL.get_Aseguradora_x_id(AsegBE)
        cODIGOeps = AsegBE.CA_IDASEGU_SITED

        With obeC
            .CC_IDTIPO_ORI = ucm_Tipo.Value
            .CC_IDNUM_HIST = Val(txt_idHistoria.Value)
            .CC_IDCLIENTE = Val(txt_IdCliente.Value)
            .CC_IDTIPO_ATENC = IIf(uchk_SeguroEps.Checked = True, 2, 1)
            .CC_IDSEGURO = IIf(uchk_SeguroEps.Checked = True, ucm_SeguroEps.Value, "")
            .CC_FECHA = udte_fecha.Value

            .CC_USUARIO = String.Format("{0}-{1}", Environment.UserName, gStr_Usuario_Sis)
            .CC_TERMINAL = Environment.MachineName
            .CC_IDEMPRESA = gInt_IdEmpresa
            .CC_SIT_COD_EPS = cODIGOeps
            .CC_SIT_COD_ASEG = txt_CodAsegurado.Text
            .CC_SIT_FEC_AUTORI = IIf(txt_FechaAutoriza.Value = Nothing, Date.Now, txt_FechaAutoriza.Value)
            .CC_SIT_COD_COBER = IIf(txt_DesCobertura.SelectedIndex = -1, 0, txt_DesCobertura.Value)

            .CC_SIT_COPG_FIJO = Val(txt_PagoFijo.Text)
            .CC_SIT_COPG_VARI = Val(txt_PagoVariable.Text)
            .CC_SIT_COD_GENE = txt_CodAutoriza.Text
            .CC_INGRESO_MANUAL = 1
            .CC_TIPOAFILIACION = ucbo_TipoAfiliacion.Value
            .CC_SIT_MONTO_IMP = txt_MontoImponible.Value

            .CC_ESTADO_PROC = IIf(uck_Procesar.Checked = True, 1, 0)
            .CC_FECHA_PROC = udt_FProcesada.Value
        End With

        Dim obeT2 As BE.FacturacionBE.SG_FA_TB_PRESUPUESTO_DET
        ug_detalle.UpdateData()
        obe.Detalles.Clear()
        For i As Integer = 0 To ug_detalle.Rows.Count - 1
            obeT2 = New BE.FacturacionBE.SG_FA_TB_PRESUPUESTO_DET
            With obeT2
                .DP_ID = Nothing
                .DP_ITEMS = i + 1
                .DP_IDARTICULO = ug_detalle.Rows(i).Cells(1).Value
                .DP_CANT = ug_detalle.Rows(i).Cells(0).Value
                .DP_PRECIO = ug_detalle.Rows(i).Cells(4).Value
                .DP_DSCTO_SEG = ug_detalle.Rows(i).Cells(7).Value
                .DP_DSCTO_OTRO = ug_detalle.Rows(i).Cells(8).Value
                .DP_SUB_TOTAL = ug_detalle.Rows(i).Cells(9).Value
                .DP_IGV = ug_detalle.Rows(i).Cells(10).Value
                .DP_TOTAL = ug_detalle.Rows(i).Cells(11).Value
                .DP_SEG_CUBRE = IIf(ug_detalle.Rows(i).Cells(5).Value = True, 1, 0)
                .DP_DEDUCIBLE = IIf(ug_detalle.Rows(i).Cells(6).Value = True, 1, 0)
            End With
            obe.Detalles.Add(obeT2)
        Next

        If lNew Then
            Dim I As Integer
            I = obr.Insert(obe, obeC, String.Format("{0}-{1}", Environment.UserName, gStr_Usuario_Sis), Environment.MachineName, TIPO, IIf(udtpFechaIngreso.Value = Nothing, 0, 1), IIf(udtpFechaAlta.Value = Nothing, 0, 1))
            txt_IdCuenta.Text = I
            If I < 0 Then
                MessageBox.Show("La operación solicitada no ha podido ser realizada", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If
        Else
            obe.PF_ID = Val(txt_idPreFactura.Text)
            Dim I As Integer
            I = obr.Update(obe, obeC, String.Format("{0}-{1}", Environment.UserName, gStr_Usuario_Sis), Environment.MachineName, TIPO, IIf(udtpFechaIngreso.Value = Nothing, 0, 1), IIf(udtpFechaAlta.Value = Nothing, 0, 1))
            If I < 0 Then
                MessageBox.Show("La operación solicitada no ha podido ser realizada", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If
        End If
        Call Avisar("Listo!")

        Call Inicializar_Estado_BotonesPre(ToolS_Mantenimiento)
        Tool_Imprimir.Enabled = True
        ucm_SeguroEps.Enabled = False
        ugb_Cuenta.Enabled = False
        txt_IdCuenta.Enabled = False
        txt_IDPresupuesto.Enabled = False

        uchk_GenerarCta.Enabled = True
        uchk_Presupuesto.Enabled = True

        ubt_Agregar.Enabled = False
        ubt_Quitar.Enabled = False
        'ubt_Consumo.Enabled = False
        uchk_SeguroEps.Enabled = False
        uce_Medico.Enabled = False
        ucm_Tipo.Enabled = False
        txt_Ruc_ClientesC.Enabled = False
        txt_idDiagnostico.Enabled = False
        udtpFechaAlta.Enabled = False
        udtpFechaIngreso.Enabled = False
        txt_Tratamiento.Enabled = False
        ug_detalle.Enabled = False
        uck_Procesar.Enabled = False
        'Call Tool_Cancelar_Click(sender, e)

    End Sub

    Private Sub Tool_Salir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_Salir.Click
        Me.Close()
    End Sub

    Private Sub Tool_Nuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_Nuevo.Click
        If txt_idPreFactura.Text <> "" Then
            Avisar("Registro ya Tiene Pre-Factura")
            Exit Sub
        End If

        Call Inicializar_Estado_BotonesPre(ToolS_Mantenimiento)
        'Inicializa()
        lNew = True

        uchk_GenerarCta.Enabled = False
        uchk_Presupuesto.Enabled = False
        txt_IdCuenta.Enabled = False
        txt_IDPresupuesto.Enabled = False

        urb_estaCuenta.Enabled = True
        ub_Detallar.Enabled = True
        ubnt_Tratamiento.Enabled = True

        If uchk_SeguroEps.Checked = True Then
            ugb_Cuenta.Enabled = True
        Else
            ugb_Cuenta.Enabled = False
        End If

        ubt_Agregar.Enabled = True
        ubt_Quitar.Enabled = True
        'ubt_Consumo.Enabled = True
        uchk_SeguroEps.Enabled = True
        uce_Medico.Enabled = True
        ucm_Tipo.Enabled = True
        txt_Ruc_ClientesC.Enabled = True
        txt_idDiagnostico.Enabled = True
        udtpFechaAlta.Enabled = True
        udtpFechaIngreso.Enabled = True
        txt_Tratamiento.Enabled = True
        ug_detalle.Enabled = True

        Tool_Grabar.Enabled = True
        Tool_Cancelar.Enabled = True
        urb_estaCuenta.Value = 0

        uck_Procesar.Enabled = True
        uce_tip_doc.Focus()

    End Sub

    Private Sub Tool_Cancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_Cancelar.Click
        Call Inicializar_Estado_BotonesPre(ToolS_Mantenimiento)
        Inicializa()
        lNew = True
        '  Call MostrarTabs(0, utc_Datos, 0)
    End Sub

    Private Sub Tool_Editar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_Editar.Click
        If txt_idPreFactura.Text = "" Then
            Avisar("Registro no Tiene Pre-Factura")
            Exit Sub
        End If
        'If ucbo_Estado.Value = 2 And Val(txt_PagoVariable.Text) <> 100 Then
        '    Avisar("La Pre-Factura ya esta Facturada, no Puede Editar")
        '    Exit Sub
        'End If

        lNew = False

        Call Inicializar_Estado_BotonesPre(ToolS_Mantenimiento)

        uchk_GenerarCta.Enabled = False
        uchk_Presupuesto.Enabled = False
        txt_IdCuenta.Enabled = False
        txt_IDPresupuesto.Enabled = False
        ubt_Agregar.Enabled = True
        ubt_Quitar.Enabled = True
        'ubt_Consumo.Enabled = True
        uchk_SeguroEps.Enabled = True
        uce_Medico.Enabled = True
        ucm_Tipo.Enabled = True
        txt_Ruc_ClientesC.Enabled = True
        txt_idDiagnostico.Enabled = True

        urb_estaCuenta.Enabled = True
        ub_Detallar.Enabled = True
        ubnt_Tratamiento.Enabled = True

        udtpFechaAlta.Enabled = True
        udtpFechaIngreso.Enabled = True
        txt_Tratamiento.Enabled = True
        If uchk_SeguroEps.Checked = True Then
            ugb_Cuenta.Enabled = True
            ug_detalle.DisplayLayout.Bands(0).Columns("CD_DSCTO_PORC").CellActivation = Activation.NoEdit
        Else
            ugb_Cuenta.Enabled = False
            ug_detalle.DisplayLayout.Bands(0).Columns("CD_DSCTO_PORC").CellActivation = Activation.AllowEdit
        End If
        ug_detalle.Enabled = True

        Tool_Grabar.Enabled = True
        Tool_Cancelar.Enabled = True

        If uck_Procesar.Checked = True Then
            uck_Procesar.Enabled = False
        Else
            uck_Procesar.Enabled = True
        End If


        uce_tip_doc.Focus()

    End Sub

    Private Sub Tool_Eliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_Eliminar.Click
        'If txt_idPreFactura.Text = "" Then
        '    Avisar("Registro no Tiene Pre-Factura")
        '    Exit Sub
        'End If
        If ucbo_Estado.Value = 2 Then
            Avisar("La Pre-Factura ya esta Facturada, no Puede Eliminar")
            Exit Sub
        End If
        If Val(txt_TotalN.Text) + Val(txt_TotalC.Text) + Val(txt_TotalAdi.Text) > 0 Then
            Avisar("La Cuenta tiene consumo de medicamentos, no Puede Eliminar")
            Exit Sub
        End If
        If Preguntar("Seguro de Eliminar?") Then
            obe.PF_ID = Val(txt_idPreFactura.Text)
            obe.PF_IDCUENTA = Val(txt_IdCuenta.Text)
            obe.PF_IDPRESUPUESTO = Val(txt_IDPresupuesto.Text)
            Dim i As Integer = 0
            i = obr.Delete(obe, String.Format("{0}-{1}", Environment.UserName, gStr_Usuario_Sis), Environment.MachineName)

            If i < 0 Then
                MessageBox.Show("La operación solicitada no ha podido ser realizada", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            ElseIf i = 1 Then
                MessageBox.Show("No puede Eliminar una cuenta Cancelada", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                Call Avisar("Listo!")

                Call Tool_Cancelar_Click(sender, e)
            End If
        End If

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

    Private Sub Cargar_PreFacturacion(ByVal id_preFac As Integer, ByVal tipo As Integer)
        obe.PF_ID = id_preFac
        obe.HasRow = False
        obr.SEL01(obe)
        If obe.HasRow Then
            With obe
                urb_estaCuenta.Value = .PF_FacTramite
                Format(Val(txt_idPreFactura.Text), "0000000000#")
                If tipo = 2 Then
                    txt_IdCuenta.Text = .PF_IDCUENTA
                    Format(Val(txt_IdCuenta.Text), "0000000000#")
                    'buscar cuenta
                    obeC.CC_ID = Val(txt_IdCuenta.Text)
                    obrT.SEL04(obeC)
                    If obeC.HasRow Then
                        With obeC
                            ucm_Tipo.Value = .CC_IDTIPO_ORI
                            If .CC_IDTIPO_ATENC = 1 Then
                                uchk_SeguroEps.Checked = False
                                ucm_SeguroEps.SelectedIndex = -1
                            Else
                                uchk_SeguroEps.Checked = True
                                ucm_SeguroEps.Value = .CC_IDSEGURO
                            End If
                            txt_CodAsegurado.Text = .CC_SIT_COD_ASEG
                            txt_FechaAutoriza.Value = .CC_SIT_FEC_AUTORI
                            txt_DesCobertura.Value = .CC_SIT_COD_COBER
                            txt_PagoFijo.Text = .CC_SIT_COPG_FIJO
                            txt_PagoVariable.Text = .CC_SIT_COPG_VARI
                            txt_CodAutoriza.Text = .CC_SIT_COD_GENE
                            txt_MontoImponible.Text = .CC_SIT_MONTO_IMP
                            ucbo_TipoAfiliacion.Value = .CC_TIPOAFILIACION

                            uck_Procesar.Checked = IIf(.CC_ESTADO_PROC = 1, True, False)
                            If .CC_ESTADO_PROC = 1 Then
                                udt_FProcesada.Value = .CC_FECHA_PROC
                            End If

                        End With
                    End If
                Else
                    txt_IDPresupuesto.Text = IIf(.PF_IDPRESUPUESTO = 0, "", .PF_IDPRESUPUESTO)
                    If txt_IDPresupuesto.Text <> "" Then
                        Format(Val(txt_IDPresupuesto.Text), "0000000000#")
                    End If
                End If
                txt_idHistoria.Value = .PF_IDNUMHIST
                Format(Val(txt_idHistoria.Text), "0000000000#")
                txt_idClienteC.Value = .PF_IDCLIENTE
                If .PF_IDTIPO_ATENC = 1 Then
                    uchk_SeguroEps.Checked = False
                    ucm_SeguroEps.SelectedIndex = -1
                Else
                    uchk_SeguroEps.Checked = True
                    ucm_SeguroEps.Value = .PF_IDSEGURO
                End If
                ucbo_Estado.Value = .PF_ESTADO_PRE_F
                udte_fecha.Value = .PF_FECHA
                uce_Medico.Value = .PF_IDMEDICO
                If .PF_FECHAIngreso = Nothing Then udtpFechaIngreso.Value = "" Else udtpFechaIngreso.Value = .PF_FECHAIngreso
                If .PF_FECHAAlta = Nothing Then udtpFechaAlta.Value = "" Else udtpFechaAlta.Value = .PF_FECHAAlta
                txt_Tratamiento.Text = .PF_Tratamiento

                Dim obrD As New BL.FacturacionBL.SG_FA_TB_CIE10
                Dim ds_Diag As New DataSet
                ds_Diag = obrD.getOrigenBus(.PF_IDCIE10)
                If ds_Diag.Tables(0).Rows.Count > 0 Then
                    With ds_Diag.Tables(0)
                        txt_idDiagnostico.Text = .Rows(0)("CI_Descripcion")
                        idDiagnostico = .Rows(0)("CI_Orden")
                    End With
                End If

                Dim historiaBL As New BL.AdmisionBL.SG_AD_TB_HISTO_CLINI
                Dim dt_histo_tmp As DataTable = historiaBL.getHistorias_Base_x_Id(txt_idHistoria.Value, gInt_IdEmpresa)
                If dt_histo_tmp.Rows.Count > 0 Then
                    txt_Des_Cliente.Text = dt_histo_tmp.Rows(0)("HC_APE_PAT") & " " & dt_histo_tmp.Rows(0)("HC_APE_MAT") & " " & dt_histo_tmp.Rows(0)("HC_APE_CASADA") & " " & dt_histo_tmp.Rows(0)("HC_NOMBRE1") & " " & dt_histo_tmp.Rows(0)("HC_NOMBRE2")
                    txt_ruc_cliente.Text = dt_histo_tmp.Rows(0)("HC_NDOC")
                    txt_IdCliente.Value = dt_histo_tmp.Rows(0)("HC_IDCLIENTE")
                    uce_tip_doc.Value = dt_histo_tmp.Rows(0)("HC_TDOC")
                End If

                Dim clienteBL As New BL.FacturacionBL.SG_FA_TB_CLIENTE
                Dim clienteBE As New BE.FacturacionBE.SG_FA_TB_CLIENTE
                clienteBE.CL_ID = txt_idClienteC.Value
                clienteBE.CL_IDEMPRESA = New BE.ContabilidadBE.SG_CO_TB_EMPRESA With {.EM_ID = gInt_IdEmpresa}
                clienteBL.get_Cliente_x_Id(clienteBE)
                txt_Des_ClienteC.Text = clienteBE.CL_NOMBRE
                txt_Ruc_ClientesC.Text = clienteBE.CL_NDOC
                clienteBE = Nothing
                clienteBL = Nothing

                Dim obj As New DataTable
                obeT.TCD_IDCAB = Val(txt_IdCuenta.Text)
                obrT.SEL010_TMP(obeT, String.Format("{0}-{1}", Environment.UserName, gStr_Usuario_Sis), Environment.MachineName, obj)
                ug_detalle.DataSource = obj
                Call Calcular_Totales()
                ug_detalle.UpdateData()

                Call Inicializar_Estado_BotonesPre(ToolS_Mantenimiento)

                Tool_Editar.Enabled = True
                Tool_Eliminar.Enabled = True
                Tool_Imprimir.Enabled = True

            End With
        Else
            Avisar("Presupuesto no Existe!")
        End If
    End Sub

    'Cuenta
    Private Sub Ayuda_Anexo_Cuenta()
        'FA_PR_ListaClientesAyuda.Int_Opcion = 1
        FA_PR_ListaCuentas.ShowDialog()

        Dim matriz As List(Of String) = FA_PR_ListaCuentas.GetLista

        If matriz.Count > 0 Then
            udtpFechaIngreso.Value = ""
            udtpFechaAlta.Value = ""

            txt_IDPresupuesto.Text = ""
            txt_IdCuenta.Text = matriz(0)
            Format(Val(txt_IdCuenta.Text), "0000000000#")
            ucm_Tipo.Value = matriz(1)
            txt_idHistoria.Value = matriz(3)

            txt_idClienteC.Value = matriz(5)
            If matriz(6) = 1 Then
                uchk_SeguroEps.Checked = False
                ucm_SeguroEps.SelectedIndex = -1
            Else
                uchk_SeguroEps.Checked = True
                ucm_SeguroEps.Value = matriz(7)
            End If

            If ucm_Tipo.Value = 1 And uchk_SeguroEps.Checked = True Then
                obr.UpdatePreFactura_Farmacia(Val(matriz(15)), Val(txt_IdCuenta.Text), IGVTasa)
            End If

            udte_fecha.Value = matriz(8)
            txt_idPreFactura.Text = matriz(9)
            txt_CodAsegurado.Text = matriz(11)
            txt_FechaAutoriza.Value = matriz(12)
            txt_DesCobertura.Value = matriz(13)
            txt_PagoFijo.Text = matriz(14)
            txt_PagoVariable.Text = matriz(15)
            txt_CodAutoriza.Text = matriz(16)
            ucbo_TipoAfiliacion.Value = matriz(17)
            uce_Medico.Value = matriz(18)
            txt_Tratamiento.Text = "Ambulatorio"
            txt_MontoImponible.Text = matriz(20)
            Dim historiaBL As New BL.AdmisionBL.SG_AD_TB_HISTO_CLINI
            Dim dt_histo_tmp As DataTable = historiaBL.getHistorias_Base_x_Id(txt_idHistoria.Value, gInt_IdEmpresa)
            If dt_histo_tmp.Rows.Count > 0 Then
                txt_Des_Cliente.Text = dt_histo_tmp.Rows(0)("HC_APE_PAT") & " " & dt_histo_tmp.Rows(0)("HC_APE_MAT") & " " & dt_histo_tmp.Rows(0)("HC_APE_CASADA") & " " & dt_histo_tmp.Rows(0)("HC_NOMBRE1") & " " & dt_histo_tmp.Rows(0)("HC_NOMBRE2")
                txt_ruc_cliente.Text = dt_histo_tmp.Rows(0)("HC_NDOC")
                txt_IdCliente.Value = dt_histo_tmp.Rows(0)("HC_IDCLIENTE")
                uce_tip_doc.Value = dt_histo_tmp.Rows(0)("HC_TDOC")
            End If
            Format(Val(txt_idHistoria.Text), "0000000000#")

            Dim clienteBL As New BL.FacturacionBL.SG_FA_TB_CLIENTE
            Dim clienteBE As New BE.FacturacionBE.SG_FA_TB_CLIENTE
            clienteBE.CL_ID = txt_idClienteC.Value
            clienteBE.CL_IDEMPRESA = New BE.ContabilidadBE.SG_CO_TB_EMPRESA With {.EM_ID = gInt_IdEmpresa}
            clienteBL.get_Cliente_x_Id(clienteBE)
            txt_Des_ClienteC.Text = clienteBE.CL_NOMBRE
            txt_Ruc_ClientesC.Text = clienteBE.CL_NDOC
            clienteBE = Nothing
            clienteBL = Nothing

            ucm_SeguroEps.Enabled = False
            ugb_Cuenta.Enabled = False
            uchk_GenerarCta.Enabled = True
            uchk_Presupuesto.Enabled = True
            ubt_Agregar.Enabled = False
            ubt_Quitar.Enabled = False
            'ubt_Consumo.Enabled = False
            uchk_SeguroEps.Enabled = False

            If txt_idPreFactura.Text = "" Then
                Dim obj As New DataTable
                obeT.TCD_IDCAB = Val(txt_IdCuenta.Text)
                obrT.SEL010_TMP(obeT, String.Format("{0}-{1}", Environment.UserName, gStr_Usuario_Sis), Environment.MachineName, obj)
                ug_detalle.DataSource = obj
                Call Calcular_Totales()
                ug_detalle.UpdateData()

                Call Inicializar_Estado_BotonesPre(ToolS_Mantenimiento)

                Tool_Nuevo.Enabled = True
                Tool_Eliminar.Enabled = True
                Tool_Imprimir.Enabled = True
                urb_estaCuenta.Value = 0
                ucbo_Estado.Value = 1
            Else
                Cargar_PreFacturacion(Val(txt_idPreFactura.Text), 1)
            End If
            Call Cargar_Consumo_Farmacia()
            Call Cargar_Adelantos_Pagos()
            Call Cargar_Consumo_SalaBebes()

            uck_Procesar.Checked = matriz(20)
            uck_Procesar.Checked = IIf(matriz(21) = 1, True, False)
            If matriz(21) = 1 Then
                udt_FProcesada.Value = matriz(22)
                lbl_FProcesada.Visible = True
                udt_FProcesada.Visible = True
            Else
                lbl_FProcesada.Visible = False
                udt_FProcesada.Visible = False
            End If

            Dim obeTPD As New BE.FacturacionBE.SG_FA_TB_PRE_FACTURA_DETALLE
            Dim obrTPD As New BL.FacturacionBL.SG_FA_TB_PRE_FACTURA_DETALLE
            obeTPD.PFD_IDCAB_CUENTA = Val(txt_IdCuenta.Text)
            obrTPD.Delete2(obeTPD, String.Format("{0}-{1}", Environment.UserName, gStr_Usuario_Sis), Environment.MachineName)

        End If

    End Sub

    Private Sub Buscar_Cuenta()
        txt_IDPresupuesto.Text = ""
        udtpFechaIngreso.Value = ""
        udtpFechaAlta.Value = ""
        obeC.CC_ID = Val(txt_IdCuenta.Text)
        Format(Val(txt_IdCuenta.Text), "0000000000#")
        obeC.HasRow = False
        obrT.SEL04(obeC)
        If obeC.HasRow Then
            With obeC
                ucm_Tipo.Value = .CC_IDTIPO_ORI
                txt_idHistoria.Value = .CC_IDNUM_HIST
                txt_idClienteC.Value = .CC_IDCLIENTE
                If .CC_IDTIPO_ATENC = 1 Then
                    uchk_SeguroEps.Checked = False
                    ucm_SeguroEps.SelectedIndex = -1
                Else
                    uchk_SeguroEps.Checked = True
                    ucm_SeguroEps.Value = .CC_IDSEGURO
                End If
                If ucm_Tipo.Value = 1 And uchk_SeguroEps.Checked = True Then
                    obr.UpdatePreFactura_Farmacia(.CC_SIT_COPG_VARI, Val(txt_IdCuenta.Text), IGVTasa)
                End If

                udte_fecha.Value = .CC_FECHA
                txt_idPreFactura.Text = IIf(.CC_IDPREFAC = 0, "", .CC_IDPREFAC)
                txt_CodAsegurado.Text = .CC_SIT_COD_ASEG
                txt_FechaAutoriza.Value = .CC_SIT_FEC_AUTORI
                txt_DesCobertura.Value = .CC_SIT_COD_COBER
                txt_PagoFijo.Text = .CC_SIT_COPG_FIJO
                txt_PagoVariable.Text = .CC_SIT_COPG_VARI
                txt_CodAutoriza.Text = .CC_SIT_COD_GENE
                txt_MontoImponible.Text = .CC_SIT_MONTO_IMP
                ucbo_TipoAfiliacion.Value = .CC_TIPOAFILIACION
                uce_Medico.Value = .CC_MEDICO

                txt_Tratamiento.Text = "Ambulatorio"
                Dim historiaBL As New BL.AdmisionBL.SG_AD_TB_HISTO_CLINI
                Dim dt_histo_tmp As DataTable = historiaBL.getHistorias_Base_x_Id(txt_idHistoria.Value, gInt_IdEmpresa)
                If dt_histo_tmp.Rows.Count > 0 Then
                    txt_Des_Cliente.Text = dt_histo_tmp.Rows(0)("HC_APE_PAT") & " " & dt_histo_tmp.Rows(0)("HC_APE_MAT") & " " & dt_histo_tmp.Rows(0)("HC_APE_CASADA") & " " & dt_histo_tmp.Rows(0)("HC_NOMBRE1") & " " & dt_histo_tmp.Rows(0)("HC_NOMBRE2")
                    txt_ruc_cliente.Text = dt_histo_tmp.Rows(0)("HC_NDOC")
                    txt_IdCliente.Value = dt_histo_tmp.Rows(0)("HC_IDCLIENTE")
                    uce_tip_doc.Value = dt_histo_tmp.Rows(0)("HC_TDOC")
                End If
                Format(Val(txt_idHistoria.Text), "0000000000#")
                Dim clienteBL As New BL.FacturacionBL.SG_FA_TB_CLIENTE
                Dim clienteBE As New BE.FacturacionBE.SG_FA_TB_CLIENTE
                clienteBE.CL_ID = txt_idClienteC.Value
                clienteBE.CL_IDEMPRESA = New BE.ContabilidadBE.SG_CO_TB_EMPRESA With {.EM_ID = gInt_IdEmpresa}
                clienteBL.get_Cliente_x_Id(clienteBE)
                txt_Des_ClienteC.Text = clienteBE.CL_NOMBRE
                txt_Ruc_ClientesC.Text = clienteBE.CL_NDOC
                clienteBE = Nothing
                clienteBL = Nothing

                ucm_SeguroEps.Enabled = False
                ugb_Cuenta.Enabled = False
                uchk_GenerarCta.Enabled = True
                uchk_Presupuesto.Enabled = True
                ubt_Agregar.Enabled = False
                ubt_Quitar.Enabled = False
                'ubt_Consumo.Enabled = False
                uchk_SeguroEps.Enabled = False

                If txt_idPreFactura.Text = "" Then
                    Dim obj As New DataTable
                    obeT.TCD_IDCAB = Val(txt_IdCuenta.Text)
                    obrT.SEL010_TMP(obeT, String.Format("{0}-{1}", Environment.UserName, gStr_Usuario_Sis), Environment.MachineName, obj)
                    ug_detalle.DataSource = obj
                    Call Calcular_Totales()
                    ug_detalle.UpdateData()

                    Call Inicializar_Estado_BotonesPre(ToolS_Mantenimiento)

                    Tool_Nuevo.Enabled = True
                    Tool_Eliminar.Enabled = True
                    Tool_Imprimir.Enabled = True
                    urb_estaCuenta.Value = 0
                    ucbo_Estado.Value = 1
                Else
                    Cargar_PreFacturacion(Val(txt_idPreFactura.Text), 1)
                End If


                Dim obeTPD As New BE.FacturacionBE.SG_FA_TB_PRE_FACTURA_DETALLE
                Dim obrTPD As New BL.FacturacionBL.SG_FA_TB_PRE_FACTURA_DETALLE
                obeTPD.PFD_IDCAB_CUENTA = Val(txt_IdCuenta.Text)
                obrTPD.Delete2(obeTPD, String.Format("{0}-{1}", Environment.UserName, gStr_Usuario_Sis), Environment.MachineName)

                Call Cargar_Consumo_Farmacia()
                Call Cargar_Adelantos_Pagos()
                Call Cargar_Consumo_SalaBebes()


                uck_Procesar.Checked = IIf(.CC_ESTADO_PROC = 1, True, False)
                If .CC_ESTADO_PROC = 1 Then
                    udt_FProcesada.Value = .CC_FECHA_PROC
                    lbl_FProcesada.Visible = True
                    udt_FProcesada.Visible = True
                Else
                    lbl_FProcesada.Visible = False
                    udt_FProcesada.Visible = False

                End If

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
    'Private Sub txt_IdCuenta_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_IdCuenta.ValueChanged
    '    If txt_IdCuenta.Text.Trim.Length = 0 Then
    '        'txt_IdCliente.Text = String.Empty
    '        'txt_Des_Cliente.Text = String.Empty
    '    End If
    'End Sub
    Private Sub txt_IdCuenta_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_IdCuenta.KeyDown
        If e.KeyCode = Keys.Enter Or e.KeyCode = Keys.Tab Then
            Call Buscar_Cuenta()
        End If

        If e.KeyCode = Keys.F2 Then Call Ayuda_Anexo_Cuenta()
    End Sub

    'Presupuesto
    Private Sub Ayuda_Anexo_Presupuesto()
        ' FA_PR_ListaClientesAyuda.Int_Opcion = 1
        FA_PR_ListaPresupuesto.ShowDialog()

        Dim matriz As List(Of String) = FA_PR_ListaPresupuesto.GetLista

        If matriz.Count > 0 Then
            txt_IdCuenta.Text = ""
            txt_IDPresupuesto.Text = matriz(0)
            Format(Val(txt_IDPresupuesto.Text), "0000000000#")
            ucm_Tipo.Value = 2
            txt_idHistoria.Value = matriz(2)
            txt_idClienteC.Value = matriz(3)
            If matriz(1) = "" Then
                uchk_SeguroEps.Checked = False
                ucm_SeguroEps.SelectedIndex = -1
            Else
                uchk_SeguroEps.Checked = True
                ucm_SeguroEps.Value = matriz(1)
            End If

            txt_idPreFactura.Text = IIf(matriz(13) = 0, "", matriz(13))

            Dim TBL As New BL.FacturacionBL.SG_FA_TB_PAQUETE_CAB
            Dim TBE As New BE.FacturacionBE.SG_FA_TB_PAQUETE_CAB
            TBE.PC_ID = matriz(7)
            TBL.SEL02(TBE)
            If TBE.HasRow = True Then
                txt_Tratamiento.Text = TBE.PC_DESCRIPCION
            Else
                txt_Tratamiento.Text = ""
            End If

            txt_CodAsegurado.Text = ""
            txt_FechaAutoriza.Value = ""
            txt_DesCobertura.Value = ""
            txt_PagoFijo.Text = matriz(9)
            txt_PagoVariable.Text = matriz(10)
            txt_CodAutoriza.Text = ""
            ucbo_TipoAfiliacion.Value = ""
            uce_Medico.Value = matriz(6)

            Dim historiaBL As New BL.AdmisionBL.SG_AD_TB_HISTO_CLINI
            Dim dt_histo_tmp As DataTable = historiaBL.getHistorias_Base_x_Id(txt_idHistoria.Value, gInt_IdEmpresa)
            If dt_histo_tmp.Rows.Count > 0 Then
                txt_Des_Cliente.Text = dt_histo_tmp.Rows(0)("HC_APE_PAT") & " " & dt_histo_tmp.Rows(0)("HC_APE_MAT") & " " & dt_histo_tmp.Rows(0)("HC_APE_CASADA") & " " & dt_histo_tmp.Rows(0)("HC_NOMBRE1") & " " & dt_histo_tmp.Rows(0)("HC_NOMBRE2")
                txt_ruc_cliente.Text = dt_histo_tmp.Rows(0)("HC_NDOC")
                txt_IdCliente.Value = dt_histo_tmp.Rows(0)("HC_IDCLIENTE")
                uce_tip_doc.Value = dt_histo_tmp.Rows(0)("HC_TDOC")
            Else
                txt_Des_Cliente.Text = ""
                txt_ruc_cliente.Text = ""
                txt_IdCliente.Value = ""
                uce_tip_doc.Value = ""
            End If
            Format(Val(txt_idHistoria.Text), "0000000000#")
            Dim clienteBL As New BL.FacturacionBL.SG_FA_TB_CLIENTE
            Dim clienteBE As New BE.FacturacionBE.SG_FA_TB_CLIENTE
            clienteBE.CL_ID = txt_idClienteC.Value
            clienteBE.CL_IDEMPRESA = New BE.ContabilidadBE.SG_CO_TB_EMPRESA With {.EM_ID = gInt_IdEmpresa}
            clienteBL.get_Cliente_x_Id(clienteBE)
            txt_Des_ClienteC.Text = clienteBE.CL_NOMBRE
            txt_Ruc_ClientesC.Text = clienteBE.CL_NDOC
            clienteBE = Nothing
            clienteBL = Nothing

            ucm_SeguroEps.Enabled = False
            ugb_Cuenta.Enabled = False
            uchk_GenerarCta.Enabled = True
            uchk_Presupuesto.Enabled = True
            ubt_Agregar.Enabled = False
            ubt_Quitar.Enabled = False
            'ubt_Consumo.Enabled = False
            uchk_SeguroEps.Enabled = False

            If txt_idPreFactura.Text = "" Then
                Dim PRESBLT As New BL.FacturacionBL.SG_FA_TB_PRESUPUESTO_DET
                Dim PRESBET As New BE.FacturacionBE.SG_FA_TB_PRESUPUESTO_DET

                Dim obj As New DataTable
                PRESBET.DP_ID = Val(txt_IDPresupuesto.Text)
                PRESBLT.SEL01(PRESBET, obj)
                ug_detalle.DataSource = obj

                obeT.TCD_IDCAB = Val(txt_IDPresupuesto.Text)
                obrT.SEL03_TMP(obeT, String.Format("{0}-{1}", Environment.UserName, gStr_Usuario_Sis), Environment.MachineName, obj)

                Call Calcular_Totales()
                ug_detalle.UpdateData()
                Call Inicializar_Estado_BotonesPre(ToolS_Mantenimiento)

                Tool_Nuevo.Enabled = True
                Tool_Eliminar.Enabled = True
                Tool_Imprimir.Enabled = True
                urb_estaCuenta.Value = 0
            Else
                Cargar_PreFacturacion(Val(txt_idPreFactura.Text), 2)
            End If

            Dim obeTPD As New BE.FacturacionBE.SG_FA_TB_PRE_FACTURA_DETALLE
            Dim obrTPD As New BL.FacturacionBL.SG_FA_TB_PRE_FACTURA_DETALLE
            obeTPD.PFD_IDCAB_CUENTA = Val(txt_IdCuenta.Text)
            obrTPD.Delete2(obeTPD, String.Format("{0}-{1}", Environment.UserName, gStr_Usuario_Sis), Environment.MachineName)

        End If

    End Sub

    Private Sub Buscar_Presupuesto()
        Dim PRESBL As New BL.FacturacionBL.SG_FA_TB_PRESUPUESTO_CAB
        Dim PRESBE As New BE.FacturacionBE.SG_FA_TB_PRESUPUESTO_CAB
        txt_IdCuenta.Text = ""
        PRESBE.PR_ID = Val(txt_IDPresupuesto.Text)
        txt_IDPresupuesto.Text = Format(Val(txt_IDPresupuesto.Text), "0000000000#")
        PRESBE.HasRow = False
        PRESBL.SEL02(PRESBE)
        If PRESBE.HasRow Then
            With PRESBE
                ucm_Tipo.Value = 2
                txt_idHistoria.Value = .PR_IDNUMHIST
                txt_idClienteC.Value = .PR_IDCLIENTE
                If .PR_IDSEGURO = "" Then
                    uchk_SeguroEps.Checked = False
                    ucm_SeguroEps.SelectedIndex = -1
                Else
                    uchk_SeguroEps.Checked = True
                    ucm_SeguroEps.Value = .PR_IDSEGURO
                End If

                txt_idPreFactura.Text = IIf(.PR_IDpreFac = 0, "", .PR_IDpreFac)
                txt_CodAsegurado.Text = ""
                txt_FechaAutoriza.Value = ""
                txt_DesCobertura.Value = ""
                txt_PagoFijo.Text = .PR_COPG_FIJO
                txt_PagoVariable.Text = .PR_COPG_VARI
                txt_CodAutoriza.Text = ""
                ucbo_TipoAfiliacion.Value = ""
                uce_Medico.Value = .PR_IDMEDICO

                Dim TBL As New BL.FacturacionBL.SG_FA_TB_PAQUETE_CAB
                Dim TBE As New BE.FacturacionBE.SG_FA_TB_PAQUETE_CAB
                TBE.PC_ID = .PR_IDPAQUETE
                TBL.SEL02(TBE)
                If TBE.HasRow = True Then
                    txt_Tratamiento.Text = TBE.PC_DESCRIPCION
                Else
                    txt_Tratamiento.Text = ""
                End If

                Dim historiaBL As New BL.AdmisionBL.SG_AD_TB_HISTO_CLINI
                Dim dt_histo_tmp As DataTable = historiaBL.getHistorias_Base_x_Id(txt_idHistoria.Value, gInt_IdEmpresa)
                If dt_histo_tmp.Rows.Count > 0 Then
                    txt_Des_Cliente.Text = dt_histo_tmp.Rows(0)("HC_APE_PAT") & " " & dt_histo_tmp.Rows(0)("HC_APE_MAT") & " " & dt_histo_tmp.Rows(0)("HC_APE_CASADA") & " " & dt_histo_tmp.Rows(0)("HC_NOMBRE1") & " " & dt_histo_tmp.Rows(0)("HC_NOMBRE2")
                    txt_ruc_cliente.Text = dt_histo_tmp.Rows(0)("HC_NDOC")
                    txt_IdCliente.Value = dt_histo_tmp.Rows(0)("HC_IDCLIENTE")
                    uce_tip_doc.Value = dt_histo_tmp.Rows(0)("HC_TDOC")
                Else
                    txt_Des_Cliente.Text = ""
                    txt_ruc_cliente.Text = ""
                    txt_IdCliente.Value = ""
                    uce_tip_doc.Value = ""
                End If

                Dim clienteBL As New BL.FacturacionBL.SG_FA_TB_CLIENTE
                Dim clienteBE As New BE.FacturacionBE.SG_FA_TB_CLIENTE
                clienteBE.CL_ID = txt_idClienteC.Value
                clienteBE.CL_IDEMPRESA = New BE.ContabilidadBE.SG_CO_TB_EMPRESA With {.EM_ID = gInt_IdEmpresa}
                clienteBL.get_Cliente_x_Id(clienteBE)
                txt_Des_ClienteC.Text = clienteBE.CL_NOMBRE
                txt_Ruc_ClientesC.Text = clienteBE.CL_NDOC
                clienteBE = Nothing
                clienteBL = Nothing

                ucm_SeguroEps.Enabled = False
                ugb_Cuenta.Enabled = False
                uchk_GenerarCta.Enabled = True
                uchk_Presupuesto.Enabled = True
                ubt_Agregar.Enabled = False
                ubt_Quitar.Enabled = False
                'ubt_Consumo.Enabled = False
                uchk_SeguroEps.Enabled = False

                If txt_idPreFactura.Text = "" Then
                    Dim PRESBLT As New BL.FacturacionBL.SG_FA_TB_PRESUPUESTO_DET
                    Dim PRESBET As New BE.FacturacionBE.SG_FA_TB_PRESUPUESTO_DET

                    Dim obj As New DataTable
                    PRESBET.DP_ID = Val(txt_IDPresupuesto.Text)
                    PRESBLT.SEL01(PRESBET, obj)
                    ug_detalle.DataSource = obj

                    obeT.TCD_IDCAB = Val(txt_IDPresupuesto.Text)
                    obrT.SEL03_TMP(obeT, String.Format("{0}-{1}", Environment.UserName, gStr_Usuario_Sis), Environment.MachineName, obj)

                    Call Calcular_Totales()
                    ug_detalle.UpdateData()

                    Call Inicializar_Estado_BotonesPre(ToolS_Mantenimiento)

                    Tool_Nuevo.Enabled = True
                    Tool_Eliminar.Enabled = True
                    Tool_Imprimir.Enabled = True
                    urb_estaCuenta.Value = 0
                Else
                    Cargar_PreFacturacion(Val(txt_idPreFactura.Text), 2)
                End If

                Dim obeTPD As New BE.FacturacionBE.SG_FA_TB_PRE_FACTURA_DETALLE
                Dim obrTPD As New BL.FacturacionBL.SG_FA_TB_PRE_FACTURA_DETALLE
                obeTPD.PFD_IDCAB_CUENTA = Val(txt_IdCuenta.Text)
                obrTPD.Delete2(obeTPD, String.Format("{0}-{1}", Environment.UserName, gStr_Usuario_Sis), Environment.MachineName)

            End With
        Else
            Avisar("Presupuesto no Existe!")
            Inicializa()
        End If

    End Sub

    Private Sub txt_IDPresupuesto_EditorButtonClick(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinEditors.EditorButtonEventArgs) Handles txt_IDPresupuesto.EditorButtonClick
        Select Case e.Button.Key
            Case "ayuda"
                Call Ayuda_Anexo_Presupuesto()
            Case "editar"
        End Select
    End Sub

    Private Sub txt_IDPresupuesto_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_IDPresupuesto.KeyDown
        If e.KeyCode = Keys.Enter Or e.KeyCode = Keys.Tab Then
            Call Buscar_Presupuesto()
        End If

        If e.KeyCode = Keys.F2 Then Call Ayuda_Anexo_Presupuesto()
    End Sub

    Private Sub Tool_Imprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_Imprimir.Click
        Dim dt_comprobante As New DataTable

        'Dim obj As New DataTable
        obeT.TCD_IDCAB = Val(txt_IdCuenta.Text)
        obrT.SEL06_TMP(obeT, String.Format("{0}-{1}", Environment.UserName, gStr_Usuario_Sis), Environment.MachineName, dt_comprobante)
        'ug_detalle.DataSource = dt_comprobante

        Try
            Me.Cursor = Cursors.WaitCursor

            If dt_comprobante.Rows.Count > 0 Then
                Dim crystalBL As New LR.ClsReporte
                Dim Monto_en_Letras As String = Letras(txt_Total.Value).ToUpper

                Dim obrmo As New BL.FacturacionBL.SG_FA_TB_MONEDA
                Dim drr_MOV As System.Data.SqlClient.SqlDataReader
                drr_MOV = obrmo.get_Moneda("01", gInt_IdEmpresa)
                If drr_MOV.HasRows Then
                    drr_MOV.Read()
                    Monto_en_Letras = Monto_en_Letras & " " & drr_MOV("MO_DESCRIPCION")
                End If
                drr_MOV.Close()

                crystalBL.Muestra_Reporte(gStr_RutaRep & "\SG_FA_11.RPT", dt_comprobante, "", "pSubT;" & txt_SubTotal.Text, "pIGV;" & txt_IGV.Text, "pTotal;" & txt_Total.Text, "pPresupuesto;" & Format(Val(txt_IDPresupuesto.Text), "0000000000#"), "pCuenta;" & Format(Val(txt_IdCuenta.Text), "0000000000#"), "pPaciente;" & txt_Des_Cliente.Text, "pSon;" & Monto_en_Letras, "pusu;" & IIf(gStr_Usuario_Sis.ToUpper = "MHERRERA", "MELISSA HERRERA", "ANA VALVERDE"))
                crystalBL = Nothing
            End If

            Me.Cursor = Cursors.Default

        Catch ex As Exception
            Throw ex
            Me.Cursor = Cursors.Default
        End Try

    End Sub

    'Private Sub ubt_Consumo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ubt_Consumo.Click
    '    FA_PR_ListaFarmacia.Cuenta = Val(txt_IdCuenta.Text)
    '    FA_PR_ListaFarmacia.Tipo = ucm_Tipo.Value
    '    FA_PR_ListaFarmacia.ShowDialog()
    'End Sub

    Private Sub ug_consumos_InitializeRow(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinGrid.InitializeRowEventArgs) Handles ug_consumos.InitializeRow
        If e.Row.Cells(7).Value = 0 Then
            e.Row.Appearance.BackColor = Color.FromArgb(255, 128, 128)
        ElseIf e.Row.Cells(7).Value = 1 Then
            e.Row.Appearance.BackColor = Color.DeepSkyBlue
        Else
            e.Row.Appearance.BackColor = Color.LightGreen
        End If
    End Sub

    Private Sub ubtn_imprimir_consu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ubtn_imprimir_consu.Click
        Dim ReporteBL As New BL.FacturacionBL.SG_FA_Reportes
        Dim dt_tmp As DataTable = ReporteBL.get_ConsumoFarmacia(Val(txt_IdCuenta.Text), ucm_Tipo.Value)
        ReporteBL = Nothing

        Try
            Me.Cursor = Cursors.WaitCursor
            Dim crystalBL As New LR.ClsReporte
            crystalBL.Muestra_Reporte(gStr_RutaRep & "\SG_FA_13.RPT", dt_tmp, "", "pPaciente;" & uce_tip_doc.Text.Substring(0, 4) & ": " & txt_ruc_cliente.Text & " - " & txt_Des_Cliente.Text, "pCuenta;" & txt_IdCuenta.Text, "pArea;" & ucm_Tipo.Text)
            crystalBL = Nothing
            Me.Cursor = Cursors.Default
        Catch ex As Exception
            ShowError("Ocurrio un problema con el reporte.")
            Me.Cursor = Cursors.Default
        End Try

    End Sub

    Private Sub ubtn_ActualizarPre_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ubtn_ActualizarPre.Click
        If Preguntar("Los precios se actualizara de acuerdo al seguro que a seleccionado ¿Esta de acuerdo en actualizar los precios de farmacia del consumo que realizo el paciente?") = True Then

            obe.PF_IDCUENTA = Val(txt_IdCuenta.Text)
            obe.PF_IDSEGURO = IIf(uchk_SeguroEps.Checked = True, ucm_SeguroEps.Value, "000")
            obe.PF_IGV = IGVTasa

            Dim X As Integer
            X = obr.Update_Farmacia_Det(obe)
            If X < 0 Then
                MessageBox.Show("La operación solicitada no ha podido ser realizada", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If
            Avisar("Precios Actualizados Correctamente")
            Call Cargar_Consumo_Farmacia()
            Call AgregarFarmacia()
        End If
    End Sub

    Private Sub ubnt_Tratamiento_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ubnt_Tratamiento.Click
        FA_PR_ListaTratamientos.ShowDialog()

        Dim matriz As List(Of String) = FA_PR_ListaTratamientos.GetLista

        If matriz.Count > 0 Then
            utxt_IdTratamiento.Text = matriz(0)
            txt_Tratamiento.Text = matriz(1)

            If ug_detalle.Rows.Count <= 0 Then

                Dim obrT As New BL.FacturacionBL.SG_FA_TB_PAQUETE_DET
                Dim obeT As New BE.FacturacionBE.SG_FA_TB_PAQUETE_DET
                Dim obj As New DataTable
                obeT.PD_IDCAB = Val(utxt_IdTratamiento.Text)
                obeT.PD_IDEMPRESA = gInt_IdEmpresa

                obrT.SEL03_Pre(obeT, IIf(uchk_SeguroEps.Checked = True, ucm_SeguroEps.Value, ""), IIf(uchk_SeguroEps.Checked = True, 1, 0), IGVTasa, String.Format("{0}-{1}", Environment.UserName, gStr_Usuario_Sis), Environment.MachineName, obj)
                ug_detalle.DataSource = obj

                Calcular_Copago(1)
                Calcular_Totales()
                ug_detalle.UpdateData()
            End If

        End If
    End Sub

    Private Sub UltraButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ubtn_ConsultarConsumo.Click
        Call Cargar_Consumo_Farmacia()
        Call AgregarFarmacia()
    End Sub

    Private Sub ub_Detallar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ub_Detallar.Click
        FA_PR_Pre_Factura_Detalle.txt_DesArticulo.Text = ug_detalle.ActiveRow.Cells("Descripcion").Value
        FA_PR_Pre_Factura_Detalle.txt_iditem.Text = ug_detalle.ActiveRow.Cells("CD_ITEM").Value
        FA_PR_Pre_Factura_Detalle.IGVTasa = IGVTasa
        FA_PR_Pre_Factura_Detalle.Tipo = IIf(uchk_SeguroEps.Checked = True, 1, 0)
        If uchk_SeguroEps.Checked = False Then
            FA_PR_Pre_Factura_Detalle.IDSeguro = "000"
        Else
            FA_PR_Pre_Factura_Detalle.IDSeguro = ucm_SeguroEps.Value.ToString
        End If

        FA_PR_Pre_Factura_Detalle.Medico = uce_Medico.Value
        FA_PR_Pre_Factura_Detalle.utxt_IDCuenta.Text = Val(txt_IdCuenta.Text)
        FA_PR_Pre_Factura_Detalle.ShowDialog()
    End Sub

    Private Sub Tool_ImprimirDet_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_ImprimirDet.Click
        Dim dt_comprobante As New DataTable

        'Dim obj As New DataTable
        dt_comprobante = obrT.SEL07_TMP(Val(txt_IdCuenta.Text))
        'ug_detalle.DataSource = dt_comprobante

        Try
            Me.Cursor = Cursors.WaitCursor

            Dim subtotal1 As Double = 0
            Dim variable As Double = 0
            Dim saldo As Double = 0
            Dim deducible As Double = 0
            Dim subTotal As Double = 0
            Dim IGV As Double = 0

            For i As Integer = 0 To ug_detalle.Rows.Count - 1
                If ug_detalle.Rows(i).Cells(5).Value = True Or ug_detalle.Rows(i).Cells(6).Value = True Then
                    If ug_detalle.Rows(i).Cells(5).Value = True Then
                        If ug_detalle.Rows(i).Cells(6).Value = True Then
                            variable = variable + (ug_detalle.Rows(i).Cells(9).Value - Val(txt_PagoFijo.Text))
                        Else
                            variable = variable + ug_detalle.Rows(i).Cells(9).Value
                        End If
                    End If
                    If ug_detalle.Rows(i).Cells(6).Value = True Then deducible = deducible + Val(txt_PagoFijo.Text)
                    subtotal1 += Math.Round(ug_detalle.Rows(i).Cells(4).Value * ug_detalle.Rows(i).Cells(0).Value, 2)
                    'ug_detalle.Rows(i).Cells(7).Value
                End If
            Next

            subtotal1 = Math.Round(subtotal1, 2)
            deducible = Math.Round(deducible, 2)
            saldo = Math.Round(subtotal1 - deducible, 2)
            variable = Math.Round(variable, 2)

            ''igv += ug_Detalle.Rows(i).Cells(9).Value
            ''total += ug_Detalle.Rows(i).Cells(10).Value
            subTotal = Math.Round(saldo - variable, 2) ' ug_Detalle.DisplayLayout.Bands(0).Summaries("sSubtotal").
            IGV = Math.Round((subTotal * IGVTasa) / 100, 2) 'ug_Detalle.DisplayLayout.Bands(0).Summaries("sIgv")
            'ume_total.Value = Math.Round(ume_subtotal.Value + ume_igv.Value, 2) 'ug_Detalle.DisplayLayout.Bands(0).Summaries("sTotal")

            If dt_comprobante.Rows.Count > 0 Then
                Dim crystalBL As New LR.ClsReporte
                Dim Monto_en_Letras As String = Letras(Math.Round(subTotal + IGV, 2)).ToUpper

                Dim obrmo As New BL.FacturacionBL.SG_FA_TB_MONEDA
                Dim drr_MOV As System.Data.SqlClient.SqlDataReader
                drr_MOV = obrmo.get_Moneda("01", gInt_IdEmpresa)
                If drr_MOV.HasRows Then
                    drr_MOV.Read()
                    Monto_en_Letras = Monto_en_Letras & " " & drr_MOV("MO_DESCRIPCION")
                End If
                drr_MOV.Close()

                crystalBL.Muestra_Reporte(gStr_RutaRep & "\SG_FA_16.RPT", dt_comprobante, "", "pSubT;" & subTotal, "pIGV;" & IGV, "pTotal;" & Math.Round(subTotal + IGV, 2), "pCuenta;" & Format(Val(txt_IdCuenta.Text), "0000000000#"), "pPaciente;" & txt_Des_Cliente.Text, "pSon;" & Monto_en_Letras, "pusu;" & IIf(gStr_Usuario_Sis.ToUpper = "MHERRERA", "MELISSA HERRERA", "ANA VALVERDE"), "pCliente;" & ucm_SeguroEps.Text, "psubtotal1;" & subtotal1, "pdeducible;" & deducible, "psaldo;" & saldo, "pvariable;" & variable, "pPor;" & 100 - Val(txt_PagoVariable.Text))
                crystalBL = Nothing
            End If

            Me.Cursor = Cursors.Default

        Catch ex As Exception
            Throw ex
            Me.Cursor = Cursors.Default
        End Try

    End Sub

    Private Sub NuevoItemFarmacia(ByVal DesFarmacia As String, ByVal IDFarmacia As Integer, ByVal Codigo As String, ByVal Total As Decimal, ByVal PagoVariable As Double)
        Dim valItem As Integer = 0
        For i As Integer = 0 To ug_detalle.Rows.Count - 1
            If ug_detalle.Rows(i).Cells(14).Value > valItem Then
                valItem = ug_detalle.Rows(i).Cells(14).Value
            End If
        Next

        ug_detalle.DisplayLayout.Bands(0).AddNew()
        ug_detalle.Rows(ug_detalle.Rows.Count - 1).Cells(0).Value = 1 ' cant
        ug_detalle.Rows(ug_detalle.Rows.Count - 1).Cells(1).Value = IDFarmacia  ' codigo id
        ug_detalle.Rows(ug_detalle.Rows.Count - 1).Cells(2).Value = Codigo 'codigo
        ug_detalle.Rows(ug_detalle.Rows.Count - 1).Cells(3).Value = DesFarmacia 'descripcion
        ug_detalle.Rows(ug_detalle.Rows.Count - 1).Cells(4).Value = Total 'costo
        ug_detalle.Rows(ug_detalle.Rows.Count - 1).Cells(5).Value = True  'CUBRE
        ug_detalle.Rows(ug_detalle.Rows.Count - 1).Cells(6).Value = False  'DEDUCLIBLE
        ug_detalle.Rows(ug_detalle.Rows.Count - 1).Cells(7).Value = 0 'descuen
        ug_detalle.Rows(ug_detalle.Rows.Count - 1).Cells(8).Value = 0.0 'descuen
        ug_detalle.Rows(ug_detalle.Rows.Count - 1).Cells(9).Value = 0 'sub tot
        ug_detalle.Rows(ug_detalle.Rows.Count - 1).Cells(10).Value = 0 'igv
        ug_detalle.Rows(ug_detalle.Rows.Count - 1).Cells(11).Value = 0 ' total
        ug_detalle.Rows(ug_detalle.Rows.Count - 1).Cells(12).Value = 0 ' consul
        ug_detalle.Rows(ug_detalle.Rows.Count - 1).Cells(13).Value = 0 ' comprobante
        ug_detalle.Rows(ug_detalle.Rows.Count - 1).Cells(14).Value = valItem + 1 ' items
        ug_detalle.Rows(ug_detalle.Rows.Count - 1).Cells(15).Value = 0 ' SIN PAGO
        ug_detalle.Rows(ug_detalle.Rows.Count - 1).Cells(16).Value = 0
        ug_detalle.Rows(ug_detalle.Rows.Count - 1).Cells(17).Value = PagoVariable
        'descuento 0
        '  
        '  ValModifi = 0
        With obeT
            .TCD_CANT = 1
            .TCD_DESCUENTO = 0
            .TCD_IDARTICULO = IDFarmacia
            .TCD_IDCAB = 0
            .TCD_IGV = 0
            .TCD_ITEM = valItem + 1
            .TCD_PRECIO = Total
            .TCD_SUB_TOTAL = 0
            .TCD_TOTAL = 0
            .TCD_SINPAGO = 0
            .TCD_DSCTO_OTRO = 0.0
            .TCD_SEG_CUBRE = 1
            .TCD_DEDUCIBLE = 0

        End With
        obrT.Insert_TMP(obeT, String.Format("{0}-{1}", Environment.UserName, gStr_Usuario_Sis), Environment.MachineName)
        ValModifi = 1
        ug_detalle.UpdateData()
        ug_detalle.Refresh()
        ValModifi = 0
    End Sub
    Private Sub AgregarFarmacia()
        If ucm_Tipo.Value = 1 And uchk_SeguroEps.Checked = True And txt_TotalC.Value > 0 Then
            Dim ItemFar As Integer = 0
            Dim ItemsAdi As Integer = 0
            Dim PorcDesc As Double = 0

            Dim TotalAdicional As Double = 0
            For i As Integer = 0 To ug_consumos.Rows.Count - 1
                If val(ug_consumos.Rows(i).Cells(8).Value.ToString) <> val(txt_PagoVariable.Text) Then
                    TotalAdicional = TotalAdicional + Val(ug_consumos.Rows(i).Cells(6).Value.ToString)
                    PorcDesc = Val(ug_consumos.Rows(i).Cells(8).Value.ToString)
                End If
            Next

            For i As Integer = 0 To ug_detalle.Rows.Count - 1
                If TotalAdicional > 0 Then
                    If ug_detalle.Rows(i).Cells(1).Value = 389 Then
                        ItemFar = i
                    End If
                    If ug_detalle.Rows(i).Cells(1).Value = 4793 Then
                        ItemsAdi = i
                    End If
                Else
                    If ug_detalle.Rows(i).Cells(1).Value = 389 Then
                        ItemFar = i
                        Exit Sub
                    End If
                End If
            Next
            If ItemFar > 0 Then
                ug_detalle.Rows(ItemFar).Cells(4).Value = Math.Round(txt_TotalC.Value - TotalAdicional, 2)
                ValModifi = 1
                ug_detalle.UpdateData()
                ug_detalle.Refresh()
                ValModifi = 0
            Else
                NuevoItemFarmacia("FARMACIA", 389, "002001", Math.Round(txt_TotalC.Value - TotalAdicional, 2), Val(txt_PagoVariable.Text))
            End If
            If ItemsAdi > 0 Then
                ug_detalle.Rows(ItemsAdi).Cells(4).Value = Math.Round(TotalAdicional, 2)
                ug_detalle.Rows(ItemsAdi).Cells(17).Value = Math.Round(PorcDesc, 2)
                'DESCUENTO = PorcDesc
                ValModifi = 1
                ug_detalle.UpdateData()
                ug_detalle.Refresh()
                ValModifi = 0
            Else
                NuevoItemFarmacia("ADICIONALES: FARMACIA", 4793, "002003", Math.Round(TotalAdicional, 2), PorcDesc)
            End If
            'txt_TotalC.Value

        End If
    End Sub

    Private Sub uck_Procesar_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles uck_Procesar.CheckedChanged
        If uck_Procesar.Checked = True Then
            Dim suma As Decimal = 0
            If ucm_Tipo.Value = 1 Then
                For i As Integer = 0 To ug_detalle.Rows.Count - 1
                    suma = suma + ug_detalle.Rows(i).Cells(7).Value
                Next
                If suma <= 3.5 Then
                    lbl_FProcesada.Visible = True
                    udt_FProcesada.Visible = True
                Else
                    Avisar("El Monto no es correcto para procesar")
                    uck_Procesar.Checked = False
                End If
            Else
                Avisar("Tipo de Atencion tiene que ser Ambulatorio")
                uck_Procesar.Checked = False
            End If
        Else
            lbl_FProcesada.Visible = False
            udt_FProcesada.Visible = False
        End If
    End Sub

    Private Sub ubt_ActSalaBebe_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ubt_ActSalaBebe.Click
        Cargar_Consumo_SalaBebes()
    End Sub

    Private Sub txt_IdCuenta_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_IdCuenta.ValueChanged

    End Sub
End Class