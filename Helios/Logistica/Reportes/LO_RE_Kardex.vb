Public Class LO_RE_Kardex
    Private obe As BE.LogisticaBE.SG_LO_TB_MOVIMIENTOS_C
    Private obr As BL.LogisticaBL.SG_LO_TB_MOVIMIENTOS_C
    Dim IGVTasa As Double
    Public Sub New()
        InitializeComponent()
        obe = New BE.LogisticaBE.SG_LO_TB_MOVIMIENTOS_C
        obr = New BL.LogisticaBL.SG_LO_TB_MOVIMIENTOS_C
    End Sub
    Private Sub pKeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If e.KeyChar = Convert.ToChar(Keys.Return) Then
            SendKeys.Send("{TAB}")
            e.Handled = True
        End If
    End Sub

    Private Sub pKeyPressNumero(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_IDArticulo.KeyPress
        e.KeyChar = fKeyPress(e.KeyChar, sender.Text, 1)
        e.Handled = (e.KeyChar = "")
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


    Private Sub Inicializa()
        Call LimpiaGrid(ug_data, uds_Lista)
        txt_IDArticulo.Text = ""
        txt_Des_Articulo.Text = ""
        txtStock.Text = ""
        uck_ExcTransferencia.Checked = False
        uck_ExcVentas.Checked = False
        udtp_FechaFin.Value = Now
        udtp_fechaInicio.Value = Now
        uce_Almacen.SelectedIndex = 0
    End Sub

    Private Sub LO_RE_Kardex_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        obe = New BE.LogisticaBE.SG_LO_TB_MOVIMIENTOS_C
        obr = New BL.LogisticaBL.SG_LO_TB_MOVIMIENTOS_C
        Me.KeyPreview = True

        Dim AlcBL As New BL.LogisticaBL.SG_LO_TB_ALMACEN
        uce_Almacen.DataSource = AlcBL.get_almacen_2(gInt_IdEmpresa, gInt_IdUsuario_Sis)
        uce_Almacen.DisplayMember = "AL_DESCRIPCION"
        uce_Almacen.ValueMember = "AL_ID"
        AlcBL = Nothing
        txt_IDArticulo.ButtonsRight(0).Appearance.Image = My.Resources._104

        Call Inicializa()
        Cargar_Tasas_Impuestos()
    End Sub

    Private Sub Ayuda_Articulo()

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
        For Each articulo As BE.LogisticaBE.SG_LO_TB_ARTICULO In matriz
            txt_IDArticulo.Text = articulo.AR_ID
            txt_Des_Articulo.Text = articulo.AR_DESCRIPCION
        Next

    End Sub

    Private Sub Buscar_Articulo()
        Dim articuloBL As New BL.LogisticaBL.SG_LO_TB_ARTICULO
        Dim dt_tmp As DataTable = articuloBL.get_Articulos_x_id(Val(txt_IDArticulo.Text), gInt_IdEmpresa)
        Dim dt_tmpS As DataTable = articuloBL.get_Saldo_X_Articulo(gInt_IdEmpresa, uce_Almacen.Value, Val(txt_IDArticulo.Text))
        If dt_tmp.Rows.Count > 0 Then
            txt_Des_Articulo.Text = dt_tmp.Rows(0)("AR_DESCRIPCION")
        End If
        If dt_tmpS.Rows.Count > 0 Then
            txtStock.Text = dt_tmpS.Rows(0)(0).ToString
        Else
            txtStock.Text = 0
        End If

        dt_tmp.Dispose()
        dt_tmpS.Dispose()
        articuloBL = Nothing
    End Sub

    Private Sub txt_IDArticulo_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_IDArticulo.ValueChanged
        If txt_IDArticulo.Text.Trim.Length = 0 Then
            txt_IDArticulo.Text = String.Empty
            txt_Des_Articulo.Text = String.Empty
        End If
    End Sub
    Private Sub txt_IDArticulo_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_IDArticulo.KeyDown
        If e.KeyCode = Keys.F2 Then
            Call Ayuda_Articulo()
        End If
        If e.KeyCode = Keys.Enter Then
            Call Buscar_Articulo()

        End If
    End Sub
    Private Sub txt_IDArticulo_EditorButtonClick(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinEditors.EditorButtonEventArgs) Handles txt_IDArticulo.EditorButtonClick
        Call Ayuda_Articulo()
    End Sub

    Private Sub Tool_Consultar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_Consultar.Click

        Try

            Me.Cursor = Cursors.WaitCursor

            Call LimpiaGrid(ug_data, uds_Lista)
            Dim datoTipo As String
            If uce_Almacen.Value = Nothing Then Exit Sub
            If Val(txt_IDArticulo.Text) = 0 Then Exit Sub
            obe.MO_IDALMACEN_ORI = uce_Almacen.Value
            obe.MO_IDEMPRESA = gInt_IdEmpresa
            datoTipo = IIf(uck_ExcVentas.Checked = True, "SG_FA_TB_COMPROBANTE_C", IIf(uck_ExcTransferencia.Checked = True, "SG_LO_TB_MOVIMIENTOS_C", ""))
            ug_data.DataSource = obr.SEL06(obe, datoTipo, Val(txt_IDArticulo.Text), udtp_fechaInicio.Value, udtp_FechaFin.Value)
            ug_data.UpdateData()
            Dim articuloBL As New BL.LogisticaBL.SG_LO_TB_ARTICULO
            Dim dt_tmpS As DataTable = articuloBL.get_Saldo_X_Articulo(gInt_IdEmpresa, uce_Almacen.Value, Val(txt_IDArticulo.Text))
            If dt_tmpS.Rows.Count > 0 Then
                txtStock.Text = dt_tmpS.Rows(0)(0)
            Else
                txtStock.Text = 0
            End If

            dt_tmpS.Dispose()
            articuloBL = Nothing

            Me.Cursor = Cursors.Default

        Catch ex As Exception
            Avisar("Error en Consulta : " & ex.Message)
            Me.Cursor = Cursors.Default
        End Try

    End Sub
    Private Sub Tool_Salir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_Salir.Click
        Me.Close()
    End Sub
    Private Sub pFormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        obe = Nothing
        obr = Nothing
        e.Cancel = False
    End Sub

    Private Sub Tool_Imprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_Imprimir.Click
        If uce_Almacen.Value = Nothing Then Exit Sub
        If Val(txt_IDArticulo.Text) = 0 Then Exit Sub
        Me.Cursor = Cursors.WaitCursor
        Dim obj As New DataTable

        Dim nom_reporte As String = "SG_LO_07.RPT"
        Dim crystalBL As New LR.ClsReporte
        Dim dt_data As New DataTable
        obe.MO_IDALMACEN_ORI = uce_Almacen.Value
        obe.MO_IDEMPRESA = gInt_IdEmpresa
        dt_data = obr.SEL06(obe, IIf(uck_ExcVentas.Checked = True, "SG_FA_TB_COMPROBANTE_C", IIf(uck_ExcTransferencia.Checked = True, "SG_LO_TB_MOVIMIENTOS_C", "")), Val(txt_IDArticulo.Text), udtp_fechaInicio.Text, udtp_FechaFin.Text)

        crystalBL.Muestra_Reporte(gStr_RutaRep & "\" & nom_reporte, dt_data, "", "Particulo;" & txt_Des_Articulo.Text, "Palmacen;" & uce_Almacen.Text, "PfechaI;" & udtp_fechaInicio.Text, "PfechaF;" & udtp_FechaFin.Text, "pEmpresa;" & gStr_NomEmpresa)

        crystalBL = Nothing
        ' reportesBL = Nothing

        Me.Cursor = Cursors.Default
    End Sub


End Class