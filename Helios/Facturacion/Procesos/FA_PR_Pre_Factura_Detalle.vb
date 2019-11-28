Imports Infragistics.Win.UltraWinGrid
Public Class FA_PR_Pre_Factura_Detalle
    Dim obeT As BE.FacturacionBE.SG_FA_TB_PRE_FACTURA_DETALLE
    Dim obrT As BL.FacturacionBL.SG_FA_TB_PRE_FACTURA_DETALLE
    Public IGVTasa As Decimal
    Public IDSeguro As String
    Public Tipo As Integer
    Public Medico As String
    Private Sub pKeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Me.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Return) Then
            SendKeys.Send("{TAB}")
            e.Handled = True
        End If
    End Sub
    Public Sub New()
        InitializeComponent()
        obeT = New BE.FacturacionBE.SG_FA_TB_PRE_FACTURA_DETALLE
        obrT = New BL.FacturacionBL.SG_FA_TB_PRE_FACTURA_DETALLE
    End Sub
    Private Sub FA_PR_Pre_Factura_Detalle_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        obeT = New BE.FacturacionBE.SG_FA_TB_PRE_FACTURA_DETALLE
        obrT = New BL.FacturacionBL.SG_FA_TB_PRE_FACTURA_DETALLE
        Me.KeyPreview = True

        ubt_Agregar.Appearance.Image = My.Resources._16__Plus_
        ubt_Quitar.Appearance.Image = My.Resources._16__Delete_

        obeT.PFD_IDCAB_CUENTA = Val(utxt_IDCuenta.Text)
        obeT.PFD_ITEM = Val(txt_iditem.Text)

        ug_detalle.DataSource = obrT.SEL01(obeT, String.Format("{0}-{1}", Environment.UserName, gStr_Usuario_Sis), Environment.MachineName, IGVTasa)
    End Sub
    Private Sub ubt_Agregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ubt_Agregar.Click
        AD_PR_ListaArticulosSeg.TipoSeg = Tipo
        AD_PR_ListaArticulosSeg.idSeguro = IDSeguro
        AD_PR_ListaArticulosSeg.idMedico = Medico
        AD_PR_ListaArticulosSeg.IGVTas = IGVTasa 'FA_PR_Pre_Facturacion.IGVTasa
        AD_PR_ListaArticulosSeg.ShowDialog()

        Dim matriz As List(Of BE.FacturacionBE.SG_FA_TB_ARTICULO) = AD_PR_ListaArticulosSeg.GetLista

        For Each articulo As BE.FacturacionBE.SG_FA_TB_ARTICULO In matriz

            ug_detalle.DisplayLayout.Bands(0).AddNew()
            ug_detalle.Rows(ug_detalle.Rows.Count - 1).Cells(0).Value = articulo.AR_ID  ' codigo id
            ug_detalle.Rows(ug_detalle.Rows.Count - 1).Cells(1).Value = articulo.AR_DESCRIPCION  'descripcion
            ug_detalle.Rows(ug_detalle.Rows.Count - 1).Cells(2).Value = articulo.AR_PRECIO_VENTA  'costo
            ug_detalle.Rows(ug_detalle.Rows.Count - 1).Cells(3).Value = 1 'cant
            ug_detalle.Rows(ug_detalle.Rows.Count - 1).Cells(4).Value = articulo.AR_PRECIO_VENTA 'sub tot
            ug_detalle.Rows(ug_detalle.Rows.Count - 1).Cells(5).Value = Math.Round((articulo.AR_PRECIO_VENTA * IGVTasa) / 100, 2)
            ug_detalle.Rows(ug_detalle.Rows.Count - 1).Cells(6).Value = articulo.AR_PRECIO_VENTA + Math.Round((articulo.AR_PRECIO_VENTA * IGVTasa) / 100, 2)
            ug_detalle.Rows(ug_detalle.Rows.Count - 1).Cells(7).Value = Val(txt_iditem.Text)
            ug_detalle.Rows(ug_detalle.Rows.Count - 1).Cells(8).Value = Val(utxt_IDCuenta.Text)
            ug_detalle.UpdateData()
            ug_detalle.Refresh()

            With obeT
                .PFD_ITEM = Val(txt_iditem.Text)
                .PFD_IDCAB_CUENTA = Val(utxt_IDCuenta.Text)
                .PFD_CANT = 1
                .PFD_IDARTICULO = articulo.AR_ID
                .PFD_PRECIO = articulo.AR_PRECIO_VENTA
                .PFD_TOTAL = articulo.AR_PRECIO_VENTA '+ Math.Round((articulo.AR_PRECIO_VENTA * IGVTasa) / 100, 2)
            End With
            obrT.Insert(obeT, String.Format("{0}-{1}", Environment.UserName, gStr_Usuario_Sis), Environment.MachineName)
        Next
    End Sub

    Private Sub ubt_Quitar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ubt_Quitar.Click
        If ug_detalle.Rows.Count = 0 Then Exit Sub
        If ug_detalle.ActiveRow Is Nothing Then Exit Sub

        If Preguntar("Seguro que deseas eliminar el registro?") Then
            obeT.PFD_ITEM = Val(txt_iditem.Text)
            obeT.PFD_IDARTICULO = ug_detalle.ActiveRow.Cells(0).Value
            obeT.PFD_IDCAB_CUENTA = ug_detalle.ActiveRow.Cells(8).Value
            ug_detalle.ActiveRow.Hidden = True
            ug_detalle.ActiveRow.Delete()
            obrT.Delete(obeT, String.Format("{0}-{1}", Environment.UserName, gStr_Usuario_Sis), Environment.MachineName)

        End If
    End Sub
    Private Sub ug_Detalle_BeforeRowsDeleted(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.BeforeRowsDeletedEventArgs) Handles ug_detalle.BeforeRowsDeleted
        e.DisplayPromptMsg = False
        e.Cancel = False
    End Sub
    Private Sub ug_Detalle_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles ug_detalle.KeyDown
        If e.KeyCode = Keys.Enter Then
            ug_detalle.PerformAction(UltraGridAction.NextCellByTab, False, False)
            ug_detalle.UpdateData()
        End If
    End Sub
    Private Sub ug_Detalle_AfterRowUpdate(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinGrid.RowEventArgs) Handles ug_detalle.AfterRowUpdate
        'e.Row.Cells("Total").Value = e.Row.Cells("Precio").Value * e.Row.Cells("Cant").Value

        Dim igv_cal As Decimal = "0.00"
        Dim total_cal As Decimal = "0.00"
        Dim subtotal_cal As Decimal = "0.00"
        'Dim Precio As Decimal = 0.0

        subtotal_cal = Math.Round((e.Row.Cells(3).Value * e.Row.Cells(2).Value), 2)
        igv_cal = Math.Round((subtotal_cal * IGVTasa) / 100, 2)
        total_cal = Math.Round(subtotal_cal + igv_cal, 2)

        With obeT
            .PFD_ITEM = e.Row.Cells(7).Value
            .PFD_CANT = e.Row.Cells(3).Value
            .PFD_IDARTICULO = e.Row.Cells(0).Value
            .PFD_PRECIO = e.Row.Cells(2).Value
            .PFD_TOTAL = subtotal_cal
            .PFD_IDCAB_CUENTA = e.Row.Cells(8).Value
        End With
        obrT.Update(obeT, String.Format("{0}-{1}", Environment.UserName, gStr_Usuario_Sis), Environment.MachineName)

        e.Row.Cells(4).Value = subtotal_cal
        e.Row.Cells(5).Value = igv_cal
        e.Row.Cells(6).Value = total_cal

    End Sub

    Private Sub ubn_Listo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ubn_Listo.Click
        Me.Close()
    End Sub
End Class