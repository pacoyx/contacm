Public Class PL_MA_Personal_Remu

    Public dbl_sueldo_inicial As Double = 0
    Public dat_fecha_inicial As Date
    Public int_idpersonal As Integer = 0

    Private Sub PL_MA_Personal_Remu_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call Cargar_Sueldos()
    End Sub

    Private Sub Cargar_Sueldos()
        Dim remuBL As New BL.PlanillaBL.SG_PL_TB_PERSONAL_REMUNERACION
        ug_remus.DataSource = remuBL.get_Remuneracion_x_Personal(New BE.PlanillaBE.SG_PL_TB_PERSONAL With {.PE_ID = int_idpersonal})

        If ug_remus.Rows.Count = 0 Then
            Dim remuBE As New BE.PlanillaBE.SG_PL_TB_PERSONAL_REMUNERACION
            remuBE.PR_ITEM = 1
            remuBE.PR_IDPERSONAL = int_idpersonal
            remuBE.PR_FECHA = dat_fecha_inicial
            remuBE.PR_REMUNERACION = dbl_sueldo_inicial
            remuBE.PR_USUARIO = String.Format("{0}-{1}", Environment.UserName, gStr_Usuario_Sis)
            remuBE.PR_TERMINAL = Environment.MachineName
            remuBE.PR_FECREG = Date.Now

            remuBL.Insert(remuBE)

            ug_remus.DataSource = remuBL.get_Remuneracion_x_Personal(New BE.PlanillaBE.SG_PL_TB_PERSONAL With {.PE_ID = int_idpersonal})
        End If

        remuBL = Nothing
    End Sub

    Private Sub ug_remus_InitializeLayout(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.InitializeLayoutEventArgs) Handles ug_remus.InitializeLayout

    End Sub

    Private Sub Tool_Salir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_Salir.Click
        Me.Close()
    End Sub

    Private Sub ug_remus_AfterRowUpdate(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.RowEventArgs) Handles ug_remus.AfterRowUpdate

        If e.Row.Cells("PR_ITEM").Value.ToString = "" Then
            Exit Sub
        End If

        If e.Row.Cells("PR_FECHA").Value.ToString = "" Then
            ug_remus.ActiveCell = ug_remus.Rows(ug_remus.ActiveRow.Index).Cells("PR_FECHA")
            ug_remus.PerformAction(Infragistics.Win.UltraWinGrid.UltraGridAction.EnterEditMode)
            Exit Sub
        End If

        If e.Row.Cells("PR_REMUNERACION").Value.ToString = "" Then
            Exit Sub
        End If


        Dim remuBL As New BL.PlanillaBL.SG_PL_TB_PERSONAL_REMUNERACION
        Dim remuBE As New BE.PlanillaBE.SG_PL_TB_PERSONAL_REMUNERACION

        remuBE.PR_ITEM = e.Row.Cells("PR_ITEM").Value
        remuBE.PR_IDPERSONAL = int_idpersonal
        remuBE.PR_FECHA = e.Row.Cells("PR_FECHA").Value
        remuBE.PR_REMUNERACION = e.Row.Cells("PR_REMUNERACION").Value
        remuBE.PR_USUARIO = String.Format("{0}-{1}", Environment.UserName, gStr_Usuario_Sis)
        remuBE.PR_TERMINAL = Environment.MachineName
        remuBE.PR_FECREG = Date.Now

        remuBL.Delete(remuBE)
        remuBL.Insert(remuBE)

        remuBE = Nothing
        remuBL = Nothing

    End Sub

    Private Sub ug_remus_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles ug_remus.KeyDown
        If e.KeyCode = Keys.Enter Then
            ug_remus.PerformAction(Infragistics.Win.UltraWinGrid.UltraGridAction.NextCellByTab, False, False)
        End If
    End Sub

    Private Sub ug_remus_BeforeRowsDeleted(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.BeforeRowsDeletedEventArgs) Handles ug_remus.BeforeRowsDeleted
        e.DisplayPromptMsg = False

        Dim remuBL As New BL.PlanillaBL.SG_PL_TB_PERSONAL_REMUNERACION
        Dim remuBE As New BE.PlanillaBE.SG_PL_TB_PERSONAL_REMUNERACION

        remuBE.PR_ITEM = ug_remus.ActiveRow.Cells("PR_ITEM").Value
        remuBE.PR_IDPERSONAL = int_idpersonal
        remuBE.PR_FECHA = ug_remus.ActiveRow.Cells("PR_FECHA").Value
        remuBE.PR_REMUNERACION = ug_remus.ActiveRow.Cells("PR_REMUNERACION").Value
        remuBE.PR_USUARIO = String.Format("{0}-{1}", Environment.UserName, gStr_Usuario_Sis)
        remuBE.PR_TERMINAL = Environment.MachineName
        remuBE.PR_FECREG = Date.Now

        remuBL.Delete(remuBE)
    End Sub
End Class