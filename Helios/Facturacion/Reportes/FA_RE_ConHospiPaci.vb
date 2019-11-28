Public Class FA_RE_ConHospiPaci

    Private Sub FA_RE_ConHospiPaci_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Call Cargar_Datos()
    End Sub

    Private Sub Cargar_Datos()
        Dim pacienteHospiBL As New BL.HospitalBL.SG_HO_TB_PACI_HOSPI
        ug_ListaCamas.DataSource = pacienteHospiBL.get_Pacientes_Hospi_Facturacion(gInt_IdEmpresa)
        pacienteHospiBL = Nothing
    End Sub

    Private Sub Tool_Actualizar_Click(sender As System.Object, e As System.EventArgs) Handles Tool_Actualizar.Click
        Call Cargar_Datos()
    End Sub

    Private Sub Tool_Salir_Click(sender As System.Object, e As System.EventArgs) Handles Tool_Salir.Click
        Me.Close()
    End Sub
End Class