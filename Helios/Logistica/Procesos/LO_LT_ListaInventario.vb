Public Class LO_LT_ListaInventario
    Private obe As BE.LogisticaBE.SG_LO_TB_SALDOS_C
    Private obr As BL.LogisticaBL.SG_LO_TB_SALDOS_C

    Dim lista As New List(Of String)
    Public Sub New()
        InitializeComponent()
        obe = New BE.LogisticaBE.SG_LO_TB_SALDOS_C
        obr = New BL.LogisticaBL.SG_LO_TB_SALDOS_C
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

    Private Sub LO_LT_ListaInventario_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        uce_Almacen.Focus()
    End Sub
    Private Sub LO_LT_ListaInventario_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ubtn_Aceptar.Appearance.Image = My.Resources._16__Ok_
        ubtn_Cancelar.Appearance.Image = My.Resources._16__Cancel_

        Dim AlcBL As New BL.LogisticaBL.SG_LO_TB_ALMACEN
        uce_Almacen.DataSource = AlcBL.get_almacen_2(gInt_IdEmpresa, gInt_IdUsuario_Sis)
        uce_Almacen.DisplayMember = "AL_DESCRIPCION"
        uce_Almacen.ValueMember = "AL_ID"
        AlcBL = Nothing

        uce_Almacen.SelectedIndex = 0

        obe = New BE.LogisticaBE.SG_LO_TB_SALDOS_C
        obr = New BL.LogisticaBL.SG_LO_TB_SALDOS_C

        Call Formatear_Grilla_Selector(ug_data)
        uck_Fecha.Checked = False
        udte_fechaD.Value = Now
        udte_fechaH.Value = Now
        udte_fechaD.Enabled = False
        udte_fechaH.Enabled = False

        obe.SA_IDALMACEN = uce_Almacen.Value
        obe.SA_FECHA_APERTURA = udte_fechaD.Value
        obe.SA_FECHA_CIERRE = udte_fechaH.Value
        ug_data.DataSource = obr.SEL03(obe, IIf(uck_Fecha.Checked = True, 1, 0), gInt_IdEmpresa)

        Me.KeyPreview = True
    End Sub

    Private Sub ubtn_Consultar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ubtn_Consultar.Click
        obe.SA_IDALMACEN = uce_Almacen.Value
        obe.SA_FECHA_APERTURA = udte_fechaD.Value
        obe.SA_FECHA_CIERRE = udte_fechaH.Value
        ug_data.DataSource = obr.SEL03(obe, IIf(uck_Fecha.Checked = True, 1, 0), gInt_IdEmpresa)
    End Sub

    Private Sub ubtn_Aceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ubtn_Aceptar.Click
        lista.Clear()
        If ug_data.Rows.Count > 0 Then
            For i As Integer = 0 To ug_data.DisplayLayout.Bands(0).Columns.Count - 1
                lista.Add(ug_data.ActiveRow.Cells(i).Value.ToString)
            Next
        End If

        Me.Close()
    End Sub

    Private Sub ubtn_Cancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ubtn_Cancelar.Click
        lista.Clear()
        Me.Close()
    End Sub

    Private Sub ug_data_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles ug_data.KeyDown
        Try
            If ug_data.Rows.Count > 0 Then
                If ug_data.ActiveRow.Index = 0 Then
                    If e.KeyCode = Keys.Up Then
                        ug_data.Focus()
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