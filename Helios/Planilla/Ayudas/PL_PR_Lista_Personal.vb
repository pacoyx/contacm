Public Class PL_PR_Lista_Personal

    Public Bol_habilitar_uos As Boolean = True
    Public Bol_Aceptar As Boolean = False
    Public Bol_MultiSeleccion As Boolean = True
    Public Int_tipo_Personal As Integer = 1
    Public lista_empleados As New List(Of BE.PlanillaBE.SG_PL_TB_PERSONAL)


    Public ReadOnly Property Matriz()
        Get
            Return lista_empleados
        End Get
    End Property

    Private Sub Focus_Filtro()
        If ug_Listado_Personal.Rows.Count = 0 Then Exit Sub
        ug_Listado_Personal.Rows(0).Activate()
        ug_Listado_Personal.Rows.FilterRow.Cells("PE_CODIGO").Activate()
        ug_Listado_Personal.PerformAction(Infragistics.Win.UltraWinGrid.UltraGridAction.EnterEditMode)
        SendKeys.Send("{TAB}")
    End Sub

    Private Sub PL_PR_Lista_Personal_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        Call Focus_Filtro()
    End Sub

    Private Sub PL_PR_Lista_Personal_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call Cargar_Personal()

        'uchk_Todos.Checked = False
    End Sub

    Public Sub Cargar_Personal()

        Dim personalBL As New BL.PlanillaBL.SG_PL_TB_PERSONAL
        Dim personalBE As New BE.PlanillaBE.SG_PL_TB_PERSONAL


        uos_tipos.Enabled = Bol_habilitar_uos

        personalBE.PE_AFECTO_QUINTA = IIf(uchk_Cesados.Checked, 1, 0)
        personalBE.PE_ID_TIPO_PER = IIf(Int_tipo_Personal = 0, uos_tipos.Value, Int_tipo_Personal)
        personalBE.PE_ID_EMPRESA = gInt_IdEmpresa

        LimpiaGrid(ug_Listado_Personal, uds_Listado_Personal)
        ug_Listado_Personal.DataSource = personalBL.getPersonal_x_Tipo(personalBE)
        ug_Listado_Personal.DisplayLayout.Bands(0).ColumnFilters.ClearAllFilters()
            
        Try
            If Bol_MultiSeleccion Then
                uchk_Todos.Visible = True
                ug_Listado_Personal.DisplayLayout.Bands(0).Columns("Sel").Hidden = False
            Else
                uchk_Todos.Visible = False
                ug_Listado_Personal.DisplayLayout.Bands(0).Columns("Sel").Hidden = True
            End If
        Catch ex As Exception

        End Try


        personalBL = Nothing
        personalBE = Nothing

    End Sub

    Private Sub Tool_Salir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_Salir.Click
        Bol_Aceptar = False
        Me.Close()
    End Sub

    Private Sub Tool_Aceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_Aceptar.Click

        Dim empleado As BE.PlanillaBE.SG_PL_TB_PERSONAL
        lista_empleados.Clear()
        ug_Listado_Personal.UpdateData()


        If Bol_MultiSeleccion Then
            For i As Integer = 0 To ug_Listado_Personal.Rows.Count - 1
                If ug_Listado_Personal.Rows(i).Cells("SEL").Value Then
                    empleado = New BE.PlanillaBE.SG_PL_TB_PERSONAL()

                    empleado.PE_CODIGO = ug_Listado_Personal.Rows(i).Cells("PE_CODIGO").Value.ToString
                    empleado.PE_APE_PAT = ug_Listado_Personal.Rows(i).Cells("PE_APE_PAT").Value.ToString
                    empleado.PE_APE_MAT = ug_Listado_Personal.Rows(i).Cells("PE_APE_MAT").Value.ToString
                    empleado.PE_NOM_PRI = ug_Listado_Personal.Rows(i).Cells("NOMBRES").Value.ToString
                    empleado.PE_ID = ug_Listado_Personal.Rows(i).Cells("PE_ID").Value

                    lista_empleados.Add(empleado)
                End If
            Next
        Else

            If ug_Listado_Personal.ActiveRow.IsFilterRow Then Exit Sub
            If ug_Listado_Personal.ActiveRow Is Nothing Then Exit Sub

            empleado = New BE.PlanillaBE.SG_PL_TB_PERSONAL()
            empleado.PE_CODIGO = ug_Listado_Personal.ActiveRow.Cells("PE_CODIGO").Value.ToString
            empleado.PE_APE_PAT = ug_Listado_Personal.ActiveRow.Cells("PE_APE_PAT").Value.ToString
            empleado.PE_APE_MAT = ug_Listado_Personal.ActiveRow.Cells("PE_APE_MAT").Value.ToString
            empleado.PE_NOM_PRI = ug_Listado_Personal.ActiveRow.Cells("NOMBRES").Value.ToString
            empleado.PE_ID = ug_Listado_Personal.ActiveRow.Cells("PE_ID").Value
            lista_empleados.Add(empleado)

        End If



        Bol_Aceptar = True
        Me.Close()
    End Sub

    Private Sub uchk_Todos_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles uchk_Todos.CheckedChanged
        For i As Integer = 0 To ug_Listado_Personal.Rows.Count - 1
            ug_Listado_Personal.Rows(i).Cells("SEL").Value = uchk_Todos.Checked
        Next

        ug_Listado_Personal.UpdateData()

    End Sub

    Private Sub uos_tipos_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles uos_tipos.ValueChanged
        Call Cargar_Personal()
        Call Focus_Filtro()
    End Sub

    Private Sub uchk_Cesados_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles uchk_Cesados.CheckedChanged
        Call Cargar_Personal()
    End Sub

    Private Sub ug_Listado_Personal_DoubleClickRow(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.DoubleClickRowEventArgs) Handles ug_Listado_Personal.DoubleClickRow
        If Not Bol_MultiSeleccion Then
            If ug_Listado_Personal.ActiveRow.ListIndex = -1 Then Exit Sub

            Tool_Aceptar_Click(sender, e)
        End If
    End Sub

    Private Sub ug_Listado_Personal_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles ug_Listado_Personal.KeyDown
        If e.KeyCode = Keys.Escape Then
            Call Tool_Salir_Click(sender, e)
        End If

        If e.KeyCode = Keys.Down Then
            If ug_Listado_Personal.ActiveRow.Index = -1 Then
                ug_Listado_Personal.Rows(0).Activate()
            End If
        End If

        If e.KeyCode = Keys.Enter Then
            Call Tool_Aceptar_Click(sender, e)
        End If
        

    End Sub
End Class