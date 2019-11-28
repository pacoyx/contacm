Public Class AD_PR_AtencionxServicio
    Private obe As BE.AdmisionBE.SG_AD_TB_CITA_MED
    Private obr As BL.AdmisionBL.SG_AD_TB_CITA_MED
    Private obeT As BE.AdmisionBE.TMP_SG_AD_TB_CUENTA_DET
    Private obrT As BL.AdmisionBL.SG_AD_TB_CUENTA_CAB

    Public lNew As Boolean = False
    Public Opcion As Integer
    Dim IGVTasa As Double
    Public ArticuloAnt As Integer
    Public Sub New()
        InitializeComponent()
        obe = New BE.AdmisionBE.SG_AD_TB_CITA_MED
        obr = New BL.AdmisionBL.SG_AD_TB_CITA_MED
        obeT = New BE.AdmisionBE.TMP_SG_AD_TB_CUENTA_DET
        obrT = New BL.AdmisionBL.SG_AD_TB_CUENTA_CAB
    End Sub
    Private Sub pKeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Me.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Return) Then
            SendKeys.Send("{TAB}")
            e.Handled = True
        End If
    End Sub

    Private Sub pLostfocus(ByVal sender As Object, ByVal e As System.EventArgs) ' Handles txt_DesCorto.LostFocus, txt_Descripcion.LostFocus
        sender.BackColor = Color.White
        If sender.Text.Trim.Length < 1 Then
            sender.BackColor = Color.LightPink
        End If
    End Sub
    Private Sub pKeyPressNumeroDe(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_DesctoOtro.KeyPress
        e.KeyChar = fKeyPress(e.KeyChar, sender.Text, 2)
        e.Handled = (e.KeyChar = "")
    End Sub

    Private Function fValida() As Boolean
        pLostfocus(txt_idHistoria, Nothing)
        pLostfocus(ucb_Articulo, Nothing)
        If Val(txt_idHistoria.Text) = 0 Then
            txt_idHistoria.BackColor = Color.LightPink
        End If
        uce_Medico.BackColor = Color.White
        If uce_Medico.Text <> "" And uce_Medico.SelectedIndex = -1 Then
            uce_Medico.BackColor = Color.LightPink
        End If
        'val el articulo
        'If uchk_GenerarCta.Checked = True Then
        '    ucm_Tipo.BackColor = Color.White
        '    If ucm_Tipo.SelectedIndex = -1 Then ucm_Tipo.BackColor = Color.LightPink
        '    If ucm_Tipo.BackColor = Color.LightPink Then GoTo Err_Valida
        'End If
        If ucb_Articulo.BackColor = Color.LightPink Then GoTo Err_Valida
        If txt_idHistoria.BackColor = Color.LightPink Then GoTo Err_Valida
        If uce_Medico.BackColor = Color.LightPink Then GoTo Err_Valida

        'If OPCION = 3 Then

        uck_HoraLlegada.BackColor = Color.Transparent
        If uck_HoraLlegada.Checked = False Then uck_HoraLlegada.BackColor = Color.LightPink
        If uck_HoraLlegada.BackColor = Color.LightPink Then GoTo Err_Valida


        ume_HoraLLegada.BackColor = Color.White
        If ume_HoraLLegada.Value.ToString = Nothing Then ume_HoraLLegada.BackColor = Color.LightPink
        If ume_HoraLLegada.BackColor = Color.LightPink Then GoTo Err_Valida
        'End If

        Return True
        Exit Function
Err_Valida:
        MessageBox.Show("Corrija ó Complete los campos errados !!", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Return False
    End Function

    Private Sub AD_PR_Atencion_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txt_ruc_cliente.ButtonsRight(0).Appearance.Image = My.Resources._104
        ubtn_listaEco.Appearance.Image = My.Resources._16__Bullets_and_numbering_
        '  txt_NumDoc.ButtonsRight(0).Appearance.Image = My.Resources._16__Page_number_
        txt_ruc_cliente.BackColor = Color.White
        txt_idHistoria.BackColor = Color.White

        Call Cargar_Tasas_Impuestos()

        obe = New BE.AdmisionBE.SG_AD_TB_CITA_MED
        obr = New BL.AdmisionBL.SG_AD_TB_CITA_MED
        obeT = New BE.AdmisionBE.TMP_SG_AD_TB_CUENTA_DET
        obrT = New BL.AdmisionBL.SG_AD_TB_CUENTA_CAB

        Me.KeyPreview = True

        ume_HoraLLegada.Focus()
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
        'FA_PR_ListaClientesAyuda.Int_Opcion = 1
        AD_PR_BuscaPaciente.ShowDialog()

        Dim matriz As List(Of String) = AD_PR_BuscaPaciente.GetLista

        'txt_ruc_cliente.ButtonsRight("editar").Enabled = False

        If matriz.Count > 0 Then
            txt_IdCliente.Text = matriz(1)
            txt_idHistoria.Text = matriz(0)
            txt_ruc_cliente.Text = matriz(9)
            uce_tip_doc.Value = matriz(8)
            txt_Des_Cliente.Text = matriz(2)
            udte_fechaNac.Value = matriz(10)
            txt_Edad.Value = Int(DateDiff("m", matriz(10), Date.Now) / 12)
            'txt_ruc_cliente.ButtonsRight("editar").Enabled = True

            Call Buscar_Cuenta()
        End If

    End Sub

    Public Sub Buscar_Cuenta()

        Dim Cuenta2BL As New BL.AdmisionBL.SG_AD_TB_CUENTA_CAB
        Dim Cuenta2BE As New BE.AdmisionBE.SG_AD_TB_CUENTA_CAB

        Cuenta2BE.CC_IDNUM_HIST = Val(txt_idHistoria.Text)
        Cuenta2BE.CC_FECHA = udte_fecha.Value
        Cuenta2BL.SEL02(Cuenta2BE)
        If Cuenta2BE.HasRow Then
            txt_IdCuenta.Text = Cuenta2BE.CC_ID
            '.txt_ruc_cliente.Enabled = False
            '.uce_tip_doc.Enabled = False
            txt_idTipoSeg.Text = Cuenta2BE.CC_IDTIPO_ATENC

            If Cuenta2BE.CC_IDTIPO_ATENC = 2 Then
                ucm_SeguroEps.Value = Cuenta2BE.CC_IDSEGURO
                txt_PagoFijo.Text = Cuenta2BE.CC_SIT_COPG_FIJO
                txt_PagoVariable.Text = Cuenta2BE.CC_SIT_COPG_VARI

                ulbl_DatosCuenta.Text = "La Cuenta Es " & IIf(Cuenta2BE.CC_IDTIPO_ORI = 1, "AMBULATORIA", "de HOSPITALIZACION") & ", Por Seguro de la Fecha: " & Cuenta2BE.CC_FECHA
            End If


            Dim ArticulosBL As New BL.FacturacionBL.SG_FA_TB_ARTICULO
            ucb_Articulo.DataSource = ArticulosBL.get_Articulos_Ayuda03(gInt_IdEmpresa, ucm_SeguroEps.Value, Cuenta2BE.CC_IDTIPO_ATENC, IGVTasa, "025")
            ucb_Articulo.DisplayMember = "AR_DESCRIPCION"
            ucb_Articulo.ValueMember = "AR_ID"
            ArticulosBL = Nothing

            ucb_Articulo.SelectedIndex = -1
            'idcuenta
            'idSeguro
        Else
            ulbl_DatosCuenta.Text = ""
            txt_idTipoSeg.Text = 1
            txt_IdCuenta.Text = ""
            txt_PagoFijo.Text = ""
            txt_PagoVariable.Text = ""

            Dim ArticulosBL As New BL.FacturacionBL.SG_FA_TB_ARTICULO
            ucb_Articulo.DataSource = ArticulosBL.get_Articulos_Ayuda03(gInt_IdEmpresa, ucm_SeguroEps.Value, 1, IGVTasa, "025")
            ucb_Articulo.DisplayMember = "AR_DESCRIPCION"
            ucb_Articulo.ValueMember = "AR_ID"
            ArticulosBL = Nothing
            ucb_Articulo.SelectedIndex = -1
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
            udte_fechaNac.Value = clienteBE.HC_FNAC
            txt_Edad.Value = Int(DateDiff("m", clienteBE.HC_FNAC, Date.Now) / 12)
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
                        txt_Edad.Value = Int(DateDiff("m", clienteBE.HC_FNAC, Date.Now) / 12)
                    End If
                End If
            End If

        End If
        Buscar_Cuenta()
        clienteBE = Nothing
        clienteBL = Nothing

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

    Private Sub Tool_Grabar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_Grabar.Click
        If fValida() = False Then Exit Sub
inicio:
        With obe
            .CM_IDPROGRAMACION = txt_idprogramacion.Value
            .CM_IDNUMHIST = Val(txt_idHistoria.Value)
            .CM_FECHACITA = udte_fecha.Value
            .CM_NUM_ORDEN = txt_Orden.Value
            .CM_HORA_PROG = txt_Hora.Value
            .CM_HORA_ATENC = IIf(uck_HoraLlegada.Checked = True, ume_HoraLLegada.Value, "")
            .CM_HORA_SAL = IIf(uck_HoraSalida.Checked = True, ume_horaSalida.Value, "")

            .CM_OBSERVACIONES = txt_Observacion.Text
            .CM_EDAD_ATENC = Val(txt_Edad.Value)
            .CM_IDTIPO_ATENC = Val(txt_idTipoSeg.Text)
            .CM_IDSEGURO = IIf(Val(txt_idTipoSeg.Text) = 2, ucm_SeguroEps.Value, "")

            .CM_IDCLIENTE = Val(txt_IdCliente.Value)
            .CM_USUARIO = String.Format("{0}-{1}", Environment.UserName, gStr_Usuario_Sis)
            .CM_PC = Environment.MachineName
            .CM_IDEMPRESA = gInt_IdEmpresa
            .CM_HORA_ING = IIf(uck_HoraIngreso.Checked = True, ume_horaIngreso.Value, "")
            .CM_IDMEDICODERI = uce_Medico.Value
            .CM_Anamnesis = 0
        End With

        Dim obeC As New BE.AdmisionBE.SG_AD_TB_CUENTA_CAB
        With obeC
            .CC_IDNUM_HIST = Val(txt_idHistoria.Value)
            .CC_IDCLIENTE = Val(txt_IdCliente.Value)
            .CC_IDTIPO_ATENC = Val(txt_idTipoSeg.Text)
            .CC_IDSEGURO = IIf(Val(txt_idTipoSeg.Text) = 2, ucm_SeguroEps.Value, "")
            .CC_FECHA = udte_fecha.Value
            .CC_USUARIO = String.Format("{0}-{1}", Environment.UserName, gStr_Usuario_Sis)
            .CC_TERMINAL = Environment.MachineName
            .CC_IDEMPRESA = gInt_IdEmpresa
            .CC_IDPREFAC = 0

            .CC_SIT_COD_EPS = ""
            .CC_SIT_COD_ASEG = ""
            .CC_SIT_FEC_AUTORI = Date.Now
            .CC_SIT_COD_COBER = 0
            .CC_SIT_COPG_FIJO = Val(txt_PagoFijo.Text)
            .CC_SIT_COPG_VARI = Val(txt_PagoVariable.Text)
            .CC_SIT_COD_GENE = ""
            .CC_INGRESO_MANUAL = 0
            .CC_TIPOAFILIACION = 0
            .CC_SIT_MONTO_IMP = 0
        End With

        Dim obeT As New BE.AdmisionBE.TMP_SG_AD_TB_CUENTA_DET
        With obeT
            .TCD_IDARTICULO = ucb_Articulo.Value
            .TCD_CANT = 1
            .TCD_TOTAL = txt_Total.Value
            .TCD_PRECIO = txt_Precio.Value
            .TCD_DESCUENTO = txt_Descuento.Value
            .TCD_SUB_TOTAL = txt_SubTotal.Value
            .TCD_IGV = txt_IGV.Value
            .TCD_IDempresa = gInt_IdEmpresa

            .TCD_SINPAGO = 0
            .TCD_DSCTO_OTRO = Val(txt_DesctoOtro.Text)

            If Val(txt_idTipoSeg.Text) = 2 Then
                .TCD_SEG_CUBRE = IIf(uck_AtencionP.Checked = False, 1, 0)
            Else
                .TCD_SEG_CUBRE = 0
            End If
            '.TCD_SEG_CUBRE = IIf(Val(txt_idTipoSeg.Text) = 2, 1, 0)

            .TCD_DEDUCIBLE = 0

        End With

        If lNew Then

            Dim I As Integer
            I = obr.Insert_XSer(obe, obeC, obeT, String.Format("{0}-{1}", Environment.UserName, gStr_Usuario_Sis), Environment.MachineName, Val(txt_IdCuenta.Text))
            txt_idCita.Text = I
            If I = -2 Then
                MessageBox.Show("El Numero De Orden Ya a sido registrado, Se usara el Siguiente Numero", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txt_Orden.Value = Val(txt_Orden.Value) + 1
                GoTo inicio

                'Exit Sub
            Else
                If I < 0 Then
                    MessageBox.Show("La operación solicitada no ha podido ser realizada", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Exit Sub
                End If
            End If
        Else
            obe.CM_ID = txt_idCita.Text

            Dim I As Integer
            I = obr.Update_XSer(obe, obeC, obeT, String.Format("{0}-{1}", Environment.UserName, gStr_Usuario_Sis), Environment.MachineName, Val(txt_IdCuenta.Text), Opcion, ArticuloAnt)
            If I < 0 Then
                MessageBox.Show("La operación solicitada no ha podido ser realizada", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            Else
                If txt_IdCuenta.Text = "" Then txt_idCita.Text = I
            End If

        End If
            Call Avisar("Listo!")
            Me.Close()

    End Sub

    Private Sub uck_HoraLlegada_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles uck_HoraLlegada.CheckedChanged
        If uck_HoraLlegada.Checked = True Then
            ume_HoraLLegada.Value = Date.Now.TimeOfDay.ToString
            ume_HoraLLegada.Enabled = True
        Else
            ume_HoraLLegada.Value = ""
            ume_HoraLLegada.Enabled = False
        End If
    End Sub

    Private Sub uck_HoraIngreso_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles uck_HoraIngreso.CheckedChanged
        If uck_HoraIngreso.Checked = True Then
            ume_horaIngreso.Value = Date.Now.TimeOfDay.ToString
            ume_horaIngreso.Enabled = True
        Else
            ume_horaIngreso.Value = ""
            ume_horaIngreso.Enabled = False
        End If
    End Sub

    Private Sub ucb_Articulo_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ucb_Articulo.ValueChanged
        txt_Precio.Text = "0.00"
        txt_Descuento.Text = "0.00"
        txt_Total.Text = "0.00"
        txt_SubTotal.Text = "0.00"
        txt_IGV.Text = "0.00"
        Dim artiBL As New BL.FacturacionBL.SG_FA_TB_ARTICULO
        Dim artiBE As New BE.FacturacionBE.SG_FA_TB_ARTICULO

        artiBE.AR_IDEMPRESA = gInt_IdEmpresa
        artiBE.AR_IDFAMILIA = "025"
        artiBE.AR_ID = ucb_Articulo.Value

        If Val(txt_idTipoSeg.Text) = 2 And uck_AtencionP.Checked = True Then
            artiBL.get_Articulos_Ayuda03_XID(artiBE, ucm_SeguroEps.Value, 1, IGVTasa)
        Else
            artiBL.get_Articulos_Ayuda03_XID(artiBE, ucm_SeguroEps.Value, Val(txt_idTipoSeg.Text), IGVTasa)
        End If
        If artiBE.HasRow Then
            txt_Precio.Text = Math.Round(artiBE.AR_PRECIO_VENTA, 2)

            If Val(txt_idTipoSeg.Text) = 2 And uck_AtencionP.Checked = False Then
                txt_Descuento.Text = Math.Round((artiBE.AR_PRECIO_VENTA * Val(txt_PagoVariable.Value)) / 100, 2)
            Else
                txt_Descuento.Text = "0.00"
            End If
            txt_SubTotal.Value = Math.Round(artiBE.AR_PRECIO_VENTA - txt_Descuento.Value - Val(txt_DesctoOtro.Text), 2)
            txt_IGV.Value = Math.Round((CType(txt_SubTotal.Value, Decimal) * IGVTasa) / 100, 2)
            txt_Total.Value = Math.Round(CType(txt_SubTotal.Value, Decimal) + CType(txt_IGV.Value, Decimal), 2)
            'idcuenta
            'idSeguro
        End If

    End Sub

    Private Sub txt_DesctoOtro_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_DesctoOtro.ValueChanged
        txt_SubTotal.Text = Math.Round(CType(txt_Precio.Value, Decimal) - CType(txt_Descuento.Value, Decimal) - CType(txt_DesctoOtro.Value, Decimal), 2)
        txt_IGV.Text = Math.Round((CType(txt_SubTotal.Value, Decimal) * IGVTasa) / 100, 2)
        txt_Total.Text = Math.Round(CType(txt_SubTotal.Value, Decimal) + CType(txt_IGV.Value, Decimal), 2)
    End Sub

    Private Sub uck_AtencionP_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles uck_AtencionP.CheckedChanged
        If Val(txt_idTipoSeg.Text) = 2 Then
            Dim idart As Integer = ucb_Articulo.Value
            txt_Precio.Text = "0.00"
            txt_Descuento.Text = "0.00"
            txt_Total.Text = "0.00"
            txt_SubTotal.Text = "0.00"
            txt_IGV.Text = "0.00"

            If uck_AtencionP.Checked = True Then

                Dim ArticulosBL As New BL.FacturacionBL.SG_FA_TB_ARTICULO
                ucb_Articulo.DataSource = ArticulosBL.get_Articulos_Ayuda03(gInt_IdEmpresa, ucm_SeguroEps.Value, 1, IGVTasa, "025")
                ucb_Articulo.DisplayMember = "AR_DESCRIPCION"
                ucb_Articulo.ValueMember = "AR_ID"
                ArticulosBL = Nothing
            Else
                Dim ArticulosBL As New BL.FacturacionBL.SG_FA_TB_ARTICULO
                ucb_Articulo.DataSource = ArticulosBL.get_Articulos_Ayuda03(gInt_IdEmpresa, ucm_SeguroEps.Value, Val(txt_idTipoSeg.Text), IGVTasa, "025")
                ucb_Articulo.DisplayMember = "AR_DESCRIPCION"
                ucb_Articulo.ValueMember = "AR_ID"
                ArticulosBL = Nothing
            End If

            ucb_Articulo.SelectedIndex = -1
            ucb_Articulo.Value = idart
        End If

        'Dim artiBL As New BL.FacturacionBL.SG_FA_TB_ARTICULO
        'Dim artiBE As New BE.FacturacionBE.SG_FA_TB_ARTICULO

        'artiBE.AR_IDEMPRESA = gInt_IdEmpresa
        'artiBE.AR_IDFAMILIA = "025"
        'artiBE.AR_ID = ucb_Articulo.Value

        'If Val(txt_idTipoSeg.Text) = 2 And uck_AtencionP.Checked = True Then
        '    artiBL.get_Articulos_Ayuda03_XID(artiBE, ucm_SeguroEps.Value, 1, IGVTasa)
        'Else
        '    artiBL.get_Articulos_Ayuda03_XID(artiBE, ucm_SeguroEps.Value, Val(txt_idTipoSeg.Text), IGVTasa)
        'End If
        'If artiBE.HasRow Then
        '    txt_Precio.Text = Math.Round(artiBE.AR_PRECIO_VENTA, 2)

        '    If Val(txt_idTipoSeg.Text) = 2 And uck_AtencionP.Checked = False Then
        '        txt_Descuento.Text = Math.Round((artiBE.AR_PRECIO_VENTA * Val(txt_PagoVariable.Value)) / 100, 2)
        '    Else
        '        txt_Descuento.Text = "0.00"
        '    End If
        '    txt_SubTotal.Value = Math.Round(artiBE.AR_PRECIO_VENTA - txt_Descuento.Value - Val(txt_DesctoOtro.Text), 2)
        '    txt_IGV.Value = Math.Round((CType(txt_SubTotal.Value, Decimal) * IGVTasa) / 100, 2)
        '    txt_Total.Value = Math.Round(CType(txt_SubTotal.Value, Decimal) + CType(txt_IGV.Value, Decimal), 2)
        '    'idcuenta
        '    'idSeguro
        'End If

    End Sub

    Private Sub uck_HoraSalida_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles uck_HoraSalida.CheckedChanged
        If uck_HoraSalida.Checked = True Then
            ume_horaSalida.Value = Date.Now.TimeOfDay.ToString
            ume_horaSalida.Enabled = True
        Else
            ume_horaSalida.Value = ""
            ume_horaSalida.Enabled = False
        End If
    End Sub

    Private Sub ubtn_listaEco_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ubtn_listaEco.Click
        Dim obre As New BL.AdmisionBL.SG_AD_TB_Reportes
        Dim obj As New DataTable
        obre.SEL05(txt_idHistoria.Text, obj)
        If obj.Rows.Count > 0 Then
            LimpiaGrid(AD_PR_ListaHisEco.ug_Lista, AD_PR_ListaHisEco.uds_Lista)
            AD_PR_ListaHisEco.ug_Lista.DataSource = obj
            AD_PR_ListaHisEco.ShowDialog()
        Else
            MessageBox.Show("No tiene registros para mostrar", ".:. Aviso .:.", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
        
    End Sub
End Class