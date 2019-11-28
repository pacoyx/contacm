Public Class PL_RP_Tardanza_Detalle


    Public str_Dni As String
    Public dat_fec_ini As Date
    Public dat_fec_fin As Date
    Public str_nom_trab As String
    Public bol_Considerar_FT As Boolean

    Private Sub PL_RP_Tardanza_Detalle_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Call Cargar_Data_Detalle()
        Call Formatear_Grilla_Selector(ug_Detalle)
        lbl_ft.Visible = bol_Considerar_FT
    End Sub

    Private Sub Cargar_Data_Detalle()

        txt_trabajador.Text = str_nom_trab

        Dim marcasBL As New BL.PlanillaBL.Dicon
        ug_Detalle.DataSource = marcasBL.get_Tardanzas_Detalle(str_Dni, dat_fec_ini, dat_fec_fin)
        marcasBL = Nothing



        'sumamos el detalle
        Dim hora As String = String.Empty
        Dim minuto As String = String.Empty
        Dim segundos As String = String.Empty
        Dim tiempo_Acumulado As New TimeSpan(0, 0, 0)
        Dim vector As String() = Nothing

        For i As Integer = 0 To ug_Detalle.Rows.Count - 1
            vector = ug_Detalle.Rows(i).Cells("TARDANZA").Value.ToString.Split(":")
            hora = vector(0)
            minuto = vector(1)
            segundos = vector(2)
            tiempo_Acumulado = tiempo_Acumulado.Add(New TimeSpan(hora, minuto, segundos))
        Next

        txt_total.Text = tiempo_Acumulado.ToString

    End Sub

    Private Sub Tool_Salir_Click(sender As System.Object, e As System.EventArgs) Handles Tool_Salir.Click
        Me.Close()
    End Sub

    Private Sub ug_Detalle_InitializeRow(sender As System.Object, e As Infragistics.Win.UltraWinGrid.InitializeRowEventArgs) Handles ug_Detalle.InitializeRow
        If bol_Considerar_FT Then
            If e.Row.Cells("Estado").Value = "FT" Then
                e.Row.Appearance.ForeColor = Color.Red
            End If
        End If

    End Sub

    Private Sub Tool_exportar_Click(sender As System.Object, e As System.EventArgs) Handles Tool_exportar.Click
        Me.Cursor = Cursors.WaitCursor



        UltraGridExcelExporter1.Export(ug_Detalle, "detalle_marca.xls")
        Process.Start("detalle_marca.xls")


        Me.Cursor = Cursors.Default
    End Sub

    Private Sub Tool_imprimir_Click(sender As System.Object, e As System.EventArgs) Handles Tool_imprimir.Click
        Me.Cursor = Cursors.WaitCursor

        UltraPrintPreviewDialog1.Document = ugpd_Planilla
        UltraPrintPreviewDialog1.ShowDialog()

        Me.Cursor = Cursors.Default
    End Sub
End Class