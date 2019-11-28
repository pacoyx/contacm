Imports Infragistics.Win.UltraWinGrid
Public Class LO_LT_Consumo
    Private obe As BE.LogisticaBE.SG_LO_TB_CONSUMO_C
    Private obr As BL.LogisticaBL.SG_LO_TB_CONSUMO_C

    Private obeT As BE.LogisticaBE.SG_LO_TB_CONSUMO_D
    'Private obrT As BL.FacturacionBL.SG_FA_TB_PRESUPUESTO_DET

    Public lNew As Boolean = False
    Public OPCION As Integer
    Dim IGVTasa As Double
    Public Sub New()
        InitializeComponent()
        obe = New BE.LogisticaBE.SG_LO_TB_CONSUMO_C
        obr = New BL.LogisticaBL.SG_LO_TB_CONSUMO_C
        obeT = New BE.LogisticaBE.SG_LO_TB_CONSUMO_D
        'obeT = New BE.FacturacionBE.SG_FA_TB_PRESUPUESTO_DET
        'obrT = New BL.FacturacionBL.SG_FA_TB_PRESUPUESTO_DET
    End Sub
    Private Sub pKeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Me.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Return) Then
            SendKeys.Send("{TAB}")
            e.Handled = True
        End If
    End Sub
    Private Sub pKeyPressNumero(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_IdCuenta.KeyPress
        e.KeyChar = fKeyPress(e.KeyChar, sender.Text, 2)
        e.Handled = (e.KeyChar = "")
    End Sub
    Private Sub pLostfocus(ByVal sender As Object, ByVal e As System.EventArgs)
        sender.BackColor = Color.White
        If sender.Text.Trim.Length < 1 Then
            sender.BackColor = Color.LightPink
        End If
    End Sub

    Private Sub Cargar_Tasas_Impuestos()

        Dim impuestosBL As New BL.ContabilidadBL.SG_CO_TB_IMPUESTO
        Dim impuestoBE As New BE.ContabilidadBE.SG_CO_TB_IMPUESTO

        impuestoBE.IM_IDEMPRESA = New BE.ContabilidadBE.SG_CO_TB_EMPRESA With {.EM_ID = 7}
        impuestoBE.IM_IDTIPOIMPUESTO = New BE.ContabilidadBE.SG_CO_TB_TIPO_IMPUESTO With {.TI_CODIGO = "01"}
        impuestoBE.IM_PERIODO = Now.Year
        impuestoBE.IM_MES = Now.Month

        impuestosBL.getImpuestos_x_Tipo(impuestoBE)
        IGVTasa = impuestoBE.IM_TASA


        impuestosBL = Nothing
        impuestoBE = Nothing

    End Sub

    Private Function fValida() As Boolean
        pLostfocus(txt_IdCuenta, Nothing)
        pLostfocus(txt_NumDoc, Nothing)

        If txt_IdCuenta.BackColor = Color.LightPink Then GoTo Err_Valida
        If txt_NumDoc.BackColor = Color.LightPink Then GoTo Err_Valida

        Return True
        Exit Function
Err_Valida:
        MessageBox.Show("Corrija ó Complete los campos errados !!", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Return False
    End Function

    Private Sub Inicializa()
        Call LimpiaGrid(ug_detalle, uds_detalle)
        Call Limpiar_Controls_InGroupox(ugb_Datos)
        txt_IdCuenta.BackColor = Color.White
        txt_NumDoc.BackColor = Color.White
        ucbo_Estado.Value = 1

        uce_Almacen.SelectedIndex = 0
        uce_tip_doc.SelectedIndex = 0
        udte_fecha.Value = Now
        uce_Almacen.ReadOnly = False
    End Sub

    Private Sub Cargar_Combos()
        '--almacenes
        Dim AlcBL As New BL.LogisticaBL.SG_LO_TB_ALMACEN
        uce_Almacen.DataSource = AlcBL.get_almacen_2(7, gInt_IdUsuario_Sis)
        uce_Almacen.DisplayMember = "AL_DESCRIPCION"
        uce_Almacen.ValueMember = "AL_ID"
        AlcBL = Nothing

        Dim documentoscBL As New BL.AdmisionBL.SG_AD_TB_TIP_DOC_PER
        uce_tip_doc.DataSource = documentoscBL.getTiposDocs(7)
        uce_tip_doc.DisplayMember = "TD_ABREVIATURA"
        uce_tip_doc.ValueMember = "TD_ID"
        documentoscBL = Nothing

    End Sub

    Private Sub uce_Almacen_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles uce_Almacen.ValueChanged

        Dim seriesBL As New BL.LogisticaBL.SG_LO_TB_ALMACEN_SERIE
        Dim seriesBE As New BE.LogisticaBE.SG_LO_TB_ALMACEN_SERIE

        seriesBE.AS_IDEMPRESA = 7
        seriesBE.AS_IDALMACEN = uce_Almacen.Value
        uce_TipoDoc.DataSource = seriesBL.SEL02(seriesBE)
        uce_TipoDoc.DisplayMember = "TD_DESCRIPCION"
        uce_TipoDoc.Value = "AS_TDOC"

        seriesBL = Nothing
        seriesBE = Nothing

        If uce_TipoDoc.Items.Count > 0 Then uce_TipoDoc.SelectedIndex = 0

        Call LimpiaGrid(ug_detalle, uds_detalle)
    End Sub

    Private Sub Cargar_Series_Doc()

        Dim seriesBL As New BL.LogisticaBL.SG_LO_TB_ALMACEN_SERIE
        Dim seriesBE As New BE.LogisticaBE.SG_LO_TB_ALMACEN_SERIE

        seriesBE.AS_IDEMPRESA = 7
        seriesBE.AS_IDALMACEN = uce_Almacen.Value
        seriesBE.AS_TDOC = uce_TipoDoc.Value

        uce_Serie.DataSource = seriesBL.SEL03(seriesBE)
        uce_Serie.DisplayMember = "AS_SERIE"
        uce_Serie.ValueMember = "AS_SERIE"

        seriesBE = Nothing
        seriesBL = Nothing

        If uce_Serie.Items.Count > 0 Then uce_Serie.SelectedIndex = 0

    End Sub

    Private Sub Obtener_Ult_Num_Compro()

        Dim numeracionBL As New BL.LogisticaBL.SG_LO_TB_NUM_COMPRO
        Dim numeracionBE As New BE.LogisticaBE.SG_LO_TB_NUM_COMPRO

        numeracionBE.NC_IDTIPO = uce_TipoDoc.Value
        numeracionBE.NC_IDEMPRESA = 7
        numeracionBE.NC_SERIE = uce_Serie.Value

        txt_NumDoc.Text = numeracionBL.SEL02(numeracionBE)

        numeracionBE = Nothing
        numeracionBL = Nothing
    End Sub

    'Private Sub Validar_existe_num_comprobante(ByRef existe As Boolean)

    '    Dim comproBL As New BL.LogisticaBL.SG_LO_TB_CONSUMO_C
    '    Dim comproBE As New BE.LogisticaBE.SG_LO_TB_CONSUMO_C

    '    comproBE.CM_TDOC = uce_TipoDoc.Value
    '    comproBE.CM_SDOC = uce_Serie.Value
    '    comproBE.CM_NDOC = txt_NumDoc.Text
    '    comproBE.CM_IDEMPRESA = 7

    '    If comproBL.SEL02(comproBE) Then
    '        Call Avisar("El numero de comprobante " & uce_TipoDoc.Text & "-" & uce_Serie.Value & "-" & txt_NumDoc.Text & " ya esta registrado,! Cuidado")
    '        existe = True
    '    End If

    '    comproBE = Nothing
    '    comproBL = Nothing

    'End Sub

    Private Sub uce_TipoDoc_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles uce_TipoDoc.ValueChanged

        Call Cargar_Series_Doc()
        Call Obtener_Ult_Num_Compro()

    End Sub

    Private Sub uce_Serie_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles uce_Serie.ValueChanged
        Call Obtener_Ult_Num_Compro()
    End Sub

    Private Sub LO_LT_Consumo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Cargar_Combos()
        Call CargarCombo_ConMeses(uce_Mes)
        Inicializa()
        uce_Mes.Value = Now.Month
        txt_año.Text = Now.Year

        Call Inicializar_Estado_Botones_Tool(ToolS_Mantenimiento)
        Tool_Imprimir.Enabled = False
        Call MostrarTabs(0, utc_Datos, 0)

        'txt_ruc_cliente.ButtonsRight(0).Appearance.Image = My.Resources._104
        txt_IdCuenta.ButtonsRight(0).Appearance.Image = My.Resources._104

        obe = New BE.LogisticaBE.SG_LO_TB_CONSUMO_C
        obr = New BL.LogisticaBL.SG_LO_TB_CONSUMO_C
        obeT = New BE.LogisticaBE.SG_LO_TB_CONSUMO_D

        Me.KeyPreview = True

        Call Formatear_Grilla_Selector(ug_Lista)
        obe.CM_IDEMPRESA = 7

        ug_Lista.DataSource = obr.SEL01(obe, gInt_IdUsuario_Sis, uce_Mes.Value, Val(txt_año.Text))

        Timer1.Enabled = True
        Timer1.Interval = 60000

        Call Cargar_Tasas_Impuestos()
    End Sub


    '-------------pacientes clientes

    Private Sub Ayuda_Anexo_Cab()
        ' FA_PR_ListaClientesAyuda.Int_Opcion = 1
        AD_PR_BuscaPaciente.ShowDialog()

        Dim matriz As List(Of String) = AD_PR_BuscaPaciente.GetLista

        If matriz.Count > 0 Then

            txt_idHistoria.Text = matriz(0)
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
                Format(Val(txt_IdCuenta.Text), "0000000000#")
                txtIDSeguro.Text = IIf(matrizC(6) = 1, "000", matrizC(7))
                Dim comproBL As New BL.FacturacionBL.SG_FA_TB_COMPROBANTE_C
                If comproBL.Existe_Comprob_Cuenta(Val(txt_IdCuenta.Text)) Then
                    Call Avisar("La Cuenta ya fue facturada a la aseguradora, No puede usarla.")
                    Inicializa()
                    Exit Sub
                End If
                comproBL = Nothing
            Else
                txt_IdCuenta.Text = ""
                txtIDSeguro.Text = ""
            End If

            Call LimpiaGrid(ug_detalle, uds_detalle)
            ug_detalle.UpdateData()
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
            txt_idHistoria.Text = clienteBE.HC_NUM_HIST
            txt_Des_Cliente.Text = clienteBE.HC_NOMBRE1

            LO_LT_ListaCuentas.txt_filtro.Text = txt_Des_Cliente.Text
            LO_LT_ListaCuentas.TIPO = 0
            LO_LT_ListaCuentas.ShowDialog()
            Dim matrizC As List(Of String) = LO_LT_ListaCuentas.GetLista

            If matrizC.Count > 0 Then
                txt_IdCuenta.Text = matrizC(0)
                Format(Val(txt_IdCuenta.Text), "0000000000#")
                txtIDSeguro.Text = IIf(matrizC(6) = 1, "000", matrizC(7))
                Dim comproBL As New BL.FacturacionBL.SG_FA_TB_COMPROBANTE_C
                If comproBL.Existe_Comprob_Cuenta(Val(txt_IdCuenta.Text)) Then
                    Call Avisar("La Cuenta ya fue facturada a la aseguradora, No puede usarla.")
                    Inicializa()
                    Exit Sub
                End If
                comproBL = Nothing
            Else
                txt_IdCuenta.Text = ""
                txtIDSeguro.Text = ""
            End If

            Call LimpiaGrid(ug_detalle, uds_detalle)
            ug_detalle.UpdateData()

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

            Dim comproBL As New BL.FacturacionBL.SG_FA_TB_COMPROBANTE_C
            If comproBL.Existe_Comprob_Cuenta(Val(txt_IdCuenta.Text)) Then
                Call Avisar("La Cuenta ya fue facturada a la aseguradora, No puede usarla.")
                Inicializa()
                Exit Sub
            End If
            comproBL = Nothing

            Format(Val(txt_IdCuenta.Text), "0000000000#")
            txt_idHistoria.Value = matriz(3)
            txtIDSeguro.Text = IIf(matriz(6) = 1, "000", matriz(7))

            Dim historiaBL As New BL.AdmisionBL.SG_AD_TB_HISTO_CLINI
            Dim dt_histo_tmp As DataTable = historiaBL.getHistorias_Base_x_Id(txt_idHistoria.Value, 1)
            If dt_histo_tmp.Rows.Count > 0 Then
                txt_Des_Cliente.Text = dt_histo_tmp.Rows(0)("HC_APE_PAT") & " " & dt_histo_tmp.Rows(0)("HC_APE_MAT") & " " & dt_histo_tmp.Rows(0)("HC_APE_CASADA") & " " & dt_histo_tmp.Rows(0)("HC_NOMBRE1") & " " & dt_histo_tmp.Rows(0)("HC_NOMBRE2")
                txt_ruc_cliente.Text = dt_histo_tmp.Rows(0)("HC_NDOC")
                uce_tip_doc.Value = dt_histo_tmp.Rows(0)("HC_TDOC")
            End If
            Format(Val(txt_idHistoria.Text), "0000000000#")
            Call LimpiaGrid(ug_detalle, uds_detalle)

            ug_detalle.UpdateData()

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
                    Call Avisar("La Cuenta ya fue facturada a la aseguradora, No puede usarla.")
                    Inicializa()
                    Exit Sub
                End If
                comproBL = Nothing


                txt_idHistoria.Value = .CC_IDNUM_HIST
                txtIDSeguro.Text = IIf(.CC_IDTIPO_ATENC = 1, "000", .CC_IDSEGURO)

                Dim historiaBL As New BL.AdmisionBL.SG_AD_TB_HISTO_CLINI
                Dim dt_histo_tmp As DataTable = historiaBL.getHistorias_Base_x_Id(txt_idHistoria.Value, 1)
                If dt_histo_tmp.Rows.Count > 0 Then
                    txt_Des_Cliente.Text = dt_histo_tmp.Rows(0)("HC_APE_PAT") & " " & dt_histo_tmp.Rows(0)("HC_APE_MAT") & " " & dt_histo_tmp.Rows(0)("HC_APE_CASADA") & " " & dt_histo_tmp.Rows(0)("HC_NOMBRE1") & " " & dt_histo_tmp.Rows(0)("HC_NOMBRE2")
                    txt_ruc_cliente.Text = dt_histo_tmp.Rows(0)("HC_NDOC")
                    uce_tip_doc.Value = dt_histo_tmp.Rows(0)("HC_TDOC")
                End If
                Format(Val(txt_idHistoria.Text), "0000000000#")

                Call LimpiaGrid(ug_detalle, uds_detalle)
                'Dim obj As New DataTable
                'obeT.TCD_IDCAB = Val(txt_IdCuenta.Text)
                'obrT.SEL010_TMP(obeT, String.Format("{0}-{1}", Environment.UserName, gStr_Usuario_Sis), Environment.MachineName, obj)
                'ug_detalle.DataSource = obj

                ug_detalle.UpdateData()

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

    '----DETALLE
    Private Sub ubt_Agregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ubt_Agregar.Click
        LO_LT_ListaMedicamInsumos.IGVTas = IGVTasa
        LO_LT_ListaMedicamInsumos.TipoAten = 2
        LO_LT_ListaMedicamInsumos.idSeguro = IIf(txtIDSeguro.Text = "", "000", txtIDSeguro.Text)
        LO_LT_ListaMedicamInsumos.idalmacen = uce_Almacen.Value
        LO_LT_ListaMedicamInsumos.ShowDialog()

        Dim matriz As List(Of BE.LogisticaBE.SG_LO_TB_ARTICULO) = LO_LT_ListaMedicamInsumos.GetLista
        Dim aa As Integer = 0
        Dim cc As Integer = 0
        For Each articulo As BE.LogisticaBE.SG_LO_TB_ARTICULO In matriz
            'DC_ITEM()
            'DC_IDARTICULO()
            'AR_DESCRIPCION()
            'UM_Des()
            'DC_IDLOTE()
            'DC_PRECIO()
            'DC_CANT()
            'DC_TOTAL()
            'DC_SEG_CUBRE()
            'DC_Trans()
            'DS_SALDO

            If articulo.DS_SALDO > 0 Then
                Dim bb As Integer = 0
                For d As Integer = 0 To ug_detalle.Rows.Count - 1
                    If ug_detalle.Rows(d).Cells("DC_IDARTICULO").Value = articulo.AR_ID Then
                        bb = bb + 1
                    End If
                Next
                If bb = 0 Then
                    ug_detalle.DisplayLayout.Bands(0).AddNew()
                    ug_detalle.Rows(ug_detalle.Rows.Count - 1).Cells(0).Value = ug_detalle.Rows.Count
                    ug_detalle.Rows(ug_detalle.Rows.Count - 1).Cells("DC_IDARTICULO").Value = articulo.AR_ID  'codigo id
                    ug_detalle.Rows(ug_detalle.Rows.Count - 1).Cells(2).Value = articulo.AR_DESCRIPCION 'codigo
                    ug_detalle.Rows(ug_detalle.Rows.Count - 1).Cells(3).Value = articulo.UM_DesV  'descripcion
                    ug_detalle.Rows(ug_detalle.Rows.Count - 1).Cells("DC_IDLOTE").Value = articulo.DS_IDLOTE
                    ug_detalle.Rows(ug_detalle.Rows.Count - 1).Cells("DC_PRECIO").Value = articulo.AR_PRECIO_VENTA
                    ug_detalle.Rows(ug_detalle.Rows.Count - 1).Cells("DC_CANT").Value = 1
                    ug_detalle.Rows(ug_detalle.Rows.Count - 1).Cells(7).Value = articulo.AR_PRECIO_VENTA
                    ug_detalle.Rows(ug_detalle.Rows.Count - 1).Cells("DC_SEG_CUBRE").Value = IIf(txtIDSeguro.Text <> "000", True, False)
                    ug_detalle.Rows(ug_detalle.Rows.Count - 1).Cells("DC_Trans").Value = 1
                    ug_detalle.Rows(ug_detalle.Rows.Count - 1).Cells("DS_SALDO").Value = articulo.DS_SALDO
                Else
                    cc = cc + 1
                End If
                
            Else
                aa = aa + 1
            End If
        Next
        If cc > 0 Then
            Avisar(cc & " Producto no se pudieron agregar porque ya estan en la lista")
        End If
        If aa > 0 Then
            Avisar(aa & " Productos no se pudieron agregar porque no tiene Stock")
        End If

        ug_detalle.UpdateData()
        ug_detalle.Refresh()
        ' Call Calcular_Totales()
    End Sub
    Private Sub ubt_Quitar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ubt_Quitar.Click
        If ug_detalle.Rows.Count = 0 Then Exit Sub
        If ug_detalle.ActiveRow Is Nothing Then Exit Sub

        If Preguntar("Seguro que deseas eliminar el registro?") Then
            ug_detalle.ActiveRow.Delete()
        End If

    End Sub

    Private Sub ug_detalle_BeforeRowUpdate(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinGrid.CancelableRowEventArgs) Handles ug_detalle.BeforeRowUpdate
        If e.Row.Cells(6).Value > e.Row.Cells(10).Value Then
            Avisar("Stock no suficiente")
            e.Cancel = True
        End If
    End Sub

    Private Sub ug_Detalle_AfterRowUpdate(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinGrid.RowEventArgs) Handles ug_detalle.AfterRowUpdate
        Dim subtotal_cal As Decimal = "0.00"
        subtotal_cal = Math.Round((e.Row.Cells(5).Value * e.Row.Cells(6).Value), 2)
        e.Row.Cells(7).Value = subtotal_cal
    End Sub
    'Private Sub ug_Detalle_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles ug_detalle.KeyDown
    '    If e.KeyCode = Keys.Enter Then
    '        ug_detalle.PerformAction(UltraGridAction.NextCellByTab, False, False)
    '        ug_detalle.UpdateData()
    '    End If
    'End Sub
    Private Sub ug_Detalle_BeforeRowsDeleted(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.BeforeRowsDeletedEventArgs) Handles ug_detalle.BeforeRowsDeleted
        e.DisplayPromptMsg = False
        e.Cancel = False

    End Sub

    Private Sub Validar_existe_num_comprobante(ByRef existe As Boolean)

        Dim comproBL As New BL.LogisticaBL.SG_LO_TB_MOVIMIENTOS_C
        Dim comproBE As New BE.LogisticaBE.SG_LO_TB_MOVIMIENTOS_C

        comproBE.MO_TDOC = uce_TipoDoc.Value
        comproBE.MO_SDOC = uce_Serie.Value
        comproBE.MO_NDOC = txt_NumDoc.Text
        If gInt_IdEmpresa = 1 Then
            comproBE.MO_IDEMPRESA = 7
        Else
            comproBE.MO_IDEMPRESA = gInt_IdEmpresa
        End If
        If comproBL.Existe_cORRETATIVO(comproBE) Then
            Call Avisar("El numero de comprobante " & uce_TipoDoc.Text & "-" & uce_Serie.Value & "-" & txt_NumDoc.Text & " ya esta registrado,! Cuidado")
            existe = True
        End If

        comproBE = Nothing
        comproBL = Nothing

    End Sub

    '---menu
    Private Sub Tool_Grabar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_Grabar.Click
        If fValida() = False Then Exit Sub
        Dim comproBL As New BL.FacturacionBL.SG_FA_TB_COMPROBANTE_C
        If comproBL.Existe_Comprob_Cuenta(Val(txt_IdCuenta.Text)) Then
            Call Avisar("La Cuenta ya fue facturada, No puede usarla.")
            'Inicializa()
            Exit Sub
        End If
        comproBL = Nothing

        If lNew = True Then
            Dim rpta_existe As Boolean = False
            Call Validar_existe_num_comprobante(rpta_existe)

            If rpta_existe Then
               Call Obtener_Ult_Num_Compro()
            End If
        End If

        If ug_detalle.Rows.Count = 0 Then
            Avisar("Falta agregar medicamentos")
            Exit Sub
        End If
        With obe
            .CM_TDOC = uce_TipoDoc.Value
            .CM_SDOC = uce_Serie.Value
            .CM_NDOC = txt_NumDoc.Text
            .CM_FECHA = udte_fecha.Value
            .CM_IDALMACEN = uce_Almacen.Value
            .CM_IDCUENTA = txt_IdCuenta.Text
            .CM_IDNUM_HIST = Val(txt_idHistoria.Value)
            .CM_IDEMPRESA = 7
        End With

        'Dim detalleBE As BE.LogisticaBE.SG_LO_TB_COMPROBANTES_DET
        Dim ls_detalles As New List(Of BE.LogisticaBE.SG_LO_TB_CONSUMO_D)
        Dim obeTc As BE.LogisticaBE.SG_LO_TB_CONSUMO_D
        ug_detalle.UpdateData()

        Dim total As Decimal = 0
        For i As Integer = 0 To ug_detalle.Rows.Count - 1
            obeTc = New BE.LogisticaBE.SG_LO_TB_CONSUMO_D
            With obeTc
                .DC_ITEM = i + 1
                .DC_IDARTICULO = ug_detalle.Rows(i).Cells("DC_IDARTICULO").Value
                .DC_IDLOTE = ug_detalle.Rows(i).Cells("DC_IDLOTE").Value
                .DC_CANT = ug_detalle.Rows(i).Cells("DC_CANT").Value
                .DC_PRECIO = ug_detalle.Rows(i).Cells("DC_PRECIO").Value
                .DC_TOTAL = ug_detalle.Rows(i).Cells(7).Value
                '.DC_SEG_CUBRE = ug_detalle.Rows(i).Cells(8).Value
                .DC_SEG_CUBRE = ug_detalle.Rows(i).Cells("DC_SEG_CUBRE").Value  'IIf(ug_detalle.Rows(i).Cells("DC_SEG_CUBRE").Value = True, 1, 0)
                total = total + .DC_TOTAL
            End With
            ls_detalles.Add(obeTc)
        Next
        obe.CM_TOTAL = total

        If lNew Then
            If obr.Insert(obe, String.Format("{0}-{1}", Environment.UserName, gStr_Usuario_Sis), Environment.MachineName, ls_detalles) < 0 Then
                MessageBox.Show("La operación solicitada no ha podido ser realizada", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If
        Else
            obe.CM_ID = txt_idConsumo.Text
            Dim I As Integer = obr.Update(obe, String.Format("{0}-{1}", Environment.UserName, gStr_Usuario_Sis), Environment.MachineName, ls_detalles)
            If I = -2 Then
                MessageBox.Show("No Se puede modificar un consumo del inventario ya cerrado, Registrar otro Documento", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Exit Sub
            End If
            If I = -1 Then
                MessageBox.Show("La operación solicitada no ha podido ser realizada", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If

        End If
        Call Avisar("Listo!")

        obe.CM_IDEMPRESA = 7
        ug_Lista.DataSource = obr.SEL01(obe, gInt_IdUsuario_Sis, uce_Mes.Value, Val(txt_año.Text))

        Call Cambiar_Estado_Botones_Tool(ToolS_Mantenimiento)
        Call Tool_Nuevo_Click(sender, e)

    End Sub

    Private Sub Tool_Salir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_Salir.Click
        Me.Close()
    End Sub

    Private Sub Tool_Nuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_Nuevo.Click
        Call Cambiar_Estado_Botones_Tool(ToolS_Mantenimiento)
        Tool_Imprimir.Enabled = False
        Call MostrarTabs(1, utc_Datos, 1)
        Inicializa()
        Call Obtener_Ult_Num_Compro()
        lNew = True
        ugb_Datos.Enabled = True
        uce_Almacen.SelectedIndex = 0
        uce_tip_doc.Focus()
    End Sub

    Private Sub Tool_Cancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_Cancelar.Click
        Call Cambiar_Estado_Botones_Tool(ToolS_Mantenimiento)
        Tool_Grabar.Enabled = False
        Tool_Imprimir.Enabled = False
        Call MostrarTabs(0, utc_Datos, 0)
    End Sub

    Private Sub Tool_Editar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_Editar.Click
        If ug_Lista.Rows.Count = 0 Then Exit Sub
        If ug_Lista.ActiveRow Is Nothing Then Exit Sub

        If ug_Lista.ActiveRow.Cells(11).Value = 0 Then
            Avisar("El Registro ya esta Anulado")
            Exit Sub
        End If
        lNew = False

        Call Cambiar_Estado_Botones_Tool(ToolS_Mantenimiento)

        txt_idConsumo.Text = ug_Lista.ActiveRow.Cells(0).Value
        txt_idHistoria.Value = ug_Lista.ActiveRow.Cells(7).Value
        Dim historiaBL As New BL.AdmisionBL.SG_AD_TB_HISTO_CLINI
        Dim dt_histo_tmp As DataTable = historiaBL.getHistorias_Base_x_Id(txt_idHistoria.Value, 1)
        If dt_histo_tmp.Rows.Count > 0 Then
            txt_Des_Cliente.Text = dt_histo_tmp.Rows(0)("HC_APE_PAT") & " " & dt_histo_tmp.Rows(0)("HC_APE_MAT") & " " & dt_histo_tmp.Rows(0)("HC_NOMBRE1")
            txt_ruc_cliente.Text = dt_histo_tmp.Rows(0)("HC_NDOC")
            uce_tip_doc.Value = dt_histo_tmp.Rows(0)("HC_TDOC")
        End If

        udte_fecha.Value = ug_Lista.ActiveRow.Cells(10).Value
        uce_TipoDoc.Value = ug_Lista.ActiveRow.Cells(2).Value
        uce_Serie.Value = ug_Lista.ActiveRow.Cells(3).Value
        txt_NumDoc.Text = ug_Lista.ActiveRow.Cells(4).Value
        uce_Almacen.Value = ug_Lista.ActiveRow.Cells(5).Value
        txt_IdCuenta.Text = ug_Lista.ActiveRow.Cells(6).Value
        ucbo_Estado.Value = ug_Lista.ActiveRow.Cells(13).Value

        Dim obrT As New BL.AdmisionBL.SG_AD_TB_CUENTA_CAB
        Dim obeC As New BE.AdmisionBE.SG_AD_TB_CUENTA_CAB
        obeC.CC_ID = Val(txt_IdCuenta.Text)
        Format(Val(txt_IdCuenta.Text), "0000000000#")
        obeC.HasRow = False
        obrT.SEL04(obeC)
        If obeC.HasRow Then
            txtIDSeguro.Text = IIf(obeC.CC_IDTIPO_ATENC = 1, "000", obeC.CC_IDSEGURO)
        End If

        If ug_Lista.ActiveRow.Cells(13).Value = "2" Then
            Avisar("El Consumo ya fue transferido")
            Tool_Grabar.Enabled = False
            ugb_Datos.Enabled = False
        ElseIf ug_Lista.ActiveRow.Cells(13).Value = "3" Then
            Avisar("El Consumo ya fue Facturado")
            Tool_Grabar.Enabled = False
            ugb_Datos.Enabled = False
        Else
            Tool_Grabar.Enabled = True
            ugb_Datos.Enabled = True
        End If

        obeT.DC_IDCONSUMO = Val(txt_idConsumo.Text)
        ug_detalle.DataSource = obr.SEL03(obeT, 1, gInt_IdEmpresa)

        ug_detalle.UpdateData()

        Tool_Imprimir.Enabled = True

        Dim obrM As New BL.LogisticaBL.SG_LO_TB_MOVIMIENTOS_C
        Dim drr_MOV As System.Data.SqlClient.SqlDataReader
        drr_MOV = obrM.SEL09(Val(txt_idConsumo.Text))
        If drr_MOV.HasRows Then
            drr_MOV.Read()
            txt_IDMOV.Text = drr_MOV("MO_ID")
        Else
            txt_IDMOV.Text = ""
        End If
        drr_MOV.Close()
        obrM = Nothing
        Call MostrarTabs(1, utc_Datos, 1)
        uce_Almacen.ReadOnly = True
        uce_tip_doc.Focus()

    End Sub

    Private Sub Tool_Eliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_Eliminar.Click
        If ug_Lista.Rows.Count = 0 Then Exit Sub
        If ug_Lista.ActiveRow Is Nothing Then Exit Sub

        If ug_Lista.ActiveRow.Cells(11).Value = 0 Then
            Avisar("El Registro ya esta Anulado")
            Exit Sub
        End If
        If ug_Lista.ActiveRow.Cells(13).Value <> "1" Then
            Avisar("El Consumo ya fue transferido")
            Exit Sub
        End If

        If Preguntar("Seguro de Eliminar?") Then
            obe.CM_ID = ug_Lista.ActiveRow.Cells(0).Value
            Dim i As Integer
            i = obr.Delete(obe, String.Format("{0}-{1}", Environment.UserName, gStr_Usuario_Sis), Environment.MachineName)
            If i = -2 Then
                MessageBox.Show("No se puede anular el comprobante, corresponde a un Inventario ya cerrado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            ElseIf i < 0 Then
                MessageBox.Show("La operación solicitada no ha podido ser realizada", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                Call Avisar("Listo!")
                obe.CM_IDEMPRESA = 7
                ug_Lista.DataSource = obr.SEL01(obe, gInt_IdUsuario_Sis, uce_Mes.Value, Val(txt_año.Text))
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

    Private Sub ug_Lista_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ug_Lista.DoubleClick
        Tool_Editar_Click(sender, e)
    End Sub

    Private Sub ug_Lista_InitializeRow(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinGrid.InitializeRowEventArgs) Handles ug_Lista.InitializeRow
        If e.Row.Cells(11).Value = 0 Then
            e.Row.Appearance.ForeColor = Color.Tomato
        End If
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        obe.CM_IDEMPRESA = 7
        ug_Lista.DataSource = obr.SEL01(obe, gInt_IdUsuario_Sis, uce_Mes.Value, Val(txt_año.Text))
    End Sub

    Private Sub uce_Mes_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles uce_Mes.LostFocus
        ug_Lista.DataSource = obr.SEL01(obe, gInt_IdUsuario_Sis, uce_Mes.Value, Val(txt_año.Text))
    End Sub

    Private Sub txt_año_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_año.LostFocus
        ug_Lista.DataSource = obr.SEL01(obe, gInt_IdUsuario_Sis, uce_Mes.Value, Val(txt_año.Text))
    End Sub

    Private Sub Tool_Imprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_Imprimir.Click
        ' If ucbo_Estado.Value = 1 Then Exit Sub

        Dim dt_comprobante As New DataTable
        Dim obrM As New BL.LogisticaBL.SG_LO_TB_MOVIMIENTOS_C

        'Dim obj As New DataTable
        dt_comprobante = obrM.SEL05(Val(txt_IDMOV.Text))
        'ug_detalle.DataSource = dt_comprobante

        Try
            Me.Cursor = Cursors.WaitCursor

            If dt_comprobante.Rows.Count > 0 Then
                Dim crystalBL As New LR.ClsReporte

                crystalBL.Muestra_Reporte(gStr_RutaRep & "\SG_LO_04.RPT", dt_comprobante, "", "ptdoc;" & uce_TipoDoc.Text, "pserie;" & uce_Serie.Text, "pnumero;" & txt_NumDoc.Text, "pPaciente; Paciente: " & txt_Des_Cliente.Text & "   Historia: " & txt_idHistoria.Text, "pAlmacenOri;" & "Farmacia", "pAlmacenDes;" & uce_Almacen.Text, "pMotivo;" & "REQUERIMIENTO PARA ALMACEN")

                crystalBL = Nothing
            End If

            Me.Cursor = Cursors.Default

        Catch ex As Exception
            Throw ex
            Me.Cursor = Cursors.Default
        End Try

    End Sub
End Class