Public Class PL_MA_PlantillaCodigo

    Private Sub PL_MA_PlantillaCodigo_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Call Cargar_PlantillaCodigo()
        Call Cargar_Relacion()
    End Sub

    Private Sub Tool_Salir_Click(sender As System.Object, e As System.EventArgs) Handles Tool_Salir.Click
        Me.Close()
    End Sub

    Private Sub Cargar_PlantillaCodigo()
        Dim plantillaBL As New BL.PlanillaBL.SG_PL_TB_PLANTILLA_CODIGO
        ug_Plantilla.DataSource = plantillaBL.get_Plantilla()
        plantillaBL = Nothing
    End Sub

    Private Sub Cargar_Relacion()
        Dim relacionBL As New BL.PlanillaBL.SG_PL_TB_PLANCOD_EMPRESA
        ug_Relacion.DataSource = relacionBL.get_Relacion_Plantilla_Empresa(New BE.ContabilidadBE.SG_CO_TB_EMPRESA With {.EM_ID = gInt_IdEmpresa})
        relacionBL = Nothing
    End Sub

    Private Sub ug_Plantilla_BeforeRowsDeleted(sender As System.Object, e As Infragistics.Win.UltraWinGrid.BeforeRowsDeletedEventArgs) Handles ug_Plantilla.BeforeRowsDeleted
        e.Cancel = True
        e.DisplayPromptMsg = False
    End Sub

    Private Sub ug_Relacion_BeforeRowsDeleted(sender As System.Object, e As Infragistics.Win.UltraWinGrid.BeforeRowsDeletedEventArgs) Handles ug_Relacion.BeforeRowsDeleted
        e.DisplayPromptMsg = False
    End Sub

    Private Sub ug_Plantilla_DoubleClickRow(sender As System.Object, e As Infragistics.Win.UltraWinGrid.DoubleClickRowEventArgs) Handles ug_Plantilla.DoubleClickRow

        For i As Integer = 0 To ug_Relacion.Rows.Count - 1
            If ug_Relacion.Rows(i).Cells("PE_IDPLANTILLA").Value = ug_Plantilla.ActiveRow.Cells("PC_ID").Value Then
                Avisar("El codigo ya esta en la lista de Relación")
                Exit Sub
            End If
        Next


        ug_Relacion.DisplayLayout.Bands(0).AddNew()
        ug_Relacion.Rows(ug_Relacion.Rows.Count - 1).Cells("PE_IDPLANTILLA").Value = ug_Plantilla.ActiveRow.Cells("PC_ID").Value
        ug_Relacion.Rows(ug_Relacion.Rows.Count - 1).Cells("PC_DES_REGISTRO").Value = ug_Plantilla.ActiveRow.Cells("PC_DES_REGISTRO").Value
        ug_Relacion.Rows(ug_Relacion.Rows.Count - 1).Cells("PE_IDCONCEPTO").Value = ""
        ug_Relacion.UpdateData()

    End Sub

    Private Sub Tool_Grabar_Click(sender As System.Object, e As System.EventArgs) Handles Tool_Grabar.Click

        Dim relacionBL As New BL.PlanillaBL.SG_PL_TB_PLANCOD_EMPRESA
        Dim ls_relacion As New List(Of BE.PlanillaBE.SG_PL_TB_PLANCOD_EMPRESA)
        Dim relacion As BE.PlanillaBE.SG_PL_TB_PLANCOD_EMPRESA

        ug_Relacion.UpdateData()
        For i As Integer = 0 To ug_Relacion.Rows.Count - 1
            relacion = New BE.PlanillaBE.SG_PL_TB_PLANCOD_EMPRESA
            relacion.PE_IDPLANTILLA = ug_Relacion.Rows(i).Cells("PE_IDPLANTILLA").Value
            relacion.PE_IDCONCEPTO = ug_Relacion.Rows(i).Cells("PE_IDCONCEPTO").Value
            relacion.PE_IDEMPRESA = gInt_IdEmpresa

            ls_relacion.Add(relacion)
        Next

        relacionBL.Insert(ls_relacion)
        relacionBL = Nothing

        Avisar("Listo!")

    End Sub
End Class
