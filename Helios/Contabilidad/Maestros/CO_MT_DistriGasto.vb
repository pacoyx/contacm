Imports Infragistics.Win.UltraWinGrid

Public Class CO_MT_DistriGasto

    Private Sub CO_MT_DistriGasto_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call CargarCombo_ConMeses(uce_Mes)
        txt_Ayo.Text = gDat_Fecha_Sis.Year
        txt_Ayo.ReadOnly = True
        uce_Mes.SelectedIndex = -1
    End Sub

#Region "Procedimientos"

    Private Sub Cargar_Datos()
        Dim distribucionBL As New BL.ContabilidadBL.SG_CO_TB_DISTRI_GASTO
        Dim distribucionBE As New BE.ContabilidadBE.SG_CO_TB_DISTRI_GASTO
        Dim dt_data As DataTable = Nothing

        With distribucionBE
            .DG_ANHO = txt_Ayo.Text
            .DG_MES = uce_Mes.Value
            .DG_IDEMPRESA = gInt_IdEmpresa
        End With
        dt_data = distribucionBL.get_Distribuciones(distribucionBE)

        Call LimpiaGrid(ug_distri, uds_distri)

        For i As Integer = 0 To dt_data.Rows.Count - 1
            ug_distri.DisplayLayout.Bands(0).AddNew()
            ug_distri.Rows(i).Cells("CC_CODIGO").Value = dt_data.Rows(i)("CC_CODIGO")
            ug_distri.Rows(i).Cells("CC_DESCRIPCION").Value = dt_data.Rows(i)("CC_DESCRIPCION")
            ug_distri.Rows(i).Cells("DG_VALOR").Value = dt_data.Rows(i)("DG_VALOR")
        Next

        ug_distri.UpdateData()

        dt_data.Dispose()
        distribucionBL = Nothing
        distribucionBE = Nothing

    End Sub

    Private Sub Grabar_Datos()

        Dim distribucionBL As New BL.ContabilidadBL.SG_CO_TB_DISTRI_GASTO
        Dim distribucionBE As BE.ContabilidadBE.SG_CO_TB_DISTRI_GASTO
        Dim ls_distribuciones As New List(Of BE.ContabilidadBE.SG_CO_TB_DISTRI_GASTO)

        For i As Integer = 0 To ug_distri.Rows.Count - 1
            distribucionBE = New BE.ContabilidadBE.SG_CO_TB_DISTRI_GASTO
            With distribucionBE
                .DG_ANHO = txt_Ayo.Text
                .DG_MES = uce_Mes.Value
                .DG_IDCC = ug_distri.Rows(i).Cells("CC_CODIGO").Value
                .DG_VALOR = ug_distri.Rows(i).Cells("DG_VALOR").Value
                .DG_IDEMPRESA = gInt_IdEmpresa
            End With
            ls_distribuciones.Add(distribucionBE)
        Next

        If ls_distribuciones.Count = 0 Then
            Call Avisar("No hay detalles para registrar")
            distribucionBL = Nothing
            distribucionBE = Nothing
            Exit Sub
        End If

        distribucionBL.Insert(ls_distribuciones)


        distribucionBL = Nothing
        distribucionBE = Nothing

        Call Avisar("Listo!")

    End Sub

#End Region

    Private Sub Tool_Salir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_Salir.Click
        Me.Close()
    End Sub

    Private Sub Tool_grabar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_grabar.Click

        ug_distri.UpdateData()

        If ug_distri.Rows.Count = 0 Then
            Call Avisar("No hay datos para registrar")
            Exit Sub
        End If

        If txt_Ayo.Text = "" Then
            Call Avisar("No se cargo el año")
            Exit Sub
        End If

        If uce_Mes.SelectedIndex = -1 Then
            Call Avisar("Seleccione mes")
            Exit Sub
        End If

        Call Grabar_Datos()
    End Sub

    Private Sub uce_Mes_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles uce_Mes.ValueChanged
        Call Cargar_Datos()
    End Sub

    Private Sub ug_distri_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles ug_distri.KeyDown
        If e.KeyCode = Keys.Enter Then
            With ug_distri
                .PerformAction(UltraGridAction.NextCellByTab, False, False)
                .PerformAction(UltraGridAction.NextCellByTab, False, False)
                .PerformAction(UltraGridAction.NextCellByTab, False, False)
            End With
        End If
    End Sub
End Class