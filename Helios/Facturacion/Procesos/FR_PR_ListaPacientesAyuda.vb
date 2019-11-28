Public Class FR_PR_ListaPacientesAyuda


    Dim Dv_data As DataView
    Dim lista As New List(Of String)
    Dim historiasBL As New BL.AdmisionBL.SG_AD_TB_HISTO_CLINI


    Public Function GetLista() As List(Of String)
        Return lista
    End Function

    Private Sub FR_PR_ListaPacientesAyuda_Activated(sender As Object, e As System.EventArgs) Handles Me.Activated
        txt_filtro.Text = ""
        Call LimpiaGrid(ug_data, uds_Data)
        txt_filtro.Focus()
    End Sub

    Private Sub FR_PR_ListaPacientesAyuda_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        uce_campos.SelectedIndex = 0
        ubtn_Aceptar.Appearance.Image = My.Resources._16__Ok_
        ubtn_Cancelar.Appearance.Image = My.Resources._16__Cancel_

    End Sub

    Private Sub txt_filtro_ValueChanged(sender As System.Object, e As System.EventArgs) Handles txt_filtro.ValueChanged
        If txt_filtro.Text.Trim = "" Then
            Call LimpiaGrid(ug_data, uds_Data)
        Else
            If uchk_sinHisto.Checked Then
                ug_data.DataSource = historiasBL.SEL04(txt_filtro.Text.Trim, uce_campos.Value, gInt_IdEmpresa)
            Else
                ug_data.DataSource = historiasBL.SEL03(txt_filtro.Text.Trim, uce_campos.Value, gInt_IdEmpresa)
            End If
        End If
    End Sub

    Private Sub ubtn_Aceptar_Click(sender As System.Object, e As System.EventArgs) Handles ubtn_Aceptar.Click
        lista.Clear()
        For i As Integer = 0 To ug_data.DisplayLayout.Bands(0).Columns.Count - 1
            lista.Add(ug_data.ActiveRow.Cells(i).Value.ToString)
        Next

        lista.Add(IIf(uchk_sinHisto.Checked, "1", "0"))

        Me.Close()
    End Sub

    Private Sub ubtn_Cancelar_Click(sender As System.Object, e As System.EventArgs) Handles ubtn_Cancelar.Click
        lista.Clear()
        Me.Close()
    End Sub

    Private Sub uce_campos_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles uce_campos.KeyDown
        If e.KeyCode = Keys.Enter Then txt_filtro.Focus()
    End Sub

    Private Sub txt_filtro_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_filtro.KeyDown

        If e.KeyCode = Keys.Enter Then
            If ug_data.Rows.Count > 0 Then
                Call ubtn_Aceptar_Click(sender, e)
            End If
        End If


        If e.KeyCode = Keys.Down Then
            If ug_data.Rows.Count > 0 Then
                ug_data.Focus()
            End If
        End If


        If e.KeyCode = Keys.Escape Then
            ubtn_Cancelar_Click(sender, e)
        End If

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

    Private Sub uchk_sinHisto_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles uchk_sinHisto.CheckedChanged
        If txt_filtro.Text.Trim = "" Then
            Call LimpiaGrid(ug_data, uds_Data)
        Else
            If uchk_sinHisto.Checked Then
                ug_data.DataSource = historiasBL.SEL04(txt_filtro.Text.Trim, uce_campos.Value, gInt_IdEmpresa)
            Else
                ug_data.DataSource = historiasBL.SEL03(txt_filtro.Text.Trim, uce_campos.Value, gInt_IdEmpresa)
            End If
        End If
    End Sub
End Class