Public Class BB_RE_ListaRegistro
    Private obe As BE.NeoBE.SA_TB_BB_REGISTRO
    Private obr As BL.NeoBL.SA_TB_BB_REGISTRO
    Dim lista As New List(Of String)
    Public Sub New()
        InitializeComponent()
        obe = New BE.NeoBE.SA_TB_BB_REGISTRO
        obr = New BL.NeoBL.SA_TB_BB_REGISTRO
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

    Private Sub FA_PR_ListaAyuda_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        txt_filtro.Focus()
    End Sub

    Private Sub CargarLista()
        Dim obj As New DataTable
        obr.SEL03(uce_campos.Value, txt_filtro.Text, obj)
        ug_data.DataSource = obj
    End Sub

    Private Sub BB_RE_ListaRegistro_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        uce_campos.SelectedIndex = 0

        obe = New BE.NeoBE.SA_TB_BB_REGISTRO
        obr = New BL.NeoBL.SA_TB_BB_REGISTRO

        Call Formatear_Grilla_Selector(ug_data)

        CargarLista()

        Me.KeyPreview = True
    End Sub
 
    Private Sub Tool_Consultar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_Consultar.Click
        CargarLista()

    End Sub

    Private Sub Tool_Aceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_Aceptar.Click
        lista.Clear()
        If ug_data.Rows.Count > 0 Then
            For i As Integer = 0 To ug_data.DisplayLayout.Bands(0).Columns.Count - 1
                lista.Add(ug_data.ActiveRow.Cells(i).Value.ToString)
            Next
        End If

        Me.Close()
    End Sub

    Private Sub Tool_Salir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_Salir.Click
        lista.Clear()
        Me.Close()
    End Sub

    Private Sub pFormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        obe = Nothing
        obr = Nothing
    End Sub

    Private Sub ug_data_DoubleClickRow(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.DoubleClickRowEventArgs) Handles ug_data.DoubleClickRow
        If ug_data.ActiveRow.IsFilterRow Then Exit Sub
        If ug_data.Rows.Count > 0 Then Tool_Aceptar_Click(sender, e)
    End Sub

    Private Sub txt_filtro_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_filtro.LostFocus
        CargarLista()
    End Sub
End Class