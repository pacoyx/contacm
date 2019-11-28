Public Class PL_RP_Dscto_Quinta

    Dim comenzar As Boolean = False

    Private Sub PL_RP_Dscto_Quinta_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        une_ayo.Value = gDat_Fecha_Sis.Year
        Call Cargar_TipoPersonal()
        Call Formatear_Grilla_Selector(ug_quinta)
        comenzar = Not comenzar
        txt_cod_personal.ButtonsRight(0).Appearance.Image = My.Resources._104
    End Sub

    Private Sub Cargar_TipoPersonal()
        Dim tipoPersonalBL As New BL.PlanillaBL.SG_PL_TB_TIPO_PERSONAL
        uce_TipoPersonal.DataSource = tipoPersonalBL.getTipos()
        uce_TipoPersonal.ValueMember = "TP_ID"
        uce_TipoPersonal.DisplayMember = "TP_DESCRIPCION"
        tipoPersonalBL = Nothing
    End Sub

    Private Sub Mostrar_Ayuda_Empleado()

        PL_PR_Lista_Personal.Int_tipo_Personal = 0
        PL_PR_Lista_Personal.Bol_habilitar_uos = True
        PL_PR_Lista_Personal.Bol_MultiSeleccion = False
        PL_PR_Lista_Personal.ShowDialog()
        If PL_PR_Lista_Personal.Bol_Aceptar Then
            Dim matriz As New List(Of BE.PlanillaBE.SG_PL_TB_PERSONAL)
            matriz = PL_PR_Lista_Personal.lista_empleados
            If matriz.Count > 0 Then

                For Each empleado As BE.PlanillaBE.SG_PL_TB_PERSONAL In matriz
                    txt_cod_personal.Text = empleado.PE_CODIGO
                    txt_nombres.Text = empleado.PE_APE_PAT & " " & empleado.PE_APE_MAT & " " & empleado.PE_NOM_PRI
                    txt_id_personal.Text = empleado.PE_ID
                Next
            End If
            matriz = Nothing

        End If
    End Sub

    Private Sub Cargar_Data_Quinta()
        If Not comenzar Then Exit Sub


        If uce_TipoPersonal.SelectedIndex = -1 Then
            Avisar("Seleccione un tipo de Personal")
            uce_TipoPersonal.Focus()
            Exit Sub
        End If


        If Not uchk_todos.Checked Then
            If txt_id_personal.Text.Trim.Length = 0 Then
                Avisar("Seleccione un trabajador")
                txt_cod_personal.Focus()
                Exit Sub
            End If
        End If

        Me.Cursor = Cursors.WaitCursor

        Dim reportesBL As New BL.PlanillaBL.SG_PL_Reportes
        ug_quinta.DataSource = reportesBL.get_Dscto_Quinta_Acumulado(une_ayo.Value, gDat_Fecha_Sis.Month, uce_TipoPersonal.Value, IIf(uchk_todos.Checked, 0, txt_id_personal.Text.Trim), gInt_IdEmpresa)
        reportesBL = Nothing

        Me.Cursor = Cursors.Default

    End Sub

    Private Sub Tool_Salir_Click(sender As System.Object, e As System.EventArgs) Handles Tool_Salir.Click
        Me.Close()
    End Sub

    Private Sub Tool_imprimir_Click(sender As System.Object, e As System.EventArgs) Handles Tool_imprimir.Click

        If uce_TipoPersonal.SelectedIndex = -1 Then
            Avisar("Seleccione un tipo de Personal")
            uce_TipoPersonal.Focus()
            Exit Sub
        End If

        Me.Cursor = Cursors.WaitCursor

        Dim dt_reporte As DataTable = CType(ug_quinta.DataSource, DataTable)

        Using crystalBL As New LR.ClsReporte
            crystalBL.Muestra_Reporte(gStr_RutaRep & "\SG_PL_15.rpt", dt_reporte, "", "pEmp;" & gStr_NomEmpresa, "pPersonal;" & uce_TipoPersonal.Text)
        End Using
        Me.Cursor = Cursors.Default

    End Sub

    Private Sub uce_TipoPersonal_ValueChanged(sender As System.Object, e As System.EventArgs) Handles uce_TipoPersonal.ValueChanged
        Call Cargar_Data_Quinta()
    End Sub

    Private Sub une_ayo_ValueChanged(sender As System.Object, e As System.EventArgs) Handles une_ayo.ValueChanged
        Call Cargar_Data_Quinta()
    End Sub

    Private Sub ug_quinta_InitializeGroupByRow(sender As System.Object, e As Infragistics.Win.UltraWinGrid.InitializeGroupByRowEventArgs) Handles ug_quinta.InitializeGroupByRow
        e.Row.Expanded = True
    End Sub

    Private Sub txt_cod_personal_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles txt_cod_personal.KeyDown
        If e.KeyCode = Keys.F2 Then Mostrar_Ayuda_Empleado()
    End Sub

    Private Sub txt_cod_personal_EditorButtonClick(sender As System.Object, e As Infragistics.Win.UltraWinEditors.EditorButtonEventArgs) Handles txt_cod_personal.EditorButtonClick
        Call Mostrar_Ayuda_Empleado()
    End Sub

    Private Sub uchk_todos_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles uchk_todos.CheckedChanged
        ugb_trabajador.Enabled = Not uchk_todos.Checked
    End Sub

    Private Sub ToolStripButton1_Click(sender As System.Object, e As System.EventArgs) Handles ToolStripButton1.Click
        Call Cargar_Data_Quinta()
    End Sub
End Class