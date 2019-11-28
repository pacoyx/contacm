Public Class LO_MA_Tipo_Doc_Personal

    Private Sub LO_MA_Tipo_Doc_Personal_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Call Cargar_Documentos()
    End Sub

    Private Sub Cargar_Documentos()
        Dim documentosBL As New BL.LogisticaBL.SG_LO_TB_TIPO_DOCU_PERSO
        ug_documentos.DataSource = documentosBL.get_Documentos(gInt_IdEmpresa)
        documentosBL = Nothing
    End Sub

    Private Sub Tool_Salir_Click(sender As System.Object, e As System.EventArgs) Handles Tool_Salir.Click
        Me.Close()
    End Sub
End Class