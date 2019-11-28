Public Class FA_PR_ListaArticulosCuentas
    Dim lista As New List(Of BE.AdmisionBE.TMP_SG_AD_TB_CUENTA_DET)
    Public idHisto As Integer
    Public Function GetLista() As List(Of BE.AdmisionBE.TMP_SG_AD_TB_CUENTA_DET)
        Return lista
    End Function

    Private Sub FA_PR_ListaArticuloAyuda_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        If ug_data.Rows.Count = 0 Then Exit Sub
        ug_data.Rows(0).Activate()
        ug_data.Rows.FilterRow.Cells("CC_FECHA").Activate()
        ug_data.PerformAction(Infragistics.Win.UltraWinGrid.UltraGridAction.EnterEditMode)
        SendKeys.Send("{TAB}")
    End Sub

    Private Sub FA_PR_ListaArticulosCuentas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        lista.Clear()
        Dim articuloBL As New BL.FacturacionBL.SG_FA_TB_ARTICULO

        ug_data.DataSource = articuloBL.get_Articulos_Cuent(gInt_IdEmpresa, idHisto)
        If ug_data.Rows.Count <= 0 Then
            Me.Close()
        End If
        articuloBL = Nothing

    End Sub

    Private Sub ug_data_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles ug_data.KeyDown

        lista.Clear()
        ug_data.UpdateData()

        If ug_data.Rows.Count > 0 Then

            If e.KeyCode = Keys.Down And ug_data.ActiveRow.IsFilterRow Then
                ug_data.Rows(0).Activate()
            End If

            If e.KeyCode = Keys.Enter Then

                If ug_data.ActiveRow.IsFilterRow Then Exit Sub

                Dim articuloBE As BE.AdmisionBE.TMP_SG_AD_TB_CUENTA_DET
                articuloBE = New BE.AdmisionBE.TMP_SG_AD_TB_CUENTA_DET

                articuloBE.TCD_FECHA = ug_data.ActiveRow.Cells("CC_FECHA").Value
                articuloBE.TCD_IDCAB = ug_data.ActiveRow.Cells("CD_IDCAB").Value
                articuloBE.TCD_ITEM = ug_data.ActiveRow.Cells("CD_ITEM").Value
                articuloBE.TCD_IDARTICULO = ug_data.ActiveRow.Cells("AR_ID").Value
                articuloBE.TCD_DESCRIPCION = ug_data.ActiveRow.Cells("AR_DESCRIPCION").Value
                articuloBE.TCD_CANT = ug_data.ActiveRow.Cells("CD_CANT").Value
                articuloBE.TCD_PRECIO = ug_data.ActiveRow.Cells("PRECIO").Value
                articuloBE.TCD_DESCUENTO = ug_data.ActiveRow.Cells("CD_DESCUENTO").Value
                articuloBE.TCD_SUB_TOTAL = ug_data.ActiveRow.Cells("CD_SUB_TOTAL").Value
                articuloBE.TCD_IGV = ug_data.ActiveRow.Cells("CD_IGV").Value
                articuloBE.TCD_TOTAL = ug_data.ActiveRow.Cells("CD_TOTAL").Value

                lista.Add(articuloBE)

                Me.Close()
            End If
        End If

    End Sub


    Private Sub ug_data_DoubleClickRow(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.DoubleClickRowEventArgs) Handles ug_data.DoubleClickRow

        If ug_data.ActiveRow.IsFilterRow Then Exit Sub

        lista.Clear()
        ug_data.UpdateData()

        If ug_data.Rows.Count > 0 Then

            Dim articuloBE As BE.AdmisionBE.TMP_SG_AD_TB_CUENTA_DET
            articuloBE = New BE.AdmisionBE.TMP_SG_AD_TB_CUENTA_DET

            articuloBE.TCD_FECHA = ug_data.ActiveRow.Cells("CC_FECHA").Value
            articuloBE.TCD_IDCAB = ug_data.ActiveRow.Cells("CD_IDCAB").Value
            articuloBE.TCD_ITEM = ug_data.ActiveRow.Cells("CD_ITEM").Value
            articuloBE.TCD_IDARTICULO = ug_data.ActiveRow.Cells("AR_ID").Value
            articuloBE.TCD_DESCRIPCION = ug_data.ActiveRow.Cells("AR_DESCRIPCION").Value
            articuloBE.TCD_CANT = ug_data.ActiveRow.Cells("CD_CANT").Value
            articuloBE.TCD_PRECIO = ug_data.ActiveRow.Cells("PRECIO").Value
            articuloBE.TCD_DESCUENTO = ug_data.ActiveRow.Cells("CD_DESCUENTO").Value
            articuloBE.TCD_SUB_TOTAL = ug_data.ActiveRow.Cells("CD_SUB_TOTAL").Value
            articuloBE.TCD_IGV = ug_data.ActiveRow.Cells("CD_IGV").Value
            articuloBE.TCD_TOTAL = ug_data.ActiveRow.Cells("CD_TOTAL").Value

            lista.Add(articuloBE)

            Me.Close()
        End If

    End Sub

    Private Sub Tool_Aceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_Aceptar.Click
        lista.Clear()
        ug_data.UpdateData()

        Dim articuloBE As BE.AdmisionBE.TMP_SG_AD_TB_CUENTA_DET

        For f As Integer = 0 To ug_data.Rows.Count - 1

            If ug_data.Rows(f).Cells("Sel").Value Then

                articuloBE = New BE.AdmisionBE.TMP_SG_AD_TB_CUENTA_DET

                articuloBE.TCD_FECHA = ug_data.Rows(f).Cells("CC_FECHA").Value
                articuloBE.TCD_IDCAB = ug_data.Rows(f).Cells("CD_IDCAB").Value
                articuloBE.TCD_ITEM = ug_data.Rows(f).Cells("CD_ITEM").Value
                articuloBE.TCD_IDARTICULO = ug_data.Rows(f).Cells("AR_ID").Value
                articuloBE.TCD_DESCRIPCION = ug_data.Rows(f).Cells("AR_DESCRIPCION").Value
                articuloBE.TCD_CANT = ug_data.Rows(f).Cells("CD_CANT").Value
                articuloBE.TCD_PRECIO = ug_data.Rows(f).Cells("PRECIO").Value
                articuloBE.TCD_DESCUENTO = ug_data.Rows(f).Cells("CD_DESCUENTO").Value
                articuloBE.TCD_SUB_TOTAL = ug_data.Rows(f).Cells("CD_SUB_TOTAL").Value
                articuloBE.TCD_IGV = ug_data.Rows(f).Cells("CD_IGV").Value
                articuloBE.TCD_TOTAL = ug_data.Rows(f).Cells("CD_TOTAL").Value

                lista.Add(articuloBE)
            End If
        Next

        Me.Close()

    End Sub

    Private Sub Tool_Salir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_Salir.Click
        lista.Clear()
        Me.Close()
    End Sub
    'Private Sub pFormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
    '    '  lista.Clear()
    '    Me.Close()
    'End Sub
End Class