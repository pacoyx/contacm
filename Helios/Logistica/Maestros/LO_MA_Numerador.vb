Public Class LO_MA_Numerador
    Private obe As BE.LogisticaBE.SG_LO_TB_NUM_COMPRO
    Private obr As BL.LogisticaBL.SG_LO_TB_NUM_COMPRO
    Private lNew As Boolean = False
    Public Sub New()
        InitializeComponent()
        obe = New BE.LogisticaBE.SG_LO_TB_NUM_COMPRO
        obr = New BL.LogisticaBL.SG_LO_TB_NUM_COMPRO
    End Sub

    Private Sub pKeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Me.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Return) Then
            SendKeys.Send("{TAB}")
            e.Handled = True
        End If
    End Sub
    Private Sub pKeyPressNumero(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_NumDoc.KeyPress, txt_serie.KeyPress
        e.KeyChar = fKeyPress(e.KeyChar, sender.Text, 1)
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
        pLostfocus(txt_NumDoc, Nothing)
        pLostfocus(txt_serie, Nothing)
        If txt_NumDoc.BackColor = Color.LightPink Then GoTo Err_Valida
        If txt_serie.BackColor = Color.LightPink Then GoTo Err_Valida
        Return True
        Exit Function
Err_Valida:
        MessageBox.Show("Corrija ó Complete los campos errados !!", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Return False
    End Function
    Private Sub Inicializa()
        Call Limpiar_Controls_InGroupox(ugb_datos)
        txt_NumDoc.BackColor = Color.White
        txt_serie.BackColor = Color.White
    End Sub

    Private Sub LO_MA_Numerador_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim documentosBL As New BL.LogisticaBL.SG_LO_TB_TIPO_DOCUMENTO
        uce_TipoDoc.DataSource = documentosBL.get_ListaDoc(gInt_IdEmpresa)
        uce_TipoDoc.DisplayMember = "TD_DESCRIPCION"
        uce_TipoDoc.ValueMember = "TD_ID"
        documentosBL = Nothing

        Call Inicializar_Estado_Botones_Tool(ToolS_Mantenimiento)
        Call MostrarTabs(0, utc_Numeracion, 0)

        obe = New BE.LogisticaBE.SG_LO_TB_NUM_COMPRO
        obr = New BL.LogisticaBL.SG_LO_TB_NUM_COMPRO

        Me.KeyPreview = True

        Call Formatear_Grilla_Selector(ug_Lista_Num)
        obe.NC_IDEMPRESA = gInt_IdEmpresa
        ug_Lista_Num.DataSource = obr.SEL01(obe)

        Inicializa()

    End Sub

    Private Sub Tool_Nuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_Nuevo.Click
        Call Cambiar_Estado_Botones_Tool(ToolS_Mantenimiento)
        Call MostrarTabs(1, utc_Numeracion, 1)
        Inicializa()
        uce_TipoDoc.Enabled = True
        txt_serie.Enabled = True
        lNew = True
        uce_TipoDoc.Focus()

    End Sub

    Private Sub Tool_Cancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_Cancelar.Click
        Call Cambiar_Estado_Botones_Tool(ToolS_Mantenimiento)
        Call MostrarTabs(0, utc_Numeracion, 0)
    End Sub

    Private Sub Tool_Grabar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_Grabar.Click
        If fValida() = False Then Exit Sub

        With obe
            .NC_IDTIPO = uce_TipoDoc.Value
            .NC_SERIE = txt_serie.Text
            .NC_NUMERO = txt_NumDoc.Text
            .NC_IDEMPRESA = gInt_IdEmpresa
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
        obe.NC_IDEMPRESA = gInt_IdEmpresa
        ug_Lista_Num.DataSource = obr.SEL01(obe)

        Call Cambiar_Estado_Botones_Tool(ToolS_Mantenimiento)
        Call Tool_Nuevo_Click(sender, e)

    End Sub

    Private Sub Tool_Editar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_Editar.Click
        If ug_Lista_Num.Rows.Count <= 0 Then Exit Sub
        lNew = False

        Call Cambiar_Estado_Botones_Tool(ToolS_Mantenimiento)

        uce_TipoDoc.Value = ug_Lista_Num.ActiveRow.Cells(0).Value
        txt_serie.Text = ug_Lista_Num.ActiveRow.Cells(2).Value
        txt_NumDoc.Text = ug_Lista_Num.ActiveRow.Cells(3).Value

        uce_TipoDoc.Enabled = False
        txt_serie.Enabled = False

        Call MostrarTabs(1, utc_Numeracion, 1)
        uce_TipoDoc.Focus()

    End Sub

    Private Sub Tool_Eliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_Eliminar.Click
        If ug_Lista_Num.Rows.Count <= 0 Then Exit Sub
        If Preguntar("Seguro de Eliminar?") Then
            obe.NC_IDTIPO = ug_Lista_Num.ActiveRow.Cells(0).Value
            obe.NC_SERIE = ug_Lista_Num.ActiveRow.Cells(2).Value
            obe.NC_IDEMPRESA = gInt_IdEmpresa
            If obr.Delete(obe, String.Format("{0}-{1}", Environment.UserName, gStr_Usuario_Sis), Environment.MachineName) < 0 Then
                MessageBox.Show("La operación solicitada no ha podido ser realizada", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                Call Avisar("Listo!")
                obe.NC_IDEMPRESA = gInt_IdEmpresa
                ug_Lista_Num.DataSource = obr.SEL01(obe)
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