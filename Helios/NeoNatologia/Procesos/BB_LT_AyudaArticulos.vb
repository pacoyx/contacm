Public Class BB_LT_AyudaArticulos
    Public IDAREA As String
    Dim lista As New List(Of BE.FacturacionBE.SG_FA_TB_ARTICULO)

    Public Function GetLista() As List(Of BE.FacturacionBE.SG_FA_TB_ARTICULO)
        Return lista
    End Function

    Private Sub FA_PR_ListaArticuloAyuda_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        Focus_Filtro()
    End Sub

    Private Sub FA_PR_ListaArticuloAyuda_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call Cargar_Articulos()
    End Sub
    Private Sub Focus_Filtro()
        If ug_data.Rows.Count = 0 Then Exit Sub
        ug_data.Rows(0).Activate()
        ug_data.Rows.FilterRow.Cells("AR_ID").Activate()
        ug_data.PerformAction(Infragistics.Win.UltraWinGrid.UltraGridAction.EnterEditMode)
        SendKeys.Send("{TAB}")
    End Sub

    Private Sub Cargar_Articulos()

        Me.Text = "Lista de Articulos"

        Dim articuloBL As New BL.FacturacionBL.SG_FA_TB_ARTICULO
        ug_data.DataSource = articuloBL.get_Articulos_Ayuda05(gInt_IdEmpresa, IDAREA, "CO")

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

                Dim articuloBE As BE.FacturacionBE.SG_FA_TB_ARTICULO
                articuloBE = New BE.FacturacionBE.SG_FA_TB_ARTICULO

                articuloBE.AR_ID = ug_data.ActiveRow.Cells("AR_ID").Value
                articuloBE.AR_DESCRIPCION = ug_data.ActiveRow.Cells("AR_DESCRIPCION").Value
                articuloBE.UM_DesV = ug_data.ActiveRow.Cells("UM_DESCRIPCION").Value

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

            Dim articuloBE As BE.FacturacionBE.SG_FA_TB_ARTICULO
            articuloBE = New BE.FacturacionBE.SG_FA_TB_ARTICULO

            articuloBE.AR_ID = ug_data.ActiveRow.Cells("AR_ID").Value
            articuloBE.AR_DESCRIPCION = ug_data.ActiveRow.Cells("AR_DESCRIPCION").Value
            articuloBE.UM_DesV = ug_data.ActiveRow.Cells("UM_DESCRIPCION").Value

            lista.Add(articuloBE)

            Me.Close()
        End If

    End Sub

    Private Sub Tool_Aceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_Aceptar.Click
        lista.Clear()
        ug_data.UpdateData()

        Dim articuloBE As BE.FacturacionBE.SG_FA_TB_ARTICULO

        For f As Integer = 0 To ug_data.Rows.Count - 1


            If ug_data.Rows(f).Cells("Sel").Value Then

                articuloBE = New BE.FacturacionBE.SG_FA_TB_ARTICULO

                articuloBE.AR_ID = ug_data.Rows(f).Cells("AR_ID").Value
                articuloBE.AR_DESCRIPCION = ug_data.Rows(f).Cells("AR_DESCRIPCION").Value
                articuloBE.UM_DesV = ug_data.Rows(f).Cells("UM_DESCRIPCION").Value

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