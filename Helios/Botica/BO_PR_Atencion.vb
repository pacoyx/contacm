Imports Infragistics.Win.UltraWinGrid
Public Class BO_PR_Atencion
    Private obe As BE.BoticaBE.SG_BO_TB_ATENCION
    Private obr As BL.BoticaBL.SG_BO_TB_ATENCION

    Public lNew As Boolean = False
    Public OPCION As Integer
    Dim IGVTasa As Double
    Public IDMEDICO As String
    Public Sub New()
        InitializeComponent()
        obe = New BE.BoticaBE.SG_BO_TB_ATENCION
        obr = New BL.BoticaBL.SG_BO_TB_ATENCION
    End Sub
    Private Sub pKeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Me.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Return) Then
            SendKeys.Send("{TAB}")
            e.Handled = True
        End If
    End Sub
    Private Sub pKeyPressNumero(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_Serie.KeyPress, txt_Numero.KeyPress
        e.KeyChar = fKeyPress(e.KeyChar, sender.Text, 1)
        e.Handled = (e.KeyChar = "")
    End Sub
    Private Sub pLostfocus(ByVal sender As Object, ByVal e As System.EventArgs) ' Handles txt_DesCorto.LostFocus, txt_Descripcion.LostFocus
        sender.BackColor = Color.White
        If sender.Text.Trim.Length < 1 Then
            sender.BackColor = Color.LightPink
        End If
    End Sub
    Private Sub Inicializa()
        Call Limpiar_Controls_InGroupox(ugb_Datos)
        Call Limpiar_Controls_InGroupox(ugb_Cuenta)
        txt_Serie.BackColor = Color.White
        txt_Numero.BackColor = Color.White

        ugb_Cuenta.Enabled = True
        ug_Lista.Enabled = False
        uce_TipoDoc.SelectedIndex = 0

    End Sub

    Private Function fValida() As Boolean
        pLostfocus(txt_Serie, Nothing)
        pLostfocus(txt_Numero, Nothing)

        If txt_Serie.BackColor = Color.LightPink Then GoTo Err_Valida
        If txt_Numero.BackColor = Color.LightPink Then GoTo Err_Valida


        Return True
        Exit Function
Err_Valida:
        MessageBox.Show("Corrija ó Complete los campos errados !!", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Return False
    End Function

    Private Sub AD_PR_Atencion_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        obe = New BE.BoticaBE.SG_BO_TB_ATENCION
        obr = New BL.BoticaBL.SG_BO_TB_ATENCION
        Me.KeyPreview = True

        udte_fechaD.Value = gDat_Fecha_Sis
        udte_fechaH.Value = gDat_Fecha_Sis
        ubtn_consultar.Appearance.Image = My.Resources._16__Search_

        Call Inicializar_Estado_Botones_Tool(ToolS_Mantenimiento)
        Call MostrarTabs(0, utc_Datos, 0)
        Call Inicializa()
        Call Cargar_Datos()
        Call Formatear_Grilla_Selector(ug_Cuentas)

        Tool_Eliminar.Enabled = False

    End Sub

    Private Sub Tool_Nuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_Nuevo.Click
        If ug_Cuentas.Rows.Count <= 0 Then Exit Sub
        Call Cambiar_Estado_Botones_Tool(ToolS_Mantenimiento)
        Call MostrarTabs(1, utc_Datos, 1)
        Inicializa()
        lNew = True

        Call Formatear_Grilla_Selector(ug_Lista)
        Dim obj As New DataTable
        obe.AT_IDCuenta = Val(ug_Cuentas.ActiveRow.Cells(0).Value)
        txt_idCuenta.Text = ug_Cuentas.ActiveRow.Cells(0).Value
        obr.SEL01(obe, obj)
        ug_Lista.DataSource = obj

        ug_Lista.DisplayLayout.Appearance.FontData.Name = "Calibri"

        ug_Lista.Enabled = False
        Tool_Eliminar.Enabled = False
    End Sub

    Private Sub Tool_Cancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_Cancelar.Click
        Call Cambiar_Estado_Botones_Tool(ToolS_Mantenimiento)
        Call MostrarTabs(0, utc_Datos, 0)
        Tool_Eliminar.Enabled = False
    End Sub

    Private Sub Tool_Grabar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_Grabar.Click
        If fValida() = False Then Exit Sub

        With obe
            .AT_IDCuenta = txt_IdCuenta.Value
            .AT_IDTipoDoc = uce_TipoDoc.Value
            .AT_Numero = txt_Numero.Text
            .AT_Serie = txt_Serie.Text
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
            obe.AT_ID = txt_id.Value
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
        Call Tool_Cancelar_Click(sender, e)

    End Sub

    Private Sub Tool_Editar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_Editar.Click
        If ug_Cuentas.Rows.Count <= 0 Then Exit Sub
        lNew = False

        Call Formatear_Grilla_Selector(ug_Lista)
        Dim obj As New DataTable
        obe.AT_IDCuenta = Val(ug_Cuentas.ActiveRow.Cells(0).Value)
        txt_idCuenta.Text = ug_Cuentas.ActiveRow.Cells(0).Value
        obr.SEL01(obe, obj)
        ug_Lista.DataSource = obj

        ug_Lista.DisplayLayout.Appearance.FontData.Name = "Calibri"

        Call Cambiar_Estado_Botones_Tool(ToolS_Mantenimiento)

        'txt_id.Text = ug_Lista.ActiveRow.Cells(0).Value
        'txt_IdCuenta.Value = ug_Lista.ActiveRow.Cells(1).Value
        'uce_TipoDoc.Value = IIf(ug_Lista.ActiveRow.Cells(2).Value = "Factura", "01", "02")
        'txt_Serie.Value = ug_Lista.ActiveRow.Cells(3).Value
        'txt_Numero.Value = ug_Lista.ActiveRow.Cells(4).Value

        ugb_Cuenta.Enabled = False
        'Buscar_CuentaEditar()
        ug_Lista.Enabled = True
        Call MostrarTabs(1, utc_Datos, 1)
        'uchk_Cuenta.Focus()
        Tool_Eliminar.Enabled = True
        'llenar datos
    End Sub

    Private Sub Tool_Eliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_Eliminar.Click
        If Preguntar("Seguro de Eliminar?") Then
            obe.AT_ID = ug_Lista.ActiveRow.Cells(0).Value
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
       
        txt_id.Text = ug_Lista.ActiveRow.Cells(0).Value
        ' txt_idCuenta.Value = ug_Lista.ActiveRow.Cells(1).Value
        uce_TipoDoc.Value = IIf(ug_Lista.ActiveRow.Cells(2).Value = "Factura", "01", "02")
        txt_Serie.Value = ug_Lista.ActiveRow.Cells(3).Value
        txt_Numero.Value = ug_Lista.ActiveRow.Cells(4).Value

        ugb_Cuenta.Enabled = True
    End Sub

    Private Sub ug_Cuentas_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles ug_Cuentas.DoubleClick
        Tool_Editar_Click(sender, e)
    End Sub

    Private Sub ubtn_consultar_Click(sender As System.Object, e As System.EventArgs) Handles ubtn_consultar.Click
        Call Cargar_Datos()
    End Sub

    Private Sub Cargar_Datos()
        Dim boticalc As New BL.AdmisionBL.SG_AD_TB_CUENTA_CAB
        ug_Cuentas.DataSource = boticalc.SEL07(gInt_IdEmpresa, CDate(udte_fechaD.Value).ToShortDateString, CDate(udte_fechaH.Value).ToShortDateString)
        boticalc = Nothing
    End Sub
End Class