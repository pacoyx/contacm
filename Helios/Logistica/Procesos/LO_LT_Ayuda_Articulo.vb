Public Class LO_LT_Ayuda_Articulo
    Public bol_aceptar As Boolean = False
    Public lista As New List(Of String)
    Private Sub LO_LT_Ayuda_Articulo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call cargar_grilla()
        'Call Formatear_Grilla_Selector(ug_arti)
    End Sub
    Public Sub cargar_grilla()
        Dim arti As New BL.LogisticaBL.SG_FA_TB_ARTICULO_UNIDAD_MEDIDA
        ug_arti.DataSource = arti.get_req(gInt_IdEmpresa)
        ug_arti.DisplayLayout.Bands(0).Columns(0).Header.Caption = "Codigo"
        ug_arti.DisplayLayout.Bands(0).Columns(1).Header.Caption = "Descripcion"
        ug_arti.DisplayLayout.Bands(0).Columns(2).Header.Caption = "Uni_Med"
        ug_arti.DisplayLayout.Bands(0).Columns(3).Header.Caption = "Uni_Des"
        arti = Nothing
    End Sub
    Private Sub Tool_salir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_salir.Click
        bol_aceptar = False
        Me.Close()
    End Sub
    Private Sub Tool_aceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_aceptar.Click
        bol_aceptar = True
        If ug_arti.Rows.Count = 0 Then
            Avisar("NO SE ENCONTRARON ARTICULOS")
            Exit Sub
        End If
        If ug_arti.ActiveRow Is Nothing Then
            Avisar("SELECCIONE UNA FILA")
            Exit Sub
        End If
        Call listar_grilla()
        Me.Close()
    End Sub
    Public Sub listar_grilla()
        lista.Clear()
        lista.Add(ug_arti.ActiveRow.Cells("AR_ID").Value.ToString)
        lista.Add(ug_arti.ActiveRow.Cells("AR_DESCRIPCION").Value.ToString)
        lista.Add(ug_arti.ActiveRow.Cells("UM_ID").Value.ToString)
        lista.Add(ug_arti.ActiveRow.Cells("UM_DESCRIPCION").Value.ToString)
    End Sub
End Class