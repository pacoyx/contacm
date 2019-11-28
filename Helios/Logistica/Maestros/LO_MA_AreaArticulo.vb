Public Class LO_MA_AreaArticulo
    Private obe As BE.LogisticaBE.SG_LO_TB_ARTICULOS_AREA
    Private obr As BL.LogisticaBL.SG_LO_TB_ARTICULOS_AREA
    Private lNew As Boolean = False
    Public IGVTas As Double

    Public Sub New()
        InitializeComponent()
        obe = New BE.LogisticaBE.SG_LO_TB_ARTICULOS_AREA
        obr = New BL.LogisticaBL.SG_LO_TB_ARTICULOS_AREA
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

        pLostfocus(ucb_Area, Nothing)
        pLostfocus(ucbOrigen, Nothing)

        If ucb_Area.BackColor = Color.LightPink Then GoTo Err_Valida
        If ucbOrigen.BackColor = Color.LightPink Then GoTo Err_Valida
        Return True
        Exit Function
Err_Valida:
        MessageBox.Show("Corrija ó Complete los campos errados !!", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Return False
    End Function
    Private Sub Inicializa()
        Call Limpiar_Controls_InGroupox(ugb_datos)
        ucb_Area.BackColor = Color.White
        ucbOrigen.BackColor = Color.White
        ucbo_Procesar.Enabled = True
        ucb_Area.ReadOnly = False
        ucbOrigen.ReadOnly = False
    End Sub

    Private Sub LO_MA_AreaArticulo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim AreBL As New BL.LogisticaBL.SG_LO_TB_AREA
        ucb_Area.DataSource = AreBL.getar(gInt_IdEmpresa)
        ucb_Area.DisplayMember = "AR_DESCRIPCION"
        ucb_Area.ValueMember = "AR_ID"
        AreBL = Nothing

        Dim OrigBL As New BL.LogisticaBL.SG_LO_TB_ORIGEN
        Dim OrigBE As New BE.LogisticaBE.SG_LO_TB_ORIGEN
        OrigBE.OR_IDEMPRESA = gInt_IdEmpresa
        ucbOrigen.DataSource = OrigBL.SEL01(OrigBE)
        ucbOrigen.DisplayMember = "OR_NOMBRE"
        ucbOrigen.ValueMember = "OR_ID"
        OrigBL = Nothing

        Call Inicializar_Estado_Botones_Tool(ToolS_Mantenimiento)
        Call MostrarTabs(0, utc_Datos, 0)

        obe = New BE.LogisticaBE.SG_LO_TB_ARTICULOS_AREA
        obr = New BL.LogisticaBL.SG_LO_TB_ARTICULOS_AREA

        Me.KeyPreview = True

        Call Formatear_Grilla_Selector(ug_Lista)

        obe.AA_IDEMPRESA = gInt_IdEmpresa
        ug_Lista.DataSource = obr.SEL01(obe)

        Inicializa()
    End Sub

    Private Sub Tool_Nuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_Nuevo.Click
        Call Cambiar_Estado_Botones_Tool(ToolS_Mantenimiento)
        Call MostrarTabs(1, utc_Datos, 1)
        Inicializa()

        'obe.AA_IDEMPRESA = gInt_IdEmpresa
        'ug_intervalos.DataSource = obr.SEL02(obe, ucbOrigen.Value)
        'ug_ArticulosTra.DataSource = obr.SEL03(obe, ucbOrigen.Value)

        lNew = True
    End Sub

    Private Sub Tool_Cancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_Cancelar.Click
        Call Cambiar_Estado_Botones_Tool(ToolS_Mantenimiento)
        Call MostrarTabs(0, utc_Datos, 0)
    End Sub

    Private Sub Tool_Grabar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_Grabar.Click
        If fValida() = False Then Exit Sub
        obe.AA_IDAREA = ucb_Area.Value
        obe.AA_IDEMPRESA = gInt_IdEmpresa
        obr.Delete(obe, ucbOrigen.Value)
        For f As Integer = 0 To ug_ArticulosTra.Rows.Count - 1
            obe.AA_IDARTICULO = ug_ArticulosTra.Rows(f).Cells(1).Value
            obr.Insert(obe)
        Next

        Call Avisar("Listo!")

        obe.AA_IDEMPRESA = gInt_IdEmpresa
        ug_Lista.DataSource = obr.SEL01(obe)

        ' Call Cambiar_Estado_Botones_Tool(ToolS_Mantenimiento)
        Call Tool_Cancelar_Click(sender, e)

    End Sub

    Private Sub Tool_Editar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_Editar.Click
        If ug_Lista.Rows.Count <= 0 Then Exit Sub
        '  If ug_Lista.ActiveRow.Cells(0).Value = "" Then Exit Sub
        lNew = False

        Call Cambiar_Estado_Botones_Tool(ToolS_Mantenimiento)

        ucb_Area.Value = ug_Lista.ActiveRow.Cells(0).Value
        ucbOrigen.Value = ug_Lista.ActiveRow.Cells(3).Value

        obe.AA_IDAREA = ucb_Area.Value
        obe.AA_IDEMPRESA = gInt_IdEmpresa
        ug_intervalos.DataSource = obr.SEL02(obe, ucbOrigen.Value)
        ug_ArticulosTra.DataSource = obr.SEL03(obe, ucbOrigen.Value)

        Call MostrarTabs(1, utc_Datos, 1)
        ug_intervalos.Focus()

        ucb_Area.ReadOnly = True
        ucbOrigen.ReadOnly = True
        ucbo_Procesar.Enabled = False
    End Sub

    Private Sub Tool_Eliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_Eliminar.Click
        If ug_Lista.Rows.Count <= 0 Then Exit Sub
        If ug_Lista.ActiveRow.Cells(0).Value <= 0 Then Exit Sub
        If Preguntar("Seguro de Eliminar?") Then
            obe.AA_IDAREA = ug_Lista.ActiveRow.Cells(0).Value
            obe.AA_IDEMPRESA = gInt_IdEmpresa
            If obr.Delete(obe, ucbOrigen.Value) < 0 Then
                MessageBox.Show("La operación solicitada no ha podido ser realizada", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                Call Avisar("Listo!")
                ug_Lista.DataSource = obr.SEL01(obe)
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

    Private Sub ucbo_Procesar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ucbo_Procesar.Click
        obe.AA_IDEMPRESA = gInt_IdEmpresa
        obe.AA_IDAREA = ucb_Area.Value
        If obr.SEL03(obe, ucbOrigen.Value).Rows.Count > 0 Then
            Avisar("El Area con el origen ya tiene articulos")
            Exit Sub
        End If
        ug_intervalos.DataSource = obr.SEL02(obe, ucbOrigen.Value)
        ug_ArticulosTra.DataSource = obr.SEL03(obe, ucbOrigen.Value)
        ucb_Area.ReadOnly = True
        ucbOrigen.ReadOnly = True
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
        ug_intervalos.ActiveRow.Delete()
    End Sub

End Class