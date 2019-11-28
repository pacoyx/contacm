Public Class CO_MT_TCamb_Web
    Public Str_Direccion_Defecto As String = "http://www.sunat.gob.pe/cl-at-ittipcam/tcS01Alias"

    Private Sub CO_MT_TCamb_Web_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call CargarWeb()
        usb_Web.Panels("Barra").ProgressBarInfo.Style = Infragistics.Win.UltraWinProgressBar.ProgressBarStyle.Office2007Continuous

        UltraToolbarsManager1.Tools("tool_tc_sunat").SharedProps.AppearancesLarge.Appearance.Image = My.Resources.sunat
        UltraToolbarsManager1.Tools("tool_tc_sbs").SharedProps.AppearancesLarge.Appearance.Image = My.Resources.sbschico
        UltraToolbarsManager1.Tools("tool_Con_Ruc").SharedProps.AppearancesLarge.Appearance.Image = My.Resources.lupa
        UltraToolbarsManager1.Tools("tool_salir").SharedProps.AppearancesLarge.Appearance.Image = My.Resources.CP_59_32x32_32
        UltraToolbarsManager1.Ribbon.ApplicationMenuButtonImage = My.Resources._09_osX_Logo_marks

    End Sub

    Private Sub CargarWeb()
        wb_tc.Navigate(Str_Direccion_Defecto)
    End Sub

    Private Sub wb_tc_DocumentCompleted(ByVal sender As System.Object, ByVal e As System.Windows.Forms.WebBrowserDocumentCompletedEventArgs) Handles wb_tc.DocumentCompleted
        ' uce_Direccion.Items.Add(e.Url.AbsoluteUri)

    End Sub

    Private Sub wb_tc_ProgressChanged(ByVal sender As Object, ByVal e As System.Windows.Forms.WebBrowserProgressChangedEventArgs) Handles wb_tc.ProgressChanged

        usb_Web.Panels("Barra").ProgressBarInfo.Maximum = e.MaximumProgress
        usb_Web.Panels("Barra").ProgressBarInfo.Minimum = e.CurrentProgress

        If e.MaximumProgress <= 0 Then

        End If
    End Sub

    Private Sub UltraToolbarsManager1_ToolClick(sender As System.Object, e As Infragistics.Win.UltraWinToolbars.ToolClickEventArgs) Handles UltraToolbarsManager1.ToolClick
        Select Case e.Tool.Key
            Case "tool_tc_Sunat"
                wb_tc.Navigate("http://www.sunat.gob.pe/cl-at-ittipcam/tcS01Alias")
            Case "tool_tc_Sbs"
                wb_tc.Navigate("http://www.sbs.gob.pe/app/stats/tc-cv.asp")
            Case "tool_Con_Ruc"
                wb_tc.Navigate("http://www.sunat.gob.pe/cl-ti-itmrconsruc/jcrS00Alias")
            Case "tool_salir"
                Me.Close()
        End Select

    End Sub
End Class