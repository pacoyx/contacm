Public Class MA_PR_Visto_Jefe

    Private Sub MA_PR_Visto_Jefe_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

        Call Cargar_Datos()

    End Sub

    Private Sub Cargar_Datos()

        chk_Todos.Checked = False

        Dim marcaBL As New BL.MarcacionesBL.SG_MA_TB_PAPELETA
        Dim dt_info As DataTable = marcaBL.get_Info_Usuario(gInt_IdUsuario_Sis)
        Dim idArea As Integer = 0

        If dt_info.Rows.Count > 0 Then
            txt_id_personal.Text = dt_info(0)("US_IDPERSONAL")
            ug_DataVisto.DataSource = marcaBL.get_Area_X_Jefe(Integer.Parse(txt_id_personal.Text), 0, gInt_IdEmpresa)
        End If

        dt_info = Nothing
        marcaBL = Nothing

        lbl_total_reg.Text = "Nº de Registros : " & ug_DataVisto.Rows.Count

    End Sub

    Private Sub Tool_Salir_Click(sender As System.Object, e As System.EventArgs) Handles Tool_Salir.Click
        Me.Close()
    End Sub

    Private Sub Tool_Grabar_Click(sender As System.Object, e As System.EventArgs) Handles Tool_Grabar.Click

        ug_DataVisto.UpdateData()

        Dim marcaBL As New BL.MarcacionesBL.SG_MA_TB_PAPELETA
        For i As Integer = 0 To ug_DataVisto.Rows.Count - 1
            If ug_DataVisto.Rows(i).Cells("SEL").Value Then
                marcaBL.Update_Visto_JA(ug_DataVisto.Rows(i).Cells("ID_INT").Value, 1, Now.Date)
            Else
                marcaBL.Update_Visto_JA(ug_DataVisto.Rows(i).Cells("ID_INT").Value, 0, Now.Date)
            End If
        Next
        marcaBL = Nothing

        Call Avisar("Listo")
        Call Cargar_Datos()

    End Sub

    Private Sub Tool_Actualizar_Click(sender As System.Object, e As System.EventArgs) Handles Tool_Actualizar.Click
        Call Cargar_Datos()
    End Sub

    Private Sub chk_Todos_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles chk_Todos.CheckedChanged
        For i As Integer = 0 To ug_DataVisto.Rows.Count - 1
            ug_DataVisto.Rows(i).Cells("SEL").Value = chk_Todos.Checked
        Next

        ug_DataVisto.UpdateData()

    End Sub
End Class