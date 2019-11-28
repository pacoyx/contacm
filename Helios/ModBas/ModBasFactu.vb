Module ModBasFactu


    Public Sub Completar_Lineas(nombre_doc_lineas_ As String, ByRef dt_data As DataTable, bol_es_Nc_ As Boolean, texto_nc_ As String)

        'Obtenemos el numero de lineas del detalle para la impresion
        Dim lineas As Integer = 10
        Dim paraetrosBL As New BL.FacturacionBL.SG_FA_TB_PARAMETROS
        Dim paraetrosBE As New BE.FacturacionBE.SG_FA_TB_PARAMETROS

        paraetrosBE.AD_IDEMPRESA = New BE.ContabilidadBE.SG_CO_TB_EMPRESA With {.EM_ID = gInt_IdEmpresa}
        paraetrosBE.AD_TIPO = "REPO"
        paraetrosBE.AD_NOMBRE = nombre_doc_lineas_

        lineas = paraetrosBL.get_Valor(paraetrosBE)

        paraetrosBE = Nothing
        paraetrosBL = Nothing


        If bol_es_Nc_ Then
            If dt_data.Rows.Count > 0 Then
                dt_data.Rows(0)("AR_DESCRIPCION") = texto_nc_
            End If
        End If
        


        Dim fila As DataRow
        For i As Integer = 0 To (lineas - dt_data.Rows.Count)
            fila = dt_data.NewRow

            fila("CO_TDOC") = ""
            fila("CO_SDOC") = ""
            fila("CO_NDOC") = ""
            fila("CO_FEC_EMI") = dt_data(0)("CO_FEC_EMI")
            fila("CO_FEC_VEN") = dt_data(0)("CO_FEC_VEN")
            fila("CO_SUBTOTAL") = dt_data(0)("CO_SUBTOTAL")
            fila("CO_IGV") = dt_data(0)("CO_IGV")
            fila("CO_TOTAL") = dt_data(0)("CO_TOTAL")
            fila("CO_IDMONEDA") = DBNull.Value
            fila("CO_TCAM") = DBNull.Value
            fila("CO_TDOC_REF") = DBNull.Value
            fila("CO_SDOC_REF") = ""
            fila("CO_NDOC_REF") = ""
            fila("CO_FEC_EMI_REF") = DBNull.Value
            fila("CO_FEC_VEN_REF") = DBNull.Value
            fila("CO_IDCLIENTE") = 0
            fila("CL_NOMBRE") = ""
            fila("CL_NDOC") = ""
            fila("CO_NOTAS") = dt_data(0)("CO_NOTAS")
            fila("CO_IDFORMA_PAGO") = ""
            fila("FP_DESCRIPCION") = ""
            fila("CD_ITEM") = DBNull.Value
            fila("CD_IDARTICULO") = DBNull.Value
            fila("AR_DESCRIPCION") = ""
            fila("CD_CANT") = DBNull.Value
            fila("CD_PRECIO") = DBNull.Value
            fila("CD_DSCTO") = DBNull.Value
            fila("CD_SUBTOTAL") = DBNull.Value
            fila("CD_IGV") = DBNull.Value
            fila("CD_TOTAL") = DBNull.Value
            fila("EM_RUC") = ""

            dt_data.Rows.Add(fila)

        Next


    End Sub

End Module
