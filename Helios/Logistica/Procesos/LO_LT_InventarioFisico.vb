Imports Infragistics.Win.UltraWinGrid
Public Class LO_LT_InventarioFisico
    Private obe As BE.LogisticaBE.SG_LO_TB_SALDOS_C
    Private obr As BL.LogisticaBL.SG_LO_TB_SALDOS_C

    Private obeT As BE.LogisticaBE.SG_LO_TB_SALDOS_D

    Public lNew As Boolean = False
    Public OPCION As Integer
    Dim IGVTasa As Double
    Public Sub New()
        InitializeComponent()
        obe = New BE.LogisticaBE.SG_LO_TB_SALDOS_C
        obr = New BL.LogisticaBL.SG_LO_TB_SALDOS_C
        obeT = New BE.LogisticaBE.SG_LO_TB_SALDOS_D
    End Sub
    Private Sub pKeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If e.KeyChar = Convert.ToChar(Keys.Return) Then
            SendKeys.Send("{TAB}")
            e.Handled = True
        End If
    End Sub
    Private Sub pKeyPressNumero(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles utxt_IDSaldo.KeyPress
        e.KeyChar = fKeyPress(e.KeyChar, sender.Text, 1)
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
        impuestoBE.IM_IDEMPRESA = New BE.ContabilidadBE.SG_CO_TB_EMPRESA With {.EM_ID = gInt_IdEmpresa}
        impuestoBE.IM_IDTIPOIMPUESTO = New BE.ContabilidadBE.SG_CO_TB_TIPO_IMPUESTO With {.TI_CODIGO = "01"}
        impuestoBE.IM_PERIODO = Now.Year
        impuestoBE.IM_MES = Now.Month
        impuestosBL.getImpuestos_x_Tipo(impuestoBE)
        IGVTasa = impuestoBE.IM_TASA
        impuestosBL = Nothing
        impuestoBE = Nothing
    End Sub

    Private Function fValida() As Boolean
        pLostfocus(uce_Almacen, Nothing)

        If uce_Almacen.BackColor = Color.LightPink Then GoTo Err_Valida

        Return True
        Exit Function
Err_Valida:
        MessageBox.Show("Corrija ó Complete los campos errados !!", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Return False
    End Function

    Private Sub Inicializa()
        Call LimpiaGrid(ug_detalle, uds_Lista)
        utxt_IDSaldo.BackColor = Color.White
        udte_fechaA.Value = Nothing
        udtp_FechaCierre.Value = Nothing
        udte_fechaIni.Value = Nothing

        utxt_IDSaldo.Enabled = True
        uce_Almacen.Enabled = False
        ubt_Cargar.Enabled = False
        ubt_Agregar.Enabled = False

        ubt_Cargar.Enabled = False
        uchk_Cierre.Checked = False
        utxt_IDSaldo.Text = ""
        uchk_Cierre.Enabled = False

        Tool_ImprimirCierre.Enabled = False
        Tool_Imprimir.Enabled = False
        Tool_Nuevo.Enabled = True
        Tool_Grabar.Enabled = False
        Tool_Cancelar.Enabled = False
        Tool_Salir.Enabled = True

    End Sub

    Private Sub Cargar_Combos()
        '--almacenes
        Dim AlcBL As New BL.LogisticaBL.SG_LO_TB_ALMACEN
        uce_Almacen.DataSource = AlcBL.get_almacen_2(gInt_IdEmpresa, gInt_IdUsuario_Sis)
        uce_Almacen.DisplayMember = "AL_DESCRIPCION"
        uce_Almacen.ValueMember = "AL_ID"
        AlcBL = Nothing
    End Sub

    Private Sub LO_LT_InventarioFisico_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Cargar_Combos()
        Inicializa()

        Call Inicializar_Estado_Botones_Tool(ToolS_Mantenimiento)

        utxt_IDSaldo.ButtonsRight(0).Appearance.Image = My.Resources._104
        ubt_Agregar.Appearance.Image = My.Resources._16__Plus_
        ubt_Cargar.Appearance.Image = My.Resources.action_refresh_blue
        obe = New BE.LogisticaBE.SG_LO_TB_SALDOS_C
        obr = New BL.LogisticaBL.SG_LO_TB_SALDOS_C
        obeT = New BE.LogisticaBE.SG_LO_TB_SALDOS_D

        Me.KeyPreview = True

        Call Cargar_Tasas_Impuestos()
    End Sub

    Private Sub Tool_Nuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_Nuevo.Click
        'Call Cambiar_Estado_Botones_Tool(ToolS_Mantenimiento)
        Inicializa()
        lNew = True
        utxt_IDSaldo.Enabled = False
        uce_Almacen.Enabled = True
        ubt_Cargar.Enabled = True
        ubt_Agregar.Enabled = True
        utxt_IDSaldo.Enabled = False
        uce_Almacen.Focus()

        Tool_Nuevo.Enabled = False
        Tool_Grabar.Enabled = True
        Tool_Cancelar.Enabled = True
        Tool_Salir.Enabled = False
        Tool_ImprimirCierre.Enabled = False
        Tool_Imprimir.Enabled = True
    End Sub

    Private Sub ubt_Agregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ubt_Agregar.Click
        LO_LT_AyuArtiCom.ShowDialog()
        If LO_LT_AyuArtiCom.bol_Aceptar Then

            Dim matriz As List(Of BE.LogisticaBE.SG_LO_TB_ARTICULO) = LO_LT_AyuArtiCom.GetLista

            For Each articulo As BE.LogisticaBE.SG_LO_TB_ARTICULO In matriz

                obe.SA_IDEMPRESA = gInt_IdEmpresa
                obe.SA_IDALMACEN = uce_Almacen.Value
                Dim drr_MOV As System.Data.SqlClient.SqlDataReader
                drr_MOV = obr.SEL02(obe, articulo.AR_ID)
                If drr_MOV.HasRows Then
                    drr_MOV.Read()

                    ug_detalle.DisplayLayout.Bands(0).AddNew()
                    With ug_detalle.Rows(ug_detalle.Rows.Count - 1)

                        .Cells("DS_COSTO").Value = drr_MOV("DS_COSTO")
                        .Cells("DS_IDLOTE").Value = drr_MOV("DE_IDLOTE")

                        .Cells("DS_IDARTICULO").Value = articulo.AR_ID
                        .Cells("AR_DESCRIPCION").Value = articulo.AR_DESCRIPCION
                        .Cells("UM_DESCRIPCION").Value = articulo.UM_Des

                        .Cells("DS_INICIAL").Value = 0
                        .Cells("DS_INGRESOS").Value = 0
                        .Cells("DS_SALIDAS").Value = 0
                        .Cells("DS_SALDO").Value = 0
                        '.Cells("DS_SALDO_FISICO").Value = 
                        .Cells("Nuevo").Value = 0
                    End With
                Else
                    Avisar("El Producto ya existe.")
                End If
                drr_MOV.Close()
            Next
            ug_detalle.UpdateData()
        End If
    End Sub

    'Private Sub Tool_Editar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    Call Cambiar_Estado_Botones_Tool(ToolS_Mantenimiento)
    '    lNew = False
    '    utxt_IDSaldo.Enabled = True
    '    uce_Almacen.Enabled = False
    '    ubt_Cargar.Enabled = False
    '    ubt_Agregar.Enabled = False
    '    uchk_Cierre.Enabled = False
    '    utxt_IDSaldo.Focus()
    'End Sub

    Private Sub ubt_Cargar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ubt_Cargar.Click
        obe.SA_IDALMACEN = uce_Almacen.Value
        obe.SA_IDEMPRESA = gInt_IdEmpresa
        obe.SA_ID = 0
        Dim ds_Cab As New DataSet
        ds_Cab = obr.SEL01(obe, 1)
        If ds_Cab.Tables(0).Rows.Count > 0 Then
            utxt_IDSaldo.Text = ds_Cab.Tables(0).Rows(0)("SA_ID")
            udte_fechaA.Value = ds_Cab.Tables(0).Rows(0)("SA_FECHA_APERTURA")
            udtp_FechaCierre.Value = ds_Cab.Tables(0).Rows(0)("SA_FECHA_CIERRE").ToString
            uchk_Cierre.Checked = False

            ug_detalle.DataSource = ds_Cab.Tables(1)
            ug_detalle.UpdateData()

            uce_Almacen.Enabled = False
            ubt_Cargar.Enabled = False
            uchk_Cierre.Enabled = True
            udtp_FechaCierre.Value = Now
            udte_fechaIni.ReadOnly = False

            ug_detalle.DisplayLayout.Bands(0).Columns("DS_SALDO_FISICO").CellActivation = Activation.AllowEdit
        End If
    End Sub

    Private Sub Tool_Cancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_Cancelar.Click
        'Call Cambiar_Estado_Botones_Tool(ToolS_Mantenimiento)
        Inicializa()
    End Sub

    Private Sub Tool_Salir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_Salir.Click
        Me.Close()
    End Sub

    'Inventario
    Private Sub Ayuda_Anexo_Inventario()

        LO_LT_ListaInventario.ShowDialog()

        Dim matriz As List(Of String) = LO_LT_ListaInventario.GetLista

        If matriz.Count > 0 Then
            utxt_IDSaldo.Text = matriz(0)

            obe.SA_ID = Val(utxt_IDSaldo.Text)
            Format(Val(utxt_IDSaldo.Text), "0000000000#")

            obe.SA_IDALMACEN = uce_Almacen.Value
            obe.SA_IDEMPRESA = gInt_IdEmpresa
            Dim ds_Cab As New DataSet
            ds_Cab = obr.SEL01(obe, 2)
            If ds_Cab.Tables(0).Rows.Count > 0 Then
                'utxt_IDSaldo.Text = ds_Cab.Tables(0).Rows(0)("SA_ID")
                uce_Almacen.Value = ds_Cab.Tables(0).Rows(0)("SA_IDALMACEN")
                udte_fechaA.Value = ds_Cab.Tables(0).Rows(0)("SA_FECHA_APERTURA")

                udte_fechaIni.Value = ds_Cab.Tables(0).Rows(0)("SA_FECHA_INICIO_INV")

                udtp_FechaCierre.Value = IIf(ds_Cab.Tables(0).Rows(0)("SA_ESTADO") = 1, Now, ds_Cab.Tables(0).Rows(0)("SA_FECHA_CIERRE").ToString)
                uchk_Cierre.Checked = IIf(ds_Cab.Tables(0).Rows(0)("SA_ESTADO") = 1, False, True)

                ug_detalle.DataSource = ds_Cab.Tables(1)

                ug_detalle.UpdateData()

                'uce_Almacen.Enabled = False
                'ubt_Cargar.Enabled = False
                utxt_IDSaldo.Enabled = False
                If ds_Cab.Tables(0).Rows(0)("SA_ESTADO") = 0 Then
                    ubt_Agregar.Enabled = False
                    uchk_Cierre.Enabled = False
                    ug_detalle.DisplayLayout.Bands(0).Columns("DS_SALDO_FISICO").CellActivation = Activation.NoEdit
                    Tool_Grabar.Enabled = False
                    udte_fechaIni.ReadOnly = True
                    Tool_ImprimirCierre.Enabled = True
                Else
                    ubt_Agregar.Enabled = True
                    uchk_Cierre.Enabled = True
                    ug_detalle.DisplayLayout.Bands(0).Columns("DS_SALDO_FISICO").CellActivation = Activation.AllowEdit
                    Tool_Grabar.Enabled = True
                    udte_fechaIni.ReadOnly = False
                    Tool_ImprimirCierre.Enabled = False
                End If

                uce_Almacen.Enabled = False
                ubt_Cargar.Enabled = False
                'udtp_FechaCierre.Value = Now


                Tool_Nuevo.Enabled = False
                Tool_Cancelar.Enabled = True
                Tool_Salir.Enabled = False
                Tool_Imprimir.Enabled = True

            Else
                Avisar("Cuenta no Existe!")
            End If

        End If

    End Sub

    Private Sub Buscar_Inventario()

        obe.SA_ID = Val(utxt_IDSaldo.Text)
        Format(Val(utxt_IDSaldo.Text), "0000000000#")

        obe.SA_IDALMACEN = uce_Almacen.Value
        obe.SA_IDEMPRESA = gInt_IdEmpresa
        Dim ds_Cab As New DataSet
        ds_Cab = obr.SEL01(obe, 2)
        If ds_Cab.Tables(0).Rows.Count > 0 Then
            'utxt_IDSaldo.Text = ds_Cab.Tables(0).Rows(0)("SA_ID")
            uce_Almacen.Value = ds_Cab.Tables(0).Rows(0)("SA_IDALMACEN")
            udte_fechaA.Value = ds_Cab.Tables(0).Rows(0)("SA_FECHA_APERTURA")
            udte_fechaIni.Value = ds_Cab.Tables(0).Rows(0)("SA_FECHA_INICIO_INV")
            udtp_FechaCierre.Value = IIf(ds_Cab.Tables(0).Rows(0)("SA_ESTADO") = 1, Now, ds_Cab.Tables(0).Rows(0)("SA_FECHA_CIERRE").ToString)
            uchk_Cierre.Checked = IIf(ds_Cab.Tables(0).Rows(0)("SA_ESTADO") = 1, False, True)

            ug_detalle.DataSource = ds_Cab.Tables(1)

            ug_detalle.UpdateData()

            'uce_Almacen.Enabled = False
            'ubt_Cargar.Enabled = False
            utxt_IDSaldo.Enabled = False
            If ds_Cab.Tables(0).Rows(0)("SA_ESTADO") = 0 Then
                ubt_Agregar.Enabled = False
                uchk_Cierre.Enabled = False
                ug_detalle.DisplayLayout.Bands(0).Columns("DS_SALDO_FISICO").CellActivation = Activation.NoEdit
                Tool_Grabar.Enabled = False
                udte_fechaIni.ReadOnly = True
                Tool_ImprimirCierre.Enabled = True
            Else
                ubt_Agregar.Enabled = True
                uchk_Cierre.Enabled = True
                ug_detalle.DisplayLayout.Bands(0).Columns("DS_SALDO_FISICO").CellActivation = Activation.AllowEdit
                Tool_Grabar.Enabled = True
                udte_fechaIni.ReadOnly = False
                Tool_ImprimirCierre.Enabled = False
            End If

            uce_Almacen.Enabled = False
            ubt_Cargar.Enabled = False
            'udtp_FechaCierre.Value = Now
            Tool_Nuevo.Enabled = False
            Tool_Cancelar.Enabled = True
            Tool_Salir.Enabled = False
            Tool_Imprimir.Enabled = True
        Else
            Avisar("Inventario no iniciado!")
        End If

       
    End Sub

    Private Sub utxt_IDSaldo_EditorButtonClick(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinEditors.EditorButtonEventArgs) Handles utxt_IDSaldo.EditorButtonClick
        Call Ayuda_Anexo_Inventario()
    End Sub

    Private Sub utxt_IDSaldo_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles utxt_IDSaldo.KeyDown
        If e.KeyCode = Keys.Enter Or e.KeyCode = Keys.Tab Then
            Call Buscar_Inventario()
        End If

        If e.KeyCode = Keys.F2 Then Call Ayuda_Anexo_Inventario()
    End Sub

    Private Sub Tool_Grabar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_Grabar.Click
        If ug_detalle.Rows.Count = 0 Then
            Avisar("No hay productos en el detalle")
            Exit Sub
        End If
        If udte_fechaIni.Value = Nothing Then
            Avisar("Falta Ingresar la fecha que inicio su inventario")
            Exit Sub
        End If
        If uchk_Cierre.Checked = True Then
            If Preguntar("Se generara movimiento de ajuste por las diferencias de saldos") = False Then
                Exit Sub
            End If
        End If
        Dim detalleBE As BE.LogisticaBE.SG_LO_TB_SALDOS_D
        Dim ls_detalles As New List(Of BE.LogisticaBE.SG_LO_TB_SALDOS_D)

        With obe
            .SA_ID = Val(utxt_IDSaldo.Text)
            .SA_IDALMACEN = uce_Almacen.Value
            .SA_IDEMPRESA = gInt_IdEmpresa
            .SA_FECHA_INICIO_INV = udte_fechaIni.Value
        End With

        For i As Integer = 0 To ug_detalle.Rows.Count - 1
            detalleBE = New BE.LogisticaBE.SG_LO_TB_SALDOS_D
            With detalleBE
                .DS_IDSALDO = Val(utxt_IDSaldo.Text)
                .DS_IDLOTE = ug_detalle.Rows(i).Cells("DS_IDLOTE").Value.ToString
                .DS_IDARTICULO = ug_detalle.Rows(i).Cells("DS_IDARTICULO").Value
                .DS_INICIAL = ug_detalle.Rows(i).Cells("DS_INICIAL").Value
                .DS_INGRESOS = ug_detalle.Rows(i).Cells("DS_INGRESOS").Value
                .DS_SALIDAS = ug_detalle.Rows(i).Cells("DS_SALIDAS").Value
                .DS_SALDO = ug_detalle.Rows(i).Cells("DS_SALDO").Value
                .DS_SALDO_FISICO = Val(ug_detalle.Rows(i).Cells("DS_SALDO_FISICO").Value.ToString)
                .DS_COSTO = ug_detalle.Rows(i).Cells("DS_COSTO").Value
                .Val = IIf(ug_detalle.Rows(i).Cells("DS_SALDO_FISICO").Value.ToString = "", 0, 1)
            End With
            ls_detalles.Add(detalleBE)
        Next
        Try
            obr.Insert(obe, String.Format("{0}-{1}", Environment.UserName, gStr_Usuario_Sis), Environment.MachineName, ls_detalles, IIf(uchk_Cierre.Checked = True, 1, 0))

            Call Avisar("Listo!")

            'Call Cambiar_Estado_Botones_Tool(ToolS_Mantenimiento)
            Call Tool_Cancelar_Click(sender, e)

        Catch ex As Exception
            Call ShowError(ex.Message)
        End Try

    End Sub

    Private Sub ug_Detalle_AfterRowUpdate(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinGrid.RowEventArgs) Handles ug_detalle.AfterRowUpdate
        'If Val(e.Row.Cells(8).Value) > Val(e.Row.Cells(9).Value) Then
        e.Row.Cells(10).Value = Val(e.Row.Cells(9).Value.ToString) - Val(e.Row.Cells(8).Value.ToString)
        'End If
    End Sub

    Private Sub Tool_Imprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_Imprimir.Click
        If Val(utxt_IDSaldo.Text) = 0 Then Exit Sub
        Me.Cursor = Cursors.WaitCursor
        Dim obj As New DataTable

        Dim nom_reporte As String = "SG_LO_05.RPT"
        Dim crystalBL As New LR.ClsReporte
        Dim dt_data As New DataTable
        obe.SA_IDEMPRESA = gInt_IdEmpresa
        obe.SA_ID = Val(utxt_IDSaldo.Text)
        dt_data = obr.ListaImprimirInv(obe)

        crystalBL.Muestra_Reporte(gStr_RutaRep & "\" & nom_reporte, dt_data, "", "pSaldo;" & utxt_IDSaldo.Text, "pEmpresa;" & gStr_NomEmpresa)

        crystalBL = Nothing
        ' reportesBL = Nothing

        Me.Cursor = Cursors.Default
    End Sub


    Private Sub Tool_ImprimirCierre_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_ImprimirCierre.Click
        If Val(utxt_IDSaldo.Text) = 0 Then Exit Sub
        Me.Cursor = Cursors.WaitCursor
        Dim obj As New DataTable

        Dim nom_reporte As String = "SG_LO_13.RPT"
        Dim crystalBL As New LR.ClsReporte
        Dim dt_data As New DataTable
        obe.SA_IDEMPRESA = gInt_IdEmpresa
        obe.SA_ID = Val(utxt_IDSaldo.Text)
        dt_data = obr.ListaImprimirInv2(obe)

        crystalBL.Muestra_Reporte(gStr_RutaRep & "\" & nom_reporte, dt_data, "", "pSaldo;" & utxt_IDSaldo.Text, "pEmpresa;" & gStr_NomEmpresa)

        crystalBL = Nothing
        ' reportesBL = Nothing

        Me.Cursor = Cursors.Default
    End Sub
End Class
