Public Class FA_PR_ListaCuentas
    Private obe As BE.AdmisionBE.SG_AD_TB_CUENTA_CAB
    Private obr As BL.AdmisionBL.SG_AD_TB_CUENTA_CAB

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
    Private Sub pKeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Me.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Return) Then
            SendKeys.Send("{TAB}")
            e.Handled = True
        End If
    End Sub

    Private Sub FA_PR_ListaAyuda_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        txt_filtro.Focus()
    End Sub

    Private Sub FA_PR_ListaAyuda_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        ubtn_Aceptar.Appearance.Image = My.Resources._16__Ok_
        ubtn_Cancelar.Appearance.Image = My.Resources._16__Cancel_
        uce_campos.SelectedIndex = 0

        obe = New BE.AdmisionBE.SG_AD_TB_CUENTA_CAB
        obr = New BL.AdmisionBL.SG_AD_TB_CUENTA_CAB

        Call Formatear_Grilla_Selector(ug_data)
        uck_Fecha.Checked = False
        udte_fechaD.Value = Now
        udte_fechaH.Value = Now
        udte_fechaD.Enabled = False
        udte_fechaH.Enabled = False

        obe.CC_IDEMPRESA = gInt_IdEmpresa
        Dim obj As New DataTable
        obr.SEL05(obe, uce_campos.Value, txt_filtro.Text, uck_Fecha.Checked, udte_fechaD.Text, udte_fechaH.Text, obj)
        ug_data.DataSource = obj

        Me.KeyPreview = True
    End Sub

    Private Sub ubtn_Consultar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ubtn_Consultar.Click
        Dim obj As New DataTable
        obe.CC_IDEMPRESA = gInt_IdEmpresa
        obr.SEL05(obe, uce_campos.Value, txt_filtro.Text, uck_Fecha.Checked, udte_fechaD.Text, udte_fechaH.Text, obj)
        ug_data.DataSource = obj
    End Sub

    Private Sub ubtn_Aceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ubtn_Aceptar.Click
        lista.Clear()
        For i As Integer = 0 To ug_data.DisplayLayout.Bands(0).Columns.Count - 1
            lista.Add(ug_data.ActiveRow.Cells(i).Value.ToString)
        Next
        Me.Close()
    End Sub

    Private Sub ubtn_Cancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ubtn_Cancelar.Click
        lista.Clear()
        Me.Close()
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
                    ubtn_Aceptar_Click(sender, e)
                End If
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub ug_data_DoubleClickRow(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.DoubleClickRowEventArgs) Handles ug_data.DoubleClickRow
        If ug_data.ActiveRow.IsFilterRow Then Exit Sub
        If ug_data.Rows.Count > 0 Then ubtn_Aceptar_Click(sender, e)
    End Sub

    Private Sub uck_Fecha_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles uck_Fecha.CheckedChanged
        If uck_Fecha.Checked = True Then
            udte_fechaD.Enabled = True
            udte_fechaH.Enabled = True
        Else
            udte_fechaD.Value = Now
            udte_fechaH.Value = Now
            udte_fechaD.Enabled = False
            udte_fechaH.Enabled = False
        End If
    End Sub
End Class