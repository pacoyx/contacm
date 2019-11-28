Imports Infragistics.Win.UltraWinGrid
Public Class BB_LT_RegLogistica
    Private obe As BE.LogisticaBE.SG_LO_TB_REQUERIMIENTO_C
    Private obr As BL.LogisticaBL.SG_LO_TB_REQUERIMIENTO_C
    Private obeT As BE.LogisticaBE.SG_LO_TB_REQUERIMIENTO_D

    Public lNew As Boolean = False
    Public OPCION As Integer
    Dim IGVTasa As Double
    Public Sub New()
        InitializeComponent()
        obe = New BE.LogisticaBE.SG_LO_TB_REQUERIMIENTO_C
        obr = New BL.LogisticaBL.SG_LO_TB_REQUERIMIENTO_C
        obeT = New BE.LogisticaBE.SG_LO_TB_REQUERIMIENTO_D
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
        'pLostfocus(txt_IdRequerimiento, Nothing)
        'If txt_IdRequerimiento.BackColor = Color.LightPink Then GoTo Err_Valida

        Return True
        Exit Function
Err_Valida:
        MessageBox.Show("Corrija ó Complete los campos errados !!", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Return False
    End Function

    Private Sub Inicializa()
        Call LimpiaGrid(ug_detalle, uds_detalle)
        Call Limpiar_Controls_InGroupox(ugb_Datos)
        txt_IdRequerimiento.BackColor = Color.White

        uce_tip_doc.SelectedIndex = 0
        udte_fecha.Value = Now
    End Sub

    Private Sub CargarLista()
        Call Formatear_Grilla_Selector(ug_Lista)
        obe.RC_IDEMPRESA = 1
        obe.RC_IDAREA = uce_Area.Value
        obe.RC_IDRegistro = Val(txt_idRegistro.Text)
        ug_Lista.DataSource = obr.SEL01(obe)
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
                'txtIDSeguro.Text = IIf(.CC_IDTIPO_ATENC = 1, "000", .CC_IDSEGURO)

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

    Private Sub BB_LT_RegConsumoFar_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Dim documentoscBL As New BL.AdmisionBL.SG_AD_TB_TIP_DOC_PER
        uce_tip_doc.DataSource = documentoscBL.getTiposDocs(7)
        uce_tip_doc.DisplayMember = "TD_ABREVIATURA"
        uce_tip_doc.ValueMember = "TD_ID"
        documentoscBL = Nothing

        Inicializa()

        Call Inicializar_Estado_Botones_Tool(ToolS_Mantenimiento)
        Tool_Imprimir.Enabled = False
        Tool_Editar.Enabled = True
        Tool_Eliminar.Enabled = True

        Call MostrarTabs(0, utc_Datos, 0)

        obe = New BE.LogisticaBE.SG_LO_TB_REQUERIMIENTO_C
        obr = New BL.LogisticaBL.SG_LO_TB_REQUERIMIENTO_C
        obeT = New BE.LogisticaBE.SG_LO_TB_REQUERIMIENTO_D

        Me.KeyPreview = True
        CargarLista()

    End Sub

    '----DETALLE
    Private Sub ubt_Agregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ubt_Agregar.Click
        BB_LT_AyudaArticulos.IDAREA = "007"
        BB_LT_AyudaArticulos.ShowDialog()

        Dim matriz As List(Of BE.FacturacionBE.SG_FA_TB_ARTICULO) = BB_LT_AyudaArticulos.GetLista

        For Each articulo As BE.FacturacionBE.SG_FA_TB_ARTICULO In matriz
            ug_detalle.DisplayLayout.Bands(0).AddNew()
            ug_detalle.Rows(ug_detalle.Rows.Count - 1).Cells("RD_ITEM").Value = ug_detalle.Rows.Count
            ug_detalle.Rows(ug_detalle.Rows.Count - 1).Cells("RD_IDARTICULO").Value = articulo.AR_ID
            ug_detalle.Rows(ug_detalle.Rows.Count - 1).Cells(2).Value = articulo.AR_DESCRIPCION
            ug_detalle.Rows(ug_detalle.Rows.Count - 1).Cells(3).Value = articulo.UM_DesV
            ug_detalle.Rows(ug_detalle.Rows.Count - 1).Cells(4).Value = 1
            ug_detalle.Rows(ug_detalle.Rows.Count - 1).Cells(5).Value = ""

            ug_detalle.UpdateData()
            ug_detalle.Refresh()

        Next
    End Sub

    Private Sub ubt_Quitar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ubt_Quitar.Click
        If ug_detalle.Rows.Count = 0 Then Exit Sub
        If ug_detalle.ActiveRow Is Nothing Then Exit Sub

        ug_detalle.ActiveRow.Delete()
    End Sub

    'Private Sub ug_Detalle_AfterRowUpdate(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinGrid.RowEventArgs) Handles ug_detalle.AfterRowUpdate
    '    Dim subtotal_cal As Decimal = "0.00"
    '    subtotal_cal = Math.Round((e.Row.Cells(5).Value * e.Row.Cells(6).Value), 2)
    '    e.Row.Cells(7).Value = subtotal_cal
    'End Sub
    Private Sub ug_Detalle_BeforeRowsDeleted(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.BeforeRowsDeletedEventArgs) Handles ug_detalle.BeforeRowsDeleted
        e.DisplayPromptMsg = False
        e.Cancel = False
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
            Avisar("Falta agregar articulos")
            Exit Sub
        End If

        With obe
            .RC_ID = Val(txt_IdRequerimiento.Text)
            .RC_FECHA_REQ = udte_fecha.Value
            .RC_NOTA = txt_Nota.Text
            .RC_IDAREA = uce_Area.Value
            .RC_IDCC = Val(txt_IDCUENTA.Text)
            .RC_IDEMPRESA = gInt_IdEmpresa
            .RC_IDUSUARIO = gInt_IdUsuario_Sis
            .RC_IDTIPO = 1
            .RC_IDPROYECTO = 0
            .RC_IDRegistro = Val(txt_idRegistro.Text)
        End With

        'Dim detalleBE As BE.LogisticaBE.SG_LO_TB_COMPROBANTES_DET
        Dim ls_detalles As New List(Of BE.LogisticaBE.SG_LO_TB_REQUERIMIENTO_D)
        Dim obeTc As BE.LogisticaBE.SG_LO_TB_REQUERIMIENTO_D
        ug_detalle.UpdateData()

        Dim total As Decimal = 0
        For i As Integer = 0 To ug_detalle.Rows.Count - 1
            obeTc = New BE.LogisticaBE.SG_LO_TB_REQUERIMIENTO_D
            With obeTc
                .RD_ITEM = i + 1
                .RD_IDARTICULO = ug_detalle.Rows(i).Cells("RD_IDARTICULO").Value
                .RD_CANT = ug_detalle.Rows(i).Cells("RD_CANT").Value
                .RD_NOTA = ug_detalle.Rows(i).Cells("RD_NOTA").Value

            End With
            ls_detalles.Add(obeTc)
        Next

        If lNew Then
            Dim s As Integer = obr.Insert(obe, String.Format("{0}-{1}", Environment.UserName, gStr_Usuario_Sis), Environment.MachineName, ls_detalles)
            txt_IdRequerimiento.Text = s
            If s < 0 Then
                MessageBox.Show("La operación solicitada no ha podido ser realizada", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If
        Else
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

        CargarLista()
        Tool_Grabar.Enabled = False
        Tool_Imprimir.Enabled = True

        ' Call Cambiar_Estado_Botones_Tool(ToolS_Mantenimiento)
        ' Call Tool_Nuevo_Click(sender, e)

    End Sub

    Private Sub Tool_Salir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_Salir.Click
        Me.Close()
    End Sub

    Private Sub Tool_Nuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_Nuevo.Click
        Inicializa()
        If Datos() Then
            Call Cambiar_Estado_Botones_Tool(ToolS_Mantenimiento)
            Call MostrarTabs(1, utc_Datos, 1)
            lNew = True
            ugb_Datos.Enabled = True
            txt_Nota.Focus()
        End If
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
        'If ug_Lista.ActiveRow.Cells(11).Value = 0 Then
        '    Avisar("El Registro ya esta Anulado")
        '    Exit Sub
        'End If
        ' If Datos() Then
        lNew = False
        Call Cambiar_Estado_Botones_Tool(ToolS_Mantenimiento)

        Dim obrT As New BL.AdmisionBL.SG_AD_TB_CUENTA_CAB
        Dim obeC As New BE.AdmisionBE.SG_AD_TB_CUENTA_CAB
        obeC.CC_ID = Val(txt_IDCUENTA.Text)
        Format(Val(txt_IDCUENTA.Text), "0000000000#")
        obeC.HasRow = False
        obrT.SEL04(obeC)
        If obeC.HasRow Then
            With obeC
                txt_idHistoria.Value = .CC_IDNUM_HIST
                'txtIDSeguro.Text = IIf(.CC_IDTIPO_ATENC = 1, "000", .CC_IDSEGURO)
                Dim historiaBL As New BL.AdmisionBL.SG_AD_TB_HISTO_CLINI
                Dim dt_histo_tmp As DataTable = historiaBL.getHistorias_Base_x_Id(txt_idHistoria.Value, 1)
                If dt_histo_tmp.Rows.Count > 0 Then
                    txt_Des_Cliente.Text = dt_histo_tmp.Rows(0)("HC_APE_PAT") & " " & dt_histo_tmp.Rows(0)("HC_APE_MAT") & " " & dt_histo_tmp.Rows(0)("HC_APE_CASADA") & " " & dt_histo_tmp.Rows(0)("HC_NOMBRE1") & " " & dt_histo_tmp.Rows(0)("HC_NOMBRE2")
                    txt_ruc_cliente.Text = dt_histo_tmp.Rows(0)("HC_NDOC")
                    uce_tip_doc.Value = dt_histo_tmp.Rows(0)("HC_TDOC")
                End If
                Format(Val(txt_idHistoria.Text), "0000000000#")
            End With
        End If

        txt_IdRequerimiento.Text = ug_Lista.ActiveRow.Cells(0).Value

        udte_fecha.Value = ug_Lista.ActiveRow.Cells(3).Value
        txt_Nota.Value = ug_Lista.ActiveRow.Cells(4).Value

        If ug_Lista.ActiveRow.Cells(5).Value = 0 Then
            Avisar("El Registro ya esta Anulado")
            Tool_Grabar.Enabled = False
            ugb_Datos.Enabled = False
            Tool_Imprimir.Enabled = False
        Else
            Tool_Grabar.Enabled = True
            ugb_Datos.Enabled = True
            Tool_Imprimir.Enabled = True
        End If

        Dim comproBL As New BL.FacturacionBL.SG_FA_TB_COMPROBANTE_C
        If comproBL.Existe_Comprob_Cuenta(Val(txt_IDCUENTA.Text)) Then
            Call Avisar("La Cuenta ya fue facturada a la aseguradora, No puede usarla.")
            Tool_Grabar.Enabled = False
            ugb_Datos.Enabled = False
            Tool_Imprimir.Enabled = False
        End If
        comproBL = Nothing

        obe.RC_ID = Val(txt_IdRequerimiento.Text)
        ug_detalle.DataSource = obr.SEL02(obe)

        ug_detalle.UpdateData()

        Call MostrarTabs(1, utc_Datos, 1)
        uce_tip_doc.Focus()

        '  End If
    End Sub

    Private Sub Tool_Eliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_Eliminar.Click
        If ug_Lista.Rows.Count = 0 Then Exit Sub
        If ug_Lista.ActiveRow Is Nothing Then Exit Sub

        If ug_Lista.ActiveRow.Cells(5).Value = 0 Then
            Avisar("El Registro ya esta Anulado")
            Exit Sub
        End If
       
        Dim comproBL As New BL.FacturacionBL.SG_FA_TB_COMPROBANTE_C
        If comproBL.Existe_Comprob_Cuenta(Val(txt_IDCUENTA.Text)) Then
            Call Avisar("La Cuenta ya fue facturada a la aseguradora, No puede usarla.")
            Exit Sub
        End If
        comproBL = Nothing

        If Preguntar("Seguro de Eliminar?") Then
            obe.RC_ID = ug_Lista.ActiveRow.Cells(0).Value
            If obr.Delete(obe, String.Format("{0}-{1}", Environment.UserName, gStr_Usuario_Sis), Environment.MachineName) < 0 Then
                MessageBox.Show("La operación solicitada no ha podido ser realizada", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                Call Avisar("Listo!")
                CargarLista()
            End If
        End If

    End Sub

    Private Sub pFormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If Tool_Grabar.Enabled = True Or Tool_Imprimir.Enabled = True Then
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
        If e.Row.Cells(5).Value = 0 Then
            e.Row.Appearance.ForeColor = Color.Tomato
        End If
    End Sub

    Private Sub Tool_Imprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_Imprimir.Click
        If txt_IdRequerimiento.Text <> "" Then
            Dim dt_comprobante As New DataTable
            'Dim obj As New DataTable
            obe.RC_ID = Val(txt_IdRequerimiento.Text)
            dt_comprobante = obr.SEL03(obe)
            'ug_detalle.DataSource = dt_comprobante

            Try
                Me.Cursor = Cursors.WaitCursor

                If dt_comprobante.Rows.Count > 0 Then
                    Dim crystalBL As New LR.ClsReporte
                    crystalBL.Muestra_Reporte(gStr_RutaRep & "\SG_LO_12.RPT", dt_comprobante, "", "pRequerimiento;" & txt_IdRequerimiento.Text, "pPaciente;" & txt_Nota.Text, "pAlmacenOri;" & uce_Area.Text)
                    crystalBL = Nothing
                End If

                Me.Cursor = Cursors.Default

            Catch ex As Exception
                Throw ex
                Me.Cursor = Cursors.Default
            End Try

            Call Tool_Cancelar_Click(sender, e)
        End If
    End Sub
End Class
