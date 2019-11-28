Imports Infragistics.Win.UltraWinGrid
Public Class AD_PR_AtencionTopico
    Private obe As BE.AdmisionBE.SG_AD_TB_TOPICO
    Private obeD As BE.AdmisionBE.SG_AD_TB_TOPICO_DET
    Private obr As BL.AdmisionBL.SG_AD_TB_TOPICO

    Public lNew As Boolean = False
    Dim IGVTasa As Double
    Dim TipoCambio As Double
    Public Sub New()
        InitializeComponent()
        obe = New BE.AdmisionBE.SG_AD_TB_TOPICO
        obr = New BL.AdmisionBL.SG_AD_TB_TOPICO
        obeD = New BE.AdmisionBE.SG_AD_TB_TOPICO_DET
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

    Private Sub Obtener_TipoCambio_dia()

        Dim rpta As String = String.Empty
        Dim paraetrosBL As New BL.FacturacionBL.SG_FA_TB_PARAMETROS
        Dim paraetrosBE As New BE.FacturacionBE.SG_FA_TB_PARAMETROS

        paraetrosBE.AD_IDEMPRESA = New BE.ContabilidadBE.SG_CO_TB_EMPRESA With {.EM_ID = gInt_IdEmpresa}
        paraetrosBE.AD_TIPO = "SISTE"
        paraetrosBE.AD_NOMBRE = "TC"

        rpta = paraetrosBL.get_Valor(paraetrosBE)

        If rpta = "F" Then

            Dim tipocambioBL As New BL.FacturacionBL.SG_FA_TB_PARIDAD
            Dim tipocambioBE As New BE.FacturacionBE.SG_FA_TB_PARIDAD

            tipocambioBE.PA_IDEMPRESA = New BE.ContabilidadBE.SG_CO_TB_EMPRESA With {.EM_ID = 1}
            'tipocambioBE.PA_FECHA = CDate(udte_fec_emi.Value).ToShortDateString
            Dim dt_tc As DataTable = tipocambioBL.get_Pariedad_x_Ultimo(tipocambioBE)

            If dt_tc.Rows.Count > 0 Then
                TipoCambio = dt_tc.Rows(0)("PA_VENTA")
            Else
                TipoCambio = 0
            End If

            dt_tc = Nothing

            tipocambioBE = Nothing
            tipocambioBL = Nothing

        Else ' rpta = "C"

            Dim tipocamBL As New BL.ContabilidadBL.SG_CO_TB_TIPOCAMBIO
            Dim tipocamBE As New BE.ContabilidadBE.SG_CO_TB_TIPOCAMBIO

            tipocamBE.TC_IDEMPRESA = New BE.ContabilidadBE.SG_CO_TB_EMPRESA With {.EM_ID = gInt_IdEmpresa}
            tipocamBE.TC_FECHA = CDate(udte_fecha.Value).ToShortDateString
            tipocamBE.TC_IDMONEDA = New BE.ContabilidadBE.SG_CO_TB_MONEDA With {.MO_CODIGO = 2}
            tipocamBL.getTipoCambio(tipocamBE)

            TipoCambio = tipocamBE.TC_VENTA

            tipocamBE = Nothing
            tipocamBL = Nothing

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
    Private Function fValida() As Boolean
        ' pLostfocus(txt_idHistoria, Nothing)
        txt_idHistoria.BackColor = Color.White
        If Val(txt_idHistoria.Text) = 0 And txt_Des_Cliente.Text = "" Then
            txt_idHistoria.BackColor = Color.LightPink
        End If
     
        If txt_idHistoria.BackColor = Color.LightPink Then GoTo Err_Valida

        ume_HoraLLegada.BackColor = Color.White
        If ume_HoraLLegada.Value.ToString = Nothing Then ume_HoraLLegada.BackColor = Color.LightPink

        If ume_HoraLLegada.BackColor = Color.LightPink Then GoTo Err_Valida

        Return True
        Exit Function
Err_Valida:
        MessageBox.Show("Corrija ó Complete los campos errados !!", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Return False
    End Function

    Private Sub AD_PR_AtencionTopico_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txt_ruc_cliente.ButtonsRight(0).Appearance.Image = My.Resources._104
        'txt_NumDoc.ButtonsRight(0).Appearance.Image = My.Resources._16__Page_number_
        txt_ruc_cliente.BackColor = Color.White
        txt_idHistoria.BackColor = Color.White

        Calcular_Totales()
        Cargar_Tasas_Impuestos()

        obe = New BE.AdmisionBE.SG_AD_TB_TOPICO
        obr = New BL.AdmisionBL.SG_AD_TB_TOPICO
        obeD = New BE.AdmisionBE.SG_AD_TB_TOPICO_DET

        Me.KeyPreview = True

        ume_HoraLLegada.Focus()
        ubt_Agregar.Appearance.Image = My.Resources._16__Plus_
        ubt_Quitar.Appearance.Image = My.Resources._132

        Obtener_TipoCambio_dia()
    End Sub

    Private Sub Calcular_Totales()
        txt_SubTotal.Text = ""
        txt_IGV.Text = ""
        txt_Total.Text = ""
        Dim subtotal As Decimal = "0.00"
        Dim igv As Decimal = "0.00"
        Dim total As Decimal = "0.00"

        For i As Integer = 0 To ug_detalle.Rows.Count - 1
            If ug_detalle.Rows(i).Hidden = False Then
                subtotal += Val(ug_detalle.Rows(i).Cells(5).Value.ToString)
                igv += Val(ug_detalle.Rows(i).Cells(6).Value.ToString)
                total += Val(ug_detalle.Rows(i).Cells(7).Value.ToString)
            End If
        Next
        txt_SubTotal.Text = Math.Round(subtotal, 2)
        txt_IGV.Text = Math.Round(igv, 2)
        txt_Total.Text = Math.Round(total, 2)
    End Sub

    Private Sub Tool_Grabar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_Grabar.Click
        If fValida() = False Then Exit Sub
        If ug_detalle.Rows.Count = 0 Then
            Avisar("Falta agregar Items")
            Exit Sub
        End If
        With obe
            .TO_ID = Val(txt_idCita_Topico.Text)
            .TO_IDNUMHIST = Val(txt_idHistoria.Value)
            .TO_FECHA = udte_fecha.Value
            .TO_NUM_ORDEN = txt_Orden.Value
            .TO_ESTADO = 1
            .TO_HORA_ATENC = ume_HoraLLegada.Text
            .TO_OBSERVACION = txt_Observacion.Text
            .TO_IDTURNO = ucbo_Turno.Value
            .TO_IDEMPRESA = gInt_IdEmpresa
            .TO_TOTAL = Val(txt_Total.Text)
            .TO_MEDICODER = uce_Medico.Value
            .TO_PERSONAS = txt_Des_Cliente.Text
        End With

        Dim ls_detalles As New List(Of BE.AdmisionBE.SG_AD_TB_TOPICO_DET)

        ug_detalle.UpdateData()
        Dim obeTc As BE.AdmisionBE.SG_AD_TB_TOPICO_DET

        For i As Integer = 0 To ug_detalle.Rows.Count - 1
            obeTc = New BE.AdmisionBE.SG_AD_TB_TOPICO_DET
            With obeTc
                .DT_CANT = ug_detalle.Rows(i).Cells(0).Value
                .DT_IDARTICULO = ug_detalle.Rows(i).Cells(1).Value
                .DT_PRECIO = ug_detalle.Rows(i).Cells(4).Value
                .DT_SUBTOTAL = ug_detalle.Rows(i).Cells(5).Value
                .DT_IGV = ug_detalle.Rows(i).Cells(6).Value
                .DT_TOTAL = ug_detalle.Rows(i).Cells(7).Value
            End With
            ls_detalles.Add(obeTc)
        Next


        If lNew Then
            Dim I As Integer
            I = obr.Insert(obe, String.Format("{0}-{1}", Environment.UserName, gStr_Usuario_Sis), Environment.MachineName, ls_detalles)
            If I < 0 Then
                MessageBox.Show("La operación solicitada no ha podido ser realizada", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If
        Else
            Dim I As Integer
            I = obr.Update(obe, String.Format("{0}-{1}", Environment.UserName, gStr_Usuario_Sis), Environment.MachineName, ls_detalles)
            If I < 0 Then
                MessageBox.Show("La operación solicitada no ha podido ser realizada", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If

        End If
        Call Avisar("Listo!")
        Me.Close()

    End Sub

    Private Sub Tool_Salir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_Salir.Click
        Me.Close()
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
    Private Sub Ayuda_Anexo_Cab()
        ' FA_PR_ListaClientesAyuda.Int_Opcion = 1
        AD_PR_BuscaPaciente.ShowDialog()

        Dim matriz As List(Of String) = AD_PR_BuscaPaciente.GetLista

        'txt_ruc_cliente.ButtonsRight("editar").Enabled = False

        If matriz.Count > 0 Then
            txt_IdCliente.Text = matriz(1)
            txt_idHistoria.Text = matriz(0)
            Format(Val(txt_idHistoria.Text), "0000000000#")
            txt_ruc_cliente.Text = matriz(9)
            uce_tip_doc.Value = matriz(8)
            txt_Des_Cliente.Text = matriz(2)
            udte_fechaNac.Value = matriz(10)
            'txt_Edad.Value = Int(DateDiff("m", matriz(10), Date.Now) / 12)
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
            Format(Val(txt_idHistoria.Text), "0000000000#")
            txt_Des_Cliente.Text = clienteBE.HC_NOMBRE1
            udte_fechaNac.Value = clienteBE.HC_FNAC
            'txt_Edad.Value = Int(DateDiff("m", clienteBE.HC_FNAC, Date.Now) / 12)
            'uce_tip_doc.Value = clienteBE.HC_TDOC
            'txt_ruc_cliente.Text = clienteBE.HC_NDOC

            '  ubtn_agregar.Focus()
        Else

            If Preguntar("El cliente no existe!, Desea Crearlo?") Then

                FA_PR_IngClienteRapido.str_num_ruc = txt_ruc_cliente.Text.Trim
                'FA_PR_IngClienteRapido.str_ = uce_tip_doc.Value
                FA_PR_IngClienteRapido.ShowDialog()
                If FA_PR_IngClienteRapido.bol_Grabo Then
                    clienteBE.HC_NDOC = FA_PR_IngClienteRapido.txt_num_doc.Text.Trim
                    clienteBE.HC_IDEMPRESA = gInt_IdEmpresa
                    clienteBE.HC_TDOC = FA_PR_IngClienteRapido.uce_TipoDoc.Value
                    clienteBL.get_Historias_x_Doc(clienteBE)
                    If clienteBE.HasRow Then
                        txt_IdCliente.Text = clienteBE.HC_IDCLIENTE
                        txt_idHistoria.Text = clienteBE.HC_NUM_HIST
                        txt_Des_Cliente.Text = clienteBE.HC_NOMBRE1
                        uce_tip_doc.Value = clienteBE.HC_TDOC
                        txt_ruc_cliente.Text = clienteBE.HC_NDOC
                        udte_fechaNac.Value = clienteBE.HC_FNAC
                        'txt_Edad.Value = Int(DateDiff("m", clienteBE.HC_FNAC, Date.Now) / 12)
                    End If
                End If
            End If

        End If

        clienteBE = Nothing
        clienteBL = Nothing

    End Sub

    Private Sub ubt_Agregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ubt_Agregar.Click

        Dim igv_cal As Decimal = "0.00"
        Dim total_cal As Decimal = "0.00"
        Dim subtotal_cal As Decimal = "0.00"
        Dim descuento As Decimal = "0.00"
        'AD_PR_ListaArticulosSeg.  poner el check de atencion particular n false 
       
        AD_PR_ListaArticulosSeg.idSeguro = "000"
        AD_PR_ListaArticulosSeg.idMedico = "000"
        '  AD_PR_ListaArticulosSeg.idSeguro = IIf(uchk_SeguroEps.Checked = False, "000", ucm_SeguroEps.Value.ToString)
        AD_PR_ListaArticulosSeg.IGVTas = IGVTasa
        AD_PR_ListaArticulosSeg.ShowDialog()

        Dim matriz As List(Of BE.FacturacionBE.SG_FA_TB_ARTICULO) = AD_PR_ListaArticulosSeg.GetLista

        For Each articulo As BE.FacturacionBE.SG_FA_TB_ARTICULO In matriz

            subtotal_cal = Math.Round(articulo.AR_PRECIO_VENTA - descuento, 2)
            igv_cal = Math.Round((subtotal_cal * IGVTasa) / 100, 2)
            total_cal = Math.Round(subtotal_cal + igv_cal, 2)

            ug_detalle.DisplayLayout.Bands(0).AddNew()
            ug_detalle.Rows(ug_detalle.Rows.Count - 1).Cells(0).Value = 1  ' cant
            ug_detalle.Rows(ug_detalle.Rows.Count - 1).Cells(1).Value = articulo.AR_ID  ' codigo id
            ug_detalle.Rows(ug_detalle.Rows.Count - 1).Cells(2).Value = articulo.AR_CODIGO 'codigo
            ug_detalle.Rows(ug_detalle.Rows.Count - 1).Cells(3).Value = articulo.AR_DESCRIPCION  'descripcion
            ug_detalle.Rows(ug_detalle.Rows.Count - 1).Cells(4).Value = articulo.AR_PRECIO_VENTA  'costo
            ug_detalle.Rows(ug_detalle.Rows.Count - 1).Cells(5).Value = subtotal_cal 'sub tot
            ug_detalle.Rows(ug_detalle.Rows.Count - 1).Cells(6).Value = igv_cal 'igv
            ug_detalle.Rows(ug_detalle.Rows.Count - 1).Cells(7).Value = total_cal ' total
            ug_detalle.UpdateData()
            ug_detalle.Refresh()
         
        Next
    End Sub

    Private Sub ubt_Quitar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ubt_Quitar.Click
        If ug_detalle.Rows.Count = 0 Then Exit Sub
        If ug_detalle.ActiveRow Is Nothing Then Exit Sub

        If Preguntar("Seguro que deseas eliminar el registro?") Then
            'ug_detalle.ActiveRow.Hidden = True
            ug_detalle.ActiveRow.Delete()
            Call Calcular_Totales()
        End If
      

    End Sub

    Private Sub ug_Detalle_AfterRowUpdate(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinGrid.RowEventArgs) Handles ug_detalle.AfterRowUpdate
        'e.Row.Cells("Total").Value = e.Row.Cells("Precio").Value * e.Row.Cells("Cant").Value
        Dim igv_cal As Decimal = "0.00"
        Dim total_cal As Decimal = "0.00"
        Dim subtotal_cal As Decimal = "0.00"

        subtotal_cal = Math.Round(e.Row.Cells(4).Value * e.Row.Cells(0).Value, 2)
        igv_cal = Math.Round((subtotal_cal * IGVTasa) / 100, 2)
        total_cal = Math.Round(subtotal_cal + igv_cal, 2)

        e.Row.Cells(5).Value = subtotal_cal
        e.Row.Cells(6).Value = igv_cal
        e.Row.Cells(7).Value = total_cal

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

End Class