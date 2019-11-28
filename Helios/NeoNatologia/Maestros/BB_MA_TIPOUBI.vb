Public Class BB_MA_TIPOUBI
    Private obe As BE.NeoBE.SA_TB_BB_TIPO_UBI
    Private obr As BL.NeoBL.SA_TB_BB_TIPO_UBI
    Private lNew As Boolean = False
    Public Sub New()
        InitializeComponent()
        obe = New BE.NeoBE.SA_TB_BB_TIPO_UBI
        obr = New BL.NeoBL.SA_TB_BB_TIPO_UBI
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
        If txt_des.BackColor = Color.LightPink Then GoTo Err_Valida
        Return True
        Exit Function
Err_Valida:
        MessageBox.Show("Corrija ó Complete los campos errados !!", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Return False
    End Function
    Private Sub Inicializa()
        Call Limpiar_Controls_InGroupox(ugb_Datos)
        txt_des.BackColor = Color.White
    End Sub
    Private Sub BB_MA_TIPOUBI_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call Inicializar_Estado_Botones_Tool(ToolS_Mantenimiento)
        Call MostrarTabs(0, utc_Tipo, 0)

        obe = New BE.NeoBE.SA_TB_BB_TIPO_UBI
        obr = New BL.NeoBL.SA_TB_BB_TIPO_UBI
        Me.KeyPreview = True

        Call Formatear_Grilla_Selector(ug_Datos)
        ug_Datos.DataSource = obr.SEL01()

        Inicializa()
    End Sub

    Private Sub Tool_Nuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_Nuevo.Click
        Call Cambiar_Estado_Botones_Tool(ToolS_Mantenimiento)
        Call MostrarTabs(1, utc_Tipo, 1)
        Inicializa()
        lNew = True
        txt_des.Focus()
    End Sub

    Private Sub Tool_Cancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_Cancelar.Click
        Call Cambiar_Estado_Botones_Tool(ToolS_Mantenimiento)
        Call MostrarTabs(0, utc_Tipo, 0)
    End Sub

    Private Sub Tool_Grabar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_Grabar.Click
        If fValida() = False Then Exit Sub

        With obe
            .TI_ID = Val(txt_cod.Text)
            .TI_DESCRIPCION = txt_des.Text
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
        ug_Datos.DataSource = obr.SEL01()

        Call Cambiar_Estado_Botones_Tool(ToolS_Mantenimiento)
        Call Tool_Nuevo_Click(sender, e)
    End Sub

    Private Sub Tool_Editar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_Editar.Click
        If ug_Datos.Rows.Count <= 0 Then Exit Sub
        lNew = False

        Call Cambiar_Estado_Botones_Tool(ToolS_Mantenimiento)

        txt_cod.Text = ug_Datos.ActiveRow.Cells(0).Value
        txt_des.Text = ug_Datos.ActiveRow.Cells(1).Value

        Call MostrarTabs(1, utc_Tipo, 1)
        txt_des.Focus()

    End Sub

    Private Sub Tool_Eliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_Eliminar.Click
        If ug_Datos.Rows.Count <= 0 Then Exit Sub
        If Preguntar("Seguro de Eliminar?") Then
            obe.TI_ID = ug_Datos.ActiveRow.Cells(0).Value
            If obr.Delete(obe, String.Format("{0}-{1}", Environment.UserName, gStr_Usuario_Sis), Environment.MachineName) < 0 Then
                MessageBox.Show("La operación solicitada no ha podido ser realizada", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                Call Avisar("Listo!")
                ug_Datos.DataSource = obr.SEL01()
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
End Class