Public Class AD_PR_ListaHisEco
    '  Private obr As BL.AdmisionBL.SG_AD_TB_Reportes

    Public Sub New()
        InitializeComponent()
        '   obr = New BL.AdmisionBL.SG_AD_TB_Reportes
    End Sub
    Private Sub pKeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Me.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Return) Then
            SendKeys.Send("{TAB}")
            e.Handled = True
        End If
    End Sub
    Private Sub AD_RE_ConsultaEcografia_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        '  obr = New BL.AdmisionBL.SG_AD_TB_Reportes
        Me.KeyPreview = True

        '--LimpiaGrid(ug_Lista, uds_Lista)

        'Dim obj As New DataTable
        'obr.SEL05(Paciente, obj)
        'ug_Lista.DataSource = obj
    End Sub

End Class