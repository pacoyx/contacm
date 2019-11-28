Public Class BB_LT_AyudaCuenta
    Private obe As BE.AdmisionBE.SG_AD_TB_CUENTA_CAB
    Private obr As BL.AdmisionBL.SG_AD_TB_CUENTA_CAB
    Public TIPO As Integer '2=HOSPI,1=TODAS
    ' Dim Dv_data As DataView
    Dim lista As New List(Of String)
    Public Sub New()
        InitializeComponent()
        obe = New BE.AdmisionBE.SG_AD_TB_CUENTA_CAB
        obr = New BL.AdmisionBL.SG_AD_TB_CUENTA_CAB
    End Sub
    Public Function GetLista() As List(Of String)
        Return lista
    End Function

    Private Sub BB_LT_AyudaCuenta_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        txt_filtro.Focus()
    End Sub
    Private Sub pKeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Me.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Return) Then
            SendKeys.Send("{TAB}")
            e.Handled = True
        End If
    End Sub
    Private Sub BB_LT_AyudaCuenta_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        uce_campos.SelectedIndex = 0

        obe = New BE.AdmisionBE.SG_AD_TB_CUENTA_CAB
        obr = New BL.AdmisionBL.SG_AD_TB_CUENTA_CAB

        Call Formatear_Grilla_Selector(ug_data)

        Cargar_grilla()

        Me.KeyPreview = True
    End Sub
    Public Sub Cargar_grilla()
        Dim obj As New DataTable
        obr.SEL13(uce_campos.Value, txt_filtro.Text, obj)
        ug_data.DataSource = obj
    End Sub
    Private Sub ubtn_Consultar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ubtn_Consultar.Click
        Cargar_grilla()
    End Sub
    Private Sub uce_campos_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles uce_campos.KeyDown
        If e.KeyCode = Keys.Enter Then txt_filtro.Focus()
    End Sub

    Private Sub ug_data_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles ug_data.KeyDown
        Try
            If ug_data.Rows.Count > 0 Then
                If ug_data.ActiveRow.Index = 0 Then
                    If e.KeyCode = Keys.Up Then
                        txt_filtro.Focus()
                    End If
                End If

                If e.KeyCode = Keys.Enter Then

                    lista.Clear()
                    If ug_data.Rows.Count > 0 Then
                        For i As Integer = 0 To ug_data.DisplayLayout.Bands(0).Columns.Count - 1
                            lista.Add(ug_data.ActiveRow.Cells(i).Value.ToString)
                        Next
                    End If

                    Me.Close()

                End If
            End If
        Catch ex As Exception

        End Try
    End Sub


    Private Sub ug_data_DoubleClickRow(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.DoubleClickRowEventArgs) Handles ug_data.DoubleClickRow
        If ug_data.ActiveRow.IsFilterRow Then Exit Sub
        If ug_data.Rows.Count > 0 Then
            lista.Clear()
            If ug_data.Rows.Count > 0 Then
                For i As Integer = 0 To ug_data.DisplayLayout.Bands(0).Columns.Count - 1
                    lista.Add(ug_data.ActiveRow.Cells(i).Value.ToString)
                Next
            End If

            Me.Close()
        End If
    End Sub

    Private Sub txt_filtro_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_filtro.LostFocus
        ubtn_Consultar_Click(Nothing, Nothing)
    End Sub

End Class