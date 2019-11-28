Public Class PR_RE_ConsultaCompro
    Private obr As BL.FacturacionBL.SG_FA_TB_COMPROBANTE_C
    ' Private Paciente As String
    Private Fecha As String

    Public Sub New()
        InitializeComponent()
        obr = New BL.FacturacionBL.SG_FA_TB_COMPROBANTE_C
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

    Private Function fValida() As Boolean
        udte_fechaD.BackColor = Color.White
        udte_fechaH.BackColor = Color.White
        txt_Num_doc_paci.BackColor = Color.White
        If uck_Paciente.Checked = True Then
            pLostfocus(txt_Num_doc_paci, Nothing)
        End If
        If uck_Fecha.Checked = True Then
            If udte_fechaD.Value = Nothing Then udte_fechaD.BackColor = Color.LightPink
            If udte_fechaH.Value = Nothing Then udte_fechaH.BackColor = Color.LightPink
        End If

        If udte_fechaD.BackColor = Color.LightPink Then GoTo Err_Valida
        If udte_fechaH.BackColor = Color.LightPink Then GoTo Err_Valida
        If txt_Num_doc_paci.BackColor = Color.LightPink Then GoTo Err_Valida

        Return True
        Exit Function
Err_Valida:
        MessageBox.Show("Corrija ó Complete los campos errados !!", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Return False

    End Function

    Private Sub AD_RE_ConsultaCitasXfecha_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        txt_Num_doc_paci.ButtonsRight(0).Appearance.Image = My.Resources._104
        txt_Num_doc_paci.BackColor = Color.White
        ubtn_Consultar.Appearance.Image = My.Resources._16__Search_

        obr = New BL.FacturacionBL.SG_FA_TB_COMPROBANTE_C

        Cancelar()

        Me.KeyPreview = True

        udte_fechaD.Focus()
    End Sub

    Private Sub uck_Paciente_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles uck_Paciente.CheckedChanged
        If uck_Paciente.Checked = True Then
            txt_Num_doc_paci.Enabled = True
        Else
            txt_Num_doc_paci.Enabled = False
            txt_Num_doc_paci.Text = ""
        End If
    End Sub

    Private Sub uck_Fecha_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles uck_Fecha.CheckedChanged
        If uck_Fecha.Checked = True Then
            udte_fechaD.Enabled = True
            udte_fechaH.Enabled = True
            Fecha = " and convert(date,CO_FEC_EMI) between '" & udte_fechaD.Text & "' and '" & udte_fechaH.Text & "'"
        Else
            udte_fechaD.Enabled = False
            udte_fechaH.Enabled = False
            udte_fechaD.Value = Now
            udte_fechaH.Value = Now
            Fecha = ""
        End If
    End Sub

    Private Sub Cancelar()
        uck_Paciente.Checked = False
        uck_Fecha.Checked = False

        txt_Num_doc_paci.Enabled = False

        udte_fechaD.Enabled = False
        udte_fechaH.Enabled = False

        udte_fechaD.Value = Now.Date
        udte_fechaH.Value = Now.Date

        txt_Num_doc_paci.Text = ""

        Fecha = ""


        uds_Lista.Rows.Clear()
        ug_Lista.DataSource = uds_Lista

        Call LimpiaGrid(ug_ListaDet, uds_ListaDet)

    End Sub

    Private Sub Tool_Cancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_Cancelar.Click
        Cancelar()
    End Sub

    Private Sub ubtn_Consultar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ubtn_Consultar.Click

        If txt_num_histo.Text.Trim.Length = 0 Then
            Exit Sub
        End If

        If uck_Paciente.Checked = False And uck_Fecha.Checked = False Then
            Avisar("Seleccione una opcion de Consulta")
            Exit Sub
        End If

        Dim obj As New DataTable
        'obr.SEL01(gInt_IdEmpresa, Paciente, Fecha, obj)

        If uck_Fecha.Checked Then
            obj = obr.SEL02(txt_num_histo.Text.Trim, CDate(udte_fechaD.Value).ToShortDateString, CDate(udte_fechaH.Value).ToShortDateString, gInt_IdEmpresa, Val(txt_IDCLIENTE.Text))
        Else
            obj = obr.SEL02(txt_num_histo.Text.Trim, String.Empty, String.Empty, gInt_IdEmpresa, Val(txt_IDCLIENTE.Text))
        End If

        ug_Lista.DataSource = obj

        If ug_Lista.Rows.Count > 0 Then
            Dim obj2 As New DataTable
            obr.SEL01Det(ug_Lista.Rows(0).Cells(0).Value, obj2)
            ug_ListaDet.DataSource = obj2
        Else
            uds_ListaDet.Rows.Clear()
            ug_ListaDet.DataSource = uds_ListaDet
        End If

    End Sub

    Private Sub Tool_Salir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_Salir.Click
        Me.Close()
    End Sub

    Private Sub udte_fechaD_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles udte_fechaD.ValueChanged
        If uck_Fecha.Checked = True Then
            Fecha = " and convert(date,CO_FEC_EMI) between '" & udte_fechaD.Text & "' and '" & udte_fechaH.Text & "'"
        End If
    End Sub

    Private Sub udte_fechaH_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles udte_fechaH.ValueChanged
        If uck_Fecha.Checked = True Then
            Fecha = " and convert(date,CO_FEC_EMI) between '" & udte_fechaD.Text & "' and '" & udte_fechaH.Text & "'"
        End If
    End Sub

    Private Sub ug_Lista_AfterSelectChange(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinGrid.AfterSelectChangeEventArgs) Handles ug_Lista.AfterSelectChange
        If ug_Lista.ActiveRow.IsFilterRow Then Exit Sub
        Dim obj As New DataTable
        obr.SEL01Det(ug_Lista.ActiveRow.Cells(0).Value, obj)
        ug_ListaDet.DataSource = obj
    End Sub

    Private Sub txt_Ruc_ClientesC_EditorButtonClick(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinEditors.EditorButtonEventArgs) Handles txt_Num_doc_paci.EditorButtonClick
        Select Case e.Button.Key
            Case "ayuda"
                'Call Ayuda_Busca_Cliente01()
                Call Ayuda_Busca_Cliente02()
                Call ubtn_Consultar_Click(sender, e)
            Case "editar"

        End Select
    End Sub

    Private Sub txt_Ruc_ClientesC_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_Num_doc_paci.KeyDown
        'If e.KeyCode = Keys.Enter Then
        'Call Buscar_Cliente_Rapido()
        'Call ubtn_Consultar_Click(sender, e)
        'End If

        If e.KeyCode = Keys.F2 Then
            Call Ayuda_Busca_Cliente02()
            Call ubtn_Consultar_Click(sender, e)
        End If

    End Sub

    Private Sub txt_Ruc_ClientesC_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_Num_doc_paci.ValueChanged
        If txt_Num_doc_paci.Text.Trim.Length = 0 Then
            txt_num_histo.Text = String.Empty
            txt_Des_paci.Text = String.Empty
        End If
    End Sub

    'Private Sub Buscar_Cliente_Rapido()
    '    'busca cuando se hace el keydow con el enter, se tiene que ingresar el num de docume del cliente

    '    Dim clienteBL As New BL.FacturacionBL.SG_FA_TB_CLIENTE
    '    Dim clienteBE As New BE.FacturacionBE.SG_FA_TB_CLIENTE

    '    clienteBE.CL_NDOC = txt_Num_doc_paci.Text.Trim
    '    clienteBE.CL_IDEMPRESA = New BE.ContabilidadBE.SG_CO_TB_EMPRESA With {.EM_ID = gInt_IdEmpresa}
    '    clienteBL.get_Cliente_x_Ruc(clienteBE)

    '    If clienteBE.HasRow Then
    '        txt_num_histo.Text = clienteBE.CL_ID

    '        txt_Des_paci.Text = clienteBE.CL_NOMBRE
    '    End If

    '    clienteBE = Nothing
    '    clienteBL = Nothing

    'End Sub

    'Private Sub Ayuda_Busca_Cliente01()
    '    FA_PR_ListaClientesAyuda.Int_Opcion = 1
    '    FA_PR_ListaClientesAyuda.ShowDialog()

    '    Dim matriz As List(Of String) = FA_PR_ListaClientesAyuda.GetLista

    '    If matriz.Count > 0 Then
    '        txt_num_histo.Text = matriz(0)
    '        txt_Num_doc_paci.Text = matriz(1)
    '        txt_Des_paci.Text = matriz(2)
    '    End If

    '    matriz = Nothing

    '    If uck_Paciente.Checked = True Then
    '        Paciente = " and CO_IDCLIENTE='" & Val(txt_num_histo.Text) & "'"
    '    End If


    'End Sub

    Private Sub Ayuda_Busca_Cliente02()

        'FR_PR_ListaPacientesAyuda.Int_Opcion = 1
        FR_PR_ListaPacientesAyuda.ShowDialog()

        Dim matriz As List(Of String) = FR_PR_ListaPacientesAyuda.GetLista

        If matriz.Count > 0 Then
            txt_IDCLIENTE.Text = matriz(1)
            txt_num_histo.Text = matriz(0)
            txt_Num_doc_paci.Text = matriz(4)
            txt_Des_paci.Text = matriz(2)
        End If

        matriz = Nothing


    End Sub

End Class