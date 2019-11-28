Imports Microsoft.ApplicationBlocks.Data
Imports System.Data.SqlClient
Imports System.Data

Public Class FertilidadBL

    Public Class SG_FA_Reportes
        Inherits ClsBD
        Public Function get_Fertilidad_BusqCuenta(ByVal dato As Integer) As DataSet
            Return SqlHelper.ExecuteDataset(Cn, "Fertilidad_BusqCuenta", dato)
        End Function
        Public Sub get_Fertilidad_Busqueda(ByVal id As String, ByVal Tipo As Integer, ByRef oDt As DataTable)
            Dim cmd As New SqlCommand("Fertilidad_Busqueda", Cn)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.Add("@p_Dato", System.Data.SqlDbType.VarChar).Value = id
            cmd.Parameters.Add("@p_Tipo", System.Data.SqlDbType.Int).Value = Tipo
            Dim da As New SqlDataAdapter
            da.SelectCommand = cmd
            da.Fill(oDt)
        End Sub
        Public Sub get_Fertilidad_BusquedaPago(ByVal id As String, ByVal Tipo As Integer, ByRef oDt As DataTable)
            Dim cmd As New SqlCommand("Fertilidad_BusquedaPago", Cn)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.Add("@p_Dato", System.Data.SqlDbType.VarChar).Value = id
            cmd.Parameters.Add("@p_Tipo", System.Data.SqlDbType.Int).Value = Tipo
            Dim da As New SqlDataAdapter
            da.SelectCommand = cmd
            da.Fill(oDt)
        End Sub

        Public Function get_Fertilidad_Deudas(ByVal dato As Integer, ByVal tipo As Integer) As DataSet
            Return SqlHelper.ExecuteDataset(Cn, "Fertilidad_Deudas", dato, tipo)
        End Function

        Public Sub get_Fertilidad_CuentaDetalle(ByVal id As Integer, ByVal Tipo As Integer, ByRef oDt As DataTable)
            Dim cmd As New SqlCommand("Fertilidad_CuentaDetalle", Cn)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.Add("@p_Dato", System.Data.SqlDbType.Int).Value = id
            cmd.Parameters.Add("@p_Tipo", System.Data.SqlDbType.Int).Value = Tipo
            Dim da As New SqlDataAdapter
            da.SelectCommand = cmd
            da.Fill(oDt)
        End Sub


        '-----Crystal Report
        Public Sub get_Fertilidad_CuentaCrystl(ByVal id As Integer, ByVal Tipo As Integer, ByRef oDt As DataSet)
            Dim cmd As New SqlCommand("Fertilidad_Cuenta", Cn)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.Add("@p_Dato", System.Data.SqlDbType.Int).Value = id
            cmd.Parameters.Add("@p_Tipo", System.Data.SqlDbType.Int).Value = Tipo
            Dim da As New SqlDataAdapter
            da.SelectCommand = cmd
            da.Fill(oDt, "Reporte01")
        End Sub
        Public Sub get_Fertilidad_CuentaDetalleCrystl(ByVal id As Integer, ByVal Tipo As Integer, ByRef oDt As DataSet)
            Dim cmd As New SqlCommand("Fertilidad_CuentaDetalle", Cn)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.Add("@p_Dato", System.Data.SqlDbType.Int).Value = id
            cmd.Parameters.Add("@p_Tipo", System.Data.SqlDbType.Int).Value = Tipo
            Dim da As New SqlDataAdapter
            da.SelectCommand = cmd
            da.Fill(oDt, "Detalle")
        End Sub
 
    End Class
    Public Class SG_CF_TB_CUENTA_CRIO_C
        Inherits ClsBD
        Public Sub Insert(entidad As BE.FertilidadBE.SG_CF_TB_CUENTA_CRIO_C)
            With entidad
                SqlHelper.ExecuteNonQuery(Cn, "SG_CF_SP_I_CUENTA_CRIO_C", .IDHISTORIA, .IDFICHA, .IDARTICULO, _
                                          .FEC_PROCESO, .NOMBRES, .APE_PAT, .APE_MAT, .IDTIPO_DOC, .NUM_DOC, _
                                          .IDMEDICO, .FEC_CONGE, .IMP_CONGELACION, .IDMONEDA_CONGE, _
                                          .IMP_SEMESTRAL, .IDMONEDA_SEME, .DIR1, .DIR2, .UBIGEO, .EMAIL, _
                                          .OBS, .REFERIDO,.RESPONSABLE, .ESTADO, .USUARIO, .TERMINAL, .FECREG, .IDEMPRESA)
            End With
        End Sub
        Public Function get_grilla(empresa As Integer) As DataTable
            Return SqlHelper.ExecuteDataset(Cn, "SG_CF_SP_S_CUENTA_CRIO_C", empresa).Tables(0)
        End Function
        Public Function get_referencia() As DataTable
            Return SqlHelper.ExecuteDataset(Cn, "SG_CF_SP_S_RECOMENDADO").Tables(0)
        End Function
        Public Function get_tipo_doc() As DataTable
            Return SqlHelper.ExecuteDataset(Cn, "SG_CF_SP_S_TIPO_DOC").Tables(0)
        End Function
        Public Function get_arti() As DataTable
            Return SqlHelper.ExecuteDataset(cn, "SG_CF_SP_S_ARTICULO").tables(0)
        End Function
        Public Function get_mone() As DataTable
            Return SqlHelper.ExecuteDataset(Cn, "SG_CF_SP_S_MONEDA").Tables(0)
        End Function
        Public Function get_medic() As DataTable
            Return SqlHelper.ExecuteDataset(Cn, "SG_CF_SP_S_MEDICO").Tables(0)
        End Function
        Public Function get_historia_cli() As DataTable
            Return SqlHelper.ExecuteDataset(Cn, "SG_CF_SP_S_HISTO_CLINI").Tables(0)
        End Function
    End Class
    
End Class
