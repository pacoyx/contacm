Public Class LO_LT_Ayuda_Prove
    Dim lista As New List(Of BE.LogisticaBE.SG_LO_TB_PROVEEDOR)

    Private Sub LO_LT_Ayuda_Prove_Activated(sender As Object, e As System.EventArgs) Handles Me.Activated
        Focus_Filtro()
    End Sub

    Private Sub LO_LT_Ayuda_Prove_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Call Cargar_Datos()
    End Sub

    Public Function GetLista() As List(Of BE.LogisticaBE.SG_LO_TB_PROVEEDOR)
        Return lista
    End Function

    Private Sub Focus_Filtro()
        If ug_proveedores.Rows.Count = 0 Then Exit Sub
        ug_proveedores.Rows(0).Activate()
        ug_proveedores.Rows.FilterRow.Cells("PR_NDOC").Activate()
        ug_proveedores.PerformAction(Infragistics.Win.UltraWinGrid.UltraGridAction.EnterEditMode)
        SendKeys.Send("{TAB}")
    End Sub

    Private Sub Cargar_Datos()
        Dim proveedorBL As New BL.LogisticaBL.SG_LO_TB_PROVEEDOR
        ug_proveedores.DataSource = proveedorBL.get_Proveedores_ayuda(gInt_IdEmpresa)
        proveedorBL = Nothing
    End Sub

    Private Sub ug_proveedores_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles ug_proveedores.KeyDown

        lista.Clear()
        ug_proveedores.UpdateData()

        If ug_proveedores.Rows.Count > 0 Then

            If e.KeyCode = Keys.Down And ug_proveedores.ActiveRow.IsFilterRow Then
                ug_proveedores.Rows(0).Activate()
            End If

            If e.KeyCode = Keys.Enter Then

                If ug_proveedores.ActiveRow.IsFilterRow Then Exit Sub

                Dim proveedorBE As New BE.LogisticaBE.SG_LO_TB_PROVEEDOR

                proveedorBE.PR_ID = ug_proveedores.ActiveRow.Cells("PR_ID").Value
                proveedorBE.PR_DESCRIPCION = ug_proveedores.ActiveRow.Cells("PR_DESCRIPCION").Value
                proveedorBE.PR_NDOC = ug_proveedores.ActiveRow.Cells("PR_NDOC").Value

                lista.Add(proveedorBE)

                Me.Close()
            End If
        End If

    End Sub

    Private Sub ug_proveedores_DoubleClickRow(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.DoubleClickRowEventArgs) Handles ug_proveedores.DoubleClickRow

        If ug_proveedores.ActiveRow.IsFilterRow Then Exit Sub

        lista.Clear()
        ug_proveedores.UpdateData()

        If ug_proveedores.Rows.Count > 0 Then

            Dim proveedorBE As New BE.LogisticaBE.SG_LO_TB_PROVEEDOR

            proveedorBE.PR_ID = ug_proveedores.ActiveRow.Cells("PR_ID").Value
            proveedorBE.PR_DESCRIPCION = ug_proveedores.ActiveRow.Cells("PR_DESCRIPCION").Value
            proveedorBE.PR_NDOC = ug_proveedores.ActiveRow.Cells("PR_NDOC").Value
            
            lista.Add(proveedorBE)

            Me.Close()
        End If

    End Sub

    Private Sub Tool_Aceptar_Click(sender As System.Object, e As System.EventArgs) Handles Tool_Aceptar.Click

        If ug_proveedores.ActiveRow Is Nothing Then Exit Sub
        If ug_proveedores.Rows.Count = 0 Then Exit Sub

        lista.Clear()
        ug_proveedores.UpdateData()

        Dim proveedorBE As New BE.LogisticaBE.SG_LO_TB_PROVEEDOR

        proveedorBE.PR_ID = ug_proveedores.ActiveRow.Cells("PR_ID").Value
        proveedorBE.PR_DESCRIPCION = ug_proveedores.ActiveRow.Cells("PR_DESCRIPCION").Value
        proveedorBE.PR_NDOC = ug_proveedores.ActiveRow.Cells("PR_NDOC").Value
        proveedorBE.PR_IDANEXO_CONTA = ug_proveedores.ActiveRow.Cells("PR_IDANEXO_CONTA").Value
        lista.Add(proveedorBE)


        Me.Close()

    End Sub

    Private Sub Tool_Salir_Click(sender As System.Object, e As System.EventArgs) Handles Tool_Salir.Click
        lista.Clear()
        Me.Close()
    End Sub


End Class