Public Class FA_PR_BuscarPaciente
    'Private obe As BE.AdmisionBE.SG_AD_TB_HISTO_CLINI
    'Private obr As BL.AdmisionBL.SG_AD_TB_HISTO_CLINI

    Dim lista As New List(Of String)
    Public medico As String
    'Dim Docu As String
    'Dim apemat As String
    'Dim apecas As String
    'Dim nombre As String
    'Dim historia As String

    'Public Sub New()
    '    InitializeComponent()
    '    obe = New BE.AdmisionBE.SG_AD_TB_HISTO_CLINI
    '    obr = New BL.AdmisionBL.SG_AD_TB_HISTO_CLINI
    'End Sub

    Public Function GetLista() As List(Of String)
        Return lista
    End Function
    Private Sub pKeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Me.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Return) Then
            SendKeys.Send("{TAB}")
            e.Handled = True
        End If
    End Sub
    Private Sub FA_PR_BuscarPaciente_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim medicosBL As New BL.AdmisionBL.SG_AD_TB_MEDICO
        uce_Medico.DataSource = medicosBL.get_Medicos(1)
        uce_Medico.ValueMember = "ME_CODIGO"
        uce_Medico.DisplayMember = "NOMBRES"
        medicosBL = Nothing

        uce_Medico.Value = medico
        udte_fecha.Value = Now
        Call Cargar_Agenda(udte_fecha.Value, uce_Medico.Value)
        'Call Formatear_Grilla_Selector(ug_Listado)

        'Dim historiaBL As New BL.AdmisionBL.SG_AD_TB_HISTO_CLINI
        'ug_Listado.DataSource = historiaBL.get_Historias_Ayuda(gInt_IdEmpresa)
        'historiaBL = Nothing
        Me.KeyPreview = True
    End Sub
    Public Sub Cargar_Agenda(ByVal fecha As String, ByVal Medico As String)

        Dim programacionBL As New BL.AdmisionBL.SG_AD_TB_PROGRAMA_CITA
        'Dim dt_prog As DataTable
        ug_intervalos.DataSource = programacionBL.get_Citas_x_FechayDoc(CDate(fecha).ToShortDateString, Medico)
        programacionBL = Nothing

        'Call LimpiaGrid(ug_intervalos, uds_intervalos)
    End Sub

    Private Sub ug_intervalos_DoubleClickRow(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinGrid.DoubleClickRowEventArgs) Handles ug_intervalos.DoubleClickRow
        If ug_intervalos.ActiveRow.IsFilterRow Then Exit Sub
        If ug_intervalos.Rows.Count > 0 Then Tool_Aceptar_Click(sender, e)
    End Sub

    Private Sub ug_intervalos_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles ug_intervalos.KeyDown
        Try
            If ug_intervalos.Rows.Count > 0 Then
                If ug_intervalos.ActiveRow.Index = 0 Then
                    If e.KeyCode = Keys.Up Then
                        udte_fecha.Focus()
                    End If
                End If
                If e.KeyCode = Keys.Enter Then
                    Tool_Aceptar_Click(sender, e)
                End If

            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Tool_Aceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_Aceptar.Click
        lista.Clear()

        If ug_intervalos.Rows.Count > 0 Then
            If Not ug_intervalos.ActiveRow Is Nothing Then
                lista.Add(ug_intervalos.ActiveRow.Cells(0).Value.ToString)
                lista.Add(ug_intervalos.ActiveRow.Cells(1).Value.ToString)
                lista.Add(ug_intervalos.ActiveRow.Cells(2).Value.ToString)
                lista.Add(ug_intervalos.ActiveRow.Cells(3).Value.ToString)
                lista.Add(ug_intervalos.ActiveRow.Cells(4).Value.ToString)
                lista.Add(ug_intervalos.ActiveRow.Cells(5).Value.ToString)
                lista.Add(ug_intervalos.ActiveRow.Cells(6).Value.ToString)
                lista.Add(ug_intervalos.ActiveRow.Cells(7).Value.ToString)
                lista.Add(ug_intervalos.ActiveRow.Cells(8).Value.ToString)
            End If
        End If

        '  bol_Aceptar = True
        Me.Close()
    End Sub

    Private Sub Tool_Consultar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_Consultar.Click
        Call Cargar_Agenda(udte_fecha.Value, uce_Medico.Value)
    End Sub

    Private Sub Tool_Salir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_Salir.Click
        Me.Close()
    End Sub

    Private Sub Tool_Detalle_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_Detalle.Click
        With FA_PR_DetalleCuenta
            Call Limpiar_Controls_InGroupox(.ugb_Datos)
            .uds_detalle.Rows.Clear()
            .ug_detalle.DataSource = .uds_detalle
            .udte_fecha.Value = udte_fecha.Value
            .txt_idCuenta.Text = ug_intervalos.ActiveRow.Cells(10).Value
            .txt_idprogramacion.Value = ug_intervalos.ActiveRow.Cells(8).Value
            .txt_idCita.Text = ug_intervalos.ActiveRow.Cells(0).Value

            Dim documentosBL As New BL.AdmisionBL.SG_AD_TB_TIP_DOC_PER
            .uce_tip_doc.DataSource = documentosBL.getTiposDocs(1)
            .uce_tip_doc.DisplayMember = "TD_ABREVIATURA"
            .uce_tip_doc.ValueMember = "TD_ID"
            documentosBL = Nothing
            .uce_tip_doc.SelectedIndex = 0

            Dim clienteBL As New BL.AdmisionBL.SG_AD_TB_HISTO_CLINI
            Dim clienteBE As New BE.AdmisionBE.SG_AD_TB_HISTO_CLINI

            clienteBE.HC_NDOC = ug_intervalos.ActiveRow.Cells(6).Value
            clienteBE.HC_IDEMPRESA = 1
            clienteBE.HC_TDOC = ug_intervalos.ActiveRow.Cells(9).Value

            clienteBL.get_Historias_x_Doc(clienteBE)

            If clienteBE.HasRow Then
                .txt_IdCliente.Text = clienteBE.HC_IDCLIENTE
                .txt_Des_Cliente.Text = clienteBE.HC_NOMBRE1
                .uce_tip_doc.Value = clienteBE.HC_TDOC
                .txt_ruc_cliente.Text = clienteBE.HC_NDOC
            End If
            clienteBL = Nothing
            clienteBE = Nothing

            'Dim CuentaBL As New BL.AdmisionBL.SG_AD_TB_CUENTA_CAB
            'Dim CuentaBE As New BE.AdmisionBE.SG_AD_TB_CUENTA_CAB

            'CuentaBE.CC_IDCITA = ug_intervalos.ActiveRow.Cells(0).Value
            'CuentaBL.SEL01(CuentaBE)
            'If CuentaBE.HasRow Then
            '    .txt_idCuenta.Text = CuentaBE.CC_ID
            'End If
            'CuentaBL = Nothing
            'CuentaBE = Nothing
            '.uck_HoraIngreso.Enabled = False
            'llenar los datos de seguro Y LA CUENTA

            Dim CitaBL As New BL.AdmisionBL.SG_AD_TB_CITA_MED
            Dim CitaBE As New BE.AdmisionBE.SG_AD_TB_CITA_MED

            CitaBE.CM_ID = ug_intervalos.ActiveRow.Cells(0).Value
            CitaBL.SEL01(CitaBE)
            If CitaBE.HasRow Then
                .txt_Observacion.Text = CitaBE.CM_OBSERVACIONES

                Dim obrT As New BL.AdmisionBL.SG_AD_TB_CUENTA_CAB
                Dim obeT As New BE.AdmisionBE.TMP_SG_AD_TB_CUENTA_DET
                ' MsgBox(Val(.txt_idCita.Text))
                Dim obj As New DataTable
                obeT.TCD_IDCAB = Val(.txt_idCuenta.Text)
                obeT.TCD_IDCITA = Val(.txt_idCita.Text)
                obrT.SEL_TMP01(obeT, obj)
                .ug_detalle.DataSource = obj
                obrT = Nothing
                obeT = Nothing
            End If
            CitaBL = Nothing
            CitaBE = Nothing
            .ShowDialog()

        End With
    End Sub
End Class