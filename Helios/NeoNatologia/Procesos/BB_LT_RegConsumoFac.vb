Imports Infragistics.Win.UltraWinGrid
Public Class BB_LT_RegConsumoFac
    Private obe As BE.NeoBE.SA_TB_BB_CONSUMO
    Private obr As BL.NeoBL.SA_TB_BB_CONSUMO
    Public lNew As Boolean = False
    Public Sub New()
        InitializeComponent()
        obe = New BE.NeoBE.SA_TB_BB_CONSUMO
        obr = New BL.NeoBL.SA_TB_BB_CONSUMO
    End Sub
    Private Sub pKeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Me.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Return) Then
            SendKeys.Send("{TAB}")
            e.Handled = True
        End If
    End Sub
    Private Sub pKeyPressNumero(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_Cantidad.KeyPress
        e.KeyChar = fKeyPress(e.KeyChar, sender.Text, 1)
        e.Handled = (e.KeyChar = "")
    End Sub
    Private Sub pLostfocus(ByVal sender As Object, ByVal e As System.EventArgs)
        sender.BackColor = Color.White
        If sender.Text.Trim.Length < 1 Then
            sender.BackColor = Color.LightPink
        End If
    End Sub

    Private Sub Inicializa()
        dtp_FechaIngreso.Value = Now
        Call Limpiar_Controls_InGroupox(ugb_Datos)
        uce_Articulo.BackColor = Color.White

        uce_Articulo.SelectedIndex = 0
        dtp_FechaIngreso.Value = Now
        ume_horaFin.Value = Nothing
        ume_Horainicio.Value = Nothing
        utxt_TotalHoras.Value = Nothing
        ulbl_UnidadMedida.Visible = False
    End Sub

    Private Function fValida() As Boolean
        pLostfocus(uce_Articulo, Nothing)

        If uce_Articulo.BackColor = Color.LightPink Then GoTo Err_Valida
        Return True
        Exit Function
Err_Valida:
        MessageBox.Show("Corrija ó Complete los campos errados !!", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Return False
    End Function

    Private Sub CargarLista()
        Call Formatear_Grilla_Selector(ug_Lista)
        obe.CB_IDREGISTRO = Val(txt_idRegistro.Text)
        ug_Lista.DataSource = obr.SEL02(obe)
    End Sub

    Private Sub BB_LT_RegConsumoFac_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim ArtiBL As New BL.FacturacionBL.SG_FA_TB_ARTICULO
        uce_Articulo.DataSource = ArtiBL.get_Articulos_Ayuda05(gInt_IdEmpresa, "007", "VE")
        uce_Articulo.DisplayMember = "AR_DESCRIPCION"
        uce_Articulo.ValueMember = "AR_ID"
        ArtiBL = Nothing

        'Dim uniMedBL As New BL.LogisticaBL.SG_LO_TB_UNI_MED
        'uce_um_venta.DataSource = uniMedBL.getMedidas(gInt_IdEmpresa)
        'uce_um_venta.DisplayMember = "UM_DESCRIPCION"
        'uce_um_venta.ValueMember = "UM_ID"
        'uniMedBL = Nothing

        Inicializa()

        Call Inicializar_Estado_Botones_Tool(ToolS_Mantenimiento)
        Call MostrarTabs(0, utc_Datos, 0)

        obe = New BE.NeoBE.SA_TB_BB_CONSUMO
        obr = New BL.NeoBL.SA_TB_BB_CONSUMO

        Me.KeyPreview = True
        CargarLista()
    End Sub

    '---menu
    Private Sub Tool_Grabar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_Grabar.Click
        If fValida() = False Then Exit Sub
        Dim comproBL As New BL.FacturacionBL.SG_FA_TB_COMPROBANTE_C
        If comproBL.Existe_Comprob_Cuenta(Val(txt_IDCUENTA.Text)) Then
            Call Avisar("La Cuenta ya fue facturada, No puede usarla.")
            'Inicializa()
            Exit Sub
        End If
        comproBL = Nothing

        With obe
            .CB_IDUBICACION = 0
            .CB_IDARTICULO = uce_Articulo.Value
            .CB_FECHA = dtp_FechaIngreso.Value
            .CB_HORA_INI = IIf(ume_Horainicio.Text = ":", "", ume_Horainicio.Value)
            .CB_HORA_FIN = IIf(ume_horaFin.Text = ":", "", ume_horaFin.Value)
            .CB_IDREGISTRO = Val(txt_idRegistro.Text)
            .CB_OBSERVACION = txt_Observacion.Text
            .CB_ITEM = Val(txt_IdItem.Text)
            .CB_CANTIDAD = Val(txt_Cantidad.Text)
            .CB_TOTAL_HORAS = IIf(utxt_TotalHoras.Text = ":", "", utxt_TotalHoras.Value)
        End With

        If lNew Then
            If obr.Insert(obe, String.Format("{0}-{1}", Environment.UserName, gStr_Usuario_Sis), Environment.MachineName) < 0 Then
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

        CargarLista()

        Call Cambiar_Estado_Botones_Tool(ToolS_Mantenimiento)
        Call MostrarTabs(0, utc_Datos, 0)

    End Sub

    Private Sub Tool_Salir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_Salir.Click
        Me.Close()
    End Sub

    Private Sub Tool_Nuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_Nuevo.Click
        Call Cambiar_Estado_Botones_Tool(ToolS_Mantenimiento)
        Call MostrarTabs(1, utc_Datos, 1)
        Inicializa()
        lNew = True
    End Sub

    Private Sub Tool_Cancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_Cancelar.Click
        Call Cambiar_Estado_Botones_Tool(ToolS_Mantenimiento)
        Call MostrarTabs(0, utc_Datos, 0)
    End Sub

    Private Sub Tool_Editar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_Editar.Click
        If ug_Lista.Rows.Count = 0 Then Exit Sub
        If ug_Lista.ActiveRow Is Nothing Then Exit Sub

        If ug_Lista.ActiveRow.Cells(8).Value = 0 Then
            Avisar("El Registro ya esta Anulado")
            Exit Sub
        End If
        lNew = False

        Call Cambiar_Estado_Botones_Tool(ToolS_Mantenimiento)

        txt_IdItem.Text = ug_Lista.ActiveRow.Cells(0).Value
        uce_Articulo.Value = ug_Lista.ActiveRow.Cells(1).Value

        dtp_FechaIngreso.Value = ug_Lista.ActiveRow.Cells(4).Value
        ume_horaFin.Value = ug_Lista.ActiveRow.Cells(6).Value
        ume_Horainicio.Value = ug_Lista.ActiveRow.Cells(5).Value
        txt_Observacion.Text = ug_Lista.ActiveRow.Cells(7).Value
        txt_Cantidad.Text = ug_Lista.ActiveRow.Cells(9).Value
        utxt_TotalHoras.Value = ug_Lista.ActiveRow.Cells(10).Value
        Call MostrarTabs(1, utc_Datos, 1)

    End Sub

    Private Sub Tool_Eliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_Eliminar.Click
        If ug_Lista.Rows.Count = 0 Then Exit Sub
        If ug_Lista.ActiveRow Is Nothing Then Exit Sub
        Dim comproBL As New BL.FacturacionBL.SG_FA_TB_COMPROBANTE_C
        If comproBL.Existe_Comprob_Cuenta(Val(txt_IDCUENTA.Text)) Then
            Call Avisar("La Cuenta ya fue facturada, No puede usarla.")
            'Inicializa()
            Exit Sub

        End If
        comproBL = Nothing

        If ug_Lista.ActiveRow.Cells(8).Value = 0 Then
            Avisar("El Registro ya esta Anulado")
            Exit Sub
        End If

        If Preguntar("Seguro de Eliminar?") Then
            obe.CB_IDREGISTRO = Val(txt_idRegistro.Text)
            obe.CB_ITEM = ug_Lista.ActiveRow.Cells(0).Value
            If obr.Delete(obe, String.Format("{0}-{1}", Environment.UserName, gStr_Usuario_Sis), Environment.MachineName) < 0 Then
                MessageBox.Show("La operación solicitada no ha podido ser realizada", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                Call Avisar("Listo!")
                CargarLista()
            End If
        End If

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

    Private Sub ug_Lista_InitializeRow(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinGrid.InitializeRowEventArgs) Handles ug_Lista.InitializeRow
        If e.Row.Cells(8).Value = 0 Then
            e.Row.Appearance.ForeColor = Color.Tomato
        End If
    End Sub

    Private Sub uce_Articulo_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles uce_Articulo.ValueChanged
        'Dim articuloBL As New BL.LogisticaBL.SG_LO_TB_ARTICULO
        'Dim dt_tmp As DataTable = articuloBL.get_Articulos_x_id(uce_Articulo.Value, gInt_IdEmpresa)
        'If dt_tmp.Rows.Count > 0 Then
        '    With dt_tmp
        '        uce_um_venta.Value = .Rows(0)("AR_UM_VENTA")
        '    End With
        'End If

        'dt_tmp.Dispose()
        'articuloBL = s
        If uce_Articulo.Value = "156" Then
            ulbl_UnidadMedida.Visible = True
        Else
            ulbl_UnidadMedida.Visible = False
        End If

    End Sub

    Private Sub ume_horaFin_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles ume_horaFin.Leave
        If ume_horaFin.Text.Trim.Length = 5 And ume_Horainicio.Text.Trim.Length = 5 Then
            Restar_Horas()
        Else
            utxt_TotalHoras.Value = Nothing
        End If
    End Sub

    Sub Restar_Horas()
        Dim final As String = ume_horaFin.Text
        Dim inicial As String = ume_Horainicio.Text
        Dim tiempoI As TimeSpan = TimeSpan.Parse(inicial)
        Dim tiempoF As TimeSpan = TimeSpan.Parse(final)
        Dim resta As TimeSpan = tiempoF - tiempoI
        utxt_TotalHoras.Text = resta.ToString.Substring(0, 5)
        '  utxt_TotalHoras.Text = utxt_TotalHoras.Text.Substring(0, 5)
    End Sub

    Private Sub ume_Horainicio_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles ume_Horainicio.Leave
        If ume_horaFin.Text.Trim.Length = 5 And ume_Horainicio.Text.Trim.Length = 5 Then
            Restar_Horas()
        Else
            utxt_TotalHoras.Value = Nothing
        End If
    End Sub
End Class