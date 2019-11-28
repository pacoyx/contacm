Public Class PL_PR_ControlMes

    Private Sub PL_PR_ControlMes_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'cargamos el periodo
        Call CargarCombo_ConMeses(uce_Mes)
        une_Ayo.Value = gDat_Fecha_Sis.Year
        uce_Mes.Value = gDat_Fecha_Sis.Month
    End Sub

    Private Sub Tool_Salir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_Salir.Click
        Me.Close()
    End Sub

    Private Sub Tool_Aceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_Aceptar.Click
        Dim AdmMesBL As New BL.ContabilidadBL.SG_CO_TB_ADMMES
        Dim AdmMesBE As New BE.ContabilidadBE.SG_CO_TB_ADMMES

        With AdmMesBE
            .AM_ANHO = une_Ayo.Value
            .AM_MES = uce_Mes.Value
            .AM_ESTADO = uos_estado.Value
            .AM_IDEMPRESA = New BE.ContabilidadBE.SG_CO_TB_EMPRESA With {.EM_ID = gInt_IdEmpresa}
            .AM_USUARIO = String.Format("{0}-{1}", Environment.UserName, gStr_Usuario_Sis)
            .AM_TERMINAL = Environment.MachineName
            .AM_FECREG = Now.Date
            .AM_MODULO = 3
        End With

        If uos_estado.Value = 1 Then
            If AdmMesBL.Esta_Cerrado_Mes(AdmMesBE) Then
                Avisar("El mes ya esta cerrado." & Chr(13) & "Tiene que abrirlo antes.")
                AdmMesBL = Nothing
                AdmMesBE = Nothing
                Exit Sub
            End If
        End If
        

        AdmMesBL.Delete(AdmMesBE)
        AdmMesBL.Insert(AdmMesBE)

        Avisar("Listo!")
        AdmMesBL = Nothing
        AdmMesBE = Nothing
    End Sub

    Private Sub uce_Mes_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles uce_Mes.ValueChanged
        Try

            Dim AdmMesBL As New BL.ContabilidadBL.SG_CO_TB_ADMMES
            Dim AdmMesBE As New BE.ContabilidadBE.SG_CO_TB_ADMMES

            With AdmMesBE
                .AM_ANHO = une_Ayo.Value
                .AM_MES = uce_Mes.Value
                .AM_IDEMPRESA = New BE.ContabilidadBE.SG_CO_TB_EMPRESA With {.EM_ID = gInt_IdEmpresa}
                .AM_MODULO = 3
            End With

            If AdmMesBL.Esta_Cerrado_Mes(AdmMesBE) Then
                uos_estado.Value = 1
            Else
                uos_estado.Value = 0
            End If

            AdmMesBL = Nothing
            AdmMesBE = Nothing

        Catch ex As Exception
            ShowError(ex.Message)
        End Try
    End Sub
End Class