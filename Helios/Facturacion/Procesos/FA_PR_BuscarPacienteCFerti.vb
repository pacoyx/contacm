Public Class FA_PR_BuscarPacienteCFerti
    Private obr As BL.FertilidadBL.SG_FA_Reportes
    Dim lista As New List(Of String)
    Public Sub New()
        InitializeComponent()
        obr = New BL.FertilidadBL.SG_FA_Reportes
    End Sub

    Public Function GetLista() As List(Of String)
        Return lista
    End Function
    Private Sub pKeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Me.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Return) Then
            SendKeys.Send("{TAB}")
            e.Handled = True
        End If
    End Sub

    Private Sub ubtn_Aceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        lista.Clear()

        If ug_Lista.Rows.Count > 0 Then
            If Not ug_Lista.ActiveRow Is Nothing Then

                lista.Add(ug_Lista.ActiveRow.Cells(0).Value.ToString)
                lista.Add(ug_Lista.ActiveRow.Cells(1).Value.ToString)
                lista.Add(ug_Lista.ActiveRow.Cells(2).Value.ToString)
                lista.Add(ug_Lista.ActiveRow.Cells(3).Value.ToString)
                lista.Add(ug_Lista.ActiveRow.Cells(4).Value.ToString)
            End If
        End If
        Me.Close()
    End Sub

    Private Sub ug_Lista_Hist_Clin_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles ug_Lista.KeyDown
        Try
            If ug_Lista.Rows.Count > 0 Then
                If ug_Lista.ActiveRow.Index = 0 Then
                    If e.KeyCode = Keys.Up Then
                        txt_Filtro.Focus()
                    End If
                End If
                If e.KeyCode = Keys.Enter Then
                    ubtn_Aceptar_Click(sender, e)
                End If
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub ug_Lista_Hist_Clin_DoubleClickRow(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.DoubleClickRowEventArgs) Handles ug_Lista.DoubleClickRow
        If ug_Lista.ActiveRow.IsFilterRow Then Exit Sub
        If ug_Lista.Rows.Count > 0 Then ubtn_Aceptar_Click(sender, e)
    End Sub

    Private Sub AD_PR_BuscaPaciente_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        ' ubtn_Aceptar.Appearance.Image = My.Resources._16__Ok_
        ' ubtn_Cancelar.Appearance.Image = My.Resources._16__Cancel_
        ucb_Campos.SelectedIndex = 0
        txt_Filtro.Text = ""
        obr = New BL.FertilidadBL.SG_FA_Reportes

        'Call Formatear_Grilla_Selector(ug_Lista)
        Call LimpiaGrid(ug_Lista, uds_Lista)
        'obe.HC_IDEMPRESA = gInt_IdEmpresa
        'Dim obj As New DataTable
        'obr.SEL01(obe, ucb_Campos.Value, txt_Filtro.Text, obj)
        'ug_Lista.DataSource = obj

        lista.Clear()
        txt_Filtro.Focus()

        Me.KeyPreview = True
    End Sub

    Private Sub ubtn_Consultar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ubtn_Consultar.Click
        Dim obj As New DataTable
        obr.get_Fertilidad_Busqueda(txt_Filtro.Text, Val(ucb_Campos.Value), obj)
        ug_Lista.DataSource = obj
    End Sub

    Private Sub txt_Filtro_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_Filtro.Leave
        ubtn_Consultar_Click(sender, e)
    End Sub
End Class