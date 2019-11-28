Public Class AD_MA_MedicosXUsu
    Private obe As BE.AdmisionBE.SG_AD_TB_UsuXMedico
    Private obr As BL.AdmisionBL.SG_AD_TB_UsuXMedico
    Private lNew As Boolean = False

    Public Sub New()
        InitializeComponent()
        obe = New BE.AdmisionBE.SG_AD_TB_UsuXMedico
        obr = New BL.AdmisionBL.SG_AD_TB_UsuXMedico
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
        If lNew Then
            pLostfocus(ucb_Usuario, Nothing)
        Else
            pLostfocus(txt_NombreUSu, Nothing)
        End If



        If ucb_Usuario.BackColor = Color.LightPink Then GoTo Err_Valida
        If txt_NombreUSu.BackColor = Color.LightPink Then GoTo Err_Valida
        Return True
        Exit Function
Err_Valida:
        MessageBox.Show("Corrija ó Complete los campos errados !!", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Return False
    End Function
    Private Sub Inicializa()
        Call Limpiar_Controls_InGroupox(ugb_datos)
        txt_NombreUSu.BackColor = Color.White
        ucb_Usuario.BackColor = Color.White

        ucb_Usuario.Visible = True
        txt_NombreUSu.Visible = False
    End Sub

    Private Sub pLoad() Handles MyBase.Load
        Call Inicializar_Estado_Botones_Tool(ToolS_Mantenimiento)
        Call MostrarTabs(0, utc_Datos, 0)

        obe = New BE.AdmisionBE.SG_AD_TB_UsuXMedico
        obr = New BL.AdmisionBL.SG_AD_TB_UsuXMedico

        Dim obj1 As New DataTable
        obr.SEL03(obe, obj1)
        ucb_Usuario.DataSource = obj1
        ucb_Usuario.DisplayMember = "US_NOMBRE"
        ucb_Usuario.ValueMember = "US_ID"

        Me.KeyPreview = True

        Call Formatear_Grilla_Selector(ug_Lista)

        Dim obj As New DataTable
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
        obe.UM_IDUSUARIO = 0
        obr.SEL02(obe, 0, obj)
        ug_intervalos.DataSource = obj


        Dim obj1 As New DataTable
        obr.SEL03(obe, obj1)
        ucb_Usuario.DataSource = obj1
        ucb_Usuario.DisplayMember = "US_NOMBRE"
        ucb_Usuario.ValueMember = "US_ID"


        lNew = True
        txt_NombreUSu.Focus()

    End Sub

    Private Sub Tool_Cancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_Cancelar.Click
        Call Cambiar_Estado_Botones_Tool(ToolS_Mantenimiento)
        Call MostrarTabs(0, utc_Datos, 0)
    End Sub

    Private Sub Tool_Grabar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_Grabar.Click
        If fValida() = False Then Exit Sub

        If lNew Then
            obe.UM_IDUSUARIO = ucb_Usuario.Value
        Else
            obe.UM_IDUSUARIO = txt_idUsu.Text
            obr.Delete(obe, String.Format("{0}-{1}", Environment.UserName, gStr_Usuario_Sis), Environment.MachineName)
        End If
        ug_intervalos.UpdateData()

        For f As Integer = 0 To ug_intervalos.Rows.Count - 1

            If ug_intervalos.Rows(f).Cells("Sel").Value Then
                obe.UM_IDMEDICO = ug_intervalos.Rows(f).Cells(1).Value
                obe.UM_IDEMPRESA = ug_intervalos.Rows(f).Cells(3).Value

                obr.Insert(obe, String.Format("{0}-{1}", Environment.UserName, gStr_Usuario_Sis), Environment.MachineName)
            End If
        Next


        Call Avisar("Listo!")

        Dim obj As New DataTable
        obr.SEL01(obe, obj)
        ug_Lista.DataSource = obj

        Call Cambiar_Estado_Botones_Tool(ToolS_Mantenimiento)
        Call Tool_Nuevo_Click(sender, e)

    End Sub

    Private Sub Tool_Editar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_Editar.Click
        If ug_Lista.Rows.Count <= 0 Then Exit Sub
        '  If ug_Lista.ActiveRow.Cells(0).Value = "" Then Exit Sub
        lNew = False

        Call Cambiar_Estado_Botones_Tool(ToolS_Mantenimiento)

        txt_idUsu.Text = ug_Lista.ActiveRow.Cells(0).Value
        txt_NombreUSu.Value = ug_Lista.ActiveRow.Cells(1).Value


        Dim obj As New DataTable
        obe.UM_IDUSUARIO = ug_Lista.ActiveRow.Cells(0).Value
        obr.SEL02(obe, 1, obj)
        ug_intervalos.DataSource = obj


        ucb_Usuario.Visible = False
        txt_NombreUSu.Visible = True

        Call MostrarTabs(1, utc_Datos, 1)
        txt_NombreUSu.Focus()

    End Sub

    Private Sub Tool_Eliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_Eliminar.Click
        If ug_Lista.Rows.Count <= 0 Then Exit Sub
        If ug_Lista.ActiveRow.Cells(0).Value.ToString = "" Then Exit Sub
        If Preguntar("Seguro de Eliminar?") Then
            obe.UM_IDUSUARIO = ug_Lista.ActiveRow.Cells(0).Value
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

End Class