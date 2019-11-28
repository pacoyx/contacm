Public Class TE_RE_DetalleComprobantes

    Private Sub frmDetalleComprobantes_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        udte_f1.Value = Now
        udte_f2.Value = Now
        uce_Destino.SelectedIndex = 0
        uchk_PorMedico.Checked = False
        uce_Medico.Enabled = False
        Dim medicosBL As New BL.AdmisionBL.SG_AD_TB_MEDICO
        uce_Medico.DataSource = medicosBL.get_Medicos(gInt_IdEmpresa)
        uce_Medico.ValueMember = "ME_CODIGO"
        uce_Medico.DisplayMember = "NOMBRES"
        medicosBL = Nothing

        Call LimpiaGrid(ug_detalle, uds_Lista)
    End Sub

    Private Sub Tool_Consultar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_Consultar.Click
        If uce_Destino.SelectedIndex = -1 Then
            Avisar("Seleccione un destino")
            uce_Destino.Focus()
            Exit Sub
        End If

        Dim obr As New BL.FacturacionBL.SG_FA_Reportes
        ug_detalle.DataSource = obr.get_Atencion_comprobantesT(gInt_IdEmpresa, udte_f1.Text, udte_f2.Text, uce_Destino.Value, IIf(uchk_PorMedico.Checked = True, uce_Medico.Text, ""))

    End Sub

    Private Sub Tool_exportar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_exportar.Click

        Dim str_nombre_arc_exc As String = "Comprobantes " & Date.Now.Day & Date.Now.Month & Date.Now.Year & Date.Now.Hour & Date.Now.Minute & Date.Now.Second & ".xls"

        Try
            Me.Cursor = Cursors.WaitCursor

            uge_detra.Export(ug_detalle, str_nombre_arc_exc)


            Process.Start(str_nombre_arc_exc)
            Me.Cursor = Cursors.Default
        Catch ex As Exception
            Call Avisar("Ocurrio un error.")
            Me.Cursor = Cursors.Default
        End Try
    End Sub
    Private Sub Tool_salir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_salir.Click
        Me.Close()
    End Sub

    Private Sub uchk_PorMedico_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles uchk_PorMedico.CheckedChanged
        If uchk_PorMedico.Checked = True Then
            uce_Medico.Enabled = True
        Else
            uce_Medico.Enabled = False
        End If
    End Sub
End Class