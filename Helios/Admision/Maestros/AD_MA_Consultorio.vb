Public Class AD_MA_Consultorio
    Private obe As BE.AdmisionBE.SG_AD_TB_CONSULTORIO_MEDICO
    Private obr As BL.AdmisionBL.SG_AD_TB_CONSULTORIO_MEDICO
    Private lNew As Boolean = False

    Public Sub New()
        InitializeComponent()
        obe = New BE.AdmisionBE.SG_AD_TB_CONSULTORIO_MEDICO
        obr = New BL.AdmisionBL.SG_AD_TB_CONSULTORIO_MEDICO
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
        pLostfocus(txt_DesCorto, Nothing)
        pLostfocus(txt_Descripcion, Nothing)

        If txt_DesCorto.BackColor = Color.LightPink Then GoTo Err_Valida
        If txt_Descripcion.BackColor = Color.LightPink Then GoTo Err_Valida
        Return True
        Exit Function
Err_Valida:
        MessageBox.Show("Corrija ó Complete los campos errados !!", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Return False
    End Function

    Private Sub Inicializa()
        Call Limpiar_Controls_InGroupox(ugb_datos)
        txt_DesCorto.BackColor = Color.White
        txt_Descripcion.BackColor = Color.White
    End Sub

    Private Sub pLoad() Handles MyBase.Load
        Call Inicializar_Estado_Botones_Tool(ToolS_Mantenimiento)
        Call MostrarTabs(0, utc_Consultorios, 0)
        obe = New BE.AdmisionBE.SG_AD_TB_CONSULTORIO_MEDICO
        obr = New BL.AdmisionBL.SG_AD_TB_CONSULTORIO_MEDICO

        Me.KeyPreview = True

        Call Formatear_Grilla_Selector(ug_Consultorio)
        ug_Consultorio.DataSource = obr.get_Consultorios(gInt_IdEmpresa)
        ug_Consultorio.DisplayLayout.Appearance.FontData.Name = "Calibri"

        Inicializa()
    End Sub

    Private Sub Tool_Nuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_Nuevo.Click
        Call Cambiar_Estado_Botones_Tool(ToolS_Mantenimiento)
        Call MostrarTabs(1, utc_Consultorios, 1)
        Inicializa()
        lNew = True
        txt_DesCorto.Focus()

    End Sub

    Private Sub Tool_Cancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_Cancelar.Click
        Call Cambiar_Estado_Botones_Tool(ToolS_Mantenimiento)
        Call MostrarTabs(0, utc_Consultorios, 0)
    End Sub

    Private Sub Tool_Grabar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_Grabar.Click
        If fValida() = False Then Exit Sub

        With obe
            .CM_DES_CORTA = txt_DesCorto.Text
            .CM_DESCRIPCION = txt_Descripcion.Text
            .CM_USUARIO = String.Format("{0}-{1}", Environment.UserName, gStr_Usuario_Sis)
            .CM_PC = Environment.MachineName
            .CM_IDEMPRESA = gInt_IdEmpresa
        End With

        If lNew Then
            Dim I As Integer
            I = obr.Insert(obe, String.Format("{0}-{1}", Environment.UserName, gStr_Usuario_Sis), Environment.MachineName)
            txt_id.Text = I
            If I < 0 Then
                MessageBox.Show("La operación solicitada no ha podido ser realizada", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If
        Else
            obe.CM_ID = txt_id.Text
            If obr.Update(obe, String.Format("{0}-{1}", Environment.UserName, gStr_Usuario_Sis), Environment.MachineName) < 0 Then
                MessageBox.Show("La operación solicitada no ha podido ser realizada", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If
        End If
        Call Avisar("Listo!")
        ug_Consultorio.DataSource = obr.get_Consultorios(gInt_IdEmpresa)

        Call Cambiar_Estado_Botones_Tool(ToolS_Mantenimiento)
        Call Tool_Nuevo_Click(sender, e)

    End Sub

    Private Sub Tool_Editar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_Editar.Click

        lNew = False

        Call Cambiar_Estado_Botones_Tool(ToolS_Mantenimiento)

        txt_id.Text = ug_Consultorio.ActiveRow.Cells(0).Value
        txt_DesCorto.Value = ug_Consultorio.ActiveRow.Cells(1).Value
        txt_Descripcion.Value = ug_Consultorio.ActiveRow.Cells(2).Value

        Call MostrarTabs(1, utc_Consultorios, 1)
        txt_DesCorto.Focus()

    End Sub

    Private Sub Tool_Eliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_Eliminar.Click
        If Preguntar("Seguro de Eliminar?") Then
            obe.CM_ID = ug_Consultorio.ActiveRow.Cells(0).Value
            obe.CM_IDEMPRESA = gInt_IdEmpresa
            If obr.Delete(obe, String.Format("{0}-{1}", Environment.UserName, gStr_Usuario_Sis), Environment.MachineName) < 0 Then
                MessageBox.Show("La operación solicitada no ha podido ser realizada", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                Call Avisar("Listo!")
                ug_Consultorio.DataSource = obr.get_Consultorios(gInt_IdEmpresa)
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

    Private Sub ug_Consultorio_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ug_Consultorio.DoubleClick
        Tool_Editar_Click(sender, e)
    End Sub
End Class