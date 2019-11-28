Public Class PL_AY_Lista_Ayuda

    Public Bol_Aceptar As Boolean = False
    Public Bol_MultiSeleccion As Boolean = True
    Public Data As DataTable = Nothing

    Dim dv_lista As New DataView
    Public lista_respuesta As New List(Of BE.PlanillaBE.SG_PL_TB_MATRIZ_RESPUESTA)


    Public ReadOnly Property Matriz()
        Get
            Return lista_respuesta
        End Get
    End Property

    Private Sub PL_AY_Lista_Ayuda_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        txt_filtro.Text = String.Empty
        txt_filtro.Focus()
    End Sub

    Private Sub PL_AY_Lista_Ayuda_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        dv_lista = Data.DefaultView
        ug_ayuda.DataSource = dv_lista
        uce_filtro.SelectedIndex = 1

        For i As Integer = 0 To ug_ayuda.Rows.Count - 1
            ug_ayuda.Rows(i).Cells(1).Activation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
            ug_ayuda.Rows(i).Cells(2).Activation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        Next



        Try
            If Bol_MultiSeleccion Then
                uchk_Todos.Visible = True
                ug_ayuda.DisplayLayout.Bands(0).Columns("Sel").Hidden = False
            Else
                uchk_Todos.Visible = False
                ug_ayuda.DisplayLayout.Bands(0).Columns("Sel").Hidden = True
            End If
        Catch ex As Exception

        End Try

    End Sub

    Private Sub txt_filtro_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_filtro.KeyDown
        If e.KeyCode = Keys.Enter Then
            Call Tool_Aceptar_Click(sender, e)
        End If

        If e.KeyCode = Keys.Down Then
            If ug_ayuda.Rows.Count > 0 Then
                ug_ayuda.Focus()
                ug_ayuda.Rows(0).Activate()
            End If
        End If

    End Sub

    Private Sub txt_filtro_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_filtro.ValueChanged

        dv_lista.RowFilter = uce_filtro.Text & " like '" & txt_filtro.Text.Trim & "%'"

    End Sub

    Private Sub Tool_Salir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_Salir.Click
        Bol_Aceptar = False
        Me.Close()
    End Sub

    Private Sub Tool_Aceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_Aceptar.Click

        Dim respuesta As BE.PlanillaBE.SG_PL_TB_MATRIZ_RESPUESTA

        lista_respuesta.Clear()
        ug_ayuda.UpdateData()

        If Bol_MultiSeleccion Then

            For i As Integer = 0 To ug_ayuda.Rows.Count - 1
                If ug_ayuda.Rows(i).Cells("Sel").Value Then
                    respuesta = New BE.PlanillaBE.SG_PL_TB_MATRIZ_RESPUESTA
                    respuesta.CODIGO = ug_ayuda.Rows(i).Cells("Codigo").Value
                    respuesta.DESCRIPCION = ug_ayuda.Rows(i).Cells("Descripcion").Value
                    lista_respuesta.Add(respuesta)
                End If
            Next

        Else

            respuesta = New BE.PlanillaBE.SG_PL_TB_MATRIZ_RESPUESTA
            respuesta.CODIGO = ug_ayuda.ActiveRow.Cells("Codigo").Value
            respuesta.DESCRIPCION = ug_ayuda.ActiveRow.Cells("Descripcion").Value
            lista_respuesta.Add(respuesta)

        End If


        Bol_Aceptar = True
        Me.Close()
    End Sub

    
    Private Sub uchk_Todos_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles uchk_Todos.CheckedChanged
        For i As Integer = 0 To ug_ayuda.Rows.Count - 1
            ug_ayuda.Rows(i).Cells("Sel").Value = uchk_Todos
        Next
    End Sub

    Private Sub ug_ayuda_DoubleClickRow(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.DoubleClickRowEventArgs) Handles ug_ayuda.DoubleClickRow
        Call Tool_Aceptar_Click(sender, e)
    End Sub

    Private Sub ug_ayuda_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles ug_ayuda.KeyDown
        If e.KeyCode = Keys.Enter Then
            Call Tool_Aceptar_Click(sender, e)
        End If
        If e.KeyCode = Keys.Escape Then
            Call Tool_Salir_Click(sender, e)
        End If

        If e.KeyCode = Keys.Up Then
            If ug_ayuda.ActiveRow.Index = 0 Then
                txt_filtro.Focus()
            End If
        End If
    End Sub
End Class