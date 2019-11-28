Public Class PL_RP_EnvioMail_xCargos
    Public str_fecha As String
    Public dt_data_rep As DataTable
    Public str_Ruta_nom_pdf As String
    Public str_Nom_Archivo_pdf As String
    Public int_idcargo As Integer


    Private Sub PL_RP_EnvioMail_xCargos_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        txt_mensaje.Text = "Informacion acerca de las vacaciones a la fecha " & str_fecha & "." & Chr(13) & "Se adjunta archivo PDF con el reporte de vacaciones"
        lbl_datos_adj.Text = str_Nom_Archivo_pdf

        Dim varBL As New BL.PlanillaBL.SG_PL_TB_PARAMETROS
        Dim varBE As New BE.PlanillaBE.SG_PL_TB_PARAMETROS
        varBE.AD_TIPO = "CORRE"
        varBE.AD_NOMBRE = "R_VACA"
        varBE.AD_IDEMPRESA = gInt_IdEmpresa
        lbl_correo_de.Text = varBL.get_Valor(varBE)

        varBL = Nothing
        varBE = Nothing

        Call Cargar_Lista_Trabaja_x_Cargo()

    End Sub

    Private Sub Cargar_Lista_Trabaja_x_Cargo()

        Dim dt_lista As DataTable = Nothing
        Dim personalBL As New BL.PlanillaBL.SG_PL_TB_PERSONAL
        dt_lista = personalBL.get_Personal_x_Cargo(int_idcargo, gInt_IdEmpresa)

        Call LimpiaGrid(ug_lista, uds_lista)
        For i As Integer = 0 To dt_lista.Rows.Count - 1
            ug_lista.DisplayLayout.Bands(0).AddNew()
            ug_lista.Rows(i).Cells("PE_ID").Value = dt_lista.Rows(i)("PE_ID")
            ug_lista.Rows(i).Cells("PE_CODIGO").Value = dt_lista.Rows(i)("PE_CODIGO")
            ug_lista.Rows(i).Cells("NOMBRES").Value = dt_lista.Rows(i)("NOMBRES")
            ug_lista.Rows(i).Cells("CORREO").Value = dt_lista.Rows(i)("CORREO")
            ug_lista.Rows(i).Cells("PE_FOTO").Value = Bytes2Image(dt_lista.Rows(i)("PE_FOTO"))
            ug_lista.UpdateData()
        Next


    End Sub

    Private Sub uchk_cadauno_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles uchk_cadauno.CheckedChanged
        txt_para.Visible = Not uchk_cadauno.Checked
        ug_lista.DisplayLayout.Bands(0).Columns("CORREO").Hidden = Not uchk_cadauno.Checked
        ug_lista.DisplayLayout.Bands(0).Columns("ARCHIVO").Hidden = Not uchk_cadauno.Checked
        lbl_eti_datosadj.Visible = Not uchk_cadauno.Checked
        lbl_datos_adj.Visible = Not uchk_cadauno.Checked
        'ubtn_verDatosAdj.Visible = Not uchk_cadauno.Checked

        'ug_lista.DisplayLayout.Bands(0).Columns("RUTA").Hidden = Not uchk_cadauno.Checked
        If uchk_cadauno.Checked Then
            Call Generar_Pdfs_x_Trabajador()
        End If
    End Sub

    Private Sub Tool_Salir_Click(sender As System.Object, e As System.EventArgs) Handles Tool_Salir.Click
        Me.Close()
    End Sub

    Private Sub Tool_Enviar_Click(sender As System.Object, e As System.EventArgs) Handles Tool_Enviar.Click
        If Not uchk_cadauno.Checked Then
            If txt_para.Text.Trim.Length = 0 Then
                Avisar("Ingrese correo para enviar.")
            End If
        End If


        Me.Cursor = Cursors.WaitCursor

        Dim crystalBL As New LR.ClsFunciones
        Dim x As New BL.ContabilidadBL.MyCorreo

        If uchk_cadauno.Checked Then 'individual,sacamos los datos de la grilla

            For i As Integer = 0 To ug_lista.Rows.Count - 1
                If ug_lista.Rows(i).Cells("CORREO").Value.ToString <> String.Empty And ug_lista.Rows(i).Cells("RUTA").Value.ToString <> String.Empty Then
                    x.Enviar_Correo_Rep_Vaca_DatosAdj(lbl_correo_de.Text, ug_lista.Rows(i).Cells("CORREO").Value, _
                                              txt_mensaje.Text.Trim, ug_lista.Rows(i).Cells("RUTA").Value)
                End If
            Next
        Else
            x.Enviar_Correo_Rep_Vaca_DatosAdj(lbl_correo_de.Text, txt_para.Text.Trim, txt_mensaje.Text.Trim, str_Ruta_nom_pdf)
        End If

        Avisar("Listo!")
        x = Nothing
        Me.Cursor = Cursors.Default
        Me.Close()


    End Sub

    Private Sub Generar_Pdfs_x_Trabajador()

        Me.Cursor = Cursors.WaitCursor
        Dim crystalBL As New LR.ClsFunciones
        Dim reportesBL As New BL.PlanillaBL.SG_PL_Reportes
        Dim dt_tmp As DataTable = Nothing
        Dim str_Ruta_archivo_pdf As String = String.Empty
        Dim str_nom_pdf As String = String.Empty

        For i As Integer = 0 To ug_lista.Rows.Count - 1

            dt_tmp = reportesBL.get_Movimi_Vacaciones(CDate(str_fecha), Environment.MachineName, _
                                                      ug_lista.Rows(i).Cells("PE_ID").Value, 1, gInt_IdEmpresa)
            crystalBL.CrearPDF(dt_tmp, gStr_RutaRep, str_Ruta_archivo_pdf, str_nom_pdf)

            ug_lista.Rows(i).Cells("Ruta").Value = str_Ruta_archivo_pdf
            ug_lista.Rows(i).Cells("Archivo").Value = str_nom_pdf
        Next

        ug_lista.UpdateData()


        dt_tmp = Nothing
        crystalBL = Nothing
        reportesBL = Nothing

        Me.Cursor = Cursors.Default
    End Sub

    Private Sub ug_lista_DoubleClick(sender As System.Object, e As System.EventArgs) Handles ug_lista.DoubleClick
        Try
            Process.Start(ug_lista.ActiveRow.Cells("ruta").Value.ToString)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As System.Object, e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles lbl_datos_adj.LinkClicked
        Try
            Process.Start(str_Ruta_nom_pdf)
        Catch ex As Exception

        End Try
    End Sub

End Class