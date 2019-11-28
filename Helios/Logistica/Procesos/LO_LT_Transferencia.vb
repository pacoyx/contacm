Imports Infragistics.Win.UltraWinGrid
Public Class LO_LT_Transferencia
    Private obe As BE.LogisticaBE.SG_LO_TB_CONSUMO_C
    Private obr As BL.LogisticaBL.SG_LO_TB_CONSUMO_C
    Private obeM As BE.LogisticaBE.SG_LO_TB_MOVIMIENTOS_C
    Private obrM As BL.LogisticaBL.SG_LO_TB_MOVIMIENTOS_C

    'Private obeT As BE.LogisticaBE.SG_LO_TB_CONSUMO_D
    'Private obeTM As BE.LogisticaBE.SG_LO_TB_MOVIMIENTOS_D
    'Private obrT As BL.FacturacionBL.SG_FA_TB_PRESUPUESTO_DET

    Public lNew As Boolean = False
    Public OPCION As Integer
    Dim IGVTasa As Double
    Public Sub New()
        InitializeComponent()
        obe = New BE.LogisticaBE.SG_LO_TB_CONSUMO_C
        obr = New BL.LogisticaBL.SG_LO_TB_CONSUMO_C
        obeM = New BE.LogisticaBE.SG_LO_TB_MOVIMIENTOS_C
        obrM = New BL.LogisticaBL.SG_LO_TB_MOVIMIENTOS_C
        'obeT = New BE.LogisticaBE.SG_LO_TB_CONSUMO_D
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

        uchk_Transferencia.Enabled = True
        uce_SerieTrans.ReadOnly = False
        uce_TipoDocTrans.ReadOnly = False
        ubnt_Transferencias.Enabled = True


        uce_tip_doc.SelectedIndex = 0
        udte_fecha.Value = Now
    End Sub

    Private Sub Cargar_Combos()
        '--almacenes
        Dim AlcBL As New BL.LogisticaBL.SG_LO_TB_ALMACEN
        uce_Almacen.DataSource = AlcBL.get_almacen_3(gInt_IdEmpresa)
        uce_Almacen.DisplayMember = "AL_DESCRIPCION"
        uce_Almacen.ValueMember = "AL_ID"
        AlcBL = Nothing

        Dim documentoscBL As New BL.AdmisionBL.SG_AD_TB_TIP_DOC_PER
        uce_tip_doc.DataSource = documentoscBL.getTiposDocs(gInt_IdEmpresa)
        uce_tip_doc.DisplayMember = "TD_ABREVIATURA"
        uce_tip_doc.ValueMember = "TD_ID"
        documentoscBL = Nothing

        Dim asegBL As New BL.FacturacionBL.SG_FA_TB_CIA_ASEG
        ucm_SeguroEps.DataSource = asegBL.getAseguradoras(gInt_IdEmpresa)
        ucm_SeguroEps.DisplayMember = "CA_DESCRIPCION"
        ucm_SeguroEps.ValueMember = "CA_ID"
        asegBL = Nothing

    End Sub

    Private Sub Cargar_Tasas_Impuestos()

        Dim impuestosBL As New BL.ContabilidadBL.SG_CO_TB_IMPUESTO
        Dim impuestoBE As New BE.ContabilidadBE.SG_CO_TB_IMPUESTO

        impuestoBE.IM_IDEMPRESA = New BE.ContabilidadBE.SG_CO_TB_EMPRESA With {.EM_ID = gInt_IdEmpresa}
        impuestoBE.IM_IDTIPOIMPUESTO = New BE.ContabilidadBE.SG_CO_TB_TIPO_IMPUESTO With {.TI_CODIGO = "01"}
        impuestoBE.IM_PERIODO = Now.Year
        impuestoBE.IM_MES = Now.Month

        impuestosBL.getImpuestos_x_Tipo(impuestoBE)
        IGVTasa = impuestoBE.IM_TASA


        impuestosBL = Nothing
        impuestoBE = Nothing

    End Sub

    Private Sub Cargar_Series_Doc()

        Dim seriesBL As New BL.LogisticaBL.SG_LO_TB_ALMACEN_SERIE
        Dim seriesBE As New BE.LogisticaBE.SG_LO_TB_ALMACEN_SERIE

        seriesBE.AS_IDEMPRESA = gInt_IdEmpresa
        seriesBE.AS_TDOC = uce_TipoDoc.Value

        uce_SerieTrans.DataSource = seriesBL.SEL05(seriesBE)
        uce_SerieTrans.DisplayMember = "AS_SERIE"
        uce_SerieTrans.ValueMember = "AS_SERIE"

        seriesBE = Nothing
        seriesBL = Nothing

        If uce_SerieTrans.Items.Count > 0 Then uce_SerieTrans.SelectedIndex = 0

    End Sub

    Private Sub Obtener_Ult_Num_Compro()

        Dim numeracionBL As New BL.LogisticaBL.SG_LO_TB_NUM_COMPRO
        Dim numeracionBE As New BE.LogisticaBE.SG_LO_TB_NUM_COMPRO

        numeracionBE.NC_IDTIPO = uce_TipoDocTrans.Value
        numeracionBE.NC_IDEMPRESA = gInt_IdEmpresa
        numeracionBE.NC_SERIE = uce_SerieTrans.Value

        txt_NumDocTrans.Text = numeracionBL.SEL02(numeracionBE)

        numeracionBE = Nothing
        numeracionBL = Nothing
    End Sub
    'Private Sub Validar_existe_num_comprobante(ByRef existe As Boolean)

    '    Dim comproBL As New BL.LogisticaBL.SG_LO_TB_MOVIMIENTOS_C
    '    Dim comproBE As New BE.LogisticaBE.SG_LO_TB_MOVIMIENTOS_C

    '    comproBE.MO_TDOC = uce_TipoDocTrans.Value
    '    comproBE.MO_SDOC = uce_SerieTrans.Value
    '    comproBE.MO_NDOC = txt_NumDocTrans.Text
    '    comproBE.MO_IDEMPRESA = gInt_IdEmpresa

    '    If comproBL.SEL02(comproBE) Then
    '        Call Avisar("El numero de comprobante " & uce_TipoDocTrans.Text & "-" & uce_SerieTrans.Value & "-" & txt_NumDocTrans.Text & " ya esta registrado,! Cuidado")
    '        existe = True
    '    End If

    '    comproBE = Nothing
    '    comproBL = Nothing
    'End Sub


    Private Sub LO_LT_Consumo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Cargar_Combos()
        Call CargarCombo_ConMeses(uce_Mes)
        Inicializa()
        uce_Mes.Value = Now.Month
        txt_año.Text = Now.Year

        Call Inicializar_Estado_Botones_Tool(ToolS_Mantenimiento)
        Call MostrarTabs(0, utc_Datos, 0)

        'txt_ruc_cliente.ButtonsRight(0).Appearance.Image = My.Resources._104
        'txt_IdCuenta.ButtonsRight(0).Appearance.Image = My.Resources._104

        obe = New BE.LogisticaBE.SG_LO_TB_CONSUMO_C
        obr = New BL.LogisticaBL.SG_LO_TB_CONSUMO_C
        obeM = New BE.LogisticaBE.SG_LO_TB_MOVIMIENTOS_C
        obrM = New BL.LogisticaBL.SG_LO_TB_MOVIMIENTOS_C
        'obeT = New BE.LogisticaBE.SG_LO_TB_CONSUMO_D

        Me.KeyPreview = True

        Call Formatear_Grilla_Selector(ug_Lista)
        obe.CM_IDEMPRESA = gInt_IdEmpresa

        ug_Lista.DataSource = obr.SEL04(obe, uce_Mes.Value, Val(txt_año.Text))
        Cargar_Tasas_Impuestos()

        ug_detalle.DisplayLayout.ValueLists.Clear()
        ug_detalle.DisplayLayout.ValueLists.Add("DC_SEG_CUBRE")
        ug_detalle.DisplayLayout.ValueLists("DC_SEG_CUBRE").ValueListItems.Clear()
        ug_detalle.DisplayLayout.ValueLists("DC_SEG_CUBRE").ValueListItems.Add("0", "No Cubre")
        ug_detalle.DisplayLayout.ValueLists("DC_SEG_CUBRE").ValueListItems.Add("1", "Cubre")
        ug_detalle.DisplayLayout.ValueLists("DC_SEG_CUBRE").ValueListItems.Add("2", "Adicional")
        ug_detalle.DisplayLayout.Bands(0).Columns("DC_SEG_CUBRE").Style = Infragistics.Win.UltraWinGrid.ColumnStyle.DropDownList
        ug_detalle.DisplayLayout.Bands(0).Columns("DC_SEG_CUBRE").ValueList = ug_detalle.DisplayLayout.ValueLists("DC_SEG_CUBRE")

        'Dim ComunicacionBL As New BL.FacturacionBL.SG_FA_TB_TIPO_COMUNICACION
        'Call CrearComboGrid("CODIGO", "TC_DESCRIPCION", ug_Comunicacio, ComunicacionBL.getTipos(gInt_IdEmpresa), True)
        'ComunicacionBL = Nothing
        'Call MostrarTabs(1, utc_Datos, 1)

        Timer1.Enabled = True
        Timer1.Interval = 60000
        Tool_Imprimir.Enabled = False
        ugb_Datos.Enabled = True
    End Sub

    Private Sub ubt_Agregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ubt_Agregar.Click
        LO_LT_ListaMedicamInsumos.IGVTas = IGVTasa
        LO_LT_ListaMedicamInsumos.TipoAten = 2
        LO_LT_ListaMedicamInsumos.idSeguro = txtIDSeguro.Text
        LO_LT_ListaMedicamInsumos.idalmacen = uce_Almacen.Value
        LO_LT_ListaMedicamInsumos.ShowDialog()

        Dim matriz As List(Of BE.LogisticaBE.SG_LO_TB_ARTICULO) = LO_LT_ListaMedicamInsumos.GetLista
        Dim aa As Integer = 0
        For Each articulo As BE.LogisticaBE.SG_LO_TB_ARTICULO In matriz
            'DC_ITEM()
            'DC_IDARTICULO()
            'AR_DESCRIPCION()
            'UM_Des()
            'DC_PRECIO()
            'DC_CANT()
            'DC_IDLOTE()
            'DC_TOTAL()
            'DC_SEG_CUBRE()
            'DC_Trans()

            'articuloBE.AR_ID = ug_data.ActiveRow.Cells("AR_ID").Value
            'articuloBE.AR_DESCRIPCION = ug_data.ActiveRow.Cells("AR_DESCRIPCION").Value
            'articuloBE.DS_IDLOTE = ug_data.ActiveRow.Cells("DS_IDLOTE").Value
            'articuloBE.UM_DesV = ug_data.ActiveRow.Cells("UM_DESCRIPCION").Value
            'articuloBE.AR_PRECIO_VENTA = ug_data.ActiveRow.Cells("AR_PRECIO_VENTA").Value
            'articuloBE.AR_INCLUYE_IGV = ug_data.ActiveRow.Cells("AR_INCLUYE_IGV").Value
            'articuloBE.DS_SALDO = ug_data.ActiveRow.Cells("DS_SALDO").Value
            'articuloBE.AR_SIN_IGV()
           
            If articulo.DS_SALDO > 0 Then
                ug_detalle.DisplayLayout.Bands(0).AddNew()
                ug_detalle.Rows(ug_detalle.Rows.Count - 1).Cells(0).Value = ug_detalle.Rows.Count
                ug_detalle.Rows(ug_detalle.Rows.Count - 1).Cells("DC_IDARTICULO").Value = articulo.AR_ID  'codigo id
                ug_detalle.Rows(ug_detalle.Rows.Count - 1).Cells(2).Value = articulo.AR_DESCRIPCION 'codigo
                ug_detalle.Rows(ug_detalle.Rows.Count - 1).Cells(3).Value = articulo.DS_IDLOTE
                ug_detalle.Rows(ug_detalle.Rows.Count - 1).Cells(4).Value = articulo.UM_DesV  'descripcion
                ug_detalle.Rows(ug_detalle.Rows.Count - 1).Cells(5).Value = articulo.AR_PRECIO_VENTA
                ug_detalle.Rows(ug_detalle.Rows.Count - 1).Cells(6).Value = 1
                ug_detalle.Rows(ug_detalle.Rows.Count - 1).Cells(7).Value = articulo.AR_PRECIO_VENTA
                ug_detalle.Rows(ug_detalle.Rows.Count - 1).Cells("DC_SEG_CUBRE").Value = IIf(txtIDSeguro.Text <> "000", 1, 0)
                ug_detalle.Rows(ug_detalle.Rows.Count - 1).Cells("DC_Trans").Value = 1
                ug_detalle.Rows(ug_detalle.Rows.Count - 1).Cells("DS_SALDO").Value = articulo.DS_SALDO
            Else
                aa = aa + 1
            End If

        Next
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

    Private Sub ug_detalle_ClickCell(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinGrid.ClickCellEventArgs) Handles ug_detalle.ClickCell
        If e.Cell.Column.Index = 9 Then
            If ug_detalle.ActiveRow.Cells(6).Value > ug_detalle.ActiveRow.Cells(10).Value Then
                Avisar("Stock no suficiente")
                e.Cell.CancelUpdate()
            End If
        End If
    End Sub

    Private Sub ug_Detalle_AfterRowUpdate(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinGrid.RowEventArgs) Handles ug_detalle.AfterRowUpdate
        'e.Row.Cells("Total").Value = e.Row.Cells("Precio").Value * e.Row.Cells("Cant").Value
        Dim subtotal_cal As Decimal = "0.00"
        subtotal_cal = Math.Round((e.Row.Cells(5).Value * e.Row.Cells(6).Value), 2)
        e.Row.Cells(7).Value = subtotal_cal
    End Sub
    Private Sub ug_Detalle_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles ug_detalle.KeyDown
        'If e.KeyCode = Keys.Enter Then
        '    ug_detalle.PerformAction(UltraGridAction.NextCellByTab, False, False)
        '    ug_detalle.UpdateData()
        'End If
    End Sub
    Private Sub ug_Detalle_BeforeRowsDeleted(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.BeforeRowsDeletedEventArgs) Handles ug_detalle.BeforeRowsDeleted
        e.DisplayPromptMsg = False
        e.Cancel = False

    End Sub

    Private Sub Validar_existe_num_comprobante(ByRef existe As Boolean)

        Dim comproBL As New BL.LogisticaBL.SG_LO_TB_MOVIMIENTOS_C
        Dim comproBE As New BE.LogisticaBE.SG_LO_TB_MOVIMIENTOS_C

        comproBE.MO_TDOC = uce_TipoDocTrans.Value
        comproBE.MO_SDOC = uce_SerieTrans.Value
        comproBE.MO_NDOC = txt_NumDocTrans.Text
        comproBE.MO_IDEMPRESA = gInt_IdEmpresa

        If comproBL.Existe_cORRETATIVO(comproBE) Then
            Call Avisar("El numero de comprobante " & uce_TipoDocTrans.Text & "-" & uce_SerieTrans.Value & "-" & txt_NumDocTrans.Text & " ya esta registrado,! Cuidado")
            existe = True
        End If

        comproBE = Nothing
        comproBL = Nothing

    End Sub

    '---menu
    Private Sub Tool_Grabar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_Grabar.Click
        If fValida() = False Then Exit Sub
        If uchk_Transferencia.Checked = True And Val(utxt_IdTransferencia.Text) = 0 Then
            Dim rpta_existe As Boolean = False
            Call Validar_existe_num_comprobante(rpta_existe)

            If rpta_existe Then
                Avisar("No se puede continuar! Numero de guia existe")
                Exit Sub
            End If
        End If

        With obeM
            .MO_TDOC = uce_TipoDocTrans.Value
            .MO_SDOC = uce_SerieTrans.Value
            .MO_NDOC = txt_NumDocTrans.Text
            .MO_FECHA = udtFechaTrans.Value
            .MO_IDALMACEN_ORI = utxt_IdAlmacenC.Text
            .MO_IDALMACEN_DES = uce_Almacen.Value
            .MO_IDMOTIVO = 8
            .MO_IDCONSUMO = Val(txt_idConsumo.Text)
            .MO_IDEMPRESA = gInt_IdEmpresa
            .MO_ID = Val(utxt_IdTransferencia.Text)
            .MO_IDAREA = ""
            .MO_NOTA = "Paciente: " & txt_Des_Cliente.Text & "  Historia: " & txt_idHistoria.Text
        End With

        'Dim detalleBE As BE.LogisticaBE.SG_LO_TB_COMPROBANTES_DET
        Dim obeTc As BE.LogisticaBE.SG_LO_TB_CONSUMO_D
        Dim obeTM As BE.LogisticaBE.SG_LO_TB_MOVIMIENTOS_D
        Dim ls_detalles As New List(Of BE.LogisticaBE.SG_LO_TB_CONSUMO_D)
        Dim ls_detallesM As New List(Of BE.LogisticaBE.SG_LO_TB_MOVIMIENTOS_D)
        ug_detalle.UpdateData()

        For i As Integer = 0 To ug_detalle.Rows.Count - 1
            obeTc = New BE.LogisticaBE.SG_LO_TB_CONSUMO_D
            obeTM = New BE.LogisticaBE.SG_LO_TB_MOVIMIENTOS_D
            With obeTc
                If ug_detalle.Rows(i).Cells(9).Value = True Then
                    obeTM.MO_IDARTICULO = ug_detalle.Rows(i).Cells("DC_IDARTICULO").Value
                    obeTM.MO_IDLOTE = ug_detalle.Rows(i).Cells("DC_IDLOTE").Value
                    obeTM.MO_CANTIDAD = ug_detalle.Rows(i).Cells("DC_CANT").Value
                    ls_detallesM.Add(obeTM)
                End If
                .DC_ITEM = i + 1
                .DC_IDARTICULO = ug_detalle.Rows(i).Cells("DC_IDARTICULO").Value
                .DC_IDLOTE = ug_detalle.Rows(i).Cells("DC_IDLOTE").Value
                .DC_CANT = ug_detalle.Rows(i).Cells("DC_CANT").Value
                .DC_PRECIO = ug_detalle.Rows(i).Cells("DC_PRECIO").Value
                .DC_TOTAL = ug_detalle.Rows(i).Cells(7).Value
                .DC_SEG_CUBRE = ug_detalle.Rows(i).Cells("DC_SEG_CUBRE").Value 'IIf(ug_detalle.Rows(i).Cells("DC_SEG_CUBRE").Value = True, 1, 0)
            End With
            ls_detalles.Add(obeTc)
        Next
        If Val(utxt_IdTransferencia.Text) > 0 Then
            Tool_Imprimir.Enabled = True
            If obrM.Update_porConsumo(obeM, String.Format("{0}-{1}", Environment.UserName, gStr_Usuario_Sis), Environment.MachineName, ls_detallesM, ls_detalles, IIf(txt_Ref_Transferencia.Text = "", 1, 0)) < 0 Then
                MessageBox.Show("La operación solicitada no ha podido ser realizada", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If
        Else
            If uchk_Transferencia.Checked = True Then
                Tool_Imprimir.Enabled = True
                Dim i As Integer = 0
                i = obrM.Insert_porConsumo(obeM, String.Format("{0}-{1}", Environment.UserName, gStr_Usuario_Sis), Environment.MachineName, ls_detallesM, ls_detalles)
                utxt_IdTransferencia.Text = i
                If i < 0 Then
                    MessageBox.Show("La operación solicitada no ha podido ser realizada", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Exit Sub
                End If
            Else
                Tool_Imprimir.Enabled = False
                If obrM.Update_Consumo(obeM, String.Format("{0}-{1}", Environment.UserName, gStr_Usuario_Sis), Environment.MachineName, ls_detallesM, ls_detalles) < 0 Then
                    MessageBox.Show("La operación solicitada no ha podido ser realizada", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Exit Sub
                End If
            End If
        End If

        Call Avisar("Listo!")

        obe.CM_IDEMPRESA = gInt_IdEmpresa
        ug_Lista.DataSource = obr.SEL04(obe, uce_Mes.Value, Val(txt_año.Text))
        ugb_Datos.Enabled = False
        Tool_Editar.Enabled = False
        Tool_Cancelar.Enabled = True
        Tool_Grabar.Enabled = False
        'Tool_Eliminar.Enabled = False
        Tool_Salir.Enabled = True

        ' Call Cambiar_Estado_Botones_Tool(ToolS_Mantenimiento)
        ' Call MostrarTabs(0, utc_Datos, 0)
        '  Call Tool_Nuevo_Click(sender, e)

    End Sub

    Private Sub Tool_Salir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_Salir.Click
        Me.Close()
    End Sub

    Private Sub Tool_Cancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_Cancelar.Click
        Tool_Editar.Enabled = True
        Tool_Cancelar.Enabled = False
        Tool_Grabar.Enabled = False
        '   Tool_Eliminar.Enabled = True
        Tool_Salir.Enabled = True

        'Call Cambiar_Estado_Botones_Tool(ToolS_Mantenimiento)
        Call MostrarTabs(0, utc_Datos, 0)
        Tool_Imprimir.Enabled = False
        ugb_Datos.Enabled = True
    End Sub

    Private Sub Tool_Editar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_Editar.Click
        If ug_Lista.Rows.Count = 0 Then Exit Sub
        If ug_Lista.ActiveRow Is Nothing Then Exit Sub
        If ug_Lista.ActiveRow.IsFilterRow Then Exit Sub

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
        uce_Almacen.Value = ug_Lista.ActiveRow.Cells(5).Value

        uce_TipoDoc.Value = ug_Lista.ActiveRow.Cells(2).Value
        uce_Serie.Text = ug_Lista.ActiveRow.Cells(3).Value
        txt_NumDoc.Text = ug_Lista.ActiveRow.Cells(4).Value
        txt_IdCuenta.Text = ug_Lista.ActiveRow.Cells(6).Value

        ucbo_Estado.Value = ug_Lista.ActiveRow.Cells(13).Value

        If ug_Lista.ActiveRow.Cells(13).Value = "2" Then
            'Tool_Grabar.Enabled = False
            'transferencia
            Tool_Imprimir.Enabled = True
            Dim drr_MOV As System.Data.SqlClient.SqlDataReader
            drr_MOV = obrM.SEL04(Val(txt_idConsumo.Text))
            If drr_MOV.HasRows Then
                drr_MOV.Read()

                Avisar("El Consumo ya fue transferido")

                uchk_Transferencia.Enabled = False
                ubnt_Transferencias.Enabled = False
                
                If ug_Lista.ActiveRow.Cells(14).Value = 0 Then
                    uchk_Transferencia.Checked = True
                    uce_TipoDocTrans.Value = drr_MOV("MO_TDOC")
                    uce_SerieTrans.Value = drr_MOV("MO_SDOC")
                    txt_NumDocTrans.Text = drr_MOV("MO_NDOC")
                    txt_Ref_Transferencia.Text = ""
                Else
                    uchk_Transferencia.Checked = False
                    txt_Ref_Transferencia.Text = drr_MOV("MO_TDOC") & ": " & drr_MOV("MO_SDOC") & "-" & drr_MOV("MO_NDOC")
                End If
                uce_SerieTrans.ReadOnly = True
                uce_TipoDocTrans.ReadOnly = True
                udtFechaTrans.Value = drr_MOV("MO_FECHA").ToString
                utxt_IdTransferencia.Text = drr_MOV("MO_ID")
                utxt_IdAlmacenC.Text = drr_MOV("MO_IDALMACEN_ORI")
            End If
            drr_MOV.Close()
        ElseIf ug_Lista.ActiveRow.Cells(13).Value = "3" Then
            'facturado

            Dim drr_MOV As System.Data.SqlClient.SqlDataReader
            drr_MOV = obrM.SEL04(Val(txt_idConsumo.Text))
            If drr_MOV.HasRows Then
                drr_MOV.Read()
                ubnt_Transferencias.Enabled = False
                uchk_Transferencia.Enabled = False
               
                If ug_Lista.ActiveRow.Cells(14).Value = 0 Then
                    uchk_Transferencia.Checked = True
                    uce_TipoDocTrans.Value = drr_MOV("MO_TDOC")
                    uce_SerieTrans.Value = drr_MOV("MO_SDOC")
                    txt_NumDocTrans.Text = drr_MOV("MO_NDOC")
                    txt_Ref_Transferencia.Text = ""
                Else
                    uchk_Transferencia.Checked = False
                    txt_Ref_Transferencia.Text = drr_MOV("MO_TDOC") & ": " & drr_MOV("MO_SDOC") & "-" & drr_MOV("MO_NDOC")
                End If

                uce_SerieTrans.ReadOnly = True
                uce_TipoDocTrans.ReadOnly = True
                udtFechaTrans.Value = drr_MOV("MO_FECHA").ToString
                utxt_IdTransferencia.Text = drr_MOV("MO_ID")
                utxt_IdAlmacenC.Text = drr_MOV("MO_IDALMACEN_ORI")
                Avisar("El Consumo ya fue transferido")
                Tool_Imprimir.Enabled = True
            Else
                'falta trasferencia
                Dim ALMBL As New BL.LogisticaBL.SG_LO_TB_ALMACEN
                Dim drr_AlM As System.Data.SqlClient.SqlDataReader
                drr_AlM = ALMBL.get_almacen_4(gInt_IdEmpresa)
                If drr_AlM.HasRows Then
                    drr_AlM.Read()
                    utxt_IdAlmacenC.Text = drr_AlM("AL_ID")
                End If
                drr_AlM.Close()
                txt_Ref_Transferencia.Text = ""

                uchk_Transferencia.Checked = False
                uce_TipoDocTrans.SelectedIndex = -1
                uce_SerieTrans.SelectedIndex = -1
                txt_NumDocTrans.Text = ""
                udtFechaTrans.Value = Now
                utxt_IdTransferencia.Text = 0
                'Tool_Grabar.Enabled = True
                uchk_Transferencia.Enabled = True
                ubnt_Transferencias.Enabled = True
                uce_SerieTrans.ReadOnly = False
                uce_TipoDocTrans.ReadOnly = False
                Tool_Imprimir.Enabled = False

            End If

            drr_MOV.Close()
        Else
            Dim ALMBL As New BL.LogisticaBL.SG_LO_TB_ALMACEN
            Dim drr_AlM As System.Data.SqlClient.SqlDataReader
            drr_AlM = ALMBL.get_almacen_4(gInt_IdEmpresa)
            If drr_AlM.HasRows Then
                drr_AlM.Read()
                utxt_IdAlmacenC.Text = drr_AlM("AL_ID")
            End If
            drr_AlM.Close()
            txt_Ref_Transferencia.Text = ""

            uchk_Transferencia.Checked = False
            uce_TipoDocTrans.SelectedIndex = -1
            uce_SerieTrans.SelectedIndex = -1
            txt_NumDocTrans.Text = ""
            udtFechaTrans.Value = Now
            utxt_IdTransferencia.Text = 0
            'Tool_Grabar.Enabled = True
            uchk_Transferencia.Enabled = True
            ubnt_Transferencias.Enabled = True
            uce_SerieTrans.ReadOnly = False
            uce_TipoDocTrans.ReadOnly = False

            Tool_Imprimir.Enabled = False
        End If

        Dim obrT As New BL.AdmisionBL.SG_AD_TB_CUENTA_CAB
        Dim obeC As New BE.AdmisionBE.SG_AD_TB_CUENTA_CAB
        obeC.CC_ID = Val(txt_IdCuenta.Text)
        Format(Val(txt_IdCuenta.Text), "0000000000#")
        obeC.HasRow = False
        obrT.SEL04(obeC)
        If obeC.HasRow Then
            txtIDSeguro.Text = IIf(obeC.CC_IDTIPO_ATENC = 1, "000", obeC.CC_IDSEGURO)
            uchk_SeguroEps.Checked = IIf(obeC.CC_IDTIPO_ATENC = 1, False, True)
            ucm_SeguroEps.Value = obeC.CC_IDSEGURO
        End If

        Dim obeT As New BE.LogisticaBE.SG_LO_TB_CONSUMO_D
        obeT.DC_IDCONSUMO = Val(txt_idConsumo.Text)
        ug_detalle.DataSource = obr.SEL03(obeT, 2, gInt_IdEmpresa)

        ug_detalle.UpdateData()

        Call MostrarTabs(1, utc_Datos, 1)

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
        uce_tip_doc.Focus()
        ugb_Datos.Enabled = True
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

    '--------
    Private Sub uchk_Transferencia_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles uchk_Transferencia.CheckedChanged
        Dim seriesBL As New BL.LogisticaBL.SG_LO_TB_ALMACEN_SERIE
        Dim seriesBE As New BE.LogisticaBE.SG_LO_TB_ALMACEN_SERIE

        seriesBE.AS_IDEMPRESA = gInt_IdEmpresa
        uce_TipoDocTrans.DataSource = seriesBL.SEL04(seriesBE)
        uce_TipoDocTrans.DisplayMember = "TD_DESCRIPCION"
        uce_TipoDocTrans.Value = "AS_TDOC"

        seriesBL = Nothing
        seriesBE = Nothing
        udtFechaTrans.Value = Now
        If uce_TipoDocTrans.Items.Count > 0 Then uce_TipoDocTrans.SelectedIndex = 0

        If uchk_Transferencia.Checked = True Then
            utxt_IdTransferencia.Text = ""
            txt_Ref_Transferencia.Text = ""
        Else
            uce_TipoDocTrans.SelectedIndex = -1
            uce_SerieTrans.SelectedIndex = -1
            txt_NumDocTrans.Text = ""
        End If
    End Sub

    Private Sub uce_SerieTrans_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles uce_SerieTrans.ValueChanged
        Call Obtener_Ult_Num_Compro()
    End Sub

    Private Sub uce_TipoDocTrans_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles uce_TipoDocTrans.ValueChanged
        Call Cargar_Series_Doc()
        Call Obtener_Ult_Num_Compro()
    End Sub

    Private Sub uce_Almacen_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles uce_Almacen.ValueChanged

        Dim seriesBL As New BL.LogisticaBL.SG_LO_TB_ALMACEN_SERIE
        Dim seriesBE As New BE.LogisticaBE.SG_LO_TB_ALMACEN_SERIE

        seriesBE.AS_IDEMPRESA = gInt_IdEmpresa
        seriesBE.AS_IDALMACEN = uce_Almacen.Value
        uce_TipoDoc.DataSource = seriesBL.SEL02(seriesBE)
        uce_TipoDoc.DisplayMember = "TD_DESCRIPCION"
        uce_TipoDoc.Value = "AS_TDOC"

        seriesBL = Nothing
        seriesBE = Nothing

        If uce_TipoDoc.Items.Count > 0 Then uce_TipoDoc.SelectedIndex = 0

        Call LimpiaGrid(ug_detalle, uds_detalle)
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        obe.CM_IDEMPRESA = gInt_IdEmpresa
        ug_Lista.DataSource = obr.SEL04(obe, uce_Mes.Value, Val(txt_año.Text))
    End Sub

    Private Sub Tool_Imprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_Imprimir.Click
        If Val(utxt_IdTransferencia.Text) = 0 Or txt_NumDocTrans.Text = "" Then Exit Sub

        Dim dt_comprobante As New DataTable

        'Dim obj As New DataTable
        dt_comprobante = obrM.SEL05(Val(utxt_IdTransferencia.Text))
        'ug_detalle.DataSource = dt_comprobante

        Try
            Me.Cursor = Cursors.WaitCursor

            If dt_comprobante.Rows.Count > 0 Then
                Dim crystalBL As New LR.ClsReporte

                crystalBL.Muestra_Reporte(gStr_RutaRep & "\SG_LO_04.RPT", dt_comprobante, "", "ptdoc;" & uce_TipoDocTrans.Text, "pserie;" & uce_SerieTrans.Text, "pnumero;" & txt_NumDocTrans.Text, "pPaciente; Paciente: " & txt_Des_Cliente.Text & "   Historia: " & txt_idHistoria.Text, "pAlmacenOri;" & "Farmacia", "pAlmacenDes;" & uce_Almacen.Text, "pMotivo;" & "TRANSFERENCIA ENTRE ALMACENES")

                crystalBL = Nothing
            End If

            Me.Cursor = Cursors.Default

        Catch ex As Exception
            Throw ex
            Me.Cursor = Cursors.Default
        End Try

    End Sub

    Private Sub ubnt_Transferencias_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ubnt_Transferencias.Click
        If uchk_Transferencia.Checked = True Then
            Avisar("No puede agregar una transferencia si va a grabar uno nuevo")
            Exit Sub
        End If
        LO_LT_ListaTransferencia.IDALMACEN_DES = uce_Almacen.Value
        LO_LT_ListaTransferencia.IDALMACEN_ORI = utxt_IdAlmacenC.Text
        LO_LT_ListaTransferencia.ShowDialog()

        Dim matriz As List(Of BE.LogisticaBE.SG_LO_TB_MOVIMIENTOS_C) = LO_LT_ListaTransferencia.GetLista

        For Each MOV As BE.LogisticaBE.SG_LO_TB_MOVIMIENTOS_C In matriz
            utxt_IdTransferencia.Text = MOV.MO_ID
            txt_Ref_Transferencia.Text = MOV.MO_TDOC & ": " & MOV.MO_SDOC & "-" & MOV.MO_NDOC
        Next

        ug_detalle.UpdateData()
        ug_detalle.Refresh()
        ' Call Calcular_Totales()
    End Sub

    Private Sub uce_Mes_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles uce_Mes.LostFocus
        ug_Lista.DataSource = obr.SEL04(obe, uce_Mes.Value, Val(txt_año.Text))
    End Sub

    Private Sub txt_año_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_año.LostFocus
        ug_Lista.DataSource = obr.SEL04(obe, uce_Mes.Value, Val(txt_año.Text))
    End Sub
End Class