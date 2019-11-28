Public Class MA_RE_ConsultaPapeleta

    Private Sub MA_RE_ConsultaPapeleta_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Call Cargar_Datos_Usuario()
    End Sub

    Private Sub Cargar_Datos_Usuario()

        Me.Cursor = Cursors.WaitCursor

        Dim marcaBL As New BL.MarcacionesBL.SG_MA_TB_PAPELETA
        Dim dt_info As DataTable = marcaBL.get_Info_Usuario(gInt_IdUsuario_Sis)

        If dt_info.Rows.Count > 0 Then
            txt_nom_emple.Text = dt_info(0)("PE_CODIGO") & " - " & dt_info(0)("NOMBRES")
            txt_id_personal.Text = dt_info(0)("US_IDPERSONAL")
        End If

        ug_Lis_Pap.DataSource = marcaBL.get_Rep_02(txt_id_personal.Text)

        dt_info = Nothing
        marcaBL = Nothing

        Me.Cursor = Cursors.Default

    End Sub

    Private Sub Tool_Salir_Click(sender As System.Object, e As System.EventArgs) Handles Tool_Salir.Click
        Me.Close()
    End Sub

    Private Sub Tool_Imp_Papeleta_Click(sender As System.Object, e As System.EventArgs) Handles Tool_Imp_Papeleta.Click

        If ug_Lis_Pap.Rows.Count = 0 Then Exit Sub
        If ug_Lis_Pap.ActiveRow Is Nothing Then Exit Sub

        Me.Cursor = Cursors.WaitCursor

        Dim ObjReporte As New LR.ClsReporte
        Dim marcaBL As New BL.MarcacionesBL.SG_MA_TB_PAPELETA
        Dim dt As DataTable = marcaBL.get_Rep_01(Integer.Parse(ug_Lis_Pap.ActiveRow.Cells("PA_ID").Value))
        Dim empresaBL As New BL.ContabilidadBL.SG_CO_TB_EMPRESA
        Dim empresaBE As New BE.ContabilidadBE.SG_CO_TB_EMPRESA With {.EM_ID = gInt_IdEmpresa}
        empresaBL.getEmpresas_2(empresaBE)

        ObjReporte.Muestra_Reporte(String.Format("{0}\{1}", gStr_RutaRep, "MA_01.rpt"), dt, "", "pEmp;" & empresaBE.EM_NOMBRE, "pRuc;" & empresaBE.EM_RUC)

        ObjReporte = Nothing
        marcaBL = Nothing
        empresaBE = Nothing
        empresaBL = Nothing

        Me.Cursor = Cursors.Default
    End Sub

    Private Sub Tool_Imp_Resumen_Click(sender As System.Object, e As System.EventArgs) Handles Tool_Imp_Resumen.Click
        If ug_Lis_Pap.Rows.Count = 0 Then Exit Sub
        If ug_Lis_Pap.ActiveRow Is Nothing Then Exit Sub

        Me.Cursor = Cursors.WaitCursor

        Dim ObjReporte As New LR.ClsReporte
        Dim marcaBL As New BL.MarcacionesBL.SG_MA_TB_PAPELETA
        Dim dt As DataTable = marcaBL.get_Rep_02(Integer.Parse(txt_id_personal.Text))
        Dim empresaBL As New BL.ContabilidadBL.SG_CO_TB_EMPRESA
        Dim empresaBE As New BE.ContabilidadBE.SG_CO_TB_EMPRESA With {.EM_ID = gInt_IdEmpresa}
        empresaBL.getEmpresas_2(empresaBE)

        ObjReporte.Muestra_Reporte(String.Format("{0}\{1}", gStr_RutaRep, "MA_02.rpt"), dt, "", "pEmp;" & empresaBE.EM_NOMBRE)

        ObjReporte = Nothing
        marcaBL = Nothing
        empresaBE = Nothing
        empresaBL = Nothing

        Me.Cursor = Cursors.Default

    End Sub

    Private Sub Tool_Actualizar_Click(sender As System.Object, e As System.EventArgs) Handles Tool_Actualizar.Click

    End Sub
End Class