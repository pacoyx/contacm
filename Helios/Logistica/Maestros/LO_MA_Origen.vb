Public Class LO_MA_Origen
    Private obe As BE.LogisticaBE.SG_LO_TB_ORIGEN
    Private obr As BL.LogisticaBL.SG_LO_TB_ORIGEN
    Private lNew As Boolean = False

    Public Sub New()
        InitializeComponent()
        obe = New BE.LogisticaBE.SG_LO_TB_ORIGEN
        obr = New BL.LogisticaBL.SG_LO_TB_ORIGEN
    End Sub

    Private Sub pKeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Me.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Return) Then
            SendKeys.Send("{TAB}")
            e.Handled = True
        End If
    End Sub

    'Private Sub pGotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_DesCorto.GotFocus, txt_Descripcion.GotFocus
    '    sender.BackColor = Color.White
    'End Sub
    Private Sub pLostfocus(ByVal sender As Object, ByVal e As System.EventArgs) ' Handles txt_DesCorto.LostFocus, txt_Descripcion.LostFocus
        sender.BackColor = Color.White
        If sender.Text.Trim.Length < 1 Then
            sender.BackColor = Color.LightPink
        End If
    End Sub
    Private Function fValida() As Boolean
        pLostfocus(txt_Descripcion, Nothing)
        pLostfocus(txt_id, Nothing)
        If txt_Descripcion.BackColor = Color.LightPink Then GoTo Err_Valida
        If txt_id.BackColor = Color.LightPink Then GoTo Err_Valida
        Return True
        Exit Function
Err_Valida:
        MessageBox.Show("Corrija ó Complete los campos errados !!", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Return False
    End Function
    Private Sub Inicializa()
        Call Limpiar_Controls_InGroupox(ugb_datos)
        txt_Descripcion.BackColor = Color.White
        txt_id.BackColor = Color.White
        txt_id.ReadOnly = False
    End Sub
    Private Sub pLoad() Handles MyBase.Load
        Call Inicializar_Estado_Botones_Tool(ToolS_Mantenimiento)
        Call MostrarTabs(0, utc_Datos, 0)

        obe = New BE.LogisticaBE.SG_LO_TB_ORIGEN
        obr = New BL.LogisticaBL.SG_LO_TB_ORIGEN

        Me.KeyPreview = True

        Call Formatear_Grilla_Selector(ug_Lista)

        obe.OR_IDEMPRESA = gInt_IdEmpresa
        ug_Lista.DataSource = obr.SEL01(obe)

        ug_Lista.DisplayLayout.Appearance.FontData.Name = "Calibri"

        Inicializa()
    End Sub

    Private Sub Tool_Nuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_Nuevo.Click
        Call Cambiar_Estado_Botones_Tool(ToolS_Mantenimiento)
        Call MostrarTabs(1, utc_Datos, 1)
        Inicializa()

        lNew = True
        txt_id.Focus()

    End Sub

    Private Sub Tool_Cancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_Cancelar.Click
        Call Cambiar_Estado_Botones_Tool(ToolS_Mantenimiento)
        Call MostrarTabs(0, utc_Datos, 0)
    End Sub

    Private Sub Tool_Grabar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_Grabar.Click
        If fValida() = False Then Exit Sub

        With obe
            .OR_ID = txt_id.Text
            .OR_NOMBRE = txt_Descripcion.Text
            .OR_IDEMPRESA = gInt_IdEmpresa
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

        obe.OR_IDEMPRESA = gInt_IdEmpresa
        ug_Lista.DataSource = obr.SEL01(obe)

        Call Cambiar_Estado_Botones_Tool(ToolS_Mantenimiento)
        Call Tool_Nuevo_Click(sender, e)
        Call MostrarTabs(0, utc_Datos, 0)

    End Sub

    Private Sub Tool_Editar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_Editar.Click
        If ug_Lista.Rows.Count <= 0 Then Exit Sub
        lNew = False

        Call Cambiar_Estado_Botones_Tool(ToolS_Mantenimiento)

        txt_id.Text = ug_Lista.ActiveRow.Cells(0).Value
        txt_Descripcion.Value = ug_Lista.ActiveRow.Cells(1).Value
        txt_id.ReadOnly = True
        Call MostrarTabs(1, utc_Datos, 1)
        txt_Descripcion.Focus()

    End Sub

    Private Sub Tool_Eliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_Eliminar.Click
        If ug_Lista.Rows.Count <= 0 Then Exit Sub
        If Preguntar("Seguro de Eliminar?") Then
            obe.OR_ID = ug_Lista.ActiveRow.Cells(0).Value
            obe.OR_IDEMPRESA = gInt_IdEmpresa
            If obr.Delete(obe, String.Format("{0}-{1}", Environment.UserName, gStr_Usuario_Sis), Environment.MachineName) < 0 Then
                MessageBox.Show("La operación solicitada no ha podido ser realizada", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                Call Avisar("Listo!")

                obe.OR_IDEMPRESA = gInt_IdEmpresa
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
End Class