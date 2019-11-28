Public Class MA_RelacionPer

    Dim cod_eli As String = ""

    Private Sub MA_RelacionPer_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Call Cargar_Personal()
    End Sub


    Private Sub Cargar_Personal()

        Dim personalBL As New BL.PlanillaBL.SG_PL_TB_PERSONAL

        ug_ListaA.DataSource = personalBL.getPersonal_RelacionPer(gInt_IdEmpresa)
        ug_ListaB.DataSource = personalBL.getPersonal_RelacionPer(gInt_IdEmpresa)

        personalBL = Nothing

    End Sub

    Private Sub ubtn_agregar_Click(sender As System.Object, e As System.EventArgs) Handles ubtn_agregar.Click


        For i As Integer = 0 To ug_Relacion.Rows.Count - 1
            If ug_Relacion.Rows(i).Cells("CODIGO").Value = ug_ListaB.ActiveRow.Cells("PE_CODIGO").Value And ug_Relacion.Rows(i).Cells("IDEMPRESA").Value = ug_ListaB.ActiveRow.Cells("PE_ID_EMPRESA").Value Then
                Avisar("El empleado ya esta asignado.")
                Exit Sub
            End If
        Next


        Dim marcacionesBL As New BL.MarcacionesBL.SG_MA_TB_RELA_PERSONAL
        Dim marcacionesBE As New BE.MarcacionesBE.SG_MA_TB_RELA_PERSONAL

        marcacionesBE.IDPERSONAL_A = ug_ListaA.ActiveRow.Cells("PE_ID").Value
        marcacionesBE.IDPERSONAL_B = ug_ListaB.ActiveRow.Cells("PE_ID").Value
        marcacionesBE.IDEMPRESA = ug_ListaB.ActiveRow.Cells("PE_ID_EMPRESA").Value

        marcacionesBL.Insert(marcacionesBE)

        Call Avisar("Listo!")

        Call Cargar_Relacionados()

        marcacionesBE = Nothing
        marcacionesBL = Nothing

    End Sub

    Private Sub ug_ListaA_AfterRowActivate(sender As System.Object, e As System.EventArgs) Handles ug_ListaA.AfterRowActivate
        Call Cargar_Relacionados()
    End Sub

    Private Sub Cargar_Relacionados()

        Dim marcacionesBL As New BL.MarcacionesBL.SG_MA_TB_RELA_PERSONAL
        Dim marcacionesBE As New BE.MarcacionesBE.SG_MA_TB_RELA_PERSONAL

        marcacionesBE.IDPERSONAL_A = ug_ListaA.ActiveRow.Cells("PE_ID").Value
        marcacionesBE.IDEMPRESA = ug_ListaA.ActiveRow.Cells("PE_ID_EMPRESA").Value

        ug_Relacion.DataSource = marcacionesBL.getRelacion(marcacionesBE)

        marcacionesBE = Nothing
        marcacionesBL = Nothing

        lbl_con_rel.Text = "Cant. de Personal : " & ug_Relacion.Rows.Count.ToString

    End Sub

    Private Sub ToolStripButton1_Click(sender As System.Object, e As System.EventArgs) Handles ToolStripButton1.Click
        Me.Close()
    End Sub

    Private Sub ug_Relacion_AfterRowsDeleted(sender As Object, e As System.EventArgs) Handles ug_Relacion.AfterRowsDeleted
        Dim marcacionesBL As New BL.MarcacionesBL.SG_MA_TB_RELA_PERSONAL
        Dim marcacionesBE As New BE.MarcacionesBE.SG_MA_TB_RELA_PERSONAL

        marcacionesBE.IDPERSONAL_A = ug_ListaA.ActiveRow.Cells("PE_ID").Value
        marcacionesBE.IDPERSONAL_B = cod_eli
        marcacionesBE.IDEMPRESA = gInt_IdEmpresa

        marcacionesBL.Delete(marcacionesBE)

        marcacionesBE = Nothing
        marcacionesBL = Nothing
    End Sub

    Private Sub ug_Relacion_BeforeRowsDeleted(sender As System.Object, e As Infragistics.Win.UltraWinGrid.BeforeRowsDeletedEventArgs) Handles ug_Relacion.BeforeRowsDeleted
        cod_eli = ug_Relacion.ActiveRow.Cells("PE_ID").Value
        e.DisplayPromptMsg = False
        e.Cancel = False
    End Sub
End Class