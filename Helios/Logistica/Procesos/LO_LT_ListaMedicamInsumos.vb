Public Class LO_LT_ListaMedicamInsumos
    Dim lista As New List(Of BE.LogisticaBE.SG_LO_TB_ARTICULO)
    Public TipoAten As Integer
    Public idSeguro As String
    Public IGVTas As Integer
    Public idalmacen As String

    Public Function GetLista() As List(Of BE.LogisticaBE.SG_LO_TB_ARTICULO)
        Return lista
    End Function

    Private Sub FA_PR_ListaArticuloAyuda_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        If ug_data.Rows.Count = 0 Then Exit Sub
        ug_data.Rows(0).Activate()
        ug_data.Rows.FilterRow.Cells("AR_ID").Activate()
        ug_data.PerformAction(Infragistics.Win.UltraWinGrid.UltraGridAction.EnterEditMode)
        SendKeys.Send("{TAB}")
    End Sub

    Private Sub AD_PR_ListaArticulosSeg_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Dim articuloBL As New BL.LogisticaBL.SG_LO_TB_ARTICULO

        ug_data.DataSource = articuloBL.get_Articulos_Ayuda(IIf(TipoAten = 5, gInt_IdEmpresa, 7), IGVTas, idalmacen, idSeguro, TipoAten)
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

                Dim articuloBE As New BE.LogisticaBE.SG_LO_TB_ARTICULO
                'articuloBE = New BE.FacturacionBE.SG_FA_TB_ARTICULO
                'SEL()
                'AR_ID()
                'AR_DESCRIPCION()
                'DS_IDLOTE()
                'UM_DESCRIPCION()
                'AR_UM_VENTA()
                'GA_DESCRIPCION()
                'AR_PRECIO_VENTA()
                'AR_INCLUYE_IGV()
                'DS_SALDO()
                'AR_SIN_IGV()
                articuloBE.AR_ID = ug_data.ActiveRow.Cells("AR_ID").Value
                articuloBE.AR_DESCRIPCION = ug_data.ActiveRow.Cells("AR_DESCRIPCION").Value
                articuloBE.DS_IDLOTE = ug_data.ActiveRow.Cells("DS_IDLOTE").Value
                articuloBE.UM_DesV = ug_data.ActiveRow.Cells("UM_DESCRIPCION").Value
                articuloBE.AR_PRECIO_VENTA = ug_data.ActiveRow.Cells("AR_PRECIO_VENTA").Value
                articuloBE.AR_INCLUYE_IGV = ug_data.ActiveRow.Cells("AR_INCLUYE_IGV").Value
                articuloBE.DS_SALDO = ug_data.ActiveRow.Cells("DS_SALDO").Value
                articuloBE.AR_SIN_IGV = ug_data.ActiveRow.Cells("AR_SIN_IGV").Value
                articuloBE.AR_TIPO_ARTI = ug_data.ActiveRow.Cells("AR_TIPO_ARTI").Value

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

            Dim articuloBE As New BE.LogisticaBE.SG_LO_TB_ARTICULO
            ' articuloBE = New BE.FacturacionBE.SG_FA_TB_ARTICULO

            articuloBE.AR_ID = ug_data.ActiveRow.Cells("AR_ID").Value
            articuloBE.AR_DESCRIPCION = ug_data.ActiveRow.Cells("AR_DESCRIPCION").Value
            articuloBE.DS_IDLOTE = ug_data.ActiveRow.Cells("DS_IDLOTE").Value
            articuloBE.UM_DesV = ug_data.ActiveRow.Cells("UM_DESCRIPCION").Value
            articuloBE.AR_PRECIO_VENTA = ug_data.ActiveRow.Cells("AR_PRECIO_VENTA").Value
            articuloBE.AR_INCLUYE_IGV = ug_data.ActiveRow.Cells("AR_INCLUYE_IGV").Value
            articuloBE.DS_SALDO = ug_data.ActiveRow.Cells("DS_SALDO").Value
            articuloBE.AR_SIN_IGV = ug_data.ActiveRow.Cells("AR_SIN_IGV").Value
            articuloBE.AR_TIPO_ARTI = ug_data.ActiveRow.Cells("AR_TIPO_ARTI").Value
            lista.Add(articuloBE)
            Me.Close()
        End If

    End Sub

    Private Sub Tool_Aceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_Aceptar.Click
        lista.Clear()
        ug_data.UpdateData()

        Dim articuloBE As BE.LogisticaBE.SG_LO_TB_ARTICULO

        For f As Integer = 0 To ug_data.Rows.Count - 1

            If ug_data.Rows(f).Cells("Sel").Value Then

                articuloBE = New BE.LogisticaBE.SG_LO_TB_ARTICULO

                articuloBE.AR_ID = ug_data.Rows(f).Cells("AR_ID").Value
                articuloBE.AR_DESCRIPCION = ug_data.Rows(f).Cells("AR_DESCRIPCION").Value
                articuloBE.DS_IDLOTE = ug_data.Rows(f).Cells("DS_IDLOTE").Value
                articuloBE.UM_DesV = ug_data.Rows(f).Cells("UM_DESCRIPCION").Value
                articuloBE.AR_PRECIO_VENTA = ug_data.Rows(f).Cells("AR_PRECIO_VENTA").Value
                articuloBE.AR_INCLUYE_IGV = ug_data.Rows(f).Cells("AR_INCLUYE_IGV").Value
                articuloBE.DS_SALDO = ug_data.Rows(f).Cells("DS_SALDO").Value
                articuloBE.AR_SIN_IGV = ug_data.Rows(f).Cells("AR_SIN_IGV").Value

                lista.Add(articuloBE)
            End If
        Next
        Me.Close()

    End Sub

    Private Sub Tool_Salir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_Salir.Click
        lista.Clear()
        Me.Close()
    End Sub

End Class