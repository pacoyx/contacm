Imports Infragistics.Win.UltraWinGrid
Public Class PR_PR_Pre_Facturacion
    Private obe As BE.FacturacionBE.SG_FA_TB_PRE_FACTURA_CAB
    Private obr As BL.FacturacionBL.SG_FA_TB_PRE_FACTURA_CAB

    Private obeT As BE.AdmisionBE.TMP_SG_AD_TB_CUENTA_DET
    Private obrT As BL.AdmisionBL.SG_AD_TB_CUENTA_CAB
    Private obeC As BE.AdmisionBE.SG_AD_TB_CUENTA_CAB

    Public lNew As Boolean = False
    Public OPCION As Integer
    Dim IGVTasa As Double
    Public IDMEDICO As String

    Public Sub New()
        InitializeComponent()
        obe = New BE.FacturacionBE.SG_FA_TB_PRE_FACTURA_CAB
        obr = New BL.FacturacionBL.SG_FA_TB_PRE_FACTURA_CAB
        obeT = New BE.AdmisionBE.TMP_SG_AD_TB_CUENTA_DET
        obrT = New BL.AdmisionBL.SG_AD_TB_CUENTA_CAB
        obeC = New BE.AdmisionBE.SG_AD_TB_CUENTA_CAB
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
    Private Sub pKeyPressNumero(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_IdCuenta.KeyPress
        e.KeyChar = fKeyPress(e.KeyChar, sender.Text, 1)
        e.Handled = (e.KeyChar = "")
    End Sub
    Private Function fValida() As Boolean
        pLostfocus(txt_ruc_cliente, Nothing)
        pLostfocus(uce_Medico, Nothing)

        If uce_Tratamiento.Text <> "" And uce_Tratamiento.SelectedIndex = -1 Then
            uce_Tratamiento.BackColor = Color.LightPink
        End If

        If uce_Medico.BackColor = Color.LightPink Then GoTo Err_Valida
        If txt_ruc_cliente.BackColor = Color.LightPink Then GoTo Err_Valida

        Return True
        Exit Function
Err_Valida:
        MessageBox.Show("Corrija ó Complete los campos errados !!", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Return False
    End Function

    Private Sub Inicializa()
        Call Limpiar_Controls_InGroupox(ugb_Datos)
        txt_ruc_cliente.BackColor = Color.White
        uce_Medico.BackColor = Color.White
        ucbo_Estado.Value = 1

        txt_IdCuenta.ReadOnly = True
        uchk_GenerarCta.Enabled = True
        uce_Medico.Enabled = False
        ' ucm_Tipo.Enabled = False
        uce_Tratamiento.Enabled = False
        uce_tip_doc.Enabled = False
        txt_ruc_cliente.Enabled = False

        uce_tip_doc.SelectedIndex = 0
        ucm_Tipo.Value = 3
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

        Dim OrigenBL As New BL.AdmisionBL.SG_AD_TB_ORIGEN_ATENC
        ucm_Tipo.DataSource = OrigenBL.getOrigen()
        ucm_Tipo.DisplayMember = "OA_DESCRIPCION"
        ucm_Tipo.ValueMember = "OA_ID"
        OrigenBL = Nothing
        ucm_Tipo.SelectedIndex = 0

        Dim ArticulosBL As New BL.FacturacionBL.SG_FA_TB_ARTICULO
        uce_Tratamiento.DataSource = ArticulosBL.get_Articulos_Ayuda04(gInt_IdEmpresa)
        uce_Tratamiento.DisplayMember = "AR_DESCRIPCION"
        uce_Tratamiento.ValueMember = "AR_ID"
        ArticulosBL = Nothing

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

    Private Sub AD_PR_Atencion_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Cargar_Combos()
        Inicializa()

        Call Inicializar_Estado_Botones_Tool(ToolS_Mantenimiento)
        Call MostrarTabs(0, utc_Datos, 0)

        txt_ruc_cliente.ButtonsRight(0).Appearance.Image = My.Resources._104
        txt_IdCuenta.ButtonsRight(0).Appearance.Image = My.Resources._104

        obe = New BE.FacturacionBE.SG_FA_TB_PRE_FACTURA_CAB
        obr = New BL.FacturacionBL.SG_FA_TB_PRE_FACTURA_CAB
        obeT = New BE.AdmisionBE.TMP_SG_AD_TB_CUENTA_DET
        obrT = New BL.AdmisionBL.SG_AD_TB_CUENTA_CAB
        obeC = New BE.AdmisionBE.SG_AD_TB_CUENTA_CAB

        Cargar_Tasas_Impuestos()

        Me.KeyPreview = True

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
            'txt_ruc_cliente.ButtonsRight("editar").Enabled = True
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
        Else
            uce_Medico.Enabled = True
            Avisar("El Paciente no existe!")
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

    Private Sub uchk_GenerarCta_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles uchk_GenerarCta.CheckedChanged
        If uchk_GenerarCta.Checked = True Then
            txt_IdCuenta.ReadOnly = False
        Else
            txt_IdCuenta.Text = ""
            txt_IdCuenta.ReadOnly = True
        End If
    End Sub

    '--menu
    Private Sub Tool_Grabar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_Grabar.Click
        If fValida() = False Then Exit Sub
        With obe
            .PF_IDCUENTA = Val(txt_IdCuenta.Value)
            .PF_IDTIPO_ATENC = 1
            .PF_IDNUMHIST = Val(txt_idHistoria.Value)
            .PF_IDCLIENTE = Val(txt_IdCliente.Value)
            .PF_IDMEDICO = uce_Medico.Value
            .PF_IDEMPRESA = gInt_IdEmpresa
            .PF_FECHA = udte_fecha.Value
            .PF_USUARIO = String.Format("{0}-{1}", Environment.UserName, gStr_Usuario_Sis)
            .PF_TERMINAL = Environment.MachineName
            .PF_Tratamiento = uce_Tratamiento.Text
        End With

        If lNew Then
            Dim I As Integer
            I = obr.Insert_Presup(obe, obeC, String.Format("{0}-{1}", Environment.UserName, gStr_Usuario_Sis), Environment.MachineName, uce_Tratamiento.Value, IGVTasa)
            txt_IdCuenta.Text = I
            If I < 0 Then
                MessageBox.Show("La operación solicitada no ha podido ser realizada", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If
        Else
            obe.PF_ID = Val(txt_idPreFactura.Text)
            Dim I As Integer
            I = obr.Update_Presup(obe, obeC, String.Format("{0}-{1}", Environment.UserName, gStr_Usuario_Sis), Environment.MachineName, uce_Tratamiento.Value, IGVTasa)
            If I < 0 Then
                MessageBox.Show("La operación solicitada no ha podido ser realizada", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If
        End If
        Call Avisar("Listo!")

        ' Call Cambiar_Estado_Botones_Tool(ToolS_Mantenimiento)
        Call Tool_Cancelar_Click(sender, e)

    End Sub

    Private Sub Tool_Salir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_Salir.Click
        Me.Close()
    End Sub

    Private Sub Tool_Nuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_Nuevo.Click
        'If txt_idPreFactura.Text <> "" Then
        '    Avisar("Registro ya Tiene Pre-Factura")
        '    Exit Sub
        'End If

        Call Cambiar_Estado_Botones_Tool(ToolS_Mantenimiento)
        Inicializa()
        lNew = True

        txt_IdCuenta.ReadOnly = True
        uchk_GenerarCta.Enabled = False

        uce_Medico.Enabled = True
        '    ucm_Tipo.Enabled = True
        uce_Tratamiento.Enabled = True
        uce_tip_doc.Enabled = True
        txt_ruc_cliente.Enabled = True

        uce_tip_doc.Focus()

    End Sub

    Private Sub Tool_Cancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_Cancelar.Click
        Call Cambiar_Estado_Botones_Tool(ToolS_Mantenimiento)
        Inicializa()
        lNew = True
        '  Call MostrarTabs(0, utc_Datos, 0)
    End Sub

    Private Sub Tool_Editar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_Editar.Click
        If txt_idPreFactura.Text = "" Then
            Avisar("Registro no Tiene Pre-Factura")
            Exit Sub
        End If
        If ucbo_Estado.Value = 2 Then
            Avisar("La Pre-Factura ya esta Facturada, no Puede Editar")
            Exit Sub
        End If

        lNew = False

        Call Cambiar_Estado_Botones_Tool(ToolS_Mantenimiento)

        uchk_GenerarCta.Enabled = False
        uce_Medico.Enabled = True
        uce_Tratamiento.Enabled = True
        uce_tip_doc.Enabled = True
        txt_ruc_cliente.Enabled = True


        uce_tip_doc.Focus()

    End Sub

    Private Sub Tool_Eliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_Eliminar.Click
        If txt_idPreFactura.Text = "" Then
            Avisar("Registro no Tiene Pre-Factura")
            Exit Sub
        End If
        If ucbo_Estado.Value = 2 Then
            Avisar("La Pre-Factura ya esta Facturada, no Puede Eliminar")
            Exit Sub
        End If

        If Preguntar("Seguro de Eliminar?") Then
            obe.PF_ID = Val(txt_idPreFactura.Text)
            obe.PF_IDCUENTA = Val(txt_IdCuenta.Text)
            obe.PF_IDPRESUPUESTO = 0
            Dim i As Integer = 0
            i = obr.Delete(obe, String.Format("{0}-{1}", Environment.UserName, gStr_Usuario_Sis), Environment.MachineName)

            If i < 0 Then
                MessageBox.Show("La operación solicitada no ha podido ser realizada", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            ElseIf i = 1 Then
                MessageBox.Show("No puede Eliminar una cuenta Cancelada", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                Call Avisar("Listo!")

                Call Cambiar_Estado_Botones_Tool(ToolS_Mantenimiento)
                Call Tool_Cancelar_Click(sender, e)
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

    Private Sub Cargar_PreFacturacion(ByVal id_preFac As Integer)
        obe.PF_ID = id_preFac
        obe.HasRow = False
        obr.SEL01(obe)
        If obe.HasRow Then
            With obe
                'If tipo = 2 Then
                '    txt_IdCuenta.Text = .PF_IDCUENTA
                '    'buscar cuenta
                '    obeC.CC_ID = Val(txt_IdCuenta.Text)
                '    obrT.SEL04(obeC)
                '    If obeC.HasRow Then
                '        With obeC
                '            ucm_Tipo.Value = .CC_IDTIPO_ORI
                '        End With
                '    End If
                'End If

                txt_idHistoria.Value = .PF_IDNUMHIST
                ucbo_Estado.Value = .PF_ESTADO_PRE_F
                udte_fecha.Value = .PF_FECHA
                uce_Medico.Value = .PF_IDMEDICO
                uce_Tratamiento.Text = .PF_Tratamiento

                Dim historiaBL As New BL.AdmisionBL.SG_AD_TB_HISTO_CLINI
                Dim dt_histo_tmp As DataTable = historiaBL.getHistorias_Base_x_Id(txt_idHistoria.Value, gInt_IdEmpresa)
                If dt_histo_tmp.Rows.Count > 0 Then
                    txt_Des_Cliente.Text = dt_histo_tmp.Rows(0)("HC_APE_PAT") & " " & dt_histo_tmp.Rows(0)("HC_APE_MAT") & " " & dt_histo_tmp.Rows(0)("HC_APE_CASADA") & " " & dt_histo_tmp.Rows(0)("HC_NOMBRE1") & " " & dt_histo_tmp.Rows(0)("HC_NOMBRE2")
                    txt_ruc_cliente.Text = dt_histo_tmp.Rows(0)("HC_NDOC")
                    txt_IdCliente.Value = dt_histo_tmp.Rows(0)("HC_IDCLIENTE")
                    uce_tip_doc.Value = dt_histo_tmp.Rows(0)("HC_TDOC")
                End If
            End With
        Else
            Avisar("Pre-Factura no Existe!")
            Inicializa()
        End If
    End Sub

    'Cuenta
    Private Sub Ayuda_Anexo_Cuenta()
        ' FA_PR_ListaClientesAyuda.Int_Opcion = 1
        PR_PR_ListaCuentas.ShowDialog()

        Dim matriz As List(Of String) = PR_PR_ListaCuentas.GetLista

        If matriz.Count > 0 Then
            txt_IdCuenta.Text = matriz(0)
            ucm_Tipo.Value = matriz(1)
            txt_idHistoria.Value = matriz(3)
            txt_idPreFactura.Text = matriz(9)

            uce_Medico.Value = matriz(18)
            ' uce_Tratamiento.Text = "Ambulatorio"
            Dim historiaBL As New BL.AdmisionBL.SG_AD_TB_HISTO_CLINI
            Dim dt_histo_tmp As DataTable = historiaBL.getHistorias_Base_x_Id(txt_idHistoria.Value, gInt_IdEmpresa)
            If dt_histo_tmp.Rows.Count > 0 Then
                txt_Des_Cliente.Text = dt_histo_tmp.Rows(0)("HC_APE_PAT") & " " & dt_histo_tmp.Rows(0)("HC_APE_MAT") & " " & dt_histo_tmp.Rows(0)("HC_APE_CASADA") & " " & dt_histo_tmp.Rows(0)("HC_NOMBRE1") & " " & dt_histo_tmp.Rows(0)("HC_NOMBRE2")
                txt_ruc_cliente.Text = dt_histo_tmp.Rows(0)("HC_NDOC")
                txt_IdCliente.Value = dt_histo_tmp.Rows(0)("HC_IDCLIENTE")
                uce_tip_doc.Value = dt_histo_tmp.Rows(0)("HC_TDOC")
            End If

            Cargar_PreFacturacion(Val(txt_idPreFactura.Text))

        End If

    End Sub

    Private Sub Buscar_Cuenta()
        obeC.CC_ID = Val(txt_IdCuenta.Text)
        obeC.HasRow = False
        obrT.SEL04(obeC)
        If obeC.HasRow Then
            With obeC
                If .CC_IDPREFAC = 0 Or .CC_IDTIPO_ORI <> 3 Then
                    Avisar("Cuenta no Existe!")
                    Exit Sub
                End If

                ucm_Tipo.Value = .CC_IDTIPO_ORI
                txt_idHistoria.Value = .CC_IDNUM_HIST

                txt_idPreFactura.Text = IIf(.CC_IDPREFAC = 0, "", .CC_IDPREFAC)
                uce_Medico.Value = .CC_MEDICO
                'uce_Tratamiento.Text = "Ambulatorio"
                Dim historiaBL As New BL.AdmisionBL.SG_AD_TB_HISTO_CLINI
                Dim dt_histo_tmp As DataTable = historiaBL.getHistorias_Base_x_Id(txt_idHistoria.Value, gInt_IdEmpresa)
                If dt_histo_tmp.Rows.Count > 0 Then
                    txt_Des_Cliente.Text = dt_histo_tmp.Rows(0)("HC_APE_PAT") & " " & dt_histo_tmp.Rows(0)("HC_APE_MAT") & " " & dt_histo_tmp.Rows(0)("HC_APE_CASADA") & " " & dt_histo_tmp.Rows(0)("HC_NOMBRE1") & " " & dt_histo_tmp.Rows(0)("HC_NOMBRE2")
                    txt_ruc_cliente.Text = dt_histo_tmp.Rows(0)("HC_NDOC")
                    txt_IdCliente.Value = dt_histo_tmp.Rows(0)("HC_IDCLIENTE")
                    uce_tip_doc.Value = dt_histo_tmp.Rows(0)("HC_TDOC")
                End If
                uchk_GenerarCta.Enabled = True
                Cargar_PreFacturacion(Val(txt_idPreFactura.Text))

            End With
        Else
            Avisar("Cuenta no Existe!")
            Inicializa()
        End If

    End Sub

    Private Sub txt_IdCuenta_EditorButtonClick(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinEditors.EditorButtonEventArgs) Handles txt_IdCuenta.EditorButtonClick
        Select Case e.Button.Key
            Case "ayuda"
                Call Ayuda_Anexo_Cuenta()
            Case "editar"

        End Select
    End Sub
    'Private Sub txt_IdCuenta_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_IdCuenta.ValueChanged
    '    If txt_IdCuenta.Text.Trim.Length = 0 Then
    '        'txt_IdCliente.Text = String.Empty
    '        'txt_Des_Cliente.Text = String.Empty
    '    End If
    'End Sub
    Private Sub txt_IdCuenta_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_IdCuenta.KeyDown
        If e.KeyCode = Keys.Enter Or e.KeyCode = Keys.Tab Then
            Call Buscar_Cuenta()
        End If

        If e.KeyCode = Keys.F2 Then Call Ayuda_Anexo_Cuenta()
    End Sub

End Class