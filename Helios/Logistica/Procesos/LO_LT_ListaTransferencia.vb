Public Class LO_LT_ListaTransferencia
    Dim lista As New List(Of BE.LogisticaBE.SG_LO_TB_MOVIMIENTOS_C)
    Public IDALMACEN_ORI As String
    Public IDALMACEN_DES As String

    Public Function GetLista() As List(Of BE.LogisticaBE.SG_LO_TB_MOVIMIENTOS_C)
        Return lista
    End Function

    Private Sub FA_PR_ListaArticuloAyuda_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        If ug_data.Rows.Count = 0 Then Exit Sub
        ug_data.Rows(0).Activate()
        ug_data.Rows.FilterRow.Cells("MO_ID").Activate()
        ug_data.PerformAction(Infragistics.Win.UltraWinGrid.UltraGridAction.EnterEditMode)

        SendKeys.Send("{TAB}")
    End Sub

    Private Sub AD_PR_ListaArticulosSeg_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Dim movBL As New BL.LogisticaBL.SG_LO_TB_MOVIMIENTOS_C
        Dim movBE As New BE.LogisticaBE.SG_LO_TB_MOVIMIENTOS_C
        movBE.MO_IDALMACEN_ORI = IDALMACEN_ORI
        movBE.MO_IDALMACEN_DES = IDALMACEN_DES
        movBE.MO_IDEMPRESA = gInt_IdEmpresa
        ug_data.DataSource = movBL.SEL07(movBE)
        movBL = Nothing

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

                Dim MOVBE As New BE.LogisticaBE.SG_LO_TB_MOVIMIENTOS_C
                MOVBE.MO_ID = ug_data.ActiveRow.Cells("MO_ID").Value
                MOVBE.MO_TDOC = ug_data.ActiveRow.Cells("MO_TDOC").Value
                MOVBE.MO_SDOC = ug_data.ActiveRow.Cells("MO_SDOC").Value
                MOVBE.MO_NDOC = ug_data.ActiveRow.Cells("MO_NDOC").Value
                lista.Add(MOVBE)

                Me.Close()
            End If
        End If
    End Sub

    Private Sub ug_data_DoubleClickRow(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.DoubleClickRowEventArgs) Handles ug_data.DoubleClickRow

        If ug_data.ActiveRow.IsFilterRow Then Exit Sub

        lista.Clear()
        ug_data.UpdateData()

        If ug_data.Rows.Count > 0 Then

            Dim MOVBE As New BE.LogisticaBE.SG_LO_TB_MOVIMIENTOS_C
            ' articuloBE = New BE.FacturacionBE.SG_FA_TB_ARTICULO

            MOVBE.MO_ID = ug_data.ActiveRow.Cells("MO_ID").Value
            MOVBE.MO_TDOC = ug_data.ActiveRow.Cells("MO_TDOC").Value
            MOVBE.MO_SDOC = ug_data.ActiveRow.Cells("MO_SDOC").Value
            MOVBE.MO_NDOC = ug_data.ActiveRow.Cells("MO_NDOC").Value
            lista.Add(MOVBE)
            Me.Close()
        End If

    End Sub

    Private Sub Tool_Aceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_Aceptar.Click
        lista.Clear()
        ug_data.UpdateData()
        If ug_data.Rows.Count > 0 Then
            Dim MOVBE As New BE.LogisticaBE.SG_LO_TB_MOVIMIENTOS_C

            'For f As Integer = 0 To ug_data.Rows.Count - 1
            '    If ug_data.Rows(f).Cells("Sel").Value Then

            MOVBE = New BE.LogisticaBE.SG_LO_TB_MOVIMIENTOS_C
            MOVBE.MO_ID = ug_data.ActiveRow.Cells("MO_ID").Value
            MOVBE.MO_TDOC = ug_data.ActiveRow.Cells("MO_TDOC").Value
            MOVBE.MO_SDOC = ug_data.ActiveRow.Cells("MO_SDOC").Value
            MOVBE.MO_NDOC = ug_data.ActiveRow.Cells("MO_NDOC").Value

            lista.Add(MOVBE)

            '    End If
            'Next
        End If
        Me.Close()

    End Sub

    Private Sub Tool_Salir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_Salir.Click
        lista.Clear()
        Me.Close()
    End Sub

End Class