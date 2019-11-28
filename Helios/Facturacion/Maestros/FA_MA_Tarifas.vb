Public Class FA_MA_Tarifas
    '    Private obe As BE.FacturacionBE.SG_FA_TB_ARTI_SEGU
    '    Private obr As BL.FacturacionBL.SG_FA_TB_ARTI_SEGU
    '    Private lNew As Boolean = False
    '    Public IGVTas As Double

    '    Public Sub New()
    '        InitializeComponent()
    '        obe = New BE.FacturacionBE.SG_FA_TB_ARTI_SEGU
    '        obr = New BL.FacturacionBL.SG_FA_TB_ARTI_SEGU
    '    End Sub

    '    Private Sub pKeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Me.KeyPress
    '        If e.KeyChar = Convert.ToChar(Keys.Return) Then
    '            SendKeys.Send("{TAB}")
    '            e.Handled = True
    '        End If
    '    End Sub

    '    Private Sub pLostfocus(ByVal sender As Object, ByVal e As System.EventArgs) ' Handles txt_DesCorto.LostFocus, txt_Descripcion.LostFocus
    '        sender.BackColor = Color.White
    '        If sender.Text.Trim.Length < 1 Then
    '            sender.BackColor = Color.LightPink
    '        End If
    '    End Sub

    '    Private Sub Cargar_Tasas_Impuestos()

    '        Dim impuestosBL As New BL.ContabilidadBL.SG_CO_TB_IMPUESTO
    '        Dim impuestoBE As New BE.ContabilidadBE.SG_CO_TB_IMPUESTO

    '        impuestoBE.IM_IDEMPRESA = New BE.ContabilidadBE.SG_CO_TB_EMPRESA With {.EM_ID = gInt_IdEmpresa}
    '        impuestoBE.IM_IDTIPOIMPUESTO = New BE.ContabilidadBE.SG_CO_TB_TIPO_IMPUESTO With {.TI_CODIGO = "01"}
    '        impuestoBE.IM_PERIODO = Date.Now.Year
    '        impuestoBE.IM_MES = Date.Now.Month

    '        impuestosBL.getImpuestos_x_Tipo(impuestoBE)
    '        IGVTas = impuestoBE.IM_TASA

    '        impuestosBL = Nothing
    '        impuestoBE = Nothing

    '    End Sub

    '    Private Function fValida() As Boolean
    '        If lNew Then
    '            pLostfocus(ucb_Seguro, Nothing)
    '        Else
    '            pLostfocus(txt_NombreSeg, Nothing)
    '        End If

    '        If ucb_Seguro.BackColor = Color.LightPink Then GoTo Err_Valida
    '        If txt_NombreSeg.BackColor = Color.LightPink Then GoTo Err_Valida
    '        Return True
    '        Exit Function
    'Err_Valida:
    '        MessageBox.Show("Corrija ó Complete los campos errados !!", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error)
    '        Return False
    '    End Function
    '    Private Sub Inicializa()
    '        Call Limpiar_Controls_InGroupox(ugb_datos)
    '        txt_NombreSeg.BackColor = Color.White
    '        ucb_Seguro.BackColor = Color.White

    '        ucb_Seguro.Visible = True
    '        txt_NombreSeg.Visible = False
    '    End Sub

    '    Private Sub pLoad() Handles MyBase.Load
    '        Call Inicializar_Estado_Botones_Tool(ToolS_Mantenimiento)
    '        Call MostrarTabs(0, utc_Datos, 0)

    '        obe = New BE.FacturacionBE.SG_FA_TB_ARTI_SEGU
    '        obr = New BL.FacturacionBL.SG_FA_TB_ARTI_SEGU

    '        Dim obj1 As New DataTable
    '        obe.AS_IDEMPRESA = gInt_IdEmpresa
    '        obr.SEL03(obe, obj1)
    '        ucb_Seguro.DataSource = obj1
    '        ucb_Seguro.DisplayMember = "CA_DESCRIPCION"
    '        ucb_Seguro.ValueMember = "CA_ID"

    '        Cargar_Tasas_Impuestos()

    '        Me.KeyPreview = True

    '        Call Formatear_Grilla_Selector(ug_Lista)

    '        Dim obj As New DataTable
    '        obr.SEL01(obe, obj)
    '        ug_Lista.DataSource = obj

    '        ug_Lista.DisplayLayout.Appearance.FontData.Name = "Calibri"

    '        Inicializa()
    '    End Sub

    '    Private Sub Tool_Nuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_Nuevo.Click
    '        Call Cambiar_Estado_Botones_Tool(ToolS_Mantenimiento)
    '        Call MostrarTabs(1, utc_Datos, 1)
    '        Inicializa()

    '        Dim obj As New DataTable
    '        obe.AS_IDSEGURO = ""
    '        obe.AS_IDEMPRESA = gInt_IdEmpresa
    '        obr.SEL02(obe, 0, IGVTas, obj)
    '        ug_intervalos.DataSource = obj

    '        Dim obj1 As New DataTable
    '        obe.AS_IDEMPRESA = gInt_IdEmpresa
    '        obr.SEL03(obe, obj1)
    '        ucb_Seguro.DataSource = obj1
    '        ucb_Seguro.DisplayMember = "CA_DESCRIPCION"
    '        ucb_Seguro.ValueMember = "CA_ID"

    '        lNew = True
    '        txt_NombreSeg.Focus()

    '    End Sub

    '    Private Sub Tool_Cancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_Cancelar.Click
    '        Call Cambiar_Estado_Botones_Tool(ToolS_Mantenimiento)
    '        Call MostrarTabs(0, utc_Datos, 0)
    '    End Sub

    '    Private Sub Tool_Grabar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_Grabar.Click
    '        If fValida() = False Then Exit Sub

    '        obe.AS_IDEMPRESA = gInt_IdEmpresa
    '        obe.AS_USUARIO = String.Format("{0}-{1}", Environment.UserName, gStr_Usuario_Sis)
    '        obe.AS_TERMINAL = Environment.MachineName

    '        If lNew Then
    '            obe.AS_IDSEGURO = ucb_Seguro.Value
    '        Else
    '            obe.AS_IDSEGURO = txt_idUsu.Text
    '            obr.Delete(obe, String.Format("{0}-{1}", Environment.UserName, gStr_Usuario_Sis), Environment.MachineName)
    '        End If
    '        ug_intervalos.UpdateData()

    '        For f As Integer = 0 To ug_intervalos.Rows.Count - 1
    '            If ug_intervalos.Rows(f).Cells("Sel").Value Then
    '                obe.AS_IDARTICULO = ug_intervalos.Rows(f).Cells(1).Value
    '                obe.AS_IMPORTE = ug_intervalos.Rows(f).Cells(5).Value
    '                obr.Insert(obe, IGVTas, String.Format("{0}-{1}", Environment.UserName, gStr_Usuario_Sis), Environment.MachineName)
    '            End If
    '        Next

    '        Call Avisar("Listo!")

    '        Dim obj As New DataTable
    '        obr.SEL01(obe, obj)
    '        ug_Lista.DataSource = obj

    '        Call Cambiar_Estado_Botones_Tool(ToolS_Mantenimiento)
    '        Call Tool_Nuevo_Click(sender, e)

    '    End Sub

    '    Private Sub Tool_Editar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_Editar.Click
    '        If ug_Lista.Rows.Count <= 0 Then Exit Sub
    '        '  If ug_Lista.ActiveRow.Cells(0).Value = "" Then Exit Sub
    '        lNew = False

    '        Call Cambiar_Estado_Botones_Tool(ToolS_Mantenimiento)

    '        txt_idUsu.Text = ug_Lista.ActiveRow.Cells(0).Value
    '        txt_NombreSeg.Value = ug_Lista.ActiveRow.Cells(1).Value


    '        Dim obj As New DataTable
    '        obe.AS_IDSEGURO = ug_Lista.ActiveRow.Cells(0).Value
    '        obe.AS_IDEMPRESA = gInt_IdEmpresa
    '        obr.SEL02(obe, 1, IGVTas, obj)
    '        ug_intervalos.DataSource = obj

    '        ucb_Seguro.Visible = False
    '        txt_NombreSeg.Visible = True

    '        Call MostrarTabs(1, utc_Datos, 1)
    '        txt_NombreSeg.Focus()

    '    End Sub

    '    Private Sub Tool_Eliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_Eliminar.Click
    '        If ug_Lista.Rows.Count <= 0 Then Exit Sub
    '        If ug_Lista.ActiveRow.Cells(0).Value = "" Then Exit Sub
    '        If Preguntar("Seguro de Eliminar?") Then
    '            obe.AS_IDSEGURO = ug_Lista.ActiveRow.Cells(0).Value
    '            obe.AS_IDEMPRESA = gInt_IdEmpresa
    '            If obr.Delete(obe, String.Format("{0}-{1}", Environment.UserName, gStr_Usuario_Sis), Environment.MachineName) < 0 Then
    '                MessageBox.Show("La operación solicitada no ha podido ser realizada", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
    '            Else
    '                Call Avisar("Listo!")
    '                Dim obj As New DataTable
    '                obr.SEL01(obe, obj)
    '                ug_Lista.DataSource = obj
    '            End If
    '        End If

    '    End Sub

    '    Private Sub Tool_Salir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_Salir.Click
    '        Me.Close()
    '    End Sub

    '    Private Sub pFormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
    '        If Tool_Grabar.Enabled = True Then
    '            MessageBox.Show("Culmine ó cancele la transacción activa !!!", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
    '            e.Cancel = True
    '        Else
    '            obe = Nothing
    '            obr = Nothing
    '            e.Cancel = False
    '        End If
    '    End Sub

    '    Private Sub ug_Lista_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ug_Lista.DoubleClick
    '        Tool_Editar_Click(sender, e)
    '    End Sub

End Class