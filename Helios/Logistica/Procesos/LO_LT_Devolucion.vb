Imports Infragistics.Win.UltraWinGrid
Public Class LO_LT_Devolucion
    Private obe As BE.LogisticaBE.SG_LO_TB_MOVIMIENTOS_C
    Private obr As BL.LogisticaBL.SG_LO_TB_MOVIMIENTOS_C
    ' Private obeT As BE.LogisticaBE.SG_LO_TB_MOVIMIENTOS_D

    Public lNew As Boolean = False
    Public OPCION As Integer
    Dim IGVTasa As Double
    'Dim arrayMotipoTIpo() As String
    Public Sub New()
        InitializeComponent()
        obe = New BE.LogisticaBE.SG_LO_TB_MOVIMIENTOS_C
        obr = New BL.LogisticaBL.SG_LO_TB_MOVIMIENTOS_C
        ' obeT = New BE.LogisticaBE.SG_LO_TB_MOVIMIENTOS_D
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
        pLostfocus(uce_Almacen, Nothing)
        pLostfocus(ucbo_Motivo, Nothing)

        If uce_Almacen.BackColor = Color.LightPink Then GoTo Err_Valida
        If ucbo_Motivo.BackColor = Color.LightPink Then GoTo Err_Valida

        Return True
        Exit Function
Err_Valida:
        MessageBox.Show("Corrija ó Complete los campos errados !!", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Return False
    End Function

    Private Sub Inicializa()
        Call LimpiaGrid(ug_detalle, uds_detalle)
        Call Limpiar_Controls_InGroupox(ugb_Datos)
        uce_Almacen.BackColor = Color.White
        ucbo_Motivo.BackColor = Color.White
        ucbo_Estado.Value = 1

        uce_TipoDoc.SelectedIndex = 0
        udte_fecha.Value = Now

        uce_Almacen.ReadOnly = False
        ucbo_Motivo.ReadOnly = False
        uce_TipoDoc.ReadOnly = False
        uce_Serie.ReadOnly = False

        ucbo_AlmacenDest.Value = "001"
        uce_Almacen.SelectedIndex = 0
        ucbo_Motivo.SelectedIndex = 0
    End Sub
    Private Sub CargarLista()
        obe.MO_IDEMPRESA = 7
        ug_Lista.DataSource = obr.SEL08(obe, uce_Mes.Value, Val(txt_año.Text), gInt_IdUsuario_Sis)
    End Sub
    Private Sub Cargar_Combos()
        '--almacenes
        Dim AlcBL As New BL.LogisticaBL.SG_LO_TB_ALMACEN
        uce_Almacen.DataSource = AlcBL.get_almacen_2(7, gInt_IdUsuario_Sis)
        uce_Almacen.DisplayMember = "AL_DESCRIPCION"
        uce_Almacen.ValueMember = "AL_ID"

        ucbo_AlmacenDest.DataSource = AlcBL.get_almacen_3(7)
        ucbo_AlmacenDest.DisplayMember = "AL_DESCRIPCION"
        ucbo_AlmacenDest.ValueMember = "AL_ID"
        AlcBL = Nothing


        Dim motivBL As New BL.LogisticaBL.SG_LO_TB_MOTIVO
        Dim obeM As New BE.LogisticaBE.SG_LO_TB_MOTIVO
        obeM.MT_IDEMPRESA = 7
        ucbo_Motivo.DataSource = motivBL.SEL04(obeM)
        ucbo_Motivo.DisplayMember = "MT_NOMBRE"
        ucbo_Motivo.ValueMember = "MT_ID"
        motivBL = Nothing

        Dim seriesBL As New BL.LogisticaBL.SG_LO_TB_ALMACEN_SERIE
        Dim seriesBE As New BE.LogisticaBE.SG_LO_TB_ALMACEN_SERIE

        'seriesBE.AS_IDEMPRESA = 7
        'uce_TipoDoc.DataSource = seriesBL.SEL04(seriesBE)
        'uce_TipoDoc.DisplayMember = "TD_DESCRIPCION"
        'uce_TipoDoc.Value = "AS_TDOC"
        'seriesBL = Nothing
        'seriesBE = Nothing

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

    Private Sub LO_LT_Devolucion_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Cargar_Combos()
        Call CargarCombo_ConMeses(uce_Mes)
        Inicializa()
        uce_Mes.Value = Now.Month
        txt_año.Text = Now.Year

        Call Inicializar_Estado_Botones_Tool(ToolS_Mantenimiento)
        Call MostrarTabs(0, utc_Datos, 0)

        obe = New BE.LogisticaBE.SG_LO_TB_MOVIMIENTOS_C
        obr = New BL.LogisticaBL.SG_LO_TB_MOVIMIENTOS_C
        ' obeT = New BE.LogisticaBE.SG_LO_TB_MOVIMIENTOS_D

        Me.KeyPreview = True

        Call Formatear_Grilla_Selector(ug_Lista)
        CargarLista()
        Tool_Imprimir.Enabled = False
        Cargar_Tasas_Impuestos()
    End Sub

    '----DETALLE
    Private Sub ubt_Agregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ubt_Agregar.Click

        LO_LT_ListaMedicamInsumos.IGVTas = IGVTasa
        LO_LT_ListaMedicamInsumos.TipoAten = 4
      
        LO_LT_ListaMedicamInsumos.idSeguro = "000"
        LO_LT_ListaMedicamInsumos.idalmacen = uce_Almacen.Value
        LO_LT_ListaMedicamInsumos.ShowDialog()

        Dim matriz As List(Of BE.LogisticaBE.SG_LO_TB_ARTICULO) = LO_LT_ListaMedicamInsumos.GetLista
        Dim aa As Integer = 0
        For Each articulo As BE.LogisticaBE.SG_LO_TB_ARTICULO In matriz
            ug_detalle.DisplayLayout.Bands(0).AddNew()
            ug_detalle.Rows(ug_detalle.Rows.Count - 1).Cells("MO_IDARTICULO").Value = articulo.AR_ID
            ug_detalle.Rows(ug_detalle.Rows.Count - 1).Cells("AR_DESCRIPCION").Value = articulo.AR_DESCRIPCION
            ug_detalle.Rows(ug_detalle.Rows.Count - 1).Cells("UM_DESCRIPCION").Value = articulo.UM_DesV
            ug_detalle.Rows(ug_detalle.Rows.Count - 1).Cells("MO_IDLOTE").Value = articulo.DS_IDLOTE
            ug_detalle.Rows(ug_detalle.Rows.Count - 1).Cells("MO_CANTIDAD").Value = 1
            ug_detalle.Rows(ug_detalle.Rows.Count - 1).Cells("DS_SALDO").Value = articulo.DS_SALDO
        Next

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
        ' Dim arrayMotipoTIpo() As String
        'arrayMotipoTIpo = Strings.Split(ucbo_Motivo.Value, "-")
        ' If arrayMotipoTIpo(1) <> 1 Then
        If e.Row.Cells(4).Value > e.Row.Cells(5).Value Then
            Avisar("Stock no suficiente")
            e.Cancel = True
            ' e.Handle = True
            'End If
        End If
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
        comproBE.MO_IDEMPRESA = 7

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
        If lNew Then
            Dim rpta_existe As Boolean = False
            Call Validar_existe_num_comprobante(rpta_existe)

            If rpta_existe Then
                Avisar("No se puede continuar! Numero de guia existe")
                Exit Sub
            End If
        End If
        If ug_detalle.Rows.Count = 0 Then
            Avisar("Falta agregar Items")
            Exit Sub
        End If
        With obe
            .MO_TDOC = uce_TipoDoc.Value
            .MO_SDOC = uce_Serie.Value
            .MO_NDOC = txt_NumDoc.Text
            .MO_FECHA = udte_fecha.Value
            .MO_IDALMACEN_ORI = uce_Almacen.Value
            .MO_IDAREA = ""
            .MO_IDALMACEN_DES = ucbo_AlmacenDest.Value
            .MO_NOTA = txt_Notas.Text
            .MO_IDMOTIVO = ucbo_Motivo.Value
            .MO_IDCONSUMO = 0
            .MO_IDEMPRESA = 7
        End With

        Dim ls_detalles As New List(Of BE.LogisticaBE.SG_LO_TB_MOVIMIENTOS_D)

        ug_detalle.UpdateData()
        Dim obeTc As BE.LogisticaBE.SG_LO_TB_MOVIMIENTOS_D

        For i As Integer = 0 To ug_detalle.Rows.Count - 1
            obeTc = New BE.LogisticaBE.SG_LO_TB_MOVIMIENTOS_D
            With obeTc
                .MO_IDARTICULO = ug_detalle.Rows(i).Cells("MO_IDARTICULO").Value
                .MO_IDLOTE = ug_detalle.Rows(i).Cells("MO_IDLOTE").Value
                .MO_CANTIDAD = ug_detalle.Rows(i).Cells("MO_CANTIDAD").Value
            End With
            ls_detalles.Add(obeTc)
        Next

        If lNew Then
            Dim I As Integer = obr.Insert(obe, String.Format("{0}-{1}", Environment.UserName, gStr_Usuario_Sis), Environment.MachineName, ls_detalles)
            utxt_IdMovimiento.Text = I
            If I < 0 Then
                MessageBox.Show("La operación solicitada no ha podido ser realizada", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If
        Else
            obe.MO_ID = Val(utxt_IdMovimiento.Text)
            Dim I As Integer = obr.Update(obe, String.Format("{0}-{1}", Environment.UserName, gStr_Usuario_Sis), Environment.MachineName, ls_detalles)
            If I = -2 Then
                MessageBox.Show("No Se puede modificar un movimiento del inventario ya cerrado, Registrar otro Documento", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Exit Sub
            End If
            If I = -1 Then
                MessageBox.Show("La operación solicitada no ha podido ser realizada", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If
        End If
        Call Avisar("Listo!")
        Tool_Imprimir.Enabled = True
       CargarLista()
        'Inicializa()
        Call Cambiar_Estado_Botones_Tool(ToolS_Mantenimiento)
        'Call Tool_Cancelar_Click(sender, e)

    End Sub

    Private Sub Tool_Salir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_Salir.Click
        Me.Close()
    End Sub

    Private Sub Tool_Nuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_Nuevo.Click
        Call Cambiar_Estado_Botones_Tool(ToolS_Mantenimiento)
        Call MostrarTabs(1, utc_Datos, 1)
        Inicializa()
        Call Obtener_Ult_Num_Compro()
        lNew = True
        'udte_fecha.ReadOnly = True
        uce_Almacen.Focus()
        Tool_Imprimir.Enabled = False

    End Sub

    Private Sub Tool_Cancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_Cancelar.Click
        Call Cambiar_Estado_Botones_Tool(ToolS_Mantenimiento)
        Call MostrarTabs(0, utc_Datos, 0)
        Tool_Imprimir.Enabled = False
    End Sub

    Private Sub Tool_Editar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_Editar.Click
        If ug_Lista.Rows.Count = 0 Then Exit Sub
        If ug_Lista.ActiveRow Is Nothing Then Exit Sub
        If ug_Lista.ActiveRow.Cells(10).Value = 0 Then
            Avisar("El Registro ya esta Anulado")
            Exit Sub
        End If
        lNew = False

        Call Cambiar_Estado_Botones_Tool(ToolS_Mantenimiento)

        utxt_IdMovimiento.Text = ug_Lista.ActiveRow.Cells(0).Value
        uce_TipoDoc.Value = ug_Lista.ActiveRow.Cells(1).Value
        uce_Serie.Value = ug_Lista.ActiveRow.Cells(2).Value
        txt_NumDoc.Text = ug_Lista.ActiveRow.Cells(3).Value
        ucbo_Motivo.Value = ug_Lista.ActiveRow.Cells(4).Value
        uce_Almacen.Value = ug_Lista.ActiveRow.Cells(6).Value
        ucbo_AlmacenDest.Value = ug_Lista.ActiveRow.Cells(8).Value
        udte_fecha.Value = ug_Lista.ActiveRow.Cells(9).Value
        ucbo_Estado.Value = ug_Lista.ActiveRow.Cells(10).Value
        ' txt_idConsumo.Text = ug_Lista.ActiveRow.Cells(12).Value.ToString
        ' ucb_Area.Value = ug_Lista.ActiveRow.Cells(13).Value.ToString
        txt_Notas.Text = ug_Lista.ActiveRow.Cells(14).Value.ToString

        obe.MO_ID = Val(utxt_IdMovimiento.Text)
        ug_detalle.DataSource = obr.SEL03(obe)

        ug_detalle.UpdateData()

        Call MostrarTabs(1, utc_Datos, 1)
        uce_Almacen.ReadOnly = True
        ucbo_Motivo.ReadOnly = True
        uce_TipoDoc.ReadOnly = True
        uce_Serie.ReadOnly = True
       
        'ucbo_AlmacenDest.ReadOnly = True
        uce_Almacen.Focus()
        Tool_Imprimir.Enabled = True
    End Sub

    Private Sub Tool_Eliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_Eliminar.Click
        If ug_Lista.Rows.Count = 0 Then Exit Sub
        If ug_Lista.ActiveRow Is Nothing Then Exit Sub
        If ug_Lista.ActiveRow.Cells(10).Value = 0 Then
            Avisar("El Registro ya esta Anulado")
            Exit Sub
        End If
        If Preguntar("Seguro de Eliminar?") Then
            obe.MO_ID = ug_Lista.ActiveRow.Cells(0).Value
            obe.MO_IDEMPRESA = 7
            Dim i As Integer = obr.Delete(obe, String.Format("{0}-{1}", Environment.UserName, gStr_Usuario_Sis), Environment.MachineName)

            If i = -2 Then
                MessageBox.Show("No Se puede anular un movimiento del inventario ya cerrado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            ElseIf i < 0 Then
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
        If e.Row.Cells(10).Value = 0 Then
            e.Row.Appearance.ForeColor = Color.Tomato
        End If
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
        LimpiaGrid(ug_detalle, uds_detalle)
    End Sub

    Private Sub Tool_Imprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_Imprimir.Click
        Dim dt_comprobante As New DataTable
        'Dim obj As New DataTable
        dt_comprobante = obr.SEL05(Val(utxt_IdMovimiento.Text))
        'ug_detalle.DataSource = dt_comprobante

        Try
            Me.Cursor = Cursors.WaitCursor

            If dt_comprobante.Rows.Count > 0 Then
                Dim crystalBL As New LR.ClsReporte
                crystalBL.Muestra_Reporte(gStr_RutaRep & "\SG_LO_04.RPT", dt_comprobante, "", "ptdoc;" & uce_TipoDoc.Text, "pserie;" & uce_Serie.Text, "pnumero;" & txt_NumDoc.Text, "pPaciente;" & txt_Notas.Text, "pAlmacenOri;" & uce_Almacen.Text, "pAlmacenDes;" & ucbo_AlmacenDest.Text, "pMotivo;" & ucbo_Motivo.Text)
                crystalBL = Nothing
            End If

            Me.Cursor = Cursors.Default

        Catch ex As Exception
            Throw ex
            Me.Cursor = Cursors.Default
        End Try

    End Sub

    Private Sub uce_Mes_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles uce_Mes.LostFocus
        CargarLista()
    End Sub

    Private Sub txt_año_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_año.LostFocus
        CargarLista()
    End Sub

End Class