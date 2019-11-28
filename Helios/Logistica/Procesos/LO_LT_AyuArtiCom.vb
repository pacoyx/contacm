Public Class LO_LT_AyuArtiCom

    Public bol_Aceptar As Boolean = False
    ' Public ls_lista As New List(Of String)
    Dim ls_lista As New List(Of BE.LogisticaBE.SG_LO_TB_ARTICULO)

    Public Function GetLista() As List(Of BE.LogisticaBE.SG_LO_TB_ARTICULO)
        Return ls_lista
    End Function

    Private Sub LO_LT_AyuArtiCom_Activated(sender As Object, e As System.EventArgs) Handles Me.Activated
        Call Focus_Filtro()
    End Sub

    Private Sub Focus_Filtro()
        If ug_lista.Rows.Count = 0 Then Exit Sub
        ug_lista.Rows(0).Activate()
        ug_lista.Rows.FilterRow.Cells("AR_ID").Activate()
        ug_lista.PerformAction(Infragistics.Win.UltraWinGrid.UltraGridAction.EnterEditMode)
        SendKeys.Send("{TAB}")
    End Sub

    Private Sub LO_LT_AyuArtiCom_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call Cargar_Articulos()
    End Sub

    Private Sub Cargar_Articulos()
        Dim articuloBL As New BL.LogisticaBL.SG_LO_TB_ARTICULO
        ug_lista.DataSource = articuloBL.get_Articulos_Ayuda(gInt_IdEmpresa)
        articuloBL = Nothing
    End Sub

    Private Sub Aceptar()
        bol_Aceptar = True
        ls_lista.Clear()

        Dim articuloBE As New BE.LogisticaBE.SG_LO_TB_ARTICULO

        articuloBE.AR_ID = ug_lista.ActiveRow.Cells("AR_ID").Value
        articuloBE.AR_DESCRIPCION = ug_lista.ActiveRow.Cells("AR_DESCRIPCION").Value
        articuloBE.AR_UM_COMPRA = ug_lista.ActiveRow.Cells("AR_UM_COMPRA").Value
        articuloBE.UM_Des = ug_lista.ActiveRow.Cells("UM_DESCRIPCION").Value
        articuloBE.AR_CANT_UMC = ug_lista.ActiveRow.Cells("AR_CANT_UMC").Value
        articuloBE.UM_DesV = ug_lista.ActiveRow.Cells("UM_ABREVI").Value
        articuloBE.AR_UM_VENTA = ug_lista.ActiveRow.Cells("AR_UM_VENTA").Value
        articuloBE.AR_SIN_IGV = ug_lista.ActiveRow.Cells("AR_SIN_IGV").Value
        articuloBE.AR_PRECIO_COMPRA = ug_lista.ActiveRow.Cells("AR_PRECIO_COMPRA").Value
        ls_lista.Add(articuloBE)

        Me.Close()

    End Sub

    Private Sub Tool_Salir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_Salir.Click
        ls_lista.Clear()
        bol_Aceptar = False
        Me.Close()
    End Sub

    Private Sub ug_lista_DoubleClickCell(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinGrid.DoubleClickCellEventArgs) Handles ug_lista.DoubleClickCell
        Call Aceptar()
    End Sub

    Private Sub ug_lista_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles ug_lista.KeyDown
        If e.KeyCode = Keys.Enter Then
            Call Aceptar()
        End If
        If e.KeyCode = Keys.Escape Then
            Call Tool_Salir_Click(sender, e)
        End If

        If e.KeyCode = Keys.Down And ug_lista.ActiveRow.IsFilterRow And ug_lista.Rows.Count > 0 Then
            ug_lista.Rows(0).Activate()
        End If

    End Sub

    Private Sub Tool_Aceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_Aceptar.Click

        bol_Aceptar = True
        ls_lista.Clear()
        ug_lista.UpdateData()

        Dim articuloBE As BE.LogisticaBE.SG_LO_TB_ARTICULO

        For f As Integer = 0 To ug_lista.Rows.Count - 1

            If ug_lista.Rows(f).Cells("Sel").Value Then

                articuloBE = New BE.LogisticaBE.SG_LO_TB_ARTICULO

                articuloBE.AR_ID = ug_lista.Rows(f).Cells("AR_ID").Value
                articuloBE.AR_DESCRIPCION = ug_lista.Rows(f).Cells("AR_DESCRIPCION").Value
                articuloBE.AR_UM_COMPRA = ug_lista.Rows(f).Cells("AR_UM_COMPRA").Value
                articuloBE.UM_Des = ug_lista.Rows(f).Cells("UM_DESCRIPCION").Value
                articuloBE.AR_CANT_UMC = ug_lista.Rows(f).Cells("AR_CANT_UMC").Value
                articuloBE.UM_DesV = ug_lista.Rows(f).Cells("UM_ABREVI").Value
                articuloBE.AR_UM_VENTA = ug_lista.Rows(f).Cells("AR_UM_VENTA").Value
                articuloBE.AR_SIN_IGV = ug_lista.Rows(f).Cells("AR_SIN_IGV").Value
                articuloBE.AR_PRECIO_COMPRA = ug_lista.Rows(f).Cells("AR_PRECIO_COMPRA").Value
                ls_lista.Add(articuloBE)
            End If
        Next

        Me.Close()


    End Sub
End Class