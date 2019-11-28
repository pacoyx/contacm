Public Class PL_PR_DatosArchivo_Plani_ScotiaBank

    Public pCod_Intit As String = ""
    Public pCod_tipoServi As String = ""
    Public pCod_FechaAbo As String = ""
    Public pCod_Responsable As String = ""
    Public pCod_CuentaCargo As String = ""
    Public pZipear As Boolean = False
    Public pbol_Aceptar As Boolean = False


    Private Sub PL_PR_DatosArchivo_Plani_ScotiaBank_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        uce_tipo_servicio.SelectedIndex = 0

        Dim empresaBE As New BE.ContabilidadBE.SG_CO_TB_EMPRESA With {.EM_ID = gInt_IdEmpresa}
        Dim empresaBL As New BL.ContabilidadBL.SG_CO_TB_EMPRESA
        empresaBL.getEmpresas_2(empresaBE)

        txt_cod_inti.Text = empresaBE.EM_RUC

        empresaBE = Nothing
        empresaBL = Nothing
    End Sub

    Private Sub Tool_Salir_Click(sender As System.Object, e As System.EventArgs) Handles Tool_Salir.Click
        Me.Close()
    End Sub

    Private Sub Tool_Aceptar_Click(sender As System.Object, e As System.EventArgs) Handles Tool_Aceptar.Click

        pCod_Intit = txt_cod_inti.Text
        pCod_tipoServi = uce_tipo_servicio.Value
        pCod_FechaAbo = udte_fec_abono.Value
        pCod_Responsable = txt_responsable.Text
        pCod_CuentaCargo = txt_cta_cargo_insti.Text
        pZipear = uchk_zipear.Checked
        pbol_Aceptar = True
        Me.Close()

    End Sub
End Class