Public Class CO_MT_Copiar_Info_Emp

    Dim empresaBL As New BL.ContabilidadBL.SG_CO_TB_EMPRESA

    Public int_empresa_nueva As Integer

    Private Sub ubtn_Aceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ubtn_Aceptar.Click
        empresaBL.Copiar_Info_Empresa(uce_empresa.Value, int_empresa_nueva, gDat_Fecha_Sis.Year)

        Me.Close()
    End Sub


    Private Sub ubtn_cancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ubtn_cancelar.Click
        Me.Close()
    End Sub

    Private Sub CO_MT_Copiar_Info_Emp_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        uce_empresa.DataSource = empresaBL.getEmpresas_1()
        uce_empresa.DisplayMember = "EM_NOMBRE"
        uce_empresa.ValueMember = "EM_ID"
    End Sub
End Class