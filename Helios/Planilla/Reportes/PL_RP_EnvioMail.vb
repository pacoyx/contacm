Public Class PL_RP_EnvioMail

    Public int_idpersonal As Integer
    Public str_fecha As String
    'Public dt_data_rep As DataTable
    Public str_Ruta_nom_pdf As String
    Public str_Nom_Archivo_pdf As String

    Private Sub PL_RP_EnvioMail_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

        Call Cargar_Datos_Trabajador()
        Call Cargar_Etiquetas()

    End Sub

    Private Sub Cargar_Etiquetas()
        Dim personalBL As New BL.PlanillaBL.SG_PL_TB_PERSONA_COMUNICACION
        Dim correoPersonal As String = personalBL.get_Correo_Personal(int_idpersonal)
        personalBL = Nothing

        lbl_correo_trabajador.Text = ""
        If correoPersonal <> String.Empty Then
            lbl_correo_trabajador.Text = correoPersonal
            txt_correo_trab_alt.Visible = False
        Else
            lbl_correo_trabajador.Text = "Ingrese correo "
            txt_correo_trab_alt.Visible = True
            txt_correo_trab_alt.Text = ""
        End If


        lbl_datos_adj.Text = str_Nom_Archivo_pdf
        txt_mensaje.Text = "Informacion acerca de las vacaciones a la fecha " & str_fecha & "." & Chr(13) & "Se adjunta archivo PDF con el reporte de vacaciones"

        Dim varBL As New BL.PlanillaBL.SG_PL_TB_PARAMETROS
        Dim varBE As New BE.PlanillaBE.SG_PL_TB_PARAMETROS
        varBE.AD_TIPO = "CORRE"
        varBE.AD_NOMBRE = "R_VACA"
        varBE.AD_IDEMPRESA = gInt_IdEmpresa
        lbl_correo_de.Text = varBL.get_Valor(varBE)

    End Sub

    Private Sub Tool_Salir_Click(sender As System.Object, e As System.EventArgs) Handles Tool_Salir.Click
        Me.Close()
    End Sub

    Private Sub Tool_Enviar_Click(sender As System.Object, e As System.EventArgs) Handles Tool_Enviar.Click

        If txt_correo_trab_alt.Visible Then
            If txt_correo_trab_alt.Text.Trim.Length = 0 Then
                Avisar("Ingrese el correo del trabajador")
                Exit Sub
            End If
        End If

        Me.Cursor = Cursors.WaitCursor

        Dim crystalBL As New LR.ClsFunciones
        Dim x As New BL.ContabilidadBL.MyCorreo

        x.Enviar_Correo_Rep_Vaca_DatosAdj(lbl_correo_de.Text, IIf(txt_correo_trab_alt.Visible, txt_correo_trab_alt.Text, lbl_correo_trabajador.Text), _
                                          txt_mensaje.Text.Trim, str_Ruta_nom_pdf)

        Avisar("Listo!")
        x = Nothing
        Me.Cursor = Cursors.Default
        Me.Close()

    End Sub

    Private Sub Cargar_Datos_Trabajador()

        Dim personalBE As New BE.PlanillaBE.SG_PL_TB_PERSONAL With {.PE_ID = int_idpersonal}
        Dim personalBL As New BL.PlanillaBL.SG_PL_TB_PERSONAL
        personalBE.PE_ID_EMPRESA = gInt_IdEmpresa
        personalBL.getPersonal_x_Id(personalBE)

        lbl_ape_pat.Text = personalBE.PE_APE_PAT
        lbl_ape_mat.Text = personalBE.PE_APE_MAT
        lbl_nom1.Text = personalBE.PE_NOM_PRI & " " & personalBE.PE_NOM_SEG


        'If personalBE.PE_FOTO Is Nothing Then
        '    upb_img.Image = My.Resources.Desconocido
        'Else
        '    upb_img.Image = Bytes2Image(personalBE.PE_FOTO)
        'End If

        Dim cargoBL As New BL.PlanillaBL.SG_PL_TB_CARGO
        Dim cargoBE As New BE.PlanillaBE.SG_PL_TB_CARGO With {.EC_ID = personalBE.PE_ID_CARGO, .EC_IDEMPRESA = New BE.ContabilidadBE.SG_CO_TB_EMPRESA With {.EM_ID = gInt_IdEmpresa}}
        cargoBL.getCargo_x_Id(cargoBE)
        lbl_cargo.Text = cargoBE.EC_CARGO




        cargoBL = Nothing
        cargoBE = Nothing

        personalBE = Nothing
        personalBL = Nothing

    End Sub


    Private Sub lbl_datos_adj_LinkClicked(sender As System.Object, e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles lbl_datos_adj.LinkClicked
        Try
            Process.Start(str_Ruta_nom_pdf)
        Catch ex As Exception

        End Try
    End Sub
End Class