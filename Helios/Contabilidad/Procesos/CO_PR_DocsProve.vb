Public Class CO_PR_DocsProve

    Public pIdProveedor As Integer
    Public pNum_detra As String
    Public pFecha_detra As String
    Public pbol_aceptar As Boolean = False


    Private Sub CO_PR_DocsProve_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call Cargar_Docs_proveedor()
        txt_fecha_detra.Text = pFecha_detra
        txt_num_detra.Text = pNum_detra
    End Sub

    Private Sub Cargar_Docs_proveedor()
        Dim contaBL As New BL.ContabilidadBL.SG_CO_TB_ASIENTO_CONTABLE
        ug_Documentos.DataSource = contaBL.get_Docs_x_Proveedor(pIdProveedor, gInt_IdEmpresa)
        contaBL = Nothing
    End Sub

    Private Sub ug_Documentos_DoubleClickRow(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.DoubleClickRowEventArgs) Handles ug_Documentos.DoubleClickRow

        'If ug_Documentos.ActiveRow.IsFilterRow Then Exit Sub
        'If ug_Documentos.ActiveRow Is Nothing Then Exit Sub

        'Dim contaBL As New BL.ContabilidadBL.SG_CO_TB_ASIENTO_CONTABLE
        'Dim pIdDocumento As Integer = ug_Documentos.ActiveRow.Cells("ID_DOC").Value

        'contaBL.Actualiza_Info_factura_detraccion(pIdDocumento, pNum_detra, pFecha_detra)
        'pbol_aceptar = True
        'contaBL = Nothing
        'Me.Close()

    End Sub

    Private Sub Tool_Salir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_Salir.Click
        pbol_aceptar = False
        Me.Close()
    End Sub

 
    Private Sub Tool_Aceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_Aceptar.Click

        Dim contaBL As New BL.ContabilidadBL.SG_CO_TB_ASIENTO_CONTABLE
        Dim pIdDocumento As Integer = 0

        ug_Documentos.UpdateData()
        Me.Cursor = Cursors.WaitCursor
        For i As Integer = 0 To ug_Documentos.Rows.Count - 1
            If ug_Documentos.Rows(i).Cells("Sel").Value Then
                pIdDocumento = ug_Documentos.Rows(i).Cells("ID_DOC").Value
                contaBL.Actualiza_Info_factura_detraccion(pIdDocumento, pNum_detra, pFecha_detra)
            End If
        Next
        Me.Cursor = Cursors.Default

        pbol_aceptar = True
        contaBL = Nothing
        Me.Close()
        'probando el vss

    End Sub
End Class