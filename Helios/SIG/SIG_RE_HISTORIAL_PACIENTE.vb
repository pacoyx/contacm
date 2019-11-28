Imports Infragistics.Win.UltraWinGrid
Public Class SIG_RE_HISTORIAL_PACIENTE

    Private obe As BE.FacturacionBE.SG_FA_TB_PRE_FACTURA_CAB
    Private obr As BL.FacturacionBL.SG_FA_TB_PRE_FACTURA_CAB

    Private obeT As BE.AdmisionBE.TMP_SG_AD_TB_CUENTA_DET
    Private obrC As BL.AdmisionBL.SG_AD_TB_CUENTA_CAB
    Private obeC As BE.AdmisionBE.SG_AD_TB_CUENTA_CAB

    'Public lNew As Boolean = False
    'Public OPCION As Integer
    Dim IGVTasa As Double
    'Public IDMEDICO As String
    'Dim idDiagnostico As Integer = 0

    Public Sub New()
        InitializeComponent()
        obe = New BE.FacturacionBE.SG_FA_TB_PRE_FACTURA_CAB
        obr = New BL.FacturacionBL.SG_FA_TB_PRE_FACTURA_CAB
        obeT = New BE.AdmisionBE.TMP_SG_AD_TB_CUENTA_DET
        obrC = New BL.AdmisionBL.SG_AD_TB_CUENTA_CAB
        obeC = New BE.AdmisionBE.SG_AD_TB_CUENTA_CAB
    End Sub

    Private Sub pKeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Me.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Return) Then
            SendKeys.Send("{TAB}")
            e.Handled = True
        End If
    End Sub

    Private Sub pKeyPressNumero(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_idHistoria.KeyPress
        e.KeyChar = fKeyPress(e.KeyChar, sender.Text, 1)
        e.Handled = (e.KeyChar = "")
    End Sub

    Private Sub Inicializa()

        Call Limpiar_Controls_InGroupox(ugb_Datos)
        Call Limpiar_Controls_InGroupox(ugb_Cuenta)

        uce_Medico.BackColor = Color.White

        txt_SubTotal.Value = 0
        txt_IGV.Value = 0
        txt_Total.Value = 0
        udte_fecha.Value = Now

        Call LimpiaGrid(ug_detalle, uds_detalle)
        Call LimpiaGrid(ug_Atenciones, uds_Atenciones)
        Call LimpiaGrid(ug_Comprobantes, uds_Comprobantes)
        '   Call LimpiaGrid(ug_ComprobantesDET, uds_ComprobanteDET)
        Call LimpiaGrid(ug_consumos, uds_consumos)
        txt_TotalC.Text = "0.00"
        txt_TotalN.Text = "0.00"

        'txt_TotalC.Text = "0.00"
        'txt_TotalN.Text = "0.00"
        utc_vistas.Tabs(0).Selected = True

    End Sub

    Private Sub Cargar_Combos()

        'Dim documentoscBL As New BL.AdmisionBL.SG_AD_TB_TIP_DOC_PER
        'uce_tip_doc.DataSource = documentoscBL.getTiposDocs(gInt_IdEmpresa)
        'uce_tip_doc.DisplayMember = "TD_ABREVIATURA"
        'uce_tip_doc.ValueMember = "TD_ID"
        'documentoscBL = Nothing

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

        Dim bscOBERTURA As New BindingSource
        Dim cOBERTURABL As New BL.AdmisionBL.SG_AD_TB_COBERTURA
        bscOBERTURA.DataSource = cOBERTURABL.getOrigen()
        bscOBERTURA.Filter = String.Format("CB_IDTIPO_ORIGEN = '{0}'", ucm_Tipo.Value)
        txt_DesCobertura.DataSource = bscOBERTURA
        txt_DesCobertura.DisplayMember = "CB_DESCRIPCION"
        txt_DesCobertura.ValueMember = "CB_ID"
        cOBERTURABL = Nothing

    End Sub

    Private Sub SIG_RE_HISTORIAL_PACIENTE_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call Cargar_Combos()
        Call Inicializa()
        Call MostrarTabs(0, utc_Datos, 0)

        ' txt_ruc_cliente.ButtonsRight(0).Appearance.Image = My.Resources._104
        txt_idHistoria.ButtonsRight(0).Appearance.Image = My.Resources._104
        utc_vistas.Tabs(0).Appearance.Image = My.Resources._590
        utc_vistas.Tabs(1).Appearance.Image = My.Resources._1030
        utc_vistas.Tabs(2).Appearance.Image = My.Resources._092

        obe = New BE.FacturacionBE.SG_FA_TB_PRE_FACTURA_CAB
        obr = New BL.FacturacionBL.SG_FA_TB_PRE_FACTURA_CAB
        obeT = New BE.AdmisionBE.TMP_SG_AD_TB_CUENTA_DET
        obrC = New BL.AdmisionBL.SG_AD_TB_CUENTA_CAB
        obeC = New BE.AdmisionBE.SG_AD_TB_CUENTA_CAB

        Call Cargar_Tasas_Impuestos()

        Me.KeyPreview = True
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
    Private Sub Cargar_Atenciones()
        Call LimpiaGrid(ug_Atenciones, uds_Atenciones)
        Call LimpiaGrid(ug_detalle, uds_detalle)
        ug_Atenciones.DataSource = obrC.SEL12(Val(txt_idHistoria.Text))

        If ug_Atenciones.Rows.Count > 0 Then
            Buscar_Cuenta(1)
            Cargar_Consumo_Farmacia(1)
            Cargar_Comprobantes(1)
        End If
    End Sub
    Private Sub Cargar_Consumo_Farmacia(ByVal i As Integer)
        Call LimpiaGrid(ug_consumos, uds_consumos)
        txt_TotalC.Text = "0.00"
        txt_TotalN.Text = "0.00"

        Dim ReporteBL As New BL.FacturacionBL.SG_FA_Reportes
        If i = 0 Then
            ug_consumos.DataSource = ReporteBL.get_ConsumoFarmacia(Val(ug_Atenciones.ActiveRow.Cells(0).Value), ucm_Tipo.Value)
        Else
            ug_consumos.DataSource = ReporteBL.get_ConsumoFarmacia(Val(ug_Atenciones.Rows(0).Cells(0).Value), ucm_Tipo.Value)
        End If

        ReporteBL = Nothing
        Call Calcular_Totales_Consumos_Farmacia()
    End Sub
    Private Sub Calcular_Totales_Consumos_Farmacia()

        txt_TotalC.Text = ""
        txt_TotalN.Text = ""

        Dim subtotalC As Decimal = "0.00"
        Dim subtotalN As Decimal = "0.00"

        For i As Integer = 0 To ug_consumos.Rows.Count - 1
            If ug_consumos.Rows(i).Cells(7).Value = 1 Then
                subtotalC = subtotalC + Val(ug_consumos.Rows(i).Cells(6).Value.ToString)
            Else
                subtotalN = subtotalN + Val(ug_consumos.Rows(i).Cells(6).Value.ToString)
            End If
        Next

        txt_TotalC.Value = Math.Round(subtotalC, 2)
        txt_TotalN.Value = Math.Round(subtotalN, 2)
    End Sub

    Private Sub Cargar_Comprobantes(ByVal i As Integer)
        Call LimpiaGrid(ug_Comprobantes, uds_Comprobantes)
        '  Call LimpiaGrid(ug_ComprobantesDET, uds_ComprobanteDET)

        Dim ReporteBL As New BL.FacturacionBL.SG_FA_TB_COMPROBANTE_C
        If i = 0 Then
            ug_Comprobantes.DataSource = ReporteBL.get_Comprobante(Val(ug_Atenciones.ActiveRow.Cells(0).Value), 1)
        Else
            ug_Comprobantes.DataSource = ReporteBL.get_Comprobante(Val(ug_Atenciones.Rows(0).Cells(0).Value), 1)
        End If


        'If ug_Comprobantes.Rows.Count > 0 Then
        '    ug_ComprobantesDET.DataSource = ReporteBL.get_ComprobantedET(ug_Comprobantes.Rows(0).Cells("CO_ID").Value, 1)
        'End If

        ReporteBL = Nothing
    End Sub

    Private Sub txt_idHistoria_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_idHistoria.KeyDown
        If e.KeyCode = Keys.Enter Then
            Call Buscar_historia()
        End If
        If e.KeyCode = Keys.F2 Then Call Mostrar_Ayuda_Historias()
    End Sub
    Private Sub txt_idHistoria_EditorButtonClick(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinEditors.EditorButtonEventArgs) Handles txt_idHistoria.EditorButtonClick
        Select Case e.Button.Key
            Case "ayuda"
                Call Mostrar_Ayuda_Historias()
        End Select
    End Sub

    Private Sub Mostrar_Ayuda_Historias()
        ' FA_PR_ListaClientesAyuda.Int_Opcion = 1
        AD_PR_BuscaPaciente.ShowDialog()

        Dim matriz As List(Of String) = AD_PR_BuscaPaciente.GetLista

        'txt_ruc_cliente.ButtonsRight("editar").Enabled = False

        If matriz.Count > 0 Then

            txt_idHistoria.Text = matriz(0)
            Format(Val(txt_idHistoria.Text), "0000000000#")
            txt_Des_Cliente.Text = matriz(2)

            Cargar_Atenciones()
        End If

    End Sub

    Private Sub Buscar_historia()
        Dim HBL As New BL.AdmisionBL.SG_AD_TB_HISTO_CLINI
        Dim HBE As New BE.AdmisionBE.SG_AD_TB_HISTO_CLINI
        Dim drr_MOV As System.Data.SqlClient.SqlDataReader
        HBE.HC_NUM_HIST = Val(txt_idHistoria.Text)
        HBE.HC_IDEMPRESA = gInt_IdEmpresa
        drr_MOV = HBL.get_Historias_x_HIstoria(HBE)
        If drr_MOV.HasRows Then
            drr_MOV.Read()
            txt_Des_Cliente.Text = drr_MOV("HC_APE_PAT").ToString & " " & drr_MOV("HC_APE_MAT").ToString & " " & drr_MOV("HC_APE_CASADA").ToString & " " & drr_MOV("HC_NOMBRE1").ToString
            Cargar_Atenciones()
        Else
            Avisar("No existe la Historia")
        End If

        HBE = Nothing
        HBL = Nothing

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
            End If
        Next

        txt_SubTotal.Value = Math.Round(subtotal, 2)
        txt_IGV.Value = Math.Round(subtotal * (IGVTasa / 100), 2)
        txt_Total.Value = Math.Round(CType(txt_SubTotal.Value, Decimal) + CType(txt_IGV.Value, Decimal), 2)
    End Sub

    Private Sub Tool_Salir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_Salir.Click
        Me.Close()
    End Sub

    Private Sub Tool_Cancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_Cancelar.Click
        Inicializa()
    End Sub

    Private Sub pFormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        obe = Nothing
        obr = Nothing
        obeT = Nothing
        obeC = Nothing
        obrC = Nothing
        e.Cancel = False
    End Sub

    ''Cuenta
    Private Sub Cargar_PreFacturacion(ByVal id_preFac As Integer, ByVal tipo As Integer)
        obe.PF_ID = id_preFac
        obe.HasRow = False
        obr.SEL01(obe)
        If obe.HasRow Then
            With obe
                If .PF_IDTIPO_ATENC = 1 Then
                    uchk_SeguroEps.Checked = False
                    ucm_SeguroEps.SelectedIndex = -1
                Else
                    uchk_SeguroEps.Checked = True
                    ucm_SeguroEps.Value = .PF_IDSEGURO
                End If
                udte_fecha.Value = .PF_FECHA
                uce_Medico.Value = .PF_IDMEDICO
                txt_Tratamiento.Text = .PF_Tratamiento

                Dim obrD As New BL.FacturacionBL.SG_FA_TB_CIE10
                Dim ds_Diag As New DataSet
                ds_Diag = obrD.getOrigenBus(.PF_IDCIE10)
                If ds_Diag.Tables(0).Rows.Count > 0 Then
                    With ds_Diag.Tables(0)
                        txt_idDiagnostico.Text = .Rows(0)("CI_Descripcion")
                    End With
                End If

            End With
        End If
    End Sub
    Private Sub Buscar_Cuenta(ByVal i As Integer)
        If i = 0 Then
            obeC.CC_ID = Val(ug_Atenciones.ActiveRow.Cells(0).Value)
        Else
            obeC.CC_ID = Val(ug_Atenciones.Rows(0).Cells(0).Value)
        End If

        'Format(Val(txt_IdCuenta.Text), "0000000000#")
        obeC.HasRow = False
        obrC.SEL04(obeC)
        If obeC.HasRow Then
            With obeC
                ucm_Tipo.Value = .CC_IDTIPO_ORI
                ' txt_idHistoria.Value = .CC_IDNUM_HIST
                If .CC_IDTIPO_ATENC = 1 Then
                    uchk_SeguroEps.Checked = False
                    ucm_SeguroEps.SelectedIndex = -1
                Else
                    uchk_SeguroEps.Checked = True
                    ucm_SeguroEps.Value = .CC_IDSEGURO
                End If
                txt_DesCobertura.Value = .CC_SIT_COD_COBER
                txt_PagoFijo.Text = .CC_SIT_COPG_FIJO
                txt_PagoVariable.Text = .CC_SIT_COPG_VARI
                txt_MontoImponible.Text = .CC_SIT_MONTO_IMP
                uce_Medico.Value = .CC_MEDICO

                txt_Tratamiento.Text = "Ambulatorio"

                Dim obj As New DataTable
                obeT.TCD_IDCAB = obeC.CC_ID
                obrC.SEL010_TMP(obeT, String.Format("{0}-{1}", Environment.UserName, gStr_Usuario_Sis), Environment.MachineName, obj)
                ug_detalle.DataSource = obj
                Call Calcular_Totales()
                ug_detalle.UpdateData()

                Cargar_PreFacturacion(Val(obeC.CC_IDPREFAC), 1)

            End With
        Else
            Avisar("Cuenta no Existe!")
            Inicializa()
        End If
    End Sub
    Private Sub ug_Atenciones_AfterSelectChange(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinGrid.AfterSelectChangeEventArgs) Handles ug_Atenciones.AfterSelectChange
        If ug_Atenciones.ActiveRow.IsFilterRow Then Exit Sub
        Buscar_Cuenta(0)
        Cargar_Consumo_Farmacia(0)
        Cargar_Comprobantes(0)
    End Sub
   
    'Private Sub ug_Comprobantes_AfterSelectChange(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinGrid.AfterSelectChangeEventArgs) Handles ug_Comprobantes.AfterSelectChange
    '    If ug_Comprobantes.ActiveRow.IsFilterRow Then Exit Sub
    '    Dim ReporteBL As New BL.FacturacionBL.SG_FA_TB_COMPROBANTE_C
    '    '  ug_ComprobantesDET.DataSource = ReporteBL.get_ComprobantedET(ug_Comprobantes.ActiveRow.Cells("CO_ID").Value, 1)
    '    ReporteBL = Nothing
    'End Sub
    Private Sub Tool_Consultar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_Consultar.Click
        Cargar_Atenciones()
    End Sub

    Private Sub ubtn_imprimir_comp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ubtn_imprimir_comp.Click
        If ug_Comprobantes.Rows.Count = 0 Then Exit Sub

        Me.Cursor = Cursors.WaitCursor

        Dim nom_reporte As String = "SG_FA_01.RPT"
        Dim nom_param_linea As String = ""
        Dim texto_nota_cre As String = ""
        Dim bol_es_nc As Boolean = False

        Select Case ug_Comprobantes.ActiveRow.Cells("CO_TDOC").Value
            Case "01" 'factura
                'nom_reporte = "SG_FA_01.RPT"
                nom_reporte = "SG_FA_01_1F_G.RPT"
                nom_param_linea = "LINFACFAC"
            Case "07" 'nota de credito
                nom_reporte = "SG_FA_07_1F_G.RPT"
                'nom_reporte = "SG_FA_07_" & gInt_IdEmpresa.ToString & ".RPT"
                nom_param_linea = "LINFACNCR"

        End Select

        Dim idComprobante As Integer = ug_Comprobantes.ActiveRow.Cells("CO_ID").Value
        Dim reportesBL As New BL.FacturacionBL.SG_FA_Reportes
        Dim crystalBL As New LR.ClsReporte
        Dim dt_comprobante As DataTable = reportesBL.get_Comprobante(idComprobante, gInt_IdEmpresa)
        Dim Monto_en_Letras As String = Letras(ug_Comprobantes.ActiveRow.Cells("CO_TOTAL").Value).ToUpper
        Dim moneda As String = ug_Comprobantes.ActiveRow.Cells("CO_IDMONEDA").Value

        If moneda = "01" Then
            Monto_en_Letras = Monto_en_Letras & " NUEVOS SOLES"
        Else
            Monto_en_Letras = Monto_en_Letras & " DOLARES AMERICANOS"
        End If

        If ug_Comprobantes.ActiveRow.Cells("CO_TDOC").Value = "01" Then
            crystalBL.Muestra_Reporte(gStr_RutaRep & "\" & nom_reporte, dt_comprobante, "", "pMontoLetras;" & Monto_en_Letras, "pMoneda;" & moneda, "pSubTotal;" & ug_Comprobantes.ActiveRow.Cells("SubTotal").Value, "pDeducible;" & ug_Comprobantes.ActiveRow.Cells("CO_DEDUCIBLE").Value, "pSaldo;" & ug_Comprobantes.ActiveRow.Cells("Saldo").Value, "pCoaseguro;" & ug_Comprobantes.ActiveRow.Cells("CO_SEGURO").Value, "pPor;" & ug_Comprobantes.ActiveRow.Cells("CO_SEGURO_PORC").Value, "pFechaI;" & ug_Comprobantes.ActiveRow.Cells("PF_FechaIngreso").Value, "pFechaA;" & ug_Comprobantes.ActiveRow.Cells("PF_FechaAlta").Value, "pPaciente;" & txt_Des_Cliente.Text)
            'ElseIf uce_TipoDoc.Value = "03" Then
            '    crystalBL.Muestra_Reporte(gStr_RutaRep & "\" & nom_reporte, dt_comprobante, "", "pMontoLetras;" & Monto_en_Letras, "pMoneda;" & moneda, "pPaciente;" & txt_Des_Cliente.Text)
        Else
            'Call Completar_Lineas(nom_param_linea, dt_comprobante, bol_es_nc, texto_nota_cre)
            crystalBL.Muestra_Reporte(gStr_RutaRep & "\" & nom_reporte, dt_comprobante, "", "pMontoLetras;" & Monto_en_Letras, "pMoneda;" & moneda, "pSubTotal;" & ug_Comprobantes.ActiveRow.Cells("SubTotal").Value, "pDeducible;" & ug_Comprobantes.ActiveRow.Cells("CO_DEDUCIBLE").Value, "pSaldo;" & ug_Comprobantes.ActiveRow.Cells("Saldo").Value, "pCoaseguro;" & ug_Comprobantes.ActiveRow.Cells("CO_SEGURO").Value, "pPor;" & ug_Comprobantes.ActiveRow.Cells("CO_SEGURO_PORC").Value)
        End If

        crystalBL = Nothing
        reportesBL = Nothing

        Me.Cursor = Cursors.Default

    End Sub

    Private Sub Tool_Imprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_Imprimir.Click
        If ug_Atenciones.Rows.Count = 0 Then Exit Sub

        Dim dt_comprobante As New DataTable

        'Dim obj As New DataTable
        dt_comprobante = obrC.SEL07_TMP(Val(ug_Atenciones.ActiveRow.Cells(0).Value))
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

            subTotal = Math.Round(saldo - variable, 2) ' ug_Detalle.DisplayLayout.Bands(0).Summaries("sSubtotal").
            IGV = Math.Round((subTotal * IGVTasa) / 100, 2) 'ug_Detalle.DisplayLayout.Bands(0).Summaries("sIgv")
            'ume_total.Value = Math.Round(ume_subtotal.Value + ume_igv.Value, 2) 'ug_Detalle.DisplayLayout.Bands(0).Summaries("sTotal")

            If dt_comprobante.Rows.Count > 0 Then
                Dim crystalBL As New LR.ClsReporte
                Dim Monto_en_Letras As String = Letras(Math.Round(subTotal + IGV, 2)).ToUpper
                Monto_en_Letras = Monto_en_Letras & " NUEVOS SOLES"

                'crystalBL.Muestra_Reporte(gStr_RutaRep & "\SG_FA_16.RPT", dt_comprobante, "", "pSubT;" & txt_SubTotal.Text, "pIGV;" & txt_IGV.Text, "pTotal;" & txt_Total.Text, "pPresupuesto;" & Format("1", "0000000000#"), "pCuenta;" & Format(Val(ug_Atenciones.ActiveRow.Cells(0).Value), "0000000000#"), "pPaciente;" & txt_Des_Cliente.Text, "pSon;" & Monto_en_Letras, "pusu;" & IIf(gStr_Usuario_Sis.ToUpper = "MHERRERA", "MELISSA HERRERA", "ANA VALVERDE"))
                crystalBL.Muestra_Reporte(gStr_RutaRep & "\SG_FA_16.RPT", dt_comprobante, "", "pSubT;" & subTotal, "pIGV;" & IGV, "pTotal;" & Math.Round(subTotal + IGV, 2), "pCuenta;" & Format(Val(ug_Atenciones.ActiveRow.Cells(0).Value), "0000000000#"), "pPaciente;" & txt_Des_Cliente.Text, "pSon;" & Monto_en_Letras, "pusu;" & IIf(gStr_Usuario_Sis.ToUpper = "MHERRERA", "MELISSA HERRERA", "ANA VALVERDE"), "pCliente;" & ucm_SeguroEps.Text, "psubtotal1;" & subtotal1, "pdeducible;" & deducible, "psaldo;" & saldo, "pvariable;" & variable, "pPor;" & 100 - Val(txt_PagoVariable.Text))
                crystalBL = Nothing
            End If

            Me.Cursor = Cursors.Default

        Catch ex As Exception
            Throw ex
            Me.Cursor = Cursors.Default
        End Try
    End Sub

    Private Sub ug_consumos_InitializeRow(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinGrid.InitializeRowEventArgs) Handles ug_consumos.InitializeRow
        If e.Row.Cells(7).Value = 0 Then
            e.Row.Appearance.BackColor = Color.FromArgb(255, 128, 128)
        ElseIf e.Row.Cells(7).Value = 1 Then
            e.Row.Appearance.BackColor = Color.DeepSkyBlue
        Else
            e.Row.Appearance.BackColor = Color.LightGreen
        End If
    End Sub
End Class