Public Class LO_RE_Costo
    Private obe As BE.LogisticaBE.SG_LO_TB_SALDOS_C
    Private obr As BL.LogisticaBL.SG_LO_TB_SALDOS_C
    Public Sub New()
        InitializeComponent()
        obe = New BE.LogisticaBE.SG_LO_TB_SALDOS_C
        obr = New BL.LogisticaBL.SG_LO_TB_SALDOS_C
    End Sub

    Private Sub pKeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If e.KeyChar = Convert.ToChar(Keys.Return) Then
            SendKeys.Send("{TAB}")
            e.Handled = True
        End If
    End Sub

    Private Sub pKeyPressNumero(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_año.KeyPress
        e.KeyChar = fKeyPress(e.KeyChar, sender.Text, 1)
        e.Handled = (e.KeyChar = "")
    End Sub

    Private Sub Tool_Consultar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_Consultar.Click
        Call LimpiaGrid(ug_data, uds_Lista)
        If txt_año.Text.Length <> 4 Then Exit Sub
        If uchk_Motivo.Checked = False And uce_Almacen.Value = Nothing Then Exit Sub
        If uchk_Motivo.Checked = True And ucbo_Motivo.Value = Nothing Then Exit Sub
        If gInt_IdEmpresa = 7 Then
            ug_data.DataSource = obr.Costo(IIf(uchk_Motivo.Checked = False, uce_Almacen.Value, ""), uce_Mes.Value, Val(txt_año.Text), IIf(uchk_Motivo.Checked = True, ucbo_Motivo.Value, 0))
        Else
            ug_data.DataSource = obr.Costo2(uce_Almacen.Value, uce_Mes.Value, Val(txt_año.Text), gInt_IdEmpresa)
        End If

        ug_data.UpdateData()
    End Sub

    Private Sub LO_RE_InventarioValoriz_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        obe = New BE.LogisticaBE.SG_LO_TB_SALDOS_C
        obr = New BL.LogisticaBL.SG_LO_TB_SALDOS_C
        Me.KeyPreview = True

        Dim AlcBL As New BL.LogisticaBL.SG_LO_TB_ALMACEN
        uce_Almacen.DataSource = AlcBL.get_almacen_2(gInt_IdEmpresa, gInt_IdUsuario_Sis)
        uce_Almacen.DisplayMember = "AL_DESCRIPCION"
        uce_Almacen.ValueMember = "AL_ID"
        AlcBL = Nothing

        Dim motivBL As New BL.LogisticaBL.SG_LO_TB_MOTIVO
        Dim obeM As New BE.LogisticaBE.SG_LO_TB_MOTIVO
        obeM.MT_IDEMPRESA = gInt_IdEmpresa
        ucbo_Motivo.DataSource = motivBL.SEL03(obeM)
        ucbo_Motivo.DisplayMember = "MT_NOMBRE"
        ucbo_Motivo.ValueMember = "MT_ID"
        motivBL = Nothing

        uchk_Motivo.Checked = False
        ucbo_Motivo.Enabled = False
        uce_Almacen.Enabled = True

        Call LimpiaGrid(ug_data, uds_Lista)
        txt_año.Text = Now.Year
        uce_Mes.Value = IIf(Now.Month < 10, "0" & Now.Month, Now.Month)

        If gInt_IdEmpresa = 7 Then
            ucbo_Motivo.Visible = True
            uchk_Motivo.Visible = True
        Else
            ucbo_Motivo.Visible = False
            uchk_Motivo.Visible = False
        End If
    End Sub

    Private Sub Tool_Exportar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_Exportar.Click
        Dim str_nombre_arc_exc As String = "Costos " & Date.Now.Day & Date.Now.Month & Date.Now.Year & Date.Now.Hour & Date.Now.Minute & Date.Now.Second & ".xls"
        Try
            Me.Cursor = Cursors.WaitCursor
            uge_detra.Export(ug_data, str_nombre_arc_exc)

            Process.Start(str_nombre_arc_exc)
            Me.Cursor = Cursors.Default
        Catch ex As Exception
            Call Avisar("Ocurrio un error.")
            Me.Cursor = Cursors.Default
        End Try
    End Sub

    Private Sub uce_Mes_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles uce_Mes.ValueChanged
        Tool_Consultar_Click(Nothing, Nothing)
    End Sub

    Private Sub Tool_Salir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_Salir.Click
        Me.Close()
    End Sub

    Private Sub pFormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        obe = Nothing
        obr = Nothing
        e.Cancel = False
    End Sub

    Private Sub txt_año_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_año.LostFocus
        Tool_Consultar_Click(Nothing, Nothing)
    End Sub

    Private Sub uce_Almacen_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles uce_Almacen.ValueChanged
        Tool_Consultar_Click(Nothing, Nothing)
    End Sub

    Private Sub uchk_Motivo_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles uchk_Motivo.CheckedChanged
        If uchk_Motivo.Checked = True Then
            ucbo_Motivo.Enabled = True
            uce_Almacen.Enabled = False
        Else
            ucbo_Motivo.Enabled = False
            uce_Almacen.Enabled = True
        End If
    End Sub

    Private Sub ucbo_Motivo_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ucbo_Motivo.ValueChanged
        Tool_Consultar_Click(Nothing, Nothing)
    End Sub
End Class