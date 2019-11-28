Public Class LO_MA_Usu_Almacen
    Private obe As BE.LogisticaBE.SG_LO_TB_USU_ALMACEN
    Private obr As BL.LogisticaBL.SG_LO_TB_USU_ALMACEN
    Public Sub New()
        InitializeComponent()
        obe = New BE.LogisticaBE.SG_LO_TB_USU_ALMACEN
        obr = New BL.LogisticaBL.SG_LO_TB_USU_ALMACEN
    End Sub
    Private Sub pKeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Me.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Return) Then
            SendKeys.Send("{TAB}")
            e.Handled = True
        End If
    End Sub

    Private Sub LO_MA_Usu_Almacen_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call Cargar_Usuario()
        Call Cargar_Almacen()
        obe = New BE.LogisticaBE.SG_LO_TB_USU_ALMACEN
        obr = New BL.LogisticaBL.SG_LO_TB_USU_ALMACEN
        Me.KeyPreview = True
    End Sub

    Private Sub Cargar_Almacen_x_Usuario()

        obe.UA_IDEMPRESA = gInt_IdEmpresa
        obe.UA_IDUSUARIO = uce_usuario.Value

        lb_Lista.DataSource = obr.SEL01(obe)
        lb_Lista.DisplayMember = "AL_DESCRIPCION"
        lb_Lista.ValueMember = "UA_IDALMACEN"

    End Sub

    Private Sub Cargar_Usuario()

        Dim usuarioBL As New BL.ContabilidadBL.SG_CO_TB_USUARIO
        'une_idusuario.Value = usuarioBL.getIdUsu_x_NomUsu(gStr_Usuario_Sis)
        uce_usuario.DataSource = usuarioBL.getUsuarios
        uce_usuario.DisplayMember = "US_NOMBRE"
        uce_usuario.ValueMember = "US_ID"
        usuarioBL = Nothing

    End Sub

    Private Sub Cargar_Almacen()

        Dim ABL As New BL.LogisticaBL.SG_LO_TB_ALMACEN

        uce_Almacen.DataSource = ABL.get_almacen_3(gInt_IdEmpresa)
        uce_Almacen.DisplayMember = "AL_DESCRIPCION"
        uce_Almacen.ValueMember = "AL_ID"
        ABL = Nothing
    End Sub

    Private Sub Tool_Salir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_Salir.Click
        Me.Close()
    End Sub

    Private Sub ubtn_Agregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ubtn_Agregar.Click
        If uce_Almacen.Value = "" Then Exit Sub

        For i As Integer = 0 To lb_Lista.Items.Count - 1
            Dim dr As DataRowView
            dr = lb_Lista.Items(i)
            If dr.Row.Item(0).ToString = uce_Almacen.Value Then
                Avisar("Ya existe el punto de venta en la lista")
                Exit Sub
            End If
        Next

        'Dim usuPtovtaBL As New BL.FacturacionBL.SG_FA_TB_USU_PTOVTA
        'Dim usuPtovtaBE As New BE.FacturacionBE.SG_FA_TB_USU_PTOVTA
        obe.UA_IDEMPRESA = gInt_IdEmpresa
        obe.UA_IDUSUARIO = uce_usuario.Value
        obe.UA_IDALMACEN = uce_Almacen.Value

        If obr.Insert(obe, String.Format("{0}-{1}", Environment.UserName, gStr_Usuario_Sis), Environment.MachineName) < 0 Then
            MessageBox.Show("La operación solicitada no ha podido ser realizada", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        Call Cargar_Almacen_x_Usuario()

    End Sub

    Private Sub uce_usuario_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles uce_usuario.ValueChanged
        Call Cargar_Almacen_x_Usuario()
    End Sub

    Private Sub ubtn_eliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ubtn_eliminar.Click
        obe.UA_IDEMPRESA = gInt_IdEmpresa
        obe.UA_IDUSUARIO = uce_usuario.Value
        obe.UA_IDALMACEN = lb_Lista.SelectedValue

        If obr.Delete(obe, String.Format("{0}-{1}", Environment.UserName, gStr_Usuario_Sis), Environment.MachineName) < 0 Then
            MessageBox.Show("La operación solicitada no ha podido ser realizada", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        Call Cargar_Almacen_x_Usuario()
    End Sub
    Private Sub pFormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        obe = Nothing
        obr = Nothing
        e.Cancel = False
    End Sub

End Class