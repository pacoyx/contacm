Public Class AD_MA_Medico

    Private obe As BE.AdmisionBE.SG_AD_TB_MEDICO
    Private obr As BL.AdmisionBL.SG_AD_TB_MEDICO
    Private lNew As Boolean = False

    Public Sub New()
        InitializeComponent()
        obe = New BE.AdmisionBE.SG_AD_TB_MEDICO
        obr = New BL.AdmisionBL.SG_AD_TB_MEDICO
    End Sub
    Private Sub pKeyPressNumero(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_RUC.KeyPress, txt_Intervalo.KeyPress
        e.KeyChar = fKeyPress(e.KeyChar, sender.Text, 1)
        e.Handled = (e.KeyChar = "")
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
        pLostfocus(txt_ApellidoP, Nothing)
        pLostfocus(txt_ApellidoM, Nothing)
        pLostfocus(txt_Nombres, Nothing)
        pLostfocus(txt_ColegioM, Nothing)
        'pLostfocus(txt_Intervalo, Nothing)
        'pLostfocus(txt_num_doc, Nothing)
        uce_Especialidades.BackColor = Color.White
        udte_fecha.BackColor = Color.White
        uce_tip_doc.BackColor = Color.White
        'If udte_fecha.Value = Nothing Then udte_fecha.BackColor = Color.LightPink
        If uce_Especialidades.SelectedIndex = -1 Then uce_Especialidades.BackColor = Color.LightPink
        If uce_tip_doc.SelectedIndex = -1 Then uce_tip_doc.BackColor = Color.LightPink

        'If txt_num_doc.Text.Trim.Length <> 8 And (uce_tip_doc.Value = 1 Or uce_tip_doc.Value = 5) Then
        ' txt_num_doc.BackColor = Color.LightPink
        ' End If

        If uce_tip_doc.BackColor = Color.LightPink Then GoTo Err_Valida
        'If txt_num_doc.BackColor = Color.LightPink Then GoTo Err_Valida
        If uce_Especialidades.BackColor = Color.LightPink Then GoTo Err_Valida
        If txt_ApellidoP.BackColor = Color.LightPink Then GoTo Err_Valida
        If txt_ApellidoM.BackColor = Color.LightPink Then GoTo Err_Valida
        If txt_Nombres.BackColor = Color.LightPink Then GoTo Err_Valida
        If txt_ColegioM.BackColor = Color.LightPink Then GoTo Err_Valida
        'If txt_Intervalo.BackColor = Color.LightPink Then GoTo Err_Valida
        'If udte_fecha.BackColor = Color.LightPink Then GoTo Err_Valida
        Return True
        Exit Function
Err_Valida:
        MessageBox.Show("Corrija ó Complete los campos errados !!", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Return False
    End Function

    Private Sub Inicializa()
        Call Limpiar_Controls_InGroupox(ugb_datos)
        txt_ApellidoP.BackColor = Color.White
        txt_ApellidoM.BackColor = Color.White
        txt_Nombres.BackColor = Color.White
        uce_Especialidades.BackColor = Color.White
        txt_ColegioM.BackColor = Color.White
        txt_Intervalo.BackColor = Color.White
        udte_fecha.BackColor = Color.White
        uce_tip_doc.BackColor = Color.White
        txt_num_doc.BackColor = Color.White
        udte_fecha.Value = gDat_Fecha_Sis
        urb_Estado.CheckedIndex = 0
    End Sub

    Private Sub pLoad() Handles MyBase.Load
        Call Inicializar_Estado_Botones_Tool(ToolS_Mantenimiento)
        Call MostrarTabs(0, utc_Datos, 0)

        Dim EspecialidadBL As New BL.AdmisionBL.SG_AD_TB_ESPECIALIDADES
        Dim EspecialidadBE As New BE.AdmisionBE.SG_AD_TB_ESPECIALIDADES
        Dim OBJE As New DataTable
        EspecialidadBE.ES_IDEMPRESA = gInt_IdEmpresa
        EspecialidadBL.SEL01(EspecialidadBE, OBJE)
        uce_Especialidades.DataSource = OBJE
        uce_Especialidades.ValueMember = "ES_ID"
        uce_Especialidades.DisplayMember = "ES_DESCRIPCION"
        EspecialidadBL = Nothing


        Dim documentosBL As New BL.AdmisionBL.SG_AD_TB_TIP_DOC_PER
        uce_tip_doc.DataSource = documentosBL.getTiposDocs(gInt_IdEmpresa)
        uce_tip_doc.DisplayMember = "TD_ABREVIATURA"
        uce_tip_doc.ValueMember = "TD_ID"
        documentosBL = Nothing

        obe = New BE.AdmisionBE.SG_AD_TB_MEDICO
        obr = New BL.AdmisionBL.SG_AD_TB_MEDICO

        Me.KeyPreview = True

        Call Formatear_Grilla_Selector(ug_Lista)
        obe.ME_IDEMPRESA = gInt_IdEmpresa

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
        lNew = True
        txt_ApellidoP.Focus()

    End Sub

    Private Sub Tool_Cancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_Cancelar.Click
        Call Cambiar_Estado_Botones_Tool(ToolS_Mantenimiento)
        Call MostrarTabs(0, utc_Datos, 0)
    End Sub

    Private Sub Tool_Grabar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_Grabar.Click
        If fValida() = False Then Exit Sub

        With obe
            .ME_APE_PAT = txt_ApellidoP.Text
            .ME_APE_MAT = txt_ApellidoM.Text
            .ME_NOMBRES = txt_Nombres.Text
            .ME_CORREO = txt_Correo.Text
            .ME_DIRECCION = txt_Direccion.Text
            .ME_ESPECIALIDAD = uce_Especialidades.Value
            .ME_ESTADO = urb_Estado.Value
            .ME_FECNAC = IIf(udte_fecha.Value = Nothing, Now.Date, udte_fecha.Value)
            .ME_INTERVALO = txt_Intervalo.Value
            .ME_IDEMPRESA = gInt_IdEmpresa
            .ME_NUM_COLEG = txt_ColegioM.Text
            .ME_PC = Environment.MachineName
            .ME_RUC = txt_RUC.Text
            .ME_TELEFONOCELULAR = txt_Celular.Text
            .ME_TELEFONOFIJO = txt_Fijo.Text
            .ME_USUARIO = String.Format("{0}-{1}", Environment.UserName, gStr_Usuario_Sis)
            .ME_TDOC = uce_tip_doc.Value
            .ME_NDOC = txt_num_doc.Text
        End With

        If lNew Then
            Dim I As Integer
            I = obr.Insert(obe, String.Format("{0}-{1}", Environment.UserName, gStr_Usuario_Sis), Environment.MachineName)
            txt_id.Text = I
            If I < 0 Then
                MessageBox.Show("La operación solicitada no ha podido ser realizada, Posiblemente el registro ya exista", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If
        Else
            obe.ME_CODIGO = txt_id.Text
            If obr.Update(obe, String.Format("{0}-{1}", Environment.UserName, gStr_Usuario_Sis), Environment.MachineName) < 0 Then
                MessageBox.Show("La operación solicitada no ha podido ser realizada, Posiblemente el registro ya exista", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If
        End If
        Call Avisar("Listo!")

        Dim obj As New DataTable
        obr.SEL01(obe, obj)
        ug_Lista.DataSource = obj

        Call Cambiar_Estado_Botones_Tool(ToolS_Mantenimiento)
        Call Tool_Nuevo_Click(sender, e)

    End Sub

    Private Sub Tool_Editar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_Editar.Click

        lNew = False

        Call Cambiar_Estado_Botones_Tool(ToolS_Mantenimiento)
        txt_id.Text = ug_Lista.ActiveRow.Cells(0).Value
        txt_ApellidoP.Value = ug_Lista.ActiveRow.Cells(1).Value
        txt_ApellidoM.Value = ug_Lista.ActiveRow.Cells(2).Value
        txt_Nombres.Value = ug_Lista.ActiveRow.Cells(3).Value
        txt_ColegioM.Value = ug_Lista.ActiveRow.Cells(4).Value
        uce_Especialidades.Value = ug_Lista.ActiveRow.Cells(5).Value

        txt_RUC.Value = ug_Lista.ActiveRow.Cells(7).Value
        txt_Direccion.Value = ug_Lista.ActiveRow.Cells(8).Value
        txt_Fijo.Value = ug_Lista.ActiveRow.Cells(9).Value
        txt_Celular.Value = ug_Lista.ActiveRow.Cells(10).Value
        txt_Intervalo.Value = ug_Lista.ActiveRow.Cells(11).Value
        udte_fecha.Value = ug_Lista.ActiveRow.Cells(12).Value
        txt_Correo.Value = ug_Lista.ActiveRow.Cells(13).Value
        uce_tip_doc.Value = ug_Lista.ActiveRow.Cells(14).Value
        txt_num_doc.Value = ug_Lista.ActiveRow.Cells(15).Value
        If ug_Lista.ActiveRow.Cells(16).Value = "ACTIVO" Then urb_Estado.CheckedIndex = 0 Else urb_Estado.CheckedIndex = 1

        Call MostrarTabs(1, utc_Datos, 1)
        txt_ApellidoP.Focus()

    End Sub

    Private Sub Tool_Eliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_Eliminar.Click
        If Preguntar("Seguro de Eliminar?") Then
            obe.ME_CODIGO = ug_Lista.ActiveRow.Cells(0).Value
            obe.ME_IDEMPRESA = gInt_IdEmpresa

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

    Private Sub pLoad(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class