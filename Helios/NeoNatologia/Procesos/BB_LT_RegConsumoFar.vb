Imports Infragistics.Win.UltraWinGrid
Public Class BB_LT_RegConsumoFar
    Private obe As BE.LogisticaBE.SG_LO_TB_CONSUMO_C
    Private obr As BL.LogisticaBL.SG_LO_TB_CONSUMO_C
    Private obeT As BE.LogisticaBE.SG_LO_TB_CONSUMO_D

    Public lNew As Boolean = False
    Public OPCION As Integer
    Dim IGVTasa As Double
    Public Sub New()
        InitializeComponent()
        obe = New BE.LogisticaBE.SG_LO_TB_CONSUMO_C
        obr = New BL.LogisticaBL.SG_LO_TB_CONSUMO_C
        obeT = New BE.LogisticaBE.SG_LO_TB_CONSUMO_D
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
        pLostfocus(txt_NumDoc, Nothing)
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
        txt_NumDoc.BackColor = Color.White
        ucbo_Estado.Value = 1

        uce_tip_doc.SelectedIndex = 0
        uce_TipoDoc.SelectedIndex = 0
        udte_fecha.Value = Now
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
    Private Sub uce_TipoDoc_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles uce_TipoDoc.ValueChanged

        Call Cargar_Series_Doc()
        Call Obtener_Ult_Num_Compro()

    End Sub
    Private Sub uce_Serie_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles uce_Serie.ValueChanged
        Call Obtener_Ult_Num_Compro()
    End Sub

    Private Sub CargarLista()
        Call Formatear_Grilla_Selector(ug_Lista)
        obe.CM_IDEMPRESA = 7
        obe.CM_IDALMACEN = uce_Almacen.Value
        obe.CM_IDREGISTRO = Val(txt_idRegistro.Text)
        ug_Lista.DataSource = obr.SEL02(obe)
    End Sub

    Private Sub BB_LT_RegConsumoFar_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Dim documentoscBL As New BL.AdmisionBL.SG_AD_TB_TIP_DOC_PER
        uce_tip_doc.DataSource = documentoscBL.getTiposDocs(7)
        uce_tip_doc.DisplayMember = "TD_ABREVIATURA"
        uce_tip_doc.ValueMember = "TD_ID"
        documentoscBL = Nothing

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


        Inicializa()

        Call Inicializar_Estado_Botones_Tool(ToolS_Mantenimiento)
        Call MostrarTabs(0, utc_Datos, 0)

        obe = New BE.LogisticaBE.SG_LO_TB_CONSUMO_C
        obr = New BL.LogisticaBL.SG_LO_TB_CONSUMO_C
        obeT = New BE.LogisticaBE.SG_LO_TB_CONSUMO_D

        Me.KeyPreview = True
        CargarLista()
      
        Call Cargar_Tasas_Impuestos()

    End Sub

    Function Datos() As Boolean
        Dim obrT As New BL.AdmisionBL.SG_AD_TB_CUENTA_CAB
        Dim obeC As New BE.AdmisionBE.SG_AD_TB_CUENTA_CAB

        obeC.CC_ID = Val(txt_IDCUENTA.Text)
        Format(Val(txt_IDCUENTA.Text), "0000000000#")
        obeC.HasRow = False
        obrT.SEL04(obeC)
        If obeC.HasRow Then
            With obeC
                Dim comproBL As New BL.FacturacionBL.SG_FA_TB_COMPROBANTE_C
                If comproBL.Existe_Comprob_Cuenta(Val(txt_IDCUENTA.Text)) Then
                    Call Avisar("La Cuenta ya fue facturada a la aseguradora, No puede usarla.")
                    Return False
                    Exit Function
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
                Return True
            End With
        End If
    End Function
    '----DETALLE
    Private Sub ubt_Agregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ubt_Agregar.Click
        LO_LT_ListaMedicamInsumos.IGVTas = IGVTasa
        LO_LT_ListaMedicamInsumos.TipoAten = 2
        LO_LT_ListaMedicamInsumos.idSeguro = txtIDSeguro.Text
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

            ' If articulo.DS_SALDO > 0 Then
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
        Next
        If cc > 0 Then
            Avisar(cc & " Producto no se pudieron agregar porque ya estan en la lista")
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

    Private Sub ug_Detalle_AfterRowUpdate(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinGrid.RowEventArgs) Handles ug_detalle.AfterRowUpdate
        Dim subtotal_cal As Decimal = "0.00"
        subtotal_cal = Math.Round((e.Row.Cells(5).Value * e.Row.Cells(6).Value), 2)
        e.Row.Cells(7).Value = subtotal_cal
    End Sub
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
            Exit Sub
        End If
        comproBL = Nothing

        If ug_detalle.Rows.Count = 0 Then
            Avisar("Falta agregar medicamentos")
            Exit Sub
        End If

        If lNew = True Then
            Dim rpta_existe As Boolean = False
            Call Validar_existe_num_comprobante(rpta_existe)

            If rpta_existe Then
                Call Obtener_Ult_Num_Compro()
            End If
        Else
            Dim LOGBL As New BL.LogisticaBL.SG_LO_TB_CONSUMO_C
            If LOGBL.Existe_Transferencia(Val(txt_idConsumo.Text)) Then
                Call Avisar("El Doc. Ya se transfirio, No puede modificar.")
                Exit Sub
            End If
            LOGBL = Nothing
        End If
        With obe
            .CM_TDOC = uce_TipoDoc.Value
            .CM_SDOC = uce_Serie.Value
            .CM_NDOC = txt_NumDoc.Text
            .CM_FECHA = udte_fecha.Value
            .CM_IDALMACEN = uce_Almacen.Value
            .CM_IDCUENTA = txt_IDCUENTA.Text
            .CM_IDNUM_HIST = Val(txt_idHistoria.Value)
            .CM_IDEMPRESA = 7
            .CM_IDREGISTRO = Val(txt_idRegistro.Text)
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
            If obr.Insert_BEBE(obe, String.Format("{0}-{1}", Environment.UserName, gStr_Usuario_Sis), Environment.MachineName, ls_detalles) < 0 Then
                MessageBox.Show("La operación solicitada no ha podido ser realizada", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If
        Else
            obe.CM_ID = txt_idConsumo.Text
            Dim I As Integer = obr.Update_bebe(obe, String.Format("{0}-{1}", Environment.UserName, gStr_Usuario_Sis), Environment.MachineName, ls_detalles)
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

        CargarLista()

        Call Cambiar_Estado_Botones_Tool(ToolS_Mantenimiento)
        Call Tool_Nuevo_Click(sender, e)

    End Sub

    Private Sub Tool_Salir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_Salir.Click
        Me.Close()
    End Sub

    Private Sub Tool_Nuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_Nuevo.Click
        Inicializa()
        If Datos() Then
            Call Cambiar_Estado_Botones_Tool(ToolS_Mantenimiento)
            Call MostrarTabs(1, utc_Datos, 1)
            Call Obtener_Ult_Num_Compro()
            lNew = True
            ugb_Datos.Enabled = True
            uce_TipoDoc.Focus()
        End If
    End Sub

    Private Sub Tool_Cancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_Cancelar.Click
        Call Cambiar_Estado_Botones_Tool(ToolS_Mantenimiento)
        Tool_Grabar.Enabled = False
        Call MostrarTabs(0, utc_Datos, 0)
    End Sub

    Private Sub Tool_Editar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_Editar.Click
        If ug_Lista.Rows.Count = 0 Then Exit Sub
        If ug_Lista.ActiveRow Is Nothing Then Exit Sub
        'If ug_Lista.ActiveRow.Cells(11).Value = 0 Then
        '    Avisar("El Registro ya esta Anulado")
        '    Exit Sub
        'End If
        ' If Datos() Then
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
        txt_IDCUENTA.Text = ug_Lista.ActiveRow.Cells(6).Value
        ucbo_Estado.Value = ug_Lista.ActiveRow.Cells(13).Value


        Dim obrT As New BL.AdmisionBL.SG_AD_TB_CUENTA_CAB
        Dim obeC As New BE.AdmisionBE.SG_AD_TB_CUENTA_CAB
        obeC.CC_ID = Val(txt_IDCUENTA.Text)
        Format(Val(txt_IDCUENTA.Text), "0000000000#")
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
            Avisar("El Registro ya esta Anulado")
            Tool_Grabar.Enabled = False
            ugb_Datos.Enabled = False
        ElseIf ug_Lista.ActiveRow.Cells(11).Value = 0 Then
            Avisar("El Registro ya esta Anulado")
            Tool_Grabar.Enabled = False
            ugb_Datos.Enabled = False
        Else
            Tool_Grabar.Enabled = True
            ugb_Datos.Enabled = True
        End If

        Dim comproBL As New BL.FacturacionBL.SG_FA_TB_COMPROBANTE_C
        If comproBL.Existe_Comprob_Cuenta(Val(txt_IDCUENTA.Text)) Then
            Call Avisar("La Cuenta ya fue facturada a la aseguradora, No puede usarla.")
            Tool_Grabar.Enabled = False
            ugb_Datos.Enabled = False
        End If
        comproBL = Nothing

        obeT.DC_IDCONSUMO = Val(txt_idConsumo.Text)
        ug_detalle.DataSource = obr.SEL03(obeT, 1, gInt_IdEmpresa)

        ug_detalle.UpdateData()

        Call MostrarTabs(1, utc_Datos, 1)
        uce_tip_doc.Focus()

        '  End If
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

        Dim comproBL As New BL.FacturacionBL.SG_FA_TB_COMPROBANTE_C
        If comproBL.Existe_Comprob_Cuenta(Val(txt_IDCUENTA.Text)) Then
            Call Avisar("La Cuenta ya fue facturada a la aseguradora, No puede usarla.")
            Exit Sub
        End If
        comproBL = Nothing

        Dim LOGBL As New BL.LogisticaBL.SG_LO_TB_CONSUMO_C
        If LOGBL.Existe_Transferencia(Val(txt_idConsumo.Text)) Then
            Call Avisar("El Doc. Ya se transfirio, No puede modificar.")
            Exit Sub
        End If
        LOGBL = Nothing

        If Preguntar("Seguro de Eliminar?") Then
            obe.CM_ID = ug_Lista.ActiveRow.Cells(0).Value
            If obr.Delete(obe, String.Format("{0}-{1}", Environment.UserName, gStr_Usuario_Sis), Environment.MachineName) < 0 Then
                MessageBox.Show("La operación solicitada no ha podido ser realizada", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                Call Avisar("Listo!")
                CargarLista()
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

End Class