Public Class AD_RE_ConsultaEcografia
    Private obr As BL.AdmisionBL.SG_AD_TB_Reportes
    Private Paciente As String
    Private Servicio As String
    Private Medico As String
    Public Sub New()
        InitializeComponent()
        obr = New BL.AdmisionBL.SG_AD_TB_Reportes
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
    '    Private Function fValida() As Boolean

    '        udte_fechaD.BackColor = Color.White
    '        udte_fechaH.BackColor = Color.White
    '        If udte_fechaD.Value = Nothing Then udte_fechaD.BackColor = Color.LightPink
    '        If udte_fechaH.Value = Nothing Then udte_fechaH.BackColor = Color.LightPink

    '        If udte_fechaD.BackColor = Color.LightPink Then GoTo Err_Valida
    '        If udte_fechaH.BackColor = Color.LightPink Then GoTo Err_Valida

    '        Return True
    '        Exit Function
    'Err_Valida:
    '        MessageBox.Show("Corrija ó Complete los campos errados !!", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error)
    '        Return False

    '    End Function


    Private Sub AD_RE_ConsultaEcografia_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        obr = New BL.AdmisionBL.SG_AD_TB_Reportes
        Cancelar()
        Me.KeyPreview = True

    End Sub

    Private Sub Cancelar()
        ucb_Campos.SelectedIndex = 0
        txt_Filtro.Text = ""

        LimpiaGrid(ug_Lista, uds_Lista)
    End Sub

    Private Sub ubtn_Consultar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ubtn_Consultar.Click

        If txt_Filtro.Text.Trim.Length = 0 Then
            Avisar("Ingrese un dato para filtrar")
            txt_Filtro.Focus()
            Exit Sub
        End If

        Dim obj As New DataTable
        obr.SEL04(obj, txt_Filtro.Text, ucb_Campos.Value)
        ug_Lista.DataSource = obj
    End Sub

    Private Sub txt_Filtro_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_Filtro.KeyDown
        If e.KeyCode = Keys.Enter Then
            ubtn_Consultar_Click(sender, e)
        End If
    End Sub

    Private Sub ug_Lista_InitializeRow(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinGrid.InitializeRowEventArgs) Handles ug_Lista.InitializeRow
        If e.Row.Cells("CD_SEG_CUBRE").Value = 1 Then
            e.Row.Appearance.BackColor = Color.FromArgb(251, 174, 164)
            'Else
            '    --e.Row.Appearance.BackColor = Color.LightYellow
        End If

    End Sub
    '    Private Sub Tool_Imprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_Imprimir.Click
    '        Me.Cursor = Cursors.WaitCursor
    '        Dim obj As New DataTable
    '        obr.SEL01(udte_fechaD.Text, udte_fechaH.Text, gInt_IdEmpresa, Paciente, Servicio, Medico, obj)

    '        Dim nom_reporte As String = "SG_AD_04.RPT"
    '        Dim crystalBL As New LR.ClsReporte
    '        Dim dt_data As New DataTable
    '        dt_data = obj

    '        crystalBL.Muestra_Reporte(gStr_RutaRep & "\" & nom_reporte, dt_data, "")


    '        crystalBL = Nothing
    '        ' reportesBL = Nothing

    '        Me.Cursor = Cursors.Default
    '    End Sub

    'Private Sub Tool_Salir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    Me.Close()
    'End Sub

End Class