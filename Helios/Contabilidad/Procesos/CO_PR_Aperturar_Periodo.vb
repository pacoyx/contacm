Public Class CO_PR_Aperturar_Periodo

    Private Sub CO_PR_Aperturar_Periodo_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load


    End Sub

    Private Sub Tool_Salir_Click(sender As System.Object, e As System.EventArgs) Handles Tool_Salir.Click
        Me.Close()
    End Sub

    Private Sub Tool_Aceptar_Click(sender As System.Object, e As System.EventArgs) Handles Tool_Aceptar.Click

        If une_ayo_des.Value Is Nothing Then
            Avisar("Ingrese Año")
            une_ayo_des.Focus()
            Exit Sub
        End If

        Me.Cursor = Cursors.WaitCursor

        Dim empresaBL As New BL.ContabilidadBL.SG_CO_TB_EMPRESA
        empresaBL.Aperturar_Periodo(gInt_IdEmpresa, gDat_Fecha_Sis.Year, une_ayo_des.Value)
        empresaBL = Nothing

        Me.Cursor = Cursors.Default
    End Sub

End Class