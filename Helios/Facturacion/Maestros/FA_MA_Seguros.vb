Public Class FA_MA_Seguros
    Private obe As BE.FacturacionBE.SG_FA_TB_CIA_ASEG
    Private obr As BL.FacturacionBL.SG_FA_TB_CIA_ASEG
    Private lNew As Boolean = False

    Public Sub New()
        InitializeComponent()
        obe = New BE.FacturacionBE.SG_FA_TB_CIA_ASEG
        obr = New BL.FacturacionBL.SG_FA_TB_CIA_ASEG
    End Sub

    Private Sub pKeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Me.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Return) Then
            SendKeys.Send("{TAB}")
            e.Handled = True
        End If
    End Sub
    Private Sub pKeyPressNumeroDec(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_factorH.KeyPress, txt_FactorS.KeyPress
        e.KeyChar = fKeyPress(e.KeyChar, sender.Text, 2)
        e.Handled = (e.KeyChar = "")
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
        pLostfocus(txt_num_doc, Nothing)
        pLostfocus(txt_idSeguroSited, Nothing)
        uce_TipoDoc.BackColor = Color.White
        If uce_TipoDoc.SelectedIndex = -1 Then uce_TipoDoc.BackColor = Color.LightPink
        ucbo_TipoSeguro.BackColor = Color.White
        If ucbo_TipoSeguro.SelectedIndex = -1 Then ucbo_TipoSeguro.BackColor = Color.LightPink

        If ucbo_TipoSeguro.BackColor = Color.LightPink Then GoTo Err_Valida
        If uce_TipoDoc.BackColor = Color.LightPink Then GoTo Err_Valida
        If txt_Descripcion.BackColor = Color.LightPink Then GoTo Err_Valida
        If txt_num_doc.BackColor = Color.LightPink Then GoTo Err_Valida
        If txt_idSeguroSited.BackColor = Color.LightPink Then GoTo Err_Valida
        Return True
        Exit Function
Err_Valida:
        MessageBox.Show("Corrija ó Complete los campos errados !!", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Return False
    End Function

    Private Sub Inicializa()
        Call Limpiar_Controls_InGroupox(ugb_datos)
        txt_Descripcion.BackColor = Color.White
    End Sub

    Private Sub pLoad() Handles MyBase.Load
        Call Inicializar_Estado_Botones_Tool(ToolS_Mantenimiento)
        Call MostrarTabs(0, utc_Datos, 0)

        Call Cargar_Combos()

        obe = New BE.FacturacionBE.SG_FA_TB_CIA_ASEG
        obr = New BL.FacturacionBL.SG_FA_TB_CIA_ASEG

        Me.KeyPreview = True

        Call Formatear_Grilla_Selector(ug_Lista)

        Dim obj As New DataTable
        obe.CA_IDEMPRESA = gInt_IdEmpresa
        obr.SEL01(obe, obj)
        ug_Lista.DataSource = obj
        ug_Lista.DisplayLayout.Appearance.FontData.Name = "Calibri"

        Inicializa()
    End Sub

    Private Sub Cargar_Combos()

         Dim obj_docPBL As New BL.ContabilidadBL.SG_CO_TB_TIPO_DOC_IDENTIDAD
        uce_TipoDoc.DataSource = obj_docPBL.getTipoDos
        uce_TipoDoc.DisplayMember = "DI_DESCRIPCION"
        uce_TipoDoc.ValueMember = "DI_CODIGO"
        obj_docPBL = Nothing

        Dim TipoCia As New BL.FacturacionBL.SG_FA_TB_TIPO_CIA_ASEG
        Dim obeTipoCia As New BE.FacturacionBE.SG_FA_TB_TIPO_CIA_ASEG
        obeTipoCia.TA_IDEMPRESA = gInt_IdEmpresa
        Dim obj2 As New DataTable
        TipoCia.SEL01(obeTipoCia, obj2)
        ucbo_TipoSeguro.DataSource = obj2
        ucbo_TipoSeguro.DisplayMember = "TA_DESCRIPCION"
        ucbo_TipoSeguro.ValueMember = "TA_ID"
        TipoCia = Nothing

    End Sub


    Private Sub Tool_Nuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_Nuevo.Click
        Call Cambiar_Estado_Botones_Tool(ToolS_Mantenimiento)
        Call MostrarTabs(1, utc_Datos, 1)
        Inicializa()

        lNew = True
        ucbo_TipoSeguro.Focus()

    End Sub

    Private Sub Tool_Cancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_Cancelar.Click
        Call Cambiar_Estado_Botones_Tool(ToolS_Mantenimiento)
        Call MostrarTabs(0, utc_Datos, 0)
    End Sub

    Private Sub Tool_Grabar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_Grabar.Click
        If fValida() = False Then Exit Sub

        With obe
            .CA_DESCRIPCION = txt_Descripcion.Text
            .CA_DIRECCION = txt_Direccion.Text

            .CA_IDASEGU_SITED = txt_idSeguroSited.Text
            .CA_IDEMPRESA = gInt_IdEmpresa
            .CA_IDTIPO_CIA_ASEG = ucbo_TipoSeguro.Value
            .CA_IDTIPO_DOC = uce_TipoDoc.Value
            .CA_NUM_DOC = txt_num_doc.Text
            .CA_PAG_WEB = txt_PaginaWeb.Text
            .CA_REPRE = txt_Representante.Text
            .CA_TELEFONO = txt_Telefono.Text
            .CA_IDSUNASA = txt_idSunasa.Text
            .CA_FactorHonorario = Val(txt_factorH.Text)
            .CA_FactorServicio = Val(txt_FactorS.Text)
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
            obe.CA_ID = txt_id.Text
            If obr.Update(obe, String.Format("{0}-{1}", Environment.UserName, gStr_Usuario_Sis), Environment.MachineName) < 0 Then
                MessageBox.Show("La operación solicitada no ha podido ser realizada", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
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
        If ug_Lista.Rows.Count <= 0 Then Exit Sub
        lNew = False

        Call Cambiar_Estado_Botones_Tool(ToolS_Mantenimiento)

        txt_id.Text = ug_Lista.ActiveRow.Cells(0).Value
        ucbo_TipoSeguro.Value = ug_Lista.ActiveRow.Cells(1).Value
        txt_Descripcion.Text = ug_Lista.ActiveRow.Cells(2).Value
        txt_Direccion.Text = ug_Lista.ActiveRow.Cells(3).Value
        uce_TipoDoc.Value = ug_Lista.ActiveRow.Cells(4).Value
        txt_num_doc.Text = ug_Lista.ActiveRow.Cells(5).Value
        txt_Telefono.Text = ug_Lista.ActiveRow.Cells(6).Value
        txt_PaginaWeb.Text = ug_Lista.ActiveRow.Cells(7).Value
        txt_Representante.Text = ug_Lista.ActiveRow.Cells(8).Value
        txt_idSeguroSited.Text = ug_Lista.ActiveRow.Cells(10).Value
        txt_idSunasa.Text = ug_Lista.ActiveRow.Cells(11).Value
        txt_factorH.Text = ug_Lista.ActiveRow.Cells(12).Value
        txt_FactorS.Text = ug_Lista.ActiveRow.Cells(13).Value

        Call MostrarTabs(1, utc_Datos, 1)
        txt_Descripcion.Focus()

    End Sub

    Private Sub Tool_Eliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_Eliminar.Click
        If ug_Lista.Rows.Count <= 0 Then Exit Sub
        If Preguntar("Seguro de Eliminar?") Then
            obe.CA_ID = ug_Lista.ActiveRow.Cells(0).Value
            obe.CA_IDEMPRESA = gInt_IdEmpresa
            If obr.Delete(obe, String.Format("{0}-{1}", Environment.UserName, gStr_Usuario_Sis), Environment.MachineName) < 0 Then
                MessageBox.Show("La operación solicitada no ha podido ser realizada", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                Call Avisar("Listo!")
                Dim obj As New DataTable
                obe.CA_IDEMPRESA = gInt_IdEmpresa
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