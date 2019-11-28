Public Class LO_LT_DocRef

    Private Sub LO_LT_DocRef_Activated(sender As Object, e As System.EventArgs) Handles Me.Activated
        uce_TipoDocRef.Focus()
    End Sub

    Private Sub LO_LT_DocRef_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Call Cargar_Documentos()
        ubtn_aceptar.Appearance.Image = My.Resources._16__Ok_
    End Sub

    Private Sub Cargar_Documentos()
        Dim documentoBL As New BL.LogisticaBL.SG_LO_TB_TIPO_DOCUMENTO
        uce_TipoDocRef.DataSource = documentoBL.get_Documentos(gInt_IdEmpresa)
        uce_TipoDocRef.DisplayMember = "DES"
        uce_TipoDocRef.ValueMember = "TD_ID"
        documentoBL = Nothing
    End Sub


    Private Sub ubtn_aceptar_Click(sender As System.Object, e As System.EventArgs) Handles ubtn_aceptar.Click
        Me.Close()
    End Sub

    Private Sub uce_TipoDocRef_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles uce_TipoDocRef.KeyDown
        If e.KeyCode = Keys.Enter Then SendKeys.Send(vbTab)
    End Sub

    Private Sub txt_SerieDocRef_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles txt_SerieDocRef.KeyDown
        If e.KeyCode = Keys.Enter Then SendKeys.Send(vbTab)
    End Sub

    Private Sub txt_NumDocRef_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles txt_NumDocRef.KeyDown
        If e.KeyCode = Keys.Enter Then ubtn_aceptar.Focus()
    End Sub

    Private Sub txt_SerieDocRef_Leave(sender As System.Object, e As System.EventArgs) Handles txt_SerieDocRef.Leave
        txt_SerieDocRef.Text = txt_SerieDocRef.Text.Trim.PadLeft(4, "0")
    End Sub

    Private Sub txt_NumDocRef_Leave(sender As System.Object, e As System.EventArgs) Handles txt_NumDocRef.Leave
        txt_NumDocRef.Text = txt_NumDocRef.Text.Trim.PadLeft(10, "0")
    End Sub
End Class