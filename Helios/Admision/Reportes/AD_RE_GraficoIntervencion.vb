Public Class AD_RE_GraficoIntervencion

    Private Sub AD_RE_GraficoAtenciones_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call CargarCombo_ConMeses(uce_Mes)
        uce_tipo.SelectedIndex = 2
        uce_Mes.SelectedIndex = Now.Month - 1
    End Sub

    Private Sub Tool_Consultar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_Consultar.Click
        Cargar_Comprobantes()
    End Sub
    Private Sub Cargar_Comprobantes()
        Dim ReportBL As New BL.AdmisionBL.SG_AD_TB_Reportes
        Dim obj As New DataTable
        obj = ReportBL.get_Gra_Intermedio(uce_Mes.Value, CDate(udte_desde.Value).ToShortDateString, CDate(udte_hasta.Value).ToShortDateString, Now.Year, uce_tipo.Value)
        If obj.Rows.Count > 0 Then
            uc_Grafico.Visible = True
            uc_Grafico.Data.DataSource = obj
        Else
            uc_Grafico.Visible = False
        End If


        ReportBL = Nothing
    End Sub
    Private Sub uce_tipo_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles uce_tipo.ValueChanged

        udte_desde.Visible = True
        udte_hasta.Visible = True
        uce_Mes.Visible = True
        lbl_desde.Visible = True
        lbl_hasta.Visible = True
        lbl_desde.Text = "Desde"
        Select Case uce_tipo.Value
            Case 2 'diario
                udte_hasta.Visible = False
                uce_Mes.Visible = False

                lbl_hasta.Visible = False
            Case 3 'semanal
                uce_Mes.Visible = False

            Case 1 'mensual

                lbl_desde.Text = "Mes"
                lbl_hasta.Visible = False
                udte_desde.Visible = False
                udte_hasta.Visible = False

        End Select

        Call Cargar_Comprobantes()

    End Sub

    Private Sub uce_Mes_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles uce_Mes.ValueChanged
        Call Cargar_Comprobantes()
    End Sub

    Private Sub udte_desde_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles udte_desde.KeyDown
        If e.KeyCode = Keys.Enter Then
            If uce_tipo.Value = "2" Then 'por dia
                Call Cargar_Comprobantes()
            Else
                udte_hasta.Focus()
            End If
        End If
    End Sub

    Private Sub udte_hasta_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles udte_hasta.KeyDown
        If e.KeyCode = Keys.Enter Then
            Call Cargar_Comprobantes()
        End If
    End Sub
    Private Sub uce_tipo_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles uce_tipo.KeyDown
        If e.KeyCode = Keys.Enter Then
            If uce_tipo.Value = "2" Then 'por dia
                udte_desde.Focus()
            End If
        End If
    End Sub

    Private Sub Tool_Salir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_Salir.Click
        Me.Close()
    End Sub

End Class