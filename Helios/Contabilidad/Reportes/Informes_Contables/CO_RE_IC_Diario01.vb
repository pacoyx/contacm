Public Class CO_RE_IC_Diario01

    Private Sub CO_RE_IC_Diario01_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Call CargarCombo_ConMeses(uce_Mes)
        Call Cargar_Subdiarios()
        txt_Ayo.Text = gDat_Fecha_Sis.Year
        txt_Ayo.ReadOnly = True
        uce_Mes.Value = gDat_Fecha_Sis.Month
    End Sub

    Private Sub Cargar_Subdiarios()

        Dim SubdiariosBL As New BL.ContabilidadBL.SG_CO_TB_SUBDIARIO
        Dim SubdiariosBE As New BE.ContabilidadBE.SG_CO_TB_SUBDIARIO With {.SD_IDEMPRESA = New BE.ContabilidadBE.SG_CO_TB_EMPRESA With {.EM_ID = gInt_IdEmpresa}}
        Dim Dt As DataTable = SubdiariosBL.getSubdiarios(SubdiariosBE)

        For i As Integer = 0 To Dt.Rows.Count - 1
            uce_subdiario.Items.Add(Dt.Rows(i)("SD_ID"), Dt.Rows(i)("SD_DESCRIPCION"))
        Next

        SubdiariosBE = Nothing
        SubdiariosBL = Nothing

    End Sub

    Private Sub uop_tipo_ValueChanged(sender As System.Object, e As System.EventArgs) Handles uop_tipo.ValueChanged
        uce_subdiario.Enabled = False
        uce_subdiario.SelectedIndex = -1
        If uop_tipo.Value = "O" Then
            uce_subdiario.Enabled = True
        End If

    End Sub

    Private Sub Tool_salir_Click(sender As System.Object, e As System.EventArgs) Handles Tool_salir.Click
        Me.Close()
    End Sub

    Private Sub Tool_ok_Click(sender As System.Object, e As System.EventArgs) Handles Tool_ok.Click

        Dim Obj_ReporteBL As New BL.ContabilidadBL.SG_CO_Reportes_Registros
        Dim cabeceraBE As New BE.ContabilidadBE.SG_CO_TB_ASIENTO_CAB
        Dim Dt As DataTable = Nothing

        cabeceraBE.AC_ANHO = CInt(txt_Ayo.Text.Trim)
        cabeceraBE.AC_MES = CInt(uce_Mes.Value)
        cabeceraBE.AC_IDSUBDIARIO = New BE.ContabilidadBE.SG_CO_TB_SUBDIARIO With {.SD_ID = uce_subdiario.Value}
        cabeceraBE.AC_IDEMPRESA = New BE.ContabilidadBE.SG_CO_TB_EMPRESA With {.EM_ID = gInt_IdEmpresa}

        Dt = Obj_ReporteBL.get_IC_Diario_01(cabeceraBE)

        Dim f As New CO_RE_IC_Diario_Vista
        f.pdt_data = Dt
        f.ptitulo = "Libro Diario del Mes de " & uce_Mes.Text
        f.Show()


    End Sub
End Class