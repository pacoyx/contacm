Public Class FA_MA_Tratamiento
    Private obe As BE.FacturacionBE.SG_FA_TB_PAQUETE_CAB
    Private obr As BL.FacturacionBL.SG_FA_TB_PAQUETE_CAB
    Private obeT As BE.FacturacionBE.SG_FA_TB_PAQUETE_DET
    Private obrT As BL.FacturacionBL.SG_FA_TB_PAQUETE_DET
    Private lNew As Boolean = False
    Public IGVTas As Double

    Public Sub New()
        InitializeComponent()
        obe = New BE.FacturacionBE.SG_FA_TB_PAQUETE_CAB
        obr = New BL.FacturacionBL.SG_FA_TB_PAQUETE_CAB
        obeT = New BE.FacturacionBE.SG_FA_TB_PAQUETE_DET
        obrT = New BL.FacturacionBL.SG_FA_TB_PAQUETE_DET
    End Sub

    Private Sub pKeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Me.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Return) Then
            SendKeys.Send("{TAB}")
            e.Handled = True
        End If
    End Sub

    Private Sub pLostfocus(ByVal sender As Object, ByVal e As System.EventArgs) ' Handles txt_DesCorto.LostFocus, txt_Descripcion.LostFocus
        sender.BackColor = Color.White
        If sender.Text.Trim.Length < 1 Then
            sender.BackColor = Color.LightPink
        End If
    End Sub

    Private Function fValida() As Boolean

        pLostfocus(txt_Nombre, Nothing)
        pLostfocus(txt_CuentaCon, Nothing)

        If txt_Nombre.BackColor = Color.LightPink Then GoTo Err_Valida
        If txt_CuentaCon.BackColor = Color.LightPink Then GoTo Err_Valida
        Return True
        Exit Function
Err_Valida:
        MessageBox.Show("Corrija ó Complete los campos errados !!", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Return False
    End Function
    Private Sub Inicializa()
        Call Limpiar_Controls_InGroupox(ugb_datos)
        txt_Nombre.BackColor = Color.White
        txt_CuentaCon.BackColor = Color.White
    End Sub
    Private Sub pLoad() Handles MyBase.Load
        Call Inicializar_Estado_Botones_Tool(ToolS_Mantenimiento)
        Call MostrarTabs(0, utc_Datos, 0)

        obe = New BE.FacturacionBE.SG_FA_TB_PAQUETE_CAB
        obr = New BL.FacturacionBL.SG_FA_TB_PAQUETE_CAB
        obeT = New BE.FacturacionBE.SG_FA_TB_PAQUETE_DET
        obrT = New BL.FacturacionBL.SG_FA_TB_PAQUETE_DET

        Me.KeyPreview = True

        Call Formatear_Grilla_Selector(ug_Lista)

        txt_IDArticulo.ButtonsRight(0).Appearance.Image = My.Resources._104

        Dim obj As New DataTable
        obe.PC_IDEMPRESA = gInt_IdEmpresa
        obr.SEL01(obe, obj)
        ug_Lista.DataSource = obj

        ug_Lista.DisplayLayout.Appearance.FontData.Name = "Calibri"

        Inicializa()
    End Sub

    Private Sub Tool_Nuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_Nuevo.Click
        Call Cambiar_Estado_Botones_Tool(ToolS_Mantenimiento)
        Call MostrarTabs(1, utc_Datos, 1)
        Inicializa()

        Dim obj As New DataTable
        Dim obj2 As New DataTable
        obeT.PD_IDCAB = 0
        obeT.PD_IDEMPRESA = gInt_IdEmpresa

        obrT.SEL01(obeT, obj)
        ug_intervalos.DataSource = obj

        obrT.SEL03(obeT, obj2)
        ug_ArticulosTra.DataSource = obj2

        lNew = True
        txt_Nombre.Focus()

    End Sub

    Private Sub Tool_Cancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_Cancelar.Click
        Call Cambiar_Estado_Botones_Tool(ToolS_Mantenimiento)
        Call MostrarTabs(0, utc_Datos, 0)
    End Sub

    Private Sub Tool_Grabar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_Grabar.Click
        If fValida() = False Then Exit Sub

        obe.PC_IDEMPRESA = gInt_IdEmpresa
        obe.PC_USUARIO = String.Format("{0}-{1}", Environment.UserName, gStr_Usuario_Sis)
        obe.PC_TERMINAL = Environment.MachineName
        obe.PC_DESCRIPCION = txt_Nombre.Text
        obe.PC_CuentaCont = txt_CuentaCon.Text
        obe.PC_IDARTICULO = Val(txt_IDArt.Text)
        obe.PC_ESTADO = uos_Estado.Value
        If lNew Then
            Dim i As Integer
            i = obr.Insert(obe, String.Format("{0}-{1}", Environment.UserName, gStr_Usuario_Sis), Environment.MachineName)
            If i > 0 Then
                txt_idTratamiento.Text = i
            Else
                MessageBox.Show("La operación solicitada no ha podido ser realizada", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If
        Else
            obe.PC_ID = Val(txt_idTratamiento.Text)
            obr.Update(obe, String.Format("{0}-{1}", Environment.UserName, gStr_Usuario_Sis), Environment.MachineName)
        End If

        ug_intervalos.UpdateData()
        obeT.PD_IDCAB = Val(txt_idTratamiento.Text)
        obeT.PD_IDEMPRESA = gInt_IdEmpresa
        obrT.Delete(obeT, String.Format("{0}-{1}", Environment.UserName, gStr_Usuario_Sis), Environment.MachineName)
        For f As Integer = 0 To ug_ArticulosTra.Rows.Count - 1
            obeT.PD_IDARTICULO = ug_ArticulosTra.Rows(f).Cells(1).Value
            obeT.PD_CANTIDAD = Val(ug_ArticulosTra.Rows(f).Cells(5).Value)
            obrT.Insert(obeT, String.Format("{0}-{1}", Environment.UserName, gStr_Usuario_Sis), Environment.MachineName)
        Next

        Call Avisar("Listo!")

        Dim obj As New DataTable
        obr.SEL01(obe, obj)
        ug_Lista.DataSource = obj

        ' Call Cambiar_Estado_Botones_Tool(ToolS_Mantenimiento)
        Call Tool_Cancelar_Click(sender, e)

    End Sub

    Private Sub Tool_Editar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_Editar.Click
        If ug_Lista.Rows.Count <= 0 Then Exit Sub
        '  If ug_Lista.ActiveRow.Cells(0).Value = "" Then Exit Sub
        lNew = False

        Call Cambiar_Estado_Botones_Tool(ToolS_Mantenimiento)

        txt_idTratamiento.Text = ug_Lista.ActiveRow.Cells(0).Value
        txt_Nombre.Value = ug_Lista.ActiveRow.Cells(1).Value
        txt_CuentaCon.Value = ug_Lista.ActiveRow.Cells(2).Value
        txt_IDArt.Value = ug_Lista.ActiveRow.Cells(3).Value
        Dim articuloBL As New BL.LogisticaBL.SG_LO_TB_ARTICULO
        Dim dt_tmp As DataTable = articuloBL.get_Articulos_x_id(Val(txt_IDArt.Text), gInt_IdEmpresa)
        If dt_tmp.Rows.Count > 0 Then
            txt_Des_Articulo.Text = dt_tmp.Rows(0)("AR_DESCRIPCION")
            txt_IDArticulo.Text = dt_tmp.Rows(0)("AR_CODIGO")
        Else
            txt_Des_Articulo.Text = ""
            txt_IDArticulo.Text = ""
        End If
        dt_tmp.Dispose()
        articuloBL = Nothing

        uos_Estado.Value = ug_Lista.ActiveRow.Cells("PC_ESTADO").Value

        Dim obj As New DataTable
        Dim obj2 As New DataTable
        obeT.PD_IDCAB = ug_Lista.ActiveRow.Cells(0).Value
        obeT.PD_IDEMPRESA = gInt_IdEmpresa

        obrT.SEL01(obeT, obj)
        ug_intervalos.DataSource = obj

        obrT.SEL03(obeT, obj2)
        ug_ArticulosTra.DataSource = obj2

        Call MostrarTabs(1, utc_Datos, 1)
        txt_Nombre.Focus()

    End Sub
    Private Sub Tool_Eliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_Eliminar.Click
        If ug_Lista.Rows.Count <= 0 Then Exit Sub
        If ug_Lista.ActiveRow.Cells(0).Value <= 0 Then Exit Sub
        If Preguntar("Seguro de Eliminar?") Then
            obe.PC_ID = ug_Lista.ActiveRow.Cells(0).Value
            obe.PC_IDEMPRESA = gInt_IdEmpresa
            If obr.Delete(obe, String.Format("{0}-{1}", Environment.UserName, gStr_Usuario_Sis), Environment.MachineName) < 0 Then
                MessageBox.Show("La operación solicitada no ha podido ser realizada", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                Call Avisar("Listo!")
                Dim obj As New DataTable
                obr.SEL01(obe, obj)
                ug_Lista.DataSource = obj
            End If
        End If

    End Sub

    Private Sub Tool_Salir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_Salir.Click
        Me.Close()
    End Sub

    Private Sub pFormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If Tool_Grabar.Enabled = True Then
            MessageBox.Show("Culmine ó cancele la transacción activa !!!", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
            e.Cancel = True
        Else
            obe = Nothing
            obr = Nothing
            e.Cancel = False
        End If
    End Sub

    Private Sub ug_Lista_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ug_Lista.DoubleClick
        Tool_Editar_Click(sender, e)
    End Sub

    Private Sub ubt_Agregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ubt_Agregar.Click
        ' Dim a As New List(Of Integer)
        For f As Integer = 0 To ug_intervalos.Rows.Count - 1
            If ug_intervalos.Rows(f).Cells(0).Value = True And ug_intervalos.Rows(f).Hidden = False Then
                ug_ArticulosTra.DisplayLayout.Bands(0).AddNew()
                ug_ArticulosTra.Rows(ug_ArticulosTra.Rows.Count - 1).Cells(0).Value = True
                ug_ArticulosTra.Rows(ug_ArticulosTra.Rows.Count - 1).Cells(1).Value = ug_intervalos.Rows(f).Cells(1).Value
                ug_ArticulosTra.Rows(ug_ArticulosTra.Rows.Count - 1).Cells(2).Value = ug_intervalos.Rows(f).Cells(2).Value
                ug_ArticulosTra.Rows(ug_ArticulosTra.Rows.Count - 1).Cells(3).Value = ug_intervalos.Rows(f).Cells(3).Value
                ug_ArticulosTra.Rows(ug_ArticulosTra.Rows.Count - 1).Cells(4).Value = ug_intervalos.Rows(f).Cells(4).Value
                ug_ArticulosTra.Rows(ug_ArticulosTra.Rows.Count - 1).Cells(5).Value = 1
                ug_intervalos.Rows(f).Hidden = True

                'a.Add(ug_intervalos.Rows(f).Cells(1).Value)

            End If
        Next

        'For d As Integer = 0 To ug_intervalos.Rows.Count - 1
        '    For f As Integer = 0 To a.Count - 1
        '        If ug_intervalos.Rows(d).Cells(1).Value = a(f) Then
        '            ug_intervalos.Rows(d).Delete()
        '        End If
        '    Next
        'Next
        
    End Sub

    Private Sub ubt_Quitar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ubt_Quitar.Click
        ug_intervalos.DisplayLayout.Bands(0).AddNew()
        ug_intervalos.Rows(ug_intervalos.Rows.Count - 1).Cells(0).Value = False
        ug_intervalos.Rows(ug_intervalos.Rows.Count - 1).Cells(1).Value = ug_ArticulosTra.ActiveRow.Cells(1).Value
        ug_intervalos.Rows(ug_intervalos.Rows.Count - 1).Cells(2).Value = ug_ArticulosTra.ActiveRow.Cells(2).Value
        ug_intervalos.Rows(ug_intervalos.Rows.Count - 1).Cells(3).Value = ug_ArticulosTra.ActiveRow.Cells(3).Value
        ug_intervalos.Rows(ug_intervalos.Rows.Count - 1).Cells(4).Value = ug_ArticulosTra.ActiveRow.Cells(4).Value
        ug_ArticulosTra.ActiveRow.Delete()
    End Sub

    Private Sub ug_ArticulosTra_BeforeRowsDeleted(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinGrid.BeforeRowsDeletedEventArgs) Handles ug_ArticulosTra.BeforeRowsDeleted
        e.DisplayPromptMsg = False
    End Sub

    Private Sub ug_ArticulosTra_DoubleClickRow(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinGrid.DoubleClickRowEventArgs) Handles ug_ArticulosTra.DoubleClickRow
        ug_intervalos.DisplayLayout.Bands(0).AddNew()
        ug_intervalos.Rows(ug_intervalos.Rows.Count - 1).Cells(0).Value = False
        ug_intervalos.Rows(ug_intervalos.Rows.Count - 1).Cells(1).Value = ug_ArticulosTra.ActiveRow.Cells(1).Value
        ug_intervalos.Rows(ug_intervalos.Rows.Count - 1).Cells(2).Value = ug_ArticulosTra.ActiveRow.Cells(2).Value
        ug_intervalos.Rows(ug_intervalos.Rows.Count - 1).Cells(3).Value = ug_ArticulosTra.ActiveRow.Cells(3).Value
        ug_intervalos.Rows(ug_intervalos.Rows.Count - 1).Cells(4).Value = ug_ArticulosTra.ActiveRow.Cells(4).Value

        ug_ArticulosTra.ActiveRow.Delete()
    End Sub

    Private Sub ug_intervalos_BeforeRowsDeleted(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinGrid.BeforeRowsDeletedEventArgs) Handles ug_intervalos.BeforeRowsDeleted
        e.DisplayPromptMsg = False
    End Sub

    Private Sub ug_intervalos_DoubleClickRow(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinGrid.DoubleClickRowEventArgs) Handles ug_intervalos.DoubleClickRow
        If ug_intervalos.ActiveRow.IsFilterRow Then Exit Sub
        ug_ArticulosTra.DisplayLayout.Bands(0).AddNew()
        ug_ArticulosTra.Rows(ug_ArticulosTra.Rows.Count - 1).Cells(0).Value = True
        ug_ArticulosTra.Rows(ug_ArticulosTra.Rows.Count - 1).Cells(1).Value = ug_intervalos.ActiveRow.Cells(1).Value
        ug_ArticulosTra.Rows(ug_ArticulosTra.Rows.Count - 1).Cells(2).Value = ug_intervalos.ActiveRow.Cells(2).Value
        ug_ArticulosTra.Rows(ug_ArticulosTra.Rows.Count - 1).Cells(3).Value = ug_intervalos.ActiveRow.Cells(3).Value
        ug_ArticulosTra.Rows(ug_ArticulosTra.Rows.Count - 1).Cells(4).Value = ug_intervalos.ActiveRow.Cells(4).Value
        ug_ArticulosTra.Rows(ug_ArticulosTra.Rows.Count - 1).Cells(5).Value = 1
        ug_intervalos.ActiveRow.Delete()
    End Sub

    Private Sub Ayuda_Articulo()

        FA_PR_ListaArticuloAyuda.Int_Opcion = 1
        FA_PR_ListaArticuloAyuda.IGVTas = 18.0
        FA_PR_ListaArticuloAyuda.ShowDialog()

        Dim matriz As List(Of BE.FacturacionBE.SG_FA_TB_ARTICULO) = FA_PR_ListaArticuloAyuda.GetLista

        For Each articulo As BE.FacturacionBE.SG_FA_TB_ARTICULO In matriz
            txt_IDArt.Text = articulo.AR_ID
            txt_IDArticulo.Text = articulo.AR_CODIGO
            txt_Des_Articulo.Text = articulo.AR_DESCRIPCION
        Next

    End Sub

    Private Sub Buscar_Articulo()
        Dim articuloBL As New BL.LogisticaBL.SG_LO_TB_ARTICULO
        Dim drr_MOV As System.Data.SqlClient.SqlDataReader
        drr_MOV = articuloBL.get_Articulos_x_Codigo(txt_IDArticulo.Text, gInt_IdEmpresa)
        If drr_MOV.HasRows Then
            drr_MOV.Read()
            txt_Des_Articulo.Text = drr_MOV("AR_DESCRIPCION")
            txt_IDArt.Text = drr_MOV("AR_ID")
        Else
            Avisar("El Articulo no Existe.")
        End If
        drr_MOV.Close()
        articuloBL = Nothing
    End Sub

    Private Sub txt_IDArticulo_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_IDArticulo.ValueChanged
        If txt_IDArticulo.Text.Trim.Length = 0 Then
            txt_IDArticulo.Text = String.Empty
            txt_IDArt.Text = String.Empty
            txt_Des_Articulo.Text = String.Empty
        End If
    End Sub
    Private Sub txt_IDArticulo_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_IDArticulo.KeyDown
        If e.KeyCode = Keys.F2 Then
            Call Ayuda_Articulo()
        End If
        If e.KeyCode = Keys.Enter Then
            Call Buscar_Articulo()
        End If
    End Sub
    Private Sub txt_IDArticulo_EditorButtonClick(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinEditors.EditorButtonEventArgs) Handles txt_IDArticulo.EditorButtonClick
        Call Ayuda_Articulo()
    End Sub
    Private Sub ug_Lista_InitializeRow(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinGrid.InitializeRowEventArgs) Handles ug_Lista.InitializeRow
        If e.Row.Cells("PC_ESTADO").Value = 0 Then
            e.Row.Appearance.ForeColor = Color.Tomato
        End If
    End Sub
End Class