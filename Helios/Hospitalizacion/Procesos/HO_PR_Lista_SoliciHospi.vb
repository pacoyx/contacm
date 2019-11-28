Public Class HO_PR_Lista_SoliciHospi

    Public ls_datos As New List(Of String)
    Public bol_aceptar As Boolean = False

    Private Sub HO_PR_Lista_SoliciHospi_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Call Cargar_Datos()
    End Sub

    Private Sub Cargar_Datos()
        Dim pacihospiBL As New BL.HospitalBL.SG_HO_TB_PACI_HOSPI
        ug_lista.DataSource = pacihospiBL.get_Lista_Soli_Hospi(gInt_IdEmpresa)
        pacihospiBL = Nothing
    End Sub

    Private Sub Tool_Aceptar_Click(sender As System.Object, e As System.EventArgs) Handles Tool_Aceptar.Click

        If ug_lista.ActiveRow Is Nothing Then Exit Sub
        If ug_lista.Rows.Count = 0 Then Exit Sub

        ls_datos.Add(ug_lista.ActiveRow.Cells("SH_ID").Value.ToString)
        ls_datos.Add(ug_lista.ActiveRow.Cells("HISTORIA").Value.ToString)
        ls_datos.Add(ug_lista.ActiveRow.Cells("PACIENTE").Value.ToString)
        ls_datos.Add(ug_lista.ActiveRow.Cells("DIAGNOSTICO").Value.ToString)
        ls_datos.Add(ug_lista.ActiveRow.Cells("COD_MEDICO").Value.ToString)
        ls_datos.Add(ug_lista.ActiveRow.Cells("MEDICO").Value.ToString)
        ls_datos.Add(ug_lista.ActiveRow.Cells("FECHA").Value.ToString)
        bol_aceptar = True
        Me.Close()
    End Sub

    Private Sub Tool_Salir_Click(sender As System.Object, e As System.EventArgs) Handles Tool_Salir.Click
        bol_aceptar = False
        Me.Close()
    End Sub

    Private Sub ug_lista_DoubleClickRow(sender As System.Object, e As Infragistics.Win.UltraWinGrid.DoubleClickRowEventArgs) Handles ug_lista.DoubleClickRow
        If ug_lista.ActiveRow Is Nothing Then Exit Sub
        If ug_lista.Rows.Count = 0 Then Exit Sub
        Call Tool_Aceptar_Click(sender, e)
    End Sub
End Class