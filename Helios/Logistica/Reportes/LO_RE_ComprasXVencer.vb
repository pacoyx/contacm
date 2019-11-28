Public Class LO_RE_ComprasXVencer
    Private obr As BL.LogisticaBL.SG_LO_TB_COMPROBANTES_CAB
    Dim IGVTasa As Double
    Public Sub New()
        InitializeComponent()
        obr = New BL.LogisticaBL.SG_LO_TB_COMPROBANTES_CAB
    End Sub
    Private Sub pKeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If e.KeyChar = Convert.ToChar(Keys.Return) Then
            SendKeys.Send("{TAB}")
            e.Handled = True
        End If
    End Sub
    Private Sub Inicializa()
        Call LimpiaGrid(ug_data, uds_Lista)
        uck_Totalizar.Checked = False
        udtp_FechaFin.Value = Now
        udtp_fechaInicio.Value = Now
    End Sub

    Private Sub LO_RE_ComprasXVencer_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        obr = New BL.LogisticaBL.SG_LO_TB_COMPROBANTES_CAB
        Me.KeyPreview = True

        Call Inicializa()
    End Sub

    Private Sub Tool_Consultar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_Consultar.Click
        Call LimpiaGrid(ug_data, uds_Lista)
        ug_data.DataSource = obr.get_ComprobanteCredito_xFecha(IIf(uck_Totalizar.Checked = False, 1, 0), udtp_fechaInicio.Text, udtp_FechaFin.Text, gInt_IdEmpresa)
        ug_data.UpdateData()
    End Sub
    Private Sub Tool_Salir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_Salir.Click
        Me.Close()
    End Sub
    Private Sub pFormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        obr = Nothing
        e.Cancel = False
    End Sub

    Private Sub Tool_Imprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_Imprimir.Click
        Me.Cursor = Cursors.WaitCursor
        Dim obj As New DataTable

        Dim nom_reporte As String = "SG_LO_10.RPT"
        Dim crystalBL As New LR.ClsReporte
        Dim dt_data As New DataTable
        dt_data = obr.get_ComprobanteCredito_xFecha(IIf(uck_Totalizar.Checked = False, 1, 0), udtp_fechaInicio.Text, udtp_FechaFin.Text, gInt_IdEmpresa)

        crystalBL.Muestra_Reporte(gStr_RutaRep & "\" & nom_reporte, dt_data, "", "FechaI;" & udtp_fechaInicio.Text, "FechaF;" & udtp_FechaFin.Text)

        crystalBL = Nothing
        'reportesBL = Nothing

        Me.Cursor = Cursors.Default
    End Sub
End Class