Public Class FA_RE_Tarifario
    Public IGVTasa As Double
    Private Sub pKeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Me.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Return) Then
            SendKeys.Send("{TAB}")
            e.Handled = True
        End If
    End Sub
    Private Sub Cargar_Tasas_Impuestos()

        Dim impuestosBL As New BL.ContabilidadBL.SG_CO_TB_IMPUESTO
        Dim impuestoBE As New BE.ContabilidadBE.SG_CO_TB_IMPUESTO

        impuestoBE.IM_IDEMPRESA = New BE.ContabilidadBE.SG_CO_TB_EMPRESA With {.EM_ID = gInt_IdEmpresa}
        impuestoBE.IM_IDTIPOIMPUESTO = New BE.ContabilidadBE.SG_CO_TB_TIPO_IMPUESTO With {.TI_CODIGO = "01"}
        impuestoBE.IM_PERIODO = Date.Now.Year
        impuestoBE.IM_MES = Date.Now.Month

        impuestosBL.getImpuestos_x_Tipo(impuestoBE)
        IGVTasa = impuestoBE.IM_TASA

        impuestosBL = Nothing
        impuestoBE = Nothing

    End Sub
    Private Sub FA_RE_Tarifario_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim asegBL As New BL.FacturacionBL.SG_FA_TB_CIA_ASEG
        ucm_SeguroEps.DataSource = asegBL.getAseguradoras(gInt_IdEmpresa)
        ucm_SeguroEps.DisplayMember = "CA_DESCRIPCION"
        ucm_SeguroEps.ValueMember = "CA_ID"
        asegBL = Nothing
        ucm_SeguroEps.Enabled = False
        Cargar_Tasas_Impuestos()
        Me.KeyPreview = True
    End Sub

    Private Sub ub_Detallar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ub_Detallar.Click

        Dim articuloBL As New BL.FacturacionBL.SG_FA_TB_ARTICULO

        ug_data.DataSource = articuloBL.get_Articulos_Ayuda02(gInt_IdEmpresa, ucm_SeguroEps.Value, uos_opcion.Value, IGVTasa, "")
        articuloBL = Nothing
    End Sub

    Private Sub uos_opcion_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles uos_opcion.ValueChanged
        If uos_opcion.Value = 1 Then
            ucm_SeguroEps.Enabled = True
        Else
            ucm_SeguroEps.Enabled = False
        End If
    End Sub

End Class