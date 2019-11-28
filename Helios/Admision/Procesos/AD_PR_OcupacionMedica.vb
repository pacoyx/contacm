Public Class AD_PR_OcupacionMedica
    Private obe As BE.AdmisionBE.SG_AD_TB_OCUPACIONES_MEDICAS
    Private obr As BL.AdmisionBL.SG_AD_TB_OCUPACIONES_MEDICAS
    Public lNew As Boolean = False
    Public Sub New()
        InitializeComponent()
        obe = New BE.AdmisionBE.SG_AD_TB_OCUPACIONES_MEDICAS
        obr = New BL.AdmisionBL.SG_AD_TB_OCUPACIONES_MEDICAS
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
        pLostfocus(txt_Descripcion, Nothing)

        If txt_Descripcion.BackColor = Color.LightPink Then GoTo Err_Valida

        Return True
        Exit Function
Err_Valida:
        MessageBox.Show("Corrija ó Complete los campos errados !!", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Return False
    End Function

    Private Sub AD_PR_OcupacionMedica_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txt_Descripcion.BackColor = Color.White

        obe = New BE.AdmisionBE.SG_AD_TB_OCUPACIONES_MEDICAS
        obr = New BL.AdmisionBL.SG_AD_TB_OCUPACIONES_MEDICAS

        Me.KeyPreview = True
    End Sub

    Private Sub Tool_Salir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_Salir.Click
        Me.Close()
    End Sub

    Private Sub Tool_Grabar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_Grabar.Click
        If fValida() = False Then Exit Sub

        With obe
            .OM_IDPROGRAMACION = txt_idprogramacion.Value
            .OM_FECHA = udte_fecha.Value
            .OM_HORA_PROG = txt_Hora.Value
            .OM_NUM_ORDEN = txt_Orden.Value
            .OM_DESCRIPCION = txt_Descripcion.Text
            .OM_IDEMPRESA = gInt_IdEmpresa
        End With

        If lNew Then
            Dim I As Integer
            I = obr.Insert(obe, String.Format("{0}-{1}", Environment.UserName, gStr_Usuario_Sis), Environment.MachineName)
            txt_idOcupacion.Text = I
            If I < 0 Then
                MessageBox.Show("La operación solicitada no ha podido ser realizada", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If
        Else
            obe.OM_ID = Val(txt_idOcupacion.Text)
            If obr.Update(obe, String.Format("{0}-{1}", Environment.UserName, gStr_Usuario_Sis), Environment.MachineName) < 0 Then
                MessageBox.Show("La operación solicitada no ha podido ser realizada", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If
        End If
        Call Avisar("Listo!")
        'AD_PR_AgendaCitas.Cargar_Agenda(udte_fecha.Value, Servicio, Medico)
        Me.Close()

    End Sub

    Private Sub Tool_Eliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_Eliminar.Click
        If txt_idOcupacion.Text = "" Then Exit Sub
        If Preguntar("Seguro de Eliminar?") Then
            obe.OM_ID = Val(txt_idOcupacion.Value)

            If obr.Delete(obe, String.Format("{0}-{1}", Environment.UserName, gStr_Usuario_Sis), Environment.MachineName) < 0 Then
                MessageBox.Show("La operación solicitada no ha podido ser realizada", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                Call Avisar("Listo!")
                'AD_PR_AgendaCitas.Cargar_Agenda(udte_fecha.Value, Servicio, Medico)
                Me.Close()
            End If

        End If
    End Sub
End Class