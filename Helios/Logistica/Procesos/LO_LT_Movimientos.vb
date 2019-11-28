Imports Infragistics.Win.UltraWinGrid
Public Class LO_LT_Movimientos
    Private obe As BE.LogisticaBE.SG_LO_TB_MOVIMIENTOS_C
    Private obr As BL.LogisticaBL.SG_LO_TB_MOVIMIENTOS_C
    Private obeT As BE.LogisticaBE.SG_LO_TB_MOVIMIENTOS_D

    Public lNew As Boolean = False
    Public OPCION As Integer
    Dim IGVTasa As Double
    Dim arrayMotipoTIpo() As String
    Public Sub New()
        InitializeComponent()
        obe = New BE.LogisticaBE.SG_LO_TB_MOVIMIENTOS_C
        obr = New BL.LogisticaBL.SG_LO_TB_MOVIMIENTOS_C
        obeT = New BE.LogisticaBE.SG_LO_TB_MOVIMIENTOS_D
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

        If arrayMotipoTIpo(1) <> 1 And lNew = True Then
            For i As Integer = 0 To ug_detalle.Rows.Count - 1
                If ug_detalle.Rows(i).Cells(4).Value > ug_detalle.Rows(i).Cells(5).Value Then
                    Avisar("Stock no suficiente")
                    ug_detalle.Rows(i).Cells(4).Value = ug_detalle.Rows(i).Cells(5).Value
                    GoTo Err_Valida
                End If
            Next
        End If

        Return True
        Exit Function
Err_Valida:
        MessageBox.Show("Corrija ó Complete los campos errados !!", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Return False
    End Function

    Private Sub Inicializa()
        Call LimpiaGrid(ug_detalle, uds_detalle)
        Call Limpiar_Controls_InGroupox(ugb_Datos)

        If uce_Almacen.Items.Count > 0 Then uce_Almacen.SelectedIndex = 0
        uce_Almacen.BackColor = Color.White
        ucbo_Motivo.BackColor = Color.White
        ucbo_Estado.Value = 1

        uce_TipoDoc.SelectedIndex = 0
        udte_fecha.Value = Now
        uce_Almacen.ReadOnly = False
        ucbo_Motivo.ReadOnly = False
        uce_TipoDoc.ReadOnly = False
        uce_Serie.ReadOnly = False
        ucb_Area.ReadOnly = False
        ucbo_AlmacenDest.ReadOnly = False

        ulbl_AlmacenArea.Text = ""
        ucbo_AlmacenDest.Visible = False
        ucb_Area.Visible = False
    End Sub

    Private Sub Cargar_Combos()
        '--almacenes
        Dim AlcBL As New BL.LogisticaBL.SG_LO_TB_ALMACEN
        uce_Almacen.DataSource = AlcBL.get_almacen_2(gInt_IdEmpresa, gInt_IdUsuario_Sis)
        uce_Almacen.DisplayMember = "AL_DESCRIPCION"
        uce_Almacen.ValueMember = "AL_ID"
        'AlcBL = Nothing

        ucbo_AlmacenDest.DataSource = AlcBL.get_almacen_3(gInt_IdEmpresa)
        ucbo_AlmacenDest.DisplayMember = "AL_DESCRIPCION"
        ucbo_AlmacenDest.ValueMember = "AL_ID"
        AlcBL = Nothing

        Dim AreBL As New BL.LogisticaBL.SG_LO_TB_AREA
        ucb_Area.DataSource = AreBL.getar(gInt_IdEmpresa)
        ucb_Area.DisplayMember = "AR_DESCRIPCION"
        ucb_Area.ValueMember = "AR_ID"
        AreBL = Nothing

        Dim motivBL As New BL.LogisticaBL.SG_LO_TB_MOTIVO
        Dim obeM As New BE.LogisticaBE.SG_LO_TB_MOTIVO
        obeM.MT_IDEMPRESA = gInt_IdEmpresa
        ucbo_Motivo.DataSource = motivBL.SEL02(obeM)
        ucbo_Motivo.DisplayMember = "MT_NOMBRE"
        ucbo_Motivo.ValueMember = "MT_ID"
        motivBL = Nothing

    End Sub

    Private Sub ucbo_Motivo_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ucbo_Motivo.ValueChanged
        arrayMotipoTIpo = Strings.Split(ucbo_Motivo.Value, "-")

        If Val(arrayMotipoTIpo(1)) = 3 Then
            ucbo_AlmacenDest.Visible = True
            ucb_Area.Visible = False
            ulbl_AlmacenArea.Text = "Almacen Destino"
        ElseIf Val(arrayMotipoTIpo(2)) = 1 Then
            ucb_Area.Visible = True
            ucbo_AlmacenDest.Visible = False
            ulbl_AlmacenArea.Text = "Area Destino"
        Else
            ucb_Area.Visible = False
            ucbo_AlmacenDest.Visible = False
            ulbl_AlmacenArea.Text = ""
        End If
        LimpiaGrid(ug_detalle, uds_detalle)
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
        numeracionBE.NC_IDEMPRESA = gInt_IdEmpresa
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
    '    comproBE.CM_IDEMPRESA = gInt_IdEmpresa

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

    Private Sub LO_LT_Movimientos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Cargar_Combos()
        Call CargarCombo_ConMeses(uce_Mes)

        Inicializa()
        uce_Mes.Value = Now.Month
        txt_año.Text = Now.Year

        Call Inicializar_Estado_Botones_Tool(ToolS_Mantenimiento)
        Call MostrarTabs(0, utc_Datos, 0)

        obe = New BE.LogisticaBE.SG_LO_TB_MOVIMIENTOS_C
        obr = New BL.LogisticaBL.SG_LO_TB_MOVIMIENTOS_C
        obeT = New BE.LogisticaBE.SG_LO_TB_MOVIMIENTOS_D

        Me.KeyPreview = True

        Call Formatear_Grilla_Selector(ug_Lista)
        obe.MO_IDEMPRESA = gInt_IdEmpresa

        ug_Lista.DataSource = obr.SEL01(obe, uce_Mes.Value, Val(txt_año.Text), gInt_IdUsuario_Sis)
        Tool_Imprimir.Enabled = False
        Cargar_Tasas_Impuestos()
    End Sub

    '----DETALLE
    Private Sub ubt_Agregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ubt_Agregar.Click

        LO_LT_ListaMedicamInsumos.IGVTas = IGVTasa
        If gInt_IdEmpresa = 7 Then
            LO_LT_ListaMedicamInsumos.TipoAten = 4
        Else
            LO_LT_ListaMedicamInsumos.TipoAten = 5
        End If


        LO_LT_ListaMedicamInsumos.idSeguro = "000"
        LO_LT_ListaMedicamInsumos.idalmacen = uce_Almacen.Value

        LO_LT_ListaMedicamInsumos.ShowDialog()

        Dim matriz As List(Of BE.LogisticaBE.SG_LO_TB_ARTICULO) = LO_LT_ListaMedicamInsumos.GetLista
        Dim aa As Integer = 0
        Dim cc As Integer = 0
        For Each articulo As BE.LogisticaBE.SG_LO_TB_ARTICULO In matriz
            If articulo.DS_SALDO > 0 Or arrayMotipoTIpo(1) = 1 Then
                Dim bb As Integer = 0
                For d As Integer = 0 To ug_detalle.Rows.Count - 1
                    If ug_detalle.Rows(d).Cells("MO_IDARTICULO").Value = articulo.AR_ID Then
                        bb = bb + 1
                    End If
                Next
                If bb = 0 Then
                    ug_detalle.DisplayLayout.Bands(0).AddNew()
                    ug_detalle.Rows(ug_detalle.Rows.Count - 1).Cells("MO_IDARTICULO").Value = articulo.AR_ID
                    ug_detalle.Rows(ug_detalle.Rows.Count - 1).Cells("AR_DESCRIPCION").Value = articulo.AR_DESCRIPCION
                    ug_detalle.Rows(ug_detalle.Rows.Count - 1).Cells("UM_DESCRIPCION").Value = articulo.UM_DesV
                    ug_detalle.Rows(ug_detalle.Rows.Count - 1).Cells("MO_IDLOTE").Value = articulo.DS_IDLOTE
                    ug_detalle.Rows(ug_detalle.Rows.Count - 1).Cells("MO_CANTIDAD").Value = 1
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
        ' Dim arrayMotipoTIpo() As String
        'arrayMotipoTIpo = Strings.Split(ucbo_Motivo.Value, "-")
        If arrayMotipoTIpo(1) <> 1 Then
            If e.Row.Cells(4).Value > e.Row.Cells(5).Value Then
                Avisar("Stock no suficiente")
                e.Cancel = True
                ' e.Handle = True
            End If
        End If
    End Sub

    Private Sub ug_Detalle_AfterRowUpdate(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinGrid.RowEventArgs) Handles ug_detalle.AfterRowUpdate
        ''e.Row.Cells("Total").Value = e.Row.Cells("Precio").Value * e.Row.Cells("Cant").Value
        'Dim subtotal_cal As Decimal = "0.00"
        'subtotal_cal = Math.Round((e.Row.Cells(5).Value * e.Row.Cells(6).Value), 2)
        'e.Row.Cells(7).Value = subtotal_cal
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
        'If gInt_IdEmpresa = 1 Then
        '    comproBE.MO_IDEMPRESA = 7
        'Else
        comproBE.MO_IDEMPRESA = gInt_IdEmpresa
        'End If

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

        If lNew = True Then
            Dim rpta_existe As Boolean = False
            Call Validar_existe_num_comprobante(rpta_existe)

            If rpta_existe Then
                Call Obtener_Ult_Num_Compro()
            End If
        End If

        If ug_detalle.Rows.Count = 0 Then
            Avisar("Falta agregar Items")
            Exit Sub
        End If

        If Val(arrayMotipoTIpo(1)) = 3 Then
            If ucbo_AlmacenDest.Text.Trim = "" Then
                Avisar("Seleccione Almacen")
                Exit Sub
            End If
        ElseIf Val(arrayMotipoTIpo(2)) = 1 Then
            If ucb_Area.Text.Trim = "" Then
                Avisar("Seleccione Area")
                Exit Sub
            End If
        End If

        With obe
            .MO_TDOC = uce_TipoDoc.Value
            .MO_SDOC = uce_Serie.Value
            .MO_NDOC = txt_NumDoc.Text
            .MO_FECHA = udte_fecha.Value
            .MO_IDALMACEN_ORI = uce_Almacen.Value

            'Dim arrayMotipoTIpo() As String
            'arrayMotipoTIpo = Strings.Split(ucbo_Motivo.Value, "-")
            .MO_IDAREA = IIf(arrayMotipoTIpo(2) = 1, ucb_Area.Value, "")
            .MO_IDALMACEN_DES = IIf(arrayMotipoTIpo(1) = 3, ucbo_AlmacenDest.Value, "")
            .MO_NOTA = txt_Notas.Text
            .MO_IDMOTIVO = arrayMotipoTIpo(0)
            .MO_IDCONSUMO = Val(txt_idConsumo.Text)
            .MO_IDEMPRESA = gInt_IdEmpresa
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
        obe.MO_IDEMPRESA = gInt_IdEmpresa
        ug_Lista.DataSource = obr.SEL01(obe, uce_Mes.Value, Val(txt_año.Text), gInt_IdUsuario_Sis)
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
        'If gInt_IdEmpresa = 7 Then
        udte_fecha.ReadOnly = True
        'Else
        'udte_fecha.ReadOnly = False
        ' End If
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
        txt_idConsumo.Text = ug_Lista.ActiveRow.Cells(12).Value.ToString
        ucb_Area.Value = ug_Lista.ActiveRow.Cells(13).Value.ToString
        txt_Notas.Text = ug_Lista.ActiveRow.Cells(14).Value.ToString

        obe.MO_ID = Val(utxt_IdMovimiento.Text)
        ug_detalle.DataSource = obr.SEL03(obe)

        ug_detalle.UpdateData()

        Call MostrarTabs(1, utc_Datos, 1)
        uce_Almacen.ReadOnly = True
        ucbo_Motivo.ReadOnly = True
        uce_TipoDoc.ReadOnly = True
        uce_Serie.ReadOnly = True
        ucb_Area.ReadOnly = True
        If gInt_IdEmpresa = 7 Then
            udte_fecha.ReadOnly = True
        Else
            udte_fecha.ReadOnly = False
        End If
        ucbo_AlmacenDest.ReadOnly = True
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
            obe.MO_IDEMPRESA = gInt_IdEmpresa
            Dim i As Integer = obr.Delete(obe, String.Format("{0}-{1}", Environment.UserName, gStr_Usuario_Sis), Environment.MachineName)

            If i = -2 Then
                MessageBox.Show("No Se puede anular un movimiento del inventario ya cerrado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            ElseIf i < 0 Then
                MessageBox.Show("La operación solicitada no ha podido ser realizada", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                Call Avisar("Listo!")
                obe.MO_IDEMPRESA = gInt_IdEmpresa
                ug_Lista.DataSource = obr.SEL01(obe, uce_Mes.Value, Val(txt_año.Text), gInt_IdUsuario_Sis)
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

        seriesBE.AS_IDEMPRESA = gInt_IdEmpresa
        seriesBE.AS_IDALMACEN = uce_Almacen.Value
        uce_TipoDoc.DataSource = seriesBL.SEL02(seriesBE)
        uce_TipoDoc.DisplayMember = "TD_DESCRIPCION"
        uce_TipoDoc.Value = "AS_TDOC"
        seriesBL = Nothing
        seriesBE = Nothing

        If uce_TipoDoc.Items.Count > 0 Then uce_TipoDoc.SelectedIndex = 0

        LimpiaGrid(ug_detalle, uds_detalle)

        Call Cargar_Series_Doc()
        Call Obtener_Ult_Num_Compro()
    End Sub

    Private Sub Tool_Imprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_Imprimir.Click
        If Val(arrayMotipoTIpo(1)) <> 3 And Val(arrayMotipoTIpo(1)) <> 4 And Val(arrayMotipoTIpo(1)) <> 2 Then Exit Sub

        Dim dt_comprobante As New DataTable
        'Dim obj As New DataTable
        dt_comprobante = obr.SEL05(Val(utxt_IdMovimiento.Text))
        'ug_detalle.DataSource = dt_comprobante

        Try
            Me.Cursor = Cursors.WaitCursor

            If dt_comprobante.Rows.Count > 0 Then
                Dim crystalBL As New LR.ClsReporte
                If gInt_IdEmpresa = 7 Then
                    crystalBL.Muestra_Reporte(gStr_RutaRep & "\SG_LO_04.RPT", dt_comprobante, "", "ptdoc;" & uce_TipoDoc.Text, "pserie;" & uce_Serie.Text, "pnumero;" & txt_NumDoc.Text, "pPaciente;" & txt_Notas.Text, "pAlmacenOri;" & uce_Almacen.Text, "pAlmacenDes;" & IIf(Val(arrayMotipoTIpo(1)) = 3, ucbo_AlmacenDest.Text, IIf(Val(arrayMotipoTIpo(2)) = 1, ucb_Area.Text, "")), "pMotivo;" & ucbo_Motivo.Text)
                Else
                    crystalBL.Muestra_Reporte(gStr_RutaRep & "\SG_LO_08.RPT", dt_comprobante, "", "ptdoc;" & uce_TipoDoc.Text, "pserie;" & uce_Serie.Text, "pnumero;" & txt_NumDoc.Text, "pPaciente;" & txt_Notas.Text, "pAlmacenOri;" & uce_Almacen.Text, "pAlmacenDes;" & IIf(Val(arrayMotipoTIpo(1)) = 3, ucbo_AlmacenDest.Text, IIf(Val(arrayMotipoTIpo(2)) = 1, ucb_Area.Text, "")), "pMotivo;" & ucbo_Motivo.Text)
                End If

                crystalBL = Nothing
            End If

            Me.Cursor = Cursors.Default

        Catch ex As Exception
            Throw ex
            Me.Cursor = Cursors.Default
        End Try

    End Sub

    Private Sub uce_Mes_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles uce_Mes.LostFocus
        ug_Lista.DataSource = obr.SEL01(obe, uce_Mes.Value, Val(txt_año.Text), gInt_IdUsuario_Sis)
    End Sub

    Private Sub txt_año_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_año.LostFocus
        ug_Lista.DataSource = obr.SEL01(obe, uce_Mes.Value, Val(txt_año.Text), gInt_IdUsuario_Sis)
    End Sub

End Class