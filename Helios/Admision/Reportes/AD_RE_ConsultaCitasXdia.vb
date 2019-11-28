Public Class AD_RE_ConsultaCitasXdia
    Private obr As BL.AdmisionBL.SG_AD_TB_Reportes
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

    Private Sub AD_RE_ConsultaCitasXfecha_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        obr = New BL.AdmisionBL.SG_AD_TB_Reportes

        Cancelar()

        Me.KeyPreview = True

        udte_fechaD.Focus()
    End Sub


    Private Sub Cancelar()
        udte_fechaD.Value = Now
    End Sub
    Private Sub Tool_Cancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_Cancelar.Click
        Cancelar()
    End Sub

 
    Private Sub Tool_Imprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_Imprimir.Click
        Me.Cursor = Cursors.WaitCursor
        Dim obj As New DataSet
        obr.SEL02(gInt_IdEmpresa, obj)
        obr.SEL03(udte_fechaD.Text, gInt_IdEmpresa, obj)

        Dim nom_reporte As String = "SG_AD_05.RPT"
        Dim crystalBL As New LR.ClsReporte
        Dim dt_data As New DataSet
        dt_data = obj

        crystalBL.Muestra_Reporte_dataset(gStr_RutaRep & "\" & nom_reporte, dt_data, "", "pfecha;" & udte_fechaD.Text)


        crystalBL = Nothing
        ' reportesBL = Nothing

        Me.Cursor = Cursors.Default
    End Sub

    Private Sub Tool_Salir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_Salir.Click
        Me.Close()
    End Sub

End Class