Public Class PL_PR_Folio_Comprobante

    Public str_idfolio As String
    Public str_desfolio As String
    Public int_idpersonal As Integer
    Public str_cod_per As String
    Public str_nom_per As String
    Public int_ayo As Integer
    Public int_mes As Integer
    Public bol_aceptar As Boolean


    Private Sub PL_PR_Folio_Comprobante_Activated(sender As Object, e As System.EventArgs) Handles Me.Activated
        txt_SerieDoc.Focus()
    End Sub


    Private Sub PL_PR_Folio_Comprobante_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Call Cargar_Documentos()
        txt_cod_Doc_Cab.Text = "3"
        uce_TipoDoc.Value = 3
        Call Cargar_Info_Trabajador()
        ubtn_Aceptar.Appearance.Image = My.Resources._16__Ok_
        ubtn_Cancelar.Appearance.Image = My.Resources._16__Cancel_
        txt_Folio.Text = str_desfolio
    End Sub

    Private Sub Cargar_Documentos()

        Dim DocumentoBL As New BL.ContabilidadBL.SG_CO_TB_DOCUMENTO
        Dim DocumentoBE As New BE.ContabilidadBE.SG_CO_TB_DOCUMENTO
        DocumentoBE.DO_IDEMPRESA = New BE.ContabilidadBE.SG_CO_TB_EMPRESA With {.EM_ID = gInt_IdEmpresa}

        uce_TipoDoc.DataSource = DocumentoBL.getDocumentos(DocumentoBE)
        uce_TipoDoc.DisplayMember = "DO_DESCRIPCION"
        uce_TipoDoc.ValueMember = "DO_CODIGO"

        DocumentoBE = Nothing
        DocumentoBL = Nothing


    End Sub

    Private Sub Cargar_Info_Trabajador()
        Dim dt_tmp As DataTable = Nothing
        Dim comprobanteBL As New BL.PlanillaBL.SG_PL_TB_FOLIO_DOC_COMPRO
        Dim comprobanteBE As New BE.PlanillaBE.SG_PL_TB_FOLIO_DOC_COMPRO
        comprobanteBE.FC_IDFOLIO = str_idfolio
        comprobanteBE.FC_IDPERSONAL = int_idpersonal
        comprobanteBE.FC_ANHO = int_ayo
        comprobanteBE.FC_MES = int_mes
        comprobanteBE.FC_IDEMPRESA = gInt_IdEmpresa
        dt_tmp = comprobanteBL.get_Info_Trabajador(comprobanteBE)

        If dt_tmp.Rows.Count > 0 Then
            txt_cod_per.Text = str_cod_per
            txt_trabajador.Text = str_nom_per
            txt_idtrabajador.Text = int_idpersonal

            txt_cod_Doc_Cab.Text = dt_tmp(0)("FC_TDOC")
            uce_TipoDoc.Value = dt_tmp(0)("FC_TDOC")
            txt_SerieDoc.Text = dt_tmp(0)("FC_SDOC")
            txt_NumDoc.Text = dt_tmp(0)("FC_NDOC")
            ume_Importe.Value = dt_tmp(0)("FC_IMPORTE")
            ume_base.Value = dt_tmp(0)("FC_BASE")
            ume_igv.Value = dt_tmp(0)("FC_IGV")

        Else

            txt_cod_per.Text = str_cod_per
            txt_trabajador.Text = str_nom_per
            txt_idtrabajador.Text = int_idpersonal

            txt_cod_Doc_Cab.Text = "3"
            uce_TipoDoc.Value = "3"
            txt_SerieDoc.Text = ""
            txt_NumDoc.Text = ""
            ume_Importe.Value = 0
            ume_base.Value = 0
            ume_igv.Value = 0

        End If

        dt_tmp.Dispose()
        comprobanteBE = Nothing
        comprobanteBL = Nothing

    End Sub

    Private Sub Grabar_Info_Trabajador()
        Dim comprobanteBL As New BL.PlanillaBL.SG_PL_TB_FOLIO_DOC_COMPRO
        Dim comprobanteBE As New BE.PlanillaBE.SG_PL_TB_FOLIO_DOC_COMPRO

        With comprobanteBE
            .FC_IDFOLIO = str_idfolio
            .FC_IDPERSONAL = int_idpersonal
            .FC_ANHO = int_ayo
            .FC_MES = int_mes
            .FC_TDOC = uce_TipoDoc.Value
            .FC_SDOC = txt_SerieDoc.Text
            .FC_NDOC = txt_NumDoc.Text
            .FC_BASE = ume_base.Value
            .FC_IGV = ume_igv.Value
            .FC_IMPORTE = ume_Importe.Value
            .FC_IDEMPRESA = gInt_IdEmpresa
        End With

        comprobanteBL.Insert(comprobanteBE)

        comprobanteBE = Nothing
        comprobanteBL = Nothing

    End Sub

    Private Sub uce_TipoDoc_ValueChanged(sender As System.Object, e As System.EventArgs) Handles uce_TipoDoc.ValueChanged
        txt_cod_Doc_Cab.Text = uce_TipoDoc.Value
    End Sub

    Private Sub ubtn_Cancelar_Click(sender As System.Object, e As System.EventArgs) Handles ubtn_Cancelar.Click
        bol_aceptar = False
        Me.Close()
    End Sub

    Private Sub ubtn_Aceptar_Click(sender As System.Object, e As System.EventArgs) Handles ubtn_Aceptar.Click
        Call Grabar_Info_Trabajador()
        bol_aceptar = True
        Me.Close()
    End Sub

    Private Sub txt_cod_Doc_Cab_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles txt_cod_Doc_Cab.KeyDown
        If e.KeyCode = Keys.Enter Then uce_TipoDoc.Focus()
    End Sub

    Private Sub uce_TipoDoc_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles uce_TipoDoc.KeyDown
        If e.KeyCode = Keys.Enter Then txt_SerieDoc.Focus()
    End Sub

    Private Sub txt_SerieDoc_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles txt_SerieDoc.KeyDown
        If e.KeyCode = Keys.Enter Then txt_NumDoc.Focus()
    End Sub

    Private Sub txt_NumDoc_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles txt_NumDoc.KeyDown
        If e.KeyCode = Keys.Enter Then ume_Importe.Focus()
    End Sub

    Private Sub ume_Importe_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles ume_Importe.KeyDown
        If e.KeyCode = Keys.Enter Then ume_base.Focus()
    End Sub

    Private Sub ume_igv_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles ume_igv.KeyDown
        If e.KeyCode = Keys.Enter Then ubtn_Aceptar.Focus()
    End Sub

    Private Sub ume_base_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles ume_base.KeyDown
        If e.KeyCode = Keys.Enter Then ume_igv.Focus()
    End Sub

    Private Sub ume_Importe_Leave(sender As System.Object, e As System.EventArgs) Handles ume_Importe.Leave
        If ume_Importe.Value > 0 Then
            ume_igv.Value = (CDbl(ume_Importe.Value) * 0.18)
            ume_base.Value = CDbl(ume_Importe.Value) - CDbl(ume_igv.Value)
        End If
    End Sub



    Private Sub txt_SerieDoc_Leave(sender As System.Object, e As System.EventArgs) Handles txt_SerieDoc.Leave
        If txt_SerieDoc.Text.Trim.Length > 0 Then
            txt_SerieDoc.Text = txt_SerieDoc.Text.PadLeft(3, "0")
        End If

    End Sub

    Private Sub txt_NumDoc_Leave(sender As System.Object, e As System.EventArgs) Handles txt_NumDoc.Leave
        If txt_NumDoc.Text.Trim.Length > 0 Then
            Select Case gInt_IdEmpresa
                Case 1
                    txt_NumDoc.Text = txt_NumDoc.Text.PadLeft(7, "0")
                Case Else
                    txt_NumDoc.Text = txt_NumDoc.Text.PadLeft(10, "0")
            End Select
        End If
    End Sub
End Class