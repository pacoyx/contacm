Public Class LO_MA_Forma_Farmaceutica
    Private obe As BE.LogisticaBE.SG_LO_TB_FORMA_FARMACEUTICA
    Private obr As BL.LogisticaBL.SG_LO_TB_FORMA_FARMACEUTICA
    Private lNew As Boolean = False
    Public Sub New()
        InitializeComponent()
        obe = New BE.LogisticaBE.SG_LO_TB_FORMA_FARMACEUTICA
        obr = New BL.LogisticaBL.SG_LO_TB_FORMA_FARMACEUTICA
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
        pLostfocus(txt_Nombre, Nothing)
        If txt_Nombre.BackColor = Color.LightPink Then GoTo Err_Valida
        Return True
        Exit Function
Err_Valida:
        MessageBox.Show("Corrija ó Complete los campos errados !!", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Return False
    End Function
    Private Sub Inicializa()
        Call Limpiar_Controls_InGroupox(ugb_datos)
        txt_Nombre.BackColor = Color.White
    End Sub

    Private Sub LO_MA_Forma_Farmaceutica_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Call Inicializar_Estado_Botones_Tool(ToolS_Mantenimiento)
        Call MostrarTabs(0, utc_Numeracion, 0)

        obe = New BE.LogisticaBE.SG_LO_TB_FORMA_FARMACEUTICA
        obr = New BL.LogisticaBL.SG_LO_TB_FORMA_FARMACEUTICA
        Me.KeyPreview = True

        Call Formatear_Grilla_Selector(ug_Lista_Num)
        ug_Lista_Num.DataSource = obr.SEL01(gInt_IdEmpresa)

        Inicializa()
    End Sub

    Private Sub Tool_Nuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_Nuevo.Click
        Call Cambiar_Estado_Botones_Tool(ToolS_Mantenimiento)
        Call MostrarTabs(1, utc_Numeracion, 1)
        Inicializa()
        lNew = True
        txt_Nombre.Focus()
    End Sub

    Private Sub Tool_Cancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_Cancelar.Click
        Call Cambiar_Estado_Botones_Tool(ToolS_Mantenimiento)
        Call MostrarTabs(0, utc_Numeracion, 0)
    End Sub

    Private Sub Tool_Grabar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_Grabar.Click
        If fValida() = False Then Exit Sub

        With obe
            .FF_ID = txt_id.Text
            .FF_NOMBRE = txt_Nombre.Text
            .FF_IDEMPRESA = gInt_IdEmpresa
        End With

        If lNew Then
            Dim i As Integer
            i = obr.Insert(obe, String.Format("{0}-{1}", Environment.UserName, gStr_Usuario_Sis), Environment.MachineName)
            txt_id.Text = i
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
        ug_Lista_Num.DataSource = obr.SEL01(gInt_IdEmpresa)

        Call Cambiar_Estado_Botones_Tool(ToolS_Mantenimiento)
        Call Tool_Nuevo_Click(sender, e)
    End Sub

    Private Sub Tool_Editar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_Editar.Click
        If ug_Lista_Num.Rows.Count <= 0 Then Exit Sub
        lNew = False

        Call Cambiar_Estado_Botones_Tool(ToolS_Mantenimiento)

        txt_id.Text = ug_Lista_Num.ActiveRow.Cells(0).Value
        txt_Nombre.Text = ug_Lista_Num.ActiveRow.Cells(1).Value
        
        Call MostrarTabs(1, utc_Numeracion, 1)
        txt_Nombre.Focus()

    End Sub

    Private Sub Tool_Eliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_Eliminar.Click
        If ug_Lista_Num.Rows.Count <= 0 Then Exit Sub
        If Preguntar("Seguro de Eliminar?") Then
            obe.FF_ID = ug_Lista_Num.ActiveRow.Cells(0).Value
            obe.FF_IDEMPRESA = gInt_IdEmpresa
            If obr.Delete(obe, String.Format("{0}-{1}", Environment.UserName, gStr_Usuario_Sis), Environment.MachineName) < 0 Then
                MessageBox.Show("La operación solicitada no ha podido ser realizada", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                Call Avisar("Listo!")

                ug_Lista_Num.DataSource = obr.SEL01(gInt_IdEmpresa)
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

    Private Sub ug_Lista_Num_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ug_Lista_Num.DoubleClick
        Tool_Editar_Click(sender, e)
    End Sub

End Class