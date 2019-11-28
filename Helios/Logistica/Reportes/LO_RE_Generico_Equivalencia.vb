Public Class LO_RE_Generico_Equivalencia
    Private obr As BL.LogisticaBL.SG_LO_TB_ARTICULO

    Public Sub New()
        InitializeComponent()
        obr = New BL.LogisticaBL.SG_LO_TB_ARTICULO
    End Sub

    Private Sub pKeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Me.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Return) Then
            SendKeys.Send("{TAB}")
            e.Handled = True
        End If
    End Sub

    Private Sub Cancelar()
        uds_Lista.Rows.Clear()
        ug_Lista.DataSource = uds_Lista

        Call LimpiaGrid(ug_ListaDet, uds_ListaDet)

    End Sub

    Private Sub LO_RE_Generico_Equivalencia_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        ubtn_Consultar.Appearance.Image = My.Resources._16__Search_

        obr = New BL.LogisticaBL.SG_LO_TB_ARTICULO

        Dim GenericoBL As New BL.LogisticaBL.SG_LO_TB_GENERICO
        uce_Generico.DataSource = GenericoBL.SEL01(gInt_IdEmpresa)
        uce_Generico.DisplayMember = "GE_DESCRIPCION"
        uce_Generico.ValueMember = "GE_ID"
        GenericoBL = Nothing

        Cancelar()

        Me.KeyPreview = True

        uce_Generico.Focus()
    End Sub

    Private Sub Tool_Cancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_Cancelar.Click
        Cancelar()
    End Sub

    Private Sub Tool_Salir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_Salir.Click
        Me.Close()
    End Sub

    Private Sub ug_Lista_AfterSelectChange(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinGrid.AfterSelectChangeEventArgs) Handles ug_Lista.AfterSelectChange
        If ug_Lista.ActiveRow.IsFilterRow Then Exit Sub
        If ug_Lista.Rows.Count = 0 Then Exit Sub
        ug_ListaDet.DataSource = obr.get_Articulos_generico(gInt_IdEmpresa, Val(ug_Lista.ActiveRow.Cells(0).Value))
    End Sub

    Private Sub ubtn_Consultar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ubtn_Consultar.Click
        
        ug_Lista.DisplayLayout.Bands(0).AddNew()
        ug_Lista.Rows(ug_Lista.Rows.Count - 1).Cells("GE_ID").Value = uce_Generico.Value
        ug_Lista.Rows(ug_Lista.Rows.Count - 1).Cells("GE_DESCRIPCION").Value = uce_Generico.Text

        ug_Lista.UpdateData()
        ug_Lista.Refresh()

        ug_ListaDet.DataSource = obr.get_Articulos_generico(gInt_IdEmpresa, Val(ug_Lista.ActiveRow.Cells(0).Value))
    End Sub

    Private Sub ubtn_Quitar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ubtn_Quitar.Click
        If ug_Lista.Rows.Count = 0 Then Exit Sub
        If ug_Lista.ActiveRow Is Nothing Then Exit Sub

        ug_Lista.ActiveRow.Delete()
        LimpiaGrid(ug_ListaDet, uds_ListaDet)
    End Sub

    Private Sub ug_Lista_BeforeRowsDeleted(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinGrid.BeforeRowsDeletedEventArgs) Handles ug_Lista.BeforeRowsDeleted
        e.DisplayPromptMsg = False
        e.Cancel = False
    End Sub

    Private Sub Tool_Imprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_Imprimir.Click
        Me.Cursor = Cursors.WaitCursor

        Dim reportesfaBL As New BL.FacturacionBL.SG_FA_Reportes
        Dim crystalBL As New LR.ClsReporte
        Dim dt_data As New DataTable

        dt_data = obr.get_Articulos_generico(gInt_IdEmpresa, Val(ug_Lista.ActiveRow.Cells(0).Value))
        crystalBL.Muestra_Reporte(gStr_RutaRep & "\SG_LO_02.RPT", dt_data, "", "CODIGO;" & Val(ug_Lista.ActiveRow.Cells(0).Value), "DESCRIPCION;" & ug_Lista.ActiveRow.Cells(1).Value)
        crystalBL = Nothing
        reportesfaBL = Nothing

        Me.Cursor = Cursors.Default
    End Sub
End Class