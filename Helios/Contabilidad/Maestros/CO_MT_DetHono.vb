
Public Class CO_MT_DetHono

    Public Int_IdAnexo As Integer
    Public str_razonSocial As String

    Private Sub CO_MT_DetHono_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

        Call Cargar_AFP()

        txt_razon.Text = Int_IdAnexo.ToString + " - : - " + str_razonSocial

        txt_ape_pat.Text = String.Empty
        txt_ape_mat.Text = String.Empty
        txt_nom1.Text = String.Empty
        txt_nom2.Text = String.Empty
        txt_dir_fiscal.Text = String.Empty
        txt_telfe.Text = String.Empty
        txt_mobil.Text = String.Empty
        txt_email.Text = String.Empty
        txt_profesion.Text = String.Empty
        txt_dni.Text = String.Empty
        uce_Lis_Afp.SelectedIndex = -1
        txt_cuspp.Text = ""

        Dim honorraioBL As New BL.ContabilidadBL.SG_CO_TB_HONORARIO_PROFE
        Dim dt_tmp As DataTable = honorraioBL.getHonorarios(Int_IdAnexo)

        If dt_tmp.Rows.Count > 0 Then
            With dt_tmp.Rows(0)

                txt_ape_pat.Text = .Item("HP_APE_PAT")
                txt_ape_mat.Text = .Item("HP_APE_MAT")
                txt_nom1.Text = .Item("HP_PRI_NOM")
                txt_nom2.Text = .Item("HP_SEC_NOM")
                txt_dir_fiscal.Text = .Item("HP_DIR")
                txt_telfe.Text = .Item("HP_TELF_FIJO")
                txt_mobil.Text = .Item("HP_TELF_MOVIL")
                txt_email.Text = .Item("HP_EMAIL")
                txt_profesion.Text = .Item("HP_PROFESION")
                txt_dni.Text = .Item("HP_DNI")
                txt_cuspp.Text = .Item("HP_CUSPP")
                uce_Lis_Afp.Value = .Item("HP_IDAFP")
                uos_tipo_comi.Value = .Item("HP_TIPO_COMI").ToString
            End With

        End If

        honorraioBL = Nothing
        dt_tmp.Dispose()

    End Sub

    Private Sub Cargar_AFP()
        Dim afpBL As New BL.PlanillaBL.SG_PL_TB_AFP
        uce_Lis_Afp.DataSource = afpBL.getAfp(New BE.ContabilidadBE.SG_CO_TB_EMPRESA With {.EM_ID = gInt_IdEmpresa})
        uce_Lis_Afp.ValueMember = "AF_ID"
        uce_Lis_Afp.DisplayMember = "AF_NOMBRE"
        afpBL = Nothing
    End Sub

    Private Sub Tool_Salir_Click(sender As System.Object, e As System.EventArgs) Handles Tool_Salir.Click
        Me.Close()
    End Sub

    Private Sub Tool_Eliminar_Click(sender As System.Object, e As System.EventArgs) Handles Tool_Eliminar.Click

    End Sub

    Private Sub Tool_Grabar_Click(sender As System.Object, e As System.EventArgs) Handles Tool_Grabar.Click

        Dim honorariosBE As New BE.ContabilidadBE.SG_CO_TB_HONORARIO_PROFE
        Dim honorariosBL As New BL.ContabilidadBL.SG_CO_TB_HONORARIO_PROFE

        With honorariosBE
            .HP_IDHONORARIO = New BE.ContabilidadBE.SG_CO_TB_ANEXO With {.AN_IDANEXO = Int_IdAnexo}
            .HP_PRI_NOM = txt_nom1.Text
            .HP_SEC_NOM = txt_nom2.Text
            .HP_APE_PAT = txt_ape_pat.Text
            .HP_APE_MAT = txt_ape_mat.Text
            .HP_DIR = txt_dir_fiscal.Text
            .HP_IDPAIS = New BE.ContabilidadBE.SG_CO_TB_PAIS With {.PA_CODIGO = "01"}
            .HP_CIUDAD = String.Empty
            .HP_TELF_FIJO = txt_telfe.Text
            .HP_TELF_MOVIL = txt_mobil.Text
            .HP_EMAIL = txt_email.Text
            .HP_PROFESION = txt_profesion.Text
            .HP_DNI = txt_dni.Text
            .HP_ES_AFECTO_RENTA = 0
            .HP_USUARIO = String.Format("{0}-{1}", Environment.UserName, gStr_Usuario_Sis)
            .HP_TERMINAL = Environment.MachineName
            .HP_FECREG = Now.Date
            .HP_CUSPP = txt_cuspp.Text.Trim
            .HP_TIPO_COMI = uos_tipo_comi.Value

            If uce_Lis_Afp.SelectedIndex <> -1 Then
                .HP_IDAFP = uce_Lis_Afp.Value
            End If

        End With

        honorariosBL.Insert(honorariosBE)

        honorariosBL = Nothing
        honorariosBE = Nothing


        Avisar("Listo!")

        Me.Close()

    End Sub

    Private Sub txt_ape_pat_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles txt_ape_pat.KeyDown
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send(vbTab)
        End If
    End Sub

    Private Sub txt_ape_mat_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles txt_ape_mat.KeyDown
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send(vbTab)
        End If
    End Sub

    Private Sub txt_nom1_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles txt_nom1.KeyDown
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send(vbTab)
        End If
    End Sub

    Private Sub txt_nom2_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles txt_nom2.KeyDown
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send(vbTab)
        End If
    End Sub

    Private Sub txt_dni_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles txt_dni.KeyDown
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send(vbTab)
        End If
    End Sub

    Private Sub txt_profesion_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles txt_profesion.KeyDown
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send(vbTab)
        End If
    End Sub

    Private Sub txt_dir_fiscal_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles txt_dir_fiscal.KeyDown
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send(vbTab)
        End If
    End Sub

    Private Sub ume_tel1_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs)
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send(vbTab)
        End If
    End Sub

    Private Sub ume_mobil1_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs)
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send(vbTab)
        End If
    End Sub

    Private Sub ume_fax1_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs)
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send(vbTab)
        End If
    End Sub

    Private Sub txt_email_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles txt_email.KeyDown
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send(vbTab)
        End If
    End Sub

    Private Sub txt_telfe_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles txt_telfe.KeyDown
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send(vbTab)
        End If
    End Sub

    Private Sub txt_mobil_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles txt_mobil.KeyDown
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send(vbTab)
        End If
    End Sub

    Private Sub txt_fax_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs)
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send(vbTab)
        End If
    End Sub

    Private Sub txt_cuspp_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles txt_cuspp.KeyDown

        If e.KeyCode = Keys.Enter Then
            SendKeys.Send(vbTab)
        End If

    End Sub

    Private Sub UltraLabel8_Click(sender As System.Object, e As System.EventArgs) Handles UltraLabel8.Click, UltraLabel9.Click

    End Sub
End Class