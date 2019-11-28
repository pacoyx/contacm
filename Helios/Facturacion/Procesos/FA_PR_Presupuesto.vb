Imports Infragistics.Win.UltraWinGrid
Public Class FA_PR_Presupuesto
    Private obe As BE.FacturacionBE.SG_FA_TB_PRESUPUESTO_CAB
    Private obr As BL.FacturacionBL.SG_FA_TB_PRESUPUESTO_CAB

    Private obeT As BE.FacturacionBE.SG_FA_TB_PRESUPUESTO_DET
    Private obrT As BL.FacturacionBL.SG_FA_TB_PRESUPUESTO_DET

    Public lNew As Boolean = False
    Public OPCION As Integer
    Dim IGVTasa As Double
    Public Sub New()
        InitializeComponent()
        obe = New BE.FacturacionBE.SG_FA_TB_PRESUPUESTO_CAB
        obr = New BL.FacturacionBL.SG_FA_TB_PRESUPUESTO_CAB
        obeT = New BE.FacturacionBE.SG_FA_TB_PRESUPUESTO_DET
        obrT = New BL.FacturacionBL.SG_FA_TB_PRESUPUESTO_DET
    End Sub
    Private Sub pKeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Me.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Return) Then
            SendKeys.Send("{TAB}")
            e.Handled = True
        End If
    End Sub
    Private Sub pKeyPressNumero(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_PagoFijo.KeyPress, txt_PagoVariable.KeyPress
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
        pLostfocus(txt_Ruc_ClientesC, Nothing)
        pLostfocus(txt_Tratamiento, Nothing)
        pLostfocus(uce_Medico, Nothing)

        'If Val(txt_Ruc_ClientesC.Text) = 0 Then txt_Ruc_ClientesC.BackColor = Color.LightPink
        If txt_Tratamiento.Text = "" Then txt_Tratamiento.BackColor = Color.LightPink
        If uce_Medico.Text = "" Then uce_Medico.BackColor = Color.LightPink
    
        If txt_Ruc_ClientesC.BackColor = Color.LightPink Then GoTo Err_Valida
        If txt_Tratamiento.BackColor = Color.LightPink Then GoTo Err_Valida
        If uce_Medico.BackColor = Color.LightPink Then GoTo Err_Valida

        Return True
        Exit Function
Err_Valida:
        MessageBox.Show("Corrija ó Complete los campos errados !!", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Return False
    End Function

    Private Sub Inicializa()
        Call LimpiaGrid(ug_detalle, uds_detalle)
        Call Limpiar_Controls_InGroupox(ugb_Datos)
        txt_Ruc_ClientesC.BackColor = Color.White
        txt_Tratamiento.BackColor = Color.White
        uce_Medico.BackColor = Color.White
        ucbo_Estado.Value = 1


        ucm_SeguroEps.Enabled = False
        ugb_Cuenta.Enabled = False
        uce_tip_doc.SelectedIndex = 0

        txt_SubTotal.Value = 0
        txt_IGV.Value = 0
        txt_Total.Value = 0

        udte_fecha.Value = Now

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

    End Sub


    Private Sub AD_PR_Atencion_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Cargar_Combos()
        Inicializa()

        Call Inicializar_Estado_Botones_Tool(ToolS_Mantenimiento)
        Call MostrarTabs(0, utc_Datos, 0)

        txt_Ruc_ClientesC.ButtonsRight(0).Appearance.Image = My.Resources._104
        txt_Tratamiento.ButtonsRight(0).Appearance.Image = My.Resources._104
        txt_ruc_cliente.ButtonsRight(0).Appearance.Image = My.Resources._104

        txt_Tratamiento.BackColor = Color.White
        txt_Ruc_ClientesC.BackColor = Color.White

        obe = New BE.FacturacionBE.SG_FA_TB_PRESUPUESTO_CAB
        obr = New BL.FacturacionBL.SG_FA_TB_PRESUPUESTO_CAB
        obeT = New BE.FacturacionBE.SG_FA_TB_PRESUPUESTO_DET
        obrT = New BL.FacturacionBL.SG_FA_TB_PRESUPUESTO_DET


        Cargar_Tasas_Impuestos()

        Me.KeyPreview = True

        Call Formatear_Grilla_Selector(ug_Lista)
        obe.PR_IDEMPRESA = gInt_IdEmpresa

        Dim obj As New DataTable
        obe.PR_IDEMPRESA = gInt_IdEmpresa
        obr.SEL01(obe, obj)
        ug_Lista.DataSource = obj

    End Sub


    '----tratamiento
    Private Sub txt_Tratamiento_EditorButtonClick(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinEditors.EditorButtonEventArgs) Handles txt_Tratamiento.EditorButtonClick
        Select Case e.Button.Key
            Case "ayuda"
                Call Ayuda_Anexo_Cab_T()
            Case "editar"

        End Select
    End Sub
    Private Sub txt_Tratamiento_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_Tratamiento.KeyDown
        'If e.KeyCode = Keys.Enter Then
        '    Call Buscar_Tratamiento()
        'End If

        If e.KeyCode = Keys.F2 Then Call Ayuda_Anexo_Cab_T()
    End Sub
    Private Sub txt_Tratamiento_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_Tratamiento.ValueChanged
        If txt_Tratamiento.Text.Trim.Length = 0 Then
            txt_idTratamiento.Text = String.Empty
        End If
    End Sub

    Private Sub Ayuda_Anexo_Cab_T()

        FA_PR_ListaTratamientos.ShowDialog()

        Dim matriz As List(Of String) = FA_PR_ListaTratamientos.GetLista

        If matriz.Count > 0 Then
            txt_idTratamiento.Text = matriz(0)
            txt_Tratamiento.Text = matriz(1)

            Dim obrT As New BL.FacturacionBL.SG_FA_TB_PAQUETE_DET
            Dim obeT As New BE.FacturacionBE.SG_FA_TB_PAQUETE_DET
            Dim obj As New DataTable
            obeT.PD_IDCAB = Val(txt_idTratamiento.Text)
            obeT.PD_IDEMPRESA = gInt_IdEmpresa
            obrT.SEL02(obeT, IIf(uchk_SeguroEps.Checked = True, ucm_SeguroEps.Value, ""), IIf(uchk_SeguroEps.Checked = True, 1, 0), IGVTasa, obj)
            ug_detalle.DataSource = obj

            Calcular_Copago()
            Calcular_Totales()
            ug_detalle.UpdateData()
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

        clienteBE.CL_NDOC = txt_Ruc_ClientesC.Text.Trim
        clienteBE.CL_IDEMPRESA = New BE.ContabilidadBE.SG_CO_TB_EMPRESA With {.EM_ID = gInt_IdEmpresa}
        clienteBL.get_Cliente_x_Ruc(clienteBE)

        If clienteBE.HasRow Then
            txt_idClienteC.Text = clienteBE.CL_ID
            txt_Des_ClienteC.Text = clienteBE.CL_NOMBRE
            uchk_SeguroEps.Focus()
        Else

            If Preguntar("El cliente no existe!, Desea Crearlo?") Then

                FA_PR_IngClienteRapido.str_num_ruc = txt_ruc_cliente.Text.Trim
                FA_PR_IngClienteRapido.ShowDialog()
                If FA_PR_IngClienteRapido.bol_Grabo Then
                    clienteBL.get_Cliente_x_Ruc(clienteBE)
                    If clienteBE.HasRow Then
                        txt_idClienteC.Text = clienteBE.CL_ID
                        txt_Des_ClienteC.Text = clienteBE.CL_NOMBRE
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


    Private Sub uchk_SeguroEps_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles uchk_SeguroEps.CheckedChanged
        If uchk_SeguroEps.Checked = True Then
            ucm_SeguroEps.Enabled = True
            ugb_Cuenta.Enabled = True
            ucm_SeguroEps.SelectedIndex = 0
        Else
            ucm_SeguroEps.SelectedIndex = -1
            ucm_SeguroEps.Enabled = False
            ugb_Cuenta.Enabled = False
            Call Limpiar_Controls_InGroupox(ugb_Cuenta)
            Calcular_Copago()
            Calcular_Totales()
        End If
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
        ' AD_PR_ListaArticulosSeg.idSeguro = IIf(uchk_SeguroEps.Checked = False, "000", ucm_SeguroEps.Value.ToString)
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

            ug_detalle.DisplayLayout.Bands(0).AddNew()
            ug_detalle.Rows(ug_detalle.Rows.Count - 1).Cells(0).Value = 1 ' cant
            ug_detalle.Rows(ug_detalle.Rows.Count - 1).Cells(1).Value = articulo.AR_ID  ' codigo id
            ug_detalle.Rows(ug_detalle.Rows.Count - 1).Cells(2).Value = articulo.AR_CODIGO 'codigo
            ug_detalle.Rows(ug_detalle.Rows.Count - 1).Cells(3).Value = articulo.AR_DESCRIPCION  'descripcion
            ug_detalle.Rows(ug_detalle.Rows.Count - 1).Cells(4).Value = articulo.AR_PRECIO_VENTA  'costo
            ug_detalle.Rows(ug_detalle.Rows.Count - 1).Cells(5).Value = True  'CUBRE
            ug_detalle.Rows(ug_detalle.Rows.Count - 1).Cells(6).Value = False  'DEDUCLIBLE
            ug_detalle.Rows(ug_detalle.Rows.Count - 1).Cells(7).Value = descuento 'descuen
            ug_detalle.Rows(ug_detalle.Rows.Count - 1).Cells(8).Value = 0.0 'descuen
            ug_detalle.Rows(ug_detalle.Rows.Count - 1).Cells(9).Value = subtotal_cal 'sub tot
            ug_detalle.Rows(ug_detalle.Rows.Count - 1).Cells(10).Value = igv_cal 'igv
            ug_detalle.Rows(ug_detalle.Rows.Count - 1).Cells(11).Value = total_cal ' total
            ug_detalle.Rows(ug_detalle.Rows.Count - 1).Cells(12).Value = articulo.CA_Consulta ' consul
            ug_detalle.Rows(ug_detalle.Rows.Count - 1).Cells(13).Value = 0 ' comprobante
            ug_detalle.Rows(ug_detalle.Rows.Count - 1).Cells(14).Value = ug_detalle.Rows.Count - 1 ' items
            ug_detalle.Rows(ug_detalle.Rows.Count - 1).Cells(15).Value = 0 ' SIN PAGO
            ug_detalle.UpdateData()
            ug_detalle.Refresh()

        Next
        ' Call Calcular_Totales()
    End Sub

    Private Sub ubt_Quitar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ubt_Quitar.Click
        If ug_detalle.Rows.Count = 0 Then Exit Sub
        If ug_detalle.ActiveRow Is Nothing Then Exit Sub

        If ug_detalle.ActiveRow.Cells(13).Value <> 0 Then
            Call Avisar("El Servicio ya fue Cancelado")
            Exit Sub
        End If

        If Preguntar("Seguro que deseas eliminar el registro?") Then
            'ug_detalle.ActiveRow.Hidden = True
            ug_detalle.ActiveRow.Delete()
            'obeT.TCD_ITEM = ug_detalle.ActiveRow.Cells(11).Value
            'obrT.Delete_TMP(obeT, String.Format("{0}-{1}", Environment.UserName, gStr_Usuario_Sis), Environment.MachineName)

            Call Calcular_Totales()
        End If
        'ug_detalle.Rows(ug_detalle.Rows.Count - 1).Hidden = True


    End Sub

    Private Sub Calcular_Totales()

        txt_SubTotal.Text = ""
        txt_IGV.Text = ""
        txt_Total.Text = ""
        Dim subtotal As Decimal = "0.00"
        'Dim igv As Decimal = "0.00"
        'Dim total As Decimal = "0.00"
        For i As Integer = 0 To ug_detalle.Rows.Count - 1
            ' If ug_detalle.Rows(i).Hidden = False Then
            subtotal = subtotal + ug_detalle.Rows(i).Cells(9).Value
            'igv = igv + ug_detalle.Rows(i).Cells(10).Value
            'total = total + ug_detalle.Rows(i).Cells(11).Value
            ' End If
        Next

        txt_SubTotal.Value = Math.Round(subtotal, 2)
        txt_IGV.Value = Math.Round(subtotal * (IGVTasa / 100), 2)
        txt_Total.Value = Math.Round(CType(txt_SubTotal.Value, Decimal) + CType(txt_IGV.Value, Decimal), 2)

        'txt_SubTotal.Text = Math.Round(subtotal, 2)
        'txt_IGV.Text = Math.Round(igv, 2)
        'txt_Total.Text = Math.Round(total, 2)
    End Sub

    Private Sub Calcular_Copago()

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
                    descuentoSeg = Math.Round(((Precio * Val(txt_PagoVariable.Value)) / 100), 2)
                End If
            Else
                descuentoSeg = 0.0
            End If

            subtotal_cal = Math.Round((ug_detalle.Rows(i).Cells(4).Value * ug_detalle.Rows(i).Cells(0).Value) - descuentoSeg - ug_detalle.Rows(i).Cells(8).Value, 2)
            igv_cal = Math.Round((subtotal_cal * IGVTasa) / 100, 2)
            total_cal = Math.Round(subtotal_cal + igv_cal, 2)

            ug_detalle.Rows(i).Cells("Descuento").Value = descuentoSeg
            ug_detalle.Rows(i).Cells(9).Value = subtotal_cal
            ug_detalle.Rows(i).Cells(10).Value = igv_cal
            ug_detalle.Rows(i).Cells(11).Value = total_cal
        Next

    End Sub

    Private Sub txt_PagoFijo_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_PagoFijo.ValueChanged
        Calcular_Copago()
        Calcular_Totales()

    End Sub

    Private Sub txt_PagoVariable_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_PagoVariable.ValueChanged
        Calcular_Copago()
        Calcular_Totales()
    End Sub

    Private Sub ug_Detalle_AfterRowUpdate(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinGrid.RowEventArgs) Handles ug_detalle.AfterRowUpdate
        'e.Row.Cells("Total").Value = e.Row.Cells("Precio").Value * e.Row.Cells("Cant").Value
        Dim igv_cal As Decimal = "0.00"
        Dim total_cal As Decimal = "0.00"
        Dim subtotal_cal As Decimal = "0.00"
        Dim descuentoSeg As Decimal = "0.00"

        Dim Precio As Decimal = 0.0

        If uchk_SeguroEps.Checked = True Then
            If e.Row.Cells(6).Value = True Then
                descuentoSeg = (e.Row.Cells(4).Value * e.Row.Cells(0).Value) - Val(txt_PagoFijo.Text)
            End If
            If e.Row.Cells(5).Value = True Then
                Precio = IIf(e.Row.Cells(6).Value = False, (e.Row.Cells(4).Value * e.Row.Cells(0).Value), descuentoSeg)
                ' Precio = (e.Row.Cells(4).Value * e.Row.Cells(0).Value) - descuentoSeg
                descuentoSeg = Math.Round(((Precio * Val(txt_PagoVariable.Value)) / 100), 2)
            End If
        Else
            descuentoSeg = 0.0
        End If

        subtotal_cal = Math.Round((e.Row.Cells(4).Value * e.Row.Cells(0).Value) - descuentoSeg - e.Row.Cells(8).Value, 2)
        igv_cal = Math.Round((subtotal_cal * IGVTasa) / 100, 2)
        total_cal = Math.Round(subtotal_cal + igv_cal, 2)

        e.Row.Cells(7).Value = descuentoSeg
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

    '---menu
    Private Sub Tool_Grabar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_Grabar.Click
        If fValida() = False Then Exit Sub
        With obe
            .PR_IDNUMHIST = Val(txt_idHistoria.Value)
            .PR_FECHA = udte_fecha.Value
            .PR_IDMEDICO = uce_Medico.Value
            .PR_IDSEGURO = IIf(uchk_SeguroEps.Checked = True, ucm_SeguroEps.Value, "")
            .PR_IDCLIENTE = Val(txt_IdCliente.Value)
            .PR_COPG_FIJO = Val(txt_PagoFijo.Text)
            .PR_COPG_VARI = Val(txt_PagoVariable.Text)
            .PR_IDEMPRESA = gInt_IdEmpresa
            .PR_IDPAQUETE = txt_idTratamiento.Text

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
            I = obr.Insert(obe, String.Format("{0}-{1}", Environment.UserName, gStr_Usuario_Sis), Environment.MachineName)
            txt_idPresupuesto.Text = I
            If I < 0 Then
                MessageBox.Show("La operación solicitada no ha podido ser realizada", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If
        Else
            obe.PR_ID = txt_idPresupuesto.Text
            Dim I As Integer
            I = obr.Update(obe, String.Format("{0}-{1}", Environment.UserName, gStr_Usuario_Sis), Environment.MachineName)
            If I < 0 Then
                MessageBox.Show("La operación solicitada no ha podido ser realizada", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub

            End If

        End If
        Call Avisar("Listo!")

        Dim obj As New DataTable
        obe.PR_IDEMPRESA = gInt_IdEmpresa
        obr.SEL01(obe, obj)
        ug_Lista.DataSource = obj

        Call Cambiar_Estado_Botones_Tool(ToolS_Mantenimiento)
        Call Tool_Nuevo_Click(sender, e)

    End Sub

    Private Sub Tool_Salir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_Salir.Click
        Me.Close()
    End Sub

    Private Sub Tool_Nuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_Nuevo.Click
        Call Cambiar_Estado_Botones_Tool(ToolS_Mantenimiento)
        Call MostrarTabs(1, utc_Datos, 1)
        Inicializa()
        lNew = True
        uce_tip_doc.Focus()

    End Sub

    Private Sub Tool_Cancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_Cancelar.Click
        Call Cambiar_Estado_Botones_Tool(ToolS_Mantenimiento)
        Call MostrarTabs(0, utc_Datos, 0)
    End Sub

    Private Sub Tool_Editar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_Editar.Click
        If ug_Lista.Rows.Count = 0 Then Exit Sub
        If ug_Lista.ActiveRow Is Nothing Then Exit Sub
        If ug_Lista.ActiveRow.Cells(11).Value <> "PENDIENTE" Then
            Avisar("No se puede Editar un Presupuesto que tiene Pre-Factura")
            Exit Sub
        End If

        lNew = False

        Call Cambiar_Estado_Botones_Tool(ToolS_Mantenimiento)

        txt_idPresupuesto.Text = ug_Lista.ActiveRow.Cells(0).Value
        If ug_Lista.ActiveRow.Cells(6).Value <> "PARTICULAR" Then
            uchk_SeguroEps.Checked = True
            ucm_SeguroEps.Value = ug_Lista.ActiveRow.Cells(1).Value
        Else
            uchk_SeguroEps.Checked = False
        End If
        txt_idClienteC.Value = ug_Lista.ActiveRow.Cells(3).Value
        txt_idHistoria.Value = ug_Lista.ActiveRow.Cells(2).Value
        Dim historiaBL As New BL.AdmisionBL.SG_AD_TB_HISTO_CLINI
        Dim dt_histo_tmp As DataTable = historiaBL.getHistorias_Base_x_Id(txt_idHistoria.Value, gInt_IdEmpresa)
        If dt_histo_tmp.Rows.Count > 0 Then
            txt_Des_Cliente.Text = dt_histo_tmp.Rows(0)("HC_APE_PAT") & " " & dt_histo_tmp.Rows(0)("HC_APE_MAT") & " " & dt_histo_tmp.Rows(0)("HC_NOMBRE1")
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

        uce_Medico.Value = ug_Lista.ActiveRow.Cells(7).Value
        txt_idTratamiento.Text = ug_Lista.ActiveRow.Cells(8).Value

        Dim TBL As New BL.FacturacionBL.SG_FA_TB_PAQUETE_CAB
        Dim TBE As New BE.FacturacionBE.SG_FA_TB_PAQUETE_CAB
        TBE.PC_ID = Val(txt_idTratamiento.Text)
        TBL.SEL02(TBE)
        If TBE.HasRow = True Then
            txt_Tratamiento.Text = TBE.PC_DESCRIPCION
        Else
            txt_Tratamiento.Text = ""
        End If
        TBE = Nothing
        TBL = Nothing


        txt_PagoFijo.Text = ug_Lista.ActiveRow.Cells(9).Value
        txt_PagoVariable.Text = ug_Lista.ActiveRow.Cells(10).Value
        If ug_Lista.ActiveRow.Cells(11).Value = "PENDIENTE" Then
            ucbo_Estado.Value = 1
        Else
            ucbo_Estado.Value = 2
        End If
        udte_fecha.Value = ug_Lista.ActiveRow.Cells(12).Value

        Dim obj As New DataTable
        obeT.DP_ID = ug_Lista.ActiveRow.Cells(0).Value
        obrT.SEL01(obeT, obj)
        ug_detalle.DataSource = obj
     
        Call Calcular_Totales()
        ug_detalle.UpdateData()

        Call MostrarTabs(1, utc_Datos, 1)
        uce_tip_doc.Focus()

    End Sub

    Private Sub Tool_Eliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_Eliminar.Click
        If ug_Lista.Rows.Count = 0 Then Exit Sub
        If ug_Lista.ActiveRow Is Nothing Then Exit Sub
        If ug_Lista.ActiveRow.Cells(11).Value <> "PENDIENTE" Then
            Avisar("No se puede Editar un Presupuesto que tiene Pre-Factura")
            Exit Sub
        End If
        If Preguntar("Seguro de Eliminar?") Then
            obe.PR_ID = ug_Lista.ActiveRow.Cells(0).Value
            If obr.Delete(obe, String.Format("{0}-{1}", Environment.UserName, gStr_Usuario_Sis), Environment.MachineName) < 0 Then
                MessageBox.Show("La operación solicitada no ha podido ser realizada", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                Call Avisar("Listo!")
                Dim obj As New DataTable
                obe.PR_IDEMPRESA = gInt_IdEmpresa
                obr.SEL01(obe, obj)
                ug_Lista.DataSource = obj
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

End Class