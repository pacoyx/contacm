Public Class AD_PR_PreFacturacion
    Dim IGVTasa As Double
   
    Private Sub Obtener_Datos_Seguro()

        Dim AsegBL As New BL.FacturacionBL.SG_FA_TB_CIA_ASEG
        Dim AsegBE As New BE.FacturacionBE.SG_FA_TB_CIA_ASEG
        AsegBE.CA_ID = ucm_SeguroEps.Value
        AsegBE.CA_IDEMPRESA = gInt_IdEmpresa
        AsegBL.get_Aseguradora_x_id(AsegBE)
        txt_EPS.Value = AsegBE.CA_IDASEGU_SITED

        Dim sitedsBL As New BL.AdmisionBL.Siteds
        Dim objS As New DataTable
        sitedsBL.get_Cobertura_x_Paciente(txt_ruc_cliente.Value.ToString, txt_EPS.Text, objS)
        If objS.Rows.Count <= 0 Then sitedsBL.get_Cobertura_x_Paciente2(txt_ruc_cliente.Value.ToString, txt_EPS.Text, objS)
        If objS.Rows.Count > 0 Then
            txt_CodAutoriza.Value = objS.Rows(0)(0)
            txt_FechaAutoriza.Value = objS.Rows(0)(1)
            txt_CodAsegurado.Value = objS.Rows(0)(2)

            txt_PagoFijo.Value = objS.Rows(0)(5)
            txt_PagoVariable.Value = objS.Rows(0)(6)
            TXT_TIPOAFILIACION.Text = objS.Rows(0)(7)

            txt_FijoC.Value = Math.Round(txt_PagoFijo.Value / ((IGVTasa / 100) + 1), 2)

            'ACTUALIZAR CON LA TABLA COBERTURA Y TIPO ORIGEN
            Dim cBL As New BL.AdmisionBL.SG_AD_TB_COBERTURA
            Dim cBE As New BE.AdmisionBE.SG_AD_TB_COBERTURA
            cBE.CB_SITEDS = objS.Rows(0)(3).ToString
            cBL.SEL02(cBE)
            If cBE.HasRow Then
                'ucm_Tipo.Value = cBE.CB_IDTIPO_ORIGEN
                txt_DesCobertura.Value = cBE.CB_ID
            End If
            ' txt_CodCobertura.Value = objS.Rows(0)(3)
            ' txt_DesCobertura.Value = objS.Rows(0)(4)

        Else
            Avisar("El Codigo de Autorización no se a encontrado!")
        End If

    End Sub

End Class