Public Class BB_MA_UBICACION
    Private obe As BE.NeoBE.SA_TB_BB_UBICACION
    Private obr As BL.NeoBL.SA_TB_BB_UBICACION
    Private lNew As Boolean = False
    Public Sub New()
        InitializeComponent()
        obe = New BE.NeoBE.SA_TB_BB_UBICACION
        obr = New BL.NeoBL.SA_TB_BB_UBICACION
    End Sub

    Private Sub pKeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Me.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Return) Then
            SendKeys.Send("{TAB}")
            e.Handled = True
        End If
    End Sub
    Private Sub pLostfocus(ByVal sender As Object, ByVal e As System.EventArgs)
        sender.BackColor = Color.White
        If sender.Text.Trim.Length < 1 Then
            sender.BackColor = Color.LightPink
        End If
    End Sub
    Private Function fValida() As Boolean
        pLostfocus(txt_des, Nothing)
        pLostfocus(txt_IDArticulo, Nothing)
        pLostfocus(ucb_tip, Nothing)
        If txt_des.BackColor = Color.LightPink Then GoTo Err_Valida
        If txt_IDArticulo.BackColor = Color.LightPink Then GoTo Err_Valida
        If ucb_tip.BackColor = Color.LightPink Then GoTo Err_Valida
        Return True
        Exit Function
Err_Valida:
        MessageBox.Show("Corrija ó Complete los campos errados !!", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Return False
    End Function
    Private Sub Inicializa()
        Call Limpiar_Controls_InGroupox(ugb_Datos)
        txt_des.BackColor = Color.White
        txt_IDArticulo.BackColor = Color.White
        ucb_tip.BackColor = Color.White
    End Sub
    Private Sub BB_MA_UBICACION_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call Inicializar_Estado_Botones_Tool(ToolS_Mantenimiento)
        Call MostrarTabs(0, utc_incuba, 0)

        obe = New BE.NeoBE.SA_TB_BB_UBICACION
        obr = New BL.NeoBL.SA_TB_BB_UBICACION
        Me.KeyPreview = True

        Dim TipoBL As New BL.NeoBL.SA_TB_BB_TIPO_UBI
        ucb_tip.DataSource = TipoBL.SEL01()
        ucb_tip.DisplayMember = "TI_DESCRIPCION"
        ucb_tip.ValueMember = "TI_ID"
        TipoBL = Nothing

        Call Formatear_Grilla_Selector(ug_incuba)
        obe.UB_IDEMPRESA = gInt_IdEmpresa
        ug_incuba.DataSource = obr.SEL01(obe)

        txt_IDArticulo.ButtonsRight(0).Appearance.Image = My.Resources._104

        Inicializa()
    End Sub
    Private Sub Tool_Nuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_Nuevo.Click
        Call Cambiar_Estado_Botones_Tool(ToolS_Mantenimiento)
        Call MostrarTabs(1, utc_incuba, 1)
        Inicializa()
        lNew = True
        txt_des.Focus()
    End Sub

    Private Sub Tool_Cancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_Cancelar.Click
        Call Cambiar_Estado_Botones_Tool(ToolS_Mantenimiento)
        Call MostrarTabs(0, utc_incuba, 0)
    End Sub
    Private Sub Tool_Grabar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_Grabar.Click
        If fValida() = False Then Exit Sub

        With obe
            .UB_ID = Val(txt_cod.Text)
            .UB_NOMBRE = txt_des.Text
            .UB_IDTIPO = ucb_tip.Value
            .UB_IDARTICULO = txt_IDArt.Text
            .UB_ESTADO = uos_Estado.Value
            .UB_IDEMPRESA = gInt_IdEmpresa
        End With

        If lNew Then
            Dim i As Integer
            i = obr.Insert(obe, String.Format("{0}-{1}", Environment.UserName, gStr_Usuario_Sis), Environment.MachineName)
            txt_cod.Text = i
            If i < 0 Then
                MessageBox.Show("La operación solicitada no ha podido ser realizada", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If
        Else
            If obr.Update(obe, String.Format("{0}-{1}", Environment.UserName, gStr_Usuario_Sis), Environment.MachineName) < 0 Then
                MessageBox.Show("La operación solicitada no ha podido ser realizada", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If
        End If
        Call Avisar("Listo!")
        obe.UB_IDEMPRESA = gInt_IdEmpresa
        ug_incuba.DataSource = obr.SEL01(obe)

        Call Cambiar_Estado_Botones_Tool(ToolS_Mantenimiento)
        Call Tool_Nuevo_Click(sender, e)
    End Sub
    Private Sub Tool_Editar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_Editar.Click
        If ug_incuba.Rows.Count <= 0 Then Exit Sub
        lNew = False

        Call Cambiar_Estado_Botones_Tool(ToolS_Mantenimiento)

        txt_cod.Text = ug_incuba.ActiveRow.Cells(0).Value
        txt_des.Text = ug_incuba.ActiveRow.Cells(1).Value
        ucb_tip.Value = ug_incuba.ActiveRow.Cells(2).Value
        txt_IDArt.Text = ug_incuba.ActiveRow.Cells(4).Value
        uos_Estado.Value = ug_incuba.ActiveRow.Cells(5).Value

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

        Call MostrarTabs(1, utc_incuba, 1)
        txt_des.Focus()

    End Sub

    Private Sub Tool_Eliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_Eliminar.Click
        If ug_incuba.Rows.Count <= 0 Then Exit Sub
        If Preguntar("Seguro de Eliminar?") Then
            obe.UB_ID = ug_incuba.ActiveRow.Cells(0).Value
            If obr.Delete(obe, String.Format("{0}-{1}", Environment.UserName, gStr_Usuario_Sis), Environment.MachineName) < 0 Then
                MessageBox.Show("La operación solicitada no ha podido ser realizada", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                Call Avisar("Listo!")
                obe.UB_IDEMPRESA = gInt_IdEmpresa
                ug_incuba.DataSource = obr.SEL01(obe)
            End If
        End If
    End Sub

    Private Sub ug_incuba_DoubleClickRow(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinGrid.DoubleClickRowEventArgs) Handles ug_incuba.DoubleClickRow
        Tool_Editar_Click(sender, e)
    End Sub
    Private Sub ug_incuba_InitializeRow(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinGrid.InitializeRowEventArgs) Handles ug_incuba.InitializeRow
        If e.Row.Cells(5).Value = 0 Then
            e.Row.Appearance.ForeColor = Color.Tomato
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

End Class